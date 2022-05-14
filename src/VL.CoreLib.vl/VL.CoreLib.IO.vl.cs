extern alias e2;
extern alias e5;

using n15 = _VL_CoreLib_IO_;
using n47 = _VL_CoreLib_IO_.IO.ByteChunkifier_Reactive.Advanced;
using n74 = _VL_CoreLib_IO_.IO.CharReader_Reactive.Advanced;
using n21 = global::System.Net.NetworkInformation;
using n78 = _CoreLibBasics_.Primitive.ValueTuple__3_Items.Advanced;
using n20 = _CoreLibBasics_.Control.Advanced;
using n6 = e2::VL.Lib.IO.Socket;
using n62 = e2::VL.Lib.Primitive;
using n51 = global::System.Reactive.Subjects;
using n32 = _VL_Reactive_.Reactive.ToObservable;
using n52 = _CoreLibBasics_.System.Resources.Provider.Advanced;
using n17 = _CoreLibBasics_.Control;
using n83 = _VL_CoreLib_IO_.IO.CharChunkifier.Advanced;
using n43 = _VL_CoreLib_IO_.IO.ByteWriter.Advanced;
using n11 = e2::VL.Lib.Text;
using n25 = _VL_CoreLib_IO_.IO.Net;
using n41 = _VL_CoreLib_IO_.IO.ByteReader.Advanced;
using n18 = _VL_Reactive_.Reactive.Advanced;
using n33 = _VL_Reactive_.Reactive.Sampler;
using n55 = _VL_CoreLib_IO_.IO.Socket.UdpSocket.Advanced;
using n35 = _VL_CoreLib_IO_.IO.Ports.Sender;
using n66 = _VL_Reactive_.Reactive.Subjects.Subject.Advanced;
using n46 = _VL_CoreLib_IO_.IO.ByteReader_Reactive.Advanced;
using n70 = e5::VL.Lib.Animation;
using n61 = _CoreLibBasics_.Primitive.String;
using n38 = _VL_CoreLib_IO_.IO.Advanced;
using n53 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n5 = global::System.Net;
using n69 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n81 = _VL_CoreLib_IO_.IO.CharReader.Advanced;
using n3 = _VL_CoreLib_IO_.IO.Socket;
using n10 = global::System.Collections.Generic;
using n28 = e2::VL.Lib.IO.Ports;
using n88 = _CoreLibBasics_.Math.Adaptive;
using n86 = _VL_Reactive_.Reactive.Observable.Advanced;
using n87 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n36 = _VL_CoreLib_IO_.IO.Ports.Receiver;
using n30 = _VL_CoreLib_IO_.IO;
using n63 = _CoreLibBasics_.Primitive.Byte.Advanced;
using n80 = _CoreLibBasics_.Animation;
using n19 = e2::VL.Lib.Primitive.CacheRegion;
using n64 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n68 = e2::VL.Lib.IO.Obsolete;
using n48 = _VL_CoreLib_IO_.IO.ByteWriter_Reactive.Advanced;
using n27 = global::System.Threading;
using n31 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n60 = e5::VL.Lib.Primitive;
using n39 = _VL_CoreLib_IO_.IO.File;
using n72 = _CoreLibBasics_.IO.Stream.Experimental;
using n76 = _VL_CoreLib_IO_.IO.CharChunkifier_Reactive.Advanced;
using n42 = _VL_CoreLib_IO_.IO.ByteChunkifier.Advanced;
using n54 = _VL_CoreLib_IO_.IO.Socket.UdpServer_Reactive;
using n9 = e5::VL.Lib.Basics.Resources;
using n26 = e5::VL.Lib.Runtime;
using n24 = global::System.Net.Sockets;
using n2 = global::System;
using n79 = _VL_Reactive_.Reactive.AsyncTask;
using n13 = _VL_CoreLib_IO_.IO.Net.Advanced;
using n49 = _VL_Reactive_.Reactive;
using n58 = _VL_CoreLib_IO_.IO.Socket.Datagram;
using n56 = _VL_CoreLib_IO_.IO.Socket.Sender_Datagram.Advanced;
using n82 = _VL_CoreLib_IO_.IO.CharCollector.Advanced;
using n14 = e2::VL.Lib.IO.Net;
using n7 = e2::VL.Lib.IO;
using n45 = _VL_CoreLib_IO_.IO.ByteCollector_Reactive.Advanced;
using n67 = _VL_CoreLib_IO_.IO.Obsolete;
using n57 = _VL_CoreLib_IO_.IO.Socket.Receiver_Datagram.Advanced;
using n29 = global::System.IO.Ports;
using n77 = _VL_CoreLib_IO_.IO.CharWriter_Reactive.Advanced;
using n44 = _VL_CoreLib_IO_.IO.Monitor_Reactive.Advanced;
using n40 = _VL_CoreLib_IO_.IO.ByteCollector.Advanced;
using n65 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n71 = _VL_CoreLib_IO_.IO.File_NoSharing_1.Obsolete;
using n59 = _VL_Reactive_.Reactive.HoldLatest;
using n23 = _VL_Collections_.Collections.Sequence;
using n16 = global::System.Runtime.CompilerServices;
using n34 = _VL_CoreLib_IO_.IO.Ports.SerialPort;
using n12 = e5::VL.Lib.Collections;
using n84 = _VL_CoreLib_IO_.IO.CharWriter.Advanced;
using n37 = e5::VL.Lib.IO;
using n75 = _VL_CoreLib_IO_.IO.CharCollector_Reactive.Advanced;
using n22 = _VL_Collections_.Collections.Spread;
using n50 = _CoreLibBasics_.System.Resources.Advanced;
using n73 = _CoreLibBasics_.IO.Stream.ReaderAll.Experimental;
using n85 = _CoreLibBasics_.Primitive.Advanced;
using n8 = global::System.IO;

namespace _VL_CoreLib_IO_.IO.Socket
{
    [n1.ElementAttribute(TracingId = 235858U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BOd1NI2Q70rNLdxNE7z8jj", Name = "UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj")]
    [n2.SerializableAttribute]
    public class UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj Create(n1.NodeContext Node_Context)
        {
            var instance = new UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj CreateDefault()
        {
            var instance = new UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj Update(n2.IObservable<n6.Datagram> Datagrams_In, [n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Multicast_Address_In, out bool Is_Open_Out)
        {
            n5.IPEndPoint __pad_Rt1enE1E5gsMQS9AcKKU3a_0 = this.__slot_Rt1enE1E5gsMQS9AcKKU3a;
            n5.IPAddress __pad_F9WRZt8QfzRMQ5s4tWRlyT_1 = this.__slot_F9WRZt8QfzRMQ5s4tWRlyT;
            bool Bind_2 = false;
            n6.UDPSocket Input_3 = this.__p_TguivbMwTaNN20J21xPiGt;
            var Result_4 = Input_3.Update(localEndPoint: __pad_Rt1enE1E5gsMQS9AcKKU3a_0, bind: Bind_2);
            var Output_7 = this.__p_RiLq3hHlD3FLdjbCLCzsLz.Update(Input_In: Multicast_Address_In, Result_Out: out n5.IPAddress Result_5, Is_Valid_Out: out bool Is_Valid_6);
            bool Force_8 = false;
            bool Dispose_Cached_Outputs_9 = false;
            var manager_10 = this.__cache_AXRGXsq6J14PKfmVBn396l;
            if (manager_10 is null)
            {
                manager_10 = new n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>>(n2.ValueTuple.Create(n52._Operations_.CreateDefault<n24.Socket, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>()));
            }

            var inputs_11 = (Result_4, Result_5, Is_Valid_6);
            var outputs_12 = manager_10.Outputs;
            var Has_Changed_13 = Force_8 || manager_10.InputsChanged(inputs_11);
            if (Has_Changed_13)
            {
                if (Dispose_Cached_Outputs_9)
                    manager_10.DisposeOutputs();
                n53.ObjectHelpers.IsAssigned(x: Result_4, result: out bool Result_15, notAssigned: out bool Not_Assigned_16);
                n9.IResourceProvider<n24.Socket> __auto_17;
                if (Result_15)
                {
                    var __fallback___19 = n1.ServiceRegistry.Current;
                    n50._Operations_.Do<n24.Socket>(Input_In: Result_4, Action_In: (n24.Socket Input_In_21) =>
                    {
                        using var __current_20 = __fallback___19.MakeCurrentIfNone();
                        var Output_22 = new n24.MulticastOption(group: Result_5, mcint: __pad_F9WRZt8QfzRMQ5s4tWRlyT_1);
                        n54._Operations_.IsValidMulticastIP(Input_In: Result_5, Result_Out: out bool Result_23);
                        var Output_24 = Result_23 && Is_Valid_6;
                        n24.SocketOptionLevel Option_Level_25 = default(n24.SocketOptionLevel);
                        n24.SocketOptionName Option_Name_26 = __c_V4ubsfWtiNHLuaZWBzLCuN;
                        var Output_27 = Input_In_21;
                        if (Output_24)
                        {
                            Input_In_21.SetSocketOption(optionLevel: Option_Level_25, optionName: Option_Name_26, optionValue: Output_22);
                        }
                    }

                    , Output_Out: out n9.IResourceProvider<n24.Socket> Output_28);
                    __auto_17 = Output_28;
                }
                else
                {
                    __auto_17 = Result_4;
                }

                outputs_12 = n2.ValueTuple.Create(__auto_17);
                manager_10 = manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9, default, outputs_12);
            }
            else
            {
                manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9);
            }

            var __auto_29 = outputs_12.Item1;
            bool Update_30 = true;
            var Output_31 = this.__p_TLgwe5NKBWNPAkJvlcPOr1;
            if (Update_30)
            {
                n6.DatagramSender Input_32 = this.__p_TLgwe5NKBWNPAkJvlcPOr1;
                Input_32.Update(localSocket: __auto_29, datagrams: Datagrams_In);
                Output_31 = Input_32;
            }

            var Is_Open_33 = Input_3.IsOpen;
            Is_Open_Out = Is_Open_33;
            n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj that_34 = this;
            if (this.__GetContext__().IsImmutable)
                that_34 = Input_3 != this.__p_TguivbMwTaNN20J21xPiGt || Output_7 != this.__p_RiLq3hHlD3FLdjbCLCzsLz || manager_10 != this.__cache_AXRGXsq6J14PKfmVBn396l || Output_31 != this.__p_TLgwe5NKBWNPAkJvlcPOr1 ? new UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(this)
                {__p_TguivbMwTaNN20J21xPiGt = Input_3, __p_RiLq3hHlD3FLdjbCLCzsLz = Output_7, __cache_AXRGXsq6J14PKfmVBn396l = manager_10, __p_TLgwe5NKBWNPAkJvlcPOr1 = Output_31} : that_34;
            else
            {
                this.__p_TguivbMwTaNN20J21xPiGt = Input_3;
                this.__p_RiLq3hHlD3FLdjbCLCzsLz = Output_7;
                this.__cache_AXRGXsq6J14PKfmVBn396l = manager_10;
                this.__p_TLgwe5NKBWNPAkJvlcPOr1 = Output_31;
            }

            return that_34;
        }

        public n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj SetEnabled([n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            bool SetEnabled_0 = true;
            var Output_1 = this.__p_TguivbMwTaNN20J21xPiGt;
            if (SetEnabled_0)
            {
                n6.UDPSocket Input_2 = this.__p_TguivbMwTaNN20J21xPiGt;
                Input_2.Enabled = Enabled_In;
                Output_1 = Input_2;
            }

            n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_1 != this.__p_TguivbMwTaNN20J21xPiGt ? new UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(this)
                {__p_TguivbMwTaNN20J21xPiGt = Output_1} : that_3;
            else
            {
                this.__p_TguivbMwTaNN20J21xPiGt = Output_1;
            }

            return that_3;
        }

        public n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Any_0 = n5.IPAddress.Any;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "LuteNaNOjmiLTF6ApdoAq4", 235883U);
            var Output_2 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_1);
            int Port_3 = 0;
            var State_Output_5 = Output_2.Update(Address_In: Any_0, Port_In: Port_3, Output_Out: out n5.IPEndPoint Output_4);
            n5.IPEndPoint __pad_Rt1enE1E5gsMQS9AcKKU3a_6 = Output_4;
            n5.IPAddress __pad_F9WRZt8QfzRMQ5s4tWRlyT_7 = Any_0;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "TguivbMwTaNN20J21xPiGt", 235862U);
            n55._Operations_.Create_H(Node_Context: Node_Context_8, Output_Out: out n6.UDPSocket Output_9);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "TLgwe5NKBWNPAkJvlcPOr1", 235874U);
            n56._Operations_.Create_H(Node_Context_In: Node_Context_10, Output_Out: out n6.DatagramSender Output_11);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "RiLq3hHlD3FLdjbCLCzsLz", 235903U);
            var Output_13 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_12);
            n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj that_14 = this;
            this.__slot_Rt1enE1E5gsMQS9AcKKU3a = Output_4;
            this.__slot_F9WRZt8QfzRMQ5s4tWRlyT = Any_0;
            this.__p_LuteNaNOjmiLTF6ApdoAq4 = State_Output_5;
            this.__p_TguivbMwTaNN20J21xPiGt = Output_9;
            this.__p_TLgwe5NKBWNPAkJvlcPOr1 = Output_11;
            this.__p_RiLq3hHlD3FLdjbCLCzsLz = Output_13;
            this.__cache_AXRGXsq6J14PKfmVBn396l = null;
            return that_14;
        }

        public n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj __CreateDefault__()
        {
            n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj that_0 = this;
            this.__slot_Rt1enE1E5gsMQS9AcKKU3a = default(n5.IPEndPoint);
            this.__slot_F9WRZt8QfzRMQ5s4tWRlyT = default(n5.IPAddress);
            this.__p_TguivbMwTaNN20J21xPiGt = default(n6.UDPSocket);
            this.__p_RiLq3hHlD3FLdjbCLCzsLz = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__cache_AXRGXsq6J14PKfmVBn396l = null;
            this.__p_TLgwe5NKBWNPAkJvlcPOr1 = default(n6.DatagramSender);
            this.__p_LuteNaNOjmiLTF6ApdoAq4 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TguivbMwTaNN20J21xPiGt);
            n1.CompilationHelper.SafeDispose(this.__p_RiLq3hHlD3FLdjbCLCzsLz);
            n1.CompilationHelper.SafeDispose(this.__cache_AXRGXsq6J14PKfmVBn396l);
            n1.CompilationHelper.SafeDispose(this.__p_TLgwe5NKBWNPAkJvlcPOr1);
            n1.CompilationHelper.SafeDispose(this.__p_LuteNaNOjmiLTF6ApdoAq4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 235900U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Rt1enE1E5gsMQS9AcKKU3a", Name = "__slot_Rt1enE1E5gsMQS9AcKKU3a")]
        public n5.IPEndPoint __slot_Rt1enE1E5gsMQS9AcKKU3a;
        [n1.ElementAttribute(TracingId = 236006U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "F9WRZt8QfzRMQ5s4tWRlyT", Name = "__slot_F9WRZt8QfzRMQ5s4tWRlyT")]
        public n5.IPAddress __slot_F9WRZt8QfzRMQ5s4tWRlyT;
        [n1.ElementAttribute(TracingId = 235862U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "TguivbMwTaNN20J21xPiGt", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n6.UDPSocket __p_TguivbMwTaNN20J21xPiGt;
        [n1.ElementAttribute(TracingId = 235903U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RiLq3hHlD3FLdjbCLCzsLz", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_RiLq3hHlD3FLdjbCLCzsLz;
        [n1.ElementAttribute(TracingId = 235910U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AXRGXsq6J14PKfmVBn396l", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>> __cache_AXRGXsq6J14PKfmVBn396l = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.SocketOptionName __c_V4ubsfWtiNHLuaZWBzLCuN = n1.CompilationHelper.Deserialize<n24.SocketOptionName>("AddMembership", false, "PcdEIeqrXeZQCL5lc35ctR", "V4ubsfWtiNHLuaZWBzLCuN");
        [n1.ElementAttribute(TracingId = 235874U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "TLgwe5NKBWNPAkJvlcPOr1", Name = "Sender (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n6.DatagramSender __p_TLgwe5NKBWNPAkJvlcPOr1;
        [n1.ElementAttribute(TracingId = 235883U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "LuteNaNOjmiLTF6ApdoAq4", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_LuteNaNOjmiLTF6ApdoAq4;
        static UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj()
        {
        }

        public UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj other): base(other)
        {
            this.__slot_Rt1enE1E5gsMQS9AcKKU3a = other.__slot_Rt1enE1E5gsMQS9AcKKU3a;
            this.__slot_F9WRZt8QfzRMQ5s4tWRlyT = other.__slot_F9WRZt8QfzRMQ5s4tWRlyT;
            this.__p_TguivbMwTaNN20J21xPiGt = other.__p_TguivbMwTaNN20J21xPiGt;
            this.__p_RiLq3hHlD3FLdjbCLCzsLz = other.__p_RiLq3hHlD3FLdjbCLCzsLz;
            this.__cache_AXRGXsq6J14PKfmVBn396l = other.__cache_AXRGXsq6J14PKfmVBn396l;
            this.__p_TLgwe5NKBWNPAkJvlcPOr1 = other.__p_TLgwe5NKBWNPAkJvlcPOr1;
            this.__p_LuteNaNOjmiLTF6ApdoAq4 = other.__p_LuteNaNOjmiLTF6ApdoAq4;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Rt1enE1E5gsMQS9AcKKU3a", in __slot_Rt1enE1E5gsMQS9AcKKU3a), n1.CompilationHelper.GetValueOrExisting(values, "__slot_F9WRZt8QfzRMQ5s4tWRlyT", in __slot_F9WRZt8QfzRMQ5s4tWRlyT), n1.CompilationHelper.GetValueOrExisting(values, "__p_TguivbMwTaNN20J21xPiGt", in __p_TguivbMwTaNN20J21xPiGt), n1.CompilationHelper.GetValueOrExisting(values, "__p_RiLq3hHlD3FLdjbCLCzsLz", in __p_RiLq3hHlD3FLdjbCLCzsLz), n1.CompilationHelper.GetValueOrExisting(values, "__cache_AXRGXsq6J14PKfmVBn396l", in __cache_AXRGXsq6J14PKfmVBn396l), n1.CompilationHelper.GetValueOrExisting(values, "__p_TLgwe5NKBWNPAkJvlcPOr1", in __p_TLgwe5NKBWNPAkJvlcPOr1), n1.CompilationHelper.GetValueOrExisting(values, "__p_LuteNaNOjmiLTF6ApdoAq4", in __p_LuteNaNOjmiLTF6ApdoAq4));
        }

        internal UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj __WITH__(n5.IPEndPoint __slot_Rt1enE1E5gsMQS9AcKKU3a, n5.IPAddress __slot_F9WRZt8QfzRMQ5s4tWRlyT, n6.UDPSocket __p_TguivbMwTaNN20J21xPiGt, n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_RiLq3hHlD3FLdjbCLCzsLz, n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>> __cache_AXRGXsq6J14PKfmVBn396l, n6.DatagramSender __p_TLgwe5NKBWNPAkJvlcPOr1, n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_LuteNaNOjmiLTF6ApdoAq4)
        {
            n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Rt1enE1E5gsMQS9AcKKU3a != this.__slot_Rt1enE1E5gsMQS9AcKKU3a || __slot_F9WRZt8QfzRMQ5s4tWRlyT != this.__slot_F9WRZt8QfzRMQ5s4tWRlyT || __p_TguivbMwTaNN20J21xPiGt != this.__p_TguivbMwTaNN20J21xPiGt || __p_RiLq3hHlD3FLdjbCLCzsLz != this.__p_RiLq3hHlD3FLdjbCLCzsLz || __cache_AXRGXsq6J14PKfmVBn396l != this.__cache_AXRGXsq6J14PKfmVBn396l || __p_TLgwe5NKBWNPAkJvlcPOr1 != this.__p_TLgwe5NKBWNPAkJvlcPOr1 || __p_LuteNaNOjmiLTF6ApdoAq4 != this.__p_LuteNaNOjmiLTF6ApdoAq4 ? new UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj(this)
                {__slot_Rt1enE1E5gsMQS9AcKKU3a = __slot_Rt1enE1E5gsMQS9AcKKU3a, __slot_F9WRZt8QfzRMQ5s4tWRlyT = __slot_F9WRZt8QfzRMQ5s4tWRlyT, __p_TguivbMwTaNN20J21xPiGt = __p_TguivbMwTaNN20J21xPiGt, __p_RiLq3hHlD3FLdjbCLCzsLz = __p_RiLq3hHlD3FLdjbCLCzsLz, __cache_AXRGXsq6J14PKfmVBn396l = __cache_AXRGXsq6J14PKfmVBn396l, __p_TLgwe5NKBWNPAkJvlcPOr1 = __p_TLgwe5NKBWNPAkJvlcPOr1, __p_LuteNaNOjmiLTF6ApdoAq4 = __p_LuteNaNOjmiLTF6ApdoAq4} : that_0;
            else
            {
                this.__slot_Rt1enE1E5gsMQS9AcKKU3a = __slot_Rt1enE1E5gsMQS9AcKKU3a;
                this.__slot_F9WRZt8QfzRMQ5s4tWRlyT = __slot_F9WRZt8QfzRMQ5s4tWRlyT;
                this.__p_TguivbMwTaNN20J21xPiGt = __p_TguivbMwTaNN20J21xPiGt;
                this.__p_RiLq3hHlD3FLdjbCLCzsLz = __p_RiLq3hHlD3FLdjbCLCzsLz;
                this.__cache_AXRGXsq6J14PKfmVBn396l = __cache_AXRGXsq6J14PKfmVBn396l;
                this.__p_TLgwe5NKBWNPAkJvlcPOr1 = __p_TLgwe5NKBWNPAkJvlcPOr1;
                this.__p_LuteNaNOjmiLTF6ApdoAq4 = __p_LuteNaNOjmiLTF6ApdoAq4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 236244U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "DVOunIaysXuOsl2X0gaBGw", Name = "UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw")]
    [n2.SerializableAttribute]
    public class UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw Create(n1.NodeContext Node_Context)
        {
            var instance = new UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw CreateDefault()
        {
            var instance = new UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("4444", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Multicast_Address_In, out n2.IObservable<n6.Datagram> Datagrams_Out, out bool Is_Open_Out)
        {
            bool __pad_BRzjXAu5UjnMIUxvIzebVI_0 = __slot_BRzjXAu5UjnMIUxvIzebVI;
            var Output_3 = this.__p_D5hhDTA35qKLp9uS10SaDg.Update(Input_In: Local_Address_In, Result_Out: out n5.IPAddress Result_1, Is_Valid_Out: out bool Is_Valid_2);
            var State_Output_5 = this.__p_EFbxr2T0ySSNSP4jrbEI61.Update(Address_In: Result_1, Port_In: Local_Port_In, Output_Out: out n5.IPEndPoint Output_4);
            n6.UDPSocket Input_6 = this.__p_Pxl8heoJaRPO0RLVOkvvdA;
            var Result_7 = Input_6.Update(localEndPoint: Output_4, bind: __pad_BRzjXAu5UjnMIUxvIzebVI_0);
            var Is_Open_8 = Input_6.IsOpen;
            var Output_11 = this.__p_SE1W4LT5qOtNZq5PQhiKY2.Update(Input_In: Multicast_Address_In, Result_Out: out n5.IPAddress Result_9, Is_Valid_Out: out bool Is_Valid_10);
            bool Force_12 = false;
            bool Dispose_Cached_Outputs_13 = false;
            var manager_14 = this.__cache_IQ2pVX5CDHsOtGaaW27WN2;
            if (manager_14 is null)
            {
                manager_14 = new n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>>(n2.ValueTuple.Create(n52._Operations_.CreateDefault<n24.Socket, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>()));
            }

            var inputs_15 = (Result_7, Result_9, Is_Valid_10);
            var outputs_16 = manager_14.Outputs;
            var Has_Changed_17 = Force_12 || manager_14.InputsChanged(inputs_15);
            if (Has_Changed_17)
            {
                if (Dispose_Cached_Outputs_13)
                    manager_14.DisposeOutputs();
                n53.ObjectHelpers.IsAssigned(x: Result_7, result: out bool Result_19, notAssigned: out bool Not_Assigned_20);
                n9.IResourceProvider<n24.Socket> __auto_21;
                if (Result_19)
                {
                    var __fallback___23 = n1.ServiceRegistry.Current;
                    n50._Operations_.Do<n24.Socket>(Input_In: Result_7, Action_In: (n24.Socket Input_In_25) =>
                    {
                        using var __current_24 = __fallback___23.MakeCurrentIfNone();
                        var Output_26 = new n24.MulticastOption(group: Result_9, mcint: Result_1);
                        n54._Operations_.IsValidMulticastIP(Input_In: Result_9, Result_Out: out bool Result_27);
                        var Output_28 = Result_27 && Is_Valid_10;
                        n24.SocketOptionLevel Option_Level_29 = default(n24.SocketOptionLevel);
                        n24.SocketOptionName Option_Name_30 = __c_OVT6kHlAGTlLAzvmX86Fij;
                        var Output_31 = Input_In_25;
                        if (Output_28)
                        {
                            Input_In_25.SetSocketOption(optionLevel: Option_Level_29, optionName: Option_Name_30, optionValue: Output_26);
                        }
                    }

                    , Output_Out: out n9.IResourceProvider<n24.Socket> Output_32);
                    __auto_21 = Output_32;
                }
                else
                {
                    __auto_21 = Result_7;
                }

                outputs_16 = n2.ValueTuple.Create(__auto_21);
                manager_14 = manager_14.Update(inputs_15, __GetContext__().IsImmutable, Dispose_Cached_Outputs_13, default, outputs_16);
            }
            else
            {
                manager_14.Update(inputs_15, __GetContext__().IsImmutable, Dispose_Cached_Outputs_13);
            }

            var __auto_33 = outputs_16.Item1;
            n6.DatagramReceiver Input_34 = this.__p_C2cnyAX5LKHN6uuK4rd3s6;
            var Datagrams_35 = Input_34.Datagrams;
            bool Update_36 = true;
            var Output_37 = Input_34;
            if (Update_36)
            {
                Input_34.Update(localSocket: __auto_33);
                Output_37 = Input_34;
            }

            Datagrams_Out = Datagrams_35;
            Is_Open_Out = Is_Open_8;
            n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = Output_3 != this.__p_D5hhDTA35qKLp9uS10SaDg || State_Output_5 != this.__p_EFbxr2T0ySSNSP4jrbEI61 || Input_6 != this.__p_Pxl8heoJaRPO0RLVOkvvdA || Output_11 != this.__p_SE1W4LT5qOtNZq5PQhiKY2 || manager_14 != this.__cache_IQ2pVX5CDHsOtGaaW27WN2 || Output_37 != this.__p_C2cnyAX5LKHN6uuK4rd3s6 ? new UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(this)
                {__p_D5hhDTA35qKLp9uS10SaDg = Output_3, __p_EFbxr2T0ySSNSP4jrbEI61 = State_Output_5, __p_Pxl8heoJaRPO0RLVOkvvdA = Input_6, __p_SE1W4LT5qOtNZq5PQhiKY2 = Output_11, __cache_IQ2pVX5CDHsOtGaaW27WN2 = manager_14, __p_C2cnyAX5LKHN6uuK4rd3s6 = Output_37} : that_38;
            else
            {
                this.__p_D5hhDTA35qKLp9uS10SaDg = Output_3;
                this.__p_EFbxr2T0ySSNSP4jrbEI61 = State_Output_5;
                this.__p_Pxl8heoJaRPO0RLVOkvvdA = Input_6;
                this.__p_SE1W4LT5qOtNZq5PQhiKY2 = Output_11;
                this.__cache_IQ2pVX5CDHsOtGaaW27WN2 = manager_14;
                this.__p_C2cnyAX5LKHN6uuK4rd3s6 = Output_37;
            }

            return that_38;
        }

        public n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw SetEnabled([n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            bool SetEnabled_0 = true;
            var Output_1 = this.__p_Pxl8heoJaRPO0RLVOkvvdA;
            if (SetEnabled_0)
            {
                n6.UDPSocket Input_2 = this.__p_Pxl8heoJaRPO0RLVOkvvdA;
                Input_2.Enabled = Enabled_In;
                Output_1 = Input_2;
            }

            n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_1 != this.__p_Pxl8heoJaRPO0RLVOkvvdA ? new UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(this)
                {__p_Pxl8heoJaRPO0RLVOkvvdA = Output_1} : that_3;
            else
            {
                this.__p_Pxl8heoJaRPO0RLVOkvvdA = Output_1;
            }

            return that_3;
        }

        public n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Pxl8heoJaRPO0RLVOkvvdA", 236248U);
            n55._Operations_.Create_H(Node_Context: Node_Context_0, Output_Out: out n6.UDPSocket Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "C2cnyAX5LKHN6uuK4rd3s6", 236265U);
            n57._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n6.DatagramReceiver Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "EFbxr2T0ySSNSP4jrbEI61", 236275U);
            var Output_5 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "D5hhDTA35qKLp9uS10SaDg", 236286U);
            var Output_7 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SE1W4LT5qOtNZq5PQhiKY2", 236295U);
            var Output_9 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_8);
            n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw that_10 = this;
            this.__p_Pxl8heoJaRPO0RLVOkvvdA = Output_1;
            this.__p_C2cnyAX5LKHN6uuK4rd3s6 = Output_3;
            this.__p_EFbxr2T0ySSNSP4jrbEI61 = Output_5;
            this.__p_D5hhDTA35qKLp9uS10SaDg = Output_7;
            this.__p_SE1W4LT5qOtNZq5PQhiKY2 = Output_9;
            this.__cache_IQ2pVX5CDHsOtGaaW27WN2 = null;
            return that_10;
        }

        public n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __CreateDefault__()
        {
            n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw that_0 = this;
            this.__p_D5hhDTA35qKLp9uS10SaDg = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__p_EFbxr2T0ySSNSP4jrbEI61 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.CreateDefault();
            this.__p_Pxl8heoJaRPO0RLVOkvvdA = default(n6.UDPSocket);
            this.__p_SE1W4LT5qOtNZq5PQhiKY2 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__cache_IQ2pVX5CDHsOtGaaW27WN2 = null;
            this.__p_C2cnyAX5LKHN6uuK4rd3s6 = default(n6.DatagramReceiver);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_D5hhDTA35qKLp9uS10SaDg);
            n1.CompilationHelper.SafeDispose(this.__p_EFbxr2T0ySSNSP4jrbEI61);
            n1.CompilationHelper.SafeDispose(this.__p_Pxl8heoJaRPO0RLVOkvvdA);
            n1.CompilationHelper.SafeDispose(this.__p_SE1W4LT5qOtNZq5PQhiKY2);
            n1.CompilationHelper.SafeDispose(this.__cache_IQ2pVX5CDHsOtGaaW27WN2);
            n1.CompilationHelper.SafeDispose(this.__p_C2cnyAX5LKHN6uuK4rd3s6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 236262U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BRzjXAu5UjnMIUxvIzebVI", Name = "__slot_BRzjXAu5UjnMIUxvIzebVI")]
        public static bool __slot_BRzjXAu5UjnMIUxvIzebVI = true;
        [n1.ElementAttribute(TracingId = 236286U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "D5hhDTA35qKLp9uS10SaDg", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_D5hhDTA35qKLp9uS10SaDg;
        [n1.ElementAttribute(TracingId = 236275U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "EFbxr2T0ySSNSP4jrbEI61", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_EFbxr2T0ySSNSP4jrbEI61;
        [n1.ElementAttribute(TracingId = 236248U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Pxl8heoJaRPO0RLVOkvvdA", Name = "UdpSocket", IsManaged = true, IsAutoGenerated = true)]
        public n6.UDPSocket __p_Pxl8heoJaRPO0RLVOkvvdA;
        [n1.ElementAttribute(TracingId = 236295U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SE1W4LT5qOtNZq5PQhiKY2", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_SE1W4LT5qOtNZq5PQhiKY2;
        [n1.ElementAttribute(TracingId = 236378U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IQ2pVX5CDHsOtGaaW27WN2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>> __cache_IQ2pVX5CDHsOtGaaW27WN2 = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.SocketOptionName __c_OVT6kHlAGTlLAzvmX86Fij = n1.CompilationHelper.Deserialize<n24.SocketOptionName>("AddMembership", false, "PcdEIeqrXeZQCL5lc35ctR", "OVT6kHlAGTlLAzvmX86Fij");
        [n1.ElementAttribute(TracingId = 236265U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "C2cnyAX5LKHN6uuK4rd3s6", Name = "Receiver (Datagram)", IsManaged = true, IsAutoGenerated = true)]
        public n6.DatagramReceiver __p_C2cnyAX5LKHN6uuK4rd3s6;
        static UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw()
        {
        }

        public UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw other): base(other)
        {
            this.__p_D5hhDTA35qKLp9uS10SaDg = other.__p_D5hhDTA35qKLp9uS10SaDg;
            this.__p_EFbxr2T0ySSNSP4jrbEI61 = other.__p_EFbxr2T0ySSNSP4jrbEI61;
            this.__p_Pxl8heoJaRPO0RLVOkvvdA = other.__p_Pxl8heoJaRPO0RLVOkvvdA;
            this.__p_SE1W4LT5qOtNZq5PQhiKY2 = other.__p_SE1W4LT5qOtNZq5PQhiKY2;
            this.__cache_IQ2pVX5CDHsOtGaaW27WN2 = other.__cache_IQ2pVX5CDHsOtGaaW27WN2;
            this.__p_C2cnyAX5LKHN6uuK4rd3s6 = other.__p_C2cnyAX5LKHN6uuK4rd3s6;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_D5hhDTA35qKLp9uS10SaDg", in __p_D5hhDTA35qKLp9uS10SaDg), n1.CompilationHelper.GetValueOrExisting(values, "__p_EFbxr2T0ySSNSP4jrbEI61", in __p_EFbxr2T0ySSNSP4jrbEI61), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pxl8heoJaRPO0RLVOkvvdA", in __p_Pxl8heoJaRPO0RLVOkvvdA), n1.CompilationHelper.GetValueOrExisting(values, "__p_SE1W4LT5qOtNZq5PQhiKY2", in __p_SE1W4LT5qOtNZq5PQhiKY2), n1.CompilationHelper.GetValueOrExisting(values, "__cache_IQ2pVX5CDHsOtGaaW27WN2", in __cache_IQ2pVX5CDHsOtGaaW27WN2), n1.CompilationHelper.GetValueOrExisting(values, "__p_C2cnyAX5LKHN6uuK4rd3s6", in __p_C2cnyAX5LKHN6uuK4rd3s6));
        }

        internal UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __WITH__(n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_D5hhDTA35qKLp9uS10SaDg, n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_EFbxr2T0ySSNSP4jrbEI61, n6.UDPSocket __p_Pxl8heoJaRPO0RLVOkvvdA, n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_SE1W4LT5qOtNZq5PQhiKY2, n19.Manager<n2.ValueTuple<n9.IResourceProvider<n24.Socket>, n5.IPAddress, bool>, n2.ValueTuple<n9.IResourceProvider<n24.Socket>>> __cache_IQ2pVX5CDHsOtGaaW27WN2, n6.DatagramReceiver __p_C2cnyAX5LKHN6uuK4rd3s6)
        {
            n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_D5hhDTA35qKLp9uS10SaDg != this.__p_D5hhDTA35qKLp9uS10SaDg || __p_EFbxr2T0ySSNSP4jrbEI61 != this.__p_EFbxr2T0ySSNSP4jrbEI61 || __p_Pxl8heoJaRPO0RLVOkvvdA != this.__p_Pxl8heoJaRPO0RLVOkvvdA || __p_SE1W4LT5qOtNZq5PQhiKY2 != this.__p_SE1W4LT5qOtNZq5PQhiKY2 || __cache_IQ2pVX5CDHsOtGaaW27WN2 != this.__cache_IQ2pVX5CDHsOtGaaW27WN2 || __p_C2cnyAX5LKHN6uuK4rd3s6 != this.__p_C2cnyAX5LKHN6uuK4rd3s6 ? new UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw(this)
                {__p_D5hhDTA35qKLp9uS10SaDg = __p_D5hhDTA35qKLp9uS10SaDg, __p_EFbxr2T0ySSNSP4jrbEI61 = __p_EFbxr2T0ySSNSP4jrbEI61, __p_Pxl8heoJaRPO0RLVOkvvdA = __p_Pxl8heoJaRPO0RLVOkvvdA, __p_SE1W4LT5qOtNZq5PQhiKY2 = __p_SE1W4LT5qOtNZq5PQhiKY2, __cache_IQ2pVX5CDHsOtGaaW27WN2 = __cache_IQ2pVX5CDHsOtGaaW27WN2, __p_C2cnyAX5LKHN6uuK4rd3s6 = __p_C2cnyAX5LKHN6uuK4rd3s6} : that_0;
            else
            {
                this.__p_D5hhDTA35qKLp9uS10SaDg = __p_D5hhDTA35qKLp9uS10SaDg;
                this.__p_EFbxr2T0ySSNSP4jrbEI61 = __p_EFbxr2T0ySSNSP4jrbEI61;
                this.__p_Pxl8heoJaRPO0RLVOkvvdA = __p_Pxl8heoJaRPO0RLVOkvvdA;
                this.__p_SE1W4LT5qOtNZq5PQhiKY2 = __p_SE1W4LT5qOtNZq5PQhiKY2;
                this.__cache_IQ2pVX5CDHsOtGaaW27WN2 = __cache_IQ2pVX5CDHsOtGaaW27WN2;
                this.__p_C2cnyAX5LKHN6uuK4rd3s6 = __p_C2cnyAX5LKHN6uuK4rd3s6;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 236473U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "NqOArIZnZHfQJCMXWLcZF9", Name = "ToDatagrams_NqOArIZnZHfQJCMXWLcZF9")]
    [n2.SerializableAttribute]
    public class ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 Create(n1.NodeContext Node_Context)
        {
            var instance = new ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 CreateDefault()
        {
            var instance = new ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 Update(n2.IObservable<n10.IEnumerable<byte>> Input_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Remote_Address_In, [n4.SerializedDefaultValueAttribute("4444", false)] int Remote_Port_In, out n2.IObservable<n6.Datagram> Output_Out)
        {
            var Output_2 = this.__p_LJOefuMiV2tPYapdXRPrhk.Update(Input_In: Remote_Address_In, Result_Out: out n5.IPAddress Result_0, Is_Valid_Out: out bool Is_Valid_1);
            var State_Output_4 = this.__p_CzSdWo3yQZSNIGaFhRu4jQ.Update(Address_In: Result_0, Port_In: Remote_Port_In, Output_Out: out n5.IPEndPoint Output_3);
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_14 = this.__p_L83vHGBnk3HNbk688r2s7l.Update<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Value_In: Input_In, Selector_In: (n10.IEnumerable<byte> Arg_1_In_7, int Arg_2_In_8) =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n22._Operations_.FromSequence<byte>(Input_In: Arg_1_In_7, Result_Out: out n12.Spread<byte> Result_9);
                n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Nwq063zt1QsPf2dSmTdAWp", 236487U);
                n58._Operations_.Create(Node_Context: Node_Context_10, Remote_End_Point_In: Output_3, Payload_In: Result_9, Output_Out: out n6.Datagram Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<n6.Datagram> Result_12, Changed_Out: out bool Changed_13);
            Output_Out = Result_12;
            n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Output_2 != this.__p_LJOefuMiV2tPYapdXRPrhk || State_Output_4 != this.__p_CzSdWo3yQZSNIGaFhRu4jQ || Output_14 != this.__p_L83vHGBnk3HNbk688r2s7l ? new ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(this)
                {__p_LJOefuMiV2tPYapdXRPrhk = Output_2, __p_CzSdWo3yQZSNIGaFhRu4jQ = State_Output_4, __p_L83vHGBnk3HNbk688r2s7l = Output_14} : that_15;
            else
            {
                this.__p_LJOefuMiV2tPYapdXRPrhk = Output_2;
                this.__p_CzSdWo3yQZSNIGaFhRu4jQ = State_Output_4;
                this.__p_L83vHGBnk3HNbk688r2s7l = Output_14;
            }

            return that_15;
        }

        public n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "CzSdWo3yQZSNIGaFhRu4jQ", 236495U);
            var Output_1 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "LJOefuMiV2tPYapdXRPrhk", 236499U);
            var Output_3 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "L83vHGBnk3HNbk688r2s7l", 236476U);
            var Output_5 = n49.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n10.IEnumerable<byte>>, n10.IEnumerable<byte>, n6.Datagram>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_4);
            n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 that_6 = this;
            this.__p_CzSdWo3yQZSNIGaFhRu4jQ = Output_1;
            this.__p_LJOefuMiV2tPYapdXRPrhk = Output_3;
            this.__p_L83vHGBnk3HNbk688r2s7l = Output_5;
            return that_6;
        }

        public n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 __CreateDefault__()
        {
            n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 that_0 = this;
            this.__p_LJOefuMiV2tPYapdXRPrhk = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__p_CzSdWo3yQZSNIGaFhRu4jQ = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.CreateDefault();
            this.__p_L83vHGBnk3HNbk688r2s7l = n49.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n10.IEnumerable<byte>>, n10.IEnumerable<byte>, n6.Datagram>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LJOefuMiV2tPYapdXRPrhk);
            n1.CompilationHelper.SafeDispose(this.__p_CzSdWo3yQZSNIGaFhRu4jQ);
            n1.CompilationHelper.SafeDispose(this.__p_L83vHGBnk3HNbk688r2s7l);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 236499U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "LJOefuMiV2tPYapdXRPrhk", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_LJOefuMiV2tPYapdXRPrhk;
        [n1.ElementAttribute(TracingId = 236495U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CzSdWo3yQZSNIGaFhRu4jQ", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_CzSdWo3yQZSNIGaFhRu4jQ;
        [n1.ElementAttribute(TracingId = 236476U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "L83vHGBnk3HNbk688r2s7l", Name = "Select", IsManaged = true, IsAutoGenerated = true)]
        public n49.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n10.IEnumerable<byte>>, n10.IEnumerable<byte>, n6.Datagram> __p_L83vHGBnk3HNbk688r2s7l;
        public ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 other): base(other)
        {
            this.__p_LJOefuMiV2tPYapdXRPrhk = other.__p_LJOefuMiV2tPYapdXRPrhk;
            this.__p_CzSdWo3yQZSNIGaFhRu4jQ = other.__p_CzSdWo3yQZSNIGaFhRu4jQ;
            this.__p_L83vHGBnk3HNbk688r2s7l = other.__p_L83vHGBnk3HNbk688r2s7l;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LJOefuMiV2tPYapdXRPrhk", in __p_LJOefuMiV2tPYapdXRPrhk), n1.CompilationHelper.GetValueOrExisting(values, "__p_CzSdWo3yQZSNIGaFhRu4jQ", in __p_CzSdWo3yQZSNIGaFhRu4jQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_L83vHGBnk3HNbk688r2s7l", in __p_L83vHGBnk3HNbk688r2s7l));
        }

        internal ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 __WITH__(n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_LJOefuMiV2tPYapdXRPrhk, n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_CzSdWo3yQZSNIGaFhRu4jQ, n49.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n10.IEnumerable<byte>>, n10.IEnumerable<byte>, n6.Datagram> __p_L83vHGBnk3HNbk688r2s7l)
        {
            n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LJOefuMiV2tPYapdXRPrhk != this.__p_LJOefuMiV2tPYapdXRPrhk || __p_CzSdWo3yQZSNIGaFhRu4jQ != this.__p_CzSdWo3yQZSNIGaFhRu4jQ || __p_L83vHGBnk3HNbk688r2s7l != this.__p_L83vHGBnk3HNbk688r2s7l ? new ToDatagrams_NqOArIZnZHfQJCMXWLcZF9(this)
                {__p_LJOefuMiV2tPYapdXRPrhk = __p_LJOefuMiV2tPYapdXRPrhk, __p_CzSdWo3yQZSNIGaFhRu4jQ = __p_CzSdWo3yQZSNIGaFhRu4jQ, __p_L83vHGBnk3HNbk688r2s7l = __p_L83vHGBnk3HNbk688r2s7l} : that_0;
            else
            {
                this.__p_LJOefuMiV2tPYapdXRPrhk = __p_LJOefuMiV2tPYapdXRPrhk;
                this.__p_CzSdWo3yQZSNIGaFhRu4jQ = __p_CzSdWo3yQZSNIGaFhRu4jQ;
                this.__p_L83vHGBnk3HNbk688r2s7l = __p_L83vHGBnk3HNbk688r2s7l;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 236531U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ABWqm1HsYpNPHycPXOjEv8", Name = "UdpClient_ABWqm1HsYpNPHycPXOjEv8")]
    [n2.SerializableAttribute]
    public class UdpClient_ABWqm1HsYpNPHycPXOjEv8 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 Create(n1.NodeContext Node_Context)
        {
            var instance = new UdpClient_ABWqm1HsYpNPHycPXOjEv8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 CreateDefault()
        {
            var instance = new UdpClient_ABWqm1HsYpNPHycPXOjEv8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 Update(n10.IEnumerable<byte> Input_In, bool Send_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Remote_Address_In, [n4.SerializedDefaultValueAttribute("4444", false)] int Remote_Port_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Is_Open_Out)
        {
            n32._Operations_.Update_H<n10.IEnumerable<byte>>(Input_In: this.__p_UzlBmXflzKsPoZw3Fe7OYu, Message_In: Input_In, Send_In: Send_In, Output_Out: out n31.ToObservable<n10.IEnumerable<byte>> Output_0, Result_Out: out n2.IObservable<n10.IEnumerable<byte>> Result_1);
            var State_Output_3 = this.__p_Ru6YhunzcWnOjzHNXBsK8Y.Update(Input_In: Result_1, Remote_Address_In: Remote_Address_In, Remote_Port_In: Remote_Port_In, Output_Out: out n2.IObservable<n6.Datagram> Output_2);
            var Output_5 = this.__p_H6nJgUtUVsWMqfjYSS5vh4.Update(Datagrams_In: Output_2, Multicast_Address_In: Remote_Address_In, Is_Open_Out: out bool Is_Open_4);
            bool SetEnabled_6 = true;
            var Output_7 = Output_5;
            if (SetEnabled_6)
            {
                Output_7 = Output_5.SetEnabled(Enabled_In: Enabled_In);
            }

            Is_Open_Out = Is_Open_4;
            n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_0 != this.__p_UzlBmXflzKsPoZw3Fe7OYu || State_Output_3 != this.__p_Ru6YhunzcWnOjzHNXBsK8Y || Output_7 != this.__p_H6nJgUtUVsWMqfjYSS5vh4 ? new UdpClient_ABWqm1HsYpNPHycPXOjEv8(this)
                {__p_UzlBmXflzKsPoZw3Fe7OYu = Output_0, __p_Ru6YhunzcWnOjzHNXBsK8Y = State_Output_3, __p_H6nJgUtUVsWMqfjYSS5vh4 = Output_7} : that_8;
            else
            {
                this.__p_UzlBmXflzKsPoZw3Fe7OYu = Output_0;
                this.__p_Ru6YhunzcWnOjzHNXBsK8Y = State_Output_3;
                this.__p_H6nJgUtUVsWMqfjYSS5vh4 = Output_7;
            }

            return that_8;
        }

        public n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "UzlBmXflzKsPoZw3Fe7OYu", 236534U);
            n32._Operations_.Create_H<n10.IEnumerable<byte>>(Node_Context: Node_Context_0, Output_Out: out n31.ToObservable<n10.IEnumerable<byte>> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Ru6YhunzcWnOjzHNXBsK8Y", 236538U);
            var Output_3 = n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "H6nJgUtUVsWMqfjYSS5vh4", 236543U);
            var Output_5 = n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj.Create(Node_Context: Node_Context_4);
            n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 that_6 = this;
            this.__p_UzlBmXflzKsPoZw3Fe7OYu = Output_1;
            this.__p_Ru6YhunzcWnOjzHNXBsK8Y = Output_3;
            this.__p_H6nJgUtUVsWMqfjYSS5vh4 = Output_5;
            return that_6;
        }

        public n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 __CreateDefault__()
        {
            n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 that_0 = this;
            this.__p_UzlBmXflzKsPoZw3Fe7OYu = default(n31.ToObservable<n10.IEnumerable<byte>>);
            this.__p_Ru6YhunzcWnOjzHNXBsK8Y = n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9.CreateDefault();
            this.__p_H6nJgUtUVsWMqfjYSS5vh4 = n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UzlBmXflzKsPoZw3Fe7OYu);
            n1.CompilationHelper.SafeDispose(this.__p_Ru6YhunzcWnOjzHNXBsK8Y);
            n1.CompilationHelper.SafeDispose(this.__p_H6nJgUtUVsWMqfjYSS5vh4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 236534U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "UzlBmXflzKsPoZw3Fe7OYu", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n31.ToObservable<n10.IEnumerable<byte>> __p_UzlBmXflzKsPoZw3Fe7OYu;
        [n1.ElementAttribute(TracingId = 236538U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Ru6YhunzcWnOjzHNXBsK8Y", Name = "ToDatagrams", IsManaged = true, IsAutoGenerated = true)]
        public n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 __p_Ru6YhunzcWnOjzHNXBsK8Y;
        [n1.ElementAttribute(TracingId = 236543U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "H6nJgUtUVsWMqfjYSS5vh4", Name = "UdpClient (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj __p_H6nJgUtUVsWMqfjYSS5vh4;
        public UdpClient_ABWqm1HsYpNPHycPXOjEv8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UdpClient_ABWqm1HsYpNPHycPXOjEv8(UdpClient_ABWqm1HsYpNPHycPXOjEv8 other): base(other)
        {
            this.__p_UzlBmXflzKsPoZw3Fe7OYu = other.__p_UzlBmXflzKsPoZw3Fe7OYu;
            this.__p_Ru6YhunzcWnOjzHNXBsK8Y = other.__p_Ru6YhunzcWnOjzHNXBsK8Y;
            this.__p_H6nJgUtUVsWMqfjYSS5vh4 = other.__p_H6nJgUtUVsWMqfjYSS5vh4;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UzlBmXflzKsPoZw3Fe7OYu", in __p_UzlBmXflzKsPoZw3Fe7OYu), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ru6YhunzcWnOjzHNXBsK8Y", in __p_Ru6YhunzcWnOjzHNXBsK8Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_H6nJgUtUVsWMqfjYSS5vh4", in __p_H6nJgUtUVsWMqfjYSS5vh4));
        }

        internal UdpClient_ABWqm1HsYpNPHycPXOjEv8 __WITH__(n31.ToObservable<n10.IEnumerable<byte>> __p_UzlBmXflzKsPoZw3Fe7OYu, n3.ToDatagrams_NqOArIZnZHfQJCMXWLcZF9 __p_Ru6YhunzcWnOjzHNXBsK8Y, n3.UdpClient_Reactive_BOd1NI2Q70rNLdxNE7z8jj __p_H6nJgUtUVsWMqfjYSS5vh4)
        {
            n3.UdpClient_ABWqm1HsYpNPHycPXOjEv8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UzlBmXflzKsPoZw3Fe7OYu != this.__p_UzlBmXflzKsPoZw3Fe7OYu || __p_Ru6YhunzcWnOjzHNXBsK8Y != this.__p_Ru6YhunzcWnOjzHNXBsK8Y || __p_H6nJgUtUVsWMqfjYSS5vh4 != this.__p_H6nJgUtUVsWMqfjYSS5vh4 ? new UdpClient_ABWqm1HsYpNPHycPXOjEv8(this)
                {__p_UzlBmXflzKsPoZw3Fe7OYu = __p_UzlBmXflzKsPoZw3Fe7OYu, __p_Ru6YhunzcWnOjzHNXBsK8Y = __p_Ru6YhunzcWnOjzHNXBsK8Y, __p_H6nJgUtUVsWMqfjYSS5vh4 = __p_H6nJgUtUVsWMqfjYSS5vh4} : that_0;
            else
            {
                this.__p_UzlBmXflzKsPoZw3Fe7OYu = __p_UzlBmXflzKsPoZw3Fe7OYu;
                this.__p_Ru6YhunzcWnOjzHNXBsK8Y = __p_Ru6YhunzcWnOjzHNXBsK8Y;
                this.__p_H6nJgUtUVsWMqfjYSS5vh4 = __p_H6nJgUtUVsWMqfjYSS5vh4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 236580U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "KWe4UurP6xMOND9k3h1iMA", Name = "UdpServer_KWe4UurP6xMOND9k3h1iMA")]
    [n2.SerializableAttribute]
    public class UdpServer_KWe4UurP6xMOND9k3h1iMA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.UdpServer_KWe4UurP6xMOND9k3h1iMA Create(n1.NodeContext Node_Context)
        {
            var instance = new UdpServer_KWe4UurP6xMOND9k3h1iMA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.UdpServer_KWe4UurP6xMOND9k3h1iMA CreateDefault()
        {
            var instance = new UdpServer_KWe4UurP6xMOND9k3h1iMA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.UdpServer_KWe4UurP6xMOND9k3h1iMA Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Local_Address_In, [n4.SerializedDefaultValueAttribute("4444", false)] int Local_Port_In, [n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Multicast_Group_Address_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n12.Spread<byte> Output_Out, out n5.IPAddress Address_Out, out bool On_Data_Out)
        {
            var Output_2 = this.__p_GYiEBHbFIuUNvj0zOClNMp.Update(Local_Address_In: Local_Address_In, Local_Port_In: Local_Port_In, Multicast_Address_In: Multicast_Group_Address_In, Datagrams_Out: out n2.IObservable<n6.Datagram> Datagrams_0, Is_Open_Out: out bool Is_Open_1);
            bool SetEnabled_3 = true;
            var Output_4 = Output_2;
            if (SetEnabled_3)
            {
                Output_4 = Output_2.SetEnabled(Enabled_In: Enabled_In);
            }

            bool Reset_5 = false;
            bool Update_6 = true;
            var Output_7 = this.__p_FSQtUNjLhhHPWb8yzSf2Tq;
            if (Update_6)
            {
                n59._Operations_.Update_H<n6.Datagram>(Input_In: this.__p_FSQtUNjLhhHPWb8yzSf2Tq, Async_Notifications_In: Datagrams_0, Reset_In: Reset_5, Output_Out: out Output_7);
            }

            n59._Operations_.GetData_H<n6.Datagram>(Input_In: Output_7, Output_Out: out n31.HoldLatest<n6.Datagram> Output_8, Value_Out: out n6.Datagram Value_9, On_Data_Out: out bool On_Data_10);
            Value_9.Split(remoteEndPoint: out n5.IPEndPoint Remote_End_Point_11, payload: out n12.Spread<byte> Payload_12);
            var Address_13 = Remote_End_Point_11.Address;
            Output_Out = Payload_12;
            Address_Out = Address_13;
            On_Data_Out = On_Data_10;
            n3.UdpServer_KWe4UurP6xMOND9k3h1iMA that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_4 != this.__p_GYiEBHbFIuUNvj0zOClNMp || Output_8 != this.__p_FSQtUNjLhhHPWb8yzSf2Tq ? new UdpServer_KWe4UurP6xMOND9k3h1iMA(this)
                {__p_GYiEBHbFIuUNvj0zOClNMp = Output_4, __p_FSQtUNjLhhHPWb8yzSf2Tq = Output_8} : that_14;
            else
            {
                this.__p_GYiEBHbFIuUNvj0zOClNMp = Output_4;
                this.__p_FSQtUNjLhhHPWb8yzSf2Tq = Output_8;
            }

            return that_14;
        }

        public n3.UdpServer_KWe4UurP6xMOND9k3h1iMA __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "GYiEBHbFIuUNvj0zOClNMp", 236583U);
            var Output_1 = n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "FSQtUNjLhhHPWb8yzSf2Tq", 236590U);
            n6.Datagram Initial_Result_3 = default(n6.Datagram);
            n59._Operations_.Create_H<n6.Datagram>(Node_Context: Node_Context_2, Initial_Result_In: Initial_Result_3, Output_Out: out n31.HoldLatest<n6.Datagram> Output_4);
            n3.UdpServer_KWe4UurP6xMOND9k3h1iMA that_5 = this;
            this.__p_GYiEBHbFIuUNvj0zOClNMp = Output_1;
            this.__p_FSQtUNjLhhHPWb8yzSf2Tq = Output_4;
            return that_5;
        }

        public n3.UdpServer_KWe4UurP6xMOND9k3h1iMA __CreateDefault__()
        {
            n3.UdpServer_KWe4UurP6xMOND9k3h1iMA that_0 = this;
            this.__p_GYiEBHbFIuUNvj0zOClNMp = n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw.CreateDefault();
            this.__p_FSQtUNjLhhHPWb8yzSf2Tq = default(n31.HoldLatest<n6.Datagram>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GYiEBHbFIuUNvj0zOClNMp);
            n1.CompilationHelper.SafeDispose(this.__p_FSQtUNjLhhHPWb8yzSf2Tq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 236583U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GYiEBHbFIuUNvj0zOClNMp", Name = "UdpServer (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __p_GYiEBHbFIuUNvj0zOClNMp;
        [n1.ElementAttribute(TracingId = 236590U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "FSQtUNjLhhHPWb8yzSf2Tq", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n6.Datagram> __p_FSQtUNjLhhHPWb8yzSf2Tq;
        public UdpServer_KWe4UurP6xMOND9k3h1iMA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UdpServer_KWe4UurP6xMOND9k3h1iMA(UdpServer_KWe4UurP6xMOND9k3h1iMA other): base(other)
        {
            this.__p_GYiEBHbFIuUNvj0zOClNMp = other.__p_GYiEBHbFIuUNvj0zOClNMp;
            this.__p_FSQtUNjLhhHPWb8yzSf2Tq = other.__p_FSQtUNjLhhHPWb8yzSf2Tq;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GYiEBHbFIuUNvj0zOClNMp", in __p_GYiEBHbFIuUNvj0zOClNMp), n1.CompilationHelper.GetValueOrExisting(values, "__p_FSQtUNjLhhHPWb8yzSf2Tq", in __p_FSQtUNjLhhHPWb8yzSf2Tq));
        }

        internal UdpServer_KWe4UurP6xMOND9k3h1iMA __WITH__(n3.UdpServer_Reactive_DVOunIaysXuOsl2X0gaBGw __p_GYiEBHbFIuUNvj0zOClNMp, n31.HoldLatest<n6.Datagram> __p_FSQtUNjLhhHPWb8yzSf2Tq)
        {
            n3.UdpServer_KWe4UurP6xMOND9k3h1iMA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GYiEBHbFIuUNvj0zOClNMp != this.__p_GYiEBHbFIuUNvj0zOClNMp || __p_FSQtUNjLhhHPWb8yzSf2Tq != this.__p_FSQtUNjLhhHPWb8yzSf2Tq ? new UdpServer_KWe4UurP6xMOND9k3h1iMA(this)
                {__p_GYiEBHbFIuUNvj0zOClNMp = __p_GYiEBHbFIuUNvj0zOClNMp, __p_FSQtUNjLhhHPWb8yzSf2Tq = __p_FSQtUNjLhhHPWb8yzSf2Tq} : that_0;
            else
            {
                this.__p_GYiEBHbFIuUNvj0zOClNMp = __p_GYiEBHbFIuUNvj0zOClNMp;
                this.__p_FSQtUNjLhhHPWb8yzSf2Tq = __p_FSQtUNjLhhHPWb8yzSf2Tq;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 236757U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GUYRku2XzpsMgeeeoNpw2g", Name = "ToDatagram_GUYRku2XzpsMgeeeoNpw2g")]
    [n2.SerializableAttribute]
    public class ToDatagram_GUYRku2XzpsMgeeeoNpw2g : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g Create(n1.NodeContext Node_Context)
        {
            var instance = new ToDatagram_GUYRku2XzpsMgeeeoNpw2g(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g CreateDefault()
        {
            var instance = new ToDatagram_GUYRku2XzpsMgeeeoNpw2g(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g Update(n10.IEnumerable<byte> Input_In, [n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Remote_Address_In, [n4.SerializedDefaultValueAttribute("4444", false)] int Remote_Port_In, out n6.Datagram Output_Out)
        {
            n22._Operations_.FromSequence<byte>(Input_In: Input_In, Result_Out: out n12.Spread<byte> Result_0);
            var Output_3 = this.__p_H5YMif4GooEQDrtiVef7Z4.Update(Input_In: Remote_Address_In, Result_Out: out n5.IPAddress Result_1, Is_Valid_Out: out bool Is_Valid_2);
            var State_Output_5 = this.__p_IyN0tr4v3jLP37IBQewnvF.Update(Address_In: Result_1, Port_In: Remote_Port_In, Output_Out: out n5.IPEndPoint Output_4);
            n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "B7QCNDnAhrNOZRrZ29BDDh", 236772U);
            n58._Operations_.Create(Node_Context: Node_Context_6, Remote_End_Point_In: Output_4, Payload_In: Result_0, Output_Out: out n6.Datagram Output_7);
            Output_Out = Output_7;
            n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_3 != this.__p_H5YMif4GooEQDrtiVef7Z4 || State_Output_5 != this.__p_IyN0tr4v3jLP37IBQewnvF ? new ToDatagram_GUYRku2XzpsMgeeeoNpw2g(this)
                {__p_H5YMif4GooEQDrtiVef7Z4 = Output_3, __p_IyN0tr4v3jLP37IBQewnvF = State_Output_5} : that_8;
            else
            {
                this.__p_H5YMif4GooEQDrtiVef7Z4 = Output_3;
                this.__p_IyN0tr4v3jLP37IBQewnvF = State_Output_5;
            }

            return that_8;
        }

        public n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IyN0tr4v3jLP37IBQewnvF", 236761U);
            var Output_1 = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "H5YMif4GooEQDrtiVef7Z4", 236765U);
            var Output_3 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_2);
            n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g that_4 = this;
            this.__p_IyN0tr4v3jLP37IBQewnvF = Output_1;
            this.__p_H5YMif4GooEQDrtiVef7Z4 = Output_3;
            return that_4;
        }

        public n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g __CreateDefault__()
        {
            n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g that_0 = this;
            this.__p_H5YMif4GooEQDrtiVef7Z4 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__p_IyN0tr4v3jLP37IBQewnvF = n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_H5YMif4GooEQDrtiVef7Z4);
            n1.CompilationHelper.SafeDispose(this.__p_IyN0tr4v3jLP37IBQewnvF);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 236765U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "H5YMif4GooEQDrtiVef7Z4", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_H5YMif4GooEQDrtiVef7Z4;
        [n1.ElementAttribute(TracingId = 236761U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IyN0tr4v3jLP37IBQewnvF", Name = "IPEndPoint", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_IyN0tr4v3jLP37IBQewnvF;
        public ToDatagram_GUYRku2XzpsMgeeeoNpw2g(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToDatagram_GUYRku2XzpsMgeeeoNpw2g(ToDatagram_GUYRku2XzpsMgeeeoNpw2g other): base(other)
        {
            this.__p_H5YMif4GooEQDrtiVef7Z4 = other.__p_H5YMif4GooEQDrtiVef7Z4;
            this.__p_IyN0tr4v3jLP37IBQewnvF = other.__p_IyN0tr4v3jLP37IBQewnvF;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H5YMif4GooEQDrtiVef7Z4", in __p_H5YMif4GooEQDrtiVef7Z4), n1.CompilationHelper.GetValueOrExisting(values, "__p_IyN0tr4v3jLP37IBQewnvF", in __p_IyN0tr4v3jLP37IBQewnvF));
        }

        internal ToDatagram_GUYRku2XzpsMgeeeoNpw2g __WITH__(n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_H5YMif4GooEQDrtiVef7Z4, n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __p_IyN0tr4v3jLP37IBQewnvF)
        {
            n3.ToDatagram_GUYRku2XzpsMgeeeoNpw2g that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_H5YMif4GooEQDrtiVef7Z4 != this.__p_H5YMif4GooEQDrtiVef7Z4 || __p_IyN0tr4v3jLP37IBQewnvF != this.__p_IyN0tr4v3jLP37IBQewnvF ? new ToDatagram_GUYRku2XzpsMgeeeoNpw2g(this)
                {__p_H5YMif4GooEQDrtiVef7Z4 = __p_H5YMif4GooEQDrtiVef7Z4, __p_IyN0tr4v3jLP37IBQewnvF = __p_IyN0tr4v3jLP37IBQewnvF} : that_0;
            else
            {
                this.__p_H5YMif4GooEQDrtiVef7Z4 = __p_H5YMif4GooEQDrtiVef7Z4;
                this.__p_IyN0tr4v3jLP37IBQewnvF = __p_IyN0tr4v3jLP37IBQewnvF;
            }

            return that_0;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Socket.Datagram
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Create_Array(n5.IPEndPoint Remote_End_Point_In, byte[] Payload_In, out n6.Datagram Output_Out)
        {
            var Output_0 = new n6.Datagram(remoteEndPoint: Remote_End_Point_In, payload: Payload_In);
            Output_Out = Output_0;
            return;
        }

        public static void Payload_Array(n6.Datagram Input_In, out byte[] Payload_Array_Out)
        {
            var Payload_Array_0 = Input_In.PayloadArray;
            Payload_Array_Out = Payload_Array_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, n5.IPEndPoint Remote_End_Point_In, n12.Spread<byte> Payload_In, out n6.Datagram Output_Out)
        {
            var Output_0 = new n6.Datagram(remoteEndPoint: Remote_End_Point_In, payload: Payload_In);
            Output_Out = Output_0;
            return;
        }

        public static void Split_Array(n6.Datagram Input_In, out n5.IPEndPoint Remote_End_Point_Out, out byte[] Payload_Out)
        {
            Input_In.SplitArray(remoteEndPoint: out n5.IPEndPoint Remote_End_Point_0, payload: out byte[] Payload_1);
            Remote_End_Point_Out = Remote_End_Point_0;
            Payload_Out = Payload_1;
            return;
        }

        public static void Split(n6.Datagram Input_In, out n5.IPEndPoint Remote_End_Point_Out, out n12.Spread<byte> Payload_Out)
        {
            Input_In.Split(remoteEndPoint: out n5.IPEndPoint Remote_End_Point_0, payload: out n12.Spread<byte> Payload_1);
            Remote_End_Point_Out = Remote_End_Point_0;
            Payload_Out = Payload_1;
            return;
        }

        public static void RemoteEndPoint(n6.Datagram Input_In, out n5.IPEndPoint Remote_End_Point_Out)
        {
            var Remote_End_Point_0 = Input_In.RemoteEndPoint;
            Remote_End_Point_Out = Remote_End_Point_0;
            return;
        }

        public static void Payload(n6.Datagram Input_In, out n12.Spread<byte> Payload_Out)
        {
            var Payload_0 = Input_In.Payload;
            Payload_Out = Payload_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Socket.UdpServer_Reactive
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsValidMulticastIP(n5.IPAddress Input_In, out bool Result_Out)
        {
            byte __pad_Rco62rEl9x9LkuzzRqvHZF_0 = __slot_Rco62rEl9x9LkuzzRqvHZF;
            byte __pad_AxEJPMWrOiQQIOzdVpZVXn_1 = __slot_AxEJPMWrOiQQIOzdVpZVXn;
            var Result_2 = Input_In.GetAddressBytes();
            byte Default_Value_3 = 0;
            n23._Operations_.FirstOrDefault<byte[], byte>(Input_In: Result_2, Default_Value_In: Default_Value_3, Output_Out: out byte[] Output_4, Result_Out: out byte Result_5);
            var Result_6 = Result_5 >= __pad_Rco62rEl9x9LkuzzRqvHZF_0;
            var Result_7 = Result_5 <= __pad_AxEJPMWrOiQQIOzdVpZVXn_1;
            var Output_8 = Result_6 && Result_7;
            Result_Out = Output_8;
            return;
        }

        [n1.ElementAttribute(TracingId = 236355U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Rco62rEl9x9LkuzzRqvHZF", Name = "__slot_Rco62rEl9x9LkuzzRqvHZF")]
        public static byte __slot_Rco62rEl9x9LkuzzRqvHZF = 224;
        [n1.ElementAttribute(TracingId = 236369U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AxEJPMWrOiQQIOzdVpZVXn", Name = "__slot_AxEJPMWrOiQQIOzdVpZVXn")]
        public static byte __slot_AxEJPMWrOiQQIOzdVpZVXn = 239;
        static _Operations_()
        {
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Socket.UdpSocket.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n6.UDPSocket Output_Out)
        {
            var Output_0 = new n6.UDPSocket();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n6.UDPSocket Input_In, n5.IPEndPoint Local_End_Point_In, bool Bind_In, out n6.UDPSocket Output_Out, out n9.IResourceProvider<n24.Socket> Result_Out)
        {
            var Result_0 = Input_In.Update(localEndPoint: Local_End_Point_In, bind: Bind_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsOpen_H(n6.UDPSocket Input_In, out n6.UDPSocket Output_Out, out bool Is_Open_Out)
        {
            var Is_Open_0 = Input_In.IsOpen;
            Output_Out = Input_In;
            Is_Open_Out = Is_Open_0;
            return;
        }

        public static void SetEnabled_H(n6.UDPSocket Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n6.UDPSocket Output_Out)
        {
            Input_In.Enabled = Enabled_In;
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Socket.Receiver_Datagram.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n6.DatagramReceiver Output_Out)
        {
            var Output_0 = new n6.DatagramReceiver();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n6.DatagramReceiver Input_In, n9.IResourceProvider<n24.Socket> Local_Socket_In, out n6.DatagramReceiver Output_Out)
        {
            Input_In.Update(localSocket: Local_Socket_In);
            Output_Out = Input_In;
            return;
        }

        public static void Datagrams_H(n6.DatagramReceiver Input_In, out n6.DatagramReceiver Output_Out, out n2.IObservable<n6.Datagram> Datagrams_Out)
        {
            var Datagrams_0 = Input_In.Datagrams;
            Output_Out = Input_In;
            Datagrams_Out = Datagrams_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Socket.Sender_Datagram.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n6.DatagramSender Output_Out)
        {
            var Output_0 = new n6.DatagramSender(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n6.DatagramSender Input_In, n9.IResourceProvider<n24.Socket> Local_Socket_In, n2.IObservable<n6.Datagram> Datagrams_In, out n6.DatagramSender Output_Out)
        {
            Input_In.Update(localSocket: Local_Socket_In, datagrams: Datagrams_In);
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Ports.SerialPort
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n28.SerialPort Output_Out)
        {
            var Output_0 = new n28.SerialPort();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n28.SerialPort Input_In, n28.ComPort Port_Name_In, [n4.SerializedDefaultValueAttribute("115200", false)] int Baudrate_In, [n4.SerializedDefaultValueAttribute("8", false)] int Data_Bits_In, [n4.SerializedDefaultValueAttribute("One", false)] n29.StopBits Stop_Bits_In, n29.Parity Parity_In, n29.Handshake Handshake_In, bool Dtr_Enable_In, bool Rts_Enable_In, bool Break_State_In, bool Open_In, out n28.SerialPort Output_Out, out n9.IResourceProvider<n29.SerialPort> Result_Out)
        {
            var Result_0 = Input_In.Update(portName: Port_Name_In, baudrate: Baudrate_In, dataBits: Data_Bits_In, stopBits: Stop_Bits_In, parity: Parity_In, handshake: Handshake_In, dtrEnable: Dtr_Enable_In, rtsEnable: Rts_Enable_In, breakState: Break_State_In, open: Open_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsOpen_H(n28.SerialPort Input_In, out n28.SerialPort Output_Out, out bool Is_Open_Out)
        {
            var Is_Open_0 = Input_In.IsOpen;
            Output_Out = Input_In;
            Is_Open_Out = Is_Open_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Ports.ComPort
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n28.ComPort CreateDefault()
        {
            var Result_0 = n28.ComPort.CreateDefault();
            return Result_0;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Ports.Receiver
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n28.Receiver Output_Out)
        {
            var Output_0 = new n28.Receiver();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n28.Receiver Input_In, n9.IResourceProvider<n29.SerialPort> Port_In, out n28.Receiver Output_Out)
        {
            Input_In.Update(port: Port_In);
            Output_Out = Input_In;
            return;
        }

        public static void Data_H(n28.Receiver Input_In, out n28.Receiver Output_Out, out n2.IObservable<n12.Spread<byte>> Data_Out)
        {
            var Data_0 = Input_In.Data;
            Output_Out = Input_In;
            Data_Out = Data_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Ports.Sender
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n28.Sender Output_Out)
        {
            var Output_0 = new n28.Sender(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n28.Sender Input_In, n9.IResourceProvider<n29.SerialPort> Port_In, n2.IObservable<n12.Spread<byte>> Data_In, out n28.Sender Output_Out)
        {
            Input_In.Update(port: Port_In, data: Data_In);
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO
{
    [n1.ElementAttribute(TracingId = 237507U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AiAKpmuYyUIPIlE9TNeP81", Name = "SerialPort_AiAKpmuYyUIPIlE9TNeP81")]
    [n2.SerializableAttribute]
    public class SerialPort_AiAKpmuYyUIPIlE9TNeP81 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 Create(n1.NodeContext Node_Context)
        {
            var instance = new SerialPort_AiAKpmuYyUIPIlE9TNeP81(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 CreateDefault()
        {
            var instance = new SerialPort_AiAKpmuYyUIPIlE9TNeP81(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 Update(n12.Spread<byte> Input_In, bool Send_In, [n4.SerializedDefaultValueAttribute("8", false)] int Data_Bits_In, [n4.SerializedDefaultValueAttribute("One", false)] n29.StopBits Stop_Bits_In, n29.Parity Parity_In, n29.Handshake Handshake_In, bool Dtr_Enable_In, bool Rts_Enable_In, bool Break_State_In, [n4.SerializedDefaultValueAttribute("115200", false)] int Baudrate_In, n28.ComPort Port_Name_In, bool Open_In, out n12.Spread<byte> Output_Out, out bool On_Data_Out, out bool Is_Open_Out)
        {
            n32._Operations_.Update_H<n12.Spread<byte>>(Input_In: this.__p_SVi55zeLggbPF2wZ6wFaU8, Message_In: Input_In, Send_In: Send_In, Output_Out: out n31.ToObservable<n12.Spread<byte>> Output_0, Result_Out: out n2.IObservable<n12.Spread<byte>> Result_1);
            n28.SerialPort Input_2 = this.__p_GeJDz1kPWKZNN7m82li8MN;
            var Result_3 = Input_2.Update(portName: Port_Name_In, baudrate: Baudrate_In, dataBits: Data_Bits_In, stopBits: Stop_Bits_In, parity: Parity_In, handshake: Handshake_In, dtrEnable: Dtr_Enable_In, rtsEnable: Rts_Enable_In, breakState: Break_State_In, open: Open_In);
            bool Update_4 = true;
            var Output_5 = this.__p_ECvxUPhzJMpNPsPFPjPVbI;
            if (Update_4)
            {
                n28.Sender Input_6 = this.__p_ECvxUPhzJMpNPsPFPjPVbI;
                Input_6.Update(port: Result_3, data: Result_1);
                Output_5 = Input_6;
            }

            var Is_Open_7 = Input_2.IsOpen;
            bool Update_8 = true;
            var Output_9 = this.__p_JUtKKvwVUlKL2YL4AHVr5p;
            if (Update_8)
            {
                n28.Receiver Input_10 = this.__p_JUtKKvwVUlKL2YL4AHVr5p;
                Input_10.Update(port: Result_3);
                Output_9 = Input_10;
            }

            var Data_11 = Output_9.Data;
            n33._Operations_.Sample_H<n12.Spread<byte>>(Input_In: this.__p_JERgLNNfib6NWBqfaUCqEB, Async_Notifications_In: Data_11, Output_Out: out n31.Sampler<n12.Spread<byte>> Output_12, Notifications_Out: out n12.Spread<n12.Spread<byte>> Notifications_13, On_Data_Out: out bool On_Data_14);
            n22._Operations_.Flatten<n12.Spread<n12.Spread<byte>>, byte>(Input_In: Notifications_13, Output_Out: out n12.Spread<byte> Output_15);
            Output_Out = Output_15;
            On_Data_Out = On_Data_14;
            Is_Open_Out = Is_Open_7;
            n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = Output_0 != this.__p_SVi55zeLggbPF2wZ6wFaU8 || Input_2 != this.__p_GeJDz1kPWKZNN7m82li8MN || Output_5 != this.__p_ECvxUPhzJMpNPsPFPjPVbI || Output_9 != this.__p_JUtKKvwVUlKL2YL4AHVr5p || Output_12 != this.__p_JERgLNNfib6NWBqfaUCqEB ? new SerialPort_AiAKpmuYyUIPIlE9TNeP81(this)
                {__p_SVi55zeLggbPF2wZ6wFaU8 = Output_0, __p_GeJDz1kPWKZNN7m82li8MN = Input_2, __p_ECvxUPhzJMpNPsPFPjPVbI = Output_5, __p_JUtKKvwVUlKL2YL4AHVr5p = Output_9, __p_JERgLNNfib6NWBqfaUCqEB = Output_12} : that_16;
            else
            {
                this.__p_SVi55zeLggbPF2wZ6wFaU8 = Output_0;
                this.__p_GeJDz1kPWKZNN7m82li8MN = Input_2;
                this.__p_ECvxUPhzJMpNPsPFPjPVbI = Output_5;
                this.__p_JUtKKvwVUlKL2YL4AHVr5p = Output_9;
                this.__p_JERgLNNfib6NWBqfaUCqEB = Output_12;
            }

            return that_16;
        }

        public n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "GeJDz1kPWKZNN7m82li8MN", 237511U);
            n34._Operations_.Create_H(Node_Context: Node_Context_0, Output_Out: out n28.SerialPort Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "ECvxUPhzJMpNPsPFPjPVbI", 237539U);
            n35._Operations_.Create_H(Node_Context_In: Node_Context_2, Output_Out: out n28.Sender Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "JUtKKvwVUlKL2YL4AHVr5p", 237544U);
            n36._Operations_.Create_H(Node_Context: Node_Context_4, Output_Out: out n28.Receiver Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SVi55zeLggbPF2wZ6wFaU8", 237563U);
            n32._Operations_.Create_H<n12.Spread<byte>>(Node_Context: Node_Context_6, Output_Out: out n31.ToObservable<n12.Spread<byte>> Output_7);
            var Default_8 = n33._Operations_.CreateDefault_H<n12.Spread<byte>>();
            n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 that_9 = this;
            this.__p_GeJDz1kPWKZNN7m82li8MN = Output_1;
            this.__p_ECvxUPhzJMpNPsPFPjPVbI = Output_3;
            this.__p_JUtKKvwVUlKL2YL4AHVr5p = Output_5;
            this.__p_SVi55zeLggbPF2wZ6wFaU8 = Output_7;
            this.__p_JERgLNNfib6NWBqfaUCqEB = Default_8;
            return that_9;
        }

        public n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 __CreateDefault__()
        {
            n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 that_0 = this;
            this.__p_SVi55zeLggbPF2wZ6wFaU8 = default(n31.ToObservable<n12.Spread<byte>>);
            this.__p_GeJDz1kPWKZNN7m82li8MN = default(n28.SerialPort);
            this.__p_ECvxUPhzJMpNPsPFPjPVbI = default(n28.Sender);
            this.__p_JUtKKvwVUlKL2YL4AHVr5p = default(n28.Receiver);
            this.__p_JERgLNNfib6NWBqfaUCqEB = n33._Operations_.CreateDefault_H<n12.Spread<byte>>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SVi55zeLggbPF2wZ6wFaU8);
            n1.CompilationHelper.SafeDispose(this.__p_GeJDz1kPWKZNN7m82li8MN);
            n1.CompilationHelper.SafeDispose(this.__p_ECvxUPhzJMpNPsPFPjPVbI);
            n1.CompilationHelper.SafeDispose(this.__p_JUtKKvwVUlKL2YL4AHVr5p);
            n1.CompilationHelper.SafeDispose(this.__p_JERgLNNfib6NWBqfaUCqEB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 237563U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SVi55zeLggbPF2wZ6wFaU8", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n31.ToObservable<n12.Spread<byte>> __p_SVi55zeLggbPF2wZ6wFaU8;
        [n1.ElementAttribute(TracingId = 237511U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GeJDz1kPWKZNN7m82li8MN", Name = "SerialPort", IsManaged = true, IsAutoGenerated = true)]
        public n28.SerialPort __p_GeJDz1kPWKZNN7m82li8MN;
        [n1.ElementAttribute(TracingId = 237539U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ECvxUPhzJMpNPsPFPjPVbI", Name = "Sender", IsManaged = true, IsAutoGenerated = true)]
        public n28.Sender __p_ECvxUPhzJMpNPsPFPjPVbI;
        [n1.ElementAttribute(TracingId = 237544U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JUtKKvwVUlKL2YL4AHVr5p", Name = "Receiver", IsManaged = true, IsAutoGenerated = true)]
        public n28.Receiver __p_JUtKKvwVUlKL2YL4AHVr5p;
        [n1.ElementAttribute(TracingId = 237578U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JERgLNNfib6NWBqfaUCqEB", Name = "Sampler", IsManaged = true, IsAutoGenerated = true)]
        public n31.Sampler<n12.Spread<byte>> __p_JERgLNNfib6NWBqfaUCqEB;
        public SerialPort_AiAKpmuYyUIPIlE9TNeP81(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SerialPort_AiAKpmuYyUIPIlE9TNeP81(SerialPort_AiAKpmuYyUIPIlE9TNeP81 other): base(other)
        {
            this.__p_SVi55zeLggbPF2wZ6wFaU8 = other.__p_SVi55zeLggbPF2wZ6wFaU8;
            this.__p_GeJDz1kPWKZNN7m82li8MN = other.__p_GeJDz1kPWKZNN7m82li8MN;
            this.__p_ECvxUPhzJMpNPsPFPjPVbI = other.__p_ECvxUPhzJMpNPsPFPjPVbI;
            this.__p_JUtKKvwVUlKL2YL4AHVr5p = other.__p_JUtKKvwVUlKL2YL4AHVr5p;
            this.__p_JERgLNNfib6NWBqfaUCqEB = other.__p_JERgLNNfib6NWBqfaUCqEB;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SVi55zeLggbPF2wZ6wFaU8", in __p_SVi55zeLggbPF2wZ6wFaU8), n1.CompilationHelper.GetValueOrExisting(values, "__p_GeJDz1kPWKZNN7m82li8MN", in __p_GeJDz1kPWKZNN7m82li8MN), n1.CompilationHelper.GetValueOrExisting(values, "__p_ECvxUPhzJMpNPsPFPjPVbI", in __p_ECvxUPhzJMpNPsPFPjPVbI), n1.CompilationHelper.GetValueOrExisting(values, "__p_JUtKKvwVUlKL2YL4AHVr5p", in __p_JUtKKvwVUlKL2YL4AHVr5p), n1.CompilationHelper.GetValueOrExisting(values, "__p_JERgLNNfib6NWBqfaUCqEB", in __p_JERgLNNfib6NWBqfaUCqEB));
        }

        internal SerialPort_AiAKpmuYyUIPIlE9TNeP81 __WITH__(n31.ToObservable<n12.Spread<byte>> __p_SVi55zeLggbPF2wZ6wFaU8, n28.SerialPort __p_GeJDz1kPWKZNN7m82li8MN, n28.Sender __p_ECvxUPhzJMpNPsPFPjPVbI, n28.Receiver __p_JUtKKvwVUlKL2YL4AHVr5p, n31.Sampler<n12.Spread<byte>> __p_JERgLNNfib6NWBqfaUCqEB)
        {
            n30.SerialPort_AiAKpmuYyUIPIlE9TNeP81 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SVi55zeLggbPF2wZ6wFaU8 != this.__p_SVi55zeLggbPF2wZ6wFaU8 || __p_GeJDz1kPWKZNN7m82li8MN != this.__p_GeJDz1kPWKZNN7m82li8MN || __p_ECvxUPhzJMpNPsPFPjPVbI != this.__p_ECvxUPhzJMpNPsPFPjPVbI || __p_JUtKKvwVUlKL2YL4AHVr5p != this.__p_JUtKKvwVUlKL2YL4AHVr5p || __p_JERgLNNfib6NWBqfaUCqEB != this.__p_JERgLNNfib6NWBqfaUCqEB ? new SerialPort_AiAKpmuYyUIPIlE9TNeP81(this)
                {__p_SVi55zeLggbPF2wZ6wFaU8 = __p_SVi55zeLggbPF2wZ6wFaU8, __p_GeJDz1kPWKZNN7m82li8MN = __p_GeJDz1kPWKZNN7m82li8MN, __p_ECvxUPhzJMpNPsPFPjPVbI = __p_ECvxUPhzJMpNPsPFPjPVbI, __p_JUtKKvwVUlKL2YL4AHVr5p = __p_JUtKKvwVUlKL2YL4AHVr5p, __p_JERgLNNfib6NWBqfaUCqEB = __p_JERgLNNfib6NWBqfaUCqEB} : that_0;
            else
            {
                this.__p_SVi55zeLggbPF2wZ6wFaU8 = __p_SVi55zeLggbPF2wZ6wFaU8;
                this.__p_GeJDz1kPWKZNN7m82li8MN = __p_GeJDz1kPWKZNN7m82li8MN;
                this.__p_ECvxUPhzJMpNPsPFPjPVbI = __p_ECvxUPhzJMpNPsPFPjPVbI;
                this.__p_JUtKKvwVUlKL2YL4AHVr5p = __p_JUtKKvwVUlKL2YL4AHVr5p;
                this.__p_JERgLNNfib6NWBqfaUCqEB = __p_JERgLNNfib6NWBqfaUCqEB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 242876U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "TT8gWSNJDrLPfzy5QjExui", Name = "FileReader_String_TT8gWSNJDrLPfzy5QjExui")]
    [n2.SerializableAttribute]
    public class FileReader_String_TT8gWSNJDrLPfzy5QjExui : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_String_TT8gWSNJDrLPfzy5QjExui(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui CreateDefault()
        {
            var instance = new FileReader_String_TT8gWSNJDrLPfzy5QjExui(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui Update(n37.Path File_Path_In, n11.Encodings Encoding_In, bool Read_In, out string Output_Out)
        {
            n8.FileMode File_Mode_0 = __c_BMTHKIT7sVwQFv4QWVfAN3;
            n8.FileAccess File_Access_1 = __c_KpyDYYxJNDOLDCta8bfjh0;
            n8.FileShare File_Share_2 = __c_D0t7fBTdhWBP57Nk2a5GAU;
            n7.FileNode Input_3 = this.__p_QUNl2OVAGjhMlTeHErqbnN;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            var State_Output_6 = this.__p_ATHwEtLk7SJMxDXYN5GwxP.Update(Input_In: Result_4, Encoding_In: Encoding_In, Read_In: Read_In, Output_Out: out string Output_5);
            Output_Out = Output_5;
            n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Input_3 != this.__p_QUNl2OVAGjhMlTeHErqbnN || State_Output_6 != this.__p_ATHwEtLk7SJMxDXYN5GwxP ? new FileReader_String_TT8gWSNJDrLPfzy5QjExui(this)
                {__p_QUNl2OVAGjhMlTeHErqbnN = Input_3, __p_ATHwEtLk7SJMxDXYN5GwxP = State_Output_6} : that_7;
            else
            {
                this.__p_QUNl2OVAGjhMlTeHErqbnN = Input_3;
                this.__p_ATHwEtLk7SJMxDXYN5GwxP = State_Output_6;
            }

            return that_7;
        }

        public n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "ATHwEtLk7SJMxDXYN5GwxP", 242891U);
            var Output_1 = n38.StringReader_BOTojDz8Ou7NQQoQbWoirY.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "QUNl2OVAGjhMlTeHErqbnN", 242907U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_2, Output_Out: out n7.FileNode Output_3);
            n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui that_4 = this;
            this.__p_ATHwEtLk7SJMxDXYN5GwxP = Output_1;
            this.__p_QUNl2OVAGjhMlTeHErqbnN = Output_3;
            return that_4;
        }

        public n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui __CreateDefault__()
        {
            n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui that_0 = this;
            this.__p_QUNl2OVAGjhMlTeHErqbnN = default(n7.FileNode);
            this.__p_ATHwEtLk7SJMxDXYN5GwxP = n38.StringReader_BOTojDz8Ou7NQQoQbWoirY.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QUNl2OVAGjhMlTeHErqbnN);
            n1.CompilationHelper.SafeDispose(this.__p_ATHwEtLk7SJMxDXYN5GwxP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 242907U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "QUNl2OVAGjhMlTeHErqbnN", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_QUNl2OVAGjhMlTeHErqbnN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_BMTHKIT7sVwQFv4QWVfAN3 = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "BMTHKIT7sVwQFv4QWVfAN3");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_KpyDYYxJNDOLDCta8bfjh0 = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "KpyDYYxJNDOLDCta8bfjh0");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_D0t7fBTdhWBP57Nk2a5GAU = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "D0t7fBTdhWBP57Nk2a5GAU");
        [n1.ElementAttribute(TracingId = 242891U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ATHwEtLk7SJMxDXYN5GwxP", Name = "StringReader", IsManaged = true, IsAutoGenerated = true)]
        public n38.StringReader_BOTojDz8Ou7NQQoQbWoirY __p_ATHwEtLk7SJMxDXYN5GwxP;
        static FileReader_String_TT8gWSNJDrLPfzy5QjExui()
        {
        }

        public FileReader_String_TT8gWSNJDrLPfzy5QjExui(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_String_TT8gWSNJDrLPfzy5QjExui(FileReader_String_TT8gWSNJDrLPfzy5QjExui other): base(other)
        {
            this.__p_QUNl2OVAGjhMlTeHErqbnN = other.__p_QUNl2OVAGjhMlTeHErqbnN;
            this.__p_ATHwEtLk7SJMxDXYN5GwxP = other.__p_ATHwEtLk7SJMxDXYN5GwxP;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QUNl2OVAGjhMlTeHErqbnN", in __p_QUNl2OVAGjhMlTeHErqbnN), n1.CompilationHelper.GetValueOrExisting(values, "__p_ATHwEtLk7SJMxDXYN5GwxP", in __p_ATHwEtLk7SJMxDXYN5GwxP));
        }

        internal FileReader_String_TT8gWSNJDrLPfzy5QjExui __WITH__(n7.FileNode __p_QUNl2OVAGjhMlTeHErqbnN, n38.StringReader_BOTojDz8Ou7NQQoQbWoirY __p_ATHwEtLk7SJMxDXYN5GwxP)
        {
            n30.FileReader_String_TT8gWSNJDrLPfzy5QjExui that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QUNl2OVAGjhMlTeHErqbnN != this.__p_QUNl2OVAGjhMlTeHErqbnN || __p_ATHwEtLk7SJMxDXYN5GwxP != this.__p_ATHwEtLk7SJMxDXYN5GwxP ? new FileReader_String_TT8gWSNJDrLPfzy5QjExui(this)
                {__p_QUNl2OVAGjhMlTeHErqbnN = __p_QUNl2OVAGjhMlTeHErqbnN, __p_ATHwEtLk7SJMxDXYN5GwxP = __p_ATHwEtLk7SJMxDXYN5GwxP} : that_0;
            else
            {
                this.__p_QUNl2OVAGjhMlTeHErqbnN = __p_QUNl2OVAGjhMlTeHErqbnN;
                this.__p_ATHwEtLk7SJMxDXYN5GwxP = __p_ATHwEtLk7SJMxDXYN5GwxP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 242990U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Nbs971t4mpQOvLXHem7Bzs", Name = "FileReader_Nbs971t4mpQOvLXHem7Bzs")]
    [n2.SerializableAttribute]
    public class FileReader_Nbs971t4mpQOvLXHem7Bzs : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileReader_Nbs971t4mpQOvLXHem7Bzs Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_Nbs971t4mpQOvLXHem7Bzs(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileReader_Nbs971t4mpQOvLXHem7Bzs CreateDefault()
        {
            var instance = new FileReader_Nbs971t4mpQOvLXHem7Bzs(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileReader_Nbs971t4mpQOvLXHem7Bzs Update(n37.Path File_Path_In, bool Read_In, out n12.Spread<byte> Output_Out)
        {
            n8.FileMode File_Mode_0 = __c_OvH0R05D3yQNYSvCY9HFC0;
            n8.FileAccess File_Access_1 = __c_A8oPohfbGwVOHcM650rqBz;
            n8.FileShare File_Share_2 = __c_AaM5SHCmj8iMJVorzrAdOk;
            n7.FileNode Input_3 = this.__p_SkH792jdTG8PLOEkmUVRJy;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n7.ByteReader Input__this__5 = this.__p_T7s13LhBhokMtxuJBC68RK;
            var Result_6 = Input__this__5.Update(input: Result_4);
            n7.ByteCollector Input__this__7 = this.__p_NUcPuHSXpZKLiq2HZ1cWl5;
            var Result_8 = Input__this__7.Update(input: Result_6, collect: Read_In);
            Output_Out = Result_8;
            n30.FileReader_Nbs971t4mpQOvLXHem7Bzs that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = Input_3 != this.__p_SkH792jdTG8PLOEkmUVRJy || Input__this__5 != this.__p_T7s13LhBhokMtxuJBC68RK || Input__this__7 != this.__p_NUcPuHSXpZKLiq2HZ1cWl5 ? new FileReader_Nbs971t4mpQOvLXHem7Bzs(this)
                {__p_SkH792jdTG8PLOEkmUVRJy = Input_3, __p_T7s13LhBhokMtxuJBC68RK = Input__this__5, __p_NUcPuHSXpZKLiq2HZ1cWl5 = Input__this__7} : that_9;
            else
            {
                this.__p_SkH792jdTG8PLOEkmUVRJy = Input_3;
                this.__p_T7s13LhBhokMtxuJBC68RK = Input__this__5;
                this.__p_NUcPuHSXpZKLiq2HZ1cWl5 = Input__this__7;
            }

            return that_9;
        }

        public n30.FileReader_Nbs971t4mpQOvLXHem7Bzs __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SkH792jdTG8PLOEkmUVRJy", 243003U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "NUcPuHSXpZKLiq2HZ1cWl5", 243021U);
            n40._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n7.ByteCollector Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "T7s13LhBhokMtxuJBC68RK", 243029U);
            n41._Operations_.Create_H(Node_Context_In: Node_Context_4, Output_Out: out n7.ByteReader Output_5);
            n30.FileReader_Nbs971t4mpQOvLXHem7Bzs that_6 = this;
            this.__p_SkH792jdTG8PLOEkmUVRJy = Output_1;
            this.__p_NUcPuHSXpZKLiq2HZ1cWl5 = Output_3;
            this.__p_T7s13LhBhokMtxuJBC68RK = Output_5;
            return that_6;
        }

        public n30.FileReader_Nbs971t4mpQOvLXHem7Bzs __CreateDefault__()
        {
            n30.FileReader_Nbs971t4mpQOvLXHem7Bzs that_0 = this;
            this.__p_SkH792jdTG8PLOEkmUVRJy = default(n7.FileNode);
            this.__p_T7s13LhBhokMtxuJBC68RK = default(n7.ByteReader);
            this.__p_NUcPuHSXpZKLiq2HZ1cWl5 = default(n7.ByteCollector);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SkH792jdTG8PLOEkmUVRJy);
            n1.CompilationHelper.SafeDispose(this.__p_T7s13LhBhokMtxuJBC68RK);
            n1.CompilationHelper.SafeDispose(this.__p_NUcPuHSXpZKLiq2HZ1cWl5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243003U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SkH792jdTG8PLOEkmUVRJy", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_SkH792jdTG8PLOEkmUVRJy;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_OvH0R05D3yQNYSvCY9HFC0 = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "OvH0R05D3yQNYSvCY9HFC0");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_A8oPohfbGwVOHcM650rqBz = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "A8oPohfbGwVOHcM650rqBz");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_AaM5SHCmj8iMJVorzrAdOk = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "AaM5SHCmj8iMJVorzrAdOk");
        [n1.ElementAttribute(TracingId = 243029U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "T7s13LhBhokMtxuJBC68RK", Name = "ByteReader", IsManaged = true, IsAutoGenerated = true)]
        public n7.ByteReader __p_T7s13LhBhokMtxuJBC68RK;
        [n1.ElementAttribute(TracingId = 243021U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "NUcPuHSXpZKLiq2HZ1cWl5", Name = "ByteCollector", IsManaged = true, IsAutoGenerated = true)]
        public n7.ByteCollector __p_NUcPuHSXpZKLiq2HZ1cWl5;
        static FileReader_Nbs971t4mpQOvLXHem7Bzs()
        {
        }

        public FileReader_Nbs971t4mpQOvLXHem7Bzs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_Nbs971t4mpQOvLXHem7Bzs(FileReader_Nbs971t4mpQOvLXHem7Bzs other): base(other)
        {
            this.__p_SkH792jdTG8PLOEkmUVRJy = other.__p_SkH792jdTG8PLOEkmUVRJy;
            this.__p_T7s13LhBhokMtxuJBC68RK = other.__p_T7s13LhBhokMtxuJBC68RK;
            this.__p_NUcPuHSXpZKLiq2HZ1cWl5 = other.__p_NUcPuHSXpZKLiq2HZ1cWl5;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SkH792jdTG8PLOEkmUVRJy", in __p_SkH792jdTG8PLOEkmUVRJy), n1.CompilationHelper.GetValueOrExisting(values, "__p_T7s13LhBhokMtxuJBC68RK", in __p_T7s13LhBhokMtxuJBC68RK), n1.CompilationHelper.GetValueOrExisting(values, "__p_NUcPuHSXpZKLiq2HZ1cWl5", in __p_NUcPuHSXpZKLiq2HZ1cWl5));
        }

        internal FileReader_Nbs971t4mpQOvLXHem7Bzs __WITH__(n7.FileNode __p_SkH792jdTG8PLOEkmUVRJy, n7.ByteReader __p_T7s13LhBhokMtxuJBC68RK, n7.ByteCollector __p_NUcPuHSXpZKLiq2HZ1cWl5)
        {
            n30.FileReader_Nbs971t4mpQOvLXHem7Bzs that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SkH792jdTG8PLOEkmUVRJy != this.__p_SkH792jdTG8PLOEkmUVRJy || __p_T7s13LhBhokMtxuJBC68RK != this.__p_T7s13LhBhokMtxuJBC68RK || __p_NUcPuHSXpZKLiq2HZ1cWl5 != this.__p_NUcPuHSXpZKLiq2HZ1cWl5 ? new FileReader_Nbs971t4mpQOvLXHem7Bzs(this)
                {__p_SkH792jdTG8PLOEkmUVRJy = __p_SkH792jdTG8PLOEkmUVRJy, __p_T7s13LhBhokMtxuJBC68RK = __p_T7s13LhBhokMtxuJBC68RK, __p_NUcPuHSXpZKLiq2HZ1cWl5 = __p_NUcPuHSXpZKLiq2HZ1cWl5} : that_0;
            else
            {
                this.__p_SkH792jdTG8PLOEkmUVRJy = __p_SkH792jdTG8PLOEkmUVRJy;
                this.__p_T7s13LhBhokMtxuJBC68RK = __p_T7s13LhBhokMtxuJBC68RK;
                this.__p_NUcPuHSXpZKLiq2HZ1cWl5 = __p_NUcPuHSXpZKLiq2HZ1cWl5;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243074U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "U2bWfQ8dEnvPg38ttqISAx", Name = "FileWriter_U2bWfQ8dEnvPg38ttqISAx")]
    [n2.SerializableAttribute]
    public class FileWriter_U2bWfQ8dEnvPg38ttqISAx : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_U2bWfQ8dEnvPg38ttqISAx(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx CreateDefault()
        {
            var instance = new FileWriter_U2bWfQ8dEnvPg38ttqISAx(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx Update(n37.Path File_Path_In, n12.Spread<byte> Data_In, bool Append_In, bool Write_In)
        {
            n8.FileMode __pad_T2cueZ7c1VrPyG7tO8qd9w_0 = __slot_T2cueZ7c1VrPyG7tO8qd9w;
            n8.FileMode __pad_IHBXfeKQbdxPtdINYRLd0G_1 = __slot_IHBXfeKQbdxPtdINYRLd0G;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_T2cueZ7c1VrPyG7tO8qd9w_0, Input_2_In: __pad_IHBXfeKQbdxPtdINYRLd0G_1, Output_Out: out n8.FileMode Output_2);
            n8.FileAccess File_Access_3 = __c_CaqD3yBetnEMdjShJdEZSo;
            n8.FileShare File_Share_4 = __c_J2lPYubappYOV870ukZZym;
            n7.FileNode Input_5 = this.__p_LVoCyFJoX0iLzwZhlh8fCC;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_2, fileAccess: File_Access_3, fileShare: File_Share_4);
            n7.ByteChunkifier Input__this__7 = this.__p_EjYLBMwGZ5ELgqvmbSdSuG;
            var Result_8 = Input__this__7.Update(input: Data_In);
            bool Update_9 = true;
            var Output_10 = this.__p_IrAY9TMe4C4QCHDIEXNZoC;
            if (Update_9)
            {
                n7.ByteWriter Input__this__11 = this.__p_IrAY9TMe4C4QCHDIEXNZoC;
                Input__this__11.Update(input: Result_6, data: Result_8, write: Write_In);
                Output_10 = Input__this__11;
            }

            n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Input_5 != this.__p_LVoCyFJoX0iLzwZhlh8fCC || Input__this__7 != this.__p_EjYLBMwGZ5ELgqvmbSdSuG || Output_10 != this.__p_IrAY9TMe4C4QCHDIEXNZoC ? new FileWriter_U2bWfQ8dEnvPg38ttqISAx(this)
                {__p_LVoCyFJoX0iLzwZhlh8fCC = Input_5, __p_EjYLBMwGZ5ELgqvmbSdSuG = Input__this__7, __p_IrAY9TMe4C4QCHDIEXNZoC = Output_10} : that_12;
            else
            {
                this.__p_LVoCyFJoX0iLzwZhlh8fCC = Input_5;
                this.__p_EjYLBMwGZ5ELgqvmbSdSuG = Input__this__7;
                this.__p_IrAY9TMe4C4QCHDIEXNZoC = Output_10;
            }

            return that_12;
        }

        public n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "LVoCyFJoX0iLzwZhlh8fCC", 243086U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "EjYLBMwGZ5ELgqvmbSdSuG", 243107U);
            n42._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n7.ByteChunkifier Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IrAY9TMe4C4QCHDIEXNZoC", 243119U);
            n43._Operations_.Create_H(Node_Context_In: Node_Context_4, Output_Out: out n7.ByteWriter Output_5);
            n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx that_6 = this;
            this.__p_LVoCyFJoX0iLzwZhlh8fCC = Output_1;
            this.__p_EjYLBMwGZ5ELgqvmbSdSuG = Output_3;
            this.__p_IrAY9TMe4C4QCHDIEXNZoC = Output_5;
            return that_6;
        }

        public n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx __CreateDefault__()
        {
            n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx that_0 = this;
            this.__p_LVoCyFJoX0iLzwZhlh8fCC = default(n7.FileNode);
            this.__p_EjYLBMwGZ5ELgqvmbSdSuG = default(n7.ByteChunkifier);
            this.__p_IrAY9TMe4C4QCHDIEXNZoC = default(n7.ByteWriter);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LVoCyFJoX0iLzwZhlh8fCC);
            n1.CompilationHelper.SafeDispose(this.__p_EjYLBMwGZ5ELgqvmbSdSuG);
            n1.CompilationHelper.SafeDispose(this.__p_IrAY9TMe4C4QCHDIEXNZoC);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243129U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IHBXfeKQbdxPtdINYRLd0G", Name = "__slot_IHBXfeKQbdxPtdINYRLd0G")]
        public static n8.FileMode __slot_IHBXfeKQbdxPtdINYRLd0G = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "IHBXfeKQbdxPtdINYRLd0G");
        [n1.ElementAttribute(TracingId = 243146U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "T2cueZ7c1VrPyG7tO8qd9w", Name = "__slot_T2cueZ7c1VrPyG7tO8qd9w")]
        public static n8.FileMode __slot_T2cueZ7c1VrPyG7tO8qd9w = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "T2cueZ7c1VrPyG7tO8qd9w");
        [n1.ElementAttribute(TracingId = 243086U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "LVoCyFJoX0iLzwZhlh8fCC", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_LVoCyFJoX0iLzwZhlh8fCC;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_CaqD3yBetnEMdjShJdEZSo = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "CaqD3yBetnEMdjShJdEZSo");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_J2lPYubappYOV870ukZZym = n1.CompilationHelper.Deserialize<n8.FileShare>("None", false, "PcdEIeqrXeZQCL5lc35ctR", "J2lPYubappYOV870ukZZym");
        [n1.ElementAttribute(TracingId = 243107U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "EjYLBMwGZ5ELgqvmbSdSuG", Name = "ByteChunkifier", IsManaged = true, IsAutoGenerated = true)]
        public n7.ByteChunkifier __p_EjYLBMwGZ5ELgqvmbSdSuG;
        [n1.ElementAttribute(TracingId = 243119U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IrAY9TMe4C4QCHDIEXNZoC", Name = "ByteWriter", IsManaged = true, IsAutoGenerated = true)]
        public n7.ByteWriter __p_IrAY9TMe4C4QCHDIEXNZoC;
        static FileWriter_U2bWfQ8dEnvPg38ttqISAx()
        {
        }

        public FileWriter_U2bWfQ8dEnvPg38ttqISAx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_U2bWfQ8dEnvPg38ttqISAx(FileWriter_U2bWfQ8dEnvPg38ttqISAx other): base(other)
        {
            this.__p_LVoCyFJoX0iLzwZhlh8fCC = other.__p_LVoCyFJoX0iLzwZhlh8fCC;
            this.__p_EjYLBMwGZ5ELgqvmbSdSuG = other.__p_EjYLBMwGZ5ELgqvmbSdSuG;
            this.__p_IrAY9TMe4C4QCHDIEXNZoC = other.__p_IrAY9TMe4C4QCHDIEXNZoC;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LVoCyFJoX0iLzwZhlh8fCC", in __p_LVoCyFJoX0iLzwZhlh8fCC), n1.CompilationHelper.GetValueOrExisting(values, "__p_EjYLBMwGZ5ELgqvmbSdSuG", in __p_EjYLBMwGZ5ELgqvmbSdSuG), n1.CompilationHelper.GetValueOrExisting(values, "__p_IrAY9TMe4C4QCHDIEXNZoC", in __p_IrAY9TMe4C4QCHDIEXNZoC));
        }

        internal FileWriter_U2bWfQ8dEnvPg38ttqISAx __WITH__(n7.FileNode __p_LVoCyFJoX0iLzwZhlh8fCC, n7.ByteChunkifier __p_EjYLBMwGZ5ELgqvmbSdSuG, n7.ByteWriter __p_IrAY9TMe4C4QCHDIEXNZoC)
        {
            n30.FileWriter_U2bWfQ8dEnvPg38ttqISAx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LVoCyFJoX0iLzwZhlh8fCC != this.__p_LVoCyFJoX0iLzwZhlh8fCC || __p_EjYLBMwGZ5ELgqvmbSdSuG != this.__p_EjYLBMwGZ5ELgqvmbSdSuG || __p_IrAY9TMe4C4QCHDIEXNZoC != this.__p_IrAY9TMe4C4QCHDIEXNZoC ? new FileWriter_U2bWfQ8dEnvPg38ttqISAx(this)
                {__p_LVoCyFJoX0iLzwZhlh8fCC = __p_LVoCyFJoX0iLzwZhlh8fCC, __p_EjYLBMwGZ5ELgqvmbSdSuG = __p_EjYLBMwGZ5ELgqvmbSdSuG, __p_IrAY9TMe4C4QCHDIEXNZoC = __p_IrAY9TMe4C4QCHDIEXNZoC} : that_0;
            else
            {
                this.__p_LVoCyFJoX0iLzwZhlh8fCC = __p_LVoCyFJoX0iLzwZhlh8fCC;
                this.__p_EjYLBMwGZ5ELgqvmbSdSuG = __p_EjYLBMwGZ5ELgqvmbSdSuG;
                this.__p_IrAY9TMe4C4QCHDIEXNZoC = __p_IrAY9TMe4C4QCHDIEXNZoC;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243204U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RhzHb4NoVZQP8wGq101JDK", Name = "FileWriter_String_RhzHb4NoVZQP8wGq101JDK")]
    [n2.SerializableAttribute]
    public class FileWriter_String_RhzHb4NoVZQP8wGq101JDK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_String_RhzHb4NoVZQP8wGq101JDK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK CreateDefault()
        {
            var instance = new FileWriter_String_RhzHb4NoVZQP8wGq101JDK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK Update(n37.Path File_Path_In, string Data_In, n11.Encodings Encoding_In, bool Append_In, bool Write_In)
        {
            n8.FileMode __pad_JvPm0VVGgiNL6EebPGO6QE_0 = __slot_JvPm0VVGgiNL6EebPGO6QE;
            n8.FileMode __pad_A5dwuAsTYudK9miFQnSmk4_1 = __slot_A5dwuAsTYudK9miFQnSmk4;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_JvPm0VVGgiNL6EebPGO6QE_0, Input_2_In: __pad_A5dwuAsTYudK9miFQnSmk4_1, Output_Out: out n8.FileMode Output_2);
            n8.FileAccess File_Access_3 = __c_A3zudFYH0ngQVpNxmEyn1T;
            n8.FileShare File_Share_4 = __c_E7wjXsW5o7AP7Ab3YN893b;
            n7.FileNode Input_5 = this.__p_FanCEfcLwxmQHl2Nx9sUHZ;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_2, fileAccess: File_Access_3, fileShare: File_Share_4);
            bool Update_7 = true;
            var Output_8 = this.__p_IEsAt2R8xLqLKM2816XCBC;
            if (Update_7)
            {
                Output_8 = this.__p_IEsAt2R8xLqLKM2816XCBC.Update(Input_In: Result_6, Data_In: Data_In, Encoding_In: Encoding_In, Write_In: Write_In);
            }

            n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = Input_5 != this.__p_FanCEfcLwxmQHl2Nx9sUHZ || Output_8 != this.__p_IEsAt2R8xLqLKM2816XCBC ? new FileWriter_String_RhzHb4NoVZQP8wGq101JDK(this)
                {__p_FanCEfcLwxmQHl2Nx9sUHZ = Input_5, __p_IEsAt2R8xLqLKM2816XCBC = Output_8} : that_9;
            else
            {
                this.__p_FanCEfcLwxmQHl2Nx9sUHZ = Input_5;
                this.__p_IEsAt2R8xLqLKM2816XCBC = Output_8;
            }

            return that_9;
        }

        public n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "FanCEfcLwxmQHl2Nx9sUHZ", 243219U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IEsAt2R8xLqLKM2816XCBC", 243238U);
            var Output_3 = n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U.Create(Node_Context: Node_Context_2);
            n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK that_4 = this;
            this.__p_FanCEfcLwxmQHl2Nx9sUHZ = Output_1;
            this.__p_IEsAt2R8xLqLKM2816XCBC = Output_3;
            return that_4;
        }

        public n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK __CreateDefault__()
        {
            n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK that_0 = this;
            this.__p_FanCEfcLwxmQHl2Nx9sUHZ = default(n7.FileNode);
            this.__p_IEsAt2R8xLqLKM2816XCBC = n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FanCEfcLwxmQHl2Nx9sUHZ);
            n1.CompilationHelper.SafeDispose(this.__p_IEsAt2R8xLqLKM2816XCBC);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243252U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "A5dwuAsTYudK9miFQnSmk4", Name = "__slot_A5dwuAsTYudK9miFQnSmk4")]
        public static n8.FileMode __slot_A5dwuAsTYudK9miFQnSmk4 = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "A5dwuAsTYudK9miFQnSmk4");
        [n1.ElementAttribute(TracingId = 243270U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JvPm0VVGgiNL6EebPGO6QE", Name = "__slot_JvPm0VVGgiNL6EebPGO6QE")]
        public static n8.FileMode __slot_JvPm0VVGgiNL6EebPGO6QE = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "JvPm0VVGgiNL6EebPGO6QE");
        [n1.ElementAttribute(TracingId = 243219U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "FanCEfcLwxmQHl2Nx9sUHZ", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_FanCEfcLwxmQHl2Nx9sUHZ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_A3zudFYH0ngQVpNxmEyn1T = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "A3zudFYH0ngQVpNxmEyn1T");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_E7wjXsW5o7AP7Ab3YN893b = n1.CompilationHelper.Deserialize<n8.FileShare>("None", false, "PcdEIeqrXeZQCL5lc35ctR", "E7wjXsW5o7AP7Ab3YN893b");
        [n1.ElementAttribute(TracingId = 243238U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IEsAt2R8xLqLKM2816XCBC", Name = "StringWriter", IsManaged = true, IsAutoGenerated = true)]
        public n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U __p_IEsAt2R8xLqLKM2816XCBC;
        static FileWriter_String_RhzHb4NoVZQP8wGq101JDK()
        {
        }

        public FileWriter_String_RhzHb4NoVZQP8wGq101JDK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_String_RhzHb4NoVZQP8wGq101JDK(FileWriter_String_RhzHb4NoVZQP8wGq101JDK other): base(other)
        {
            this.__p_FanCEfcLwxmQHl2Nx9sUHZ = other.__p_FanCEfcLwxmQHl2Nx9sUHZ;
            this.__p_IEsAt2R8xLqLKM2816XCBC = other.__p_IEsAt2R8xLqLKM2816XCBC;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FanCEfcLwxmQHl2Nx9sUHZ", in __p_FanCEfcLwxmQHl2Nx9sUHZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_IEsAt2R8xLqLKM2816XCBC", in __p_IEsAt2R8xLqLKM2816XCBC));
        }

        internal FileWriter_String_RhzHb4NoVZQP8wGq101JDK __WITH__(n7.FileNode __p_FanCEfcLwxmQHl2Nx9sUHZ, n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U __p_IEsAt2R8xLqLKM2816XCBC)
        {
            n30.FileWriter_String_RhzHb4NoVZQP8wGq101JDK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FanCEfcLwxmQHl2Nx9sUHZ != this.__p_FanCEfcLwxmQHl2Nx9sUHZ || __p_IEsAt2R8xLqLKM2816XCBC != this.__p_IEsAt2R8xLqLKM2816XCBC ? new FileWriter_String_RhzHb4NoVZQP8wGq101JDK(this)
                {__p_FanCEfcLwxmQHl2Nx9sUHZ = __p_FanCEfcLwxmQHl2Nx9sUHZ, __p_IEsAt2R8xLqLKM2816XCBC = __p_IEsAt2R8xLqLKM2816XCBC} : that_0;
            else
            {
                this.__p_FanCEfcLwxmQHl2Nx9sUHZ = __p_FanCEfcLwxmQHl2Nx9sUHZ;
                this.__p_IEsAt2R8xLqLKM2816XCBC = __p_IEsAt2R8xLqLKM2816XCBC;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243339U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "VixxmbVX6AtMbizi7gZULo", Name = "FileReader_Reactive_VixxmbVX6AtMbizi7gZULo")]
    [n2.SerializableAttribute]
    public class FileReader_Reactive_VixxmbVX6AtMbizi7gZULo : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo CreateDefault()
        {
            var instance = new FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo Update(n37.Path File_Path_In, bool Read_In, out n2.IObservable<n12.Spread<byte>> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode File_Mode_0 = __c_IjFsIBfVFASLi2RQ3h01aG;
            n8.FileAccess File_Access_1 = __c_UEKc1cxAZEcLlrKPUVwJXf;
            n8.FileShare File_Share_2 = __c_GYPOdOSev1CLOkr6eZUEOy;
            n7.FileNode Input_3 = this.__p_GfZybXiZzVmPu3PbRznR99;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n32._Operations_.Update_H<n9.IResourceProvider<n8.Stream>>(Input_In: this.__p_T771XBsToFsMYZCohMimlC, Message_In: Result_4, Send_In: Read_In, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_5, Result_Out: out n2.IObservable<n9.IResourceProvider<n8.Stream>> Result_6);
            n7.AsyncByteReader Input__this__7 = this.__p_Ns9AUTO8xkuO7KNFavIX9v;
            var Result_8 = Input__this__7.Update(input: Result_6);
            n44._Operations_.Update_H<byte>(State_Input_In: this.__p_G0UhY59K2bGOPj7WzWJyh7, Input_In: Result_8, State_Output_Out: out n7.Monitor<byte> State_Output_9, Output_Out: out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Output_10, Progress_Out: out float Progress_11, In_Progress_Out: out bool In_Progress_12, On_Completed_Out: out bool On_Completed_13);
            n7.AsyncByteCollector Input__this__14 = this.__p_IILmR1ar08DMEIbPM7WTqG;
            var Result_15 = Input__this__14.Update(input: Output_10);
            Output_Out = Result_15;
            Progress_Out = Progress_11;
            In_Progress_Out = In_Progress_12;
            On_Completed_Out = On_Completed_13;
            n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = Input_3 != this.__p_GfZybXiZzVmPu3PbRznR99 || Output_5 != this.__p_T771XBsToFsMYZCohMimlC || Input__this__7 != this.__p_Ns9AUTO8xkuO7KNFavIX9v || State_Output_9 != this.__p_G0UhY59K2bGOPj7WzWJyh7 || Input__this__14 != this.__p_IILmR1ar08DMEIbPM7WTqG ? new FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(this)
                {__p_GfZybXiZzVmPu3PbRznR99 = Input_3, __p_T771XBsToFsMYZCohMimlC = Output_5, __p_Ns9AUTO8xkuO7KNFavIX9v = Input__this__7, __p_G0UhY59K2bGOPj7WzWJyh7 = State_Output_9, __p_IILmR1ar08DMEIbPM7WTqG = Input__this__14} : that_16;
            else
            {
                this.__p_GfZybXiZzVmPu3PbRznR99 = Input_3;
                this.__p_T771XBsToFsMYZCohMimlC = Output_5;
                this.__p_Ns9AUTO8xkuO7KNFavIX9v = Input__this__7;
                this.__p_G0UhY59K2bGOPj7WzWJyh7 = State_Output_9;
                this.__p_IILmR1ar08DMEIbPM7WTqG = Input__this__14;
            }

            return that_16;
        }

        public n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "GfZybXiZzVmPu3PbRznR99", 243345U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IILmR1ar08DMEIbPM7WTqG", 243362U);
            n45._Operations_.Create(Node_Context: Node_Context_2, Output_Out: out n7.AsyncByteCollector Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "G0UhY59K2bGOPj7WzWJyh7", 243378U);
            n44._Operations_.Create_H<byte>(Node_Context: Node_Context_4, Output_Out: out n7.Monitor<byte> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Ns9AUTO8xkuO7KNFavIX9v", 243395U);
            n46._Operations_.Create(Node_Context_In: Node_Context_6, Output_Out: out n7.AsyncByteReader Output_7);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "T771XBsToFsMYZCohMimlC", 243405U);
            n32._Operations_.Create_H<n9.IResourceProvider<n8.Stream>>(Node_Context: Node_Context_8, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_9);
            n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo that_10 = this;
            this.__p_GfZybXiZzVmPu3PbRznR99 = Output_1;
            this.__p_IILmR1ar08DMEIbPM7WTqG = Output_3;
            this.__p_G0UhY59K2bGOPj7WzWJyh7 = Output_5;
            this.__p_Ns9AUTO8xkuO7KNFavIX9v = Output_7;
            this.__p_T771XBsToFsMYZCohMimlC = Output_9;
            return that_10;
        }

        public n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo __CreateDefault__()
        {
            n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo that_0 = this;
            this.__p_GfZybXiZzVmPu3PbRznR99 = default(n7.FileNode);
            this.__p_T771XBsToFsMYZCohMimlC = default(n31.ToObservable<n9.IResourceProvider<n8.Stream>>);
            this.__p_Ns9AUTO8xkuO7KNFavIX9v = default(n7.AsyncByteReader);
            this.__p_G0UhY59K2bGOPj7WzWJyh7 = default(n7.Monitor<byte>);
            this.__p_IILmR1ar08DMEIbPM7WTqG = default(n7.AsyncByteCollector);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GfZybXiZzVmPu3PbRznR99);
            n1.CompilationHelper.SafeDispose(this.__p_T771XBsToFsMYZCohMimlC);
            n1.CompilationHelper.SafeDispose(this.__p_Ns9AUTO8xkuO7KNFavIX9v);
            n1.CompilationHelper.SafeDispose(this.__p_G0UhY59K2bGOPj7WzWJyh7);
            n1.CompilationHelper.SafeDispose(this.__p_IILmR1ar08DMEIbPM7WTqG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243345U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GfZybXiZzVmPu3PbRznR99", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_GfZybXiZzVmPu3PbRznR99;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_IjFsIBfVFASLi2RQ3h01aG = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "IjFsIBfVFASLi2RQ3h01aG");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_UEKc1cxAZEcLlrKPUVwJXf = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "UEKc1cxAZEcLlrKPUVwJXf");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_GYPOdOSev1CLOkr6eZUEOy = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "GYPOdOSev1CLOkr6eZUEOy");
        [n1.ElementAttribute(TracingId = 243405U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "T771XBsToFsMYZCohMimlC", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_T771XBsToFsMYZCohMimlC;
        [n1.ElementAttribute(TracingId = 243395U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Ns9AUTO8xkuO7KNFavIX9v", Name = "ByteReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteReader __p_Ns9AUTO8xkuO7KNFavIX9v;
        [n1.ElementAttribute(TracingId = 243378U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "G0UhY59K2bGOPj7WzWJyh7", Name = "Monitor (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Monitor<byte> __p_G0UhY59K2bGOPj7WzWJyh7;
        [n1.ElementAttribute(TracingId = 243362U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IILmR1ar08DMEIbPM7WTqG", Name = "ByteCollector (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteCollector __p_IILmR1ar08DMEIbPM7WTqG;
        static FileReader_Reactive_VixxmbVX6AtMbizi7gZULo()
        {
        }

        public FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(FileReader_Reactive_VixxmbVX6AtMbizi7gZULo other): base(other)
        {
            this.__p_GfZybXiZzVmPu3PbRznR99 = other.__p_GfZybXiZzVmPu3PbRznR99;
            this.__p_T771XBsToFsMYZCohMimlC = other.__p_T771XBsToFsMYZCohMimlC;
            this.__p_Ns9AUTO8xkuO7KNFavIX9v = other.__p_Ns9AUTO8xkuO7KNFavIX9v;
            this.__p_G0UhY59K2bGOPj7WzWJyh7 = other.__p_G0UhY59K2bGOPj7WzWJyh7;
            this.__p_IILmR1ar08DMEIbPM7WTqG = other.__p_IILmR1ar08DMEIbPM7WTqG;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GfZybXiZzVmPu3PbRznR99", in __p_GfZybXiZzVmPu3PbRznR99), n1.CompilationHelper.GetValueOrExisting(values, "__p_T771XBsToFsMYZCohMimlC", in __p_T771XBsToFsMYZCohMimlC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ns9AUTO8xkuO7KNFavIX9v", in __p_Ns9AUTO8xkuO7KNFavIX9v), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0UhY59K2bGOPj7WzWJyh7", in __p_G0UhY59K2bGOPj7WzWJyh7), n1.CompilationHelper.GetValueOrExisting(values, "__p_IILmR1ar08DMEIbPM7WTqG", in __p_IILmR1ar08DMEIbPM7WTqG));
        }

        internal FileReader_Reactive_VixxmbVX6AtMbizi7gZULo __WITH__(n7.FileNode __p_GfZybXiZzVmPu3PbRznR99, n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_T771XBsToFsMYZCohMimlC, n7.AsyncByteReader __p_Ns9AUTO8xkuO7KNFavIX9v, n7.Monitor<byte> __p_G0UhY59K2bGOPj7WzWJyh7, n7.AsyncByteCollector __p_IILmR1ar08DMEIbPM7WTqG)
        {
            n30.FileReader_Reactive_VixxmbVX6AtMbizi7gZULo that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GfZybXiZzVmPu3PbRznR99 != this.__p_GfZybXiZzVmPu3PbRznR99 || __p_T771XBsToFsMYZCohMimlC != this.__p_T771XBsToFsMYZCohMimlC || __p_Ns9AUTO8xkuO7KNFavIX9v != this.__p_Ns9AUTO8xkuO7KNFavIX9v || __p_G0UhY59K2bGOPj7WzWJyh7 != this.__p_G0UhY59K2bGOPj7WzWJyh7 || __p_IILmR1ar08DMEIbPM7WTqG != this.__p_IILmR1ar08DMEIbPM7WTqG ? new FileReader_Reactive_VixxmbVX6AtMbizi7gZULo(this)
                {__p_GfZybXiZzVmPu3PbRznR99 = __p_GfZybXiZzVmPu3PbRznR99, __p_T771XBsToFsMYZCohMimlC = __p_T771XBsToFsMYZCohMimlC, __p_Ns9AUTO8xkuO7KNFavIX9v = __p_Ns9AUTO8xkuO7KNFavIX9v, __p_G0UhY59K2bGOPj7WzWJyh7 = __p_G0UhY59K2bGOPj7WzWJyh7, __p_IILmR1ar08DMEIbPM7WTqG = __p_IILmR1ar08DMEIbPM7WTqG} : that_0;
            else
            {
                this.__p_GfZybXiZzVmPu3PbRznR99 = __p_GfZybXiZzVmPu3PbRznR99;
                this.__p_T771XBsToFsMYZCohMimlC = __p_T771XBsToFsMYZCohMimlC;
                this.__p_Ns9AUTO8xkuO7KNFavIX9v = __p_Ns9AUTO8xkuO7KNFavIX9v;
                this.__p_G0UhY59K2bGOPj7WzWJyh7 = __p_G0UhY59K2bGOPj7WzWJyh7;
                this.__p_IILmR1ar08DMEIbPM7WTqG = __p_IILmR1ar08DMEIbPM7WTqG;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243483U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "VTFPwrKqLPQOeQrp8g7eWh", Name = "FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh")]
    [n2.SerializableAttribute]
    public class FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh CreateDefault()
        {
            var instance = new FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh Update(n37.Path File_Path_In, n11.Encodings Encoding_In, bool Read_In, out n2.IObservable<string> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode File_Mode_0 = __c_JFesFe2smhwNZE9DaXrYzU;
            n8.FileAccess File_Access_1 = __c_EIEUVgH1LMzQK7x7G0Q3ee;
            n8.FileShare File_Share_2 = __c_Uie5djIYQL4LYQThNH7avk;
            n7.FileNode Input_3 = this.__p_Jkuwu27BcOMMnhn80ILJTq;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n32._Operations_.Update_H<n9.IResourceProvider<n8.Stream>>(Input_In: this.__p_HrXlGQNlah3O7VXyzkJ71D, Message_In: Result_4, Send_In: Read_In, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_5, Result_Out: out n2.IObservable<n9.IResourceProvider<n8.Stream>> Result_6);
            var State_Output_11 = this.__p_MeCCGmpU7jvMBEOhddGGWd.Update(Input_In: Result_6, Encoding_In: Encoding_In, Output_Out: out n2.IObservable<string> Output_7, Progress_Out: out float Progress_8, In_Progress_Out: out bool In_Progress_9, On_Completed_Out: out bool On_Completed_10);
            Output_Out = Output_7;
            Progress_Out = Progress_8;
            In_Progress_Out = In_Progress_9;
            On_Completed_Out = On_Completed_10;
            n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Input_3 != this.__p_Jkuwu27BcOMMnhn80ILJTq || Output_5 != this.__p_HrXlGQNlah3O7VXyzkJ71D || State_Output_11 != this.__p_MeCCGmpU7jvMBEOhddGGWd ? new FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(this)
                {__p_Jkuwu27BcOMMnhn80ILJTq = Input_3, __p_HrXlGQNlah3O7VXyzkJ71D = Output_5, __p_MeCCGmpU7jvMBEOhddGGWd = State_Output_11} : that_12;
            else
            {
                this.__p_Jkuwu27BcOMMnhn80ILJTq = Input_3;
                this.__p_HrXlGQNlah3O7VXyzkJ71D = Output_5;
                this.__p_MeCCGmpU7jvMBEOhddGGWd = State_Output_11;
            }

            return that_12;
        }

        public n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "MeCCGmpU7jvMBEOhddGGWd", 243498U);
            var Output_1 = n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Jkuwu27BcOMMnhn80ILJTq", 243514U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_2, Output_Out: out n7.FileNode Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "HrXlGQNlah3O7VXyzkJ71D", 243539U);
            n32._Operations_.Create_H<n9.IResourceProvider<n8.Stream>>(Node_Context: Node_Context_4, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_5);
            n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh that_6 = this;
            this.__p_MeCCGmpU7jvMBEOhddGGWd = Output_1;
            this.__p_Jkuwu27BcOMMnhn80ILJTq = Output_3;
            this.__p_HrXlGQNlah3O7VXyzkJ71D = Output_5;
            return that_6;
        }

        public n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh __CreateDefault__()
        {
            n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh that_0 = this;
            this.__p_Jkuwu27BcOMMnhn80ILJTq = default(n7.FileNode);
            this.__p_HrXlGQNlah3O7VXyzkJ71D = default(n31.ToObservable<n9.IResourceProvider<n8.Stream>>);
            this.__p_MeCCGmpU7jvMBEOhddGGWd = n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Jkuwu27BcOMMnhn80ILJTq);
            n1.CompilationHelper.SafeDispose(this.__p_HrXlGQNlah3O7VXyzkJ71D);
            n1.CompilationHelper.SafeDispose(this.__p_MeCCGmpU7jvMBEOhddGGWd);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243514U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Jkuwu27BcOMMnhn80ILJTq", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_Jkuwu27BcOMMnhn80ILJTq;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_JFesFe2smhwNZE9DaXrYzU = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "JFesFe2smhwNZE9DaXrYzU");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_EIEUVgH1LMzQK7x7G0Q3ee = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "EIEUVgH1LMzQK7x7G0Q3ee");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_Uie5djIYQL4LYQThNH7avk = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "Uie5djIYQL4LYQThNH7avk");
        [n1.ElementAttribute(TracingId = 243539U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "HrXlGQNlah3O7VXyzkJ71D", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_HrXlGQNlah3O7VXyzkJ71D;
        [n1.ElementAttribute(TracingId = 243498U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MeCCGmpU7jvMBEOhddGGWd", Name = "StringReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef __p_MeCCGmpU7jvMBEOhddGGWd;
        static FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh()
        {
        }

        public FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh other): base(other)
        {
            this.__p_Jkuwu27BcOMMnhn80ILJTq = other.__p_Jkuwu27BcOMMnhn80ILJTq;
            this.__p_HrXlGQNlah3O7VXyzkJ71D = other.__p_HrXlGQNlah3O7VXyzkJ71D;
            this.__p_MeCCGmpU7jvMBEOhddGGWd = other.__p_MeCCGmpU7jvMBEOhddGGWd;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Jkuwu27BcOMMnhn80ILJTq", in __p_Jkuwu27BcOMMnhn80ILJTq), n1.CompilationHelper.GetValueOrExisting(values, "__p_HrXlGQNlah3O7VXyzkJ71D", in __p_HrXlGQNlah3O7VXyzkJ71D), n1.CompilationHelper.GetValueOrExisting(values, "__p_MeCCGmpU7jvMBEOhddGGWd", in __p_MeCCGmpU7jvMBEOhddGGWd));
        }

        internal FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh __WITH__(n7.FileNode __p_Jkuwu27BcOMMnhn80ILJTq, n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_HrXlGQNlah3O7VXyzkJ71D, n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef __p_MeCCGmpU7jvMBEOhddGGWd)
        {
            n30.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Jkuwu27BcOMMnhn80ILJTq != this.__p_Jkuwu27BcOMMnhn80ILJTq || __p_HrXlGQNlah3O7VXyzkJ71D != this.__p_HrXlGQNlah3O7VXyzkJ71D || __p_MeCCGmpU7jvMBEOhddGGWd != this.__p_MeCCGmpU7jvMBEOhddGGWd ? new FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh(this)
                {__p_Jkuwu27BcOMMnhn80ILJTq = __p_Jkuwu27BcOMMnhn80ILJTq, __p_HrXlGQNlah3O7VXyzkJ71D = __p_HrXlGQNlah3O7VXyzkJ71D, __p_MeCCGmpU7jvMBEOhddGGWd = __p_MeCCGmpU7jvMBEOhddGGWd} : that_0;
            else
            {
                this.__p_Jkuwu27BcOMMnhn80ILJTq = __p_Jkuwu27BcOMMnhn80ILJTq;
                this.__p_HrXlGQNlah3O7VXyzkJ71D = __p_HrXlGQNlah3O7VXyzkJ71D;
                this.__p_MeCCGmpU7jvMBEOhddGGWd = __p_MeCCGmpU7jvMBEOhddGGWd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243614U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AtVTqYvzpFTNOhjHcbX8pA", Name = "FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA")]
    [n2.SerializableAttribute]
    public class FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA CreateDefault()
        {
            var instance = new FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA Update(n37.Path File_Path_In, n2.IObservable<n12.Spread<byte>> Data_In, bool Append_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode __pad_G4ygqCuzQjMNAuuzEuqOC4_0 = __slot_G4ygqCuzQjMNAuuzEuqOC4;
            n8.FileMode __pad_LArhebZXyQhQDKz2koIdtf_1 = __slot_LArhebZXyQhQDKz2koIdtf;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_G4ygqCuzQjMNAuuzEuqOC4_0, Input_2_In: __pad_LArhebZXyQhQDKz2koIdtf_1, Output_Out: out n8.FileMode Output_2);
            n8.FileAccess File_Access_3 = __c_Dr6np7cbDcuOiETcDxiPfR;
            n8.FileShare File_Share_4 = __c_OAl24phaScaP0q5Jl0JBnP;
            n7.FileNode Input_5 = this.__p_VHin9L5j9WrMPvLXLjJ79k;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_2, fileAccess: File_Access_3, fileShare: File_Share_4);
            var State_Output_8 = this.__p_BOUWl5yVguGPnjeazWJa43.Update<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Input_In: Result_6, Output_Out: out n9.IResourceProvider<n8.Stream> Output_7);
            n7.AsyncByteChunkifier Input__this__9 = this.__p_FKqVJKHEoknOHOLHBURfaf;
            var Result_10 = Input__this__9.Update(input: Data_In);
            n7.AsyncByteWriter Input__this__11 = this.__p_SzEeBYb0vNROcNGU8UVs9L;
            var Result_12 = Input__this__11.Update(input: Output_7, data: Result_10);
            n44._Operations_.Update_H<byte>(State_Input_In: this.__p_KFUNjWqR1P3NAgBXmKghvI, Input_In: Result_12, State_Output_Out: out n7.Monitor<byte> State_Output_13, Output_Out: out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Output_14, Progress_Out: out float Progress_15, In_Progress_Out: out bool In_Progress_16, On_Completed_Out: out bool On_Completed_17);
            var Output_19 = this.__p_SO58I7X346JLeNaWC46myu.Update(Value_In: Output_14, Result_Out: out n2.IObservable<n7.Chunk<byte>> Result_18);
            bool Update_20 = true;
            var Output_21 = this.__p_DdGwkIhk3zkPIuc61RIyaA;
            if (Update_20)
            {
                Output_21 = this.__p_DdGwkIhk3zkPIuc61RIyaA.Update(Input_In: Result_18);
            }

            Progress_Out = Progress_15;
            In_Progress_Out = In_Progress_16;
            On_Completed_Out = On_Completed_17;
            n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = Input_5 != this.__p_VHin9L5j9WrMPvLXLjJ79k || State_Output_8 != this.__p_BOUWl5yVguGPnjeazWJa43 || Input__this__9 != this.__p_FKqVJKHEoknOHOLHBURfaf || Input__this__11 != this.__p_SzEeBYb0vNROcNGU8UVs9L || State_Output_13 != this.__p_KFUNjWqR1P3NAgBXmKghvI || Output_19 != this.__p_SO58I7X346JLeNaWC46myu || Output_21 != this.__p_DdGwkIhk3zkPIuc61RIyaA ? new FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(this)
                {__p_VHin9L5j9WrMPvLXLjJ79k = Input_5, __p_BOUWl5yVguGPnjeazWJa43 = State_Output_8, __p_FKqVJKHEoknOHOLHBURfaf = Input__this__9, __p_SzEeBYb0vNROcNGU8UVs9L = Input__this__11, __p_KFUNjWqR1P3NAgBXmKghvI = State_Output_13, __p_SO58I7X346JLeNaWC46myu = Output_19, __p_DdGwkIhk3zkPIuc61RIyaA = Output_21} : that_22;
            else
            {
                this.__p_VHin9L5j9WrMPvLXLjJ79k = Input_5;
                this.__p_BOUWl5yVguGPnjeazWJa43 = State_Output_8;
                this.__p_FKqVJKHEoknOHOLHBURfaf = Input__this__9;
                this.__p_SzEeBYb0vNROcNGU8UVs9L = Input__this__11;
                this.__p_KFUNjWqR1P3NAgBXmKghvI = State_Output_13;
                this.__p_SO58I7X346JLeNaWC46myu = Output_19;
                this.__p_DdGwkIhk3zkPIuc61RIyaA = Output_21;
            }

            return that_22;
        }

        public n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "VHin9L5j9WrMPvLXLjJ79k", 243627U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "FKqVJKHEoknOHOLHBURfaf", 243655U);
            n47._Operations_.Create(Node_Context: Node_Context_2, Output_Out: out n7.AsyncByteChunkifier Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SzEeBYb0vNROcNGU8UVs9L", 243668U);
            n48._Operations_.Create(Node_Context_In: Node_Context_4, Output_Out: out n7.AsyncByteWriter Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "KFUNjWqR1P3NAgBXmKghvI", 243728U);
            n44._Operations_.Create_H<byte>(Node_Context: Node_Context_6, Output_Out: out n7.Monitor<byte> Output_7);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SO58I7X346JLeNaWC46myu", 243759U);
            var Output_9 = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>>.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "DdGwkIhk3zkPIuc61RIyaA", 243777U);
            var Output_11 = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>>.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "BOUWl5yVguGPnjeazWJa43", 243795U);
            var Output_13 = n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_12);
            n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA that_14 = this;
            this.__p_VHin9L5j9WrMPvLXLjJ79k = Output_1;
            this.__p_FKqVJKHEoknOHOLHBURfaf = Output_3;
            this.__p_SzEeBYb0vNROcNGU8UVs9L = Output_5;
            this.__p_KFUNjWqR1P3NAgBXmKghvI = Output_7;
            this.__p_SO58I7X346JLeNaWC46myu = Output_9;
            this.__p_DdGwkIhk3zkPIuc61RIyaA = Output_11;
            this.__p_BOUWl5yVguGPnjeazWJa43 = Output_13;
            return that_14;
        }

        public n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA __CreateDefault__()
        {
            n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA that_0 = this;
            this.__p_VHin9L5j9WrMPvLXLjJ79k = default(n7.FileNode);
            this.__p_BOUWl5yVguGPnjeazWJa43 = n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            this.__p_FKqVJKHEoknOHOLHBURfaf = default(n7.AsyncByteChunkifier);
            this.__p_SzEeBYb0vNROcNGU8UVs9L = default(n7.AsyncByteWriter);
            this.__p_KFUNjWqR1P3NAgBXmKghvI = default(n7.Monitor<byte>);
            this.__p_SO58I7X346JLeNaWC46myu = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>>.CreateDefault();
            this.__p_DdGwkIhk3zkPIuc61RIyaA = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VHin9L5j9WrMPvLXLjJ79k);
            n1.CompilationHelper.SafeDispose(this.__p_BOUWl5yVguGPnjeazWJa43);
            n1.CompilationHelper.SafeDispose(this.__p_FKqVJKHEoknOHOLHBURfaf);
            n1.CompilationHelper.SafeDispose(this.__p_SzEeBYb0vNROcNGU8UVs9L);
            n1.CompilationHelper.SafeDispose(this.__p_KFUNjWqR1P3NAgBXmKghvI);
            n1.CompilationHelper.SafeDispose(this.__p_SO58I7X346JLeNaWC46myu);
            n1.CompilationHelper.SafeDispose(this.__p_DdGwkIhk3zkPIuc61RIyaA);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243684U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "LArhebZXyQhQDKz2koIdtf", Name = "__slot_LArhebZXyQhQDKz2koIdtf")]
        public static n8.FileMode __slot_LArhebZXyQhQDKz2koIdtf = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "LArhebZXyQhQDKz2koIdtf");
        [n1.ElementAttribute(TracingId = 243710U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "G4ygqCuzQjMNAuuzEuqOC4", Name = "__slot_G4ygqCuzQjMNAuuzEuqOC4")]
        public static n8.FileMode __slot_G4ygqCuzQjMNAuuzEuqOC4 = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "G4ygqCuzQjMNAuuzEuqOC4");
        [n1.ElementAttribute(TracingId = 243627U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "VHin9L5j9WrMPvLXLjJ79k", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_VHin9L5j9WrMPvLXLjJ79k;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_Dr6np7cbDcuOiETcDxiPfR = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "Dr6np7cbDcuOiETcDxiPfR");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_OAl24phaScaP0q5Jl0JBnP = n1.CompilationHelper.Deserialize<n8.FileShare>("None", false, "PcdEIeqrXeZQCL5lc35ctR", "OAl24phaScaP0q5Jl0JBnP");
        [n1.ElementAttribute(TracingId = 243795U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BOUWl5yVguGPnjeazWJa43", Name = "SerialSharing", IsManaged = true, IsAutoGenerated = true)]
        public n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream> __p_BOUWl5yVguGPnjeazWJa43;
        [n1.ElementAttribute(TracingId = 243655U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "FKqVJKHEoknOHOLHBURfaf", Name = "ByteChunkifier (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteChunkifier __p_FKqVJKHEoknOHOLHBURfaf;
        [n1.ElementAttribute(TracingId = 243668U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SzEeBYb0vNROcNGU8UVs9L", Name = "ByteWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteWriter __p_SzEeBYb0vNROcNGU8UVs9L;
        [n1.ElementAttribute(TracingId = 243728U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "KFUNjWqR1P3NAgBXmKghvI", Name = "Monitor (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Monitor<byte> __p_KFUNjWqR1P3NAgBXmKghvI;
        [n1.ElementAttribute(TracingId = 243759U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SO58I7X346JLeNaWC46myu", Name = "Switch", IsManaged = true, IsAutoGenerated = true)]
        public n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>> __p_SO58I7X346JLeNaWC46myu;
        [n1.ElementAttribute(TracingId = 243777U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "DdGwkIhk3zkPIuc61RIyaA", Name = "Subscribe", IsManaged = true, IsAutoGenerated = true)]
        public n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>> __p_DdGwkIhk3zkPIuc61RIyaA;
        static FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA()
        {
        }

        public FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA other): base(other)
        {
            this.__p_VHin9L5j9WrMPvLXLjJ79k = other.__p_VHin9L5j9WrMPvLXLjJ79k;
            this.__p_BOUWl5yVguGPnjeazWJa43 = other.__p_BOUWl5yVguGPnjeazWJa43;
            this.__p_FKqVJKHEoknOHOLHBURfaf = other.__p_FKqVJKHEoknOHOLHBURfaf;
            this.__p_SzEeBYb0vNROcNGU8UVs9L = other.__p_SzEeBYb0vNROcNGU8UVs9L;
            this.__p_KFUNjWqR1P3NAgBXmKghvI = other.__p_KFUNjWqR1P3NAgBXmKghvI;
            this.__p_SO58I7X346JLeNaWC46myu = other.__p_SO58I7X346JLeNaWC46myu;
            this.__p_DdGwkIhk3zkPIuc61RIyaA = other.__p_DdGwkIhk3zkPIuc61RIyaA;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VHin9L5j9WrMPvLXLjJ79k", in __p_VHin9L5j9WrMPvLXLjJ79k), n1.CompilationHelper.GetValueOrExisting(values, "__p_BOUWl5yVguGPnjeazWJa43", in __p_BOUWl5yVguGPnjeazWJa43), n1.CompilationHelper.GetValueOrExisting(values, "__p_FKqVJKHEoknOHOLHBURfaf", in __p_FKqVJKHEoknOHOLHBURfaf), n1.CompilationHelper.GetValueOrExisting(values, "__p_SzEeBYb0vNROcNGU8UVs9L", in __p_SzEeBYb0vNROcNGU8UVs9L), n1.CompilationHelper.GetValueOrExisting(values, "__p_KFUNjWqR1P3NAgBXmKghvI", in __p_KFUNjWqR1P3NAgBXmKghvI), n1.CompilationHelper.GetValueOrExisting(values, "__p_SO58I7X346JLeNaWC46myu", in __p_SO58I7X346JLeNaWC46myu), n1.CompilationHelper.GetValueOrExisting(values, "__p_DdGwkIhk3zkPIuc61RIyaA", in __p_DdGwkIhk3zkPIuc61RIyaA));
        }

        internal FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA __WITH__(n7.FileNode __p_VHin9L5j9WrMPvLXLjJ79k, n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream> __p_BOUWl5yVguGPnjeazWJa43, n7.AsyncByteChunkifier __p_FKqVJKHEoknOHOLHBURfaf, n7.AsyncByteWriter __p_SzEeBYb0vNROcNGU8UVs9L, n7.Monitor<byte> __p_KFUNjWqR1P3NAgBXmKghvI, n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>> __p_SO58I7X346JLeNaWC46myu, n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>> __p_DdGwkIhk3zkPIuc61RIyaA)
        {
            n30.FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VHin9L5j9WrMPvLXLjJ79k != this.__p_VHin9L5j9WrMPvLXLjJ79k || __p_BOUWl5yVguGPnjeazWJa43 != this.__p_BOUWl5yVguGPnjeazWJa43 || __p_FKqVJKHEoknOHOLHBURfaf != this.__p_FKqVJKHEoknOHOLHBURfaf || __p_SzEeBYb0vNROcNGU8UVs9L != this.__p_SzEeBYb0vNROcNGU8UVs9L || __p_KFUNjWqR1P3NAgBXmKghvI != this.__p_KFUNjWqR1P3NAgBXmKghvI || __p_SO58I7X346JLeNaWC46myu != this.__p_SO58I7X346JLeNaWC46myu || __p_DdGwkIhk3zkPIuc61RIyaA != this.__p_DdGwkIhk3zkPIuc61RIyaA ? new FileWriter_Reactive_AtVTqYvzpFTNOhjHcbX8pA(this)
                {__p_VHin9L5j9WrMPvLXLjJ79k = __p_VHin9L5j9WrMPvLXLjJ79k, __p_BOUWl5yVguGPnjeazWJa43 = __p_BOUWl5yVguGPnjeazWJa43, __p_FKqVJKHEoknOHOLHBURfaf = __p_FKqVJKHEoknOHOLHBURfaf, __p_SzEeBYb0vNROcNGU8UVs9L = __p_SzEeBYb0vNROcNGU8UVs9L, __p_KFUNjWqR1P3NAgBXmKghvI = __p_KFUNjWqR1P3NAgBXmKghvI, __p_SO58I7X346JLeNaWC46myu = __p_SO58I7X346JLeNaWC46myu, __p_DdGwkIhk3zkPIuc61RIyaA = __p_DdGwkIhk3zkPIuc61RIyaA} : that_0;
            else
            {
                this.__p_VHin9L5j9WrMPvLXLjJ79k = __p_VHin9L5j9WrMPvLXLjJ79k;
                this.__p_BOUWl5yVguGPnjeazWJa43 = __p_BOUWl5yVguGPnjeazWJa43;
                this.__p_FKqVJKHEoknOHOLHBURfaf = __p_FKqVJKHEoknOHOLHBURfaf;
                this.__p_SzEeBYb0vNROcNGU8UVs9L = __p_SzEeBYb0vNROcNGU8UVs9L;
                this.__p_KFUNjWqR1P3NAgBXmKghvI = __p_KFUNjWqR1P3NAgBXmKghvI;
                this.__p_SO58I7X346JLeNaWC46myu = __p_SO58I7X346JLeNaWC46myu;
                this.__p_DdGwkIhk3zkPIuc61RIyaA = __p_DdGwkIhk3zkPIuc61RIyaA;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 243885U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IKMLoIqK7roLwjblZg9cs1", Name = "FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1")]
    [n2.SerializableAttribute]
    public class FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 CreateDefault()
        {
            var instance = new FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 Update(n37.Path File_Path_In, n2.IObservable<string> Data_In, n11.Encodings Encoding_In, bool Append_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode __pad_MM5nbkTOrdSPbuqa2YOZlV_0 = __slot_MM5nbkTOrdSPbuqa2YOZlV;
            n8.FileMode __pad_QzlQP563BPfPHRYXUJ7WP4_1 = __slot_QzlQP563BPfPHRYXUJ7WP4;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_MM5nbkTOrdSPbuqa2YOZlV_0, Input_2_In: __pad_QzlQP563BPfPHRYXUJ7WP4_1, Output_Out: out n8.FileMode Output_2);
            n8.FileAccess File_Access_3 = __c_HBCaCBx34TdMcPDGNIcAAn;
            n8.FileShare File_Share_4 = __c_D7Q6q0DznEVLMBSInAMyPu;
            n7.FileNode Input_5 = this.__p_QORgCiH9oHuMozJ8fLeT7A;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_2, fileAccess: File_Access_3, fileShare: File_Share_4);
            var State_Output_8 = this.__p_U5KBqoqg5LVOdRDIG8dJjH.Update<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Input_In: Result_6, Output_Out: out n9.IResourceProvider<n8.Stream> Output_7);
            var Output_12 = this.__p_QdID3fgipNpQLfv0HRxV4I.Update(Input_In: Output_7, Data_In: Data_In, Encoding_In: Encoding_In, Progress_Out: out float Progress_9, In_Progress_Out: out bool In_Progress_10, On_Completed_Out: out bool On_Completed_11);
            Progress_Out = Progress_9;
            In_Progress_Out = In_Progress_10;
            On_Completed_Out = On_Completed_11;
            n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Input_5 != this.__p_QORgCiH9oHuMozJ8fLeT7A || State_Output_8 != this.__p_U5KBqoqg5LVOdRDIG8dJjH || Output_12 != this.__p_QdID3fgipNpQLfv0HRxV4I ? new FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(this)
                {__p_QORgCiH9oHuMozJ8fLeT7A = Input_5, __p_U5KBqoqg5LVOdRDIG8dJjH = State_Output_8, __p_QdID3fgipNpQLfv0HRxV4I = Output_12} : that_13;
            else
            {
                this.__p_QORgCiH9oHuMozJ8fLeT7A = Input_5;
                this.__p_U5KBqoqg5LVOdRDIG8dJjH = State_Output_8;
                this.__p_QdID3fgipNpQLfv0HRxV4I = Output_12;
            }

            return that_13;
        }

        public n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "QORgCiH9oHuMozJ8fLeT7A", 243897U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "QdID3fgipNpQLfv0HRxV4I", 243918U);
            var Output_3 = n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "U5KBqoqg5LVOdRDIG8dJjH", 243979U);
            var Output_5 = n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_4);
            n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 that_6 = this;
            this.__p_QORgCiH9oHuMozJ8fLeT7A = Output_1;
            this.__p_QdID3fgipNpQLfv0HRxV4I = Output_3;
            this.__p_U5KBqoqg5LVOdRDIG8dJjH = Output_5;
            return that_6;
        }

        public n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 __CreateDefault__()
        {
            n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 that_0 = this;
            this.__p_QORgCiH9oHuMozJ8fLeT7A = default(n7.FileNode);
            this.__p_U5KBqoqg5LVOdRDIG8dJjH = n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            this.__p_QdID3fgipNpQLfv0HRxV4I = n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QORgCiH9oHuMozJ8fLeT7A);
            n1.CompilationHelper.SafeDispose(this.__p_U5KBqoqg5LVOdRDIG8dJjH);
            n1.CompilationHelper.SafeDispose(this.__p_QdID3fgipNpQLfv0HRxV4I);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 243937U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "QzlQP563BPfPHRYXUJ7WP4", Name = "__slot_QzlQP563BPfPHRYXUJ7WP4")]
        public static n8.FileMode __slot_QzlQP563BPfPHRYXUJ7WP4 = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "QzlQP563BPfPHRYXUJ7WP4");
        [n1.ElementAttribute(TracingId = 243960U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MM5nbkTOrdSPbuqa2YOZlV", Name = "__slot_MM5nbkTOrdSPbuqa2YOZlV")]
        public static n8.FileMode __slot_MM5nbkTOrdSPbuqa2YOZlV = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "MM5nbkTOrdSPbuqa2YOZlV");
        [n1.ElementAttribute(TracingId = 243897U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "QORgCiH9oHuMozJ8fLeT7A", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_QORgCiH9oHuMozJ8fLeT7A;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_HBCaCBx34TdMcPDGNIcAAn = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "HBCaCBx34TdMcPDGNIcAAn");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_D7Q6q0DznEVLMBSInAMyPu = n1.CompilationHelper.Deserialize<n8.FileShare>("None", false, "PcdEIeqrXeZQCL5lc35ctR", "D7Q6q0DznEVLMBSInAMyPu");
        [n1.ElementAttribute(TracingId = 243979U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "U5KBqoqg5LVOdRDIG8dJjH", Name = "SerialSharing", IsManaged = true, IsAutoGenerated = true)]
        public n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream> __p_U5KBqoqg5LVOdRDIG8dJjH;
        [n1.ElementAttribute(TracingId = 243918U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "QdID3fgipNpQLfv0HRxV4I", Name = "StringWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy __p_QdID3fgipNpQLfv0HRxV4I;
        static FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1()
        {
        }

        public FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 other): base(other)
        {
            this.__p_QORgCiH9oHuMozJ8fLeT7A = other.__p_QORgCiH9oHuMozJ8fLeT7A;
            this.__p_U5KBqoqg5LVOdRDIG8dJjH = other.__p_U5KBqoqg5LVOdRDIG8dJjH;
            this.__p_QdID3fgipNpQLfv0HRxV4I = other.__p_QdID3fgipNpQLfv0HRxV4I;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QORgCiH9oHuMozJ8fLeT7A", in __p_QORgCiH9oHuMozJ8fLeT7A), n1.CompilationHelper.GetValueOrExisting(values, "__p_U5KBqoqg5LVOdRDIG8dJjH", in __p_U5KBqoqg5LVOdRDIG8dJjH), n1.CompilationHelper.GetValueOrExisting(values, "__p_QdID3fgipNpQLfv0HRxV4I", in __p_QdID3fgipNpQLfv0HRxV4I));
        }

        internal FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 __WITH__(n7.FileNode __p_QORgCiH9oHuMozJ8fLeT7A, n50.SerialSharing_UIpvYTsjtgNNZH3ZY2bZ3H<n9.IResourceProvider<n8.Stream>, n8.Stream> __p_U5KBqoqg5LVOdRDIG8dJjH, n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy __p_QdID3fgipNpQLfv0HRxV4I)
        {
            n30.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QORgCiH9oHuMozJ8fLeT7A != this.__p_QORgCiH9oHuMozJ8fLeT7A || __p_U5KBqoqg5LVOdRDIG8dJjH != this.__p_U5KBqoqg5LVOdRDIG8dJjH || __p_QdID3fgipNpQLfv0HRxV4I != this.__p_QdID3fgipNpQLfv0HRxV4I ? new FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1(this)
                {__p_QORgCiH9oHuMozJ8fLeT7A = __p_QORgCiH9oHuMozJ8fLeT7A, __p_U5KBqoqg5LVOdRDIG8dJjH = __p_U5KBqoqg5LVOdRDIG8dJjH, __p_QdID3fgipNpQLfv0HRxV4I = __p_QdID3fgipNpQLfv0HRxV4I} : that_0;
            else
            {
                this.__p_QORgCiH9oHuMozJ8fLeT7A = __p_QORgCiH9oHuMozJ8fLeT7A;
                this.__p_U5KBqoqg5LVOdRDIG8dJjH = __p_U5KBqoqg5LVOdRDIG8dJjH;
                this.__p_QdID3fgipNpQLfv0HRxV4I = __p_QdID3fgipNpQLfv0HRxV4I;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 244168U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "M1IAv37BbqlMBsE7EEZOwv", Name = "FileCopier_M1IAv37BbqlMBsE7EEZOwv")]
    [n2.SerializableAttribute]
    public class FileCopier_M1IAv37BbqlMBsE7EEZOwv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv Create(n1.NodeContext Node_Context)
        {
            var instance = new FileCopier_M1IAv37BbqlMBsE7EEZOwv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv CreateDefault()
        {
            var instance = new FileCopier_M1IAv37BbqlMBsE7EEZOwv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv Update(n37.Path From_In, n37.Path To_In, bool Copy_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode File_Mode_0 = __c_UjlxzKtsIPdLvoBiOsj35o;
            n8.FileAccess File_Access_1 = __c_PnZcwcZYOf5NNbgSyQjT7n;
            n8.FileShare File_Share_2 = __c_GoZjDPqK2kLLjp3G0yqLNS;
            n7.FileNode Input_3 = this.__p_GPA2m8jj5eELWNjDZvvjae;
            var Result_4 = Input_3.Update(filePath: From_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n32._Operations_.Update_H<n9.IResourceProvider<n8.Stream>>(Input_In: this.__p_Vb7dQTEpEMyOxQm0qstjAr, Message_In: Result_4, Send_In: Copy_In, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_5, Result_Out: out n2.IObservable<n9.IResourceProvider<n8.Stream>> Result_6);
            n7.AsyncByteReader Input__this__7 = this.__p_SU8PlXQohhnLl6LUz2jE0H;
            var Result_8 = Input__this__7.Update(input: Result_6);
            n8.FileMode File_Mode_9 = __c_KdLiN7urydYO2STpUCbuN1;
            n8.FileAccess File_Access_10 = __c_RhEu1phcBQRPHlJSaNkYZM;
            n8.FileShare File_Share_11 = __c_TYPnsMUbe3bMijjVMaQLiy;
            n7.FileNode Input_12 = this.__p_Tq02xp6fpLvOFtEtoheLv3;
            var Result_13 = Input_12.Update(filePath: To_In, fileMode: File_Mode_9, fileAccess: File_Access_10, fileShare: File_Share_11);
            n7.AsyncByteWriter Input__this__14 = this.__p_JmlOdDMpjBtLxc6jECBPYe;
            var Result_15 = Input__this__14.Update(input: Result_13, data: Result_8);
            n44._Operations_.Update_H<byte>(State_Input_In: this.__p_ArIvx10BiaULdqN56WFMyp, Input_In: Result_15, State_Output_Out: out n7.Monitor<byte> State_Output_16, Output_Out: out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Output_17, Progress_Out: out float Progress_18, In_Progress_Out: out bool In_Progress_19, On_Completed_Out: out bool On_Completed_20);
            var Output_22 = this.__p_O1fQfuk7M4hMSnOz9JtLPe.Update(Value_In: Output_17, Result_Out: out n2.IObservable<n7.Chunk<byte>> Result_21);
            bool Update_23 = true;
            var Output_24 = this.__p_VXp3loFfWswLYGfI7LTCd4;
            if (Update_23)
            {
                Output_24 = this.__p_VXp3loFfWswLYGfI7LTCd4.Update(Input_In: Result_21);
            }

            Progress_Out = Progress_18;
            In_Progress_Out = In_Progress_19;
            On_Completed_Out = On_Completed_20;
            n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Input_3 != this.__p_GPA2m8jj5eELWNjDZvvjae || Output_5 != this.__p_Vb7dQTEpEMyOxQm0qstjAr || Input__this__7 != this.__p_SU8PlXQohhnLl6LUz2jE0H || Input_12 != this.__p_Tq02xp6fpLvOFtEtoheLv3 || Input__this__14 != this.__p_JmlOdDMpjBtLxc6jECBPYe || State_Output_16 != this.__p_ArIvx10BiaULdqN56WFMyp || Output_22 != this.__p_O1fQfuk7M4hMSnOz9JtLPe || Output_24 != this.__p_VXp3loFfWswLYGfI7LTCd4 ? new FileCopier_M1IAv37BbqlMBsE7EEZOwv(this)
                {__p_GPA2m8jj5eELWNjDZvvjae = Input_3, __p_Vb7dQTEpEMyOxQm0qstjAr = Output_5, __p_SU8PlXQohhnLl6LUz2jE0H = Input__this__7, __p_Tq02xp6fpLvOFtEtoheLv3 = Input_12, __p_JmlOdDMpjBtLxc6jECBPYe = Input__this__14, __p_ArIvx10BiaULdqN56WFMyp = State_Output_16, __p_O1fQfuk7M4hMSnOz9JtLPe = Output_22, __p_VXp3loFfWswLYGfI7LTCd4 = Output_24} : that_25;
            else
            {
                this.__p_GPA2m8jj5eELWNjDZvvjae = Input_3;
                this.__p_Vb7dQTEpEMyOxQm0qstjAr = Output_5;
                this.__p_SU8PlXQohhnLl6LUz2jE0H = Input__this__7;
                this.__p_Tq02xp6fpLvOFtEtoheLv3 = Input_12;
                this.__p_JmlOdDMpjBtLxc6jECBPYe = Input__this__14;
                this.__p_ArIvx10BiaULdqN56WFMyp = State_Output_16;
                this.__p_O1fQfuk7M4hMSnOz9JtLPe = Output_22;
                this.__p_VXp3loFfWswLYGfI7LTCd4 = Output_24;
            }

            return that_25;
        }

        public n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "GPA2m8jj5eELWNjDZvvjae", 244174U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.FileNode Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SU8PlXQohhnLl6LUz2jE0H", 244219U);
            n46._Operations_.Create(Node_Context_In: Node_Context_2, Output_Out: out n7.AsyncByteReader Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Vb7dQTEpEMyOxQm0qstjAr", 244225U);
            n32._Operations_.Create_H<n9.IResourceProvider<n8.Stream>>(Node_Context: Node_Context_4, Output_Out: out n31.ToObservable<n9.IResourceProvider<n8.Stream>> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Tq02xp6fpLvOFtEtoheLv3", 244236U);
            n39._Operations_.Create_H(Node_Context_In: Node_Context_6, Output_Out: out n7.FileNode Output_7);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "JmlOdDMpjBtLxc6jECBPYe", 244262U);
            n48._Operations_.Create(Node_Context_In: Node_Context_8, Output_Out: out n7.AsyncByteWriter Output_9);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "ArIvx10BiaULdqN56WFMyp", 244271U);
            n44._Operations_.Create_H<byte>(Node_Context: Node_Context_10, Output_Out: out n7.Monitor<byte> Output_11);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "O1fQfuk7M4hMSnOz9JtLPe", 244292U);
            var Output_13 = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>>.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "VXp3loFfWswLYGfI7LTCd4", 244297U);
            var Output_15 = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>>.Create(Node_Context: Node_Context_14);
            n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv that_16 = this;
            this.__p_GPA2m8jj5eELWNjDZvvjae = Output_1;
            this.__p_SU8PlXQohhnLl6LUz2jE0H = Output_3;
            this.__p_Vb7dQTEpEMyOxQm0qstjAr = Output_5;
            this.__p_Tq02xp6fpLvOFtEtoheLv3 = Output_7;
            this.__p_JmlOdDMpjBtLxc6jECBPYe = Output_9;
            this.__p_ArIvx10BiaULdqN56WFMyp = Output_11;
            this.__p_O1fQfuk7M4hMSnOz9JtLPe = Output_13;
            this.__p_VXp3loFfWswLYGfI7LTCd4 = Output_15;
            return that_16;
        }

        public n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv __CreateDefault__()
        {
            n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv that_0 = this;
            this.__p_GPA2m8jj5eELWNjDZvvjae = default(n7.FileNode);
            this.__p_Vb7dQTEpEMyOxQm0qstjAr = default(n31.ToObservable<n9.IResourceProvider<n8.Stream>>);
            this.__p_SU8PlXQohhnLl6LUz2jE0H = default(n7.AsyncByteReader);
            this.__p_Tq02xp6fpLvOFtEtoheLv3 = default(n7.FileNode);
            this.__p_JmlOdDMpjBtLxc6jECBPYe = default(n7.AsyncByteWriter);
            this.__p_ArIvx10BiaULdqN56WFMyp = default(n7.Monitor<byte>);
            this.__p_O1fQfuk7M4hMSnOz9JtLPe = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>>.CreateDefault();
            this.__p_VXp3loFfWswLYGfI7LTCd4 = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GPA2m8jj5eELWNjDZvvjae);
            n1.CompilationHelper.SafeDispose(this.__p_Vb7dQTEpEMyOxQm0qstjAr);
            n1.CompilationHelper.SafeDispose(this.__p_SU8PlXQohhnLl6LUz2jE0H);
            n1.CompilationHelper.SafeDispose(this.__p_Tq02xp6fpLvOFtEtoheLv3);
            n1.CompilationHelper.SafeDispose(this.__p_JmlOdDMpjBtLxc6jECBPYe);
            n1.CompilationHelper.SafeDispose(this.__p_ArIvx10BiaULdqN56WFMyp);
            n1.CompilationHelper.SafeDispose(this.__p_O1fQfuk7M4hMSnOz9JtLPe);
            n1.CompilationHelper.SafeDispose(this.__p_VXp3loFfWswLYGfI7LTCd4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 244174U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GPA2m8jj5eELWNjDZvvjae", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_GPA2m8jj5eELWNjDZvvjae;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_UjlxzKtsIPdLvoBiOsj35o = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "UjlxzKtsIPdLvoBiOsj35o");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_PnZcwcZYOf5NNbgSyQjT7n = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "PnZcwcZYOf5NNbgSyQjT7n");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_GoZjDPqK2kLLjp3G0yqLNS = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "GoZjDPqK2kLLjp3G0yqLNS");
        [n1.ElementAttribute(TracingId = 244225U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Vb7dQTEpEMyOxQm0qstjAr", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_Vb7dQTEpEMyOxQm0qstjAr;
        [n1.ElementAttribute(TracingId = 244219U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SU8PlXQohhnLl6LUz2jE0H", Name = "ByteReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteReader __p_SU8PlXQohhnLl6LUz2jE0H;
        [n1.ElementAttribute(TracingId = 244236U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Tq02xp6fpLvOFtEtoheLv3", Name = "File", IsManaged = true, IsAutoGenerated = true)]
        public n7.FileNode __p_Tq02xp6fpLvOFtEtoheLv3;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileMode __c_KdLiN7urydYO2STpUCbuN1 = n1.CompilationHelper.Deserialize<n8.FileMode>("OpenOrCreate", false, "PcdEIeqrXeZQCL5lc35ctR", "KdLiN7urydYO2STpUCbuN1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileAccess __c_RhEu1phcBQRPHlJSaNkYZM = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "RhEu1phcBQRPHlJSaNkYZM");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_TYPnsMUbe3bMijjVMaQLiy = n1.CompilationHelper.Deserialize<n8.FileShare>("None", false, "PcdEIeqrXeZQCL5lc35ctR", "TYPnsMUbe3bMijjVMaQLiy");
        [n1.ElementAttribute(TracingId = 244262U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JmlOdDMpjBtLxc6jECBPYe", Name = "ByteWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncByteWriter __p_JmlOdDMpjBtLxc6jECBPYe;
        [n1.ElementAttribute(TracingId = 244271U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ArIvx10BiaULdqN56WFMyp", Name = "Monitor (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Monitor<byte> __p_ArIvx10BiaULdqN56WFMyp;
        [n1.ElementAttribute(TracingId = 244292U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "O1fQfuk7M4hMSnOz9JtLPe", Name = "Switch", IsManaged = true, IsAutoGenerated = true)]
        public n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>> __p_O1fQfuk7M4hMSnOz9JtLPe;
        [n1.ElementAttribute(TracingId = 244297U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "VXp3loFfWswLYGfI7LTCd4", Name = "Subscribe", IsManaged = true, IsAutoGenerated = true)]
        public n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>> __p_VXp3loFfWswLYGfI7LTCd4;
        static FileCopier_M1IAv37BbqlMBsE7EEZOwv()
        {
        }

        public FileCopier_M1IAv37BbqlMBsE7EEZOwv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileCopier_M1IAv37BbqlMBsE7EEZOwv(FileCopier_M1IAv37BbqlMBsE7EEZOwv other): base(other)
        {
            this.__p_GPA2m8jj5eELWNjDZvvjae = other.__p_GPA2m8jj5eELWNjDZvvjae;
            this.__p_Vb7dQTEpEMyOxQm0qstjAr = other.__p_Vb7dQTEpEMyOxQm0qstjAr;
            this.__p_SU8PlXQohhnLl6LUz2jE0H = other.__p_SU8PlXQohhnLl6LUz2jE0H;
            this.__p_Tq02xp6fpLvOFtEtoheLv3 = other.__p_Tq02xp6fpLvOFtEtoheLv3;
            this.__p_JmlOdDMpjBtLxc6jECBPYe = other.__p_JmlOdDMpjBtLxc6jECBPYe;
            this.__p_ArIvx10BiaULdqN56WFMyp = other.__p_ArIvx10BiaULdqN56WFMyp;
            this.__p_O1fQfuk7M4hMSnOz9JtLPe = other.__p_O1fQfuk7M4hMSnOz9JtLPe;
            this.__p_VXp3loFfWswLYGfI7LTCd4 = other.__p_VXp3loFfWswLYGfI7LTCd4;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GPA2m8jj5eELWNjDZvvjae", in __p_GPA2m8jj5eELWNjDZvvjae), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vb7dQTEpEMyOxQm0qstjAr", in __p_Vb7dQTEpEMyOxQm0qstjAr), n1.CompilationHelper.GetValueOrExisting(values, "__p_SU8PlXQohhnLl6LUz2jE0H", in __p_SU8PlXQohhnLl6LUz2jE0H), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tq02xp6fpLvOFtEtoheLv3", in __p_Tq02xp6fpLvOFtEtoheLv3), n1.CompilationHelper.GetValueOrExisting(values, "__p_JmlOdDMpjBtLxc6jECBPYe", in __p_JmlOdDMpjBtLxc6jECBPYe), n1.CompilationHelper.GetValueOrExisting(values, "__p_ArIvx10BiaULdqN56WFMyp", in __p_ArIvx10BiaULdqN56WFMyp), n1.CompilationHelper.GetValueOrExisting(values, "__p_O1fQfuk7M4hMSnOz9JtLPe", in __p_O1fQfuk7M4hMSnOz9JtLPe), n1.CompilationHelper.GetValueOrExisting(values, "__p_VXp3loFfWswLYGfI7LTCd4", in __p_VXp3loFfWswLYGfI7LTCd4));
        }

        internal FileCopier_M1IAv37BbqlMBsE7EEZOwv __WITH__(n7.FileNode __p_GPA2m8jj5eELWNjDZvvjae, n31.ToObservable<n9.IResourceProvider<n8.Stream>> __p_Vb7dQTEpEMyOxQm0qstjAr, n7.AsyncByteReader __p_SU8PlXQohhnLl6LUz2jE0H, n7.FileNode __p_Tq02xp6fpLvOFtEtoheLv3, n7.AsyncByteWriter __p_JmlOdDMpjBtLxc6jECBPYe, n7.Monitor<byte> __p_ArIvx10BiaULdqN56WFMyp, n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<byte>>>, n7.Chunk<byte>> __p_O1fQfuk7M4hMSnOz9JtLPe, n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<byte>>, n7.Chunk<byte>> __p_VXp3loFfWswLYGfI7LTCd4)
        {
            n30.FileCopier_M1IAv37BbqlMBsE7EEZOwv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GPA2m8jj5eELWNjDZvvjae != this.__p_GPA2m8jj5eELWNjDZvvjae || __p_Vb7dQTEpEMyOxQm0qstjAr != this.__p_Vb7dQTEpEMyOxQm0qstjAr || __p_SU8PlXQohhnLl6LUz2jE0H != this.__p_SU8PlXQohhnLl6LUz2jE0H || __p_Tq02xp6fpLvOFtEtoheLv3 != this.__p_Tq02xp6fpLvOFtEtoheLv3 || __p_JmlOdDMpjBtLxc6jECBPYe != this.__p_JmlOdDMpjBtLxc6jECBPYe || __p_ArIvx10BiaULdqN56WFMyp != this.__p_ArIvx10BiaULdqN56WFMyp || __p_O1fQfuk7M4hMSnOz9JtLPe != this.__p_O1fQfuk7M4hMSnOz9JtLPe || __p_VXp3loFfWswLYGfI7LTCd4 != this.__p_VXp3loFfWswLYGfI7LTCd4 ? new FileCopier_M1IAv37BbqlMBsE7EEZOwv(this)
                {__p_GPA2m8jj5eELWNjDZvvjae = __p_GPA2m8jj5eELWNjDZvvjae, __p_Vb7dQTEpEMyOxQm0qstjAr = __p_Vb7dQTEpEMyOxQm0qstjAr, __p_SU8PlXQohhnLl6LUz2jE0H = __p_SU8PlXQohhnLl6LUz2jE0H, __p_Tq02xp6fpLvOFtEtoheLv3 = __p_Tq02xp6fpLvOFtEtoheLv3, __p_JmlOdDMpjBtLxc6jECBPYe = __p_JmlOdDMpjBtLxc6jECBPYe, __p_ArIvx10BiaULdqN56WFMyp = __p_ArIvx10BiaULdqN56WFMyp, __p_O1fQfuk7M4hMSnOz9JtLPe = __p_O1fQfuk7M4hMSnOz9JtLPe, __p_VXp3loFfWswLYGfI7LTCd4 = __p_VXp3loFfWswLYGfI7LTCd4} : that_0;
            else
            {
                this.__p_GPA2m8jj5eELWNjDZvvjae = __p_GPA2m8jj5eELWNjDZvvjae;
                this.__p_Vb7dQTEpEMyOxQm0qstjAr = __p_Vb7dQTEpEMyOxQm0qstjAr;
                this.__p_SU8PlXQohhnLl6LUz2jE0H = __p_SU8PlXQohhnLl6LUz2jE0H;
                this.__p_Tq02xp6fpLvOFtEtoheLv3 = __p_Tq02xp6fpLvOFtEtoheLv3;
                this.__p_JmlOdDMpjBtLxc6jECBPYe = __p_JmlOdDMpjBtLxc6jECBPYe;
                this.__p_ArIvx10BiaULdqN56WFMyp = __p_ArIvx10BiaULdqN56WFMyp;
                this.__p_O1fQfuk7M4hMSnOz9JtLPe = __p_O1fQfuk7M4hMSnOz9JtLPe;
                this.__p_VXp3loFfWswLYGfI7LTCd4 = __p_VXp3loFfWswLYGfI7LTCd4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 245475U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "I03t4Vl2eeONCIn4wcBPLF", Name = "SerialPort3_C")]
    [n2.SerializableAttribute]
    public class SerialPort3_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.SerialPort3_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SerialPort3_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.SerialPort3_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SerialPort3_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.SerialPort3_C Update(n28.ComPort Port_Name_In, [n4.SerializedDefaultValueAttribute("115200", false)] int Baudrate_In, [n4.SerializedDefaultValueAttribute("8", false)] int Data_Bits_In, [n4.SerializedDefaultValueAttribute("One", false)] n29.StopBits Stop_Bits_In, n29.Parity Parity_In, n29.Handshake Handshake_In, bool Rts_Enable_In, bool Dtr_Enable_In, bool Break_State_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Open_In, out n2.IObservable<byte[]> Data_Out, out bool Is_Open_Out)
        {
            n51.Subject<byte[]> __pad_QX6cBxxBbG8O53Z7jSJqjB_0 = this.__slot_QX6cBxxBbG8O53Z7jSJqjB;
            int __pad_G4bGv8Inay3O1vSkoebuDy_1 = __slot_G4bGv8Inay3O1vSkoebuDy;
            byte[] __pad_IrsddYWpl1IN3Qm98MsB8q_2 = this.__slot_IrsddYWpl1IN3Qm98MsB8q;
            bool Force_3 = false;
            bool Dispose_Cached_Outputs_4 = true;
            var manager_5 = this.__cache_GMAuwT8aAwcMc80EaVsP13;
            if (manager_5 is null)
            {
                manager_5 = new n19.Manager<n2.ValueTuple<n28.ComPort, int, n29.Parity, int, n29.StopBits, n29.Handshake, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n29.SerialPort>>(n2.ValueTuple.Create(default(n29.SerialPort)));
            }

            var inputs_6 = (Port_Name_In, Baudrate_In, Parity_In, Data_Bits_In, Stop_Bits_In, Handshake_In, Rts_Enable_In, Dtr_Enable_In);
            var outputs_7 = manager_5.Outputs;
            var Has_Changed_8 = Force_3 || manager_5.InputsChanged(inputs_6);
            if (Has_Changed_8)
            {
                if (Dispose_Cached_Outputs_4)
                    manager_5.DisposeOutputs();
                var state_9 = n1.CompilationHelper.Restore<__OHC0UwH5OvGLimkPX2pRKV>(manager_5.State, __GetContext__());
                if (state_9 == null)
                {
                    state_9 = new __OHC0UwH5OvGLimkPX2pRKV(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "UNSUNfqZWweLaMfk7dsgqv", 245543U);
                    var Output_11 = n17.Try_NXr6u6gowSzLvQTfp53h2q.Create(Node_Context: Node_Context_10);
                    state_9.__p_UNSUNfqZWweLaMfk7dsgqv = Output_11;
                }

                n12.IDynamicEnum Input_12 = (n12.IDynamicEnum)Port_Name_In;
                var Value_13 = Input_12.Value;
                bool Stick_To_Last_Valid_Outputs_14 = false;
                bool Reset_Region_On_Failure_15 = false;
                var customRegion_16 = state_9.__customRegion_UNSUNfqZWweLaMfk7dsgqv ?? new n60.CustomRegion();
                customRegion_16.newPatchSymbol = 6101447;
                customRegion_16.BeginChanges();
                customRegion_16.AddIncomingLink(typeof(int), 0);
                customRegion_16.AddIncomingLink(typeof(n29.Parity), 1);
                customRegion_16.AddIncomingLink(typeof(int), 2);
                customRegion_16.AddIncomingLink(typeof(string), 3);
                customRegion_16.AddIncomingLink(typeof(n29.Handshake), 4);
                customRegion_16.AddIncomingLink(typeof(bool), 5);
                customRegion_16.AddIncomingLink(typeof(bool), 6);
                customRegion_16.AddIncomingLink(typeof(n29.StopBits), 7);
                customRegion_16.AddOutput("", typeof(n29.SerialPort), 0);
                customRegion_16.SetInputValues();
                customRegion_16.SetIncomingLinkValues(Baudrate_In, Parity_In, Data_Bits_In, Value_13, Handshake_In, Rts_Enable_In, Dtr_Enable_In, Stop_Bits_In);
                customRegion_16.EndChanges();
                var __fallback___17 = n1.ServiceRegistry.Current;
                customRegion_16.PatchUpdator = (n2.Object stateInput_20, n10.IReadOnlyList<n2.Object> inputs_21, n10.IReadOnlyList<n2.Object> incomingLinks_22, out n2.Object stateOutput_31, out n12.Spread<n2.Object> outputs_32) =>
                {
                    using var __current_18 = __fallback___17.MakeCurrentIfNone();
                    var state_19 = n1.CompilationHelper.Restore<__CMZ401nMc7gL6AZSmJdnFJ>(stateInput_20, __GetContext__());
                    var link_R9ZzdK59AM0MZRukHvL0UT_23 = (int)incomingLinks_22[0];
                    var link_Lsx9YIVAeUoOdznLLaM7cE_24 = (n29.Parity)incomingLinks_22[1];
                    var link_IxsNiNE0FNPMJPBUe0KuCm_25 = (int)incomingLinks_22[2];
                    var link_Bd5iwHZUZHiLigT4DJPgTm_26 = (string)incomingLinks_22[3];
                    var link_HnsyjWGDAEBNfvkMEstR1t_27 = (n29.Handshake)incomingLinks_22[4];
                    var link_SIiElVjrsdgMPO31JLzZcA_28 = (bool)incomingLinks_22[5];
                    var link_DwxOWFqO2FsPhxzcmpSutJ_29 = (bool)incomingLinks_22[6];
                    var link_Ibl11Z8xCJyLoOVcdNcHfN_30 = (n29.StopBits)incomingLinks_22[7];
                    var Output_33 = new n29.SerialPort(portName: link_Bd5iwHZUZHiLigT4DJPgTm_26, baudRate: link_R9ZzdK59AM0MZRukHvL0UT_23, parity: link_Lsx9YIVAeUoOdznLLaM7cE_24, dataBits: link_IxsNiNE0FNPMJPBUe0KuCm_25, stopBits: link_Ibl11Z8xCJyLoOVcdNcHfN_30);
                    Output_33.Handshake = link_HnsyjWGDAEBNfvkMEstR1t_27;
                    Output_33.RtsEnable = link_SIiElVjrsdgMPO31JLzZcA_28;
                    Output_33.DtrEnable = link_DwxOWFqO2FsPhxzcmpSutJ_29;
                    stateOutput_31 = state_19;
                    outputs_32 = n4.CollectionExtensions.CreateSpreadOfObjects(Output_33);
                }

                ;
                customRegion_16.PatchCreator = (n10.IReadOnlyList<n2.Object> initialInputs_35, out n2.Object stateOutput_36, out n12.Spread<n2.Object> initialOutputs_37) =>
                {
                    using var __current_34 = __fallback___17.MakeCurrentIfNone();
                    var state_19 = new __CMZ401nMc7gL6AZSmJdnFJ(__GetContext__(), n1.VLObject.NewIdentity());
                    stateOutput_36 = state_19;
                    initialOutputs_37 = n4.CollectionExtensions.CreateSpreadOfObjects(default(n29.SerialPort));
                }

                ;
                var Output_41 = state_9.__p_UNSUNfqZWweLaMfk7dsgqv.Update(Stick_To_Last_Valid_Outputs_In: Stick_To_Last_Valid_Outputs_14, Reset_Region_On_Failure_In: Reset_Region_On_Failure_15, Region_In: customRegion_16, Success_Out: out bool Success_38, Error_Message_Out: out string Error_Message_39, Failure_Out: out bool Failure_40);
                var __auto_42 = (n29.SerialPort)customRegion_16.OutputValues[0];
                state_9.__customRegion_UNSUNfqZWweLaMfk7dsgqv = customRegion_16;
                state_9.__p_UNSUNfqZWweLaMfk7dsgqv = Output_41;
                outputs_7 = n2.ValueTuple.Create(__auto_42);
                manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, state_9, outputs_7);
            }
            else
            {
                manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
            }

            var __auto_43 = outputs_7.Item1;
            this.__cache_GMAuwT8aAwcMc80EaVsP13 = manager_5;
            var Output_46 = this.__p_R00VttHKpBkLet0r9e2wqq.Update(Value_In: Open_In, Up_Edge_Out: out bool Up_Edge_44, Down_Edge_Out: out bool Down_Edge_45);
            this.__p_R00VttHKpBkLet0r9e2wqq = Output_46;
            var Output_47 = Has_Changed_8 || Up_Edge_44;
            n53.ObjectHelpers.IsAssigned(x: __auto_43, result: out bool Result_48, notAssigned: out bool Not_Assigned_49);
            var Output_50 = Result_48 && Down_Edge_45;
            var Output_51 = Result_48 && Output_47;
            n29.SerialPort __auto_52;
            var state_53 = n1.CompilationHelper.Restore<__UZ74g1vBdCMQT4pJzzChBo>(this.__if_HewgCOWktfXQBVhXrdNF3j, __GetContext__());
            if (Output_51)
            {
                if (state_53 == null)
                {
                    state_53 = new __UZ74g1vBdCMQT4pJzzChBo(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_54 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IHpoIbV5nzuLXnaj2BY6Q6", 245732U);
                    var Output_55 = n17.Try_NXr6u6gowSzLvQTfp53h2q.Create(Node_Context: Node_Context_54);
                    state_53.__p_IHpoIbV5nzuLXnaj2BY6Q6 = Output_55;
                }

                bool Stick_To_Last_Valid_Outputs_56 = false;
                bool Reset_Region_On_Failure_57 = false;
                var customRegion_58 = state_53.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6 ?? new n60.CustomRegion();
                customRegion_58.newPatchSymbol = 43294408;
                customRegion_58.BeginChanges();
                customRegion_58.AddIncomingLink(typeof(n29.SerialPort), 0);
                customRegion_58.AddOutput("", typeof(n29.SerialPort), 0);
                customRegion_58.SetInputValues();
                customRegion_58.SetIncomingLinkValues(__auto_43);
                customRegion_58.EndChanges();
                var __fallback___59 = n1.ServiceRegistry.Current;
                customRegion_58.PatchUpdator = (n2.Object stateInput_62, n10.IReadOnlyList<n2.Object> inputs_63, n10.IReadOnlyList<n2.Object> incomingLinks_64, out n2.Object stateOutput_66, out n12.Spread<n2.Object> outputs_67) =>
                {
                    using var __current_60 = __fallback___59.MakeCurrentIfNone();
                    var state_61 = n1.CompilationHelper.Restore<__ATx64oHGI9bMKQytyaDeF4>(stateInput_62, __GetContext__());
                    var link_QTivU41sOnuNni6Zo2BlND_65 = (n29.SerialPort)incomingLinks_64[0];
                    link_QTivU41sOnuNni6Zo2BlND_65.Open();
                    stateOutput_66 = state_61;
                    outputs_67 = n4.CollectionExtensions.CreateSpreadOfObjects(link_QTivU41sOnuNni6Zo2BlND_65);
                }

                ;
                customRegion_58.PatchCreator = (n10.IReadOnlyList<n2.Object> initialInputs_69, out n2.Object stateOutput_70, out n12.Spread<n2.Object> initialOutputs_71) =>
                {
                    using var __current_68 = __fallback___59.MakeCurrentIfNone();
                    var state_61 = new __ATx64oHGI9bMKQytyaDeF4(__GetContext__(), n1.VLObject.NewIdentity());
                    stateOutput_70 = state_61;
                    initialOutputs_71 = n4.CollectionExtensions.CreateSpreadOfObjects(default(n29.SerialPort));
                }

                ;
                var Output_75 = state_53.__p_IHpoIbV5nzuLXnaj2BY6Q6.Update(Stick_To_Last_Valid_Outputs_In: Stick_To_Last_Valid_Outputs_56, Reset_Region_On_Failure_In: Reset_Region_On_Failure_57, Region_In: customRegion_58, Success_Out: out bool Success_72, Error_Message_Out: out string Error_Message_73, Failure_Out: out bool Failure_74);
                var __auto_76 = (n29.SerialPort)customRegion_58.OutputValues[0];
                __auto_52 = __auto_76;
                state_53.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6 = customRegion_58;
                state_53.__p_IHpoIbV5nzuLXnaj2BY6Q6 = Output_75;
                this.__if_HewgCOWktfXQBVhXrdNF3j = state_53;
            }
            else
            {
                __auto_52 = __auto_43;
            }

            n29.SerialPort __auto_77;
            if (Output_50)
            {
                __auto_52.Close();
                __auto_77 = __auto_52;
            }
            else
            {
                __auto_77 = __auto_52;
            }

            n53.ObjectHelpers.IsAssigned(x: __auto_77, result: out bool Result_79, notAssigned: out bool Not_Assigned_80);
            n29.SerialPort __auto_81;
            bool __auto_82;
            if (Result_79)
            {
                var Is_Open_84 = __auto_77.IsOpen;
                __auto_81 = __auto_77;
                __auto_82 = Is_Open_84;
            }
            else
            {
                __auto_81 = __auto_77;
                __auto_82 = false;
            }

            var Output_87 = this.__p_Ive7wBG2kTUM75ZIWBIv2I.Update(Value_In: Break_State_In, Result_Out: out bool Result_85, Unchanged_Out: out bool Unchanged_86);
            this.__p_Ive7wBG2kTUM75ZIWBIv2I = Output_87;
            var Output_88 = Up_Edge_44 || Result_85;
            var Output_89 = __auto_82 && Output_88;
            n29.SerialPort __auto_90;
            if (Output_89)
            {
                __auto_81.BreakState = Break_State_In;
                __auto_90 = __auto_81;
            }
            else
            {
                __auto_90 = __auto_81;
            }

            this.__slot_Di9VN1hG2KFQOz63llNIZr = __auto_82;
            bool __pad_Di9VN1hG2KFQOz63llNIZr_92 = __auto_82;
            this.__slot_Kcz9xpEc0SXLZJuHUYODoD = __auto_90;
            n29.SerialPort __pad_Kcz9xpEc0SXLZJuHUYODoD_93 = __auto_90;
            n10.IEnumerable<byte> Input_94 = (n10.IEnumerable<byte>)__pad_IrsddYWpl1IN3Qm98MsB8q_2;
            if (__auto_82)
            {
                var Bytes_To_Read_96 = __pad_Kcz9xpEc0SXLZJuHUYODoD_93.BytesToRead;
                n64._Operations_.Min<int, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Input_In: Bytes_To_Read_96, Input_2_In: __pad_G4bGv8Inay3O1vSkoebuDy_1, Output_Out: out int Output_97);
                int Offset_98 = 0;
                var Result_99 = __pad_Kcz9xpEc0SXLZJuHUYODoD_93.Read(buffer: __pad_IrsddYWpl1IN3Qm98MsB8q_2, offset: Offset_98, count: Output_97);
                int Input_2_100 = 0;
                var Result_101 = Result_99 > Input_2_100;
                if (Result_101)
                {
                    n23._Operations_.Take<byte>(Input_In: Input_94, Count_In: Result_99, Output_Out: out n10.IEnumerable<byte> Output_103);
                    n65._Operations_.FromSequence<byte>(Input_In: Output_103, Result_Out: out byte[] Result_104);
                    n66._Operations_.OnNext<byte[]>(Input_In: __pad_QX6cBxxBbG8O53Z7jSJqjB_0, Value_In: Result_104, Output_Out: out n51.Subject<byte[]> Output_105);
                }
            }

            n2.IObservable<byte[]> Data_Out_106 = (n2.IObservable<byte[]>)__pad_QX6cBxxBbG8O53Z7jSJqjB_0;
            Data_Out = Data_Out_106;
            Is_Open_Out = __auto_82;
            return this;
        }

        public n30.SerialPort3_C SendData(byte[] Data_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            bool __pad_Di9VN1hG2KFQOz63llNIZr_0 = this.__slot_Di9VN1hG2KFQOz63llNIZr;
            n29.SerialPort __pad_Kcz9xpEc0SXLZJuHUYODoD_1 = this.__slot_Kcz9xpEc0SXLZJuHUYODoD;
            var Output_2 = __pad_Di9VN1hG2KFQOz63llNIZr_0 && Apply_In;
            if (Output_2)
            {
                n65._Operations_.Length<byte>(Input_In: Data_In, Output_Out: out byte[] Output_4, Length_Out: out int Length_5);
                int Offset_6 = 0;
                __pad_Kcz9xpEc0SXLZJuHUYODoD_1.Write(buffer: Output_4, offset: Offset_6, count: Length_5);
            }

            return this;
        }

        public n30.SerialPort3_C SendString(string Data_In, [n4.SerializedDefaultValueAttribute("\r\n", false)] string Terminator_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            bool __pad_Di9VN1hG2KFQOz63llNIZr_0 = this.__slot_Di9VN1hG2KFQOz63llNIZr;
            n29.SerialPort __pad_Kcz9xpEc0SXLZJuHUYODoD_1 = this.__slot_Kcz9xpEc0SXLZJuHUYODoD;
            var Output_2 = __pad_Di9VN1hG2KFQOz63llNIZr_0 && Apply_In;
            if (Output_2)
            {
                var Output_4 = n62.StringExtensions.Plus(input: Data_In, input2: Terminator_In);
                __pad_Kcz9xpEc0SXLZJuHUYODoD_1.Write(text: Output_4);
            }

            return this;
        }

        public n30.SerialPort3_C __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_Di9VN1hG2KFQOz63llNIZr = false;
            this.__slot_IrsddYWpl1IN3Qm98MsB8q = n65._Operations_.CreateDefault<byte>();
            this.__slot_QX6cBxxBbG8O53Z7jSJqjB = default(n51.Subject<byte[]>);
            this.__slot_Kcz9xpEc0SXLZJuHUYODoD = default(n29.SerialPort);
            int __pad_G4bGv8Inay3O1vSkoebuDy_0 = __slot_G4bGv8Inay3O1vSkoebuDy;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "FuM8JtD9iDdMU8HbWqPvrX", 246023U);
            n65._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_G4bGv8Inay3O1vSkoebuDy_0, Result_Out: out byte[] Result_2);
            this.__slot_IrsddYWpl1IN3Qm98MsB8q = Result_2;
            byte[] __pad_IrsddYWpl1IN3Qm98MsB8q_3 = Result_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "LpuVcfQDqQ1Pye86JwBTSD", 246267U);
            n66._Operations_.Create<byte[]>(Node_Context: Node_Context_4, Output_Out: out n51.Subject<byte[]> Output_5);
            this.__slot_QX6cBxxBbG8O53Z7jSJqjB = Output_5;
            n51.Subject<byte[]> __pad_QX6cBxxBbG8O53Z7jSJqjB_6 = Output_5;
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "R00VttHKpBkLet0r9e2wqq", 245679U);
            var Output_8 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_7);
            this.__p_R00VttHKpBkLet0r9e2wqq = Output_8;
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Ive7wBG2kTUM75ZIWBIv2I", 246245U);
            bool Changed_On_Create_10 = true;
            var Output_11 = n17.Changed_A8JGbead2bxNdnPybiEqVS<bool>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_9, Changed_On_Create_In: Changed_On_Create_10);
            this.__p_Ive7wBG2kTUM75ZIWBIv2I = Output_11;
            this.__cache_GMAuwT8aAwcMc80EaVsP13 = null;
            this.__if_HewgCOWktfXQBVhXrdNF3j = default(n2.Object);
            return this;
        }

        public n30.SerialPort3_C __CreateDefault__()
        {
            this.__slot_Di9VN1hG2KFQOz63llNIZr = false;
            this.__slot_IrsddYWpl1IN3Qm98MsB8q = n65._Operations_.CreateDefault<byte>();
            this.__slot_QX6cBxxBbG8O53Z7jSJqjB = default(n51.Subject<byte[]>);
            this.__slot_Kcz9xpEc0SXLZJuHUYODoD = default(n29.SerialPort);
            this.__cache_GMAuwT8aAwcMc80EaVsP13 = null;
            this.__p_R00VttHKpBkLet0r9e2wqq = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__if_HewgCOWktfXQBVhXrdNF3j = default(n2.Object);
            this.__p_Ive7wBG2kTUM75ZIWBIv2I = n17.Changed_A8JGbead2bxNdnPybiEqVS<bool>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GMAuwT8aAwcMc80EaVsP13);
            n1.CompilationHelper.SafeDispose(this.__p_R00VttHKpBkLet0r9e2wqq);
            n1.CompilationHelper.SafeDispose(this.__if_HewgCOWktfXQBVhXrdNF3j);
            n1.CompilationHelper.SafeDispose(this.__p_Ive7wBG2kTUM75ZIWBIv2I);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 245921U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Di9VN1hG2KFQOz63llNIZr", Name = "__slot_Di9VN1hG2KFQOz63llNIZr")]
        public bool __slot_Di9VN1hG2KFQOz63llNIZr;
        [n1.ElementAttribute(TracingId = 246034U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "G4bGv8Inay3O1vSkoebuDy", Name = "__slot_G4bGv8Inay3O1vSkoebuDy")]
        public static int __slot_G4bGv8Inay3O1vSkoebuDy = 2048;
        [n1.ElementAttribute(TracingId = 246040U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IrsddYWpl1IN3Qm98MsB8q", Name = "__slot_IrsddYWpl1IN3Qm98MsB8q")]
        public byte[] __slot_IrsddYWpl1IN3Qm98MsB8q;
        [n1.ElementAttribute(TracingId = 246272U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "QX6cBxxBbG8O53Z7jSJqjB", Name = "__slot_QX6cBxxBbG8O53Z7jSJqjB")]
        public n51.Subject<byte[]> __slot_QX6cBxxBbG8O53Z7jSJqjB;
        [n1.ElementAttribute(TracingId = 246314U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Kcz9xpEc0SXLZJuHUYODoD", Name = "__slot_Kcz9xpEc0SXLZJuHUYODoD")]
        public n29.SerialPort __slot_Kcz9xpEc0SXLZJuHUYODoD;
        [n1.ElementAttribute(TracingId = 245480U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "GMAuwT8aAwcMc80EaVsP13", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n28.ComPort, int, n29.Parity, int, n29.StopBits, n29.Handshake, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n29.SerialPort>> __cache_GMAuwT8aAwcMc80EaVsP13 = null;
        [n1.ElementAttribute(TracingId = 245679U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "R00VttHKpBkLet0r9e2wqq", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_R00VttHKpBkLet0r9e2wqq;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_HewgCOWktfXQBVhXrdNF3j;
        [n1.ElementAttribute(TracingId = 246245U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Ive7wBG2kTUM75ZIWBIv2I", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n17.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_Ive7wBG2kTUM75ZIWBIv2I;
        static SerialPort3_C()
        {
        }

        public SerialPort3_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SerialPort3_C(SerialPort3_C other): base(other)
        {
            this.__slot_Di9VN1hG2KFQOz63llNIZr = other.__slot_Di9VN1hG2KFQOz63llNIZr;
            this.__slot_IrsddYWpl1IN3Qm98MsB8q = other.__slot_IrsddYWpl1IN3Qm98MsB8q;
            this.__slot_QX6cBxxBbG8O53Z7jSJqjB = other.__slot_QX6cBxxBbG8O53Z7jSJqjB;
            this.__slot_Kcz9xpEc0SXLZJuHUYODoD = other.__slot_Kcz9xpEc0SXLZJuHUYODoD;
            this.__cache_GMAuwT8aAwcMc80EaVsP13 = other.__cache_GMAuwT8aAwcMc80EaVsP13;
            this.__p_R00VttHKpBkLet0r9e2wqq = other.__p_R00VttHKpBkLet0r9e2wqq;
            this.__if_HewgCOWktfXQBVhXrdNF3j = other.__if_HewgCOWktfXQBVhXrdNF3j;
            this.__p_Ive7wBG2kTUM75ZIWBIv2I = other.__p_Ive7wBG2kTUM75ZIWBIv2I;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Di9VN1hG2KFQOz63llNIZr", in __slot_Di9VN1hG2KFQOz63llNIZr), n1.CompilationHelper.GetValueOrExisting(values, "__slot_IrsddYWpl1IN3Qm98MsB8q", in __slot_IrsddYWpl1IN3Qm98MsB8q), n1.CompilationHelper.GetValueOrExisting(values, "__slot_QX6cBxxBbG8O53Z7jSJqjB", in __slot_QX6cBxxBbG8O53Z7jSJqjB), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Kcz9xpEc0SXLZJuHUYODoD", in __slot_Kcz9xpEc0SXLZJuHUYODoD), n1.CompilationHelper.GetValueOrExisting(values, "__cache_GMAuwT8aAwcMc80EaVsP13", in __cache_GMAuwT8aAwcMc80EaVsP13), n1.CompilationHelper.GetValueOrExisting(values, "__p_R00VttHKpBkLet0r9e2wqq", in __p_R00VttHKpBkLet0r9e2wqq), n1.CompilationHelper.GetValueOrExisting(values, "__if_HewgCOWktfXQBVhXrdNF3j", in __if_HewgCOWktfXQBVhXrdNF3j), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ive7wBG2kTUM75ZIWBIv2I", in __p_Ive7wBG2kTUM75ZIWBIv2I));
        }

        internal SerialPort3_C __WITH__(bool __slot_Di9VN1hG2KFQOz63llNIZr, byte[] __slot_IrsddYWpl1IN3Qm98MsB8q, n51.Subject<byte[]> __slot_QX6cBxxBbG8O53Z7jSJqjB, n29.SerialPort __slot_Kcz9xpEc0SXLZJuHUYODoD, n19.Manager<n2.ValueTuple<n28.ComPort, int, n29.Parity, int, n29.StopBits, n29.Handshake, bool, n2.ValueTuple<bool>>, n2.ValueTuple<n29.SerialPort>> __cache_GMAuwT8aAwcMc80EaVsP13, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_R00VttHKpBkLet0r9e2wqq, n2.Object __if_HewgCOWktfXQBVhXrdNF3j, n17.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_Ive7wBG2kTUM75ZIWBIv2I)
        {
            n30.SerialPort3_C that_0 = this;
            this.__slot_Di9VN1hG2KFQOz63llNIZr = __slot_Di9VN1hG2KFQOz63llNIZr;
            this.__slot_IrsddYWpl1IN3Qm98MsB8q = __slot_IrsddYWpl1IN3Qm98MsB8q;
            this.__slot_QX6cBxxBbG8O53Z7jSJqjB = __slot_QX6cBxxBbG8O53Z7jSJqjB;
            this.__slot_Kcz9xpEc0SXLZJuHUYODoD = __slot_Kcz9xpEc0SXLZJuHUYODoD;
            this.__cache_GMAuwT8aAwcMc80EaVsP13 = __cache_GMAuwT8aAwcMc80EaVsP13;
            this.__p_R00VttHKpBkLet0r9e2wqq = __p_R00VttHKpBkLet0r9e2wqq;
            this.__if_HewgCOWktfXQBVhXrdNF3j = __if_HewgCOWktfXQBVhXrdNF3j;
            this.__p_Ive7wBG2kTUM75ZIWBIv2I = __p_Ive7wBG2kTUM75ZIWBIv2I;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "OHC0UwH5OvGLimkPX2pRKV", Name = "__OHC0UwH5OvGLimkPX2pRKV")]
        [n2.SerializableAttribute]
        public class __OHC0UwH5OvGLimkPX2pRKV : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UNSUNfqZWweLaMfk7dsgqv);
                n1.CompilationHelper.SafeDispose(this.__customRegion_UNSUNfqZWweLaMfk7dsgqv);
                return;
            }

            [n1.ElementAttribute(TracingId = 245543U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "UNSUNfqZWweLaMfk7dsgqv", Name = "Try", IsManaged = true, IsAutoGenerated = true)]
            public n17.Try_NXr6u6gowSzLvQTfp53h2q __p_UNSUNfqZWweLaMfk7dsgqv;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n60.CustomRegion __customRegion_UNSUNfqZWweLaMfk7dsgqv;
            public __OHC0UwH5OvGLimkPX2pRKV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OHC0UwH5OvGLimkPX2pRKV(__OHC0UwH5OvGLimkPX2pRKV other): base(other)
            {
                this.__p_UNSUNfqZWweLaMfk7dsgqv = other.__p_UNSUNfqZWweLaMfk7dsgqv;
                this.__customRegion_UNSUNfqZWweLaMfk7dsgqv = other.__customRegion_UNSUNfqZWweLaMfk7dsgqv;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UNSUNfqZWweLaMfk7dsgqv", in __p_UNSUNfqZWweLaMfk7dsgqv), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_UNSUNfqZWweLaMfk7dsgqv", in __customRegion_UNSUNfqZWweLaMfk7dsgqv));
            }

            internal __OHC0UwH5OvGLimkPX2pRKV __WITH__(n17.Try_NXr6u6gowSzLvQTfp53h2q __p_UNSUNfqZWweLaMfk7dsgqv, n60.CustomRegion __customRegion_UNSUNfqZWweLaMfk7dsgqv)
            {
                __OHC0UwH5OvGLimkPX2pRKV that_0 = this;
                this.__p_UNSUNfqZWweLaMfk7dsgqv = __p_UNSUNfqZWweLaMfk7dsgqv;
                this.__customRegion_UNSUNfqZWweLaMfk7dsgqv = __customRegion_UNSUNfqZWweLaMfk7dsgqv;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CMZ401nMc7gL6AZSmJdnFJ", Name = "__CMZ401nMc7gL6AZSmJdnFJ")]
        [n2.SerializableAttribute]
        public class __CMZ401nMc7gL6AZSmJdnFJ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __CMZ401nMc7gL6AZSmJdnFJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CMZ401nMc7gL6AZSmJdnFJ(__CMZ401nMc7gL6AZSmJdnFJ other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __CMZ401nMc7gL6AZSmJdnFJ __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "UZ74g1vBdCMQT4pJzzChBo", Name = "__UZ74g1vBdCMQT4pJzzChBo")]
        [n2.SerializableAttribute]
        public class __UZ74g1vBdCMQT4pJzzChBo : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IHpoIbV5nzuLXnaj2BY6Q6);
                n1.CompilationHelper.SafeDispose(this.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6);
                return;
            }

            [n1.ElementAttribute(TracingId = 245732U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IHpoIbV5nzuLXnaj2BY6Q6", Name = "Try", IsManaged = true, IsAutoGenerated = true)]
            public n17.Try_NXr6u6gowSzLvQTfp53h2q __p_IHpoIbV5nzuLXnaj2BY6Q6;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n60.CustomRegion __customRegion_IHpoIbV5nzuLXnaj2BY6Q6;
            public __UZ74g1vBdCMQT4pJzzChBo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UZ74g1vBdCMQT4pJzzChBo(__UZ74g1vBdCMQT4pJzzChBo other): base(other)
            {
                this.__p_IHpoIbV5nzuLXnaj2BY6Q6 = other.__p_IHpoIbV5nzuLXnaj2BY6Q6;
                this.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6 = other.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IHpoIbV5nzuLXnaj2BY6Q6", in __p_IHpoIbV5nzuLXnaj2BY6Q6), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_IHpoIbV5nzuLXnaj2BY6Q6", in __customRegion_IHpoIbV5nzuLXnaj2BY6Q6));
            }

            internal __UZ74g1vBdCMQT4pJzzChBo __WITH__(n17.Try_NXr6u6gowSzLvQTfp53h2q __p_IHpoIbV5nzuLXnaj2BY6Q6, n60.CustomRegion __customRegion_IHpoIbV5nzuLXnaj2BY6Q6)
            {
                __UZ74g1vBdCMQT4pJzzChBo that_0 = this;
                this.__p_IHpoIbV5nzuLXnaj2BY6Q6 = __p_IHpoIbV5nzuLXnaj2BY6Q6;
                this.__customRegion_IHpoIbV5nzuLXnaj2BY6Q6 = __customRegion_IHpoIbV5nzuLXnaj2BY6Q6;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ATx64oHGI9bMKQytyaDeF4", Name = "__ATx64oHGI9bMKQytyaDeF4")]
        [n2.SerializableAttribute]
        public class __ATx64oHGI9bMKQytyaDeF4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __ATx64oHGI9bMKQytyaDeF4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ATx64oHGI9bMKQytyaDeF4(__ATx64oHGI9bMKQytyaDeF4 other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __ATx64oHGI9bMKQytyaDeF4 __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 246692U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "EtyioAuoHGbOGm6NgPCyAL", Name = "VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL")]
    [n2.SerializableAttribute]
    public class VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL CreateDefault()
        {
            var instance = new VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL Update()
        {
            return this;
        }

        public n30.VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n30.VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL __CreateDefault__()
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

        public VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL(VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_CoreLib_IOApplication_EtyioAuoHGbOGm6NgPCyAL __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Obsolete
{
    [n1.ElementAttribute(TracingId = 237710U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IjerHItQqY4PCwNKtTBHV2", Name = "FileReader__1_IjerHItQqY4PCwNKtTBHV2")]
    [n2.SerializableAttribute]
    public class FileReader__1_IjerHItQqY4PCwNKtTBHV2 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader__1_IjerHItQqY4PCwNKtTBHV2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 CreateDefault()
        {
            var instance = new FileReader__1_IjerHItQqY4PCwNKtTBHV2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 Update(n37.Path File_Path_In, bool Read_In, out n12.Spread<byte> Data_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode __pad_G09SlxdXBUwOcnmc3e0bsm_0 = __slot_G09SlxdXBUwOcnmc3e0bsm;
            n8.FileAccess __pad_RybqkVh1UVVNUCw4mIoHD0_1 = __slot_RybqkVh1UVVNUCw4mIoHD0;
            n8.FileShare File_Share_2 = __c_HAD5lbJOWzaM3CtV82npi7;
            n68.ObsoleteFileNoSharing Input_3 = this.__p_A6lZlZZYaKDOqvbap4SHfk;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: __pad_G09SlxdXBUwOcnmc3e0bsm_0, fileAccess: __pad_RybqkVh1UVVNUCw4mIoHD0_1, fileShare: File_Share_2);
            long Offset_5 = 0L;
            bool Abort_6 = false;
            var Output_11 = this.__p_CFG1IZ0I6ITPGAL6Q00ELf.Update(Input_In: Result_4, Offset_In: Offset_5, Read_In: Read_In, Abort_In: Abort_6, Result_Out: out n9.IResourceProvider<n8.Stream> Result_7, Data_Out: out n12.Spread<byte> Data_8, Progress_Out: out float Progress_9, In_Progress_Out: out bool In_Progress_10);
            var Output_14 = this.__p_RPfC3bLzlJMNAzsrk1jcJk.Update(Value_In: In_Progress_10, Up_Edge_Out: out bool Up_Edge_12, Down_Edge_Out: out bool Down_Edge_13);
            Data_Out = Data_8;
            Progress_Out = Progress_9;
            In_Progress_Out = In_Progress_10;
            On_Completed_Out = Down_Edge_13;
            n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Input_3 != this.__p_A6lZlZZYaKDOqvbap4SHfk || Output_11 != this.__p_CFG1IZ0I6ITPGAL6Q00ELf || Output_14 != this.__p_RPfC3bLzlJMNAzsrk1jcJk ? new FileReader__1_IjerHItQqY4PCwNKtTBHV2(this)
                {__p_A6lZlZZYaKDOqvbap4SHfk = Input_3, __p_CFG1IZ0I6ITPGAL6Q00ELf = Output_11, __p_RPfC3bLzlJMNAzsrk1jcJk = Output_14} : that_15;
            else
            {
                this.__p_A6lZlZZYaKDOqvbap4SHfk = Input_3;
                this.__p_CFG1IZ0I6ITPGAL6Q00ELf = Output_11;
                this.__p_RPfC3bLzlJMNAzsrk1jcJk = Output_14;
            }

            return that_15;
        }

        public n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "A6lZlZZYaKDOqvbap4SHfk", 237715U);
            n70.IFrameClock Clock_1 = n69._Operations_.CreateDefault();
            n71._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n68.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "CFG1IZ0I6ITPGAL6Q00ELf", 237732U);
            var Output_4 = n72.ReaderAll_I0f0g5bpDcwM7IvfNlL1lC.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "RPfC3bLzlJMNAzsrk1jcJk", 237757U);
            var Output_6 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_5);
            n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 that_7 = this;
            this.__p_A6lZlZZYaKDOqvbap4SHfk = Output_2;
            this.__p_CFG1IZ0I6ITPGAL6Q00ELf = Output_4;
            this.__p_RPfC3bLzlJMNAzsrk1jcJk = Output_6;
            return that_7;
        }

        public n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 __CreateDefault__()
        {
            n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 that_0 = this;
            this.__p_A6lZlZZYaKDOqvbap4SHfk = default(n68.ObsoleteFileNoSharing);
            this.__p_CFG1IZ0I6ITPGAL6Q00ELf = n72.ReaderAll_I0f0g5bpDcwM7IvfNlL1lC.CreateDefault();
            this.__p_RPfC3bLzlJMNAzsrk1jcJk = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_A6lZlZZYaKDOqvbap4SHfk);
            n1.CompilationHelper.SafeDispose(this.__p_CFG1IZ0I6ITPGAL6Q00ELf);
            n1.CompilationHelper.SafeDispose(this.__p_RPfC3bLzlJMNAzsrk1jcJk);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 237725U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "G09SlxdXBUwOcnmc3e0bsm", Name = "__slot_G09SlxdXBUwOcnmc3e0bsm")]
        public static n8.FileMode __slot_G09SlxdXBUwOcnmc3e0bsm = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "G09SlxdXBUwOcnmc3e0bsm");
        [n1.ElementAttribute(TracingId = 237729U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RybqkVh1UVVNUCw4mIoHD0", Name = "__slot_RybqkVh1UVVNUCw4mIoHD0")]
        public static n8.FileAccess __slot_RybqkVh1UVVNUCw4mIoHD0 = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "RybqkVh1UVVNUCw4mIoHD0");
        [n1.ElementAttribute(TracingId = 237715U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "A6lZlZZYaKDOqvbap4SHfk", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n68.ObsoleteFileNoSharing __p_A6lZlZZYaKDOqvbap4SHfk;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_HAD5lbJOWzaM3CtV82npi7 = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "HAD5lbJOWzaM3CtV82npi7");
        [n1.ElementAttribute(TracingId = 237732U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CFG1IZ0I6ITPGAL6Q00ELf", Name = "ReaderAll", IsManaged = true, IsAutoGenerated = true)]
        public n72.ReaderAll_I0f0g5bpDcwM7IvfNlL1lC __p_CFG1IZ0I6ITPGAL6Q00ELf;
        [n1.ElementAttribute(TracingId = 237757U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RPfC3bLzlJMNAzsrk1jcJk", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_RPfC3bLzlJMNAzsrk1jcJk;
        static FileReader__1_IjerHItQqY4PCwNKtTBHV2()
        {
        }

        public FileReader__1_IjerHItQqY4PCwNKtTBHV2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader__1_IjerHItQqY4PCwNKtTBHV2(FileReader__1_IjerHItQqY4PCwNKtTBHV2 other): base(other)
        {
            this.__p_A6lZlZZYaKDOqvbap4SHfk = other.__p_A6lZlZZYaKDOqvbap4SHfk;
            this.__p_CFG1IZ0I6ITPGAL6Q00ELf = other.__p_CFG1IZ0I6ITPGAL6Q00ELf;
            this.__p_RPfC3bLzlJMNAzsrk1jcJk = other.__p_RPfC3bLzlJMNAzsrk1jcJk;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_A6lZlZZYaKDOqvbap4SHfk", in __p_A6lZlZZYaKDOqvbap4SHfk), n1.CompilationHelper.GetValueOrExisting(values, "__p_CFG1IZ0I6ITPGAL6Q00ELf", in __p_CFG1IZ0I6ITPGAL6Q00ELf), n1.CompilationHelper.GetValueOrExisting(values, "__p_RPfC3bLzlJMNAzsrk1jcJk", in __p_RPfC3bLzlJMNAzsrk1jcJk));
        }

        internal FileReader__1_IjerHItQqY4PCwNKtTBHV2 __WITH__(n68.ObsoleteFileNoSharing __p_A6lZlZZYaKDOqvbap4SHfk, n72.ReaderAll_I0f0g5bpDcwM7IvfNlL1lC __p_CFG1IZ0I6ITPGAL6Q00ELf, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_RPfC3bLzlJMNAzsrk1jcJk)
        {
            n67.FileReader__1_IjerHItQqY4PCwNKtTBHV2 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_A6lZlZZYaKDOqvbap4SHfk != this.__p_A6lZlZZYaKDOqvbap4SHfk || __p_CFG1IZ0I6ITPGAL6Q00ELf != this.__p_CFG1IZ0I6ITPGAL6Q00ELf || __p_RPfC3bLzlJMNAzsrk1jcJk != this.__p_RPfC3bLzlJMNAzsrk1jcJk ? new FileReader__1_IjerHItQqY4PCwNKtTBHV2(this)
                {__p_A6lZlZZYaKDOqvbap4SHfk = __p_A6lZlZZYaKDOqvbap4SHfk, __p_CFG1IZ0I6ITPGAL6Q00ELf = __p_CFG1IZ0I6ITPGAL6Q00ELf, __p_RPfC3bLzlJMNAzsrk1jcJk = __p_RPfC3bLzlJMNAzsrk1jcJk} : that_0;
            else
            {
                this.__p_A6lZlZZYaKDOqvbap4SHfk = __p_A6lZlZZYaKDOqvbap4SHfk;
                this.__p_CFG1IZ0I6ITPGAL6Q00ELf = __p_CFG1IZ0I6ITPGAL6Q00ELf;
                this.__p_RPfC3bLzlJMNAzsrk1jcJk = __p_RPfC3bLzlJMNAzsrk1jcJk;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 237806U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "FlSWv1BZxAXQcA8WA0GZhK", Name = "FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK")]
    [n2.SerializableAttribute]
    public class FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK CreateDefault()
        {
            var instance = new FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK Update(n37.Path File_Path_In, n11.Encodings Encoding_In, bool Read_In, out string Data_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileMode __pad_Es5NkloquzrLu5ak0UqrXP_0 = __slot_Es5NkloquzrLu5ak0UqrXP;
            n8.FileAccess __pad_DsbMsXfmYEXPtgJbv9lrB5_1 = __slot_DsbMsXfmYEXPtgJbv9lrB5;
            n8.FileShare File_Share_2 = __c_UWilFieTkMAMaNy59I7PwI;
            n68.ObsoleteFileNoSharing Input_3 = this.__p_BVL2I3txXCDMCj8GKmjLLJ;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: __pad_Es5NkloquzrLu5ak0UqrXP_0, fileAccess: __pad_DsbMsXfmYEXPtgJbv9lrB5_1, fileShare: File_Share_2);
            long Offset_5 = 0L;
            bool Abort_6 = false;
            n7.ReaderString Input__this__7 = this.__p_AGD3Y8fsppfMO65qQI30Mk;
            var Result_11 = Input__this__7.ReadAllString(input: Result_4, encoding: Encoding_In, offset: Offset_5, read: Read_In, abort: Abort_6, progress: out float Progress_8, inProgress: out bool In_Progress_9, data: out string Data_10);
            var Output_14 = this.__p_FR8ra9zFYWpPmXgyDAeVDV.Update(Value_In: In_Progress_9, Up_Edge_Out: out bool Up_Edge_12, Down_Edge_Out: out bool Down_Edge_13);
            Data_Out = Data_10;
            Progress_Out = Progress_8;
            In_Progress_Out = In_Progress_9;
            On_Completed_Out = Down_Edge_13;
            n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Input_3 != this.__p_BVL2I3txXCDMCj8GKmjLLJ || Input__this__7 != this.__p_AGD3Y8fsppfMO65qQI30Mk || Output_14 != this.__p_FR8ra9zFYWpPmXgyDAeVDV ? new FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(this)
                {__p_BVL2I3txXCDMCj8GKmjLLJ = Input_3, __p_AGD3Y8fsppfMO65qQI30Mk = Input__this__7, __p_FR8ra9zFYWpPmXgyDAeVDV = Output_14} : that_15;
            else
            {
                this.__p_BVL2I3txXCDMCj8GKmjLLJ = Input_3;
                this.__p_AGD3Y8fsppfMO65qQI30Mk = Input__this__7;
                this.__p_FR8ra9zFYWpPmXgyDAeVDV = Output_14;
            }

            return that_15;
        }

        public n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "BVL2I3txXCDMCj8GKmjLLJ", 237810U);
            n70.IFrameClock Clock_1 = n69._Operations_.CreateDefault();
            n71._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n68.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "AGD3Y8fsppfMO65qQI30Mk", 237818U);
            n73._Operations_.Create(Node_Context: Node_Context_3, Output_Out: out n7.ReaderString Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "FR8ra9zFYWpPmXgyDAeVDV", 237829U);
            var Output_6 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_5);
            n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK that_7 = this;
            this.__p_BVL2I3txXCDMCj8GKmjLLJ = Output_2;
            this.__p_AGD3Y8fsppfMO65qQI30Mk = Output_4;
            this.__p_FR8ra9zFYWpPmXgyDAeVDV = Output_6;
            return that_7;
        }

        public n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK __CreateDefault__()
        {
            n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK that_0 = this;
            this.__p_BVL2I3txXCDMCj8GKmjLLJ = default(n68.ObsoleteFileNoSharing);
            this.__p_AGD3Y8fsppfMO65qQI30Mk = default(n7.ReaderString);
            this.__p_FR8ra9zFYWpPmXgyDAeVDV = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BVL2I3txXCDMCj8GKmjLLJ);
            n1.CompilationHelper.SafeDispose(this.__p_AGD3Y8fsppfMO65qQI30Mk);
            n1.CompilationHelper.SafeDispose(this.__p_FR8ra9zFYWpPmXgyDAeVDV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 237816U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Es5NkloquzrLu5ak0UqrXP", Name = "__slot_Es5NkloquzrLu5ak0UqrXP")]
        public static n8.FileMode __slot_Es5NkloquzrLu5ak0UqrXP = n1.CompilationHelper.Deserialize<n8.FileMode>("Open", false, "PcdEIeqrXeZQCL5lc35ctR", "Es5NkloquzrLu5ak0UqrXP");
        [n1.ElementAttribute(TracingId = 237817U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "DsbMsXfmYEXPtgJbv9lrB5", Name = "__slot_DsbMsXfmYEXPtgJbv9lrB5")]
        public static n8.FileAccess __slot_DsbMsXfmYEXPtgJbv9lrB5 = n1.CompilationHelper.Deserialize<n8.FileAccess>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "DsbMsXfmYEXPtgJbv9lrB5");
        [n1.ElementAttribute(TracingId = 237810U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BVL2I3txXCDMCj8GKmjLLJ", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n68.ObsoleteFileNoSharing __p_BVL2I3txXCDMCj8GKmjLLJ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_UWilFieTkMAMaNy59I7PwI = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "UWilFieTkMAMaNy59I7PwI");
        [n1.ElementAttribute(TracingId = 237818U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AGD3Y8fsppfMO65qQI30Mk", Name = "ReaderAll", IsManaged = true, IsAutoGenerated = true)]
        public n7.ReaderString __p_AGD3Y8fsppfMO65qQI30Mk;
        [n1.ElementAttribute(TracingId = 237829U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "FR8ra9zFYWpPmXgyDAeVDV", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FR8ra9zFYWpPmXgyDAeVDV;
        static FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK()
        {
        }

        public FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK other): base(other)
        {
            this.__p_BVL2I3txXCDMCj8GKmjLLJ = other.__p_BVL2I3txXCDMCj8GKmjLLJ;
            this.__p_AGD3Y8fsppfMO65qQI30Mk = other.__p_AGD3Y8fsppfMO65qQI30Mk;
            this.__p_FR8ra9zFYWpPmXgyDAeVDV = other.__p_FR8ra9zFYWpPmXgyDAeVDV;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BVL2I3txXCDMCj8GKmjLLJ", in __p_BVL2I3txXCDMCj8GKmjLLJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_AGD3Y8fsppfMO65qQI30Mk", in __p_AGD3Y8fsppfMO65qQI30Mk), n1.CompilationHelper.GetValueOrExisting(values, "__p_FR8ra9zFYWpPmXgyDAeVDV", in __p_FR8ra9zFYWpPmXgyDAeVDV));
        }

        internal FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK __WITH__(n68.ObsoleteFileNoSharing __p_BVL2I3txXCDMCj8GKmjLLJ, n7.ReaderString __p_AGD3Y8fsppfMO65qQI30Mk, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FR8ra9zFYWpPmXgyDAeVDV)
        {
            n67.FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BVL2I3txXCDMCj8GKmjLLJ != this.__p_BVL2I3txXCDMCj8GKmjLLJ || __p_AGD3Y8fsppfMO65qQI30Mk != this.__p_AGD3Y8fsppfMO65qQI30Mk || __p_FR8ra9zFYWpPmXgyDAeVDV != this.__p_FR8ra9zFYWpPmXgyDAeVDV ? new FileReader_String_1_FlSWv1BZxAXQcA8WA0GZhK(this)
                {__p_BVL2I3txXCDMCj8GKmjLLJ = __p_BVL2I3txXCDMCj8GKmjLLJ, __p_AGD3Y8fsppfMO65qQI30Mk = __p_AGD3Y8fsppfMO65qQI30Mk, __p_FR8ra9zFYWpPmXgyDAeVDV = __p_FR8ra9zFYWpPmXgyDAeVDV} : that_0;
            else
            {
                this.__p_BVL2I3txXCDMCj8GKmjLLJ = __p_BVL2I3txXCDMCj8GKmjLLJ;
                this.__p_AGD3Y8fsppfMO65qQI30Mk = __p_AGD3Y8fsppfMO65qQI30Mk;
                this.__p_FR8ra9zFYWpPmXgyDAeVDV = __p_FR8ra9zFYWpPmXgyDAeVDV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 237873U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "R7mOvMTuwndMvNCG0IO3Dv", Name = "FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv")]
    [n2.SerializableAttribute]
    public class FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv CreateDefault()
        {
            var instance = new FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv Update(n37.Path File_Path_In, n11.Encodings Encoding_In, string Data_In, bool Append_In, bool Write_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileAccess __pad_L1KMsybVy4lP7dNSPUPBh0_0 = __slot_L1KMsybVy4lP7dNSPUPBh0;
            n8.FileMode __pad_ShTg0rV3wR3NSQn3tVpYbR_1 = __slot_ShTg0rV3wR3NSQn3tVpYbR;
            n8.FileMode __pad_IBcDTS0CIUgQEbBcDGFIYL_2 = __slot_IBcDTS0CIUgQEbBcDGFIYL;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_ShTg0rV3wR3NSQn3tVpYbR_1, Input_2_In: __pad_IBcDTS0CIUgQEbBcDGFIYL_2, Output_Out: out n8.FileMode Output_3);
            n8.FileShare File_Share_4 = __c_HpX6fwXR44qNCbBedoC83I;
            n68.ObsoleteFileNoSharing Input_5 = this.__p_EfEzg57VYzeQaNayX8jLLd;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_3, fileAccess: __pad_L1KMsybVy4lP7dNSPUPBh0_0, fileShare: File_Share_4);
            long Offset_7 = 0L;
            bool Abort_8 = false;
            var Output_11 = this.__p_RGpKkEFAE3ZPPxPfbBA3FX.Update(Input_In: Result_6, Encoding_In: Encoding_In, Data_In: Data_In, Offset_In: Offset_7, Write_In: Write_In, Abort_In: Abort_8, Progress_Out: out float Progress_9, In_Progress_Out: out bool In_Progress_10);
            var Output_14 = this.__p_L9nWPnEeyqpO7343kxVOlh.Update(Value_In: In_Progress_10, Up_Edge_Out: out bool Up_Edge_12, Down_Edge_Out: out bool Down_Edge_13);
            Progress_Out = Progress_9;
            In_Progress_Out = In_Progress_10;
            On_Completed_Out = Down_Edge_13;
            n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Input_5 != this.__p_EfEzg57VYzeQaNayX8jLLd || Output_11 != this.__p_RGpKkEFAE3ZPPxPfbBA3FX || Output_14 != this.__p_L9nWPnEeyqpO7343kxVOlh ? new FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(this)
                {__p_EfEzg57VYzeQaNayX8jLLd = Input_5, __p_RGpKkEFAE3ZPPxPfbBA3FX = Output_11, __p_L9nWPnEeyqpO7343kxVOlh = Output_14} : that_15;
            else
            {
                this.__p_EfEzg57VYzeQaNayX8jLLd = Input_5;
                this.__p_RGpKkEFAE3ZPPxPfbBA3FX = Output_11;
                this.__p_L9nWPnEeyqpO7343kxVOlh = Output_14;
            }

            return that_15;
        }

        public n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "EfEzg57VYzeQaNayX8jLLd", 237878U);
            n70.IFrameClock Clock_1 = n69._Operations_.CreateDefault();
            n71._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n68.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "RGpKkEFAE3ZPPxPfbBA3FX", 237892U);
            var Output_4 = n72.Writer_String_KdneNV6fZfcMTOqz2tJw5z.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "L9nWPnEeyqpO7343kxVOlh", 237909U);
            var Output_6 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_5);
            n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv that_7 = this;
            this.__p_EfEzg57VYzeQaNayX8jLLd = Output_2;
            this.__p_RGpKkEFAE3ZPPxPfbBA3FX = Output_4;
            this.__p_L9nWPnEeyqpO7343kxVOlh = Output_6;
            return that_7;
        }

        public n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv __CreateDefault__()
        {
            n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv that_0 = this;
            this.__p_EfEzg57VYzeQaNayX8jLLd = default(n68.ObsoleteFileNoSharing);
            this.__p_RGpKkEFAE3ZPPxPfbBA3FX = n72.Writer_String_KdneNV6fZfcMTOqz2tJw5z.CreateDefault();
            this.__p_L9nWPnEeyqpO7343kxVOlh = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EfEzg57VYzeQaNayX8jLLd);
            n1.CompilationHelper.SafeDispose(this.__p_RGpKkEFAE3ZPPxPfbBA3FX);
            n1.CompilationHelper.SafeDispose(this.__p_L9nWPnEeyqpO7343kxVOlh);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 237889U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "L1KMsybVy4lP7dNSPUPBh0", Name = "__slot_L1KMsybVy4lP7dNSPUPBh0")]
        public static n8.FileAccess __slot_L1KMsybVy4lP7dNSPUPBh0 = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "L1KMsybVy4lP7dNSPUPBh0");
        [n1.ElementAttribute(TracingId = 237922U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IBcDTS0CIUgQEbBcDGFIYL", Name = "__slot_IBcDTS0CIUgQEbBcDGFIYL")]
        public static n8.FileMode __slot_IBcDTS0CIUgQEbBcDGFIYL = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "IBcDTS0CIUgQEbBcDGFIYL");
        [n1.ElementAttribute(TracingId = 237937U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ShTg0rV3wR3NSQn3tVpYbR", Name = "__slot_ShTg0rV3wR3NSQn3tVpYbR")]
        public static n8.FileMode __slot_ShTg0rV3wR3NSQn3tVpYbR = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "ShTg0rV3wR3NSQn3tVpYbR");
        [n1.ElementAttribute(TracingId = 237878U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "EfEzg57VYzeQaNayX8jLLd", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n68.ObsoleteFileNoSharing __p_EfEzg57VYzeQaNayX8jLLd;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_HpX6fwXR44qNCbBedoC83I = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "HpX6fwXR44qNCbBedoC83I");
        [n1.ElementAttribute(TracingId = 237892U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RGpKkEFAE3ZPPxPfbBA3FX", Name = "Writer (String)", IsManaged = true, IsAutoGenerated = true)]
        public n72.Writer_String_KdneNV6fZfcMTOqz2tJw5z __p_RGpKkEFAE3ZPPxPfbBA3FX;
        [n1.ElementAttribute(TracingId = 237909U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "L9nWPnEeyqpO7343kxVOlh", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_L9nWPnEeyqpO7343kxVOlh;
        static FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv()
        {
        }

        public FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv other): base(other)
        {
            this.__p_EfEzg57VYzeQaNayX8jLLd = other.__p_EfEzg57VYzeQaNayX8jLLd;
            this.__p_RGpKkEFAE3ZPPxPfbBA3FX = other.__p_RGpKkEFAE3ZPPxPfbBA3FX;
            this.__p_L9nWPnEeyqpO7343kxVOlh = other.__p_L9nWPnEeyqpO7343kxVOlh;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EfEzg57VYzeQaNayX8jLLd", in __p_EfEzg57VYzeQaNayX8jLLd), n1.CompilationHelper.GetValueOrExisting(values, "__p_RGpKkEFAE3ZPPxPfbBA3FX", in __p_RGpKkEFAE3ZPPxPfbBA3FX), n1.CompilationHelper.GetValueOrExisting(values, "__p_L9nWPnEeyqpO7343kxVOlh", in __p_L9nWPnEeyqpO7343kxVOlh));
        }

        internal FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv __WITH__(n68.ObsoleteFileNoSharing __p_EfEzg57VYzeQaNayX8jLLd, n72.Writer_String_KdneNV6fZfcMTOqz2tJw5z __p_RGpKkEFAE3ZPPxPfbBA3FX, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_L9nWPnEeyqpO7343kxVOlh)
        {
            n67.FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_EfEzg57VYzeQaNayX8jLLd != this.__p_EfEzg57VYzeQaNayX8jLLd || __p_RGpKkEFAE3ZPPxPfbBA3FX != this.__p_RGpKkEFAE3ZPPxPfbBA3FX || __p_L9nWPnEeyqpO7343kxVOlh != this.__p_L9nWPnEeyqpO7343kxVOlh ? new FileWriter_String_1_R7mOvMTuwndMvNCG0IO3Dv(this)
                {__p_EfEzg57VYzeQaNayX8jLLd = __p_EfEzg57VYzeQaNayX8jLLd, __p_RGpKkEFAE3ZPPxPfbBA3FX = __p_RGpKkEFAE3ZPPxPfbBA3FX, __p_L9nWPnEeyqpO7343kxVOlh = __p_L9nWPnEeyqpO7343kxVOlh} : that_0;
            else
            {
                this.__p_EfEzg57VYzeQaNayX8jLLd = __p_EfEzg57VYzeQaNayX8jLLd;
                this.__p_RGpKkEFAE3ZPPxPfbBA3FX = __p_RGpKkEFAE3ZPPxPfbBA3FX;
                this.__p_L9nWPnEeyqpO7343kxVOlh = __p_L9nWPnEeyqpO7343kxVOlh;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 237997U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "J7vmTTktovMOYBUQelwW3O", Name = "FileWriter__1_J7vmTTktovMOYBUQelwW3O")]
    [n2.SerializableAttribute]
    public class FileWriter__1_J7vmTTktovMOYBUQelwW3O : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter__1_J7vmTTktovMOYBUQelwW3O(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O CreateDefault()
        {
            var instance = new FileWriter__1_J7vmTTktovMOYBUQelwW3O(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O Update(n37.Path File_Path_In, n12.Spread<byte> Data_In, bool Append_In, bool Write_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n8.FileAccess __pad_SYPA42Pgme3QMlTnT6kKTL_0 = __slot_SYPA42Pgme3QMlTnT6kKTL;
            n8.FileMode __pad_CkXExCY454WQaaxPdWsOnq_1 = __slot_CkXExCY454WQaaxPdWsOnq;
            n8.FileMode __pad_SwxOdQ3MquzL6kX83tIF3J_2 = __slot_SwxOdQ3MquzL6kX83tIF3J;
            n20._Operations_.Switch_Boolean<n8.FileMode>(Condition_In: Append_In, Input_In: __pad_CkXExCY454WQaaxPdWsOnq_1, Input_2_In: __pad_SwxOdQ3MquzL6kX83tIF3J_2, Output_Out: out n8.FileMode Output_3);
            n8.FileShare File_Share_4 = __c_GZ6sC9fpDj7MLlRUsouVA9;
            n68.ObsoleteFileNoSharing Input_5 = this.__p_IGGficrUmVOLnTcZbdRsPU;
            var Result_6 = Input_5.Update(filePath: File_Path_In, fileMode: Output_3, fileAccess: __pad_SYPA42Pgme3QMlTnT6kKTL_0, fileShare: File_Share_4);
            long Offset_7 = 0L;
            bool Abort_8 = false;
            var Output_11 = this.__p_Lm8GjVVahpuO01tBZKWGe0.Update(Input_In: Result_6, Data_In: Data_In, Offset_In: Offset_7, Write_In: Write_In, Abort_In: Abort_8, Progress_Out: out float Progress_9, In_Progress_Out: out bool In_Progress_10);
            var Output_14 = this.__p_CCRWtWEhtw5NwurUPWneQm.Update(Value_In: In_Progress_10, Up_Edge_Out: out bool Up_Edge_12, Down_Edge_Out: out bool Down_Edge_13);
            Progress_Out = Progress_9;
            In_Progress_Out = In_Progress_10;
            On_Completed_Out = Down_Edge_13;
            n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Input_5 != this.__p_IGGficrUmVOLnTcZbdRsPU || Output_11 != this.__p_Lm8GjVVahpuO01tBZKWGe0 || Output_14 != this.__p_CCRWtWEhtw5NwurUPWneQm ? new FileWriter__1_J7vmTTktovMOYBUQelwW3O(this)
                {__p_IGGficrUmVOLnTcZbdRsPU = Input_5, __p_Lm8GjVVahpuO01tBZKWGe0 = Output_11, __p_CCRWtWEhtw5NwurUPWneQm = Output_14} : that_15;
            else
            {
                this.__p_IGGficrUmVOLnTcZbdRsPU = Input_5;
                this.__p_Lm8GjVVahpuO01tBZKWGe0 = Output_11;
                this.__p_CCRWtWEhtw5NwurUPWneQm = Output_14;
            }

            return that_15;
        }

        public n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "CCRWtWEhtw5NwurUPWneQm", 238007U);
            var Output_1 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IGGficrUmVOLnTcZbdRsPU", 238031U);
            n70.IFrameClock Clock_3 = n69._Operations_.CreateDefault();
            n71._Operations_.Create_H(Node_Context: Node_Context_2, Clock_In: Clock_3, Output_Out: out n68.ObsoleteFileNoSharing Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Lm8GjVVahpuO01tBZKWGe0", 238045U);
            var Output_6 = n72.Writer_FLTogNdA1Z3OamN18SsMzU.Create(Node_Context: Node_Context_5);
            n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O that_7 = this;
            this.__p_CCRWtWEhtw5NwurUPWneQm = Output_1;
            this.__p_IGGficrUmVOLnTcZbdRsPU = Output_4;
            this.__p_Lm8GjVVahpuO01tBZKWGe0 = Output_6;
            return that_7;
        }

        public n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O __CreateDefault__()
        {
            n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O that_0 = this;
            this.__p_IGGficrUmVOLnTcZbdRsPU = default(n68.ObsoleteFileNoSharing);
            this.__p_Lm8GjVVahpuO01tBZKWGe0 = n72.Writer_FLTogNdA1Z3OamN18SsMzU.CreateDefault();
            this.__p_CCRWtWEhtw5NwurUPWneQm = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IGGficrUmVOLnTcZbdRsPU);
            n1.CompilationHelper.SafeDispose(this.__p_Lm8GjVVahpuO01tBZKWGe0);
            n1.CompilationHelper.SafeDispose(this.__p_CCRWtWEhtw5NwurUPWneQm);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 238001U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SwxOdQ3MquzL6kX83tIF3J", Name = "__slot_SwxOdQ3MquzL6kX83tIF3J")]
        public static n8.FileMode __slot_SwxOdQ3MquzL6kX83tIF3J = n1.CompilationHelper.Deserialize<n8.FileMode>("Append", false, "PcdEIeqrXeZQCL5lc35ctR", "SwxOdQ3MquzL6kX83tIF3J");
        [n1.ElementAttribute(TracingId = 238002U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SYPA42Pgme3QMlTnT6kKTL", Name = "__slot_SYPA42Pgme3QMlTnT6kKTL")]
        public static n8.FileAccess __slot_SYPA42Pgme3QMlTnT6kKTL = n1.CompilationHelper.Deserialize<n8.FileAccess>("Write", false, "PcdEIeqrXeZQCL5lc35ctR", "SYPA42Pgme3QMlTnT6kKTL");
        [n1.ElementAttribute(TracingId = 238027U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CkXExCY454WQaaxPdWsOnq", Name = "__slot_CkXExCY454WQaaxPdWsOnq")]
        public static n8.FileMode __slot_CkXExCY454WQaaxPdWsOnq = n1.CompilationHelper.Deserialize<n8.FileMode>("Create", false, "PcdEIeqrXeZQCL5lc35ctR", "CkXExCY454WQaaxPdWsOnq");
        [n1.ElementAttribute(TracingId = 238031U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IGGficrUmVOLnTcZbdRsPU", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n68.ObsoleteFileNoSharing __p_IGGficrUmVOLnTcZbdRsPU;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.FileShare __c_GZ6sC9fpDj7MLlRUsouVA9 = n1.CompilationHelper.Deserialize<n8.FileShare>("Read", false, "PcdEIeqrXeZQCL5lc35ctR", "GZ6sC9fpDj7MLlRUsouVA9");
        [n1.ElementAttribute(TracingId = 238045U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Lm8GjVVahpuO01tBZKWGe0", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n72.Writer_FLTogNdA1Z3OamN18SsMzU __p_Lm8GjVVahpuO01tBZKWGe0;
        [n1.ElementAttribute(TracingId = 238007U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CCRWtWEhtw5NwurUPWneQm", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CCRWtWEhtw5NwurUPWneQm;
        static FileWriter__1_J7vmTTktovMOYBUQelwW3O()
        {
        }

        public FileWriter__1_J7vmTTktovMOYBUQelwW3O(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter__1_J7vmTTktovMOYBUQelwW3O(FileWriter__1_J7vmTTktovMOYBUQelwW3O other): base(other)
        {
            this.__p_IGGficrUmVOLnTcZbdRsPU = other.__p_IGGficrUmVOLnTcZbdRsPU;
            this.__p_Lm8GjVVahpuO01tBZKWGe0 = other.__p_Lm8GjVVahpuO01tBZKWGe0;
            this.__p_CCRWtWEhtw5NwurUPWneQm = other.__p_CCRWtWEhtw5NwurUPWneQm;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IGGficrUmVOLnTcZbdRsPU", in __p_IGGficrUmVOLnTcZbdRsPU), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lm8GjVVahpuO01tBZKWGe0", in __p_Lm8GjVVahpuO01tBZKWGe0), n1.CompilationHelper.GetValueOrExisting(values, "__p_CCRWtWEhtw5NwurUPWneQm", in __p_CCRWtWEhtw5NwurUPWneQm));
        }

        internal FileWriter__1_J7vmTTktovMOYBUQelwW3O __WITH__(n68.ObsoleteFileNoSharing __p_IGGficrUmVOLnTcZbdRsPU, n72.Writer_FLTogNdA1Z3OamN18SsMzU __p_Lm8GjVVahpuO01tBZKWGe0, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CCRWtWEhtw5NwurUPWneQm)
        {
            n67.FileWriter__1_J7vmTTktovMOYBUQelwW3O that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IGGficrUmVOLnTcZbdRsPU != this.__p_IGGficrUmVOLnTcZbdRsPU || __p_Lm8GjVVahpuO01tBZKWGe0 != this.__p_Lm8GjVVahpuO01tBZKWGe0 || __p_CCRWtWEhtw5NwurUPWneQm != this.__p_CCRWtWEhtw5NwurUPWneQm ? new FileWriter__1_J7vmTTktovMOYBUQelwW3O(this)
                {__p_IGGficrUmVOLnTcZbdRsPU = __p_IGGficrUmVOLnTcZbdRsPU, __p_Lm8GjVVahpuO01tBZKWGe0 = __p_Lm8GjVVahpuO01tBZKWGe0, __p_CCRWtWEhtw5NwurUPWneQm = __p_CCRWtWEhtw5NwurUPWneQm} : that_0;
            else
            {
                this.__p_IGGficrUmVOLnTcZbdRsPU = __p_IGGficrUmVOLnTcZbdRsPU;
                this.__p_Lm8GjVVahpuO01tBZKWGe0 = __p_Lm8GjVVahpuO01tBZKWGe0;
                this.__p_CCRWtWEhtw5NwurUPWneQm = __p_CCRWtWEhtw5NwurUPWneQm;
            }

            return that_0;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.File__1.Obsolete
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, T Clock_In, out n68.ObsoleteFile Output_Out)
            where T : n70.IFrameClock
        {
            n70.IFrameClock Clock_0 = (n70.IFrameClock)Clock_In;
            var Output_1 = new n68.ObsoleteFile(clock: Clock_0);
            Output_Out = Output_1;
            return;
        }

        public static void Update_H(n68.ObsoleteFile Input_In, n37.Path File_Path_In, [n4.SerializedDefaultValueAttribute("OpenOrCreate", false)] n8.FileMode File_Mode_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileAccess File_Access_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileShare File_Share_In, out n68.ObsoleteFile Output_Out, out n9.IResourceProvider<n8.Stream> Result_Out)
        {
            var Result_0 = Input_In.Update(filePath: File_Path_In, fileMode: File_Mode_In, fileAccess: File_Access_In, fileShare: File_Share_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.File_NoSharing_1.Obsolete
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, n70.IFrameClock Clock_In, out n68.ObsoleteFileNoSharing Output_Out)
        {
            var Output_0 = new n68.ObsoleteFileNoSharing(clock: Clock_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n68.ObsoleteFileNoSharing Input_In, n37.Path File_Path_In, [n4.SerializedDefaultValueAttribute("OpenOrCreate", false)] n8.FileMode File_Mode_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileAccess File_Access_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileShare File_Share_In, out n68.ObsoleteFileNoSharing Output_Out, out n9.IResourceProvider<n8.Stream> Result_Out)
        {
            var Result_0 = Input_In.Update(filePath: File_Path_In, fileMode: File_Mode_In, fileAccess: File_Access_In, fileShare: File_Share_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Advanced
{
    [n1.ElementAttribute(TracingId = 240786U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "OZuCM5n4eNWP7pF1DYKlef", Name = "StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef")]
    [n2.SerializableAttribute]
    public class StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef Create(n1.NodeContext Node_Context)
        {
            var instance = new StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef CreateDefault()
        {
            var instance = new StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef Update(n2.IObservable<n9.IResourceProvider<n8.Stream>> Input_In, n11.Encodings Encoding_In, out n2.IObservable<string> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n7.AsyncCharReader Input__this__0 = this.__p_IrcaNFDBAKbNAQmV0yVzi6;
            var Result_1 = Input__this__0.Update(input: Input_In, encoding: Encoding_In);
            n44._Operations_.Update_H<char>(State_Input_In: this.__p_JcMSmpqcyFvLVA4QJe0Mha, Input_In: Result_1, State_Output_Out: out n7.Monitor<char> State_Output_2, Output_Out: out n2.IObservable<n2.IObservable<n7.Chunk<char>>> Output_3, Progress_Out: out float Progress_4, In_Progress_Out: out bool In_Progress_5, On_Completed_Out: out bool On_Completed_6);
            n7.AsyncCharCollector Input__this__7 = this.__p_Bts9XSEZux8OaguGaDqgIq;
            var Result_8 = Input__this__7.Update(input: Output_3);
            Output_Out = Result_8;
            Progress_Out = Progress_4;
            In_Progress_Out = In_Progress_5;
            On_Completed_Out = On_Completed_6;
            n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = Input__this__0 != this.__p_IrcaNFDBAKbNAQmV0yVzi6 || State_Output_2 != this.__p_JcMSmpqcyFvLVA4QJe0Mha || Input__this__7 != this.__p_Bts9XSEZux8OaguGaDqgIq ? new StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(this)
                {__p_IrcaNFDBAKbNAQmV0yVzi6 = Input__this__0, __p_JcMSmpqcyFvLVA4QJe0Mha = State_Output_2, __p_Bts9XSEZux8OaguGaDqgIq = Input__this__7} : that_9;
            else
            {
                this.__p_IrcaNFDBAKbNAQmV0yVzi6 = Input__this__0;
                this.__p_JcMSmpqcyFvLVA4QJe0Mha = State_Output_2;
                this.__p_Bts9XSEZux8OaguGaDqgIq = Input__this__7;
            }

            return that_9;
        }

        public n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "IrcaNFDBAKbNAQmV0yVzi6", 240796U);
            n74._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.AsyncCharReader Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Bts9XSEZux8OaguGaDqgIq", 240811U);
            n75._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n7.AsyncCharCollector Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "JcMSmpqcyFvLVA4QJe0Mha", 240815U);
            n44._Operations_.Create_H<char>(Node_Context: Node_Context_4, Output_Out: out n7.Monitor<char> Output_5);
            n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef that_6 = this;
            this.__p_IrcaNFDBAKbNAQmV0yVzi6 = Output_1;
            this.__p_Bts9XSEZux8OaguGaDqgIq = Output_3;
            this.__p_JcMSmpqcyFvLVA4QJe0Mha = Output_5;
            return that_6;
        }

        public n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef __CreateDefault__()
        {
            n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef that_0 = this;
            this.__p_IrcaNFDBAKbNAQmV0yVzi6 = default(n7.AsyncCharReader);
            this.__p_JcMSmpqcyFvLVA4QJe0Mha = default(n7.Monitor<char>);
            this.__p_Bts9XSEZux8OaguGaDqgIq = default(n7.AsyncCharCollector);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IrcaNFDBAKbNAQmV0yVzi6);
            n1.CompilationHelper.SafeDispose(this.__p_JcMSmpqcyFvLVA4QJe0Mha);
            n1.CompilationHelper.SafeDispose(this.__p_Bts9XSEZux8OaguGaDqgIq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 240796U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IrcaNFDBAKbNAQmV0yVzi6", Name = "CharReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncCharReader __p_IrcaNFDBAKbNAQmV0yVzi6;
        [n1.ElementAttribute(TracingId = 240815U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JcMSmpqcyFvLVA4QJe0Mha", Name = "Monitor (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Monitor<char> __p_JcMSmpqcyFvLVA4QJe0Mha;
        [n1.ElementAttribute(TracingId = 240811U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Bts9XSEZux8OaguGaDqgIq", Name = "CharCollector (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncCharCollector __p_Bts9XSEZux8OaguGaDqgIq;
        public StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef other): base(other)
        {
            this.__p_IrcaNFDBAKbNAQmV0yVzi6 = other.__p_IrcaNFDBAKbNAQmV0yVzi6;
            this.__p_JcMSmpqcyFvLVA4QJe0Mha = other.__p_JcMSmpqcyFvLVA4QJe0Mha;
            this.__p_Bts9XSEZux8OaguGaDqgIq = other.__p_Bts9XSEZux8OaguGaDqgIq;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IrcaNFDBAKbNAQmV0yVzi6", in __p_IrcaNFDBAKbNAQmV0yVzi6), n1.CompilationHelper.GetValueOrExisting(values, "__p_JcMSmpqcyFvLVA4QJe0Mha", in __p_JcMSmpqcyFvLVA4QJe0Mha), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bts9XSEZux8OaguGaDqgIq", in __p_Bts9XSEZux8OaguGaDqgIq));
        }

        internal StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef __WITH__(n7.AsyncCharReader __p_IrcaNFDBAKbNAQmV0yVzi6, n7.Monitor<char> __p_JcMSmpqcyFvLVA4QJe0Mha, n7.AsyncCharCollector __p_Bts9XSEZux8OaguGaDqgIq)
        {
            n38.StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IrcaNFDBAKbNAQmV0yVzi6 != this.__p_IrcaNFDBAKbNAQmV0yVzi6 || __p_JcMSmpqcyFvLVA4QJe0Mha != this.__p_JcMSmpqcyFvLVA4QJe0Mha || __p_Bts9XSEZux8OaguGaDqgIq != this.__p_Bts9XSEZux8OaguGaDqgIq ? new StringReader_Reactive_OZuCM5n4eNWP7pF1DYKlef(this)
                {__p_IrcaNFDBAKbNAQmV0yVzi6 = __p_IrcaNFDBAKbNAQmV0yVzi6, __p_JcMSmpqcyFvLVA4QJe0Mha = __p_JcMSmpqcyFvLVA4QJe0Mha, __p_Bts9XSEZux8OaguGaDqgIq = __p_Bts9XSEZux8OaguGaDqgIq} : that_0;
            else
            {
                this.__p_IrcaNFDBAKbNAQmV0yVzi6 = __p_IrcaNFDBAKbNAQmV0yVzi6;
                this.__p_JcMSmpqcyFvLVA4QJe0Mha = __p_JcMSmpqcyFvLVA4QJe0Mha;
                this.__p_Bts9XSEZux8OaguGaDqgIq = __p_Bts9XSEZux8OaguGaDqgIq;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 240933U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "NvLjtZwaL21LuVr42kqkiy", Name = "StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy")]
    [n2.SerializableAttribute]
    public class StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy Create(n1.NodeContext Node_Context)
        {
            var instance = new StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy CreateDefault()
        {
            var instance = new StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy Update(n9.IResourceProvider<n8.Stream> Input_In, n2.IObservable<string> Data_In, n11.Encodings Encoding_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n7.AsyncCharChunkifier Input__this__0 = this.__p_RwNyBPFVZ1LNmw3v2b5Fgl;
            var Result_1 = Input__this__0.Update(input: Data_In);
            n7.AsyncCharWriter Input__this__2 = this.__p_ANlZTwNrIarMcHjONenTmy;
            var Result_3 = Input__this__2.Update(input: Input_In, data: Result_1, encoding: Encoding_In);
            n44._Operations_.Update_H<char>(State_Input_In: this.__p_Knyumvw7SNQOqyvPa5ekXr, Input_In: Result_3, State_Output_Out: out n7.Monitor<char> State_Output_4, Output_Out: out n2.IObservable<n2.IObservable<n7.Chunk<char>>> Output_5, Progress_Out: out float Progress_6, In_Progress_Out: out bool In_Progress_7, On_Completed_Out: out bool On_Completed_8);
            var Output_10 = this.__p_Aq7SU2d922yMRS6YUDS87Y.Update(Value_In: Output_5, Result_Out: out n2.IObservable<n7.Chunk<char>> Result_9);
            bool Update_11 = true;
            var Output_12 = this.__p_KHqS2cz0tAIPDO72oIYTlx;
            if (Update_11)
            {
                Output_12 = this.__p_KHqS2cz0tAIPDO72oIYTlx.Update(Input_In: Result_9);
            }

            Progress_Out = Progress_6;
            In_Progress_Out = In_Progress_7;
            On_Completed_Out = On_Completed_8;
            n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Input__this__0 != this.__p_RwNyBPFVZ1LNmw3v2b5Fgl || Input__this__2 != this.__p_ANlZTwNrIarMcHjONenTmy || State_Output_4 != this.__p_Knyumvw7SNQOqyvPa5ekXr || Output_10 != this.__p_Aq7SU2d922yMRS6YUDS87Y || Output_12 != this.__p_KHqS2cz0tAIPDO72oIYTlx ? new StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(this)
                {__p_RwNyBPFVZ1LNmw3v2b5Fgl = Input__this__0, __p_ANlZTwNrIarMcHjONenTmy = Input__this__2, __p_Knyumvw7SNQOqyvPa5ekXr = State_Output_4, __p_Aq7SU2d922yMRS6YUDS87Y = Output_10, __p_KHqS2cz0tAIPDO72oIYTlx = Output_12} : that_13;
            else
            {
                this.__p_RwNyBPFVZ1LNmw3v2b5Fgl = Input__this__0;
                this.__p_ANlZTwNrIarMcHjONenTmy = Input__this__2;
                this.__p_Knyumvw7SNQOqyvPa5ekXr = State_Output_4;
                this.__p_Aq7SU2d922yMRS6YUDS87Y = Output_10;
                this.__p_KHqS2cz0tAIPDO72oIYTlx = Output_12;
            }

            return that_13;
        }

        public n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "RwNyBPFVZ1LNmw3v2b5Fgl", 240936U);
            n76._Operations_.Create_H(Node_Context: Node_Context_0, Output_Out: out n7.AsyncCharChunkifier Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "ANlZTwNrIarMcHjONenTmy", 240945U);
            n77._Operations_.Create_H(Node_Context_In: Node_Context_2, Output_Out: out n7.AsyncCharWriter Output_3);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Knyumvw7SNQOqyvPa5ekXr", 240955U);
            n44._Operations_.Create_H<char>(Node_Context: Node_Context_4, Output_Out: out n7.Monitor<char> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Aq7SU2d922yMRS6YUDS87Y", 240967U);
            var Output_7 = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<char>>>, n7.Chunk<char>>.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "KHqS2cz0tAIPDO72oIYTlx", 240972U);
            var Output_9 = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<char>>, n7.Chunk<char>>.Create(Node_Context: Node_Context_8);
            n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy that_10 = this;
            this.__p_RwNyBPFVZ1LNmw3v2b5Fgl = Output_1;
            this.__p_ANlZTwNrIarMcHjONenTmy = Output_3;
            this.__p_Knyumvw7SNQOqyvPa5ekXr = Output_5;
            this.__p_Aq7SU2d922yMRS6YUDS87Y = Output_7;
            this.__p_KHqS2cz0tAIPDO72oIYTlx = Output_9;
            return that_10;
        }

        public n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy __CreateDefault__()
        {
            n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy that_0 = this;
            this.__p_RwNyBPFVZ1LNmw3v2b5Fgl = default(n7.AsyncCharChunkifier);
            this.__p_ANlZTwNrIarMcHjONenTmy = default(n7.AsyncCharWriter);
            this.__p_Knyumvw7SNQOqyvPa5ekXr = default(n7.Monitor<char>);
            this.__p_Aq7SU2d922yMRS6YUDS87Y = n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<char>>>, n7.Chunk<char>>.CreateDefault();
            this.__p_KHqS2cz0tAIPDO72oIYTlx = n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<char>>, n7.Chunk<char>>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RwNyBPFVZ1LNmw3v2b5Fgl);
            n1.CompilationHelper.SafeDispose(this.__p_ANlZTwNrIarMcHjONenTmy);
            n1.CompilationHelper.SafeDispose(this.__p_Knyumvw7SNQOqyvPa5ekXr);
            n1.CompilationHelper.SafeDispose(this.__p_Aq7SU2d922yMRS6YUDS87Y);
            n1.CompilationHelper.SafeDispose(this.__p_KHqS2cz0tAIPDO72oIYTlx);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 240936U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RwNyBPFVZ1LNmw3v2b5Fgl", Name = "CharChunkifier (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncCharChunkifier __p_RwNyBPFVZ1LNmw3v2b5Fgl;
        [n1.ElementAttribute(TracingId = 240945U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ANlZTwNrIarMcHjONenTmy", Name = "CharWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.AsyncCharWriter __p_ANlZTwNrIarMcHjONenTmy;
        [n1.ElementAttribute(TracingId = 240955U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Knyumvw7SNQOqyvPa5ekXr", Name = "Monitor (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Monitor<char> __p_Knyumvw7SNQOqyvPa5ekXr;
        [n1.ElementAttribute(TracingId = 240967U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Aq7SU2d922yMRS6YUDS87Y", Name = "Switch", IsManaged = true, IsAutoGenerated = true)]
        public n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<char>>>, n7.Chunk<char>> __p_Aq7SU2d922yMRS6YUDS87Y;
        [n1.ElementAttribute(TracingId = 240972U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "KHqS2cz0tAIPDO72oIYTlx", Name = "Subscribe", IsManaged = true, IsAutoGenerated = true)]
        public n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<char>>, n7.Chunk<char>> __p_KHqS2cz0tAIPDO72oIYTlx;
        public StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy other): base(other)
        {
            this.__p_RwNyBPFVZ1LNmw3v2b5Fgl = other.__p_RwNyBPFVZ1LNmw3v2b5Fgl;
            this.__p_ANlZTwNrIarMcHjONenTmy = other.__p_ANlZTwNrIarMcHjONenTmy;
            this.__p_Knyumvw7SNQOqyvPa5ekXr = other.__p_Knyumvw7SNQOqyvPa5ekXr;
            this.__p_Aq7SU2d922yMRS6YUDS87Y = other.__p_Aq7SU2d922yMRS6YUDS87Y;
            this.__p_KHqS2cz0tAIPDO72oIYTlx = other.__p_KHqS2cz0tAIPDO72oIYTlx;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RwNyBPFVZ1LNmw3v2b5Fgl", in __p_RwNyBPFVZ1LNmw3v2b5Fgl), n1.CompilationHelper.GetValueOrExisting(values, "__p_ANlZTwNrIarMcHjONenTmy", in __p_ANlZTwNrIarMcHjONenTmy), n1.CompilationHelper.GetValueOrExisting(values, "__p_Knyumvw7SNQOqyvPa5ekXr", in __p_Knyumvw7SNQOqyvPa5ekXr), n1.CompilationHelper.GetValueOrExisting(values, "__p_Aq7SU2d922yMRS6YUDS87Y", in __p_Aq7SU2d922yMRS6YUDS87Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_KHqS2cz0tAIPDO72oIYTlx", in __p_KHqS2cz0tAIPDO72oIYTlx));
        }

        internal StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy __WITH__(n7.AsyncCharChunkifier __p_RwNyBPFVZ1LNmw3v2b5Fgl, n7.AsyncCharWriter __p_ANlZTwNrIarMcHjONenTmy, n7.Monitor<char> __p_Knyumvw7SNQOqyvPa5ekXr, n49.Switch_M9sbDTDlF27NjjkngIh8VW<n2.IObservable<n2.IObservable<n7.Chunk<char>>>, n7.Chunk<char>> __p_Aq7SU2d922yMRS6YUDS87Y, n18.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n7.Chunk<char>>, n7.Chunk<char>> __p_KHqS2cz0tAIPDO72oIYTlx)
        {
            n38.StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RwNyBPFVZ1LNmw3v2b5Fgl != this.__p_RwNyBPFVZ1LNmw3v2b5Fgl || __p_ANlZTwNrIarMcHjONenTmy != this.__p_ANlZTwNrIarMcHjONenTmy || __p_Knyumvw7SNQOqyvPa5ekXr != this.__p_Knyumvw7SNQOqyvPa5ekXr || __p_Aq7SU2d922yMRS6YUDS87Y != this.__p_Aq7SU2d922yMRS6YUDS87Y || __p_KHqS2cz0tAIPDO72oIYTlx != this.__p_KHqS2cz0tAIPDO72oIYTlx ? new StringWriter_Reactive_NvLjtZwaL21LuVr42kqkiy(this)
                {__p_RwNyBPFVZ1LNmw3v2b5Fgl = __p_RwNyBPFVZ1LNmw3v2b5Fgl, __p_ANlZTwNrIarMcHjONenTmy = __p_ANlZTwNrIarMcHjONenTmy, __p_Knyumvw7SNQOqyvPa5ekXr = __p_Knyumvw7SNQOqyvPa5ekXr, __p_Aq7SU2d922yMRS6YUDS87Y = __p_Aq7SU2d922yMRS6YUDS87Y, __p_KHqS2cz0tAIPDO72oIYTlx = __p_KHqS2cz0tAIPDO72oIYTlx} : that_0;
            else
            {
                this.__p_RwNyBPFVZ1LNmw3v2b5Fgl = __p_RwNyBPFVZ1LNmw3v2b5Fgl;
                this.__p_ANlZTwNrIarMcHjONenTmy = __p_ANlZTwNrIarMcHjONenTmy;
                this.__p_Knyumvw7SNQOqyvPa5ekXr = __p_Knyumvw7SNQOqyvPa5ekXr;
                this.__p_Aq7SU2d922yMRS6YUDS87Y = __p_Aq7SU2d922yMRS6YUDS87Y;
                this.__p_KHqS2cz0tAIPDO72oIYTlx = __p_KHqS2cz0tAIPDO72oIYTlx;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 241467U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BOTojDz8Ou7NQQoQbWoirY", Name = "StringReader_BOTojDz8Ou7NQQoQbWoirY")]
    [n2.SerializableAttribute]
    public class StringReader_BOTojDz8Ou7NQQoQbWoirY : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.StringReader_BOTojDz8Ou7NQQoQbWoirY Create(n1.NodeContext Node_Context)
        {
            var instance = new StringReader_BOTojDz8Ou7NQQoQbWoirY(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n38.StringReader_BOTojDz8Ou7NQQoQbWoirY CreateDefault()
        {
            var instance = new StringReader_BOTojDz8Ou7NQQoQbWoirY(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.StringReader_BOTojDz8Ou7NQQoQbWoirY Update(n9.IResourceProvider<n8.Stream> Input_In, n11.Encodings Encoding_In, bool Read_In, out string Output_Out)
        {
            n7.CharReader Input__this__0 = this.__p_JoxQgpdcFFzLzTRHjx5sIj;
            var Result_1 = Input__this__0.Update(input: Input_In, encoding: Encoding_In);
            n7.CharCollector Input__this__2 = this.__p_K4qs6UwKPR9QMO3FfFt7EP;
            var Result_3 = Input__this__2.Update(input: Result_1, collect: Read_In);
            Output_Out = Result_3;
            n38.StringReader_BOTojDz8Ou7NQQoQbWoirY that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = Input__this__0 != this.__p_JoxQgpdcFFzLzTRHjx5sIj || Input__this__2 != this.__p_K4qs6UwKPR9QMO3FfFt7EP ? new StringReader_BOTojDz8Ou7NQQoQbWoirY(this)
                {__p_JoxQgpdcFFzLzTRHjx5sIj = Input__this__0, __p_K4qs6UwKPR9QMO3FfFt7EP = Input__this__2} : that_4;
            else
            {
                this.__p_JoxQgpdcFFzLzTRHjx5sIj = Input__this__0;
                this.__p_K4qs6UwKPR9QMO3FfFt7EP = Input__this__2;
            }

            return that_4;
        }

        public n38.StringReader_BOTojDz8Ou7NQQoQbWoirY __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "JoxQgpdcFFzLzTRHjx5sIj", 241472U);
            n81._Operations_.Create_H(Node_Context_In: Node_Context_0, Output_Out: out n7.CharReader Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "K4qs6UwKPR9QMO3FfFt7EP", 241477U);
            n82._Operations_.Create_H(Node_Context: Node_Context_2, Output_Out: out n7.CharCollector Output_3);
            n38.StringReader_BOTojDz8Ou7NQQoQbWoirY that_4 = this;
            this.__p_JoxQgpdcFFzLzTRHjx5sIj = Output_1;
            this.__p_K4qs6UwKPR9QMO3FfFt7EP = Output_3;
            return that_4;
        }

        public n38.StringReader_BOTojDz8Ou7NQQoQbWoirY __CreateDefault__()
        {
            n38.StringReader_BOTojDz8Ou7NQQoQbWoirY that_0 = this;
            this.__p_JoxQgpdcFFzLzTRHjx5sIj = default(n7.CharReader);
            this.__p_K4qs6UwKPR9QMO3FfFt7EP = default(n7.CharCollector);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JoxQgpdcFFzLzTRHjx5sIj);
            n1.CompilationHelper.SafeDispose(this.__p_K4qs6UwKPR9QMO3FfFt7EP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 241472U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JoxQgpdcFFzLzTRHjx5sIj", Name = "CharReader", IsManaged = true, IsAutoGenerated = true)]
        public n7.CharReader __p_JoxQgpdcFFzLzTRHjx5sIj;
        [n1.ElementAttribute(TracingId = 241477U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "K4qs6UwKPR9QMO3FfFt7EP", Name = "CharCollector", IsManaged = true, IsAutoGenerated = true)]
        public n7.CharCollector __p_K4qs6UwKPR9QMO3FfFt7EP;
        public StringReader_BOTojDz8Ou7NQQoQbWoirY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringReader_BOTojDz8Ou7NQQoQbWoirY(StringReader_BOTojDz8Ou7NQQoQbWoirY other): base(other)
        {
            this.__p_JoxQgpdcFFzLzTRHjx5sIj = other.__p_JoxQgpdcFFzLzTRHjx5sIj;
            this.__p_K4qs6UwKPR9QMO3FfFt7EP = other.__p_K4qs6UwKPR9QMO3FfFt7EP;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JoxQgpdcFFzLzTRHjx5sIj", in __p_JoxQgpdcFFzLzTRHjx5sIj), n1.CompilationHelper.GetValueOrExisting(values, "__p_K4qs6UwKPR9QMO3FfFt7EP", in __p_K4qs6UwKPR9QMO3FfFt7EP));
        }

        internal StringReader_BOTojDz8Ou7NQQoQbWoirY __WITH__(n7.CharReader __p_JoxQgpdcFFzLzTRHjx5sIj, n7.CharCollector __p_K4qs6UwKPR9QMO3FfFt7EP)
        {
            n38.StringReader_BOTojDz8Ou7NQQoQbWoirY that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JoxQgpdcFFzLzTRHjx5sIj != this.__p_JoxQgpdcFFzLzTRHjx5sIj || __p_K4qs6UwKPR9QMO3FfFt7EP != this.__p_K4qs6UwKPR9QMO3FfFt7EP ? new StringReader_BOTojDz8Ou7NQQoQbWoirY(this)
                {__p_JoxQgpdcFFzLzTRHjx5sIj = __p_JoxQgpdcFFzLzTRHjx5sIj, __p_K4qs6UwKPR9QMO3FfFt7EP = __p_K4qs6UwKPR9QMO3FfFt7EP} : that_0;
            else
            {
                this.__p_JoxQgpdcFFzLzTRHjx5sIj = __p_JoxQgpdcFFzLzTRHjx5sIj;
                this.__p_K4qs6UwKPR9QMO3FfFt7EP = __p_K4qs6UwKPR9QMO3FfFt7EP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 241500U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "DcGtmOHsL0sNmgl8AQ442U", Name = "StringWriter_DcGtmOHsL0sNmgl8AQ442U")]
    [n2.SerializableAttribute]
    public class StringWriter_DcGtmOHsL0sNmgl8AQ442U : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U Create(n1.NodeContext Node_Context)
        {
            var instance = new StringWriter_DcGtmOHsL0sNmgl8AQ442U(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U CreateDefault()
        {
            var instance = new StringWriter_DcGtmOHsL0sNmgl8AQ442U(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U Update(n9.IResourceProvider<n8.Stream> Input_In, string Data_In, n11.Encodings Encoding_In, bool Write_In)
        {
            n7.CharChunkifier Input__this__0 = this.__p_ABQvfqdLlmFL5jMVMVR27H;
            var Result_1 = Input__this__0.Update(input: Data_In);
            bool Update_2 = true;
            var Output_3 = this.__p_D9gwu3NeOvuQQfemDPxzTM;
            if (Update_2)
            {
                n7.CharWriter Input__this__4 = this.__p_D9gwu3NeOvuQQfemDPxzTM;
                Input__this__4.Update(input: Input_In, data: Result_1, encoding: Encoding_In, write: Write_In);
                Output_3 = Input__this__4;
            }

            n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Input__this__0 != this.__p_ABQvfqdLlmFL5jMVMVR27H || Output_3 != this.__p_D9gwu3NeOvuQQfemDPxzTM ? new StringWriter_DcGtmOHsL0sNmgl8AQ442U(this)
                {__p_ABQvfqdLlmFL5jMVMVR27H = Input__this__0, __p_D9gwu3NeOvuQQfemDPxzTM = Output_3} : that_5;
            else
            {
                this.__p_ABQvfqdLlmFL5jMVMVR27H = Input__this__0;
                this.__p_D9gwu3NeOvuQQfemDPxzTM = Output_3;
            }

            return that_5;
        }

        public n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "ABQvfqdLlmFL5jMVMVR27H", 241503U);
            n83._Operations_.Create_H(Node_Context: Node_Context_0, Output_Out: out n7.CharChunkifier Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "D9gwu3NeOvuQQfemDPxzTM", 241506U);
            n84._Operations_.Create_H(Node_Context_In: Node_Context_2, Output_Out: out n7.CharWriter Output_3);
            n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U that_4 = this;
            this.__p_ABQvfqdLlmFL5jMVMVR27H = Output_1;
            this.__p_D9gwu3NeOvuQQfemDPxzTM = Output_3;
            return that_4;
        }

        public n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U __CreateDefault__()
        {
            n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U that_0 = this;
            this.__p_ABQvfqdLlmFL5jMVMVR27H = default(n7.CharChunkifier);
            this.__p_D9gwu3NeOvuQQfemDPxzTM = default(n7.CharWriter);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ABQvfqdLlmFL5jMVMVR27H);
            n1.CompilationHelper.SafeDispose(this.__p_D9gwu3NeOvuQQfemDPxzTM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 241503U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "ABQvfqdLlmFL5jMVMVR27H", Name = "CharChunkifier", IsManaged = true, IsAutoGenerated = true)]
        public n7.CharChunkifier __p_ABQvfqdLlmFL5jMVMVR27H;
        [n1.ElementAttribute(TracingId = 241506U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "D9gwu3NeOvuQQfemDPxzTM", Name = "CharWriter", IsManaged = true, IsAutoGenerated = true)]
        public n7.CharWriter __p_D9gwu3NeOvuQQfemDPxzTM;
        public StringWriter_DcGtmOHsL0sNmgl8AQ442U(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringWriter_DcGtmOHsL0sNmgl8AQ442U(StringWriter_DcGtmOHsL0sNmgl8AQ442U other): base(other)
        {
            this.__p_ABQvfqdLlmFL5jMVMVR27H = other.__p_ABQvfqdLlmFL5jMVMVR27H;
            this.__p_D9gwu3NeOvuQQfemDPxzTM = other.__p_D9gwu3NeOvuQQfemDPxzTM;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ABQvfqdLlmFL5jMVMVR27H", in __p_ABQvfqdLlmFL5jMVMVR27H), n1.CompilationHelper.GetValueOrExisting(values, "__p_D9gwu3NeOvuQQfemDPxzTM", in __p_D9gwu3NeOvuQQfemDPxzTM));
        }

        internal StringWriter_DcGtmOHsL0sNmgl8AQ442U __WITH__(n7.CharChunkifier __p_ABQvfqdLlmFL5jMVMVR27H, n7.CharWriter __p_D9gwu3NeOvuQQfemDPxzTM)
        {
            n38.StringWriter_DcGtmOHsL0sNmgl8AQ442U that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ABQvfqdLlmFL5jMVMVR27H != this.__p_ABQvfqdLlmFL5jMVMVR27H || __p_D9gwu3NeOvuQQfemDPxzTM != this.__p_D9gwu3NeOvuQQfemDPxzTM ? new StringWriter_DcGtmOHsL0sNmgl8AQ442U(this)
                {__p_ABQvfqdLlmFL5jMVMVR27H = __p_ABQvfqdLlmFL5jMVMVR27H, __p_D9gwu3NeOvuQQfemDPxzTM = __p_D9gwu3NeOvuQQfemDPxzTM} : that_0;
            else
            {
                this.__p_ABQvfqdLlmFL5jMVMVR27H = __p_ABQvfqdLlmFL5jMVMVR27H;
                this.__p_D9gwu3NeOvuQQfemDPxzTM = __p_D9gwu3NeOvuQQfemDPxzTM;
            }

            return that_0;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteReader_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context_In, out n7.AsyncByteReader Output_Out)
        {
            var Output_0 = new n7.AsyncByteReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update(n7.AsyncByteReader Input__this__In, n2.IObservable<n9.IResourceProvider<n8.Stream>> Input_In, out n7.AsyncByteReader Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteWriter_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context_In, out n7.AsyncByteWriter Output_Out)
        {
            var Output_0 = new n7.AsyncByteWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update(n7.AsyncByteWriter State_Input_In, n9.IResourceProvider<n8.Stream> Input_In, n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Data_In, out n7.AsyncByteWriter State_Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Result_Out)
        {
            var Result_0 = State_Input_In.Update(input: Input_In, data: Data_In);
            State_Output_Out = State_Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharReader.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.CharReader Output_Out)
        {
            var Output_0 = new n7.CharReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.CharReader Input__this__In, n9.IResourceProvider<n8.Stream> Input_In, n11.Encodings Encoding_In, out n7.CharReader Output_Out, out n10.IEnumerable<n7.Chunk<char>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, encoding: Encoding_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharWriter.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.CharWriter Output_Out)
        {
            var Output_0 = new n7.CharWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.CharWriter Input__this__In, n9.IResourceProvider<n8.Stream> Input_In, n10.IEnumerable<n7.Chunk<char>> Data_In, n11.Encodings Encoding_In, bool Write_In, out n7.CharWriter Output_Out)
        {
            Input__this__In.Update(input: Input_In, data: Data_In, encoding: Encoding_In, write: Write_In);
            Output_Out = Input__this__In;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteChunkifier_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, out n7.AsyncByteChunkifier Output_Out)
        {
            var Output_0 = new n7.AsyncByteChunkifier();
            Output_Out = Output_0;
            return;
        }

        public static void Update(n7.AsyncByteChunkifier Input__this__In, n2.IObservable<n12.Spread<byte>> Input_In, out n7.AsyncByteChunkifier Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharChunkifier.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.CharChunkifier Output_Out)
        {
            var Output_0 = new n7.CharChunkifier();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.CharChunkifier Input__this__In, string Input_In, out n7.CharChunkifier Output_Out, out n10.IEnumerable<n7.Chunk<char>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteCollector_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, out n7.AsyncByteCollector Output_Out)
        {
            var Output_0 = new n7.AsyncByteCollector();
            Output_Out = Output_0;
            return;
        }

        public static void Update(n7.AsyncByteCollector Input__this__In, n2.IObservable<n2.IObservable<n7.Chunk<byte>>> Input_In, out n7.AsyncByteCollector Output_Out, out n2.IObservable<n12.Spread<byte>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharCollector.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.CharCollector Output_Out)
        {
            var Output_0 = new n7.CharCollector();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.CharCollector Input__this__In, n10.IEnumerable<n7.Chunk<char>> Input_In, bool Collect_In, out n7.CharCollector Output_Out, out string Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, collect: Collect_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Monitor_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n7.Monitor<T> Output_Out)
        {
            var Output_0 = new n7.Monitor<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n7.Monitor<T> State_Input_In, n2.IObservable<n2.IObservable<n7.Chunk<T>>> Input_In, out n7.Monitor<T> State_Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<T>>> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var Result_3 = State_Input_In.Update(input: Input_In, progress: out float Progress_0, inProgress: out bool In_Progress_1, onCompleted: out bool On_Completed_2);
            State_Output_Out = State_Input_In;
            Output_Out = Result_3;
            Progress_Out = Progress_0;
            In_Progress_Out = In_Progress_1;
            On_Completed_Out = On_Completed_2;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteReader.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.ByteReader Output_Out)
        {
            var Output_0 = new n7.ByteReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.ByteReader Input__this__In, n9.IResourceProvider<n8.Stream> Input_In, out n7.ByteReader Output_Out, out n10.IEnumerable<n7.Chunk<byte>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteCollector.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.ByteCollector Output_Out)
        {
            var Output_0 = new n7.ByteCollector();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.ByteCollector Input__this__In, n10.IEnumerable<n7.Chunk<byte>> Input_In, bool Collect_In, out n7.ByteCollector Output_Out, out n12.Spread<byte> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, collect: Collect_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteWriter.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.ByteWriter Output_Out)
        {
            var Output_0 = new n7.ByteWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.ByteWriter Input__this__In, n9.IResourceProvider<n8.Stream> Input_In, n10.IEnumerable<n7.Chunk<byte>> Data_In, bool Write_In, out n7.ByteWriter Output_Out)
        {
            Input__this__In.Update(input: Input_In, data: Data_In, write: Write_In);
            Output_Out = Input__this__In;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.ByteChunkifier.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.ByteChunkifier Output_Out)
        {
            var Output_0 = new n7.ByteChunkifier();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.ByteChunkifier Input__this__In, n12.Spread<byte> Input_In, out n7.ByteChunkifier Output_Out, out n10.IEnumerable<n7.Chunk<byte>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharReader_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.AsyncCharReader Output_Out)
        {
            var Output_0 = new n7.AsyncCharReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.AsyncCharReader Input__this__In, n2.IObservable<n9.IResourceProvider<n8.Stream>> Input_In, n11.Encodings Encoding_In, out n7.AsyncCharReader Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<char>>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, encoding: Encoding_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharWriter_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.AsyncCharWriter Output_Out)
        {
            var Output_0 = new n7.AsyncCharWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.AsyncCharWriter Input__this__In, n9.IResourceProvider<n8.Stream> Input_In, n2.IObservable<n2.IObservable<n7.Chunk<char>>> Data_In, n11.Encodings Encoding_In, out n7.AsyncCharWriter Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<char>>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, data: Data_In, encoding: Encoding_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharChunkifier_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.AsyncCharChunkifier Output_Out)
        {
            var Output_0 = new n7.AsyncCharChunkifier();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.AsyncCharChunkifier Input__this__In, n2.IObservable<string> Input_In, out n7.AsyncCharChunkifier Output_Out, out n2.IObservable<n2.IObservable<n7.Chunk<char>>> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.CharCollector_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context, out n7.AsyncCharCollector Output_Out)
        {
            var Output_0 = new n7.AsyncCharCollector();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.AsyncCharCollector Input__this__In, n2.IObservable<n2.IObservable<n7.Chunk<char>>> Input_In, out n7.AsyncCharCollector Output_Out, out n2.IObservable<string> Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Chunk.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n7.Chunk<T> CreateDefault<T>()
        {
            var Default_0 = n7.Chunk<T>.Default;
            return Default_0;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Net.Advanced
{
    [n1.ElementAttribute(TracingId = 241577U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "I4nudrDB0zZLgxuS5DE6uV", Name = "IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV")]
    [n2.SerializableAttribute]
    public class IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV Create(n1.NodeContext Node_Context)
        {
            var instance = new IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV CreateDefault()
        {
            var instance = new IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV Update(string Host_Name_Or_Address_In, int Port_In, out n2.IObservable<n5.IPEndPoint> Output_Out)
        {
            var Output_2 = this.__p_P16aO3igdImLRORM14Gmgz.Update(Value_In: Host_Name_Or_Address_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var Output_5 = this.__p_PE4Tp6NWQahOpkOzULr4Vr.Update(Value_In: Port_In, Result_Out: out bool Result_3, Unchanged_Out: out bool Unchanged_4);
            var Output_6 = Result_0 || Result_3;
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_MlNYoErcariN0z0LfBlt63.Update<n2.IObservable<n5.IPEndPoint>, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Send_In: Output_6, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                var Result_9 = n14.NetUtils.GetIPEndPointAsync(hostNameOrAddress: Host_Name_Or_Address_In, port: Port_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<n5.IPEndPoint> Result_10);
            Output_Out = Result_10;
            n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_2 != this.__p_P16aO3igdImLRORM14Gmgz || Output_5 != this.__p_PE4Tp6NWQahOpkOzULr4Vr || Output_11 != this.__p_MlNYoErcariN0z0LfBlt63 ? new IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(this)
                {__p_P16aO3igdImLRORM14Gmgz = Output_2, __p_PE4Tp6NWQahOpkOzULr4Vr = Output_5, __p_MlNYoErcariN0z0LfBlt63 = Output_11} : that_12;
            else
            {
                this.__p_P16aO3igdImLRORM14Gmgz = Output_2;
                this.__p_PE4Tp6NWQahOpkOzULr4Vr = Output_5;
                this.__p_MlNYoErcariN0z0LfBlt63 = Output_11;
            }

            return that_12;
        }

        public n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "P16aO3igdImLRORM14Gmgz", 241582U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n17.Changed_A8JGbead2bxNdnPybiEqVS<string>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "PE4Tp6NWQahOpkOzULr4Vr", 241590U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n17.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "MlNYoErcariN0z0LfBlt63", 241595U);
            var Output_7 = n18.ToObservable_Switch_Factory_C<n5.IPEndPoint>.Create(Node_Context: Node_Context_6);
            n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV that_8 = this;
            this.__p_P16aO3igdImLRORM14Gmgz = Output_2;
            this.__p_PE4Tp6NWQahOpkOzULr4Vr = Output_5;
            this.__p_MlNYoErcariN0z0LfBlt63 = Output_7;
            return that_8;
        }

        public n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV __CreateDefault__()
        {
            n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV that_0 = this;
            this.__p_P16aO3igdImLRORM14Gmgz = n17.Changed_A8JGbead2bxNdnPybiEqVS<string>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            this.__p_PE4Tp6NWQahOpkOzULr4Vr = n17.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            this.__p_MlNYoErcariN0z0LfBlt63 = n18.ToObservable_Switch_Factory_C<n5.IPEndPoint>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_P16aO3igdImLRORM14Gmgz);
            n1.CompilationHelper.SafeDispose(this.__p_PE4Tp6NWQahOpkOzULr4Vr);
            n1.CompilationHelper.SafeDispose(this.__p_MlNYoErcariN0z0LfBlt63);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 241582U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "P16aO3igdImLRORM14Gmgz", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n17.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_P16aO3igdImLRORM14Gmgz;
        [n1.ElementAttribute(TracingId = 241590U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "PE4Tp6NWQahOpkOzULr4Vr", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n17.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_PE4Tp6NWQahOpkOzULr4Vr;
        [n1.ElementAttribute(TracingId = 241595U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MlNYoErcariN0z0LfBlt63", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n18.ToObservable_Switch_Factory_C<n5.IPEndPoint> __p_MlNYoErcariN0z0LfBlt63;
        public IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV other): base(other)
        {
            this.__p_P16aO3igdImLRORM14Gmgz = other.__p_P16aO3igdImLRORM14Gmgz;
            this.__p_PE4Tp6NWQahOpkOzULr4Vr = other.__p_PE4Tp6NWQahOpkOzULr4Vr;
            this.__p_MlNYoErcariN0z0LfBlt63 = other.__p_MlNYoErcariN0z0LfBlt63;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_P16aO3igdImLRORM14Gmgz", in __p_P16aO3igdImLRORM14Gmgz), n1.CompilationHelper.GetValueOrExisting(values, "__p_PE4Tp6NWQahOpkOzULr4Vr", in __p_PE4Tp6NWQahOpkOzULr4Vr), n1.CompilationHelper.GetValueOrExisting(values, "__p_MlNYoErcariN0z0LfBlt63", in __p_MlNYoErcariN0z0LfBlt63));
        }

        internal IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV __WITH__(n17.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_P16aO3igdImLRORM14Gmgz, n17.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_PE4Tp6NWQahOpkOzULr4Vr, n18.ToObservable_Switch_Factory_C<n5.IPEndPoint> __p_MlNYoErcariN0z0LfBlt63)
        {
            n13.IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_P16aO3igdImLRORM14Gmgz != this.__p_P16aO3igdImLRORM14Gmgz || __p_PE4Tp6NWQahOpkOzULr4Vr != this.__p_PE4Tp6NWQahOpkOzULr4Vr || __p_MlNYoErcariN0z0LfBlt63 != this.__p_MlNYoErcariN0z0LfBlt63 ? new IPEndPointResolver_I4nudrDB0zZLgxuS5DE6uV(this)
                {__p_P16aO3igdImLRORM14Gmgz = __p_P16aO3igdImLRORM14Gmgz, __p_PE4Tp6NWQahOpkOzULr4Vr = __p_PE4Tp6NWQahOpkOzULr4Vr, __p_MlNYoErcariN0z0LfBlt63 = __p_MlNYoErcariN0z0LfBlt63} : that_0;
            else
            {
                this.__p_P16aO3igdImLRORM14Gmgz = __p_P16aO3igdImLRORM14Gmgz;
                this.__p_PE4Tp6NWQahOpkOzULr4Vr = __p_PE4Tp6NWQahOpkOzULr4Vr;
                this.__p_MlNYoErcariN0z0LfBlt63 = __p_MlNYoErcariN0z0LfBlt63;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 242104U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "LFQAAxLFDLrLGEmZiQz7To", Name = "IPEndPoint_LFQAAxLFDLrLGEmZiQz7To")]
    [n2.SerializableAttribute]
    public class IPEndPoint_LFQAAxLFDLrLGEmZiQz7To : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To Create(n1.NodeContext Node_Context)
        {
            var instance = new IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To CreateDefault()
        {
            var instance = new IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To Update(n5.IPAddress Address_In, int Port_In, out n5.IPEndPoint Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_KxEmfHB5NkuO09mZeHaIDf;
            if (manager_2 is null)
            {
                manager_2 = new n19.Manager<n2.ValueTuple<n5.IPAddress, int>, n2.ValueTuple<n5.IPEndPoint>>(n2.ValueTuple.Create(default(n5.IPEndPoint)));
            }

            var inputs_3 = (Address_In, Port_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_7 = new n5.IPEndPoint(address: Address_In, port: Port_In);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_KxEmfHB5NkuO09mZeHaIDf ? new IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(this)
                {__cache_KxEmfHB5NkuO09mZeHaIDf = manager_2} : that_9;
            else
            {
                this.__cache_KxEmfHB5NkuO09mZeHaIDf = manager_2;
            }

            return that_9;
        }

        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To that_0 = this;
            this.__cache_KxEmfHB5NkuO09mZeHaIDf = null;
            return that_0;
        }

        public n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __CreateDefault__()
        {
            n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To that_0 = this;
            this.__cache_KxEmfHB5NkuO09mZeHaIDf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KxEmfHB5NkuO09mZeHaIDf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 242110U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "KxEmfHB5NkuO09mZeHaIDf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n5.IPAddress, int>, n2.ValueTuple<n5.IPEndPoint>> __cache_KxEmfHB5NkuO09mZeHaIDf = null;
        public IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(IPEndPoint_LFQAAxLFDLrLGEmZiQz7To other): base(other)
        {
            this.__cache_KxEmfHB5NkuO09mZeHaIDf = other.__cache_KxEmfHB5NkuO09mZeHaIDf;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KxEmfHB5NkuO09mZeHaIDf", in __cache_KxEmfHB5NkuO09mZeHaIDf));
        }

        internal IPEndPoint_LFQAAxLFDLrLGEmZiQz7To __WITH__(n19.Manager<n2.ValueTuple<n5.IPAddress, int>, n2.ValueTuple<n5.IPEndPoint>> __cache_KxEmfHB5NkuO09mZeHaIDf)
        {
            n13.IPEndPoint_LFQAAxLFDLrLGEmZiQz7To that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KxEmfHB5NkuO09mZeHaIDf != this.__cache_KxEmfHB5NkuO09mZeHaIDf ? new IPEndPoint_LFQAAxLFDLrLGEmZiQz7To(this)
                {__cache_KxEmfHB5NkuO09mZeHaIDf = __cache_KxEmfHB5NkuO09mZeHaIDf} : that_0;
            else
            {
                this.__cache_KxEmfHB5NkuO09mZeHaIDf = __cache_KxEmfHB5NkuO09mZeHaIDf;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 242141U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MLeJfL0KehEPTxpNGNIs8m", Name = "IPAddress_MLeJfL0KehEPTxpNGNIs8m")]
    [n2.SerializableAttribute]
    public class IPAddress_MLeJfL0KehEPTxpNGNIs8m : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m Create(n1.NodeContext Node_Context)
        {
            var instance = new IPAddress_MLeJfL0KehEPTxpNGNIs8m(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m CreateDefault()
        {
            var instance = new IPAddress_MLeJfL0KehEPTxpNGNIs8m(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m Update([n4.SerializedDefaultValueAttribute("0.0.0.0", false)] string Input_In, out n5.IPAddress Result_Out, out bool Is_Valid_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_DLCKEX058XqPqfNLakhGS2;
            if (manager_2 is null)
            {
                manager_2 = new n19.Manager<n2.ValueTuple<string>, n2.ValueTuple<n5.IPAddress, bool>>((default(n5.IPAddress), false));
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Result_8 = n5.IPAddress.TryParse(ipString: Input_In, address: out n5.IPAddress Address_7);
                var Any_9 = n5.IPAddress.Any;
                n20._Operations_.Switch_Boolean<n5.IPAddress>(Condition_In: Result_8, Input_In: Any_9, Input_2_In: Address_7, Output_Out: out n5.IPAddress Output_10);
                outputs_4 = (Output_10, Result_8);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_11, __auto_12) = outputs_4;
            Result_Out = __auto_11;
            Is_Valid_Out = __auto_12;
            n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = manager_2 != this.__cache_DLCKEX058XqPqfNLakhGS2 ? new IPAddress_MLeJfL0KehEPTxpNGNIs8m(this)
                {__cache_DLCKEX058XqPqfNLakhGS2 = manager_2} : that_13;
            else
            {
                this.__cache_DLCKEX058XqPqfNLakhGS2 = manager_2;
            }

            return that_13;
        }

        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m that_0 = this;
            this.__cache_DLCKEX058XqPqfNLakhGS2 = null;
            return that_0;
        }

        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __CreateDefault__()
        {
            n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m that_0 = this;
            this.__cache_DLCKEX058XqPqfNLakhGS2 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DLCKEX058XqPqfNLakhGS2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 242147U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "DLCKEX058XqPqfNLakhGS2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<string>, n2.ValueTuple<n5.IPAddress, bool>> __cache_DLCKEX058XqPqfNLakhGS2 = null;
        public IPAddress_MLeJfL0KehEPTxpNGNIs8m(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPAddress_MLeJfL0KehEPTxpNGNIs8m(IPAddress_MLeJfL0KehEPTxpNGNIs8m other): base(other)
        {
            this.__cache_DLCKEX058XqPqfNLakhGS2 = other.__cache_DLCKEX058XqPqfNLakhGS2;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DLCKEX058XqPqfNLakhGS2", in __cache_DLCKEX058XqPqfNLakhGS2));
        }

        internal IPAddress_MLeJfL0KehEPTxpNGNIs8m __WITH__(n19.Manager<n2.ValueTuple<string>, n2.ValueTuple<n5.IPAddress, bool>> __cache_DLCKEX058XqPqfNLakhGS2)
        {
            n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DLCKEX058XqPqfNLakhGS2 != this.__cache_DLCKEX058XqPqfNLakhGS2 ? new IPAddress_MLeJfL0KehEPTxpNGNIs8m(this)
                {__cache_DLCKEX058XqPqfNLakhGS2 = __cache_DLCKEX058XqPqfNLakhGS2} : that_0;
            else
            {
                this.__cache_DLCKEX058XqPqfNLakhGS2 = __cache_DLCKEX058XqPqfNLakhGS2;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 242468U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "IMxwVok0gkqQG3e3tXC736", Name = "NetworkInterfaces_IMxwVok0gkqQG3e3tXC736")]
    [n2.SerializableAttribute]
    public class NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 Create(n1.NodeContext Node_Context)
        {
            var instance = new NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 CreateDefault()
        {
            var instance = new NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 Update(bool Update_In, [n4.SerializedDefaultValueAttribute("Wireless80211", false)] n21.NetworkInterfaceType Type_In, out n12.Spread<string> Address_Out, out n12.Spread<string> Name_Out, out n12.Spread<string> Description_Out, out n12.Spread<bool> Is_Up_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_Umv9LIJGB8VNiYBeRUkwSf;
            if (manager_1 is null)
            {
                manager_1 = new n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>>((n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<bool>()));
            }

            var inputs_2 = n2.ValueTuple.Create(Type_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Update_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__TesmdratTUOLHcUmFiC2nW>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __TesmdratTUOLHcUmFiC2nW(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_DZB7vki9s0NMkHSxOwVDSu = n22._Operations_.CreateDefault<n12.Spread<string>>(), __cp_UE5249XenX0N0ruPyEiPkW = n22._Operations_.CreateDefault<string>(), __cp_LXkNF7Wd5CULk689E9aYKT = n22._Operations_.CreateDefault<string>(), __cp_DZYTCkIbG56Ourh1RPB9c7 = n22._Operations_.CreateDefault<bool>()};
                }

                var Result_6 = n21.NetworkInterface.GetAllNetworkInterfaces();
                var manager_37 = state_5.__loop_NuSrbadcaQIMMsxt39SKuP ?? new n26.ImmutableLifetimeManager();
                var iterator_38 = manager_37.GetIterator(__GetContext__());
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_5.__cp_DZB7vki9s0NMkHSxOwVDSu, 16);
                n12.Spread<n12.Spread<string>> output_40;
                var builder_41 = n4.CollectionBuilders.GetBuilder(state_5.__cp_UE5249XenX0N0ruPyEiPkW, 16);
                n12.Spread<string> output_42;
                var builder_43 = n4.CollectionBuilders.GetBuilder(state_5.__cp_LXkNF7Wd5CULk689E9aYKT, 16);
                n12.Spread<string> output_44;
                var builder_45 = n4.CollectionBuilders.GetBuilder(state_5.__cp_DZYTCkIbG56Ourh1RPB9c7, 16);
                n12.Spread<bool> output_46;
                try
                {
                    var i_9 = 0;
                    foreach (var item_7 in Result_6)
                    {
                        var splicer_8 = item_7;
                        var i_local_10 = i_9;
                        __BHY6rgPzQcuOan0QvWfF68 state_11;
                        if (!iterator_38.MoveNext(out state_11))
                        {
                            iterator_38.Add(state_11 = new __BHY6rgPzQcuOan0QvWfF68(__GetContext__(), n1.VLObject.NewIdentity())
                            {__cp_N9wCdK66KNjLGokRP86H85 = n22._Operations_.CreateDefault<string>()});
                        }

                        n21.OperationalStatus __pad_JGdzHTcqYjgMudfQN10sdx_12 = __slot_JGdzHTcqYjgMudfQN10sdx;
                        var Result_13 = splicer_8.GetIPProperties();
                        var Name_14 = splicer_8.Name;
                        var Description_15 = splicer_8.Description;
                        var Network_Interface_Type_16 = splicer_8.NetworkInterfaceType;
                        var Result_17 = Network_Interface_Type_16 == Type_In;
                        var Gateway_Addresses_18 = Result_13.GatewayAddresses;
                        n10.IEnumerable<n21.GatewayIPAddressInformation> Input_19 = (n10.IEnumerable<n21.GatewayIPAddressInformation>)Gateway_Addresses_18;
                        n23._Operations_.Any<n21.GatewayIPAddressInformation>(Input_In: Input_19, Result_Out: out bool Result_20);
                        var Output_21 = Result_17 && Result_20;
                        var Unicast_Addresses_22 = Result_13.UnicastAddresses;
                        var builder_33 = n4.CollectionBuilders.GetBuilder(state_11.__cp_N9wCdK66KNjLGokRP86H85, 16);
                        n12.Spread<string> output_34;
                        try
                        {
                            var i_25 = 0;
                            foreach (var item_23 in Unicast_Addresses_22)
                            {
                                var splicer_24 = item_23;
                                var i_local_26 = i_25;
                                var Address_28 = splicer_24.Address;
                                var Address_Family_29 = Address_28.AddressFamily;
                                n24.AddressFamily Input_2_30 = __c_BAWPjO3pX65OaPSICl6fux;
                                var Result_31 = Address_Family_29 == Input_2_30;
                                var Result_32 = Address_28.ToString();
                                if (Result_31)
                                {
                                    builder_33.Add(Result_32);
                                }

                                i_25++;
                            }
                        }
                        finally
                        {
                            output_34 = builder_33.Commit();
                        }

                        var Operational_Status_35 = splicer_8.OperationalStatus;
                        var Result_36 = Operational_Status_35 == __pad_JGdzHTcqYjgMudfQN10sdx_12;
                        if (state_11.__GetContext__().IsImmutable)
                            state_11 = output_34 != state_11.__cp_N9wCdK66KNjLGokRP86H85 ? new __BHY6rgPzQcuOan0QvWfF68(state_11)
                            {__cp_N9wCdK66KNjLGokRP86H85 = output_34} : state_11;
                        else
                        {
                            state_11.__cp_N9wCdK66KNjLGokRP86H85 = output_34;
                        }

                        iterator_38.Update(state_11);
                        if (Output_21)
                        {
                            builder_39.Add(output_34);
                            builder_41.Add(Name_14);
                            builder_43.Add(Description_15);
                            builder_45.Add(Result_36);
                        }
                        else
                            iterator_38.Remove();
                        i_9++;
                    }
                }
                finally
                {
                    manager_37 = iterator_38.Commit();
                    output_40 = builder_39.Commit();
                    output_42 = builder_41.Commit();
                    output_44 = builder_43.Commit();
                    output_46 = builder_45.Commit();
                }

                n22._Operations_.Flatten<n12.Spread<n12.Spread<string>>, string>(Input_In: output_40, Output_Out: out n12.Spread<string> Output_47);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = manager_37 != state_5.__loop_NuSrbadcaQIMMsxt39SKuP || output_40 != state_5.__cp_DZB7vki9s0NMkHSxOwVDSu || output_42 != state_5.__cp_UE5249XenX0N0ruPyEiPkW || output_44 != state_5.__cp_LXkNF7Wd5CULk689E9aYKT || output_46 != state_5.__cp_DZYTCkIbG56Ourh1RPB9c7 ? new __TesmdratTUOLHcUmFiC2nW(state_5)
                    {__loop_NuSrbadcaQIMMsxt39SKuP = manager_37, __cp_DZB7vki9s0NMkHSxOwVDSu = output_40, __cp_UE5249XenX0N0ruPyEiPkW = output_42, __cp_LXkNF7Wd5CULk689E9aYKT = output_44, __cp_DZYTCkIbG56Ourh1RPB9c7 = output_46} : state_5;
                else
                {
                    state_5.__loop_NuSrbadcaQIMMsxt39SKuP = manager_37;
                    state_5.__cp_DZB7vki9s0NMkHSxOwVDSu = output_40;
                    state_5.__cp_UE5249XenX0N0ruPyEiPkW = output_42;
                    state_5.__cp_LXkNF7Wd5CULk689E9aYKT = output_44;
                    state_5.__cp_DZYTCkIbG56Ourh1RPB9c7 = output_46;
                }

                outputs_3 = (Output_47, output_42, output_44, output_46);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var(__auto_48, __auto_49, __auto_50, __auto_51) = outputs_3;
            Address_Out = __auto_48;
            Name_Out = __auto_49;
            Description_Out = __auto_50;
            Is_Up_Out = __auto_51;
            n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 that_52 = this;
            if (this.__GetContext__().IsImmutable)
                that_52 = manager_1 != this.__cache_Umv9LIJGB8VNiYBeRUkwSf ? new NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(this)
                {__cache_Umv9LIJGB8VNiYBeRUkwSf = manager_1} : that_52;
            else
            {
                this.__cache_Umv9LIJGB8VNiYBeRUkwSf = manager_1;
            }

            return that_52;
        }

        public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 that_0 = this;
            this.__cache_Umv9LIJGB8VNiYBeRUkwSf = null;
            return that_0;
        }

        public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __CreateDefault__()
        {
            n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 that_0 = this;
            this.__cache_Umv9LIJGB8VNiYBeRUkwSf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Umv9LIJGB8VNiYBeRUkwSf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 242471U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Umv9LIJGB8VNiYBeRUkwSf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>> __cache_Umv9LIJGB8VNiYBeRUkwSf = null;
        [n1.ElementAttribute(TracingId = 242711U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JGdzHTcqYjgMudfQN10sdx", Name = "__slot_JGdzHTcqYjgMudfQN10sdx")]
        public static n21.OperationalStatus __slot_JGdzHTcqYjgMudfQN10sdx = n1.CompilationHelper.Deserialize<n21.OperationalStatus>("Up", false, "PcdEIeqrXeZQCL5lc35ctR", "JGdzHTcqYjgMudfQN10sdx");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.AddressFamily __c_BAWPjO3pX65OaPSICl6fux = n1.CompilationHelper.Deserialize<n24.AddressFamily>("InterNetwork", false, "PcdEIeqrXeZQCL5lc35ctR", "BAWPjO3pX65OaPSICl6fux");
        static NetworkInterfaces_IMxwVok0gkqQG3e3tXC736()
        {
        }

        public NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 other): base(other)
        {
            this.__cache_Umv9LIJGB8VNiYBeRUkwSf = other.__cache_Umv9LIJGB8VNiYBeRUkwSf;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Umv9LIJGB8VNiYBeRUkwSf", in __cache_Umv9LIJGB8VNiYBeRUkwSf));
        }

        internal NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __WITH__(n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>> __cache_Umv9LIJGB8VNiYBeRUkwSf)
        {
            n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Umv9LIJGB8VNiYBeRUkwSf != this.__cache_Umv9LIJGB8VNiYBeRUkwSf ? new NetworkInterfaces_IMxwVok0gkqQG3e3tXC736(this)
                {__cache_Umv9LIJGB8VNiYBeRUkwSf = __cache_Umv9LIJGB8VNiYBeRUkwSf} : that_0;
            else
            {
                this.__cache_Umv9LIJGB8VNiYBeRUkwSf = __cache_Umv9LIJGB8VNiYBeRUkwSf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "TesmdratTUOLHcUmFiC2nW", Name = "__TesmdratTUOLHcUmFiC2nW")]
        [n2.SerializableAttribute]
        public class __TesmdratTUOLHcUmFiC2nW : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_NuSrbadcaQIMMsxt39SKuP);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n26.ImmutableLifetimeManager __loop_NuSrbadcaQIMMsxt39SKuP;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n12.Spread<string>> __cp_DZB7vki9s0NMkHSxOwVDSu;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<string> __cp_UE5249XenX0N0ruPyEiPkW;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<string> __cp_LXkNF7Wd5CULk689E9aYKT;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<bool> __cp_DZYTCkIbG56Ourh1RPB9c7;
            public __TesmdratTUOLHcUmFiC2nW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TesmdratTUOLHcUmFiC2nW(__TesmdratTUOLHcUmFiC2nW other): base(other)
            {
                this.__loop_NuSrbadcaQIMMsxt39SKuP = other.__loop_NuSrbadcaQIMMsxt39SKuP;
                this.__cp_DZB7vki9s0NMkHSxOwVDSu = other.__cp_DZB7vki9s0NMkHSxOwVDSu;
                this.__cp_UE5249XenX0N0ruPyEiPkW = other.__cp_UE5249XenX0N0ruPyEiPkW;
                this.__cp_LXkNF7Wd5CULk689E9aYKT = other.__cp_LXkNF7Wd5CULk689E9aYKT;
                this.__cp_DZYTCkIbG56Ourh1RPB9c7 = other.__cp_DZYTCkIbG56Ourh1RPB9c7;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_NuSrbadcaQIMMsxt39SKuP", in __loop_NuSrbadcaQIMMsxt39SKuP), n1.CompilationHelper.GetValueOrExisting(values, "__cp_DZB7vki9s0NMkHSxOwVDSu", in __cp_DZB7vki9s0NMkHSxOwVDSu), n1.CompilationHelper.GetValueOrExisting(values, "__cp_UE5249XenX0N0ruPyEiPkW", in __cp_UE5249XenX0N0ruPyEiPkW), n1.CompilationHelper.GetValueOrExisting(values, "__cp_LXkNF7Wd5CULk689E9aYKT", in __cp_LXkNF7Wd5CULk689E9aYKT), n1.CompilationHelper.GetValueOrExisting(values, "__cp_DZYTCkIbG56Ourh1RPB9c7", in __cp_DZYTCkIbG56Ourh1RPB9c7));
            }

            internal __TesmdratTUOLHcUmFiC2nW __WITH__(n26.ImmutableLifetimeManager __loop_NuSrbadcaQIMMsxt39SKuP, n12.Spread<n12.Spread<string>> __cp_DZB7vki9s0NMkHSxOwVDSu, n12.Spread<string> __cp_UE5249XenX0N0ruPyEiPkW, n12.Spread<string> __cp_LXkNF7Wd5CULk689E9aYKT, n12.Spread<bool> __cp_DZYTCkIbG56Ourh1RPB9c7)
            {
                __TesmdratTUOLHcUmFiC2nW that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_NuSrbadcaQIMMsxt39SKuP != this.__loop_NuSrbadcaQIMMsxt39SKuP || __cp_DZB7vki9s0NMkHSxOwVDSu != this.__cp_DZB7vki9s0NMkHSxOwVDSu || __cp_UE5249XenX0N0ruPyEiPkW != this.__cp_UE5249XenX0N0ruPyEiPkW || __cp_LXkNF7Wd5CULk689E9aYKT != this.__cp_LXkNF7Wd5CULk689E9aYKT || __cp_DZYTCkIbG56Ourh1RPB9c7 != this.__cp_DZYTCkIbG56Ourh1RPB9c7 ? new __TesmdratTUOLHcUmFiC2nW(this)
                    {__loop_NuSrbadcaQIMMsxt39SKuP = __loop_NuSrbadcaQIMMsxt39SKuP, __cp_DZB7vki9s0NMkHSxOwVDSu = __cp_DZB7vki9s0NMkHSxOwVDSu, __cp_UE5249XenX0N0ruPyEiPkW = __cp_UE5249XenX0N0ruPyEiPkW, __cp_LXkNF7Wd5CULk689E9aYKT = __cp_LXkNF7Wd5CULk689E9aYKT, __cp_DZYTCkIbG56Ourh1RPB9c7 = __cp_DZYTCkIbG56Ourh1RPB9c7} : that_0;
                else
                {
                    this.__loop_NuSrbadcaQIMMsxt39SKuP = __loop_NuSrbadcaQIMMsxt39SKuP;
                    this.__cp_DZB7vki9s0NMkHSxOwVDSu = __cp_DZB7vki9s0NMkHSxOwVDSu;
                    this.__cp_UE5249XenX0N0ruPyEiPkW = __cp_UE5249XenX0N0ruPyEiPkW;
                    this.__cp_LXkNF7Wd5CULk689E9aYKT = __cp_LXkNF7Wd5CULk689E9aYKT;
                    this.__cp_DZYTCkIbG56Ourh1RPB9c7 = __cp_DZYTCkIbG56Ourh1RPB9c7;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BHY6rgPzQcuOan0QvWfF68", Name = "__BHY6rgPzQcuOan0QvWfF68")]
        [n2.SerializableAttribute]
        public class __BHY6rgPzQcuOan0QvWfF68 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<string> __cp_N9wCdK66KNjLGokRP86H85;
            public __BHY6rgPzQcuOan0QvWfF68(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BHY6rgPzQcuOan0QvWfF68(__BHY6rgPzQcuOan0QvWfF68 other): base(other)
            {
                this.__cp_N9wCdK66KNjLGokRP86H85 = other.__cp_N9wCdK66KNjLGokRP86H85;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_N9wCdK66KNjLGokRP86H85", in __cp_N9wCdK66KNjLGokRP86H85));
            }

            internal __BHY6rgPzQcuOan0QvWfF68 __WITH__(n12.Spread<string> __cp_N9wCdK66KNjLGokRP86H85)
            {
                __BHY6rgPzQcuOan0QvWfF68 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_N9wCdK66KNjLGokRP86H85 != this.__cp_N9wCdK66KNjLGokRP86H85 ? new __BHY6rgPzQcuOan0QvWfF68(this)
                    {__cp_N9wCdK66KNjLGokRP86H85 = __cp_N9wCdK66KNjLGokRP86H85} : that_0;
                else
                {
                    this.__cp_N9wCdK66KNjLGokRP86H85 = __cp_N9wCdK66KNjLGokRP86H85;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void DefaultAddress(out n5.IPAddress Default_Address_Out)
        {
            var Default_Address_0 = n14.NetUtils.DefaultAddress;
            Default_Address_Out = Default_Address_0;
            return;
        }

        public static void DefaultIPEndPoint(out n5.IPEndPoint Default_IPEnd_Point_Out)
        {
            var Default_IPEnd_Point_0 = n14.NetUtils.DefaultIPEndPoint;
            Default_IPEnd_Point_Out = Default_IPEnd_Point_0;
            return;
        }

        public static void GetHostAddresses([n4.SerializedDefaultValueAttribute("localhost", false)] string Host_Name_Or_Address_In, out n12.Spread<n5.IPAddress> Result_Out)
        {
            var Result_0 = n14.NetUtils.GetHostAddresses(hostNameOrAddress: Host_Name_Or_Address_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetHostAddressesAsync([n4.SerializedDefaultValueAttribute("localhost", false)] string Host_Name_Or_Address_In, out n2.IObservable<n12.Spread<n5.IPAddress>> Result_Out)
        {
            var Result_0 = n14.NetUtils.GetHostAddressesAsync(hostNameOrAddress: Host_Name_Or_Address_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetIPEndPointAsync(string Host_Name_Or_Address_In, int Port_In, out n2.IObservable<n5.IPEndPoint> Result_Out)
        {
            var Result_0 = n14.NetUtils.GetIPEndPointAsync(hostNameOrAddress: Host_Name_Or_Address_In, port: Port_In);
            Result_Out = Result_0;
            return;
        }

        public static void WOL([n4.SerializedDefaultValueAttribute("00:00:00:00:00:00", false)] string MAC_Address_In, out n10.IEnumerable<byte> WOL_Out, out bool Valid_Out)
        {
            n12.Spread<byte> __cp_G2LmcTsRGzFM8xEhkQPk38 = n22._Operations_.CreateDefault<byte>();
            int __pad_AIyGOSIOPwiOKWSJ3JRTSO_0 = __slot_AIyGOSIOPwiOKWSJ3JRTSO;
            string __pad_AZ2yWDtHxgKM9yEHpSQrMH_1 = __slot_AZ2yWDtHxgKM9yEHpSQrMH;
            int __pad_AAJyFVxLDknMt65GmHO2xl_2 = __slot_AAJyFVxLDknMt65GmHO2xl;
            int __pad_K2X1aWqKGbbPbAa5AXuUWd_3 = __slot_K2X1aWqKGbbPbAa5AXuUWd;
            byte __pad_HHPCuR2IbSGL4UIDkbEwR2_4 = __slot_HHPCuR2IbSGL4UIDkbEwR2;
            int __pad_NyArGG12JNhOWj7zrKZbLn_5 = __slot_NyArGG12JNhOWj7zrKZbLn;
            var Chars_6 = MAC_Address_In[__pad_AIyGOSIOPwiOKWSJ3JRTSO_0];
            var Result_7 = char.ToString(c: Chars_6);
            n2.StringSplitOptions Options_8 = default(n2.StringSplitOptions);
            n61._Operations_.Split_String(Input_In: MAC_Address_In, Separator_In: Result_7, Options_In: Options_8, Output_Out: out n12.Spread<string> Output_9);
            var Output_10 = n62.StringExtensions.Plus(input: Result_7, input2: __pad_AZ2yWDtHxgKM9yEHpSQrMH_1);
            n63._Operations_.TryParse_Hex(Input_In: Output_10, Success_Out: out bool Success_11, Value_Out: out byte Value_12);
            n12.Spread<string> Output_13;
            if (Success_11)
            {
                int __pad_Eocu89hr9d1P2a110IVWqy_14 = __slot_Eocu89hr9d1P2a110IVWqy;
                n61._Operations_.Split_Count(Input_In: MAC_Address_In, Count_In: __pad_Eocu89hr9d1P2a110IVWqy_14, Substrings_Out: out n12.Spread<string> Substrings_15);
                Output_13 = Substrings_15;
            }
            else
            {
                Output_13 = Output_9;
            }

            var builder_22 = n4.CollectionBuilders.GetBuilder(__cp_G2LmcTsRGzFM8xEhkQPk38, 16);
            n12.Spread<byte> output_23;
            try
            {
                var i_18 = 0;
                foreach (var item_16 in n4.CollectionExtensions.AsSpan(Output_13))
                {
                    var splicer_17 = item_16;
                    var i_local_19 = i_18;
                    n63._Operations_.TryParse_Hex(Input_In: splicer_17, Success_Out: out bool Success_20, Value_Out: out byte Value_21);
                    if (Success_20)
                    {
                        builder_22.Add(Value_21);
                    }

                    i_18++;
                }
            }
            finally
            {
                output_23 = builder_22.Commit();
            }

            n23._Operations_.Repeat<n12.Spread<byte>>(Element_In: output_23, Count_In: __pad_K2X1aWqKGbbPbAa5AXuUWd_3, Result_Out: out n10.IEnumerable<n12.Spread<byte>> Result_24);
            n22._Operations_.Flatten<n10.IEnumerable<n12.Spread<byte>>, byte>(Input_In: Result_24, Output_Out: out n12.Spread<byte> Output_25);
            n10.IEnumerable<byte> Input_2_26 = (n10.IEnumerable<byte>)Output_25;
            n23._Operations_.Repeat<byte>(Element_In: __pad_HHPCuR2IbSGL4UIDkbEwR2_4, Count_In: __pad_AAJyFVxLDknMt65GmHO2xl_2, Result_Out: out n10.IEnumerable<byte> Result_27);
            n23._Operations_.Concat<byte>(Input_In: Result_27, Input_2_In: Input_2_26, Output_Out: out n10.IEnumerable<byte> Output_28);
            n10.IEnumerable<byte> Input_29 = (n10.IEnumerable<byte>)Output_25;
            n23._Operations_.Count<byte>(Input_In: Input_29, Result_Out: out int Result_30);
            var Result_31 = Result_30 == __pad_NyArGG12JNhOWj7zrKZbLn_5;
            WOL_Out = Output_28;
            Valid_Out = Result_31;
            return;
        }

        [n1.ElementAttribute(TracingId = 242204U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AIyGOSIOPwiOKWSJ3JRTSO", Name = "__slot_AIyGOSIOPwiOKWSJ3JRTSO")]
        public static int __slot_AIyGOSIOPwiOKWSJ3JRTSO = 2;
        [n1.ElementAttribute(TracingId = 242209U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AZ2yWDtHxgKM9yEHpSQrMH", Name = "__slot_AZ2yWDtHxgKM9yEHpSQrMH")]
        public static string __slot_AZ2yWDtHxgKM9yEHpSQrMH = "0";
        [n1.ElementAttribute(TracingId = 242211U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "AAJyFVxLDknMt65GmHO2xl", Name = "__slot_AAJyFVxLDknMt65GmHO2xl")]
        public static int __slot_AAJyFVxLDknMt65GmHO2xl = 6;
        [n1.ElementAttribute(TracingId = 242214U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "K2X1aWqKGbbPbAa5AXuUWd", Name = "__slot_K2X1aWqKGbbPbAa5AXuUWd")]
        public static int __slot_K2X1aWqKGbbPbAa5AXuUWd = 16;
        [n1.ElementAttribute(TracingId = 242217U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "HHPCuR2IbSGL4UIDkbEwR2", Name = "__slot_HHPCuR2IbSGL4UIDkbEwR2")]
        public static byte __slot_HHPCuR2IbSGL4UIDkbEwR2 = 255;
        [n1.ElementAttribute(TracingId = 242221U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "NyArGG12JNhOWj7zrKZbLn", Name = "__slot_NyArGG12JNhOWj7zrKZbLn")]
        public static int __slot_NyArGG12JNhOWj7zrKZbLn = 96;
        [n1.ElementAttribute(TracingId = 242336U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Eocu89hr9d1P2a110IVWqy", Name = "__slot_Eocu89hr9d1P2a110IVWqy")]
        public static int __slot_Eocu89hr9d1P2a110IVWqy = 2;
        static _Operations_()
        {
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Net.IPAddress.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TryParse(string Input_In, out bool Success_Out, out n5.IPAddress Address_Out)
        {
            var Result_1 = n5.IPAddress.TryParse(ipString: Input_In, address: out n5.IPAddress Address_0);
            Success_Out = Result_1;
            Address_Out = Address_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Net.IPEndPoint.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Join_IPAddress_Int32(n5.IPAddress Address_In, int Port_In, out n5.IPEndPoint Output_Out)
        {
            var Output_0 = new n5.IPEndPoint(address: Address_In, port: Port_In);
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Net.NetworkCredential.Advanced
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Create_String_String_String(string User_Name_In, string Password_In, string Domain_In, out n5.NetworkCredential Output_Out)
        {
            var Output_0 = new n5.NetworkCredential(userName: User_Name_In, password: Password_In, domain: Domain_In);
            Output_Out = Output_0;
            return;
        }

        public static void Create_String_String(string User_Name_In, string Password_In, out n5.NetworkCredential Output_Out)
        {
            var Output_0 = new n5.NetworkCredential(userName: User_Name_In, password: Password_In);
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.File
{
    [n1.ElementAttribute(TracingId = 235854U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n7.FileNode Output_Out)
        {
            var Output_0 = new n7.FileNode(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n7.FileNode Input_In, n37.Path File_Path_In, [n4.SerializedDefaultValueAttribute("OpenOrCreate", false)] n8.FileMode File_Mode_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileAccess File_Access_In, [n4.SerializedDefaultValueAttribute("Read", false)] n8.FileShare File_Share_In, out n7.FileNode Output_Out, out n9.IResourceProvider<n8.Stream> Result_Out)
        {
            var Result_0 = Input_In.Update(filePath: File_Path_In, fileMode: File_Mode_In, fileAccess: File_Access_In, fileShare: File_Share_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_IO_.IO.Net
{
    [n1.ElementAttribute(TracingId = 244396U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MOfJFeomvygPhh7bpt6VEW", Name = "IPs_Wifi_MOfJFeomvygPhh7bpt6VEW")]
    [n2.SerializableAttribute]
    public class IPs_Wifi_MOfJFeomvygPhh7bpt6VEW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW Create(n1.NodeContext Node_Context)
        {
            var instance = new IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW CreateDefault()
        {
            var instance = new IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW Update(bool Update_In, out n12.Spread<string> Address_Out, out n12.Spread<string> Name_Out, out n12.Spread<string> Description_Out, out n12.Spread<bool> Is_Up_Out)
        {
            n21.NetworkInterfaceType __pad_Shf9WAJPxmxQUWIZE1QluO_0 = __slot_Shf9WAJPxmxQUWIZE1QluO;
            var Output_5 = this.__p_JGGnt2GFZn4O9N14nuF4pu.Update(Update_In: Update_In, Type_In: __pad_Shf9WAJPxmxQUWIZE1QluO_0, Address_Out: out n12.Spread<string> Address_1, Name_Out: out n12.Spread<string> Name_2, Description_Out: out n12.Spread<string> Description_3, Is_Up_Out: out n12.Spread<bool> Is_Up_4);
            Address_Out = Address_1;
            Name_Out = Name_2;
            Description_Out = Description_3;
            Is_Up_Out = Is_Up_4;
            n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_JGGnt2GFZn4O9N14nuF4pu ? new IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(this)
                {__p_JGGnt2GFZn4O9N14nuF4pu = Output_5} : that_6;
            else
            {
                this.__p_JGGnt2GFZn4O9N14nuF4pu = Output_5;
            }

            return that_6;
        }

        public n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "JGGnt2GFZn4O9N14nuF4pu", 244413U);
            var Output_1 = n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736.Create(Node_Context: Node_Context_0);
            n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW that_2 = this;
            this.__p_JGGnt2GFZn4O9N14nuF4pu = Output_1;
            return that_2;
        }

        public n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW __CreateDefault__()
        {
            n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW that_0 = this;
            this.__p_JGGnt2GFZn4O9N14nuF4pu = n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JGGnt2GFZn4O9N14nuF4pu);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 244439U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Shf9WAJPxmxQUWIZE1QluO", Name = "__slot_Shf9WAJPxmxQUWIZE1QluO")]
        public static n21.NetworkInterfaceType __slot_Shf9WAJPxmxQUWIZE1QluO = n1.CompilationHelper.Deserialize<n21.NetworkInterfaceType>("Wireless80211", false, "PcdEIeqrXeZQCL5lc35ctR", "Shf9WAJPxmxQUWIZE1QluO");
        [n1.ElementAttribute(TracingId = 244413U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "JGGnt2GFZn4O9N14nuF4pu", Name = "NetworkInterfaces", IsManaged = true, IsAutoGenerated = true)]
        public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_JGGnt2GFZn4O9N14nuF4pu;
        static IPs_Wifi_MOfJFeomvygPhh7bpt6VEW()
        {
        }

        public IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(IPs_Wifi_MOfJFeomvygPhh7bpt6VEW other): base(other)
        {
            this.__p_JGGnt2GFZn4O9N14nuF4pu = other.__p_JGGnt2GFZn4O9N14nuF4pu;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JGGnt2GFZn4O9N14nuF4pu", in __p_JGGnt2GFZn4O9N14nuF4pu));
        }

        internal IPs_Wifi_MOfJFeomvygPhh7bpt6VEW __WITH__(n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_JGGnt2GFZn4O9N14nuF4pu)
        {
            n25.IPs_Wifi_MOfJFeomvygPhh7bpt6VEW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JGGnt2GFZn4O9N14nuF4pu != this.__p_JGGnt2GFZn4O9N14nuF4pu ? new IPs_Wifi_MOfJFeomvygPhh7bpt6VEW(this)
                {__p_JGGnt2GFZn4O9N14nuF4pu = __p_JGGnt2GFZn4O9N14nuF4pu} : that_0;
            else
            {
                this.__p_JGGnt2GFZn4O9N14nuF4pu = __p_JGGnt2GFZn4O9N14nuF4pu;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 244502U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Bka6gkmtoNRQc5HnTGexxa", Name = "IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa")]
    [n2.SerializableAttribute]
    public class IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa Create(n1.NodeContext Node_Context)
        {
            var instance = new IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa CreateDefault()
        {
            var instance = new IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa Update(bool Update_In, out n12.Spread<string> Address_Out, out n12.Spread<string> Name_Out, out n12.Spread<string> Description_Out, out n12.Spread<bool> Is_Up_Out)
        {
            n21.NetworkInterfaceType __pad_Df4cvBhvx65PljoTxXF5qO_0 = __slot_Df4cvBhvx65PljoTxXF5qO;
            var Output_5 = this.__p_R46NcEL3hkYMpbJaUrZ1pN.Update(Update_In: Update_In, Type_In: __pad_Df4cvBhvx65PljoTxXF5qO_0, Address_Out: out n12.Spread<string> Address_1, Name_Out: out n12.Spread<string> Name_2, Description_Out: out n12.Spread<string> Description_3, Is_Up_Out: out n12.Spread<bool> Is_Up_4);
            Address_Out = Address_1;
            Name_Out = Name_2;
            Description_Out = Description_3;
            Is_Up_Out = Is_Up_4;
            n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_R46NcEL3hkYMpbJaUrZ1pN ? new IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(this)
                {__p_R46NcEL3hkYMpbJaUrZ1pN = Output_5} : that_6;
            else
            {
                this.__p_R46NcEL3hkYMpbJaUrZ1pN = Output_5;
            }

            return that_6;
        }

        public n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "R46NcEL3hkYMpbJaUrZ1pN", 244510U);
            var Output_1 = n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736.Create(Node_Context: Node_Context_0);
            n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa that_2 = this;
            this.__p_R46NcEL3hkYMpbJaUrZ1pN = Output_1;
            return that_2;
        }

        public n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa __CreateDefault__()
        {
            n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa that_0 = this;
            this.__p_R46NcEL3hkYMpbJaUrZ1pN = n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_R46NcEL3hkYMpbJaUrZ1pN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 244526U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Df4cvBhvx65PljoTxXF5qO", Name = "__slot_Df4cvBhvx65PljoTxXF5qO")]
        public static n21.NetworkInterfaceType __slot_Df4cvBhvx65PljoTxXF5qO = n1.CompilationHelper.Deserialize<n21.NetworkInterfaceType>("Ethernet", false, "PcdEIeqrXeZQCL5lc35ctR", "Df4cvBhvx65PljoTxXF5qO");
        [n1.ElementAttribute(TracingId = 244510U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "R46NcEL3hkYMpbJaUrZ1pN", Name = "NetworkInterfaces", IsManaged = true, IsAutoGenerated = true)]
        public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_R46NcEL3hkYMpbJaUrZ1pN;
        static IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa()
        {
        }

        public IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa other): base(other)
        {
            this.__p_R46NcEL3hkYMpbJaUrZ1pN = other.__p_R46NcEL3hkYMpbJaUrZ1pN;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_R46NcEL3hkYMpbJaUrZ1pN", in __p_R46NcEL3hkYMpbJaUrZ1pN));
        }

        internal IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa __WITH__(n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_R46NcEL3hkYMpbJaUrZ1pN)
        {
            n25.IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_R46NcEL3hkYMpbJaUrZ1pN != this.__p_R46NcEL3hkYMpbJaUrZ1pN ? new IPs_Ethernet_Bka6gkmtoNRQc5HnTGexxa(this)
                {__p_R46NcEL3hkYMpbJaUrZ1pN = __p_R46NcEL3hkYMpbJaUrZ1pN} : that_0;
            else
            {
                this.__p_R46NcEL3hkYMpbJaUrZ1pN = __p_R46NcEL3hkYMpbJaUrZ1pN;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 244596U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SU385Q2zoCqLj1U3xPCyTo", Name = "IPs_SU385Q2zoCqLj1U3xPCyTo")]
    [n2.SerializableAttribute]
    public class IPs_SU385Q2zoCqLj1U3xPCyTo : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.IPs_SU385Q2zoCqLj1U3xPCyTo Create(n1.NodeContext Node_Context)
        {
            var instance = new IPs_SU385Q2zoCqLj1U3xPCyTo(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.IPs_SU385Q2zoCqLj1U3xPCyTo CreateDefault()
        {
            var instance = new IPs_SU385Q2zoCqLj1U3xPCyTo(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.IPs_SU385Q2zoCqLj1U3xPCyTo Update(bool Update_In, out n12.Spread<string> Address_Out, out n12.Spread<string> Name_Out, out n12.Spread<string> Description_Out, out n12.Spread<bool> Is_Up_Out)
        {
            n21.NetworkInterfaceType __pad_J1ChWvxWNjcLYrL8lfCvNf_0 = __slot_J1ChWvxWNjcLYrL8lfCvNf;
            n21.NetworkInterfaceType __pad_Ly2doyNjKuFMyUCDbBMirx_1 = __slot_Ly2doyNjKuFMyUCDbBMirx;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_B73QnNna6XUNaiokWNtGqN;
            if (manager_3 is null)
            {
                manager_3 = new n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType, n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>>((n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<string>(), n22._Operations_.CreateDefault<bool>()));
            }

            var inputs_4 = (__pad_J1ChWvxWNjcLYrL8lfCvNf_0, __pad_Ly2doyNjKuFMyUCDbBMirx_1);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Update_In || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__CQ1RI8RwEr2PSbY7M7iDIO>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __CQ1RI8RwEr2PSbY7M7iDIO(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = n22._Operations_.CreateDefault<n21.NetworkInterfaceType>(), __cp_HnKcqjLoBf5L1rfUY160HR = n22._Operations_.CreateDefault<n12.Spread<string>>(), __cp_RBMkpdU6PlGQUkGscJK6Lq = n22._Operations_.CreateDefault<n12.Spread<string>>(), __cp_ObpRNuj0YWJLEQrlc4Beuj = n22._Operations_.CreateDefault<n12.Spread<string>>(), __cp_J3EdAwPQK6dNFItZFk3f9G = n22._Operations_.CreateDefault<n12.Spread<bool>>()};
                }

                var builder_8 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs, 2);
                builder_8.Add(__pad_J1ChWvxWNjcLYrL8lfCvNf_0);
                builder_8.Add(__pad_Ly2doyNjKuFMyUCDbBMirx_1);
                var __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs_9 = builder_8.Commit();
                n22._Operations_.Cons<n21.NetworkInterfaceType>(Input_In: __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs_9, Result_Out: out n12.Spread<n21.NetworkInterfaceType> Result_10);
                var manager_24 = state_7.__loop_QiHRBCajjfzNsnxn5KOrAZ ?? new n26.ImmutableLifetimeManager();
                var iterator_25 = manager_24.GetIterator(__GetContext__());
                var builder_26 = n4.CollectionBuilders.GetBuilder(state_7.__cp_HnKcqjLoBf5L1rfUY160HR, 16);
                n12.Spread<n12.Spread<string>> output_27;
                var builder_28 = n4.CollectionBuilders.GetBuilder(state_7.__cp_RBMkpdU6PlGQUkGscJK6Lq, 16);
                n12.Spread<n12.Spread<string>> output_29;
                var builder_30 = n4.CollectionBuilders.GetBuilder(state_7.__cp_ObpRNuj0YWJLEQrlc4Beuj, 16);
                n12.Spread<n12.Spread<string>> output_31;
                var builder_32 = n4.CollectionBuilders.GetBuilder(state_7.__cp_J3EdAwPQK6dNFItZFk3f9G, 16);
                n12.Spread<n12.Spread<bool>> output_33;
                try
                {
                    var i_13 = 0;
                    foreach (var item_11 in n4.CollectionExtensions.AsSpan(Result_10))
                    {
                        var splicer_12 = item_11;
                        var i_local_14 = i_13;
                        __Q9JNpK3YSYALfmWwdItpws state_15;
                        if (!iterator_25.MoveNext(out state_15))
                        {
                            iterator_25.Add(state_15 = new __Q9JNpK3YSYALfmWwdItpws(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "TzmxkWUnCvaLYoXP8T4P1x", 244671U);
                            var Output_17 = n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736.Create(Node_Context: Node_Context_16);
                            state_15.__p_TzmxkWUnCvaLYoXP8T4P1x = Output_17;
                        }

                        bool Update_18 = true;
                        var Output_23 = state_15.__p_TzmxkWUnCvaLYoXP8T4P1x.Update(Update_In: Update_18, Type_In: splicer_12, Address_Out: out n12.Spread<string> Address_19, Name_Out: out n12.Spread<string> Name_20, Description_Out: out n12.Spread<string> Description_21, Is_Up_Out: out n12.Spread<bool> Is_Up_22);
                        if (state_15.__GetContext__().IsImmutable)
                            state_15 = Output_23 != state_15.__p_TzmxkWUnCvaLYoXP8T4P1x ? new __Q9JNpK3YSYALfmWwdItpws(state_15)
                            {__p_TzmxkWUnCvaLYoXP8T4P1x = Output_23} : state_15;
                        else
                        {
                            state_15.__p_TzmxkWUnCvaLYoXP8T4P1x = Output_23;
                        }

                        iterator_25.Update(state_15);
                        builder_26.Add(Address_19);
                        builder_28.Add(Name_20);
                        builder_30.Add(Description_21);
                        builder_32.Add(Is_Up_22);
                        i_13++;
                    }
                }
                finally
                {
                    manager_24 = iterator_25.Commit();
                    output_27 = builder_26.Commit();
                    output_29 = builder_28.Commit();
                    output_31 = builder_30.Commit();
                    output_33 = builder_32.Commit();
                }

                n22._Operations_.Flatten<n12.Spread<n12.Spread<string>>, string>(Input_In: output_27, Output_Out: out n12.Spread<string> Output_34);
                n22._Operations_.Flatten<n12.Spread<n12.Spread<string>>, string>(Input_In: output_29, Output_Out: out n12.Spread<string> Output_35);
                n22._Operations_.Flatten<n12.Spread<n12.Spread<string>>, string>(Input_In: output_31, Output_Out: out n12.Spread<string> Output_36);
                n22._Operations_.Flatten<n12.Spread<n12.Spread<bool>>, bool>(Input_In: output_33, Output_Out: out n12.Spread<bool> Output_37);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs_9 != state_7.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs || manager_24 != state_7.__loop_QiHRBCajjfzNsnxn5KOrAZ || output_27 != state_7.__cp_HnKcqjLoBf5L1rfUY160HR || output_29 != state_7.__cp_RBMkpdU6PlGQUkGscJK6Lq || output_31 != state_7.__cp_ObpRNuj0YWJLEQrlc4Beuj || output_33 != state_7.__cp_J3EdAwPQK6dNFItZFk3f9G ? new __CQ1RI8RwEr2PSbY7M7iDIO(state_7)
                    {__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs_9, __loop_QiHRBCajjfzNsnxn5KOrAZ = manager_24, __cp_HnKcqjLoBf5L1rfUY160HR = output_27, __cp_RBMkpdU6PlGQUkGscJK6Lq = output_29, __cp_ObpRNuj0YWJLEQrlc4Beuj = output_31, __cp_J3EdAwPQK6dNFItZFk3f9G = output_33} : state_7;
                else
                {
                    state_7.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs_9;
                    state_7.__loop_QiHRBCajjfzNsnxn5KOrAZ = manager_24;
                    state_7.__cp_HnKcqjLoBf5L1rfUY160HR = output_27;
                    state_7.__cp_RBMkpdU6PlGQUkGscJK6Lq = output_29;
                    state_7.__cp_ObpRNuj0YWJLEQrlc4Beuj = output_31;
                    state_7.__cp_J3EdAwPQK6dNFItZFk3f9G = output_33;
                }

                outputs_5 = (Output_34, Output_35, Output_36, Output_37);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_38, __auto_39, __auto_40, __auto_41) = outputs_5;
            Address_Out = __auto_38;
            Name_Out = __auto_39;
            Description_Out = __auto_40;
            Is_Up_Out = __auto_41;
            n25.IPs_SU385Q2zoCqLj1U3xPCyTo that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_3 != this.__cache_B73QnNna6XUNaiokWNtGqN ? new IPs_SU385Q2zoCqLj1U3xPCyTo(this)
                {__cache_B73QnNna6XUNaiokWNtGqN = manager_3} : that_42;
            else
            {
                this.__cache_B73QnNna6XUNaiokWNtGqN = manager_3;
            }

            return that_42;
        }

        public n25.IPs_SU385Q2zoCqLj1U3xPCyTo __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.IPs_SU385Q2zoCqLj1U3xPCyTo that_0 = this;
            this.__cache_B73QnNna6XUNaiokWNtGqN = null;
            return that_0;
        }

        public n25.IPs_SU385Q2zoCqLj1U3xPCyTo __CreateDefault__()
        {
            n25.IPs_SU385Q2zoCqLj1U3xPCyTo that_0 = this;
            this.__cache_B73QnNna6XUNaiokWNtGqN = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_B73QnNna6XUNaiokWNtGqN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 244613U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "J1ChWvxWNjcLYrL8lfCvNf", Name = "__slot_J1ChWvxWNjcLYrL8lfCvNf")]
        public static n21.NetworkInterfaceType __slot_J1ChWvxWNjcLYrL8lfCvNf = n1.CompilationHelper.Deserialize<n21.NetworkInterfaceType>("Ethernet", false, "PcdEIeqrXeZQCL5lc35ctR", "J1ChWvxWNjcLYrL8lfCvNf");
        [n1.ElementAttribute(TracingId = 244624U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Ly2doyNjKuFMyUCDbBMirx", Name = "__slot_Ly2doyNjKuFMyUCDbBMirx")]
        public static n21.NetworkInterfaceType __slot_Ly2doyNjKuFMyUCDbBMirx = n1.CompilationHelper.Deserialize<n21.NetworkInterfaceType>("Wireless80211", false, "PcdEIeqrXeZQCL5lc35ctR", "Ly2doyNjKuFMyUCDbBMirx");
        [n1.ElementAttribute(TracingId = 244630U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "B73QnNna6XUNaiokWNtGqN", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType, n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>> __cache_B73QnNna6XUNaiokWNtGqN = null;
        static IPs_SU385Q2zoCqLj1U3xPCyTo()
        {
        }

        public IPs_SU385Q2zoCqLj1U3xPCyTo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IPs_SU385Q2zoCqLj1U3xPCyTo(IPs_SU385Q2zoCqLj1U3xPCyTo other): base(other)
        {
            this.__cache_B73QnNna6XUNaiokWNtGqN = other.__cache_B73QnNna6XUNaiokWNtGqN;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_B73QnNna6XUNaiokWNtGqN", in __cache_B73QnNna6XUNaiokWNtGqN));
        }

        internal IPs_SU385Q2zoCqLj1U3xPCyTo __WITH__(n19.Manager<n2.ValueTuple<n21.NetworkInterfaceType, n21.NetworkInterfaceType>, n2.ValueTuple<n12.Spread<string>, n12.Spread<string>, n12.Spread<string>, n12.Spread<bool>>> __cache_B73QnNna6XUNaiokWNtGqN)
        {
            n25.IPs_SU385Q2zoCqLj1U3xPCyTo that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_B73QnNna6XUNaiokWNtGqN != this.__cache_B73QnNna6XUNaiokWNtGqN ? new IPs_SU385Q2zoCqLj1U3xPCyTo(this)
                {__cache_B73QnNna6XUNaiokWNtGqN = __cache_B73QnNna6XUNaiokWNtGqN} : that_0;
            else
            {
                this.__cache_B73QnNna6XUNaiokWNtGqN = __cache_B73QnNna6XUNaiokWNtGqN;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "CQ1RI8RwEr2PSbY7M7iDIO", Name = "__CQ1RI8RwEr2PSbY7M7iDIO")]
        [n2.SerializableAttribute]
        public class __CQ1RI8RwEr2PSbY7M7iDIO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_QiHRBCajjfzNsnxn5KOrAZ);
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n21.NetworkInterfaceType> __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = default(n12.Spread<n21.NetworkInterfaceType>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n26.ImmutableLifetimeManager __loop_QiHRBCajjfzNsnxn5KOrAZ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n12.Spread<string>> __cp_HnKcqjLoBf5L1rfUY160HR;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n12.Spread<string>> __cp_RBMkpdU6PlGQUkGscJK6Lq;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n12.Spread<string>> __cp_ObpRNuj0YWJLEQrlc4Beuj;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n12.Spread<bool>> __cp_J3EdAwPQK6dNFItZFk3f9G;
            public __CQ1RI8RwEr2PSbY7M7iDIO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CQ1RI8RwEr2PSbY7M7iDIO(__CQ1RI8RwEr2PSbY7M7iDIO other): base(other)
            {
                this.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = other.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs;
                this.__loop_QiHRBCajjfzNsnxn5KOrAZ = other.__loop_QiHRBCajjfzNsnxn5KOrAZ;
                this.__cp_HnKcqjLoBf5L1rfUY160HR = other.__cp_HnKcqjLoBf5L1rfUY160HR;
                this.__cp_RBMkpdU6PlGQUkGscJK6Lq = other.__cp_RBMkpdU6PlGQUkGscJK6Lq;
                this.__cp_ObpRNuj0YWJLEQrlc4Beuj = other.__cp_ObpRNuj0YWJLEQrlc4Beuj;
                this.__cp_J3EdAwPQK6dNFItZFk3f9G = other.__cp_J3EdAwPQK6dNFItZFk3f9G;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs", in __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs), n1.CompilationHelper.GetValueOrExisting(values, "__loop_QiHRBCajjfzNsnxn5KOrAZ", in __loop_QiHRBCajjfzNsnxn5KOrAZ), n1.CompilationHelper.GetValueOrExisting(values, "__cp_HnKcqjLoBf5L1rfUY160HR", in __cp_HnKcqjLoBf5L1rfUY160HR), n1.CompilationHelper.GetValueOrExisting(values, "__cp_RBMkpdU6PlGQUkGscJK6Lq", in __cp_RBMkpdU6PlGQUkGscJK6Lq), n1.CompilationHelper.GetValueOrExisting(values, "__cp_ObpRNuj0YWJLEQrlc4Beuj", in __cp_ObpRNuj0YWJLEQrlc4Beuj), n1.CompilationHelper.GetValueOrExisting(values, "__cp_J3EdAwPQK6dNFItZFk3f9G", in __cp_J3EdAwPQK6dNFItZFk3f9G));
            }

            internal __CQ1RI8RwEr2PSbY7M7iDIO __WITH__(n12.Spread<n21.NetworkInterfaceType> __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs, n26.ImmutableLifetimeManager __loop_QiHRBCajjfzNsnxn5KOrAZ, n12.Spread<n12.Spread<string>> __cp_HnKcqjLoBf5L1rfUY160HR, n12.Spread<n12.Spread<string>> __cp_RBMkpdU6PlGQUkGscJK6Lq, n12.Spread<n12.Spread<string>> __cp_ObpRNuj0YWJLEQrlc4Beuj, n12.Spread<n12.Spread<bool>> __cp_J3EdAwPQK6dNFItZFk3f9G)
            {
                __CQ1RI8RwEr2PSbY7M7iDIO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs != this.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs || __loop_QiHRBCajjfzNsnxn5KOrAZ != this.__loop_QiHRBCajjfzNsnxn5KOrAZ || __cp_HnKcqjLoBf5L1rfUY160HR != this.__cp_HnKcqjLoBf5L1rfUY160HR || __cp_RBMkpdU6PlGQUkGscJK6Lq != this.__cp_RBMkpdU6PlGQUkGscJK6Lq || __cp_ObpRNuj0YWJLEQrlc4Beuj != this.__cp_ObpRNuj0YWJLEQrlc4Beuj || __cp_J3EdAwPQK6dNFItZFk3f9G != this.__cp_J3EdAwPQK6dNFItZFk3f9G ? new __CQ1RI8RwEr2PSbY7M7iDIO(this)
                    {__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs, __loop_QiHRBCajjfzNsnxn5KOrAZ = __loop_QiHRBCajjfzNsnxn5KOrAZ, __cp_HnKcqjLoBf5L1rfUY160HR = __cp_HnKcqjLoBf5L1rfUY160HR, __cp_RBMkpdU6PlGQUkGscJK6Lq = __cp_RBMkpdU6PlGQUkGscJK6Lq, __cp_ObpRNuj0YWJLEQrlc4Beuj = __cp_ObpRNuj0YWJLEQrlc4Beuj, __cp_J3EdAwPQK6dNFItZFk3f9G = __cp_J3EdAwPQK6dNFItZFk3f9G} : that_0;
                else
                {
                    this.__pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs = __pin_group_Input_In_I1baDKAyKhrQMBGqvM0Zzs;
                    this.__loop_QiHRBCajjfzNsnxn5KOrAZ = __loop_QiHRBCajjfzNsnxn5KOrAZ;
                    this.__cp_HnKcqjLoBf5L1rfUY160HR = __cp_HnKcqjLoBf5L1rfUY160HR;
                    this.__cp_RBMkpdU6PlGQUkGscJK6Lq = __cp_RBMkpdU6PlGQUkGscJK6Lq;
                    this.__cp_ObpRNuj0YWJLEQrlc4Beuj = __cp_ObpRNuj0YWJLEQrlc4Beuj;
                    this.__cp_J3EdAwPQK6dNFItZFk3f9G = __cp_J3EdAwPQK6dNFItZFk3f9G;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Q9JNpK3YSYALfmWwdItpws", Name = "__Q9JNpK3YSYALfmWwdItpws")]
        [n2.SerializableAttribute]
        public class __Q9JNpK3YSYALfmWwdItpws : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TzmxkWUnCvaLYoXP8T4P1x);
                return;
            }

            [n1.ElementAttribute(TracingId = 244671U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "TzmxkWUnCvaLYoXP8T4P1x", Name = "NetworkInterfaces", IsManaged = true, IsAutoGenerated = true)]
            public n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_TzmxkWUnCvaLYoXP8T4P1x;
            public __Q9JNpK3YSYALfmWwdItpws(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q9JNpK3YSYALfmWwdItpws(__Q9JNpK3YSYALfmWwdItpws other): base(other)
            {
                this.__p_TzmxkWUnCvaLYoXP8T4P1x = other.__p_TzmxkWUnCvaLYoXP8T4P1x;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TzmxkWUnCvaLYoXP8T4P1x", in __p_TzmxkWUnCvaLYoXP8T4P1x));
            }

            internal __Q9JNpK3YSYALfmWwdItpws __WITH__(n13.NetworkInterfaces_IMxwVok0gkqQG3e3tXC736 __p_TzmxkWUnCvaLYoXP8T4P1x)
            {
                __Q9JNpK3YSYALfmWwdItpws that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TzmxkWUnCvaLYoXP8T4P1x != this.__p_TzmxkWUnCvaLYoXP8T4P1x ? new __Q9JNpK3YSYALfmWwdItpws(this)
                    {__p_TzmxkWUnCvaLYoXP8T4P1x = __p_TzmxkWUnCvaLYoXP8T4P1x} : that_0;
                else
                {
                    this.__p_TzmxkWUnCvaLYoXP8T4P1x = __p_TzmxkWUnCvaLYoXP8T4P1x;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 244906U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MapdEBfx7GmNw3zKjfmzsc", Name = "Ping_MapdEBfx7GmNw3zKjfmzsc")]
    [n2.SerializableAttribute]
    public class Ping_MapdEBfx7GmNw3zKjfmzsc : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.Ping_MapdEBfx7GmNw3zKjfmzsc Create(n1.NodeContext Node_Context)
        {
            var instance = new Ping_MapdEBfx7GmNw3zKjfmzsc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.Ping_MapdEBfx7GmNw3zKjfmzsc CreateDefault()
        {
            var instance = new Ping_MapdEBfx7GmNw3zKjfmzsc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.Ping_MapdEBfx7GmNw3zKjfmzsc Update([n4.SerializedDefaultValueAttribute("127.0.0.1", false)] string Input_In, [n4.SerializedDefaultValueAttribute("5", false)] float Period_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Reachable_Out, out string Status_Out, out int Roundtrip_Time_Out)
        {
            n21.Ping __auto_0 = this.Ping;
            var Output_3 = this.__p_SScvlduT3pQQQDSMss0Qw9.Update(Input_In: Input_In, Result_Out: out n5.IPAddress Result_1, Is_Valid_Out: out bool Is_Valid_2);
            var Output_4 = !Enabled_In;
            bool Update_5 = true;
            var Output_6 = this.__p_OQOkpmi0SY3OfZvwUvjy0U;
            if (Update_5)
            {
                Output_6 = this.__p_OQOkpmi0SY3OfZvwUvjy0U.Update(Period_In: Period_In, Pause_In: Output_4);
            }

            var Output_9 = this.__p_B74n5bEHsqFPF5d23GoEU9.Update(Value_In: Enabled_In, Up_Edge_Out: out bool Up_Edge_7, Down_Edge_Out: out bool Down_Edge_8);
            var Output_10 = Output_6;
            if (Up_Edge_7)
            {
                Output_10 = Output_6.Reset();
            }

            var Output_14 = Output_10.GetValues(Phase_Out: out float Phase_11, On_New_Cycle_Out: out bool On_New_Cycle_12, Cycles_Out: out int Cycles_13);
            var Output_15 = On_New_Cycle_12 || Up_Edge_7;
            var Output_16 = Is_Valid_2 && Output_15;
            bool Abort_17 = false;
            var __fallback___18 = n1.ServiceRegistry.Current;
            n79._Operations_.Update_H<n2.ValueTuple<bool, string, int>, n2.Object>(Input_In: this.__p_VMXJg50Sw7wOpCN7elIDC0, Trigger_In: Output_16, Abort_In: Abort_17, Update_In: (n2.Object s_21, n27.CancellationToken Input_1_In_22) =>
            {
                using var __current_19 = __fallback___18.MakeCurrentIfNone();
                var state_20 = n1.CompilationHelper.Restore<__SrLjGJzL5XXQHHpZUAk1UX>(s_21, __GetContext__());
                bool Stick_To_Last_Valid_Outputs_23 = false;
                bool Reset_Region_On_Failure_24 = false;
                var customRegion_25 = state_20.__customRegion_RTtyhlYykAuQPWYeKthkuK ?? new n60.CustomRegion();
                customRegion_25.newPatchSymbol = 14546728;
                customRegion_25.BeginChanges();
                customRegion_25.AddIncomingLink(typeof(n21.Ping), 0);
                customRegion_25.AddIncomingLink(typeof(n5.IPAddress), 1);
                customRegion_25.AddIncomingLink(typeof(float), 2);
                customRegion_25.AddOutput("", typeof(n2.ValueTuple<bool, string, int>), 0);
                customRegion_25.SetInputValues();
                customRegion_25.SetIncomingLinkValues(__auto_0, Result_1, Period_In);
                customRegion_25.EndChanges();
                customRegion_25.PatchUpdator = (n2.Object stateInput_28, n10.IReadOnlyList<n2.Object> inputs_29, n10.IReadOnlyList<n2.Object> incomingLinks_30, out n2.Object stateOutput_34, out n12.Spread<n2.Object> outputs_35) =>
                {
                    using var __current_26 = __fallback___18.MakeCurrentIfNone();
                    var state_27 = n1.CompilationHelper.Restore<__Ft4tTEmzjVdM5INr4XNvT1>(stateInput_28, __GetContext__());
                    var link_QcMf7fSTZQULiXCAY0sKwd_31 = (n21.Ping)incomingLinks_30[0];
                    var link_JXOm85Q2CEZLLyJR7lUWB2_32 = (n5.IPAddress)incomingLinks_30[1];
                    var link_LjYnheBj0GIQO2u7CuyhxB_33 = (float)incomingLinks_30[2];
                    float __pad_MzmomsALZqTQZ0C5DmwI1f_36 = __slot_MzmomsALZqTQZ0C5DmwI1f;
                    int __pad_Cd41M3iUHlaM4mPWAhXenP_37 = __slot_Cd41M3iUHlaM4mPWAhXenP;
                    n21.IPStatus __pad_UjwUzJJk3FeOYX7CdrRf4H_38 = __slot_UjwUzJJk3FeOYX7CdrRf4H;
                    var Output_39 = link_LjYnheBj0GIQO2u7CuyhxB_33 * __pad_MzmomsALZqTQZ0C5DmwI1f_36;
                    var Result_40 = n62.Float32Extensions.Floor(input: Output_39);
                    var Output_41 = Result_40 - __pad_Cd41M3iUHlaM4mPWAhXenP_37;
                    var Result_42 = link_QcMf7fSTZQULiXCAY0sKwd_31.Send(address: link_JXOm85Q2CEZLLyJR7lUWB2_32, timeout: Output_41);
                    var Roundtrip_Time_43 = Result_42.RoundtripTime;
                    var Status_44 = Result_42.Status;
                    var Result_45 = Status_44 == __pad_UjwUzJJk3FeOYX7CdrRf4H_38;
                    var Result_46 = n53.ObjectHelpers.ToString(input: Status_44);
                    var Result_47 = n62.IntegerConversions.ToInt32(input: Roundtrip_Time_43);
                    n78._Operations_.ValueTuple_Create<bool, string, int>(Item_1_In: Result_45, Item_2_In: Result_46, Item_3_In: Result_47, Output_Out: out n2.ValueTuple<bool, string, int> Output_48);
                    stateOutput_34 = state_27;
                    outputs_35 = n4.CollectionExtensions.CreateSpreadOfObjects(Output_48);
                }

                ;
                customRegion_25.PatchCreator = (n10.IReadOnlyList<n2.Object> initialInputs_50, out n2.Object stateOutput_51, out n12.Spread<n2.Object> initialOutputs_52) =>
                {
                    using var __current_49 = __fallback___18.MakeCurrentIfNone();
                    var state_27 = new __Ft4tTEmzjVdM5INr4XNvT1(__GetContext__(), n1.VLObject.NewIdentity());
                    stateOutput_51 = state_27;
                    initialOutputs_52 = n4.CollectionExtensions.CreateSpreadOfObjects(n78._Operations_.CreateDefault<bool, string, int, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>());
                }

                ;
                var Output_56 = state_20.__p_RTtyhlYykAuQPWYeKthkuK.Update(Stick_To_Last_Valid_Outputs_In: Stick_To_Last_Valid_Outputs_23, Reset_Region_On_Failure_In: Reset_Region_On_Failure_24, Region_In: customRegion_25, Success_Out: out bool Success_53, Error_Message_Out: out string Error_Message_54, Failure_Out: out bool Failure_55);
                var __auto_57 = (n2.ValueTuple<bool, string, int>)customRegion_25.OutputValues[0];
                if (state_20.__GetContext__().IsImmutable)
                    state_20 = customRegion_25 != state_20.__customRegion_RTtyhlYykAuQPWYeKthkuK || Output_56 != state_20.__p_RTtyhlYykAuQPWYeKthkuK ? new __SrLjGJzL5XXQHHpZUAk1UX(state_20)
                    {__customRegion_RTtyhlYykAuQPWYeKthkuK = customRegion_25, __p_RTtyhlYykAuQPWYeKthkuK = Output_56} : state_20;
                else
                {
                    state_20.__customRegion_RTtyhlYykAuQPWYeKthkuK = customRegion_25;
                    state_20.__p_RTtyhlYykAuQPWYeKthkuK = Output_56;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<bool, string, int>>(state_20, __auto_57);
            }

            , Create_In: () =>
            {
                using var __current_58 = __fallback___18.MakeCurrentIfNone();
                var state_20 = new __SrLjGJzL5XXQHHpZUAk1UX(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_59 = __GetContext__().CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "RTtyhlYykAuQPWYeKthkuK", 244969U);
                var Output_60 = n17.Try_NXr6u6gowSzLvQTfp53h2q.Create(Node_Context: Node_Context_59);
                state_20.__p_RTtyhlYykAuQPWYeKthkuK = Output_60;
                return state_20;
            }

            , Output_Out: out n31.AsyncTask<n2.ValueTuple<bool, string, int>> Output_61, Result_Out: out n2.IObservable<n2.ValueTuple<bool, string, int>> Result_62, In_Progress_Out: out bool In_Progress_63);
            var Output_66 = this.__p_Gp5fHun6SYKNJTEs2ZIUK8.Update(Value_In: Input_In, Result_Out: out bool Result_64, Unchanged_Out: out bool Unchanged_65);
            var Output_67 = Result_64 || Up_Edge_7;
            bool Update_68 = true;
            var Output_69 = this.__p_BQQ0Mg0xitgMN9XHAGp2L1;
            if (Update_68)
            {
                n59._Operations_.Update_H<n2.ValueTuple<bool, string, int>>(Input_In: this.__p_BQQ0Mg0xitgMN9XHAGp2L1, Async_Notifications_In: Result_62, Reset_In: Output_67, Output_Out: out Output_69);
            }

            n59._Operations_.GetData_H<n2.ValueTuple<bool, string, int>>(Input_In: Output_69, Output_Out: out n31.HoldLatest<n2.ValueTuple<bool, string, int>> Output_70, Value_Out: out n2.ValueTuple<bool, string, int> Value_71, On_Data_Out: out bool On_Data_72);
            n78._Operations_.ValueTuple_Split<bool, string, int>(Input_In: Value_71, Item_1_Out: out bool Item_1_73, Item_2_Out: out string Item_2_74, Item_3_Out: out int Item_3_75);
            Reachable_Out = Item_1_73;
            Status_Out = Item_2_74;
            Roundtrip_Time_Out = Item_3_75;
            n25.Ping_MapdEBfx7GmNw3zKjfmzsc that_76 = this;
            if (this.__GetContext__().IsImmutable)
                that_76 = Output_3 != this.__p_SScvlduT3pQQQDSMss0Qw9 || Output_14 != this.__p_OQOkpmi0SY3OfZvwUvjy0U || Output_9 != this.__p_B74n5bEHsqFPF5d23GoEU9 || Output_61 != this.__p_VMXJg50Sw7wOpCN7elIDC0 || Output_66 != this.__p_Gp5fHun6SYKNJTEs2ZIUK8 || Output_70 != this.__p_BQQ0Mg0xitgMN9XHAGp2L1 ? new Ping_MapdEBfx7GmNw3zKjfmzsc(this)
                {__p_SScvlduT3pQQQDSMss0Qw9 = Output_3, __p_OQOkpmi0SY3OfZvwUvjy0U = Output_14, __p_B74n5bEHsqFPF5d23GoEU9 = Output_9, __p_VMXJg50Sw7wOpCN7elIDC0 = Output_61, __p_Gp5fHun6SYKNJTEs2ZIUK8 = Output_66, __p_BQQ0Mg0xitgMN9XHAGp2L1 = Output_70} : that_76;
            else
            {
                this.__p_SScvlduT3pQQQDSMss0Qw9 = Output_3;
                this.__p_OQOkpmi0SY3OfZvwUvjy0U = Output_14;
                this.__p_B74n5bEHsqFPF5d23GoEU9 = Output_9;
                this.__p_VMXJg50Sw7wOpCN7elIDC0 = Output_61;
                this.__p_Gp5fHun6SYKNJTEs2ZIUK8 = Output_66;
                this.__p_BQQ0Mg0xitgMN9XHAGp2L1 = Output_70;
            }

            return that_76;
        }

        public n25.Ping_MapdEBfx7GmNw3zKjfmzsc __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n21.Ping();
            n21.Ping __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "SScvlduT3pQQQDSMss0Qw9", 244919U);
            var Output_3 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "VMXJg50Sw7wOpCN7elIDC0", 244947U);
            n79._Operations_.Create_H<n2.ValueTuple<bool, string, int>>(Node_Context: Node_Context_4, Output_Out: out n31.AsyncTask<n2.ValueTuple<bool, string, int>> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "OQOkpmi0SY3OfZvwUvjy0U", 245134U);
            n70.IFrameClock Clock_7 = n69._Operations_.CreateDefault();
            var Output_8 = n80.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_6, Clock_In: Clock_7);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "BQQ0Mg0xitgMN9XHAGp2L1", 245161U);
            n2.ValueTuple<bool, string, int> Initial_Result_10 = n78._Operations_.CreateDefault<bool, string, int, n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            n59._Operations_.Create_H<n2.ValueTuple<bool, string, int>>(Node_Context: Node_Context_9, Initial_Result_In: Initial_Result_10, Output_Out: out n31.HoldLatest<n2.ValueTuple<bool, string, int>> Output_11);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "Gp5fHun6SYKNJTEs2ZIUK8", 245223U);
            bool Changed_On_Create_13 = true;
            var Output_14 = n17.Changed_A8JGbead2bxNdnPybiEqVS<string>.Create<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>(Node_Context: Node_Context_12, Changed_On_Create_In: Changed_On_Create_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("PcdEIeqrXeZQCL5lc35ctR", "B74n5bEHsqFPF5d23GoEU9", 245258U);
            var Output_16 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_15);
            n25.Ping_MapdEBfx7GmNw3zKjfmzsc that_17 = this;
            this.Ping = Output_0;
            this.__p_SScvlduT3pQQQDSMss0Qw9 = Output_3;
            this.__p_VMXJg50Sw7wOpCN7elIDC0 = Output_5;
            this.__p_OQOkpmi0SY3OfZvwUvjy0U = Output_8;
            this.__p_BQQ0Mg0xitgMN9XHAGp2L1 = Output_11;
            this.__p_Gp5fHun6SYKNJTEs2ZIUK8 = Output_14;
            this.__p_B74n5bEHsqFPF5d23GoEU9 = Output_16;
            return that_17;
        }

        public n25.Ping_MapdEBfx7GmNw3zKjfmzsc Dispose_()
        {
            n21.Ping __auto_0 = this.Ping;
            n2.IDisposable Input_1 = (n2.IDisposable)__auto_0;
            ((n2.IDisposable)Input_1).Dispose();
            n1.CompilationHelper.SafeDispose(this.__p_SScvlduT3pQQQDSMss0Qw9);
            n1.CompilationHelper.SafeDispose(this.__p_OQOkpmi0SY3OfZvwUvjy0U);
            n1.CompilationHelper.SafeDispose(this.__p_B74n5bEHsqFPF5d23GoEU9);
            n1.CompilationHelper.SafeDispose(this.__p_VMXJg50Sw7wOpCN7elIDC0);
            n1.CompilationHelper.SafeDispose(this.__p_Gp5fHun6SYKNJTEs2ZIUK8);
            n1.CompilationHelper.SafeDispose(this.__p_BQQ0Mg0xitgMN9XHAGp2L1);
            return this;
        }

        public n25.Ping_MapdEBfx7GmNw3zKjfmzsc __CreateDefault__()
        {
            n25.Ping_MapdEBfx7GmNw3zKjfmzsc that_0 = this;
            this.Ping = default(n21.Ping);
            this.__p_SScvlduT3pQQQDSMss0Qw9 = n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m.CreateDefault();
            this.__p_OQOkpmi0SY3OfZvwUvjy0U = n80.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_B74n5bEHsqFPF5d23GoEU9 = n17.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_VMXJg50Sw7wOpCN7elIDC0 = default(n31.AsyncTask<n2.ValueTuple<bool, string, int>>);
            this.__p_Gp5fHun6SYKNJTEs2ZIUK8 = n17.Changed_A8JGbead2bxNdnPybiEqVS<string>.CreateDefault<n15.__AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR>();
            this.__p_BQQ0Mg0xitgMN9XHAGp2L1 = default(n31.HoldLatest<n2.ValueTuple<bool, string, int>>);
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 244916U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MNYQTrVTG16MS2AEYUd7Ij", Name = "Ping")]
        public n21.Ping Ping;
        [n1.ElementAttribute(TracingId = 244919U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SScvlduT3pQQQDSMss0Qw9", Name = "IPAddress", IsManaged = true, IsAutoGenerated = true)]
        public n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_SScvlduT3pQQQDSMss0Qw9;
        [n1.ElementAttribute(TracingId = 245134U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "OQOkpmi0SY3OfZvwUvjy0U", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n80.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_OQOkpmi0SY3OfZvwUvjy0U;
        [n1.ElementAttribute(TracingId = 245258U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "B74n5bEHsqFPF5d23GoEU9", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_B74n5bEHsqFPF5d23GoEU9;
        [n1.ElementAttribute(TracingId = 244947U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "VMXJg50Sw7wOpCN7elIDC0", Name = "AsyncTask", IsManaged = true, IsAutoGenerated = true)]
        public n31.AsyncTask<n2.ValueTuple<bool, string, int>> __p_VMXJg50Sw7wOpCN7elIDC0;
        [n1.ElementAttribute(TracingId = 245112U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "MzmomsALZqTQZ0C5DmwI1f", Name = "__slot_MzmomsALZqTQZ0C5DmwI1f")]
        public static float __slot_MzmomsALZqTQZ0C5DmwI1f = 1000F;
        [n1.ElementAttribute(TracingId = 245117U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Cd41M3iUHlaM4mPWAhXenP", Name = "__slot_Cd41M3iUHlaM4mPWAhXenP")]
        public static int __slot_Cd41M3iUHlaM4mPWAhXenP = 500;
        [n1.ElementAttribute(TracingId = 244992U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "UjwUzJJk3FeOYX7CdrRf4H", Name = "__slot_UjwUzJJk3FeOYX7CdrRf4H")]
        public static n21.IPStatus __slot_UjwUzJJk3FeOYX7CdrRf4H = n1.CompilationHelper.Deserialize<n21.IPStatus>("Success", false, "PcdEIeqrXeZQCL5lc35ctR", "UjwUzJJk3FeOYX7CdrRf4H");
        [n1.ElementAttribute(TracingId = 245223U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Gp5fHun6SYKNJTEs2ZIUK8", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n17.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_Gp5fHun6SYKNJTEs2ZIUK8;
        [n1.ElementAttribute(TracingId = 245161U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "BQQ0Mg0xitgMN9XHAGp2L1", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n2.ValueTuple<bool, string, int>> __p_BQQ0Mg0xitgMN9XHAGp2L1;
        static Ping_MapdEBfx7GmNw3zKjfmzsc()
        {
        }

        public Ping_MapdEBfx7GmNw3zKjfmzsc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Ping_MapdEBfx7GmNw3zKjfmzsc(Ping_MapdEBfx7GmNw3zKjfmzsc other): base(other)
        {
            this.Ping = other.Ping;
            this.__p_SScvlduT3pQQQDSMss0Qw9 = other.__p_SScvlduT3pQQQDSMss0Qw9;
            this.__p_OQOkpmi0SY3OfZvwUvjy0U = other.__p_OQOkpmi0SY3OfZvwUvjy0U;
            this.__p_B74n5bEHsqFPF5d23GoEU9 = other.__p_B74n5bEHsqFPF5d23GoEU9;
            this.__p_VMXJg50Sw7wOpCN7elIDC0 = other.__p_VMXJg50Sw7wOpCN7elIDC0;
            this.__p_Gp5fHun6SYKNJTEs2ZIUK8 = other.__p_Gp5fHun6SYKNJTEs2ZIUK8;
            this.__p_BQQ0Mg0xitgMN9XHAGp2L1 = other.__p_BQQ0Mg0xitgMN9XHAGp2L1;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Ping", in Ping), n1.CompilationHelper.GetValueOrExisting(values, "__p_SScvlduT3pQQQDSMss0Qw9", in __p_SScvlduT3pQQQDSMss0Qw9), n1.CompilationHelper.GetValueOrExisting(values, "__p_OQOkpmi0SY3OfZvwUvjy0U", in __p_OQOkpmi0SY3OfZvwUvjy0U), n1.CompilationHelper.GetValueOrExisting(values, "__p_B74n5bEHsqFPF5d23GoEU9", in __p_B74n5bEHsqFPF5d23GoEU9), n1.CompilationHelper.GetValueOrExisting(values, "__p_VMXJg50Sw7wOpCN7elIDC0", in __p_VMXJg50Sw7wOpCN7elIDC0), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gp5fHun6SYKNJTEs2ZIUK8", in __p_Gp5fHun6SYKNJTEs2ZIUK8), n1.CompilationHelper.GetValueOrExisting(values, "__p_BQQ0Mg0xitgMN9XHAGp2L1", in __p_BQQ0Mg0xitgMN9XHAGp2L1));
        }

        internal Ping_MapdEBfx7GmNw3zKjfmzsc __WITH__(n21.Ping Ping, n13.IPAddress_MLeJfL0KehEPTxpNGNIs8m __p_SScvlduT3pQQQDSMss0Qw9, n80.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_OQOkpmi0SY3OfZvwUvjy0U, n17.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_B74n5bEHsqFPF5d23GoEU9, n31.AsyncTask<n2.ValueTuple<bool, string, int>> __p_VMXJg50Sw7wOpCN7elIDC0, n17.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_Gp5fHun6SYKNJTEs2ZIUK8, n31.HoldLatest<n2.ValueTuple<bool, string, int>> __p_BQQ0Mg0xitgMN9XHAGp2L1)
        {
            n25.Ping_MapdEBfx7GmNw3zKjfmzsc that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Ping != this.Ping || __p_SScvlduT3pQQQDSMss0Qw9 != this.__p_SScvlduT3pQQQDSMss0Qw9 || __p_OQOkpmi0SY3OfZvwUvjy0U != this.__p_OQOkpmi0SY3OfZvwUvjy0U || __p_B74n5bEHsqFPF5d23GoEU9 != this.__p_B74n5bEHsqFPF5d23GoEU9 || __p_VMXJg50Sw7wOpCN7elIDC0 != this.__p_VMXJg50Sw7wOpCN7elIDC0 || __p_Gp5fHun6SYKNJTEs2ZIUK8 != this.__p_Gp5fHun6SYKNJTEs2ZIUK8 || __p_BQQ0Mg0xitgMN9XHAGp2L1 != this.__p_BQQ0Mg0xitgMN9XHAGp2L1 ? new Ping_MapdEBfx7GmNw3zKjfmzsc(this)
                {Ping = Ping, __p_SScvlduT3pQQQDSMss0Qw9 = __p_SScvlduT3pQQQDSMss0Qw9, __p_OQOkpmi0SY3OfZvwUvjy0U = __p_OQOkpmi0SY3OfZvwUvjy0U, __p_B74n5bEHsqFPF5d23GoEU9 = __p_B74n5bEHsqFPF5d23GoEU9, __p_VMXJg50Sw7wOpCN7elIDC0 = __p_VMXJg50Sw7wOpCN7elIDC0, __p_Gp5fHun6SYKNJTEs2ZIUK8 = __p_Gp5fHun6SYKNJTEs2ZIUK8, __p_BQQ0Mg0xitgMN9XHAGp2L1 = __p_BQQ0Mg0xitgMN9XHAGp2L1} : that_1;
            else
            {
                this.Ping = Ping;
                this.__p_SScvlduT3pQQQDSMss0Qw9 = __p_SScvlduT3pQQQDSMss0Qw9;
                this.__p_OQOkpmi0SY3OfZvwUvjy0U = __p_OQOkpmi0SY3OfZvwUvjy0U;
                this.__p_B74n5bEHsqFPF5d23GoEU9 = __p_B74n5bEHsqFPF5d23GoEU9;
                this.__p_VMXJg50Sw7wOpCN7elIDC0 = __p_VMXJg50Sw7wOpCN7elIDC0;
                this.__p_Gp5fHun6SYKNJTEs2ZIUK8 = __p_Gp5fHun6SYKNJTEs2ZIUK8;
                this.__p_BQQ0Mg0xitgMN9XHAGp2L1 = __p_BQQ0Mg0xitgMN9XHAGp2L1;
            }

            return that_1;
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "SrLjGJzL5XXQHHpZUAk1UX", Name = "__SrLjGJzL5XXQHHpZUAk1UX")]
        [n2.SerializableAttribute]
        public class __SrLjGJzL5XXQHHpZUAk1UX : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RTtyhlYykAuQPWYeKthkuK);
                n1.CompilationHelper.SafeDispose(this.__customRegion_RTtyhlYykAuQPWYeKthkuK);
                return;
            }

            [n1.ElementAttribute(TracingId = 244969U, DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "RTtyhlYykAuQPWYeKthkuK", Name = "Try", IsManaged = true, IsAutoGenerated = true)]
            public n17.Try_NXr6u6gowSzLvQTfp53h2q __p_RTtyhlYykAuQPWYeKthkuK;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n60.CustomRegion __customRegion_RTtyhlYykAuQPWYeKthkuK;
            public __SrLjGJzL5XXQHHpZUAk1UX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SrLjGJzL5XXQHHpZUAk1UX(__SrLjGJzL5XXQHHpZUAk1UX other): base(other)
            {
                this.__p_RTtyhlYykAuQPWYeKthkuK = other.__p_RTtyhlYykAuQPWYeKthkuK;
                this.__customRegion_RTtyhlYykAuQPWYeKthkuK = other.__customRegion_RTtyhlYykAuQPWYeKthkuK;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RTtyhlYykAuQPWYeKthkuK", in __p_RTtyhlYykAuQPWYeKthkuK), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_RTtyhlYykAuQPWYeKthkuK", in __customRegion_RTtyhlYykAuQPWYeKthkuK));
            }

            internal __SrLjGJzL5XXQHHpZUAk1UX __WITH__(n17.Try_NXr6u6gowSzLvQTfp53h2q __p_RTtyhlYykAuQPWYeKthkuK, n60.CustomRegion __customRegion_RTtyhlYykAuQPWYeKthkuK)
            {
                __SrLjGJzL5XXQHHpZUAk1UX that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RTtyhlYykAuQPWYeKthkuK != this.__p_RTtyhlYykAuQPWYeKthkuK || __customRegion_RTtyhlYykAuQPWYeKthkuK != this.__customRegion_RTtyhlYykAuQPWYeKthkuK ? new __SrLjGJzL5XXQHHpZUAk1UX(this)
                    {__p_RTtyhlYykAuQPWYeKthkuK = __p_RTtyhlYykAuQPWYeKthkuK, __customRegion_RTtyhlYykAuQPWYeKthkuK = __customRegion_RTtyhlYykAuQPWYeKthkuK} : that_0;
                else
                {
                    this.__p_RTtyhlYykAuQPWYeKthkuK = __p_RTtyhlYykAuQPWYeKthkuK;
                    this.__customRegion_RTtyhlYykAuQPWYeKthkuK = __customRegion_RTtyhlYykAuQPWYeKthkuK;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PcdEIeqrXeZQCL5lc35ctR", PersistentId = "Ft4tTEmzjVdM5INr4XNvT1", Name = "__Ft4tTEmzjVdM5INr4XNvT1")]
        [n2.SerializableAttribute]
        public class __Ft4tTEmzjVdM5INr4XNvT1 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __Ft4tTEmzjVdM5INr4XNvT1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ft4tTEmzjVdM5INr4XNvT1(__Ft4tTEmzjVdM5INr4XNvT1 other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __Ft4tTEmzjVdM5INr4XNvT1 __WITH__()
            {
                return this;
            }
        }
    }
}

namespace _VL_CoreLib_IO_
{
    public struct __AdaptiveImplementations__PcdEIeqrXeZQCL5lc35ctR : n87.IAdaptiveCreateDefault<n24.Socket>, n87.IAdaptiveCreateDefault<n2.IObservable<n10.IEnumerable<byte>>>, n87.IAdaptiveCreateDefault<n2.IObservable<n6.Datagram>>, n87.IAdaptiveCreateDefault<n29.SerialPort>, n87.IAdaptiveCreateDefault<n8.Stream>, n87.IAdaptiveCreateDefault<string>, n87.IAdaptiveCreateDefault<int>, n87.IAdaptiveCreateDefault<n2.IObservable<n5.IPEndPoint>>, n87.IAdaptiveCreateDefault<bool>, n88.IAdaptiveOperatorLess<int>
    {
        public void CreateDefault(out n24.Socket Output_Out)
        {
            n85._Operations_.CreateDefault_Generic<n24.Socket>(Output_Out: out n24.Socket Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n10.IEnumerable<byte>> Output_Out)
        {
            var Result_0 = n86._Operations_.CreateDefault<n10.IEnumerable<byte>>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n6.Datagram> Output_Out)
        {
            var Result_0 = n86._Operations_.CreateDefault<n6.Datagram>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n29.SerialPort Output_Out)
        {
            n85._Operations_.CreateDefault_Generic<n29.SerialPort>(Output_Out: out n29.SerialPort Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.Stream Output_Out)
        {
            var Null_0 = n72._Operations_.CreateDefault();
            Output_Out = Null_0;
            return;
        }

        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n61._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n85._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n5.IPEndPoint> Output_Out)
        {
            var Result_0 = n86._Operations_.CreateDefault<n5.IPEndPoint>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n85._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}