extern alias e27;
extern alias e2;
extern alias e40;
extern alias e5;
extern alias e1;
extern alias e20;

using n58 = _VL_Sync_.IO;
using n35 = _CoreLibBasics_.Primitive.Int3;
using n18 = _VL_Stride_Graphics_.Stride.Buffers.Internal;
using n28 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.Texture.Advanced;
using n10 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n19 = _CoreLibBasics_.Control.Advanced;
using n54 = _VL_Stride_Graphics_.Video.ImagePlayer_FrameBased_Stride;
using n53 = e2::VL.Lib.Primitive;
using n15 = _CoreLibBasics_.Primitive.Object.Advanced;
using n40 = _CoreLibBasics_.System.Resources.Provider.Advanced;
using n21 = _CoreLibBasics_.Control;
using n62 = _CoreLibBasics_.System.Conversion.Adaptive;
using n59 = _VL_Stride_Graphics_.Video.ImagePlayer_Stride;
using n45 = _VL_Stride_Graphics_.Stride.Textures.Utils.Obsolete;
using n60 = _CoreLibBasics_.Math.Generic.Advanced;
using n25 = _VL_Stride_Graphics_.Stride.Buffers.Advanced;
using n33 = _VL_CoreLib_Experimental_.Control.Try__1_Output.Obsolete.Experimental;
using n65 = _System_Memory_.System.Advanced.Adaptive;
using n14 = e40::VL.Stride.Graphics;
using n46 = _CoreLibBasics_.Primitive.IntPtr.Advanced;
using n8 = e27::Stride.Graphics;
using n32 = e2::VL.Lib.Control;
using n57 = e5::VL.Lib.Animation;
using n70 = _CoreLibBasics_.Primitive.String;
using n5 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n61 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n11 = global::System.Collections.Generic;
using n12 = e1::Stride.Core.Mathematics;
using n44 = _CoreLibBasics_.Math.Adaptive;
using n49 = _CoreLibBasics_.IO.Path;
using n20 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n24 = _VL_Stride_Graphics_.Stride.Textures.Utils.Advanced;
using n22 = _VL_Stride_Graphics_;
using n6 = e2::VL.Lib.Primitive.CacheRegion;
using n16 = _CoreLibBasics_.Primitive.Boolean;
using n23 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n34 = _VL_Stride_Graphics_.Stride.Textures.Internal;
using n48 = global::System.Threading;
using n64 = e40::VL.Stride;
using n50 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n17 = e20::Stride.Graphics;
using n43 = global::System.Threading.Tasks;
using n31 = _VL_Stride_Graphics_.Stride.Textures.Advanced;
using n3 = _VL_Stride_Graphics_.Stride.Buffers.ReadBack;
using n39 = e5::VL.Lib.Basics.Resources;
using n55 = e5::VL.Lib.Runtime;
using n2 = global::System;
using n51 = _VL_Reactive_.Reactive.AsyncTask;
using n29 = _CoreLibBasics_.Primitive.Int2;
using n68 = e2::VL.Lib;
using n47 = _VL_Stride_Graphics_.Video;
using n13 = _VL_Stride_Graphics_.Stride.Buffers;
using n27 = _VL_Stride_Graphics_.Stride.Textures;
using n67 = _VL_Stride_Graphics_.Stride;
using n7 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n52 = _VL_Reactive_.Reactive.HoldLatest;
using n66 = e5::VL.Lib.Basics.Imaging;
using n63 = _VL_Stride_Graphics_.Stride.Windowing;
using n56 = _VL_Collections_.Collections.Sequence;
using n9 = global::System.Runtime.CompilerServices;
using n26 = e5::VL.Lib.Collections;
using n30 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Core.Utils.Advanced;
using n36 = e5::VL.Lib.IO;
using n37 = _VL_Collections_.Collections.Spread;
using n41 = _CoreLibBasics_.Primitive.ValueTuple__2_Items.Advanced;
using n38 = _VL_Stride_Graphics_.Stride.Textures.TextureReader_Async.Advanced;
using n42 = _CoreLibBasics_.System.Resources.Advanced;
using n69 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_Stride_Graphics_.Stride.Buffers.ReadBack
{
    [n1.ElementAttribute(TracingId = 107561U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RH2RUpkkU3qOkXmvMgGVUB", Name = "ReadBack_RH2RUpkkU3qOkXmvMgGVUB")]
    [n2.SerializableAttribute]
    public class ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> CreateDefault()
        {
            var instance = new ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> Update(n8.Buffer Buffer_In, [n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Elements_Per_Buffer_Structure_In, T Example_Element_Of_Type_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out T[] Output_Out)
        {
            n5.ObjectHelpers.IsAssigned(x: Buffer_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            var Output_2 = Result_0 && Enabled_In;
            bool Force_3 = false;
            bool Dispose_Cached_Outputs_4 = false;
            var manager_5 = this.__cache_EOLLBuyqSuFMKWtFfL1s6Q;
            if (manager_5 is null)
            {
                manager_5 = new n6.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<T[]>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<T>()));
            }

            var inputs_6 = (Element_Count_In, Elements_Per_Buffer_Structure_In);
            var outputs_7 = manager_5.Outputs;
            var Has_Changed_8 = Force_3 || manager_5.InputsChanged(inputs_6);
            if (Has_Changed_8)
            {
                if (Dispose_Cached_Outputs_4)
                    manager_5.DisposeOutputs();
                var Output_10 = Element_Count_In * Elements_Per_Buffer_Structure_In;
                n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "BhJf8MohmVcOGbWit9RGYd", 107568U);
                n7._Operations_.Create<T>(Node_Context: Node_Context_11, Length_In: Output_10, Result_Out: out T[] Result_12);
                int Index_13 = 0;
                n7._Operations_.SetItem<T>(Input_In: Result_12, Index_In: Index_13, Value_In: Example_Element_Of_Type_In, Output_Out: out T[] Output_14);
                outputs_7 = n2.ValueTuple.Create(Output_14);
                manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, default, outputs_7);
            }
            else
            {
                manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
            }

            var __auto_15 = outputs_7.Item1;
            var State_Output_17 = this.__p_Np7WVhIe5C5Qd8pFnDJ7B6.Update(Output_Out: out n8.GraphicsContext Output_16);
            var Command_List_18 = Output_16.CommandList;
            n8.CommandList __auto_19 = Command_List_18;
            if (Output_2)
            {
                Buffer_In.GetData<T>(commandList: __auto_19, toData: __auto_15);
            }

            Output_Out = __auto_15;
            n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = manager_5 != this.__cache_EOLLBuyqSuFMKWtFfL1s6Q || State_Output_17 != this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 || Command_List_18 != this.Command_List ? new ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T>(this)
                {__cache_EOLLBuyqSuFMKWtFfL1s6Q = manager_5, __p_Np7WVhIe5C5Qd8pFnDJ7B6 = State_Output_17, Command_List = Command_List_18} : that_21;
            else
            {
                this.__cache_EOLLBuyqSuFMKWtFfL1s6Q = manager_5;
                this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 = State_Output_17;
                this.Command_List = Command_List_18;
            }

            return that_21;
        }

        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Np7WVhIe5C5Qd8pFnDJ7B6", 107616U);
            var Output_1 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.Create(Node_Context_In: Node_Context_0);
            n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> that_2 = this;
            this.Command_List = default(n8.CommandList);
            this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 = Output_1;
            this.__cache_EOLLBuyqSuFMKWtFfL1s6Q = null;
            return that_2;
        }

        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> __CreateDefault__()
        {
            n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> that_0 = this;
            this.Command_List = default(n8.CommandList);
            this.__cache_EOLLBuyqSuFMKWtFfL1s6Q = null;
            this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_EOLLBuyqSuFMKWtFfL1s6Q);
            n1.CompilationHelper.SafeDispose(this.__p_Np7WVhIe5C5Qd8pFnDJ7B6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107596U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EzzVoV1VDoDOggfh43VKtY", Name = "Command List")]
        public n8.CommandList Command_List;
        [n1.ElementAttribute(TracingId = 107564U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EOLLBuyqSuFMKWtFfL1s6Q", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<T[]>> __cache_EOLLBuyqSuFMKWtFfL1s6Q = null;
        [n1.ElementAttribute(TracingId = 107616U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Np7WVhIe5C5Qd8pFnDJ7B6", Name = "GraphicsContext", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_Np7WVhIe5C5Qd8pFnDJ7B6;
        public ReadBack_RH2RUpkkU3qOkXmvMgGVUB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadBack_RH2RUpkkU3qOkXmvMgGVUB(ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> other): base(other)
        {
            this.Command_List = other.Command_List;
            this.__cache_EOLLBuyqSuFMKWtFfL1s6Q = other.__cache_EOLLBuyqSuFMKWtFfL1s6Q;
            this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 = other.__p_Np7WVhIe5C5Qd8pFnDJ7B6;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Command_List", in Command_List), n1.CompilationHelper.GetValueOrExisting(values, "__cache_EOLLBuyqSuFMKWtFfL1s6Q", in __cache_EOLLBuyqSuFMKWtFfL1s6Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_Np7WVhIe5C5Qd8pFnDJ7B6", in __p_Np7WVhIe5C5Qd8pFnDJ7B6));
        }

        internal ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> __WITH__(n8.CommandList Command_List, n6.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<T[]>> __cache_EOLLBuyqSuFMKWtFfL1s6Q, n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_Np7WVhIe5C5Qd8pFnDJ7B6)
        {
            n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Command_List != this.Command_List || __cache_EOLLBuyqSuFMKWtFfL1s6Q != this.__cache_EOLLBuyqSuFMKWtFfL1s6Q || __p_Np7WVhIe5C5Qd8pFnDJ7B6 != this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 ? new ReadBack_RH2RUpkkU3qOkXmvMgGVUB<T>(this)
                {Command_List = Command_List, __cache_EOLLBuyqSuFMKWtFfL1s6Q = __cache_EOLLBuyqSuFMKWtFfL1s6Q, __p_Np7WVhIe5C5Qd8pFnDJ7B6 = __p_Np7WVhIe5C5Qd8pFnDJ7B6} : that_0;
            else
            {
                this.Command_List = Command_List;
                this.__cache_EOLLBuyqSuFMKWtFfL1s6Q = __cache_EOLLBuyqSuFMKWtFfL1s6Q;
                this.__p_Np7WVhIe5C5Qd8pFnDJ7B6 = __p_Np7WVhIe5C5Qd8pFnDJ7B6;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107653U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CTLWvUbjPuRQD6igVPwvzF", Name = "ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF")]
    [n2.SerializableAttribute]
    public class ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF CreateDefault()
        {
            var instance = new ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF Update(n8.Buffer Buffer_In, [n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Elements_Per_Buffer_Structure_In, out n12.Vector4[] Output_Out)
        {
            var Zero_0 = n12.Vector4.Zero;
            bool Enabled_1 = true;
            var State_Output_3 = this.__p_KIh3lltro2BLjVKGulZIYP.Update(Buffer_In: Buffer_In, Element_Count_In: Element_Count_In, Elements_Per_Buffer_Structure_In: Elements_Per_Buffer_Structure_In, Example_Element_Of_Type_In: Zero_0, Enabled_In: Enabled_1, Output_Out: out n12.Vector4[] Output_2);
            Output_Out = Output_2;
            n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_KIh3lltro2BLjVKGulZIYP ? new ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(this)
                {__p_KIh3lltro2BLjVKGulZIYP = State_Output_3} : that_4;
            else
            {
                this.__p_KIh3lltro2BLjVKGulZIYP = State_Output_3;
            }

            return that_4;
        }

        public n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "KIh3lltro2BLjVKGulZIYP", 107656U);
            var Output_1 = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector4>.Create(Node_Context: Node_Context_0);
            n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF that_2 = this;
            this.__p_KIh3lltro2BLjVKGulZIYP = Output_1;
            return that_2;
        }

        public n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF __CreateDefault__()
        {
            n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF that_0 = this;
            this.__p_KIh3lltro2BLjVKGulZIYP = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector4>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KIh3lltro2BLjVKGulZIYP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107656U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KIh3lltro2BLjVKGulZIYP", Name = "ReadBack", IsManaged = true, IsAutoGenerated = true)]
        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector4> __p_KIh3lltro2BLjVKGulZIYP;
        public ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF other): base(other)
        {
            this.__p_KIh3lltro2BLjVKGulZIYP = other.__p_KIh3lltro2BLjVKGulZIYP;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KIh3lltro2BLjVKGulZIYP", in __p_KIh3lltro2BLjVKGulZIYP));
        }

        internal ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF __WITH__(n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector4> __p_KIh3lltro2BLjVKGulZIYP)
        {
            n3.ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KIh3lltro2BLjVKGulZIYP != this.__p_KIh3lltro2BLjVKGulZIYP ? new ReadBackVec4_CTLWvUbjPuRQD6igVPwvzF(this)
                {__p_KIh3lltro2BLjVKGulZIYP = __p_KIh3lltro2BLjVKGulZIYP} : that_0;
            else
            {
                this.__p_KIh3lltro2BLjVKGulZIYP = __p_KIh3lltro2BLjVKGulZIYP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107687U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DXB7LW5AyOQPlCtxrmxokb", Name = "ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb")]
    [n2.SerializableAttribute]
    public class ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb CreateDefault()
        {
            var instance = new ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb Update(n8.Buffer Buffer_In, [n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Elements_Per_Buffer_Structure_In, out float[] Output_Out)
        {
            float __pad_Amchh0YrFLpMV9W7iNt0I8_0 = __slot_Amchh0YrFLpMV9W7iNt0I8;
            bool Enabled_1 = true;
            var State_Output_3 = this.__p_S42n7accQuGOmKDG3tO0Ee.Update(Buffer_In: Buffer_In, Element_Count_In: Element_Count_In, Elements_Per_Buffer_Structure_In: Elements_Per_Buffer_Structure_In, Example_Element_Of_Type_In: __pad_Amchh0YrFLpMV9W7iNt0I8_0, Enabled_In: Enabled_1, Output_Out: out float[] Output_2);
            Output_Out = Output_2;
            n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_S42n7accQuGOmKDG3tO0Ee ? new ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(this)
                {__p_S42n7accQuGOmKDG3tO0Ee = State_Output_3} : that_4;
            else
            {
                this.__p_S42n7accQuGOmKDG3tO0Ee = State_Output_3;
            }

            return that_4;
        }

        public n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "S42n7accQuGOmKDG3tO0Ee", 107690U);
            var Output_1 = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<float>.Create(Node_Context: Node_Context_0);
            n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb that_2 = this;
            this.__p_S42n7accQuGOmKDG3tO0Ee = Output_1;
            return that_2;
        }

        public n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb __CreateDefault__()
        {
            n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb that_0 = this;
            this.__p_S42n7accQuGOmKDG3tO0Ee = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_S42n7accQuGOmKDG3tO0Ee);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107701U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Amchh0YrFLpMV9W7iNt0I8", Name = "__slot_Amchh0YrFLpMV9W7iNt0I8")]
        public static float __slot_Amchh0YrFLpMV9W7iNt0I8 = 0F;
        [n1.ElementAttribute(TracingId = 107690U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "S42n7accQuGOmKDG3tO0Ee", Name = "ReadBack", IsManaged = true, IsAutoGenerated = true)]
        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<float> __p_S42n7accQuGOmKDG3tO0Ee;
        static ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb()
        {
        }

        public ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb other): base(other)
        {
            this.__p_S42n7accQuGOmKDG3tO0Ee = other.__p_S42n7accQuGOmKDG3tO0Ee;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_S42n7accQuGOmKDG3tO0Ee", in __p_S42n7accQuGOmKDG3tO0Ee));
        }

        internal ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb __WITH__(n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<float> __p_S42n7accQuGOmKDG3tO0Ee)
        {
            n3.ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_S42n7accQuGOmKDG3tO0Ee != this.__p_S42n7accQuGOmKDG3tO0Ee ? new ReadBackFloat_DXB7LW5AyOQPlCtxrmxokb(this)
                {__p_S42n7accQuGOmKDG3tO0Ee = __p_S42n7accQuGOmKDG3tO0Ee} : that_0;
            else
            {
                this.__p_S42n7accQuGOmKDG3tO0Ee = __p_S42n7accQuGOmKDG3tO0Ee;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107720U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "G9MH2IMMz2JMo3cQulW6NI", Name = "ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI")]
    [n2.SerializableAttribute]
    public class ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI CreateDefault()
        {
            var instance = new ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI Update(n8.Buffer Buffer_In, [n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Elements_Per_Buffer_Structure_In, out n12.Vector3[] Output_Out)
        {
            var Zero_0 = n12.Vector3.Zero;
            bool Enabled_1 = true;
            var State_Output_3 = this.__p_FUC6J6OmNSDLKuIqLgX4Ri.Update(Buffer_In: Buffer_In, Element_Count_In: Element_Count_In, Elements_Per_Buffer_Structure_In: Elements_Per_Buffer_Structure_In, Example_Element_Of_Type_In: Zero_0, Enabled_In: Enabled_1, Output_Out: out n12.Vector3[] Output_2);
            Output_Out = Output_2;
            n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_FUC6J6OmNSDLKuIqLgX4Ri ? new ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(this)
                {__p_FUC6J6OmNSDLKuIqLgX4Ri = State_Output_3} : that_4;
            else
            {
                this.__p_FUC6J6OmNSDLKuIqLgX4Ri = State_Output_3;
            }

            return that_4;
        }

        public n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "FUC6J6OmNSDLKuIqLgX4Ri", 107723U);
            var Output_1 = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector3>.Create(Node_Context: Node_Context_0);
            n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI that_2 = this;
            this.__p_FUC6J6OmNSDLKuIqLgX4Ri = Output_1;
            return that_2;
        }

        public n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI __CreateDefault__()
        {
            n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI that_0 = this;
            this.__p_FUC6J6OmNSDLKuIqLgX4Ri = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector3>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FUC6J6OmNSDLKuIqLgX4Ri);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107723U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FUC6J6OmNSDLKuIqLgX4Ri", Name = "ReadBack", IsManaged = true, IsAutoGenerated = true)]
        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector3> __p_FUC6J6OmNSDLKuIqLgX4Ri;
        public ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI other): base(other)
        {
            this.__p_FUC6J6OmNSDLKuIqLgX4Ri = other.__p_FUC6J6OmNSDLKuIqLgX4Ri;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FUC6J6OmNSDLKuIqLgX4Ri", in __p_FUC6J6OmNSDLKuIqLgX4Ri));
        }

        internal ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI __WITH__(n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector3> __p_FUC6J6OmNSDLKuIqLgX4Ri)
        {
            n3.ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FUC6J6OmNSDLKuIqLgX4Ri != this.__p_FUC6J6OmNSDLKuIqLgX4Ri ? new ReadBackVec3_G9MH2IMMz2JMo3cQulW6NI(this)
                {__p_FUC6J6OmNSDLKuIqLgX4Ri = __p_FUC6J6OmNSDLKuIqLgX4Ri} : that_0;
            else
            {
                this.__p_FUC6J6OmNSDLKuIqLgX4Ri = __p_FUC6J6OmNSDLKuIqLgX4Ri;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107754U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "E0mMo8bcQLQPNgFse9hCMF", Name = "ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF")]
    [n2.SerializableAttribute]
    public class ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF CreateDefault()
        {
            var instance = new ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF Update(n8.Buffer Buffer_In, [n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Elements_Per_Buffer_Structure_In, out n12.Vector2[] Output_Out)
        {
            var Zero_0 = n12.Vector2.Zero;
            bool Enabled_1 = true;
            var State_Output_3 = this.__p_BaXznCtdp8wPMt3lSm028c.Update(Buffer_In: Buffer_In, Element_Count_In: Element_Count_In, Elements_Per_Buffer_Structure_In: Elements_Per_Buffer_Structure_In, Example_Element_Of_Type_In: Zero_0, Enabled_In: Enabled_1, Output_Out: out n12.Vector2[] Output_2);
            Output_Out = Output_2;
            n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_BaXznCtdp8wPMt3lSm028c ? new ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(this)
                {__p_BaXznCtdp8wPMt3lSm028c = State_Output_3} : that_4;
            else
            {
                this.__p_BaXznCtdp8wPMt3lSm028c = State_Output_3;
            }

            return that_4;
        }

        public n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "BaXznCtdp8wPMt3lSm028c", 107757U);
            var Output_1 = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector2>.Create(Node_Context: Node_Context_0);
            n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF that_2 = this;
            this.__p_BaXznCtdp8wPMt3lSm028c = Output_1;
            return that_2;
        }

        public n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF __CreateDefault__()
        {
            n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF that_0 = this;
            this.__p_BaXznCtdp8wPMt3lSm028c = n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BaXznCtdp8wPMt3lSm028c);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107757U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BaXznCtdp8wPMt3lSm028c", Name = "ReadBack", IsManaged = true, IsAutoGenerated = true)]
        public n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector2> __p_BaXznCtdp8wPMt3lSm028c;
        public ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF other): base(other)
        {
            this.__p_BaXznCtdp8wPMt3lSm028c = other.__p_BaXznCtdp8wPMt3lSm028c;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BaXznCtdp8wPMt3lSm028c", in __p_BaXznCtdp8wPMt3lSm028c));
        }

        internal ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF __WITH__(n3.ReadBack_RH2RUpkkU3qOkXmvMgGVUB<n12.Vector2> __p_BaXznCtdp8wPMt3lSm028c)
        {
            n3.ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BaXznCtdp8wPMt3lSm028c != this.__p_BaXznCtdp8wPMt3lSm028c ? new ReadBackVec2_E0mMo8bcQLQPNgFse9hCMF(this)
                {__p_BaXznCtdp8wPMt3lSm028c = __p_BaXznCtdp8wPMt3lSm028c} : that_0;
            else
            {
                this.__p_BaXznCtdp8wPMt3lSm028c = __p_BaXznCtdp8wPMt3lSm028c;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Buffers
{
    [n1.ElementAttribute(TracingId = 107788U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PFT0uUgEsf0MJ7bFzVugSk", Name = "SetData_PFT0uUgEsf0MJ7bFzVugSk")]
    [n2.SerializableAttribute]
    public class SetData_PFT0uUgEsf0MJ7bFzVugSk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.SetData_PFT0uUgEsf0MJ7bFzVugSk Create(n1.NodeContext Node_Context)
        {
            var instance = new SetData_PFT0uUgEsf0MJ7bFzVugSk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.SetData_PFT0uUgEsf0MJ7bFzVugSk CreateDefault()
        {
            var instance = new SetData_PFT0uUgEsf0MJ7bFzVugSk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.SetData_PFT0uUgEsf0MJ7bFzVugSk Update(n8.Buffer Input_In, n14.IGraphicsDataProvider Data_In, [n4.SerializedDefaultValueAttribute("0", false)] int Offset_In_Bytes_In, bool Apply_In, out n8.Buffer Output_Out)
        {
            n8.GraphicsContext __auto_0 = this.Output;
            n8.Buffer __auto_1;
            if (Apply_In)
            {
                var Command_List_3 = __auto_0.CommandList;
                var Output_4 = n14.BufferExtensions.SetDataFromProvider(buffer: Input_In, commandList: Command_List_3, data: Data_In, offsetInBytes: Offset_In_Bytes_In);
                __auto_1 = Output_4;
            }
            else
            {
                __auto_1 = Input_In;
            }

            Output_Out = __auto_1;
            return this;
        }

        public n13.SetData_PFT0uUgEsf0MJ7bFzVugSk __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "IXjKlKru3AlNaL4RCmniL3", 107810U);
            var Output_1 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.Create(Node_Context_In: Node_Context_0);
            var State_Output_3 = Output_1.Update(Output_Out: out n8.GraphicsContext Output_2);
            n8.GraphicsContext __auto_4 = Output_2;
            n13.SetData_PFT0uUgEsf0MJ7bFzVugSk that_5 = this;
            this.Output = Output_2;
            this.__p_IXjKlKru3AlNaL4RCmniL3 = State_Output_3;
            return that_5;
        }

        public n13.SetData_PFT0uUgEsf0MJ7bFzVugSk __CreateDefault__()
        {
            n13.SetData_PFT0uUgEsf0MJ7bFzVugSk that_0 = this;
            this.Output = default(n8.GraphicsContext);
            this.__p_IXjKlKru3AlNaL4RCmniL3 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IXjKlKru3AlNaL4RCmniL3);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107813U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DmgB44v2j5uOLLfLMwymTN", Name = "Output")]
        public n8.GraphicsContext Output;
        [n1.ElementAttribute(TracingId = 107810U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IXjKlKru3AlNaL4RCmniL3", Name = "GraphicsContext", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_IXjKlKru3AlNaL4RCmniL3;
        public SetData_PFT0uUgEsf0MJ7bFzVugSk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetData_PFT0uUgEsf0MJ7bFzVugSk(SetData_PFT0uUgEsf0MJ7bFzVugSk other): base(other)
        {
            this.Output = other.Output;
            this.__p_IXjKlKru3AlNaL4RCmniL3 = other.__p_IXjKlKru3AlNaL4RCmniL3;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Output", in Output), n1.CompilationHelper.GetValueOrExisting(values, "__p_IXjKlKru3AlNaL4RCmniL3", in __p_IXjKlKru3AlNaL4RCmniL3));
        }

        internal SetData_PFT0uUgEsf0MJ7bFzVugSk __WITH__(n8.GraphicsContext Output, n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_IXjKlKru3AlNaL4RCmniL3)
        {
            n13.SetData_PFT0uUgEsf0MJ7bFzVugSk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output || __p_IXjKlKru3AlNaL4RCmniL3 != this.__p_IXjKlKru3AlNaL4RCmniL3 ? new SetData_PFT0uUgEsf0MJ7bFzVugSk(this)
                {Output = Output, __p_IXjKlKru3AlNaL4RCmniL3 = __p_IXjKlKru3AlNaL4RCmniL3} : that_0;
            else
            {
                this.Output = Output;
                this.__p_IXjKlKru3AlNaL4RCmniL3 = __p_IXjKlKru3AlNaL4RCmniL3;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107843U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "C82b44KM7nmOgoP82JqMWO", Name = "DynamicBuffer_C82b44KM7nmOgoP82JqMWO")]
    [n2.SerializableAttribute]
    public class DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> CreateDefault()
        {
            var instance = new DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> Update<AdM>(T Input_In, int Element_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Offset_In_Bytes_In, bool Is_Structured_Buffer_In, bool Is_Vertex_Buffer_In, bool Is_Index_Buffer_In, bool Allow_Raw_Views_In, bool Recreate_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            n15._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_1);
            n5.ObjectHelpers.IsAssigned(x: Result_1, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            n14.IGraphicsDataProvider __auto_4;
            int __auto_5;
            var state_6 = n1.CompilationHelper.Restore<__MmRL8LTTWmIMFVzYXUoR3G>(this.__if_FixYrbUmWWmNhxx5ScuYkn, __GetContext__());
            if (Result_2)
            {
                if (state_6 == null)
                {
                    state_6 = new __MmRL8LTTWmIMFVzYXUoR3G(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "NqG63rkt8IqNbNdRz2xeta", 107937U);
                    var Output_8 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_NqG63rkt8IqNbNdRz2xeta = Output_8;
                }

                int Offset_In_Bytes_9 = 0;
                bool Force_10 = false;
                bool SetInput_11 = true;
                var Output_12 = state_6.__p_NqG63rkt8IqNbNdRz2xeta;
                if (SetInput_11)
                {
                    Output_12 = state_6.__p_NqG63rkt8IqNbNdRz2xeta.SetInput<AdM>(Input_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_9, Force_In: Force_10);
                }

                var State_Output_14 = Output_12.Update(Output_Out: out n14.IGraphicsDataProvider Output_13);
                var Size_In_Bytes_15 = Output_13.SizeInBytes;
                __auto_4 = Output_13;
                __auto_5 = Size_In_Bytes_15;
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_14 != state_6.__p_NqG63rkt8IqNbNdRz2xeta ? new __MmRL8LTTWmIMFVzYXUoR3G(state_6)
                    {__p_NqG63rkt8IqNbNdRz2xeta = State_Output_14} : state_6;
                else
                {
                    state_6.__p_NqG63rkt8IqNbNdRz2xeta = State_Output_14;
                }
            }
            else
            {
                __auto_4 = default(n14.IGraphicsDataProvider);
                __auto_5 = 0;
            }

            var Output_16 = Result_2 && Apply_In;
            bool Dispose_Cached_Outputs_17 = false;
            var manager_18 = this.__cache_QRuKOIDKTCjQEXispb5UiS;
            if (manager_18 is null)
            {
                manager_18 = new n6.Manager<n2.ValueTuple<int, int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_19 = (Element_Size_In_Bytes_In, __auto_5, Is_Structured_Buffer_In, Is_Vertex_Buffer_In, Is_Index_Buffer_In, Allow_Raw_Views_In);
            var outputs_20 = manager_18.Outputs;
            var Has_Changed_21 = Recreate_In || manager_18.InputsChanged(inputs_19);
            if (Has_Changed_21)
            {
                if (Dispose_Cached_Outputs_17)
                    manager_18.DisposeOutputs();
                var state_22 = n1.CompilationHelper.Restore<__E6M5AizEqR0PwMOSaIV9au>(manager_18.State, __GetContext__());
                if (state_22 == null)
                {
                    state_22 = new __E6M5AizEqR0PwMOSaIV9au(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_23 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_22.__p_RQC24rnEnTaPDsb3GpzWS7 = node_23;
                    var node_24 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5 = node_24;
                    var node_25 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_22.__p_SFLqj3TP9TlLRbmyW7K6QG = node_25;
                }

                n14.StructuredBufferType __pad_CFeoR1mQLTILhVpIIPDd6Y_26 = __slot_CFeoR1mQLTILhVpIIPDd6Y;
                n14.StructuredBufferType __pad_VYz1JM6cNIoLN2X94xv3cg_27 = __slot_VYz1JM6cNIoLN2X94xv3cg;
                n8.GraphicsResourceUsage __pad_HrjjC2A5sVNMOgsIap8AuS_28 = __slot_HrjjC2A5sVNMOgsIap8AuS;
                n1.CompilationHelper.WritePin(state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5.Inputs[0], ref __auto_5);
                var Output_29 = Is_Vertex_Buffer_In || Is_Index_Buffer_In;
                n16._Operations_.ANDNOT(Input_In: Is_Structured_Buffer_In, Input_2_In: Output_29, Output_Out: out bool Output_30);
                int Element_Count_31 = 0;
                n18._Operations_.GetCountAndStrideAndFormat(Element_Count_In: Element_Count_31, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Input_In: __auto_4, Is_Structured_Buffer_In: Output_30, Allow_Raw_Views_In: Allow_Raw_Views_In, Size_Out: out int Size_32, Structure_Stride_Out: out int Structure_Stride_33, Format_Out: out n17.PixelFormat Format_34);
                n1.CompilationHelper.WritePin(state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5.Inputs[1], ref Structure_Stride_33);
                n1.CompilationHelper.WritePin(state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5.Inputs[2], ref __pad_HrjjC2A5sVNMOgsIap8AuS_28);
                n19._Operations_.Switch_Boolean<n14.StructuredBufferType>(Condition_In: Is_Structured_Buffer_In, Input_In: __pad_CFeoR1mQLTILhVpIIPDd6Y_26, Input_2_In: __pad_VYz1JM6cNIoLN2X94xv3cg_27, Output_Out: out n14.StructuredBufferType Output_35);
                bool Is_Unordered_Access_36 = false;
                bool Is_View_37 = false;
                bool Is_Stream_Output_38 = false;
                n18._Operations_.BufferFlags(Is_Unordered_Access_In: Is_Unordered_Access_36, Structured_Buffer_Type_In: Output_35, Is_Vertex_Buffer_In: Is_Vertex_Buffer_In, Is_Index_Buffer_In: Is_Index_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_View_In: Is_View_37, Is_Stream_Output_In: Is_Stream_Output_38, Output_Out: out n8.BufferFlags Output_39);
                n1.CompilationHelper.WritePin(state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5.Inputs[3], ref Output_39);
                n1.CompilationHelper.ReadPin(state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5.Outputs[0], out n8.BufferDescription out_40);
                n1.CompilationHelper.WritePin(state_22.__p_RQC24rnEnTaPDsb3GpzWS7.Inputs[0], ref out_40);
                bool Is_Unordered_Access_41 = false;
                bool Is_Stream_Output_42 = false;
                n18._Operations_.BufferViewFlags(Is_Unordered_Access_In: Is_Unordered_Access_41, Structured_Buffer_Type_In: Output_35, Is_Vertex_Buffer_In: Is_Vertex_Buffer_In, Is_Index_Buffer_In: Is_Index_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_Stream_Output_In: Is_Stream_Output_42, Output_Out: out n8.BufferFlags Output_43);
                n1.CompilationHelper.WritePin(state_22.__p_SFLqj3TP9TlLRbmyW7K6QG.Inputs[0], ref Output_43);
                n1.CompilationHelper.WritePin(state_22.__p_SFLqj3TP9TlLRbmyW7K6QG.Inputs[1], ref Format_34);
                n1.CompilationHelper.ReadPin(state_22.__p_SFLqj3TP9TlLRbmyW7K6QG.Outputs[0], out n14.BufferViewDescription out_44);
                n1.CompilationHelper.WritePin(state_22.__p_RQC24rnEnTaPDsb3GpzWS7.Inputs[1], ref out_44);
                n1.CompilationHelper.WritePin(state_22.__p_RQC24rnEnTaPDsb3GpzWS7.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_22.__p_RQC24rnEnTaPDsb3GpzWS7.Outputs[0], out n8.Buffer out_45);
                if (state_22.__GetContext__().IsImmutable)
                    state_22 = state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5 != state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5 || state_22.__p_RQC24rnEnTaPDsb3GpzWS7 != state_22.__p_RQC24rnEnTaPDsb3GpzWS7 || state_22.__p_SFLqj3TP9TlLRbmyW7K6QG != state_22.__p_SFLqj3TP9TlLRbmyW7K6QG ? new __E6M5AizEqR0PwMOSaIV9au(state_22)
                    {__p_DSoFIC6ZRMEPUrsyKkpTH5 = state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5, __p_RQC24rnEnTaPDsb3GpzWS7 = state_22.__p_RQC24rnEnTaPDsb3GpzWS7, __p_SFLqj3TP9TlLRbmyW7K6QG = state_22.__p_SFLqj3TP9TlLRbmyW7K6QG} : state_22;
                else
                {
                    state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5 = state_22.__p_DSoFIC6ZRMEPUrsyKkpTH5;
                    state_22.__p_RQC24rnEnTaPDsb3GpzWS7 = state_22.__p_RQC24rnEnTaPDsb3GpzWS7;
                    state_22.__p_SFLqj3TP9TlLRbmyW7K6QG = state_22.__p_SFLqj3TP9TlLRbmyW7K6QG;
                }

                outputs_20 = n2.ValueTuple.Create(out_45);
                manager_18 = manager_18.Update(inputs_19, __GetContext__().IsImmutable, Dispose_Cached_Outputs_17, state_22, outputs_20);
            }
            else
            {
                manager_18.Update(inputs_19, __GetContext__().IsImmutable, Dispose_Cached_Outputs_17);
            }

            var __auto_46 = outputs_20.Item1;
            var State_Output_48 = this.__p_CknwO4VC78aQJM2ElqNucP.Update(Input_In: __auto_46, Data_In: __auto_4, Offset_In_Bytes_In: Offset_In_Bytes_In, Apply_In: Output_16, Output_Out: out n8.Buffer Output_47);
            Output_Out = Output_47;
            Has_Changed_Out = Has_Changed_21;
            n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = state_6 != this.__if_FixYrbUmWWmNhxx5ScuYkn || manager_18 != this.__cache_QRuKOIDKTCjQEXispb5UiS || State_Output_48 != this.__p_CknwO4VC78aQJM2ElqNucP ? new DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T>(this)
                {__if_FixYrbUmWWmNhxx5ScuYkn = state_6, __cache_QRuKOIDKTCjQEXispb5UiS = manager_18, __p_CknwO4VC78aQJM2ElqNucP = State_Output_48} : that_49;
            else
            {
                this.__if_FixYrbUmWWmNhxx5ScuYkn = state_6;
                this.__cache_QRuKOIDKTCjQEXispb5UiS = manager_18;
                this.__p_CknwO4VC78aQJM2ElqNucP = State_Output_48;
            }

            return that_49;
        }

        public n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "CknwO4VC78aQJM2ElqNucP", 107954U);
            var Output_1 = n13.SetData_PFT0uUgEsf0MJ7bFzVugSk.Create(Node_Context: Node_Context_0);
            n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> that_2 = this;
            this.__p_CknwO4VC78aQJM2ElqNucP = Output_1;
            this.__if_FixYrbUmWWmNhxx5ScuYkn = default(n2.Object);
            this.__cache_QRuKOIDKTCjQEXispb5UiS = null;
            return that_2;
        }

        public n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> __CreateDefault__()
        {
            n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> that_0 = this;
            this.__if_FixYrbUmWWmNhxx5ScuYkn = default(n2.Object);
            this.__cache_QRuKOIDKTCjQEXispb5UiS = null;
            this.__p_CknwO4VC78aQJM2ElqNucP = n13.SetData_PFT0uUgEsf0MJ7bFzVugSk.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_FixYrbUmWWmNhxx5ScuYkn);
            n1.CompilationHelper.SafeDispose(this.__cache_QRuKOIDKTCjQEXispb5UiS);
            n1.CompilationHelper.SafeDispose(this.__p_CknwO4VC78aQJM2ElqNucP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_FixYrbUmWWmNhxx5ScuYkn;
        [n1.ElementAttribute(TracingId = 107847U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QRuKOIDKTCjQEXispb5UiS", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_QRuKOIDKTCjQEXispb5UiS = null;
        [n1.ElementAttribute(TracingId = 107917U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CFeoR1mQLTILhVpIIPDd6Y", Name = "__slot_CFeoR1mQLTILhVpIIPDd6Y")]
        public static n14.StructuredBufferType __slot_CFeoR1mQLTILhVpIIPDd6Y = n1.CompilationHelper.Deserialize<n14.StructuredBufferType>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "CFeoR1mQLTILhVpIIPDd6Y");
        [n1.ElementAttribute(TracingId = 107916U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VYz1JM6cNIoLN2X94xv3cg", Name = "__slot_VYz1JM6cNIoLN2X94xv3cg")]
        public static n14.StructuredBufferType __slot_VYz1JM6cNIoLN2X94xv3cg = n1.CompilationHelper.Deserialize<n14.StructuredBufferType>("StructuredBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "VYz1JM6cNIoLN2X94xv3cg");
        [n1.ElementAttribute(TracingId = 107861U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HrjjC2A5sVNMOgsIap8AuS", Name = "__slot_HrjjC2A5sVNMOgsIap8AuS")]
        public static n8.GraphicsResourceUsage __slot_HrjjC2A5sVNMOgsIap8AuS = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Dynamic", false, "Dky5PMnuvcKN4CxmfNs7Uv", "HrjjC2A5sVNMOgsIap8AuS");
        [n1.ElementAttribute(TracingId = 107954U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CknwO4VC78aQJM2ElqNucP", Name = "SetData", IsManaged = true, IsAutoGenerated = true)]
        public n13.SetData_PFT0uUgEsf0MJ7bFzVugSk __p_CknwO4VC78aQJM2ElqNucP;
        static DynamicBuffer_C82b44KM7nmOgoP82JqMWO()
        {
        }

        public DynamicBuffer_C82b44KM7nmOgoP82JqMWO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DynamicBuffer_C82b44KM7nmOgoP82JqMWO(DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> other): base(other)
        {
            this.__if_FixYrbUmWWmNhxx5ScuYkn = other.__if_FixYrbUmWWmNhxx5ScuYkn;
            this.__cache_QRuKOIDKTCjQEXispb5UiS = other.__cache_QRuKOIDKTCjQEXispb5UiS;
            this.__p_CknwO4VC78aQJM2ElqNucP = other.__p_CknwO4VC78aQJM2ElqNucP;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_FixYrbUmWWmNhxx5ScuYkn", in __if_FixYrbUmWWmNhxx5ScuYkn), n1.CompilationHelper.GetValueOrExisting(values, "__cache_QRuKOIDKTCjQEXispb5UiS", in __cache_QRuKOIDKTCjQEXispb5UiS), n1.CompilationHelper.GetValueOrExisting(values, "__p_CknwO4VC78aQJM2ElqNucP", in __p_CknwO4VC78aQJM2ElqNucP));
        }

        internal DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> __WITH__(n2.Object __if_FixYrbUmWWmNhxx5ScuYkn, n6.Manager<n2.ValueTuple<int, int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_QRuKOIDKTCjQEXispb5UiS, n13.SetData_PFT0uUgEsf0MJ7bFzVugSk __p_CknwO4VC78aQJM2ElqNucP)
        {
            n13.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_FixYrbUmWWmNhxx5ScuYkn != this.__if_FixYrbUmWWmNhxx5ScuYkn || __cache_QRuKOIDKTCjQEXispb5UiS != this.__cache_QRuKOIDKTCjQEXispb5UiS || __p_CknwO4VC78aQJM2ElqNucP != this.__p_CknwO4VC78aQJM2ElqNucP ? new DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T>(this)
                {__if_FixYrbUmWWmNhxx5ScuYkn = __if_FixYrbUmWWmNhxx5ScuYkn, __cache_QRuKOIDKTCjQEXispb5UiS = __cache_QRuKOIDKTCjQEXispb5UiS, __p_CknwO4VC78aQJM2ElqNucP = __p_CknwO4VC78aQJM2ElqNucP} : that_0;
            else
            {
                this.__if_FixYrbUmWWmNhxx5ScuYkn = __if_FixYrbUmWWmNhxx5ScuYkn;
                this.__cache_QRuKOIDKTCjQEXispb5UiS = __cache_QRuKOIDKTCjQEXispb5UiS;
                this.__p_CknwO4VC78aQJM2ElqNucP = __p_CknwO4VC78aQJM2ElqNucP;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "MmRL8LTTWmIMFVzYXUoR3G", Name = "__MmRL8LTTWmIMFVzYXUoR3G")]
        [n2.SerializableAttribute]
        public class __MmRL8LTTWmIMFVzYXUoR3G : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NqG63rkt8IqNbNdRz2xeta);
                return;
            }

            [n1.ElementAttribute(TracingId = 107937U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NqG63rkt8IqNbNdRz2xeta", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_NqG63rkt8IqNbNdRz2xeta;
            public __MmRL8LTTWmIMFVzYXUoR3G(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MmRL8LTTWmIMFVzYXUoR3G(__MmRL8LTTWmIMFVzYXUoR3G other): base(other)
            {
                this.__p_NqG63rkt8IqNbNdRz2xeta = other.__p_NqG63rkt8IqNbNdRz2xeta;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NqG63rkt8IqNbNdRz2xeta", in __p_NqG63rkt8IqNbNdRz2xeta));
            }

            internal __MmRL8LTTWmIMFVzYXUoR3G __WITH__(n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_NqG63rkt8IqNbNdRz2xeta)
            {
                __MmRL8LTTWmIMFVzYXUoR3G that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NqG63rkt8IqNbNdRz2xeta != this.__p_NqG63rkt8IqNbNdRz2xeta ? new __MmRL8LTTWmIMFVzYXUoR3G(this)
                    {__p_NqG63rkt8IqNbNdRz2xeta = __p_NqG63rkt8IqNbNdRz2xeta} : that_0;
                else
                {
                    this.__p_NqG63rkt8IqNbNdRz2xeta = __p_NqG63rkt8IqNbNdRz2xeta;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "E6M5AizEqR0PwMOSaIV9au", Name = "__E6M5AizEqR0PwMOSaIV9au")]
        [n2.SerializableAttribute]
        public class __E6M5AizEqR0PwMOSaIV9au : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RQC24rnEnTaPDsb3GpzWS7);
                n1.CompilationHelper.SafeDispose(this.__p_DSoFIC6ZRMEPUrsyKkpTH5);
                n1.CompilationHelper.SafeDispose(this.__p_SFLqj3TP9TlLRbmyW7K6QG);
                return;
            }

            [n1.ElementAttribute(TracingId = 107862U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RQC24rnEnTaPDsb3GpzWS7", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_RQC24rnEnTaPDsb3GpzWS7;
            [n1.ElementAttribute(TracingId = 107868U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DSoFIC6ZRMEPUrsyKkpTH5", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_DSoFIC6ZRMEPUrsyKkpTH5;
            [n1.ElementAttribute(TracingId = 107874U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SFLqj3TP9TlLRbmyW7K6QG", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_SFLqj3TP9TlLRbmyW7K6QG;
            public __E6M5AizEqR0PwMOSaIV9au(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __E6M5AizEqR0PwMOSaIV9au(__E6M5AizEqR0PwMOSaIV9au other): base(other)
            {
                this.__p_RQC24rnEnTaPDsb3GpzWS7 = other.__p_RQC24rnEnTaPDsb3GpzWS7;
                this.__p_DSoFIC6ZRMEPUrsyKkpTH5 = other.__p_DSoFIC6ZRMEPUrsyKkpTH5;
                this.__p_SFLqj3TP9TlLRbmyW7K6QG = other.__p_SFLqj3TP9TlLRbmyW7K6QG;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RQC24rnEnTaPDsb3GpzWS7", in __p_RQC24rnEnTaPDsb3GpzWS7), n1.CompilationHelper.GetValueOrExisting(values, "__p_DSoFIC6ZRMEPUrsyKkpTH5", in __p_DSoFIC6ZRMEPUrsyKkpTH5), n1.CompilationHelper.GetValueOrExisting(values, "__p_SFLqj3TP9TlLRbmyW7K6QG", in __p_SFLqj3TP9TlLRbmyW7K6QG));
            }

            internal __E6M5AizEqR0PwMOSaIV9au __WITH__(n1.IVLNode __p_RQC24rnEnTaPDsb3GpzWS7, n1.IVLNode __p_DSoFIC6ZRMEPUrsyKkpTH5, n1.IVLNode __p_SFLqj3TP9TlLRbmyW7K6QG)
            {
                __E6M5AizEqR0PwMOSaIV9au that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RQC24rnEnTaPDsb3GpzWS7 != this.__p_RQC24rnEnTaPDsb3GpzWS7 || __p_DSoFIC6ZRMEPUrsyKkpTH5 != this.__p_DSoFIC6ZRMEPUrsyKkpTH5 || __p_SFLqj3TP9TlLRbmyW7K6QG != this.__p_SFLqj3TP9TlLRbmyW7K6QG ? new __E6M5AizEqR0PwMOSaIV9au(this)
                    {__p_RQC24rnEnTaPDsb3GpzWS7 = __p_RQC24rnEnTaPDsb3GpzWS7, __p_DSoFIC6ZRMEPUrsyKkpTH5 = __p_DSoFIC6ZRMEPUrsyKkpTH5, __p_SFLqj3TP9TlLRbmyW7K6QG = __p_SFLqj3TP9TlLRbmyW7K6QG} : that_0;
                else
                {
                    this.__p_RQC24rnEnTaPDsb3GpzWS7 = __p_RQC24rnEnTaPDsb3GpzWS7;
                    this.__p_DSoFIC6ZRMEPUrsyKkpTH5 = __p_DSoFIC6ZRMEPUrsyKkpTH5;
                    this.__p_SFLqj3TP9TlLRbmyW7K6QG = __p_SFLqj3TP9TlLRbmyW7K6QG;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 108047U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DmEfvnY9LhgL0IgudEOxyM", Name = "ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM")]
    [n2.SerializableAttribute]
    public class ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM CreateDefault()
        {
            var instance = new ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM Update([n4.SerializedDefaultValueAttribute("1", false)] int Element_Count_In, [n4.SerializedDefaultValueAttribute("16", false)] int Element_Size_In_Bytes_In, n14.IGraphicsDataProvider Initial_Data_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Unordered_Access_In, [n4.SerializedDefaultValueAttribute("StructuredBuffer", false)] n14.StructuredBufferType Structured_Buffer_Type_In, bool Is_Stream_Output_In, bool Allow_Raw_Views_In, bool Recreate_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_RlTyhxj03PYPXcNipLKAtU;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<int, int, bool, n14.StructuredBufferType, bool, bool>, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_2 = (Element_Count_In, Element_Size_In_Bytes_In, Is_Unordered_Access_In, Structured_Buffer_Type_In, Is_Stream_Output_In, Allow_Raw_Views_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__QXYp41kgWsmLmXjIF5BS0i>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __QXYp41kgWsmLmXjIF5BS0i(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_5.__p_LnWWBICuY1lN2PQGvQtCAh = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO = node_7;
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_K3PHfsagHgQLBjZbytHeqO = node_8;
                }

                n14.StructuredBufferType __pad_TSrZFhx9MNqO2AuXq1NgrD_9 = __slot_TSrZFhx9MNqO2AuXq1NgrD;
                n8.GraphicsResourceUsage __pad_LLP9BXCcwefMGM1nDKx4zd_10 = __slot_LLP9BXCcwefMGM1nDKx4zd;
                var Result_11 = Structured_Buffer_Type_In != __pad_TSrZFhx9MNqO2AuXq1NgrD_9;
                n18._Operations_.GetCountAndStrideAndFormat(Element_Count_In: Element_Count_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Input_In: Initial_Data_In, Is_Structured_Buffer_In: Result_11, Allow_Raw_Views_In: Allow_Raw_Views_In, Size_Out: out int Size_12, Structure_Stride_Out: out int Structure_Stride_13, Format_Out: out n17.PixelFormat Format_14);
                n1.CompilationHelper.WritePin(state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO.Inputs[0], ref Size_12);
                n1.CompilationHelper.WritePin(state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO.Inputs[1], ref Structure_Stride_13);
                n1.CompilationHelper.WritePin(state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO.Inputs[2], ref __pad_LLP9BXCcwefMGM1nDKx4zd_10);
                bool Is_Index_Buffer_15 = false;
                bool Is_View_16 = false;
                n18._Operations_.BufferFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Structured_Buffer_Type_In: Structured_Buffer_Type_In, Is_Vertex_Buffer_In: Is_Stream_Output_In, Is_Index_Buffer_In: Is_Index_Buffer_15, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_View_In: Is_View_16, Is_Stream_Output_In: Is_Stream_Output_In, Output_Out: out n8.BufferFlags Output_17);
                n1.CompilationHelper.WritePin(state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO.Inputs[3], ref Output_17);
                n1.CompilationHelper.ReadPin(state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO.Outputs[0], out n8.BufferDescription out_18);
                n1.CompilationHelper.WritePin(state_5.__p_LnWWBICuY1lN2PQGvQtCAh.Inputs[0], ref out_18);
                bool Is_Index_Buffer_19 = false;
                n18._Operations_.BufferViewFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Structured_Buffer_Type_In: Structured_Buffer_Type_In, Is_Vertex_Buffer_In: Is_Stream_Output_In, Is_Index_Buffer_In: Is_Index_Buffer_19, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_Stream_Output_In: Is_Stream_Output_In, Output_Out: out n8.BufferFlags Output_20);
                n1.CompilationHelper.WritePin(state_5.__p_K3PHfsagHgQLBjZbytHeqO.Inputs[0], ref Output_20);
                n1.CompilationHelper.WritePin(state_5.__p_K3PHfsagHgQLBjZbytHeqO.Inputs[1], ref Format_14);
                n1.CompilationHelper.ReadPin(state_5.__p_K3PHfsagHgQLBjZbytHeqO.Outputs[0], out n14.BufferViewDescription out_21);
                n1.CompilationHelper.WritePin(state_5.__p_LnWWBICuY1lN2PQGvQtCAh.Inputs[1], ref out_21);
                n1.CompilationHelper.WritePin(state_5.__p_LnWWBICuY1lN2PQGvQtCAh.Inputs[2], ref Initial_Data_In);
                n1.CompilationHelper.WritePin(state_5.__p_LnWWBICuY1lN2PQGvQtCAh.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_LnWWBICuY1lN2PQGvQtCAh.Outputs[0], out n8.Buffer out_22);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO != state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO || state_5.__p_LnWWBICuY1lN2PQGvQtCAh != state_5.__p_LnWWBICuY1lN2PQGvQtCAh || state_5.__p_K3PHfsagHgQLBjZbytHeqO != state_5.__p_K3PHfsagHgQLBjZbytHeqO ? new __QXYp41kgWsmLmXjIF5BS0i(state_5)
                    {__p_FRxFPsIH1F9Nf6lWY2FPvO = state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO, __p_LnWWBICuY1lN2PQGvQtCAh = state_5.__p_LnWWBICuY1lN2PQGvQtCAh, __p_K3PHfsagHgQLBjZbytHeqO = state_5.__p_K3PHfsagHgQLBjZbytHeqO} : state_5;
                else
                {
                    state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO = state_5.__p_FRxFPsIH1F9Nf6lWY2FPvO;
                    state_5.__p_LnWWBICuY1lN2PQGvQtCAh = state_5.__p_LnWWBICuY1lN2PQGvQtCAh;
                    state_5.__p_K3PHfsagHgQLBjZbytHeqO = state_5.__p_K3PHfsagHgQLBjZbytHeqO;
                }

                outputs_3 = n2.ValueTuple.Create(out_22);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_23 = outputs_3.Item1;
            Output_Out = __auto_23;
            Has_Changed_Out = Has_Changed_4;
            n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = manager_1 != this.__cache_RlTyhxj03PYPXcNipLKAtU ? new ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(this)
                {__cache_RlTyhxj03PYPXcNipLKAtU = manager_1} : that_24;
            else
            {
                this.__cache_RlTyhxj03PYPXcNipLKAtU = manager_1;
            }

            return that_24;
        }

        public n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM that_0 = this;
            this.__cache_RlTyhxj03PYPXcNipLKAtU = null;
            return that_0;
        }

        public n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __CreateDefault__()
        {
            n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM that_0 = this;
            this.__cache_RlTyhxj03PYPXcNipLKAtU = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RlTyhxj03PYPXcNipLKAtU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 108051U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RlTyhxj03PYPXcNipLKAtU", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, int, bool, n14.StructuredBufferType, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_RlTyhxj03PYPXcNipLKAtU = null;
        [n1.ElementAttribute(TracingId = 108107U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TSrZFhx9MNqO2AuXq1NgrD", Name = "__slot_TSrZFhx9MNqO2AuXq1NgrD")]
        public static n14.StructuredBufferType __slot_TSrZFhx9MNqO2AuXq1NgrD = n1.CompilationHelper.Deserialize<n14.StructuredBufferType>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "TSrZFhx9MNqO2AuXq1NgrD");
        [n1.ElementAttribute(TracingId = 108065U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LLP9BXCcwefMGM1nDKx4zd", Name = "__slot_LLP9BXCcwefMGM1nDKx4zd")]
        public static n8.GraphicsResourceUsage __slot_LLP9BXCcwefMGM1nDKx4zd = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Default", false, "Dky5PMnuvcKN4CxmfNs7Uv", "LLP9BXCcwefMGM1nDKx4zd");
        static ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM()
        {
        }

        public ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM other): base(other)
        {
            this.__cache_RlTyhxj03PYPXcNipLKAtU = other.__cache_RlTyhxj03PYPXcNipLKAtU;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RlTyhxj03PYPXcNipLKAtU", in __cache_RlTyhxj03PYPXcNipLKAtU));
        }

        internal ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __WITH__(n6.Manager<n2.ValueTuple<int, int, bool, n14.StructuredBufferType, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_RlTyhxj03PYPXcNipLKAtU)
        {
            n13.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RlTyhxj03PYPXcNipLKAtU != this.__cache_RlTyhxj03PYPXcNipLKAtU ? new ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM(this)
                {__cache_RlTyhxj03PYPXcNipLKAtU = __cache_RlTyhxj03PYPXcNipLKAtU} : that_0;
            else
            {
                this.__cache_RlTyhxj03PYPXcNipLKAtU = __cache_RlTyhxj03PYPXcNipLKAtU;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QXYp41kgWsmLmXjIF5BS0i", Name = "__QXYp41kgWsmLmXjIF5BS0i")]
        [n2.SerializableAttribute]
        public class __QXYp41kgWsmLmXjIF5BS0i : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_LnWWBICuY1lN2PQGvQtCAh);
                n1.CompilationHelper.SafeDispose(this.__p_FRxFPsIH1F9Nf6lWY2FPvO);
                n1.CompilationHelper.SafeDispose(this.__p_K3PHfsagHgQLBjZbytHeqO);
                return;
            }

            [n1.ElementAttribute(TracingId = 108066U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LnWWBICuY1lN2PQGvQtCAh", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_LnWWBICuY1lN2PQGvQtCAh;
            [n1.ElementAttribute(TracingId = 108072U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FRxFPsIH1F9Nf6lWY2FPvO", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_FRxFPsIH1F9Nf6lWY2FPvO;
            [n1.ElementAttribute(TracingId = 108078U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K3PHfsagHgQLBjZbytHeqO", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_K3PHfsagHgQLBjZbytHeqO;
            public __QXYp41kgWsmLmXjIF5BS0i(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QXYp41kgWsmLmXjIF5BS0i(__QXYp41kgWsmLmXjIF5BS0i other): base(other)
            {
                this.__p_LnWWBICuY1lN2PQGvQtCAh = other.__p_LnWWBICuY1lN2PQGvQtCAh;
                this.__p_FRxFPsIH1F9Nf6lWY2FPvO = other.__p_FRxFPsIH1F9Nf6lWY2FPvO;
                this.__p_K3PHfsagHgQLBjZbytHeqO = other.__p_K3PHfsagHgQLBjZbytHeqO;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LnWWBICuY1lN2PQGvQtCAh", in __p_LnWWBICuY1lN2PQGvQtCAh), n1.CompilationHelper.GetValueOrExisting(values, "__p_FRxFPsIH1F9Nf6lWY2FPvO", in __p_FRxFPsIH1F9Nf6lWY2FPvO), n1.CompilationHelper.GetValueOrExisting(values, "__p_K3PHfsagHgQLBjZbytHeqO", in __p_K3PHfsagHgQLBjZbytHeqO));
            }

            internal __QXYp41kgWsmLmXjIF5BS0i __WITH__(n1.IVLNode __p_LnWWBICuY1lN2PQGvQtCAh, n1.IVLNode __p_FRxFPsIH1F9Nf6lWY2FPvO, n1.IVLNode __p_K3PHfsagHgQLBjZbytHeqO)
            {
                __QXYp41kgWsmLmXjIF5BS0i that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_LnWWBICuY1lN2PQGvQtCAh != this.__p_LnWWBICuY1lN2PQGvQtCAh || __p_FRxFPsIH1F9Nf6lWY2FPvO != this.__p_FRxFPsIH1F9Nf6lWY2FPvO || __p_K3PHfsagHgQLBjZbytHeqO != this.__p_K3PHfsagHgQLBjZbytHeqO ? new __QXYp41kgWsmLmXjIF5BS0i(this)
                    {__p_LnWWBICuY1lN2PQGvQtCAh = __p_LnWWBICuY1lN2PQGvQtCAh, __p_FRxFPsIH1F9Nf6lWY2FPvO = __p_FRxFPsIH1F9Nf6lWY2FPvO, __p_K3PHfsagHgQLBjZbytHeqO = __p_K3PHfsagHgQLBjZbytHeqO} : that_0;
                else
                {
                    this.__p_LnWWBICuY1lN2PQGvQtCAh = __p_LnWWBICuY1lN2PQGvQtCAh;
                    this.__p_FRxFPsIH1F9Nf6lWY2FPvO = __p_FRxFPsIH1F9Nf6lWY2FPvO;
                    this.__p_K3PHfsagHgQLBjZbytHeqO = __p_K3PHfsagHgQLBjZbytHeqO;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 108184U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FbLI4KQBLiqPWqVmsjtSvI", Name = "VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI")]
    [n2.SerializableAttribute]
    public class VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI Create(n1.NodeContext Node_Context)
        {
            var instance = new VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI CreateDefault()
        {
            var instance = new VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI Update(n8.Buffer Input_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Recreate_In, out n8.Buffer Output_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_GIEzvLtYa1WOn9VRUj9xNG;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_2 = n2.ValueTuple.Create(Input_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__AS4uWZI8yzhN9tsbMinsWy>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __AS4uWZI8yzhN9tsbMinsWy(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferView", "Stride.Graphics.Advanced");
                    state_5.__p_RRBriULKaUoPHD25XJRUQi = node_7;
                }

                n8.BufferFlags __pad_CRukRx4IniXOvBVUDOhYcm_8 = __slot_CRukRx4IniXOvBVUDOhYcm;
                n8.BufferFlags __pad_HdI9Wb1tupeLuPQe3TuUhK_9 = __slot_HdI9Wb1tupeLuPQe3TuUhK;
                var Output_10 = __pad_CRukRx4IniXOvBVUDOhYcm_8 | __pad_HdI9Wb1tupeLuPQe3TuUhK_9;
                n1.CompilationHelper.WritePin(state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh.Inputs[0], ref Output_10);
                n17.PixelFormat Format_11 = __c_AddXFtjivFROC3NKpiRCvn;
                n1.CompilationHelper.WritePin(state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh.Inputs[1], ref Format_11);
                n1.CompilationHelper.ReadPin(state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh.Outputs[0], out n14.BufferViewDescription out_12);
                n1.CompilationHelper.WritePin(state_5.__p_RRBriULKaUoPHD25XJRUQi.Inputs[0], ref Input_In);
                n1.CompilationHelper.WritePin(state_5.__p_RRBriULKaUoPHD25XJRUQi.Inputs[1], ref out_12);
                n1.CompilationHelper.WritePin(state_5.__p_RRBriULKaUoPHD25XJRUQi.Inputs[2], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_RRBriULKaUoPHD25XJRUQi.Outputs[0], out n8.Buffer out_13);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh != state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh || state_5.__p_RRBriULKaUoPHD25XJRUQi != state_5.__p_RRBriULKaUoPHD25XJRUQi ? new __AS4uWZI8yzhN9tsbMinsWy(state_5)
                    {__p_Q25ukbYr74HOjrJ3XsW8Wh = state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh, __p_RRBriULKaUoPHD25XJRUQi = state_5.__p_RRBriULKaUoPHD25XJRUQi} : state_5;
                else
                {
                    state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh = state_5.__p_Q25ukbYr74HOjrJ3XsW8Wh;
                    state_5.__p_RRBriULKaUoPHD25XJRUQi = state_5.__p_RRBriULKaUoPHD25XJRUQi;
                }

                outputs_3 = n2.ValueTuple.Create(out_13);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_14 = outputs_3.Item1;
            Output_Out = __auto_14;
            n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = manager_1 != this.__cache_GIEzvLtYa1WOn9VRUj9xNG ? new VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(this)
                {__cache_GIEzvLtYa1WOn9VRUj9xNG = manager_1} : that_15;
            else
            {
                this.__cache_GIEzvLtYa1WOn9VRUj9xNG = manager_1;
            }

            return that_15;
        }

        public n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI that_0 = this;
            this.__cache_GIEzvLtYa1WOn9VRUj9xNG = null;
            return that_0;
        }

        public n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI __CreateDefault__()
        {
            n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI that_0 = this;
            this.__cache_GIEzvLtYa1WOn9VRUj9xNG = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GIEzvLtYa1WOn9VRUj9xNG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 108187U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GIEzvLtYa1WOn9VRUj9xNG", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>> __cache_GIEzvLtYa1WOn9VRUj9xNG = null;
        [n1.ElementAttribute(TracingId = 108198U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CRukRx4IniXOvBVUDOhYcm", Name = "__slot_CRukRx4IniXOvBVUDOhYcm")]
        public static n8.BufferFlags __slot_CRukRx4IniXOvBVUDOhYcm = n1.CompilationHelper.Deserialize<n8.BufferFlags>("VertexBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "CRukRx4IniXOvBVUDOhYcm");
        [n1.ElementAttribute(TracingId = 108203U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HdI9Wb1tupeLuPQe3TuUhK", Name = "__slot_HdI9Wb1tupeLuPQe3TuUhK")]
        public static n8.BufferFlags __slot_HdI9Wb1tupeLuPQe3TuUhK = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "HdI9Wb1tupeLuPQe3TuUhK");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n17.PixelFormat __c_AddXFtjivFROC3NKpiRCvn = n1.CompilationHelper.Deserialize<n17.PixelFormat>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "AddXFtjivFROC3NKpiRCvn");
        static VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI()
        {
        }

        public VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI other): base(other)
        {
            this.__cache_GIEzvLtYa1WOn9VRUj9xNG = other.__cache_GIEzvLtYa1WOn9VRUj9xNG;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GIEzvLtYa1WOn9VRUj9xNG", in __cache_GIEzvLtYa1WOn9VRUj9xNG));
        }

        internal VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI __WITH__(n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>> __cache_GIEzvLtYa1WOn9VRUj9xNG)
        {
            n13.VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GIEzvLtYa1WOn9VRUj9xNG != this.__cache_GIEzvLtYa1WOn9VRUj9xNG ? new VertexBufferView_FbLI4KQBLiqPWqVmsjtSvI(this)
                {__cache_GIEzvLtYa1WOn9VRUj9xNG = __cache_GIEzvLtYa1WOn9VRUj9xNG} : that_0;
            else
            {
                this.__cache_GIEzvLtYa1WOn9VRUj9xNG = __cache_GIEzvLtYa1WOn9VRUj9xNG;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AS4uWZI8yzhN9tsbMinsWy", Name = "__AS4uWZI8yzhN9tsbMinsWy")]
        [n2.SerializableAttribute]
        public class __AS4uWZI8yzhN9tsbMinsWy : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Q25ukbYr74HOjrJ3XsW8Wh);
                n1.CompilationHelper.SafeDispose(this.__p_RRBriULKaUoPHD25XJRUQi);
                return;
            }

            [n1.ElementAttribute(TracingId = 108194U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Q25ukbYr74HOjrJ3XsW8Wh", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Q25ukbYr74HOjrJ3XsW8Wh;
            [n1.ElementAttribute(TracingId = 108204U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RRBriULKaUoPHD25XJRUQi", Name = "BufferView", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferView", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_RRBriULKaUoPHD25XJRUQi;
            public __AS4uWZI8yzhN9tsbMinsWy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __AS4uWZI8yzhN9tsbMinsWy(__AS4uWZI8yzhN9tsbMinsWy other): base(other)
            {
                this.__p_Q25ukbYr74HOjrJ3XsW8Wh = other.__p_Q25ukbYr74HOjrJ3XsW8Wh;
                this.__p_RRBriULKaUoPHD25XJRUQi = other.__p_RRBriULKaUoPHD25XJRUQi;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Q25ukbYr74HOjrJ3XsW8Wh", in __p_Q25ukbYr74HOjrJ3XsW8Wh), n1.CompilationHelper.GetValueOrExisting(values, "__p_RRBriULKaUoPHD25XJRUQi", in __p_RRBriULKaUoPHD25XJRUQi));
            }

            internal __AS4uWZI8yzhN9tsbMinsWy __WITH__(n1.IVLNode __p_Q25ukbYr74HOjrJ3XsW8Wh, n1.IVLNode __p_RRBriULKaUoPHD25XJRUQi)
            {
                __AS4uWZI8yzhN9tsbMinsWy that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Q25ukbYr74HOjrJ3XsW8Wh != this.__p_Q25ukbYr74HOjrJ3XsW8Wh || __p_RRBriULKaUoPHD25XJRUQi != this.__p_RRBriULKaUoPHD25XJRUQi ? new __AS4uWZI8yzhN9tsbMinsWy(this)
                    {__p_Q25ukbYr74HOjrJ3XsW8Wh = __p_Q25ukbYr74HOjrJ3XsW8Wh, __p_RRBriULKaUoPHD25XJRUQi = __p_RRBriULKaUoPHD25XJRUQi} : that_0;
                else
                {
                    this.__p_Q25ukbYr74HOjrJ3XsW8Wh = __p_Q25ukbYr74HOjrJ3XsW8Wh;
                    this.__p_RRBriULKaUoPHD25XJRUQi = __p_RRBriULKaUoPHD25XJRUQi;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 108235U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KrHH8P5aaGPLw8xFASXRV9", Name = "IndexBufferView_KrHH8P5aaGPLw8xFASXRV9")]
    [n2.SerializableAttribute]
    public class IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 Create(n1.NodeContext Node_Context)
        {
            var instance = new IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 CreateDefault()
        {
            var instance = new IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 Update(n8.Buffer Input_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Recreate_In, out n8.Buffer Output_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_NStUWaF5iUgOkFkNbCxLpZ;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_2 = n2.ValueTuple.Create(Input_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__N1ocZoocnwwLtyfVd8CMZM>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __N1ocZoocnwwLtyfVd8CMZM(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_QD8Ybm8k643MbLbU10RlSP = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferView", "Stride.Graphics.Advanced");
                    state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa = node_7;
                }

                n8.BufferFlags __pad_AgD7ERS6jtiNNgU2oYlGNC_8 = __slot_AgD7ERS6jtiNNgU2oYlGNC;
                n8.BufferFlags __pad_VBY8qWXl4u0OElKwPUgCjF_9 = __slot_VBY8qWXl4u0OElKwPUgCjF;
                var Output_10 = __pad_AgD7ERS6jtiNNgU2oYlGNC_8 | __pad_VBY8qWXl4u0OElKwPUgCjF_9;
                n1.CompilationHelper.WritePin(state_5.__p_QD8Ybm8k643MbLbU10RlSP.Inputs[0], ref Output_10);
                n17.PixelFormat Format_11 = __c_SwYqbBCy2qYO4yBDvzVluy;
                n1.CompilationHelper.WritePin(state_5.__p_QD8Ybm8k643MbLbU10RlSP.Inputs[1], ref Format_11);
                n1.CompilationHelper.ReadPin(state_5.__p_QD8Ybm8k643MbLbU10RlSP.Outputs[0], out n14.BufferViewDescription out_12);
                n1.CompilationHelper.WritePin(state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa.Inputs[0], ref Input_In);
                n1.CompilationHelper.WritePin(state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa.Inputs[1], ref out_12);
                n1.CompilationHelper.WritePin(state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa.Inputs[2], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa.Outputs[0], out n8.Buffer out_13);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_QD8Ybm8k643MbLbU10RlSP != state_5.__p_QD8Ybm8k643MbLbU10RlSP || state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa != state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa ? new __N1ocZoocnwwLtyfVd8CMZM(state_5)
                    {__p_QD8Ybm8k643MbLbU10RlSP = state_5.__p_QD8Ybm8k643MbLbU10RlSP, __p_Tj8xNrXj8wBOYVKo5WmAPa = state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa} : state_5;
                else
                {
                    state_5.__p_QD8Ybm8k643MbLbU10RlSP = state_5.__p_QD8Ybm8k643MbLbU10RlSP;
                    state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa = state_5.__p_Tj8xNrXj8wBOYVKo5WmAPa;
                }

                outputs_3 = n2.ValueTuple.Create(out_13);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_14 = outputs_3.Item1;
            Output_Out = __auto_14;
            n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = manager_1 != this.__cache_NStUWaF5iUgOkFkNbCxLpZ ? new IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(this)
                {__cache_NStUWaF5iUgOkFkNbCxLpZ = manager_1} : that_15;
            else
            {
                this.__cache_NStUWaF5iUgOkFkNbCxLpZ = manager_1;
            }

            return that_15;
        }

        public n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 that_0 = this;
            this.__cache_NStUWaF5iUgOkFkNbCxLpZ = null;
            return that_0;
        }

        public n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 __CreateDefault__()
        {
            n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 that_0 = this;
            this.__cache_NStUWaF5iUgOkFkNbCxLpZ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NStUWaF5iUgOkFkNbCxLpZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 108238U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NStUWaF5iUgOkFkNbCxLpZ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>> __cache_NStUWaF5iUgOkFkNbCxLpZ = null;
        [n1.ElementAttribute(TracingId = 108249U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AgD7ERS6jtiNNgU2oYlGNC", Name = "__slot_AgD7ERS6jtiNNgU2oYlGNC")]
        public static n8.BufferFlags __slot_AgD7ERS6jtiNNgU2oYlGNC = n1.CompilationHelper.Deserialize<n8.BufferFlags>("IndexBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "AgD7ERS6jtiNNgU2oYlGNC");
        [n1.ElementAttribute(TracingId = 108254U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VBY8qWXl4u0OElKwPUgCjF", Name = "__slot_VBY8qWXl4u0OElKwPUgCjF")]
        public static n8.BufferFlags __slot_VBY8qWXl4u0OElKwPUgCjF = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "VBY8qWXl4u0OElKwPUgCjF");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n17.PixelFormat __c_SwYqbBCy2qYO4yBDvzVluy = n1.CompilationHelper.Deserialize<n17.PixelFormat>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "SwYqbBCy2qYO4yBDvzVluy");
        static IndexBufferView_KrHH8P5aaGPLw8xFASXRV9()
        {
        }

        public IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 other): base(other)
        {
            this.__cache_NStUWaF5iUgOkFkNbCxLpZ = other.__cache_NStUWaF5iUgOkFkNbCxLpZ;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NStUWaF5iUgOkFkNbCxLpZ", in __cache_NStUWaF5iUgOkFkNbCxLpZ));
        }

        internal IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 __WITH__(n6.Manager<n2.ValueTuple<n8.Buffer>, n2.ValueTuple<n8.Buffer>> __cache_NStUWaF5iUgOkFkNbCxLpZ)
        {
            n13.IndexBufferView_KrHH8P5aaGPLw8xFASXRV9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NStUWaF5iUgOkFkNbCxLpZ != this.__cache_NStUWaF5iUgOkFkNbCxLpZ ? new IndexBufferView_KrHH8P5aaGPLw8xFASXRV9(this)
                {__cache_NStUWaF5iUgOkFkNbCxLpZ = __cache_NStUWaF5iUgOkFkNbCxLpZ} : that_0;
            else
            {
                this.__cache_NStUWaF5iUgOkFkNbCxLpZ = __cache_NStUWaF5iUgOkFkNbCxLpZ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "N1ocZoocnwwLtyfVd8CMZM", Name = "__N1ocZoocnwwLtyfVd8CMZM")]
        [n2.SerializableAttribute]
        public class __N1ocZoocnwwLtyfVd8CMZM : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QD8Ybm8k643MbLbU10RlSP);
                n1.CompilationHelper.SafeDispose(this.__p_Tj8xNrXj8wBOYVKo5WmAPa);
                return;
            }

            [n1.ElementAttribute(TracingId = 108245U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QD8Ybm8k643MbLbU10RlSP", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_QD8Ybm8k643MbLbU10RlSP;
            [n1.ElementAttribute(TracingId = 108255U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Tj8xNrXj8wBOYVKo5WmAPa", Name = "BufferView", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferView", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Tj8xNrXj8wBOYVKo5WmAPa;
            public __N1ocZoocnwwLtyfVd8CMZM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __N1ocZoocnwwLtyfVd8CMZM(__N1ocZoocnwwLtyfVd8CMZM other): base(other)
            {
                this.__p_QD8Ybm8k643MbLbU10RlSP = other.__p_QD8Ybm8k643MbLbU10RlSP;
                this.__p_Tj8xNrXj8wBOYVKo5WmAPa = other.__p_Tj8xNrXj8wBOYVKo5WmAPa;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QD8Ybm8k643MbLbU10RlSP", in __p_QD8Ybm8k643MbLbU10RlSP), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tj8xNrXj8wBOYVKo5WmAPa", in __p_Tj8xNrXj8wBOYVKo5WmAPa));
            }

            internal __N1ocZoocnwwLtyfVd8CMZM __WITH__(n1.IVLNode __p_QD8Ybm8k643MbLbU10RlSP, n1.IVLNode __p_Tj8xNrXj8wBOYVKo5WmAPa)
            {
                __N1ocZoocnwwLtyfVd8CMZM that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QD8Ybm8k643MbLbU10RlSP != this.__p_QD8Ybm8k643MbLbU10RlSP || __p_Tj8xNrXj8wBOYVKo5WmAPa != this.__p_Tj8xNrXj8wBOYVKo5WmAPa ? new __N1ocZoocnwwLtyfVd8CMZM(this)
                    {__p_QD8Ybm8k643MbLbU10RlSP = __p_QD8Ybm8k643MbLbU10RlSP, __p_Tj8xNrXj8wBOYVKo5WmAPa = __p_Tj8xNrXj8wBOYVKo5WmAPa} : that_0;
                else
                {
                    this.__p_QD8Ybm8k643MbLbU10RlSP = __p_QD8Ybm8k643MbLbU10RlSP;
                    this.__p_Tj8xNrXj8wBOYVKo5WmAPa = __p_Tj8xNrXj8wBOYVKo5WmAPa;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 108945U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UzEm5Ymj4cZN8XONjvbNX9", Name = "ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9")]
    [n2.SerializableAttribute]
    public class ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> CreateDefault<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> Update<AdM>(T Initial_Data_In, int Element_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Structured_Buffer_In, bool Is_Vertex_Buffer_In, bool Is_Index_Buffer_In, bool Allow_Raw_Views_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Recreate_On_Inital_Data_Change_In, bool Recreate_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_Bur2WIUVPUaMe7Fs5BzWmR.Update(Value_In: Initial_Data_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_4 = Result_1 && Recreate_On_Inital_Data_Change_In;
            var Output_5 = Output_4 || Recreate_In;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_K78An1XzB64PPdvPYXgYar;
            if (manager_7 is null)
            {
                manager_7 = new n6.Manager<n2.ValueTuple<int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_8 = (Element_Size_In_Bytes_In, Is_Structured_Buffer_In, Is_Vertex_Buffer_In, Is_Index_Buffer_In, Allow_Raw_Views_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Output_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__BVvAmZXu8tKNhym69ztj3L>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __BVvAmZXu8tKNhym69ztj3L(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_12 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_11.__p_F0URCzfPX9VOz7QAEINpMB = node_12;
                    var node_13 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_11.__p_QrU6eEGw5jEPnafXrMggfP = node_13;
                    var node_14 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B = node_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "ARnsow89RqFPK8DQlxA9V7", 109055U);
                    var Output_16 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_15);
                    state_11.__p_ARnsow89RqFPK8DQlxA9V7 = Output_16;
                }

                n14.StructuredBufferType __pad_DWbY8cJ5tZ2Nzwx7YREGvN_17 = __slot_DWbY8cJ5tZ2Nzwx7YREGvN;
                n14.StructuredBufferType __pad_UCMRsIMnRxXLbqvb47pgzV_18 = __slot_UCMRsIMnRxXLbqvb47pgzV;
                n8.GraphicsResourceUsage __pad_OZp4cg3VmUINDSHHlCjoiz_19 = __slot_OZp4cg3VmUINDSHHlCjoiz;
                int Offset_In_Bytes_20 = 0;
                bool Force_21 = false;
                bool SetInput_22 = true;
                var Output_23 = state_11.__p_ARnsow89RqFPK8DQlxA9V7;
                if (SetInput_22)
                {
                    Output_23 = state_11.__p_ARnsow89RqFPK8DQlxA9V7.SetInput<AdM>(Input_In: Initial_Data_In, Offset_In_Bytes_In: Offset_In_Bytes_20, Force_In: Force_21);
                }

                var State_Output_25 = Output_23.Update(Output_Out: out n14.IGraphicsDataProvider Output_24);
                int Element_Count_26 = 0;
                n18._Operations_.GetCountAndStrideAndFormat(Element_Count_In: Element_Count_26, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Input_In: Output_24, Is_Structured_Buffer_In: Is_Structured_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Size_Out: out int Size_27, Structure_Stride_Out: out int Structure_Stride_28, Format_Out: out n17.PixelFormat Format_29);
                n1.CompilationHelper.WritePin(state_11.__p_QrU6eEGw5jEPnafXrMggfP.Inputs[0], ref Size_27);
                n1.CompilationHelper.WritePin(state_11.__p_QrU6eEGw5jEPnafXrMggfP.Inputs[1], ref Structure_Stride_28);
                n1.CompilationHelper.WritePin(state_11.__p_QrU6eEGw5jEPnafXrMggfP.Inputs[2], ref __pad_OZp4cg3VmUINDSHHlCjoiz_19);
                n19._Operations_.Switch_Boolean<n14.StructuredBufferType>(Condition_In: Is_Structured_Buffer_In, Input_In: __pad_DWbY8cJ5tZ2Nzwx7YREGvN_17, Input_2_In: __pad_UCMRsIMnRxXLbqvb47pgzV_18, Output_Out: out n14.StructuredBufferType Output_30);
                bool Is_Unordered_Access_31 = false;
                bool Is_View_32 = false;
                bool Is_Stream_Output_33 = false;
                n18._Operations_.BufferFlags(Is_Unordered_Access_In: Is_Unordered_Access_31, Structured_Buffer_Type_In: Output_30, Is_Vertex_Buffer_In: Is_Vertex_Buffer_In, Is_Index_Buffer_In: Is_Index_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_View_In: Is_View_32, Is_Stream_Output_In: Is_Stream_Output_33, Output_Out: out n8.BufferFlags Output_34);
                n1.CompilationHelper.WritePin(state_11.__p_QrU6eEGw5jEPnafXrMggfP.Inputs[3], ref Output_34);
                n1.CompilationHelper.ReadPin(state_11.__p_QrU6eEGw5jEPnafXrMggfP.Outputs[0], out n8.BufferDescription out_35);
                n1.CompilationHelper.WritePin(state_11.__p_F0URCzfPX9VOz7QAEINpMB.Inputs[0], ref out_35);
                bool Is_Unordered_Access_36 = false;
                bool Is_Stream_Output_37 = false;
                n18._Operations_.BufferViewFlags(Is_Unordered_Access_In: Is_Unordered_Access_36, Structured_Buffer_Type_In: Output_30, Is_Vertex_Buffer_In: Is_Vertex_Buffer_In, Is_Index_Buffer_In: Is_Index_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_Stream_Output_In: Is_Stream_Output_37, Output_Out: out n8.BufferFlags Output_38);
                n1.CompilationHelper.WritePin(state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B.Inputs[0], ref Output_38);
                n1.CompilationHelper.WritePin(state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B.Inputs[1], ref Format_29);
                n1.CompilationHelper.ReadPin(state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B.Outputs[0], out n14.BufferViewDescription out_39);
                n1.CompilationHelper.WritePin(state_11.__p_F0URCzfPX9VOz7QAEINpMB.Inputs[1], ref out_39);
                n1.CompilationHelper.WritePin(state_11.__p_F0URCzfPX9VOz7QAEINpMB.Inputs[2], ref Output_24);
                bool Recreate_40 = true;
                n1.CompilationHelper.WritePin(state_11.__p_F0URCzfPX9VOz7QAEINpMB.Inputs[3], ref Recreate_40);
                n1.CompilationHelper.ReadPin(state_11.__p_F0URCzfPX9VOz7QAEINpMB.Outputs[0], out n8.Buffer out_41);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = State_Output_25 != state_11.__p_ARnsow89RqFPK8DQlxA9V7 || state_11.__p_QrU6eEGw5jEPnafXrMggfP != state_11.__p_QrU6eEGw5jEPnafXrMggfP || state_11.__p_F0URCzfPX9VOz7QAEINpMB != state_11.__p_F0URCzfPX9VOz7QAEINpMB || state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B != state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B ? new __BVvAmZXu8tKNhym69ztj3L(state_11)
                    {__p_ARnsow89RqFPK8DQlxA9V7 = State_Output_25, __p_QrU6eEGw5jEPnafXrMggfP = state_11.__p_QrU6eEGw5jEPnafXrMggfP, __p_F0URCzfPX9VOz7QAEINpMB = state_11.__p_F0URCzfPX9VOz7QAEINpMB, __p_D8gJ9ZsVjYsPR2yQnEog2B = state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B} : state_11;
                else
                {
                    state_11.__p_ARnsow89RqFPK8DQlxA9V7 = State_Output_25;
                    state_11.__p_QrU6eEGw5jEPnafXrMggfP = state_11.__p_QrU6eEGw5jEPnafXrMggfP;
                    state_11.__p_F0URCzfPX9VOz7QAEINpMB = state_11.__p_F0URCzfPX9VOz7QAEINpMB;
                    state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B = state_11.__p_D8gJ9ZsVjYsPR2yQnEog2B;
                }

                outputs_9 = n2.ValueTuple.Create(out_41);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_42 = outputs_9.Item1;
            Output_Out = __auto_42;
            Has_Changed_Out = Has_Changed_10;
            n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = Output_3 != this.__p_Bur2WIUVPUaMe7Fs5BzWmR || manager_7 != this.__cache_K78An1XzB64PPdvPYXgYar ? new ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T>(this)
                {__p_Bur2WIUVPUaMe7Fs5BzWmR = Output_3, __cache_K78An1XzB64PPdvPYXgYar = manager_7} : that_43;
            else
            {
                this.__p_Bur2WIUVPUaMe7Fs5BzWmR = Output_3;
                this.__cache_K78An1XzB64PPdvPYXgYar = manager_7;
            }

            return that_43;
        }

        public n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Bur2WIUVPUaMe7Fs5BzWmR", 109117U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> that_4 = this;
            this.__p_Bur2WIUVPUaMe7Fs5BzWmR = Output_3;
            this.__cache_K78An1XzB64PPdvPYXgYar = null;
            return that_4;
        }

        public n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> __CreateDefault__<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> that_1 = this;
            this.__p_Bur2WIUVPUaMe7Fs5BzWmR = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.CreateDefault<AdM>();
            this.__cache_K78An1XzB64PPdvPYXgYar = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Bur2WIUVPUaMe7Fs5BzWmR);
            n1.CompilationHelper.SafeDispose(this.__cache_K78An1XzB64PPdvPYXgYar);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 109117U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Bur2WIUVPUaMe7Fs5BzWmR", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_Bur2WIUVPUaMe7Fs5BzWmR;
        [n1.ElementAttribute(TracingId = 108950U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K78An1XzB64PPdvPYXgYar", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_K78An1XzB64PPdvPYXgYar = null;
        [n1.ElementAttribute(TracingId = 109085U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DWbY8cJ5tZ2Nzwx7YREGvN", Name = "__slot_DWbY8cJ5tZ2Nzwx7YREGvN")]
        public static n14.StructuredBufferType __slot_DWbY8cJ5tZ2Nzwx7YREGvN = n1.CompilationHelper.Deserialize<n14.StructuredBufferType>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "DWbY8cJ5tZ2Nzwx7YREGvN");
        [n1.ElementAttribute(TracingId = 109083U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UCMRsIMnRxXLbqvb47pgzV", Name = "__slot_UCMRsIMnRxXLbqvb47pgzV")]
        public static n14.StructuredBufferType __slot_UCMRsIMnRxXLbqvb47pgzV = n1.CompilationHelper.Deserialize<n14.StructuredBufferType>("StructuredBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "UCMRsIMnRxXLbqvb47pgzV");
        [n1.ElementAttribute(TracingId = 108972U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OZp4cg3VmUINDSHHlCjoiz", Name = "__slot_OZp4cg3VmUINDSHHlCjoiz")]
        public static n8.GraphicsResourceUsage __slot_OZp4cg3VmUINDSHHlCjoiz = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "OZp4cg3VmUINDSHHlCjoiz");
        static ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9()
        {
        }

        public ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9(ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> other): base(other)
        {
            this.__p_Bur2WIUVPUaMe7Fs5BzWmR = other.__p_Bur2WIUVPUaMe7Fs5BzWmR;
            this.__cache_K78An1XzB64PPdvPYXgYar = other.__cache_K78An1XzB64PPdvPYXgYar;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Bur2WIUVPUaMe7Fs5BzWmR", in __p_Bur2WIUVPUaMe7Fs5BzWmR), n1.CompilationHelper.GetValueOrExisting(values, "__cache_K78An1XzB64PPdvPYXgYar", in __cache_K78An1XzB64PPdvPYXgYar));
        }

        internal ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> __WITH__(n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_Bur2WIUVPUaMe7Fs5BzWmR, n6.Manager<n2.ValueTuple<int, bool, bool, bool, bool>, n2.ValueTuple<n8.Buffer>> __cache_K78An1XzB64PPdvPYXgYar)
        {
            n13.ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Bur2WIUVPUaMe7Fs5BzWmR != this.__p_Bur2WIUVPUaMe7Fs5BzWmR || __cache_K78An1XzB64PPdvPYXgYar != this.__cache_K78An1XzB64PPdvPYXgYar ? new ImmutableBuffer_UzEm5Ymj4cZN8XONjvbNX9<T>(this)
                {__p_Bur2WIUVPUaMe7Fs5BzWmR = __p_Bur2WIUVPUaMe7Fs5BzWmR, __cache_K78An1XzB64PPdvPYXgYar = __cache_K78An1XzB64PPdvPYXgYar} : that_0;
            else
            {
                this.__p_Bur2WIUVPUaMe7Fs5BzWmR = __p_Bur2WIUVPUaMe7Fs5BzWmR;
                this.__cache_K78An1XzB64PPdvPYXgYar = __cache_K78An1XzB64PPdvPYXgYar;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BVvAmZXu8tKNhym69ztj3L", Name = "__BVvAmZXu8tKNhym69ztj3L")]
        [n2.SerializableAttribute]
        public class __BVvAmZXu8tKNhym69ztj3L : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_F0URCzfPX9VOz7QAEINpMB);
                n1.CompilationHelper.SafeDispose(this.__p_QrU6eEGw5jEPnafXrMggfP);
                n1.CompilationHelper.SafeDispose(this.__p_D8gJ9ZsVjYsPR2yQnEog2B);
                n1.CompilationHelper.SafeDispose(this.__p_ARnsow89RqFPK8DQlxA9V7);
                return;
            }

            [n1.ElementAttribute(TracingId = 108975U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F0URCzfPX9VOz7QAEINpMB", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_F0URCzfPX9VOz7QAEINpMB;
            [n1.ElementAttribute(TracingId = 108989U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QrU6eEGw5jEPnafXrMggfP", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_QrU6eEGw5jEPnafXrMggfP;
            [n1.ElementAttribute(TracingId = 108999U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "D8gJ9ZsVjYsPR2yQnEog2B", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_D8gJ9ZsVjYsPR2yQnEog2B;
            [n1.ElementAttribute(TracingId = 109055U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "ARnsow89RqFPK8DQlxA9V7", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_ARnsow89RqFPK8DQlxA9V7;
            public __BVvAmZXu8tKNhym69ztj3L(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BVvAmZXu8tKNhym69ztj3L(__BVvAmZXu8tKNhym69ztj3L other): base(other)
            {
                this.__p_F0URCzfPX9VOz7QAEINpMB = other.__p_F0URCzfPX9VOz7QAEINpMB;
                this.__p_QrU6eEGw5jEPnafXrMggfP = other.__p_QrU6eEGw5jEPnafXrMggfP;
                this.__p_D8gJ9ZsVjYsPR2yQnEog2B = other.__p_D8gJ9ZsVjYsPR2yQnEog2B;
                this.__p_ARnsow89RqFPK8DQlxA9V7 = other.__p_ARnsow89RqFPK8DQlxA9V7;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F0URCzfPX9VOz7QAEINpMB", in __p_F0URCzfPX9VOz7QAEINpMB), n1.CompilationHelper.GetValueOrExisting(values, "__p_QrU6eEGw5jEPnafXrMggfP", in __p_QrU6eEGw5jEPnafXrMggfP), n1.CompilationHelper.GetValueOrExisting(values, "__p_D8gJ9ZsVjYsPR2yQnEog2B", in __p_D8gJ9ZsVjYsPR2yQnEog2B), n1.CompilationHelper.GetValueOrExisting(values, "__p_ARnsow89RqFPK8DQlxA9V7", in __p_ARnsow89RqFPK8DQlxA9V7));
            }

            internal __BVvAmZXu8tKNhym69ztj3L __WITH__(n1.IVLNode __p_F0URCzfPX9VOz7QAEINpMB, n1.IVLNode __p_QrU6eEGw5jEPnafXrMggfP, n1.IVLNode __p_D8gJ9ZsVjYsPR2yQnEog2B, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_ARnsow89RqFPK8DQlxA9V7)
            {
                __BVvAmZXu8tKNhym69ztj3L that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_F0URCzfPX9VOz7QAEINpMB != this.__p_F0URCzfPX9VOz7QAEINpMB || __p_QrU6eEGw5jEPnafXrMggfP != this.__p_QrU6eEGw5jEPnafXrMggfP || __p_D8gJ9ZsVjYsPR2yQnEog2B != this.__p_D8gJ9ZsVjYsPR2yQnEog2B || __p_ARnsow89RqFPK8DQlxA9V7 != this.__p_ARnsow89RqFPK8DQlxA9V7 ? new __BVvAmZXu8tKNhym69ztj3L(this)
                    {__p_F0URCzfPX9VOz7QAEINpMB = __p_F0URCzfPX9VOz7QAEINpMB, __p_QrU6eEGw5jEPnafXrMggfP = __p_QrU6eEGw5jEPnafXrMggfP, __p_D8gJ9ZsVjYsPR2yQnEog2B = __p_D8gJ9ZsVjYsPR2yQnEog2B, __p_ARnsow89RqFPK8DQlxA9V7 = __p_ARnsow89RqFPK8DQlxA9V7} : that_0;
                else
                {
                    this.__p_F0URCzfPX9VOz7QAEINpMB = __p_F0URCzfPX9VOz7QAEINpMB;
                    this.__p_QrU6eEGw5jEPnafXrMggfP = __p_QrU6eEGw5jEPnafXrMggfP;
                    this.__p_D8gJ9ZsVjYsPR2yQnEog2B = __p_D8gJ9ZsVjYsPR2yQnEog2B;
                    this.__p_ARnsow89RqFPK8DQlxA9V7 = __p_ARnsow89RqFPK8DQlxA9V7;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Buffers.Internal
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void BufferFlags(bool Is_Unordered_Access_In, n14.StructuredBufferType Structured_Buffer_Type_In, bool Is_Vertex_Buffer_In, bool Is_Index_Buffer_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Allow_Raw_Views_In, bool Is_View_In, bool Is_Stream_Output_In, out n8.BufferFlags Output_Out)
        {
            n8.BufferFlags __pad_F9EzfyGs93DPJLiClJ93Bi_0 = __slot_F9EzfyGs93DPJLiClJ93Bi;
            n8.BufferFlags __pad_NHXbU450JC4PY6cPGwrYvc_1 = __slot_NHXbU450JC4PY6cPGwrYvc;
            n8.BufferFlags __pad_UXdlSGuG5BzQAr8hlAl5dH_2 = __slot_UXdlSGuG5BzQAr8hlAl5dH;
            n16._Operations_.ORNOT(Input_In: Is_View_In, Input_2_In: Allow_Raw_Views_In, Output_Out: out bool Output_3);
            n8.BufferFlags __auto_4;
            if (Output_3)
            {
                n17.PixelFormat View_Format_5 = default(n17.PixelFormat);
                n14.BufferExtensions.CombineWithStructuredBufferTypeFlag(bufferFlags: __pad_F9EzfyGs93DPJLiClJ93Bi_0, viewFormat: View_Format_5, structuredBufferType: Structured_Buffer_Type_In, flags: out n8.BufferFlags Flags_6, format: out n17.PixelFormat Format_7);
                __auto_4 = Flags_6;
            }
            else
            {
                __auto_4 = __pad_F9EzfyGs93DPJLiClJ93Bi_0;
            }

            n8.BufferFlags __auto_8;
            if (Is_Unordered_Access_In)
            {
                n8.BufferFlags __pad_PHM6SUOGo9yPGrlDKBcEeQ_9 = __slot_PHM6SUOGo9yPGrlDKBcEeQ;
                var Output_10 = __auto_4 | __pad_PHM6SUOGo9yPGrlDKBcEeQ_9;
                __auto_8 = Output_10;
            }
            else
            {
                __auto_8 = __auto_4;
            }

            n19._Operations_.Switch_Boolean<n8.BufferFlags>(Condition_In: Is_Index_Buffer_In, Input_In: __auto_8, Input_2_In: __pad_NHXbU450JC4PY6cPGwrYvc_1, Output_Out: out n8.BufferFlags Output_11);
            n19._Operations_.Switch_Boolean<n8.BufferFlags>(Condition_In: Is_Vertex_Buffer_In, Input_In: Output_11, Input_2_In: __pad_UXdlSGuG5BzQAr8hlAl5dH_2, Output_Out: out n8.BufferFlags Output_12);
            n8.BufferFlags __auto_13;
            if (Allow_Raw_Views_In)
            {
                n8.BufferFlags __pad_QXFb7n6ZLkmLLXUm7KBYEN_14 = __slot_QXFb7n6ZLkmLLXUm7KBYEN;
                var Output_15 = Output_12 | __pad_QXFb7n6ZLkmLLXUm7KBYEN_14;
                __auto_13 = Output_15;
            }
            else
            {
                __auto_13 = Output_12;
            }

            n8.BufferFlags __auto_16;
            if (Is_Stream_Output_In)
            {
                n8.BufferFlags __pad_JAgZLwBjXwVQVLsVTlqXQW_17 = __slot_JAgZLwBjXwVQVLsVTlqXQW;
                var Output_18 = __auto_13 | __pad_JAgZLwBjXwVQVLsVTlqXQW_17;
                __auto_16 = Output_18;
            }
            else
            {
                __auto_16 = __auto_13;
            }

            Output_Out = __auto_16;
            return;
        }

        public static void GetFormatFromStride(int Input_In, out n17.PixelFormat Output_Out)
        {
            int __pad_IVaTdLrPphLQZsudLAUgM2_0 = __slot_IVaTdLrPphLQZsudLAUgM2;
            n17.PixelFormat __pad_LNKP2jE496lLKQTPhmI8u2_1 = __slot_LNKP2jE496lLKQTPhmI8u2;
            int __pad_EdwA6PRdqooMl3zKj5WDFi_2 = __slot_EdwA6PRdqooMl3zKj5WDFi;
            int __pad_ECgIHVQmSQrMZ42h38jPvr_3 = __slot_ECgIHVQmSQrMZ42h38jPvr;
            var Result_4 = Input_In == __pad_ECgIHVQmSQrMZ42h38jPvr_3;
            var Result_5 = Input_In == __pad_IVaTdLrPphLQZsudLAUgM2_0;
            n17.PixelFormat __auto_6;
            if (Result_4)
            {
                n17.PixelFormat __pad_DdTopO8xYE5MmkMP3NFhAu_7 = __slot_DdTopO8xYE5MmkMP3NFhAu;
                __auto_6 = __pad_DdTopO8xYE5MmkMP3NFhAu_7;
            }
            else
            {
                __auto_6 = __pad_LNKP2jE496lLKQTPhmI8u2_1;
            }

            n17.PixelFormat __auto_8;
            if (Result_5)
            {
                n17.PixelFormat __pad_PuJg5iOIkElMZsuiheCO0p_9 = __slot_PuJg5iOIkElMZsuiheCO0p;
                __auto_8 = __pad_PuJg5iOIkElMZsuiheCO0p_9;
            }
            else
            {
                __auto_8 = __auto_6;
            }

            var Result_10 = Input_In == __pad_EdwA6PRdqooMl3zKj5WDFi_2;
            n17.PixelFormat __auto_11;
            if (Result_10)
            {
                n17.PixelFormat __pad_ANVcAQmvk9OPomQqpuTuR4_12 = __slot_ANVcAQmvk9OPomQqpuTuR4;
                __auto_11 = __pad_ANVcAQmvk9OPomQqpuTuR4_12;
            }
            else
            {
                __auto_11 = __auto_8;
            }

            Output_Out = __auto_11;
            return;
        }

        public static void GetStrideAndFormat(n14.IGraphicsDataProvider Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Structured_Buffer_In, bool Allow_Raw_Views_In, out int Stride_Out, out n17.PixelFormat Format_Out)
        {
            int __pad_PxkzrOlm1P3NpAKcN99DYV_0 = __slot_PxkzrOlm1P3NpAKcN99DYV;
            n17.PixelFormat __pad_BYr2ykX4Cz4PSj499HwEOK_1 = __slot_BYr2ykX4Cz4PSj499HwEOK;
            n16._Operations_.ANDNOT(Input_In: Is_Structured_Buffer_In, Input_2_In: Allow_Raw_Views_In, Output_Out: out bool Output_2);
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            int __auto_5;
            if (Result_3)
            {
                var Element_Size_In_Bytes_6 = Input_In.ElementSizeInBytes;
                __auto_5 = Element_Size_In_Bytes_6;
            }
            else
            {
                __auto_5 = __pad_PxkzrOlm1P3NpAKcN99DYV_0;
            }

            n18._Operations_.GetFormatFromStride(Input_In: __auto_5, Output_Out: out n17.PixelFormat Output_7);
            n19._Operations_.Switch_Boolean<n17.PixelFormat>(Condition_In: Output_2, Input_In: Output_7, Input_2_In: __pad_BYr2ykX4Cz4PSj499HwEOK_1, Output_Out: out n17.PixelFormat Output_8);
            int Input_9 = 0;
            n19._Operations_.Switch_Boolean<int>(Condition_In: Output_2, Input_In: Input_9, Input_2_In: __auto_5, Output_Out: out int Output_10);
            Stride_Out = Output_10;
            Format_Out = Output_8;
            return;
        }

        public static void EnsureFour(int Input_In, out int Output_Out)
        {
            int __pad_Jxi0i0cJjqcQXgMVMzORUm_0 = __slot_Jxi0i0cJjqcQXgMVMzORUm;
            n23._Operations_.Max<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Input_In, Input_2_In: __pad_Jxi0i0cJjqcQXgMVMzORUm_0, Output_Out: out int Output_1);
            Output_Out = Output_1;
            return;
        }

        public static void GetCountAndStrideAndFormat([n4.SerializedDefaultValueAttribute("0", false)] int Element_Count_In, int Element_Size_In_Bytes_In, n14.IGraphicsDataProvider Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Structured_Buffer_In, bool Allow_Raw_Views_In, out int Size_Out, out int Structure_Stride_Out, out n17.PixelFormat Format_Out)
        {
            int __pad_AkLZKj6aHsTNmUbs319DT4_0 = __slot_AkLZKj6aHsTNmUbs319DT4;
            n17.PixelFormat __pad_KROD5C9NYYwOLI5sFACyOl_1 = __slot_KROD5C9NYYwOLI5sFACyOl;
            n16._Operations_.ANDNOT(Input_In: Is_Structured_Buffer_In, Input_2_In: Allow_Raw_Views_In, Output_Out: out bool Output_2);
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            int __auto_5;
            int __auto_6;
            if (Result_3)
            {
                var Element_Size_In_Bytes_7 = Input_In.ElementSizeInBytes;
                var Size_In_Bytes_8 = Input_In.SizeInBytes;
                __auto_5 = Size_In_Bytes_8;
                __auto_6 = Element_Size_In_Bytes_7;
            }
            else
            {
                __auto_5 = 0;
                __auto_6 = __pad_AkLZKj6aHsTNmUbs319DT4_0;
            }

            n18._Operations_.GetFormatFromStride(Input_In: __auto_6, Output_Out: out n17.PixelFormat Output_9);
            n19._Operations_.Switch_Boolean<n17.PixelFormat>(Condition_In: Output_2, Input_In: Output_9, Input_2_In: __pad_KROD5C9NYYwOLI5sFACyOl_1, Output_Out: out n17.PixelFormat Output_10);
            n24._Operations_.ReplaceValue<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __auto_6, Replace_Value_In: Element_Size_In_Bytes_In, Output_Out: out int Output_11);
            int Input_12 = 0;
            n19._Operations_.Switch_Boolean<int>(Condition_In: Output_2, Input_In: Input_12, Input_2_In: Output_11, Output_Out: out int Output_13);
            var Output_14 = Element_Count_In * Output_11;
            n24._Operations_.ReplaceValue<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __auto_5, Replace_Value_In: Output_14, Output_Out: out int Output_15);
            n18._Operations_.EnsureFour(Input_In: Output_15, Output_Out: out int Output_16);
            Size_Out = Output_16;
            Structure_Stride_Out = Output_13;
            Format_Out = Output_10;
            return;
        }

        public static void BufferViewFlags(bool Is_Unordered_Access_In, n14.StructuredBufferType Structured_Buffer_Type_In, bool Is_Vertex_Buffer_In, bool Is_Index_Buffer_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Allow_Raw_Views_In, bool Is_Stream_Output_In, out n8.BufferFlags Output_Out)
        {
            bool __pad_VanDymO0ulePfnfGXHYEJz_0 = __slot_VanDymO0ulePfnfGXHYEJz;
            n18._Operations_.BufferFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Structured_Buffer_Type_In: Structured_Buffer_Type_In, Is_Vertex_Buffer_In: Is_Vertex_Buffer_In, Is_Index_Buffer_In: Is_Index_Buffer_In, Allow_Raw_Views_In: Allow_Raw_Views_In, Is_View_In: __pad_VanDymO0ulePfnfGXHYEJz_0, Is_Stream_Output_In: Is_Stream_Output_In, Output_Out: out n8.BufferFlags Output_1);
            Output_Out = Output_1;
            return;
        }

        [n1.ElementAttribute(TracingId = 108289U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F9EzfyGs93DPJLiClJ93Bi", Name = "__slot_F9EzfyGs93DPJLiClJ93Bi")]
        public static n8.BufferFlags __slot_F9EzfyGs93DPJLiClJ93Bi = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "F9EzfyGs93DPJLiClJ93Bi");
        [n1.ElementAttribute(TracingId = 108301U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NHXbU450JC4PY6cPGwrYvc", Name = "__slot_NHXbU450JC4PY6cPGwrYvc")]
        public static n8.BufferFlags __slot_NHXbU450JC4PY6cPGwrYvc = n1.CompilationHelper.Deserialize<n8.BufferFlags>("IndexBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "NHXbU450JC4PY6cPGwrYvc");
        [n1.ElementAttribute(TracingId = 108295U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UXdlSGuG5BzQAr8hlAl5dH", Name = "__slot_UXdlSGuG5BzQAr8hlAl5dH")]
        public static n8.BufferFlags __slot_UXdlSGuG5BzQAr8hlAl5dH = n1.CompilationHelper.Deserialize<n8.BufferFlags>("VertexBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "UXdlSGuG5BzQAr8hlAl5dH");
        [n1.ElementAttribute(TracingId = 108343U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PHM6SUOGo9yPGrlDKBcEeQ", Name = "__slot_PHM6SUOGo9yPGrlDKBcEeQ")]
        public static n8.BufferFlags __slot_PHM6SUOGo9yPGrlDKBcEeQ = n1.CompilationHelper.Deserialize<n8.BufferFlags>("UnorderedAccess", false, "Dky5PMnuvcKN4CxmfNs7Uv", "PHM6SUOGo9yPGrlDKBcEeQ");
        [n1.ElementAttribute(TracingId = 108325U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QXFb7n6ZLkmLLXUm7KBYEN", Name = "__slot_QXFb7n6ZLkmLLXUm7KBYEN")]
        public static n8.BufferFlags __slot_QXFb7n6ZLkmLLXUm7KBYEN = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "QXFb7n6ZLkmLLXUm7KBYEN");
        [n1.ElementAttribute(TracingId = 108368U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JAgZLwBjXwVQVLsVTlqXQW", Name = "__slot_JAgZLwBjXwVQVLsVTlqXQW")]
        public static n8.BufferFlags __slot_JAgZLwBjXwVQVLsVTlqXQW = n1.CompilationHelper.Deserialize<n8.BufferFlags>("StreamOutput", false, "Dky5PMnuvcKN4CxmfNs7Uv", "JAgZLwBjXwVQVLsVTlqXQW");
        [n1.ElementAttribute(TracingId = 108460U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IVaTdLrPphLQZsudLAUgM2", Name = "__slot_IVaTdLrPphLQZsudLAUgM2")]
        public static int __slot_IVaTdLrPphLQZsudLAUgM2 = 12;
        [n1.ElementAttribute(TracingId = 108429U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LNKP2jE496lLKQTPhmI8u2", Name = "__slot_LNKP2jE496lLKQTPhmI8u2")]
        public static n17.PixelFormat __slot_LNKP2jE496lLKQTPhmI8u2 = n1.CompilationHelper.Deserialize<n17.PixelFormat>("R32_Float", false, "Dky5PMnuvcKN4CxmfNs7Uv", "LNKP2jE496lLKQTPhmI8u2");
        [n1.ElementAttribute(TracingId = 108500U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EdwA6PRdqooMl3zKj5WDFi", Name = "__slot_EdwA6PRdqooMl3zKj5WDFi")]
        public static int __slot_EdwA6PRdqooMl3zKj5WDFi = 16;
        [n1.ElementAttribute(TracingId = 108436U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "ECgIHVQmSQrMZ42h38jPvr", Name = "__slot_ECgIHVQmSQrMZ42h38jPvr")]
        public static int __slot_ECgIHVQmSQrMZ42h38jPvr = 8;
        [n1.ElementAttribute(TracingId = 108426U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DdTopO8xYE5MmkMP3NFhAu", Name = "__slot_DdTopO8xYE5MmkMP3NFhAu")]
        public static n17.PixelFormat __slot_DdTopO8xYE5MmkMP3NFhAu = n1.CompilationHelper.Deserialize<n17.PixelFormat>("R32G32_Float", false, "Dky5PMnuvcKN4CxmfNs7Uv", "DdTopO8xYE5MmkMP3NFhAu");
        [n1.ElementAttribute(TracingId = 108451U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PuJg5iOIkElMZsuiheCO0p", Name = "__slot_PuJg5iOIkElMZsuiheCO0p")]
        public static n17.PixelFormat __slot_PuJg5iOIkElMZsuiheCO0p = n1.CompilationHelper.Deserialize<n17.PixelFormat>("R32G32B32_Float", false, "Dky5PMnuvcKN4CxmfNs7Uv", "PuJg5iOIkElMZsuiheCO0p");
        [n1.ElementAttribute(TracingId = 108489U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "ANVcAQmvk9OPomQqpuTuR4", Name = "__slot_ANVcAQmvk9OPomQqpuTuR4")]
        public static n17.PixelFormat __slot_ANVcAQmvk9OPomQqpuTuR4 = n1.CompilationHelper.Deserialize<n17.PixelFormat>("R32G32B32A32_Float", false, "Dky5PMnuvcKN4CxmfNs7Uv", "ANVcAQmvk9OPomQqpuTuR4");
        [n1.ElementAttribute(TracingId = 108580U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PxkzrOlm1P3NpAKcN99DYV", Name = "__slot_PxkzrOlm1P3NpAKcN99DYV")]
        public static int __slot_PxkzrOlm1P3NpAKcN99DYV = 4;
        [n1.ElementAttribute(TracingId = 108537U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BYr2ykX4Cz4PSj499HwEOK", Name = "__slot_BYr2ykX4Cz4PSj499HwEOK")]
        public static n17.PixelFormat __slot_BYr2ykX4Cz4PSj499HwEOK = n1.CompilationHelper.Deserialize<n17.PixelFormat>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "BYr2ykX4Cz4PSj499HwEOK");
        [n1.ElementAttribute(TracingId = 108670U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Jxi0i0cJjqcQXgMVMzORUm", Name = "__slot_Jxi0i0cJjqcQXgMVMzORUm")]
        public static int __slot_Jxi0i0cJjqcQXgMVMzORUm = 4;
        [n1.ElementAttribute(TracingId = 108760U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AkLZKj6aHsTNmUbs319DT4", Name = "__slot_AkLZKj6aHsTNmUbs319DT4")]
        public static int __slot_AkLZKj6aHsTNmUbs319DT4 = 4;
        [n1.ElementAttribute(TracingId = 108701U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KROD5C9NYYwOLI5sFACyOl", Name = "__slot_KROD5C9NYYwOLI5sFACyOl")]
        public static n17.PixelFormat __slot_KROD5C9NYYwOLI5sFACyOl = n1.CompilationHelper.Deserialize<n17.PixelFormat>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "KROD5C9NYYwOLI5sFACyOl");
        [n1.ElementAttribute(TracingId = 108923U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VanDymO0ulePfnfGXHYEJz", Name = "__slot_VanDymO0ulePfnfGXHYEJz")]
        public static bool __slot_VanDymO0ulePfnfGXHYEJz = true;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Buffers.Advanced
{
    [n1.ElementAttribute(TracingId = 111384U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DfBGipv0gMxM1yarAzmJmh", Name = "DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh")]
    [n2.SerializableAttribute]
    public class DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh Create(n1.NodeContext Node_Context)
        {
            var instance = new DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh CreateDefault()
        {
            var instance = new DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh Update(bool Recreate_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
        {
            var State_Output_1 = this.__p_BjlfULNJQ3TOnCTorZ98KP.Update(Simulate_In: Recreate_In, Output_Out: out bool Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_RBQFJAYHRD8Nspc1efKn5w;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Output_0 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__QYQ66yver3FPOxZaNxh5oV>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __QYQ66yver3FPOxZaNxh5oV(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_7.__p_BXg1SHl0PufQIWWHGA7SAn = node_8;
                    var node_9 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_7.__p_REYGhIHMfjDOqByvdtTZyW = node_9;
                    var node_10 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_7.__p_K7bfXw0Y7nmPblvKCbzDJm = node_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "LLIaUxgrnZQLoCF2DstPji", 111471U);
                    var Output_12 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>>.Create(Node_Context: Node_Context_11);
                    state_7.__p_LLIaUxgrnZQLoCF2DstPji = Output_12;
                }

                int __pad_JfsclSY8m6ANYuw9S9Khep_13 = __slot_JfsclSY8m6ANYuw9S9Khep;
                n8.BufferFlags __pad_SsQXCkHJCTAOWFUf2RuaUI_14 = __slot_SsQXCkHJCTAOWFUf2RuaUI;
                n8.BufferFlags __pad_FKnM0R7LNssQQYP5r4TQ4j_15 = __slot_FKnM0R7LNssQQYP5r4TQ4j;
                n8.BufferFlags __pad_V5FQnLZcrOtPZD8WPskDat_16 = __slot_V5FQnLZcrOtPZD8WPskDat;
                n8.BufferFlags __pad_JaF6mNH4XmmL4TW90rhtcn_17 = __slot_JaF6mNH4XmmL4TW90rhtcn;
                n26.Spread<uint> __pad_GfFq2uZpOAAQJ8Tdrplrvf_18 = __slot_GfFq2uZpOAAQJ8Tdrplrvf;
                n1.CompilationHelper.WritePin(state_7.__p_BXg1SHl0PufQIWWHGA7SAn.Inputs[0], ref __pad_JfsclSY8m6ANYuw9S9Khep_13);
                var Output_19 = __pad_SsQXCkHJCTAOWFUf2RuaUI_14 | __pad_FKnM0R7LNssQQYP5r4TQ4j_15;
                Output_19 = Output_19 | __pad_V5FQnLZcrOtPZD8WPskDat_16;
                Output_19 = Output_19 | __pad_JaF6mNH4XmmL4TW90rhtcn_17;
                n1.CompilationHelper.WritePin(state_7.__p_BXg1SHl0PufQIWWHGA7SAn.Inputs[3], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_BXg1SHl0PufQIWWHGA7SAn.Outputs[0], out n8.BufferDescription out_20);
                n1.CompilationHelper.WritePin(state_7.__p_K7bfXw0Y7nmPblvKCbzDJm.Inputs[0], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_K7bfXw0Y7nmPblvKCbzDJm.Outputs[0], out n14.BufferViewDescription out_21);
                n1.CompilationHelper.WritePin(state_7.__p_REYGhIHMfjDOqByvdtTZyW.Inputs[0], ref out_20);
                n1.CompilationHelper.WritePin(state_7.__p_REYGhIHMfjDOqByvdtTZyW.Inputs[1], ref out_21);
                int Offset_In_Bytes_22 = 0;
                bool Force_23 = false;
                bool SetInput_24 = true;
                var Output_25 = state_7.__p_LLIaUxgrnZQLoCF2DstPji;
                if (SetInput_24)
                {
                    Output_25 = state_7.__p_LLIaUxgrnZQLoCF2DstPji.SetInput<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __pad_GfFq2uZpOAAQJ8Tdrplrvf_18, Offset_In_Bytes_In: Offset_In_Bytes_22, Force_In: Force_23);
                }

                var State_Output_27 = Output_25.Update(Output_Out: out n14.IGraphicsDataProvider Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_REYGhIHMfjDOqByvdtTZyW.Inputs[2], ref Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_REYGhIHMfjDOqByvdtTZyW.Inputs[3], ref Output_0);
                n1.CompilationHelper.ReadPin(state_7.__p_REYGhIHMfjDOqByvdtTZyW.Outputs[0], out n8.Buffer out_28);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = state_7.__p_BXg1SHl0PufQIWWHGA7SAn != state_7.__p_BXg1SHl0PufQIWWHGA7SAn || state_7.__p_K7bfXw0Y7nmPblvKCbzDJm != state_7.__p_K7bfXw0Y7nmPblvKCbzDJm || state_7.__p_REYGhIHMfjDOqByvdtTZyW != state_7.__p_REYGhIHMfjDOqByvdtTZyW || State_Output_27 != state_7.__p_LLIaUxgrnZQLoCF2DstPji ? new __QYQ66yver3FPOxZaNxh5oV(state_7)
                    {__p_BXg1SHl0PufQIWWHGA7SAn = state_7.__p_BXg1SHl0PufQIWWHGA7SAn, __p_K7bfXw0Y7nmPblvKCbzDJm = state_7.__p_K7bfXw0Y7nmPblvKCbzDJm, __p_REYGhIHMfjDOqByvdtTZyW = state_7.__p_REYGhIHMfjDOqByvdtTZyW, __p_LLIaUxgrnZQLoCF2DstPji = State_Output_27} : state_7;
                else
                {
                    state_7.__p_BXg1SHl0PufQIWWHGA7SAn = state_7.__p_BXg1SHl0PufQIWWHGA7SAn;
                    state_7.__p_K7bfXw0Y7nmPblvKCbzDJm = state_7.__p_K7bfXw0Y7nmPblvKCbzDJm;
                    state_7.__p_REYGhIHMfjDOqByvdtTZyW = state_7.__p_REYGhIHMfjDOqByvdtTZyW;
                    state_7.__p_LLIaUxgrnZQLoCF2DstPji = State_Output_27;
                }

                outputs_5 = n2.ValueTuple.Create(out_28);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_29 = outputs_5.Item1;
            Output_Out = __auto_29;
            Has_Changed_Out = Has_Changed_6;
            n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = State_Output_1 != this.__p_BjlfULNJQ3TOnCTorZ98KP || manager_3 != this.__cache_RBQFJAYHRD8Nspc1efKn5w ? new DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(this)
                {__p_BjlfULNJQ3TOnCTorZ98KP = State_Output_1, __cache_RBQFJAYHRD8Nspc1efKn5w = manager_3} : that_30;
            else
            {
                this.__p_BjlfULNJQ3TOnCTorZ98KP = State_Output_1;
                this.__cache_RBQFJAYHRD8Nspc1efKn5w = manager_3;
            }

            return that_30;
        }

        public n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "BjlfULNJQ3TOnCTorZ98KP", 111940U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh that_2 = this;
            this.__p_BjlfULNJQ3TOnCTorZ98KP = Output_1;
            this.__cache_RBQFJAYHRD8Nspc1efKn5w = null;
            return that_2;
        }

        public n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh __CreateDefault__()
        {
            n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh that_0 = this;
            this.__p_BjlfULNJQ3TOnCTorZ98KP = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_RBQFJAYHRD8Nspc1efKn5w = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BjlfULNJQ3TOnCTorZ98KP);
            n1.CompilationHelper.SafeDispose(this.__cache_RBQFJAYHRD8Nspc1efKn5w);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 111940U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BjlfULNJQ3TOnCTorZ98KP", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_BjlfULNJQ3TOnCTorZ98KP;
        [n1.ElementAttribute(TracingId = 111390U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RBQFJAYHRD8Nspc1efKn5w", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_RBQFJAYHRD8Nspc1efKn5w = null;
        [n1.ElementAttribute(TracingId = 111425U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JfsclSY8m6ANYuw9S9Khep", Name = "__slot_JfsclSY8m6ANYuw9S9Khep")]
        public static int __slot_JfsclSY8m6ANYuw9S9Khep = 12;
        [n1.ElementAttribute(TracingId = 111440U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SsQXCkHJCTAOWFUf2RuaUI", Name = "__slot_SsQXCkHJCTAOWFUf2RuaUI")]
        public static n8.BufferFlags __slot_SsQXCkHJCTAOWFUf2RuaUI = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "SsQXCkHJCTAOWFUf2RuaUI");
        [n1.ElementAttribute(TracingId = 111462U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FKnM0R7LNssQQYP5r4TQ4j", Name = "__slot_FKnM0R7LNssQQYP5r4TQ4j")]
        public static n8.BufferFlags __slot_FKnM0R7LNssQQYP5r4TQ4j = n1.CompilationHelper.Deserialize<n8.BufferFlags>("UnorderedAccess", false, "Dky5PMnuvcKN4CxmfNs7Uv", "FKnM0R7LNssQQYP5r4TQ4j");
        [n1.ElementAttribute(TracingId = 111467U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "V5FQnLZcrOtPZD8WPskDat", Name = "__slot_V5FQnLZcrOtPZD8WPskDat")]
        public static n8.BufferFlags __slot_V5FQnLZcrOtPZD8WPskDat = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "V5FQnLZcrOtPZD8WPskDat");
        [n1.ElementAttribute(TracingId = 111434U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JaF6mNH4XmmL4TW90rhtcn", Name = "__slot_JaF6mNH4XmmL4TW90rhtcn")]
        public static n8.BufferFlags __slot_JaF6mNH4XmmL4TW90rhtcn = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ArgumentBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "JaF6mNH4XmmL4TW90rhtcn");
        [n1.ElementAttribute(TracingId = 111919U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GfFq2uZpOAAQJ8Tdrplrvf", Name = "__slot_GfFq2uZpOAAQJ8Tdrplrvf")]
        public static n26.Spread<uint> __slot_GfFq2uZpOAAQJ8Tdrplrvf = n1.CompilationHelper.Deserialize<n26.Spread<uint>>("1, 1, 1", false, "Dky5PMnuvcKN4CxmfNs7Uv", "GfFq2uZpOAAQJ8Tdrplrvf");
        static DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh()
        {
        }

        public DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh other): base(other)
        {
            this.__p_BjlfULNJQ3TOnCTorZ98KP = other.__p_BjlfULNJQ3TOnCTorZ98KP;
            this.__cache_RBQFJAYHRD8Nspc1efKn5w = other.__cache_RBQFJAYHRD8Nspc1efKn5w;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BjlfULNJQ3TOnCTorZ98KP", in __p_BjlfULNJQ3TOnCTorZ98KP), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RBQFJAYHRD8Nspc1efKn5w", in __cache_RBQFJAYHRD8Nspc1efKn5w));
        }

        internal DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh __WITH__(n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_BjlfULNJQ3TOnCTorZ98KP, n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_RBQFJAYHRD8Nspc1efKn5w)
        {
            n25.DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BjlfULNJQ3TOnCTorZ98KP != this.__p_BjlfULNJQ3TOnCTorZ98KP || __cache_RBQFJAYHRD8Nspc1efKn5w != this.__cache_RBQFJAYHRD8Nspc1efKn5w ? new DispatchArgsBuffer_DfBGipv0gMxM1yarAzmJmh(this)
                {__p_BjlfULNJQ3TOnCTorZ98KP = __p_BjlfULNJQ3TOnCTorZ98KP, __cache_RBQFJAYHRD8Nspc1efKn5w = __cache_RBQFJAYHRD8Nspc1efKn5w} : that_0;
            else
            {
                this.__p_BjlfULNJQ3TOnCTorZ98KP = __p_BjlfULNJQ3TOnCTorZ98KP;
                this.__cache_RBQFJAYHRD8Nspc1efKn5w = __cache_RBQFJAYHRD8Nspc1efKn5w;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QYQ66yver3FPOxZaNxh5oV", Name = "__QYQ66yver3FPOxZaNxh5oV")]
        [n2.SerializableAttribute]
        public class __QYQ66yver3FPOxZaNxh5oV : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BXg1SHl0PufQIWWHGA7SAn);
                n1.CompilationHelper.SafeDispose(this.__p_REYGhIHMfjDOqByvdtTZyW);
                n1.CompilationHelper.SafeDispose(this.__p_K7bfXw0Y7nmPblvKCbzDJm);
                n1.CompilationHelper.SafeDispose(this.__p_LLIaUxgrnZQLoCF2DstPji);
                return;
            }

            [n1.ElementAttribute(TracingId = 111401U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BXg1SHl0PufQIWWHGA7SAn", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_BXg1SHl0PufQIWWHGA7SAn;
            [n1.ElementAttribute(TracingId = 111413U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "REYGhIHMfjDOqByvdtTZyW", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_REYGhIHMfjDOqByvdtTZyW;
            [n1.ElementAttribute(TracingId = 111428U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K7bfXw0Y7nmPblvKCbzDJm", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_K7bfXw0Y7nmPblvKCbzDJm;
            [n1.ElementAttribute(TracingId = 111471U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LLIaUxgrnZQLoCF2DstPji", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_LLIaUxgrnZQLoCF2DstPji;
            public __QYQ66yver3FPOxZaNxh5oV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QYQ66yver3FPOxZaNxh5oV(__QYQ66yver3FPOxZaNxh5oV other): base(other)
            {
                this.__p_BXg1SHl0PufQIWWHGA7SAn = other.__p_BXg1SHl0PufQIWWHGA7SAn;
                this.__p_REYGhIHMfjDOqByvdtTZyW = other.__p_REYGhIHMfjDOqByvdtTZyW;
                this.__p_K7bfXw0Y7nmPblvKCbzDJm = other.__p_K7bfXw0Y7nmPblvKCbzDJm;
                this.__p_LLIaUxgrnZQLoCF2DstPji = other.__p_LLIaUxgrnZQLoCF2DstPji;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BXg1SHl0PufQIWWHGA7SAn", in __p_BXg1SHl0PufQIWWHGA7SAn), n1.CompilationHelper.GetValueOrExisting(values, "__p_REYGhIHMfjDOqByvdtTZyW", in __p_REYGhIHMfjDOqByvdtTZyW), n1.CompilationHelper.GetValueOrExisting(values, "__p_K7bfXw0Y7nmPblvKCbzDJm", in __p_K7bfXw0Y7nmPblvKCbzDJm), n1.CompilationHelper.GetValueOrExisting(values, "__p_LLIaUxgrnZQLoCF2DstPji", in __p_LLIaUxgrnZQLoCF2DstPji));
            }

            internal __QYQ66yver3FPOxZaNxh5oV __WITH__(n1.IVLNode __p_BXg1SHl0PufQIWWHGA7SAn, n1.IVLNode __p_REYGhIHMfjDOqByvdtTZyW, n1.IVLNode __p_K7bfXw0Y7nmPblvKCbzDJm, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_LLIaUxgrnZQLoCF2DstPji)
            {
                __QYQ66yver3FPOxZaNxh5oV that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BXg1SHl0PufQIWWHGA7SAn != this.__p_BXg1SHl0PufQIWWHGA7SAn || __p_REYGhIHMfjDOqByvdtTZyW != this.__p_REYGhIHMfjDOqByvdtTZyW || __p_K7bfXw0Y7nmPblvKCbzDJm != this.__p_K7bfXw0Y7nmPblvKCbzDJm || __p_LLIaUxgrnZQLoCF2DstPji != this.__p_LLIaUxgrnZQLoCF2DstPji ? new __QYQ66yver3FPOxZaNxh5oV(this)
                    {__p_BXg1SHl0PufQIWWHGA7SAn = __p_BXg1SHl0PufQIWWHGA7SAn, __p_REYGhIHMfjDOqByvdtTZyW = __p_REYGhIHMfjDOqByvdtTZyW, __p_K7bfXw0Y7nmPblvKCbzDJm = __p_K7bfXw0Y7nmPblvKCbzDJm, __p_LLIaUxgrnZQLoCF2DstPji = __p_LLIaUxgrnZQLoCF2DstPji} : that_0;
                else
                {
                    this.__p_BXg1SHl0PufQIWWHGA7SAn = __p_BXg1SHl0PufQIWWHGA7SAn;
                    this.__p_REYGhIHMfjDOqByvdtTZyW = __p_REYGhIHMfjDOqByvdtTZyW;
                    this.__p_K7bfXw0Y7nmPblvKCbzDJm = __p_K7bfXw0Y7nmPblvKCbzDJm;
                    this.__p_LLIaUxgrnZQLoCF2DstPji = __p_LLIaUxgrnZQLoCF2DstPji;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 112010U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "J7akI1tpQ2SQOwszi02xqf", Name = "DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf")]
    [n2.SerializableAttribute]
    public class DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf CreateDefault()
        {
            var instance = new DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf Update(bool Recreate_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
        {
            var State_Output_1 = this.__p_BV0w232dsKWNi6pZ9KHE65.Update(Simulate_In: Recreate_In, Output_Out: out bool Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_IYtHh7tBs3aPDeGjTt3lL7;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Output_0 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__AacYDmeBZxsNW1zAhTPqsI>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __AacYDmeBZxsNW1zAhTPqsI(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_7.__p_P1gokgKgipxQJyKAsYjMPB = node_8;
                    var node_9 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_7.__p_BpCHHeLTmAQOtr71RJRl0C = node_9;
                    var node_10 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_7.__p_HlwpNsUD1MmP096xGomn20 = node_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "IYOYPAza2uxOO2YdG18FZE", 112135U);
                    var Output_12 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>>.Create(Node_Context: Node_Context_11);
                    state_7.__p_IYOYPAza2uxOO2YdG18FZE = Output_12;
                }

                int __pad_PbwrqsfTAi7Lwh5C3lQP2E_13 = __slot_PbwrqsfTAi7Lwh5C3lQP2E;
                n8.BufferFlags __pad_FMMCqNejipjLX2yrWJVWKZ_14 = __slot_FMMCqNejipjLX2yrWJVWKZ;
                n8.BufferFlags __pad_F4RrLxd1tmWOEv3tG6gLuG_15 = __slot_F4RrLxd1tmWOEv3tG6gLuG;
                n8.BufferFlags __pad_QH14QdJCo49NeM0hfRQ8tU_16 = __slot_QH14QdJCo49NeM0hfRQ8tU;
                n8.BufferFlags __pad_J0r039JAl97Ll30V5nKVzF_17 = __slot_J0r039JAl97Ll30V5nKVzF;
                n26.Spread<uint> __pad_OAAJlUJ22iaNK4xKOa7yhs_18 = __slot_OAAJlUJ22iaNK4xKOa7yhs;
                n1.CompilationHelper.WritePin(state_7.__p_P1gokgKgipxQJyKAsYjMPB.Inputs[0], ref __pad_PbwrqsfTAi7Lwh5C3lQP2E_13);
                var Output_19 = __pad_FMMCqNejipjLX2yrWJVWKZ_14 | __pad_F4RrLxd1tmWOEv3tG6gLuG_15;
                Output_19 = Output_19 | __pad_QH14QdJCo49NeM0hfRQ8tU_16;
                Output_19 = Output_19 | __pad_J0r039JAl97Ll30V5nKVzF_17;
                n1.CompilationHelper.WritePin(state_7.__p_P1gokgKgipxQJyKAsYjMPB.Inputs[3], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_P1gokgKgipxQJyKAsYjMPB.Outputs[0], out n8.BufferDescription out_20);
                n1.CompilationHelper.WritePin(state_7.__p_HlwpNsUD1MmP096xGomn20.Inputs[0], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_HlwpNsUD1MmP096xGomn20.Outputs[0], out n14.BufferViewDescription out_21);
                n1.CompilationHelper.WritePin(state_7.__p_BpCHHeLTmAQOtr71RJRl0C.Inputs[0], ref out_20);
                n1.CompilationHelper.WritePin(state_7.__p_BpCHHeLTmAQOtr71RJRl0C.Inputs[1], ref out_21);
                int Offset_In_Bytes_22 = 0;
                bool Force_23 = false;
                bool SetInput_24 = true;
                var Output_25 = state_7.__p_IYOYPAza2uxOO2YdG18FZE;
                if (SetInput_24)
                {
                    Output_25 = state_7.__p_IYOYPAza2uxOO2YdG18FZE.SetInput<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __pad_OAAJlUJ22iaNK4xKOa7yhs_18, Offset_In_Bytes_In: Offset_In_Bytes_22, Force_In: Force_23);
                }

                var State_Output_27 = Output_25.Update(Output_Out: out n14.IGraphicsDataProvider Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_BpCHHeLTmAQOtr71RJRl0C.Inputs[2], ref Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_BpCHHeLTmAQOtr71RJRl0C.Inputs[3], ref Output_0);
                n1.CompilationHelper.ReadPin(state_7.__p_BpCHHeLTmAQOtr71RJRl0C.Outputs[0], out n8.Buffer out_28);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = state_7.__p_P1gokgKgipxQJyKAsYjMPB != state_7.__p_P1gokgKgipxQJyKAsYjMPB || state_7.__p_HlwpNsUD1MmP096xGomn20 != state_7.__p_HlwpNsUD1MmP096xGomn20 || state_7.__p_BpCHHeLTmAQOtr71RJRl0C != state_7.__p_BpCHHeLTmAQOtr71RJRl0C || State_Output_27 != state_7.__p_IYOYPAza2uxOO2YdG18FZE ? new __AacYDmeBZxsNW1zAhTPqsI(state_7)
                    {__p_P1gokgKgipxQJyKAsYjMPB = state_7.__p_P1gokgKgipxQJyKAsYjMPB, __p_HlwpNsUD1MmP096xGomn20 = state_7.__p_HlwpNsUD1MmP096xGomn20, __p_BpCHHeLTmAQOtr71RJRl0C = state_7.__p_BpCHHeLTmAQOtr71RJRl0C, __p_IYOYPAza2uxOO2YdG18FZE = State_Output_27} : state_7;
                else
                {
                    state_7.__p_P1gokgKgipxQJyKAsYjMPB = state_7.__p_P1gokgKgipxQJyKAsYjMPB;
                    state_7.__p_HlwpNsUD1MmP096xGomn20 = state_7.__p_HlwpNsUD1MmP096xGomn20;
                    state_7.__p_BpCHHeLTmAQOtr71RJRl0C = state_7.__p_BpCHHeLTmAQOtr71RJRl0C;
                    state_7.__p_IYOYPAza2uxOO2YdG18FZE = State_Output_27;
                }

                outputs_5 = n2.ValueTuple.Create(out_28);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_29 = outputs_5.Item1;
            Output_Out = __auto_29;
            Has_Changed_Out = Has_Changed_6;
            n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = State_Output_1 != this.__p_BV0w232dsKWNi6pZ9KHE65 || manager_3 != this.__cache_IYtHh7tBs3aPDeGjTt3lL7 ? new DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(this)
                {__p_BV0w232dsKWNi6pZ9KHE65 = State_Output_1, __cache_IYtHh7tBs3aPDeGjTt3lL7 = manager_3} : that_30;
            else
            {
                this.__p_BV0w232dsKWNi6pZ9KHE65 = State_Output_1;
                this.__cache_IYtHh7tBs3aPDeGjTt3lL7 = manager_3;
            }

            return that_30;
        }

        public n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "BV0w232dsKWNi6pZ9KHE65", 112197U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf that_2 = this;
            this.__p_BV0w232dsKWNi6pZ9KHE65 = Output_1;
            this.__cache_IYtHh7tBs3aPDeGjTt3lL7 = null;
            return that_2;
        }

        public n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf __CreateDefault__()
        {
            n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf that_0 = this;
            this.__p_BV0w232dsKWNi6pZ9KHE65 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_IYtHh7tBs3aPDeGjTt3lL7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BV0w232dsKWNi6pZ9KHE65);
            n1.CompilationHelper.SafeDispose(this.__cache_IYtHh7tBs3aPDeGjTt3lL7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 112197U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BV0w232dsKWNi6pZ9KHE65", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_BV0w232dsKWNi6pZ9KHE65;
        [n1.ElementAttribute(TracingId = 112019U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IYtHh7tBs3aPDeGjTt3lL7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_IYtHh7tBs3aPDeGjTt3lL7 = null;
        [n1.ElementAttribute(TracingId = 112076U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PbwrqsfTAi7Lwh5C3lQP2E", Name = "__slot_PbwrqsfTAi7Lwh5C3lQP2E")]
        public static int __slot_PbwrqsfTAi7Lwh5C3lQP2E = 16;
        [n1.ElementAttribute(TracingId = 112097U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FMMCqNejipjLX2yrWJVWKZ", Name = "__slot_FMMCqNejipjLX2yrWJVWKZ")]
        public static n8.BufferFlags __slot_FMMCqNejipjLX2yrWJVWKZ = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "FMMCqNejipjLX2yrWJVWKZ");
        [n1.ElementAttribute(TracingId = 112121U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F4RrLxd1tmWOEv3tG6gLuG", Name = "__slot_F4RrLxd1tmWOEv3tG6gLuG")]
        public static n8.BufferFlags __slot_F4RrLxd1tmWOEv3tG6gLuG = n1.CompilationHelper.Deserialize<n8.BufferFlags>("UnorderedAccess", false, "Dky5PMnuvcKN4CxmfNs7Uv", "F4RrLxd1tmWOEv3tG6gLuG");
        [n1.ElementAttribute(TracingId = 112127U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QH14QdJCo49NeM0hfRQ8tU", Name = "__slot_QH14QdJCo49NeM0hfRQ8tU")]
        public static n8.BufferFlags __slot_QH14QdJCo49NeM0hfRQ8tU = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "QH14QdJCo49NeM0hfRQ8tU");
        [n1.ElementAttribute(TracingId = 112094U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "J0r039JAl97Ll30V5nKVzF", Name = "__slot_J0r039JAl97Ll30V5nKVzF")]
        public static n8.BufferFlags __slot_J0r039JAl97Ll30V5nKVzF = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ArgumentBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "J0r039JAl97Ll30V5nKVzF");
        [n1.ElementAttribute(TracingId = 112164U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OAAJlUJ22iaNK4xKOa7yhs", Name = "__slot_OAAJlUJ22iaNK4xKOa7yhs")]
        public static n26.Spread<uint> __slot_OAAJlUJ22iaNK4xKOa7yhs = n1.CompilationHelper.Deserialize<n26.Spread<uint>>("1, 1, 0, 0", false, "Dky5PMnuvcKN4CxmfNs7Uv", "OAAJlUJ22iaNK4xKOa7yhs");
        static DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf()
        {
        }

        public DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf other): base(other)
        {
            this.__p_BV0w232dsKWNi6pZ9KHE65 = other.__p_BV0w232dsKWNi6pZ9KHE65;
            this.__cache_IYtHh7tBs3aPDeGjTt3lL7 = other.__cache_IYtHh7tBs3aPDeGjTt3lL7;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BV0w232dsKWNi6pZ9KHE65", in __p_BV0w232dsKWNi6pZ9KHE65), n1.CompilationHelper.GetValueOrExisting(values, "__cache_IYtHh7tBs3aPDeGjTt3lL7", in __cache_IYtHh7tBs3aPDeGjTt3lL7));
        }

        internal DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf __WITH__(n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_BV0w232dsKWNi6pZ9KHE65, n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_IYtHh7tBs3aPDeGjTt3lL7)
        {
            n25.DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BV0w232dsKWNi6pZ9KHE65 != this.__p_BV0w232dsKWNi6pZ9KHE65 || __cache_IYtHh7tBs3aPDeGjTt3lL7 != this.__cache_IYtHh7tBs3aPDeGjTt3lL7 ? new DrawArgsBuffer_J7akI1tpQ2SQOwszi02xqf(this)
                {__p_BV0w232dsKWNi6pZ9KHE65 = __p_BV0w232dsKWNi6pZ9KHE65, __cache_IYtHh7tBs3aPDeGjTt3lL7 = __cache_IYtHh7tBs3aPDeGjTt3lL7} : that_0;
            else
            {
                this.__p_BV0w232dsKWNi6pZ9KHE65 = __p_BV0w232dsKWNi6pZ9KHE65;
                this.__cache_IYtHh7tBs3aPDeGjTt3lL7 = __cache_IYtHh7tBs3aPDeGjTt3lL7;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AacYDmeBZxsNW1zAhTPqsI", Name = "__AacYDmeBZxsNW1zAhTPqsI")]
        [n2.SerializableAttribute]
        public class __AacYDmeBZxsNW1zAhTPqsI : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_P1gokgKgipxQJyKAsYjMPB);
                n1.CompilationHelper.SafeDispose(this.__p_BpCHHeLTmAQOtr71RJRl0C);
                n1.CompilationHelper.SafeDispose(this.__p_HlwpNsUD1MmP096xGomn20);
                n1.CompilationHelper.SafeDispose(this.__p_IYOYPAza2uxOO2YdG18FZE);
                return;
            }

            [n1.ElementAttribute(TracingId = 112035U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "P1gokgKgipxQJyKAsYjMPB", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_P1gokgKgipxQJyKAsYjMPB;
            [n1.ElementAttribute(TracingId = 112055U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BpCHHeLTmAQOtr71RJRl0C", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_BpCHHeLTmAQOtr71RJRl0C;
            [n1.ElementAttribute(TracingId = 112081U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HlwpNsUD1MmP096xGomn20", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_HlwpNsUD1MmP096xGomn20;
            [n1.ElementAttribute(TracingId = 112135U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IYOYPAza2uxOO2YdG18FZE", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_IYOYPAza2uxOO2YdG18FZE;
            public __AacYDmeBZxsNW1zAhTPqsI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __AacYDmeBZxsNW1zAhTPqsI(__AacYDmeBZxsNW1zAhTPqsI other): base(other)
            {
                this.__p_P1gokgKgipxQJyKAsYjMPB = other.__p_P1gokgKgipxQJyKAsYjMPB;
                this.__p_BpCHHeLTmAQOtr71RJRl0C = other.__p_BpCHHeLTmAQOtr71RJRl0C;
                this.__p_HlwpNsUD1MmP096xGomn20 = other.__p_HlwpNsUD1MmP096xGomn20;
                this.__p_IYOYPAza2uxOO2YdG18FZE = other.__p_IYOYPAza2uxOO2YdG18FZE;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_P1gokgKgipxQJyKAsYjMPB", in __p_P1gokgKgipxQJyKAsYjMPB), n1.CompilationHelper.GetValueOrExisting(values, "__p_BpCHHeLTmAQOtr71RJRl0C", in __p_BpCHHeLTmAQOtr71RJRl0C), n1.CompilationHelper.GetValueOrExisting(values, "__p_HlwpNsUD1MmP096xGomn20", in __p_HlwpNsUD1MmP096xGomn20), n1.CompilationHelper.GetValueOrExisting(values, "__p_IYOYPAza2uxOO2YdG18FZE", in __p_IYOYPAza2uxOO2YdG18FZE));
            }

            internal __AacYDmeBZxsNW1zAhTPqsI __WITH__(n1.IVLNode __p_P1gokgKgipxQJyKAsYjMPB, n1.IVLNode __p_BpCHHeLTmAQOtr71RJRl0C, n1.IVLNode __p_HlwpNsUD1MmP096xGomn20, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_IYOYPAza2uxOO2YdG18FZE)
            {
                __AacYDmeBZxsNW1zAhTPqsI that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_P1gokgKgipxQJyKAsYjMPB != this.__p_P1gokgKgipxQJyKAsYjMPB || __p_BpCHHeLTmAQOtr71RJRl0C != this.__p_BpCHHeLTmAQOtr71RJRl0C || __p_HlwpNsUD1MmP096xGomn20 != this.__p_HlwpNsUD1MmP096xGomn20 || __p_IYOYPAza2uxOO2YdG18FZE != this.__p_IYOYPAza2uxOO2YdG18FZE ? new __AacYDmeBZxsNW1zAhTPqsI(this)
                    {__p_P1gokgKgipxQJyKAsYjMPB = __p_P1gokgKgipxQJyKAsYjMPB, __p_BpCHHeLTmAQOtr71RJRl0C = __p_BpCHHeLTmAQOtr71RJRl0C, __p_HlwpNsUD1MmP096xGomn20 = __p_HlwpNsUD1MmP096xGomn20, __p_IYOYPAza2uxOO2YdG18FZE = __p_IYOYPAza2uxOO2YdG18FZE} : that_0;
                else
                {
                    this.__p_P1gokgKgipxQJyKAsYjMPB = __p_P1gokgKgipxQJyKAsYjMPB;
                    this.__p_BpCHHeLTmAQOtr71RJRl0C = __p_BpCHHeLTmAQOtr71RJRl0C;
                    this.__p_HlwpNsUD1MmP096xGomn20 = __p_HlwpNsUD1MmP096xGomn20;
                    this.__p_IYOYPAza2uxOO2YdG18FZE = __p_IYOYPAza2uxOO2YdG18FZE;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 112272U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EdSaGFFflOVMLSRyzUd2tq", Name = "DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq")]
    [n2.SerializableAttribute]
    public class DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq CreateDefault()
        {
            var instance = new DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq Update(bool Recreate_In, out n8.Buffer Output_Out, out bool Has_Changed_Out)
        {
            var State_Output_1 = this.__p_QlrUSrcxgq9OieqS8a29A6.Update(Simulate_In: Recreate_In, Output_Out: out bool Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_LN2YIfmck2FMUyorjhMbRM;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>>(n2.ValueTuple.Create(default(n8.Buffer)));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Output_0 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__SUCExnTPEI0LVmQ6ClKOJx>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __SUCExnTPEI0LVmQ6ClKOJx(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferDescription", "Stride.Graphics.Advanced");
                    state_7.__p_DAmaZMghsDgNi5JJhzVl1C = node_8;
                    var node_9 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Buffer", "Stride.Graphics.Advanced");
                    state_7.__p_NYZlD2TzfblPAGzdB6ECVa = node_9;
                    var node_10 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BufferViewDescription", "Stride.Graphics.Advanced");
                    state_7.__p_Vjt73Fzo3gcMWuAnP1piV4 = node_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "DVvgHBwvtzSOM9tG59wLgR", 112388U);
                    var Output_12 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>>.Create(Node_Context: Node_Context_11);
                    state_7.__p_DVvgHBwvtzSOM9tG59wLgR = Output_12;
                }

                int __pad_GN4BsjQwHztMzhJiNxgnoj_13 = __slot_GN4BsjQwHztMzhJiNxgnoj;
                n8.BufferFlags __pad_RIQzgnASVUQLOam0jNiG3X_14 = __slot_RIQzgnASVUQLOam0jNiG3X;
                n8.BufferFlags __pad_HbiG9ifUMwkMV1do8RvzmA_15 = __slot_HbiG9ifUMwkMV1do8RvzmA;
                n8.BufferFlags __pad_AOkszPWbTGeLlOYY64zkF0_16 = __slot_AOkszPWbTGeLlOYY64zkF0;
                n8.BufferFlags __pad_VSYTokSEzzpP1AdHlEYGe3_17 = __slot_VSYTokSEzzpP1AdHlEYGe3;
                n26.Spread<uint> __pad_B3dJb1IPyPyPUCpJ8KSJW8_18 = __slot_B3dJb1IPyPyPUCpJ8KSJW8;
                n1.CompilationHelper.WritePin(state_7.__p_DAmaZMghsDgNi5JJhzVl1C.Inputs[0], ref __pad_GN4BsjQwHztMzhJiNxgnoj_13);
                var Output_19 = __pad_RIQzgnASVUQLOam0jNiG3X_14 | __pad_HbiG9ifUMwkMV1do8RvzmA_15;
                Output_19 = Output_19 | __pad_AOkszPWbTGeLlOYY64zkF0_16;
                Output_19 = Output_19 | __pad_VSYTokSEzzpP1AdHlEYGe3_17;
                n1.CompilationHelper.WritePin(state_7.__p_DAmaZMghsDgNi5JJhzVl1C.Inputs[3], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_DAmaZMghsDgNi5JJhzVl1C.Outputs[0], out n8.BufferDescription out_20);
                n1.CompilationHelper.WritePin(state_7.__p_Vjt73Fzo3gcMWuAnP1piV4.Inputs[0], ref Output_19);
                n1.CompilationHelper.ReadPin(state_7.__p_Vjt73Fzo3gcMWuAnP1piV4.Outputs[0], out n14.BufferViewDescription out_21);
                n1.CompilationHelper.WritePin(state_7.__p_NYZlD2TzfblPAGzdB6ECVa.Inputs[0], ref out_20);
                n1.CompilationHelper.WritePin(state_7.__p_NYZlD2TzfblPAGzdB6ECVa.Inputs[1], ref out_21);
                int Offset_In_Bytes_22 = 0;
                bool Force_23 = false;
                bool SetInput_24 = true;
                var Output_25 = state_7.__p_DVvgHBwvtzSOM9tG59wLgR;
                if (SetInput_24)
                {
                    Output_25 = state_7.__p_DVvgHBwvtzSOM9tG59wLgR.SetInput<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __pad_B3dJb1IPyPyPUCpJ8KSJW8_18, Offset_In_Bytes_In: Offset_In_Bytes_22, Force_In: Force_23);
                }

                var State_Output_27 = Output_25.Update(Output_Out: out n14.IGraphicsDataProvider Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_NYZlD2TzfblPAGzdB6ECVa.Inputs[2], ref Output_26);
                n1.CompilationHelper.WritePin(state_7.__p_NYZlD2TzfblPAGzdB6ECVa.Inputs[3], ref Output_0);
                n1.CompilationHelper.ReadPin(state_7.__p_NYZlD2TzfblPAGzdB6ECVa.Outputs[0], out n8.Buffer out_28);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = state_7.__p_DAmaZMghsDgNi5JJhzVl1C != state_7.__p_DAmaZMghsDgNi5JJhzVl1C || state_7.__p_Vjt73Fzo3gcMWuAnP1piV4 != state_7.__p_Vjt73Fzo3gcMWuAnP1piV4 || state_7.__p_NYZlD2TzfblPAGzdB6ECVa != state_7.__p_NYZlD2TzfblPAGzdB6ECVa || State_Output_27 != state_7.__p_DVvgHBwvtzSOM9tG59wLgR ? new __SUCExnTPEI0LVmQ6ClKOJx(state_7)
                    {__p_DAmaZMghsDgNi5JJhzVl1C = state_7.__p_DAmaZMghsDgNi5JJhzVl1C, __p_Vjt73Fzo3gcMWuAnP1piV4 = state_7.__p_Vjt73Fzo3gcMWuAnP1piV4, __p_NYZlD2TzfblPAGzdB6ECVa = state_7.__p_NYZlD2TzfblPAGzdB6ECVa, __p_DVvgHBwvtzSOM9tG59wLgR = State_Output_27} : state_7;
                else
                {
                    state_7.__p_DAmaZMghsDgNi5JJhzVl1C = state_7.__p_DAmaZMghsDgNi5JJhzVl1C;
                    state_7.__p_Vjt73Fzo3gcMWuAnP1piV4 = state_7.__p_Vjt73Fzo3gcMWuAnP1piV4;
                    state_7.__p_NYZlD2TzfblPAGzdB6ECVa = state_7.__p_NYZlD2TzfblPAGzdB6ECVa;
                    state_7.__p_DVvgHBwvtzSOM9tG59wLgR = State_Output_27;
                }

                outputs_5 = n2.ValueTuple.Create(out_28);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_29 = outputs_5.Item1;
            Output_Out = __auto_29;
            Has_Changed_Out = Has_Changed_6;
            n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = State_Output_1 != this.__p_QlrUSrcxgq9OieqS8a29A6 || manager_3 != this.__cache_LN2YIfmck2FMUyorjhMbRM ? new DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(this)
                {__p_QlrUSrcxgq9OieqS8a29A6 = State_Output_1, __cache_LN2YIfmck2FMUyorjhMbRM = manager_3} : that_30;
            else
            {
                this.__p_QlrUSrcxgq9OieqS8a29A6 = State_Output_1;
                this.__cache_LN2YIfmck2FMUyorjhMbRM = manager_3;
            }

            return that_30;
        }

        public n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "QlrUSrcxgq9OieqS8a29A6", 112424U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq that_2 = this;
            this.__p_QlrUSrcxgq9OieqS8a29A6 = Output_1;
            this.__cache_LN2YIfmck2FMUyorjhMbRM = null;
            return that_2;
        }

        public n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq __CreateDefault__()
        {
            n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq that_0 = this;
            this.__p_QlrUSrcxgq9OieqS8a29A6 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_LN2YIfmck2FMUyorjhMbRM = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QlrUSrcxgq9OieqS8a29A6);
            n1.CompilationHelper.SafeDispose(this.__cache_LN2YIfmck2FMUyorjhMbRM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 112424U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QlrUSrcxgq9OieqS8a29A6", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_QlrUSrcxgq9OieqS8a29A6;
        [n1.ElementAttribute(TracingId = 112277U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LN2YIfmck2FMUyorjhMbRM", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_LN2YIfmck2FMUyorjhMbRM = null;
        [n1.ElementAttribute(TracingId = 112331U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GN4BsjQwHztMzhJiNxgnoj", Name = "__slot_GN4BsjQwHztMzhJiNxgnoj")]
        public static int __slot_GN4BsjQwHztMzhJiNxgnoj = 20;
        [n1.ElementAttribute(TracingId = 112358U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RIQzgnASVUQLOam0jNiG3X", Name = "__slot_RIQzgnASVUQLOam0jNiG3X")]
        public static n8.BufferFlags __slot_RIQzgnASVUQLOam0jNiG3X = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "RIQzgnASVUQLOam0jNiG3X");
        [n1.ElementAttribute(TracingId = 112378U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HbiG9ifUMwkMV1do8RvzmA", Name = "__slot_HbiG9ifUMwkMV1do8RvzmA")]
        public static n8.BufferFlags __slot_HbiG9ifUMwkMV1do8RvzmA = n1.CompilationHelper.Deserialize<n8.BufferFlags>("UnorderedAccess", false, "Dky5PMnuvcKN4CxmfNs7Uv", "HbiG9ifUMwkMV1do8RvzmA");
        [n1.ElementAttribute(TracingId = 112385U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AOkszPWbTGeLlOYY64zkF0", Name = "__slot_AOkszPWbTGeLlOYY64zkF0")]
        public static n8.BufferFlags __slot_AOkszPWbTGeLlOYY64zkF0 = n1.CompilationHelper.Deserialize<n8.BufferFlags>("RawBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "AOkszPWbTGeLlOYY64zkF0");
        [n1.ElementAttribute(TracingId = 112350U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VSYTokSEzzpP1AdHlEYGe3", Name = "__slot_VSYTokSEzzpP1AdHlEYGe3")]
        public static n8.BufferFlags __slot_VSYTokSEzzpP1AdHlEYGe3 = n1.CompilationHelper.Deserialize<n8.BufferFlags>("ArgumentBuffer", false, "Dky5PMnuvcKN4CxmfNs7Uv", "VSYTokSEzzpP1AdHlEYGe3");
        [n1.ElementAttribute(TracingId = 112412U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "B3dJb1IPyPyPUCpJ8KSJW8", Name = "__slot_B3dJb1IPyPyPUCpJ8KSJW8")]
        public static n26.Spread<uint> __slot_B3dJb1IPyPyPUCpJ8KSJW8 = n1.CompilationHelper.Deserialize<n26.Spread<uint>>("3, 1, 0, 0, 0", false, "Dky5PMnuvcKN4CxmfNs7Uv", "B3dJb1IPyPyPUCpJ8KSJW8");
        static DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq()
        {
        }

        public DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq other): base(other)
        {
            this.__p_QlrUSrcxgq9OieqS8a29A6 = other.__p_QlrUSrcxgq9OieqS8a29A6;
            this.__cache_LN2YIfmck2FMUyorjhMbRM = other.__cache_LN2YIfmck2FMUyorjhMbRM;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QlrUSrcxgq9OieqS8a29A6", in __p_QlrUSrcxgq9OieqS8a29A6), n1.CompilationHelper.GetValueOrExisting(values, "__cache_LN2YIfmck2FMUyorjhMbRM", in __cache_LN2YIfmck2FMUyorjhMbRM));
        }

        internal DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq __WITH__(n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_QlrUSrcxgq9OieqS8a29A6, n6.Manager<n2.ValueTuple, n2.ValueTuple<n8.Buffer>> __cache_LN2YIfmck2FMUyorjhMbRM)
        {
            n25.DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QlrUSrcxgq9OieqS8a29A6 != this.__p_QlrUSrcxgq9OieqS8a29A6 || __cache_LN2YIfmck2FMUyorjhMbRM != this.__cache_LN2YIfmck2FMUyorjhMbRM ? new DrawArgsBuffer_Indexed_EdSaGFFflOVMLSRyzUd2tq(this)
                {__p_QlrUSrcxgq9OieqS8a29A6 = __p_QlrUSrcxgq9OieqS8a29A6, __cache_LN2YIfmck2FMUyorjhMbRM = __cache_LN2YIfmck2FMUyorjhMbRM} : that_0;
            else
            {
                this.__p_QlrUSrcxgq9OieqS8a29A6 = __p_QlrUSrcxgq9OieqS8a29A6;
                this.__cache_LN2YIfmck2FMUyorjhMbRM = __cache_LN2YIfmck2FMUyorjhMbRM;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SUCExnTPEI0LVmQ6ClKOJx", Name = "__SUCExnTPEI0LVmQ6ClKOJx")]
        [n2.SerializableAttribute]
        public class __SUCExnTPEI0LVmQ6ClKOJx : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DAmaZMghsDgNi5JJhzVl1C);
                n1.CompilationHelper.SafeDispose(this.__p_NYZlD2TzfblPAGzdB6ECVa);
                n1.CompilationHelper.SafeDispose(this.__p_Vjt73Fzo3gcMWuAnP1piV4);
                n1.CompilationHelper.SafeDispose(this.__p_DVvgHBwvtzSOM9tG59wLgR);
                return;
            }

            [n1.ElementAttribute(TracingId = 112293U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DAmaZMghsDgNi5JJhzVl1C", Name = "BufferDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_DAmaZMghsDgNi5JJhzVl1C;
            [n1.ElementAttribute(TracingId = 112311U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NYZlD2TzfblPAGzdB6ECVa", Name = "Buffer", IsManaged = true, IsAutoGenerated = true, NodeName = "Buffer", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_NYZlD2TzfblPAGzdB6ECVa;
            [n1.ElementAttribute(TracingId = 112338U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Vjt73Fzo3gcMWuAnP1piV4", Name = "BufferViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "BufferViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Vjt73Fzo3gcMWuAnP1piV4;
            [n1.ElementAttribute(TracingId = 112388U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DVvgHBwvtzSOM9tG59wLgR", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_DVvgHBwvtzSOM9tG59wLgR;
            public __SUCExnTPEI0LVmQ6ClKOJx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SUCExnTPEI0LVmQ6ClKOJx(__SUCExnTPEI0LVmQ6ClKOJx other): base(other)
            {
                this.__p_DAmaZMghsDgNi5JJhzVl1C = other.__p_DAmaZMghsDgNi5JJhzVl1C;
                this.__p_NYZlD2TzfblPAGzdB6ECVa = other.__p_NYZlD2TzfblPAGzdB6ECVa;
                this.__p_Vjt73Fzo3gcMWuAnP1piV4 = other.__p_Vjt73Fzo3gcMWuAnP1piV4;
                this.__p_DVvgHBwvtzSOM9tG59wLgR = other.__p_DVvgHBwvtzSOM9tG59wLgR;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DAmaZMghsDgNi5JJhzVl1C", in __p_DAmaZMghsDgNi5JJhzVl1C), n1.CompilationHelper.GetValueOrExisting(values, "__p_NYZlD2TzfblPAGzdB6ECVa", in __p_NYZlD2TzfblPAGzdB6ECVa), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vjt73Fzo3gcMWuAnP1piV4", in __p_Vjt73Fzo3gcMWuAnP1piV4), n1.CompilationHelper.GetValueOrExisting(values, "__p_DVvgHBwvtzSOM9tG59wLgR", in __p_DVvgHBwvtzSOM9tG59wLgR));
            }

            internal __SUCExnTPEI0LVmQ6ClKOJx __WITH__(n1.IVLNode __p_DAmaZMghsDgNi5JJhzVl1C, n1.IVLNode __p_NYZlD2TzfblPAGzdB6ECVa, n1.IVLNode __p_Vjt73Fzo3gcMWuAnP1piV4, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<n26.Spread<uint>> __p_DVvgHBwvtzSOM9tG59wLgR)
            {
                __SUCExnTPEI0LVmQ6ClKOJx that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DAmaZMghsDgNi5JJhzVl1C != this.__p_DAmaZMghsDgNi5JJhzVl1C || __p_NYZlD2TzfblPAGzdB6ECVa != this.__p_NYZlD2TzfblPAGzdB6ECVa || __p_Vjt73Fzo3gcMWuAnP1piV4 != this.__p_Vjt73Fzo3gcMWuAnP1piV4 || __p_DVvgHBwvtzSOM9tG59wLgR != this.__p_DVvgHBwvtzSOM9tG59wLgR ? new __SUCExnTPEI0LVmQ6ClKOJx(this)
                    {__p_DAmaZMghsDgNi5JJhzVl1C = __p_DAmaZMghsDgNi5JJhzVl1C, __p_NYZlD2TzfblPAGzdB6ECVa = __p_NYZlD2TzfblPAGzdB6ECVa, __p_Vjt73Fzo3gcMWuAnP1piV4 = __p_Vjt73Fzo3gcMWuAnP1piV4, __p_DVvgHBwvtzSOM9tG59wLgR = __p_DVvgHBwvtzSOM9tG59wLgR} : that_0;
                else
                {
                    this.__p_DAmaZMghsDgNi5JJhzVl1C = __p_DAmaZMghsDgNi5JJhzVl1C;
                    this.__p_NYZlD2TzfblPAGzdB6ECVa = __p_NYZlD2TzfblPAGzdB6ECVa;
                    this.__p_Vjt73Fzo3gcMWuAnP1piV4 = __p_Vjt73Fzo3gcMWuAnP1piV4;
                    this.__p_DVvgHBwvtzSOM9tG59wLgR = __p_DVvgHBwvtzSOM9tG59wLgR;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures
{
    [n1.ElementAttribute(TracingId = 112493U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LP0S7rvH864PsdlvgOVWhx", Name = "CloneTexture_LP0S7rvH864PsdlvgOVWhx")]
    [n2.SerializableAttribute]
    public class CloneTexture_LP0S7rvH864PsdlvgOVWhx : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx Create(n1.NodeContext Node_Context)
        {
            var instance = new CloneTexture_LP0S7rvH864PsdlvgOVWhx(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx CreateDefault()
        {
            var instance = new CloneTexture_LP0S7rvH864PsdlvgOVWhx(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx Update(n8.Texture Input_In, bool Copy_Content_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Copy_Content_On_Clone_In, bool Force_In, n17.PixelFormat Format_In, n8.TextureFlags Flags_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Dispose_Cached_Texture_In, n8.TextureOptions Options_In, out n8.Texture Output_Out)
        {
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n8.Texture __auto_2;
            var state_3 = n1.CompilationHelper.Restore<__NBBumTPpQVkOWUEDNU19kK>(this.__if_FktktpFeZzCNv0TsoooZjw, __GetContext__());
            if (Result_0)
            {
                if (state_3 == null)
                {
                    state_3 = new __NBBumTPpQVkOWUEDNU19kK(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var manager_4 = state_3.__cache_Mg2lE1UzLXFMNPJ1gBtpnV;
                if (manager_4 is null)
                {
                    manager_4 = new n6.Manager<n2.ValueTuple<n8.Texture, n17.PixelFormat, n8.TextureFlags, n8.TextureOptions>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
                }

                var inputs_5 = (Input_In, Format_In, Flags_In, Options_In);
                var outputs_6 = manager_4.Outputs;
                var Has_Changed_7 = Force_In || manager_4.InputsChanged(inputs_5);
                if (Has_Changed_7)
                {
                    if (Dispose_Cached_Texture_In)
                        manager_4.DisposeOutputs();
                    n8.GraphicsResourceUsage Usage_9 = default(n8.GraphicsResourceUsage);
                    n28._Operations_.CloneWithOptions(Input_In: Input_In, Format_In: Format_In, Flags_In: Flags_In, Usage_In: Usage_9, Options_In: Options_In, Result_Out: out n8.Texture Result_10);
                    outputs_6 = n2.ValueTuple.Create(Result_10);
                    manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Texture_In, default, outputs_6);
                }
                else
                {
                    manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Texture_In);
                }

                var __auto_11 = outputs_6.Item1;
                var Output_12 = Copy_Content_On_Clone_In && Has_Changed_7;
                var Output_13 = Copy_Content_In || Output_12;
                var state_14 = n1.CompilationHelper.Restore<__M308IjzTG5rNCT8xHEdbzL>(state_3.__if_O5gNNxg0XgmNuTOBABNHMs, __GetContext__());
                if (Output_13)
                {
                    if (state_14 == null)
                    {
                        state_14 = new __M308IjzTG5rNCT8xHEdbzL(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "AOMMGoqxKnUPWPM11Wi3oc", 112580U);
                        var Output_16 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.Create(Node_Context_In: Node_Context_15);
                        state_14.__p_AOMMGoqxKnUPWPM11Wi3oc = Output_16;
                    }

                    var State_Output_18 = state_14.__p_AOMMGoqxKnUPWPM11Wi3oc.Update(Output_Out: out n8.GraphicsContext Output_17);
                    var Command_List_19 = Output_17.CommandList;
                    Command_List_19.Copy(source: Input_In, destination: __auto_11);
                    if (state_14.__GetContext__().IsImmutable)
                        state_14 = State_Output_18 != state_14.__p_AOMMGoqxKnUPWPM11Wi3oc ? new __M308IjzTG5rNCT8xHEdbzL(state_14)
                        {__p_AOMMGoqxKnUPWPM11Wi3oc = State_Output_18} : state_14;
                    else
                    {
                        state_14.__p_AOMMGoqxKnUPWPM11Wi3oc = State_Output_18;
                    }
                }

                __auto_2 = __auto_11;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_4 != state_3.__cache_Mg2lE1UzLXFMNPJ1gBtpnV || state_14 != state_3.__if_O5gNNxg0XgmNuTOBABNHMs ? new __NBBumTPpQVkOWUEDNU19kK(state_3)
                    {__cache_Mg2lE1UzLXFMNPJ1gBtpnV = manager_4, __if_O5gNNxg0XgmNuTOBABNHMs = state_14} : state_3;
                else
                {
                    state_3.__cache_Mg2lE1UzLXFMNPJ1gBtpnV = manager_4;
                    state_3.__if_O5gNNxg0XgmNuTOBABNHMs = state_14;
                }
            }
            else
            {
                __auto_2 = default(n8.Texture);
            }

            Output_Out = __auto_2;
            n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = state_3 != this.__if_FktktpFeZzCNv0TsoooZjw ? new CloneTexture_LP0S7rvH864PsdlvgOVWhx(this)
                {__if_FktktpFeZzCNv0TsoooZjw = state_3} : that_20;
            else
            {
                this.__if_FktktpFeZzCNv0TsoooZjw = state_3;
            }

            return that_20;
        }

        public n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx that_0 = this;
            this.__if_FktktpFeZzCNv0TsoooZjw = default(n2.Object);
            return that_0;
        }

        public n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx __CreateDefault__()
        {
            n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx that_0 = this;
            this.__if_FktktpFeZzCNv0TsoooZjw = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_FktktpFeZzCNv0TsoooZjw);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_FktktpFeZzCNv0TsoooZjw;
        public CloneTexture_LP0S7rvH864PsdlvgOVWhx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CloneTexture_LP0S7rvH864PsdlvgOVWhx(CloneTexture_LP0S7rvH864PsdlvgOVWhx other): base(other)
        {
            this.__if_FktktpFeZzCNv0TsoooZjw = other.__if_FktktpFeZzCNv0TsoooZjw;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_FktktpFeZzCNv0TsoooZjw", in __if_FktktpFeZzCNv0TsoooZjw));
        }

        internal CloneTexture_LP0S7rvH864PsdlvgOVWhx __WITH__(n2.Object __if_FktktpFeZzCNv0TsoooZjw)
        {
            n27.CloneTexture_LP0S7rvH864PsdlvgOVWhx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_FktktpFeZzCNv0TsoooZjw != this.__if_FktktpFeZzCNv0TsoooZjw ? new CloneTexture_LP0S7rvH864PsdlvgOVWhx(this)
                {__if_FktktpFeZzCNv0TsoooZjw = __if_FktktpFeZzCNv0TsoooZjw} : that_0;
            else
            {
                this.__if_FktktpFeZzCNv0TsoooZjw = __if_FktktpFeZzCNv0TsoooZjw;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NBBumTPpQVkOWUEDNU19kK", Name = "__NBBumTPpQVkOWUEDNU19kK")]
        [n2.SerializableAttribute]
        public class __NBBumTPpQVkOWUEDNU19kK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_Mg2lE1UzLXFMNPJ1gBtpnV);
                n1.CompilationHelper.SafeDispose(this.__if_O5gNNxg0XgmNuTOBABNHMs);
                return;
            }

            [n1.ElementAttribute(TracingId = 112508U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Mg2lE1UzLXFMNPJ1gBtpnV", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n6.Manager<n2.ValueTuple<n8.Texture, n17.PixelFormat, n8.TextureFlags, n8.TextureOptions>, n2.ValueTuple<n8.Texture>> __cache_Mg2lE1UzLXFMNPJ1gBtpnV = null;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_O5gNNxg0XgmNuTOBABNHMs;
            public __NBBumTPpQVkOWUEDNU19kK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NBBumTPpQVkOWUEDNU19kK(__NBBumTPpQVkOWUEDNU19kK other): base(other)
            {
                this.__cache_Mg2lE1UzLXFMNPJ1gBtpnV = other.__cache_Mg2lE1UzLXFMNPJ1gBtpnV;
                this.__if_O5gNNxg0XgmNuTOBABNHMs = other.__if_O5gNNxg0XgmNuTOBABNHMs;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Mg2lE1UzLXFMNPJ1gBtpnV", in __cache_Mg2lE1UzLXFMNPJ1gBtpnV), n1.CompilationHelper.GetValueOrExisting(values, "__if_O5gNNxg0XgmNuTOBABNHMs", in __if_O5gNNxg0XgmNuTOBABNHMs));
            }

            internal __NBBumTPpQVkOWUEDNU19kK __WITH__(n6.Manager<n2.ValueTuple<n8.Texture, n17.PixelFormat, n8.TextureFlags, n8.TextureOptions>, n2.ValueTuple<n8.Texture>> __cache_Mg2lE1UzLXFMNPJ1gBtpnV, n2.Object __if_O5gNNxg0XgmNuTOBABNHMs)
            {
                __NBBumTPpQVkOWUEDNU19kK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_Mg2lE1UzLXFMNPJ1gBtpnV != this.__cache_Mg2lE1UzLXFMNPJ1gBtpnV || __if_O5gNNxg0XgmNuTOBABNHMs != this.__if_O5gNNxg0XgmNuTOBABNHMs ? new __NBBumTPpQVkOWUEDNU19kK(this)
                    {__cache_Mg2lE1UzLXFMNPJ1gBtpnV = __cache_Mg2lE1UzLXFMNPJ1gBtpnV, __if_O5gNNxg0XgmNuTOBABNHMs = __if_O5gNNxg0XgmNuTOBABNHMs} : that_0;
                else
                {
                    this.__cache_Mg2lE1UzLXFMNPJ1gBtpnV = __cache_Mg2lE1UzLXFMNPJ1gBtpnV;
                    this.__if_O5gNNxg0XgmNuTOBABNHMs = __if_O5gNNxg0XgmNuTOBABNHMs;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "M308IjzTG5rNCT8xHEdbzL", Name = "__M308IjzTG5rNCT8xHEdbzL")]
        [n2.SerializableAttribute]
        public class __M308IjzTG5rNCT8xHEdbzL : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AOMMGoqxKnUPWPM11Wi3oc);
                return;
            }

            [n1.ElementAttribute(TracingId = 112580U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AOMMGoqxKnUPWPM11Wi3oc", Name = "GraphicsContext", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_AOMMGoqxKnUPWPM11Wi3oc;
            public __M308IjzTG5rNCT8xHEdbzL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __M308IjzTG5rNCT8xHEdbzL(__M308IjzTG5rNCT8xHEdbzL other): base(other)
            {
                this.__p_AOMMGoqxKnUPWPM11Wi3oc = other.__p_AOMMGoqxKnUPWPM11Wi3oc;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AOMMGoqxKnUPWPM11Wi3oc", in __p_AOMMGoqxKnUPWPM11Wi3oc));
            }

            internal __M308IjzTG5rNCT8xHEdbzL __WITH__(n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_AOMMGoqxKnUPWPM11Wi3oc)
            {
                __M308IjzTG5rNCT8xHEdbzL that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AOMMGoqxKnUPWPM11Wi3oc != this.__p_AOMMGoqxKnUPWPM11Wi3oc ? new __M308IjzTG5rNCT8xHEdbzL(this)
                    {__p_AOMMGoqxKnUPWPM11Wi3oc = __p_AOMMGoqxKnUPWPM11Wi3oc} : that_0;
                else
                {
                    this.__p_AOMMGoqxKnUPWPM11Wi3oc = __p_AOMMGoqxKnUPWPM11Wi3oc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 115326U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F1s6QlGyqF5NnwIq9Yu290", Name = "DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290")]
    [n2.SerializableAttribute]
    public class DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> CreateDefault()
        {
            var instance = new DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> Update<AdM>(T Input_In, [n4.SerializedDefaultValueAttribute("128, 128", false)] n12.Int2 Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, bool Recreate_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            int Offset_In_Bytes_1 = 0;
            bool Force_2 = false;
            bool SetInput_3 = true;
            var Output_4 = this.__p_AIyu9gHmzYnNLh1P6xtFa2;
            if (SetInput_3)
            {
                Output_4 = this.__p_AIyu9gHmzYnNLh1P6xtFa2.SetInput<AdM>(Input_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_1, Force_In: Force_2);
            }

            var State_Output_6 = Output_4.Update(Output_Out: out n14.IGraphicsDataProvider Output_5);
            n15._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_7);
            n5.ObjectHelpers.IsAssigned(x: Result_7, result: out bool Result_8, notAssigned: out bool Not_Assigned_9);
            var Output_10 = Result_8 && Apply_In;
            bool Dispose_Cached_Outputs_11 = false;
            var manager_12 = this.__cache_U1TQz7qmiD9L6PE7IS5DEb;
            if (manager_12 is null)
            {
                manager_12 = new n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_13 = (Size_In, Format_In);
            var outputs_14 = manager_12.Outputs;
            var Has_Changed_15 = Recreate_In || manager_12.InputsChanged(inputs_13);
            if (Has_Changed_15)
            {
                if (Dispose_Cached_Outputs_11)
                    manager_12.DisposeOutputs();
                var state_16 = n1.CompilationHelper.Restore<__Ru2VA3ZGzasLfP8rO7ixBh>(manager_12.State, __GetContext__());
                if (state_16 == null)
                {
                    state_16 = new __Ru2VA3ZGzasLfP8rO7ixBh(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_17 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_16.__p_MZLBPBbtLsGL0fcu7BYsv6 = node_17;
                    var node_18 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_16.__p_DnlcBKi2TfNLg4F80V1uT0 = node_18;
                    var node_19 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN = node_19;
                }

                n8.GraphicsResourceUsage __pad_FeDltGaW8q0PR4B9HXFXXn_20 = __slot_FeDltGaW8q0PR4B9HXFXXn;
                n29._Operations_.Split(Input_In: Size_In, X_Out: out int X_21, Y_Out: out int Y_22);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_21, Output_Out: out int Output_23);
                n1.CompilationHelper.WritePin(state_16.__p_DnlcBKi2TfNLg4F80V1uT0.Inputs[1], ref Output_23);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_22, Output_Out: out int Output_24);
                n1.CompilationHelper.WritePin(state_16.__p_DnlcBKi2TfNLg4F80V1uT0.Inputs[2], ref Output_24);
                n1.CompilationHelper.WritePin(state_16.__p_DnlcBKi2TfNLg4F80V1uT0.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_16.__p_DnlcBKi2TfNLg4F80V1uT0.Inputs[8], ref __pad_FeDltGaW8q0PR4B9HXFXXn_20);
                n1.CompilationHelper.ReadPin(state_16.__p_DnlcBKi2TfNLg4F80V1uT0.Outputs[0], out n8.TextureDescription out_25);
                n1.CompilationHelper.WritePin(state_16.__p_MZLBPBbtLsGL0fcu7BYsv6.Inputs[0], ref out_25);
                n1.CompilationHelper.WritePin(state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN.Outputs[0], out n8.TextureViewDescription out_26);
                n1.CompilationHelper.WritePin(state_16.__p_MZLBPBbtLsGL0fcu7BYsv6.Inputs[1], ref out_26);
                n1.CompilationHelper.WritePin(state_16.__p_MZLBPBbtLsGL0fcu7BYsv6.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_16.__p_MZLBPBbtLsGL0fcu7BYsv6.Outputs[0], out n8.Texture out_27);
                if (state_16.__GetContext__().IsImmutable)
                    state_16 = state_16.__p_DnlcBKi2TfNLg4F80V1uT0 != state_16.__p_DnlcBKi2TfNLg4F80V1uT0 || state_16.__p_MZLBPBbtLsGL0fcu7BYsv6 != state_16.__p_MZLBPBbtLsGL0fcu7BYsv6 || state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN != state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN ? new __Ru2VA3ZGzasLfP8rO7ixBh(state_16)
                    {__p_DnlcBKi2TfNLg4F80V1uT0 = state_16.__p_DnlcBKi2TfNLg4F80V1uT0, __p_MZLBPBbtLsGL0fcu7BYsv6 = state_16.__p_MZLBPBbtLsGL0fcu7BYsv6, __p_Tv8BtFk8WOFNQyGQdcJ6nN = state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN} : state_16;
                else
                {
                    state_16.__p_DnlcBKi2TfNLg4F80V1uT0 = state_16.__p_DnlcBKi2TfNLg4F80V1uT0;
                    state_16.__p_MZLBPBbtLsGL0fcu7BYsv6 = state_16.__p_MZLBPBbtLsGL0fcu7BYsv6;
                    state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN = state_16.__p_Tv8BtFk8WOFNQyGQdcJ6nN;
                }

                outputs_14 = n2.ValueTuple.Create(out_27);
                manager_12 = manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11, state_16, outputs_14);
            }
            else
            {
                manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11);
            }

            var __auto_28 = outputs_14.Item1;
            bool Re_Initialize_29 = false;
            var __fallback___30 = n1.ServiceRegistry.Current;
            n33._Operations_.Update_H<n2.Object, n8.Texture>(Input_In: this.__p_VlsZrTgXtJ2Mvh96XI1tER, Default_Output_In: __auto_28, Re_Initialize_In: Re_Initialize_29, Try_In: (n2.Object s_33) =>
            {
                using var __current_31 = __fallback___30.MakeCurrentIfNone();
                var state_32 = n1.CompilationHelper.Restore<__STPq6mDGlEAMidI47J4x9D>(s_33, __GetContext__());
                int Array_Slice_34 = 0;
                int Mip_Slice_35 = 0;
                n2.Nullable<n8.ResourceRegion> Region_36 = default(n2.Nullable<n8.ResourceRegion>);
                var State_Output_38 = state_32.__p_IIuKrAscJWvLmarsYiG9tf.Update(Input_In: __auto_28, Data_In: Output_5, Array_Slice_In: Array_Slice_34, Mip_Slice_In: Mip_Slice_35, Region_In: Region_36, Apply_In: Output_10, Output_Out: out n8.Texture Output_37);
                if (state_32.__GetContext__().IsImmutable)
                    state_32 = State_Output_38 != state_32.__p_IIuKrAscJWvLmarsYiG9tf ? new __STPq6mDGlEAMidI47J4x9D(state_32)
                    {__p_IIuKrAscJWvLmarsYiG9tf = State_Output_38} : state_32;
                else
                {
                    state_32.__p_IIuKrAscJWvLmarsYiG9tf = State_Output_38;
                }

                return n2.Tuple.Create<n2.Object, n8.Texture>(state_32, Output_37);
            }

            , Create_In: () =>
            {
                using var __current_39 = __fallback___30.MakeCurrentIfNone();
                var state_32 = new __STPq6mDGlEAMidI47J4x9D(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_40 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "IIuKrAscJWvLmarsYiG9tf", 115579U);
                var Output_41 = n31.SetData_FPEbMrBTNrWLDZKYInJXKW.Create(Node_Context: Node_Context_40);
                state_32.__p_IIuKrAscJWvLmarsYiG9tf = Output_41;
                return state_32;
            }

            , Output_Out: out n32.TryStateful<n2.Object> Output_42, Result_Out: out n8.Texture Result_43, Success_Out: out bool Success_44, Error_Message_Out: out string Error_Message_45);
            Output_Out = Result_43;
            Has_Changed_Out = Has_Changed_15;
            n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> that_46 = this;
            if (this.__GetContext__().IsImmutable)
                that_46 = State_Output_6 != this.__p_AIyu9gHmzYnNLh1P6xtFa2 || manager_12 != this.__cache_U1TQz7qmiD9L6PE7IS5DEb || Output_42 != this.__p_VlsZrTgXtJ2Mvh96XI1tER ? new DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T>(this)
                {__p_AIyu9gHmzYnNLh1P6xtFa2 = State_Output_6, __cache_U1TQz7qmiD9L6PE7IS5DEb = manager_12, __p_VlsZrTgXtJ2Mvh96XI1tER = Output_42} : that_46;
            else
            {
                this.__p_AIyu9gHmzYnNLh1P6xtFa2 = State_Output_6;
                this.__cache_U1TQz7qmiD9L6PE7IS5DEb = manager_12;
                this.__p_VlsZrTgXtJ2Mvh96XI1tER = Output_42;
            }

            return that_46;
        }

        public n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "AIyu9gHmzYnNLh1P6xtFa2", 115538U);
            var Output_1 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "VlsZrTgXtJ2Mvh96XI1tER", 115558U);
            n33._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_2, Output_Out: out n32.TryStateful<n2.Object> Output_3);
            n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> that_4 = this;
            this.__p_AIyu9gHmzYnNLh1P6xtFa2 = Output_1;
            this.__p_VlsZrTgXtJ2Mvh96XI1tER = Output_3;
            this.__cache_U1TQz7qmiD9L6PE7IS5DEb = null;
            return that_4;
        }

        public n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> __CreateDefault__()
        {
            n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> that_0 = this;
            this.__p_AIyu9gHmzYnNLh1P6xtFa2 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.CreateDefault();
            this.__cache_U1TQz7qmiD9L6PE7IS5DEb = null;
            this.__p_VlsZrTgXtJ2Mvh96XI1tER = default(n32.TryStateful<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AIyu9gHmzYnNLh1P6xtFa2);
            n1.CompilationHelper.SafeDispose(this.__cache_U1TQz7qmiD9L6PE7IS5DEb);
            n1.CompilationHelper.SafeDispose(this.__p_VlsZrTgXtJ2Mvh96XI1tER);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 115538U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AIyu9gHmzYnNLh1P6xtFa2", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_AIyu9gHmzYnNLh1P6xtFa2;
        [n1.ElementAttribute(TracingId = 115332U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "U1TQz7qmiD9L6PE7IS5DEb", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_U1TQz7qmiD9L6PE7IS5DEb = null;
        [n1.ElementAttribute(TracingId = 115365U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FeDltGaW8q0PR4B9HXFXXn", Name = "__slot_FeDltGaW8q0PR4B9HXFXXn")]
        public static n8.GraphicsResourceUsage __slot_FeDltGaW8q0PR4B9HXFXXn = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Dynamic", false, "Dky5PMnuvcKN4CxmfNs7Uv", "FeDltGaW8q0PR4B9HXFXXn");
        [n1.ElementAttribute(TracingId = 115558U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VlsZrTgXtJ2Mvh96XI1tER", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
        public n32.TryStateful<n2.Object> __p_VlsZrTgXtJ2Mvh96XI1tER;
        static DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290()
        {
        }

        public DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290(DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> other): base(other)
        {
            this.__p_AIyu9gHmzYnNLh1P6xtFa2 = other.__p_AIyu9gHmzYnNLh1P6xtFa2;
            this.__cache_U1TQz7qmiD9L6PE7IS5DEb = other.__cache_U1TQz7qmiD9L6PE7IS5DEb;
            this.__p_VlsZrTgXtJ2Mvh96XI1tER = other.__p_VlsZrTgXtJ2Mvh96XI1tER;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AIyu9gHmzYnNLh1P6xtFa2", in __p_AIyu9gHmzYnNLh1P6xtFa2), n1.CompilationHelper.GetValueOrExisting(values, "__cache_U1TQz7qmiD9L6PE7IS5DEb", in __cache_U1TQz7qmiD9L6PE7IS5DEb), n1.CompilationHelper.GetValueOrExisting(values, "__p_VlsZrTgXtJ2Mvh96XI1tER", in __p_VlsZrTgXtJ2Mvh96XI1tER));
        }

        internal DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> __WITH__(n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_AIyu9gHmzYnNLh1P6xtFa2, n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_U1TQz7qmiD9L6PE7IS5DEb, n32.TryStateful<n2.Object> __p_VlsZrTgXtJ2Mvh96XI1tER)
        {
            n27.DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AIyu9gHmzYnNLh1P6xtFa2 != this.__p_AIyu9gHmzYnNLh1P6xtFa2 || __cache_U1TQz7qmiD9L6PE7IS5DEb != this.__cache_U1TQz7qmiD9L6PE7IS5DEb || __p_VlsZrTgXtJ2Mvh96XI1tER != this.__p_VlsZrTgXtJ2Mvh96XI1tER ? new DynamicTexture2D_F1s6QlGyqF5NnwIq9Yu290<T>(this)
                {__p_AIyu9gHmzYnNLh1P6xtFa2 = __p_AIyu9gHmzYnNLh1P6xtFa2, __cache_U1TQz7qmiD9L6PE7IS5DEb = __cache_U1TQz7qmiD9L6PE7IS5DEb, __p_VlsZrTgXtJ2Mvh96XI1tER = __p_VlsZrTgXtJ2Mvh96XI1tER} : that_0;
            else
            {
                this.__p_AIyu9gHmzYnNLh1P6xtFa2 = __p_AIyu9gHmzYnNLh1P6xtFa2;
                this.__cache_U1TQz7qmiD9L6PE7IS5DEb = __cache_U1TQz7qmiD9L6PE7IS5DEb;
                this.__p_VlsZrTgXtJ2Mvh96XI1tER = __p_VlsZrTgXtJ2Mvh96XI1tER;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Ru2VA3ZGzasLfP8rO7ixBh", Name = "__Ru2VA3ZGzasLfP8rO7ixBh")]
        [n2.SerializableAttribute]
        public class __Ru2VA3ZGzasLfP8rO7ixBh : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MZLBPBbtLsGL0fcu7BYsv6);
                n1.CompilationHelper.SafeDispose(this.__p_DnlcBKi2TfNLg4F80V1uT0);
                n1.CompilationHelper.SafeDispose(this.__p_Tv8BtFk8WOFNQyGQdcJ6nN);
                return;
            }

            [n1.ElementAttribute(TracingId = 115373U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "MZLBPBbtLsGL0fcu7BYsv6", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_MZLBPBbtLsGL0fcu7BYsv6;
            [n1.ElementAttribute(TracingId = 115391U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DnlcBKi2TfNLg4F80V1uT0", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_DnlcBKi2TfNLg4F80V1uT0;
            [n1.ElementAttribute(TracingId = 115429U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Tv8BtFk8WOFNQyGQdcJ6nN", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Tv8BtFk8WOFNQyGQdcJ6nN;
            public __Ru2VA3ZGzasLfP8rO7ixBh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ru2VA3ZGzasLfP8rO7ixBh(__Ru2VA3ZGzasLfP8rO7ixBh other): base(other)
            {
                this.__p_MZLBPBbtLsGL0fcu7BYsv6 = other.__p_MZLBPBbtLsGL0fcu7BYsv6;
                this.__p_DnlcBKi2TfNLg4F80V1uT0 = other.__p_DnlcBKi2TfNLg4F80V1uT0;
                this.__p_Tv8BtFk8WOFNQyGQdcJ6nN = other.__p_Tv8BtFk8WOFNQyGQdcJ6nN;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MZLBPBbtLsGL0fcu7BYsv6", in __p_MZLBPBbtLsGL0fcu7BYsv6), n1.CompilationHelper.GetValueOrExisting(values, "__p_DnlcBKi2TfNLg4F80V1uT0", in __p_DnlcBKi2TfNLg4F80V1uT0), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tv8BtFk8WOFNQyGQdcJ6nN", in __p_Tv8BtFk8WOFNQyGQdcJ6nN));
            }

            internal __Ru2VA3ZGzasLfP8rO7ixBh __WITH__(n1.IVLNode __p_MZLBPBbtLsGL0fcu7BYsv6, n1.IVLNode __p_DnlcBKi2TfNLg4F80V1uT0, n1.IVLNode __p_Tv8BtFk8WOFNQyGQdcJ6nN)
            {
                __Ru2VA3ZGzasLfP8rO7ixBh that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MZLBPBbtLsGL0fcu7BYsv6 != this.__p_MZLBPBbtLsGL0fcu7BYsv6 || __p_DnlcBKi2TfNLg4F80V1uT0 != this.__p_DnlcBKi2TfNLg4F80V1uT0 || __p_Tv8BtFk8WOFNQyGQdcJ6nN != this.__p_Tv8BtFk8WOFNQyGQdcJ6nN ? new __Ru2VA3ZGzasLfP8rO7ixBh(this)
                    {__p_MZLBPBbtLsGL0fcu7BYsv6 = __p_MZLBPBbtLsGL0fcu7BYsv6, __p_DnlcBKi2TfNLg4F80V1uT0 = __p_DnlcBKi2TfNLg4F80V1uT0, __p_Tv8BtFk8WOFNQyGQdcJ6nN = __p_Tv8BtFk8WOFNQyGQdcJ6nN} : that_0;
                else
                {
                    this.__p_MZLBPBbtLsGL0fcu7BYsv6 = __p_MZLBPBbtLsGL0fcu7BYsv6;
                    this.__p_DnlcBKi2TfNLg4F80V1uT0 = __p_DnlcBKi2TfNLg4F80V1uT0;
                    this.__p_Tv8BtFk8WOFNQyGQdcJ6nN = __p_Tv8BtFk8WOFNQyGQdcJ6nN;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "STPq6mDGlEAMidI47J4x9D", Name = "__STPq6mDGlEAMidI47J4x9D")]
        [n2.SerializableAttribute]
        public class __STPq6mDGlEAMidI47J4x9D : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IIuKrAscJWvLmarsYiG9tf);
                return;
            }

            [n1.ElementAttribute(TracingId = 115579U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IIuKrAscJWvLmarsYiG9tf", Name = "SetData", IsManaged = true, IsAutoGenerated = true)]
            public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_IIuKrAscJWvLmarsYiG9tf;
            public __STPq6mDGlEAMidI47J4x9D(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __STPq6mDGlEAMidI47J4x9D(__STPq6mDGlEAMidI47J4x9D other): base(other)
            {
                this.__p_IIuKrAscJWvLmarsYiG9tf = other.__p_IIuKrAscJWvLmarsYiG9tf;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IIuKrAscJWvLmarsYiG9tf", in __p_IIuKrAscJWvLmarsYiG9tf));
            }

            internal __STPq6mDGlEAMidI47J4x9D __WITH__(n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_IIuKrAscJWvLmarsYiG9tf)
            {
                __STPq6mDGlEAMidI47J4x9D that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_IIuKrAscJWvLmarsYiG9tf != this.__p_IIuKrAscJWvLmarsYiG9tf ? new __STPq6mDGlEAMidI47J4x9D(this)
                    {__p_IIuKrAscJWvLmarsYiG9tf = __p_IIuKrAscJWvLmarsYiG9tf} : that_0;
                else
                {
                    this.__p_IIuKrAscJWvLmarsYiG9tf = __p_IIuKrAscJWvLmarsYiG9tf;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 115664U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Vao5mu9muXYOjpaceyFIMy", Name = "ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy")]
    [n2.SerializableAttribute]
    public class ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy CreateDefault()
        {
            var instance = new ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy Update([n4.SerializedDefaultValueAttribute("512, 512", false)] n12.Int2 Size_In, n14.IGraphicsDataProvider[] Initial_Data_In, [n4.SerializedDefaultValueAttribute("1", false)] int Array_Size_In, [n4.SerializedDefaultValueAttribute("1", false)] int Mip_Levels_In, [n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Unordered_Access_In, bool Is_Render_Target_In, bool Is_Depth_Stencil_In, bool Is_Shared_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_EmLFhtkVywgMc9gBrkiREb;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<n12.Int2, int, int, n17.PixelFormat, bool, bool, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_2 = (Size_In, Array_Size_In, Mip_Levels_In, Format_In, Is_Unordered_Access_In, Is_Render_Target_In, Is_Depth_Stencil_In, Is_Shared_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__FY2zHdGw2H3O1RMQwEQLyq>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __FY2zHdGw2H3O1RMQwEQLyq(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_5.__p_Hcdlhpo6B9rP1jwNddpWcb = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_5.__p_VYVSZ4C3ISlPTXHCljbgtx = node_7;
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_CNAhme1jNbUOQmWvXGkISU = node_8;
                }

                n8.GraphicsResourceUsage __pad_SPWa5jfRrBWOh7wp53DwP0_9 = __slot_SPWa5jfRrBWOh7wp53DwP0;
                n29._Operations_.Split(Input_In: Size_In, X_Out: out int X_10, Y_Out: out int Y_11);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_10, Output_Out: out int Output_12);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[1], ref Output_12);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_11, Output_Out: out int Output_13);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[2], ref Output_13);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[4], ref Array_Size_In);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[5], ref Mip_Levels_In);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[8], ref __pad_SPWa5jfRrBWOh7wp53DwP0_9);
                n34._Operations_.TextureFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Is_Render_Target_In: Is_Render_Target_In, Is_Depth_Stencil_In: Is_Depth_Stencil_In, Is_Shared_In: Is_Shared_In, Output_Out: out n8.TextureFlags Output_14, Options_Out: out n8.TextureOptions Options_15);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[9], ref Output_14);
                n1.CompilationHelper.WritePin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Inputs[10], ref Options_15);
                n1.CompilationHelper.ReadPin(state_5.__p_VYVSZ4C3ISlPTXHCljbgtx.Outputs[0], out n8.TextureDescription out_16);
                n1.CompilationHelper.WritePin(state_5.__p_Hcdlhpo6B9rP1jwNddpWcb.Inputs[0], ref out_16);
                n1.CompilationHelper.WritePin(state_5.__p_CNAhme1jNbUOQmWvXGkISU.Inputs[0], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_CNAhme1jNbUOQmWvXGkISU.Inputs[3], ref Output_14);
                n1.CompilationHelper.ReadPin(state_5.__p_CNAhme1jNbUOQmWvXGkISU.Outputs[0], out n8.TextureViewDescription out_17);
                n1.CompilationHelper.WritePin(state_5.__p_Hcdlhpo6B9rP1jwNddpWcb.Inputs[1], ref out_17);
                n1.CompilationHelper.WritePin(state_5.__p_Hcdlhpo6B9rP1jwNddpWcb.Inputs[2], ref Initial_Data_In);
                n1.CompilationHelper.WritePin(state_5.__p_Hcdlhpo6B9rP1jwNddpWcb.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_Hcdlhpo6B9rP1jwNddpWcb.Outputs[0], out n8.Texture out_18);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_VYVSZ4C3ISlPTXHCljbgtx != state_5.__p_VYVSZ4C3ISlPTXHCljbgtx || state_5.__p_Hcdlhpo6B9rP1jwNddpWcb != state_5.__p_Hcdlhpo6B9rP1jwNddpWcb || state_5.__p_CNAhme1jNbUOQmWvXGkISU != state_5.__p_CNAhme1jNbUOQmWvXGkISU ? new __FY2zHdGw2H3O1RMQwEQLyq(state_5)
                    {__p_VYVSZ4C3ISlPTXHCljbgtx = state_5.__p_VYVSZ4C3ISlPTXHCljbgtx, __p_Hcdlhpo6B9rP1jwNddpWcb = state_5.__p_Hcdlhpo6B9rP1jwNddpWcb, __p_CNAhme1jNbUOQmWvXGkISU = state_5.__p_CNAhme1jNbUOQmWvXGkISU} : state_5;
                else
                {
                    state_5.__p_VYVSZ4C3ISlPTXHCljbgtx = state_5.__p_VYVSZ4C3ISlPTXHCljbgtx;
                    state_5.__p_Hcdlhpo6B9rP1jwNddpWcb = state_5.__p_Hcdlhpo6B9rP1jwNddpWcb;
                    state_5.__p_CNAhme1jNbUOQmWvXGkISU = state_5.__p_CNAhme1jNbUOQmWvXGkISU;
                }

                outputs_3 = n2.ValueTuple.Create(out_18);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_19 = outputs_3.Item1;
            Output_Out = __auto_19;
            Has_Changed_Out = Has_Changed_4;
            n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = manager_1 != this.__cache_EmLFhtkVywgMc9gBrkiREb ? new ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(this)
                {__cache_EmLFhtkVywgMc9gBrkiREb = manager_1} : that_20;
            else
            {
                this.__cache_EmLFhtkVywgMc9gBrkiREb = manager_1;
            }

            return that_20;
        }

        public n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy that_0 = this;
            this.__cache_EmLFhtkVywgMc9gBrkiREb = null;
            return that_0;
        }

        public n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __CreateDefault__()
        {
            n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy that_0 = this;
            this.__cache_EmLFhtkVywgMc9gBrkiREb = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_EmLFhtkVywgMc9gBrkiREb);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 115668U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EmLFhtkVywgMc9gBrkiREb", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int2, int, int, n17.PixelFormat, bool, bool, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n8.Texture>> __cache_EmLFhtkVywgMc9gBrkiREb = null;
        [n1.ElementAttribute(TracingId = 115693U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SPWa5jfRrBWOh7wp53DwP0", Name = "__slot_SPWa5jfRrBWOh7wp53DwP0")]
        public static n8.GraphicsResourceUsage __slot_SPWa5jfRrBWOh7wp53DwP0 = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Default", false, "Dky5PMnuvcKN4CxmfNs7Uv", "SPWa5jfRrBWOh7wp53DwP0");
        static ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy()
        {
        }

        public ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy other): base(other)
        {
            this.__cache_EmLFhtkVywgMc9gBrkiREb = other.__cache_EmLFhtkVywgMc9gBrkiREb;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_EmLFhtkVywgMc9gBrkiREb", in __cache_EmLFhtkVywgMc9gBrkiREb));
        }

        internal ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __WITH__(n6.Manager<n2.ValueTuple<n12.Int2, int, int, n17.PixelFormat, bool, bool, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n8.Texture>> __cache_EmLFhtkVywgMc9gBrkiREb)
        {
            n27.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_EmLFhtkVywgMc9gBrkiREb != this.__cache_EmLFhtkVywgMc9gBrkiREb ? new ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy(this)
                {__cache_EmLFhtkVywgMc9gBrkiREb = __cache_EmLFhtkVywgMc9gBrkiREb} : that_0;
            else
            {
                this.__cache_EmLFhtkVywgMc9gBrkiREb = __cache_EmLFhtkVywgMc9gBrkiREb;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FY2zHdGw2H3O1RMQwEQLyq", Name = "__FY2zHdGw2H3O1RMQwEQLyq")]
        [n2.SerializableAttribute]
        public class __FY2zHdGw2H3O1RMQwEQLyq : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Hcdlhpo6B9rP1jwNddpWcb);
                n1.CompilationHelper.SafeDispose(this.__p_VYVSZ4C3ISlPTXHCljbgtx);
                n1.CompilationHelper.SafeDispose(this.__p_CNAhme1jNbUOQmWvXGkISU);
                return;
            }

            [n1.ElementAttribute(TracingId = 115697U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Hcdlhpo6B9rP1jwNddpWcb", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Hcdlhpo6B9rP1jwNddpWcb;
            [n1.ElementAttribute(TracingId = 115707U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VYVSZ4C3ISlPTXHCljbgtx", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_VYVSZ4C3ISlPTXHCljbgtx;
            [n1.ElementAttribute(TracingId = 115730U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CNAhme1jNbUOQmWvXGkISU", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_CNAhme1jNbUOQmWvXGkISU;
            public __FY2zHdGw2H3O1RMQwEQLyq(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FY2zHdGw2H3O1RMQwEQLyq(__FY2zHdGw2H3O1RMQwEQLyq other): base(other)
            {
                this.__p_Hcdlhpo6B9rP1jwNddpWcb = other.__p_Hcdlhpo6B9rP1jwNddpWcb;
                this.__p_VYVSZ4C3ISlPTXHCljbgtx = other.__p_VYVSZ4C3ISlPTXHCljbgtx;
                this.__p_CNAhme1jNbUOQmWvXGkISU = other.__p_CNAhme1jNbUOQmWvXGkISU;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Hcdlhpo6B9rP1jwNddpWcb", in __p_Hcdlhpo6B9rP1jwNddpWcb), n1.CompilationHelper.GetValueOrExisting(values, "__p_VYVSZ4C3ISlPTXHCljbgtx", in __p_VYVSZ4C3ISlPTXHCljbgtx), n1.CompilationHelper.GetValueOrExisting(values, "__p_CNAhme1jNbUOQmWvXGkISU", in __p_CNAhme1jNbUOQmWvXGkISU));
            }

            internal __FY2zHdGw2H3O1RMQwEQLyq __WITH__(n1.IVLNode __p_Hcdlhpo6B9rP1jwNddpWcb, n1.IVLNode __p_VYVSZ4C3ISlPTXHCljbgtx, n1.IVLNode __p_CNAhme1jNbUOQmWvXGkISU)
            {
                __FY2zHdGw2H3O1RMQwEQLyq that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Hcdlhpo6B9rP1jwNddpWcb != this.__p_Hcdlhpo6B9rP1jwNddpWcb || __p_VYVSZ4C3ISlPTXHCljbgtx != this.__p_VYVSZ4C3ISlPTXHCljbgtx || __p_CNAhme1jNbUOQmWvXGkISU != this.__p_CNAhme1jNbUOQmWvXGkISU ? new __FY2zHdGw2H3O1RMQwEQLyq(this)
                    {__p_Hcdlhpo6B9rP1jwNddpWcb = __p_Hcdlhpo6B9rP1jwNddpWcb, __p_VYVSZ4C3ISlPTXHCljbgtx = __p_VYVSZ4C3ISlPTXHCljbgtx, __p_CNAhme1jNbUOQmWvXGkISU = __p_CNAhme1jNbUOQmWvXGkISU} : that_0;
                else
                {
                    this.__p_Hcdlhpo6B9rP1jwNddpWcb = __p_Hcdlhpo6B9rP1jwNddpWcb;
                    this.__p_VYVSZ4C3ISlPTXHCljbgtx = __p_VYVSZ4C3ISlPTXHCljbgtx;
                    this.__p_CNAhme1jNbUOQmWvXGkISU = __p_CNAhme1jNbUOQmWvXGkISU;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 115842U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NlZ1Wiz1nSGLumavpcD7Fw", Name = "ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw")]
    [n2.SerializableAttribute]
    public class ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> CreateDefault<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> Update<AdM>(T Initial_Data_In, [n4.SerializedDefaultValueAttribute("128, 128", false)] n12.Int2 Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Recreate_On_Inital_Data_Change_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_GwWDqFcmI2rOzAOtlUrxgK.Update(Value_In: Initial_Data_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_4 = Result_1 && Recreate_On_Inital_Data_Change_In;
            var Output_5 = Output_4 || Recreate_In;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_Stunygs1ANQLDFgcUfVfZ8;
            if (manager_7 is null)
            {
                manager_7 = new n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_8 = (Size_In, Format_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Output_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__O4Ay9tjKluMM2jwCfXww4t>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __O4Ay9tjKluMM2jwCfXww4t(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_12 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_11.__p_Uwh84soVb35P2O7ACoEmsC = node_12;
                    var node_13 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_11.__p_UKYXFV8Zk8WQOH75DxwmcA = node_13;
                    var node_14 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_11.__p_J9X5IUq1LEwM2LLPqs17O0 = node_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "FXXROX7uerGLEz4PJnuyV0", 115887U);
                    var Output_16 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_15);
                    state_11.__p_FXXROX7uerGLEz4PJnuyV0 = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "FoGRF3h3hnXPYT6iydCX6a", 115896U);
                    var Output_18 = n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider>.Create(Node_Context: Node_Context_17);
                    state_11.__p_FoGRF3h3hnXPYT6iydCX6a = Output_18;
                }

                n8.GraphicsResourceUsage __pad_G79eHn2lZTyMOd1Rsw1RGX_19 = __slot_G79eHn2lZTyMOd1Rsw1RGX;
                n29._Operations_.Split(Input_In: Size_In, X_Out: out int X_20, Y_Out: out int Y_21);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_20, Output_Out: out int Output_22);
                n1.CompilationHelper.WritePin(state_11.__p_UKYXFV8Zk8WQOH75DxwmcA.Inputs[1], ref Output_22);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_21, Output_Out: out int Output_23);
                n1.CompilationHelper.WritePin(state_11.__p_UKYXFV8Zk8WQOH75DxwmcA.Inputs[2], ref Output_23);
                n1.CompilationHelper.WritePin(state_11.__p_UKYXFV8Zk8WQOH75DxwmcA.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_11.__p_UKYXFV8Zk8WQOH75DxwmcA.Inputs[8], ref __pad_G79eHn2lZTyMOd1Rsw1RGX_19);
                n1.CompilationHelper.ReadPin(state_11.__p_UKYXFV8Zk8WQOH75DxwmcA.Outputs[0], out n8.TextureDescription out_24);
                n1.CompilationHelper.WritePin(state_11.__p_Uwh84soVb35P2O7ACoEmsC.Inputs[0], ref out_24);
                n1.CompilationHelper.WritePin(state_11.__p_J9X5IUq1LEwM2LLPqs17O0.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_11.__p_J9X5IUq1LEwM2LLPqs17O0.Outputs[0], out n8.TextureViewDescription out_25);
                n1.CompilationHelper.WritePin(state_11.__p_Uwh84soVb35P2O7ACoEmsC.Inputs[1], ref out_25);
                int Offset_In_Bytes_26 = 0;
                bool Force_27 = false;
                bool SetInput_28 = true;
                var Output_29 = state_11.__p_FXXROX7uerGLEz4PJnuyV0;
                if (SetInput_28)
                {
                    Output_29 = state_11.__p_FXXROX7uerGLEz4PJnuyV0.SetInput<AdM>(Input_In: Initial_Data_In, Offset_In_Bytes_In: Offset_In_Bytes_26, Force_In: Force_27);
                }

                var State_Output_31 = Output_29.Update(Output_Out: out n14.IGraphicsDataProvider Output_30);
                bool Force_32 = false;
                var State_Output_34 = state_11.__p_FoGRF3h3hnXPYT6iydCX6a.Update(Input_In: Output_30, Force_In: Force_32, Output_Out: out n14.IGraphicsDataProvider[] Output_33);
                n1.CompilationHelper.WritePin(state_11.__p_Uwh84soVb35P2O7ACoEmsC.Inputs[2], ref Output_33);
                var Output_35 = Output_4 || Recreate_In;
                n1.CompilationHelper.WritePin(state_11.__p_Uwh84soVb35P2O7ACoEmsC.Inputs[3], ref Output_35);
                n1.CompilationHelper.ReadPin(state_11.__p_Uwh84soVb35P2O7ACoEmsC.Outputs[0], out n8.Texture out_36);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = state_11.__p_UKYXFV8Zk8WQOH75DxwmcA != state_11.__p_UKYXFV8Zk8WQOH75DxwmcA || state_11.__p_Uwh84soVb35P2O7ACoEmsC != state_11.__p_Uwh84soVb35P2O7ACoEmsC || state_11.__p_J9X5IUq1LEwM2LLPqs17O0 != state_11.__p_J9X5IUq1LEwM2LLPqs17O0 || State_Output_31 != state_11.__p_FXXROX7uerGLEz4PJnuyV0 || State_Output_34 != state_11.__p_FoGRF3h3hnXPYT6iydCX6a ? new __O4Ay9tjKluMM2jwCfXww4t(state_11)
                    {__p_UKYXFV8Zk8WQOH75DxwmcA = state_11.__p_UKYXFV8Zk8WQOH75DxwmcA, __p_Uwh84soVb35P2O7ACoEmsC = state_11.__p_Uwh84soVb35P2O7ACoEmsC, __p_J9X5IUq1LEwM2LLPqs17O0 = state_11.__p_J9X5IUq1LEwM2LLPqs17O0, __p_FXXROX7uerGLEz4PJnuyV0 = State_Output_31, __p_FoGRF3h3hnXPYT6iydCX6a = State_Output_34} : state_11;
                else
                {
                    state_11.__p_UKYXFV8Zk8WQOH75DxwmcA = state_11.__p_UKYXFV8Zk8WQOH75DxwmcA;
                    state_11.__p_Uwh84soVb35P2O7ACoEmsC = state_11.__p_Uwh84soVb35P2O7ACoEmsC;
                    state_11.__p_J9X5IUq1LEwM2LLPqs17O0 = state_11.__p_J9X5IUq1LEwM2LLPqs17O0;
                    state_11.__p_FXXROX7uerGLEz4PJnuyV0 = State_Output_31;
                    state_11.__p_FoGRF3h3hnXPYT6iydCX6a = State_Output_34;
                }

                outputs_9 = n2.ValueTuple.Create(out_36);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_37 = outputs_9.Item1;
            Output_Out = __auto_37;
            Has_Changed_Out = Has_Changed_10;
            n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = Output_3 != this.__p_GwWDqFcmI2rOzAOtlUrxgK || manager_7 != this.__cache_Stunygs1ANQLDFgcUfVfZ8 ? new ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T>(this)
                {__p_GwWDqFcmI2rOzAOtlUrxgK = Output_3, __cache_Stunygs1ANQLDFgcUfVfZ8 = manager_7} : that_38;
            else
            {
                this.__p_GwWDqFcmI2rOzAOtlUrxgK = Output_3;
                this.__cache_Stunygs1ANQLDFgcUfVfZ8 = manager_7;
            }

            return that_38;
        }

        public n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "GwWDqFcmI2rOzAOtlUrxgK", 115922U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> that_4 = this;
            this.__p_GwWDqFcmI2rOzAOtlUrxgK = Output_3;
            this.__cache_Stunygs1ANQLDFgcUfVfZ8 = null;
            return that_4;
        }

        public n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> __CreateDefault__<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> that_1 = this;
            this.__p_GwWDqFcmI2rOzAOtlUrxgK = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.CreateDefault<AdM>();
            this.__cache_Stunygs1ANQLDFgcUfVfZ8 = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GwWDqFcmI2rOzAOtlUrxgK);
            n1.CompilationHelper.SafeDispose(this.__cache_Stunygs1ANQLDFgcUfVfZ8);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 115922U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GwWDqFcmI2rOzAOtlUrxgK", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_GwWDqFcmI2rOzAOtlUrxgK;
        [n1.ElementAttribute(TracingId = 115846U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Stunygs1ANQLDFgcUfVfZ8", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_Stunygs1ANQLDFgcUfVfZ8 = null;
        [n1.ElementAttribute(TracingId = 115856U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "G79eHn2lZTyMOd1Rsw1RGX", Name = "__slot_G79eHn2lZTyMOd1Rsw1RGX")]
        public static n8.GraphicsResourceUsage __slot_G79eHn2lZTyMOd1Rsw1RGX = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "G79eHn2lZTyMOd1Rsw1RGX");
        static ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw()
        {
        }

        public ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw(ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> other): base(other)
        {
            this.__p_GwWDqFcmI2rOzAOtlUrxgK = other.__p_GwWDqFcmI2rOzAOtlUrxgK;
            this.__cache_Stunygs1ANQLDFgcUfVfZ8 = other.__cache_Stunygs1ANQLDFgcUfVfZ8;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GwWDqFcmI2rOzAOtlUrxgK", in __p_GwWDqFcmI2rOzAOtlUrxgK), n1.CompilationHelper.GetValueOrExisting(values, "__cache_Stunygs1ANQLDFgcUfVfZ8", in __cache_Stunygs1ANQLDFgcUfVfZ8));
        }

        internal ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> __WITH__(n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_GwWDqFcmI2rOzAOtlUrxgK, n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_Stunygs1ANQLDFgcUfVfZ8)
        {
            n27.ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GwWDqFcmI2rOzAOtlUrxgK != this.__p_GwWDqFcmI2rOzAOtlUrxgK || __cache_Stunygs1ANQLDFgcUfVfZ8 != this.__cache_Stunygs1ANQLDFgcUfVfZ8 ? new ImmutableTexture2D_NlZ1Wiz1nSGLumavpcD7Fw<T>(this)
                {__p_GwWDqFcmI2rOzAOtlUrxgK = __p_GwWDqFcmI2rOzAOtlUrxgK, __cache_Stunygs1ANQLDFgcUfVfZ8 = __cache_Stunygs1ANQLDFgcUfVfZ8} : that_0;
            else
            {
                this.__p_GwWDqFcmI2rOzAOtlUrxgK = __p_GwWDqFcmI2rOzAOtlUrxgK;
                this.__cache_Stunygs1ANQLDFgcUfVfZ8 = __cache_Stunygs1ANQLDFgcUfVfZ8;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "O4Ay9tjKluMM2jwCfXww4t", Name = "__O4Ay9tjKluMM2jwCfXww4t")]
        [n2.SerializableAttribute]
        public class __O4Ay9tjKluMM2jwCfXww4t : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Uwh84soVb35P2O7ACoEmsC);
                n1.CompilationHelper.SafeDispose(this.__p_UKYXFV8Zk8WQOH75DxwmcA);
                n1.CompilationHelper.SafeDispose(this.__p_J9X5IUq1LEwM2LLPqs17O0);
                n1.CompilationHelper.SafeDispose(this.__p_FXXROX7uerGLEz4PJnuyV0);
                n1.CompilationHelper.SafeDispose(this.__p_FoGRF3h3hnXPYT6iydCX6a);
                return;
            }

            [n1.ElementAttribute(TracingId = 115857U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Uwh84soVb35P2O7ACoEmsC", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Uwh84soVb35P2O7ACoEmsC;
            [n1.ElementAttribute(TracingId = 115863U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UKYXFV8Zk8WQOH75DxwmcA", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_UKYXFV8Zk8WQOH75DxwmcA;
            [n1.ElementAttribute(TracingId = 115876U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "J9X5IUq1LEwM2LLPqs17O0", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_J9X5IUq1LEwM2LLPqs17O0;
            [n1.ElementAttribute(TracingId = 115887U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FXXROX7uerGLEz4PJnuyV0", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_FXXROX7uerGLEz4PJnuyV0;
            [n1.ElementAttribute(TracingId = 115896U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FoGRF3h3hnXPYT6iydCX6a", Name = "FromValue", IsManaged = true, IsAutoGenerated = true)]
            public n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_FoGRF3h3hnXPYT6iydCX6a;
            public __O4Ay9tjKluMM2jwCfXww4t(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O4Ay9tjKluMM2jwCfXww4t(__O4Ay9tjKluMM2jwCfXww4t other): base(other)
            {
                this.__p_Uwh84soVb35P2O7ACoEmsC = other.__p_Uwh84soVb35P2O7ACoEmsC;
                this.__p_UKYXFV8Zk8WQOH75DxwmcA = other.__p_UKYXFV8Zk8WQOH75DxwmcA;
                this.__p_J9X5IUq1LEwM2LLPqs17O0 = other.__p_J9X5IUq1LEwM2LLPqs17O0;
                this.__p_FXXROX7uerGLEz4PJnuyV0 = other.__p_FXXROX7uerGLEz4PJnuyV0;
                this.__p_FoGRF3h3hnXPYT6iydCX6a = other.__p_FoGRF3h3hnXPYT6iydCX6a;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Uwh84soVb35P2O7ACoEmsC", in __p_Uwh84soVb35P2O7ACoEmsC), n1.CompilationHelper.GetValueOrExisting(values, "__p_UKYXFV8Zk8WQOH75DxwmcA", in __p_UKYXFV8Zk8WQOH75DxwmcA), n1.CompilationHelper.GetValueOrExisting(values, "__p_J9X5IUq1LEwM2LLPqs17O0", in __p_J9X5IUq1LEwM2LLPqs17O0), n1.CompilationHelper.GetValueOrExisting(values, "__p_FXXROX7uerGLEz4PJnuyV0", in __p_FXXROX7uerGLEz4PJnuyV0), n1.CompilationHelper.GetValueOrExisting(values, "__p_FoGRF3h3hnXPYT6iydCX6a", in __p_FoGRF3h3hnXPYT6iydCX6a));
            }

            internal __O4Ay9tjKluMM2jwCfXww4t __WITH__(n1.IVLNode __p_Uwh84soVb35P2O7ACoEmsC, n1.IVLNode __p_UKYXFV8Zk8WQOH75DxwmcA, n1.IVLNode __p_J9X5IUq1LEwM2LLPqs17O0, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_FXXROX7uerGLEz4PJnuyV0, n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_FoGRF3h3hnXPYT6iydCX6a)
            {
                __O4Ay9tjKluMM2jwCfXww4t that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Uwh84soVb35P2O7ACoEmsC != this.__p_Uwh84soVb35P2O7ACoEmsC || __p_UKYXFV8Zk8WQOH75DxwmcA != this.__p_UKYXFV8Zk8WQOH75DxwmcA || __p_J9X5IUq1LEwM2LLPqs17O0 != this.__p_J9X5IUq1LEwM2LLPqs17O0 || __p_FXXROX7uerGLEz4PJnuyV0 != this.__p_FXXROX7uerGLEz4PJnuyV0 || __p_FoGRF3h3hnXPYT6iydCX6a != this.__p_FoGRF3h3hnXPYT6iydCX6a ? new __O4Ay9tjKluMM2jwCfXww4t(this)
                    {__p_Uwh84soVb35P2O7ACoEmsC = __p_Uwh84soVb35P2O7ACoEmsC, __p_UKYXFV8Zk8WQOH75DxwmcA = __p_UKYXFV8Zk8WQOH75DxwmcA, __p_J9X5IUq1LEwM2LLPqs17O0 = __p_J9X5IUq1LEwM2LLPqs17O0, __p_FXXROX7uerGLEz4PJnuyV0 = __p_FXXROX7uerGLEz4PJnuyV0, __p_FoGRF3h3hnXPYT6iydCX6a = __p_FoGRF3h3hnXPYT6iydCX6a} : that_0;
                else
                {
                    this.__p_Uwh84soVb35P2O7ACoEmsC = __p_Uwh84soVb35P2O7ACoEmsC;
                    this.__p_UKYXFV8Zk8WQOH75DxwmcA = __p_UKYXFV8Zk8WQOH75DxwmcA;
                    this.__p_J9X5IUq1LEwM2LLPqs17O0 = __p_J9X5IUq1LEwM2LLPqs17O0;
                    this.__p_FXXROX7uerGLEz4PJnuyV0 = __p_FXXROX7uerGLEz4PJnuyV0;
                    this.__p_FoGRF3h3hnXPYT6iydCX6a = __p_FoGRF3h3hnXPYT6iydCX6a;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 116252U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "A5xFcqhGTHlMZboisCSd69", Name = "DynamicTexture3D_A5xFcqhGTHlMZboisCSd69")]
    [n2.SerializableAttribute]
    public class DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> CreateDefault()
        {
            var instance = new DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> Update<AdM>(T Input_In, [n4.SerializedDefaultValueAttribute("16, 16, 16", false)] n12.Int3 Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, bool Recreate_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            int Offset_In_Bytes_1 = 0;
            bool Force_2 = false;
            bool SetInput_3 = true;
            var Output_4 = this.__p_L4NUuHh7Cq3MWMDMbwNrMy;
            if (SetInput_3)
            {
                Output_4 = this.__p_L4NUuHh7Cq3MWMDMbwNrMy.SetInput<AdM>(Input_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_1, Force_In: Force_2);
            }

            var State_Output_6 = Output_4.Update(Output_Out: out n14.IGraphicsDataProvider Output_5);
            n15._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_7);
            n5.ObjectHelpers.IsAssigned(x: Result_7, result: out bool Result_8, notAssigned: out bool Not_Assigned_9);
            var Output_10 = Result_8 && Apply_In;
            bool Dispose_Cached_Outputs_11 = false;
            var manager_12 = this.__cache_K3trXq3aYRwMNQXMdm9RmY;
            if (manager_12 is null)
            {
                manager_12 = new n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_13 = (Size_In, Format_In);
            var outputs_14 = manager_12.Outputs;
            var Has_Changed_15 = Recreate_In || manager_12.InputsChanged(inputs_13);
            if (Has_Changed_15)
            {
                if (Dispose_Cached_Outputs_11)
                    manager_12.DisposeOutputs();
                var state_16 = n1.CompilationHelper.Restore<__Ry95y78KYorNnjqQzZnlBv>(manager_12.State, __GetContext__());
                if (state_16 == null)
                {
                    state_16 = new __Ry95y78KYorNnjqQzZnlBv(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_17 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_16.__p_UsqU78CBhepPslejS2f7kK = node_17;
                    var node_18 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_16.__p_OzKj8sjMDafPiYQy7bawxN = node_18;
                    var node_19 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_16.__p_DIF8pI3lDC3L9iSHOkEHL0 = node_19;
                }

                n17.TextureDimension __pad_LodqwtQanEkLgijY0XVIUx_20 = __slot_LodqwtQanEkLgijY0XVIUx;
                n8.GraphicsResourceUsage __pad_RqbmdpWWHeXLWkKaEtX46C_21 = __slot_RqbmdpWWHeXLWkKaEtX46C;
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[0], ref __pad_LodqwtQanEkLgijY0XVIUx_20);
                n35._Operations_.Split(Input_In: Size_In, X_Out: out int X_22, Y_Out: out int Y_23, Z_Out: out int Z_24);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_22, Output_Out: out int Output_25);
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[1], ref Output_25);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_23, Output_Out: out int Output_26);
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[2], ref Output_26);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Z_24, Output_Out: out int Output_27);
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[3], ref Output_27);
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Inputs[8], ref __pad_RqbmdpWWHeXLWkKaEtX46C_21);
                n1.CompilationHelper.ReadPin(state_16.__p_OzKj8sjMDafPiYQy7bawxN.Outputs[0], out n8.TextureDescription out_28);
                n1.CompilationHelper.WritePin(state_16.__p_UsqU78CBhepPslejS2f7kK.Inputs[0], ref out_28);
                n1.CompilationHelper.WritePin(state_16.__p_DIF8pI3lDC3L9iSHOkEHL0.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_16.__p_DIF8pI3lDC3L9iSHOkEHL0.Outputs[0], out n8.TextureViewDescription out_29);
                n1.CompilationHelper.WritePin(state_16.__p_UsqU78CBhepPslejS2f7kK.Inputs[1], ref out_29);
                n1.CompilationHelper.WritePin(state_16.__p_UsqU78CBhepPslejS2f7kK.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_16.__p_UsqU78CBhepPslejS2f7kK.Outputs[0], out n8.Texture out_30);
                if (state_16.__GetContext__().IsImmutable)
                    state_16 = state_16.__p_OzKj8sjMDafPiYQy7bawxN != state_16.__p_OzKj8sjMDafPiYQy7bawxN || state_16.__p_UsqU78CBhepPslejS2f7kK != state_16.__p_UsqU78CBhepPslejS2f7kK || state_16.__p_DIF8pI3lDC3L9iSHOkEHL0 != state_16.__p_DIF8pI3lDC3L9iSHOkEHL0 ? new __Ry95y78KYorNnjqQzZnlBv(state_16)
                    {__p_OzKj8sjMDafPiYQy7bawxN = state_16.__p_OzKj8sjMDafPiYQy7bawxN, __p_UsqU78CBhepPslejS2f7kK = state_16.__p_UsqU78CBhepPslejS2f7kK, __p_DIF8pI3lDC3L9iSHOkEHL0 = state_16.__p_DIF8pI3lDC3L9iSHOkEHL0} : state_16;
                else
                {
                    state_16.__p_OzKj8sjMDafPiYQy7bawxN = state_16.__p_OzKj8sjMDafPiYQy7bawxN;
                    state_16.__p_UsqU78CBhepPslejS2f7kK = state_16.__p_UsqU78CBhepPslejS2f7kK;
                    state_16.__p_DIF8pI3lDC3L9iSHOkEHL0 = state_16.__p_DIF8pI3lDC3L9iSHOkEHL0;
                }

                outputs_14 = n2.ValueTuple.Create(out_30);
                manager_12 = manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11, state_16, outputs_14);
            }
            else
            {
                manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11);
            }

            var __auto_31 = outputs_14.Item1;
            bool Re_Initialize_32 = false;
            var __fallback___33 = n1.ServiceRegistry.Current;
            n33._Operations_.Update_H<n2.Object, n8.Texture>(Input_In: this.__p_NsTxMqg7Zi8O7nYkThszRR, Default_Output_In: __auto_31, Re_Initialize_In: Re_Initialize_32, Try_In: (n2.Object s_36) =>
            {
                using var __current_34 = __fallback___33.MakeCurrentIfNone();
                var state_35 = n1.CompilationHelper.Restore<__B9Pb0didu7pMUBDi2k9Ctn>(s_36, __GetContext__());
                int Array_Slice_37 = 0;
                int Mip_Slice_38 = 0;
                n2.Nullable<n8.ResourceRegion> Region_39 = default(n2.Nullable<n8.ResourceRegion>);
                var State_Output_41 = state_35.__p_EcTDAdcOMQIOQS2Hh2XNzI.Update(Input_In: __auto_31, Data_In: Output_5, Array_Slice_In: Array_Slice_37, Mip_Slice_In: Mip_Slice_38, Region_In: Region_39, Apply_In: Output_10, Output_Out: out n8.Texture Output_40);
                if (state_35.__GetContext__().IsImmutable)
                    state_35 = State_Output_41 != state_35.__p_EcTDAdcOMQIOQS2Hh2XNzI ? new __B9Pb0didu7pMUBDi2k9Ctn(state_35)
                    {__p_EcTDAdcOMQIOQS2Hh2XNzI = State_Output_41} : state_35;
                else
                {
                    state_35.__p_EcTDAdcOMQIOQS2Hh2XNzI = State_Output_41;
                }

                return n2.Tuple.Create<n2.Object, n8.Texture>(state_35, Output_40);
            }

            , Create_In: () =>
            {
                using var __current_42 = __fallback___33.MakeCurrentIfNone();
                var state_35 = new __B9Pb0didu7pMUBDi2k9Ctn(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "EcTDAdcOMQIOQS2Hh2XNzI", 116499U);
                var Output_44 = n31.SetData_FPEbMrBTNrWLDZKYInJXKW.Create(Node_Context: Node_Context_43);
                state_35.__p_EcTDAdcOMQIOQS2Hh2XNzI = Output_44;
                return state_35;
            }

            , Output_Out: out n32.TryStateful<n2.Object> Output_45, Result_Out: out n8.Texture Result_46, Success_Out: out bool Success_47, Error_Message_Out: out string Error_Message_48);
            Output_Out = Result_46;
            Has_Changed_Out = Has_Changed_15;
            n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = State_Output_6 != this.__p_L4NUuHh7Cq3MWMDMbwNrMy || manager_12 != this.__cache_K3trXq3aYRwMNQXMdm9RmY || Output_45 != this.__p_NsTxMqg7Zi8O7nYkThszRR ? new DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T>(this)
                {__p_L4NUuHh7Cq3MWMDMbwNrMy = State_Output_6, __cache_K3trXq3aYRwMNQXMdm9RmY = manager_12, __p_NsTxMqg7Zi8O7nYkThszRR = Output_45} : that_49;
            else
            {
                this.__p_L4NUuHh7Cq3MWMDMbwNrMy = State_Output_6;
                this.__cache_K3trXq3aYRwMNQXMdm9RmY = manager_12;
                this.__p_NsTxMqg7Zi8O7nYkThszRR = Output_45;
            }

            return that_49;
        }

        public n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "L4NUuHh7Cq3MWMDMbwNrMy", 116453U);
            var Output_1 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "NsTxMqg7Zi8O7nYkThszRR", 116474U);
            n33._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_2, Output_Out: out n32.TryStateful<n2.Object> Output_3);
            n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> that_4 = this;
            this.__p_L4NUuHh7Cq3MWMDMbwNrMy = Output_1;
            this.__p_NsTxMqg7Zi8O7nYkThszRR = Output_3;
            this.__cache_K3trXq3aYRwMNQXMdm9RmY = null;
            return that_4;
        }

        public n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> __CreateDefault__()
        {
            n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> that_0 = this;
            this.__p_L4NUuHh7Cq3MWMDMbwNrMy = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.CreateDefault();
            this.__cache_K3trXq3aYRwMNQXMdm9RmY = null;
            this.__p_NsTxMqg7Zi8O7nYkThszRR = default(n32.TryStateful<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_L4NUuHh7Cq3MWMDMbwNrMy);
            n1.CompilationHelper.SafeDispose(this.__cache_K3trXq3aYRwMNQXMdm9RmY);
            n1.CompilationHelper.SafeDispose(this.__p_NsTxMqg7Zi8O7nYkThszRR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 116453U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "L4NUuHh7Cq3MWMDMbwNrMy", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_L4NUuHh7Cq3MWMDMbwNrMy;
        [n1.ElementAttribute(TracingId = 116260U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K3trXq3aYRwMNQXMdm9RmY", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_K3trXq3aYRwMNQXMdm9RmY = null;
        [n1.ElementAttribute(TracingId = 116400U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LodqwtQanEkLgijY0XVIUx", Name = "__slot_LodqwtQanEkLgijY0XVIUx")]
        public static n17.TextureDimension __slot_LodqwtQanEkLgijY0XVIUx = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture3D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "LodqwtQanEkLgijY0XVIUx");
        [n1.ElementAttribute(TracingId = 116282U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RqbmdpWWHeXLWkKaEtX46C", Name = "__slot_RqbmdpWWHeXLWkKaEtX46C")]
        public static n8.GraphicsResourceUsage __slot_RqbmdpWWHeXLWkKaEtX46C = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Dynamic", false, "Dky5PMnuvcKN4CxmfNs7Uv", "RqbmdpWWHeXLWkKaEtX46C");
        [n1.ElementAttribute(TracingId = 116474U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NsTxMqg7Zi8O7nYkThszRR", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
        public n32.TryStateful<n2.Object> __p_NsTxMqg7Zi8O7nYkThszRR;
        static DynamicTexture3D_A5xFcqhGTHlMZboisCSd69()
        {
        }

        public DynamicTexture3D_A5xFcqhGTHlMZboisCSd69(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DynamicTexture3D_A5xFcqhGTHlMZboisCSd69(DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> other): base(other)
        {
            this.__p_L4NUuHh7Cq3MWMDMbwNrMy = other.__p_L4NUuHh7Cq3MWMDMbwNrMy;
            this.__cache_K3trXq3aYRwMNQXMdm9RmY = other.__cache_K3trXq3aYRwMNQXMdm9RmY;
            this.__p_NsTxMqg7Zi8O7nYkThszRR = other.__p_NsTxMqg7Zi8O7nYkThszRR;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_L4NUuHh7Cq3MWMDMbwNrMy", in __p_L4NUuHh7Cq3MWMDMbwNrMy), n1.CompilationHelper.GetValueOrExisting(values, "__cache_K3trXq3aYRwMNQXMdm9RmY", in __cache_K3trXq3aYRwMNQXMdm9RmY), n1.CompilationHelper.GetValueOrExisting(values, "__p_NsTxMqg7Zi8O7nYkThszRR", in __p_NsTxMqg7Zi8O7nYkThszRR));
        }

        internal DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> __WITH__(n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_L4NUuHh7Cq3MWMDMbwNrMy, n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_K3trXq3aYRwMNQXMdm9RmY, n32.TryStateful<n2.Object> __p_NsTxMqg7Zi8O7nYkThszRR)
        {
            n27.DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_L4NUuHh7Cq3MWMDMbwNrMy != this.__p_L4NUuHh7Cq3MWMDMbwNrMy || __cache_K3trXq3aYRwMNQXMdm9RmY != this.__cache_K3trXq3aYRwMNQXMdm9RmY || __p_NsTxMqg7Zi8O7nYkThszRR != this.__p_NsTxMqg7Zi8O7nYkThszRR ? new DynamicTexture3D_A5xFcqhGTHlMZboisCSd69<T>(this)
                {__p_L4NUuHh7Cq3MWMDMbwNrMy = __p_L4NUuHh7Cq3MWMDMbwNrMy, __cache_K3trXq3aYRwMNQXMdm9RmY = __cache_K3trXq3aYRwMNQXMdm9RmY, __p_NsTxMqg7Zi8O7nYkThszRR = __p_NsTxMqg7Zi8O7nYkThszRR} : that_0;
            else
            {
                this.__p_L4NUuHh7Cq3MWMDMbwNrMy = __p_L4NUuHh7Cq3MWMDMbwNrMy;
                this.__cache_K3trXq3aYRwMNQXMdm9RmY = __cache_K3trXq3aYRwMNQXMdm9RmY;
                this.__p_NsTxMqg7Zi8O7nYkThszRR = __p_NsTxMqg7Zi8O7nYkThszRR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Ry95y78KYorNnjqQzZnlBv", Name = "__Ry95y78KYorNnjqQzZnlBv")]
        [n2.SerializableAttribute]
        public class __Ry95y78KYorNnjqQzZnlBv : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UsqU78CBhepPslejS2f7kK);
                n1.CompilationHelper.SafeDispose(this.__p_OzKj8sjMDafPiYQy7bawxN);
                n1.CompilationHelper.SafeDispose(this.__p_DIF8pI3lDC3L9iSHOkEHL0);
                return;
            }

            [n1.ElementAttribute(TracingId = 116286U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UsqU78CBhepPslejS2f7kK", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_UsqU78CBhepPslejS2f7kK;
            [n1.ElementAttribute(TracingId = 116307U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OzKj8sjMDafPiYQy7bawxN", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_OzKj8sjMDafPiYQy7bawxN;
            [n1.ElementAttribute(TracingId = 116339U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DIF8pI3lDC3L9iSHOkEHL0", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_DIF8pI3lDC3L9iSHOkEHL0;
            public __Ry95y78KYorNnjqQzZnlBv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ry95y78KYorNnjqQzZnlBv(__Ry95y78KYorNnjqQzZnlBv other): base(other)
            {
                this.__p_UsqU78CBhepPslejS2f7kK = other.__p_UsqU78CBhepPslejS2f7kK;
                this.__p_OzKj8sjMDafPiYQy7bawxN = other.__p_OzKj8sjMDafPiYQy7bawxN;
                this.__p_DIF8pI3lDC3L9iSHOkEHL0 = other.__p_DIF8pI3lDC3L9iSHOkEHL0;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UsqU78CBhepPslejS2f7kK", in __p_UsqU78CBhepPslejS2f7kK), n1.CompilationHelper.GetValueOrExisting(values, "__p_OzKj8sjMDafPiYQy7bawxN", in __p_OzKj8sjMDafPiYQy7bawxN), n1.CompilationHelper.GetValueOrExisting(values, "__p_DIF8pI3lDC3L9iSHOkEHL0", in __p_DIF8pI3lDC3L9iSHOkEHL0));
            }

            internal __Ry95y78KYorNnjqQzZnlBv __WITH__(n1.IVLNode __p_UsqU78CBhepPslejS2f7kK, n1.IVLNode __p_OzKj8sjMDafPiYQy7bawxN, n1.IVLNode __p_DIF8pI3lDC3L9iSHOkEHL0)
            {
                __Ry95y78KYorNnjqQzZnlBv that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UsqU78CBhepPslejS2f7kK != this.__p_UsqU78CBhepPslejS2f7kK || __p_OzKj8sjMDafPiYQy7bawxN != this.__p_OzKj8sjMDafPiYQy7bawxN || __p_DIF8pI3lDC3L9iSHOkEHL0 != this.__p_DIF8pI3lDC3L9iSHOkEHL0 ? new __Ry95y78KYorNnjqQzZnlBv(this)
                    {__p_UsqU78CBhepPslejS2f7kK = __p_UsqU78CBhepPslejS2f7kK, __p_OzKj8sjMDafPiYQy7bawxN = __p_OzKj8sjMDafPiYQy7bawxN, __p_DIF8pI3lDC3L9iSHOkEHL0 = __p_DIF8pI3lDC3L9iSHOkEHL0} : that_0;
                else
                {
                    this.__p_UsqU78CBhepPslejS2f7kK = __p_UsqU78CBhepPslejS2f7kK;
                    this.__p_OzKj8sjMDafPiYQy7bawxN = __p_OzKj8sjMDafPiYQy7bawxN;
                    this.__p_DIF8pI3lDC3L9iSHOkEHL0 = __p_DIF8pI3lDC3L9iSHOkEHL0;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "B9Pb0didu7pMUBDi2k9Ctn", Name = "__B9Pb0didu7pMUBDi2k9Ctn")]
        [n2.SerializableAttribute]
        public class __B9Pb0didu7pMUBDi2k9Ctn : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EcTDAdcOMQIOQS2Hh2XNzI);
                return;
            }

            [n1.ElementAttribute(TracingId = 116499U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EcTDAdcOMQIOQS2Hh2XNzI", Name = "SetData", IsManaged = true, IsAutoGenerated = true)]
            public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_EcTDAdcOMQIOQS2Hh2XNzI;
            public __B9Pb0didu7pMUBDi2k9Ctn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __B9Pb0didu7pMUBDi2k9Ctn(__B9Pb0didu7pMUBDi2k9Ctn other): base(other)
            {
                this.__p_EcTDAdcOMQIOQS2Hh2XNzI = other.__p_EcTDAdcOMQIOQS2Hh2XNzI;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EcTDAdcOMQIOQS2Hh2XNzI", in __p_EcTDAdcOMQIOQS2Hh2XNzI));
            }

            internal __B9Pb0didu7pMUBDi2k9Ctn __WITH__(n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_EcTDAdcOMQIOQS2Hh2XNzI)
            {
                __B9Pb0didu7pMUBDi2k9Ctn that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EcTDAdcOMQIOQS2Hh2XNzI != this.__p_EcTDAdcOMQIOQS2Hh2XNzI ? new __B9Pb0didu7pMUBDi2k9Ctn(this)
                    {__p_EcTDAdcOMQIOQS2Hh2XNzI = __p_EcTDAdcOMQIOQS2Hh2XNzI} : that_0;
                else
                {
                    this.__p_EcTDAdcOMQIOQS2Hh2XNzI = __p_EcTDAdcOMQIOQS2Hh2XNzI;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 116642U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SO197zGpVYsOMINttv8noS", Name = "ComputeTexture3D_SO197zGpVYsOMINttv8noS")]
    [n2.SerializableAttribute]
    public class ComputeTexture3D_SO197zGpVYsOMINttv8noS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputeTexture3D_SO197zGpVYsOMINttv8noS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS CreateDefault()
        {
            var instance = new ComputeTexture3D_SO197zGpVYsOMINttv8noS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS Update([n4.SerializedDefaultValueAttribute("16, 16, 16", false)] n12.Int3 Size_In, n14.IGraphicsDataProvider[] Initial_Data_In, [n4.SerializedDefaultValueAttribute("1", false)] int Array_Size_In, [n4.SerializedDefaultValueAttribute("1", false)] int Mip_Levels_In, [n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Unordered_Access_In, bool Is_Render_Target_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_NyHcAs0TyBfMvZfZevzL9r;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<n12.Int3, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_2 = (Size_In, Array_Size_In, Mip_Levels_In, Format_In, Is_Unordered_Access_In, Is_Render_Target_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__B8rSFk1C2rHNxZChOjDvQB>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __B8rSFk1C2rHNxZChOjDvQB(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_5.__p_AdjkAleZX7vMr1GSRtdjzJ = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_5.__p_Vxrso0LBP1RQN1YMOaTYPp = node_7;
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_FksvlreNf9pNrmuEZjwKr1 = node_8;
                }

                n17.TextureDimension __pad_NzPs3dOUXKnQYArAZkXJVG_9 = __slot_NzPs3dOUXKnQYArAZkXJVG;
                n8.GraphicsResourceUsage __pad_IaJnAmYIas0MSkx5wfK8x1_10 = __slot_IaJnAmYIas0MSkx5wfK8x1;
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[0], ref __pad_NzPs3dOUXKnQYArAZkXJVG_9);
                n35._Operations_.Split(Input_In: Size_In, X_Out: out int X_11, Y_Out: out int Y_12, Z_Out: out int Z_13);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_11, Output_Out: out int Output_14);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[1], ref Output_14);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_12, Output_Out: out int Output_15);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[2], ref Output_15);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Z_13, Output_Out: out int Output_16);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[3], ref Output_16);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[4], ref Array_Size_In);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[5], ref Mip_Levels_In);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[8], ref __pad_IaJnAmYIas0MSkx5wfK8x1_10);
                bool Is_Depth_Stencil_17 = false;
                bool Is_Shared_18 = false;
                n34._Operations_.TextureFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Is_Render_Target_In: Is_Render_Target_In, Is_Depth_Stencil_In: Is_Depth_Stencil_17, Is_Shared_In: Is_Shared_18, Output_Out: out n8.TextureFlags Output_19, Options_Out: out n8.TextureOptions Options_20);
                n1.CompilationHelper.WritePin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Inputs[9], ref Output_19);
                n1.CompilationHelper.ReadPin(state_5.__p_Vxrso0LBP1RQN1YMOaTYPp.Outputs[0], out n8.TextureDescription out_21);
                n1.CompilationHelper.WritePin(state_5.__p_AdjkAleZX7vMr1GSRtdjzJ.Inputs[0], ref out_21);
                n1.CompilationHelper.WritePin(state_5.__p_FksvlreNf9pNrmuEZjwKr1.Inputs[0], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_FksvlreNf9pNrmuEZjwKr1.Inputs[3], ref Output_19);
                n1.CompilationHelper.ReadPin(state_5.__p_FksvlreNf9pNrmuEZjwKr1.Outputs[0], out n8.TextureViewDescription out_22);
                n1.CompilationHelper.WritePin(state_5.__p_AdjkAleZX7vMr1GSRtdjzJ.Inputs[1], ref out_22);
                n1.CompilationHelper.WritePin(state_5.__p_AdjkAleZX7vMr1GSRtdjzJ.Inputs[2], ref Initial_Data_In);
                n1.CompilationHelper.WritePin(state_5.__p_AdjkAleZX7vMr1GSRtdjzJ.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_AdjkAleZX7vMr1GSRtdjzJ.Outputs[0], out n8.Texture out_23);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_Vxrso0LBP1RQN1YMOaTYPp != state_5.__p_Vxrso0LBP1RQN1YMOaTYPp || state_5.__p_AdjkAleZX7vMr1GSRtdjzJ != state_5.__p_AdjkAleZX7vMr1GSRtdjzJ || state_5.__p_FksvlreNf9pNrmuEZjwKr1 != state_5.__p_FksvlreNf9pNrmuEZjwKr1 ? new __B8rSFk1C2rHNxZChOjDvQB(state_5)
                    {__p_Vxrso0LBP1RQN1YMOaTYPp = state_5.__p_Vxrso0LBP1RQN1YMOaTYPp, __p_AdjkAleZX7vMr1GSRtdjzJ = state_5.__p_AdjkAleZX7vMr1GSRtdjzJ, __p_FksvlreNf9pNrmuEZjwKr1 = state_5.__p_FksvlreNf9pNrmuEZjwKr1} : state_5;
                else
                {
                    state_5.__p_Vxrso0LBP1RQN1YMOaTYPp = state_5.__p_Vxrso0LBP1RQN1YMOaTYPp;
                    state_5.__p_AdjkAleZX7vMr1GSRtdjzJ = state_5.__p_AdjkAleZX7vMr1GSRtdjzJ;
                    state_5.__p_FksvlreNf9pNrmuEZjwKr1 = state_5.__p_FksvlreNf9pNrmuEZjwKr1;
                }

                outputs_3 = n2.ValueTuple.Create(out_23);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_24 = outputs_3.Item1;
            Output_Out = __auto_24;
            Has_Changed_Out = Has_Changed_4;
            n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_1 != this.__cache_NyHcAs0TyBfMvZfZevzL9r ? new ComputeTexture3D_SO197zGpVYsOMINttv8noS(this)
                {__cache_NyHcAs0TyBfMvZfZevzL9r = manager_1} : that_25;
            else
            {
                this.__cache_NyHcAs0TyBfMvZfZevzL9r = manager_1;
            }

            return that_25;
        }

        public n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS that_0 = this;
            this.__cache_NyHcAs0TyBfMvZfZevzL9r = null;
            return that_0;
        }

        public n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS __CreateDefault__()
        {
            n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS that_0 = this;
            this.__cache_NyHcAs0TyBfMvZfZevzL9r = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NyHcAs0TyBfMvZfZevzL9r);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 116650U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NyHcAs0TyBfMvZfZevzL9r", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int3, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>> __cache_NyHcAs0TyBfMvZfZevzL9r = null;
        [n1.ElementAttribute(TracingId = 116849U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NzPs3dOUXKnQYArAZkXJVG", Name = "__slot_NzPs3dOUXKnQYArAZkXJVG")]
        public static n17.TextureDimension __slot_NzPs3dOUXKnQYArAZkXJVG = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture3D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "NzPs3dOUXKnQYArAZkXJVG");
        [n1.ElementAttribute(TracingId = 116702U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IaJnAmYIas0MSkx5wfK8x1", Name = "__slot_IaJnAmYIas0MSkx5wfK8x1")]
        public static n8.GraphicsResourceUsage __slot_IaJnAmYIas0MSkx5wfK8x1 = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Default", false, "Dky5PMnuvcKN4CxmfNs7Uv", "IaJnAmYIas0MSkx5wfK8x1");
        static ComputeTexture3D_SO197zGpVYsOMINttv8noS()
        {
        }

        public ComputeTexture3D_SO197zGpVYsOMINttv8noS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputeTexture3D_SO197zGpVYsOMINttv8noS(ComputeTexture3D_SO197zGpVYsOMINttv8noS other): base(other)
        {
            this.__cache_NyHcAs0TyBfMvZfZevzL9r = other.__cache_NyHcAs0TyBfMvZfZevzL9r;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NyHcAs0TyBfMvZfZevzL9r", in __cache_NyHcAs0TyBfMvZfZevzL9r));
        }

        internal ComputeTexture3D_SO197zGpVYsOMINttv8noS __WITH__(n6.Manager<n2.ValueTuple<n12.Int3, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>> __cache_NyHcAs0TyBfMvZfZevzL9r)
        {
            n27.ComputeTexture3D_SO197zGpVYsOMINttv8noS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NyHcAs0TyBfMvZfZevzL9r != this.__cache_NyHcAs0TyBfMvZfZevzL9r ? new ComputeTexture3D_SO197zGpVYsOMINttv8noS(this)
                {__cache_NyHcAs0TyBfMvZfZevzL9r = __cache_NyHcAs0TyBfMvZfZevzL9r} : that_0;
            else
            {
                this.__cache_NyHcAs0TyBfMvZfZevzL9r = __cache_NyHcAs0TyBfMvZfZevzL9r;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "B8rSFk1C2rHNxZChOjDvQB", Name = "__B8rSFk1C2rHNxZChOjDvQB")]
        [n2.SerializableAttribute]
        public class __B8rSFk1C2rHNxZChOjDvQB : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AdjkAleZX7vMr1GSRtdjzJ);
                n1.CompilationHelper.SafeDispose(this.__p_Vxrso0LBP1RQN1YMOaTYPp);
                n1.CompilationHelper.SafeDispose(this.__p_FksvlreNf9pNrmuEZjwKr1);
                return;
            }

            [n1.ElementAttribute(TracingId = 116709U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AdjkAleZX7vMr1GSRtdjzJ", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_AdjkAleZX7vMr1GSRtdjzJ;
            [n1.ElementAttribute(TracingId = 116730U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Vxrso0LBP1RQN1YMOaTYPp", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Vxrso0LBP1RQN1YMOaTYPp;
            [n1.ElementAttribute(TracingId = 116768U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FksvlreNf9pNrmuEZjwKr1", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_FksvlreNf9pNrmuEZjwKr1;
            public __B8rSFk1C2rHNxZChOjDvQB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __B8rSFk1C2rHNxZChOjDvQB(__B8rSFk1C2rHNxZChOjDvQB other): base(other)
            {
                this.__p_AdjkAleZX7vMr1GSRtdjzJ = other.__p_AdjkAleZX7vMr1GSRtdjzJ;
                this.__p_Vxrso0LBP1RQN1YMOaTYPp = other.__p_Vxrso0LBP1RQN1YMOaTYPp;
                this.__p_FksvlreNf9pNrmuEZjwKr1 = other.__p_FksvlreNf9pNrmuEZjwKr1;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AdjkAleZX7vMr1GSRtdjzJ", in __p_AdjkAleZX7vMr1GSRtdjzJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vxrso0LBP1RQN1YMOaTYPp", in __p_Vxrso0LBP1RQN1YMOaTYPp), n1.CompilationHelper.GetValueOrExisting(values, "__p_FksvlreNf9pNrmuEZjwKr1", in __p_FksvlreNf9pNrmuEZjwKr1));
            }

            internal __B8rSFk1C2rHNxZChOjDvQB __WITH__(n1.IVLNode __p_AdjkAleZX7vMr1GSRtdjzJ, n1.IVLNode __p_Vxrso0LBP1RQN1YMOaTYPp, n1.IVLNode __p_FksvlreNf9pNrmuEZjwKr1)
            {
                __B8rSFk1C2rHNxZChOjDvQB that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AdjkAleZX7vMr1GSRtdjzJ != this.__p_AdjkAleZX7vMr1GSRtdjzJ || __p_Vxrso0LBP1RQN1YMOaTYPp != this.__p_Vxrso0LBP1RQN1YMOaTYPp || __p_FksvlreNf9pNrmuEZjwKr1 != this.__p_FksvlreNf9pNrmuEZjwKr1 ? new __B8rSFk1C2rHNxZChOjDvQB(this)
                    {__p_AdjkAleZX7vMr1GSRtdjzJ = __p_AdjkAleZX7vMr1GSRtdjzJ, __p_Vxrso0LBP1RQN1YMOaTYPp = __p_Vxrso0LBP1RQN1YMOaTYPp, __p_FksvlreNf9pNrmuEZjwKr1 = __p_FksvlreNf9pNrmuEZjwKr1} : that_0;
                else
                {
                    this.__p_AdjkAleZX7vMr1GSRtdjzJ = __p_AdjkAleZX7vMr1GSRtdjzJ;
                    this.__p_Vxrso0LBP1RQN1YMOaTYPp = __p_Vxrso0LBP1RQN1YMOaTYPp;
                    this.__p_FksvlreNf9pNrmuEZjwKr1 = __p_FksvlreNf9pNrmuEZjwKr1;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 117037U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Jr9H2SgSxNyP6XV3v0LHLg", Name = "ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg")]
    [n2.SerializableAttribute]
    public class ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> CreateDefault<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> Update<AdM>(T Initial_Data_In, [n4.SerializedDefaultValueAttribute("16, 16, 16", false)] n12.Int3 Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Recreate_On_Inital_Data_Change_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_UXdd8ru1b34MZ6ErS2qljA.Update(Value_In: Initial_Data_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_4 = Result_1 && Recreate_On_Inital_Data_Change_In;
            var Output_5 = Output_4 || Recreate_In;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_OJhn57N6IPmMIqKac0zG4f;
            if (manager_7 is null)
            {
                manager_7 = new n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_8 = (Size_In, Format_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Output_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__CmysGBzOzmuPlTiMoa9Lm2>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __CmysGBzOzmuPlTiMoa9Lm2(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_12 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx = node_12;
                    var node_13 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_11.__p_GYdJSpCTXOnQJLbOfUiglg = node_13;
                    var node_14 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_11.__p_UKV1YllriQGLo498wQUmd4 = node_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Q3hFJFVHLL5NEH8uyKlrpm", 117196U);
                    var Output_16 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_15);
                    state_11.__p_Q3hFJFVHLL5NEH8uyKlrpm = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "TXheb7CkrmHLoFcP22RPFF", 117217U);
                    var Output_18 = n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider>.Create(Node_Context: Node_Context_17);
                    state_11.__p_TXheb7CkrmHLoFcP22RPFF = Output_18;
                }

                n17.TextureDimension __pad_UOQfhaRMaj6OV7naLgkpgi_19 = __slot_UOQfhaRMaj6OV7naLgkpgi;
                n8.GraphicsResourceUsage __pad_RZ4BM9vmu5cQKkjPxvSNOl_20 = __slot_RZ4BM9vmu5cQKkjPxvSNOl;
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[0], ref __pad_UOQfhaRMaj6OV7naLgkpgi_19);
                n35._Operations_.Split(Input_In: Size_In, X_Out: out int X_21, Y_Out: out int Y_22, Z_Out: out int Z_23);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_21, Output_Out: out int Output_24);
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[1], ref Output_24);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_22, Output_Out: out int Output_25);
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[2], ref Output_25);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Z_23, Output_Out: out int Output_26);
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[3], ref Output_26);
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Inputs[8], ref __pad_RZ4BM9vmu5cQKkjPxvSNOl_20);
                n1.CompilationHelper.ReadPin(state_11.__p_GYdJSpCTXOnQJLbOfUiglg.Outputs[0], out n8.TextureDescription out_27);
                n1.CompilationHelper.WritePin(state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx.Inputs[0], ref out_27);
                n1.CompilationHelper.WritePin(state_11.__p_UKV1YllriQGLo498wQUmd4.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_11.__p_UKV1YllriQGLo498wQUmd4.Outputs[0], out n8.TextureViewDescription out_28);
                n1.CompilationHelper.WritePin(state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx.Inputs[1], ref out_28);
                int Offset_In_Bytes_29 = 0;
                bool Force_30 = false;
                bool SetInput_31 = true;
                var Output_32 = state_11.__p_Q3hFJFVHLL5NEH8uyKlrpm;
                if (SetInput_31)
                {
                    Output_32 = state_11.__p_Q3hFJFVHLL5NEH8uyKlrpm.SetInput<AdM>(Input_In: Initial_Data_In, Offset_In_Bytes_In: Offset_In_Bytes_29, Force_In: Force_30);
                }

                var State_Output_34 = Output_32.Update(Output_Out: out n14.IGraphicsDataProvider Output_33);
                bool Force_35 = false;
                var State_Output_37 = state_11.__p_TXheb7CkrmHLoFcP22RPFF.Update(Input_In: Output_33, Force_In: Force_35, Output_Out: out n14.IGraphicsDataProvider[] Output_36);
                n1.CompilationHelper.WritePin(state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx.Inputs[2], ref Output_36);
                var Output_38 = Output_4 || Recreate_In;
                n1.CompilationHelper.WritePin(state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx.Inputs[3], ref Output_38);
                n1.CompilationHelper.ReadPin(state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx.Outputs[0], out n8.Texture out_39);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = state_11.__p_GYdJSpCTXOnQJLbOfUiglg != state_11.__p_GYdJSpCTXOnQJLbOfUiglg || state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx != state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx || state_11.__p_UKV1YllriQGLo498wQUmd4 != state_11.__p_UKV1YllriQGLo498wQUmd4 || State_Output_34 != state_11.__p_Q3hFJFVHLL5NEH8uyKlrpm || State_Output_37 != state_11.__p_TXheb7CkrmHLoFcP22RPFF ? new __CmysGBzOzmuPlTiMoa9Lm2(state_11)
                    {__p_GYdJSpCTXOnQJLbOfUiglg = state_11.__p_GYdJSpCTXOnQJLbOfUiglg, __p_VRF8Ll5eLzHOo5aWBdHyGx = state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx, __p_UKV1YllriQGLo498wQUmd4 = state_11.__p_UKV1YllriQGLo498wQUmd4, __p_Q3hFJFVHLL5NEH8uyKlrpm = State_Output_34, __p_TXheb7CkrmHLoFcP22RPFF = State_Output_37} : state_11;
                else
                {
                    state_11.__p_GYdJSpCTXOnQJLbOfUiglg = state_11.__p_GYdJSpCTXOnQJLbOfUiglg;
                    state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx = state_11.__p_VRF8Ll5eLzHOo5aWBdHyGx;
                    state_11.__p_UKV1YllriQGLo498wQUmd4 = state_11.__p_UKV1YllriQGLo498wQUmd4;
                    state_11.__p_Q3hFJFVHLL5NEH8uyKlrpm = State_Output_34;
                    state_11.__p_TXheb7CkrmHLoFcP22RPFF = State_Output_37;
                }

                outputs_9 = n2.ValueTuple.Create(out_39);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_40 = outputs_9.Item1;
            Output_Out = __auto_40;
            Has_Changed_Out = Has_Changed_10;
            n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> that_41 = this;
            if (this.__GetContext__().IsImmutable)
                that_41 = Output_3 != this.__p_UXdd8ru1b34MZ6ErS2qljA || manager_7 != this.__cache_OJhn57N6IPmMIqKac0zG4f ? new ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T>(this)
                {__p_UXdd8ru1b34MZ6ErS2qljA = Output_3, __cache_OJhn57N6IPmMIqKac0zG4f = manager_7} : that_41;
            else
            {
                this.__p_UXdd8ru1b34MZ6ErS2qljA = Output_3;
                this.__cache_OJhn57N6IPmMIqKac0zG4f = manager_7;
            }

            return that_41;
        }

        public n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "UXdd8ru1b34MZ6ErS2qljA", 117336U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> that_4 = this;
            this.__p_UXdd8ru1b34MZ6ErS2qljA = Output_3;
            this.__cache_OJhn57N6IPmMIqKac0zG4f = null;
            return that_4;
        }

        public n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> __CreateDefault__<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> that_1 = this;
            this.__p_UXdd8ru1b34MZ6ErS2qljA = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.CreateDefault<AdM>();
            this.__cache_OJhn57N6IPmMIqKac0zG4f = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UXdd8ru1b34MZ6ErS2qljA);
            n1.CompilationHelper.SafeDispose(this.__cache_OJhn57N6IPmMIqKac0zG4f);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117336U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UXdd8ru1b34MZ6ErS2qljA", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_UXdd8ru1b34MZ6ErS2qljA;
        [n1.ElementAttribute(TracingId = 117046U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OJhn57N6IPmMIqKac0zG4f", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_OJhn57N6IPmMIqKac0zG4f = null;
        [n1.ElementAttribute(TracingId = 117259U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UOQfhaRMaj6OV7naLgkpgi", Name = "__slot_UOQfhaRMaj6OV7naLgkpgi")]
        public static n17.TextureDimension __slot_UOQfhaRMaj6OV7naLgkpgi = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture3D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "UOQfhaRMaj6OV7naLgkpgi");
        [n1.ElementAttribute(TracingId = 117078U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RZ4BM9vmu5cQKkjPxvSNOl", Name = "__slot_RZ4BM9vmu5cQKkjPxvSNOl")]
        public static n8.GraphicsResourceUsage __slot_RZ4BM9vmu5cQKkjPxvSNOl = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "RZ4BM9vmu5cQKkjPxvSNOl");
        static ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg()
        {
        }

        public ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg(ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> other): base(other)
        {
            this.__p_UXdd8ru1b34MZ6ErS2qljA = other.__p_UXdd8ru1b34MZ6ErS2qljA;
            this.__cache_OJhn57N6IPmMIqKac0zG4f = other.__cache_OJhn57N6IPmMIqKac0zG4f;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UXdd8ru1b34MZ6ErS2qljA", in __p_UXdd8ru1b34MZ6ErS2qljA), n1.CompilationHelper.GetValueOrExisting(values, "__cache_OJhn57N6IPmMIqKac0zG4f", in __cache_OJhn57N6IPmMIqKac0zG4f));
        }

        internal ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> __WITH__(n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_UXdd8ru1b34MZ6ErS2qljA, n6.Manager<n2.ValueTuple<n12.Int3, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_OJhn57N6IPmMIqKac0zG4f)
        {
            n27.ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UXdd8ru1b34MZ6ErS2qljA != this.__p_UXdd8ru1b34MZ6ErS2qljA || __cache_OJhn57N6IPmMIqKac0zG4f != this.__cache_OJhn57N6IPmMIqKac0zG4f ? new ImmutableTexture3D_Jr9H2SgSxNyP6XV3v0LHLg<T>(this)
                {__p_UXdd8ru1b34MZ6ErS2qljA = __p_UXdd8ru1b34MZ6ErS2qljA, __cache_OJhn57N6IPmMIqKac0zG4f = __cache_OJhn57N6IPmMIqKac0zG4f} : that_0;
            else
            {
                this.__p_UXdd8ru1b34MZ6ErS2qljA = __p_UXdd8ru1b34MZ6ErS2qljA;
                this.__cache_OJhn57N6IPmMIqKac0zG4f = __cache_OJhn57N6IPmMIqKac0zG4f;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CmysGBzOzmuPlTiMoa9Lm2", Name = "__CmysGBzOzmuPlTiMoa9Lm2")]
        [n2.SerializableAttribute]
        public class __CmysGBzOzmuPlTiMoa9Lm2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VRF8Ll5eLzHOo5aWBdHyGx);
                n1.CompilationHelper.SafeDispose(this.__p_GYdJSpCTXOnQJLbOfUiglg);
                n1.CompilationHelper.SafeDispose(this.__p_UKV1YllriQGLo498wQUmd4);
                n1.CompilationHelper.SafeDispose(this.__p_Q3hFJFVHLL5NEH8uyKlrpm);
                n1.CompilationHelper.SafeDispose(this.__p_TXheb7CkrmHLoFcP22RPFF);
                return;
            }

            [n1.ElementAttribute(TracingId = 117083U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VRF8Ll5eLzHOo5aWBdHyGx", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_VRF8Ll5eLzHOo5aWBdHyGx;
            [n1.ElementAttribute(TracingId = 117105U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GYdJSpCTXOnQJLbOfUiglg", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_GYdJSpCTXOnQJLbOfUiglg;
            [n1.ElementAttribute(TracingId = 117148U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "UKV1YllriQGLo498wQUmd4", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_UKV1YllriQGLo498wQUmd4;
            [n1.ElementAttribute(TracingId = 117196U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Q3hFJFVHLL5NEH8uyKlrpm", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_Q3hFJFVHLL5NEH8uyKlrpm;
            [n1.ElementAttribute(TracingId = 117217U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TXheb7CkrmHLoFcP22RPFF", Name = "FromValue", IsManaged = true, IsAutoGenerated = true)]
            public n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_TXheb7CkrmHLoFcP22RPFF;
            public __CmysGBzOzmuPlTiMoa9Lm2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CmysGBzOzmuPlTiMoa9Lm2(__CmysGBzOzmuPlTiMoa9Lm2 other): base(other)
            {
                this.__p_VRF8Ll5eLzHOo5aWBdHyGx = other.__p_VRF8Ll5eLzHOo5aWBdHyGx;
                this.__p_GYdJSpCTXOnQJLbOfUiglg = other.__p_GYdJSpCTXOnQJLbOfUiglg;
                this.__p_UKV1YllriQGLo498wQUmd4 = other.__p_UKV1YllriQGLo498wQUmd4;
                this.__p_Q3hFJFVHLL5NEH8uyKlrpm = other.__p_Q3hFJFVHLL5NEH8uyKlrpm;
                this.__p_TXheb7CkrmHLoFcP22RPFF = other.__p_TXheb7CkrmHLoFcP22RPFF;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VRF8Ll5eLzHOo5aWBdHyGx", in __p_VRF8Ll5eLzHOo5aWBdHyGx), n1.CompilationHelper.GetValueOrExisting(values, "__p_GYdJSpCTXOnQJLbOfUiglg", in __p_GYdJSpCTXOnQJLbOfUiglg), n1.CompilationHelper.GetValueOrExisting(values, "__p_UKV1YllriQGLo498wQUmd4", in __p_UKV1YllriQGLo498wQUmd4), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q3hFJFVHLL5NEH8uyKlrpm", in __p_Q3hFJFVHLL5NEH8uyKlrpm), n1.CompilationHelper.GetValueOrExisting(values, "__p_TXheb7CkrmHLoFcP22RPFF", in __p_TXheb7CkrmHLoFcP22RPFF));
            }

            internal __CmysGBzOzmuPlTiMoa9Lm2 __WITH__(n1.IVLNode __p_VRF8Ll5eLzHOo5aWBdHyGx, n1.IVLNode __p_GYdJSpCTXOnQJLbOfUiglg, n1.IVLNode __p_UKV1YllriQGLo498wQUmd4, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_Q3hFJFVHLL5NEH8uyKlrpm, n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_TXheb7CkrmHLoFcP22RPFF)
            {
                __CmysGBzOzmuPlTiMoa9Lm2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VRF8Ll5eLzHOo5aWBdHyGx != this.__p_VRF8Ll5eLzHOo5aWBdHyGx || __p_GYdJSpCTXOnQJLbOfUiglg != this.__p_GYdJSpCTXOnQJLbOfUiglg || __p_UKV1YllriQGLo498wQUmd4 != this.__p_UKV1YllriQGLo498wQUmd4 || __p_Q3hFJFVHLL5NEH8uyKlrpm != this.__p_Q3hFJFVHLL5NEH8uyKlrpm || __p_TXheb7CkrmHLoFcP22RPFF != this.__p_TXheb7CkrmHLoFcP22RPFF ? new __CmysGBzOzmuPlTiMoa9Lm2(this)
                    {__p_VRF8Ll5eLzHOo5aWBdHyGx = __p_VRF8Ll5eLzHOo5aWBdHyGx, __p_GYdJSpCTXOnQJLbOfUiglg = __p_GYdJSpCTXOnQJLbOfUiglg, __p_UKV1YllriQGLo498wQUmd4 = __p_UKV1YllriQGLo498wQUmd4, __p_Q3hFJFVHLL5NEH8uyKlrpm = __p_Q3hFJFVHLL5NEH8uyKlrpm, __p_TXheb7CkrmHLoFcP22RPFF = __p_TXheb7CkrmHLoFcP22RPFF} : that_0;
                else
                {
                    this.__p_VRF8Ll5eLzHOo5aWBdHyGx = __p_VRF8Ll5eLzHOo5aWBdHyGx;
                    this.__p_GYdJSpCTXOnQJLbOfUiglg = __p_GYdJSpCTXOnQJLbOfUiglg;
                    this.__p_UKV1YllriQGLo498wQUmd4 = __p_UKV1YllriQGLo498wQUmd4;
                    this.__p_Q3hFJFVHLL5NEH8uyKlrpm = __p_Q3hFJFVHLL5NEH8uyKlrpm;
                    this.__p_TXheb7CkrmHLoFcP22RPFF = __p_TXheb7CkrmHLoFcP22RPFF;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 117468U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Eqmb6Wko2RXLl2BN6IfmON", Name = "DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON")]
    [n2.SerializableAttribute]
    public class DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> CreateDefault()
        {
            var instance = new DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> Update<AdM>(T Input_In, [n4.SerializedDefaultValueAttribute("512", false)] int Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, bool Recreate_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            int Offset_In_Bytes_1 = 0;
            bool Force_2 = false;
            bool SetInput_3 = true;
            var Output_4 = this.__p_TRDtXEFQL37LZUtjTtKtZO;
            if (SetInput_3)
            {
                Output_4 = this.__p_TRDtXEFQL37LZUtjTtKtZO.SetInput<AdM>(Input_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_1, Force_In: Force_2);
            }

            var State_Output_6 = Output_4.Update(Output_Out: out n14.IGraphicsDataProvider Output_5);
            n15._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_7);
            n5.ObjectHelpers.IsAssigned(x: Result_7, result: out bool Result_8, notAssigned: out bool Not_Assigned_9);
            var Output_10 = Result_8 && Apply_In;
            bool Dispose_Cached_Outputs_11 = false;
            var manager_12 = this.__cache_SdMV3GLX5k2QK237p5LP9M;
            if (manager_12 is null)
            {
                manager_12 = new n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_13 = (Size_In, Format_In);
            var outputs_14 = manager_12.Outputs;
            var Has_Changed_15 = Recreate_In || manager_12.InputsChanged(inputs_13);
            if (Has_Changed_15)
            {
                if (Dispose_Cached_Outputs_11)
                    manager_12.DisposeOutputs();
                var state_16 = n1.CompilationHelper.Restore<__BV8AChOe1ZSOX4CejSHJyb>(manager_12.State, __GetContext__());
                if (state_16 == null)
                {
                    state_16 = new __BV8AChOe1ZSOX4CejSHJyb(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_17 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_16.__p_SBaaewfxzz4LWB1XC6qp2G = node_17;
                    var node_18 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_16.__p_Lzd41AVhsAQMzvGoTi3k28 = node_18;
                    var node_19 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_16.__p_JODT535T3z9PEVe2rC9QHT = node_19;
                }

                n17.TextureDimension __pad_BwPepU4N8WoNIJAO7FneWS_20 = __slot_BwPepU4N8WoNIJAO7FneWS;
                n8.GraphicsResourceUsage __pad_T7geCASQJ5wMt8ArO7Ddey_21 = __slot_T7geCASQJ5wMt8ArO7Ddey;
                n1.CompilationHelper.WritePin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Inputs[0], ref __pad_BwPepU4N8WoNIJAO7FneWS_20);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Size_In, Output_Out: out int Output_22);
                n1.CompilationHelper.WritePin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Inputs[1], ref Output_22);
                int Height_23 = 1;
                n1.CompilationHelper.WritePin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Inputs[2], ref Height_23);
                n1.CompilationHelper.WritePin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Inputs[8], ref __pad_T7geCASQJ5wMt8ArO7Ddey_21);
                n1.CompilationHelper.ReadPin(state_16.__p_Lzd41AVhsAQMzvGoTi3k28.Outputs[0], out n8.TextureDescription out_24);
                n1.CompilationHelper.WritePin(state_16.__p_SBaaewfxzz4LWB1XC6qp2G.Inputs[0], ref out_24);
                n1.CompilationHelper.WritePin(state_16.__p_JODT535T3z9PEVe2rC9QHT.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_16.__p_JODT535T3z9PEVe2rC9QHT.Outputs[0], out n8.TextureViewDescription out_25);
                n1.CompilationHelper.WritePin(state_16.__p_SBaaewfxzz4LWB1XC6qp2G.Inputs[1], ref out_25);
                n1.CompilationHelper.WritePin(state_16.__p_SBaaewfxzz4LWB1XC6qp2G.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_16.__p_SBaaewfxzz4LWB1XC6qp2G.Outputs[0], out n8.Texture out_26);
                if (state_16.__GetContext__().IsImmutable)
                    state_16 = state_16.__p_Lzd41AVhsAQMzvGoTi3k28 != state_16.__p_Lzd41AVhsAQMzvGoTi3k28 || state_16.__p_SBaaewfxzz4LWB1XC6qp2G != state_16.__p_SBaaewfxzz4LWB1XC6qp2G || state_16.__p_JODT535T3z9PEVe2rC9QHT != state_16.__p_JODT535T3z9PEVe2rC9QHT ? new __BV8AChOe1ZSOX4CejSHJyb(state_16)
                    {__p_Lzd41AVhsAQMzvGoTi3k28 = state_16.__p_Lzd41AVhsAQMzvGoTi3k28, __p_SBaaewfxzz4LWB1XC6qp2G = state_16.__p_SBaaewfxzz4LWB1XC6qp2G, __p_JODT535T3z9PEVe2rC9QHT = state_16.__p_JODT535T3z9PEVe2rC9QHT} : state_16;
                else
                {
                    state_16.__p_Lzd41AVhsAQMzvGoTi3k28 = state_16.__p_Lzd41AVhsAQMzvGoTi3k28;
                    state_16.__p_SBaaewfxzz4LWB1XC6qp2G = state_16.__p_SBaaewfxzz4LWB1XC6qp2G;
                    state_16.__p_JODT535T3z9PEVe2rC9QHT = state_16.__p_JODT535T3z9PEVe2rC9QHT;
                }

                outputs_14 = n2.ValueTuple.Create(out_26);
                manager_12 = manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11, state_16, outputs_14);
            }
            else
            {
                manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11);
            }

            var __auto_27 = outputs_14.Item1;
            bool Re_Initialize_28 = false;
            var __fallback___29 = n1.ServiceRegistry.Current;
            n33._Operations_.Update_H<n2.Object, n8.Texture>(Input_In: this.__p_LssdMSA2ytGNCbj7uE61PX, Default_Output_In: __auto_27, Re_Initialize_In: Re_Initialize_28, Try_In: (n2.Object s_32) =>
            {
                using var __current_30 = __fallback___29.MakeCurrentIfNone();
                var state_31 = n1.CompilationHelper.Restore<__Abp6vqw5TBBP1daTRELMdR>(s_32, __GetContext__());
                int Array_Slice_33 = 0;
                int Mip_Slice_34 = 0;
                n2.Nullable<n8.ResourceRegion> Region_35 = default(n2.Nullable<n8.ResourceRegion>);
                var State_Output_37 = state_31.__p_MLzxgpGDBS7PCy8An1kD8I.Update(Input_In: __auto_27, Data_In: Output_5, Array_Slice_In: Array_Slice_33, Mip_Slice_In: Mip_Slice_34, Region_In: Region_35, Apply_In: Output_10, Output_Out: out n8.Texture Output_36);
                if (state_31.__GetContext__().IsImmutable)
                    state_31 = State_Output_37 != state_31.__p_MLzxgpGDBS7PCy8An1kD8I ? new __Abp6vqw5TBBP1daTRELMdR(state_31)
                    {__p_MLzxgpGDBS7PCy8An1kD8I = State_Output_37} : state_31;
                else
                {
                    state_31.__p_MLzxgpGDBS7PCy8An1kD8I = State_Output_37;
                }

                return n2.Tuple.Create<n2.Object, n8.Texture>(state_31, Output_36);
            }

            , Create_In: () =>
            {
                using var __current_38 = __fallback___29.MakeCurrentIfNone();
                var state_31 = new __Abp6vqw5TBBP1daTRELMdR(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "MLzxgpGDBS7PCy8An1kD8I", 117684U);
                var Output_40 = n31.SetData_FPEbMrBTNrWLDZKYInJXKW.Create(Node_Context: Node_Context_39);
                state_31.__p_MLzxgpGDBS7PCy8An1kD8I = Output_40;
                return state_31;
            }

            , Output_Out: out n32.TryStateful<n2.Object> Output_41, Result_Out: out n8.Texture Result_42, Success_Out: out bool Success_43, Error_Message_Out: out string Error_Message_44);
            Output_Out = Result_42;
            Has_Changed_Out = Has_Changed_15;
            n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> that_45 = this;
            if (this.__GetContext__().IsImmutable)
                that_45 = State_Output_6 != this.__p_TRDtXEFQL37LZUtjTtKtZO || manager_12 != this.__cache_SdMV3GLX5k2QK237p5LP9M || Output_41 != this.__p_LssdMSA2ytGNCbj7uE61PX ? new DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T>(this)
                {__p_TRDtXEFQL37LZUtjTtKtZO = State_Output_6, __cache_SdMV3GLX5k2QK237p5LP9M = manager_12, __p_LssdMSA2ytGNCbj7uE61PX = Output_41} : that_45;
            else
            {
                this.__p_TRDtXEFQL37LZUtjTtKtZO = State_Output_6;
                this.__cache_SdMV3GLX5k2QK237p5LP9M = manager_12;
                this.__p_LssdMSA2ytGNCbj7uE61PX = Output_41;
            }

            return that_45;
        }

        public n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "TRDtXEFQL37LZUtjTtKtZO", 117644U);
            var Output_1 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "LssdMSA2ytGNCbj7uE61PX", 117664U);
            n33._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_2, Output_Out: out n32.TryStateful<n2.Object> Output_3);
            n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> that_4 = this;
            this.__p_TRDtXEFQL37LZUtjTtKtZO = Output_1;
            this.__p_LssdMSA2ytGNCbj7uE61PX = Output_3;
            this.__cache_SdMV3GLX5k2QK237p5LP9M = null;
            return that_4;
        }

        public n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> __CreateDefault__()
        {
            n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> that_0 = this;
            this.__p_TRDtXEFQL37LZUtjTtKtZO = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.CreateDefault();
            this.__cache_SdMV3GLX5k2QK237p5LP9M = null;
            this.__p_LssdMSA2ytGNCbj7uE61PX = default(n32.TryStateful<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TRDtXEFQL37LZUtjTtKtZO);
            n1.CompilationHelper.SafeDispose(this.__cache_SdMV3GLX5k2QK237p5LP9M);
            n1.CompilationHelper.SafeDispose(this.__p_LssdMSA2ytGNCbj7uE61PX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117644U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TRDtXEFQL37LZUtjTtKtZO", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_TRDtXEFQL37LZUtjTtKtZO;
        [n1.ElementAttribute(TracingId = 117475U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SdMV3GLX5k2QK237p5LP9M", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_SdMV3GLX5k2QK237p5LP9M = null;
        [n1.ElementAttribute(TracingId = 117587U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BwPepU4N8WoNIJAO7FneWS", Name = "__slot_BwPepU4N8WoNIJAO7FneWS")]
        public static n17.TextureDimension __slot_BwPepU4N8WoNIJAO7FneWS = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture1D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "BwPepU4N8WoNIJAO7FneWS");
        [n1.ElementAttribute(TracingId = 117499U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "T7geCASQJ5wMt8ArO7Ddey", Name = "__slot_T7geCASQJ5wMt8ArO7Ddey")]
        public static n8.GraphicsResourceUsage __slot_T7geCASQJ5wMt8ArO7Ddey = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Dynamic", false, "Dky5PMnuvcKN4CxmfNs7Uv", "T7geCASQJ5wMt8ArO7Ddey");
        [n1.ElementAttribute(TracingId = 117664U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LssdMSA2ytGNCbj7uE61PX", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
        public n32.TryStateful<n2.Object> __p_LssdMSA2ytGNCbj7uE61PX;
        static DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON()
        {
        }

        public DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON(DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> other): base(other)
        {
            this.__p_TRDtXEFQL37LZUtjTtKtZO = other.__p_TRDtXEFQL37LZUtjTtKtZO;
            this.__cache_SdMV3GLX5k2QK237p5LP9M = other.__cache_SdMV3GLX5k2QK237p5LP9M;
            this.__p_LssdMSA2ytGNCbj7uE61PX = other.__p_LssdMSA2ytGNCbj7uE61PX;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TRDtXEFQL37LZUtjTtKtZO", in __p_TRDtXEFQL37LZUtjTtKtZO), n1.CompilationHelper.GetValueOrExisting(values, "__cache_SdMV3GLX5k2QK237p5LP9M", in __cache_SdMV3GLX5k2QK237p5LP9M), n1.CompilationHelper.GetValueOrExisting(values, "__p_LssdMSA2ytGNCbj7uE61PX", in __p_LssdMSA2ytGNCbj7uE61PX));
        }

        internal DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> __WITH__(n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_TRDtXEFQL37LZUtjTtKtZO, n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_SdMV3GLX5k2QK237p5LP9M, n32.TryStateful<n2.Object> __p_LssdMSA2ytGNCbj7uE61PX)
        {
            n27.DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_TRDtXEFQL37LZUtjTtKtZO != this.__p_TRDtXEFQL37LZUtjTtKtZO || __cache_SdMV3GLX5k2QK237p5LP9M != this.__cache_SdMV3GLX5k2QK237p5LP9M || __p_LssdMSA2ytGNCbj7uE61PX != this.__p_LssdMSA2ytGNCbj7uE61PX ? new DynamicTexture1D_Eqmb6Wko2RXLl2BN6IfmON<T>(this)
                {__p_TRDtXEFQL37LZUtjTtKtZO = __p_TRDtXEFQL37LZUtjTtKtZO, __cache_SdMV3GLX5k2QK237p5LP9M = __cache_SdMV3GLX5k2QK237p5LP9M, __p_LssdMSA2ytGNCbj7uE61PX = __p_LssdMSA2ytGNCbj7uE61PX} : that_0;
            else
            {
                this.__p_TRDtXEFQL37LZUtjTtKtZO = __p_TRDtXEFQL37LZUtjTtKtZO;
                this.__cache_SdMV3GLX5k2QK237p5LP9M = __cache_SdMV3GLX5k2QK237p5LP9M;
                this.__p_LssdMSA2ytGNCbj7uE61PX = __p_LssdMSA2ytGNCbj7uE61PX;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BV8AChOe1ZSOX4CejSHJyb", Name = "__BV8AChOe1ZSOX4CejSHJyb")]
        [n2.SerializableAttribute]
        public class __BV8AChOe1ZSOX4CejSHJyb : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SBaaewfxzz4LWB1XC6qp2G);
                n1.CompilationHelper.SafeDispose(this.__p_Lzd41AVhsAQMzvGoTi3k28);
                n1.CompilationHelper.SafeDispose(this.__p_JODT535T3z9PEVe2rC9QHT);
                return;
            }

            [n1.ElementAttribute(TracingId = 117502U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SBaaewfxzz4LWB1XC6qp2G", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_SBaaewfxzz4LWB1XC6qp2G;
            [n1.ElementAttribute(TracingId = 117520U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Lzd41AVhsAQMzvGoTi3k28", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Lzd41AVhsAQMzvGoTi3k28;
            [n1.ElementAttribute(TracingId = 117552U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JODT535T3z9PEVe2rC9QHT", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_JODT535T3z9PEVe2rC9QHT;
            public __BV8AChOe1ZSOX4CejSHJyb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BV8AChOe1ZSOX4CejSHJyb(__BV8AChOe1ZSOX4CejSHJyb other): base(other)
            {
                this.__p_SBaaewfxzz4LWB1XC6qp2G = other.__p_SBaaewfxzz4LWB1XC6qp2G;
                this.__p_Lzd41AVhsAQMzvGoTi3k28 = other.__p_Lzd41AVhsAQMzvGoTi3k28;
                this.__p_JODT535T3z9PEVe2rC9QHT = other.__p_JODT535T3z9PEVe2rC9QHT;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SBaaewfxzz4LWB1XC6qp2G", in __p_SBaaewfxzz4LWB1XC6qp2G), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lzd41AVhsAQMzvGoTi3k28", in __p_Lzd41AVhsAQMzvGoTi3k28), n1.CompilationHelper.GetValueOrExisting(values, "__p_JODT535T3z9PEVe2rC9QHT", in __p_JODT535T3z9PEVe2rC9QHT));
            }

            internal __BV8AChOe1ZSOX4CejSHJyb __WITH__(n1.IVLNode __p_SBaaewfxzz4LWB1XC6qp2G, n1.IVLNode __p_Lzd41AVhsAQMzvGoTi3k28, n1.IVLNode __p_JODT535T3z9PEVe2rC9QHT)
            {
                __BV8AChOe1ZSOX4CejSHJyb that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SBaaewfxzz4LWB1XC6qp2G != this.__p_SBaaewfxzz4LWB1XC6qp2G || __p_Lzd41AVhsAQMzvGoTi3k28 != this.__p_Lzd41AVhsAQMzvGoTi3k28 || __p_JODT535T3z9PEVe2rC9QHT != this.__p_JODT535T3z9PEVe2rC9QHT ? new __BV8AChOe1ZSOX4CejSHJyb(this)
                    {__p_SBaaewfxzz4LWB1XC6qp2G = __p_SBaaewfxzz4LWB1XC6qp2G, __p_Lzd41AVhsAQMzvGoTi3k28 = __p_Lzd41AVhsAQMzvGoTi3k28, __p_JODT535T3z9PEVe2rC9QHT = __p_JODT535T3z9PEVe2rC9QHT} : that_0;
                else
                {
                    this.__p_SBaaewfxzz4LWB1XC6qp2G = __p_SBaaewfxzz4LWB1XC6qp2G;
                    this.__p_Lzd41AVhsAQMzvGoTi3k28 = __p_Lzd41AVhsAQMzvGoTi3k28;
                    this.__p_JODT535T3z9PEVe2rC9QHT = __p_JODT535T3z9PEVe2rC9QHT;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Abp6vqw5TBBP1daTRELMdR", Name = "__Abp6vqw5TBBP1daTRELMdR")]
        [n2.SerializableAttribute]
        public class __Abp6vqw5TBBP1daTRELMdR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MLzxgpGDBS7PCy8An1kD8I);
                return;
            }

            [n1.ElementAttribute(TracingId = 117684U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "MLzxgpGDBS7PCy8An1kD8I", Name = "SetData", IsManaged = true, IsAutoGenerated = true)]
            public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_MLzxgpGDBS7PCy8An1kD8I;
            public __Abp6vqw5TBBP1daTRELMdR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Abp6vqw5TBBP1daTRELMdR(__Abp6vqw5TBBP1daTRELMdR other): base(other)
            {
                this.__p_MLzxgpGDBS7PCy8An1kD8I = other.__p_MLzxgpGDBS7PCy8An1kD8I;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MLzxgpGDBS7PCy8An1kD8I", in __p_MLzxgpGDBS7PCy8An1kD8I));
            }

            internal __Abp6vqw5TBBP1daTRELMdR __WITH__(n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_MLzxgpGDBS7PCy8An1kD8I)
            {
                __Abp6vqw5TBBP1daTRELMdR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MLzxgpGDBS7PCy8An1kD8I != this.__p_MLzxgpGDBS7PCy8An1kD8I ? new __Abp6vqw5TBBP1daTRELMdR(this)
                    {__p_MLzxgpGDBS7PCy8An1kD8I = __p_MLzxgpGDBS7PCy8An1kD8I} : that_0;
                else
                {
                    this.__p_MLzxgpGDBS7PCy8An1kD8I = __p_MLzxgpGDBS7PCy8An1kD8I;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 117798U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Ble2PwEcLIJPosndgAb3Pm", Name = "ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm")]
    [n2.SerializableAttribute]
    public class ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm CreateDefault()
        {
            var instance = new ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm Update([n4.SerializedDefaultValueAttribute("512", false)] int Size_In, n14.IGraphicsDataProvider[] Initial_Data_In, [n4.SerializedDefaultValueAttribute("1", false)] int Array_Size_In, [n4.SerializedDefaultValueAttribute("1", false)] int Mip_Levels_In, [n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Unordered_Access_In, bool Is_Render_Target_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_RwjdEnWIB70L25AOxJ3FFE;
            if (manager_1 is null)
            {
                manager_1 = new n6.Manager<n2.ValueTuple<int, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_2 = (Size_In, Array_Size_In, Mip_Levels_In, Format_In, Is_Unordered_Access_In, Is_Render_Target_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Recreate_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__MKwsaKc8uSXPnvEimhL84W>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __MKwsaKc8uSXPnvEimhL84W(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_6 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_5.__p_U9GV7oqg7vYQGWlQUZH8CB = node_6;
                    var node_7 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_5.__p_E8JgOlRplQoPHBFmmy9UoD = node_7;
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_5.__p_G7bHbuJF9aaPGtSBXolMgG = node_8;
                }

                n17.TextureDimension __pad_P0HG7B2N2ssMOouTuldGEk_9 = __slot_P0HG7B2N2ssMOouTuldGEk;
                n8.GraphicsResourceUsage __pad_URH1mahks1UOclSajwm5mi_10 = __slot_URH1mahks1UOclSajwm5mi;
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[0], ref __pad_P0HG7B2N2ssMOouTuldGEk_9);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Size_In, Output_Out: out int Output_11);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[1], ref Output_11);
                int Height_12 = 1;
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[2], ref Height_12);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[4], ref Array_Size_In);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[5], ref Mip_Levels_In);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[8], ref __pad_URH1mahks1UOclSajwm5mi_10);
                bool Is_Depth_Stencil_13 = false;
                bool Is_Shared_14 = false;
                n34._Operations_.TextureFlags(Is_Unordered_Access_In: Is_Unordered_Access_In, Is_Render_Target_In: Is_Render_Target_In, Is_Depth_Stencil_In: Is_Depth_Stencil_13, Is_Shared_In: Is_Shared_14, Output_Out: out n8.TextureFlags Output_15, Options_Out: out n8.TextureOptions Options_16);
                n1.CompilationHelper.WritePin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Inputs[9], ref Output_15);
                n1.CompilationHelper.ReadPin(state_5.__p_E8JgOlRplQoPHBFmmy9UoD.Outputs[0], out n8.TextureDescription out_17);
                n1.CompilationHelper.WritePin(state_5.__p_U9GV7oqg7vYQGWlQUZH8CB.Inputs[0], ref out_17);
                n1.CompilationHelper.WritePin(state_5.__p_G7bHbuJF9aaPGtSBXolMgG.Inputs[0], ref Format_In);
                n1.CompilationHelper.WritePin(state_5.__p_G7bHbuJF9aaPGtSBXolMgG.Inputs[3], ref Output_15);
                n1.CompilationHelper.ReadPin(state_5.__p_G7bHbuJF9aaPGtSBXolMgG.Outputs[0], out n8.TextureViewDescription out_18);
                n1.CompilationHelper.WritePin(state_5.__p_U9GV7oqg7vYQGWlQUZH8CB.Inputs[1], ref out_18);
                n1.CompilationHelper.WritePin(state_5.__p_U9GV7oqg7vYQGWlQUZH8CB.Inputs[2], ref Initial_Data_In);
                n1.CompilationHelper.WritePin(state_5.__p_U9GV7oqg7vYQGWlQUZH8CB.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_5.__p_U9GV7oqg7vYQGWlQUZH8CB.Outputs[0], out n8.Texture out_19);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_5.__p_E8JgOlRplQoPHBFmmy9UoD != state_5.__p_E8JgOlRplQoPHBFmmy9UoD || state_5.__p_U9GV7oqg7vYQGWlQUZH8CB != state_5.__p_U9GV7oqg7vYQGWlQUZH8CB || state_5.__p_G7bHbuJF9aaPGtSBXolMgG != state_5.__p_G7bHbuJF9aaPGtSBXolMgG ? new __MKwsaKc8uSXPnvEimhL84W(state_5)
                    {__p_E8JgOlRplQoPHBFmmy9UoD = state_5.__p_E8JgOlRplQoPHBFmmy9UoD, __p_U9GV7oqg7vYQGWlQUZH8CB = state_5.__p_U9GV7oqg7vYQGWlQUZH8CB, __p_G7bHbuJF9aaPGtSBXolMgG = state_5.__p_G7bHbuJF9aaPGtSBXolMgG} : state_5;
                else
                {
                    state_5.__p_E8JgOlRplQoPHBFmmy9UoD = state_5.__p_E8JgOlRplQoPHBFmmy9UoD;
                    state_5.__p_U9GV7oqg7vYQGWlQUZH8CB = state_5.__p_U9GV7oqg7vYQGWlQUZH8CB;
                    state_5.__p_G7bHbuJF9aaPGtSBXolMgG = state_5.__p_G7bHbuJF9aaPGtSBXolMgG;
                }

                outputs_3 = n2.ValueTuple.Create(out_19);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_20 = outputs_3.Item1;
            Output_Out = __auto_20;
            Has_Changed_Out = Has_Changed_4;
            n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = manager_1 != this.__cache_RwjdEnWIB70L25AOxJ3FFE ? new ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(this)
                {__cache_RwjdEnWIB70L25AOxJ3FFE = manager_1} : that_21;
            else
            {
                this.__cache_RwjdEnWIB70L25AOxJ3FFE = manager_1;
            }

            return that_21;
        }

        public n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm that_0 = this;
            this.__cache_RwjdEnWIB70L25AOxJ3FFE = null;
            return that_0;
        }

        public n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm __CreateDefault__()
        {
            n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm that_0 = this;
            this.__cache_RwjdEnWIB70L25AOxJ3FFE = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RwjdEnWIB70L25AOxJ3FFE);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117804U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RwjdEnWIB70L25AOxJ3FFE", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>> __cache_RwjdEnWIB70L25AOxJ3FFE = null;
        [n1.ElementAttribute(TracingId = 117879U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "P0HG7B2N2ssMOouTuldGEk", Name = "__slot_P0HG7B2N2ssMOouTuldGEk")]
        public static n17.TextureDimension __slot_P0HG7B2N2ssMOouTuldGEk = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture1D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "P0HG7B2N2ssMOouTuldGEk");
        [n1.ElementAttribute(TracingId = 117821U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "URH1mahks1UOclSajwm5mi", Name = "__slot_URH1mahks1UOclSajwm5mi")]
        public static n8.GraphicsResourceUsage __slot_URH1mahks1UOclSajwm5mi = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Default", false, "Dky5PMnuvcKN4CxmfNs7Uv", "URH1mahks1UOclSajwm5mi");
        static ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm()
        {
        }

        public ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm other): base(other)
        {
            this.__cache_RwjdEnWIB70L25AOxJ3FFE = other.__cache_RwjdEnWIB70L25AOxJ3FFE;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RwjdEnWIB70L25AOxJ3FFE", in __cache_RwjdEnWIB70L25AOxJ3FFE));
        }

        internal ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm __WITH__(n6.Manager<n2.ValueTuple<int, int, int, n17.PixelFormat, bool, bool>, n2.ValueTuple<n8.Texture>> __cache_RwjdEnWIB70L25AOxJ3FFE)
        {
            n27.ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RwjdEnWIB70L25AOxJ3FFE != this.__cache_RwjdEnWIB70L25AOxJ3FFE ? new ComputeTexture1D_Ble2PwEcLIJPosndgAb3Pm(this)
                {__cache_RwjdEnWIB70L25AOxJ3FFE = __cache_RwjdEnWIB70L25AOxJ3FFE} : that_0;
            else
            {
                this.__cache_RwjdEnWIB70L25AOxJ3FFE = __cache_RwjdEnWIB70L25AOxJ3FFE;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "MKwsaKc8uSXPnvEimhL84W", Name = "__MKwsaKc8uSXPnvEimhL84W")]
        [n2.SerializableAttribute]
        public class __MKwsaKc8uSXPnvEimhL84W : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_U9GV7oqg7vYQGWlQUZH8CB);
                n1.CompilationHelper.SafeDispose(this.__p_E8JgOlRplQoPHBFmmy9UoD);
                n1.CompilationHelper.SafeDispose(this.__p_G7bHbuJF9aaPGtSBXolMgG);
                return;
            }

            [n1.ElementAttribute(TracingId = 117822U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "U9GV7oqg7vYQGWlQUZH8CB", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_U9GV7oqg7vYQGWlQUZH8CB;
            [n1.ElementAttribute(TracingId = 117833U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "E8JgOlRplQoPHBFmmy9UoD", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_E8JgOlRplQoPHBFmmy9UoD;
            [n1.ElementAttribute(TracingId = 117855U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "G7bHbuJF9aaPGtSBXolMgG", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_G7bHbuJF9aaPGtSBXolMgG;
            public __MKwsaKc8uSXPnvEimhL84W(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MKwsaKc8uSXPnvEimhL84W(__MKwsaKc8uSXPnvEimhL84W other): base(other)
            {
                this.__p_U9GV7oqg7vYQGWlQUZH8CB = other.__p_U9GV7oqg7vYQGWlQUZH8CB;
                this.__p_E8JgOlRplQoPHBFmmy9UoD = other.__p_E8JgOlRplQoPHBFmmy9UoD;
                this.__p_G7bHbuJF9aaPGtSBXolMgG = other.__p_G7bHbuJF9aaPGtSBXolMgG;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_U9GV7oqg7vYQGWlQUZH8CB", in __p_U9GV7oqg7vYQGWlQUZH8CB), n1.CompilationHelper.GetValueOrExisting(values, "__p_E8JgOlRplQoPHBFmmy9UoD", in __p_E8JgOlRplQoPHBFmmy9UoD), n1.CompilationHelper.GetValueOrExisting(values, "__p_G7bHbuJF9aaPGtSBXolMgG", in __p_G7bHbuJF9aaPGtSBXolMgG));
            }

            internal __MKwsaKc8uSXPnvEimhL84W __WITH__(n1.IVLNode __p_U9GV7oqg7vYQGWlQUZH8CB, n1.IVLNode __p_E8JgOlRplQoPHBFmmy9UoD, n1.IVLNode __p_G7bHbuJF9aaPGtSBXolMgG)
            {
                __MKwsaKc8uSXPnvEimhL84W that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_U9GV7oqg7vYQGWlQUZH8CB != this.__p_U9GV7oqg7vYQGWlQUZH8CB || __p_E8JgOlRplQoPHBFmmy9UoD != this.__p_E8JgOlRplQoPHBFmmy9UoD || __p_G7bHbuJF9aaPGtSBXolMgG != this.__p_G7bHbuJF9aaPGtSBXolMgG ? new __MKwsaKc8uSXPnvEimhL84W(this)
                    {__p_U9GV7oqg7vYQGWlQUZH8CB = __p_U9GV7oqg7vYQGWlQUZH8CB, __p_E8JgOlRplQoPHBFmmy9UoD = __p_E8JgOlRplQoPHBFmmy9UoD, __p_G7bHbuJF9aaPGtSBXolMgG = __p_G7bHbuJF9aaPGtSBXolMgG} : that_0;
                else
                {
                    this.__p_U9GV7oqg7vYQGWlQUZH8CB = __p_U9GV7oqg7vYQGWlQUZH8CB;
                    this.__p_E8JgOlRplQoPHBFmmy9UoD = __p_E8JgOlRplQoPHBFmmy9UoD;
                    this.__p_G7bHbuJF9aaPGtSBXolMgG = __p_G7bHbuJF9aaPGtSBXolMgG;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 117970U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K0Vj0L7OsdvPDPyDP8NEjH", Name = "ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH")]
    [n2.SerializableAttribute]
    public class ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> CreateDefault<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var instance = new ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> Update<AdM>(T Initial_Data_In, [n4.SerializedDefaultValueAttribute("512", false)] int Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Recreate_On_Inital_Data_Change_In, bool Recreate_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_F7s2D18rJnlMLZ1CYIhc5D.Update(Value_In: Initial_Data_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_4 = Result_1 && Recreate_On_Inital_Data_Change_In;
            var Output_5 = Output_4 || Recreate_In;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_Gj0xZ8vvMWNNigZSKYlSUo;
            if (manager_7 is null)
            {
                manager_7 = new n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_8 = (Size_In, Format_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Output_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__RXXpPRkhl3IPqBqW6AwkKH>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __RXXpPRkhl3IPqBqW6AwkKH(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_12 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_11.__p_A4CRVToBrb8OXwOSRO8kBo = node_12;
                    var node_13 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_11.__p_OVDJIpuqV51MEVGf9yIFrN = node_13;
                    var node_14 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_11.__p_IBYCE9QZbiDOCNHqHKkQb5 = node_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "CIW0vlY3CiaPQmYNv8NvDZ", 118050U);
                    var Output_16 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_15);
                    state_11.__p_CIW0vlY3CiaPQmYNv8NvDZ = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "KvTJZEBMEZzNKOz5OEyNZZ", 118075U);
                    var Output_18 = n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider>.Create(Node_Context: Node_Context_17);
                    state_11.__p_KvTJZEBMEZzNKOz5OEyNZZ = Output_18;
                }

                n17.TextureDimension __pad_CA5feigB7jrP56VfBFQGj9_19 = __slot_CA5feigB7jrP56VfBFQGj9;
                n8.GraphicsResourceUsage __pad_RGgGnUNNlpbMecUwRjZbx4_20 = __slot_RGgGnUNNlpbMecUwRjZbx4;
                n1.CompilationHelper.WritePin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Inputs[0], ref __pad_CA5feigB7jrP56VfBFQGj9_19);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Size_In, Output_Out: out int Output_21);
                n1.CompilationHelper.WritePin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Inputs[1], ref Output_21);
                int Height_22 = 1;
                n1.CompilationHelper.WritePin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Inputs[2], ref Height_22);
                n1.CompilationHelper.WritePin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Inputs[8], ref __pad_RGgGnUNNlpbMecUwRjZbx4_20);
                n1.CompilationHelper.ReadPin(state_11.__p_OVDJIpuqV51MEVGf9yIFrN.Outputs[0], out n8.TextureDescription out_23);
                n1.CompilationHelper.WritePin(state_11.__p_A4CRVToBrb8OXwOSRO8kBo.Inputs[0], ref out_23);
                n1.CompilationHelper.WritePin(state_11.__p_IBYCE9QZbiDOCNHqHKkQb5.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_11.__p_IBYCE9QZbiDOCNHqHKkQb5.Outputs[0], out n8.TextureViewDescription out_24);
                n1.CompilationHelper.WritePin(state_11.__p_A4CRVToBrb8OXwOSRO8kBo.Inputs[1], ref out_24);
                int Offset_In_Bytes_25 = 0;
                bool Force_26 = false;
                bool SetInput_27 = true;
                var Output_28 = state_11.__p_CIW0vlY3CiaPQmYNv8NvDZ;
                if (SetInput_27)
                {
                    Output_28 = state_11.__p_CIW0vlY3CiaPQmYNv8NvDZ.SetInput<AdM>(Input_In: Initial_Data_In, Offset_In_Bytes_In: Offset_In_Bytes_25, Force_In: Force_26);
                }

                var State_Output_30 = Output_28.Update(Output_Out: out n14.IGraphicsDataProvider Output_29);
                bool Force_31 = false;
                var State_Output_33 = state_11.__p_KvTJZEBMEZzNKOz5OEyNZZ.Update(Input_In: Output_29, Force_In: Force_31, Output_Out: out n14.IGraphicsDataProvider[] Output_32);
                n1.CompilationHelper.WritePin(state_11.__p_A4CRVToBrb8OXwOSRO8kBo.Inputs[2], ref Output_32);
                var Output_34 = Output_4 || Recreate_In;
                n1.CompilationHelper.WritePin(state_11.__p_A4CRVToBrb8OXwOSRO8kBo.Inputs[3], ref Output_34);
                n1.CompilationHelper.ReadPin(state_11.__p_A4CRVToBrb8OXwOSRO8kBo.Outputs[0], out n8.Texture out_35);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = state_11.__p_OVDJIpuqV51MEVGf9yIFrN != state_11.__p_OVDJIpuqV51MEVGf9yIFrN || state_11.__p_A4CRVToBrb8OXwOSRO8kBo != state_11.__p_A4CRVToBrb8OXwOSRO8kBo || state_11.__p_IBYCE9QZbiDOCNHqHKkQb5 != state_11.__p_IBYCE9QZbiDOCNHqHKkQb5 || State_Output_30 != state_11.__p_CIW0vlY3CiaPQmYNv8NvDZ || State_Output_33 != state_11.__p_KvTJZEBMEZzNKOz5OEyNZZ ? new __RXXpPRkhl3IPqBqW6AwkKH(state_11)
                    {__p_OVDJIpuqV51MEVGf9yIFrN = state_11.__p_OVDJIpuqV51MEVGf9yIFrN, __p_A4CRVToBrb8OXwOSRO8kBo = state_11.__p_A4CRVToBrb8OXwOSRO8kBo, __p_IBYCE9QZbiDOCNHqHKkQb5 = state_11.__p_IBYCE9QZbiDOCNHqHKkQb5, __p_CIW0vlY3CiaPQmYNv8NvDZ = State_Output_30, __p_KvTJZEBMEZzNKOz5OEyNZZ = State_Output_33} : state_11;
                else
                {
                    state_11.__p_OVDJIpuqV51MEVGf9yIFrN = state_11.__p_OVDJIpuqV51MEVGf9yIFrN;
                    state_11.__p_A4CRVToBrb8OXwOSRO8kBo = state_11.__p_A4CRVToBrb8OXwOSRO8kBo;
                    state_11.__p_IBYCE9QZbiDOCNHqHKkQb5 = state_11.__p_IBYCE9QZbiDOCNHqHKkQb5;
                    state_11.__p_CIW0vlY3CiaPQmYNv8NvDZ = State_Output_30;
                    state_11.__p_KvTJZEBMEZzNKOz5OEyNZZ = State_Output_33;
                }

                outputs_9 = n2.ValueTuple.Create(out_35);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_36 = outputs_9.Item1;
            Output_Out = __auto_36;
            Has_Changed_Out = Has_Changed_10;
            n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = Output_3 != this.__p_F7s2D18rJnlMLZ1CYIhc5D || manager_7 != this.__cache_Gj0xZ8vvMWNNigZSKYlSUo ? new ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T>(this)
                {__p_F7s2D18rJnlMLZ1CYIhc5D = Output_3, __cache_Gj0xZ8vvMWNNigZSKYlSUo = manager_7} : that_37;
            else
            {
                this.__p_F7s2D18rJnlMLZ1CYIhc5D = Output_3;
                this.__cache_Gj0xZ8vvMWNNigZSKYlSUo = manager_7;
            }

            return that_37;
        }

        public n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "F7s2D18rJnlMLZ1CYIhc5D", 118165U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> that_4 = this;
            this.__p_F7s2D18rJnlMLZ1CYIhc5D = Output_3;
            this.__cache_Gj0xZ8vvMWNNigZSKYlSUo = null;
            return that_4;
        }

        public n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> __CreateDefault__<AdM>()
            where AdM : struct, n20.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> that_1 = this;
            this.__p_F7s2D18rJnlMLZ1CYIhc5D = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.CreateDefault<AdM>();
            this.__cache_Gj0xZ8vvMWNNigZSKYlSUo = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_F7s2D18rJnlMLZ1CYIhc5D);
            n1.CompilationHelper.SafeDispose(this.__cache_Gj0xZ8vvMWNNigZSKYlSUo);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 118165U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F7s2D18rJnlMLZ1CYIhc5D", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_F7s2D18rJnlMLZ1CYIhc5D;
        [n1.ElementAttribute(TracingId = 117975U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Gj0xZ8vvMWNNigZSKYlSUo", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_Gj0xZ8vvMWNNigZSKYlSUo = null;
        [n1.ElementAttribute(TracingId = 118100U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CA5feigB7jrP56VfBFQGj9", Name = "__slot_CA5feigB7jrP56VfBFQGj9")]
        public static n17.TextureDimension __slot_CA5feigB7jrP56VfBFQGj9 = n1.CompilationHelper.Deserialize<n17.TextureDimension>("Texture1D", false, "Dky5PMnuvcKN4CxmfNs7Uv", "CA5feigB7jrP56VfBFQGj9");
        [n1.ElementAttribute(TracingId = 117991U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RGgGnUNNlpbMecUwRjZbx4", Name = "__slot_RGgGnUNNlpbMecUwRjZbx4")]
        public static n8.GraphicsResourceUsage __slot_RGgGnUNNlpbMecUwRjZbx4 = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "RGgGnUNNlpbMecUwRjZbx4");
        static ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH()
        {
        }

        public ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH(ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> other): base(other)
        {
            this.__p_F7s2D18rJnlMLZ1CYIhc5D = other.__p_F7s2D18rJnlMLZ1CYIhc5D;
            this.__cache_Gj0xZ8vvMWNNigZSKYlSUo = other.__cache_Gj0xZ8vvMWNNigZSKYlSUo;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F7s2D18rJnlMLZ1CYIhc5D", in __p_F7s2D18rJnlMLZ1CYIhc5D), n1.CompilationHelper.GetValueOrExisting(values, "__cache_Gj0xZ8vvMWNNigZSKYlSUo", in __cache_Gj0xZ8vvMWNNigZSKYlSUo));
        }

        internal ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> __WITH__(n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_F7s2D18rJnlMLZ1CYIhc5D, n6.Manager<n2.ValueTuple<int, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_Gj0xZ8vvMWNNigZSKYlSUo)
        {
            n27.ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_F7s2D18rJnlMLZ1CYIhc5D != this.__p_F7s2D18rJnlMLZ1CYIhc5D || __cache_Gj0xZ8vvMWNNigZSKYlSUo != this.__cache_Gj0xZ8vvMWNNigZSKYlSUo ? new ImmutableTexture1D_K0Vj0L7OsdvPDPyDP8NEjH<T>(this)
                {__p_F7s2D18rJnlMLZ1CYIhc5D = __p_F7s2D18rJnlMLZ1CYIhc5D, __cache_Gj0xZ8vvMWNNigZSKYlSUo = __cache_Gj0xZ8vvMWNNigZSKYlSUo} : that_0;
            else
            {
                this.__p_F7s2D18rJnlMLZ1CYIhc5D = __p_F7s2D18rJnlMLZ1CYIhc5D;
                this.__cache_Gj0xZ8vvMWNNigZSKYlSUo = __cache_Gj0xZ8vvMWNNigZSKYlSUo;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RXXpPRkhl3IPqBqW6AwkKH", Name = "__RXXpPRkhl3IPqBqW6AwkKH")]
        [n2.SerializableAttribute]
        public class __RXXpPRkhl3IPqBqW6AwkKH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_A4CRVToBrb8OXwOSRO8kBo);
                n1.CompilationHelper.SafeDispose(this.__p_OVDJIpuqV51MEVGf9yIFrN);
                n1.CompilationHelper.SafeDispose(this.__p_IBYCE9QZbiDOCNHqHKkQb5);
                n1.CompilationHelper.SafeDispose(this.__p_CIW0vlY3CiaPQmYNv8NvDZ);
                n1.CompilationHelper.SafeDispose(this.__p_KvTJZEBMEZzNKOz5OEyNZZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 117994U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "A4CRVToBrb8OXwOSRO8kBo", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_A4CRVToBrb8OXwOSRO8kBo;
            [n1.ElementAttribute(TracingId = 118015U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OVDJIpuqV51MEVGf9yIFrN", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_OVDJIpuqV51MEVGf9yIFrN;
            [n1.ElementAttribute(TracingId = 118040U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IBYCE9QZbiDOCNHqHKkQb5", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_IBYCE9QZbiDOCNHqHKkQb5;
            [n1.ElementAttribute(TracingId = 118050U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "CIW0vlY3CiaPQmYNv8NvDZ", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_CIW0vlY3CiaPQmYNv8NvDZ;
            [n1.ElementAttribute(TracingId = 118075U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KvTJZEBMEZzNKOz5OEyNZZ", Name = "FromValue", IsManaged = true, IsAutoGenerated = true)]
            public n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_KvTJZEBMEZzNKOz5OEyNZZ;
            public __RXXpPRkhl3IPqBqW6AwkKH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RXXpPRkhl3IPqBqW6AwkKH(__RXXpPRkhl3IPqBqW6AwkKH other): base(other)
            {
                this.__p_A4CRVToBrb8OXwOSRO8kBo = other.__p_A4CRVToBrb8OXwOSRO8kBo;
                this.__p_OVDJIpuqV51MEVGf9yIFrN = other.__p_OVDJIpuqV51MEVGf9yIFrN;
                this.__p_IBYCE9QZbiDOCNHqHKkQb5 = other.__p_IBYCE9QZbiDOCNHqHKkQb5;
                this.__p_CIW0vlY3CiaPQmYNv8NvDZ = other.__p_CIW0vlY3CiaPQmYNv8NvDZ;
                this.__p_KvTJZEBMEZzNKOz5OEyNZZ = other.__p_KvTJZEBMEZzNKOz5OEyNZZ;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_A4CRVToBrb8OXwOSRO8kBo", in __p_A4CRVToBrb8OXwOSRO8kBo), n1.CompilationHelper.GetValueOrExisting(values, "__p_OVDJIpuqV51MEVGf9yIFrN", in __p_OVDJIpuqV51MEVGf9yIFrN), n1.CompilationHelper.GetValueOrExisting(values, "__p_IBYCE9QZbiDOCNHqHKkQb5", in __p_IBYCE9QZbiDOCNHqHKkQb5), n1.CompilationHelper.GetValueOrExisting(values, "__p_CIW0vlY3CiaPQmYNv8NvDZ", in __p_CIW0vlY3CiaPQmYNv8NvDZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_KvTJZEBMEZzNKOz5OEyNZZ", in __p_KvTJZEBMEZzNKOz5OEyNZZ));
            }

            internal __RXXpPRkhl3IPqBqW6AwkKH __WITH__(n1.IVLNode __p_A4CRVToBrb8OXwOSRO8kBo, n1.IVLNode __p_OVDJIpuqV51MEVGf9yIFrN, n1.IVLNode __p_IBYCE9QZbiDOCNHqHKkQb5, n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_CIW0vlY3CiaPQmYNv8NvDZ, n7.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n14.IGraphicsDataProvider> __p_KvTJZEBMEZzNKOz5OEyNZZ)
            {
                __RXXpPRkhl3IPqBqW6AwkKH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_A4CRVToBrb8OXwOSRO8kBo != this.__p_A4CRVToBrb8OXwOSRO8kBo || __p_OVDJIpuqV51MEVGf9yIFrN != this.__p_OVDJIpuqV51MEVGf9yIFrN || __p_IBYCE9QZbiDOCNHqHKkQb5 != this.__p_IBYCE9QZbiDOCNHqHKkQb5 || __p_CIW0vlY3CiaPQmYNv8NvDZ != this.__p_CIW0vlY3CiaPQmYNv8NvDZ || __p_KvTJZEBMEZzNKOz5OEyNZZ != this.__p_KvTJZEBMEZzNKOz5OEyNZZ ? new __RXXpPRkhl3IPqBqW6AwkKH(this)
                    {__p_A4CRVToBrb8OXwOSRO8kBo = __p_A4CRVToBrb8OXwOSRO8kBo, __p_OVDJIpuqV51MEVGf9yIFrN = __p_OVDJIpuqV51MEVGf9yIFrN, __p_IBYCE9QZbiDOCNHqHKkQb5 = __p_IBYCE9QZbiDOCNHqHKkQb5, __p_CIW0vlY3CiaPQmYNv8NvDZ = __p_CIW0vlY3CiaPQmYNv8NvDZ, __p_KvTJZEBMEZzNKOz5OEyNZZ = __p_KvTJZEBMEZzNKOz5OEyNZZ} : that_0;
                else
                {
                    this.__p_A4CRVToBrb8OXwOSRO8kBo = __p_A4CRVToBrb8OXwOSRO8kBo;
                    this.__p_OVDJIpuqV51MEVGf9yIFrN = __p_OVDJIpuqV51MEVGf9yIFrN;
                    this.__p_IBYCE9QZbiDOCNHqHKkQb5 = __p_IBYCE9QZbiDOCNHqHKkQb5;
                    this.__p_CIW0vlY3CiaPQmYNv8NvDZ = __p_CIW0vlY3CiaPQmYNv8NvDZ;
                    this.__p_KvTJZEBMEZzNKOz5OEyNZZ = __p_KvTJZEBMEZzNKOz5OEyNZZ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 120961U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JAJW0N78bjtP39GueSKiEK", Name = "Texture2DArray_JAJW0N78bjtP39GueSKiEK")]
    [n2.SerializableAttribute]
    public class Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Texture2DArray_JAJW0N78bjtP39GueSKiEK<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> CreateDefault()
        {
            var instance = new Texture2DArray_JAJW0N78bjtP39GueSKiEK<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> Update<AdM>(T Input_In, [n4.SerializedDefaultValueAttribute("128, 128", false)] n12.Int2 Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n17.PixelFormat Format_In, bool Recreate_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n8.Texture Output_Out, out bool Has_Changed_Out)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            int Offset_In_Bytes_1 = 0;
            bool Force_2 = false;
            bool SetInput_3 = true;
            var Output_4 = this.__p_JXRbW0VSzRYM6yUlrQ851J;
            if (SetInput_3)
            {
                Output_4 = this.__p_JXRbW0VSzRYM6yUlrQ851J.SetInput<AdM>(Input_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_1, Force_In: Force_2);
            }

            var State_Output_6 = Output_4.Update(Output_Out: out n14.IGraphicsDataProvider Output_5);
            n15._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_7);
            n5.ObjectHelpers.IsAssigned(x: Result_7, result: out bool Result_8, notAssigned: out bool Not_Assigned_9);
            var Output_10 = Result_8 && Apply_In;
            bool Dispose_Cached_Outputs_11 = false;
            var manager_12 = this.__cache_EAtaVfKpI3fMvbRg4OZiBD;
            if (manager_12 is null)
            {
                manager_12 = new n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_13 = (Size_In, Format_In);
            var outputs_14 = manager_12.Outputs;
            var Has_Changed_15 = Recreate_In || manager_12.InputsChanged(inputs_13);
            if (Has_Changed_15)
            {
                if (Dispose_Cached_Outputs_11)
                    manager_12.DisposeOutputs();
                var state_16 = n1.CompilationHelper.Restore<__PWXkjZlkxTWLwVAvN9p4q7>(manager_12.State, __GetContext__());
                if (state_16 == null)
                {
                    state_16 = new __PWXkjZlkxTWLwVAvN9p4q7(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_17 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Texture", "Stride.Graphics.Advanced");
                    state_16.__p_FBTBcF5kUXYP8w8PmiQBe4 = node_17;
                    var node_18 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureDescription", "Stride.Graphics.Advanced");
                    state_16.__p_FI82sxGRPmjPTLjqai492C = node_18;
                    var node_19 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "TextureViewDescription", "Stride.Graphics.Advanced");
                    state_16.__p_S68LQS3KdSYOetksgddUCM = node_19;
                }

                n8.GraphicsResourceUsage __pad_STRqhrbNpWqLShtTIiGSwn_20 = __slot_STRqhrbNpWqLShtTIiGSwn;
                n29._Operations_.Split(Input_In: Size_In, X_Out: out int X_21, Y_Out: out int Y_22);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_21, Output_Out: out int Output_23);
                n1.CompilationHelper.WritePin(state_16.__p_FI82sxGRPmjPTLjqai492C.Inputs[1], ref Output_23);
                n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_22, Output_Out: out int Output_24);
                n1.CompilationHelper.WritePin(state_16.__p_FI82sxGRPmjPTLjqai492C.Inputs[2], ref Output_24);
                n1.CompilationHelper.WritePin(state_16.__p_FI82sxGRPmjPTLjqai492C.Inputs[6], ref Format_In);
                n1.CompilationHelper.WritePin(state_16.__p_FI82sxGRPmjPTLjqai492C.Inputs[8], ref __pad_STRqhrbNpWqLShtTIiGSwn_20);
                n1.CompilationHelper.ReadPin(state_16.__p_FI82sxGRPmjPTLjqai492C.Outputs[0], out n8.TextureDescription out_25);
                n1.CompilationHelper.WritePin(state_16.__p_FBTBcF5kUXYP8w8PmiQBe4.Inputs[0], ref out_25);
                n1.CompilationHelper.WritePin(state_16.__p_S68LQS3KdSYOetksgddUCM.Inputs[0], ref Format_In);
                n1.CompilationHelper.ReadPin(state_16.__p_S68LQS3KdSYOetksgddUCM.Outputs[0], out n8.TextureViewDescription out_26);
                n1.CompilationHelper.WritePin(state_16.__p_FBTBcF5kUXYP8w8PmiQBe4.Inputs[1], ref out_26);
                n1.CompilationHelper.WritePin(state_16.__p_FBTBcF5kUXYP8w8PmiQBe4.Inputs[3], ref Recreate_In);
                n1.CompilationHelper.ReadPin(state_16.__p_FBTBcF5kUXYP8w8PmiQBe4.Outputs[0], out n8.Texture out_27);
                if (state_16.__GetContext__().IsImmutable)
                    state_16 = state_16.__p_FI82sxGRPmjPTLjqai492C != state_16.__p_FI82sxGRPmjPTLjqai492C || state_16.__p_FBTBcF5kUXYP8w8PmiQBe4 != state_16.__p_FBTBcF5kUXYP8w8PmiQBe4 || state_16.__p_S68LQS3KdSYOetksgddUCM != state_16.__p_S68LQS3KdSYOetksgddUCM ? new __PWXkjZlkxTWLwVAvN9p4q7(state_16)
                    {__p_FI82sxGRPmjPTLjqai492C = state_16.__p_FI82sxGRPmjPTLjqai492C, __p_FBTBcF5kUXYP8w8PmiQBe4 = state_16.__p_FBTBcF5kUXYP8w8PmiQBe4, __p_S68LQS3KdSYOetksgddUCM = state_16.__p_S68LQS3KdSYOetksgddUCM} : state_16;
                else
                {
                    state_16.__p_FI82sxGRPmjPTLjqai492C = state_16.__p_FI82sxGRPmjPTLjqai492C;
                    state_16.__p_FBTBcF5kUXYP8w8PmiQBe4 = state_16.__p_FBTBcF5kUXYP8w8PmiQBe4;
                    state_16.__p_S68LQS3KdSYOetksgddUCM = state_16.__p_S68LQS3KdSYOetksgddUCM;
                }

                outputs_14 = n2.ValueTuple.Create(out_27);
                manager_12 = manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11, state_16, outputs_14);
            }
            else
            {
                manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11);
            }

            var __auto_28 = outputs_14.Item1;
            bool Re_Initialize_29 = false;
            var __fallback___30 = n1.ServiceRegistry.Current;
            n33._Operations_.Update_H<n2.Object, n8.Texture>(Input_In: this.__p_GBAR3lQtA6EMdk3yPrMFYW, Default_Output_In: __auto_28, Re_Initialize_In: Re_Initialize_29, Try_In: (n2.Object s_33) =>
            {
                using var __current_31 = __fallback___30.MakeCurrentIfNone();
                var state_32 = n1.CompilationHelper.Restore<__OADboWWyvYvMcXqOR4Kjhm>(s_33, __GetContext__());
                int Array_Slice_34 = 0;
                int Mip_Slice_35 = 0;
                n2.Nullable<n8.ResourceRegion> Region_36 = default(n2.Nullable<n8.ResourceRegion>);
                var State_Output_38 = state_32.__p_K573sBnTSsjO94ly0UiVN0.Update(Input_In: __auto_28, Data_In: Output_5, Array_Slice_In: Array_Slice_34, Mip_Slice_In: Mip_Slice_35, Region_In: Region_36, Apply_In: Output_10, Output_Out: out n8.Texture Output_37);
                if (state_32.__GetContext__().IsImmutable)
                    state_32 = State_Output_38 != state_32.__p_K573sBnTSsjO94ly0UiVN0 ? new __OADboWWyvYvMcXqOR4Kjhm(state_32)
                    {__p_K573sBnTSsjO94ly0UiVN0 = State_Output_38} : state_32;
                else
                {
                    state_32.__p_K573sBnTSsjO94ly0UiVN0 = State_Output_38;
                }

                return n2.Tuple.Create<n2.Object, n8.Texture>(state_32, Output_37);
            }

            , Create_In: () =>
            {
                using var __current_39 = __fallback___30.MakeCurrentIfNone();
                var state_32 = new __OADboWWyvYvMcXqOR4Kjhm(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_40 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "K573sBnTSsjO94ly0UiVN0", 121320U);
                var Output_41 = n31.SetData_FPEbMrBTNrWLDZKYInJXKW.Create(Node_Context: Node_Context_40);
                state_32.__p_K573sBnTSsjO94ly0UiVN0 = Output_41;
                return state_32;
            }

            , Output_Out: out n32.TryStateful<n2.Object> Output_42, Result_Out: out n8.Texture Result_43, Success_Out: out bool Success_44, Error_Message_Out: out string Error_Message_45);
            Output_Out = Result_43;
            Has_Changed_Out = Has_Changed_15;
            n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> that_46 = this;
            if (this.__GetContext__().IsImmutable)
                that_46 = State_Output_6 != this.__p_JXRbW0VSzRYM6yUlrQ851J || manager_12 != this.__cache_EAtaVfKpI3fMvbRg4OZiBD || Output_42 != this.__p_GBAR3lQtA6EMdk3yPrMFYW ? new Texture2DArray_JAJW0N78bjtP39GueSKiEK<T>(this)
                {__p_JXRbW0VSzRYM6yUlrQ851J = State_Output_6, __cache_EAtaVfKpI3fMvbRg4OZiBD = manager_12, __p_GBAR3lQtA6EMdk3yPrMFYW = Output_42} : that_46;
            else
            {
                this.__p_JXRbW0VSzRYM6yUlrQ851J = State_Output_6;
                this.__cache_EAtaVfKpI3fMvbRg4OZiBD = manager_12;
                this.__p_GBAR3lQtA6EMdk3yPrMFYW = Output_42;
            }

            return that_46;
        }

        public n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "JXRbW0VSzRYM6yUlrQ851J", 121254U);
            var Output_1 = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "GBAR3lQtA6EMdk3yPrMFYW", 121289U);
            n33._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_2, Output_Out: out n32.TryStateful<n2.Object> Output_3);
            n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> that_4 = this;
            this.__p_JXRbW0VSzRYM6yUlrQ851J = Output_1;
            this.__p_GBAR3lQtA6EMdk3yPrMFYW = Output_3;
            this.__cache_EAtaVfKpI3fMvbRg4OZiBD = null;
            return that_4;
        }

        public n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> __CreateDefault__()
        {
            n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> that_0 = this;
            this.__p_JXRbW0VSzRYM6yUlrQ851J = n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>.CreateDefault();
            this.__cache_EAtaVfKpI3fMvbRg4OZiBD = null;
            this.__p_GBAR3lQtA6EMdk3yPrMFYW = default(n32.TryStateful<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JXRbW0VSzRYM6yUlrQ851J);
            n1.CompilationHelper.SafeDispose(this.__cache_EAtaVfKpI3fMvbRg4OZiBD);
            n1.CompilationHelper.SafeDispose(this.__p_GBAR3lQtA6EMdk3yPrMFYW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 121254U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JXRbW0VSzRYM6yUlrQ851J", Name = "GraphicsData", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_JXRbW0VSzRYM6yUlrQ851J;
        [n1.ElementAttribute(TracingId = 120973U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EAtaVfKpI3fMvbRg4OZiBD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_EAtaVfKpI3fMvbRg4OZiBD = null;
        [n1.ElementAttribute(TracingId = 120998U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "STRqhrbNpWqLShtTIiGSwn", Name = "__slot_STRqhrbNpWqLShtTIiGSwn")]
        public static n8.GraphicsResourceUsage __slot_STRqhrbNpWqLShtTIiGSwn = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Dynamic", false, "Dky5PMnuvcKN4CxmfNs7Uv", "STRqhrbNpWqLShtTIiGSwn");
        [n1.ElementAttribute(TracingId = 121289U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GBAR3lQtA6EMdk3yPrMFYW", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
        public n32.TryStateful<n2.Object> __p_GBAR3lQtA6EMdk3yPrMFYW;
        static Texture2DArray_JAJW0N78bjtP39GueSKiEK()
        {
        }

        public Texture2DArray_JAJW0N78bjtP39GueSKiEK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Texture2DArray_JAJW0N78bjtP39GueSKiEK(Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> other): base(other)
        {
            this.__p_JXRbW0VSzRYM6yUlrQ851J = other.__p_JXRbW0VSzRYM6yUlrQ851J;
            this.__cache_EAtaVfKpI3fMvbRg4OZiBD = other.__cache_EAtaVfKpI3fMvbRg4OZiBD;
            this.__p_GBAR3lQtA6EMdk3yPrMFYW = other.__p_GBAR3lQtA6EMdk3yPrMFYW;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JXRbW0VSzRYM6yUlrQ851J", in __p_JXRbW0VSzRYM6yUlrQ851J), n1.CompilationHelper.GetValueOrExisting(values, "__cache_EAtaVfKpI3fMvbRg4OZiBD", in __cache_EAtaVfKpI3fMvbRg4OZiBD), n1.CompilationHelper.GetValueOrExisting(values, "__p_GBAR3lQtA6EMdk3yPrMFYW", in __p_GBAR3lQtA6EMdk3yPrMFYW));
        }

        internal Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> __WITH__(n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __p_JXRbW0VSzRYM6yUlrQ851J, n6.Manager<n2.ValueTuple<n12.Int2, n17.PixelFormat>, n2.ValueTuple<n8.Texture>> __cache_EAtaVfKpI3fMvbRg4OZiBD, n32.TryStateful<n2.Object> __p_GBAR3lQtA6EMdk3yPrMFYW)
        {
            n27.Texture2DArray_JAJW0N78bjtP39GueSKiEK<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JXRbW0VSzRYM6yUlrQ851J != this.__p_JXRbW0VSzRYM6yUlrQ851J || __cache_EAtaVfKpI3fMvbRg4OZiBD != this.__cache_EAtaVfKpI3fMvbRg4OZiBD || __p_GBAR3lQtA6EMdk3yPrMFYW != this.__p_GBAR3lQtA6EMdk3yPrMFYW ? new Texture2DArray_JAJW0N78bjtP39GueSKiEK<T>(this)
                {__p_JXRbW0VSzRYM6yUlrQ851J = __p_JXRbW0VSzRYM6yUlrQ851J, __cache_EAtaVfKpI3fMvbRg4OZiBD = __cache_EAtaVfKpI3fMvbRg4OZiBD, __p_GBAR3lQtA6EMdk3yPrMFYW = __p_GBAR3lQtA6EMdk3yPrMFYW} : that_0;
            else
            {
                this.__p_JXRbW0VSzRYM6yUlrQ851J = __p_JXRbW0VSzRYM6yUlrQ851J;
                this.__cache_EAtaVfKpI3fMvbRg4OZiBD = __cache_EAtaVfKpI3fMvbRg4OZiBD;
                this.__p_GBAR3lQtA6EMdk3yPrMFYW = __p_GBAR3lQtA6EMdk3yPrMFYW;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PWXkjZlkxTWLwVAvN9p4q7", Name = "__PWXkjZlkxTWLwVAvN9p4q7")]
        [n2.SerializableAttribute]
        public class __PWXkjZlkxTWLwVAvN9p4q7 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FBTBcF5kUXYP8w8PmiQBe4);
                n1.CompilationHelper.SafeDispose(this.__p_FI82sxGRPmjPTLjqai492C);
                n1.CompilationHelper.SafeDispose(this.__p_S68LQS3KdSYOetksgddUCM);
                return;
            }

            [n1.ElementAttribute(TracingId = 121004U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FBTBcF5kUXYP8w8PmiQBe4", Name = "Texture", IsManaged = true, IsAutoGenerated = true, NodeName = "Texture", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_FBTBcF5kUXYP8w8PmiQBe4;
            [n1.ElementAttribute(TracingId = 121043U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FI82sxGRPmjPTLjqai492C", Name = "TextureDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_FI82sxGRPmjPTLjqai492C;
            [n1.ElementAttribute(TracingId = 121100U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "S68LQS3KdSYOetksgddUCM", Name = "TextureViewDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "TextureViewDescription", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_S68LQS3KdSYOetksgddUCM;
            public __PWXkjZlkxTWLwVAvN9p4q7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PWXkjZlkxTWLwVAvN9p4q7(__PWXkjZlkxTWLwVAvN9p4q7 other): base(other)
            {
                this.__p_FBTBcF5kUXYP8w8PmiQBe4 = other.__p_FBTBcF5kUXYP8w8PmiQBe4;
                this.__p_FI82sxGRPmjPTLjqai492C = other.__p_FI82sxGRPmjPTLjqai492C;
                this.__p_S68LQS3KdSYOetksgddUCM = other.__p_S68LQS3KdSYOetksgddUCM;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FBTBcF5kUXYP8w8PmiQBe4", in __p_FBTBcF5kUXYP8w8PmiQBe4), n1.CompilationHelper.GetValueOrExisting(values, "__p_FI82sxGRPmjPTLjqai492C", in __p_FI82sxGRPmjPTLjqai492C), n1.CompilationHelper.GetValueOrExisting(values, "__p_S68LQS3KdSYOetksgddUCM", in __p_S68LQS3KdSYOetksgddUCM));
            }

            internal __PWXkjZlkxTWLwVAvN9p4q7 __WITH__(n1.IVLNode __p_FBTBcF5kUXYP8w8PmiQBe4, n1.IVLNode __p_FI82sxGRPmjPTLjqai492C, n1.IVLNode __p_S68LQS3KdSYOetksgddUCM)
            {
                __PWXkjZlkxTWLwVAvN9p4q7 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FBTBcF5kUXYP8w8PmiQBe4 != this.__p_FBTBcF5kUXYP8w8PmiQBe4 || __p_FI82sxGRPmjPTLjqai492C != this.__p_FI82sxGRPmjPTLjqai492C || __p_S68LQS3KdSYOetksgddUCM != this.__p_S68LQS3KdSYOetksgddUCM ? new __PWXkjZlkxTWLwVAvN9p4q7(this)
                    {__p_FBTBcF5kUXYP8w8PmiQBe4 = __p_FBTBcF5kUXYP8w8PmiQBe4, __p_FI82sxGRPmjPTLjqai492C = __p_FI82sxGRPmjPTLjqai492C, __p_S68LQS3KdSYOetksgddUCM = __p_S68LQS3KdSYOetksgddUCM} : that_0;
                else
                {
                    this.__p_FBTBcF5kUXYP8w8PmiQBe4 = __p_FBTBcF5kUXYP8w8PmiQBe4;
                    this.__p_FI82sxGRPmjPTLjqai492C = __p_FI82sxGRPmjPTLjqai492C;
                    this.__p_S68LQS3KdSYOetksgddUCM = __p_S68LQS3KdSYOetksgddUCM;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OADboWWyvYvMcXqOR4Kjhm", Name = "__OADboWWyvYvMcXqOR4Kjhm")]
        [n2.SerializableAttribute]
        public class __OADboWWyvYvMcXqOR4Kjhm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_K573sBnTSsjO94ly0UiVN0);
                return;
            }

            [n1.ElementAttribute(TracingId = 121320U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "K573sBnTSsjO94ly0UiVN0", Name = "SetData", IsManaged = true, IsAutoGenerated = true)]
            public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_K573sBnTSsjO94ly0UiVN0;
            public __OADboWWyvYvMcXqOR4Kjhm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OADboWWyvYvMcXqOR4Kjhm(__OADboWWyvYvMcXqOR4Kjhm other): base(other)
            {
                this.__p_K573sBnTSsjO94ly0UiVN0 = other.__p_K573sBnTSsjO94ly0UiVN0;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_K573sBnTSsjO94ly0UiVN0", in __p_K573sBnTSsjO94ly0UiVN0));
            }

            internal __OADboWWyvYvMcXqOR4Kjhm __WITH__(n31.SetData_FPEbMrBTNrWLDZKYInJXKW __p_K573sBnTSsjO94ly0UiVN0)
            {
                __OADboWWyvYvMcXqOR4Kjhm that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_K573sBnTSsjO94ly0UiVN0 != this.__p_K573sBnTSsjO94ly0UiVN0 ? new __OADboWWyvYvMcXqOR4Kjhm(this)
                    {__p_K573sBnTSsjO94ly0UiVN0 = __p_K573sBnTSsjO94ly0UiVN0} : that_0;
                else
                {
                    this.__p_K573sBnTSsjO94ly0UiVN0 = __p_K573sBnTSsjO94ly0UiVN0;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.Advanced
{
    [n1.ElementAttribute(TracingId = 112761U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HrZ7v1TOZ75ODnvgAMM5aV", Name = "TextureReader_HrZ7v1TOZ75ODnvgAMM5aV")]
    [n2.SerializableAttribute]
    public class TextureReader_HrZ7v1TOZ75ODnvgAMM5aV : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV Create(n1.NodeContext Node_Context)
        {
            var instance = new TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV CreateDefault()
        {
            var instance = new TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV Update(n36.Path File_Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, out n8.Texture Output_Out)
        {
            bool __pad_TEgjVpsQT2KNzm42VaVMPF_0 = __slot_TEgjVpsQT2KNzm42VaVMPF;
            bool Force_1 = false;
            var manager_2 = this.__cache_C6YNksUnSUmLDbeUjl275a;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n36.Path, bool>, n2.ValueTuple<n8.Texture>>(n2.ValueTuple.Create(default(n8.Texture)));
            }

            var inputs_3 = (File_Path_In, Is_sRGB_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_1 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (__pad_TEgjVpsQT2KNzm42VaVMPF_0)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Kz1TFBbdAcWN05TWOl3Ojd>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Kz1TFBbdAcWN05TWOl3Ojd(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = n37._Operations_.CreateDefault<bool>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "A3pjsMbzCEsP4CIHnpeHrE", 112891U);
                    var Output_8 = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_7);
                    state_6.__p_A3pjsMbzCEsP4CIHnpeHrE = Output_8;
                }

                var Exists_9 = File_Path_In.Exists;
                int Index_10 = n2.Convert.ToInt32(Is_sRGB_In);
                var State_Output_12 = state_6.__p_A3pjsMbzCEsP4CIHnpeHrE.Update(Output_Out: out n8.GraphicsDevice Output_11);
                var Color_Space_13 = Output_11.ColorSpace;
                n17.ColorSpace Input_2_14 = default(n17.ColorSpace);
                var Result_15 = Color_Space_13 == Input_2_14;
                bool Input_16 = false;
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb, 2);
                builder_17.Add(Input_16);
                builder_17.Add(Result_15);
                var __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb_18 = builder_17.Commit();
                n21._Operations_.Switch<bool, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Index_In: Index_10, Input_In: __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb_18, Output_Out: out bool Output_19);
                n8.Texture __auto_20;
                var state_21 = n1.CompilationHelper.Restore<__FVJPHiEZwlYMXcP3ZvGH06>(state_6.__if_CPbO2GnMaIYO6j2SF0wWTH, __GetContext__());
                if (Exists_9)
                {
                    if (state_21 == null)
                    {
                        state_21 = new __FVJPHiEZwlYMXcP3ZvGH06(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "H3a443eFxG8NvjttRHv9BP", 112815U);
                        var Output_23 = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_22);
                        state_21.__p_H3a443eFxG8NvjttRHv9BP = Output_23;
                    }

                    var State_Output_25 = state_21.__p_H3a443eFxG8NvjttRHv9BP.Update(Output_Out: out n8.GraphicsDevice Output_24);
                    var Result_26 = (string)File_Path_In;
                    n8.TextureFlags Texture_Flags_27 = __c_FluvDrXIP1iPUPZ7kmNSMy;
                    n8.GraphicsResourceUsage Usage_28 = __c_FHxkVBAXSfWOHp2BMH6P9k;
                    var Result_29 = n14.TextureExtensions.Load(device: Output_24, file: Result_26, textureFlags: Texture_Flags_27, usage: Usage_28, loadAsSRGB: Output_19);
                    __auto_20 = Result_29;
                    if (state_21.__GetContext__().IsImmutable)
                        state_21 = State_Output_25 != state_21.__p_H3a443eFxG8NvjttRHv9BP ? new __FVJPHiEZwlYMXcP3ZvGH06(state_21)
                        {__p_H3a443eFxG8NvjttRHv9BP = State_Output_25} : state_21;
                    else
                    {
                        state_21.__p_H3a443eFxG8NvjttRHv9BP = State_Output_25;
                    }
                }
                else
                {
                    __auto_20 = default(n8.Texture);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_12 != state_6.__p_A3pjsMbzCEsP4CIHnpeHrE || __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb_18 != state_6.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb || state_21 != state_6.__if_CPbO2GnMaIYO6j2SF0wWTH ? new __Kz1TFBbdAcWN05TWOl3Ojd(state_6)
                    {__p_A3pjsMbzCEsP4CIHnpeHrE = State_Output_12, __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb_18, __if_CPbO2GnMaIYO6j2SF0wWTH = state_21} : state_6;
                else
                {
                    state_6.__p_A3pjsMbzCEsP4CIHnpeHrE = State_Output_12;
                    state_6.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb_18;
                    state_6.__if_CPbO2GnMaIYO6j2SF0wWTH = state_21;
                }

                outputs_4 = n2.ValueTuple.Create(__auto_20);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, __pad_TEgjVpsQT2KNzm42VaVMPF_0, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, __pad_TEgjVpsQT2KNzm42VaVMPF_0);
            }

            var __auto_30 = outputs_4.Item1;
            Output_Out = __auto_30;
            n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = manager_2 != this.__cache_C6YNksUnSUmLDbeUjl275a ? new TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(this)
                {__cache_C6YNksUnSUmLDbeUjl275a = manager_2} : that_31;
            else
            {
                this.__cache_C6YNksUnSUmLDbeUjl275a = manager_2;
            }

            return that_31;
        }

        public n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV that_0 = this;
            this.__cache_C6YNksUnSUmLDbeUjl275a = null;
            return that_0;
        }

        public n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV __CreateDefault__()
        {
            n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV that_0 = this;
            this.__cache_C6YNksUnSUmLDbeUjl275a = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_C6YNksUnSUmLDbeUjl275a);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 112938U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TEgjVpsQT2KNzm42VaVMPF", Name = "__slot_TEgjVpsQT2KNzm42VaVMPF")]
        public static bool __slot_TEgjVpsQT2KNzm42VaVMPF = true;
        [n1.ElementAttribute(TracingId = 112768U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "C6YNksUnSUmLDbeUjl275a", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n36.Path, bool>, n2.ValueTuple<n8.Texture>> __cache_C6YNksUnSUmLDbeUjl275a = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.TextureFlags __c_FluvDrXIP1iPUPZ7kmNSMy = n1.CompilationHelper.Deserialize<n8.TextureFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "FluvDrXIP1iPUPZ7kmNSMy");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.GraphicsResourceUsage __c_FHxkVBAXSfWOHp2BMH6P9k = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "FHxkVBAXSfWOHp2BMH6P9k");
        static TextureReader_HrZ7v1TOZ75ODnvgAMM5aV()
        {
        }

        public TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(TextureReader_HrZ7v1TOZ75ODnvgAMM5aV other): base(other)
        {
            this.__cache_C6YNksUnSUmLDbeUjl275a = other.__cache_C6YNksUnSUmLDbeUjl275a;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_C6YNksUnSUmLDbeUjl275a", in __cache_C6YNksUnSUmLDbeUjl275a));
        }

        internal TextureReader_HrZ7v1TOZ75ODnvgAMM5aV __WITH__(n6.Manager<n2.ValueTuple<n36.Path, bool>, n2.ValueTuple<n8.Texture>> __cache_C6YNksUnSUmLDbeUjl275a)
        {
            n31.TextureReader_HrZ7v1TOZ75ODnvgAMM5aV that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_C6YNksUnSUmLDbeUjl275a != this.__cache_C6YNksUnSUmLDbeUjl275a ? new TextureReader_HrZ7v1TOZ75ODnvgAMM5aV(this)
                {__cache_C6YNksUnSUmLDbeUjl275a = __cache_C6YNksUnSUmLDbeUjl275a} : that_0;
            else
            {
                this.__cache_C6YNksUnSUmLDbeUjl275a = __cache_C6YNksUnSUmLDbeUjl275a;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Kz1TFBbdAcWN05TWOl3Ojd", Name = "__Kz1TFBbdAcWN05TWOl3Ojd")]
        [n2.SerializableAttribute]
        public class __Kz1TFBbdAcWN05TWOl3Ojd : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_A3pjsMbzCEsP4CIHnpeHrE);
                n1.CompilationHelper.SafeDispose(this.__if_CPbO2GnMaIYO6j2SF0wWTH);
                return;
            }

            [n1.ElementAttribute(TracingId = 112891U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "A3pjsMbzCEsP4CIHnpeHrE", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_A3pjsMbzCEsP4CIHnpeHrE;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n26.Spread<bool> __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = default(n26.Spread<bool>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_CPbO2GnMaIYO6j2SF0wWTH;
            public __Kz1TFBbdAcWN05TWOl3Ojd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Kz1TFBbdAcWN05TWOl3Ojd(__Kz1TFBbdAcWN05TWOl3Ojd other): base(other)
            {
                this.__p_A3pjsMbzCEsP4CIHnpeHrE = other.__p_A3pjsMbzCEsP4CIHnpeHrE;
                this.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = other.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb;
                this.__if_CPbO2GnMaIYO6j2SF0wWTH = other.__if_CPbO2GnMaIYO6j2SF0wWTH;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_A3pjsMbzCEsP4CIHnpeHrE", in __p_A3pjsMbzCEsP4CIHnpeHrE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb", in __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb), n1.CompilationHelper.GetValueOrExisting(values, "__if_CPbO2GnMaIYO6j2SF0wWTH", in __if_CPbO2GnMaIYO6j2SF0wWTH));
            }

            internal __Kz1TFBbdAcWN05TWOl3Ojd __WITH__(n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_A3pjsMbzCEsP4CIHnpeHrE, n26.Spread<bool> __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb, n2.Object __if_CPbO2GnMaIYO6j2SF0wWTH)
            {
                __Kz1TFBbdAcWN05TWOl3Ojd that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_A3pjsMbzCEsP4CIHnpeHrE != this.__p_A3pjsMbzCEsP4CIHnpeHrE || __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb != this.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb || __if_CPbO2GnMaIYO6j2SF0wWTH != this.__if_CPbO2GnMaIYO6j2SF0wWTH ? new __Kz1TFBbdAcWN05TWOl3Ojd(this)
                    {__p_A3pjsMbzCEsP4CIHnpeHrE = __p_A3pjsMbzCEsP4CIHnpeHrE, __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb, __if_CPbO2GnMaIYO6j2SF0wWTH = __if_CPbO2GnMaIYO6j2SF0wWTH} : that_0;
                else
                {
                    this.__p_A3pjsMbzCEsP4CIHnpeHrE = __p_A3pjsMbzCEsP4CIHnpeHrE;
                    this.__pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb = __pin_group_Input_In_GXN2E0f1mUTO28CCkpjxwb;
                    this.__if_CPbO2GnMaIYO6j2SF0wWTH = __if_CPbO2GnMaIYO6j2SF0wWTH;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FVJPHiEZwlYMXcP3ZvGH06", Name = "__FVJPHiEZwlYMXcP3ZvGH06")]
        [n2.SerializableAttribute]
        public class __FVJPHiEZwlYMXcP3ZvGH06 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_H3a443eFxG8NvjttRHv9BP);
                return;
            }

            [n1.ElementAttribute(TracingId = 112815U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "H3a443eFxG8NvjttRHv9BP", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_H3a443eFxG8NvjttRHv9BP;
            public __FVJPHiEZwlYMXcP3ZvGH06(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FVJPHiEZwlYMXcP3ZvGH06(__FVJPHiEZwlYMXcP3ZvGH06 other): base(other)
            {
                this.__p_H3a443eFxG8NvjttRHv9BP = other.__p_H3a443eFxG8NvjttRHv9BP;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H3a443eFxG8NvjttRHv9BP", in __p_H3a443eFxG8NvjttRHv9BP));
            }

            internal __FVJPHiEZwlYMXcP3ZvGH06 __WITH__(n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_H3a443eFxG8NvjttRHv9BP)
            {
                __FVJPHiEZwlYMXcP3ZvGH06 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_H3a443eFxG8NvjttRHv9BP != this.__p_H3a443eFxG8NvjttRHv9BP ? new __FVJPHiEZwlYMXcP3ZvGH06(this)
                    {__p_H3a443eFxG8NvjttRHv9BP = __p_H3a443eFxG8NvjttRHv9BP} : that_0;
                else
                {
                    this.__p_H3a443eFxG8NvjttRHv9BP = __p_H3a443eFxG8NvjttRHv9BP;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 113010U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FPEbMrBTNrWLDZKYInJXKW", Name = "SetData_FPEbMrBTNrWLDZKYInJXKW")]
    [n2.SerializableAttribute]
    public class SetData_FPEbMrBTNrWLDZKYInJXKW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n31.SetData_FPEbMrBTNrWLDZKYInJXKW Create(n1.NodeContext Node_Context)
        {
            var instance = new SetData_FPEbMrBTNrWLDZKYInJXKW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n31.SetData_FPEbMrBTNrWLDZKYInJXKW CreateDefault()
        {
            var instance = new SetData_FPEbMrBTNrWLDZKYInJXKW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.SetData_FPEbMrBTNrWLDZKYInJXKW Update(n8.Texture Input_In, n14.IGraphicsDataProvider Data_In, [n4.SerializedDefaultValueAttribute("0", false)] int Array_Slice_In, [n4.SerializedDefaultValueAttribute("0", false)] int Mip_Slice_In, n2.Nullable<n8.ResourceRegion> Region_In, bool Apply_In, out n8.Texture Output_Out)
        {
            n8.GraphicsContext __auto_0 = this.Output;
            n8.Texture __auto_1;
            if (Apply_In)
            {
                var Command_List_3 = __auto_0.CommandList;
                var Output_4 = n14.TextureExtensions.SetDataFromProvider(texture: Input_In, commandList: Command_List_3, data: Data_In, arraySlice: Array_Slice_In, mipSlice: Mip_Slice_In, region: Region_In);
                __auto_1 = Output_4;
            }
            else
            {
                __auto_1 = Input_In;
            }

            Output_Out = __auto_1;
            return this;
        }

        public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "RgxYUmTMJMpLLgQTgdQyrq", 113073U);
            var Output_1 = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.Create(Node_Context_In: Node_Context_0);
            var State_Output_3 = Output_1.Update(Output_Out: out n8.GraphicsContext Output_2);
            n8.GraphicsContext __auto_4 = Output_2;
            n31.SetData_FPEbMrBTNrWLDZKYInJXKW that_5 = this;
            this.Output = Output_2;
            this.__p_RgxYUmTMJMpLLgQTgdQyrq = State_Output_3;
            return that_5;
        }

        public n31.SetData_FPEbMrBTNrWLDZKYInJXKW __CreateDefault__()
        {
            n31.SetData_FPEbMrBTNrWLDZKYInJXKW that_0 = this;
            this.Output = default(n8.GraphicsContext);
            this.__p_RgxYUmTMJMpLLgQTgdQyrq = n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RgxYUmTMJMpLLgQTgdQyrq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 113078U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "M0itgszoGufMoIy4jMyeJP", Name = "Output")]
        public n8.GraphicsContext Output;
        [n1.ElementAttribute(TracingId = 113073U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RgxYUmTMJMpLLgQTgdQyrq", Name = "GraphicsContext", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_RgxYUmTMJMpLLgQTgdQyrq;
        public SetData_FPEbMrBTNrWLDZKYInJXKW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetData_FPEbMrBTNrWLDZKYInJXKW(SetData_FPEbMrBTNrWLDZKYInJXKW other): base(other)
        {
            this.Output = other.Output;
            this.__p_RgxYUmTMJMpLLgQTgdQyrq = other.__p_RgxYUmTMJMpLLgQTgdQyrq;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Output", in Output), n1.CompilationHelper.GetValueOrExisting(values, "__p_RgxYUmTMJMpLLgQTgdQyrq", in __p_RgxYUmTMJMpLLgQTgdQyrq));
        }

        internal SetData_FPEbMrBTNrWLDZKYInJXKW __WITH__(n8.GraphicsContext Output, n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_RgxYUmTMJMpLLgQTgdQyrq)
        {
            n31.SetData_FPEbMrBTNrWLDZKYInJXKW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output || __p_RgxYUmTMJMpLLgQTgdQyrq != this.__p_RgxYUmTMJMpLLgQTgdQyrq ? new SetData_FPEbMrBTNrWLDZKYInJXKW(this)
                {Output = Output, __p_RgxYUmTMJMpLLgQTgdQyrq = __p_RgxYUmTMJMpLLgQTgdQyrq} : that_0;
            else
            {
                this.Output = Output;
                this.__p_RgxYUmTMJMpLLgQTgdQyrq = __p_RgxYUmTMJMpLLgQTgdQyrq;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 113166U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "ED1w6KteGIfQbh9SW2Xc4y", Name = "TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y")]
    [n2.SerializableAttribute]
    public class TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y Create(n1.NodeContext Node_Context)
        {
            var instance = new TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y CreateDefault()
        {
            var instance = new TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y Update([n4.SerializedDefaultValueAttribute("..\\..\\..\\..\\Downloads\\", false)] n36.Path File_Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, n8.Texture Default_In, out n8.Texture Output_Out)
        {
            var State_Output_1 = this.__p_DE5BoK65A2hN1mtjBNrGkW.Update(Output_Out: out n8.GraphicsDevice Output_0);
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_Fnr7rwwqtr0QBsm2EbMJwR;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n8.GraphicsDevice, n36.Path, bool>, n2.ValueTuple<n39.IResourceProvider<n38.TextureLoadTask_C>>>(n2.ValueTuple.Create(n40._Operations_.CreateDefault<n38.TextureLoadTask_C, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>()));
            }

            var inputs_5 = (Output_0, File_Path_In, Is_sRGB_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Ig9aqly3wyiPtMYtevJlTx", 113532U);
                n41._Operations_.Create<n36.Path, bool>(Node_Context: Node_Context_9, Item_1_In: File_Path_In, Item_2_In: Is_sRGB_In, Output_Out: out n2.ValueTuple<n36.Path, bool> Output_10);
                int Delay_Disposal_In_Milliseconds_11 = 0;
                var __fallback___12 = n1.ServiceRegistry.Current;
                n42._Operations_.NewPooled_PerApp<n2.ValueTuple<n36.Path, bool>, n38.TextureLoadTask_C>(Key_In: Output_10, Delay_Disposal_In_Milliseconds_In: Delay_Disposal_In_Milliseconds_11, Factory_In: (n2.ValueTuple<n36.Path, bool> Input_In_14) =>
                {
                    using var __current_13 = __fallback___12.MakeCurrentIfNone();
                    n41._Operations_.Split<n36.Path, bool>(Input_In: Input_In_14, Item_1_Out: out n36.Path Item_1_15, Item_2_Out: out bool Item_2_16);
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "NuU6nbi3p5QM81mRhou5wt", 113521U);
                    var Output_18 = n38.TextureLoadTask_C.Create(Node_Context: Node_Context_17, Device_In: Output_0, Path_In: Item_1_15, Is_sRGB_In: Item_2_16);
                    return Output_18;
                }

                , Result_Out: out n39.IResourceProvider<n38.TextureLoadTask_C> Result_19);
                outputs_6 = n2.ValueTuple.Create(Result_19);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_20 = outputs_6.Item1;
            bool Update_21 = true;
            var Output_22 = this.__p_BSo7Ne0Nl5LMTGsEgIugsX;
            if (Update_21)
            {
                Output_22 = this.__p_BSo7Ne0Nl5LMTGsEgIugsX.Update(Input_In: __auto_20);
            }

            var Output_24 = Output_22.GetResource(Resource_Out: out n38.TextureLoadTask_C Resource_23);
            var Output_26 = Resource_23.Texture(Default_In: Default_In, Texture_Out: out n8.Texture Texture_25);
            Output_Out = Texture_25;
            n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = State_Output_1 != this.__p_DE5BoK65A2hN1mtjBNrGkW || manager_4 != this.__cache_Fnr7rwwqtr0QBsm2EbMJwR || Output_24 != this.__p_BSo7Ne0Nl5LMTGsEgIugsX ? new TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(this)
                {__p_DE5BoK65A2hN1mtjBNrGkW = State_Output_1, __cache_Fnr7rwwqtr0QBsm2EbMJwR = manager_4, __p_BSo7Ne0Nl5LMTGsEgIugsX = Output_24} : that_27;
            else
            {
                this.__p_DE5BoK65A2hN1mtjBNrGkW = State_Output_1;
                this.__cache_Fnr7rwwqtr0QBsm2EbMJwR = manager_4;
                this.__p_BSo7Ne0Nl5LMTGsEgIugsX = Output_24;
            }

            return that_27;
        }

        public n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "DE5BoK65A2hN1mtjBNrGkW", 113475U);
            var Output_1 = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "BSo7Ne0Nl5LMTGsEgIugsX", 113483U);
            var Output_3 = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n38.TextureLoadTask_C>, n38.TextureLoadTask_C>.Create(Node_Context: Node_Context_2);
            n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y that_4 = this;
            this.__p_DE5BoK65A2hN1mtjBNrGkW = Output_1;
            this.__p_BSo7Ne0Nl5LMTGsEgIugsX = Output_3;
            this.__cache_Fnr7rwwqtr0QBsm2EbMJwR = null;
            return that_4;
        }

        public n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y Dispose_()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DE5BoK65A2hN1mtjBNrGkW);
            n1.CompilationHelper.SafeDispose(this.__cache_Fnr7rwwqtr0QBsm2EbMJwR);
            n1.CompilationHelper.SafeDispose(this.__p_BSo7Ne0Nl5LMTGsEgIugsX);
            return this;
        }

        public n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y __CreateDefault__()
        {
            n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y that_0 = this;
            this.__p_DE5BoK65A2hN1mtjBNrGkW = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.CreateDefault();
            this.__cache_Fnr7rwwqtr0QBsm2EbMJwR = null;
            this.__p_BSo7Ne0Nl5LMTGsEgIugsX = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n38.TextureLoadTask_C>, n38.TextureLoadTask_C>.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 113475U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "DE5BoK65A2hN1mtjBNrGkW", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_DE5BoK65A2hN1mtjBNrGkW;
        [n1.ElementAttribute(TracingId = 113491U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Fnr7rwwqtr0QBsm2EbMJwR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n8.GraphicsDevice, n36.Path, bool>, n2.ValueTuple<n39.IResourceProvider<n38.TextureLoadTask_C>>> __cache_Fnr7rwwqtr0QBsm2EbMJwR = null;
        [n1.ElementAttribute(TracingId = 113483U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BSo7Ne0Nl5LMTGsEgIugsX", Name = "Using (Process)", IsManaged = true, IsAutoGenerated = true)]
        public n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n38.TextureLoadTask_C>, n38.TextureLoadTask_C> __p_BSo7Ne0Nl5LMTGsEgIugsX;
        public TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y other): base(other)
        {
            this.__p_DE5BoK65A2hN1mtjBNrGkW = other.__p_DE5BoK65A2hN1mtjBNrGkW;
            this.__cache_Fnr7rwwqtr0QBsm2EbMJwR = other.__cache_Fnr7rwwqtr0QBsm2EbMJwR;
            this.__p_BSo7Ne0Nl5LMTGsEgIugsX = other.__p_BSo7Ne0Nl5LMTGsEgIugsX;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DE5BoK65A2hN1mtjBNrGkW", in __p_DE5BoK65A2hN1mtjBNrGkW), n1.CompilationHelper.GetValueOrExisting(values, "__cache_Fnr7rwwqtr0QBsm2EbMJwR", in __cache_Fnr7rwwqtr0QBsm2EbMJwR), n1.CompilationHelper.GetValueOrExisting(values, "__p_BSo7Ne0Nl5LMTGsEgIugsX", in __p_BSo7Ne0Nl5LMTGsEgIugsX));
        }

        internal TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y __WITH__(n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_DE5BoK65A2hN1mtjBNrGkW, n6.Manager<n2.ValueTuple<n8.GraphicsDevice, n36.Path, bool>, n2.ValueTuple<n39.IResourceProvider<n38.TextureLoadTask_C>>> __cache_Fnr7rwwqtr0QBsm2EbMJwR, n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n38.TextureLoadTask_C>, n38.TextureLoadTask_C> __p_BSo7Ne0Nl5LMTGsEgIugsX)
        {
            n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = __p_DE5BoK65A2hN1mtjBNrGkW != this.__p_DE5BoK65A2hN1mtjBNrGkW || __cache_Fnr7rwwqtr0QBsm2EbMJwR != this.__cache_Fnr7rwwqtr0QBsm2EbMJwR || __p_BSo7Ne0Nl5LMTGsEgIugsX != this.__p_BSo7Ne0Nl5LMTGsEgIugsX ? new TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y(this)
                {__p_DE5BoK65A2hN1mtjBNrGkW = __p_DE5BoK65A2hN1mtjBNrGkW, __cache_Fnr7rwwqtr0QBsm2EbMJwR = __cache_Fnr7rwwqtr0QBsm2EbMJwR, __p_BSo7Ne0Nl5LMTGsEgIugsX = __p_BSo7Ne0Nl5LMTGsEgIugsX} : that_1;
            else
            {
                this.__p_DE5BoK65A2hN1mtjBNrGkW = __p_DE5BoK65A2hN1mtjBNrGkW;
                this.__cache_Fnr7rwwqtr0QBsm2EbMJwR = __cache_Fnr7rwwqtr0QBsm2EbMJwR;
                this.__p_BSo7Ne0Nl5LMTGsEgIugsX = __p_BSo7Ne0Nl5LMTGsEgIugsX;
            }

            return that_1;
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.TextureReader_Async.Advanced
{
    [n1.ElementAttribute(TracingId = 113172U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "PXUOc6U1BkyPLN8LwZ3a61", Name = "TextureLoadTask_C")]
    [n2.SerializableAttribute]
    public class TextureLoadTask_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.TextureLoadTask_C Create(n1.NodeContext Node_Context, n8.GraphicsDevice Device_In, [n4.SerializedDefaultValueAttribute("..\\..\\..\\..\\Downloads\\", false)] n36.Path Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TextureLoadTask_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Device_In, Path_In, Is_sRGB_In);
        }

        [n4.CreateDefaultAttribute]
        public static n38.TextureLoadTask_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TextureLoadTask_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.TextureLoadTask_C Texture(n8.Texture Default_In, out n8.Texture Texture_Out)
        {
            n43.Task<n8.Texture> __auto_0 = this.Task;
            var Is_Completed_1 = __auto_0.IsCompleted;
            n8.Texture __auto_2;
            if (Is_Completed_1)
            {
                var Result_4 = __auto_0.Result;
                __auto_2 = Result_4;
            }
            else
            {
                __auto_2 = Default_In;
            }

            Texture_Out = __auto_2;
            return this;
        }

        public n38.TextureLoadTask_C __Create__(n1.NodeContext Node_Context, n8.GraphicsDevice Device_In, [n4.SerializedDefaultValueAttribute("..\\..\\..\\..\\Downloads\\", false)] n36.Path Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Task = default(n43.Task<n8.Texture>);
            var Exists_0 = Path_In.Exists;
            n8.Texture Result_1 = default(n8.Texture);
            var Result_2 = n43.Task.FromResult<n8.Texture>(result: Result_1);
            int Index_3 = n2.Convert.ToInt32(Is_sRGB_In);
            n43.Task<n8.Texture> __auto_4;
            var state_5 = n1.CompilationHelper.Restore<__EGyU5LfOxRHLbdY5PK9BiO>(this.__if_Btenn6CTM8ANeB2cLu1LV8, Node_Context);
            if (Exists_0)
            {
                if (state_5 == null)
                {
                    state_5 = new __EGyU5LfOxRHLbdY5PK9BiO(Node_Context, n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw = n37._Operations_.CreateDefault<bool>()};
                }

                var Color_Space_5 = Device_In.ColorSpace;
                n17.ColorSpace Input_2_6 = default(n17.ColorSpace);
                var Result_7 = Color_Space_5 == Input_2_6;
                bool Input_8 = false;
                var builder_9 = n4.CollectionBuilders.GetBuilder(state_5.__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw, 2);
                builder_9.Add(Input_8);
                builder_9.Add(Result_7);
                var __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw_10 = builder_9.Commit();
                n21._Operations_.Switch<bool, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Index_In: Index_3, Input_In: __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw_10, Output_Out: out bool Output_11);
                var __fallback___12 = n1.ServiceRegistry.Current;
                var Result_18 = n43.Task.Run<n8.Texture>(function: () =>
                {
                    using var __current_13 = __fallback___12.MakeCurrentIfNone();
                    var Result_14 = (string)Path_In;
                    n8.TextureFlags Texture_Flags_15 = __c_R0OnmDMwDN2QVQZelDCbw5;
                    n8.GraphicsResourceUsage Usage_16 = __c_ScS28vDtJiGQdbnX0DdOcs;
                    var Result_17 = n14.TextureExtensions.Load(device: Device_In, file: Result_14, textureFlags: Texture_Flags_15, usage: Usage_16, loadAsSRGB: Output_11);
                    return Result_17;
                }

                );
                __auto_4 = Result_18;
                state_5.__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw = __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw_10;
                this.__if_Btenn6CTM8ANeB2cLu1LV8 = state_5;
            }
            else
            {
                __auto_4 = Result_2;
            }

            this.Task = __auto_4;
            n43.Task<n8.Texture> __auto_19 = __auto_4;
            return this;
        }

        public n38.TextureLoadTask_C Dispose_()
        {
            n43.Task<n8.Texture> __auto_0 = this.Task;
            var Result_1 = __auto_0.Result;
            n5.ObjectHelpers.IsAssigned(x: Result_1, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            n2.IDisposable Input_4 = (n2.IDisposable)Result_1;
            n43.Task<n8.Texture> __auto_5;
            if (Result_2)
            {
                ((n2.IDisposable)Input_4).Dispose();
                __auto_5 = __auto_0;
            }
            else
            {
                __auto_5 = __auto_0;
            }

            __auto_5.Dispose();
            n1.CompilationHelper.SafeDispose(this.__if_Btenn6CTM8ANeB2cLu1LV8);
            return this;
        }

        public n38.TextureLoadTask_C __CreateDefault__()
        {
            this.Task = default(n43.Task<n8.Texture>);
            this.__if_Btenn6CTM8ANeB2cLu1LV8 = default(n2.Object);
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 113179U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Kj2nOySGJi8PAZMlwbjqz4", Name = "Task")]
        public n43.Task<n8.Texture> Task;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.TextureFlags __c_R0OnmDMwDN2QVQZelDCbw5 = n1.CompilationHelper.Deserialize<n8.TextureFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "R0OnmDMwDN2QVQZelDCbw5");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.GraphicsResourceUsage __c_ScS28vDtJiGQdbnX0DdOcs = n1.CompilationHelper.Deserialize<n8.GraphicsResourceUsage>("Immutable", false, "Dky5PMnuvcKN4CxmfNs7Uv", "ScS28vDtJiGQdbnX0DdOcs");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Btenn6CTM8ANeB2cLu1LV8;
        static TextureLoadTask_C()
        {
        }

        public TextureLoadTask_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureLoadTask_C(TextureLoadTask_C other): base(other)
        {
            this.Task = other.Task;
            this.__if_Btenn6CTM8ANeB2cLu1LV8 = other.__if_Btenn6CTM8ANeB2cLu1LV8;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Task", in Task), n1.CompilationHelper.GetValueOrExisting(values, "__if_Btenn6CTM8ANeB2cLu1LV8", in __if_Btenn6CTM8ANeB2cLu1LV8));
        }

        internal TextureLoadTask_C __WITH__(n43.Task<n8.Texture> Task, n2.Object __if_Btenn6CTM8ANeB2cLu1LV8)
        {
            n38.TextureLoadTask_C that_0 = this;
            this.Task = Task;
            this.__if_Btenn6CTM8ANeB2cLu1LV8 = __if_Btenn6CTM8ANeB2cLu1LV8;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "EGyU5LfOxRHLbdY5PK9BiO", Name = "__EGyU5LfOxRHLbdY5PK9BiO")]
        [n2.SerializableAttribute]
        public class __EGyU5LfOxRHLbdY5PK9BiO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n26.Spread<bool> __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw = default(n26.Spread<bool>);
            public __EGyU5LfOxRHLbdY5PK9BiO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EGyU5LfOxRHLbdY5PK9BiO(__EGyU5LfOxRHLbdY5PK9BiO other): base(other)
            {
                this.__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw = other.__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw", in __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw));
            }

            internal __EGyU5LfOxRHLbdY5PK9BiO __WITH__(n26.Spread<bool> __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw)
            {
                __EGyU5LfOxRHLbdY5PK9BiO that_0 = this;
                this.__pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw = __pin_group_Input_In_Hg7xIDPbjCKM03K5IDVuNw;
                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.Utils.Advanced
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ReplaceValue<T, AdM>(T Input_In, T Replace_Value_In, out T Output_Out)
            where AdM : struct, n44.IAdaptiveOperatorGreater<T>, n44.IAdaptiveZero<T>
        {
            var w_0 = default(AdM);
            w_0.Zero(Zero_Out: out T Zero_1);
            w_0.OperatorGreater(Input_In: Replace_Value_In, Input_2_In: Zero_1, Result_Out: out bool Result_2);
            n19._Operations_.Switch_Boolean<T>(Condition_In: Result_2, Input_In: Input_In, Input_2_In: Replace_Value_In, Output_Out: out T Output_3);
            Output_Out = Output_3;
            return;
        }

        public static void ReplaceSize(n12.Int2 Size_In, n12.Int2 Replace_Size_In, out n12.Int2 Output_Out)
        {
            n29._Operations_.Split(Input_In: Replace_Size_In, X_Out: out int X_0, Y_Out: out int Y_1);
            n29._Operations_.Split(Input_In: Size_In, X_Out: out int X_2, Y_Out: out int Y_3);
            n24._Operations_.ReplaceValue<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: X_2, Replace_Value_In: X_0, Output_Out: out int Output_4);
            n24._Operations_.ReplaceValue<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Y_3, Replace_Value_In: Y_1, Output_Out: out int Output_5);
            n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_5, Output_Out: out int Output_6);
            n30._Operations_.EnsureOne<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_4, Output_Out: out int Output_7);
            n1.NodeContext Node_Context_8 = n1.NodeContext.Default.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "TYjF5uTu2TYONCYKJrgbpr", 113742U);
            n29._Operations_.Create(Node_Context: Node_Context_8, X_In: Output_7, Y_In: Output_6, Output_Out: out n12.Int2 Output_9);
            Output_Out = Output_9;
            return;
        }

        public static void ReplaceFormat(n17.PixelFormat Input_In, [n4.SerializedDefaultValueAttribute("None", false)] n17.PixelFormat New_Format_In, out n17.PixelFormat Output_Out)
        {
            n17.PixelFormat __pad_TQmigsZ5UTdQJRB5skfDfC_0 = __slot_TQmigsZ5UTdQJRB5skfDfC;
            var Result_1 = New_Format_In != __pad_TQmigsZ5UTdQJRB5skfDfC_0;
            n19._Operations_.Switch_Boolean<n17.PixelFormat>(Condition_In: Result_1, Input_In: Input_In, Input_2_In: New_Format_In, Output_Out: out n17.PixelFormat Output_2);
            Output_Out = Output_2;
            return;
        }

        public static void GetArraySize(n8.Texture Input_In, out int Output_Out)
        {
            int __pad_VIqxSbYzcVyOGop3VTNhFR_0 = __slot_VIqxSbYzcVyOGop3VTNhFR;
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            int __auto_3;
            if (Result_1)
            {
                var Array_Size_4 = Input_In.ArraySize;
                __auto_3 = Array_Size_4;
            }
            else
            {
                __auto_3 = __pad_VIqxSbYzcVyOGop3VTNhFR_0;
            }

            Output_Out = __auto_3;
            return;
        }

        public static void CanCopyTo(n8.Texture From_In, n8.Texture To_In, out bool Properties_Equals_Out, out bool Reference_Equals_Out)
        {
            n45._Operations_.TextureInfo(Input_In: From_In, Output_Out: out n8.Texture Output_0, Size_Out: out n12.Int2 Size_1, Width_Out: out int Width_2, Height_Out: out int Height_3, Depth_Out: out int Depth_4, Format_Out: out n17.PixelFormat Format_5, Mip_Levels_Out: out int Mip_Levels_6, Array_Size_Out: out int Array_Size_7, Shared_Handle_Out: out n2.IntPtr Shared_Handle_8, Loaded_Out: out bool Loaded_9);
            var Result_10 = n5.ObjectHelpers.Eq(input: From_In, input2: To_In);
            n45._Operations_.TextureInfo(Input_In: To_In, Output_Out: out n8.Texture Output_11, Size_Out: out n12.Int2 Size_12, Width_Out: out int Width_13, Height_Out: out int Height_14, Depth_Out: out int Depth_15, Format_Out: out n17.PixelFormat Format_16, Mip_Levels_Out: out int Mip_Levels_17, Array_Size_Out: out int Array_Size_18, Shared_Handle_Out: out n2.IntPtr Shared_Handle_19, Loaded_Out: out bool Loaded_20);
            var Result_21 = Size_1 == Size_12;
            var Result_22 = Depth_4 == Depth_15;
            var Result_23 = n17.PixelFormatExtensions.BlockSize(format: Format_5);
            var Result_24 = n17.PixelFormatExtensions.BlockSize(format: Format_16);
            var Result_25 = Result_23 == Result_24;
            var Result_26 = Mip_Levels_6 == Mip_Levels_17;
            var Result_27 = Array_Size_7 == Array_Size_18;
            var Output_28 = Result_21 && Result_22;
            var Output_29 = Output_28 && Result_25;
            var Output_30 = Output_29 && Result_26;
            var Output_31 = Output_30 && Result_27;
            var Output_32 = Output_31 && Loaded_9;
            var Output_33 = Output_32 && Loaded_20;
            Properties_Equals_Out = Output_33;
            Reference_Equals_Out = Result_10;
            return;
        }

        public static void CopyTextureSafe(n8.CommandList Command_List_In, n8.Texture Source_In, n8.Texture Destination_In, out bool Success_Out)
        {
            n24._Operations_.CanCopyTo(From_In: Source_In, To_In: Destination_In, Properties_Equals_Out: out bool Properties_Equals_0, Reference_Equals_Out: out bool Reference_Equals_1);
            if (Properties_Equals_0)
            {
                Command_List_In.Copy(source: Source_In, destination: Destination_In);
            }

            Success_Out = Properties_Equals_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 113902U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TQmigsZ5UTdQJRB5skfDfC", Name = "__slot_TQmigsZ5UTdQJRB5skfDfC")]
        public static n17.PixelFormat __slot_TQmigsZ5UTdQJRB5skfDfC = n1.CompilationHelper.Deserialize<n17.PixelFormat>("None", false, "Dky5PMnuvcKN4CxmfNs7Uv", "TQmigsZ5UTdQJRB5skfDfC");
        [n1.ElementAttribute(TracingId = 113924U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VIqxSbYzcVyOGop3VTNhFR", Name = "__slot_VIqxSbYzcVyOGop3VTNhFR")]
        public static int __slot_VIqxSbYzcVyOGop3VTNhFR = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.Utils
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsShared(n8.Texture Input_In, out n8.Texture Output_Out, out bool Is_Shared_Out, out n2.IntPtr Shared_Handle_Out, out bool Exists_Out)
        {
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            bool __auto_2;
            n2.IntPtr __auto_3;
            if (Result_0)
            {
                var Shared_Handle_4 = Input_In.SharedHandle;
                var Zero_5 = n2.IntPtr.Zero;
                var Result_6 = Shared_Handle_4 != Zero_5;
                __auto_2 = Result_6;
                __auto_3 = Shared_Handle_4;
            }
            else
            {
                __auto_2 = false;
                __auto_3 = n46._Operations_.CreateDefault();
            }

            Output_Out = Input_In;
            Is_Shared_Out = __auto_2;
            Shared_Handle_Out = __auto_3;
            Exists_Out = Result_0;
            return;
        }

        public static void Info(n8.Texture Input_In, out n8.Texture Output_Out, out n12.Int2 View_Size_Out, out n17.PixelFormat View_Format_Out, out n12.Int2 Resource_Size_Out, out n17.PixelFormat Resource_Format_Out, out bool Exists_Out)
        {
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n12.Int2 __auto_2;
            n17.PixelFormat __auto_3;
            n12.Int2 __auto_4;
            n17.PixelFormat __auto_5;
            bool __auto_6;
            if (Result_0)
            {
                var View_Width_7 = Input_In.ViewWidth;
                var View_Height_8 = Input_In.ViewHeight;
                n1.NodeContext Node_Context_9 = n1.NodeContext.Default.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "GvVM63WUAgkOa9YpJfDs8l", 115029U);
                n29._Operations_.Create(Node_Context: Node_Context_9, X_In: View_Width_7, Y_In: View_Height_8, Output_Out: out n12.Int2 Output_10);
                __auto_2 = Output_10;
                var View_Format_11 = Input_In.ViewFormat;
                __auto_3 = View_Format_11;
                var Width_12 = Input_In.Width;
                var Height_13 = Input_In.Height;
                n1.NodeContext Node_Context_14 = n1.NodeContext.Default.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "HwMVELCy0T0PZaa7ZdVdek", 115090U);
                n29._Operations_.Create(Node_Context: Node_Context_14, X_In: Width_12, Y_In: Height_13, Output_Out: out n12.Int2 Output_15);
                __auto_4 = Output_15;
                var Format_16 = Input_In.Format;
                __auto_5 = Format_16;
                var Is_Disposed_17 = Input_In.IsDisposed;
                __auto_6 = Is_Disposed_17;
            }
            else
            {
                __auto_2 = default(n12.Int2);
                __auto_3 = default(n17.PixelFormat);
                __auto_4 = default(n12.Int2);
                __auto_5 = default(n17.PixelFormat);
                __auto_6 = false;
            }

            n16._Operations_.ANDNOT(Input_In: Result_0, Input_2_In: __auto_6, Output_Out: out bool Output_18);
            Output_Out = Input_In;
            View_Size_Out = __auto_2;
            View_Format_Out = __auto_3;
            Resource_Size_Out = __auto_4;
            Resource_Format_Out = __auto_5;
            Exists_Out = Output_18;
            return;
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.Utils.Obsolete
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TextureInfo(n8.Texture Input_In, out n8.Texture Output_Out, out n12.Int2 Size_Out, out int Width_Out, out int Height_Out, out int Depth_Out, out n17.PixelFormat Format_Out, out int Mip_Levels_Out, out int Array_Size_Out, out n2.IntPtr Shared_Handle_Out, out bool Loaded_Out)
        {
            n17.PixelFormat __pad_BzDlKOr78Z3MzsYYOcQYAs_0 = __slot_BzDlKOr78Z3MzsYYOcQYAs;
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n12.Int2 __auto_3;
            int __auto_4;
            int __auto_5;
            int __auto_6;
            n17.PixelFormat __auto_7;
            int __auto_8;
            int __auto_9;
            n2.IntPtr __auto_10;
            bool __auto_11;
            if (Result_1)
            {
                var Width_12 = Input_In.Width;
                var Height_13 = Input_In.Height;
                n1.NodeContext Node_Context_14 = n1.NodeContext.Default.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "OsoS5ae76R1N5ids3G6ieJ", 114434U);
                n29._Operations_.Create(Node_Context: Node_Context_14, X_In: Width_12, Y_In: Height_13, Output_Out: out n12.Int2 Output_15);
                __auto_5 = Height_13;
                __auto_3 = Output_15;
                __auto_4 = Width_12;
                var Format_16 = Input_In.Format;
                __auto_7 = Format_16;
                var Array_Size_17 = Input_In.ArraySize;
                __auto_9 = Array_Size_17;
                var Shared_Handle_18 = Input_In.SharedHandle;
                __auto_10 = Shared_Handle_18;
                var Depth_19 = Input_In.Depth;
                __auto_6 = Depth_19;
                var Mip_Levels_20 = Input_In.MipLevels;
                __auto_8 = Mip_Levels_20;
                var Is_Disposed_21 = Input_In.IsDisposed;
                __auto_11 = Is_Disposed_21;
            }
            else
            {
                __auto_3 = default(n12.Int2);
                __auto_4 = 0;
                __auto_5 = 0;
                __auto_6 = 0;
                __auto_7 = __pad_BzDlKOr78Z3MzsYYOcQYAs_0;
                __auto_8 = 0;
                __auto_9 = 0;
                __auto_10 = n46._Operations_.CreateDefault();
                __auto_11 = false;
            }

            n16._Operations_.ANDNOT(Input_In: Result_1, Input_2_In: __auto_11, Output_Out: out bool Output_22);
            Output_Out = Input_In;
            Size_Out = __auto_3;
            Width_Out = __auto_4;
            Height_Out = __auto_5;
            Depth_Out = __auto_6;
            Format_Out = __auto_7;
            Mip_Levels_Out = __auto_8;
            Array_Size_Out = __auto_9;
            Shared_Handle_Out = __auto_10;
            Loaded_Out = Output_22;
            return;
        }

        public static void TextureInfo_Basic(n8.Texture Input_In, out n8.Texture Output_Out, out n12.Int2 Size_Out, out int Width_Out, out int Height_Out, out n17.PixelFormat Format_Out, out bool Loaded_Out)
        {
            n17.PixelFormat __pad_V2lZGvV8Fn3L4SCWZzEIzI_0 = __slot_V2lZGvV8Fn3L4SCWZzEIzI;
            n5.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n12.Int2 __auto_3;
            int __auto_4;
            int __auto_5;
            n17.PixelFormat __auto_6;
            if (Result_1)
            {
                var Width_7 = Input_In.Width;
                var Height_8 = Input_In.Height;
                n1.NodeContext Node_Context_9 = n1.NodeContext.Default.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "QtQlo0l1D39LJQKbrNTGWv", 114846U);
                n29._Operations_.Create(Node_Context: Node_Context_9, X_In: Width_7, Y_In: Height_8, Output_Out: out n12.Int2 Output_10);
                __auto_5 = Height_8;
                __auto_3 = Output_10;
                __auto_4 = Width_7;
                var Format_11 = Input_In.Format;
                __auto_6 = Format_11;
            }
            else
            {
                __auto_3 = default(n12.Int2);
                __auto_4 = 0;
                __auto_5 = 0;
                __auto_6 = __pad_V2lZGvV8Fn3L4SCWZzEIzI_0;
            }

            Output_Out = Input_In;
            Size_Out = __auto_3;
            Width_Out = __auto_4;
            Height_Out = __auto_5;
            Format_Out = __auto_6;
            Loaded_Out = Result_1;
            return;
        }

        [n1.ElementAttribute(TracingId = 114688U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BzDlKOr78Z3MzsYYOcQYAs", Name = "__slot_BzDlKOr78Z3MzsYYOcQYAs")]
        public static n17.PixelFormat __slot_BzDlKOr78Z3MzsYYOcQYAs = default(n17.PixelFormat);
        [n1.ElementAttribute(TracingId = 114925U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "V2lZGvV8Fn3L4SCWZzEIzI", Name = "__slot_V2lZGvV8Fn3L4SCWZzEIzI")]
        public static n17.PixelFormat __slot_V2lZGvV8Fn3L4SCWZzEIzI = default(n17.PixelFormat);
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Textures.Internal
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TextureFlags([n4.SerializedDefaultValueAttribute("True", false)] bool Is_Unordered_Access_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Render_Target_In, bool Is_Depth_Stencil_In, bool Is_Shared_In, out n8.TextureFlags Output_Out, out n8.TextureOptions Options_Out)
        {
            n8.TextureFlags __pad_TBsnc30a3R6ObAeNqWhmn3_0 = __slot_TBsnc30a3R6ObAeNqWhmn3;
            var Output_1 = Is_Render_Target_In || Is_Depth_Stencil_In;
            n16._Operations_.ANDNOT(Input_In: Is_Unordered_Access_In, Input_2_In: Output_1, Output_Out: out bool Output_2);
            n8.TextureFlags __auto_3;
            if (Output_2)
            {
                n8.TextureFlags __pad_GjkQDtXH9tcOX2C71bZkjY_4 = __slot_GjkQDtXH9tcOX2C71bZkjY;
                var Output_5 = __pad_TBsnc30a3R6ObAeNqWhmn3_0 | __pad_GjkQDtXH9tcOX2C71bZkjY_4;
                __auto_3 = Output_5;
            }
            else
            {
                __auto_3 = __pad_TBsnc30a3R6ObAeNqWhmn3_0;
            }

            n16._Operations_.ANDNOT(Input_In: Is_Render_Target_In, Input_2_In: Is_Depth_Stencil_In, Output_Out: out bool Output_6);
            n8.TextureFlags __auto_7;
            if (Output_6)
            {
                n8.TextureFlags __pad_QwEFCAIgUnGMPOhQtXm5Sy_8 = __slot_QwEFCAIgUnGMPOhQtXm5Sy;
                var Output_9 = __auto_3 | __pad_QwEFCAIgUnGMPOhQtXm5Sy_8;
                __auto_7 = Output_9;
            }
            else
            {
                __auto_7 = __auto_3;
            }

            n8.TextureFlags __auto_10;
            if (Is_Depth_Stencil_In)
            {
                n8.TextureFlags __pad_Md3hdJcao6GQCTeV1nHoGj_11 = __slot_Md3hdJcao6GQCTeV1nHoGj;
                var Output_12 = __auto_7 | __pad_Md3hdJcao6GQCTeV1nHoGj_11;
                __auto_10 = Output_12;
            }
            else
            {
                __auto_10 = __auto_7;
            }

            n8.TextureOptions __auto_13;
            if (Is_Shared_In)
            {
                n8.TextureOptions __pad_BbKBgKsMCruPMx5IZ0U50I_14 = __slot_BbKBgKsMCruPMx5IZ0U50I;
                __auto_13 = __pad_BbKBgKsMCruPMx5IZ0U50I_14;
            }
            else
            {
                __auto_13 = default(n8.TextureOptions);
            }

            Output_Out = __auto_10;
            Options_Out = __auto_13;
            return;
        }

        [n1.ElementAttribute(TracingId = 116006U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "TBsnc30a3R6ObAeNqWhmn3", Name = "__slot_TBsnc30a3R6ObAeNqWhmn3")]
        public static n8.TextureFlags __slot_TBsnc30a3R6ObAeNqWhmn3 = n1.CompilationHelper.Deserialize<n8.TextureFlags>("ShaderResource", false, "Dky5PMnuvcKN4CxmfNs7Uv", "TBsnc30a3R6ObAeNqWhmn3");
        [n1.ElementAttribute(TracingId = 115998U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GjkQDtXH9tcOX2C71bZkjY", Name = "__slot_GjkQDtXH9tcOX2C71bZkjY")]
        public static n8.TextureFlags __slot_GjkQDtXH9tcOX2C71bZkjY = n1.CompilationHelper.Deserialize<n8.TextureFlags>("UnorderedAccess", false, "Dky5PMnuvcKN4CxmfNs7Uv", "GjkQDtXH9tcOX2C71bZkjY");
        [n1.ElementAttribute(TracingId = 116036U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QwEFCAIgUnGMPOhQtXm5Sy", Name = "__slot_QwEFCAIgUnGMPOhQtXm5Sy")]
        public static n8.TextureFlags __slot_QwEFCAIgUnGMPOhQtXm5Sy = n1.CompilationHelper.Deserialize<n8.TextureFlags>("RenderTarget", false, "Dky5PMnuvcKN4CxmfNs7Uv", "QwEFCAIgUnGMPOhQtXm5Sy");
        [n1.ElementAttribute(TracingId = 116073U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Md3hdJcao6GQCTeV1nHoGj", Name = "__slot_Md3hdJcao6GQCTeV1nHoGj")]
        public static n8.TextureFlags __slot_Md3hdJcao6GQCTeV1nHoGj = n1.CompilationHelper.Deserialize<n8.TextureFlags>("DepthStencil", false, "Dky5PMnuvcKN4CxmfNs7Uv", "Md3hdJcao6GQCTeV1nHoGj");
        [n1.ElementAttribute(TracingId = 116192U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BbKBgKsMCruPMx5IZ0U50I", Name = "__slot_BbKBgKsMCruPMx5IZ0U50I")]
        public static n8.TextureOptions __slot_BbKBgKsMCruPMx5IZ0U50I = n1.CompilationHelper.Deserialize<n8.TextureOptions>("Shared", false, "Dky5PMnuvcKN4CxmfNs7Uv", "BbKBgKsMCruPMx5IZ0U50I");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Graphics_.Video
{
    [n1.ElementAttribute(TracingId = 118250U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FqmXvulEPFmO2GIAyZs14F", Name = "ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F")]
    [n2.SerializableAttribute]
    public class ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F Create(n1.NodeContext Node_Context)
        {
            var instance = new ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F CreateDefault()
        {
            var instance = new ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F Update([n4.SerializedDefaultValueAttribute("..\\..\\..\\..\\..\\..\\_vvvv\\vvvv_gamma_2021.3.0-0031-geaf1d21c5d\\lib\\packs\\VL.Stride.Runtime.0.9.49-g80160751fb\\stride\\Resources\\Textures\\", false)] n36.Path Directory_In, [n4.SerializedDefaultValueAttribute("*.*", false)] string Search_Pattern_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Rescan_Directory_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, n8.Texture Default_In, int Frame_to_Display_In, int Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Loop_To_In, n11.IEnumerable<int> Seek_Frames_In, [n4.SerializedDefaultValueAttribute("0", false)] int Frame_Step_Descending_In, [n4.SerializedDefaultValueAttribute("1", false)] int Frame_Step_Ascending_In, [n4.SerializedDefaultValueAttribute("2", false)] int Preload_Count_In, out n8.Texture Output_Out, out bool On_Scanning_Complete_Out, out int Frame_Count_Out, out n26.Spread<int> Preloaded_Frames_Out)
        {
            var Output_2 = this.__p_L8CRigONqdkLYx0NLQgXww.Update(Value_In: Directory_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var Output_5 = this.__p_IzgRvXeF7ulPogsvk6DDnA.Update(Value_In: Search_Pattern_In, Result_Out: out bool Result_3, Unchanged_Out: out bool Unchanged_4);
            var State_Output_7 = this.__p_FnTEA68bPSBPsx7EHJsGmr.Update(Simulate_In: Rescan_Directory_In, Output_Out: out bool Output_6);
            var Output_8 = Result_0 || Result_3;
            var Output_9 = Output_8 || Output_6;
            bool Abort_10 = false;
            var __fallback___11 = n1.ServiceRegistry.Current;
            n51._Operations_.Update_H<n26.Spread<n36.Path>, n2.Object>(Input_In: this.__p_I4Trc2kkdQOQNQXc9lwtBC, Trigger_In: Output_9, Abort_In: Abort_10, Update_In: (n2.Object s_14, n48.CancellationToken Input_1_In_15) =>
            {
                using var __current_12 = __fallback___11.MakeCurrentIfNone();
                var state_13 = n1.CompilationHelper.Restore<__GlxiFkQwvBOLVNrc1aat48>(s_14, __GetContext__());
                bool __pad_HAM58qXz422NiuFrgAxrlS_16 = __slot_HAM58qXz422NiuFrgAxrlS;
                bool Include_Subdirectories_17 = false;
                bool Include_Hidden_18 = false;
                var Output_20 = state_13.__p_JYBVw2bUN2vNLPCj7a1W7Q.Update(Directory_In: Directory_In, Search_Pattern_In: Search_Pattern_In, Include_Subdirectories_In: Include_Subdirectories_17, Include_Hidden_In: Include_Hidden_18, Refresh_In: __pad_HAM58qXz422NiuFrgAxrlS_16, Files_Out: out n26.Spread<n36.Path> Files_19);
                if (state_13.__GetContext__().IsImmutable)
                    state_13 = Output_20 != state_13.__p_JYBVw2bUN2vNLPCj7a1W7Q ? new __GlxiFkQwvBOLVNrc1aat48(state_13)
                    {__p_JYBVw2bUN2vNLPCj7a1W7Q = Output_20} : state_13;
                else
                {
                    state_13.__p_JYBVw2bUN2vNLPCj7a1W7Q = Output_20;
                }

                return n2.Tuple.Create<n2.Object, n26.Spread<n36.Path>>(state_13, Files_19);
            }

            , Create_In: () =>
            {
                using var __current_21 = __fallback___11.MakeCurrentIfNone();
                var state_13 = new __GlxiFkQwvBOLVNrc1aat48(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "JYBVw2bUN2vNLPCj7a1W7Q", 118316U);
                var Output_23 = n49.Dir_MpDjcJT8vHtN0yoPM6imee.Create(Node_Context: Node_Context_22);
                state_13.__p_JYBVw2bUN2vNLPCj7a1W7Q = Output_23;
                return state_13;
            }

            , Output_Out: out n50.AsyncTask<n26.Spread<n36.Path>> Output_24, Result_Out: out n2.IObservable<n26.Spread<n36.Path>> Result_25, In_Progress_Out: out bool In_Progress_26);
            bool Reset_27 = false;
            bool Update_28 = true;
            var Output_29 = this.__p_ENhxIQKqPZvOnhZH7Q1flg;
            if (Update_28)
            {
                n52._Operations_.Update_H<n26.Spread<n36.Path>>(Input_In: this.__p_ENhxIQKqPZvOnhZH7Q1flg, Async_Notifications_In: Result_25, Reset_In: Reset_27, Output_Out: out Output_29);
            }

            n52._Operations_.GetData_H<n26.Spread<n36.Path>>(Input_In: Output_29, Output_Out: out n50.HoldLatest<n26.Spread<n36.Path>> Output_30, Value_Out: out n26.Spread<n36.Path> Value_31, On_Data_Out: out bool On_Data_32);
            int Input_2_33 = 0;
            var Result_34 = Loop_To_In >= Input_2_33;
            int Index_35 = n2.Convert.ToInt32(Result_34);
            n37._Operations_.Count<n36.Path>(Input_In: Value_31, Count_Out: out int Count_36);
            var Output_37 = n53.Integer32Extensions.Dec(input: Count_36);
            var builder_38 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z, 2);
            builder_38.Add(Output_37);
            builder_38.Add(Loop_To_In);
            var __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z_39 = builder_38.Commit();
            n21._Operations_.Switch<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Index_In: Index_35, Input_In: __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z_39, Output_Out: out int Output_40);
            n23._Operations_.Wrap<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Frame_to_Display_In, Minimum_In: Loop_From_In, Maximum_In: Output_40, Output_Out: out int Output_41);
            var builder_42 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7, 1);
            builder_42.Add(Output_41);
            var __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7_43 = builder_42.Commit();
            n37._Operations_.FromValue<int>(Input_In: __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7_43, Result_Out: out n26.Spread<int> Result_44);
            n11.IEnumerable<int> Input_45 = (n11.IEnumerable<int>)Result_44;
            n54._Operations_.PreloadIds(Input_In: Output_41, Preload_Count_In: Preload_Count_In, Frame_Step_Descending_In: Frame_Step_Descending_In, Minimum_In: Loop_From_In, Maximum_In: Output_40, Frame_Step_Ascending_In: Frame_Step_Ascending_In, Output_Out: out n11.IEnumerable<int> Output_46);
            bool Force_47 = false;
            bool Dispose_Cached_Outputs_48 = false;
            var manager_49 = this.__cache_BQWo8FIDkMPOWERXPHIxwP;
            if (manager_49 is null)
            {
                manager_49 = new n6.Manager<n2.ValueTuple<n11.IEnumerable<int>, int, int, int>, n2.ValueTuple<n26.Spread<int>>>(n2.ValueTuple.Create(n37._Operations_.CreateDefault<int>()));
            }

            var inputs_50 = (Seek_Frames_In, Preload_Count_In, Frame_Step_Descending_In, Frame_Step_Ascending_In);
            var outputs_51 = manager_49.Outputs;
            var Has_Changed_52 = Force_47 || manager_49.InputsChanged(inputs_50);
            if (Has_Changed_52)
            {
                if (Dispose_Cached_Outputs_48)
                    manager_49.DisposeOutputs();
                var state_53 = n1.CompilationHelper.Restore<__RX2WzSdBcz9LHAOSzMRYMz>(manager_49.State, __GetContext__());
                if (state_53 == null)
                {
                    state_53 = new __RX2WzSdBcz9LHAOSzMRYMz(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_Kz0lbhukznnMymlyi06xB2 = n37._Operations_.CreateDefault<n11.IEnumerable<int>>()};
                }

                var Output_54 = n53.Integer32Extensions.Dec(input: Preload_Count_In);
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_53.__cp_Kz0lbhukznnMymlyi06xB2, 16);
                n26.Spread<n11.IEnumerable<int>> output_62;
                try
                {
                    var i_57 = 0;
                    foreach (var item_55 in Seek_Frames_In)
                    {
                        var splicer_56 = item_55;
                        var i_local_58 = i_57;
                        n54._Operations_.PreloadIds(Input_In: splicer_56, Preload_Count_In: Output_54, Frame_Step_Descending_In: Frame_Step_Descending_In, Minimum_In: Loop_From_In, Maximum_In: Output_40, Frame_Step_Ascending_In: Frame_Step_Ascending_In, Output_Out: out n11.IEnumerable<int> Output_60);
                        builder_61.Add(Output_60);
                        i_57++;
                    }
                }
                finally
                {
                    output_62 = builder_61.Commit();
                }

                n37._Operations_.Flatten<n26.Spread<n11.IEnumerable<int>>, int>(Input_In: output_62, Output_Out: out n26.Spread<int> Output_63);
                if (state_53.__GetContext__().IsImmutable)
                    state_53 = output_62 != state_53.__cp_Kz0lbhukznnMymlyi06xB2 ? new __RX2WzSdBcz9LHAOSzMRYMz(state_53)
                    {__cp_Kz0lbhukznnMymlyi06xB2 = output_62} : state_53;
                else
                {
                    state_53.__cp_Kz0lbhukznnMymlyi06xB2 = output_62;
                }

                outputs_51 = n2.ValueTuple.Create(Output_63);
                manager_49 = manager_49.Update(inputs_50, __GetContext__().IsImmutable, Dispose_Cached_Outputs_48, state_53, outputs_51);
            }
            else
            {
                manager_49.Update(inputs_50, __GetContext__().IsImmutable, Dispose_Cached_Outputs_48);
            }

            var __auto_64 = outputs_51.Item1;
            n11.IEnumerable<int> Input_4_65 = (n11.IEnumerable<int>)__auto_64;
            var builder_66 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7, 4);
            builder_66.Add(Input_45);
            builder_66.Add(Output_46);
            builder_66.Add(Seek_Frames_In);
            builder_66.Add(Input_4_65);
            var __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7_67 = builder_66.Commit();
            n37._Operations_.Concat<int>(Input_In: __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7_67, Output_Out: out n26.Spread<int> Output_68);
            n37._Operations_.Distinct<int>(Input_In: Output_68, Output_Out: out n26.Spread<int> Output_69);
            var manager_81 = this.__loop_UJ60QAKi0gvPkG03AF4R6j ?? new n55.ImmutableLifetimeManager();
            var iterator_82 = manager_81.GetIterator(__GetContext__());
            var builder_83 = n4.CollectionBuilders.GetBuilder(this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG, 16);
            n26.Spread<n8.Texture> output_84;
            var builder_85 = n4.CollectionBuilders.GetBuilder(this.__cp_TqjScqnZFDMM34LTkKc5Kf, 16);
            n26.Spread<int> output_86;
            try
            {
                var i_72 = 0;
                foreach (var item_70 in n4.CollectionExtensions.AsSpan(Output_69))
                {
                    var splicer_71 = item_70;
                    var i_local_73 = i_72;
                    __KaWsydn8UKjMUNGa9sT6DG state_74;
                    if (!iterator_82.MoveNext(out state_74))
                    {
                        iterator_82.Add(state_74 = new __KaWsydn8UKjMUNGa9sT6DG(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_75 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "MVTtTJo1AFYOqugiTTrUDI", 118391U);
                        var Output_76 = n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y.Create(Node_Context: Node_Context_75);
                        state_74.__p_MVTtTJo1AFYOqugiTTrUDI = Output_76;
                    }

                    n36.Path Default_Value_77 = n49._Operations_.CreateDefault();
                    n37._Operations_.GetSlice<n36.Path>(Input_In: Value_31, Default_Value_In: Default_Value_77, Index_In: splicer_71, Result_Out: out n36.Path Result_78);
                    var State_Output_80 = state_74.__p_MVTtTJo1AFYOqugiTTrUDI.Update(File_Path_In: Result_78, Is_sRGB_In: Is_sRGB_In, Default_In: Default_In, Output_Out: out n8.Texture Output_79);
                    if (state_74.__GetContext__().IsImmutable)
                        state_74 = State_Output_80 != state_74.__p_MVTtTJo1AFYOqugiTTrUDI ? new __KaWsydn8UKjMUNGa9sT6DG(state_74)
                        {__p_MVTtTJo1AFYOqugiTTrUDI = State_Output_80} : state_74;
                    else
                    {
                        state_74.__p_MVTtTJo1AFYOqugiTTrUDI = State_Output_80;
                    }

                    iterator_82.Update(state_74);
                    builder_83.Add(Output_79);
                    builder_85.Add(splicer_71);
                    i_72++;
                }
            }
            finally
            {
                manager_81 = iterator_82.Commit();
                output_84 = builder_83.Commit();
                output_86 = builder_85.Commit();
            }

            n8.Texture Default_Value_87 = default(n8.Texture);
            n56._Operations_.FirstOrDefault<n26.Spread<n8.Texture>, n8.Texture>(Input_In: output_84, Default_Value_In: Default_Value_87, Output_Out: out n26.Spread<n8.Texture> Output_88, Result_Out: out n8.Texture Result_89);
            Output_Out = Result_89;
            On_Scanning_Complete_Out = On_Data_32;
            Frame_Count_Out = Count_36;
            Preloaded_Frames_Out = output_86;
            n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F that_90 = this;
            if (this.__GetContext__().IsImmutable)
                that_90 = Output_2 != this.__p_L8CRigONqdkLYx0NLQgXww || Output_5 != this.__p_IzgRvXeF7ulPogsvk6DDnA || State_Output_7 != this.__p_FnTEA68bPSBPsx7EHJsGmr || Output_24 != this.__p_I4Trc2kkdQOQNQXc9lwtBC || Output_30 != this.__p_ENhxIQKqPZvOnhZH7Q1flg || __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z_39 != this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z || __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7_43 != this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 || manager_49 != this.__cache_BQWo8FIDkMPOWERXPHIxwP || __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7_67 != this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 || manager_81 != this.__loop_UJ60QAKi0gvPkG03AF4R6j || output_84 != this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG || output_86 != this.__cp_TqjScqnZFDMM34LTkKc5Kf ? new ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(this)
                {__p_L8CRigONqdkLYx0NLQgXww = Output_2, __p_IzgRvXeF7ulPogsvk6DDnA = Output_5, __p_FnTEA68bPSBPsx7EHJsGmr = State_Output_7, __p_I4Trc2kkdQOQNQXc9lwtBC = Output_24, __p_ENhxIQKqPZvOnhZH7Q1flg = Output_30, __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z_39, __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7_43, __cache_BQWo8FIDkMPOWERXPHIxwP = manager_49, __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7_67, __loop_UJ60QAKi0gvPkG03AF4R6j = manager_81, __cp_Lx7GCNqbNq8PP3Zf4tW6wG = output_84, __cp_TqjScqnZFDMM34LTkKc5Kf = output_86} : that_90;
            else
            {
                this.__p_L8CRigONqdkLYx0NLQgXww = Output_2;
                this.__p_IzgRvXeF7ulPogsvk6DDnA = Output_5;
                this.__p_FnTEA68bPSBPsx7EHJsGmr = State_Output_7;
                this.__p_I4Trc2kkdQOQNQXc9lwtBC = Output_24;
                this.__p_ENhxIQKqPZvOnhZH7Q1flg = Output_30;
                this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z_39;
                this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7_43;
                this.__cache_BQWo8FIDkMPOWERXPHIxwP = manager_49;
                this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7_67;
                this.__loop_UJ60QAKi0gvPkG03AF4R6j = manager_81;
                this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG = output_84;
                this.__cp_TqjScqnZFDMM34LTkKc5Kf = output_86;
            }

            return that_90;
        }

        public n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "FnTEA68bPSBPsx7EHJsGmr", 118255U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "L8CRigONqdkLYx0NLQgXww", 118270U);
            bool Changed_On_Create_3 = true;
            var Output_4 = n21.Changed_A8JGbead2bxNdnPybiEqVS<n36.Path>.Create<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Node_Context: Node_Context_2, Changed_On_Create_In: Changed_On_Create_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "I4Trc2kkdQOQNQXc9lwtBC", 118287U);
            n51._Operations_.Create_H<n26.Spread<n36.Path>>(Node_Context: Node_Context_5, Output_Out: out n50.AsyncTask<n26.Spread<n36.Path>> Output_6);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "IzgRvXeF7ulPogsvk6DDnA", 118343U);
            bool Changed_On_Create_8 = true;
            var Output_9 = n21.Changed_A8JGbead2bxNdnPybiEqVS<string>.Create<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Node_Context: Node_Context_7, Changed_On_Create_In: Changed_On_Create_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "ENhxIQKqPZvOnhZH7Q1flg", 118350U);
            n26.Spread<n36.Path> Initial_Result_11 = n37._Operations_.CreateDefault<n36.Path>();
            n52._Operations_.Create_H<n26.Spread<n36.Path>>(Node_Context: Node_Context_10, Initial_Result_In: Initial_Result_11, Output_Out: out n50.HoldLatest<n26.Spread<n36.Path>> Output_12);
            n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F that_13 = this;
            this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = n37._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = n37._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = n37._Operations_.CreateDefault<n11.IEnumerable<int>>();
            this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG = n37._Operations_.CreateDefault<n8.Texture>();
            this.__cp_TqjScqnZFDMM34LTkKc5Kf = n37._Operations_.CreateDefault<int>();
            this.__p_FnTEA68bPSBPsx7EHJsGmr = Output_1;
            this.__p_L8CRigONqdkLYx0NLQgXww = Output_4;
            this.__p_I4Trc2kkdQOQNQXc9lwtBC = Output_6;
            this.__p_IzgRvXeF7ulPogsvk6DDnA = Output_9;
            this.__p_ENhxIQKqPZvOnhZH7Q1flg = Output_12;
            this.__cache_BQWo8FIDkMPOWERXPHIxwP = null;
            this.__loop_UJ60QAKi0gvPkG03AF4R6j = default(n55.ImmutableLifetimeManager);
            return that_13;
        }

        public n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F __CreateDefault__()
        {
            n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F that_0 = this;
            this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = n37._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = n37._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = n37._Operations_.CreateDefault<n11.IEnumerable<int>>();
            this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG = n37._Operations_.CreateDefault<n8.Texture>();
            this.__cp_TqjScqnZFDMM34LTkKc5Kf = n37._Operations_.CreateDefault<int>();
            this.__p_L8CRigONqdkLYx0NLQgXww = n21.Changed_A8JGbead2bxNdnPybiEqVS<n36.Path>.CreateDefault<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>();
            this.__p_IzgRvXeF7ulPogsvk6DDnA = n21.Changed_A8JGbead2bxNdnPybiEqVS<string>.CreateDefault<n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>();
            this.__p_FnTEA68bPSBPsx7EHJsGmr = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_I4Trc2kkdQOQNQXc9lwtBC = default(n50.AsyncTask<n26.Spread<n36.Path>>);
            this.__p_ENhxIQKqPZvOnhZH7Q1flg = default(n50.HoldLatest<n26.Spread<n36.Path>>);
            this.__cache_BQWo8FIDkMPOWERXPHIxwP = null;
            this.__loop_UJ60QAKi0gvPkG03AF4R6j = default(n55.ImmutableLifetimeManager);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_L8CRigONqdkLYx0NLQgXww);
            n1.CompilationHelper.SafeDispose(this.__p_IzgRvXeF7ulPogsvk6DDnA);
            n1.CompilationHelper.SafeDispose(this.__p_FnTEA68bPSBPsx7EHJsGmr);
            n1.CompilationHelper.SafeDispose(this.__p_I4Trc2kkdQOQNQXc9lwtBC);
            n1.CompilationHelper.SafeDispose(this.__p_ENhxIQKqPZvOnhZH7Q1flg);
            n1.CompilationHelper.SafeDispose(this.__cache_BQWo8FIDkMPOWERXPHIxwP);
            n1.CompilationHelper.SafeDispose(this.__loop_UJ60QAKi0gvPkG03AF4R6j);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 118270U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "L8CRigONqdkLYx0NLQgXww", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<n36.Path> __p_L8CRigONqdkLYx0NLQgXww;
        [n1.ElementAttribute(TracingId = 118343U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IzgRvXeF7ulPogsvk6DDnA", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_IzgRvXeF7ulPogsvk6DDnA;
        [n1.ElementAttribute(TracingId = 118255U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FnTEA68bPSBPsx7EHJsGmr", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_FnTEA68bPSBPsx7EHJsGmr;
        [n1.ElementAttribute(TracingId = 118287U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "I4Trc2kkdQOQNQXc9lwtBC", Name = "AsyncTask", IsManaged = true, IsAutoGenerated = true)]
        public n50.AsyncTask<n26.Spread<n36.Path>> __p_I4Trc2kkdQOQNQXc9lwtBC;
        [n1.ElementAttribute(TracingId = 118332U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HAM58qXz422NiuFrgAxrlS", Name = "__slot_HAM58qXz422NiuFrgAxrlS")]
        public static bool __slot_HAM58qXz422NiuFrgAxrlS = true;
        [n1.ElementAttribute(TracingId = 118350U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "ENhxIQKqPZvOnhZH7Q1flg", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n50.HoldLatest<n26.Spread<n36.Path>> __p_ENhxIQKqPZvOnhZH7Q1flg;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n26.Spread<int> __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = default(n26.Spread<int>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n26.Spread<int> __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = default(n26.Spread<int>);
        [n1.ElementAttribute(TracingId = 118695U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "BQWo8FIDkMPOWERXPHIxwP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n11.IEnumerable<int>, int, int, int>, n2.ValueTuple<n26.Spread<int>>> __cache_BQWo8FIDkMPOWERXPHIxwP = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n26.Spread<n11.IEnumerable<int>> __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = default(n26.Spread<n11.IEnumerable<int>>);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n55.ImmutableLifetimeManager __loop_UJ60QAKi0gvPkG03AF4R6j;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n26.Spread<n8.Texture> __cp_Lx7GCNqbNq8PP3Zf4tW6wG;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n26.Spread<int> __cp_TqjScqnZFDMM34LTkKc5Kf;
        static ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F()
        {
        }

        public ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F other): base(other)
        {
            this.__p_L8CRigONqdkLYx0NLQgXww = other.__p_L8CRigONqdkLYx0NLQgXww;
            this.__p_IzgRvXeF7ulPogsvk6DDnA = other.__p_IzgRvXeF7ulPogsvk6DDnA;
            this.__p_FnTEA68bPSBPsx7EHJsGmr = other.__p_FnTEA68bPSBPsx7EHJsGmr;
            this.__p_I4Trc2kkdQOQNQXc9lwtBC = other.__p_I4Trc2kkdQOQNQXc9lwtBC;
            this.__p_ENhxIQKqPZvOnhZH7Q1flg = other.__p_ENhxIQKqPZvOnhZH7Q1flg;
            this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = other.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z;
            this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = other.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7;
            this.__cache_BQWo8FIDkMPOWERXPHIxwP = other.__cache_BQWo8FIDkMPOWERXPHIxwP;
            this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = other.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7;
            this.__loop_UJ60QAKi0gvPkG03AF4R6j = other.__loop_UJ60QAKi0gvPkG03AF4R6j;
            this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG = other.__cp_Lx7GCNqbNq8PP3Zf4tW6wG;
            this.__cp_TqjScqnZFDMM34LTkKc5Kf = other.__cp_TqjScqnZFDMM34LTkKc5Kf;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_L8CRigONqdkLYx0NLQgXww", in __p_L8CRigONqdkLYx0NLQgXww), n1.CompilationHelper.GetValueOrExisting(values, "__p_IzgRvXeF7ulPogsvk6DDnA", in __p_IzgRvXeF7ulPogsvk6DDnA), n1.CompilationHelper.GetValueOrExisting(values, "__p_FnTEA68bPSBPsx7EHJsGmr", in __p_FnTEA68bPSBPsx7EHJsGmr), n1.CompilationHelper.GetValueOrExisting(values, "__p_I4Trc2kkdQOQNQXc9lwtBC", in __p_I4Trc2kkdQOQNQXc9lwtBC), n1.CompilationHelper.GetValueOrExisting(values, "__p_ENhxIQKqPZvOnhZH7Q1flg", in __p_ENhxIQKqPZvOnhZH7Q1flg), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z", in __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7", in __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7), n1.CompilationHelper.GetValueOrExisting(values, "__cache_BQWo8FIDkMPOWERXPHIxwP", in __cache_BQWo8FIDkMPOWERXPHIxwP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7", in __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7), n1.CompilationHelper.GetValueOrExisting(values, "__loop_UJ60QAKi0gvPkG03AF4R6j", in __loop_UJ60QAKi0gvPkG03AF4R6j), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Lx7GCNqbNq8PP3Zf4tW6wG", in __cp_Lx7GCNqbNq8PP3Zf4tW6wG), n1.CompilationHelper.GetValueOrExisting(values, "__cp_TqjScqnZFDMM34LTkKc5Kf", in __cp_TqjScqnZFDMM34LTkKc5Kf));
        }

        internal ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F __WITH__(n21.Changed_A8JGbead2bxNdnPybiEqVS<n36.Path> __p_L8CRigONqdkLYx0NLQgXww, n21.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_IzgRvXeF7ulPogsvk6DDnA, n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_FnTEA68bPSBPsx7EHJsGmr, n50.AsyncTask<n26.Spread<n36.Path>> __p_I4Trc2kkdQOQNQXc9lwtBC, n50.HoldLatest<n26.Spread<n36.Path>> __p_ENhxIQKqPZvOnhZH7Q1flg, n26.Spread<int> __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z, n26.Spread<int> __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7, n6.Manager<n2.ValueTuple<n11.IEnumerable<int>, int, int, int>, n2.ValueTuple<n26.Spread<int>>> __cache_BQWo8FIDkMPOWERXPHIxwP, n26.Spread<n11.IEnumerable<int>> __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7, n55.ImmutableLifetimeManager __loop_UJ60QAKi0gvPkG03AF4R6j, n26.Spread<n8.Texture> __cp_Lx7GCNqbNq8PP3Zf4tW6wG, n26.Spread<int> __cp_TqjScqnZFDMM34LTkKc5Kf)
        {
            n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_L8CRigONqdkLYx0NLQgXww != this.__p_L8CRigONqdkLYx0NLQgXww || __p_IzgRvXeF7ulPogsvk6DDnA != this.__p_IzgRvXeF7ulPogsvk6DDnA || __p_FnTEA68bPSBPsx7EHJsGmr != this.__p_FnTEA68bPSBPsx7EHJsGmr || __p_I4Trc2kkdQOQNQXc9lwtBC != this.__p_I4Trc2kkdQOQNQXc9lwtBC || __p_ENhxIQKqPZvOnhZH7Q1flg != this.__p_ENhxIQKqPZvOnhZH7Q1flg || __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z != this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z || __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 != this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 || __cache_BQWo8FIDkMPOWERXPHIxwP != this.__cache_BQWo8FIDkMPOWERXPHIxwP || __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 != this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 || __loop_UJ60QAKi0gvPkG03AF4R6j != this.__loop_UJ60QAKi0gvPkG03AF4R6j || __cp_Lx7GCNqbNq8PP3Zf4tW6wG != this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG || __cp_TqjScqnZFDMM34LTkKc5Kf != this.__cp_TqjScqnZFDMM34LTkKc5Kf ? new ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F(this)
                {__p_L8CRigONqdkLYx0NLQgXww = __p_L8CRigONqdkLYx0NLQgXww, __p_IzgRvXeF7ulPogsvk6DDnA = __p_IzgRvXeF7ulPogsvk6DDnA, __p_FnTEA68bPSBPsx7EHJsGmr = __p_FnTEA68bPSBPsx7EHJsGmr, __p_I4Trc2kkdQOQNQXc9lwtBC = __p_I4Trc2kkdQOQNQXc9lwtBC, __p_ENhxIQKqPZvOnhZH7Q1flg = __p_ENhxIQKqPZvOnhZH7Q1flg, __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z, __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7, __cache_BQWo8FIDkMPOWERXPHIxwP = __cache_BQWo8FIDkMPOWERXPHIxwP, __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7, __loop_UJ60QAKi0gvPkG03AF4R6j = __loop_UJ60QAKi0gvPkG03AF4R6j, __cp_Lx7GCNqbNq8PP3Zf4tW6wG = __cp_Lx7GCNqbNq8PP3Zf4tW6wG, __cp_TqjScqnZFDMM34LTkKc5Kf = __cp_TqjScqnZFDMM34LTkKc5Kf} : that_0;
            else
            {
                this.__p_L8CRigONqdkLYx0NLQgXww = __p_L8CRigONqdkLYx0NLQgXww;
                this.__p_IzgRvXeF7ulPogsvk6DDnA = __p_IzgRvXeF7ulPogsvk6DDnA;
                this.__p_FnTEA68bPSBPsx7EHJsGmr = __p_FnTEA68bPSBPsx7EHJsGmr;
                this.__p_I4Trc2kkdQOQNQXc9lwtBC = __p_I4Trc2kkdQOQNQXc9lwtBC;
                this.__p_ENhxIQKqPZvOnhZH7Q1flg = __p_ENhxIQKqPZvOnhZH7Q1flg;
                this.__pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z = __pin_group_Input_In_AGd4J5Urqz3M7g8olouy4Z;
                this.__pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7 = __pin_group_Input_In_Pz7cIMzdvPoOIG1Ha1ySL7;
                this.__cache_BQWo8FIDkMPOWERXPHIxwP = __cache_BQWo8FIDkMPOWERXPHIxwP;
                this.__pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7 = __pin_group_Input_In_BM9x9KcoJt5P0yoS8gwUQ7;
                this.__loop_UJ60QAKi0gvPkG03AF4R6j = __loop_UJ60QAKi0gvPkG03AF4R6j;
                this.__cp_Lx7GCNqbNq8PP3Zf4tW6wG = __cp_Lx7GCNqbNq8PP3Zf4tW6wG;
                this.__cp_TqjScqnZFDMM34LTkKc5Kf = __cp_TqjScqnZFDMM34LTkKc5Kf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "GlxiFkQwvBOLVNrc1aat48", Name = "__GlxiFkQwvBOLVNrc1aat48")]
        [n2.SerializableAttribute]
        public class __GlxiFkQwvBOLVNrc1aat48 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JYBVw2bUN2vNLPCj7a1W7Q);
                return;
            }

            [n1.ElementAttribute(TracingId = 118316U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JYBVw2bUN2vNLPCj7a1W7Q", Name = "Dir", IsManaged = true, IsAutoGenerated = true)]
            public n49.Dir_MpDjcJT8vHtN0yoPM6imee __p_JYBVw2bUN2vNLPCj7a1W7Q;
            public __GlxiFkQwvBOLVNrc1aat48(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GlxiFkQwvBOLVNrc1aat48(__GlxiFkQwvBOLVNrc1aat48 other): base(other)
            {
                this.__p_JYBVw2bUN2vNLPCj7a1W7Q = other.__p_JYBVw2bUN2vNLPCj7a1W7Q;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JYBVw2bUN2vNLPCj7a1W7Q", in __p_JYBVw2bUN2vNLPCj7a1W7Q));
            }

            internal __GlxiFkQwvBOLVNrc1aat48 __WITH__(n49.Dir_MpDjcJT8vHtN0yoPM6imee __p_JYBVw2bUN2vNLPCj7a1W7Q)
            {
                __GlxiFkQwvBOLVNrc1aat48 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JYBVw2bUN2vNLPCj7a1W7Q != this.__p_JYBVw2bUN2vNLPCj7a1W7Q ? new __GlxiFkQwvBOLVNrc1aat48(this)
                    {__p_JYBVw2bUN2vNLPCj7a1W7Q = __p_JYBVw2bUN2vNLPCj7a1W7Q} : that_0;
                else
                {
                    this.__p_JYBVw2bUN2vNLPCj7a1W7Q = __p_JYBVw2bUN2vNLPCj7a1W7Q;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "RX2WzSdBcz9LHAOSzMRYMz", Name = "__RX2WzSdBcz9LHAOSzMRYMz")]
        [n2.SerializableAttribute]
        public class __RX2WzSdBcz9LHAOSzMRYMz : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n26.Spread<n11.IEnumerable<int>> __cp_Kz0lbhukznnMymlyi06xB2;
            public __RX2WzSdBcz9LHAOSzMRYMz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RX2WzSdBcz9LHAOSzMRYMz(__RX2WzSdBcz9LHAOSzMRYMz other): base(other)
            {
                this.__cp_Kz0lbhukznnMymlyi06xB2 = other.__cp_Kz0lbhukznnMymlyi06xB2;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_Kz0lbhukznnMymlyi06xB2", in __cp_Kz0lbhukznnMymlyi06xB2));
            }

            internal __RX2WzSdBcz9LHAOSzMRYMz __WITH__(n26.Spread<n11.IEnumerable<int>> __cp_Kz0lbhukznnMymlyi06xB2)
            {
                __RX2WzSdBcz9LHAOSzMRYMz that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_Kz0lbhukznnMymlyi06xB2 != this.__cp_Kz0lbhukznnMymlyi06xB2 ? new __RX2WzSdBcz9LHAOSzMRYMz(this)
                    {__cp_Kz0lbhukznnMymlyi06xB2 = __cp_Kz0lbhukznnMymlyi06xB2} : that_0;
                else
                {
                    this.__cp_Kz0lbhukznnMymlyi06xB2 = __cp_Kz0lbhukznnMymlyi06xB2;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KaWsydn8UKjMUNGa9sT6DG", Name = "__KaWsydn8UKjMUNGa9sT6DG")]
        [n2.SerializableAttribute]
        public class __KaWsydn8UKjMUNGa9sT6DG : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MVTtTJo1AFYOqugiTTrUDI);
                return;
            }

            [n1.ElementAttribute(TracingId = 118391U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "MVTtTJo1AFYOqugiTTrUDI", Name = "TextureReader (Async)", IsManaged = true, IsAutoGenerated = true)]
            public n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y __p_MVTtTJo1AFYOqugiTTrUDI;
            public __KaWsydn8UKjMUNGa9sT6DG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KaWsydn8UKjMUNGa9sT6DG(__KaWsydn8UKjMUNGa9sT6DG other): base(other)
            {
                this.__p_MVTtTJo1AFYOqugiTTrUDI = other.__p_MVTtTJo1AFYOqugiTTrUDI;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MVTtTJo1AFYOqugiTTrUDI", in __p_MVTtTJo1AFYOqugiTTrUDI));
            }

            internal __KaWsydn8UKjMUNGa9sT6DG __WITH__(n31.TextureReader_Async_ED1w6KteGIfQbh9SW2Xc4y __p_MVTtTJo1AFYOqugiTTrUDI)
            {
                __KaWsydn8UKjMUNGa9sT6DG that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MVTtTJo1AFYOqugiTTrUDI != this.__p_MVTtTJo1AFYOqugiTTrUDI ? new __KaWsydn8UKjMUNGa9sT6DG(this)
                    {__p_MVTtTJo1AFYOqugiTTrUDI = __p_MVTtTJo1AFYOqugiTTrUDI} : that_0;
                else
                {
                    this.__p_MVTtTJo1AFYOqugiTTrUDI = __p_MVTtTJo1AFYOqugiTTrUDI;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 119183U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Rf8zNKbH3rROmWYhlPGRaA", Name = "ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA")]
    [n2.SerializableAttribute]
    public class ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA Create(n1.NodeContext Node_Context, n57.IFrameClock Clock_In)
        {
            var instance = new ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA CreateDefault()
        {
            var instance = new ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA Update([n4.SerializedDefaultValueAttribute("..\\..\\..\\..\\..\\..\\_vvvv\\vvvv_gamma_2021.3.0-0031-geaf1d21c5d\\lib\\packs\\VL.Stride.Runtime.0.9.49-g80160751fb\\stride\\Resources\\Textures\\", false)] n36.Path Directory_In, [n4.SerializedDefaultValueAttribute("*.*", false)] string Search_Pattern_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Rescan_Directory_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, n8.Texture Default_In, [n4.SerializedDefaultValueAttribute("30", false)] float Movie_FPS_In, [n4.SerializedDefaultValueAttribute("60", false)] float Display_FPS_In, [n4.SerializedDefaultValueAttribute("2", false)] int Preload_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] float Rate_In, bool Play_In, bool Seek_In, float Seek_Time_In, bool Loop_In, float Loop_Start_Time_In, [n4.SerializedDefaultValueAttribute("-1", false)] float Loop_End_Time_In, n58.ITimeSync_I Sync_In, out n8.Texture Output_Out, out bool On_Scanning_Complete_Out, out float Position_Out, out float Duration_Out, out int Displayed_Frame_Out, out int Frame_Count_Out, out n26.Spread<int> Preloaded_Frames_Out)
        {
            float __auto_0 = this.Duration;
            float Input_2_1 = 0F;
            var Result_2 = Loop_End_Time_In >= Input_2_1;
            float __auto_3;
            if (Result_2)
            {
                n23._Operations_.Min<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Loop_End_Time_In, Input_2_In: __auto_0, Output_Out: out float Output_5);
                __auto_3 = Output_5;
            }
            else
            {
                __auto_3 = __auto_0;
            }

            n5.ObjectHelpers.IsAssigned(x: Sync_In, result: out bool Result_6, notAssigned: out bool Not_Assigned_7);
            float LS_8;
            float LE_9;
            bool L_10;
            float ST_11;
            bool S_12;
            bool P_13;
            double AT_14;
            float ST2_15;
            float R_16;
            var state_17 = n1.CompilationHelper.Restore<__U13ZescdczrPtN6vthM1aX>(this.__if_Vs04Cqoa7vQQasQhyaohu2, __GetContext__());
            if (Result_6)
            {
                if (state_17 == null)
                {
                    state_17 = new __U13ZescdczrPtN6vthM1aX(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = n37._Operations_.CreateDefault<double>()};
                }

                double __pad_FQVWQ5SqG31OM2m1HZr537_18 = __slot_FQVWQ5SqG31OM2m1HZr537;
                double __pad_Qayjl3Xu93hL3eyUdnNBzM_19 = __slot_Qayjl3Xu93hL3eyUdnNBzM;
                var Output_27 = ((n58.ITimeSync_I)Sync_In).SyncControls(Loop_Start_Time_In: Loop_Start_Time_In, Loop_End_Time_In: __auto_3, Loop_In: Loop_In, Seek_Time_In: Seek_Time_In, Seek_In: Seek_In, Rate_In: Rate_In, Play_In: Play_In, Loop_Start_Time_Out: out float Loop_Start_Time_20, Loop_End_Time_Out: out float Loop_End_Time_21, Loop_Out: out bool Loop_22, Seek_Time_Out: out float Seek_Time_23, Seek_Out: out bool Seek_24, Rate_Out: out float Rate_25, Play_Out: out bool Play_26);
                var Output_31 = ((n58.ITimeSync_I)Output_27).UpdateSync(Seek_Time_Out: out float Seek_Time_28, Seek_Out: out bool Seek_29, Adjust_Time_Out: out double Adjust_Time_30);
                LS_8 = Loop_Start_Time_20;
                LE_9 = Loop_End_Time_21;
                L_10 = Loop_22;
                n19._Operations_.Switch_Boolean<float>(Condition_In: Seek_24, Input_In: Seek_Time_28, Input_2_In: Seek_Time_23, Output_Out: out float Output_32);
                ST_11 = Output_32;
                var Output_33 = Seek_29 && Play_26;
                var Output_34 = Output_33 || Seek_24;
                P_13 = Play_26;
                int Index_35 = n2.Convert.ToInt32(Play_26);
                double Input_36 = 0;
                var builder_37 = n4.CollectionBuilders.GetBuilder(state_17.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo, 2);
                builder_37.Add(Input_36);
                builder_37.Add(Adjust_Time_30);
                var __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo_38 = builder_37.Commit();
                n21._Operations_.Switch<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Index_In: Index_35, Input_In: __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo_38, Output_Out: out double Output_39);
                n23._Operations_.Clamp<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_39, Minimum_In: __pad_FQVWQ5SqG31OM2m1HZr537_18, Maximum_In: __pad_Qayjl3Xu93hL3eyUdnNBzM_19, Output_Out: out double Output_40);
                AT_14 = Output_40;
                S_12 = Output_34;
                ST2_15 = Seek_Time_23;
                R_16 = Rate_25;
                if (state_17.__GetContext__().IsImmutable)
                    state_17 = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo_38 != state_17.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo ? new __U13ZescdczrPtN6vthM1aX(state_17)
                    {__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo_38} : state_17;
                else
                {
                    state_17.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo_38;
                }
            }
            else
            {
                LS_8 = Loop_Start_Time_In;
                LE_9 = __auto_3;
                L_10 = Loop_In;
                ST_11 = Seek_Time_In;
                S_12 = Seek_In;
                P_13 = Play_In;
                AT_14 = 0;
                ST2_15 = 0F;
                R_16 = Rate_In;
            }

            bool SetTime_41 = true;
            var Output_42 = this.__p_AOMLpPUFwXFPgUY82j2HOw;
            if (SetTime_41)
            {
                Output_42 = this.__p_AOMLpPUFwXFPgUY82j2HOw.SetTime(Seek_Time_In: ST_11, Seek_In: S_12);
            }

            var Output_44 = Output_42.Step(Play_In: P_13, Loop_In: L_10, Loop_Start_In: LS_8, Loop_End_In: LE_9, Speed_In: R_16, Adjust_Time_In: AT_14, Position_Out: out float Position_43);
            n59._Operations_.ToFrameId<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Position_43, FPS_In: Movie_FPS_In, Result_Out: out int Result_45);
            bool Force_46 = true;
            bool Dispose_Cached_Outputs_47 = false;
            var manager_48 = this.__cache_LWxpVch198rLafbuzVzMyk;
            if (manager_48 is null)
            {
                manager_48 = new n6.Manager<n2.ValueTuple<float, float, float, float, float, float>, n2.ValueTuple<int, int, n26.Spread<int>, int, int>>((0, 0, n37._Operations_.CreateDefault<int>(), 0, 0));
            }

            var inputs_49 = (LS_8, Movie_FPS_In, LE_9, ST2_15, R_16, Display_FPS_In);
            var outputs_50 = manager_48.Outputs;
            var Has_Changed_51 = Force_46 || manager_48.InputsChanged(inputs_49);
            if (Has_Changed_51)
            {
                if (Dispose_Cached_Outputs_47)
                    manager_48.DisposeOutputs();
                var state_52 = n1.CompilationHelper.Restore<__NGjvKmQQXyXNY6bn9CAC47>(manager_48.State, __GetContext__());
                if (state_52 == null)
                {
                    state_52 = new __NGjvKmQQXyXNY6bn9CAC47(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = n37._Operations_.CreateDefault<int>()};
                }

                n59._Operations_.ToFrameId<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: LS_8, FPS_In: Movie_FPS_In, Result_Out: out int Result_53);
                n59._Operations_.ToFrameId<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: ST2_15, FPS_In: Movie_FPS_In, Result_Out: out int Result_54);
                var builder_55 = n4.CollectionBuilders.GetBuilder(state_52.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg, 1);
                builder_55.Add(Result_54);
                var __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg_56 = builder_55.Commit();
                n37._Operations_.FromValue<int>(Input_In: __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg_56, Result_Out: out n26.Spread<int> Result_57);
                n59._Operations_.ToFrameId<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: LE_9, FPS_In: Movie_FPS_In, Result_Out: out int Result_58);
                var Output_59 = (float)Movie_FPS_In / Display_FPS_In;
                var Output_60 = Output_59 * R_16;
                float Input_2_61 = 0F;
                var Result_62 = R_16 < Input_2_61;
                var Result_63 = n53.Float32Extensions.Round(input: Output_60);
                int Input_2_64 = 1;
                n23._Operations_.Max<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Result_63, Input_2_In: Input_2_64, Output_Out: out int Output_65);
                int Default_66 = 0;
                n21._Operations_.SwitchOutput<int>(Condition_In: Result_62, Input_In: Output_65, Default_In: Default_66, True_Out: out int True_67, False_Out: out int False_68);
                if (state_52.__GetContext__().IsImmutable)
                    state_52 = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg_56 != state_52.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg ? new __NGjvKmQQXyXNY6bn9CAC47(state_52)
                    {__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg_56} : state_52;
                else
                {
                    state_52.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg_56;
                }

                outputs_50 = (Result_53, Result_58, Result_57, True_67, False_68);
                manager_48 = manager_48.Update(inputs_49, __GetContext__().IsImmutable, Dispose_Cached_Outputs_47, state_52, outputs_50);
            }
            else
            {
                manager_48.Update(inputs_49, __GetContext__().IsImmutable, Dispose_Cached_Outputs_47);
            }

            var(__auto_69, __auto_70, __auto_71, __auto_72, __auto_73) = outputs_50;
            n11.IEnumerable<int> Seek_Frames_74 = (n11.IEnumerable<int>)__auto_71;
            var State_Output_79 = this.__p_JU6z9w7MVDnOy96k4WzWzA.Update(Directory_In: Directory_In, Search_Pattern_In: Search_Pattern_In, Rescan_Directory_In: Rescan_Directory_In, Is_sRGB_In: Is_sRGB_In, Default_In: Default_In, Frame_to_Display_In: Result_45, Loop_From_In: __auto_69, Loop_To_In: __auto_70, Seek_Frames_In: Seek_Frames_74, Frame_Step_Descending_In: __auto_72, Frame_Step_Ascending_In: __auto_73, Preload_Count_In: Preload_Count_In, Output_Out: out n8.Texture Output_75, On_Scanning_Complete_Out: out bool On_Scanning_Complete_76, Frame_Count_Out: out int Frame_Count_77, Preloaded_Frames_Out: out n26.Spread<int> Preloaded_Frames_78);
            n5.ObjectHelpers.IsAssigned(x: Sync_In, result: out bool Result_80, notAssigned: out bool Not_Assigned_81);
            float Input_82 = (float)Frame_Count_77;
            var Output_83 = (float)Input_82 / Movie_FPS_In;
            float Minimum_84 = 0F;
            n23._Operations_.Wrap<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Position_43, Minimum_In: Minimum_84, Maximum_In: Output_83, Output_Out: out float Output_85);
            double Stream_Position_86 = (double)Output_85;
            if (Result_80)
            {
                var Output_88 = ((n58.ITimeSync_I)Sync_In).SetTimes(Stream_Position_In: Stream_Position_86, Stream_Duration_In: Output_83);
            }

            float __auto_89 = Output_83;
            n58.ITimeSync_I __auto_90 = Sync_In;
            Output_Out = Output_75;
            On_Scanning_Complete_Out = On_Scanning_Complete_76;
            Position_Out = Output_85;
            Duration_Out = Output_83;
            Displayed_Frame_Out = Result_45;
            Frame_Count_Out = Frame_Count_77;
            Preloaded_Frames_Out = Preloaded_Frames_78;
            n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA that_91 = this;
            if (this.__GetContext__().IsImmutable)
                that_91 = state_17 != this.__if_Vs04Cqoa7vQQasQhyaohu2 || Output_44 != this.__p_AOMLpPUFwXFPgUY82j2HOw || manager_48 != this.__cache_LWxpVch198rLafbuzVzMyk || State_Output_79 != this.__p_JU6z9w7MVDnOy96k4WzWzA || Output_83 != this.Duration || Sync_In != this.Sync ? new ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(this)
                {__if_Vs04Cqoa7vQQasQhyaohu2 = state_17, __p_AOMLpPUFwXFPgUY82j2HOw = Output_44, __cache_LWxpVch198rLafbuzVzMyk = manager_48, __p_JU6z9w7MVDnOy96k4WzWzA = State_Output_79, Duration = Output_83, Sync = Sync_In} : that_91;
            else
            {
                this.__if_Vs04Cqoa7vQQasQhyaohu2 = state_17;
                this.__p_AOMLpPUFwXFPgUY82j2HOw = Output_44;
                this.__cache_LWxpVch198rLafbuzVzMyk = manager_48;
                this.__p_JU6z9w7MVDnOy96k4WzWzA = State_Output_79;
                this.Duration = Output_83;
                this.Sync = Sync_In;
            }

            return that_91;
        }

        public n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA SetClock(n57.IFrameClock New_Clock_In)
        {
            n58.ITimeSync_I __auto_0 = this.Sync;
            n5.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            var Output_3 = __auto_0;
            if (Result_1)
            {
                Output_3 = ((n58.ITimeSync_I)__auto_0).SetClock(Frame_Clock_In: New_Clock_In);
            }

            bool SetClock_4 = true;
            var Output_5 = this.__p_AOMLpPUFwXFPgUY82j2HOw;
            if (SetClock_4)
            {
                Output_5 = this.__p_AOMLpPUFwXFPgUY82j2HOw.SetClock(New_Clock_In: New_Clock_In);
            }

            n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_AOMLpPUFwXFPgUY82j2HOw ? new ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(this)
                {__p_AOMLpPUFwXFPgUY82j2HOw = Output_5} : that_6;
            else
            {
                this.__p_AOMLpPUFwXFPgUY82j2HOw = Output_5;
            }

            return that_6;
        }

        public n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA __Create__(n1.NodeContext Node_Context, n57.IFrameClock Clock_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "AOMLpPUFwXFPgUY82j2HOw", 119225U);
            var Output_1 = n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh.Create(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "JU6z9w7MVDnOy96k4WzWzA", 119186U);
            var Output_3 = n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F.Create(Node_Context: Node_Context_2);
            n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA that_4 = this;
            this.Sync = default(n58.ITimeSync_I);
            this.Duration = 0F;
            this.__p_AOMLpPUFwXFPgUY82j2HOw = Output_1;
            this.__p_JU6z9w7MVDnOy96k4WzWzA = Output_3;
            this.__if_Vs04Cqoa7vQQasQhyaohu2 = default(n2.Object);
            this.__cache_LWxpVch198rLafbuzVzMyk = null;
            return that_4;
        }

        public n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA __CreateDefault__()
        {
            n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA that_0 = this;
            this.Sync = default(n58.ITimeSync_I);
            this.Duration = 0F;
            this.__if_Vs04Cqoa7vQQasQhyaohu2 = default(n2.Object);
            this.__p_AOMLpPUFwXFPgUY82j2HOw = n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh.CreateDefault();
            this.__cache_LWxpVch198rLafbuzVzMyk = null;
            this.__p_JU6z9w7MVDnOy96k4WzWzA = n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Vs04Cqoa7vQQasQhyaohu2);
            n1.CompilationHelper.SafeDispose(this.__p_AOMLpPUFwXFPgUY82j2HOw);
            n1.CompilationHelper.SafeDispose(this.__cache_LWxpVch198rLafbuzVzMyk);
            n1.CompilationHelper.SafeDispose(this.__p_JU6z9w7MVDnOy96k4WzWzA);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 120456U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "QDSav0orpiHQEvmr9LGIWu", Name = "__slot_QDSav0orpiHQEvmr9LGIWu")]
        public static string __slot_QDSav0orpiHQEvmr9LGIWu = "< \r\non the server, control parameters are passed through\r\non the clients, they are received from the server (ie inputs are ignored)";
        [n1.ElementAttribute(TracingId = 120467U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FwhzbAKpM3sQKiIX8J68i1", Name = "__slot_FwhzbAKpM3sQKiIX8J68i1")]
        public static string __slot_FwhzbAKpM3sQKiIX8J68i1 = "< throttle time adjustment to decrease the chance of white flashes when starting playback";
        [n1.ElementAttribute(TracingId = 120147U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "C3zbtVNLnU2Ldmx8xQazyJ", Name = "Sync")]
        public n58.ITimeSync_I Sync;
        [n1.ElementAttribute(TracingId = 120152U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AycEZJBlEJJNh6djWYW5UC", Name = "Duration")]
        public float Duration;
        [n1.ElementAttribute(TracingId = 120104U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "FQVWQ5SqG31OM2m1HZr537", Name = "__slot_FQVWQ5SqG31OM2m1HZr537")]
        public static double __slot_FQVWQ5SqG31OM2m1HZr537 = -0.00999999977648258;
        [n1.ElementAttribute(TracingId = 120106U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Qayjl3Xu93hL3eyUdnNBzM", Name = "__slot_Qayjl3Xu93hL3eyUdnNBzM")]
        public static double __slot_Qayjl3Xu93hL3eyUdnNBzM = 0.00999999977648258;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Vs04Cqoa7vQQasQhyaohu2;
        [n1.ElementAttribute(TracingId = 119225U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "AOMLpPUFwXFPgUY82j2HOw", Name = "Playhead2", IsManaged = true, IsAutoGenerated = true)]
        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh __p_AOMLpPUFwXFPgUY82j2HOw;
        [n1.ElementAttribute(TracingId = 120191U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LWxpVch198rLafbuzVzMyk", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<float, float, float, float, float, float>, n2.ValueTuple<int, int, n26.Spread<int>, int, int>> __cache_LWxpVch198rLafbuzVzMyk = null;
        [n1.ElementAttribute(TracingId = 119186U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "JU6z9w7MVDnOy96k4WzWzA", Name = "ImagePlayer (FrameBased Stride)", IsManaged = true, IsAutoGenerated = true)]
        public n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F __p_JU6z9w7MVDnOy96k4WzWzA;
        static ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA()
        {
        }

        public ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA other): base(other)
        {
            this.Sync = other.Sync;
            this.Duration = other.Duration;
            this.__if_Vs04Cqoa7vQQasQhyaohu2 = other.__if_Vs04Cqoa7vQQasQhyaohu2;
            this.__p_AOMLpPUFwXFPgUY82j2HOw = other.__p_AOMLpPUFwXFPgUY82j2HOw;
            this.__cache_LWxpVch198rLafbuzVzMyk = other.__cache_LWxpVch198rLafbuzVzMyk;
            this.__p_JU6z9w7MVDnOy96k4WzWzA = other.__p_JU6z9w7MVDnOy96k4WzWzA;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Sync", in Sync), n1.CompilationHelper.GetValueOrExisting(values, "Duration", in Duration), n1.CompilationHelper.GetValueOrExisting(values, "__if_Vs04Cqoa7vQQasQhyaohu2", in __if_Vs04Cqoa7vQQasQhyaohu2), n1.CompilationHelper.GetValueOrExisting(values, "__p_AOMLpPUFwXFPgUY82j2HOw", in __p_AOMLpPUFwXFPgUY82j2HOw), n1.CompilationHelper.GetValueOrExisting(values, "__cache_LWxpVch198rLafbuzVzMyk", in __cache_LWxpVch198rLafbuzVzMyk), n1.CompilationHelper.GetValueOrExisting(values, "__p_JU6z9w7MVDnOy96k4WzWzA", in __p_JU6z9w7MVDnOy96k4WzWzA));
        }

        internal ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA __WITH__(n58.ITimeSync_I Sync, float Duration, n2.Object __if_Vs04Cqoa7vQQasQhyaohu2, n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh __p_AOMLpPUFwXFPgUY82j2HOw, n6.Manager<n2.ValueTuple<float, float, float, float, float, float>, n2.ValueTuple<int, int, n26.Spread<int>, int, int>> __cache_LWxpVch198rLafbuzVzMyk, n47.ImagePlayer_FrameBased_Stride_FqmXvulEPFmO2GIAyZs14F __p_JU6z9w7MVDnOy96k4WzWzA)
        {
            n47.ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Sync != this.Sync || Duration != this.Duration || __if_Vs04Cqoa7vQQasQhyaohu2 != this.__if_Vs04Cqoa7vQQasQhyaohu2 || __p_AOMLpPUFwXFPgUY82j2HOw != this.__p_AOMLpPUFwXFPgUY82j2HOw || __cache_LWxpVch198rLafbuzVzMyk != this.__cache_LWxpVch198rLafbuzVzMyk || __p_JU6z9w7MVDnOy96k4WzWzA != this.__p_JU6z9w7MVDnOy96k4WzWzA ? new ImagePlayer_Stride_Rf8zNKbH3rROmWYhlPGRaA(this)
                {Sync = Sync, Duration = Duration, __if_Vs04Cqoa7vQQasQhyaohu2 = __if_Vs04Cqoa7vQQasQhyaohu2, __p_AOMLpPUFwXFPgUY82j2HOw = __p_AOMLpPUFwXFPgUY82j2HOw, __cache_LWxpVch198rLafbuzVzMyk = __cache_LWxpVch198rLafbuzVzMyk, __p_JU6z9w7MVDnOy96k4WzWzA = __p_JU6z9w7MVDnOy96k4WzWzA} : that_0;
            else
            {
                this.Sync = Sync;
                this.Duration = Duration;
                this.__if_Vs04Cqoa7vQQasQhyaohu2 = __if_Vs04Cqoa7vQQasQhyaohu2;
                this.__p_AOMLpPUFwXFPgUY82j2HOw = __p_AOMLpPUFwXFPgUY82j2HOw;
                this.__cache_LWxpVch198rLafbuzVzMyk = __cache_LWxpVch198rLafbuzVzMyk;
                this.__p_JU6z9w7MVDnOy96k4WzWzA = __p_JU6z9w7MVDnOy96k4WzWzA;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "U13ZescdczrPtN6vthM1aX", Name = "__U13ZescdczrPtN6vthM1aX")]
        [n2.SerializableAttribute]
        public class __U13ZescdczrPtN6vthM1aX : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n26.Spread<double> __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = default(n26.Spread<double>);
            public __U13ZescdczrPtN6vthM1aX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __U13ZescdczrPtN6vthM1aX(__U13ZescdczrPtN6vthM1aX other): base(other)
            {
                this.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = other.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo", in __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo));
            }

            internal __U13ZescdczrPtN6vthM1aX __WITH__(n26.Spread<double> __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo)
            {
                __U13ZescdczrPtN6vthM1aX that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo != this.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo ? new __U13ZescdczrPtN6vthM1aX(this)
                    {__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo} : that_0;
                else
                {
                    this.__pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo = __pin_group_Input_In_GspVXtYBVHwOAP5zk7I5uo;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NGjvKmQQXyXNY6bn9CAC47", Name = "__NGjvKmQQXyXNY6bn9CAC47")]
        [n2.SerializableAttribute]
        public class __NGjvKmQQXyXNY6bn9CAC47 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n26.Spread<int> __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = default(n26.Spread<int>);
            public __NGjvKmQQXyXNY6bn9CAC47(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NGjvKmQQXyXNY6bn9CAC47(__NGjvKmQQXyXNY6bn9CAC47 other): base(other)
            {
                this.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = other.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg", in __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg));
            }

            internal __NGjvKmQQXyXNY6bn9CAC47 __WITH__(n26.Spread<int> __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg)
            {
                __NGjvKmQQXyXNY6bn9CAC47 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg != this.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg ? new __NGjvKmQQXyXNY6bn9CAC47(this)
                    {__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg} : that_0;
                else
                {
                    this.__pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg = __pin_group_Input_In_RoaeqLhPSeIOSSFcAkMrNg;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Video.ImagePlayer_FrameBased_Stride
{
    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void PreloadIds(int Input_In, int Preload_Count_In, [n4.SerializedDefaultValueAttribute("1", false)] int Frame_Step_Descending_In, int Minimum_In, int Maximum_In, [n4.SerializedDefaultValueAttribute("1", false)] int Frame_Step_Ascending_In, out n11.IEnumerable<int> Output_Out)
        {
            n26.Spread<int> __cp_IZ9FeNdN6fRLNgGpn4w4Av = n37._Operations_.CreateDefault<int>();
            n26.Spread<int> __cp_GQGwBc92twSNjbAMOTjRTq = n37._Operations_.CreateDefault<int>();
            var builder_6 = n4.CollectionBuilders.GetBuilder(__cp_IZ9FeNdN6fRLNgGpn4w4Av, 16);
            n26.Spread<int> output_7;
            try
            {
                for (var i_0 = 0; i_0 < Preload_Count_In; i_0++)
                {
                    var i_local_1 = i_0;
                    var Output_2 = n53.Integer32Extensions.Inc(input: i_local_1);
                    var Output_3 = Output_2 * Frame_Step_Descending_In;
                    var Output_4 = Input_In - Output_3;
                    n23._Operations_.Wrap<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_4, Minimum_In: Minimum_In, Maximum_In: Maximum_In, Output_Out: out int Output_5);
                    builder_6.Add(Output_5);
                }
            }
            finally
            {
                output_7 = builder_6.Commit();
            }

            var builder_14 = n4.CollectionBuilders.GetBuilder(__cp_GQGwBc92twSNjbAMOTjRTq, 16);
            n26.Spread<int> output_15;
            try
            {
                for (var i_8 = 0; i_8 < Preload_Count_In; i_8++)
                {
                    var i_local_9 = i_8;
                    var Output_10 = n53.Integer32Extensions.Inc(input: i_local_9);
                    var Output_11 = Output_10 * Frame_Step_Ascending_In;
                    var Output_12 = Input_In + Output_11;
                    n23._Operations_.Wrap<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_12, Minimum_In: Minimum_In, Maximum_In: Maximum_In, Output_Out: out int Output_13);
                    builder_14.Add(Output_13);
                }
            }
            finally
            {
                output_15 = builder_14.Commit();
            }

            n11.IEnumerable<int> Input_2_16 = (n11.IEnumerable<int>)output_15;
            n11.IEnumerable<int> Input_17 = (n11.IEnumerable<int>)output_7;
            n56._Operations_.Concat<int>(Input_In: Input_17, Input_2_In: Input_2_16, Output_Out: out n11.IEnumerable<int> Output_18);
            Output_Out = Output_18;
            return;
        }
    }
}

namespace _VL_Stride_Graphics_.Video.ImagePlayer_Stride
{
    [n1.ElementAttribute(TracingId = 119530U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Kxyn85uoNljQF5nAzWcnIh", Name = "Playhead2_Kxyn85uoNljQF5nAzWcnIh")]
    [n2.SerializableAttribute]
    public class Playhead2_Kxyn85uoNljQF5nAzWcnIh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh Create(n1.NodeContext Node_Context, n57.IFrameClock Clock_In)
        {
            var instance = new Playhead2_Kxyn85uoNljQF5nAzWcnIh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh CreateDefault()
        {
            var instance = new Playhead2_Kxyn85uoNljQF5nAzWcnIh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh SetTime(float Seek_Time_In, bool Seek_In)
        {
            double __auto_0 = this.Time;
            double __auto_1 = (double)Seek_Time_In;
            if (Seek_In)
            {
            }
            else
            {
                __auto_1 = __auto_0;
            }

            double __auto_3 = __auto_1;
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = __auto_1 != this.Time ? new Playhead2_Kxyn85uoNljQF5nAzWcnIh(this)
                {Time = __auto_1} : that_4;
            else
            {
                this.Time = __auto_1;
            }

            return that_4;
        }

        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh Step(bool Play_In, bool Loop_In, float Loop_Start_In, float Loop_End_In, [n4.SerializedDefaultValueAttribute("1", false)] float Speed_In, double Adjust_Time_In, out float Position_Out)
        {
            double __auto_0 = this.Time;
            n57.IFrameClock __pad_NLPdpcXzbscNnuKS5Hpi0u_1 = this.__slot_NLPdpcXzbscNnuKS5Hpi0u;
            double Input_2 = (double)Speed_In;
            double Output_3;
            if (Play_In)
            {
                var Time_Difference_5 = __pad_NLPdpcXzbscNnuKS5Hpi0u_1.TimeDifference;
                var Output_6 = Input_2 * Time_Difference_5;
                var Output_7 = __auto_0 + Output_6;
                Output_3 = Output_7;
            }
            else
            {
                Output_3 = __auto_0;
            }

            var Output_8 = Output_3 + Adjust_Time_In;
            var Output_9 = !Loop_In;
            double Minimum_10 = (double)Loop_Start_In;
            double Maximum_11 = (double)Loop_End_In;
            double __auto_12;
            if (Output_9)
            {
                n23._Operations_.Clamp<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Output_8, Minimum_In: Minimum_10, Maximum_In: Maximum_11, Output_Out: out double Output_14);
                __auto_12 = Output_14;
            }
            else
            {
                __auto_12 = Output_8;
            }

            double Minimum_15 = (double)Loop_Start_In;
            double Maximum_16 = (double)Loop_End_In;
            double Input_2_17 = (double)Loop_Start_In;
            double __auto_18;
            if (Loop_In)
            {
                float __pad_HIgQjdwKgEBPre8qjxcEFl_20 = __slot_HIgQjdwKgEBPre8qjxcEFl;
                n23._Operations_.Wrap<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: __auto_12, Minimum_In: Minimum_15, Maximum_In: Maximum_16, Output_Out: out double Output_21);
                n60._Operations_.Distance<float, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Loop_Start_In, Input_2_In: Loop_End_In, Result_Out: out float Result_22);
                var Result_23 = Result_22 == __pad_HIgQjdwKgEBPre8qjxcEFl_20;
                n19._Operations_.Switch_Boolean<double>(Condition_In: Result_23, Input_In: Output_21, Input_2_In: Input_2_17, Output_Out: out double Output_24);
                __auto_18 = Output_24;
            }
            else
            {
                __auto_18 = __auto_12;
            }

            var Result_25 = n53.IntegerConversions.ToFloat32(input: __auto_18);
            double __auto_26 = __auto_18;
            Position_Out = Result_25;
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = __auto_18 != this.Time ? new Playhead2_Kxyn85uoNljQF5nAzWcnIh(this)
                {Time = __auto_18} : that_27;
            else
            {
                this.Time = __auto_18;
            }

            return that_27;
        }

        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh SetClock(n57.IFrameClock New_Clock_In)
        {
            n57.IFrameClock __pad_NLPdpcXzbscNnuKS5Hpi0u_0 = New_Clock_In;
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = New_Clock_In != this.__slot_NLPdpcXzbscNnuKS5Hpi0u ? new Playhead2_Kxyn85uoNljQF5nAzWcnIh(this)
                {__slot_NLPdpcXzbscNnuKS5Hpi0u = New_Clock_In} : that_1;
            else
            {
                this.__slot_NLPdpcXzbscNnuKS5Hpi0u = New_Clock_In;
            }

            return that_1;
        }

        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh __Create__(n1.NodeContext Node_Context, n57.IFrameClock Clock_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n57.IFrameClock __pad_NLPdpcXzbscNnuKS5Hpi0u_0 = Clock_In;
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_1 = this;
            this.Time = 0;
            this.__slot_NLPdpcXzbscNnuKS5Hpi0u = Clock_In;
            return that_1;
        }

        public n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh __CreateDefault__()
        {
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_0 = this;
            this.Time = 0;
            this.__slot_NLPdpcXzbscNnuKS5Hpi0u = n61._Operations_.CreateDefault();
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

        [n1.ElementAttribute(TracingId = 119537U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NpXMTUZ3wvQP04T1qwxehR", Name = "Time")]
        public double Time;
        [n1.ElementAttribute(TracingId = 119801U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "NLPdpcXzbscNnuKS5Hpi0u", Name = "__slot_NLPdpcXzbscNnuKS5Hpi0u")]
        public n57.IFrameClock __slot_NLPdpcXzbscNnuKS5Hpi0u;
        [n1.ElementAttribute(TracingId = 119742U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "HIgQjdwKgEBPre8qjxcEFl", Name = "__slot_HIgQjdwKgEBPre8qjxcEFl")]
        public static float __slot_HIgQjdwKgEBPre8qjxcEFl = 0F;
        static Playhead2_Kxyn85uoNljQF5nAzWcnIh()
        {
        }

        public Playhead2_Kxyn85uoNljQF5nAzWcnIh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Playhead2_Kxyn85uoNljQF5nAzWcnIh(Playhead2_Kxyn85uoNljQF5nAzWcnIh other): base(other)
        {
            this.Time = other.Time;
            this.__slot_NLPdpcXzbscNnuKS5Hpi0u = other.__slot_NLPdpcXzbscNnuKS5Hpi0u;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Time", in Time), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NLPdpcXzbscNnuKS5Hpi0u", in __slot_NLPdpcXzbscNnuKS5Hpi0u));
        }

        internal Playhead2_Kxyn85uoNljQF5nAzWcnIh __WITH__(double Time, n57.IFrameClock __slot_NLPdpcXzbscNnuKS5Hpi0u)
        {
            n59.Playhead2_Kxyn85uoNljQF5nAzWcnIh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Time != this.Time || __slot_NLPdpcXzbscNnuKS5Hpi0u != this.__slot_NLPdpcXzbscNnuKS5Hpi0u ? new Playhead2_Kxyn85uoNljQF5nAzWcnIh(this)
                {Time = Time, __slot_NLPdpcXzbscNnuKS5Hpi0u = __slot_NLPdpcXzbscNnuKS5Hpi0u} : that_0;
            else
            {
                this.Time = Time;
                this.__slot_NLPdpcXzbscNnuKS5Hpi0u = __slot_NLPdpcXzbscNnuKS5Hpi0u;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ToFrameId<T, AdM>(T Input_In, T FPS_In, out int Result_Out)
            where AdM : struct, n44.IAdaptiveOperatorGreaterThan<T>, n44.IAdaptiveOperatorMulitply<T>, n62.IAdaptiveToInt32<T>, n20.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_B1lFCu99XTiQPER80BViva_1 = __slot_B1lFCu99XTiQPER80BViva;
            w_0.CreateDefault(Output_Out: out T Output_2);
            w_0.OperatorGreaterThan(Input_In: Input_In, Input_2_In: Output_2, Result_Out: out bool Result_3);
            int __auto_4;
            if (Result_3)
            {
                w_0.OperatorMulitply(Input_In: Input_In, Input_2_In: FPS_In, Output_Out: out T Output_5);
                w_0.ToInt32(Input_In: Output_5, Result_Out: out int Result_6);
                __auto_4 = Result_6;
            }
            else
            {
                __auto_4 = __pad_B1lFCu99XTiQPER80BViva_1;
            }

            Result_Out = __auto_4;
            return;
        }

        [n1.ElementAttribute(TracingId = 119473U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "B1lFCu99XTiQPER80BViva", Name = "__slot_B1lFCu99XTiQPER80BViva")]
        public static int __slot_B1lFCu99XTiQPER80BViva = -1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Windowing
{
    [n1.ElementAttribute(TracingId = 121501U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "IJtw1D3ePLDOe5ge35vYfr", Name = "AdapterInfo_IJtw1D3ePLDOe5ge35vYfr")]
    [n2.SerializableAttribute]
    public class AdapterInfo_IJtw1D3ePLDOe5ge35vYfr : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr Create(n1.NodeContext Node_Context)
        {
            var instance = new AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr CreateDefault()
        {
            var instance = new AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr Update(bool Refresh_In, out string Description_Out, out int Ouput_Count_Out, out n26.Spread<n8.GraphicsOutput> Outputs_Out, out string Adapter_Uid_Out, out int Vendor_Id_Out)
        {
            var State_Output_1 = this.__p_KigqqDuSnJNQameB82pv7c.Update(Simulate_In: Refresh_In, Output_Out: out bool Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_T0VmK0eEIFuOtw6rmlCDsL;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple, n2.ValueTuple<string, int, n26.Spread<n8.GraphicsOutput>, string, int>>(("", 0, n37._Operations_.CreateDefault<n8.GraphicsOutput>(), "", 0));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Output_0 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__KNEjzdGxs6QK9qVD8jPrUB>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __KNEjzdGxs6QK9qVD8jPrUB(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "F0xSCXWOlI6OsHyTdHnYPm", 121609U);
                    var Output_9 = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_8);
                    state_7.__p_F0xSCXWOlI6OsHyTdHnYPm = Output_9;
                }

                var State_Output_11 = state_7.__p_F0xSCXWOlI6OsHyTdHnYPm.Update(Output_Out: out n8.GraphicsDevice Output_10);
                var Adapter_12 = Output_10.Adapter;
                var Outputs_13 = Adapter_12.Outputs;
                n11.IEnumerable<n8.GraphicsOutput> Input_14 = (n11.IEnumerable<n8.GraphicsOutput>)Outputs_13;
                var __fallback___15 = n1.ServiceRegistry.Current;
                n56._Operations_.Where<n8.GraphicsOutput>(Input_In: Input_14, Predicate_In: (n8.GraphicsOutput Input_1_In_17, int Input_2_In_18) =>
                {
                    using var __current_16 = __fallback___15.MakeCurrentIfNone();
                    n5.ObjectHelpers.IsAssigned(x: Input_1_In_17, result: out bool Result_19, notAssigned: out bool Not_Assigned_20);
                    return Result_19;
                }

                , Output_Out: out n11.IEnumerable<n8.GraphicsOutput> Output_21);
                n37._Operations_.FromSequence<n8.GraphicsOutput>(Input_In: Output_21, Result_Out: out n26.Spread<n8.GraphicsOutput> Result_22);
                n37._Operations_.Count<n8.GraphicsOutput>(Input_In: Result_22, Count_Out: out int Count_23);
                var Description_24 = Adapter_12.Description;
                var Adapter_Uid_25 = Adapter_12.AdapterUid;
                var Vendor_Id_26 = Adapter_12.VendorId;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_11 != state_7.__p_F0xSCXWOlI6OsHyTdHnYPm ? new __KNEjzdGxs6QK9qVD8jPrUB(state_7)
                    {__p_F0xSCXWOlI6OsHyTdHnYPm = State_Output_11} : state_7;
                else
                {
                    state_7.__p_F0xSCXWOlI6OsHyTdHnYPm = State_Output_11;
                }

                outputs_5 = (Description_24, Count_23, Result_22, Adapter_Uid_25, Vendor_Id_26);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_27, __auto_28, __auto_29, __auto_30, __auto_31) = outputs_5;
            Description_Out = __auto_27;
            Ouput_Count_Out = __auto_28;
            Outputs_Out = __auto_29;
            Adapter_Uid_Out = __auto_30;
            Vendor_Id_Out = __auto_31;
            n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = State_Output_1 != this.__p_KigqqDuSnJNQameB82pv7c || manager_3 != this.__cache_T0VmK0eEIFuOtw6rmlCDsL ? new AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(this)
                {__p_KigqqDuSnJNQameB82pv7c = State_Output_1, __cache_T0VmK0eEIFuOtw6rmlCDsL = manager_3} : that_32;
            else
            {
                this.__p_KigqqDuSnJNQameB82pv7c = State_Output_1;
                this.__cache_T0VmK0eEIFuOtw6rmlCDsL = manager_3;
            }

            return that_32;
        }

        public n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "KigqqDuSnJNQameB82pv7c", 121743U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr that_2 = this;
            this.__p_KigqqDuSnJNQameB82pv7c = Output_1;
            this.__cache_T0VmK0eEIFuOtw6rmlCDsL = null;
            return that_2;
        }

        public n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr __CreateDefault__()
        {
            n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr that_0 = this;
            this.__p_KigqqDuSnJNQameB82pv7c = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_T0VmK0eEIFuOtw6rmlCDsL = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KigqqDuSnJNQameB82pv7c);
            n1.CompilationHelper.SafeDispose(this.__cache_T0VmK0eEIFuOtw6rmlCDsL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 121743U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KigqqDuSnJNQameB82pv7c", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_KigqqDuSnJNQameB82pv7c;
        [n1.ElementAttribute(TracingId = 121509U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "T0VmK0eEIFuOtw6rmlCDsL", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple, n2.ValueTuple<string, int, n26.Spread<n8.GraphicsOutput>, string, int>> __cache_T0VmK0eEIFuOtw6rmlCDsL = null;
        public AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(AdapterInfo_IJtw1D3ePLDOe5ge35vYfr other): base(other)
        {
            this.__p_KigqqDuSnJNQameB82pv7c = other.__p_KigqqDuSnJNQameB82pv7c;
            this.__cache_T0VmK0eEIFuOtw6rmlCDsL = other.__cache_T0VmK0eEIFuOtw6rmlCDsL;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KigqqDuSnJNQameB82pv7c", in __p_KigqqDuSnJNQameB82pv7c), n1.CompilationHelper.GetValueOrExisting(values, "__cache_T0VmK0eEIFuOtw6rmlCDsL", in __cache_T0VmK0eEIFuOtw6rmlCDsL));
        }

        internal AdapterInfo_IJtw1D3ePLDOe5ge35vYfr __WITH__(n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_KigqqDuSnJNQameB82pv7c, n6.Manager<n2.ValueTuple, n2.ValueTuple<string, int, n26.Spread<n8.GraphicsOutput>, string, int>> __cache_T0VmK0eEIFuOtw6rmlCDsL)
        {
            n63.AdapterInfo_IJtw1D3ePLDOe5ge35vYfr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KigqqDuSnJNQameB82pv7c != this.__p_KigqqDuSnJNQameB82pv7c || __cache_T0VmK0eEIFuOtw6rmlCDsL != this.__cache_T0VmK0eEIFuOtw6rmlCDsL ? new AdapterInfo_IJtw1D3ePLDOe5ge35vYfr(this)
                {__p_KigqqDuSnJNQameB82pv7c = __p_KigqqDuSnJNQameB82pv7c, __cache_T0VmK0eEIFuOtw6rmlCDsL = __cache_T0VmK0eEIFuOtw6rmlCDsL} : that_0;
            else
            {
                this.__p_KigqqDuSnJNQameB82pv7c = __p_KigqqDuSnJNQameB82pv7c;
                this.__cache_T0VmK0eEIFuOtw6rmlCDsL = __cache_T0VmK0eEIFuOtw6rmlCDsL;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "KNEjzdGxs6QK9qVD8jPrUB", Name = "__KNEjzdGxs6QK9qVD8jPrUB")]
        [n2.SerializableAttribute]
        public class __KNEjzdGxs6QK9qVD8jPrUB : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_F0xSCXWOlI6OsHyTdHnYPm);
                return;
            }

            [n1.ElementAttribute(TracingId = 121609U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "F0xSCXWOlI6OsHyTdHnYPm", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_F0xSCXWOlI6OsHyTdHnYPm;
            public __KNEjzdGxs6QK9qVD8jPrUB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KNEjzdGxs6QK9qVD8jPrUB(__KNEjzdGxs6QK9qVD8jPrUB other): base(other)
            {
                this.__p_F0xSCXWOlI6OsHyTdHnYPm = other.__p_F0xSCXWOlI6OsHyTdHnYPm;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F0xSCXWOlI6OsHyTdHnYPm", in __p_F0xSCXWOlI6OsHyTdHnYPm));
            }

            internal __KNEjzdGxs6QK9qVD8jPrUB __WITH__(n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_F0xSCXWOlI6OsHyTdHnYPm)
            {
                __KNEjzdGxs6QK9qVD8jPrUB that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_F0xSCXWOlI6OsHyTdHnYPm != this.__p_F0xSCXWOlI6OsHyTdHnYPm ? new __KNEjzdGxs6QK9qVD8jPrUB(this)
                    {__p_F0xSCXWOlI6OsHyTdHnYPm = __p_F0xSCXWOlI6OsHyTdHnYPm} : that_0;
                else
                {
                    this.__p_F0xSCXWOlI6OsHyTdHnYPm = __p_F0xSCXWOlI6OsHyTdHnYPm;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_.Stride.Utils.Advanced
{
    [n1.ElementAttribute(TracingId = 121882U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Jyp9mYJHExJNVTwXieAIds", Name = "GraphicsData_Jyp9mYJHExJNVTwXieAIds")]
    [n2.SerializableAttribute]
    public class GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> CreateDefault()
        {
            var instance = new GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> Update(out n14.IGraphicsDataProvider Output_Out)
        {
            n14.MemoryDataProvider __auto_0 = this.Provider;
            n14.IGraphicsDataProvider Output_Out_1 = (n14.IGraphicsDataProvider)__auto_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> SetInput<AdM>(T Input_In, int Offset_In_Bytes_In, bool Force_In)
            where AdM : struct, n10.IAdaptiveSetGraphicsData<T>
        {
            var w_0 = default(AdM);
            n14.MemoryDataProvider __auto_1 = this.Provider;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_P2wfN2MKpNUNc9rzRRbJcp;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<T, int>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_4 = (Input_In, Offset_In_Bytes_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_In || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                int Size_In_Bytes_8 = 0;
                int Element_Size_In_Bytes_9 = 0;
                int Row_Size_In_Bytes_10 = 0;
                int Slice_Size_In_Bytes_11 = 0;
                w_0.SetGraphicsData(Input_In: __auto_1, Data_In: Input_In, Offset_In_Bytes_In: Offset_In_Bytes_In, Size_In_Bytes_In: Size_In_Bytes_8, Element_Size_In_Bytes_In: Element_Size_In_Bytes_9, Row_Size_In_Bytes_In: Row_Size_In_Bytes_10, Slice_Size_In_Bytes_In: Slice_Size_In_Bytes_11, Output_Out: out n14.MemoryDataProvider Output_12);
                outputs_5 = n2.ValueTuple.Create();
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = manager_3 != this.__cache_P2wfN2MKpNUNc9rzRRbJcp ? new GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>(this)
                {__cache_P2wfN2MKpNUNc9rzRRbJcp = manager_3} : that_13;
            else
            {
                this.__cache_P2wfN2MKpNUNc9rzRRbJcp = manager_3;
            }

            return that_13;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> SetSize(int Size_In_Bytes_In)
        {
            n14.MemoryDataProvider __auto_0 = this.Provider;
            __auto_0.SizeInBytes = Size_In_Bytes_In;
            return this;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> SetElementSize(int Element_Size_In_Bytes_In)
        {
            n14.MemoryDataProvider __auto_0 = this.Provider;
            __auto_0.ElementSizeInBytes = Element_Size_In_Bytes_In;
            return this;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> SetRowSize(int Row_Size_In_Bytes_In)
        {
            n14.MemoryDataProvider __auto_0 = this.Provider;
            __auto_0.RowSizeInBytes = Row_Size_In_Bytes_In;
            return this;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> SetSliceSize(int Slice_Size_In_Bytes_In)
        {
            n14.MemoryDataProvider __auto_0 = this.Provider;
            __auto_0.SliceSizeInBytes = Slice_Size_In_Bytes_In;
            return this;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n14.MemoryDataProvider();
            n14.MemoryDataProvider __auto_1 = Output_0;
            n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> that_2 = this;
            this.Provider = Output_0;
            this.__cache_P2wfN2MKpNUNc9rzRRbJcp = null;
            return that_2;
        }

        public n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __CreateDefault__()
        {
            n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> that_0 = this;
            this.Provider = default(n14.MemoryDataProvider);
            this.__cache_P2wfN2MKpNUNc9rzRRbJcp = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_P2wfN2MKpNUNc9rzRRbJcp);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 121998U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "VYWDgys3xiFOnzNJidQEMw", Name = "Provider")]
        public n14.MemoryDataProvider Provider;
        [n1.ElementAttribute(TracingId = 121888U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "P2wfN2MKpNUNc9rzRRbJcp", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<T, int>, n2.ValueTuple> __cache_P2wfN2MKpNUNc9rzRRbJcp = null;
        public GraphicsData_Jyp9mYJHExJNVTwXieAIds(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GraphicsData_Jyp9mYJHExJNVTwXieAIds(GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> other): base(other)
        {
            this.Provider = other.Provider;
            this.__cache_P2wfN2MKpNUNc9rzRRbJcp = other.__cache_P2wfN2MKpNUNc9rzRRbJcp;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Provider", in Provider), n1.CompilationHelper.GetValueOrExisting(values, "__cache_P2wfN2MKpNUNc9rzRRbJcp", in __cache_P2wfN2MKpNUNc9rzRRbJcp));
        }

        internal GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> __WITH__(n14.MemoryDataProvider Provider, n6.Manager<n2.ValueTuple<T, int>, n2.ValueTuple> __cache_P2wfN2MKpNUNc9rzRRbJcp)
        {
            n10.GraphicsData_Jyp9mYJHExJNVTwXieAIds<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Provider != this.Provider || __cache_P2wfN2MKpNUNc9rzRRbJcp != this.__cache_P2wfN2MKpNUNc9rzRRbJcp ? new GraphicsData_Jyp9mYJHExJNVTwXieAIds<T>(this)
                {Provider = Provider, __cache_P2wfN2MKpNUNc9rzRRbJcp = __cache_P2wfN2MKpNUNc9rzRRbJcp} : that_0;
            else
            {
                this.Provider = Provider;
                this.__cache_P2wfN2MKpNUNc9rzRRbJcp = __cache_P2wfN2MKpNUNc9rzRRbJcp;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 122656U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "V0mXf77TurpOVQNzgviejb", Name = "GraphicsDevice_V0mXf77TurpOVQNzgviejb")]
    [n2.SerializableAttribute]
    public class GraphicsDevice_V0mXf77TurpOVQNzgviejb : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb Create(n1.NodeContext Node_Context_In)
        {
            var instance = new GraphicsDevice_V0mXf77TurpOVQNzgviejb(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n4.CreateDefaultAttribute]
        public static n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb CreateDefault()
        {
            var instance = new GraphicsDevice_V0mXf77TurpOVQNzgviejb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb Update(out n8.GraphicsDevice Output_Out)
        {
            var Output_1 = this.__p_Bbfv58zUUhvOHxuyclPVuP.GetResource(Resource_Out: out n8.GraphicsDevice Resource_0);
            Output_Out = Resource_0;
            n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Bbfv58zUUhvOHxuyclPVuP ? new GraphicsDevice_V0mXf77TurpOVQNzgviejb(this)
                {__p_Bbfv58zUUhvOHxuyclPVuP = Output_1} : that_2;
            else
            {
                this.__p_Bbfv58zUUhvOHxuyclPVuP = Output_1;
            }

            return that_2;
        }

        public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __Create__(n1.NodeContext Node_Context_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Result_0 = n64.Resources.GetDeviceProvider(nodeContext: Node_Context_In);
            n1.NodeContext Node_Context_1 = Node_Context_In.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Bbfv58zUUhvOHxuyclPVuP", 122662U);
            var Output_2 = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsDevice>, n8.GraphicsDevice>.Create(Node_Context: Node_Context_1);
            bool Update_3 = true;
            var Output_4 = Output_2;
            if (Update_3)
            {
                Output_4 = Output_2.Update(Input_In: Result_0);
            }

            n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb that_5 = this;
            this.__p_Bbfv58zUUhvOHxuyclPVuP = Output_4;
            return that_5;
        }

        public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __CreateDefault__()
        {
            n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb that_0 = this;
            this.__p_Bbfv58zUUhvOHxuyclPVuP = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsDevice>, n8.GraphicsDevice>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Bbfv58zUUhvOHxuyclPVuP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 122662U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Bbfv58zUUhvOHxuyclPVuP", Name = "Using (Process)", IsManaged = true, IsAutoGenerated = true)]
        public n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsDevice>, n8.GraphicsDevice> __p_Bbfv58zUUhvOHxuyclPVuP;
        public GraphicsDevice_V0mXf77TurpOVQNzgviejb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GraphicsDevice_V0mXf77TurpOVQNzgviejb(GraphicsDevice_V0mXf77TurpOVQNzgviejb other): base(other)
        {
            this.__p_Bbfv58zUUhvOHxuyclPVuP = other.__p_Bbfv58zUUhvOHxuyclPVuP;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Bbfv58zUUhvOHxuyclPVuP", in __p_Bbfv58zUUhvOHxuyclPVuP));
        }

        internal GraphicsDevice_V0mXf77TurpOVQNzgviejb __WITH__(n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsDevice>, n8.GraphicsDevice> __p_Bbfv58zUUhvOHxuyclPVuP)
        {
            n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Bbfv58zUUhvOHxuyclPVuP != this.__p_Bbfv58zUUhvOHxuyclPVuP ? new GraphicsDevice_V0mXf77TurpOVQNzgviejb(this)
                {__p_Bbfv58zUUhvOHxuyclPVuP = __p_Bbfv58zUUhvOHxuyclPVuP} : that_0;
            else
            {
                this.__p_Bbfv58zUUhvOHxuyclPVuP = __p_Bbfv58zUUhvOHxuyclPVuP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 122753U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "LZGVLOdpi83QS6XklGOZVK", Name = "GraphicsContext_LZGVLOdpi83QS6XklGOZVK")]
    [n2.SerializableAttribute]
    public class GraphicsContext_LZGVLOdpi83QS6XklGOZVK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK Create(n1.NodeContext Node_Context_In)
        {
            var instance = new GraphicsContext_LZGVLOdpi83QS6XklGOZVK(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n4.CreateDefaultAttribute]
        public static n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK CreateDefault()
        {
            var instance = new GraphicsContext_LZGVLOdpi83QS6XklGOZVK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK Update(out n8.GraphicsContext Output_Out)
        {
            var Output_1 = this.__p_Dl49sO7pvigQdBMKCSIKzl.GetResource(Resource_Out: out n8.GraphicsContext Resource_0);
            Output_Out = Resource_0;
            n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Dl49sO7pvigQdBMKCSIKzl ? new GraphicsContext_LZGVLOdpi83QS6XklGOZVK(this)
                {__p_Dl49sO7pvigQdBMKCSIKzl = Output_1} : that_2;
            else
            {
                this.__p_Dl49sO7pvigQdBMKCSIKzl = Output_1;
            }

            return that_2;
        }

        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __Create__(n1.NodeContext Node_Context_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Result_0 = n64.Resources.GetGraphicsContextProvider(nodeContext: Node_Context_In);
            n1.NodeContext Node_Context_1 = Node_Context_In.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "Dl49sO7pvigQdBMKCSIKzl", 122760U);
            var Output_2 = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsContext>, n8.GraphicsContext>.Create(Node_Context: Node_Context_1);
            bool Update_3 = true;
            var Output_4 = Output_2;
            if (Update_3)
            {
                Output_4 = Output_2.Update(Input_In: Result_0);
            }

            n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK that_5 = this;
            this.__p_Dl49sO7pvigQdBMKCSIKzl = Output_4;
            return that_5;
        }

        public n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __CreateDefault__()
        {
            n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK that_0 = this;
            this.__p_Dl49sO7pvigQdBMKCSIKzl = n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsContext>, n8.GraphicsContext>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Dl49sO7pvigQdBMKCSIKzl);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 122760U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "Dl49sO7pvigQdBMKCSIKzl", Name = "Using (Process)", IsManaged = true, IsAutoGenerated = true)]
        public n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsContext>, n8.GraphicsContext> __p_Dl49sO7pvigQdBMKCSIKzl;
        public GraphicsContext_LZGVLOdpi83QS6XklGOZVK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GraphicsContext_LZGVLOdpi83QS6XklGOZVK(GraphicsContext_LZGVLOdpi83QS6XklGOZVK other): base(other)
        {
            this.__p_Dl49sO7pvigQdBMKCSIKzl = other.__p_Dl49sO7pvigQdBMKCSIKzl;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Dl49sO7pvigQdBMKCSIKzl", in __p_Dl49sO7pvigQdBMKCSIKzl));
        }

        internal GraphicsContext_LZGVLOdpi83QS6XklGOZVK __WITH__(n42.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n39.IResourceProvider<n8.GraphicsContext>, n8.GraphicsContext> __p_Dl49sO7pvigQdBMKCSIKzl)
        {
            n10.GraphicsContext_LZGVLOdpi83QS6XklGOZVK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Dl49sO7pvigQdBMKCSIKzl != this.__p_Dl49sO7pvigQdBMKCSIKzl ? new GraphicsContext_LZGVLOdpi83QS6XklGOZVK(this)
                {__p_Dl49sO7pvigQdBMKCSIKzl = __p_Dl49sO7pvigQdBMKCSIKzl} : that_0;
            else
            {
                this.__p_Dl49sO7pvigQdBMKCSIKzl = __p_Dl49sO7pvigQdBMKCSIKzl;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 122842U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "SUf2hZhJxjcNpRebjx40WD", Name = "ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD")]
    [n2.SerializableAttribute]
    public class ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD Create(n1.NodeContext Node_Context)
        {
            var instance = new ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD CreateDefault()
        {
            var instance = new ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD Update(n12.Color4 Input_In, out n12.Color4 Output_Out)
        {
            var State_Output_1 = this.__p_OpFbWMMY5kyOje2CagHayh.Update(Output_Out: out n8.GraphicsDevice Output_0);
            var Color_Space_2 = Output_0.ColorSpace;
            var Output_3 = n17.ColorExtensions.ToColorSpace(color: Input_In, colorSpace: Color_Space_2);
            Output_Out = Output_3;
            n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_1 != this.__p_OpFbWMMY5kyOje2CagHayh ? new ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(this)
                {__p_OpFbWMMY5kyOje2CagHayh = State_Output_1} : that_4;
            else
            {
                this.__p_OpFbWMMY5kyOje2CagHayh = State_Output_1;
            }

            return that_4;
        }

        public n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dky5PMnuvcKN4CxmfNs7Uv", "OpFbWMMY5kyOje2CagHayh", 122847U);
            var Output_1 = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_0);
            n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD that_2 = this;
            this.__p_OpFbWMMY5kyOje2CagHayh = Output_1;
            return that_2;
        }

        public n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD __CreateDefault__()
        {
            n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD that_0 = this;
            this.__p_OpFbWMMY5kyOje2CagHayh = n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OpFbWMMY5kyOje2CagHayh);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 122847U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OpFbWMMY5kyOje2CagHayh", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
        public n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_OpFbWMMY5kyOje2CagHayh;
        public ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD other): base(other)
        {
            this.__p_OpFbWMMY5kyOje2CagHayh = other.__p_OpFbWMMY5kyOje2CagHayh;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OpFbWMMY5kyOje2CagHayh", in __p_OpFbWMMY5kyOje2CagHayh));
        }

        internal ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD __WITH__(n10.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_OpFbWMMY5kyOje2CagHayh)
        {
            n10.ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_OpFbWMMY5kyOje2CagHayh != this.__p_OpFbWMMY5kyOje2CagHayh ? new ToDeviceColorSpace_SUf2hZhJxjcNpRebjx40WD(this)
                {__p_OpFbWMMY5kyOje2CagHayh = __p_OpFbWMMY5kyOje2CagHayh} : that_0;
            else
            {
                this.__p_OpFbWMMY5kyOje2CagHayh = __p_OpFbWMMY5kyOje2CagHayh;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107555U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void SetGraphicsData<T2, T, AdM>(n14.MemoryDataProvider Input_In, T2 Data_In, [n4.SerializedDefaultValueAttribute("0", false)] int Offset_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Element_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Row_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Slice_Size_In_Bytes_In, out n14.MemoryDataProvider Output_Out)
            where T2 : n11.IEnumerable<T> where T : struct where AdM : struct, n65.IAdaptiveAsReadOnlyMemory<T2, T>
        {
            var w_0 = default(AdM);
            w_0.AsReadOnlyMemory(Input_In: Data_In, Result_Out: out n2.ReadOnlyMemory<T> Result_1);
            Input_In.SetMemoryData<T>(memory: Result_1, offsetInBytes: Offset_In_Bytes_In, sizeInBytes: Size_In_Bytes_In, elementSizeInBytes: Element_Size_In_Bytes_In, rowSizeInBytes: Row_Size_In_Bytes_In, sliceSizeInBytes: Slice_Size_In_Bytes_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetGraphicsData(n14.MemoryDataProvider Input_In, n66.IImage Data_In, [n4.SerializedDefaultValueAttribute("0", false)] int Offset_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Element_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Row_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Slice_Size_In_Bytes_In, out n14.MemoryDataProvider Output_Out)
        {
            Input_In.SetImageData(image: Data_In, offsetInBytes: Offset_In_Bytes_In, sizeInBytes: Size_In_Bytes_In, elementSizeInBytes: Element_Size_In_Bytes_In, rowSizeInBytes: Row_Size_In_Bytes_In, sliceSizeInBytes: Slice_Size_In_Bytes_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetGraphicsData<T>(n14.MemoryDataProvider Input_In, n2.ReadOnlyMemory<T> Data_In, [n4.SerializedDefaultValueAttribute("0", false)] int Offset_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Element_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Row_Size_In_Bytes_In, [n4.SerializedDefaultValueAttribute("0", false)] int Slice_Size_In_Bytes_In, out n14.MemoryDataProvider Output_Out)
            where T : struct
        {
            Input_In.SetMemoryData<T>(memory: Data_In, offsetInBytes: Offset_In_Bytes_In, sizeInBytes: Size_In_Bytes_In, elementSizeInBytes: Element_Size_In_Bytes_In, rowSizeInBytes: Row_Size_In_Bytes_In, sliceSizeInBytes: Slice_Size_In_Bytes_In);
            Output_Out = Input_In;
            return;
        }
    }

    public interface IAdaptiveSetGraphicsData<T>
    {
        void SetGraphicsData(n14.MemoryDataProvider Input_In, T Data_In, int Offset_In_Bytes_In, int Size_In_Bytes_In, int Element_Size_In_Bytes_In, int Row_Size_In_Bytes_In, int Slice_Size_In_Bytes_In, out n14.MemoryDataProvider Output_Out);
    }
}

namespace _VL_Stride_Graphics_.Stride
{
    [n1.ElementAttribute(TracingId = 123269U, DocumentId = "Dky5PMnuvcKN4CxmfNs7Uv", PersistentId = "OfoGgjpFBuQOO6WH36N2O3", Name = "VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3")]
    [n2.SerializableAttribute]
    public class VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n67.VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n67.VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 CreateDefault()
        {
            var instance = new VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n67.VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 Update()
        {
            return this;
        }

        public n67.VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n67.VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 __CreateDefault__()
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

        public VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3(VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_GraphicsApplication_OfoGgjpFBuQOO6WH36N2O3 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Graphics_
{
    public struct __AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv : n44.IAdaptiveOperatorGreater<int>, n44.IAdaptiveZero<int>, n10.IAdaptiveSetGraphicsData<n26.Spread<uint>>, n65.IAdaptiveAsReadOnlyMemory<n26.Spread<uint>, uint>, n20.IAdaptiveCreateDefault<bool>, n20.IAdaptiveCreateDefault<n38.TextureLoadTask_C>, n20.IAdaptiveCreateDefault<n36.Path>, n44.IAdaptiveMax<int>, n44.IAdaptiveOne<int>, n20.IAdaptiveCreateDefault<string>, n20.IAdaptiveCreateDefault<int>, n44.IAdaptiveNE<int>, n44.IAdaptiveOperatorPlus<int>, n44.IAdaptiveOperatorMinus<int>, n44.IAdaptiveZMOD<int>, n44.IAdaptiveNE<float>, n44.IAdaptiveOne<float>, n44.IAdaptiveOperatorPlus<float>, n44.IAdaptiveZero<float>, n44.IAdaptiveOperatorMinus<float>, n44.IAdaptiveZMOD<float>, n44.IAdaptiveOperatorGreaterThan<float>, n44.IAdaptiveOperatorMulitply<float>, n62.IAdaptiveToInt32<float>, n20.IAdaptiveCreateDefault<float>, n20.IAdaptiveCreateDefault<double>, n44.IAdaptiveMax<double>, n44.IAdaptiveOperatorGreater<double>, n44.IAdaptiveMin<double>, n44.IAdaptiveOperatorLess<double>, n44.IAdaptiveOperatorLess<float>, n44.IAdaptiveNE<double>, n44.IAdaptiveOne<double>, n44.IAdaptiveOperatorPlus<double>, n44.IAdaptiveZero<double>, n44.IAdaptiveOperatorMinus<double>, n44.IAdaptiveZMOD<double>, n44.IAdaptiveLength<float>, n20.IAdaptiveCreateDefault<n8.GraphicsDevice>, n20.IAdaptiveCreateDefault<n8.GraphicsContext>
    {
        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Zero(out int Zero_Out)
        {
            var Zero_0 = n53.Integer32Extensions.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void SetGraphicsData(n14.MemoryDataProvider Input_In, n26.Spread<uint> Data_In, int Offset_In_Bytes_In, int Size_In_Bytes_In, int Element_Size_In_Bytes_In, int Row_Size_In_Bytes_In, int Slice_Size_In_Bytes_In, out n14.MemoryDataProvider Output_Out)
        {
            n10._Operations_.SetGraphicsData<n26.Spread<uint>, uint, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Input_In, Data_In: Data_In, Offset_In_Bytes_In: Offset_In_Bytes_In, Size_In_Bytes_In: Size_In_Bytes_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Row_Size_In_Bytes_In: Row_Size_In_Bytes_In, Slice_Size_In_Bytes_In: Slice_Size_In_Bytes_In, Output_Out: out n14.MemoryDataProvider Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AsReadOnlyMemory(n26.Spread<uint> Input_In, out n2.ReadOnlyMemory<uint> Result_Out)
        {
            n11.IReadOnlyList<uint> Input_0 = (n11.IReadOnlyList<uint>)Input_In;
            var Result_1 = n68.MemoryUtils.AsReadOnlyMemory<uint>(input: Input_0);
            Result_Out = Result_1;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n38.TextureLoadTask_C Output_Out)
        {
            var Output_0 = n38.TextureLoadTask_C.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n36.Path Output_Out)
        {
            var Default_0 = n49._Operations_.CreateDefault();
            Output_Out = Default_0;
            return;
        }

        public void Max(int Input_In, int Input_2_In, out int Output_Out)
        {
            n23._Operations_.Max<int, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out int One_Out)
        {
            var One_0 = n53.Integer32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n70._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void NE(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorPlus(int Input_In, int Input_2_In, out int Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(int Input_In, int Input_2_In, out int Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void ZMOD(int Input_In, int Input_2_In, out int Output_Out)
        {
            var Output_0 = n53.Integer32Extensions.ZMOD(z: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public void NE(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void One(out float One_Out)
        {
            var One_0 = n53.Float32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Zero(out float Zero_Out)
        {
            var Zero_0 = n53.Float32Extensions.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void ZMOD(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = n53.Float32Extensions.ZMOD(z: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreaterThan(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In >= Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void ToInt32(float Input_In, out int Result_Out)
        {
            var Result_0 = n53.IntegerConversions.ToInt32(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out double Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<double>(Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Max(double Input_In, double Input_2_In, out double Output_Out)
        {
            n23._Operations_.Max<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Min(double Input_In, double Input_2_In, out double Output_Out)
        {
            n23._Operations_.Min<double, n22.__AdaptiveImplementations__Dky5PMnuvcKN4CxmfNs7Uv>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void NE(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void One(out double One_Out)
        {
            var One_0 = n53.Float64Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorPlus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Zero(out double Zero_Out)
        {
            var Zero_0 = n53.Float64Extensions.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void OperatorMinus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void ZMOD(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = n53.Float64Extensions.ZMOD(z: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public void Length(float Input_In, out float Result_Out)
        {
            var Output_0 = n53.Float32Extensions.Length(input: Input_In);
            Result_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.GraphicsDevice Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<n8.GraphicsDevice>(Output_Out: out n8.GraphicsDevice Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.GraphicsContext Output_Out)
        {
            n69._Operations_.CreateDefault_Generic<n8.GraphicsContext>(Output_Out: out n8.GraphicsContext Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}