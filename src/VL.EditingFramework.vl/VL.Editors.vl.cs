extern alias e9;
extern alias e2;
extern alias e5;
extern alias e1;

using n34 = _VL_Editors_.Editors._3D.Advanced;
using n26 = _VL_Xml_.System.XML.XDeclaration;
using n64 = _VL_Editors_.Editors._2D.Advanced;
using n55 = _CoreLibBasics_._3D.Matrix;
using n53 = _VL_Editors_.Editors.Adaptive.Internal;
using n22 = _VL_Bezier_Cubic_.Math.Advanced;
using n32 = _CoreLibBasics_.Control.Advanced;
using n54 = _CoreLibBasics_.Animation.FrameBased;
using n35 = e2::VL.Lib.Primitive;
using n41 = _CoreLibBasics_.Control;
using n57 = _System_Serialization_.System.Serialization.Volatile.Advanced;
using n40 = global::System.Collections.Immutable;
using n65 = _CoreLibBasics_.System.Conversion.Adaptive;
using n47 = _CoreLibBasics_.Math.Generic.Advanced;
using n20 = _VL_Editors_.Editors.Bezier.Internal;
using n62 = _CoreLibBasics_._3D.Transform;
using n28 = _VL_Xml_.System.XML.XDocument;
using n46 = e2::VL.Lib.Mathematics;
using n29 = _VL_Editors_;
using n8 = _VL_Editors_.Editors.Advanced;
using n58 = _CoreLibBasics_.Primitive.String;
using n24 = _VL_Bezier_Cubic_.Math;
using n30 = _VL_Bezier_Cubic_.Math.Experimental;
using n37 = e2::VL.Lib.Primitive.Object;
using n6 = e5::VL.Core.CompilerServices;
using n56 = _CoreLibBasics_._2D.Transform;
using n23 = global::System.Collections.Generic;
using n48 = _CoreLibBasics_._2D.Vector2;
using n3 = e1::Stride.Core.Mathematics;
using n13 = _VL_Editors_.Editors.Reader;
using n21 = _CoreLibBasics_.Math.Adaptive;
using n38 = _VL_Editors_.Editors._3D.Internal;
using n16 = _System_Serialization_.System.Serialization;
using n52 = _VL_Editors_.Editors._2D.Internal;
using n59 = _VL_Xml_.System.XML;
using n5 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n9 = e2::VL.Lib.Primitive.CacheRegion;
using n15 = global::System.Xml.XPath;
using n45 = _VL_Skia_.IO.Keyboard;
using n1 = e5::VL.Core;
using n43 = e9::VL.Lib.IO;
using n31 = _VL_Editors_.Editors.Internal;
using n11 = e2::VL.Lib.Xml;
using n2 = global::System;
using n49 = _CoreLibBasics_._2D.Rectangle;
using n39 = global::System.Windows.Forms;
using n25 = _VL_Bezier_Cubic_.Math.BezierSegment;
using n42 = _VL_Xml_.System.XML.XElement;
using n27 = _VL_Xml_.System.XML.XDocumentType;
using n50 = _CoreLibBasics_._3D;
using n12 = _VL_Collections_.Collections.Sequence;
using n18 = global::System.Runtime.CompilerServices;
using n44 = _VL_Skia_.IO.Mouse;
using n19 = _VL_Xml_.System.XML.Advanced;
using n61 = _CoreLibBasics_._3D.Plane;
using n4 = _VL_Editors_.Editors;
using n10 = e5::VL.Lib.Collections;
using n17 = e5::VL.Lib.IO;
using n14 = _VL_Collections_.Collections.Spread;
using n33 = _VL_Editors_.Editors._2D;
using n36 = _VL_Editors_.Editors._3D;
using n63 = _CoreLibBasics_.Primitive.Advanced;
using n7 = global::System.Xml.Linq;
using n60 = _CoreLibBasics_._3D.Vector4;
using n51 = _CoreLibBasics_._3D.Vector3;

namespace _VL_Editors_.Editors
{
    [n1.ElementAttribute(TracingId = 63687U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DvpMZgosWbNMOtBUTedvT1", Name = "Reader_DvpMZgosWbNMOtBUTedvT1")]
    [n2.SerializableAttribute]
    public class Reader_DvpMZgosWbNMOtBUTedvT1<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var instance = new Reader_DvpMZgosWbNMOtBUTedvT1<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var instance = new Reader_DvpMZgosWbNMOtBUTedvT1<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> Update<AdM>(n17.Path File_Path_In, bool Read_In, out T Result_Out, out bool On_Data_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var State_Output_2 = this.__p_FamChungmsXLTb7ZU40sXr.Update(File_Path_In: File_Path_In, Read_In: Read_In, Output_Out: out n7.XDocument Output_1);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_M6ovS8C5x4jPUNEDCwy5a6;
            if (manager_4 is null)
            {
                w_0.CreateDefault(out T __out_0);
                manager_4 = new n9.Manager<n2.ValueTuple, n2.ValueTuple<T>>(n2.ValueTuple.Create(__out_0));
            }

            var inputs_5 = n2.ValueTuple.Create();
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Read_In || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                string __pad_JeADzLkQNGFLVezhUokete_9 = __slot_JeADzLkQNGFLVezhUokete;
                n11.XmlNodes.SplitXDocument(input: Output_1, root: out n7.XElement Root_10, declaration: out n7.XDeclaration Declaration_11, documentType: out n7.XDocumentType Document_Type_12);
                n13._Operations_.Fallback(Input_In: Root_10, Output_Out: out n7.XElement Output_13);
                var Result_14 = n15.Extensions.XPathSelectElement(node: Output_13, expression: __pad_JeADzLkQNGFLVezhUokete_9);
                n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "GBaJPTCS2McLSm51GG8cww", 64694U);
                n16._Operations_.Deserialize<T>(Content_In: Result_14, Node_Context_In: Node_Context_15, Result_Out: out T Result_16);
                outputs_6 = n2.ValueTuple.Create(Result_16);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_17 = outputs_6.Item1;
            Result_Out = __auto_17;
            On_Data_Out = Has_Changed_7;
            n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> that_18 = this;
            if (this.__GetContext__().IsImmutable)
                that_18 = State_Output_2 != this.__p_FamChungmsXLTb7ZU40sXr || manager_4 != this.__cache_M6ovS8C5x4jPUNEDCwy5a6 ? new Reader_DvpMZgosWbNMOtBUTedvT1<T>(this)
                {__p_FamChungmsXLTb7ZU40sXr = State_Output_2, __cache_M6ovS8C5x4jPUNEDCwy5a6 = manager_4} : that_18;
            else
            {
                this.__p_FamChungmsXLTb7ZU40sXr = State_Output_2;
                this.__cache_M6ovS8C5x4jPUNEDCwy5a6 = manager_4;
            }

            return that_18;
        }

        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "FamChungmsXLTb7ZU40sXr", 64627U);
            var Output_2 = n19.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ.Create(Node_Context: Node_Context_1);
            n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> that_3 = this;
            this.__p_FamChungmsXLTb7ZU40sXr = Output_2;
            this.__cache_M6ovS8C5x4jPUNEDCwy5a6 = null;
            return that_3;
        }

        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> that_1 = this;
            this.__p_FamChungmsXLTb7ZU40sXr = n19.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ.CreateDefault();
            this.__cache_M6ovS8C5x4jPUNEDCwy5a6 = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FamChungmsXLTb7ZU40sXr);
            n1.CompilationHelper.SafeDispose(this.__cache_M6ovS8C5x4jPUNEDCwy5a6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 64627U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FamChungmsXLTb7ZU40sXr", Name = "XMLReader (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n19.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __p_FamChungmsXLTb7ZU40sXr;
        [n1.ElementAttribute(TracingId = 64651U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "M6ovS8C5x4jPUNEDCwy5a6", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n2.ValueTuple, n2.ValueTuple<T>> __cache_M6ovS8C5x4jPUNEDCwy5a6 = null;
        [n1.ElementAttribute(TracingId = 64720U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JeADzLkQNGFLVezhUokete", Name = "__slot_JeADzLkQNGFLVezhUokete")]
        public static string __slot_JeADzLkQNGFLVezhUokete = "Spread";
        static Reader_DvpMZgosWbNMOtBUTedvT1()
        {
        }

        public Reader_DvpMZgosWbNMOtBUTedvT1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Reader_DvpMZgosWbNMOtBUTedvT1(Reader_DvpMZgosWbNMOtBUTedvT1<T> other): base(other)
        {
            this.__p_FamChungmsXLTb7ZU40sXr = other.__p_FamChungmsXLTb7ZU40sXr;
            this.__cache_M6ovS8C5x4jPUNEDCwy5a6 = other.__cache_M6ovS8C5x4jPUNEDCwy5a6;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FamChungmsXLTb7ZU40sXr", in __p_FamChungmsXLTb7ZU40sXr), n1.CompilationHelper.GetValueOrExisting(values, "__cache_M6ovS8C5x4jPUNEDCwy5a6", in __cache_M6ovS8C5x4jPUNEDCwy5a6));
        }

        internal Reader_DvpMZgosWbNMOtBUTedvT1<T> __WITH__(n19.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __p_FamChungmsXLTb7ZU40sXr, n9.Manager<n2.ValueTuple, n2.ValueTuple<T>> __cache_M6ovS8C5x4jPUNEDCwy5a6)
        {
            n4.Reader_DvpMZgosWbNMOtBUTedvT1<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FamChungmsXLTb7ZU40sXr != this.__p_FamChungmsXLTb7ZU40sXr || __cache_M6ovS8C5x4jPUNEDCwy5a6 != this.__cache_M6ovS8C5x4jPUNEDCwy5a6 ? new Reader_DvpMZgosWbNMOtBUTedvT1<T>(this)
                {__p_FamChungmsXLTb7ZU40sXr = __p_FamChungmsXLTb7ZU40sXr, __cache_M6ovS8C5x4jPUNEDCwy5a6 = __cache_M6ovS8C5x4jPUNEDCwy5a6} : that_0;
            else
            {
                this.__p_FamChungmsXLTb7ZU40sXr = __p_FamChungmsXLTb7ZU40sXr;
                this.__cache_M6ovS8C5x4jPUNEDCwy5a6 = __cache_M6ovS8C5x4jPUNEDCwy5a6;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 64799U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VWy4rC6UCb0Nm7X4PoUFet", Name = "Writer_VWy4rC6UCb0Nm7X4PoUFet")]
    [n2.SerializableAttribute]
    public class Writer_VWy4rC6UCb0Nm7X4PoUFet : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Writer_VWy4rC6UCb0Nm7X4PoUFet Create(n1.NodeContext Node_Context)
        {
            var instance = new Writer_VWy4rC6UCb0Nm7X4PoUFet(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Writer_VWy4rC6UCb0Nm7X4PoUFet CreateDefault()
        {
            var instance = new Writer_VWy4rC6UCb0Nm7X4PoUFet(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet Update<T>(T Data_In, n17.Path File_Path_In, bool Write_In)
        {
            n7.XDocument __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__Si0RDglNIQdMJB8ers2Jrn>(this.__if_KJajBhQ0iC9QapgFGnyATQ, __GetContext__());
            if (Write_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __Si0RDglNIQdMJB8ers2Jrn(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = n14._Operations_.CreateDefault<n7.XAttribute>(), __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = n14._Operations_.CreateDefault<n7.XElement>()};
                }

                string __pad_O2C8ICJQKV3L5Xlm61FVsa_2 = __slot_O2C8ICJQKV3L5Xlm61FVsa;
                string __pad_J5LTVjcvltfQMhIndOvSg5_3 = __slot_J5LTVjcvltfQMhIndOvSg5;
                string __pad_BfxaUxahNTAO6J50h3PlAu_4 = __slot_BfxaUxahNTAO6J50h3PlAu;
                var Result_5 = n11.XmlNodes.JoinXAttribute(name: __pad_J5LTVjcvltfQMhIndOvSg5_3, value: __pad_BfxaUxahNTAO6J50h3PlAu_4);
                var builder_6 = n6.CollectionBuilders.GetBuilder(state_1.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO, 1);
                builder_6.Add(Result_5);
                var __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO_7 = builder_6.Commit();
                n14._Operations_.FromValue<n7.XAttribute>(Input_In: __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO_7, Result_Out: out n10.Spread<n7.XAttribute> Result_8);
                n23.IEnumerable<n7.XAttribute> Attributes_9 = (n23.IEnumerable<n7.XAttribute>)Result_8;
                n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "AidDeUziys0MdsIeDNSdx0", 64889U);
                bool Include_Defaults_11 = false;
                n16._Operations_.Serialize<T>(Value_In: Data_In, Node_Context_In: Node_Context_10, Include_Defaults_In: Include_Defaults_11, Result_Out: out n7.XElement Result_12);
                var builder_13 = n6.CollectionBuilders.GetBuilder(state_1.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc, 1);
                builder_13.Add(Result_12);
                var __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc_14 = builder_13.Commit();
                n14._Operations_.FromValue<n7.XElement>(Input_In: __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc_14, Result_Out: out n10.Spread<n7.XElement> Result_15);
                n23.IEnumerable<n7.XElement> Children_16 = (n23.IEnumerable<n7.XElement>)Result_15;
                string Value_17 = "";
                var Result_18 = n11.XmlNodes.JoinXElement(name: __pad_O2C8ICJQKV3L5Xlm61FVsa_2, value: Value_17, attributes: Attributes_9, children: Children_16);
                n7.XDeclaration Declaration_19 = n26._Operations_.CreateDefault();
                n7.XDocumentType Document_Type_20 = n27._Operations_.CreateDefault();
                var Result_21 = n11.XmlNodes.JoinXDocument(root: Result_18, declaration: Declaration_19, documentType: Document_Type_20);
                __auto_0 = Result_21;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO_7 != state_1.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO || __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc_14 != state_1.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc ? new __Si0RDglNIQdMJB8ers2Jrn(state_1)
                    {__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO_7, __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc_14} : state_1;
                else
                {
                    state_1.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO_7;
                    state_1.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc_14;
                }
            }
            else
            {
                __auto_0 = n28._Operations_.CreateDefault();
            }

            bool Update_22 = true;
            var Output_23 = this.__p_S3f3VMbPSrgM8LLhRsB5n9;
            if (Update_22)
            {
                Output_23 = this.__p_S3f3VMbPSrgM8LLhRsB5n9.Update(File_Path_In: File_Path_In, Data_In: __auto_0, Write_In: Write_In);
            }

            n4.Writer_VWy4rC6UCb0Nm7X4PoUFet that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = state_1 != this.__if_KJajBhQ0iC9QapgFGnyATQ || Output_23 != this.__p_S3f3VMbPSrgM8LLhRsB5n9 ? new Writer_VWy4rC6UCb0Nm7X4PoUFet(this)
                {__if_KJajBhQ0iC9QapgFGnyATQ = state_1, __p_S3f3VMbPSrgM8LLhRsB5n9 = Output_23} : that_24;
            else
            {
                this.__if_KJajBhQ0iC9QapgFGnyATQ = state_1;
                this.__p_S3f3VMbPSrgM8LLhRsB5n9 = Output_23;
            }

            return that_24;
        }

        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "S3f3VMbPSrgM8LLhRsB5n9", 64924U);
            var Output_1 = n19.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv.Create(Node_Context: Node_Context_0);
            n4.Writer_VWy4rC6UCb0Nm7X4PoUFet that_2 = this;
            this.__p_S3f3VMbPSrgM8LLhRsB5n9 = Output_1;
            this.__if_KJajBhQ0iC9QapgFGnyATQ = default(n2.Object);
            return that_2;
        }

        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __CreateDefault__()
        {
            n4.Writer_VWy4rC6UCb0Nm7X4PoUFet that_0 = this;
            this.__if_KJajBhQ0iC9QapgFGnyATQ = default(n2.Object);
            this.__p_S3f3VMbPSrgM8LLhRsB5n9 = n19.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_KJajBhQ0iC9QapgFGnyATQ);
            n1.CompilationHelper.SafeDispose(this.__p_S3f3VMbPSrgM8LLhRsB5n9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 64846U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "O2C8ICJQKV3L5Xlm61FVsa", Name = "__slot_O2C8ICJQKV3L5Xlm61FVsa")]
        public static string __slot_O2C8ICJQKV3L5Xlm61FVsa = "Editor";
        [n1.ElementAttribute(TracingId = 64881U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "J5LTVjcvltfQMhIndOvSg5", Name = "__slot_J5LTVjcvltfQMhIndOvSg5")]
        public static string __slot_J5LTVjcvltfQMhIndOvSg5 = "version";
        [n1.ElementAttribute(TracingId = 64910U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BfxaUxahNTAO6J50h3PlAu", Name = "__slot_BfxaUxahNTAO6J50h3PlAu")]
        public static string __slot_BfxaUxahNTAO6J50h3PlAu = "4";
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_KJajBhQ0iC9QapgFGnyATQ;
        [n1.ElementAttribute(TracingId = 64924U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "S3f3VMbPSrgM8LLhRsB5n9", Name = "XMLWriter (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n19.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __p_S3f3VMbPSrgM8LLhRsB5n9;
        static Writer_VWy4rC6UCb0Nm7X4PoUFet()
        {
        }

        public Writer_VWy4rC6UCb0Nm7X4PoUFet(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Writer_VWy4rC6UCb0Nm7X4PoUFet(Writer_VWy4rC6UCb0Nm7X4PoUFet other): base(other)
        {
            this.__if_KJajBhQ0iC9QapgFGnyATQ = other.__if_KJajBhQ0iC9QapgFGnyATQ;
            this.__p_S3f3VMbPSrgM8LLhRsB5n9 = other.__p_S3f3VMbPSrgM8LLhRsB5n9;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_KJajBhQ0iC9QapgFGnyATQ", in __if_KJajBhQ0iC9QapgFGnyATQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_S3f3VMbPSrgM8LLhRsB5n9", in __p_S3f3VMbPSrgM8LLhRsB5n9));
        }

        internal Writer_VWy4rC6UCb0Nm7X4PoUFet __WITH__(n2.Object __if_KJajBhQ0iC9QapgFGnyATQ, n19.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __p_S3f3VMbPSrgM8LLhRsB5n9)
        {
            n4.Writer_VWy4rC6UCb0Nm7X4PoUFet that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_KJajBhQ0iC9QapgFGnyATQ != this.__if_KJajBhQ0iC9QapgFGnyATQ || __p_S3f3VMbPSrgM8LLhRsB5n9 != this.__p_S3f3VMbPSrgM8LLhRsB5n9 ? new Writer_VWy4rC6UCb0Nm7X4PoUFet(this)
                {__if_KJajBhQ0iC9QapgFGnyATQ = __if_KJajBhQ0iC9QapgFGnyATQ, __p_S3f3VMbPSrgM8LLhRsB5n9 = __p_S3f3VMbPSrgM8LLhRsB5n9} : that_0;
            else
            {
                this.__if_KJajBhQ0iC9QapgFGnyATQ = __if_KJajBhQ0iC9QapgFGnyATQ;
                this.__p_S3f3VMbPSrgM8LLhRsB5n9 = __p_S3f3VMbPSrgM8LLhRsB5n9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Si0RDglNIQdMJB8ers2Jrn", Name = "__Si0RDglNIQdMJB8ers2Jrn")]
        [n2.SerializableAttribute]
        public class __Si0RDglNIQdMJB8ers2Jrn : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n7.XAttribute> __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = default(n10.Spread<n7.XAttribute>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n7.XElement> __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = default(n10.Spread<n7.XElement>);
            public __Si0RDglNIQdMJB8ers2Jrn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Si0RDglNIQdMJB8ers2Jrn(__Si0RDglNIQdMJB8ers2Jrn other): base(other)
            {
                this.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = other.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO;
                this.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = other.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO", in __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc", in __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc));
            }

            internal __Si0RDglNIQdMJB8ers2Jrn __WITH__(n10.Spread<n7.XAttribute> __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO, n10.Spread<n7.XElement> __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc)
            {
                __Si0RDglNIQdMJB8ers2Jrn that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO != this.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO || __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc != this.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc ? new __Si0RDglNIQdMJB8ers2Jrn(this)
                    {__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO, __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc} : that_0;
                else
                {
                    this.__pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO = __pin_group_Input_In_Af7UVkABJegNTvSlPlQ9IO;
                    this.__pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc = __pin_group_Input_In_UW3xTMe0REFLEBHWCbkWtc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103183U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Jd0xF0Rc2hCNIwHHficaF0", Name = "Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0")]
    [n2.SerializableAttribute]
    public class Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var instance = new Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var instance = new Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> Update<AdM>(n17.Path File_Path_In, bool Read_In, out n30.BezierSpline_R<T> Result_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n30.BezierSpline_R<T> __auto_1 = this.BezierSpline;
            var Output_4 = this.__p_Pd65SUFau4DOUMfQ7BfHa5.Update<AdM>(File_Path_In: File_Path_In, Read_In: Read_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Result_2, On_Data_Out: out bool On_Data_3);
            n10.Spread<n8.EditableBezierKnot_R<T>> __pad_Iyc87sx7lVgLO8dW9aAba0_5 = Result_2;
            n30.BezierSpline_R<T> __auto_6;
            var state_7 = n1.CompilationHelper.Restore<__HSxGCEdp1k4MKj0WsCYZYS>(this.__if_L1T271OgJyILYtflUAOHkU, __GetContext__());
            if (On_Data_3)
            {
                if (state_7 == null)
                {
                    state_7 = new __HSxGCEdp1k4MKj0WsCYZYS(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_QhGFRyQkrA7OHUZceG4cK4 = n14._Operations_.CreateDefault<n22.BezierKnot_R<T>>()};
                }

                var Output_8 = n30.BezierSpline_R<T>.CreateDefault();
                var builder_15 = n6.CollectionBuilders.GetBuilder(state_7.__cp_QhGFRyQkrA7OHUZceG4cK4, 16);
                n10.Spread<n22.BezierKnot_R<T>> output_16;
                try
                {
                    var i_11 = 0;
                    foreach (var item_9 in n6.CollectionExtensions.AsSpan(__pad_Iyc87sx7lVgLO8dW9aAba0_5))
                    {
                        var splicer_10 = item_9;
                        var i_local_12 = i_11;
                        n20._Operations_.ToBezierKnot<T, AdM>(EditableBezierKnot_In: splicer_10, BezierKnot_Out: out n22.BezierKnot_R<T> BezierKnot_14);
                        builder_15.Add(BezierKnot_14);
                        i_11++;
                    }
                }
                finally
                {
                    output_16 = builder_15.Commit();
                }

                var Output_17 = Output_8.Join(Knots_In: output_16);
                __auto_6 = Output_17;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_16 != state_7.__cp_QhGFRyQkrA7OHUZceG4cK4 ? new __HSxGCEdp1k4MKj0WsCYZYS(state_7)
                    {__cp_QhGFRyQkrA7OHUZceG4cK4 = output_16} : state_7;
                else
                {
                    state_7.__cp_QhGFRyQkrA7OHUZceG4cK4 = output_16;
                }
            }
            else
            {
                __auto_6 = __auto_1;
            }

            n30.BezierSpline_R<T> __auto_18 = __auto_6;
            Result_Out = __auto_6;
            n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = Output_4 != this.__p_Pd65SUFau4DOUMfQ7BfHa5 || Result_2 != this.__slot_Iyc87sx7lVgLO8dW9aAba0 || state_7 != this.__if_L1T271OgJyILYtflUAOHkU || __auto_6 != this.BezierSpline ? new Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T>(this)
                {__p_Pd65SUFau4DOUMfQ7BfHa5 = Output_4, __slot_Iyc87sx7lVgLO8dW9aAba0 = Result_2, __if_L1T271OgJyILYtflUAOHkU = state_7, BezierSpline = __auto_6} : that_19;
            else
            {
                this.__p_Pd65SUFau4DOUMfQ7BfHa5 = Output_4;
                this.__slot_Iyc87sx7lVgLO8dW9aAba0 = Result_2;
                this.__if_L1T271OgJyILYtflUAOHkU = state_7;
                this.BezierSpline = __auto_6;
            }

            return that_19;
        }

        public n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Pd65SUFau4DOUMfQ7BfHa5", 103212U);
            var Output_2 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>>.Create<AdM>(Node_Context: Node_Context_1);
            n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> that_3 = this;
            this.__slot_Iyc87sx7lVgLO8dW9aAba0 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            this.BezierSpline = n30.BezierSpline_R<T>.CreateDefault();
            this.__p_Pd65SUFau4DOUMfQ7BfHa5 = Output_2;
            this.__if_L1T271OgJyILYtflUAOHkU = default(n2.Object);
            return that_3;
        }

        public n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var w_0 = default(AdM);
            n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> that_1 = this;
            this.__slot_Iyc87sx7lVgLO8dW9aAba0 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            this.BezierSpline = n30.BezierSpline_R<T>.CreateDefault();
            this.__p_Pd65SUFau4DOUMfQ7BfHa5 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>>.CreateDefault<AdM>();
            this.__if_L1T271OgJyILYtflUAOHkU = default(n2.Object);
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Pd65SUFau4DOUMfQ7BfHa5);
            n1.CompilationHelper.SafeDispose(this.__if_L1T271OgJyILYtflUAOHkU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 103219U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Iyc87sx7lVgLO8dW9aAba0", Name = "__slot_Iyc87sx7lVgLO8dW9aAba0")]
        public n10.Spread<n8.EditableBezierKnot_R<T>> __slot_Iyc87sx7lVgLO8dW9aAba0;
        [n1.ElementAttribute(TracingId = 103187U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IKdCb1pXgcKORyYDSve9Hm", Name = "BezierSpline")]
        public n30.BezierSpline_R<T> BezierSpline;
        [n1.ElementAttribute(TracingId = 103212U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Pd65SUFau4DOUMfQ7BfHa5", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>> __p_Pd65SUFau4DOUMfQ7BfHa5;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_L1T271OgJyILYtflUAOHkU;
        public Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0(Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> other): base(other)
        {
            this.__slot_Iyc87sx7lVgLO8dW9aAba0 = other.__slot_Iyc87sx7lVgLO8dW9aAba0;
            this.BezierSpline = other.BezierSpline;
            this.__p_Pd65SUFau4DOUMfQ7BfHa5 = other.__p_Pd65SUFau4DOUMfQ7BfHa5;
            this.__if_L1T271OgJyILYtflUAOHkU = other.__if_L1T271OgJyILYtflUAOHkU;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Iyc87sx7lVgLO8dW9aAba0", in __slot_Iyc87sx7lVgLO8dW9aAba0), n1.CompilationHelper.GetValueOrExisting(values, "BezierSpline", in BezierSpline), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pd65SUFau4DOUMfQ7BfHa5", in __p_Pd65SUFau4DOUMfQ7BfHa5), n1.CompilationHelper.GetValueOrExisting(values, "__if_L1T271OgJyILYtflUAOHkU", in __if_L1T271OgJyILYtflUAOHkU));
        }

        internal Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> __WITH__(n10.Spread<n8.EditableBezierKnot_R<T>> __slot_Iyc87sx7lVgLO8dW9aAba0, n30.BezierSpline_R<T> BezierSpline, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>> __p_Pd65SUFau4DOUMfQ7BfHa5, n2.Object __if_L1T271OgJyILYtflUAOHkU)
        {
            n4.Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Iyc87sx7lVgLO8dW9aAba0 != this.__slot_Iyc87sx7lVgLO8dW9aAba0 || BezierSpline != this.BezierSpline || __p_Pd65SUFau4DOUMfQ7BfHa5 != this.__p_Pd65SUFau4DOUMfQ7BfHa5 || __if_L1T271OgJyILYtflUAOHkU != this.__if_L1T271OgJyILYtflUAOHkU ? new Reader_Bezier_2d_Jd0xF0Rc2hCNIwHHficaF0<T>(this)
                {__slot_Iyc87sx7lVgLO8dW9aAba0 = __slot_Iyc87sx7lVgLO8dW9aAba0, BezierSpline = BezierSpline, __p_Pd65SUFau4DOUMfQ7BfHa5 = __p_Pd65SUFau4DOUMfQ7BfHa5, __if_L1T271OgJyILYtflUAOHkU = __if_L1T271OgJyILYtflUAOHkU} : that_0;
            else
            {
                this.__slot_Iyc87sx7lVgLO8dW9aAba0 = __slot_Iyc87sx7lVgLO8dW9aAba0;
                this.BezierSpline = BezierSpline;
                this.__p_Pd65SUFau4DOUMfQ7BfHa5 = __p_Pd65SUFau4DOUMfQ7BfHa5;
                this.__if_L1T271OgJyILYtflUAOHkU = __if_L1T271OgJyILYtflUAOHkU;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HSxGCEdp1k4MKj0WsCYZYS", Name = "__HSxGCEdp1k4MKj0WsCYZYS")]
        [n2.SerializableAttribute]
        public class __HSxGCEdp1k4MKj0WsCYZYS : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n22.BezierKnot_R<T>> __cp_QhGFRyQkrA7OHUZceG4cK4;
            public __HSxGCEdp1k4MKj0WsCYZYS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HSxGCEdp1k4MKj0WsCYZYS(__HSxGCEdp1k4MKj0WsCYZYS other): base(other)
            {
                this.__cp_QhGFRyQkrA7OHUZceG4cK4 = other.__cp_QhGFRyQkrA7OHUZceG4cK4;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_QhGFRyQkrA7OHUZceG4cK4", in __cp_QhGFRyQkrA7OHUZceG4cK4));
            }

            internal __HSxGCEdp1k4MKj0WsCYZYS __WITH__(n10.Spread<n22.BezierKnot_R<T>> __cp_QhGFRyQkrA7OHUZceG4cK4)
            {
                __HSxGCEdp1k4MKj0WsCYZYS that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_QhGFRyQkrA7OHUZceG4cK4 != this.__cp_QhGFRyQkrA7OHUZceG4cK4 ? new __HSxGCEdp1k4MKj0WsCYZYS(this)
                    {__cp_QhGFRyQkrA7OHUZceG4cK4 = __cp_QhGFRyQkrA7OHUZceG4cK4} : that_0;
                else
                {
                    this.__cp_QhGFRyQkrA7OHUZceG4cK4 = __cp_QhGFRyQkrA7OHUZceG4cK4;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103244U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BThXaXf6hCENrjkT6jpIMQ", Name = "Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ")]
    [n2.SerializableAttribute]
    public class Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> CreateDefault()
        {
            var instance = new Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> Update<AdM>(n30.BezierSpline_R<T> BezierSpline_In, n17.Path File_Path_In, bool Write_In)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<n31.SerializablePoint_R<T>>
        {
            var w_0 = default(AdM);
            var Empty_1 = n14._Operations_.CreateDefault<n22.BezierKnot_R<n31.SerializablePoint_R<T>>>();
            n10.Spread<n22.BezierKnot_R<n31.SerializablePoint_R<T>>> __auto_2;
            var state_3 = n1.CompilationHelper.Restore<__OFCsoD13NUKPASyXVxZ5C2>(this.__if_FvcXkRYfes5MUmtlCfl3cz, __GetContext__());
            if (Write_In)
            {
                if (state_3 == null)
                {
                    state_3 = new __OFCsoD13NUKPASyXVxZ5C2(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_PGM6yMJPMxfNI0gWjkO8sq = n14._Operations_.CreateDefault<n22.BezierKnot_R<n31.SerializablePoint_R<T>>>()};
                }

                var Output_5 = BezierSpline_In.Split(Result_Out: out n10.Spread<n22.BezierKnot_R<T>> Result_4);
                int accumulator_7 = 0;
                var builder_33 = n6.CollectionBuilders.GetBuilder(state_3.__cp_PGM6yMJPMxfNI0gWjkO8sq, 16);
                n10.Spread<n22.BezierKnot_R<n31.SerializablePoint_R<T>>> output_34;
                try
                {
                    var i_9 = 0;
                    foreach (var item_6 in n6.CollectionExtensions.AsSpan(Result_4))
                    {
                        var splicer_8 = item_6;
                        var i_local_10 = i_9;
                        int __pad_H59unqPMn4QNTgKfCOG2oQ_12 = __slot_H59unqPMn4QNTgKfCOG2oQ;
                        int __pad_Aom4kMCy2ieQd6RAW1MAUX_13 = __slot_Aom4kMCy2ieQd6RAW1MAUX;
                        int __pad_MNet64xqoUOMZpuK7HhiAq_14 = __slot_MNet64xqoUOMZpuK7HhiAq;
                        int __pad_SibKNkFT9xDQPGx9UrTBny_15 = __slot_SibKNkFT9xDQPGx9UrTBny;
                        var Output_20 = splicer_8.Split(Point_Out: out T Point_16, Control1_Out: out T Control1_17, Control2_Out: out T Control2_18, Mode_Out: out int Mode_19);
                        var Output_21 = n31.SerializablePoint_R<T>.CreateDefault<AdM>();
                        var Output_22 = accumulator_7 + __pad_SibKNkFT9xDQPGx9UrTBny_15;
                        var Output_23 = Output_21.Join(Position_In: Point_16, Id_In: Output_22);
                        var Output_24 = accumulator_7 + __pad_H59unqPMn4QNTgKfCOG2oQ_12;
                        var Output_25 = Output_24 + __pad_MNet64xqoUOMZpuK7HhiAq_14;
                        var Output_26 = n31.SerializablePoint_R<T>.CreateDefault<AdM>();
                        var Output_27 = Output_26.Join(Position_In: Control2_18, Id_In: Output_24);
                        var Output_28 = n22.BezierKnot_R<n31.SerializablePoint_R<T>>.CreateDefault<AdM>();
                        var Output_29 = n31.SerializablePoint_R<T>.CreateDefault<AdM>();
                        var Output_30 = accumulator_7 + __pad_Aom4kMCy2ieQd6RAW1MAUX_13;
                        var Output_31 = Output_29.Join(Position_In: Control1_17, Id_In: Output_30);
                        var Output_32 = Output_28.Join<AdM>(Point_In: Output_23, Control1_In: Output_31, Control2_In: Output_27, Mode_In: Mode_19);
                        builder_33.Add(Output_32);
                        accumulator_7 = Output_25;
                        i_9++;
                    }
                }
                finally
                {
                    output_34 = builder_33.Commit();
                }

                __auto_2 = output_34;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = output_34 != state_3.__cp_PGM6yMJPMxfNI0gWjkO8sq ? new __OFCsoD13NUKPASyXVxZ5C2(state_3)
                    {__cp_PGM6yMJPMxfNI0gWjkO8sq = output_34} : state_3;
                else
                {
                    state_3.__cp_PGM6yMJPMxfNI0gWjkO8sq = output_34;
                }
            }
            else
            {
                __auto_2 = Empty_1;
            }

            bool Update_35 = true;
            var Output_36 = this.__p_RzwC5SYerhIL3ffkcvcnzN;
            if (Update_35)
            {
                Output_36 = this.__p_RzwC5SYerhIL3ffkcvcnzN.Update<n10.Spread<n22.BezierKnot_R<n31.SerializablePoint_R<T>>>>(Data_In: __auto_2, File_Path_In: File_Path_In, Write_In: Write_In);
            }

            n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = state_3 != this.__if_FvcXkRYfes5MUmtlCfl3cz || Output_36 != this.__p_RzwC5SYerhIL3ffkcvcnzN ? new Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T>(this)
                {__if_FvcXkRYfes5MUmtlCfl3cz = state_3, __p_RzwC5SYerhIL3ffkcvcnzN = Output_36} : that_37;
            else
            {
                this.__if_FvcXkRYfes5MUmtlCfl3cz = state_3;
                this.__p_RzwC5SYerhIL3ffkcvcnzN = Output_36;
            }

            return that_37;
        }

        public n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RzwC5SYerhIL3ffkcvcnzN", 103315U);
            var Output_1 = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.Create(Node_Context: Node_Context_0);
            n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> that_2 = this;
            this.__p_RzwC5SYerhIL3ffkcvcnzN = Output_1;
            this.__if_FvcXkRYfes5MUmtlCfl3cz = default(n2.Object);
            return that_2;
        }

        public n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> __CreateDefault__()
        {
            n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> that_0 = this;
            this.__if_FvcXkRYfes5MUmtlCfl3cz = default(n2.Object);
            this.__p_RzwC5SYerhIL3ffkcvcnzN = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_FvcXkRYfes5MUmtlCfl3cz);
            n1.CompilationHelper.SafeDispose(this.__p_RzwC5SYerhIL3ffkcvcnzN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 103306U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "H59unqPMn4QNTgKfCOG2oQ", Name = "__slot_H59unqPMn4QNTgKfCOG2oQ")]
        public static int __slot_H59unqPMn4QNTgKfCOG2oQ = 2;
        [n1.ElementAttribute(TracingId = 103301U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Aom4kMCy2ieQd6RAW1MAUX", Name = "__slot_Aom4kMCy2ieQd6RAW1MAUX")]
        public static int __slot_Aom4kMCy2ieQd6RAW1MAUX = 1;
        [n1.ElementAttribute(TracingId = 103311U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MNet64xqoUOMZpuK7HhiAq", Name = "__slot_MNet64xqoUOMZpuK7HhiAq")]
        public static int __slot_MNet64xqoUOMZpuK7HhiAq = 1;
        [n1.ElementAttribute(TracingId = 103296U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SibKNkFT9xDQPGx9UrTBny", Name = "__slot_SibKNkFT9xDQPGx9UrTBny")]
        public static int __slot_SibKNkFT9xDQPGx9UrTBny = 0;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_FvcXkRYfes5MUmtlCfl3cz;
        [n1.ElementAttribute(TracingId = 103315U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RzwC5SYerhIL3ffkcvcnzN", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_RzwC5SYerhIL3ffkcvcnzN;
        static Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ()
        {
        }

        public Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ(Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> other): base(other)
        {
            this.__if_FvcXkRYfes5MUmtlCfl3cz = other.__if_FvcXkRYfes5MUmtlCfl3cz;
            this.__p_RzwC5SYerhIL3ffkcvcnzN = other.__p_RzwC5SYerhIL3ffkcvcnzN;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_FvcXkRYfes5MUmtlCfl3cz", in __if_FvcXkRYfes5MUmtlCfl3cz), n1.CompilationHelper.GetValueOrExisting(values, "__p_RzwC5SYerhIL3ffkcvcnzN", in __p_RzwC5SYerhIL3ffkcvcnzN));
        }

        internal Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> __WITH__(n2.Object __if_FvcXkRYfes5MUmtlCfl3cz, n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_RzwC5SYerhIL3ffkcvcnzN)
        {
            n4.Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_FvcXkRYfes5MUmtlCfl3cz != this.__if_FvcXkRYfes5MUmtlCfl3cz || __p_RzwC5SYerhIL3ffkcvcnzN != this.__p_RzwC5SYerhIL3ffkcvcnzN ? new Writer_Bezier_BThXaXf6hCENrjkT6jpIMQ<T>(this)
                {__if_FvcXkRYfes5MUmtlCfl3cz = __if_FvcXkRYfes5MUmtlCfl3cz, __p_RzwC5SYerhIL3ffkcvcnzN = __p_RzwC5SYerhIL3ffkcvcnzN} : that_0;
            else
            {
                this.__if_FvcXkRYfes5MUmtlCfl3cz = __if_FvcXkRYfes5MUmtlCfl3cz;
                this.__p_RzwC5SYerhIL3ffkcvcnzN = __p_RzwC5SYerhIL3ffkcvcnzN;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OFCsoD13NUKPASyXVxZ5C2", Name = "__OFCsoD13NUKPASyXVxZ5C2")]
        [n2.SerializableAttribute]
        public class __OFCsoD13NUKPASyXVxZ5C2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n22.BezierKnot_R<n31.SerializablePoint_R<T>>> __cp_PGM6yMJPMxfNI0gWjkO8sq;
            public __OFCsoD13NUKPASyXVxZ5C2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OFCsoD13NUKPASyXVxZ5C2(__OFCsoD13NUKPASyXVxZ5C2 other): base(other)
            {
                this.__cp_PGM6yMJPMxfNI0gWjkO8sq = other.__cp_PGM6yMJPMxfNI0gWjkO8sq;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_PGM6yMJPMxfNI0gWjkO8sq", in __cp_PGM6yMJPMxfNI0gWjkO8sq));
            }

            internal __OFCsoD13NUKPASyXVxZ5C2 __WITH__(n10.Spread<n22.BezierKnot_R<n31.SerializablePoint_R<T>>> __cp_PGM6yMJPMxfNI0gWjkO8sq)
            {
                __OFCsoD13NUKPASyXVxZ5C2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_PGM6yMJPMxfNI0gWjkO8sq != this.__cp_PGM6yMJPMxfNI0gWjkO8sq ? new __OFCsoD13NUKPASyXVxZ5C2(this)
                    {__cp_PGM6yMJPMxfNI0gWjkO8sq = __cp_PGM6yMJPMxfNI0gWjkO8sq} : that_0;
                else
                {
                    this.__cp_PGM6yMJPMxfNI0gWjkO8sq = __cp_PGM6yMJPMxfNI0gWjkO8sq;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103363U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QeCJxY25XjaONjeqYnZyRQ", Name = "Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ")]
    [n2.SerializableAttribute]
    public class Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var instance = new Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var instance = new Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> Update<AdM>(n17.Path File_Path_In, bool Read_In, out n30.BezierSpline_R<T> Result_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n30.BezierSpline_R<T> __auto_1 = this.BezierSpline;
            var Output_4 = this.__p_TZ0aovxOygFO9A3gqh0S7d.Update<AdM>(File_Path_In: File_Path_In, Read_In: Read_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Result_2, On_Data_Out: out bool On_Data_3);
            n10.Spread<n8.EditableBezierKnot_R<T>> __pad_J2lACNWGNQdLjYnSGCDhHf_5 = Result_2;
            n30.BezierSpline_R<T> __auto_6;
            var state_7 = n1.CompilationHelper.Restore<__JF54SvXUCHcL3JIcwHI0eZ>(this.__if_Kxq16eAo4acNOMTgEzD9zK, __GetContext__());
            if (On_Data_3)
            {
                if (state_7 == null)
                {
                    state_7 = new __JF54SvXUCHcL3JIcwHI0eZ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_SSNDtAlou0sLIi6Dl0rk9H = n14._Operations_.CreateDefault<n22.BezierKnot_R<T>>()};
                }

                var Output_8 = n30.BezierSpline_R<T>.CreateDefault();
                var builder_15 = n6.CollectionBuilders.GetBuilder(state_7.__cp_SSNDtAlou0sLIi6Dl0rk9H, 16);
                n10.Spread<n22.BezierKnot_R<T>> output_16;
                try
                {
                    var i_11 = 0;
                    foreach (var item_9 in n6.CollectionExtensions.AsSpan(__pad_J2lACNWGNQdLjYnSGCDhHf_5))
                    {
                        var splicer_10 = item_9;
                        var i_local_12 = i_11;
                        n20._Operations_.ToBezierKnot<T, AdM>(EditableBezierKnot_In: splicer_10, BezierKnot_Out: out n22.BezierKnot_R<T> BezierKnot_14);
                        builder_15.Add(BezierKnot_14);
                        i_11++;
                    }
                }
                finally
                {
                    output_16 = builder_15.Commit();
                }

                var Output_17 = Output_8.Join(Knots_In: output_16);
                __auto_6 = Output_17;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_16 != state_7.__cp_SSNDtAlou0sLIi6Dl0rk9H ? new __JF54SvXUCHcL3JIcwHI0eZ(state_7)
                    {__cp_SSNDtAlou0sLIi6Dl0rk9H = output_16} : state_7;
                else
                {
                    state_7.__cp_SSNDtAlou0sLIi6Dl0rk9H = output_16;
                }
            }
            else
            {
                __auto_6 = __auto_1;
            }

            n30.BezierSpline_R<T> __auto_18 = __auto_6;
            Result_Out = __auto_6;
            n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = Output_4 != this.__p_TZ0aovxOygFO9A3gqh0S7d || Result_2 != this.__slot_J2lACNWGNQdLjYnSGCDhHf || state_7 != this.__if_Kxq16eAo4acNOMTgEzD9zK || __auto_6 != this.BezierSpline ? new Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T>(this)
                {__p_TZ0aovxOygFO9A3gqh0S7d = Output_4, __slot_J2lACNWGNQdLjYnSGCDhHf = Result_2, __if_Kxq16eAo4acNOMTgEzD9zK = state_7, BezierSpline = __auto_6} : that_19;
            else
            {
                this.__p_TZ0aovxOygFO9A3gqh0S7d = Output_4;
                this.__slot_J2lACNWGNQdLjYnSGCDhHf = Result_2;
                this.__if_Kxq16eAo4acNOMTgEzD9zK = state_7;
                this.BezierSpline = __auto_6;
            }

            return that_19;
        }

        public n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "TZ0aovxOygFO9A3gqh0S7d", 103392U);
            var Output_2 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>>.Create<AdM>(Node_Context: Node_Context_1);
            n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> that_3 = this;
            this.__slot_J2lACNWGNQdLjYnSGCDhHf = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            this.BezierSpline = n30.BezierSpline_R<T>.CreateDefault();
            this.__p_TZ0aovxOygFO9A3gqh0S7d = Output_2;
            this.__if_Kxq16eAo4acNOMTgEzD9zK = default(n2.Object);
            return that_3;
        }

        public n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<T>>>
        {
            var w_0 = default(AdM);
            n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> that_1 = this;
            this.__slot_J2lACNWGNQdLjYnSGCDhHf = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            this.BezierSpline = n30.BezierSpline_R<T>.CreateDefault();
            this.__p_TZ0aovxOygFO9A3gqh0S7d = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>>.CreateDefault<AdM>();
            this.__if_Kxq16eAo4acNOMTgEzD9zK = default(n2.Object);
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TZ0aovxOygFO9A3gqh0S7d);
            n1.CompilationHelper.SafeDispose(this.__if_Kxq16eAo4acNOMTgEzD9zK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 103399U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "J2lACNWGNQdLjYnSGCDhHf", Name = "__slot_J2lACNWGNQdLjYnSGCDhHf")]
        public n10.Spread<n8.EditableBezierKnot_R<T>> __slot_J2lACNWGNQdLjYnSGCDhHf;
        [n1.ElementAttribute(TracingId = 103367U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OqIrWDs6OGKLt8G1BVeFoL", Name = "BezierSpline")]
        public n30.BezierSpline_R<T> BezierSpline;
        [n1.ElementAttribute(TracingId = 103392U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TZ0aovxOygFO9A3gqh0S7d", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>> __p_TZ0aovxOygFO9A3gqh0S7d;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Kxq16eAo4acNOMTgEzD9zK;
        public Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ(Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> other): base(other)
        {
            this.__slot_J2lACNWGNQdLjYnSGCDhHf = other.__slot_J2lACNWGNQdLjYnSGCDhHf;
            this.BezierSpline = other.BezierSpline;
            this.__p_TZ0aovxOygFO9A3gqh0S7d = other.__p_TZ0aovxOygFO9A3gqh0S7d;
            this.__if_Kxq16eAo4acNOMTgEzD9zK = other.__if_Kxq16eAo4acNOMTgEzD9zK;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_J2lACNWGNQdLjYnSGCDhHf", in __slot_J2lACNWGNQdLjYnSGCDhHf), n1.CompilationHelper.GetValueOrExisting(values, "BezierSpline", in BezierSpline), n1.CompilationHelper.GetValueOrExisting(values, "__p_TZ0aovxOygFO9A3gqh0S7d", in __p_TZ0aovxOygFO9A3gqh0S7d), n1.CompilationHelper.GetValueOrExisting(values, "__if_Kxq16eAo4acNOMTgEzD9zK", in __if_Kxq16eAo4acNOMTgEzD9zK));
        }

        internal Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> __WITH__(n10.Spread<n8.EditableBezierKnot_R<T>> __slot_J2lACNWGNQdLjYnSGCDhHf, n30.BezierSpline_R<T> BezierSpline, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<T>>> __p_TZ0aovxOygFO9A3gqh0S7d, n2.Object __if_Kxq16eAo4acNOMTgEzD9zK)
        {
            n4.Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_J2lACNWGNQdLjYnSGCDhHf != this.__slot_J2lACNWGNQdLjYnSGCDhHf || BezierSpline != this.BezierSpline || __p_TZ0aovxOygFO9A3gqh0S7d != this.__p_TZ0aovxOygFO9A3gqh0S7d || __if_Kxq16eAo4acNOMTgEzD9zK != this.__if_Kxq16eAo4acNOMTgEzD9zK ? new Reader_Bezier_3d_QeCJxY25XjaONjeqYnZyRQ<T>(this)
                {__slot_J2lACNWGNQdLjYnSGCDhHf = __slot_J2lACNWGNQdLjYnSGCDhHf, BezierSpline = BezierSpline, __p_TZ0aovxOygFO9A3gqh0S7d = __p_TZ0aovxOygFO9A3gqh0S7d, __if_Kxq16eAo4acNOMTgEzD9zK = __if_Kxq16eAo4acNOMTgEzD9zK} : that_0;
            else
            {
                this.__slot_J2lACNWGNQdLjYnSGCDhHf = __slot_J2lACNWGNQdLjYnSGCDhHf;
                this.BezierSpline = BezierSpline;
                this.__p_TZ0aovxOygFO9A3gqh0S7d = __p_TZ0aovxOygFO9A3gqh0S7d;
                this.__if_Kxq16eAo4acNOMTgEzD9zK = __if_Kxq16eAo4acNOMTgEzD9zK;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JF54SvXUCHcL3JIcwHI0eZ", Name = "__JF54SvXUCHcL3JIcwHI0eZ")]
        [n2.SerializableAttribute]
        public class __JF54SvXUCHcL3JIcwHI0eZ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n22.BezierKnot_R<T>> __cp_SSNDtAlou0sLIi6Dl0rk9H;
            public __JF54SvXUCHcL3JIcwHI0eZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JF54SvXUCHcL3JIcwHI0eZ(__JF54SvXUCHcL3JIcwHI0eZ other): base(other)
            {
                this.__cp_SSNDtAlou0sLIi6Dl0rk9H = other.__cp_SSNDtAlou0sLIi6Dl0rk9H;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_SSNDtAlou0sLIi6Dl0rk9H", in __cp_SSNDtAlou0sLIi6Dl0rk9H));
            }

            internal __JF54SvXUCHcL3JIcwHI0eZ __WITH__(n10.Spread<n22.BezierKnot_R<T>> __cp_SSNDtAlou0sLIi6Dl0rk9H)
            {
                __JF54SvXUCHcL3JIcwHI0eZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_SSNDtAlou0sLIi6Dl0rk9H != this.__cp_SSNDtAlou0sLIi6Dl0rk9H ? new __JF54SvXUCHcL3JIcwHI0eZ(this)
                    {__cp_SSNDtAlou0sLIi6Dl0rk9H = __cp_SSNDtAlou0sLIi6Dl0rk9H} : that_0;
                else
                {
                    this.__cp_SSNDtAlou0sLIi6Dl0rk9H = __cp_SSNDtAlou0sLIi6Dl0rk9H;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103424U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HzSL7sYbUW9MJQ7oFUii7l", Name = "VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l")]
    [n2.SerializableAttribute]
    public class VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l CreateDefault()
        {
            var instance = new VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l Update()
        {
            return this;
        }

        public n4.VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l __CreateDefault__()
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

        public VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l(VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_EditorsApplication_HzSL7sYbUW9MJQ7oFUii7l __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Editors_.Editors.Reader
{
    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Fallback(n7.XElement Input_In, out n7.XElement Output_Out)
        {
            string __pad_Pmget1pO64WM6NhjWrqXuu_0 = __slot_Pmget1pO64WM6NhjWrqXuu;
            var Result_1 = n15.Extensions.XPathSelectElement(node: Input_In, expression: __pad_Pmget1pO64WM6NhjWrqXuu_0);
            n37.ObjectHelpers.IsAssigned(x: Result_1, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            n7.XElement __auto_4;
            if (Result_2)
            {
                n10.Spread<n7.XElement> __pin_group_Input_In_SVBCUNhi4MiOGqWlNKvw1A = default(n10.Spread<n7.XElement>);
                n10.Spread<n7.XAttribute> __pin_group_Input_In_RwzcU6pXsUhMHO1BF3f6v1 = default(n10.Spread<n7.XAttribute>);
                string __pad_T7yx19TGLQWOAop5t7ZQFI_5 = __slot_T7yx19TGLQWOAop5t7ZQFI;
                string __pad_VlwUc3oeYNTL9CCqBACRPM_6 = __slot_VlwUc3oeYNTL9CCqBACRPM;
                string __pad_AsDjC9KTLLMPf5Bt4eZXv9_7 = __slot_AsDjC9KTLLMPf5Bt4eZXv9;
                string __pad_A8A0CmSIDz9MgH4PDygz6a_8 = __slot_A8A0CmSIDz9MgH4PDygz6a;
                string __pad_DXRNgzlWhxlLVUsqbwA2uQ_9 = __slot_DXRNgzlWhxlLVUsqbwA2uQ;
                string __pad_NCFOekJhsx3L03hVHZxIYj_10 = __slot_NCFOekJhsx3L03hVHZxIYj;
                string __pad_NB3E9xVfBTyOiWsQJShfLW_11 = __slot_NB3E9xVfBTyOiWsQJShfLW;
                string __pad_AwJ7Wu88zN3LvhuXEsrtYx_12 = __slot_AwJ7Wu88zN3LvhuXEsrtYx;
                n11.XmlNodes.SplitXElement(input: Result_1, name: out string Name_13, value: out string Value_14, children: out n10.Spread<n7.XElement> Children_15, attributes: out n10.Spread<n7.XAttribute> Attributes_16);
                n31._Operations_.FromJsonAndNewLine(Input_In: Value_14, Output_Out: out n10.Spread<string> Output_17);
                var Result_18 = n11.XmlNodes.XAttributeByName(input: Input_In, name: __pad_T7yx19TGLQWOAop5t7ZQFI_5);
                n11.XmlNodes.SplitXAttribute(input: Result_18, name: out string Name_19, value: out string Value_20);
                var Result_21 = Value_20 == __pad_AwJ7Wu88zN3LvhuXEsrtYx_12;
                n7.XElement __auto_22;
                if (Result_21)
                {
                    n10.Spread<n8.EditablePoint_R<n3.Vector2>> __cp_SHb6ev6AW4jNONRyxtiSmj = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector2>>();
                    var builder_32 = n6.CollectionBuilders.GetBuilder(__cp_SHb6ev6AW4jNONRyxtiSmj, 16);
                    n10.Spread<n8.EditablePoint_R<n3.Vector2>> output_33;
                    try
                    {
                        var i_25 = 0;
                        foreach (var item_23 in n6.CollectionExtensions.AsSpan(Output_17))
                        {
                            var splicer_24 = item_23;
                            var i_local_26 = i_25;
                            string __pad_Sws6aB4abcJP3LU3latVhC_27 = __slot_Sws6aB4abcJP3LU3latVhC;
                            bool Write_Array_Attribute_28 = false;
                            var Result_29 = n11.XmlNodes.DeserializeXNode(json: splicer_24, deserializeRootElementName: __pad_Sws6aB4abcJP3LU3latVhC_27, writeArrayAttribute: Write_Array_Attribute_28);
                            n31._Operations_.ParseEditablePoint2d<n7.XDocument>(Input_In: Result_29, Path_In: __pad_Sws6aB4abcJP3LU3latVhC_27, Output_Out: out n8.EditablePoint_R<n3.Vector2> Output_30, Success_Out: out bool Success_31);
                            builder_32.Add(Output_30);
                            i_25++;
                        }
                    }
                    finally
                    {
                        output_33 = builder_32.Commit();
                    }

                    n1.NodeContext Node_Context_34 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CPrrtUDdgmKOJNJLX1kpXw", 63920U);
                    bool Include_Defaults_35 = false;
                    n16._Operations_.Serialize<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>(Value_In: output_33, Node_Context_In: Node_Context_34, Include_Defaults_In: Include_Defaults_35, Result_Out: out n7.XElement Result_36);
                    __auto_22 = Result_36;
                }
                else
                {
                    __auto_22 = n42._Operations_.CreateDefault();
                }

                var Result_37 = Value_20 == __pad_VlwUc3oeYNTL9CCqBACRPM_6;
                n7.XElement __auto_38;
                if (Result_37)
                {
                    n10.Spread<n8.EditablePoint_R<n3.Vector3>> __cp_GWZMKa2FpExQE1cfkn1lQ3 = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector3>>();
                    var builder_48 = n6.CollectionBuilders.GetBuilder(__cp_GWZMKa2FpExQE1cfkn1lQ3, 16);
                    n10.Spread<n8.EditablePoint_R<n3.Vector3>> output_49;
                    try
                    {
                        var i_41 = 0;
                        foreach (var item_39 in n6.CollectionExtensions.AsSpan(Output_17))
                        {
                            var splicer_40 = item_39;
                            var i_local_42 = i_41;
                            string __pad_Qwylmik562OOO2dzfNba5i_43 = __slot_Qwylmik562OOO2dzfNba5i;
                            bool Write_Array_Attribute_44 = false;
                            var Result_45 = n11.XmlNodes.DeserializeXNode(json: splicer_40, deserializeRootElementName: __pad_Qwylmik562OOO2dzfNba5i_43, writeArrayAttribute: Write_Array_Attribute_44);
                            n31._Operations_.ParseEditablePoint3d<n7.XDocument>(Input_In: Result_45, Path_In: __pad_Qwylmik562OOO2dzfNba5i_43, Output_Out: out n8.EditablePoint_R<n3.Vector3> Output_46, Success_Out: out bool Success_47);
                            builder_48.Add(Output_46);
                            i_41++;
                        }
                    }
                    finally
                    {
                        output_49 = builder_48.Commit();
                    }

                    n1.NodeContext Node_Context_50 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "A453mgWEZnuO3U8FEXVF1H", 64152U);
                    bool Include_Defaults_51 = false;
                    n16._Operations_.Serialize<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>(Value_In: output_49, Node_Context_In: Node_Context_50, Include_Defaults_In: Include_Defaults_51, Result_Out: out n7.XElement Result_52);
                    __auto_38 = Result_52;
                }
                else
                {
                    __auto_38 = __auto_22;
                }

                var Result_53 = Value_20 == __pad_AsDjC9KTLLMPf5Bt4eZXv9_7;
                n7.XElement __auto_54;
                if (Result_53)
                {
                    n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __cp_Dc33swR8KerNKe8qlMz0i9 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
                    var builder_64 = n6.CollectionBuilders.GetBuilder(__cp_Dc33swR8KerNKe8qlMz0i9, 16);
                    n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> output_65;
                    try
                    {
                        var i_57 = 0;
                        foreach (var item_55 in n6.CollectionExtensions.AsSpan(Output_17))
                        {
                            var splicer_56 = item_55;
                            var i_local_58 = i_57;
                            string __pad_TaXloAmYtF7L1Hdz8kTlCA_59 = __slot_TaXloAmYtF7L1Hdz8kTlCA;
                            bool Write_Array_Attribute_60 = false;
                            var Result_61 = n11.XmlNodes.DeserializeXNode(json: splicer_56, deserializeRootElementName: __pad_TaXloAmYtF7L1Hdz8kTlCA_59, writeArrayAttribute: Write_Array_Attribute_60);
                            n20._Operations_.ParseEditableBezierKnot2d<n7.XDocument>(Input_In: Result_61, Path_In: __pad_TaXloAmYtF7L1Hdz8kTlCA_59, Value_Out: out n8.EditableBezierKnot_R<n3.Vector2> Value_62, Success_Out: out bool Success_63);
                            builder_64.Add(Value_62);
                            i_57++;
                        }
                    }
                    finally
                    {
                        output_65 = builder_64.Commit();
                    }

                    n1.NodeContext Node_Context_66 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "KpjiBhhNub2PrvTq0bjUb1", 64291U);
                    bool Include_Defaults_67 = false;
                    n16._Operations_.Serialize<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>(Value_In: output_65, Node_Context_In: Node_Context_66, Include_Defaults_In: Include_Defaults_67, Result_Out: out n7.XElement Result_68);
                    __auto_54 = Result_68;
                }
                else
                {
                    __auto_54 = __auto_38;
                }

                var Result_69 = Value_20 == __pad_A8A0CmSIDz9MgH4PDygz6a_8;
                n7.XElement __auto_70;
                if (Result_69)
                {
                    n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> __cp_LykgNAVaVE1Nx8WlKr4cvc = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>();
                    var builder_80 = n6.CollectionBuilders.GetBuilder(__cp_LykgNAVaVE1Nx8WlKr4cvc, 16);
                    n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> output_81;
                    try
                    {
                        var i_73 = 0;
                        foreach (var item_71 in n6.CollectionExtensions.AsSpan(Output_17))
                        {
                            var splicer_72 = item_71;
                            var i_local_74 = i_73;
                            string __pad_BAo6YiOtivmM0W5TIzQ5Zi_75 = __slot_BAo6YiOtivmM0W5TIzQ5Zi;
                            bool Write_Array_Attribute_76 = false;
                            var Result_77 = n11.XmlNodes.DeserializeXNode(json: splicer_72, deserializeRootElementName: __pad_BAo6YiOtivmM0W5TIzQ5Zi_75, writeArrayAttribute: Write_Array_Attribute_76);
                            n20._Operations_.ParseEditableBezierKnot3d<n7.XDocument>(Input_In: Result_77, Path_In: __pad_BAo6YiOtivmM0W5TIzQ5Zi_75, Value_Out: out n8.EditableBezierKnot_R<n3.Vector3> Value_78, Success_Out: out bool Success_79);
                            builder_80.Add(Value_78);
                            i_73++;
                        }
                    }
                    finally
                    {
                        output_81 = builder_80.Commit();
                    }

                    n1.NodeContext Node_Context_82 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "SfGi23mFRJBLxMvFuo7IWg", 64443U);
                    bool Include_Defaults_83 = false;
                    n16._Operations_.Serialize<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>(Value_In: output_81, Node_Context_In: Node_Context_82, Include_Defaults_In: Include_Defaults_83, Result_Out: out n7.XElement Result_84);
                    __auto_70 = Result_84;
                }
                else
                {
                    __auto_70 = __auto_54;
                }

                var builder_85 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_SVBCUNhi4MiOGqWlNKvw1A, 1);
                builder_85.Add(__auto_70);
                var __pin_group_Input_In_SVBCUNhi4MiOGqWlNKvw1A_86 = builder_85.Commit();
                n14._Operations_.FromValue<n7.XElement>(Input_In: __pin_group_Input_In_SVBCUNhi4MiOGqWlNKvw1A_86, Result_Out: out n10.Spread<n7.XElement> Result_87);
                n23.IEnumerable<n7.XElement> Children_88 = (n23.IEnumerable<n7.XElement>)Result_87;
                var Result_89 = n11.XmlNodes.JoinXAttribute(name: __pad_NCFOekJhsx3L03hVHZxIYj_10, value: __pad_NB3E9xVfBTyOiWsQJShfLW_11);
                var builder_90 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_RwzcU6pXsUhMHO1BF3f6v1, 1);
                builder_90.Add(Result_89);
                var __pin_group_Input_In_RwzcU6pXsUhMHO1BF3f6v1_91 = builder_90.Commit();
                n14._Operations_.FromValue<n7.XAttribute>(Input_In: __pin_group_Input_In_RwzcU6pXsUhMHO1BF3f6v1_91, Result_Out: out n10.Spread<n7.XAttribute> Result_92);
                n23.IEnumerable<n7.XAttribute> Attributes_93 = (n23.IEnumerable<n7.XAttribute>)Result_92;
                string Value_94 = "";
                var Result_95 = n11.XmlNodes.JoinXElement(name: __pad_DXRNgzlWhxlLVUsqbwA2uQ_9, value: Value_94, attributes: Attributes_93, children: Children_88);
                __auto_4 = Result_95;
            }
            else
            {
                __auto_4 = Input_In;
            }

            Output_Out = __auto_4;
            return;
        }

        [n1.ElementAttribute(TracingId = 63717U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Pmget1pO64WM6NhjWrqXuu", Name = "__slot_Pmget1pO64WM6NhjWrqXuu")]
        public static string __slot_Pmget1pO64WM6NhjWrqXuu = "Data";
        [n1.ElementAttribute(TracingId = 63791U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "T7yx19TGLQWOAop5t7ZQFI", Name = "__slot_T7yx19TGLQWOAop5t7ZQFI")]
        public static string __slot_T7yx19TGLQWOAop5t7ZQFI = "type";
        [n1.ElementAttribute(TracingId = 64186U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VlwUc3oeYNTL9CCqBACRPM", Name = "__slot_VlwUc3oeYNTL9CCqBACRPM")]
        public static string __slot_VlwUc3oeYNTL9CCqBACRPM = "Point3D";
        [n1.ElementAttribute(TracingId = 64344U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AsDjC9KTLLMPf5Bt4eZXv9", Name = "__slot_AsDjC9KTLLMPf5Bt4eZXv9")]
        public static string __slot_AsDjC9KTLLMPf5Bt4eZXv9 = "BezierKnot2D";
        [n1.ElementAttribute(TracingId = 64478U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "A8A0CmSIDz9MgH4PDygz6a", Name = "__slot_A8A0CmSIDz9MgH4PDygz6a")]
        public static string __slot_A8A0CmSIDz9MgH4PDygz6a = "BezierKnot3D";
        [n1.ElementAttribute(TracingId = 63999U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DXRNgzlWhxlLVUsqbwA2uQ", Name = "__slot_DXRNgzlWhxlLVUsqbwA2uQ")]
        public static string __slot_DXRNgzlWhxlLVUsqbwA2uQ = "Editor";
        [n1.ElementAttribute(TracingId = 64026U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NCFOekJhsx3L03hVHZxIYj", Name = "__slot_NCFOekJhsx3L03hVHZxIYj")]
        public static string __slot_NCFOekJhsx3L03hVHZxIYj = "version";
        [n1.ElementAttribute(TracingId = 64036U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NB3E9xVfBTyOiWsQJShfLW", Name = "__slot_NB3E9xVfBTyOiWsQJShfLW")]
        public static string __slot_NB3E9xVfBTyOiWsQJShfLW = "4";
        [n1.ElementAttribute(TracingId = 63812U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AwJ7Wu88zN3LvhuXEsrtYx", Name = "__slot_AwJ7Wu88zN3LvhuXEsrtYx")]
        public static string __slot_AwJ7Wu88zN3LvhuXEsrtYx = "Point2D";
        [n1.ElementAttribute(TracingId = 63883U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Sws6aB4abcJP3LU3latVhC", Name = "__slot_Sws6aB4abcJP3LU3latVhC")]
        public static string __slot_Sws6aB4abcJP3LU3latVhC = "Knot";
        [n1.ElementAttribute(TracingId = 64105U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Qwylmik562OOO2dzfNba5i", Name = "__slot_Qwylmik562OOO2dzfNba5i")]
        public static string __slot_Qwylmik562OOO2dzfNba5i = "Knot";
        [n1.ElementAttribute(TracingId = 64267U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TaXloAmYtF7L1Hdz8kTlCA", Name = "__slot_TaXloAmYtF7L1Hdz8kTlCA")]
        public static string __slot_TaXloAmYtF7L1Hdz8kTlCA = "Knot";
        [n1.ElementAttribute(TracingId = 64404U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BAo6YiOtivmM0W5TIzQ5Zi", Name = "__slot_BAo6YiOtivmM0W5TIzQ5Zi")]
        public static string __slot_BAo6YiOtivmM0W5TIzQ5Zi = "Knot";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Editors_.Editors.Internal
{
    [n1.ElementAttribute(TracingId = 65209U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BFQaetPaesuQBJGrK2NH1d", Name = "ModeDetector_BFQaetPaesuQBJGrK2NH1d")]
    [n2.SerializableAttribute]
    public class ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ModeDetector_BFQaetPaesuQBJGrK2NH1d<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> CreateDefault()
        {
            var instance = new ModeDetector_BFQaetPaesuQBJGrK2NH1d<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> Update(bool Editing_In, n10.Spread<n8.EditablePoint_R<T>> Points_In, n3.RectangleF Selection_Rectangle_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Mouse_Buttons_In, out n10.Spread<n8.EditablePoint_R<T>> Points_Out, out bool Set_Selection_Out, out bool Pressed_Out, out bool Released_Out)
        {
            var Output_0 = !Editing_In;
            n10.Spread<n8.EditablePoint_R<T>> Output_1;
            bool Set_Selection_2;
            var state_3 = n1.CompilationHelper.Restore<__VlHqTLldLR5LpXlRPe2W7r>(this.__if_DlaPC5dqSK5N7mAoPe67Q0, __GetContext__());
            if (Output_0)
            {
                if (state_3 == null)
                {
                    state_3 = new __VlHqTLldLR5LpXlRPe2W7r(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_JqNLe6LlEQSMKRkTvNuZas = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>()};
                }

                bool accumulator_5 = false;
                var builder_17 = n6.CollectionBuilders.GetBuilder(state_3.__cp_JqNLe6LlEQSMKRkTvNuZas, 16);
                n10.Spread<n8.EditablePoint_R<T>> output_18;
                try
                {
                    var i_7 = 0;
                    foreach (var item_4 in n6.CollectionExtensions.AsSpan(Points_In))
                    {
                        var splicer_6 = item_4;
                        var i_local_8 = i_7;
                        var Output_11 = splicer_6.GetProjectedPosition(Position_Out: out n3.Vector2 Position_10);
                        n31._Operations_.InSelection(Input_In: Position_10, Rectangle_In: Selection_Rectangle_In, Pick_Size_In: Pick_Size_In, Result_Out: out bool Result_12);
                        int Modifier_13 = n2.Convert.ToInt32(Result_12);
                        bool Apply_14 = true;
                        var Output_15 = splicer_6;
                        if (Apply_14)
                        {
                            Output_15 = splicer_6.SetSelectionModifier(Modifier_In: Modifier_13);
                        }

                        var Output_16 = Result_12 || accumulator_5;
                        builder_17.Add(Output_15);
                        accumulator_5 = Output_16;
                        i_7++;
                    }
                }
                finally
                {
                    output_18 = builder_17.Commit();
                }

                Output_1 = output_18;
                Set_Selection_2 = accumulator_5;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = output_18 != state_3.__cp_JqNLe6LlEQSMKRkTvNuZas ? new __VlHqTLldLR5LpXlRPe2W7r(state_3)
                    {__cp_JqNLe6LlEQSMKRkTvNuZas = output_18} : state_3;
                else
                {
                    state_3.__cp_JqNLe6LlEQSMKRkTvNuZas = output_18;
                }
            }
            else
            {
                Output_1 = Points_In;
                Set_Selection_2 = false;
            }

            var Output_21 = this.__p_SmJdpVtNAbwLSiDEwkYGk9.Update(Value_In: Mouse_Buttons_In, Up_Edge_Out: out bool Up_Edge_19, Down_Edge_Out: out bool Down_Edge_20);
            Points_Out = Output_1;
            Set_Selection_Out = Set_Selection_2;
            Pressed_Out = Up_Edge_19;
            Released_Out = Down_Edge_20;
            n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = state_3 != this.__if_DlaPC5dqSK5N7mAoPe67Q0 || Output_21 != this.__p_SmJdpVtNAbwLSiDEwkYGk9 ? new ModeDetector_BFQaetPaesuQBJGrK2NH1d<T>(this)
                {__if_DlaPC5dqSK5N7mAoPe67Q0 = state_3, __p_SmJdpVtNAbwLSiDEwkYGk9 = Output_21} : that_22;
            else
            {
                this.__if_DlaPC5dqSK5N7mAoPe67Q0 = state_3;
                this.__p_SmJdpVtNAbwLSiDEwkYGk9 = Output_21;
            }

            return that_22;
        }

        public n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "SmJdpVtNAbwLSiDEwkYGk9", 65244U);
            var Output_1 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> that_2 = this;
            this.__p_SmJdpVtNAbwLSiDEwkYGk9 = Output_1;
            this.__if_DlaPC5dqSK5N7mAoPe67Q0 = default(n2.Object);
            return that_2;
        }

        public n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> __CreateDefault__()
        {
            n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> that_0 = this;
            this.__if_DlaPC5dqSK5N7mAoPe67Q0 = default(n2.Object);
            this.__p_SmJdpVtNAbwLSiDEwkYGk9 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_DlaPC5dqSK5N7mAoPe67Q0);
            n1.CompilationHelper.SafeDispose(this.__p_SmJdpVtNAbwLSiDEwkYGk9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_DlaPC5dqSK5N7mAoPe67Q0;
        [n1.ElementAttribute(TracingId = 65244U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SmJdpVtNAbwLSiDEwkYGk9", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SmJdpVtNAbwLSiDEwkYGk9;
        public ModeDetector_BFQaetPaesuQBJGrK2NH1d(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ModeDetector_BFQaetPaesuQBJGrK2NH1d(ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> other): base(other)
        {
            this.__if_DlaPC5dqSK5N7mAoPe67Q0 = other.__if_DlaPC5dqSK5N7mAoPe67Q0;
            this.__p_SmJdpVtNAbwLSiDEwkYGk9 = other.__p_SmJdpVtNAbwLSiDEwkYGk9;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_DlaPC5dqSK5N7mAoPe67Q0", in __if_DlaPC5dqSK5N7mAoPe67Q0), n1.CompilationHelper.GetValueOrExisting(values, "__p_SmJdpVtNAbwLSiDEwkYGk9", in __p_SmJdpVtNAbwLSiDEwkYGk9));
        }

        internal ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> __WITH__(n2.Object __if_DlaPC5dqSK5N7mAoPe67Q0, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SmJdpVtNAbwLSiDEwkYGk9)
        {
            n31.ModeDetector_BFQaetPaesuQBJGrK2NH1d<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_DlaPC5dqSK5N7mAoPe67Q0 != this.__if_DlaPC5dqSK5N7mAoPe67Q0 || __p_SmJdpVtNAbwLSiDEwkYGk9 != this.__p_SmJdpVtNAbwLSiDEwkYGk9 ? new ModeDetector_BFQaetPaesuQBJGrK2NH1d<T>(this)
                {__if_DlaPC5dqSK5N7mAoPe67Q0 = __if_DlaPC5dqSK5N7mAoPe67Q0, __p_SmJdpVtNAbwLSiDEwkYGk9 = __p_SmJdpVtNAbwLSiDEwkYGk9} : that_0;
            else
            {
                this.__if_DlaPC5dqSK5N7mAoPe67Q0 = __if_DlaPC5dqSK5N7mAoPe67Q0;
                this.__p_SmJdpVtNAbwLSiDEwkYGk9 = __p_SmJdpVtNAbwLSiDEwkYGk9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VlHqTLldLR5LpXlRPe2W7r", Name = "__VlHqTLldLR5LpXlRPe2W7r")]
        [n2.SerializableAttribute]
        public class __VlHqTLldLR5LpXlRPe2W7r : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n8.EditablePoint_R<T>> __cp_JqNLe6LlEQSMKRkTvNuZas;
            public __VlHqTLldLR5LpXlRPe2W7r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VlHqTLldLR5LpXlRPe2W7r(__VlHqTLldLR5LpXlRPe2W7r other): base(other)
            {
                this.__cp_JqNLe6LlEQSMKRkTvNuZas = other.__cp_JqNLe6LlEQSMKRkTvNuZas;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_JqNLe6LlEQSMKRkTvNuZas", in __cp_JqNLe6LlEQSMKRkTvNuZas));
            }

            internal __VlHqTLldLR5LpXlRPe2W7r __WITH__(n10.Spread<n8.EditablePoint_R<T>> __cp_JqNLe6LlEQSMKRkTvNuZas)
            {
                __VlHqTLldLR5LpXlRPe2W7r that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_JqNLe6LlEQSMKRkTvNuZas != this.__cp_JqNLe6LlEQSMKRkTvNuZas ? new __VlHqTLldLR5LpXlRPe2W7r(this)
                    {__cp_JqNLe6LlEQSMKRkTvNuZas = __cp_JqNLe6LlEQSMKRkTvNuZas} : that_0;
                else
                {
                    this.__cp_JqNLe6LlEQSMKRkTvNuZas = __cp_JqNLe6LlEQSMKRkTvNuZas;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 65456U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "U4WhUIJIZ12QZXLRrxVqkU", Name = "SelectionRect_U4WhUIJIZ12QZXLRrxVqkU")]
    [n2.SerializableAttribute]
    public class SelectionRect_U4WhUIJIZ12QZXLRrxVqkU : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU Create(n1.NodeContext Node_Context)
        {
            var instance = new SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU CreateDefault()
        {
            var instance = new SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU Update(n3.Vector2 Position_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Select_In, out n3.RectangleF Selection_Out)
        {
            float __pad_GH8gs5qckQ6MdJYXINco5T_0 = __slot_GH8gs5qckQ6MdJYXINco5T;
            var Output_3 = this.__p_Kmq0flhp6zlLktGvOEh6iD.Update(Value_In: Select_In, Up_Edge_Out: out bool Up_Edge_1, Down_Edge_Out: out bool Down_Edge_2);
            bool SetValue_4 = true;
            var Output_5 = this.__p_BO64SbXwx3bO5V6Rnt8Vh6;
            if (SetValue_4)
            {
                Output_5 = this.__p_BO64SbXwx3bO5V6Rnt8Vh6.SetValue(Value_In: Position_In, Sample_In: Up_Edge_1);
            }

            var Output_7 = Output_5.GetValue(Value_Out: out n3.Vector2 Value_6);
            bool SetValue_8 = true;
            var Output_9 = this.__p_I23M4slls5ePRsMemtFdXP;
            if (SetValue_8)
            {
                Output_9 = this.__p_I23M4slls5ePRsMemtFdXP.SetValue(Value_In: Position_In, Sample_In: Select_In);
            }

            var Output_11 = Output_9.GetValue(Value_Out: out n3.Vector2 Value_10);
            bool Apply_12 = true;
            var Output_13 = Value_10;
            if (Apply_12)
            {
                var Output_14 = n46.Vector2Nodes.Lerp(input: ref Value_10, input2: ref Value_6, scalar: __pad_GH8gs5qckQ6MdJYXINco5T_0);
                Output_13 = Output_14;
            }

            bool Apply_15 = true;
            var Output_16 = Value_10;
            if (Apply_15)
            {
                n3.Vector2.Subtract(left: ref Value_10, right: ref Value_6, result: out n3.Vector2 Output_17);
                Output_16 = Output_17;
            }

            n46.Vector2Nodes.Vector(input: ref Output_16, x: out float X_18, y: out float Y_19);
            bool Apply_20 = true;
            var Output_21 = X_18;
            if (Apply_20)
            {
                n47._Operations_.Abs<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: X_18, Output_Out: out Output_21);
            }

            bool Apply_22 = true;
            var Output_23 = Y_19;
            if (Apply_22)
            {
                n47._Operations_.Abs<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Y_19, Output_Out: out Output_23);
            }

            var Output_24 = new n3.Vector2(x: Output_21, y: Output_23);
            var Result_25 = n46.RectangleNodes.FromCenterSize(center: ref Output_13, size: ref Output_24);
            Selection_Out = Result_25;
            n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = Output_3 != this.__p_Kmq0flhp6zlLktGvOEh6iD || Output_7 != this.__p_BO64SbXwx3bO5V6Rnt8Vh6 || Output_11 != this.__p_I23M4slls5ePRsMemtFdXP ? new SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(this)
                {__p_Kmq0flhp6zlLktGvOEh6iD = Output_3, __p_BO64SbXwx3bO5V6Rnt8Vh6 = Output_7, __p_I23M4slls5ePRsMemtFdXP = Output_11} : that_26;
            else
            {
                this.__p_Kmq0flhp6zlLktGvOEh6iD = Output_3;
                this.__p_BO64SbXwx3bO5V6Rnt8Vh6 = Output_7;
                this.__p_I23M4slls5ePRsMemtFdXP = Output_11;
            }

            return that_26;
        }

        public n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "BO64SbXwx3bO5V6Rnt8Vh6", 65577U);
            n3.Vector2 Initial_Value_1 = n48._Operations_.CreateDefault();
            var Output_2 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2>.Create(Node_Context: Node_Context_0, Initial_Value_In: Initial_Value_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Kmq0flhp6zlLktGvOEh6iD", 65605U);
            var Output_4 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "I23M4slls5ePRsMemtFdXP", 65626U);
            n3.Vector2 Initial_Value_6 = n48._Operations_.CreateDefault();
            var Output_7 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2>.Create(Node_Context: Node_Context_5, Initial_Value_In: Initial_Value_6);
            n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU that_8 = this;
            this.__p_BO64SbXwx3bO5V6Rnt8Vh6 = Output_2;
            this.__p_Kmq0flhp6zlLktGvOEh6iD = Output_4;
            this.__p_I23M4slls5ePRsMemtFdXP = Output_7;
            return that_8;
        }

        public n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU __CreateDefault__()
        {
            n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU that_0 = this;
            this.__p_Kmq0flhp6zlLktGvOEh6iD = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_BO64SbXwx3bO5V6Rnt8Vh6 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2>.CreateDefault();
            this.__p_I23M4slls5ePRsMemtFdXP = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Kmq0flhp6zlLktGvOEh6iD);
            n1.CompilationHelper.SafeDispose(this.__p_BO64SbXwx3bO5V6Rnt8Vh6);
            n1.CompilationHelper.SafeDispose(this.__p_I23M4slls5ePRsMemtFdXP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 65479U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GH8gs5qckQ6MdJYXINco5T", Name = "__slot_GH8gs5qckQ6MdJYXINco5T")]
        public static float __slot_GH8gs5qckQ6MdJYXINco5T = 0.499999821F;
        [n1.ElementAttribute(TracingId = 65605U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Kmq0flhp6zlLktGvOEh6iD", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Kmq0flhp6zlLktGvOEh6iD;
        [n1.ElementAttribute(TracingId = 65577U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BO64SbXwx3bO5V6Rnt8Vh6", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_BO64SbXwx3bO5V6Rnt8Vh6;
        [n1.ElementAttribute(TracingId = 65626U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I23M4slls5ePRsMemtFdXP", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_I23M4slls5ePRsMemtFdXP;
        static SelectionRect_U4WhUIJIZ12QZXLRrxVqkU()
        {
        }

        public SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(SelectionRect_U4WhUIJIZ12QZXLRrxVqkU other): base(other)
        {
            this.__p_Kmq0flhp6zlLktGvOEh6iD = other.__p_Kmq0flhp6zlLktGvOEh6iD;
            this.__p_BO64SbXwx3bO5V6Rnt8Vh6 = other.__p_BO64SbXwx3bO5V6Rnt8Vh6;
            this.__p_I23M4slls5ePRsMemtFdXP = other.__p_I23M4slls5ePRsMemtFdXP;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Kmq0flhp6zlLktGvOEh6iD", in __p_Kmq0flhp6zlLktGvOEh6iD), n1.CompilationHelper.GetValueOrExisting(values, "__p_BO64SbXwx3bO5V6Rnt8Vh6", in __p_BO64SbXwx3bO5V6Rnt8Vh6), n1.CompilationHelper.GetValueOrExisting(values, "__p_I23M4slls5ePRsMemtFdXP", in __p_I23M4slls5ePRsMemtFdXP));
        }

        internal SelectionRect_U4WhUIJIZ12QZXLRrxVqkU __WITH__(n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Kmq0flhp6zlLktGvOEh6iD, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_BO64SbXwx3bO5V6Rnt8Vh6, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_I23M4slls5ePRsMemtFdXP)
        {
            n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Kmq0flhp6zlLktGvOEh6iD != this.__p_Kmq0flhp6zlLktGvOEh6iD || __p_BO64SbXwx3bO5V6Rnt8Vh6 != this.__p_BO64SbXwx3bO5V6Rnt8Vh6 || __p_I23M4slls5ePRsMemtFdXP != this.__p_I23M4slls5ePRsMemtFdXP ? new SelectionRect_U4WhUIJIZ12QZXLRrxVqkU(this)
                {__p_Kmq0flhp6zlLktGvOEh6iD = __p_Kmq0flhp6zlLktGvOEh6iD, __p_BO64SbXwx3bO5V6Rnt8Vh6 = __p_BO64SbXwx3bO5V6Rnt8Vh6, __p_I23M4slls5ePRsMemtFdXP = __p_I23M4slls5ePRsMemtFdXP} : that_0;
            else
            {
                this.__p_Kmq0flhp6zlLktGvOEh6iD = __p_Kmq0flhp6zlLktGvOEh6iD;
                this.__p_BO64SbXwx3bO5V6Rnt8Vh6 = __p_BO64SbXwx3bO5V6Rnt8Vh6;
                this.__p_I23M4slls5ePRsMemtFdXP = __p_I23M4slls5ePRsMemtFdXP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 71789U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Rti32WMsT7ZN1y93rtaCiY", Name = "SerializablePoint_R")]
    [n2.SerializableAttribute]
    public class SerializablePoint_R<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n31.SerializablePoint_R<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new SerializablePoint_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n31.SerializablePoint_R<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n31.SerializablePoint_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new SerializablePoint_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n31.SerializablePoint_R<T> __DEFAULT__;
        public n31.SerializablePoint_R<T> Join(T Position_In, int Id_In)
        {
            T __auto_0 = Position_In;
            int __auto_1 = Id_In;
            n31.SerializablePoint_R<T> that_2 = this;
            that_2 = !n23.EqualityComparer<T>.Default.Equals(Position_In, this.Position) || Id_In != this.Id ? new SerializablePoint_R<T>(this)
            {Position = Position_In, Id = Id_In} : that_2;
            return that_2;
        }

        public n31.SerializablePoint_R<T> Split(out T Position_Out, out int Id_Out)
        {
            T __auto_0 = this.Position;
            int __auto_1 = this.Id;
            Position_Out = __auto_0;
            Id_Out = __auto_1;
            return this;
        }

        public n31.SerializablePoint_R<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_1);
            n31.SerializablePoint_R<T> that_1 = this;
            this.Position = __out_1;
            this.Id = 0;
            return that_1;
        }

        public n31.SerializablePoint_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_2);
            n31.SerializablePoint_R<T> that_1 = this;
            this.Position = __out_2;
            this.Id = 0;
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

        [n1.ElementAttribute(TracingId = 71791U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CBwVkyoViXTNCGIsYXCOB0", Name = "Position")]
        public T Position;
        [n1.ElementAttribute(TracingId = 71792U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KPlMJXNuAvfOxrHU8Sb2My", Name = "Id")]
        public int Id;
        public SerializablePoint_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SerializablePoint_R(SerializablePoint_R<T> other): base(other)
        {
            this.Position = other.Position;
            this.Id = other.Id;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Id", in Id));
        }

        internal SerializablePoint_R<T> __WITH__(T Position, int Id)
        {
            n31.SerializablePoint_R<T> that_0 = this;
            that_0 = !n23.EqualityComparer<T>.Default.Equals(Position, this.Position) || Id != this.Id ? new SerializablePoint_R<T>(this)
            {Position = Position, Id = Id} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 71832U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VVBCmtJv67lLPJWYmZwjXn", Name = "ActionSelector_VVBCmtJv67lLPJWYmZwjXn")]
    [n2.SerializableAttribute]
    public class ActionSelector_VVBCmtJv67lLPJWYmZwjXn : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn Create(n1.NodeContext Node_Context)
        {
            var instance = new ActionSelector_VVBCmtJv67lLPJWYmZwjXn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn CreateDefault()
        {
            var instance = new ActionSelector_VVBCmtJv67lLPJWYmZwjXn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn Update<T>(n10.Spread<T> Knots_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Add_In, bool LockControls_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Closed_In, bool RemoveKnot_In, [n6.SerializedDefaultValueAttribute("True", false)] bool ToggleSmoothness_In, [n6.SerializedDefaultValueAttribute("True", false)] bool ShiftKey_In, out bool AddKnot_Out, out bool LockControls_Out, out bool HideEndsControls_Out, out bool SmoothEndsControls_Out, out bool Closed_Out, out bool PushHistory_Out, out bool RemoveKnot_Out, out bool AddKnotOnCurve_Out, out bool FindPointOnCurve_Out, out bool ToggleSmoothness_Out)
        {
            int __pad_QR49pKqYajDMUOsuoLtDJm_0 = __slot_QR49pKqYajDMUOsuoLtDJm;
            int __pad_AmnqEBu42OSN4k6apx4t3V_1 = __slot_AmnqEBu42OSN4k6apx4t3V;
            n14._Operations_.Count<T>(Input_In: Knots_In, Count_Out: out int Count_2);
            var Result_3 = Count_2 < __pad_QR49pKqYajDMUOsuoLtDJm_0;
            var Output_4 = this.__p_T26jg5vYSrFQC9FI1S9uSx;
            if (Closed_In)
            {
                Output_4 = this.__p_T26jg5vYSrFQC9FI1S9uSx.Flip();
            }

            var Output_5 = Output_4;
            if (Result_3)
            {
                Output_5 = Output_4.Reset();
            }

            var Output_7 = Output_5.GetValue(Value_Out: out bool Value_6);
            var Result_8 = Count_2 > __pad_AmnqEBu42OSN4k6apx4t3V_1;
            bool Apply_9 = true;
            var Output_10 = Result_8;
            if (Apply_9)
            {
                var Output_11 = Result_8 && ToggleSmoothness_In;
                Output_10 = Output_11;
            }

            var Output_14 = this.__p_IR4cypj1MNHQZdf0G4u4CI.Update(Value_In: Value_6, Result_Out: out bool Result_12, Unchanged_Out: out bool Unchanged_13);
            bool Apply_15 = true;
            var Output_16 = Value_6;
            if (Apply_15)
            {
                var Output_17 = !Value_6;
                Output_16 = Output_17;
            }

            var Output_20 = this.__p_BCMtcs1659cPF7S97bqVBK.Update(Value_In: Add_In, Up_Edge_Out: out bool Up_Edge_18, Down_Edge_Out: out bool Down_Edge_19);
            bool Apply_21 = true;
            var Output_22 = ShiftKey_In;
            if (Apply_21)
            {
                var Output_23 = !ShiftKey_In;
                Output_22 = Output_23;
            }

            var Output_24 = Output_16 && Up_Edge_18;
            var Output_25 = Output_24 && Output_22;
            var Output_26 = LockControls_In || RemoveKnot_In;
            var Output_27 = Output_26 || ToggleSmoothness_In;
            var Output_28 = Output_27 || Result_12;
            var Output_29 = Output_28 || Output_25;
            bool Apply_30 = true;
            var Output_31 = Value_6;
            if (Apply_30)
            {
                var Output_32 = Value_6 && Up_Edge_18;
                Output_31 = Output_32;
            }

            bool Apply_33 = true;
            var Output_34 = Up_Edge_18;
            if (Apply_33)
            {
                var Output_35 = Up_Edge_18 && ShiftKey_In;
                Output_34 = Output_35;
            }

            bool Apply_36 = true;
            var Output_37 = Output_31;
            if (Apply_36)
            {
                var Output_38 = Output_31 || Output_34;
                Output_37 = Output_38;
            }

            bool Apply_39 = true;
            var Output_40 = Value_6;
            if (Apply_39)
            {
                var Output_41 = Value_6 || ShiftKey_In;
                Output_40 = Output_41;
            }

            var Output_44 = this.__p_TGbv9cYLUniPssRL6VE0kq.Update(Value_In: Value_6, Up_Edge_Out: out bool Up_Edge_42, Down_Edge_Out: out bool Down_Edge_43);
            bool Apply_45 = true;
            var Output_46 = Value_6;
            if (Apply_45)
            {
                var Output_47 = !Value_6;
                Output_46 = Output_47;
            }

            AddKnot_Out = Output_25;
            LockControls_Out = LockControls_In;
            HideEndsControls_Out = Output_46;
            SmoothEndsControls_Out = Up_Edge_42;
            Closed_Out = Value_6;
            PushHistory_Out = Output_29;
            RemoveKnot_Out = RemoveKnot_In;
            AddKnotOnCurve_Out = Output_37;
            FindPointOnCurve_Out = Output_40;
            ToggleSmoothness_Out = Output_10;
            n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn that_48 = this;
            if (this.__GetContext__().IsImmutable)
                that_48 = Output_7 != this.__p_T26jg5vYSrFQC9FI1S9uSx || Output_14 != this.__p_IR4cypj1MNHQZdf0G4u4CI || Output_20 != this.__p_BCMtcs1659cPF7S97bqVBK || Output_44 != this.__p_TGbv9cYLUniPssRL6VE0kq ? new ActionSelector_VVBCmtJv67lLPJWYmZwjXn(this)
                {__p_T26jg5vYSrFQC9FI1S9uSx = Output_7, __p_IR4cypj1MNHQZdf0G4u4CI = Output_14, __p_BCMtcs1659cPF7S97bqVBK = Output_20, __p_TGbv9cYLUniPssRL6VE0kq = Output_44} : that_48;
            else
            {
                this.__p_T26jg5vYSrFQC9FI1S9uSx = Output_7;
                this.__p_IR4cypj1MNHQZdf0G4u4CI = Output_14;
                this.__p_BCMtcs1659cPF7S97bqVBK = Output_20;
                this.__p_TGbv9cYLUniPssRL6VE0kq = Output_44;
            }

            return that_48;
        }

        public n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "BCMtcs1659cPF7S97bqVBK", 71904U);
            var Output_1 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "T26jg5vYSrFQC9FI1S9uSx", 71911U);
            var Output_3 = n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IR4cypj1MNHQZdf0G4u4CI", 71921U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n41.Changed_A8JGbead2bxNdnPybiEqVS<bool>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "TGbv9cYLUniPssRL6VE0kq", 72022U);
            var Output_8 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_7);
            n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn that_9 = this;
            this.__p_BCMtcs1659cPF7S97bqVBK = Output_1;
            this.__p_T26jg5vYSrFQC9FI1S9uSx = Output_3;
            this.__p_IR4cypj1MNHQZdf0G4u4CI = Output_6;
            this.__p_TGbv9cYLUniPssRL6VE0kq = Output_8;
            return that_9;
        }

        public n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn __CreateDefault__()
        {
            n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn that_0 = this;
            this.__p_T26jg5vYSrFQC9FI1S9uSx = n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            this.__p_IR4cypj1MNHQZdf0G4u4CI = n41.Changed_A8JGbead2bxNdnPybiEqVS<bool>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_BCMtcs1659cPF7S97bqVBK = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_TGbv9cYLUniPssRL6VE0kq = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_T26jg5vYSrFQC9FI1S9uSx);
            n1.CompilationHelper.SafeDispose(this.__p_IR4cypj1MNHQZdf0G4u4CI);
            n1.CompilationHelper.SafeDispose(this.__p_BCMtcs1659cPF7S97bqVBK);
            n1.CompilationHelper.SafeDispose(this.__p_TGbv9cYLUniPssRL6VE0kq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 71887U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QR49pKqYajDMUOsuoLtDJm", Name = "__slot_QR49pKqYajDMUOsuoLtDJm")]
        public static int __slot_QR49pKqYajDMUOsuoLtDJm = 3;
        [n1.ElementAttribute(TracingId = 71892U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AmnqEBu42OSN4k6apx4t3V", Name = "__slot_AmnqEBu42OSN4k6apx4t3V")]
        public static int __slot_AmnqEBu42OSN4k6apx4t3V = 2;
        [n1.ElementAttribute(TracingId = 71911U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "T26jg5vYSrFQC9FI1S9uSx", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_T26jg5vYSrFQC9FI1S9uSx;
        [n1.ElementAttribute(TracingId = 71921U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IR4cypj1MNHQZdf0G4u4CI", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_IR4cypj1MNHQZdf0G4u4CI;
        [n1.ElementAttribute(TracingId = 71904U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BCMtcs1659cPF7S97bqVBK", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_BCMtcs1659cPF7S97bqVBK;
        [n1.ElementAttribute(TracingId = 72022U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TGbv9cYLUniPssRL6VE0kq", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_TGbv9cYLUniPssRL6VE0kq;
        static ActionSelector_VVBCmtJv67lLPJWYmZwjXn()
        {
        }

        public ActionSelector_VVBCmtJv67lLPJWYmZwjXn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ActionSelector_VVBCmtJv67lLPJWYmZwjXn(ActionSelector_VVBCmtJv67lLPJWYmZwjXn other): base(other)
        {
            this.__p_T26jg5vYSrFQC9FI1S9uSx = other.__p_T26jg5vYSrFQC9FI1S9uSx;
            this.__p_IR4cypj1MNHQZdf0G4u4CI = other.__p_IR4cypj1MNHQZdf0G4u4CI;
            this.__p_BCMtcs1659cPF7S97bqVBK = other.__p_BCMtcs1659cPF7S97bqVBK;
            this.__p_TGbv9cYLUniPssRL6VE0kq = other.__p_TGbv9cYLUniPssRL6VE0kq;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_T26jg5vYSrFQC9FI1S9uSx", in __p_T26jg5vYSrFQC9FI1S9uSx), n1.CompilationHelper.GetValueOrExisting(values, "__p_IR4cypj1MNHQZdf0G4u4CI", in __p_IR4cypj1MNHQZdf0G4u4CI), n1.CompilationHelper.GetValueOrExisting(values, "__p_BCMtcs1659cPF7S97bqVBK", in __p_BCMtcs1659cPF7S97bqVBK), n1.CompilationHelper.GetValueOrExisting(values, "__p_TGbv9cYLUniPssRL6VE0kq", in __p_TGbv9cYLUniPssRL6VE0kq));
        }

        internal ActionSelector_VVBCmtJv67lLPJWYmZwjXn __WITH__(n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_T26jg5vYSrFQC9FI1S9uSx, n41.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_IR4cypj1MNHQZdf0G4u4CI, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_BCMtcs1659cPF7S97bqVBK, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_TGbv9cYLUniPssRL6VE0kq)
        {
            n31.ActionSelector_VVBCmtJv67lLPJWYmZwjXn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_T26jg5vYSrFQC9FI1S9uSx != this.__p_T26jg5vYSrFQC9FI1S9uSx || __p_IR4cypj1MNHQZdf0G4u4CI != this.__p_IR4cypj1MNHQZdf0G4u4CI || __p_BCMtcs1659cPF7S97bqVBK != this.__p_BCMtcs1659cPF7S97bqVBK || __p_TGbv9cYLUniPssRL6VE0kq != this.__p_TGbv9cYLUniPssRL6VE0kq ? new ActionSelector_VVBCmtJv67lLPJWYmZwjXn(this)
                {__p_T26jg5vYSrFQC9FI1S9uSx = __p_T26jg5vYSrFQC9FI1S9uSx, __p_IR4cypj1MNHQZdf0G4u4CI = __p_IR4cypj1MNHQZdf0G4u4CI, __p_BCMtcs1659cPF7S97bqVBK = __p_BCMtcs1659cPF7S97bqVBK, __p_TGbv9cYLUniPssRL6VE0kq = __p_TGbv9cYLUniPssRL6VE0kq} : that_0;
            else
            {
                this.__p_T26jg5vYSrFQC9FI1S9uSx = __p_T26jg5vYSrFQC9FI1S9uSx;
                this.__p_IR4cypj1MNHQZdf0G4u4CI = __p_IR4cypj1MNHQZdf0G4u4CI;
                this.__p_BCMtcs1659cPF7S97bqVBK = __p_BCMtcs1659cPF7S97bqVBK;
                this.__p_TGbv9cYLUniPssRL6VE0kq = __p_TGbv9cYLUniPssRL6VE0kq;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Translate<T, AdM>(T Input_In, T Offset_In, out T Output_Out)
            where AdM : struct, n21.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            w_0.OperatorPlus(Input_In: Input_In, Input_2_In: Offset_In, Output_Out: out T Output_1);
            Output_Out = Output_1;
            return;
        }

        public static void AddRemovePoints<T, T2, AdM>(int Current_Id_In, n10.Spread<n8.EditablePoint_R<T>> Points_In, T2 Points_To_Add_In, bool Add_In, bool Clear_In, bool Remove_Selected_In, out int Current_Id_Out, out n10.Spread<n8.EditablePoint_R<T>> Points_Out)
            where T2 : n23.IEnumerable<T> where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Empty_1 = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditablePoint_R<T>>>(Condition_In: Clear_In, Input_In: Points_In, Input_2_In: Empty_1, Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_2);
            n10.Spread<n8.EditablePoint_R<T>> Outputs_3;
            int Current_Id_4;
            if (Add_In)
            {
                n10.Spread<n8.EditablePoint_R<T>> __cp_LpJ25o8vFXZLdXLKG6s4mV = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
                n10.Spread<n23.IEnumerable<n8.EditablePoint_R<T>>> __pin_group_Input_In_LggdA5A0SFELcfpEkAI7FH = default(n10.Spread<n23.IEnumerable<n8.EditablePoint_R<T>>>);
                n23.IEnumerable<n8.EditablePoint_R<T>> Input_5 = (n23.IEnumerable<n8.EditablePoint_R<T>>)Output_2;
                int accumulator_7 = Current_Id_In;
                var builder_17 = n6.CollectionBuilders.GetBuilder(__cp_LpJ25o8vFXZLdXLKG6s4mV, 16);
                n10.Spread<n8.EditablePoint_R<T>> output_18;
                try
                {
                    var i_9 = 0;
                    foreach (var item_6 in Points_To_Add_In)
                    {
                        var splicer_8 = item_6;
                        var i_local_10 = i_9;
                        int __pad_TOWekHaH4P2OrjGlzI4wMU_11 = __slot_TOWekHaH4P2OrjGlzI4wMU;
                        n1.NodeContext Node_Context_12 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Cw8NcIZlFqfPujWYWQJlkn", 65876U);
                        var Output_13 = n8.EditablePoint_R<T>.Create<AdM>(Node_Context: Node_Context_12, Position_In: splicer_8, Id_In: accumulator_7);
                        bool Apply_14 = true;
                        var Output_15 = accumulator_7;
                        if (Apply_14)
                        {
                            var Output_16 = accumulator_7 + __pad_TOWekHaH4P2OrjGlzI4wMU_11;
                            Output_15 = Output_16;
                        }

                        builder_17.Add(Output_13);
                        accumulator_7 = Output_15;
                        i_9++;
                    }
                }
                finally
                {
                    output_18 = builder_17.Commit();
                }

                n23.IEnumerable<n8.EditablePoint_R<T>> Input_2_19 = (n23.IEnumerable<n8.EditablePoint_R<T>>)output_18;
                var Result_20 = n12._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
                var Result_21 = n12._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
                var builder_22 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_LggdA5A0SFELcfpEkAI7FH, 4);
                builder_22.Add(Input_5);
                builder_22.Add(Input_2_19);
                builder_22.Add(Result_20);
                builder_22.Add(Result_21);
                var __pin_group_Input_In_LggdA5A0SFELcfpEkAI7FH_23 = builder_22.Commit();
                n14._Operations_.Concat<n8.EditablePoint_R<T>>(Input_In: __pin_group_Input_In_LggdA5A0SFELcfpEkAI7FH_23, Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_24);
                Outputs_3 = Output_24;
                Current_Id_4 = accumulator_7;
            }
            else
            {
                Outputs_3 = Output_2;
                Current_Id_4 = Current_Id_In;
            }

            n10.Spread<n8.EditablePoint_R<T>> Output_25;
            if (Remove_Selected_In)
            {
                bool Apply_26 = true;
                var __fallback___27 = n1.ServiceRegistry.Current;
                var Output_36 = Outputs_3;
                if (Apply_26)
                {
                    n14._Operations_.Where<n8.EditablePoint_R<T>>(Input_In: Outputs_3, Predicate_In: (n8.EditablePoint_R<T> Source_In_29, int Arg_2_In_30) =>
                    {
                        using var __current_28 = __fallback___27.MakeCurrentIfNone();
                        var Output_32 = Source_In_29.GetSelected(Selected_Out: out bool Selected_31);
                        bool Apply_33 = true;
                        var Output_34 = Selected_31;
                        if (Apply_33)
                        {
                            var Output_35 = !Selected_31;
                            Output_34 = Output_35;
                        }

                        return Output_34;
                    }

                    , Output_Out: out Output_36);
                }

                Output_25 = Output_36;
            }
            else
            {
                Output_25 = Outputs_3;
            }

            Current_Id_Out = Current_Id_4;
            Points_Out = Output_25;
            return;
        }

        public static void MouseOver(n3.Vector2 Input_In, n3.Vector2 Mouse_Position_In, float Pick_Size_In, out bool Result_Out)
        {
            var Output_0 = new n3.Vector2(x: Pick_Size_In, y: Pick_Size_In);
            var Result_1 = n46.RectangleNodes.FromCenterSize(center: ref Input_In, size: ref Output_0);
            n46.Collision2D.RectContainsPoint(rectangle: ref Result_1, point: ref Mouse_Position_In, result: out bool Result_2);
            Result_Out = Result_2;
            return;
        }

        public static void InSelection(n3.Vector2 Input_In, n3.RectangleF Rectangle_In, float Pick_Size_In, out bool Result_Out)
        {
            var Output_0 = new n3.Vector2(x: Pick_Size_In, y: Pick_Size_In);
            var Result_1 = n46.RectangleNodes.FromCenterSize(center: ref Input_In, size: ref Output_0);
            n46.Collision2D.RectIntersectsRect(rectangle1: ref Rectangle_In, rectangle2: ref Result_1, result: out bool Result_2);
            Result_Out = Result_2;
            return;
        }

        public static void SelectPoints<T2, T>(T2 Inputs_In, bool Selection_Hovered_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Gizmo_Idle_In, bool EditingKey_In, bool Add_To_Selection_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Remove_From_Selection_In, bool Select_All_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Pressed_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Released_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Select_with_Key_In, out n10.Spread<n8.EditablePoint_R<T>> Outputs_Out, out bool Selection_Changed_Out, out bool Selection_Set_Out)
            where T2 : n23.IEnumerable<n8.EditablePoint_R<T>>
        {
            n10.Spread<n8.EditablePoint_R<T>> __cp_H0qF0Ev5OYSM3CQEIWZQYS = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
            var Output_0 = !Add_To_Selection_In;
            var Output_1 = !Remove_From_Selection_In;
            var Output_2 = !EditingKey_In;
            var Output_3 = Pressed_In || Select_with_Key_In;
            var Output_4 = Released_In || Select_with_Key_In;
            var Output_5 = !Selection_Hovered_In;
            bool accumulator_7 = false;
            bool accumulator_8 = false;
            var builder_59 = n6.CollectionBuilders.GetBuilder(__cp_H0qF0Ev5OYSM3CQEIWZQYS, 16);
            n10.Spread<n8.EditablePoint_R<T>> output_60;
            try
            {
                var i_10 = 0;
                foreach (var item_6 in Inputs_In)
                {
                    var splicer_9 = item_6;
                    var i_local_11 = i_10;
                    int __pad_Aj6KuEBjBBUPSKMJDR96w1_12 = __slot_Aj6KuEBjBBUPSKMJDR96w1;
                    var Output_14 = splicer_9.GetSelected(Selected_Out: out bool Selected_13);
                    var Output_15 = Selected_13 && Output_5;
                    var Output_16 = Output_15 && Output_2;
                    var Output_17 = Output_16 && Output_0;
                    var Output_18 = Output_17 && Output_1;
                    var Output_19 = Output_18 && Pressed_In;
                    var Output_20 = Output_19 && Gizmo_Idle_In;
                    var Output_22 = splicer_9.GetSelectionModifier(Modifier_Out: out int Modifier_21);
                    int Input_2_23 = 0;
                    var Result_24 = Modifier_21 < Input_2_23;
                    var Output_25 = Remove_From_Selection_In && Result_24;
                    var Output_26 = Output_25 && Released_In;
                    var Output_28 = splicer_9.GetHovered(Hovered_Out: out bool Hovered_27);
                    var Output_30 = splicer_9.GetKeyHovered(Hovered_Out: out bool Hovered_29);
                    var Output_31 = Hovered_27 || Hovered_29;
                    var Output_32 = Output_31 && Remove_From_Selection_In;
                    var Output_33 = Output_32 && Pressed_In;
                    var Output_34 = Selected_13 && Output_31;
                    var Output_35 = Output_34 && Select_with_Key_In;
                    var Output_36 = Output_20 || Output_26;
                    var Output_37 = Output_36 || Output_33;
                    var Output_38 = Output_37 || Output_35;
                    var Output_39 = splicer_9;
                    if (Output_38)
                    {
                        Output_39 = splicer_9.DeSelect();
                    }

                    var Output_40 = !Selected_13;
                    var Output_41 = Hovered_27 && Output_3;
                    var Output_42 = Output_41 && Output_40;
                    int Input_2_43 = 0;
                    var Result_44 = Modifier_21 > Input_2_43;
                    var Output_45 = Result_44 && Output_4;
                    var Output_46 = Output_45 && Output_1;
                    var Output_47 = Hovered_29 && Output_40;
                    var Output_48 = Output_47 && Select_with_Key_In;
                    var Output_49 = Output_42 || Select_All_In;
                    var Output_50 = Output_49 || Output_46;
                    var Output_51 = Output_50 || Output_48;
                    var Output_52 = Output_39;
                    if (Output_51)
                    {
                        Output_52 = Output_39.Select();
                    }

                    var Output_53 = accumulator_7 || Output_38;
                    var Output_54 = Output_53 || Output_51;
                    var Output_55 = Output_51 || accumulator_8;
                    var Output_56 = !Output_48;
                    var Output_57 = Output_55 && Output_56;
                    var Output_58 = Output_52;
                    if (Output_51)
                    {
                        Output_58 = Output_52.SetSelectionModifier(Modifier_In: __pad_Aj6KuEBjBBUPSKMJDR96w1_12);
                    }

                    builder_59.Add(Output_58);
                    accumulator_7 = Output_54;
                    accumulator_8 = Output_57;
                    i_10++;
                }
            }
            finally
            {
                output_60 = builder_59.Commit();
            }

            Outputs_Out = output_60;
            Selection_Changed_Out = accumulator_7;
            Selection_Set_Out = accumulator_8;
            return;
        }

        public static void Center<T2, T, AdM>(T2 Input_In, out T Result_Out)
            where T2 : n23.IEnumerable<n8.EditablePoint_R<T>> where AdM : struct, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n12._Operations_.Average_Selector<T2, n8.EditablePoint_R<T>, T, AdM>(Input_In: Input_In, Selector_In: (n8.EditablePoint_R<T> Source_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Output_5 = Source_In_3.GetPosition(Position_Out: out T Position_4);
                return Position_4;
            }

            , Result_Out: out T Result_6);
            Result_Out = Result_6;
            return;
        }

        public static void UpdatePoints<T2, T, AdM>(T2 Inputs_In, n3.Matrix Matrix_In, out n10.Spread<n8.EditablePoint_R<T>> Outputs_Out)
            where T2 : n23.IEnumerable<n8.EditablePoint_R<T>> where AdM : struct, n53.IAdaptiveToXYZ<T>
        {
            n10.Spread<n8.EditablePoint_R<T>> __cp_IF5KWJ0YWEdPyqbnD77hjL = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
            var w_0 = default(AdM);
            var builder_7 = n6.CollectionBuilders.GetBuilder(__cp_IF5KWJ0YWEdPyqbnD77hjL, 16);
            n10.Spread<n8.EditablePoint_R<T>> output_8;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Inputs_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    bool Apply_5 = true;
                    var Output_6 = splicer_2;
                    if (Apply_5)
                    {
                        Output_6 = splicer_2.Update<AdM>(Matrix_In: Matrix_In);
                    }

                    builder_7.Add(Output_6);
                    i_3++;
                }
            }
            finally
            {
                output_8 = builder_7.Commit();
            }

            Outputs_Out = output_8;
            return;
        }

        public static void SetLockState<T, T2>(n10.Spread<n8.EditablePoint_R<T>> Spread_In, T2 Lockeds_In, out n10.Spread<n8.EditablePoint_R<T>> Outputs_Out)
            where T2 : n23.IEnumerable<bool>
        {
            n10.Spread<n8.EditablePoint_R<T>> __cp_HUmFSx7hnhrP5l0wKmlVKi = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
            n14._Operations_.Count<n8.EditablePoint_R<T>>(Input_In: Spread_In, Count_Out: out int Count_0);
            n23.IEnumerable<bool> Input_1 = (n23.IEnumerable<bool>)Lockeds_In;
            n14._Operations_.FromSequence<bool>(Input_In: Input_1, Result_Out: out n10.Spread<bool> Result_2);
            var builder_13 = n6.CollectionBuilders.GetBuilder(__cp_HUmFSx7hnhrP5l0wKmlVKi, 16);
            n10.Spread<n8.EditablePoint_R<T>> output_14;
            try
            {
                var Input_Count_4 = Spread_In.Count;
                var __safeGuard_5 = Input_Count_4 >= Count_0;
                var Locked_Count_7 = Result_2.Count;
                var __safeGuard_8 = Locked_Count_7 >= Count_0;
                for (var i_3 = 0; i_3 < Count_0; i_3++)
                {
                    var splicer_6 = __safeGuard_5 ? Spread_In[i_3] : Input_Count_4 > 0 ? Spread_In[i_3 % Input_Count_4] : default(n8.EditablePoint_R<T>);
                    var splicer_9 = __safeGuard_8 ? Result_2[i_3] : Locked_Count_7 > 0 ? Result_2[i_3 % Locked_Count_7] : default(bool);
                    var i_local_10 = i_3;
                    bool Apply_11 = true;
                    var Output_12 = splicer_6;
                    if (Apply_11)
                    {
                        Output_12 = splicer_6.SetLocked(Locked_In: splicer_9);
                    }

                    builder_13.Add(Output_12);
                }
            }
            finally
            {
                output_14 = builder_13.Commit();
            }

            Outputs_Out = output_14;
            return;
        }

        public static void OffsetScaling(bool Rotate_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Fine_In, out float Output_Out)
        {
            float __pad_HrcJPrXzXyRLTEn7u76Cd8_0 = __slot_HrcJPrXzXyRLTEn7u76Cd8;
            float __pad_F94BhfXa2xTPx37cW4YUJT_1 = __slot_F94BhfXa2xTPx37cW4YUJT;
            float __pad_HG78pGRWAeiP5HsCNFLFVQ_2 = __slot_HG78pGRWAeiP5HsCNFLFVQ;
            float __pad_NfdKO3bDzFMQTGQk0ShvLl_3 = __slot_NfdKO3bDzFMQTGQk0ShvLl;
            float __pad_TVc83fbSVMQMokWaAqCpMo_4 = __slot_TVc83fbSVMQMokWaAqCpMo;
            bool Apply_5 = true;
            var Output_6 = __pad_F94BhfXa2xTPx37cW4YUJT_1;
            if (Apply_5)
            {
                var Output_7 = (float)__pad_F94BhfXa2xTPx37cW4YUJT_1 / __pad_HG78pGRWAeiP5HsCNFLFVQ_2;
                Output_6 = Output_7;
            }

            var Output_8 = __pad_NfdKO3bDzFMQTGQk0ShvLl_3;
            if (Fine_In)
            {
                var Output_9 = __pad_NfdKO3bDzFMQTGQk0ShvLl_3 * __pad_TVc83fbSVMQMokWaAqCpMo_4;
                Output_8 = Output_9;
            }

            bool Apply_10 = true;
            var Output_11 = Output_6;
            if (Apply_10)
            {
                var Output_12 = Output_6 * Output_8;
                Output_11 = Output_12;
            }

            n32._Operations_.Switch_Boolean<float>(Condition_In: Rotate_In, Input_In: __pad_HrcJPrXzXyRLTEn7u76Cd8_0, Input_2_In: Output_11, Output_Out: out float Output_13);
            Output_Out = Output_13;
            return;
        }

        public static void RemoveHover<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Input_In, int Index_In, out n10.Spread<n8.EditablePoint_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_OtoqJQm0hXyN7oIQFp6n47_1 = __slot_OtoqJQm0hXyN7oIQFp6n47;
            var Output_2 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Index_In: Index_In, Result_Out: out n8.EditablePoint_R<T> Result_3);
            var Output_4 = Result_3.SetHovered(Hovered_In: __pad_OtoqJQm0hXyN7oIQFp6n47_1);
            var Output_5 = Output_4.SetKeyHovered(Hovered_In: __pad_OtoqJQm0hXyN7oIQFp6n47_1);
            n14._Operations_.SetSlice<n8.EditablePoint_R<T>>(Input_In: Input_In, Value_In: Output_5, Index_In: Index_In, Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_6);
            Output_Out = Output_6;
            return;
        }

        public static void HoverWithKeys<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Input_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Hover_Next_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Hover_Previous_In, bool Mouse_Pressed_In, out n10.Spread<n8.EditablePoint_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_T2Rekull3AJQGHVuvbdAPc_1 = __slot_T2Rekull3AJQGHVuvbdAPc;
            int __pad_BnGMxpkO6SPM12QSfD68TH_2 = __slot_BnGMxpkO6SPM12QSfD68TH;
            int accumulator_4 = __pad_BnGMxpkO6SPM12QSfD68TH_2;
            int accumulator_5 = __pad_BnGMxpkO6SPM12QSfD68TH_2;
            var i_7 = 0;
            foreach (var item_3 in n6.CollectionExtensions.AsSpan(Input_In))
            {
                var splicer_6 = item_3;
                var i_local_8 = i_7;
                var Output_10 = splicer_6.GetHovered(Hovered_Out: out bool Hovered_9);
                var Output_12 = splicer_6.GetKeyHovered(Hovered_Out: out bool Hovered_11);
                var Output_13 = Hovered_9 || Hovered_11;
                n32._Operations_.Switch_Boolean<int>(Condition_In: Output_13, Input_In: accumulator_4, Input_2_In: i_local_8, Output_Out: out int Output_14);
                var Output_16 = splicer_6.GetSelected(Selected_Out: out bool Selected_15);
                n32._Operations_.Switch_Boolean<int>(Condition_In: Selected_15, Input_In: accumulator_5, Input_2_In: i_local_8, Output_Out: out int Output_17);
                accumulator_4 = Output_14;
                accumulator_5 = Output_17;
                i_7++;
            }

            int Input_2_18 = 0;
            var Result_19 = accumulator_4 >= Input_2_18;
            n32._Operations_.Switch_Boolean<int>(Condition_In: Result_19, Input_In: accumulator_5, Input_2_In: accumulator_4, Output_Out: out int Output_20);
            var Output_21 = Output_20;
            if (Hover_Next_In)
            {
                var Output_22 = n35.Integer32Extensions.Inc(input: Output_20);
                Output_21 = Output_22;
            }

            var Output_23 = Hover_Next_In || Hover_Previous_In;
            var Output_24 = Output_23 || Mouse_Pressed_In;
            var Output_25 = Input_In;
            if (Output_24)
            {
                n31._Operations_.RemoveHover<T, AdM>(Input_In: Input_In, Index_In: accumulator_4, Output_Out: out Output_25);
            }

            var Output_26 = Output_21;
            if (Hover_Previous_In)
            {
                var Output_27 = n35.Integer32Extensions.Dec(input: Output_21);
                Output_26 = Output_27;
            }

            var Output_28 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Output_25, Default_Value_In: Output_28, Index_In: Output_26, Result_Out: out n8.EditablePoint_R<T> Result_29);
            var Output_30 = Result_29.SetKeyHovered(Hovered_In: __pad_T2Rekull3AJQGHVuvbdAPc_1);
            var Output_31 = Output_25;
            if (Output_23)
            {
                n14._Operations_.SetSlice<n8.EditablePoint_R<T>>(Input_In: Output_25, Value_In: Output_30, Index_In: Output_26, Output_Out: out Output_31);
            }

            n10.Spread<n8.EditablePoint_R<T>> __pad_G7ucNJOt3YDQJGXgsPWUVd_32 = Output_31;
            bool __pad_CzzVLYq2h0BPjAxojwKuYg_33 = Hover_Previous_In;
            bool __pad_KsCz5CG3Fc9MJQaDr7YjJX_34 = Hover_Next_In;
            Output_Out = Output_31;
            return;
        }

        public static void RemoveKeyHover<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Input_In, int Index_In, out n10.Spread<n8.EditablePoint_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_JpwQJq5PByKQE1m5so3eeU_1 = __slot_JpwQJq5PByKQE1m5so3eeU;
            var Output_2 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Index_In: Index_In, Result_Out: out n8.EditablePoint_R<T> Result_3);
            var Output_4 = Result_3.SetKeyHovered(Hovered_In: __pad_JpwQJq5PByKQE1m5so3eeU_1);
            bool Apply_5 = true;
            var Output_6 = Input_In;
            if (Apply_5)
            {
                n14._Operations_.SetSlice<n8.EditablePoint_R<T>>(Input_In: Input_In, Value_In: Output_4, Index_In: Index_In, Output_Out: out Output_6);
            }

            Output_Out = Output_6;
            return;
        }

        public static void HoverWithMouse<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Input_In, n3.Vector2 Mouse_Position_In, float Pick_Size_In, bool Enable_In, out n10.Spread<n8.EditablePoint_R<T>> Output_Out, out bool Selection_Hovered_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n10.Spread<n8.EditablePoint_R<T>> __auto_1;
            bool __auto_2;
            if (Enable_In)
            {
                n10.Spread<n8.EditablePoint_R<T>> __cp_P9CTdHUT8gOLvKf8JRKBs3 = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
                bool accumulator_4 = false;
                bool accumulator_5 = false;
                int accumulator_6 = 0;
                var builder_28 = n6.CollectionBuilders.GetBuilder(__cp_P9CTdHUT8gOLvKf8JRKBs3, 16);
                n10.Spread<n8.EditablePoint_R<T>> output_29;
                try
                {
                    var i_8 = 0;
                    foreach (var item_3 in n6.CollectionExtensions.AsSpan(Input_In))
                    {
                        var splicer_7 = item_3;
                        var i_local_9 = i_8;
                        var Output_11 = splicer_7.GetKeyHovered(Hovered_Out: out bool Hovered_10);
                        n32._Operations_.Switch_Boolean<int>(Condition_In: Hovered_10, Input_In: accumulator_6, Input_2_In: i_local_9, Output_Out: out int Output_12);
                        var Output_14 = splicer_7.GetProjectedPosition(Position_Out: out n3.Vector2 Position_13);
                        n31._Operations_.MouseOver(Input_In: Position_13, Mouse_Position_In: Mouse_Position_In, Pick_Size_In: Pick_Size_In, Result_Out: out bool Result_15);
                        var Output_17 = splicer_7.GetLocked(Locked_Out: out bool Locked_16);
                        var Output_18 = !Locked_16;
                        var Output_19 = !accumulator_4;
                        var Output_20 = Result_15 && Output_18;
                        var Output_21 = Output_20 && Output_19;
                        var Output_22 = Output_21 || accumulator_4;
                        var Output_24 = splicer_7.GetSelected(Selected_Out: out bool Selected_23);
                        var Output_25 = Output_21 && Selected_23;
                        var Output_26 = Output_25 || accumulator_5;
                        var Output_27 = splicer_7.SetHovered(Hovered_In: Output_21);
                        builder_28.Add(Output_27);
                        accumulator_4 = Output_22;
                        accumulator_5 = Output_26;
                        accumulator_6 = Output_12;
                        i_8++;
                    }
                }
                finally
                {
                    output_29 = builder_28.Commit();
                }

                var Output_30 = output_29;
                if (accumulator_4)
                {
                    n31._Operations_.RemoveKeyHover<T, AdM>(Input_In: output_29, Index_In: accumulator_6, Output_Out: out Output_30);
                }

                __auto_1 = Output_30;
                __auto_2 = accumulator_5;
            }
            else
            {
                __auto_1 = Input_In;
                __auto_2 = false;
            }

            Output_Out = __auto_1;
            Selection_Hovered_Out = __auto_2;
            return;
        }

        public static void SelectWithMarquee<T>(n10.Spread<n8.EditablePoint_R<T>> Input_In, n3.RectangleF Mouse_Selection_In, float Pick_Size_In, bool Enable_In, bool Remove_From_Selection_In, out n10.Spread<n8.EditablePoint_R<T>> Output_Out, out bool Selection_Modifier_Changed_Out)
        {
            n10.Spread<n8.EditablePoint_R<T>> Output_0;
            bool Selection_Modifier_Changed_1;
            if (Enable_In)
            {
                n10.Spread<n8.EditablePoint_R<T>> __cp_EXdJdynMx9pOV1iUDs9m2s = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
                bool accumulator_3 = false;
                var builder_18 = n6.CollectionBuilders.GetBuilder(__cp_EXdJdynMx9pOV1iUDs9m2s, 16);
                n10.Spread<n8.EditablePoint_R<T>> output_19;
                try
                {
                    var i_5 = 0;
                    foreach (var item_2 in n6.CollectionExtensions.AsSpan(Input_In))
                    {
                        var splicer_4 = item_2;
                        var i_local_6 = i_5;
                        int __pad_TgY9r6P6QH7MeyYdOmpwBc_7 = __slot_TgY9r6P6QH7MeyYdOmpwBc;
                        int __pad_VACTrvSmNoXLKLUUVMVGoi_8 = __slot_VACTrvSmNoXLKLUUVMVGoi;
                        var Output_10 = splicer_4.GetProjectedPosition(Position_Out: out n3.Vector2 Position_9);
                        n31._Operations_.InSelection(Input_In: Position_9, Rectangle_In: Mouse_Selection_In, Pick_Size_In: Pick_Size_In, Result_Out: out bool Result_11);
                        n32._Operations_.Switch_Boolean<int>(Condition_In: Remove_From_Selection_In, Input_In: __pad_TgY9r6P6QH7MeyYdOmpwBc_7, Input_2_In: __pad_VACTrvSmNoXLKLUUVMVGoi_8, Output_Out: out int Output_12);
                        int Input_13 = 0;
                        n32._Operations_.Switch_Boolean<int>(Condition_In: Result_11, Input_In: Input_13, Input_2_In: Output_12, Output_Out: out int Output_14);
                        bool Apply_15 = true;
                        var Output_16 = splicer_4;
                        if (Apply_15)
                        {
                            Output_16 = splicer_4.SetSelectionModifier(Modifier_In: Output_14);
                        }

                        var Output_17 = Result_11 || accumulator_3;
                        builder_18.Add(Output_16);
                        accumulator_3 = Output_17;
                        i_5++;
                    }
                }
                finally
                {
                    output_19 = builder_18.Commit();
                }

                Output_0 = output_19;
                Selection_Modifier_Changed_1 = accumulator_3;
            }
            else
            {
                Output_0 = Input_In;
                Selection_Modifier_Changed_1 = false;
            }

            Output_Out = Output_0;
            Selection_Modifier_Changed_Out = Selection_Modifier_Changed_1;
            return;
        }

        public static void Average<T2, T, AdM>(T2 Input_In, out T Output_Out, out int Elements_Count_Out)
            where T2 : n23.IEnumerable<n8.EditablePoint_R<T>> where AdM : struct, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            T accumulator_3 = Output_1;
            int accumulator_4 = 0;
            var i_6 = 0;
            foreach (var item_2 in Input_In)
            {
                var splicer_5 = item_2;
                var i_local_7 = i_6;
                int __pad_P4XS3asfmvEMHBtt9unBZ9_8 = __slot_P4XS3asfmvEMHBtt9unBZ9;
                var Output_16 = splicer_5.Split(Position_Out: out T Position_9, Locked_Out: out bool Locked_10, Selected_Out: out bool Selected_11, Hovered_Out: out bool Hovered_12, KeyHovered_Out: out bool KeyHovered_13, SelectionModifier_Out: out int SelectionModifier_14, Id_Out: out int Id_15);
                var Output_17 = accumulator_3;
                if (Selected_11)
                {
                    w_0.OperatorPlus(Input_In: accumulator_3, Input_2_In: Position_9, Output_Out: out Output_17);
                }

                var Output_18 = accumulator_4;
                if (Selected_11)
                {
                    var Output_19 = accumulator_4 + __pad_P4XS3asfmvEMHBtt9unBZ9_8;
                    Output_18 = Output_19;
                }

                accumulator_3 = Output_17;
                accumulator_4 = Output_18;
                i_6++;
            }

            float Scalar_20 = (float)accumulator_4;
            w_0.OperatorDivide_Scale(Input_In: accumulator_3, Scalar_In: Scalar_20, Output_Out: out T Output_21);
            Output_Out = Output_21;
            Elements_Count_Out = accumulator_4;
            return;
        }

        public static void FromSerializablePoint<T, AdM>(n31.SerializablePoint_R<T> Input_In, out n8.EditablePoint_R<T> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Output_3 = Input_In.Split(Position_Out: out T Position_1, Id_Out: out int Id_2);
            n1.NodeContext Node_Context_4 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "M0NSrru8Kb0MpU6ZzJhH1S", 70518U);
            var Output_5 = n8.EditablePoint_R<T>.Create<AdM>(Node_Context: Node_Context_4, Position_In: Position_1, Id_In: Id_2);
            Output_Out = Output_5;
            return;
        }

        public static void ToSerializablePoint<T, AdM>(n8.EditablePoint_R<T> Input_In, out n31.SerializablePoint_R<T> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Output_1 = n31.SerializablePoint_R<T>.CreateDefault<AdM>();
            var Output_9 = Input_In.Split(Position_Out: out T Position_2, Locked_Out: out bool Locked_3, Selected_Out: out bool Selected_4, Hovered_Out: out bool Hovered_5, KeyHovered_Out: out bool KeyHovered_6, SelectionModifier_Out: out int SelectionModifier_7, Id_Out: out int Id_8);
            var Output_10 = Output_1.Join(Position_In: Position_2, Id_In: Id_8);
            Output_Out = Output_10;
            return;
        }

        public static void ToJsonAndNewLine<T>(T Value_In, out string Output_Out)
        {
            bool __pad_I87QkHohQekNiVS1TWYyeo_0 = __slot_I87QkHohQekNiVS1TWYyeo;
            byte __pad_GNHNUGVUlmPNPkNtSazja2_1 = __slot_GNHNUGVUlmPNPkNtSazja2;
            bool Indent_2 = false;
            n57._Operations_.Serialize_Json<T>(Value_In: Value_In, Indent_In: Indent_2, Omit_Header_In: __pad_I87QkHohQekNiVS1TWYyeo_0, Result_Out: out string Result_3);
            var Result_4 = n35.IntegerConversions.ToChar(input: __pad_GNHNUGVUlmPNPkNtSazja2_1);
            var Result_5 = char.ToString(c: Result_4);
            var Output_6 = n35.StringExtensions.Plus(input: Result_5, input2: Result_3);
            Output_Out = Output_6;
            return;
        }

        public static void FromJsonAndNewLine(string Input_In, out n10.Spread<string> Output_Out)
        {
            byte __pad_FGRg02I96a3Pu6VG4aNpBR_0 = __slot_FGRg02I96a3Pu6VG4aNpBR;
            n2.StringSplitOptions __pad_R4KaAyKxsDFMEAV95kOo8h_1 = __slot_R4KaAyKxsDFMEAV95kOo8h;
            var Result_2 = n35.IntegerConversions.ToChar(input: __pad_FGRg02I96a3Pu6VG4aNpBR_0);
            var Result_3 = char.ToString(c: Result_2);
            n58._Operations_.Split_String(Input_In: Input_In, Separator_In: Result_3, Options_In: __pad_R4KaAyKxsDFMEAV95kOo8h_1, Output_Out: out n10.Spread<string> Output_4);
            Output_Out = Output_4;
            return;
        }

        public static void ParseEditablePoint2d<T>(T Input_In, string Path_In, out n8.EditablePoint_R<n3.Vector2> Output_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_PFHUa8MdpwxOvzWKxl4dL7_0 = __slot_PFHUa8MdpwxOvzWKxl4dL7;
            string __pad_VPk1xYwoSrRMUMHTnYdkME_1 = __slot_VPk1xYwoSrRMUMHTnYdkME;
            var Result_2 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            var Result_3 = n15.Extensions.XPathSelectElement(node: Result_2, expression: __pad_VPk1xYwoSrRMUMHTnYdkME_1);
            n31._Operations_.GetVector2D<n7.XElement>(Input_In: Result_3, Value_Out: out n3.Vector2 Value_4, Success_Out: out bool Success_5);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_2, Path_In: __pad_PFHUa8MdpwxOvzWKxl4dL7_0, Value_Out: out int Value_6, Success_Out: out bool Success_7);
            n1.NodeContext Node_Context_8 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "MGx9fuMV2svLiHf7x8QArH", 71322U);
            var Output_9 = n8.EditablePoint_R<n3.Vector2>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_8, Position_In: Value_4, Id_In: Value_6);
            var Output_10 = Success_5 && Success_7;
            Output_Out = Output_9;
            Success_Out = Output_10;
            return;
        }

        public static void GetVector2D<T>(T Input_In, out n3.Vector2 Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_KurtVTKgcw5LbAvOAh0GUX_0 = __slot_KurtVTKgcw5LbAvOAh0GUX;
            string __pad_OoMy4d63CQdQciqq8UMP9u_1 = __slot_OoMy4d63CQdQciqq8UMP9u;
            n59._Operations_.XPathGetValue<T, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Input_In, Path_In: __pad_OoMy4d63CQdQciqq8UMP9u_1, Value_Out: out float Value_2, Success_Out: out bool Success_3);
            n59._Operations_.XPathGetValue<T, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Input_In, Path_In: __pad_KurtVTKgcw5LbAvOAh0GUX_0, Value_Out: out float Value_4, Success_Out: out bool Success_5);
            var Output_6 = new n3.Vector2(x: Value_2, y: Value_4);
            var Output_7 = Success_3 && Success_5;
            Value_Out = Output_6;
            Success_Out = Output_7;
            return;
        }

        public static void ParseEditablePoint3d<T>(T Input_In, string Path_In, out n8.EditablePoint_R<n3.Vector3> Output_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_M0XxMXp6TO8ODsKiv2L6sa_0 = __slot_M0XxMXp6TO8ODsKiv2L6sa;
            string __pad_OCJjok1OokLMKJ0vE25TLN_1 = __slot_OCJjok1OokLMKJ0vE25TLN;
            var Result_2 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            var Result_3 = n15.Extensions.XPathSelectElement(node: Result_2, expression: __pad_OCJjok1OokLMKJ0vE25TLN_1);
            n31._Operations_.GetVector3D<n7.XElement>(Input_In: Result_3, Value_Out: out n3.Vector3 Value_4, Success_Out: out bool Success_5);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_2, Path_In: __pad_M0XxMXp6TO8ODsKiv2L6sa_0, Value_Out: out int Value_6, Success_Out: out bool Success_7);
            n1.NodeContext Node_Context_8 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "G19xjr5YWRdMWbpFOXDksh", 71553U);
            var Output_9 = n8.EditablePoint_R<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_8, Position_In: Value_4, Id_In: Value_6);
            var Output_10 = Success_5 && Success_7;
            Output_Out = Output_9;
            Success_Out = Output_10;
            return;
        }

        public static void GetVector3D<T>(T Input_In, out n3.Vector3 Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_QLHAtxVoFhNLqBkKnND51p_0 = __slot_QLHAtxVoFhNLqBkKnND51p;
            string __pad_CzC6MwPiapXN2IOH2FjxlT_1 = __slot_CzC6MwPiapXN2IOH2FjxlT;
            string __pad_H24OWHnv2YIO21wKdUQP64_2 = __slot_H24OWHnv2YIO21wKdUQP64;
            n59._Operations_.XPathGetValue<T, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Input_In, Path_In: __pad_H24OWHnv2YIO21wKdUQP64_2, Value_Out: out float Value_3, Success_Out: out bool Success_4);
            n59._Operations_.XPathGetValue<T, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Input_In, Path_In: __pad_QLHAtxVoFhNLqBkKnND51p_0, Value_Out: out float Value_5, Success_Out: out bool Success_6);
            n59._Operations_.XPathGetValue<T, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Input_In, Path_In: __pad_CzC6MwPiapXN2IOH2FjxlT_1, Value_Out: out float Value_7, Success_Out: out bool Success_8);
            var Output_9 = new n3.Vector3(x: Value_3, y: Value_5, z: Value_7);
            var Output_10 = Success_4 && Success_6;
            var Output_11 = Output_10 && Success_8;
            Value_Out = Output_9;
            Success_Out = Output_11;
            return;
        }

        [n1.ElementAttribute(TracingId = 65870U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TOWekHaH4P2OrjGlzI4wMU", Name = "__slot_TOWekHaH4P2OrjGlzI4wMU")]
        public static int __slot_TOWekHaH4P2OrjGlzI4wMU = 1;
        [n1.ElementAttribute(TracingId = 66457U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Aj6KuEBjBBUPSKMJDR96w1", Name = "__slot_Aj6KuEBjBBUPSKMJDR96w1")]
        public static int __slot_Aj6KuEBjBBUPSKMJDR96w1 = 0;
        [n1.ElementAttribute(TracingId = 68289U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HrcJPrXzXyRLTEn7u76Cd8", Name = "__slot_HrcJPrXzXyRLTEn7u76Cd8")]
        public static float __slot_HrcJPrXzXyRLTEn7u76Cd8 = 1F;
        [n1.ElementAttribute(TracingId = 68288U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F94BhfXa2xTPx37cW4YUJT", Name = "__slot_F94BhfXa2xTPx37cW4YUJT")]
        public static float __slot_F94BhfXa2xTPx37cW4YUJT = 100F;
        [n1.ElementAttribute(TracingId = 68284U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HG78pGRWAeiP5HsCNFLFVQ", Name = "__slot_HG78pGRWAeiP5HsCNFLFVQ")]
        public static float __slot_HG78pGRWAeiP5HsCNFLFVQ = 360F;
        [n1.ElementAttribute(TracingId = 68279U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NfdKO3bDzFMQTGQk0ShvLl", Name = "__slot_NfdKO3bDzFMQTGQk0ShvLl")]
        public static float __slot_NfdKO3bDzFMQTGQk0ShvLl = 1F;
        [n1.ElementAttribute(TracingId = 68280U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TVc83fbSVMQMokWaAqCpMo", Name = "__slot_TVc83fbSVMQMokWaAqCpMo")]
        public static float __slot_TVc83fbSVMQMokWaAqCpMo = 0.1F;
        [n1.ElementAttribute(TracingId = 68438U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OtoqJQm0hXyN7oIQFp6n47", Name = "__slot_OtoqJQm0hXyN7oIQFp6n47")]
        public static bool __slot_OtoqJQm0hXyN7oIQFp6n47 = false;
        [n1.ElementAttribute(TracingId = 68689U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "T2Rekull3AJQGHVuvbdAPc", Name = "__slot_T2Rekull3AJQGHVuvbdAPc")]
        public static bool __slot_T2Rekull3AJQGHVuvbdAPc = true;
        [n1.ElementAttribute(TracingId = 68616U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BnGMxpkO6SPM12QSfD68TH", Name = "__slot_BnGMxpkO6SPM12QSfD68TH")]
        public static int __slot_BnGMxpkO6SPM12QSfD68TH = -1;
        [n1.ElementAttribute(TracingId = 69149U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JpwQJq5PByKQE1m5so3eeU", Name = "__slot_JpwQJq5PByKQE1m5so3eeU")]
        public static bool __slot_JpwQJq5PByKQE1m5so3eeU = false;
        [n1.ElementAttribute(TracingId = 69967U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TgY9r6P6QH7MeyYdOmpwBc", Name = "__slot_TgY9r6P6QH7MeyYdOmpwBc")]
        public static int __slot_TgY9r6P6QH7MeyYdOmpwBc = 1;
        [n1.ElementAttribute(TracingId = 69973U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VACTrvSmNoXLKLUUVMVGoi", Name = "__slot_VACTrvSmNoXLKLUUVMVGoi")]
        public static int __slot_VACTrvSmNoXLKLUUVMVGoi = -1;
        [n1.ElementAttribute(TracingId = 70234U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "P4XS3asfmvEMHBtt9unBZ9", Name = "__slot_P4XS3asfmvEMHBtt9unBZ9")]
        public static int __slot_P4XS3asfmvEMHBtt9unBZ9 = 1;
        [n1.ElementAttribute(TracingId = 70660U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I87QkHohQekNiVS1TWYyeo", Name = "__slot_I87QkHohQekNiVS1TWYyeo")]
        public static bool __slot_I87QkHohQekNiVS1TWYyeo = true;
        [n1.ElementAttribute(TracingId = 70725U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GNHNUGVUlmPNPkNtSazja2", Name = "__slot_GNHNUGVUlmPNPkNtSazja2")]
        public static byte __slot_GNHNUGVUlmPNPkNtSazja2 = 10;
        [n1.ElementAttribute(TracingId = 71285U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FGRg02I96a3Pu6VG4aNpBR", Name = "__slot_FGRg02I96a3Pu6VG4aNpBR")]
        public static byte __slot_FGRg02I96a3Pu6VG4aNpBR = 10;
        [n1.ElementAttribute(TracingId = 71270U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "R4KaAyKxsDFMEAV95kOo8h", Name = "__slot_R4KaAyKxsDFMEAV95kOo8h")]
        public static n2.StringSplitOptions __slot_R4KaAyKxsDFMEAV95kOo8h = n1.CompilationHelper.Deserialize<n2.StringSplitOptions>("RemoveEmptyEntries", false, "RMDMfKmnIrVPStLdWe8u30", "R4KaAyKxsDFMEAV95kOo8h");
        [n1.ElementAttribute(TracingId = 71340U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PFHUa8MdpwxOvzWKxl4dL7", Name = "__slot_PFHUa8MdpwxOvzWKxl4dL7")]
        public static string __slot_PFHUa8MdpwxOvzWKxl4dL7 = "Id";
        [n1.ElementAttribute(TracingId = 71410U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VPk1xYwoSrRMUMHTnYdkME", Name = "__slot_VPk1xYwoSrRMUMHTnYdkME")]
        public static string __slot_VPk1xYwoSrRMUMHTnYdkME = "Position";
        [n1.ElementAttribute(TracingId = 71490U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KurtVTKgcw5LbAvOAh0GUX", Name = "__slot_KurtVTKgcw5LbAvOAh0GUX")]
        public static string __slot_KurtVTKgcw5LbAvOAh0GUX = "Y";
        [n1.ElementAttribute(TracingId = 71449U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OoMy4d63CQdQciqq8UMP9u", Name = "__slot_OoMy4d63CQdQciqq8UMP9u")]
        public static string __slot_OoMy4d63CQdQciqq8UMP9u = "X";
        [n1.ElementAttribute(TracingId = 71582U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "M0XxMXp6TO8ODsKiv2L6sa", Name = "__slot_M0XxMXp6TO8ODsKiv2L6sa")]
        public static string __slot_M0XxMXp6TO8ODsKiv2L6sa = "Id";
        [n1.ElementAttribute(TracingId = 71651U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OCJjok1OokLMKJ0vE25TLN", Name = "__slot_OCJjok1OokLMKJ0vE25TLN")]
        public static string __slot_OCJjok1OokLMKJ0vE25TLN = "Position";
        [n1.ElementAttribute(TracingId = 71716U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QLHAtxVoFhNLqBkKnND51p", Name = "__slot_QLHAtxVoFhNLqBkKnND51p")]
        public static string __slot_QLHAtxVoFhNLqBkKnND51p = "Y";
        [n1.ElementAttribute(TracingId = 71772U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CzC6MwPiapXN2IOH2FjxlT", Name = "__slot_CzC6MwPiapXN2IOH2FjxlT")]
        public static string __slot_CzC6MwPiapXN2IOH2FjxlT = "Z";
        [n1.ElementAttribute(TracingId = 71681U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "H24OWHnv2YIO21wKdUQP64", Name = "__slot_H24OWHnv2YIO21wKdUQP64")]
        public static string __slot_H24OWHnv2YIO21wKdUQP64 = "X";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Editors_.Editors.Adaptive.Internal
{
    public interface IAdaptiveToXYZ<T>
    {
        void ToXYZ(T Vector_In, out n3.Vector3 Output_Out);
    }
}

namespace _VL_Editors_.Editors.EditablePoint.Internal
{
    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void OperatorEquals(n8.EditablePoint_R<n3.Vector2> Input_In, n8.EditablePoint_R<n3.Vector2> Input_2_In, out bool Result_Out)
        {
            var Output_1 = Input_In.GetId(Id_Out: out int Id_0);
            var Output_3 = Input_2_In.GetId(Id_Out: out int Id_2);
            var Result_4 = Id_0 == Id_2;
            Result_Out = Result_4;
            return;
        }

        public static void OperatorEquals__3D(n8.EditablePoint_R<n3.Vector3> Input_In, n8.EditablePoint_R<n3.Vector3> Input_2_In, out bool Result_Out)
        {
            var Output_1 = Input_In.GetId(Id_Out: out int Id_0);
            var Output_3 = Input_2_In.GetId(Id_Out: out int Id_2);
            var Result_4 = Id_0 == Id_2;
            Result_Out = Result_4;
            return;
        }
    }
}

namespace _VL_Editors_.Editors.Bezier.Internal
{
    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CloseBezierCurve<T, AdM>(n10.Spread<T> Input_In, out n10.Spread<T> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            n12._Operations_.FirstOrDefault<n10.Spread<T>, T>(Input_In: Input_In, Default_Value_In: Output_1, Output_Out: out n10.Spread<T> Output_2, Result_Out: out T Result_3);
            bool Apply_4 = true;
            var Output_5 = Input_In;
            if (Apply_4)
            {
                n14._Operations_.Add<T>(Input_In: Input_In, Item_In: Result_3, Output_Out: out Output_5);
            }

            Output_Out = Output_5;
            return;
        }

        public static void SmoothControls<T, AdM>(n8.EditableBezierKnot_R<T> Input_In, n10.Spread<n8.EditableBezierKnot_R<T>> Knots_In, int Index_In, out n8.EditableBezierKnot_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            int __pad_IwoRE8hohk3NB2k5fts0XU_1 = __slot_IwoRE8hohk3NB2k5fts0XU;
            int __pad_PplK4kwyg1GOl4VqR7gbfE_2 = __slot_PplK4kwyg1GOl4VqR7gbfE;
            var Output_3 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            bool Apply_4 = true;
            var Output_5 = Index_In;
            if (Apply_4)
            {
                var Output_6 = Index_In - __pad_IwoRE8hohk3NB2k5fts0XU_1;
                Output_5 = Output_6;
            }

            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Knots_In, Default_Value_In: Output_3, Index_In: Output_5, Result_Out: out n8.EditableBezierKnot_R<T> Result_7);
            var Output_8 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            bool Apply_9 = true;
            var Output_10 = Index_In;
            if (Apply_9)
            {
                var Output_11 = Index_In + __pad_PplK4kwyg1GOl4VqR7gbfE_2;
                Output_10 = Output_11;
            }

            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Knots_In, Default_Value_In: Output_8, Index_In: Output_10, Result_Out: out n8.EditableBezierKnot_R<T> Result_12);
            n20._Operations_.CalculateControls<T, AdM>(Previous_Knot_In: Result_7, Current_In: Input_In, Next_Knot_In: Result_12, Control1_Position_Out: out T Control1_Position_13, Control2_Position_Out: out T Control2_Position_14);
            bool Apply_15 = true;
            var Output_16 = Input_In;
            if (Apply_15)
            {
                Output_16 = Input_In.SetSmoothControls(Control1_In: Control1_Position_13, Control2_In: Control2_Position_14);
            }

            Output_Out = Output_16;
            return;
        }

        public static void FindPositionOnSegment<T2, T, AdM>(T2 EditableBezierKnots_In, T Point_In, int Iteration_Count_In, bool Sample_In, out int Segment_Index_Out, out float Position_on_Segment_Out)
            where T2 : n23.IEnumerable<n8.EditableBezierKnot_R<T>> where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveLerp<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            int Segment_Index_1;
            float PositionOnSegment_2;
            if (Sample_In)
            {
                n10.Spread<n22.BezierKnot_R<T>> __cp_TPpQjYDC8ezOsBrPuCPo2b = n14._Operations_.CreateDefault<n22.BezierKnot_R<T>>();
                var builder_8 = n6.CollectionBuilders.GetBuilder(__cp_TPpQjYDC8ezOsBrPuCPo2b, 16);
                n10.Spread<n22.BezierKnot_R<T>> output_9;
                try
                {
                    var i_5 = 0;
                    foreach (var item_3 in EditableBezierKnots_In)
                    {
                        var splicer_4 = item_3;
                        var i_local_6 = i_5;
                        n20._Operations_.ToBezierKnot<T, AdM>(EditableBezierKnot_In: splicer_4, BezierKnot_Out: out n22.BezierKnot_R<T> BezierKnot_7);
                        builder_8.Add(BezierKnot_7);
                        i_5++;
                    }
                }
                finally
                {
                    output_9 = builder_8.Commit();
                }

                n25._Operations_.BezierSegmentsFromBezierKnots<T, AdM>(BezierKnots_In: output_9, Result_Out: out n10.Spread<n24.BezierSegment_R<T>> Result_10, Segment_Count_Out: out int Segment_Count_11);
                n25._Operations_.NearestPointOnBezierSegment<n10.Spread<n24.BezierSegment_R<T>>, T, AdM>(BezierSegment_In: Result_10, Point_In: Point_In, Iteration_Count_In: Iteration_Count_In, Point_on_BezierSegment_Out: out T Point_on_BezierSegment_12, Position_on_BezierSegment_Out: out float Position_on_BezierSegment_13, BezierSegment_Out: out n24.BezierSegment_R<T> BezierSegment_14);
                n14._Operations_.IndexOf<n24.BezierSegment_R<T>>(Input_In: Result_10, Item_In: BezierSegment_14, Result_Out: out int Result_15);
                Segment_Index_1 = Result_15;
                PositionOnSegment_2 = Position_on_BezierSegment_13;
            }
            else
            {
                Segment_Index_1 = 0;
                PositionOnSegment_2 = 0F;
            }

            int __pad_VpXMarmlbGSOIG9Lb0EESL_16 = Segment_Index_1;
            float __pad_BGFEF92HbljOubHjeYj11K_17 = PositionOnSegment_2;
            Segment_Index_Out = Segment_Index_1;
            Position_on_Segment_Out = PositionOnSegment_2;
            return;
        }

        public static void ControlForCorner<T, AdM>(T Knot_Position_In, T Other_Knot_Position_In, out T Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            float __pad_GzWbqtOTaA0QPajt7u1NHm_1 = __slot_GzWbqtOTaA0QPajt7u1NHm;
            bool Apply_2 = true;
            var Output_3 = Other_Knot_Position_In;
            if (Apply_2)
            {
                w_0.OperatorMinus(Input_In: Other_Knot_Position_In, Input_2_In: Knot_Position_In, Output_Out: out Output_3);
            }

            bool Apply_4 = true;
            var Output_5 = Output_3;
            if (Apply_4)
            {
                w_0.Normalize(Input_In: Output_3, Output_Out: out Output_5);
            }

            w_0.Length(Input_In: Output_3, Result_Out: out float Result_6);
            bool Apply_7 = true;
            var Output_8 = Result_6;
            if (Apply_7)
            {
                var Output_9 = (float)Result_6 / __pad_GzWbqtOTaA0QPajt7u1NHm_1;
                Output_8 = Output_9;
            }

            bool Apply_10 = true;
            var Output_11 = Output_5;
            if (Apply_10)
            {
                w_0.OperatorMulitply_Scale(Input_In: Output_5, Scalar_In: Output_8, Output_Out: out Output_11);
            }

            bool Apply_12 = true;
            var Output_13 = Output_11;
            if (Apply_12)
            {
                w_0.OperatorPlus(Input_In: Output_11, Input_2_In: Knot_Position_In, Output_Out: out Output_13);
            }

            Output_Out = Output_13;
            return;
        }

        public static void ProjectPointsToScreen<T2, T>(T2 BezierPoints_In, out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_Out)
            where T2 : n23.IEnumerable<n8.EditableBezierKnot_R<T>>
        {
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __cp_DaLlNyIm831LPwxSofn2Fv = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
            var builder_43 = n6.CollectionBuilders.GetBuilder(__cp_DaLlNyIm831LPwxSofn2Fv, 16);
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> output_44;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in BezierPoints_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    var Output_8 = splicer_1.Split(Point_Out: out n8.EditablePoint_R<T> Point_4, Control1_Out: out n8.EditablePoint_R<T> Control1_5, Control2_Out: out n8.EditablePoint_R<T> Control2_6, Mode_Out: out int Mode_7);
                    var Output_10 = Point_4.GetProjectedPosition(Position_Out: out n3.Vector2 Position_9);
                    n8.EditablePoint_R<n3.Vector2> Input_11 = n8.EditablePoint_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
                    bool Locked_12 = false;
                    bool Selected_13 = false;
                    bool Hovered_14 = false;
                    bool KeyHovered_15 = false;
                    int SelectionModifier_16 = 0;
                    int Id_17 = 0;
                    var Output_18 = Input_11.Join(Position_In: Position_9, Locked_In: Locked_12, Selected_In: Selected_13, Hovered_In: Hovered_14, KeyHovered_In: KeyHovered_15, SelectionModifier_In: SelectionModifier_16, Id_In: Id_17);
                    var Output_20 = Control1_5.GetProjectedPosition(Position_Out: out n3.Vector2 Position_19);
                    n8.EditablePoint_R<n3.Vector2> Input_21 = n8.EditablePoint_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
                    bool Locked_22 = false;
                    bool Selected_23 = false;
                    bool Hovered_24 = false;
                    bool KeyHovered_25 = false;
                    int SelectionModifier_26 = 0;
                    int Id_27 = 0;
                    var Output_28 = Input_21.Join(Position_In: Position_19, Locked_In: Locked_22, Selected_In: Selected_23, Hovered_In: Hovered_24, KeyHovered_In: KeyHovered_25, SelectionModifier_In: SelectionModifier_26, Id_In: Id_27);
                    var Output_30 = Control2_6.GetProjectedPosition(Position_Out: out n3.Vector2 Position_29);
                    n8.EditablePoint_R<n3.Vector2> Input_31 = n8.EditablePoint_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
                    bool Locked_32 = false;
                    bool Selected_33 = false;
                    bool Hovered_34 = false;
                    bool KeyHovered_35 = false;
                    int SelectionModifier_36 = 0;
                    int Id_37 = 0;
                    var Output_38 = Input_31.Join(Position_In: Position_29, Locked_In: Locked_32, Selected_In: Selected_33, Hovered_In: Hovered_34, KeyHovered_In: KeyHovered_35, SelectionModifier_In: SelectionModifier_36, Id_In: Id_37);
                    n8.EditableBezierKnot_R<n3.Vector2> Input_39 = n8.EditableBezierKnot_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
                    int Mode_40 = 0;
                    bool Apply_41 = true;
                    var Output_42 = Input_39;
                    if (Apply_41)
                    {
                        Output_42 = Input_39.Join(Point_In: Output_18, Contol1_In: Output_28, Control2_In: Output_38, Mode_In: Mode_40);
                    }

                    builder_43.Add(Output_42);
                    i_2++;
                }
            }
            finally
            {
                output_44 = builder_43.Commit();
            }

            Output_Out = output_44;
            return;
        }

        public static void InsertKnot<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, int Segment_Index_In, float Position_on_Segment_In, bool Add_Knot_In, bool Sample_Point_In, int Next_Id_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out, out T Sampled_Point_Out, out int Next_Id_Out)
            where AdM : struct, n21.IAdaptiveLerp<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            var Output_2 = n24.BezierSegment_R<T>.CreateDefault<AdM>();
            T Sampled_Point_3;
            n24.BezierSegment_R<T> Segment_4;
            if (Sample_Point_In)
            {
                n10.Spread<n22.BezierKnot_R<T>> __cp_PE74IOwhuzCQdCyxcfE4f6 = n14._Operations_.CreateDefault<n22.BezierKnot_R<T>>();
                var builder_10 = n6.CollectionBuilders.GetBuilder(__cp_PE74IOwhuzCQdCyxcfE4f6, 16);
                n10.Spread<n22.BezierKnot_R<T>> output_11;
                try
                {
                    var i_7 = 0;
                    foreach (var item_5 in n6.CollectionExtensions.AsSpan(Input_In))
                    {
                        var splicer_6 = item_5;
                        var i_local_8 = i_7;
                        n20._Operations_.ToBezierKnot<T, AdM>(EditableBezierKnot_In: splicer_6, BezierKnot_Out: out n22.BezierKnot_R<T> BezierKnot_9);
                        builder_10.Add(BezierKnot_9);
                        i_7++;
                    }
                }
                finally
                {
                    output_11 = builder_10.Commit();
                }

                n25._Operations_.BezierSegmentsFromBezierKnots<T, AdM>(BezierKnots_In: output_11, Result_Out: out n10.Spread<n24.BezierSegment_R<T>> Result_12, Segment_Count_Out: out int Segment_Count_13);
                var Output_14 = n24.BezierSegment_R<T>.CreateDefault<AdM>();
                n14._Operations_.GetSlice<n24.BezierSegment_R<T>>(Input_In: Result_12, Default_Value_In: Output_14, Index_In: Segment_Index_In, Result_Out: out n24.BezierSegment_R<T> Result_15);
                n25._Operations_.Sample<T, AdM>(Input_In: Result_15, Scalar_In: Position_on_Segment_In, Output_Out: out T Output_16);
                Segment_4 = Result_15;
                Sampled_Point_3 = Output_16;
            }
            else
            {
                Sampled_Point_3 = Output_1;
                Segment_4 = Output_2;
            }

            n10.Spread<n8.EditableBezierKnot_R<T>> Output_17;
            int Next_Id_18;
            if (Add_Knot_In)
            {
                n10.Spread<n8.EditableBezierKnot_R<T>> __cp_RJSEqo2v0QoN60aKGWEZ92 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
                int __pad_N5cxYCkk9gsL8WVu6GKTXr_19 = __slot_N5cxYCkk9gsL8WVu6GKTXr;
                var builder_26 = n6.CollectionBuilders.GetBuilder(__cp_RJSEqo2v0QoN60aKGWEZ92, 16);
                n10.Spread<n8.EditableBezierKnot_R<T>> output_27;
                try
                {
                    var i_22 = 0;
                    foreach (var item_20 in n6.CollectionExtensions.AsSpan(Input_In))
                    {
                        var splicer_21 = item_20;
                        var i_local_23 = i_22;
                        bool Apply_24 = true;
                        var Output_25 = splicer_21;
                        if (Apply_24)
                        {
                            Output_25 = splicer_21.DeselectPoinAndControls();
                        }

                        builder_26.Add(Output_25);
                        i_22++;
                    }
                }
                finally
                {
                    output_27 = builder_26.Commit();
                }

                var Output_28 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
                n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: output_27, Default_Value_In: Output_28, Index_In: Segment_Index_In, Result_Out: out n8.EditableBezierKnot_R<T> Result_29);
                var Output_31 = Result_29.GetControl2(Control2_Out: out n8.EditablePoint_R<T> Control2_30);
                n20._Operations_.NewBezierKnotOnSegment<T, AdM>(Bezier_In: Segment_4, Scalar_In: Position_on_Segment_In, Next_Id_In: Next_Id_In, Control2PreviousBezierKnot_Out: out T Control2PreviousBezierKnot_32, EditableBezierKnot_Out: out n8.EditableBezierKnot_R<T> EditableBezierKnot_33, Control1NextBezierKnot_Out: out T Control1NextBezierKnot_34, Next_Id_Out: out int Next_Id_35);
                bool Apply_36 = true;
                var Output_37 = Control2_30;
                if (Apply_36)
                {
                    Output_37 = Control2_30.SetPosition(Position_In: Control2PreviousBezierKnot_32);
                }

                bool Apply_38 = true;
                var Output_39 = Result_29;
                if (Apply_38)
                {
                    Output_39 = Result_29.SetControl2(Control2_In: Output_37);
                }

                bool Apply_40 = true;
                var Output_41 = output_27;
                if (Apply_40)
                {
                    n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: output_27, Value_In: Output_39, Index_In: Segment_Index_In, Output_Out: out Output_41);
                }

                var Output_42 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
                bool Apply_43 = true;
                var Output_44 = Segment_Index_In;
                if (Apply_43)
                {
                    var Output_45 = Segment_Index_In + __pad_N5cxYCkk9gsL8WVu6GKTXr_19;
                    Output_44 = Output_45;
                }

                n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Output_41, Default_Value_In: Output_42, Index_In: Output_44, Result_Out: out n8.EditableBezierKnot_R<T> Result_46);
                var Output_48 = Result_46.GetControl1(Control1_Out: out n8.EditablePoint_R<T> Control1_47);
                bool Apply_49 = true;
                var Output_50 = Control1_47;
                if (Apply_49)
                {
                    Output_50 = Control1_47.SetPosition(Position_In: Control1NextBezierKnot_34);
                }

                bool Apply_51 = true;
                var Output_52 = Result_46;
                if (Apply_51)
                {
                    Output_52 = Result_46.SetControl1(Control1_In: Output_50);
                }

                bool Apply_53 = true;
                var Output_54 = Output_41;
                if (Apply_53)
                {
                    n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Output_41, Value_In: Output_52, Index_In: Output_44, Output_Out: out Output_54);
                }

                bool Apply_55 = true;
                var Output_56 = Output_54;
                if (Apply_55)
                {
                    n14._Operations_.InsertSlice<n8.EditableBezierKnot_R<T>>(Input_In: Output_54, Index_In: Output_44, Value_In: EditableBezierKnot_33, Output_Out: out Output_56);
                }

                Output_17 = Output_56;
                Next_Id_18 = Next_Id_35;
            }
            else
            {
                Output_17 = Input_In;
                Next_Id_18 = Next_Id_In;
            }

            Output_Out = Output_17;
            Sampled_Point_Out = Sampled_Point_3;
            Next_Id_Out = Next_Id_18;
            return;
        }

        public static void AddRemoveBezierKnots<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, n23.IEnumerable<n8.EditableBezierKnot_R<T>> Knots_to_Add_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Add_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Smooth_In, bool Clear_In, bool Remove_Selected_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            var Empty_1 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditableBezierKnot_R<T>>>(Condition_In: Clear_In, Input_In: Input_In, Input_2_In: Empty_1, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_2);
            n14._Operations_.FromSequence<n8.EditableBezierKnot_R<T>>(Input_In: Knots_to_Add_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Result_3);
            n14._Operations_.IsEmpty<n8.EditableBezierKnot_R<T>>(Input_In: Result_3, Is_Empty_Out: out bool Is_Empty_4);
            bool Apply_5 = true;
            var Output_6 = Is_Empty_4;
            if (Apply_5)
            {
                var Output_7 = !Is_Empty_4;
                Output_6 = Output_7;
            }

            bool Apply_8 = true;
            var Output_9 = Output_6;
            if (Apply_8)
            {
                var Output_10 = Output_6 && Add_In;
                Output_9 = Output_10;
            }

            n10.Spread<n8.EditableBezierKnot_R<T>> Points_11;
            if (Output_9)
            {
                n10.Spread<n8.EditableBezierKnot_R<T>> __cp_Ll4WdyGvksoQMYzBFWXzlH = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
                n10.Spread<n23.IEnumerable<n8.EditableBezierKnot_R<T>>> __pin_group_Input_In_UnPBFPjhrbJPunItVKTnPX = default(n10.Spread<n23.IEnumerable<n8.EditableBezierKnot_R<T>>>);
                n23.IEnumerable<n8.EditableBezierKnot_R<T>> Input_12 = (n23.IEnumerable<n8.EditableBezierKnot_R<T>>)Output_2;
                var builder_18 = n6.CollectionBuilders.GetBuilder(__cp_Ll4WdyGvksoQMYzBFWXzlH, 16);
                n10.Spread<n8.EditableBezierKnot_R<T>> output_19;
                try
                {
                    var i_15 = 0;
                    foreach (var item_13 in n6.CollectionExtensions.AsSpan(Result_3))
                    {
                        var splicer_14 = item_13;
                        var i_local_16 = i_15;
                        var Output_17 = splicer_14;
                        if (Smooth_In)
                        {
                            Output_17 = splicer_14.SetControlsToPoint();
                        }

                        builder_18.Add(Output_17);
                        i_15++;
                    }
                }
                finally
                {
                    output_19 = builder_18.Commit();
                }

                n23.IEnumerable<n8.EditableBezierKnot_R<T>> Input_2_20 = (n23.IEnumerable<n8.EditableBezierKnot_R<T>>)output_19;
                var Result_21 = n12._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
                var builder_22 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_UnPBFPjhrbJPunItVKTnPX, 3);
                builder_22.Add(Input_12);
                builder_22.Add(Input_2_20);
                builder_22.Add(Result_21);
                var __pin_group_Input_In_UnPBFPjhrbJPunItVKTnPX_23 = builder_22.Commit();
                n14._Operations_.Concat<n8.EditableBezierKnot_R<T>>(Input_In: __pin_group_Input_In_UnPBFPjhrbJPunItVKTnPX_23, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_24);
                n14._Operations_.Count<n8.EditableBezierKnot_R<T>>(Input_In: Result_3, Count_Out: out int Count_25);
                var Output_26 = Output_24;
                if (Smooth_In)
                {
                    n20._Operations_.SmoothAddedPoints<T, AdM>(Input_In: Output_24, New_Points_Count_In: Count_25, Output_Out: out Output_26);
                }

                Points_11 = Output_26;
            }
            else
            {
                Points_11 = Output_2;
            }

            n10.Spread<n8.EditableBezierKnot_R<T>> Points_27;
            if (Remove_Selected_In)
            {
                bool Apply_28 = true;
                var __fallback___29 = n1.ServiceRegistry.Current;
                var Output_40 = Points_11;
                if (Apply_28)
                {
                    n14._Operations_.Where<n8.EditableBezierKnot_R<T>>(Input_In: Points_11, Predicate_In: (n8.EditableBezierKnot_R<T> Source_In_31, int Arg_2_In_32) =>
                    {
                        using var __current_30 = __fallback___29.MakeCurrentIfNone();
                        var Output_34 = Source_In_31.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_33);
                        var Output_36 = Point_33.GetSelected(Selected_Out: out bool Selected_35);
                        bool Apply_37 = true;
                        var Output_38 = Selected_35;
                        if (Apply_37)
                        {
                            var Output_39 = !Selected_35;
                            Output_38 = Output_39;
                        }

                        return Output_38;
                    }

                    , Output_Out: out Output_40);
                }

                Points_27 = Output_40;
            }
            else
            {
                Points_27 = Points_11;
            }

            Output_Out = Points_27;
            return;
        }

        public static void CreateControlsForCorner<T, AdM>(n8.EditableBezierKnot_R<T> Input_In, n10.Spread<n8.EditableBezierKnot_R<T>> Knots_In, int Index_In, out n8.EditableBezierKnot_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            var Output_2 = Input_In.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_1);
            var Output_4 = Point_1.GetPosition(Position_Out: out T Position_3);
            var Output_5 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            bool Apply_6 = true;
            var Output_7 = Index_In;
            if (Apply_6)
            {
                var Output_8 = n35.Integer32Extensions.Dec(input: Index_In);
                Output_7 = Output_8;
            }

            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Knots_In, Default_Value_In: Output_5, Index_In: Output_7, Result_Out: out n8.EditableBezierKnot_R<T> Result_9);
            var Output_11 = Result_9.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_10);
            var Output_13 = Point_10.GetPosition(Position_Out: out T Position_12);
            n20._Operations_.ControlForCorner<T, AdM>(Knot_Position_In: Position_3, Other_Knot_Position_In: Position_12, Output_Out: out T Output_14);
            var Output_15 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            bool Apply_16 = true;
            var Output_17 = Index_In;
            if (Apply_16)
            {
                var Output_18 = n35.Integer32Extensions.Inc(input: Index_In);
                Output_17 = Output_18;
            }

            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Knots_In, Default_Value_In: Output_15, Index_In: Output_17, Result_Out: out n8.EditableBezierKnot_R<T> Result_19);
            var Output_21 = Result_19.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_20);
            var Output_23 = Point_20.GetPosition(Position_Out: out T Position_22);
            n20._Operations_.ControlForCorner<T, AdM>(Knot_Position_In: Position_3, Other_Knot_Position_In: Position_22, Output_Out: out T Output_24);
            var Output_25 = Input_In.SetSmoothControls(Control1_In: Output_14, Control2_In: Output_24);
            Output_Out = Output_25;
            return;
        }

        public static void HoverWithKeys<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Hover_Next_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Hover_Previous_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Hover_Control_In, bool Mouse_Pressed_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_RDr3yoclCXXP304y0W9xCE_1 = __slot_RDr3yoclCXXP304y0W9xCE;
            int accumulator_3 = __pad_RDr3yoclCXXP304y0W9xCE_1;
            int accumulator_4 = __pad_RDr3yoclCXXP304y0W9xCE_1;
            var i_6 = 0;
            foreach (var item_2 in n6.CollectionExtensions.AsSpan(Input_In))
            {
                var splicer_5 = item_2;
                var i_local_7 = i_6;
                n20._Operations_.IsSmthHovered<T>(Input_In: splicer_5, Result_Out: out bool Result_8);
                n32._Operations_.Switch_Boolean<int>(Condition_In: Result_8, Input_In: accumulator_3, Input_2_In: i_local_7, Output_Out: out int Output_9);
                n20._Operations_.IsSmthSelected<T>(Input_In: splicer_5, Result_Out: out bool Result_10);
                n32._Operations_.Switch_Boolean<int>(Condition_In: Result_10, Input_In: accumulator_4, Input_2_In: i_local_7, Output_Out: out int Output_11);
                accumulator_3 = Output_9;
                accumulator_4 = Output_11;
                i_6++;
            }

            int Input_2_12 = 0;
            var Result_13 = accumulator_3 >= Input_2_12;
            n32._Operations_.Switch_Boolean<int>(Condition_In: Result_13, Input_In: accumulator_4, Input_2_In: accumulator_3, Output_Out: out int Output_14);
            var Output_15 = Hover_Next_In || Hover_Previous_In;
            var Output_16 = Output_15 || Mouse_Pressed_In;
            var Output_17 = Input_In;
            if (Output_16)
            {
                n20._Operations_.RemoveHover<T, AdM>(Input_In: Input_In, Index_In: accumulator_3, Output_Out: out Output_17);
            }

            var Output_18 = Output_14;
            if (Hover_Next_In)
            {
                var Output_19 = n35.Integer32Extensions.Inc(input: Output_14);
                Output_18 = Output_19;
            }

            var Output_20 = Output_18;
            if (Hover_Previous_In)
            {
                var Output_21 = n35.Integer32Extensions.Dec(input: Output_18);
                Output_20 = Output_21;
            }

            var Output_22 = Output_17;
            if (Output_15)
            {
                n20._Operations_.SetPointKeyHover<T, AdM>(Input_In: Output_17, Index_In: Output_20, Output_Out: out Output_22);
            }

            var Output_23 = Output_22;
            if (Hover_Control_In)
            {
                n20._Operations_.FlipControlHover<T, AdM>(Input_In: Output_22, Index_In: Output_14, Output_Out: out Output_23);
            }

            Output_Out = Output_23;
            return;
        }

        public static void RemoveHover<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, int Index_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_SqY6zOBDa9nPhPL7Twzxbw_1 = __slot_SqY6zOBDa9nPhPL7Twzxbw;
            var Output_2 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Index_In: Index_In, Result_Out: out n8.EditableBezierKnot_R<T> Result_3);
            var Output_8 = Result_3.Split(Point_Out: out n8.EditablePoint_R<T> Point_4, Control1_Out: out n8.EditablePoint_R<T> Control1_5, Control2_Out: out n8.EditablePoint_R<T> Control2_6, Mode_Out: out int Mode_7);
            var Output_9 = Point_4.SetHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_10 = Output_9.SetKeyHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_11 = Control1_5.SetHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_12 = Output_11.SetKeyHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_13 = Control2_6.SetHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_14 = Output_13.SetKeyHovered(Hovered_In: __pad_SqY6zOBDa9nPhPL7Twzxbw_1);
            var Output_15 = Result_3.Join(Point_In: Output_10, Contol1_In: Output_12, Control2_In: Output_14, Mode_In: Mode_7);
            n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_15, Index_In: Index_In, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_16);
            Output_Out = Output_16;
            return;
        }

        public static void SetPointKeyHover<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, int Index_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_AP0p7ii7dnaM44CByrTyt4_1 = __slot_AP0p7ii7dnaM44CByrTyt4;
            var Output_2 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Index_In: Index_In, Result_Out: out n8.EditableBezierKnot_R<T> Result_3);
            var Output_5 = Result_3.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_4);
            var Output_6 = Point_4.SetKeyHovered(Hovered_In: __pad_AP0p7ii7dnaM44CByrTyt4_1);
            var Output_7 = Result_3.SetPoint(Point_In: Output_6);
            bool Apply_8 = true;
            var Output_9 = Input_In;
            if (Apply_8)
            {
                n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_7, Index_In: Index_In, Output_Out: out Output_9);
            }

            Output_Out = Output_9;
            return;
        }

        public static void FlipControlHover<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, int Index_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_TjpW06vz3NtQXLUwdwKYph_1 = __slot_TjpW06vz3NtQXLUwdwKYph;
            bool __pad_PBOZNDwdC9DPk8yWmHmKAW_2 = __slot_PBOZNDwdC9DPk8yWmHmKAW;
            var Output_3 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_3, Index_In: Index_In, Result_Out: out n8.EditableBezierKnot_R<T> Result_4);
            var Output_9 = Result_4.Split(Point_Out: out n8.EditablePoint_R<T> Point_5, Control1_Out: out n8.EditablePoint_R<T> Control1_6, Control2_Out: out n8.EditablePoint_R<T> Control2_7, Mode_Out: out int Mode_8);
            var Output_10 = Point_5.SetKeyHovered(Hovered_In: __pad_TjpW06vz3NtQXLUwdwKYph_1);
            var Output_12 = Control1_6.GetKeyHovered(Hovered_Out: out bool Hovered_11);
            var Output_14 = Control1_6.GetHovered(Hovered_Out: out bool Hovered_13);
            var Output_15 = Hovered_11 || Hovered_13;
            var Output_16 = !Output_15;
            var Output_18 = Control2_7.GetKeyHovered(Hovered_Out: out bool Hovered_17);
            var Output_20 = Control2_7.GetHovered(Hovered_Out: out bool Hovered_19);
            var Output_21 = Hovered_17 || Hovered_19;
            var Output_22 = !Output_21;
            var Output_23 = Output_16 && Output_22;
            n32._Operations_.Switch_Boolean<bool>(Condition_In: Output_23, Input_In: Output_21, Input_2_In: __pad_PBOZNDwdC9DPk8yWmHmKAW_2, Output_Out: out bool Output_24);
            var Output_25 = Control1_6.SetKeyHovered(Hovered_In: Output_24);
            var Output_26 = Control2_7.SetKeyHovered(Hovered_In: Output_15);
            var Output_27 = Result_4.Join(Point_In: Output_10, Contol1_In: Output_25, Control2_In: Output_26, Mode_In: Mode_8);
            var Output_29 = Control1_6.GetLocked(Locked_Out: out bool Locked_28);
            var Output_31 = Control2_7.GetLocked(Locked_Out: out bool Locked_30);
            var Output_32 = Locked_28 || Locked_30;
            var Output_33 = !Output_32;
            var Output_34 = Input_In;
            if (Output_33)
            {
                n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_27, Index_In: Index_In, Output_Out: out Output_34);
            }

            Output_Out = Output_34;
            return;
        }

        public static void CorrectSelection<T>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n14._Operations_.Where<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Predicate_In: (n8.EditableBezierKnot_R<T> Arg_1_In_2, int Arg_2_In_3) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Output_8 = Arg_1_In_2.Split(Point_Out: out n8.EditablePoint_R<T> Point_4, Control1_Out: out n8.EditablePoint_R<T> Control1_5, Control2_Out: out n8.EditablePoint_R<T> Control2_6, Mode_Out: out int Mode_7);
                var Output_10 = Point_4.GetSelected(Selected_Out: out bool Selected_9);
                var Output_12 = Point_4.GetSelectionModifier(Modifier_Out: out int Modifier_11);
                int Input_2_13 = 0;
                var Result_14 = Modifier_11 > Input_2_13;
                var Output_15 = Selected_9 || Result_14;
                return Output_15;
            }

            , Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_16);
            n23.IEnumerable<n8.EditableBezierKnot_R<T>> Input_17 = (n23.IEnumerable<n8.EditableBezierKnot_R<T>>)Output_16;
            n12._Operations_.Any<n8.EditableBezierKnot_R<T>>(Input_In: Input_17, Result_Out: out bool Result_18);
            n10.Spread<n8.EditableBezierKnot_R<T>> __auto_19;
            if (Result_18)
            {
                n10.Spread<n8.EditableBezierKnot_R<T>> __cp_CusKTEMRGC3NXyy6hOVMbD = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
                var builder_36 = n6.CollectionBuilders.GetBuilder(__cp_CusKTEMRGC3NXyy6hOVMbD, 16);
                n10.Spread<n8.EditableBezierKnot_R<T>> output_37;
                try
                {
                    var i_22 = 0;
                    foreach (var item_20 in n6.CollectionExtensions.AsSpan(Input_In))
                    {
                        var splicer_21 = item_20;
                        var i_local_23 = i_22;
                        bool __pad_U3BSe3MdqM7M0AdLk7MN7r_24 = __slot_U3BSe3MdqM7M0AdLk7MN7r;
                        int __pad_BXWeBz1jz7bPNRT7S8Py8G_25 = __slot_BXWeBz1jz7bPNRT7S8Py8G;
                        var Output_30 = splicer_21.Split(Point_Out: out n8.EditablePoint_R<T> Point_26, Control1_Out: out n8.EditablePoint_R<T> Control1_27, Control2_Out: out n8.EditablePoint_R<T> Control2_28, Mode_Out: out int Mode_29);
                        var Output_31 = Control1_27;
                        if (__pad_U3BSe3MdqM7M0AdLk7MN7r_24)
                        {
                            Output_31 = Control1_27.DeSelect();
                        }

                        var Output_32 = Output_31;
                        if (__pad_U3BSe3MdqM7M0AdLk7MN7r_24)
                        {
                            Output_32 = Output_31.SetSelectionModifier(Modifier_In: __pad_BXWeBz1jz7bPNRT7S8Py8G_25);
                        }

                        var Output_33 = Control2_28;
                        if (__pad_U3BSe3MdqM7M0AdLk7MN7r_24)
                        {
                            Output_33 = Control2_28.DeSelect();
                        }

                        var Output_34 = Output_33;
                        if (__pad_U3BSe3MdqM7M0AdLk7MN7r_24)
                        {
                            Output_34 = Output_33.SetSelectionModifier(Modifier_In: __pad_BXWeBz1jz7bPNRT7S8Py8G_25);
                        }

                        var Output_35 = splicer_21.Join(Point_In: Point_26, Contol1_In: Output_32, Control2_In: Output_34, Mode_In: Mode_29);
                        builder_36.Add(Output_35);
                        i_22++;
                    }
                }
                finally
                {
                    output_37 = builder_36.Commit();
                }

                __auto_19 = output_37;
            }
            else
            {
                __auto_19 = Input_In;
            }

            Output_Out = __auto_19;
            return;
        }

        public static void CalculateControls<T, AdM>(n8.EditableBezierKnot_R<T> Previous_Knot_In, n8.EditableBezierKnot_R<T> Current_In, n8.EditableBezierKnot_R<T> Next_Knot_In, out T Control1_Position_Out, out T Control2_Position_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            float __pad_FrqHYmAIBTwLvUYqwF8dPQ_1 = __slot_FrqHYmAIBTwLvUYqwF8dPQ;
            float __pad_KxIWfM8a1iCPvHUmJamXO5_2 = __slot_KxIWfM8a1iCPvHUmJamXO5;
            var Output_4 = Previous_Knot_In.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_3);
            var Output_6 = Point_3.GetPosition(Position_Out: out T Position_5);
            var Output_8 = Current_In.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_7);
            var Output_10 = Point_7.GetPosition(Position_Out: out T Position_9);
            bool Apply_11 = true;
            var Output_12 = Position_9;
            if (Apply_11)
            {
                w_0.OperatorMinus(Input_In: Position_9, Input_2_In: Position_5, Output_Out: out Output_12);
            }

            bool Apply_13 = true;
            var Output_14 = Output_12;
            if (Apply_13)
            {
                w_0.OperatorDivide_Scale(Input_In: Output_12, Scalar_In: __pad_KxIWfM8a1iCPvHUmJamXO5_2, Output_Out: out Output_14);
            }

            bool Apply_15 = true;
            var Output_16 = Position_5;
            if (Apply_15)
            {
                w_0.OperatorPlus(Input_In: Position_5, Input_2_In: Output_14, Output_Out: out Output_16);
            }

            var Output_18 = Next_Knot_In.GetPoint(Point_Out: out n8.EditablePoint_R<T> Point_17);
            var Output_20 = Point_17.GetPosition(Position_Out: out T Position_19);
            bool Apply_21 = true;
            var Output_22 = Position_19;
            if (Apply_21)
            {
                w_0.OperatorMinus(Input_In: Position_19, Input_2_In: Position_9, Output_Out: out Output_22);
            }

            bool Apply_23 = true;
            var Output_24 = Output_22;
            if (Apply_23)
            {
                w_0.OperatorDivide_Scale(Input_In: Output_22, Scalar_In: __pad_KxIWfM8a1iCPvHUmJamXO5_2, Output_Out: out Output_24);
            }

            bool Apply_25 = true;
            var Output_26 = Position_9;
            if (Apply_25)
            {
                w_0.OperatorPlus(Input_In: Position_9, Input_2_In: Output_24, Output_Out: out Output_26);
            }

            w_0.Length(Input_In: Output_22, Result_Out: out float Result_27);
            w_0.Length(Input_In: Output_12, Result_Out: out float Result_28);
            var Output_29 = (float)Result_27 / Result_28;
            bool Apply_30 = true;
            var Output_31 = Output_29;
            if (Apply_30)
            {
                var Output_32 = Output_29 + __pad_FrqHYmAIBTwLvUYqwF8dPQ_1;
                Output_31 = Output_32;
            }

            bool Apply_33 = true;
            var Output_34 = Output_26;
            if (Apply_33)
            {
                w_0.OperatorMinus(Input_In: Output_26, Input_2_In: Output_16, Output_Out: out Output_34);
            }

            bool Apply_35 = true;
            var Output_36 = Output_34;
            if (Apply_35)
            {
                w_0.OperatorDivide_Scale(Input_In: Output_34, Scalar_In: Output_31, Output_Out: out Output_36);
            }

            bool Apply_37 = true;
            var Output_38 = Output_16;
            if (Apply_37)
            {
                w_0.OperatorPlus(Input_In: Output_16, Input_2_In: Output_36, Output_Out: out Output_38);
            }

            bool Apply_39 = true;
            var Output_40 = Position_9;
            if (Apply_39)
            {
                w_0.OperatorMinus(Input_In: Position_9, Input_2_In: Output_38, Output_Out: out Output_40);
            }

            bool Apply_41 = true;
            var Output_42 = Output_26;
            if (Apply_41)
            {
                w_0.OperatorPlus(Input_In: Output_26, Input_2_In: Output_40, Output_Out: out Output_42);
            }

            bool Apply_43 = true;
            var Output_44 = Output_16;
            if (Apply_43)
            {
                w_0.OperatorPlus(Input_In: Output_16, Input_2_In: Output_40, Output_Out: out Output_44);
            }

            Control1_Position_Out = Output_44;
            Control2_Position_Out = Output_42;
            return;
        }

        public static void GetAllEditablePoints<T>(n10.Spread<n8.EditableBezierKnot_R<T>> BezierPoint_In, out n10.Spread<n8.EditablePoint_R<T>> Points_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n2.Func<n8.EditableBezierKnot_R<T>, n10.Spread<n8.EditablePoint_R<T>>> Transformer_5 = (n8.EditableBezierKnot_R<T> Input_In_2) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Output_4 = Input_In_2.GetEditablePoints(Result_Out: out n10.Spread<n8.EditablePoint_R<T>> Result_3);
                return Result_3;
            }

            ;
            n14._Operations_.Select_Many<n8.EditableBezierKnot_R<T>, n8.EditablePoint_R<T>>(Input_In: BezierPoint_In, Transformer_In: Transformer_5, Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_6);
            Points_Out = Output_6;
            return;
        }

        public static void SplitBezierPoints<T2, T>(T2 BezierPoints_In, out n10.Spread<T> Points_Out, out n10.Spread<T> Controls_Out, out n10.Spread<bool> Locked_Out, out n10.Spread<bool> SelectedPoints_Out, out n10.Spread<bool> SelectedControls_Out, out n10.Spread<bool> VisibleControls_Out)
            where T2 : n23.IEnumerable<n8.EditableBezierKnot_R<T>>
        {
            n10.Spread<T> __cp_Ju1bLLyBwbINR97I5aYU97 = n14._Operations_.CreateDefault<T>();
            n10.Spread<bool> __cp_UGymlFNRf1VLjeOaSKde5B = n14._Operations_.CreateDefault<bool>();
            n10.Spread<bool> __cp_HnoGqQADBYENwUxDaeIC0N = n14._Operations_.CreateDefault<bool>();
            var Empty_0 = n14._Operations_.CreateDefault<T>();
            n10.Spread<T> accumulator_2 = Empty_0;
            n10.Spread<bool> accumulator_3 = n14._Operations_.CreateDefault<bool>();
            n10.Spread<bool> accumulator_4 = n14._Operations_.CreateDefault<bool>();
            var builder_55 = n6.CollectionBuilders.GetBuilder(__cp_Ju1bLLyBwbINR97I5aYU97, 16);
            n10.Spread<T> output_56;
            var builder_57 = n6.CollectionBuilders.GetBuilder(__cp_UGymlFNRf1VLjeOaSKde5B, 16);
            n10.Spread<bool> output_58;
            var builder_59 = n6.CollectionBuilders.GetBuilder(__cp_HnoGqQADBYENwUxDaeIC0N, 16);
            n10.Spread<bool> output_60;
            try
            {
                var i_6 = 0;
                foreach (var item_1 in BezierPoints_In)
                {
                    var splicer_5 = item_1;
                    var i_local_7 = i_6;
                    var Output_12 = splicer_5.Split(Point_Out: out n8.EditablePoint_R<T> Point_8, Control1_Out: out n8.EditablePoint_R<T> Control1_9, Control2_Out: out n8.EditablePoint_R<T> Control2_10, Mode_Out: out int Mode_11);
                    var Output_14 = Point_8.GetPosition(Position_Out: out T Position_13);
                    var Output_16 = Point_8.GetSelected(Selected_Out: out bool Selected_15);
                    var Output_18 = Control2_10.GetSelected(Selected_Out: out bool Selected_17);
                    bool Apply_19 = true;
                    var Output_20 = Selected_17;
                    if (Apply_19)
                    {
                        var Output_21 = Selected_17 || Selected_15;
                        Output_20 = Output_21;
                    }

                    var Output_23 = Control2_10.GetPosition(Position_Out: out T Position_22);
                    var Output_25 = Control1_9.GetPosition(Position_Out: out T Position_24);
                    bool Apply_26 = true;
                    var Output_27 = accumulator_2;
                    if (Apply_26)
                    {
                        n14._Operations_.Add<T>(Input_In: accumulator_2, Item_In: Position_24, Output_Out: out Output_27);
                    }

                    bool Apply_28 = true;
                    var Output_29 = Output_27;
                    if (Apply_28)
                    {
                        n14._Operations_.Add<T>(Input_In: Output_27, Item_In: Position_22, Output_Out: out Output_29);
                    }

                    var Output_31 = Control1_9.GetSelected(Selected_Out: out bool Selected_30);
                    bool Apply_32 = true;
                    var Output_33 = Selected_30;
                    if (Apply_32)
                    {
                        var Output_34 = Selected_30 || Selected_15;
                        Output_33 = Output_34;
                    }

                    bool Apply_35 = true;
                    var Output_36 = accumulator_4;
                    if (Apply_35)
                    {
                        n14._Operations_.Add<bool>(Input_In: accumulator_4, Item_In: Output_33, Output_Out: out Output_36);
                    }

                    bool Apply_37 = true;
                    var Output_38 = Output_36;
                    if (Apply_37)
                    {
                        n14._Operations_.Add<bool>(Input_In: Output_36, Item_In: Output_20, Output_Out: out Output_38);
                    }

                    var Output_40 = Control1_9.GetLocked(Locked_Out: out bool Locked_39);
                    bool Apply_41 = true;
                    var Output_42 = Locked_39;
                    if (Apply_41)
                    {
                        var Output_43 = !Locked_39;
                        Output_42 = Output_43;
                    }

                    bool Apply_44 = true;
                    var Output_45 = accumulator_3;
                    if (Apply_44)
                    {
                        n14._Operations_.Add<bool>(Input_In: accumulator_3, Item_In: Output_42, Output_Out: out Output_45);
                    }

                    var Output_47 = Control2_10.GetLocked(Locked_Out: out bool Locked_46);
                    bool Apply_48 = true;
                    var Output_49 = Locked_46;
                    if (Apply_48)
                    {
                        var Output_50 = !Locked_46;
                        Output_49 = Output_50;
                    }

                    bool Apply_51 = true;
                    var Output_52 = Output_45;
                    if (Apply_51)
                    {
                        n14._Operations_.Add<bool>(Input_In: Output_45, Item_In: Output_49, Output_Out: out Output_52);
                    }

                    var Output_54 = Point_8.GetLocked(Locked_Out: out bool Locked_53);
                    builder_55.Add(Position_13);
                    builder_57.Add(Locked_53);
                    builder_59.Add(Selected_15);
                    accumulator_2 = Output_29;
                    accumulator_3 = Output_52;
                    accumulator_4 = Output_38;
                    i_6++;
                }
            }
            finally
            {
                output_56 = builder_55.Commit();
                output_58 = builder_57.Commit();
                output_60 = builder_59.Commit();
            }

            Points_Out = output_56;
            Controls_Out = accumulator_2;
            Locked_Out = output_58;
            SelectedPoints_Out = output_60;
            SelectedControls_Out = accumulator_4;
            VisibleControls_Out = accumulator_3;
            return;
        }

        public static void ReflectControl<T, AdM>(n8.EditablePoint_R<T> Input_In, n8.EditablePoint_R<T> Control2_In, n8.EditablePoint_R<T> Point_In, out n8.EditablePoint_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            var Output_2 = Point_In.GetPosition(Position_Out: out T Position_1);
            var Output_4 = Control2_In.GetPosition(Position_Out: out T Position_3);
            bool Apply_5 = true;
            var Output_6 = Position_3;
            if (Apply_5)
            {
                w_0.OperatorMinus(Input_In: Position_3, Input_2_In: Position_1, Output_Out: out Output_6);
            }

            bool Apply_7 = true;
            var Output_8 = Position_1;
            if (Apply_7)
            {
                w_0.OperatorMinus(Input_In: Position_1, Input_2_In: Output_6, Output_Out: out Output_8);
            }

            bool Apply_9 = true;
            var Output_10 = Input_In;
            if (Apply_9)
            {
                Output_10 = Input_In.SetPosition(Position_In: Output_8);
            }

            Output_Out = Output_10;
            return;
        }

        public static void ToEditableBezierKnot<T, AdM>(n22.BezierKnot_R<T> BezierKnot_In, int Next_Id_In, out n8.EditableBezierKnot_R<T> EditableBezierKnot_Out, out int Next_Id_Out)
            where AdM : struct, n21.IAdaptiveOperatorEquals<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_GCrwDfJi4pYMewHyYEQKpz_1 = __slot_GCrwDfJi4pYMewHyYEQKpz;
            int __pad_VXTeJ6RlDFcOAE8kFBrbDq_2 = __slot_VXTeJ6RlDFcOAE8kFBrbDq;
            int __pad_V4HxgiSV1f3PbN5ftcrPss_3 = __slot_V4HxgiSV1f3PbN5ftcrPss;
            var Output_8 = BezierKnot_In.Split(Point_Out: out T Point_4, Control1_Out: out T Control1_5, Control2_Out: out T Control2_6, Mode_Out: out int Mode_7);
            var Output_9 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            bool Locked_10 = false;
            bool Selected_11 = false;
            bool Hovered_12 = false;
            bool KeyHovered_13 = false;
            int SelectionModifier_14 = 0;
            var Output_15 = Output_9.Join(Position_In: Point_4, Locked_In: Locked_10, Selected_In: Selected_11, Hovered_In: Hovered_12, KeyHovered_In: KeyHovered_13, SelectionModifier_In: SelectionModifier_14, Id_In: Next_Id_In);
            bool Apply_16 = true;
            var Output_17 = Next_Id_In;
            if (Apply_16)
            {
                var Output_18 = Next_Id_In + __pad_GCrwDfJi4pYMewHyYEQKpz_1;
                Output_17 = Output_18;
            }

            var Output_19 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            w_0.OperatorEquals(Input_In: Point_4, Input_2_In: Control1_5, Result_Out: out bool Result_20);
            bool Selected_21 = false;
            bool Hovered_22 = false;
            bool KeyHovered_23 = false;
            int SelectionModifier_24 = 0;
            var Output_25 = Output_19.Join(Position_In: Control1_5, Locked_In: Result_20, Selected_In: Selected_21, Hovered_In: Hovered_22, KeyHovered_In: KeyHovered_23, SelectionModifier_In: SelectionModifier_24, Id_In: Output_17);
            var Output_26 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            var Output_27 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            w_0.OperatorEquals(Input_In: Point_4, Input_2_In: Control2_6, Result_Out: out bool Result_28);
            bool Apply_29 = true;
            var Output_30 = Output_17;
            if (Apply_29)
            {
                var Output_31 = Output_17 + __pad_VXTeJ6RlDFcOAE8kFBrbDq_2;
                Output_30 = Output_31;
            }

            bool Selected_32 = false;
            bool Hovered_33 = false;
            bool KeyHovered_34 = false;
            int SelectionModifier_35 = 0;
            var Output_36 = Output_27.Join(Position_In: Control2_6, Locked_In: Result_28, Selected_In: Selected_32, Hovered_In: Hovered_33, KeyHovered_In: KeyHovered_34, SelectionModifier_In: SelectionModifier_35, Id_In: Output_30);
            bool Apply_37 = true;
            var Output_38 = Output_26;
            if (Apply_37)
            {
                Output_38 = Output_26.Join(Point_In: Output_15, Contol1_In: Output_25, Control2_In: Output_36, Mode_In: Mode_7);
            }

            bool Apply_39 = true;
            var Output_40 = Output_30;
            if (Apply_39)
            {
                var Output_41 = Output_30 + __pad_V4HxgiSV1f3PbN5ftcrPss_3;
                Output_40 = Output_41;
            }

            EditableBezierKnot_Out = Output_38;
            Next_Id_Out = Output_40;
            return;
        }

        public static void ToBezierKnot<T, AdM>(n8.EditableBezierKnot_R<T> EditableBezierKnot_In, out n22.BezierKnot_R<T> BezierKnot_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Output_5 = EditableBezierKnot_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_1, Control1_Out: out n8.EditablePoint_R<T> Control1_2, Control2_Out: out n8.EditablePoint_R<T> Control2_3, Mode_Out: out int Mode_4);
            var Output_13 = Point_1.Split(Position_Out: out T Position_6, Locked_Out: out bool Locked_7, Selected_Out: out bool Selected_8, Hovered_Out: out bool Hovered_9, KeyHovered_Out: out bool KeyHovered_10, SelectionModifier_Out: out int SelectionModifier_11, Id_Out: out int Id_12);
            var Output_14 = n22.BezierKnot_R<T>.CreateDefault<AdM>();
            var Output_22 = Control1_2.Split(Position_Out: out T Position_15, Locked_Out: out bool Locked_16, Selected_Out: out bool Selected_17, Hovered_Out: out bool Hovered_18, KeyHovered_Out: out bool KeyHovered_19, SelectionModifier_Out: out int SelectionModifier_20, Id_Out: out int Id_21);
            var Output_30 = Control2_3.Split(Position_Out: out T Position_23, Locked_Out: out bool Locked_24, Selected_Out: out bool Selected_25, Hovered_Out: out bool Hovered_26, KeyHovered_Out: out bool KeyHovered_27, SelectionModifier_Out: out int SelectionModifier_28, Id_Out: out int Id_29);
            bool Apply_31 = true;
            var Output_32 = Output_14;
            if (Apply_31)
            {
                Output_32 = Output_14.Join<AdM>(Point_In: Position_6, Control1_In: Position_15, Control2_In: Position_23, Mode_In: Mode_4);
            }

            BezierKnot_Out = Output_32;
            return;
        }

        public static void FirstOrLast<T>(n10.Spread<T> Spread_In, int Index_In, out bool Output_Out)
        {
            int __pad_CVQeuTv6DUoMwGuYXI2uv9_0 = __slot_CVQeuTv6DUoMwGuYXI2uv9;
            int __pad_AdEJxSzWggOO9GDkuzJn99_1 = __slot_AdEJxSzWggOO9GDkuzJn99;
            n14._Operations_.Count<T>(Input_In: Spread_In, Count_Out: out int Count_2);
            bool Apply_3 = true;
            var Output_4 = Count_2;
            if (Apply_3)
            {
                var Output_5 = Count_2 - __pad_CVQeuTv6DUoMwGuYXI2uv9_0;
                Output_4 = Output_5;
            }

            var Result_6 = Index_In == Output_4;
            var Result_7 = Index_In == __pad_AdEJxSzWggOO9GDkuzJn99_1;
            bool Apply_8 = true;
            var Output_9 = Result_7;
            if (Apply_8)
            {
                var Output_10 = Result_7 || Result_6;
                Output_9 = Output_10;
            }

            Output_Out = Output_9;
            return;
        }

        public static void RotateControlAroundPoint<T, AdM>(T Input_In, T Point_In, T Moving_Control_In, bool Is_Symmetric_In, out T Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n21.IAdaptiveOperatorMinus<T>, n21.IAdaptiveOperatorMinus_Negate<T>
        {
            var w_0 = default(AdM);
            bool Apply_1 = true;
            var Output_2 = Input_In;
            if (Apply_1)
            {
                w_0.OperatorMinus(Input_In: Input_In, Input_2_In: Point_In, Output_Out: out Output_2);
            }

            bool Apply_3 = true;
            var Output_4 = Moving_Control_In;
            if (Apply_3)
            {
                w_0.OperatorMinus(Input_In: Moving_Control_In, Input_2_In: Point_In, Output_Out: out Output_4);
            }

            bool Apply_5 = true;
            var Output_6 = Output_4;
            if (Apply_5)
            {
                w_0.Normalize(Input_In: Output_4, Output_Out: out Output_6);
            }

            bool Apply_7 = true;
            var Output_8 = Output_6;
            if (Apply_7)
            {
                w_0.OperatorMinus_Negate(Input_In: Output_6, Output_Out: out Output_8);
            }

            w_0.Length(Input_In: Output_2, Result_Out: out float Result_9);
            bool Apply_10 = true;
            var Output_11 = Output_8;
            if (Apply_10)
            {
                w_0.OperatorMulitply_Scale(Input_In: Output_8, Scalar_In: Result_9, Output_Out: out Output_11);
            }

            bool Apply_12 = true;
            var Output_13 = Output_4;
            if (Apply_12)
            {
                w_0.OperatorMinus_Negate(Input_In: Output_4, Output_Out: out Output_13);
            }

            n32._Operations_.Switch_Boolean<T>(Condition_In: Is_Symmetric_In, Input_In: Output_11, Input_2_In: Output_13, Output_Out: out T Output_14);
            bool Apply_15 = true;
            var Output_16 = Point_In;
            if (Apply_15)
            {
                w_0.OperatorPlus(Input_In: Point_In, Input_2_In: Output_14, Output_Out: out Output_16);
            }

            Output_Out = Output_16;
            return;
        }

        public static void MakeLastKnotSmooth<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_UDjdgBIBsLRLsuQ9tTEzxK_1 = __slot_UDjdgBIBsLRLsuQ9tTEzxK;
            int __pad_QYqVABxbcZtPtsbFAAe5yF_2 = __slot_QYqVABxbcZtPtsbFAAe5yF;
            var Output_3 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n12._Operations_.LastOrDefault<n10.Spread<n8.EditableBezierKnot_R<T>>, n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_3, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_4, Result_Out: out n8.EditableBezierKnot_R<T> Result_5);
            bool Apply_6 = true;
            var Output_7 = Result_5;
            if (Apply_6)
            {
                Output_7 = Result_5.SetSmoothMode();
            }

            n14._Operations_.Count<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Count_Out: out int Count_8);
            var Result_9 = Count_8 > __pad_QYqVABxbcZtPtsbFAAe5yF_2;
            var Output_10 = Input_In;
            if (Result_9)
            {
                n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_7, Index_In: __pad_UDjdgBIBsLRLsuQ9tTEzxK_1, Output_Out: out Output_10);
            }

            Output_Out = Output_10;
            return;
        }

        public static void MakeLastKnotCorner<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_GuZ6g4mQqPdNIVugaeHMoU_1 = __slot_GuZ6g4mQqPdNIVugaeHMoU;
            var Output_2 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n12._Operations_.LastOrDefault<n10.Spread<n8.EditableBezierKnot_R<T>>, n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_3, Result_Out: out n8.EditableBezierKnot_R<T> Result_4);
            bool Apply_5 = true;
            var Output_6 = Result_4;
            if (Apply_5)
            {
                Output_6 = Result_4.SetCornerMode();
            }

            bool Apply_7 = true;
            var Output_8 = Input_In;
            if (Apply_7)
            {
                n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_6, Index_In: __pad_GuZ6g4mQqPdNIVugaeHMoU_1, Output_Out: out Output_8);
            }

            Output_Out = Output_8;
            return;
        }

        public static void MakeFirstKnotCorner<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_IyOXfLAgl5LOj8b2sITkTN_1 = __slot_IyOXfLAgl5LOj8b2sITkTN;
            var Output_2 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n12._Operations_.FirstOrDefault<n10.Spread<n8.EditableBezierKnot_R<T>>, n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_2, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_3, Result_Out: out n8.EditableBezierKnot_R<T> Result_4);
            bool Apply_5 = true;
            var Output_6 = Result_4;
            if (Apply_5)
            {
                Output_6 = Result_4.SetCornerMode();
            }

            bool Apply_7 = true;
            var Output_8 = Input_In;
            if (Apply_7)
            {
                n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_6, Index_In: __pad_IyOXfLAgl5LOj8b2sITkTN_1, Output_Out: out Output_8);
            }

            Output_Out = Output_8;
            return;
        }

        public static void SmoothAddedPoints<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, int New_Points_Count_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            int __pad_EYOXVNGkYrkO4K7Y6F8xbL_1 = __slot_EYOXVNGkYrkO4K7Y6F8xbL;
            n14._Operations_.Count<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Count_Out: out int Count_2);
            var Result_3 = Count_2 > __pad_EYOXVNGkYrkO4K7Y6F8xbL_1;
            n10.Spread<n8.EditableBezierKnot_R<T>> Points_4;
            if (Result_3)
            {
                int __pad_MrCwi6RZn6ROI6LLeN6wch_5 = __slot_MrCwi6RZn6ROI6LLeN6wch;
                var Output_6 = Count_2 - New_Points_Count_In;
                var Output_7 = Output_6 - __pad_MrCwi6RZn6ROI6LLeN6wch_5;
                n10.Spread<n8.EditableBezierKnot_R<T>> accumulator_9 = Input_In;
                for (var i_8 = 0; i_8 < New_Points_Count_In; i_8++)
                {
                    var i_local_10 = i_8;
                    int __pad_Q5aTgijK1WBMQCmEzgAbZi_11 = __slot_Q5aTgijK1WBMQCmEzgAbZi;
                    int __pad_UQU06UbYCaKL9uFNF8kdAZ_12 = __slot_UQU06UbYCaKL9uFNF8kdAZ;
                    bool __pad_UUtZzmxrbXPPIGeeyQKzcv_13 = __slot_UUtZzmxrbXPPIGeeyQKzcv;
                    bool Apply_14 = true;
                    var Output_15 = Output_7;
                    if (Apply_14)
                    {
                        var Output_16 = Output_7 + i_local_10;
                        Output_15 = Output_16;
                    }

                    bool Apply_17 = true;
                    var Output_18 = Output_15;
                    if (Apply_17)
                    {
                        var Output_19 = Output_15 + __pad_Q5aTgijK1WBMQCmEzgAbZi_11;
                        Output_18 = Output_19;
                    }

                    var Output_20 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
                    n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: accumulator_9, Default_Value_In: Output_20, Index_In: Output_18, Result_Out: out n8.EditableBezierKnot_R<T> Result_21);
                    var Output_22 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
                    bool Apply_23 = true;
                    var Output_24 = Output_15;
                    if (Apply_23)
                    {
                        var Output_25 = Output_15 - __pad_UQU06UbYCaKL9uFNF8kdAZ_12;
                        Output_24 = Output_25;
                    }

                    n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: accumulator_9, Default_Value_In: Output_22, Index_In: Output_24, Result_Out: out n8.EditableBezierKnot_R<T> Result_26);
                    var Output_27 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
                    n14._Operations_.GetSlice<n8.EditableBezierKnot_R<T>>(Input_In: accumulator_9, Default_Value_In: Output_27, Index_In: Output_15, Result_Out: out n8.EditableBezierKnot_R<T> Result_28);
                    n20._Operations_.CalculateControls<T, AdM>(Previous_Knot_In: Result_26, Current_In: Result_28, Next_Knot_In: Result_21, Control1_Position_Out: out T Control1_Position_29, Control2_Position_Out: out T Control2_Position_30);
                    bool Apply_31 = true;
                    var Output_32 = Result_28;
                    if (Apply_31)
                    {
                        Output_32 = Result_28.SetSmoothControls(Control1_In: Control1_Position_29, Control2_In: Control2_Position_30);
                    }

                    var Output_33 = Output_32;
                    if (__pad_UUtZzmxrbXPPIGeeyQKzcv_13)
                    {
                        Output_33 = Output_32.SetSmoothMode();
                    }

                    bool Apply_34 = true;
                    var Output_35 = accumulator_9;
                    if (Apply_34)
                    {
                        n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: accumulator_9, Value_In: Output_33, Index_In: Output_15, Output_Out: out Output_35);
                    }

                    accumulator_9 = Output_35;
                }

                Points_4 = accumulator_9;
            }
            else
            {
                Points_4 = Input_In;
            }

            Output_Out = Points_4;
            return;
        }

        public static void ReflectControls<T, AdM>(n8.EditableBezierKnot_R<T> Input_In, bool Reflect_Control1_In, bool Reflect_Control2_In, out n8.EditableBezierKnot_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            n8.EditableBezierKnot_R<T> Output_1;
            if (Reflect_Control1_In)
            {
                var Output_6 = Input_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_2, Control1_Out: out n8.EditablePoint_R<T> Control1_3, Control2_Out: out n8.EditablePoint_R<T> Control2_4, Mode_Out: out int Mode_5);
                bool Apply_7 = true;
                var Output_8 = Control1_3;
                if (Apply_7)
                {
                    n20._Operations_.ReflectControl<T, AdM>(Input_In: Control1_3, Control2_In: Control2_4, Point_In: Point_2, Output_Out: out Output_8);
                }

                bool Apply_9 = true;
                var Output_10 = Output_8;
                if (Apply_9)
                {
                    Output_10 = Output_8.Unlock();
                }

                bool Apply_11 = true;
                var Output_12 = Input_In;
                if (Apply_11)
                {
                    Output_12 = Input_In.SetControl1(Control1_In: Output_10);
                }

                Output_1 = Output_12;
            }
            else
            {
                Output_1 = Input_In;
            }

            n8.EditableBezierKnot_R<T> Output_13;
            if (Reflect_Control2_In)
            {
                var Output_18 = Output_1.Split(Point_Out: out n8.EditablePoint_R<T> Point_14, Control1_Out: out n8.EditablePoint_R<T> Control1_15, Control2_Out: out n8.EditablePoint_R<T> Control2_16, Mode_Out: out int Mode_17);
                bool Apply_19 = true;
                var Output_20 = Control2_16;
                if (Apply_19)
                {
                    n20._Operations_.ReflectControl<T, AdM>(Input_In: Control2_16, Control2_In: Control1_15, Point_In: Point_14, Output_Out: out Output_20);
                }

                bool Apply_21 = true;
                var Output_22 = Output_20;
                if (Apply_21)
                {
                    Output_22 = Output_20.Unlock();
                }

                bool Apply_23 = true;
                var Output_24 = Output_1;
                if (Apply_23)
                {
                    Output_24 = Output_1.SetControl2(Control2_In: Output_22);
                }

                Output_13 = Output_24;
            }
            else
            {
                Output_13 = Output_1;
            }

            Output_Out = Output_13;
            return;
        }

        public static void MakeSmoothSymmetricKnot<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            n10.Spread<n8.EditableBezierKnot_R<T>> __cp_UdFO6cP4PkqPP7h4R4xIEs = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            var w_0 = default(AdM);
            var builder_36 = n6.CollectionBuilders.GetBuilder(__cp_UdFO6cP4PkqPP7h4R4xIEs, 16);
            n10.Spread<n8.EditableBezierKnot_R<T>> output_37;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in n6.CollectionExtensions.AsSpan(Input_In))
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    var Output_6 = splicer_2.IsPointOrControlsSelected(Result_Out: out bool Result_5);
                    var Output_7 = splicer_2;
                    if (Result_5)
                    {
                        Output_7 = splicer_2.SetSmoothSymmetricMode();
                    }

                    var Output_9 = splicer_2.IsSmooth(Result_Out: out bool Result_8);
                    bool Apply_10 = true;
                    var Output_11 = Result_8;
                    if (Apply_10)
                    {
                        var Output_12 = !Result_8;
                        Output_11 = Output_12;
                    }

                    n20._Operations_.FirstOrLast<n8.EditableBezierKnot_R<T>>(Spread_In: Input_In, Index_In: i_local_4, Output_Out: out bool Output_13);
                    bool Apply_14 = true;
                    var Output_15 = Output_11;
                    if (Apply_14)
                    {
                        var Output_16 = Output_11 || Output_13;
                        Output_15 = Output_16;
                    }

                    bool Apply_17 = true;
                    var Output_18 = Result_5;
                    if (Apply_17)
                    {
                        var Output_19 = Result_5 && Output_15;
                        Output_18 = Output_19;
                    }

                    var Output_20 = Output_7;
                    if (Output_18)
                    {
                        n20._Operations_.SmoothControls<T, AdM>(Input_In: Output_7, Knots_In: Input_In, Index_In: i_local_4, Output_Out: out Output_20);
                    }

                    var Output_25 = splicer_2.Split(Point_Out: out n8.EditablePoint_R<T> Point_21, Control1_Out: out n8.EditablePoint_R<T> Control1_22, Control2_Out: out n8.EditablePoint_R<T> Control2_23, Mode_Out: out int Mode_24);
                    var Output_27 = Control2_23.GetSelected(Selected_Out: out bool Selected_26);
                    var Output_29 = Control1_22.GetSelected(Selected_Out: out bool Selected_28);
                    var Output_31 = Point_21.GetSelected(Selected_Out: out bool Selected_30);
                    bool Apply_32 = true;
                    var Output_33 = Selected_28;
                    if (Apply_32)
                    {
                        var Output_34 = Selected_28 || Selected_30;
                        Output_33 = Output_34;
                    }

                    var Output_35 = Output_20;
                    if (Result_5)
                    {
                        n20._Operations_.ReflectControls<T, AdM>(Input_In: Output_20, Reflect_Control1_In: Selected_26, Reflect_Control2_In: Output_33, Output_Out: out Output_35);
                    }

                    builder_36.Add(Output_35);
                    i_3++;
                }
            }
            finally
            {
                output_37 = builder_36.Commit();
            }

            Output_Out = output_37;
            return;
        }

        public static void MakeSmoothKnot<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            n10.Spread<n8.EditableBezierKnot_R<T>> __cp_O8D6lFFrt5yMkeAfCvIxDd = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            var w_0 = default(AdM);
            var builder_17 = n6.CollectionBuilders.GetBuilder(__cp_O8D6lFFrt5yMkeAfCvIxDd, 16);
            n10.Spread<n8.EditableBezierKnot_R<T>> output_18;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in n6.CollectionExtensions.AsSpan(Input_In))
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    var Output_6 = splicer_2.IsPointOrControlsSelected(Result_Out: out bool Result_5);
                    var Output_7 = splicer_2;
                    if (Result_5)
                    {
                        Output_7 = splicer_2.SetSmoothMode();
                    }

                    var Output_9 = splicer_2.IsSymmetric(Result_Out: out bool Result_8);
                    bool Apply_10 = true;
                    var Output_11 = Result_8;
                    if (Apply_10)
                    {
                        var Output_12 = !Result_8;
                        Output_11 = Output_12;
                    }

                    bool Apply_13 = true;
                    var Output_14 = Result_5;
                    if (Apply_13)
                    {
                        var Output_15 = Result_5 && Output_11;
                        Output_14 = Output_15;
                    }

                    var Output_16 = Output_7;
                    if (Output_14)
                    {
                        n20._Operations_.SmoothControls<T, AdM>(Input_In: Output_7, Knots_In: Input_In, Index_In: i_local_4, Output_Out: out Output_16);
                    }

                    builder_17.Add(Output_16);
                    i_3++;
                }
            }
            finally
            {
                output_18 = builder_17.Commit();
            }

            Output_Out = output_18;
            return;
        }

        public static void MakeCornerWithHandlesKnot<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>
        {
            n10.Spread<n8.EditableBezierKnot_R<T>> __cp_DkIWx02NCOcPvgITkRZKUx = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            var w_0 = default(AdM);
            var builder_21 = n6.CollectionBuilders.GetBuilder(__cp_DkIWx02NCOcPvgITkRZKUx, 16);
            n10.Spread<n8.EditableBezierKnot_R<T>> output_22;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in n6.CollectionExtensions.AsSpan(Input_In))
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    var Output_6 = splicer_2.IsPointOrControlsSelected(Result_Out: out bool Result_5);
                    var Output_7 = splicer_2;
                    if (Result_5)
                    {
                        Output_7 = splicer_2.SetCornerWithHandlesMode();
                    }

                    var Output_9 = splicer_2.IsCorner(Result_Out: out bool Result_8);
                    n20._Operations_.FirstOrLast<n8.EditableBezierKnot_R<T>>(Spread_In: Input_In, Index_In: i_local_4, Output_Out: out bool Output_10);
                    bool Apply_11 = true;
                    var Output_12 = Output_10;
                    if (Apply_11)
                    {
                        var Output_13 = !Output_10;
                        Output_12 = Output_13;
                    }

                    var Output_14 = Result_5 && Result_8;
                    var Output_15 = Output_14 && Output_12;
                    var Output_16 = Output_7;
                    if (Output_15)
                    {
                        n20._Operations_.CreateControlsForCorner<T, AdM>(Input_In: Output_7, Knots_In: Input_In, Index_In: i_local_4, Output_Out: out Output_16);
                    }

                    bool Apply_17 = true;
                    var Output_18 = Result_5;
                    if (Apply_17)
                    {
                        var Output_19 = Result_5 && Output_10;
                        Output_18 = Output_19;
                    }

                    var Output_20 = Output_16;
                    if (Output_18)
                    {
                        n20._Operations_.SmoothControls<T, AdM>(Input_In: Output_16, Knots_In: Input_In, Index_In: i_local_4, Output_Out: out Output_20);
                    }

                    builder_21.Add(Output_20);
                    i_3++;
                }
            }
            finally
            {
                output_22 = builder_21.Commit();
            }

            Output_Out = output_22;
            return;
        }

        public static void MakeCornerKnot<T>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
        {
            n10.Spread<n8.EditableBezierKnot_R<T>> __cp_ASRys9Oo0OUPRA1YomLFI2 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            var builder_9 = n6.CollectionBuilders.GetBuilder(__cp_ASRys9Oo0OUPRA1YomLFI2, 16);
            n10.Spread<n8.EditableBezierKnot_R<T>> output_10;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in n6.CollectionExtensions.AsSpan(Input_In))
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    var Output_5 = splicer_1.IsPointOrControlsSelected(Result_Out: out bool Result_4);
                    var Output_6 = splicer_1;
                    if (Result_4)
                    {
                        Output_6 = splicer_1.SetCornerMode();
                    }

                    var Output_7 = Output_6;
                    if (Result_4)
                    {
                        Output_7 = Output_6.HideControls();
                    }

                    var Output_8 = Output_7;
                    if (Result_4)
                    {
                        Output_8 = Output_7.SelectPoint();
                    }

                    builder_9.Add(Output_8);
                    i_2++;
                }
            }
            finally
            {
                output_10 = builder_9.Commit();
            }

            Output_Out = output_10;
            return;
        }

        public static void UpdateBezierKnots<T2, T, AdM>(T2 Input_In, n10.Spread<n8.EditablePoint_R<T>> New_Positions_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where T2 : n23.IEnumerable<n8.EditableBezierKnot_R<T>> where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n5.IAdaptiveCreateDefault<T>, n21.IAdaptiveOperatorMinus<T>, n21.IAdaptiveOperatorMinus_Negate<T>
        {
            n10.Spread<n8.EditableBezierKnot_R<T>> __cp_Al0aottKuwSNLWg0ek7f0N = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T>>();
            var w_0 = default(AdM);
            var builder_24 = n6.CollectionBuilders.GetBuilder(__cp_Al0aottKuwSNLWg0ek7f0N, 16);
            n10.Spread<n8.EditableBezierKnot_R<T>> output_25;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Input_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    int __pad_BzoXVyHP8swOR1PwpjhYYN_5 = __slot_BzoXVyHP8swOR1PwpjhYYN;
                    var Output_6 = i_local_4 * __pad_BzoXVyHP8swOR1PwpjhYYN_5;
                    n14._Operations_.GetSpread<n8.EditablePoint_R<T>>(Input_In: New_Positions_In, Index_In: Output_6, Count_In: __pad_BzoXVyHP8swOR1PwpjhYYN_5, Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_7);
                    var Output_9 = splicer_2.GetMode(Mode_Out: out int Mode_8);
                    n20._Operations_.CorrectControlsSelection<T, AdM>(Spread_of_3_Points_In: Output_7, Knot_Mode_In: Mode_8, Point_Out: out n8.EditablePoint_R<T> Point_10, Control1_Out: out n8.EditablePoint_R<T> Control1_11, Control2_Out: out n8.EditablePoint_R<T> Control2_12);
                    var Output_14 = splicer_2.IsSmooth(Result_Out: out bool Result_13);
                    var Output_16 = Point_10.GetSelected(Selected_Out: out bool Selected_15);
                    bool Apply_17 = true;
                    var Output_18 = Selected_15;
                    if (Apply_17)
                    {
                        var Output_19 = !Selected_15;
                        Output_18 = Output_19;
                    }

                    var Output_20 = Result_13 && Output_18;
                    var Output_21 = splicer_2.UpdateKnot<AdM>(Point_In: Point_10, Control1_In: Control1_11, Control2_In: Control2_12);
                    n20._Operations_.UpdateControls<T, T>(Input_In: Output_21, New_Point_In: Point_10, New_Control1_In: Control1_11, New_Control2_In: Control2_12, Output_Out: out n8.EditableBezierKnot_R<T> Output_22);
                    var Output_23 = Output_22;
                    if (Output_20)
                    {
                        n20._Operations_.MoveSmoothControls<T, AdM>(Input_In: Output_22, Control1_New_In: Control1_11, Control2_New_In: Control2_12, Output_Out: out Output_23);
                    }

                    builder_24.Add(Output_23);
                    i_3++;
                }
            }
            finally
            {
                output_25 = builder_24.Commit();
            }

            Output_Out = output_25;
            return;
        }

        public static void SmoothKnot<T, AdM>(n8.EditableBezierKnot_R<T> Input_In, out n8.EditableBezierKnot_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            var Output_5 = Input_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_1, Control1_Out: out n8.EditablePoint_R<T> Control1_2, Control2_Out: out n8.EditablePoint_R<T> Control2_3, Mode_Out: out int Mode_4);
            var Output_7 = Point_1.GetSelected(Selected_Out: out bool Selected_6);
            var Output_9 = Control1_2.GetSelected(Selected_Out: out bool Selected_8);
            var Output_11 = Control1_2.GetLocked(Locked_Out: out bool Locked_10);
            bool Apply_12 = true;
            var Output_13 = Locked_10;
            if (Apply_12)
            {
                var Output_14 = !Locked_10;
                Output_13 = Output_14;
            }

            bool Apply_15 = true;
            var Output_16 = Selected_8;
            if (Apply_15)
            {
                var Output_17 = Selected_8 && Output_13;
                Output_16 = Output_17;
            }

            bool Apply_18 = true;
            var Output_19 = Selected_6;
            if (Apply_18)
            {
                var Output_20 = Selected_6 || Output_16;
                Output_19 = Output_20;
            }

            var Output_21 = Control2_3;
            if (Output_19)
            {
                n20._Operations_.ReflectControl<T, AdM>(Input_In: Control2_3, Control2_In: Control1_2, Point_In: Point_1, Output_Out: out Output_21);
            }

            bool Apply_22 = true;
            var Output_23 = Input_In;
            if (Apply_22)
            {
                Output_23 = Input_In.SetControl2(Control2_In: Output_21);
            }

            bool Apply_24 = true;
            var Output_25 = Output_19;
            if (Apply_24)
            {
                var Output_26 = !Output_19;
                Output_25 = Output_26;
            }

            var Output_28 = Control2_3.GetSelected(Selected_Out: out bool Selected_27);
            var Output_30 = Control2_3.GetLocked(Locked_Out: out bool Locked_29);
            bool Apply_31 = true;
            var Output_32 = Locked_29;
            if (Apply_31)
            {
                var Output_33 = !Locked_29;
                Output_32 = Output_33;
            }

            bool Apply_34 = true;
            var Output_35 = Selected_27;
            if (Apply_34)
            {
                var Output_36 = Selected_27 && Output_32;
                Output_35 = Output_36;
            }

            bool Apply_37 = true;
            var Output_38 = Output_25;
            if (Apply_37)
            {
                var Output_39 = Output_25 && Output_35;
                Output_38 = Output_39;
            }

            var Output_40 = Control1_2;
            if (Output_38)
            {
                n20._Operations_.ReflectControl<T, AdM>(Input_In: Control1_2, Control2_In: Control2_3, Point_In: Point_1, Output_Out: out Output_40);
            }

            bool Apply_41 = true;
            var Output_42 = Output_23;
            if (Apply_41)
            {
                Output_42 = Output_23.SetControl1(Control1_In: Output_40);
            }

            Output_Out = Output_42;
            return;
        }

        public static void MoveSmoothControls<T, AdM>(n8.EditableBezierKnot_R<T> Input_In, n8.EditablePoint_R<T> Control1_New_In, n8.EditablePoint_R<T> Control2_New_In, out n8.EditableBezierKnot_R<T> Output_Out)
            where AdM : struct, n21.IAdaptiveLength<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMulitply_Scale<T>, n21.IAdaptiveNormalize<T>, n21.IAdaptiveOperatorMinus<T>, n21.IAdaptiveOperatorMinus_Negate<T>
        {
            var w_0 = default(AdM);
            var Output_5 = Input_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_1, Control1_Out: out n8.EditablePoint_R<T> Control1_2, Control2_Out: out n8.EditablePoint_R<T> Control2_3, Mode_Out: out int Mode_4);
            var Output_7 = Point_1.GetPosition(Position_Out: out T Position_6);
            var Output_9 = Control2_3.GetPosition(Position_Out: out T Position_8);
            var Output_11 = Control1_New_In.GetPosition(Position_Out: out T Position_10);
            var Output_13 = Input_In.IsSymmetric(Result_Out: out bool Result_12);
            bool Apply_14 = true;
            var Output_15 = Position_8;
            if (Apply_14)
            {
                n20._Operations_.RotateControlAroundPoint<T, AdM>(Input_In: Position_8, Point_In: Position_6, Moving_Control_In: Position_10, Is_Symmetric_In: Result_12, Output_Out: out Output_15);
            }

            var Output_17 = Control1_New_In.GetSelected(Selected_Out: out bool Selected_16);
            var Output_19 = Control2_New_In.GetPosition(Position_Out: out T Position_18);
            n32._Operations_.Switch_Boolean<T>(Condition_In: Selected_16, Input_In: Position_18, Input_2_In: Output_15, Output_Out: out T Output_20);
            bool Apply_21 = true;
            var Output_22 = Control2_3;
            if (Apply_21)
            {
                Output_22 = Control2_3.SetPosition(Position_In: Output_20);
            }

            var Output_24 = Control2_New_In.GetSelected(Selected_Out: out bool Selected_23);
            var Output_26 = Control1_2.GetPosition(Position_Out: out T Position_25);
            bool Apply_27 = true;
            var Output_28 = Position_25;
            if (Apply_27)
            {
                n20._Operations_.RotateControlAroundPoint<T, AdM>(Input_In: Position_25, Point_In: Position_6, Moving_Control_In: Position_18, Is_Symmetric_In: Result_12, Output_Out: out Output_28);
            }

            n32._Operations_.Switch_Boolean<T>(Condition_In: Selected_23, Input_In: Position_10, Input_2_In: Output_28, Output_Out: out T Output_29);
            bool Apply_30 = true;
            var Output_31 = Control1_2;
            if (Apply_30)
            {
                Output_31 = Control1_2.SetPosition(Position_In: Output_29);
            }

            bool Apply_32 = true;
            var Output_33 = Input_In;
            if (Apply_32)
            {
                Output_33 = Input_In.SetControl1(Control1_In: Output_31);
            }

            bool Apply_34 = true;
            var Output_35 = Output_33;
            if (Apply_34)
            {
                Output_35 = Output_33.SetControl2(Control2_In: Output_22);
            }

            Output_Out = Output_35;
            return;
        }

        public static void IsSmthHovered<T>(n8.EditableBezierKnot_R<T> Input_In, out bool Result_Out)
        {
            var Output_4 = Input_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_0, Control1_Out: out n8.EditablePoint_R<T> Control1_1, Control2_Out: out n8.EditablePoint_R<T> Control2_2, Mode_Out: out int Mode_3);
            var Output_6 = Point_0.GetHovered(Hovered_Out: out bool Hovered_5);
            var Output_8 = Control1_1.GetHovered(Hovered_Out: out bool Hovered_7);
            var Output_10 = Point_0.GetKeyHovered(Hovered_Out: out bool Hovered_9);
            var Output_12 = Control1_1.GetKeyHovered(Hovered_Out: out bool Hovered_11);
            var Output_14 = Control2_2.GetHovered(Hovered_Out: out bool Hovered_13);
            var Output_16 = Control2_2.GetKeyHovered(Hovered_Out: out bool Hovered_15);
            var Output_17 = Hovered_5 || Hovered_9;
            var Output_18 = Output_17 || Hovered_7;
            var Output_19 = Output_18 || Hovered_11;
            var Output_20 = Output_19 || Hovered_13;
            var Output_21 = Output_20 || Hovered_15;
            Result_Out = Output_21;
            return;
        }

        public static void IsSmthSelected<T>(n8.EditableBezierKnot_R<T> Input_In, out bool Result_Out)
        {
            var Output_4 = Input_In.Split(Point_Out: out n8.EditablePoint_R<T> Point_0, Control1_Out: out n8.EditablePoint_R<T> Control1_1, Control2_Out: out n8.EditablePoint_R<T> Control2_2, Mode_Out: out int Mode_3);
            var Output_6 = Point_0.GetSelected(Selected_Out: out bool Selected_5);
            var Output_8 = Control1_1.GetSelected(Selected_Out: out bool Selected_7);
            var Output_10 = Control2_2.GetSelected(Selected_Out: out bool Selected_9);
            var Output_11 = Selected_5 || Selected_7;
            var Output_12 = Output_11 || Selected_9;
            Result_Out = Output_12;
            return;
        }

        public static void SetFirstKnotCorner<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_GxvfLU8vfX3Nkl2ALwQP5U_1 = __slot_GxvfLU8vfX3Nkl2ALwQP5U;
            int __pad_Acj784rR5XtQEW6Wionlp4_2 = __slot_Acj784rR5XtQEW6Wionlp4;
            var Output_3 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n14._Operations_.SplitFirst<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_3, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_4, Result_Out: out n8.EditableBezierKnot_R<T> Result_5);
            var Output_6 = Result_5;
            if (__pad_GxvfLU8vfX3Nkl2ALwQP5U_1)
            {
                Output_6 = Result_5.SetCornerMode();
            }

            var Output_7 = Output_6;
            if (__pad_GxvfLU8vfX3Nkl2ALwQP5U_1)
            {
                Output_7 = Output_6.HideControls();
            }

            n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_7, Index_In: __pad_Acj784rR5XtQEW6Wionlp4_2, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_8);
            Output_Out = Output_8;
            return;
        }

        public static void SetLastKnotCorner<T, AdM>(n10.Spread<n8.EditableBezierKnot_R<T>> Input_In, out n10.Spread<n8.EditableBezierKnot_R<T>> Output_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool __pad_PhjWZBk6I4MQMx80HBqWfr_1 = __slot_PhjWZBk6I4MQMx80HBqWfr;
            int __pad_MSj5YPXHdg6NM1oMZ5YGbc_2 = __slot_MSj5YPXHdg6NM1oMZ5YGbc;
            var Output_3 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            n14._Operations_.SplitLast<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Default_Value_In: Output_3, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_4, Result_Out: out n8.EditableBezierKnot_R<T> Result_5);
            var Output_6 = Result_5;
            if (__pad_PhjWZBk6I4MQMx80HBqWfr_1)
            {
                Output_6 = Result_5.SetCornerMode();
            }

            var Output_7 = Output_6;
            if (__pad_PhjWZBk6I4MQMx80HBqWfr_1)
            {
                Output_7 = Output_6.HideControls();
            }

            n14._Operations_.SetSlice<n8.EditableBezierKnot_R<T>>(Input_In: Input_In, Value_In: Output_7, Index_In: __pad_MSj5YPXHdg6NM1oMZ5YGbc_2, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<T>> Output_8);
            Output_Out = Output_8;
            return;
        }

        public static void CorrectControlsSelection<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Spread_of_3_Points_In, int Knot_Mode_In, out n8.EditablePoint_R<T> Point_Out, out n8.EditablePoint_R<T> Control1_Out, out n8.EditablePoint_R<T> Control2_Out)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_BUrNKXTBtqbO1z53efC6sS_1 = __slot_BUrNKXTBtqbO1z53efC6sS;
            int __pad_UjRPvGNoFAkLxLsd4lir54_2 = __slot_UjRPvGNoFAkLxLsd4lir54;
            int __pad_IWZh6jT0ZTdMxQniU3VcnY_3 = __slot_IWZh6jT0ZTdMxQniU3VcnY;
            int __pad_DJiDcCPmxnPP48hcGqRlHZ_4 = __slot_DJiDcCPmxnPP48hcGqRlHZ;
            int __pad_L0B1DXJMT7hN9lXch0nARt_5 = __slot_L0B1DXJMT7hN9lXch0nARt;
            var Output_6 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Spread_of_3_Points_In, Default_Value_In: Output_6, Index_In: __pad_BUrNKXTBtqbO1z53efC6sS_1, Result_Out: out n8.EditablePoint_R<T> Result_7);
            var Output_8 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Spread_of_3_Points_In, Default_Value_In: Output_8, Index_In: __pad_UjRPvGNoFAkLxLsd4lir54_2, Result_Out: out n8.EditablePoint_R<T> Result_9);
            var Output_11 = Result_9.GetSelectionModifier(Modifier_Out: out int Modifier_10);
            int Input_2_12 = 0;
            var Result_13 = Modifier_10 > Input_2_12;
            var Output_14 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            n14._Operations_.GetSlice<n8.EditablePoint_R<T>>(Input_In: Spread_of_3_Points_In, Default_Value_In: Output_14, Index_In: __pad_IWZh6jT0ZTdMxQniU3VcnY_3, Result_Out: out n8.EditablePoint_R<T> Result_15);
            var Output_17 = Result_15.GetSelectionModifier(Modifier_Out: out int Modifier_16);
            int Input_2_18 = 0;
            var Result_19 = Modifier_16 > Input_2_18;
            var Output_20 = Result_13 && Result_19;
            var Output_22 = Result_15.GetSelected(Selected_Out: out bool Selected_21);
            var Result_23 = Knot_Mode_In > __pad_DJiDcCPmxnPP48hcGqRlHZ_4;
            var Output_25 = Result_9.GetSelected(Selected_Out: out bool Selected_24);
            var Output_26 = Result_23 && Selected_24;
            var Output_27 = Output_26 && Selected_21;
            var Output_28 = Result_23 && Output_20;
            var Output_29 = Result_7;
            if (Output_27)
            {
                Output_29 = Result_7.Select();
            }

            var Output_30 = Output_29;
            if (Output_28)
            {
                Output_30 = Output_29.SetSelectionModifier(Modifier_In: __pad_L0B1DXJMT7hN9lXch0nARt_5);
            }

            Point_Out = Output_30;
            Control1_Out = Result_9;
            Control2_Out = Result_15;
            return;
        }

        public static void UpdateControls<T, T2>(n8.EditableBezierKnot_R<T> Input_In, n8.EditablePoint_R<T2> New_Point_In, n8.EditablePoint_R<T> New_Control1_In, n8.EditablePoint_R<T> New_Control2_In, out n8.EditableBezierKnot_R<T> Output_Out)
        {
            var Output_1 = Input_In.GetControl1(Control1_Out: out n8.EditablePoint_R<T> Control1_0);
            var Output_3 = Control1_0.GetLocked(Locked_Out: out bool Locked_2);
            bool Apply_4 = true;
            var Output_5 = Locked_2;
            if (Apply_4)
            {
                var Output_6 = !Locked_2;
                Output_5 = Output_6;
            }

            var Output_8 = Input_In.IsCornerWithHandles(Result_Out: out bool Result_7);
            var Output_10 = New_Point_In.GetSelected(Selected_Out: out bool Selected_9);
            bool Apply_11 = true;
            var Output_12 = Selected_9;
            if (Apply_11)
            {
                var Output_13 = !Selected_9;
                Output_12 = Output_13;
            }

            var Output_14 = Output_5 && Result_7;
            var Output_15 = Output_14 && Output_12;
            var Output_17 = Input_In.GetControl2(Control2_Out: out n8.EditablePoint_R<T> Control2_16);
            var Output_19 = Control2_16.GetLocked(Locked_Out: out bool Locked_18);
            bool Apply_20 = true;
            var Output_21 = Locked_18;
            if (Apply_20)
            {
                var Output_22 = !Locked_18;
                Output_21 = Output_22;
            }

            var Output_23 = Output_21 && Result_7;
            var Output_24 = Output_23 && Output_12;
            var Output_25 = Input_In;
            if (Output_15)
            {
                Output_25 = Input_In.SetControl1(Control1_In: New_Control1_In);
            }

            var Output_26 = Output_25;
            if (Output_24)
            {
                Output_26 = Output_25.SetControl2(Control2_In: New_Control2_In);
            }

            Output_Out = Output_26;
            return;
        }

        public static void SerializeEditableBezierKnots<T2, T, AdM>(T2 Input_In, out string Output_Out)
            where T2 : n23.IEnumerable<n8.EditableBezierKnot_R<T>> where AdM : struct, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<n31.SerializablePoint_R<T>>
        {
            n10.Spread<string> __cp_AoQkSgjVOlVPgljtUD9imx = n14._Operations_.CreateDefault<string>();
            var w_0 = default(AdM);
            var builder_16 = n6.CollectionBuilders.GetBuilder(__cp_AoQkSgjVOlVPgljtUD9imx, 16);
            n10.Spread<string> output_17;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Input_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    var Output_9 = splicer_2.Split(Point_Out: out n8.EditablePoint_R<T> Point_5, Control1_Out: out n8.EditablePoint_R<T> Control1_6, Control2_Out: out n8.EditablePoint_R<T> Control2_7, Mode_Out: out int Mode_8);
                    n31._Operations_.ToSerializablePoint<T, AdM>(Input_In: Point_5, Output_Out: out n31.SerializablePoint_R<T> Output_10);
                    var Output_11 = n22.BezierKnot_R<n31.SerializablePoint_R<T>>.CreateDefault<AdM>();
                    n31._Operations_.ToSerializablePoint<T, AdM>(Input_In: Control1_6, Output_Out: out n31.SerializablePoint_R<T> Output_12);
                    n31._Operations_.ToSerializablePoint<T, AdM>(Input_In: Control2_7, Output_Out: out n31.SerializablePoint_R<T> Output_13);
                    var Output_14 = Output_11.Join<AdM>(Point_In: Output_10, Control1_In: Output_12, Control2_In: Output_13, Mode_In: Mode_8);
                    n31._Operations_.ToJsonAndNewLine<n22.BezierKnot_R<n31.SerializablePoint_R<T>>>(Value_In: Output_14, Output_Out: out string Output_15);
                    builder_16.Add(Output_15);
                    i_3++;
                }
            }
            finally
            {
                output_17 = builder_16.Commit();
            }

            n23.IEnumerable<string> Values_18 = (n23.IEnumerable<string>)output_17;
            var Result_19 = string.Concat(values: Values_18);
            Output_Out = Result_19;
            return;
        }

        public static void ParseEditableBezierKnot2d<T>(T Input_In, string Path_In, out n8.EditableBezierKnot_R<n3.Vector2> Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_CfWseylWc9yNBFCURBI1I1_0 = __slot_CfWseylWc9yNBFCURBI1I1;
            string __pad_BFDq3en1uX1NytBAglqLjO_1 = __slot_BFDq3en1uX1NytBAglqLjO;
            string __pad_Vkob1cis1rNOXlEnorzZBy_2 = __slot_Vkob1cis1rNOXlEnorzZBy;
            string __pad_HIrGZqWGWXtMSiTtabq5bv_3 = __slot_HIrGZqWGWXtMSiTtabq5bv;
            var Result_4 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_4, Path_In: __pad_CfWseylWc9yNBFCURBI1I1_0, Value_Out: out int Value_5, Success_Out: out bool Success_6);
            n31._Operations_.ParseEditablePoint2d<n7.XElement>(Input_In: Result_4, Path_In: __pad_BFDq3en1uX1NytBAglqLjO_1, Output_Out: out n8.EditablePoint_R<n3.Vector2> Output_7, Success_Out: out bool Success_8);
            n31._Operations_.ParseEditablePoint2d<n7.XElement>(Input_In: Result_4, Path_In: __pad_Vkob1cis1rNOXlEnorzZBy_2, Output_Out: out n8.EditablePoint_R<n3.Vector2> Output_9, Success_Out: out bool Success_10);
            n31._Operations_.ParseEditablePoint2d<n7.XElement>(Input_In: Result_4, Path_In: __pad_HIrGZqWGWXtMSiTtabq5bv_3, Output_Out: out n8.EditablePoint_R<n3.Vector2> Output_11, Success_Out: out bool Success_12);
            n8.EditableBezierKnot_R<n3.Vector2> Input_13 = n8.EditableBezierKnot_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_14 = Input_13.Join(Point_In: Output_7, Contol1_In: Output_9, Control2_In: Output_11, Mode_In: Value_5);
            var Output_15 = Success_8 && Success_10;
            var Output_16 = Output_15 && Success_12;
            var Output_17 = Output_16 && Success_6;
            Value_Out = Output_14;
            Success_Out = Output_17;
            return;
        }

        public static void ParseBezierKnot2d<T>(T Input_In, string Path_In, out n22.BezierKnot_R<n3.Vector2> Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_RzQiwS5eup9PSbgXCrot4d_0 = __slot_RzQiwS5eup9PSbgXCrot4d;
            string __pad_RV5q6LhASoZPCvmhMQUxVP_1 = __slot_RV5q6LhASoZPCvmhMQUxVP;
            string __pad_KYh2IUGr79UOaYYEw1UNPI_2 = __slot_KYh2IUGr79UOaYYEw1UNPI;
            string __pad_LKZWCJcoQyPLUbth1M6s9Q_3 = __slot_LKZWCJcoQyPLUbth1M6s9Q;
            var Result_4 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_4, Path_In: __pad_RzQiwS5eup9PSbgXCrot4d_0, Value_Out: out int Value_5, Success_Out: out bool Success_6);
            var Result_7 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_RV5q6LhASoZPCvmhMQUxVP_1);
            n31._Operations_.GetVector2D<n7.XElement>(Input_In: Result_7, Value_Out: out n3.Vector2 Value_8, Success_Out: out bool Success_9);
            var Result_10 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_KYh2IUGr79UOaYYEw1UNPI_2);
            n31._Operations_.GetVector2D<n7.XElement>(Input_In: Result_10, Value_Out: out n3.Vector2 Value_11, Success_Out: out bool Success_12);
            var Result_13 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_LKZWCJcoQyPLUbth1M6s9Q_3);
            n31._Operations_.GetVector2D<n7.XElement>(Input_In: Result_13, Value_Out: out n3.Vector2 Value_14, Success_Out: out bool Success_15);
            n22.BezierKnot_R<n3.Vector2> Input_16 = n22.BezierKnot_R<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_17 = Input_16.Join<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Point_In: Value_8, Control1_In: Value_11, Control2_In: Value_14, Mode_In: Value_5);
            var Output_18 = Success_9 && Success_12;
            var Output_19 = Output_18 && Success_15;
            var Output_20 = Output_19 && Success_6;
            Value_Out = Output_17;
            Success_Out = Output_20;
            return;
        }

        public static void ParseBezierKnot3d<T>(T Input_In, string Path_In, out n22.BezierKnot_R<n3.Vector3> Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_DMXTDRjXphVOxIu040FXUw_0 = __slot_DMXTDRjXphVOxIu040FXUw;
            string __pad_CiYm7MYzIhJLb3Y5E6pR2k_1 = __slot_CiYm7MYzIhJLb3Y5E6pR2k;
            string __pad_TvcUKQTFkRQL4URwEXsSMZ_2 = __slot_TvcUKQTFkRQL4URwEXsSMZ;
            string __pad_AWAKyoy4XY5NMf6qxKCvVd_3 = __slot_AWAKyoy4XY5NMf6qxKCvVd;
            var Result_4 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_4, Path_In: __pad_DMXTDRjXphVOxIu040FXUw_0, Value_Out: out int Value_5, Success_Out: out bool Success_6);
            var Result_7 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_CiYm7MYzIhJLb3Y5E6pR2k_1);
            n31._Operations_.GetVector3D<n7.XElement>(Input_In: Result_7, Value_Out: out n3.Vector3 Value_8, Success_Out: out bool Success_9);
            var Result_10 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_TvcUKQTFkRQL4URwEXsSMZ_2);
            n31._Operations_.GetVector3D<n7.XElement>(Input_In: Result_10, Value_Out: out n3.Vector3 Value_11, Success_Out: out bool Success_12);
            var Result_13 = n15.Extensions.XPathSelectElement(node: Result_4, expression: __pad_AWAKyoy4XY5NMf6qxKCvVd_3);
            n31._Operations_.GetVector3D<n7.XElement>(Input_In: Result_13, Value_Out: out n3.Vector3 Value_14, Success_Out: out bool Success_15);
            n22.BezierKnot_R<n3.Vector3> Input_16 = n22.BezierKnot_R<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_17 = Input_16.Join<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Point_In: Value_8, Control1_In: Value_11, Control2_In: Value_14, Mode_In: Value_5);
            var Output_18 = Success_9 && Success_12;
            var Output_19 = Output_18 && Success_15;
            var Output_20 = Output_19 && Success_6;
            Value_Out = Output_17;
            Success_Out = Output_20;
            return;
        }

        public static void ParseEditableBezierKnot3d<T>(T Input_In, string Path_In, out n8.EditableBezierKnot_R<n3.Vector3> Value_Out, out bool Success_Out)
            where T : n7.XNode
        {
            string __pad_KX9tGUvjwE6LDURp6z6Nga_0 = __slot_KX9tGUvjwE6LDURp6z6Nga;
            string __pad_Dabz1JYWy1yNuW9qiOTDMv_1 = __slot_Dabz1JYWy1yNuW9qiOTDMv;
            string __pad_GPgo2K4AvDYNtCPQICR8Z8_2 = __slot_GPgo2K4AvDYNtCPQICR8Z8;
            string __pad_KcN9Ti1dIXpMsoh73jTXfj_3 = __slot_KcN9Ti1dIXpMsoh73jTXfj;
            var Result_4 = n15.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            n59._Operations_.XPathGetValue<n7.XElement, int, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_4, Path_In: __pad_KX9tGUvjwE6LDURp6z6Nga_0, Value_Out: out int Value_5, Success_Out: out bool Success_6);
            n31._Operations_.ParseEditablePoint3d<n7.XElement>(Input_In: Result_4, Path_In: __pad_Dabz1JYWy1yNuW9qiOTDMv_1, Output_Out: out n8.EditablePoint_R<n3.Vector3> Output_7, Success_Out: out bool Success_8);
            n31._Operations_.ParseEditablePoint3d<n7.XElement>(Input_In: Result_4, Path_In: __pad_GPgo2K4AvDYNtCPQICR8Z8_2, Output_Out: out n8.EditablePoint_R<n3.Vector3> Output_9, Success_Out: out bool Success_10);
            n31._Operations_.ParseEditablePoint3d<n7.XElement>(Input_In: Result_4, Path_In: __pad_KcN9Ti1dIXpMsoh73jTXfj_3, Output_Out: out n8.EditablePoint_R<n3.Vector3> Output_11, Success_Out: out bool Success_12);
            n8.EditableBezierKnot_R<n3.Vector3> Input_13 = n8.EditableBezierKnot_R<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_14 = Input_13.Join(Point_In: Output_7, Contol1_In: Output_9, Control2_In: Output_11, Mode_In: Value_5);
            var Output_15 = Success_8 && Success_10;
            var Output_16 = Output_15 && Success_12;
            var Output_17 = Output_16 && Success_6;
            Value_Out = Output_14;
            Success_Out = Output_17;
            return;
        }

        public static void NewBezierKnotOnSegment<T, AdM>(n24.BezierSegment_R<T> Bezier_In, float Scalar_In, int Next_Id_In, out T Control2PreviousBezierKnot_Out, out n8.EditableBezierKnot_R<T> EditableBezierKnot_Out, out T Control1NextBezierKnot_Out, out int Next_Id_Out)
            where AdM : struct, n21.IAdaptiveLerp<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            int __pad_LYNlkoKXlmRPy80VLPEy1R_1 = __slot_LYNlkoKXlmRPy80VLPEy1R;
            int __pad_EuvhxocgkmDPUioLVtJD5l_2 = __slot_EuvhxocgkmDPUioLVtJD5l;
            int __pad_PRjvtz6HDKFP1g7e3PtfnZ_3 = __slot_PRjvtz6HDKFP1g7e3PtfnZ;
            int __pad_R9CEGtmcrRbO0kxwZIoE42_4 = __slot_R9CEGtmcrRbO0kxwZIoE42;
            n25._Operations_.Slice<T, AdM>(Input_In: Bezier_In, Scalar_In: Scalar_In, Output_Out: out n10.Spread<n24.BezierSegment_R<T>> Output_5);
            var Output_6 = n24.BezierSegment_R<T>.CreateDefault<AdM>();
            n12._Operations_.LastOrDefault<n10.Spread<n24.BezierSegment_R<T>>, n24.BezierSegment_R<T>>(Input_In: Output_5, Default_Value_In: Output_6, Output_Out: out n10.Spread<n24.BezierSegment_R<T>> Output_7, Result_Out: out n24.BezierSegment_R<T> Result_8);
            var Output_13 = Result_8.Split(Control_1_Out: out T Control_1_9, Control_2_Out: out T Control_2_10, Control_3_Out: out T Control_3_11, Control_4_Out: out T Control_4_12);
            bool Apply_14 = true;
            var Output_15 = Next_Id_In;
            if (Apply_14)
            {
                var Output_16 = Next_Id_In + __pad_EuvhxocgkmDPUioLVtJD5l_2;
                Output_15 = Output_16;
            }

            bool Apply_17 = true;
            var Output_18 = Output_15;
            if (Apply_17)
            {
                var Output_19 = Output_15 + __pad_PRjvtz6HDKFP1g7e3PtfnZ_3;
                Output_18 = Output_19;
            }

            n1.NodeContext Node_Context_20 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "V0lzDNC3SD6PzWpyOWhzFo", 80579U);
            var Output_21 = n8.EditablePoint_R<T>.Create<AdM>(Node_Context: Node_Context_20, Position_In: Control_2_10, Id_In: Output_18);
            var Output_22 = n24.BezierSegment_R<T>.CreateDefault<AdM>();
            n12._Operations_.FirstOrDefault<n10.Spread<n24.BezierSegment_R<T>>, n24.BezierSegment_R<T>>(Input_In: Output_5, Default_Value_In: Output_22, Output_Out: out n10.Spread<n24.BezierSegment_R<T>> Output_23, Result_Out: out n24.BezierSegment_R<T> Result_24);
            var Output_29 = Result_24.Split(Control_1_Out: out T Control_1_25, Control_2_Out: out T Control_2_26, Control_3_Out: out T Control_3_27, Control_4_Out: out T Control_4_28);
            n1.NodeContext Node_Context_30 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "JxhhUwqbS4gNn9VEVZH3Qh", 80553U);
            var Output_31 = n8.EditablePoint_R<T>.Create<AdM>(Node_Context: Node_Context_30, Position_In: Control_4_28, Id_In: Next_Id_In);
            n1.NodeContext Node_Context_32 = n1.NodeContext.Default.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "VOfPvoZ4pfOM0raxvngMbm", 80563U);
            var Output_33 = n8.EditablePoint_R<T>.Create<AdM>(Node_Context: Node_Context_32, Position_In: Control_3_27, Id_In: Output_15);
            var Output_34 = n8.EditableBezierKnot_R<T>.CreateDefault<AdM>();
            bool Apply_35 = true;
            var Output_36 = Output_31;
            if (Apply_35)
            {
                Output_36 = Output_31.Select();
            }

            bool Apply_37 = true;
            var Output_38 = Output_34;
            if (Apply_37)
            {
                Output_38 = Output_34.Join(Point_In: Output_36, Contol1_In: Output_33, Control2_In: Output_21, Mode_In: __pad_LYNlkoKXlmRPy80VLPEy1R_1);
            }

            bool Apply_39 = true;
            var Output_40 = Output_18;
            if (Apply_39)
            {
                var Output_41 = Output_18 + __pad_R9CEGtmcrRbO0kxwZIoE42_4;
                Output_40 = Output_41;
            }

            Control2PreviousBezierKnot_Out = Control_2_26;
            EditableBezierKnot_Out = Output_38;
            Control1NextBezierKnot_Out = Control_3_11;
            Next_Id_Out = Output_40;
            return;
        }

        [n1.ElementAttribute(TracingId = 72219U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IwoRE8hohk3NB2k5fts0XU", Name = "__slot_IwoRE8hohk3NB2k5fts0XU")]
        public static int __slot_IwoRE8hohk3NB2k5fts0XU = 1;
        [n1.ElementAttribute(TracingId = 72217U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PplK4kwyg1GOl4VqR7gbfE", Name = "__slot_PplK4kwyg1GOl4VqR7gbfE")]
        public static int __slot_PplK4kwyg1GOl4VqR7gbfE = 1;
        [n1.ElementAttribute(TracingId = 73613U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GzWbqtOTaA0QPajt7u1NHm", Name = "__slot_GzWbqtOTaA0QPajt7u1NHm")]
        public static float __slot_GzWbqtOTaA0QPajt7u1NHm = 2F;
        [n1.ElementAttribute(TracingId = 73882U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "N5cxYCkk9gsL8WVu6GKTXr", Name = "__slot_N5cxYCkk9gsL8WVu6GKTXr")]
        public static int __slot_N5cxYCkk9gsL8WVu6GKTXr = 1;
        [n1.ElementAttribute(TracingId = 75240U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RDr3yoclCXXP304y0W9xCE", Name = "__slot_RDr3yoclCXXP304y0W9xCE")]
        public static int __slot_RDr3yoclCXXP304y0W9xCE = -1;
        [n1.ElementAttribute(TracingId = 75452U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SqY6zOBDa9nPhPL7Twzxbw", Name = "__slot_SqY6zOBDa9nPhPL7Twzxbw")]
        public static bool __slot_SqY6zOBDa9nPhPL7Twzxbw = false;
        [n1.ElementAttribute(TracingId = 76007U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AP0p7ii7dnaM44CByrTyt4", Name = "__slot_AP0p7ii7dnaM44CByrTyt4")]
        public static bool __slot_AP0p7ii7dnaM44CByrTyt4 = true;
        [n1.ElementAttribute(TracingId = 76082U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TjpW06vz3NtQXLUwdwKYph", Name = "__slot_TjpW06vz3NtQXLUwdwKYph")]
        public static bool __slot_TjpW06vz3NtQXLUwdwKYph = false;
        [n1.ElementAttribute(TracingId = 76101U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PBOZNDwdC9DPk8yWmHmKAW", Name = "__slot_PBOZNDwdC9DPk8yWmHmKAW")]
        public static bool __slot_PBOZNDwdC9DPk8yWmHmKAW = true;
        [n1.ElementAttribute(TracingId = 76255U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "U3BSe3MdqM7M0AdLk7MN7r", Name = "__slot_U3BSe3MdqM7M0AdLk7MN7r")]
        public static bool __slot_U3BSe3MdqM7M0AdLk7MN7r = true;
        [n1.ElementAttribute(TracingId = 76253U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BXWeBz1jz7bPNRT7S8Py8G", Name = "__slot_BXWeBz1jz7bPNRT7S8Py8G")]
        public static int __slot_BXWeBz1jz7bPNRT7S8Py8G = 0;
        [n1.ElementAttribute(TracingId = 76295U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FrqHYmAIBTwLvUYqwF8dPQ", Name = "__slot_FrqHYmAIBTwLvUYqwF8dPQ")]
        public static float __slot_FrqHYmAIBTwLvUYqwF8dPQ = 1F;
        [n1.ElementAttribute(TracingId = 76294U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KxIWfM8a1iCPvHUmJamXO5", Name = "__slot_KxIWfM8a1iCPvHUmJamXO5")]
        public static float __slot_KxIWfM8a1iCPvHUmJamXO5 = 2F;
        [n1.ElementAttribute(TracingId = 76676U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GCrwDfJi4pYMewHyYEQKpz", Name = "__slot_GCrwDfJi4pYMewHyYEQKpz")]
        public static int __slot_GCrwDfJi4pYMewHyYEQKpz = 1;
        [n1.ElementAttribute(TracingId = 76677U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VXTeJ6RlDFcOAE8kFBrbDq", Name = "__slot_VXTeJ6RlDFcOAE8kFBrbDq")]
        public static int __slot_VXTeJ6RlDFcOAE8kFBrbDq = 1;
        [n1.ElementAttribute(TracingId = 76678U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "V4HxgiSV1f3PbN5ftcrPss", Name = "__slot_V4HxgiSV1f3PbN5ftcrPss")]
        public static int __slot_V4HxgiSV1f3PbN5ftcrPss = 1;
        [n1.ElementAttribute(TracingId = 76843U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CVQeuTv6DUoMwGuYXI2uv9", Name = "__slot_CVQeuTv6DUoMwGuYXI2uv9")]
        public static int __slot_CVQeuTv6DUoMwGuYXI2uv9 = 1;
        [n1.ElementAttribute(TracingId = 76842U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AdEJxSzWggOO9GDkuzJn99", Name = "__slot_AdEJxSzWggOO9GDkuzJn99")]
        public static int __slot_AdEJxSzWggOO9GDkuzJn99 = 0;
        [n1.ElementAttribute(TracingId = 76958U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UDjdgBIBsLRLsuQ9tTEzxK", Name = "__slot_UDjdgBIBsLRLsuQ9tTEzxK")]
        public static int __slot_UDjdgBIBsLRLsuQ9tTEzxK = -1;
        [n1.ElementAttribute(TracingId = 76959U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QYqVABxbcZtPtsbFAAe5yF", Name = "__slot_QYqVABxbcZtPtsbFAAe5yF")]
        public static int __slot_QYqVABxbcZtPtsbFAAe5yF = 1;
        [n1.ElementAttribute(TracingId = 77000U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GuZ6g4mQqPdNIVugaeHMoU", Name = "__slot_GuZ6g4mQqPdNIVugaeHMoU")]
        public static int __slot_GuZ6g4mQqPdNIVugaeHMoU = -1;
        [n1.ElementAttribute(TracingId = 77030U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IyOXfLAgl5LOj8b2sITkTN", Name = "__slot_IyOXfLAgl5LOj8b2sITkTN")]
        public static int __slot_IyOXfLAgl5LOj8b2sITkTN = 0;
        [n1.ElementAttribute(TracingId = 77087U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EYOXVNGkYrkO4K7Y6F8xbL", Name = "__slot_EYOXVNGkYrkO4K7Y6F8xbL")]
        public static int __slot_EYOXVNGkYrkO4K7Y6F8xbL = 2;
        [n1.ElementAttribute(TracingId = 77112U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MrCwi6RZn6ROI6LLeN6wch", Name = "__slot_MrCwi6RZn6ROI6LLeN6wch")]
        public static int __slot_MrCwi6RZn6ROI6LLeN6wch = 1;
        [n1.ElementAttribute(TracingId = 77134U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Q5aTgijK1WBMQCmEzgAbZi", Name = "__slot_Q5aTgijK1WBMQCmEzgAbZi")]
        public static int __slot_Q5aTgijK1WBMQCmEzgAbZi = 1;
        [n1.ElementAttribute(TracingId = 77139U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UQU06UbYCaKL9uFNF8kdAZ", Name = "__slot_UQU06UbYCaKL9uFNF8kdAZ")]
        public static int __slot_UQU06UbYCaKL9uFNF8kdAZ = 1;
        [n1.ElementAttribute(TracingId = 77256U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UUtZzmxrbXPPIGeeyQKzcv", Name = "__slot_UUtZzmxrbXPPIGeeyQKzcv")]
        public static bool __slot_UUtZzmxrbXPPIGeeyQKzcv = true;
        [n1.ElementAttribute(TracingId = 78996U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BzoXVyHP8swOR1PwpjhYYN", Name = "__slot_BzoXVyHP8swOR1PwpjhYYN")]
        public static int __slot_BzoXVyHP8swOR1PwpjhYYN = 3;
        [n1.ElementAttribute(TracingId = 79785U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GxvfLU8vfX3Nkl2ALwQP5U", Name = "__slot_GxvfLU8vfX3Nkl2ALwQP5U")]
        public static bool __slot_GxvfLU8vfX3Nkl2ALwQP5U = true;
        [n1.ElementAttribute(TracingId = 79778U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Acj784rR5XtQEW6Wionlp4", Name = "__slot_Acj784rR5XtQEW6Wionlp4")]
        public static int __slot_Acj784rR5XtQEW6Wionlp4 = 0;
        [n1.ElementAttribute(TracingId = 79822U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PhjWZBk6I4MQMx80HBqWfr", Name = "__slot_PhjWZBk6I4MQMx80HBqWfr")]
        public static bool __slot_PhjWZBk6I4MQMx80HBqWfr = true;
        [n1.ElementAttribute(TracingId = 79815U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MSj5YPXHdg6NM1oMZ5YGbc", Name = "__slot_MSj5YPXHdg6NM1oMZ5YGbc")]
        public static int __slot_MSj5YPXHdg6NM1oMZ5YGbc = -1;
        [n1.ElementAttribute(TracingId = 79834U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BUrNKXTBtqbO1z53efC6sS", Name = "__slot_BUrNKXTBtqbO1z53efC6sS")]
        public static int __slot_BUrNKXTBtqbO1z53efC6sS = 0;
        [n1.ElementAttribute(TracingId = 79835U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UjRPvGNoFAkLxLsd4lir54", Name = "__slot_UjRPvGNoFAkLxLsd4lir54")]
        public static int __slot_UjRPvGNoFAkLxLsd4lir54 = 1;
        [n1.ElementAttribute(TracingId = 79836U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IWZh6jT0ZTdMxQniU3VcnY", Name = "__slot_IWZh6jT0ZTdMxQniU3VcnY")]
        public static int __slot_IWZh6jT0ZTdMxQniU3VcnY = 2;
        [n1.ElementAttribute(TracingId = 79862U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DJiDcCPmxnPP48hcGqRlHZ", Name = "__slot_DJiDcCPmxnPP48hcGqRlHZ")]
        public static int __slot_DJiDcCPmxnPP48hcGqRlHZ = 1;
        [n1.ElementAttribute(TracingId = 79885U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "L0B1DXJMT7hN9lXch0nARt", Name = "__slot_L0B1DXJMT7hN9lXch0nARt")]
        public static int __slot_L0B1DXJMT7hN9lXch0nARt = 1;
        [n1.ElementAttribute(TracingId = 80109U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CfWseylWc9yNBFCURBI1I1", Name = "__slot_CfWseylWc9yNBFCURBI1I1")]
        public static string __slot_CfWseylWc9yNBFCURBI1I1 = "Mode";
        [n1.ElementAttribute(TracingId = 80122U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BFDq3en1uX1NytBAglqLjO", Name = "__slot_BFDq3en1uX1NytBAglqLjO")]
        public static string __slot_BFDq3en1uX1NytBAglqLjO = "Point";
        [n1.ElementAttribute(TracingId = 80130U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Vkob1cis1rNOXlEnorzZBy", Name = "__slot_Vkob1cis1rNOXlEnorzZBy")]
        public static string __slot_Vkob1cis1rNOXlEnorzZBy = "Control1";
        [n1.ElementAttribute(TracingId = 80138U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HIrGZqWGWXtMSiTtabq5bv", Name = "__slot_HIrGZqWGWXtMSiTtabq5bv")]
        public static string __slot_HIrGZqWGWXtMSiTtabq5bv = "Control2";
        [n1.ElementAttribute(TracingId = 80184U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RzQiwS5eup9PSbgXCrot4d", Name = "__slot_RzQiwS5eup9PSbgXCrot4d")]
        public static string __slot_RzQiwS5eup9PSbgXCrot4d = "Mode";
        [n1.ElementAttribute(TracingId = 80195U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RV5q6LhASoZPCvmhMQUxVP", Name = "__slot_RV5q6LhASoZPCvmhMQUxVP")]
        public static string __slot_RV5q6LhASoZPCvmhMQUxVP = "Point/Position";
        [n1.ElementAttribute(TracingId = 80230U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KYh2IUGr79UOaYYEw1UNPI", Name = "__slot_KYh2IUGr79UOaYYEw1UNPI")]
        public static string __slot_KYh2IUGr79UOaYYEw1UNPI = "Control1/Position";
        [n1.ElementAttribute(TracingId = 80196U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LKZWCJcoQyPLUbth1M6s9Q", Name = "__slot_LKZWCJcoQyPLUbth1M6s9Q")]
        public static string __slot_LKZWCJcoQyPLUbth1M6s9Q = "Control2/Position";
        [n1.ElementAttribute(TracingId = 80288U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DMXTDRjXphVOxIu040FXUw", Name = "__slot_DMXTDRjXphVOxIu040FXUw")]
        public static string __slot_DMXTDRjXphVOxIu040FXUw = "Mode";
        [n1.ElementAttribute(TracingId = 80305U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CiYm7MYzIhJLb3Y5E6pR2k", Name = "__slot_CiYm7MYzIhJLb3Y5E6pR2k")]
        public static string __slot_CiYm7MYzIhJLb3Y5E6pR2k = "Point/Position";
        [n1.ElementAttribute(TracingId = 80369U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TvcUKQTFkRQL4URwEXsSMZ", Name = "__slot_TvcUKQTFkRQL4URwEXsSMZ")]
        public static string __slot_TvcUKQTFkRQL4URwEXsSMZ = "Control1/Position";
        [n1.ElementAttribute(TracingId = 80308U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AWAKyoy4XY5NMf6qxKCvVd", Name = "__slot_AWAKyoy4XY5NMf6qxKCvVd")]
        public static string __slot_AWAKyoy4XY5NMf6qxKCvVd = "Control2/Position";
        [n1.ElementAttribute(TracingId = 80462U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KX9tGUvjwE6LDURp6z6Nga", Name = "__slot_KX9tGUvjwE6LDURp6z6Nga")]
        public static string __slot_KX9tGUvjwE6LDURp6z6Nga = "Mode";
        [n1.ElementAttribute(TracingId = 80475U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Dabz1JYWy1yNuW9qiOTDMv", Name = "__slot_Dabz1JYWy1yNuW9qiOTDMv")]
        public static string __slot_Dabz1JYWy1yNuW9qiOTDMv = "Point";
        [n1.ElementAttribute(TracingId = 80483U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GPgo2K4AvDYNtCPQICR8Z8", Name = "__slot_GPgo2K4AvDYNtCPQICR8Z8")]
        public static string __slot_GPgo2K4AvDYNtCPQICR8Z8 = "Control1";
        [n1.ElementAttribute(TracingId = 80491U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KcN9Ti1dIXpMsoh73jTXfj", Name = "__slot_KcN9Ti1dIXpMsoh73jTXfj")]
        public static string __slot_KcN9Ti1dIXpMsoh73jTXfj = "Control2";
        [n1.ElementAttribute(TracingId = 80532U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LYNlkoKXlmRPy80VLPEy1R", Name = "__slot_LYNlkoKXlmRPy80VLPEy1R")]
        public static int __slot_LYNlkoKXlmRPy80VLPEy1R = 2;
        [n1.ElementAttribute(TracingId = 80529U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EuvhxocgkmDPUioLVtJD5l", Name = "__slot_EuvhxocgkmDPUioLVtJD5l")]
        public static int __slot_EuvhxocgkmDPUioLVtJD5l = 1;
        [n1.ElementAttribute(TracingId = 80530U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PRjvtz6HDKFP1g7e3PtfnZ", Name = "__slot_PRjvtz6HDKFP1g7e3PtfnZ")]
        public static int __slot_PRjvtz6HDKFP1g7e3PtfnZ = 1;
        [n1.ElementAttribute(TracingId = 80531U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "R9CEGtmcrRbO0kxwZIoE42", Name = "__slot_R9CEGtmcrRbO0kxwZIoE42")]
        public static int __slot_R9CEGtmcrRbO0kxwZIoE42 = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Editors_.Editors._2D
{
    [n1.ElementAttribute(TracingId = 80640U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UkkghEPMxJHMCG7AYvyYTz", Name = "PointEditor_UkkghEPMxJHMCG7AYvyYTz")]
    [n2.SerializableAttribute]
    public class PointEditor_UkkghEPMxJHMCG7AYvyYTz : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz Create(n1.NodeContext Node_Context)
        {
            var instance = new PointEditor_UkkghEPMxJHMCG7AYvyYTz(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz CreateDefault()
        {
            var instance = new PointEditor_UkkghEPMxJHMCG7AYvyYTz(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz Update(n23.IEnumerable<n3.Vector2> Points_To_Add_In, bool Add_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Clear_In, n23.IEnumerable<bool> Locked_In, n8.PointEditorControlsData_R PointEditorControls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, n3.Matrix View_In, [n6.SerializedDefaultValueAttribute("1", false)] float Camera_Zoom_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, float Gizmo_Size_In, n17.Path File_Path_In, bool Load_In, bool Save_In, out n8.PointEditorState_R<n3.Vector2, float, bool, bool, bool, bool, n3.Vector2> PointEditor_State_Out, out n10.Spread<n3.Vector2> Points_Out, out n10.Spread<int> Ids_Out, out bool Idle_Out)
        {
            int __auto_0 = this.Current_Id;
            int __pad_QzXy1Mur7tsLMV51KWPSh5_1 = __slot_QzXy1Mur7tsLMV51KWPSh5;
            n10.Spread<n8.EditablePoint_R<n3.Vector2>> __auto_2 = this.Points;
            var Output_5 = this.__p_IVtJiQzLGR1OkLGly8LKbQ.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(File_Path_In: File_Path_In, Read_In: Load_In, Result_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Result_3, On_Data_Out: out bool On_Data_4);
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>(Condition_In: On_Data_4, Input_In: __auto_2, Input_2_In: Result_3, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Output_6);
            var Output_22 = PointEditorControls_In.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_7, Mouse_Pressed_Out: out bool Mouse_Pressed_8, Selection_Out: out n3.RectangleF Selection_9, Remove_Selected_Out: out bool Remove_Selected_10, Control_Out: out bool Control_11, Shift_Out: out bool Shift_12, Space_Out: out bool Space_13, Hover_Next_Out: out bool Hover_Next_14, Hover_Previous_Out: out bool Hover_Previous_15, Select_All_Out: out bool Select_All_16, Scale_Out: out bool Scale_17, Rotate_Out: out bool Rotate_18, Translate_Out: out bool Translate_19, Undo_Out: out bool Undo_20, Redo_Out: out bool Redo_21);
            var Output_25 = this.__p_HWM3tkYWu73Mgc3CVcDi7i.Update(Value_In: Mouse_Pressed_8, Up_Edge_Out: out bool Up_Edge_23, Down_Edge_Out: out bool Down_Edge_24);
            n31._Operations_.HoverWithKeys<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_6, Hover_Next_In: Hover_Next_14, Hover_Previous_In: Hover_Previous_15, Mouse_Pressed_In: Up_Edge_23, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Output_26);
            n31._Operations_.SetLockState<n3.Vector2, n23.IEnumerable<bool>>(Spread_In: Output_26, Lockeds_In: Locked_In, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Outputs_27);
            var Output_38 = this.__p_IeIuFNwnTz0Lti78eM9IZ8.Update(Points_In: Outputs_27, PointEditor_Controls_In: PointEditorControls_In, View_In: View_In, Pick_Size_In: Pick_Size_In, Step_Size_In: Step_Size_In, Gizmo_Size_In: Gizmo_Size_In, Camera_Zoom_In: Camera_Zoom_In, Camera_Idle_In: Camera_Idle_In, Gizmo_Controls_In: Gizmo_Controls_In, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points_28, Result_Out: out n10.Spread<n3.Vector2> Result_29, Editing_Out: out bool Editing_30, Selection_Changed_Out: out bool Selection_Changed_31, Selection_Updated_Out: out bool Selection_Updated_32, Translate_Out: out bool Translate_33, Rotate_Out: out bool Rotate_34, Scale_Out: out bool Scale_35, Offset_Out: out n3.Vector2 Offset_36, GizmoState_Out: out n34.GizmoState_R GizmoState_37);
            n31._Operations_.AddRemovePoints<n3.Vector2, n23.IEnumerable<n3.Vector2>, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Current_Id_In: __auto_0, Points_In: Points_28, Points_To_Add_In: Points_To_Add_In, Add_In: Add_In, Clear_In: Clear_In, Remove_Selected_In: Remove_Selected_10, Current_Id_Out: out int Current_Id_39, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points_40);
            var Identity_41 = n3.Matrix.Identity;
            var Result_42 = View_In == Identity_41;
            var Output_45 = this.__p_AID5mI8Sq3kOiEq8VqngOL.Update(Value_In: Editing_30, Up_Edge_Out: out bool Up_Edge_43, Down_Edge_Out: out bool Down_Edge_44);
            var Output_46 = Add_In || Down_Edge_44;
            var Output_50 = this.__p_JqRVtYVl9WTMVjinhRwqSP.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Clear_In: Clear_In, Item_In: Points_40, Levels_In: __pad_QzXy1Mur7tsLMV51KWPSh5_1, Push_In: Output_46, Undo_In: Undo_20, Redo_In: Redo_21, Result_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Result_47, Count_Out: out int Count_48, Pointer_Out: out int Pointer_49);
            n23.IEnumerable<n8.EditablePoint_R<n3.Vector2>> EditablePoints_51 = (n23.IEnumerable<n8.EditablePoint_R<n3.Vector2>>)Result_47;
            n8.PointEditorState_R<n3.Vector2, float, bool, bool, bool, bool, n3.Vector2> Input_52 = n8.PointEditorState_R<n3.Vector2, float, bool, bool, bool, bool, n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_53 = Input_52.Join(EditablePoints_In: EditablePoints_51, Pick_Size_In: Pick_Size_In, Editing_In: Editing_30, Scaling_In: Scale_35, Rotation_In: Rotate_34, Translation_In: Translate_33, Offset_In: Offset_36, Is_Projection_Space_In: Result_42, GizmoState_In: GizmoState_37);
            bool Update_54 = true;
            var Output_55 = this.__p_E09YwUPqhfmNe4gFuGH7Bg;
            if (Update_54)
            {
                Output_55 = this.__p_E09YwUPqhfmNe4gFuGH7Bg.Update<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>(Data_In: Result_47, File_Path_In: File_Path_In, Write_In: Save_In);
            }

            var Output_56 = Editing_30 || Undo_20;
            var Output_57 = Output_56 || Redo_21;
            var Output_58 = !Output_57;
            int __pad_Base2Qk1oCTMZEGIfzzyaw_59 = Count_48;
            int __pad_DGcUSqsCt4XPkRSET9dglW_60 = Pointer_49;
            n10.Spread<n8.EditablePoint_R<n3.Vector2>> __auto_61 = Result_47;
            var builder_75 = n6.CollectionBuilders.GetBuilder(this.__cp_Ueq6mBFnA46L864YDBctAL, 16);
            n10.Spread<n3.Vector2> output_76;
            var builder_77 = n6.CollectionBuilders.GetBuilder(this.__cp_RFSlHhQRiVOMkkgEncGZ81, 16);
            n10.Spread<int> output_78;
            try
            {
                var i_64 = 0;
                foreach (var item_62 in n6.CollectionExtensions.AsSpan(Result_47))
                {
                    var splicer_63 = item_62;
                    var i_local_65 = i_64;
                    var Output_74 = splicer_63.Split(Position_Out: out n3.Vector2 Position_67, Locked_Out: out bool Locked_68, Selected_Out: out bool Selected_69, Hovered_Out: out bool Hovered_70, KeyHovered_Out: out bool KeyHovered_71, SelectionModifier_Out: out int SelectionModifier_72, Id_Out: out int Id_73);
                    builder_75.Add(Position_67);
                    builder_77.Add(Id_73);
                    i_64++;
                }
            }
            finally
            {
                output_76 = builder_75.Commit();
                output_78 = builder_77.Commit();
            }

            int __auto_79 = Current_Id_39;
            PointEditor_State_Out = Output_53;
            Points_Out = output_76;
            Ids_Out = output_78;
            Idle_Out = Output_58;
            n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz that_80 = this;
            if (this.__GetContext__().IsImmutable)
                that_80 = Output_5 != this.__p_IVtJiQzLGR1OkLGly8LKbQ || Output_25 != this.__p_HWM3tkYWu73Mgc3CVcDi7i || Output_38 != this.__p_IeIuFNwnTz0Lti78eM9IZ8 || Output_45 != this.__p_AID5mI8Sq3kOiEq8VqngOL || Output_50 != this.__p_JqRVtYVl9WTMVjinhRwqSP || Output_55 != this.__p_E09YwUPqhfmNe4gFuGH7Bg || Count_48 != this.__slot_Base2Qk1oCTMZEGIfzzyaw || Pointer_49 != this.__slot_DGcUSqsCt4XPkRSET9dglW || Result_47 != this.Points || output_76 != this.__cp_Ueq6mBFnA46L864YDBctAL || output_78 != this.__cp_RFSlHhQRiVOMkkgEncGZ81 || Current_Id_39 != this.Current_Id ? new PointEditor_UkkghEPMxJHMCG7AYvyYTz(this)
                {__p_IVtJiQzLGR1OkLGly8LKbQ = Output_5, __p_HWM3tkYWu73Mgc3CVcDi7i = Output_25, __p_IeIuFNwnTz0Lti78eM9IZ8 = Output_38, __p_AID5mI8Sq3kOiEq8VqngOL = Output_45, __p_JqRVtYVl9WTMVjinhRwqSP = Output_50, __p_E09YwUPqhfmNe4gFuGH7Bg = Output_55, __slot_Base2Qk1oCTMZEGIfzzyaw = Count_48, __slot_DGcUSqsCt4XPkRSET9dglW = Pointer_49, Points = Result_47, __cp_Ueq6mBFnA46L864YDBctAL = output_76, __cp_RFSlHhQRiVOMkkgEncGZ81 = output_78, Current_Id = Current_Id_39} : that_80;
            else
            {
                this.__p_IVtJiQzLGR1OkLGly8LKbQ = Output_5;
                this.__p_HWM3tkYWu73Mgc3CVcDi7i = Output_25;
                this.__p_IeIuFNwnTz0Lti78eM9IZ8 = Output_38;
                this.__p_AID5mI8Sq3kOiEq8VqngOL = Output_45;
                this.__p_JqRVtYVl9WTMVjinhRwqSP = Output_50;
                this.__p_E09YwUPqhfmNe4gFuGH7Bg = Output_55;
                this.__slot_Base2Qk1oCTMZEGIfzzyaw = Count_48;
                this.__slot_DGcUSqsCt4XPkRSET9dglW = Pointer_49;
                this.Points = Result_47;
                this.__cp_Ueq6mBFnA46L864YDBctAL = output_76;
                this.__cp_RFSlHhQRiVOMkkgEncGZ81 = output_78;
                this.Current_Id = Current_Id_39;
            }

            return that_80;
        }

        public n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IeIuFNwnTz0Lti78eM9IZ8", 80690U);
            var Output_1 = n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "AID5mI8Sq3kOiEq8VqngOL", 80710U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "JqRVtYVl9WTMVjinhRwqSP", 80717U);
            var Output_5 = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "HWM3tkYWu73Mgc3CVcDi7i", 80812U);
            var Output_7 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IVtJiQzLGR1OkLGly8LKbQ", 80817U);
            var Output_9 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "E09YwUPqhfmNe4gFuGH7Bg", 80822U);
            var Output_11 = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.Create(Node_Context: Node_Context_10);
            n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz that_12 = this;
            this.Points = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector2>>();
            this.Current_Id = 0;
            this.__slot_Base2Qk1oCTMZEGIfzzyaw = 0;
            this.__slot_DGcUSqsCt4XPkRSET9dglW = 0;
            this.__cp_Ueq6mBFnA46L864YDBctAL = n14._Operations_.CreateDefault<n3.Vector2>();
            this.__cp_RFSlHhQRiVOMkkgEncGZ81 = n14._Operations_.CreateDefault<int>();
            this.__p_IeIuFNwnTz0Lti78eM9IZ8 = Output_1;
            this.__p_AID5mI8Sq3kOiEq8VqngOL = Output_3;
            this.__p_JqRVtYVl9WTMVjinhRwqSP = Output_5;
            this.__p_HWM3tkYWu73Mgc3CVcDi7i = Output_7;
            this.__p_IVtJiQzLGR1OkLGly8LKbQ = Output_9;
            this.__p_E09YwUPqhfmNe4gFuGH7Bg = Output_11;
            return that_12;
        }

        public n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz __CreateDefault__()
        {
            n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz that_0 = this;
            this.Points = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector2>>();
            this.Current_Id = 0;
            this.__slot_Base2Qk1oCTMZEGIfzzyaw = 0;
            this.__slot_DGcUSqsCt4XPkRSET9dglW = 0;
            this.__cp_Ueq6mBFnA46L864YDBctAL = n14._Operations_.CreateDefault<n3.Vector2>();
            this.__cp_RFSlHhQRiVOMkkgEncGZ81 = n14._Operations_.CreateDefault<int>();
            this.__p_IVtJiQzLGR1OkLGly8LKbQ = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_HWM3tkYWu73Mgc3CVcDi7i = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_IeIuFNwnTz0Lti78eM9IZ8 = n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.CreateDefault();
            this.__p_AID5mI8Sq3kOiEq8VqngOL = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_JqRVtYVl9WTMVjinhRwqSP = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.CreateDefault();
            this.__p_E09YwUPqhfmNe4gFuGH7Bg = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IVtJiQzLGR1OkLGly8LKbQ);
            n1.CompilationHelper.SafeDispose(this.__p_HWM3tkYWu73Mgc3CVcDi7i);
            n1.CompilationHelper.SafeDispose(this.__p_IeIuFNwnTz0Lti78eM9IZ8);
            n1.CompilationHelper.SafeDispose(this.__p_AID5mI8Sq3kOiEq8VqngOL);
            n1.CompilationHelper.SafeDispose(this.__p_JqRVtYVl9WTMVjinhRwqSP);
            n1.CompilationHelper.SafeDispose(this.__p_E09YwUPqhfmNe4gFuGH7Bg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 80642U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EhdfUpn9JdyOcKYEs9XVd7", Name = "Points")]
        public n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points;
        [n1.ElementAttribute(TracingId = 80643U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TodD1iyO5uOLhaXJEe9iG1", Name = "Current Id")]
        public int Current_Id;
        [n1.ElementAttribute(TracingId = 80677U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QzXy1Mur7tsLMV51KWPSh5", Name = "__slot_QzXy1Mur7tsLMV51KWPSh5")]
        public static int __slot_QzXy1Mur7tsLMV51KWPSh5 = 50;
        [n1.ElementAttribute(TracingId = 80729U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Base2Qk1oCTMZEGIfzzyaw", Name = "__slot_Base2Qk1oCTMZEGIfzzyaw")]
        public int __slot_Base2Qk1oCTMZEGIfzzyaw;
        [n1.ElementAttribute(TracingId = 80730U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DGcUSqsCt4XPkRSET9dglW", Name = "__slot_DGcUSqsCt4XPkRSET9dglW")]
        public int __slot_DGcUSqsCt4XPkRSET9dglW;
        [n1.ElementAttribute(TracingId = 80817U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IVtJiQzLGR1OkLGly8LKbQ", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_IVtJiQzLGR1OkLGly8LKbQ;
        [n1.ElementAttribute(TracingId = 80812U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HWM3tkYWu73Mgc3CVcDi7i", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HWM3tkYWu73Mgc3CVcDi7i;
        [n1.ElementAttribute(TracingId = 80690U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IeIuFNwnTz0Lti78eM9IZ8", Name = "PointManipulator2d", IsManaged = true, IsAutoGenerated = true)]
        public n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_IeIuFNwnTz0Lti78eM9IZ8;
        [n1.ElementAttribute(TracingId = 80710U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AID5mI8Sq3kOiEq8VqngOL", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_AID5mI8Sq3kOiEq8VqngOL;
        [n1.ElementAttribute(TracingId = 80717U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JqRVtYVl9WTMVjinhRwqSP", Name = "Undo", IsManaged = true, IsAutoGenerated = true)]
        public n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_JqRVtYVl9WTMVjinhRwqSP;
        [n1.ElementAttribute(TracingId = 80822U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "E09YwUPqhfmNe4gFuGH7Bg", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_E09YwUPqhfmNe4gFuGH7Bg;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector2> __cp_Ueq6mBFnA46L864YDBctAL;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<int> __cp_RFSlHhQRiVOMkkgEncGZ81;
        static PointEditor_UkkghEPMxJHMCG7AYvyYTz()
        {
        }

        public PointEditor_UkkghEPMxJHMCG7AYvyYTz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditor_UkkghEPMxJHMCG7AYvyYTz(PointEditor_UkkghEPMxJHMCG7AYvyYTz other): base(other)
        {
            this.Points = other.Points;
            this.Current_Id = other.Current_Id;
            this.__slot_Base2Qk1oCTMZEGIfzzyaw = other.__slot_Base2Qk1oCTMZEGIfzzyaw;
            this.__slot_DGcUSqsCt4XPkRSET9dglW = other.__slot_DGcUSqsCt4XPkRSET9dglW;
            this.__p_IVtJiQzLGR1OkLGly8LKbQ = other.__p_IVtJiQzLGR1OkLGly8LKbQ;
            this.__p_HWM3tkYWu73Mgc3CVcDi7i = other.__p_HWM3tkYWu73Mgc3CVcDi7i;
            this.__p_IeIuFNwnTz0Lti78eM9IZ8 = other.__p_IeIuFNwnTz0Lti78eM9IZ8;
            this.__p_AID5mI8Sq3kOiEq8VqngOL = other.__p_AID5mI8Sq3kOiEq8VqngOL;
            this.__p_JqRVtYVl9WTMVjinhRwqSP = other.__p_JqRVtYVl9WTMVjinhRwqSP;
            this.__p_E09YwUPqhfmNe4gFuGH7Bg = other.__p_E09YwUPqhfmNe4gFuGH7Bg;
            this.__cp_Ueq6mBFnA46L864YDBctAL = other.__cp_Ueq6mBFnA46L864YDBctAL;
            this.__cp_RFSlHhQRiVOMkkgEncGZ81 = other.__cp_RFSlHhQRiVOMkkgEncGZ81;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Points", in Points), n1.CompilationHelper.GetValueOrExisting(values, "Current_Id", in Current_Id), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Base2Qk1oCTMZEGIfzzyaw", in __slot_Base2Qk1oCTMZEGIfzzyaw), n1.CompilationHelper.GetValueOrExisting(values, "__slot_DGcUSqsCt4XPkRSET9dglW", in __slot_DGcUSqsCt4XPkRSET9dglW), n1.CompilationHelper.GetValueOrExisting(values, "__p_IVtJiQzLGR1OkLGly8LKbQ", in __p_IVtJiQzLGR1OkLGly8LKbQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_HWM3tkYWu73Mgc3CVcDi7i", in __p_HWM3tkYWu73Mgc3CVcDi7i), n1.CompilationHelper.GetValueOrExisting(values, "__p_IeIuFNwnTz0Lti78eM9IZ8", in __p_IeIuFNwnTz0Lti78eM9IZ8), n1.CompilationHelper.GetValueOrExisting(values, "__p_AID5mI8Sq3kOiEq8VqngOL", in __p_AID5mI8Sq3kOiEq8VqngOL), n1.CompilationHelper.GetValueOrExisting(values, "__p_JqRVtYVl9WTMVjinhRwqSP", in __p_JqRVtYVl9WTMVjinhRwqSP), n1.CompilationHelper.GetValueOrExisting(values, "__p_E09YwUPqhfmNe4gFuGH7Bg", in __p_E09YwUPqhfmNe4gFuGH7Bg), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Ueq6mBFnA46L864YDBctAL", in __cp_Ueq6mBFnA46L864YDBctAL), n1.CompilationHelper.GetValueOrExisting(values, "__cp_RFSlHhQRiVOMkkgEncGZ81", in __cp_RFSlHhQRiVOMkkgEncGZ81));
        }

        internal PointEditor_UkkghEPMxJHMCG7AYvyYTz __WITH__(n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points, int Current_Id, int __slot_Base2Qk1oCTMZEGIfzzyaw, int __slot_DGcUSqsCt4XPkRSET9dglW, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_IVtJiQzLGR1OkLGly8LKbQ, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HWM3tkYWu73Mgc3CVcDi7i, n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_IeIuFNwnTz0Lti78eM9IZ8, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_AID5mI8Sq3kOiEq8VqngOL, n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_JqRVtYVl9WTMVjinhRwqSP, n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_E09YwUPqhfmNe4gFuGH7Bg, n10.Spread<n3.Vector2> __cp_Ueq6mBFnA46L864YDBctAL, n10.Spread<int> __cp_RFSlHhQRiVOMkkgEncGZ81)
        {
            n33.PointEditor_UkkghEPMxJHMCG7AYvyYTz that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Points != this.Points || Current_Id != this.Current_Id || __slot_Base2Qk1oCTMZEGIfzzyaw != this.__slot_Base2Qk1oCTMZEGIfzzyaw || __slot_DGcUSqsCt4XPkRSET9dglW != this.__slot_DGcUSqsCt4XPkRSET9dglW || __p_IVtJiQzLGR1OkLGly8LKbQ != this.__p_IVtJiQzLGR1OkLGly8LKbQ || __p_HWM3tkYWu73Mgc3CVcDi7i != this.__p_HWM3tkYWu73Mgc3CVcDi7i || __p_IeIuFNwnTz0Lti78eM9IZ8 != this.__p_IeIuFNwnTz0Lti78eM9IZ8 || __p_AID5mI8Sq3kOiEq8VqngOL != this.__p_AID5mI8Sq3kOiEq8VqngOL || __p_JqRVtYVl9WTMVjinhRwqSP != this.__p_JqRVtYVl9WTMVjinhRwqSP || __p_E09YwUPqhfmNe4gFuGH7Bg != this.__p_E09YwUPqhfmNe4gFuGH7Bg || __cp_Ueq6mBFnA46L864YDBctAL != this.__cp_Ueq6mBFnA46L864YDBctAL || __cp_RFSlHhQRiVOMkkgEncGZ81 != this.__cp_RFSlHhQRiVOMkkgEncGZ81 ? new PointEditor_UkkghEPMxJHMCG7AYvyYTz(this)
                {Points = Points, Current_Id = Current_Id, __slot_Base2Qk1oCTMZEGIfzzyaw = __slot_Base2Qk1oCTMZEGIfzzyaw, __slot_DGcUSqsCt4XPkRSET9dglW = __slot_DGcUSqsCt4XPkRSET9dglW, __p_IVtJiQzLGR1OkLGly8LKbQ = __p_IVtJiQzLGR1OkLGly8LKbQ, __p_HWM3tkYWu73Mgc3CVcDi7i = __p_HWM3tkYWu73Mgc3CVcDi7i, __p_IeIuFNwnTz0Lti78eM9IZ8 = __p_IeIuFNwnTz0Lti78eM9IZ8, __p_AID5mI8Sq3kOiEq8VqngOL = __p_AID5mI8Sq3kOiEq8VqngOL, __p_JqRVtYVl9WTMVjinhRwqSP = __p_JqRVtYVl9WTMVjinhRwqSP, __p_E09YwUPqhfmNe4gFuGH7Bg = __p_E09YwUPqhfmNe4gFuGH7Bg, __cp_Ueq6mBFnA46L864YDBctAL = __cp_Ueq6mBFnA46L864YDBctAL, __cp_RFSlHhQRiVOMkkgEncGZ81 = __cp_RFSlHhQRiVOMkkgEncGZ81} : that_0;
            else
            {
                this.Points = Points;
                this.Current_Id = Current_Id;
                this.__slot_Base2Qk1oCTMZEGIfzzyaw = __slot_Base2Qk1oCTMZEGIfzzyaw;
                this.__slot_DGcUSqsCt4XPkRSET9dglW = __slot_DGcUSqsCt4XPkRSET9dglW;
                this.__p_IVtJiQzLGR1OkLGly8LKbQ = __p_IVtJiQzLGR1OkLGly8LKbQ;
                this.__p_HWM3tkYWu73Mgc3CVcDi7i = __p_HWM3tkYWu73Mgc3CVcDi7i;
                this.__p_IeIuFNwnTz0Lti78eM9IZ8 = __p_IeIuFNwnTz0Lti78eM9IZ8;
                this.__p_AID5mI8Sq3kOiEq8VqngOL = __p_AID5mI8Sq3kOiEq8VqngOL;
                this.__p_JqRVtYVl9WTMVjinhRwqSP = __p_JqRVtYVl9WTMVjinhRwqSP;
                this.__p_E09YwUPqhfmNe4gFuGH7Bg = __p_E09YwUPqhfmNe4gFuGH7Bg;
                this.__cp_Ueq6mBFnA46L864YDBctAL = __cp_Ueq6mBFnA46L864YDBctAL;
                this.__cp_RFSlHhQRiVOMkkgEncGZ81 = __cp_RFSlHhQRiVOMkkgEncGZ81;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 83115U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JSuW2sbD6X1MDCPp1QdsHz", Name = "BezierEditor_JSuW2sbD6X1MDCPp1QdsHz")]
    [n2.SerializableAttribute]
    public class BezierEditor_JSuW2sbD6X1MDCPp1QdsHz : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz Create(n1.NodeContext Node_Context)
        {
            var instance = new BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz CreateDefault()
        {
            var instance = new BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz Update(n23.IEnumerable<n22.BezierKnot_R<n3.Vector2>> Knots_To_Add_In, bool Add_Knots_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Add_and_Smooth_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Insert_Knot_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Clear_In, n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, float Gizmo_Size_In, n3.Matrix View_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, [n6.SerializedDefaultValueAttribute("1", false)] float Camera_Zoom_In, n17.Path File_Path_In, bool Load_In, bool Save_In, out n8.BezierEditorState_R<n3.Vector2, float, n3.Vector2, bool, bool, bool, n3.Vector2, bool, bool> BezierEditorState_Out, out n30.BezierSpline_R<n3.Vector2> BezierSpline_Out, out bool Idle_Out)
        {
            int __pad_EZBcQ3G54XaMRPIbZrCatj_0 = __slot_EZBcQ3G54XaMRPIbZrCatj;
            int __pad_CwDxijHRI4ULDJG0nKyNmH_1 = __slot_CwDxijHRI4ULDJG0nKyNmH;
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __auto_2 = this.BezierKnots;
            int __auto_3 = this.Next_Id;
            var Output_4 = Add_Knots_In || Add_and_Smooth_In;
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Knot_5;
            int Next_Id_6;
            var state_7 = n1.CompilationHelper.Restore<__OSXy9LRTjBlMtxKFR5SVoE>(this.__if_KJ2YHwEsL3nOmLvtK9xriW, __GetContext__());
            if (Output_4)
            {
                if (state_7 == null)
                {
                    state_7 = new __OSXy9LRTjBlMtxKFR5SVoE(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_MnIxB7j30fhNHz4harEOOJ = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>()};
                }

                int accumulator_9 = __auto_3;
                var builder_16 = n6.CollectionBuilders.GetBuilder(state_7.__cp_MnIxB7j30fhNHz4harEOOJ, 16);
                n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> output_17;
                try
                {
                    var i_11 = 0;
                    foreach (var item_8 in Knots_To_Add_In)
                    {
                        var splicer_10 = item_8;
                        var i_local_12 = i_11;
                        n20._Operations_.ToEditableBezierKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(BezierKnot_In: splicer_10, Next_Id_In: accumulator_9, EditableBezierKnot_Out: out n8.EditableBezierKnot_R<n3.Vector2> EditableBezierKnot_14, Next_Id_Out: out int Next_Id_15);
                        builder_16.Add(EditableBezierKnot_14);
                        accumulator_9 = Next_Id_15;
                        i_11++;
                    }
                }
                finally
                {
                    output_17 = builder_16.Commit();
                }

                Knot_5 = output_17;
                Next_Id_6 = accumulator_9;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_17 != state_7.__cp_MnIxB7j30fhNHz4harEOOJ ? new __OSXy9LRTjBlMtxKFR5SVoE(state_7)
                    {__cp_MnIxB7j30fhNHz4harEOOJ = output_17} : state_7;
                else
                {
                    state_7.__cp_MnIxB7j30fhNHz4harEOOJ = output_17;
                }
            }
            else
            {
                Knot_5 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
                Next_Id_6 = __auto_3;
            }

            var Output_20 = this.__p_GZMZY3bGRYYQZDLACyaEgx.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(File_Path_In: File_Path_In, Read_In: Load_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Result_18, On_Data_Out: out bool On_Data_19);
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>(Condition_In: On_Data_19, Input_In: __auto_2, Input_2_In: Result_18, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_21);
            var Output_30 = BezierEditorControls_In.Split(Corner_Out: out bool Corner_22, Corner_With_Handles_Out: out bool Corner_With_Handles_23, Smooth_Out: out bool Smooth_24, Smooth_Symmetric_Out: out bool Smooth_Symmetric_25, Find_Point_on_Curve_Out: out bool Find_Point_on_Curve_26, PointEditorControls_Out: out n8.PointEditorControlsData_R PointEditorControls_27, Hover_Control_Out: out bool Hover_Control_28, Force_Selection_Out: out bool Force_Selection_29);
            var Output_46 = PointEditorControls_27.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_31, Mouse_Pressed_Out: out bool Mouse_Pressed_32, Selection_Out: out n3.RectangleF Selection_33, Remove_Selected_Out: out bool Remove_Selected_34, Control_Out: out bool Control_35, Shift_Out: out bool Shift_36, Space_Out: out bool Space_37, Hover_Next_Out: out bool Hover_Next_38, Hover_Previous_Out: out bool Hover_Previous_39, Select_All_Out: out bool Select_All_40, Scale_Out: out bool Scale_41, Rotate_Out: out bool Rotate_42, Translate_Out: out bool Translate_43, Undo_Out: out bool Undo_44, Redo_Out: out bool Redo_45);
            bool Apply_47 = true;
            var Output_48 = View_In;
            if (Apply_47)
            {
                n3.Matrix.Invert(value: ref View_In, result: out n3.Matrix Output_49);
                Output_48 = Output_49;
            }

            bool Apply_50 = true;
            var Output_51 = Pointer_Position_31;
            if (Apply_50)
            {
                n3.Vector2.TransformCoordinate(coordinate: ref Pointer_Position_31, transform: ref Output_48, result: out n3.Vector2 Output_52);
                Output_51 = Output_52;
            }

            n20._Operations_.FindPositionOnSegment<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(EditableBezierKnots_In: Output_21, Point_In: Output_51, Iteration_Count_In: __pad_CwDxijHRI4ULDJG0nKyNmH_1, Sample_In: Find_Point_on_Curve_26, Segment_Index_Out: out int Segment_Index_53, Position_on_Segment_Out: out float Position_on_Segment_54);
            var Output_55 = Insert_Knot_In && Find_Point_on_Curve_26;
            n20._Operations_.InsertKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_21, Segment_Index_In: Segment_Index_53, Position_on_Segment_In: Position_on_Segment_54, Add_Knot_In: Output_55, Sample_Point_In: Find_Point_on_Curve_26, Next_Id_In: Next_Id_6, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_56, Sampled_Point_Out: out n3.Vector2 Sampled_Point_57, Next_Id_Out: out int Next_Id_58);
            var Output_68 = this.__p_UzSD4v773YpPOFGG9adTRR.Update(BezierPoints_In: Output_56, BezierPointEditorControls_In: BezierEditorControls_In, Gizmo_Controls_In: Gizmo_Controls_In, Pick_Size_In: Pick_Size_In, Step_Size_In: Step_Size_In, Gizmo_Size_In: Gizmo_Size_In, ViewProjection_In: View_In, Camera_Zoom_In: Camera_Zoom_In, Camera_Idle_In: Camera_Idle_In, BezierPoints_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> BezierPoints_59, Editing_Out: out bool Editing_60, Selection_Changed_Out: out bool Selection_Changed_61, Selection_Updated_Out: out bool Selection_Updated_62, Translate_Out: out bool Translate_63, Rotate_Out: out bool Rotate_64, Scale_Out: out bool Scale_65, Offset_Out: out n3.Vector2 Offset_66, GizmoState_Out: out n34.GizmoState_R GizmoState_67);
            var Output_69 = !Force_Selection_29;
            var Output_70 = Selection_Updated_62 && Output_69;
            var Output_71 = BezierPoints_59;
            if (Output_70)
            {
                n20._Operations_.CorrectSelection<n3.Vector2>(Input_In: BezierPoints_59, Output_Out: out Output_71);
            }

            n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector2>> Knots_to_Add_72 = (n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector2>>)Knot_5;
            n20._Operations_.AddRemoveBezierKnots<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_71, Knots_to_Add_In: Knots_to_Add_72, Add_In: Output_4, Smooth_In: Add_and_Smooth_In, Clear_In: Clear_In, Remove_Selected_In: Remove_Selected_34, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_73);
            var Output_74 = Corner_22 || Corner_With_Handles_23;
            var Output_75 = Output_74 || Smooth_24;
            var Output_76 = Output_75 || Smooth_Symmetric_25;
            var Output_77 = Output_4 || Clear_In;
            var Output_78 = Output_77 || Remove_Selected_34;
            var Output_79 = Output_78 || Output_76;
            var Output_80 = Output_79 || Insert_Knot_In;
            var Output_81 = !Find_Point_on_Curve_26;
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>(Condition_In: Output_81, Input_In: Output_56, Input_2_In: Output_73, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_82);
            var Output_85 = this.__p_PbIoRrDVRjlQDR0ZWLvvmv.Update(Value_In: Editing_60, Up_Edge_Out: out bool Up_Edge_83, Down_Edge_Out: out bool Down_Edge_84);
            var Output_86 = Output_80 || Down_Edge_84;
            var Output_90 = this.__p_EY3TpTAdwlYP6xjll7Ustj.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Clear_In: Clear_In, Item_In: Output_82, Levels_In: __pad_EZBcQ3G54XaMRPIbZrCatj_0, Push_In: Output_86, Undo_In: Undo_44, Redo_In: Redo_45, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Result_87, Count_Out: out int Count_88, Pointer_Out: out int Pointer_89);
            var Output_91 = Scale_65 || Scale_41;
            bool Update_92 = true;
            var Output_93 = this.__p_RJ11ujNKoWvOk2PJtHTnlx;
            if (Update_92)
            {
                Output_93 = this.__p_RJ11ujNKoWvOk2PJtHTnlx.Update<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>(Data_In: Result_87, File_Path_In: File_Path_In, Write_In: Save_In);
            }

            n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector2>> BezierKnots_94 = (n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector2>>)Result_87;
            var Output_95 = Translate_63 || Translate_43;
            var Output_96 = Rotate_64 || Rotate_42;
            var Identity_97 = n3.Matrix.Identity;
            var Result_98 = View_In == Identity_97;
            n8.BezierEditorState_R<n3.Vector2, float, n3.Vector2, bool, bool, bool, n3.Vector2, bool, bool> Input_99 = n8.BezierEditorState_R<n3.Vector2, float, n3.Vector2, bool, bool, bool, n3.Vector2, bool, bool>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            var Output_100 = Input_99.Join(BezierKnots_In: BezierKnots_94, Pick_Size_In: Pick_Size_In, Offset_In: Offset_66, Translation_In: Output_95, Rotation_In: Output_96, Scaling_In: Output_91, Point_on_Curve_In: Sampled_Point_57, Looking_for_Point_In: Find_Point_on_Curve_26, Editing_In: Editing_60, Is_Projection_Space_In: Result_98, GizmoState_In: GizmoState_67);
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __auto_101 = Result_87;
            var builder_108 = n6.CollectionBuilders.GetBuilder(this.__cp_B1IZnhe5BdNOCRqNLIcg9L, 16);
            n10.Spread<n22.BezierKnot_R<n3.Vector2>> output_109;
            try
            {
                var i_104 = 0;
                foreach (var item_102 in n6.CollectionExtensions.AsSpan(Result_87))
                {
                    var splicer_103 = item_102;
                    var i_local_105 = i_104;
                    n20._Operations_.ToBezierKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(EditableBezierKnot_In: splicer_103, BezierKnot_Out: out n22.BezierKnot_R<n3.Vector2> BezierKnot_107);
                    builder_108.Add(BezierKnot_107);
                    i_104++;
                }
            }
            finally
            {
                output_109 = builder_108.Commit();
            }

            n30.BezierSpline_R<n3.Vector2> Input_110 = n30.BezierSpline_R<n3.Vector2>.CreateDefault();
            bool Apply_111 = true;
            var Output_112 = Input_110;
            if (Apply_111)
            {
                Output_112 = Input_110.Join(Knots_In: output_109);
            }

            int Input_2_113 = 0;
            n32._Operations_.Switch_Boolean<int>(Condition_In: On_Data_19, Input_In: Next_Id_58, Input_2_In: Input_2_113, Output_Out: out int Output_114);
            int __auto_115 = Output_114;
            var Output_116 = !Editing_60;
            BezierEditorState_Out = Output_100;
            BezierSpline_Out = Output_112;
            Idle_Out = Output_116;
            n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz that_117 = this;
            if (this.__GetContext__().IsImmutable)
                that_117 = state_7 != this.__if_KJ2YHwEsL3nOmLvtK9xriW || Output_20 != this.__p_GZMZY3bGRYYQZDLACyaEgx || Output_68 != this.__p_UzSD4v773YpPOFGG9adTRR || Output_85 != this.__p_PbIoRrDVRjlQDR0ZWLvvmv || Output_90 != this.__p_EY3TpTAdwlYP6xjll7Ustj || Output_93 != this.__p_RJ11ujNKoWvOk2PJtHTnlx || Result_87 != this.BezierKnots || output_109 != this.__cp_B1IZnhe5BdNOCRqNLIcg9L || Output_114 != this.Next_Id ? new BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(this)
                {__if_KJ2YHwEsL3nOmLvtK9xriW = state_7, __p_GZMZY3bGRYYQZDLACyaEgx = Output_20, __p_UzSD4v773YpPOFGG9adTRR = Output_68, __p_PbIoRrDVRjlQDR0ZWLvvmv = Output_85, __p_EY3TpTAdwlYP6xjll7Ustj = Output_90, __p_RJ11ujNKoWvOk2PJtHTnlx = Output_93, BezierKnots = Result_87, __cp_B1IZnhe5BdNOCRqNLIcg9L = output_109, Next_Id = Output_114} : that_117;
            else
            {
                this.__if_KJ2YHwEsL3nOmLvtK9xriW = state_7;
                this.__p_GZMZY3bGRYYQZDLACyaEgx = Output_20;
                this.__p_UzSD4v773YpPOFGG9adTRR = Output_68;
                this.__p_PbIoRrDVRjlQDR0ZWLvvmv = Output_85;
                this.__p_EY3TpTAdwlYP6xjll7Ustj = Output_90;
                this.__p_RJ11ujNKoWvOk2PJtHTnlx = Output_93;
                this.BezierKnots = Result_87;
                this.__cp_B1IZnhe5BdNOCRqNLIcg9L = output_109;
                this.Next_Id = Output_114;
            }

            return that_117;
        }

        public n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "EY3TpTAdwlYP6xjll7Ustj", 83226U);
            var Output_1 = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "PbIoRrDVRjlQDR0ZWLvvmv", 83239U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "UzSD4v773YpPOFGG9adTRR", 83260U);
            var Output_5 = n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "GZMZY3bGRYYQZDLACyaEgx", 83737U);
            var Output_7 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RJ11ujNKoWvOk2PJtHTnlx", 83750U);
            var Output_9 = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.Create(Node_Context: Node_Context_8);
            n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz that_10 = this;
            this.BezierKnots = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
            this.Next_Id = 0;
            this.__cp_B1IZnhe5BdNOCRqNLIcg9L = n14._Operations_.CreateDefault<n22.BezierKnot_R<n3.Vector2>>();
            this.__p_EY3TpTAdwlYP6xjll7Ustj = Output_1;
            this.__p_PbIoRrDVRjlQDR0ZWLvvmv = Output_3;
            this.__p_UzSD4v773YpPOFGG9adTRR = Output_5;
            this.__p_GZMZY3bGRYYQZDLACyaEgx = Output_7;
            this.__p_RJ11ujNKoWvOk2PJtHTnlx = Output_9;
            this.__if_KJ2YHwEsL3nOmLvtK9xriW = default(n2.Object);
            return that_10;
        }

        public n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz __CreateDefault__()
        {
            n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz that_0 = this;
            this.BezierKnots = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
            this.Next_Id = 0;
            this.__cp_B1IZnhe5BdNOCRqNLIcg9L = n14._Operations_.CreateDefault<n22.BezierKnot_R<n3.Vector2>>();
            this.__if_KJ2YHwEsL3nOmLvtK9xriW = default(n2.Object);
            this.__p_GZMZY3bGRYYQZDLACyaEgx = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_UzSD4v773YpPOFGG9adTRR = n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC.CreateDefault();
            this.__p_PbIoRrDVRjlQDR0ZWLvvmv = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_EY3TpTAdwlYP6xjll7Ustj = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>.CreateDefault();
            this.__p_RJ11ujNKoWvOk2PJtHTnlx = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_KJ2YHwEsL3nOmLvtK9xriW);
            n1.CompilationHelper.SafeDispose(this.__p_GZMZY3bGRYYQZDLACyaEgx);
            n1.CompilationHelper.SafeDispose(this.__p_UzSD4v773YpPOFGG9adTRR);
            n1.CompilationHelper.SafeDispose(this.__p_PbIoRrDVRjlQDR0ZWLvvmv);
            n1.CompilationHelper.SafeDispose(this.__p_EY3TpTAdwlYP6xjll7Ustj);
            n1.CompilationHelper.SafeDispose(this.__p_RJ11ujNKoWvOk2PJtHTnlx);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 83117U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "ITNUt1GmbQtLdAHAayRqaj", Name = "BezierKnots")]
        public n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> BezierKnots;
        [n1.ElementAttribute(TracingId = 83118U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VRj5nddorF7NEpNwCTjV1j", Name = "Next Id")]
        public int Next_Id;
        [n1.ElementAttribute(TracingId = 83162U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EZBcQ3G54XaMRPIbZrCatj", Name = "__slot_EZBcQ3G54XaMRPIbZrCatj")]
        public static int __slot_EZBcQ3G54XaMRPIbZrCatj = 50;
        [n1.ElementAttribute(TracingId = 83163U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CwDxijHRI4ULDJG0nKyNmH", Name = "__slot_CwDxijHRI4ULDJG0nKyNmH")]
        public static int __slot_CwDxijHRI4ULDJG0nKyNmH = 100;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_KJ2YHwEsL3nOmLvtK9xriW;
        [n1.ElementAttribute(TracingId = 83737U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GZMZY3bGRYYQZDLACyaEgx", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>> __p_GZMZY3bGRYYQZDLACyaEgx;
        [n1.ElementAttribute(TracingId = 83260U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UzSD4v773YpPOFGG9adTRR", Name = "BezierKnotManipulator2d", IsManaged = true, IsAutoGenerated = true)]
        public n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC __p_UzSD4v773YpPOFGG9adTRR;
        [n1.ElementAttribute(TracingId = 83239U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PbIoRrDVRjlQDR0ZWLvvmv", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PbIoRrDVRjlQDR0ZWLvvmv;
        [n1.ElementAttribute(TracingId = 83226U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EY3TpTAdwlYP6xjll7Ustj", Name = "Undo", IsManaged = true, IsAutoGenerated = true)]
        public n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>> __p_EY3TpTAdwlYP6xjll7Ustj;
        [n1.ElementAttribute(TracingId = 83750U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RJ11ujNKoWvOk2PJtHTnlx", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_RJ11ujNKoWvOk2PJtHTnlx;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n22.BezierKnot_R<n3.Vector2>> __cp_B1IZnhe5BdNOCRqNLIcg9L;
        static BezierEditor_JSuW2sbD6X1MDCPp1QdsHz()
        {
        }

        public BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(BezierEditor_JSuW2sbD6X1MDCPp1QdsHz other): base(other)
        {
            this.BezierKnots = other.BezierKnots;
            this.Next_Id = other.Next_Id;
            this.__if_KJ2YHwEsL3nOmLvtK9xriW = other.__if_KJ2YHwEsL3nOmLvtK9xriW;
            this.__p_GZMZY3bGRYYQZDLACyaEgx = other.__p_GZMZY3bGRYYQZDLACyaEgx;
            this.__p_UzSD4v773YpPOFGG9adTRR = other.__p_UzSD4v773YpPOFGG9adTRR;
            this.__p_PbIoRrDVRjlQDR0ZWLvvmv = other.__p_PbIoRrDVRjlQDR0ZWLvvmv;
            this.__p_EY3TpTAdwlYP6xjll7Ustj = other.__p_EY3TpTAdwlYP6xjll7Ustj;
            this.__p_RJ11ujNKoWvOk2PJtHTnlx = other.__p_RJ11ujNKoWvOk2PJtHTnlx;
            this.__cp_B1IZnhe5BdNOCRqNLIcg9L = other.__cp_B1IZnhe5BdNOCRqNLIcg9L;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "BezierKnots", in BezierKnots), n1.CompilationHelper.GetValueOrExisting(values, "Next_Id", in Next_Id), n1.CompilationHelper.GetValueOrExisting(values, "__if_KJ2YHwEsL3nOmLvtK9xriW", in __if_KJ2YHwEsL3nOmLvtK9xriW), n1.CompilationHelper.GetValueOrExisting(values, "__p_GZMZY3bGRYYQZDLACyaEgx", in __p_GZMZY3bGRYYQZDLACyaEgx), n1.CompilationHelper.GetValueOrExisting(values, "__p_UzSD4v773YpPOFGG9adTRR", in __p_UzSD4v773YpPOFGG9adTRR), n1.CompilationHelper.GetValueOrExisting(values, "__p_PbIoRrDVRjlQDR0ZWLvvmv", in __p_PbIoRrDVRjlQDR0ZWLvvmv), n1.CompilationHelper.GetValueOrExisting(values, "__p_EY3TpTAdwlYP6xjll7Ustj", in __p_EY3TpTAdwlYP6xjll7Ustj), n1.CompilationHelper.GetValueOrExisting(values, "__p_RJ11ujNKoWvOk2PJtHTnlx", in __p_RJ11ujNKoWvOk2PJtHTnlx), n1.CompilationHelper.GetValueOrExisting(values, "__cp_B1IZnhe5BdNOCRqNLIcg9L", in __cp_B1IZnhe5BdNOCRqNLIcg9L));
        }

        internal BezierEditor_JSuW2sbD6X1MDCPp1QdsHz __WITH__(n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> BezierKnots, int Next_Id, n2.Object __if_KJ2YHwEsL3nOmLvtK9xriW, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>> __p_GZMZY3bGRYYQZDLACyaEgx, n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC __p_UzSD4v773YpPOFGG9adTRR, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PbIoRrDVRjlQDR0ZWLvvmv, n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>> __p_EY3TpTAdwlYP6xjll7Ustj, n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_RJ11ujNKoWvOk2PJtHTnlx, n10.Spread<n22.BezierKnot_R<n3.Vector2>> __cp_B1IZnhe5BdNOCRqNLIcg9L)
        {
            n33.BezierEditor_JSuW2sbD6X1MDCPp1QdsHz that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = BezierKnots != this.BezierKnots || Next_Id != this.Next_Id || __if_KJ2YHwEsL3nOmLvtK9xriW != this.__if_KJ2YHwEsL3nOmLvtK9xriW || __p_GZMZY3bGRYYQZDLACyaEgx != this.__p_GZMZY3bGRYYQZDLACyaEgx || __p_UzSD4v773YpPOFGG9adTRR != this.__p_UzSD4v773YpPOFGG9adTRR || __p_PbIoRrDVRjlQDR0ZWLvvmv != this.__p_PbIoRrDVRjlQDR0ZWLvvmv || __p_EY3TpTAdwlYP6xjll7Ustj != this.__p_EY3TpTAdwlYP6xjll7Ustj || __p_RJ11ujNKoWvOk2PJtHTnlx != this.__p_RJ11ujNKoWvOk2PJtHTnlx || __cp_B1IZnhe5BdNOCRqNLIcg9L != this.__cp_B1IZnhe5BdNOCRqNLIcg9L ? new BezierEditor_JSuW2sbD6X1MDCPp1QdsHz(this)
                {BezierKnots = BezierKnots, Next_Id = Next_Id, __if_KJ2YHwEsL3nOmLvtK9xriW = __if_KJ2YHwEsL3nOmLvtK9xriW, __p_GZMZY3bGRYYQZDLACyaEgx = __p_GZMZY3bGRYYQZDLACyaEgx, __p_UzSD4v773YpPOFGG9adTRR = __p_UzSD4v773YpPOFGG9adTRR, __p_PbIoRrDVRjlQDR0ZWLvvmv = __p_PbIoRrDVRjlQDR0ZWLvvmv, __p_EY3TpTAdwlYP6xjll7Ustj = __p_EY3TpTAdwlYP6xjll7Ustj, __p_RJ11ujNKoWvOk2PJtHTnlx = __p_RJ11ujNKoWvOk2PJtHTnlx, __cp_B1IZnhe5BdNOCRqNLIcg9L = __cp_B1IZnhe5BdNOCRqNLIcg9L} : that_0;
            else
            {
                this.BezierKnots = BezierKnots;
                this.Next_Id = Next_Id;
                this.__if_KJ2YHwEsL3nOmLvtK9xriW = __if_KJ2YHwEsL3nOmLvtK9xriW;
                this.__p_GZMZY3bGRYYQZDLACyaEgx = __p_GZMZY3bGRYYQZDLACyaEgx;
                this.__p_UzSD4v773YpPOFGG9adTRR = __p_UzSD4v773YpPOFGG9adTRR;
                this.__p_PbIoRrDVRjlQDR0ZWLvvmv = __p_PbIoRrDVRjlQDR0ZWLvvmv;
                this.__p_EY3TpTAdwlYP6xjll7Ustj = __p_EY3TpTAdwlYP6xjll7Ustj;
                this.__p_RJ11ujNKoWvOk2PJtHTnlx = __p_RJ11ujNKoWvOk2PJtHTnlx;
                this.__cp_B1IZnhe5BdNOCRqNLIcg9L = __cp_B1IZnhe5BdNOCRqNLIcg9L;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OSXy9LRTjBlMtxKFR5SVoE", Name = "__OSXy9LRTjBlMtxKFR5SVoE")]
        [n2.SerializableAttribute]
        public class __OSXy9LRTjBlMtxKFR5SVoE : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __cp_MnIxB7j30fhNHz4harEOOJ;
            public __OSXy9LRTjBlMtxKFR5SVoE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OSXy9LRTjBlMtxKFR5SVoE(__OSXy9LRTjBlMtxKFR5SVoE other): base(other)
            {
                this.__cp_MnIxB7j30fhNHz4harEOOJ = other.__cp_MnIxB7j30fhNHz4harEOOJ;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_MnIxB7j30fhNHz4harEOOJ", in __cp_MnIxB7j30fhNHz4harEOOJ));
            }

            internal __OSXy9LRTjBlMtxKFR5SVoE __WITH__(n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> __cp_MnIxB7j30fhNHz4harEOOJ)
            {
                __OSXy9LRTjBlMtxKFR5SVoE that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_MnIxB7j30fhNHz4harEOOJ != this.__cp_MnIxB7j30fhNHz4harEOOJ ? new __OSXy9LRTjBlMtxKFR5SVoE(this)
                    {__cp_MnIxB7j30fhNHz4harEOOJ = __cp_MnIxB7j30fhNHz4harEOOJ} : that_0;
                else
                {
                    this.__cp_MnIxB7j30fhNHz4harEOOJ = __cp_MnIxB7j30fhNHz4harEOOJ;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Editors_.Editors._2D.Internal
{
    [n1.ElementAttribute(TracingId = 81089U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FJOVd9YYOqCP04e46Kg1Il", Name = "Offsetter_FJOVd9YYOqCP04e46Kg1Il")]
    [n2.SerializableAttribute]
    public class Offsetter_FJOVd9YYOqCP04e46Kg1Il : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il Create(n1.NodeContext Node_Context)
        {
            var instance = new Offsetter_FJOVd9YYOqCP04e46Kg1Il(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il CreateDefault()
        {
            var instance = new Offsetter_FJOVd9YYOqCP04e46Kg1Il(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il Update(bool Editing_In, n3.Vector2 Position_In, n3.Matrix View_In, n3.Vector2 Step_Size_In, n3.Vector2 Nudge_In, [n6.SerializedDefaultValueAttribute("1", false)] float Scaling_In, out n3.Vector2 Relative_Out, out n3.Vector2 Absolute_Out, out bool Updated_Out)
        {
            n46.Vector2Nodes.Multiply(left: ref Step_Size_In, right: ref Nudge_In, result: out n3.Vector2 Output_0);
            n46.Vector2Nodes.Vector(input: ref Step_Size_In, x: out float X_1, y: out float Y_2);
            float Input_2_3 = 0F;
            var Result_4 = X_1 == Input_2_3;
            n3.Matrix.Invert(value: ref View_In, result: out n3.Matrix Output_5);
            n3.Vector2.TransformCoordinate(coordinate: ref Position_In, transform: ref Output_5, result: out n3.Vector2 Output_6);
            n48._Operations_.Quantize(Input_In: Output_6, Step_Size_In: Step_Size_In, Output_Out: out n3.Vector2 Output_7);
            n46.Vector2Nodes.Vector(input: ref Output_7, x: out float X_8, y: out float Y_9);
            n46.Vector2Nodes.Vector(input: ref Output_6, x: out float X_10, y: out float Y_11);
            n32._Operations_.Switch_Boolean<float>(Condition_In: Result_4, Input_In: X_8, Input_2_In: X_10, Output_Out: out float Output_12);
            float Input_2_13 = 0F;
            var Result_14 = Y_2 == Input_2_13;
            n32._Operations_.Switch_Boolean<float>(Condition_In: Result_14, Input_In: Y_9, Input_2_In: Y_11, Output_Out: out float Output_15);
            var Output_16 = new n3.Vector2(x: Output_12, y: Output_15);
            var Output_18 = this.__p_FNoPYWPmHXbPsnbkRAihhk.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Value_In: Output_16, Result_Out: out n3.Vector2 Result_17);
            n46.Vector2Nodes.Scale(input: ref Result_17, scalar: Scaling_In, output: out n3.Vector2 Output_19);
            n32._Operations_.Switch_Boolean<n3.Vector2>(Condition_In: Editing_In, Input_In: Output_0, Input_2_In: Output_19, Output_Out: out n3.Vector2 Output_20);
            var Result_21 = Output_0.Length();
            float Input_2_22 = 0F;
            var Result_23 = Result_21 > Input_2_22;
            var Output_24 = Editing_In || Result_23;
            var Output_25 = !Output_24;
            bool Step_26 = true;
            var Output_27 = this.__p_HEHb177mHNfND4Ob0kDlfB;
            if (Step_26)
            {
                Output_27 = this.__p_HEHb177mHNfND4Ob0kDlfB.Step<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Offset_In: Output_20);
            }

            n3.Vector2 Reset_Value_28 = n48._Operations_.CreateDefault();
            var Output_29 = Output_27;
            if (Output_25)
            {
                Output_29 = Output_27.Reset(Reset_Value_In: Reset_Value_28);
            }

            var Output_31 = Output_29.GetValue(Value_Out: out n3.Vector2 Value_30);
            Relative_Out = Output_20;
            Absolute_Out = Value_30;
            Updated_Out = Output_24;
            n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = Output_18 != this.__p_FNoPYWPmHXbPsnbkRAihhk || Output_31 != this.__p_HEHb177mHNfND4Ob0kDlfB ? new Offsetter_FJOVd9YYOqCP04e46Kg1Il(this)
                {__p_FNoPYWPmHXbPsnbkRAihhk = Output_18, __p_HEHb177mHNfND4Ob0kDlfB = Output_31} : that_32;
            else
            {
                this.__p_FNoPYWPmHXbPsnbkRAihhk = Output_18;
                this.__p_HEHb177mHNfND4Ob0kDlfB = Output_31;
            }

            return that_32;
        }

        public n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "FNoPYWPmHXbPsnbkRAihhk", 81121U);
            var Output_1 = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "HEHb177mHNfND4Ob0kDlfB", 81136U);
            n3.Vector2 Initial_Value_3 = n48._Operations_.CreateDefault();
            var Output_4 = n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector2>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_2, Initial_Value_In: Initial_Value_3);
            n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il that_5 = this;
            this.__p_FNoPYWPmHXbPsnbkRAihhk = Output_1;
            this.__p_HEHb177mHNfND4Ob0kDlfB = Output_4;
            return that_5;
        }

        public n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il __CreateDefault__()
        {
            n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il that_0 = this;
            this.__p_FNoPYWPmHXbPsnbkRAihhk = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_HEHb177mHNfND4Ob0kDlfB = n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FNoPYWPmHXbPsnbkRAihhk);
            n1.CompilationHelper.SafeDispose(this.__p_HEHb177mHNfND4Ob0kDlfB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 81121U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FNoPYWPmHXbPsnbkRAihhk", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2> __p_FNoPYWPmHXbPsnbkRAihhk;
        [n1.ElementAttribute(TracingId = 81136U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HEHb177mHNfND4Ob0kDlfB", Name = "Integrator", IsManaged = true, IsAutoGenerated = true)]
        public n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector2> __p_HEHb177mHNfND4Ob0kDlfB;
        public Offsetter_FJOVd9YYOqCP04e46Kg1Il(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Offsetter_FJOVd9YYOqCP04e46Kg1Il(Offsetter_FJOVd9YYOqCP04e46Kg1Il other): base(other)
        {
            this.__p_FNoPYWPmHXbPsnbkRAihhk = other.__p_FNoPYWPmHXbPsnbkRAihhk;
            this.__p_HEHb177mHNfND4Ob0kDlfB = other.__p_HEHb177mHNfND4Ob0kDlfB;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FNoPYWPmHXbPsnbkRAihhk", in __p_FNoPYWPmHXbPsnbkRAihhk), n1.CompilationHelper.GetValueOrExisting(values, "__p_HEHb177mHNfND4Ob0kDlfB", in __p_HEHb177mHNfND4Ob0kDlfB));
        }

        internal Offsetter_FJOVd9YYOqCP04e46Kg1Il __WITH__(n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2> __p_FNoPYWPmHXbPsnbkRAihhk, n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector2> __p_HEHb177mHNfND4Ob0kDlfB)
        {
            n52.Offsetter_FJOVd9YYOqCP04e46Kg1Il that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FNoPYWPmHXbPsnbkRAihhk != this.__p_FNoPYWPmHXbPsnbkRAihhk || __p_HEHb177mHNfND4Ob0kDlfB != this.__p_HEHb177mHNfND4Ob0kDlfB ? new Offsetter_FJOVd9YYOqCP04e46Kg1Il(this)
                {__p_FNoPYWPmHXbPsnbkRAihhk = __p_FNoPYWPmHXbPsnbkRAihhk, __p_HEHb177mHNfND4Ob0kDlfB = __p_HEHb177mHNfND4Ob0kDlfB} : that_0;
            else
            {
                this.__p_FNoPYWPmHXbPsnbkRAihhk = __p_FNoPYWPmHXbPsnbkRAihhk;
                this.__p_HEHb177mHNfND4Ob0kDlfB = __p_HEHb177mHNfND4Ob0kDlfB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 81242U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SRoT7IhKCRiLCRQU6fZSAJ", Name = "PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ")]
    [n2.SerializableAttribute]
    public class PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> : n1.VLObject, n2.IDisposable where T : n23.IEnumerable<n8.EditablePoint_R<n3.Vector2>>
    {
        [n6.CreateNewAttribute]
        public static n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var instance = new PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> CreateDefault()
        {
            var instance = new PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> Update(T Points_In, n8.PointEditorControlsData_R PointEditor_Controls_In, n3.Matrix View_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, float Gizmo_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Camera_Zoom_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points_Out, out n10.Spread<n3.Vector2> Result_Out, out bool Editing_Out, out bool Selection_Changed_Out, out bool Selection_Updated_Out, out bool Translate_Out, out bool Rotate_Out, out bool Scale_Out, out n3.Vector2 Offset_Out, out n34.GizmoState_R GizmoState_Out)
        {
            n3.Vector2 __pad_OdwqwuHsKTvLuDzdh2p7p9_0 = __slot_OdwqwuHsKTvLuDzdh2p7p9;
            int __pad_NTRgTR8AhF1Ox5BO3l2yOx_1 = __slot_NTRgTR8AhF1Ox5BO3l2yOx;
            float __pad_Iu2MyYc3mAiMxOGXBUcrkP_2 = __slot_Iu2MyYc3mAiMxOGXBUcrkP;
            float __pad_VBKGCLVxF29NxCQTLHF0Cf_3 = __slot_VBKGCLVxF29NxCQTLHF0Cf;
            bool __pad_KnsNFWZeBXVPEnHkIy5DLM_4 = __slot_KnsNFWZeBXVPEnHkIy5DLM;
            n31._Operations_.Average<T, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Points_In, Output_Out: out n3.Vector2 Output_5, Elements_Count_Out: out int Elements_Count_6);
            n48._Operations_.AvoidNaN(Input_In: Output_5, Default_In: __pad_OdwqwuHsKTvLuDzdh2p7p9_0, Output_Out: out n3.Vector2 Output_7);
            float Z_8 = 0F;
            var Result_9 = n46.Vector2Nodes.ToVector3(input: ref Output_7, z: Z_8);
            var Result_10 = Camera_Zoom_In != __pad_Iu2MyYc3mAiMxOGXBUcrkP_2;
            var Output_11 = Gizmo_Size_In;
            if (Result_10)
            {
                var Output_12 = (float)Gizmo_Size_In / Camera_Zoom_In;
                Output_11 = Output_12;
            }

            var Output_13 = (float)Output_11 / __pad_VBKGCLVxF29NxCQTLHF0Cf_3;
            var Output_16 = this.__p_Gv4cj5J9uRoQb7cFLoHa8D.Update(Value_In: Output_7, Result_Out: out bool Result_14, Unchanged_Out: out bool Unchanged_15);
            int Input_2_17 = 0;
            var Result_18 = Elements_Count_6 > Input_2_17;
            var Output_29 = this.__p_Jb1T8ePoWe4NAOku5c30gp.Update(Gizmo_Size_In: Output_11, Pick_Size_In: Output_13, Position_In: Result_9, Position_Changed_In: Result_14, Active_Plane_In: __pad_NTRgTR8AhF1Ox5BO3l2yOx_1, Number_of_Points_In: Elements_Count_6, Gizmo_Controls_In: Gizmo_Controls_In, Step_Size_In: Step_Size_In, View_Projection_In: View_In, Camera_Idle_In: Camera_Idle_In, Default_Visibility_In: __pad_KnsNFWZeBXVPEnHkIy5DLM_4, Enabled_In: Result_18, GizmoState_Out: out n34.GizmoState_R GizmoState_19, Translate_Offset_Out: out n3.Vector3 Translate_Offset_20, Scale_Offset_Out: out n3.Vector3 Scale_Offset_21, Rotate_Offset_Out: out n3.Vector3 Rotate_Offset_22, Total_Offset_Out: out n3.Vector3 Total_Offset_23, Translation_Active_Out: out bool Translation_Active_24, Scale_Active_Out: out bool Scale_Active_25, Rotation_Active_Out: out bool Rotation_Active_26, Active_Axis_Out: out n3.Vector3 Active_Axis_27, Idle_Out: out bool Idle_28);
            var Output_30 = !Idle_28;
            bool __pad_Pp5Hw7vBdwmOMTs5uJ8bYB_31 = Output_30;
            var Output_34 = this.__p_QxsKqm3c1EsQSZkJCepwk9.Update(Value_In: __pad_Pp5Hw7vBdwmOMTs5uJ8bYB_31, Up_Edge_Out: out bool Up_Edge_32, Down_Edge_Out: out bool Down_Edge_33);
            bool SetValue_35 = true;
            var Output_36 = this.__p_H1ByOENp45POjiyk4v6Ts2;
            if (SetValue_35)
            {
                Output_36 = this.__p_H1ByOENp45POjiyk4v6Ts2.SetValue(Value_In: Points_In, Sample_In: Up_Edge_32);
            }

            var Output_38 = Output_36.GetValue(Value_Out: out T Value_37);
            n32._Operations_.Switch_Boolean<T>(Condition_In: __pad_Pp5Hw7vBdwmOMTs5uJ8bYB_31, Input_In: Points_In, Input_2_In: Value_37, Output_Out: out T Output_39);
            n31._Operations_.UpdatePoints<T, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Inputs_In: Output_39, Matrix_In: View_In, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Outputs_40);
            n31._Operations_.Average<T, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_39, Output_Out: out n3.Vector2 Output_41, Elements_Count_Out: out int Elements_Count_42);
            var Output_58 = PointEditor_Controls_In.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_43, Mouse_Pressed_Out: out bool Mouse_Pressed_44, Selection_Out: out n3.RectangleF Selection_45, Remove_Selected_Out: out bool Remove_Selected_46, Control_Out: out bool Control_47, Shift_Out: out bool Shift_48, Space_Out: out bool Space_49, Hover_Next_Out: out bool Hover_Next_50, Hover_Previous_Out: out bool Hover_Previous_51, Select_All_Out: out bool Select_All_52, Scale_Out: out bool Scale_53, Rotate_Out: out bool Rotate_54, Translate_Out: out bool Translate_55, Undo_Out: out bool Undo_56, Redo_Out: out bool Redo_57);
            n31._Operations_.HoverWithMouse<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Outputs_40, Mouse_Position_In: Pointer_Position_43, Pick_Size_In: Pick_Size_In, Enable_In: Idle_28, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Output_59, Selection_Hovered_Out: out bool Selection_Hovered_60);
            var Output_61 = Idle_28 && Mouse_Pressed_44;
            n31._Operations_.SelectWithMarquee<n3.Vector2>(Input_In: Output_59, Mouse_Selection_In: Selection_45, Pick_Size_In: Pick_Size_In, Enable_In: Output_61, Remove_From_Selection_In: Shift_48, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Output_62, Selection_Modifier_Changed_Out: out bool Selection_Modifier_Changed_63);
            var Output_64 = Scale_53 || Rotate_54;
            var Output_65 = Output_64 || Translate_55;
            var Output_68 = this.__p_E7hYirePautN6JPsKHQwrV.Update(Value_In: Mouse_Pressed_44, Up_Edge_Out: out bool Up_Edge_66, Down_Edge_Out: out bool Down_Edge_67);
            n31._Operations_.SelectPoints<n10.Spread<n8.EditablePoint_R<n3.Vector2>>, n3.Vector2>(Inputs_In: Output_62, Selection_Hovered_In: Selection_Hovered_60, Gizmo_Idle_In: Idle_28, EditingKey_In: Output_65, Add_To_Selection_In: Control_47, Remove_From_Selection_In: Shift_48, Select_All_In: Select_All_52, Pressed_In: Up_Edge_66, Released_In: Down_Edge_67, Select_with_Key_In: Space_49, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Outputs_69, Selection_Changed_Out: out bool Selection_Changed_70, Selection_Set_Out: out bool Selection_Set_71);
            var Result_72 = (n3.Vector2)Translate_Offset_20;
            var Z_73 = Rotate_Offset_22.Z;
            var Result_74 = (n3.Vector2)Scale_Offset_21;
            n52._Operations_.EditPoints2d<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>(Points_In: Outputs_69, Center_In: Output_41, Editing_In: __pad_Pp5Hw7vBdwmOMTs5uJ8bYB_31, Translate_In: Result_72, Rotate_In: Z_73, Scale_In: Result_74, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Outputs_75, Result_Out: out n10.Spread<n3.Vector2> Result_76);
            var Output_77 = Mouse_Pressed_44 || Output_65;
            var Output_78 = Scale_53 || Scale_Active_25;
            var Output_79 = Rotate_54 || Rotation_Active_26;
            var Z_80 = Total_Offset_23.Z;
            float X_81 = 0F;
            float Z_82 = 0F;
            var Output_83 = new n3.Vector3(x: X_81, y: Z_80, z: Z_82);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Rotation_Active_26, Input_In: Total_Offset_23, Input_2_In: Output_83, Output_Out: out n3.Vector3 Output_84);
            var Result_85 = (n3.Vector2)Output_84;
            var Output_86 = Translate_55 || Translation_Active_24;
            var Output_87 = Selection_Modifier_Changed_63 || Selection_Set_71;
            var Output_88 = Output_87 && Output_77;
            Points_Out = Outputs_75;
            Result_Out = Result_76;
            Editing_Out = __pad_Pp5Hw7vBdwmOMTs5uJ8bYB_31;
            Selection_Changed_Out = Selection_Changed_70;
            Selection_Updated_Out = Output_88;
            Translate_Out = Output_86;
            Rotate_Out = Output_79;
            Scale_Out = Output_78;
            Offset_Out = Result_85;
            GizmoState_Out = GizmoState_19;
            n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> that_89 = this;
            if (this.__GetContext__().IsImmutable)
                that_89 = Output_16 != this.__p_Gv4cj5J9uRoQb7cFLoHa8D || Output_29 != this.__p_Jb1T8ePoWe4NAOku5c30gp || Output_30 != this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB || Output_34 != this.__p_QxsKqm3c1EsQSZkJCepwk9 || Output_38 != this.__p_H1ByOENp45POjiyk4v6Ts2 || Output_68 != this.__p_E7hYirePautN6JPsKHQwrV ? new PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T>(this)
                {__p_Gv4cj5J9uRoQb7cFLoHa8D = Output_16, __p_Jb1T8ePoWe4NAOku5c30gp = Output_29, __slot_Pp5Hw7vBdwmOMTs5uJ8bYB = Output_30, __p_QxsKqm3c1EsQSZkJCepwk9 = Output_34, __p_H1ByOENp45POjiyk4v6Ts2 = Output_38, __p_E7hYirePautN6JPsKHQwrV = Output_68} : that_89;
            else
            {
                this.__p_Gv4cj5J9uRoQb7cFLoHa8D = Output_16;
                this.__p_Jb1T8ePoWe4NAOku5c30gp = Output_29;
                this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = Output_30;
                this.__p_QxsKqm3c1EsQSZkJCepwk9 = Output_34;
                this.__p_H1ByOENp45POjiyk4v6Ts2 = Output_38;
                this.__p_E7hYirePautN6JPsKHQwrV = Output_68;
            }

            return that_89;
        }

        public n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "E7hYirePautN6JPsKHQwrV", 81349U);
            var Output_2 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Jb1T8ePoWe4NAOku5c30gp", 81362U);
            var Output_4 = n34.Gizmo_VCf0qns0epcMnUFCEx67yz.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Gv4cj5J9uRoQb7cFLoHa8D", 81393U);
            bool Changed_On_Create_6 = true;
            var Output_7 = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_5, Changed_On_Create_In: Changed_On_Create_6);
            w_0.CreateDefault(Output_Out: out T Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "H1ByOENp45POjiyk4v6Ts2", 81474U);
            var Output_10 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<T>.Create(Node_Context: Node_Context_9, Initial_Value_In: Output_8);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "QxsKqm3c1EsQSZkJCepwk9", 81479U);
            var Output_12 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_11);
            n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> that_13 = this;
            this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = false;
            this.__p_E7hYirePautN6JPsKHQwrV = Output_2;
            this.__p_Jb1T8ePoWe4NAOku5c30gp = Output_4;
            this.__p_Gv4cj5J9uRoQb7cFLoHa8D = Output_7;
            this.__p_H1ByOENp45POjiyk4v6Ts2 = Output_10;
            this.__p_QxsKqm3c1EsQSZkJCepwk9 = Output_12;
            return that_13;
        }

        public n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> __CreateDefault__()
        {
            n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> that_0 = this;
            this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = false;
            this.__p_Gv4cj5J9uRoQb7cFLoHa8D = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_Jb1T8ePoWe4NAOku5c30gp = n34.Gizmo_VCf0qns0epcMnUFCEx67yz.CreateDefault();
            this.__p_QxsKqm3c1EsQSZkJCepwk9 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_H1ByOENp45POjiyk4v6Ts2 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<T>.CreateDefault();
            this.__p_E7hYirePautN6JPsKHQwrV = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Gv4cj5J9uRoQb7cFLoHa8D);
            n1.CompilationHelper.SafeDispose(this.__p_Jb1T8ePoWe4NAOku5c30gp);
            n1.CompilationHelper.SafeDispose(this.__p_QxsKqm3c1EsQSZkJCepwk9);
            n1.CompilationHelper.SafeDispose(this.__p_H1ByOENp45POjiyk4v6Ts2);
            n1.CompilationHelper.SafeDispose(this.__p_E7hYirePautN6JPsKHQwrV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 81398U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NTRgTR8AhF1Ox5BO3l2yOx", Name = "__slot_NTRgTR8AhF1Ox5BO3l2yOx")]
        public static int __slot_NTRgTR8AhF1Ox5BO3l2yOx = 1;
        [n1.ElementAttribute(TracingId = 81430U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VBKGCLVxF29NxCQTLHF0Cf", Name = "__slot_VBKGCLVxF29NxCQTLHF0Cf")]
        public static float __slot_VBKGCLVxF29NxCQTLHF0Cf = 5F;
        [n1.ElementAttribute(TracingId = 81445U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KnsNFWZeBXVPEnHkIy5DLM", Name = "__slot_KnsNFWZeBXVPEnHkIy5DLM")]
        public static bool __slot_KnsNFWZeBXVPEnHkIy5DLM = false;
        [n1.ElementAttribute(TracingId = 81468U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Iu2MyYc3mAiMxOGXBUcrkP", Name = "__slot_Iu2MyYc3mAiMxOGXBUcrkP")]
        public static float __slot_Iu2MyYc3mAiMxOGXBUcrkP = 0F;
        [n1.ElementAttribute(TracingId = 81483U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Pp5Hw7vBdwmOMTs5uJ8bYB", Name = "__slot_Pp5Hw7vBdwmOMTs5uJ8bYB")]
        public bool __slot_Pp5Hw7vBdwmOMTs5uJ8bYB;
        [n1.ElementAttribute(TracingId = 81488U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OdwqwuHsKTvLuDzdh2p7p9", Name = "__slot_OdwqwuHsKTvLuDzdh2p7p9")]
        public static n3.Vector2 __slot_OdwqwuHsKTvLuDzdh2p7p9 = n1.CompilationHelper.Deserialize<n3.Vector2>("1000, 1000", false, "RMDMfKmnIrVPStLdWe8u30", "OdwqwuHsKTvLuDzdh2p7p9");
        [n1.ElementAttribute(TracingId = 81393U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Gv4cj5J9uRoQb7cFLoHa8D", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2> __p_Gv4cj5J9uRoQb7cFLoHa8D;
        [n1.ElementAttribute(TracingId = 81362U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Jb1T8ePoWe4NAOku5c30gp", Name = "Gizmo", IsManaged = true, IsAutoGenerated = true)]
        public n34.Gizmo_VCf0qns0epcMnUFCEx67yz __p_Jb1T8ePoWe4NAOku5c30gp;
        [n1.ElementAttribute(TracingId = 81479U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QxsKqm3c1EsQSZkJCepwk9", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_QxsKqm3c1EsQSZkJCepwk9;
        [n1.ElementAttribute(TracingId = 81474U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "H1ByOENp45POjiyk4v6Ts2", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<T> __p_H1ByOENp45POjiyk4v6Ts2;
        [n1.ElementAttribute(TracingId = 81349U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "E7hYirePautN6JPsKHQwrV", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_E7hYirePautN6JPsKHQwrV;
        static PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ()
        {
        }

        public PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ(PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> other): base(other)
        {
            this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = other.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB;
            this.__p_Gv4cj5J9uRoQb7cFLoHa8D = other.__p_Gv4cj5J9uRoQb7cFLoHa8D;
            this.__p_Jb1T8ePoWe4NAOku5c30gp = other.__p_Jb1T8ePoWe4NAOku5c30gp;
            this.__p_QxsKqm3c1EsQSZkJCepwk9 = other.__p_QxsKqm3c1EsQSZkJCepwk9;
            this.__p_H1ByOENp45POjiyk4v6Ts2 = other.__p_H1ByOENp45POjiyk4v6Ts2;
            this.__p_E7hYirePautN6JPsKHQwrV = other.__p_E7hYirePautN6JPsKHQwrV;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Pp5Hw7vBdwmOMTs5uJ8bYB", in __slot_Pp5Hw7vBdwmOMTs5uJ8bYB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gv4cj5J9uRoQb7cFLoHa8D", in __p_Gv4cj5J9uRoQb7cFLoHa8D), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jb1T8ePoWe4NAOku5c30gp", in __p_Jb1T8ePoWe4NAOku5c30gp), n1.CompilationHelper.GetValueOrExisting(values, "__p_QxsKqm3c1EsQSZkJCepwk9", in __p_QxsKqm3c1EsQSZkJCepwk9), n1.CompilationHelper.GetValueOrExisting(values, "__p_H1ByOENp45POjiyk4v6Ts2", in __p_H1ByOENp45POjiyk4v6Ts2), n1.CompilationHelper.GetValueOrExisting(values, "__p_E7hYirePautN6JPsKHQwrV", in __p_E7hYirePautN6JPsKHQwrV));
        }

        internal PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> __WITH__(bool __slot_Pp5Hw7vBdwmOMTs5uJ8bYB, n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2> __p_Gv4cj5J9uRoQb7cFLoHa8D, n34.Gizmo_VCf0qns0epcMnUFCEx67yz __p_Jb1T8ePoWe4NAOku5c30gp, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_QxsKqm3c1EsQSZkJCepwk9, n41.SPH_RESwCzqU3iTMc4Ig82Av03<T> __p_H1ByOENp45POjiyk4v6Ts2, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_E7hYirePautN6JPsKHQwrV)
        {
            n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Pp5Hw7vBdwmOMTs5uJ8bYB != this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB || __p_Gv4cj5J9uRoQb7cFLoHa8D != this.__p_Gv4cj5J9uRoQb7cFLoHa8D || __p_Jb1T8ePoWe4NAOku5c30gp != this.__p_Jb1T8ePoWe4NAOku5c30gp || __p_QxsKqm3c1EsQSZkJCepwk9 != this.__p_QxsKqm3c1EsQSZkJCepwk9 || __p_H1ByOENp45POjiyk4v6Ts2 != this.__p_H1ByOENp45POjiyk4v6Ts2 || __p_E7hYirePautN6JPsKHQwrV != this.__p_E7hYirePautN6JPsKHQwrV ? new PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<T>(this)
                {__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = __slot_Pp5Hw7vBdwmOMTs5uJ8bYB, __p_Gv4cj5J9uRoQb7cFLoHa8D = __p_Gv4cj5J9uRoQb7cFLoHa8D, __p_Jb1T8ePoWe4NAOku5c30gp = __p_Jb1T8ePoWe4NAOku5c30gp, __p_QxsKqm3c1EsQSZkJCepwk9 = __p_QxsKqm3c1EsQSZkJCepwk9, __p_H1ByOENp45POjiyk4v6Ts2 = __p_H1ByOENp45POjiyk4v6Ts2, __p_E7hYirePautN6JPsKHQwrV = __p_E7hYirePautN6JPsKHQwrV} : that_0;
            else
            {
                this.__slot_Pp5Hw7vBdwmOMTs5uJ8bYB = __slot_Pp5Hw7vBdwmOMTs5uJ8bYB;
                this.__p_Gv4cj5J9uRoQb7cFLoHa8D = __p_Gv4cj5J9uRoQb7cFLoHa8D;
                this.__p_Jb1T8ePoWe4NAOku5c30gp = __p_Jb1T8ePoWe4NAOku5c30gp;
                this.__p_QxsKqm3c1EsQSZkJCepwk9 = __p_QxsKqm3c1EsQSZkJCepwk9;
                this.__p_H1ByOENp45POjiyk4v6Ts2 = __p_H1ByOENp45POjiyk4v6Ts2;
                this.__p_E7hYirePautN6JPsKHQwrV = __p_E7hYirePautN6JPsKHQwrV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 81610U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SQh00YNQ1ZOO1t9hOnsSjC", Name = "BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC")]
    [n2.SerializableAttribute]
    public class BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC Create(n1.NodeContext Node_Context)
        {
            var instance = new BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC CreateDefault()
        {
            var instance = new BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC Update(n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> BezierPoints_In, n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierPointEditorControls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, float Gizmo_Size_In, n3.Matrix ViewProjection_In, [n6.SerializedDefaultValueAttribute("1", false)] float Camera_Zoom_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> BezierPoints_Out, out bool Editing_Out, out bool Selection_Changed_Out, out bool Selection_Updated_Out, out bool Translate_Out, out bool Rotate_Out, out bool Scale_Out, out n3.Vector2 Offset_Out, out n34.GizmoState_R GizmoState_Out)
        {
            var Output_8 = BezierPointEditorControls_In.Split(Corner_Out: out bool Corner_0, Corner_With_Handles_Out: out bool Corner_With_Handles_1, Smooth_Out: out bool Smooth_2, Smooth_Symmetric_Out: out bool Smooth_Symmetric_3, Find_Point_on_Curve_Out: out bool Find_Point_on_Curve_4, PointEditorControls_Out: out n8.PointEditorControlsData_R PointEditorControls_5, Hover_Control_Out: out bool Hover_Control_6, Force_Selection_Out: out bool Force_Selection_7);
            var Output_9 = BezierPoints_In;
            if (Corner_0)
            {
                n20._Operations_.MakeCornerKnot<n3.Vector2>(Input_In: BezierPoints_In, Output_Out: out Output_9);
            }

            var Output_10 = Output_9;
            if (Corner_With_Handles_1)
            {
                n20._Operations_.MakeCornerWithHandlesKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_9, Output_Out: out Output_10);
            }

            var Output_11 = Output_10;
            if (Smooth_2)
            {
                n20._Operations_.MakeSmoothKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_10, Output_Out: out Output_11);
            }

            var Output_12 = Smooth_2 || Smooth_Symmetric_3;
            var Output_13 = Output_11;
            if (Smooth_Symmetric_3)
            {
                n20._Operations_.MakeSmoothSymmetricKnot<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_11, Output_Out: out Output_13);
            }

            var Output_29 = PointEditorControls_5.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_14, Mouse_Pressed_Out: out bool Mouse_Pressed_15, Selection_Out: out n3.RectangleF Selection_16, Remove_Selected_Out: out bool Remove_Selected_17, Control_Out: out bool Control_18, Shift_Out: out bool Shift_19, Space_Out: out bool Space_20, Hover_Next_Out: out bool Hover_Next_21, Hover_Previous_Out: out bool Hover_Previous_22, Select_All_Out: out bool Select_All_23, Scale_Out: out bool Scale_24, Rotate_Out: out bool Rotate_25, Translate_Out: out bool Translate_26, Undo_Out: out bool Undo_27, Redo_Out: out bool Redo_28);
            var Output_32 = this.__p_DckXKv6MO4fNMfoYOX7dKj.Update(Value_In: Mouse_Pressed_15, Up_Edge_Out: out bool Up_Edge_30, Down_Edge_Out: out bool Down_Edge_31);
            n20._Operations_.HoverWithKeys<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_13, Hover_Next_In: Hover_Next_21, Hover_Previous_In: Hover_Previous_22, Hover_Control_In: Hover_Control_6, Mouse_Pressed_In: Up_Edge_30, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_33);
            n20._Operations_.GetAllEditablePoints<n3.Vector2>(BezierPoint_In: Output_33, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points_34);
            var Output_45 = this.__p_S7jnNuF3fE1PnRslJiJYdk.Update(Points_In: Points_34, PointEditor_Controls_In: PointEditorControls_5, View_In: ViewProjection_In, Pick_Size_In: Pick_Size_In, Step_Size_In: Step_Size_In, Gizmo_Size_In: Gizmo_Size_In, Camera_Zoom_In: Camera_Zoom_In, Camera_Idle_In: Camera_Idle_In, Gizmo_Controls_In: Gizmo_Controls_In, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Points_35, Result_Out: out n10.Spread<n3.Vector2> Result_36, Editing_Out: out bool Editing_37, Selection_Changed_Out: out bool Selection_Changed_38, Selection_Updated_Out: out bool Selection_Updated_39, Translate_Out: out bool Translate_40, Rotate_Out: out bool Rotate_41, Scale_Out: out bool Scale_42, Offset_Out: out n3.Vector2 Offset_43, GizmoState_Out: out n34.GizmoState_R GizmoState_44);
            n20._Operations_.UpdateBezierKnots<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_33, New_Positions_In: Points_35, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_46);
            var Output_47 = Selection_Updated_39 || Output_12;
            BezierPoints_Out = Output_46;
            Editing_Out = Editing_37;
            Selection_Changed_Out = Selection_Changed_38;
            Selection_Updated_Out = Output_47;
            Translate_Out = Translate_40;
            Rotate_Out = Rotate_41;
            Scale_Out = Scale_42;
            Offset_Out = Offset_43;
            GizmoState_Out = GizmoState_44;
            n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC that_48 = this;
            if (this.__GetContext__().IsImmutable)
                that_48 = Output_32 != this.__p_DckXKv6MO4fNMfoYOX7dKj || Output_45 != this.__p_S7jnNuF3fE1PnRslJiJYdk ? new BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(this)
                {__p_DckXKv6MO4fNMfoYOX7dKj = Output_32, __p_S7jnNuF3fE1PnRslJiJYdk = Output_45} : that_48;
            else
            {
                this.__p_DckXKv6MO4fNMfoYOX7dKj = Output_32;
                this.__p_S7jnNuF3fE1PnRslJiJYdk = Output_45;
            }

            return that_48;
        }

        public n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "S7jnNuF3fE1PnRslJiJYdk", 81668U);
            var Output_1 = n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "DckXKv6MO4fNMfoYOX7dKj", 82597U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC that_4 = this;
            this.__p_S7jnNuF3fE1PnRslJiJYdk = Output_1;
            this.__p_DckXKv6MO4fNMfoYOX7dKj = Output_3;
            return that_4;
        }

        public n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC __CreateDefault__()
        {
            n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC that_0 = this;
            this.__p_DckXKv6MO4fNMfoYOX7dKj = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_S7jnNuF3fE1PnRslJiJYdk = n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DckXKv6MO4fNMfoYOX7dKj);
            n1.CompilationHelper.SafeDispose(this.__p_S7jnNuF3fE1PnRslJiJYdk);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 82597U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DckXKv6MO4fNMfoYOX7dKj", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_DckXKv6MO4fNMfoYOX7dKj;
        [n1.ElementAttribute(TracingId = 81668U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "S7jnNuF3fE1PnRslJiJYdk", Name = "PointManipulator2d", IsManaged = true, IsAutoGenerated = true)]
        public n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_S7jnNuF3fE1PnRslJiJYdk;
        public BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC other): base(other)
        {
            this.__p_DckXKv6MO4fNMfoYOX7dKj = other.__p_DckXKv6MO4fNMfoYOX7dKj;
            this.__p_S7jnNuF3fE1PnRslJiJYdk = other.__p_S7jnNuF3fE1PnRslJiJYdk;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DckXKv6MO4fNMfoYOX7dKj", in __p_DckXKv6MO4fNMfoYOX7dKj), n1.CompilationHelper.GetValueOrExisting(values, "__p_S7jnNuF3fE1PnRslJiJYdk", in __p_S7jnNuF3fE1PnRslJiJYdk));
        }

        internal BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC __WITH__(n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_DckXKv6MO4fNMfoYOX7dKj, n52.PointManipulator2d_SRoT7IhKCRiLCRQU6fZSAJ<n10.Spread<n8.EditablePoint_R<n3.Vector2>>> __p_S7jnNuF3fE1PnRslJiJYdk)
        {
            n52.BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DckXKv6MO4fNMfoYOX7dKj != this.__p_DckXKv6MO4fNMfoYOX7dKj || __p_S7jnNuF3fE1PnRslJiJYdk != this.__p_S7jnNuF3fE1PnRslJiJYdk ? new BezierKnotManipulator2d_SQh00YNQ1ZOO1t9hOnsSjC(this)
                {__p_DckXKv6MO4fNMfoYOX7dKj = __p_DckXKv6MO4fNMfoYOX7dKj, __p_S7jnNuF3fE1PnRslJiJYdk = __p_S7jnNuF3fE1PnRslJiJYdk} : that_0;
            else
            {
                this.__p_DckXKv6MO4fNMfoYOX7dKj = __p_DckXKv6MO4fNMfoYOX7dKj;
                this.__p_S7jnNuF3fE1PnRslJiJYdk = __p_S7jnNuF3fE1PnRslJiJYdk;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void EditPoints2d<T>(T Points_In, n3.Vector2 Center_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Editing_In, n3.Vector2 Translate_In, float Rotate_In, n3.Vector2 Scale_In, out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Outputs_Out, out n10.Spread<n3.Vector2> Result_Out)
            where T : n23.IEnumerable<n8.EditablePoint_R<n3.Vector2>>
        {
            n10.Spread<n8.EditablePoint_R<n3.Vector2>> __cp_UGCN8sSKqPtPFjiOBTQPGS = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector2>>();
            n10.Spread<n3.Vector2> __cp_K09mQPYExUzOiPnXacTPh2 = n14._Operations_.CreateDefault<n3.Vector2>();
            var builder_13 = n6.CollectionBuilders.GetBuilder(__cp_UGCN8sSKqPtPFjiOBTQPGS, 16);
            n10.Spread<n8.EditablePoint_R<n3.Vector2>> output_14;
            var builder_15 = n6.CollectionBuilders.GetBuilder(__cp_K09mQPYExUzOiPnXacTPh2, 16);
            n10.Spread<n3.Vector2> output_16;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Points_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    var Output_5 = splicer_1.GetSelected(Selected_Out: out bool Selected_4);
                    var Output_7 = splicer_1.GetPosition(Position_Out: out n3.Vector2 Position_6);
                    var Output_8 = Selected_4 && Editing_In;
                    var Output_9 = Position_6;
                    if (Output_8)
                    {
                        n31._Operations_.Translate<n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Position_6, Offset_In: Translate_In, Output_Out: out Output_9);
                    }

                    var Output_10 = Output_9;
                    if (Output_8)
                    {
                        n52._Operations_.Rotate(Input_In: Output_9, Center_In: Center_In, Offset_In: Rotate_In, Output_Out: out Output_10);
                    }

                    var Output_11 = Output_10;
                    if (Output_8)
                    {
                        n52._Operations_.Scale(Input_In: Output_10, Center_In: Center_In, Offset_In: Scale_In, Output_Out: out Output_11);
                    }

                    var Output_12 = splicer_1.SetPosition(Position_In: Output_11);
                    builder_13.Add(Output_12);
                    builder_15.Add(Output_11);
                    i_2++;
                }
            }
            finally
            {
                output_14 = builder_13.Commit();
                output_16 = builder_15.Commit();
            }

            Outputs_Out = output_14;
            Result_Out = output_16;
            return;
        }

        public static void Scale(n3.Vector2 Input_In, n3.Vector2 Center_In, n3.Vector2 Offset_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2 __pad_NATSTgXyp1wMmebx0pcfEP_0 = __slot_NATSTgXyp1wMmebx0pcfEP;
            n3.Vector2.Subtract(left: ref Input_In, right: ref Center_In, result: out n3.Vector2 Output_1);
            n3.Vector2.Add(left: ref Offset_In, right: ref __pad_NATSTgXyp1wMmebx0pcfEP_0, result: out n3.Vector2 Output_2);
            n3.Matrix Input_3 = n55._Operations_.CreateDefault();
            n56._Operations_.Scale(Input_In: Input_3, Scaling_In: Output_2, Output_Out: out n3.Matrix Output_4);
            n3.Vector2.TransformCoordinate(coordinate: ref Output_1, transform: ref Output_4, result: out n3.Vector2 Output_5);
            n3.Vector2.Add(left: ref Output_5, right: ref Center_In, result: out n3.Vector2 Output_6);
            Output_Out = Output_6;
            return;
        }

        public static void Rotate(n3.Vector2 Input_In, n3.Vector2 Center_In, float Offset_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Subtract(left: ref Input_In, right: ref Center_In, result: out n3.Vector2 Output_0);
            n3.Matrix Input_1 = n55._Operations_.CreateDefault();
            n56._Operations_.Rotate(Input_In: Input_1, Rotation_In: Offset_In, Output_Out: out n3.Matrix Output_2);
            n3.Vector2.TransformCoordinate(coordinate: ref Output_0, transform: ref Output_2, result: out n3.Vector2 Output_3);
            n3.Vector2.Add(left: ref Output_3, right: ref Center_In, result: out n3.Vector2 Output_4);
            Output_Out = Output_4;
            return;
        }

        [n1.ElementAttribute(TracingId = 81034U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NATSTgXyp1wMmebx0pcfEP", Name = "__slot_NATSTgXyp1wMmebx0pcfEP")]
        public static n3.Vector2 __slot_NATSTgXyp1wMmebx0pcfEP = n1.CompilationHelper.Deserialize<n3.Vector2>("1, 1", false, "RMDMfKmnIrVPStLdWe8u30", "NATSTgXyp1wMmebx0pcfEP");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Editors_.Editors._2D.Advanced
{
    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ToXYZ(n3.Vector2 Vector_In, out n3.Vector3 Output_Out)
        {
            n46.Vector2Nodes.Vector(input: ref Vector_In, x: out float X_0, y: out float Y_1);
            float Z_2 = 0F;
            var Output_3 = new n3.Vector3(x: X_0, y: Y_1, z: Z_2);
            Output_Out = Output_3;
            return;
        }
    }
}

namespace _VL_Editors_.Editors._3D
{
    [n1.ElementAttribute(TracingId = 84994U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QJexiIR3G9OL3pu257uaG0", Name = "PointEditor_QJexiIR3G9OL3pu257uaG0")]
    [n2.SerializableAttribute]
    public class PointEditor_QJexiIR3G9OL3pu257uaG0 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n36.PointEditor_QJexiIR3G9OL3pu257uaG0 Create(n1.NodeContext Node_Context)
        {
            var instance = new PointEditor_QJexiIR3G9OL3pu257uaG0(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n36.PointEditor_QJexiIR3G9OL3pu257uaG0 CreateDefault()
        {
            var instance = new PointEditor_QJexiIR3G9OL3pu257uaG0(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.PointEditor_QJexiIR3G9OL3pu257uaG0 Update(n23.IEnumerable<n3.Vector3> Points_To_Add_In, bool Add_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Clear_In, n23.IEnumerable<bool> Locked_In, n8.PointEditorControlsData_R PointEditor_Controls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, n3.Matrix View_Projection_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, n17.Path File_Path_In, bool Load_In, bool Save_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, out n8.PointEditorState_R<n3.Vector3, float, bool, bool, bool, bool, n3.Vector3> PointEditor_State_Out, out n10.Spread<n3.Vector3> Points_Out, out n10.Spread<int> Ids_Out, out bool Idle_Out)
        {
            int __auto_0 = this.Current_Id;
            int __pad_KaAcqAMuAScPCjPzTjNZAy_1 = __slot_KaAcqAMuAScPCjPzTjNZAy;
            n10.Spread<n8.EditablePoint_R<n3.Vector3>> __auto_2 = this.Points;
            var Output_5 = this.__p_LZck7GBcmGEP4q7TDdTuW8.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(File_Path_In: File_Path_In, Read_In: Load_In, Result_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Result_3, On_Data_Out: out bool On_Data_4);
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>(Condition_In: On_Data_4, Input_In: __auto_2, Input_2_In: Result_3, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Output_6);
            n31._Operations_.SetLockState<n3.Vector3, n23.IEnumerable<bool>>(Spread_In: Output_6, Lockeds_In: Locked_In, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Outputs_7);
            var Output_23 = PointEditor_Controls_In.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_8, Mouse_Pressed_Out: out bool Mouse_Pressed_9, Selection_Out: out n3.RectangleF Selection_10, Remove_Selected_Out: out bool Remove_Selected_11, Control_Out: out bool Control_12, Shift_Out: out bool Shift_13, Space_Out: out bool Space_14, Hover_Next_Out: out bool Hover_Next_15, Hover_Previous_Out: out bool Hover_Previous_16, Select_All_Out: out bool Select_All_17, Scale_Out: out bool Scale_18, Rotate_Out: out bool Rotate_19, Translate_Out: out bool Translate_20, Undo_Out: out bool Undo_21, Redo_Out: out bool Redo_22);
            bool Mouse_Pressed_24 = false;
            n31._Operations_.HoverWithKeys<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Outputs_7, Hover_Next_In: Hover_Next_15, Hover_Previous_In: Hover_Previous_16, Mouse_Pressed_In: Mouse_Pressed_24, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Output_25);
            var Output_35 = this.__p_VQA2VYDYO7PMaU88IbuVOr.Update(Points_In: Output_25, PointEditor_Controls_In: PointEditor_Controls_In, Gizmo_Controls_In: Gizmo_Controls_In, Step_Size_In: Step_Size_In, Gizmo_Size_In: Gizmo_Size_In, ViewProjection_In: View_Projection_In, Camera_Idle_In: Camera_Idle_In, Pick_Size_In: Pick_Size_In, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_26, Result_Out: out n10.Spread<n3.Vector3> Result_27, Editing_Out: out bool Editing_28, Selection_Updated_Out: out bool Selection_Updated_29, Scale_Out: out bool Scale_30, Rotate_Out: out bool Rotate_31, Translate_Out: out bool Translate_32, Offset_Out: out n3.Vector3 Offset_33, GizmoState_Out: out n34.GizmoState_R GizmoState_34);
            n31._Operations_.AddRemovePoints<n3.Vector3, n23.IEnumerable<n3.Vector3>, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Current_Id_In: __auto_0, Points_In: Points_26, Points_To_Add_In: Points_To_Add_In, Add_In: Add_In, Clear_In: Clear_In, Remove_Selected_In: Remove_Selected_11, Current_Id_Out: out int Current_Id_36, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_37);
            var Output_40 = this.__p_VtbFLzMZ6a6PSMU8DGDF2B.Update(Value_In: Editing_28, Up_Edge_Out: out bool Up_Edge_38, Down_Edge_Out: out bool Down_Edge_39);
            var Output_41 = Add_In || Down_Edge_39;
            var Output_45 = this.__p_RuJfUqfdxNTPLXe0oAyoc5.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Clear_In: Clear_In, Item_In: Points_37, Levels_In: __pad_KaAcqAMuAScPCjPzTjNZAy_1, Push_In: Output_41, Undo_In: Undo_21, Redo_In: Redo_22, Result_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Result_42, Count_Out: out int Count_43, Pointer_Out: out int Pointer_44);
            n23.IEnumerable<n8.EditablePoint_R<n3.Vector3>> EditablePoints_46 = (n23.IEnumerable<n8.EditablePoint_R<n3.Vector3>>)Result_42;
            n8.PointEditorState_R<n3.Vector3, float, bool, bool, bool, bool, n3.Vector3> Input_47 = n8.PointEditorState_R<n3.Vector3, float, bool, bool, bool, bool, n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            bool Is_Projection_Space_48 = false;
            var Output_49 = Input_47.Join(EditablePoints_In: EditablePoints_46, Pick_Size_In: Pick_Size_In, Editing_In: Editing_28, Scaling_In: Scale_30, Rotation_In: Rotate_31, Translation_In: Translate_32, Offset_In: Offset_33, Is_Projection_Space_In: Is_Projection_Space_48, GizmoState_In: GizmoState_34);
            bool Update_50 = true;
            var Output_51 = this.__p_R8vcVZlFr3EMebkmsYL3js;
            if (Update_50)
            {
                Output_51 = this.__p_R8vcVZlFr3EMebkmsYL3js.Update<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>(Data_In: Result_42, File_Path_In: File_Path_In, Write_In: Save_In);
            }

            var Output_52 = Editing_28 || Undo_21;
            var Output_53 = Output_52 || Redo_22;
            var Output_54 = !Output_53;
            int __pad_RLe1lTrl43tLEyW1Oh2q3K_55 = Count_43;
            int __pad_F33WUGFGci9PhojRCofxvV_56 = Pointer_44;
            n10.Spread<n8.EditablePoint_R<n3.Vector3>> __auto_57 = Result_42;
            var builder_71 = n6.CollectionBuilders.GetBuilder(this.__cp_IT4rz7bXxXcMrIM5RZdjOn, 16);
            n10.Spread<n3.Vector3> output_72;
            var builder_73 = n6.CollectionBuilders.GetBuilder(this.__cp_UuNsgqUKqIFMQdB1gYMecy, 16);
            n10.Spread<int> output_74;
            try
            {
                var i_60 = 0;
                foreach (var item_58 in n6.CollectionExtensions.AsSpan(Result_42))
                {
                    var splicer_59 = item_58;
                    var i_local_61 = i_60;
                    var Output_70 = splicer_59.Split(Position_Out: out n3.Vector3 Position_63, Locked_Out: out bool Locked_64, Selected_Out: out bool Selected_65, Hovered_Out: out bool Hovered_66, KeyHovered_Out: out bool KeyHovered_67, SelectionModifier_Out: out int SelectionModifier_68, Id_Out: out int Id_69);
                    builder_71.Add(Position_63);
                    builder_73.Add(Id_69);
                    i_60++;
                }
            }
            finally
            {
                output_72 = builder_71.Commit();
                output_74 = builder_73.Commit();
            }

            int __auto_75 = Current_Id_36;
            PointEditor_State_Out = Output_49;
            Points_Out = output_72;
            Ids_Out = output_74;
            Idle_Out = Output_54;
            n36.PointEditor_QJexiIR3G9OL3pu257uaG0 that_76 = this;
            if (this.__GetContext__().IsImmutable)
                that_76 = Output_5 != this.__p_LZck7GBcmGEP4q7TDdTuW8 || Output_35 != this.__p_VQA2VYDYO7PMaU88IbuVOr || Output_40 != this.__p_VtbFLzMZ6a6PSMU8DGDF2B || Output_45 != this.__p_RuJfUqfdxNTPLXe0oAyoc5 || Output_51 != this.__p_R8vcVZlFr3EMebkmsYL3js || Count_43 != this.__slot_RLe1lTrl43tLEyW1Oh2q3K || Pointer_44 != this.__slot_F33WUGFGci9PhojRCofxvV || Result_42 != this.Points || output_72 != this.__cp_IT4rz7bXxXcMrIM5RZdjOn || output_74 != this.__cp_UuNsgqUKqIFMQdB1gYMecy || Current_Id_36 != this.Current_Id ? new PointEditor_QJexiIR3G9OL3pu257uaG0(this)
                {__p_LZck7GBcmGEP4q7TDdTuW8 = Output_5, __p_VQA2VYDYO7PMaU88IbuVOr = Output_35, __p_VtbFLzMZ6a6PSMU8DGDF2B = Output_40, __p_RuJfUqfdxNTPLXe0oAyoc5 = Output_45, __p_R8vcVZlFr3EMebkmsYL3js = Output_51, __slot_RLe1lTrl43tLEyW1Oh2q3K = Count_43, __slot_F33WUGFGci9PhojRCofxvV = Pointer_44, Points = Result_42, __cp_IT4rz7bXxXcMrIM5RZdjOn = output_72, __cp_UuNsgqUKqIFMQdB1gYMecy = output_74, Current_Id = Current_Id_36} : that_76;
            else
            {
                this.__p_LZck7GBcmGEP4q7TDdTuW8 = Output_5;
                this.__p_VQA2VYDYO7PMaU88IbuVOr = Output_35;
                this.__p_VtbFLzMZ6a6PSMU8DGDF2B = Output_40;
                this.__p_RuJfUqfdxNTPLXe0oAyoc5 = Output_45;
                this.__p_R8vcVZlFr3EMebkmsYL3js = Output_51;
                this.__slot_RLe1lTrl43tLEyW1Oh2q3K = Count_43;
                this.__slot_F33WUGFGci9PhojRCofxvV = Pointer_44;
                this.Points = Result_42;
                this.__cp_IT4rz7bXxXcMrIM5RZdjOn = output_72;
                this.__cp_UuNsgqUKqIFMQdB1gYMecy = output_74;
                this.Current_Id = Current_Id_36;
            }

            return that_76;
        }

        public n36.PointEditor_QJexiIR3G9OL3pu257uaG0 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "VQA2VYDYO7PMaU88IbuVOr", 85114U);
            var Output_1 = n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "VtbFLzMZ6a6PSMU8DGDF2B", 85170U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RuJfUqfdxNTPLXe0oAyoc5", 85193U);
            var Output_5 = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LZck7GBcmGEP4q7TDdTuW8", 85430U);
            var Output_7 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "R8vcVZlFr3EMebkmsYL3js", 85443U);
            var Output_9 = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.Create(Node_Context: Node_Context_8);
            n36.PointEditor_QJexiIR3G9OL3pu257uaG0 that_10 = this;
            this.Points = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector3>>();
            this.Current_Id = 0;
            this.__slot_RLe1lTrl43tLEyW1Oh2q3K = 0;
            this.__slot_F33WUGFGci9PhojRCofxvV = 0;
            this.__cp_IT4rz7bXxXcMrIM5RZdjOn = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__cp_UuNsgqUKqIFMQdB1gYMecy = n14._Operations_.CreateDefault<int>();
            this.__p_VQA2VYDYO7PMaU88IbuVOr = Output_1;
            this.__p_VtbFLzMZ6a6PSMU8DGDF2B = Output_3;
            this.__p_RuJfUqfdxNTPLXe0oAyoc5 = Output_5;
            this.__p_LZck7GBcmGEP4q7TDdTuW8 = Output_7;
            this.__p_R8vcVZlFr3EMebkmsYL3js = Output_9;
            return that_10;
        }

        public n36.PointEditor_QJexiIR3G9OL3pu257uaG0 __CreateDefault__()
        {
            n36.PointEditor_QJexiIR3G9OL3pu257uaG0 that_0 = this;
            this.Points = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector3>>();
            this.Current_Id = 0;
            this.__slot_RLe1lTrl43tLEyW1Oh2q3K = 0;
            this.__slot_F33WUGFGci9PhojRCofxvV = 0;
            this.__cp_IT4rz7bXxXcMrIM5RZdjOn = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__cp_UuNsgqUKqIFMQdB1gYMecy = n14._Operations_.CreateDefault<int>();
            this.__p_LZck7GBcmGEP4q7TDdTuW8 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_VQA2VYDYO7PMaU88IbuVOr = n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.CreateDefault();
            this.__p_VtbFLzMZ6a6PSMU8DGDF2B = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_RuJfUqfdxNTPLXe0oAyoc5 = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.CreateDefault();
            this.__p_R8vcVZlFr3EMebkmsYL3js = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LZck7GBcmGEP4q7TDdTuW8);
            n1.CompilationHelper.SafeDispose(this.__p_VQA2VYDYO7PMaU88IbuVOr);
            n1.CompilationHelper.SafeDispose(this.__p_VtbFLzMZ6a6PSMU8DGDF2B);
            n1.CompilationHelper.SafeDispose(this.__p_RuJfUqfdxNTPLXe0oAyoc5);
            n1.CompilationHelper.SafeDispose(this.__p_R8vcVZlFr3EMebkmsYL3js);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 84999U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Un7gI6kLxLrOmKqw5NLACv", Name = "Points")]
        public n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points;
        [n1.ElementAttribute(TracingId = 85001U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I4EPcH0gVxwOd0RBzh9vmW", Name = "Current Id")]
        public int Current_Id;
        [n1.ElementAttribute(TracingId = 85070U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KaAcqAMuAScPCjPzTjNZAy", Name = "__slot_KaAcqAMuAScPCjPzTjNZAy")]
        public static int __slot_KaAcqAMuAScPCjPzTjNZAy = 50;
        [n1.ElementAttribute(TracingId = 85218U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RLe1lTrl43tLEyW1Oh2q3K", Name = "__slot_RLe1lTrl43tLEyW1Oh2q3K")]
        public int __slot_RLe1lTrl43tLEyW1Oh2q3K;
        [n1.ElementAttribute(TracingId = 85219U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F33WUGFGci9PhojRCofxvV", Name = "__slot_F33WUGFGci9PhojRCofxvV")]
        public int __slot_F33WUGFGci9PhojRCofxvV;
        [n1.ElementAttribute(TracingId = 85430U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LZck7GBcmGEP4q7TDdTuW8", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_LZck7GBcmGEP4q7TDdTuW8;
        [n1.ElementAttribute(TracingId = 85114U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VQA2VYDYO7PMaU88IbuVOr", Name = "PointManipulator3d", IsManaged = true, IsAutoGenerated = true)]
        public n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_VQA2VYDYO7PMaU88IbuVOr;
        [n1.ElementAttribute(TracingId = 85170U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VtbFLzMZ6a6PSMU8DGDF2B", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VtbFLzMZ6a6PSMU8DGDF2B;
        [n1.ElementAttribute(TracingId = 85193U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RuJfUqfdxNTPLXe0oAyoc5", Name = "Undo", IsManaged = true, IsAutoGenerated = true)]
        public n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_RuJfUqfdxNTPLXe0oAyoc5;
        [n1.ElementAttribute(TracingId = 85443U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "R8vcVZlFr3EMebkmsYL3js", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_R8vcVZlFr3EMebkmsYL3js;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __cp_IT4rz7bXxXcMrIM5RZdjOn;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<int> __cp_UuNsgqUKqIFMQdB1gYMecy;
        static PointEditor_QJexiIR3G9OL3pu257uaG0()
        {
        }

        public PointEditor_QJexiIR3G9OL3pu257uaG0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditor_QJexiIR3G9OL3pu257uaG0(PointEditor_QJexiIR3G9OL3pu257uaG0 other): base(other)
        {
            this.Points = other.Points;
            this.Current_Id = other.Current_Id;
            this.__slot_RLe1lTrl43tLEyW1Oh2q3K = other.__slot_RLe1lTrl43tLEyW1Oh2q3K;
            this.__slot_F33WUGFGci9PhojRCofxvV = other.__slot_F33WUGFGci9PhojRCofxvV;
            this.__p_LZck7GBcmGEP4q7TDdTuW8 = other.__p_LZck7GBcmGEP4q7TDdTuW8;
            this.__p_VQA2VYDYO7PMaU88IbuVOr = other.__p_VQA2VYDYO7PMaU88IbuVOr;
            this.__p_VtbFLzMZ6a6PSMU8DGDF2B = other.__p_VtbFLzMZ6a6PSMU8DGDF2B;
            this.__p_RuJfUqfdxNTPLXe0oAyoc5 = other.__p_RuJfUqfdxNTPLXe0oAyoc5;
            this.__p_R8vcVZlFr3EMebkmsYL3js = other.__p_R8vcVZlFr3EMebkmsYL3js;
            this.__cp_IT4rz7bXxXcMrIM5RZdjOn = other.__cp_IT4rz7bXxXcMrIM5RZdjOn;
            this.__cp_UuNsgqUKqIFMQdB1gYMecy = other.__cp_UuNsgqUKqIFMQdB1gYMecy;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Points", in Points), n1.CompilationHelper.GetValueOrExisting(values, "Current_Id", in Current_Id), n1.CompilationHelper.GetValueOrExisting(values, "__slot_RLe1lTrl43tLEyW1Oh2q3K", in __slot_RLe1lTrl43tLEyW1Oh2q3K), n1.CompilationHelper.GetValueOrExisting(values, "__slot_F33WUGFGci9PhojRCofxvV", in __slot_F33WUGFGci9PhojRCofxvV), n1.CompilationHelper.GetValueOrExisting(values, "__p_LZck7GBcmGEP4q7TDdTuW8", in __p_LZck7GBcmGEP4q7TDdTuW8), n1.CompilationHelper.GetValueOrExisting(values, "__p_VQA2VYDYO7PMaU88IbuVOr", in __p_VQA2VYDYO7PMaU88IbuVOr), n1.CompilationHelper.GetValueOrExisting(values, "__p_VtbFLzMZ6a6PSMU8DGDF2B", in __p_VtbFLzMZ6a6PSMU8DGDF2B), n1.CompilationHelper.GetValueOrExisting(values, "__p_RuJfUqfdxNTPLXe0oAyoc5", in __p_RuJfUqfdxNTPLXe0oAyoc5), n1.CompilationHelper.GetValueOrExisting(values, "__p_R8vcVZlFr3EMebkmsYL3js", in __p_R8vcVZlFr3EMebkmsYL3js), n1.CompilationHelper.GetValueOrExisting(values, "__cp_IT4rz7bXxXcMrIM5RZdjOn", in __cp_IT4rz7bXxXcMrIM5RZdjOn), n1.CompilationHelper.GetValueOrExisting(values, "__cp_UuNsgqUKqIFMQdB1gYMecy", in __cp_UuNsgqUKqIFMQdB1gYMecy));
        }

        internal PointEditor_QJexiIR3G9OL3pu257uaG0 __WITH__(n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points, int Current_Id, int __slot_RLe1lTrl43tLEyW1Oh2q3K, int __slot_F33WUGFGci9PhojRCofxvV, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_LZck7GBcmGEP4q7TDdTuW8, n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_VQA2VYDYO7PMaU88IbuVOr, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VtbFLzMZ6a6PSMU8DGDF2B, n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_RuJfUqfdxNTPLXe0oAyoc5, n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_R8vcVZlFr3EMebkmsYL3js, n10.Spread<n3.Vector3> __cp_IT4rz7bXxXcMrIM5RZdjOn, n10.Spread<int> __cp_UuNsgqUKqIFMQdB1gYMecy)
        {
            n36.PointEditor_QJexiIR3G9OL3pu257uaG0 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Points != this.Points || Current_Id != this.Current_Id || __slot_RLe1lTrl43tLEyW1Oh2q3K != this.__slot_RLe1lTrl43tLEyW1Oh2q3K || __slot_F33WUGFGci9PhojRCofxvV != this.__slot_F33WUGFGci9PhojRCofxvV || __p_LZck7GBcmGEP4q7TDdTuW8 != this.__p_LZck7GBcmGEP4q7TDdTuW8 || __p_VQA2VYDYO7PMaU88IbuVOr != this.__p_VQA2VYDYO7PMaU88IbuVOr || __p_VtbFLzMZ6a6PSMU8DGDF2B != this.__p_VtbFLzMZ6a6PSMU8DGDF2B || __p_RuJfUqfdxNTPLXe0oAyoc5 != this.__p_RuJfUqfdxNTPLXe0oAyoc5 || __p_R8vcVZlFr3EMebkmsYL3js != this.__p_R8vcVZlFr3EMebkmsYL3js || __cp_IT4rz7bXxXcMrIM5RZdjOn != this.__cp_IT4rz7bXxXcMrIM5RZdjOn || __cp_UuNsgqUKqIFMQdB1gYMecy != this.__cp_UuNsgqUKqIFMQdB1gYMecy ? new PointEditor_QJexiIR3G9OL3pu257uaG0(this)
                {Points = Points, Current_Id = Current_Id, __slot_RLe1lTrl43tLEyW1Oh2q3K = __slot_RLe1lTrl43tLEyW1Oh2q3K, __slot_F33WUGFGci9PhojRCofxvV = __slot_F33WUGFGci9PhojRCofxvV, __p_LZck7GBcmGEP4q7TDdTuW8 = __p_LZck7GBcmGEP4q7TDdTuW8, __p_VQA2VYDYO7PMaU88IbuVOr = __p_VQA2VYDYO7PMaU88IbuVOr, __p_VtbFLzMZ6a6PSMU8DGDF2B = __p_VtbFLzMZ6a6PSMU8DGDF2B, __p_RuJfUqfdxNTPLXe0oAyoc5 = __p_RuJfUqfdxNTPLXe0oAyoc5, __p_R8vcVZlFr3EMebkmsYL3js = __p_R8vcVZlFr3EMebkmsYL3js, __cp_IT4rz7bXxXcMrIM5RZdjOn = __cp_IT4rz7bXxXcMrIM5RZdjOn, __cp_UuNsgqUKqIFMQdB1gYMecy = __cp_UuNsgqUKqIFMQdB1gYMecy} : that_0;
            else
            {
                this.Points = Points;
                this.Current_Id = Current_Id;
                this.__slot_RLe1lTrl43tLEyW1Oh2q3K = __slot_RLe1lTrl43tLEyW1Oh2q3K;
                this.__slot_F33WUGFGci9PhojRCofxvV = __slot_F33WUGFGci9PhojRCofxvV;
                this.__p_LZck7GBcmGEP4q7TDdTuW8 = __p_LZck7GBcmGEP4q7TDdTuW8;
                this.__p_VQA2VYDYO7PMaU88IbuVOr = __p_VQA2VYDYO7PMaU88IbuVOr;
                this.__p_VtbFLzMZ6a6PSMU8DGDF2B = __p_VtbFLzMZ6a6PSMU8DGDF2B;
                this.__p_RuJfUqfdxNTPLXe0oAyoc5 = __p_RuJfUqfdxNTPLXe0oAyoc5;
                this.__p_R8vcVZlFr3EMebkmsYL3js = __p_R8vcVZlFr3EMebkmsYL3js;
                this.__cp_IT4rz7bXxXcMrIM5RZdjOn = __cp_IT4rz7bXxXcMrIM5RZdjOn;
                this.__cp_UuNsgqUKqIFMQdB1gYMecy = __cp_UuNsgqUKqIFMQdB1gYMecy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 98053U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BdxOemVoWItPgBnY4q8s91", Name = "BezierEditor_BdxOemVoWItPgBnY4q8s91")]
    [n2.SerializableAttribute]
    public class BezierEditor_BdxOemVoWItPgBnY4q8s91 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 Create(n1.NodeContext Node_Context)
        {
            var instance = new BezierEditor_BdxOemVoWItPgBnY4q8s91(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 CreateDefault()
        {
            var instance = new BezierEditor_BdxOemVoWItPgBnY4q8s91(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 Update<T>(T Knots_To_Add_In, bool Add_Knot_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Add_and_Smooth_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Insert_Knot_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Clear_In, n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, n3.Matrix ViewProjection_In, n17.Path File_Path_In, bool Load_In, bool Save_In, out n8.BezierEditorState_R<n3.Vector3, float, n3.Vector3, bool, bool, bool, n3.Vector3, bool, bool> BezierEditorState_Out, out n30.BezierSpline_R<n3.Vector3> BezierSpline_Out, out bool Idle_Out)
            where T : n23.IEnumerable<n22.BezierKnot_R<n3.Vector3>>
        {
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> __auto_0 = this.BezierKnots;
            int __pad_PadyZsNsymfPVFUpWF7GQZ_1 = __slot_PadyZsNsymfPVFUpWF7GQZ;
            int __pad_MGQwXsbWEtZLWTGBGya2e3_2 = __slot_MGQwXsbWEtZLWTGBGya2e3;
            int __auto_3 = this.Current_Id;
            var Output_4 = Add_Knot_In || Add_and_Smooth_In;
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Knot_5;
            int Current_Id_6;
            var state_7 = n1.CompilationHelper.Restore<__JIqYc85o8rYQcbR16qJeuu>(this.__if_KE3pg3ZuhMfOiUpnMkNAE3, __GetContext__());
            if (Output_4)
            {
                if (state_7 == null)
                {
                    state_7 = new __JIqYc85o8rYQcbR16qJeuu(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_V8Y5fSXLKUzPI0qrEVeWbN = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>()};
                }

                int accumulator_9 = __auto_3;
                var builder_16 = n6.CollectionBuilders.GetBuilder(state_7.__cp_V8Y5fSXLKUzPI0qrEVeWbN, 16);
                n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> output_17;
                try
                {
                    var i_11 = 0;
                    foreach (var item_8 in Knots_To_Add_In)
                    {
                        var splicer_10 = item_8;
                        var i_local_12 = i_11;
                        n20._Operations_.ToEditableBezierKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(BezierKnot_In: splicer_10, Next_Id_In: accumulator_9, EditableBezierKnot_Out: out n8.EditableBezierKnot_R<n3.Vector3> EditableBezierKnot_14, Next_Id_Out: out int Next_Id_15);
                        builder_16.Add(EditableBezierKnot_14);
                        accumulator_9 = Next_Id_15;
                        i_11++;
                    }
                }
                finally
                {
                    output_17 = builder_16.Commit();
                }

                Knot_5 = output_17;
                Current_Id_6 = accumulator_9;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_17 != state_7.__cp_V8Y5fSXLKUzPI0qrEVeWbN ? new __JIqYc85o8rYQcbR16qJeuu(state_7)
                    {__cp_V8Y5fSXLKUzPI0qrEVeWbN = output_17} : state_7;
                else
                {
                    state_7.__cp_V8Y5fSXLKUzPI0qrEVeWbN = output_17;
                }
            }
            else
            {
                Knot_5 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>();
                Current_Id_6 = __auto_3;
            }

            var Output_26 = BezierEditorControls_In.Split(Corner_Out: out bool Corner_18, Corner_With_Handles_Out: out bool Corner_With_Handles_19, Smooth_Out: out bool Smooth_20, Smooth_Symmetric_Out: out bool Smooth_Symmetric_21, Find_Point_on_Curve_Out: out bool Find_Point_on_Curve_22, PointEditorControls_Out: out n8.PointEditorControlsData_R PointEditorControls_23, Hover_Control_Out: out bool Hover_Control_24, Force_Selection_Out: out bool Force_Selection_25);
            var Output_27 = !Find_Point_on_Curve_22;
            var Output_28 = Add_Knot_In;
            if (Output_27)
            {
                var Output_29 = Add_Knot_In || Add_and_Smooth_In;
                Output_28 = Output_29;
            }

            var Output_32 = this.__p_Ujv3yIXc7sqO4CUQqOsasT.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(File_Path_In: File_Path_In, Read_In: Load_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Result_30, On_Data_Out: out bool On_Data_31);
            n32._Operations_.Switch_Boolean<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>(Condition_In: On_Data_31, Input_In: __auto_0, Input_2_In: Result_30, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_33);
            n20._Operations_.ProjectPointsToScreen<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>, n3.Vector3>(BezierPoints_In: Output_33, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_34);
            var Output_50 = PointEditorControls_23.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_35, Mouse_Pressed_Out: out bool Mouse_Pressed_36, Selection_Out: out n3.RectangleF Selection_37, Remove_Selected_Out: out bool Remove_Selected_38, Control_Out: out bool Control_39, Shift_Out: out bool Shift_40, Space_Out: out bool Space_41, Hover_Next_Out: out bool Hover_Next_42, Hover_Previous_Out: out bool Hover_Previous_43, Select_All_Out: out bool Select_All_44, Scale_Out: out bool Scale_45, Rotate_Out: out bool Rotate_46, Translate_Out: out bool Translate_47, Undo_Out: out bool Undo_48, Redo_Out: out bool Redo_49);
            n20._Operations_.FindPositionOnSegment<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>, n3.Vector2, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(EditableBezierKnots_In: Output_34, Point_In: Pointer_Position_35, Iteration_Count_In: __pad_PadyZsNsymfPVFUpWF7GQZ_1, Sample_In: Find_Point_on_Curve_22, Segment_Index_Out: out int Segment_Index_51, Position_on_Segment_Out: out float Position_on_Segment_52);
            var Output_53 = Insert_Knot_In && Find_Point_on_Curve_22;
            n20._Operations_.InsertKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_33, Segment_Index_In: Segment_Index_51, Position_on_Segment_In: Position_on_Segment_52, Add_Knot_In: Output_53, Sample_Point_In: Find_Point_on_Curve_22, Next_Id_In: Current_Id_6, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_54, Sampled_Point_Out: out n3.Vector3 Sampled_Point_55, Next_Id_Out: out int Next_Id_56);
            n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> Input_2_57 = n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            n32._Operations_.Switch_Boolean<n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R>>(Condition_In: Find_Point_on_Curve_22, Input_In: BezierEditorControls_In, Input_2_In: Input_2_57, Output_Out: out n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> Output_58);
            bool Camera_Idle_59 = true;
            var Output_68 = this.__p_L5Y1yrgg7f8OlBCbXTSUyV.Update(BezierKnots_In: Output_54, BezierEditorControls_In: Output_58, Gizmo_Controls_In: Gizmo_Controls_In, Camera_Idle_In: Camera_Idle_59, Step_Size_In: Step_Size_In, Pick_Size_In: Pick_Size_In, Gizmo_Size_In: Gizmo_Size_In, ViewProjection_In: ViewProjection_In, BezierKnots_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots_60, Editing_Out: out bool Editing_61, Selection_Updated_Out: out bool Selection_Updated_62, Scale_Out: out bool Scale_63, Rotate_Out: out bool Rotate_64, Translate_Out: out bool Translate_65, Offset_Out: out n3.Vector3 Offset_66, GizmoState_Out: out n34.GizmoState_R GizmoState_67);
            var Output_69 = !Force_Selection_25;
            var Output_70 = Selection_Updated_62 && Output_69;
            var Output_71 = BezierKnots_60;
            if (Output_70)
            {
                n20._Operations_.CorrectSelection<n3.Vector3>(Input_In: BezierKnots_60, Output_Out: out Output_71);
            }

            n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector3>> Knots_to_Add_72 = (n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector3>>)Knot_5;
            n20._Operations_.AddRemoveBezierKnots<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_71, Knots_to_Add_In: Knots_to_Add_72, Add_In: Output_28, Smooth_In: Add_and_Smooth_In, Clear_In: Clear_In, Remove_Selected_In: Remove_Selected_38, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_73);
            var Output_74 = Output_4 || Clear_In;
            var Output_75 = Output_74 || Remove_Selected_38;
            var Output_76 = Output_75 || Insert_Knot_In;
            var Output_79 = this.__p_AbIUAdO5SrlMVDdKyHeQxy.Update(Value_In: Editing_61, Up_Edge_Out: out bool Up_Edge_77, Down_Edge_Out: out bool Down_Edge_78);
            var Output_80 = Output_76 || Down_Edge_78;
            var Output_84 = this.__p_B3ZBHxrygraPmwNo3QN6Th.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Clear_In: Clear_In, Item_In: Output_73, Levels_In: __pad_MGQwXsbWEtZLWTGBGya2e3_2, Push_In: Output_80, Undo_In: Undo_48, Redo_In: Redo_49, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Result_81, Count_Out: out int Count_82, Pointer_Out: out int Pointer_83);
            n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots_85 = (n23.IEnumerable<n8.EditableBezierKnot_R<n3.Vector3>>)Result_81;
            var Output_86 = Translate_65 || Translate_47;
            var Output_87 = Rotate_64 || Rotate_46;
            var Output_88 = Scale_63 || Scale_45;
            n8.BezierEditorState_R<n3.Vector3, float, n3.Vector3, bool, bool, bool, n3.Vector3, bool, bool> Input_89 = n8.BezierEditorState_R<n3.Vector3, float, n3.Vector3, bool, bool, bool, n3.Vector3, bool, bool>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            bool Is_Projection_Space_90 = false;
            var Output_91 = Input_89.Join(BezierKnots_In: BezierKnots_85, Pick_Size_In: Pick_Size_In, Offset_In: Offset_66, Translation_In: Output_86, Rotation_In: Output_87, Scaling_In: Output_88, Point_on_Curve_In: Sampled_Point_55, Looking_for_Point_In: Find_Point_on_Curve_22, Editing_In: Editing_61, Is_Projection_Space_In: Is_Projection_Space_90, GizmoState_In: GizmoState_67);
            bool Update_92 = true;
            var Output_93 = this.__p_L3kiEFfF0mgPpWvFYKmrde;
            if (Update_92)
            {
                Output_93 = this.__p_L3kiEFfF0mgPpWvFYKmrde.Update<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>(Data_In: Result_81, File_Path_In: File_Path_In, Write_In: Save_In);
            }

            int __auto_94 = Next_Id_56;
            var Output_95 = !Editing_61;
            n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> __auto_96 = Result_81;
            var builder_103 = n6.CollectionBuilders.GetBuilder(this.__cp_KfuhKMlLpVOLJvtsNPiUel, 16);
            n10.Spread<n22.BezierKnot_R<n3.Vector3>> output_104;
            try
            {
                var i_99 = 0;
                foreach (var item_97 in n6.CollectionExtensions.AsSpan(Result_81))
                {
                    var splicer_98 = item_97;
                    var i_local_100 = i_99;
                    n20._Operations_.ToBezierKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(EditableBezierKnot_In: splicer_98, BezierKnot_Out: out n22.BezierKnot_R<n3.Vector3> BezierKnot_102);
                    builder_103.Add(BezierKnot_102);
                    i_99++;
                }
            }
            finally
            {
                output_104 = builder_103.Commit();
            }

            n30.BezierSpline_R<n3.Vector3> Input_105 = n30.BezierSpline_R<n3.Vector3>.CreateDefault();
            bool Apply_106 = true;
            var Output_107 = Input_105;
            if (Apply_106)
            {
                Output_107 = Input_105.Join(Knots_In: output_104);
            }

            BezierEditorState_Out = Output_91;
            BezierSpline_Out = Output_107;
            Idle_Out = Output_95;
            n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 that_108 = this;
            if (this.__GetContext__().IsImmutable)
                that_108 = state_7 != this.__if_KE3pg3ZuhMfOiUpnMkNAE3 || Output_32 != this.__p_Ujv3yIXc7sqO4CUQqOsasT || Output_68 != this.__p_L5Y1yrgg7f8OlBCbXTSUyV || Output_79 != this.__p_AbIUAdO5SrlMVDdKyHeQxy || Output_84 != this.__p_B3ZBHxrygraPmwNo3QN6Th || Output_93 != this.__p_L3kiEFfF0mgPpWvFYKmrde || Next_Id_56 != this.Current_Id || Result_81 != this.BezierKnots || output_104 != this.__cp_KfuhKMlLpVOLJvtsNPiUel ? new BezierEditor_BdxOemVoWItPgBnY4q8s91(this)
                {__if_KE3pg3ZuhMfOiUpnMkNAE3 = state_7, __p_Ujv3yIXc7sqO4CUQqOsasT = Output_32, __p_L5Y1yrgg7f8OlBCbXTSUyV = Output_68, __p_AbIUAdO5SrlMVDdKyHeQxy = Output_79, __p_B3ZBHxrygraPmwNo3QN6Th = Output_84, __p_L3kiEFfF0mgPpWvFYKmrde = Output_93, Current_Id = Next_Id_56, BezierKnots = Result_81, __cp_KfuhKMlLpVOLJvtsNPiUel = output_104} : that_108;
            else
            {
                this.__if_KE3pg3ZuhMfOiUpnMkNAE3 = state_7;
                this.__p_Ujv3yIXc7sqO4CUQqOsasT = Output_32;
                this.__p_L5Y1yrgg7f8OlBCbXTSUyV = Output_68;
                this.__p_AbIUAdO5SrlMVDdKyHeQxy = Output_79;
                this.__p_B3ZBHxrygraPmwNo3QN6Th = Output_84;
                this.__p_L3kiEFfF0mgPpWvFYKmrde = Output_93;
                this.Current_Id = Next_Id_56;
                this.BezierKnots = Result_81;
                this.__cp_KfuhKMlLpVOLJvtsNPiUel = output_104;
            }

            return that_108;
        }

        public n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "L5Y1yrgg7f8OlBCbXTSUyV", 98299U);
            var Output_1 = n38.BezierKnotManipulator3d_R.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "AbIUAdO5SrlMVDdKyHeQxy", 98332U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "B3ZBHxrygraPmwNo3QN6Th", 98366U);
            var Output_5 = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "L3kiEFfF0mgPpWvFYKmrde", 98540U);
            var Output_7 = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Ujv3yIXc7sqO4CUQqOsasT", 98549U);
            var Output_9 = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_8);
            n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 that_10 = this;
            this.BezierKnots = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>();
            this.Current_Id = 0;
            this.__cp_KfuhKMlLpVOLJvtsNPiUel = n14._Operations_.CreateDefault<n22.BezierKnot_R<n3.Vector3>>();
            this.__p_L5Y1yrgg7f8OlBCbXTSUyV = Output_1;
            this.__p_AbIUAdO5SrlMVDdKyHeQxy = Output_3;
            this.__p_B3ZBHxrygraPmwNo3QN6Th = Output_5;
            this.__p_L3kiEFfF0mgPpWvFYKmrde = Output_7;
            this.__p_Ujv3yIXc7sqO4CUQqOsasT = Output_9;
            this.__if_KE3pg3ZuhMfOiUpnMkNAE3 = default(n2.Object);
            return that_10;
        }

        public n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 __CreateDefault__()
        {
            n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 that_0 = this;
            this.BezierKnots = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>();
            this.Current_Id = 0;
            this.__cp_KfuhKMlLpVOLJvtsNPiUel = n14._Operations_.CreateDefault<n22.BezierKnot_R<n3.Vector3>>();
            this.__if_KE3pg3ZuhMfOiUpnMkNAE3 = default(n2.Object);
            this.__p_Ujv3yIXc7sqO4CUQqOsasT = n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_L5Y1yrgg7f8OlBCbXTSUyV = n38.BezierKnotManipulator3d_R.CreateDefault();
            this.__p_AbIUAdO5SrlMVDdKyHeQxy = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_B3ZBHxrygraPmwNo3QN6Th = n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>.CreateDefault();
            this.__p_L3kiEFfF0mgPpWvFYKmrde = n4.Writer_VWy4rC6UCb0Nm7X4PoUFet.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_KE3pg3ZuhMfOiUpnMkNAE3);
            n1.CompilationHelper.SafeDispose(this.__p_Ujv3yIXc7sqO4CUQqOsasT);
            n1.CompilationHelper.SafeDispose(this.__p_L5Y1yrgg7f8OlBCbXTSUyV);
            n1.CompilationHelper.SafeDispose(this.__p_AbIUAdO5SrlMVDdKyHeQxy);
            n1.CompilationHelper.SafeDispose(this.__p_B3ZBHxrygraPmwNo3QN6Th);
            n1.CompilationHelper.SafeDispose(this.__p_L3kiEFfF0mgPpWvFYKmrde);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 98057U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Pb3hyxWGeoIPctuLzKtq0m", Name = "BezierKnots")]
        public n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots;
        [n1.ElementAttribute(TracingId = 98059U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ah9ZzphDtznNfTyQuLLpYt", Name = "Current Id")]
        public int Current_Id;
        [n1.ElementAttribute(TracingId = 98129U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MGQwXsbWEtZLWTGBGya2e3", Name = "__slot_MGQwXsbWEtZLWTGBGya2e3")]
        public static int __slot_MGQwXsbWEtZLWTGBGya2e3 = 50;
        [n1.ElementAttribute(TracingId = 98135U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PadyZsNsymfPVFUpWF7GQZ", Name = "__slot_PadyZsNsymfPVFUpWF7GQZ")]
        public static int __slot_PadyZsNsymfPVFUpWF7GQZ = 50;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_KE3pg3ZuhMfOiUpnMkNAE3;
        [n1.ElementAttribute(TracingId = 98549U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ujv3yIXc7sqO4CUQqOsasT", Name = "Reader", IsManaged = true, IsAutoGenerated = true)]
        public n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>> __p_Ujv3yIXc7sqO4CUQqOsasT;
        [n1.ElementAttribute(TracingId = 98299U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "L5Y1yrgg7f8OlBCbXTSUyV", Name = "BezierKnotManipulator3d", IsManaged = true, IsAutoGenerated = true)]
        public n38.BezierKnotManipulator3d_R __p_L5Y1yrgg7f8OlBCbXTSUyV;
        [n1.ElementAttribute(TracingId = 98332U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AbIUAdO5SrlMVDdKyHeQxy", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_AbIUAdO5SrlMVDdKyHeQxy;
        [n1.ElementAttribute(TracingId = 98366U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "B3ZBHxrygraPmwNo3QN6Th", Name = "Undo", IsManaged = true, IsAutoGenerated = true)]
        public n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>> __p_B3ZBHxrygraPmwNo3QN6Th;
        [n1.ElementAttribute(TracingId = 98540U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "L3kiEFfF0mgPpWvFYKmrde", Name = "Writer", IsManaged = true, IsAutoGenerated = true)]
        public n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_L3kiEFfF0mgPpWvFYKmrde;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n22.BezierKnot_R<n3.Vector3>> __cp_KfuhKMlLpVOLJvtsNPiUel;
        static BezierEditor_BdxOemVoWItPgBnY4q8s91()
        {
        }

        public BezierEditor_BdxOemVoWItPgBnY4q8s91(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierEditor_BdxOemVoWItPgBnY4q8s91(BezierEditor_BdxOemVoWItPgBnY4q8s91 other): base(other)
        {
            this.BezierKnots = other.BezierKnots;
            this.Current_Id = other.Current_Id;
            this.__if_KE3pg3ZuhMfOiUpnMkNAE3 = other.__if_KE3pg3ZuhMfOiUpnMkNAE3;
            this.__p_Ujv3yIXc7sqO4CUQqOsasT = other.__p_Ujv3yIXc7sqO4CUQqOsasT;
            this.__p_L5Y1yrgg7f8OlBCbXTSUyV = other.__p_L5Y1yrgg7f8OlBCbXTSUyV;
            this.__p_AbIUAdO5SrlMVDdKyHeQxy = other.__p_AbIUAdO5SrlMVDdKyHeQxy;
            this.__p_B3ZBHxrygraPmwNo3QN6Th = other.__p_B3ZBHxrygraPmwNo3QN6Th;
            this.__p_L3kiEFfF0mgPpWvFYKmrde = other.__p_L3kiEFfF0mgPpWvFYKmrde;
            this.__cp_KfuhKMlLpVOLJvtsNPiUel = other.__cp_KfuhKMlLpVOLJvtsNPiUel;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "BezierKnots", in BezierKnots), n1.CompilationHelper.GetValueOrExisting(values, "Current_Id", in Current_Id), n1.CompilationHelper.GetValueOrExisting(values, "__if_KE3pg3ZuhMfOiUpnMkNAE3", in __if_KE3pg3ZuhMfOiUpnMkNAE3), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ujv3yIXc7sqO4CUQqOsasT", in __p_Ujv3yIXc7sqO4CUQqOsasT), n1.CompilationHelper.GetValueOrExisting(values, "__p_L5Y1yrgg7f8OlBCbXTSUyV", in __p_L5Y1yrgg7f8OlBCbXTSUyV), n1.CompilationHelper.GetValueOrExisting(values, "__p_AbIUAdO5SrlMVDdKyHeQxy", in __p_AbIUAdO5SrlMVDdKyHeQxy), n1.CompilationHelper.GetValueOrExisting(values, "__p_B3ZBHxrygraPmwNo3QN6Th", in __p_B3ZBHxrygraPmwNo3QN6Th), n1.CompilationHelper.GetValueOrExisting(values, "__p_L3kiEFfF0mgPpWvFYKmrde", in __p_L3kiEFfF0mgPpWvFYKmrde), n1.CompilationHelper.GetValueOrExisting(values, "__cp_KfuhKMlLpVOLJvtsNPiUel", in __cp_KfuhKMlLpVOLJvtsNPiUel));
        }

        internal BezierEditor_BdxOemVoWItPgBnY4q8s91 __WITH__(n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots, int Current_Id, n2.Object __if_KE3pg3ZuhMfOiUpnMkNAE3, n4.Reader_DvpMZgosWbNMOtBUTedvT1<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>> __p_Ujv3yIXc7sqO4CUQqOsasT, n38.BezierKnotManipulator3d_R __p_L5Y1yrgg7f8OlBCbXTSUyV, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_AbIUAdO5SrlMVDdKyHeQxy, n41.Undo_T3rhyhgvpyhMjGurjjnyNr<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>> __p_B3ZBHxrygraPmwNo3QN6Th, n4.Writer_VWy4rC6UCb0Nm7X4PoUFet __p_L3kiEFfF0mgPpWvFYKmrde, n10.Spread<n22.BezierKnot_R<n3.Vector3>> __cp_KfuhKMlLpVOLJvtsNPiUel)
        {
            n36.BezierEditor_BdxOemVoWItPgBnY4q8s91 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = BezierKnots != this.BezierKnots || Current_Id != this.Current_Id || __if_KE3pg3ZuhMfOiUpnMkNAE3 != this.__if_KE3pg3ZuhMfOiUpnMkNAE3 || __p_Ujv3yIXc7sqO4CUQqOsasT != this.__p_Ujv3yIXc7sqO4CUQqOsasT || __p_L5Y1yrgg7f8OlBCbXTSUyV != this.__p_L5Y1yrgg7f8OlBCbXTSUyV || __p_AbIUAdO5SrlMVDdKyHeQxy != this.__p_AbIUAdO5SrlMVDdKyHeQxy || __p_B3ZBHxrygraPmwNo3QN6Th != this.__p_B3ZBHxrygraPmwNo3QN6Th || __p_L3kiEFfF0mgPpWvFYKmrde != this.__p_L3kiEFfF0mgPpWvFYKmrde || __cp_KfuhKMlLpVOLJvtsNPiUel != this.__cp_KfuhKMlLpVOLJvtsNPiUel ? new BezierEditor_BdxOemVoWItPgBnY4q8s91(this)
                {BezierKnots = BezierKnots, Current_Id = Current_Id, __if_KE3pg3ZuhMfOiUpnMkNAE3 = __if_KE3pg3ZuhMfOiUpnMkNAE3, __p_Ujv3yIXc7sqO4CUQqOsasT = __p_Ujv3yIXc7sqO4CUQqOsasT, __p_L5Y1yrgg7f8OlBCbXTSUyV = __p_L5Y1yrgg7f8OlBCbXTSUyV, __p_AbIUAdO5SrlMVDdKyHeQxy = __p_AbIUAdO5SrlMVDdKyHeQxy, __p_B3ZBHxrygraPmwNo3QN6Th = __p_B3ZBHxrygraPmwNo3QN6Th, __p_L3kiEFfF0mgPpWvFYKmrde = __p_L3kiEFfF0mgPpWvFYKmrde, __cp_KfuhKMlLpVOLJvtsNPiUel = __cp_KfuhKMlLpVOLJvtsNPiUel} : that_0;
            else
            {
                this.BezierKnots = BezierKnots;
                this.Current_Id = Current_Id;
                this.__if_KE3pg3ZuhMfOiUpnMkNAE3 = __if_KE3pg3ZuhMfOiUpnMkNAE3;
                this.__p_Ujv3yIXc7sqO4CUQqOsasT = __p_Ujv3yIXc7sqO4CUQqOsasT;
                this.__p_L5Y1yrgg7f8OlBCbXTSUyV = __p_L5Y1yrgg7f8OlBCbXTSUyV;
                this.__p_AbIUAdO5SrlMVDdKyHeQxy = __p_AbIUAdO5SrlMVDdKyHeQxy;
                this.__p_B3ZBHxrygraPmwNo3QN6Th = __p_B3ZBHxrygraPmwNo3QN6Th;
                this.__p_L3kiEFfF0mgPpWvFYKmrde = __p_L3kiEFfF0mgPpWvFYKmrde;
                this.__cp_KfuhKMlLpVOLJvtsNPiUel = __cp_KfuhKMlLpVOLJvtsNPiUel;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JIqYc85o8rYQcbR16qJeuu", Name = "__JIqYc85o8rYQcbR16qJeuu")]
        [n2.SerializableAttribute]
        public class __JIqYc85o8rYQcbR16qJeuu : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> __cp_V8Y5fSXLKUzPI0qrEVeWbN;
            public __JIqYc85o8rYQcbR16qJeuu(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JIqYc85o8rYQcbR16qJeuu(__JIqYc85o8rYQcbR16qJeuu other): base(other)
            {
                this.__cp_V8Y5fSXLKUzPI0qrEVeWbN = other.__cp_V8Y5fSXLKUzPI0qrEVeWbN;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_V8Y5fSXLKUzPI0qrEVeWbN", in __cp_V8Y5fSXLKUzPI0qrEVeWbN));
            }

            internal __JIqYc85o8rYQcbR16qJeuu __WITH__(n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> __cp_V8Y5fSXLKUzPI0qrEVeWbN)
            {
                __JIqYc85o8rYQcbR16qJeuu that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_V8Y5fSXLKUzPI0qrEVeWbN != this.__cp_V8Y5fSXLKUzPI0qrEVeWbN ? new __JIqYc85o8rYQcbR16qJeuu(this)
                    {__cp_V8Y5fSXLKUzPI0qrEVeWbN = __cp_V8Y5fSXLKUzPI0qrEVeWbN} : that_0;
                else
                {
                    this.__cp_V8Y5fSXLKUzPI0qrEVeWbN = __cp_V8Y5fSXLKUzPI0qrEVeWbN;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Editors_.Editors._3D.Internal
{
    [n1.ElementAttribute(TracingId = 86377U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "K4C9hJ2oKeaMti8ydWbYAr", Name = "Offsetter_K4C9hJ2oKeaMti8ydWbYAr")]
    [n2.SerializableAttribute]
    public class Offsetter_K4C9hJ2oKeaMti8ydWbYAr : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr Create(n1.NodeContext Node_Context)
        {
            var instance = new Offsetter_K4C9hJ2oKeaMti8ydWbYAr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr CreateDefault()
        {
            var instance = new Offsetter_K4C9hJ2oKeaMti8ydWbYAr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr Update([n6.SerializedDefaultValueAttribute("False", false)] bool Editing_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Shift_In, n3.Vector2 Mouse_Position_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Scale_In, [n6.SerializedDefaultValueAttribute("1", false)] float Rotate_In, bool Translate_In, float Step_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Scaling_In, n3.Vector3 Active_Axis_In, n3.Matrix View_Projection_In, n3.Vector3 Drag_Plane_Point_In, bool Edit_in_ViewSpace_In, out n3.Vector3 Scale_Out, out n3.Vector3 Rotate_Out, out n3.Vector3 Translate_Out, out n3.Vector3 Absolute_Out)
        {
            n3.Vector3 __pad_Tb5LDxuEGyxNDuQpUnNwrP_0 = __slot_Tb5LDxuEGyxNDuQpUnNwrP;
            n3.Vector3 __pad_JcWGUQopVf4LamIpGv0DwS_1 = __slot_JcWGUQopVf4LamIpGv0DwS;
            n3.Vector3 __pad_Fj7ylmQEwI9LoKHTWksanX_2 = __slot_Fj7ylmQEwI9LoKHTWksanX;
            float __pad_J1RsKhuUbqVNlXNoKDuXeP_3 = __slot_J1RsKhuUbqVNlXNoKDuXeP;
            float __pad_IUsXk93b0g6PIF2hVUatqX_4 = __slot_IUsXk93b0g6PIF2hVUatqX;
            bool Apply_5 = true;
            var Output_6 = Editing_In;
            if (Apply_5)
            {
                var Output_7 = !Editing_In;
                Output_6 = Output_7;
            }

            var Output_10 = this.__p_KNqLPQqOZWdMS9Iftff2or.Update(Value_In: Editing_In, Up_Edge_Out: out bool Up_Edge_8, Down_Edge_Out: out bool Down_Edge_9);
            bool Apply_11 = true;
            var Output_12 = Shift_In;
            if (Apply_11)
            {
                var Output_13 = Shift_In && Scale_In;
                Output_12 = Output_13;
            }

            var One_14 = n3.Vector3.One;
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Output_12, Input_In: Active_Axis_In, Input_2_In: One_14, Output_Out: out n3.Vector3 Output_15);
            var Y_16 = Mouse_Position_In.Y;
            bool Apply_17 = true;
            var Output_18 = Y_16;
            if (Apply_17)
            {
                n47._Operations_.Quantize<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Y_16, Step_Size_In: Step_Size_In, Output_Out: out Output_18);
            }

            bool Apply_19 = true;
            var Output_20 = Output_18;
            if (Apply_19)
            {
                var Output_21 = Output_18 * Scaling_In;
                Output_20 = Output_21;
            }

            n50._Operations_.GetPickRay(Input_In: Mouse_Position_In, View_Projection_In: View_Projection_In, Ray_Out: out n3.Ray Ray_22);
            var builder_23 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ, 1);
            builder_23.Add(__pad_Tb5LDxuEGyxNDuQpUnNwrP_0);
            var __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ_24 = builder_23.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ_24, Result_Out: out n10.Spread<n3.Vector3> Result_25);
            n23.IEnumerable<n3.Vector3> Input_26 = (n23.IEnumerable<n3.Vector3>)Result_25;
            var builder_27 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1, 1);
            builder_27.Add(__pad_JcWGUQopVf4LamIpGv0DwS_1);
            var __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1_28 = builder_27.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1_28, Result_Out: out n10.Spread<n3.Vector3> Result_29);
            n23.IEnumerable<n3.Vector3> Input_2_30 = (n23.IEnumerable<n3.Vector3>)Result_29;
            var builder_31 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v, 1);
            builder_31.Add(__pad_Fj7ylmQEwI9LoKHTWksanX_2);
            var __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v_32 = builder_31.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v_32, Result_Out: out n10.Spread<n3.Vector3> Result_33);
            n23.IEnumerable<n3.Vector3> Input_3_34 = (n23.IEnumerable<n3.Vector3>)Result_33;
            n23.IEnumerable<n3.Vector3> Input_4_35 = n12._Operations_.CreateDefault<n3.Vector3>();
            var builder_36 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz, 4);
            builder_36.Add(Input_26);
            builder_36.Add(Input_2_30);
            builder_36.Add(Input_3_34);
            builder_36.Add(Input_4_35);
            var __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz_37 = builder_36.Commit();
            n14._Operations_.Concat<n3.Vector3>(Input_In: __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz_37, Output_Out: out n10.Spread<n3.Vector3> Output_38);
            var builder_39 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS, 1);
            builder_39.Add(Active_Axis_In);
            var __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS_40 = builder_39.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS_40, Result_Out: out n10.Spread<n3.Vector3> Result_41);
            bool Apply_42 = true;
            var Output_43 = Output_38;
            if (Apply_42)
            {
                n14._Operations_.Except<n3.Vector3>(Input_In: Output_38, Input_2_In: Result_41, Output_Out: out Output_43);
            }

            bool Apply_44 = true;
            var Output_45 = View_Projection_In;
            if (Apply_44)
            {
                n3.Matrix.Invert(value: ref View_Projection_In, result: out n3.Matrix Output_46);
                Output_45 = Output_46;
            }

            n3.Vector3 Input_47 = n51._Operations_.CreateDefault();
            bool Apply_48 = true;
            var Output_49 = Input_47;
            if (Apply_48)
            {
                n3.Vector3.TransformCoordinate(coordinate: ref Input_47, transform: ref Output_45, result: out n3.Vector3 Output_50);
                Output_49 = Output_50;
            }

            float accumulator_52 = __pad_J1RsKhuUbqVNlXNoKDuXeP_3;
            n3.Vector3 accumulator_53 = n51._Operations_.CreateDefault();
            var i_55 = 0;
            foreach (var item_51 in n6.CollectionExtensions.AsSpan(Output_43))
            {
                var splicer_54 = item_51;
                var i_local_56 = i_55;
                n3.Vector3.Dot(left: ref splicer_54, right: ref Output_49, result: out float Result_58);
                bool Apply_59 = true;
                var Output_60 = Result_58;
                if (Apply_59)
                {
                    n47._Operations_.Abs<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_58, Output_Out: out Output_60);
                }

                var Result_61 = Output_60 > accumulator_52;
                n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Result_61, Input_In: accumulator_53, Input_2_In: splicer_54, Output_Out: out n3.Vector3 Output_62);
                n32._Operations_.Switch_Boolean<float>(Condition_In: Result_61, Input_In: accumulator_52, Input_2_In: Output_60, Output_Out: out float Output_63);
                accumulator_52 = Output_63;
                accumulator_53 = Output_62;
                i_55++;
            }

            var Output_64 = new n3.Plane(point: Drag_Plane_Point_In, normal: accumulator_53);
            bool SetValue_65 = true;
            var Output_66 = this.__p_Ohh0ywjt3ZULH3155heEU9;
            if (SetValue_65)
            {
                Output_66 = this.__p_Ohh0ywjt3ZULH3155heEU9.SetValue(Value_In: Output_64, Sample_In: Up_Edge_8);
            }

            var Output_68 = Output_66.GetValue(Value_Out: out n3.Plane Value_67);
            var Result_70 = n3.CollisionHelper.RayIntersectsPlane(ray: ref Ray_22, plane: ref Value_67, point: out n3.Vector3 Point_69);
            n3.Vector3.Dot(left: ref Active_Axis_In, right: ref Point_69, result: out float Result_71);
            bool Apply_72 = true;
            var Output_73 = Result_71;
            if (Apply_72)
            {
                n47._Operations_.Quantize<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_71, Step_Size_In: Step_Size_In, Output_Out: out Output_73);
            }

            float Input_74 = 0F;
            n32._Operations_.Switch_Boolean<float>(Condition_In: Result_70, Input_In: Input_74, Input_2_In: Output_73, Output_Out: out float Output_75);
            n32._Operations_.Switch_Boolean<float>(Condition_In: Translate_In, Input_In: Output_20, Input_2_In: Output_75, Output_Out: out float Output_76);
            bool Apply_77 = true;
            var Output_78 = Output_15;
            if (Apply_77)
            {
                n46.Vector3Nodes.Scale(input: ref Output_15, scalar: Output_76, output: out n3.Vector3 Output_79);
                Output_78 = Output_79;
            }

            var Output_81 = this.__p_JgA82Xb6rQ2LjmGUiJmEAT.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Value_In: Output_78, Result_Out: out n3.Vector3 Result_80);
            var Direction_82 = Ray_22.Direction;
            var Output_83 = new n3.Plane(point: Drag_Plane_Point_In, normal: Direction_82);
            bool SetValue_84 = true;
            var Output_85 = this.__p_MMVTze7DDZUNRLtPyabjQT;
            if (SetValue_84)
            {
                Output_85 = this.__p_MMVTze7DDZUNRLtPyabjQT.SetValue(Value_In: Output_83, Sample_In: Up_Edge_8);
            }

            var Output_87 = Output_85.GetValue(Value_Out: out n3.Plane Value_86);
            var Result_89 = n3.CollisionHelper.RayIntersectsPlane(ray: ref Ray_22, plane: ref Value_86, point: out n3.Vector3 Point_88);
            var Output_90 = new n3.Vector3(x: Step_Size_In, y: Step_Size_In, z: Step_Size_In);
            bool Apply_91 = true;
            var Output_92 = Point_88;
            if (Apply_91)
            {
                n51._Operations_.Quantize(Input_In: Point_88, Step_Size_In: Output_90, Output_Out: out Output_92);
            }

            var Output_94 = this.__p_MhED3d8A3AOOQCcdVdEv9Y.Update<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Value_In: Output_92, Result_Out: out n3.Vector3 Result_93);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Edit_in_ViewSpace_In, Input_In: Result_80, Input_2_In: Result_93, Output_Out: out n3.Vector3 Output_95);
            n3.Vector3 Input_2_96 = n51._Operations_.CreateDefault();
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Up_Edge_8, Input_In: Output_95, Input_2_In: Input_2_96, Output_Out: out n3.Vector3 Output_97);
            n3.Vector3 Input_98 = n51._Operations_.CreateDefault();
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Editing_In, Input_In: Input_98, Input_2_In: Output_97, Output_Out: out n3.Vector3 Output_99);
            bool Step_100 = true;
            var Output_101 = this.__p_P08aH4OJvJBPVP50crW4d8;
            if (Step_100)
            {
                Output_101 = this.__p_P08aH4OJvJBPVP50crW4d8.Step<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Offset_In: Output_99);
            }

            n3.Vector3 Reset_Value_102 = n51._Operations_.CreateDefault();
            var Output_103 = Output_101;
            if (Output_6)
            {
                Output_103 = Output_101.Reset(Reset_Value_In: Reset_Value_102);
            }

            var Output_105 = Output_103.GetValue(Value_Out: out n3.Vector3 Value_104);
            n46.MatrixNodes.GetColumns(input: ref View_Projection_In, column1: out n3.Vector4 Column_1_106, column2: out n3.Vector4 Column_2_107, column3: out n3.Vector4 Column_3_108, column4: out n3.Vector4 Column_4_109);
            bool Apply_110 = true;
            var Output_111 = Column_4_109;
            if (Apply_110)
            {
                n60._Operations_.Abs(Input_In: Column_4_109, Output_Out: out Output_111);
            }

            n46.Vector4Nodes.Vector(input: ref Output_111, x: out float X_112, y: out float Y_113, z: out float Z_114, w: out float W_115);
            var Output_116 = X_112 + Y_113;
            var Output_117 = Output_116 + Z_114;
            var Result_118 = Output_117 < __pad_IUsXk93b0g6PIF2hVUatqX_4;
            float Scalar_119 = n2.Convert.ToSingle(Scale_In);
            bool Apply_120 = true;
            var Output_121 = Output_99;
            if (Apply_120)
            {
                n46.Vector3Nodes.Scale(input: ref Output_99, scalar: Scalar_119, output: out n3.Vector3 Output_122);
                Output_121 = Output_122;
            }

            bool Apply_123 = true;
            var Output_124 = Output_99;
            if (Apply_123)
            {
                n46.Vector3Nodes.Scale(input: ref Output_99, scalar: Rotate_In, output: out n3.Vector3 Output_125);
                Output_124 = Output_125;
            }

            float Scalar_126 = n2.Convert.ToSingle(Translate_In);
            bool Apply_127 = true;
            var Output_128 = Output_99;
            if (Apply_127)
            {
                n46.Vector3Nodes.Scale(input: ref Output_99, scalar: Scalar_126, output: out n3.Vector3 Output_129);
                Output_128 = Output_129;
            }

            Scale_Out = Output_121;
            Rotate_Out = Output_124;
            Translate_Out = Output_128;
            Absolute_Out = Value_104;
            n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr that_130 = this;
            if (this.__GetContext__().IsImmutable)
                that_130 = Output_10 != this.__p_KNqLPQqOZWdMS9Iftff2or || __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ_24 != this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ || __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1_28 != this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 || __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v_32 != this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v || __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz_37 != this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz || __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS_40 != this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS || Output_68 != this.__p_Ohh0ywjt3ZULH3155heEU9 || Output_81 != this.__p_JgA82Xb6rQ2LjmGUiJmEAT || Output_87 != this.__p_MMVTze7DDZUNRLtPyabjQT || Output_94 != this.__p_MhED3d8A3AOOQCcdVdEv9Y || Output_105 != this.__p_P08aH4OJvJBPVP50crW4d8 ? new Offsetter_K4C9hJ2oKeaMti8ydWbYAr(this)
                {__p_KNqLPQqOZWdMS9Iftff2or = Output_10, __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ_24, __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1_28, __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v_32, __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz_37, __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS_40, __p_Ohh0ywjt3ZULH3155heEU9 = Output_68, __p_JgA82Xb6rQ2LjmGUiJmEAT = Output_81, __p_MMVTze7DDZUNRLtPyabjQT = Output_87, __p_MhED3d8A3AOOQCcdVdEv9Y = Output_94, __p_P08aH4OJvJBPVP50crW4d8 = Output_105} : that_130;
            else
            {
                this.__p_KNqLPQqOZWdMS9Iftff2or = Output_10;
                this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ_24;
                this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1_28;
                this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v_32;
                this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz_37;
                this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS_40;
                this.__p_Ohh0ywjt3ZULH3155heEU9 = Output_68;
                this.__p_JgA82Xb6rQ2LjmGUiJmEAT = Output_81;
                this.__p_MMVTze7DDZUNRLtPyabjQT = Output_87;
                this.__p_MhED3d8A3AOOQCcdVdEv9Y = Output_94;
                this.__p_P08aH4OJvJBPVP50crW4d8 = Output_105;
            }

            return that_130;
        }

        public n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "KNqLPQqOZWdMS9Iftff2or", 86598U);
            var Output_1 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Ohh0ywjt3ZULH3155heEU9", 86707U);
            n3.Plane Initial_Value_3 = n61._Operations_.CreateDefault();
            var Output_4 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane>.Create(Node_Context: Node_Context_2, Initial_Value_In: Initial_Value_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "P08aH4OJvJBPVP50crW4d8", 86751U);
            n3.Vector3 Initial_Value_6 = n51._Operations_.CreateDefault();
            var Output_7 = n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_5, Initial_Value_In: Initial_Value_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "JgA82Xb6rQ2LjmGUiJmEAT", 86873U);
            var Output_9 = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "MMVTze7DDZUNRLtPyabjQT", 87100U);
            n3.Plane Initial_Value_11 = n61._Operations_.CreateDefault();
            var Output_12 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane>.Create(Node_Context: Node_Context_10, Initial_Value_In: Initial_Value_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "MhED3d8A3AOOQCcdVdEv9Y", 87307U);
            var Output_14 = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_13);
            n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr that_15 = this;
            this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = n14._Operations_.CreateDefault<n23.IEnumerable<n3.Vector3>>();
            this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__p_KNqLPQqOZWdMS9Iftff2or = Output_1;
            this.__p_Ohh0ywjt3ZULH3155heEU9 = Output_4;
            this.__p_P08aH4OJvJBPVP50crW4d8 = Output_7;
            this.__p_JgA82Xb6rQ2LjmGUiJmEAT = Output_9;
            this.__p_MMVTze7DDZUNRLtPyabjQT = Output_12;
            this.__p_MhED3d8A3AOOQCcdVdEv9Y = Output_14;
            return that_15;
        }

        public n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr __CreateDefault__()
        {
            n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr that_0 = this;
            this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = n14._Operations_.CreateDefault<n23.IEnumerable<n3.Vector3>>();
            this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = n14._Operations_.CreateDefault<n3.Vector3>();
            this.__p_KNqLPQqOZWdMS9Iftff2or = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_Ohh0ywjt3ZULH3155heEU9 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane>.CreateDefault();
            this.__p_JgA82Xb6rQ2LjmGUiJmEAT = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_MMVTze7DDZUNRLtPyabjQT = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane>.CreateDefault();
            this.__p_MhED3d8A3AOOQCcdVdEv9Y = n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_P08aH4OJvJBPVP50crW4d8 = n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KNqLPQqOZWdMS9Iftff2or);
            n1.CompilationHelper.SafeDispose(this.__p_Ohh0ywjt3ZULH3155heEU9);
            n1.CompilationHelper.SafeDispose(this.__p_JgA82Xb6rQ2LjmGUiJmEAT);
            n1.CompilationHelper.SafeDispose(this.__p_MMVTze7DDZUNRLtPyabjQT);
            n1.CompilationHelper.SafeDispose(this.__p_MhED3d8A3AOOQCcdVdEv9Y);
            n1.CompilationHelper.SafeDispose(this.__p_P08aH4OJvJBPVP50crW4d8);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 86480U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Tb5LDxuEGyxNDuQpUnNwrP", Name = "__slot_Tb5LDxuEGyxNDuQpUnNwrP")]
        public static n3.Vector3 __slot_Tb5LDxuEGyxNDuQpUnNwrP = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0, 0", false, "RMDMfKmnIrVPStLdWe8u30", "Tb5LDxuEGyxNDuQpUnNwrP");
        [n1.ElementAttribute(TracingId = 86483U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JcWGUQopVf4LamIpGv0DwS", Name = "__slot_JcWGUQopVf4LamIpGv0DwS")]
        public static n3.Vector3 __slot_JcWGUQopVf4LamIpGv0DwS = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 1, 0", false, "RMDMfKmnIrVPStLdWe8u30", "JcWGUQopVf4LamIpGv0DwS");
        [n1.ElementAttribute(TracingId = 86489U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Fj7ylmQEwI9LoKHTWksanX", Name = "__slot_Fj7ylmQEwI9LoKHTWksanX")]
        public static n3.Vector3 __slot_Fj7ylmQEwI9LoKHTWksanX = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 1", false, "RMDMfKmnIrVPStLdWe8u30", "Fj7ylmQEwI9LoKHTWksanX");
        [n1.ElementAttribute(TracingId = 86498U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "J1RsKhuUbqVNlXNoKDuXeP", Name = "__slot_J1RsKhuUbqVNlXNoKDuXeP")]
        public static float __slot_J1RsKhuUbqVNlXNoKDuXeP = 0F;
        [n1.ElementAttribute(TracingId = 86511U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LQPVwhfVLvWPJIbQY3s5hi", Name = "__slot_LQPVwhfVLvWPJIbQY3s5hi")]
        public static string __slot_LQPVwhfVLvWPJIbQY3s5hi = "< exclude the plane defined by the normal of mousebutton pressed xyz from possible planes to drag on";
        [n1.ElementAttribute(TracingId = 86515U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JGC4jcb5S1HP8vTxUodxyj", Name = "__slot_JGC4jcb5S1HP8vTxUodxyj")]
        public static string __slot_JGC4jcb5S1HP8vTxUodxyj = "< of the two possible planes choose the one which more faces the camera";
        [n1.ElementAttribute(TracingId = 86521U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IUsXk93b0g6PIF2hVUatqX", Name = "__slot_IUsXk93b0g6PIF2hVUatqX")]
        public static float __slot_IUsXk93b0g6PIF2hVUatqX = 1.01F;
        [n1.ElementAttribute(TracingId = 86532U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HjYnvO39pv9PtMgIBWuvOa", Name = "__slot_HjYnvO39pv9PtMgIBWuvOa")]
        public static string __slot_HjYnvO39pv9PtMgIBWuvOa = "< returns the distances of the mouse draged in worldspace to have points draged realistically according to mousemovement";
        [n1.ElementAttribute(TracingId = 86539U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I8NsoEuGE5zL3Ly4EoIV2h", Name = "__slot_I8NsoEuGE5zL3Ly4EoIV2h")]
        public static string __slot_I8NsoEuGE5zL3Ly4EoIV2h = "< detect ortho view";
        [n1.ElementAttribute(TracingId = 86544U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SxNi2cDxVNjP5OfwA7fcKn", Name = "__slot_SxNi2cDxVNjP5OfwA7fcKn")]
        public static string __slot_SxNi2cDxVNjP5OfwA7fcKn = "< Axis vs. ViewSpace";
        [n1.ElementAttribute(TracingId = 86551U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AqeRg7q55KEPA0PHj46WUh", Name = "__slot_AqeRg7q55KEPA0PHj46WUh")]
        public static string __slot_AqeRg7q55KEPA0PHj46WUh = "< Scale vs. Translate";
        [n1.ElementAttribute(TracingId = 86557U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "COpdk2G4BDrMZRTFgH6PrV", Name = "__slot_COpdk2G4BDrMZRTFgH6PrV")]
        public static string __slot_COpdk2G4BDrMZRTFgH6PrV = "< per Axis vs. Uniform";
        [n1.ElementAttribute(TracingId = 86598U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KNqLPQqOZWdMS9Iftff2or", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KNqLPQqOZWdMS9Iftff2or;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = default(n10.Spread<n3.Vector3>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = default(n10.Spread<n3.Vector3>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = default(n10.Spread<n3.Vector3>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n23.IEnumerable<n3.Vector3>> __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = default(n10.Spread<n23.IEnumerable<n3.Vector3>>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = default(n10.Spread<n3.Vector3>);
        [n1.ElementAttribute(TracingId = 86707U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ohh0ywjt3ZULH3155heEU9", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane> __p_Ohh0ywjt3ZULH3155heEU9;
        [n1.ElementAttribute(TracingId = 86873U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JgA82Xb6rQ2LjmGUiJmEAT", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3> __p_JgA82Xb6rQ2LjmGUiJmEAT;
        [n1.ElementAttribute(TracingId = 87100U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MMVTze7DDZUNRLtPyabjQT", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane> __p_MMVTze7DDZUNRLtPyabjQT;
        [n1.ElementAttribute(TracingId = 87307U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MhED3d8A3AOOQCcdVdEv9Y", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3> __p_MhED3d8A3AOOQCcdVdEv9Y;
        [n1.ElementAttribute(TracingId = 86751U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "P08aH4OJvJBPVP50crW4d8", Name = "Integrator", IsManaged = true, IsAutoGenerated = true)]
        public n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector3> __p_P08aH4OJvJBPVP50crW4d8;
        static Offsetter_K4C9hJ2oKeaMti8ydWbYAr()
        {
        }

        public Offsetter_K4C9hJ2oKeaMti8ydWbYAr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Offsetter_K4C9hJ2oKeaMti8ydWbYAr(Offsetter_K4C9hJ2oKeaMti8ydWbYAr other): base(other)
        {
            this.__p_KNqLPQqOZWdMS9Iftff2or = other.__p_KNqLPQqOZWdMS9Iftff2or;
            this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = other.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ;
            this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = other.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1;
            this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = other.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v;
            this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = other.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz;
            this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = other.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS;
            this.__p_Ohh0ywjt3ZULH3155heEU9 = other.__p_Ohh0ywjt3ZULH3155heEU9;
            this.__p_JgA82Xb6rQ2LjmGUiJmEAT = other.__p_JgA82Xb6rQ2LjmGUiJmEAT;
            this.__p_MMVTze7DDZUNRLtPyabjQT = other.__p_MMVTze7DDZUNRLtPyabjQT;
            this.__p_MhED3d8A3AOOQCcdVdEv9Y = other.__p_MhED3d8A3AOOQCcdVdEv9Y;
            this.__p_P08aH4OJvJBPVP50crW4d8 = other.__p_P08aH4OJvJBPVP50crW4d8;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KNqLPQqOZWdMS9Iftff2or", in __p_KNqLPQqOZWdMS9Iftff2or), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ", in __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1", in __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v", in __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz", in __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS", in __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ohh0ywjt3ZULH3155heEU9", in __p_Ohh0ywjt3ZULH3155heEU9), n1.CompilationHelper.GetValueOrExisting(values, "__p_JgA82Xb6rQ2LjmGUiJmEAT", in __p_JgA82Xb6rQ2LjmGUiJmEAT), n1.CompilationHelper.GetValueOrExisting(values, "__p_MMVTze7DDZUNRLtPyabjQT", in __p_MMVTze7DDZUNRLtPyabjQT), n1.CompilationHelper.GetValueOrExisting(values, "__p_MhED3d8A3AOOQCcdVdEv9Y", in __p_MhED3d8A3AOOQCcdVdEv9Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_P08aH4OJvJBPVP50crW4d8", in __p_P08aH4OJvJBPVP50crW4d8));
        }

        internal Offsetter_K4C9hJ2oKeaMti8ydWbYAr __WITH__(n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KNqLPQqOZWdMS9Iftff2or, n10.Spread<n3.Vector3> __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ, n10.Spread<n3.Vector3> __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1, n10.Spread<n3.Vector3> __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v, n10.Spread<n23.IEnumerable<n3.Vector3>> __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz, n10.Spread<n3.Vector3> __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane> __p_Ohh0ywjt3ZULH3155heEU9, n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3> __p_JgA82Xb6rQ2LjmGUiJmEAT, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Plane> __p_MMVTze7DDZUNRLtPyabjQT, n54.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector3> __p_MhED3d8A3AOOQCcdVdEv9Y, n54.Integrator_THHkpncME3nNMZHt1mZTtJ<n3.Vector3> __p_P08aH4OJvJBPVP50crW4d8)
        {
            n38.Offsetter_K4C9hJ2oKeaMti8ydWbYAr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KNqLPQqOZWdMS9Iftff2or != this.__p_KNqLPQqOZWdMS9Iftff2or || __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ != this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ || __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 != this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 || __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v != this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v || __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz != this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz || __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS != this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS || __p_Ohh0ywjt3ZULH3155heEU9 != this.__p_Ohh0ywjt3ZULH3155heEU9 || __p_JgA82Xb6rQ2LjmGUiJmEAT != this.__p_JgA82Xb6rQ2LjmGUiJmEAT || __p_MMVTze7DDZUNRLtPyabjQT != this.__p_MMVTze7DDZUNRLtPyabjQT || __p_MhED3d8A3AOOQCcdVdEv9Y != this.__p_MhED3d8A3AOOQCcdVdEv9Y || __p_P08aH4OJvJBPVP50crW4d8 != this.__p_P08aH4OJvJBPVP50crW4d8 ? new Offsetter_K4C9hJ2oKeaMti8ydWbYAr(this)
                {__p_KNqLPQqOZWdMS9Iftff2or = __p_KNqLPQqOZWdMS9Iftff2or, __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ, __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1, __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v, __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz, __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS, __p_Ohh0ywjt3ZULH3155heEU9 = __p_Ohh0ywjt3ZULH3155heEU9, __p_JgA82Xb6rQ2LjmGUiJmEAT = __p_JgA82Xb6rQ2LjmGUiJmEAT, __p_MMVTze7DDZUNRLtPyabjQT = __p_MMVTze7DDZUNRLtPyabjQT, __p_MhED3d8A3AOOQCcdVdEv9Y = __p_MhED3d8A3AOOQCcdVdEv9Y, __p_P08aH4OJvJBPVP50crW4d8 = __p_P08aH4OJvJBPVP50crW4d8} : that_0;
            else
            {
                this.__p_KNqLPQqOZWdMS9Iftff2or = __p_KNqLPQqOZWdMS9Iftff2or;
                this.__pin_group_Input_In_CzKKmflFBObMgK5axG23EZ = __pin_group_Input_In_CzKKmflFBObMgK5axG23EZ;
                this.__pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1 = __pin_group_Input_In_Dlp3jZlFcrkLMfAhfP6so1;
                this.__pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v = __pin_group_Input_In_Pdei1uTmlFEO0caQcbV59v;
                this.__pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz = __pin_group_Input_In_V7R80on7ZJjOyZ4Y3dxvJz;
                this.__pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS = __pin_group_Input_In_ANw9sVyobhYP8sO7IhNWTS;
                this.__p_Ohh0ywjt3ZULH3155heEU9 = __p_Ohh0ywjt3ZULH3155heEU9;
                this.__p_JgA82Xb6rQ2LjmGUiJmEAT = __p_JgA82Xb6rQ2LjmGUiJmEAT;
                this.__p_MMVTze7DDZUNRLtPyabjQT = __p_MMVTze7DDZUNRLtPyabjQT;
                this.__p_MhED3d8A3AOOQCcdVdEv9Y = __p_MhED3d8A3AOOQCcdVdEv9Y;
                this.__p_P08aH4OJvJBPVP50crW4d8 = __p_P08aH4OJvJBPVP50crW4d8;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 87600U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GQIA7vZy239LZeN2s3lf2n", Name = "PointManipulator3d_GQIA7vZy239LZeN2s3lf2n")]
    [n2.SerializableAttribute]
    public class PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> : n1.VLObject, n2.IDisposable where T : n23.IEnumerable<n8.EditablePoint_R<n3.Vector3>>
    {
        [n6.CreateNewAttribute]
        public static n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var instance = new PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> CreateDefault()
        {
            var instance = new PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> Update(T Points_In, n8.PointEditorControlsData_R PointEditor_Controls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, n3.Matrix ViewProjection_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, float Pick_Size_In, out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_Out, out n10.Spread<n3.Vector3> Result_Out, out bool Editing_Out, out bool Selection_Updated_Out, out bool Scale_Out, out bool Rotate_Out, out bool Translate_Out, out n3.Vector3 Offset_Out, out n34.GizmoState_R GizmoState_Out)
        {
            n3.Vector3 __pad_OpNkDQWnVASNcfjGgMxmR1_0 = __slot_OpNkDQWnVASNcfjGgMxmR1;
            int __pad_HCnxWpuQT0rPHY76EnEt4O_1 = __slot_HCnxWpuQT0rPHY76EnEt4O;
            float __pad_CwM6PPb2dMSMLor1X56bsm_2 = __slot_CwM6PPb2dMSMLor1X56bsm;
            bool __pad_A3XbiE3hjT8OGWY3LJB59t_3 = __slot_A3XbiE3hjT8OGWY3LJB59t;
            n31._Operations_.Average<T, n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Points_In, Output_Out: out n3.Vector3 Output_4, Elements_Count_Out: out int Elements_Count_5);
            n51._Operations_.AvoidNaN(Input_In: Output_4, Default_In: __pad_OpNkDQWnVASNcfjGgMxmR1_0, Output_Out: out n3.Vector3 Output_6);
            n38._Operations_.LockToScreen(Size_In: Gizmo_Size_In, Position_In: Output_6, View_Projection_In: ViewProjection_In, Result_Out: out float Result_7);
            var Output_8 = (float)Result_7 / __pad_CwM6PPb2dMSMLor1X56bsm_2;
            var Output_11 = this.__p_MH0F5TwVhhVMleOQDdEHoR.Update(Value_In: Output_6, Result_Out: out bool Result_9, Unchanged_Out: out bool Unchanged_10);
            int Input_2_12 = 0;
            var Result_13 = Elements_Count_5 > Input_2_12;
            var Output_24 = this.__p_M8CskD3XiOBPRSu0RfV8dH.Update(Gizmo_Size_In: Result_7, Pick_Size_In: Output_8, Position_In: Output_6, Position_Changed_In: Result_9, Active_Plane_In: __pad_HCnxWpuQT0rPHY76EnEt4O_1, Number_of_Points_In: Elements_Count_5, Gizmo_Controls_In: Gizmo_Controls_In, Step_Size_In: Step_Size_In, View_Projection_In: ViewProjection_In, Camera_Idle_In: Camera_Idle_In, Default_Visibility_In: __pad_A3XbiE3hjT8OGWY3LJB59t_3, Enabled_In: Result_13, GizmoState_Out: out n34.GizmoState_R GizmoState_14, Translate_Offset_Out: out n3.Vector3 Translate_Offset_15, Scale_Offset_Out: out n3.Vector3 Scale_Offset_16, Rotate_Offset_Out: out n3.Vector3 Rotate_Offset_17, Total_Offset_Out: out n3.Vector3 Total_Offset_18, Translation_Active_Out: out bool Translation_Active_19, Scale_Active_Out: out bool Scale_Active_20, Rotation_Active_Out: out bool Rotation_Active_21, Active_Axis_Out: out n3.Vector3 Active_Axis_22, Idle_Out: out bool Idle_23);
            var Output_25 = !Idle_23;
            bool __pad_FOzNkAolr43MbczFZ2VmrW_26 = Output_25;
            var Output_29 = this.__p_KI0Ho8FQ7vsPqMopP0hvbk.Update(Value_In: __pad_FOzNkAolr43MbczFZ2VmrW_26, Up_Edge_Out: out bool Up_Edge_27, Down_Edge_Out: out bool Down_Edge_28);
            bool SetValue_30 = true;
            var Output_31 = this.__p_LdijEKHpNbbPJYj8v7IsyV;
            if (SetValue_30)
            {
                Output_31 = this.__p_LdijEKHpNbbPJYj8v7IsyV.SetValue(Value_In: Points_In, Sample_In: Up_Edge_27);
            }

            var Output_33 = Output_31.GetValue(Value_Out: out T Value_32);
            n32._Operations_.Switch_Boolean<T>(Condition_In: __pad_FOzNkAolr43MbczFZ2VmrW_26, Input_In: Points_In, Input_2_In: Value_32, Output_Out: out T Output_34);
            n31._Operations_.UpdatePoints<T, n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Inputs_In: Output_34, Matrix_In: ViewProjection_In, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Outputs_35);
            n31._Operations_.Average<T, n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_34, Output_Out: out n3.Vector3 Output_36, Elements_Count_Out: out int Elements_Count_37);
            var Output_53 = PointEditor_Controls_In.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_38, Mouse_Pressed_Out: out bool Mouse_Pressed_39, Selection_Out: out n3.RectangleF Selection_40, Remove_Selected_Out: out bool Remove_Selected_41, Control_Out: out bool Control_42, Shift_Out: out bool Shift_43, Space_Out: out bool Space_44, Hover_Next_Out: out bool Hover_Next_45, Hover_Previous_Out: out bool Hover_Previous_46, Select_All_Out: out bool Select_All_47, Scale_Out: out bool Scale_48, Rotate_Out: out bool Rotate_49, Translate_Out: out bool Translate_50, Undo_Out: out bool Undo_51, Redo_Out: out bool Redo_52);
            n31._Operations_.HoverWithMouse<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Outputs_35, Mouse_Position_In: Pointer_Position_38, Pick_Size_In: Pick_Size_In, Enable_In: Idle_23, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Output_54, Selection_Hovered_Out: out bool Selection_Hovered_55);
            var Output_56 = Idle_23 && Mouse_Pressed_39;
            n31._Operations_.SelectWithMarquee<n3.Vector3>(Input_In: Output_54, Mouse_Selection_In: Selection_40, Pick_Size_In: Pick_Size_In, Enable_In: Output_56, Remove_From_Selection_In: Shift_43, Output_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Output_57, Selection_Modifier_Changed_Out: out bool Selection_Modifier_Changed_58);
            var Output_59 = Scale_48 || Rotate_49;
            var Output_60 = Output_59 || Translate_50;
            var Output_63 = this.__p_OT1oLEHk6snNii8PBdbeU4.Update(Value_In: Mouse_Pressed_39, Up_Edge_Out: out bool Up_Edge_61, Down_Edge_Out: out bool Down_Edge_62);
            n31._Operations_.SelectPoints<n10.Spread<n8.EditablePoint_R<n3.Vector3>>, n3.Vector3>(Inputs_In: Output_57, Selection_Hovered_In: Selection_Hovered_55, Gizmo_Idle_In: Idle_23, EditingKey_In: Output_60, Add_To_Selection_In: Control_42, Remove_From_Selection_In: Shift_43, Select_All_In: Select_All_47, Pressed_In: Up_Edge_61, Released_In: Down_Edge_62, Select_with_Key_In: Space_44, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Outputs_64, Selection_Changed_Out: out bool Selection_Changed_65, Selection_Set_Out: out bool Selection_Set_66);
            n38._Operations_.EditPoints3d<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>(Points_In: Outputs_64, Center_In: Output_36, Editing_In: __pad_FOzNkAolr43MbczFZ2VmrW_26, Scale_In: Scale_Offset_16, Rotate_In: Rotate_Offset_17, Translate_In: Translate_Offset_15, Axis_In: Active_Axis_22, Outputs_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Outputs_67, Result_Out: out n10.Spread<n3.Vector3> Result_68);
            var Output_69 = Mouse_Pressed_39 || Output_60;
            var Output_70 = Scale_48 || Scale_Active_20;
            var Output_71 = Rotate_49 || Rotation_Active_21;
            var Output_72 = Translate_50 || Translation_Active_19;
            var Output_73 = Selection_Modifier_Changed_58 || Selection_Set_66;
            var Output_74 = Output_73 && Output_69;
            Points_Out = Outputs_67;
            Result_Out = Result_68;
            Editing_Out = __pad_FOzNkAolr43MbczFZ2VmrW_26;
            Selection_Updated_Out = Output_74;
            Scale_Out = Output_70;
            Rotate_Out = Output_71;
            Translate_Out = Output_72;
            Offset_Out = Total_Offset_18;
            GizmoState_Out = GizmoState_14;
            n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> that_75 = this;
            if (this.__GetContext__().IsImmutable)
                that_75 = Output_11 != this.__p_MH0F5TwVhhVMleOQDdEHoR || Output_24 != this.__p_M8CskD3XiOBPRSu0RfV8dH || Output_25 != this.__slot_FOzNkAolr43MbczFZ2VmrW || Output_29 != this.__p_KI0Ho8FQ7vsPqMopP0hvbk || Output_33 != this.__p_LdijEKHpNbbPJYj8v7IsyV || Output_63 != this.__p_OT1oLEHk6snNii8PBdbeU4 ? new PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T>(this)
                {__p_MH0F5TwVhhVMleOQDdEHoR = Output_11, __p_M8CskD3XiOBPRSu0RfV8dH = Output_24, __slot_FOzNkAolr43MbczFZ2VmrW = Output_25, __p_KI0Ho8FQ7vsPqMopP0hvbk = Output_29, __p_LdijEKHpNbbPJYj8v7IsyV = Output_33, __p_OT1oLEHk6snNii8PBdbeU4 = Output_63} : that_75;
            else
            {
                this.__p_MH0F5TwVhhVMleOQDdEHoR = Output_11;
                this.__p_M8CskD3XiOBPRSu0RfV8dH = Output_24;
                this.__slot_FOzNkAolr43MbczFZ2VmrW = Output_25;
                this.__p_KI0Ho8FQ7vsPqMopP0hvbk = Output_29;
                this.__p_LdijEKHpNbbPJYj8v7IsyV = Output_33;
                this.__p_OT1oLEHk6snNii8PBdbeU4 = Output_63;
            }

            return that_75;
        }

        public n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "OT1oLEHk6snNii8PBdbeU4", 87894U);
            var Output_2 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "M8CskD3XiOBPRSu0RfV8dH", 87935U);
            var Output_4 = n34.Gizmo_VCf0qns0epcMnUFCEx67yz.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "MH0F5TwVhhVMleOQDdEHoR", 88055U);
            bool Changed_On_Create_6 = true;
            var Output_7 = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_5, Changed_On_Create_In: Changed_On_Create_6);
            w_0.CreateDefault(Output_Out: out T Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LdijEKHpNbbPJYj8v7IsyV", 88215U);
            var Output_10 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<T>.Create(Node_Context: Node_Context_9, Initial_Value_In: Output_8);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "KI0Ho8FQ7vsPqMopP0hvbk", 88245U);
            var Output_12 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_11);
            n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> that_13 = this;
            this.__slot_FOzNkAolr43MbczFZ2VmrW = false;
            this.__p_OT1oLEHk6snNii8PBdbeU4 = Output_2;
            this.__p_M8CskD3XiOBPRSu0RfV8dH = Output_4;
            this.__p_MH0F5TwVhhVMleOQDdEHoR = Output_7;
            this.__p_LdijEKHpNbbPJYj8v7IsyV = Output_10;
            this.__p_KI0Ho8FQ7vsPqMopP0hvbk = Output_12;
            return that_13;
        }

        public n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> __CreateDefault__()
        {
            n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> that_0 = this;
            this.__slot_FOzNkAolr43MbczFZ2VmrW = false;
            this.__p_MH0F5TwVhhVMleOQDdEHoR = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_M8CskD3XiOBPRSu0RfV8dH = n34.Gizmo_VCf0qns0epcMnUFCEx67yz.CreateDefault();
            this.__p_KI0Ho8FQ7vsPqMopP0hvbk = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_LdijEKHpNbbPJYj8v7IsyV = n41.SPH_RESwCzqU3iTMc4Ig82Av03<T>.CreateDefault();
            this.__p_OT1oLEHk6snNii8PBdbeU4 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MH0F5TwVhhVMleOQDdEHoR);
            n1.CompilationHelper.SafeDispose(this.__p_M8CskD3XiOBPRSu0RfV8dH);
            n1.CompilationHelper.SafeDispose(this.__p_KI0Ho8FQ7vsPqMopP0hvbk);
            n1.CompilationHelper.SafeDispose(this.__p_LdijEKHpNbbPJYj8v7IsyV);
            n1.CompilationHelper.SafeDispose(this.__p_OT1oLEHk6snNii8PBdbeU4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 88020U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HCnxWpuQT0rPHY76EnEt4O", Name = "__slot_HCnxWpuQT0rPHY76EnEt4O")]
        public static int __slot_HCnxWpuQT0rPHY76EnEt4O = 0;
        [n1.ElementAttribute(TracingId = 88150U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CwM6PPb2dMSMLor1X56bsm", Name = "__slot_CwM6PPb2dMSMLor1X56bsm")]
        public static float __slot_CwM6PPb2dMSMLor1X56bsm = 8F;
        [n1.ElementAttribute(TracingId = 88201U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "A3XbiE3hjT8OGWY3LJB59t", Name = "__slot_A3XbiE3hjT8OGWY3LJB59t")]
        public static bool __slot_A3XbiE3hjT8OGWY3LJB59t = true;
        [n1.ElementAttribute(TracingId = 88241U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FOzNkAolr43MbczFZ2VmrW", Name = "__slot_FOzNkAolr43MbczFZ2VmrW")]
        public bool __slot_FOzNkAolr43MbczFZ2VmrW;
        [n1.ElementAttribute(TracingId = 88263U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OpNkDQWnVASNcfjGgMxmR1", Name = "__slot_OpNkDQWnVASNcfjGgMxmR1")]
        public static n3.Vector3 __slot_OpNkDQWnVASNcfjGgMxmR1 = n1.CompilationHelper.Deserialize<n3.Vector3>("1000, 1000, 1000", false, "RMDMfKmnIrVPStLdWe8u30", "OpNkDQWnVASNcfjGgMxmR1");
        [n1.ElementAttribute(TracingId = 88055U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MH0F5TwVhhVMleOQDdEHoR", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3> __p_MH0F5TwVhhVMleOQDdEHoR;
        [n1.ElementAttribute(TracingId = 87935U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "M8CskD3XiOBPRSu0RfV8dH", Name = "Gizmo", IsManaged = true, IsAutoGenerated = true)]
        public n34.Gizmo_VCf0qns0epcMnUFCEx67yz __p_M8CskD3XiOBPRSu0RfV8dH;
        [n1.ElementAttribute(TracingId = 88245U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KI0Ho8FQ7vsPqMopP0hvbk", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KI0Ho8FQ7vsPqMopP0hvbk;
        [n1.ElementAttribute(TracingId = 88215U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LdijEKHpNbbPJYj8v7IsyV", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<T> __p_LdijEKHpNbbPJYj8v7IsyV;
        [n1.ElementAttribute(TracingId = 87894U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OT1oLEHk6snNii8PBdbeU4", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OT1oLEHk6snNii8PBdbeU4;
        static PointManipulator3d_GQIA7vZy239LZeN2s3lf2n()
        {
        }

        public PointManipulator3d_GQIA7vZy239LZeN2s3lf2n(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointManipulator3d_GQIA7vZy239LZeN2s3lf2n(PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> other): base(other)
        {
            this.__slot_FOzNkAolr43MbczFZ2VmrW = other.__slot_FOzNkAolr43MbczFZ2VmrW;
            this.__p_MH0F5TwVhhVMleOQDdEHoR = other.__p_MH0F5TwVhhVMleOQDdEHoR;
            this.__p_M8CskD3XiOBPRSu0RfV8dH = other.__p_M8CskD3XiOBPRSu0RfV8dH;
            this.__p_KI0Ho8FQ7vsPqMopP0hvbk = other.__p_KI0Ho8FQ7vsPqMopP0hvbk;
            this.__p_LdijEKHpNbbPJYj8v7IsyV = other.__p_LdijEKHpNbbPJYj8v7IsyV;
            this.__p_OT1oLEHk6snNii8PBdbeU4 = other.__p_OT1oLEHk6snNii8PBdbeU4;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_FOzNkAolr43MbczFZ2VmrW", in __slot_FOzNkAolr43MbczFZ2VmrW), n1.CompilationHelper.GetValueOrExisting(values, "__p_MH0F5TwVhhVMleOQDdEHoR", in __p_MH0F5TwVhhVMleOQDdEHoR), n1.CompilationHelper.GetValueOrExisting(values, "__p_M8CskD3XiOBPRSu0RfV8dH", in __p_M8CskD3XiOBPRSu0RfV8dH), n1.CompilationHelper.GetValueOrExisting(values, "__p_KI0Ho8FQ7vsPqMopP0hvbk", in __p_KI0Ho8FQ7vsPqMopP0hvbk), n1.CompilationHelper.GetValueOrExisting(values, "__p_LdijEKHpNbbPJYj8v7IsyV", in __p_LdijEKHpNbbPJYj8v7IsyV), n1.CompilationHelper.GetValueOrExisting(values, "__p_OT1oLEHk6snNii8PBdbeU4", in __p_OT1oLEHk6snNii8PBdbeU4));
        }

        internal PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> __WITH__(bool __slot_FOzNkAolr43MbczFZ2VmrW, n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3> __p_MH0F5TwVhhVMleOQDdEHoR, n34.Gizmo_VCf0qns0epcMnUFCEx67yz __p_M8CskD3XiOBPRSu0RfV8dH, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KI0Ho8FQ7vsPqMopP0hvbk, n41.SPH_RESwCzqU3iTMc4Ig82Av03<T> __p_LdijEKHpNbbPJYj8v7IsyV, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OT1oLEHk6snNii8PBdbeU4)
        {
            n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_FOzNkAolr43MbczFZ2VmrW != this.__slot_FOzNkAolr43MbczFZ2VmrW || __p_MH0F5TwVhhVMleOQDdEHoR != this.__p_MH0F5TwVhhVMleOQDdEHoR || __p_M8CskD3XiOBPRSu0RfV8dH != this.__p_M8CskD3XiOBPRSu0RfV8dH || __p_KI0Ho8FQ7vsPqMopP0hvbk != this.__p_KI0Ho8FQ7vsPqMopP0hvbk || __p_LdijEKHpNbbPJYj8v7IsyV != this.__p_LdijEKHpNbbPJYj8v7IsyV || __p_OT1oLEHk6snNii8PBdbeU4 != this.__p_OT1oLEHk6snNii8PBdbeU4 ? new PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<T>(this)
                {__slot_FOzNkAolr43MbczFZ2VmrW = __slot_FOzNkAolr43MbczFZ2VmrW, __p_MH0F5TwVhhVMleOQDdEHoR = __p_MH0F5TwVhhVMleOQDdEHoR, __p_M8CskD3XiOBPRSu0RfV8dH = __p_M8CskD3XiOBPRSu0RfV8dH, __p_KI0Ho8FQ7vsPqMopP0hvbk = __p_KI0Ho8FQ7vsPqMopP0hvbk, __p_LdijEKHpNbbPJYj8v7IsyV = __p_LdijEKHpNbbPJYj8v7IsyV, __p_OT1oLEHk6snNii8PBdbeU4 = __p_OT1oLEHk6snNii8PBdbeU4} : that_0;
            else
            {
                this.__slot_FOzNkAolr43MbczFZ2VmrW = __slot_FOzNkAolr43MbczFZ2VmrW;
                this.__p_MH0F5TwVhhVMleOQDdEHoR = __p_MH0F5TwVhhVMleOQDdEHoR;
                this.__p_M8CskD3XiOBPRSu0RfV8dH = __p_M8CskD3XiOBPRSu0RfV8dH;
                this.__p_KI0Ho8FQ7vsPqMopP0hvbk = __p_KI0Ho8FQ7vsPqMopP0hvbk;
                this.__p_LdijEKHpNbbPJYj8v7IsyV = __p_LdijEKHpNbbPJYj8v7IsyV;
                this.__p_OT1oLEHk6snNii8PBdbeU4 = __p_OT1oLEHk6snNii8PBdbeU4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 89102U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "D5mpug9GP7kP0E5bw1JEyx", Name = "HandlerDetector_D5mpug9GP7kP0E5bw1JEyx")]
    [n2.SerializableAttribute]
    public class HandlerDetector_D5mpug9GP7kP0E5bw1JEyx : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx Create(n1.NodeContext Node_Context)
        {
            var instance = new HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx CreateDefault()
        {
            var instance = new HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx Update(n3.Ray PickRay_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Sample_In, n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_In, bool Rotate_In, float Pick_Size_In, out bool Edit_in_ViewSpace_Out, out bool Handler_Active_Out, out n3.Vector3 DragPlane_Point_Out, out n3.Vector3 Active_Axis_Out)
        {
            n3.Vector3 __pad_KgPIV5G82w3Lm1IKpKWMBA_0 = __slot_KgPIV5G82w3Lm1IKpKWMBA;
            n3.Vector3 __pad_I6tE3OmqzKDL8mCXYjJGuo_1 = __slot_I6tE3OmqzKDL8mCXYjJGuo;
            float __pad_UGvkSsUwpMBP1rja4NQOO5_2 = __slot_UGvkSsUwpMBP1rja4NQOO5;
            bool Apply_3 = true;
            var __fallback___4 = n1.ServiceRegistry.Current;
            var Output_15 = Points_In;
            if (Apply_3)
            {
                n14._Operations_.Where<n8.EditablePoint_R<n3.Vector3>>(Input_In: Points_In, Predicate_In: (n8.EditablePoint_R<n3.Vector3> Source_In_6, int Index_In_7) =>
                {
                    using var __current_5 = __fallback___4.MakeCurrentIfNone();
                    var Output_9 = Source_In_6.GetSelected(Selected_Out: out bool Selected_8);
                    var Output_11 = Source_In_6.GetHovered(Hovered_Out: out bool Hovered_10);
                    bool Apply_12 = true;
                    var Output_13 = Selected_8;
                    if (Apply_12)
                    {
                        var Output_14 = Selected_8 || Hovered_10;
                        Output_13 = Output_14;
                    }

                    return Output_13;
                }

                , Output_Out: out Output_15);
            }

            n12._Operations_.Average_Selector<n10.Spread<n8.EditablePoint_R<n3.Vector3>>, n8.EditablePoint_R<n3.Vector3>, n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_15, Selector_In: (n8.EditablePoint_R<n3.Vector3> Source_In_17) =>
            {
                using var __current_16 = __fallback___4.MakeCurrentIfNone();
                var Output_19 = Source_In_17.GetPosition(Position_Out: out n3.Vector3 Position_18);
                return Position_18;
            }

            , Result_Out: out n3.Vector3 Result_20);
            bool SetValue_21 = true;
            var Output_22 = this.__p_U3iUi517NdvLXiCInIxSAa;
            if (SetValue_21)
            {
                Output_22 = this.__p_U3iUi517NdvLXiCInIxSAa.SetValue(Value_In: Result_20, Sample_In: Sample_In);
            }

            var Output_24 = Output_22.GetValue(Value_Out: out n3.Vector3 Value_23);
            var Output_25 = new n3.BoundingSphere(center: Value_23, radius: __pad_UGvkSsUwpMBP1rja4NQOO5_2);
            var Result_27 = n3.CollisionHelper.RayIntersectsSphere(ray: ref PickRay_In, sphere: ref Output_25, point: out n3.Vector3 Point_26);
            n3.Matrix Input_28 = n55._Operations_.CreateDefault();
            bool Apply_29 = true;
            var Output_30 = Input_28;
            if (Apply_29)
            {
                n62._Operations_.Translate(Input_In: Input_28, Translation_In: Value_23, Output_Out: out Output_30);
            }

            n10.Spread<n3.Vector3> Input_31 = n14._Operations_.CreateDefault<n3.Vector3>();
            n3.Vector3 Item_32 = n51._Operations_.CreateDefault();
            bool Apply_33 = true;
            var Output_34 = Input_31;
            if (Apply_33)
            {
                n14._Operations_.Add<n3.Vector3>(Input_In: Input_31, Item_In: Item_32, Output_Out: out Output_34);
            }

            bool Apply_35 = true;
            var Output_36 = Output_34;
            if (Apply_35)
            {
                n14._Operations_.Add<n3.Vector3>(Input_In: Output_34, Item_In: __pad_KgPIV5G82w3Lm1IKpKWMBA_0, Output_Out: out Output_36);
            }

            bool Apply_37 = true;
            var Output_38 = Output_36;
            if (Apply_37)
            {
                n14._Operations_.Add<n3.Vector3>(Input_In: Output_36, Item_In: __pad_I6tE3OmqzKDL8mCXYjJGuo_1, Output_Out: out Output_38);
            }

            var Output_41 = this.__p_UGUE61wTrBUNvFwbSptwSV.Update<n10.Spread<n3.Vector3>>(Ray_In: PickRay_In, Triad_Center_In: Output_30, Pick_Size_In: Pick_Size_In, Axis_Rotations_In: Output_38, Axis_Out: out n3.Vector3 Axis_39, Hit_Position_Out: out n3.Vector3 Hit_Position_40);
            var Output_44 = this.__p_OwDsMtqIIixL5hhQRDbGAl.Update<n10.Spread<n3.Vector3>, float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Ray_In: PickRay_In, Triad_Center_In: Output_30, Axis_Rotations_In: Output_38, Pick_Size_In: Pick_Size_In, Axis_Out: out n3.Vector3 Axis_42, Hit_Position_Out: out bool Hit_Position_43);
            n51._Operations_.Any(Input_In: Axis_42, Result_Out: out bool Result_45);
            n14._Operations_.Count<n8.EditablePoint_R<n3.Vector3>>(Input_In: Output_15, Count_Out: out int Count_46);
            int Input_2_47 = 0;
            var Result_48 = Count_46 > Input_2_47;
            bool Apply_49 = true;
            var Output_50 = Result_45;
            if (Apply_49)
            {
                var Output_51 = Result_45 && Result_48;
                Output_50 = Output_51;
            }

            n51._Operations_.Any(Input_In: Axis_39, Result_Out: out bool Result_52);
            bool Apply_53 = true;
            var Output_54 = Result_52;
            if (Apply_53)
            {
                var Output_55 = Result_52 && Result_48;
                Output_54 = Output_55;
            }

            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Rotate_In, Input_In: Axis_39, Input_2_In: Axis_42, Output_Out: out n3.Vector3 Output_56);
            bool Apply_57 = true;
            var Output_58 = Result_27;
            if (Apply_57)
            {
                var Output_59 = Result_27 && Result_48;
                Output_58 = Output_59;
            }

            bool Apply_60 = true;
            var Output_61 = Output_58;
            if (Apply_60)
            {
                var Output_62 = Output_58 || Output_54;
                Output_61 = Output_62;
            }

            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Output_58, Input_In: Hit_Position_40, Input_2_In: Point_26, Output_Out: out n3.Vector3 Output_63);
            n3.Vector3 __pad_BMAd8RIJ6DSQNbaGuqZey3_64 = Axis_42;
            Edit_in_ViewSpace_Out = Output_58;
            Handler_Active_Out = Output_61;
            DragPlane_Point_Out = Output_63;
            Active_Axis_Out = Axis_39;
            n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx that_65 = this;
            if (this.__GetContext__().IsImmutable)
                that_65 = Output_24 != this.__p_U3iUi517NdvLXiCInIxSAa || Output_41 != this.__p_UGUE61wTrBUNvFwbSptwSV || Output_44 != this.__p_OwDsMtqIIixL5hhQRDbGAl || Axis_42 != this.__slot_BMAd8RIJ6DSQNbaGuqZey3 ? new HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(this)
                {__p_U3iUi517NdvLXiCInIxSAa = Output_24, __p_UGUE61wTrBUNvFwbSptwSV = Output_41, __p_OwDsMtqIIixL5hhQRDbGAl = Output_44, __slot_BMAd8RIJ6DSQNbaGuqZey3 = Axis_42} : that_65;
            else
            {
                this.__p_U3iUi517NdvLXiCInIxSAa = Output_24;
                this.__p_UGUE61wTrBUNvFwbSptwSV = Output_41;
                this.__p_OwDsMtqIIixL5hhQRDbGAl = Output_44;
                this.__slot_BMAd8RIJ6DSQNbaGuqZey3 = Axis_42;
            }

            return that_65;
        }

        public n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "UGUE61wTrBUNvFwbSptwSV", 89177U);
            var Output_1 = n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "U3iUi517NdvLXiCInIxSAa", 89228U);
            n3.Vector3 Initial_Value_3 = n51._Operations_.CreateDefault();
            var Output_4 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.Create(Node_Context: Node_Context_2, Initial_Value_In: Initial_Value_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "OwDsMtqIIixL5hhQRDbGAl", 89431U);
            var Output_6 = n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270.Create(Node_Context: Node_Context_5);
            n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx that_7 = this;
            this.__slot_BMAd8RIJ6DSQNbaGuqZey3 = n51._Operations_.CreateDefault();
            this.__p_UGUE61wTrBUNvFwbSptwSV = Output_1;
            this.__p_U3iUi517NdvLXiCInIxSAa = Output_4;
            this.__p_OwDsMtqIIixL5hhQRDbGAl = Output_6;
            return that_7;
        }

        public n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx __CreateDefault__()
        {
            n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx that_0 = this;
            this.__slot_BMAd8RIJ6DSQNbaGuqZey3 = n51._Operations_.CreateDefault();
            this.__p_U3iUi517NdvLXiCInIxSAa = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.CreateDefault();
            this.__p_UGUE61wTrBUNvFwbSptwSV = n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y.CreateDefault();
            this.__p_OwDsMtqIIixL5hhQRDbGAl = n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_U3iUi517NdvLXiCInIxSAa);
            n1.CompilationHelper.SafeDispose(this.__p_UGUE61wTrBUNvFwbSptwSV);
            n1.CompilationHelper.SafeDispose(this.__p_OwDsMtqIIixL5hhQRDbGAl);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 89155U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UGvkSsUwpMBP1rja4NQOO5", Name = "__slot_UGvkSsUwpMBP1rja4NQOO5")]
        public static float __slot_UGvkSsUwpMBP1rja4NQOO5 = 0.0200000033F;
        [n1.ElementAttribute(TracingId = 89161U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I6tE3OmqzKDL8mCXYjJGuo", Name = "__slot_I6tE3OmqzKDL8mCXYjJGuo")]
        public static n3.Vector3 __slot_I6tE3OmqzKDL8mCXYjJGuo = n1.CompilationHelper.Deserialize<n3.Vector3>("0, -0.25000006, 0", false, "RMDMfKmnIrVPStLdWe8u30", "I6tE3OmqzKDL8mCXYjJGuo");
        [n1.ElementAttribute(TracingId = 89170U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KgPIV5G82w3Lm1IKpKWMBA", Name = "__slot_KgPIV5G82w3Lm1IKpKWMBA")]
        public static n3.Vector3 __slot_KgPIV5G82w3Lm1IKpKWMBA = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 0.25000006", false, "RMDMfKmnIrVPStLdWe8u30", "KgPIV5G82w3Lm1IKpKWMBA");
        [n1.ElementAttribute(TracingId = 89172U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QxZYx3l9FmyLed4tvX8Joc", Name = "__slot_QxZYx3l9FmyLed4tvX8Joc")]
        public static string __slot_QxZYx3l9FmyLed4tvX8Joc = "< todo: extra handler for rotation/scaling";
        [n1.ElementAttribute(TracingId = 89465U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BMAd8RIJ6DSQNbaGuqZey3", Name = "__slot_BMAd8RIJ6DSQNbaGuqZey3")]
        public n3.Vector3 __slot_BMAd8RIJ6DSQNbaGuqZey3;
        [n1.ElementAttribute(TracingId = 89228U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "U3iUi517NdvLXiCInIxSAa", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_U3iUi517NdvLXiCInIxSAa;
        [n1.ElementAttribute(TracingId = 89177U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UGUE61wTrBUNvFwbSptwSV", Name = "TranslateAxisDetection", IsManaged = true, IsAutoGenerated = true)]
        public n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y __p_UGUE61wTrBUNvFwbSptwSV;
        [n1.ElementAttribute(TracingId = 89431U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OwDsMtqIIixL5hhQRDbGAl", Name = "RotateAxisDetection", IsManaged = true, IsAutoGenerated = true)]
        public n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 __p_OwDsMtqIIixL5hhQRDbGAl;
        static HandlerDetector_D5mpug9GP7kP0E5bw1JEyx()
        {
        }

        public HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(HandlerDetector_D5mpug9GP7kP0E5bw1JEyx other): base(other)
        {
            this.__slot_BMAd8RIJ6DSQNbaGuqZey3 = other.__slot_BMAd8RIJ6DSQNbaGuqZey3;
            this.__p_U3iUi517NdvLXiCInIxSAa = other.__p_U3iUi517NdvLXiCInIxSAa;
            this.__p_UGUE61wTrBUNvFwbSptwSV = other.__p_UGUE61wTrBUNvFwbSptwSV;
            this.__p_OwDsMtqIIixL5hhQRDbGAl = other.__p_OwDsMtqIIixL5hhQRDbGAl;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_BMAd8RIJ6DSQNbaGuqZey3", in __slot_BMAd8RIJ6DSQNbaGuqZey3), n1.CompilationHelper.GetValueOrExisting(values, "__p_U3iUi517NdvLXiCInIxSAa", in __p_U3iUi517NdvLXiCInIxSAa), n1.CompilationHelper.GetValueOrExisting(values, "__p_UGUE61wTrBUNvFwbSptwSV", in __p_UGUE61wTrBUNvFwbSptwSV), n1.CompilationHelper.GetValueOrExisting(values, "__p_OwDsMtqIIixL5hhQRDbGAl", in __p_OwDsMtqIIixL5hhQRDbGAl));
        }

        internal HandlerDetector_D5mpug9GP7kP0E5bw1JEyx __WITH__(n3.Vector3 __slot_BMAd8RIJ6DSQNbaGuqZey3, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_U3iUi517NdvLXiCInIxSAa, n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y __p_UGUE61wTrBUNvFwbSptwSV, n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 __p_OwDsMtqIIixL5hhQRDbGAl)
        {
            n38.HandlerDetector_D5mpug9GP7kP0E5bw1JEyx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_BMAd8RIJ6DSQNbaGuqZey3 != this.__slot_BMAd8RIJ6DSQNbaGuqZey3 || __p_U3iUi517NdvLXiCInIxSAa != this.__p_U3iUi517NdvLXiCInIxSAa || __p_UGUE61wTrBUNvFwbSptwSV != this.__p_UGUE61wTrBUNvFwbSptwSV || __p_OwDsMtqIIixL5hhQRDbGAl != this.__p_OwDsMtqIIixL5hhQRDbGAl ? new HandlerDetector_D5mpug9GP7kP0E5bw1JEyx(this)
                {__slot_BMAd8RIJ6DSQNbaGuqZey3 = __slot_BMAd8RIJ6DSQNbaGuqZey3, __p_U3iUi517NdvLXiCInIxSAa = __p_U3iUi517NdvLXiCInIxSAa, __p_UGUE61wTrBUNvFwbSptwSV = __p_UGUE61wTrBUNvFwbSptwSV, __p_OwDsMtqIIixL5hhQRDbGAl = __p_OwDsMtqIIixL5hhQRDbGAl} : that_0;
            else
            {
                this.__slot_BMAd8RIJ6DSQNbaGuqZey3 = __slot_BMAd8RIJ6DSQNbaGuqZey3;
                this.__p_U3iUi517NdvLXiCInIxSAa = __p_U3iUi517NdvLXiCInIxSAa;
                this.__p_UGUE61wTrBUNvFwbSptwSV = __p_UGUE61wTrBUNvFwbSptwSV;
                this.__p_OwDsMtqIIixL5hhQRDbGAl = __p_OwDsMtqIIixL5hhQRDbGAl;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 89754U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RNbycIqTva7MrNMrGLx270", Name = "RotateAxisDetection_RNbycIqTva7MrNMrGLx270")]
    [n2.SerializableAttribute]
    public class RotateAxisDetection_RNbycIqTva7MrNMrGLx270 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 Create(n1.NodeContext Node_Context)
        {
            var instance = new RotateAxisDetection_RNbycIqTva7MrNMrGLx270(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 CreateDefault()
        {
            var instance = new RotateAxisDetection_RNbycIqTva7MrNMrGLx270(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 Update<T2, T, AdM>(n3.Ray Ray_In, n3.Matrix Triad_Center_In, T2 Axis_Rotations_In, T Pick_Size_In, out n3.Vector3 Axis_Out, out bool Hit_Position_Out)
            where T2 : n23.IEnumerable<n3.Vector3> where AdM : struct, n21.IAdaptiveLength<T>
        {
            var w_0 = default(AdM);
            int __pad_PNLJxG5bZ2VML3BjkOUiUR_1 = __slot_PNLJxG5bZ2VML3BjkOUiUR;
            int __pad_O3IiioYdF2OMmjUvqlVmqb_2 = __slot_O3IiioYdF2OMmjUvqlVmqb;
            float __pad_VsjAy4BUNVLMoip3vucVCS_3 = __slot_VsjAy4BUNVLMoip3vucVCS;
            w_0.Length(Input_In: Pick_Size_In, Result_Out: out float Result_4);
            bool Apply_5 = true;
            var Output_6 = Result_4;
            if (Apply_5)
            {
                var Output_7 = Result_4 * __pad_VsjAy4BUNVLMoip3vucVCS_3;
                Output_6 = Output_7;
            }

            var Translation_Vector_8 = Triad_Center_In.TranslationVector;
            var builder_27 = n6.CollectionBuilders.GetBuilder(this.__cp_AdEnnNH1rqNNjzGC8Pvloi, 16);
            n10.Spread<bool> output_28;
            var builder_29 = n6.CollectionBuilders.GetBuilder(this.__cp_T1UmVeGBpkTNpinYa4mVGh, 16);
            n10.Spread<float> output_30;
            var builder_31 = n6.CollectionBuilders.GetBuilder(this.__cp_UgbsPEVvaX0Laj8vQirXoZ, 16);
            n10.Spread<bool> output_32;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in Axis_Rotations_In)
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n3.Vector3 __pad_F4lukFlwE1xL22y5PiDboG_14 = __slot_F4lukFlwE1xL22y5PiDboG;
                    bool Apply_15 = true;
                    var Output_16 = Triad_Center_In;
                    if (Apply_15)
                    {
                        n62._Operations_.Rotate(Input_In: Triad_Center_In, Rotation_In: splicer_10, Output_Out: out Output_16);
                    }

                    n3.Vector3 Point_17 = n51._Operations_.CreateDefault();
                    var Output_18 = new n3.Plane(point: Point_17, normal: __pad_F4lukFlwE1xL22y5PiDboG_14);
                    n3.Plane.Transform(plane: ref Output_18, transformation: ref Output_16, result: out n3.Plane Output_19);
                    var Result_21 = n3.CollisionHelper.RayIntersectsPlane(ray: ref Ray_In, plane: ref Output_19, point: out n3.Vector3 Point_20);
                    n47._Operations_.Distance<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Point_20, Input_2_In: Translation_Vector_8, Result_Out: out float Result_22);
                    var Result_23 = Result_22 < Output_6;
                    bool Apply_24 = true;
                    var Output_25 = Result_21;
                    if (Apply_24)
                    {
                        var Output_26 = Result_21 && Result_23;
                        Output_25 = Output_26;
                    }

                    builder_27.Add(Output_25);
                    builder_29.Add(Result_22);
                    builder_31.Add(Result_23);
                    i_11++;
                }
            }
            finally
            {
                output_28 = builder_27.Commit();
                output_30 = builder_29.Commit();
                output_32 = builder_31.Commit();
            }

            bool Default_Value_33 = false;
            int Index_34 = 0;
            n14._Operations_.GetSlice<bool>(Input_In: output_28, Default_Value_In: Default_Value_33, Index_In: Index_34, Result_Out: out bool Result_35);
            float X_36 = n2.Convert.ToSingle(Result_35);
            bool Default_Value_37 = false;
            n14._Operations_.GetSlice<bool>(Input_In: output_28, Default_Value_In: Default_Value_37, Index_In: __pad_PNLJxG5bZ2VML3BjkOUiUR_1, Result_Out: out bool Result_38);
            float Y_39 = n2.Convert.ToSingle(Result_38);
            bool Default_Value_40 = false;
            n14._Operations_.GetSlice<bool>(Input_In: output_28, Default_Value_In: Default_Value_40, Index_In: __pad_O3IiioYdF2OMmjUvqlVmqb_2, Result_Out: out bool Result_41);
            float Z_42 = n2.Convert.ToSingle(Result_41);
            var Output_43 = new n3.Vector3(x: X_36, y: Y_39, z: Z_42);
            n14._Operations_.Select<n10.Spread<bool>, bool, n10.Spread<bool>>(Input_In: output_32, Alive_Values_In: output_28, Output_Out: out n10.Spread<bool> Output_44);
            n10.Spread<bool> __pad_LQoQQPmhV3lQYQPpE4Nxp3_45 = output_32;
            bool Default_Value_46 = false;
            n12._Operations_.FirstOrDefault<n10.Spread<bool>, bool>(Input_In: Output_44, Default_Value_In: Default_Value_46, Output_Out: out n10.Spread<bool> Output_47, Result_Out: out bool Result_48);
            n10.Spread<float> __pad_IjEz4A4BFVsP74v89Kb48o_49 = output_30;
            Axis_Out = Output_43;
            Hit_Position_Out = Result_48;
            n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 that_50 = this;
            if (this.__GetContext__().IsImmutable)
                that_50 = output_28 != this.__cp_AdEnnNH1rqNNjzGC8Pvloi || output_30 != this.__cp_T1UmVeGBpkTNpinYa4mVGh || output_32 != this.__cp_UgbsPEVvaX0Laj8vQirXoZ || output_32 != this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 || output_30 != this.__slot_IjEz4A4BFVsP74v89Kb48o ? new RotateAxisDetection_RNbycIqTva7MrNMrGLx270(this)
                {__cp_AdEnnNH1rqNNjzGC8Pvloi = output_28, __cp_T1UmVeGBpkTNpinYa4mVGh = output_30, __cp_UgbsPEVvaX0Laj8vQirXoZ = output_32, __slot_LQoQQPmhV3lQYQPpE4Nxp3 = output_32, __slot_IjEz4A4BFVsP74v89Kb48o = output_30} : that_50;
            else
            {
                this.__cp_AdEnnNH1rqNNjzGC8Pvloi = output_28;
                this.__cp_T1UmVeGBpkTNpinYa4mVGh = output_30;
                this.__cp_UgbsPEVvaX0Laj8vQirXoZ = output_32;
                this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 = output_32;
                this.__slot_IjEz4A4BFVsP74v89Kb48o = output_30;
            }

            return that_50;
        }

        public n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 that_0 = this;
            this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 = n14._Operations_.CreateDefault<bool>();
            this.__slot_IjEz4A4BFVsP74v89Kb48o = n14._Operations_.CreateDefault<float>();
            this.__cp_AdEnnNH1rqNNjzGC8Pvloi = n14._Operations_.CreateDefault<bool>();
            this.__cp_T1UmVeGBpkTNpinYa4mVGh = n14._Operations_.CreateDefault<float>();
            this.__cp_UgbsPEVvaX0Laj8vQirXoZ = n14._Operations_.CreateDefault<bool>();
            return that_0;
        }

        public n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 __CreateDefault__()
        {
            n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 that_0 = this;
            this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 = n14._Operations_.CreateDefault<bool>();
            this.__slot_IjEz4A4BFVsP74v89Kb48o = n14._Operations_.CreateDefault<float>();
            this.__cp_AdEnnNH1rqNNjzGC8Pvloi = n14._Operations_.CreateDefault<bool>();
            this.__cp_T1UmVeGBpkTNpinYa4mVGh = n14._Operations_.CreateDefault<float>();
            this.__cp_UgbsPEVvaX0Laj8vQirXoZ = n14._Operations_.CreateDefault<bool>();
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

        [n1.ElementAttribute(TracingId = 89794U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "O3IiioYdF2OMmjUvqlVmqb", Name = "__slot_O3IiioYdF2OMmjUvqlVmqb")]
        public static int __slot_O3IiioYdF2OMmjUvqlVmqb = 2;
        [n1.ElementAttribute(TracingId = 89796U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PNLJxG5bZ2VML3BjkOUiUR", Name = "__slot_PNLJxG5bZ2VML3BjkOUiUR")]
        public static int __slot_PNLJxG5bZ2VML3BjkOUiUR = 1;
        [n1.ElementAttribute(TracingId = 89801U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VsjAy4BUNVLMoip3vucVCS", Name = "__slot_VsjAy4BUNVLMoip3vucVCS")]
        public static float __slot_VsjAy4BUNVLMoip3vucVCS = 3F;
        [n1.ElementAttribute(TracingId = 89865U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LQoQQPmhV3lQYQPpE4Nxp3", Name = "__slot_LQoQQPmhV3lQYQPpE4Nxp3")]
        public n10.Spread<bool> __slot_LQoQQPmhV3lQYQPpE4Nxp3;
        [n1.ElementAttribute(TracingId = 89867U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IjEz4A4BFVsP74v89Kb48o", Name = "__slot_IjEz4A4BFVsP74v89Kb48o")]
        public n10.Spread<float> __slot_IjEz4A4BFVsP74v89Kb48o;
        [n1.ElementAttribute(TracingId = 89880U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F4lukFlwE1xL22y5PiDboG", Name = "__slot_F4lukFlwE1xL22y5PiDboG")]
        public static n3.Vector3 __slot_F4lukFlwE1xL22y5PiDboG = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0, 0", false, "RMDMfKmnIrVPStLdWe8u30", "F4lukFlwE1xL22y5PiDboG");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<bool> __cp_AdEnnNH1rqNNjzGC8Pvloi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<float> __cp_T1UmVeGBpkTNpinYa4mVGh;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<bool> __cp_UgbsPEVvaX0Laj8vQirXoZ;
        static RotateAxisDetection_RNbycIqTva7MrNMrGLx270()
        {
        }

        public RotateAxisDetection_RNbycIqTva7MrNMrGLx270(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RotateAxisDetection_RNbycIqTva7MrNMrGLx270(RotateAxisDetection_RNbycIqTva7MrNMrGLx270 other): base(other)
        {
            this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 = other.__slot_LQoQQPmhV3lQYQPpE4Nxp3;
            this.__slot_IjEz4A4BFVsP74v89Kb48o = other.__slot_IjEz4A4BFVsP74v89Kb48o;
            this.__cp_AdEnnNH1rqNNjzGC8Pvloi = other.__cp_AdEnnNH1rqNNjzGC8Pvloi;
            this.__cp_T1UmVeGBpkTNpinYa4mVGh = other.__cp_T1UmVeGBpkTNpinYa4mVGh;
            this.__cp_UgbsPEVvaX0Laj8vQirXoZ = other.__cp_UgbsPEVvaX0Laj8vQirXoZ;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LQoQQPmhV3lQYQPpE4Nxp3", in __slot_LQoQQPmhV3lQYQPpE4Nxp3), n1.CompilationHelper.GetValueOrExisting(values, "__slot_IjEz4A4BFVsP74v89Kb48o", in __slot_IjEz4A4BFVsP74v89Kb48o), n1.CompilationHelper.GetValueOrExisting(values, "__cp_AdEnnNH1rqNNjzGC8Pvloi", in __cp_AdEnnNH1rqNNjzGC8Pvloi), n1.CompilationHelper.GetValueOrExisting(values, "__cp_T1UmVeGBpkTNpinYa4mVGh", in __cp_T1UmVeGBpkTNpinYa4mVGh), n1.CompilationHelper.GetValueOrExisting(values, "__cp_UgbsPEVvaX0Laj8vQirXoZ", in __cp_UgbsPEVvaX0Laj8vQirXoZ));
        }

        internal RotateAxisDetection_RNbycIqTva7MrNMrGLx270 __WITH__(n10.Spread<bool> __slot_LQoQQPmhV3lQYQPpE4Nxp3, n10.Spread<float> __slot_IjEz4A4BFVsP74v89Kb48o, n10.Spread<bool> __cp_AdEnnNH1rqNNjzGC8Pvloi, n10.Spread<float> __cp_T1UmVeGBpkTNpinYa4mVGh, n10.Spread<bool> __cp_UgbsPEVvaX0Laj8vQirXoZ)
        {
            n38.RotateAxisDetection_RNbycIqTva7MrNMrGLx270 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_LQoQQPmhV3lQYQPpE4Nxp3 != this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 || __slot_IjEz4A4BFVsP74v89Kb48o != this.__slot_IjEz4A4BFVsP74v89Kb48o || __cp_AdEnnNH1rqNNjzGC8Pvloi != this.__cp_AdEnnNH1rqNNjzGC8Pvloi || __cp_T1UmVeGBpkTNpinYa4mVGh != this.__cp_T1UmVeGBpkTNpinYa4mVGh || __cp_UgbsPEVvaX0Laj8vQirXoZ != this.__cp_UgbsPEVvaX0Laj8vQirXoZ ? new RotateAxisDetection_RNbycIqTva7MrNMrGLx270(this)
                {__slot_LQoQQPmhV3lQYQPpE4Nxp3 = __slot_LQoQQPmhV3lQYQPpE4Nxp3, __slot_IjEz4A4BFVsP74v89Kb48o = __slot_IjEz4A4BFVsP74v89Kb48o, __cp_AdEnnNH1rqNNjzGC8Pvloi = __cp_AdEnnNH1rqNNjzGC8Pvloi, __cp_T1UmVeGBpkTNpinYa4mVGh = __cp_T1UmVeGBpkTNpinYa4mVGh, __cp_UgbsPEVvaX0Laj8vQirXoZ = __cp_UgbsPEVvaX0Laj8vQirXoZ} : that_0;
            else
            {
                this.__slot_LQoQQPmhV3lQYQPpE4Nxp3 = __slot_LQoQQPmhV3lQYQPpE4Nxp3;
                this.__slot_IjEz4A4BFVsP74v89Kb48o = __slot_IjEz4A4BFVsP74v89Kb48o;
                this.__cp_AdEnnNH1rqNNjzGC8Pvloi = __cp_AdEnnNH1rqNNjzGC8Pvloi;
                this.__cp_T1UmVeGBpkTNpinYa4mVGh = __cp_T1UmVeGBpkTNpinYa4mVGh;
                this.__cp_UgbsPEVvaX0Laj8vQirXoZ = __cp_UgbsPEVvaX0Laj8vQirXoZ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 90051U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BqtC7Hby5zRLTdvJl8kZ1Y", Name = "TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y")]
    [n2.SerializableAttribute]
    public class TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y Create(n1.NodeContext Node_Context)
        {
            var instance = new TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y CreateDefault()
        {
            var instance = new TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y Update<T>(n3.Ray Ray_In, n3.Matrix Triad_Center_In, float Pick_Size_In, T Axis_Rotations_In, out n3.Vector3 Axis_Out, out n3.Vector3 Hit_Position_Out)
            where T : n23.IEnumerable<n3.Vector3>
        {
            int __pad_Kcg8FggPAKUM2ju8QrGqO2_0 = __slot_Kcg8FggPAKUM2ju8QrGqO2;
            int __pad_R8mKLZWp9K2NYcT8Ecz1xC_1 = __slot_R8mKLZWp9K2NYcT8Ecz1xC;
            float __pad_R71h0AUIRvbLM8mnzN9kai_2 = __slot_R71h0AUIRvbLM8mnzN9kai;
            var Output_3 = new n3.Vector3(x: Pick_Size_In, y: Pick_Size_In, z: Pick_Size_In);
            bool Apply_4 = true;
            var Output_5 = Output_3;
            if (Apply_4)
            {
                n46.Vector3Nodes.Scale(input: ref Output_3, scalar: __pad_R71h0AUIRvbLM8mnzN9kai_2, output: out n3.Vector3 Output_6);
                Output_5 = Output_6;
            }

            var builder_24 = n6.CollectionBuilders.GetBuilder(this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY, 16);
            n10.Spread<bool> output_25;
            var builder_26 = n6.CollectionBuilders.GetBuilder(this.__cp_VIgJNx3OX29LbLtUWmtnLk, 16);
            n10.Spread<n3.Vector3> output_27;
            try
            {
                var i_9 = 0;
                foreach (var item_7 in Axis_Rotations_In)
                {
                    var splicer_8 = item_7;
                    var i_local_10 = i_9;
                    n3.Vector3 __pad_NQFl4e92VtnLmqU7lrpxpC_12 = __slot_NQFl4e92VtnLmqU7lrpxpC;
                    n3.Vector3 __pad_SV469PXqF8tO2RTfpnETGw_13 = __slot_SV469PXqF8tO2RTfpnETGw;
                    bool Apply_14 = true;
                    var Output_15 = Triad_Center_In;
                    if (Apply_14)
                    {
                        n62._Operations_.Rotate(Input_In: Triad_Center_In, Rotation_In: splicer_8, Output_Out: out Output_15);
                    }

                    bool Apply_16 = true;
                    var Output_17 = Output_15;
                    if (Apply_16)
                    {
                        n62._Operations_.Scale(Input_In: Output_15, Scaling_In: Output_5, Output_Out: out Output_17);
                    }

                    var Output_18 = new n46.OrientedBoundingBox(minimum: __pad_NQFl4e92VtnLmqU7lrpxpC_12, maximum: __pad_SV469PXqF8tO2RTfpnETGw_13);
                    bool Apply_19 = true;
                    var Output_20 = Output_18;
                    if (Apply_19)
                    {
                        var Output_21 = n46.BoxExtensions.Transform(input: ref Output_18, transformation: ref Output_17);
                        Output_20 = Output_21;
                    }

                    var Result_23 = Output_20.Intersects(ray: ref Ray_In, point: out n3.Vector3 Point_22);
                    builder_24.Add(Result_23);
                    builder_26.Add(Point_22);
                    i_9++;
                }
            }
            finally
            {
                output_25 = builder_24.Commit();
                output_27 = builder_26.Commit();
            }

            bool Default_Value_28 = false;
            int Index_29 = 0;
            n14._Operations_.GetSlice<bool>(Input_In: output_25, Default_Value_In: Default_Value_28, Index_In: Index_29, Result_Out: out bool Result_30);
            float X_31 = n2.Convert.ToSingle(Result_30);
            bool Default_Value_32 = false;
            n14._Operations_.GetSlice<bool>(Input_In: output_25, Default_Value_In: Default_Value_32, Index_In: __pad_Kcg8FggPAKUM2ju8QrGqO2_0, Result_Out: out bool Result_33);
            float Y_34 = n2.Convert.ToSingle(Result_33);
            bool Default_Value_35 = false;
            n14._Operations_.GetSlice<bool>(Input_In: output_25, Default_Value_In: Default_Value_35, Index_In: __pad_R8mKLZWp9K2NYcT8Ecz1xC_1, Result_Out: out bool Result_36);
            float Z_37 = n2.Convert.ToSingle(Result_36);
            var Output_38 = new n3.Vector3(x: X_31, y: Y_34, z: Z_37);
            n3.Vector3 __pad_JLYPJEvry8eNMofNTbGs1I_39 = Output_38;
            n14._Operations_.Select<n10.Spread<n3.Vector3>, n3.Vector3, n10.Spread<bool>>(Input_In: output_27, Alive_Values_In: output_25, Output_Out: out n10.Spread<n3.Vector3> Output_40);
            n3.Vector3 Default_Value_41 = n51._Operations_.CreateDefault();
            n12._Operations_.FirstOrDefault<n10.Spread<n3.Vector3>, n3.Vector3>(Input_In: Output_40, Default_Value_In: Default_Value_41, Output_Out: out n10.Spread<n3.Vector3> Output_42, Result_Out: out n3.Vector3 Result_43);
            Axis_Out = Output_38;
            Hit_Position_Out = Result_43;
            n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y that_44 = this;
            if (this.__GetContext__().IsImmutable)
                that_44 = output_25 != this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY || output_27 != this.__cp_VIgJNx3OX29LbLtUWmtnLk || Output_38 != this.__slot_JLYPJEvry8eNMofNTbGs1I ? new TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(this)
                {__cp_F1Lq6Asqc9kP6mR2Ul0xBY = output_25, __cp_VIgJNx3OX29LbLtUWmtnLk = output_27, __slot_JLYPJEvry8eNMofNTbGs1I = Output_38} : that_44;
            else
            {
                this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY = output_25;
                this.__cp_VIgJNx3OX29LbLtUWmtnLk = output_27;
                this.__slot_JLYPJEvry8eNMofNTbGs1I = Output_38;
            }

            return that_44;
        }

        public n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y that_0 = this;
            this.__slot_JLYPJEvry8eNMofNTbGs1I = n51._Operations_.CreateDefault();
            this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY = n14._Operations_.CreateDefault<bool>();
            this.__cp_VIgJNx3OX29LbLtUWmtnLk = n14._Operations_.CreateDefault<n3.Vector3>();
            return that_0;
        }

        public n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y __CreateDefault__()
        {
            n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y that_0 = this;
            this.__slot_JLYPJEvry8eNMofNTbGs1I = n51._Operations_.CreateDefault();
            this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY = n14._Operations_.CreateDefault<bool>();
            this.__cp_VIgJNx3OX29LbLtUWmtnLk = n14._Operations_.CreateDefault<n3.Vector3>();
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

        [n1.ElementAttribute(TracingId = 90074U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "R71h0AUIRvbLM8mnzN9kai", Name = "__slot_R71h0AUIRvbLM8mnzN9kai")]
        public static float __slot_R71h0AUIRvbLM8mnzN9kai = 6F;
        [n1.ElementAttribute(TracingId = 90079U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "R8mKLZWp9K2NYcT8Ecz1xC", Name = "__slot_R8mKLZWp9K2NYcT8Ecz1xC")]
        public static int __slot_R8mKLZWp9K2NYcT8Ecz1xC = 2;
        [n1.ElementAttribute(TracingId = 90081U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Kcg8FggPAKUM2ju8QrGqO2", Name = "__slot_Kcg8FggPAKUM2ju8QrGqO2")]
        public static int __slot_Kcg8FggPAKUM2ju8QrGqO2 = 1;
        [n1.ElementAttribute(TracingId = 90158U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JLYPJEvry8eNMofNTbGs1I", Name = "__slot_JLYPJEvry8eNMofNTbGs1I")]
        public n3.Vector3 __slot_JLYPJEvry8eNMofNTbGs1I;
        [n1.ElementAttribute(TracingId = 90171U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NQFl4e92VtnLmqU7lrpxpC", Name = "__slot_NQFl4e92VtnLmqU7lrpxpC")]
        public static n3.Vector3 __slot_NQFl4e92VtnLmqU7lrpxpC = n1.CompilationHelper.Deserialize<n3.Vector3>("0.25000006, -0.099999994, -0.099999994", false, "RMDMfKmnIrVPStLdWe8u30", "NQFl4e92VtnLmqU7lrpxpC");
        [n1.ElementAttribute(TracingId = 90169U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SV469PXqF8tO2RTfpnETGw", Name = "__slot_SV469PXqF8tO2RTfpnETGw")]
        public static n3.Vector3 __slot_SV469PXqF8tO2RTfpnETGw = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0.1, 0.09999999", false, "RMDMfKmnIrVPStLdWe8u30", "SV469PXqF8tO2RTfpnETGw");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<bool> __cp_F1Lq6Asqc9kP6mR2Ul0xBY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __cp_VIgJNx3OX29LbLtUWmtnLk;
        static TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y()
        {
        }

        public TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y other): base(other)
        {
            this.__slot_JLYPJEvry8eNMofNTbGs1I = other.__slot_JLYPJEvry8eNMofNTbGs1I;
            this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY = other.__cp_F1Lq6Asqc9kP6mR2Ul0xBY;
            this.__cp_VIgJNx3OX29LbLtUWmtnLk = other.__cp_VIgJNx3OX29LbLtUWmtnLk;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_JLYPJEvry8eNMofNTbGs1I", in __slot_JLYPJEvry8eNMofNTbGs1I), n1.CompilationHelper.GetValueOrExisting(values, "__cp_F1Lq6Asqc9kP6mR2Ul0xBY", in __cp_F1Lq6Asqc9kP6mR2Ul0xBY), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VIgJNx3OX29LbLtUWmtnLk", in __cp_VIgJNx3OX29LbLtUWmtnLk));
        }

        internal TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y __WITH__(n3.Vector3 __slot_JLYPJEvry8eNMofNTbGs1I, n10.Spread<bool> __cp_F1Lq6Asqc9kP6mR2Ul0xBY, n10.Spread<n3.Vector3> __cp_VIgJNx3OX29LbLtUWmtnLk)
        {
            n38.TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_JLYPJEvry8eNMofNTbGs1I != this.__slot_JLYPJEvry8eNMofNTbGs1I || __cp_F1Lq6Asqc9kP6mR2Ul0xBY != this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY || __cp_VIgJNx3OX29LbLtUWmtnLk != this.__cp_VIgJNx3OX29LbLtUWmtnLk ? new TranslateAxisDetection_BqtC7Hby5zRLTdvJl8kZ1Y(this)
                {__slot_JLYPJEvry8eNMofNTbGs1I = __slot_JLYPJEvry8eNMofNTbGs1I, __cp_F1Lq6Asqc9kP6mR2Ul0xBY = __cp_F1Lq6Asqc9kP6mR2Ul0xBY, __cp_VIgJNx3OX29LbLtUWmtnLk = __cp_VIgJNx3OX29LbLtUWmtnLk} : that_0;
            else
            {
                this.__slot_JLYPJEvry8eNMofNTbGs1I = __slot_JLYPJEvry8eNMofNTbGs1I;
                this.__cp_F1Lq6Asqc9kP6mR2Ul0xBY = __cp_F1Lq6Asqc9kP6mR2Ul0xBY;
                this.__cp_VIgJNx3OX29LbLtUWmtnLk = __cp_VIgJNx3OX29LbLtUWmtnLk;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 95969U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EjOkQeKTEgqPCZYFkueh9o", Name = "BezierKnotManipulator3d_R")]
    [n2.SerializableAttribute]
    public class BezierKnotManipulator3d_R : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.BezierKnotManipulator3d_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new BezierKnotManipulator3d_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.BezierKnotManipulator3d_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n38.BezierKnotManipulator3d_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new BezierKnotManipulator3d_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n38.BezierKnotManipulator3d_R __DEFAULT__;
        public n38.BezierKnotManipulator3d_R Update(n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots_In, n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControls_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, n3.Matrix ViewProjection_In, out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> BezierKnots_Out, out bool Editing_Out, out bool Selection_Updated_Out, out bool Scale_Out, out bool Rotate_Out, out bool Translate_Out, out n3.Vector3 Offset_Out, out n34.GizmoState_R GizmoState_Out)
        {
            var Output_8 = BezierEditorControls_In.Split(Corner_Out: out bool Corner_0, Corner_With_Handles_Out: out bool Corner_With_Handles_1, Smooth_Out: out bool Smooth_2, Smooth_Symmetric_Out: out bool Smooth_Symmetric_3, Find_Point_on_Curve_Out: out bool Find_Point_on_Curve_4, PointEditorControls_Out: out n8.PointEditorControlsData_R PointEditorControls_5, Hover_Control_Out: out bool Hover_Control_6, Force_Selection_Out: out bool Force_Selection_7);
            var Output_9 = BezierKnots_In;
            if (Corner_0)
            {
                n20._Operations_.MakeCornerKnot<n3.Vector3>(Input_In: BezierKnots_In, Output_Out: out Output_9);
            }

            var Output_10 = Output_9;
            if (Corner_With_Handles_1)
            {
                n20._Operations_.MakeCornerWithHandlesKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_9, Output_Out: out Output_10);
            }

            var Output_11 = Output_10;
            if (Smooth_2)
            {
                n20._Operations_.MakeSmoothKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_10, Output_Out: out Output_11);
            }

            var Output_12 = Output_11;
            if (Smooth_Symmetric_3)
            {
                n20._Operations_.MakeSmoothSymmetricKnot<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_11, Output_Out: out Output_12);
            }

            var Output_28 = PointEditorControls_5.Split(Pointer_Position_Out: out n3.Vector2 Pointer_Position_13, Mouse_Pressed_Out: out bool Mouse_Pressed_14, Selection_Out: out n3.RectangleF Selection_15, Remove_Selected_Out: out bool Remove_Selected_16, Control_Out: out bool Control_17, Shift_Out: out bool Shift_18, Space_Out: out bool Space_19, Hover_Next_Out: out bool Hover_Next_20, Hover_Previous_Out: out bool Hover_Previous_21, Select_All_Out: out bool Select_All_22, Scale_Out: out bool Scale_23, Rotate_Out: out bool Rotate_24, Translate_Out: out bool Translate_25, Undo_Out: out bool Undo_26, Redo_Out: out bool Redo_27);
            var Output_31 = this.__p_HqiJqmJ0rzNLAJMYw1yap4.Update(Value_In: Mouse_Pressed_14, Up_Edge_Out: out bool Up_Edge_29, Down_Edge_Out: out bool Down_Edge_30);
            n20._Operations_.HoverWithKeys<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_12, Hover_Next_In: Hover_Next_20, Hover_Previous_In: Hover_Previous_21, Hover_Control_In: Hover_Control_6, Mouse_Pressed_In: Up_Edge_29, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_32);
            n20._Operations_.GetAllEditablePoints<n3.Vector3>(BezierPoint_In: Output_32, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_33);
            var Output_43 = this.__p_PIHDrX3Hr54QXRIfNivywH.Update(Points_In: Points_33, PointEditor_Controls_In: PointEditorControls_5, Gizmo_Controls_In: Gizmo_Controls_In, Step_Size_In: Step_Size_In, Gizmo_Size_In: Gizmo_Size_In, ViewProjection_In: ViewProjection_In, Camera_Idle_In: Camera_Idle_In, Pick_Size_In: Pick_Size_In, Points_Out: out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Points_34, Result_Out: out n10.Spread<n3.Vector3> Result_35, Editing_Out: out bool Editing_36, Selection_Updated_Out: out bool Selection_Updated_37, Scale_Out: out bool Scale_38, Rotate_Out: out bool Rotate_39, Translate_Out: out bool Translate_40, Offset_Out: out n3.Vector3 Offset_41, GizmoState_Out: out n34.GizmoState_R GizmoState_42);
            n20._Operations_.UpdateBezierKnots<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>, n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_32, New_Positions_In: Points_34, Output_Out: out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_44);
            BezierKnots_Out = Output_44;
            Editing_Out = Editing_36;
            Selection_Updated_Out = Selection_Updated_37;
            Scale_Out = Scale_38;
            Rotate_Out = Rotate_39;
            Translate_Out = Translate_40;
            Offset_Out = Offset_41;
            GizmoState_Out = GizmoState_42;
            n38.BezierKnotManipulator3d_R that_45 = this;
            that_45 = Output_31 != this.__p_HqiJqmJ0rzNLAJMYw1yap4 || Output_43 != this.__p_PIHDrX3Hr54QXRIfNivywH ? new BezierKnotManipulator3d_R(this)
            {__p_HqiJqmJ0rzNLAJMYw1yap4 = Output_31, __p_PIHDrX3Hr54QXRIfNivywH = Output_43} : that_45;
            return that_45;
        }

        public n38.BezierKnotManipulator3d_R __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "PIHDrX3Hr54QXRIfNivywH", 96002U);
            var Output_1 = n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "HqiJqmJ0rzNLAJMYw1yap4", 96145U);
            var Output_3 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n38.BezierKnotManipulator3d_R that_4 = this;
            this.__p_PIHDrX3Hr54QXRIfNivywH = Output_1;
            this.__p_HqiJqmJ0rzNLAJMYw1yap4 = Output_3;
            return that_4;
        }

        public n38.BezierKnotManipulator3d_R __CreateDefault__()
        {
            n38.BezierKnotManipulator3d_R that_0 = this;
            this.__p_HqiJqmJ0rzNLAJMYw1yap4 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_PIHDrX3Hr54QXRIfNivywH = n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HqiJqmJ0rzNLAJMYw1yap4);
            n1.CompilationHelper.SafeDispose(this.__p_PIHDrX3Hr54QXRIfNivywH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 96145U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HqiJqmJ0rzNLAJMYw1yap4", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HqiJqmJ0rzNLAJMYw1yap4;
        [n1.ElementAttribute(TracingId = 96002U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PIHDrX3Hr54QXRIfNivywH", Name = "PointManipulator3d", IsManaged = true, IsAutoGenerated = true)]
        public n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_PIHDrX3Hr54QXRIfNivywH;
        public BezierKnotManipulator3d_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierKnotManipulator3d_R(BezierKnotManipulator3d_R other): base(other)
        {
            this.__p_HqiJqmJ0rzNLAJMYw1yap4 = other.__p_HqiJqmJ0rzNLAJMYw1yap4;
            this.__p_PIHDrX3Hr54QXRIfNivywH = other.__p_PIHDrX3Hr54QXRIfNivywH;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HqiJqmJ0rzNLAJMYw1yap4", in __p_HqiJqmJ0rzNLAJMYw1yap4), n1.CompilationHelper.GetValueOrExisting(values, "__p_PIHDrX3Hr54QXRIfNivywH", in __p_PIHDrX3Hr54QXRIfNivywH));
        }

        internal BezierKnotManipulator3d_R __WITH__(n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HqiJqmJ0rzNLAJMYw1yap4, n38.PointManipulator3d_GQIA7vZy239LZeN2s3lf2n<n10.Spread<n8.EditablePoint_R<n3.Vector3>>> __p_PIHDrX3Hr54QXRIfNivywH)
        {
            n38.BezierKnotManipulator3d_R that_0 = this;
            that_0 = __p_HqiJqmJ0rzNLAJMYw1yap4 != this.__p_HqiJqmJ0rzNLAJMYw1yap4 || __p_PIHDrX3Hr54QXRIfNivywH != this.__p_PIHDrX3Hr54QXRIfNivywH ? new BezierKnotManipulator3d_R(this)
            {__p_HqiJqmJ0rzNLAJMYw1yap4 = __p_HqiJqmJ0rzNLAJMYw1yap4, __p_PIHDrX3Hr54QXRIfNivywH = __p_PIHDrX3Hr54QXRIfNivywH} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 96317U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SBqScJSmXEiM5u1rro5DrH", Name = "GizmoDetector_SBqScJSmXEiM5u1rro5DrH")]
    [n2.SerializableAttribute]
    public class GizmoDetector_SBqScJSmXEiM5u1rro5DrH : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH Create(n1.NodeContext Node_Context)
        {
            var instance = new GizmoDetector_SBqScJSmXEiM5u1rro5DrH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH CreateDefault()
        {
            var instance = new GizmoDetector_SBqScJSmXEiM5u1rro5DrH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH Update(n3.Ray PickRay_In, n34.GizmoModel_R Gizmo_Model_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out n34.GizmoModel_R Gizmo_Out)
        {
            int __pad_D7FgH0gXEwUQDxp0xrs4qs_0 = __slot_D7FgH0gXEwUQDxp0xrs4qs;
            var Output_5 = Gizmo_Model_In.GetEnabledComponents(Translation_in_Projection_Out: out bool Translation_in_Projection_1, Translation_Out: out bool Translation_2, Scale_Out: out bool Scale_3, Rotation_Out: out bool Rotation_4);
            var Output_6 = Translation_2 && Enable_In;
            var Max_Value_7 = float.MaxValue;
            n3.Vector3 Active_Axis_8 = n51._Operations_.CreateDefault();
            var Output_9 = Gizmo_Model_In;
            if (Enable_In)
            {
                Output_9 = Gizmo_Model_In.SetActiveComponents(Active_Axis_In: Active_Axis_8, Active_Component_In: __pad_D7FgH0gXEwUQDxp0xrs4qs_0);
            }

            float __auto_10;
            n34.GizmoModel_R __auto_11;
            if (Output_6)
            {
                int __pad_CYWGPctw05SPr3iyD7t802_13 = __slot_CYWGPctw05SPr3iyD7t802;
                var Output_22 = Output_9.GetModelData(Translation_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_14, Gizmo_Size_Out: out float Gizmo_Size_15, Scale_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_16, Pick_Size_Out: out float Pick_Size_17, Rotation_Planes_Out: out n10.Spread<n3.Plane> Rotation_Planes_18, Center_Box_Out: out n46.OrientedBoundingBox Center_Box_19, Position_Out: out n3.Vector3 Position_20, Enabled_Axis_Out: out n3.Vector3 Enabled_Axis_21);
                n38._Operations_.TranslateAxisDetection<n10.Spread<n46.OrientedBoundingBox>>(Translation_Boxes_In: Translation_Boxes_14, Ray_In: PickRay_In, Enabled_Axis_In: Enabled_Axis_21, Distance_Out: out float Distance_23, Selected_Axis_Out: out n3.Vector3 Selected_Axis_24, Result_Out: out bool Result_25);
                var Result_26 = Max_Value_7 > Distance_23;
                var Output_27 = Result_26 && Result_25;
                var Output_28 = Output_9;
                if (Output_27)
                {
                    Output_28 = Output_9.SetActiveComponents(Active_Axis_In: Selected_Axis_24, Active_Component_In: __pad_CYWGPctw05SPr3iyD7t802_13);
                }

                __auto_11 = Output_28;
                n32._Operations_.Switch_Boolean<float>(Condition_In: Output_27, Input_In: Max_Value_7, Input_2_In: Distance_23, Output_Out: out float Output_29);
                __auto_10 = Output_29;
            }
            else
            {
                __auto_10 = Max_Value_7;
                __auto_11 = Output_9;
            }

            var Output_30 = Scale_3 && Enable_In;
            float __auto_31;
            n34.GizmoModel_R __auto_32;
            if (Output_30)
            {
                int __pad_AQJL6Q3gkRqPV4fNbfeWkH_34 = __slot_AQJL6Q3gkRqPV4fNbfeWkH;
                var Output_43 = __auto_11.GetModelData(Translation_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_35, Gizmo_Size_Out: out float Gizmo_Size_36, Scale_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_37, Pick_Size_Out: out float Pick_Size_38, Rotation_Planes_Out: out n10.Spread<n3.Plane> Rotation_Planes_39, Center_Box_Out: out n46.OrientedBoundingBox Center_Box_40, Position_Out: out n3.Vector3 Position_41, Enabled_Axis_Out: out n3.Vector3 Enabled_Axis_42);
                n38._Operations_.ScaleAxisDetection<n10.Spread<n46.OrientedBoundingBox>>(Scale_Boxes_In: Scale_Boxes_37, Ray_In: PickRay_In, Enabled_Axis_In: Enabled_Axis_42, Distance_Out: out float Distance_44, Selected_Axis_Out: out n3.Vector3 Selected_Axis_45, Result_Out: out bool Result_46);
                var Output_47 = __auto_11;
                if (Result_46)
                {
                    Output_47 = __auto_11.SetActiveComponents(Active_Axis_In: Selected_Axis_45, Active_Component_In: __pad_AQJL6Q3gkRqPV4fNbfeWkH_34);
                }

                __auto_32 = Output_47;
                n32._Operations_.Switch_Boolean<float>(Condition_In: Result_46, Input_In: Distance_44, Input_2_In: __auto_10, Output_Out: out float Output_48);
                __auto_31 = Output_48;
            }
            else
            {
                __auto_31 = __auto_10;
                __auto_32 = __auto_11;
            }

            var Output_49 = Rotation_4 && Enable_In;
            float __auto_50;
            n34.GizmoModel_R __auto_51;
            if (Output_49)
            {
                int __pad_MTQoGAKnZxWO02Ti0fuaYh_53 = __slot_MTQoGAKnZxWO02Ti0fuaYh;
                var Output_62 = __auto_32.GetModelData(Translation_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_54, Gizmo_Size_Out: out float Gizmo_Size_55, Scale_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_56, Pick_Size_Out: out float Pick_Size_57, Rotation_Planes_Out: out n10.Spread<n3.Plane> Rotation_Planes_58, Center_Box_Out: out n46.OrientedBoundingBox Center_Box_59, Position_Out: out n3.Vector3 Position_60, Enabled_Axis_Out: out n3.Vector3 Enabled_Axis_61);
                n38._Operations_.RotateAxisDetection<n10.Spread<n3.Plane>>(Ray_In: PickRay_In, Rotation_Planes_In: Rotation_Planes_58, Enabled_Axis_In: Enabled_Axis_61, Gizmo_Position_In: Position_60, Size_In: Gizmo_Size_55, Pick_Size_In: Pick_Size_57, Distance_Out: out float Distance_63, Selected_Axis_Out: out n3.Vector3 Selected_Axis_64, Result_Out: out bool Result_65, Inner_Radius_Out: out float Inner_Radius_66);
                var Result_67 = __auto_31 > Distance_63;
                var Output_68 = Result_67 && Result_65;
                var Output_69 = __auto_32;
                if (Output_68)
                {
                    Output_69 = __auto_32.SetActiveComponents(Active_Axis_In: Selected_Axis_64, Active_Component_In: __pad_MTQoGAKnZxWO02Ti0fuaYh_53);
                }

                __auto_51 = Output_69;
                n32._Operations_.Switch_Boolean<float>(Condition_In: Output_68, Input_In: Distance_63, Input_2_In: __auto_31, Output_Out: out float Output_70);
                __auto_50 = Output_70;
            }
            else
            {
                __auto_50 = __auto_31;
                __auto_51 = __auto_32;
            }

            var Output_71 = Translation_in_Projection_1 && Enable_In;
            float __auto_72;
            n34.GizmoModel_R __auto_73;
            if (Output_71)
            {
                int __pad_E6piwSRYVYXPRzjb3m8yBt_75 = __slot_E6piwSRYVYXPRzjb3m8yBt;
                var Output_84 = __auto_51.GetModelData(Translation_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_76, Gizmo_Size_Out: out float Gizmo_Size_77, Scale_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_78, Pick_Size_Out: out float Pick_Size_79, Rotation_Planes_Out: out n10.Spread<n3.Plane> Rotation_Planes_80, Center_Box_Out: out n46.OrientedBoundingBox Center_Box_81, Position_Out: out n3.Vector3 Position_82, Enabled_Axis_Out: out n3.Vector3 Enabled_Axis_83);
                n38._Operations_.CenterDetection(Center_Box_In: Center_Box_81, Ray_In: PickRay_In, Distance_Out: out float Distance_85, Result_Out: out bool Result_86);
                n3.Vector3 Active_Axis_87 = n51._Operations_.CreateDefault();
                var Output_88 = __auto_51;
                if (Result_86)
                {
                    Output_88 = __auto_51.SetActiveComponents(Active_Axis_In: Active_Axis_87, Active_Component_In: __pad_E6piwSRYVYXPRzjb3m8yBt_75);
                }

                __auto_73 = Output_88;
                n32._Operations_.Switch_Boolean<float>(Condition_In: Result_86, Input_In: __auto_50, Input_2_In: Distance_85, Output_Out: out float Output_89);
                __auto_72 = Output_89;
            }
            else
            {
                __auto_72 = __auto_50;
                __auto_73 = __auto_51;
            }

            Gizmo_Out = __auto_73;
            return this;
        }

        public n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH __CreateDefault__()
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

        [n1.ElementAttribute(TracingId = 96961U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "D7FgH0gXEwUQDxp0xrs4qs", Name = "__slot_D7FgH0gXEwUQDxp0xrs4qs")]
        public static int __slot_D7FgH0gXEwUQDxp0xrs4qs = -1;
        [n1.ElementAttribute(TracingId = 96447U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CYWGPctw05SPr3iyD7t802", Name = "__slot_CYWGPctw05SPr3iyD7t802")]
        public static int __slot_CYWGPctw05SPr3iyD7t802 = 1;
        [n1.ElementAttribute(TracingId = 96564U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AQJL6Q3gkRqPV4fNbfeWkH", Name = "__slot_AQJL6Q3gkRqPV4fNbfeWkH")]
        public static int __slot_AQJL6Q3gkRqPV4fNbfeWkH = 2;
        [n1.ElementAttribute(TracingId = 96727U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MTQoGAKnZxWO02Ti0fuaYh", Name = "__slot_MTQoGAKnZxWO02Ti0fuaYh")]
        public static int __slot_MTQoGAKnZxWO02Ti0fuaYh = 3;
        [n1.ElementAttribute(TracingId = 96842U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "E6piwSRYVYXPRzjb3m8yBt", Name = "__slot_E6piwSRYVYXPRzjb3m8yBt")]
        public static int __slot_E6piwSRYVYXPRzjb3m8yBt = 0;
        static GizmoDetector_SBqScJSmXEiM5u1rro5DrH()
        {
        }

        public GizmoDetector_SBqScJSmXEiM5u1rro5DrH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoDetector_SBqScJSmXEiM5u1rro5DrH(GizmoDetector_SBqScJSmXEiM5u1rro5DrH other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal GizmoDetector_SBqScJSmXEiM5u1rro5DrH __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 97182U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AdI63omT2YTOi5EjgAa12J", Name = "GizmoOffsetter_AdI63omT2YTOi5EjgAa12J")]
    [n2.SerializableAttribute]
    public class GizmoOffsetter_AdI63omT2YTOi5EjgAa12J : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J Create(n1.NodeContext Node_Context)
        {
            var instance = new GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J CreateDefault()
        {
            var instance = new GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J Update(n34.GizmoModel_R Gizmo_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Editing_In, n3.Matrix View_Projection_In, bool Uniform_In, n3.Vector2 Mouse_Position_In, float Step_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Rotation_Step_Scale_In, out n3.Vector3 Translate_Offset_Out, out n3.Vector3 Scale_Offset_Out, out n3.Vector3 Rotate_Offset_Out, out n3.Vector3 Active_Axis_Out)
        {
            float __pad_RnY1TgvLp9HNewgaOfk4Wa_0 = __slot_RnY1TgvLp9HNewgaOfk4Wa;
            var Output_6 = Gizmo_In.GetActiveComponents(Translation_Active_Out: out bool Translation_Active_1, Scale_Active_Out: out bool Scale_Active_2, Rotation_Active_Out: out bool Rotation_Active_3, Active_Axis_Out: out n3.Vector3 Active_Axis_4, Center_Active_Out: out bool Center_Active_5);
            var Output_7 = Translation_Active_1 || Scale_Active_2;
            var Output_8 = Editing_In && Scale_Active_2;
            var Output_9 = Output_7 && Editing_In;
            var Output_18 = Gizmo_In.GetModelData(Translation_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_10, Gizmo_Size_Out: out float Gizmo_Size_11, Scale_Boxes_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_12, Pick_Size_Out: out float Pick_Size_13, Rotation_Planes_Out: out n10.Spread<n3.Plane> Rotation_Planes_14, Center_Box_Out: out n46.OrientedBoundingBox Center_Box_15, Position_Out: out n3.Vector3 Position_16, Enabled_Axis_Out: out n3.Vector3 Enabled_Axis_17);
            n3.Vector3 __auto_19;
            if (Output_9)
            {
                n38._Operations_.MoveAlongAxis(Gizmo_Position_In: Position_16, Active_Axis_In: Active_Axis_4, Mouse_Position_In: Mouse_Position_In, View_Projection_In: View_Projection_In, Result_Out: out n3.Vector3 Result_21);
                __auto_19 = Result_21;
            }
            else
            {
                __auto_19 = n51._Operations_.CreateDefault();
            }

            var Output_24 = this.__p_MrMAFKjqxXNMT1sZvaMC3D.Update(Value_In: Editing_In, Up_Edge_Out: out bool Up_Edge_22, Down_Edge_Out: out bool Down_Edge_23);
            var Output_25 = Up_Edge_22 || Down_Edge_23;
            bool SetValue_26 = true;
            var Output_27 = this.__p_Qws22ssI45gNxyOdvVYVw2;
            if (SetValue_26)
            {
                Output_27 = this.__p_Qws22ssI45gNxyOdvVYVw2.SetValue(Value_In: __auto_19, Sample_In: Output_25);
            }

            var Output_29 = Output_27.GetValue(Value_Out: out n3.Vector3 Value_28);
            var Output_30 = Center_Active_5 && Editing_In;
            n3.Vector3 __auto_31;
            if (Output_30)
            {
                n38._Operations_.MoveInViewProjection(Gizmo_Position_In: Position_16, Mouse_Position_In: Mouse_Position_In, View_Projection_In: View_Projection_In, Result_Out: out n3.Vector3 Result_33);
                __auto_31 = Result_33;
            }
            else
            {
                __auto_31 = n51._Operations_.CreateDefault();
            }

            bool SetValue_34 = true;
            var Output_35 = this.__p_GXg7NTdRqxWL5FnAejbIDz;
            if (SetValue_34)
            {
                Output_35 = this.__p_GXg7NTdRqxWL5FnAejbIDz.SetValue(Value_In: __auto_31, Sample_In: Output_25);
            }

            var Output_37 = Output_35.GetValue(Value_Out: out n3.Vector3 Value_36);
            n3.Vector3.Subtract(left: ref __auto_19, right: ref Value_28, result: out n3.Vector3 Output_38);
            n3.Vector3.Subtract(left: ref __auto_31, right: ref Value_36, result: out n3.Vector3 Output_39);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Center_Active_5, Input_In: Output_38, Input_2_In: Output_39, Output_Out: out n3.Vector3 Output_40);
            var Output_41 = new n3.Vector3(x: Step_Size_In, y: Step_Size_In, z: Step_Size_In);
            n51._Operations_.Quantize(Input_In: Output_40, Step_Size_In: Output_41, Output_Out: out n3.Vector3 Output_42);
            var Output_43 = Scale_Active_2 && Editing_In;
            float __auto_44;
            if (Output_43)
            {
                n38._Operations_.OffsetAlongAxis(Active_Axis_In: Active_Axis_4, Mouse_Position_In: Mouse_Position_In, ViewProjection_In: View_Projection_In, Result_Out: out float Result_46);
                __auto_44 = Result_46;
            }
            else
            {
                __auto_44 = 0F;
            }

            bool SetValue_47 = true;
            var Output_48 = this.__p_M468oRScZsiPMfWwd45pez;
            if (SetValue_47)
            {
                Output_48 = this.__p_M468oRScZsiPMfWwd45pez.SetValue(Value_In: __auto_44, Sample_In: Output_25);
            }

            var Output_50 = Output_48.GetValue(Value_Out: out float Value_49);
            var Output_51 = __auto_44 - Value_49;
            n47._Operations_.Quantize<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_51, Step_Size_In: Step_Size_In, Output_Out: out float Output_52);
            var Output_53 = Rotation_Active_3 && Editing_In;
            float Scalar_54 = n2.Convert.ToSingle(Rotation_Active_3);
            n3.Vector3 __auto_55;
            if (Output_53)
            {
                n46.Vector2Nodes.Vector(input: ref Mouse_Position_In, x: out float X_57, y: out float Y_58);
                var Output_59 = new n3.Vector3(x: Y_58, y: X_57, z: Y_58);
                n46.Vector3Nodes.Multiply(left: ref Active_Axis_4, right: ref Output_59, result: out n3.Vector3 Output_60);
                n46.Vector3Nodes.Scale(input: ref Output_60, scalar: Scalar_54, output: out n3.Vector3 Output_61);
                n46.Vector3Nodes.Vector(input: ref Output_61, x: out float X_62, y: out float Y_63, z: out float Z_64);
                var Output_65 = -Y_63;
                var Output_66 = new n3.Vector3(x: X_62, y: Output_65, z: Z_64);
                __auto_55 = Output_66;
            }
            else
            {
                __auto_55 = n51._Operations_.CreateDefault();
            }

            bool SetValue_67 = true;
            var Output_68 = this.__p_A1iAU4IJK1QPJ8VADfZLYg;
            if (SetValue_67)
            {
                Output_68 = this.__p_A1iAU4IJK1QPJ8VADfZLYg.SetValue(Value_In: __auto_55, Sample_In: Output_25);
            }

            var Output_70 = Output_68.GetValue(Value_Out: out n3.Vector3 Value_69);
            n3.Vector3.Subtract(left: ref __auto_55, right: ref Value_69, result: out n3.Vector3 Output_71);
            var Output_72 = new n3.Vector3(x: __pad_RnY1TgvLp9HNewgaOfk4Wa_0, y: __pad_RnY1TgvLp9HNewgaOfk4Wa_0, z: __pad_RnY1TgvLp9HNewgaOfk4Wa_0);
            n51._Operations_.Quantize(Input_In: Output_71, Step_Size_In: Output_72, Output_Out: out n3.Vector3 Output_73);
            n46.Vector3Nodes.Scale(input: ref Output_73, scalar: Rotation_Step_Scale_In, output: out n3.Vector3 Output_74);
            n46.Vector3Nodes.Scale(input: ref Active_Axis_4, scalar: Output_52, output: out n3.Vector3 Output_75);
            n3.Vector3 __auto_76;
            if (Output_8)
            {
                var One_78 = n3.Vector3.One;
                n46.Vector3Nodes.Scale(input: ref One_78, scalar: Output_52, output: out n3.Vector3 Output_79);
                n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Uniform_In, Input_In: Output_75, Input_2_In: Output_79, Output_Out: out n3.Vector3 Output_80);
                __auto_76 = Output_80;
            }
            else
            {
                __auto_76 = n51._Operations_.CreateDefault();
            }

            var Output_81 = Translation_Active_1 || Center_Active_5;
            var Output_82 = Output_81 && Editing_In;
            n3.Vector3 Input_83 = n51._Operations_.CreateDefault();
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Output_82, Input_In: Input_83, Input_2_In: Output_42, Output_Out: out n3.Vector3 Output_84);
            Translate_Offset_Out = Output_84;
            Scale_Offset_Out = __auto_76;
            Rotate_Offset_Out = Output_74;
            Active_Axis_Out = Active_Axis_4;
            n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J that_85 = this;
            if (this.__GetContext__().IsImmutable)
                that_85 = Output_24 != this.__p_MrMAFKjqxXNMT1sZvaMC3D || Output_29 != this.__p_Qws22ssI45gNxyOdvVYVw2 || Output_37 != this.__p_GXg7NTdRqxWL5FnAejbIDz || Output_50 != this.__p_M468oRScZsiPMfWwd45pez || Output_70 != this.__p_A1iAU4IJK1QPJ8VADfZLYg ? new GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(this)
                {__p_MrMAFKjqxXNMT1sZvaMC3D = Output_24, __p_Qws22ssI45gNxyOdvVYVw2 = Output_29, __p_GXg7NTdRqxWL5FnAejbIDz = Output_37, __p_M468oRScZsiPMfWwd45pez = Output_50, __p_A1iAU4IJK1QPJ8VADfZLYg = Output_70} : that_85;
            else
            {
                this.__p_MrMAFKjqxXNMT1sZvaMC3D = Output_24;
                this.__p_Qws22ssI45gNxyOdvVYVw2 = Output_29;
                this.__p_GXg7NTdRqxWL5FnAejbIDz = Output_37;
                this.__p_M468oRScZsiPMfWwd45pez = Output_50;
                this.__p_A1iAU4IJK1QPJ8VADfZLYg = Output_70;
            }

            return that_85;
        }

        public n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Qws22ssI45gNxyOdvVYVw2", 97542U);
            n3.Vector3 Initial_Value_1 = n51._Operations_.CreateDefault();
            var Output_2 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.Create(Node_Context: Node_Context_0, Initial_Value_In: Initial_Value_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "MrMAFKjqxXNMT1sZvaMC3D", 97559U);
            var Output_4 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "GXg7NTdRqxWL5FnAejbIDz", 97617U);
            n3.Vector3 Initial_Value_6 = n51._Operations_.CreateDefault();
            var Output_7 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.Create(Node_Context: Node_Context_5, Initial_Value_In: Initial_Value_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "M468oRScZsiPMfWwd45pez", 97729U);
            float Initial_Value_9 = 0F;
            var Output_10 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<float>.Create(Node_Context: Node_Context_8, Initial_Value_In: Initial_Value_9);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "A1iAU4IJK1QPJ8VADfZLYg", 97778U);
            n3.Vector3 Initial_Value_12 = n51._Operations_.CreateDefault();
            var Output_13 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.Create(Node_Context: Node_Context_11, Initial_Value_In: Initial_Value_12);
            n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J that_14 = this;
            this.__p_Qws22ssI45gNxyOdvVYVw2 = Output_2;
            this.__p_MrMAFKjqxXNMT1sZvaMC3D = Output_4;
            this.__p_GXg7NTdRqxWL5FnAejbIDz = Output_7;
            this.__p_M468oRScZsiPMfWwd45pez = Output_10;
            this.__p_A1iAU4IJK1QPJ8VADfZLYg = Output_13;
            return that_14;
        }

        public n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J __CreateDefault__()
        {
            n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J that_0 = this;
            this.__p_MrMAFKjqxXNMT1sZvaMC3D = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_Qws22ssI45gNxyOdvVYVw2 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.CreateDefault();
            this.__p_GXg7NTdRqxWL5FnAejbIDz = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.CreateDefault();
            this.__p_M468oRScZsiPMfWwd45pez = n41.SPH_RESwCzqU3iTMc4Ig82Av03<float>.CreateDefault();
            this.__p_A1iAU4IJK1QPJ8VADfZLYg = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MrMAFKjqxXNMT1sZvaMC3D);
            n1.CompilationHelper.SafeDispose(this.__p_Qws22ssI45gNxyOdvVYVw2);
            n1.CompilationHelper.SafeDispose(this.__p_GXg7NTdRqxWL5FnAejbIDz);
            n1.CompilationHelper.SafeDispose(this.__p_M468oRScZsiPMfWwd45pez);
            n1.CompilationHelper.SafeDispose(this.__p_A1iAU4IJK1QPJ8VADfZLYg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 97802U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RnY1TgvLp9HNewgaOfk4Wa", Name = "__slot_RnY1TgvLp9HNewgaOfk4Wa")]
        public static float __slot_RnY1TgvLp9HNewgaOfk4Wa = 0.01F;
        [n1.ElementAttribute(TracingId = 97559U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MrMAFKjqxXNMT1sZvaMC3D", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_MrMAFKjqxXNMT1sZvaMC3D;
        [n1.ElementAttribute(TracingId = 97542U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Qws22ssI45gNxyOdvVYVw2", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_Qws22ssI45gNxyOdvVYVw2;
        [n1.ElementAttribute(TracingId = 97617U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GXg7NTdRqxWL5FnAejbIDz", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_GXg7NTdRqxWL5FnAejbIDz;
        [n1.ElementAttribute(TracingId = 97729U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "M468oRScZsiPMfWwd45pez", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_M468oRScZsiPMfWwd45pez;
        [n1.ElementAttribute(TracingId = 97778U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "A1iAU4IJK1QPJ8VADfZLYg", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_A1iAU4IJK1QPJ8VADfZLYg;
        static GizmoOffsetter_AdI63omT2YTOi5EjgAa12J()
        {
        }

        public GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(GizmoOffsetter_AdI63omT2YTOi5EjgAa12J other): base(other)
        {
            this.__p_MrMAFKjqxXNMT1sZvaMC3D = other.__p_MrMAFKjqxXNMT1sZvaMC3D;
            this.__p_Qws22ssI45gNxyOdvVYVw2 = other.__p_Qws22ssI45gNxyOdvVYVw2;
            this.__p_GXg7NTdRqxWL5FnAejbIDz = other.__p_GXg7NTdRqxWL5FnAejbIDz;
            this.__p_M468oRScZsiPMfWwd45pez = other.__p_M468oRScZsiPMfWwd45pez;
            this.__p_A1iAU4IJK1QPJ8VADfZLYg = other.__p_A1iAU4IJK1QPJ8VADfZLYg;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MrMAFKjqxXNMT1sZvaMC3D", in __p_MrMAFKjqxXNMT1sZvaMC3D), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qws22ssI45gNxyOdvVYVw2", in __p_Qws22ssI45gNxyOdvVYVw2), n1.CompilationHelper.GetValueOrExisting(values, "__p_GXg7NTdRqxWL5FnAejbIDz", in __p_GXg7NTdRqxWL5FnAejbIDz), n1.CompilationHelper.GetValueOrExisting(values, "__p_M468oRScZsiPMfWwd45pez", in __p_M468oRScZsiPMfWwd45pez), n1.CompilationHelper.GetValueOrExisting(values, "__p_A1iAU4IJK1QPJ8VADfZLYg", in __p_A1iAU4IJK1QPJ8VADfZLYg));
        }

        internal GizmoOffsetter_AdI63omT2YTOi5EjgAa12J __WITH__(n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_MrMAFKjqxXNMT1sZvaMC3D, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_Qws22ssI45gNxyOdvVYVw2, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_GXg7NTdRqxWL5FnAejbIDz, n41.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_M468oRScZsiPMfWwd45pez, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector3> __p_A1iAU4IJK1QPJ8VADfZLYg)
        {
            n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_MrMAFKjqxXNMT1sZvaMC3D != this.__p_MrMAFKjqxXNMT1sZvaMC3D || __p_Qws22ssI45gNxyOdvVYVw2 != this.__p_Qws22ssI45gNxyOdvVYVw2 || __p_GXg7NTdRqxWL5FnAejbIDz != this.__p_GXg7NTdRqxWL5FnAejbIDz || __p_M468oRScZsiPMfWwd45pez != this.__p_M468oRScZsiPMfWwd45pez || __p_A1iAU4IJK1QPJ8VADfZLYg != this.__p_A1iAU4IJK1QPJ8VADfZLYg ? new GizmoOffsetter_AdI63omT2YTOi5EjgAa12J(this)
                {__p_MrMAFKjqxXNMT1sZvaMC3D = __p_MrMAFKjqxXNMT1sZvaMC3D, __p_Qws22ssI45gNxyOdvVYVw2 = __p_Qws22ssI45gNxyOdvVYVw2, __p_GXg7NTdRqxWL5FnAejbIDz = __p_GXg7NTdRqxWL5FnAejbIDz, __p_M468oRScZsiPMfWwd45pez = __p_M468oRScZsiPMfWwd45pez, __p_A1iAU4IJK1QPJ8VADfZLYg = __p_A1iAU4IJK1QPJ8VADfZLYg} : that_0;
            else
            {
                this.__p_MrMAFKjqxXNMT1sZvaMC3D = __p_MrMAFKjqxXNMT1sZvaMC3D;
                this.__p_Qws22ssI45gNxyOdvVYVw2 = __p_Qws22ssI45gNxyOdvVYVw2;
                this.__p_GXg7NTdRqxWL5FnAejbIDz = __p_GXg7NTdRqxWL5FnAejbIDz;
                this.__p_M468oRScZsiPMfWwd45pez = __p_M468oRScZsiPMfWwd45pez;
                this.__p_A1iAU4IJK1QPJ8VADfZLYg = __p_A1iAU4IJK1QPJ8VADfZLYg;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void EditPoints3d<T>(T Points_In, n3.Vector3 Center_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Editing_In, n3.Vector3 Scale_In, n3.Vector3 Rotate_In, n3.Vector3 Translate_In, n3.Vector3 Axis_In, out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Outputs_Out, out n10.Spread<n3.Vector3> Result_Out)
            where T : n23.IEnumerable<n8.EditablePoint_R<n3.Vector3>>
        {
            n10.Spread<n8.EditablePoint_R<n3.Vector3>> __cp_R73gfzMG0GMMpB5Su9DGBc = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector3>>();
            n10.Spread<n3.Vector3> __cp_BzROcimA1WCLGZ8HDG6Em9 = n14._Operations_.CreateDefault<n3.Vector3>();
            var builder_14 = n6.CollectionBuilders.GetBuilder(__cp_R73gfzMG0GMMpB5Su9DGBc, 16);
            n10.Spread<n8.EditablePoint_R<n3.Vector3>> output_15;
            var builder_16 = n6.CollectionBuilders.GetBuilder(__cp_BzROcimA1WCLGZ8HDG6Em9, 16);
            n10.Spread<n3.Vector3> output_17;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Points_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    var Output_5 = splicer_1.GetSelected(Selected_Out: out bool Selected_4);
                    var Output_7 = splicer_1.GetPosition(Position_Out: out n3.Vector3 Position_6);
                    var Output_8 = Selected_4 && Editing_In;
                    var Output_9 = Position_6;
                    if (Output_8)
                    {
                        n38._Operations_.Scale<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Position_6, Center_In: Center_In, Offset_In: Scale_In, Output_Out: out Output_9);
                    }

                    var Output_10 = Output_9;
                    if (Output_8)
                    {
                        n38._Operations_.Rotate(Input_In: Output_9, Center_In: Center_In, Axis_In: Axis_In, Offset_In: Rotate_In, Output_Out: out Output_10);
                    }

                    var Output_11 = Output_10;
                    if (Output_8)
                    {
                        n31._Operations_.Translate<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Output_10, Offset_In: Translate_In, Output_Out: out Output_11);
                    }

                    bool Apply_12 = true;
                    var Output_13 = splicer_1;
                    if (Apply_12)
                    {
                        Output_13 = splicer_1.SetPosition(Position_In: Output_11);
                    }

                    builder_14.Add(Output_13);
                    builder_16.Add(Output_11);
                    i_2++;
                }
            }
            finally
            {
                output_15 = builder_14.Commit();
                output_17 = builder_16.Commit();
            }

            Outputs_Out = output_15;
            Result_Out = output_17;
            return;
        }

        public static void Rotate(n3.Vector3 Input_In, n3.Vector3 Center_In, n3.Vector3 Axis_In, n3.Vector3 Offset_In, out n3.Vector3 Output_Out)
        {
            n3.Vector3.Subtract(left: ref Input_In, right: ref Center_In, result: out n3.Vector3 Output_0);
            n46.Vector3Nodes.Vector(input: ref Offset_In, x: out float X_1, y: out float Y_2, z: out float Z_3);
            var Output_4 = X_1 + Y_2;
            var Output_5 = Output_4 + Z_3;
            n46.QuaternionNodes.RotationAxis(axis: ref Axis_In, angle: Output_5, result: out n3.Quaternion Result_6);
            bool Apply_7 = true;
            var Output_8 = Output_0;
            if (Apply_7)
            {
                n3.Vector3.Transform(vector: ref Output_0, rotation: ref Result_6, result: out n3.Vector3 Output_9);
                Output_8 = Output_9;
            }

            n3.Vector3.Add(left: ref Output_8, right: ref Center_In, result: out n3.Vector3 Output_10);
            Output_Out = Output_10;
            return;
        }

        public static void Scale<T, AdM>(T Input_In, T Center_In, T Offset_In, out T Output_Out)
            where AdM : struct, n21.IAdaptiveOne<T>, n21.IAdaptiveOperatorMulitply<T>, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            bool Apply_1 = true;
            var Output_2 = Input_In;
            if (Apply_1)
            {
                w_0.OperatorMinus(Input_In: Input_In, Input_2_In: Center_In, Output_Out: out Output_2);
            }

            w_0.One(One_Out: out T One_3);
            w_0.OperatorPlus(Input_In: Offset_In, Input_2_In: One_3, Output_Out: out T Output_4);
            w_0.OperatorMulitply(Input_In: Output_2, Input_2_In: Output_4, Output_Out: out T Output_5);
            w_0.OperatorPlus(Input_In: Center_In, Input_2_In: Output_5, Output_Out: out T Output_6);
            Output_Out = Output_6;
            return;
        }

        public static void GetAveragePosition<T, AdM>(n10.Spread<n8.EditablePoint_R<T>> Input_In, out T Result_Out)
            where AdM : struct, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorDivide_Scale<T>, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n14._Operations_.Where<n8.EditablePoint_R<T>>(Input_In: Input_In, Predicate_In: (n8.EditablePoint_R<T> Source_In_3, int Index_In_4) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Output_6 = Source_In_3.GetSelected(Selected_Out: out bool Selected_5);
                var Output_8 = Source_In_3.GetHovered(Hovered_Out: out bool Hovered_7);
                var Output_9 = Selected_5 || Hovered_7;
                return Output_9;
            }

            , Output_Out: out n10.Spread<n8.EditablePoint_R<T>> Output_10);
            n12._Operations_.Average_Selector<n10.Spread<n8.EditablePoint_R<T>>, n8.EditablePoint_R<T>, T, AdM>(Input_In: Output_10, Selector_In: (n8.EditablePoint_R<T> Source_In_12) =>
            {
                using var __current_11 = __fallback___1.MakeCurrentIfNone();
                var Output_14 = Source_In_12.GetPosition(Position_Out: out T Position_13);
                return Position_13;
            }

            , Result_Out: out T Result_15);
            Result_Out = Result_15;
            return;
        }

        public static void ToVector3(n10.Spread<float> Input_In, out n3.Vector3 Output_Out)
        {
            int __pad_BZc68GX5XtZMqJK9i1ngKr_0 = __slot_BZc68GX5XtZMqJK9i1ngKr;
            int __pad_LPD9TsYBTsjORAsEmgaMsf_1 = __slot_LPD9TsYBTsjORAsEmgaMsf;
            int __pad_JHHzGpdYCiaMIRkjxwAbNs_2 = __slot_JHHzGpdYCiaMIRkjxwAbNs;
            float Default_Value_3 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_3, Index_In: __pad_JHHzGpdYCiaMIRkjxwAbNs_2, Result_Out: out float Result_4);
            float Default_Value_5 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_5, Index_In: __pad_BZc68GX5XtZMqJK9i1ngKr_0, Result_Out: out float Result_6);
            float Default_Value_7 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_7, Index_In: __pad_LPD9TsYBTsjORAsEmgaMsf_1, Result_Out: out float Result_8);
            var Output_9 = new n3.Vector3(x: Result_4, y: Result_6, z: Result_8);
            Output_Out = Output_9;
            return;
        }

        public static void Min_Spreads2<T>(T Input_In, out float Output_Out, out int Index_Out)
            where T : n23.IEnumerable<float>
        {
            var Max_Value_0 = float.MaxValue;
            float accumulator_2 = Max_Value_0;
            int accumulator_3 = 0;
            var i_5 = 0;
            foreach (var item_1 in Input_In)
            {
                var splicer_4 = item_1;
                var i_local_6 = i_5;
                var Result_7 = splicer_4 < accumulator_2;
                n32._Operations_.Switch_Boolean<int>(Condition_In: Result_7, Input_In: accumulator_3, Input_2_In: i_local_6, Output_Out: out int Output_8);
                n32._Operations_.Switch_Boolean<float>(Condition_In: Result_7, Input_In: accumulator_2, Input_2_In: splicer_4, Output_Out: out float Output_9);
                accumulator_2 = Output_9;
                accumulator_3 = Output_8;
                i_5++;
            }

            Output_Out = accumulator_2;
            Index_Out = accumulator_3;
            return;
        }

        public static void ToVector(n10.Spread<float> Input_In, out n3.Vector3 Output_Out)
        {
            int __pad_Euuw6TqayOyQYhFyiY0JWP_0 = __slot_Euuw6TqayOyQYhFyiY0JWP;
            int __pad_GfPm1c6zCe1NBRAbLn174U_1 = __slot_GfPm1c6zCe1NBRAbLn174U;
            int __pad_TnryT9eIGF3P6tqF4MWd1p_2 = __slot_TnryT9eIGF3P6tqF4MWd1p;
            float Default_Value_3 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_3, Index_In: __pad_TnryT9eIGF3P6tqF4MWd1p_2, Result_Out: out float Result_4);
            float Default_Value_5 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_5, Index_In: __pad_Euuw6TqayOyQYhFyiY0JWP_0, Result_Out: out float Result_6);
            float Default_Value_7 = 0F;
            n14._Operations_.GetSlice<float>(Input_In: Input_In, Default_Value_In: Default_Value_7, Index_In: __pad_GfPm1c6zCe1NBRAbLn174U_1, Result_Out: out float Result_8);
            var Output_9 = new n3.Vector3(x: Result_4, y: Result_6, z: Result_8);
            Output_Out = Output_9;
            return;
        }

        public static void ToSpread(n3.Vector3 Input_In, out n10.Spread<float> Output_Out)
        {
            n10.Spread<float> __pin_group_Input_In_Ez9hjBb2KpPQJNxCUhnEFn = default(n10.Spread<float>);
            n46.Vector3Nodes.Vector(input: ref Input_In, x: out float X_0, y: out float Y_1, z: out float Z_2);
            var builder_3 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_Ez9hjBb2KpPQJNxCUhnEFn, 3);
            builder_3.Add(X_0);
            builder_3.Add(Y_1);
            builder_3.Add(Z_2);
            var __pin_group_Input_In_Ez9hjBb2KpPQJNxCUhnEFn_4 = builder_3.Commit();
            n14._Operations_.Cons<float>(Input_In: __pin_group_Input_In_Ez9hjBb2KpPQJNxCUhnEFn_4, Result_Out: out n10.Spread<float> Result_5);
            Output_Out = Result_5;
            return;
        }

        public static void ToSpreadOfAxisVectors(n3.Vector3 Input_In, out n10.Spread<n3.Vector3> Output_Out)
        {
            n10.Spread<n3.Vector3> __pin_group_Input_In_A7gYEOIDTmeL9G93BR4wpZ = default(n10.Spread<n3.Vector3>);
            n46.Vector3Nodes.Vector(input: ref Input_In, x: out float X_0, y: out float Y_1, z: out float Z_2);
            float Y_3 = 0F;
            float Z_4 = 0F;
            var Output_5 = new n3.Vector3(x: X_0, y: Y_3, z: Z_4);
            float X_6 = 0F;
            float Z_7 = 0F;
            var Output_8 = new n3.Vector3(x: X_6, y: Y_1, z: Z_7);
            float X_9 = 0F;
            float Y_10 = 0F;
            var Output_11 = new n3.Vector3(x: X_9, y: Y_10, z: Z_2);
            var builder_12 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_A7gYEOIDTmeL9G93BR4wpZ, 3);
            builder_12.Add(Output_5);
            builder_12.Add(Output_8);
            builder_12.Add(Output_11);
            var __pin_group_Input_In_A7gYEOIDTmeL9G93BR4wpZ_13 = builder_12.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_A7gYEOIDTmeL9G93BR4wpZ_13, Result_Out: out n10.Spread<n3.Vector3> Result_14);
            Output_Out = Result_14;
            return;
        }

        public static void GetScaleBoxes(float Pick_Size_In, [n6.SerializedDefaultValueAttribute("1", false)] float Size_In, out n10.Spread<n46.OrientedBoundingBox> Output_Out)
        {
            n10.Spread<n3.Vector3> __pin_group_Input_In_JDaUJTBDkxCLh885zZFA87 = default(n10.Spread<n3.Vector3>);
            n10.Spread<n46.OrientedBoundingBox> __cp_Rg7lE4NsuTJNBk20PdnWsi = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            float __pad_LfoNKFCODdoQWAQe01vQh3_0 = __slot_LfoNKFCODdoQWAQe01vQh3;
            float __pad_MddZ7zPqztUML676Wn8Eaa_1 = __slot_MddZ7zPqztUML676Wn8Eaa;
            var Output_2 = (float)Pick_Size_In / __pad_LfoNKFCODdoQWAQe01vQh3_0;
            var Output_3 = Output_2 + __pad_MddZ7zPqztUML676Wn8Eaa_1;
            float Y_4 = 0F;
            float Z_5 = 0F;
            var Output_6 = new n3.Vector3(x: Output_3, y: Y_4, z: Z_5);
            var Output_7 = Output_2 + __pad_MddZ7zPqztUML676Wn8Eaa_1;
            float X_8 = 0F;
            float Z_9 = 0F;
            var Output_10 = new n3.Vector3(x: X_8, y: Output_7, z: Z_9);
            var Output_11 = Output_2 + __pad_MddZ7zPqztUML676Wn8Eaa_1;
            float X_12 = 0F;
            float Y_13 = 0F;
            var Output_14 = new n3.Vector3(x: X_12, y: Y_13, z: Output_11);
            var builder_15 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_JDaUJTBDkxCLh885zZFA87, 3);
            builder_15.Add(Output_6);
            builder_15.Add(Output_10);
            builder_15.Add(Output_14);
            var __pin_group_Input_In_JDaUJTBDkxCLh885zZFA87_16 = builder_15.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_JDaUJTBDkxCLh885zZFA87_16, Result_Out: out n10.Spread<n3.Vector3> Result_17);
            var Output_18 = new n3.Vector3(x: Pick_Size_In, y: Pick_Size_In, z: Pick_Size_In);
            n3.Vector3 Center_19 = n51._Operations_.CreateDefault();
            var Result_20 = n46.BoxExtensions.CreateCenterSize(center: ref Center_19, size: ref Output_18);
            var builder_27 = n6.CollectionBuilders.GetBuilder(__cp_Rg7lE4NsuTJNBk20PdnWsi, 16);
            n10.Spread<n46.OrientedBoundingBox> output_28;
            try
            {
                var i_23 = 0;
                foreach (var item_21 in n6.CollectionExtensions.AsSpan(Result_17))
                {
                    var splicer_22 = item_21;
                    var i_local_24 = i_23;
                    n46.Vector3Nodes.Scale(input: ref splicer_22, scalar: Size_In, output: out n3.Vector3 Output_25);
                    var Output_26 = n46.BoxExtensions.Translate(input: ref Result_20, translation: ref Output_25);
                    builder_27.Add(Output_26);
                    i_23++;
                }
            }
            finally
            {
                output_28 = builder_27.Commit();
            }

            Output_Out = output_28;
            return;
        }

        public static void GetTranslationBoxes(float Size_In, float Pick_Size_In, out n10.Spread<n46.OrientedBoundingBox> Output_Out)
        {
            n10.Spread<n3.Vector3> __pin_group_Input_In_InFIFYKCDF0QRmI6ova7Bp = default(n10.Spread<n3.Vector3>);
            n10.Spread<n3.Vector3> __pin_group_Input_In_CA9iKZ9hO9dNGeATjxNgUF = default(n10.Spread<n3.Vector3>);
            n10.Spread<n46.OrientedBoundingBox> __cp_RN8soHlhNTWN4bm9sqAqb9 = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            float __pad_QLUl5kWR6VyLHndPbxi7PS_0 = __slot_QLUl5kWR6VyLHndPbxi7PS;
            var Output_1 = (float)Size_In / __pad_QLUl5kWR6VyLHndPbxi7PS_0;
            float Y_2 = 0F;
            float Z_3 = 0F;
            var Output_4 = new n3.Vector3(x: Output_1, y: Y_2, z: Z_3);
            var Output_5 = new n3.Vector3(x: Size_In, y: Pick_Size_In, z: Pick_Size_In);
            var Output_6 = new n3.Vector3(x: Pick_Size_In, y: Size_In, z: Pick_Size_In);
            var Output_7 = new n3.Vector3(x: Pick_Size_In, y: Pick_Size_In, z: Size_In);
            var builder_8 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_InFIFYKCDF0QRmI6ova7Bp, 3);
            builder_8.Add(Output_5);
            builder_8.Add(Output_6);
            builder_8.Add(Output_7);
            var __pin_group_Input_In_InFIFYKCDF0QRmI6ova7Bp_9 = builder_8.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_InFIFYKCDF0QRmI6ova7Bp_9, Result_Out: out n10.Spread<n3.Vector3> Result_10);
            float X_11 = 0F;
            float Z_12 = 0F;
            var Output_13 = new n3.Vector3(x: X_11, y: Output_1, z: Z_12);
            float X_14 = 0F;
            float Y_15 = 0F;
            var Output_16 = new n3.Vector3(x: X_14, y: Y_15, z: Output_1);
            var builder_17 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_CA9iKZ9hO9dNGeATjxNgUF, 3);
            builder_17.Add(Output_4);
            builder_17.Add(Output_13);
            builder_17.Add(Output_16);
            var __pin_group_Input_In_CA9iKZ9hO9dNGeATjxNgUF_18 = builder_17.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_CA9iKZ9hO9dNGeATjxNgUF_18, Result_Out: out n10.Spread<n3.Vector3> Result_19);
            var enumerator_20 = n6.CollectionExtensions.AsSpan(Result_19).GetEnumerator();
            var enumerator_22 = n6.CollectionExtensions.AsSpan(Result_10).GetEnumerator();
            var builder_27 = n6.CollectionBuilders.GetBuilder(__cp_RN8soHlhNTWN4bm9sqAqb9, 16);
            n10.Spread<n46.OrientedBoundingBox> output_28;
            try
            {
                var i_24 = 0;
                while (enumerator_20.MoveNext() && enumerator_22.MoveNext())
                {
                    var splicer_21 = enumerator_20.Current;
                    var splicer_23 = enumerator_22.Current;
                    var i_local_25 = i_24;
                    var Result_26 = n46.BoxExtensions.CreateCenterSize(center: ref splicer_21, size: ref splicer_23);
                    builder_27.Add(Result_26);
                    i_24++;
                }
            }
            finally
            {
                output_28 = builder_27.Commit();
            }

            Output_Out = output_28;
            return;
        }

        public static void GetRotationPlanes(out n10.Spread<n3.Plane> Planes_Out, out n10.Spread<n3.Matrix> Matrices_Out)
        {
            n10.Spread<n3.Vector3> __pin_group_Input_In_BsNpsBjJnN3NgJAhX2n83Y = default(n10.Spread<n3.Vector3>);
            n10.Spread<n3.Plane> __cp_PNisYKUWzNHOsCEBUbia9e = n14._Operations_.CreateDefault<n3.Plane>();
            n10.Spread<n3.Matrix> __cp_HwIlIBs221kL7vWt5DLbSp = n14._Operations_.CreateDefault<n3.Matrix>();
            n3.Vector3 __pad_KprbZZvhy1pMS8Bv6kiGMS_0 = __slot_KprbZZvhy1pMS8Bv6kiGMS;
            n3.Vector3 __pad_NTFwtuLN24bNfGXwcPs8av_1 = __slot_NTFwtuLN24bNfGXwcPs8av;
            n3.Vector3 __pad_QkFE2oXz6MdQXicBIYrv3b_2 = __slot_QkFE2oXz6MdQXicBIYrv3b;
            float __pad_AokTe7HaM5COHTYmaLMkjS_3 = __slot_AokTe7HaM5COHTYmaLMkjS;
            var builder_4 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_BsNpsBjJnN3NgJAhX2n83Y, 3);
            builder_4.Add(__pad_KprbZZvhy1pMS8Bv6kiGMS_0);
            builder_4.Add(__pad_NTFwtuLN24bNfGXwcPs8av_1);
            builder_4.Add(__pad_QkFE2oXz6MdQXicBIYrv3b_2);
            var __pin_group_Input_In_BsNpsBjJnN3NgJAhX2n83Y_5 = builder_4.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_BsNpsBjJnN3NgJAhX2n83Y_5, Result_Out: out n10.Spread<n3.Vector3> Result_6);
            float X_7 = 0F;
            float Y_8 = 0F;
            var Output_9 = new n3.Vector3(x: X_7, y: Y_8, z: __pad_AokTe7HaM5COHTYmaLMkjS_3);
            n3.Vector3 Point_10 = n51._Operations_.CreateDefault();
            var Output_11 = new n3.Plane(point: Point_10, normal: Output_9);
            var builder_19 = n6.CollectionBuilders.GetBuilder(__cp_PNisYKUWzNHOsCEBUbia9e, 16);
            n10.Spread<n3.Plane> output_20;
            var builder_21 = n6.CollectionBuilders.GetBuilder(__cp_HwIlIBs221kL7vWt5DLbSp, 16);
            n10.Spread<n3.Matrix> output_22;
            try
            {
                var i_14 = 0;
                foreach (var item_12 in n6.CollectionExtensions.AsSpan(Result_6))
                {
                    var splicer_13 = item_12;
                    var i_local_15 = i_14;
                    n3.Matrix Input_16 = n55._Operations_.CreateDefault();
                    n62._Operations_.Rotate(Input_In: Input_16, Rotation_In: splicer_13, Output_Out: out n3.Matrix Output_17);
                    n3.Plane.Transform(plane: ref Output_11, transformation: ref Output_17, result: out n3.Plane Output_18);
                    builder_19.Add(Output_18);
                    builder_21.Add(Output_17);
                    i_14++;
                }
            }
            finally
            {
                output_20 = builder_19.Commit();
                output_22 = builder_21.Commit();
            }

            Planes_Out = output_20;
            Matrices_Out = output_22;
            return;
        }

        public static void TranslateBoxes<T>(T Input_In, n3.Vector3 Value_In, out n10.Spread<n46.OrientedBoundingBox> Output_Out)
            where T : n23.IEnumerable<n46.OrientedBoundingBox>
        {
            n10.Spread<n46.OrientedBoundingBox> __cp_VboCzeBGAzSOtvKL3Lr6MD = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            n38._Operations_.ToSpreadOfAxisVectors(Input_In: Value_In, Output_Out: out n10.Spread<n3.Vector3> Output_0);
            var enumerator_1 = Input_In.GetEnumerator();
            var enumerator_3 = n6.CollectionExtensions.AsSpan(Output_0).GetEnumerator();
            var builder_11 = n6.CollectionBuilders.GetBuilder(__cp_VboCzeBGAzSOtvKL3Lr6MD, 16);
            n10.Spread<n46.OrientedBoundingBox> output_12;
            try
            {
                var i_5 = 0;
                while (enumerator_1.MoveNext() && enumerator_3.MoveNext())
                {
                    var splicer_2 = enumerator_1.Current;
                    var splicer_4 = enumerator_3.Current;
                    var i_local_6 = i_5;
                    n3.Vector3 Input_2_7 = n51._Operations_.CreateDefault();
                    var Result_8 = splicer_4 != Input_2_7;
                    var Output_9 = splicer_2;
                    if (Result_8)
                    {
                        var Output_10 = n46.BoxExtensions.Translate(input: ref splicer_2, translation: ref splicer_4);
                        Output_9 = Output_10;
                    }

                    builder_11.Add(Output_9);
                    i_5++;
                }
            }
            finally
            {
                enumerator_1.Dispose();
                output_12 = builder_11.Commit();
            }

            Output_Out = output_12;
            return;
        }

        public static void GizmoTransform<T4, T3, T, T2>(T4 Translation_In, T3 Scale_In, T GizmoScale_In, T2 Rotation_In, n3.Matrix Transformation_In, out n10.Spread<n46.OrientedBoundingBox> Translation_Out, out n10.Spread<n46.OrientedBoundingBox> Scale_Out, out n10.Spread<n3.Plane> Rotation_Out)
            where T4 : n23.IEnumerable<n46.OrientedBoundingBox> where T3 : n23.IEnumerable<n46.OrientedBoundingBox> where T : n23.IEnumerable<n3.Vector3> where T2 : n23.IEnumerable<n3.Plane>
        {
            n10.Spread<n46.OrientedBoundingBox> __cp_PJXo1yAwOCOO174PepkYsZ = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            n10.Spread<n46.OrientedBoundingBox> __cp_PM86iHNNSxYMG0cYA3u2VY = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            n10.Spread<n3.Plane> __cp_Jyp8vfsYWlSOmyB4P2NZ4Y = n14._Operations_.CreateDefault<n3.Plane>();
            var enumerator_0 = Translation_In.GetEnumerator();
            var enumerator_2 = Scale_In.GetEnumerator();
            var enumerator_4 = GizmoScale_In.GetEnumerator();
            var enumerator_6 = Rotation_In.GetEnumerator();
            var builder_17 = n6.CollectionBuilders.GetBuilder(__cp_PJXo1yAwOCOO174PepkYsZ, 16);
            n10.Spread<n46.OrientedBoundingBox> output_18;
            var builder_19 = n6.CollectionBuilders.GetBuilder(__cp_PM86iHNNSxYMG0cYA3u2VY, 16);
            n10.Spread<n46.OrientedBoundingBox> output_20;
            var builder_21 = n6.CollectionBuilders.GetBuilder(__cp_Jyp8vfsYWlSOmyB4P2NZ4Y, 16);
            n10.Spread<n3.Plane> output_22;
            try
            {
                var i_8 = 0;
                while (enumerator_0.MoveNext() && enumerator_2.MoveNext() && enumerator_4.MoveNext() && enumerator_6.MoveNext())
                {
                    var splicer_1 = enumerator_0.Current;
                    var splicer_3 = enumerator_2.Current;
                    var splicer_5 = enumerator_4.Current;
                    var splicer_7 = enumerator_6.Current;
                    var i_local_9 = i_8;
                    var Output_10 = n46.BoxExtensions.Transform(input: ref splicer_1, transformation: ref Transformation_In);
                    n3.Vector3 Input_2_11 = n51._Operations_.CreateDefault();
                    var Result_12 = splicer_5 != Input_2_11;
                    var Output_13 = splicer_3;
                    if (Result_12)
                    {
                        var Output_14 = n46.BoxExtensions.Translate(input: ref splicer_3, translation: ref splicer_5);
                        Output_13 = Output_14;
                    }

                    var Output_15 = n46.BoxExtensions.Transform(input: ref Output_13, transformation: ref Transformation_In);
                    n3.Plane.Transform(plane: ref splicer_7, transformation: ref Transformation_In, result: out n3.Plane Output_16);
                    builder_17.Add(Output_10);
                    builder_19.Add(Output_15);
                    builder_21.Add(Output_16);
                    i_8++;
                }
            }
            finally
            {
                enumerator_0.Dispose();
                enumerator_2.Dispose();
                enumerator_4.Dispose();
                enumerator_6.Dispose();
                output_18 = builder_17.Commit();
                output_20 = builder_19.Commit();
                output_22 = builder_21.Commit();
            }

            Translation_Out = output_18;
            Scale_Out = output_20;
            Rotation_Out = output_22;
            return;
        }

        public static void ActivePlane(n3.Vector3 Active_Axis_In, n3.Matrix View_Projection_In, out n3.Plane Output_Out)
        {
            n10.Spread<n3.Vector3> __pin_group_Input_In_Ji1jqcxzJ2RLgfkvzgEOFV = default(n10.Spread<n3.Vector3>);
            n10.Spread<n3.Vector3> __pin_group_Input_In_ARNA0109oMINQt98fHTSTO = default(n10.Spread<n3.Vector3>);
            n10.Spread<n3.Vector3> __pin_group_Input_In_LQHxEBhtOAPLItYbSMHJx7 = default(n10.Spread<n3.Vector3>);
            n10.Spread<n23.IEnumerable<n3.Vector3>> __pin_group_Input_In_AoPXeOufabyPl0w9MmQV6D = default(n10.Spread<n23.IEnumerable<n3.Vector3>>);
            n10.Spread<n3.Vector3> __pin_group_Input_In_SGStkuZhhKOLvHqkEm911o = default(n10.Spread<n3.Vector3>);
            n3.Vector3 __pad_Be8Oqzwk2emNauJJSxZAnS_0 = __slot_Be8Oqzwk2emNauJJSxZAnS;
            n3.Vector3 __pad_SnHJoAbtghIOcZXQhltX0D_1 = __slot_SnHJoAbtghIOcZXQhltX0D;
            n3.Vector3 __pad_I2R8BT9oE9DO7OwFfbUl5K_2 = __slot_I2R8BT9oE9DO7OwFfbUl5K;
            float __pad_T8WjOq1WHgPMtYgCBoNTQn_3 = __slot_T8WjOq1WHgPMtYgCBoNTQn;
            string __pad_IQQapXpyOj8M4agcotWknG_4 = __slot_IQQapXpyOj8M4agcotWknG;
            string __pad_Ar5UTYFJdZDOAPHohvzLoB_5 = __slot_Ar5UTYFJdZDOAPHohvzLoB;
            var builder_6 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_Ji1jqcxzJ2RLgfkvzgEOFV, 1);
            builder_6.Add(__pad_Be8Oqzwk2emNauJJSxZAnS_0);
            var __pin_group_Input_In_Ji1jqcxzJ2RLgfkvzgEOFV_7 = builder_6.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_Ji1jqcxzJ2RLgfkvzgEOFV_7, Result_Out: out n10.Spread<n3.Vector3> Result_8);
            n23.IEnumerable<n3.Vector3> Input_9 = (n23.IEnumerable<n3.Vector3>)Result_8;
            var builder_10 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_ARNA0109oMINQt98fHTSTO, 1);
            builder_10.Add(__pad_SnHJoAbtghIOcZXQhltX0D_1);
            var __pin_group_Input_In_ARNA0109oMINQt98fHTSTO_11 = builder_10.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_ARNA0109oMINQt98fHTSTO_11, Result_Out: out n10.Spread<n3.Vector3> Result_12);
            n23.IEnumerable<n3.Vector3> Input_2_13 = (n23.IEnumerable<n3.Vector3>)Result_12;
            var builder_14 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_LQHxEBhtOAPLItYbSMHJx7, 1);
            builder_14.Add(__pad_I2R8BT9oE9DO7OwFfbUl5K_2);
            var __pin_group_Input_In_LQHxEBhtOAPLItYbSMHJx7_15 = builder_14.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_LQHxEBhtOAPLItYbSMHJx7_15, Result_Out: out n10.Spread<n3.Vector3> Result_16);
            n23.IEnumerable<n3.Vector3> Input_3_17 = (n23.IEnumerable<n3.Vector3>)Result_16;
            var builder_18 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_AoPXeOufabyPl0w9MmQV6D, 3);
            builder_18.Add(Input_9);
            builder_18.Add(Input_2_13);
            builder_18.Add(Input_3_17);
            var __pin_group_Input_In_AoPXeOufabyPl0w9MmQV6D_19 = builder_18.Commit();
            n14._Operations_.Concat<n3.Vector3>(Input_In: __pin_group_Input_In_AoPXeOufabyPl0w9MmQV6D_19, Output_Out: out n10.Spread<n3.Vector3> Output_20);
            var builder_21 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_SGStkuZhhKOLvHqkEm911o, 1);
            builder_21.Add(Active_Axis_In);
            var __pin_group_Input_In_SGStkuZhhKOLvHqkEm911o_22 = builder_21.Commit();
            n14._Operations_.FromValue<n3.Vector3>(Input_In: __pin_group_Input_In_SGStkuZhhKOLvHqkEm911o_22, Result_Out: out n10.Spread<n3.Vector3> Result_23);
            n14._Operations_.Except<n3.Vector3>(Input_In: Output_20, Input_2_In: Result_23, Output_Out: out n10.Spread<n3.Vector3> Output_24);
            n3.Matrix.Invert(value: ref View_Projection_In, result: out n3.Matrix Output_25);
            n3.Vector3 Input_26 = n51._Operations_.CreateDefault();
            n3.Vector3.TransformCoordinate(coordinate: ref Input_26, transform: ref Output_25, result: out n3.Vector3 Output_27);
            float accumulator_29 = __pad_T8WjOq1WHgPMtYgCBoNTQn_3;
            n3.Vector3 accumulator_30 = n51._Operations_.CreateDefault();
            var i_32 = 0;
            foreach (var item_28 in n6.CollectionExtensions.AsSpan(Output_24))
            {
                var splicer_31 = item_28;
                var i_local_33 = i_32;
                n3.Vector3.Dot(left: ref splicer_31, right: ref Output_27, result: out float Result_34);
                n47._Operations_.Abs<float, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Result_34, Output_Out: out float Output_35);
                var Result_36 = Output_35 > accumulator_29;
                n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Result_36, Input_In: accumulator_30, Input_2_In: splicer_31, Output_Out: out n3.Vector3 Output_37);
                n32._Operations_.Switch_Boolean<float>(Condition_In: Result_36, Input_In: accumulator_29, Input_2_In: Output_35, Output_Out: out float Output_38);
                accumulator_29 = Output_38;
                accumulator_30 = Output_37;
                i_32++;
            }

            float D_39 = 0F;
            var Output_40 = new n3.Plane(value: accumulator_30, d: D_39);
            n3.Vector3 __pad_Mc213YeUHflPeEKFdDKxKj_41 = accumulator_30;
            n10.Spread<n3.Vector3> __pad_SKkoHAepFoqNspQXHmZqud_42 = Output_24;
            Output_Out = Output_40;
            return;
        }

        public static void TranslateAxisDetection<T>(T Translation_Boxes_In, n3.Ray Ray_In, n3.Vector3 Enabled_Axis_In, out float Distance_Out, out n3.Vector3 Selected_Axis_Out, out bool Result_Out)
            where T : n23.IEnumerable<n46.OrientedBoundingBox>
        {
            n10.Spread<bool> __cp_INQdv2U4YxDPrN63t4vFDc = n14._Operations_.CreateDefault<bool>();
            float __pad_GarESePYRU7LwFHMeYws3w_0 = __slot_GarESePYRU7LwFHMeYws3w;
            n38._Operations_.ToSpreadOfBoolean(Input_In: Enabled_Axis_In, Output_Out: out n10.Spread<bool> Output_1);
            var Max_Value_2 = float.MaxValue;
            float accumulator_3 = Max_Value_2;
            int accumulator_4 = 0;
            var enumerator_5 = Translation_Boxes_In.GetEnumerator();
            var enumerator_7 = n6.CollectionExtensions.AsSpan(Output_1).GetEnumerator();
            var builder_20 = n6.CollectionBuilders.GetBuilder(__cp_INQdv2U4YxDPrN63t4vFDc, 16);
            n10.Spread<bool> output_21;
            try
            {
                var i_9 = 0;
                while (enumerator_5.MoveNext() && enumerator_7.MoveNext())
                {
                    var splicer_6 = enumerator_5.Current;
                    var splicer_8 = enumerator_7.Current;
                    var i_local_10 = i_9;
                    var Result_12 = splicer_6.Intersects(ray: ref Ray_In, point: out n3.Vector3 Point_11);
                    var Position_13 = Ray_In.Position;
                    n47._Operations_.Distance<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Point_11, Input_2_In: Position_13, Result_Out: out float Result_14);
                    var Result_15 = Result_14 < accumulator_3;
                    var Output_16 = Result_12 && Result_15;
                    var Output_17 = Output_16 && splicer_8;
                    n32._Operations_.Switch_Boolean<int>(Condition_In: Output_17, Input_In: accumulator_4, Input_2_In: i_local_10, Output_Out: out int Output_18);
                    n32._Operations_.Switch_Boolean<float>(Condition_In: Output_17, Input_In: accumulator_3, Input_2_In: Result_14, Output_Out: out float Output_19);
                    builder_20.Add(Result_12);
                    accumulator_3 = Output_19;
                    accumulator_4 = Output_18;
                    i_9++;
                }
            }
            finally
            {
                enumerator_5.Dispose();
                output_21 = builder_20.Commit();
            }

            n14._Operations_.Count<bool>(Input_In: output_21, Count_Out: out int Count_22);
            float Element_23 = 0F;
            n14._Operations_.Repeat<float>(Element_In: Element_23, Count_In: Count_22, Result_Out: out n10.Spread<float> Result_24);
            var Result_25 = accumulator_3 < Max_Value_2;
            var Output_26 = Result_24;
            if (Result_25)
            {
                n14._Operations_.SetSlice<float>(Input_In: Result_24, Value_In: __pad_GarESePYRU7LwFHMeYws3w_0, Index_In: accumulator_4, Output_Out: out Output_26);
            }

            n38._Operations_.ToVector3(Input_In: Output_26, Output_Out: out n3.Vector3 Output_27);
            Distance_Out = accumulator_3;
            Selected_Axis_Out = Output_27;
            Result_Out = Result_25;
            return;
        }

        public static void RotateAxisDetection<T>(n3.Ray Ray_In, T Rotation_Planes_In, n3.Vector3 Enabled_Axis_In, n3.Vector3 Gizmo_Position_In, float Size_In, float Pick_Size_In, out float Distance_Out, out n3.Vector3 Selected_Axis_Out, out bool Result_Out, out float Inner_Radius_Out)
            where T : n23.IEnumerable<n3.Plane>
        {
            n10.Spread<bool> __cp_D6gu6bjixuaOqs27RpRXPY = n14._Operations_.CreateDefault<bool>();
            float __pad_IjORH42VpbmNSaWZ51iXw1_0 = __slot_IjORH42VpbmNSaWZ51iXw1;
            float __pad_CotublbkUmQNtwvaasAU72_1 = __slot_CotublbkUmQNtwvaasAU72;
            bool __pad_A52i7v614CVQCUaGvYOqwv_2 = __slot_A52i7v614CVQCUaGvYOqwv;
            var Output_3 = n35.Float32Extensions.Length(input: Pick_Size_In);
            n38._Operations_.ToSpreadOfBoolean(Input_In: Enabled_Axis_In, Output_Out: out n10.Spread<bool> Output_4);
            var Max_Value_5 = float.MaxValue;
            bool accumulator_7 = __pad_A52i7v614CVQCUaGvYOqwv_2;
            var i_9 = 0;
            foreach (var item_6 in n6.CollectionExtensions.AsSpan(Output_4))
            {
                var splicer_8 = item_6;
                var i_local_10 = i_9;
                var Output_11 = splicer_8 && accumulator_7;
                accumulator_7 = Output_11;
                i_9++;
            }

            float accumulator_12 = Max_Value_5;
            int accumulator_13 = 0;
            var enumerator_14 = Rotation_Planes_In.GetEnumerator();
            var enumerator_16 = n6.CollectionExtensions.AsSpan(Output_4).GetEnumerator();
            var builder_38 = n6.CollectionBuilders.GetBuilder(__cp_D6gu6bjixuaOqs27RpRXPY, 16);
            n10.Spread<bool> output_39;
            try
            {
                var i_18 = 0;
                while (enumerator_14.MoveNext() && enumerator_16.MoveNext())
                {
                    var splicer_15 = enumerator_14.Current;
                    var splicer_17 = enumerator_16.Current;
                    var i_local_19 = i_18;
                    var Result_21 = n3.CollisionHelper.RayIntersectsPlane(ray: ref Ray_In, plane: ref splicer_15, point: out n3.Vector3 Point_20);
                    n3.Vector3.Subtract(left: ref Point_20, right: ref Gizmo_Position_In, result: out n3.Vector3 Output_22);
                    var Result_23 = Output_22.Length();
                    var Result_24 = Result_23 < Size_In;
                    var Output_25 = Size_In - Pick_Size_In;
                    var Result_26 = Result_23 > Output_25;
                    var Output_27 = Result_24 && Result_26;
                    var Output_28 = !splicer_17;
                    var Output_29 = Output_28 || accumulator_7;
                    var Output_30 = Result_21 && Output_27;
                    var Output_31 = Output_30 && Output_29;
                    var Position_32 = Ray_In.Position;
                    n47._Operations_.Distance<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Point_20, Input_2_In: Position_32, Result_Out: out float Result_33);
                    var Result_34 = Result_33 < accumulator_12;
                    var Output_35 = Output_31 && Result_34;
                    n32._Operations_.Switch_Boolean<int>(Condition_In: Output_35, Input_In: accumulator_13, Input_2_In: i_local_19, Output_Out: out int Output_36);
                    n32._Operations_.Switch_Boolean<float>(Condition_In: Output_35, Input_In: accumulator_12, Input_2_In: Result_33, Output_Out: out float Output_37);
                    builder_38.Add(Output_31);
                    accumulator_12 = Output_37;
                    accumulator_13 = Output_36;
                    i_18++;
                }
            }
            finally
            {
                enumerator_14.Dispose();
                output_39 = builder_38.Commit();
            }

            n14._Operations_.Count<bool>(Input_In: output_39, Count_Out: out int Count_40);
            float Element_41 = 0F;
            n14._Operations_.Repeat<float>(Element_In: Element_41, Count_In: Count_40, Result_Out: out n10.Spread<float> Result_42);
            var Result_43 = accumulator_12 < Max_Value_5;
            var Output_44 = Result_42;
            if (Result_43)
            {
                n14._Operations_.SetSlice<float>(Input_In: Result_42, Value_In: __pad_IjORH42VpbmNSaWZ51iXw1_0, Index_In: accumulator_13, Output_Out: out Output_44);
            }

            n38._Operations_.ToVector3(Input_In: Output_44, Output_Out: out n3.Vector3 Output_45);
            var Output_46 = __pad_CotublbkUmQNtwvaasAU72_1 - Output_3;
            Distance_Out = accumulator_12;
            Selected_Axis_Out = Output_45;
            Result_Out = Result_43;
            Inner_Radius_Out = Output_46;
            return;
        }

        public static void ScaleAxisDetection<T>(T Scale_Boxes_In, n3.Ray Ray_In, n3.Vector3 Enabled_Axis_In, out float Distance_Out, out n3.Vector3 Selected_Axis_Out, out bool Result_Out)
            where T : n23.IEnumerable<n46.OrientedBoundingBox>
        {
            n10.Spread<bool> __cp_TQnsqzsGMFuP5Gch9Fhx5H = n14._Operations_.CreateDefault<bool>();
            float __pad_VeK5WRvcrLFOpJOtQygNdS_0 = __slot_VeK5WRvcrLFOpJOtQygNdS;
            n38._Operations_.ToSpreadOfBoolean(Input_In: Enabled_Axis_In, Output_Out: out n10.Spread<bool> Output_1);
            var Max_Value_2 = float.MaxValue;
            float accumulator_3 = Max_Value_2;
            int accumulator_4 = 0;
            var enumerator_5 = Scale_Boxes_In.GetEnumerator();
            var enumerator_7 = n6.CollectionExtensions.AsSpan(Output_1).GetEnumerator();
            var builder_20 = n6.CollectionBuilders.GetBuilder(__cp_TQnsqzsGMFuP5Gch9Fhx5H, 16);
            n10.Spread<bool> output_21;
            try
            {
                var i_9 = 0;
                while (enumerator_5.MoveNext() && enumerator_7.MoveNext())
                {
                    var splicer_6 = enumerator_5.Current;
                    var splicer_8 = enumerator_7.Current;
                    var i_local_10 = i_9;
                    var Result_12 = splicer_6.Intersects(ray: ref Ray_In, point: out n3.Vector3 Point_11);
                    var Position_13 = Ray_In.Position;
                    n47._Operations_.Distance<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Point_11, Input_2_In: Position_13, Result_Out: out float Result_14);
                    var Result_15 = Result_14 < accumulator_3;
                    var Output_16 = Result_12 && Result_15;
                    var Output_17 = Output_16 && splicer_8;
                    n32._Operations_.Switch_Boolean<int>(Condition_In: Output_17, Input_In: accumulator_4, Input_2_In: i_local_10, Output_Out: out int Output_18);
                    n32._Operations_.Switch_Boolean<float>(Condition_In: Output_17, Input_In: accumulator_3, Input_2_In: Result_14, Output_Out: out float Output_19);
                    builder_20.Add(Result_12);
                    accumulator_3 = Output_19;
                    accumulator_4 = Output_18;
                    i_9++;
                }
            }
            finally
            {
                enumerator_5.Dispose();
                output_21 = builder_20.Commit();
            }

            n14._Operations_.Count<bool>(Input_In: output_21, Count_Out: out int Count_22);
            float Element_23 = 0F;
            n14._Operations_.Repeat<float>(Element_In: Element_23, Count_In: Count_22, Result_Out: out n10.Spread<float> Result_24);
            var Result_25 = accumulator_3 < Max_Value_2;
            var Output_26 = Result_24;
            if (Result_25)
            {
                n14._Operations_.SetSlice<float>(Input_In: Result_24, Value_In: __pad_VeK5WRvcrLFOpJOtQygNdS_0, Index_In: accumulator_4, Output_Out: out Output_26);
            }

            n38._Operations_.ToVector3(Input_In: Output_26, Output_Out: out n3.Vector3 Output_27);
            Distance_Out = accumulator_3;
            Selected_Axis_Out = Output_27;
            Result_Out = Result_25;
            return;
        }

        public static void CenterDetection(n46.OrientedBoundingBox Center_Box_In, n3.Ray Ray_In, out float Distance_Out, out bool Result_Out)
        {
            var Result_1 = Center_Box_In.Intersects(ray: ref Ray_In, point: out n3.Vector3 Point_0);
            var Position_2 = Ray_In.Position;
            n47._Operations_.Distance<n3.Vector3, n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Input_In: Point_0, Input_2_In: Position_2, Result_Out: out float Result_3);
            var Max_Value_4 = float.MaxValue;
            n32._Operations_.Switch_Boolean<float>(Condition_In: Result_1, Input_In: Max_Value_4, Input_2_In: Result_3, Output_Out: out float Output_5);
            Distance_Out = Output_5;
            Result_Out = Result_1;
            return;
        }

        public static void BoxPosition(n46.OrientedBoundingBox Input_In, out n3.Vector3 Output_Out)
        {
            float __pad_Gkt8QCdLzudPw2sGxuVmQ3_0 = __slot_Gkt8QCdLzudPw2sGxuVmQ3;
            var Center_1 = Input_In.Center;
            var Size_2 = Input_In.Size;
            n46.Vector3Nodes.DivScale(input: ref Size_2, scalar: __pad_Gkt8QCdLzudPw2sGxuVmQ3_0, output: out n3.Vector3 Output_3);
            n3.Vector3.Subtract(left: ref Center_1, right: ref Output_3, result: out n3.Vector3 Output_4);
            Output_Out = Output_4;
            return;
        }

        public static void Translate<T3, T2, T>(T3 Translation_In, T2 Scale_In, T Rotation_In, n46.OrientedBoundingBox Center_In, n3.Vector3 Position_In, out n10.Spread<n46.OrientedBoundingBox> Translation_Out, out n10.Spread<n46.OrientedBoundingBox> Scale_Out, out n10.Spread<n3.Plane> Rotation_Out, out n46.OrientedBoundingBox Center_Out)
            where T3 : n23.IEnumerable<n46.OrientedBoundingBox> where T2 : n23.IEnumerable<n46.OrientedBoundingBox> where T : n23.IEnumerable<n3.Plane>
        {
            n10.Spread<n46.OrientedBoundingBox> __cp_SaCeOeENyHzLFUyGqymUpR = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            n10.Spread<n46.OrientedBoundingBox> __cp_GXcLMDCmQ1oMJXO9Qiic7m = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            n10.Spread<n3.Plane> __cp_GQZa6iCcBgLMEAICkaheB8 = n14._Operations_.CreateDefault<n3.Plane>();
            var enumerator_0 = Translation_In.GetEnumerator();
            var enumerator_2 = Scale_In.GetEnumerator();
            var enumerator_4 = Rotation_In.GetEnumerator();
            var builder_13 = n6.CollectionBuilders.GetBuilder(__cp_SaCeOeENyHzLFUyGqymUpR, 16);
            n10.Spread<n46.OrientedBoundingBox> output_14;
            var builder_15 = n6.CollectionBuilders.GetBuilder(__cp_GXcLMDCmQ1oMJXO9Qiic7m, 16);
            n10.Spread<n46.OrientedBoundingBox> output_16;
            var builder_17 = n6.CollectionBuilders.GetBuilder(__cp_GQZa6iCcBgLMEAICkaheB8, 16);
            n10.Spread<n3.Plane> output_18;
            try
            {
                var i_6 = 0;
                while (enumerator_0.MoveNext() && enumerator_2.MoveNext() && enumerator_4.MoveNext())
                {
                    var splicer_1 = enumerator_0.Current;
                    var splicer_3 = enumerator_2.Current;
                    var splicer_5 = enumerator_4.Current;
                    var i_local_7 = i_6;
                    var Output_8 = n46.BoxExtensions.Translate(input: ref splicer_1, translation: ref Position_In);
                    var Output_9 = n46.BoxExtensions.Translate(input: ref splicer_3, translation: ref Position_In);
                    n3.Matrix Input_10 = n55._Operations_.CreateDefault();
                    n62._Operations_.Translate(Input_In: Input_10, Translation_In: Position_In, Output_Out: out n3.Matrix Output_11);
                    n3.Plane.Transform(plane: ref splicer_5, transformation: ref Output_11, result: out n3.Plane Output_12);
                    builder_13.Add(Output_8);
                    builder_15.Add(Output_9);
                    builder_17.Add(Output_12);
                    i_6++;
                }
            }
            finally
            {
                enumerator_0.Dispose();
                enumerator_2.Dispose();
                enumerator_4.Dispose();
                output_14 = builder_13.Commit();
                output_16 = builder_15.Commit();
                output_18 = builder_17.Commit();
            }

            var Output_19 = n46.BoxExtensions.Translate(input: ref Center_In, translation: ref Position_In);
            Translation_Out = output_14;
            Scale_Out = output_16;
            Rotation_Out = output_18;
            Center_Out = Output_19;
            return;
        }

        public static void ClosestPointOnALine(n3.Vector3 Line_Point1_In, n3.Vector3 Line_Point2_In, n3.Vector3 Free_Point_In, out n3.Vector3 Result_Out)
        {
            n3.Vector3.Subtract(left: ref Line_Point2_In, right: ref Line_Point1_In, result: out n3.Vector3 Output_0);
            n3.Vector3.Subtract(left: ref Free_Point_In, right: ref Line_Point1_In, result: out n3.Vector3 Output_1);
            n3.Vector3.Dot(left: ref Output_1, right: ref Output_0, result: out float Result_2);
            var Result_3 = Output_0.Length();
            var Output_4 = Result_3 * Result_3;
            var Output_5 = (float)Result_2 / Output_4;
            n46.Vector3Nodes.Scale(input: ref Output_0, scalar: Output_5, output: out n3.Vector3 Output_6);
            n3.Vector3.Add(left: ref Line_Point1_In, right: ref Output_6, result: out n3.Vector3 Output_7);
            Result_Out = Output_7;
            return;
        }

        public static void PickRayIntersectsLine(n3.Vector3 Line_Position_In, n3.Vector3 Line_Position2_In, n3.Ray PickRay_In, out n3.Vector3 Result_Out)
        {
            n3.Vector3.Subtract(left: ref Line_Position2_In, right: ref Line_Position_In, result: out n3.Vector3 Output_0);
            n3.Vector3.Normalize(value: ref Output_0, result: out n3.Vector3 Output_1);
            var Output_2 = new n3.Ray(position: Line_Position_In, direction: Output_1);
            var Result_4 = n3.CollisionHelper.RayIntersectsRay(ray1: ref Output_2, ray2: ref PickRay_In, point: out n3.Vector3 Point_3);
            n3.Vector3.Negate(value: ref Output_1, result: out n3.Vector3 Output_5);
            var Output_6 = new n3.Ray(position: Line_Position_In, direction: Output_5);
            var Result_8 = n3.CollisionHelper.RayIntersectsRay(ray1: ref Output_6, ray2: ref PickRay_In, point: out n3.Vector3 Point_7);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Result_4, Input_In: Point_7, Input_2_In: Point_3, Output_Out: out n3.Vector3 Output_9);
            Result_Out = Output_9;
            return;
        }

        public static void MoveAlongAxis(n3.Vector3 Gizmo_Position_In, n3.Vector3 Active_Axis_In, n3.Vector2 Mouse_Position_In, n3.Matrix View_Projection_In, out n3.Vector3 Result_Out)
        {
            n3.Vector3.TransformCoordinate(coordinate: ref Gizmo_Position_In, transform: ref View_Projection_In, result: out n3.Vector3 Output_0);
            n3.Vector3.Add(left: ref Gizmo_Position_In, right: ref Active_Axis_In, result: out n3.Vector3 Output_1);
            n3.Vector3.TransformCoordinate(coordinate: ref Output_1, transform: ref View_Projection_In, result: out n3.Vector3 Output_2);
            float Z_3 = 0F;
            var Result_4 = n46.Vector2Nodes.ToVector3(input: ref Mouse_Position_In, z: Z_3);
            n38._Operations_.ClosestPointOnALine(Line_Point1_In: Output_0, Line_Point2_In: Output_2, Free_Point_In: Result_4, Result_Out: out n3.Vector3 Result_5);
            n3.Matrix.Invert(value: ref View_Projection_In, result: out n3.Matrix Output_6);
            n3.Vector3.TransformCoordinate(coordinate: ref Result_5, transform: ref Output_6, result: out n3.Vector3 Output_7);
            n46.Vector3Nodes.Multiply(left: ref Output_7, right: ref Active_Axis_In, result: out n3.Vector3 Output_8);
            Result_Out = Output_8;
            return;
        }

        public static void GetCenterBox(float Pick_Size_In, out n46.OrientedBoundingBox Result_Out)
        {
            var Output_0 = new n3.Vector3(x: Pick_Size_In, y: Pick_Size_In, z: Pick_Size_In);
            n3.Vector3 Center_1 = n51._Operations_.CreateDefault();
            var Result_2 = n46.BoxExtensions.CreateCenterSize(center: ref Center_1, size: ref Output_0);
            Result_Out = Result_2;
            return;
        }

        public static void MoveInViewProjection(n3.Vector3 Gizmo_Position_In, n3.Vector2 Mouse_Position_In, n3.Matrix View_Projection_In, out n3.Vector3 Result_Out)
        {
            float Z_0 = 0F;
            var Result_1 = n46.Vector2Nodes.ToVector3(input: ref Mouse_Position_In, z: Z_0);
            n3.Vector3.TransformCoordinate(coordinate: ref Gizmo_Position_In, transform: ref View_Projection_In, result: out n3.Vector3 Output_2);
            n3.Vector3.Add(left: ref Result_1, right: ref Output_2, result: out n3.Vector3 Output_3);
            n3.Matrix.Invert(value: ref View_Projection_In, result: out n3.Matrix Output_4);
            n3.Vector3.TransformCoordinate(coordinate: ref Output_3, transform: ref Output_4, result: out n3.Vector3 Output_5);
            Result_Out = Output_5;
            return;
        }

        public static void ToSpreadOfBoolean(n3.Vector3 Input_In, out n10.Spread<bool> Output_Out)
        {
            n10.Spread<bool> __pin_group_Input_In_JDNlr4NIbIiOw7Tdt5s1ay = default(n10.Spread<bool>);
            float __pad_LdIH2bODUS0QNAFoShQihX_0 = __slot_LdIH2bODUS0QNAFoShQihX;
            n46.Vector3Nodes.Vector(input: ref Input_In, x: out float X_1, y: out float Y_2, z: out float Z_3);
            var Result_4 = X_1 > __pad_LdIH2bODUS0QNAFoShQihX_0;
            var Result_5 = Y_2 > __pad_LdIH2bODUS0QNAFoShQihX_0;
            var Result_6 = Z_3 > __pad_LdIH2bODUS0QNAFoShQihX_0;
            var builder_7 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_JDNlr4NIbIiOw7Tdt5s1ay, 3);
            builder_7.Add(Result_4);
            builder_7.Add(Result_5);
            builder_7.Add(Result_6);
            var __pin_group_Input_In_JDNlr4NIbIiOw7Tdt5s1ay_8 = builder_7.Commit();
            n14._Operations_.Cons<bool>(Input_In: __pin_group_Input_In_JDNlr4NIbIiOw7Tdt5s1ay_8, Result_Out: out n10.Spread<bool> Result_9);
            Output_Out = Result_9;
            return;
        }

        public static void GetMatrices<T3, T2, T>(T3 Translation_Boxes_In, T2 Scale_Boxes_In, T Rotation_Matrices_In, [n6.SerializedDefaultValueAttribute("1", false)] float Size_In, n3.Vector3 Position_In, out n10.Spread<n3.Matrix> Pin_Out, out n10.Spread<n3.Matrix> Pin_2_Out, out n10.Spread<n3.Matrix> Pin_3_Out)
            where T3 : n23.IEnumerable<n46.OrientedBoundingBox> where T2 : n23.IEnumerable<n46.OrientedBoundingBox> where T : n23.IEnumerable<n3.Matrix>
        {
            n10.Spread<n3.Matrix> __cp_B7sGh9vsScJQML2lgRNivM = n14._Operations_.CreateDefault<n3.Matrix>();
            n10.Spread<n3.Matrix> __cp_Chgiun555MPNaTcFak7N7a = n14._Operations_.CreateDefault<n3.Matrix>();
            n10.Spread<n3.Matrix> __cp_EpbcY3qUaDBMswCPyruGgR = n14._Operations_.CreateDefault<n3.Matrix>();
            var enumerator_0 = Translation_Boxes_In.GetEnumerator();
            var enumerator_2 = Scale_Boxes_In.GetEnumerator();
            var enumerator_4 = Rotation_Matrices_In.GetEnumerator();
            var builder_28 = n6.CollectionBuilders.GetBuilder(__cp_B7sGh9vsScJQML2lgRNivM, 16);
            n10.Spread<n3.Matrix> output_29;
            var builder_30 = n6.CollectionBuilders.GetBuilder(__cp_Chgiun555MPNaTcFak7N7a, 16);
            n10.Spread<n3.Matrix> output_31;
            var builder_32 = n6.CollectionBuilders.GetBuilder(__cp_EpbcY3qUaDBMswCPyruGgR, 16);
            n10.Spread<n3.Matrix> output_33;
            try
            {
                var i_6 = 0;
                while (enumerator_0.MoveNext() && enumerator_2.MoveNext() && enumerator_4.MoveNext())
                {
                    var splicer_1 = enumerator_0.Current;
                    var splicer_3 = enumerator_2.Current;
                    var splicer_5 = enumerator_4.Current;
                    var i_local_7 = i_6;
                    float __pad_I7wFm7reOj0MTisxIZMsG6_8 = __slot_I7wFm7reOj0MTisxIZMsG6;
                    var Center_9 = splicer_1.Center;
                    n3.Matrix Input_10 = n55._Operations_.CreateDefault();
                    n62._Operations_.Translate(Input_In: Input_10, Translation_In: Center_9, Output_Out: out n3.Matrix Output_11);
                    var Size_12 = splicer_1.Size;
                    n62._Operations_.Scale(Input_In: Output_11, Scaling_In: Size_12, Output_Out: out n3.Matrix Output_13);
                    var Center_14 = splicer_3.Center;
                    n3.Matrix Input_15 = n55._Operations_.CreateDefault();
                    n62._Operations_.Translate(Input_In: Input_15, Translation_In: Center_14, Output_Out: out n3.Matrix Output_16);
                    var Size_17 = splicer_3.Size;
                    n62._Operations_.Scale(Input_In: Output_16, Scaling_In: Size_17, Output_Out: out n3.Matrix Output_18);
                    var Output_19 = Size_In * __pad_I7wFm7reOj0MTisxIZMsG6_8;
                    n3.Matrix Input_20 = n55._Operations_.CreateDefault();
                    n62._Operations_.UniformScale(Input_In: Input_20, Scaling_In: Output_19, Output_Out: out n3.Matrix Output_21);
                    n3.Matrix Input_22 = n55._Operations_.CreateDefault();
                    n62._Operations_.Translate(Input_In: Input_22, Translation_In: Position_In, Output_Out: out n3.Matrix Output_23);
                    n3.Matrix Input_3_24 = n55._Operations_.CreateDefault();
                    n3.Matrix.Multiply(left: ref Output_21, right: ref splicer_5, result: out n3.Matrix Output_25);
                    n3.Matrix.Multiply(left: ref Output_25, right: ref Input_3_24, result: out n3.Matrix Output_26);
                    n3.Matrix.Multiply(left: ref Output_26, right: ref Output_23, result: out n3.Matrix Output_27);
                    builder_28.Add(Output_13);
                    builder_30.Add(Output_18);
                    builder_32.Add(Output_27);
                    i_6++;
                }
            }
            finally
            {
                enumerator_0.Dispose();
                enumerator_2.Dispose();
                enumerator_4.Dispose();
                output_29 = builder_28.Commit();
                output_31 = builder_30.Commit();
                output_33 = builder_32.Commit();
            }

            Pin_Out = output_29;
            Pin_2_Out = output_31;
            Pin_3_Out = output_33;
            return;
        }

        public static void LockToScreen([n6.SerializedDefaultValueAttribute("1", false)] float Size_In, n3.Vector3 Position_In, n3.Matrix View_Projection_In, out float Result_Out)
        {
            n3.Vector3.TransformCoordinate(coordinate: ref Position_In, transform: ref View_Projection_In, result: out n3.Vector3 Output_0);
            n3.Matrix.Invert(value: ref View_Projection_In, result: out n3.Matrix Output_1);
            n3.Vector3.TransformCoordinate(coordinate: ref Output_0, transform: ref Output_1, result: out n3.Vector3 Output_2);
            float X_3 = 0F;
            float Z_4 = 0F;
            var Output_5 = new n3.Vector3(x: X_3, y: Size_In, z: Z_4);
            n3.Vector3.Add(left: ref Output_0, right: ref Output_5, result: out n3.Vector3 Output_6);
            n3.Vector3.TransformCoordinate(coordinate: ref Output_6, transform: ref Output_1, result: out n3.Vector3 Output_7);
            n3.Vector3.Subtract(left: ref Output_2, right: ref Output_7, result: out n3.Vector3 Output_8);
            var Result_9 = Output_8.Length();
            var Output_10 = Size_In * Result_9;
            Result_Out = Output_10;
            return;
        }

        public static void ActiveComponentsController(int Number_of_Points_In, bool Visible_In, out int Output_Out, out bool Visible_Out)
        {
            int __pad_EUiwkR7NqawP8QAkOAkkfP_0 = __slot_EUiwkR7NqawP8QAkOAkkfP;
            int __pad_SchHObMibz2NSWq0owXOfM_1 = __slot_SchHObMibz2NSWq0owXOfM;
            int __pad_Ompl8ubP8NzLjxEU1YU71x_2 = __slot_Ompl8ubP8NzLjxEU1YU71x;
            int __pad_EQvjMzEnqF7MWUh9mQPdaX_3 = __slot_EQvjMzEnqF7MWUh9mQPdaX;
            var Result_4 = Number_of_Points_In == __pad_EUiwkR7NqawP8QAkOAkkfP_0;
            n32._Operations_.Switch_Boolean<int>(Condition_In: Result_4, Input_In: __pad_SchHObMibz2NSWq0owXOfM_1, Input_2_In: __pad_Ompl8ubP8NzLjxEU1YU71x_2, Output_Out: out int Output_5);
            n32._Operations_.Switch_Boolean<int>(Condition_In: Visible_In, Input_In: __pad_EQvjMzEnqF7MWUh9mQPdaX_3, Input_2_In: Output_5, Output_Out: out int Output_6);
            var Result_7 = Number_of_Points_In > __pad_EUiwkR7NqawP8QAkOAkkfP_0;
            var Output_8 = Visible_In || Result_7;
            Output_Out = Output_6;
            Visible_Out = Output_8;
            return;
        }

        public static void OffsetAlongAxis(n3.Vector3 Active_Axis_In, n3.Vector2 Mouse_Position_In, n3.Matrix ViewProjection_In, out float Result_Out)
        {
            n3.Vector3.TransformCoordinate(coordinate: ref Active_Axis_In, transform: ref ViewProjection_In, result: out n3.Vector3 Output_0);
            float Z_1 = 0F;
            var Result_2 = n46.Vector2Nodes.ToVector3(input: ref Mouse_Position_In, z: Z_1);
            n3.Vector3.Dot(left: ref Output_0, right: ref Result_2, result: out float Result_3);
            Result_Out = Result_3;
            return;
        }

        public static void RotationStepScale([n6.SerializedDefaultValueAttribute("True", false)] bool Small_Step_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Smaller_Step_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Big_Step_In, out float Output_Out)
        {
            float __pad_VLbB3gRa5gpOoohP8qxLsw_0 = __slot_VLbB3gRa5gpOoohP8qxLsw;
            float __pad_MlpsUm2k5DsMVhkHuZ8AkY_1 = __slot_MlpsUm2k5DsMVhkHuZ8AkY;
            float __pad_Ky4wVwOrZ2CM7K3tvMPh2U_2 = __slot_Ky4wVwOrZ2CM7K3tvMPh2U;
            float __pad_LaTrLXOGcwnObz2lnAgLRQ_3 = __slot_LaTrLXOGcwnObz2lnAgLRQ;
            var Output_4 = __pad_VLbB3gRa5gpOoohP8qxLsw_0;
            if (Small_Step_In)
            {
                var Output_5 = __pad_VLbB3gRa5gpOoohP8qxLsw_0 * __pad_MlpsUm2k5DsMVhkHuZ8AkY_1;
                Output_4 = Output_5;
            }

            var Output_6 = Output_4;
            if (Smaller_Step_In)
            {
                var Output_7 = Output_4 * __pad_MlpsUm2k5DsMVhkHuZ8AkY_1;
                Output_6 = Output_7;
            }

            var Output_8 = Output_6;
            if (Big_Step_In)
            {
                var Output_9 = Output_6 * __pad_Ky4wVwOrZ2CM7K3tvMPh2U_2;
                Output_8 = Output_9;
            }

            var Output_10 = (float)Output_8 / __pad_LaTrLXOGcwnObz2lnAgLRQ_3;
            Output_Out = Output_10;
            return;
        }

        [n1.ElementAttribute(TracingId = 90680U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BZc68GX5XtZMqJK9i1ngKr", Name = "__slot_BZc68GX5XtZMqJK9i1ngKr")]
        public static int __slot_BZc68GX5XtZMqJK9i1ngKr = 1;
        [n1.ElementAttribute(TracingId = 90692U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LPD9TsYBTsjORAsEmgaMsf", Name = "__slot_LPD9TsYBTsjORAsEmgaMsf")]
        public static int __slot_LPD9TsYBTsjORAsEmgaMsf = 2;
        [n1.ElementAttribute(TracingId = 90707U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JHHzGpdYCiaMIRkjxwAbNs", Name = "__slot_JHHzGpdYCiaMIRkjxwAbNs")]
        public static int __slot_JHHzGpdYCiaMIRkjxwAbNs = 0;
        [n1.ElementAttribute(TracingId = 91033U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Euuw6TqayOyQYhFyiY0JWP", Name = "__slot_Euuw6TqayOyQYhFyiY0JWP")]
        public static int __slot_Euuw6TqayOyQYhFyiY0JWP = 1;
        [n1.ElementAttribute(TracingId = 91038U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GfPm1c6zCe1NBRAbLn174U", Name = "__slot_GfPm1c6zCe1NBRAbLn174U")]
        public static int __slot_GfPm1c6zCe1NBRAbLn174U = 2;
        [n1.ElementAttribute(TracingId = 91040U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TnryT9eIGF3P6tqF4MWd1p", Name = "__slot_TnryT9eIGF3P6tqF4MWd1p")]
        public static int __slot_TnryT9eIGF3P6tqF4MWd1p = 0;
        [n1.ElementAttribute(TracingId = 91505U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LfoNKFCODdoQWAQe01vQh3", Name = "__slot_LfoNKFCODdoQWAQe01vQh3")]
        public static float __slot_LfoNKFCODdoQWAQe01vQh3 = 2F;
        [n1.ElementAttribute(TracingId = 91387U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MddZ7zPqztUML676Wn8Eaa", Name = "__slot_MddZ7zPqztUML676Wn8Eaa")]
        public static float __slot_MddZ7zPqztUML676Wn8Eaa = 1F;
        [n1.ElementAttribute(TracingId = 91836U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QLUl5kWR6VyLHndPbxi7PS", Name = "__slot_QLUl5kWR6VyLHndPbxi7PS")]
        public static float __slot_QLUl5kWR6VyLHndPbxi7PS = 2F;
        [n1.ElementAttribute(TracingId = 91880U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KprbZZvhy1pMS8Bv6kiGMS", Name = "__slot_KprbZZvhy1pMS8Bv6kiGMS")]
        public static n3.Vector3 __slot_KprbZZvhy1pMS8Bv6kiGMS = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0.25, 0.25", false, "RMDMfKmnIrVPStLdWe8u30", "KprbZZvhy1pMS8Bv6kiGMS");
        [n1.ElementAttribute(TracingId = 91887U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NTFwtuLN24bNfGXwcPs8av", Name = "__slot_NTFwtuLN24bNfGXwcPs8av")]
        public static n3.Vector3 __slot_NTFwtuLN24bNfGXwcPs8av = n1.CompilationHelper.Deserialize<n3.Vector3>("0.25, 0, 0", false, "RMDMfKmnIrVPStLdWe8u30", "NTFwtuLN24bNfGXwcPs8av");
        [n1.ElementAttribute(TracingId = 91890U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QkFE2oXz6MdQXicBIYrv3b", Name = "__slot_QkFE2oXz6MdQXicBIYrv3b")]
        public static n3.Vector3 __slot_QkFE2oXz6MdQXicBIYrv3b = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 4.07546743E-08", false, "RMDMfKmnIrVPStLdWe8u30", "QkFE2oXz6MdQXicBIYrv3b");
        [n1.ElementAttribute(TracingId = 91996U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AokTe7HaM5COHTYmaLMkjS", Name = "__slot_AokTe7HaM5COHTYmaLMkjS")]
        public static float __slot_AokTe7HaM5COHTYmaLMkjS = 1F;
        [n1.ElementAttribute(TracingId = 92263U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Be8Oqzwk2emNauJJSxZAnS", Name = "__slot_Be8Oqzwk2emNauJJSxZAnS")]
        public static n3.Vector3 __slot_Be8Oqzwk2emNauJJSxZAnS = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0, 0", false, "RMDMfKmnIrVPStLdWe8u30", "Be8Oqzwk2emNauJJSxZAnS");
        [n1.ElementAttribute(TracingId = 92267U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SnHJoAbtghIOcZXQhltX0D", Name = "__slot_SnHJoAbtghIOcZXQhltX0D")]
        public static n3.Vector3 __slot_SnHJoAbtghIOcZXQhltX0D = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 1, 0", false, "RMDMfKmnIrVPStLdWe8u30", "SnHJoAbtghIOcZXQhltX0D");
        [n1.ElementAttribute(TracingId = 92273U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I2R8BT9oE9DO7OwFfbUl5K", Name = "__slot_I2R8BT9oE9DO7OwFfbUl5K")]
        public static n3.Vector3 __slot_I2R8BT9oE9DO7OwFfbUl5K = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 1", false, "RMDMfKmnIrVPStLdWe8u30", "I2R8BT9oE9DO7OwFfbUl5K");
        [n1.ElementAttribute(TracingId = 92279U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "T8WjOq1WHgPMtYgCBoNTQn", Name = "__slot_T8WjOq1WHgPMtYgCBoNTQn")]
        public static float __slot_T8WjOq1WHgPMtYgCBoNTQn = 0F;
        [n1.ElementAttribute(TracingId = 92283U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IQQapXpyOj8M4agcotWknG", Name = "__slot_IQQapXpyOj8M4agcotWknG")]
        public static string __slot_IQQapXpyOj8M4agcotWknG = "< exclude the plane defined by the normal of mousebutton pressed xyz from possible planes to drag on";
        [n1.ElementAttribute(TracingId = 92285U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ar5UTYFJdZDOAPHohvzLoB", Name = "__slot_Ar5UTYFJdZDOAPHohvzLoB")]
        public static string __slot_Ar5UTYFJdZDOAPHohvzLoB = "< of the two possible planes choose the one which more faces the camera";
        [n1.ElementAttribute(TracingId = 92547U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GarESePYRU7LwFHMeYws3w", Name = "__slot_GarESePYRU7LwFHMeYws3w")]
        public static float __slot_GarESePYRU7LwFHMeYws3w = 1F;
        [n1.ElementAttribute(TracingId = 92870U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IjORH42VpbmNSaWZ51iXw1", Name = "__slot_IjORH42VpbmNSaWZ51iXw1")]
        public static float __slot_IjORH42VpbmNSaWZ51iXw1 = 1F;
        [n1.ElementAttribute(TracingId = 92873U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CotublbkUmQNtwvaasAU72", Name = "__slot_CotublbkUmQNtwvaasAU72")]
        public static float __slot_CotublbkUmQNtwvaasAU72 = 1F;
        [n1.ElementAttribute(TracingId = 93553U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "A52i7v614CVQCUaGvYOqwv", Name = "__slot_A52i7v614CVQCUaGvYOqwv")]
        public static bool __slot_A52i7v614CVQCUaGvYOqwv = true;
        [n1.ElementAttribute(TracingId = 93601U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VeK5WRvcrLFOpJOtQygNdS", Name = "__slot_VeK5WRvcrLFOpJOtQygNdS")]
        public static float __slot_VeK5WRvcrLFOpJOtQygNdS = 1F;
        [n1.ElementAttribute(TracingId = 94251U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Gkt8QCdLzudPw2sGxuVmQ3", Name = "__slot_Gkt8QCdLzudPw2sGxuVmQ3")]
        public static float __slot_Gkt8QCdLzudPw2sGxuVmQ3 = 2F;
        [n1.ElementAttribute(TracingId = 95363U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LdIH2bODUS0QNAFoShQihX", Name = "__slot_LdIH2bODUS0QNAFoShQihX")]
        public static float __slot_LdIH2bODUS0QNAFoShQihX = 0F;
        [n1.ElementAttribute(TracingId = 95422U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I7wFm7reOj0MTisxIZMsG6", Name = "__slot_I7wFm7reOj0MTisxIZMsG6")]
        public static float __slot_I7wFm7reOj0MTisxIZMsG6 = 2F;
        [n1.ElementAttribute(TracingId = 95762U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EUiwkR7NqawP8QAkOAkkfP", Name = "__slot_EUiwkR7NqawP8QAkOAkkfP")]
        public static int __slot_EUiwkR7NqawP8QAkOAkkfP = 1;
        [n1.ElementAttribute(TracingId = 95715U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SchHObMibz2NSWq0owXOfM", Name = "__slot_SchHObMibz2NSWq0owXOfM")]
        public static int __slot_SchHObMibz2NSWq0owXOfM = 3;
        [n1.ElementAttribute(TracingId = 95728U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ompl8ubP8NzLjxEU1YU71x", Name = "__slot_Ompl8ubP8NzLjxEU1YU71x")]
        public static int __slot_Ompl8ubP8NzLjxEU1YU71x = 1;
        [n1.ElementAttribute(TracingId = 95712U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EQvjMzEnqF7MWUh9mQPdaX", Name = "__slot_EQvjMzEnqF7MWUh9mQPdaX")]
        public static int __slot_EQvjMzEnqF7MWUh9mQPdaX = 0;
        [n1.ElementAttribute(TracingId = 95894U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VLbB3gRa5gpOoohP8qxLsw", Name = "__slot_VLbB3gRa5gpOoohP8qxLsw")]
        public static float __slot_VLbB3gRa5gpOoohP8qxLsw = 100F;
        [n1.ElementAttribute(TracingId = 95913U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MlpsUm2k5DsMVhkHuZ8AkY", Name = "__slot_MlpsUm2k5DsMVhkHuZ8AkY")]
        public static float __slot_MlpsUm2k5DsMVhkHuZ8AkY = 0.1F;
        [n1.ElementAttribute(TracingId = 95945U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ky4wVwOrZ2CM7K3tvMPh2U", Name = "__slot_Ky4wVwOrZ2CM7K3tvMPh2U")]
        public static float __slot_Ky4wVwOrZ2CM7K3tvMPh2U = 5F;
        [n1.ElementAttribute(TracingId = 95870U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LaTrLXOGcwnObz2lnAgLRQ", Name = "__slot_LaTrLXOGcwnObz2lnAgLRQ")]
        public static float __slot_LaTrLXOGcwnObz2lnAgLRQ = 360F;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Editors_.Editors._3D.Advanced
{
    [n1.ElementAttribute(TracingId = 98779U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EjrtsETNYZOMpElKECWGVG", Name = "GizmoState_R")]
    [n2.SerializableAttribute]
    public class GizmoState_R : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n34.GizmoState_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new GizmoState_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n34.GizmoState_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n34.GizmoState_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new GizmoState_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n34.GizmoState_R __DEFAULT__;
        public n34.GizmoState_R Join(n34.GizmoModel_R Gizmo_Model_In, n3.Vector3 Active_Axis_In, n3.Vector3 Translation_Offset_In, n3.Vector3 Rotation_Value_In, n3.Vector3 Scale_Offset_In, bool Visible_In, bool Idle_In)
        {
            n34.GizmoModel_R __auto_0 = Gizmo_Model_In;
            n3.Vector3 __auto_1 = Active_Axis_In;
            n3.Vector3 __auto_2 = Translation_Offset_In;
            n3.Vector3 __auto_3 = Rotation_Value_In;
            n3.Vector3 __auto_4 = Scale_Offset_In;
            bool __auto_5 = Visible_In;
            bool __auto_6 = Idle_In;
            n34.GizmoState_R that_7 = this;
            that_7 = Gizmo_Model_In != this.Gizmo_Model || Active_Axis_In != this.Active_Axis || Translation_Offset_In != this.Translation_Offset || Rotation_Value_In != this.Rotation_Offset || Scale_Offset_In != this.Scale_Offset || Visible_In != this.Visible || Idle_In != this.Idle ? new GizmoState_R(this)
            {Gizmo_Model = Gizmo_Model_In, Active_Axis = Active_Axis_In, Translation_Offset = Translation_Offset_In, Rotation_Offset = Rotation_Value_In, Scale_Offset = Scale_Offset_In, Visible = Visible_In, Idle = Idle_In} : that_7;
            return that_7;
        }

        public n34.GizmoState_R Update()
        {
            return this;
        }

        public n34.GizmoState_R Split(out n34.GizmoModel_R Gizmo_Model_Out, out n3.Vector3 Active_Axis_Out, out n3.Vector3 Translation_Offset_Out, out n3.Vector3 Rotation_Value_Out, out n3.Vector3 Scale_Offset_Out, out bool Visible_Out, out bool Idle_Out)
        {
            n34.GizmoModel_R __auto_0 = this.Gizmo_Model;
            n3.Vector3 __auto_1 = this.Active_Axis;
            n3.Vector3 __auto_2 = this.Translation_Offset;
            n3.Vector3 __auto_3 = this.Rotation_Offset;
            n3.Vector3 __auto_4 = this.Scale_Offset;
            bool __auto_5 = this.Visible;
            bool __auto_6 = this.Idle;
            Gizmo_Model_Out = __auto_0;
            Active_Axis_Out = __auto_1;
            Translation_Offset_Out = __auto_2;
            Rotation_Value_Out = __auto_3;
            Scale_Offset_Out = __auto_4;
            Visible_Out = __auto_5;
            Idle_Out = __auto_6;
            return this;
        }

        public n34.GizmoState_R __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n34.GizmoState_R that_0 = this;
            this.Translation_Offset = n51._Operations_.CreateDefault();
            this.Rotation_Offset = n51._Operations_.CreateDefault();
            this.Scale_Offset = n51._Operations_.CreateDefault();
            this.Gizmo_Model = n34.GizmoModel_R.CreateDefault();
            this.Idle = false;
            this.Visible = false;
            this.Active_Axis = n51._Operations_.CreateDefault();
            return that_0;
        }

        public n34.GizmoState_R __CreateDefault__()
        {
            n34.GizmoState_R that_0 = this;
            this.Translation_Offset = n51._Operations_.CreateDefault();
            this.Rotation_Offset = n51._Operations_.CreateDefault();
            this.Scale_Offset = n51._Operations_.CreateDefault();
            this.Gizmo_Model = n34.GizmoModel_R.CreateDefault();
            this.Idle = false;
            this.Visible = false;
            this.Active_Axis = n51._Operations_.CreateDefault();
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

        [n1.ElementAttribute(TracingId = 98783U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Laj6HDgK3u5L7p2pymF0rc", Name = "Translation Offset")]
        public n3.Vector3 Translation_Offset;
        [n1.ElementAttribute(TracingId = 98785U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "L2uaT1jrdHoMvnAsFh5GeY", Name = "Rotation Offset")]
        public n3.Vector3 Rotation_Offset;
        [n1.ElementAttribute(TracingId = 98788U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BGGAUav4w4HLCZZqzUkA6m", Name = "Scale Offset")]
        public n3.Vector3 Scale_Offset;
        [n1.ElementAttribute(TracingId = 98803U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RfwiuGgBYhvPCSfA66a4Be", Name = "Gizmo Model")]
        public n34.GizmoModel_R Gizmo_Model;
        [n1.ElementAttribute(TracingId = 98807U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SKFhI3fLKDrNHcGLuNczc4", Name = "Idle")]
        public bool Idle;
        [n1.ElementAttribute(TracingId = 98811U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CbG851U6QpGOMLi8mGrpk8", Name = "Visible")]
        public bool Visible;
        [n1.ElementAttribute(TracingId = 98815U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VCRTIuyYgwPMFb0mXtqIOr", Name = "Active Axis")]
        public n3.Vector3 Active_Axis;
        public GizmoState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoState_R(GizmoState_R other): base(other)
        {
            this.Translation_Offset = other.Translation_Offset;
            this.Rotation_Offset = other.Rotation_Offset;
            this.Scale_Offset = other.Scale_Offset;
            this.Gizmo_Model = other.Gizmo_Model;
            this.Idle = other.Idle;
            this.Visible = other.Visible;
            this.Active_Axis = other.Active_Axis;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Translation_Offset", in Translation_Offset), n1.CompilationHelper.GetValueOrExisting(values, "Rotation_Offset", in Rotation_Offset), n1.CompilationHelper.GetValueOrExisting(values, "Scale_Offset", in Scale_Offset), n1.CompilationHelper.GetValueOrExisting(values, "Gizmo_Model", in Gizmo_Model), n1.CompilationHelper.GetValueOrExisting(values, "Idle", in Idle), n1.CompilationHelper.GetValueOrExisting(values, "Visible", in Visible), n1.CompilationHelper.GetValueOrExisting(values, "Active_Axis", in Active_Axis));
        }

        internal GizmoState_R __WITH__(n3.Vector3 Translation_Offset, n3.Vector3 Rotation_Offset, n3.Vector3 Scale_Offset, n34.GizmoModel_R Gizmo_Model, bool Idle, bool Visible, n3.Vector3 Active_Axis)
        {
            n34.GizmoState_R that_0 = this;
            that_0 = Translation_Offset != this.Translation_Offset || Rotation_Offset != this.Rotation_Offset || Scale_Offset != this.Scale_Offset || Gizmo_Model != this.Gizmo_Model || Idle != this.Idle || Visible != this.Visible || Active_Axis != this.Active_Axis ? new GizmoState_R(this)
            {Translation_Offset = Translation_Offset, Rotation_Offset = Rotation_Offset, Scale_Offset = Scale_Offset, Gizmo_Model = Gizmo_Model, Idle = Idle, Visible = Visible, Active_Axis = Active_Axis} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 98903U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QTQhZ9JTgfqO01TLiBAEol", Name = "GizmoModel_R")]
    [n2.SerializableAttribute]
    public class GizmoModel_R : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n34.GizmoModel_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new GizmoModel_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n34.GizmoModel_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n34.GizmoModel_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new GizmoModel_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n34.GizmoModel_R __DEFAULT__;
        public n34.GizmoModel_R GetModelData(out n10.Spread<n46.OrientedBoundingBox> Translation_Boxes_Out, out float Gizmo_Size_Out, out n10.Spread<n46.OrientedBoundingBox> Scale_Boxes_Out, out float Pick_Size_Out, out n10.Spread<n3.Plane> Rotation_Planes_Out, out n46.OrientedBoundingBox Center_Box_Out, out n3.Vector3 Position_Out, out n3.Vector3 Enabled_Axis_Out)
        {
            n3.Vector3 __auto_0 = this.Position;
            n10.Spread<n46.OrientedBoundingBox> __auto_1 = this.Translation_Boxes;
            float __auto_2 = this.Gizmo_Size;
            n10.Spread<n46.OrientedBoundingBox> __auto_3 = this.Scale_Boxes;
            float __auto_4 = this.Pick_Size;
            n10.Spread<n3.Plane> __auto_5 = this.Rotation_Planes;
            n46.OrientedBoundingBox __auto_6 = this.Center_Box;
            n3.Vector3 __auto_7 = this.Active_Plane;
            Translation_Boxes_Out = __auto_1;
            Gizmo_Size_Out = __auto_2;
            Scale_Boxes_Out = __auto_3;
            Pick_Size_Out = __auto_4;
            Rotation_Planes_Out = __auto_5;
            Center_Box_Out = __auto_6;
            Position_Out = __auto_0;
            Enabled_Axis_Out = __auto_7;
            return this;
        }

        public n34.GizmoModel_R SetActiveComponents(n3.Vector3 Active_Axis_In, int Active_Component_In)
        {
            int __pad_Grv1QgYvWzIPexwbrmSAuo_0 = __slot_Grv1QgYvWzIPexwbrmSAuo;
            int __pad_IWU0h3LQiNKPU76pDajops_1 = __slot_IWU0h3LQiNKPU76pDajops;
            int __pad_V1KdKEkU13EMdQLIQmiaDu_2 = __slot_V1KdKEkU13EMdQLIQmiaDu;
            int __pad_HmOZm1IrSKSLJdd4xnnBsl_3 = __slot_HmOZm1IrSKSLJdd4xnnBsl;
            n3.Vector3 __auto_4 = Active_Axis_In;
            var Result_5 = Active_Component_In == __pad_Grv1QgYvWzIPexwbrmSAuo_0;
            bool __auto_6 = Result_5;
            var Result_7 = Active_Component_In == __pad_IWU0h3LQiNKPU76pDajops_1;
            bool __auto_8 = Result_7;
            var Result_9 = Active_Component_In == __pad_V1KdKEkU13EMdQLIQmiaDu_2;
            bool __auto_10 = Result_9;
            var Result_11 = Active_Component_In == __pad_HmOZm1IrSKSLJdd4xnnBsl_3;
            bool __auto_12 = Result_11;
            n34.GizmoModel_R that_13 = this;
            that_13 = Active_Axis_In != this.Active_Axis || Result_5 != this.Translation_Active || Result_7 != this.Scale_Active || Result_9 != this.Rotation_Active || Result_11 != this.Center_Active ? new GizmoModel_R(this)
            {Active_Axis = Active_Axis_In, Translation_Active = Result_5, Scale_Active = Result_7, Rotation_Active = Result_9, Center_Active = Result_11} : that_13;
            return that_13;
        }

        public n34.GizmoModel_R GetActiveComponents(out bool Translation_Active_Out, out bool Scale_Active_Out, out bool Rotation_Active_Out, out n3.Vector3 Active_Axis_Out, out bool Center_Active_Out)
        {
            bool __auto_0 = this.Translation_Active;
            bool __auto_1 = this.Scale_Active;
            bool __auto_2 = this.Rotation_Active;
            n3.Vector3 __auto_3 = this.Active_Axis;
            bool __auto_4 = this.Center_Active;
            Translation_Active_Out = __auto_0;
            Scale_Active_Out = __auto_1;
            Rotation_Active_Out = __auto_2;
            Active_Axis_Out = __auto_3;
            Center_Active_Out = __auto_4;
            return this;
        }

        public n34.GizmoModel_R GetEnabledComponents(out bool Translation_in_Projection_Out, out bool Translation_Out, out bool Scale_Out, out bool Rotation_Out)
        {
            bool __pad_J5DrSEIWSC6MBuLGPk5n8X_0 = this.__slot_J5DrSEIWSC6MBuLGPk5n8X;
            bool __pad_JNnd9CSOPw2PQciDKM6PQE_1 = this.__slot_JNnd9CSOPw2PQciDKM6PQE;
            bool __pad_D2U8hwAetBGLLha45mUCxt_2 = this.__slot_D2U8hwAetBGLLha45mUCxt;
            bool __pad_EpOKl6dAqDaNCpf43NDNoN_3 = this.__slot_EpOKl6dAqDaNCpf43NDNoN;
            Translation_in_Projection_Out = __pad_J5DrSEIWSC6MBuLGPk5n8X_0;
            Translation_Out = __pad_JNnd9CSOPw2PQciDKM6PQE_1;
            Scale_Out = __pad_D2U8hwAetBGLLha45mUCxt_2;
            Rotation_Out = __pad_EpOKl6dAqDaNCpf43NDNoN_3;
            return this;
        }

        public n34.GizmoModel_R SetEnabledComponents(int Active_Component_Index_In)
        {
            int __pad_PQODEELiUFnOK09NjKEwGK_0 = __slot_PQODEELiUFnOK09NjKEwGK;
            int __pad_CBViJ2rJYEAO1UERZflVAE_1 = __slot_CBViJ2rJYEAO1UERZflVAE;
            int __pad_MrP7x7ngu4xNdINgiHMrQ7_2 = __slot_MrP7x7ngu4xNdINgiHMrQ7;
            int __pad_KOWxV0lFIDHLckcWLmuRhJ_3 = __slot_KOWxV0lFIDHLckcWLmuRhJ;
            var Result_4 = Active_Component_Index_In > __pad_PQODEELiUFnOK09NjKEwGK_0;
            bool __pad_JNnd9CSOPw2PQciDKM6PQE_5 = Result_4;
            var Result_6 = Active_Component_Index_In > __pad_CBViJ2rJYEAO1UERZflVAE_1;
            bool __pad_D2U8hwAetBGLLha45mUCxt_7 = Result_6;
            var Result_8 = Active_Component_Index_In > __pad_MrP7x7ngu4xNdINgiHMrQ7_2;
            bool __pad_EpOKl6dAqDaNCpf43NDNoN_9 = Result_8;
            var Result_10 = Active_Component_Index_In > __pad_KOWxV0lFIDHLckcWLmuRhJ_3;
            bool __pad_J5DrSEIWSC6MBuLGPk5n8X_11 = Result_10;
            n34.GizmoModel_R that_12 = this;
            that_12 = Result_4 != this.__slot_JNnd9CSOPw2PQciDKM6PQE || Result_6 != this.__slot_D2U8hwAetBGLLha45mUCxt || Result_8 != this.__slot_EpOKl6dAqDaNCpf43NDNoN || Result_10 != this.__slot_J5DrSEIWSC6MBuLGPk5n8X ? new GizmoModel_R(this)
            {__slot_JNnd9CSOPw2PQciDKM6PQE = Result_4, __slot_D2U8hwAetBGLLha45mUCxt = Result_6, __slot_EpOKl6dAqDaNCpf43NDNoN = Result_8, __slot_J5DrSEIWSC6MBuLGPk5n8X = Result_10} : that_12;
            return that_12;
        }

        public n34.GizmoModel_R IsActive(out bool Result_Out)
        {
            bool __auto_0 = this.Translation_Active;
            bool __auto_1 = this.Scale_Active;
            bool __auto_2 = this.Rotation_Active;
            bool __auto_3 = this.Center_Active;
            n3.Vector3 __auto_4 = this.Active_Axis;
            n51._Operations_.Any(Input_In: __auto_4, Result_Out: out bool Result_5);
            var Output_6 = __auto_0 || __auto_1;
            var Output_7 = Output_6 || __auto_2;
            var Output_8 = Output_7 || __auto_3;
            var Output_9 = Output_8 || Result_5;
            Result_Out = Output_9;
            return this;
        }

        public n34.GizmoModel_R Split(out n10.Spread<n3.Matrix> Translation_Out, out n10.Spread<n3.Matrix> Scale_Out, out n10.Spread<n3.Matrix> Rotation_Out, out n3.Matrix Center_Out, out n3.Vector3 Position_Out, out n3.Vector3 Active_Axis_Out, out bool Translation_Active_Out, out bool Scale_Active_Out, out bool Rotation_Active_Out, out bool Center_Active_Out, out bool Center_Enabled_Out, out bool Translation_Enabled_Out, out bool Scale_Enabled_Out, out bool Rotation_Enabled_Out, out float Pick_Size_Out, out float Gizmo_Size_Out, out n3.Vector3 Active_Plane_Out)
        {
            n3.Vector3 __auto_0 = this.Position;
            n10.Spread<n46.OrientedBoundingBox> __auto_1 = this.Translation_Boxes;
            n10.Spread<n46.OrientedBoundingBox> __auto_2 = this.Scale_Boxes;
            n10.Spread<n3.Matrix> __pad_VC232rHbyujLqg30Xv7ZZh_3 = this.__slot_VC232rHbyujLqg30Xv7ZZh;
            float __auto_4 = this.Gizmo_Size;
            n46.OrientedBoundingBox __auto_5 = this.Center_Box;
            n3.Vector3 __auto_6 = this.Active_Axis;
            bool __auto_7 = this.Translation_Active;
            bool __auto_8 = this.Scale_Active;
            bool __auto_9 = this.Rotation_Active;
            bool __auto_10 = this.Center_Active;
            bool __pad_J5DrSEIWSC6MBuLGPk5n8X_11 = this.__slot_J5DrSEIWSC6MBuLGPk5n8X;
            bool __pad_JNnd9CSOPw2PQciDKM6PQE_12 = this.__slot_JNnd9CSOPw2PQciDKM6PQE;
            bool __pad_D2U8hwAetBGLLha45mUCxt_13 = this.__slot_D2U8hwAetBGLLha45mUCxt;
            bool __pad_EpOKl6dAqDaNCpf43NDNoN_14 = this.__slot_EpOKl6dAqDaNCpf43NDNoN;
            float __auto_15 = this.Pick_Size;
            float __auto_16 = this.Gizmo_Size;
            n3.Vector3 __auto_17 = this.Active_Plane;
            n38._Operations_.GetMatrices<n10.Spread<n46.OrientedBoundingBox>, n10.Spread<n46.OrientedBoundingBox>, n10.Spread<n3.Matrix>>(Translation_Boxes_In: __auto_1, Scale_Boxes_In: __auto_2, Rotation_Matrices_In: __pad_VC232rHbyujLqg30Xv7ZZh_3, Size_In: __auto_4, Position_In: __auto_0, Pin_Out: out n10.Spread<n3.Matrix> Pin_18, Pin_2_Out: out n10.Spread<n3.Matrix> Pin_2_19, Pin_3_Out: out n10.Spread<n3.Matrix> Pin_3_20);
            var Center_21 = __auto_5.Center;
            n3.Matrix Input_22 = n55._Operations_.CreateDefault();
            n62._Operations_.Translate(Input_In: Input_22, Translation_In: Center_21, Output_Out: out n3.Matrix Output_23);
            var Size_24 = __auto_5.Size;
            n62._Operations_.Scale(Input_In: Output_23, Scaling_In: Size_24, Output_Out: out n3.Matrix Output_25);
            Translation_Out = Pin_18;
            Scale_Out = Pin_2_19;
            Rotation_Out = Pin_3_20;
            Center_Out = Output_25;
            Position_Out = __auto_0;
            Active_Axis_Out = __auto_6;
            Translation_Active_Out = __auto_7;
            Scale_Active_Out = __auto_8;
            Rotation_Active_Out = __auto_9;
            Center_Active_Out = __auto_10;
            Center_Enabled_Out = __pad_J5DrSEIWSC6MBuLGPk5n8X_11;
            Translation_Enabled_Out = __pad_JNnd9CSOPw2PQciDKM6PQE_12;
            Scale_Enabled_Out = __pad_D2U8hwAetBGLLha45mUCxt_13;
            Rotation_Enabled_Out = __pad_EpOKl6dAqDaNCpf43NDNoN_14;
            Pick_Size_Out = __auto_15;
            Gizmo_Size_Out = __auto_16;
            Active_Plane_Out = __auto_17;
            return this;
        }

        public n34.GizmoModel_R SetActivePlane(int Active_Plane_In)
        {
            n3.Vector3 __pad_LmhZefZFKXBQcCvCGYBt2W_0 = __slot_LmhZefZFKXBQcCvCGYBt2W;
            n3.Vector3 __pad_Jb9jvG6fI90OYcnPDn5ROJ_1 = __slot_Jb9jvG6fI90OYcnPDn5ROJ;
            n3.Vector3 __pad_HZ6kOcpBtEWPlUcgWyroDm_2 = __slot_HZ6kOcpBtEWPlUcgWyroDm;
            n3.Vector3 __pad_IW3lqUaIRp5Lr2umC7HUGE_3 = __slot_IW3lqUaIRp5Lr2umC7HUGE;
            var builder_4 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9, 4);
            builder_4.Add(__pad_LmhZefZFKXBQcCvCGYBt2W_0);
            builder_4.Add(__pad_Jb9jvG6fI90OYcnPDn5ROJ_1);
            builder_4.Add(__pad_HZ6kOcpBtEWPlUcgWyroDm_2);
            builder_4.Add(__pad_IW3lqUaIRp5Lr2umC7HUGE_3);
            var __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9_5 = builder_4.Commit();
            n14._Operations_.Cons<n3.Vector3>(Input_In: __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9_5, Result_Out: out n10.Spread<n3.Vector3> Result_6);
            n3.Vector3 Default_Value_7 = n51._Operations_.CreateDefault();
            n14._Operations_.GetSlice<n3.Vector3>(Input_In: Result_6, Default_Value_In: Default_Value_7, Index_In: Active_Plane_In, Result_Out: out n3.Vector3 Result_8);
            n3.Vector3 __auto_9 = Result_8;
            n34.GizmoModel_R that_10 = this;
            that_10 = __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9_5 != this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 || Result_8 != this.Active_Plane ? new GizmoModel_R(this)
            {__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9_5, Active_Plane = Result_8} : that_10;
            return that_10;
        }

        public n34.GizmoModel_R Translate()
        {
            n10.Spread<n46.OrientedBoundingBox> __pad_I8FtVRLVZmAMbKk8gzCfBv_0 = this.__slot_I8FtVRLVZmAMbKk8gzCfBv;
            n10.Spread<n46.OrientedBoundingBox> __pad_PwRD1YZsLdtQP5HRRkmDWb_1 = this.__slot_PwRD1YZsLdtQP5HRRkmDWb;
            n10.Spread<n3.Plane> __pad_CXOshgwhxZ2Ps8RnKwuDbu_2 = this.__slot_CXOshgwhxZ2Ps8RnKwuDbu;
            n46.OrientedBoundingBox __pad_UadyTVN8bcEPmvTrs9dAHw_3 = this.__slot_UadyTVN8bcEPmvTrs9dAHw;
            n3.Vector3 __auto_4 = this.Position;
            n38._Operations_.Translate<n10.Spread<n46.OrientedBoundingBox>, n10.Spread<n46.OrientedBoundingBox>, n10.Spread<n3.Plane>>(Translation_In: __pad_I8FtVRLVZmAMbKk8gzCfBv_0, Scale_In: __pad_PwRD1YZsLdtQP5HRRkmDWb_1, Rotation_In: __pad_CXOshgwhxZ2Ps8RnKwuDbu_2, Center_In: __pad_UadyTVN8bcEPmvTrs9dAHw_3, Position_In: __auto_4, Translation_Out: out n10.Spread<n46.OrientedBoundingBox> Translation_5, Scale_Out: out n10.Spread<n46.OrientedBoundingBox> Scale_6, Rotation_Out: out n10.Spread<n3.Plane> Rotation_7, Center_Out: out n46.OrientedBoundingBox Center_8);
            n10.Spread<n46.OrientedBoundingBox> __auto_9 = Translation_5;
            n10.Spread<n46.OrientedBoundingBox> __auto_10 = Scale_6;
            n10.Spread<n3.Plane> __auto_11 = Rotation_7;
            n46.OrientedBoundingBox __auto_12 = Center_8;
            n34.GizmoModel_R that_13 = this;
            that_13 = Translation_5 != this.Translation_Boxes || Scale_6 != this.Scale_Boxes || Rotation_7 != this.Rotation_Planes || !n23.EqualityComparer<n46.OrientedBoundingBox>.Default.Equals(Center_8, this.Center_Box) ? new GizmoModel_R(this)
            {Translation_Boxes = Translation_5, Scale_Boxes = Scale_6, Rotation_Planes = Rotation_7, Center_Box = Center_8} : that_13;
            return that_13;
        }

        public n34.GizmoModel_R Init([n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, float Pick_Size_In, n3.Vector3 Position_In)
        {
            float __auto_0 = Gizmo_Size_In;
            n38._Operations_.GetTranslationBoxes(Size_In: Gizmo_Size_In, Pick_Size_In: Pick_Size_In, Output_Out: out n10.Spread<n46.OrientedBoundingBox> Output_1);
            float __auto_2 = Pick_Size_In;
            n38._Operations_.GetCenterBox(Pick_Size_In: Pick_Size_In, Result_Out: out n46.OrientedBoundingBox Result_3);
            n46.OrientedBoundingBox __pad_UadyTVN8bcEPmvTrs9dAHw_4 = Result_3;
            n38._Operations_.GetScaleBoxes(Pick_Size_In: Pick_Size_In, Size_In: Gizmo_Size_In, Output_Out: out n10.Spread<n46.OrientedBoundingBox> Output_5);
            n10.Spread<n46.OrientedBoundingBox> __pad_PwRD1YZsLdtQP5HRRkmDWb_6 = Output_5;
            n10.Spread<n46.OrientedBoundingBox> __pad_I8FtVRLVZmAMbKk8gzCfBv_7 = Output_1;
            n3.Vector3 __auto_8 = Position_In;
            n38._Operations_.GetRotationPlanes(Planes_Out: out n10.Spread<n3.Plane> Planes_9, Matrices_Out: out n10.Spread<n3.Matrix> Matrices_10);
            n10.Spread<n3.Plane> __pad_CXOshgwhxZ2Ps8RnKwuDbu_11 = Planes_9;
            n10.Spread<n3.Matrix> __pad_VC232rHbyujLqg30Xv7ZZh_12 = Matrices_10;
            n34.GizmoModel_R that_13 = this;
            that_13 = Gizmo_Size_In != this.Gizmo_Size || Pick_Size_In != this.Pick_Size || !n23.EqualityComparer<n46.OrientedBoundingBox>.Default.Equals(Result_3, this.__slot_UadyTVN8bcEPmvTrs9dAHw) || Output_5 != this.__slot_PwRD1YZsLdtQP5HRRkmDWb || Output_1 != this.__slot_I8FtVRLVZmAMbKk8gzCfBv || Position_In != this.Position || Planes_9 != this.__slot_CXOshgwhxZ2Ps8RnKwuDbu || Matrices_10 != this.__slot_VC232rHbyujLqg30Xv7ZZh ? new GizmoModel_R(this)
            {Gizmo_Size = Gizmo_Size_In, Pick_Size = Pick_Size_In, __slot_UadyTVN8bcEPmvTrs9dAHw = Result_3, __slot_PwRD1YZsLdtQP5HRRkmDWb = Output_5, __slot_I8FtVRLVZmAMbKk8gzCfBv = Output_1, Position = Position_In, __slot_CXOshgwhxZ2Ps8RnKwuDbu = Planes_9, __slot_VC232rHbyujLqg30Xv7ZZh = Matrices_10} : that_13;
            return that_13;
        }

        public n34.GizmoModel_R __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n34.GizmoModel_R that_0 = this;
            this.__slot_VC232rHbyujLqg30Xv7ZZh = n14._Operations_.CreateDefault<n3.Matrix>();
            this.__slot_JNnd9CSOPw2PQciDKM6PQE = false;
            this.__slot_D2U8hwAetBGLLha45mUCxt = false;
            this.__slot_EpOKl6dAqDaNCpf43NDNoN = false;
            this.__slot_UadyTVN8bcEPmvTrs9dAHw = default(n46.OrientedBoundingBox);
            this.__slot_CXOshgwhxZ2Ps8RnKwuDbu = n14._Operations_.CreateDefault<n3.Plane>();
            this.__slot_PwRD1YZsLdtQP5HRRkmDWb = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.__slot_I8FtVRLVZmAMbKk8gzCfBv = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.__slot_J5DrSEIWSC6MBuLGPk5n8X = false;
            this.Gizmo_Size = 0F;
            this.Pick_Size = 0F;
            this.Translation_Active = false;
            this.Scale_Active = false;
            this.Rotation_Active = false;
            this.Active_Axis = n51._Operations_.CreateDefault();
            this.Translation_Boxes = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.Scale_Boxes = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.Rotation_Planes = n14._Operations_.CreateDefault<n3.Plane>();
            this.Position = n51._Operations_.CreateDefault();
            this.Center_Box = default(n46.OrientedBoundingBox);
            this.Center_Active = false;
            this.Active_Plane = n51._Operations_.CreateDefault();
            this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = n14._Operations_.CreateDefault<n3.Vector3>();
            return that_0;
        }

        public n34.GizmoModel_R __CreateDefault__()
        {
            n34.GizmoModel_R that_0 = this;
            this.__slot_VC232rHbyujLqg30Xv7ZZh = n14._Operations_.CreateDefault<n3.Matrix>();
            this.__slot_JNnd9CSOPw2PQciDKM6PQE = false;
            this.__slot_D2U8hwAetBGLLha45mUCxt = false;
            this.__slot_EpOKl6dAqDaNCpf43NDNoN = false;
            this.__slot_UadyTVN8bcEPmvTrs9dAHw = default(n46.OrientedBoundingBox);
            this.__slot_CXOshgwhxZ2Ps8RnKwuDbu = n14._Operations_.CreateDefault<n3.Plane>();
            this.__slot_PwRD1YZsLdtQP5HRRkmDWb = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.__slot_I8FtVRLVZmAMbKk8gzCfBv = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.__slot_J5DrSEIWSC6MBuLGPk5n8X = false;
            this.Gizmo_Size = 0F;
            this.Pick_Size = 0F;
            this.Translation_Active = false;
            this.Scale_Active = false;
            this.Rotation_Active = false;
            this.Active_Axis = n51._Operations_.CreateDefault();
            this.Translation_Boxes = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.Scale_Boxes = n14._Operations_.CreateDefault<n46.OrientedBoundingBox>();
            this.Rotation_Planes = n14._Operations_.CreateDefault<n3.Plane>();
            this.Position = n51._Operations_.CreateDefault();
            this.Center_Box = default(n46.OrientedBoundingBox);
            this.Center_Active = false;
            this.Active_Plane = n51._Operations_.CreateDefault();
            this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = n14._Operations_.CreateDefault<n3.Vector3>();
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

        [n1.ElementAttribute(TracingId = 98995U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VC232rHbyujLqg30Xv7ZZh", Name = "__slot_VC232rHbyujLqg30Xv7ZZh")]
        public n10.Spread<n3.Matrix> __slot_VC232rHbyujLqg30Xv7ZZh;
        [n1.ElementAttribute(TracingId = 99019U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Grv1QgYvWzIPexwbrmSAuo", Name = "__slot_Grv1QgYvWzIPexwbrmSAuo")]
        public static int __slot_Grv1QgYvWzIPexwbrmSAuo = 1;
        [n1.ElementAttribute(TracingId = 99020U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "V1KdKEkU13EMdQLIQmiaDu", Name = "__slot_V1KdKEkU13EMdQLIQmiaDu")]
        public static int __slot_V1KdKEkU13EMdQLIQmiaDu = 3;
        [n1.ElementAttribute(TracingId = 99024U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IWU0h3LQiNKPU76pDajops", Name = "__slot_IWU0h3LQiNKPU76pDajops")]
        public static int __slot_IWU0h3LQiNKPU76pDajops = 2;
        [n1.ElementAttribute(TracingId = 99025U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JNnd9CSOPw2PQciDKM6PQE", Name = "__slot_JNnd9CSOPw2PQciDKM6PQE")]
        public bool __slot_JNnd9CSOPw2PQciDKM6PQE;
        [n1.ElementAttribute(TracingId = 99027U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "D2U8hwAetBGLLha45mUCxt", Name = "__slot_D2U8hwAetBGLLha45mUCxt")]
        public bool __slot_D2U8hwAetBGLLha45mUCxt;
        [n1.ElementAttribute(TracingId = 99029U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EpOKl6dAqDaNCpf43NDNoN", Name = "__slot_EpOKl6dAqDaNCpf43NDNoN")]
        public bool __slot_EpOKl6dAqDaNCpf43NDNoN;
        [n1.ElementAttribute(TracingId = 99095U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HmOZm1IrSKSLJdd4xnnBsl", Name = "__slot_HmOZm1IrSKSLJdd4xnnBsl")]
        public static int __slot_HmOZm1IrSKSLJdd4xnnBsl = 0;
        [n1.ElementAttribute(TracingId = 99109U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Jb9jvG6fI90OYcnPDn5ROJ", Name = "__slot_Jb9jvG6fI90OYcnPDn5ROJ")]
        public static n3.Vector3 __slot_Jb9jvG6fI90OYcnPDn5ROJ = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 1, 0", false, "RMDMfKmnIrVPStLdWe8u30", "Jb9jvG6fI90OYcnPDn5ROJ");
        [n1.ElementAttribute(TracingId = 99113U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HZ6kOcpBtEWPlUcgWyroDm", Name = "__slot_HZ6kOcpBtEWPlUcgWyroDm")]
        public static n3.Vector3 __slot_HZ6kOcpBtEWPlUcgWyroDm = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0, 1", false, "RMDMfKmnIrVPStLdWe8u30", "HZ6kOcpBtEWPlUcgWyroDm");
        [n1.ElementAttribute(TracingId = 99116U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IW3lqUaIRp5Lr2umC7HUGE", Name = "__slot_IW3lqUaIRp5Lr2umC7HUGE")]
        public static n3.Vector3 __slot_IW3lqUaIRp5Lr2umC7HUGE = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 1, 1", false, "RMDMfKmnIrVPStLdWe8u30", "IW3lqUaIRp5Lr2umC7HUGE");
        [n1.ElementAttribute(TracingId = 99117U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LmhZefZFKXBQcCvCGYBt2W", Name = "__slot_LmhZefZFKXBQcCvCGYBt2W")]
        public static n3.Vector3 __slot_LmhZefZFKXBQcCvCGYBt2W = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 1, 1", false, "RMDMfKmnIrVPStLdWe8u30", "LmhZefZFKXBQcCvCGYBt2W");
        [n1.ElementAttribute(TracingId = 99152U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PQODEELiUFnOK09NjKEwGK", Name = "__slot_PQODEELiUFnOK09NjKEwGK")]
        public static int __slot_PQODEELiUFnOK09NjKEwGK = 0;
        [n1.ElementAttribute(TracingId = 99164U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MrP7x7ngu4xNdINgiHMrQ7", Name = "__slot_MrP7x7ngu4xNdINgiHMrQ7")]
        public static int __slot_MrP7x7ngu4xNdINgiHMrQ7 = 2;
        [n1.ElementAttribute(TracingId = 99165U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CBViJ2rJYEAO1UERZflVAE", Name = "__slot_CBViJ2rJYEAO1UERZflVAE")]
        public static int __slot_CBViJ2rJYEAO1UERZflVAE = 1;
        [n1.ElementAttribute(TracingId = 99171U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UadyTVN8bcEPmvTrs9dAHw", Name = "__slot_UadyTVN8bcEPmvTrs9dAHw")]
        public n46.OrientedBoundingBox __slot_UadyTVN8bcEPmvTrs9dAHw;
        [n1.ElementAttribute(TracingId = 99172U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CXOshgwhxZ2Ps8RnKwuDbu", Name = "__slot_CXOshgwhxZ2Ps8RnKwuDbu")]
        public n10.Spread<n3.Plane> __slot_CXOshgwhxZ2Ps8RnKwuDbu;
        [n1.ElementAttribute(TracingId = 99174U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PwRD1YZsLdtQP5HRRkmDWb", Name = "__slot_PwRD1YZsLdtQP5HRRkmDWb")]
        public n10.Spread<n46.OrientedBoundingBox> __slot_PwRD1YZsLdtQP5HRRkmDWb;
        [n1.ElementAttribute(TracingId = 99175U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I8FtVRLVZmAMbKk8gzCfBv", Name = "__slot_I8FtVRLVZmAMbKk8gzCfBv")]
        public n10.Spread<n46.OrientedBoundingBox> __slot_I8FtVRLVZmAMbKk8gzCfBv;
        [n1.ElementAttribute(TracingId = 99202U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KOWxV0lFIDHLckcWLmuRhJ", Name = "__slot_KOWxV0lFIDHLckcWLmuRhJ")]
        public static int __slot_KOWxV0lFIDHLckcWLmuRhJ = -1;
        [n1.ElementAttribute(TracingId = 99203U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "J5DrSEIWSC6MBuLGPk5n8X", Name = "__slot_J5DrSEIWSC6MBuLGPk5n8X")]
        public bool __slot_J5DrSEIWSC6MBuLGPk5n8X;
        [n1.ElementAttribute(TracingId = 98941U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LT7zHcYHIMwNHNVYAWn76C", Name = "Gizmo Size")]
        public float Gizmo_Size;
        [n1.ElementAttribute(TracingId = 98950U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "D2ad175CGRzNmEUS2WBmHO", Name = "Pick Size")]
        public float Pick_Size;
        [n1.ElementAttribute(TracingId = 98954U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SuVNYBi3vgHOCKUdf9Yoci", Name = "Translation Active")]
        public bool Translation_Active;
        [n1.ElementAttribute(TracingId = 98958U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "S1NxLjdiophN2v0HeCnvCr", Name = "Scale Active")]
        public bool Scale_Active;
        [n1.ElementAttribute(TracingId = 98956U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TmwtaiRgjDqMSVmZp7VoQ7", Name = "Rotation Active")]
        public bool Rotation_Active;
        [n1.ElementAttribute(TracingId = 98967U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PrvzyIb0Uo0LZxbVMdABvc", Name = "Active Axis")]
        public n3.Vector3 Active_Axis;
        [n1.ElementAttribute(TracingId = 99002U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FGeu8nURTZTP3tdYa3kK9l", Name = "Translation Boxes")]
        public n10.Spread<n46.OrientedBoundingBox> Translation_Boxes;
        [n1.ElementAttribute(TracingId = 99000U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SdD8I5I5bymPZh7SgpY1Ma", Name = "Scale Boxes")]
        public n10.Spread<n46.OrientedBoundingBox> Scale_Boxes;
        [n1.ElementAttribute(TracingId = 98998U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VOTIfuwULTnLsWTevIiBRr", Name = "Rotation Planes")]
        public n10.Spread<n3.Plane> Rotation_Planes;
        [n1.ElementAttribute(TracingId = 98928U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Aqao2rBpxfXNm2qlrHWwGT", Name = "Position")]
        public n3.Vector3 Position;
        [n1.ElementAttribute(TracingId = 99042U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PKwEUgrTSUTLZzGi5y6lB4", Name = "Center Box")]
        public n46.OrientedBoundingBox Center_Box;
        [n1.ElementAttribute(TracingId = 99068U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Cp1TptXlLsTMOCpWyKIW63", Name = "Center Active")]
        public bool Center_Active;
        [n1.ElementAttribute(TracingId = 99108U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NNbJ2Y7A28zMLM5q4Mdbu9", Name = "Active Plane")]
        public n3.Vector3 Active_Plane;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<n3.Vector3> __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = default(n10.Spread<n3.Vector3>);
        static GizmoModel_R()
        {
        }

        public GizmoModel_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoModel_R(GizmoModel_R other): base(other)
        {
            this.__slot_VC232rHbyujLqg30Xv7ZZh = other.__slot_VC232rHbyujLqg30Xv7ZZh;
            this.__slot_JNnd9CSOPw2PQciDKM6PQE = other.__slot_JNnd9CSOPw2PQciDKM6PQE;
            this.__slot_D2U8hwAetBGLLha45mUCxt = other.__slot_D2U8hwAetBGLLha45mUCxt;
            this.__slot_EpOKl6dAqDaNCpf43NDNoN = other.__slot_EpOKl6dAqDaNCpf43NDNoN;
            this.__slot_UadyTVN8bcEPmvTrs9dAHw = other.__slot_UadyTVN8bcEPmvTrs9dAHw;
            this.__slot_CXOshgwhxZ2Ps8RnKwuDbu = other.__slot_CXOshgwhxZ2Ps8RnKwuDbu;
            this.__slot_PwRD1YZsLdtQP5HRRkmDWb = other.__slot_PwRD1YZsLdtQP5HRRkmDWb;
            this.__slot_I8FtVRLVZmAMbKk8gzCfBv = other.__slot_I8FtVRLVZmAMbKk8gzCfBv;
            this.__slot_J5DrSEIWSC6MBuLGPk5n8X = other.__slot_J5DrSEIWSC6MBuLGPk5n8X;
            this.Gizmo_Size = other.Gizmo_Size;
            this.Pick_Size = other.Pick_Size;
            this.Translation_Active = other.Translation_Active;
            this.Scale_Active = other.Scale_Active;
            this.Rotation_Active = other.Rotation_Active;
            this.Active_Axis = other.Active_Axis;
            this.Translation_Boxes = other.Translation_Boxes;
            this.Scale_Boxes = other.Scale_Boxes;
            this.Rotation_Planes = other.Rotation_Planes;
            this.Position = other.Position;
            this.Center_Box = other.Center_Box;
            this.Center_Active = other.Center_Active;
            this.Active_Plane = other.Active_Plane;
            this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = other.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_VC232rHbyujLqg30Xv7ZZh", in __slot_VC232rHbyujLqg30Xv7ZZh), n1.CompilationHelper.GetValueOrExisting(values, "__slot_JNnd9CSOPw2PQciDKM6PQE", in __slot_JNnd9CSOPw2PQciDKM6PQE), n1.CompilationHelper.GetValueOrExisting(values, "__slot_D2U8hwAetBGLLha45mUCxt", in __slot_D2U8hwAetBGLLha45mUCxt), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EpOKl6dAqDaNCpf43NDNoN", in __slot_EpOKl6dAqDaNCpf43NDNoN), n1.CompilationHelper.GetValueOrExisting(values, "__slot_UadyTVN8bcEPmvTrs9dAHw", in __slot_UadyTVN8bcEPmvTrs9dAHw), n1.CompilationHelper.GetValueOrExisting(values, "__slot_CXOshgwhxZ2Ps8RnKwuDbu", in __slot_CXOshgwhxZ2Ps8RnKwuDbu), n1.CompilationHelper.GetValueOrExisting(values, "__slot_PwRD1YZsLdtQP5HRRkmDWb", in __slot_PwRD1YZsLdtQP5HRRkmDWb), n1.CompilationHelper.GetValueOrExisting(values, "__slot_I8FtVRLVZmAMbKk8gzCfBv", in __slot_I8FtVRLVZmAMbKk8gzCfBv), n1.CompilationHelper.GetValueOrExisting(values, "__slot_J5DrSEIWSC6MBuLGPk5n8X", in __slot_J5DrSEIWSC6MBuLGPk5n8X), n1.CompilationHelper.GetValueOrExisting(values, "Gizmo_Size", in Gizmo_Size), n1.CompilationHelper.GetValueOrExisting(values, "Pick_Size", in Pick_Size), n1.CompilationHelper.GetValueOrExisting(values, "Translation_Active", in Translation_Active), n1.CompilationHelper.GetValueOrExisting(values, "Scale_Active", in Scale_Active), n1.CompilationHelper.GetValueOrExisting(values, "Rotation_Active", in Rotation_Active), n1.CompilationHelper.GetValueOrExisting(values, "Active_Axis", in Active_Axis), n1.CompilationHelper.GetValueOrExisting(values, "Translation_Boxes", in Translation_Boxes), n1.CompilationHelper.GetValueOrExisting(values, "Scale_Boxes", in Scale_Boxes), n1.CompilationHelper.GetValueOrExisting(values, "Rotation_Planes", in Rotation_Planes), n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Center_Box", in Center_Box), n1.CompilationHelper.GetValueOrExisting(values, "Center_Active", in Center_Active), n1.CompilationHelper.GetValueOrExisting(values, "Active_Plane", in Active_Plane), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9", in __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9));
        }

        internal GizmoModel_R __WITH__(n10.Spread<n3.Matrix> __slot_VC232rHbyujLqg30Xv7ZZh, bool __slot_JNnd9CSOPw2PQciDKM6PQE, bool __slot_D2U8hwAetBGLLha45mUCxt, bool __slot_EpOKl6dAqDaNCpf43NDNoN, n46.OrientedBoundingBox __slot_UadyTVN8bcEPmvTrs9dAHw, n10.Spread<n3.Plane> __slot_CXOshgwhxZ2Ps8RnKwuDbu, n10.Spread<n46.OrientedBoundingBox> __slot_PwRD1YZsLdtQP5HRRkmDWb, n10.Spread<n46.OrientedBoundingBox> __slot_I8FtVRLVZmAMbKk8gzCfBv, bool __slot_J5DrSEIWSC6MBuLGPk5n8X, float Gizmo_Size, float Pick_Size, bool Translation_Active, bool Scale_Active, bool Rotation_Active, n3.Vector3 Active_Axis, n10.Spread<n46.OrientedBoundingBox> Translation_Boxes, n10.Spread<n46.OrientedBoundingBox> Scale_Boxes, n10.Spread<n3.Plane> Rotation_Planes, n3.Vector3 Position, n46.OrientedBoundingBox Center_Box, bool Center_Active, n3.Vector3 Active_Plane, n10.Spread<n3.Vector3> __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9)
        {
            n34.GizmoModel_R that_0 = this;
            that_0 = __slot_VC232rHbyujLqg30Xv7ZZh != this.__slot_VC232rHbyujLqg30Xv7ZZh || __slot_JNnd9CSOPw2PQciDKM6PQE != this.__slot_JNnd9CSOPw2PQciDKM6PQE || __slot_D2U8hwAetBGLLha45mUCxt != this.__slot_D2U8hwAetBGLLha45mUCxt || __slot_EpOKl6dAqDaNCpf43NDNoN != this.__slot_EpOKl6dAqDaNCpf43NDNoN || !n23.EqualityComparer<n46.OrientedBoundingBox>.Default.Equals(__slot_UadyTVN8bcEPmvTrs9dAHw, this.__slot_UadyTVN8bcEPmvTrs9dAHw) || __slot_CXOshgwhxZ2Ps8RnKwuDbu != this.__slot_CXOshgwhxZ2Ps8RnKwuDbu || __slot_PwRD1YZsLdtQP5HRRkmDWb != this.__slot_PwRD1YZsLdtQP5HRRkmDWb || __slot_I8FtVRLVZmAMbKk8gzCfBv != this.__slot_I8FtVRLVZmAMbKk8gzCfBv || __slot_J5DrSEIWSC6MBuLGPk5n8X != this.__slot_J5DrSEIWSC6MBuLGPk5n8X || Gizmo_Size != this.Gizmo_Size || Pick_Size != this.Pick_Size || Translation_Active != this.Translation_Active || Scale_Active != this.Scale_Active || Rotation_Active != this.Rotation_Active || Active_Axis != this.Active_Axis || Translation_Boxes != this.Translation_Boxes || Scale_Boxes != this.Scale_Boxes || Rotation_Planes != this.Rotation_Planes || Position != this.Position || !n23.EqualityComparer<n46.OrientedBoundingBox>.Default.Equals(Center_Box, this.Center_Box) || Center_Active != this.Center_Active || Active_Plane != this.Active_Plane || __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 != this.__pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 ? new GizmoModel_R(this)
            {__slot_VC232rHbyujLqg30Xv7ZZh = __slot_VC232rHbyujLqg30Xv7ZZh, __slot_JNnd9CSOPw2PQciDKM6PQE = __slot_JNnd9CSOPw2PQciDKM6PQE, __slot_D2U8hwAetBGLLha45mUCxt = __slot_D2U8hwAetBGLLha45mUCxt, __slot_EpOKl6dAqDaNCpf43NDNoN = __slot_EpOKl6dAqDaNCpf43NDNoN, __slot_UadyTVN8bcEPmvTrs9dAHw = __slot_UadyTVN8bcEPmvTrs9dAHw, __slot_CXOshgwhxZ2Ps8RnKwuDbu = __slot_CXOshgwhxZ2Ps8RnKwuDbu, __slot_PwRD1YZsLdtQP5HRRkmDWb = __slot_PwRD1YZsLdtQP5HRRkmDWb, __slot_I8FtVRLVZmAMbKk8gzCfBv = __slot_I8FtVRLVZmAMbKk8gzCfBv, __slot_J5DrSEIWSC6MBuLGPk5n8X = __slot_J5DrSEIWSC6MBuLGPk5n8X, Gizmo_Size = Gizmo_Size, Pick_Size = Pick_Size, Translation_Active = Translation_Active, Scale_Active = Scale_Active, Rotation_Active = Rotation_Active, Active_Axis = Active_Axis, Translation_Boxes = Translation_Boxes, Scale_Boxes = Scale_Boxes, Rotation_Planes = Rotation_Planes, Position = Position, Center_Box = Center_Box, Center_Active = Center_Active, Active_Plane = Active_Plane, __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9 = __pin_group_Input_In_EEvLsnkMfulPzD1WMLcDT9} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 99521U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FwMKMU2m58nOMS2ThuJF65", Name = "GizmoControls_FwMKMU2m58nOMS2ThuJF65")]
    [n2.SerializableAttribute]
    public class GizmoControls_FwMKMU2m58nOMS2ThuJF65 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 Create(n1.NodeContext Node_Context)
        {
            var instance = new GizmoControls_FwMKMU2m58nOMS2ThuJF65(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 CreateDefault()
        {
            var instance = new GizmoControls_FwMKMU2m58nOMS2ThuJF65(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 Update(n43.IMouse Mouse_In, n43.IKeyboard Keyboard_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_Out)
        {
            n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> __auto_0 = this.Controls;
            string __pad_F3SqyWDC3StL8zL7VrnDGq_1 = __slot_F3SqyWDC3StL8zL7VrnDGq;
            string __pad_KZvg7DzMd8VOycNLnyBFw4_2 = __slot_KZvg7DzMd8VOycNLnyBFw4;
            string __pad_PEIvZsb7TchPQIRgzn2lO6_3 = __slot_PEIvZsb7TchPQIRgzn2lO6;
            string __pad_L37pnd5fr3VNXkeCK8q5ll_4 = __slot_L37pnd5fr3VNXkeCK8q5ll;
            string __pad_M6IvbjpiNjyOrpNvLqSL8K_5 = __slot_M6IvbjpiNjyOrpNvLqSL8K;
            string __pad_A7JpJ8gkdPSNSUMvonj82G_6 = __slot_A7JpJ8gkdPSNSUMvonj82G;
            string __pad_NpSXUqlTpXXL5Uw33Ly6Bf_7 = __slot_NpSXUqlTpXXL5Uw33Ly6Bf;
            float __pad_MEI14jl7889PI4AyOpTHrf_8 = __slot_MEI14jl7889PI4AyOpTHrf;
            string __pad_BDjhtpoAcf0OfK1pGkU3wS_9 = __slot_BDjhtpoAcf0OfK1pGkU3wS;
            string __pad_Q5PDgPFzSXcMSgQfcI5EFV_10 = __slot_Q5PDgPFzSXcMSgQfcI5EFV;
            var Output_21 = this.__p_Iibogj8YyDkM2vgSJaggsZ.Update(Mouse_Device_In: Mouse_In, Position_In_World_Out: out n3.Vector2 Position_In_World_11, Position_In_Projection_Out: out n3.Vector2 Position_In_Projection_12, Position_Out: out n3.Vector2 Position_13, Left_Pressed_Out: out bool Left_Pressed_14, Middle_Pressed_Out: out bool Middle_Pressed_15, Right_Pressed_Out: out bool Right_Pressed_16, Normalized_Position_Out: out n3.Vector2 Normalized_Position_17, WheelDelta_Out: out int WheelDelta_18, Client_Area_Out: out n3.Vector2 Client_Area_19, Sender_Out: out n2.Object Sender_20);
            var Output_23 = this.__p_FmDhCqW2dFsNv9WzvKxmHe.Update(Keyboard_Device_In: Keyboard_In, Pressed_Keys_Out: out n40.ImmutableHashSet<n39.Keys> Pressed_Keys_22);
            var Output_25 = this.__p_CwsQ1o8k0O5NemqWxQWIXB.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_F3SqyWDC3StL8zL7VrnDGq_1, Is_Down_Out: out bool Is_Down_24);
            var Output_28 = this.__p_Eag0kYY6Y2qMSYUu4lSp6f.Update(Value_In: Is_Down_24, Up_Edge_Out: out bool Up_Edge_26, Down_Edge_Out: out bool Down_Edge_27);
            float Input_29 = n2.Convert.ToSingle(Up_Edge_26);
            var Output_30 = Input_29 * __pad_MEI14jl7889PI4AyOpTHrf_8;
            var Output_32 = this.__p_RmX6dXq302bLnL9gLWDwy1.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_M6IvbjpiNjyOrpNvLqSL8K_5, Is_Down_Out: out bool Is_Down_31);
            var Output_35 = this.__p_VZNUvULbYLsQbLQDbBAvRd.Update(Value_In: Is_Down_31, Up_Edge_Out: out bool Up_Edge_33, Down_Edge_Out: out bool Down_Edge_34);
            float Input_2_36 = n2.Convert.ToSingle(Up_Edge_33);
            var Output_37 = Output_30 + Input_2_36;
            var Output_39 = this.__p_UCYVS6PuVXbPXjRHV1qWVw.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_NpSXUqlTpXXL5Uw33Ly6Bf_7, Is_Down_Out: out bool Is_Down_38);
            var Output_42 = this.__p_LroDatgevllNKDVS6W3sHa.Update(Value_In: Is_Down_38, Up_Edge_Out: out bool Up_Edge_40, Down_Edge_Out: out bool Down_Edge_41);
            float Input_43 = n2.Convert.ToSingle(Up_Edge_40);
            var Output_44 = Input_43 * __pad_MEI14jl7889PI4AyOpTHrf_8;
            var Output_46 = this.__p_Syv3rN4JtHENFBMyUo2QJ3.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_A7JpJ8gkdPSNSUMvonj82G_6, Is_Down_Out: out bool Is_Down_45);
            var Output_49 = this.__p_OWjoALxKOoFQZrrGxy2Fxb.Update(Value_In: Is_Down_45, Up_Edge_Out: out bool Up_Edge_47, Down_Edge_Out: out bool Down_Edge_48);
            float Input_2_50 = n2.Convert.ToSingle(Up_Edge_47);
            var Output_51 = Output_44 + Input_2_50;
            var Output_53 = this.__p_KXAvGhfty2JMox9LdRcsBA.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_Q5PDgPFzSXcMSgQfcI5EFV_10, Is_Down_Out: out bool Is_Down_52);
            var Output_56 = this.__p_LLjau5m0qObMO7wKbXXdhi.Update(Value_In: Is_Down_52, Up_Edge_Out: out bool Up_Edge_54, Down_Edge_Out: out bool Down_Edge_55);
            float Input_57 = n2.Convert.ToSingle(Up_Edge_54);
            var Output_58 = Input_57 * __pad_MEI14jl7889PI4AyOpTHrf_8;
            var Output_60 = this.__p_IogDBujldPiP6MOUytcd1v.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_BDjhtpoAcf0OfK1pGkU3wS_9, Is_Down_Out: out bool Is_Down_59);
            var Output_63 = this.__p_IOksqk0QatyOiGfvzFV1CP.Update(Value_In: Is_Down_59, Up_Edge_Out: out bool Up_Edge_61, Down_Edge_Out: out bool Down_Edge_62);
            float Input_2_64 = n2.Convert.ToSingle(Up_Edge_61);
            var Output_65 = Output_58 + Input_2_64;
            var Output_66 = new n3.Vector3(x: Output_37, y: Output_51, z: Output_65);
            var Output_68 = this.__p_F9rSqye8DEBNBIqHDr1BJt.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_KZvg7DzMd8VOycNLnyBFw4_2, Is_Down_Out: out bool Is_Down_67);
            var Output_70 = this.__p_RqSXQTw9YPILpLnlIplntT.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_L37pnd5fr3VNXkeCK8q5ll_4, Is_Down_Out: out bool Is_Down_69);
            var Output_73 = this.__p_SPmDGHNirbuMGjNeqq9M7k.Update(Value_In: Is_Down_69, Up_Edge_Out: out bool Up_Edge_71, Down_Edge_Out: out bool Down_Edge_72);
            var Output_75 = this.__p_Vget8jbr5QQMEzcOAKwy7g.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_PEIvZsb7TchPQIRgzn2lO6_3, Is_Down_Out: out bool Is_Down_74);
            var Output_76 = Is_Down_67 && Is_Down_74;
            var Output_77 = !Is_Down_67;
            var Output_78 = Output_77 && Is_Down_74;
            var Output_79 = Up_Edge_26 || Up_Edge_33;
            var Output_80 = Output_79 || Up_Edge_47;
            var Output_81 = Output_80 || Up_Edge_40;
            var Output_82 = Output_81 || Up_Edge_61;
            var Output_83 = Output_82 || Up_Edge_54;
            var Output_84 = __auto_0;
            if (Enable_In)
            {
                Output_84 = __auto_0.Join(Mouse_Position_In: Position_In_Projection_12, Nudge_Offset_In: Output_66, Left_Button_Pressed_In: Left_Pressed_14, Uniform_Scaling_In: Is_Down_67, Mode_Selection_Pressed_In: Up_Edge_71, Small_Rotation_Step_In: Is_Down_67, Smaller_Rotation_Step_In: Output_76, Big_Rotation_Step_In: Output_78, Nudge_In: Output_83);
            }

            n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> __auto_85 = Output_84;
            Gizmo_Controls_Out = Output_84;
            n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 that_86 = this;
            if (this.__GetContext__().IsImmutable)
                that_86 = Output_21 != this.__p_Iibogj8YyDkM2vgSJaggsZ || Output_23 != this.__p_FmDhCqW2dFsNv9WzvKxmHe || Output_25 != this.__p_CwsQ1o8k0O5NemqWxQWIXB || Output_28 != this.__p_Eag0kYY6Y2qMSYUu4lSp6f || Output_32 != this.__p_RmX6dXq302bLnL9gLWDwy1 || Output_35 != this.__p_VZNUvULbYLsQbLQDbBAvRd || Output_39 != this.__p_UCYVS6PuVXbPXjRHV1qWVw || Output_42 != this.__p_LroDatgevllNKDVS6W3sHa || Output_46 != this.__p_Syv3rN4JtHENFBMyUo2QJ3 || Output_49 != this.__p_OWjoALxKOoFQZrrGxy2Fxb || Output_53 != this.__p_KXAvGhfty2JMox9LdRcsBA || Output_56 != this.__p_LLjau5m0qObMO7wKbXXdhi || Output_60 != this.__p_IogDBujldPiP6MOUytcd1v || Output_63 != this.__p_IOksqk0QatyOiGfvzFV1CP || Output_68 != this.__p_F9rSqye8DEBNBIqHDr1BJt || Output_70 != this.__p_RqSXQTw9YPILpLnlIplntT || Output_73 != this.__p_SPmDGHNirbuMGjNeqq9M7k || Output_75 != this.__p_Vget8jbr5QQMEzcOAKwy7g || Output_84 != this.Controls ? new GizmoControls_FwMKMU2m58nOMS2ThuJF65(this)
                {__p_Iibogj8YyDkM2vgSJaggsZ = Output_21, __p_FmDhCqW2dFsNv9WzvKxmHe = Output_23, __p_CwsQ1o8k0O5NemqWxQWIXB = Output_25, __p_Eag0kYY6Y2qMSYUu4lSp6f = Output_28, __p_RmX6dXq302bLnL9gLWDwy1 = Output_32, __p_VZNUvULbYLsQbLQDbBAvRd = Output_35, __p_UCYVS6PuVXbPXjRHV1qWVw = Output_39, __p_LroDatgevllNKDVS6W3sHa = Output_42, __p_Syv3rN4JtHENFBMyUo2QJ3 = Output_46, __p_OWjoALxKOoFQZrrGxy2Fxb = Output_49, __p_KXAvGhfty2JMox9LdRcsBA = Output_53, __p_LLjau5m0qObMO7wKbXXdhi = Output_56, __p_IogDBujldPiP6MOUytcd1v = Output_60, __p_IOksqk0QatyOiGfvzFV1CP = Output_63, __p_F9rSqye8DEBNBIqHDr1BJt = Output_68, __p_RqSXQTw9YPILpLnlIplntT = Output_70, __p_SPmDGHNirbuMGjNeqq9M7k = Output_73, __p_Vget8jbr5QQMEzcOAKwy7g = Output_75, Controls = Output_84} : that_86;
            else
            {
                this.__p_Iibogj8YyDkM2vgSJaggsZ = Output_21;
                this.__p_FmDhCqW2dFsNv9WzvKxmHe = Output_23;
                this.__p_CwsQ1o8k0O5NemqWxQWIXB = Output_25;
                this.__p_Eag0kYY6Y2qMSYUu4lSp6f = Output_28;
                this.__p_RmX6dXq302bLnL9gLWDwy1 = Output_32;
                this.__p_VZNUvULbYLsQbLQDbBAvRd = Output_35;
                this.__p_UCYVS6PuVXbPXjRHV1qWVw = Output_39;
                this.__p_LroDatgevllNKDVS6W3sHa = Output_42;
                this.__p_Syv3rN4JtHENFBMyUo2QJ3 = Output_46;
                this.__p_OWjoALxKOoFQZrrGxy2Fxb = Output_49;
                this.__p_KXAvGhfty2JMox9LdRcsBA = Output_53;
                this.__p_LLjau5m0qObMO7wKbXXdhi = Output_56;
                this.__p_IogDBujldPiP6MOUytcd1v = Output_60;
                this.__p_IOksqk0QatyOiGfvzFV1CP = Output_63;
                this.__p_F9rSqye8DEBNBIqHDr1BJt = Output_68;
                this.__p_RqSXQTw9YPILpLnlIplntT = Output_70;
                this.__p_SPmDGHNirbuMGjNeqq9M7k = Output_73;
                this.__p_Vget8jbr5QQMEzcOAKwy7g = Output_75;
                this.Controls = Output_84;
            }

            return that_86;
        }

        public n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "F9rSqye8DEBNBIqHDr1BJt", 99525U);
            var Output_1 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RqSXQTw9YPILpLnlIplntT", 99530U);
            var Output_3 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Iibogj8YyDkM2vgSJaggsZ", 99541U);
            var Output_5 = n44.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "FmDhCqW2dFsNv9WzvKxmHe", 99583U);
            var Output_7 = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "SPmDGHNirbuMGjNeqq9M7k", 99590U);
            var Output_9 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CwsQ1o8k0O5NemqWxQWIXB", 99617U);
            var Output_11 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RmX6dXq302bLnL9gLWDwy1", 99624U);
            var Output_13 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Syv3rN4JtHENFBMyUo2QJ3", 99634U);
            var Output_15 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "UCYVS6PuVXbPXjRHV1qWVw", 99645U);
            var Output_17 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Eag0kYY6Y2qMSYUu4lSp6f", 99684U);
            var Output_19 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "VZNUvULbYLsQbLQDbBAvRd", 99690U);
            var Output_21 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "OWjoALxKOoFQZrrGxy2Fxb", 99699U);
            var Output_23 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LroDatgevllNKDVS6W3sHa", 99706U);
            var Output_25 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IogDBujldPiP6MOUytcd1v", 99741U);
            var Output_27 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "KXAvGhfty2JMox9LdRcsBA", 99749U);
            var Output_29 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IOksqk0QatyOiGfvzFV1CP", 99771U);
            var Output_31 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LLjau5m0qObMO7wKbXXdhi", 99780U);
            var Output_33 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_32);
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Vget8jbr5QQMEzcOAKwy7g", 99787U);
            var Output_35 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_34);
            n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 that_36 = this;
            this.Controls = n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_F9rSqye8DEBNBIqHDr1BJt = Output_1;
            this.__p_RqSXQTw9YPILpLnlIplntT = Output_3;
            this.__p_Iibogj8YyDkM2vgSJaggsZ = Output_5;
            this.__p_FmDhCqW2dFsNv9WzvKxmHe = Output_7;
            this.__p_SPmDGHNirbuMGjNeqq9M7k = Output_9;
            this.__p_CwsQ1o8k0O5NemqWxQWIXB = Output_11;
            this.__p_RmX6dXq302bLnL9gLWDwy1 = Output_13;
            this.__p_Syv3rN4JtHENFBMyUo2QJ3 = Output_15;
            this.__p_UCYVS6PuVXbPXjRHV1qWVw = Output_17;
            this.__p_Eag0kYY6Y2qMSYUu4lSp6f = Output_19;
            this.__p_VZNUvULbYLsQbLQDbBAvRd = Output_21;
            this.__p_OWjoALxKOoFQZrrGxy2Fxb = Output_23;
            this.__p_LroDatgevllNKDVS6W3sHa = Output_25;
            this.__p_IogDBujldPiP6MOUytcd1v = Output_27;
            this.__p_KXAvGhfty2JMox9LdRcsBA = Output_29;
            this.__p_IOksqk0QatyOiGfvzFV1CP = Output_31;
            this.__p_LLjau5m0qObMO7wKbXXdhi = Output_33;
            this.__p_Vget8jbr5QQMEzcOAKwy7g = Output_35;
            return that_36;
        }

        public n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 __CreateDefault__()
        {
            n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 that_0 = this;
            this.Controls = n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_Iibogj8YyDkM2vgSJaggsZ = n44.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_FmDhCqW2dFsNv9WzvKxmHe = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_CwsQ1o8k0O5NemqWxQWIXB = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Eag0kYY6Y2qMSYUu4lSp6f = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_RmX6dXq302bLnL9gLWDwy1 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_VZNUvULbYLsQbLQDbBAvRd = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_UCYVS6PuVXbPXjRHV1qWVw = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LroDatgevllNKDVS6W3sHa = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_Syv3rN4JtHENFBMyUo2QJ3 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_OWjoALxKOoFQZrrGxy2Fxb = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_KXAvGhfty2JMox9LdRcsBA = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LLjau5m0qObMO7wKbXXdhi = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_IogDBujldPiP6MOUytcd1v = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_IOksqk0QatyOiGfvzFV1CP = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_F9rSqye8DEBNBIqHDr1BJt = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_RqSXQTw9YPILpLnlIplntT = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_SPmDGHNirbuMGjNeqq9M7k = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_Vget8jbr5QQMEzcOAKwy7g = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Iibogj8YyDkM2vgSJaggsZ);
            n1.CompilationHelper.SafeDispose(this.__p_FmDhCqW2dFsNv9WzvKxmHe);
            n1.CompilationHelper.SafeDispose(this.__p_CwsQ1o8k0O5NemqWxQWIXB);
            n1.CompilationHelper.SafeDispose(this.__p_Eag0kYY6Y2qMSYUu4lSp6f);
            n1.CompilationHelper.SafeDispose(this.__p_RmX6dXq302bLnL9gLWDwy1);
            n1.CompilationHelper.SafeDispose(this.__p_VZNUvULbYLsQbLQDbBAvRd);
            n1.CompilationHelper.SafeDispose(this.__p_UCYVS6PuVXbPXjRHV1qWVw);
            n1.CompilationHelper.SafeDispose(this.__p_LroDatgevllNKDVS6W3sHa);
            n1.CompilationHelper.SafeDispose(this.__p_Syv3rN4JtHENFBMyUo2QJ3);
            n1.CompilationHelper.SafeDispose(this.__p_OWjoALxKOoFQZrrGxy2Fxb);
            n1.CompilationHelper.SafeDispose(this.__p_KXAvGhfty2JMox9LdRcsBA);
            n1.CompilationHelper.SafeDispose(this.__p_LLjau5m0qObMO7wKbXXdhi);
            n1.CompilationHelper.SafeDispose(this.__p_IogDBujldPiP6MOUytcd1v);
            n1.CompilationHelper.SafeDispose(this.__p_IOksqk0QatyOiGfvzFV1CP);
            n1.CompilationHelper.SafeDispose(this.__p_F9rSqye8DEBNBIqHDr1BJt);
            n1.CompilationHelper.SafeDispose(this.__p_RqSXQTw9YPILpLnlIplntT);
            n1.CompilationHelper.SafeDispose(this.__p_SPmDGHNirbuMGjNeqq9M7k);
            n1.CompilationHelper.SafeDispose(this.__p_Vget8jbr5QQMEzcOAKwy7g);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 99529U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KZvg7DzMd8VOycNLnyBFw4", Name = "__slot_KZvg7DzMd8VOycNLnyBFw4")]
        public static string __slot_KZvg7DzMd8VOycNLnyBFw4 = "ShiftKey";
        [n1.ElementAttribute(TracingId = 99538U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "L37pnd5fr3VNXkeCK8q5ll", Name = "__slot_L37pnd5fr3VNXkeCK8q5ll")]
        public static string __slot_L37pnd5fr3VNXkeCK8q5ll = "G";
        [n1.ElementAttribute(TracingId = 99602U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F3SqyWDC3StL8zL7VrnDGq", Name = "__slot_F3SqyWDC3StL8zL7VrnDGq")]
        public static string __slot_F3SqyWDC3StL8zL7VrnDGq = "Left";
        [n1.ElementAttribute(TracingId = 99606U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "M6IvbjpiNjyOrpNvLqSL8K", Name = "__slot_M6IvbjpiNjyOrpNvLqSL8K")]
        public static string __slot_M6IvbjpiNjyOrpNvLqSL8K = "Right";
        [n1.ElementAttribute(TracingId = 99607U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "A7JpJ8gkdPSNSUMvonj82G", Name = "__slot_A7JpJ8gkdPSNSUMvonj82G")]
        public static string __slot_A7JpJ8gkdPSNSUMvonj82G = "Up";
        [n1.ElementAttribute(TracingId = 99612U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NpSXUqlTpXXL5Uw33Ly6Bf", Name = "__slot_NpSXUqlTpXXL5Uw33Ly6Bf")]
        public static string __slot_NpSXUqlTpXXL5Uw33Ly6Bf = "Down";
        [n1.ElementAttribute(TracingId = 99615U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MEI14jl7889PI4AyOpTHrf", Name = "__slot_MEI14jl7889PI4AyOpTHrf")]
        public static float __slot_MEI14jl7889PI4AyOpTHrf = -1F;
        [n1.ElementAttribute(TracingId = 99731U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BDjhtpoAcf0OfK1pGkU3wS", Name = "__slot_BDjhtpoAcf0OfK1pGkU3wS")]
        public static string __slot_BDjhtpoAcf0OfK1pGkU3wS = "PageUp";
        [n1.ElementAttribute(TracingId = 99737U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Q5PDgPFzSXcMSgQfcI5EFV", Name = "__slot_Q5PDgPFzSXcMSgQfcI5EFV")]
        public static string __slot_Q5PDgPFzSXcMSgQfcI5EFV = "PageDown";
        [n1.ElementAttribute(TracingId = 99796U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PEIvZsb7TchPQIRgzn2lO6", Name = "__slot_PEIvZsb7TchPQIRgzn2lO6")]
        public static string __slot_PEIvZsb7TchPQIRgzn2lO6 = "ControlKey";
        [n1.ElementAttribute(TracingId = 99599U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FKDIYHQBMUkQUW6O1bRreJ", Name = "Controls")]
        public n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Controls;
        [n1.ElementAttribute(TracingId = 99541U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Iibogj8YyDkM2vgSJaggsZ", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n44.MouseState_BNOhaxXysw1MZBzyJMI18t __p_Iibogj8YyDkM2vgSJaggsZ;
        [n1.ElementAttribute(TracingId = 99583U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FmDhCqW2dFsNv9WzvKxmHe", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_FmDhCqW2dFsNv9WzvKxmHe;
        [n1.ElementAttribute(TracingId = 99617U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CwsQ1o8k0O5NemqWxQWIXB", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CwsQ1o8k0O5NemqWxQWIXB;
        [n1.ElementAttribute(TracingId = 99684U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Eag0kYY6Y2qMSYUu4lSp6f", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Eag0kYY6Y2qMSYUu4lSp6f;
        [n1.ElementAttribute(TracingId = 99624U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RmX6dXq302bLnL9gLWDwy1", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RmX6dXq302bLnL9gLWDwy1;
        [n1.ElementAttribute(TracingId = 99690U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VZNUvULbYLsQbLQDbBAvRd", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VZNUvULbYLsQbLQDbBAvRd;
        [n1.ElementAttribute(TracingId = 99645U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UCYVS6PuVXbPXjRHV1qWVw", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UCYVS6PuVXbPXjRHV1qWVw;
        [n1.ElementAttribute(TracingId = 99706U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LroDatgevllNKDVS6W3sHa", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LroDatgevllNKDVS6W3sHa;
        [n1.ElementAttribute(TracingId = 99634U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Syv3rN4JtHENFBMyUo2QJ3", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Syv3rN4JtHENFBMyUo2QJ3;
        [n1.ElementAttribute(TracingId = 99699U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OWjoALxKOoFQZrrGxy2Fxb", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OWjoALxKOoFQZrrGxy2Fxb;
        [n1.ElementAttribute(TracingId = 99749U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KXAvGhfty2JMox9LdRcsBA", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_KXAvGhfty2JMox9LdRcsBA;
        [n1.ElementAttribute(TracingId = 99780U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LLjau5m0qObMO7wKbXXdhi", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LLjau5m0qObMO7wKbXXdhi;
        [n1.ElementAttribute(TracingId = 99741U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IogDBujldPiP6MOUytcd1v", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_IogDBujldPiP6MOUytcd1v;
        [n1.ElementAttribute(TracingId = 99771U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IOksqk0QatyOiGfvzFV1CP", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_IOksqk0QatyOiGfvzFV1CP;
        [n1.ElementAttribute(TracingId = 99525U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F9rSqye8DEBNBIqHDr1BJt", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_F9rSqye8DEBNBIqHDr1BJt;
        [n1.ElementAttribute(TracingId = 99530U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RqSXQTw9YPILpLnlIplntT", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RqSXQTw9YPILpLnlIplntT;
        [n1.ElementAttribute(TracingId = 99590U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SPmDGHNirbuMGjNeqq9M7k", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SPmDGHNirbuMGjNeqq9M7k;
        [n1.ElementAttribute(TracingId = 99787U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Vget8jbr5QQMEzcOAKwy7g", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Vget8jbr5QQMEzcOAKwy7g;
        static GizmoControls_FwMKMU2m58nOMS2ThuJF65()
        {
        }

        public GizmoControls_FwMKMU2m58nOMS2ThuJF65(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoControls_FwMKMU2m58nOMS2ThuJF65(GizmoControls_FwMKMU2m58nOMS2ThuJF65 other): base(other)
        {
            this.Controls = other.Controls;
            this.__p_Iibogj8YyDkM2vgSJaggsZ = other.__p_Iibogj8YyDkM2vgSJaggsZ;
            this.__p_FmDhCqW2dFsNv9WzvKxmHe = other.__p_FmDhCqW2dFsNv9WzvKxmHe;
            this.__p_CwsQ1o8k0O5NemqWxQWIXB = other.__p_CwsQ1o8k0O5NemqWxQWIXB;
            this.__p_Eag0kYY6Y2qMSYUu4lSp6f = other.__p_Eag0kYY6Y2qMSYUu4lSp6f;
            this.__p_RmX6dXq302bLnL9gLWDwy1 = other.__p_RmX6dXq302bLnL9gLWDwy1;
            this.__p_VZNUvULbYLsQbLQDbBAvRd = other.__p_VZNUvULbYLsQbLQDbBAvRd;
            this.__p_UCYVS6PuVXbPXjRHV1qWVw = other.__p_UCYVS6PuVXbPXjRHV1qWVw;
            this.__p_LroDatgevllNKDVS6W3sHa = other.__p_LroDatgevllNKDVS6W3sHa;
            this.__p_Syv3rN4JtHENFBMyUo2QJ3 = other.__p_Syv3rN4JtHENFBMyUo2QJ3;
            this.__p_OWjoALxKOoFQZrrGxy2Fxb = other.__p_OWjoALxKOoFQZrrGxy2Fxb;
            this.__p_KXAvGhfty2JMox9LdRcsBA = other.__p_KXAvGhfty2JMox9LdRcsBA;
            this.__p_LLjau5m0qObMO7wKbXXdhi = other.__p_LLjau5m0qObMO7wKbXXdhi;
            this.__p_IogDBujldPiP6MOUytcd1v = other.__p_IogDBujldPiP6MOUytcd1v;
            this.__p_IOksqk0QatyOiGfvzFV1CP = other.__p_IOksqk0QatyOiGfvzFV1CP;
            this.__p_F9rSqye8DEBNBIqHDr1BJt = other.__p_F9rSqye8DEBNBIqHDr1BJt;
            this.__p_RqSXQTw9YPILpLnlIplntT = other.__p_RqSXQTw9YPILpLnlIplntT;
            this.__p_SPmDGHNirbuMGjNeqq9M7k = other.__p_SPmDGHNirbuMGjNeqq9M7k;
            this.__p_Vget8jbr5QQMEzcOAKwy7g = other.__p_Vget8jbr5QQMEzcOAKwy7g;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Controls", in Controls), n1.CompilationHelper.GetValueOrExisting(values, "__p_Iibogj8YyDkM2vgSJaggsZ", in __p_Iibogj8YyDkM2vgSJaggsZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_FmDhCqW2dFsNv9WzvKxmHe", in __p_FmDhCqW2dFsNv9WzvKxmHe), n1.CompilationHelper.GetValueOrExisting(values, "__p_CwsQ1o8k0O5NemqWxQWIXB", in __p_CwsQ1o8k0O5NemqWxQWIXB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Eag0kYY6Y2qMSYUu4lSp6f", in __p_Eag0kYY6Y2qMSYUu4lSp6f), n1.CompilationHelper.GetValueOrExisting(values, "__p_RmX6dXq302bLnL9gLWDwy1", in __p_RmX6dXq302bLnL9gLWDwy1), n1.CompilationHelper.GetValueOrExisting(values, "__p_VZNUvULbYLsQbLQDbBAvRd", in __p_VZNUvULbYLsQbLQDbBAvRd), n1.CompilationHelper.GetValueOrExisting(values, "__p_UCYVS6PuVXbPXjRHV1qWVw", in __p_UCYVS6PuVXbPXjRHV1qWVw), n1.CompilationHelper.GetValueOrExisting(values, "__p_LroDatgevllNKDVS6W3sHa", in __p_LroDatgevllNKDVS6W3sHa), n1.CompilationHelper.GetValueOrExisting(values, "__p_Syv3rN4JtHENFBMyUo2QJ3", in __p_Syv3rN4JtHENFBMyUo2QJ3), n1.CompilationHelper.GetValueOrExisting(values, "__p_OWjoALxKOoFQZrrGxy2Fxb", in __p_OWjoALxKOoFQZrrGxy2Fxb), n1.CompilationHelper.GetValueOrExisting(values, "__p_KXAvGhfty2JMox9LdRcsBA", in __p_KXAvGhfty2JMox9LdRcsBA), n1.CompilationHelper.GetValueOrExisting(values, "__p_LLjau5m0qObMO7wKbXXdhi", in __p_LLjau5m0qObMO7wKbXXdhi), n1.CompilationHelper.GetValueOrExisting(values, "__p_IogDBujldPiP6MOUytcd1v", in __p_IogDBujldPiP6MOUytcd1v), n1.CompilationHelper.GetValueOrExisting(values, "__p_IOksqk0QatyOiGfvzFV1CP", in __p_IOksqk0QatyOiGfvzFV1CP), n1.CompilationHelper.GetValueOrExisting(values, "__p_F9rSqye8DEBNBIqHDr1BJt", in __p_F9rSqye8DEBNBIqHDr1BJt), n1.CompilationHelper.GetValueOrExisting(values, "__p_RqSXQTw9YPILpLnlIplntT", in __p_RqSXQTw9YPILpLnlIplntT), n1.CompilationHelper.GetValueOrExisting(values, "__p_SPmDGHNirbuMGjNeqq9M7k", in __p_SPmDGHNirbuMGjNeqq9M7k), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vget8jbr5QQMEzcOAKwy7g", in __p_Vget8jbr5QQMEzcOAKwy7g));
        }

        internal GizmoControls_FwMKMU2m58nOMS2ThuJF65 __WITH__(n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Controls, n44.MouseState_BNOhaxXysw1MZBzyJMI18t __p_Iibogj8YyDkM2vgSJaggsZ, n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_FmDhCqW2dFsNv9WzvKxmHe, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CwsQ1o8k0O5NemqWxQWIXB, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Eag0kYY6Y2qMSYUu4lSp6f, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RmX6dXq302bLnL9gLWDwy1, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VZNUvULbYLsQbLQDbBAvRd, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UCYVS6PuVXbPXjRHV1qWVw, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LroDatgevllNKDVS6W3sHa, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Syv3rN4JtHENFBMyUo2QJ3, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OWjoALxKOoFQZrrGxy2Fxb, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_KXAvGhfty2JMox9LdRcsBA, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LLjau5m0qObMO7wKbXXdhi, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_IogDBujldPiP6MOUytcd1v, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_IOksqk0QatyOiGfvzFV1CP, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_F9rSqye8DEBNBIqHDr1BJt, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RqSXQTw9YPILpLnlIplntT, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_SPmDGHNirbuMGjNeqq9M7k, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Vget8jbr5QQMEzcOAKwy7g)
        {
            n34.GizmoControls_FwMKMU2m58nOMS2ThuJF65 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Controls != this.Controls || __p_Iibogj8YyDkM2vgSJaggsZ != this.__p_Iibogj8YyDkM2vgSJaggsZ || __p_FmDhCqW2dFsNv9WzvKxmHe != this.__p_FmDhCqW2dFsNv9WzvKxmHe || __p_CwsQ1o8k0O5NemqWxQWIXB != this.__p_CwsQ1o8k0O5NemqWxQWIXB || __p_Eag0kYY6Y2qMSYUu4lSp6f != this.__p_Eag0kYY6Y2qMSYUu4lSp6f || __p_RmX6dXq302bLnL9gLWDwy1 != this.__p_RmX6dXq302bLnL9gLWDwy1 || __p_VZNUvULbYLsQbLQDbBAvRd != this.__p_VZNUvULbYLsQbLQDbBAvRd || __p_UCYVS6PuVXbPXjRHV1qWVw != this.__p_UCYVS6PuVXbPXjRHV1qWVw || __p_LroDatgevllNKDVS6W3sHa != this.__p_LroDatgevllNKDVS6W3sHa || __p_Syv3rN4JtHENFBMyUo2QJ3 != this.__p_Syv3rN4JtHENFBMyUo2QJ3 || __p_OWjoALxKOoFQZrrGxy2Fxb != this.__p_OWjoALxKOoFQZrrGxy2Fxb || __p_KXAvGhfty2JMox9LdRcsBA != this.__p_KXAvGhfty2JMox9LdRcsBA || __p_LLjau5m0qObMO7wKbXXdhi != this.__p_LLjau5m0qObMO7wKbXXdhi || __p_IogDBujldPiP6MOUytcd1v != this.__p_IogDBujldPiP6MOUytcd1v || __p_IOksqk0QatyOiGfvzFV1CP != this.__p_IOksqk0QatyOiGfvzFV1CP || __p_F9rSqye8DEBNBIqHDr1BJt != this.__p_F9rSqye8DEBNBIqHDr1BJt || __p_RqSXQTw9YPILpLnlIplntT != this.__p_RqSXQTw9YPILpLnlIplntT || __p_SPmDGHNirbuMGjNeqq9M7k != this.__p_SPmDGHNirbuMGjNeqq9M7k || __p_Vget8jbr5QQMEzcOAKwy7g != this.__p_Vget8jbr5QQMEzcOAKwy7g ? new GizmoControls_FwMKMU2m58nOMS2ThuJF65(this)
                {Controls = Controls, __p_Iibogj8YyDkM2vgSJaggsZ = __p_Iibogj8YyDkM2vgSJaggsZ, __p_FmDhCqW2dFsNv9WzvKxmHe = __p_FmDhCqW2dFsNv9WzvKxmHe, __p_CwsQ1o8k0O5NemqWxQWIXB = __p_CwsQ1o8k0O5NemqWxQWIXB, __p_Eag0kYY6Y2qMSYUu4lSp6f = __p_Eag0kYY6Y2qMSYUu4lSp6f, __p_RmX6dXq302bLnL9gLWDwy1 = __p_RmX6dXq302bLnL9gLWDwy1, __p_VZNUvULbYLsQbLQDbBAvRd = __p_VZNUvULbYLsQbLQDbBAvRd, __p_UCYVS6PuVXbPXjRHV1qWVw = __p_UCYVS6PuVXbPXjRHV1qWVw, __p_LroDatgevllNKDVS6W3sHa = __p_LroDatgevllNKDVS6W3sHa, __p_Syv3rN4JtHENFBMyUo2QJ3 = __p_Syv3rN4JtHENFBMyUo2QJ3, __p_OWjoALxKOoFQZrrGxy2Fxb = __p_OWjoALxKOoFQZrrGxy2Fxb, __p_KXAvGhfty2JMox9LdRcsBA = __p_KXAvGhfty2JMox9LdRcsBA, __p_LLjau5m0qObMO7wKbXXdhi = __p_LLjau5m0qObMO7wKbXXdhi, __p_IogDBujldPiP6MOUytcd1v = __p_IogDBujldPiP6MOUytcd1v, __p_IOksqk0QatyOiGfvzFV1CP = __p_IOksqk0QatyOiGfvzFV1CP, __p_F9rSqye8DEBNBIqHDr1BJt = __p_F9rSqye8DEBNBIqHDr1BJt, __p_RqSXQTw9YPILpLnlIplntT = __p_RqSXQTw9YPILpLnlIplntT, __p_SPmDGHNirbuMGjNeqq9M7k = __p_SPmDGHNirbuMGjNeqq9M7k, __p_Vget8jbr5QQMEzcOAKwy7g = __p_Vget8jbr5QQMEzcOAKwy7g} : that_0;
            else
            {
                this.Controls = Controls;
                this.__p_Iibogj8YyDkM2vgSJaggsZ = __p_Iibogj8YyDkM2vgSJaggsZ;
                this.__p_FmDhCqW2dFsNv9WzvKxmHe = __p_FmDhCqW2dFsNv9WzvKxmHe;
                this.__p_CwsQ1o8k0O5NemqWxQWIXB = __p_CwsQ1o8k0O5NemqWxQWIXB;
                this.__p_Eag0kYY6Y2qMSYUu4lSp6f = __p_Eag0kYY6Y2qMSYUu4lSp6f;
                this.__p_RmX6dXq302bLnL9gLWDwy1 = __p_RmX6dXq302bLnL9gLWDwy1;
                this.__p_VZNUvULbYLsQbLQDbBAvRd = __p_VZNUvULbYLsQbLQDbBAvRd;
                this.__p_UCYVS6PuVXbPXjRHV1qWVw = __p_UCYVS6PuVXbPXjRHV1qWVw;
                this.__p_LroDatgevllNKDVS6W3sHa = __p_LroDatgevllNKDVS6W3sHa;
                this.__p_Syv3rN4JtHENFBMyUo2QJ3 = __p_Syv3rN4JtHENFBMyUo2QJ3;
                this.__p_OWjoALxKOoFQZrrGxy2Fxb = __p_OWjoALxKOoFQZrrGxy2Fxb;
                this.__p_KXAvGhfty2JMox9LdRcsBA = __p_KXAvGhfty2JMox9LdRcsBA;
                this.__p_LLjau5m0qObMO7wKbXXdhi = __p_LLjau5m0qObMO7wKbXXdhi;
                this.__p_IogDBujldPiP6MOUytcd1v = __p_IogDBujldPiP6MOUytcd1v;
                this.__p_IOksqk0QatyOiGfvzFV1CP = __p_IOksqk0QatyOiGfvzFV1CP;
                this.__p_F9rSqye8DEBNBIqHDr1BJt = __p_F9rSqye8DEBNBIqHDr1BJt;
                this.__p_RqSXQTw9YPILpLnlIplntT = __p_RqSXQTw9YPILpLnlIplntT;
                this.__p_SPmDGHNirbuMGjNeqq9M7k = __p_SPmDGHNirbuMGjNeqq9M7k;
                this.__p_Vget8jbr5QQMEzcOAKwy7g = __p_Vget8jbr5QQMEzcOAKwy7g;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 99948U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AMBdHb4W3XiNqy6YcKA3Z0", Name = "GizmoControlsState_R")]
    [n2.SerializableAttribute]
    public class GizmoControlsState_R<T4, T3, T2, T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n34.GizmoControlsState_R<T4, T3, T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T2>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new GizmoControlsState_R<T4, T3, T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n34.GizmoControlsState_R<T4, T3, T2, T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T2>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n34.GizmoControlsState_R<T4, T3, T2, T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new GizmoControlsState_R<T4, T3, T2, T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n34.GizmoControlsState_R<T4, T3, T2, T> __DEFAULT__;
        public n34.GizmoControlsState_R<T4, T3, T2, T> Update()
        {
            return this;
        }

        public n34.GizmoControlsState_R<T4, T3, T2, T> Join(n3.Vector2 Mouse_Position_In, T4 Nudge_Offset_In, bool Left_Button_Pressed_In, bool Uniform_Scaling_In, bool Mode_Selection_Pressed_In, T3 Small_Rotation_Step_In, T Smaller_Rotation_Step_In, T2 Big_Rotation_Step_In, bool Nudge_In)
        {
            n3.Vector2 __auto_0 = Mouse_Position_In;
            T4 __auto_1 = Nudge_Offset_In;
            bool __auto_2 = Left_Button_Pressed_In;
            bool __auto_3 = Uniform_Scaling_In;
            bool __auto_4 = Mode_Selection_Pressed_In;
            T3 __auto_5 = Small_Rotation_Step_In;
            T __auto_6 = Smaller_Rotation_Step_In;
            T2 __auto_7 = Big_Rotation_Step_In;
            bool __auto_8 = Nudge_In;
            n34.GizmoControlsState_R<T4, T3, T2, T> that_9 = this;
            that_9 = Mouse_Position_In != this.Mouse_Position || !n23.EqualityComparer<T4>.Default.Equals(Nudge_Offset_In, this.Nudge_Offset) || Left_Button_Pressed_In != this.Left_Button_Pressed || Uniform_Scaling_In != this.Uniform_Scaling || Mode_Selection_Pressed_In != this.Mode_Selection_Pressed || !n23.EqualityComparer<T3>.Default.Equals(Small_Rotation_Step_In, this.Small_Rotation_Step) || !n23.EqualityComparer<T>.Default.Equals(Smaller_Rotation_Step_In, this.Smaller_Rotation_Step) || !n23.EqualityComparer<T2>.Default.Equals(Big_Rotation_Step_In, this.Big_Rotation_Step) || Nudge_In != this.Nudge ? new GizmoControlsState_R<T4, T3, T2, T>(this)
            {Mouse_Position = Mouse_Position_In, Nudge_Offset = Nudge_Offset_In, Left_Button_Pressed = Left_Button_Pressed_In, Uniform_Scaling = Uniform_Scaling_In, Mode_Selection_Pressed = Mode_Selection_Pressed_In, Small_Rotation_Step = Small_Rotation_Step_In, Smaller_Rotation_Step = Smaller_Rotation_Step_In, Big_Rotation_Step = Big_Rotation_Step_In, Nudge = Nudge_In} : that_9;
            return that_9;
        }

        public n34.GizmoControlsState_R<T4, T3, T2, T> Split(out n3.Vector2 Mouse_Position_Out, out T4 Nudge_Offset_Out, out bool Left_Button_Pressed_Out, out bool Uniform_Scaling_Out, out bool Mode_Selection_Pressed_Out, out T3 Small_Rotation_Step_Out, out T Smaller_Rotation_Step_Out, out T2 Big_Rotation_Step_Out, out bool Nudge_Out)
        {
            n3.Vector2 __auto_0 = this.Mouse_Position;
            T4 __auto_1 = this.Nudge_Offset;
            bool __auto_2 = this.Left_Button_Pressed;
            bool __auto_3 = this.Uniform_Scaling;
            bool __auto_4 = this.Mode_Selection_Pressed;
            T3 __auto_5 = this.Small_Rotation_Step;
            T __auto_6 = this.Smaller_Rotation_Step;
            T2 __auto_7 = this.Big_Rotation_Step;
            bool __auto_8 = this.Nudge;
            Mouse_Position_Out = __auto_0;
            Nudge_Offset_Out = __auto_1;
            Left_Button_Pressed_Out = __auto_2;
            Uniform_Scaling_Out = __auto_3;
            Mode_Selection_Pressed_Out = __auto_4;
            Small_Rotation_Step_Out = __auto_5;
            Smaller_Rotation_Step_Out = __auto_6;
            Big_Rotation_Step_Out = __auto_7;
            Nudge_Out = __auto_8;
            return this;
        }

        public n34.GizmoControlsState_R<T4, T3, T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T2>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T4 __out_0);
            w_0.CreateDefault(out T3 __out_1);
            w_0.CreateDefault(out T2 __out_2);
            w_0.CreateDefault(out T __out_3);
            n34.GizmoControlsState_R<T4, T3, T2, T> that_1 = this;
            this.Mouse_Position = n48._Operations_.CreateDefault();
            this.Left_Button_Pressed = false;
            this.Mode_Selection_Pressed = false;
            this.Uniform_Scaling = false;
            this.Nudge = false;
            this.Nudge_Offset = __out_0;
            this.Small_Rotation_Step = __out_1;
            this.Big_Rotation_Step = __out_2;
            this.Smaller_Rotation_Step = __out_3;
            return that_1;
        }

        public n34.GizmoControlsState_R<T4, T3, T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T4 __out_4);
            w_0.CreateDefault(out T3 __out_5);
            w_0.CreateDefault(out T2 __out_6);
            w_0.CreateDefault(out T __out_7);
            n34.GizmoControlsState_R<T4, T3, T2, T> that_1 = this;
            this.Mouse_Position = n48._Operations_.CreateDefault();
            this.Left_Button_Pressed = false;
            this.Mode_Selection_Pressed = false;
            this.Uniform_Scaling = false;
            this.Nudge = false;
            this.Nudge_Offset = __out_4;
            this.Small_Rotation_Step = __out_5;
            this.Big_Rotation_Step = __out_6;
            this.Smaller_Rotation_Step = __out_7;
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

        [n1.ElementAttribute(TracingId = 99955U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FUi6i6bKCjfPBTYBaNVGPg", Name = "Mouse Position")]
        public n3.Vector2 Mouse_Position;
        [n1.ElementAttribute(TracingId = 99958U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "O9Ubx4Z9fF1MysLaD01Bad", Name = "Left Button Pressed")]
        public bool Left_Button_Pressed;
        [n1.ElementAttribute(TracingId = 99961U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LpLQjJvghuVLW5uUFLxxSm", Name = "Mode Selection Pressed")]
        public bool Mode_Selection_Pressed;
        [n1.ElementAttribute(TracingId = 99972U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EQVWhuKykVVNOVEQAHAWdM", Name = "Uniform Scaling")]
        public bool Uniform_Scaling;
        [n1.ElementAttribute(TracingId = 99979U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Aly62eV3kmtOuSC0thT54J", Name = "Nudge")]
        public bool Nudge;
        [n1.ElementAttribute(TracingId = 99984U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GgrzTLqXLNvLIlRFrC30ri", Name = "Nudge Offset")]
        public T4 Nudge_Offset;
        [n1.ElementAttribute(TracingId = 99988U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I7zqHnhYZbkLzetLXVW85N", Name = "Small Rotation Step")]
        public T3 Small_Rotation_Step;
        [n1.ElementAttribute(TracingId = 99996U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JK9veAlkHxeO8hIAUKYavD", Name = "Big Rotation Step")]
        public T2 Big_Rotation_Step;
        [n1.ElementAttribute(TracingId = 100001U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TFhj6oLNU8gNElG9CzgAbS", Name = "Smaller Rotation Step")]
        public T Smaller_Rotation_Step;
        public GizmoControlsState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoControlsState_R(GizmoControlsState_R<T4, T3, T2, T> other): base(other)
        {
            this.Mouse_Position = other.Mouse_Position;
            this.Left_Button_Pressed = other.Left_Button_Pressed;
            this.Mode_Selection_Pressed = other.Mode_Selection_Pressed;
            this.Uniform_Scaling = other.Uniform_Scaling;
            this.Nudge = other.Nudge;
            this.Nudge_Offset = other.Nudge_Offset;
            this.Small_Rotation_Step = other.Small_Rotation_Step;
            this.Big_Rotation_Step = other.Big_Rotation_Step;
            this.Smaller_Rotation_Step = other.Smaller_Rotation_Step;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Mouse_Position", in Mouse_Position), n1.CompilationHelper.GetValueOrExisting(values, "Left_Button_Pressed", in Left_Button_Pressed), n1.CompilationHelper.GetValueOrExisting(values, "Mode_Selection_Pressed", in Mode_Selection_Pressed), n1.CompilationHelper.GetValueOrExisting(values, "Uniform_Scaling", in Uniform_Scaling), n1.CompilationHelper.GetValueOrExisting(values, "Nudge", in Nudge), n1.CompilationHelper.GetValueOrExisting(values, "Nudge_Offset", in Nudge_Offset), n1.CompilationHelper.GetValueOrExisting(values, "Small_Rotation_Step", in Small_Rotation_Step), n1.CompilationHelper.GetValueOrExisting(values, "Big_Rotation_Step", in Big_Rotation_Step), n1.CompilationHelper.GetValueOrExisting(values, "Smaller_Rotation_Step", in Smaller_Rotation_Step));
        }

        internal GizmoControlsState_R<T4, T3, T2, T> __WITH__(n3.Vector2 Mouse_Position, bool Left_Button_Pressed, bool Mode_Selection_Pressed, bool Uniform_Scaling, bool Nudge, T4 Nudge_Offset, T3 Small_Rotation_Step, T2 Big_Rotation_Step, T Smaller_Rotation_Step)
        {
            n34.GizmoControlsState_R<T4, T3, T2, T> that_0 = this;
            that_0 = Mouse_Position != this.Mouse_Position || Left_Button_Pressed != this.Left_Button_Pressed || Mode_Selection_Pressed != this.Mode_Selection_Pressed || Uniform_Scaling != this.Uniform_Scaling || Nudge != this.Nudge || !n23.EqualityComparer<T4>.Default.Equals(Nudge_Offset, this.Nudge_Offset) || !n23.EqualityComparer<T3>.Default.Equals(Small_Rotation_Step, this.Small_Rotation_Step) || !n23.EqualityComparer<T2>.Default.Equals(Big_Rotation_Step, this.Big_Rotation_Step) || !n23.EqualityComparer<T>.Default.Equals(Smaller_Rotation_Step, this.Smaller_Rotation_Step) ? new GizmoControlsState_R<T4, T3, T2, T>(this)
            {Mouse_Position = Mouse_Position, Left_Button_Pressed = Left_Button_Pressed, Mode_Selection_Pressed = Mode_Selection_Pressed, Uniform_Scaling = Uniform_Scaling, Nudge = Nudge, Nudge_Offset = Nudge_Offset, Small_Rotation_Step = Small_Rotation_Step, Big_Rotation_Step = Big_Rotation_Step, Smaller_Rotation_Step = Smaller_Rotation_Step} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 100103U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VCf0qns0epcMnUFCEx67yz", Name = "Gizmo_VCf0qns0epcMnUFCEx67yz")]
    [n2.SerializableAttribute]
    public class Gizmo_VCf0qns0epcMnUFCEx67yz : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n34.Gizmo_VCf0qns0epcMnUFCEx67yz Create(n1.NodeContext Node_Context)
        {
            var instance = new Gizmo_VCf0qns0epcMnUFCEx67yz(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n34.Gizmo_VCf0qns0epcMnUFCEx67yz CreateDefault()
        {
            var instance = new Gizmo_VCf0qns0epcMnUFCEx67yz(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n34.Gizmo_VCf0qns0epcMnUFCEx67yz Update([n6.SerializedDefaultValueAttribute("1", false)] float Gizmo_Size_In, float Pick_Size_In, n3.Vector3 Position_In, bool Position_Changed_In, int Active_Plane_In, int Number_of_Points_In, n34.GizmoControlsState_R<n3.Vector3, bool, bool, bool> Gizmo_Controls_In, [n6.SerializedDefaultValueAttribute("1", false)] float Step_Size_In, n3.Matrix View_Projection_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Camera_Idle_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Default_Visibility_In, bool Enabled_In, out n34.GizmoState_R GizmoState_Out, out n3.Vector3 Translate_Offset_Out, out n3.Vector3 Scale_Offset_Out, out n3.Vector3 Rotate_Offset_Out, out n3.Vector3 Total_Offset_Out, out bool Translation_Active_Out, out bool Scale_Active_Out, out bool Rotation_Active_Out, out n3.Vector3 Active_Axis_Out, out bool Idle_Out)
        {
            int __pad_Oeq2uiiJZkSPgLj7BXbtLr_0 = __slot_Oeq2uiiJZkSPgLj7BXbtLr;
            bool __auto_1 = this.Editing;
            var Output_4 = this.__p_NIrHeqn3PCaO6pPtBk2eRo.Update(Value_In: Gizmo_Size_In, Result_Out: out bool Result_2, Unchanged_Out: out bool Unchanged_3);
            var Output_7 = this.__p_PpL6WAg0dQOMpAucGnUJk3.Update(Value_In: Pick_Size_In, Result_Out: out bool Result_5, Unchanged_Out: out bool Unchanged_6);
            var Output_10 = this.__p_RNfenOiZQPOP6bMgYUjfno.Update(Value_In: Position_In, Result_Out: out bool Result_8, Unchanged_Out: out bool Unchanged_9);
            var Output_11 = Result_2 || Result_5;
            var Output_12 = Output_11 || Result_8;
            var Output_13 = this.__p_GfTMsHcCCagLR8OXsanPqs;
            if (Output_12)
            {
                Output_13 = this.__p_GfTMsHcCCagLR8OXsanPqs.Init(Gizmo_Size_In: Gizmo_Size_In, Pick_Size_In: Pick_Size_In, Position_In: Position_In);
            }

            var Output_23 = Gizmo_Controls_In.Split(Mouse_Position_Out: out n3.Vector2 Mouse_Position_14, Nudge_Offset_Out: out n3.Vector3 Nudge_Offset_15, Left_Button_Pressed_Out: out bool Left_Button_Pressed_16, Uniform_Scaling_Out: out bool Uniform_Scaling_17, Mode_Selection_Pressed_Out: out bool Mode_Selection_Pressed_18, Small_Rotation_Step_Out: out bool Small_Rotation_Step_19, Smaller_Rotation_Step_Out: out bool Smaller_Rotation_Step_20, Big_Rotation_Step_Out: out bool Big_Rotation_Step_21, Nudge_Out: out bool Nudge_22);
            var Output_24 = this.__p_LRpjAKLQkNpP03rpISzfQa;
            if (Mode_Selection_Pressed_18)
            {
                Output_24 = this.__p_LRpjAKLQkNpP03rpISzfQa.Flip();
            }

            var Output_26 = Output_24.GetValue(Value_Out: out bool Value_25);
            var Output_27 = Value_25;
            if (Default_Visibility_In)
            {
                var Output_28 = !Value_25;
                Output_27 = Output_28;
            }

            n38._Operations_.ActiveComponentsController(Number_of_Points_In: Number_of_Points_In, Visible_In: Output_27, Output_Out: out int Output_29, Visible_Out: out bool Visible_30);
            bool SetEnabledComponents_31 = true;
            var Output_32 = Output_13;
            if (SetEnabledComponents_31)
            {
                Output_32 = Output_13.SetEnabledComponents(Active_Component_Index_In: Output_29);
            }

            bool SetActivePlane_33 = true;
            var Output_34 = Output_32;
            if (SetActivePlane_33)
            {
                Output_34 = Output_32.SetActivePlane(Active_Plane_In: Active_Plane_In);
            }

            var Output_37 = this.__p_CSKgIdQVlILLhyyqHUJn9e.Update(Value_In: Left_Button_Pressed_16, Up_Edge_Out: out bool Up_Edge_35, Down_Edge_Out: out bool Down_Edge_36);
            var Output_38 = Output_12 || Position_Changed_In;
            var Output_39 = Output_38 || Down_Edge_36;
            var Output_40 = Output_34;
            if (Output_39)
            {
                Output_40 = Output_34.Translate();
            }

            n50._Operations_.GetPickRay(Input_In: Mouse_Position_14, View_Projection_In: View_Projection_In, Ray_Out: out n3.Ray Ray_41);
            bool SetValue_42 = true;
            var Output_43 = this.__p_PHxN4RdgcGsPxlWha0phOl;
            if (SetValue_42)
            {
                Output_43 = this.__p_PHxN4RdgcGsPxlWha0phOl.SetValue(Value_In: View_Projection_In, Sample_In: Camera_Idle_In);
            }

            var Output_45 = Output_43.GetValue(Value_Out: out n3.Matrix Value_44);
            n34.GizmoModel_R Input_46 = n34.GizmoModel_R.CreateDefault();
            n32._Operations_.Switch_Boolean<n34.GizmoModel_R>(Condition_In: Enabled_In, Input_In: Input_46, Input_2_In: Output_40, Output_Out: out n34.GizmoModel_R Output_47);
            var Output_48 = !Left_Button_Pressed_16;
            var Result_49 = Number_of_Points_In == __pad_Oeq2uiiJZkSPgLj7BXbtLr_0;
            var Output_50 = !__auto_1;
            var Output_51 = Result_49 && Output_50;
            var Output_52 = Output_48 || Output_51;
            var Output_54 = this.__p_UhlX2ZxAH2kPO78SwVbT5M.Update(PickRay_In: Ray_41, Gizmo_Model_In: Output_47, Enable_In: Output_52, Gizmo_Out: out n34.GizmoModel_R Gizmo_53);
            bool SetValue_55 = true;
            var Output_56 = this.__p_AXzz6NKIRJTPQ4aeMJzrhV;
            if (SetValue_55)
            {
                Output_56 = this.__p_AXzz6NKIRJTPQ4aeMJzrhV.SetValue(Value_In: Gizmo_53, Sample_In: Output_52);
            }

            var Output_58 = Output_56.GetValue(Value_Out: out n34.GizmoModel_R Value_57);
            var Output_64 = Value_57.GetActiveComponents(Translation_Active_Out: out bool Translation_Active_59, Scale_Active_Out: out bool Scale_Active_60, Rotation_Active_Out: out bool Rotation_Active_61, Active_Axis_Out: out n3.Vector3 Active_Axis_62, Center_Active_Out: out bool Center_Active_63);
            var Output_66 = Value_57.IsActive(Result_Out: out bool Result_65);
            var Output_67 = Result_65 && Left_Button_Pressed_16;
            var Output_68 = this.__p_UCw10KqKrMnNmxP8nbg8C8;
            if (Output_67)
            {
                Output_68 = this.__p_UCw10KqKrMnNmxP8nbg8C8.Set();
            }

            var Output_69 = Output_68;
            if (Down_Edge_36)
            {
                Output_69 = Output_68.Reset();
            }

            var Output_71 = Output_69.GetState(State_Out: out bool State_70);
            n38._Operations_.RotationStepScale(Small_Step_In: Small_Rotation_Step_19, Smaller_Step_In: Smaller_Rotation_Step_20, Big_Step_In: Big_Rotation_Step_21, Output_Out: out float Output_72);
            var Output_77 = this.__p_EqpYwiK42PqPLu3p8241CG.Update(Gizmo_In: Value_57, Editing_In: State_70, View_Projection_In: Value_44, Uniform_In: Uniform_Scaling_17, Mouse_Position_In: Mouse_Position_14, Step_Size_In: Step_Size_In, Rotation_Step_Scale_In: Output_72, Translate_Offset_Out: out n3.Vector3 Translate_Offset_73, Scale_Offset_Out: out n3.Vector3 Scale_Offset_74, Rotate_Offset_Out: out n3.Vector3 Rotate_Offset_75, Active_Axis_Out: out n3.Vector3 Active_Axis_76);
            n46.Vector3Nodes.Scale(input: ref Nudge_Offset_15, scalar: Step_Size_In, output: out n3.Vector3 Output_78);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Nudge_22, Input_In: Translate_Offset_73, Input_2_In: Output_78, Output_Out: out n3.Vector3 Output_79);
            var Output_80 = State_70 || Nudge_22;
            var Output_81 = !Output_80;
            n34.GizmoState_R Input_82 = n34.GizmoState_R.CreateDefault();
            var Output_83 = Input_82.Join(Gizmo_Model_In: Gizmo_53, Active_Axis_In: Active_Axis_62, Translation_Offset_In: Output_79, Rotation_Value_In: Rotate_Offset_75, Scale_Offset_In: Scale_Offset_74, Visible_In: Visible_30, Idle_In: Output_81);
            bool __auto_84 = State_70;
            var Output_85 = Translation_Active_59 || Center_Active_63;
            var Output_86 = Output_85 || Nudge_22;
            n3.Vector3.Add(left: ref Output_79, right: ref Scale_Offset_74, result: out n3.Vector3 Output_87);
            n3.Vector3.Add(left: ref Output_87, right: ref Rotate_Offset_75, result: out n3.Vector3 Output_88);
            var One_89 = n3.Vector3.One;
            n3.Vector3.Add(left: ref Output_88, right: ref One_89, result: out n3.Vector3 Output_90);
            n32._Operations_.Switch_Boolean<n3.Vector3>(Condition_In: Scale_Active_60, Input_In: Output_88, Input_2_In: Output_90, Output_Out: out n3.Vector3 Output_91);
            GizmoState_Out = Output_83;
            Translate_Offset_Out = Output_79;
            Scale_Offset_Out = Scale_Offset_74;
            Rotate_Offset_Out = Rotate_Offset_75;
            Total_Offset_Out = Output_91;
            Translation_Active_Out = Output_86;
            Scale_Active_Out = Scale_Active_60;
            Rotation_Active_Out = Rotation_Active_61;
            Active_Axis_Out = Active_Axis_62;
            Idle_Out = Output_81;
            n34.Gizmo_VCf0qns0epcMnUFCEx67yz that_92 = this;
            if (this.__GetContext__().IsImmutable)
                that_92 = Output_4 != this.__p_NIrHeqn3PCaO6pPtBk2eRo || Output_7 != this.__p_PpL6WAg0dQOMpAucGnUJk3 || Output_10 != this.__p_RNfenOiZQPOP6bMgYUjfno || Output_40 != this.__p_GfTMsHcCCagLR8OXsanPqs || Output_26 != this.__p_LRpjAKLQkNpP03rpISzfQa || Output_37 != this.__p_CSKgIdQVlILLhyyqHUJn9e || Output_45 != this.__p_PHxN4RdgcGsPxlWha0phOl || Output_54 != this.__p_UhlX2ZxAH2kPO78SwVbT5M || Output_58 != this.__p_AXzz6NKIRJTPQ4aeMJzrhV || Output_71 != this.__p_UCw10KqKrMnNmxP8nbg8C8 || Output_77 != this.__p_EqpYwiK42PqPLu3p8241CG || State_70 != this.Editing ? new Gizmo_VCf0qns0epcMnUFCEx67yz(this)
                {__p_NIrHeqn3PCaO6pPtBk2eRo = Output_4, __p_PpL6WAg0dQOMpAucGnUJk3 = Output_7, __p_RNfenOiZQPOP6bMgYUjfno = Output_10, __p_GfTMsHcCCagLR8OXsanPqs = Output_40, __p_LRpjAKLQkNpP03rpISzfQa = Output_26, __p_CSKgIdQVlILLhyyqHUJn9e = Output_37, __p_PHxN4RdgcGsPxlWha0phOl = Output_45, __p_UhlX2ZxAH2kPO78SwVbT5M = Output_54, __p_AXzz6NKIRJTPQ4aeMJzrhV = Output_58, __p_UCw10KqKrMnNmxP8nbg8C8 = Output_71, __p_EqpYwiK42PqPLu3p8241CG = Output_77, Editing = State_70} : that_92;
            else
            {
                this.__p_NIrHeqn3PCaO6pPtBk2eRo = Output_4;
                this.__p_PpL6WAg0dQOMpAucGnUJk3 = Output_7;
                this.__p_RNfenOiZQPOP6bMgYUjfno = Output_10;
                this.__p_GfTMsHcCCagLR8OXsanPqs = Output_40;
                this.__p_LRpjAKLQkNpP03rpISzfQa = Output_26;
                this.__p_CSKgIdQVlILLhyyqHUJn9e = Output_37;
                this.__p_PHxN4RdgcGsPxlWha0phOl = Output_45;
                this.__p_UhlX2ZxAH2kPO78SwVbT5M = Output_54;
                this.__p_AXzz6NKIRJTPQ4aeMJzrhV = Output_58;
                this.__p_UCw10KqKrMnNmxP8nbg8C8 = Output_71;
                this.__p_EqpYwiK42PqPLu3p8241CG = Output_77;
                this.Editing = State_70;
            }

            return that_92;
        }

        public n34.Gizmo_VCf0qns0epcMnUFCEx67yz __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "UhlX2ZxAH2kPO78SwVbT5M", 100106U);
            var Output_1 = n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "EqpYwiK42PqPLu3p8241CG", 100125U);
            var Output_3 = n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "NIrHeqn3PCaO6pPtBk2eRo", 100150U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n41.Changed_A8JGbead2bxNdnPybiEqVS<float>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "PpL6WAg0dQOMpAucGnUJk3", 100159U);
            bool Changed_On_Create_8 = true;
            var Output_9 = n41.Changed_A8JGbead2bxNdnPybiEqVS<float>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_7, Changed_On_Create_In: Changed_On_Create_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "PHxN4RdgcGsPxlWha0phOl", 100215U);
            n3.Matrix Initial_Value_11 = n55._Operations_.CreateDefault();
            var Output_12 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Matrix>.Create(Node_Context: Node_Context_10, Initial_Value_In: Initial_Value_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "GfTMsHcCCagLR8OXsanPqs", 100232U);
            var Output_14 = n34.GizmoModel_R.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "AXzz6NKIRJTPQ4aeMJzrhV", 100243U);
            n34.GizmoModel_R Initial_Value_16 = n34.GizmoModel_R.CreateDefault();
            var Output_17 = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n34.GizmoModel_R>.Create(Node_Context: Node_Context_15, Initial_Value_In: Initial_Value_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CSKgIdQVlILLhyyqHUJn9e", 100248U);
            var Output_19 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RNfenOiZQPOP6bMgYUjfno", 100269U);
            bool Changed_On_Create_21 = true;
            var Output_22 = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3>.Create<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>(Node_Context: Node_Context_20, Changed_On_Create_In: Changed_On_Create_21);
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "UCw10KqKrMnNmxP8nbg8C8", 100290U);
            var Output_24 = n41.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_23);
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LRpjAKLQkNpP03rpISzfQa", 100299U);
            var Output_26 = n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_25);
            n34.Gizmo_VCf0qns0epcMnUFCEx67yz that_27 = this;
            this.Editing = false;
            this.__p_UhlX2ZxAH2kPO78SwVbT5M = Output_1;
            this.__p_EqpYwiK42PqPLu3p8241CG = Output_3;
            this.__p_NIrHeqn3PCaO6pPtBk2eRo = Output_6;
            this.__p_PpL6WAg0dQOMpAucGnUJk3 = Output_9;
            this.__p_PHxN4RdgcGsPxlWha0phOl = Output_12;
            this.__p_GfTMsHcCCagLR8OXsanPqs = Output_14;
            this.__p_AXzz6NKIRJTPQ4aeMJzrhV = Output_17;
            this.__p_CSKgIdQVlILLhyyqHUJn9e = Output_19;
            this.__p_RNfenOiZQPOP6bMgYUjfno = Output_22;
            this.__p_UCw10KqKrMnNmxP8nbg8C8 = Output_24;
            this.__p_LRpjAKLQkNpP03rpISzfQa = Output_26;
            return that_27;
        }

        public n34.Gizmo_VCf0qns0epcMnUFCEx67yz __CreateDefault__()
        {
            n34.Gizmo_VCf0qns0epcMnUFCEx67yz that_0 = this;
            this.Editing = false;
            this.__p_NIrHeqn3PCaO6pPtBk2eRo = n41.Changed_A8JGbead2bxNdnPybiEqVS<float>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_PpL6WAg0dQOMpAucGnUJk3 = n41.Changed_A8JGbead2bxNdnPybiEqVS<float>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_RNfenOiZQPOP6bMgYUjfno = n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__p_GfTMsHcCCagLR8OXsanPqs = n34.GizmoModel_R.CreateDefault();
            this.__p_LRpjAKLQkNpP03rpISzfQa = n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            this.__p_CSKgIdQVlILLhyyqHUJn9e = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_PHxN4RdgcGsPxlWha0phOl = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Matrix>.CreateDefault();
            this.__p_UhlX2ZxAH2kPO78SwVbT5M = n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH.CreateDefault();
            this.__p_AXzz6NKIRJTPQ4aeMJzrhV = n41.SPH_RESwCzqU3iTMc4Ig82Av03<n34.GizmoModel_R>.CreateDefault();
            this.__p_UCw10KqKrMnNmxP8nbg8C8 = n41.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_EqpYwiK42PqPLu3p8241CG = n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NIrHeqn3PCaO6pPtBk2eRo);
            n1.CompilationHelper.SafeDispose(this.__p_PpL6WAg0dQOMpAucGnUJk3);
            n1.CompilationHelper.SafeDispose(this.__p_RNfenOiZQPOP6bMgYUjfno);
            n1.CompilationHelper.SafeDispose(this.__p_GfTMsHcCCagLR8OXsanPqs);
            n1.CompilationHelper.SafeDispose(this.__p_LRpjAKLQkNpP03rpISzfQa);
            n1.CompilationHelper.SafeDispose(this.__p_CSKgIdQVlILLhyyqHUJn9e);
            n1.CompilationHelper.SafeDispose(this.__p_PHxN4RdgcGsPxlWha0phOl);
            n1.CompilationHelper.SafeDispose(this.__p_UhlX2ZxAH2kPO78SwVbT5M);
            n1.CompilationHelper.SafeDispose(this.__p_AXzz6NKIRJTPQ4aeMJzrhV);
            n1.CompilationHelper.SafeDispose(this.__p_UCw10KqKrMnNmxP8nbg8C8);
            n1.CompilationHelper.SafeDispose(this.__p_EqpYwiK42PqPLu3p8241CG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 100319U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Oeq2uiiJZkSPgLj7BXbtLr", Name = "__slot_Oeq2uiiJZkSPgLj7BXbtLr")]
        public static int __slot_Oeq2uiiJZkSPgLj7BXbtLr = 1;
        [n1.ElementAttribute(TracingId = 100325U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GElAnxAQq3vLYQtaDaUkzM", Name = "Editing")]
        public bool Editing;
        [n1.ElementAttribute(TracingId = 100150U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NIrHeqn3PCaO6pPtBk2eRo", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_NIrHeqn3PCaO6pPtBk2eRo;
        [n1.ElementAttribute(TracingId = 100159U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PpL6WAg0dQOMpAucGnUJk3", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_PpL6WAg0dQOMpAucGnUJk3;
        [n1.ElementAttribute(TracingId = 100269U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RNfenOiZQPOP6bMgYUjfno", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3> __p_RNfenOiZQPOP6bMgYUjfno;
        [n1.ElementAttribute(TracingId = 100232U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GfTMsHcCCagLR8OXsanPqs", Name = "GizmoModel", IsManaged = true, IsAutoGenerated = true)]
        public n34.GizmoModel_R __p_GfTMsHcCCagLR8OXsanPqs;
        [n1.ElementAttribute(TracingId = 100299U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LRpjAKLQkNpP03rpISzfQa", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_LRpjAKLQkNpP03rpISzfQa;
        [n1.ElementAttribute(TracingId = 100248U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CSKgIdQVlILLhyyqHUJn9e", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CSKgIdQVlILLhyyqHUJn9e;
        [n1.ElementAttribute(TracingId = 100215U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PHxN4RdgcGsPxlWha0phOl", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Matrix> __p_PHxN4RdgcGsPxlWha0phOl;
        [n1.ElementAttribute(TracingId = 100106U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UhlX2ZxAH2kPO78SwVbT5M", Name = "GizmoDetector", IsManaged = true, IsAutoGenerated = true)]
        public n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH __p_UhlX2ZxAH2kPO78SwVbT5M;
        [n1.ElementAttribute(TracingId = 100243U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "AXzz6NKIRJTPQ4aeMJzrhV", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n41.SPH_RESwCzqU3iTMc4Ig82Av03<n34.GizmoModel_R> __p_AXzz6NKIRJTPQ4aeMJzrhV;
        [n1.ElementAttribute(TracingId = 100290U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UCw10KqKrMnNmxP8nbg8C8", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n41.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_UCw10KqKrMnNmxP8nbg8C8;
        [n1.ElementAttribute(TracingId = 100125U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EqpYwiK42PqPLu3p8241CG", Name = "GizmoOffsetter", IsManaged = true, IsAutoGenerated = true)]
        public n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J __p_EqpYwiK42PqPLu3p8241CG;
        static Gizmo_VCf0qns0epcMnUFCEx67yz()
        {
        }

        public Gizmo_VCf0qns0epcMnUFCEx67yz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Gizmo_VCf0qns0epcMnUFCEx67yz(Gizmo_VCf0qns0epcMnUFCEx67yz other): base(other)
        {
            this.Editing = other.Editing;
            this.__p_NIrHeqn3PCaO6pPtBk2eRo = other.__p_NIrHeqn3PCaO6pPtBk2eRo;
            this.__p_PpL6WAg0dQOMpAucGnUJk3 = other.__p_PpL6WAg0dQOMpAucGnUJk3;
            this.__p_RNfenOiZQPOP6bMgYUjfno = other.__p_RNfenOiZQPOP6bMgYUjfno;
            this.__p_GfTMsHcCCagLR8OXsanPqs = other.__p_GfTMsHcCCagLR8OXsanPqs;
            this.__p_LRpjAKLQkNpP03rpISzfQa = other.__p_LRpjAKLQkNpP03rpISzfQa;
            this.__p_CSKgIdQVlILLhyyqHUJn9e = other.__p_CSKgIdQVlILLhyyqHUJn9e;
            this.__p_PHxN4RdgcGsPxlWha0phOl = other.__p_PHxN4RdgcGsPxlWha0phOl;
            this.__p_UhlX2ZxAH2kPO78SwVbT5M = other.__p_UhlX2ZxAH2kPO78SwVbT5M;
            this.__p_AXzz6NKIRJTPQ4aeMJzrhV = other.__p_AXzz6NKIRJTPQ4aeMJzrhV;
            this.__p_UCw10KqKrMnNmxP8nbg8C8 = other.__p_UCw10KqKrMnNmxP8nbg8C8;
            this.__p_EqpYwiK42PqPLu3p8241CG = other.__p_EqpYwiK42PqPLu3p8241CG;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Editing", in Editing), n1.CompilationHelper.GetValueOrExisting(values, "__p_NIrHeqn3PCaO6pPtBk2eRo", in __p_NIrHeqn3PCaO6pPtBk2eRo), n1.CompilationHelper.GetValueOrExisting(values, "__p_PpL6WAg0dQOMpAucGnUJk3", in __p_PpL6WAg0dQOMpAucGnUJk3), n1.CompilationHelper.GetValueOrExisting(values, "__p_RNfenOiZQPOP6bMgYUjfno", in __p_RNfenOiZQPOP6bMgYUjfno), n1.CompilationHelper.GetValueOrExisting(values, "__p_GfTMsHcCCagLR8OXsanPqs", in __p_GfTMsHcCCagLR8OXsanPqs), n1.CompilationHelper.GetValueOrExisting(values, "__p_LRpjAKLQkNpP03rpISzfQa", in __p_LRpjAKLQkNpP03rpISzfQa), n1.CompilationHelper.GetValueOrExisting(values, "__p_CSKgIdQVlILLhyyqHUJn9e", in __p_CSKgIdQVlILLhyyqHUJn9e), n1.CompilationHelper.GetValueOrExisting(values, "__p_PHxN4RdgcGsPxlWha0phOl", in __p_PHxN4RdgcGsPxlWha0phOl), n1.CompilationHelper.GetValueOrExisting(values, "__p_UhlX2ZxAH2kPO78SwVbT5M", in __p_UhlX2ZxAH2kPO78SwVbT5M), n1.CompilationHelper.GetValueOrExisting(values, "__p_AXzz6NKIRJTPQ4aeMJzrhV", in __p_AXzz6NKIRJTPQ4aeMJzrhV), n1.CompilationHelper.GetValueOrExisting(values, "__p_UCw10KqKrMnNmxP8nbg8C8", in __p_UCw10KqKrMnNmxP8nbg8C8), n1.CompilationHelper.GetValueOrExisting(values, "__p_EqpYwiK42PqPLu3p8241CG", in __p_EqpYwiK42PqPLu3p8241CG));
        }

        internal Gizmo_VCf0qns0epcMnUFCEx67yz __WITH__(bool Editing, n41.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_NIrHeqn3PCaO6pPtBk2eRo, n41.Changed_A8JGbead2bxNdnPybiEqVS<float> __p_PpL6WAg0dQOMpAucGnUJk3, n41.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector3> __p_RNfenOiZQPOP6bMgYUjfno, n34.GizmoModel_R __p_GfTMsHcCCagLR8OXsanPqs, n41.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_LRpjAKLQkNpP03rpISzfQa, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CSKgIdQVlILLhyyqHUJn9e, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Matrix> __p_PHxN4RdgcGsPxlWha0phOl, n38.GizmoDetector_SBqScJSmXEiM5u1rro5DrH __p_UhlX2ZxAH2kPO78SwVbT5M, n41.SPH_RESwCzqU3iTMc4Ig82Av03<n34.GizmoModel_R> __p_AXzz6NKIRJTPQ4aeMJzrhV, n41.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_UCw10KqKrMnNmxP8nbg8C8, n38.GizmoOffsetter_AdI63omT2YTOi5EjgAa12J __p_EqpYwiK42PqPLu3p8241CG)
        {
            n34.Gizmo_VCf0qns0epcMnUFCEx67yz that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Editing != this.Editing || __p_NIrHeqn3PCaO6pPtBk2eRo != this.__p_NIrHeqn3PCaO6pPtBk2eRo || __p_PpL6WAg0dQOMpAucGnUJk3 != this.__p_PpL6WAg0dQOMpAucGnUJk3 || __p_RNfenOiZQPOP6bMgYUjfno != this.__p_RNfenOiZQPOP6bMgYUjfno || __p_GfTMsHcCCagLR8OXsanPqs != this.__p_GfTMsHcCCagLR8OXsanPqs || __p_LRpjAKLQkNpP03rpISzfQa != this.__p_LRpjAKLQkNpP03rpISzfQa || __p_CSKgIdQVlILLhyyqHUJn9e != this.__p_CSKgIdQVlILLhyyqHUJn9e || __p_PHxN4RdgcGsPxlWha0phOl != this.__p_PHxN4RdgcGsPxlWha0phOl || __p_UhlX2ZxAH2kPO78SwVbT5M != this.__p_UhlX2ZxAH2kPO78SwVbT5M || __p_AXzz6NKIRJTPQ4aeMJzrhV != this.__p_AXzz6NKIRJTPQ4aeMJzrhV || __p_UCw10KqKrMnNmxP8nbg8C8 != this.__p_UCw10KqKrMnNmxP8nbg8C8 || __p_EqpYwiK42PqPLu3p8241CG != this.__p_EqpYwiK42PqPLu3p8241CG ? new Gizmo_VCf0qns0epcMnUFCEx67yz(this)
                {Editing = Editing, __p_NIrHeqn3PCaO6pPtBk2eRo = __p_NIrHeqn3PCaO6pPtBk2eRo, __p_PpL6WAg0dQOMpAucGnUJk3 = __p_PpL6WAg0dQOMpAucGnUJk3, __p_RNfenOiZQPOP6bMgYUjfno = __p_RNfenOiZQPOP6bMgYUjfno, __p_GfTMsHcCCagLR8OXsanPqs = __p_GfTMsHcCCagLR8OXsanPqs, __p_LRpjAKLQkNpP03rpISzfQa = __p_LRpjAKLQkNpP03rpISzfQa, __p_CSKgIdQVlILLhyyqHUJn9e = __p_CSKgIdQVlILLhyyqHUJn9e, __p_PHxN4RdgcGsPxlWha0phOl = __p_PHxN4RdgcGsPxlWha0phOl, __p_UhlX2ZxAH2kPO78SwVbT5M = __p_UhlX2ZxAH2kPO78SwVbT5M, __p_AXzz6NKIRJTPQ4aeMJzrhV = __p_AXzz6NKIRJTPQ4aeMJzrhV, __p_UCw10KqKrMnNmxP8nbg8C8 = __p_UCw10KqKrMnNmxP8nbg8C8, __p_EqpYwiK42PqPLu3p8241CG = __p_EqpYwiK42PqPLu3p8241CG} : that_0;
            else
            {
                this.Editing = Editing;
                this.__p_NIrHeqn3PCaO6pPtBk2eRo = __p_NIrHeqn3PCaO6pPtBk2eRo;
                this.__p_PpL6WAg0dQOMpAucGnUJk3 = __p_PpL6WAg0dQOMpAucGnUJk3;
                this.__p_RNfenOiZQPOP6bMgYUjfno = __p_RNfenOiZQPOP6bMgYUjfno;
                this.__p_GfTMsHcCCagLR8OXsanPqs = __p_GfTMsHcCCagLR8OXsanPqs;
                this.__p_LRpjAKLQkNpP03rpISzfQa = __p_LRpjAKLQkNpP03rpISzfQa;
                this.__p_CSKgIdQVlILLhyyqHUJn9e = __p_CSKgIdQVlILLhyyqHUJn9e;
                this.__p_PHxN4RdgcGsPxlWha0phOl = __p_PHxN4RdgcGsPxlWha0phOl;
                this.__p_UhlX2ZxAH2kPO78SwVbT5M = __p_UhlX2ZxAH2kPO78SwVbT5M;
                this.__p_AXzz6NKIRJTPQ4aeMJzrhV = __p_AXzz6NKIRJTPQ4aeMJzrhV;
                this.__p_UCw10KqKrMnNmxP8nbg8C8 = __p_UCw10KqKrMnNmxP8nbg8C8;
                this.__p_EqpYwiK42PqPLu3p8241CG = __p_EqpYwiK42PqPLu3p8241CG;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 63484U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ToXYZ(n3.Vector3 Vector_In, out n3.Vector3 Output_Out)
        {
            Output_Out = Vector_In;
            return;
        }
    }
}

namespace _VL_Editors_.Editors.Advanced
{
    [n1.ElementAttribute(TracingId = 100516U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CfmJZxw2ZgxMXLlIxJ3jzg", Name = "PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg")]
    [n2.SerializableAttribute]
    public class PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg Create(n1.NodeContext Node_Context)
        {
            var instance = new PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg CreateDefault()
        {
            var instance = new PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg Join(n43.IMouse Mouse_Device_In, n43.IKeyboard Keyboard_Device_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.PointEditorControlsData_R PointEditor_Controls_Out)
        {
            n8.PointEditorControlsData_R __auto_0 = this.PointEditorControlsData;
            string __pad_OKsOW9ffpgLPlMQnW8zyfi_1 = __slot_OKsOW9ffpgLPlMQnW8zyfi;
            string __pad_Nt5p1teYvV8QYmErUzm8Lk_2 = __slot_Nt5p1teYvV8QYmErUzm8Lk;
            string __pad_Fy8kqpRt4OCOy9M7tBl4aL_3 = __slot_Fy8kqpRt4OCOy9M7tBl4aL;
            string __pad_VyVFu04XqmdNMJvzHxEDJR_4 = __slot_VyVFu04XqmdNMJvzHxEDJR;
            string __pad_KhQLa0C4XERNl1vrediLbQ_5 = __slot_KhQLa0C4XERNl1vrediLbQ;
            string __pad_I3Wn0OFuKe7LKI3jdeSOTe_6 = __slot_I3Wn0OFuKe7LKI3jdeSOTe;
            string __pad_FEfajGnWMWKMehwJIuRnCX_7 = __slot_FEfajGnWMWKMehwJIuRnCX;
            string __pad_LcseZhLB8GVP8P0TgqkEFo_8 = __slot_LcseZhLB8GVP8P0TgqkEFo;
            string __pad_PdF6ka6wzjgPXgfhqiE83g_9 = __slot_PdF6ka6wzjgPXgfhqiE83g;
            string __pad_Tv7iQ7VAQ17QVNGoh7ZWzY_10 = __slot_Tv7iQ7VAQ17QVNGoh7ZWzY;
            string __pad_Lnv5LSUTFGQNRWlzBpwYB4_11 = __slot_Lnv5LSUTFGQNRWlzBpwYB4;
            string __pad_OEKniAGZNSdPv2aFqBuRA9_12 = __slot_OEKniAGZNSdPv2aFqBuRA9;
            var Output_23 = this.__p_OShCFZw2rNEQaKBRwm4bxD.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n3.Vector2 Position_In_World_13, Position_In_Projection_Out: out n3.Vector2 Position_In_Projection_14, Position_Out: out n3.Vector2 Position_15, Left_Pressed_Out: out bool Left_Pressed_16, Middle_Pressed_Out: out bool Middle_Pressed_17, Right_Pressed_Out: out bool Right_Pressed_18, Normalized_Position_Out: out n3.Vector2 Normalized_Position_19, WheelDelta_Out: out int WheelDelta_20, Client_Area_Out: out n3.Vector2 Client_Area_21, Sender_Out: out n2.Object Sender_22);
            var Output_25 = this.__p_EsYwfESB2yDPlQd4kwhGk6.Update(Position_In: Position_In_Projection_14, Select_In: Left_Pressed_16, Selection_Out: out n3.RectangleF Selection_24);
            var Output_27 = this.__p_JhF0m8oWhQYNb9G2taFsXd.Update(Keyboard_Device_In: Keyboard_Device_In, Pressed_Keys_Out: out n40.ImmutableHashSet<n39.Keys> Pressed_Keys_26);
            var Output_29 = this.__p_Kl0H8GX8A91Ma0FvwYFFeN.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_OKsOW9ffpgLPlMQnW8zyfi_1, Is_Down_Out: out bool Is_Down_28);
            var Output_31 = this.__p_JoxnayoNsgHPMX9bHpQtSC.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_OEKniAGZNSdPv2aFqBuRA9_12, Is_Down_Out: out bool Is_Down_30);
            var Output_32 = Is_Down_28 || Is_Down_30;
            var Output_35 = this.__p_K8OMYLmuUBuLlxWxaQMFMW.Update(Value_In: Output_32, Up_Edge_Out: out bool Up_Edge_33, Down_Edge_Out: out bool Down_Edge_34);
            var Output_37 = this.__p_T1wLIFvYIZMMTjWTjUrW6C.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Nt5p1teYvV8QYmErUzm8Lk_2, Is_Down_Out: out bool Is_Down_36);
            var Output_39 = this.__p_J6bqF99H5RLP0KkY0kz8Oh.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_I3Wn0OFuKe7LKI3jdeSOTe_6, Is_Down_Out: out bool Is_Down_38);
            var Output_41 = this.__p_SbNxzcvCxgnPCAwqbizvmr.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Lnv5LSUTFGQNRWlzBpwYB4_11, Is_Down_Out: out bool Is_Down_40);
            var Output_44 = this.__p_PD5Gw4HKd8mPVOUSnFkEAe.Update(Value_In: Is_Down_40, Up_Edge_Out: out bool Up_Edge_42, Down_Edge_Out: out bool Down_Edge_43);
            var Output_45 = !Is_Down_38;
            var Output_47 = this.__p_Bf6vOO5BgIPNsUAgugh8dd.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_PdF6ka6wzjgPXgfhqiE83g_9, Is_Down_Out: out bool Is_Down_46);
            var Output_50 = this.__p_LdnrCC1QOGHOarIsxUI6ON.Update(Value_In: Is_Down_46, Up_Edge_Out: out bool Up_Edge_48, Down_Edge_Out: out bool Down_Edge_49);
            var Output_51 = Output_45 && Up_Edge_48;
            var Output_52 = Is_Down_38 && Up_Edge_48;
            var Output_54 = this.__p_C7tpoGCrJXLQX7JTQmJBua.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Fy8kqpRt4OCOy9M7tBl4aL_3, Is_Down_Out: out bool Is_Down_53);
            var Output_55 = Is_Down_53 && Is_Down_36;
            var Output_57 = this.__p_Tigllc3wZDAP2UYqaWqZqf.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_KhQLa0C4XERNl1vrediLbQ_5, Is_Down_Out: out bool Is_Down_56);
            var Output_59 = this.__p_NHL983GqvYMMTjwexsli3k.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_VyVFu04XqmdNMJvzHxEDJR_4, Is_Down_Out: out bool Is_Down_58);
            var Output_61 = this.__p_Nq9qXINAYJpM1BQfwr8Ugy.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Tv7iQ7VAQ17QVNGoh7ZWzY_10, Is_Down_Out: out bool Is_Down_60);
            var Output_63 = this.__p_IhlnilW9nkYNI13ixtOnjM.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_FEfajGnWMWKMehwJIuRnCX_7, Is_Down_Out: out bool Is_Down_62);
            var Output_65 = this.__p_EeG6wKrIDY1Py1FwHGmKYq.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_LcseZhLB8GVP8P0TgqkEFo_8, Is_Down_Out: out bool Is_Down_64);
            var Output_66 = Is_Down_62 && Is_Down_64;
            bool Apply_67 = true;
            var Output_68 = Is_Down_38;
            if (Apply_67)
            {
                var Output_69 = !Is_Down_38;
                Output_68 = Output_69;
            }

            var Output_70 = Output_66 && Output_68;
            var Output_73 = this.__p_CH1YqmEydzGPoa1yEZdqMi.Update(Value_In: Output_70, Up_Edge_Out: out bool Up_Edge_71, Down_Edge_Out: out bool Down_Edge_72);
            var Output_74 = Output_66 && Is_Down_38;
            var Output_77 = this.__p_IaqOg9K25AYLTEVlmPqXG4.Update(Value_In: Output_74, Up_Edge_Out: out bool Up_Edge_75, Down_Edge_Out: out bool Down_Edge_76);
            var Output_78 = __auto_0;
            if (Enabled_In)
            {
                Output_78 = __auto_0.Join(Pointer_Position_In: Position_In_Projection_14, Mouse_Pressed_In: Left_Pressed_16, Selection_In: Selection_24, Remove_Selected_In: Up_Edge_33, Control_In: Is_Down_36, Shift_In: Is_Down_38, Space_In: Up_Edge_42, Hover_Next_In: Output_51, Hover_Previous_In: Output_52, Select_All_In: Output_55, Scale_In: Is_Down_56, Rotate_In: Is_Down_58, Translate_In: Is_Down_60, Undo_In: Up_Edge_71, Redo_In: Up_Edge_75);
            }

            n8.PointEditorControlsData_R __auto_79 = Output_78;
            PointEditor_Controls_Out = Output_78;
            n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg that_80 = this;
            if (this.__GetContext__().IsImmutable)
                that_80 = Output_23 != this.__p_OShCFZw2rNEQaKBRwm4bxD || Output_25 != this.__p_EsYwfESB2yDPlQd4kwhGk6 || Output_27 != this.__p_JhF0m8oWhQYNb9G2taFsXd || Output_29 != this.__p_Kl0H8GX8A91Ma0FvwYFFeN || Output_31 != this.__p_JoxnayoNsgHPMX9bHpQtSC || Output_35 != this.__p_K8OMYLmuUBuLlxWxaQMFMW || Output_37 != this.__p_T1wLIFvYIZMMTjWTjUrW6C || Output_39 != this.__p_J6bqF99H5RLP0KkY0kz8Oh || Output_41 != this.__p_SbNxzcvCxgnPCAwqbizvmr || Output_44 != this.__p_PD5Gw4HKd8mPVOUSnFkEAe || Output_47 != this.__p_Bf6vOO5BgIPNsUAgugh8dd || Output_50 != this.__p_LdnrCC1QOGHOarIsxUI6ON || Output_54 != this.__p_C7tpoGCrJXLQX7JTQmJBua || Output_57 != this.__p_Tigllc3wZDAP2UYqaWqZqf || Output_59 != this.__p_NHL983GqvYMMTjwexsli3k || Output_61 != this.__p_Nq9qXINAYJpM1BQfwr8Ugy || Output_63 != this.__p_IhlnilW9nkYNI13ixtOnjM || Output_65 != this.__p_EeG6wKrIDY1Py1FwHGmKYq || Output_73 != this.__p_CH1YqmEydzGPoa1yEZdqMi || Output_77 != this.__p_IaqOg9K25AYLTEVlmPqXG4 || Output_78 != this.PointEditorControlsData ? new PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(this)
                {__p_OShCFZw2rNEQaKBRwm4bxD = Output_23, __p_EsYwfESB2yDPlQd4kwhGk6 = Output_25, __p_JhF0m8oWhQYNb9G2taFsXd = Output_27, __p_Kl0H8GX8A91Ma0FvwYFFeN = Output_29, __p_JoxnayoNsgHPMX9bHpQtSC = Output_31, __p_K8OMYLmuUBuLlxWxaQMFMW = Output_35, __p_T1wLIFvYIZMMTjWTjUrW6C = Output_37, __p_J6bqF99H5RLP0KkY0kz8Oh = Output_39, __p_SbNxzcvCxgnPCAwqbizvmr = Output_41, __p_PD5Gw4HKd8mPVOUSnFkEAe = Output_44, __p_Bf6vOO5BgIPNsUAgugh8dd = Output_47, __p_LdnrCC1QOGHOarIsxUI6ON = Output_50, __p_C7tpoGCrJXLQX7JTQmJBua = Output_54, __p_Tigllc3wZDAP2UYqaWqZqf = Output_57, __p_NHL983GqvYMMTjwexsli3k = Output_59, __p_Nq9qXINAYJpM1BQfwr8Ugy = Output_61, __p_IhlnilW9nkYNI13ixtOnjM = Output_63, __p_EeG6wKrIDY1Py1FwHGmKYq = Output_65, __p_CH1YqmEydzGPoa1yEZdqMi = Output_73, __p_IaqOg9K25AYLTEVlmPqXG4 = Output_77, PointEditorControlsData = Output_78} : that_80;
            else
            {
                this.__p_OShCFZw2rNEQaKBRwm4bxD = Output_23;
                this.__p_EsYwfESB2yDPlQd4kwhGk6 = Output_25;
                this.__p_JhF0m8oWhQYNb9G2taFsXd = Output_27;
                this.__p_Kl0H8GX8A91Ma0FvwYFFeN = Output_29;
                this.__p_JoxnayoNsgHPMX9bHpQtSC = Output_31;
                this.__p_K8OMYLmuUBuLlxWxaQMFMW = Output_35;
                this.__p_T1wLIFvYIZMMTjWTjUrW6C = Output_37;
                this.__p_J6bqF99H5RLP0KkY0kz8Oh = Output_39;
                this.__p_SbNxzcvCxgnPCAwqbizvmr = Output_41;
                this.__p_PD5Gw4HKd8mPVOUSnFkEAe = Output_44;
                this.__p_Bf6vOO5BgIPNsUAgugh8dd = Output_47;
                this.__p_LdnrCC1QOGHOarIsxUI6ON = Output_50;
                this.__p_C7tpoGCrJXLQX7JTQmJBua = Output_54;
                this.__p_Tigllc3wZDAP2UYqaWqZqf = Output_57;
                this.__p_NHL983GqvYMMTjwexsli3k = Output_59;
                this.__p_Nq9qXINAYJpM1BQfwr8Ugy = Output_61;
                this.__p_IhlnilW9nkYNI13ixtOnjM = Output_63;
                this.__p_EeG6wKrIDY1Py1FwHGmKYq = Output_65;
                this.__p_CH1YqmEydzGPoa1yEZdqMi = Output_73;
                this.__p_IaqOg9K25AYLTEVlmPqXG4 = Output_77;
                this.PointEditorControlsData = Output_78;
            }

            return that_80;
        }

        public n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "OShCFZw2rNEQaKBRwm4bxD", 100553U);
            var Output_1 = n44.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "JhF0m8oWhQYNb9G2taFsXd", 100565U);
            var Output_3 = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "T1wLIFvYIZMMTjWTjUrW6C", 100568U);
            var Output_5 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "EsYwfESB2yDPlQd4kwhGk6", 100572U);
            var Output_7 = n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "NHL983GqvYMMTjwexsli3k", 100576U);
            var Output_9 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Tigllc3wZDAP2UYqaWqZqf", 100580U);
            var Output_11 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "J6bqF99H5RLP0KkY0kz8Oh", 100584U);
            var Output_13 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "C7tpoGCrJXLQX7JTQmJBua", 100591U);
            var Output_15 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Kl0H8GX8A91Ma0FvwYFFeN", 100613U);
            var Output_17 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "EeG6wKrIDY1Py1FwHGmKYq", 100617U);
            var Output_19 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IhlnilW9nkYNI13ixtOnjM", 100621U);
            var Output_21 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CH1YqmEydzGPoa1yEZdqMi", 100637U);
            var Output_23 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "IaqOg9K25AYLTEVlmPqXG4", 100641U);
            var Output_25 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Nq9qXINAYJpM1BQfwr8Ugy", 100645U);
            var Output_27 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "SbNxzcvCxgnPCAwqbizvmr", 100654U);
            var Output_29 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "PD5Gw4HKd8mPVOUSnFkEAe", 100658U);
            var Output_31 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Bf6vOO5BgIPNsUAgugh8dd", 100663U);
            var Output_33 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_32);
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "LdnrCC1QOGHOarIsxUI6ON", 100674U);
            var Output_35 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_34);
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "JoxnayoNsgHPMX9bHpQtSC", 100683U);
            var Output_37 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_36);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "K8OMYLmuUBuLlxWxaQMFMW", 100691U);
            var Output_39 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_38);
            n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg that_40 = this;
            this.PointEditorControlsData = n8.PointEditorControlsData_R.CreateDefault();
            this.__p_OShCFZw2rNEQaKBRwm4bxD = Output_1;
            this.__p_JhF0m8oWhQYNb9G2taFsXd = Output_3;
            this.__p_T1wLIFvYIZMMTjWTjUrW6C = Output_5;
            this.__p_EsYwfESB2yDPlQd4kwhGk6 = Output_7;
            this.__p_NHL983GqvYMMTjwexsli3k = Output_9;
            this.__p_Tigllc3wZDAP2UYqaWqZqf = Output_11;
            this.__p_J6bqF99H5RLP0KkY0kz8Oh = Output_13;
            this.__p_C7tpoGCrJXLQX7JTQmJBua = Output_15;
            this.__p_Kl0H8GX8A91Ma0FvwYFFeN = Output_17;
            this.__p_EeG6wKrIDY1Py1FwHGmKYq = Output_19;
            this.__p_IhlnilW9nkYNI13ixtOnjM = Output_21;
            this.__p_CH1YqmEydzGPoa1yEZdqMi = Output_23;
            this.__p_IaqOg9K25AYLTEVlmPqXG4 = Output_25;
            this.__p_Nq9qXINAYJpM1BQfwr8Ugy = Output_27;
            this.__p_SbNxzcvCxgnPCAwqbizvmr = Output_29;
            this.__p_PD5Gw4HKd8mPVOUSnFkEAe = Output_31;
            this.__p_Bf6vOO5BgIPNsUAgugh8dd = Output_33;
            this.__p_LdnrCC1QOGHOarIsxUI6ON = Output_35;
            this.__p_JoxnayoNsgHPMX9bHpQtSC = Output_37;
            this.__p_K8OMYLmuUBuLlxWxaQMFMW = Output_39;
            return that_40;
        }

        public n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg __CreateDefault__()
        {
            n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg that_0 = this;
            this.PointEditorControlsData = n8.PointEditorControlsData_R.CreateDefault();
            this.__p_OShCFZw2rNEQaKBRwm4bxD = n44.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_EsYwfESB2yDPlQd4kwhGk6 = n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU.CreateDefault();
            this.__p_JhF0m8oWhQYNb9G2taFsXd = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_Kl0H8GX8A91Ma0FvwYFFeN = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_JoxnayoNsgHPMX9bHpQtSC = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_K8OMYLmuUBuLlxWxaQMFMW = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_T1wLIFvYIZMMTjWTjUrW6C = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_J6bqF99H5RLP0KkY0kz8Oh = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_SbNxzcvCxgnPCAwqbizvmr = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_PD5Gw4HKd8mPVOUSnFkEAe = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_Bf6vOO5BgIPNsUAgugh8dd = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LdnrCC1QOGHOarIsxUI6ON = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_C7tpoGCrJXLQX7JTQmJBua = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Tigllc3wZDAP2UYqaWqZqf = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_NHL983GqvYMMTjwexsli3k = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Nq9qXINAYJpM1BQfwr8Ugy = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_IhlnilW9nkYNI13ixtOnjM = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_EeG6wKrIDY1Py1FwHGmKYq = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_CH1YqmEydzGPoa1yEZdqMi = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_IaqOg9K25AYLTEVlmPqXG4 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OShCFZw2rNEQaKBRwm4bxD);
            n1.CompilationHelper.SafeDispose(this.__p_EsYwfESB2yDPlQd4kwhGk6);
            n1.CompilationHelper.SafeDispose(this.__p_JhF0m8oWhQYNb9G2taFsXd);
            n1.CompilationHelper.SafeDispose(this.__p_Kl0H8GX8A91Ma0FvwYFFeN);
            n1.CompilationHelper.SafeDispose(this.__p_JoxnayoNsgHPMX9bHpQtSC);
            n1.CompilationHelper.SafeDispose(this.__p_K8OMYLmuUBuLlxWxaQMFMW);
            n1.CompilationHelper.SafeDispose(this.__p_T1wLIFvYIZMMTjWTjUrW6C);
            n1.CompilationHelper.SafeDispose(this.__p_J6bqF99H5RLP0KkY0kz8Oh);
            n1.CompilationHelper.SafeDispose(this.__p_SbNxzcvCxgnPCAwqbizvmr);
            n1.CompilationHelper.SafeDispose(this.__p_PD5Gw4HKd8mPVOUSnFkEAe);
            n1.CompilationHelper.SafeDispose(this.__p_Bf6vOO5BgIPNsUAgugh8dd);
            n1.CompilationHelper.SafeDispose(this.__p_LdnrCC1QOGHOarIsxUI6ON);
            n1.CompilationHelper.SafeDispose(this.__p_C7tpoGCrJXLQX7JTQmJBua);
            n1.CompilationHelper.SafeDispose(this.__p_Tigllc3wZDAP2UYqaWqZqf);
            n1.CompilationHelper.SafeDispose(this.__p_NHL983GqvYMMTjwexsli3k);
            n1.CompilationHelper.SafeDispose(this.__p_Nq9qXINAYJpM1BQfwr8Ugy);
            n1.CompilationHelper.SafeDispose(this.__p_IhlnilW9nkYNI13ixtOnjM);
            n1.CompilationHelper.SafeDispose(this.__p_EeG6wKrIDY1Py1FwHGmKYq);
            n1.CompilationHelper.SafeDispose(this.__p_CH1YqmEydzGPoa1yEZdqMi);
            n1.CompilationHelper.SafeDispose(this.__p_IaqOg9K25AYLTEVlmPqXG4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 100518U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F6XfYYx6t49P2tzrSip3lz", Name = "PointEditorControlsData")]
        public n8.PointEditorControlsData_R PointEditorControlsData;
        [n1.ElementAttribute(TracingId = 100542U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Nt5p1teYvV8QYmErUzm8Lk", Name = "__slot_Nt5p1teYvV8QYmErUzm8Lk")]
        public static string __slot_Nt5p1teYvV8QYmErUzm8Lk = "ControlKey";
        [n1.ElementAttribute(TracingId = 100543U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VyVFu04XqmdNMJvzHxEDJR", Name = "__slot_VyVFu04XqmdNMJvzHxEDJR")]
        public static string __slot_VyVFu04XqmdNMJvzHxEDJR = "C";
        [n1.ElementAttribute(TracingId = 100544U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KhQLa0C4XERNl1vrediLbQ", Name = "__slot_KhQLa0C4XERNl1vrediLbQ")]
        public static string __slot_KhQLa0C4XERNl1vrediLbQ = "X";
        [n1.ElementAttribute(TracingId = 100545U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "I3Wn0OFuKe7LKI3jdeSOTe", Name = "__slot_I3Wn0OFuKe7LKI3jdeSOTe")]
        public static string __slot_I3Wn0OFuKe7LKI3jdeSOTe = "ShiftKey";
        [n1.ElementAttribute(TracingId = 100546U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Fy8kqpRt4OCOy9M7tBl4aL", Name = "__slot_Fy8kqpRt4OCOy9M7tBl4aL")]
        public static string __slot_Fy8kqpRt4OCOy9M7tBl4aL = "A";
        [n1.ElementAttribute(TracingId = 100547U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OKsOW9ffpgLPlMQnW8zyfi", Name = "__slot_OKsOW9ffpgLPlMQnW8zyfi")]
        public static string __slot_OKsOW9ffpgLPlMQnW8zyfi = "Delete";
        [n1.ElementAttribute(TracingId = 100548U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LcseZhLB8GVP8P0TgqkEFo", Name = "__slot_LcseZhLB8GVP8P0TgqkEFo")]
        public static string __slot_LcseZhLB8GVP8P0TgqkEFo = "ControlKey";
        [n1.ElementAttribute(TracingId = 100549U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FEfajGnWMWKMehwJIuRnCX", Name = "__slot_FEfajGnWMWKMehwJIuRnCX")]
        public static string __slot_FEfajGnWMWKMehwJIuRnCX = "Z";
        [n1.ElementAttribute(TracingId = 100550U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Tv7iQ7VAQ17QVNGoh7ZWzY", Name = "__slot_Tv7iQ7VAQ17QVNGoh7ZWzY")]
        public static string __slot_Tv7iQ7VAQ17QVNGoh7ZWzY = "V";
        [n1.ElementAttribute(TracingId = 100653U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Lnv5LSUTFGQNRWlzBpwYB4", Name = "__slot_Lnv5LSUTFGQNRWlzBpwYB4")]
        public static string __slot_Lnv5LSUTFGQNRWlzBpwYB4 = "Space";
        [n1.ElementAttribute(TracingId = 100662U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PdF6ka6wzjgPXgfhqiE83g", Name = "__slot_PdF6ka6wzjgPXgfhqiE83g")]
        public static string __slot_PdF6ka6wzjgPXgfhqiE83g = "Q";
        [n1.ElementAttribute(TracingId = 100682U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OEKniAGZNSdPv2aFqBuRA9", Name = "__slot_OEKniAGZNSdPv2aFqBuRA9")]
        public static string __slot_OEKniAGZNSdPv2aFqBuRA9 = "Back";
        [n1.ElementAttribute(TracingId = 100553U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OShCFZw2rNEQaKBRwm4bxD", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n44.MouseState_BNOhaxXysw1MZBzyJMI18t __p_OShCFZw2rNEQaKBRwm4bxD;
        [n1.ElementAttribute(TracingId = 100572U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EsYwfESB2yDPlQd4kwhGk6", Name = "SelectionRect", IsManaged = true, IsAutoGenerated = true)]
        public n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU __p_EsYwfESB2yDPlQd4kwhGk6;
        [n1.ElementAttribute(TracingId = 100565U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JhF0m8oWhQYNb9G2taFsXd", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_JhF0m8oWhQYNb9G2taFsXd;
        [n1.ElementAttribute(TracingId = 100613U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Kl0H8GX8A91Ma0FvwYFFeN", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Kl0H8GX8A91Ma0FvwYFFeN;
        [n1.ElementAttribute(TracingId = 100683U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JoxnayoNsgHPMX9bHpQtSC", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JoxnayoNsgHPMX9bHpQtSC;
        [n1.ElementAttribute(TracingId = 100691U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "K8OMYLmuUBuLlxWxaQMFMW", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_K8OMYLmuUBuLlxWxaQMFMW;
        [n1.ElementAttribute(TracingId = 100568U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "T1wLIFvYIZMMTjWTjUrW6C", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_T1wLIFvYIZMMTjWTjUrW6C;
        [n1.ElementAttribute(TracingId = 100584U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "J6bqF99H5RLP0KkY0kz8Oh", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_J6bqF99H5RLP0KkY0kz8Oh;
        [n1.ElementAttribute(TracingId = 100654U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SbNxzcvCxgnPCAwqbizvmr", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_SbNxzcvCxgnPCAwqbizvmr;
        [n1.ElementAttribute(TracingId = 100658U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PD5Gw4HKd8mPVOUSnFkEAe", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PD5Gw4HKd8mPVOUSnFkEAe;
        [n1.ElementAttribute(TracingId = 100663U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Bf6vOO5BgIPNsUAgugh8dd", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Bf6vOO5BgIPNsUAgugh8dd;
        [n1.ElementAttribute(TracingId = 100674U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LdnrCC1QOGHOarIsxUI6ON", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LdnrCC1QOGHOarIsxUI6ON;
        [n1.ElementAttribute(TracingId = 100591U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "C7tpoGCrJXLQX7JTQmJBua", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_C7tpoGCrJXLQX7JTQmJBua;
        [n1.ElementAttribute(TracingId = 100580U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Tigllc3wZDAP2UYqaWqZqf", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Tigllc3wZDAP2UYqaWqZqf;
        [n1.ElementAttribute(TracingId = 100576U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NHL983GqvYMMTjwexsli3k", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_NHL983GqvYMMTjwexsli3k;
        [n1.ElementAttribute(TracingId = 100645U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Nq9qXINAYJpM1BQfwr8Ugy", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Nq9qXINAYJpM1BQfwr8Ugy;
        [n1.ElementAttribute(TracingId = 100621U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IhlnilW9nkYNI13ixtOnjM", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_IhlnilW9nkYNI13ixtOnjM;
        [n1.ElementAttribute(TracingId = 100617U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EeG6wKrIDY1Py1FwHGmKYq", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_EeG6wKrIDY1Py1FwHGmKYq;
        [n1.ElementAttribute(TracingId = 100637U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CH1YqmEydzGPoa1yEZdqMi", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CH1YqmEydzGPoa1yEZdqMi;
        [n1.ElementAttribute(TracingId = 100641U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IaqOg9K25AYLTEVlmPqXG4", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_IaqOg9K25AYLTEVlmPqXG4;
        static PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg()
        {
        }

        public PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg other): base(other)
        {
            this.PointEditorControlsData = other.PointEditorControlsData;
            this.__p_OShCFZw2rNEQaKBRwm4bxD = other.__p_OShCFZw2rNEQaKBRwm4bxD;
            this.__p_EsYwfESB2yDPlQd4kwhGk6 = other.__p_EsYwfESB2yDPlQd4kwhGk6;
            this.__p_JhF0m8oWhQYNb9G2taFsXd = other.__p_JhF0m8oWhQYNb9G2taFsXd;
            this.__p_Kl0H8GX8A91Ma0FvwYFFeN = other.__p_Kl0H8GX8A91Ma0FvwYFFeN;
            this.__p_JoxnayoNsgHPMX9bHpQtSC = other.__p_JoxnayoNsgHPMX9bHpQtSC;
            this.__p_K8OMYLmuUBuLlxWxaQMFMW = other.__p_K8OMYLmuUBuLlxWxaQMFMW;
            this.__p_T1wLIFvYIZMMTjWTjUrW6C = other.__p_T1wLIFvYIZMMTjWTjUrW6C;
            this.__p_J6bqF99H5RLP0KkY0kz8Oh = other.__p_J6bqF99H5RLP0KkY0kz8Oh;
            this.__p_SbNxzcvCxgnPCAwqbizvmr = other.__p_SbNxzcvCxgnPCAwqbizvmr;
            this.__p_PD5Gw4HKd8mPVOUSnFkEAe = other.__p_PD5Gw4HKd8mPVOUSnFkEAe;
            this.__p_Bf6vOO5BgIPNsUAgugh8dd = other.__p_Bf6vOO5BgIPNsUAgugh8dd;
            this.__p_LdnrCC1QOGHOarIsxUI6ON = other.__p_LdnrCC1QOGHOarIsxUI6ON;
            this.__p_C7tpoGCrJXLQX7JTQmJBua = other.__p_C7tpoGCrJXLQX7JTQmJBua;
            this.__p_Tigllc3wZDAP2UYqaWqZqf = other.__p_Tigllc3wZDAP2UYqaWqZqf;
            this.__p_NHL983GqvYMMTjwexsli3k = other.__p_NHL983GqvYMMTjwexsli3k;
            this.__p_Nq9qXINAYJpM1BQfwr8Ugy = other.__p_Nq9qXINAYJpM1BQfwr8Ugy;
            this.__p_IhlnilW9nkYNI13ixtOnjM = other.__p_IhlnilW9nkYNI13ixtOnjM;
            this.__p_EeG6wKrIDY1Py1FwHGmKYq = other.__p_EeG6wKrIDY1Py1FwHGmKYq;
            this.__p_CH1YqmEydzGPoa1yEZdqMi = other.__p_CH1YqmEydzGPoa1yEZdqMi;
            this.__p_IaqOg9K25AYLTEVlmPqXG4 = other.__p_IaqOg9K25AYLTEVlmPqXG4;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "PointEditorControlsData", in PointEditorControlsData), n1.CompilationHelper.GetValueOrExisting(values, "__p_OShCFZw2rNEQaKBRwm4bxD", in __p_OShCFZw2rNEQaKBRwm4bxD), n1.CompilationHelper.GetValueOrExisting(values, "__p_EsYwfESB2yDPlQd4kwhGk6", in __p_EsYwfESB2yDPlQd4kwhGk6), n1.CompilationHelper.GetValueOrExisting(values, "__p_JhF0m8oWhQYNb9G2taFsXd", in __p_JhF0m8oWhQYNb9G2taFsXd), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kl0H8GX8A91Ma0FvwYFFeN", in __p_Kl0H8GX8A91Ma0FvwYFFeN), n1.CompilationHelper.GetValueOrExisting(values, "__p_JoxnayoNsgHPMX9bHpQtSC", in __p_JoxnayoNsgHPMX9bHpQtSC), n1.CompilationHelper.GetValueOrExisting(values, "__p_K8OMYLmuUBuLlxWxaQMFMW", in __p_K8OMYLmuUBuLlxWxaQMFMW), n1.CompilationHelper.GetValueOrExisting(values, "__p_T1wLIFvYIZMMTjWTjUrW6C", in __p_T1wLIFvYIZMMTjWTjUrW6C), n1.CompilationHelper.GetValueOrExisting(values, "__p_J6bqF99H5RLP0KkY0kz8Oh", in __p_J6bqF99H5RLP0KkY0kz8Oh), n1.CompilationHelper.GetValueOrExisting(values, "__p_SbNxzcvCxgnPCAwqbizvmr", in __p_SbNxzcvCxgnPCAwqbizvmr), n1.CompilationHelper.GetValueOrExisting(values, "__p_PD5Gw4HKd8mPVOUSnFkEAe", in __p_PD5Gw4HKd8mPVOUSnFkEAe), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bf6vOO5BgIPNsUAgugh8dd", in __p_Bf6vOO5BgIPNsUAgugh8dd), n1.CompilationHelper.GetValueOrExisting(values, "__p_LdnrCC1QOGHOarIsxUI6ON", in __p_LdnrCC1QOGHOarIsxUI6ON), n1.CompilationHelper.GetValueOrExisting(values, "__p_C7tpoGCrJXLQX7JTQmJBua", in __p_C7tpoGCrJXLQX7JTQmJBua), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tigllc3wZDAP2UYqaWqZqf", in __p_Tigllc3wZDAP2UYqaWqZqf), n1.CompilationHelper.GetValueOrExisting(values, "__p_NHL983GqvYMMTjwexsli3k", in __p_NHL983GqvYMMTjwexsli3k), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nq9qXINAYJpM1BQfwr8Ugy", in __p_Nq9qXINAYJpM1BQfwr8Ugy), n1.CompilationHelper.GetValueOrExisting(values, "__p_IhlnilW9nkYNI13ixtOnjM", in __p_IhlnilW9nkYNI13ixtOnjM), n1.CompilationHelper.GetValueOrExisting(values, "__p_EeG6wKrIDY1Py1FwHGmKYq", in __p_EeG6wKrIDY1Py1FwHGmKYq), n1.CompilationHelper.GetValueOrExisting(values, "__p_CH1YqmEydzGPoa1yEZdqMi", in __p_CH1YqmEydzGPoa1yEZdqMi), n1.CompilationHelper.GetValueOrExisting(values, "__p_IaqOg9K25AYLTEVlmPqXG4", in __p_IaqOg9K25AYLTEVlmPqXG4));
        }

        internal PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg __WITH__(n8.PointEditorControlsData_R PointEditorControlsData, n44.MouseState_BNOhaxXysw1MZBzyJMI18t __p_OShCFZw2rNEQaKBRwm4bxD, n31.SelectionRect_U4WhUIJIZ12QZXLRrxVqkU __p_EsYwfESB2yDPlQd4kwhGk6, n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_JhF0m8oWhQYNb9G2taFsXd, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Kl0H8GX8A91Ma0FvwYFFeN, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JoxnayoNsgHPMX9bHpQtSC, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_K8OMYLmuUBuLlxWxaQMFMW, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_T1wLIFvYIZMMTjWTjUrW6C, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_J6bqF99H5RLP0KkY0kz8Oh, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_SbNxzcvCxgnPCAwqbizvmr, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PD5Gw4HKd8mPVOUSnFkEAe, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Bf6vOO5BgIPNsUAgugh8dd, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LdnrCC1QOGHOarIsxUI6ON, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_C7tpoGCrJXLQX7JTQmJBua, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Tigllc3wZDAP2UYqaWqZqf, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_NHL983GqvYMMTjwexsli3k, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Nq9qXINAYJpM1BQfwr8Ugy, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_IhlnilW9nkYNI13ixtOnjM, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_EeG6wKrIDY1Py1FwHGmKYq, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CH1YqmEydzGPoa1yEZdqMi, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_IaqOg9K25AYLTEVlmPqXG4)
        {
            n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = PointEditorControlsData != this.PointEditorControlsData || __p_OShCFZw2rNEQaKBRwm4bxD != this.__p_OShCFZw2rNEQaKBRwm4bxD || __p_EsYwfESB2yDPlQd4kwhGk6 != this.__p_EsYwfESB2yDPlQd4kwhGk6 || __p_JhF0m8oWhQYNb9G2taFsXd != this.__p_JhF0m8oWhQYNb9G2taFsXd || __p_Kl0H8GX8A91Ma0FvwYFFeN != this.__p_Kl0H8GX8A91Ma0FvwYFFeN || __p_JoxnayoNsgHPMX9bHpQtSC != this.__p_JoxnayoNsgHPMX9bHpQtSC || __p_K8OMYLmuUBuLlxWxaQMFMW != this.__p_K8OMYLmuUBuLlxWxaQMFMW || __p_T1wLIFvYIZMMTjWTjUrW6C != this.__p_T1wLIFvYIZMMTjWTjUrW6C || __p_J6bqF99H5RLP0KkY0kz8Oh != this.__p_J6bqF99H5RLP0KkY0kz8Oh || __p_SbNxzcvCxgnPCAwqbizvmr != this.__p_SbNxzcvCxgnPCAwqbizvmr || __p_PD5Gw4HKd8mPVOUSnFkEAe != this.__p_PD5Gw4HKd8mPVOUSnFkEAe || __p_Bf6vOO5BgIPNsUAgugh8dd != this.__p_Bf6vOO5BgIPNsUAgugh8dd || __p_LdnrCC1QOGHOarIsxUI6ON != this.__p_LdnrCC1QOGHOarIsxUI6ON || __p_C7tpoGCrJXLQX7JTQmJBua != this.__p_C7tpoGCrJXLQX7JTQmJBua || __p_Tigllc3wZDAP2UYqaWqZqf != this.__p_Tigllc3wZDAP2UYqaWqZqf || __p_NHL983GqvYMMTjwexsli3k != this.__p_NHL983GqvYMMTjwexsli3k || __p_Nq9qXINAYJpM1BQfwr8Ugy != this.__p_Nq9qXINAYJpM1BQfwr8Ugy || __p_IhlnilW9nkYNI13ixtOnjM != this.__p_IhlnilW9nkYNI13ixtOnjM || __p_EeG6wKrIDY1Py1FwHGmKYq != this.__p_EeG6wKrIDY1Py1FwHGmKYq || __p_CH1YqmEydzGPoa1yEZdqMi != this.__p_CH1YqmEydzGPoa1yEZdqMi || __p_IaqOg9K25AYLTEVlmPqXG4 != this.__p_IaqOg9K25AYLTEVlmPqXG4 ? new PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg(this)
                {PointEditorControlsData = PointEditorControlsData, __p_OShCFZw2rNEQaKBRwm4bxD = __p_OShCFZw2rNEQaKBRwm4bxD, __p_EsYwfESB2yDPlQd4kwhGk6 = __p_EsYwfESB2yDPlQd4kwhGk6, __p_JhF0m8oWhQYNb9G2taFsXd = __p_JhF0m8oWhQYNb9G2taFsXd, __p_Kl0H8GX8A91Ma0FvwYFFeN = __p_Kl0H8GX8A91Ma0FvwYFFeN, __p_JoxnayoNsgHPMX9bHpQtSC = __p_JoxnayoNsgHPMX9bHpQtSC, __p_K8OMYLmuUBuLlxWxaQMFMW = __p_K8OMYLmuUBuLlxWxaQMFMW, __p_T1wLIFvYIZMMTjWTjUrW6C = __p_T1wLIFvYIZMMTjWTjUrW6C, __p_J6bqF99H5RLP0KkY0kz8Oh = __p_J6bqF99H5RLP0KkY0kz8Oh, __p_SbNxzcvCxgnPCAwqbizvmr = __p_SbNxzcvCxgnPCAwqbizvmr, __p_PD5Gw4HKd8mPVOUSnFkEAe = __p_PD5Gw4HKd8mPVOUSnFkEAe, __p_Bf6vOO5BgIPNsUAgugh8dd = __p_Bf6vOO5BgIPNsUAgugh8dd, __p_LdnrCC1QOGHOarIsxUI6ON = __p_LdnrCC1QOGHOarIsxUI6ON, __p_C7tpoGCrJXLQX7JTQmJBua = __p_C7tpoGCrJXLQX7JTQmJBua, __p_Tigllc3wZDAP2UYqaWqZqf = __p_Tigllc3wZDAP2UYqaWqZqf, __p_NHL983GqvYMMTjwexsli3k = __p_NHL983GqvYMMTjwexsli3k, __p_Nq9qXINAYJpM1BQfwr8Ugy = __p_Nq9qXINAYJpM1BQfwr8Ugy, __p_IhlnilW9nkYNI13ixtOnjM = __p_IhlnilW9nkYNI13ixtOnjM, __p_EeG6wKrIDY1Py1FwHGmKYq = __p_EeG6wKrIDY1Py1FwHGmKYq, __p_CH1YqmEydzGPoa1yEZdqMi = __p_CH1YqmEydzGPoa1yEZdqMi, __p_IaqOg9K25AYLTEVlmPqXG4 = __p_IaqOg9K25AYLTEVlmPqXG4} : that_0;
            else
            {
                this.PointEditorControlsData = PointEditorControlsData;
                this.__p_OShCFZw2rNEQaKBRwm4bxD = __p_OShCFZw2rNEQaKBRwm4bxD;
                this.__p_EsYwfESB2yDPlQd4kwhGk6 = __p_EsYwfESB2yDPlQd4kwhGk6;
                this.__p_JhF0m8oWhQYNb9G2taFsXd = __p_JhF0m8oWhQYNb9G2taFsXd;
                this.__p_Kl0H8GX8A91Ma0FvwYFFeN = __p_Kl0H8GX8A91Ma0FvwYFFeN;
                this.__p_JoxnayoNsgHPMX9bHpQtSC = __p_JoxnayoNsgHPMX9bHpQtSC;
                this.__p_K8OMYLmuUBuLlxWxaQMFMW = __p_K8OMYLmuUBuLlxWxaQMFMW;
                this.__p_T1wLIFvYIZMMTjWTjUrW6C = __p_T1wLIFvYIZMMTjWTjUrW6C;
                this.__p_J6bqF99H5RLP0KkY0kz8Oh = __p_J6bqF99H5RLP0KkY0kz8Oh;
                this.__p_SbNxzcvCxgnPCAwqbizvmr = __p_SbNxzcvCxgnPCAwqbizvmr;
                this.__p_PD5Gw4HKd8mPVOUSnFkEAe = __p_PD5Gw4HKd8mPVOUSnFkEAe;
                this.__p_Bf6vOO5BgIPNsUAgugh8dd = __p_Bf6vOO5BgIPNsUAgugh8dd;
                this.__p_LdnrCC1QOGHOarIsxUI6ON = __p_LdnrCC1QOGHOarIsxUI6ON;
                this.__p_C7tpoGCrJXLQX7JTQmJBua = __p_C7tpoGCrJXLQX7JTQmJBua;
                this.__p_Tigllc3wZDAP2UYqaWqZqf = __p_Tigllc3wZDAP2UYqaWqZqf;
                this.__p_NHL983GqvYMMTjwexsli3k = __p_NHL983GqvYMMTjwexsli3k;
                this.__p_Nq9qXINAYJpM1BQfwr8Ugy = __p_Nq9qXINAYJpM1BQfwr8Ugy;
                this.__p_IhlnilW9nkYNI13ixtOnjM = __p_IhlnilW9nkYNI13ixtOnjM;
                this.__p_EeG6wKrIDY1Py1FwHGmKYq = __p_EeG6wKrIDY1Py1FwHGmKYq;
                this.__p_CH1YqmEydzGPoa1yEZdqMi = __p_CH1YqmEydzGPoa1yEZdqMi;
                this.__p_IaqOg9K25AYLTEVlmPqXG4 = __p_IaqOg9K25AYLTEVlmPqXG4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 100760U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CMMCJGkyan8Oixr6sXEyEm", Name = "PointEditorControlsData_R")]
    [n2.SerializableAttribute]
    public class PointEditorControlsData_R : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.PointEditorControlsData_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new PointEditorControlsData_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.PointEditorControlsData_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.PointEditorControlsData_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new PointEditorControlsData_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.PointEditorControlsData_R __DEFAULT__;
        public n8.PointEditorControlsData_R Join(n3.Vector2 Pointer_Position_In, bool Mouse_Pressed_In, n3.RectangleF Selection_In, bool Remove_Selected_In, bool Control_In, bool Shift_In, bool Space_In, bool Hover_Next_In, bool Hover_Previous_In, bool Select_All_In, bool Scale_In, bool Rotate_In, bool Translate_In, bool Undo_In, bool Redo_In)
        {
            n3.Vector2 __auto_0 = Pointer_Position_In;
            bool __auto_1 = Mouse_Pressed_In;
            n3.RectangleF __auto_2 = Selection_In;
            bool __auto_3 = Remove_Selected_In;
            bool __auto_4 = Control_In;
            bool __auto_5 = Shift_In;
            bool __auto_6 = Space_In;
            bool __auto_7 = Hover_Next_In;
            bool __auto_8 = Hover_Previous_In;
            bool __auto_9 = Select_All_In;
            bool __auto_10 = Scale_In;
            bool __auto_11 = Rotate_In;
            bool __auto_12 = Translate_In;
            bool __auto_13 = Undo_In;
            bool __auto_14 = Redo_In;
            n8.PointEditorControlsData_R that_15 = this;
            that_15 = Pointer_Position_In != this.Pointer_Position || Mouse_Pressed_In != this.Mouse_Pressed || !n23.EqualityComparer<n3.RectangleF>.Default.Equals(Selection_In, this.Selection) || Remove_Selected_In != this.Remove_Selected || Control_In != this.Control || Shift_In != this.Shift || Space_In != this.Space || Hover_Next_In != this.Hover_Next || Hover_Previous_In != this.Hover_Previous || Select_All_In != this.Select_All || Scale_In != this.Scale || Rotate_In != this.Rotate || Translate_In != this.Translate || Undo_In != this.Undo || Redo_In != this.Redo ? new PointEditorControlsData_R(this)
            {Pointer_Position = Pointer_Position_In, Mouse_Pressed = Mouse_Pressed_In, Selection = Selection_In, Remove_Selected = Remove_Selected_In, Control = Control_In, Shift = Shift_In, Space = Space_In, Hover_Next = Hover_Next_In, Hover_Previous = Hover_Previous_In, Select_All = Select_All_In, Scale = Scale_In, Rotate = Rotate_In, Translate = Translate_In, Undo = Undo_In, Redo = Redo_In} : that_15;
            return that_15;
        }

        public n8.PointEditorControlsData_R Split(out n3.Vector2 Pointer_Position_Out, out bool Mouse_Pressed_Out, out n3.RectangleF Selection_Out, out bool Remove_Selected_Out, out bool Control_Out, out bool Shift_Out, out bool Space_Out, out bool Hover_Next_Out, out bool Hover_Previous_Out, out bool Select_All_Out, out bool Scale_Out, out bool Rotate_Out, out bool Translate_Out, out bool Undo_Out, out bool Redo_Out)
        {
            n3.Vector2 __auto_0 = this.Pointer_Position;
            bool __auto_1 = this.Mouse_Pressed;
            n3.RectangleF __auto_2 = this.Selection;
            bool __auto_3 = this.Remove_Selected;
            bool __auto_4 = this.Control;
            bool __auto_5 = this.Shift;
            bool __auto_6 = this.Space;
            bool __auto_7 = this.Hover_Next;
            bool __auto_8 = this.Hover_Previous;
            bool __auto_9 = this.Select_All;
            bool __auto_10 = this.Scale;
            bool __auto_11 = this.Rotate;
            bool __auto_12 = this.Translate;
            bool __auto_13 = this.Undo;
            bool __auto_14 = this.Redo;
            Pointer_Position_Out = __auto_0;
            Mouse_Pressed_Out = __auto_1;
            Selection_Out = __auto_2;
            Remove_Selected_Out = __auto_3;
            Control_Out = __auto_4;
            Shift_Out = __auto_5;
            Space_Out = __auto_6;
            Hover_Next_Out = __auto_7;
            Hover_Previous_Out = __auto_8;
            Select_All_Out = __auto_9;
            Scale_Out = __auto_10;
            Rotate_Out = __auto_11;
            Translate_Out = __auto_12;
            Undo_Out = __auto_13;
            Redo_Out = __auto_14;
            return this;
        }

        public n8.PointEditorControlsData_R __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n8.PointEditorControlsData_R that_0 = this;
            this.Pointer_Position = n48._Operations_.CreateDefault();
            this.Mouse_Pressed = false;
            this.Selection = n49._Operations_.CreateDefault();
            this.Remove_Selected = false;
            this.Control = false;
            this.Shift = false;
            this.Select_All = false;
            this.Scale = false;
            this.Rotate = false;
            this.Translate = false;
            this.Undo = false;
            this.Redo = false;
            this.Space = false;
            this.Hover_Next = false;
            this.Hover_Previous = false;
            return that_0;
        }

        public n8.PointEditorControlsData_R __CreateDefault__()
        {
            n8.PointEditorControlsData_R that_0 = this;
            this.Pointer_Position = n48._Operations_.CreateDefault();
            this.Mouse_Pressed = false;
            this.Selection = n49._Operations_.CreateDefault();
            this.Remove_Selected = false;
            this.Control = false;
            this.Shift = false;
            this.Select_All = false;
            this.Scale = false;
            this.Rotate = false;
            this.Translate = false;
            this.Undo = false;
            this.Redo = false;
            this.Space = false;
            this.Hover_Next = false;
            this.Hover_Previous = false;
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

        [n1.ElementAttribute(TracingId = 100762U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "V0X50I5dyBbNro3y9f7SdT", Name = "Pointer Position")]
        public n3.Vector2 Pointer_Position;
        [n1.ElementAttribute(TracingId = 100763U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F2Tix9AdgEfLQn257SMI3G", Name = "Mouse Pressed")]
        public bool Mouse_Pressed;
        [n1.ElementAttribute(TracingId = 100764U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FSS7oevjcd6NU4wUTUqi3w", Name = "Selection")]
        public n3.RectangleF Selection;
        [n1.ElementAttribute(TracingId = 100765U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LvrF37zteuFN9TcDM6iFgz", Name = "Remove Selected")]
        public bool Remove_Selected;
        [n1.ElementAttribute(TracingId = 100766U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HJajbHtvxgHPaR319kaAyh", Name = "Control")]
        public bool Control;
        [n1.ElementAttribute(TracingId = 100767U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PuMrHBMCWp1OBFQTS3hQab", Name = "Shift")]
        public bool Shift;
        [n1.ElementAttribute(TracingId = 100768U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OsMZW7GFD3SNo8CCGUdg9S", Name = "Select All")]
        public bool Select_All;
        [n1.ElementAttribute(TracingId = 100769U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PnIcOsxnZQpNdUcRSrgdNq", Name = "Scale")]
        public bool Scale;
        [n1.ElementAttribute(TracingId = 100770U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LV51BlpsKLeMtBwCmVPYRF", Name = "Rotate")]
        public bool Rotate;
        [n1.ElementAttribute(TracingId = 100771U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JEFDtPxQoNVM8FCwus0hTr", Name = "Translate")]
        public bool Translate;
        [n1.ElementAttribute(TracingId = 100772U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DMQqyptMCi1OSwNgvnhxap", Name = "Undo")]
        public bool Undo;
        [n1.ElementAttribute(TracingId = 100773U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KxFg1xYh2ojMknJynTfll8", Name = "Redo")]
        public bool Redo;
        [n1.ElementAttribute(TracingId = 100812U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EiVC05eCrUVLbumzNB2xIO", Name = "Space")]
        public bool Space;
        [n1.ElementAttribute(TracingId = 100816U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "V0cggoGb79VLLvKociObzs", Name = "Hover Next")]
        public bool Hover_Next;
        [n1.ElementAttribute(TracingId = 100820U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LmGSRf05Vt7PXIMZathn6b", Name = "Hover Previous")]
        public bool Hover_Previous;
        public PointEditorControlsData_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditorControlsData_R(PointEditorControlsData_R other): base(other)
        {
            this.Pointer_Position = other.Pointer_Position;
            this.Mouse_Pressed = other.Mouse_Pressed;
            this.Selection = other.Selection;
            this.Remove_Selected = other.Remove_Selected;
            this.Control = other.Control;
            this.Shift = other.Shift;
            this.Select_All = other.Select_All;
            this.Scale = other.Scale;
            this.Rotate = other.Rotate;
            this.Translate = other.Translate;
            this.Undo = other.Undo;
            this.Redo = other.Redo;
            this.Space = other.Space;
            this.Hover_Next = other.Hover_Next;
            this.Hover_Previous = other.Hover_Previous;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Pointer_Position", in Pointer_Position), n1.CompilationHelper.GetValueOrExisting(values, "Mouse_Pressed", in Mouse_Pressed), n1.CompilationHelper.GetValueOrExisting(values, "Selection", in Selection), n1.CompilationHelper.GetValueOrExisting(values, "Remove_Selected", in Remove_Selected), n1.CompilationHelper.GetValueOrExisting(values, "Control", in Control), n1.CompilationHelper.GetValueOrExisting(values, "Shift", in Shift), n1.CompilationHelper.GetValueOrExisting(values, "Select_All", in Select_All), n1.CompilationHelper.GetValueOrExisting(values, "Scale", in Scale), n1.CompilationHelper.GetValueOrExisting(values, "Rotate", in Rotate), n1.CompilationHelper.GetValueOrExisting(values, "Translate", in Translate), n1.CompilationHelper.GetValueOrExisting(values, "Undo", in Undo), n1.CompilationHelper.GetValueOrExisting(values, "Redo", in Redo), n1.CompilationHelper.GetValueOrExisting(values, "Space", in Space), n1.CompilationHelper.GetValueOrExisting(values, "Hover_Next", in Hover_Next), n1.CompilationHelper.GetValueOrExisting(values, "Hover_Previous", in Hover_Previous));
        }

        internal PointEditorControlsData_R __WITH__(n3.Vector2 Pointer_Position, bool Mouse_Pressed, n3.RectangleF Selection, bool Remove_Selected, bool Control, bool Shift, bool Select_All, bool Scale, bool Rotate, bool Translate, bool Undo, bool Redo, bool Space, bool Hover_Next, bool Hover_Previous)
        {
            n8.PointEditorControlsData_R that_0 = this;
            that_0 = Pointer_Position != this.Pointer_Position || Mouse_Pressed != this.Mouse_Pressed || !n23.EqualityComparer<n3.RectangleF>.Default.Equals(Selection, this.Selection) || Remove_Selected != this.Remove_Selected || Control != this.Control || Shift != this.Shift || Select_All != this.Select_All || Scale != this.Scale || Rotate != this.Rotate || Translate != this.Translate || Undo != this.Undo || Redo != this.Redo || Space != this.Space || Hover_Next != this.Hover_Next || Hover_Previous != this.Hover_Previous ? new PointEditorControlsData_R(this)
            {Pointer_Position = Pointer_Position, Mouse_Pressed = Mouse_Pressed, Selection = Selection, Remove_Selected = Remove_Selected, Control = Control, Shift = Shift, Select_All = Select_All, Scale = Scale, Rotate = Rotate, Translate = Translate, Undo = Undo, Redo = Redo, Space = Space, Hover_Next = Hover_Next, Hover_Previous = Hover_Previous} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 100920U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FemPy9T9iZIOUVBQJQvgkC", Name = "PointEditorState_R")]
    [n2.SerializableAttribute]
    public class PointEditorState_R<T7, T6, T5, T4, T3, T2, T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new PointEditorState_R<T7, T6, T5, T4, T3, T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new PointEditorState_R<T7, T6, T5, T4, T3, T2, T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> __DEFAULT__;
        public n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> Join(n23.IEnumerable<n8.EditablePoint_R<T7>> EditablePoints_In, T6 Pick_Size_In, T5 Editing_In, T4 Scaling_In, T3 Rotation_In, T2 Translation_In, T Offset_In, bool Is_Projection_Space_In, n34.GizmoState_R GizmoState_In)
        {
            n14._Operations_.FromSequence<n8.EditablePoint_R<T7>>(Input_In: EditablePoints_In, Result_Out: out n10.Spread<n8.EditablePoint_R<T7>> Result_0);
            n10.Spread<n8.EditablePoint_R<T7>> __auto_1 = Result_0;
            T6 __auto_2 = Pick_Size_In;
            T5 __auto_3 = Editing_In;
            T4 __auto_4 = Scaling_In;
            T3 __auto_5 = Rotation_In;
            T2 __auto_6 = Translation_In;
            T __auto_7 = Offset_In;
            bool __auto_8 = Is_Projection_Space_In;
            n34.GizmoState_R __auto_9 = GizmoState_In;
            n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> that_10 = this;
            that_10 = Result_0 != this.EditablePoints || !n23.EqualityComparer<T6>.Default.Equals(Pick_Size_In, this.Pick_Size) || !n23.EqualityComparer<T5>.Default.Equals(Editing_In, this.Editing) || !n23.EqualityComparer<T4>.Default.Equals(Scaling_In, this.Scaling) || !n23.EqualityComparer<T3>.Default.Equals(Rotation_In, this.Rotating) || !n23.EqualityComparer<T2>.Default.Equals(Translation_In, this.Translating) || !n23.EqualityComparer<T>.Default.Equals(Offset_In, this.Offset) || Is_Projection_Space_In != this.Is_Projection_Space || GizmoState_In != this.GizmoState ? new PointEditorState_R<T7, T6, T5, T4, T3, T2, T>(this)
            {EditablePoints = Result_0, Pick_Size = Pick_Size_In, Editing = Editing_In, Scaling = Scaling_In, Rotating = Rotation_In, Translating = Translation_In, Offset = Offset_In, Is_Projection_Space = Is_Projection_Space_In, GizmoState = GizmoState_In} : that_10;
            return that_10;
        }

        public n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> Split(out n10.Spread<n8.EditablePoint_R<T7>> EditablePoints_Out, out T6 Pick_Size_Out, out T5 Editing_Out, out T4 Scaling_Out, out T3 Rotation_Out, out T2 Translation_Out, out T Offset_Out, out bool Is_Projection_Space_Out, out n34.GizmoState_R GizmoState_Out)
        {
            n10.Spread<n8.EditablePoint_R<T7>> __auto_0 = this.EditablePoints;
            T6 __auto_1 = this.Pick_Size;
            T5 __auto_2 = this.Editing;
            T4 __auto_3 = this.Scaling;
            T3 __auto_4 = this.Rotating;
            T2 __auto_5 = this.Translating;
            T __auto_6 = this.Offset;
            bool __auto_7 = this.Is_Projection_Space;
            n34.GizmoState_R __auto_8 = this.GizmoState;
            EditablePoints_Out = __auto_0;
            Pick_Size_Out = __auto_1;
            Editing_Out = __auto_2;
            Scaling_Out = __auto_3;
            Rotation_Out = __auto_4;
            Translation_Out = __auto_5;
            Offset_Out = __auto_6;
            Is_Projection_Space_Out = __auto_7;
            GizmoState_Out = __auto_8;
            return this;
        }

        public n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T6 __out_0);
            w_0.CreateDefault(out T5 __out_1);
            w_0.CreateDefault(out T4 __out_2);
            w_0.CreateDefault(out T3 __out_3);
            w_0.CreateDefault(out T2 __out_4);
            w_0.CreateDefault(out T __out_5);
            n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> that_1 = this;
            this.EditablePoints = n14._Operations_.CreateDefault<n8.EditablePoint_R<T7>>();
            this.Pick_Size = __out_0;
            this.Editing = __out_1;
            this.Scaling = __out_2;
            this.Rotating = __out_3;
            this.Translating = __out_4;
            this.Offset = __out_5;
            this.Is_Projection_Space = false;
            this.GizmoState = n34.GizmoState_R.CreateDefault();
            return that_1;
        }

        public n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T6 __out_6);
            w_0.CreateDefault(out T5 __out_7);
            w_0.CreateDefault(out T4 __out_8);
            w_0.CreateDefault(out T3 __out_9);
            w_0.CreateDefault(out T2 __out_10);
            w_0.CreateDefault(out T __out_11);
            n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> that_1 = this;
            this.EditablePoints = n14._Operations_.CreateDefault<n8.EditablePoint_R<T7>>();
            this.Pick_Size = __out_6;
            this.Editing = __out_7;
            this.Scaling = __out_8;
            this.Rotating = __out_9;
            this.Translating = __out_10;
            this.Offset = __out_11;
            this.Is_Projection_Space = false;
            this.GizmoState = n34.GizmoState_R.CreateDefault();
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

        [n1.ElementAttribute(TracingId = 100922U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EMC6lje3FVdLf0jK8yes11", Name = "EditablePoints")]
        public n10.Spread<n8.EditablePoint_R<T7>> EditablePoints;
        [n1.ElementAttribute(TracingId = 100923U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Dg7yuiCCqmWOkt2z8tPMFy", Name = "Pick Size")]
        public T6 Pick_Size;
        [n1.ElementAttribute(TracingId = 100924U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "VxSgssg6oxbPEHN8DyOypK", Name = "Editing")]
        public T5 Editing;
        [n1.ElementAttribute(TracingId = 100925U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "H1NmoR5psaeLS6s5bJOKcb", Name = "Scaling")]
        public T4 Scaling;
        [n1.ElementAttribute(TracingId = 100926U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "O48GO1xiVx1MGHcxZOMYj8", Name = "Rotating")]
        public T3 Rotating;
        [n1.ElementAttribute(TracingId = 100927U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MrDpHevtP1nQEBW59asrAy", Name = "Translating")]
        public T2 Translating;
        [n1.ElementAttribute(TracingId = 100928U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NSNC24N3iNDOpitzcHy1fP", Name = "Offset")]
        public T Offset;
        [n1.ElementAttribute(TracingId = 100973U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NQc25NSd1OyQREXEwPMApF", Name = "Is Projection Space")]
        public bool Is_Projection_Space;
        [n1.ElementAttribute(TracingId = 100977U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TYOIYkFkGe8MyZWrIVDAdH", Name = "GizmoState")]
        public n34.GizmoState_R GizmoState;
        public PointEditorState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditorState_R(PointEditorState_R<T7, T6, T5, T4, T3, T2, T> other): base(other)
        {
            this.EditablePoints = other.EditablePoints;
            this.Pick_Size = other.Pick_Size;
            this.Editing = other.Editing;
            this.Scaling = other.Scaling;
            this.Rotating = other.Rotating;
            this.Translating = other.Translating;
            this.Offset = other.Offset;
            this.Is_Projection_Space = other.Is_Projection_Space;
            this.GizmoState = other.GizmoState;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "EditablePoints", in EditablePoints), n1.CompilationHelper.GetValueOrExisting(values, "Pick_Size", in Pick_Size), n1.CompilationHelper.GetValueOrExisting(values, "Editing", in Editing), n1.CompilationHelper.GetValueOrExisting(values, "Scaling", in Scaling), n1.CompilationHelper.GetValueOrExisting(values, "Rotating", in Rotating), n1.CompilationHelper.GetValueOrExisting(values, "Translating", in Translating), n1.CompilationHelper.GetValueOrExisting(values, "Offset", in Offset), n1.CompilationHelper.GetValueOrExisting(values, "Is_Projection_Space", in Is_Projection_Space), n1.CompilationHelper.GetValueOrExisting(values, "GizmoState", in GizmoState));
        }

        internal PointEditorState_R<T7, T6, T5, T4, T3, T2, T> __WITH__(n10.Spread<n8.EditablePoint_R<T7>> EditablePoints, T6 Pick_Size, T5 Editing, T4 Scaling, T3 Rotating, T2 Translating, T Offset, bool Is_Projection_Space, n34.GizmoState_R GizmoState)
        {
            n8.PointEditorState_R<T7, T6, T5, T4, T3, T2, T> that_0 = this;
            that_0 = EditablePoints != this.EditablePoints || !n23.EqualityComparer<T6>.Default.Equals(Pick_Size, this.Pick_Size) || !n23.EqualityComparer<T5>.Default.Equals(Editing, this.Editing) || !n23.EqualityComparer<T4>.Default.Equals(Scaling, this.Scaling) || !n23.EqualityComparer<T3>.Default.Equals(Rotating, this.Rotating) || !n23.EqualityComparer<T2>.Default.Equals(Translating, this.Translating) || !n23.EqualityComparer<T>.Default.Equals(Offset, this.Offset) || Is_Projection_Space != this.Is_Projection_Space || GizmoState != this.GizmoState ? new PointEditorState_R<T7, T6, T5, T4, T3, T2, T>(this)
            {EditablePoints = EditablePoints, Pick_Size = Pick_Size, Editing = Editing, Scaling = Scaling, Rotating = Rotating, Translating = Translating, Offset = Offset, Is_Projection_Space = Is_Projection_Space, GizmoState = GizmoState} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 101054U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EUrvnFtz38FOfmwUlAfieh", Name = "EditablePoint_R")]
    [n2.SerializableAttribute]
    public class EditablePoint_R<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.EditablePoint_R<T> Create<AdM>(n1.NodeContext Node_Context, T Position_In, int Id_In)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new EditablePoint_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Position_In, Id_In);
        }

        [n6.CreateDefaultAttribute]
        public static n8.EditablePoint_R<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.EditablePoint_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new EditablePoint_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.EditablePoint_R<T> __DEFAULT__;
        public n8.EditablePoint_R<T> SetId()
        {
            return this;
        }

        public n8.EditablePoint_R<T> DeSelect()
        {
            bool __pad_RaZSEQ9H35JOBPRjiU2Vxo_0 = __slot_RaZSEQ9H35JOBPRjiU2Vxo;
            bool __auto_1 = __pad_RaZSEQ9H35JOBPRjiU2Vxo_0;
            n8.EditablePoint_R<T> that_2 = this;
            that_2 = __pad_RaZSEQ9H35JOBPRjiU2Vxo_0 != this.Selected ? new EditablePoint_R<T>(this)
            {Selected = __pad_RaZSEQ9H35JOBPRjiU2Vxo_0} : that_2;
            return that_2;
        }

        public n8.EditablePoint_R<T> Select()
        {
            bool __pad_Q6eeXrJVNT2PCcJibyUuxY_0 = __slot_Q6eeXrJVNT2PCcJibyUuxY;
            bool __auto_1 = this.Locked;
            bool Apply_2 = true;
            var Output_3 = __auto_1;
            if (Apply_2)
            {
                var Output_4 = !__auto_1;
                Output_3 = Output_4;
            }

            bool Apply_5 = true;
            var Output_6 = __pad_Q6eeXrJVNT2PCcJibyUuxY_0;
            if (Apply_5)
            {
                var Output_7 = __pad_Q6eeXrJVNT2PCcJibyUuxY_0 && Output_3;
                Output_6 = Output_7;
            }

            bool __auto_8 = Output_6;
            n8.EditablePoint_R<T> that_9 = this;
            that_9 = Output_6 != this.Selected ? new EditablePoint_R<T>(this)
            {Selected = Output_6} : that_9;
            return that_9;
        }

        public n8.EditablePoint_R<T> ToggleSelection()
        {
            bool __auto_0 = this.Selected;
            bool Apply_1 = true;
            var Output_2 = __auto_0;
            if (Apply_1)
            {
                var Output_3 = !__auto_0;
                Output_2 = Output_3;
            }

            bool __auto_4 = Output_2;
            n8.EditablePoint_R<T> that_5 = this;
            that_5 = Output_2 != this.Selected ? new EditablePoint_R<T>(this)
            {Selected = Output_2} : that_5;
            return that_5;
        }

        public n8.EditablePoint_R<T> GetPosition(out T Position_Out)
        {
            T __auto_0 = this.Position;
            Position_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> Unlock()
        {
            bool __pad_MQ8A3nCnc6JNrXNbmvrVtO_0 = __slot_MQ8A3nCnc6JNrXNbmvrVtO;
            bool __auto_1 = __pad_MQ8A3nCnc6JNrXNbmvrVtO_0;
            n8.EditablePoint_R<T> that_2 = this;
            that_2 = __pad_MQ8A3nCnc6JNrXNbmvrVtO_0 != this.Locked ? new EditablePoint_R<T>(this)
            {Locked = __pad_MQ8A3nCnc6JNrXNbmvrVtO_0} : that_2;
            return that_2;
        }

        public n8.EditablePoint_R<T> Lock()
        {
            bool __pad_BzY3l73BJ3PPSSPh9LsfUv_0 = __slot_BzY3l73BJ3PPSSPh9LsfUv;
            bool __auto_1 = __pad_BzY3l73BJ3PPSSPh9LsfUv_0;
            n8.EditablePoint_R<T> that_2 = this;
            that_2 = __pad_BzY3l73BJ3PPSSPh9LsfUv_0 != this.Locked ? new EditablePoint_R<T>(this)
            {Locked = __pad_BzY3l73BJ3PPSSPh9LsfUv_0} : that_2;
            return that_2;
        }

        public n8.EditablePoint_R<T> GetSelected(out bool Selected_Out)
        {
            bool __auto_0 = this.Selected;
            Selected_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> SetPosition(T Position_In)
        {
            T __auto_0 = Position_In;
            n8.EditablePoint_R<T> that_1 = this;
            that_1 = !n23.EqualityComparer<T>.Default.Equals(Position_In, this.Position) ? new EditablePoint_R<T>(this)
            {Position = Position_In} : that_1;
            return that_1;
        }

        public n8.EditablePoint_R<T> SetLocked(bool Locked_In)
        {
            bool __auto_0 = Locked_In;
            n8.EditablePoint_R<T> that_1 = this;
            that_1 = Locked_In != this.Locked ? new EditablePoint_R<T>(this)
            {Locked = Locked_In} : that_1;
            return that_1;
        }

        public n8.EditablePoint_R<T> SetHovered(bool Hovered_In)
        {
            bool __auto_0 = Hovered_In;
            n8.EditablePoint_R<T> that_1 = this;
            that_1 = Hovered_In != this.Hovered ? new EditablePoint_R<T>(this)
            {Hovered = Hovered_In} : that_1;
            return that_1;
        }

        public n8.EditablePoint_R<T> SetSelectionModifier(int Modifier_In)
        {
            int __auto_0 = Modifier_In;
            n8.EditablePoint_R<T> that_1 = this;
            that_1 = Modifier_In != this.SelectionModifier ? new EditablePoint_R<T>(this)
            {SelectionModifier = Modifier_In} : that_1;
            return that_1;
        }

        public n8.EditablePoint_R<T> Update<AdM>(n3.Matrix Matrix_In)
            where AdM : struct, n53.IAdaptiveToXYZ<T>
        {
            var w_0 = default(AdM);
            n3.Vector2 __pad_NJp267h2DoFOlgWmcmIZBw_1 = __slot_NJp267h2DoFOlgWmcmIZBw;
            T __auto_2 = this.Position;
            n3.Vector2 Center_3 = n48._Operations_.CreateDefault();
            var Result_4 = n46.RectangleNodes.FromCenterSize(center: ref Center_3, size: ref __pad_NJp267h2DoFOlgWmcmIZBw_1);
            var Output_5 = new n46.ViewportF(bounds: Result_4);
            w_0.ToXYZ(Vector_In: __auto_2, Output_Out: out n3.Vector3 Output_6);
            Output_5.Project(source: ref Output_6, matrix: ref Matrix_In, vector: out n3.Vector3 Vector_7);
            n46.Vector3Nodes.Vector(input: ref Vector_7, x: out float X_8, y: out float Y_9, z: out float Z_10);
            var Output_11 = new n3.Vector2(x: X_8, y: Y_9);
            n3.Vector2 __auto_12 = Output_11;
            n8.EditablePoint_R<T> that_13 = this;
            that_13 = Output_11 != this.ProjectedPosition ? new EditablePoint_R<T>(this)
            {ProjectedPosition = Output_11} : that_13;
            return that_13;
        }

        public n8.EditablePoint_R<T> GetLocked(out bool Locked_Out)
        {
            bool __auto_0 = this.Locked;
            Locked_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> GetProjectedPosition(out n3.Vector2 Position_Out)
        {
            n3.Vector2 __auto_0 = this.ProjectedPosition;
            Position_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> GetHovered(out bool Hovered_Out)
        {
            bool __auto_0 = this.Hovered;
            Hovered_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> GetSelectionModifier(out int Modifier_Out)
        {
            int __auto_0 = this.SelectionModifier;
            Modifier_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> GetId(out int Id_Out)
        {
            int __auto_0 = this.Id;
            Id_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> Split(out T Position_Out, out bool Locked_Out, out bool Selected_Out, out bool Hovered_Out, out bool KeyHovered_Out, out int SelectionModifier_Out, out int Id_Out)
        {
            T __auto_0 = this.Position;
            bool __auto_1 = this.Locked;
            bool __auto_2 = this.Selected;
            bool __auto_3 = this.Hovered;
            bool __auto_4 = this.KeyHovered;
            int __auto_5 = this.SelectionModifier;
            int __auto_6 = this.Id;
            Position_Out = __auto_0;
            Locked_Out = __auto_1;
            Selected_Out = __auto_2;
            Hovered_Out = __auto_3;
            KeyHovered_Out = __auto_4;
            SelectionModifier_Out = __auto_5;
            Id_Out = __auto_6;
            return this;
        }

        public n8.EditablePoint_R<T> Join(T Position_In, bool Locked_In, bool Selected_In, bool Hovered_In, bool KeyHovered_In, int SelectionModifier_In, int Id_In)
        {
            T __auto_0 = Position_In;
            bool __auto_1 = Locked_In;
            bool __auto_2 = Selected_In;
            bool __auto_3 = Hovered_In;
            bool __auto_4 = KeyHovered_In;
            int __auto_5 = SelectionModifier_In;
            int __auto_6 = Id_In;
            n8.EditablePoint_R<T> that_7 = this;
            that_7 = !n23.EqualityComparer<T>.Default.Equals(Position_In, this.Position) || Locked_In != this.Locked || Selected_In != this.Selected || Hovered_In != this.Hovered || KeyHovered_In != this.KeyHovered || SelectionModifier_In != this.SelectionModifier || Id_In != this.Id ? new EditablePoint_R<T>(this)
            {Position = Position_In, Locked = Locked_In, Selected = Selected_In, Hovered = Hovered_In, KeyHovered = KeyHovered_In, SelectionModifier = SelectionModifier_In, Id = Id_In} : that_7;
            return that_7;
        }

        public n8.EditablePoint_R<T> SetKeyHovered(bool Hovered_In)
        {
            bool __auto_0 = Hovered_In;
            n8.EditablePoint_R<T> that_1 = this;
            that_1 = Hovered_In != this.KeyHovered ? new EditablePoint_R<T>(this)
            {KeyHovered = Hovered_In} : that_1;
            return that_1;
        }

        public n8.EditablePoint_R<T> GetKeyHovered(out bool Hovered_Out)
        {
            bool __auto_0 = this.KeyHovered;
            Hovered_Out = __auto_0;
            return this;
        }

        public n8.EditablePoint_R<T> __Create__<AdM>(n1.NodeContext Node_Context, T Position_In, int Id_In)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_12);
            T __auto_1 = Position_In;
            int __auto_2 = Id_In;
            n8.EditablePoint_R<T> that_3 = this;
            this.Position = Position_In;
            this.Locked = false;
            this.Selected = false;
            this.Hovered = false;
            this.ProjectedPosition = n48._Operations_.CreateDefault();
            this.SelectionModifier = 0;
            this.Id = Id_In;
            this.KeyHovered = false;
            return that_3;
        }

        public n8.EditablePoint_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_13);
            n8.EditablePoint_R<T> that_1 = this;
            this.Position = __out_13;
            this.Locked = false;
            this.Selected = false;
            this.Hovered = false;
            this.ProjectedPosition = n48._Operations_.CreateDefault();
            this.SelectionModifier = 0;
            this.Id = 0;
            this.KeyHovered = false;
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

        [n1.ElementAttribute(TracingId = 101056U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "ABbFAwB7d2ENpaNcdqG3vb", Name = "Position")]
        public T Position;
        [n1.ElementAttribute(TracingId = 101057U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "B8GaEsrWGn4P66redWg6Us", Name = "Locked")]
        public bool Locked;
        [n1.ElementAttribute(TracingId = 101058U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BRNUxnWcCSHPkcVupRj70b", Name = "Selected")]
        public bool Selected;
        [n1.ElementAttribute(TracingId = 101059U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SCpUlgZDBnVL7hzf1LJXcH", Name = "Hovered")]
        public bool Hovered;
        [n1.ElementAttribute(TracingId = 101063U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BOPIqTiFHdPLXdpVxK7ZnB", Name = "ProjectedPosition")]
        public n3.Vector2 ProjectedPosition;
        [n1.ElementAttribute(TracingId = 101065U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "APBWxb0YgmsMc7z4lbPpdh", Name = "SelectionModifier")]
        public int SelectionModifier;
        [n1.ElementAttribute(TracingId = 101068U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GMZJDDoiaKjL95NcvaN6H5", Name = "Id")]
        public int Id;
        [n1.ElementAttribute(TracingId = 101184U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Q6eeXrJVNT2PCcJibyUuxY", Name = "__slot_Q6eeXrJVNT2PCcJibyUuxY")]
        public static bool __slot_Q6eeXrJVNT2PCcJibyUuxY = true;
        [n1.ElementAttribute(TracingId = 101186U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RaZSEQ9H35JOBPRjiU2Vxo", Name = "__slot_RaZSEQ9H35JOBPRjiU2Vxo")]
        public static bool __slot_RaZSEQ9H35JOBPRjiU2Vxo = false;
        [n1.ElementAttribute(TracingId = 101190U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NJp267h2DoFOlgWmcmIZBw", Name = "__slot_NJp267h2DoFOlgWmcmIZBw")]
        public static n3.Vector2 __slot_NJp267h2DoFOlgWmcmIZBw = n1.CompilationHelper.Deserialize<n3.Vector2>("2, -2", false, "RMDMfKmnIrVPStLdWe8u30", "NJp267h2DoFOlgWmcmIZBw");
        [n1.ElementAttribute(TracingId = 101192U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BzY3l73BJ3PPSSPh9LsfUv", Name = "__slot_BzY3l73BJ3PPSSPh9LsfUv")]
        public static bool __slot_BzY3l73BJ3PPSSPh9LsfUv = true;
        [n1.ElementAttribute(TracingId = 101195U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MQ8A3nCnc6JNrXNbmvrVtO", Name = "__slot_MQ8A3nCnc6JNrXNbmvrVtO")]
        public static bool __slot_MQ8A3nCnc6JNrXNbmvrVtO = false;
        [n1.ElementAttribute(TracingId = 101330U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ulftl7QgC5TNumCbMM6rZo", Name = "KeyHovered")]
        public bool KeyHovered;
        static EditablePoint_R()
        {
        }

        public EditablePoint_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal EditablePoint_R(EditablePoint_R<T> other): base(other)
        {
            this.Position = other.Position;
            this.Locked = other.Locked;
            this.Selected = other.Selected;
            this.Hovered = other.Hovered;
            this.ProjectedPosition = other.ProjectedPosition;
            this.SelectionModifier = other.SelectionModifier;
            this.Id = other.Id;
            this.KeyHovered = other.KeyHovered;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Locked", in Locked), n1.CompilationHelper.GetValueOrExisting(values, "Selected", in Selected), n1.CompilationHelper.GetValueOrExisting(values, "Hovered", in Hovered), n1.CompilationHelper.GetValueOrExisting(values, "ProjectedPosition", in ProjectedPosition), n1.CompilationHelper.GetValueOrExisting(values, "SelectionModifier", in SelectionModifier), n1.CompilationHelper.GetValueOrExisting(values, "Id", in Id), n1.CompilationHelper.GetValueOrExisting(values, "KeyHovered", in KeyHovered));
        }

        internal EditablePoint_R<T> __WITH__(T Position, bool Locked, bool Selected, bool Hovered, n3.Vector2 ProjectedPosition, int SelectionModifier, int Id, bool KeyHovered)
        {
            n8.EditablePoint_R<T> that_0 = this;
            that_0 = !n23.EqualityComparer<T>.Default.Equals(Position, this.Position) || Locked != this.Locked || Selected != this.Selected || Hovered != this.Hovered || ProjectedPosition != this.ProjectedPosition || SelectionModifier != this.SelectionModifier || Id != this.Id || KeyHovered != this.KeyHovered ? new EditablePoint_R<T>(this)
            {Position = Position, Locked = Locked, Selected = Selected, Hovered = Hovered, ProjectedPosition = ProjectedPosition, SelectionModifier = SelectionModifier, Id = Id, KeyHovered = KeyHovered} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 101525U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BkvtkbxYthfP1wcZBRpDLX", Name = "BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX")]
    [n2.SerializableAttribute]
    public class BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX Create(n1.NodeContext Node_Context)
        {
            var instance = new BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX CreateDefault()
        {
            var instance = new BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX Join(n43.IKeyboard Keyboard_In, n43.IMouse Mouse_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControl_Out)
        {
            n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> __auto_0 = this.BezierEditorControl;
            string __pad_EzbAPnA4pzvLMAoQmZC0Ed_1 = __slot_EzbAPnA4pzvLMAoQmZC0Ed;
            string __pad_DjasGxDxHAoMFaoN2iLu6S_2 = __slot_DjasGxDxHAoMFaoN2iLu6S;
            string __pad_PjTScGNY1pvQAdYDFiYVwt_3 = __slot_PjTScGNY1pvQAdYDFiYVwt;
            string __pad_G036q3sd4D4Lw6h1xWYHpD_4 = __slot_G036q3sd4D4Lw6h1xWYHpD;
            string __pad_FJzOgxvEA0FQMFfavYbe5v_5 = __slot_FJzOgxvEA0FQMFfavYbe5v;
            string __pad_PhM0W24iP1HPizcHcQA8GF_6 = __slot_PhM0W24iP1HPizcHcQA8GF;
            string __pad_Ew4RzBjZtEZPqmBFY29sbV_7 = __slot_Ew4RzBjZtEZPqmBFY29sbV;
            var Output_9 = this.__p_BhunjH1pM0XLzwfpay7uKZ.Join(Mouse_Device_In: Mouse_In, Keyboard_Device_In: Keyboard_In, Enabled_In: Enabled_In, PointEditor_Controls_Out: out n8.PointEditorControlsData_R PointEditor_Controls_8);
            var Output_11 = this.__p_N3xdSOVPKQrMqDNsGJWZ4F.Update(Keyboard_Device_In: Keyboard_In, Pressed_Keys_Out: out n40.ImmutableHashSet<n39.Keys> Pressed_Keys_10);
            var Output_13 = this.__p_SQZ9vfqsDjnQNhCqjjXbzh.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_EzbAPnA4pzvLMAoQmZC0Ed_1, Is_Down_Out: out bool Is_Down_12);
            var Output_16 = this.__p_RDyF4QQYuYAPs35wb7WqUK.Update(Value_In: Is_Down_12, Up_Edge_Out: out bool Up_Edge_14, Down_Edge_Out: out bool Down_Edge_15);
            var Output_18 = this.__p_TVtqls4eV0GOQwdW3CTodN.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_PjTScGNY1pvQAdYDFiYVwt_3, Is_Down_Out: out bool Is_Down_17);
            var Output_21 = this.__p_OvoTG4BKVNOPLcxxmTEjBj.Update(Value_In: Is_Down_17, Up_Edge_Out: out bool Up_Edge_19, Down_Edge_Out: out bool Down_Edge_20);
            var Output_23 = this.__p_CLwLYjNPgmcM9DxETp9tQC.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_G036q3sd4D4Lw6h1xWYHpD_4, Is_Down_Out: out bool Is_Down_22);
            var Output_26 = this.__p_FSQ5OZEkWMHMKE9UUzNdRE.Update(Value_In: Is_Down_22, Up_Edge_Out: out bool Up_Edge_24, Down_Edge_Out: out bool Down_Edge_25);
            var Output_28 = this.__p_F7tqNXlrfanO3kMHv5gFDo.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_FJzOgxvEA0FQMFfavYbe5v_5, Is_Down_Out: out bool Is_Down_27);
            var Output_31 = this.__p_Rrov15gXRVJPYHMJLrH8GS.Update(Value_In: Is_Down_27, Up_Edge_Out: out bool Up_Edge_29, Down_Edge_Out: out bool Down_Edge_30);
            var Output_33 = this.__p_GYwKxmXojMlMZPK1IIUIMl.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_DjasGxDxHAoMFaoN2iLu6S_2, Is_Down_Out: out bool Is_Down_32);
            var Output_35 = this.__p_CCVLHkBFzLkN5ucywJFjXD.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_PhM0W24iP1HPizcHcQA8GF_6, Is_Down_Out: out bool Is_Down_34);
            var Output_38 = this.__p_CJaaR7X5HXSME02UDZIDuE.Update(Value_In: Is_Down_34, Up_Edge_Out: out bool Up_Edge_36, Down_Edge_Out: out bool Down_Edge_37);
            var Output_40 = this.__p_TuyJXjpXJWZNc1UeXfUoBV.Update(Keys_In: Pressed_Keys_10, Key_Name_In: __pad_Ew4RzBjZtEZPqmBFY29sbV_7, Is_Down_Out: out bool Is_Down_39);
            var Output_41 = __auto_0;
            if (Enabled_In)
            {
                Output_41 = __auto_0.Join(Corner_In: Up_Edge_14, Corner_With_Handles_In: Up_Edge_19, Smooth_In: Up_Edge_24, Smooth_Symmetric_In: Up_Edge_29, Find_Point_on_Curve_In: Is_Down_32, PointEditorControls_In: PointEditor_Controls_8, Hover_Control_In: Up_Edge_36, Force_Selection_In: Is_Down_39);
            }

            bool __pad_GlWPxAplozoQFvmL7OcJuh_42 = Up_Edge_14;
            n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> __auto_43 = Output_41;
            BezierEditorControl_Out = Output_41;
            n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX that_44 = this;
            if (this.__GetContext__().IsImmutable)
                that_44 = Output_9 != this.__p_BhunjH1pM0XLzwfpay7uKZ || Output_11 != this.__p_N3xdSOVPKQrMqDNsGJWZ4F || Output_13 != this.__p_SQZ9vfqsDjnQNhCqjjXbzh || Output_16 != this.__p_RDyF4QQYuYAPs35wb7WqUK || Output_18 != this.__p_TVtqls4eV0GOQwdW3CTodN || Output_21 != this.__p_OvoTG4BKVNOPLcxxmTEjBj || Output_23 != this.__p_CLwLYjNPgmcM9DxETp9tQC || Output_26 != this.__p_FSQ5OZEkWMHMKE9UUzNdRE || Output_28 != this.__p_F7tqNXlrfanO3kMHv5gFDo || Output_31 != this.__p_Rrov15gXRVJPYHMJLrH8GS || Output_33 != this.__p_GYwKxmXojMlMZPK1IIUIMl || Output_35 != this.__p_CCVLHkBFzLkN5ucywJFjXD || Output_38 != this.__p_CJaaR7X5HXSME02UDZIDuE || Output_40 != this.__p_TuyJXjpXJWZNc1UeXfUoBV || Up_Edge_14 != this.__slot_GlWPxAplozoQFvmL7OcJuh || Output_41 != this.BezierEditorControl ? new BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(this)
                {__p_BhunjH1pM0XLzwfpay7uKZ = Output_9, __p_N3xdSOVPKQrMqDNsGJWZ4F = Output_11, __p_SQZ9vfqsDjnQNhCqjjXbzh = Output_13, __p_RDyF4QQYuYAPs35wb7WqUK = Output_16, __p_TVtqls4eV0GOQwdW3CTodN = Output_18, __p_OvoTG4BKVNOPLcxxmTEjBj = Output_21, __p_CLwLYjNPgmcM9DxETp9tQC = Output_23, __p_FSQ5OZEkWMHMKE9UUzNdRE = Output_26, __p_F7tqNXlrfanO3kMHv5gFDo = Output_28, __p_Rrov15gXRVJPYHMJLrH8GS = Output_31, __p_GYwKxmXojMlMZPK1IIUIMl = Output_33, __p_CCVLHkBFzLkN5ucywJFjXD = Output_35, __p_CJaaR7X5HXSME02UDZIDuE = Output_38, __p_TuyJXjpXJWZNc1UeXfUoBV = Output_40, __slot_GlWPxAplozoQFvmL7OcJuh = Up_Edge_14, BezierEditorControl = Output_41} : that_44;
            else
            {
                this.__p_BhunjH1pM0XLzwfpay7uKZ = Output_9;
                this.__p_N3xdSOVPKQrMqDNsGJWZ4F = Output_11;
                this.__p_SQZ9vfqsDjnQNhCqjjXbzh = Output_13;
                this.__p_RDyF4QQYuYAPs35wb7WqUK = Output_16;
                this.__p_TVtqls4eV0GOQwdW3CTodN = Output_18;
                this.__p_OvoTG4BKVNOPLcxxmTEjBj = Output_21;
                this.__p_CLwLYjNPgmcM9DxETp9tQC = Output_23;
                this.__p_FSQ5OZEkWMHMKE9UUzNdRE = Output_26;
                this.__p_F7tqNXlrfanO3kMHv5gFDo = Output_28;
                this.__p_Rrov15gXRVJPYHMJLrH8GS = Output_31;
                this.__p_GYwKxmXojMlMZPK1IIUIMl = Output_33;
                this.__p_CCVLHkBFzLkN5ucywJFjXD = Output_35;
                this.__p_CJaaR7X5HXSME02UDZIDuE = Output_38;
                this.__p_TuyJXjpXJWZNc1UeXfUoBV = Output_40;
                this.__slot_GlWPxAplozoQFvmL7OcJuh = Up_Edge_14;
                this.BezierEditorControl = Output_41;
            }

            return that_44;
        }

        public n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "N3xdSOVPKQrMqDNsGJWZ4F", 101564U);
            var Output_1 = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "SQZ9vfqsDjnQNhCqjjXbzh", 101571U);
            var Output_3 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "RDyF4QQYuYAPs35wb7WqUK", 101580U);
            var Output_5 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "OvoTG4BKVNOPLcxxmTEjBj", 101589U);
            var Output_7 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "TVtqls4eV0GOQwdW3CTodN", 101595U);
            var Output_9 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "GYwKxmXojMlMZPK1IIUIMl", 101603U);
            var Output_11 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "BhunjH1pM0XLzwfpay7uKZ", 101632U);
            var Output_13 = n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CLwLYjNPgmcM9DxETp9tQC", 101641U);
            var Output_15 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "FSQ5OZEkWMHMKE9UUzNdRE", 101648U);
            var Output_17 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "Rrov15gXRVJPYHMJLrH8GS", 101655U);
            var Output_19 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "F7tqNXlrfanO3kMHv5gFDo", 101662U);
            var Output_21 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CCVLHkBFzLkN5ucywJFjXD", 101683U);
            var Output_23 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "CJaaR7X5HXSME02UDZIDuE", 101690U);
            var Output_25 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("RMDMfKmnIrVPStLdWe8u30", "TuyJXjpXJWZNc1UeXfUoBV", 101702U);
            var Output_27 = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_26);
            n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX that_28 = this;
            this.BezierEditorControl = n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__slot_GlWPxAplozoQFvmL7OcJuh = false;
            this.__p_N3xdSOVPKQrMqDNsGJWZ4F = Output_1;
            this.__p_SQZ9vfqsDjnQNhCqjjXbzh = Output_3;
            this.__p_RDyF4QQYuYAPs35wb7WqUK = Output_5;
            this.__p_OvoTG4BKVNOPLcxxmTEjBj = Output_7;
            this.__p_TVtqls4eV0GOQwdW3CTodN = Output_9;
            this.__p_GYwKxmXojMlMZPK1IIUIMl = Output_11;
            this.__p_BhunjH1pM0XLzwfpay7uKZ = Output_13;
            this.__p_CLwLYjNPgmcM9DxETp9tQC = Output_15;
            this.__p_FSQ5OZEkWMHMKE9UUzNdRE = Output_17;
            this.__p_Rrov15gXRVJPYHMJLrH8GS = Output_19;
            this.__p_F7tqNXlrfanO3kMHv5gFDo = Output_21;
            this.__p_CCVLHkBFzLkN5ucywJFjXD = Output_23;
            this.__p_CJaaR7X5HXSME02UDZIDuE = Output_25;
            this.__p_TuyJXjpXJWZNc1UeXfUoBV = Output_27;
            return that_28;
        }

        public n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX __CreateDefault__()
        {
            n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX that_0 = this;
            this.BezierEditorControl = n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R>.CreateDefault<n29.__AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30>();
            this.__slot_GlWPxAplozoQFvmL7OcJuh = false;
            this.__p_BhunjH1pM0XLzwfpay7uKZ = n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg.CreateDefault();
            this.__p_N3xdSOVPKQrMqDNsGJWZ4F = n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_SQZ9vfqsDjnQNhCqjjXbzh = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_RDyF4QQYuYAPs35wb7WqUK = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_TVtqls4eV0GOQwdW3CTodN = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_OvoTG4BKVNOPLcxxmTEjBj = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_CLwLYjNPgmcM9DxETp9tQC = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_FSQ5OZEkWMHMKE9UUzNdRE = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_F7tqNXlrfanO3kMHv5gFDo = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Rrov15gXRVJPYHMJLrH8GS = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_GYwKxmXojMlMZPK1IIUIMl = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_CCVLHkBFzLkN5ucywJFjXD = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_CJaaR7X5HXSME02UDZIDuE = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_TuyJXjpXJWZNc1UeXfUoBV = n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BhunjH1pM0XLzwfpay7uKZ);
            n1.CompilationHelper.SafeDispose(this.__p_N3xdSOVPKQrMqDNsGJWZ4F);
            n1.CompilationHelper.SafeDispose(this.__p_SQZ9vfqsDjnQNhCqjjXbzh);
            n1.CompilationHelper.SafeDispose(this.__p_RDyF4QQYuYAPs35wb7WqUK);
            n1.CompilationHelper.SafeDispose(this.__p_TVtqls4eV0GOQwdW3CTodN);
            n1.CompilationHelper.SafeDispose(this.__p_OvoTG4BKVNOPLcxxmTEjBj);
            n1.CompilationHelper.SafeDispose(this.__p_CLwLYjNPgmcM9DxETp9tQC);
            n1.CompilationHelper.SafeDispose(this.__p_FSQ5OZEkWMHMKE9UUzNdRE);
            n1.CompilationHelper.SafeDispose(this.__p_F7tqNXlrfanO3kMHv5gFDo);
            n1.CompilationHelper.SafeDispose(this.__p_Rrov15gXRVJPYHMJLrH8GS);
            n1.CompilationHelper.SafeDispose(this.__p_GYwKxmXojMlMZPK1IIUIMl);
            n1.CompilationHelper.SafeDispose(this.__p_CCVLHkBFzLkN5ucywJFjXD);
            n1.CompilationHelper.SafeDispose(this.__p_CJaaR7X5HXSME02UDZIDuE);
            n1.CompilationHelper.SafeDispose(this.__p_TuyJXjpXJWZNc1UeXfUoBV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 101527U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CO0mqGgfFODOgiNEPHAg2z", Name = "BezierEditorControl")]
        public n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControl;
        [n1.ElementAttribute(TracingId = 101542U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EzbAPnA4pzvLMAoQmZC0Ed", Name = "__slot_EzbAPnA4pzvLMAoQmZC0Ed")]
        public static string __slot_EzbAPnA4pzvLMAoQmZC0Ed = "D1";
        [n1.ElementAttribute(TracingId = 101543U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PjTScGNY1pvQAdYDFiYVwt", Name = "__slot_PjTScGNY1pvQAdYDFiYVwt")]
        public static string __slot_PjTScGNY1pvQAdYDFiYVwt = "D2";
        [n1.ElementAttribute(TracingId = 101548U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "DjasGxDxHAoMFaoN2iLu6S", Name = "__slot_DjasGxDxHAoMFaoN2iLu6S")]
        public static string __slot_DjasGxDxHAoMFaoN2iLu6S = "I";
        [n1.ElementAttribute(TracingId = 101553U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "G036q3sd4D4Lw6h1xWYHpD", Name = "__slot_G036q3sd4D4Lw6h1xWYHpD")]
        public static string __slot_G036q3sd4D4Lw6h1xWYHpD = "D3";
        [n1.ElementAttribute(TracingId = 101557U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FJzOgxvEA0FQMFfavYbe5v", Name = "__slot_FJzOgxvEA0FQMFfavYbe5v")]
        public static string __slot_FJzOgxvEA0FQMFfavYbe5v = "D4";
        [n1.ElementAttribute(TracingId = 101678U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GlWPxAplozoQFvmL7OcJuh", Name = "__slot_GlWPxAplozoQFvmL7OcJuh")]
        public bool __slot_GlWPxAplozoQFvmL7OcJuh;
        [n1.ElementAttribute(TracingId = 101679U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "PhM0W24iP1HPizcHcQA8GF", Name = "__slot_PhM0W24iP1HPizcHcQA8GF")]
        public static string __slot_PhM0W24iP1HPizcHcQA8GF = "W";
        [n1.ElementAttribute(TracingId = 101698U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ew4RzBjZtEZPqmBFY29sbV", Name = "__slot_Ew4RzBjZtEZPqmBFY29sbV")]
        public static string __slot_Ew4RzBjZtEZPqmBFY29sbV = "F";
        [n1.ElementAttribute(TracingId = 101632U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BhunjH1pM0XLzwfpay7uKZ", Name = "PointEditorControls", IsManaged = true, IsAutoGenerated = true)]
        public n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg __p_BhunjH1pM0XLzwfpay7uKZ;
        [n1.ElementAttribute(TracingId = 101564U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "N3xdSOVPKQrMqDNsGJWZ4F", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_N3xdSOVPKQrMqDNsGJWZ4F;
        [n1.ElementAttribute(TracingId = 101571U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "SQZ9vfqsDjnQNhCqjjXbzh", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_SQZ9vfqsDjnQNhCqjjXbzh;
        [n1.ElementAttribute(TracingId = 101580U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RDyF4QQYuYAPs35wb7WqUK", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_RDyF4QQYuYAPs35wb7WqUK;
        [n1.ElementAttribute(TracingId = 101595U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TVtqls4eV0GOQwdW3CTodN", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_TVtqls4eV0GOQwdW3CTodN;
        [n1.ElementAttribute(TracingId = 101589U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "OvoTG4BKVNOPLcxxmTEjBj", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OvoTG4BKVNOPLcxxmTEjBj;
        [n1.ElementAttribute(TracingId = 101641U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CLwLYjNPgmcM9DxETp9tQC", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CLwLYjNPgmcM9DxETp9tQC;
        [n1.ElementAttribute(TracingId = 101648U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FSQ5OZEkWMHMKE9UUzNdRE", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FSQ5OZEkWMHMKE9UUzNdRE;
        [n1.ElementAttribute(TracingId = 101662U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F7tqNXlrfanO3kMHv5gFDo", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_F7tqNXlrfanO3kMHv5gFDo;
        [n1.ElementAttribute(TracingId = 101655U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Rrov15gXRVJPYHMJLrH8GS", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Rrov15gXRVJPYHMJLrH8GS;
        [n1.ElementAttribute(TracingId = 101603U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GYwKxmXojMlMZPK1IIUIMl", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_GYwKxmXojMlMZPK1IIUIMl;
        [n1.ElementAttribute(TracingId = 101683U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CCVLHkBFzLkN5ucywJFjXD", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CCVLHkBFzLkN5ucywJFjXD;
        [n1.ElementAttribute(TracingId = 101690U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CJaaR7X5HXSME02UDZIDuE", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CJaaR7X5HXSME02UDZIDuE;
        [n1.ElementAttribute(TracingId = 101702U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "TuyJXjpXJWZNc1UeXfUoBV", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_TuyJXjpXJWZNc1UeXfUoBV;
        static BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX()
        {
        }

        public BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX other): base(other)
        {
            this.BezierEditorControl = other.BezierEditorControl;
            this.__slot_GlWPxAplozoQFvmL7OcJuh = other.__slot_GlWPxAplozoQFvmL7OcJuh;
            this.__p_BhunjH1pM0XLzwfpay7uKZ = other.__p_BhunjH1pM0XLzwfpay7uKZ;
            this.__p_N3xdSOVPKQrMqDNsGJWZ4F = other.__p_N3xdSOVPKQrMqDNsGJWZ4F;
            this.__p_SQZ9vfqsDjnQNhCqjjXbzh = other.__p_SQZ9vfqsDjnQNhCqjjXbzh;
            this.__p_RDyF4QQYuYAPs35wb7WqUK = other.__p_RDyF4QQYuYAPs35wb7WqUK;
            this.__p_TVtqls4eV0GOQwdW3CTodN = other.__p_TVtqls4eV0GOQwdW3CTodN;
            this.__p_OvoTG4BKVNOPLcxxmTEjBj = other.__p_OvoTG4BKVNOPLcxxmTEjBj;
            this.__p_CLwLYjNPgmcM9DxETp9tQC = other.__p_CLwLYjNPgmcM9DxETp9tQC;
            this.__p_FSQ5OZEkWMHMKE9UUzNdRE = other.__p_FSQ5OZEkWMHMKE9UUzNdRE;
            this.__p_F7tqNXlrfanO3kMHv5gFDo = other.__p_F7tqNXlrfanO3kMHv5gFDo;
            this.__p_Rrov15gXRVJPYHMJLrH8GS = other.__p_Rrov15gXRVJPYHMJLrH8GS;
            this.__p_GYwKxmXojMlMZPK1IIUIMl = other.__p_GYwKxmXojMlMZPK1IIUIMl;
            this.__p_CCVLHkBFzLkN5ucywJFjXD = other.__p_CCVLHkBFzLkN5ucywJFjXD;
            this.__p_CJaaR7X5HXSME02UDZIDuE = other.__p_CJaaR7X5HXSME02UDZIDuE;
            this.__p_TuyJXjpXJWZNc1UeXfUoBV = other.__p_TuyJXjpXJWZNc1UeXfUoBV;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "BezierEditorControl", in BezierEditorControl), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GlWPxAplozoQFvmL7OcJuh", in __slot_GlWPxAplozoQFvmL7OcJuh), n1.CompilationHelper.GetValueOrExisting(values, "__p_BhunjH1pM0XLzwfpay7uKZ", in __p_BhunjH1pM0XLzwfpay7uKZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_N3xdSOVPKQrMqDNsGJWZ4F", in __p_N3xdSOVPKQrMqDNsGJWZ4F), n1.CompilationHelper.GetValueOrExisting(values, "__p_SQZ9vfqsDjnQNhCqjjXbzh", in __p_SQZ9vfqsDjnQNhCqjjXbzh), n1.CompilationHelper.GetValueOrExisting(values, "__p_RDyF4QQYuYAPs35wb7WqUK", in __p_RDyF4QQYuYAPs35wb7WqUK), n1.CompilationHelper.GetValueOrExisting(values, "__p_TVtqls4eV0GOQwdW3CTodN", in __p_TVtqls4eV0GOQwdW3CTodN), n1.CompilationHelper.GetValueOrExisting(values, "__p_OvoTG4BKVNOPLcxxmTEjBj", in __p_OvoTG4BKVNOPLcxxmTEjBj), n1.CompilationHelper.GetValueOrExisting(values, "__p_CLwLYjNPgmcM9DxETp9tQC", in __p_CLwLYjNPgmcM9DxETp9tQC), n1.CompilationHelper.GetValueOrExisting(values, "__p_FSQ5OZEkWMHMKE9UUzNdRE", in __p_FSQ5OZEkWMHMKE9UUzNdRE), n1.CompilationHelper.GetValueOrExisting(values, "__p_F7tqNXlrfanO3kMHv5gFDo", in __p_F7tqNXlrfanO3kMHv5gFDo), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rrov15gXRVJPYHMJLrH8GS", in __p_Rrov15gXRVJPYHMJLrH8GS), n1.CompilationHelper.GetValueOrExisting(values, "__p_GYwKxmXojMlMZPK1IIUIMl", in __p_GYwKxmXojMlMZPK1IIUIMl), n1.CompilationHelper.GetValueOrExisting(values, "__p_CCVLHkBFzLkN5ucywJFjXD", in __p_CCVLHkBFzLkN5ucywJFjXD), n1.CompilationHelper.GetValueOrExisting(values, "__p_CJaaR7X5HXSME02UDZIDuE", in __p_CJaaR7X5HXSME02UDZIDuE), n1.CompilationHelper.GetValueOrExisting(values, "__p_TuyJXjpXJWZNc1UeXfUoBV", in __p_TuyJXjpXJWZNc1UeXfUoBV));
        }

        internal BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX __WITH__(n8.BezierEditorControlsData_R<n8.PointEditorControlsData_R> BezierEditorControl, bool __slot_GlWPxAplozoQFvmL7OcJuh, n8.PointEditorControls_CfmJZxw2ZgxMXLlIxJ3jzg __p_BhunjH1pM0XLzwfpay7uKZ, n45.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_N3xdSOVPKQrMqDNsGJWZ4F, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_SQZ9vfqsDjnQNhCqjjXbzh, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_RDyF4QQYuYAPs35wb7WqUK, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_TVtqls4eV0GOQwdW3CTodN, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OvoTG4BKVNOPLcxxmTEjBj, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CLwLYjNPgmcM9DxETp9tQC, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FSQ5OZEkWMHMKE9UUzNdRE, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_F7tqNXlrfanO3kMHv5gFDo, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Rrov15gXRVJPYHMJLrH8GS, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_GYwKxmXojMlMZPK1IIUIMl, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_CCVLHkBFzLkN5ucywJFjXD, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CJaaR7X5HXSME02UDZIDuE, n45.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_TuyJXjpXJWZNc1UeXfUoBV)
        {
            n8.BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = BezierEditorControl != this.BezierEditorControl || __slot_GlWPxAplozoQFvmL7OcJuh != this.__slot_GlWPxAplozoQFvmL7OcJuh || __p_BhunjH1pM0XLzwfpay7uKZ != this.__p_BhunjH1pM0XLzwfpay7uKZ || __p_N3xdSOVPKQrMqDNsGJWZ4F != this.__p_N3xdSOVPKQrMqDNsGJWZ4F || __p_SQZ9vfqsDjnQNhCqjjXbzh != this.__p_SQZ9vfqsDjnQNhCqjjXbzh || __p_RDyF4QQYuYAPs35wb7WqUK != this.__p_RDyF4QQYuYAPs35wb7WqUK || __p_TVtqls4eV0GOQwdW3CTodN != this.__p_TVtqls4eV0GOQwdW3CTodN || __p_OvoTG4BKVNOPLcxxmTEjBj != this.__p_OvoTG4BKVNOPLcxxmTEjBj || __p_CLwLYjNPgmcM9DxETp9tQC != this.__p_CLwLYjNPgmcM9DxETp9tQC || __p_FSQ5OZEkWMHMKE9UUzNdRE != this.__p_FSQ5OZEkWMHMKE9UUzNdRE || __p_F7tqNXlrfanO3kMHv5gFDo != this.__p_F7tqNXlrfanO3kMHv5gFDo || __p_Rrov15gXRVJPYHMJLrH8GS != this.__p_Rrov15gXRVJPYHMJLrH8GS || __p_GYwKxmXojMlMZPK1IIUIMl != this.__p_GYwKxmXojMlMZPK1IIUIMl || __p_CCVLHkBFzLkN5ucywJFjXD != this.__p_CCVLHkBFzLkN5ucywJFjXD || __p_CJaaR7X5HXSME02UDZIDuE != this.__p_CJaaR7X5HXSME02UDZIDuE || __p_TuyJXjpXJWZNc1UeXfUoBV != this.__p_TuyJXjpXJWZNc1UeXfUoBV ? new BezierEditorControls_BkvtkbxYthfP1wcZBRpDLX(this)
                {BezierEditorControl = BezierEditorControl, __slot_GlWPxAplozoQFvmL7OcJuh = __slot_GlWPxAplozoQFvmL7OcJuh, __p_BhunjH1pM0XLzwfpay7uKZ = __p_BhunjH1pM0XLzwfpay7uKZ, __p_N3xdSOVPKQrMqDNsGJWZ4F = __p_N3xdSOVPKQrMqDNsGJWZ4F, __p_SQZ9vfqsDjnQNhCqjjXbzh = __p_SQZ9vfqsDjnQNhCqjjXbzh, __p_RDyF4QQYuYAPs35wb7WqUK = __p_RDyF4QQYuYAPs35wb7WqUK, __p_TVtqls4eV0GOQwdW3CTodN = __p_TVtqls4eV0GOQwdW3CTodN, __p_OvoTG4BKVNOPLcxxmTEjBj = __p_OvoTG4BKVNOPLcxxmTEjBj, __p_CLwLYjNPgmcM9DxETp9tQC = __p_CLwLYjNPgmcM9DxETp9tQC, __p_FSQ5OZEkWMHMKE9UUzNdRE = __p_FSQ5OZEkWMHMKE9UUzNdRE, __p_F7tqNXlrfanO3kMHv5gFDo = __p_F7tqNXlrfanO3kMHv5gFDo, __p_Rrov15gXRVJPYHMJLrH8GS = __p_Rrov15gXRVJPYHMJLrH8GS, __p_GYwKxmXojMlMZPK1IIUIMl = __p_GYwKxmXojMlMZPK1IIUIMl, __p_CCVLHkBFzLkN5ucywJFjXD = __p_CCVLHkBFzLkN5ucywJFjXD, __p_CJaaR7X5HXSME02UDZIDuE = __p_CJaaR7X5HXSME02UDZIDuE, __p_TuyJXjpXJWZNc1UeXfUoBV = __p_TuyJXjpXJWZNc1UeXfUoBV} : that_0;
            else
            {
                this.BezierEditorControl = BezierEditorControl;
                this.__slot_GlWPxAplozoQFvmL7OcJuh = __slot_GlWPxAplozoQFvmL7OcJuh;
                this.__p_BhunjH1pM0XLzwfpay7uKZ = __p_BhunjH1pM0XLzwfpay7uKZ;
                this.__p_N3xdSOVPKQrMqDNsGJWZ4F = __p_N3xdSOVPKQrMqDNsGJWZ4F;
                this.__p_SQZ9vfqsDjnQNhCqjjXbzh = __p_SQZ9vfqsDjnQNhCqjjXbzh;
                this.__p_RDyF4QQYuYAPs35wb7WqUK = __p_RDyF4QQYuYAPs35wb7WqUK;
                this.__p_TVtqls4eV0GOQwdW3CTodN = __p_TVtqls4eV0GOQwdW3CTodN;
                this.__p_OvoTG4BKVNOPLcxxmTEjBj = __p_OvoTG4BKVNOPLcxxmTEjBj;
                this.__p_CLwLYjNPgmcM9DxETp9tQC = __p_CLwLYjNPgmcM9DxETp9tQC;
                this.__p_FSQ5OZEkWMHMKE9UUzNdRE = __p_FSQ5OZEkWMHMKE9UUzNdRE;
                this.__p_F7tqNXlrfanO3kMHv5gFDo = __p_F7tqNXlrfanO3kMHv5gFDo;
                this.__p_Rrov15gXRVJPYHMJLrH8GS = __p_Rrov15gXRVJPYHMJLrH8GS;
                this.__p_GYwKxmXojMlMZPK1IIUIMl = __p_GYwKxmXojMlMZPK1IIUIMl;
                this.__p_CCVLHkBFzLkN5ucywJFjXD = __p_CCVLHkBFzLkN5ucywJFjXD;
                this.__p_CJaaR7X5HXSME02UDZIDuE = __p_CJaaR7X5HXSME02UDZIDuE;
                this.__p_TuyJXjpXJWZNc1UeXfUoBV = __p_TuyJXjpXJWZNc1UeXfUoBV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 101774U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GfYkrBCvdKiOQha6qV0sW4", Name = "BezierEditorState_R")]
    [n2.SerializableAttribute]
    public class BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T8>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T7>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T8>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T7>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> __DEFAULT__;
        public n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> Update()
        {
            return this;
        }

        public n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> Join(n23.IEnumerable<n8.EditableBezierKnot_R<T9>> BezierKnots_In, T Pick_Size_In, T2 Offset_In, T3 Translation_In, T4 Rotation_In, T5 Scaling_In, T6 Point_on_Curve_In, T7 Looking_for_Point_In, T8 Editing_In, bool Is_Projection_Space_In, n34.GizmoState_R GizmoState_In)
        {
            n14._Operations_.FromSequence<n8.EditableBezierKnot_R<T9>>(Input_In: BezierKnots_In, Result_Out: out n10.Spread<n8.EditableBezierKnot_R<T9>> Result_0);
            n10.Spread<n8.EditableBezierKnot_R<T9>> __auto_1 = Result_0;
            T __auto_2 = Pick_Size_In;
            T2 __auto_3 = Offset_In;
            T3 __auto_4 = Translation_In;
            T4 __auto_5 = Rotation_In;
            T5 __auto_6 = Scaling_In;
            T6 __auto_7 = Point_on_Curve_In;
            T7 __auto_8 = Looking_for_Point_In;
            T8 __auto_9 = Editing_In;
            bool __auto_10 = Is_Projection_Space_In;
            n34.GizmoState_R __auto_11 = GizmoState_In;
            n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> that_12 = this;
            that_12 = Result_0 != this.BezierPoints || !n23.EqualityComparer<T>.Default.Equals(Pick_Size_In, this.Pick_Size) || !n23.EqualityComparer<T2>.Default.Equals(Offset_In, this.Offset) || !n23.EqualityComparer<T3>.Default.Equals(Translation_In, this.Translation) || !n23.EqualityComparer<T4>.Default.Equals(Rotation_In, this.Rotation) || !n23.EqualityComparer<T5>.Default.Equals(Scaling_In, this.Scaling) || !n23.EqualityComparer<T6>.Default.Equals(Point_on_Curve_In, this.Point_on_Curve) || !n23.EqualityComparer<T7>.Default.Equals(Looking_for_Point_In, this.Looking_for_Point) || !n23.EqualityComparer<T8>.Default.Equals(Editing_In, this.Editing) || Is_Projection_Space_In != this.Is_Projection_Space || GizmoState_In != this.GizmoState ? new BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8>(this)
            {BezierPoints = Result_0, Pick_Size = Pick_Size_In, Offset = Offset_In, Translation = Translation_In, Rotation = Rotation_In, Scaling = Scaling_In, Point_on_Curve = Point_on_Curve_In, Looking_for_Point = Looking_for_Point_In, Editing = Editing_In, Is_Projection_Space = Is_Projection_Space_In, GizmoState = GizmoState_In} : that_12;
            return that_12;
        }

        public n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> Split(out n10.Spread<n8.EditableBezierKnot_R<T9>> BezierKnots_Out, out T Pick_Size_Out, out T2 Offset_Out, out T3 Translation_Out, out T4 Rotation_Out, out T5 Scaling_Out, out T6 Point_on_Curve_Out, out T7 Looking_for_Point_Out, out T8 Editing_Out, out bool Is_Projection_Space_Out, out n34.GizmoState_R GizmoState_Out)
        {
            n10.Spread<n8.EditableBezierKnot_R<T9>> __auto_0 = this.BezierPoints;
            T __auto_1 = this.Pick_Size;
            T2 __auto_2 = this.Offset;
            T3 __auto_3 = this.Translation;
            T4 __auto_4 = this.Rotation;
            T5 __auto_5 = this.Scaling;
            T6 __auto_6 = this.Point_on_Curve;
            T7 __auto_7 = this.Looking_for_Point;
            T8 __auto_8 = this.Editing;
            bool __auto_9 = this.Is_Projection_Space;
            n34.GizmoState_R __auto_10 = this.GizmoState;
            BezierKnots_Out = __auto_0;
            Pick_Size_Out = __auto_1;
            Offset_Out = __auto_2;
            Translation_Out = __auto_3;
            Rotation_Out = __auto_4;
            Scaling_Out = __auto_5;
            Point_on_Curve_Out = __auto_6;
            Looking_for_Point_Out = __auto_7;
            Editing_Out = __auto_8;
            Is_Projection_Space_Out = __auto_9;
            GizmoState_Out = __auto_10;
            return this;
        }

        public n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T8>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T7>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_14);
            w_0.CreateDefault(out T2 __out_15);
            w_0.CreateDefault(out T3 __out_16);
            w_0.CreateDefault(out T4 __out_17);
            w_0.CreateDefault(out T5 __out_18);
            w_0.CreateDefault(out T6 __out_19);
            w_0.CreateDefault(out T7 __out_20);
            w_0.CreateDefault(out T8 __out_21);
            n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> that_1 = this;
            this.BezierPoints = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T9>>();
            this.Pick_Size = __out_14;
            this.Offset = __out_15;
            this.Translation = __out_16;
            this.Rotation = __out_17;
            this.Scaling = __out_18;
            this.Point_on_Curve = __out_19;
            this.Looking_for_Point = __out_20;
            this.Editing = __out_21;
            this.Is_Projection_Space = false;
            this.GizmoState = n34.GizmoState_R.CreateDefault();
            return that_1;
        }

        public n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T3>, n5.IAdaptiveCreateDefault<T8>, n5.IAdaptiveCreateDefault<T6>, n5.IAdaptiveCreateDefault<T7>, n5.IAdaptiveCreateDefault<T>, n5.IAdaptiveCreateDefault<T4>, n5.IAdaptiveCreateDefault<T5>, n5.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_22);
            w_0.CreateDefault(out T2 __out_23);
            w_0.CreateDefault(out T3 __out_24);
            w_0.CreateDefault(out T4 __out_25);
            w_0.CreateDefault(out T5 __out_26);
            w_0.CreateDefault(out T6 __out_27);
            w_0.CreateDefault(out T7 __out_28);
            w_0.CreateDefault(out T8 __out_29);
            n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> that_1 = this;
            this.BezierPoints = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<T9>>();
            this.Pick_Size = __out_22;
            this.Offset = __out_23;
            this.Translation = __out_24;
            this.Rotation = __out_25;
            this.Scaling = __out_26;
            this.Point_on_Curve = __out_27;
            this.Looking_for_Point = __out_28;
            this.Editing = __out_29;
            this.Is_Projection_Space = false;
            this.GizmoState = n34.GizmoState_R.CreateDefault();
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

        [n1.ElementAttribute(TracingId = 101778U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "P6YuUe43yvTPsm6CzYFbTE", Name = "BezierPoints")]
        public n10.Spread<n8.EditableBezierKnot_R<T9>> BezierPoints;
        [n1.ElementAttribute(TracingId = 101780U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UfAVWzO1MRlO4asTtE2LD0", Name = "Pick Size")]
        public T Pick_Size;
        [n1.ElementAttribute(TracingId = 101783U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Iyy672m0V2aO5TPfkSthNH", Name = "Offset")]
        public T2 Offset;
        [n1.ElementAttribute(TracingId = 101784U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "B4ItatNHjHNOj3HTfcAguO", Name = "Translation")]
        public T3 Translation;
        [n1.ElementAttribute(TracingId = 101785U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "FfJOUCdjPrqMdb6fglGUGR", Name = "Rotation")]
        public T4 Rotation;
        [n1.ElementAttribute(TracingId = 101786U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "S97EkIa5SEyOBvbk1RGWmZ", Name = "Scaling")]
        public T5 Scaling;
        [n1.ElementAttribute(TracingId = 101787U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HU3SZ2bqQ6jMHLnsgKDTaD", Name = "Point on Curve")]
        public T6 Point_on_Curve;
        [n1.ElementAttribute(TracingId = 101788U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "RI2bXWXVExSN31TmfFTwpI", Name = "Looking for Point")]
        public T7 Looking_for_Point;
        [n1.ElementAttribute(TracingId = 101789U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IB6o6TBMkk0QXq36ei2Wii", Name = "Editing")]
        public T8 Editing;
        [n1.ElementAttribute(TracingId = 101885U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "CL4V0S4fkpDM0eq18L9QeP", Name = "Is Projection Space")]
        public bool Is_Projection_Space;
        [n1.ElementAttribute(TracingId = 101892U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Gx5LpO7RhntLP1N1X0u77I", Name = "GizmoState")]
        public n34.GizmoState_R GizmoState;
        public BezierEditorState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierEditorState_R(BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> other): base(other)
        {
            this.BezierPoints = other.BezierPoints;
            this.Pick_Size = other.Pick_Size;
            this.Offset = other.Offset;
            this.Translation = other.Translation;
            this.Rotation = other.Rotation;
            this.Scaling = other.Scaling;
            this.Point_on_Curve = other.Point_on_Curve;
            this.Looking_for_Point = other.Looking_for_Point;
            this.Editing = other.Editing;
            this.Is_Projection_Space = other.Is_Projection_Space;
            this.GizmoState = other.GizmoState;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "BezierPoints", in BezierPoints), n1.CompilationHelper.GetValueOrExisting(values, "Pick_Size", in Pick_Size), n1.CompilationHelper.GetValueOrExisting(values, "Offset", in Offset), n1.CompilationHelper.GetValueOrExisting(values, "Translation", in Translation), n1.CompilationHelper.GetValueOrExisting(values, "Rotation", in Rotation), n1.CompilationHelper.GetValueOrExisting(values, "Scaling", in Scaling), n1.CompilationHelper.GetValueOrExisting(values, "Point_on_Curve", in Point_on_Curve), n1.CompilationHelper.GetValueOrExisting(values, "Looking_for_Point", in Looking_for_Point), n1.CompilationHelper.GetValueOrExisting(values, "Editing", in Editing), n1.CompilationHelper.GetValueOrExisting(values, "Is_Projection_Space", in Is_Projection_Space), n1.CompilationHelper.GetValueOrExisting(values, "GizmoState", in GizmoState));
        }

        internal BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> __WITH__(n10.Spread<n8.EditableBezierKnot_R<T9>> BezierPoints, T Pick_Size, T2 Offset, T3 Translation, T4 Rotation, T5 Scaling, T6 Point_on_Curve, T7 Looking_for_Point, T8 Editing, bool Is_Projection_Space, n34.GizmoState_R GizmoState)
        {
            n8.BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8> that_0 = this;
            that_0 = BezierPoints != this.BezierPoints || !n23.EqualityComparer<T>.Default.Equals(Pick_Size, this.Pick_Size) || !n23.EqualityComparer<T2>.Default.Equals(Offset, this.Offset) || !n23.EqualityComparer<T3>.Default.Equals(Translation, this.Translation) || !n23.EqualityComparer<T4>.Default.Equals(Rotation, this.Rotation) || !n23.EqualityComparer<T5>.Default.Equals(Scaling, this.Scaling) || !n23.EqualityComparer<T6>.Default.Equals(Point_on_Curve, this.Point_on_Curve) || !n23.EqualityComparer<T7>.Default.Equals(Looking_for_Point, this.Looking_for_Point) || !n23.EqualityComparer<T8>.Default.Equals(Editing, this.Editing) || Is_Projection_Space != this.Is_Projection_Space || GizmoState != this.GizmoState ? new BezierEditorState_R<T9, T, T2, T3, T4, T5, T6, T7, T8>(this)
            {BezierPoints = BezierPoints, Pick_Size = Pick_Size, Offset = Offset, Translation = Translation, Rotation = Rotation, Scaling = Scaling, Point_on_Curve = Point_on_Curve, Looking_for_Point = Looking_for_Point, Editing = Editing, Is_Projection_Space = Is_Projection_Space, GizmoState = GizmoState} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 101985U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "K50gxMDw5xROwWdoM9TPwu", Name = "EditableBezierKnot_R")]
    [n2.SerializableAttribute]
    public class EditableBezierKnot_R<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.EditableBezierKnot_R<T> Create<AdM>(n1.NodeContext Node_Context, n8.EditablePoint_R<T> Point_In)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new EditableBezierKnot_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Point_In);
        }

        [n6.CreateDefaultAttribute]
        public static n8.EditableBezierKnot_R<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.EditableBezierKnot_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new EditableBezierKnot_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.EditableBezierKnot_R<T> __DEFAULT__;
        public n8.EditableBezierKnot_R<T> GetControl2(out n8.EditablePoint_R<T> Control2_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control2;
            Control2_Out = __auto_0;
            return this;
        }

        public n8.EditableBezierKnot_R<T> GetControl1(out n8.EditablePoint_R<T> Control1_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control1;
            Control1_Out = __auto_0;
            return this;
        }

        public n8.EditableBezierKnot_R<T> GetPoint(out n8.EditablePoint_R<T> Point_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            Point_Out = __auto_0;
            return this;
        }

        public n8.EditableBezierKnot_R<T> Update()
        {
            return this;
        }

        public n8.EditableBezierKnot_R<T> GetMode(out int Mode_Out)
        {
            int __auto_0 = this.Mode;
            Mode_Out = __auto_0;
            return this;
        }

        public n8.EditableBezierKnot_R<T> IsSmooth(out bool Result_Out)
        {
            int __auto_0 = this.Mode;
            int __pad_IdDAOoqF7SNL8X4eNJYRoE_1 = __slot_IdDAOoqF7SNL8X4eNJYRoE;
            int __pad_Uv4SvcEMpKWO9EjODIB6Ct_2 = __slot_Uv4SvcEMpKWO9EjODIB6Ct;
            var Result_3 = __auto_0 == __pad_IdDAOoqF7SNL8X4eNJYRoE_1;
            var Result_4 = __auto_0 == __pad_Uv4SvcEMpKWO9EjODIB6Ct_2;
            bool Apply_5 = true;
            var Output_6 = Result_3;
            if (Apply_5)
            {
                var Output_7 = Result_3 || Result_4;
                Output_6 = Output_7;
            }

            Result_Out = Output_6;
            return this;
        }

        public n8.EditableBezierKnot_R<T> SetSmoothMode()
        {
            int __pad_JYZyUqQt9EJPAE2O8D6mbl_0 = __slot_JYZyUqQt9EJPAE2O8D6mbl;
            int __auto_1 = __pad_JYZyUqQt9EJPAE2O8D6mbl_0;
            n8.EditableBezierKnot_R<T> that_2 = this;
            that_2 = __pad_JYZyUqQt9EJPAE2O8D6mbl_0 != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Mode = __pad_JYZyUqQt9EJPAE2O8D6mbl_0} : that_2;
            return that_2;
        }

        public n8.EditableBezierKnot_R<T> SetSmoothSymmetricMode()
        {
            int __pad_BGTmrjLW8tSMrZwIwV5xX6_0 = __slot_BGTmrjLW8tSMrZwIwV5xX6;
            int __auto_1 = __pad_BGTmrjLW8tSMrZwIwV5xX6_0;
            n8.EditableBezierKnot_R<T> that_2 = this;
            that_2 = __pad_BGTmrjLW8tSMrZwIwV5xX6_0 != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Mode = __pad_BGTmrjLW8tSMrZwIwV5xX6_0} : that_2;
            return that_2;
        }

        public n8.EditableBezierKnot_R<T> SetCornerMode()
        {
            int __pad_GrCewpWjPs5OoGjCXVAK33_0 = __slot_GrCewpWjPs5OoGjCXVAK33;
            int __auto_1 = __pad_GrCewpWjPs5OoGjCXVAK33_0;
            n8.EditableBezierKnot_R<T> that_2 = this;
            that_2 = __pad_GrCewpWjPs5OoGjCXVAK33_0 != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Mode = __pad_GrCewpWjPs5OoGjCXVAK33_0} : that_2;
            return that_2;
        }

        public n8.EditableBezierKnot_R<T> SetCornerWithHandlesMode()
        {
            int __pad_Jf6AcoHf0YrPQmDP4WSQKr_0 = __slot_Jf6AcoHf0YrPQmDP4WSQKr;
            int __auto_1 = __pad_Jf6AcoHf0YrPQmDP4WSQKr_0;
            n8.EditableBezierKnot_R<T> that_2 = this;
            that_2 = __pad_Jf6AcoHf0YrPQmDP4WSQKr_0 != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Mode = __pad_Jf6AcoHf0YrPQmDP4WSQKr_0} : that_2;
            return that_2;
        }

        public n8.EditableBezierKnot_R<T> IsSymmetric(out bool Result_Out)
        {
            int __auto_0 = this.Mode;
            int __pad_MOvzTsVq0G8No2RIYtBQ77_1 = __slot_MOvzTsVq0G8No2RIYtBQ77;
            var Result_2 = __auto_0 == __pad_MOvzTsVq0G8No2RIYtBQ77_1;
            Result_Out = Result_2;
            return this;
        }

        public n8.EditableBezierKnot_R<T> IsCorner(out bool Result_Out)
        {
            int __auto_0 = this.Mode;
            int __pad_LC3oHS5BTQWMKLrobbUyRS_1 = __slot_LC3oHS5BTQWMKLrobbUyRS;
            var Result_2 = __auto_0 == __pad_LC3oHS5BTQWMKLrobbUyRS_1;
            Result_Out = Result_2;
            return this;
        }

        public n8.EditableBezierKnot_R<T> IsCornerWithHandles(out bool Result_Out)
        {
            int __auto_0 = this.Mode;
            int __pad_KexAqa12pHSOIjhv5gjPXQ_1 = __slot_KexAqa12pHSOIjhv5gjPXQ;
            var Result_2 = __auto_0 == __pad_KexAqa12pHSOIjhv5gjPXQ_1;
            Result_Out = Result_2;
            return this;
        }

        public n8.EditableBezierKnot_R<T> Join(n8.EditablePoint_R<T> Point_In, n8.EditablePoint_R<T> Contol1_In, n8.EditablePoint_R<T> Control2_In, int Mode_In)
        {
            n8.EditablePoint_R<T> __auto_0 = Point_In;
            n8.EditablePoint_R<T> __auto_1 = Contol1_In;
            n8.EditablePoint_R<T> __auto_2 = Control2_In;
            int __auto_3 = Mode_In;
            n8.EditableBezierKnot_R<T> that_4 = this;
            that_4 = Point_In != this.Point || Contol1_In != this.Control1 || Control2_In != this.Control2 || Mode_In != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Point = Point_In, Control1 = Contol1_In, Control2 = Control2_In, Mode = Mode_In} : that_4;
            return that_4;
        }

        public n8.EditableBezierKnot_R<T> Split(out n8.EditablePoint_R<T> Point_Out, out n8.EditablePoint_R<T> Control1_Out, out n8.EditablePoint_R<T> Control2_Out, out int Mode_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            n8.EditablePoint_R<T> __auto_1 = this.Control1;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            int __auto_3 = this.Mode;
            Point_Out = __auto_0;
            Control1_Out = __auto_1;
            Control2_Out = __auto_2;
            Mode_Out = __auto_3;
            return this;
        }

        public n8.EditableBezierKnot_R<T> SetPointAndControls(n8.EditablePoint_R<T> Control1_In, n8.EditablePoint_R<T> Point_In, n8.EditablePoint_R<T> Control2_In)
        {
            n8.EditablePoint_R<T> __auto_0 = Control1_In;
            n8.EditablePoint_R<T> __auto_1 = Point_In;
            n8.EditablePoint_R<T> __auto_2 = Control2_In;
            n8.EditableBezierKnot_R<T> that_3 = this;
            that_3 = Control1_In != this.Control1 || Point_In != this.Point || Control2_In != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Control1 = Control1_In, Point = Point_In, Control2 = Control2_In} : that_3;
            return that_3;
        }

        public n8.EditableBezierKnot_R<T> SetPoint(n8.EditablePoint_R<T> Point_In)
        {
            n8.EditablePoint_R<T> __auto_0 = Point_In;
            n8.EditableBezierKnot_R<T> that_1 = this;
            that_1 = Point_In != this.Point ? new EditableBezierKnot_R<T>(this)
            {Point = Point_In} : that_1;
            return that_1;
        }

        public n8.EditableBezierKnot_R<T> SetControl1(n8.EditablePoint_R<T> Control1_In)
        {
            n8.EditablePoint_R<T> __auto_0 = Control1_In;
            n8.EditableBezierKnot_R<T> that_1 = this;
            that_1 = Control1_In != this.Control1 ? new EditableBezierKnot_R<T>(this)
            {Control1 = Control1_In} : that_1;
            return that_1;
        }

        public n8.EditableBezierKnot_R<T> SetControl2(n8.EditablePoint_R<T> Control2_In)
        {
            n8.EditablePoint_R<T> __auto_0 = Control2_In;
            n8.EditableBezierKnot_R<T> that_1 = this;
            that_1 = Control2_In != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Control2 = Control2_In} : that_1;
            return that_1;
        }

        public n8.EditableBezierKnot_R<T> UpdateControls<AdM>(n8.EditablePoint_R<T> Point_In)
            where AdM : struct, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            n8.EditablePoint_R<T> __auto_1 = this.Point;
            n8.EditablePoint_R<T> __auto_2 = this.Control1;
            n8.EditablePoint_R<T> __auto_3 = this.Control2;
            var Output_5 = Point_In.GetPosition(Position_Out: out T Position_4);
            var Output_7 = __auto_1.GetPosition(Position_Out: out T Position_6);
            bool Apply_8 = true;
            var Output_9 = Position_4;
            if (Apply_8)
            {
                w_0.OperatorMinus(Input_In: Position_4, Input_2_In: Position_6, Output_Out: out Output_9);
            }

            var Output_11 = __auto_2.GetPosition(Position_Out: out T Position_10);
            bool Apply_12 = true;
            var Output_13 = Output_9;
            if (Apply_12)
            {
                w_0.OperatorPlus(Input_In: Output_9, Input_2_In: Position_10, Output_Out: out Output_13);
            }

            bool Apply_14 = true;
            var Output_15 = __auto_2;
            if (Apply_14)
            {
                Output_15 = __auto_2.SetPosition(Position_In: Output_13);
            }

            n8.EditablePoint_R<T> __auto_16 = Output_15;
            var Output_18 = __auto_3.GetPosition(Position_Out: out T Position_17);
            bool Apply_19 = true;
            var Output_20 = Output_9;
            if (Apply_19)
            {
                w_0.OperatorPlus(Input_In: Output_9, Input_2_In: Position_17, Output_Out: out Output_20);
            }

            bool Apply_21 = true;
            var Output_22 = __auto_3;
            if (Apply_21)
            {
                Output_22 = __auto_3.SetPosition(Position_In: Output_20);
            }

            n8.EditablePoint_R<T> __auto_23 = Output_22;
            n8.EditableBezierKnot_R<T> that_24 = this;
            that_24 = Output_15 != this.Control1 || Output_22 != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Control1 = Output_15, Control2 = Output_22} : that_24;
            return that_24;
        }

        public n8.EditableBezierKnot_R<T> UpdateKnot<AdM>(n8.EditablePoint_R<T> Point_In, n8.EditablePoint_R<T> Control1_In, n8.EditablePoint_R<T> Control2_In)
            where AdM : struct, n21.IAdaptiveOperatorPlus<T>, n21.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            n8.EditablePoint_R<T> __auto_1 = this.Point;
            n8.EditablePoint_R<T> __auto_2 = this.Control1;
            n8.EditablePoint_R<T> __auto_3 = this.Control2;
            n8.EditablePoint_R<T> __auto_4 = Point_In;
            var Output_6 = Point_In.GetPosition(Position_Out: out T Position_5);
            var Output_8 = __auto_1.GetPosition(Position_Out: out T Position_7);
            bool Apply_9 = true;
            var Output_10 = Position_5;
            if (Apply_9)
            {
                w_0.OperatorMinus(Input_In: Position_5, Input_2_In: Position_7, Output_Out: out Output_10);
            }

            var Output_12 = __auto_2.GetPosition(Position_Out: out T Position_11);
            bool Apply_13 = true;
            var Output_14 = Output_10;
            if (Apply_13)
            {
                w_0.OperatorPlus(Input_In: Output_10, Input_2_In: Position_11, Output_Out: out Output_14);
            }

            bool Apply_15 = true;
            var Output_16 = Control1_In;
            if (Apply_15)
            {
                Output_16 = Control1_In.SetPosition(Position_In: Output_14);
            }

            n8.EditablePoint_R<T> __auto_17 = Output_16;
            var Output_19 = __auto_3.GetPosition(Position_Out: out T Position_18);
            bool Apply_20 = true;
            var Output_21 = Output_10;
            if (Apply_20)
            {
                w_0.OperatorPlus(Input_In: Output_10, Input_2_In: Position_18, Output_Out: out Output_21);
            }

            bool Apply_22 = true;
            var Output_23 = Control2_In;
            if (Apply_22)
            {
                Output_23 = Control2_In.SetPosition(Position_In: Output_21);
            }

            n8.EditablePoint_R<T> __auto_24 = Output_23;
            n8.EditableBezierKnot_R<T> that_25 = this;
            that_25 = Point_In != this.Point || Output_16 != this.Control1 || Output_23 != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Point = Point_In, Control1 = Output_16, Control2 = Output_23} : that_25;
            return that_25;
        }

        public n8.EditableBezierKnot_R<T> DeselectPoinAndControls()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            n8.EditablePoint_R<T> __auto_1 = this.Control1;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            bool Apply_3 = true;
            var Output_4 = __auto_0;
            if (Apply_3)
            {
                Output_4 = __auto_0.DeSelect();
            }

            n8.EditablePoint_R<T> __auto_5 = Output_4;
            bool Apply_6 = true;
            var Output_7 = __auto_1;
            if (Apply_6)
            {
                Output_7 = __auto_1.DeSelect();
            }

            n8.EditablePoint_R<T> __auto_8 = Output_7;
            bool Apply_9 = true;
            var Output_10 = __auto_2;
            if (Apply_9)
            {
                Output_10 = __auto_2.DeSelect();
            }

            n8.EditablePoint_R<T> __auto_11 = Output_10;
            n8.EditableBezierKnot_R<T> that_12 = this;
            that_12 = Output_4 != this.Point || Output_7 != this.Control1 || Output_10 != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Point = Output_4, Control1 = Output_7, Control2 = Output_10} : that_12;
            return that_12;
        }

        public n8.EditableBezierKnot_R<T> SetSmoothControls(T Control1_In, T Control2_In)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control1;
            n8.EditablePoint_R<T> __auto_1 = this.Control2;
            bool Apply_2 = true;
            var Output_3 = __auto_0;
            if (Apply_2)
            {
                Output_3 = __auto_0.SetPosition(Position_In: Control1_In);
            }

            bool Apply_4 = true;
            var Output_5 = Output_3;
            if (Apply_4)
            {
                Output_5 = Output_3.Unlock();
            }

            n8.EditablePoint_R<T> __auto_6 = Output_5;
            bool Apply_7 = true;
            var Output_8 = __auto_1;
            if (Apply_7)
            {
                Output_8 = __auto_1.SetPosition(Position_In: Control2_In);
            }

            bool Apply_9 = true;
            var Output_10 = Output_8;
            if (Apply_9)
            {
                Output_10 = Output_8.Unlock();
            }

            n8.EditablePoint_R<T> __auto_11 = Output_10;
            n8.EditableBezierKnot_R<T> that_12 = this;
            that_12 = Output_5 != this.Control1 || Output_10 != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Control1 = Output_5, Control2 = Output_10} : that_12;
            return that_12;
        }

        public n8.EditableBezierKnot_R<T> GetEditablePoints(out n10.Spread<n8.EditablePoint_R<T>> Result_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            n8.EditablePoint_R<T> __auto_1 = this.Control1;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            var Empty_3 = n14._Operations_.CreateDefault<n8.EditablePoint_R<T>>();
            bool Apply_4 = true;
            var Output_5 = Empty_3;
            if (Apply_4)
            {
                n14._Operations_.Add<n8.EditablePoint_R<T>>(Input_In: Empty_3, Item_In: __auto_0, Output_Out: out Output_5);
            }

            bool Apply_6 = true;
            var Output_7 = Output_5;
            if (Apply_6)
            {
                n14._Operations_.Add<n8.EditablePoint_R<T>>(Input_In: Output_5, Item_In: __auto_1, Output_Out: out Output_7);
            }

            bool Apply_8 = true;
            var Output_9 = Output_7;
            if (Apply_8)
            {
                n14._Operations_.Add<n8.EditablePoint_R<T>>(Input_In: Output_7, Item_In: __auto_2, Output_Out: out Output_9);
            }

            Result_Out = Output_9;
            return this;
        }

        public n8.EditableBezierKnot_R<T> IsPointOrControlsSelected(out bool Result_Out)
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            n8.EditablePoint_R<T> __auto_1 = this.Control1;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            var Output_4 = __auto_0.GetSelected(Selected_Out: out bool Selected_3);
            var Output_6 = __auto_1.GetSelected(Selected_Out: out bool Selected_5);
            var Output_8 = __auto_2.GetSelected(Selected_Out: out bool Selected_7);
            var Output_9 = Selected_3 || Selected_5;
            var Output_10 = Output_9 || Selected_7;
            Result_Out = Output_10;
            return this;
        }

        public n8.EditableBezierKnot_R<T> SetControlsToPoint()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control1;
            n8.EditablePoint_R<T> __auto_1 = this.Point;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            var Output_4 = __auto_1.GetPosition(Position_Out: out T Position_3);
            bool Apply_5 = true;
            var Output_6 = __auto_0;
            if (Apply_5)
            {
                Output_6 = __auto_0.SetPosition(Position_In: Position_3);
            }

            bool Apply_7 = true;
            var Output_8 = __auto_2;
            if (Apply_7)
            {
                Output_8 = __auto_2.SetPosition(Position_In: Position_3);
            }

            n8.EditablePoint_R<T> __auto_9 = Output_8;
            n8.EditablePoint_R<T> __auto_10 = Output_6;
            n8.EditableBezierKnot_R<T> that_11 = this;
            that_11 = Output_8 != this.Control2 || Output_6 != this.Control1 ? new EditableBezierKnot_R<T>(this)
            {Control2 = Output_8, Control1 = Output_6} : that_11;
            return that_11;
        }

        public n8.EditableBezierKnot_R<T> SelectPoint()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            bool Apply_1 = true;
            var Output_2 = __auto_0;
            if (Apply_1)
            {
                Output_2 = __auto_0.Select();
            }

            n8.EditablePoint_R<T> __auto_3 = Output_2;
            n8.EditableBezierKnot_R<T> that_4 = this;
            that_4 = Output_2 != this.Point ? new EditableBezierKnot_R<T>(this)
            {Point = Output_2} : that_4;
            return that_4;
        }

        public n8.EditableBezierKnot_R<T> HideControl2()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Point;
            n8.EditablePoint_R<T> __auto_1 = this.Control2;
            var Output_3 = __auto_0.GetPosition(Position_Out: out T Position_2);
            bool Apply_4 = true;
            var Output_5 = __auto_1;
            if (Apply_4)
            {
                Output_5 = __auto_1.SetPosition(Position_In: Position_2);
            }

            bool Apply_6 = true;
            var Output_7 = Output_5;
            if (Apply_6)
            {
                Output_7 = Output_5.Lock();
            }

            n8.EditablePoint_R<T> __auto_8 = Output_7;
            n8.EditableBezierKnot_R<T> that_9 = this;
            that_9 = Output_7 != this.Control2 ? new EditableBezierKnot_R<T>(this)
            {Control2 = Output_7} : that_9;
            return that_9;
        }

        public n8.EditableBezierKnot_R<T> HideControl1()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control1;
            n8.EditablePoint_R<T> __auto_1 = this.Point;
            var Output_3 = __auto_1.GetPosition(Position_Out: out T Position_2);
            bool Apply_4 = true;
            var Output_5 = __auto_0;
            if (Apply_4)
            {
                Output_5 = __auto_0.SetPosition(Position_In: Position_2);
            }

            bool Apply_6 = true;
            var Output_7 = Output_5;
            if (Apply_6)
            {
                Output_7 = Output_5.Lock();
            }

            n8.EditablePoint_R<T> __auto_8 = Output_7;
            n8.EditableBezierKnot_R<T> that_9 = this;
            that_9 = Output_7 != this.Control1 ? new EditableBezierKnot_R<T>(this)
            {Control1 = Output_7} : that_9;
            return that_9;
        }

        public n8.EditableBezierKnot_R<T> HideControls()
        {
            n8.EditablePoint_R<T> __auto_0 = this.Control1;
            n8.EditablePoint_R<T> __auto_1 = this.Point;
            n8.EditablePoint_R<T> __auto_2 = this.Control2;
            var Output_4 = __auto_1.GetPosition(Position_Out: out T Position_3);
            bool Apply_5 = true;
            var Output_6 = __auto_0;
            if (Apply_5)
            {
                Output_6 = __auto_0.SetPosition(Position_In: Position_3);
            }

            bool Apply_7 = true;
            var Output_8 = Output_6;
            if (Apply_7)
            {
                Output_8 = Output_6.Lock();
            }

            bool Apply_9 = true;
            var Output_10 = __auto_2;
            if (Apply_9)
            {
                Output_10 = __auto_2.SetPosition(Position_In: Position_3);
            }

            bool Apply_11 = true;
            var Output_12 = Output_10;
            if (Apply_11)
            {
                Output_12 = Output_10.Lock();
            }

            n8.EditablePoint_R<T> __auto_13 = Output_12;
            n8.EditablePoint_R<T> __auto_14 = Output_8;
            n8.EditableBezierKnot_R<T> that_15 = this;
            that_15 = Output_12 != this.Control2 || Output_8 != this.Control1 ? new EditableBezierKnot_R<T>(this)
            {Control2 = Output_12, Control1 = Output_8} : that_15;
            return that_15;
        }

        public n8.EditableBezierKnot_R<T> __Create__<AdM>(n1.NodeContext Node_Context, n8.EditablePoint_R<T> Point_In)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            int __pad_ShV0ZnDNOgsMJF8ybGzV9V_1 = __slot_ShV0ZnDNOgsMJF8ybGzV9V;
            n8.EditablePoint_R<T> __auto_2 = Point_In;
            bool Apply_3 = true;
            var Output_4 = Point_In;
            if (Apply_3)
            {
                Output_4 = Point_In.Lock();
            }

            n8.EditablePoint_R<T> __auto_5 = Output_4;
            n8.EditablePoint_R<T> __auto_6 = Output_4;
            int __auto_7 = __pad_ShV0ZnDNOgsMJF8ybGzV9V_1;
            n8.EditableBezierKnot_R<T> that_8 = this;
            this.Control1 = Output_4;
            this.Point = Point_In;
            this.Control2 = Output_4;
            this.Mode = __pad_ShV0ZnDNOgsMJF8ybGzV9V_1;
            return that_8;
        }

        public n8.EditableBezierKnot_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n8.EditableBezierKnot_R<T> that_1 = this;
            this.Control1 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            this.Point = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            this.Control2 = n8.EditablePoint_R<T>.CreateDefault<AdM>();
            this.Mode = 0;
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

        [n1.ElementAttribute(TracingId = 101987U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Dqy6GPq0TaMO6g9LLouxEP", Name = "Control1")]
        public n8.EditablePoint_R<T> Control1;
        [n1.ElementAttribute(TracingId = 101989U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ccxf9gnoiPyNYqZ0xn9bHi", Name = "Point")]
        public n8.EditablePoint_R<T> Point;
        [n1.ElementAttribute(TracingId = 101991U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "HmmtxhF50qgPLuJeRMb5Zg", Name = "Control2")]
        public n8.EditablePoint_R<T> Control2;
        [n1.ElementAttribute(TracingId = 101992U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "QaI21cwvApRPqYF6P2HT34", Name = "Mode")]
        public int Mode;
        [n1.ElementAttribute(TracingId = 102242U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "JYZyUqQt9EJPAE2O8D6mbl", Name = "__slot_JYZyUqQt9EJPAE2O8D6mbl")]
        public static int __slot_JYZyUqQt9EJPAE2O8D6mbl = 2;
        [n1.ElementAttribute(TracingId = 102253U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "BGTmrjLW8tSMrZwIwV5xX6", Name = "__slot_BGTmrjLW8tSMrZwIwV5xX6")]
        public static int __slot_BGTmrjLW8tSMrZwIwV5xX6 = 3;
        [n1.ElementAttribute(TracingId = 102261U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "GrCewpWjPs5OoGjCXVAK33", Name = "__slot_GrCewpWjPs5OoGjCXVAK33")]
        public static int __slot_GrCewpWjPs5OoGjCXVAK33 = 0;
        [n1.ElementAttribute(TracingId = 102267U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Jf6AcoHf0YrPQmDP4WSQKr", Name = "__slot_Jf6AcoHf0YrPQmDP4WSQKr")]
        public static int __slot_Jf6AcoHf0YrPQmDP4WSQKr = 1;
        [n1.ElementAttribute(TracingId = 102273U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "ShV0ZnDNOgsMJF8ybGzV9V", Name = "__slot_ShV0ZnDNOgsMJF8ybGzV9V")]
        public static int __slot_ShV0ZnDNOgsMJF8ybGzV9V = 3;
        [n1.ElementAttribute(TracingId = 102278U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "IdDAOoqF7SNL8X4eNJYRoE", Name = "__slot_IdDAOoqF7SNL8X4eNJYRoE")]
        public static int __slot_IdDAOoqF7SNL8X4eNJYRoE = 2;
        [n1.ElementAttribute(TracingId = 102283U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Uv4SvcEMpKWO9EjODIB6Ct", Name = "__slot_Uv4SvcEMpKWO9EjODIB6Ct")]
        public static int __slot_Uv4SvcEMpKWO9EjODIB6Ct = 3;
        [n1.ElementAttribute(TracingId = 102288U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "LC3oHS5BTQWMKLrobbUyRS", Name = "__slot_LC3oHS5BTQWMKLrobbUyRS")]
        public static int __slot_LC3oHS5BTQWMKLrobbUyRS = 0;
        [n1.ElementAttribute(TracingId = 102292U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MOvzTsVq0G8No2RIYtBQ77", Name = "__slot_MOvzTsVq0G8No2RIYtBQ77")]
        public static int __slot_MOvzTsVq0G8No2RIYtBQ77 = 3;
        [n1.ElementAttribute(TracingId = 102300U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KexAqa12pHSOIjhv5gjPXQ", Name = "__slot_KexAqa12pHSOIjhv5gjPXQ")]
        public static int __slot_KexAqa12pHSOIjhv5gjPXQ = 1;
        static EditableBezierKnot_R()
        {
        }

        public EditableBezierKnot_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal EditableBezierKnot_R(EditableBezierKnot_R<T> other): base(other)
        {
            this.Control1 = other.Control1;
            this.Point = other.Point;
            this.Control2 = other.Control2;
            this.Mode = other.Mode;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Control1", in Control1), n1.CompilationHelper.GetValueOrExisting(values, "Point", in Point), n1.CompilationHelper.GetValueOrExisting(values, "Control2", in Control2), n1.CompilationHelper.GetValueOrExisting(values, "Mode", in Mode));
        }

        internal EditableBezierKnot_R<T> __WITH__(n8.EditablePoint_R<T> Control1, n8.EditablePoint_R<T> Point, n8.EditablePoint_R<T> Control2, int Mode)
        {
            n8.EditableBezierKnot_R<T> that_0 = this;
            that_0 = Control1 != this.Control1 || Point != this.Point || Control2 != this.Control2 || Mode != this.Mode ? new EditableBezierKnot_R<T>(this)
            {Control1 = Control1, Point = Point, Control2 = Control2, Mode = Mode} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 103093U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Slac8PORkymNllyKtieSlA", Name = "BezierEditorControlsData_R")]
    [n2.SerializableAttribute]
    public class BezierEditorControlsData_R<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n8.BezierEditorControlsData_R<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new BezierEditorControlsData_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n8.BezierEditorControlsData_R<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n8.BezierEditorControlsData_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new BezierEditorControlsData_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.BezierEditorControlsData_R<T> __DEFAULT__;
        public n8.BezierEditorControlsData_R<T> Join(bool Corner_In, bool Corner_With_Handles_In, bool Smooth_In, bool Smooth_Symmetric_In, bool Find_Point_on_Curve_In, T PointEditorControls_In, bool Hover_Control_In, bool Force_Selection_In)
        {
            bool __auto_0 = Corner_In;
            bool __auto_1 = Corner_With_Handles_In;
            bool __auto_2 = Smooth_In;
            bool __auto_3 = Smooth_Symmetric_In;
            bool __auto_4 = Find_Point_on_Curve_In;
            T __auto_5 = PointEditorControls_In;
            bool __auto_6 = Hover_Control_In;
            bool __auto_7 = Force_Selection_In;
            n8.BezierEditorControlsData_R<T> that_8 = this;
            that_8 = Corner_In != this.Corner || Corner_With_Handles_In != this.Corner_With_Handles || Smooth_In != this.Smooth || Smooth_Symmetric_In != this.Smooth_Symmetric || Find_Point_on_Curve_In != this.FindPointOnCurve || !n23.EqualityComparer<T>.Default.Equals(PointEditorControls_In, this.PointEditorControls) || Hover_Control_In != this.Hover_Control || Force_Selection_In != this.Force_Selection ? new BezierEditorControlsData_R<T>(this)
            {Corner = Corner_In, Corner_With_Handles = Corner_With_Handles_In, Smooth = Smooth_In, Smooth_Symmetric = Smooth_Symmetric_In, FindPointOnCurve = Find_Point_on_Curve_In, PointEditorControls = PointEditorControls_In, Hover_Control = Hover_Control_In, Force_Selection = Force_Selection_In} : that_8;
            return that_8;
        }

        public n8.BezierEditorControlsData_R<T> Split(out bool Corner_Out, out bool Corner_With_Handles_Out, out bool Smooth_Out, out bool Smooth_Symmetric_Out, out bool Find_Point_on_Curve_Out, out T PointEditorControls_Out, out bool Hover_Control_Out, out bool Force_Selection_Out)
        {
            bool __auto_0 = this.Corner;
            bool __auto_1 = this.Corner_With_Handles;
            bool __auto_2 = this.Smooth;
            bool __auto_3 = this.Smooth_Symmetric;
            bool __auto_4 = this.FindPointOnCurve;
            T __auto_5 = this.PointEditorControls;
            bool __auto_6 = this.Hover_Control;
            bool __auto_7 = this.Force_Selection;
            Corner_Out = __auto_0;
            Corner_With_Handles_Out = __auto_1;
            Smooth_Out = __auto_2;
            Smooth_Symmetric_Out = __auto_3;
            Find_Point_on_Curve_Out = __auto_4;
            PointEditorControls_Out = __auto_5;
            Hover_Control_Out = __auto_6;
            Force_Selection_Out = __auto_7;
            return this;
        }

        public n8.BezierEditorControlsData_R<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_30);
            n8.BezierEditorControlsData_R<T> that_1 = this;
            this.Corner = false;
            this.Corner_With_Handles = false;
            this.Smooth = false;
            this.Smooth_Symmetric = false;
            this.FindPointOnCurve = false;
            this.PointEditorControls = __out_30;
            this.Hover_Control = false;
            this.Force_Selection = false;
            return that_1;
        }

        public n8.BezierEditorControlsData_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_31);
            n8.BezierEditorControlsData_R<T> that_1 = this;
            this.Corner = false;
            this.Corner_With_Handles = false;
            this.Smooth = false;
            this.Smooth_Symmetric = false;
            this.FindPointOnCurve = false;
            this.PointEditorControls = __out_31;
            this.Hover_Control = false;
            this.Force_Selection = false;
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

        [n1.ElementAttribute(TracingId = 103095U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "KEWt13ZwvGkOljDkEzxrTZ", Name = "Corner")]
        public bool Corner;
        [n1.ElementAttribute(TracingId = 103096U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Kq74bB4t08yP6WpoFSTd9h", Name = "Corner With Handles")]
        public bool Corner_With_Handles;
        [n1.ElementAttribute(TracingId = 103097U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "F8U3KPDQuDJN2LP6Nmxedm", Name = "Smooth")]
        public bool Smooth;
        [n1.ElementAttribute(TracingId = 103098U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "Ma1DDsR7NM5MilgYhkubUm", Name = "Smooth Symmetric")]
        public bool Smooth_Symmetric;
        [n1.ElementAttribute(TracingId = 103099U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "MuVE890KAlEPWi5Pmxv4Dj", Name = "FindPointOnCurve")]
        public bool FindPointOnCurve;
        [n1.ElementAttribute(TracingId = 103100U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "UiipRiuex19OrAVX8d0rWB", Name = "PointEditorControls")]
        public T PointEditorControls;
        [n1.ElementAttribute(TracingId = 103140U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "NMvwKKgTXBBQFPazK6Ivpk", Name = "Hover Control")]
        public bool Hover_Control;
        [n1.ElementAttribute(TracingId = 103144U, DocumentId = "RMDMfKmnIrVPStLdWe8u30", PersistentId = "EjWcZxnDUSpN2HGJCpedbN", Name = "Force Selection")]
        public bool Force_Selection;
        public BezierEditorControlsData_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BezierEditorControlsData_R(BezierEditorControlsData_R<T> other): base(other)
        {
            this.Corner = other.Corner;
            this.Corner_With_Handles = other.Corner_With_Handles;
            this.Smooth = other.Smooth;
            this.Smooth_Symmetric = other.Smooth_Symmetric;
            this.FindPointOnCurve = other.FindPointOnCurve;
            this.PointEditorControls = other.PointEditorControls;
            this.Hover_Control = other.Hover_Control;
            this.Force_Selection = other.Force_Selection;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Corner", in Corner), n1.CompilationHelper.GetValueOrExisting(values, "Corner_With_Handles", in Corner_With_Handles), n1.CompilationHelper.GetValueOrExisting(values, "Smooth", in Smooth), n1.CompilationHelper.GetValueOrExisting(values, "Smooth_Symmetric", in Smooth_Symmetric), n1.CompilationHelper.GetValueOrExisting(values, "FindPointOnCurve", in FindPointOnCurve), n1.CompilationHelper.GetValueOrExisting(values, "PointEditorControls", in PointEditorControls), n1.CompilationHelper.GetValueOrExisting(values, "Hover_Control", in Hover_Control), n1.CompilationHelper.GetValueOrExisting(values, "Force_Selection", in Force_Selection));
        }

        internal BezierEditorControlsData_R<T> __WITH__(bool Corner, bool Corner_With_Handles, bool Smooth, bool Smooth_Symmetric, bool FindPointOnCurve, T PointEditorControls, bool Hover_Control, bool Force_Selection)
        {
            n8.BezierEditorControlsData_R<T> that_0 = this;
            that_0 = Corner != this.Corner || Corner_With_Handles != this.Corner_With_Handles || Smooth != this.Smooth || Smooth_Symmetric != this.Smooth_Symmetric || FindPointOnCurve != this.FindPointOnCurve || !n23.EqualityComparer<T>.Default.Equals(PointEditorControls, this.PointEditorControls) || Hover_Control != this.Hover_Control || Force_Selection != this.Force_Selection ? new BezierEditorControlsData_R<T>(this)
            {Corner = Corner, Corner_With_Handles = Corner_With_Handles, Smooth = Smooth, Smooth_Symmetric = Smooth_Symmetric, FindPointOnCurve = FindPointOnCurve, PointEditorControls = PointEditorControls, Hover_Control = Hover_Control, Force_Selection = Force_Selection} : that_0;
            return that_0;
        }
    }
}

namespace _VL_Editors_
{
    public struct __AdaptiveImplementations__RMDMfKmnIrVPStLdWe8u30 : n5.IAdaptiveCreateDefault<n3.Vector2>, n5.IAdaptiveCreateDefault<n3.Vector3>, n5.IAdaptiveCreateDefault<float>, n21.IAdaptiveOperatorMinus<float>, n21.IAdaptiveOperatorLess<float>, n65.IAdaptiveTryParse<int>, n5.IAdaptiveCreateDefault<int>, n65.IAdaptiveTryParse<float>, n5.IAdaptiveCreateDefault<bool>, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditablePoint_R<n3.Vector2>>>, n21.IAdaptiveOperatorPlus<n3.Vector2>, n21.IAdaptiveOperatorMinus<n3.Vector2>, n53.IAdaptiveToXYZ<n3.Vector2>, n21.IAdaptiveOperatorDivide_Scale<n3.Vector2>, n5.IAdaptiveCreateDefault<n8.PointEditorControlsData_R>, n21.IAdaptiveLength<n3.Vector2>, n21.IAdaptiveOperatorMulitply_Scale<n3.Vector2>, n21.IAdaptiveNormalize<n3.Vector2>, n21.IAdaptiveOperatorMinus_Negate<n3.Vector2>, n21.IAdaptiveLerp<n3.Vector2>, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>>>, n21.IAdaptiveOperatorEquals<n3.Vector2>, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditablePoint_R<n3.Vector3>>>, n21.IAdaptiveOperatorPlus<n3.Vector3>, n21.IAdaptiveOne<n3.Vector3>, n21.IAdaptiveOperatorMulitply<n3.Vector3>, n21.IAdaptiveOperatorMinus<n3.Vector3>, n21.IAdaptiveOperatorMulitply<float>, n21.IAdaptiveOperatorDivide<float>, n21.IAdaptiveOperatorGreater<float>, n21.IAdaptiveFloor_Float<float>, n53.IAdaptiveToXYZ<n3.Vector3>, n21.IAdaptiveOperatorDivide_Scale<n3.Vector3>, n21.IAdaptiveLength<float>, n21.IAdaptiveLength<n3.Vector3>, n21.IAdaptiveOperatorMulitply_Scale<n3.Vector3>, n21.IAdaptiveNormalize<n3.Vector3>, n21.IAdaptiveOperatorMinus_Negate<n3.Vector3>, n21.IAdaptiveLerp<n3.Vector3>, n5.IAdaptiveCreateDefault<n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>>>, n21.IAdaptiveOperatorEquals<n3.Vector3>
    {
        public void CreateDefault(out n3.Vector2 Output_Out)
        {
            var Zero_0 = n48._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void CreateDefault(out n3.Vector3 Output_Out)
        {
            var Zero_0 = n51._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n63._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void TryParse(string String_In, out int Value_Out, out bool Success_Out)
        {
            var Result_1 = n35.StringExtensions.TryParse(@string: String_In, value: out int Value_0);
            Value_Out = Value_0;
            Success_Out = Result_1;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n63._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void TryParse(string String_In, out float Value_Out, out bool Success_Out)
        {
            var Result_1 = n35.StringExtensions.TryParse(@string: String_In, value: out float Value_0);
            Value_Out = Value_0;
            Success_Out = Result_1;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n63._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n10.Spread<n8.EditablePoint_R<n3.Vector2>> Output_Out)
        {
            var Empty_0 = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector2>>();
            Output_Out = Empty_0;
            return;
        }

        public void OperatorPlus(n3.Vector2 Input_In, n3.Vector2 Input_2_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Add(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n3.Vector2 Input_In, n3.Vector2 Input_2_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void ToXYZ(n3.Vector2 Vector_In, out n3.Vector3 Output_Out)
        {
            n64._Operations_.ToXYZ(Vector_In: Vector_In, Output_Out: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide_Scale(n3.Vector2 Input_In, float Scalar_In, out n3.Vector2 Output_Out)
        {
            n46.Vector2Nodes.DivScale(input: ref Input_In, scalar: Scalar_In, output: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.PointEditorControlsData_R Output_Out)
        {
            var Output_0 = n8.PointEditorControlsData_R.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void Length(n3.Vector2 Input_In, out float Result_Out)
        {
            var Result_0 = Input_In.Length();
            Result_Out = Result_0;
            return;
        }

        public void OperatorMulitply_Scale(n3.Vector2 Input_In, float Scalar_In, out n3.Vector2 Output_Out)
        {
            n46.Vector2Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Normalize(n3.Vector2 Input_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Normalize(value: ref Input_In, result: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus_Negate(n3.Vector2 Input_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Negate(value: ref Input_In, result: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Lerp(n3.Vector2 Input_In, n3.Vector2 Input_2_In, float Scalar_In, out n3.Vector2 Output_Out)
        {
            var Output_0 = n46.Vector2Nodes.Lerp(input: ref Input_In, input2: ref Input_2_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n10.Spread<n8.EditableBezierKnot_R<n3.Vector2>> Output_Out)
        {
            var Empty_0 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector2>>();
            Output_Out = Empty_0;
            return;
        }

        public void OperatorEquals(n3.Vector2 Input_In, n3.Vector2 Input_2_In, out bool Result_Out)
        {
            var Result_0 = n46.Vector2Nodes.Equals(input: ref Input_In, other: ref Input_2_In);
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out n10.Spread<n8.EditablePoint_R<n3.Vector3>> Output_Out)
        {
            var Empty_0 = n14._Operations_.CreateDefault<n8.EditablePoint_R<n3.Vector3>>();
            Output_Out = Empty_0;
            return;
        }

        public void OperatorPlus(n3.Vector3 Input_In, n3.Vector3 Input_2_In, out n3.Vector3 Output_Out)
        {
            n3.Vector3.Add(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n3.Vector3 One_Out)
        {
            var One_0 = n3.Vector3.One;
            One_Out = One_0;
            return;
        }

        public void OperatorMulitply(n3.Vector3 Input_In, n3.Vector3 Input_2_In, out n3.Vector3 Output_Out)
        {
            n46.Vector3Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n3.Vector3 Input_In, n3.Vector3 Input_2_In, out n3.Vector3 Output_Out)
        {
            n3.Vector3.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Floor_Float(float Input_In, out float Output_Out)
        {
            var Output_0 = n35.Float32Extensions.FloorFloat(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public void ToXYZ(n3.Vector3 Vector_In, out n3.Vector3 Output_Out)
        {
            n34._Operations_.ToXYZ(Vector_In: Vector_In, Output_Out: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide_Scale(n3.Vector3 Input_In, float Scalar_In, out n3.Vector3 Output_Out)
        {
            n46.Vector3Nodes.DivScale(input: ref Input_In, scalar: Scalar_In, output: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Length(float Input_In, out float Result_Out)
        {
            var Output_0 = n35.Float32Extensions.Length(input: Input_In);
            Result_Out = Output_0;
            return;
        }

        public void Length(n3.Vector3 Input_In, out float Result_Out)
        {
            var Result_0 = Input_In.Length();
            Result_Out = Result_0;
            return;
        }

        public void OperatorMulitply_Scale(n3.Vector3 Input_In, float Scalar_In, out n3.Vector3 Output_Out)
        {
            n46.Vector3Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Normalize(n3.Vector3 Input_In, out n3.Vector3 Output_Out)
        {
            n3.Vector3.Normalize(value: ref Input_In, result: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus_Negate(n3.Vector3 Input_In, out n3.Vector3 Output_Out)
        {
            n3.Vector3.Negate(value: ref Input_In, result: out n3.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Lerp(n3.Vector3 Input_In, n3.Vector3 Input_2_In, float Scalar_In, out n3.Vector3 Output_Out)
        {
            var Output_0 = n46.Vector3Nodes.Lerp(input: ref Input_In, input2: ref Input_2_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n10.Spread<n8.EditableBezierKnot_R<n3.Vector3>> Output_Out)
        {
            var Empty_0 = n14._Operations_.CreateDefault<n8.EditableBezierKnot_R<n3.Vector3>>();
            Output_Out = Empty_0;
            return;
        }

        public void OperatorEquals(n3.Vector3 Input_In, n3.Vector3 Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}