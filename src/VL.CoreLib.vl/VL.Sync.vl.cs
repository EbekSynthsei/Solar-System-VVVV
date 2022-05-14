extern alias e2;
extern alias e5;

using n2 = _VL_Sync_.IO;
using n7 = e2::VL.Lib.IO.Socket;
using n23 = _CoreLibBasics_.Animation.FrameBased;
using n19 = e2::VL.Lib.Primitive;
using n22 = _VL_Reactive_.Reactive.ToObservable;
using n37 = _CoreLibBasics_.Primitive.Object.Advanced;
using n31 = _CoreLibBasics_.Control;
using n24 = _System_Serialization_.System.Serialization.Volatile.Advanced;
using n39 = _CoreLibBasics_.Math.Generic.Advanced;
using n33 = e2::VL.Lib.Text;
using n42 = _VL_CoreLib_IO_.IO.Net;
using n26 = _VL_CoreLib_IO_.IO.Socket.UdpSocket.Advanced;
using n45 = _CoreLibBasics_.Animation.IClock.Advanced;
using n10 = e5::VL.Lib.Animation;
using n38 = _CoreLibBasics_.Primitive;
using n18 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n5 = global::System.Net;
using n35 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n43 = _VL_CoreLib_IO_.IO.Socket;
using n11 = global::System.Collections.Generic;
using n47 = _CoreLibBasics_.Math.Adaptive;
using n30 = _VL_Sync_;
using n29 = _VL_Reactive_.Reactive.Observable.Advanced;
using n46 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n41 = _CoreLibBasics_.Animation.Time;
using n40 = _VL_Sync_.IO.ClockSyncClient.Internal;
using n6 = e2::VL.Lib.Primitive.CacheRegion;
using n44 = _VL_Sync_.IO.FramePlayer;
using n20 = _VL_Reactive_.Reactive.ForEach_Keep;
using n8 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n48 = global::System.Net.Sockets;
using n3 = global::System;
using n17 = _VL_CoreLib_IO_.IO.Net.Advanced;
using n36 = _VL_Reactive_.Reactive;
using n28 = e2::VL.Sync;
using n15 = _VL_CoreLib_IO_.IO.Socket.Datagram;
using n21 = _VL_CoreLib_IO_.IO.Socket.Sender_Datagram.Advanced;
using n27 = _VL_CoreLib_IO_.IO.Socket.Receiver_Datagram.Advanced;
using n16 = _VL_Reactive_.Reactive.ForEach;
using n34 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n9 = _VL_Reactive_.Reactive.HoldLatest;
using n12 = _VL_Collections_.Collections.Sequence;
using n25 = global::System.Runtime.CompilerServices;
using n32 = _CoreLibBasics_.Text.Encodings;
using n13 = e5::VL.Lib.Collections;
using n14 = _VL_Collections_.Collections.Spread;
using n49 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_Sync_.IO
{
    [n1.ElementAttribute(TracingId = 260748U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LchMaugJjJPLuM5DGpn1gT", Name = "PlayerSyncServer_C")]
    [n3.SerializableAttribute]
    public class PlayerSyncServer_C : n1.VLObject, n2.ITimeSync_I, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.PlayerSyncServer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new PlayerSyncServer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.PlayerSyncServer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new PlayerSyncServer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.PlayerSyncServer_C Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("6666", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Socket_is_Open_Out, out bool On_Data_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_TJwJhpzVMk5PhHpHHWoc3p;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_3 = (Local_Address_In, Local_Port_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Result_8 = n5.IPAddress.TryParse(ipString: Local_Address_In, address: out n5.IPAddress Address_7);
                var Output_9 = new n5.IPEndPoint(address: Address_7, port: Local_Port_In);
                outputs_4 = (Result_8, Output_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_10, __auto_11) = outputs_4;
            this.__cache_TJwJhpzVMk5PhHpHHWoc3p = manager_2;
            var Output_12 = __auto_10 && Enabled_In;
            n7.UDPSocket Input_13 = this.__p_TN27FUdFUlYO9ZBdtCkYLa;
            var Is_Open_14 = Input_13.IsOpen;
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = Input_13;
            bool SetEnabled_15 = true;
            var Output_16 = Input_13;
            if (SetEnabled_15)
            {
                Input_13.Enabled = Output_12;
                Output_16 = Input_13;
            }

            this.__p_TN27FUdFUlYO9ZBdtCkYLa = Output_16;
            n9._Operations_.GetData_H<n7.Datagram>(Input_In: this.__p_ANYUCrsAoLYMTcwMKvWmSB, Output_Out: out n8.HoldLatest<n7.Datagram> Output_17, Value_Out: out n7.Datagram Value_18, On_Data_Out: out bool On_Data_19);
            this.__p_ANYUCrsAoLYMTcwMKvWmSB = Output_17;
            var Remote_End_Point_20 = Value_18.RemoteEndPoint;
            this.__slot_EzqOB64xctAPvuUy3uhI8g = Remote_End_Point_20;
            n5.IPEndPoint __pad_EzqOB64xctAPvuUy3uhI8g_21 = Remote_End_Point_20;
            Socket_is_Open_Out = Is_Open_14;
            On_Data_Out = On_Data_19;
            return this;
        }

        public n2.PlayerSyncServer_C SetTimes_(double Stream_Position_In, float Stream_Duration_In)
        {
            this.__slot_U7y8MmQqyGZOPhXiqao68X = Stream_Position_In;
            double __pad_U7y8MmQqyGZOPhXiqao68X_0 = Stream_Position_In;
            var Current_Time_1 = n10.Clocks.CurrentTime;
            var Seconds_2 = Current_Time_1.Seconds;
            this.__slot_GmUc0xRrS3YLP6WrHhlcED = Seconds_2;
            double __pad_GmUc0xRrS3YLP6WrHhlcED_3 = Seconds_2;
            return this;
        }

        public n2.PlayerSyncServer_C SetControls()
        {
            return this;
        }

        public n2.PlayerSyncServer_C SyncControls_(float Loop_Start_Time_In, float Loop_End_Time_In, bool Loop_In, float Seek_Time_In, bool Seek_In, float Rate_In, bool Play_In, out float Loop_Start_Time_Out, out float Loop_End_Time_Out, out bool Loop_Out, out float Seek_Time_Out, out bool Seek_Out, out float Rate_Out, out bool Play_Out)
        {
            double __pad_U7y8MmQqyGZOPhXiqao68X_0 = this.__slot_U7y8MmQqyGZOPhXiqao68X;
            double __pad_GmUc0xRrS3YLP6WrHhlcED_1 = this.__slot_GmUc0xRrS3YLP6WrHhlcED;
            n7.DatagramReceiver Input_2 = this.__p_BRVXKU1S8dWOCX8iGmLKh4;
            var Datagrams_3 = Input_2.Datagrams;
            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = Input_2;
            bool Reset_4 = false;
            var __fallback___5 = n1.ServiceRegistry.Current;
            n16._Operations_.Update_H<n3.Object, n7.Datagram, n7.Datagram>(Input_In: this.__p_SzYfFdZAzkMPOMfJqNrXMt, Messages_In: Datagrams_3, Reset_In: Reset_4, Update_In: (n3.Object s_8, n7.Datagram Input_1_In_9) =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                var state_7 = n1.CompilationHelper.Restore<__I985T0yioHiQV5rFANiUXd>(s_8, __GetContext__());
                var Remote_End_Point_10 = Input_1_In_9.RemoteEndPoint;
                var Result_11 = n3.BitConverter.GetBytes(value: __pad_U7y8MmQqyGZOPhXiqao68X_0);
                n11.IEnumerable<byte> Input_12 = (n11.IEnumerable<byte>)Result_11;
                var Result_13 = n3.BitConverter.GetBytes(value: __pad_GmUc0xRrS3YLP6WrHhlcED_1);
                n11.IEnumerable<byte> Input_2_14 = (n11.IEnumerable<byte>)Result_13;
                n12._Operations_.Concat<byte>(Input_In: Input_12, Input_2_In: Input_2_14, Output_Out: out n11.IEnumerable<byte> Output_15);
                n14._Operations_.FromSequence<byte>(Input_In: Output_15, Result_Out: out n13.Spread<byte> Result_16);
                n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "LWL7DjJMvjCPDfOXL5AqEM", 260803U);
                n15._Operations_.Create(Node_Context: Node_Context_17, Remote_End_Point_In: Remote_End_Point_10, Payload_In: Result_16, Output_Out: out n7.Datagram Output_18);
                return n3.Tuple.Create<n3.Object, n7.Datagram>(state_7, Output_18);
            }

            , Create_In: () =>
            {
                using var __current_19 = __fallback___5.MakeCurrentIfNone();
                var state_7 = new __I985T0yioHiQV5rFANiUXd(__GetContext__(), n1.VLObject.NewIdentity());
                return state_7;
            }

            , Output_Out: out n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> Output_20, Result_Out: out n3.IObservable<n7.Datagram> Result_21);
            this.__p_SzYfFdZAzkMPOMfJqNrXMt = Output_20;
            bool Reset_22 = false;
            n20._Operations_.Update_H<n3.Object, n7.Datagram, n5.IPEndPoint>(Input_In: this.__p_K8gvOalPgl1NSxjLLZxZoq, Messages_In: Result_21, Reset_In: Reset_22, Update_In: (n3.Object s_25, n7.Datagram Input_1_In_26) =>
            {
                using var __current_23 = __fallback___5.MakeCurrentIfNone();
                var state_24 = n1.CompilationHelper.Restore<__BXZLaBtOYblP0oiukPInYF>(s_25, __GetContext__());
                var Remote_End_Point_27 = Input_1_In_26.RemoteEndPoint;
                var Port_28 = Remote_End_Point_27.Port;
                int Input_2_29 = 0;
                var Result_30 = Port_28 > Input_2_29;
                n5.IPEndPoint __auto_31;
                var state_32 = n1.CompilationHelper.Restore<__Qmc3ekDAJm5MCcgunlunv9>(state_24.__if_OiiRMjJtI5NM2vA2m1d84t, __GetContext__());
                if (Result_30)
                {
                    if (state_32 == null)
                    {
                        state_32 = new __Qmc3ekDAJm5MCcgunlunv9(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "PmPCuCUctMTLWsUg2a8HoQ", 261223U);
                        var Output_34 = n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_33);
                        state_32.__p_PmPCuCUctMTLWsUg2a8HoQ = Output_34;
                    }

                    string __pad_PeguZCcWprmMll0NhCc2Ml_35 = __slot_PeguZCcWprmMll0NhCc2Ml;
                    var Address_36 = Remote_End_Point_27.Address;
                    var Result_37 = n18.ObjectHelpers.ToString(input: Address_36);
                    char Value_38 = '.';
                    var Result_39 = Result_37.LastIndexOf(value: Value_38);
                    int Start_Index_40 = 0;
                    var Output_41 = Result_37.Substring(startIndex: Start_Index_40, length: Result_39);
                    var Output_42 = n19.StringExtensions.Plus(input: Output_41, input2: __pad_PeguZCcWprmMll0NhCc2Ml_35);
                    var Result_43 = n5.IPAddress.Parse(ipString: Output_42);
                    var State_Output_45 = state_32.__p_PmPCuCUctMTLWsUg2a8HoQ.Update(Address_In: Result_43, Port_In: Port_28, Output_Out: out n5.IPEndPoint Output_44);
                    __auto_31 = Output_44;
                    state_32.__p_PmPCuCUctMTLWsUg2a8HoQ = State_Output_45;
                }
                else
                {
                    __auto_31 = default(n5.IPEndPoint);
                }

                state_24.__if_OiiRMjJtI5NM2vA2m1d84t = state_32;
                return n3.Tuple.Create<n3.Object, n5.IPEndPoint, bool>(state_24, __auto_31, Result_30);
            }

            , Create_In: () =>
            {
                using var __current_46 = __fallback___5.MakeCurrentIfNone();
                var state_24 = new __BXZLaBtOYblP0oiukPInYF(__GetContext__(), n1.VLObject.NewIdentity());
                return state_24;
            }

            , Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n5.IPEndPoint> Output_47, Result_Out: out n3.IObservable<n5.IPEndPoint> Result_48);
            this.__p_K8gvOalPgl1NSxjLLZxZoq = Output_47;
            bool Reset_49 = false;
            bool Update_50 = true;
            var Output_51 = this.__p_D6icpOSbPRiPQ2O33LhCtk;
            if (Update_50)
            {
                n9._Operations_.Update_H<n5.IPEndPoint>(Input_In: this.__p_D6icpOSbPRiPQ2O33LhCtk, Async_Notifications_In: Result_48, Reset_In: Reset_49, Output_Out: out Output_51);
            }

            this.__p_D6icpOSbPRiPQ2O33LhCtk = Output_51;
            n9._Operations_.GetData_H<n5.IPEndPoint>(Input_In: Output_51, Output_Out: out n8.HoldLatest<n5.IPEndPoint> Output_52, Value_Out: out n5.IPEndPoint Value_53, On_Data_Out: out bool On_Data_54);
            this.__p_D6icpOSbPRiPQ2O33LhCtk = Output_52;
            var manager_55 = this.__cache_TJwJhpzVMk5PhHpHHWoc3p;
            if (manager_55 is null)
            {
                manager_55 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var(__auto_56, __auto_57) = manager_55.Outputs;
            bool Bind_58 = true;
            n7.UDPSocket Input_59 = this.__p_TN27FUdFUlYO9ZBdtCkYLa;
            var Result_60 = Input_59.Update(localEndPoint: __auto_57, bind: Bind_58);
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = Input_59;
            bool Dispose_Cached_Outputs_61 = false;
            var manager_62 = this.__cache_UK7PpYlj1rYNIjIkVFKvo2;
            if (manager_62 is null)
            {
                manager_62 = new n6.Manager<n3.ValueTuple<float, float, bool, float, bool, bool, float>, n3.ValueTuple>(n3.ValueTuple.Create());
            }

            var inputs_63 = (Loop_Start_Time_In, Loop_End_Time_In, Loop_In, Seek_Time_In, Seek_In, Play_In, Rate_In);
            var outputs_64 = manager_62.Outputs;
            var Has_Changed_65 = On_Data_54 || manager_62.InputsChanged(inputs_63);
            if (Has_Changed_65)
            {
                if (Dispose_Cached_Outputs_61)
                    manager_62.DisposeOutputs();
                var state_66 = n1.CompilationHelper.Restore<__O48LvNVjzn4QPBfZ50siXO>(manager_62.State, __GetContext__());
                if (state_66 == null)
                {
                    state_66 = new __O48LvNVjzn4QPBfZ50siXO(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_67 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "TYmFojJP1NZNdeDi2M7jRl", 261038U);
                    n21._Operations_.Create_H(Node_Context_In: Node_Context_67, Output_Out: out n7.DatagramSender Output_68);
                    state_66.__p_TYmFojJP1NZNdeDi2M7jRl = Output_68;
                    n1.NodeContext Node_Context_69 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "ANOPJCiSuvWLx22OgKnDnB", 261042U);
                    n22._Operations_.Create_H<n7.Datagram>(Node_Context: Node_Context_69, Output_Out: out n8.ToObservable<n7.Datagram> Output_70);
                    state_66.__p_ANOPJCiSuvWLx22OgKnDnB = Output_70;
                    n1.NodeContext Node_Context_71 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "InlZumDWfEWQTCPRXd6Nz1", 261102U);
                    var Output_72 = n23.Counter_UIay2coHW4dO2NuoNnTZ3G.Create(Node_Context: Node_Context_71);
                    state_66.__p_InlZumDWfEWQTCPRXd6Nz1 = Output_72;
                }

                int Increment_73 = 1;
                int Default_74 = 0;
                bool Update_75 = true;
                var Output_76 = state_66.__p_InlZumDWfEWQTCPRXd6Nz1;
                if (Update_75)
                {
                    Output_76 = state_66.__p_InlZumDWfEWQTCPRXd6Nz1.Update(Increment_In: Increment_73, Default_In: Default_74);
                }

                var Output_77 = Output_76;
                if (Seek_In)
                {
                    Output_77 = Output_76.Up();
                }

                var Output_79 = Output_77.GetValue(Value_Out: out int Value_78);
                n1.NodeContext Node_Context_80 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "P8gMEWis17xOqeU5DGMskN", 261057U);
                var Output_81 = n2.PlayerController_R.Create(Node_Context: Node_Context_80, Loop_From_In: Loop_Start_Time_In, Loop_To_In: Loop_End_Time_In, Loop_In: Loop_In, Seek_Time_In: Seek_Time_In, Seek_In: Value_78, Rate_In: Rate_In, Play_In: Play_In);
                bool Force_Little_Endian_82 = false;
                n24._Operations_.Serialize_Binary<n2.PlayerController_R>(Value_In: Output_81, Force_Little_Endian_In: Force_Little_Endian_82, Result_Out: out byte[] Result_83);
                n11.IEnumerable<byte> Input_84 = (n11.IEnumerable<byte>)Result_83;
                n14._Operations_.FromSequence<byte>(Input_In: Input_84, Result_Out: out n13.Spread<byte> Result_85);
                n1.NodeContext Node_Context_86 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "F9N0tgEYYE3QVH4eOUGP2M", 261047U);
                n15._Operations_.Create(Node_Context: Node_Context_86, Remote_End_Point_In: Value_53, Payload_In: Result_85, Output_Out: out n7.Datagram Output_87);
                bool Send_88 = true;
                n22._Operations_.Update_H<n7.Datagram>(Input_In: state_66.__p_ANOPJCiSuvWLx22OgKnDnB, Message_In: Output_87, Send_In: Send_88, Output_Out: out n8.ToObservable<n7.Datagram> Output_89, Result_Out: out n3.IObservable<n7.Datagram> Result_90);
                bool Update_91 = true;
                var Output_92 = state_66.__p_TYmFojJP1NZNdeDi2M7jRl;
                if (Update_91)
                {
                    n7.DatagramSender Input_93 = state_66.__p_TYmFojJP1NZNdeDi2M7jRl;
                    Input_93.Update(localSocket: Result_60, datagrams: Result_90);
                    Output_92 = Input_93;
                }

                state_66.__p_InlZumDWfEWQTCPRXd6Nz1 = Output_79;
                state_66.__p_ANOPJCiSuvWLx22OgKnDnB = Output_89;
                state_66.__p_TYmFojJP1NZNdeDi2M7jRl = Output_92;
                outputs_64 = n3.ValueTuple.Create();
                manager_62 = manager_62.Update(inputs_63, __GetContext__().IsImmutable, Dispose_Cached_Outputs_61, state_66, outputs_64);
            }
            else
            {
                manager_62.Update(inputs_63, __GetContext__().IsImmutable, Dispose_Cached_Outputs_61);
            }

            this.__cache_UK7PpYlj1rYNIjIkVFKvo2 = manager_62;
            bool Update_94 = true;
            var Output_95 = Input_2;
            if (Update_94)
            {
                Input_2.Update(localSocket: Result_60);
                Output_95 = Input_2;
            }

            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = Output_95;
            bool Update_96 = true;
            var Output_97 = this.__p_MioGnh8VcVQMBQvGzrZ1ys;
            if (Update_96)
            {
                n7.DatagramSender Input_98 = this.__p_MioGnh8VcVQMBQvGzrZ1ys;
                Input_98.Update(localSocket: Result_60, datagrams: Result_21);
                Output_97 = Input_98;
            }

            this.__p_MioGnh8VcVQMBQvGzrZ1ys = Output_97;
            bool Reset_99 = false;
            bool Update_100 = true;
            var Output_101 = this.__p_ANYUCrsAoLYMTcwMKvWmSB;
            if (Update_100)
            {
                n9._Operations_.Update_H<n7.Datagram>(Input_In: this.__p_ANYUCrsAoLYMTcwMKvWmSB, Async_Notifications_In: Result_21, Reset_In: Reset_99, Output_Out: out Output_101);
            }

            this.__p_ANYUCrsAoLYMTcwMKvWmSB = Output_101;
            Loop_Start_Time_Out = Loop_Start_Time_In;
            Loop_End_Time_Out = Loop_End_Time_In;
            Loop_Out = Loop_In;
            Seek_Time_Out = Seek_Time_In;
            Seek_Out = Seek_In;
            Rate_Out = Rate_In;
            Play_Out = Play_In;
            return this;
        }

        public n2.PlayerSyncServer_C __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_U7y8MmQqyGZOPhXiqao68X = 0;
            this.__slot_GmUc0xRrS3YLP6WrHhlcED = 0;
            this.__slot_EzqOB64xctAPvuUy3uhI8g = default(n5.IPEndPoint);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "SzYfFdZAzkMPOMfJqNrXMt", 260751U);
            n16._Operations_.Create_H<n3.Object, n7.Datagram, n7.Datagram>(Node_Context: Node_Context_0, Output_Out: out n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> Output_1);
            this.__p_SzYfFdZAzkMPOMfJqNrXMt = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "TN27FUdFUlYO9ZBdtCkYLa", 260839U);
            n26._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n7.UDPSocket Output_3);
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "BRVXKU1S8dWOCX8iGmLKh4", 260924U);
            n27._Operations_.Create_H(Node_Context: Node_Context_4, Output_Out: out n7.DatagramReceiver Output_5);
            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "MioGnh8VcVQMBQvGzrZ1ys", 260937U);
            n21._Operations_.Create_H(Node_Context_In: Node_Context_6, Output_Out: out n7.DatagramSender Output_7);
            this.__p_MioGnh8VcVQMBQvGzrZ1ys = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "ANYUCrsAoLYMTcwMKvWmSB", 260947U);
            n7.Datagram Initial_Result_9 = default(n7.Datagram);
            n9._Operations_.Create_H<n7.Datagram>(Node_Context: Node_Context_8, Initial_Result_In: Initial_Result_9, Output_Out: out n8.HoldLatest<n7.Datagram> Output_10);
            this.__p_ANYUCrsAoLYMTcwMKvWmSB = Output_10;
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "K8gvOalPgl1NSxjLLZxZoq", 261147U);
            n20._Operations_.Create_H<n3.Object, n7.Datagram, n5.IPEndPoint>(Node_Context: Node_Context_11, Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n5.IPEndPoint> Output_12);
            this.__p_K8gvOalPgl1NSxjLLZxZoq = Output_12;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "D6icpOSbPRiPQ2O33LhCtk", 261242U);
            n5.IPEndPoint Initial_Result_14 = default(n5.IPEndPoint);
            n9._Operations_.Create_H<n5.IPEndPoint>(Node_Context: Node_Context_13, Initial_Result_In: Initial_Result_14, Output_Out: out n8.HoldLatest<n5.IPEndPoint> Output_15);
            this.__p_D6icpOSbPRiPQ2O33LhCtk = Output_15;
            this.__cache_TJwJhpzVMk5PhHpHHWoc3p = null;
            this.__cache_UK7PpYlj1rYNIjIkVFKvo2 = null;
            return this;
        }

        public n2.PlayerSyncServer_C __CreateDefault__()
        {
            this.__slot_U7y8MmQqyGZOPhXiqao68X = 0;
            this.__slot_GmUc0xRrS3YLP6WrHhlcED = 0;
            this.__slot_EzqOB64xctAPvuUy3uhI8g = default(n5.IPEndPoint);
            this.__cache_TJwJhpzVMk5PhHpHHWoc3p = null;
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = default(n7.UDPSocket);
            this.__p_ANYUCrsAoLYMTcwMKvWmSB = default(n8.HoldLatest<n7.Datagram>);
            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = default(n7.DatagramReceiver);
            this.__p_SzYfFdZAzkMPOMfJqNrXMt = default(n8.ForEach<n3.Object, n7.Datagram, n7.Datagram>);
            this.__p_K8gvOalPgl1NSxjLLZxZoq = default(n8.ForEachKeep<n3.Object, n7.Datagram, n5.IPEndPoint>);
            this.__p_D6icpOSbPRiPQ2O33LhCtk = default(n8.HoldLatest<n5.IPEndPoint>);
            this.__cache_UK7PpYlj1rYNIjIkVFKvo2 = null;
            this.__p_MioGnh8VcVQMBQvGzrZ1ys = default(n7.DatagramSender);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_TJwJhpzVMk5PhHpHHWoc3p);
            n1.CompilationHelper.SafeDispose(this.__p_TN27FUdFUlYO9ZBdtCkYLa);
            n1.CompilationHelper.SafeDispose(this.__p_ANYUCrsAoLYMTcwMKvWmSB);
            n1.CompilationHelper.SafeDispose(this.__p_BRVXKU1S8dWOCX8iGmLKh4);
            n1.CompilationHelper.SafeDispose(this.__p_SzYfFdZAzkMPOMfJqNrXMt);
            n1.CompilationHelper.SafeDispose(this.__p_K8gvOalPgl1NSxjLLZxZoq);
            n1.CompilationHelper.SafeDispose(this.__p_D6icpOSbPRiPQ2O33LhCtk);
            n1.CompilationHelper.SafeDispose(this.__cache_UK7PpYlj1rYNIjIkVFKvo2);
            n1.CompilationHelper.SafeDispose(this.__p_MioGnh8VcVQMBQvGzrZ1ys);
            return;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SetTimes(double Stream_Position_In, float Stream_Duration_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetTimes_(Stream_Position_In, Stream_Duration_In);
            return __returnValue__;
        }

        n2.ITimeSync_I n2.ITimeSync_I.UpdateSync(out float Seek_Time_Out, out bool Seek_Out, out double Adjust_Time_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Seek_Time_Out = 0F;
            Seek_Out = false;
            Adjust_Time_Out = 0;
            return this;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SetClock(n10.IFrameClock Frame_Clock_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            return this;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SyncControls(float Loop_Start_Time_In, float Loop_End_Time_In, bool Loop_In, float Seek_Time_In, bool Seek_In, float Rate_In, bool Play_In, out float Loop_Start_Time_Out, out float Loop_End_Time_Out, out bool Loop_Out, out float Seek_Time_Out, out bool Seek_Out, out float Rate_Out, out bool Play_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SyncControls_(Loop_Start_Time_In, Loop_End_Time_In, Loop_In, Seek_Time_In, Seek_In, Rate_In, Play_In, out Loop_Start_Time_Out, out Loop_End_Time_Out, out Loop_Out, out Seek_Time_Out, out Seek_Out, out Rate_Out, out Play_Out);
            return __returnValue__;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 260822U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "U7y8MmQqyGZOPhXiqao68X", Name = "__slot_U7y8MmQqyGZOPhXiqao68X")]
        public double __slot_U7y8MmQqyGZOPhXiqao68X;
        [n1.ElementAttribute(TracingId = 260825U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "GmUc0xRrS3YLP6WrHhlcED", Name = "__slot_GmUc0xRrS3YLP6WrHhlcED")]
        public double __slot_GmUc0xRrS3YLP6WrHhlcED;
        [n1.ElementAttribute(TracingId = 260967U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Pe21lmGWw1EMmH1GS5lWlQ", Name = "__slot_Pe21lmGWw1EMmH1GS5lWlQ")]
        public static string __slot_Pe21lmGWw1EMmH1GS5lWlQ = "Server receives periodic ping from clients and responds with its own time and the current stream position";
        [n1.ElementAttribute(TracingId = 261012U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EzqOB64xctAPvuUy3uhI8g", Name = "__slot_EzqOB64xctAPvuUy3uhI8g")]
        public n5.IPEndPoint __slot_EzqOB64xctAPvuUy3uhI8g;
        [n1.ElementAttribute(TracingId = 261250U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "OTvyGTtW3dpNs7mLsIdKjW", Name = "__slot_OTvyGTtW3dpNs7mLsIdKjW")]
        public static string __slot_OTvyGTtW3dpNs7mLsIdKjW = "< figure out broadcast IP from messages received from clients";
        [n1.ElementAttribute(TracingId = 261256U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "VxEkCPAp8UvMMNWUQCnkZ8", Name = "__slot_VxEkCPAp8UvMMNWUQCnkZ8")]
        public static string __slot_VxEkCPAp8UvMMNWUQCnkZ8 = "< periodically send control parameters, so clients that join later, still get updated";
        [n1.ElementAttribute(TracingId = 260852U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TJwJhpzVMk5PhHpHHWoc3p", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_TJwJhpzVMk5PhHpHHWoc3p = null;
        [n1.ElementAttribute(TracingId = 260839U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TN27FUdFUlYO9ZBdtCkYLa", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n7.UDPSocket __p_TN27FUdFUlYO9ZBdtCkYLa;
        [n1.ElementAttribute(TracingId = 260947U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ANYUCrsAoLYMTcwMKvWmSB", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<n7.Datagram> __p_ANYUCrsAoLYMTcwMKvWmSB;
        [n1.ElementAttribute(TracingId = 260924U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BRVXKU1S8dWOCX8iGmLKh4", Name = "Receiver (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramReceiver __p_BRVXKU1S8dWOCX8iGmLKh4;
        [n1.ElementAttribute(TracingId = 260751U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SzYfFdZAzkMPOMfJqNrXMt", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> __p_SzYfFdZAzkMPOMfJqNrXMt;
        [n1.ElementAttribute(TracingId = 261147U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "K8gvOalPgl1NSxjLLZxZoq", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEachKeep<n3.Object, n7.Datagram, n5.IPEndPoint> __p_K8gvOalPgl1NSxjLLZxZoq;
        [n1.ElementAttribute(TracingId = 261220U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PeguZCcWprmMll0NhCc2Ml", Name = "__slot_PeguZCcWprmMll0NhCc2Ml")]
        public static string __slot_PeguZCcWprmMll0NhCc2Ml = ".255";
        [n1.ElementAttribute(TracingId = 261242U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "D6icpOSbPRiPQ2O33LhCtk", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<n5.IPEndPoint> __p_D6icpOSbPRiPQ2O33LhCtk;
        [n1.ElementAttribute(TracingId = 261020U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "UK7PpYlj1rYNIjIkVFKvo2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<float, float, bool, float, bool, bool, float>, n3.ValueTuple> __cache_UK7PpYlj1rYNIjIkVFKvo2 = null;
        [n1.ElementAttribute(TracingId = 260937U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "MioGnh8VcVQMBQvGzrZ1ys", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramSender __p_MioGnh8VcVQMBQvGzrZ1ys;
        static PlayerSyncServer_C()
        {
        }

        public PlayerSyncServer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PlayerSyncServer_C(PlayerSyncServer_C other): base(other)
        {
            this.__slot_U7y8MmQqyGZOPhXiqao68X = other.__slot_U7y8MmQqyGZOPhXiqao68X;
            this.__slot_GmUc0xRrS3YLP6WrHhlcED = other.__slot_GmUc0xRrS3YLP6WrHhlcED;
            this.__slot_EzqOB64xctAPvuUy3uhI8g = other.__slot_EzqOB64xctAPvuUy3uhI8g;
            this.__cache_TJwJhpzVMk5PhHpHHWoc3p = other.__cache_TJwJhpzVMk5PhHpHHWoc3p;
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = other.__p_TN27FUdFUlYO9ZBdtCkYLa;
            this.__p_ANYUCrsAoLYMTcwMKvWmSB = other.__p_ANYUCrsAoLYMTcwMKvWmSB;
            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = other.__p_BRVXKU1S8dWOCX8iGmLKh4;
            this.__p_SzYfFdZAzkMPOMfJqNrXMt = other.__p_SzYfFdZAzkMPOMfJqNrXMt;
            this.__p_K8gvOalPgl1NSxjLLZxZoq = other.__p_K8gvOalPgl1NSxjLLZxZoq;
            this.__p_D6icpOSbPRiPQ2O33LhCtk = other.__p_D6icpOSbPRiPQ2O33LhCtk;
            this.__cache_UK7PpYlj1rYNIjIkVFKvo2 = other.__cache_UK7PpYlj1rYNIjIkVFKvo2;
            this.__p_MioGnh8VcVQMBQvGzrZ1ys = other.__p_MioGnh8VcVQMBQvGzrZ1ys;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_U7y8MmQqyGZOPhXiqao68X", in __slot_U7y8MmQqyGZOPhXiqao68X), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GmUc0xRrS3YLP6WrHhlcED", in __slot_GmUc0xRrS3YLP6WrHhlcED), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EzqOB64xctAPvuUy3uhI8g", in __slot_EzqOB64xctAPvuUy3uhI8g), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TJwJhpzVMk5PhHpHHWoc3p", in __cache_TJwJhpzVMk5PhHpHHWoc3p), n1.CompilationHelper.GetValueOrExisting(values, "__p_TN27FUdFUlYO9ZBdtCkYLa", in __p_TN27FUdFUlYO9ZBdtCkYLa), n1.CompilationHelper.GetValueOrExisting(values, "__p_ANYUCrsAoLYMTcwMKvWmSB", in __p_ANYUCrsAoLYMTcwMKvWmSB), n1.CompilationHelper.GetValueOrExisting(values, "__p_BRVXKU1S8dWOCX8iGmLKh4", in __p_BRVXKU1S8dWOCX8iGmLKh4), n1.CompilationHelper.GetValueOrExisting(values, "__p_SzYfFdZAzkMPOMfJqNrXMt", in __p_SzYfFdZAzkMPOMfJqNrXMt), n1.CompilationHelper.GetValueOrExisting(values, "__p_K8gvOalPgl1NSxjLLZxZoq", in __p_K8gvOalPgl1NSxjLLZxZoq), n1.CompilationHelper.GetValueOrExisting(values, "__p_D6icpOSbPRiPQ2O33LhCtk", in __p_D6icpOSbPRiPQ2O33LhCtk), n1.CompilationHelper.GetValueOrExisting(values, "__cache_UK7PpYlj1rYNIjIkVFKvo2", in __cache_UK7PpYlj1rYNIjIkVFKvo2), n1.CompilationHelper.GetValueOrExisting(values, "__p_MioGnh8VcVQMBQvGzrZ1ys", in __p_MioGnh8VcVQMBQvGzrZ1ys));
        }

        internal PlayerSyncServer_C __WITH__(double __slot_U7y8MmQqyGZOPhXiqao68X, double __slot_GmUc0xRrS3YLP6WrHhlcED, n5.IPEndPoint __slot_EzqOB64xctAPvuUy3uhI8g, n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_TJwJhpzVMk5PhHpHHWoc3p, n7.UDPSocket __p_TN27FUdFUlYO9ZBdtCkYLa, n8.HoldLatest<n7.Datagram> __p_ANYUCrsAoLYMTcwMKvWmSB, n7.DatagramReceiver __p_BRVXKU1S8dWOCX8iGmLKh4, n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> __p_SzYfFdZAzkMPOMfJqNrXMt, n8.ForEachKeep<n3.Object, n7.Datagram, n5.IPEndPoint> __p_K8gvOalPgl1NSxjLLZxZoq, n8.HoldLatest<n5.IPEndPoint> __p_D6icpOSbPRiPQ2O33LhCtk, n6.Manager<n3.ValueTuple<float, float, bool, float, bool, bool, float>, n3.ValueTuple> __cache_UK7PpYlj1rYNIjIkVFKvo2, n7.DatagramSender __p_MioGnh8VcVQMBQvGzrZ1ys)
        {
            n2.PlayerSyncServer_C that_0 = this;
            this.__slot_U7y8MmQqyGZOPhXiqao68X = __slot_U7y8MmQqyGZOPhXiqao68X;
            this.__slot_GmUc0xRrS3YLP6WrHhlcED = __slot_GmUc0xRrS3YLP6WrHhlcED;
            this.__slot_EzqOB64xctAPvuUy3uhI8g = __slot_EzqOB64xctAPvuUy3uhI8g;
            this.__cache_TJwJhpzVMk5PhHpHHWoc3p = __cache_TJwJhpzVMk5PhHpHHWoc3p;
            this.__p_TN27FUdFUlYO9ZBdtCkYLa = __p_TN27FUdFUlYO9ZBdtCkYLa;
            this.__p_ANYUCrsAoLYMTcwMKvWmSB = __p_ANYUCrsAoLYMTcwMKvWmSB;
            this.__p_BRVXKU1S8dWOCX8iGmLKh4 = __p_BRVXKU1S8dWOCX8iGmLKh4;
            this.__p_SzYfFdZAzkMPOMfJqNrXMt = __p_SzYfFdZAzkMPOMfJqNrXMt;
            this.__p_K8gvOalPgl1NSxjLLZxZoq = __p_K8gvOalPgl1NSxjLLZxZoq;
            this.__p_D6icpOSbPRiPQ2O33LhCtk = __p_D6icpOSbPRiPQ2O33LhCtk;
            this.__cache_UK7PpYlj1rYNIjIkVFKvo2 = __cache_UK7PpYlj1rYNIjIkVFKvo2;
            this.__p_MioGnh8VcVQMBQvGzrZ1ys = __p_MioGnh8VcVQMBQvGzrZ1ys;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "I985T0yioHiQV5rFANiUXd", Name = "__I985T0yioHiQV5rFANiUXd")]
        [n3.SerializableAttribute]
        public class __I985T0yioHiQV5rFANiUXd : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __I985T0yioHiQV5rFANiUXd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __I985T0yioHiQV5rFANiUXd(__I985T0yioHiQV5rFANiUXd other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __I985T0yioHiQV5rFANiUXd __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BXZLaBtOYblP0oiukPInYF", Name = "__BXZLaBtOYblP0oiukPInYF")]
        [n3.SerializableAttribute]
        public class __BXZLaBtOYblP0oiukPInYF : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_OiiRMjJtI5NM2vA2m1d84t);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n3.Object __if_OiiRMjJtI5NM2vA2m1d84t;
            public __BXZLaBtOYblP0oiukPInYF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BXZLaBtOYblP0oiukPInYF(__BXZLaBtOYblP0oiukPInYF other): base(other)
            {
                this.__if_OiiRMjJtI5NM2vA2m1d84t = other.__if_OiiRMjJtI5NM2vA2m1d84t;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_OiiRMjJtI5NM2vA2m1d84t", in __if_OiiRMjJtI5NM2vA2m1d84t));
            }

            internal __BXZLaBtOYblP0oiukPInYF __WITH__(n3.Object __if_OiiRMjJtI5NM2vA2m1d84t)
            {
                __BXZLaBtOYblP0oiukPInYF that_0 = this;
                this.__if_OiiRMjJtI5NM2vA2m1d84t = __if_OiiRMjJtI5NM2vA2m1d84t;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Qmc3ekDAJm5MCcgunlunv9", Name = "__Qmc3ekDAJm5MCcgunlunv9")]
        [n3.SerializableAttribute]
        public class __Qmc3ekDAJm5MCcgunlunv9 : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PmPCuCUctMTLWsUg2a8HoQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 261223U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PmPCuCUctMTLWsUg2a8HoQ", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
            public n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_PmPCuCUctMTLWsUg2a8HoQ;
            public __Qmc3ekDAJm5MCcgunlunv9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Qmc3ekDAJm5MCcgunlunv9(__Qmc3ekDAJm5MCcgunlunv9 other): base(other)
            {
                this.__p_PmPCuCUctMTLWsUg2a8HoQ = other.__p_PmPCuCUctMTLWsUg2a8HoQ;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PmPCuCUctMTLWsUg2a8HoQ", in __p_PmPCuCUctMTLWsUg2a8HoQ));
            }

            internal __Qmc3ekDAJm5MCcgunlunv9 __WITH__(n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_PmPCuCUctMTLWsUg2a8HoQ)
            {
                __Qmc3ekDAJm5MCcgunlunv9 that_0 = this;
                this.__p_PmPCuCUctMTLWsUg2a8HoQ = __p_PmPCuCUctMTLWsUg2a8HoQ;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "O48LvNVjzn4QPBfZ50siXO", Name = "__O48LvNVjzn4QPBfZ50siXO")]
        [n3.SerializableAttribute]
        public class __O48LvNVjzn4QPBfZ50siXO : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TYmFojJP1NZNdeDi2M7jRl);
                n1.CompilationHelper.SafeDispose(this.__p_ANOPJCiSuvWLx22OgKnDnB);
                n1.CompilationHelper.SafeDispose(this.__p_InlZumDWfEWQTCPRXd6Nz1);
                return;
            }

            [n1.ElementAttribute(TracingId = 261038U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TYmFojJP1NZNdeDi2M7jRl", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
            public n7.DatagramSender __p_TYmFojJP1NZNdeDi2M7jRl;
            [n1.ElementAttribute(TracingId = 261042U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ANOPJCiSuvWLx22OgKnDnB", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
            public n8.ToObservable<n7.Datagram> __p_ANOPJCiSuvWLx22OgKnDnB;
            [n1.ElementAttribute(TracingId = 261102U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "InlZumDWfEWQTCPRXd6Nz1", Name = "Counter", IsManaged = true, IsAutoGenerated = true)]
            public n23.Counter_UIay2coHW4dO2NuoNnTZ3G __p_InlZumDWfEWQTCPRXd6Nz1;
            public __O48LvNVjzn4QPBfZ50siXO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O48LvNVjzn4QPBfZ50siXO(__O48LvNVjzn4QPBfZ50siXO other): base(other)
            {
                this.__p_TYmFojJP1NZNdeDi2M7jRl = other.__p_TYmFojJP1NZNdeDi2M7jRl;
                this.__p_ANOPJCiSuvWLx22OgKnDnB = other.__p_ANOPJCiSuvWLx22OgKnDnB;
                this.__p_InlZumDWfEWQTCPRXd6Nz1 = other.__p_InlZumDWfEWQTCPRXd6Nz1;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TYmFojJP1NZNdeDi2M7jRl", in __p_TYmFojJP1NZNdeDi2M7jRl), n1.CompilationHelper.GetValueOrExisting(values, "__p_ANOPJCiSuvWLx22OgKnDnB", in __p_ANOPJCiSuvWLx22OgKnDnB), n1.CompilationHelper.GetValueOrExisting(values, "__p_InlZumDWfEWQTCPRXd6Nz1", in __p_InlZumDWfEWQTCPRXd6Nz1));
            }

            internal __O48LvNVjzn4QPBfZ50siXO __WITH__(n7.DatagramSender __p_TYmFojJP1NZNdeDi2M7jRl, n8.ToObservable<n7.Datagram> __p_ANOPJCiSuvWLx22OgKnDnB, n23.Counter_UIay2coHW4dO2NuoNnTZ3G __p_InlZumDWfEWQTCPRXd6Nz1)
            {
                __O48LvNVjzn4QPBfZ50siXO that_0 = this;
                this.__p_TYmFojJP1NZNdeDi2M7jRl = __p_TYmFojJP1NZNdeDi2M7jRl;
                this.__p_ANOPJCiSuvWLx22OgKnDnB = __p_ANOPJCiSuvWLx22OgKnDnB;
                this.__p_InlZumDWfEWQTCPRXd6Nz1 = __p_InlZumDWfEWQTCPRXd6Nz1;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 261487U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EqvY1oEVb5uOjk3Xzzt2I2", Name = "PlayerSyncClient_C")]
    [n3.SerializableAttribute]
    public class PlayerSyncClient_C : n1.VLObject, n2.ITimeSync_I, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.PlayerSyncClient_C Create(n1.NodeContext Node_Context, n10.IFrameClock Frame_Clock_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new PlayerSyncClient_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Frame_Clock_In);
        }

        [n4.CreateDefaultAttribute]
        public static n2.PlayerSyncClient_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new PlayerSyncClient_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.PlayerSyncClient_C Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("6666", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Remote_Address_In, [n4.SerializedDefaultValueAttribute("6666", false)] int Remote_Port_In, double Constant_Offset_In, [n4.SerializedDefaultValueAttribute("0.25", false)] double Seek_Threshold_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Socket_is_Open_Out, out bool On_Data_Out)
        {
            n28.SyncClient __pad_C3H9EmmymVOOiRGxF30FaI_0 = this.__slot_C3H9EmmymVOOiRGxF30FaI;
            n10.IFrameClock __auto_1 = this.Frame_Clock;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_EVhewElqIGtMeyNSXDOoOV;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_5 = (Local_Address_In, Local_Port_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var Result_10 = n5.IPAddress.TryParse(ipString: Local_Address_In, address: out n5.IPAddress Address_9);
                var Output_11 = new n5.IPEndPoint(address: Address_9, port: Local_Port_In);
                outputs_6 = (Result_10, Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_12, __auto_13) = outputs_6;
            this.__cache_EVhewElqIGtMeyNSXDOoOV = manager_4;
            bool Force_14 = false;
            bool Dispose_Cached_Outputs_15 = false;
            var manager_16 = this.__cache_GKnauriGKdLQc5P7peXvHo;
            if (manager_16 is null)
            {
                manager_16 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_17 = (Remote_Address_In, Remote_Port_In);
            var outputs_18 = manager_16.Outputs;
            var Has_Changed_19 = Force_14 || manager_16.InputsChanged(inputs_17);
            if (Has_Changed_19)
            {
                if (Dispose_Cached_Outputs_15)
                    manager_16.DisposeOutputs();
                var state_20 = n1.CompilationHelper.Restore<__O2j8wXtjBWaLIvLh9tSl4E>(manager_16.State, __GetContext__());
                if (state_20 == null)
                {
                    state_20 = new __O2j8wXtjBWaLIvLh9tSl4E(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "GGgFqEk9MRdL2T33uqWD30", 261745U);
                    var Output_22 = n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_21);
                    state_20.__p_GGgFqEk9MRdL2T33uqWD30 = Output_22;
                }

                var Result_24 = n5.IPAddress.TryParse(ipString: Remote_Address_In, address: out n5.IPAddress Address_23);
                var State_Output_26 = state_20.__p_GGgFqEk9MRdL2T33uqWD30.Update(Address_In: Address_23, Port_In: Remote_Port_In, Output_Out: out n5.IPEndPoint Output_25);
                state_20.__p_GGgFqEk9MRdL2T33uqWD30 = State_Output_26;
                outputs_18 = (Result_24, Output_25);
                manager_16 = manager_16.Update(inputs_17, __GetContext__().IsImmutable, Dispose_Cached_Outputs_15, state_20, outputs_18);
            }
            else
            {
                manager_16.Update(inputs_17, __GetContext__().IsImmutable, Dispose_Cached_Outputs_15);
            }

            var(__auto_27, __auto_28) = outputs_18;
            this.__cache_GKnauriGKdLQc5P7peXvHo = manager_16;
            this.__slot_KX7TB1tvSCHPxZkF6kvp0v = Constant_Offset_In;
            double __pad_KX7TB1tvSCHPxZkF6kvp0v_29 = Constant_Offset_In;
            this.__slot_RwQ9lSOtHAvNsr1bA7P41K = Seek_Threshold_In;
            double __pad_RwQ9lSOtHAvNsr1bA7P41K_30 = Seek_Threshold_In;
            this.Enabled = Enabled_In;
            bool __auto_31 = Enabled_In;
            bool Bind_32 = true;
            n7.UDPSocket Input_33 = this.__p_OBoq3u4aSiUPs8nYmwJl45;
            var Result_34 = Input_33.Update(localEndPoint: __auto_13, bind: Bind_32);
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = Input_33;
            var Is_Open_35 = Input_33.IsOpen;
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = Input_33;
            bool SetEnabled_36 = true;
            var Output_37 = Input_33;
            if (SetEnabled_36)
            {
                Input_33.Enabled = Enabled_In;
                Output_37 = Input_33;
            }

            this.__p_OBoq3u4aSiUPs8nYmwJl45 = Output_37;
            var Output_38 = __auto_12 && Enabled_In;
            var Output_39 = Output_38 && __auto_27;
            int Index_40 = n3.Convert.ToInt32(Output_39);
            double Value_41 = 0.5;
            var Result_42 = n3.TimeSpan.FromSeconds(value: Value_41);
            var Output_45 = this.__p_LFgviQmeKCvOnEnh0Rc5H5.Update(Period_In: Result_42, Result_Out: out n3.IObservable<long> Result_43, Changed_Out: out bool Changed_44);
            this.__p_LFgviQmeKCvOnEnh0Rc5H5 = Output_45;
            n3.IObservable<long> Input_46 = n29._Operations_.CreateDefault<long>();
            var builder_47 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4, 2);
            builder_47.Add(Input_46);
            builder_47.Add(Result_43);
            var __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4_48 = builder_47.Commit();
            this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4_48;
            n31._Operations_.Switch<n3.IObservable<long>, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_40, Input_In: __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4_48, Output_Out: out n3.IObservable<long> Output_49);
            bool Reset_50 = false;
            var __fallback___51 = n1.ServiceRegistry.Current;
            n16._Operations_.Update_H<n3.Object, long, n7.Datagram>(Input_In: this.__p_Qrk7VQwvA1sQaunPyIbvpJ, Messages_In: Output_49, Reset_In: Reset_50, Update_In: (n3.Object s_54, long Input_1_In_55) =>
            {
                using var __current_52 = __fallback___51.MakeCurrentIfNone();
                var state_53 = n1.CompilationHelper.Restore<__HbJndo9kiV3MHEDHLbbHRP>(s_54, __GetContext__());
                string __pad_F4G5iCO9Vd7Nnnzw9lmsql_56 = __slot_F4G5iCO9Vd7Nnnzw9lmsql;
                n33.Encodings Encoding_57 = n32._Operations_.CreateDefault();
                var Result_58 = n19.StringExtensions.ToBytes(input: __pad_F4G5iCO9Vd7Nnnzw9lmsql_56, encoding: Encoding_57);
                n11.IEnumerable<byte> Input_59 = (n11.IEnumerable<byte>)Result_58;
                n14._Operations_.FromSequence<byte>(Input_In: Input_59, Result_Out: out n13.Spread<byte> Result_60);
                n1.NodeContext Node_Context_61 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "O7i7mNXf3bRPQsdT5sHkAj", 261534U);
                n15._Operations_.Create(Node_Context: Node_Context_61, Remote_End_Point_In: __auto_28, Payload_In: Result_60, Output_Out: out n7.Datagram Output_62);
                return n3.Tuple.Create<n3.Object, n7.Datagram>(state_53, Output_62);
            }

            , Create_In: () =>
            {
                using var __current_63 = __fallback___51.MakeCurrentIfNone();
                var state_53 = new __HbJndo9kiV3MHEDHLbbHRP(__GetContext__(), n1.VLObject.NewIdentity());
                return state_53;
            }

            , Output_Out: out n8.ForEach<n3.Object, long, n7.Datagram> Output_64, Result_Out: out n3.IObservable<n7.Datagram> Result_65);
            this.__p_Qrk7VQwvA1sQaunPyIbvpJ = Output_64;
            bool Update_66 = true;
            var Output_67 = this.__p_VffA2Rc88ttNATksQWSy7z;
            if (Update_66)
            {
                n7.DatagramSender Input_68 = this.__p_VffA2Rc88ttNATksQWSy7z;
                Input_68.Update(localSocket: Result_34, datagrams: Result_65);
                Output_67 = Input_68;
            }

            this.__p_VffA2Rc88ttNATksQWSy7z = Output_67;
            n7.DatagramReceiver Input_69 = this.__p_HSpPxCBvij1NxEWpyeIxf2;
            var Datagrams_70 = Input_69.Datagrams;
            this.__p_HSpPxCBvij1NxEWpyeIxf2 = Input_69;
            bool Update_71 = true;
            var Output_72 = Input_69;
            if (Update_71)
            {
                Input_69.Update(localSocket: Result_34);
                Output_72 = Input_69;
            }

            this.__p_HSpPxCBvij1NxEWpyeIxf2 = Output_72;
            n10.IClock Input_73 = (n10.IClock)__auto_1;
            bool Reset_74 = false;
            n20._Operations_.Update_H<n3.Object, n7.Datagram, n28.SyncClient>(Input_In: this.__p_CQBVeLeGwFAMxnu8DGxqdC, Messages_In: Datagrams_70, Reset_In: Reset_74, Update_In: (n3.Object s_77, n7.Datagram Input_1_In_78) =>
            {
                using var __current_75 = __fallback___51.MakeCurrentIfNone();
                var state_76 = n1.CompilationHelper.Restore<__EzYaT81EXWuLxLEowg06zp>(s_77, __GetContext__());
                int __pad_RxfxkR6GNugPeAl7v2AzTi_79 = __slot_RxfxkR6GNugPeAl7v2AzTi;
                var Payload_Array_80 = Input_1_In_78.PayloadArray;
                n34._Operations_.Length<byte>(Input_In: Payload_Array_80, Output_Out: out byte[] Output_81, Length_Out: out int Length_82);
                var Result_83 = Length_82 == __pad_RxfxkR6GNugPeAl7v2AzTi_79;
                n28.SyncClient __auto_84;
                if (Result_83)
                {
                    var Result_86 = n10.Clocks.Seconds(clock: Input_73);
                    __pad_C3H9EmmymVOOiRGxF30FaI_0.ReceiveServerAnswer(data: Payload_Array_80, timeStamp: Result_86);
                    __auto_84 = __pad_C3H9EmmymVOOiRGxF30FaI_0;
                }
                else
                {
                    __auto_84 = default(n28.SyncClient);
                }

                return n3.Tuple.Create<n3.Object, n28.SyncClient, bool>(state_76, __auto_84, Result_83);
            }

            , Create_In: () =>
            {
                using var __current_87 = __fallback___51.MakeCurrentIfNone();
                var state_76 = new __EzYaT81EXWuLxLEowg06zp(__GetContext__(), n1.VLObject.NewIdentity());
                return state_76;
            }

            , Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n28.SyncClient> Output_88, Result_Out: out n3.IObservable<n28.SyncClient> Result_89);
            this.__p_CQBVeLeGwFAMxnu8DGxqdC = Output_88;
            bool Reset_90 = false;
            bool Update_91 = true;
            var Output_92 = this.__p_MIZdw7kSYllL7m7qxCS2wG;
            if (Update_91)
            {
                n9._Operations_.Update_H<n28.SyncClient>(Input_In: this.__p_MIZdw7kSYllL7m7qxCS2wG, Async_Notifications_In: Result_89, Reset_In: Reset_90, Output_Out: out Output_92);
            }

            this.__p_MIZdw7kSYllL7m7qxCS2wG = Output_92;
            n9._Operations_.GetData_H<n28.SyncClient>(Input_In: Output_92, Output_Out: out n8.HoldLatest<n28.SyncClient> Output_93, Value_Out: out n28.SyncClient Value_94, On_Data_Out: out bool On_Data_95);
            this.__p_MIZdw7kSYllL7m7qxCS2wG = Output_93;
            bool Reset_96 = false;
            n20._Operations_.Update_H<n3.Object, n7.Datagram, n2.PlayerController_R>(Input_In: this.__p_ArjHyxe6VACNlPl4InX6KN, Messages_In: Datagrams_70, Reset_In: Reset_96, Update_In: (n3.Object s_99, n7.Datagram Input_1_In_100) =>
            {
                using var __current_97 = __fallback___51.MakeCurrentIfNone();
                var state_98 = n1.CompilationHelper.Restore<__KvmDNZgBzcZL1tT9HftUrS>(s_99, __GetContext__());
                int __pad_DsxJYOr0eg5M2Z1sUMZtIH_101 = __slot_DsxJYOr0eg5M2Z1sUMZtIH;
                var Payload_Array_102 = Input_1_In_100.PayloadArray;
                n34._Operations_.Length<byte>(Input_In: Payload_Array_102, Output_Out: out byte[] Output_103, Length_Out: out int Length_104);
                var Result_105 = Length_104 > __pad_DsxJYOr0eg5M2Z1sUMZtIH_101;
                n2.PlayerController_R __auto_106;
                if (Result_105)
                {
                    bool Force_Little_Endian_108 = false;
                    n24._Operations_.Deserialize_Binary<n2.PlayerController_R>(Serialized_Value_In: Payload_Array_102, Force_Little_Endian_In: Force_Little_Endian_108, Result_Out: out n2.PlayerController_R Result_109);
                    __auto_106 = Result_109;
                }
                else
                {
                    __auto_106 = n2.PlayerController_R.CreateDefault();
                }

                return n3.Tuple.Create<n3.Object, n2.PlayerController_R, bool>(state_98, __auto_106, Result_105);
            }

            , Create_In: () =>
            {
                using var __current_110 = __fallback___51.MakeCurrentIfNone();
                var state_98 = new __KvmDNZgBzcZL1tT9HftUrS(__GetContext__(), n1.VLObject.NewIdentity());
                return state_98;
            }

            , Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n2.PlayerController_R> Output_111, Result_Out: out n3.IObservable<n2.PlayerController_R> Result_112);
            this.__p_ArjHyxe6VACNlPl4InX6KN = Output_111;
            bool Reset_113 = false;
            bool Update_114 = true;
            var Output_115 = this.__p_RoKYe6XCK3zPQ8bkheO0EU;
            if (Update_114)
            {
                n9._Operations_.Update_H<n2.PlayerController_R>(Input_In: this.__p_RoKYe6XCK3zPQ8bkheO0EU, Async_Notifications_In: Result_112, Reset_In: Reset_113, Output_Out: out Output_115);
            }

            this.__p_RoKYe6XCK3zPQ8bkheO0EU = Output_115;
            Socket_is_Open_Out = Is_Open_35;
            On_Data_Out = On_Data_95;
            return this;
        }

        public n2.PlayerSyncClient_C SetStreamTimesInternal(double Stream_Position_In, double Stream_Duration_In)
        {
            n28.SyncClient __pad_C3H9EmmymVOOiRGxF30FaI_0 = this.__slot_C3H9EmmymVOOiRGxF30FaI;
            n10.IFrameClock __auto_1 = this.Frame_Clock;
            double __pad_KX7TB1tvSCHPxZkF6kvp0v_2 = this.__slot_KX7TB1tvSCHPxZkF6kvp0v;
            double __pad_RwQ9lSOtHAvNsr1bA7P41K_3 = this.__slot_RwQ9lSOtHAvNsr1bA7P41K;
            n10.IClock Input_4 = (n10.IClock)__auto_1;
            var Result_5 = n10.Clocks.Seconds(clock: Input_4);
            __pad_C3H9EmmymVOOiRGxF30FaI_0.Update(timeStamp: Result_5, streamDuration: Stream_Duration_In, streamPosition: Stream_Position_In, constantOffset: __pad_KX7TB1tvSCHPxZkF6kvp0v_2, seekThreshold: __pad_RwQ9lSOtHAvNsr1bA7P41K_3, seekTime: out double Seek_Time_6, doSeek: out bool Do_Seek_7, adjustTime: out double Adjust_Time_8);
            this.__slot_GySP2V11PdEMbNEyh8XjmN = Seek_Time_6;
            double __pad_GySP2V11PdEMbNEyh8XjmN_9 = Seek_Time_6;
            this.__slot_ABw59oXvWyaOVV9bjbE072 = Do_Seek_7;
            bool __pad_ABw59oXvWyaOVV9bjbE072_10 = Do_Seek_7;
            this.__slot_SdXTUOieuv8MqLfz8K30dQ = Adjust_Time_8;
            double __pad_SdXTUOieuv8MqLfz8K30dQ_11 = Adjust_Time_8;
            return this;
        }

        public n2.PlayerSyncClient_C UpdateSync_(out float Seek_Time_Out, out bool Seek_Out, out double Adjust_Time_Out)
        {
            double __pad_GySP2V11PdEMbNEyh8XjmN_0 = this.__slot_GySP2V11PdEMbNEyh8XjmN;
            bool __pad_ABw59oXvWyaOVV9bjbE072_1 = this.__slot_ABw59oXvWyaOVV9bjbE072;
            double __pad_SdXTUOieuv8MqLfz8K30dQ_2 = this.__slot_SdXTUOieuv8MqLfz8K30dQ;
            var Result_3 = n19.IntegerConversions.ToFloat32(input: __pad_GySP2V11PdEMbNEyh8XjmN_0);
            Seek_Time_Out = Result_3;
            Seek_Out = __pad_ABw59oXvWyaOVV9bjbE072_1;
            Adjust_Time_Out = __pad_SdXTUOieuv8MqLfz8K30dQ_2;
            return this;
        }

        public n2.PlayerSyncClient_C SetTimes_(double Stream_Position_In, float Stream_Duration_In)
        {
            bool __auto_0 = this.Enabled;
            PlayerSyncClient_C Instance_1 = this;
            double Stream_Duration_2 = (double)Stream_Duration_In;
            var Output_3 = Instance_1;
            if (__auto_0)
            {
                Output_3 = Instance_1.SetStreamTimesInternal(Stream_Position_In: Stream_Position_In, Stream_Duration_In: Stream_Duration_2);
            }

            return this;
        }

        public n2.PlayerSyncClient_C SetClock_(n10.IFrameClock Frame_Clock_In)
        {
            this.Frame_Clock = Frame_Clock_In;
            n10.IFrameClock __auto_0 = Frame_Clock_In;
            return this;
        }

        public n2.PlayerSyncClient_C SyncControls_(float Loop_Start_Time_In, float Loop_End_Time_In, bool Loop_In, float Seek_Time_In, bool Seek_In, float Rate_In, bool Play_In, out float Loop_Start_Time_Out, out float Loop_End_Time_Out, out bool Loop_Out, out float Seek_Time_Out, out bool Seek_Out, out float Rate_Out, out bool Play_Out)
        {
            n9._Operations_.GetData_H<n2.PlayerController_R>(Input_In: this.__p_RoKYe6XCK3zPQ8bkheO0EU, Output_Out: out n8.HoldLatest<n2.PlayerController_R> Output_0, Value_Out: out n2.PlayerController_R Value_1, On_Data_Out: out bool On_Data_2);
            this.__p_RoKYe6XCK3zPQ8bkheO0EU = Output_0;
            var Output_10 = Value_1.Split(Loop_From_Out: out float Loop_From_3, Loop_To_Out: out float Loop_To_4, Loop_Out: out bool Loop_5, Seek_Time_Out: out float Seek_Time_6, Seek_Out: out int Seek_7, Rate_Out: out float Rate_8, Play_Out: out bool Play_9);
            var Output_13 = this.__p_SqKCpXdGnsIMgoWyB3SPxg.Update(Value_In: Seek_7, Result_Out: out bool Result_11, Unchanged_Out: out bool Unchanged_12);
            this.__p_SqKCpXdGnsIMgoWyB3SPxg = Output_13;
            Loop_Start_Time_Out = Loop_From_3;
            Loop_End_Time_Out = Loop_To_4;
            Loop_Out = Loop_5;
            Seek_Time_Out = Seek_Time_6;
            Seek_Out = Result_11;
            Rate_Out = Rate_8;
            Play_Out = Play_9;
            return this;
        }

        public n2.PlayerSyncClient_C __Create__(n1.NodeContext Node_Context, n10.IFrameClock Frame_Clock_In)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_C3H9EmmymVOOiRGxF30FaI = default(n28.SyncClient);
            this.__slot_KX7TB1tvSCHPxZkF6kvp0v = 0;
            this.__slot_RwQ9lSOtHAvNsr1bA7P41K = 0;
            this.__slot_GySP2V11PdEMbNEyh8XjmN = 0;
            this.__slot_ABw59oXvWyaOVV9bjbE072 = false;
            this.__slot_SdXTUOieuv8MqLfz8K30dQ = 0;
            this.Enabled = false;
            this.Frame_Clock = n35._Operations_.CreateDefault();
            this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = n14._Operations_.CreateDefault<n3.IObservable<long>>();
            this.Frame_Clock = Frame_Clock_In;
            n10.IFrameClock __auto_0 = Frame_Clock_In;
            var Output_1 = new n28.SyncClient();
            this.__slot_C3H9EmmymVOOiRGxF30FaI = Output_1;
            n28.SyncClient __pad_C3H9EmmymVOOiRGxF30FaI_2 = Output_1;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "LFgviQmeKCvOnEnh0Rc5H5", 261492U);
            var Output_4 = n36.Interval_H0f7FR6DlKkP89i5do6r8X.Create(Node_Context: Node_Context_3);
            this.__p_LFgviQmeKCvOnEnh0Rc5H5 = Output_4;
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Qrk7VQwvA1sQaunPyIbvpJ", 261508U);
            n16._Operations_.Create_H<n3.Object, long, n7.Datagram>(Node_Context: Node_Context_5, Output_Out: out n8.ForEach<n3.Object, long, n7.Datagram> Output_6);
            this.__p_Qrk7VQwvA1sQaunPyIbvpJ = Output_6;
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "OBoq3u4aSiUPs8nYmwJl45", 261653U);
            n26._Operations_.Create_H(Node_Context: Node_Context_7, Output_Out: out n7.UDPSocket Output_8);
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = Output_8;
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "VffA2Rc88ttNATksQWSy7z", 261760U);
            n21._Operations_.Create_H(Node_Context_In: Node_Context_9, Output_Out: out n7.DatagramSender Output_10);
            this.__p_VffA2Rc88ttNATksQWSy7z = Output_10;
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "MIZdw7kSYllL7m7qxCS2wG", 261776U);
            n28.SyncClient Initial_Result_12 = default(n28.SyncClient);
            n9._Operations_.Create_H<n28.SyncClient>(Node_Context: Node_Context_11, Initial_Result_In: Initial_Result_12, Output_Out: out n8.HoldLatest<n28.SyncClient> Output_13);
            this.__p_MIZdw7kSYllL7m7qxCS2wG = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "CQBVeLeGwFAMxnu8DGxqdC", 261800U);
            n20._Operations_.Create_H<n3.Object, n7.Datagram, n28.SyncClient>(Node_Context: Node_Context_14, Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n28.SyncClient> Output_15);
            this.__p_CQBVeLeGwFAMxnu8DGxqdC = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "HSpPxCBvij1NxEWpyeIxf2", 261873U);
            n27._Operations_.Create_H(Node_Context: Node_Context_16, Output_Out: out n7.DatagramReceiver Output_17);
            this.__p_HSpPxCBvij1NxEWpyeIxf2 = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "ArjHyxe6VACNlPl4InX6KN", 261883U);
            n20._Operations_.Create_H<n3.Object, n7.Datagram, n2.PlayerController_R>(Node_Context: Node_Context_18, Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n2.PlayerController_R> Output_19);
            this.__p_ArjHyxe6VACNlPl4InX6KN = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "RoKYe6XCK3zPQ8bkheO0EU", 261966U);
            n2.PlayerController_R Initial_Result_21 = n2.PlayerController_R.CreateDefault();
            n9._Operations_.Create_H<n2.PlayerController_R>(Node_Context: Node_Context_20, Initial_Result_In: Initial_Result_21, Output_Out: out n8.HoldLatest<n2.PlayerController_R> Output_22);
            this.__p_RoKYe6XCK3zPQ8bkheO0EU = Output_22;
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "SqKCpXdGnsIMgoWyB3SPxg", 261992U);
            bool Changed_On_Create_24 = true;
            var Output_25 = n31.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_23, Changed_On_Create_In: Changed_On_Create_24);
            this.__p_SqKCpXdGnsIMgoWyB3SPxg = Output_25;
            this.__cache_EVhewElqIGtMeyNSXDOoOV = null;
            this.__cache_GKnauriGKdLQc5P7peXvHo = null;
            this.__p_TBPosrcgTjmNLb5gNkwNmA = n37._Operations_.CreateDefault();
            return this;
        }

        public n2.PlayerSyncClient_C __CreateDefault__()
        {
            this.__slot_C3H9EmmymVOOiRGxF30FaI = default(n28.SyncClient);
            this.__slot_KX7TB1tvSCHPxZkF6kvp0v = 0;
            this.__slot_RwQ9lSOtHAvNsr1bA7P41K = 0;
            this.__slot_GySP2V11PdEMbNEyh8XjmN = 0;
            this.__slot_ABw59oXvWyaOVV9bjbE072 = false;
            this.__slot_SdXTUOieuv8MqLfz8K30dQ = 0;
            this.Enabled = false;
            this.Frame_Clock = n35._Operations_.CreateDefault();
            this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = n14._Operations_.CreateDefault<n3.IObservable<long>>();
            this.__cache_EVhewElqIGtMeyNSXDOoOV = null;
            this.__cache_GKnauriGKdLQc5P7peXvHo = null;
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = default(n7.UDPSocket);
            this.__p_LFgviQmeKCvOnEnh0Rc5H5 = n36.Interval_H0f7FR6DlKkP89i5do6r8X.CreateDefault();
            this.__p_Qrk7VQwvA1sQaunPyIbvpJ = default(n8.ForEach<n3.Object, long, n7.Datagram>);
            this.__p_VffA2Rc88ttNATksQWSy7z = default(n7.DatagramSender);
            this.__p_HSpPxCBvij1NxEWpyeIxf2 = default(n7.DatagramReceiver);
            this.__p_CQBVeLeGwFAMxnu8DGxqdC = default(n8.ForEachKeep<n3.Object, n7.Datagram, n28.SyncClient>);
            this.__p_MIZdw7kSYllL7m7qxCS2wG = default(n8.HoldLatest<n28.SyncClient>);
            this.__p_ArjHyxe6VACNlPl4InX6KN = default(n8.ForEachKeep<n3.Object, n7.Datagram, n2.PlayerController_R>);
            this.__p_RoKYe6XCK3zPQ8bkheO0EU = default(n8.HoldLatest<n2.PlayerController_R>);
            this.__p_TBPosrcgTjmNLb5gNkwNmA = n37._Operations_.CreateDefault();
            this.__p_SqKCpXdGnsIMgoWyB3SPxg = n31.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_EVhewElqIGtMeyNSXDOoOV);
            n1.CompilationHelper.SafeDispose(this.__cache_GKnauriGKdLQc5P7peXvHo);
            n1.CompilationHelper.SafeDispose(this.__p_OBoq3u4aSiUPs8nYmwJl45);
            n1.CompilationHelper.SafeDispose(this.__p_LFgviQmeKCvOnEnh0Rc5H5);
            n1.CompilationHelper.SafeDispose(this.__p_Qrk7VQwvA1sQaunPyIbvpJ);
            n1.CompilationHelper.SafeDispose(this.__p_VffA2Rc88ttNATksQWSy7z);
            n1.CompilationHelper.SafeDispose(this.__p_HSpPxCBvij1NxEWpyeIxf2);
            n1.CompilationHelper.SafeDispose(this.__p_CQBVeLeGwFAMxnu8DGxqdC);
            n1.CompilationHelper.SafeDispose(this.__p_MIZdw7kSYllL7m7qxCS2wG);
            n1.CompilationHelper.SafeDispose(this.__p_ArjHyxe6VACNlPl4InX6KN);
            n1.CompilationHelper.SafeDispose(this.__p_RoKYe6XCK3zPQ8bkheO0EU);
            n1.CompilationHelper.SafeDispose(this.__p_TBPosrcgTjmNLb5gNkwNmA);
            n1.CompilationHelper.SafeDispose(this.__p_SqKCpXdGnsIMgoWyB3SPxg);
            return;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SetTimes(double Stream_Position_In, float Stream_Duration_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetTimes_(Stream_Position_In, Stream_Duration_In);
            return __returnValue__;
        }

        n2.ITimeSync_I n2.ITimeSync_I.UpdateSync(out float Seek_Time_Out, out bool Seek_Out, out double Adjust_Time_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = UpdateSync_(out Seek_Time_Out, out Seek_Out, out Adjust_Time_Out);
            return __returnValue__;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SetClock(n10.IFrameClock Frame_Clock_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetClock_(Frame_Clock_In);
            return __returnValue__;
        }

        n2.ITimeSync_I n2.ITimeSync_I.SyncControls(float Loop_Start_Time_In, float Loop_End_Time_In, bool Loop_In, float Seek_Time_In, bool Seek_In, float Rate_In, bool Play_In, out float Loop_Start_Time_Out, out float Loop_End_Time_Out, out bool Loop_Out, out float Seek_Time_Out, out bool Seek_Out, out float Rate_Out, out bool Play_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SyncControls_(Loop_Start_Time_In, Loop_End_Time_In, Loop_In, Seek_Time_In, Seek_In, Rate_In, Play_In, out Loop_Start_Time_Out, out Loop_End_Time_Out, out Loop_Out, out Seek_Time_Out, out Seek_Out, out Rate_Out, out Play_Out);
            return __returnValue__;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 261561U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "C3H9EmmymVOOiRGxF30FaI", Name = "__slot_C3H9EmmymVOOiRGxF30FaI")]
        public n28.SyncClient __slot_C3H9EmmymVOOiRGxF30FaI;
        [n1.ElementAttribute(TracingId = 261601U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KX7TB1tvSCHPxZkF6kvp0v", Name = "__slot_KX7TB1tvSCHPxZkF6kvp0v")]
        public double __slot_KX7TB1tvSCHPxZkF6kvp0v;
        [n1.ElementAttribute(TracingId = 261602U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RwQ9lSOtHAvNsr1bA7P41K", Name = "__slot_RwQ9lSOtHAvNsr1bA7P41K")]
        public double __slot_RwQ9lSOtHAvNsr1bA7P41K;
        [n1.ElementAttribute(TracingId = 261603U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "GySP2V11PdEMbNEyh8XjmN", Name = "__slot_GySP2V11PdEMbNEyh8XjmN")]
        public double __slot_GySP2V11PdEMbNEyh8XjmN;
        [n1.ElementAttribute(TracingId = 261604U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ABw59oXvWyaOVV9bjbE072", Name = "__slot_ABw59oXvWyaOVV9bjbE072")]
        public bool __slot_ABw59oXvWyaOVV9bjbE072;
        [n1.ElementAttribute(TracingId = 261605U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SdXTUOieuv8MqLfz8K30dQ", Name = "__slot_SdXTUOieuv8MqLfz8K30dQ")]
        public double __slot_SdXTUOieuv8MqLfz8K30dQ;
        [n1.ElementAttribute(TracingId = 261788U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ErZagN54X4vOocYxfN6hJA", Name = "__slot_ErZagN54X4vOocYxfN6hJA")]
        public static string __slot_ErZagN54X4vOocYxfN6hJA = "1) Client sends a periodic ping to the server";
        [n1.ElementAttribute(TracingId = 261794U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "V0ShtAL3IOMLoSZ7VxdKqx", Name = "__slot_V0ShtAL3IOMLoSZ7VxdKqx")]
        public static string __slot_V0ShtAL3IOMLoSZ7VxdKqx = "3) Client receives back the time from the server and converges smoothly to the servers stream time";
        [n1.ElementAttribute(TracingId = 261879U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "J1xWaW7QmHSLKzStrypNQM", Name = "__slot_J1xWaW7QmHSLKzStrypNQM")]
        public static string __slot_J1xWaW7QmHSLKzStrypNQM = "2) Client receives control state (loop, play,..)";
        [n1.ElementAttribute(TracingId = 261635U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "P1VtYqFzKE2LNhARzjskhO", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 261639U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "UNiU6jzwAjAN9s0HGjQOXd", Name = "Frame Clock")]
        public n10.IFrameClock Frame_Clock;
        [n1.ElementAttribute(TracingId = 261665U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EVhewElqIGtMeyNSXDOoOV", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_EVhewElqIGtMeyNSXDOoOV = null;
        [n1.ElementAttribute(TracingId = 261723U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "GKnauriGKdLQc5P7peXvHo", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_GKnauriGKdLQc5P7peXvHo = null;
        [n1.ElementAttribute(TracingId = 261653U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "OBoq3u4aSiUPs8nYmwJl45", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n7.UDPSocket __p_OBoq3u4aSiUPs8nYmwJl45;
        [n1.ElementAttribute(TracingId = 261492U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LFgviQmeKCvOnEnh0Rc5H5", Name = "Interval", IsManaged = true, IsAutoGenerated = true)]
        public n36.Interval_H0f7FR6DlKkP89i5do6r8X __p_LFgviQmeKCvOnEnh0Rc5H5;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<n3.IObservable<long>> __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = default(n13.Spread<n3.IObservable<long>>);
        [n1.ElementAttribute(TracingId = 261508U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Qrk7VQwvA1sQaunPyIbvpJ", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEach<n3.Object, long, n7.Datagram> __p_Qrk7VQwvA1sQaunPyIbvpJ;
        [n1.ElementAttribute(TracingId = 261532U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "F4G5iCO9Vd7Nnnzw9lmsql", Name = "__slot_F4G5iCO9Vd7Nnnzw9lmsql")]
        public static string __slot_F4G5iCO9Vd7Nnnzw9lmsql = "sync";
        [n1.ElementAttribute(TracingId = 261760U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "VffA2Rc88ttNATksQWSy7z", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramSender __p_VffA2Rc88ttNATksQWSy7z;
        [n1.ElementAttribute(TracingId = 261873U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HSpPxCBvij1NxEWpyeIxf2", Name = "Receiver (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramReceiver __p_HSpPxCBvij1NxEWpyeIxf2;
        [n1.ElementAttribute(TracingId = 261800U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "CQBVeLeGwFAMxnu8DGxqdC", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEachKeep<n3.Object, n7.Datagram, n28.SyncClient> __p_CQBVeLeGwFAMxnu8DGxqdC;
        [n1.ElementAttribute(TracingId = 261842U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RxfxkR6GNugPeAl7v2AzTi", Name = "__slot_RxfxkR6GNugPeAl7v2AzTi")]
        public static int __slot_RxfxkR6GNugPeAl7v2AzTi = 16;
        [n1.ElementAttribute(TracingId = 261776U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "MIZdw7kSYllL7m7qxCS2wG", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<n28.SyncClient> __p_MIZdw7kSYllL7m7qxCS2wG;
        [n1.ElementAttribute(TracingId = 261883U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ArjHyxe6VACNlPl4InX6KN", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEachKeep<n3.Object, n7.Datagram, n2.PlayerController_R> __p_ArjHyxe6VACNlPl4InX6KN;
        [n1.ElementAttribute(TracingId = 261925U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DsxJYOr0eg5M2Z1sUMZtIH", Name = "__slot_DsxJYOr0eg5M2Z1sUMZtIH")]
        public static int __slot_DsxJYOr0eg5M2Z1sUMZtIH = 16;
        [n1.ElementAttribute(TracingId = 261966U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RoKYe6XCK3zPQ8bkheO0EU", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<n2.PlayerController_R> __p_RoKYe6XCK3zPQ8bkheO0EU;
        [n1.ElementAttribute(TracingId = 261610U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TBPosrcgTjmNLb5gNkwNmA", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __p_TBPosrcgTjmNLb5gNkwNmA;
        [n1.ElementAttribute(TracingId = 261992U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SqKCpXdGnsIMgoWyB3SPxg", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n31.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_SqKCpXdGnsIMgoWyB3SPxg;
        static PlayerSyncClient_C()
        {
        }

        public PlayerSyncClient_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PlayerSyncClient_C(PlayerSyncClient_C other): base(other)
        {
            this.__slot_C3H9EmmymVOOiRGxF30FaI = other.__slot_C3H9EmmymVOOiRGxF30FaI;
            this.__slot_KX7TB1tvSCHPxZkF6kvp0v = other.__slot_KX7TB1tvSCHPxZkF6kvp0v;
            this.__slot_RwQ9lSOtHAvNsr1bA7P41K = other.__slot_RwQ9lSOtHAvNsr1bA7P41K;
            this.__slot_GySP2V11PdEMbNEyh8XjmN = other.__slot_GySP2V11PdEMbNEyh8XjmN;
            this.__slot_ABw59oXvWyaOVV9bjbE072 = other.__slot_ABw59oXvWyaOVV9bjbE072;
            this.__slot_SdXTUOieuv8MqLfz8K30dQ = other.__slot_SdXTUOieuv8MqLfz8K30dQ;
            this.Enabled = other.Enabled;
            this.Frame_Clock = other.Frame_Clock;
            this.__cache_EVhewElqIGtMeyNSXDOoOV = other.__cache_EVhewElqIGtMeyNSXDOoOV;
            this.__cache_GKnauriGKdLQc5P7peXvHo = other.__cache_GKnauriGKdLQc5P7peXvHo;
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = other.__p_OBoq3u4aSiUPs8nYmwJl45;
            this.__p_LFgviQmeKCvOnEnh0Rc5H5 = other.__p_LFgviQmeKCvOnEnh0Rc5H5;
            this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = other.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4;
            this.__p_Qrk7VQwvA1sQaunPyIbvpJ = other.__p_Qrk7VQwvA1sQaunPyIbvpJ;
            this.__p_VffA2Rc88ttNATksQWSy7z = other.__p_VffA2Rc88ttNATksQWSy7z;
            this.__p_HSpPxCBvij1NxEWpyeIxf2 = other.__p_HSpPxCBvij1NxEWpyeIxf2;
            this.__p_CQBVeLeGwFAMxnu8DGxqdC = other.__p_CQBVeLeGwFAMxnu8DGxqdC;
            this.__p_MIZdw7kSYllL7m7qxCS2wG = other.__p_MIZdw7kSYllL7m7qxCS2wG;
            this.__p_ArjHyxe6VACNlPl4InX6KN = other.__p_ArjHyxe6VACNlPl4InX6KN;
            this.__p_RoKYe6XCK3zPQ8bkheO0EU = other.__p_RoKYe6XCK3zPQ8bkheO0EU;
            this.__p_TBPosrcgTjmNLb5gNkwNmA = other.__p_TBPosrcgTjmNLb5gNkwNmA;
            this.__p_SqKCpXdGnsIMgoWyB3SPxg = other.__p_SqKCpXdGnsIMgoWyB3SPxg;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_C3H9EmmymVOOiRGxF30FaI", in __slot_C3H9EmmymVOOiRGxF30FaI), n1.CompilationHelper.GetValueOrExisting(values, "__slot_KX7TB1tvSCHPxZkF6kvp0v", in __slot_KX7TB1tvSCHPxZkF6kvp0v), n1.CompilationHelper.GetValueOrExisting(values, "__slot_RwQ9lSOtHAvNsr1bA7P41K", in __slot_RwQ9lSOtHAvNsr1bA7P41K), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GySP2V11PdEMbNEyh8XjmN", in __slot_GySP2V11PdEMbNEyh8XjmN), n1.CompilationHelper.GetValueOrExisting(values, "__slot_ABw59oXvWyaOVV9bjbE072", in __slot_ABw59oXvWyaOVV9bjbE072), n1.CompilationHelper.GetValueOrExisting(values, "__slot_SdXTUOieuv8MqLfz8K30dQ", in __slot_SdXTUOieuv8MqLfz8K30dQ), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Frame_Clock", in Frame_Clock), n1.CompilationHelper.GetValueOrExisting(values, "__cache_EVhewElqIGtMeyNSXDOoOV", in __cache_EVhewElqIGtMeyNSXDOoOV), n1.CompilationHelper.GetValueOrExisting(values, "__cache_GKnauriGKdLQc5P7peXvHo", in __cache_GKnauriGKdLQc5P7peXvHo), n1.CompilationHelper.GetValueOrExisting(values, "__p_OBoq3u4aSiUPs8nYmwJl45", in __p_OBoq3u4aSiUPs8nYmwJl45), n1.CompilationHelper.GetValueOrExisting(values, "__p_LFgviQmeKCvOnEnh0Rc5H5", in __p_LFgviQmeKCvOnEnh0Rc5H5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4", in __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qrk7VQwvA1sQaunPyIbvpJ", in __p_Qrk7VQwvA1sQaunPyIbvpJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_VffA2Rc88ttNATksQWSy7z", in __p_VffA2Rc88ttNATksQWSy7z), n1.CompilationHelper.GetValueOrExisting(values, "__p_HSpPxCBvij1NxEWpyeIxf2", in __p_HSpPxCBvij1NxEWpyeIxf2), n1.CompilationHelper.GetValueOrExisting(values, "__p_CQBVeLeGwFAMxnu8DGxqdC", in __p_CQBVeLeGwFAMxnu8DGxqdC), n1.CompilationHelper.GetValueOrExisting(values, "__p_MIZdw7kSYllL7m7qxCS2wG", in __p_MIZdw7kSYllL7m7qxCS2wG), n1.CompilationHelper.GetValueOrExisting(values, "__p_ArjHyxe6VACNlPl4InX6KN", in __p_ArjHyxe6VACNlPl4InX6KN), n1.CompilationHelper.GetValueOrExisting(values, "__p_RoKYe6XCK3zPQ8bkheO0EU", in __p_RoKYe6XCK3zPQ8bkheO0EU), n1.CompilationHelper.GetValueOrExisting(values, "__p_TBPosrcgTjmNLb5gNkwNmA", in __p_TBPosrcgTjmNLb5gNkwNmA), n1.CompilationHelper.GetValueOrExisting(values, "__p_SqKCpXdGnsIMgoWyB3SPxg", in __p_SqKCpXdGnsIMgoWyB3SPxg));
        }

        internal PlayerSyncClient_C __WITH__(n28.SyncClient __slot_C3H9EmmymVOOiRGxF30FaI, double __slot_KX7TB1tvSCHPxZkF6kvp0v, double __slot_RwQ9lSOtHAvNsr1bA7P41K, double __slot_GySP2V11PdEMbNEyh8XjmN, bool __slot_ABw59oXvWyaOVV9bjbE072, double __slot_SdXTUOieuv8MqLfz8K30dQ, bool Enabled, n10.IFrameClock Frame_Clock, n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_EVhewElqIGtMeyNSXDOoOV, n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_GKnauriGKdLQc5P7peXvHo, n7.UDPSocket __p_OBoq3u4aSiUPs8nYmwJl45, n36.Interval_H0f7FR6DlKkP89i5do6r8X __p_LFgviQmeKCvOnEnh0Rc5H5, n13.Spread<n3.IObservable<long>> __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4, n8.ForEach<n3.Object, long, n7.Datagram> __p_Qrk7VQwvA1sQaunPyIbvpJ, n7.DatagramSender __p_VffA2Rc88ttNATksQWSy7z, n7.DatagramReceiver __p_HSpPxCBvij1NxEWpyeIxf2, n8.ForEachKeep<n3.Object, n7.Datagram, n28.SyncClient> __p_CQBVeLeGwFAMxnu8DGxqdC, n8.HoldLatest<n28.SyncClient> __p_MIZdw7kSYllL7m7qxCS2wG, n8.ForEachKeep<n3.Object, n7.Datagram, n2.PlayerController_R> __p_ArjHyxe6VACNlPl4InX6KN, n8.HoldLatest<n2.PlayerController_R> __p_RoKYe6XCK3zPQ8bkheO0EU, n3.Object __p_TBPosrcgTjmNLb5gNkwNmA, n31.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_SqKCpXdGnsIMgoWyB3SPxg)
        {
            n2.PlayerSyncClient_C that_0 = this;
            this.__slot_C3H9EmmymVOOiRGxF30FaI = __slot_C3H9EmmymVOOiRGxF30FaI;
            this.__slot_KX7TB1tvSCHPxZkF6kvp0v = __slot_KX7TB1tvSCHPxZkF6kvp0v;
            this.__slot_RwQ9lSOtHAvNsr1bA7P41K = __slot_RwQ9lSOtHAvNsr1bA7P41K;
            this.__slot_GySP2V11PdEMbNEyh8XjmN = __slot_GySP2V11PdEMbNEyh8XjmN;
            this.__slot_ABw59oXvWyaOVV9bjbE072 = __slot_ABw59oXvWyaOVV9bjbE072;
            this.__slot_SdXTUOieuv8MqLfz8K30dQ = __slot_SdXTUOieuv8MqLfz8K30dQ;
            this.Enabled = Enabled;
            this.Frame_Clock = Frame_Clock;
            this.__cache_EVhewElqIGtMeyNSXDOoOV = __cache_EVhewElqIGtMeyNSXDOoOV;
            this.__cache_GKnauriGKdLQc5P7peXvHo = __cache_GKnauriGKdLQc5P7peXvHo;
            this.__p_OBoq3u4aSiUPs8nYmwJl45 = __p_OBoq3u4aSiUPs8nYmwJl45;
            this.__p_LFgviQmeKCvOnEnh0Rc5H5 = __p_LFgviQmeKCvOnEnh0Rc5H5;
            this.__pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4 = __pin_group_Input_In_I5hDyMse6EVLTdNMutGFj4;
            this.__p_Qrk7VQwvA1sQaunPyIbvpJ = __p_Qrk7VQwvA1sQaunPyIbvpJ;
            this.__p_VffA2Rc88ttNATksQWSy7z = __p_VffA2Rc88ttNATksQWSy7z;
            this.__p_HSpPxCBvij1NxEWpyeIxf2 = __p_HSpPxCBvij1NxEWpyeIxf2;
            this.__p_CQBVeLeGwFAMxnu8DGxqdC = __p_CQBVeLeGwFAMxnu8DGxqdC;
            this.__p_MIZdw7kSYllL7m7qxCS2wG = __p_MIZdw7kSYllL7m7qxCS2wG;
            this.__p_ArjHyxe6VACNlPl4InX6KN = __p_ArjHyxe6VACNlPl4InX6KN;
            this.__p_RoKYe6XCK3zPQ8bkheO0EU = __p_RoKYe6XCK3zPQ8bkheO0EU;
            this.__p_TBPosrcgTjmNLb5gNkwNmA = __p_TBPosrcgTjmNLb5gNkwNmA;
            this.__p_SqKCpXdGnsIMgoWyB3SPxg = __p_SqKCpXdGnsIMgoWyB3SPxg;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "O2j8wXtjBWaLIvLh9tSl4E", Name = "__O2j8wXtjBWaLIvLh9tSl4E")]
        [n3.SerializableAttribute]
        public class __O2j8wXtjBWaLIvLh9tSl4E : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_GGgFqEk9MRdL2T33uqWD30);
                return;
            }

            [n1.ElementAttribute(TracingId = 261745U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "GGgFqEk9MRdL2T33uqWD30", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
            public n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_GGgFqEk9MRdL2T33uqWD30;
            public __O2j8wXtjBWaLIvLh9tSl4E(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O2j8wXtjBWaLIvLh9tSl4E(__O2j8wXtjBWaLIvLh9tSl4E other): base(other)
            {
                this.__p_GGgFqEk9MRdL2T33uqWD30 = other.__p_GGgFqEk9MRdL2T33uqWD30;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GGgFqEk9MRdL2T33uqWD30", in __p_GGgFqEk9MRdL2T33uqWD30));
            }

            internal __O2j8wXtjBWaLIvLh9tSl4E __WITH__(n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_GGgFqEk9MRdL2T33uqWD30)
            {
                __O2j8wXtjBWaLIvLh9tSl4E that_0 = this;
                this.__p_GGgFqEk9MRdL2T33uqWD30 = __p_GGgFqEk9MRdL2T33uqWD30;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HbJndo9kiV3MHEDHLbbHRP", Name = "__HbJndo9kiV3MHEDHLbbHRP")]
        [n3.SerializableAttribute]
        public class __HbJndo9kiV3MHEDHLbbHRP : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __HbJndo9kiV3MHEDHLbbHRP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HbJndo9kiV3MHEDHLbbHRP(__HbJndo9kiV3MHEDHLbbHRP other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __HbJndo9kiV3MHEDHLbbHRP __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EzYaT81EXWuLxLEowg06zp", Name = "__EzYaT81EXWuLxLEowg06zp")]
        [n3.SerializableAttribute]
        public class __EzYaT81EXWuLxLEowg06zp : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __EzYaT81EXWuLxLEowg06zp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EzYaT81EXWuLxLEowg06zp(__EzYaT81EXWuLxLEowg06zp other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __EzYaT81EXWuLxLEowg06zp __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KvmDNZgBzcZL1tT9HftUrS", Name = "__KvmDNZgBzcZL1tT9HftUrS")]
        [n3.SerializableAttribute]
        public class __KvmDNZgBzcZL1tT9HftUrS : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __KvmDNZgBzcZL1tT9HftUrS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KvmDNZgBzcZL1tT9HftUrS(__KvmDNZgBzcZL1tT9HftUrS other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __KvmDNZgBzcZL1tT9HftUrS __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 262294U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "V37J7IPF2JyL4LdTNQvW1o", Name = "ITimeSync_I")]
    public interface ITimeSync_I : n1.IVLObject
    {
        public n2.ITimeSync_I SetTimes(double Stream_Position_In, float Stream_Duration_In);
        public n2.ITimeSync_I UpdateSync(out float Seek_Time_Out, out bool Seek_Out, out double Adjust_Time_Out);
        public n2.ITimeSync_I SetClock(n10.IFrameClock Frame_Clock_In);
        public n2.ITimeSync_I SyncControls(float Loop_Start_Time_In, float Loop_End_Time_In, bool Loop_In, float Seek_Time_In, bool Seek_In, float Rate_In, bool Play_In, out float Loop_Start_Time_Out, out float Loop_End_Time_Out, out bool Loop_Out, out float Seek_Time_Out, out bool Seek_Out, out float Rate_Out, out bool Play_Out);
    }

    [n1.ElementAttribute(TracingId = 262487U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "CUiB12ZYuLcLxCmY1NIxUV", Name = "ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV")]
    [n3.SerializableAttribute]
    public class ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV Create(n1.NodeContext Node_Context)
        {
            var instance = new ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV CreateDefault()
        {
            var instance = new ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("5555", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Socket_is_Open_Out, out bool On_Data_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_RRLfCJOOIklLPQTPGVL7Vc;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_3 = (Local_Address_In, Local_Port_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Result_8 = n5.IPAddress.TryParse(ipString: Local_Address_In, address: out n5.IPAddress Address_7);
                var Output_9 = new n5.IPEndPoint(address: Address_7, port: Local_Port_In);
                outputs_4 = (Result_8, Output_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_10, __auto_11) = outputs_4;
            var Output_12 = __auto_10 && Enabled_In;
            bool Bind_13 = true;
            n7.UDPSocket Input_14 = this.__p_K0sAeY1vCtFOVDMUwmIzBf;
            var Result_15 = Input_14.Update(localEndPoint: __auto_11, bind: Bind_13);
            var Is_Open_16 = Input_14.IsOpen;
            bool SetEnabled_17 = true;
            var Output_18 = Input_14;
            if (SetEnabled_17)
            {
                Input_14.Enabled = Output_12;
                Output_18 = Input_14;
            }

            n7.DatagramReceiver Input_19 = this.__p_MzoPcL7cPhlLBpuoxBFDso;
            var Datagrams_20 = Input_19.Datagrams;
            bool Reset_21 = false;
            var __fallback___22 = n1.ServiceRegistry.Current;
            n16._Operations_.Update_H<n3.Object, n7.Datagram, n7.Datagram>(Input_In: this.__p_TgR4gj3uj2OQSTesEebHoL, Messages_In: Datagrams_20, Reset_In: Reset_21, Update_In: (n3.Object s_25, n7.Datagram Input_1_In_26) =>
            {
                using var __current_23 = __fallback___22.MakeCurrentIfNone();
                var state_24 = n1.CompilationHelper.Restore<__RWjRX0hiW2eOrnvcbr8zYQ>(s_25, __GetContext__());
                var Remote_End_Point_27 = Input_1_In_26.RemoteEndPoint;
                var Current_Time_28 = n10.Clocks.CurrentTime;
                var Seconds_29 = Current_Time_28.Seconds;
                var Result_30 = n3.BitConverter.GetBytes(value: Seconds_29);
                n11.IEnumerable<byte> Input_31 = (n11.IEnumerable<byte>)Result_30;
                n14._Operations_.FromSequence<byte>(Input_In: Input_31, Result_Out: out n13.Spread<byte> Result_32);
                n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "AwKHwTd71WELSGpMJGSjrN", 262538U);
                n15._Operations_.Create(Node_Context: Node_Context_33, Remote_End_Point_In: Remote_End_Point_27, Payload_In: Result_32, Output_Out: out n7.Datagram Output_34);
                return n3.Tuple.Create<n3.Object, n7.Datagram>(state_24, Output_34);
            }

            , Create_In: () =>
            {
                using var __current_35 = __fallback___22.MakeCurrentIfNone();
                var state_24 = new __RWjRX0hiW2eOrnvcbr8zYQ(__GetContext__(), n1.VLObject.NewIdentity());
                return state_24;
            }

            , Output_Out: out n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> Output_36, Result_Out: out n3.IObservable<n7.Datagram> Result_37);
            bool Reset_38 = false;
            bool Update_39 = true;
            var Output_40 = this.__p_Fs96ljQ5kCiPgp9LSJqj8e;
            if (Update_39)
            {
                n9._Operations_.Update_H<n7.Datagram>(Input_In: this.__p_Fs96ljQ5kCiPgp9LSJqj8e, Async_Notifications_In: Result_37, Reset_In: Reset_38, Output_Out: out Output_40);
            }

            n9._Operations_.GetData_H<n7.Datagram>(Input_In: Output_40, Output_Out: out n8.HoldLatest<n7.Datagram> Output_41, Value_Out: out n7.Datagram Value_42, On_Data_Out: out bool On_Data_43);
            bool Update_44 = true;
            var Output_45 = Input_19;
            if (Update_44)
            {
                Input_19.Update(localSocket: Result_15);
                Output_45 = Input_19;
            }

            bool Update_46 = true;
            var Output_47 = this.__p_OY4secphKbTMxeG7VTsh4C;
            if (Update_46)
            {
                n7.DatagramSender Input_48 = this.__p_OY4secphKbTMxeG7VTsh4C;
                Input_48.Update(localSocket: Result_15, datagrams: Result_37);
                Output_47 = Input_48;
            }

            Socket_is_Open_Out = Is_Open_16;
            On_Data_Out = On_Data_43;
            n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = manager_2 != this.__cache_RRLfCJOOIklLPQTPGVL7Vc || Output_18 != this.__p_K0sAeY1vCtFOVDMUwmIzBf || Output_45 != this.__p_MzoPcL7cPhlLBpuoxBFDso || Output_36 != this.__p_TgR4gj3uj2OQSTesEebHoL || Output_41 != this.__p_Fs96ljQ5kCiPgp9LSJqj8e || Output_47 != this.__p_OY4secphKbTMxeG7VTsh4C ? new ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(this)
                {__cache_RRLfCJOOIklLPQTPGVL7Vc = manager_2, __p_K0sAeY1vCtFOVDMUwmIzBf = Output_18, __p_MzoPcL7cPhlLBpuoxBFDso = Output_45, __p_TgR4gj3uj2OQSTesEebHoL = Output_36, __p_Fs96ljQ5kCiPgp9LSJqj8e = Output_41, __p_OY4secphKbTMxeG7VTsh4C = Output_47} : that_49;
            else
            {
                this.__cache_RRLfCJOOIklLPQTPGVL7Vc = manager_2;
                this.__p_K0sAeY1vCtFOVDMUwmIzBf = Output_18;
                this.__p_MzoPcL7cPhlLBpuoxBFDso = Output_45;
                this.__p_TgR4gj3uj2OQSTesEebHoL = Output_36;
                this.__p_Fs96ljQ5kCiPgp9LSJqj8e = Output_41;
                this.__p_OY4secphKbTMxeG7VTsh4C = Output_47;
            }

            return that_49;
        }

        public n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "TgR4gj3uj2OQSTesEebHoL", 262492U);
            n16._Operations_.Create_H<n3.Object, n7.Datagram, n7.Datagram>(Node_Context: Node_Context_0, Output_Out: out n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Fs96ljQ5kCiPgp9LSJqj8e", 262568U);
            n7.Datagram Initial_Result_3 = default(n7.Datagram);
            n9._Operations_.Create_H<n7.Datagram>(Node_Context: Node_Context_2, Initial_Result_In: Initial_Result_3, Output_Out: out n8.HoldLatest<n7.Datagram> Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "K0sAeY1vCtFOVDMUwmIzBf", 262582U);
            n26._Operations_.Create_H(Node_Context: Node_Context_5, Output_Out: out n7.UDPSocket Output_6);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "MzoPcL7cPhlLBpuoxBFDso", 262633U);
            n27._Operations_.Create_H(Node_Context: Node_Context_7, Output_Out: out n7.DatagramReceiver Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "OY4secphKbTMxeG7VTsh4C", 262639U);
            n21._Operations_.Create_H(Node_Context_In: Node_Context_9, Output_Out: out n7.DatagramSender Output_10);
            n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV that_11 = this;
            this.__p_TgR4gj3uj2OQSTesEebHoL = Output_1;
            this.__p_Fs96ljQ5kCiPgp9LSJqj8e = Output_4;
            this.__p_K0sAeY1vCtFOVDMUwmIzBf = Output_6;
            this.__p_MzoPcL7cPhlLBpuoxBFDso = Output_8;
            this.__p_OY4secphKbTMxeG7VTsh4C = Output_10;
            this.__cache_RRLfCJOOIklLPQTPGVL7Vc = null;
            return that_11;
        }

        public n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV __CreateDefault__()
        {
            n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV that_0 = this;
            this.__cache_RRLfCJOOIklLPQTPGVL7Vc = null;
            this.__p_K0sAeY1vCtFOVDMUwmIzBf = default(n7.UDPSocket);
            this.__p_MzoPcL7cPhlLBpuoxBFDso = default(n7.DatagramReceiver);
            this.__p_TgR4gj3uj2OQSTesEebHoL = default(n8.ForEach<n3.Object, n7.Datagram, n7.Datagram>);
            this.__p_Fs96ljQ5kCiPgp9LSJqj8e = default(n8.HoldLatest<n7.Datagram>);
            this.__p_OY4secphKbTMxeG7VTsh4C = default(n7.DatagramSender);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RRLfCJOOIklLPQTPGVL7Vc);
            n1.CompilationHelper.SafeDispose(this.__p_K0sAeY1vCtFOVDMUwmIzBf);
            n1.CompilationHelper.SafeDispose(this.__p_MzoPcL7cPhlLBpuoxBFDso);
            n1.CompilationHelper.SafeDispose(this.__p_TgR4gj3uj2OQSTesEebHoL);
            n1.CompilationHelper.SafeDispose(this.__p_Fs96ljQ5kCiPgp9LSJqj8e);
            n1.CompilationHelper.SafeDispose(this.__p_OY4secphKbTMxeG7VTsh4C);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 262562U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "IJjUbowUyu5NRPmaXtN6qD", Name = "__slot_IJjUbowUyu5NRPmaXtN6qD")]
        public static string __slot_IJjUbowUyu5NRPmaXtN6qD = "Server receives periodic ping from clients and responds with its own time";
        [n1.ElementAttribute(TracingId = 262595U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RRLfCJOOIklLPQTPGVL7Vc", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_RRLfCJOOIklLPQTPGVL7Vc = null;
        [n1.ElementAttribute(TracingId = 262582U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "K0sAeY1vCtFOVDMUwmIzBf", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n7.UDPSocket __p_K0sAeY1vCtFOVDMUwmIzBf;
        [n1.ElementAttribute(TracingId = 262633U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "MzoPcL7cPhlLBpuoxBFDso", Name = "Receiver (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramReceiver __p_MzoPcL7cPhlLBpuoxBFDso;
        [n1.ElementAttribute(TracingId = 262492U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TgR4gj3uj2OQSTesEebHoL", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> __p_TgR4gj3uj2OQSTesEebHoL;
        [n1.ElementAttribute(TracingId = 262568U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Fs96ljQ5kCiPgp9LSJqj8e", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<n7.Datagram> __p_Fs96ljQ5kCiPgp9LSJqj8e;
        [n1.ElementAttribute(TracingId = 262639U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "OY4secphKbTMxeG7VTsh4C", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramSender __p_OY4secphKbTMxeG7VTsh4C;
        static ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV()
        {
        }

        public ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV other): base(other)
        {
            this.__cache_RRLfCJOOIklLPQTPGVL7Vc = other.__cache_RRLfCJOOIklLPQTPGVL7Vc;
            this.__p_K0sAeY1vCtFOVDMUwmIzBf = other.__p_K0sAeY1vCtFOVDMUwmIzBf;
            this.__p_MzoPcL7cPhlLBpuoxBFDso = other.__p_MzoPcL7cPhlLBpuoxBFDso;
            this.__p_TgR4gj3uj2OQSTesEebHoL = other.__p_TgR4gj3uj2OQSTesEebHoL;
            this.__p_Fs96ljQ5kCiPgp9LSJqj8e = other.__p_Fs96ljQ5kCiPgp9LSJqj8e;
            this.__p_OY4secphKbTMxeG7VTsh4C = other.__p_OY4secphKbTMxeG7VTsh4C;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RRLfCJOOIklLPQTPGVL7Vc", in __cache_RRLfCJOOIklLPQTPGVL7Vc), n1.CompilationHelper.GetValueOrExisting(values, "__p_K0sAeY1vCtFOVDMUwmIzBf", in __p_K0sAeY1vCtFOVDMUwmIzBf), n1.CompilationHelper.GetValueOrExisting(values, "__p_MzoPcL7cPhlLBpuoxBFDso", in __p_MzoPcL7cPhlLBpuoxBFDso), n1.CompilationHelper.GetValueOrExisting(values, "__p_TgR4gj3uj2OQSTesEebHoL", in __p_TgR4gj3uj2OQSTesEebHoL), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fs96ljQ5kCiPgp9LSJqj8e", in __p_Fs96ljQ5kCiPgp9LSJqj8e), n1.CompilationHelper.GetValueOrExisting(values, "__p_OY4secphKbTMxeG7VTsh4C", in __p_OY4secphKbTMxeG7VTsh4C));
        }

        internal ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV __WITH__(n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_RRLfCJOOIklLPQTPGVL7Vc, n7.UDPSocket __p_K0sAeY1vCtFOVDMUwmIzBf, n7.DatagramReceiver __p_MzoPcL7cPhlLBpuoxBFDso, n8.ForEach<n3.Object, n7.Datagram, n7.Datagram> __p_TgR4gj3uj2OQSTesEebHoL, n8.HoldLatest<n7.Datagram> __p_Fs96ljQ5kCiPgp9LSJqj8e, n7.DatagramSender __p_OY4secphKbTMxeG7VTsh4C)
        {
            n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RRLfCJOOIklLPQTPGVL7Vc != this.__cache_RRLfCJOOIklLPQTPGVL7Vc || __p_K0sAeY1vCtFOVDMUwmIzBf != this.__p_K0sAeY1vCtFOVDMUwmIzBf || __p_MzoPcL7cPhlLBpuoxBFDso != this.__p_MzoPcL7cPhlLBpuoxBFDso || __p_TgR4gj3uj2OQSTesEebHoL != this.__p_TgR4gj3uj2OQSTesEebHoL || __p_Fs96ljQ5kCiPgp9LSJqj8e != this.__p_Fs96ljQ5kCiPgp9LSJqj8e || __p_OY4secphKbTMxeG7VTsh4C != this.__p_OY4secphKbTMxeG7VTsh4C ? new ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV(this)
                {__cache_RRLfCJOOIklLPQTPGVL7Vc = __cache_RRLfCJOOIklLPQTPGVL7Vc, __p_K0sAeY1vCtFOVDMUwmIzBf = __p_K0sAeY1vCtFOVDMUwmIzBf, __p_MzoPcL7cPhlLBpuoxBFDso = __p_MzoPcL7cPhlLBpuoxBFDso, __p_TgR4gj3uj2OQSTesEebHoL = __p_TgR4gj3uj2OQSTesEebHoL, __p_Fs96ljQ5kCiPgp9LSJqj8e = __p_Fs96ljQ5kCiPgp9LSJqj8e, __p_OY4secphKbTMxeG7VTsh4C = __p_OY4secphKbTMxeG7VTsh4C} : that_0;
            else
            {
                this.__cache_RRLfCJOOIklLPQTPGVL7Vc = __cache_RRLfCJOOIklLPQTPGVL7Vc;
                this.__p_K0sAeY1vCtFOVDMUwmIzBf = __p_K0sAeY1vCtFOVDMUwmIzBf;
                this.__p_MzoPcL7cPhlLBpuoxBFDso = __p_MzoPcL7cPhlLBpuoxBFDso;
                this.__p_TgR4gj3uj2OQSTesEebHoL = __p_TgR4gj3uj2OQSTesEebHoL;
                this.__p_Fs96ljQ5kCiPgp9LSJqj8e = __p_Fs96ljQ5kCiPgp9LSJqj8e;
                this.__p_OY4secphKbTMxeG7VTsh4C = __p_OY4secphKbTMxeG7VTsh4C;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RWjRX0hiW2eOrnvcbr8zYQ", Name = "__RWjRX0hiW2eOrnvcbr8zYQ")]
        [n3.SerializableAttribute]
        public class __RWjRX0hiW2eOrnvcbr8zYQ : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __RWjRX0hiW2eOrnvcbr8zYQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RWjRX0hiW2eOrnvcbr8zYQ(__RWjRX0hiW2eOrnvcbr8zYQ other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __RWjRX0hiW2eOrnvcbr8zYQ __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 262725U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FV9G8MqDxrULfmNOmjxMHE", Name = "ClockSyncClient_C")]
    [n3.SerializableAttribute]
    public class ClockSyncClient_C : n1.VLObject, n10.IFrameClock, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.ClockSyncClient_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new ClockSyncClient_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.ClockSyncClient_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new ClockSyncClient_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.ClockSyncClient_C Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("5556", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Remote_Address_In, [n4.SerializedDefaultValueAttribute("5555", false)] int Remote_Port_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Sockets_is_Open_Out, out bool On_Data_Out)
        {
            n38.Reference_C<n10.Time> __pad_NgTv3jLtmKiQChrsNHOsUj_0 = this.__slot_NgTv3jLtmKiQChrsNHOsUj;
            n38.Reference_C<double> __pad_LemPeWlA1s9OF5fcIAYoTE_1 = this.__slot_LemPeWlA1s9OF5fcIAYoTE;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_KFyGo9BklBiPPDC3cCTogi;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_5 = (Local_Address_In, Local_Port_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__Q2eQoLCq7QGMdnFWWV1MGE>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __Q2eQoLCq7QGMdnFWWV1MGE(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "KEPkV4FqlnGOK5ik3Es2LN", 263248U);
                    var Output_10 = n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_9);
                    state_8.__p_KEPkV4FqlnGOK5ik3Es2LN = Output_10;
                }

                var Result_12 = n5.IPAddress.TryParse(ipString: Local_Address_In, address: out n5.IPAddress Address_11);
                var State_Output_14 = state_8.__p_KEPkV4FqlnGOK5ik3Es2LN.Update(Address_In: Address_11, Port_In: Local_Port_In, Output_Out: out n5.IPEndPoint Output_13);
                state_8.__p_KEPkV4FqlnGOK5ik3Es2LN = State_Output_14;
                outputs_6 = (Result_12, Output_13);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_15, __auto_16) = outputs_6;
            this.__cache_KFyGo9BklBiPPDC3cCTogi = manager_4;
            bool Force_17 = false;
            bool Dispose_Cached_Outputs_18 = false;
            var manager_19 = this.__cache_NOD889CMJ98NaV41VWTh0o;
            if (manager_19 is null)
            {
                manager_19 = new n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>>((false, default(n5.IPEndPoint)));
            }

            var inputs_20 = (Remote_Address_In, Remote_Port_In);
            var outputs_21 = manager_19.Outputs;
            var Has_Changed_22 = Force_17 || manager_19.InputsChanged(inputs_20);
            if (Has_Changed_22)
            {
                if (Dispose_Cached_Outputs_18)
                    manager_19.DisposeOutputs();
                var state_23 = n1.CompilationHelper.Restore<__NeTOAFKLqIOQAnfVzZuxVB>(manager_19.State, __GetContext__());
                if (state_23 == null)
                {
                    state_23 = new __NeTOAFKLqIOQAnfVzZuxVB(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "HKolUPwKUr3Mu8ifWjqbAX", 263208U);
                    var Output_25 = n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_24);
                    state_23.__p_HKolUPwKUr3Mu8ifWjqbAX = Output_25;
                }

                var Result_27 = n5.IPAddress.TryParse(ipString: Remote_Address_In, address: out n5.IPAddress Address_26);
                var State_Output_29 = state_23.__p_HKolUPwKUr3Mu8ifWjqbAX.Update(Address_In: Address_26, Port_In: Remote_Port_In, Output_Out: out n5.IPEndPoint Output_28);
                state_23.__p_HKolUPwKUr3Mu8ifWjqbAX = State_Output_29;
                outputs_21 = (Result_27, Output_28);
                manager_19 = manager_19.Update(inputs_20, __GetContext__().IsImmutable, Dispose_Cached_Outputs_18, state_23, outputs_21);
            }
            else
            {
                manager_19.Update(inputs_20, __GetContext__().IsImmutable, Dispose_Cached_Outputs_18);
            }

            var(__auto_30, __auto_31) = outputs_21;
            this.__cache_NOD889CMJ98NaV41VWTh0o = manager_19;
            bool Bind_32 = true;
            n7.UDPSocket Input_33 = this.__p_HM37cmn9717L5p7WEU29hB;
            var Result_34 = Input_33.Update(localEndPoint: __auto_16, bind: Bind_32);
            this.__p_HM37cmn9717L5p7WEU29hB = Input_33;
            var Is_Open_35 = Input_33.IsOpen;
            this.__p_HM37cmn9717L5p7WEU29hB = Input_33;
            bool SetEnabled_36 = true;
            var Output_37 = Input_33;
            if (SetEnabled_36)
            {
                Input_33.Enabled = Enabled_In;
                Output_37 = Input_33;
            }

            this.__p_HM37cmn9717L5p7WEU29hB = Output_37;
            var Output_38 = Enabled_In && __auto_15;
            var Output_39 = Output_38 && __auto_30;
            int Index_40 = n3.Convert.ToInt32(Output_39);
            double Value_41 = 1;
            var Result_42 = n3.TimeSpan.FromSeconds(value: Value_41);
            var Output_45 = this.__p_Fx0WFKD90ZoNnONx0T3VdD.Update(Period_In: Result_42, Result_Out: out n3.IObservable<long> Result_43, Changed_Out: out bool Changed_44);
            this.__p_Fx0WFKD90ZoNnONx0T3VdD = Output_45;
            n3.IObservable<long> Input_46 = n29._Operations_.CreateDefault<long>();
            var builder_47 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU, 2);
            builder_47.Add(Input_46);
            builder_47.Add(Result_43);
            var __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU_48 = builder_47.Commit();
            this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU_48;
            n31._Operations_.Switch<n3.IObservable<long>, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_40, Input_In: __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU_48, Output_Out: out n3.IObservable<long> Output_49);
            bool Reset_50 = false;
            var __fallback___51 = n1.ServiceRegistry.Current;
            n16._Operations_.Update_H<n3.Object, long, n7.Datagram>(Input_In: this.__p_Lu3L5tesLCHP2BNJSElRMJ, Messages_In: Output_49, Reset_In: Reset_50, Update_In: (n3.Object s_54, long Input_1_In_55) =>
            {
                using var __current_52 = __fallback___51.MakeCurrentIfNone();
                var state_53 = n1.CompilationHelper.Restore<__PLxwzXnNwXOM0tGdEr6Jt5>(s_54, __GetContext__());
                string __pad_VL1u4IX9YejNRYdNezDBdV_56 = __slot_VL1u4IX9YejNRYdNezDBdV;
                n33.Encodings Encoding_57 = n32._Operations_.CreateDefault();
                var Result_58 = n19.StringExtensions.ToBytes(input: __pad_VL1u4IX9YejNRYdNezDBdV_56, encoding: Encoding_57);
                n11.IEnumerable<byte> Input_59 = (n11.IEnumerable<byte>)Result_58;
                n14._Operations_.FromSequence<byte>(Input_In: Input_59, Result_Out: out n13.Spread<byte> Result_60);
                n1.NodeContext Node_Context_61 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "BjpFKRd9BewQSo2kP5BLAa", 262788U);
                n15._Operations_.Create(Node_Context: Node_Context_61, Remote_End_Point_In: __auto_31, Payload_In: Result_60, Output_Out: out n7.Datagram Output_62);
                var Current_Time_63 = n10.Clocks.CurrentTime;
                var Output_64 = __pad_NgTv3jLtmKiQChrsNHOsUj_0.SetData(Data_In: Current_Time_63);
                return n3.Tuple.Create<n3.Object, n7.Datagram>(state_53, Output_62);
            }

            , Create_In: () =>
            {
                using var __current_65 = __fallback___51.MakeCurrentIfNone();
                var state_53 = new __PLxwzXnNwXOM0tGdEr6Jt5(__GetContext__(), n1.VLObject.NewIdentity());
                return state_53;
            }

            , Output_Out: out n8.ForEach<n3.Object, long, n7.Datagram> Output_66, Result_Out: out n3.IObservable<n7.Datagram> Result_67);
            this.__p_Lu3L5tesLCHP2BNJSElRMJ = Output_66;
            bool Update_68 = true;
            var Output_69 = this.__p_Dq6XVy3uEsTO723Ks7Pqac;
            if (Update_68)
            {
                n7.DatagramSender Input_70 = this.__p_Dq6XVy3uEsTO723Ks7Pqac;
                Input_70.Update(localSocket: Result_34, datagrams: Result_67);
                Output_69 = Input_70;
            }

            this.__p_Dq6XVy3uEsTO723Ks7Pqac = Output_69;
            n7.DatagramReceiver Input_71 = this.__p_KrocXgofrNrLn1w9KP6KaP;
            var Datagrams_72 = Input_71.Datagrams;
            this.__p_KrocXgofrNrLn1w9KP6KaP = Input_71;
            bool Update_73 = true;
            var Output_74 = Input_71;
            if (Update_73)
            {
                Input_71.Update(localSocket: Result_34);
                Output_74 = Input_71;
            }

            this.__p_KrocXgofrNrLn1w9KP6KaP = Output_74;
            bool Reset_75 = false;
            n16._Operations_.Update_H<n3.Object, n7.Datagram, bool>(Input_In: this.__p_FW8LLVXahGUPvqpdAYf0iR, Messages_In: Datagrams_72, Reset_In: Reset_75, Update_In: (n3.Object s_78, n7.Datagram Input_1_In_79) =>
            {
                using var __current_76 = __fallback___51.MakeCurrentIfNone();
                var state_77 = n1.CompilationHelper.Restore<__BlEfNKvakt5LXaxnQSGGba>(s_78, __GetContext__());
                double __pad_It8butmGCj0PMsbzEACE96_80 = __slot_It8butmGCj0PMsbzEACE96;
                double __pad_Hks1yXp8OmFNlhjEoXU1xE_81 = __slot_Hks1yXp8OmFNlhjEoXU1xE;
                bool __pad_PJzMOen952HM3u4QuCzH6N_82 = __slot_PJzMOen952HM3u4QuCzH6N;
                var Payload_Array_83 = Input_1_In_79.PayloadArray;
                int Start_Index_84 = 0;
                var Result_85 = n3.BitConverter.ToDouble(value: Payload_Array_83, startIndex: Start_Index_84);
                var Current_Time_86 = n10.Clocks.CurrentTime;
                var Seconds_87 = Current_Time_86.Seconds;
                var Output_89 = __pad_NgTv3jLtmKiQChrsNHOsUj_0.Data_(Data_Out: out n10.Time Data_88);
                var Output_90 = Current_Time_86 - Data_88;
                var Seconds_91 = Output_90.Seconds;
                var Output_92 = Seconds_91 * __pad_It8butmGCj0PMsbzEACE96_80;
                double Threshold_93 = 0.01;
                float Alpha_94 = 0.95F;
                bool Reset_95 = false;
                var Output_97 = state_77.__p_BV6ebCSLiewNJxRzPayDdn.Update<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Value_In: Output_92, Threshold_In: Threshold_93, Alpha_In: Alpha_94, Reset_In: Reset_95, Value_Out: out double Value_96);
                var Output_98 = Seconds_87 - Value_96;
                var Output_99 = Result_85 - Output_98;
                double __pad_BG4Q4RqMoWxNulhx5bdeNb_100 = Seconds_91;
                double Threshold_101 = 0.01;
                float Alpha_102 = 0.98F;
                bool Reset_103 = false;
                var Output_105 = state_77.__p_KO5DwLr3rnYQOPguhXYJcP.Update<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Value_In: Output_99, Threshold_In: Threshold_101, Alpha_In: Alpha_102, Reset_In: Reset_103, Value_Out: out double Value_104);
                n39._Operations_.Abs<double, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Input_In: Value_104, Output_Out: out double Output_106);
                var Result_107 = Output_106 > __pad_Hks1yXp8OmFNlhjEoXU1xE_81;
                if (Result_107)
                {
                    var Output_109 = __pad_LemPeWlA1s9OF5fcIAYoTE_1.SetData(Data_In: Value_104);
                }

                state_77.__p_BV6ebCSLiewNJxRzPayDdn = Output_97;
                state_77.__slot_BG4Q4RqMoWxNulhx5bdeNb = Seconds_91;
                state_77.__p_KO5DwLr3rnYQOPguhXYJcP = Output_105;
                return n3.Tuple.Create<n3.Object, bool>(state_77, __pad_PJzMOen952HM3u4QuCzH6N_82);
            }

            , Create_In: () =>
            {
                using var __current_110 = __fallback___51.MakeCurrentIfNone();
                var state_77 = new __BlEfNKvakt5LXaxnQSGGba(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_111 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "BV6ebCSLiewNJxRzPayDdn", 262897U);
                double Initial_Value_112 = -1;
                var Output_113 = n40.IIR2_LowPass_R<double>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_111, Initial_Value_In: Initial_Value_112);
                state_77.__p_BV6ebCSLiewNJxRzPayDdn = Output_113;
                n1.NodeContext Node_Context_114 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "KO5DwLr3rnYQOPguhXYJcP", 262966U);
                double Initial_Value_115 = 0;
                var Output_116 = n40.IIR2_LowPass_R<double>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_114, Initial_Value_In: Initial_Value_115);
                state_77.__p_KO5DwLr3rnYQOPguhXYJcP = Output_116;
                return state_77;
            }

            , Output_Out: out n8.ForEach<n3.Object, n7.Datagram, bool> Output_117, Result_Out: out n3.IObservable<bool> Result_118);
            this.__p_FW8LLVXahGUPvqpdAYf0iR = Output_117;
            bool Reset_119 = false;
            bool Update_120 = true;
            var Output_121 = this.__p_Rz6o4pphYrWNLWUlSPH4ua;
            if (Update_120)
            {
                n9._Operations_.Update_H<bool>(Input_In: this.__p_Rz6o4pphYrWNLWUlSPH4ua, Async_Notifications_In: Result_118, Reset_In: Reset_119, Output_Out: out Output_121);
            }

            this.__p_Rz6o4pphYrWNLWUlSPH4ua = Output_121;
            n9._Operations_.GetData_H<bool>(Input_In: Output_121, Output_Out: out n8.HoldLatest<bool> Output_122, Value_Out: out bool Value_123, On_Data_Out: out bool On_Data_124);
            this.__p_Rz6o4pphYrWNLWUlSPH4ua = Output_122;
            var Current_Time_125 = n10.Clocks.CurrentTime;
            var Seconds_126 = Current_Time_125.Seconds;
            var Output_128 = __pad_LemPeWlA1s9OF5fcIAYoTE_1.Data_(Data_Out: out double Data_127);
            var Output_129 = Data_127 + Seconds_126;
            var Result_130 = (n10.Time)Output_129;
            this.__slot_DhypHoEzSM0LRHv26QM8eo = Result_130;
            n10.Time __pad_DhypHoEzSM0LRHv26QM8eo_131 = Result_130;
            var Output_133 = this.__p_DV0q1XcpVIzOhhi8yhRHJF.Update<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Value_In: Output_129, Result_Out: out double Result_132);
            this.__p_DV0q1XcpVIzOhhi8yhRHJF = Output_133;
            this.__slot_RV6LKklfPVZLGi0rAF5AKK = Result_132;
            double __pad_RV6LKklfPVZLGi0rAF5AKK_134 = Result_132;
            Sockets_is_Open_Out = Is_Open_35;
            On_Data_Out = On_Data_124;
            return this;
        }

        public n2.ClockSyncClient_C Time_(out n10.Time Time_Out)
        {
            n10.Time __pad_DhypHoEzSM0LRHv26QM8eo_0 = this.__slot_DhypHoEzSM0LRHv26QM8eo;
            Time_Out = __pad_DhypHoEzSM0LRHv26QM8eo_0;
            return this;
        }

        public n2.ClockSyncClient_C TimeDifference_(out double Time_Difference_Out)
        {
            double __pad_RV6LKklfPVZLGi0rAF5AKK_0 = this.__slot_RV6LKklfPVZLGi0rAF5AKK;
            Time_Difference_Out = __pad_RV6LKklfPVZLGi0rAF5AKK_0;
            return this;
        }

        public n2.ClockSyncClient_C __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_LemPeWlA1s9OF5fcIAYoTE = n38.Reference_C<double>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            this.__slot_NgTv3jLtmKiQChrsNHOsUj = n38.Reference_C<n10.Time>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            this.__slot_DhypHoEzSM0LRHv26QM8eo = n41._Operations_.CreateDefault();
            this.__slot_RV6LKklfPVZLGi0rAF5AKK = 0;
            this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = n14._Operations_.CreateDefault<n3.IObservable<long>>();
            double __pad_D4f7CsTQPgWQOPEDOf81rD_0 = __slot_D4f7CsTQPgWQOPEDOf81rD;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "ILrfoMcBm9rLdG7eKvGBpu", 263062U);
            var Output_2 = n38.Reference_C<double>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_1, Data_In: __pad_D4f7CsTQPgWQOPEDOf81rD_0);
            this.__slot_LemPeWlA1s9OF5fcIAYoTE = Output_2;
            n38.Reference_C<double> __pad_LemPeWlA1s9OF5fcIAYoTE_3 = Output_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "QWp9uQDKhQLNAkfQd4GPqB", 263126U);
            n10.Time Data_5 = n41._Operations_.CreateDefault();
            var Output_6 = n38.Reference_C<n10.Time>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_4, Data_In: Data_5);
            this.__slot_NgTv3jLtmKiQChrsNHOsUj = Output_6;
            n38.Reference_C<n10.Time> __pad_NgTv3jLtmKiQChrsNHOsUj_7 = Output_6;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Fx0WFKD90ZoNnONx0T3VdD", 262731U);
            var Output_9 = n36.Interval_H0f7FR6DlKkP89i5do6r8X.Create(Node_Context: Node_Context_8);
            this.__p_Fx0WFKD90ZoNnONx0T3VdD = Output_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Lu3L5tesLCHP2BNJSElRMJ", 262746U);
            n16._Operations_.Create_H<n3.Object, long, n7.Datagram>(Node_Context: Node_Context_10, Output_Out: out n8.ForEach<n3.Object, long, n7.Datagram> Output_11);
            this.__p_Lu3L5tesLCHP2BNJSElRMJ = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "HM37cmn9717L5p7WEU29hB", 262808U);
            n26._Operations_.Create_H(Node_Context: Node_Context_12, Output_Out: out n7.UDPSocket Output_13);
            this.__p_HM37cmn9717L5p7WEU29hB = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "FW8LLVXahGUPvqpdAYf0iR", 262831U);
            n16._Operations_.Create_H<n3.Object, n7.Datagram, bool>(Node_Context: Node_Context_14, Output_Out: out n8.ForEach<n3.Object, n7.Datagram, bool> Output_15);
            this.__p_FW8LLVXahGUPvqpdAYf0iR = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "DV0q1XcpVIzOhhi8yhRHJF", 263121U);
            var Output_17 = n23.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<double>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_16);
            this.__p_DV0q1XcpVIzOhhi8yhRHJF = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Rz6o4pphYrWNLWUlSPH4ua", 263153U);
            bool Initial_Result_19 = false;
            n9._Operations_.Create_H<bool>(Node_Context: Node_Context_18, Initial_Result_In: Initial_Result_19, Output_Out: out n8.HoldLatest<bool> Output_20);
            this.__p_Rz6o4pphYrWNLWUlSPH4ua = Output_20;
            n1.NodeContext Node_Context_21 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "KrocXgofrNrLn1w9KP6KaP", 263164U);
            n27._Operations_.Create_H(Node_Context: Node_Context_21, Output_Out: out n7.DatagramReceiver Output_22);
            this.__p_KrocXgofrNrLn1w9KP6KaP = Output_22;
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Dq6XVy3uEsTO723Ks7Pqac", 263171U);
            n21._Operations_.Create_H(Node_Context_In: Node_Context_23, Output_Out: out n7.DatagramSender Output_24);
            this.__p_Dq6XVy3uEsTO723Ks7Pqac = Output_24;
            this.__cache_KFyGo9BklBiPPDC3cCTogi = null;
            this.__cache_NOD889CMJ98NaV41VWTh0o = null;
            return this;
        }

        public n2.ClockSyncClient_C __CreateDefault__()
        {
            this.__slot_LemPeWlA1s9OF5fcIAYoTE = n38.Reference_C<double>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            this.__slot_NgTv3jLtmKiQChrsNHOsUj = n38.Reference_C<n10.Time>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            this.__slot_DhypHoEzSM0LRHv26QM8eo = n41._Operations_.CreateDefault();
            this.__slot_RV6LKklfPVZLGi0rAF5AKK = 0;
            this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = n14._Operations_.CreateDefault<n3.IObservable<long>>();
            this.__cache_KFyGo9BklBiPPDC3cCTogi = null;
            this.__cache_NOD889CMJ98NaV41VWTh0o = null;
            this.__p_HM37cmn9717L5p7WEU29hB = default(n7.UDPSocket);
            this.__p_Fx0WFKD90ZoNnONx0T3VdD = n36.Interval_H0f7FR6DlKkP89i5do6r8X.CreateDefault();
            this.__p_Lu3L5tesLCHP2BNJSElRMJ = default(n8.ForEach<n3.Object, long, n7.Datagram>);
            this.__p_Dq6XVy3uEsTO723Ks7Pqac = default(n7.DatagramSender);
            this.__p_KrocXgofrNrLn1w9KP6KaP = default(n7.DatagramReceiver);
            this.__p_FW8LLVXahGUPvqpdAYf0iR = default(n8.ForEach<n3.Object, n7.Datagram, bool>);
            this.__p_Rz6o4pphYrWNLWUlSPH4ua = default(n8.HoldLatest<bool>);
            this.__p_DV0q1XcpVIzOhhi8yhRHJF = n23.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<double>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KFyGo9BklBiPPDC3cCTogi);
            n1.CompilationHelper.SafeDispose(this.__cache_NOD889CMJ98NaV41VWTh0o);
            n1.CompilationHelper.SafeDispose(this.__p_HM37cmn9717L5p7WEU29hB);
            n1.CompilationHelper.SafeDispose(this.__p_Fx0WFKD90ZoNnONx0T3VdD);
            n1.CompilationHelper.SafeDispose(this.__p_Lu3L5tesLCHP2BNJSElRMJ);
            n1.CompilationHelper.SafeDispose(this.__p_Dq6XVy3uEsTO723Ks7Pqac);
            n1.CompilationHelper.SafeDispose(this.__p_KrocXgofrNrLn1w9KP6KaP);
            n1.CompilationHelper.SafeDispose(this.__p_FW8LLVXahGUPvqpdAYf0iR);
            n1.CompilationHelper.SafeDispose(this.__p_Rz6o4pphYrWNLWUlSPH4ua);
            n1.CompilationHelper.SafeDispose(this.__p_DV0q1XcpVIzOhhi8yhRHJF);
            return;
        }

        n3.IObservable<n10.FrameTimeMessage> n10.IFrameClock.GetTicks()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            return n29._Operations_.CreateDefault<n10.FrameTimeMessage>();
        }

        n3.IObservable<n10.FrameFinishedMessage> n10.IFrameClock.GetFrameFinished()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            return n29._Operations_.CreateDefault<n10.FrameFinishedMessage>();
        }

        double n10.IFrameClock.TimeDifference
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = TimeDifference_(out double out_Time_Difference_Out);
                return out_Time_Difference_Out;
            }
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        n10.Time n10.IClock.Time
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Time_(out n10.Time out_Time_Out);
                return out_Time_Out;
            }
        }

        [n1.ElementAttribute(TracingId = 263073U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "D4f7CsTQPgWQOPEDOf81rD", Name = "__slot_D4f7CsTQPgWQOPEDOf81rD")]
        public static double __slot_D4f7CsTQPgWQOPEDOf81rD = 0;
        [n1.ElementAttribute(TracingId = 263115U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LemPeWlA1s9OF5fcIAYoTE", Name = "__slot_LemPeWlA1s9OF5fcIAYoTE")]
        public n38.Reference_C<double> __slot_LemPeWlA1s9OF5fcIAYoTE;
        [n1.ElementAttribute(TracingId = 263136U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "NgTv3jLtmKiQChrsNHOsUj", Name = "__slot_NgTv3jLtmKiQChrsNHOsUj")]
        public n38.Reference_C<n10.Time> __slot_NgTv3jLtmKiQChrsNHOsUj;
        [n1.ElementAttribute(TracingId = 263138U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DhypHoEzSM0LRHv26QM8eo", Name = "__slot_DhypHoEzSM0LRHv26QM8eo")]
        public n10.Time __slot_DhypHoEzSM0LRHv26QM8eo;
        [n1.ElementAttribute(TracingId = 263139U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RV6LKklfPVZLGi0rAF5AKK", Name = "__slot_RV6LKklfPVZLGi0rAF5AKK")]
        public double __slot_RV6LKklfPVZLGi0rAF5AKK;
        [n1.ElementAttribute(TracingId = 263140U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LPfE9KCNPV9PVtwAbVwZEa", Name = "__slot_LPfE9KCNPV9PVtwAbVwZEa")]
        public static string __slot_LPfE9KCNPV9PVtwAbVwZEa = "1) Client sends a periodic ping to the server and saves the timestamp of the ping";
        [n1.ElementAttribute(TracingId = 263148U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LJLasUYAqbZOyCP4r3unHu", Name = "__slot_LJLasUYAqbZOyCP4r3unHu")]
        public static string __slot_LJLasUYAqbZOyCP4r3unHu = "2) Client receives back the time from the server, figures out the latency of the roundtrip and converges smoothly to the servers time";
        [n1.ElementAttribute(TracingId = 263227U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KFyGo9BklBiPPDC3cCTogi", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_KFyGo9BklBiPPDC3cCTogi = null;
        [n1.ElementAttribute(TracingId = 263188U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "NOD889CMJ98NaV41VWTh0o", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_NOD889CMJ98NaV41VWTh0o = null;
        [n1.ElementAttribute(TracingId = 262808U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HM37cmn9717L5p7WEU29hB", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n7.UDPSocket __p_HM37cmn9717L5p7WEU29hB;
        [n1.ElementAttribute(TracingId = 262731U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Fx0WFKD90ZoNnONx0T3VdD", Name = "Interval", IsManaged = true, IsAutoGenerated = true)]
        public n36.Interval_H0f7FR6DlKkP89i5do6r8X __p_Fx0WFKD90ZoNnONx0T3VdD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<n3.IObservable<long>> __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = default(n13.Spread<n3.IObservable<long>>);
        [n1.ElementAttribute(TracingId = 262746U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Lu3L5tesLCHP2BNJSElRMJ", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEach<n3.Object, long, n7.Datagram> __p_Lu3L5tesLCHP2BNJSElRMJ;
        [n1.ElementAttribute(TracingId = 262772U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "VL1u4IX9YejNRYdNezDBdV", Name = "__slot_VL1u4IX9YejNRYdNezDBdV")]
        public static string __slot_VL1u4IX9YejNRYdNezDBdV = "time";
        [n1.ElementAttribute(TracingId = 263171U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Dq6XVy3uEsTO723Ks7Pqac", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramSender __p_Dq6XVy3uEsTO723Ks7Pqac;
        [n1.ElementAttribute(TracingId = 263164U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KrocXgofrNrLn1w9KP6KaP", Name = "Receiver (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n7.DatagramReceiver __p_KrocXgofrNrLn1w9KP6KaP;
        [n1.ElementAttribute(TracingId = 262831U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FW8LLVXahGUPvqpdAYf0iR", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n8.ForEach<n3.Object, n7.Datagram, bool> __p_FW8LLVXahGUPvqpdAYf0iR;
        [n1.ElementAttribute(TracingId = 262894U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "It8butmGCj0PMsbzEACE96", Name = "__slot_It8butmGCj0PMsbzEACE96")]
        public static double __slot_It8butmGCj0PMsbzEACE96 = 0.5;
        [n1.ElementAttribute(TracingId = 263007U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Hks1yXp8OmFNlhjEoXU1xE", Name = "__slot_Hks1yXp8OmFNlhjEoXU1xE")]
        public static double __slot_Hks1yXp8OmFNlhjEoXU1xE = 0.001;
        [n1.ElementAttribute(TracingId = 262867U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PJzMOen952HM3u4QuCzH6N", Name = "__slot_PJzMOen952HM3u4QuCzH6N")]
        public static bool __slot_PJzMOen952HM3u4QuCzH6N = false;
        [n1.ElementAttribute(TracingId = 263153U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Rz6o4pphYrWNLWUlSPH4ua", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n8.HoldLatest<bool> __p_Rz6o4pphYrWNLWUlSPH4ua;
        [n1.ElementAttribute(TracingId = 263121U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DV0q1XcpVIzOhhi8yhRHJF", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n23.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<double> __p_DV0q1XcpVIzOhhi8yhRHJF;
        static ClockSyncClient_C()
        {
        }

        public ClockSyncClient_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ClockSyncClient_C(ClockSyncClient_C other): base(other)
        {
            this.__slot_LemPeWlA1s9OF5fcIAYoTE = other.__slot_LemPeWlA1s9OF5fcIAYoTE;
            this.__slot_NgTv3jLtmKiQChrsNHOsUj = other.__slot_NgTv3jLtmKiQChrsNHOsUj;
            this.__slot_DhypHoEzSM0LRHv26QM8eo = other.__slot_DhypHoEzSM0LRHv26QM8eo;
            this.__slot_RV6LKklfPVZLGi0rAF5AKK = other.__slot_RV6LKklfPVZLGi0rAF5AKK;
            this.__cache_KFyGo9BklBiPPDC3cCTogi = other.__cache_KFyGo9BklBiPPDC3cCTogi;
            this.__cache_NOD889CMJ98NaV41VWTh0o = other.__cache_NOD889CMJ98NaV41VWTh0o;
            this.__p_HM37cmn9717L5p7WEU29hB = other.__p_HM37cmn9717L5p7WEU29hB;
            this.__p_Fx0WFKD90ZoNnONx0T3VdD = other.__p_Fx0WFKD90ZoNnONx0T3VdD;
            this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = other.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU;
            this.__p_Lu3L5tesLCHP2BNJSElRMJ = other.__p_Lu3L5tesLCHP2BNJSElRMJ;
            this.__p_Dq6XVy3uEsTO723Ks7Pqac = other.__p_Dq6XVy3uEsTO723Ks7Pqac;
            this.__p_KrocXgofrNrLn1w9KP6KaP = other.__p_KrocXgofrNrLn1w9KP6KaP;
            this.__p_FW8LLVXahGUPvqpdAYf0iR = other.__p_FW8LLVXahGUPvqpdAYf0iR;
            this.__p_Rz6o4pphYrWNLWUlSPH4ua = other.__p_Rz6o4pphYrWNLWUlSPH4ua;
            this.__p_DV0q1XcpVIzOhhi8yhRHJF = other.__p_DV0q1XcpVIzOhhi8yhRHJF;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LemPeWlA1s9OF5fcIAYoTE", in __slot_LemPeWlA1s9OF5fcIAYoTE), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NgTv3jLtmKiQChrsNHOsUj", in __slot_NgTv3jLtmKiQChrsNHOsUj), n1.CompilationHelper.GetValueOrExisting(values, "__slot_DhypHoEzSM0LRHv26QM8eo", in __slot_DhypHoEzSM0LRHv26QM8eo), n1.CompilationHelper.GetValueOrExisting(values, "__slot_RV6LKklfPVZLGi0rAF5AKK", in __slot_RV6LKklfPVZLGi0rAF5AKK), n1.CompilationHelper.GetValueOrExisting(values, "__cache_KFyGo9BklBiPPDC3cCTogi", in __cache_KFyGo9BklBiPPDC3cCTogi), n1.CompilationHelper.GetValueOrExisting(values, "__cache_NOD889CMJ98NaV41VWTh0o", in __cache_NOD889CMJ98NaV41VWTh0o), n1.CompilationHelper.GetValueOrExisting(values, "__p_HM37cmn9717L5p7WEU29hB", in __p_HM37cmn9717L5p7WEU29hB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fx0WFKD90ZoNnONx0T3VdD", in __p_Fx0WFKD90ZoNnONx0T3VdD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU", in __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lu3L5tesLCHP2BNJSElRMJ", in __p_Lu3L5tesLCHP2BNJSElRMJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dq6XVy3uEsTO723Ks7Pqac", in __p_Dq6XVy3uEsTO723Ks7Pqac), n1.CompilationHelper.GetValueOrExisting(values, "__p_KrocXgofrNrLn1w9KP6KaP", in __p_KrocXgofrNrLn1w9KP6KaP), n1.CompilationHelper.GetValueOrExisting(values, "__p_FW8LLVXahGUPvqpdAYf0iR", in __p_FW8LLVXahGUPvqpdAYf0iR), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rz6o4pphYrWNLWUlSPH4ua", in __p_Rz6o4pphYrWNLWUlSPH4ua), n1.CompilationHelper.GetValueOrExisting(values, "__p_DV0q1XcpVIzOhhi8yhRHJF", in __p_DV0q1XcpVIzOhhi8yhRHJF));
        }

        internal ClockSyncClient_C __WITH__(n38.Reference_C<double> __slot_LemPeWlA1s9OF5fcIAYoTE, n38.Reference_C<n10.Time> __slot_NgTv3jLtmKiQChrsNHOsUj, n10.Time __slot_DhypHoEzSM0LRHv26QM8eo, double __slot_RV6LKklfPVZLGi0rAF5AKK, n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_KFyGo9BklBiPPDC3cCTogi, n6.Manager<n3.ValueTuple<string, int>, n3.ValueTuple<bool, n5.IPEndPoint>> __cache_NOD889CMJ98NaV41VWTh0o, n7.UDPSocket __p_HM37cmn9717L5p7WEU29hB, n36.Interval_H0f7FR6DlKkP89i5do6r8X __p_Fx0WFKD90ZoNnONx0T3VdD, n13.Spread<n3.IObservable<long>> __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU, n8.ForEach<n3.Object, long, n7.Datagram> __p_Lu3L5tesLCHP2BNJSElRMJ, n7.DatagramSender __p_Dq6XVy3uEsTO723Ks7Pqac, n7.DatagramReceiver __p_KrocXgofrNrLn1w9KP6KaP, n8.ForEach<n3.Object, n7.Datagram, bool> __p_FW8LLVXahGUPvqpdAYf0iR, n8.HoldLatest<bool> __p_Rz6o4pphYrWNLWUlSPH4ua, n23.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<double> __p_DV0q1XcpVIzOhhi8yhRHJF)
        {
            n2.ClockSyncClient_C that_0 = this;
            this.__slot_LemPeWlA1s9OF5fcIAYoTE = __slot_LemPeWlA1s9OF5fcIAYoTE;
            this.__slot_NgTv3jLtmKiQChrsNHOsUj = __slot_NgTv3jLtmKiQChrsNHOsUj;
            this.__slot_DhypHoEzSM0LRHv26QM8eo = __slot_DhypHoEzSM0LRHv26QM8eo;
            this.__slot_RV6LKklfPVZLGi0rAF5AKK = __slot_RV6LKklfPVZLGi0rAF5AKK;
            this.__cache_KFyGo9BklBiPPDC3cCTogi = __cache_KFyGo9BklBiPPDC3cCTogi;
            this.__cache_NOD889CMJ98NaV41VWTh0o = __cache_NOD889CMJ98NaV41VWTh0o;
            this.__p_HM37cmn9717L5p7WEU29hB = __p_HM37cmn9717L5p7WEU29hB;
            this.__p_Fx0WFKD90ZoNnONx0T3VdD = __p_Fx0WFKD90ZoNnONx0T3VdD;
            this.__pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU = __pin_group_Input_In_KYcRwzpGUKPPhuZqSczepU;
            this.__p_Lu3L5tesLCHP2BNJSElRMJ = __p_Lu3L5tesLCHP2BNJSElRMJ;
            this.__p_Dq6XVy3uEsTO723Ks7Pqac = __p_Dq6XVy3uEsTO723Ks7Pqac;
            this.__p_KrocXgofrNrLn1w9KP6KaP = __p_KrocXgofrNrLn1w9KP6KaP;
            this.__p_FW8LLVXahGUPvqpdAYf0iR = __p_FW8LLVXahGUPvqpdAYf0iR;
            this.__p_Rz6o4pphYrWNLWUlSPH4ua = __p_Rz6o4pphYrWNLWUlSPH4ua;
            this.__p_DV0q1XcpVIzOhhi8yhRHJF = __p_DV0q1XcpVIzOhhi8yhRHJF;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Q2eQoLCq7QGMdnFWWV1MGE", Name = "__Q2eQoLCq7QGMdnFWWV1MGE")]
        [n3.SerializableAttribute]
        public class __Q2eQoLCq7QGMdnFWWV1MGE : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_KEPkV4FqlnGOK5ik3Es2LN);
                return;
            }

            [n1.ElementAttribute(TracingId = 263248U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KEPkV4FqlnGOK5ik3Es2LN", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
            public n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_KEPkV4FqlnGOK5ik3Es2LN;
            public __Q2eQoLCq7QGMdnFWWV1MGE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q2eQoLCq7QGMdnFWWV1MGE(__Q2eQoLCq7QGMdnFWWV1MGE other): base(other)
            {
                this.__p_KEPkV4FqlnGOK5ik3Es2LN = other.__p_KEPkV4FqlnGOK5ik3Es2LN;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KEPkV4FqlnGOK5ik3Es2LN", in __p_KEPkV4FqlnGOK5ik3Es2LN));
            }

            internal __Q2eQoLCq7QGMdnFWWV1MGE __WITH__(n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_KEPkV4FqlnGOK5ik3Es2LN)
            {
                __Q2eQoLCq7QGMdnFWWV1MGE that_0 = this;
                this.__p_KEPkV4FqlnGOK5ik3Es2LN = __p_KEPkV4FqlnGOK5ik3Es2LN;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "NeTOAFKLqIOQAnfVzZuxVB", Name = "__NeTOAFKLqIOQAnfVzZuxVB")]
        [n3.SerializableAttribute]
        public class __NeTOAFKLqIOQAnfVzZuxVB : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HKolUPwKUr3Mu8ifWjqbAX);
                return;
            }

            [n1.ElementAttribute(TracingId = 263208U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HKolUPwKUr3Mu8ifWjqbAX", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
            public n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_HKolUPwKUr3Mu8ifWjqbAX;
            public __NeTOAFKLqIOQAnfVzZuxVB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NeTOAFKLqIOQAnfVzZuxVB(__NeTOAFKLqIOQAnfVzZuxVB other): base(other)
            {
                this.__p_HKolUPwKUr3Mu8ifWjqbAX = other.__p_HKolUPwKUr3Mu8ifWjqbAX;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HKolUPwKUr3Mu8ifWjqbAX", in __p_HKolUPwKUr3Mu8ifWjqbAX));
            }

            internal __NeTOAFKLqIOQAnfVzZuxVB __WITH__(n17.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_HKolUPwKUr3Mu8ifWjqbAX)
            {
                __NeTOAFKLqIOQAnfVzZuxVB that_0 = this;
                this.__p_HKolUPwKUr3Mu8ifWjqbAX = __p_HKolUPwKUr3Mu8ifWjqbAX;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PLxwzXnNwXOM0tGdEr6Jt5", Name = "__PLxwzXnNwXOM0tGdEr6Jt5")]
        [n3.SerializableAttribute]
        public class __PLxwzXnNwXOM0tGdEr6Jt5 : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __PLxwzXnNwXOM0tGdEr6Jt5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PLxwzXnNwXOM0tGdEr6Jt5(__PLxwzXnNwXOM0tGdEr6Jt5 other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __PLxwzXnNwXOM0tGdEr6Jt5 __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BlEfNKvakt5LXaxnQSGGba", Name = "__BlEfNKvakt5LXaxnQSGGba")]
        [n3.SerializableAttribute]
        public class __BlEfNKvakt5LXaxnQSGGba : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BV6ebCSLiewNJxRzPayDdn);
                n1.CompilationHelper.SafeDispose(this.__p_KO5DwLr3rnYQOPguhXYJcP);
                return;
            }

            [n1.ElementAttribute(TracingId = 262897U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BV6ebCSLiewNJxRzPayDdn", Name = "IIR2 (LowPass)", IsManaged = true, IsAutoGenerated = true)]
            public n40.IIR2_LowPass_R<double> __p_BV6ebCSLiewNJxRzPayDdn;
            [n1.ElementAttribute(TracingId = 263049U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BG4Q4RqMoWxNulhx5bdeNb", Name = "__slot_BG4Q4RqMoWxNulhx5bdeNb")]
            public double __slot_BG4Q4RqMoWxNulhx5bdeNb;
            [n1.ElementAttribute(TracingId = 262966U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KO5DwLr3rnYQOPguhXYJcP", Name = "IIR2 (LowPass)", IsManaged = true, IsAutoGenerated = true)]
            public n40.IIR2_LowPass_R<double> __p_KO5DwLr3rnYQOPguhXYJcP;
            public __BlEfNKvakt5LXaxnQSGGba(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BlEfNKvakt5LXaxnQSGGba(__BlEfNKvakt5LXaxnQSGGba other): base(other)
            {
                this.__p_BV6ebCSLiewNJxRzPayDdn = other.__p_BV6ebCSLiewNJxRzPayDdn;
                this.__slot_BG4Q4RqMoWxNulhx5bdeNb = other.__slot_BG4Q4RqMoWxNulhx5bdeNb;
                this.__p_KO5DwLr3rnYQOPguhXYJcP = other.__p_KO5DwLr3rnYQOPguhXYJcP;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BV6ebCSLiewNJxRzPayDdn", in __p_BV6ebCSLiewNJxRzPayDdn), n1.CompilationHelper.GetValueOrExisting(values, "__slot_BG4Q4RqMoWxNulhx5bdeNb", in __slot_BG4Q4RqMoWxNulhx5bdeNb), n1.CompilationHelper.GetValueOrExisting(values, "__p_KO5DwLr3rnYQOPguhXYJcP", in __p_KO5DwLr3rnYQOPguhXYJcP));
            }

            internal __BlEfNKvakt5LXaxnQSGGba __WITH__(n40.IIR2_LowPass_R<double> __p_BV6ebCSLiewNJxRzPayDdn, double __slot_BG4Q4RqMoWxNulhx5bdeNb, n40.IIR2_LowPass_R<double> __p_KO5DwLr3rnYQOPguhXYJcP)
            {
                __BlEfNKvakt5LXaxnQSGGba that_0 = this;
                this.__p_BV6ebCSLiewNJxRzPayDdn = __p_BV6ebCSLiewNJxRzPayDdn;
                this.__slot_BG4Q4RqMoWxNulhx5bdeNb = __slot_BG4Q4RqMoWxNulhx5bdeNb;
                this.__p_KO5DwLr3rnYQOPguhXYJcP = __p_KO5DwLr3rnYQOPguhXYJcP;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 263670U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "POjVU9GJJVRPDqPMaDR0ER", Name = "ClockSyncer_POjVU9GJJVRPDqPMaDR0ER")]
    [n3.SerializableAttribute]
    public class ClockSyncer_POjVU9GJJVRPDqPMaDR0ER : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER Create(n1.NodeContext Node_Context)
        {
            var instance = new ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER CreateDefault()
        {
            var instance = new ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Server_Address_In, [n4.SerializedDefaultValueAttribute("5555", false)] int Port_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n10.IFrameClock Output_Out, out bool Socket_is_Open_Out, out bool On_Data_Out)
        {
            bool Update_0 = false;
            var Output_5 = this.__p_LjqNGDadeB3PUTgQ3Tb8Em.Update(Update_In: Update_0, Address_Out: out n13.Spread<string> Address_1, Name_Out: out n13.Spread<string> Name_2, Description_Out: out n13.Spread<string> Description_3, Is_Up_Out: out n13.Spread<bool> Is_Up_4);
            n14._Operations_.Contains<string>(Input_In: Address_1, Item_In: Server_Address_In, Result_Out: out bool Result_6);
            var Output_7 = !Result_6;
            var Output_8 = Output_7 && Enabled_In;
            var Output_9 = Result_6 && Enabled_In;
            var Output_12 = this.__p_EuD4IzVz46JOpEEoedXNDP.Update(Local_Address_In: Server_Address_In, Local_Port_In: Port_In, Enabled_In: Output_9, Socket_is_Open_Out: out bool Socket_is_Open_10, On_Data_Out: out bool On_Data_11);
            string Local_Address_13 = "0.0.0.0";
            var Output_16 = this.__p_SCSrNt6WqCQNcGVvvnoia3.Update(Local_Address_In: Local_Address_13, Local_Port_In: Port_In, Remote_Address_In: Server_Address_In, Remote_Port_In: Port_In, Enabled_In: Output_8, Sockets_is_Open_Out: out bool Sockets_is_Open_14, On_Data_Out: out bool On_Data_15);
            int Index_17 = n3.Convert.ToInt32(Result_6);
            var builder_18 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD, 2);
            builder_18.Add(Sockets_is_Open_14);
            builder_18.Add(Socket_is_Open_10);
            var __pin_group_Input_In_AWWUedIe01vMDFlwauKktD_19 = builder_18.Commit();
            n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_17, Input_In: __pin_group_Input_In_AWWUedIe01vMDFlwauKktD_19, Output_Out: out bool Output_20);
            int Index_21 = n3.Convert.ToInt32(Result_6);
            var builder_22 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA, 2);
            builder_22.Add(On_Data_15);
            builder_22.Add(On_Data_11);
            var __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA_23 = builder_22.Commit();
            n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_21, Input_In: __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA_23, Output_Out: out bool Output_24);
            n10.IFrameClock Output_Out_25 = (n10.IFrameClock)Output_16;
            Output_Out = Output_Out_25;
            Socket_is_Open_Out = Output_20;
            On_Data_Out = Output_24;
            n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = Output_5 != this.__p_LjqNGDadeB3PUTgQ3Tb8Em || Output_12 != this.__p_EuD4IzVz46JOpEEoedXNDP || Output_16 != this.__p_SCSrNt6WqCQNcGVvvnoia3 || __pin_group_Input_In_AWWUedIe01vMDFlwauKktD_19 != this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD || __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA_23 != this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA ? new ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(this)
                {__p_LjqNGDadeB3PUTgQ3Tb8Em = Output_5, __p_EuD4IzVz46JOpEEoedXNDP = Output_12, __p_SCSrNt6WqCQNcGVvvnoia3 = Output_16, __pin_group_Input_In_AWWUedIe01vMDFlwauKktD = __pin_group_Input_In_AWWUedIe01vMDFlwauKktD_19, __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA_23} : that_26;
            else
            {
                this.__p_LjqNGDadeB3PUTgQ3Tb8Em = Output_5;
                this.__p_EuD4IzVz46JOpEEoedXNDP = Output_12;
                this.__p_SCSrNt6WqCQNcGVvvnoia3 = Output_16;
                this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD = __pin_group_Input_In_AWWUedIe01vMDFlwauKktD_19;
                this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA_23;
            }

            return that_26;
        }

        public n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "EuD4IzVz46JOpEEoedXNDP", 263674U);
            var Output_1 = n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "LjqNGDadeB3PUTgQ3Tb8Em", 263705U);
            var Output_3 = n42.IPs_SU385Q2zoCqLj1U3xPCyTo.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "SCSrNt6WqCQNcGVvvnoia3", 263756U);
            var Output_5 = n2.ClockSyncClient_C.Create(Node_Context: Node_Context_4);
            n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER that_6 = this;
            this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = n14._Operations_.CreateDefault<bool>();
            this.__p_EuD4IzVz46JOpEEoedXNDP = Output_1;
            this.__p_LjqNGDadeB3PUTgQ3Tb8Em = Output_3;
            this.__p_SCSrNt6WqCQNcGVvvnoia3 = Output_5;
            return that_6;
        }

        public n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER __CreateDefault__()
        {
            n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER that_0 = this;
            this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = n14._Operations_.CreateDefault<bool>();
            this.__p_LjqNGDadeB3PUTgQ3Tb8Em = n42.IPs_SU385Q2zoCqLj1U3xPCyTo.CreateDefault();
            this.__p_EuD4IzVz46JOpEEoedXNDP = n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV.CreateDefault();
            this.__p_SCSrNt6WqCQNcGVvvnoia3 = n2.ClockSyncClient_C.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LjqNGDadeB3PUTgQ3Tb8Em);
            n1.CompilationHelper.SafeDispose(this.__p_EuD4IzVz46JOpEEoedXNDP);
            n1.CompilationHelper.SafeDispose(this.__p_SCSrNt6WqCQNcGVvvnoia3);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 263705U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LjqNGDadeB3PUTgQ3Tb8Em", Name = "IPs", IsManaged = true, IsAutoGenerated = true)]
        public n42.IPs_SU385Q2zoCqLj1U3xPCyTo __p_LjqNGDadeB3PUTgQ3Tb8Em;
        [n1.ElementAttribute(TracingId = 263674U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EuD4IzVz46JOpEEoedXNDP", Name = "ClockSyncServer", IsManaged = true, IsAutoGenerated = true)]
        public n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV __p_EuD4IzVz46JOpEEoedXNDP;
        [n1.ElementAttribute(TracingId = 263756U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SCSrNt6WqCQNcGVvvnoia3", Name = "ClockSyncClient", IsManaged = true, IsAutoGenerated = true)]
        public n2.ClockSyncClient_C __p_SCSrNt6WqCQNcGVvvnoia3;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<bool> __pin_group_Input_In_AWWUedIe01vMDFlwauKktD = default(n13.Spread<bool>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<bool> __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = default(n13.Spread<bool>);
        public ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(ClockSyncer_POjVU9GJJVRPDqPMaDR0ER other): base(other)
        {
            this.__p_LjqNGDadeB3PUTgQ3Tb8Em = other.__p_LjqNGDadeB3PUTgQ3Tb8Em;
            this.__p_EuD4IzVz46JOpEEoedXNDP = other.__p_EuD4IzVz46JOpEEoedXNDP;
            this.__p_SCSrNt6WqCQNcGVvvnoia3 = other.__p_SCSrNt6WqCQNcGVvvnoia3;
            this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD = other.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD;
            this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = other.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LjqNGDadeB3PUTgQ3Tb8Em", in __p_LjqNGDadeB3PUTgQ3Tb8Em), n1.CompilationHelper.GetValueOrExisting(values, "__p_EuD4IzVz46JOpEEoedXNDP", in __p_EuD4IzVz46JOpEEoedXNDP), n1.CompilationHelper.GetValueOrExisting(values, "__p_SCSrNt6WqCQNcGVvvnoia3", in __p_SCSrNt6WqCQNcGVvvnoia3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AWWUedIe01vMDFlwauKktD", in __pin_group_Input_In_AWWUedIe01vMDFlwauKktD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA", in __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA));
        }

        internal ClockSyncer_POjVU9GJJVRPDqPMaDR0ER __WITH__(n42.IPs_SU385Q2zoCqLj1U3xPCyTo __p_LjqNGDadeB3PUTgQ3Tb8Em, n2.ClockSyncServer_CUiB12ZYuLcLxCmY1NIxUV __p_EuD4IzVz46JOpEEoedXNDP, n2.ClockSyncClient_C __p_SCSrNt6WqCQNcGVvvnoia3, n13.Spread<bool> __pin_group_Input_In_AWWUedIe01vMDFlwauKktD, n13.Spread<bool> __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA)
        {
            n2.ClockSyncer_POjVU9GJJVRPDqPMaDR0ER that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LjqNGDadeB3PUTgQ3Tb8Em != this.__p_LjqNGDadeB3PUTgQ3Tb8Em || __p_EuD4IzVz46JOpEEoedXNDP != this.__p_EuD4IzVz46JOpEEoedXNDP || __p_SCSrNt6WqCQNcGVvvnoia3 != this.__p_SCSrNt6WqCQNcGVvvnoia3 || __pin_group_Input_In_AWWUedIe01vMDFlwauKktD != this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD || __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA != this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA ? new ClockSyncer_POjVU9GJJVRPDqPMaDR0ER(this)
                {__p_LjqNGDadeB3PUTgQ3Tb8Em = __p_LjqNGDadeB3PUTgQ3Tb8Em, __p_EuD4IzVz46JOpEEoedXNDP = __p_EuD4IzVz46JOpEEoedXNDP, __p_SCSrNt6WqCQNcGVvvnoia3 = __p_SCSrNt6WqCQNcGVvvnoia3, __pin_group_Input_In_AWWUedIe01vMDFlwauKktD = __pin_group_Input_In_AWWUedIe01vMDFlwauKktD, __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA} : that_0;
            else
            {
                this.__p_LjqNGDadeB3PUTgQ3Tb8Em = __p_LjqNGDadeB3PUTgQ3Tb8Em;
                this.__p_EuD4IzVz46JOpEEoedXNDP = __p_EuD4IzVz46JOpEEoedXNDP;
                this.__p_SCSrNt6WqCQNcGVvvnoia3 = __p_SCSrNt6WqCQNcGVvvnoia3;
                this.__pin_group_Input_In_AWWUedIe01vMDFlwauKktD = __pin_group_Input_In_AWWUedIe01vMDFlwauKktD;
                this.__pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA = __pin_group_Input_In_TdEeJTMNYPLM5gAiI1xoOA;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 263837U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HfYySC7nO7LOHxULI6wAtJ", Name = "PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ")]
    [n3.SerializableAttribute]
    public class PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ Create(n1.NodeContext Node_Context)
        {
            var instance = new PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ CreateDefault()
        {
            var instance = new PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ Update([n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Server_Address_In, [n4.SerializedDefaultValueAttribute("6666", false)] int Port_In, double Constant_Offset_In, [n4.SerializedDefaultValueAttribute("0.25", false)] double Seek_Threshold_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n2.ITimeSync_I Output_Out, out bool Socket_is_Open_Out, out bool On_Data_Out)
        {
            bool Update_0 = false;
            var Output_5 = this.__p_VdrbOl2TfXVOXPpFR2XPYo.Update(Update_In: Update_0, Address_Out: out n13.Spread<string> Address_1, Name_Out: out n13.Spread<string> Name_2, Description_Out: out n13.Spread<string> Description_3, Is_Up_Out: out n13.Spread<bool> Is_Up_4);
            n14._Operations_.Contains<string>(Input_In: Address_1, Item_In: Server_Address_In, Result_Out: out bool Result_6);
            var Output_7 = !Result_6;
            var Output_8 = Output_7 && Enabled_In;
            var Output_9 = Result_6 && Enabled_In;
            var Output_12 = this.__p_JlphjIj32XiOmRpdn3UVIQ.Update(Local_Address_In: Server_Address_In, Local_Port_In: Port_In, Enabled_In: Output_9, Socket_is_Open_Out: out bool Socket_is_Open_10, On_Data_Out: out bool On_Data_11);
            string Local_Address_13 = "0.0.0.0";
            var Output_16 = this.__p_SnIvQyUgiJLLvgcbG1YLB0.Update(Local_Address_In: Local_Address_13, Local_Port_In: Port_In, Remote_Address_In: Server_Address_In, Remote_Port_In: Port_In, Constant_Offset_In: Constant_Offset_In, Seek_Threshold_In: Seek_Threshold_In, Enabled_In: Output_8, Socket_is_Open_Out: out bool Socket_is_Open_14, On_Data_Out: out bool On_Data_15);
            int Index_17 = n3.Convert.ToInt32(Result_6);
            var builder_18 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ, 2);
            builder_18.Add(Socket_is_Open_14);
            builder_18.Add(Socket_is_Open_10);
            var __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ_19 = builder_18.Commit();
            n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_17, Input_In: __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ_19, Output_Out: out bool Output_20);
            int Index_21 = n3.Convert.ToInt32(Result_6);
            var builder_22 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN, 2);
            builder_22.Add(On_Data_15);
            builder_22.Add(On_Data_11);
            var __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN_23 = builder_22.Commit();
            n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_21, Input_In: __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN_23, Output_Out: out bool Output_24);
            int Index_25 = n3.Convert.ToInt32(Result_6);
            n2.ITimeSync_I Input_26 = (n2.ITimeSync_I)Output_16;
            n2.ITimeSync_I Input_2_27 = (n2.ITimeSync_I)Output_12;
            var builder_28 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB, 2);
            builder_28.Add(Input_26);
            builder_28.Add(Input_2_27);
            var __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB_29 = builder_28.Commit();
            n31._Operations_.Switch<n2.ITimeSync_I, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_25, Input_In: __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB_29, Output_Out: out n2.ITimeSync_I Output_30);
            Output_Out = Output_30;
            Socket_is_Open_Out = Output_20;
            On_Data_Out = Output_24;
            n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = Output_5 != this.__p_VdrbOl2TfXVOXPpFR2XPYo || Output_12 != this.__p_JlphjIj32XiOmRpdn3UVIQ || Output_16 != this.__p_SnIvQyUgiJLLvgcbG1YLB0 || __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ_19 != this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ || __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN_23 != this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN || __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB_29 != this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB ? new PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(this)
                {__p_VdrbOl2TfXVOXPpFR2XPYo = Output_5, __p_JlphjIj32XiOmRpdn3UVIQ = Output_12, __p_SnIvQyUgiJLLvgcbG1YLB0 = Output_16, __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ_19, __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN_23, __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB_29} : that_31;
            else
            {
                this.__p_VdrbOl2TfXVOXPpFR2XPYo = Output_5;
                this.__p_JlphjIj32XiOmRpdn3UVIQ = Output_12;
                this.__p_SnIvQyUgiJLLvgcbG1YLB0 = Output_16;
                this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ_19;
                this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN_23;
                this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB_29;
            }

            return that_31;
        }

        public n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "VdrbOl2TfXVOXPpFR2XPYo", 263849U);
            var Output_1 = n42.IPs_SU385Q2zoCqLj1U3xPCyTo.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "SnIvQyUgiJLLvgcbG1YLB0", 263864U);
            n10.IFrameClock Frame_Clock_3 = n35._Operations_.CreateDefault();
            var Output_4 = n2.PlayerSyncClient_C.Create(Node_Context: Node_Context_2, Frame_Clock_In: Frame_Clock_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "JlphjIj32XiOmRpdn3UVIQ", 263881U);
            var Output_6 = n2.PlayerSyncServer_C.Create(Node_Context: Node_Context_5);
            n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ that_7 = this;
            this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = n14._Operations_.CreateDefault<n2.ITimeSync_I>();
            this.__p_VdrbOl2TfXVOXPpFR2XPYo = Output_1;
            this.__p_SnIvQyUgiJLLvgcbG1YLB0 = Output_4;
            this.__p_JlphjIj32XiOmRpdn3UVIQ = Output_6;
            return that_7;
        }

        public n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ __CreateDefault__()
        {
            n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ that_0 = this;
            this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = n14._Operations_.CreateDefault<n2.ITimeSync_I>();
            this.__p_VdrbOl2TfXVOXPpFR2XPYo = n42.IPs_SU385Q2zoCqLj1U3xPCyTo.CreateDefault();
            this.__p_JlphjIj32XiOmRpdn3UVIQ = n2.PlayerSyncServer_C.CreateDefault();
            this.__p_SnIvQyUgiJLLvgcbG1YLB0 = n2.PlayerSyncClient_C.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VdrbOl2TfXVOXPpFR2XPYo);
            n1.CompilationHelper.SafeDispose(this.__p_JlphjIj32XiOmRpdn3UVIQ);
            n1.CompilationHelper.SafeDispose(this.__p_SnIvQyUgiJLLvgcbG1YLB0);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 263849U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "VdrbOl2TfXVOXPpFR2XPYo", Name = "IPs", IsManaged = true, IsAutoGenerated = true)]
        public n42.IPs_SU385Q2zoCqLj1U3xPCyTo __p_VdrbOl2TfXVOXPpFR2XPYo;
        [n1.ElementAttribute(TracingId = 263881U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JlphjIj32XiOmRpdn3UVIQ", Name = "PlayerSyncServer", IsManaged = true, IsAutoGenerated = true)]
        public n2.PlayerSyncServer_C __p_JlphjIj32XiOmRpdn3UVIQ;
        [n1.ElementAttribute(TracingId = 263864U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SnIvQyUgiJLLvgcbG1YLB0", Name = "PlayerSyncClient", IsManaged = true, IsAutoGenerated = true)]
        public n2.PlayerSyncClient_C __p_SnIvQyUgiJLLvgcbG1YLB0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<bool> __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = default(n13.Spread<bool>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<bool> __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = default(n13.Spread<bool>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<n2.ITimeSync_I> __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = default(n13.Spread<n2.ITimeSync_I>);
        public PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ other): base(other)
        {
            this.__p_VdrbOl2TfXVOXPpFR2XPYo = other.__p_VdrbOl2TfXVOXPpFR2XPYo;
            this.__p_JlphjIj32XiOmRpdn3UVIQ = other.__p_JlphjIj32XiOmRpdn3UVIQ;
            this.__p_SnIvQyUgiJLLvgcbG1YLB0 = other.__p_SnIvQyUgiJLLvgcbG1YLB0;
            this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = other.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ;
            this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = other.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN;
            this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = other.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VdrbOl2TfXVOXPpFR2XPYo", in __p_VdrbOl2TfXVOXPpFR2XPYo), n1.CompilationHelper.GetValueOrExisting(values, "__p_JlphjIj32XiOmRpdn3UVIQ", in __p_JlphjIj32XiOmRpdn3UVIQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_SnIvQyUgiJLLvgcbG1YLB0", in __p_SnIvQyUgiJLLvgcbG1YLB0), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ", in __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN", in __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB", in __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB));
        }

        internal PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ __WITH__(n42.IPs_SU385Q2zoCqLj1U3xPCyTo __p_VdrbOl2TfXVOXPpFR2XPYo, n2.PlayerSyncServer_C __p_JlphjIj32XiOmRpdn3UVIQ, n2.PlayerSyncClient_C __p_SnIvQyUgiJLLvgcbG1YLB0, n13.Spread<bool> __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ, n13.Spread<bool> __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN, n13.Spread<n2.ITimeSync_I> __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB)
        {
            n2.PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VdrbOl2TfXVOXPpFR2XPYo != this.__p_VdrbOl2TfXVOXPpFR2XPYo || __p_JlphjIj32XiOmRpdn3UVIQ != this.__p_JlphjIj32XiOmRpdn3UVIQ || __p_SnIvQyUgiJLLvgcbG1YLB0 != this.__p_SnIvQyUgiJLLvgcbG1YLB0 || __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ != this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ || __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN != this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN || __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB != this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB ? new PlayerSyncer_HfYySC7nO7LOHxULI6wAtJ(this)
                {__p_VdrbOl2TfXVOXPpFR2XPYo = __p_VdrbOl2TfXVOXPpFR2XPYo, __p_JlphjIj32XiOmRpdn3UVIQ = __p_JlphjIj32XiOmRpdn3UVIQ, __p_SnIvQyUgiJLLvgcbG1YLB0 = __p_SnIvQyUgiJLLvgcbG1YLB0, __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ, __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN, __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB} : that_0;
            else
            {
                this.__p_VdrbOl2TfXVOXPpFR2XPYo = __p_VdrbOl2TfXVOXPpFR2XPYo;
                this.__p_JlphjIj32XiOmRpdn3UVIQ = __p_JlphjIj32XiOmRpdn3UVIQ;
                this.__p_SnIvQyUgiJLLvgcbG1YLB0 = __p_SnIvQyUgiJLLvgcbG1YLB0;
                this.__pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ = __pin_group_Input_In_Sd1VdNGgzEJPnkFKyokvPJ;
                this.__pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN = __pin_group_Input_In_VGcke9xOXBwMqr5jbO6FcN;
                this.__pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB = __pin_group_Input_In_S8vZCKFdoazPUKjwsCE5HB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 264050U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "OmKl4fDMiuqMGR5Nlq7wjB", Name = "FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB")]
    [n3.SerializableAttribute]
    public class FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB Create(n1.NodeContext Node_Context)
        {
            var instance = new FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB CreateDefault()
        {
            var instance = new FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB Update([n4.SerializedDefaultValueAttribute("1", false)] int Frame_Increment_In, [n4.SerializedDefaultValueAttribute("1", false)] int Increment_every_Nth_frame_In, bool Loop_In, int Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Loop_To_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Seek_In, int Seek_Frame_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_Server_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Clients_Address_In, [n4.SerializedDefaultValueAttribute("7777", false)] int Clients_Port_In, [n4.SerializedDefaultValueAttribute("3", false)] int Network_reliability_threshold_In, [n4.SerializedDefaultValueAttribute("1", false)] float Offset_tolerance_threshold_In, out int Frame_Id_Out, out int Loop_From_Out, out int Loop_To_Out, out n13.Spread<int> Seek_Frame_Out, out int Frame_Increment_Out, out bool Network_is_reliable_Out, out int Offset_to_server_Out, out bool On_Adapt_to_server_Out)
        {
            string __pad_HF8S4hC3sy3M5L8l6HOyf0_0 = __slot_HF8S4hC3sy3M5L8l6HOyf0;
            var Result_1 = Clients_Address_In != __pad_HF8S4hC3sy3M5L8l6HOyf0_0;
            int __auto_2;
            bool __auto_3;
            int __auto_4;
            int __auto_5;
            int __auto_6;
            bool __auto_7;
            int __auto_8;
            var state_9 = n1.CompilationHelper.Restore<__DNckTKBPUDhLALYUMegKao>(this.__if_P6JVDwfgjKcPndWj7fH1XP, __GetContext__());
            if (Is_Server_In)
            {
                if (state_9 == null)
                {
                    state_9 = new __DNckTKBPUDhLALYUMegKao(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Force_10 = false;
                bool Dispose_Cached_Outputs_11 = false;
                var manager_12 = state_9.__cache_TyTxzAT2n1VMyNwcSHgL4U;
                if (manager_12 is null)
                {
                    manager_12 = new n6.Manager<n3.ValueTuple<int, bool, int, int, int, bool, int>, n3.ValueTuple<int, bool, int, int, int, bool, int>>((0, false, 0, 0, 0, false, 0));
                }

                var inputs_13 = (Frame_Increment_In, Loop_In, Loop_From_In, Loop_To_In, Seek_Frame_In, Seek_In, Increment_every_Nth_frame_In);
                var outputs_14 = manager_12.Outputs;
                var Has_Changed_15 = Force_10 || manager_12.InputsChanged(inputs_13);
                if (Has_Changed_15)
                {
                    if (Dispose_Cached_Outputs_11)
                        manager_12.DisposeOutputs();
                    var state_16 = n1.CompilationHelper.Restore<__Go8XytudtFJPdKzQBm8ODx>(manager_12.State, __GetContext__());
                    if (state_16 == null)
                    {
                        state_16 = new __Go8XytudtFJPdKzQBm8ODx(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = n14._Operations_.CreateDefault<int>()};
                        n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Vwx6I3MeBmlPKVLvW1g8fK", 264178U);
                        var Output_18 = n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8.Create(Node_Context: Node_Context_17);
                        state_16.__p_Vwx6I3MeBmlPKVLvW1g8fK = Output_18;
                    }

                    int Input_2_19 = 0;
                    var Result_20 = Loop_To_In >= Input_2_19;
                    int Index_21 = n3.Convert.ToInt32(Result_20);
                    var Max_Value_22 = int.MaxValue;
                    var builder_23 = n4.CollectionBuilders.GetBuilder(state_16.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9, 2);
                    builder_23.Add(Max_Value_22);
                    builder_23.Add(Loop_To_In);
                    var __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9_24 = builder_23.Commit();
                    n31._Operations_.Switch<int, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_21, Input_In: __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9_24, Output_Out: out int Output_25);
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "MZICuGNsEMeO0dQnyJ0ETd", 264213U);
                    var Output_27 = n44.FrameController_R.Create(Node_Context: Node_Context_26, Frame_Increment_In: Frame_Increment_In, Loop_In: Loop_In, Loop_From_In: Loop_From_In, Loop_To_In: Output_25, Seek_Frame_In: Seek_Frame_In, Seek_In: Seek_In, Increment_every_Nth_frame_In: Increment_every_Nth_frame_In);
                    bool Force_Little_Endian_28 = false;
                    n24._Operations_.Serialize_Binary<n44.FrameController_R>(Value_In: Output_27, Force_Little_Endian_In: Force_Little_Endian_28, Result_Out: out byte[] Result_29);
                    n11.IEnumerable<byte> Input_30 = (n11.IEnumerable<byte>)Result_29;
                    bool Send_31 = true;
                    var Output_33 = state_16.__p_Vwx6I3MeBmlPKVLvW1g8fK.Update(Input_In: Input_30, Send_In: Send_31, Remote_Address_In: Clients_Address_In, Remote_Port_In: Clients_Port_In, Enabled_In: Result_1, Is_Open_Out: out bool Is_Open_32);
                    if (state_16.__GetContext__().IsImmutable)
                        state_16 = __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9_24 != state_16.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 || Output_33 != state_16.__p_Vwx6I3MeBmlPKVLvW1g8fK ? new __Go8XytudtFJPdKzQBm8ODx(state_16)
                        {__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9_24, __p_Vwx6I3MeBmlPKVLvW1g8fK = Output_33} : state_16;
                    else
                    {
                        state_16.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9_24;
                        state_16.__p_Vwx6I3MeBmlPKVLvW1g8fK = Output_33;
                    }

                    outputs_14 = (Frame_Increment_In, Loop_In, Loop_From_In, Output_25, Seek_Frame_In, Seek_In, Increment_every_Nth_frame_In);
                    manager_12 = manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11, state_16, outputs_14);
                }
                else
                {
                    manager_12.Update(inputs_13, __GetContext__().IsImmutable, Dispose_Cached_Outputs_11);
                }

                var(__auto_34, __auto_35, __auto_36, __auto_37, __auto_38, __auto_39, __auto_40) = outputs_14;
                __auto_2 = __auto_34;
                __auto_3 = __auto_35;
                __auto_4 = __auto_36;
                __auto_5 = __auto_37;
                __auto_6 = __auto_38;
                __auto_7 = __auto_39;
                __auto_8 = __auto_40;
                if (state_9.__GetContext__().IsImmutable)
                    state_9 = manager_12 != state_9.__cache_TyTxzAT2n1VMyNwcSHgL4U ? new __DNckTKBPUDhLALYUMegKao(state_9)
                    {__cache_TyTxzAT2n1VMyNwcSHgL4U = manager_12} : state_9;
                else
                {
                    state_9.__cache_TyTxzAT2n1VMyNwcSHgL4U = manager_12;
                }
            }
            else
            {
                __auto_2 = Frame_Increment_In;
                __auto_3 = Loop_In;
                __auto_4 = Loop_From_In;
                __auto_5 = Loop_To_In;
                __auto_6 = Seek_Frame_In;
                __auto_7 = Seek_In;
                __auto_8 = Increment_every_Nth_frame_In;
            }

            var Output_41 = !Is_Server_In;
            int Input_2_42 = 0;
            var Result_43 = __auto_8 > Input_2_42;
            int Index_44 = n3.Convert.ToInt32(Result_43);
            var Output_45 = n19.Integer32Extensions.Dec(input: __auto_8);
            bool Set_46 = true;
            bool Retriggerable_47 = false;
            bool Reset_48 = false;
            var Output_51 = this.__p_DXqKx60TqYlQW8j8vNwWgY.Update(Set_In: Set_46, Frames_In: Output_45, Retriggerable_In: Retriggerable_47, Reset_In: Reset_48, Value_Out: out bool Value_49, Inverse_Output_Out: out bool Inverse_Output_50);
            bool Input_52 = false;
            var builder_53 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj, 2);
            builder_53.Add(Input_52);
            builder_53.Add(Inverse_Output_50);
            var __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj_54 = builder_53.Commit();
            n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_44, Input_In: __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj_54, Output_Out: out bool Output_55);
            bool Down_56 = false;
            var Output_58 = this.__p_EvSVBE5ywVyPhowpCxvaXz.Update(Loop_In: __auto_3, Increment_In: __auto_2, Default_In: __auto_6, Minimum_In: __auto_4, Maximum_In: __auto_5, Up_In: Output_55, Reset_In: __auto_7, Down_In: Down_56, Value_Out: out int Value_57);
            int __auto_59;
            int FI_60;
            int LF_61;
            int LT_62;
            bool __auto_63;
            int S_64;
            int __auto_65;
            bool __auto_66;
            var state_67 = n1.CompilationHelper.Restore<__Sgf1l81EKG0LTb0CCW19Fi>(this.__if_CBy5SrB1ojgNDyYbE0pujW, __GetContext__());
            if (Output_41)
            {
                if (state_67 == null)
                {
                    state_67 = new __Sgf1l81EKG0LTb0CCW19Fi(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = n14._Operations_.CreateDefault<int>(), __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = n14._Operations_.CreateDefault<bool>()};
                    n1.NodeContext Node_Context_68 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "GtVRCXyeAc2QHxBawmjiKm", 264276U);
                    var Output_69 = n43.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw.Create(Node_Context: Node_Context_68);
                    state_67.__p_GtVRCXyeAc2QHxBawmjiKm = Output_69;
                    n1.NodeContext Node_Context_70 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "SaIf3eueCogOVdf3HESZw8", 264286U);
                    n20._Operations_.Create_H<n3.Object, n7.Datagram, n44.FrameController_R>(Node_Context: Node_Context_70, Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n44.FrameController_R> Output_71);
                    state_67.__p_SaIf3eueCogOVdf3HESZw8 = Output_71;
                    n1.NodeContext Node_Context_72 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "UFYahnbv4oZLKi2IqJmtCX", 264557U);
                    int Frame_Increment_73 = 1;
                    bool Loop_74 = false;
                    int Loop_From_75 = 0;
                    int Loop_To_76 = -1;
                    int Seek_Frame_77 = 0;
                    bool Seek_78 = false;
                    int Increment_every_Nth_frame_79 = 1;
                    var Output_80 = n44.FrameController_R.Create(Node_Context: Node_Context_72, Frame_Increment_In: Frame_Increment_73, Loop_In: Loop_74, Loop_From_In: Loop_From_75, Loop_To_In: Loop_To_76, Seek_Frame_In: Seek_Frame_77, Seek_In: Seek_78, Increment_every_Nth_frame_In: Increment_every_Nth_frame_79);
                    n1.NodeContext Node_Context_81 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Tlq6T13bYhvPJGj1vAWQsv", 264364U);
                    n9._Operations_.Create_H<n44.FrameController_R>(Node_Context: Node_Context_81, Initial_Result_In: Output_80, Output_Out: out n8.HoldLatest<n44.FrameController_R> Output_82);
                    state_67.__p_Tlq6T13bYhvPJGj1vAWQsv = Output_82;
                    n1.NodeContext Node_Context_83 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "DcQCdVxkGjhLh2trZFqGIF", 264375U);
                    n10.IClock Clock_84 = n45._Operations_.CreateDefault();
                    var Output_85 = n31.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.Create(Node_Context: Node_Context_83, Clock_In: Clock_84);
                    state_67.__p_DcQCdVxkGjhLh2trZFqGIF = Output_85;
                    n1.NodeContext Node_Context_86 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "Da99mgzRX2qNVBahXHFubB", 264417U);
                    bool Initial_Value_87 = false;
                    var Output_88 = n31.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.Create(Node_Context: Node_Context_86, Initial_Value_In: Initial_Value_87);
                    state_67.__p_Da99mgzRX2qNVBahXHFubB = Output_88;
                    n1.NodeContext Node_Context_89 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "LIJmXe1spfxMAtiojnGt3u", 264428U);
                    n20._Operations_.Create_H<n3.Object, n7.Datagram, int>(Node_Context: Node_Context_89, Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, int> Output_90);
                    state_67.__p_LIJmXe1spfxMAtiojnGt3u = Output_90;
                    n1.NodeContext Node_Context_91 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "LIBUJoWzI2FNE8HhYLybCz", 264490U);
                    int Initial_Result_92 = 0;
                    n9._Operations_.Create_H<int>(Node_Context: Node_Context_91, Initial_Result_In: Initial_Result_92, Output_Out: out n8.HoldLatest<int> Output_93);
                    state_67.__p_LIBUJoWzI2FNE8HhYLybCz = Output_93;
                    n1.NodeContext Node_Context_94 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "FDVsO36tXtoLQqUHxyMX8I", 264501U);
                    var Output_95 = n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_94);
                    state_67.__p_FDVsO36tXtoLQqUHxyMX8I = Output_95;
                    n1.NodeContext Node_Context_96 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "UIAH4tGfHciMRk7nMgriGF", 264575U);
                    var Output_97 = n31.Trigger_FrameBased_MqVqfX7Noi8Ovoy2ns8zSI.Create(Node_Context: Node_Context_96);
                    state_67.__p_UIAH4tGfHciMRk7nMgriGF = Output_97;
                    n1.NodeContext Node_Context_98 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "MvAJw8rl6s3PgIXwKWf10U", 264590U);
                    var Output_99 = n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p.Create(Node_Context: Node_Context_98);
                    state_67.__p_MvAJw8rl6s3PgIXwKWf10U = Output_99;
                    n1.NodeContext Node_Context_100 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "JAzk95zaJnrNsV3FaDoVb8", 264604U);
                    var Output_101 = n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_100);
                    state_67.__p_JAzk95zaJnrNsV3FaDoVb8 = Output_101;
                }

                string Local_Address_102 = "0.0.0.0";
                string Multicast_Address_103 = "0.0.0.0";
                var Output_106 = state_67.__p_GtVRCXyeAc2QHxBawmjiKm.Update(Local_Address_In: Local_Address_102, Local_Port_In: Clients_Port_In, Multicast_Address_In: Multicast_Address_103, Datagrams_Out: out n3.IObservable<n7.Datagram> Datagrams_104, Is_Open_Out: out bool Is_Open_105);
                bool Reset_107 = false;
                var __fallback___108 = n1.ServiceRegistry.Current;
                n20._Operations_.Update_H<n3.Object, n7.Datagram, n44.FrameController_R>(Input_In: state_67.__p_SaIf3eueCogOVdf3HESZw8, Messages_In: Datagrams_104, Reset_In: Reset_107, Update_In: (n3.Object s_111, n7.Datagram Input_1_In_112) =>
                {
                    using var __current_109 = __fallback___108.MakeCurrentIfNone();
                    var state_110 = n1.CompilationHelper.Restore<__PNGv3UeoCQALBRcEURj0Gv>(s_111, __GetContext__());
                    int __pad_Vj1EDFYvx3MQK5xLsTc2us_113 = __slot_Vj1EDFYvx3MQK5xLsTc2us;
                    Input_1_In_112.Split(remoteEndPoint: out n5.IPEndPoint Remote_End_Point_114, payload: out n13.Spread<byte> Payload_115);
                    n14._Operations_.Count<byte>(Input_In: Payload_115, Count_Out: out int Count_116);
                    var Result_117 = Count_116 > __pad_Vj1EDFYvx3MQK5xLsTc2us_113;
                    n11.IEnumerable<byte> Input_118 = (n11.IEnumerable<byte>)Payload_115;
                    n44.FrameController_R __auto_119;
                    if (Result_117)
                    {
                        n34._Operations_.FromSequence<byte>(Input_In: Input_118, Result_Out: out byte[] Result_121);
                        bool Force_Little_Endian_122 = false;
                        n24._Operations_.Deserialize_Binary<n44.FrameController_R>(Serialized_Value_In: Result_121, Force_Little_Endian_In: Force_Little_Endian_122, Result_Out: out n44.FrameController_R Result_123);
                        __auto_119 = Result_123;
                    }
                    else
                    {
                        __auto_119 = n44.FrameController_R.CreateDefault();
                    }

                    return n3.Tuple.Create<n3.Object, n44.FrameController_R, bool>(state_110, __auto_119, Result_117);
                }

                , Create_In: () =>
                {
                    using var __current_124 = __fallback___108.MakeCurrentIfNone();
                    var state_110 = new __PNGv3UeoCQALBRcEURj0Gv(__GetContext__(), n1.VLObject.NewIdentity());
                    return state_110;
                }

                , Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, n44.FrameController_R> Output_125, Result_Out: out n3.IObservable<n44.FrameController_R> Result_126);
                bool Reset_127 = false;
                bool Update_128 = true;
                var Output_129 = state_67.__p_Tlq6T13bYhvPJGj1vAWQsv;
                if (Update_128)
                {
                    n9._Operations_.Update_H<n44.FrameController_R>(Input_In: state_67.__p_Tlq6T13bYhvPJGj1vAWQsv, Async_Notifications_In: Result_126, Reset_In: Reset_127, Output_Out: out Output_129);
                }

                n9._Operations_.GetData_H<n44.FrameController_R>(Input_In: Output_129, Output_Out: out n8.HoldLatest<n44.FrameController_R> Output_130, Value_Out: out n44.FrameController_R Value_131, On_Data_Out: out bool On_Data_132);
                bool Reset_133 = false;
                n20._Operations_.Update_H<n3.Object, n7.Datagram, int>(Input_In: state_67.__p_LIJmXe1spfxMAtiojnGt3u, Messages_In: Datagrams_104, Reset_In: Reset_133, Update_In: (n3.Object s_136, n7.Datagram Input_1_In_137) =>
                {
                    using var __current_134 = __fallback___108.MakeCurrentIfNone();
                    var state_135 = n1.CompilationHelper.Restore<__JctcIFMkV1lO6J6fqlgvwP>(s_136, __GetContext__());
                    int __pad_ES7CkNdJ2WxMx3seBT0auL_138 = __slot_ES7CkNdJ2WxMx3seBT0auL;
                    Input_1_In_137.Split(remoteEndPoint: out n5.IPEndPoint Remote_End_Point_139, payload: out n13.Spread<byte> Payload_140);
                    n14._Operations_.Count<byte>(Input_In: Payload_140, Count_Out: out int Count_141);
                    var Result_142 = Count_141 == __pad_ES7CkNdJ2WxMx3seBT0auL_138;
                    int Start_Index_143 = 0;
                    bool Input_Is_Big_Endian_144 = false;
                    var Result_145 = n19.BinaryUtils.ToInt32(input: Payload_140, startIndex: Start_Index_143, inputIsBigEndian: Input_Is_Big_Endian_144);
                    return n3.Tuple.Create<n3.Object, int, bool>(state_135, Result_145, Result_142);
                }

                , Create_In: () =>
                {
                    using var __current_146 = __fallback___108.MakeCurrentIfNone();
                    var state_135 = new __JctcIFMkV1lO6J6fqlgvwP(__GetContext__(), n1.VLObject.NewIdentity());
                    return state_135;
                }

                , Output_Out: out n8.ForEachKeep<n3.Object, n7.Datagram, int> Output_147, Result_Out: out n3.IObservable<int> Result_148);
                bool Reset_149 = false;
                bool Update_150 = true;
                var Output_151 = state_67.__p_LIBUJoWzI2FNE8HhYLybCz;
                if (Update_150)
                {
                    n9._Operations_.Update_H<int>(Input_In: state_67.__p_LIBUJoWzI2FNE8HhYLybCz, Async_Notifications_In: Result_148, Reset_In: Reset_149, Output_Out: out Output_151);
                }

                n9._Operations_.GetData_H<int>(Input_In: Output_151, Output_Out: out n8.HoldLatest<int> Output_152, Value_Out: out int Value_153, On_Data_Out: out bool On_Data_154);
                var Output_162 = Value_131.Split(Frame_Increment_Out: out int Frame_Increment_155, Loop_Out: out bool Loop_156, Loop_From_Out: out int Loop_From_157, Loop_To_Out: out int Loop_To_158, Seek_Frame_Out: out int Seek_Frame_159, Seek_Out: out bool Seek_160, Increment_every_Nth_frame_Out: out int Increment_every_Nth_frame_161);
                int Index_163 = n3.Convert.ToInt32(On_Data_132);
                var builder_164 = n4.CollectionBuilders.GetBuilder(state_67.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV, 2);
                builder_164.Add(Value_153);
                builder_164.Add(Seek_Frame_159);
                var __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV_165 = builder_164.Commit();
                n31._Operations_.Switch<int, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_163, Input_In: __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV_165, Output_Out: out int Output_166);
                int Input_2_167 = 0;
                var Result_168 = Increment_every_Nth_frame_161 > Input_2_167;
                int Index_169 = n3.Convert.ToInt32(Result_168);
                var Output_170 = n19.Integer32Extensions.Dec(input: Increment_every_Nth_frame_161);
                bool Set_171 = true;
                bool Retriggerable_172 = false;
                bool Reset_173 = false;
                var Output_176 = state_67.__p_JAzk95zaJnrNsV3FaDoVb8.Update(Set_In: Set_171, Frames_In: Output_170, Retriggerable_In: Retriggerable_172, Reset_In: Reset_173, Value_Out: out bool Value_174, Inverse_Output_Out: out bool Inverse_Output_175);
                bool Input_177 = false;
                var builder_178 = n4.CollectionBuilders.GetBuilder(state_67.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP, 2);
                builder_178.Add(Input_177);
                builder_178.Add(Inverse_Output_175);
                var __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP_179 = builder_178.Commit();
                n31._Operations_.Switch<bool, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Index_In: Index_169, Input_In: __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP_179, Output_Out: out bool Output_180);
                var Output_182 = state_67.__p_Da99mgzRX2qNVBahXHFubB.GetValue(Value_Out: out bool Value_181);
                var Output_183 = Seek_160 || Value_181;
                bool Down_184 = false;
                var Output_186 = state_67.__p_MvAJw8rl6s3PgIXwKWf10U.Update(Loop_In: Loop_156, Increment_In: Frame_Increment_155, Default_In: Output_166, Minimum_In: Loop_From_157, Maximum_In: Loop_To_158, Up_In: Output_180, Reset_In: Output_183, Down_In: Down_184, Value_Out: out int Value_185);
                LF_61 = Loop_From_157;
                bool Retriggerable_187 = true;
                bool Reset_188 = false;
                var Output_191 = state_67.__p_FDVsO36tXtoLQqUHxyMX8I.Update(Set_In: On_Data_154, Frames_In: Network_reliability_threshold_In, Retriggerable_In: Retriggerable_187, Reset_In: Reset_188, Value_Out: out bool Value_189, Inverse_Output_Out: out bool Inverse_Output_190);
                bool __pad_FSQEksQrR9PQRQJdLDVKAx_192 = Value_189;
                var Output_193 = Value_153 - Value_185;
                var Output_194 = n3.Math.Abs(value: Output_193);
                int Input_2_195 = 0;
                var Result_196 = Output_194 > Input_2_195;
                bool Reset_197 = false;
                var Output_200 = state_67.__p_DcQCdVxkGjhLh2trZFqGIF.Update(Set_In: Result_196, Reset_In: Reset_197, Time_In: Offset_tolerance_threshold_In, Value_Out: out bool Value_198, Running_Out: out float Running_199);
                var Output_201 = Value_198 && Value_189;
                bool Trigger_On_Enable_202 = true;
                int Minimum_Interval_203 = 5;
                int Maximum_Interval_204 = 5;
                var Output_208 = state_67.__p_UIAH4tGfHciMRk7nMgriGF.Update(Enabled_In: Output_201, Trigger_On_Enable_In: Trigger_On_Enable_202, Minimum_Interval_In: Minimum_Interval_203, Maximum_Interval_In: Maximum_Interval_204, Bang_Out: out bool Bang_205, Next_Bang_Countdown_Out: out int Next_Bang_Countdown_206, Current_Interval_Out: out int Current_Interval_207);
                bool SetValue_209 = true;
                var Output_210 = Output_182;
                if (SetValue_209)
                {
                    Output_210 = Output_182.SetValue(Value_In: Bang_205);
                }

                LT_62 = Loop_To_158;
                __auto_59 = Value_185;
                int __pad_JXeFQoSy622OZy1H2Unvge_211 = Value_185;
                int __pad_RxsLwx4hLJZOcAHWc1hhHi_212 = Output_193;
                __auto_65 = Output_193;
                bool __pad_COLsIny0JKcLFGg21ZsKIu_213 = Value_198;
                __auto_63 = Bang_205;
                __auto_66 = Value_189;
                S_64 = Seek_Frame_159;
                FI_60 = Frame_Increment_155;
                if (state_67.__GetContext__().IsImmutable)
                    state_67 = Output_106 != state_67.__p_GtVRCXyeAc2QHxBawmjiKm || Output_125 != state_67.__p_SaIf3eueCogOVdf3HESZw8 || Output_130 != state_67.__p_Tlq6T13bYhvPJGj1vAWQsv || Output_147 != state_67.__p_LIJmXe1spfxMAtiojnGt3u || Output_152 != state_67.__p_LIBUJoWzI2FNE8HhYLybCz || __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV_165 != state_67.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV || Output_176 != state_67.__p_JAzk95zaJnrNsV3FaDoVb8 || __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP_179 != state_67.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP || Output_210 != state_67.__p_Da99mgzRX2qNVBahXHFubB || Output_186 != state_67.__p_MvAJw8rl6s3PgIXwKWf10U || Output_191 != state_67.__p_FDVsO36tXtoLQqUHxyMX8I || Value_189 != state_67.__slot_FSQEksQrR9PQRQJdLDVKAx || Output_200 != state_67.__p_DcQCdVxkGjhLh2trZFqGIF || Output_208 != state_67.__p_UIAH4tGfHciMRk7nMgriGF || Value_185 != state_67.__slot_JXeFQoSy622OZy1H2Unvge || Output_193 != state_67.__slot_RxsLwx4hLJZOcAHWc1hhHi || Value_198 != state_67.__slot_COLsIny0JKcLFGg21ZsKIu ? new __Sgf1l81EKG0LTb0CCW19Fi(state_67)
                    {__p_GtVRCXyeAc2QHxBawmjiKm = Output_106, __p_SaIf3eueCogOVdf3HESZw8 = Output_125, __p_Tlq6T13bYhvPJGj1vAWQsv = Output_130, __p_LIJmXe1spfxMAtiojnGt3u = Output_147, __p_LIBUJoWzI2FNE8HhYLybCz = Output_152, __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV_165, __p_JAzk95zaJnrNsV3FaDoVb8 = Output_176, __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP_179, __p_Da99mgzRX2qNVBahXHFubB = Output_210, __p_MvAJw8rl6s3PgIXwKWf10U = Output_186, __p_FDVsO36tXtoLQqUHxyMX8I = Output_191, __slot_FSQEksQrR9PQRQJdLDVKAx = Value_189, __p_DcQCdVxkGjhLh2trZFqGIF = Output_200, __p_UIAH4tGfHciMRk7nMgriGF = Output_208, __slot_JXeFQoSy622OZy1H2Unvge = Value_185, __slot_RxsLwx4hLJZOcAHWc1hhHi = Output_193, __slot_COLsIny0JKcLFGg21ZsKIu = Value_198} : state_67;
                else
                {
                    state_67.__p_GtVRCXyeAc2QHxBawmjiKm = Output_106;
                    state_67.__p_SaIf3eueCogOVdf3HESZw8 = Output_125;
                    state_67.__p_Tlq6T13bYhvPJGj1vAWQsv = Output_130;
                    state_67.__p_LIJmXe1spfxMAtiojnGt3u = Output_147;
                    state_67.__p_LIBUJoWzI2FNE8HhYLybCz = Output_152;
                    state_67.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV_165;
                    state_67.__p_JAzk95zaJnrNsV3FaDoVb8 = Output_176;
                    state_67.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP_179;
                    state_67.__p_Da99mgzRX2qNVBahXHFubB = Output_210;
                    state_67.__p_MvAJw8rl6s3PgIXwKWf10U = Output_186;
                    state_67.__p_FDVsO36tXtoLQqUHxyMX8I = Output_191;
                    state_67.__slot_FSQEksQrR9PQRQJdLDVKAx = Value_189;
                    state_67.__p_DcQCdVxkGjhLh2trZFqGIF = Output_200;
                    state_67.__p_UIAH4tGfHciMRk7nMgriGF = Output_208;
                    state_67.__slot_JXeFQoSy622OZy1H2Unvge = Value_185;
                    state_67.__slot_RxsLwx4hLJZOcAHWc1hhHi = Output_193;
                    state_67.__slot_COLsIny0JKcLFGg21ZsKIu = Value_198;
                }
            }
            else
            {
                __auto_59 = Value_57;
                FI_60 = __auto_2;
                LF_61 = __auto_4;
                LT_62 = __auto_5;
                __auto_63 = false;
                S_64 = __auto_6;
                __auto_65 = 0;
                __auto_66 = false;
            }

            var Result_214 = n3.BitConverter.GetBytes(value: Value_57);
            n11.IEnumerable<byte> Input_215 = (n11.IEnumerable<byte>)Result_214;
            var Output_218 = this.__p_EB5HC4Por9jPUxE1HuQJcL.Update(Value_In: Value_57, Result_Out: out bool Result_216, Unchanged_Out: out bool Unchanged_217);
            var Output_219 = Result_1 && Is_Server_In;
            var Output_221 = this.__p_IjNpneo9XLsQFBepWfWTNk.Update(Input_In: Input_215, Send_In: Result_216, Remote_Address_In: Clients_Address_In, Remote_Port_In: Clients_Port_In, Enabled_In: Output_219, Is_Open_Out: out bool Is_Open_220);
            var builder_222 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13, 1);
            builder_222.Add(S_64);
            var __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13_223 = builder_222.Commit();
            n14._Operations_.FromValue<int>(Input_In: __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13_223, Result_Out: out n13.Spread<int> Result_224);
            Frame_Id_Out = __auto_59;
            Loop_From_Out = LF_61;
            Loop_To_Out = LT_62;
            Seek_Frame_Out = Result_224;
            Frame_Increment_Out = FI_60;
            Network_is_reliable_Out = __auto_66;
            Offset_to_server_Out = __auto_65;
            On_Adapt_to_server_Out = __auto_63;
            n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB that_225 = this;
            if (this.__GetContext__().IsImmutable)
                that_225 = state_9 != this.__if_P6JVDwfgjKcPndWj7fH1XP || Output_51 != this.__p_DXqKx60TqYlQW8j8vNwWgY || __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj_54 != this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj || Output_58 != this.__p_EvSVBE5ywVyPhowpCxvaXz || state_67 != this.__if_CBy5SrB1ojgNDyYbE0pujW || Output_218 != this.__p_EB5HC4Por9jPUxE1HuQJcL || Output_221 != this.__p_IjNpneo9XLsQFBepWfWTNk || __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13_223 != this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 ? new FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(this)
                {__if_P6JVDwfgjKcPndWj7fH1XP = state_9, __p_DXqKx60TqYlQW8j8vNwWgY = Output_51, __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj_54, __p_EvSVBE5ywVyPhowpCxvaXz = Output_58, __if_CBy5SrB1ojgNDyYbE0pujW = state_67, __p_EB5HC4Por9jPUxE1HuQJcL = Output_218, __p_IjNpneo9XLsQFBepWfWTNk = Output_221, __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13_223} : that_225;
            else
            {
                this.__if_P6JVDwfgjKcPndWj7fH1XP = state_9;
                this.__p_DXqKx60TqYlQW8j8vNwWgY = Output_51;
                this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj_54;
                this.__p_EvSVBE5ywVyPhowpCxvaXz = Output_58;
                this.__if_CBy5SrB1ojgNDyYbE0pujW = state_67;
                this.__p_EB5HC4Por9jPUxE1HuQJcL = Output_218;
                this.__p_IjNpneo9XLsQFBepWfWTNk = Output_221;
                this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13_223;
            }

            return that_225;
        }

        public n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "IjNpneo9XLsQFBepWfWTNk", 264076U);
            var Output_1 = n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "EB5HC4Por9jPUxE1HuQJcL", 264093U);
            bool Changed_On_Create_3 = true;
            var Output_4 = n31.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Node_Context: Node_Context_2, Changed_On_Create_In: Changed_On_Create_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "EvSVBE5ywVyPhowpCxvaXz", 264968U);
            var Output_6 = n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p.Create(Node_Context: Node_Context_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "DXqKx60TqYlQW8j8vNwWgY", 265018U);
            var Output_8 = n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_7);
            n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB that_9 = this;
            this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = n14._Operations_.CreateDefault<int>();
            this.__p_IjNpneo9XLsQFBepWfWTNk = Output_1;
            this.__p_EB5HC4Por9jPUxE1HuQJcL = Output_4;
            this.__p_EvSVBE5ywVyPhowpCxvaXz = Output_6;
            this.__p_DXqKx60TqYlQW8j8vNwWgY = Output_8;
            this.__if_P6JVDwfgjKcPndWj7fH1XP = default(n3.Object);
            this.__if_CBy5SrB1ojgNDyYbE0pujW = default(n3.Object);
            return that_9;
        }

        public n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB __CreateDefault__()
        {
            n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB that_0 = this;
            this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = n14._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = n14._Operations_.CreateDefault<int>();
            this.__if_P6JVDwfgjKcPndWj7fH1XP = default(n3.Object);
            this.__p_DXqKx60TqYlQW8j8vNwWgY = n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.CreateDefault();
            this.__p_EvSVBE5ywVyPhowpCxvaXz = n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p.CreateDefault();
            this.__if_CBy5SrB1ojgNDyYbE0pujW = default(n3.Object);
            this.__p_EB5HC4Por9jPUxE1HuQJcL = n31.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>();
            this.__p_IjNpneo9XLsQFBepWfWTNk = n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_P6JVDwfgjKcPndWj7fH1XP);
            n1.CompilationHelper.SafeDispose(this.__p_DXqKx60TqYlQW8j8vNwWgY);
            n1.CompilationHelper.SafeDispose(this.__p_EvSVBE5ywVyPhowpCxvaXz);
            n1.CompilationHelper.SafeDispose(this.__if_CBy5SrB1ojgNDyYbE0pujW);
            n1.CompilationHelper.SafeDispose(this.__p_EB5HC4Por9jPUxE1HuQJcL);
            n1.CompilationHelper.SafeDispose(this.__p_IjNpneo9XLsQFBepWfWTNk);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 265007U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HF8S4hC3sy3M5L8l6HOyf0", Name = "__slot_HF8S4hC3sy3M5L8l6HOyf0")]
        public static string __slot_HF8S4hC3sy3M5L8l6HOyf0 = "127.0.0.1";
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_P6JVDwfgjKcPndWj7fH1XP;
        [n1.ElementAttribute(TracingId = 265018U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DXqKx60TqYlQW8j8vNwWgY", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
        public n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_DXqKx60TqYlQW8j8vNwWgY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<bool> __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = default(n13.Spread<bool>);
        [n1.ElementAttribute(TracingId = 264968U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EvSVBE5ywVyPhowpCxvaXz", Name = "SyncFrameCounter", IsManaged = true, IsAutoGenerated = true)]
        public n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __p_EvSVBE5ywVyPhowpCxvaXz;
        [n1.ElementAttribute(TracingId = 264328U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Vj1EDFYvx3MQK5xLsTc2us", Name = "__slot_Vj1EDFYvx3MQK5xLsTc2us")]
        public static int __slot_Vj1EDFYvx3MQK5xLsTc2us = 4;
        [n1.ElementAttribute(TracingId = 264477U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ES7CkNdJ2WxMx3seBT0auL", Name = "__slot_ES7CkNdJ2WxMx3seBT0auL")]
        public static int __slot_ES7CkNdJ2WxMx3seBT0auL = 4;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_CBy5SrB1ojgNDyYbE0pujW;
        [n1.ElementAttribute(TracingId = 264093U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "EB5HC4Por9jPUxE1HuQJcL", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n31.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_EB5HC4Por9jPUxE1HuQJcL;
        [n1.ElementAttribute(TracingId = 264076U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "IjNpneo9XLsQFBepWfWTNk", Name = "UdpClient", IsManaged = true, IsAutoGenerated = true)]
        public n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __p_IjNpneo9XLsQFBepWfWTNk;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n13.Spread<int> __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = default(n13.Spread<int>);
        static FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB()
        {
        }

        public FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB other): base(other)
        {
            this.__if_P6JVDwfgjKcPndWj7fH1XP = other.__if_P6JVDwfgjKcPndWj7fH1XP;
            this.__p_DXqKx60TqYlQW8j8vNwWgY = other.__p_DXqKx60TqYlQW8j8vNwWgY;
            this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = other.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj;
            this.__p_EvSVBE5ywVyPhowpCxvaXz = other.__p_EvSVBE5ywVyPhowpCxvaXz;
            this.__if_CBy5SrB1ojgNDyYbE0pujW = other.__if_CBy5SrB1ojgNDyYbE0pujW;
            this.__p_EB5HC4Por9jPUxE1HuQJcL = other.__p_EB5HC4Por9jPUxE1HuQJcL;
            this.__p_IjNpneo9XLsQFBepWfWTNk = other.__p_IjNpneo9XLsQFBepWfWTNk;
            this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = other.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_P6JVDwfgjKcPndWj7fH1XP", in __if_P6JVDwfgjKcPndWj7fH1XP), n1.CompilationHelper.GetValueOrExisting(values, "__p_DXqKx60TqYlQW8j8vNwWgY", in __p_DXqKx60TqYlQW8j8vNwWgY), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj", in __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj), n1.CompilationHelper.GetValueOrExisting(values, "__p_EvSVBE5ywVyPhowpCxvaXz", in __p_EvSVBE5ywVyPhowpCxvaXz), n1.CompilationHelper.GetValueOrExisting(values, "__if_CBy5SrB1ojgNDyYbE0pujW", in __if_CBy5SrB1ojgNDyYbE0pujW), n1.CompilationHelper.GetValueOrExisting(values, "__p_EB5HC4Por9jPUxE1HuQJcL", in __p_EB5HC4Por9jPUxE1HuQJcL), n1.CompilationHelper.GetValueOrExisting(values, "__p_IjNpneo9XLsQFBepWfWTNk", in __p_IjNpneo9XLsQFBepWfWTNk), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13", in __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13));
        }

        internal FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB __WITH__(n3.Object __if_P6JVDwfgjKcPndWj7fH1XP, n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_DXqKx60TqYlQW8j8vNwWgY, n13.Spread<bool> __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj, n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __p_EvSVBE5ywVyPhowpCxvaXz, n3.Object __if_CBy5SrB1ojgNDyYbE0pujW, n31.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_EB5HC4Por9jPUxE1HuQJcL, n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __p_IjNpneo9XLsQFBepWfWTNk, n13.Spread<int> __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13)
        {
            n2.FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_P6JVDwfgjKcPndWj7fH1XP != this.__if_P6JVDwfgjKcPndWj7fH1XP || __p_DXqKx60TqYlQW8j8vNwWgY != this.__p_DXqKx60TqYlQW8j8vNwWgY || __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj != this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj || __p_EvSVBE5ywVyPhowpCxvaXz != this.__p_EvSVBE5ywVyPhowpCxvaXz || __if_CBy5SrB1ojgNDyYbE0pujW != this.__if_CBy5SrB1ojgNDyYbE0pujW || __p_EB5HC4Por9jPUxE1HuQJcL != this.__p_EB5HC4Por9jPUxE1HuQJcL || __p_IjNpneo9XLsQFBepWfWTNk != this.__p_IjNpneo9XLsQFBepWfWTNk || __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 != this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 ? new FramePlayer_OmKl4fDMiuqMGR5Nlq7wjB(this)
                {__if_P6JVDwfgjKcPndWj7fH1XP = __if_P6JVDwfgjKcPndWj7fH1XP, __p_DXqKx60TqYlQW8j8vNwWgY = __p_DXqKx60TqYlQW8j8vNwWgY, __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj, __p_EvSVBE5ywVyPhowpCxvaXz = __p_EvSVBE5ywVyPhowpCxvaXz, __if_CBy5SrB1ojgNDyYbE0pujW = __if_CBy5SrB1ojgNDyYbE0pujW, __p_EB5HC4Por9jPUxE1HuQJcL = __p_EB5HC4Por9jPUxE1HuQJcL, __p_IjNpneo9XLsQFBepWfWTNk = __p_IjNpneo9XLsQFBepWfWTNk, __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13} : that_0;
            else
            {
                this.__if_P6JVDwfgjKcPndWj7fH1XP = __if_P6JVDwfgjKcPndWj7fH1XP;
                this.__p_DXqKx60TqYlQW8j8vNwWgY = __p_DXqKx60TqYlQW8j8vNwWgY;
                this.__pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj = __pin_group_Input_In_CoR8ElFrG04OVAkJMDMHrj;
                this.__p_EvSVBE5ywVyPhowpCxvaXz = __p_EvSVBE5ywVyPhowpCxvaXz;
                this.__if_CBy5SrB1ojgNDyYbE0pujW = __if_CBy5SrB1ojgNDyYbE0pujW;
                this.__p_EB5HC4Por9jPUxE1HuQJcL = __p_EB5HC4Por9jPUxE1HuQJcL;
                this.__p_IjNpneo9XLsQFBepWfWTNk = __p_IjNpneo9XLsQFBepWfWTNk;
                this.__pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13 = __pin_group_Input_In_KDDoRKh7uy2LKlreaVnr13;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DNckTKBPUDhLALYUMegKao", Name = "__DNckTKBPUDhLALYUMegKao")]
        [n3.SerializableAttribute]
        public class __DNckTKBPUDhLALYUMegKao : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_TyTxzAT2n1VMyNwcSHgL4U);
                return;
            }

            [n1.ElementAttribute(TracingId = 264137U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TyTxzAT2n1VMyNwcSHgL4U", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n6.Manager<n3.ValueTuple<int, bool, int, int, int, bool, int>, n3.ValueTuple<int, bool, int, int, int, bool, int>> __cache_TyTxzAT2n1VMyNwcSHgL4U = null;
            public __DNckTKBPUDhLALYUMegKao(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DNckTKBPUDhLALYUMegKao(__DNckTKBPUDhLALYUMegKao other): base(other)
            {
                this.__cache_TyTxzAT2n1VMyNwcSHgL4U = other.__cache_TyTxzAT2n1VMyNwcSHgL4U;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_TyTxzAT2n1VMyNwcSHgL4U", in __cache_TyTxzAT2n1VMyNwcSHgL4U));
            }

            internal __DNckTKBPUDhLALYUMegKao __WITH__(n6.Manager<n3.ValueTuple<int, bool, int, int, int, bool, int>, n3.ValueTuple<int, bool, int, int, int, bool, int>> __cache_TyTxzAT2n1VMyNwcSHgL4U)
            {
                __DNckTKBPUDhLALYUMegKao that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_TyTxzAT2n1VMyNwcSHgL4U != this.__cache_TyTxzAT2n1VMyNwcSHgL4U ? new __DNckTKBPUDhLALYUMegKao(this)
                    {__cache_TyTxzAT2n1VMyNwcSHgL4U = __cache_TyTxzAT2n1VMyNwcSHgL4U} : that_0;
                else
                {
                    this.__cache_TyTxzAT2n1VMyNwcSHgL4U = __cache_TyTxzAT2n1VMyNwcSHgL4U;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Go8XytudtFJPdKzQBm8ODx", Name = "__Go8XytudtFJPdKzQBm8ODx")]
        [n3.SerializableAttribute]
        public class __Go8XytudtFJPdKzQBm8ODx : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Vwx6I3MeBmlPKVLvW1g8fK);
                return;
            }

            [n1.ElementAttribute(TracingId = 264178U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Vwx6I3MeBmlPKVLvW1g8fK", Name = "UdpClient", IsManaged = true, IsAutoGenerated = true)]
            public n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __p_Vwx6I3MeBmlPKVLvW1g8fK;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<int> __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = default(n13.Spread<int>);
            public __Go8XytudtFJPdKzQBm8ODx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Go8XytudtFJPdKzQBm8ODx(__Go8XytudtFJPdKzQBm8ODx other): base(other)
            {
                this.__p_Vwx6I3MeBmlPKVLvW1g8fK = other.__p_Vwx6I3MeBmlPKVLvW1g8fK;
                this.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = other.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vwx6I3MeBmlPKVLvW1g8fK", in __p_Vwx6I3MeBmlPKVLvW1g8fK), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9", in __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9));
            }

            internal __Go8XytudtFJPdKzQBm8ODx __WITH__(n43.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __p_Vwx6I3MeBmlPKVLvW1g8fK, n13.Spread<int> __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9)
            {
                __Go8XytudtFJPdKzQBm8ODx that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Vwx6I3MeBmlPKVLvW1g8fK != this.__p_Vwx6I3MeBmlPKVLvW1g8fK || __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 != this.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 ? new __Go8XytudtFJPdKzQBm8ODx(this)
                    {__p_Vwx6I3MeBmlPKVLvW1g8fK = __p_Vwx6I3MeBmlPKVLvW1g8fK, __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9} : that_0;
                else
                {
                    this.__p_Vwx6I3MeBmlPKVLvW1g8fK = __p_Vwx6I3MeBmlPKVLvW1g8fK;
                    this.__pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9 = __pin_group_Input_In_I7nTx0YU7mMPXdu5yFlMb9;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Sgf1l81EKG0LTb0CCW19Fi", Name = "__Sgf1l81EKG0LTb0CCW19Fi")]
        [n3.SerializableAttribute]
        public class __Sgf1l81EKG0LTb0CCW19Fi : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_GtVRCXyeAc2QHxBawmjiKm);
                n1.CompilationHelper.SafeDispose(this.__p_SaIf3eueCogOVdf3HESZw8);
                n1.CompilationHelper.SafeDispose(this.__p_Tlq6T13bYhvPJGj1vAWQsv);
                n1.CompilationHelper.SafeDispose(this.__p_DcQCdVxkGjhLh2trZFqGIF);
                n1.CompilationHelper.SafeDispose(this.__p_Da99mgzRX2qNVBahXHFubB);
                n1.CompilationHelper.SafeDispose(this.__p_LIJmXe1spfxMAtiojnGt3u);
                n1.CompilationHelper.SafeDispose(this.__p_LIBUJoWzI2FNE8HhYLybCz);
                n1.CompilationHelper.SafeDispose(this.__p_FDVsO36tXtoLQqUHxyMX8I);
                n1.CompilationHelper.SafeDispose(this.__p_UIAH4tGfHciMRk7nMgriGF);
                n1.CompilationHelper.SafeDispose(this.__p_MvAJw8rl6s3PgIXwKWf10U);
                n1.CompilationHelper.SafeDispose(this.__p_JAzk95zaJnrNsV3FaDoVb8);
                return;
            }

            [n1.ElementAttribute(TracingId = 264276U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "GtVRCXyeAc2QHxBawmjiKm", Name = "UdpServer (Reactive)", IsManaged = true, IsAutoGenerated = true)]
            public n43.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __p_GtVRCXyeAc2QHxBawmjiKm;
            [n1.ElementAttribute(TracingId = 264286U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SaIf3eueCogOVdf3HESZw8", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
            public n8.ForEachKeep<n3.Object, n7.Datagram, n44.FrameController_R> __p_SaIf3eueCogOVdf3HESZw8;
            [n1.ElementAttribute(TracingId = 264364U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Tlq6T13bYhvPJGj1vAWQsv", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
            public n8.HoldLatest<n44.FrameController_R> __p_Tlq6T13bYhvPJGj1vAWQsv;
            [n1.ElementAttribute(TracingId = 264375U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "DcQCdVxkGjhLh2trZFqGIF", Name = "TimerFlop", IsManaged = true, IsAutoGenerated = true)]
            public n31.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_DcQCdVxkGjhLh2trZFqGIF;
            [n1.ElementAttribute(TracingId = 264417U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Da99mgzRX2qNVBahXHFubB", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
            public n31.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_Da99mgzRX2qNVBahXHFubB;
            [n1.ElementAttribute(TracingId = 264428U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LIJmXe1spfxMAtiojnGt3u", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
            public n8.ForEachKeep<n3.Object, n7.Datagram, int> __p_LIJmXe1spfxMAtiojnGt3u;
            [n1.ElementAttribute(TracingId = 264490U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LIBUJoWzI2FNE8HhYLybCz", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
            public n8.HoldLatest<int> __p_LIBUJoWzI2FNE8HhYLybCz;
            [n1.ElementAttribute(TracingId = 264501U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FDVsO36tXtoLQqUHxyMX8I", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
            public n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_FDVsO36tXtoLQqUHxyMX8I;
            [n1.ElementAttribute(TracingId = 264575U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "UIAH4tGfHciMRk7nMgriGF", Name = "Trigger (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
            public n31.Trigger_FrameBased_MqVqfX7Noi8Ovoy2ns8zSI __p_UIAH4tGfHciMRk7nMgriGF;
            [n1.ElementAttribute(TracingId = 264590U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "MvAJw8rl6s3PgIXwKWf10U", Name = "SyncFrameCounter", IsManaged = true, IsAutoGenerated = true)]
            public n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __p_MvAJw8rl6s3PgIXwKWf10U;
            [n1.ElementAttribute(TracingId = 264604U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JAzk95zaJnrNsV3FaDoVb8", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
            public n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_JAzk95zaJnrNsV3FaDoVb8;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<int> __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = default(n13.Spread<int>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<bool> __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = default(n13.Spread<bool>);
            [n1.ElementAttribute(TracingId = 264513U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FSQEksQrR9PQRQJdLDVKAx", Name = "__slot_FSQEksQrR9PQRQJdLDVKAx")]
            public bool __slot_FSQEksQrR9PQRQJdLDVKAx;
            [n1.ElementAttribute(TracingId = 264574U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JXeFQoSy622OZy1H2Unvge", Name = "__slot_JXeFQoSy622OZy1H2Unvge")]
            public int __slot_JXeFQoSy622OZy1H2Unvge;
            [n1.ElementAttribute(TracingId = 264409U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RxsLwx4hLJZOcAHWc1hhHi", Name = "__slot_RxsLwx4hLJZOcAHWc1hhHi")]
            public int __slot_RxsLwx4hLJZOcAHWc1hhHi;
            [n1.ElementAttribute(TracingId = 264391U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "COLsIny0JKcLFGg21ZsKIu", Name = "__slot_COLsIny0JKcLFGg21ZsKIu")]
            public bool __slot_COLsIny0JKcLFGg21ZsKIu;
            public __Sgf1l81EKG0LTb0CCW19Fi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Sgf1l81EKG0LTb0CCW19Fi(__Sgf1l81EKG0LTb0CCW19Fi other): base(other)
            {
                this.__p_GtVRCXyeAc2QHxBawmjiKm = other.__p_GtVRCXyeAc2QHxBawmjiKm;
                this.__p_SaIf3eueCogOVdf3HESZw8 = other.__p_SaIf3eueCogOVdf3HESZw8;
                this.__p_Tlq6T13bYhvPJGj1vAWQsv = other.__p_Tlq6T13bYhvPJGj1vAWQsv;
                this.__p_DcQCdVxkGjhLh2trZFqGIF = other.__p_DcQCdVxkGjhLh2trZFqGIF;
                this.__p_Da99mgzRX2qNVBahXHFubB = other.__p_Da99mgzRX2qNVBahXHFubB;
                this.__p_LIJmXe1spfxMAtiojnGt3u = other.__p_LIJmXe1spfxMAtiojnGt3u;
                this.__p_LIBUJoWzI2FNE8HhYLybCz = other.__p_LIBUJoWzI2FNE8HhYLybCz;
                this.__p_FDVsO36tXtoLQqUHxyMX8I = other.__p_FDVsO36tXtoLQqUHxyMX8I;
                this.__p_UIAH4tGfHciMRk7nMgriGF = other.__p_UIAH4tGfHciMRk7nMgriGF;
                this.__p_MvAJw8rl6s3PgIXwKWf10U = other.__p_MvAJw8rl6s3PgIXwKWf10U;
                this.__p_JAzk95zaJnrNsV3FaDoVb8 = other.__p_JAzk95zaJnrNsV3FaDoVb8;
                this.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = other.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV;
                this.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = other.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP;
                this.__slot_FSQEksQrR9PQRQJdLDVKAx = other.__slot_FSQEksQrR9PQRQJdLDVKAx;
                this.__slot_JXeFQoSy622OZy1H2Unvge = other.__slot_JXeFQoSy622OZy1H2Unvge;
                this.__slot_RxsLwx4hLJZOcAHWc1hhHi = other.__slot_RxsLwx4hLJZOcAHWc1hhHi;
                this.__slot_COLsIny0JKcLFGg21ZsKIu = other.__slot_COLsIny0JKcLFGg21ZsKIu;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GtVRCXyeAc2QHxBawmjiKm", in __p_GtVRCXyeAc2QHxBawmjiKm), n1.CompilationHelper.GetValueOrExisting(values, "__p_SaIf3eueCogOVdf3HESZw8", in __p_SaIf3eueCogOVdf3HESZw8), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tlq6T13bYhvPJGj1vAWQsv", in __p_Tlq6T13bYhvPJGj1vAWQsv), n1.CompilationHelper.GetValueOrExisting(values, "__p_DcQCdVxkGjhLh2trZFqGIF", in __p_DcQCdVxkGjhLh2trZFqGIF), n1.CompilationHelper.GetValueOrExisting(values, "__p_Da99mgzRX2qNVBahXHFubB", in __p_Da99mgzRX2qNVBahXHFubB), n1.CompilationHelper.GetValueOrExisting(values, "__p_LIJmXe1spfxMAtiojnGt3u", in __p_LIJmXe1spfxMAtiojnGt3u), n1.CompilationHelper.GetValueOrExisting(values, "__p_LIBUJoWzI2FNE8HhYLybCz", in __p_LIBUJoWzI2FNE8HhYLybCz), n1.CompilationHelper.GetValueOrExisting(values, "__p_FDVsO36tXtoLQqUHxyMX8I", in __p_FDVsO36tXtoLQqUHxyMX8I), n1.CompilationHelper.GetValueOrExisting(values, "__p_UIAH4tGfHciMRk7nMgriGF", in __p_UIAH4tGfHciMRk7nMgriGF), n1.CompilationHelper.GetValueOrExisting(values, "__p_MvAJw8rl6s3PgIXwKWf10U", in __p_MvAJw8rl6s3PgIXwKWf10U), n1.CompilationHelper.GetValueOrExisting(values, "__p_JAzk95zaJnrNsV3FaDoVb8", in __p_JAzk95zaJnrNsV3FaDoVb8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV", in __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP", in __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP), n1.CompilationHelper.GetValueOrExisting(values, "__slot_FSQEksQrR9PQRQJdLDVKAx", in __slot_FSQEksQrR9PQRQJdLDVKAx), n1.CompilationHelper.GetValueOrExisting(values, "__slot_JXeFQoSy622OZy1H2Unvge", in __slot_JXeFQoSy622OZy1H2Unvge), n1.CompilationHelper.GetValueOrExisting(values, "__slot_RxsLwx4hLJZOcAHWc1hhHi", in __slot_RxsLwx4hLJZOcAHWc1hhHi), n1.CompilationHelper.GetValueOrExisting(values, "__slot_COLsIny0JKcLFGg21ZsKIu", in __slot_COLsIny0JKcLFGg21ZsKIu));
            }

            internal __Sgf1l81EKG0LTb0CCW19Fi __WITH__(n43.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __p_GtVRCXyeAc2QHxBawmjiKm, n8.ForEachKeep<n3.Object, n7.Datagram, n44.FrameController_R> __p_SaIf3eueCogOVdf3HESZw8, n8.HoldLatest<n44.FrameController_R> __p_Tlq6T13bYhvPJGj1vAWQsv, n31.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_DcQCdVxkGjhLh2trZFqGIF, n31.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_Da99mgzRX2qNVBahXHFubB, n8.ForEachKeep<n3.Object, n7.Datagram, int> __p_LIJmXe1spfxMAtiojnGt3u, n8.HoldLatest<int> __p_LIBUJoWzI2FNE8HhYLybCz, n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_FDVsO36tXtoLQqUHxyMX8I, n31.Trigger_FrameBased_MqVqfX7Noi8Ovoy2ns8zSI __p_UIAH4tGfHciMRk7nMgriGF, n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __p_MvAJw8rl6s3PgIXwKWf10U, n31.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_JAzk95zaJnrNsV3FaDoVb8, n13.Spread<int> __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV, n13.Spread<bool> __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP, bool __slot_FSQEksQrR9PQRQJdLDVKAx, int __slot_JXeFQoSy622OZy1H2Unvge, int __slot_RxsLwx4hLJZOcAHWc1hhHi, bool __slot_COLsIny0JKcLFGg21ZsKIu)
            {
                __Sgf1l81EKG0LTb0CCW19Fi that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_GtVRCXyeAc2QHxBawmjiKm != this.__p_GtVRCXyeAc2QHxBawmjiKm || __p_SaIf3eueCogOVdf3HESZw8 != this.__p_SaIf3eueCogOVdf3HESZw8 || __p_Tlq6T13bYhvPJGj1vAWQsv != this.__p_Tlq6T13bYhvPJGj1vAWQsv || __p_DcQCdVxkGjhLh2trZFqGIF != this.__p_DcQCdVxkGjhLh2trZFqGIF || __p_Da99mgzRX2qNVBahXHFubB != this.__p_Da99mgzRX2qNVBahXHFubB || __p_LIJmXe1spfxMAtiojnGt3u != this.__p_LIJmXe1spfxMAtiojnGt3u || __p_LIBUJoWzI2FNE8HhYLybCz != this.__p_LIBUJoWzI2FNE8HhYLybCz || __p_FDVsO36tXtoLQqUHxyMX8I != this.__p_FDVsO36tXtoLQqUHxyMX8I || __p_UIAH4tGfHciMRk7nMgriGF != this.__p_UIAH4tGfHciMRk7nMgriGF || __p_MvAJw8rl6s3PgIXwKWf10U != this.__p_MvAJw8rl6s3PgIXwKWf10U || __p_JAzk95zaJnrNsV3FaDoVb8 != this.__p_JAzk95zaJnrNsV3FaDoVb8 || __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV != this.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV || __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP != this.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP || __slot_FSQEksQrR9PQRQJdLDVKAx != this.__slot_FSQEksQrR9PQRQJdLDVKAx || __slot_JXeFQoSy622OZy1H2Unvge != this.__slot_JXeFQoSy622OZy1H2Unvge || __slot_RxsLwx4hLJZOcAHWc1hhHi != this.__slot_RxsLwx4hLJZOcAHWc1hhHi || __slot_COLsIny0JKcLFGg21ZsKIu != this.__slot_COLsIny0JKcLFGg21ZsKIu ? new __Sgf1l81EKG0LTb0CCW19Fi(this)
                    {__p_GtVRCXyeAc2QHxBawmjiKm = __p_GtVRCXyeAc2QHxBawmjiKm, __p_SaIf3eueCogOVdf3HESZw8 = __p_SaIf3eueCogOVdf3HESZw8, __p_Tlq6T13bYhvPJGj1vAWQsv = __p_Tlq6T13bYhvPJGj1vAWQsv, __p_DcQCdVxkGjhLh2trZFqGIF = __p_DcQCdVxkGjhLh2trZFqGIF, __p_Da99mgzRX2qNVBahXHFubB = __p_Da99mgzRX2qNVBahXHFubB, __p_LIJmXe1spfxMAtiojnGt3u = __p_LIJmXe1spfxMAtiojnGt3u, __p_LIBUJoWzI2FNE8HhYLybCz = __p_LIBUJoWzI2FNE8HhYLybCz, __p_FDVsO36tXtoLQqUHxyMX8I = __p_FDVsO36tXtoLQqUHxyMX8I, __p_UIAH4tGfHciMRk7nMgriGF = __p_UIAH4tGfHciMRk7nMgriGF, __p_MvAJw8rl6s3PgIXwKWf10U = __p_MvAJw8rl6s3PgIXwKWf10U, __p_JAzk95zaJnrNsV3FaDoVb8 = __p_JAzk95zaJnrNsV3FaDoVb8, __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV, __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP, __slot_FSQEksQrR9PQRQJdLDVKAx = __slot_FSQEksQrR9PQRQJdLDVKAx, __slot_JXeFQoSy622OZy1H2Unvge = __slot_JXeFQoSy622OZy1H2Unvge, __slot_RxsLwx4hLJZOcAHWc1hhHi = __slot_RxsLwx4hLJZOcAHWc1hhHi, __slot_COLsIny0JKcLFGg21ZsKIu = __slot_COLsIny0JKcLFGg21ZsKIu} : that_0;
                else
                {
                    this.__p_GtVRCXyeAc2QHxBawmjiKm = __p_GtVRCXyeAc2QHxBawmjiKm;
                    this.__p_SaIf3eueCogOVdf3HESZw8 = __p_SaIf3eueCogOVdf3HESZw8;
                    this.__p_Tlq6T13bYhvPJGj1vAWQsv = __p_Tlq6T13bYhvPJGj1vAWQsv;
                    this.__p_DcQCdVxkGjhLh2trZFqGIF = __p_DcQCdVxkGjhLh2trZFqGIF;
                    this.__p_Da99mgzRX2qNVBahXHFubB = __p_Da99mgzRX2qNVBahXHFubB;
                    this.__p_LIJmXe1spfxMAtiojnGt3u = __p_LIJmXe1spfxMAtiojnGt3u;
                    this.__p_LIBUJoWzI2FNE8HhYLybCz = __p_LIBUJoWzI2FNE8HhYLybCz;
                    this.__p_FDVsO36tXtoLQqUHxyMX8I = __p_FDVsO36tXtoLQqUHxyMX8I;
                    this.__p_UIAH4tGfHciMRk7nMgriGF = __p_UIAH4tGfHciMRk7nMgriGF;
                    this.__p_MvAJw8rl6s3PgIXwKWf10U = __p_MvAJw8rl6s3PgIXwKWf10U;
                    this.__p_JAzk95zaJnrNsV3FaDoVb8 = __p_JAzk95zaJnrNsV3FaDoVb8;
                    this.__pin_group_Input_In_J2goJXaSz15QLrvNymwLYV = __pin_group_Input_In_J2goJXaSz15QLrvNymwLYV;
                    this.__pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP = __pin_group_Input_In_PDTuk2SuGd4NrAaSKIlhoP;
                    this.__slot_FSQEksQrR9PQRQJdLDVKAx = __slot_FSQEksQrR9PQRQJdLDVKAx;
                    this.__slot_JXeFQoSy622OZy1H2Unvge = __slot_JXeFQoSy622OZy1H2Unvge;
                    this.__slot_RxsLwx4hLJZOcAHWc1hhHi = __slot_RxsLwx4hLJZOcAHWc1hhHi;
                    this.__slot_COLsIny0JKcLFGg21ZsKIu = __slot_COLsIny0JKcLFGg21ZsKIu;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PNGv3UeoCQALBRcEURj0Gv", Name = "__PNGv3UeoCQALBRcEURj0Gv")]
        [n3.SerializableAttribute]
        public class __PNGv3UeoCQALBRcEURj0Gv : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __PNGv3UeoCQALBRcEURj0Gv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PNGv3UeoCQALBRcEURj0Gv(__PNGv3UeoCQALBRcEURj0Gv other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __PNGv3UeoCQALBRcEURj0Gv __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JctcIFMkV1lO6J6fqlgvwP", Name = "__JctcIFMkV1lO6J6fqlgvwP")]
        [n3.SerializableAttribute]
        public class __JctcIFMkV1lO6J6fqlgvwP : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __JctcIFMkV1lO6J6fqlgvwP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JctcIFMkV1lO6J6fqlgvwP(__JctcIFMkV1lO6J6fqlgvwP other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __JctcIFMkV1lO6J6fqlgvwP __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 265426U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "HXXsodMqzsEQPtKfJCY1PS", Name = "PlayerController_R")]
    [n3.SerializableAttribute]
    public class PlayerController_R : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.PlayerController_R Create(n1.NodeContext Node_Context, float Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] float Loop_To_In, bool Loop_In, float Seek_Time_In, int Seek_In, float Rate_In, bool Play_In)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new PlayerController_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Loop_From_In, Loop_To_In, Loop_In, Seek_Time_In, Seek_In, Rate_In, Play_In);
        }

        [n4.CreateDefaultAttribute]
        public static n2.PlayerController_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n2.PlayerController_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new PlayerController_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n2.PlayerController_R __DEFAULT__;
        public n2.PlayerController_R Split(out float Loop_From_Out, out float Loop_To_Out, out bool Loop_Out, out float Seek_Time_Out, out int Seek_Out, out float Rate_Out, out bool Play_Out)
        {
            float __auto_0 = this.Loop_From;
            float __auto_1 = this.Loop_To;
            bool __auto_2 = this.Loop;
            float __auto_3 = this.Seek_Time;
            int __auto_4 = this.Seek;
            float __auto_5 = this.Rate;
            bool __auto_6 = this.Play;
            Loop_From_Out = __auto_0;
            Loop_To_Out = __auto_1;
            Loop_Out = __auto_2;
            Seek_Time_Out = __auto_3;
            Seek_Out = __auto_4;
            Rate_Out = __auto_5;
            Play_Out = __auto_6;
            return this;
        }

        public n2.PlayerController_R __Create__(n1.NodeContext Node_Context, float Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] float Loop_To_In, bool Loop_In, float Seek_Time_In, int Seek_In, float Rate_In, bool Play_In)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            float __auto_0 = Loop_From_In;
            float __auto_1 = Loop_To_In;
            bool __auto_2 = Loop_In;
            float __auto_3 = Seek_Time_In;
            int __auto_4 = Seek_In;
            float __auto_5 = Rate_In;
            bool __auto_6 = Play_In;
            n2.PlayerController_R that_7 = this;
            this.Loop_From = Loop_From_In;
            this.Loop_To = Loop_To_In;
            this.Play = Play_In;
            this.Loop = Loop_In;
            this.Seek_Time = Seek_Time_In;
            this.Seek = Seek_In;
            this.Rate = Rate_In;
            return that_7;
        }

        public n2.PlayerController_R __CreateDefault__()
        {
            n2.PlayerController_R that_0 = this;
            this.Loop_From = 0F;
            this.Loop_To = 0F;
            this.Play = false;
            this.Loop = false;
            this.Seek_Time = 0F;
            this.Seek = 0;
            this.Rate = 0F;
            return that_0;
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

        [n1.ElementAttribute(TracingId = 265431U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Tr6TWLk242cOId3lEnfYEo", Name = "Loop From")]
        public float Loop_From;
        [n1.ElementAttribute(TracingId = 265433U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "A1qGQL38bfrPhqqhvhoNhx", Name = "Loop To")]
        public float Loop_To;
        [n1.ElementAttribute(TracingId = 265436U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "IGNXTjyaT40NC856jDIlg4", Name = "Play")]
        public bool Play;
        [n1.ElementAttribute(TracingId = 265446U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "NQ9OOF5jxyIQIFb8QHTYHH", Name = "Loop")]
        public bool Loop;
        [n1.ElementAttribute(TracingId = 265455U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LfQSNDhg1jNPJJC78YnCPd", Name = "Seek Time")]
        public float Seek_Time;
        [n1.ElementAttribute(TracingId = 265457U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ER7PRyoQNW5O9anYlt3ekH", Name = "Seek")]
        public int Seek;
        [n1.ElementAttribute(TracingId = 265468U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "KgQ9UDThjSVPiSFNGc69Wf", Name = "Rate")]
        public float Rate;
        public PlayerController_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PlayerController_R(PlayerController_R other): base(other)
        {
            this.Loop_From = other.Loop_From;
            this.Loop_To = other.Loop_To;
            this.Play = other.Play;
            this.Loop = other.Loop;
            this.Seek_Time = other.Seek_Time;
            this.Seek = other.Seek;
            this.Rate = other.Rate;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Loop_From", in Loop_From), n1.CompilationHelper.GetValueOrExisting(values, "Loop_To", in Loop_To), n1.CompilationHelper.GetValueOrExisting(values, "Play", in Play), n1.CompilationHelper.GetValueOrExisting(values, "Loop", in Loop), n1.CompilationHelper.GetValueOrExisting(values, "Seek_Time", in Seek_Time), n1.CompilationHelper.GetValueOrExisting(values, "Seek", in Seek), n1.CompilationHelper.GetValueOrExisting(values, "Rate", in Rate));
        }

        internal PlayerController_R __WITH__(float Loop_From, float Loop_To, bool Play, bool Loop, float Seek_Time, int Seek, float Rate)
        {
            n2.PlayerController_R that_0 = this;
            that_0 = Loop_From != this.Loop_From || Loop_To != this.Loop_To || Play != this.Play || Loop != this.Loop || Seek_Time != this.Seek_Time || Seek != this.Seek || Rate != this.Rate ? new PlayerController_R(this)
            {Loop_From = Loop_From, Loop_To = Loop_To, Play = Play, Loop = Loop, Seek_Time = Seek_Time, Seek = Seek, Rate = Rate} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 265562U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LtnjuyCHaJHOH1LKVep7sS", Name = "VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS")]
    [n3.SerializableAttribute]
    public class VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n2.VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n2.VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS CreateDefault()
        {
            var instance = new VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n2.VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS Update()
        {
            return this;
        }

        public n2.VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n2.VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS __CreateDefault__()
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

        public VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS(VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal VL_SyncApplication_LtnjuyCHaJHOH1LKVep7sS __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Sync_.IO.ClockSyncClient.Internal
{
    [n1.ElementAttribute(TracingId = 263269U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TcLZBtr9H68Pjp6BL8KuKI", Name = "IIR2_LowPass_R")]
    [n3.SerializableAttribute]
    public class IIR2_LowPass_R<T> : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n40.IIR2_LowPass_R<T> Create<AdM>(n1.NodeContext Node_Context, T Initial_Value_In)
            where AdM : struct, n46.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new IIR2_LowPass_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Initial_Value_In);
        }

        [n4.CreateDefaultAttribute]
        public static n40.IIR2_LowPass_R<T> CreateDefault<AdM>()
            where AdM : struct, n46.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n40.IIR2_LowPass_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new IIR2_LowPass_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n40.IIR2_LowPass_R<T> __DEFAULT__;
        public n40.IIR2_LowPass_R<T> Update<AdM>(T Value_In, T Threshold_In, float Alpha_In, bool Reset_In, out T Value_Out)
            where AdM : struct, n47.IAdaptiveAbs<T>, n47.IAdaptiveOperatorPlus<T>, n47.IAdaptiveOperatorMulitply_Scale<T>, n47.IAdaptiveOperatorGreater<T>, n47.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            bool __auto_1 = this.Initialized;
            T __auto_2 = this.Value;
            bool __pad_FHJG7llqPk6Ozm3Jwb2mHk_3 = __slot_FHJG7llqPk6Ozm3Jwb2mHk;
            var Output_4 = !Reset_In;
            var Output_5 = __auto_1 && Output_4;
            T __auto_6;
            if (Output_5)
            {
                w_0.OperatorMinus(Input_In: Value_In, Input_2_In: __auto_2, Output_Out: out T Output_8);
                w_0.Abs(Input_In: Output_8, Output_Out: out T Output_9);
                w_0.OperatorGreater(Input_In: Output_9, Input_2_In: Threshold_In, Result_Out: out bool Result_10);
                T __auto_11;
                if (Result_10)
                {
                    float __pad_OwdXmSOZPJJMP4iH2ys6nz_13 = __slot_OwdXmSOZPJJMP4iH2ys6nz;
                    var Output_14 = __pad_OwdXmSOZPJJMP4iH2ys6nz_13 - Alpha_In;
                    w_0.OperatorMulitply_Scale(Input_In: Value_In, Scalar_In: Output_14, Output_Out: out T Output_15);
                    w_0.OperatorMulitply_Scale(Input_In: __auto_2, Scalar_In: Alpha_In, Output_Out: out T Output_16);
                    w_0.OperatorPlus(Input_In: Output_16, Input_2_In: Output_15, Output_Out: out T Output_17);
                    __auto_11 = Output_17;
                }
                else
                {
                    __auto_11 = Value_In;
                }

                __auto_6 = __auto_11;
            }
            else
            {
                __auto_6 = Value_In;
            }

            T __auto_18 = __auto_6;
            bool __auto_19 = __pad_FHJG7llqPk6Ozm3Jwb2mHk_3;
            Value_Out = __auto_6;
            n40.IIR2_LowPass_R<T> that_20 = this;
            that_20 = !n11.EqualityComparer<T>.Default.Equals(__auto_6, this.Value) || __pad_FHJG7llqPk6Ozm3Jwb2mHk_3 != this.Initialized ? new IIR2_LowPass_R<T>(this)
            {Value = __auto_6, Initialized = __pad_FHJG7llqPk6Ozm3Jwb2mHk_3} : that_20;
            return that_20;
        }

        public n40.IIR2_LowPass_R<T> GetValue(out T Value_Out)
        {
            T __auto_0 = this.Value;
            Value_Out = __auto_0;
            return this;
        }

        public n40.IIR2_LowPass_R<T> __Create__<AdM>(n1.NodeContext Node_Context, T Initial_Value_In)
            where AdM : struct, n46.IAdaptiveCreateDefault<T>
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_0);
            T __auto_1 = Initial_Value_In;
            n40.IIR2_LowPass_R<T> that_2 = this;
            this.Value = Initial_Value_In;
            this.Initialized = false;
            return that_2;
        }

        public n40.IIR2_LowPass_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n46.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_1);
            n40.IIR2_LowPass_R<T> that_1 = this;
            this.Value = __out_1;
            this.Initialized = false;
            return that_1;
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

        [n1.ElementAttribute(TracingId = 263271U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Gf2WF6bCY7BOTs6D7UqiK9", Name = "Value")]
        public T Value;
        [n1.ElementAttribute(TracingId = 263272U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Os7Lxi7NtwxPBnFNGH2q9D", Name = "Initialized")]
        public bool Initialized;
        [n1.ElementAttribute(TracingId = 263274U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FHJG7llqPk6Ozm3Jwb2mHk", Name = "__slot_FHJG7llqPk6Ozm3Jwb2mHk")]
        public static bool __slot_FHJG7llqPk6Ozm3Jwb2mHk = true;
        [n1.ElementAttribute(TracingId = 263305U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "OwdXmSOZPJJMP4iH2ys6nz", Name = "__slot_OwdXmSOZPJJMP4iH2ys6nz")]
        public static float __slot_OwdXmSOZPJJMP4iH2ys6nz = 1F;
        static IIR2_LowPass_R()
        {
        }

        public IIR2_LowPass_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IIR2_LowPass_R(IIR2_LowPass_R<T> other): base(other)
        {
            this.Value = other.Value;
            this.Initialized = other.Initialized;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Value", in Value), n1.CompilationHelper.GetValueOrExisting(values, "Initialized", in Initialized));
        }

        internal IIR2_LowPass_R<T> __WITH__(T Value, bool Initialized)
        {
            n40.IIR2_LowPass_R<T> that_0 = this;
            that_0 = !n11.EqualityComparer<T>.Default.Equals(Value, this.Value) || Initialized != this.Initialized ? new IIR2_LowPass_R<T>(this)
            {Value = Value, Initialized = Initialized} : that_0;
            return that_0;
        }
    }
}

namespace _VL_Sync_.IO.FramePlayer
{
    [n1.ElementAttribute(TracingId = 264658U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JunXM8IqV4uNZzxgZ4Y6hQ", Name = "FrameController_R")]
    [n3.SerializableAttribute]
    public class FrameController_R : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n44.FrameController_R Create(n1.NodeContext Node_Context, [n4.SerializedDefaultValueAttribute("1", false)] int Frame_Increment_In, bool Loop_In, int Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Loop_To_In, int Seek_Frame_In, bool Seek_In, [n4.SerializedDefaultValueAttribute("1", false)] int Increment_every_Nth_frame_In)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new FrameController_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Frame_Increment_In, Loop_In, Loop_From_In, Loop_To_In, Seek_Frame_In, Seek_In, Increment_every_Nth_frame_In);
        }

        [n4.CreateDefaultAttribute]
        public static n44.FrameController_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n44.FrameController_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new FrameController_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n44.FrameController_R __DEFAULT__;
        public n44.FrameController_R Split(out int Frame_Increment_Out, out bool Loop_Out, out int Loop_From_Out, out int Loop_To_Out, out int Seek_Frame_Out, out bool Seek_Out, out int Increment_every_Nth_frame_Out)
        {
            int __auto_0 = this.Frame_Increment;
            bool __auto_1 = this.Loop;
            int __auto_2 = this.Loop_From;
            int __auto_3 = this.Loop_To;
            int __auto_4 = this.Seek_Frame;
            bool __auto_5 = this.Seek;
            int __auto_6 = this.Increment_every_Nth_frame;
            Frame_Increment_Out = __auto_0;
            Loop_Out = __auto_1;
            Loop_From_Out = __auto_2;
            Loop_To_Out = __auto_3;
            Seek_Frame_Out = __auto_4;
            Seek_Out = __auto_5;
            Increment_every_Nth_frame_Out = __auto_6;
            return this;
        }

        public n44.FrameController_R __Create__(n1.NodeContext Node_Context, [n4.SerializedDefaultValueAttribute("1", false)] int Frame_Increment_In, bool Loop_In, int Loop_From_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Loop_To_In, int Seek_Frame_In, bool Seek_In, [n4.SerializedDefaultValueAttribute("1", false)] int Increment_every_Nth_frame_In)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            int __auto_0 = Frame_Increment_In;
            bool __auto_1 = Loop_In;
            int __auto_2 = Loop_From_In;
            int __auto_3 = Loop_To_In;
            int __auto_4 = Seek_Frame_In;
            bool __auto_5 = Seek_In;
            int __auto_6 = Increment_every_Nth_frame_In;
            n44.FrameController_R that_7 = this;
            this.Loop_From = Loop_From_In;
            this.Loop_To = Loop_To_In;
            this.Seek_Frame = Seek_Frame_In;
            this.Seek = Seek_In;
            this.Increment_every_Nth_frame = Increment_every_Nth_frame_In;
            this.Loop = Loop_In;
            this.Frame_Increment = Frame_Increment_In;
            return that_7;
        }

        public n44.FrameController_R __CreateDefault__()
        {
            n44.FrameController_R that_0 = this;
            this.Loop_From = 0;
            this.Loop_To = 0;
            this.Seek_Frame = 0;
            this.Seek = false;
            this.Increment_every_Nth_frame = 0;
            this.Loop = false;
            this.Frame_Increment = 0;
            return that_0;
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

        [n1.ElementAttribute(TracingId = 264667U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "JR9ZyXEJS9dM1gQV8PzIJY", Name = "Loop From")]
        public int Loop_From;
        [n1.ElementAttribute(TracingId = 264670U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PTrRkrprdCDL7MzU27rThM", Name = "Loop To")]
        public int Loop_To;
        [n1.ElementAttribute(TracingId = 264673U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "QI4jVo0dAp9MGrVChxKPgG", Name = "Seek Frame")]
        public int Seek_Frame;
        [n1.ElementAttribute(TracingId = 264675U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SOIgvLhlKHfQJMJpLfVzSR", Name = "Seek")]
        public bool Seek;
        [n1.ElementAttribute(TracingId = 264677U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "FW4E40ZssQHMX4KkE8lAYn", Name = "Increment every Nth frame")]
        public int Increment_every_Nth_frame;
        [n1.ElementAttribute(TracingId = 264691U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "BMuA06MMknnOMvMigEvhcJ", Name = "Loop")]
        public bool Loop;
        [n1.ElementAttribute(TracingId = 264664U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "SNxt4MsdQyYP0yLZdtMmjN", Name = "Frame Increment")]
        public int Frame_Increment;
        public FrameController_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FrameController_R(FrameController_R other): base(other)
        {
            this.Loop_From = other.Loop_From;
            this.Loop_To = other.Loop_To;
            this.Seek_Frame = other.Seek_Frame;
            this.Seek = other.Seek;
            this.Increment_every_Nth_frame = other.Increment_every_Nth_frame;
            this.Loop = other.Loop;
            this.Frame_Increment = other.Frame_Increment;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Loop_From", in Loop_From), n1.CompilationHelper.GetValueOrExisting(values, "Loop_To", in Loop_To), n1.CompilationHelper.GetValueOrExisting(values, "Seek_Frame", in Seek_Frame), n1.CompilationHelper.GetValueOrExisting(values, "Seek", in Seek), n1.CompilationHelper.GetValueOrExisting(values, "Increment_every_Nth_frame", in Increment_every_Nth_frame), n1.CompilationHelper.GetValueOrExisting(values, "Loop", in Loop), n1.CompilationHelper.GetValueOrExisting(values, "Frame_Increment", in Frame_Increment));
        }

        internal FrameController_R __WITH__(int Loop_From, int Loop_To, int Seek_Frame, bool Seek, int Increment_every_Nth_frame, bool Loop, int Frame_Increment)
        {
            n44.FrameController_R that_0 = this;
            that_0 = Loop_From != this.Loop_From || Loop_To != this.Loop_To || Seek_Frame != this.Seek_Frame || Seek != this.Seek || Increment_every_Nth_frame != this.Increment_every_Nth_frame || Loop != this.Loop || Frame_Increment != this.Frame_Increment ? new FrameController_R(this)
            {Loop_From = Loop_From, Loop_To = Loop_To, Seek_Frame = Seek_Frame, Seek = Seek, Increment_every_Nth_frame = Increment_every_Nth_frame, Loop = Loop, Frame_Increment = Frame_Increment} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 264831U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "Q7TacNUH8xRNvwHKMkot6p", Name = "SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p")]
    [n3.SerializableAttribute]
    public class SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p : n1.VLObject, n3.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p Create(n1.NodeContext Node_Context)
        {
            var instance = new SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p CreateDefault()
        {
            var instance = new SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p Update(bool Loop_In, [n4.SerializedDefaultValueAttribute("1", false)] int Increment_In, int Default_In, int Minimum_In, [n4.SerializedDefaultValueAttribute("15", false)] int Maximum_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Up_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Reset_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Down_In, out int Value_Out)
        {
            int __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__PIpdZhIWQ8XP1dTBsjkEux>(this.__if_GaZ5jKNCISOPwB3J2IzOCm, __GetContext__());
            if (Loop_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __PIpdZhIWQ8XP1dTBsjkEux(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "RK8Yq5191LAPu0dQAPhrYm", 264846U);
                    var Output_3 = n23.CounterWrap_NQShHNCKkBNN1Rg1qdHOVT.Create(Node_Context: Node_Context_2);
                    state_1.__p_RK8Yq5191LAPu0dQAPhrYm = Output_3;
                }

                bool Update_4 = true;
                var Output_5 = state_1.__p_RK8Yq5191LAPu0dQAPhrYm;
                if (Update_4)
                {
                    Output_5 = state_1.__p_RK8Yq5191LAPu0dQAPhrYm.Update(Increment_In: Increment_In, Default_In: Default_In, Minimum_In: Minimum_In, Maximum_In: Maximum_In);
                }

                var Output_6 = Output_5;
                if (Up_In)
                {
                    Output_6 = Output_5.Up();
                }

                var Output_7 = Output_6;
                if (Down_In)
                {
                    Output_7 = Output_6.Down();
                }

                var Output_8 = Output_7;
                if (Reset_In)
                {
                    Output_8 = Output_7.Reset();
                }

                var Output_12 = Output_8.GetValue(Value_Out: out int Value_9, Underflow_Out: out bool Underflow_10, Overflow_Out: out bool Overflow_11);
                __auto_0 = Value_9;
                bool __pad_ILbJUhcDxORLxgRemcHTKE_13 = Underflow_10;
                bool __pad_AUYe2KmOxR4OpHvIe7FtMK_14 = Overflow_11;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = Output_12 != state_1.__p_RK8Yq5191LAPu0dQAPhrYm || Underflow_10 != state_1.__slot_ILbJUhcDxORLxgRemcHTKE || Overflow_11 != state_1.__slot_AUYe2KmOxR4OpHvIe7FtMK ? new __PIpdZhIWQ8XP1dTBsjkEux(state_1)
                    {__p_RK8Yq5191LAPu0dQAPhrYm = Output_12, __slot_ILbJUhcDxORLxgRemcHTKE = Underflow_10, __slot_AUYe2KmOxR4OpHvIe7FtMK = Overflow_11} : state_1;
                else
                {
                    state_1.__p_RK8Yq5191LAPu0dQAPhrYm = Output_12;
                    state_1.__slot_ILbJUhcDxORLxgRemcHTKE = Underflow_10;
                    state_1.__slot_AUYe2KmOxR4OpHvIe7FtMK = Overflow_11;
                }
            }
            else
            {
                __auto_0 = 0;
            }

            var Output_15 = !Loop_In;
            int __auto_16;
            var state_17 = n1.CompilationHelper.Restore<__LUoPRaljUFPNFYJFQIPMSY>(this.__if_PwdeMmrR3QfNjuoRI3Kn8q, __GetContext__());
            if (Output_15)
            {
                if (state_17 == null)
                {
                    state_17 = new __LUoPRaljUFPNFYJFQIPMSY(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("IIXMQwmVKipN4ReHHIGZLy", "V2JmRmYGGFvOiyS0ybqoXO", 264887U);
                    var Output_19 = n23.CounterClamp_UmRvxWmFWbuNA95MLvVIEk.Create(Node_Context: Node_Context_18);
                    state_17.__p_V2JmRmYGGFvOiyS0ybqoXO = Output_19;
                }

                bool Update_20 = true;
                var Output_21 = state_17.__p_V2JmRmYGGFvOiyS0ybqoXO;
                if (Update_20)
                {
                    Output_21 = state_17.__p_V2JmRmYGGFvOiyS0ybqoXO.Update(Increment_In: Increment_In, Default_In: Default_In, Minimum_In: Minimum_In, Maximum_In: Maximum_In);
                }

                var Output_22 = Output_21;
                if (Up_In)
                {
                    Output_22 = Output_21.Up();
                }

                var Output_23 = Output_22;
                if (Down_In)
                {
                    Output_23 = Output_22.Down();
                }

                var Output_24 = Output_23;
                if (Reset_In)
                {
                    Output_24 = Output_23.Reset();
                }

                var Output_28 = Output_24.GetValue(Value_Out: out int Value_25, Underflow_Out: out bool Underflow_26, Overflow_Out: out bool Overflow_27);
                __auto_16 = Value_25;
                bool __pad_L3ExS3JnsyBP5ZCjuvfugf_29 = Underflow_26;
                bool __pad_TgAJAnTDXqGMvlhvkZgbAJ_30 = Overflow_27;
                if (state_17.__GetContext__().IsImmutable)
                    state_17 = Output_28 != state_17.__p_V2JmRmYGGFvOiyS0ybqoXO || Underflow_26 != state_17.__slot_L3ExS3JnsyBP5ZCjuvfugf || Overflow_27 != state_17.__slot_TgAJAnTDXqGMvlhvkZgbAJ ? new __LUoPRaljUFPNFYJFQIPMSY(state_17)
                    {__p_V2JmRmYGGFvOiyS0ybqoXO = Output_28, __slot_L3ExS3JnsyBP5ZCjuvfugf = Underflow_26, __slot_TgAJAnTDXqGMvlhvkZgbAJ = Overflow_27} : state_17;
                else
                {
                    state_17.__p_V2JmRmYGGFvOiyS0ybqoXO = Output_28;
                    state_17.__slot_L3ExS3JnsyBP5ZCjuvfugf = Underflow_26;
                    state_17.__slot_TgAJAnTDXqGMvlhvkZgbAJ = Overflow_27;
                }
            }
            else
            {
                __auto_16 = __auto_0;
            }

            Value_Out = __auto_16;
            n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = state_1 != this.__if_GaZ5jKNCISOPwB3J2IzOCm || state_17 != this.__if_PwdeMmrR3QfNjuoRI3Kn8q ? new SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(this)
                {__if_GaZ5jKNCISOPwB3J2IzOCm = state_1, __if_PwdeMmrR3QfNjuoRI3Kn8q = state_17} : that_31;
            else
            {
                this.__if_GaZ5jKNCISOPwB3J2IzOCm = state_1;
                this.__if_PwdeMmrR3QfNjuoRI3Kn8q = state_17;
            }

            return that_31;
        }

        public n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p that_0 = this;
            this.__if_GaZ5jKNCISOPwB3J2IzOCm = default(n3.Object);
            this.__if_PwdeMmrR3QfNjuoRI3Kn8q = default(n3.Object);
            return that_0;
        }

        public n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __CreateDefault__()
        {
            n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p that_0 = this;
            this.__if_GaZ5jKNCISOPwB3J2IzOCm = default(n3.Object);
            this.__if_PwdeMmrR3QfNjuoRI3Kn8q = default(n3.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_GaZ5jKNCISOPwB3J2IzOCm);
            n1.CompilationHelper.SafeDispose(this.__if_PwdeMmrR3QfNjuoRI3Kn8q);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_GaZ5jKNCISOPwB3J2IzOCm;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_PwdeMmrR3QfNjuoRI3Kn8q;
        public SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p other): base(other)
        {
            this.__if_GaZ5jKNCISOPwB3J2IzOCm = other.__if_GaZ5jKNCISOPwB3J2IzOCm;
            this.__if_PwdeMmrR3QfNjuoRI3Kn8q = other.__if_PwdeMmrR3QfNjuoRI3Kn8q;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_GaZ5jKNCISOPwB3J2IzOCm", in __if_GaZ5jKNCISOPwB3J2IzOCm), n1.CompilationHelper.GetValueOrExisting(values, "__if_PwdeMmrR3QfNjuoRI3Kn8q", in __if_PwdeMmrR3QfNjuoRI3Kn8q));
        }

        internal SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p __WITH__(n3.Object __if_GaZ5jKNCISOPwB3J2IzOCm, n3.Object __if_PwdeMmrR3QfNjuoRI3Kn8q)
        {
            n44.SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_GaZ5jKNCISOPwB3J2IzOCm != this.__if_GaZ5jKNCISOPwB3J2IzOCm || __if_PwdeMmrR3QfNjuoRI3Kn8q != this.__if_PwdeMmrR3QfNjuoRI3Kn8q ? new SyncFrameCounter_Q7TacNUH8xRNvwHKMkot6p(this)
                {__if_GaZ5jKNCISOPwB3J2IzOCm = __if_GaZ5jKNCISOPwB3J2IzOCm, __if_PwdeMmrR3QfNjuoRI3Kn8q = __if_PwdeMmrR3QfNjuoRI3Kn8q} : that_0;
            else
            {
                this.__if_GaZ5jKNCISOPwB3J2IzOCm = __if_GaZ5jKNCISOPwB3J2IzOCm;
                this.__if_PwdeMmrR3QfNjuoRI3Kn8q = __if_PwdeMmrR3QfNjuoRI3Kn8q;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "PIpdZhIWQ8XP1dTBsjkEux", Name = "__PIpdZhIWQ8XP1dTBsjkEux")]
        [n3.SerializableAttribute]
        public class __PIpdZhIWQ8XP1dTBsjkEux : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RK8Yq5191LAPu0dQAPhrYm);
                return;
            }

            [n1.ElementAttribute(TracingId = 264846U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "RK8Yq5191LAPu0dQAPhrYm", Name = "CounterWrap", IsManaged = true, IsAutoGenerated = true)]
            public n23.CounterWrap_NQShHNCKkBNN1Rg1qdHOVT __p_RK8Yq5191LAPu0dQAPhrYm;
            [n1.ElementAttribute(TracingId = 264864U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "ILbJUhcDxORLxgRemcHTKE", Name = "__slot_ILbJUhcDxORLxgRemcHTKE")]
            public bool __slot_ILbJUhcDxORLxgRemcHTKE;
            [n1.ElementAttribute(TracingId = 264866U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "AUYe2KmOxR4OpHvIe7FtMK", Name = "__slot_AUYe2KmOxR4OpHvIe7FtMK")]
            public bool __slot_AUYe2KmOxR4OpHvIe7FtMK;
            public __PIpdZhIWQ8XP1dTBsjkEux(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PIpdZhIWQ8XP1dTBsjkEux(__PIpdZhIWQ8XP1dTBsjkEux other): base(other)
            {
                this.__p_RK8Yq5191LAPu0dQAPhrYm = other.__p_RK8Yq5191LAPu0dQAPhrYm;
                this.__slot_ILbJUhcDxORLxgRemcHTKE = other.__slot_ILbJUhcDxORLxgRemcHTKE;
                this.__slot_AUYe2KmOxR4OpHvIe7FtMK = other.__slot_AUYe2KmOxR4OpHvIe7FtMK;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RK8Yq5191LAPu0dQAPhrYm", in __p_RK8Yq5191LAPu0dQAPhrYm), n1.CompilationHelper.GetValueOrExisting(values, "__slot_ILbJUhcDxORLxgRemcHTKE", in __slot_ILbJUhcDxORLxgRemcHTKE), n1.CompilationHelper.GetValueOrExisting(values, "__slot_AUYe2KmOxR4OpHvIe7FtMK", in __slot_AUYe2KmOxR4OpHvIe7FtMK));
            }

            internal __PIpdZhIWQ8XP1dTBsjkEux __WITH__(n23.CounterWrap_NQShHNCKkBNN1Rg1qdHOVT __p_RK8Yq5191LAPu0dQAPhrYm, bool __slot_ILbJUhcDxORLxgRemcHTKE, bool __slot_AUYe2KmOxR4OpHvIe7FtMK)
            {
                __PIpdZhIWQ8XP1dTBsjkEux that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RK8Yq5191LAPu0dQAPhrYm != this.__p_RK8Yq5191LAPu0dQAPhrYm || __slot_ILbJUhcDxORLxgRemcHTKE != this.__slot_ILbJUhcDxORLxgRemcHTKE || __slot_AUYe2KmOxR4OpHvIe7FtMK != this.__slot_AUYe2KmOxR4OpHvIe7FtMK ? new __PIpdZhIWQ8XP1dTBsjkEux(this)
                    {__p_RK8Yq5191LAPu0dQAPhrYm = __p_RK8Yq5191LAPu0dQAPhrYm, __slot_ILbJUhcDxORLxgRemcHTKE = __slot_ILbJUhcDxORLxgRemcHTKE, __slot_AUYe2KmOxR4OpHvIe7FtMK = __slot_AUYe2KmOxR4OpHvIe7FtMK} : that_0;
                else
                {
                    this.__p_RK8Yq5191LAPu0dQAPhrYm = __p_RK8Yq5191LAPu0dQAPhrYm;
                    this.__slot_ILbJUhcDxORLxgRemcHTKE = __slot_ILbJUhcDxORLxgRemcHTKE;
                    this.__slot_AUYe2KmOxR4OpHvIe7FtMK = __slot_AUYe2KmOxR4OpHvIe7FtMK;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "LUoPRaljUFPNFYJFQIPMSY", Name = "__LUoPRaljUFPNFYJFQIPMSY")]
        [n3.SerializableAttribute]
        public class __LUoPRaljUFPNFYJFQIPMSY : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_V2JmRmYGGFvOiyS0ybqoXO);
                return;
            }

            [n1.ElementAttribute(TracingId = 264887U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "V2JmRmYGGFvOiyS0ybqoXO", Name = "CounterClamp", IsManaged = true, IsAutoGenerated = true)]
            public n23.CounterClamp_UmRvxWmFWbuNA95MLvVIEk __p_V2JmRmYGGFvOiyS0ybqoXO;
            [n1.ElementAttribute(TracingId = 264908U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "L3ExS3JnsyBP5ZCjuvfugf", Name = "__slot_L3ExS3JnsyBP5ZCjuvfugf")]
            public bool __slot_L3ExS3JnsyBP5ZCjuvfugf;
            [n1.ElementAttribute(TracingId = 264909U, DocumentId = "IIXMQwmVKipN4ReHHIGZLy", PersistentId = "TgAJAnTDXqGMvlhvkZgbAJ", Name = "__slot_TgAJAnTDXqGMvlhvkZgbAJ")]
            public bool __slot_TgAJAnTDXqGMvlhvkZgbAJ;
            public __LUoPRaljUFPNFYJFQIPMSY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LUoPRaljUFPNFYJFQIPMSY(__LUoPRaljUFPNFYJFQIPMSY other): base(other)
            {
                this.__p_V2JmRmYGGFvOiyS0ybqoXO = other.__p_V2JmRmYGGFvOiyS0ybqoXO;
                this.__slot_L3ExS3JnsyBP5ZCjuvfugf = other.__slot_L3ExS3JnsyBP5ZCjuvfugf;
                this.__slot_TgAJAnTDXqGMvlhvkZgbAJ = other.__slot_TgAJAnTDXqGMvlhvkZgbAJ;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_V2JmRmYGGFvOiyS0ybqoXO", in __p_V2JmRmYGGFvOiyS0ybqoXO), n1.CompilationHelper.GetValueOrExisting(values, "__slot_L3ExS3JnsyBP5ZCjuvfugf", in __slot_L3ExS3JnsyBP5ZCjuvfugf), n1.CompilationHelper.GetValueOrExisting(values, "__slot_TgAJAnTDXqGMvlhvkZgbAJ", in __slot_TgAJAnTDXqGMvlhvkZgbAJ));
            }

            internal __LUoPRaljUFPNFYJFQIPMSY __WITH__(n23.CounterClamp_UmRvxWmFWbuNA95MLvVIEk __p_V2JmRmYGGFvOiyS0ybqoXO, bool __slot_L3ExS3JnsyBP5ZCjuvfugf, bool __slot_TgAJAnTDXqGMvlhvkZgbAJ)
            {
                __LUoPRaljUFPNFYJFQIPMSY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_V2JmRmYGGFvOiyS0ybqoXO != this.__p_V2JmRmYGGFvOiyS0ybqoXO || __slot_L3ExS3JnsyBP5ZCjuvfugf != this.__slot_L3ExS3JnsyBP5ZCjuvfugf || __slot_TgAJAnTDXqGMvlhvkZgbAJ != this.__slot_TgAJAnTDXqGMvlhvkZgbAJ ? new __LUoPRaljUFPNFYJFQIPMSY(this)
                    {__p_V2JmRmYGGFvOiyS0ybqoXO = __p_V2JmRmYGGFvOiyS0ybqoXO, __slot_L3ExS3JnsyBP5ZCjuvfugf = __slot_L3ExS3JnsyBP5ZCjuvfugf, __slot_TgAJAnTDXqGMvlhvkZgbAJ = __slot_TgAJAnTDXqGMvlhvkZgbAJ} : that_0;
                else
                {
                    this.__p_V2JmRmYGGFvOiyS0ybqoXO = __p_V2JmRmYGGFvOiyS0ybqoXO;
                    this.__slot_L3ExS3JnsyBP5ZCjuvfugf = __slot_L3ExS3JnsyBP5ZCjuvfugf;
                    this.__slot_TgAJAnTDXqGMvlhvkZgbAJ = __slot_TgAJAnTDXqGMvlhvkZgbAJ;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Sync_
{
    public struct __AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy : n46.IAdaptiveCreateDefault<n48.Socket>, n46.IAdaptiveCreateDefault<n3.IObservable<long>>, n46.IAdaptiveCreateDefault<int>, n46.IAdaptiveCreateDefault<n10.Time>, n46.IAdaptiveCreateDefault<double>, n47.IAdaptiveAbs<double>, n47.IAdaptiveOperatorMinus<double>, n47.IAdaptiveOperatorLess<double>, n47.IAdaptiveOperatorPlus<double>, n47.IAdaptiveOperatorMulitply_Scale<double>, n47.IAdaptiveOperatorGreater<double>, n46.IAdaptiveCreateDefault<bool>, n46.IAdaptiveCreateDefault<n2.ITimeSync_I>
    {
        public void CreateDefault(out n48.Socket Output_Out)
        {
            n49._Operations_.CreateDefault_Generic<n48.Socket>(Output_Out: out n48.Socket Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n3.IObservable<long> Output_Out)
        {
            var Result_0 = n29._Operations_.CreateDefault<long>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n49._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n10.Time Output_Out)
        {
            var Current_Frame_Time_0 = n41._Operations_.CreateDefault();
            Output_Out = Current_Frame_Time_0;
            return;
        }

        public void CreateDefault(out double Output_Out)
        {
            n49._Operations_.CreateDefault_Generic<double>(Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Abs(double Input_In, out double Output_Out)
        {
            n39._Operations_.Abs<double, n30.__AdaptiveImplementations__IIXMQwmVKipN4ReHHIGZLy>(Input_In: Input_In, Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorPlus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(double Input_In, float Scalar_In, out double Output_Out)
        {
            var Output_0 = n19.Float64Extensions.Scale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(double Input_In, double Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n49._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.ITimeSync_I Output_Out)
        {
            n49._Operations_.CreateDefault_Generic<n2.ITimeSync_I>(Output_Out: out n2.ITimeSync_I Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}