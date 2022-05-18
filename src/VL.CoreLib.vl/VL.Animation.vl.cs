extern alias e3;
extern alias e2;
extern alias e4;

using n17 = _CoreLibBasics_.Control.Advanced;
using n51 = e3::VL.Lib.Animation;
using n6 = e2::VL.Lib.Collections;
using n53 = e3::VL.Lib.Primitive.CacheRegion;
using n45 = _CoreLibBasics_.Animation.FrameBased;
using n7 = _VL_Collections_.Collections;
using n28 = _VL_Reactive_.Reactive.ToObservable;
using n18 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n21 = _CoreLibBasics_.Control;
using n30 = _VL_Collections_.Collections.Dictionary;
using n29 = global::System.Collections.Immutable;
using n54 = _CoreLibBasics_.System.Conversion.Adaptive;
using n57 = _CoreLibBasics_.Math.Generic.Advanced;
using n11 = _CoreLibBasics_.Animation.IClock.Advanced;
using n44 = _VL_Animation_.Animation.FrameBased.Wanderer__2D;
using n25 = e3::VL.Lib.Reactive;
using n43 = _CoreLibBasics_._2D;
using n38 = _VL_Animation_.Animation.FrameBased;
using n49 = _CoreLibBasics_.Math.Ranges.Advanced.Adaptive;
using n13 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n41 = _CoreLibBasics_.Math.Ranges.Range;
using n5 = global::System.Collections.Generic;
using n42 = _CoreLibBasics_._2D.Vector2;
using n19 = _VL_Collections_.Collections.Common.KeyValuePair;
using n9 = _CoreLibBasics_.Math.Adaptive;
using n24 = _System_Serialization_.System.Serialization;
using n52 = _VL_Animation_.Animation.Functions.OscillatorFunction.Internal;
using n32 = _VL_Xml_.System.XML;
using n8 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n14 = _CoreLibBasics_.Animation;
using n58 = _CoreLibBasics_.Primitive.Boolean;
using n15 = e3::VL.Lib.Primitive;
using n50 = _CoreLibBasics_.Math.Ranges.Adaptive;
using n37 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n40 = e3::VL.Lib.Mathematics;
using n56 = _CoreLibBasics_.Math.Advanced.Adaptive;
using n33 = _VL_Animation_.Animation.Functions;
using n1 = e2::VL.Core;
using n34 = _VL_Animation_;
using n39 = _VL_Animation_.Animation.FrameBased.MassSpring;
using n2 = global::System;
using n36 = e4::Stride.Core.Mathematics;
using n35 = _VL_Animation_.Animation.Advanced;
using n48 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n31 = e2::VL.Lib.IO;
using n4 = e2::VL.Core.CompilerServices;
using n26 = _VL_Reactive_.Reactive.ForEach;
using n55 = _CoreLibBasics_.System.Conversion.Advanced.Adaptive;
using n27 = _VL_Reactive_.Reactive.HoldLatest;
using n22 = _VL_Collections_.Collections.Mutable.MutableQueue.Advanced;
using n12 = e2::VL.Lib.Animation;
using n47 = _CoreLibBasics_._3D;
using n20 = _VL_Collections_.Collections.Sequence;
using n10 = global::System.Runtime.CompilerServices;
using n3 = _VL_Animation_.Animation;
using n16 = _VL_Collections_.Collections.Spread;
using n59 = _CoreLibBasics_.Primitive.Advanced;
using n23 = global::System.Xml.Linq;
using n46 = _CoreLibBasics_._3D.Vector3;

namespace _VL_Animation_.Animation
{
    [n1.ElementAttribute(TracingId = 22375U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Gow6VG33IYdQWs58olyP8x", Name = "Sequencer_Gow6VG33IYdQWs58olyP8x")]
    [n2.SerializableAttribute]
    public class Sequencer_Gow6VG33IYdQWs58olyP8x<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Sequencer_Gow6VG33IYdQWs58olyP8x<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> CreateDefault()
        {
            var instance = new Sequencer_Gow6VG33IYdQWs58olyP8x<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> Update<AdM>(T Value_In, n6.Spread<n5.KeyValuePair<float, T>> Initial_Values_In, bool Initialize_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Clear_In, [n4.SerializedDefaultValueAttribute("1", false)] float Speed_In, bool Seek_In, float Seek_Time_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Record_In, bool Play_In, out T Value_Out, out n6.Spread<n5.KeyValuePair<float, T>> Keyframes_Out, out float Duration_Out, out float Position_Out)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorGreater<float>, n9.IAdaptiveOperatorLess<float>, n9.IAdaptiveOperatorLessThan<float>, n9.IAdaptiveLerp<T>, n9.IAdaptiveOperatorGreaterThan<float>, n8.IAdaptiveCreateDefault<float>
        {
            var w_0 = default(AdM);
            bool __pad_NWPPDxnX4fNPrqprEEU2TS_1 = __slot_NWPPDxnX4fNPrqprEEU2TS;
            var Output_4 = this.__p_CB4zY00MCN0MchqsL2ZR8N.Update<AdM>(Value_In: Value_In, Clear_In: Clear_In, Record_In: Record_In, Initialize_In: Initialize_In, Initial_Values_In: Initial_Values_In, Keyframes_Out: out n6.Spread<n5.KeyValuePair<float, T>> Keyframes_2, Duration_Out: out float Duration_3);
            bool SetTime_5 = true;
            var Output_6 = this.__p_OOFuqkLY1zvMhzusz6PZQY;
            if (SetTime_5)
            {
                Output_6 = this.__p_OOFuqkLY1zvMhzusz6PZQY.SetTime(Seek_Time_In: Seek_Time_In, Seek_In: Seek_In);
            }

            float Loop_Start_7 = 0F;
            var Output_9 = Output_6.Step(Play_In: Play_In, Loop_In: __pad_NWPPDxnX4fNPrqprEEU2TS_1, Loop_Start_In: Loop_Start_7, Loop_End_In: Duration_3, Speed_In: Speed_In, Position_Out: out float Position_8);
            n7._Operations_.BinarySearch_KeyValuePair_Lerp<n6.Spread<n5.KeyValuePair<float, T>>, T, AdM>(Input_In: Keyframes_2, Search_Key_In: Position_8, Value_Out: out T Value_10, Position_Out: out float Position_11, Lower_Value_Out: out T Lower_Value_12, Upper_value_Out: out T Upper_value_13, Lower_Key_Out: out float Lower_Key_14, Upper_Key_Out: out float Upper_Key_15, Lower_Index_Out: out int Lower_Index_16, Upper_Index_Out: out int Upper_Index_17, Success_Out: out bool Success_18);
            Value_Out = Value_10;
            Keyframes_Out = Keyframes_2;
            Duration_Out = Duration_3;
            Position_Out = Position_8;
            n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = Output_4 != this.__p_CB4zY00MCN0MchqsL2ZR8N || Output_9 != this.__p_OOFuqkLY1zvMhzusz6PZQY ? new Sequencer_Gow6VG33IYdQWs58olyP8x<T>(this)
                {__p_CB4zY00MCN0MchqsL2ZR8N = Output_4, __p_OOFuqkLY1zvMhzusz6PZQY = Output_9} : that_19;
            else
            {
                this.__p_CB4zY00MCN0MchqsL2ZR8N = Output_4;
                this.__p_OOFuqkLY1zvMhzusz6PZQY = Output_9;
            }

            return that_19;
        }

        public n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "CB4zY00MCN0MchqsL2ZR8N", 22894U);
            n12.IClock Clock_1 = n11._Operations_.CreateDefault();
            var Output_2 = n3.Track_JTJsMOijt7DP1rXh0BfLSa<T>.Create(Node_Context: Node_Context_0, Clock_In: Clock_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "OOFuqkLY1zvMhzusz6PZQY", 22923U);
            n12.IFrameClock Clock_4 = n13._Operations_.CreateDefault();
            var Output_5 = n14.Playhead_EQKfVwGC966NC2YT92PjkJ.Create(Node_Context: Node_Context_3, Clock_In: Clock_4);
            n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> that_6 = this;
            this.__p_CB4zY00MCN0MchqsL2ZR8N = Output_2;
            this.__p_OOFuqkLY1zvMhzusz6PZQY = Output_5;
            return that_6;
        }

        public n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> __CreateDefault__()
        {
            n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> that_0 = this;
            this.__p_CB4zY00MCN0MchqsL2ZR8N = n3.Track_JTJsMOijt7DP1rXh0BfLSa<T>.CreateDefault();
            this.__p_OOFuqkLY1zvMhzusz6PZQY = n14.Playhead_EQKfVwGC966NC2YT92PjkJ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_CB4zY00MCN0MchqsL2ZR8N);
            n1.CompilationHelper.SafeDispose(this.__p_OOFuqkLY1zvMhzusz6PZQY);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 22883U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NWPPDxnX4fNPrqprEEU2TS", Name = "__slot_NWPPDxnX4fNPrqprEEU2TS")]
        public static bool __slot_NWPPDxnX4fNPrqprEEU2TS = true;
        [n1.ElementAttribute(TracingId = 22894U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "CB4zY00MCN0MchqsL2ZR8N", Name = "Track", IsManaged = true, IsAutoGenerated = true)]
        public n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> __p_CB4zY00MCN0MchqsL2ZR8N;
        [n1.ElementAttribute(TracingId = 22923U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "OOFuqkLY1zvMhzusz6PZQY", Name = "Playhead", IsManaged = true, IsAutoGenerated = true)]
        public n14.Playhead_EQKfVwGC966NC2YT92PjkJ __p_OOFuqkLY1zvMhzusz6PZQY;
        static Sequencer_Gow6VG33IYdQWs58olyP8x()
        {
        }

        public Sequencer_Gow6VG33IYdQWs58olyP8x(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Sequencer_Gow6VG33IYdQWs58olyP8x(Sequencer_Gow6VG33IYdQWs58olyP8x<T> other): base(other)
        {
            this.__p_CB4zY00MCN0MchqsL2ZR8N = other.__p_CB4zY00MCN0MchqsL2ZR8N;
            this.__p_OOFuqkLY1zvMhzusz6PZQY = other.__p_OOFuqkLY1zvMhzusz6PZQY;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CB4zY00MCN0MchqsL2ZR8N", in __p_CB4zY00MCN0MchqsL2ZR8N), n1.CompilationHelper.GetValueOrExisting(values, "__p_OOFuqkLY1zvMhzusz6PZQY", in __p_OOFuqkLY1zvMhzusz6PZQY));
        }

        internal Sequencer_Gow6VG33IYdQWs58olyP8x<T> __WITH__(n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> __p_CB4zY00MCN0MchqsL2ZR8N, n14.Playhead_EQKfVwGC966NC2YT92PjkJ __p_OOFuqkLY1zvMhzusz6PZQY)
        {
            n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_CB4zY00MCN0MchqsL2ZR8N != this.__p_CB4zY00MCN0MchqsL2ZR8N || __p_OOFuqkLY1zvMhzusz6PZQY != this.__p_OOFuqkLY1zvMhzusz6PZQY ? new Sequencer_Gow6VG33IYdQWs58olyP8x<T>(this)
                {__p_CB4zY00MCN0MchqsL2ZR8N = __p_CB4zY00MCN0MchqsL2ZR8N, __p_OOFuqkLY1zvMhzusz6PZQY = __p_OOFuqkLY1zvMhzusz6PZQY} : that_0;
            else
            {
                this.__p_CB4zY00MCN0MchqsL2ZR8N = __p_CB4zY00MCN0MchqsL2ZR8N;
                this.__p_OOFuqkLY1zvMhzusz6PZQY = __p_OOFuqkLY1zvMhzusz6PZQY;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 23131U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "JTJsMOijt7DP1rXh0BfLSa", Name = "Track_JTJsMOijt7DP1rXh0BfLSa")]
    [n2.SerializableAttribute]
    public class Track_JTJsMOijt7DP1rXh0BfLSa<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Track_JTJsMOijt7DP1rXh0BfLSa<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> CreateDefault()
        {
            var instance = new Track_JTJsMOijt7DP1rXh0BfLSa<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> Update<AdM>(T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Clear_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Record_In, bool Initialize_In, n6.Spread<n5.KeyValuePair<float, T>> Initial_Values_In, out n6.Spread<n5.KeyValuePair<float, T>> Keyframes_Out, out float Duration_Out)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<float>
        {
            var w_0 = default(AdM);
            n12.IClock __auto_1 = this.Clock;
            n6.SpreadBuilder<n5.KeyValuePair<float, T>> __auto_2 = this.Spread;
            var Result_3 = n12.Clocks.Seconds(clock: __auto_1);
            var Result_4 = n15.IntegerConversions.ToFloat32(input: Result_3);
            var Output_7 = this.__p_SecIa53DwHiLjqisfdWs2y.Update(Value_In: Record_In, Up_Edge_Out: out bool Up_Edge_5, Down_Edge_Out: out bool Down_Edge_6);
            bool SetValue_8 = true;
            var Output_9 = this.__p_D1KjpEafVEVNsxsTWgdPUp;
            if (SetValue_8)
            {
                Output_9 = this.__p_D1KjpEafVEVNsxsTWgdPUp.SetValue(Value_In: Result_4, Sample_In: Up_Edge_5);
            }

            var Output_11 = Output_9.GetValue(Value_Out: out float Value_10);
            var Output_12 = Result_4 - Value_10;
            var Output_13 = new n5.KeyValuePair<float, T>(key: Output_12, value: Value_In);
            n16._Operations_.ToBuilder<n5.KeyValuePair<float, T>>(Input_In: Initial_Values_In, Result_Out: out n6.SpreadBuilder<n5.KeyValuePair<float, T>> Result_14);
            n17._Operations_.Switch_Boolean<n6.SpreadBuilder<n5.KeyValuePair<float, T>>>(Condition_In: Initialize_In, Input_In: __auto_2, Input_2_In: Result_14, Output_Out: out n6.SpreadBuilder<n5.KeyValuePair<float, T>> Output_15);
            var Output_16 = Clear_In || Up_Edge_5;
            var Output_17 = Output_15;
            if (Output_16)
            {
                n18._Operations_.Clear<n5.KeyValuePair<float, T>>(Input_In: Output_15, Output_Out: out Output_17);
            }

            var Output_18 = Output_17;
            if (Record_In)
            {
                n18._Operations_.Add<n5.KeyValuePair<float, T>>(Input_In: Output_17, Item_In: Output_13, Output_Out: out Output_18);
            }

            n6.SpreadBuilder<n5.KeyValuePair<float, T>> __auto_19 = Output_18;
            var Output_20 = n19._Operations_.CreateDefault<float, T, AdM>();
            n20._Operations_.LastOrDefault<n6.SpreadBuilder<n5.KeyValuePair<float, T>>, n5.KeyValuePair<float, T>>(Input_In: Output_18, Default_Value_In: Output_20, Output_Out: out n6.SpreadBuilder<n5.KeyValuePair<float, T>> Output_21, Result_Out: out n5.KeyValuePair<float, T> Result_22);
            var Key_23 = Result_22.Key;
            n18._Operations_.ToSpread<n5.KeyValuePair<float, T>>(Input_In: Output_18, Output_Out: out n6.SpreadBuilder<n5.KeyValuePair<float, T>> Output_24, Result_Out: out n6.Spread<n5.KeyValuePair<float, T>> Result_25);
            Keyframes_Out = Result_25;
            Duration_Out = Key_23;
            n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = Output_7 != this.__p_SecIa53DwHiLjqisfdWs2y || Output_11 != this.__p_D1KjpEafVEVNsxsTWgdPUp || Output_18 != this.Spread ? new Track_JTJsMOijt7DP1rXh0BfLSa<T>(this)
                {__p_SecIa53DwHiLjqisfdWs2y = Output_7, __p_D1KjpEafVEVNsxsTWgdPUp = Output_11, Spread = Output_18} : that_26;
            else
            {
                this.__p_SecIa53DwHiLjqisfdWs2y = Output_7;
                this.__p_D1KjpEafVEVNsxsTWgdPUp = Output_11;
                this.Spread = Output_18;
            }

            return that_26;
        }

        public n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n12.IClock __auto_0 = Clock_In;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "D1KjpEafVEVNsxsTWgdPUp", 23198U);
            float Initial_Value_2 = 0F;
            var Output_3 = n21.SPH_RESwCzqU3iTMc4Ig82Av03<float>.Create(Node_Context: Node_Context_1, Initial_Value_In: Initial_Value_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "SecIa53DwHiLjqisfdWs2y", 23260U);
            var Output_5 = n21.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> that_6 = this;
            this.Spread = n18._Operations_.CreateDefault<n5.KeyValuePair<float, T>>();
            this.Clock = Clock_In;
            this.__p_D1KjpEafVEVNsxsTWgdPUp = Output_3;
            this.__p_SecIa53DwHiLjqisfdWs2y = Output_5;
            return that_6;
        }

        public n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> __CreateDefault__()
        {
            n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> that_0 = this;
            this.Spread = n18._Operations_.CreateDefault<n5.KeyValuePair<float, T>>();
            this.Clock = n11._Operations_.CreateDefault();
            this.__p_SecIa53DwHiLjqisfdWs2y = n21.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_D1KjpEafVEVNsxsTWgdPUp = n21.SPH_RESwCzqU3iTMc4Ig82Av03<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SecIa53DwHiLjqisfdWs2y);
            n1.CompilationHelper.SafeDispose(this.__p_D1KjpEafVEVNsxsTWgdPUp);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 23136U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Tiu1aeDEffBObNdHMCExmw", Name = "Spread")]
        public n6.SpreadBuilder<n5.KeyValuePair<float, T>> Spread;
        [n1.ElementAttribute(TracingId = 23379U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "B6MfiSQCrgzP5vZZ9rJvsw", Name = "Clock")]
        public n12.IClock Clock;
        [n1.ElementAttribute(TracingId = 23260U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SecIa53DwHiLjqisfdWs2y", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n21.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SecIa53DwHiLjqisfdWs2y;
        [n1.ElementAttribute(TracingId = 23198U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "D1KjpEafVEVNsxsTWgdPUp", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n21.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_D1KjpEafVEVNsxsTWgdPUp;
        public Track_JTJsMOijt7DP1rXh0BfLSa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Track_JTJsMOijt7DP1rXh0BfLSa(Track_JTJsMOijt7DP1rXh0BfLSa<T> other): base(other)
        {
            this.Spread = other.Spread;
            this.Clock = other.Clock;
            this.__p_SecIa53DwHiLjqisfdWs2y = other.__p_SecIa53DwHiLjqisfdWs2y;
            this.__p_D1KjpEafVEVNsxsTWgdPUp = other.__p_D1KjpEafVEVNsxsTWgdPUp;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Spread", in Spread), n1.CompilationHelper.GetValueOrExisting(values, "Clock", in Clock), n1.CompilationHelper.GetValueOrExisting(values, "__p_SecIa53DwHiLjqisfdWs2y", in __p_SecIa53DwHiLjqisfdWs2y), n1.CompilationHelper.GetValueOrExisting(values, "__p_D1KjpEafVEVNsxsTWgdPUp", in __p_D1KjpEafVEVNsxsTWgdPUp));
        }

        internal Track_JTJsMOijt7DP1rXh0BfLSa<T> __WITH__(n6.SpreadBuilder<n5.KeyValuePair<float, T>> Spread, n12.IClock Clock, n21.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SecIa53DwHiLjqisfdWs2y, n21.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_D1KjpEafVEVNsxsTWgdPUp)
        {
            n3.Track_JTJsMOijt7DP1rXh0BfLSa<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Spread != this.Spread || Clock != this.Clock || __p_SecIa53DwHiLjqisfdWs2y != this.__p_SecIa53DwHiLjqisfdWs2y || __p_D1KjpEafVEVNsxsTWgdPUp != this.__p_D1KjpEafVEVNsxsTWgdPUp ? new Track_JTJsMOijt7DP1rXh0BfLSa<T>(this)
                {Spread = Spread, Clock = Clock, __p_SecIa53DwHiLjqisfdWs2y = __p_SecIa53DwHiLjqisfdWs2y, __p_D1KjpEafVEVNsxsTWgdPUp = __p_D1KjpEafVEVNsxsTWgdPUp} : that_0;
            else
            {
                this.Spread = Spread;
                this.Clock = Clock;
                this.__p_SecIa53DwHiLjqisfdWs2y = __p_SecIa53DwHiLjqisfdWs2y;
                this.__p_D1KjpEafVEVNsxsTWgdPUp = __p_D1KjpEafVEVNsxsTWgdPUp;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 27651U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "IdvSxYASvkgOhJLGiNGDdg", Name = "Delay_IdvSxYASvkgOhJLGiNGDdg")]
    [n2.SerializableAttribute]
    public class Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> : n1.VLObject, n2.IDisposable where T3 : n12.IClock
    {
        [n4.CreateNewAttribute]
        public static n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> Create<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var instance = new Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var instance = new Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> Update(T Value_In, bool Insert_In, [n4.SerializedDefaultValueAttribute("1", false)] float Duration_In, T Reset_Value_In, bool Reset_In, out T Output_Out, out int Count_Out)
        {
            n5.Queue<n5.KeyValuePair<double, T>> __auto_0 = this.FIFO;
            n12.IClock __pad_SKALYzeZFhEOZQCfpYDhrz_1 = this.__slot_SKALYzeZFhEOZQCfpYDhrz;
            n5.KeyValuePair<double, T> __auto_2 = this.Prev;
            var Time_3 = __pad_SKALYzeZFhEOZQCfpYDhrz_1.Time;
            var Seconds_4 = Time_3.Seconds;
            n5.Queue<n5.KeyValuePair<double, T>> __auto_5;
            if (Insert_In)
            {
                var Output_7 = new n5.KeyValuePair<double, T>(key: Seconds_4, value: Value_In);
                __auto_0.Enqueue(item: Output_7);
                __auto_5 = __auto_0;
            }
            else
            {
                __auto_5 = __auto_0;
            }

            n5.Queue<n5.KeyValuePair<double, T>> __auto_8;
            n5.KeyValuePair<double, T> __auto_9;
            if (Reset_In)
            {
                __auto_5.Clear();
                var Output_11 = new n5.KeyValuePair<double, T>(key: Seconds_4, value: Reset_Value_In);
                __auto_5.Enqueue(item: Output_11);
                __auto_8 = __auto_5;
                __auto_9 = Output_11;
            }
            else
            {
                __auto_8 = __auto_5;
                __auto_9 = __auto_2;
            }

            var Count_12 = __auto_8.Count;
            double Input_2_13 = (double)Duration_In;
            var Output_14 = Seconds_4 - Input_2_13;
            n5.Queue<n5.KeyValuePair<double, T>> accumulator_16 = __auto_8;
            n5.KeyValuePair<double, T> accumulator_17 = __auto_9;
            for (var i_15 = 0; i_15 < Count_12; i_15++)
            {
                var i_local_18 = i_15;
                var Result_20 = accumulator_16.Peek();
                var Key_21 = Result_20.Key;
                var Result_22 = Key_21 >= Output_14;
                var Output_23 = !Result_22;
                n5.Queue<n5.KeyValuePair<double, T>> __auto_24;
                if (Output_23)
                {
                    var Result_26 = accumulator_16.Dequeue();
                    __auto_24 = accumulator_16;
                }
                else
                {
                    __auto_24 = accumulator_16;
                }

                var Result_27 = Key_21 <= Output_14;
                n17._Operations_.Switch_Boolean<n5.KeyValuePair<double, T>>(Condition_In: Result_27, Input_In: accumulator_17, Input_2_In: Result_20, Output_Out: out n5.KeyValuePair<double, T> Output_28);
                accumulator_16 = __auto_24;
                accumulator_17 = Output_28;
                if (Result_22)
                {
                    break;
                }
            }

            n5.Queue<n5.KeyValuePair<double, T>> __auto_29 = accumulator_16;
            n5.KeyValuePair<double, T> __auto_30 = accumulator_17;
            var Value_31 = __auto_30.Value;
            Output_Out = Value_31;
            Count_Out = Count_12;
            n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = accumulator_16 != this.FIFO || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(accumulator_17, this.Prev) ? new Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3>(this)
                {FIFO = accumulator_16, Prev = accumulator_17} : that_32;
            else
            {
                this.FIFO = accumulator_16;
                this.Prev = accumulator_17;
            }

            return that_32;
        }

        public n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> SetClock<T2>(T2 New_Clock_In)
            where T2 : n12.IClock
        {
            n12.IClock __pad_SKALYzeZFhEOZQCfpYDhrz_0 = (n12.IClock)New_Clock_In;
            n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = (n12.IClock)New_Clock_In != this.__slot_SKALYzeZFhEOZQCfpYDhrz ? new Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3>(this)
                {__slot_SKALYzeZFhEOZQCfpYDhrz = (n12.IClock)New_Clock_In} : that_1;
            else
            {
                this.__slot_SKALYzeZFhEOZQCfpYDhrz = (n12.IClock)New_Clock_In;
            }

            return that_1;
        }

        public n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> __Create__<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n12.IClock __pad_SKALYzeZFhEOZQCfpYDhrz_1 = (n12.IClock)Clock_In;
            var Output_2 = new n5.Queue<n5.KeyValuePair<double, T>>();
            n5.Queue<n5.KeyValuePair<double, T>> __auto_3 = Output_2;
            n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> that_4 = this;
            this.__slot_SKALYzeZFhEOZQCfpYDhrz = (n12.IClock)Clock_In;
            this.FIFO = Output_2;
            this.Prev = n19._Operations_.CreateDefault<double, T, AdM>();
            return that_4;
        }

        public n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var w_0 = default(AdM);
            n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> that_1 = this;
            this.__slot_SKALYzeZFhEOZQCfpYDhrz = n11._Operations_.CreateDefault();
            this.FIFO = n22._Operations_.CreateDefault<n5.KeyValuePair<double, T>>();
            this.Prev = n19._Operations_.CreateDefault<double, T, AdM>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 27797U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SKALYzeZFhEOZQCfpYDhrz", Name = "__slot_SKALYzeZFhEOZQCfpYDhrz")]
        public n12.IClock __slot_SKALYzeZFhEOZQCfpYDhrz;
        [n1.ElementAttribute(TracingId = 27660U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Lz7Asho6xQOOQ1cOT7dfp6", Name = "FIFO")]
        public n5.Queue<n5.KeyValuePair<double, T>> FIFO;
        [n1.ElementAttribute(TracingId = 27782U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "TSv8aqrpv9dN4arWanhJUR", Name = "Prev")]
        public n5.KeyValuePair<double, T> Prev;
        public Delay_IdvSxYASvkgOhJLGiNGDdg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Delay_IdvSxYASvkgOhJLGiNGDdg(Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> other): base(other)
        {
            this.__slot_SKALYzeZFhEOZQCfpYDhrz = other.__slot_SKALYzeZFhEOZQCfpYDhrz;
            this.FIFO = other.FIFO;
            this.Prev = other.Prev;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_SKALYzeZFhEOZQCfpYDhrz", in __slot_SKALYzeZFhEOZQCfpYDhrz), n1.CompilationHelper.GetValueOrExisting(values, "FIFO", in FIFO), n1.CompilationHelper.GetValueOrExisting(values, "Prev", in Prev));
        }

        internal Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> __WITH__(n12.IClock __slot_SKALYzeZFhEOZQCfpYDhrz, n5.Queue<n5.KeyValuePair<double, T>> FIFO, n5.KeyValuePair<double, T> Prev)
        {
            n3.Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_SKALYzeZFhEOZQCfpYDhrz != this.__slot_SKALYzeZFhEOZQCfpYDhrz || FIFO != this.FIFO || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(Prev, this.Prev) ? new Delay_IdvSxYASvkgOhJLGiNGDdg<T, T3>(this)
                {__slot_SKALYzeZFhEOZQCfpYDhrz = __slot_SKALYzeZFhEOZQCfpYDhrz, FIFO = FIFO, Prev = Prev} : that_0;
            else
            {
                this.__slot_SKALYzeZFhEOZQCfpYDhrz = __slot_SKALYzeZFhEOZQCfpYDhrz;
                this.FIFO = FIFO;
                this.Prev = Prev;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 28160U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "QCyUM9b0UOjLhRjcdjQMmm", Name = "Recorder_QCyUM9b0UOjLhRjcdjQMmm")]
    [n2.SerializableAttribute]
    public class Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Recorder_QCyUM9b0UOjLhRjcdjQMmm<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> CreateDefault()
        {
            var instance = new Recorder_QCyUM9b0UOjLhRjcdjQMmm<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> Update<AdM>(T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Clear_In, [n4.SerializedDefaultValueAttribute("1", false)] float Speed_In, bool Seek_In, float Seek_Time_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Record_In, bool Play_In, n31.Path File_Path_In, bool Save_In, bool Load_In, out T Value_Out, out float Duration_Out, out float Position_Out, out bool Loading_Completed_Out, out bool Loading_Progress_Out)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorGreater<float>, n9.IAdaptiveOperatorLess<float>, n9.IAdaptiveOperatorLessThan<float>, n9.IAdaptiveLerp<T>, n9.IAdaptiveOperatorGreaterThan<float>, n8.IAdaptiveCreateDefault<float>
        {
            var w_0 = default(AdM);
            var State_Output_4 = this.__p_AnQ6aqk9RSTPz9gEWpb0wV.Update(File_Path_In: File_Path_In, Read_In: Load_In, Output_Out: out n2.IObservable<n23.XElement> Output_1, In_Progress_Out: out bool In_Progress_2, On_Completed_Out: out bool On_Completed_3);
            bool Reset_5 = false;
            var __fallback___6 = n1.ServiceRegistry.Current;
            n26._Operations_.Update_H<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>>(Input_In: this.__p_SfrtGHpYfYOOFZhPPemQaY, Messages_In: Output_1, Reset_In: Reset_5, Update_In: (n2.Object s_9, n23.XElement Input_1_In_10) =>
            {
                using var __current_7 = __fallback___6.MakeCurrentIfNone();
                var state_8 = n1.CompilationHelper.Restore<__L36ifaDEQ7xL0UsAaX6odz>(s_9, __GetContext__());
                n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "KTRG5I0OH6IMJV1Wbh6Xqc", 28225U);
                n24._Operations_.Deserialize<n6.Spread<n5.KeyValuePair<float, T>>>(Content_In: Input_1_In_10, Node_Context_In: Node_Context_11, Result_Out: out n6.Spread<n5.KeyValuePair<float, T>> Result_12);
                return n2.Tuple.Create<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>>(state_8, Result_12);
            }

            , Create_In: () =>
            {
                using var __current_13 = __fallback___6.MakeCurrentIfNone();
                var state_8 = new __L36ifaDEQ7xL0UsAaX6odz(__GetContext__(), n1.VLObject.NewIdentity());
                return state_8;
            }

            , Output_Out: out n25.ForEach<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>> Output_14, Result_Out: out n2.IObservable<n6.Spread<n5.KeyValuePair<float, T>>> Result_15);
            bool Reset_16 = false;
            bool Update_17 = true;
            var Output_18 = this.__p_CAYupLWSx9POHqrxtQWUhn;
            if (Update_17)
            {
                n27._Operations_.Update_H<n6.Spread<n5.KeyValuePair<float, T>>>(Input_In: this.__p_CAYupLWSx9POHqrxtQWUhn, Async_Notifications_In: Result_15, Reset_In: Reset_16, Output_Out: out Output_18);
            }

            n27._Operations_.GetData_H<n6.Spread<n5.KeyValuePair<float, T>>>(Input_In: Output_18, Output_Out: out n25.HoldLatest<n6.Spread<n5.KeyValuePair<float, T>>> Output_19, Value_Out: out n6.Spread<n5.KeyValuePair<float, T>> Value_20, On_Data_Out: out bool On_Data_21);
            var Output_26 = this.__p_LcZvYUPYYf3PUIzcPdjpOk.Update<AdM>(Value_In: Value_In, Initial_Values_In: Value_20, Initialize_In: On_Data_21, Clear_In: Clear_In, Speed_In: Speed_In, Seek_In: Seek_In, Seek_Time_In: Seek_Time_In, Record_In: Record_In, Play_In: Play_In, Value_Out: out T Value_22, Keyframes_Out: out n6.Spread<n5.KeyValuePair<float, T>> Keyframes_23, Duration_Out: out float Duration_24, Position_Out: out float Position_25);
            n28._Operations_.Update_H<n6.Spread<n5.KeyValuePair<float, T>>>(Input_In: this.__p_PbylKAbWHZaP9i72RB6848, Message_In: Keyframes_23, Send_In: Save_In, Output_Out: out n25.ToObservable<n6.Spread<n5.KeyValuePair<float, T>>> Output_27, Result_Out: out n2.IObservable<n6.Spread<n5.KeyValuePair<float, T>>> Result_28);
            bool Reset_29 = false;
            n26._Operations_.Update_H<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement>(Input_In: this.__p_TOV5rjcPbXbM3uYcJYjgBx, Messages_In: Result_28, Reset_In: Reset_29, Update_In: (n2.Object s_32, n6.Spread<n5.KeyValuePair<float, T>> Input_1_In_33) =>
            {
                using var __current_30 = __fallback___6.MakeCurrentIfNone();
                var state_31 = n1.CompilationHelper.Restore<__N4C01oVBBf4PhWfj4ynYw5>(s_32, __GetContext__());
                n5.IEnumerable<n5.KeyValuePair<float, T>> Input_34 = (n5.IEnumerable<n5.KeyValuePair<float, T>>)Input_1_In_33;
                n30._Operations_.FromSequence_KeyValuePair<float, T>(Input_In: Input_34, Result_Out: out n29.ImmutableDictionary<float, T> Result_35);
                n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "FasHucDHpl1N9MoP1pGvjD", 28322U);
                bool Include_Defaults_37 = false;
                n24._Operations_.Serialize<n29.ImmutableDictionary<float, T>>(Value_In: Result_35, Node_Context_In: Node_Context_36, Include_Defaults_In: Include_Defaults_37, Result_Out: out n23.XElement Result_38);
                return n2.Tuple.Create<n2.Object, n23.XElement>(state_31, Result_38);
            }

            , Create_In: () =>
            {
                using var __current_39 = __fallback___6.MakeCurrentIfNone();
                var state_31 = new __N4C01oVBBf4PhWfj4ynYw5(__GetContext__(), n1.VLObject.NewIdentity());
                return state_31;
            }

            , Output_Out: out n25.ForEach<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement> Output_40, Result_Out: out n2.IObservable<n23.XElement> Result_41);
            var Output_44 = this.__p_Eh1r2tQAYjKMcOt1xxj1rt.Update(File_Path_In: File_Path_In, Data_In: Result_41, In_Progress_Out: out bool In_Progress_42, OnCompleted_Out: out bool OnCompleted_43);
            Value_Out = Value_22;
            Duration_Out = Duration_24;
            Position_Out = Position_25;
            Loading_Completed_Out = OnCompleted_43;
            Loading_Progress_Out = In_Progress_42;
            n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> that_45 = this;
            if (this.__GetContext__().IsImmutable)
                that_45 = State_Output_4 != this.__p_AnQ6aqk9RSTPz9gEWpb0wV || Output_14 != this.__p_SfrtGHpYfYOOFZhPPemQaY || Output_19 != this.__p_CAYupLWSx9POHqrxtQWUhn || Output_26 != this.__p_LcZvYUPYYf3PUIzcPdjpOk || Output_27 != this.__p_PbylKAbWHZaP9i72RB6848 || Output_40 != this.__p_TOV5rjcPbXbM3uYcJYjgBx || Output_44 != this.__p_Eh1r2tQAYjKMcOt1xxj1rt ? new Recorder_QCyUM9b0UOjLhRjcdjQMmm<T>(this)
                {__p_AnQ6aqk9RSTPz9gEWpb0wV = State_Output_4, __p_SfrtGHpYfYOOFZhPPemQaY = Output_14, __p_CAYupLWSx9POHqrxtQWUhn = Output_19, __p_LcZvYUPYYf3PUIzcPdjpOk = Output_26, __p_PbylKAbWHZaP9i72RB6848 = Output_27, __p_TOV5rjcPbXbM3uYcJYjgBx = Output_40, __p_Eh1r2tQAYjKMcOt1xxj1rt = Output_44} : that_45;
            else
            {
                this.__p_AnQ6aqk9RSTPz9gEWpb0wV = State_Output_4;
                this.__p_SfrtGHpYfYOOFZhPPemQaY = Output_14;
                this.__p_CAYupLWSx9POHqrxtQWUhn = Output_19;
                this.__p_LcZvYUPYYf3PUIzcPdjpOk = Output_26;
                this.__p_PbylKAbWHZaP9i72RB6848 = Output_27;
                this.__p_TOV5rjcPbXbM3uYcJYjgBx = Output_40;
                this.__p_Eh1r2tQAYjKMcOt1xxj1rt = Output_44;
            }

            return that_45;
        }

        public n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "LcZvYUPYYf3PUIzcPdjpOk", 28165U);
            var Output_1 = n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "AnQ6aqk9RSTPz9gEWpb0wV", 28193U);
            var Output_3 = n32.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "SfrtGHpYfYOOFZhPPemQaY", 28207U);
            n26._Operations_.Create_H<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>>(Node_Context: Node_Context_4, Output_Out: out n25.ForEach<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>> Output_5);
            var Empty_6 = n16._Operations_.CreateDefault<n5.KeyValuePair<float, T>>();
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "CAYupLWSx9POHqrxtQWUhn", 28239U);
            n27._Operations_.Create_H<n6.Spread<n5.KeyValuePair<float, T>>>(Node_Context: Node_Context_7, Initial_Result_In: Empty_6, Output_Out: out n25.HoldLatest<n6.Spread<n5.KeyValuePair<float, T>>> Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "PbylKAbWHZaP9i72RB6848", 28266U);
            n28._Operations_.Create_H<n6.Spread<n5.KeyValuePair<float, T>>>(Node_Context: Node_Context_9, Output_Out: out n25.ToObservable<n6.Spread<n5.KeyValuePair<float, T>>> Output_10);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "Eh1r2tQAYjKMcOt1xxj1rt", 28285U);
            var Output_12 = n32.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd.Create(Node_Context: Node_Context_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "TOV5rjcPbXbM3uYcJYjgBx", 28299U);
            n26._Operations_.Create_H<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement>(Node_Context: Node_Context_13, Output_Out: out n25.ForEach<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement> Output_14);
            n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> that_15 = this;
            this.__p_LcZvYUPYYf3PUIzcPdjpOk = Output_1;
            this.__p_AnQ6aqk9RSTPz9gEWpb0wV = Output_3;
            this.__p_SfrtGHpYfYOOFZhPPemQaY = Output_5;
            this.__p_CAYupLWSx9POHqrxtQWUhn = Output_8;
            this.__p_PbylKAbWHZaP9i72RB6848 = Output_10;
            this.__p_Eh1r2tQAYjKMcOt1xxj1rt = Output_12;
            this.__p_TOV5rjcPbXbM3uYcJYjgBx = Output_14;
            return that_15;
        }

        public n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> __CreateDefault__()
        {
            n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> that_0 = this;
            this.__p_AnQ6aqk9RSTPz9gEWpb0wV = n32.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2.CreateDefault();
            this.__p_SfrtGHpYfYOOFZhPPemQaY = default(n25.ForEach<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>>);
            this.__p_CAYupLWSx9POHqrxtQWUhn = default(n25.HoldLatest<n6.Spread<n5.KeyValuePair<float, T>>>);
            this.__p_LcZvYUPYYf3PUIzcPdjpOk = n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T>.CreateDefault();
            this.__p_PbylKAbWHZaP9i72RB6848 = default(n25.ToObservable<n6.Spread<n5.KeyValuePair<float, T>>>);
            this.__p_TOV5rjcPbXbM3uYcJYjgBx = default(n25.ForEach<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement>);
            this.__p_Eh1r2tQAYjKMcOt1xxj1rt = n32.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AnQ6aqk9RSTPz9gEWpb0wV);
            n1.CompilationHelper.SafeDispose(this.__p_SfrtGHpYfYOOFZhPPemQaY);
            n1.CompilationHelper.SafeDispose(this.__p_CAYupLWSx9POHqrxtQWUhn);
            n1.CompilationHelper.SafeDispose(this.__p_LcZvYUPYYf3PUIzcPdjpOk);
            n1.CompilationHelper.SafeDispose(this.__p_PbylKAbWHZaP9i72RB6848);
            n1.CompilationHelper.SafeDispose(this.__p_TOV5rjcPbXbM3uYcJYjgBx);
            n1.CompilationHelper.SafeDispose(this.__p_Eh1r2tQAYjKMcOt1xxj1rt);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 28193U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "AnQ6aqk9RSTPz9gEWpb0wV", Name = "XMLReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n32.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 __p_AnQ6aqk9RSTPz9gEWpb0wV;
        [n1.ElementAttribute(TracingId = 28207U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SfrtGHpYfYOOFZhPPemQaY", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n25.ForEach<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>> __p_SfrtGHpYfYOOFZhPPemQaY;
        [n1.ElementAttribute(TracingId = 28239U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "CAYupLWSx9POHqrxtQWUhn", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n25.HoldLatest<n6.Spread<n5.KeyValuePair<float, T>>> __p_CAYupLWSx9POHqrxtQWUhn;
        [n1.ElementAttribute(TracingId = 28165U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "LcZvYUPYYf3PUIzcPdjpOk", Name = "Sequencer", IsManaged = true, IsAutoGenerated = true)]
        public n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> __p_LcZvYUPYYf3PUIzcPdjpOk;
        [n1.ElementAttribute(TracingId = 28266U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "PbylKAbWHZaP9i72RB6848", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n25.ToObservable<n6.Spread<n5.KeyValuePair<float, T>>> __p_PbylKAbWHZaP9i72RB6848;
        [n1.ElementAttribute(TracingId = 28299U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "TOV5rjcPbXbM3uYcJYjgBx", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n25.ForEach<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement> __p_TOV5rjcPbXbM3uYcJYjgBx;
        [n1.ElementAttribute(TracingId = 28285U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Eh1r2tQAYjKMcOt1xxj1rt", Name = "XMLWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n32.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd __p_Eh1r2tQAYjKMcOt1xxj1rt;
        public Recorder_QCyUM9b0UOjLhRjcdjQMmm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Recorder_QCyUM9b0UOjLhRjcdjQMmm(Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> other): base(other)
        {
            this.__p_AnQ6aqk9RSTPz9gEWpb0wV = other.__p_AnQ6aqk9RSTPz9gEWpb0wV;
            this.__p_SfrtGHpYfYOOFZhPPemQaY = other.__p_SfrtGHpYfYOOFZhPPemQaY;
            this.__p_CAYupLWSx9POHqrxtQWUhn = other.__p_CAYupLWSx9POHqrxtQWUhn;
            this.__p_LcZvYUPYYf3PUIzcPdjpOk = other.__p_LcZvYUPYYf3PUIzcPdjpOk;
            this.__p_PbylKAbWHZaP9i72RB6848 = other.__p_PbylKAbWHZaP9i72RB6848;
            this.__p_TOV5rjcPbXbM3uYcJYjgBx = other.__p_TOV5rjcPbXbM3uYcJYjgBx;
            this.__p_Eh1r2tQAYjKMcOt1xxj1rt = other.__p_Eh1r2tQAYjKMcOt1xxj1rt;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AnQ6aqk9RSTPz9gEWpb0wV", in __p_AnQ6aqk9RSTPz9gEWpb0wV), n1.CompilationHelper.GetValueOrExisting(values, "__p_SfrtGHpYfYOOFZhPPemQaY", in __p_SfrtGHpYfYOOFZhPPemQaY), n1.CompilationHelper.GetValueOrExisting(values, "__p_CAYupLWSx9POHqrxtQWUhn", in __p_CAYupLWSx9POHqrxtQWUhn), n1.CompilationHelper.GetValueOrExisting(values, "__p_LcZvYUPYYf3PUIzcPdjpOk", in __p_LcZvYUPYYf3PUIzcPdjpOk), n1.CompilationHelper.GetValueOrExisting(values, "__p_PbylKAbWHZaP9i72RB6848", in __p_PbylKAbWHZaP9i72RB6848), n1.CompilationHelper.GetValueOrExisting(values, "__p_TOV5rjcPbXbM3uYcJYjgBx", in __p_TOV5rjcPbXbM3uYcJYjgBx), n1.CompilationHelper.GetValueOrExisting(values, "__p_Eh1r2tQAYjKMcOt1xxj1rt", in __p_Eh1r2tQAYjKMcOt1xxj1rt));
        }

        internal Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> __WITH__(n32.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 __p_AnQ6aqk9RSTPz9gEWpb0wV, n25.ForEach<n2.Object, n23.XElement, n6.Spread<n5.KeyValuePair<float, T>>> __p_SfrtGHpYfYOOFZhPPemQaY, n25.HoldLatest<n6.Spread<n5.KeyValuePair<float, T>>> __p_CAYupLWSx9POHqrxtQWUhn, n3.Sequencer_Gow6VG33IYdQWs58olyP8x<T> __p_LcZvYUPYYf3PUIzcPdjpOk, n25.ToObservable<n6.Spread<n5.KeyValuePair<float, T>>> __p_PbylKAbWHZaP9i72RB6848, n25.ForEach<n2.Object, n6.Spread<n5.KeyValuePair<float, T>>, n23.XElement> __p_TOV5rjcPbXbM3uYcJYjgBx, n32.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd __p_Eh1r2tQAYjKMcOt1xxj1rt)
        {
            n3.Recorder_QCyUM9b0UOjLhRjcdjQMmm<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AnQ6aqk9RSTPz9gEWpb0wV != this.__p_AnQ6aqk9RSTPz9gEWpb0wV || __p_SfrtGHpYfYOOFZhPPemQaY != this.__p_SfrtGHpYfYOOFZhPPemQaY || __p_CAYupLWSx9POHqrxtQWUhn != this.__p_CAYupLWSx9POHqrxtQWUhn || __p_LcZvYUPYYf3PUIzcPdjpOk != this.__p_LcZvYUPYYf3PUIzcPdjpOk || __p_PbylKAbWHZaP9i72RB6848 != this.__p_PbylKAbWHZaP9i72RB6848 || __p_TOV5rjcPbXbM3uYcJYjgBx != this.__p_TOV5rjcPbXbM3uYcJYjgBx || __p_Eh1r2tQAYjKMcOt1xxj1rt != this.__p_Eh1r2tQAYjKMcOt1xxj1rt ? new Recorder_QCyUM9b0UOjLhRjcdjQMmm<T>(this)
                {__p_AnQ6aqk9RSTPz9gEWpb0wV = __p_AnQ6aqk9RSTPz9gEWpb0wV, __p_SfrtGHpYfYOOFZhPPemQaY = __p_SfrtGHpYfYOOFZhPPemQaY, __p_CAYupLWSx9POHqrxtQWUhn = __p_CAYupLWSx9POHqrxtQWUhn, __p_LcZvYUPYYf3PUIzcPdjpOk = __p_LcZvYUPYYf3PUIzcPdjpOk, __p_PbylKAbWHZaP9i72RB6848 = __p_PbylKAbWHZaP9i72RB6848, __p_TOV5rjcPbXbM3uYcJYjgBx = __p_TOV5rjcPbXbM3uYcJYjgBx, __p_Eh1r2tQAYjKMcOt1xxj1rt = __p_Eh1r2tQAYjKMcOt1xxj1rt} : that_0;
            else
            {
                this.__p_AnQ6aqk9RSTPz9gEWpb0wV = __p_AnQ6aqk9RSTPz9gEWpb0wV;
                this.__p_SfrtGHpYfYOOFZhPPemQaY = __p_SfrtGHpYfYOOFZhPPemQaY;
                this.__p_CAYupLWSx9POHqrxtQWUhn = __p_CAYupLWSx9POHqrxtQWUhn;
                this.__p_LcZvYUPYYf3PUIzcPdjpOk = __p_LcZvYUPYYf3PUIzcPdjpOk;
                this.__p_PbylKAbWHZaP9i72RB6848 = __p_PbylKAbWHZaP9i72RB6848;
                this.__p_TOV5rjcPbXbM3uYcJYjgBx = __p_TOV5rjcPbXbM3uYcJYjgBx;
                this.__p_Eh1r2tQAYjKMcOt1xxj1rt = __p_Eh1r2tQAYjKMcOt1xxj1rt;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "L36ifaDEQ7xL0UsAaX6odz", Name = "__L36ifaDEQ7xL0UsAaX6odz")]
        [n2.SerializableAttribute]
        public class __L36ifaDEQ7xL0UsAaX6odz : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __L36ifaDEQ7xL0UsAaX6odz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __L36ifaDEQ7xL0UsAaX6odz(__L36ifaDEQ7xL0UsAaX6odz other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __L36ifaDEQ7xL0UsAaX6odz __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "N4C01oVBBf4PhWfj4ynYw5", Name = "__N4C01oVBBf4PhWfj4ynYw5")]
        [n2.SerializableAttribute]
        public class __N4C01oVBBf4PhWfj4ynYw5 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __N4C01oVBBf4PhWfj4ynYw5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __N4C01oVBBf4PhWfj4ynYw5(__N4C01oVBBf4PhWfj4ynYw5 other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __N4C01oVBBf4PhWfj4ynYw5 __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 46719U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Qhw7aQNplhrMCum2sxpG8z", Name = "Damper_Qhw7aQNplhrMCum2sxpG8z")]
    [n2.SerializableAttribute]
    public class Damper_Qhw7aQNplhrMCum2sxpG8z : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Damper_Qhw7aQNplhrMCum2sxpG8z Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Damper_Qhw7aQNplhrMCum2sxpG8z(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Damper_Qhw7aQNplhrMCum2sxpG8z CreateDefault()
        {
            var instance = new Damper_Qhw7aQNplhrMCum2sxpG8z(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Damper_Qhw7aQNplhrMCum2sxpG8z Update(float Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out float Position_Out, out float Velocity_Out, out float Acceleration_Out, out n33.OscillatorFunction_C<float> Function_Out)
        {
            float __pad_KESRiUW7jHGPfLO69bvXIE_0 = __slot_KESRiUW7jHGPfLO69bvXIE;
            var Output_5 = this.__p_IiHwshcbrDdOT81RPyIzTu.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: __pad_KESRiUW7jHGPfLO69bvXIE_0, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out float Position_1, Velocity_Out: out float Velocity_2, Acceleration_Out: out float Acceleration_3, Function_Out: out n33.OscillatorFunction_C<float> Function_4);
            Position_Out = Position_1;
            Velocity_Out = Velocity_2;
            Acceleration_Out = Acceleration_3;
            Function_Out = Function_4;
            n3.Damper_Qhw7aQNplhrMCum2sxpG8z that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_IiHwshcbrDdOT81RPyIzTu ? new Damper_Qhw7aQNplhrMCum2sxpG8z(this)
                {__p_IiHwshcbrDdOT81RPyIzTu = Output_5} : that_6;
            else
            {
                this.__p_IiHwshcbrDdOT81RPyIzTu = Output_5;
            }

            return that_6;
        }

        public n3.Damper_Qhw7aQNplhrMCum2sxpG8z SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_IiHwshcbrDdOT81RPyIzTu;
            if (SetClock_0)
            {
                Output_1 = this.__p_IiHwshcbrDdOT81RPyIzTu.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Damper_Qhw7aQNplhrMCum2sxpG8z that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_IiHwshcbrDdOT81RPyIzTu ? new Damper_Qhw7aQNplhrMCum2sxpG8z(this)
                {__p_IiHwshcbrDdOT81RPyIzTu = Output_1} : that_2;
            else
            {
                this.__p_IiHwshcbrDdOT81RPyIzTu = Output_1;
            }

            return that_2;
        }

        public n3.Damper_Qhw7aQNplhrMCum2sxpG8z __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "IiHwshcbrDdOT81RPyIzTu", 46725U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Damper_Qhw7aQNplhrMCum2sxpG8z that_2 = this;
            this.__p_IiHwshcbrDdOT81RPyIzTu = Output_1;
            return that_2;
        }

        public n3.Damper_Qhw7aQNplhrMCum2sxpG8z __CreateDefault__()
        {
            n3.Damper_Qhw7aQNplhrMCum2sxpG8z that_0 = this;
            this.__p_IiHwshcbrDdOT81RPyIzTu = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IiHwshcbrDdOT81RPyIzTu);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 47568U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KESRiUW7jHGPfLO69bvXIE", Name = "__slot_KESRiUW7jHGPfLO69bvXIE")]
        public static float __slot_KESRiUW7jHGPfLO69bvXIE = 0F;
        [n1.ElementAttribute(TracingId = 46725U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "IiHwshcbrDdOT81RPyIzTu", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float> __p_IiHwshcbrDdOT81RPyIzTu;
        static Damper_Qhw7aQNplhrMCum2sxpG8z()
        {
        }

        public Damper_Qhw7aQNplhrMCum2sxpG8z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Damper_Qhw7aQNplhrMCum2sxpG8z(Damper_Qhw7aQNplhrMCum2sxpG8z other): base(other)
        {
            this.__p_IiHwshcbrDdOT81RPyIzTu = other.__p_IiHwshcbrDdOT81RPyIzTu;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IiHwshcbrDdOT81RPyIzTu", in __p_IiHwshcbrDdOT81RPyIzTu));
        }

        internal Damper_Qhw7aQNplhrMCum2sxpG8z __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float> __p_IiHwshcbrDdOT81RPyIzTu)
        {
            n3.Damper_Qhw7aQNplhrMCum2sxpG8z that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IiHwshcbrDdOT81RPyIzTu != this.__p_IiHwshcbrDdOT81RPyIzTu ? new Damper_Qhw7aQNplhrMCum2sxpG8z(this)
                {__p_IiHwshcbrDdOT81RPyIzTu = __p_IiHwshcbrDdOT81RPyIzTu} : that_0;
            else
            {
                this.__p_IiHwshcbrDdOT81RPyIzTu = __p_IiHwshcbrDdOT81RPyIzTu;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 47698U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SSikkhLCtlgLWqNuUJ8Odr", Name = "Damper__2D_SSikkhLCtlgLWqNuUJ8Odr")]
    [n2.SerializableAttribute]
    public class Damper__2D_SSikkhLCtlgLWqNuUJ8Odr : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr CreateDefault()
        {
            var instance = new Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr Update(n36.Vector2 Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out n36.Vector2 Position_Out, out n36.Vector2 Velocity_Out, out n36.Vector2 Acceleration_Out, out n33.OscillatorFunction_C<n36.Vector2> Function_Out)
        {
            float __pad_VTFpUcwVYKeLE0IbdZyVu6_0 = __slot_VTFpUcwVYKeLE0IbdZyVu6;
            var Output_5 = this.__p_MoqDhyHH8TFO28HdwPhToB.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: __pad_VTFpUcwVYKeLE0IbdZyVu6_0, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out n36.Vector2 Position_1, Velocity_Out: out n36.Vector2 Velocity_2, Acceleration_Out: out n36.Vector2 Acceleration_3, Function_Out: out n33.OscillatorFunction_C<n36.Vector2> Function_4);
            Position_Out = Position_1;
            Velocity_Out = Velocity_2;
            Acceleration_Out = Acceleration_3;
            Function_Out = Function_4;
            n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_MoqDhyHH8TFO28HdwPhToB ? new Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(this)
                {__p_MoqDhyHH8TFO28HdwPhToB = Output_5} : that_6;
            else
            {
                this.__p_MoqDhyHH8TFO28HdwPhToB = Output_5;
            }

            return that_6;
        }

        public n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_MoqDhyHH8TFO28HdwPhToB;
            if (SetClock_0)
            {
                Output_1 = this.__p_MoqDhyHH8TFO28HdwPhToB.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_MoqDhyHH8TFO28HdwPhToB ? new Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(this)
                {__p_MoqDhyHH8TFO28HdwPhToB = Output_1} : that_2;
            else
            {
                this.__p_MoqDhyHH8TFO28HdwPhToB = Output_1;
            }

            return that_2;
        }

        public n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "MoqDhyHH8TFO28HdwPhToB", 47703U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr that_2 = this;
            this.__p_MoqDhyHH8TFO28HdwPhToB = Output_1;
            return that_2;
        }

        public n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr __CreateDefault__()
        {
            n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr that_0 = this;
            this.__p_MoqDhyHH8TFO28HdwPhToB = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MoqDhyHH8TFO28HdwPhToB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 47738U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "VTFpUcwVYKeLE0IbdZyVu6", Name = "__slot_VTFpUcwVYKeLE0IbdZyVu6")]
        public static float __slot_VTFpUcwVYKeLE0IbdZyVu6 = 0F;
        [n1.ElementAttribute(TracingId = 47703U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "MoqDhyHH8TFO28HdwPhToB", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2> __p_MoqDhyHH8TFO28HdwPhToB;
        static Damper__2D_SSikkhLCtlgLWqNuUJ8Odr()
        {
        }

        public Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(Damper__2D_SSikkhLCtlgLWqNuUJ8Odr other): base(other)
        {
            this.__p_MoqDhyHH8TFO28HdwPhToB = other.__p_MoqDhyHH8TFO28HdwPhToB;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MoqDhyHH8TFO28HdwPhToB", in __p_MoqDhyHH8TFO28HdwPhToB));
        }

        internal Damper__2D_SSikkhLCtlgLWqNuUJ8Odr __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2> __p_MoqDhyHH8TFO28HdwPhToB)
        {
            n3.Damper__2D_SSikkhLCtlgLWqNuUJ8Odr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_MoqDhyHH8TFO28HdwPhToB != this.__p_MoqDhyHH8TFO28HdwPhToB ? new Damper__2D_SSikkhLCtlgLWqNuUJ8Odr(this)
                {__p_MoqDhyHH8TFO28HdwPhToB = __p_MoqDhyHH8TFO28HdwPhToB} : that_0;
            else
            {
                this.__p_MoqDhyHH8TFO28HdwPhToB = __p_MoqDhyHH8TFO28HdwPhToB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 47864U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Q7f7FmZqnvOOvqWrXqfeOx", Name = "Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx")]
    [n2.SerializableAttribute]
    public class Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx CreateDefault()
        {
            var instance = new Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx Update(n36.Vector3 Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out n36.Vector3 Position_Out, out n36.Vector3 Velocity_Out, out n36.Vector3 Acceleration_Out, out n33.OscillatorFunction_C<n36.Vector3> Function_Out)
        {
            float __pad_KkIiBNfYeMRN5OZz9mRl2j_0 = __slot_KkIiBNfYeMRN5OZz9mRl2j;
            var Output_5 = this.__p_NdnjEIGZyJ7POaTNbIzHkO.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: __pad_KkIiBNfYeMRN5OZz9mRl2j_0, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out n36.Vector3 Position_1, Velocity_Out: out n36.Vector3 Velocity_2, Acceleration_Out: out n36.Vector3 Acceleration_3, Function_Out: out n33.OscillatorFunction_C<n36.Vector3> Function_4);
            Position_Out = Position_1;
            Velocity_Out = Velocity_2;
            Acceleration_Out = Acceleration_3;
            Function_Out = Function_4;
            n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_NdnjEIGZyJ7POaTNbIzHkO ? new Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(this)
                {__p_NdnjEIGZyJ7POaTNbIzHkO = Output_5} : that_6;
            else
            {
                this.__p_NdnjEIGZyJ7POaTNbIzHkO = Output_5;
            }

            return that_6;
        }

        public n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_NdnjEIGZyJ7POaTNbIzHkO;
            if (SetClock_0)
            {
                Output_1 = this.__p_NdnjEIGZyJ7POaTNbIzHkO.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_NdnjEIGZyJ7POaTNbIzHkO ? new Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(this)
                {__p_NdnjEIGZyJ7POaTNbIzHkO = Output_1} : that_2;
            else
            {
                this.__p_NdnjEIGZyJ7POaTNbIzHkO = Output_1;
            }

            return that_2;
        }

        public n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "NdnjEIGZyJ7POaTNbIzHkO", 47871U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx that_2 = this;
            this.__p_NdnjEIGZyJ7POaTNbIzHkO = Output_1;
            return that_2;
        }

        public n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx __CreateDefault__()
        {
            n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx that_0 = this;
            this.__p_NdnjEIGZyJ7POaTNbIzHkO = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NdnjEIGZyJ7POaTNbIzHkO);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 47915U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KkIiBNfYeMRN5OZz9mRl2j", Name = "__slot_KkIiBNfYeMRN5OZz9mRl2j")]
        public static float __slot_KkIiBNfYeMRN5OZz9mRl2j = 0F;
        [n1.ElementAttribute(TracingId = 47871U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NdnjEIGZyJ7POaTNbIzHkO", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3> __p_NdnjEIGZyJ7POaTNbIzHkO;
        static Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx()
        {
        }

        public Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx other): base(other)
        {
            this.__p_NdnjEIGZyJ7POaTNbIzHkO = other.__p_NdnjEIGZyJ7POaTNbIzHkO;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NdnjEIGZyJ7POaTNbIzHkO", in __p_NdnjEIGZyJ7POaTNbIzHkO));
        }

        internal Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3> __p_NdnjEIGZyJ7POaTNbIzHkO)
        {
            n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_NdnjEIGZyJ7POaTNbIzHkO != this.__p_NdnjEIGZyJ7POaTNbIzHkO ? new Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx(this)
                {__p_NdnjEIGZyJ7POaTNbIzHkO = __p_NdnjEIGZyJ7POaTNbIzHkO} : that_0;
            else
            {
                this.__p_NdnjEIGZyJ7POaTNbIzHkO = __p_NdnjEIGZyJ7POaTNbIzHkO;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 53090U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "LRcaT1Ox9T9Nx62ge5XELl", Name = "Oscillator_LRcaT1Ox9T9Nx62ge5XELl")]
    [n2.SerializableAttribute]
    public class Oscillator_LRcaT1Ox9T9Nx62ge5XELl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Oscillator_LRcaT1Ox9T9Nx62ge5XELl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl CreateDefault()
        {
            var instance = new Oscillator_LRcaT1Ox9T9Nx62ge5XELl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl Update(float Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, float Cycles_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out float Position_Out, out float Velocity_Out, out float Acceleration_Out, out n33.OscillatorFunction_C<float> Function_Out)
        {
            var Output_4 = this.__p_LH2IfX3uVlZOWNCEvfP9IV.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: Cycles_In, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out float Position_0, Velocity_Out: out float Velocity_1, Acceleration_Out: out float Acceleration_2, Function_Out: out n33.OscillatorFunction_C<float> Function_3);
            Position_Out = Position_0;
            Velocity_Out = Velocity_1;
            Acceleration_Out = Acceleration_2;
            Function_Out = Function_3;
            n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Output_4 != this.__p_LH2IfX3uVlZOWNCEvfP9IV ? new Oscillator_LRcaT1Ox9T9Nx62ge5XELl(this)
                {__p_LH2IfX3uVlZOWNCEvfP9IV = Output_4} : that_5;
            else
            {
                this.__p_LH2IfX3uVlZOWNCEvfP9IV = Output_4;
            }

            return that_5;
        }

        public n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_LH2IfX3uVlZOWNCEvfP9IV;
            if (SetClock_0)
            {
                Output_1 = this.__p_LH2IfX3uVlZOWNCEvfP9IV.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_LH2IfX3uVlZOWNCEvfP9IV ? new Oscillator_LRcaT1Ox9T9Nx62ge5XELl(this)
                {__p_LH2IfX3uVlZOWNCEvfP9IV = Output_1} : that_2;
            else
            {
                this.__p_LH2IfX3uVlZOWNCEvfP9IV = Output_1;
            }

            return that_2;
        }

        public n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "LH2IfX3uVlZOWNCEvfP9IV", 53094U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl that_2 = this;
            this.__p_LH2IfX3uVlZOWNCEvfP9IV = Output_1;
            return that_2;
        }

        public n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl __CreateDefault__()
        {
            n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl that_0 = this;
            this.__p_LH2IfX3uVlZOWNCEvfP9IV = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LH2IfX3uVlZOWNCEvfP9IV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 53094U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "LH2IfX3uVlZOWNCEvfP9IV", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float> __p_LH2IfX3uVlZOWNCEvfP9IV;
        public Oscillator_LRcaT1Ox9T9Nx62ge5XELl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Oscillator_LRcaT1Ox9T9Nx62ge5XELl(Oscillator_LRcaT1Ox9T9Nx62ge5XELl other): base(other)
        {
            this.__p_LH2IfX3uVlZOWNCEvfP9IV = other.__p_LH2IfX3uVlZOWNCEvfP9IV;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LH2IfX3uVlZOWNCEvfP9IV", in __p_LH2IfX3uVlZOWNCEvfP9IV));
        }

        internal Oscillator_LRcaT1Ox9T9Nx62ge5XELl __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<float> __p_LH2IfX3uVlZOWNCEvfP9IV)
        {
            n3.Oscillator_LRcaT1Ox9T9Nx62ge5XELl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LH2IfX3uVlZOWNCEvfP9IV != this.__p_LH2IfX3uVlZOWNCEvfP9IV ? new Oscillator_LRcaT1Ox9T9Nx62ge5XELl(this)
                {__p_LH2IfX3uVlZOWNCEvfP9IV = __p_LH2IfX3uVlZOWNCEvfP9IV} : that_0;
            else
            {
                this.__p_LH2IfX3uVlZOWNCEvfP9IV = __p_LH2IfX3uVlZOWNCEvfP9IV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 53272U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SlkPnN2OVJ3P4vEXYgjC8r", Name = "Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r")]
    [n2.SerializableAttribute]
    public class Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r CreateDefault()
        {
            var instance = new Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r Update(n36.Vector2 Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, float Cycles_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out n36.Vector2 Position_Out, out n36.Vector2 Velocity_Out, out n36.Vector2 Acceleration_Out, out n33.OscillatorFunction_C<n36.Vector2> Function_Out)
        {
            var Output_4 = this.__p_BWYsvo7VMqhNeOqJVeXT14.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: Cycles_In, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out n36.Vector2 Position_0, Velocity_Out: out n36.Vector2 Velocity_1, Acceleration_Out: out n36.Vector2 Acceleration_2, Function_Out: out n33.OscillatorFunction_C<n36.Vector2> Function_3);
            Position_Out = Position_0;
            Velocity_Out = Velocity_1;
            Acceleration_Out = Acceleration_2;
            Function_Out = Function_3;
            n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Output_4 != this.__p_BWYsvo7VMqhNeOqJVeXT14 ? new Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(this)
                {__p_BWYsvo7VMqhNeOqJVeXT14 = Output_4} : that_5;
            else
            {
                this.__p_BWYsvo7VMqhNeOqJVeXT14 = Output_4;
            }

            return that_5;
        }

        public n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_BWYsvo7VMqhNeOqJVeXT14;
            if (SetClock_0)
            {
                Output_1 = this.__p_BWYsvo7VMqhNeOqJVeXT14.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_BWYsvo7VMqhNeOqJVeXT14 ? new Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(this)
                {__p_BWYsvo7VMqhNeOqJVeXT14 = Output_1} : that_2;
            else
            {
                this.__p_BWYsvo7VMqhNeOqJVeXT14 = Output_1;
            }

            return that_2;
        }

        public n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "BWYsvo7VMqhNeOqJVeXT14", 53280U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r that_2 = this;
            this.__p_BWYsvo7VMqhNeOqJVeXT14 = Output_1;
            return that_2;
        }

        public n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r __CreateDefault__()
        {
            n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r that_0 = this;
            this.__p_BWYsvo7VMqhNeOqJVeXT14 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BWYsvo7VMqhNeOqJVeXT14);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 53280U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "BWYsvo7VMqhNeOqJVeXT14", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2> __p_BWYsvo7VMqhNeOqJVeXT14;
        public Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r other): base(other)
        {
            this.__p_BWYsvo7VMqhNeOqJVeXT14 = other.__p_BWYsvo7VMqhNeOqJVeXT14;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BWYsvo7VMqhNeOqJVeXT14", in __p_BWYsvo7VMqhNeOqJVeXT14));
        }

        internal Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector2> __p_BWYsvo7VMqhNeOqJVeXT14)
        {
            n3.Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BWYsvo7VMqhNeOqJVeXT14 != this.__p_BWYsvo7VMqhNeOqJVeXT14 ? new Oscillator__2D_SlkPnN2OVJ3P4vEXYgjC8r(this)
                {__p_BWYsvo7VMqhNeOqJVeXT14 = __p_BWYsvo7VMqhNeOqJVeXT14} : that_0;
            else
            {
                this.__p_BWYsvo7VMqhNeOqJVeXT14 = __p_BWYsvo7VMqhNeOqJVeXT14;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 54743U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "GhxWCW2Ah0JP0B7xq1lxaI", Name = "Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI")]
    [n2.SerializableAttribute]
    public class Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI Create(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            var instance = new Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI CreateDefault()
        {
            var instance = new Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI Update(n36.Vector3 Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, float Cycles_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out n36.Vector3 Position_Out, out n36.Vector3 Velocity_Out, out n36.Vector3 Acceleration_Out, out n33.OscillatorFunction_C<n36.Vector3> Function_Out)
        {
            var Output_4 = this.__p_Svd4FlFB131NJa3utFegmv.Update<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: Cycles_In, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out n36.Vector3 Position_0, Velocity_Out: out n36.Vector3 Velocity_1, Acceleration_Out: out n36.Vector3 Acceleration_2, Function_Out: out n33.OscillatorFunction_C<n36.Vector3> Function_3);
            Position_Out = Position_0;
            Velocity_Out = Velocity_1;
            Acceleration_Out = Acceleration_2;
            Function_Out = Function_3;
            n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Output_4 != this.__p_Svd4FlFB131NJa3utFegmv ? new Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(this)
                {__p_Svd4FlFB131NJa3utFegmv = Output_4} : that_5;
            else
            {
                this.__p_Svd4FlFB131NJa3utFegmv = Output_4;
            }

            return that_5;
        }

        public n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI SetClock(n12.IClock New_Clock_In)
        {
            bool SetClock_0 = true;
            var Output_1 = this.__p_Svd4FlFB131NJa3utFegmv;
            if (SetClock_0)
            {
                Output_1 = this.__p_Svd4FlFB131NJa3utFegmv.SetClock(New_Clock_In: New_Clock_In);
            }

            n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Svd4FlFB131NJa3utFegmv ? new Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(this)
                {__p_Svd4FlFB131NJa3utFegmv = Output_1} : that_2;
            else
            {
                this.__p_Svd4FlFB131NJa3utFegmv = Output_1;
            }

            return that_2;
        }

        public n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI __Create__(n1.NodeContext Node_Context, n12.IClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "Svd4FlFB131NJa3utFegmv", 54746U);
            var Output_1 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_0, Clock_In: Clock_In);
            n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI that_2 = this;
            this.__p_Svd4FlFB131NJa3utFegmv = Output_1;
            return that_2;
        }

        public n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI __CreateDefault__()
        {
            n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI that_0 = this;
            this.__p_Svd4FlFB131NJa3utFegmv = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Svd4FlFB131NJa3utFegmv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 54746U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Svd4FlFB131NJa3utFegmv", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3> __p_Svd4FlFB131NJa3utFegmv;
        public Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI other): base(other)
        {
            this.__p_Svd4FlFB131NJa3utFegmv = other.__p_Svd4FlFB131NJa3utFegmv;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Svd4FlFB131NJa3utFegmv", in __p_Svd4FlFB131NJa3utFegmv));
        }

        internal Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<n36.Vector3> __p_Svd4FlFB131NJa3utFegmv)
        {
            n3.Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Svd4FlFB131NJa3utFegmv != this.__p_Svd4FlFB131NJa3utFegmv ? new Oscillator__3D_GhxWCW2Ah0JP0B7xq1lxaI(this)
                {__p_Svd4FlFB131NJa3utFegmv = __p_Svd4FlFB131NJa3utFegmv} : that_0;
            else
            {
                this.__p_Svd4FlFB131NJa3utFegmv = __p_Svd4FlFB131NJa3utFegmv;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 81205U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "PJK5DlkbAiFMqldihFJJpm", Name = "Delay_Linear_PJK5DlkbAiFMqldihFJJpm")]
    [n2.SerializableAttribute]
    public class Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> : n1.VLObject, n2.IDisposable where T3 : n12.IClock
    {
        [n4.CreateNewAttribute]
        public static n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> Create<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var instance = new Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var instance = new Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> Update<AdM>(T Value_In, bool Insert_In, [n4.SerializedDefaultValueAttribute("1", false)] float Duration_In, T Reset_Value_In, bool Reset_In, out T Output_Out, out int Count_Out)
            where AdM : struct, n9.IAdaptiveLerp<T>
        {
            var w_0 = default(AdM);
            n5.Queue<n5.KeyValuePair<double, T>> __auto_1 = this.FIFO;
            n12.IClock __pad_OlwXn5pcn1KNGoRpIvKUqy_2 = this.__slot_OlwXn5pcn1KNGoRpIvKUqy;
            n5.KeyValuePair<double, T> __auto_3 = this.Prev;
            n5.KeyValuePair<double, T> __auto_4 = this.Next;
            var Time_5 = __pad_OlwXn5pcn1KNGoRpIvKUqy_2.Time;
            var Seconds_6 = Time_5.Seconds;
            n5.Queue<n5.KeyValuePair<double, T>> __auto_7;
            if (Insert_In)
            {
                var Output_9 = new n5.KeyValuePair<double, T>(key: Seconds_6, value: Value_In);
                __auto_1.Enqueue(item: Output_9);
                __auto_7 = __auto_1;
            }
            else
            {
                __auto_7 = __auto_1;
            }

            n5.Queue<n5.KeyValuePair<double, T>> __auto_10;
            n5.KeyValuePair<double, T> __auto_11;
            n5.KeyValuePair<double, T> __auto_12;
            if (Reset_In)
            {
                __auto_7.Clear();
                var Output_14 = new n5.KeyValuePair<double, T>(key: Seconds_6, value: Reset_Value_In);
                __auto_7.Enqueue(item: Output_14);
                __auto_10 = __auto_7;
                __auto_11 = Output_14;
                __auto_12 = Output_14;
            }
            else
            {
                __auto_10 = __auto_7;
                __auto_11 = __auto_3;
                __auto_12 = __auto_4;
            }

            var Count_15 = __auto_10.Count;
            double Input_2_16 = (double)Duration_In;
            var Output_17 = Seconds_6 - Input_2_16;
            n5.Queue<n5.KeyValuePair<double, T>> accumulator_19 = __auto_10;
            n5.KeyValuePair<double, T> accumulator_20 = __auto_11;
            n5.KeyValuePair<double, T> accumulator_21 = __auto_12;
            for (var i_18 = 0; i_18 < Count_15; i_18++)
            {
                var i_local_22 = i_18;
                var Result_24 = accumulator_19.Peek();
                var Key_25 = Result_24.Key;
                var Result_26 = Key_25 >= Output_17;
                var Result_27 = Key_25 < Output_17;
                n5.Queue<n5.KeyValuePair<double, T>> __auto_28;
                if (Result_27)
                {
                    var Result_30 = accumulator_19.Dequeue();
                    __auto_28 = accumulator_19;
                }
                else
                {
                    __auto_28 = accumulator_19;
                }

                n17._Operations_.Switch_Boolean<n5.KeyValuePair<double, T>>(Condition_In: Result_27, Input_In: accumulator_20, Input_2_In: Result_24, Output_Out: out n5.KeyValuePair<double, T> Output_31);
                n17._Operations_.Switch_Boolean<n5.KeyValuePair<double, T>>(Condition_In: Result_26, Input_In: accumulator_21, Input_2_In: Result_24, Output_Out: out n5.KeyValuePair<double, T> Output_32);
                if (Result_26)
                {
                }

                accumulator_19 = __auto_28;
                accumulator_20 = Output_31;
                accumulator_21 = Output_32;
                if (Result_26)
                {
                    break;
                }
            }

            n5.Queue<n5.KeyValuePair<double, T>> __auto_33 = accumulator_19;
            n5.KeyValuePair<double, T> __auto_34 = accumulator_20;
            n5.KeyValuePair<double, T> __auto_35 = accumulator_21;
            var Key_36 = __auto_34.Key;
            var Key_37 = __auto_35.Key;
            double Output_Minimum_38 = 0;
            double Output_Maximum_39 = 1;
            n37._Operations_.MapClamp<double, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Output_17, Input_Minimum_In: Key_36, Input_Maximum_In: Key_37, Output_Minimum_In: Output_Minimum_38, Output_Maximum_In: Output_Maximum_39, Output_Out: out double Output_40);
            var Result_41 = n15.IntegerConversions.ToFloat32(input: Output_40);
            var Value_42 = __auto_34.Value;
            var Value_43 = __auto_35.Value;
            w_0.Lerp(Input_In: Value_42, Input_2_In: Value_43, Scalar_In: Result_41, Output_Out: out T Output_44);
            Output_Out = Output_44;
            Count_Out = Count_15;
            n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> that_45 = this;
            if (this.__GetContext__().IsImmutable)
                that_45 = accumulator_19 != this.FIFO || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(accumulator_20, this.Prev) || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(accumulator_21, this.Next) ? new Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3>(this)
                {FIFO = accumulator_19, Prev = accumulator_20, Next = accumulator_21} : that_45;
            else
            {
                this.FIFO = accumulator_19;
                this.Prev = accumulator_20;
                this.Next = accumulator_21;
            }

            return that_45;
        }

        public n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> SetClock<T2>(T2 New_Clock_In)
            where T2 : n12.IClock
        {
            n12.IClock __pad_OlwXn5pcn1KNGoRpIvKUqy_0 = (n12.IClock)New_Clock_In;
            n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = (n12.IClock)New_Clock_In != this.__slot_OlwXn5pcn1KNGoRpIvKUqy ? new Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3>(this)
                {__slot_OlwXn5pcn1KNGoRpIvKUqy = (n12.IClock)New_Clock_In} : that_1;
            else
            {
                this.__slot_OlwXn5pcn1KNGoRpIvKUqy = (n12.IClock)New_Clock_In;
            }

            return that_1;
        }

        public n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> __Create__<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n12.IClock __pad_OlwXn5pcn1KNGoRpIvKUqy_1 = (n12.IClock)Clock_In;
            var Output_2 = new n5.Queue<n5.KeyValuePair<double, T>>();
            n5.Queue<n5.KeyValuePair<double, T>> __auto_3 = Output_2;
            n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> that_4 = this;
            this.__slot_OlwXn5pcn1KNGoRpIvKUqy = (n12.IClock)Clock_In;
            this.FIFO = Output_2;
            this.Next = n19._Operations_.CreateDefault<double, T, AdM>();
            this.Prev = n19._Operations_.CreateDefault<double, T, AdM>();
            return that_4;
        }

        public n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>, n8.IAdaptiveCreateDefault<double>
        {
            var w_0 = default(AdM);
            n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> that_1 = this;
            this.__slot_OlwXn5pcn1KNGoRpIvKUqy = n11._Operations_.CreateDefault();
            this.FIFO = n22._Operations_.CreateDefault<n5.KeyValuePair<double, T>>();
            this.Next = n19._Operations_.CreateDefault<double, T, AdM>();
            this.Prev = n19._Operations_.CreateDefault<double, T, AdM>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 82246U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "OlwXn5pcn1KNGoRpIvKUqy", Name = "__slot_OlwXn5pcn1KNGoRpIvKUqy")]
        public n12.IClock __slot_OlwXn5pcn1KNGoRpIvKUqy;
        [n1.ElementAttribute(TracingId = 81214U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "CitUnjRXmlHQLQKG9xUgfg", Name = "FIFO")]
        public n5.Queue<n5.KeyValuePair<double, T>> FIFO;
        [n1.ElementAttribute(TracingId = 82147U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "JCbZbMMnF9rNUKxYPldkFj", Name = "Next")]
        public n5.KeyValuePair<double, T> Next;
        [n1.ElementAttribute(TracingId = 82150U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "QxY7Xum4k0CPH6sYtsHn5R", Name = "Prev")]
        public n5.KeyValuePair<double, T> Prev;
        public Delay_Linear_PJK5DlkbAiFMqldihFJJpm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Delay_Linear_PJK5DlkbAiFMqldihFJJpm(Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> other): base(other)
        {
            this.__slot_OlwXn5pcn1KNGoRpIvKUqy = other.__slot_OlwXn5pcn1KNGoRpIvKUqy;
            this.FIFO = other.FIFO;
            this.Next = other.Next;
            this.Prev = other.Prev;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_OlwXn5pcn1KNGoRpIvKUqy", in __slot_OlwXn5pcn1KNGoRpIvKUqy), n1.CompilationHelper.GetValueOrExisting(values, "FIFO", in FIFO), n1.CompilationHelper.GetValueOrExisting(values, "Next", in Next), n1.CompilationHelper.GetValueOrExisting(values, "Prev", in Prev));
        }

        internal Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> __WITH__(n12.IClock __slot_OlwXn5pcn1KNGoRpIvKUqy, n5.Queue<n5.KeyValuePair<double, T>> FIFO, n5.KeyValuePair<double, T> Next, n5.KeyValuePair<double, T> Prev)
        {
            n3.Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_OlwXn5pcn1KNGoRpIvKUqy != this.__slot_OlwXn5pcn1KNGoRpIvKUqy || FIFO != this.FIFO || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(Next, this.Next) || !n5.EqualityComparer<n5.KeyValuePair<double, T>>.Default.Equals(Prev, this.Prev) ? new Delay_Linear_PJK5DlkbAiFMqldihFJJpm<T, T3>(this)
                {__slot_OlwXn5pcn1KNGoRpIvKUqy = __slot_OlwXn5pcn1KNGoRpIvKUqy, FIFO = FIFO, Next = Next, Prev = Prev} : that_0;
            else
            {
                this.__slot_OlwXn5pcn1KNGoRpIvKUqy = __slot_OlwXn5pcn1KNGoRpIvKUqy;
                this.FIFO = FIFO;
                this.Next = Next;
                this.Prev = Prev;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 83334U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "AqpnaEs3vthPzpyQLCCoCR", Name = "VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR")]
    [n2.SerializableAttribute]
    public class VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR CreateDefault()
        {
            var instance = new VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR Update()
        {
            return this;
        }

        public n3.VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR __CreateDefault__()
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

        public VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR(VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_AnimationApplication_AqpnaEs3vthPzpyQLCCoCR __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Animation_.Animation.FrameBased
{
    [n1.ElementAttribute(TracingId = 28484U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "ThiX3p7ISOINTOij9kpcDi", Name = "MassSpring_ThiX3p7ISOINTOij9kpcDi")]
    [n2.SerializableAttribute]
    public class MassSpring_ThiX3p7ISOINTOij9kpcDi<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new MassSpring_ThiX3p7ISOINTOij9kpcDi<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new MassSpring_ThiX3p7ISOINTOij9kpcDi<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> Update<AdM>(T Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Frequency_In, [n4.SerializedDefaultValueAttribute("2", false)] float Damping_In, out T Position_Out, out T Velocity_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            T __auto_1 = this.Position;
            T __auto_2 = this.Velocity;
            n39._Operations_.IntegrateXV<T, AdM>(State_X_In: __auto_1, State_V_In: __auto_2, Target_In: Goto_Position_In, Frequency_In: Frequency_In, Damping_In: Damping_In, Output_X_Out: out T Output_X_3, Output_V_Out: out T Output_V_4);
            T __auto_5 = Output_X_3;
            T __auto_6 = Output_V_4;
            Position_Out = __auto_5;
            Velocity_Out = __auto_6;
            n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = !n5.EqualityComparer<T>.Default.Equals(Output_X_3, this.Position) || !n5.EqualityComparer<T>.Default.Equals(Output_V_4, this.Velocity) ? new MassSpring_ThiX3p7ISOINTOij9kpcDi<T>(this)
                {Position = Output_X_3, Velocity = Output_V_4} : that_7;
            else
            {
                this.Position = Output_X_3;
                this.Velocity = Output_V_4;
            }

            return that_7;
        }

        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> Reset(T Reset_Position_In)
        {
            T __pad_DqidSEakOEbOHDMjyKf07N_0 = __slot_DqidSEakOEbOHDMjyKf07N;
            T __auto_1 = Reset_Position_In;
            T __auto_2 = __pad_DqidSEakOEbOHDMjyKf07N_0;
            n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = !n5.EqualityComparer<T>.Default.Equals(Reset_Position_In, this.Position) || !n5.EqualityComparer<T>.Default.Equals(__pad_DqidSEakOEbOHDMjyKf07N_0, this.Velocity) ? new MassSpring_ThiX3p7ISOINTOij9kpcDi<T>(this)
                {Position = Reset_Position_In, Velocity = __pad_DqidSEakOEbOHDMjyKf07N_0} : that_3;
            else
            {
                this.Position = Reset_Position_In;
                this.Velocity = __pad_DqidSEakOEbOHDMjyKf07N_0;
            }

            return that_3;
        }

        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_0);
            w_0.CreateDefault(out T __out_1);
            n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> that_1 = this;
            this.Position = __out_0;
            this.Velocity = __out_1;
            return that_1;
        }

        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_2);
            w_0.CreateDefault(out T __out_3);
            n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> that_1 = this;
            this.Position = __out_2;
            this.Velocity = __out_3;
            return that_1;
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

        [n1.ElementAttribute(TracingId = 36749U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DqidSEakOEbOHDMjyKf07N", Name = "__slot_DqidSEakOEbOHDMjyKf07N")]
        public static T __slot_DqidSEakOEbOHDMjyKf07N = default(T);
        [n1.ElementAttribute(TracingId = 28488U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "HSnz5LKGN20MkJvjYl4oMU", Name = "Position")]
        public T Position;
        [n1.ElementAttribute(TracingId = 36736U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KFTXQi2sB51PezVLE31t7L", Name = "Velocity")]
        public T Velocity;
        static MassSpring_ThiX3p7ISOINTOij9kpcDi()
        {
        }

        public MassSpring_ThiX3p7ISOINTOij9kpcDi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MassSpring_ThiX3p7ISOINTOij9kpcDi(MassSpring_ThiX3p7ISOINTOij9kpcDi<T> other): base(other)
        {
            this.Position = other.Position;
            this.Velocity = other.Velocity;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Velocity", in Velocity));
        }

        internal MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __WITH__(T Position, T Velocity)
        {
            n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n5.EqualityComparer<T>.Default.Equals(Position, this.Position) || !n5.EqualityComparer<T>.Default.Equals(Velocity, this.Velocity) ? new MassSpring_ThiX3p7ISOINTOij9kpcDi<T>(this)
                {Position = Position, Velocity = Velocity} : that_0;
            else
            {
                this.Position = Position;
                this.Velocity = Velocity;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 36866U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DYC8agHhNE6Lg7Y7GtSql2", Name = "Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2")]
    [n2.SerializableAttribute]
    public class Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 Create(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
        {
            var instance = new Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 CreateDefault()
        {
            var instance = new Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 Update(n36.Vector2 Start_In, n36.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("2, 2", false)] n36.Vector2 Width_In, [n4.SerializedDefaultValueAttribute("Mirror", false)] n40.RangeMapping Range_Mode_In, float Main_Direction_In, [n4.SerializedDefaultValueAttribute("0", false)] float Main_Direction_Tendency_In, [n4.SerializedDefaultValueAttribute("0.5", false)] float Direction_Deviation_In, [n4.SerializedDefaultValueAttribute("0.01", false)] float Speed_In, [n4.SerializedDefaultValueAttribute("1", false)] float Smoothing_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Walk_In, out n36.Vector2 Position_Out)
        {
            float __auto_0 = this.Direction;
            n41._Operations_.Range_Join_Center_Width<n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Center_In: Center_In, Width_In: Width_In, Output_Out: out n40.Range<n36.Vector2> Output_1);
            n42._Operations_.Clamp_Range(Input_In: Start_In, Range_In: Output_1, Output_Out: out n36.Vector2 Output_2);
            float Center_3 = 0F;
            n41._Operations_.Range_Join_Center_Width<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Center_In: Center_3, Width_In: Direction_Deviation_In, Output_Out: out n40.Range<float> Output_4);
            Output_4.Split(from: out float From_5, to: out float To_6);
            var Output_7 = n40.Noise.Random(from: From_5, to: To_6);
            bool Cyclic_8 = false;
            bool Jump_9 = false;
            bool Force_New_Func_10 = false;
            var Output_15 = this.__p_DI3U0iYwHvRQdt0mFO2fKJ.Update(Goto_Position_In: Output_7, Filter_Time_In: Smoothing_In, Cyclic_In: Cyclic_8, Jump_In: Jump_9, Force_New_Func_In: Force_New_Func_10, Position_Out: out float Position_11, Velocity_Out: out float Velocity_12, Acceleration_Out: out float Acceleration_13, Function_Out: out n33.OscillatorFunction_C<float> Function_14);
            var Output_16 = __auto_0 + Position_11;
            var Output_17 = n15.Float32Extensions.Lerp(input: Output_16, input2: Main_Direction_In, scalar: Main_Direction_Tendency_In);
            n43._Operations_.FromPolar(Angle_In: Output_17, Radius_In: Speed_In, Output_Out: out n36.Vector2 Output_18);
            var Output_19 = this.__p_DR0RJiZfcLYPXc5ouXSddo;
            if (Walk_In)
            {
                Output_19 = this.__p_DR0RJiZfcLYPXc5ouXSddo.Step<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Offset_In: Output_18);
            }

            var Output_20 = Output_19;
            if (Reset_In)
            {
                Output_20 = Output_19.Reset(Reset_Value_In: Output_2);
            }

            var Output_22 = Output_20.GetValue(Value_Out: out n36.Vector2 Value_21);
            n44._Operations_.MapWanderer<n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Value_21, Range_In: Output_1, Range_Mode_In: Range_Mode_In, Output_Out: out n36.Vector2 Output_23);
            float __auto_24 = Output_17;
            Position_Out = Output_23;
            n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Output_15 != this.__p_DI3U0iYwHvRQdt0mFO2fKJ || Output_22 != this.__p_DR0RJiZfcLYPXc5ouXSddo || Output_17 != this.Direction ? new Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(this)
                {__p_DI3U0iYwHvRQdt0mFO2fKJ = Output_15, __p_DR0RJiZfcLYPXc5ouXSddo = Output_22, Direction = Output_17} : that_25;
            else
            {
                this.__p_DI3U0iYwHvRQdt0mFO2fKJ = Output_15;
                this.__p_DR0RJiZfcLYPXc5ouXSddo = Output_22;
                this.Direction = Output_17;
            }

            return that_25;
        }

        public n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 SetClock(n12.IFrameClock New_Clock_In)
        {
            n12.IClock New_Clock_0 = (n12.IClock)New_Clock_In;
            bool SetClock_1 = true;
            var Output_2 = this.__p_DI3U0iYwHvRQdt0mFO2fKJ;
            if (SetClock_1)
            {
                Output_2 = this.__p_DI3U0iYwHvRQdt0mFO2fKJ.SetClock(New_Clock_In: New_Clock_0);
            }

            n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_DI3U0iYwHvRQdt0mFO2fKJ ? new Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(this)
                {__p_DI3U0iYwHvRQdt0mFO2fKJ = Output_2} : that_3;
            else
            {
                this.__p_DI3U0iYwHvRQdt0mFO2fKJ = Output_2;
            }

            return that_3;
        }

        public n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 __Create__(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n12.IClock Clock_0 = (n12.IClock)Clock_In;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "DI3U0iYwHvRQdt0mFO2fKJ", 36930U);
            var Output_2 = n3.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_1, Clock_In: Clock_0);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "DR0RJiZfcLYPXc5ouXSddo", 37000U);
            n36.Vector2 Initial_Value_4 = n42._Operations_.CreateDefault();
            var Output_5 = n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector2>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_3, Initial_Value_In: Initial_Value_4);
            n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 that_6 = this;
            this.Direction = 0F;
            this.__p_DI3U0iYwHvRQdt0mFO2fKJ = Output_2;
            this.__p_DR0RJiZfcLYPXc5ouXSddo = Output_5;
            return that_6;
        }

        public n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 __CreateDefault__()
        {
            n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 that_0 = this;
            this.Direction = 0F;
            this.__p_DI3U0iYwHvRQdt0mFO2fKJ = n3.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_DR0RJiZfcLYPXc5ouXSddo = n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector2>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DI3U0iYwHvRQdt0mFO2fKJ);
            n1.CompilationHelper.SafeDispose(this.__p_DR0RJiZfcLYPXc5ouXSddo);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 36869U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "GIYJu8w6klPP6L24GYMvSX", Name = "Direction")]
        public float Direction;
        [n1.ElementAttribute(TracingId = 36930U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DI3U0iYwHvRQdt0mFO2fKJ", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n3.Damper_Qhw7aQNplhrMCum2sxpG8z __p_DI3U0iYwHvRQdt0mFO2fKJ;
        [n1.ElementAttribute(TracingId = 37000U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DR0RJiZfcLYPXc5ouXSddo", Name = "Integrator", IsManaged = true, IsAutoGenerated = true)]
        public n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector2> __p_DR0RJiZfcLYPXc5ouXSddo;
        public Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 other): base(other)
        {
            this.Direction = other.Direction;
            this.__p_DI3U0iYwHvRQdt0mFO2fKJ = other.__p_DI3U0iYwHvRQdt0mFO2fKJ;
            this.__p_DR0RJiZfcLYPXc5ouXSddo = other.__p_DR0RJiZfcLYPXc5ouXSddo;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Direction", in Direction), n1.CompilationHelper.GetValueOrExisting(values, "__p_DI3U0iYwHvRQdt0mFO2fKJ", in __p_DI3U0iYwHvRQdt0mFO2fKJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_DR0RJiZfcLYPXc5ouXSddo", in __p_DR0RJiZfcLYPXc5ouXSddo));
        }

        internal Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 __WITH__(float Direction, n3.Damper_Qhw7aQNplhrMCum2sxpG8z __p_DI3U0iYwHvRQdt0mFO2fKJ, n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector2> __p_DR0RJiZfcLYPXc5ouXSddo)
        {
            n38.Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Direction != this.Direction || __p_DI3U0iYwHvRQdt0mFO2fKJ != this.__p_DI3U0iYwHvRQdt0mFO2fKJ || __p_DR0RJiZfcLYPXc5ouXSddo != this.__p_DR0RJiZfcLYPXc5ouXSddo ? new Wanderer__2D_DYC8agHhNE6Lg7Y7GtSql2(this)
                {Direction = Direction, __p_DI3U0iYwHvRQdt0mFO2fKJ = __p_DI3U0iYwHvRQdt0mFO2fKJ, __p_DR0RJiZfcLYPXc5ouXSddo = __p_DR0RJiZfcLYPXc5ouXSddo} : that_0;
            else
            {
                this.Direction = Direction;
                this.__p_DI3U0iYwHvRQdt0mFO2fKJ = __p_DI3U0iYwHvRQdt0mFO2fKJ;
                this.__p_DR0RJiZfcLYPXc5ouXSddo = __p_DR0RJiZfcLYPXc5ouXSddo;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 46280U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "JQUTAyrKDKqQA9wwhm7VZl", Name = "Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl")]
    [n2.SerializableAttribute]
    public class Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl Create(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
        {
            var instance = new Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl CreateDefault()
        {
            var instance = new Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl Update(n36.Vector3 Start_In, n36.Vector3 Center_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n36.Vector3 Width_In, [n4.SerializedDefaultValueAttribute("Mirror", false)] n40.RangeMapping Range_Mode_In, n36.Vector3 Main_Direction_In, [n4.SerializedDefaultValueAttribute("1", false)] float Main_Direction_Tendency_In, n36.Vector3 Direction_Deviation_In, [n4.SerializedDefaultValueAttribute("1", false)] float Speed_In, [n4.SerializedDefaultValueAttribute("1", false)] float Smoothing_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Walk_In, out n36.Vector3 Position_Out)
        {
            n36.Vector3 __auto_0 = this.Direction;
            n41._Operations_.Range_Join_Center_Width<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Center_In: Center_In, Width_In: Width_In, Output_Out: out n40.Range<n36.Vector3> Output_1);
            n46._Operations_.Clamp_Range(Input_In: Start_In, Range_In: Output_1, Output_Out: out n36.Vector3 Output_2);
            n36.Vector3 Center_3 = n46._Operations_.CreateDefault();
            n41._Operations_.Range_Join_Center_Width<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Center_In: Center_3, Width_In: Direction_Deviation_In, Output_Out: out n40.Range<n36.Vector3> Output_4);
            Output_4.Split(from: out n36.Vector3 From_5, to: out n36.Vector3 To_6);
            var Output_7 = n40.Noise.Random(from: From_5, to: To_6);
            bool Cyclic_8 = false;
            bool Jump_9 = false;
            bool Force_New_Func_10 = false;
            var Output_15 = this.__p_SFy1ESMtp6GO3WP3PuIf6d.Update(Goto_Position_In: Output_7, Filter_Time_In: Smoothing_In, Cyclic_In: Cyclic_8, Jump_In: Jump_9, Force_New_Func_In: Force_New_Func_10, Position_Out: out n36.Vector3 Position_11, Velocity_Out: out n36.Vector3 Velocity_12, Acceleration_Out: out n36.Vector3 Acceleration_13, Function_Out: out n33.OscillatorFunction_C<n36.Vector3> Function_14);
            n36.Vector3.Add(left: ref __auto_0, right: ref Position_11, result: out n36.Vector3 Output_16);
            var Output_17 = n40.Vector3Nodes.Lerp(input: ref Output_16, input2: ref Main_Direction_In, scalar: Main_Direction_Tendency_In);
            n36.Vector3.Normalize(value: ref Output_17, result: out n36.Vector3 Output_18);
            n36.Vector3 From_19 = n46._Operations_.CreateDefault();
            n47._Operations_.Slope(From_In: From_19, To_In: Output_18, Polar_Out: out float Polar_20, Azimuthal_Out: out float Azimuthal_21, Length_Out: out float Length_22);
            n47._Operations_.FromSpherical(Polar_In: Polar_20, Azimuthal_In: Azimuthal_21, Radius_In: Speed_In, Output_Out: out n36.Vector3 Output_23);
            var Output_24 = this.__p_FOMXZ0eHjofP3fiime2JAK;
            if (Walk_In)
            {
                Output_24 = this.__p_FOMXZ0eHjofP3fiime2JAK.Step<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Offset_In: Output_23);
            }

            var Output_25 = Output_24;
            if (Reset_In)
            {
                Output_25 = Output_24.Reset(Reset_Value_In: Output_2);
            }

            var Output_27 = Output_25.GetValue(Value_Out: out n36.Vector3 Value_26);
            n44._Operations_.MapWanderer<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Value_26, Range_In: Output_1, Range_Mode_In: Range_Mode_In, Output_Out: out n36.Vector3 Output_28);
            n36.Vector3 __auto_29 = Output_18;
            Position_Out = Output_28;
            n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = Output_15 != this.__p_SFy1ESMtp6GO3WP3PuIf6d || Output_27 != this.__p_FOMXZ0eHjofP3fiime2JAK || Output_18 != this.Direction ? new Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(this)
                {__p_SFy1ESMtp6GO3WP3PuIf6d = Output_15, __p_FOMXZ0eHjofP3fiime2JAK = Output_27, Direction = Output_18} : that_30;
            else
            {
                this.__p_SFy1ESMtp6GO3WP3PuIf6d = Output_15;
                this.__p_FOMXZ0eHjofP3fiime2JAK = Output_27;
                this.Direction = Output_18;
            }

            return that_30;
        }

        public n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl SetClock(n12.IFrameClock New_Clock_In)
        {
            n12.IClock New_Clock_0 = (n12.IClock)New_Clock_In;
            bool SetClock_1 = true;
            var Output_2 = this.__p_SFy1ESMtp6GO3WP3PuIf6d;
            if (SetClock_1)
            {
                Output_2 = this.__p_SFy1ESMtp6GO3WP3PuIf6d.SetClock(New_Clock_In: New_Clock_0);
            }

            n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_SFy1ESMtp6GO3WP3PuIf6d ? new Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(this)
                {__p_SFy1ESMtp6GO3WP3PuIf6d = Output_2} : that_3;
            else
            {
                this.__p_SFy1ESMtp6GO3WP3PuIf6d = Output_2;
            }

            return that_3;
        }

        public n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl __Create__(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n12.IClock Clock_0 = (n12.IClock)Clock_In;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "SFy1ESMtp6GO3WP3PuIf6d", 46474U);
            var Output_2 = n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx.Create(Node_Context: Node_Context_1, Clock_In: Clock_0);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "FOMXZ0eHjofP3fiime2JAK", 46348U);
            n36.Vector3 Initial_Value_4 = n46._Operations_.CreateDefault();
            var Output_5 = n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector3>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_3, Initial_Value_In: Initial_Value_4);
            n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl that_6 = this;
            this.Direction = n46._Operations_.CreateDefault();
            this.__p_SFy1ESMtp6GO3WP3PuIf6d = Output_2;
            this.__p_FOMXZ0eHjofP3fiime2JAK = Output_5;
            return that_6;
        }

        public n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl __CreateDefault__()
        {
            n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl that_0 = this;
            this.Direction = n46._Operations_.CreateDefault();
            this.__p_SFy1ESMtp6GO3WP3PuIf6d = n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx.CreateDefault();
            this.__p_FOMXZ0eHjofP3fiime2JAK = n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector3>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SFy1ESMtp6GO3WP3PuIf6d);
            n1.CompilationHelper.SafeDispose(this.__p_FOMXZ0eHjofP3fiime2JAK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 46282U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "LGyfxAPzlbYOSOEf8fPM4L", Name = "Direction")]
        public n36.Vector3 Direction;
        [n1.ElementAttribute(TracingId = 46474U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SFy1ESMtp6GO3WP3PuIf6d", Name = "Damper (3D)", IsManaged = true, IsAutoGenerated = true)]
        public n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx __p_SFy1ESMtp6GO3WP3PuIf6d;
        [n1.ElementAttribute(TracingId = 46348U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FOMXZ0eHjofP3fiime2JAK", Name = "Integrator", IsManaged = true, IsAutoGenerated = true)]
        public n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector3> __p_FOMXZ0eHjofP3fiime2JAK;
        public Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl other): base(other)
        {
            this.Direction = other.Direction;
            this.__p_SFy1ESMtp6GO3WP3PuIf6d = other.__p_SFy1ESMtp6GO3WP3PuIf6d;
            this.__p_FOMXZ0eHjofP3fiime2JAK = other.__p_FOMXZ0eHjofP3fiime2JAK;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Direction", in Direction), n1.CompilationHelper.GetValueOrExisting(values, "__p_SFy1ESMtp6GO3WP3PuIf6d", in __p_SFy1ESMtp6GO3WP3PuIf6d), n1.CompilationHelper.GetValueOrExisting(values, "__p_FOMXZ0eHjofP3fiime2JAK", in __p_FOMXZ0eHjofP3fiime2JAK));
        }

        internal Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl __WITH__(n36.Vector3 Direction, n3.Damper__3D_Q7f7FmZqnvOOvqWrXqfeOx __p_SFy1ESMtp6GO3WP3PuIf6d, n45.Integrator_THHkpncME3nNMZHt1mZTtJ<n36.Vector3> __p_FOMXZ0eHjofP3fiime2JAK)
        {
            n38.Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Direction != this.Direction || __p_SFy1ESMtp6GO3WP3PuIf6d != this.__p_SFy1ESMtp6GO3WP3PuIf6d || __p_FOMXZ0eHjofP3fiime2JAK != this.__p_FOMXZ0eHjofP3fiime2JAK ? new Wanderer__3D_JQUTAyrKDKqQA9wwhm7VZl(this)
                {Direction = Direction, __p_SFy1ESMtp6GO3WP3PuIf6d = __p_SFy1ESMtp6GO3WP3PuIf6d, __p_FOMXZ0eHjofP3fiime2JAK = __p_FOMXZ0eHjofP3fiime2JAK} : that_0;
            else
            {
                this.Direction = Direction;
                this.__p_SFy1ESMtp6GO3WP3PuIf6d = __p_SFy1ESMtp6GO3WP3PuIf6d;
                this.__p_FOMXZ0eHjofP3fiime2JAK = __p_FOMXZ0eHjofP3fiime2JAK;
            }

            return that_0;
        }
    }
}

namespace _VL_Animation_.Animation.FrameBased.MassSpring
{
    [n1.ElementAttribute(TracingId = 22372U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void PartialEvaluateXV<T, AdM>(T State_X_In, T State_V_In, T Derivative_X_In, T Derivative_V_In, T Target_In, float b_In, [n4.SerializedDefaultValueAttribute("0", false)] float dt_In, out T Output_X_Out, out T Output_V_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            w_0.OperatorMulitply_Scale(Input_In: Derivative_X_In, Scalar_In: dt_In, Output_Out: out T Output_1);
            w_0.OperatorMulitply_Scale(Input_In: Derivative_V_In, Scalar_In: dt_In, Output_Out: out T Output_2);
            w_0.OperatorPlus(Input_In: State_V_In, Input_2_In: Output_2, Output_Out: out T Output_3);
            w_0.OperatorMulitply_Scale(Input_In: Output_3, Scalar_In: b_In, Output_Out: out T Output_4);
            w_0.OperatorPlus(Input_In: State_X_In, Input_2_In: Output_1, Output_Out: out T Output_5);
            w_0.OperatorMinus(Input_In: Output_4, Input_2_In: Output_5, Output_Out: out T Output_6);
            w_0.OperatorPlus(Input_In: Output_6, Input_2_In: Target_In, Output_Out: out T Output_7);
            Output_X_Out = Output_3;
            Output_V_Out = Output_7;
            return;
        }

        public static void IntegrateXV<T, AdM>(T State_X_In, T State_V_In, T Target_In, [n4.SerializedDefaultValueAttribute("1", false)] float Frequency_In, float Damping_In, out T Output_X_Out, out T Output_V_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            float __pad_IVIxT42s1AvQKoUcVtHxd9_1 = __slot_IVIxT42s1AvQKoUcVtHxd9;
            float __pad_H6yD3qoEHoWMJ3vfAxyYXV_2 = __slot_H6yD3qoEHoWMJ3vfAxyYXV;
            float __pad_EGH8QZKgkqQOviH2R1cSed_3 = __slot_EGH8QZKgkqQOviH2R1cSed;
            var Output_4 = -Damping_In;
            n39._Operations_.InitialEvaluateXV<T, AdM>(State_X_In: State_X_In, State_V_In: State_V_In, Target_In: Target_In, b_In: Output_4, Output_X_Out: out T Output_X_5, Output_V_Out: out T Output_V_6);
            var Output_7 = Frequency_In * __pad_EGH8QZKgkqQOviH2R1cSed_3;
            n39._Operations_.PartialEvaluateXV<T, AdM>(State_X_In: State_X_In, State_V_In: State_V_In, Derivative_X_In: Output_X_5, Derivative_V_In: Output_V_6, Target_In: Target_In, b_In: Output_4, dt_In: Output_7, Output_X_Out: out T Output_X_8, Output_V_Out: out T Output_V_9);
            n39._Operations_.PartialEvaluateXV<T, AdM>(State_X_In: State_X_In, State_V_In: State_V_In, Derivative_X_In: Output_X_8, Derivative_V_In: Output_V_9, Target_In: Target_In, b_In: Output_4, dt_In: Output_7, Output_X_Out: out T Output_X_10, Output_V_Out: out T Output_V_11);
            n39._Operations_.PartialEvaluateXV<T, AdM>(State_X_In: State_X_In, State_V_In: State_V_In, Derivative_X_In: Output_X_10, Derivative_V_In: Output_V_11, Target_In: Target_In, b_In: Output_4, dt_In: Frequency_In, Output_X_Out: out T Output_X_12, Output_V_Out: out T Output_V_13);
            w_0.OperatorPlus(Input_In: Output_X_8, Input_2_In: Output_X_10, Output_Out: out T Output_14);
            w_0.OperatorMulitply_Scale(Input_In: Output_14, Scalar_In: __pad_IVIxT42s1AvQKoUcVtHxd9_1, Output_Out: out T Output_15);
            w_0.OperatorPlus(Input_In: Output_X_5, Input_2_In: Output_15, Output_Out: out T Output_16);
            w_0.OperatorPlus(Input_In: Output_16, Input_2_In: Output_X_12, Output_Out: out Output_16);
            var Output_17 = __pad_H6yD3qoEHoWMJ3vfAxyYXV_2 * Frequency_In;
            w_0.OperatorMulitply_Scale(Input_In: Output_16, Scalar_In: Output_17, Output_Out: out T Output_18);
            w_0.OperatorPlus(Input_In: Output_V_9, Input_2_In: Output_V_11, Output_Out: out T Output_19);
            w_0.OperatorMulitply_Scale(Input_In: Output_19, Scalar_In: __pad_IVIxT42s1AvQKoUcVtHxd9_1, Output_Out: out T Output_20);
            w_0.OperatorPlus(Input_In: Output_V_6, Input_2_In: Output_20, Output_Out: out T Output_21);
            w_0.OperatorPlus(Input_In: Output_21, Input_2_In: Output_V_13, Output_Out: out Output_21);
            w_0.OperatorMulitply_Scale(Input_In: Output_21, Scalar_In: Output_17, Output_Out: out T Output_22);
            w_0.OperatorPlus(Input_In: State_V_In, Input_2_In: Output_22, Output_Out: out T Output_23);
            w_0.OperatorPlus(Input_In: State_X_In, Input_2_In: Output_18, Output_Out: out T Output_24);
            Output_X_Out = Output_24;
            Output_V_Out = Output_23;
            return;
        }

        public static void InitialEvaluateXV<T, AdM>(T State_X_In, T State_V_In, T Target_In, float b_In, out T Output_X_Out, out T Output_V_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            w_0.OperatorMulitply_Scale(Input_In: State_V_In, Scalar_In: b_In, Output_Out: out T Output_1);
            w_0.OperatorMinus(Input_In: Output_1, Input_2_In: State_X_In, Output_Out: out T Output_2);
            w_0.OperatorPlus(Input_In: Output_2, Input_2_In: Target_In, Output_Out: out T Output_3);
            Output_X_Out = State_V_In;
            Output_V_Out = Output_3;
            return;
        }

        [n1.ElementAttribute(TracingId = 34555U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "IVIxT42s1AvQKoUcVtHxd9", Name = "__slot_IVIxT42s1AvQKoUcVtHxd9")]
        public static float __slot_IVIxT42s1AvQKoUcVtHxd9 = 2F;
        [n1.ElementAttribute(TracingId = 34599U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "H6yD3qoEHoWMJ3vfAxyYXV", Name = "__slot_H6yD3qoEHoWMJ3vfAxyYXV")]
        public static float __slot_H6yD3qoEHoWMJ3vfAxyYXV = 0.1666667F;
        [n1.ElementAttribute(TracingId = 36313U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "EGH8QZKgkqQOviH2R1cSed", Name = "__slot_EGH8QZKgkqQOviH2R1cSed")]
        public static float __slot_EGH8QZKgkqQOviH2R1cSed = 0.5F;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Animation_.Animation.FrameBased.Wanderer__2D
{
    [n1.ElementAttribute(TracingId = 22372U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void MapWanderer<T, AdM>(T Input_In, n40.Range<T> Range_In, n40.RangeMapping Range_Mode_In, out T Output_Out)
            where AdM : struct, n49.IAdaptiveMirror_Range<T>, n50.IAdaptiveClamp_Range<T>, n8.IAdaptiveCreateDefault<n2.Func<T, T>>, n49.IAdaptiveWrap_Range<T>
        {
            n6.Spread<n2.Func<T, T>> __pin_group_Input_In_QMorE5ub492L304MitUyP4 = default(n6.Spread<n2.Func<T, T>>);
            var w_0 = default(AdM);
            int Index_1 = (int)Range_Mode_In;
            var __fallback___2 = n1.ServiceRegistry.Current;
            n2.Func<T, T> Functionality_5 = (T Arg_In_4) =>
            {
                using var __current_3 = __fallback___2.MakeCurrentIfNone();
                return Arg_In_4;
            }

            ;
            n2.Func<T, T> Functionality_9 = (T Arg_In_7) =>
            {
                using var __current_6 = __fallback___2.MakeCurrentIfNone();
                w_0.Clamp_Range(Input_In: Arg_In_7, Range_In: Range_In, Output_Out: out T Output_8);
                return Output_8;
            }

            ;
            n2.Func<T, T> Functionality_13 = (T Arg_In_11) =>
            {
                using var __current_10 = __fallback___2.MakeCurrentIfNone();
                w_0.Mirror_Range(Input_In: Arg_In_11, Range_In: Range_In, Output_Out: out T Output_12);
                return Output_12;
            }

            ;
            n2.Func<T, T> Functionality_17 = (T Arg_In_15) =>
            {
                using var __current_14 = __fallback___2.MakeCurrentIfNone();
                w_0.Wrap_Range(Input_In: Arg_In_15, Range_In: Range_In, Output_Out: out T Output_16);
                return Output_16;
            }

            ;
            var builder_18 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_QMorE5ub492L304MitUyP4, 4);
            builder_18.Add(Functionality_5);
            builder_18.Add(Functionality_9);
            builder_18.Add(Functionality_13);
            builder_18.Add(Functionality_17);
            var __pin_group_Input_In_QMorE5ub492L304MitUyP4_19 = builder_18.Commit();
            n21._Operations_.Switch<n2.Func<T, T>, AdM>(Index_In: Index_1, Input_In: __pin_group_Input_In_QMorE5ub492L304MitUyP4_19, Output_Out: out n2.Func<T, T> Output_20);
            n48._Operations_.Invoke<T, T>(Input_In: Output_20, Arg_In: Input_In, Result_Out: out T Result_21);
            Output_Out = Result_21;
            return;
        }
    }
}

namespace _VL_Animation_.Animation.Functions
{
    [n1.ElementAttribute(TracingId = 54915U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "UgzdRDDnTnyLEpY3BXDw25", Name = "OscillatorFunction_C")]
    [n2.SerializableAttribute]
    public class OscillatorFunction_C<T> : n1.VLObject, n51.IFunctionAndTwoDerivativesSampler<double, T>, n51.IFunctionTwoDerivativesSampler<double, T>, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n33.OscillatorFunction_C<T> Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new OscillatorFunction_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n33.OscillatorFunction_C<T> CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new OscillatorFunction_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.OscillatorFunction_C<T> Sample_(double Input_In, out T Output_Out, out T Derivative_Out, out T Second_Derivative_Out)
        {
            double __auto_0 = this.X0;
            n52.IInternalOscillatorFunction_I<T, float> __auto_1 = this.Function;
            var Output_2 = Input_In - __auto_0;
            var Result_3 = n15.IntegerConversions.ToFloat32(input: Output_2);
            var Output_7 = ((n52.IInternalOscillatorFunction_I<T, float>)__auto_1).Sample(t_In: Result_3, p_Out: out T p_4, v_Out: out T v_5, a_Out: out T a_6);
            Output_Out = p_4;
            Derivative_Out = v_5;
            Second_Derivative_Out = a_6;
            return this;
        }

        public n33.OscillatorFunction_C<T> SampleDerivative_(double Input_In, out T Derivative_Out, out T Second_Derivative_Out)
        {
            double __auto_0 = this.X0;
            n52.IInternalOscillatorFunction_I<T, float> __auto_1 = this.Function;
            var Output_2 = Input_In - __auto_0;
            var Result_3 = n15.IntegerConversions.ToFloat32(input: Output_2);
            var Output_7 = ((n52.IInternalOscillatorFunction_I<T, float>)__auto_1).Sample(t_In: Result_3, p_Out: out T p_4, v_Out: out T v_5, a_Out: out T a_6);
            Derivative_Out = v_5;
            Second_Derivative_Out = a_6;
            return this;
        }

        public n33.OscillatorFunction_C<T> GetDomain(out n40.Range<double> Output_Out)
        {
            n40.Range<double> __auto_0 = this.Domain;
            Output_Out = __auto_0;
            return this;
        }

        public n33.OscillatorFunction_C<T> Update<AdM>(double X0_In, T Value0_In, T Derivative0_In, T Value1_In, float Damping_In, float Cycles_In, bool Cyclic_In, bool Force_In, double X1_In)
            where AdM : struct, n54.IAdaptiveToFloat32<float>, n55.IAdaptiveToFloat64<float>, n9.IAdaptiveOperatorMulitply_Scale<float>, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveRound_Float<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>, n56.IAdaptiveCos<float>, n9.IAdaptiveOperatorDivide_Scale<T>, n56.IAdaptiveSin<float>
        {
            var w_0 = default(AdM);
            this.X0 = X0_In;
            double __auto_1 = X0_In;
            n41._Operations_.Range_Join<double>(From_In: X0_In, To_In: X1_In, Output_Out: out n40.Range<double> Output_2);
            this.Domain = Output_2;
            n40.Range<double> __auto_3 = Output_2;
            var State_Output_5 = this.__p_IeT7cz0lSHRNSnSaG5yZ89.Update(Simulate_In: Force_In, Output_Out: out bool Output_4);
            this.__p_IeT7cz0lSHRNSnSaG5yZ89 = State_Output_5;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_NlgdPKKwK96QCu62lVmput;
            if (manager_7 is null)
            {
                manager_7 = new n53.Manager<n2.ValueTuple<T, T, T, float, float, bool>, n2.ValueTuple<n52.IInternalOscillatorFunction_I<T, float>>>(n2.ValueTuple.Create(default(n52.IInternalOscillatorFunction_I<T, float>)));
            }

            var inputs_8 = (Value0_In, Derivative0_In, Value1_In, Damping_In, Cycles_In, Cyclic_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Output_4 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                n52._Operations_.SelectFunction<T, AdM>(Value0_In: Value0_In, Derivative0_In: Derivative0_In, Value1_In: Value1_In, Damping_In: Damping_In, Cycles_In: Cycles_In, Cyclic_In: Cyclic_In, Output_Out: out n52.IInternalOscillatorFunction_I<T, float> Output_12);
                outputs_9 = n2.ValueTuple.Create(Output_12);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, default, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_13 = outputs_9.Item1;
            this.__cache_NlgdPKKwK96QCu62lVmput = manager_7;
            this.Function = __auto_13;
            n52.IInternalOscillatorFunction_I<T, float> __auto_14 = __auto_13;
            return this;
        }

        public n33.OscillatorFunction_C<T> __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.X0 = 0;
            this.Domain = n41._Operations_.CreateDefault_H<double, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            this.Function = default(n52.IInternalOscillatorFunction_I<T, float>);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "IeT7cz0lSHRNSnSaG5yZ89", 74083U);
            var Output_1 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            this.__p_IeT7cz0lSHRNSnSaG5yZ89 = Output_1;
            this.__cache_NlgdPKKwK96QCu62lVmput = null;
            return this;
        }

        public n33.OscillatorFunction_C<T> __CreateDefault__()
        {
            this.X0 = 0;
            this.Domain = n41._Operations_.CreateDefault_H<double, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            this.Function = default(n52.IInternalOscillatorFunction_I<T, float>);
            this.__p_IeT7cz0lSHRNSnSaG5yZ89 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_NlgdPKKwK96QCu62lVmput = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IeT7cz0lSHRNSnSaG5yZ89);
            n1.CompilationHelper.SafeDispose(this.__cache_NlgdPKKwK96QCu62lVmput);
            return;
        }

        void n51.IFunctionAndTwoDerivativesSampler<double, T>.Sample(double input, out T output, out T derivative, out T secondDerivative)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(input, out output, out derivative, out secondDerivative);
        }

        void n51.IFunctionTwoDerivativesSampler<double, T>.SampleDerivative(double input, out T derivative, out T secondDerivative)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SampleDerivative_(input, out derivative, out secondDerivative);
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        void n51.IFunctionAndDerivativeSampler<double, T>.Sample(double input, out T output, out T derivative)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(input, out output, out derivative, out T out_Second_Derivative_Out);
        }

        void n51.IFunctionSampler<double, T>.Sample(double input, out T output)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(input, out output, out T out_Derivative_Out, out T out_Second_Derivative_Out);
        }

        void n51.IFunctionDerivativeSampler<double, T>.SampleDerivative(double input, out T derivative)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SampleDerivative_(input, out derivative, out T out_Second_Derivative_Out);
        }

        [n1.ElementAttribute(TracingId = 74037U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "N6uPZtpCCv9MDkEufslMgA", Name = "X0")]
        public double X0;
        [n1.ElementAttribute(TracingId = 55027U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "MawzYJLwBsPL4XzJyXdSXT", Name = "Domain")]
        public n40.Range<double> Domain;
        [n1.ElementAttribute(TracingId = 74033U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "OPXCM0vRLZqMHZzADo8sE2", Name = "Function")]
        public n52.IInternalOscillatorFunction_I<T, float> Function;
        [n1.ElementAttribute(TracingId = 74083U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "IeT7cz0lSHRNSnSaG5yZ89", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_IeT7cz0lSHRNSnSaG5yZ89;
        [n1.ElementAttribute(TracingId = 54936U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NlgdPKKwK96QCu62lVmput", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n53.Manager<n2.ValueTuple<T, T, T, float, float, bool>, n2.ValueTuple<n52.IInternalOscillatorFunction_I<T, float>>> __cache_NlgdPKKwK96QCu62lVmput = null;
        public OscillatorFunction_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OscillatorFunction_C(OscillatorFunction_C<T> other): base(other)
        {
            this.X0 = other.X0;
            this.Domain = other.Domain;
            this.Function = other.Function;
            this.__p_IeT7cz0lSHRNSnSaG5yZ89 = other.__p_IeT7cz0lSHRNSnSaG5yZ89;
            this.__cache_NlgdPKKwK96QCu62lVmput = other.__cache_NlgdPKKwK96QCu62lVmput;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "X0", in X0), n1.CompilationHelper.GetValueOrExisting(values, "Domain", in Domain), n1.CompilationHelper.GetValueOrExisting(values, "Function", in Function), n1.CompilationHelper.GetValueOrExisting(values, "__p_IeT7cz0lSHRNSnSaG5yZ89", in __p_IeT7cz0lSHRNSnSaG5yZ89), n1.CompilationHelper.GetValueOrExisting(values, "__cache_NlgdPKKwK96QCu62lVmput", in __cache_NlgdPKKwK96QCu62lVmput));
        }

        internal OscillatorFunction_C<T> __WITH__(double X0, n40.Range<double> Domain, n52.IInternalOscillatorFunction_I<T, float> Function, n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_IeT7cz0lSHRNSnSaG5yZ89, n53.Manager<n2.ValueTuple<T, T, T, float, float, bool>, n2.ValueTuple<n52.IInternalOscillatorFunction_I<T, float>>> __cache_NlgdPKKwK96QCu62lVmput)
        {
            n33.OscillatorFunction_C<T> that_0 = this;
            this.X0 = X0;
            this.Domain = Domain;
            this.Function = Function;
            this.__p_IeT7cz0lSHRNSnSaG5yZ89 = __p_IeT7cz0lSHRNSnSaG5yZ89;
            this.__cache_NlgdPKKwK96QCu62lVmput = __cache_NlgdPKKwK96QCu62lVmput;
            return that_0;
        }
    }
}

namespace _VL_Animation_.Animation.Functions.OscillatorFunction.Internal
{
    [n1.ElementAttribute(TracingId = 55033U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "M2h4YKHw0sjOfekOliLm8u", Name = "OscillatorFunctionOSC_C")]
    [n2.SerializableAttribute]
    public abstract class OscillatorFunctionOSC_C<T2, T> : n1.VLObject, n52.IInternalOscillatorFunction_I<T2, T>, n2.IDisposable
    {
        [n2.SerializableAttribute]
        [n4.PrivateImplAttribute]
        sealed class Impl<AdC> : OscillatorFunctionOSC_C<T2, T> where AdC : struct, n56.IAdaptiveCos<T>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n56.IAdaptiveSin<T>, n9.IAdaptiveOperatorMinus_Negate<T2>, n9.IAdaptiveOperatorMinus<T2>, n54.IAdaptiveToFloat32<T>
        {
            public override n52.OscillatorFunctionOSC_C<T2, T> Join_(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In)
            {
                var w_0 = default(AdC);
                w_0.OperatorMinus(Input_In: p0_In, Input_2_In: p1_In, Output_Out: out T2 Output_1);
                this.p1 = p1_In;
                T2 __auto_2 = p1_In;
                w_0.OperatorMulitply_Scale(Input_In: Output_1, Scalar_In: damping_In, Output_Out: out T2 Output_3);
                w_0.OperatorMulitply_Scale(Input_In: v0_In, Scalar_In: damping_In, Output_Out: out T2 Output_4);
                w_0.OperatorPlus(Input_In: Output_3, Input_2_In: v0_In, Output_Out: out T2 Output_5);
                var Output_6 = -squaredDampingMinusEnergy_In;
                var Output_7 = n15.Float32Extensions.Sqrt(input: Output_6);
                w_0.OperatorDivide_Scale(Input_In: Output_5, Scalar_In: Output_7, Output_Out: out T2 Output_8);
                w_0.OperatorMulitply_Scale(Input_In: Output_1, Scalar_In: energy_In, Output_Out: out T2 Output_9);
                w_0.OperatorPlus(Input_In: Output_9, Input_2_In: Output_4, Output_Out: out T2 Output_10);
                w_0.OperatorDivide_Scale(Input_In: Output_10, Scalar_In: Output_7, Output_Out: out T2 Output_11);
                w_0.OperatorPlus(Input_In: Output_10, Input_2_In: Output_4, Output_Out: out T2 Output_12);
                this.opta21 = Output_12;
                T2 __auto_13 = Output_12;
                this.optv = Output_11;
                T2 __auto_14 = Output_11;
                w_0.OperatorMulitply_Scale(Input_In: Output_11, Scalar_In: damping_In, Output_Out: out T2 Output_15);
                w_0.OperatorMulitply_Scale(Input_In: v0_In, Scalar_In: Output_7, Output_Out: out T2 Output_16);
                w_0.OperatorMinus(Input_In: Output_16, Input_2_In: Output_15, Output_Out: out T2 Output_17);
                this.opta22 = Output_17;
                T2 __auto_18 = Output_17;
                this.proot = Output_7;
                float __auto_19 = Output_7;
                this.optp = Output_8;
                T2 __auto_20 = Output_8;
                this.v0 = v0_In;
                T2 __auto_21 = v0_In;
                this.damping = damping_In;
                float __auto_22 = damping_In;
                this.p10 = Output_1;
                T2 __auto_23 = Output_1;
                return this;
            }

            public override n52.OscillatorFunctionOSC_C<T2, T> Sample_(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out)
            {
                var w_0 = default(AdC);
                float __auto_1 = this.proot;
                T2 __auto_2 = this.p10;
                T2 __auto_3 = this.optp;
                T2 __auto_4 = this.optv;
                T2 __auto_5 = this.v0;
                float __auto_6 = this.damping;
                T2 __auto_7 = this.p1;
                T2 __auto_8 = this.opta21;
                T2 __auto_9 = this.opta22;
                w_0.OperatorMulitply_Scale(Input_In: t_In, Scalar_In: __auto_1, Output_Out: out T Output_10);
                w_0.Cos(Input_In: Output_10, Output_Out: out T Output_11);
                w_0.ToFloat32(Input_In: Output_11, Result_Out: out float Result_12);
                w_0.OperatorMulitply_Scale(Input_In: __auto_2, Scalar_In: Result_12, Output_Out: out T2 Output_13);
                w_0.Sin(Input_In: Output_10, Output_Out: out T Output_14);
                w_0.ToFloat32(Input_In: Output_14, Result_Out: out float Result_15);
                w_0.OperatorMulitply_Scale(Input_In: __auto_3, Scalar_In: Result_15, Output_Out: out T2 Output_16);
                w_0.OperatorPlus(Input_In: Output_13, Input_2_In: Output_16, Output_Out: out T2 Output_17);
                w_0.OperatorMulitply_Scale(Input_In: __auto_4, Scalar_In: Result_15, Output_Out: out T2 Output_18);
                w_0.OperatorMulitply_Scale(Input_In: __auto_5, Scalar_In: Result_12, Output_Out: out T2 Output_19);
                w_0.OperatorMinus(Input_In: Output_19, Input_2_In: Output_18, Output_Out: out T2 Output_20);
                var Output_21 = -__auto_6;
                w_0.OperatorMulitply_Scale(Input_In: t_In, Scalar_In: Output_21, Output_Out: out T Output_22);
                w_0.ToFloat64(Input_In: Output_22, Result_Out: out double Result_23);
                var Output_24 = n2.Math.Exp(d: Result_23);
                var Result_25 = n15.IntegerConversions.ToFloat32(input: Output_24);
                w_0.OperatorMulitply_Scale(Input_In: Output_20, Scalar_In: Result_25, Output_Out: out T2 Output_26);
                w_0.OperatorMulitply_Scale(Input_In: Output_17, Scalar_In: Result_25, Output_Out: out T2 Output_27);
                w_0.OperatorPlus(Input_In: __auto_7, Input_2_In: Output_27, Output_Out: out T2 Output_28);
                w_0.OperatorMulitply_Scale(Input_In: __auto_8, Scalar_In: Result_12, Output_Out: out T2 Output_29);
                w_0.OperatorMulitply_Scale(Input_In: __auto_9, Scalar_In: Result_15, Output_Out: out T2 Output_30);
                w_0.OperatorPlus(Input_In: Output_29, Input_2_In: Output_30, Output_Out: out T2 Output_31);
                w_0.OperatorMulitply_Scale(Input_In: Output_31, Scalar_In: Result_25, Output_Out: out T2 Output_32);
                w_0.OperatorMinus_Negate(Input_In: Output_32, Output_Out: out T2 Output_33);
                p_Out = Output_28;
                v_Out = Output_26;
                a_Out = Output_33;
                return this;
            }

            public override n52.OscillatorFunctionOSC_C<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            {
                n10.RuntimeHelpers.EnsureSufficientExecutionStack();
                var w_0 = default(AdM);
                w_0.CreateDefault(out T2 __out_4);
                this.p10 = __out_4;
                w_0.CreateDefault(out T2 __out_5);
                this.p1 = __out_5;
                w_0.CreateDefault(out T2 __out_6);
                this.optp = __out_6;
                this.proot = 0F;
                this.damping = 0F;
                w_0.CreateDefault(out T2 __out_7);
                this.v0 = __out_7;
                w_0.CreateDefault(out T2 __out_8);
                this.optv = __out_8;
                w_0.CreateDefault(out T2 __out_9);
                this.opta21 = __out_9;
                w_0.CreateDefault(out T2 __out_10);
                this.opta22 = __out_10;
                return this;
            }

            public override n52.OscillatorFunctionOSC_C<T2, T> __CreateDefault__<AdM>()
            {
                var w_0 = default(AdM);
                w_0.CreateDefault(out T2 __out_11);
                this.p10 = __out_11;
                w_0.CreateDefault(out T2 __out_12);
                this.p1 = __out_12;
                w_0.CreateDefault(out T2 __out_13);
                this.optp = __out_13;
                this.proot = 0F;
                this.damping = 0F;
                w_0.CreateDefault(out T2 __out_14);
                this.v0 = __out_14;
                w_0.CreateDefault(out T2 __out_15);
                this.optv = __out_15;
                w_0.CreateDefault(out T2 __out_16);
                this.opta21 = __out_16;
                w_0.CreateDefault(out T2 __out_17);
                this.opta22 = __out_17;
                return this;
            }

            public override void Dispose()
            {
                var w_0 = default(AdC);
                return;
            }

            [n1.ElementAttribute(TracingId = 56567U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "PYZPkPy3njnPOyABXHqNia", Name = "__slot_PYZPkPy3njnPOyABXHqNia")]
            public static string __slot_PYZPkPy3njnPOyABXHqNia = " e ";
            [n1.ElementAttribute(TracingId = 56578U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Cdpde9GmDTXP1cfn3GocCl", Name = "__slot_Cdpde9GmDTXP1cfn3GocCl")]
            public static string __slot_Cdpde9GmDTXP1cfn3GocCl = "alpha ";
            [n1.ElementAttribute(TracingId = 56583U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "PegjpF00vHVL6nqGFldDVO", Name = "__slot_PegjpF00vHVL6nqGFldDVO")]
            public static string __slot_PegjpF00vHVL6nqGFldDVO = " t ";
            [n1.ElementAttribute(TracingId = 56589U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "E7LrbO4job1OTW0tpBDJqe", Name = "__slot_E7LrbO4job1OTW0tpBDJqe")]
            public static string __slot_E7LrbO4job1OTW0tpBDJqe = "second case";
            [n1.ElementAttribute(TracingId = 55051U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "EVJAcAMNmBeNH1EOqR2yWI", Name = "p10")]
            public T2 p10;
            [n1.ElementAttribute(TracingId = 55048U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Bw15drys3RpN8ccQ1axBQu", Name = "p1")]
            public T2 p1;
            [n1.ElementAttribute(TracingId = 55057U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NMcrwF6UTprMS7pZDzFGiW", Name = "optp")]
            public T2 optp;
            [n1.ElementAttribute(TracingId = 55044U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Ti3lGBrm8EEOgk0lO1WpNz", Name = "proot")]
            public float proot;
            [n1.ElementAttribute(TracingId = 56422U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FcziJTTsuQGNXpHmpPvt9n", Name = "damping")]
            public float damping;
            [n1.ElementAttribute(TracingId = 56427U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "MvDqf9Kib6hPUG9BQtR5SJ", Name = "v0")]
            public T2 v0;
            [n1.ElementAttribute(TracingId = 56430U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "VnMYt9vDhmeNn5cqytXUWy", Name = "optv")]
            public T2 optv;
            [n1.ElementAttribute(TracingId = 56601U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "MmgYLNr6dLxM3mvpVm5NsJ", Name = "opta21")]
            public T2 opta21;
            [n1.ElementAttribute(TracingId = 56604U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "GMHUQhdhpUdLsGiSzNeyWH", Name = "opta22")]
            public T2 opta22;
            static Impl()
            {
            }

            public Impl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal Impl(Impl<AdC> other): base(other)
            {
                this.p10 = other.p10;
                this.p1 = other.p1;
                this.optp = other.optp;
                this.proot = other.proot;
                this.damping = other.damping;
                this.v0 = other.v0;
                this.optv = other.optv;
                this.opta21 = other.opta21;
                this.opta22 = other.opta22;
            }

            protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "p10", in p10), n1.CompilationHelper.GetValueOrExisting(values, "p1", in p1), n1.CompilationHelper.GetValueOrExisting(values, "optp", in optp), n1.CompilationHelper.GetValueOrExisting(values, "proot", in proot), n1.CompilationHelper.GetValueOrExisting(values, "damping", in damping), n1.CompilationHelper.GetValueOrExisting(values, "v0", in v0), n1.CompilationHelper.GetValueOrExisting(values, "optv", in optv), n1.CompilationHelper.GetValueOrExisting(values, "opta21", in opta21), n1.CompilationHelper.GetValueOrExisting(values, "opta22", in opta22));
            }

            internal OscillatorFunctionOSC_C<T2, T> __WITH__(T2 p10, T2 p1, T2 optp, float proot, float damping, T2 v0, T2 optv, T2 opta21, T2 opta22)
            {
                OscillatorFunctionOSC_C<T2, T> that_1 = this;
                this.p10 = p10;
                this.p1 = p1;
                this.optp = optp;
                this.proot = proot;
                this.damping = damping;
                this.v0 = v0;
                this.optv = optv;
                this.opta21 = opta21;
                this.opta22 = opta22;
                return that_1;
            }
        }

        public OscillatorFunctionOSC_C(n1.NodeContext context, uint identity): base(context, identity)
        {
        }

        protected OscillatorFunctionOSC_C(OscillatorFunctionOSC_C<T2, T> other): base(other)
        {
        }

        [n4.CreateNewAttribute]
        public static n52.OscillatorFunctionOSC_C<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n56.IAdaptiveCos<T>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n56.IAdaptiveSin<T>, n9.IAdaptiveOperatorMinus_Negate<T2>, n9.IAdaptiveOperatorMinus<T2>, n54.IAdaptiveToFloat32<T>
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Impl<AdM>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        public abstract n52.OscillatorFunctionOSC_C<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n56.IAdaptiveCos<T>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n56.IAdaptiveSin<T>, n9.IAdaptiveOperatorMinus_Negate<T2>, n9.IAdaptiveOperatorMinus<T2>, n54.IAdaptiveToFloat32<T>;
        public abstract n52.OscillatorFunctionOSC_C<T2, T> Join_(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In);
        public abstract n52.OscillatorFunctionOSC_C<T2, T> Sample_(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out);
        [n4.CreateDefaultAttribute]
        public static n52.OscillatorFunctionOSC_C<T2, T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n56.IAdaptiveCos<T>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n56.IAdaptiveSin<T>, n9.IAdaptiveOperatorMinus_Negate<T2>, n9.IAdaptiveOperatorMinus<T2>, n54.IAdaptiveToFloat32<T>
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Impl<AdM>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public abstract n52.OscillatorFunctionOSC_C<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n56.IAdaptiveCos<T>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n56.IAdaptiveSin<T>, n9.IAdaptiveOperatorMinus_Negate<T2>, n9.IAdaptiveOperatorMinus<T2>, n54.IAdaptiveToFloat32<T>;
        public abstract void Dispose();
        n52.IInternalOscillatorFunction_I<T2, T> n52.IInternalOscillatorFunction_I<T2, T>.Sample(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(t_In, out p_Out, out v_Out, out a_Out);
            return this;
        }

        n52.IInternalOscillatorFunction_I<T2, T> n52.IInternalOscillatorFunction_I<T2, T>.Join(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Join_(p0_In, p1_In, damping_In, squaredDampingMinusEnergy_In, v0_In, energy_In);
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }
    }

    [n1.ElementAttribute(TracingId = 58257U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KeilNn5G7t8OKmsaq5FEPA", Name = "IInternalOscillatorFunction_I")]
    public interface IInternalOscillatorFunction_I<T2, T> : n1.IVLObject
    {
        public n52.IInternalOscillatorFunction_I<T2, T> Sample(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out);
        public n52.IInternalOscillatorFunction_I<T2, T> Join(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In);
    }

    [n1.ElementAttribute(TracingId = 61802U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "AcP4MISlUlGNMpvKzyUHKc", Name = "OscillatorFunctionHYP_C")]
    [n2.SerializableAttribute]
    public abstract class OscillatorFunctionHYP_C<T2, T> : n1.VLObject, n52.IInternalOscillatorFunction_I<T2, T>, n2.IDisposable
    {
        [n2.SerializableAttribute]
        [n4.PrivateImplAttribute]
        sealed class Impl<AdC> : OscillatorFunctionHYP_C<T2, T> where AdC : struct, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorMinus<T2>
        {
            public override n52.OscillatorFunctionHYP_C<T2, T> Join_(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In)
            {
                var w_0 = default(AdC);
                w_0.OperatorMinus(Input_In: p0_In, Input_2_In: p1_In, Output_Out: out T2 Output_1);
                this.p1 = p1_In;
                T2 __auto_2 = p1_In;
                w_0.OperatorMulitply_Scale(Input_In: Output_1, Scalar_In: damping_In, Output_Out: out T2 Output_3);
                w_0.OperatorMulitply_Scale(Input_In: v0_In, Scalar_In: damping_In, Output_Out: out T2 Output_4);
                w_0.OperatorPlus(Input_In: Output_3, Input_2_In: v0_In, Output_Out: out T2 Output_5);
                var Output_6 = n15.Float32Extensions.Sqrt(input: squaredDampingMinusEnergy_In);
                w_0.OperatorDivide_Scale(Input_In: Output_5, Scalar_In: Output_6, Output_Out: out T2 Output_7);
                w_0.OperatorMulitply_Scale(Input_In: Output_1, Scalar_In: energy_In, Output_Out: out T2 Output_8);
                w_0.OperatorPlus(Input_In: Output_8, Input_2_In: Output_4, Output_Out: out T2 Output_9);
                w_0.OperatorDivide_Scale(Input_In: Output_9, Scalar_In: Output_6, Output_Out: out T2 Output_10);
                this.optv = Output_10;
                T2 __auto_11 = Output_10;
                w_0.OperatorMinus(Input_In: v0_In, Input_2_In: Output_10, Output_Out: out T2 Output_12);
                var Output_13 = -damping_In;
                var Output_14 = Output_13 + Output_6;
                w_0.OperatorMulitply_Scale(Input_In: Output_12, Scalar_In: Output_14, Output_Out: out T2 Output_15);
                var Output_16 = Output_13 - Output_6;
                this.optminus = Output_16;
                float __auto_17 = Output_16;
                w_0.OperatorPlus(Input_In: v0_In, Input_2_In: Output_10, Output_Out: out T2 Output_18);
                w_0.OperatorMulitply_Scale(Input_In: Output_18, Scalar_In: Output_16, Output_Out: out T2 Output_19);
                this.opta12 = Output_19;
                T2 __auto_20 = Output_19;
                this.optplus = Output_14;
                float __auto_21 = Output_14;
                this.opta11 = Output_15;
                T2 __auto_22 = Output_15;
                this.optp = Output_7;
                T2 __auto_23 = Output_7;
                this.v0 = v0_In;
                T2 __auto_24 = v0_In;
                this.p10 = Output_1;
                T2 __auto_25 = Output_1;
                return this;
            }

            public override n52.OscillatorFunctionHYP_C<T2, T> Sample_(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out)
            {
                var w_0 = default(AdC);
                float __auto_1 = this.optplus;
                float __auto_2 = this.optminus;
                T2 __auto_3 = this.p10;
                T2 __auto_4 = this.optp;
                T2 __auto_5 = this.optv;
                T2 __auto_6 = this.v0;
                T2 __auto_7 = this.p1;
                T2 __auto_8 = this.opta12;
                T2 __auto_9 = this.opta11;
                w_0.OperatorMulitply_Scale(Input_In: t_In, Scalar_In: __auto_1, Output_Out: out T Output_10);
                w_0.ToFloat64(Input_In: Output_10, Result_Out: out double Result_11);
                var Output_12 = n2.Math.Exp(d: Result_11);
                var Result_13 = n15.IntegerConversions.ToFloat32(input: Output_12);
                w_0.OperatorMulitply_Scale(Input_In: t_In, Scalar_In: __auto_2, Output_Out: out T Output_14);
                w_0.ToFloat64(Input_In: Output_14, Result_Out: out double Result_15);
                var Output_16 = n2.Math.Exp(d: Result_15);
                var Result_17 = n15.IntegerConversions.ToFloat32(input: Output_16);
                var Output_18 = Result_17 - Result_13;
                var Output_19 = Result_17 + Result_13;
                w_0.OperatorMulitply_Scale(Input_In: __auto_3, Scalar_In: Output_19, Output_Out: out T2 Output_20);
                w_0.OperatorMulitply_Scale(Input_In: __auto_4, Scalar_In: Output_18, Output_Out: out T2 Output_21);
                w_0.OperatorMinus(Input_In: Output_20, Input_2_In: Output_21, Output_Out: out T2 Output_22);
                w_0.OperatorMulitply_Scale(Input_In: __auto_5, Scalar_In: Output_18, Output_Out: out T2 Output_23);
                w_0.OperatorMulitply_Scale(Input_In: __auto_6, Scalar_In: Output_19, Output_Out: out T2 Output_24);
                w_0.OperatorPlus(Input_In: Output_24, Input_2_In: Output_23, Output_Out: out T2 Output_25);
                float Scalar_26 = 0.5F;
                w_0.OperatorMulitply_Scale(Input_In: Output_25, Scalar_In: Scalar_26, Output_Out: out T2 Output_27);
                float Scalar_28 = 0.5F;
                w_0.OperatorMulitply_Scale(Input_In: Output_22, Scalar_In: Scalar_28, Output_Out: out T2 Output_29);
                w_0.OperatorPlus(Input_In: __auto_7, Input_2_In: Output_29, Output_Out: out T2 Output_30);
                w_0.OperatorMulitply_Scale(Input_In: __auto_8, Scalar_In: Result_17, Output_Out: out T2 Output_31);
                w_0.OperatorMulitply_Scale(Input_In: __auto_9, Scalar_In: Result_13, Output_Out: out T2 Output_32);
                w_0.OperatorPlus(Input_In: Output_32, Input_2_In: Output_31, Output_Out: out T2 Output_33);
                float Scalar_34 = 0.5F;
                w_0.OperatorMulitply_Scale(Input_In: Output_33, Scalar_In: Scalar_34, Output_Out: out T2 Output_35);
                p_Out = Output_30;
                v_Out = Output_27;
                a_Out = Output_35;
                return this;
            }

            public override n52.OscillatorFunctionHYP_C<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            {
                n10.RuntimeHelpers.EnsureSufficientExecutionStack();
                var w_0 = default(AdM);
                w_0.CreateDefault(out T2 __out_18);
                this.p10 = __out_18;
                w_0.CreateDefault(out T2 __out_19);
                this.p1 = __out_19;
                w_0.CreateDefault(out T2 __out_20);
                this.optp = __out_20;
                w_0.CreateDefault(out T2 __out_21);
                this.v0 = __out_21;
                w_0.CreateDefault(out T2 __out_22);
                this.optv = __out_22;
                this.optminus = 0F;
                this.optplus = 0F;
                w_0.CreateDefault(out T2 __out_23);
                this.opta11 = __out_23;
                w_0.CreateDefault(out T2 __out_24);
                this.opta12 = __out_24;
                return this;
            }

            public override n52.OscillatorFunctionHYP_C<T2, T> __CreateDefault__<AdM>()
            {
                var w_0 = default(AdM);
                w_0.CreateDefault(out T2 __out_25);
                this.p10 = __out_25;
                w_0.CreateDefault(out T2 __out_26);
                this.p1 = __out_26;
                w_0.CreateDefault(out T2 __out_27);
                this.optp = __out_27;
                w_0.CreateDefault(out T2 __out_28);
                this.v0 = __out_28;
                w_0.CreateDefault(out T2 __out_29);
                this.optv = __out_29;
                this.optminus = 0F;
                this.optplus = 0F;
                w_0.CreateDefault(out T2 __out_30);
                this.opta11 = __out_30;
                w_0.CreateDefault(out T2 __out_31);
                this.opta12 = __out_31;
                return this;
            }

            public override void Dispose()
            {
                var w_0 = default(AdC);
                return;
            }

            [n1.ElementAttribute(TracingId = 61931U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "N5o2HXtmrVNOlUUIE5c7PY", Name = "__slot_N5o2HXtmrVNOlUUIE5c7PY")]
            public static string __slot_N5o2HXtmrVNOlUUIE5c7PY = " e ";
            [n1.ElementAttribute(TracingId = 61943U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "J3xQ31hlySdQZA5qjvzuaN", Name = "__slot_J3xQ31hlySdQZA5qjvzuaN")]
            public static string __slot_J3xQ31hlySdQZA5qjvzuaN = "first case";
            [n1.ElementAttribute(TracingId = 61983U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "JqHFJgQmTOJQQxJCA5G44f", Name = "__slot_JqHFJgQmTOJQQxJCA5G44f")]
            public static string __slot_JqHFJgQmTOJQQxJCA5G44f = ":( no adaptive exp";
            [n1.ElementAttribute(TracingId = 62195U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Hk8TTofg0JdOwh0xp7OSxw", Name = "__slot_Hk8TTofg0JdOwh0xp7OSxw")]
            public static string __slot_Hk8TTofg0JdOwh0xp7OSxw = " _plus";
            [n1.ElementAttribute(TracingId = 62203U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "E0rBpcczDgRMSmRkUC7o2L", Name = "__slot_E0rBpcczDgRMSmRkUC7o2L")]
            public static string __slot_E0rBpcczDgRMSmRkUC7o2L = " _minus";
            [n1.ElementAttribute(TracingId = 62213U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "F04eqpyeLa7PxLWaGS3Exo", Name = "__slot_F04eqpyeLa7PxLWaGS3Exo")]
            public static string __slot_F04eqpyeLa7PxLWaGS3Exo = " eplus";
            [n1.ElementAttribute(TracingId = 62218U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Iu5pNk5R4AfMhOpPPlqNu3", Name = "__slot_Iu5pNk5R4AfMhOpPPlqNu3")]
            public static string __slot_Iu5pNk5R4AfMhOpPPlqNu3 = " eminus";
            [n1.ElementAttribute(TracingId = 61820U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "BpxRB3WSNBjLjor9BOJHdg", Name = "p10")]
            public T2 p10;
            [n1.ElementAttribute(TracingId = 61815U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "QuoUoDleEyfMurIoEbmKlq", Name = "p1")]
            public T2 p1;
            [n1.ElementAttribute(TracingId = 61822U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "GI0qUjbkGEALgxMpwXw5f7", Name = "optp")]
            public T2 optp;
            [n1.ElementAttribute(TracingId = 61825U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "RPDva0Sj4kkQU9koCVvoP4", Name = "v0")]
            public T2 v0;
            [n1.ElementAttribute(TracingId = 61827U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "CWLMjVfeZLhPScTJ0uIPjA", Name = "optv")]
            public T2 optv;
            [n1.ElementAttribute(TracingId = 62266U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "C6qjOTHKWZfPHyC9gI3VoB", Name = "optminus")]
            public float optminus;
            [n1.ElementAttribute(TracingId = 62271U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "BmHhUbUcELLNKXnwJ0jqak", Name = "optplus")]
            public float optplus;
            [n1.ElementAttribute(TracingId = 62320U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FtapkDrSabPNvhBZkzUkaB", Name = "opta11")]
            public T2 opta11;
            [n1.ElementAttribute(TracingId = 62323U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "ULgb0N5MUULLAgwVMKUFEn", Name = "opta12")]
            public T2 opta12;
            static Impl()
            {
            }

            public Impl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal Impl(Impl<AdC> other): base(other)
            {
                this.p10 = other.p10;
                this.p1 = other.p1;
                this.optp = other.optp;
                this.v0 = other.v0;
                this.optv = other.optv;
                this.optminus = other.optminus;
                this.optplus = other.optplus;
                this.opta11 = other.opta11;
                this.opta12 = other.opta12;
            }

            protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "p10", in p10), n1.CompilationHelper.GetValueOrExisting(values, "p1", in p1), n1.CompilationHelper.GetValueOrExisting(values, "optp", in optp), n1.CompilationHelper.GetValueOrExisting(values, "v0", in v0), n1.CompilationHelper.GetValueOrExisting(values, "optv", in optv), n1.CompilationHelper.GetValueOrExisting(values, "optminus", in optminus), n1.CompilationHelper.GetValueOrExisting(values, "optplus", in optplus), n1.CompilationHelper.GetValueOrExisting(values, "opta11", in opta11), n1.CompilationHelper.GetValueOrExisting(values, "opta12", in opta12));
            }

            internal OscillatorFunctionHYP_C<T2, T> __WITH__(T2 p10, T2 p1, T2 optp, T2 v0, T2 optv, float optminus, float optplus, T2 opta11, T2 opta12)
            {
                OscillatorFunctionHYP_C<T2, T> that_1 = this;
                this.p10 = p10;
                this.p1 = p1;
                this.optp = optp;
                this.v0 = v0;
                this.optv = optv;
                this.optminus = optminus;
                this.optplus = optplus;
                this.opta11 = opta11;
                this.opta12 = opta12;
                return that_1;
            }
        }

        public OscillatorFunctionHYP_C(n1.NodeContext context, uint identity): base(context, identity)
        {
        }

        protected OscillatorFunctionHYP_C(OscillatorFunctionHYP_C<T2, T> other): base(other)
        {
        }

        [n4.CreateNewAttribute]
        public static n52.OscillatorFunctionHYP_C<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorMinus<T2>
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Impl<AdM>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        public abstract n52.OscillatorFunctionHYP_C<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorMinus<T2>;
        public abstract n52.OscillatorFunctionHYP_C<T2, T> Join_(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In);
        public abstract n52.OscillatorFunctionHYP_C<T2, T> Sample_(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out);
        [n4.CreateDefaultAttribute]
        public static n52.OscillatorFunctionHYP_C<T2, T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorMinus<T2>
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Impl<AdM>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public abstract n52.OscillatorFunctionHYP_C<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T2>, n9.IAdaptiveOperatorPlus<T2>, n9.IAdaptiveOperatorDivide_Scale<T2>, n55.IAdaptiveToFloat64<T>, n9.IAdaptiveOperatorMulitply_Scale<T2>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorMinus<T2>;
        public abstract void Dispose();
        n52.IInternalOscillatorFunction_I<T2, T> n52.IInternalOscillatorFunction_I<T2, T>.Sample(T t_In, out T2 p_Out, out T2 v_Out, out T2 a_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(t_In, out p_Out, out v_Out, out a_Out);
            return this;
        }

        n52.IInternalOscillatorFunction_I<T2, T> n52.IInternalOscillatorFunction_I<T2, T>.Join(T2 p0_In, T2 p1_In, float damping_In, float squaredDampingMinusEnergy_In, T2 v0_In, float energy_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Join_(p0_In, p1_In, damping_In, squaredDampingMinusEnergy_In, v0_In, energy_In);
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }
    }

    [n1.ElementAttribute(TracingId = 66005U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "VJXamcW3duDO4lF7ZFBYJu", Name = "OscillatorFunctionDMP_C")]
    [n2.SerializableAttribute]
    public abstract class OscillatorFunctionDMP_C<T> : n1.VLObject, n52.IInternalOscillatorFunction_I<T, float>, n2.IDisposable
    {
        [n2.SerializableAttribute]
        [n4.PrivateImplAttribute]
        sealed class Impl<AdC> : OscillatorFunctionDMP_C<T> where AdC : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>
        {
            public override n52.OscillatorFunctionDMP_C<T> Join_(T p0_In, T p1_In, float damping_In, float squaredDampingMinusEnergy_In, T v0_In, float energy_In)
            {
                var w_0 = default(AdC);
                w_0.OperatorMinus(Input_In: p0_In, Input_2_In: p1_In, Output_Out: out T Output_1);
                this.p1 = p1_In;
                T __auto_2 = p1_In;
                w_0.OperatorMulitply_Scale(Input_In: Output_1, Scalar_In: damping_In, Output_Out: out T Output_3);
                this.damping = damping_In;
                float __auto_4 = damping_In;
                w_0.OperatorPlus(Input_In: Output_3, Input_2_In: v0_In, Output_Out: out T Output_5);
                w_0.OperatorMulitply_Scale(Input_In: Output_5, Scalar_In: damping_In, Output_Out: out T Output_6);
                this.v0 = v0_In;
                T __auto_7 = v0_In;
                w_0.OperatorMulitply_Scale(Input_In: v0_In, Scalar_In: damping_In, Output_Out: out T Output_8);
                w_0.OperatorPlus(Input_In: Output_6, Input_2_In: Output_8, Output_Out: out T Output_9);
                this.optv2 = Output_6;
                T __auto_10 = Output_6;
                w_0.OperatorMulitply_Scale(Input_In: Output_6, Scalar_In: damping_In, Output_Out: out T Output_11);
                this.opta31 = Output_11;
                T __auto_12 = Output_11;
                w_0.OperatorMinus_Negate(Input_In: Output_9, Output_Out: out T Output_13);
                this.opta32 = Output_13;
                T __auto_14 = Output_13;
                this.diffv = Output_5;
                T __auto_15 = Output_5;
                this.p10 = Output_1;
                T __auto_16 = Output_1;
                return this;
            }

            public override n52.OscillatorFunctionDMP_C<T> Sample_(float t_In, out T p_Out, out T v_Out, out T a_Out)
            {
                var w_0 = default(AdC);
                float __auto_1 = this.damping;
                T __auto_2 = this.v0;
                T __auto_3 = this.optv2;
                T __auto_4 = this.p10;
                T __auto_5 = this.diffv;
                T __auto_6 = this.p1;
                T __auto_7 = this.opta31;
                T __auto_8 = this.opta32;
                var Output_9 = -__auto_1;
                var Output_10 = n15.Float32Extensions.Scale(input: t_In, scalar: Output_9);
                var Result_11 = n15.IntegerConversions.ToFloat64(input: Output_10);
                var Output_12 = n2.Math.Exp(d: Result_11);
                var Result_13 = n15.IntegerConversions.ToFloat32(input: Output_12);
                w_0.OperatorMulitply_Scale(Input_In: __auto_3, Scalar_In: t_In, Output_Out: out T Output_14);
                w_0.OperatorMinus(Input_In: __auto_2, Input_2_In: Output_14, Output_Out: out T Output_15);
                w_0.OperatorMulitply_Scale(Input_In: Output_15, Scalar_In: Result_13, Output_Out: out T Output_16);
                var Output_17 = n15.IntegerConversions.ToFloat32(input: t_In);
                w_0.OperatorMulitply_Scale(Input_In: __auto_5, Scalar_In: Output_17, Output_Out: out T Output_18);
                w_0.OperatorPlus(Input_In: __auto_4, Input_2_In: Output_18, Output_Out: out T Output_19);
                w_0.OperatorMulitply_Scale(Input_In: Output_19, Scalar_In: Result_13, Output_Out: out T Output_20);
                w_0.OperatorPlus(Input_In: __auto_6, Input_2_In: Output_20, Output_Out: out T Output_21);
                w_0.OperatorMulitply_Scale(Input_In: __auto_7, Scalar_In: t_In, Output_Out: out T Output_22);
                w_0.OperatorPlus(Input_In: Output_22, Input_2_In: __auto_8, Output_Out: out T Output_23);
                w_0.OperatorMulitply_Scale(Input_In: Output_23, Scalar_In: Result_13, Output_Out: out T Output_24);
                p_Out = Output_21;
                v_Out = Output_16;
                a_Out = Output_24;
                return this;
            }

            public override n52.OscillatorFunctionDMP_C<T> __Create__<AdM>(n1.NodeContext Node_Context)
            {
                n10.RuntimeHelpers.EnsureSufficientExecutionStack();
                var w_0 = default(AdM);
                w_0.CreateDefault(out T __out_32);
                this.p10 = __out_32;
                w_0.CreateDefault(out T __out_33);
                this.p1 = __out_33;
                this.damping = 0F;
                w_0.CreateDefault(out T __out_34);
                this.v0 = __out_34;
                w_0.CreateDefault(out T __out_35);
                this.optv2 = __out_35;
                w_0.CreateDefault(out T __out_36);
                this.diffv = __out_36;
                w_0.CreateDefault(out T __out_37);
                this.opta32 = __out_37;
                w_0.CreateDefault(out T __out_38);
                this.opta31 = __out_38;
                return this;
            }

            public override n52.OscillatorFunctionDMP_C<T> __CreateDefault__<AdM>()
            {
                var w_0 = default(AdM);
                w_0.CreateDefault(out T __out_39);
                this.p10 = __out_39;
                w_0.CreateDefault(out T __out_40);
                this.p1 = __out_40;
                this.damping = 0F;
                w_0.CreateDefault(out T __out_41);
                this.v0 = __out_41;
                w_0.CreateDefault(out T __out_42);
                this.optv2 = __out_42;
                w_0.CreateDefault(out T __out_43);
                this.diffv = __out_43;
                w_0.CreateDefault(out T __out_44);
                this.opta32 = __out_44;
                w_0.CreateDefault(out T __out_45);
                this.opta31 = __out_45;
                return this;
            }

            public override void Dispose()
            {
                var w_0 = default(AdC);
                return;
            }

            [n1.ElementAttribute(TracingId = 66230U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FAeo0NIAk5QO41vZoN4XxT", Name = "__slot_FAeo0NIAk5QO41vZoN4XxT")]
            public static string __slot_FAeo0NIAk5QO41vZoN4XxT = "third case";
            [n1.ElementAttribute(TracingId = 66018U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "JAXuPjUmtdaNUmLZZJs0NY", Name = "p10")]
            public T p10;
            [n1.ElementAttribute(TracingId = 66014U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SSZFGcC8QV5O4JDrzuj3R6", Name = "p1")]
            public T p1;
            [n1.ElementAttribute(TracingId = 66141U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "POGPize4BvlPKakiZwnPTc", Name = "damping")]
            public float damping;
            [n1.ElementAttribute(TracingId = 66147U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "LbXxIRb3VrzMta5RkibyY2", Name = "v0")]
            public T v0;
            [n1.ElementAttribute(TracingId = 66152U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DKdFesAlRr6MBGn7hlK5Q9", Name = "optv2")]
            public T optv2;
            [n1.ElementAttribute(TracingId = 66249U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "BkWMZq0EpjEOqtHymVyXpe", Name = "diffv")]
            public T diffv;
            [n1.ElementAttribute(TracingId = 66364U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FbaDiRZQlsdPyOFyaqaT0B", Name = "opta32")]
            public T opta32;
            [n1.ElementAttribute(TracingId = 66368U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Us9MJUfPV4lLULlJpNEEID", Name = "opta31")]
            public T opta31;
            static Impl()
            {
            }

            public Impl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal Impl(Impl<AdC> other): base(other)
            {
                this.p10 = other.p10;
                this.p1 = other.p1;
                this.damping = other.damping;
                this.v0 = other.v0;
                this.optv2 = other.optv2;
                this.diffv = other.diffv;
                this.opta32 = other.opta32;
                this.opta31 = other.opta31;
            }

            protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "p10", in p10), n1.CompilationHelper.GetValueOrExisting(values, "p1", in p1), n1.CompilationHelper.GetValueOrExisting(values, "damping", in damping), n1.CompilationHelper.GetValueOrExisting(values, "v0", in v0), n1.CompilationHelper.GetValueOrExisting(values, "optv2", in optv2), n1.CompilationHelper.GetValueOrExisting(values, "diffv", in diffv), n1.CompilationHelper.GetValueOrExisting(values, "opta32", in opta32), n1.CompilationHelper.GetValueOrExisting(values, "opta31", in opta31));
            }

            internal OscillatorFunctionDMP_C<T> __WITH__(T p10, T p1, float damping, T v0, T optv2, T diffv, T opta32, T opta31)
            {
                OscillatorFunctionDMP_C<T> that_1 = this;
                this.p10 = p10;
                this.p1 = p1;
                this.damping = damping;
                this.v0 = v0;
                this.optv2 = optv2;
                this.diffv = diffv;
                this.opta32 = opta32;
                this.opta31 = opta31;
                return that_1;
            }
        }

        public OscillatorFunctionDMP_C(n1.NodeContext context, uint identity): base(context, identity)
        {
        }

        protected OscillatorFunctionDMP_C(OscillatorFunctionDMP_C<T> other): base(other)
        {
        }

        [n4.CreateNewAttribute]
        public static n52.OscillatorFunctionDMP_C<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Impl<AdM>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        public abstract n52.OscillatorFunctionDMP_C<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>;
        public abstract n52.OscillatorFunctionDMP_C<T> Join_(T p0_In, T p1_In, float damping_In, float squaredDampingMinusEnergy_In, T v0_In, float energy_In);
        public abstract n52.OscillatorFunctionDMP_C<T> Sample_(float t_In, out T p_Out, out T v_Out, out T a_Out);
        [n4.CreateDefaultAttribute]
        public static n52.OscillatorFunctionDMP_C<T> CreateDefault<AdM>()
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Impl<AdM>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public abstract n52.OscillatorFunctionDMP_C<T> __CreateDefault__<AdM>()
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>;
        public abstract void Dispose();
        n52.IInternalOscillatorFunction_I<T, float> n52.IInternalOscillatorFunction_I<T, float>.Sample(float t_In, out T p_Out, out T v_Out, out T a_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Sample_(t_In, out p_Out, out v_Out, out a_Out);
            return this;
        }

        n52.IInternalOscillatorFunction_I<T, float> n52.IInternalOscillatorFunction_I<T, float>.Join(T p0_In, T p1_In, float damping_In, float squaredDampingMinusEnergy_In, T v0_In, float energy_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Join_(p0_In, p1_In, damping_In, squaredDampingMinusEnergy_In, v0_In, energy_In);
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }
    }

    [n1.ElementAttribute(TracingId = 22372U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GetEnergyFromCyclesAndDamping<T, AdM>(T squaredDamping_In, T Cycles_In, out T Energy_Out)
            where AdM : struct, n9.IAdaptiveOne<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorGreaterThan<T>, n56.IAdaptiveCyclesToRadians<T>, n9.IAdaptiveOperatorMulitply<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>
        {
            var w_0 = default(AdM);
            w_0.CyclesToRadians(Input_In: Cycles_In, Output_Out: out T Output_1);
            w_0.CreateDefault(Output_Out: out T Output_2);
            w_0.OperatorGreaterThan(Input_In: Output_1, Input_2_In: Output_2, Result_Out: out bool Result_3);
            w_0.One(One_Out: out T One_4);
            w_0.OperatorMinus_Negate(Input_In: One_4, Output_Out: out T Output_5);
            n17._Operations_.Switch_Boolean<T>(Condition_In: Result_3, Input_In: Output_5, Input_2_In: One_4, Output_Out: out T Output_6);
            w_0.OperatorMulitply(Input_In: Output_1, Input_2_In: Output_1, Output_Out: out T Output_7);
            w_0.OperatorMulitply(Input_In: Output_7, Input_2_In: Output_6, Output_Out: out Output_7);
            w_0.OperatorPlus(Input_In: squaredDamping_In, Input_2_In: Output_7, Output_Out: out T Output_8);
            Energy_Out = Output_8;
            return;
        }

        public static void GetCyclicValue<T, AdM>(T Value0_In, T Derivative0_In, T Value1_In, float Damping_In, float Energy_In, out T Output_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveRound_Float<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            float Scalar_1 = 2F;
            w_0.OperatorMulitply_Scale(Input_In: Derivative0_In, Scalar_In: Scalar_1, Output_Out: out T Output_2);
            w_0.OperatorMulitply_Scale(Input_In: Output_2, Scalar_In: Damping_In, Output_Out: out Output_2);
            w_0.OperatorDivide_Scale(Input_In: Output_2, Scalar_In: Energy_In, Output_Out: out T Output_3);
            w_0.OperatorPlus(Input_In: Value0_In, Input_2_In: Output_3, Output_Out: out T Output_4);
            T __pad_RjrMgeptfBnNoXT5lfhPy5_5 = Output_4;
            w_0.OperatorMinus(Input_In: __pad_RjrMgeptfBnNoXT5lfhPy5_5, Input_2_In: Value1_In, Output_Out: out T Output_6);
            w_0.Round_Float(Input_In: Output_6, Output_Out: out T Output_7);
            w_0.OperatorPlus(Input_In: Value1_In, Input_2_In: Output_7, Output_Out: out T Output_8);
            Output_Out = Output_8;
            return;
        }

        public static void SelectFunction<T, AdM>(T Value0_In, T Derivative0_In, T Value1_In, [n4.SerializedDefaultValueAttribute("1", false)] float Damping_In, float Cycles_In, bool Cyclic_In, out n52.IInternalOscillatorFunction_I<T, float> Output_Out)
            where AdM : struct, n54.IAdaptiveToFloat32<float>, n55.IAdaptiveToFloat64<float>, n9.IAdaptiveOperatorMulitply_Scale<float>, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveRound_Float<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>, n56.IAdaptiveCos<float>, n9.IAdaptiveOperatorDivide_Scale<T>, n56.IAdaptiveSin<float>
        {
            var w_0 = default(AdM);
            float __pad_KJPZUIicbAjN1DureUKsMr_1 = __slot_KJPZUIicbAjN1DureUKsMr;
            var Output_2 = Damping_In * Damping_In;
            n52._Operations_.GetEnergyFromCyclesAndDamping<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(squaredDamping_In: Output_2, Cycles_In: Cycles_In, Energy_Out: out float Energy_3);
            T Value1_4;
            if (Cyclic_In)
            {
                n52._Operations_.GetCyclicValue<T, AdM>(Value0_In: Value0_In, Derivative0_In: Derivative0_In, Value1_In: Value1_In, Damping_In: Damping_In, Energy_In: Energy_3, Output_Out: out T Output_5);
                Value1_4 = Output_5;
            }
            else
            {
                Value1_4 = Value1_In;
            }

            var Output_6 = Output_2 - Energy_3;
            n57._Operations_.Abs<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Output_6, Output_Out: out float Output_7);
            var Result_8 = Output_7 < __pad_KJPZUIicbAjN1DureUKsMr_1;
            n52.IInternalOscillatorFunction_I<T, float> __auto_9;
            if (Result_8)
            {
                n1.NodeContext Node_Context_10 = n1.NodeContext.Default.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "BDxBhk8boOjO3EneW93NNO", 69986U);
                var Output_11 = n52.OscillatorFunctionDMP_C<T>.Create<AdM>(Node_Context: Node_Context_10);
                __auto_9 = (n52.IInternalOscillatorFunction_I<T, float>)Output_11;
            }
            else
            {
                __auto_9 = default(n52.IInternalOscillatorFunction_I<T, float>);
            }

            var Output_12 = !Result_8;
            n52.IInternalOscillatorFunction_I<T, float> __auto_13;
            if (Output_12)
            {
                float Input_2_14 = 0F;
                var Result_15 = Output_6 < Input_2_14;
                n52.IInternalOscillatorFunction_I<T, float> __auto_16;
                if (Result_15)
                {
                    n1.NodeContext Node_Context_17 = n1.NodeContext.Default.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "V2F6oj9UPJKOO19y35eTui", 73673U);
                    var Output_18 = n52.OscillatorFunctionOSC_C<T, float>.Create<AdM>(Node_Context: Node_Context_17);
                    __auto_16 = (n52.IInternalOscillatorFunction_I<T, float>)Output_18;
                }
                else
                {
                    __auto_16 = __auto_9;
                }

                var Output_19 = !Result_15;
                n52.IInternalOscillatorFunction_I<T, float> __auto_20;
                if (Output_19)
                {
                    n1.NodeContext Node_Context_21 = n1.NodeContext.Default.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "En8BycHp4sdNcChF3I4ZH7", 73744U);
                    var Output_22 = n52.OscillatorFunctionHYP_C<T, float>.Create<AdM>(Node_Context: Node_Context_21);
                    __auto_20 = (n52.IInternalOscillatorFunction_I<T, float>)Output_22;
                }
                else
                {
                    __auto_20 = __auto_16;
                }

                __auto_13 = __auto_20;
            }
            else
            {
                __auto_13 = __auto_9;
            }

            var Output_23 = ((n52.IInternalOscillatorFunction_I<T, float>)__auto_13).Join(p0_In: Value0_In, p1_In: Value1_4, damping_In: Damping_In, squaredDampingMinusEnergy_In: Output_6, v0_In: Derivative0_In, energy_In: Energy_3);
            Output_Out = Output_23;
            return;
        }

        [n1.ElementAttribute(TracingId = 69962U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KJPZUIicbAjN1DureUKsMr", Name = "__slot_KJPZUIicbAjN1DureUKsMr")]
        public static float __slot_KJPZUIicbAjN1DureUKsMr = 1E-20F;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Animation_.Animation.Advanced
{
    [n1.ElementAttribute(TracingId = 77164U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "E4dfedvLjPfOjMfJ9kcvG7", Name = "Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7")]
    [n2.SerializableAttribute]
    public class Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> Create<AdM>(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> Update<AdM>(T Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, out T Position_Out, out T Velocity_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            float __pad_Fx10hYClh8AMm0l75c4382_1 = __slot_Fx10hYClh8AMm0l75c4382;
            n12.IFrameClock __auto_2 = this.Clock;
            float __pad_L9dESux7MprNZi9S2AjG0d_3 = __slot_L9dESux7MprNZi9S2AjG0d;
            var Output_4 = (float)__pad_Fx10hYClh8AMm0l75c4382_1 / Filter_Time_In;
            n13._Operations_.TimeDifference_Float32(Clock_In: __auto_2, Result_Out: out float Result_5);
            n37._Operations_.Min<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Result_5, Input_2_In: __pad_L9dESux7MprNZi9S2AjG0d_3, Output_Out: out float Output_6);
            var Output_7 = Output_4 * Output_6;
            float Damping_8 = 2F;
            var Output_11 = this.__p_OZc5kACWL6mPqPJzAo3HBm.Update<AdM>(Goto_Position_In: Goto_Position_In, Frequency_In: Output_7, Damping_In: Damping_8, Position_Out: out T Position_9, Velocity_Out: out T Velocity_10);
            T __pad_KMlaUgLBkQpOUJca4VGTsc_12 = Goto_Position_In;
            Position_Out = Position_9;
            Velocity_Out = Velocity_10;
            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Output_11 != this.__p_OZc5kACWL6mPqPJzAo3HBm || !n5.EqualityComparer<T>.Default.Equals(Goto_Position_In, this.__slot_KMlaUgLBkQpOUJca4VGTsc) ? new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(this)
                {__p_OZc5kACWL6mPqPJzAo3HBm = Output_11, __slot_KMlaUgLBkQpOUJca4VGTsc = Goto_Position_In} : that_13;
            else
            {
                this.__p_OZc5kACWL6mPqPJzAo3HBm = Output_11;
                this.__slot_KMlaUgLBkQpOUJca4VGTsc = Goto_Position_In;
            }

            return that_13;
        }

        public n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> Jump()
        {
            bool __pad_OwInW1F9uwlQFwLzJv5S0J_0 = __slot_OwInW1F9uwlQFwLzJv5S0J;
            T __pad_KMlaUgLBkQpOUJca4VGTsc_1 = this.__slot_KMlaUgLBkQpOUJca4VGTsc;
            var Output_2 = this.__p_OZc5kACWL6mPqPJzAo3HBm;
            if (__pad_OwInW1F9uwlQFwLzJv5S0J_0)
            {
                Output_2 = this.__p_OZc5kACWL6mPqPJzAo3HBm.Reset(Reset_Position_In: __pad_KMlaUgLBkQpOUJca4VGTsc_1);
            }

            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_OZc5kACWL6mPqPJzAo3HBm ? new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(this)
                {__p_OZc5kACWL6mPqPJzAo3HBm = Output_2} : that_3;
            else
            {
                this.__p_OZc5kACWL6mPqPJzAo3HBm = Output_2;
            }

            return that_3;
        }

        public n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> SetClock(n12.IFrameClock New_Clock_In)
        {
            n12.IFrameClock __auto_0 = New_Clock_In;
            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = New_Clock_In != this.Clock ? new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(this)
                {Clock = New_Clock_In} : that_1;
            else
            {
                this.Clock = New_Clock_In;
            }

            return that_1;
        }

        public n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> __Create__<AdM>(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_46);
            n12.IFrameClock __auto_1 = Clock_In;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "OZc5kACWL6mPqPJzAo3HBm", 77173U);
            var Output_3 = n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T>.Create<AdM>(Node_Context: Node_Context_2);
            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_4 = this;
            this.__slot_KMlaUgLBkQpOUJca4VGTsc = __out_46;
            this.Clock = Clock_In;
            this.__p_OZc5kACWL6mPqPJzAo3HBm = Output_3;
            return that_4;
        }

        public n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_47);
            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_1 = this;
            this.__slot_KMlaUgLBkQpOUJca4VGTsc = __out_47;
            this.Clock = n13._Operations_.CreateDefault();
            this.__p_OZc5kACWL6mPqPJzAo3HBm = n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T>.CreateDefault<AdM>();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OZc5kACWL6mPqPJzAo3HBm);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 77255U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "OwInW1F9uwlQFwLzJv5S0J", Name = "__slot_OwInW1F9uwlQFwLzJv5S0J")]
        public static bool __slot_OwInW1F9uwlQFwLzJv5S0J = true;
        [n1.ElementAttribute(TracingId = 77260U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "KMlaUgLBkQpOUJca4VGTsc", Name = "__slot_KMlaUgLBkQpOUJca4VGTsc")]
        public T __slot_KMlaUgLBkQpOUJca4VGTsc;
        [n1.ElementAttribute(TracingId = 77281U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "L9dESux7MprNZi9S2AjG0d", Name = "__slot_L9dESux7MprNZi9S2AjG0d")]
        public static float __slot_L9dESux7MprNZi9S2AjG0d = 1F;
        [n1.ElementAttribute(TracingId = 77316U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "Fx10hYClh8AMm0l75c4382", Name = "__slot_Fx10hYClh8AMm0l75c4382")]
        public static float __slot_Fx10hYClh8AMm0l75c4382 = 12F;
        [n1.ElementAttribute(TracingId = 77250U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SaRGUdJkFabLrv40FKGp1v", Name = "Clock")]
        public n12.IFrameClock Clock;
        [n1.ElementAttribute(TracingId = 77173U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "OZc5kACWL6mPqPJzAo3HBm", Name = "MassSpring", IsManaged = true, IsAutoGenerated = true)]
        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __p_OZc5kACWL6mPqPJzAo3HBm;
        static Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7()
        {
        }

        public Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7(Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> other): base(other)
        {
            this.__slot_KMlaUgLBkQpOUJca4VGTsc = other.__slot_KMlaUgLBkQpOUJca4VGTsc;
            this.Clock = other.Clock;
            this.__p_OZc5kACWL6mPqPJzAo3HBm = other.__p_OZc5kACWL6mPqPJzAo3HBm;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_KMlaUgLBkQpOUJca4VGTsc", in __slot_KMlaUgLBkQpOUJca4VGTsc), n1.CompilationHelper.GetValueOrExisting(values, "Clock", in Clock), n1.CompilationHelper.GetValueOrExisting(values, "__p_OZc5kACWL6mPqPJzAo3HBm", in __p_OZc5kACWL6mPqPJzAo3HBm));
        }

        internal Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> __WITH__(T __slot_KMlaUgLBkQpOUJca4VGTsc, n12.IFrameClock Clock, n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __p_OZc5kACWL6mPqPJzAo3HBm)
        {
            n35.Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n5.EqualityComparer<T>.Default.Equals(__slot_KMlaUgLBkQpOUJca4VGTsc, this.__slot_KMlaUgLBkQpOUJca4VGTsc) || Clock != this.Clock || __p_OZc5kACWL6mPqPJzAo3HBm != this.__p_OZc5kACWL6mPqPJzAo3HBm ? new Damper_Fast_E4dfedvLjPfOjMfJ9kcvG7<T>(this)
                {__slot_KMlaUgLBkQpOUJca4VGTsc = __slot_KMlaUgLBkQpOUJca4VGTsc, Clock = Clock, __p_OZc5kACWL6mPqPJzAo3HBm = __p_OZc5kACWL6mPqPJzAo3HBm} : that_0;
            else
            {
                this.__slot_KMlaUgLBkQpOUJca4VGTsc = __slot_KMlaUgLBkQpOUJca4VGTsc;
                this.Clock = Clock;
                this.__p_OZc5kACWL6mPqPJzAo3HBm = __p_OZc5kACWL6mPqPJzAo3HBm;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 77436U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "DNl6ggbTMUuQd9VdE3AEIB", Name = "Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB")]
    [n2.SerializableAttribute]
    public class Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> : n1.VLObject, n2.IDisposable where T3 : n12.IClock
    {
        [n4.CreateNewAttribute]
        public static n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> Create<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> Update<AdM>(T Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out T Position_Out, out T Velocity_Out, out T Acceleration_Out, out n33.OscillatorFunction_C<T> Function_Out)
            where AdM : struct, n54.IAdaptiveToFloat32<float>, n55.IAdaptiveToFloat64<float>, n9.IAdaptiveOperatorMulitply_Scale<float>, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveRound_Float<T>, n9.IAdaptiveAvoidNaN<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>, n9.IAdaptiveZero<T>, n9.IAdaptiveIsNaN<T>, n56.IAdaptiveCos<float>, n9.IAdaptiveOperatorDivide_Scale<T>, n56.IAdaptiveSin<float>
        {
            var w_0 = default(AdM);
            float __pad_F7wNtUx7rREMwotrx89V8E_1 = __slot_F7wNtUx7rREMwotrx89V8E;
            var Output_6 = this.__p_H3rlid6BAFSLoNpPeL29gd.Update<AdM>(Goto_Position_In: Goto_Position_In, Filter_Time_In: Filter_Time_In, Cycles_In: __pad_F7wNtUx7rREMwotrx89V8E_1, Cyclic_In: Cyclic_In, Jump_In: Jump_In, Force_New_Func_In: Force_New_Func_In, Position_Out: out T Position_2, Velocity_Out: out T Velocity_3, Acceleration_Out: out T Acceleration_4, Function_Out: out n33.OscillatorFunction_C<T> Function_5);
            Position_Out = Position_2;
            Velocity_Out = Velocity_3;
            Acceleration_Out = Acceleration_4;
            Function_Out = Function_5;
            n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_6 != this.__p_H3rlid6BAFSLoNpPeL29gd ? new Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3>(this)
                {__p_H3rlid6BAFSLoNpPeL29gd = Output_6} : that_7;
            else
            {
                this.__p_H3rlid6BAFSLoNpPeL29gd = Output_6;
            }

            return that_7;
        }

        public n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> SetClock<T2>(T2 New_Clock_In)
            where T2 : n12.IClock
        {
            n12.IClock New_Clock_0 = (n12.IClock)New_Clock_In;
            bool SetClock_1 = true;
            var Output_2 = this.__p_H3rlid6BAFSLoNpPeL29gd;
            if (SetClock_1)
            {
                Output_2 = this.__p_H3rlid6BAFSLoNpPeL29gd.SetClock(New_Clock_In: New_Clock_0);
            }

            n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_H3rlid6BAFSLoNpPeL29gd ? new Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3>(this)
                {__p_H3rlid6BAFSLoNpPeL29gd = Output_2} : that_3;
            else
            {
                this.__p_H3rlid6BAFSLoNpPeL29gd = Output_2;
            }

            return that_3;
        }

        public n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> __Create__<AdM>(n1.NodeContext Node_Context, T3 Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n12.IClock Clock_1 = (n12.IClock)Clock_In;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "H3rlid6BAFSLoNpPeL29gd", 77445U);
            var Output_3 = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>.Create<AdM>(Node_Context: Node_Context_2, Clock_In: Clock_1);
            n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> that_4 = this;
            this.__p_H3rlid6BAFSLoNpPeL29gd = Output_3;
            return that_4;
        }

        public n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> that_1 = this;
            this.__p_H3rlid6BAFSLoNpPeL29gd = n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>.CreateDefault<AdM>();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_H3rlid6BAFSLoNpPeL29gd);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 77516U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "F7wNtUx7rREMwotrx89V8E", Name = "__slot_F7wNtUx7rREMwotrx89V8E")]
        public static float __slot_F7wNtUx7rREMwotrx89V8E = 0F;
        [n1.ElementAttribute(TracingId = 77445U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "H3rlid6BAFSLoNpPeL29gd", Name = "Oscillator (Generic)", IsManaged = true, IsAutoGenerated = true)]
        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> __p_H3rlid6BAFSLoNpPeL29gd;
        static Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB()
        {
        }

        public Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB(Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> other): base(other)
        {
            this.__p_H3rlid6BAFSLoNpPeL29gd = other.__p_H3rlid6BAFSLoNpPeL29gd;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H3rlid6BAFSLoNpPeL29gd", in __p_H3rlid6BAFSLoNpPeL29gd));
        }

        internal Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> __WITH__(n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> __p_H3rlid6BAFSLoNpPeL29gd)
        {
            n35.Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_H3rlid6BAFSLoNpPeL29gd != this.__p_H3rlid6BAFSLoNpPeL29gd ? new Damper_Generic_DNl6ggbTMUuQd9VdE3AEIB<T, T3>(this)
                {__p_H3rlid6BAFSLoNpPeL29gd = __p_H3rlid6BAFSLoNpPeL29gd} : that_0;
            else
            {
                this.__p_H3rlid6BAFSLoNpPeL29gd = __p_H3rlid6BAFSLoNpPeL29gd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 77655U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "VbrPYB0MTDDMEKdVfbV0hS", Name = "Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS")]
    [n2.SerializableAttribute]
    public class Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> Create<AdM>(n1.NodeContext Node_Context, n12.IClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> Update<AdM>(T Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, float Cycles_In, bool Cyclic_In, bool Jump_In, bool Force_New_Func_In, out T Position_Out, out T Velocity_Out, out T Acceleration_Out, out n33.OscillatorFunction_C<T> Function_Out)
            where AdM : struct, n54.IAdaptiveToFloat32<float>, n55.IAdaptiveToFloat64<float>, n9.IAdaptiveOperatorMulitply_Scale<float>, n9.IAdaptiveOperatorMinus<T>, n8.IAdaptiveCreateDefault<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveRound_Float<T>, n9.IAdaptiveAvoidNaN<T>, n9.IAdaptiveOperatorPlus<T>, n9.IAdaptiveOperatorMinus_Negate<T>, n9.IAdaptiveZero<T>, n9.IAdaptiveIsNaN<T>, n56.IAdaptiveCos<float>, n9.IAdaptiveOperatorDivide_Scale<T>, n56.IAdaptiveSin<float>
        {
            var w_0 = default(AdM);
            n12.IClock __pad_G2XoQVxAXavQYoPYuXeytN_1 = this.__slot_G2XoQVxAXavQYoPYuXeytN;
            n33.OscillatorFunction_C<T> __auto_2 = this.F;
            w_0.CreateDefault(Output_Out: out T Output_3);
            w_0.AvoidNaN(Input_In: Goto_Position_In, Default_In: Output_3, Output_Out: out T Output_4);
            var State_Output_6 = this.__p_CAhlqRlMINvP8u7J2uIFMm.Update(Simulate_In: Jump_In, Output_Out: out bool Output_5);
            var Output_7 = !Output_5;
            w_0.Zero(Zero_Out: out T Zero_8);
            w_0.CreateDefault(Output_Out: out T Output_9);
            var Time_10 = __pad_G2XoQVxAXavQYoPYuXeytN_1.Time;
            var Seconds_11 = Time_10.Seconds;
            T __auto_12;
            T __auto_13;
            T __auto_14;
            if (Output_7)
            {
                var State_Output_19 = __auto_2.Sample_(Input_In: Seconds_11, Output_Out: out T Output_16, Derivative_Out: out T Derivative_17, Second_Derivative_Out: out T Second_Derivative_18);
                __auto_12 = Output_16;
                __auto_13 = Derivative_17;
                __auto_14 = Second_Derivative_18;
            }
            else
            {
                __auto_12 = Output_4;
                __auto_13 = Zero_8;
                __auto_14 = Output_9;
            }

            var Output_22 = this.__p_UlZR7aoqe8SMivCFXYDitC.Update(Value_In: Filter_Time_In, Result_Out: out bool Result_20, Unchanged_Out: out bool Unchanged_21);
            var Output_25 = this.__p_E0Fl4lYLmCnM8RFfD8fcc3.Update(Value_In: Goto_Position_In, Result_Out: out bool Result_23, Unchanged_Out: out bool Unchanged_24);
            var Output_26 = Result_20 || Result_23;
            n57._Operations_.IsNaN<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Filter_Time_In, Result_Out: out bool Result_27);
            w_0.IsNaN(Input_In: Goto_Position_In, Result_Out: out bool Result_28);
            var Output_29 = Result_27 || Result_28;
            n58._Operations_.ANDNOT(Input_In: Output_26, Input_2_In: Output_29, Output_Out: out bool Output_30);
            var Output_31 = Force_New_Func_In || Output_5;
            var Output_32 = Output_31 || Output_30;
            bool Dispose_Cached_Outputs_33 = false;
            var manager_34 = this.__cache_ULRgBeCECoXON89KhfawgQ;
            if (manager_34 is null)
            {
                manager_34 = new n53.Manager<n2.ValueTuple<float, bool>, n2.ValueTuple<n33.OscillatorFunction_C<T>>>(n2.ValueTuple.Create(n33.OscillatorFunction_C<T>.CreateDefault()));
            }

            var inputs_35 = (Cycles_In, Cyclic_In);
            var outputs_36 = manager_34.Outputs;
            var Has_Changed_37 = Output_32 || manager_34.InputsChanged(inputs_35);
            if (Has_Changed_37)
            {
                if (Dispose_Cached_Outputs_33)
                    manager_34.DisposeOutputs();
                n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "NdzoACSe7aeNhf9MIPMu3Y", 77816U);
                var Output_40 = n33.OscillatorFunction_C<T>.Create(Node_Context: Node_Context_39);
                float Input_2_41 = 0.0001F;
                n37._Operations_.Max<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Filter_Time_In, Input_2_In: Input_2_41, Output_Out: out float Output_42);
                float Input_43 = 12F;
                var Output_44 = (float)Input_43 / Output_42;
                double Input_2_45 = (double)Output_42;
                var Output_46 = Seconds_11 + Input_2_45;
                bool Force_47 = false;
                var Output_48 = Output_40.Update<AdM>(X0_In: Seconds_11, Value0_In: __auto_12, Derivative0_In: __auto_13, Value1_In: Output_4, Damping_In: Output_44, Cycles_In: Cycles_In, Cyclic_In: Cyclic_In, Force_In: Force_47, X1_In: Output_46);
                outputs_36 = n2.ValueTuple.Create(Output_48);
                manager_34 = manager_34.Update(inputs_35, __GetContext__().IsImmutable, Dispose_Cached_Outputs_33, default, outputs_36);
            }
            else
            {
                manager_34.Update(inputs_35, __GetContext__().IsImmutable, Dispose_Cached_Outputs_33);
            }

            var __auto_49 = outputs_36.Item1;
            n33.OscillatorFunction_C<T> __auto_50 = __auto_49;
            Position_Out = __auto_12;
            Velocity_Out = __auto_13;
            Acceleration_Out = __auto_14;
            Function_Out = __auto_49;
            n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = State_Output_6 != this.__p_CAhlqRlMINvP8u7J2uIFMm || Output_22 != this.__p_UlZR7aoqe8SMivCFXYDitC || Output_25 != this.__p_E0Fl4lYLmCnM8RFfD8fcc3 || manager_34 != this.__cache_ULRgBeCECoXON89KhfawgQ || __auto_49 != this.F ? new Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>(this)
                {__p_CAhlqRlMINvP8u7J2uIFMm = State_Output_6, __p_UlZR7aoqe8SMivCFXYDitC = Output_22, __p_E0Fl4lYLmCnM8RFfD8fcc3 = Output_25, __cache_ULRgBeCECoXON89KhfawgQ = manager_34, F = __auto_49} : that_51;
            else
            {
                this.__p_CAhlqRlMINvP8u7J2uIFMm = State_Output_6;
                this.__p_UlZR7aoqe8SMivCFXYDitC = Output_22;
                this.__p_E0Fl4lYLmCnM8RFfD8fcc3 = Output_25;
                this.__cache_ULRgBeCECoXON89KhfawgQ = manager_34;
                this.F = __auto_49;
            }

            return that_51;
        }

        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> SetClock(n12.IClock New_Clock_In)
        {
            n12.IClock __pad_G2XoQVxAXavQYoPYuXeytN_0 = New_Clock_In;
            n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = New_Clock_In != this.__slot_G2XoQVxAXavQYoPYuXeytN ? new Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>(this)
                {__slot_G2XoQVxAXavQYoPYuXeytN = New_Clock_In} : that_1;
            else
            {
                this.__slot_G2XoQVxAXavQYoPYuXeytN = New_Clock_In;
            }

            return that_1;
        }

        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> __Create__<AdM>(n1.NodeContext Node_Context, n12.IClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n12.IClock __pad_G2XoQVxAXavQYoPYuXeytN_1 = Clock_In;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "VsWxkTSamdyPUJxOcHGS0m", 77664U);
            var Output_3 = n33.OscillatorFunction_C<T>.Create(Node_Context: Node_Context_2);
            n33.OscillatorFunction_C<T> __auto_4 = Output_3;
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "CAhlqRlMINvP8u7J2uIFMm", 77941U);
            var Output_6 = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "UlZR7aoqe8SMivCFXYDitC", 78105U);
            bool Changed_On_Create_8 = true;
            var Output_9 = n21.Changed_A8JGbead2bxNdnPybiEqVS<float>.Create<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Node_Context: Node_Context_7, Changed_On_Create_In: Changed_On_Create_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "E0Fl4lYLmCnM8RFfD8fcc3", 79797U);
            bool Changed_On_Create_11 = true;
            var Output_12 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.Create<AdM>(Node_Context: Node_Context_10, Changed_On_Create_In: Changed_On_Create_11);
            n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> that_13 = this;
            this.__slot_G2XoQVxAXavQYoPYuXeytN = Clock_In;
            this.F = Output_3;
            this.__p_CAhlqRlMINvP8u7J2uIFMm = Output_6;
            this.__p_UlZR7aoqe8SMivCFXYDitC = Output_9;
            this.__p_E0Fl4lYLmCnM8RFfD8fcc3 = Output_12;
            this.__cache_ULRgBeCECoXON89KhfawgQ = null;
            return that_13;
        }

        public n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> that_1 = this;
            this.__slot_G2XoQVxAXavQYoPYuXeytN = n11._Operations_.CreateDefault();
            this.F = n33.OscillatorFunction_C<T>.CreateDefault();
            this.__p_CAhlqRlMINvP8u7J2uIFMm = n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_UlZR7aoqe8SMivCFXYDitC = n21.Changed_A8JGbead2bxNdnPybiEqVS<float>.CreateDefault<n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            this.__p_E0Fl4lYLmCnM8RFfD8fcc3 = n21.Changed_A8JGbead2bxNdnPybiEqVS<T>.CreateDefault<AdM>();
            this.__cache_ULRgBeCECoXON89KhfawgQ = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_CAhlqRlMINvP8u7J2uIFMm);
            n1.CompilationHelper.SafeDispose(this.__p_UlZR7aoqe8SMivCFXYDitC);
            n1.CompilationHelper.SafeDispose(this.__p_E0Fl4lYLmCnM8RFfD8fcc3);
            n1.CompilationHelper.SafeDispose(this.__cache_ULRgBeCECoXON89KhfawgQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 77927U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "G2XoQVxAXavQYoPYuXeytN", Name = "__slot_G2XoQVxAXavQYoPYuXeytN")]
        public n12.IClock __slot_G2XoQVxAXavQYoPYuXeytN;
        [n1.ElementAttribute(TracingId = 77673U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NAtN1ivltaGOvoNB6X5TER", Name = "F")]
        public n33.OscillatorFunction_C<T> F;
        [n1.ElementAttribute(TracingId = 77941U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "CAhlqRlMINvP8u7J2uIFMm", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_CAhlqRlMINvP8u7J2uIFMm;
        [n1.ElementAttribute(TracingId = 78105U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "UlZR7aoqe8SMivCFXYDitC", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_UlZR7aoqe8SMivCFXYDitC;
        [n1.ElementAttribute(TracingId = 79797U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "E0Fl4lYLmCnM8RFfD8fcc3", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_E0Fl4lYLmCnM8RFfD8fcc3;
        [n1.ElementAttribute(TracingId = 77677U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "ULRgBeCECoXON89KhfawgQ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n53.Manager<n2.ValueTuple<float, bool>, n2.ValueTuple<n33.OscillatorFunction_C<T>>> __cache_ULRgBeCECoXON89KhfawgQ = null;
        public Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS(Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> other): base(other)
        {
            this.__slot_G2XoQVxAXavQYoPYuXeytN = other.__slot_G2XoQVxAXavQYoPYuXeytN;
            this.F = other.F;
            this.__p_CAhlqRlMINvP8u7J2uIFMm = other.__p_CAhlqRlMINvP8u7J2uIFMm;
            this.__p_UlZR7aoqe8SMivCFXYDitC = other.__p_UlZR7aoqe8SMivCFXYDitC;
            this.__p_E0Fl4lYLmCnM8RFfD8fcc3 = other.__p_E0Fl4lYLmCnM8RFfD8fcc3;
            this.__cache_ULRgBeCECoXON89KhfawgQ = other.__cache_ULRgBeCECoXON89KhfawgQ;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_G2XoQVxAXavQYoPYuXeytN", in __slot_G2XoQVxAXavQYoPYuXeytN), n1.CompilationHelper.GetValueOrExisting(values, "F", in F), n1.CompilationHelper.GetValueOrExisting(values, "__p_CAhlqRlMINvP8u7J2uIFMm", in __p_CAhlqRlMINvP8u7J2uIFMm), n1.CompilationHelper.GetValueOrExisting(values, "__p_UlZR7aoqe8SMivCFXYDitC", in __p_UlZR7aoqe8SMivCFXYDitC), n1.CompilationHelper.GetValueOrExisting(values, "__p_E0Fl4lYLmCnM8RFfD8fcc3", in __p_E0Fl4lYLmCnM8RFfD8fcc3), n1.CompilationHelper.GetValueOrExisting(values, "__cache_ULRgBeCECoXON89KhfawgQ", in __cache_ULRgBeCECoXON89KhfawgQ));
        }

        internal Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> __WITH__(n12.IClock __slot_G2XoQVxAXavQYoPYuXeytN, n33.OscillatorFunction_C<T> F, n21.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_CAhlqRlMINvP8u7J2uIFMm, n21.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_UlZR7aoqe8SMivCFXYDitC, n21.Changed_A8JGbead2bxNdnPybiEqVS<T> __p_E0Fl4lYLmCnM8RFfD8fcc3, n53.Manager<n2.ValueTuple<float, bool>, n2.ValueTuple<n33.OscillatorFunction_C<T>>> __cache_ULRgBeCECoXON89KhfawgQ)
        {
            n35.Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_G2XoQVxAXavQYoPYuXeytN != this.__slot_G2XoQVxAXavQYoPYuXeytN || F != this.F || __p_CAhlqRlMINvP8u7J2uIFMm != this.__p_CAhlqRlMINvP8u7J2uIFMm || __p_UlZR7aoqe8SMivCFXYDitC != this.__p_UlZR7aoqe8SMivCFXYDitC || __p_E0Fl4lYLmCnM8RFfD8fcc3 != this.__p_E0Fl4lYLmCnM8RFfD8fcc3 || __cache_ULRgBeCECoXON89KhfawgQ != this.__cache_ULRgBeCECoXON89KhfawgQ ? new Oscillator_Generic_VbrPYB0MTDDMEKdVfbV0hS<T>(this)
                {__slot_G2XoQVxAXavQYoPYuXeytN = __slot_G2XoQVxAXavQYoPYuXeytN, F = F, __p_CAhlqRlMINvP8u7J2uIFMm = __p_CAhlqRlMINvP8u7J2uIFMm, __p_UlZR7aoqe8SMivCFXYDitC = __p_UlZR7aoqe8SMivCFXYDitC, __p_E0Fl4lYLmCnM8RFfD8fcc3 = __p_E0Fl4lYLmCnM8RFfD8fcc3, __cache_ULRgBeCECoXON89KhfawgQ = __cache_ULRgBeCECoXON89KhfawgQ} : that_0;
            else
            {
                this.__slot_G2XoQVxAXavQYoPYuXeytN = __slot_G2XoQVxAXavQYoPYuXeytN;
                this.F = F;
                this.__p_CAhlqRlMINvP8u7J2uIFMm = __p_CAhlqRlMINvP8u7J2uIFMm;
                this.__p_UlZR7aoqe8SMivCFXYDitC = __p_UlZR7aoqe8SMivCFXYDitC;
                this.__p_E0Fl4lYLmCnM8RFfD8fcc3 = __p_E0Fl4lYLmCnM8RFfD8fcc3;
                this.__cache_ULRgBeCECoXON89KhfawgQ = __cache_ULRgBeCECoXON89KhfawgQ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 80152U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NV7Jp8StqbYLmGMQsFc4RH", Name = "Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH")]
    [n2.SerializableAttribute]
    public class Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> Create<AdM>(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> CreateDefault<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var instance = new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> Update<AdM>(T Goto_Position_In, [n4.SerializedDefaultValueAttribute("1", false)] float Filter_Time_In, [n4.SerializedDefaultValueAttribute("2", false)] float Damping_In, out T Position_Out, out T Velocity_Out)
            where AdM : struct, n9.IAdaptiveOperatorMinus<T>, n9.IAdaptiveOperatorMulitply_Scale<T>, n9.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            float __pad_NR2LLq1B9dHNtcbY7irBwe_1 = __slot_NR2LLq1B9dHNtcbY7irBwe;
            n12.IFrameClock __auto_2 = this.Clock;
            float __pad_SpZQIfjdEHbOktGne1dhFs_3 = __slot_SpZQIfjdEHbOktGne1dhFs;
            var Output_4 = (float)__pad_NR2LLq1B9dHNtcbY7irBwe_1 / Filter_Time_In;
            n13._Operations_.TimeDifference_Float32(Clock_In: __auto_2, Result_Out: out float Result_5);
            n37._Operations_.Min<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Result_5, Input_2_In: __pad_SpZQIfjdEHbOktGne1dhFs_3, Output_Out: out float Output_6);
            var Output_7 = Output_4 * Output_6;
            var Output_10 = this.__p_FSmPrdVyLfzMjc9ERUOjlQ.Update<AdM>(Goto_Position_In: Goto_Position_In, Frequency_In: Output_7, Damping_In: Damping_In, Position_Out: out T Position_8, Velocity_Out: out T Velocity_9);
            T __pad_TrmdGkADRnoNx6ODwa2xUK_11 = Goto_Position_In;
            Position_Out = Position_8;
            Velocity_Out = Velocity_9;
            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_10 != this.__p_FSmPrdVyLfzMjc9ERUOjlQ || !n5.EqualityComparer<T>.Default.Equals(Goto_Position_In, this.__slot_TrmdGkADRnoNx6ODwa2xUK) ? new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(this)
                {__p_FSmPrdVyLfzMjc9ERUOjlQ = Output_10, __slot_TrmdGkADRnoNx6ODwa2xUK = Goto_Position_In} : that_12;
            else
            {
                this.__p_FSmPrdVyLfzMjc9ERUOjlQ = Output_10;
                this.__slot_TrmdGkADRnoNx6ODwa2xUK = Goto_Position_In;
            }

            return that_12;
        }

        public n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> Jump()
        {
            bool __pad_BDkkW1K7LahMDqpLRWsj6y_0 = __slot_BDkkW1K7LahMDqpLRWsj6y;
            T __pad_TrmdGkADRnoNx6ODwa2xUK_1 = this.__slot_TrmdGkADRnoNx6ODwa2xUK;
            var Output_2 = this.__p_FSmPrdVyLfzMjc9ERUOjlQ;
            if (__pad_BDkkW1K7LahMDqpLRWsj6y_0)
            {
                Output_2 = this.__p_FSmPrdVyLfzMjc9ERUOjlQ.Reset(Reset_Position_In: __pad_TrmdGkADRnoNx6ODwa2xUK_1);
            }

            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_FSmPrdVyLfzMjc9ERUOjlQ ? new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(this)
                {__p_FSmPrdVyLfzMjc9ERUOjlQ = Output_2} : that_3;
            else
            {
                this.__p_FSmPrdVyLfzMjc9ERUOjlQ = Output_2;
            }

            return that_3;
        }

        public n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> SetClock(n12.IFrameClock New_Clock_In)
        {
            n12.IFrameClock __auto_0 = New_Clock_In;
            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = New_Clock_In != this.Clock ? new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(this)
                {Clock = New_Clock_In} : that_1;
            else
            {
                this.Clock = New_Clock_In;
            }

            return that_1;
        }

        public n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> __Create__<AdM>(n1.NodeContext Node_Context, n12.IFrameClock Clock_In)
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_48);
            n12.IFrameClock __auto_1 = Clock_In;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("U2O4IiXgnrTMwv9Zd92a14", "FSmPrdVyLfzMjc9ERUOjlQ", 80161U);
            var Output_3 = n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T>.Create<AdM>(Node_Context: Node_Context_2);
            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_4 = this;
            this.__slot_TrmdGkADRnoNx6ODwa2xUK = __out_48;
            this.Clock = Clock_In;
            this.__p_FSmPrdVyLfzMjc9ERUOjlQ = Output_3;
            return that_4;
        }

        public n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> __CreateDefault__<AdM>()
            where AdM : struct, n8.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_49);
            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_1 = this;
            this.__slot_TrmdGkADRnoNx6ODwa2xUK = __out_49;
            this.Clock = n13._Operations_.CreateDefault();
            this.__p_FSmPrdVyLfzMjc9ERUOjlQ = n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T>.CreateDefault<AdM>();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FSmPrdVyLfzMjc9ERUOjlQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 80247U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "BDkkW1K7LahMDqpLRWsj6y", Name = "__slot_BDkkW1K7LahMDqpLRWsj6y")]
        public static bool __slot_BDkkW1K7LahMDqpLRWsj6y = true;
        [n1.ElementAttribute(TracingId = 80254U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "TrmdGkADRnoNx6ODwa2xUK", Name = "__slot_TrmdGkADRnoNx6ODwa2xUK")]
        public T __slot_TrmdGkADRnoNx6ODwa2xUK;
        [n1.ElementAttribute(TracingId = 80273U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "SpZQIfjdEHbOktGne1dhFs", Name = "__slot_SpZQIfjdEHbOktGne1dhFs")]
        public static float __slot_SpZQIfjdEHbOktGne1dhFs = 1F;
        [n1.ElementAttribute(TracingId = 81075U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "NR2LLq1B9dHNtcbY7irBwe", Name = "__slot_NR2LLq1B9dHNtcbY7irBwe")]
        public static float __slot_NR2LLq1B9dHNtcbY7irBwe = 12F;
        [n1.ElementAttribute(TracingId = 80243U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "UT252rQqZS6LXy79wgXBjy", Name = "Clock")]
        public n12.IFrameClock Clock;
        [n1.ElementAttribute(TracingId = 80161U, DocumentId = "U2O4IiXgnrTMwv9Zd92a14", PersistentId = "FSmPrdVyLfzMjc9ERUOjlQ", Name = "MassSpring", IsManaged = true, IsAutoGenerated = true)]
        public n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __p_FSmPrdVyLfzMjc9ERUOjlQ;
        static Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH()
        {
        }

        public Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH(Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> other): base(other)
        {
            this.__slot_TrmdGkADRnoNx6ODwa2xUK = other.__slot_TrmdGkADRnoNx6ODwa2xUK;
            this.Clock = other.Clock;
            this.__p_FSmPrdVyLfzMjc9ERUOjlQ = other.__p_FSmPrdVyLfzMjc9ERUOjlQ;
        }

        protected override n1.IVLObject __With__(n5.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_TrmdGkADRnoNx6ODwa2xUK", in __slot_TrmdGkADRnoNx6ODwa2xUK), n1.CompilationHelper.GetValueOrExisting(values, "Clock", in Clock), n1.CompilationHelper.GetValueOrExisting(values, "__p_FSmPrdVyLfzMjc9ERUOjlQ", in __p_FSmPrdVyLfzMjc9ERUOjlQ));
        }

        internal Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> __WITH__(T __slot_TrmdGkADRnoNx6ODwa2xUK, n12.IFrameClock Clock, n38.MassSpring_ThiX3p7ISOINTOij9kpcDi<T> __p_FSmPrdVyLfzMjc9ERUOjlQ)
        {
            n35.Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n5.EqualityComparer<T>.Default.Equals(__slot_TrmdGkADRnoNx6ODwa2xUK, this.__slot_TrmdGkADRnoNx6ODwa2xUK) || Clock != this.Clock || __p_FSmPrdVyLfzMjc9ERUOjlQ != this.__p_FSmPrdVyLfzMjc9ERUOjlQ ? new Oscillator_Fast_NV7Jp8StqbYLmGMQsFc4RH<T>(this)
                {__slot_TrmdGkADRnoNx6ODwa2xUK = __slot_TrmdGkADRnoNx6ODwa2xUK, Clock = Clock, __p_FSmPrdVyLfzMjc9ERUOjlQ = __p_FSmPrdVyLfzMjc9ERUOjlQ} : that_0;
            else
            {
                this.__slot_TrmdGkADRnoNx6ODwa2xUK = __slot_TrmdGkADRnoNx6ODwa2xUK;
                this.Clock = Clock;
                this.__p_FSmPrdVyLfzMjc9ERUOjlQ = __p_FSmPrdVyLfzMjc9ERUOjlQ;
            }

            return that_0;
        }
    }
}

namespace _VL_Animation_
{
    public struct __AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14 : n9.IAdaptiveOperatorMinus<n36.Vector2>, n9.IAdaptiveOperatorMulitply_Scale<n36.Vector2>, n9.IAdaptiveOperatorPlus<n36.Vector2>, n8.IAdaptiveCreateDefault<n36.Vector2>, n9.IAdaptiveOperatorMinus<float>, n9.IAdaptiveOperatorMulitply_Scale<float>, n9.IAdaptiveOperatorPlus<float>, n8.IAdaptiveCreateDefault<float>, n49.IAdaptiveMirror_Range<n36.Vector2>, n9.IAdaptiveOperatorDivide<n36.Vector2>, n50.IAdaptiveMirror_UnitRange<n36.Vector2>, n9.IAdaptiveOne<n36.Vector2>, n9.IAdaptiveFloor_Float<n36.Vector2>, n9.IAdaptiveAbs<n36.Vector2>, n9.IAdaptiveOperatorMulitply<n36.Vector2>, n50.IAdaptiveClamp_Range<n36.Vector2>, n8.IAdaptiveCreateDefault<n2.Func<n36.Vector2, n36.Vector2>>, n49.IAdaptiveWrap_Range<n36.Vector2>, n9.IAdaptiveZMOD<n36.Vector2>, n9.IAdaptiveNE<n36.Vector2>, n9.IAdaptiveZero<n36.Vector2>, n9.IAdaptiveOperatorMinus<n36.Vector3>, n9.IAdaptiveOperatorMulitply_Scale<n36.Vector3>, n9.IAdaptiveOperatorPlus<n36.Vector3>, n8.IAdaptiveCreateDefault<n36.Vector3>, n49.IAdaptiveMirror_Range<n36.Vector3>, n9.IAdaptiveOperatorDivide<n36.Vector3>, n50.IAdaptiveMirror_UnitRange<n36.Vector3>, n9.IAdaptiveOne<n36.Vector3>, n9.IAdaptiveFloor_Float<n36.Vector3>, n9.IAdaptiveAbs<n36.Vector3>, n9.IAdaptiveOperatorMulitply<n36.Vector3>, n50.IAdaptiveClamp_Range<n36.Vector3>, n8.IAdaptiveCreateDefault<n2.Func<n36.Vector3, n36.Vector3>>, n49.IAdaptiveWrap_Range<n36.Vector3>, n9.IAdaptiveZMOD<n36.Vector3>, n9.IAdaptiveNE<n36.Vector3>, n9.IAdaptiveZero<n36.Vector3>, n54.IAdaptiveToFloat32<float>, n55.IAdaptiveToFloat64<float>, n9.IAdaptiveRound_Float<float>, n9.IAdaptiveAvoidNaN<float>, n9.IAdaptiveIsNaN<float>, n9.IAdaptiveNE<float>, n9.IAdaptiveOperatorMinus_Negate<float>, n9.IAdaptiveZero<float>, n56.IAdaptiveCos<float>, n9.IAdaptiveOperatorDivide_Scale<float>, n56.IAdaptiveSin<float>, n9.IAdaptiveRound_Float<n36.Vector2>, n9.IAdaptiveAvoidNaN<n36.Vector2>, n9.IAdaptiveOperatorMinus_Negate<n36.Vector2>, n9.IAdaptiveIsNaN<n36.Vector2>, n9.IAdaptiveOperatorDivide_Scale<n36.Vector2>, n9.IAdaptiveRound_Float<n36.Vector3>, n9.IAdaptiveAvoidNaN<n36.Vector3>, n9.IAdaptiveOperatorMinus_Negate<n36.Vector3>, n9.IAdaptiveIsNaN<n36.Vector3>, n9.IAdaptiveOperatorDivide_Scale<n36.Vector3>, n8.IAdaptiveCreateDefault<double>, n9.IAdaptiveOne<float>, n9.IAdaptiveOperatorGreaterThan<float>, n56.IAdaptiveCyclesToRadians<float>, n9.IAdaptiveOperatorMulitply<float>, n9.IAdaptiveOperatorLess<float>, n9.IAdaptiveOperatorGreater<float>, n9.IAdaptiveOperatorMinus<double>, n50.IAdaptiveClamp_UnitRange<double>, n9.IAdaptiveOne<double>, n9.IAdaptiveOperatorLess<double>, n9.IAdaptiveZero<double>, n9.IAdaptiveOperatorDivide<double>, n9.IAdaptiveOperatorMulitply<double>, n9.IAdaptiveOperatorPlus<double>
    {
        public void OperatorMinus(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out n36.Vector2 Output_Out)
        {
            n36.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(n36.Vector2 Input_In, float Scalar_In, out n36.Vector2 Output_Out)
        {
            n40.Vector2Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out n36.Vector2 Output_Out)
        {
            n36.Vector2.Add(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n36.Vector2 Output_Out)
        {
            var Zero_0 = n42._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.Scale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Mirror_Range(n36.Vector2 Input_In, n40.Range<n36.Vector2> Range_In, out n36.Vector2 Output_Out)
        {
            n37._Operations_.Mirror_Range<n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out n36.Vector2 Output_Out)
        {
            var Output_0 = (n36.Vector2)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Mirror_UnitRange(n36.Vector2 Input_In, out n36.Vector2 Output_Out)
        {
            n37._Operations_.Mirror_UnitRange<n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n36.Vector2 One_Out)
        {
            var One_0 = n36.Vector2.One;
            One_Out = One_0;
            return;
        }

        public void Floor_Float(n36.Vector2 Input_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.Floor_Float(Input_In: Input_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Abs(n36.Vector2 Input_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.Abs(Input_In: Input_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out n36.Vector2 Output_Out)
        {
            n40.Vector2Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Clamp_Range(n36.Vector2 Input_In, n40.Range<n36.Vector2> Range_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.Clamp_Range(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.Func<n36.Vector2, n36.Vector2> Output_Out)
        {
            var Output_0 = n48._Operations_.CreateDefault<n36.Vector2, n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            Output_Out = Output_0;
            return;
        }

        public void Wrap_Range(n36.Vector2 Input_In, n40.Range<n36.Vector2> Range_In, out n36.Vector2 Output_Out)
        {
            n37._Operations_.Wrap_Range<n36.Vector2, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void ZMOD(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.ZMOD(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void NE(n36.Vector2 Input_In, n36.Vector2 Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Zero(out n36.Vector2 Zero_Out)
        {
            var Zero_0 = n36.Vector2.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void OperatorMinus(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out n36.Vector3 Output_Out)
        {
            n36.Vector3.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(n36.Vector3 Input_In, float Scalar_In, out n36.Vector3 Output_Out)
        {
            n40.Vector3Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out n36.Vector3 Output_Out)
        {
            n36.Vector3.Add(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n36.Vector3 Output_Out)
        {
            var Zero_0 = n46._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void Mirror_Range(n36.Vector3 Input_In, n40.Range<n36.Vector3> Range_In, out n36.Vector3 Output_Out)
        {
            n37._Operations_.Mirror_Range<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out n36.Vector3 Output_Out)
        {
            var Output_0 = (n36.Vector3)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Mirror_UnitRange(n36.Vector3 Input_In, out n36.Vector3 Output_Out)
        {
            n37._Operations_.Mirror_UnitRange<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n36.Vector3 One_Out)
        {
            var One_0 = n36.Vector3.One;
            One_Out = One_0;
            return;
        }

        public void Floor_Float(n36.Vector3 Input_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.Floor_Float(Input_In: Input_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Abs(n36.Vector3 Input_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.Abs(Input_In: Input_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out n36.Vector3 Output_Out)
        {
            n40.Vector3Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Clamp_Range(n36.Vector3 Input_In, n40.Range<n36.Vector3> Range_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.Clamp_Range(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.Func<n36.Vector3, n36.Vector3> Output_Out)
        {
            var Output_0 = n48._Operations_.CreateDefault<n36.Vector3, n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>();
            Output_Out = Output_0;
            return;
        }

        public void Wrap_Range(n36.Vector3 Input_In, n40.Range<n36.Vector3> Range_In, out n36.Vector3 Output_Out)
        {
            n37._Operations_.Wrap_Range<n36.Vector3, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Range_In: Range_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void ZMOD(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.ZMOD(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void NE(n36.Vector3 Input_In, n36.Vector3 Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Zero(out n36.Vector3 Zero_Out)
        {
            var Zero_0 = n36.Vector3.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void ToFloat32(float Input_In, out float Result_Out)
        {
            var Output_0 = n15.IntegerConversions.ToFloat32(input: Input_In);
            Result_Out = Output_0;
            return;
        }

        public void ToFloat64(float Input_In, out double Result_Out)
        {
            var Result_0 = n15.IntegerConversions.ToFloat64(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public void Round_Float(float Input_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.RoundFloat(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(float Input_In, float Default_In, out float Output_Out)
        {
            n57._Operations_.AvoidNaN<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Default_In: Default_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void IsNaN(float Input_In, out bool Result_Out)
        {
            n57._Operations_.IsNaN<float, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void NE(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorMinus_Negate(float Input_In, out float Output_Out)
        {
            var Output_0 = -Input_In;
            Output_Out = Output_0;
            return;
        }

        public void Zero(out float Zero_Out)
        {
            var Zero_0 = n15.Float32Extensions.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void Cos(float Input_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.Cos(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.DivideScale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void Sin(float Input_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.Sin(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public void Round_Float(n36.Vector2 Input_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.Round_Float(Input_In: Input_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(n36.Vector2 Input_In, n36.Vector2 Default_In, out n36.Vector2 Output_Out)
        {
            n42._Operations_.AvoidNaN(Input_In: Input_In, Default_In: Default_In, Output_Out: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus_Negate(n36.Vector2 Input_In, out n36.Vector2 Output_Out)
        {
            n36.Vector2.Negate(value: ref Input_In, result: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void IsNaN(n36.Vector2 Input_In, out bool Result_Out)
        {
            n42._Operations_.IsNaN(Input_In: Input_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void OperatorDivide_Scale(n36.Vector2 Input_In, float Scalar_In, out n36.Vector2 Output_Out)
        {
            n40.Vector2Nodes.DivScale(input: ref Input_In, scalar: Scalar_In, output: out n36.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Round_Float(n36.Vector3 Input_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.Round_Float(Input_In: Input_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(n36.Vector3 Input_In, n36.Vector3 Default_In, out n36.Vector3 Output_Out)
        {
            n46._Operations_.AvoidNaN(Input_In: Input_In, Default_In: Default_In, Output_Out: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus_Negate(n36.Vector3 Input_In, out n36.Vector3 Output_Out)
        {
            n36.Vector3.Negate(value: ref Input_In, result: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void IsNaN(n36.Vector3 Input_In, out bool Result_Out)
        {
            n46._Operations_.IsNaN(Input_In: Input_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void OperatorDivide_Scale(n36.Vector3 Input_In, float Scalar_In, out n36.Vector3 Output_Out)
        {
            n40.Vector3Nodes.DivScale(input: ref Input_In, scalar: Scalar_In, output: out n36.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out double Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<double>(Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out float One_Out)
        {
            var One_0 = n15.Float32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorGreaterThan(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In >= Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CyclesToRadians(float Input_In, out float Output_Out)
        {
            var Output_0 = n15.Float32Extensions.CyclesToRadians(cycles: Input_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorGreater(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorMinus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Clamp_UnitRange(double Input_In, out double Output_Out)
        {
            n37._Operations_.Clamp_UnitRange<double, n34.__AdaptiveImplementations__U2O4IiXgnrTMwv9Zd92a14>(Input_In: Input_In, Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out double One_Out)
        {
            var One_0 = n15.Float64Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorLess(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Zero(out double Zero_Out)
        {
            var Zero_0 = n15.Float64Extensions.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void OperatorDivide(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = (double)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }
    }
}