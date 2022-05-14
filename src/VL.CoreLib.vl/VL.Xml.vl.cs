extern alias e2;
extern alias e5;

using n18 = _VL_Xml_.System.XML.XNode;
using n38 = _VL_Xml_.System.XML.XDeclaration;
using n53 = _VL_Xml_.System.XML.XDocumentWriter_Reactive.Advanced;
using n50 = _VL_Xml_.System.XML.XDocumentWriter.Advanced;
using n51 = _VL_Reactive_.Reactive.ToObservable;
using n46 = _CoreLibBasics_.Primitive.Object.Advanced;
using n10 = _VL_CoreLib_Experimental_.Control.Try__3Outputs.Obsolete.Experimental;
using n33 = _CoreLibBasics_.Control;
using n31 = _CoreLibBasics_.System.Conversion.Adaptive;
using n52 = _VL_Xml_.System.XML.XDocumentReader_Reactive.Advanced;
using n12 = e2::VL.Lib.Text;
using n5 = _VL_Xml_.System.XML.XDocument;
using n54 = _VL_Reactive_.Reactive.Advanced;
using n9 = e2::VL.Lib.Control;
using n27 = e5::VL.Lib.Animation;
using n3 = _VL_Xml_.IO.Obsolete;
using n29 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n26 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n14 = global::System.Collections.Generic;
using n15 = _VL_CoreLib_Experimental_.Control.Try__2Outputs.Obsolete.Experimental;
using n16 = _CoreLibBasics_.IO.Path;
using n25 = _VL_Reactive_.Reactive.Observable.Advanced;
using n36 = _VL_Xml_.System.XML;
using n32 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n8 = _VL_Xml_.System.XML.Obsolete.Internal;
using n56 = _VL_CoreLib_IO_.IO;
using n55 = e2::VL.Lib.Primitive.CacheRegion;
using n48 = _VL_Xml_.System.XML.XAttribute;
using n22 = e2::VL.Lib.IO.Obsolete;
using n44 = global::System.Xml.XPath;
using n21 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n57 = _CoreLibBasics_.IO.Stream.Experimental;
using n24 = e2::VL.Lib.Xml;
using n34 = e5::VL.Lib.Basics.Resources;
using n2 = global::System;
using n42 = _VL_Reactive_.Reactive;
using n49 = _VL_Xml_.System.XML.XDocumentReader.Advanced;
using n23 = e2::VL.Lib.IO;
using n40 = _VL_Xml_;
using n7 = _VL_Xml_.System.XML.XElement;
using n43 = _VL_Reactive_.Reactive.ForEach;
using n39 = _VL_Xml_.System.XML.XDocumentType;
using n28 = _VL_CoreLib_IO_.IO.File_NoSharing_1.Obsolete;
using n20 = _VL_Reactive_.Reactive.HoldLatest;
using n45 = _VL_Collections_.Collections.Sequence;
using n13 = global::System.Runtime.CompilerServices;
using n17 = _CoreLibBasics_.Text.Encodings;
using n37 = _VL_Xml_.System.XML.Advanced;
using n30 = e5::VL.Lib.Collections;
using n11 = e5::VL.Lib.IO;
using n47 = _VL_Collections_.Collections.Spread;
using n35 = _CoreLibBasics_.System.Resources.Advanced;
using n41 = _VL_Reactive_.Reactive.Debug;
using n6 = global::System.Xml.Linq;
using n19 = global::System.IO;

namespace _VL_Xml_.IO.Obsolete
{
    [n1.ElementAttribute(TracingId = 209726U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "ONznqaraFfTO17wD7cHvB2", Name = "FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2")]
    [n2.SerializableAttribute]
    public class FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 CreateDefault()
        {
            var instance = new FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 Update(n11.Path File_Path_In, n12.Encodings Encoding_In, string Root_Element_Name_In, bool Write_Array_Attribute_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Read_In, out n6.XDocument Data_Out, out n6.XElement Root_Out, out bool On_Completed_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n6.XDocument Default_Output_1_0 = n5._Operations_.CreateDefault();
            n6.XElement Default_Output_2_1 = n7._Operations_.CreateDefault();
            bool Default_Output_3_2 = false;
            bool Re_Initialize_3 = false;
            var __fallback___4 = n1.ServiceRegistry.Current;
            n10._Operations_.Update_H<n2.Object, n6.XDocument, n6.XElement, bool>(Input_In: this.__p_F09yCQqYQO8NEzZeb5vbMO, Default_Output_1_In: Default_Output_1_0, Default_Output_2_In: Default_Output_2_1, Default_Output_3_In: Default_Output_3_2, Re_Initialize_In: Re_Initialize_3, Try_In: (n2.Object s_7) =>
            {
                using var __current_5 = __fallback___4.MakeCurrentIfNone();
                var state_6 = n1.CompilationHelper.Restore<__Gcg7wTykhXVNJLdXlyUiak>(s_7, __GetContext__());
                var Output_8 = state_6.__p_Lv69RRF44uPLO31x0MvAkK;
                if (Read_In)
                {
                    Output_8 = state_6.__p_Lv69RRF44uPLO31x0MvAkK.Read(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Deserialize_Root_Element_Name_In: Root_Element_Name_In, Write_Array_Attribute_In: Write_Array_Attribute_In);
                }

                var Output_12 = Output_8.Update(Data_Out: out n6.XDocument Data_9, Root_Out: out n6.XElement Root_10, On_Completed_Out: out bool On_Completed_11);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_12 != state_6.__p_Lv69RRF44uPLO31x0MvAkK ? new __Gcg7wTykhXVNJLdXlyUiak(state_6)
                    {__p_Lv69RRF44uPLO31x0MvAkK = Output_12} : state_6;
                else
                {
                    state_6.__p_Lv69RRF44uPLO31x0MvAkK = Output_12;
                }

                return n2.Tuple.Create<n2.Object, n6.XDocument, n6.XElement, bool>(state_6, Data_9, Root_10, On_Completed_11);
            }

            , Create_In: () =>
            {
                using var __current_13 = __fallback___4.MakeCurrentIfNone();
                var state_6 = new __Gcg7wTykhXVNJLdXlyUiak(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Lv69RRF44uPLO31x0MvAkK", 209785U);
                var Output_15 = n8.FileReader_JSON_NoErrorHandling_1_C.Create(Node_Context: Node_Context_14);
                state_6.__p_Lv69RRF44uPLO31x0MvAkK = Output_15;
                return state_6;
            }

            , Output_Out: out n9.TryStateful3<n2.Object> Output_16, Output_1_Out: out n6.XDocument Output_1_17, Output_2_Out: out n6.XElement Output_2_18, Output_3_Out: out bool Output_3_19, Success_Out: out bool Success_20, Error_Message_Out: out string Error_Message_21);
            Data_Out = Output_1_17;
            Root_Out = Output_2_18;
            On_Completed_Out = Output_3_19;
            Success_Out = Success_20;
            Error_Message_Out = Error_Message_21;
            n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = Output_16 != this.__p_F09yCQqYQO8NEzZeb5vbMO ? new FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(this)
                {__p_F09yCQqYQO8NEzZeb5vbMO = Output_16} : that_22;
            else
            {
                this.__p_F09yCQqYQO8NEzZeb5vbMO = Output_16;
            }

            return that_22;
        }

        public n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "F09yCQqYQO8NEzZeb5vbMO", 209752U);
            n10._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_0, Output_Out: out n9.TryStateful3<n2.Object> Output_1);
            n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 that_2 = this;
            this.__p_F09yCQqYQO8NEzZeb5vbMO = Output_1;
            return that_2;
        }

        public n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 __CreateDefault__()
        {
            n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 that_0 = this;
            this.__p_F09yCQqYQO8NEzZeb5vbMO = default(n9.TryStateful3<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_F09yCQqYQO8NEzZeb5vbMO);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 209752U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "F09yCQqYQO8NEzZeb5vbMO", Name = "Try (3Outputs)", IsManaged = true, IsAutoGenerated = true)]
        public n9.TryStateful3<n2.Object> __p_F09yCQqYQO8NEzZeb5vbMO;
        public FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 other): base(other)
        {
            this.__p_F09yCQqYQO8NEzZeb5vbMO = other.__p_F09yCQqYQO8NEzZeb5vbMO;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F09yCQqYQO8NEzZeb5vbMO", in __p_F09yCQqYQO8NEzZeb5vbMO));
        }

        internal FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 __WITH__(n9.TryStateful3<n2.Object> __p_F09yCQqYQO8NEzZeb5vbMO)
        {
            n3.FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_F09yCQqYQO8NEzZeb5vbMO != this.__p_F09yCQqYQO8NEzZeb5vbMO ? new FileReader_JSON_1_ONznqaraFfTO17wD7cHvB2(this)
                {__p_F09yCQqYQO8NEzZeb5vbMO = __p_F09yCQqYQO8NEzZeb5vbMO} : that_0;
            else
            {
                this.__p_F09yCQqYQO8NEzZeb5vbMO = __p_F09yCQqYQO8NEzZeb5vbMO;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Gcg7wTykhXVNJLdXlyUiak", Name = "__Gcg7wTykhXVNJLdXlyUiak")]
        [n2.SerializableAttribute]
        public class __Gcg7wTykhXVNJLdXlyUiak : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Lv69RRF44uPLO31x0MvAkK);
                return;
            }

            [n1.ElementAttribute(TracingId = 209785U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Lv69RRF44uPLO31x0MvAkK", Name = "FileReader (JSON NoErrorHandling 1)", IsManaged = true, IsAutoGenerated = true)]
            public n8.FileReader_JSON_NoErrorHandling_1_C __p_Lv69RRF44uPLO31x0MvAkK;
            public __Gcg7wTykhXVNJLdXlyUiak(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Gcg7wTykhXVNJLdXlyUiak(__Gcg7wTykhXVNJLdXlyUiak other): base(other)
            {
                this.__p_Lv69RRF44uPLO31x0MvAkK = other.__p_Lv69RRF44uPLO31x0MvAkK;
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Lv69RRF44uPLO31x0MvAkK", in __p_Lv69RRF44uPLO31x0MvAkK));
            }

            internal __Gcg7wTykhXVNJLdXlyUiak __WITH__(n8.FileReader_JSON_NoErrorHandling_1_C __p_Lv69RRF44uPLO31x0MvAkK)
            {
                __Gcg7wTykhXVNJLdXlyUiak that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Lv69RRF44uPLO31x0MvAkK != this.__p_Lv69RRF44uPLO31x0MvAkK ? new __Gcg7wTykhXVNJLdXlyUiak(this)
                    {__p_Lv69RRF44uPLO31x0MvAkK = __p_Lv69RRF44uPLO31x0MvAkK} : that_0;
                else
                {
                    this.__p_Lv69RRF44uPLO31x0MvAkK = __p_Lv69RRF44uPLO31x0MvAkK;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 209921U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "KNjbqVB34ftQTFNbReBMiE", Name = "FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE")]
    [n2.SerializableAttribute]
    public class FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE Create(n1.NodeContext Node_Context)
        {
            var instance = new FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE CreateDefault()
        {
            var instance = new FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE Update(n11.Path File_Path_In, n12.Encodings Encoding_In, n6.LoadOptions Options_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Read_In, out n6.XDocument Data_Out, out n6.XElement Root_Out, out bool On_Completed_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n6.XDocument Default_Output_1_0 = n5._Operations_.CreateDefault();
            n6.XElement Default_Output_2_1 = n7._Operations_.CreateDefault();
            bool Default_Output_3_2 = false;
            bool Re_Initialize_3 = false;
            var __fallback___4 = n1.ServiceRegistry.Current;
            n10._Operations_.Update_H<n2.Object, n6.XDocument, n6.XElement, bool>(Input_In: this.__p_DvSSDefziBtMBvilLRetBv, Default_Output_1_In: Default_Output_1_0, Default_Output_2_In: Default_Output_2_1, Default_Output_3_In: Default_Output_3_2, Re_Initialize_In: Re_Initialize_3, Try_In: (n2.Object s_7) =>
            {
                using var __current_5 = __fallback___4.MakeCurrentIfNone();
                var state_6 = n1.CompilationHelper.Restore<__EsIuMmb9pjpOIq3Yqp1zez>(s_7, __GetContext__());
                var Output_8 = state_6.__p_EkbDdG74u8ZPIjDp6b3sef;
                if (Read_In)
                {
                    Output_8 = state_6.__p_EkbDdG74u8ZPIjDp6b3sef.Read(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Options_In: Options_In);
                }

                var Output_12 = Output_8.Update(Data_Out: out n6.XDocument Data_9, Root_Out: out n6.XElement Root_10, On_Completed_Out: out bool On_Completed_11);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_12 != state_6.__p_EkbDdG74u8ZPIjDp6b3sef ? new __EsIuMmb9pjpOIq3Yqp1zez(state_6)
                    {__p_EkbDdG74u8ZPIjDp6b3sef = Output_12} : state_6;
                else
                {
                    state_6.__p_EkbDdG74u8ZPIjDp6b3sef = Output_12;
                }

                return n2.Tuple.Create<n2.Object, n6.XDocument, n6.XElement, bool>(state_6, Data_9, Root_10, On_Completed_11);
            }

            , Create_In: () =>
            {
                using var __current_13 = __fallback___4.MakeCurrentIfNone();
                var state_6 = new __EsIuMmb9pjpOIq3Yqp1zez(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "EkbDdG74u8ZPIjDp6b3sef", 209952U);
                var Output_15 = n8.FileReader_XML_NoErrorHandling_1_C.Create(Node_Context: Node_Context_14);
                state_6.__p_EkbDdG74u8ZPIjDp6b3sef = Output_15;
                return state_6;
            }

            , Output_Out: out n9.TryStateful3<n2.Object> Output_16, Output_1_Out: out n6.XDocument Output_1_17, Output_2_Out: out n6.XElement Output_2_18, Output_3_Out: out bool Output_3_19, Success_Out: out bool Success_20, Error_Message_Out: out string Error_Message_21);
            Data_Out = Output_1_17;
            Root_Out = Output_2_18;
            On_Completed_Out = Output_3_19;
            Success_Out = Success_20;
            Error_Message_Out = Error_Message_21;
            n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = Output_16 != this.__p_DvSSDefziBtMBvilLRetBv ? new FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(this)
                {__p_DvSSDefziBtMBvilLRetBv = Output_16} : that_22;
            else
            {
                this.__p_DvSSDefziBtMBvilLRetBv = Output_16;
            }

            return that_22;
        }

        public n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "DvSSDefziBtMBvilLRetBv", 209927U);
            n10._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_0, Output_Out: out n9.TryStateful3<n2.Object> Output_1);
            n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE that_2 = this;
            this.__p_DvSSDefziBtMBvilLRetBv = Output_1;
            return that_2;
        }

        public n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE __CreateDefault__()
        {
            n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE that_0 = this;
            this.__p_DvSSDefziBtMBvilLRetBv = default(n9.TryStateful3<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DvSSDefziBtMBvilLRetBv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 209927U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DvSSDefziBtMBvilLRetBv", Name = "Try (3Outputs)", IsManaged = true, IsAutoGenerated = true)]
        public n9.TryStateful3<n2.Object> __p_DvSSDefziBtMBvilLRetBv;
        public FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE other): base(other)
        {
            this.__p_DvSSDefziBtMBvilLRetBv = other.__p_DvSSDefziBtMBvilLRetBv;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DvSSDefziBtMBvilLRetBv", in __p_DvSSDefziBtMBvilLRetBv));
        }

        internal FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE __WITH__(n9.TryStateful3<n2.Object> __p_DvSSDefziBtMBvilLRetBv)
        {
            n3.FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DvSSDefziBtMBvilLRetBv != this.__p_DvSSDefziBtMBvilLRetBv ? new FileReader_XML_1_KNjbqVB34ftQTFNbReBMiE(this)
                {__p_DvSSDefziBtMBvilLRetBv = __p_DvSSDefziBtMBvilLRetBv} : that_0;
            else
            {
                this.__p_DvSSDefziBtMBvilLRetBv = __p_DvSSDefziBtMBvilLRetBv;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EsIuMmb9pjpOIq3Yqp1zez", Name = "__EsIuMmb9pjpOIq3Yqp1zez")]
        [n2.SerializableAttribute]
        public class __EsIuMmb9pjpOIq3Yqp1zez : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EkbDdG74u8ZPIjDp6b3sef);
                return;
            }

            [n1.ElementAttribute(TracingId = 209952U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EkbDdG74u8ZPIjDp6b3sef", Name = "FileReader (XML NoErrorHandling 1)", IsManaged = true, IsAutoGenerated = true)]
            public n8.FileReader_XML_NoErrorHandling_1_C __p_EkbDdG74u8ZPIjDp6b3sef;
            public __EsIuMmb9pjpOIq3Yqp1zez(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EsIuMmb9pjpOIq3Yqp1zez(__EsIuMmb9pjpOIq3Yqp1zez other): base(other)
            {
                this.__p_EkbDdG74u8ZPIjDp6b3sef = other.__p_EkbDdG74u8ZPIjDp6b3sef;
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EkbDdG74u8ZPIjDp6b3sef", in __p_EkbDdG74u8ZPIjDp6b3sef));
            }

            internal __EsIuMmb9pjpOIq3Yqp1zez __WITH__(n8.FileReader_XML_NoErrorHandling_1_C __p_EkbDdG74u8ZPIjDp6b3sef)
            {
                __EsIuMmb9pjpOIq3Yqp1zez that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EkbDdG74u8ZPIjDp6b3sef != this.__p_EkbDdG74u8ZPIjDp6b3sef ? new __EsIuMmb9pjpOIq3Yqp1zez(this)
                    {__p_EkbDdG74u8ZPIjDp6b3sef = __p_EkbDdG74u8ZPIjDp6b3sef} : that_0;
                else
                {
                    this.__p_EkbDdG74u8ZPIjDp6b3sef = __p_EkbDdG74u8ZPIjDp6b3sef;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 210096U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "LO29WxGQZ6eMZ1jTmWQ24C", Name = "FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C")]
    [n2.SerializableAttribute]
    public class FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C CreateDefault()
        {
            var instance = new FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C Update(n6.XNode Data_In, n11.Path File_Path_In, n12.Encodings Encoding_In, bool Indent_In, bool Omit_Root_Object_In, bool Write_In, out bool On_Completed_Out, out bool In_Progress_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n6.XNode __pad_T81G5z1cRjzMOfAhlCCBEY_0 = Data_In;
            n11.Path __pad_TK1YyzdjL60MLLsYUgLduE_1 = File_Path_In;
            n12.Encodings __pad_EZ2sXogtJLjMD1dS1T7DVo_2 = Encoding_In;
            bool __pad_SeIn6mXK0dSOnUKpSi7ZrJ_3 = Indent_In;
            bool __pad_THcUaX9C1hZQYR1KrbSMNk_4 = Omit_Root_Object_In;
            bool __pad_MwiI9W06XYmNWBAADBknvK_5 = Write_In;
            bool Default_Output_1_6 = false;
            bool Default_Output_2_7 = false;
            bool Re_Initialize_8 = false;
            var __fallback___9 = n1.ServiceRegistry.Current;
            n15._Operations_.Update_H<n2.Object, bool, bool>(Input_In: this.__p_DDDct97J6WBP6E8xgxrJbO, Default_Output_1_In: Default_Output_1_6, Default_Output_2_In: Default_Output_2_7, Re_Initialize_In: Re_Initialize_8, Try_In: (n2.Object s_12) =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                var state_11 = n1.CompilationHelper.Restore<__LjXFhnynyoAQVuocutQqd6>(s_12, __GetContext__());
                var Output_13 = state_11.__p_FQttN4m41ARLU2tIoFi3VT;
                if (__pad_MwiI9W06XYmNWBAADBknvK_5)
                {
                    Output_13 = state_11.__p_FQttN4m41ARLU2tIoFi3VT.Write<n6.XNode>(XNode_In: __pad_T81G5z1cRjzMOfAhlCCBEY_0, File_Path_In: __pad_TK1YyzdjL60MLLsYUgLduE_1, Encoding_In: __pad_EZ2sXogtJLjMD1dS1T7DVo_2, Indent_In: __pad_SeIn6mXK0dSOnUKpSi7ZrJ_3, Omit_Root_Object_In: __pad_THcUaX9C1hZQYR1KrbSMNk_4);
                }

                var Output_16 = Output_13.Update(On_Completed_Out: out bool On_Completed_14, In_Progress_Out: out bool In_Progress_15);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = Output_16 != state_11.__p_FQttN4m41ARLU2tIoFi3VT ? new __LjXFhnynyoAQVuocutQqd6(state_11)
                    {__p_FQttN4m41ARLU2tIoFi3VT = Output_16} : state_11;
                else
                {
                    state_11.__p_FQttN4m41ARLU2tIoFi3VT = Output_16;
                }

                return n2.Tuple.Create<n2.Object, bool, bool>(state_11, On_Completed_14, In_Progress_15);
            }

            , Create_In: () =>
            {
                using var __current_17 = __fallback___9.MakeCurrentIfNone();
                var state_11 = new __LjXFhnynyoAQVuocutQqd6(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "FQttN4m41ARLU2tIoFi3VT", 210135U);
                var Output_19 = n8.FileWriter_JSON_NoErrorHandling_1_C.Create(Node_Context: Node_Context_18);
                state_11.__p_FQttN4m41ARLU2tIoFi3VT = Output_19;
                return state_11;
            }

            , Output_Out: out n9.TryStateful2<n2.Object> Output_20, Output_1_Out: out bool Output_1_21, Output_2_Out: out bool Output_2_22, Success_Out: out bool Success_23, Error_Message_Out: out string Error_Message_24);
            On_Completed_Out = Output_1_21;
            In_Progress_Out = Output_2_22;
            Success_Out = Success_23;
            Error_Message_Out = Error_Message_24;
            n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Data_In != this.__slot_T81G5z1cRjzMOfAhlCCBEY || File_Path_In != this.__slot_TK1YyzdjL60MLLsYUgLduE || !n14.EqualityComparer<n12.Encodings>.Default.Equals(Encoding_In, this.__slot_EZ2sXogtJLjMD1dS1T7DVo) || Indent_In != this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ || Omit_Root_Object_In != this.__slot_THcUaX9C1hZQYR1KrbSMNk || Write_In != this.__slot_MwiI9W06XYmNWBAADBknvK || Output_20 != this.__p_DDDct97J6WBP6E8xgxrJbO ? new FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(this)
                {__slot_T81G5z1cRjzMOfAhlCCBEY = Data_In, __slot_TK1YyzdjL60MLLsYUgLduE = File_Path_In, __slot_EZ2sXogtJLjMD1dS1T7DVo = Encoding_In, __slot_SeIn6mXK0dSOnUKpSi7ZrJ = Indent_In, __slot_THcUaX9C1hZQYR1KrbSMNk = Omit_Root_Object_In, __slot_MwiI9W06XYmNWBAADBknvK = Write_In, __p_DDDct97J6WBP6E8xgxrJbO = Output_20} : that_25;
            else
            {
                this.__slot_T81G5z1cRjzMOfAhlCCBEY = Data_In;
                this.__slot_TK1YyzdjL60MLLsYUgLduE = File_Path_In;
                this.__slot_EZ2sXogtJLjMD1dS1T7DVo = Encoding_In;
                this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ = Indent_In;
                this.__slot_THcUaX9C1hZQYR1KrbSMNk = Omit_Root_Object_In;
                this.__slot_MwiI9W06XYmNWBAADBknvK = Write_In;
                this.__p_DDDct97J6WBP6E8xgxrJbO = Output_20;
            }

            return that_25;
        }

        public n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "DDDct97J6WBP6E8xgxrJbO", 210107U);
            n15._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_0, Output_Out: out n9.TryStateful2<n2.Object> Output_1);
            n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C that_2 = this;
            this.__slot_MwiI9W06XYmNWBAADBknvK = false;
            this.__slot_TK1YyzdjL60MLLsYUgLduE = n16._Operations_.CreateDefault();
            this.__slot_EZ2sXogtJLjMD1dS1T7DVo = n17._Operations_.CreateDefault();
            this.__slot_T81G5z1cRjzMOfAhlCCBEY = n18._Operations_.CreateDefault();
            this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ = false;
            this.__slot_THcUaX9C1hZQYR1KrbSMNk = false;
            this.__p_DDDct97J6WBP6E8xgxrJbO = Output_1;
            return that_2;
        }

        public n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C __CreateDefault__()
        {
            n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C that_0 = this;
            this.__slot_MwiI9W06XYmNWBAADBknvK = false;
            this.__slot_TK1YyzdjL60MLLsYUgLduE = n16._Operations_.CreateDefault();
            this.__slot_EZ2sXogtJLjMD1dS1T7DVo = n17._Operations_.CreateDefault();
            this.__slot_T81G5z1cRjzMOfAhlCCBEY = n18._Operations_.CreateDefault();
            this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ = false;
            this.__slot_THcUaX9C1hZQYR1KrbSMNk = false;
            this.__p_DDDct97J6WBP6E8xgxrJbO = default(n9.TryStateful2<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DDDct97J6WBP6E8xgxrJbO);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 210234U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MwiI9W06XYmNWBAADBknvK", Name = "__slot_MwiI9W06XYmNWBAADBknvK")]
        public bool __slot_MwiI9W06XYmNWBAADBknvK;
        [n1.ElementAttribute(TracingId = 210238U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "TK1YyzdjL60MLLsYUgLduE", Name = "__slot_TK1YyzdjL60MLLsYUgLduE")]
        public n11.Path __slot_TK1YyzdjL60MLLsYUgLduE;
        [n1.ElementAttribute(TracingId = 210239U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EZ2sXogtJLjMD1dS1T7DVo", Name = "__slot_EZ2sXogtJLjMD1dS1T7DVo")]
        public n12.Encodings __slot_EZ2sXogtJLjMD1dS1T7DVo;
        [n1.ElementAttribute(TracingId = 210242U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "T81G5z1cRjzMOfAhlCCBEY", Name = "__slot_T81G5z1cRjzMOfAhlCCBEY")]
        public n6.XNode __slot_T81G5z1cRjzMOfAhlCCBEY;
        [n1.ElementAttribute(TracingId = 210245U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SeIn6mXK0dSOnUKpSi7ZrJ", Name = "__slot_SeIn6mXK0dSOnUKpSi7ZrJ")]
        public bool __slot_SeIn6mXK0dSOnUKpSi7ZrJ;
        [n1.ElementAttribute(TracingId = 210247U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "THcUaX9C1hZQYR1KrbSMNk", Name = "__slot_THcUaX9C1hZQYR1KrbSMNk")]
        public bool __slot_THcUaX9C1hZQYR1KrbSMNk;
        [n1.ElementAttribute(TracingId = 210107U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DDDct97J6WBP6E8xgxrJbO", Name = "Try (2Outputs)", IsManaged = true, IsAutoGenerated = true)]
        public n9.TryStateful2<n2.Object> __p_DDDct97J6WBP6E8xgxrJbO;
        public FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C other): base(other)
        {
            this.__slot_MwiI9W06XYmNWBAADBknvK = other.__slot_MwiI9W06XYmNWBAADBknvK;
            this.__slot_TK1YyzdjL60MLLsYUgLduE = other.__slot_TK1YyzdjL60MLLsYUgLduE;
            this.__slot_EZ2sXogtJLjMD1dS1T7DVo = other.__slot_EZ2sXogtJLjMD1dS1T7DVo;
            this.__slot_T81G5z1cRjzMOfAhlCCBEY = other.__slot_T81G5z1cRjzMOfAhlCCBEY;
            this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ = other.__slot_SeIn6mXK0dSOnUKpSi7ZrJ;
            this.__slot_THcUaX9C1hZQYR1KrbSMNk = other.__slot_THcUaX9C1hZQYR1KrbSMNk;
            this.__p_DDDct97J6WBP6E8xgxrJbO = other.__p_DDDct97J6WBP6E8xgxrJbO;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_MwiI9W06XYmNWBAADBknvK", in __slot_MwiI9W06XYmNWBAADBknvK), n1.CompilationHelper.GetValueOrExisting(values, "__slot_TK1YyzdjL60MLLsYUgLduE", in __slot_TK1YyzdjL60MLLsYUgLduE), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EZ2sXogtJLjMD1dS1T7DVo", in __slot_EZ2sXogtJLjMD1dS1T7DVo), n1.CompilationHelper.GetValueOrExisting(values, "__slot_T81G5z1cRjzMOfAhlCCBEY", in __slot_T81G5z1cRjzMOfAhlCCBEY), n1.CompilationHelper.GetValueOrExisting(values, "__slot_SeIn6mXK0dSOnUKpSi7ZrJ", in __slot_SeIn6mXK0dSOnUKpSi7ZrJ), n1.CompilationHelper.GetValueOrExisting(values, "__slot_THcUaX9C1hZQYR1KrbSMNk", in __slot_THcUaX9C1hZQYR1KrbSMNk), n1.CompilationHelper.GetValueOrExisting(values, "__p_DDDct97J6WBP6E8xgxrJbO", in __p_DDDct97J6WBP6E8xgxrJbO));
        }

        internal FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C __WITH__(bool __slot_MwiI9W06XYmNWBAADBknvK, n11.Path __slot_TK1YyzdjL60MLLsYUgLduE, n12.Encodings __slot_EZ2sXogtJLjMD1dS1T7DVo, n6.XNode __slot_T81G5z1cRjzMOfAhlCCBEY, bool __slot_SeIn6mXK0dSOnUKpSi7ZrJ, bool __slot_THcUaX9C1hZQYR1KrbSMNk, n9.TryStateful2<n2.Object> __p_DDDct97J6WBP6E8xgxrJbO)
        {
            n3.FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_MwiI9W06XYmNWBAADBknvK != this.__slot_MwiI9W06XYmNWBAADBknvK || __slot_TK1YyzdjL60MLLsYUgLduE != this.__slot_TK1YyzdjL60MLLsYUgLduE || !n14.EqualityComparer<n12.Encodings>.Default.Equals(__slot_EZ2sXogtJLjMD1dS1T7DVo, this.__slot_EZ2sXogtJLjMD1dS1T7DVo) || __slot_T81G5z1cRjzMOfAhlCCBEY != this.__slot_T81G5z1cRjzMOfAhlCCBEY || __slot_SeIn6mXK0dSOnUKpSi7ZrJ != this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ || __slot_THcUaX9C1hZQYR1KrbSMNk != this.__slot_THcUaX9C1hZQYR1KrbSMNk || __p_DDDct97J6WBP6E8xgxrJbO != this.__p_DDDct97J6WBP6E8xgxrJbO ? new FileWriter_JSON_1_LO29WxGQZ6eMZ1jTmWQ24C(this)
                {__slot_MwiI9W06XYmNWBAADBknvK = __slot_MwiI9W06XYmNWBAADBknvK, __slot_TK1YyzdjL60MLLsYUgLduE = __slot_TK1YyzdjL60MLLsYUgLduE, __slot_EZ2sXogtJLjMD1dS1T7DVo = __slot_EZ2sXogtJLjMD1dS1T7DVo, __slot_T81G5z1cRjzMOfAhlCCBEY = __slot_T81G5z1cRjzMOfAhlCCBEY, __slot_SeIn6mXK0dSOnUKpSi7ZrJ = __slot_SeIn6mXK0dSOnUKpSi7ZrJ, __slot_THcUaX9C1hZQYR1KrbSMNk = __slot_THcUaX9C1hZQYR1KrbSMNk, __p_DDDct97J6WBP6E8xgxrJbO = __p_DDDct97J6WBP6E8xgxrJbO} : that_0;
            else
            {
                this.__slot_MwiI9W06XYmNWBAADBknvK = __slot_MwiI9W06XYmNWBAADBknvK;
                this.__slot_TK1YyzdjL60MLLsYUgLduE = __slot_TK1YyzdjL60MLLsYUgLduE;
                this.__slot_EZ2sXogtJLjMD1dS1T7DVo = __slot_EZ2sXogtJLjMD1dS1T7DVo;
                this.__slot_T81G5z1cRjzMOfAhlCCBEY = __slot_T81G5z1cRjzMOfAhlCCBEY;
                this.__slot_SeIn6mXK0dSOnUKpSi7ZrJ = __slot_SeIn6mXK0dSOnUKpSi7ZrJ;
                this.__slot_THcUaX9C1hZQYR1KrbSMNk = __slot_THcUaX9C1hZQYR1KrbSMNk;
                this.__p_DDDct97J6WBP6E8xgxrJbO = __p_DDDct97J6WBP6E8xgxrJbO;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "LjXFhnynyoAQVuocutQqd6", Name = "__LjXFhnynyoAQVuocutQqd6")]
        [n2.SerializableAttribute]
        public class __LjXFhnynyoAQVuocutQqd6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FQttN4m41ARLU2tIoFi3VT);
                return;
            }

            [n1.ElementAttribute(TracingId = 210135U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "FQttN4m41ARLU2tIoFi3VT", Name = "FileWriter (JSON NoErrorHandling 1)", IsManaged = true, IsAutoGenerated = true)]
            public n8.FileWriter_JSON_NoErrorHandling_1_C __p_FQttN4m41ARLU2tIoFi3VT;
            public __LjXFhnynyoAQVuocutQqd6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LjXFhnynyoAQVuocutQqd6(__LjXFhnynyoAQVuocutQqd6 other): base(other)
            {
                this.__p_FQttN4m41ARLU2tIoFi3VT = other.__p_FQttN4m41ARLU2tIoFi3VT;
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FQttN4m41ARLU2tIoFi3VT", in __p_FQttN4m41ARLU2tIoFi3VT));
            }

            internal __LjXFhnynyoAQVuocutQqd6 __WITH__(n8.FileWriter_JSON_NoErrorHandling_1_C __p_FQttN4m41ARLU2tIoFi3VT)
            {
                __LjXFhnynyoAQVuocutQqd6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FQttN4m41ARLU2tIoFi3VT != this.__p_FQttN4m41ARLU2tIoFi3VT ? new __LjXFhnynyoAQVuocutQqd6(this)
                    {__p_FQttN4m41ARLU2tIoFi3VT = __p_FQttN4m41ARLU2tIoFi3VT} : that_0;
                else
                {
                    this.__p_FQttN4m41ARLU2tIoFi3VT = __p_FQttN4m41ARLU2tIoFi3VT;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 210356U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Iv8uSC23OROOGCWLfpOrIq", Name = "FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq")]
    [n2.SerializableAttribute]
    public class FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq Create(n1.NodeContext Node_Context)
        {
            var instance = new FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq CreateDefault()
        {
            var instance = new FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq Update(n6.XDocument Data_In, n11.Path File_Path_In, n6.SaveOptions SaveOptions_In, bool Write_In, out bool On_Completed_Out, out bool In_Progress_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n6.XDocument __pad_G2xdMLATTKIMApM8o5qHxu_0 = Data_In;
            n11.Path __pad_SPXttW4tLhKMb7XfNJPmcx_1 = File_Path_In;
            n6.SaveOptions __pad_E5yF90ZzoB1MGKDv6f6UE9_2 = SaveOptions_In;
            bool __pad_DPLFMiJJG4VPWWTzpVinql_3 = Write_In;
            bool Default_Output_1_4 = false;
            bool Default_Output_2_5 = false;
            bool Re_Initialize_6 = false;
            var __fallback___7 = n1.ServiceRegistry.Current;
            n15._Operations_.Update_H<n2.Object, bool, bool>(Input_In: this.__p_Re80nryq92POt2n4vcvk9w, Default_Output_1_In: Default_Output_1_4, Default_Output_2_In: Default_Output_2_5, Re_Initialize_In: Re_Initialize_6, Try_In: (n2.Object s_10) =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                var state_9 = n1.CompilationHelper.Restore<__O44Rx0plg2QLsJDaPTlkhv>(s_10, __GetContext__());
                var Output_11 = state_9.__p_Co5wMK8NvamP6xNIVGDDXt;
                if (__pad_DPLFMiJJG4VPWWTzpVinql_3)
                {
                    Output_11 = state_9.__p_Co5wMK8NvamP6xNIVGDDXt.Write(XDocument_In: __pad_G2xdMLATTKIMApM8o5qHxu_0, File_Path_In: __pad_SPXttW4tLhKMb7XfNJPmcx_1, SaveOptions_In: __pad_E5yF90ZzoB1MGKDv6f6UE9_2);
                }

                var Output_14 = Output_11.Update(On_Completed_Out: out bool On_Completed_12, In_Progress_Out: out bool In_Progress_13);
                if (state_9.__GetContext__().IsImmutable)
                    state_9 = Output_14 != state_9.__p_Co5wMK8NvamP6xNIVGDDXt ? new __O44Rx0plg2QLsJDaPTlkhv(state_9)
                    {__p_Co5wMK8NvamP6xNIVGDDXt = Output_14} : state_9;
                else
                {
                    state_9.__p_Co5wMK8NvamP6xNIVGDDXt = Output_14;
                }

                return n2.Tuple.Create<n2.Object, bool, bool>(state_9, On_Completed_12, In_Progress_13);
            }

            , Create_In: () =>
            {
                using var __current_15 = __fallback___7.MakeCurrentIfNone();
                var state_9 = new __O44Rx0plg2QLsJDaPTlkhv(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Co5wMK8NvamP6xNIVGDDXt", 210408U);
                var Output_17 = n8.FileWriter_XML_NoErrorHandling_1_C.Create(Node_Context: Node_Context_16);
                state_9.__p_Co5wMK8NvamP6xNIVGDDXt = Output_17;
                return state_9;
            }

            , Output_Out: out n9.TryStateful2<n2.Object> Output_18, Output_1_Out: out bool Output_1_19, Output_2_Out: out bool Output_2_20, Success_Out: out bool Success_21, Error_Message_Out: out string Error_Message_22);
            On_Completed_Out = Output_1_19;
            In_Progress_Out = Output_2_20;
            Success_Out = Success_21;
            Error_Message_Out = Error_Message_22;
            n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = Data_In != this.__slot_G2xdMLATTKIMApM8o5qHxu || File_Path_In != this.__slot_SPXttW4tLhKMb7XfNJPmcx || !n14.EqualityComparer<n6.SaveOptions>.Default.Equals(SaveOptions_In, this.__slot_E5yF90ZzoB1MGKDv6f6UE9) || Write_In != this.__slot_DPLFMiJJG4VPWWTzpVinql || Output_18 != this.__p_Re80nryq92POt2n4vcvk9w ? new FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(this)
                {__slot_G2xdMLATTKIMApM8o5qHxu = Data_In, __slot_SPXttW4tLhKMb7XfNJPmcx = File_Path_In, __slot_E5yF90ZzoB1MGKDv6f6UE9 = SaveOptions_In, __slot_DPLFMiJJG4VPWWTzpVinql = Write_In, __p_Re80nryq92POt2n4vcvk9w = Output_18} : that_23;
            else
            {
                this.__slot_G2xdMLATTKIMApM8o5qHxu = Data_In;
                this.__slot_SPXttW4tLhKMb7XfNJPmcx = File_Path_In;
                this.__slot_E5yF90ZzoB1MGKDv6f6UE9 = SaveOptions_In;
                this.__slot_DPLFMiJJG4VPWWTzpVinql = Write_In;
                this.__p_Re80nryq92POt2n4vcvk9w = Output_18;
            }

            return that_23;
        }

        public n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Re80nryq92POt2n4vcvk9w", 210388U);
            n15._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_0, Output_Out: out n9.TryStateful2<n2.Object> Output_1);
            n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq that_2 = this;
            this.__slot_G2xdMLATTKIMApM8o5qHxu = n5._Operations_.CreateDefault();
            this.__slot_SPXttW4tLhKMb7XfNJPmcx = n16._Operations_.CreateDefault();
            this.__slot_E5yF90ZzoB1MGKDv6f6UE9 = default(n6.SaveOptions);
            this.__slot_DPLFMiJJG4VPWWTzpVinql = false;
            this.__p_Re80nryq92POt2n4vcvk9w = Output_1;
            return that_2;
        }

        public n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq __CreateDefault__()
        {
            n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq that_0 = this;
            this.__slot_G2xdMLATTKIMApM8o5qHxu = n5._Operations_.CreateDefault();
            this.__slot_SPXttW4tLhKMb7XfNJPmcx = n16._Operations_.CreateDefault();
            this.__slot_E5yF90ZzoB1MGKDv6f6UE9 = default(n6.SaveOptions);
            this.__slot_DPLFMiJJG4VPWWTzpVinql = false;
            this.__p_Re80nryq92POt2n4vcvk9w = default(n9.TryStateful2<n2.Object>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Re80nryq92POt2n4vcvk9w);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 210359U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "G2xdMLATTKIMApM8o5qHxu", Name = "__slot_G2xdMLATTKIMApM8o5qHxu")]
        public n6.XDocument __slot_G2xdMLATTKIMApM8o5qHxu;
        [n1.ElementAttribute(TracingId = 210361U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SPXttW4tLhKMb7XfNJPmcx", Name = "__slot_SPXttW4tLhKMb7XfNJPmcx")]
        public n11.Path __slot_SPXttW4tLhKMb7XfNJPmcx;
        [n1.ElementAttribute(TracingId = 210364U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "E5yF90ZzoB1MGKDv6f6UE9", Name = "__slot_E5yF90ZzoB1MGKDv6f6UE9")]
        public n6.SaveOptions __slot_E5yF90ZzoB1MGKDv6f6UE9;
        [n1.ElementAttribute(TracingId = 210383U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DPLFMiJJG4VPWWTzpVinql", Name = "__slot_DPLFMiJJG4VPWWTzpVinql")]
        public bool __slot_DPLFMiJJG4VPWWTzpVinql;
        [n1.ElementAttribute(TracingId = 210388U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Re80nryq92POt2n4vcvk9w", Name = "Try (2Outputs)", IsManaged = true, IsAutoGenerated = true)]
        public n9.TryStateful2<n2.Object> __p_Re80nryq92POt2n4vcvk9w;
        public FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq other): base(other)
        {
            this.__slot_G2xdMLATTKIMApM8o5qHxu = other.__slot_G2xdMLATTKIMApM8o5qHxu;
            this.__slot_SPXttW4tLhKMb7XfNJPmcx = other.__slot_SPXttW4tLhKMb7XfNJPmcx;
            this.__slot_E5yF90ZzoB1MGKDv6f6UE9 = other.__slot_E5yF90ZzoB1MGKDv6f6UE9;
            this.__slot_DPLFMiJJG4VPWWTzpVinql = other.__slot_DPLFMiJJG4VPWWTzpVinql;
            this.__p_Re80nryq92POt2n4vcvk9w = other.__p_Re80nryq92POt2n4vcvk9w;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_G2xdMLATTKIMApM8o5qHxu", in __slot_G2xdMLATTKIMApM8o5qHxu), n1.CompilationHelper.GetValueOrExisting(values, "__slot_SPXttW4tLhKMb7XfNJPmcx", in __slot_SPXttW4tLhKMb7XfNJPmcx), n1.CompilationHelper.GetValueOrExisting(values, "__slot_E5yF90ZzoB1MGKDv6f6UE9", in __slot_E5yF90ZzoB1MGKDv6f6UE9), n1.CompilationHelper.GetValueOrExisting(values, "__slot_DPLFMiJJG4VPWWTzpVinql", in __slot_DPLFMiJJG4VPWWTzpVinql), n1.CompilationHelper.GetValueOrExisting(values, "__p_Re80nryq92POt2n4vcvk9w", in __p_Re80nryq92POt2n4vcvk9w));
        }

        internal FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq __WITH__(n6.XDocument __slot_G2xdMLATTKIMApM8o5qHxu, n11.Path __slot_SPXttW4tLhKMb7XfNJPmcx, n6.SaveOptions __slot_E5yF90ZzoB1MGKDv6f6UE9, bool __slot_DPLFMiJJG4VPWWTzpVinql, n9.TryStateful2<n2.Object> __p_Re80nryq92POt2n4vcvk9w)
        {
            n3.FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_G2xdMLATTKIMApM8o5qHxu != this.__slot_G2xdMLATTKIMApM8o5qHxu || __slot_SPXttW4tLhKMb7XfNJPmcx != this.__slot_SPXttW4tLhKMb7XfNJPmcx || !n14.EqualityComparer<n6.SaveOptions>.Default.Equals(__slot_E5yF90ZzoB1MGKDv6f6UE9, this.__slot_E5yF90ZzoB1MGKDv6f6UE9) || __slot_DPLFMiJJG4VPWWTzpVinql != this.__slot_DPLFMiJJG4VPWWTzpVinql || __p_Re80nryq92POt2n4vcvk9w != this.__p_Re80nryq92POt2n4vcvk9w ? new FileWriter_XML_1_Iv8uSC23OROOGCWLfpOrIq(this)
                {__slot_G2xdMLATTKIMApM8o5qHxu = __slot_G2xdMLATTKIMApM8o5qHxu, __slot_SPXttW4tLhKMb7XfNJPmcx = __slot_SPXttW4tLhKMb7XfNJPmcx, __slot_E5yF90ZzoB1MGKDv6f6UE9 = __slot_E5yF90ZzoB1MGKDv6f6UE9, __slot_DPLFMiJJG4VPWWTzpVinql = __slot_DPLFMiJJG4VPWWTzpVinql, __p_Re80nryq92POt2n4vcvk9w = __p_Re80nryq92POt2n4vcvk9w} : that_0;
            else
            {
                this.__slot_G2xdMLATTKIMApM8o5qHxu = __slot_G2xdMLATTKIMApM8o5qHxu;
                this.__slot_SPXttW4tLhKMb7XfNJPmcx = __slot_SPXttW4tLhKMb7XfNJPmcx;
                this.__slot_E5yF90ZzoB1MGKDv6f6UE9 = __slot_E5yF90ZzoB1MGKDv6f6UE9;
                this.__slot_DPLFMiJJG4VPWWTzpVinql = __slot_DPLFMiJJG4VPWWTzpVinql;
                this.__p_Re80nryq92POt2n4vcvk9w = __p_Re80nryq92POt2n4vcvk9w;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "O44Rx0plg2QLsJDaPTlkhv", Name = "__O44Rx0plg2QLsJDaPTlkhv")]
        [n2.SerializableAttribute]
        public class __O44Rx0plg2QLsJDaPTlkhv : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Co5wMK8NvamP6xNIVGDDXt);
                return;
            }

            [n1.ElementAttribute(TracingId = 210408U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Co5wMK8NvamP6xNIVGDDXt", Name = "FileWriter (XML NoErrorHandling 1)", IsManaged = true, IsAutoGenerated = true)]
            public n8.FileWriter_XML_NoErrorHandling_1_C __p_Co5wMK8NvamP6xNIVGDDXt;
            public __O44Rx0plg2QLsJDaPTlkhv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O44Rx0plg2QLsJDaPTlkhv(__O44Rx0plg2QLsJDaPTlkhv other): base(other)
            {
                this.__p_Co5wMK8NvamP6xNIVGDDXt = other.__p_Co5wMK8NvamP6xNIVGDDXt;
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Co5wMK8NvamP6xNIVGDDXt", in __p_Co5wMK8NvamP6xNIVGDDXt));
            }

            internal __O44Rx0plg2QLsJDaPTlkhv __WITH__(n8.FileWriter_XML_NoErrorHandling_1_C __p_Co5wMK8NvamP6xNIVGDDXt)
            {
                __O44Rx0plg2QLsJDaPTlkhv that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Co5wMK8NvamP6xNIVGDDXt != this.__p_Co5wMK8NvamP6xNIVGDDXt ? new __O44Rx0plg2QLsJDaPTlkhv(this)
                    {__p_Co5wMK8NvamP6xNIVGDDXt = __p_Co5wMK8NvamP6xNIVGDDXt} : that_0;
                else
                {
                    this.__p_Co5wMK8NvamP6xNIVGDDXt = __p_Co5wMK8NvamP6xNIVGDDXt;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Xml_.System.XML.Obsolete.Internal
{
    [n1.ElementAttribute(TracingId = 210524U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Ts3XBe8vejRNGRuwDKrwYw", Name = "FileReader_JSON_NoErrorHandling_1_C")]
    [n2.SerializableAttribute]
    public class FileReader_JSON_NoErrorHandling_1_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.FileReader_JSON_NoErrorHandling_1_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new FileReader_JSON_NoErrorHandling_1_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.FileReader_JSON_NoErrorHandling_1_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new FileReader_JSON_NoErrorHandling_1_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.FileReader_JSON_NoErrorHandling_1_C Update(out n6.XDocument Data_Out, out n6.XElement Root_Out, out bool On_Completed_Out)
        {
            n2.IObservable<n6.XDocument> __pad_Ai454HrcmVnL3Y4GnQHCUz_0 = this.__slot_Ai454HrcmVnL3Y4GnQHCUz;
            bool Reset_1 = false;
            bool Update_2 = true;
            var Output_3 = this.__p_PRWrg1MaMBDMpijxvALVgF;
            if (Update_2)
            {
                n20._Operations_.Update_H<n6.XDocument>(Input_In: this.__p_PRWrg1MaMBDMpijxvALVgF, Async_Notifications_In: __pad_Ai454HrcmVnL3Y4GnQHCUz_0, Reset_In: Reset_1, Output_Out: out Output_3);
            }

            this.__p_PRWrg1MaMBDMpijxvALVgF = Output_3;
            n20._Operations_.GetData_H<n6.XDocument>(Input_In: Output_3, Output_Out: out n21.HoldLatest<n6.XDocument> Output_4, Value_Out: out n6.XDocument Value_5, On_Data_Out: out bool On_Data_6);
            this.__p_PRWrg1MaMBDMpijxvALVgF = Output_4;
            var Root_7 = Value_5.Root;
            Data_Out = Value_5;
            Root_Out = Root_7;
            On_Completed_Out = On_Data_6;
            return this;
        }

        public n8.FileReader_JSON_NoErrorHandling_1_C Read(n11.Path File_Path_In, n12.Encodings Encoding_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In)
        {
            n19.FileMode __pad_OCE5Iey5b9AOasLdO7jYzx_0 = __slot_OCE5Iey5b9AOasLdO7jYzx;
            n19.FileAccess __pad_RFm0w1Em9kwLqA4Mbb9GjV_1 = __slot_RFm0w1Em9kwLqA4Mbb9GjV;
            n19.FileShare File_Share_2 = __c_AqC6wI3tdscNrHwsDhhWGq;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_HQjBx2X78PjOtb1rIyLOPh;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: __pad_OCE5Iey5b9AOasLdO7jYzx_0, fileAccess: __pad_RFm0w1Em9kwLqA4Mbb9GjV_1, fileShare: File_Share_2);
            this.__p_HQjBx2X78PjOtb1rIyLOPh = Input_3;
            var __fallback___5 = n1.ServiceRegistry.Current;
            n25._Operations_.Start<n6.XDocument>(Function_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                var Output_8 = n23.StreamUtils.ReadAllString(input: Result_4, encoding: Encoding_In, data: out string Data_7);
                var Result_9 = n24.XmlNodes.DeserializeXNode(json: Data_7, deserializeRootElementName: Deserialize_Root_Element_Name_In, writeArrayAttribute: Write_Array_Attribute_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<n6.XDocument> Result_10);
            this.__slot_Ai454HrcmVnL3Y4GnQHCUz = Result_10;
            n2.IObservable<n6.XDocument> __pad_Ai454HrcmVnL3Y4GnQHCUz_11 = Result_10;
            return this;
        }

        public n8.FileReader_JSON_NoErrorHandling_1_C __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_Ai454HrcmVnL3Y4GnQHCUz = n25._Operations_.CreateDefault<n6.XDocument>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "HQjBx2X78PjOtb1rIyLOPh", 210527U);
            n27.IFrameClock Clock_1 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n22.ObsoleteFileNoSharing Output_2);
            this.__p_HQjBx2X78PjOtb1rIyLOPh = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "PRWrg1MaMBDMpijxvALVgF", 210638U);
            n6.XDocument Initial_Result_4 = n5._Operations_.CreateDefault();
            n20._Operations_.Create_H<n6.XDocument>(Node_Context: Node_Context_3, Initial_Result_In: Initial_Result_4, Output_Out: out n21.HoldLatest<n6.XDocument> Output_5);
            this.__p_PRWrg1MaMBDMpijxvALVgF = Output_5;
            return this;
        }

        public n8.FileReader_JSON_NoErrorHandling_1_C __CreateDefault__()
        {
            this.__slot_Ai454HrcmVnL3Y4GnQHCUz = n25._Operations_.CreateDefault<n6.XDocument>();
            this.__p_PRWrg1MaMBDMpijxvALVgF = default(n21.HoldLatest<n6.XDocument>);
            this.__p_HQjBx2X78PjOtb1rIyLOPh = default(n22.ObsoleteFileNoSharing);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PRWrg1MaMBDMpijxvALVgF);
            n1.CompilationHelper.SafeDispose(this.__p_HQjBx2X78PjOtb1rIyLOPh);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 210549U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "OCE5Iey5b9AOasLdO7jYzx", Name = "__slot_OCE5Iey5b9AOasLdO7jYzx")]
        public static n19.FileMode __slot_OCE5Iey5b9AOasLdO7jYzx = n1.CompilationHelper.Deserialize<n19.FileMode>("Open", false, "Q2iWAXgl3GDPCvxD5IfFJH", "OCE5Iey5b9AOasLdO7jYzx");
        [n1.ElementAttribute(TracingId = 210556U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "RFm0w1Em9kwLqA4Mbb9GjV", Name = "__slot_RFm0w1Em9kwLqA4Mbb9GjV")]
        public static n19.FileAccess __slot_RFm0w1Em9kwLqA4Mbb9GjV = n1.CompilationHelper.Deserialize<n19.FileAccess>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "RFm0w1Em9kwLqA4Mbb9GjV");
        [n1.ElementAttribute(TracingId = 210649U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Ai454HrcmVnL3Y4GnQHCUz", Name = "__slot_Ai454HrcmVnL3Y4GnQHCUz")]
        public n2.IObservable<n6.XDocument> __slot_Ai454HrcmVnL3Y4GnQHCUz;
        [n1.ElementAttribute(TracingId = 210638U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "PRWrg1MaMBDMpijxvALVgF", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n21.HoldLatest<n6.XDocument> __p_PRWrg1MaMBDMpijxvALVgF;
        [n1.ElementAttribute(TracingId = 210527U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HQjBx2X78PjOtb1rIyLOPh", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_HQjBx2X78PjOtb1rIyLOPh;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_AqC6wI3tdscNrHwsDhhWGq = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "AqC6wI3tdscNrHwsDhhWGq");
        static FileReader_JSON_NoErrorHandling_1_C()
        {
        }

        public FileReader_JSON_NoErrorHandling_1_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_JSON_NoErrorHandling_1_C(FileReader_JSON_NoErrorHandling_1_C other): base(other)
        {
            this.__slot_Ai454HrcmVnL3Y4GnQHCUz = other.__slot_Ai454HrcmVnL3Y4GnQHCUz;
            this.__p_PRWrg1MaMBDMpijxvALVgF = other.__p_PRWrg1MaMBDMpijxvALVgF;
            this.__p_HQjBx2X78PjOtb1rIyLOPh = other.__p_HQjBx2X78PjOtb1rIyLOPh;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ai454HrcmVnL3Y4GnQHCUz", in __slot_Ai454HrcmVnL3Y4GnQHCUz), n1.CompilationHelper.GetValueOrExisting(values, "__p_PRWrg1MaMBDMpijxvALVgF", in __p_PRWrg1MaMBDMpijxvALVgF), n1.CompilationHelper.GetValueOrExisting(values, "__p_HQjBx2X78PjOtb1rIyLOPh", in __p_HQjBx2X78PjOtb1rIyLOPh));
        }

        internal FileReader_JSON_NoErrorHandling_1_C __WITH__(n2.IObservable<n6.XDocument> __slot_Ai454HrcmVnL3Y4GnQHCUz, n21.HoldLatest<n6.XDocument> __p_PRWrg1MaMBDMpijxvALVgF, n22.ObsoleteFileNoSharing __p_HQjBx2X78PjOtb1rIyLOPh)
        {
            n8.FileReader_JSON_NoErrorHandling_1_C that_0 = this;
            this.__slot_Ai454HrcmVnL3Y4GnQHCUz = __slot_Ai454HrcmVnL3Y4GnQHCUz;
            this.__p_PRWrg1MaMBDMpijxvALVgF = __p_PRWrg1MaMBDMpijxvALVgF;
            this.__p_HQjBx2X78PjOtb1rIyLOPh = __p_HQjBx2X78PjOtb1rIyLOPh;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 210758U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "VdtL0OO3fo0NNZiuelwvJm", Name = "FileReader_XML_NoErrorHandling_1_C")]
    [n2.SerializableAttribute]
    public class FileReader_XML_NoErrorHandling_1_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.FileReader_XML_NoErrorHandling_1_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new FileReader_XML_NoErrorHandling_1_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.FileReader_XML_NoErrorHandling_1_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new FileReader_XML_NoErrorHandling_1_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.FileReader_XML_NoErrorHandling_1_C Update(out n6.XDocument Data_Out, out n6.XElement Root_Out, out bool On_Completed_Out)
        {
            n2.IObservable<n6.XDocument> __pad_KgK8qtoOq4iNmjO4bXgl2m_0 = this.__slot_KgK8qtoOq4iNmjO4bXgl2m;
            bool Reset_1 = false;
            bool Update_2 = true;
            var Output_3 = this.__p_P6QiZBWodz6PlKOee9jS97;
            if (Update_2)
            {
                n20._Operations_.Update_H<n6.XDocument>(Input_In: this.__p_P6QiZBWodz6PlKOee9jS97, Async_Notifications_In: __pad_KgK8qtoOq4iNmjO4bXgl2m_0, Reset_In: Reset_1, Output_Out: out Output_3);
            }

            this.__p_P6QiZBWodz6PlKOee9jS97 = Output_3;
            n20._Operations_.GetData_H<n6.XDocument>(Input_In: Output_3, Output_Out: out n21.HoldLatest<n6.XDocument> Output_4, Value_Out: out n6.XDocument Value_5, On_Data_Out: out bool On_Data_6);
            this.__p_P6QiZBWodz6PlKOee9jS97 = Output_4;
            var Root_7 = Value_5.Root;
            Data_Out = Value_5;
            Root_Out = Root_7;
            On_Completed_Out = On_Data_6;
            return this;
        }

        public n8.FileReader_XML_NoErrorHandling_1_C Read(n11.Path File_Path_In, n12.Encodings Encoding_In, n6.LoadOptions Options_In)
        {
            n19.FileMode __pad_R9KEKs6QrapPL0dtI3P127_0 = __slot_R9KEKs6QrapPL0dtI3P127;
            n19.FileAccess __pad_GevdYTsJDjsLREfQT4Nt6y_1 = __slot_GevdYTsJDjsLREfQT4Nt6y;
            n19.FileShare File_Share_2 = __c_NR3l1zTachfOc9QbLen2Eq;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_NTUZrXF1YgcNpAgjJM8s49;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: __pad_R9KEKs6QrapPL0dtI3P127_0, fileAccess: __pad_GevdYTsJDjsLREfQT4Nt6y_1, fileShare: File_Share_2);
            this.__p_NTUZrXF1YgcNpAgjJM8s49 = Input_3;
            var __fallback___5 = n1.ServiceRegistry.Current;
            n25._Operations_.Start<n6.XDocument>(Function_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                var Output_8 = n23.StreamUtils.ReadAllString(input: Result_4, encoding: Encoding_In, data: out string Data_7);
                var Result_9 = n6.XDocument.Parse(text: Data_7, options: Options_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<n6.XDocument> Result_10);
            this.__slot_KgK8qtoOq4iNmjO4bXgl2m = Result_10;
            n2.IObservable<n6.XDocument> __pad_KgK8qtoOq4iNmjO4bXgl2m_11 = Result_10;
            return this;
        }

        public n8.FileReader_XML_NoErrorHandling_1_C __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_KgK8qtoOq4iNmjO4bXgl2m = n25._Operations_.CreateDefault<n6.XDocument>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "P6QiZBWodz6PlKOee9jS97", 210802U);
            n6.XDocument Initial_Result_1 = n5._Operations_.CreateDefault();
            n20._Operations_.Create_H<n6.XDocument>(Node_Context: Node_Context_0, Initial_Result_In: Initial_Result_1, Output_Out: out n21.HoldLatest<n6.XDocument> Output_2);
            this.__p_P6QiZBWodz6PlKOee9jS97 = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "NTUZrXF1YgcNpAgjJM8s49", 210842U);
            n27.IFrameClock Clock_4 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_3, Clock_In: Clock_4, Output_Out: out n22.ObsoleteFileNoSharing Output_5);
            this.__p_NTUZrXF1YgcNpAgjJM8s49 = Output_5;
            return this;
        }

        public n8.FileReader_XML_NoErrorHandling_1_C __CreateDefault__()
        {
            this.__slot_KgK8qtoOq4iNmjO4bXgl2m = n25._Operations_.CreateDefault<n6.XDocument>();
            this.__p_P6QiZBWodz6PlKOee9jS97 = default(n21.HoldLatest<n6.XDocument>);
            this.__p_NTUZrXF1YgcNpAgjJM8s49 = default(n22.ObsoleteFileNoSharing);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_P6QiZBWodz6PlKOee9jS97);
            n1.CompilationHelper.SafeDispose(this.__p_NTUZrXF1YgcNpAgjJM8s49);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 210818U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "KgK8qtoOq4iNmjO4bXgl2m", Name = "__slot_KgK8qtoOq4iNmjO4bXgl2m")]
        public n2.IObservable<n6.XDocument> __slot_KgK8qtoOq4iNmjO4bXgl2m;
        [n1.ElementAttribute(TracingId = 210860U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "R9KEKs6QrapPL0dtI3P127", Name = "__slot_R9KEKs6QrapPL0dtI3P127")]
        public static n19.FileMode __slot_R9KEKs6QrapPL0dtI3P127 = n1.CompilationHelper.Deserialize<n19.FileMode>("Open", false, "Q2iWAXgl3GDPCvxD5IfFJH", "R9KEKs6QrapPL0dtI3P127");
        [n1.ElementAttribute(TracingId = 210864U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "GevdYTsJDjsLREfQT4Nt6y", Name = "__slot_GevdYTsJDjsLREfQT4Nt6y")]
        public static n19.FileAccess __slot_GevdYTsJDjsLREfQT4Nt6y = n1.CompilationHelper.Deserialize<n19.FileAccess>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "GevdYTsJDjsLREfQT4Nt6y");
        [n1.ElementAttribute(TracingId = 210802U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "P6QiZBWodz6PlKOee9jS97", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n21.HoldLatest<n6.XDocument> __p_P6QiZBWodz6PlKOee9jS97;
        [n1.ElementAttribute(TracingId = 210842U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "NTUZrXF1YgcNpAgjJM8s49", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_NTUZrXF1YgcNpAgjJM8s49;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_NR3l1zTachfOc9QbLen2Eq = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "NR3l1zTachfOc9QbLen2Eq");
        static FileReader_XML_NoErrorHandling_1_C()
        {
        }

        public FileReader_XML_NoErrorHandling_1_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileReader_XML_NoErrorHandling_1_C(FileReader_XML_NoErrorHandling_1_C other): base(other)
        {
            this.__slot_KgK8qtoOq4iNmjO4bXgl2m = other.__slot_KgK8qtoOq4iNmjO4bXgl2m;
            this.__p_P6QiZBWodz6PlKOee9jS97 = other.__p_P6QiZBWodz6PlKOee9jS97;
            this.__p_NTUZrXF1YgcNpAgjJM8s49 = other.__p_NTUZrXF1YgcNpAgjJM8s49;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_KgK8qtoOq4iNmjO4bXgl2m", in __slot_KgK8qtoOq4iNmjO4bXgl2m), n1.CompilationHelper.GetValueOrExisting(values, "__p_P6QiZBWodz6PlKOee9jS97", in __p_P6QiZBWodz6PlKOee9jS97), n1.CompilationHelper.GetValueOrExisting(values, "__p_NTUZrXF1YgcNpAgjJM8s49", in __p_NTUZrXF1YgcNpAgjJM8s49));
        }

        internal FileReader_XML_NoErrorHandling_1_C __WITH__(n2.IObservable<n6.XDocument> __slot_KgK8qtoOq4iNmjO4bXgl2m, n21.HoldLatest<n6.XDocument> __p_P6QiZBWodz6PlKOee9jS97, n22.ObsoleteFileNoSharing __p_NTUZrXF1YgcNpAgjJM8s49)
        {
            n8.FileReader_XML_NoErrorHandling_1_C that_0 = this;
            this.__slot_KgK8qtoOq4iNmjO4bXgl2m = __slot_KgK8qtoOq4iNmjO4bXgl2m;
            this.__p_P6QiZBWodz6PlKOee9jS97 = __p_P6QiZBWodz6PlKOee9jS97;
            this.__p_NTUZrXF1YgcNpAgjJM8s49 = __p_NTUZrXF1YgcNpAgjJM8s49;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 210936U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "VTU7hpUilUNL0dKAdefWJv", Name = "FileWriter_JSON_NoErrorHandling_1_C")]
    [n2.SerializableAttribute]
    public class FileWriter_JSON_NoErrorHandling_1_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.FileWriter_JSON_NoErrorHandling_1_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new FileWriter_JSON_NoErrorHandling_1_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.FileWriter_JSON_NoErrorHandling_1_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new FileWriter_JSON_NoErrorHandling_1_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.FileWriter_JSON_NoErrorHandling_1_C Update(out bool On_Completed_Out, out bool In_Progress_Out)
        {
            n2.IObservable<bool> __pad_HpRveibmo3PMEJgD7jqnlN_0 = this.__slot_HpRveibmo3PMEJgD7jqnlN;
            bool Reset_1 = false;
            bool Update_2 = true;
            var Output_3 = this.__p_MYZ9jTHNZlGMKNJ9FlHkdf;
            if (Update_2)
            {
                n20._Operations_.Update_H<bool>(Input_In: this.__p_MYZ9jTHNZlGMKNJ9FlHkdf, Async_Notifications_In: __pad_HpRveibmo3PMEJgD7jqnlN_0, Reset_In: Reset_1, Output_Out: out Output_3);
            }

            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = Output_3;
            n20._Operations_.GetData_H<bool>(Input_In: Output_3, Output_Out: out n21.HoldLatest<bool> Output_4, Value_Out: out bool Value_5, On_Data_Out: out bool On_Data_6);
            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = Output_4;
            var Output_7 = this.__p_CoLxJJxyAEsQO58LOQlokW;
            if (On_Data_6)
            {
                Output_7 = this.__p_CoLxJJxyAEsQO58LOQlokW.Reset();
            }

            this.__p_CoLxJJxyAEsQO58LOQlokW = Output_7;
            var Output_9 = Output_7.GetState(State_Out: out bool State_8);
            this.__p_CoLxJJxyAEsQO58LOQlokW = Output_9;
            On_Completed_Out = On_Data_6;
            In_Progress_Out = State_8;
            return this;
        }

        public n8.FileWriter_JSON_NoErrorHandling_1_C Write<T>(T XNode_In, n11.Path File_Path_In, n12.Encodings Encoding_In, bool Indent_In, bool Omit_Root_Object_In)
            where T : n6.XNode
        {
            n19.FileMode __pad_Bk8us6BRmq8NMfaGRbvHbr_0 = __slot_Bk8us6BRmq8NMfaGRbvHbr;
            n19.FileAccess __pad_B1XJsOy33uhPNhLasTkamI_1 = __slot_B1XJsOy33uhPNhLasTkamI;
            bool __pad_MFaMkbyOsBDQE8Wpd5omMU_2 = __slot_MFaMkbyOsBDQE8Wpd5omMU;
            n19.FileShare File_Share_3 = __c_TrBFIcYvFI7MJCSi92jyBv;
            n22.ObsoleteFileNoSharing Input_4 = this.__p_DoS6Jsnah3VQGqIrplGtpe;
            var Result_5 = Input_4.Update(filePath: File_Path_In, fileMode: __pad_Bk8us6BRmq8NMfaGRbvHbr_0, fileAccess: __pad_B1XJsOy33uhPNhLasTkamI_1, fileShare: File_Share_3);
            this.__p_DoS6Jsnah3VQGqIrplGtpe = Input_4;
            var __fallback___6 = n1.ServiceRegistry.Current;
            n25._Operations_.Start<bool>(Function_In: () =>
            {
                using var __current_7 = __fallback___6.MakeCurrentIfNone();
                bool __pad_SPGt1BccdJgQETOHg7RXea_8 = __slot_SPGt1BccdJgQETOHg7RXea;
                var Result_9 = n24.XmlNodes.SerializeXNode(input: XNode_In, indent: Indent_In, omitRootObject: Omit_Root_Object_In);
                long Offset_10 = 0L;
                var Output_11 = n23.StreamUtils.WriteString(input: Result_5, data: Result_9, encoding: Encoding_In, offset: Offset_10);
                return __pad_SPGt1BccdJgQETOHg7RXea_8;
            }

            , Result_Out: out n2.IObservable<bool> Result_12);
            this.__slot_HpRveibmo3PMEJgD7jqnlN = Result_12;
            n2.IObservable<bool> __pad_HpRveibmo3PMEJgD7jqnlN_13 = Result_12;
            var Output_14 = this.__p_CoLxJJxyAEsQO58LOQlokW;
            if (__pad_MFaMkbyOsBDQE8Wpd5omMU_2)
            {
                Output_14 = this.__p_CoLxJJxyAEsQO58LOQlokW.Set();
            }

            this.__p_CoLxJJxyAEsQO58LOQlokW = Output_14;
            return this;
        }

        public n8.FileWriter_JSON_NoErrorHandling_1_C __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_HpRveibmo3PMEJgD7jqnlN = n25._Operations_.CreateDefault<bool>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "DoS6Jsnah3VQGqIrplGtpe", 210990U);
            n27.IFrameClock Clock_1 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n22.ObsoleteFileNoSharing Output_2);
            this.__p_DoS6Jsnah3VQGqIrplGtpe = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "MYZ9jTHNZlGMKNJ9FlHkdf", 211039U);
            bool Initial_Result_4 = false;
            n20._Operations_.Create_H<bool>(Node_Context: Node_Context_3, Initial_Result_In: Initial_Result_4, Output_Out: out n21.HoldLatest<bool> Output_5);
            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "CoLxJJxyAEsQO58LOQlokW", 211058U);
            var Output_7 = n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_6);
            this.__p_CoLxJJxyAEsQO58LOQlokW = Output_7;
            return this;
        }

        public n8.FileWriter_JSON_NoErrorHandling_1_C __CreateDefault__()
        {
            this.__slot_HpRveibmo3PMEJgD7jqnlN = n25._Operations_.CreateDefault<bool>();
            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = default(n21.HoldLatest<bool>);
            this.__p_CoLxJJxyAEsQO58LOQlokW = n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_DoS6Jsnah3VQGqIrplGtpe = default(n22.ObsoleteFileNoSharing);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MYZ9jTHNZlGMKNJ9FlHkdf);
            n1.CompilationHelper.SafeDispose(this.__p_CoLxJJxyAEsQO58LOQlokW);
            n1.CompilationHelper.SafeDispose(this.__p_DoS6Jsnah3VQGqIrplGtpe);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 211028U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Bk8us6BRmq8NMfaGRbvHbr", Name = "__slot_Bk8us6BRmq8NMfaGRbvHbr")]
        public static n19.FileMode __slot_Bk8us6BRmq8NMfaGRbvHbr = n1.CompilationHelper.Deserialize<n19.FileMode>("Create", false, "Q2iWAXgl3GDPCvxD5IfFJH", "Bk8us6BRmq8NMfaGRbvHbr");
        [n1.ElementAttribute(TracingId = 211036U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "B1XJsOy33uhPNhLasTkamI", Name = "__slot_B1XJsOy33uhPNhLasTkamI")]
        public static n19.FileAccess __slot_B1XJsOy33uhPNhLasTkamI = n1.CompilationHelper.Deserialize<n19.FileAccess>("Write", false, "Q2iWAXgl3GDPCvxD5IfFJH", "B1XJsOy33uhPNhLasTkamI");
        [n1.ElementAttribute(TracingId = 211038U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HpRveibmo3PMEJgD7jqnlN", Name = "__slot_HpRveibmo3PMEJgD7jqnlN")]
        public n2.IObservable<bool> __slot_HpRveibmo3PMEJgD7jqnlN;
        [n1.ElementAttribute(TracingId = 211070U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MFaMkbyOsBDQE8Wpd5omMU", Name = "__slot_MFaMkbyOsBDQE8Wpd5omMU")]
        public static bool __slot_MFaMkbyOsBDQE8Wpd5omMU = true;
        [n1.ElementAttribute(TracingId = 211039U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MYZ9jTHNZlGMKNJ9FlHkdf", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n21.HoldLatest<bool> __p_MYZ9jTHNZlGMKNJ9FlHkdf;
        [n1.ElementAttribute(TracingId = 211058U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "CoLxJJxyAEsQO58LOQlokW", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_CoLxJJxyAEsQO58LOQlokW;
        [n1.ElementAttribute(TracingId = 210990U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DoS6Jsnah3VQGqIrplGtpe", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_DoS6Jsnah3VQGqIrplGtpe;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_TrBFIcYvFI7MJCSi92jyBv = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "TrBFIcYvFI7MJCSi92jyBv");
        [n1.ElementAttribute(TracingId = 210978U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SPGt1BccdJgQETOHg7RXea", Name = "__slot_SPGt1BccdJgQETOHg7RXea")]
        public static bool __slot_SPGt1BccdJgQETOHg7RXea = true;
        static FileWriter_JSON_NoErrorHandling_1_C()
        {
        }

        public FileWriter_JSON_NoErrorHandling_1_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_JSON_NoErrorHandling_1_C(FileWriter_JSON_NoErrorHandling_1_C other): base(other)
        {
            this.__slot_HpRveibmo3PMEJgD7jqnlN = other.__slot_HpRveibmo3PMEJgD7jqnlN;
            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = other.__p_MYZ9jTHNZlGMKNJ9FlHkdf;
            this.__p_CoLxJJxyAEsQO58LOQlokW = other.__p_CoLxJJxyAEsQO58LOQlokW;
            this.__p_DoS6Jsnah3VQGqIrplGtpe = other.__p_DoS6Jsnah3VQGqIrplGtpe;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_HpRveibmo3PMEJgD7jqnlN", in __slot_HpRveibmo3PMEJgD7jqnlN), n1.CompilationHelper.GetValueOrExisting(values, "__p_MYZ9jTHNZlGMKNJ9FlHkdf", in __p_MYZ9jTHNZlGMKNJ9FlHkdf), n1.CompilationHelper.GetValueOrExisting(values, "__p_CoLxJJxyAEsQO58LOQlokW", in __p_CoLxJJxyAEsQO58LOQlokW), n1.CompilationHelper.GetValueOrExisting(values, "__p_DoS6Jsnah3VQGqIrplGtpe", in __p_DoS6Jsnah3VQGqIrplGtpe));
        }

        internal FileWriter_JSON_NoErrorHandling_1_C __WITH__(n2.IObservable<bool> __slot_HpRveibmo3PMEJgD7jqnlN, n21.HoldLatest<bool> __p_MYZ9jTHNZlGMKNJ9FlHkdf, n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_CoLxJJxyAEsQO58LOQlokW, n22.ObsoleteFileNoSharing __p_DoS6Jsnah3VQGqIrplGtpe)
        {
            n8.FileWriter_JSON_NoErrorHandling_1_C that_0 = this;
            this.__slot_HpRveibmo3PMEJgD7jqnlN = __slot_HpRveibmo3PMEJgD7jqnlN;
            this.__p_MYZ9jTHNZlGMKNJ9FlHkdf = __p_MYZ9jTHNZlGMKNJ9FlHkdf;
            this.__p_CoLxJJxyAEsQO58LOQlokW = __p_CoLxJJxyAEsQO58LOQlokW;
            this.__p_DoS6Jsnah3VQGqIrplGtpe = __p_DoS6Jsnah3VQGqIrplGtpe;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 211179U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "KFR7YJtdsuwN4NiitEfp0y", Name = "FileWriter_XML_NoErrorHandling_1_C")]
    [n2.SerializableAttribute]
    public class FileWriter_XML_NoErrorHandling_1_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.FileWriter_XML_NoErrorHandling_1_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new FileWriter_XML_NoErrorHandling_1_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.FileWriter_XML_NoErrorHandling_1_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new FileWriter_XML_NoErrorHandling_1_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.FileWriter_XML_NoErrorHandling_1_C Update(out bool On_Completed_Out, out bool In_Progress_Out)
        {
            n2.IObservable<bool> __pad_HjkV2Up4MkVMlKdHFwCDrn_0 = this.__slot_HjkV2Up4MkVMlKdHFwCDrn;
            bool Reset_1 = false;
            bool Update_2 = true;
            var Output_3 = this.__p_AIuMN3lRU0yOiktZTQgqz7;
            if (Update_2)
            {
                n20._Operations_.Update_H<bool>(Input_In: this.__p_AIuMN3lRU0yOiktZTQgqz7, Async_Notifications_In: __pad_HjkV2Up4MkVMlKdHFwCDrn_0, Reset_In: Reset_1, Output_Out: out Output_3);
            }

            this.__p_AIuMN3lRU0yOiktZTQgqz7 = Output_3;
            n20._Operations_.GetData_H<bool>(Input_In: Output_3, Output_Out: out n21.HoldLatest<bool> Output_4, Value_Out: out bool Value_5, On_Data_Out: out bool On_Data_6);
            this.__p_AIuMN3lRU0yOiktZTQgqz7 = Output_4;
            var Output_7 = this.__p_EoDpnup1wheL4oWmwvdiAW;
            if (On_Data_6)
            {
                Output_7 = this.__p_EoDpnup1wheL4oWmwvdiAW.Reset();
            }

            this.__p_EoDpnup1wheL4oWmwvdiAW = Output_7;
            var Output_9 = Output_7.GetState(State_Out: out bool State_8);
            this.__p_EoDpnup1wheL4oWmwvdiAW = Output_9;
            On_Completed_Out = On_Data_6;
            In_Progress_Out = State_8;
            return this;
        }

        public n8.FileWriter_XML_NoErrorHandling_1_C Write(n6.XDocument XDocument_In, n11.Path File_Path_In, n6.SaveOptions SaveOptions_In)
        {
            n19.FileMode __pad_VCN0Db64gvqNuxdvFQ05x6_0 = __slot_VCN0Db64gvqNuxdvFQ05x6;
            n19.FileAccess __pad_QLJURKMhLemLYgvN58OQhf_1 = __slot_QLJURKMhLemLYgvN58OQhf;
            bool __pad_LqOEFDTjxCPPqQ8fLUyPqA_2 = __slot_LqOEFDTjxCPPqQ8fLUyPqA;
            n19.FileShare File_Share_3 = __c_IpMCwddNfEMMiYRO9qXeOe;
            n22.ObsoleteFileNoSharing Input_4 = this.__p_EUULTQ3CLGNPEOh5ZR9VwW;
            var Result_5 = Input_4.Update(filePath: File_Path_In, fileMode: __pad_VCN0Db64gvqNuxdvFQ05x6_0, fileAccess: __pad_QLJURKMhLemLYgvN58OQhf_1, fileShare: File_Share_3);
            this.__p_EUULTQ3CLGNPEOh5ZR9VwW = Input_4;
            var __fallback___6 = n1.ServiceRegistry.Current;
            n25._Operations_.Start<bool>(Function_In: () =>
            {
                using var __current_7 = __fallback___6.MakeCurrentIfNone();
                bool __pad_GIMTYDdKttLP3wed05zHHu_8 = __slot_GIMTYDdKttLP3wed05zHHu;
                n35._Operations_.Using<n19.Stream>(Input_In: Result_5, Action_In: (n19.Stream Arg_In_10) =>
                {
                    using var __current_9 = __fallback___6.MakeCurrentIfNone();
                    XDocument_In.Save(stream: Arg_In_10, options: SaveOptions_In);
                }

                , Output_Out: out n34.IResourceProvider<n19.Stream> Output_11);
                return __pad_GIMTYDdKttLP3wed05zHHu_8;
            }

            , Result_Out: out n2.IObservable<bool> Result_12);
            this.__slot_HjkV2Up4MkVMlKdHFwCDrn = Result_12;
            n2.IObservable<bool> __pad_HjkV2Up4MkVMlKdHFwCDrn_13 = Result_12;
            var Output_14 = this.__p_EoDpnup1wheL4oWmwvdiAW;
            if (__pad_LqOEFDTjxCPPqQ8fLUyPqA_2)
            {
                Output_14 = this.__p_EoDpnup1wheL4oWmwvdiAW.Set();
            }

            this.__p_EoDpnup1wheL4oWmwvdiAW = Output_14;
            return this;
        }

        public n8.FileWriter_XML_NoErrorHandling_1_C __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_HjkV2Up4MkVMlKdHFwCDrn = n25._Operations_.CreateDefault<bool>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "AIuMN3lRU0yOiktZTQgqz7", 211262U);
            bool Initial_Result_1 = false;
            n20._Operations_.Create_H<bool>(Node_Context: Node_Context_0, Initial_Result_In: Initial_Result_1, Output_Out: out n21.HoldLatest<bool> Output_2);
            this.__p_AIuMN3lRU0yOiktZTQgqz7 = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "EoDpnup1wheL4oWmwvdiAW", 211297U);
            var Output_4 = n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_3);
            this.__p_EoDpnup1wheL4oWmwvdiAW = Output_4;
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "EUULTQ3CLGNPEOh5ZR9VwW", 211323U);
            n27.IFrameClock Clock_6 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_5, Clock_In: Clock_6, Output_Out: out n22.ObsoleteFileNoSharing Output_7);
            this.__p_EUULTQ3CLGNPEOh5ZR9VwW = Output_7;
            return this;
        }

        public n8.FileWriter_XML_NoErrorHandling_1_C __CreateDefault__()
        {
            this.__slot_HjkV2Up4MkVMlKdHFwCDrn = n25._Operations_.CreateDefault<bool>();
            this.__p_AIuMN3lRU0yOiktZTQgqz7 = default(n21.HoldLatest<bool>);
            this.__p_EoDpnup1wheL4oWmwvdiAW = n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_EUULTQ3CLGNPEOh5ZR9VwW = default(n22.ObsoleteFileNoSharing);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AIuMN3lRU0yOiktZTQgqz7);
            n1.CompilationHelper.SafeDispose(this.__p_EoDpnup1wheL4oWmwvdiAW);
            n1.CompilationHelper.SafeDispose(this.__p_EUULTQ3CLGNPEOh5ZR9VwW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 211290U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HjkV2Up4MkVMlKdHFwCDrn", Name = "__slot_HjkV2Up4MkVMlKdHFwCDrn")]
        public n2.IObservable<bool> __slot_HjkV2Up4MkVMlKdHFwCDrn;
        [n1.ElementAttribute(TracingId = 211293U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "LqOEFDTjxCPPqQ8fLUyPqA", Name = "__slot_LqOEFDTjxCPPqQ8fLUyPqA")]
        public static bool __slot_LqOEFDTjxCPPqQ8fLUyPqA = true;
        [n1.ElementAttribute(TracingId = 211342U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "VCN0Db64gvqNuxdvFQ05x6", Name = "__slot_VCN0Db64gvqNuxdvFQ05x6")]
        public static n19.FileMode __slot_VCN0Db64gvqNuxdvFQ05x6 = n1.CompilationHelper.Deserialize<n19.FileMode>("Create", false, "Q2iWAXgl3GDPCvxD5IfFJH", "VCN0Db64gvqNuxdvFQ05x6");
        [n1.ElementAttribute(TracingId = 211353U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "QLJURKMhLemLYgvN58OQhf", Name = "__slot_QLJURKMhLemLYgvN58OQhf")]
        public static n19.FileAccess __slot_QLJURKMhLemLYgvN58OQhf = n1.CompilationHelper.Deserialize<n19.FileAccess>("Write", false, "Q2iWAXgl3GDPCvxD5IfFJH", "QLJURKMhLemLYgvN58OQhf");
        [n1.ElementAttribute(TracingId = 211262U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "AIuMN3lRU0yOiktZTQgqz7", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n21.HoldLatest<bool> __p_AIuMN3lRU0yOiktZTQgqz7;
        [n1.ElementAttribute(TracingId = 211297U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EoDpnup1wheL4oWmwvdiAW", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_EoDpnup1wheL4oWmwvdiAW;
        [n1.ElementAttribute(TracingId = 211323U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EUULTQ3CLGNPEOh5ZR9VwW", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_EUULTQ3CLGNPEOh5ZR9VwW;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_IpMCwddNfEMMiYRO9qXeOe = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "IpMCwddNfEMMiYRO9qXeOe");
        [n1.ElementAttribute(TracingId = 211201U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "GIMTYDdKttLP3wed05zHHu", Name = "__slot_GIMTYDdKttLP3wed05zHHu")]
        public static bool __slot_GIMTYDdKttLP3wed05zHHu = true;
        static FileWriter_XML_NoErrorHandling_1_C()
        {
        }

        public FileWriter_XML_NoErrorHandling_1_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileWriter_XML_NoErrorHandling_1_C(FileWriter_XML_NoErrorHandling_1_C other): base(other)
        {
            this.__slot_HjkV2Up4MkVMlKdHFwCDrn = other.__slot_HjkV2Up4MkVMlKdHFwCDrn;
            this.__p_AIuMN3lRU0yOiktZTQgqz7 = other.__p_AIuMN3lRU0yOiktZTQgqz7;
            this.__p_EoDpnup1wheL4oWmwvdiAW = other.__p_EoDpnup1wheL4oWmwvdiAW;
            this.__p_EUULTQ3CLGNPEOh5ZR9VwW = other.__p_EUULTQ3CLGNPEOh5ZR9VwW;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_HjkV2Up4MkVMlKdHFwCDrn", in __slot_HjkV2Up4MkVMlKdHFwCDrn), n1.CompilationHelper.GetValueOrExisting(values, "__p_AIuMN3lRU0yOiktZTQgqz7", in __p_AIuMN3lRU0yOiktZTQgqz7), n1.CompilationHelper.GetValueOrExisting(values, "__p_EoDpnup1wheL4oWmwvdiAW", in __p_EoDpnup1wheL4oWmwvdiAW), n1.CompilationHelper.GetValueOrExisting(values, "__p_EUULTQ3CLGNPEOh5ZR9VwW", in __p_EUULTQ3CLGNPEOh5ZR9VwW));
        }

        internal FileWriter_XML_NoErrorHandling_1_C __WITH__(n2.IObservable<bool> __slot_HjkV2Up4MkVMlKdHFwCDrn, n21.HoldLatest<bool> __p_AIuMN3lRU0yOiktZTQgqz7, n33.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_EoDpnup1wheL4oWmwvdiAW, n22.ObsoleteFileNoSharing __p_EUULTQ3CLGNPEOh5ZR9VwW)
        {
            n8.FileWriter_XML_NoErrorHandling_1_C that_0 = this;
            this.__slot_HjkV2Up4MkVMlKdHFwCDrn = __slot_HjkV2Up4MkVMlKdHFwCDrn;
            this.__p_AIuMN3lRU0yOiktZTQgqz7 = __p_AIuMN3lRU0yOiktZTQgqz7;
            this.__p_EoDpnup1wheL4oWmwvdiAW = __p_EoDpnup1wheL4oWmwvdiAW;
            this.__p_EUULTQ3CLGNPEOh5ZR9VwW = __p_EUULTQ3CLGNPEOh5ZR9VwW;
            return that_0;
        }
    }
}

namespace _VL_Xml_.System.XML
{
    [n1.ElementAttribute(TracingId = 216718U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "OcM6yTDIunKLXht5WzCyyW", Name = "XMLReader_OcM6yTDIunKLXht5WzCyyW")]
    [n2.SerializableAttribute]
    public class XMLReader_OcM6yTDIunKLXht5WzCyyW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.XMLReader_OcM6yTDIunKLXht5WzCyyW Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLReader_OcM6yTDIunKLXht5WzCyyW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.XMLReader_OcM6yTDIunKLXht5WzCyyW CreateDefault()
        {
            var instance = new XMLReader_OcM6yTDIunKLXht5WzCyyW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.XMLReader_OcM6yTDIunKLXht5WzCyyW Update(n11.Path File_Path_In, bool Read_In, out n6.XElement Output_Out)
        {
            var State_Output_1 = this.__p_VcmoJOp081LPyDeEhq3JmZ.Update(File_Path_In: File_Path_In, Read_In: Read_In, Output_Out: out n6.XDocument Output_0);
            n24.XmlNodes.SplitXDocument(input: Output_0, root: out n6.XElement Root_2, declaration: out n6.XDeclaration Declaration_3, documentType: out n6.XDocumentType Document_Type_4);
            Output_Out = Root_2;
            n36.XMLReader_OcM6yTDIunKLXht5WzCyyW that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = State_Output_1 != this.__p_VcmoJOp081LPyDeEhq3JmZ ? new XMLReader_OcM6yTDIunKLXht5WzCyyW(this)
                {__p_VcmoJOp081LPyDeEhq3JmZ = State_Output_1} : that_5;
            else
            {
                this.__p_VcmoJOp081LPyDeEhq3JmZ = State_Output_1;
            }

            return that_5;
        }

        public n36.XMLReader_OcM6yTDIunKLXht5WzCyyW __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "VcmoJOp081LPyDeEhq3JmZ", 216754U);
            var Output_1 = n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ.Create(Node_Context: Node_Context_0);
            n36.XMLReader_OcM6yTDIunKLXht5WzCyyW that_2 = this;
            this.__p_VcmoJOp081LPyDeEhq3JmZ = Output_1;
            return that_2;
        }

        public n36.XMLReader_OcM6yTDIunKLXht5WzCyyW __CreateDefault__()
        {
            n36.XMLReader_OcM6yTDIunKLXht5WzCyyW that_0 = this;
            this.__p_VcmoJOp081LPyDeEhq3JmZ = n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VcmoJOp081LPyDeEhq3JmZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216754U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "VcmoJOp081LPyDeEhq3JmZ", Name = "XMLReader (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __p_VcmoJOp081LPyDeEhq3JmZ;
        public XMLReader_OcM6yTDIunKLXht5WzCyyW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLReader_OcM6yTDIunKLXht5WzCyyW(XMLReader_OcM6yTDIunKLXht5WzCyyW other): base(other)
        {
            this.__p_VcmoJOp081LPyDeEhq3JmZ = other.__p_VcmoJOp081LPyDeEhq3JmZ;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VcmoJOp081LPyDeEhq3JmZ", in __p_VcmoJOp081LPyDeEhq3JmZ));
        }

        internal XMLReader_OcM6yTDIunKLXht5WzCyyW __WITH__(n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __p_VcmoJOp081LPyDeEhq3JmZ)
        {
            n36.XMLReader_OcM6yTDIunKLXht5WzCyyW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VcmoJOp081LPyDeEhq3JmZ != this.__p_VcmoJOp081LPyDeEhq3JmZ ? new XMLReader_OcM6yTDIunKLXht5WzCyyW(this)
                {__p_VcmoJOp081LPyDeEhq3JmZ = __p_VcmoJOp081LPyDeEhq3JmZ} : that_0;
            else
            {
                this.__p_VcmoJOp081LPyDeEhq3JmZ = __p_VcmoJOp081LPyDeEhq3JmZ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216831U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SKFRbeanCu4NWa79zKnx9Q", Name = "JSONReader_SKFRbeanCu4NWa79zKnx9Q")]
    [n2.SerializableAttribute]
    public class JSONReader_SKFRbeanCu4NWa79zKnx9Q : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONReader_SKFRbeanCu4NWa79zKnx9Q(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q CreateDefault()
        {
            var instance = new JSONReader_SKFRbeanCu4NWa79zKnx9Q(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q Update(n11.Path File_Path_In, n12.Encodings Encoding_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, bool Read_In, out n6.XElement Output_Out)
        {
            var State_Output_1 = this.__p_QERjM7hgfjlOLNDmOumbeD.Update(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Deserialize_Root_Element_Name_In: Deserialize_Root_Element_Name_In, Write_Array_Attribute_In: Write_Array_Attribute_In, Read_In: Read_In, Output_Out: out n6.XDocument Output_0);
            n24.XmlNodes.SplitXDocument(input: Output_0, root: out n6.XElement Root_2, declaration: out n6.XDeclaration Declaration_3, documentType: out n6.XDocumentType Document_Type_4);
            Output_Out = Root_2;
            n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = State_Output_1 != this.__p_QERjM7hgfjlOLNDmOumbeD ? new JSONReader_SKFRbeanCu4NWa79zKnx9Q(this)
                {__p_QERjM7hgfjlOLNDmOumbeD = State_Output_1} : that_5;
            else
            {
                this.__p_QERjM7hgfjlOLNDmOumbeD = State_Output_1;
            }

            return that_5;
        }

        public n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "QERjM7hgfjlOLNDmOumbeD", 216856U);
            var Output_1 = n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG.Create(Node_Context: Node_Context_0);
            n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q that_2 = this;
            this.__p_QERjM7hgfjlOLNDmOumbeD = Output_1;
            return that_2;
        }

        public n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q __CreateDefault__()
        {
            n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q that_0 = this;
            this.__p_QERjM7hgfjlOLNDmOumbeD = n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QERjM7hgfjlOLNDmOumbeD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216856U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "QERjM7hgfjlOLNDmOumbeD", Name = "JSONReader (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG __p_QERjM7hgfjlOLNDmOumbeD;
        public JSONReader_SKFRbeanCu4NWa79zKnx9Q(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONReader_SKFRbeanCu4NWa79zKnx9Q(JSONReader_SKFRbeanCu4NWa79zKnx9Q other): base(other)
        {
            this.__p_QERjM7hgfjlOLNDmOumbeD = other.__p_QERjM7hgfjlOLNDmOumbeD;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QERjM7hgfjlOLNDmOumbeD", in __p_QERjM7hgfjlOLNDmOumbeD));
        }

        internal JSONReader_SKFRbeanCu4NWa79zKnx9Q __WITH__(n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG __p_QERjM7hgfjlOLNDmOumbeD)
        {
            n36.JSONReader_SKFRbeanCu4NWa79zKnx9Q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QERjM7hgfjlOLNDmOumbeD != this.__p_QERjM7hgfjlOLNDmOumbeD ? new JSONReader_SKFRbeanCu4NWa79zKnx9Q(this)
                {__p_QERjM7hgfjlOLNDmOumbeD = __p_QERjM7hgfjlOLNDmOumbeD} : that_0;
            else
            {
                this.__p_QERjM7hgfjlOLNDmOumbeD = __p_QERjM7hgfjlOLNDmOumbeD;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216933U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "K3RuV8m5vRVMCM7TAI7w2R", Name = "XMLWriter_K3RuV8m5vRVMCM7TAI7w2R")]
    [n2.SerializableAttribute]
    public class XMLWriter_K3RuV8m5vRVMCM7TAI7w2R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R CreateDefault()
        {
            var instance = new XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R Update(n11.Path File_Path_In, n6.XElement Data_In, bool Write_In)
        {
            n6.XDeclaration Declaration_0 = n38._Operations_.CreateDefault();
            n6.XDocumentType Document_Type_1 = n39._Operations_.CreateDefault();
            var Result_2 = n24.XmlNodes.JoinXDocument(root: Data_In, declaration: Declaration_0, documentType: Document_Type_1);
            bool Update_3 = true;
            var Output_4 = this.__p_J6UfP6y8neuMdXJFu6vOBH;
            if (Update_3)
            {
                Output_4 = this.__p_J6UfP6y8neuMdXJFu6vOBH.Update(File_Path_In: File_Path_In, Data_In: Result_2, Write_In: Write_In);
            }

            n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Output_4 != this.__p_J6UfP6y8neuMdXJFu6vOBH ? new XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(this)
                {__p_J6UfP6y8neuMdXJFu6vOBH = Output_4} : that_5;
            else
            {
                this.__p_J6UfP6y8neuMdXJFu6vOBH = Output_4;
            }

            return that_5;
        }

        public n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "J6UfP6y8neuMdXJFu6vOBH", 216952U);
            var Output_1 = n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv.Create(Node_Context: Node_Context_0);
            n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R that_2 = this;
            this.__p_J6UfP6y8neuMdXJFu6vOBH = Output_1;
            return that_2;
        }

        public n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R __CreateDefault__()
        {
            n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R that_0 = this;
            this.__p_J6UfP6y8neuMdXJFu6vOBH = n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_J6UfP6y8neuMdXJFu6vOBH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216952U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "J6UfP6y8neuMdXJFu6vOBH", Name = "XMLWriter (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __p_J6UfP6y8neuMdXJFu6vOBH;
        public XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(XMLWriter_K3RuV8m5vRVMCM7TAI7w2R other): base(other)
        {
            this.__p_J6UfP6y8neuMdXJFu6vOBH = other.__p_J6UfP6y8neuMdXJFu6vOBH;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_J6UfP6y8neuMdXJFu6vOBH", in __p_J6UfP6y8neuMdXJFu6vOBH));
        }

        internal XMLWriter_K3RuV8m5vRVMCM7TAI7w2R __WITH__(n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __p_J6UfP6y8neuMdXJFu6vOBH)
        {
            n36.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_J6UfP6y8neuMdXJFu6vOBH != this.__p_J6UfP6y8neuMdXJFu6vOBH ? new XMLWriter_K3RuV8m5vRVMCM7TAI7w2R(this)
                {__p_J6UfP6y8neuMdXJFu6vOBH = __p_J6UfP6y8neuMdXJFu6vOBH} : that_0;
            else
            {
                this.__p_J6UfP6y8neuMdXJFu6vOBH = __p_J6UfP6y8neuMdXJFu6vOBH;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216981U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "G5eJOYNGp5vO7mYwtKIE40", Name = "JSONWriter_G5eJOYNGp5vO7mYwtKIE40")]
    [n2.SerializableAttribute]
    public class JSONWriter_G5eJOYNGp5vO7mYwtKIE40 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONWriter_G5eJOYNGp5vO7mYwtKIE40(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 CreateDefault()
        {
            var instance = new JSONWriter_G5eJOYNGp5vO7mYwtKIE40(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 Update(n11.Path File_Path_In, n6.XElement Data_In, n12.Encodings Encoding_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Indent_In, bool Omit_Root_Object_In, bool Write_In)
        {
            n6.XDeclaration Declaration_0 = n38._Operations_.CreateDefault();
            n6.XDocumentType Document_Type_1 = n39._Operations_.CreateDefault();
            var Result_2 = n24.XmlNodes.JoinXDocument(root: Data_In, declaration: Declaration_0, documentType: Document_Type_1);
            bool Update_3 = true;
            var Output_4 = this.__p_K4wMLGwkHFOMtJPNTw51UH;
            if (Update_3)
            {
                Output_4 = this.__p_K4wMLGwkHFOMtJPNTw51UH.Update(File_Path_In: File_Path_In, Data_In: Result_2, Encoding_In: Encoding_In, Indent_In: Indent_In, Omit_Root_Object_In: Omit_Root_Object_In, Write_In: Write_In);
            }

            n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = Output_4 != this.__p_K4wMLGwkHFOMtJPNTw51UH ? new JSONWriter_G5eJOYNGp5vO7mYwtKIE40(this)
                {__p_K4wMLGwkHFOMtJPNTw51UH = Output_4} : that_5;
            else
            {
                this.__p_K4wMLGwkHFOMtJPNTw51UH = Output_4;
            }

            return that_5;
        }

        public n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "K4wMLGwkHFOMtJPNTw51UH", 216990U);
            var Output_1 = n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7.Create(Node_Context: Node_Context_0);
            n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 that_2 = this;
            this.__p_K4wMLGwkHFOMtJPNTw51UH = Output_1;
            return that_2;
        }

        public n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 __CreateDefault__()
        {
            n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 that_0 = this;
            this.__p_K4wMLGwkHFOMtJPNTw51UH = n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_K4wMLGwkHFOMtJPNTw51UH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216990U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "K4wMLGwkHFOMtJPNTw51UH", Name = "JSONWriter (XDocument)", IsManaged = true, IsAutoGenerated = true)]
        public n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 __p_K4wMLGwkHFOMtJPNTw51UH;
        public JSONWriter_G5eJOYNGp5vO7mYwtKIE40(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONWriter_G5eJOYNGp5vO7mYwtKIE40(JSONWriter_G5eJOYNGp5vO7mYwtKIE40 other): base(other)
        {
            this.__p_K4wMLGwkHFOMtJPNTw51UH = other.__p_K4wMLGwkHFOMtJPNTw51UH;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_K4wMLGwkHFOMtJPNTw51UH", in __p_K4wMLGwkHFOMtJPNTw51UH));
        }

        internal JSONWriter_G5eJOYNGp5vO7mYwtKIE40 __WITH__(n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 __p_K4wMLGwkHFOMtJPNTw51UH)
        {
            n36.JSONWriter_G5eJOYNGp5vO7mYwtKIE40 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_K4wMLGwkHFOMtJPNTw51UH != this.__p_K4wMLGwkHFOMtJPNTw51UH ? new JSONWriter_G5eJOYNGp5vO7mYwtKIE40(this)
                {__p_K4wMLGwkHFOMtJPNTw51UH = __p_K4wMLGwkHFOMtJPNTw51UH} : that_0;
            else
            {
                this.__p_K4wMLGwkHFOMtJPNTw51UH = __p_K4wMLGwkHFOMtJPNTw51UH;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 217027U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "BrT4tiQ7m76MQPPcJOvDX2", Name = "XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2")]
    [n2.SerializableAttribute]
    public class XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 CreateDefault()
        {
            var instance = new XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 Update(n11.Path File_Path_In, bool Read_In, out n2.IObservable<n6.XElement> Output_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var State_Output_3 = this.__p_K0YIbTEmZzaLkMUTHDGlvC.Update(File_Path_In: File_Path_In, Read_In: Read_In, Output_Out: out n2.IObservable<n6.XDocument> Output_0, In_Progress_Out: out bool In_Progress_1, On_Completed_Out: out bool On_Completed_2);
            var __fallback___4 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_S0FWzZCQh3yPvON8f4HTGu.Update<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Value_In: Output_0, Selector_In: (n6.XDocument Arg_1_In_6, int Arg_2_In_7) =>
            {
                using var __current_5 = __fallback___4.MakeCurrentIfNone();
                n24.XmlNodes.SplitXDocument(input: Arg_1_In_6, root: out n6.XElement Root_8, declaration: out n6.XDeclaration Declaration_9, documentType: out n6.XDocumentType Document_Type_10);
                return Root_8;
            }

            , Result_Out: out n2.IObservable<n6.XElement> Result_11, Changed_Out: out bool Changed_12);
            bool Reset_14 = false;
            n41._Operations_.Update_H<n6.XElement>(Input__this__In: this.__p_M3D9J4upG5ONZRoxcEGi5o, Input_In: Result_11, Reset_In: Reset_14, Output_Out: out n21.DebugNode<n6.XElement> Output_15, Result_Out: out n2.IObservable<n6.XElement> Result_16, Input_Changed_Count_Out: out int Input_Changed_Count_17, Subscribe_Calls_Out: out int Subscribe_Calls_18, On_Next_Calls_Out: out int On_Next_Calls_19, On_Error_Calls_Out: out int On_Error_Calls_20, On_Completed_Calls_Out: out int On_Completed_Calls_21, Unsubscribe_Calls_Out: out int Unsubscribe_Calls_22, Latest_Thread_Id_Out: out int Latest_Thread_Id_23);
            Output_Out = Result_16;
            In_Progress_Out = In_Progress_1;
            On_Completed_Out = On_Completed_2;
            n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = State_Output_3 != this.__p_K0YIbTEmZzaLkMUTHDGlvC || Output_13 != this.__p_S0FWzZCQh3yPvON8f4HTGu || Output_15 != this.__p_M3D9J4upG5ONZRoxcEGi5o ? new XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(this)
                {__p_K0YIbTEmZzaLkMUTHDGlvC = State_Output_3, __p_S0FWzZCQh3yPvON8f4HTGu = Output_13, __p_M3D9J4upG5ONZRoxcEGi5o = Output_15} : that_24;
            else
            {
                this.__p_K0YIbTEmZzaLkMUTHDGlvC = State_Output_3;
                this.__p_S0FWzZCQh3yPvON8f4HTGu = Output_13;
                this.__p_M3D9J4upG5ONZRoxcEGi5o = Output_15;
            }

            return that_24;
        }

        public n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "M3D9J4upG5ONZRoxcEGi5o", 217035U);
            n41._Operations_.Create_H<n6.XElement>(Node_Context: Node_Context_0, Output_Out: out n21.DebugNode<n6.XElement> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "S0FWzZCQh3yPvON8f4HTGu", 217046U);
            var Output_3 = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement>.Create<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "K0YIbTEmZzaLkMUTHDGlvC", 217073U);
            var Output_5 = n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT.Create(Node_Context: Node_Context_4);
            n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 that_6 = this;
            this.__p_M3D9J4upG5ONZRoxcEGi5o = Output_1;
            this.__p_S0FWzZCQh3yPvON8f4HTGu = Output_3;
            this.__p_K0YIbTEmZzaLkMUTHDGlvC = Output_5;
            return that_6;
        }

        public n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 __CreateDefault__()
        {
            n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 that_0 = this;
            this.__p_K0YIbTEmZzaLkMUTHDGlvC = n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT.CreateDefault();
            this.__p_S0FWzZCQh3yPvON8f4HTGu = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement>.CreateDefault<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>();
            this.__p_M3D9J4upG5ONZRoxcEGi5o = default(n21.DebugNode<n6.XElement>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_K0YIbTEmZzaLkMUTHDGlvC);
            n1.CompilationHelper.SafeDispose(this.__p_S0FWzZCQh3yPvON8f4HTGu);
            n1.CompilationHelper.SafeDispose(this.__p_M3D9J4upG5ONZRoxcEGi5o);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 217073U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "K0YIbTEmZzaLkMUTHDGlvC", Name = "XMLReader (XDocument Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT __p_K0YIbTEmZzaLkMUTHDGlvC;
        [n1.ElementAttribute(TracingId = 217046U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "S0FWzZCQh3yPvON8f4HTGu", Name = "Select", IsManaged = true, IsAutoGenerated = true)]
        public n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement> __p_S0FWzZCQh3yPvON8f4HTGu;
        [n1.ElementAttribute(TracingId = 217035U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "M3D9J4upG5ONZRoxcEGi5o", Name = "Debug", IsManaged = true, IsAutoGenerated = true)]
        public n21.DebugNode<n6.XElement> __p_M3D9J4upG5ONZRoxcEGi5o;
        public XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 other): base(other)
        {
            this.__p_K0YIbTEmZzaLkMUTHDGlvC = other.__p_K0YIbTEmZzaLkMUTHDGlvC;
            this.__p_S0FWzZCQh3yPvON8f4HTGu = other.__p_S0FWzZCQh3yPvON8f4HTGu;
            this.__p_M3D9J4upG5ONZRoxcEGi5o = other.__p_M3D9J4upG5ONZRoxcEGi5o;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_K0YIbTEmZzaLkMUTHDGlvC", in __p_K0YIbTEmZzaLkMUTHDGlvC), n1.CompilationHelper.GetValueOrExisting(values, "__p_S0FWzZCQh3yPvON8f4HTGu", in __p_S0FWzZCQh3yPvON8f4HTGu), n1.CompilationHelper.GetValueOrExisting(values, "__p_M3D9J4upG5ONZRoxcEGi5o", in __p_M3D9J4upG5ONZRoxcEGi5o));
        }

        internal XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 __WITH__(n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT __p_K0YIbTEmZzaLkMUTHDGlvC, n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement> __p_S0FWzZCQh3yPvON8f4HTGu, n21.DebugNode<n6.XElement> __p_M3D9J4upG5ONZRoxcEGi5o)
        {
            n36.XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_K0YIbTEmZzaLkMUTHDGlvC != this.__p_K0YIbTEmZzaLkMUTHDGlvC || __p_S0FWzZCQh3yPvON8f4HTGu != this.__p_S0FWzZCQh3yPvON8f4HTGu || __p_M3D9J4upG5ONZRoxcEGi5o != this.__p_M3D9J4upG5ONZRoxcEGi5o ? new XMLReader_Reactive_BrT4tiQ7m76MQPPcJOvDX2(this)
                {__p_K0YIbTEmZzaLkMUTHDGlvC = __p_K0YIbTEmZzaLkMUTHDGlvC, __p_S0FWzZCQh3yPvON8f4HTGu = __p_S0FWzZCQh3yPvON8f4HTGu, __p_M3D9J4upG5ONZRoxcEGi5o = __p_M3D9J4upG5ONZRoxcEGi5o} : that_0;
            else
            {
                this.__p_K0YIbTEmZzaLkMUTHDGlvC = __p_K0YIbTEmZzaLkMUTHDGlvC;
                this.__p_S0FWzZCQh3yPvON8f4HTGu = __p_S0FWzZCQh3yPvON8f4HTGu;
                this.__p_M3D9J4upG5ONZRoxcEGi5o = __p_M3D9J4upG5ONZRoxcEGi5o;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 217157U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "NjSdpwlJJeQO9pvEf8bCYm", Name = "JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm")]
    [n2.SerializableAttribute]
    public class JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm CreateDefault()
        {
            var instance = new JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm Update(n11.Path File_Path_In, n12.Encodings Encoding_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, bool Read_In, out n2.IObservable<n6.XElement> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var State_Output_4 = this.__p_PqusbxuhpuMP6mUyJDYxTw.Update(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Deserialize_Root_Element_Name_In: Deserialize_Root_Element_Name_In, Write_Array_Attribute_In: Write_Array_Attribute_In, Read_In: Read_In, Output_Out: out n2.IObservable<n6.XDocument> Output_0, Progress_Out: out float Progress_1, In_Progress_Out: out bool In_Progress_2, On_Completed_Out: out bool On_Completed_3);
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_14 = this.__p_Vj7ncSu2Yi6PFLwQBslmWs.Update<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Value_In: Output_0, Selector_In: (n6.XDocument Input_1_In_7, int Input_2_In_8) =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n24.XmlNodes.SplitXDocument(input: Input_1_In_7, root: out n6.XElement Root_9, declaration: out n6.XDeclaration Declaration_10, documentType: out n6.XDocumentType Document_Type_11);
                return Root_9;
            }

            , Result_Out: out n2.IObservable<n6.XElement> Result_12, Changed_Out: out bool Changed_13);
            Output_Out = Result_12;
            Progress_Out = Progress_1;
            In_Progress_Out = In_Progress_2;
            On_Completed_Out = On_Completed_3;
            n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = State_Output_4 != this.__p_PqusbxuhpuMP6mUyJDYxTw || Output_14 != this.__p_Vj7ncSu2Yi6PFLwQBslmWs ? new JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(this)
                {__p_PqusbxuhpuMP6mUyJDYxTw = State_Output_4, __p_Vj7ncSu2Yi6PFLwQBslmWs = Output_14} : that_15;
            else
            {
                this.__p_PqusbxuhpuMP6mUyJDYxTw = State_Output_4;
                this.__p_Vj7ncSu2Yi6PFLwQBslmWs = Output_14;
            }

            return that_15;
        }

        public n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "PqusbxuhpuMP6mUyJDYxTw", 217187U);
            var Output_1 = n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Vj7ncSu2Yi6PFLwQBslmWs", 217203U);
            var Output_3 = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement>.Create<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Node_Context: Node_Context_2);
            n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm that_4 = this;
            this.__p_PqusbxuhpuMP6mUyJDYxTw = Output_1;
            this.__p_Vj7ncSu2Yi6PFLwQBslmWs = Output_3;
            return that_4;
        }

        public n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm __CreateDefault__()
        {
            n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm that_0 = this;
            this.__p_PqusbxuhpuMP6mUyJDYxTw = n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai.CreateDefault();
            this.__p_Vj7ncSu2Yi6PFLwQBslmWs = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement>.CreateDefault<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PqusbxuhpuMP6mUyJDYxTw);
            n1.CompilationHelper.SafeDispose(this.__p_Vj7ncSu2Yi6PFLwQBslmWs);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 217187U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "PqusbxuhpuMP6mUyJDYxTw", Name = "JSONReader (XDocument Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai __p_PqusbxuhpuMP6mUyJDYxTw;
        [n1.ElementAttribute(TracingId = 217203U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Vj7ncSu2Yi6PFLwQBslmWs", Name = "Select", IsManaged = true, IsAutoGenerated = true)]
        public n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement> __p_Vj7ncSu2Yi6PFLwQBslmWs;
        public JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm other): base(other)
        {
            this.__p_PqusbxuhpuMP6mUyJDYxTw = other.__p_PqusbxuhpuMP6mUyJDYxTw;
            this.__p_Vj7ncSu2Yi6PFLwQBslmWs = other.__p_Vj7ncSu2Yi6PFLwQBslmWs;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PqusbxuhpuMP6mUyJDYxTw", in __p_PqusbxuhpuMP6mUyJDYxTw), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vj7ncSu2Yi6PFLwQBslmWs", in __p_Vj7ncSu2Yi6PFLwQBslmWs));
        }

        internal JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm __WITH__(n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai __p_PqusbxuhpuMP6mUyJDYxTw, n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XDocument>, n6.XDocument, n6.XElement> __p_Vj7ncSu2Yi6PFLwQBslmWs)
        {
            n36.JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PqusbxuhpuMP6mUyJDYxTw != this.__p_PqusbxuhpuMP6mUyJDYxTw || __p_Vj7ncSu2Yi6PFLwQBslmWs != this.__p_Vj7ncSu2Yi6PFLwQBslmWs ? new JSONReader_Reactive_NjSdpwlJJeQO9pvEf8bCYm(this)
                {__p_PqusbxuhpuMP6mUyJDYxTw = __p_PqusbxuhpuMP6mUyJDYxTw, __p_Vj7ncSu2Yi6PFLwQBslmWs = __p_Vj7ncSu2Yi6PFLwQBslmWs} : that_0;
            else
            {
                this.__p_PqusbxuhpuMP6mUyJDYxTw = __p_PqusbxuhpuMP6mUyJDYxTw;
                this.__p_Vj7ncSu2Yi6PFLwQBslmWs = __p_Vj7ncSu2Yi6PFLwQBslmWs;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 217353U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MqVhXYAsYAJNTdWUWjIBSd", Name = "XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd")]
    [n2.SerializableAttribute]
    public class XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd CreateDefault()
        {
            var instance = new XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd Update(n11.Path File_Path_In, n2.IObservable<n6.XElement> Data_In, out bool In_Progress_Out, out bool OnCompleted_Out)
        {
            bool Reset_0 = false;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n43._Operations_.Update_H<n2.Object, n6.XElement, n6.XDocument>(Input_In: this.__p_SjDSsrMx2jfQAWilSw2RH6, Messages_In: Data_In, Reset_In: Reset_0, Update_In: (n2.Object s_4, n6.XElement Input_1_In_5) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var state_3 = n1.CompilationHelper.Restore<__DNIl8zHz6OBOkAxZCjk2Mh>(s_4, __GetContext__());
                n6.XDeclaration Declaration_6 = n38._Operations_.CreateDefault();
                n6.XDocumentType Document_Type_7 = n39._Operations_.CreateDefault();
                var Result_8 = n24.XmlNodes.JoinXDocument(root: Input_1_In_5, declaration: Declaration_6, documentType: Document_Type_7);
                return n2.Tuple.Create<n2.Object, n6.XDocument>(state_3, Result_8);
            }

            , Create_In: () =>
            {
                using var __current_9 = __fallback___1.MakeCurrentIfNone();
                var state_3 = new __DNIl8zHz6OBOkAxZCjk2Mh(__GetContext__(), n1.VLObject.NewIdentity());
                return state_3;
            }

            , Output_Out: out n21.ForEach<n2.Object, n6.XElement, n6.XDocument> Output_10, Result_Out: out n2.IObservable<n6.XDocument> Result_11);
            var Output_14 = this.__p_AsvC3GkdkSDMdSaWCgf8wn.Update(File_Path_In: File_Path_In, Data_In: Result_11, In_Progress_Out: out bool In_Progress_12, OnCompleted_Out: out bool OnCompleted_13);
            In_Progress_Out = In_Progress_12;
            OnCompleted_Out = OnCompleted_13;
            n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Output_10 != this.__p_SjDSsrMx2jfQAWilSw2RH6 || Output_14 != this.__p_AsvC3GkdkSDMdSaWCgf8wn ? new XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(this)
                {__p_SjDSsrMx2jfQAWilSw2RH6 = Output_10, __p_AsvC3GkdkSDMdSaWCgf8wn = Output_14} : that_15;
            else
            {
                this.__p_SjDSsrMx2jfQAWilSw2RH6 = Output_10;
                this.__p_AsvC3GkdkSDMdSaWCgf8wn = Output_14;
            }

            return that_15;
        }

        public n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "SjDSsrMx2jfQAWilSw2RH6", 217371U);
            n43._Operations_.Create_H<n2.Object, n6.XElement, n6.XDocument>(Node_Context: Node_Context_0, Output_Out: out n21.ForEach<n2.Object, n6.XElement, n6.XDocument> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "AsvC3GkdkSDMdSaWCgf8wn", 217438U);
            var Output_3 = n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv.Create(Node_Context: Node_Context_2);
            n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd that_4 = this;
            this.__p_SjDSsrMx2jfQAWilSw2RH6 = Output_1;
            this.__p_AsvC3GkdkSDMdSaWCgf8wn = Output_3;
            return that_4;
        }

        public n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd __CreateDefault__()
        {
            n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd that_0 = this;
            this.__p_SjDSsrMx2jfQAWilSw2RH6 = default(n21.ForEach<n2.Object, n6.XElement, n6.XDocument>);
            this.__p_AsvC3GkdkSDMdSaWCgf8wn = n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SjDSsrMx2jfQAWilSw2RH6);
            n1.CompilationHelper.SafeDispose(this.__p_AsvC3GkdkSDMdSaWCgf8wn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 217371U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SjDSsrMx2jfQAWilSw2RH6", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n21.ForEach<n2.Object, n6.XElement, n6.XDocument> __p_SjDSsrMx2jfQAWilSw2RH6;
        [n1.ElementAttribute(TracingId = 217438U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "AsvC3GkdkSDMdSaWCgf8wn", Name = "XMLWriter (XDocument Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv __p_AsvC3GkdkSDMdSaWCgf8wn;
        public XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd other): base(other)
        {
            this.__p_SjDSsrMx2jfQAWilSw2RH6 = other.__p_SjDSsrMx2jfQAWilSw2RH6;
            this.__p_AsvC3GkdkSDMdSaWCgf8wn = other.__p_AsvC3GkdkSDMdSaWCgf8wn;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SjDSsrMx2jfQAWilSw2RH6", in __p_SjDSsrMx2jfQAWilSw2RH6), n1.CompilationHelper.GetValueOrExisting(values, "__p_AsvC3GkdkSDMdSaWCgf8wn", in __p_AsvC3GkdkSDMdSaWCgf8wn));
        }

        internal XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd __WITH__(n21.ForEach<n2.Object, n6.XElement, n6.XDocument> __p_SjDSsrMx2jfQAWilSw2RH6, n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv __p_AsvC3GkdkSDMdSaWCgf8wn)
        {
            n36.XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SjDSsrMx2jfQAWilSw2RH6 != this.__p_SjDSsrMx2jfQAWilSw2RH6 || __p_AsvC3GkdkSDMdSaWCgf8wn != this.__p_AsvC3GkdkSDMdSaWCgf8wn ? new XMLWriter_Reactive_MqVhXYAsYAJNTdWUWjIBSd(this)
                {__p_SjDSsrMx2jfQAWilSw2RH6 = __p_SjDSsrMx2jfQAWilSw2RH6, __p_AsvC3GkdkSDMdSaWCgf8wn = __p_AsvC3GkdkSDMdSaWCgf8wn} : that_0;
            else
            {
                this.__p_SjDSsrMx2jfQAWilSw2RH6 = __p_SjDSsrMx2jfQAWilSw2RH6;
                this.__p_AsvC3GkdkSDMdSaWCgf8wn = __p_AsvC3GkdkSDMdSaWCgf8wn;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DNIl8zHz6OBOkAxZCjk2Mh", Name = "__DNIl8zHz6OBOkAxZCjk2Mh")]
        [n2.SerializableAttribute]
        public class __DNIl8zHz6OBOkAxZCjk2Mh : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __DNIl8zHz6OBOkAxZCjk2Mh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DNIl8zHz6OBOkAxZCjk2Mh(__DNIl8zHz6OBOkAxZCjk2Mh other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __DNIl8zHz6OBOkAxZCjk2Mh __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 217516U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "D9F91fz2SCnN1P2g3oMjAS", Name = "JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS")]
    [n2.SerializableAttribute]
    public class JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS CreateDefault()
        {
            var instance = new JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS Update(n11.Path File_Path_In, n2.IObservable<n6.XElement> Data_In, n12.Encodings Encoding_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Indent_In, bool Omit_Root_Object_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            bool Reset_0 = false;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n43._Operations_.Update_H<n2.Object, n6.XElement, n6.XDocument>(Input_In: this.__p_VsBqv3yahnmM2gQtyhuLhR, Messages_In: Data_In, Reset_In: Reset_0, Update_In: (n2.Object s_4, n6.XElement Input_1_In_5) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var state_3 = n1.CompilationHelper.Restore<__MiW5KSGVe7JMWRScCcsm2Z>(s_4, __GetContext__());
                n6.XDeclaration Declaration_6 = n38._Operations_.CreateDefault();
                n6.XDocumentType Document_Type_7 = n39._Operations_.CreateDefault();
                var Result_8 = n24.XmlNodes.JoinXDocument(root: Input_1_In_5, declaration: Declaration_6, documentType: Document_Type_7);
                return n2.Tuple.Create<n2.Object, n6.XDocument>(state_3, Result_8);
            }

            , Create_In: () =>
            {
                using var __current_9 = __fallback___1.MakeCurrentIfNone();
                var state_3 = new __MiW5KSGVe7JMWRScCcsm2Z(__GetContext__(), n1.VLObject.NewIdentity());
                return state_3;
            }

            , Output_Out: out n21.ForEach<n2.Object, n6.XElement, n6.XDocument> Output_10, Result_Out: out n2.IObservable<n6.XDocument> Result_11);
            n2.IObservable<n6.XNode> Data_12 = (n2.IObservable<n6.XNode>)Result_11;
            var Output_16 = this.__p_Geh2USfZeDmNyP4NhzE3J4.Update(File_Path_In: File_Path_In, Data_In: Data_12, Encoding_In: Encoding_In, Indent_In: Indent_In, Omit_Root_Object_In: Omit_Root_Object_In, Progress_Out: out float Progress_13, In_Progress_Out: out bool In_Progress_14, On_Completed_Out: out bool On_Completed_15);
            Progress_Out = Progress_13;
            In_Progress_Out = In_Progress_14;
            On_Completed_Out = On_Completed_15;
            n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS that_17 = this;
            if (this.__GetContext__().IsImmutable)
                that_17 = Output_10 != this.__p_VsBqv3yahnmM2gQtyhuLhR || Output_16 != this.__p_Geh2USfZeDmNyP4NhzE3J4 ? new JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(this)
                {__p_VsBqv3yahnmM2gQtyhuLhR = Output_10, __p_Geh2USfZeDmNyP4NhzE3J4 = Output_16} : that_17;
            else
            {
                this.__p_VsBqv3yahnmM2gQtyhuLhR = Output_10;
                this.__p_Geh2USfZeDmNyP4NhzE3J4 = Output_16;
            }

            return that_17;
        }

        public n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Geh2USfZeDmNyP4NhzE3J4", 217541U);
            var Output_1 = n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "VsBqv3yahnmM2gQtyhuLhR", 217581U);
            n43._Operations_.Create_H<n2.Object, n6.XElement, n6.XDocument>(Node_Context: Node_Context_2, Output_Out: out n21.ForEach<n2.Object, n6.XElement, n6.XDocument> Output_3);
            n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS that_4 = this;
            this.__p_Geh2USfZeDmNyP4NhzE3J4 = Output_1;
            this.__p_VsBqv3yahnmM2gQtyhuLhR = Output_3;
            return that_4;
        }

        public n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS __CreateDefault__()
        {
            n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS that_0 = this;
            this.__p_VsBqv3yahnmM2gQtyhuLhR = default(n21.ForEach<n2.Object, n6.XElement, n6.XDocument>);
            this.__p_Geh2USfZeDmNyP4NhzE3J4 = n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VsBqv3yahnmM2gQtyhuLhR);
            n1.CompilationHelper.SafeDispose(this.__p_Geh2USfZeDmNyP4NhzE3J4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 217581U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "VsBqv3yahnmM2gQtyhuLhR", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n21.ForEach<n2.Object, n6.XElement, n6.XDocument> __p_VsBqv3yahnmM2gQtyhuLhR;
        [n1.ElementAttribute(TracingId = 217541U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Geh2USfZeDmNyP4NhzE3J4", Name = "JSONWriter (XDocument Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk __p_Geh2USfZeDmNyP4NhzE3J4;
        public JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS other): base(other)
        {
            this.__p_VsBqv3yahnmM2gQtyhuLhR = other.__p_VsBqv3yahnmM2gQtyhuLhR;
            this.__p_Geh2USfZeDmNyP4NhzE3J4 = other.__p_Geh2USfZeDmNyP4NhzE3J4;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VsBqv3yahnmM2gQtyhuLhR", in __p_VsBqv3yahnmM2gQtyhuLhR), n1.CompilationHelper.GetValueOrExisting(values, "__p_Geh2USfZeDmNyP4NhzE3J4", in __p_Geh2USfZeDmNyP4NhzE3J4));
        }

        internal JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS __WITH__(n21.ForEach<n2.Object, n6.XElement, n6.XDocument> __p_VsBqv3yahnmM2gQtyhuLhR, n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk __p_Geh2USfZeDmNyP4NhzE3J4)
        {
            n36.JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VsBqv3yahnmM2gQtyhuLhR != this.__p_VsBqv3yahnmM2gQtyhuLhR || __p_Geh2USfZeDmNyP4NhzE3J4 != this.__p_Geh2USfZeDmNyP4NhzE3J4 ? new JSONWriter_Reactive_D9F91fz2SCnN1P2g3oMjAS(this)
                {__p_VsBqv3yahnmM2gQtyhuLhR = __p_VsBqv3yahnmM2gQtyhuLhR, __p_Geh2USfZeDmNyP4NhzE3J4 = __p_Geh2USfZeDmNyP4NhzE3J4} : that_0;
            else
            {
                this.__p_VsBqv3yahnmM2gQtyhuLhR = __p_VsBqv3yahnmM2gQtyhuLhR;
                this.__p_Geh2USfZeDmNyP4NhzE3J4 = __p_Geh2USfZeDmNyP4NhzE3J4;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MiW5KSGVe7JMWRScCcsm2Z", Name = "__MiW5KSGVe7JMWRScCcsm2Z")]
        [n2.SerializableAttribute]
        public class __MiW5KSGVe7JMWRScCcsm2Z : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __MiW5KSGVe7JMWRScCcsm2Z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MiW5KSGVe7JMWRScCcsm2Z(__MiW5KSGVe7JMWRScCcsm2Z other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __MiW5KSGVe7JMWRScCcsm2Z __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 217750U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "V088hn1DYqjQIqSJLRhgqK", Name = "VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK")]
    [n2.SerializableAttribute]
    public class VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n36.VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n36.VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK CreateDefault()
        {
            var instance = new VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK Update()
        {
            return this;
        }

        public n36.VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n36.VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK __CreateDefault__()
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

        public VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK(VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_XmlApplication_V088hn1DYqjQIqSJLRhgqK __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsValid(n6.XNode Input_In, n11.Path Validation_File_In, out bool Is_Valid_Out, out string Error_Message_Out)
        {
            n24.XmlNodes.ValidateXDocumentSchema(node: Input_In, validationFile: Validation_File_In, isValid: out bool Is_Valid_0, errorMessage: out string Error_Message_1);
            Is_Valid_Out = Is_Valid_0;
            Error_Message_Out = Error_Message_1;
            return;
        }

        public static void Parse(string Text_In, n6.LoadOptions Options_In, out n6.XElement Result_Out)
        {
            var Result_0 = n6.XDocument.Parse(text: Text_In, options: Options_In);
            n24.XmlNodes.SplitXDocument(input: Result_0, root: out n6.XElement Root_1, declaration: out n6.XDeclaration Declaration_2, documentType: out n6.XDocumentType Document_Type_3);
            Result_Out = Root_1;
            return;
        }

        public static void ParseJSON(string Input_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, out n6.XElement Result_Out)
        {
            var Result_0 = n24.XmlNodes.DeserializeXNode(json: Input_In, deserializeRootElementName: Deserialize_Root_Element_Name_In, writeArrayAttribute: Write_Array_Attribute_In);
            n24.XmlNodes.SplitXDocument(input: Result_0, root: out n6.XElement Root_1, declaration: out n6.XDeclaration Declaration_2, documentType: out n6.XDocumentType Document_Type_3);
            Result_Out = Root_1;
            return;
        }

        public static void ToJSON(n6.XNode Input_In, bool Indent_In, bool Omit_Root_Object_In, out string Result_Out)
        {
            var Result_0 = n24.XmlNodes.SerializeXNode(input: Input_In, indent: Indent_In, omitRootObject: Omit_Root_Object_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToString(n6.XNode Input_In, out n6.XNode Output_Out, out string Result_Out)
        {
            var Result_0 = Input_In.ToString();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void ToString_SaveOptions(n6.XNode Input_In, n6.SaveOptions Options_In, out n6.XNode Output_Out, out string Result_Out)
        {
            var Result_0 = Input_In.ToString(options: Options_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void XAttribute_Join(string Name_In, string Value_In, out n6.XAttribute Result_Out)
        {
            var Result_0 = n24.XmlNodes.JoinXAttribute(name: Name_In, value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void XAttribute_Split(n6.XAttribute Input_In, out string Name_Out, out string Value_Out)
        {
            n24.XmlNodes.SplitXAttribute(input: Input_In, name: out string Name_0, value: out string Value_1);
            Name_Out = Name_0;
            Value_Out = Value_1;
            return;
        }

        public static void XAttributeByName(n6.XElement Input_In, [n4.SerializedDefaultValueAttribute("Name", false)] string Name_In, out n6.XAttribute Result_Out)
        {
            var Result_0 = n24.XmlNodes.XAttributeByName(input: Input_In, name: Name_In);
            Result_Out = Result_0;
            return;
        }

        public static void XDeclaration_Join([n4.SerializedDefaultValueAttribute("1.0", false)] string Version_In, [n4.SerializedDefaultValueAttribute("UTF-8", false)] string Encoding_In, [n4.SerializedDefaultValueAttribute("no", false)] string Standalone_In, out n6.XDeclaration Result_Out)
        {
            var Result_0 = n24.XmlNodes.JoinXDeclaration(version: Version_In, encoding: Encoding_In, standalone: Standalone_In);
            Result_Out = Result_0;
            return;
        }

        public static void XDeclaration_Split(n6.XDeclaration Input_In, out string Version_Out, out string Encoding_Out, out string Standalone_Out)
        {
            n24.XmlNodes.SplitXDeclaration(input: Input_In, version: out string Version_0, encoding: out string Encoding_1, standalone: out string Standalone_2);
            Version_Out = Version_0;
            Encoding_Out = Encoding_1;
            Standalone_Out = Standalone_2;
            return;
        }

        public static void XDocument_Join(n6.XElement Root_In, n6.XDeclaration Declaration_In, n6.XDocumentType Document_Type_In, out n6.XDocument Result_Out)
        {
            var Result_0 = n24.XmlNodes.JoinXDocument(root: Root_In, declaration: Declaration_In, documentType: Document_Type_In);
            Result_Out = Result_0;
            return;
        }

        public static void XDocument_Split(n6.XDocument Input_In, out n6.XElement Root_Out, out n6.XDeclaration Declaration_Out, out n6.XDocumentType Document_Type_Out)
        {
            n24.XmlNodes.SplitXDocument(input: Input_In, root: out n6.XElement Root_0, declaration: out n6.XDeclaration Declaration_1, documentType: out n6.XDocumentType Document_Type_2);
            Root_Out = Root_0;
            Declaration_Out = Declaration_1;
            Document_Type_Out = Document_Type_2;
            return;
        }

        public static void XDocumentType_Join([n4.SerializedDefaultValueAttribute("ROOT", false)] string Name_In, [n4.SerializedDefaultValueAttribute("", false)] string Public_Id_In, [n4.SerializedDefaultValueAttribute("", false)] string System_Id_In, [n4.SerializedDefaultValueAttribute("", false)] string Internal_Subset_In, out n6.XDocumentType Result_Out)
        {
            var Result_0 = n24.XmlNodes.JoinXDocumentType(name: Name_In, publicId: Public_Id_In, systemId: System_Id_In, internalSubset: Internal_Subset_In);
            Result_Out = Result_0;
            return;
        }

        public static void XDocumentType_Split(n6.XDocumentType Input_In, out string Name_Out, out string Public_Id_Out, out string System_Id_Out, out string Internal_Subset_Out)
        {
            n24.XmlNodes.SplitXDocumentType(input: Input_In, name: out string Name_0, publicId: out string Public_Id_1, systemId: out string System_Id_2, internalSubset: out string Internal_Subset_3);
            Name_Out = Name_0;
            Public_Id_Out = Public_Id_1;
            System_Id_Out = System_Id_2;
            Internal_Subset_Out = Internal_Subset_3;
            return;
        }

        public static void XElement_Join(string Name_In, string Value_In, n14.IEnumerable<n6.XAttribute> Attributes_In, n14.IEnumerable<n6.XElement> Children_In, out n6.XElement Result_Out)
        {
            var Result_0 = n24.XmlNodes.JoinXElement(name: Name_In, value: Value_In, attributes: Attributes_In, children: Children_In);
            Result_Out = Result_0;
            return;
        }

        public static void XElement_Split(n6.XElement Input_In, out string Name_Out, out string Value_Out, out n30.Spread<n6.XElement> Children_Out, out n30.Spread<n6.XAttribute> Attributes_Out)
        {
            n24.XmlNodes.SplitXElement(input: Input_In, name: out string Name_0, value: out string Value_1, children: out n30.Spread<n6.XElement> Children_2, attributes: out n30.Spread<n6.XAttribute> Attributes_3);
            Name_Out = Name_0;
            Value_Out = Value_1;
            Children_Out = Children_2;
            Attributes_Out = Attributes_3;
            return;
        }

        public static void XElementsByName(n6.XElement Input_In, [n4.SerializedDefaultValueAttribute("Name", false)] string Name_In, [n4.SerializedDefaultValueAttribute("False", false)] bool All_Descendants_In, out n30.Spread<n6.XElement> Result_Out)
        {
            var Result_0 = n24.XmlNodes.XElementsByName(input: Input_In, name: Name_In, allDescendants: All_Descendants_In);
            Result_Out = Result_0;
            return;
        }

        public static void XPathSelectElement(n6.XNode Input_In, string Expression_In, out n6.XElement Result_Out)
        {
            var Result_0 = n44.Extensions.XPathSelectElement(node: Input_In, expression: Expression_In);
            Result_Out = Result_0;
            return;
        }

        public static void XPathSelectElements(n6.XNode Input_In, string Expression_In, out n14.IEnumerable<n6.XElement> Result_Out)
        {
            var Result_0 = string.IsNullOrWhiteSpace(value: Expression_In);
            var Output_1 = !Result_0;
            n14.IEnumerable<n6.XElement> __auto_2;
            if (Output_1)
            {
                var Result_3 = n44.Extensions.XPathSelectElements(node: Input_In, expression: Expression_In);
                __auto_2 = Result_3;
            }
            else
            {
                __auto_2 = n45._Operations_.CreateDefault<n6.XElement>();
            }

            Result_Out = __auto_2;
            return;
        }

        public static void XSLT(n6.XDocument Input_In, string Xsl_In, out string Result_Out)
        {
            var Result_0 = n24.XmlNodes.TransformXDocument(input: Input_In, xsl: Xsl_In);
            Result_Out = Result_0;
            return;
        }

        public static void XPathGetValue<T2, T, AdM>(T2 Input_In, string Path_In, out T Value_Out, out bool Success_Out)
            where T2 : n6.XNode where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Result_1 = n44.Extensions.XPathSelectElement(node: Input_In, expression: Path_In);
            n7._Operations_.GetValue<T, AdM>(Input_In: Result_1, Value_Out: out T Value_2, Success_Out: out bool Success_3);
            Value_Out = Value_2;
            Success_Out = Success_3;
            return;
        }

        public static void XPathGetValues<T2, T, AdM>(T2 Input_In, string Path_In, out n30.Spread<T> Values_Out, out n30.Spread<bool> Success_Out)
            where T2 : n6.XNode where AdM : struct, n31.IAdaptiveTryParse<T>
        {
            var w_0 = default(AdM);
            n36._Operations_.XPathSelectElements(Input_In: Input_In, Expression_In: Path_In, Result_Out: out n14.IEnumerable<n6.XElement> Result_1);
            n7._Operations_.GetValues<n14.IEnumerable<n6.XElement>, T, AdM>(Input_In: Result_1, Values_Out: out n30.Spread<T> Values_2, Success_Out: out n30.Spread<bool> Success_3);
            Values_Out = Values_2;
            Success_Out = Success_3;
            return;
        }

        public static void XPathGetAttributeValues<T2, T, AdM>(T2 Input_In, string Expression_In, out n30.Spread<T> Values_Out, out n30.Spread<bool> Success_Out)
            where T2 : n6.XNode where AdM : struct, n31.IAdaptiveTryParse<T>
        {
            var w_0 = default(AdM);
            var Result_1 = string.IsNullOrWhiteSpace(value: Expression_In);
            var Output_2 = !Result_1;
            n2.Object __auto_3;
            if (Output_2)
            {
                var Result_4 = n44.Extensions.XPathEvaluate(node: Input_In, expression: Expression_In);
                __auto_3 = Result_4;
            }
            else
            {
                __auto_3 = n46._Operations_.CreateDefault();
            }

            n29.ObjectHelpers.IsAssigned(x: __auto_3, result: out bool Result_5, notAssigned: out bool Not_Assigned_6);
            var Empty_7 = n47._Operations_.CreateDefault<T>();
            n30.Spread<T> __auto_8;
            n30.Spread<bool> __auto_9;
            if (Result_5)
            {
                n30.Spread<T> __cp_CYHzX6414bHOA3w5gb7aAM = n47._Operations_.CreateDefault<T>();
                n30.Spread<bool> __cp_Gk4AekUhDxkM8jaMN94KCC = n47._Operations_.CreateDefault<bool>();
                n14.IEnumerable<n2.Object> __pad_BHDxDuwsvvLQX5pNEH7YF8_10 = __slot_BHDxDuwsvvLQX5pNEH7YF8;
                n46._Operations_.CastAs<n14.IEnumerable<n2.Object>>(Input_In: __auto_3, Default_In: __pad_BHDxDuwsvvLQX5pNEH7YF8_10, Result_Out: out n14.IEnumerable<n2.Object> Result_11, Success_Out: out bool Success_12);
                var builder_24 = n4.CollectionBuilders.GetBuilder(__cp_CYHzX6414bHOA3w5gb7aAM, 16);
                n30.Spread<T> output_25;
                var builder_26 = n4.CollectionBuilders.GetBuilder(__cp_Gk4AekUhDxkM8jaMN94KCC, 16);
                n30.Spread<bool> output_27;
                try
                {
                    var i_15 = 0;
                    foreach (var item_13 in Result_11)
                    {
                        var splicer_14 = item_13;
                        var i_local_16 = i_15;
                        n6.XAttribute Default_17 = n48._Operations_.CreateDefault();
                        n46._Operations_.CastAs<n6.XAttribute>(Input_In: splicer_14, Default_In: Default_17, Result_Out: out n6.XAttribute Result_18, Success_Out: out bool Success_19);
                        n24.XmlNodes.SplitXAttribute(input: Result_18, name: out string Name_20, value: out string Value_21);
                        w_0.TryParse(String_In: Value_21, Value_Out: out T Value_22, Success_Out: out bool Success_23);
                        builder_24.Add(Value_22);
                        builder_26.Add(Success_23);
                        i_15++;
                    }
                }
                finally
                {
                    output_25 = builder_24.Commit();
                    output_27 = builder_26.Commit();
                }

                __auto_8 = output_25;
                __auto_9 = output_27;
            }
            else
            {
                __auto_8 = Empty_7;
                __auto_9 = n47._Operations_.CreateDefault<bool>();
            }

            Values_Out = __auto_8;
            Success_Out = __auto_9;
            return;
        }

        public static void XPathGetAttributeValue<T2, T, AdM>(T2 Input_In, string Expression_In, out T Value_Out, out bool Success_Out)
            where T2 : n6.XNode where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Result_1 = string.IsNullOrWhiteSpace(value: Expression_In);
            var Output_2 = !Result_1;
            n2.Object __auto_3;
            if (Output_2)
            {
                var Result_4 = n44.Extensions.XPathEvaluate(node: Input_In, expression: Expression_In);
                __auto_3 = Result_4;
            }
            else
            {
                __auto_3 = n46._Operations_.CreateDefault();
            }

            n29.ObjectHelpers.IsAssigned(x: __auto_3, result: out bool Result_5, notAssigned: out bool Not_Assigned_6);
            w_0.CreateDefault(Output_Out: out T Output_7);
            T __auto_8;
            bool __auto_9;
            if (Result_5)
            {
                n14.IEnumerable<n2.Object> __pad_K00pbhLlE38M0c40d9BsYH_10 = __slot_K00pbhLlE38M0c40d9BsYH;
                n46._Operations_.CastAs<n14.IEnumerable<n2.Object>>(Input_In: __auto_3, Default_In: __pad_K00pbhLlE38M0c40d9BsYH_10, Result_Out: out n14.IEnumerable<n2.Object> Result_11, Success_Out: out bool Success_12);
                n2.Object Default_Value_13 = n46._Operations_.CreateDefault();
                n45._Operations_.FirstOrDefault<n14.IEnumerable<n2.Object>, n2.Object>(Input_In: Result_11, Default_Value_In: Default_Value_13, Output_Out: out n14.IEnumerable<n2.Object> Output_14, Result_Out: out n2.Object Result_15);
                n6.XAttribute Default_16 = n48._Operations_.CreateDefault();
                n46._Operations_.CastAs<n6.XAttribute>(Input_In: Result_15, Default_In: Default_16, Result_Out: out n6.XAttribute Result_17, Success_Out: out bool Success_18);
                n24.XmlNodes.SplitXAttribute(input: Result_17, name: out string Name_19, value: out string Value_20);
                w_0.TryParse(String_In: Value_20, Value_Out: out T Value_21, Success_Out: out bool Success_22);
                __auto_8 = Value_21;
                __auto_9 = Success_22;
            }
            else
            {
                __auto_8 = Output_7;
                __auto_9 = false;
            }

            Value_Out = __auto_8;
            Success_Out = __auto_9;
            return;
        }

        [n1.ElementAttribute(TracingId = 213948U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "BHDxDuwsvvLQX5pNEH7YF8", Name = "__slot_BHDxDuwsvvLQX5pNEH7YF8")]
        public static n14.IEnumerable<n2.Object> __slot_BHDxDuwsvvLQX5pNEH7YF8 = n45._Operations_.CreateDefault<n2.Object>();
        [n1.ElementAttribute(TracingId = 214247U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "K00pbhLlE38M0c40d9BsYH", Name = "__slot_K00pbhLlE38M0c40d9BsYH")]
        public static n14.IEnumerable<n2.Object> __slot_K00pbhLlE38M0c40d9BsYH = n45._Operations_.CreateDefault<n2.Object>();
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XAttribute
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.XAttribute CreateDefault()
        {
            string __pad_IoEuxZNbTklP1RM1HkqCi7_0 = __slot_IoEuxZNbTklP1RM1HkqCi7;
            var Result_1 = (n6.XName)__pad_IoEuxZNbTklP1RM1HkqCi7_0;
            n2.Object Value_2 = n46._Operations_.CreateDefault();
            var Output_3 = new n6.XAttribute(name: Result_1, value: Value_2);
            return Output_3;
        }

        public static void NextAttribute(n6.XAttribute Input_In, out n6.XAttribute Output_Out, out n6.XAttribute Next_Attribute_Out)
        {
            var Next_Attribute_0 = Input_In.NextAttribute;
            Output_Out = Input_In;
            Next_Attribute_Out = Next_Attribute_0;
            return;
        }

        public static void PreviousAttribute(n6.XAttribute Input_In, out n6.XAttribute Output_Out, out n6.XAttribute Previous_Attribute_Out)
        {
            var Previous_Attribute_0 = Input_In.PreviousAttribute;
            Output_Out = Input_In;
            Previous_Attribute_Out = Previous_Attribute_0;
            return;
        }

        public static void ToString(n6.XAttribute Input_In, out string Result_Out)
        {
            var Result_0 = (string)Input_In;
            Result_Out = Result_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 211545U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "IoEuxZNbTklP1RM1HkqCi7", Name = "__slot_IoEuxZNbTklP1RM1HkqCi7")]
        public static string __slot_IoEuxZNbTklP1RM1HkqCi7 = "Default";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XDeclaration
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.XDeclaration CreateDefault()
        {
            string __pad_CKIwMSFdbPRN04Cgv2HBuP_0 = __slot_CKIwMSFdbPRN04Cgv2HBuP;
            string __pad_PGI7wnS9LJQMDynKfYKJMx_1 = __slot_PGI7wnS9LJQMDynKfYKJMx;
            string __pad_UyZjMfVLXiSLjct0T6uWbF_2 = __slot_UyZjMfVLXiSLjct0T6uWbF;
            var Output_3 = new n6.XDeclaration(version: __pad_CKIwMSFdbPRN04Cgv2HBuP_0, encoding: __pad_PGI7wnS9LJQMDynKfYKJMx_1, standalone: __pad_UyZjMfVLXiSLjct0T6uWbF_2);
            return Output_3;
        }

        public static void ToString_XDeclaration(n6.XDeclaration Input_In, out n6.XDeclaration Output_Out, out string Result_Out)
        {
            var Result_0 = Input_In.ToString();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 211739U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "CKIwMSFdbPRN04Cgv2HBuP", Name = "__slot_CKIwMSFdbPRN04Cgv2HBuP")]
        public static string __slot_CKIwMSFdbPRN04Cgv2HBuP = "1.0";
        [n1.ElementAttribute(TracingId = 211727U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "PGI7wnS9LJQMDynKfYKJMx", Name = "__slot_PGI7wnS9LJQMDynKfYKJMx")]
        public static string __slot_PGI7wnS9LJQMDynKfYKJMx = "UTF-8";
        [n1.ElementAttribute(TracingId = 211734U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "UyZjMfVLXiSLjct0T6uWbF", Name = "__slot_UyZjMfVLXiSLjct0T6uWbF")]
        public static string __slot_UyZjMfVLXiSLjct0T6uWbF = "yes";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XDocument
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Clone_Deep(n6.XDocument Input_In, out n6.XDocument Original_Out, out n6.XDocument Clone_Out)
        {
            n24.XmlNodes.Clone(input: Input_In, original: out n6.XDocument Original_0, clone: out n6.XDocument Clone_1);
            Original_Out = Original_0;
            Clone_Out = Clone_1;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n6.XDocument CreateDefault()
        {
            n6.XElement __pad_OMZJjIOTSKFP1xKcI8AJ1n_0 = __slot_OMZJjIOTSKFP1xKcI8AJ1n;
            var Output_1 = new n6.XDocument();
            Output_1.Add(content: __pad_OMZJjIOTSKFP1xKcI8AJ1n_0);
            return Output_1;
        }

        public static void Root(n6.XDocument Input_In, out n6.XDocument Output_Out, out n6.XElement Root_Out)
        {
            var Root_0 = Input_In.Root;
            Output_Out = Input_In;
            Root_Out = Root_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 211852U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "OMZJjIOTSKFP1xKcI8AJ1n", Name = "__slot_OMZJjIOTSKFP1xKcI8AJ1n")]
        public static n6.XElement __slot_OMZJjIOTSKFP1xKcI8AJ1n = n7._Operations_.CreateDefault();
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XDocumentType
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.XDocumentType CreateDefault()
        {
            string __pad_DiK9HxF5tcgMn5p1wvB2SB_0 = __slot_DiK9HxF5tcgMn5p1wvB2SB;
            string Public_Id_1 = "";
            string System_Id_2 = "";
            string Internal_Subset_3 = "";
            var Output_4 = new n6.XDocumentType(name: __pad_DiK9HxF5tcgMn5p1wvB2SB_0, publicId: Public_Id_1, systemId: System_Id_2, internalSubset: Internal_Subset_3);
            return Output_4;
        }

        [n1.ElementAttribute(TracingId = 211943U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DiK9HxF5tcgMn5p1wvB2SB", Name = "__slot_DiK9HxF5tcgMn5p1wvB2SB")]
        public static string __slot_DiK9HxF5tcgMn5p1wvB2SB = "ROOT";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XElement
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.XElement CreateDefault()
        {
            string __pad_TkUy26SXJazM4nS5BSJsI2_0 = __slot_TkUy26SXJazM4nS5BSJsI2;
            var Result_1 = (n6.XName)__pad_TkUy26SXJazM4nS5BSJsI2_0;
            var Output_2 = new n6.XElement(name: Result_1);
            return Output_2;
        }

        public static void FirstAttribute(n6.XElement Input_In, out n6.XElement Output_Out, out n6.XAttribute First_Attribute_Out)
        {
            var First_Attribute_0 = Input_In.FirstAttribute;
            Output_Out = Input_In;
            First_Attribute_Out = First_Attribute_0;
            return;
        }

        public static void HasAttributes(n6.XElement Input_In, out n6.XElement Output_Out, out bool Has_Attributes_Out)
        {
            var Has_Attributes_0 = Input_In.HasAttributes;
            Output_Out = Input_In;
            Has_Attributes_Out = Has_Attributes_0;
            return;
        }

        public static void HasElements(n6.XElement Input_In, out n6.XElement Output_Out, out bool Has_Elements_Out)
        {
            var Has_Elements_0 = Input_In.HasElements;
            Output_Out = Input_In;
            Has_Elements_Out = Has_Elements_0;
            return;
        }

        public static void IsEmpty(n6.XElement Input_In, out n6.XElement Output_Out, out bool Is_Empty_Out)
        {
            var Is_Empty_0 = Input_In.IsEmpty;
            Output_Out = Input_In;
            Is_Empty_Out = Is_Empty_0;
            return;
        }

        public static void LastAttribute(n6.XElement Input_In, out n6.XElement Output_Out, out n6.XAttribute Last_Attribute_Out)
        {
            var Last_Attribute_0 = Input_In.LastAttribute;
            Output_Out = Input_In;
            Last_Attribute_Out = Last_Attribute_0;
            return;
        }

        public static void GetValue<T, AdM>(n6.XElement Input_In, out T Value_Out, out bool Success_Out)
            where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n29.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            w_0.CreateDefault(Output_Out: out T Output_3);
            T __auto_4;
            bool __auto_5;
            if (Result_1)
            {
                n24.XmlNodes.SplitXElement(input: Input_In, name: out string Name_6, value: out string Value_7, children: out n30.Spread<n6.XElement> Children_8, attributes: out n30.Spread<n6.XAttribute> Attributes_9);
                w_0.TryParse(String_In: Value_7, Value_Out: out T Value_10, Success_Out: out bool Success_11);
                __auto_4 = Value_10;
                __auto_5 = Success_11;
            }
            else
            {
                __auto_4 = Output_3;
                __auto_5 = false;
            }

            Value_Out = __auto_4;
            Success_Out = __auto_5;
            return;
        }

        public static void GetValues<T2, T, AdM>(T2 Input_In, out n30.Spread<T> Values_Out, out n30.Spread<bool> Success_Out)
            where T2 : n14.IEnumerable<n6.XElement> where AdM : struct, n31.IAdaptiveTryParse<T>
        {
            n30.Spread<T> __cp_K893iaFaDlHM0BNgsouF7w = n47._Operations_.CreateDefault<T>();
            n30.Spread<bool> __cp_J2lS8zjfksyNuyrRtvPBG6 = n47._Operations_.CreateDefault<bool>();
            var w_0 = default(AdM);
            var builder_11 = n4.CollectionBuilders.GetBuilder(__cp_K893iaFaDlHM0BNgsouF7w, 16);
            n30.Spread<T> output_12;
            var builder_13 = n4.CollectionBuilders.GetBuilder(__cp_J2lS8zjfksyNuyrRtvPBG6, 16);
            n30.Spread<bool> output_14;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Input_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    n24.XmlNodes.SplitXElement(input: splicer_2, name: out string Name_5, value: out string Value_6, children: out n30.Spread<n6.XElement> Children_7, attributes: out n30.Spread<n6.XAttribute> Attributes_8);
                    w_0.TryParse(String_In: Value_6, Value_Out: out T Value_9, Success_Out: out bool Success_10);
                    builder_11.Add(Value_9);
                    builder_13.Add(Success_10);
                    i_3++;
                }
            }
            finally
            {
                output_12 = builder_11.Commit();
                output_14 = builder_13.Commit();
            }

            Values_Out = output_12;
            Success_Out = output_14;
            return;
        }

        public static void GetAttributeValue<T, AdM>(n6.XElement Input_In, [n4.SerializedDefaultValueAttribute("Name", false)] string Name_In, out T Value_Out, out bool Success_Out)
            where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Result_1 = string.IsNullOrWhiteSpace(value: Name_In);
            var Output_2 = !Result_1;
            w_0.CreateDefault(Output_Out: out T Output_3);
            T __auto_4;
            bool __auto_5;
            if (Output_2)
            {
                n7._Operations_.GetAttributeHelper<T, AdM>(Input_In: Input_In, Name_In: Name_In, Value_Out: out T Value_6, Success_Out: out bool Success_7);
                __auto_4 = Value_6;
                __auto_5 = Success_7;
            }
            else
            {
                __auto_4 = Output_3;
                __auto_5 = false;
            }

            Value_Out = __auto_4;
            Success_Out = __auto_5;
            return;
        }

        public static void GetAttributeValues<T2, T, AdM>(T2 Input_In, [n4.SerializedDefaultValueAttribute("Name", false)] string Name_In, out n30.Spread<T> Values_Out, out n30.Spread<bool> Success_Out)
            where T2 : n14.IEnumerable<n6.XElement> where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Result_1 = string.IsNullOrWhiteSpace(value: Name_In);
            var Output_2 = !Result_1;
            var Empty_3 = n47._Operations_.CreateDefault<T>();
            n30.Spread<T> __auto_4;
            n30.Spread<bool> __auto_5;
            if (Output_2)
            {
                n30.Spread<T> __cp_HdOJWVnOAL3O9nQIh2LmW4 = n47._Operations_.CreateDefault<T>();
                n30.Spread<bool> __cp_G1NoSvv4zPRL7CMvDDjNCT = n47._Operations_.CreateDefault<bool>();
                var builder_12 = n4.CollectionBuilders.GetBuilder(__cp_HdOJWVnOAL3O9nQIh2LmW4, 16);
                n30.Spread<T> output_13;
                var builder_14 = n4.CollectionBuilders.GetBuilder(__cp_G1NoSvv4zPRL7CMvDDjNCT, 16);
                n30.Spread<bool> output_15;
                try
                {
                    var i_8 = 0;
                    foreach (var item_6 in Input_In)
                    {
                        var splicer_7 = item_6;
                        var i_local_9 = i_8;
                        n7._Operations_.GetAttributeHelper<T, AdM>(Input_In: splicer_7, Name_In: Name_In, Value_Out: out T Value_10, Success_Out: out bool Success_11);
                        builder_12.Add(Value_10);
                        builder_14.Add(Success_11);
                        i_8++;
                    }
                }
                finally
                {
                    output_13 = builder_12.Commit();
                    output_15 = builder_14.Commit();
                }

                __auto_4 = output_13;
                __auto_5 = output_15;
            }
            else
            {
                __auto_4 = Empty_3;
                __auto_5 = n47._Operations_.CreateDefault<bool>();
            }

            Values_Out = __auto_4;
            Success_Out = __auto_5;
            return;
        }

        public static void GetAttributeHelper<T, AdM>(n6.XElement Input_In, [n4.SerializedDefaultValueAttribute("Name", false)] string Name_In, out T Value_Out, out bool Success_Out)
            where AdM : struct, n31.IAdaptiveTryParse<T>, n32.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n29.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            w_0.CreateDefault(Output_Out: out T Output_3);
            T __auto_4;
            bool __auto_5;
            if (Result_1)
            {
                var Result_6 = n24.XmlNodes.XAttributeByName(input: Input_In, name: Name_In);
                n29.ObjectHelpers.IsAssigned(x: Result_6, result: out bool Result_7, notAssigned: out bool Not_Assigned_8);
                w_0.CreateDefault(Output_Out: out T Output_9);
                T __auto_10;
                bool __auto_11;
                if (Result_7)
                {
                    n24.XmlNodes.SplitXAttribute(input: Result_6, name: out string Name_12, value: out string Value_13);
                    w_0.TryParse(String_In: Value_13, Value_Out: out T Value_14, Success_Out: out bool Success_15);
                    __auto_10 = Value_14;
                    __auto_11 = Success_15;
                }
                else
                {
                    __auto_10 = Output_9;
                    __auto_11 = false;
                }

                __auto_4 = __auto_10;
                __auto_5 = __auto_11;
            }
            else
            {
                __auto_4 = Output_3;
                __auto_5 = false;
            }

            Value_Out = __auto_4;
            Success_Out = __auto_5;
            return;
        }

        [n1.ElementAttribute(TracingId = 211986U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "TkUy26SXJazM4nS5BSJsI2", Name = "__slot_TkUy26SXJazM4nS5BSJsI2")]
        public static string __slot_TkUy26SXJazM4nS5BSJsI2 = "Default";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.XNode
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.XElement CreateDefault()
        {
            string __pad_DSBhiW5PFw4LdZurAzvCrw_0 = __slot_DSBhiW5PFw4LdZurAzvCrw;
            var Result_1 = (n6.XName)__pad_DSBhiW5PFw4LdZurAzvCrw_0;
            var Output_2 = new n6.XElement(name: Result_1);
            return Output_2;
        }

        [n1.ElementAttribute(TracingId = 212672U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "DSBhiW5PFw4LdZurAzvCrw", Name = "__slot_DSBhiW5PFw4LdZurAzvCrw")]
        public static string __slot_DSBhiW5PFw4LdZurAzvCrw = "Default";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Xml_.System.XML.Advanced
{
    [n1.ElementAttribute(TracingId = 215329U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "OPrbd3hV1yTQAohaXbZTAZ", Name = "XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ")]
    [n2.SerializableAttribute]
    public class XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ CreateDefault()
        {
            var instance = new XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ Update(n11.Path File_Path_In, bool Read_In, out n6.XDocument Output_Out)
        {
            n19.FileMode File_Mode_0 = __c_SE4KPXcccAYLMl0ZawNGv9;
            n19.FileAccess File_Access_1 = __c_HOgvAidYbnSMdA7BCULtKQ;
            n19.FileShare File_Share_2 = __c_Ecmv7TTkvfVOq0ndRlDOL7;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_FbyomPcKlTEOEL2pGZgNkz;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n23.XDocumentReader Input__this__5 = this.__p_S8GpRP5DLX2MNGU0ooFGRI;
            var Result_6 = Input__this__5.Update(input: Result_4, read: Read_In);
            Output_Out = Result_6;
            n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Input_3 != this.__p_FbyomPcKlTEOEL2pGZgNkz || Input__this__5 != this.__p_S8GpRP5DLX2MNGU0ooFGRI ? new XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(this)
                {__p_FbyomPcKlTEOEL2pGZgNkz = Input_3, __p_S8GpRP5DLX2MNGU0ooFGRI = Input__this__5} : that_7;
            else
            {
                this.__p_FbyomPcKlTEOEL2pGZgNkz = Input_3;
                this.__p_S8GpRP5DLX2MNGU0ooFGRI = Input__this__5;
            }

            return that_7;
        }

        public n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "S8GpRP5DLX2MNGU0ooFGRI", 215339U);
            n49._Operations_.Create(Node_Context_In: Node_Context_0, Output_Out: out n23.XDocumentReader Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "FbyomPcKlTEOEL2pGZgNkz", 215351U);
            n27.IFrameClock Clock_3 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_2, Clock_In: Clock_3, Output_Out: out n22.ObsoleteFileNoSharing Output_4);
            n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ that_5 = this;
            this.__p_S8GpRP5DLX2MNGU0ooFGRI = Output_1;
            this.__p_FbyomPcKlTEOEL2pGZgNkz = Output_4;
            return that_5;
        }

        public n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __CreateDefault__()
        {
            n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ that_0 = this;
            this.__p_FbyomPcKlTEOEL2pGZgNkz = default(n22.ObsoleteFileNoSharing);
            this.__p_S8GpRP5DLX2MNGU0ooFGRI = default(n23.XDocumentReader);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FbyomPcKlTEOEL2pGZgNkz);
            n1.CompilationHelper.SafeDispose(this.__p_S8GpRP5DLX2MNGU0ooFGRI);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 215371U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HIbBGpKGNoSLpit5WX7dJ8", Name = "__slot_HIbBGpKGNoSLpit5WX7dJ8")]
        public static string __slot_HIbBGpKGNoSLpit5WX7dJ8 = "Special XML reader to avoid string allocation";
        [n1.ElementAttribute(TracingId = 215351U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "FbyomPcKlTEOEL2pGZgNkz", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_FbyomPcKlTEOEL2pGZgNkz;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileMode __c_SE4KPXcccAYLMl0ZawNGv9 = n1.CompilationHelper.Deserialize<n19.FileMode>("Open", false, "Q2iWAXgl3GDPCvxD5IfFJH", "SE4KPXcccAYLMl0ZawNGv9");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileAccess __c_HOgvAidYbnSMdA7BCULtKQ = n1.CompilationHelper.Deserialize<n19.FileAccess>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "HOgvAidYbnSMdA7BCULtKQ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_Ecmv7TTkvfVOq0ndRlDOL7 = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "Ecmv7TTkvfVOq0ndRlDOL7");
        [n1.ElementAttribute(TracingId = 215339U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "S8GpRP5DLX2MNGU0ooFGRI", Name = "XDocumentReader", IsManaged = true, IsAutoGenerated = true)]
        public n23.XDocumentReader __p_S8GpRP5DLX2MNGU0ooFGRI;
        static XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ()
        {
        }

        public XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ other): base(other)
        {
            this.__p_FbyomPcKlTEOEL2pGZgNkz = other.__p_FbyomPcKlTEOEL2pGZgNkz;
            this.__p_S8GpRP5DLX2MNGU0ooFGRI = other.__p_S8GpRP5DLX2MNGU0ooFGRI;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FbyomPcKlTEOEL2pGZgNkz", in __p_FbyomPcKlTEOEL2pGZgNkz), n1.CompilationHelper.GetValueOrExisting(values, "__p_S8GpRP5DLX2MNGU0ooFGRI", in __p_S8GpRP5DLX2MNGU0ooFGRI));
        }

        internal XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ __WITH__(n22.ObsoleteFileNoSharing __p_FbyomPcKlTEOEL2pGZgNkz, n23.XDocumentReader __p_S8GpRP5DLX2MNGU0ooFGRI)
        {
            n37.XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FbyomPcKlTEOEL2pGZgNkz != this.__p_FbyomPcKlTEOEL2pGZgNkz || __p_S8GpRP5DLX2MNGU0ooFGRI != this.__p_S8GpRP5DLX2MNGU0ooFGRI ? new XMLReader_XDocument_OPrbd3hV1yTQAohaXbZTAZ(this)
                {__p_FbyomPcKlTEOEL2pGZgNkz = __p_FbyomPcKlTEOEL2pGZgNkz, __p_S8GpRP5DLX2MNGU0ooFGRI = __p_S8GpRP5DLX2MNGU0ooFGRI} : that_0;
            else
            {
                this.__p_FbyomPcKlTEOEL2pGZgNkz = __p_FbyomPcKlTEOEL2pGZgNkz;
                this.__p_S8GpRP5DLX2MNGU0ooFGRI = __p_S8GpRP5DLX2MNGU0ooFGRI;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 215421U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "PVpTLN2ieLzPuDrY7SZ3Tv", Name = "XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv")]
    [n2.SerializableAttribute]
    public class XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv CreateDefault()
        {
            var instance = new XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv Update(n11.Path File_Path_In, n6.XDocument Data_In, bool Write_In)
        {
            n19.FileMode File_Mode_0 = __c_VOGPzM4VE4LQTXqUoXP73j;
            n19.FileAccess File_Access_1 = __c_OjhplqEPb4HNbco2Dkqc5O;
            n19.FileShare File_Share_2 = __c_FV8Or8g8nZ7OuhdhtpjcoA;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_Rd2uRGI8HZBMBqoU3vGPSy;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            bool Update_5 = true;
            var Output_6 = this.__p_LPFvT2UQHUPLb69Ks6RO9e;
            if (Update_5)
            {
                n23.XDocumentWriter Input__this__7 = this.__p_LPFvT2UQHUPLb69Ks6RO9e;
                Input__this__7.Update(input: Result_4, data: Data_In, write: Write_In);
                Output_6 = Input__this__7;
            }

            n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Input_3 != this.__p_Rd2uRGI8HZBMBqoU3vGPSy || Output_6 != this.__p_LPFvT2UQHUPLb69Ks6RO9e ? new XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(this)
                {__p_Rd2uRGI8HZBMBqoU3vGPSy = Input_3, __p_LPFvT2UQHUPLb69Ks6RO9e = Output_6} : that_8;
            else
            {
                this.__p_Rd2uRGI8HZBMBqoU3vGPSy = Input_3;
                this.__p_LPFvT2UQHUPLb69Ks6RO9e = Output_6;
            }

            return that_8;
        }

        public n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Rd2uRGI8HZBMBqoU3vGPSy", 215431U);
            n27.IFrameClock Clock_1 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n22.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "LPFvT2UQHUPLb69Ks6RO9e", 215464U);
            n50._Operations_.Create(Node_Context_In: Node_Context_3, Output_Out: out n23.XDocumentWriter Output_4);
            n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv that_5 = this;
            this.__p_Rd2uRGI8HZBMBqoU3vGPSy = Output_2;
            this.__p_LPFvT2UQHUPLb69Ks6RO9e = Output_4;
            return that_5;
        }

        public n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __CreateDefault__()
        {
            n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv that_0 = this;
            this.__p_Rd2uRGI8HZBMBqoU3vGPSy = default(n22.ObsoleteFileNoSharing);
            this.__p_LPFvT2UQHUPLb69Ks6RO9e = default(n23.XDocumentWriter);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Rd2uRGI8HZBMBqoU3vGPSy);
            n1.CompilationHelper.SafeDispose(this.__p_LPFvT2UQHUPLb69Ks6RO9e);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 215484U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "LrFd0NWOWpqL5lvwQnqCjr", Name = "__slot_LrFd0NWOWpqL5lvwQnqCjr")]
        public static string __slot_LrFd0NWOWpqL5lvwQnqCjr = "Special XML writer to avoid string allocation";
        [n1.ElementAttribute(TracingId = 215431U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Rd2uRGI8HZBMBqoU3vGPSy", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_Rd2uRGI8HZBMBqoU3vGPSy;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileMode __c_VOGPzM4VE4LQTXqUoXP73j = n1.CompilationHelper.Deserialize<n19.FileMode>("Create", false, "Q2iWAXgl3GDPCvxD5IfFJH", "VOGPzM4VE4LQTXqUoXP73j");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileAccess __c_OjhplqEPb4HNbco2Dkqc5O = n1.CompilationHelper.Deserialize<n19.FileAccess>("Write", false, "Q2iWAXgl3GDPCvxD5IfFJH", "OjhplqEPb4HNbco2Dkqc5O");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_FV8Or8g8nZ7OuhdhtpjcoA = n1.CompilationHelper.Deserialize<n19.FileShare>("None", false, "Q2iWAXgl3GDPCvxD5IfFJH", "FV8Or8g8nZ7OuhdhtpjcoA");
        [n1.ElementAttribute(TracingId = 215464U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "LPFvT2UQHUPLb69Ks6RO9e", Name = "XDocumentWriter", IsManaged = true, IsAutoGenerated = true)]
        public n23.XDocumentWriter __p_LPFvT2UQHUPLb69Ks6RO9e;
        static XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv()
        {
        }

        public XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv other): base(other)
        {
            this.__p_Rd2uRGI8HZBMBqoU3vGPSy = other.__p_Rd2uRGI8HZBMBqoU3vGPSy;
            this.__p_LPFvT2UQHUPLb69Ks6RO9e = other.__p_LPFvT2UQHUPLb69Ks6RO9e;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Rd2uRGI8HZBMBqoU3vGPSy", in __p_Rd2uRGI8HZBMBqoU3vGPSy), n1.CompilationHelper.GetValueOrExisting(values, "__p_LPFvT2UQHUPLb69Ks6RO9e", in __p_LPFvT2UQHUPLb69Ks6RO9e));
        }

        internal XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv __WITH__(n22.ObsoleteFileNoSharing __p_Rd2uRGI8HZBMBqoU3vGPSy, n23.XDocumentWriter __p_LPFvT2UQHUPLb69Ks6RO9e)
        {
            n37.XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Rd2uRGI8HZBMBqoU3vGPSy != this.__p_Rd2uRGI8HZBMBqoU3vGPSy || __p_LPFvT2UQHUPLb69Ks6RO9e != this.__p_LPFvT2UQHUPLb69Ks6RO9e ? new XMLWriter_XDocument_PVpTLN2ieLzPuDrY7SZ3Tv(this)
                {__p_Rd2uRGI8HZBMBqoU3vGPSy = __p_Rd2uRGI8HZBMBqoU3vGPSy, __p_LPFvT2UQHUPLb69Ks6RO9e = __p_LPFvT2UQHUPLb69Ks6RO9e} : that_0;
            else
            {
                this.__p_Rd2uRGI8HZBMBqoU3vGPSy = __p_Rd2uRGI8HZBMBqoU3vGPSy;
                this.__p_LPFvT2UQHUPLb69Ks6RO9e = __p_LPFvT2UQHUPLb69Ks6RO9e;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 215532U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "SYtLNqgLVojLPTlgG6zowT", Name = "XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT")]
    [n2.SerializableAttribute]
    public class XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT CreateDefault()
        {
            var instance = new XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT Update(n11.Path File_Path_In, bool Read_In, out n2.IObservable<n6.XDocument> Output_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            n19.FileMode File_Mode_0 = __c_He6sJXqziigLG7WuTAvKId;
            n19.FileAccess File_Access_1 = __c_MrmAcD2ZqefPEk1xGKQMwZ;
            n19.FileShare File_Share_2 = __c_AHHsrzC0TZHNNzh7gNRz7I;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_UM6iE7AcJmoPLq7V4o1FGi;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n51._Operations_.Update_H<n34.IResourceProvider<n19.Stream>>(Input_In: this.__p_T2hMvxNMYDfMLjv6fzOUb0, Message_In: Result_4, Send_In: Read_In, Output_Out: out n21.ToObservable<n34.IResourceProvider<n19.Stream>> Output_5, Result_Out: out n2.IObservable<n34.IResourceProvider<n19.Stream>> Result_6);
            n23.AsyncXDocumentReader Input__this__7 = this.__p_D3s7UAYpm5wPrt0NlGwNU7;
            var Result_10 = Input__this__7.Update(input: Result_6, inProgress: out bool In_Progress_8, onCompleted: out bool On_Completed_9);
            bool Reset_11 = false;
            n41._Operations_.Update_H<n6.XDocument>(Input__this__In: this.__p_HBcXOYi9w27LVOzshgeBu7, Input_In: Result_10, Reset_In: Reset_11, Output_Out: out n21.DebugNode<n6.XDocument> Output_12, Result_Out: out n2.IObservable<n6.XDocument> Result_13, Input_Changed_Count_Out: out int Input_Changed_Count_14, Subscribe_Calls_Out: out int Subscribe_Calls_15, On_Next_Calls_Out: out int On_Next_Calls_16, On_Error_Calls_Out: out int On_Error_Calls_17, On_Completed_Calls_Out: out int On_Completed_Calls_18, Unsubscribe_Calls_Out: out int Unsubscribe_Calls_19, Latest_Thread_Id_Out: out int Latest_Thread_Id_20);
            Output_Out = Result_13;
            In_Progress_Out = In_Progress_8;
            On_Completed_Out = On_Completed_9;
            n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = Input_3 != this.__p_UM6iE7AcJmoPLq7V4o1FGi || Output_5 != this.__p_T2hMvxNMYDfMLjv6fzOUb0 || Input__this__7 != this.__p_D3s7UAYpm5wPrt0NlGwNU7 || Output_12 != this.__p_HBcXOYi9w27LVOzshgeBu7 ? new XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(this)
                {__p_UM6iE7AcJmoPLq7V4o1FGi = Input_3, __p_T2hMvxNMYDfMLjv6fzOUb0 = Output_5, __p_D3s7UAYpm5wPrt0NlGwNU7 = Input__this__7, __p_HBcXOYi9w27LVOzshgeBu7 = Output_12} : that_21;
            else
            {
                this.__p_UM6iE7AcJmoPLq7V4o1FGi = Input_3;
                this.__p_T2hMvxNMYDfMLjv6fzOUb0 = Output_5;
                this.__p_D3s7UAYpm5wPrt0NlGwNU7 = Input__this__7;
                this.__p_HBcXOYi9w27LVOzshgeBu7 = Output_12;
            }

            return that_21;
        }

        public n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "UM6iE7AcJmoPLq7V4o1FGi", 215546U);
            n27.IFrameClock Clock_1 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n22.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "T2hMvxNMYDfMLjv6fzOUb0", 215585U);
            n51._Operations_.Create_H<n34.IResourceProvider<n19.Stream>>(Node_Context: Node_Context_3, Output_Out: out n21.ToObservable<n34.IResourceProvider<n19.Stream>> Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "D3s7UAYpm5wPrt0NlGwNU7", 215596U);
            n52._Operations_.Create_H(Node_Context_In: Node_Context_5, Output_Out: out n23.AsyncXDocumentReader Output_6);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "HBcXOYi9w27LVOzshgeBu7", 215617U);
            n41._Operations_.Create_H<n6.XDocument>(Node_Context: Node_Context_7, Output_Out: out n21.DebugNode<n6.XDocument> Output_8);
            n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT that_9 = this;
            this.__p_UM6iE7AcJmoPLq7V4o1FGi = Output_2;
            this.__p_T2hMvxNMYDfMLjv6fzOUb0 = Output_4;
            this.__p_D3s7UAYpm5wPrt0NlGwNU7 = Output_6;
            this.__p_HBcXOYi9w27LVOzshgeBu7 = Output_8;
            return that_9;
        }

        public n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT __CreateDefault__()
        {
            n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT that_0 = this;
            this.__p_UM6iE7AcJmoPLq7V4o1FGi = default(n22.ObsoleteFileNoSharing);
            this.__p_T2hMvxNMYDfMLjv6fzOUb0 = default(n21.ToObservable<n34.IResourceProvider<n19.Stream>>);
            this.__p_D3s7UAYpm5wPrt0NlGwNU7 = default(n23.AsyncXDocumentReader);
            this.__p_HBcXOYi9w27LVOzshgeBu7 = default(n21.DebugNode<n6.XDocument>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UM6iE7AcJmoPLq7V4o1FGi);
            n1.CompilationHelper.SafeDispose(this.__p_T2hMvxNMYDfMLjv6fzOUb0);
            n1.CompilationHelper.SafeDispose(this.__p_D3s7UAYpm5wPrt0NlGwNU7);
            n1.CompilationHelper.SafeDispose(this.__p_HBcXOYi9w27LVOzshgeBu7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 215568U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "IZ8MFnX1J5xQO313breVWw", Name = "__slot_IZ8MFnX1J5xQO313breVWw")]
        public static string __slot_IZ8MFnX1J5xQO313breVWw = "Special XML reader to avoid string allocation";
        [n1.ElementAttribute(TracingId = 215574U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HSeSeuJb1tRPPtvXyHXi1H", Name = "__slot_HSeSeuJb1tRPPtvXyHXi1H")]
        public static string __slot_HSeSeuJb1tRPPtvXyHXi1H = "In future versions of .NET there should be a XDocument.LoadAsync method\r\nso it will be possible to provide cancellation, but not progress.";
        [n1.ElementAttribute(TracingId = 215546U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "UM6iE7AcJmoPLq7V4o1FGi", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_UM6iE7AcJmoPLq7V4o1FGi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileMode __c_He6sJXqziigLG7WuTAvKId = n1.CompilationHelper.Deserialize<n19.FileMode>("Open", false, "Q2iWAXgl3GDPCvxD5IfFJH", "He6sJXqziigLG7WuTAvKId");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileAccess __c_MrmAcD2ZqefPEk1xGKQMwZ = n1.CompilationHelper.Deserialize<n19.FileAccess>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "MrmAcD2ZqefPEk1xGKQMwZ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_AHHsrzC0TZHNNzh7gNRz7I = n1.CompilationHelper.Deserialize<n19.FileShare>("Read", false, "Q2iWAXgl3GDPCvxD5IfFJH", "AHHsrzC0TZHNNzh7gNRz7I");
        [n1.ElementAttribute(TracingId = 215585U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "T2hMvxNMYDfMLjv6fzOUb0", Name = "ToObservable", IsManaged = true, IsAutoGenerated = true)]
        public n21.ToObservable<n34.IResourceProvider<n19.Stream>> __p_T2hMvxNMYDfMLjv6fzOUb0;
        [n1.ElementAttribute(TracingId = 215596U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "D3s7UAYpm5wPrt0NlGwNU7", Name = "XDocumentReader (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n23.AsyncXDocumentReader __p_D3s7UAYpm5wPrt0NlGwNU7;
        [n1.ElementAttribute(TracingId = 215617U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "HBcXOYi9w27LVOzshgeBu7", Name = "Debug", IsManaged = true, IsAutoGenerated = true)]
        public n21.DebugNode<n6.XDocument> __p_HBcXOYi9w27LVOzshgeBu7;
        static XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT()
        {
        }

        public XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT other): base(other)
        {
            this.__p_UM6iE7AcJmoPLq7V4o1FGi = other.__p_UM6iE7AcJmoPLq7V4o1FGi;
            this.__p_T2hMvxNMYDfMLjv6fzOUb0 = other.__p_T2hMvxNMYDfMLjv6fzOUb0;
            this.__p_D3s7UAYpm5wPrt0NlGwNU7 = other.__p_D3s7UAYpm5wPrt0NlGwNU7;
            this.__p_HBcXOYi9w27LVOzshgeBu7 = other.__p_HBcXOYi9w27LVOzshgeBu7;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UM6iE7AcJmoPLq7V4o1FGi", in __p_UM6iE7AcJmoPLq7V4o1FGi), n1.CompilationHelper.GetValueOrExisting(values, "__p_T2hMvxNMYDfMLjv6fzOUb0", in __p_T2hMvxNMYDfMLjv6fzOUb0), n1.CompilationHelper.GetValueOrExisting(values, "__p_D3s7UAYpm5wPrt0NlGwNU7", in __p_D3s7UAYpm5wPrt0NlGwNU7), n1.CompilationHelper.GetValueOrExisting(values, "__p_HBcXOYi9w27LVOzshgeBu7", in __p_HBcXOYi9w27LVOzshgeBu7));
        }

        internal XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT __WITH__(n22.ObsoleteFileNoSharing __p_UM6iE7AcJmoPLq7V4o1FGi, n21.ToObservable<n34.IResourceProvider<n19.Stream>> __p_T2hMvxNMYDfMLjv6fzOUb0, n23.AsyncXDocumentReader __p_D3s7UAYpm5wPrt0NlGwNU7, n21.DebugNode<n6.XDocument> __p_HBcXOYi9w27LVOzshgeBu7)
        {
            n37.XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UM6iE7AcJmoPLq7V4o1FGi != this.__p_UM6iE7AcJmoPLq7V4o1FGi || __p_T2hMvxNMYDfMLjv6fzOUb0 != this.__p_T2hMvxNMYDfMLjv6fzOUb0 || __p_D3s7UAYpm5wPrt0NlGwNU7 != this.__p_D3s7UAYpm5wPrt0NlGwNU7 || __p_HBcXOYi9w27LVOzshgeBu7 != this.__p_HBcXOYi9w27LVOzshgeBu7 ? new XMLReader_XDocument_Reactive_SYtLNqgLVojLPTlgG6zowT(this)
                {__p_UM6iE7AcJmoPLq7V4o1FGi = __p_UM6iE7AcJmoPLq7V4o1FGi, __p_T2hMvxNMYDfMLjv6fzOUb0 = __p_T2hMvxNMYDfMLjv6fzOUb0, __p_D3s7UAYpm5wPrt0NlGwNU7 = __p_D3s7UAYpm5wPrt0NlGwNU7, __p_HBcXOYi9w27LVOzshgeBu7 = __p_HBcXOYi9w27LVOzshgeBu7} : that_0;
            else
            {
                this.__p_UM6iE7AcJmoPLq7V4o1FGi = __p_UM6iE7AcJmoPLq7V4o1FGi;
                this.__p_T2hMvxNMYDfMLjv6fzOUb0 = __p_T2hMvxNMYDfMLjv6fzOUb0;
                this.__p_D3s7UAYpm5wPrt0NlGwNU7 = __p_D3s7UAYpm5wPrt0NlGwNU7;
                this.__p_HBcXOYi9w27LVOzshgeBu7 = __p_HBcXOYi9w27LVOzshgeBu7;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 215708U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Jn58QSZGMUmNfBVEabutgv", Name = "XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv")]
    [n2.SerializableAttribute]
    public class XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv Create(n1.NodeContext Node_Context)
        {
            var instance = new XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv CreateDefault()
        {
            var instance = new XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv Update(n11.Path File_Path_In, n2.IObservable<n6.XDocument> Data_In, out bool In_Progress_Out, out bool OnCompleted_Out)
        {
            n19.FileMode File_Mode_0 = __c_AnrUa0sk304PFYJQLFkSYZ;
            n19.FileAccess File_Access_1 = __c_N8aEUWbt25WNSqnUIQK0dL;
            n19.FileShare File_Share_2 = __c_EhBrzKkr9J6LSf3voOnRmR;
            n22.ObsoleteFileNoSharing Input_3 = this.__p_UiGYRTTXA5kLSHTPpExuqw;
            var Result_4 = Input_3.Update(filePath: File_Path_In, fileMode: File_Mode_0, fileAccess: File_Access_1, fileShare: File_Share_2);
            n23.AsyncXDocumentWriter Input__this__5 = this.__p_MXtQwSioOvKOCQWYHu6nVT;
            var Result_8 = Input__this__5.Update(input: Result_4, data: Data_In, inProgress: out bool In_Progress_6, onCompleted: out bool On_Completed_7);
            bool Update_9 = true;
            var Output_10 = this.__p_Ht9RZRfgSKFOwVw3w6ffkZ;
            if (Update_9)
            {
                Output_10 = this.__p_Ht9RZRfgSKFOwVw3w6ffkZ.Update(Input_In: Result_8);
            }

            In_Progress_Out = In_Progress_6;
            OnCompleted_Out = On_Completed_7;
            n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = Input_3 != this.__p_UiGYRTTXA5kLSHTPpExuqw || Input__this__5 != this.__p_MXtQwSioOvKOCQWYHu6nVT || Output_10 != this.__p_Ht9RZRfgSKFOwVw3w6ffkZ ? new XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(this)
                {__p_UiGYRTTXA5kLSHTPpExuqw = Input_3, __p_MXtQwSioOvKOCQWYHu6nVT = Input__this__5, __p_Ht9RZRfgSKFOwVw3w6ffkZ = Output_10} : that_11;
            else
            {
                this.__p_UiGYRTTXA5kLSHTPpExuqw = Input_3;
                this.__p_MXtQwSioOvKOCQWYHu6nVT = Input__this__5;
                this.__p_Ht9RZRfgSKFOwVw3w6ffkZ = Output_10;
            }

            return that_11;
        }

        public n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "UiGYRTTXA5kLSHTPpExuqw", 215719U);
            n27.IFrameClock Clock_1 = n26._Operations_.CreateDefault();
            n28._Operations_.Create_H(Node_Context: Node_Context_0, Clock_In: Clock_1, Output_Out: out n22.ObsoleteFileNoSharing Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "MXtQwSioOvKOCQWYHu6nVT", 215737U);
            n53._Operations_.Create_H(Node_Context_In: Node_Context_3, Output_Out: out n23.AsyncXDocumentWriter Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Ht9RZRfgSKFOwVw3w6ffkZ", 215773U);
            var Output_6 = n54.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n6.XDocument>, n6.XDocument>.Create(Node_Context: Node_Context_5);
            n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv that_7 = this;
            this.__p_UiGYRTTXA5kLSHTPpExuqw = Output_2;
            this.__p_MXtQwSioOvKOCQWYHu6nVT = Output_4;
            this.__p_Ht9RZRfgSKFOwVw3w6ffkZ = Output_6;
            return that_7;
        }

        public n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv __CreateDefault__()
        {
            n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv that_0 = this;
            this.__p_UiGYRTTXA5kLSHTPpExuqw = default(n22.ObsoleteFileNoSharing);
            this.__p_MXtQwSioOvKOCQWYHu6nVT = default(n23.AsyncXDocumentWriter);
            this.__p_Ht9RZRfgSKFOwVw3w6ffkZ = n54.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n6.XDocument>, n6.XDocument>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UiGYRTTXA5kLSHTPpExuqw);
            n1.CompilationHelper.SafeDispose(this.__p_MXtQwSioOvKOCQWYHu6nVT);
            n1.CompilationHelper.SafeDispose(this.__p_Ht9RZRfgSKFOwVw3w6ffkZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 215756U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "KbTZ57zKQgBPK3qDiRyDi7", Name = "__slot_KbTZ57zKQgBPK3qDiRyDi7")]
        public static string __slot_KbTZ57zKQgBPK3qDiRyDi7 = "Special XML writer to avoid string allocation";
        [n1.ElementAttribute(TracingId = 215763U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Ofazlx4r1beLfc1C5TKBrP", Name = "__slot_Ofazlx4r1beLfc1C5TKBrP")]
        public static string __slot_Ofazlx4r1beLfc1C5TKBrP = "In future versions of .NET there should be a XDocument.SaveAsync method\r\nso it will be possible to provide cancellation, but not progress.";
        [n1.ElementAttribute(TracingId = 215719U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "UiGYRTTXA5kLSHTPpExuqw", Name = "File (NoSharing 1)", IsManaged = true, IsAutoGenerated = true)]
        public n22.ObsoleteFileNoSharing __p_UiGYRTTXA5kLSHTPpExuqw;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileMode __c_AnrUa0sk304PFYJQLFkSYZ = n1.CompilationHelper.Deserialize<n19.FileMode>("Create", false, "Q2iWAXgl3GDPCvxD5IfFJH", "AnrUa0sk304PFYJQLFkSYZ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileAccess __c_N8aEUWbt25WNSqnUIQK0dL = n1.CompilationHelper.Deserialize<n19.FileAccess>("Write", false, "Q2iWAXgl3GDPCvxD5IfFJH", "N8aEUWbt25WNSqnUIQK0dL");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.FileShare __c_EhBrzKkr9J6LSf3voOnRmR = n1.CompilationHelper.Deserialize<n19.FileShare>("None", false, "Q2iWAXgl3GDPCvxD5IfFJH", "EhBrzKkr9J6LSf3voOnRmR");
        [n1.ElementAttribute(TracingId = 215737U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "MXtQwSioOvKOCQWYHu6nVT", Name = "XDocumentWriter (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n23.AsyncXDocumentWriter __p_MXtQwSioOvKOCQWYHu6nVT;
        [n1.ElementAttribute(TracingId = 215773U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Ht9RZRfgSKFOwVw3w6ffkZ", Name = "Subscribe", IsManaged = true, IsAutoGenerated = true)]
        public n54.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n6.XDocument>, n6.XDocument> __p_Ht9RZRfgSKFOwVw3w6ffkZ;
        static XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv()
        {
        }

        public XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv other): base(other)
        {
            this.__p_UiGYRTTXA5kLSHTPpExuqw = other.__p_UiGYRTTXA5kLSHTPpExuqw;
            this.__p_MXtQwSioOvKOCQWYHu6nVT = other.__p_MXtQwSioOvKOCQWYHu6nVT;
            this.__p_Ht9RZRfgSKFOwVw3w6ffkZ = other.__p_Ht9RZRfgSKFOwVw3w6ffkZ;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UiGYRTTXA5kLSHTPpExuqw", in __p_UiGYRTTXA5kLSHTPpExuqw), n1.CompilationHelper.GetValueOrExisting(values, "__p_MXtQwSioOvKOCQWYHu6nVT", in __p_MXtQwSioOvKOCQWYHu6nVT), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ht9RZRfgSKFOwVw3w6ffkZ", in __p_Ht9RZRfgSKFOwVw3w6ffkZ));
        }

        internal XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv __WITH__(n22.ObsoleteFileNoSharing __p_UiGYRTTXA5kLSHTPpExuqw, n23.AsyncXDocumentWriter __p_MXtQwSioOvKOCQWYHu6nVT, n54.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<n2.IObservable<n6.XDocument>, n6.XDocument> __p_Ht9RZRfgSKFOwVw3w6ffkZ)
        {
            n37.XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UiGYRTTXA5kLSHTPpExuqw != this.__p_UiGYRTTXA5kLSHTPpExuqw || __p_MXtQwSioOvKOCQWYHu6nVT != this.__p_MXtQwSioOvKOCQWYHu6nVT || __p_Ht9RZRfgSKFOwVw3w6ffkZ != this.__p_Ht9RZRfgSKFOwVw3w6ffkZ ? new XMLWriter_XDocument_Reactive_Jn58QSZGMUmNfBVEabutgv(this)
                {__p_UiGYRTTXA5kLSHTPpExuqw = __p_UiGYRTTXA5kLSHTPpExuqw, __p_MXtQwSioOvKOCQWYHu6nVT = __p_MXtQwSioOvKOCQWYHu6nVT, __p_Ht9RZRfgSKFOwVw3w6ffkZ = __p_Ht9RZRfgSKFOwVw3w6ffkZ} : that_0;
            else
            {
                this.__p_UiGYRTTXA5kLSHTPpExuqw = __p_UiGYRTTXA5kLSHTPpExuqw;
                this.__p_MXtQwSioOvKOCQWYHu6nVT = __p_MXtQwSioOvKOCQWYHu6nVT;
                this.__p_Ht9RZRfgSKFOwVw3w6ffkZ = __p_Ht9RZRfgSKFOwVw3w6ffkZ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 215863U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "NbGfJLYlal5O49GfRvntMG", Name = "JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG")]
    [n2.SerializableAttribute]
    public class JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG CreateDefault()
        {
            var instance = new JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG Update(n11.Path File_Path_In, n12.Encodings Encoding_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, bool Read_In, out n6.XDocument Output_Out)
        {
            var State_Output_1 = this.__p_Um3Ok1CdjpyMSyCM5QYjoh.Update(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Read_In: Read_In, Output_Out: out string Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_EnMJIHIP5HDP5JHKBazARD;
            if (manager_3 is null)
            {
                manager_3 = new n55.Manager<n2.ValueTuple, n2.ValueTuple<n6.XDocument>>(n2.ValueTuple.Create(n5._Operations_.CreateDefault()));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Read_In || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var Result_8 = n24.XmlNodes.DeserializeXNode(json: Output_0, deserializeRootElementName: Deserialize_Root_Element_Name_In, writeArrayAttribute: Write_Array_Attribute_In);
                outputs_5 = n2.ValueTuple.Create(Result_8);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_9 = outputs_5.Item1;
            Output_Out = __auto_9;
            n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = State_Output_1 != this.__p_Um3Ok1CdjpyMSyCM5QYjoh || manager_3 != this.__cache_EnMJIHIP5HDP5JHKBazARD ? new JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(this)
                {__p_Um3Ok1CdjpyMSyCM5QYjoh = State_Output_1, __cache_EnMJIHIP5HDP5JHKBazARD = manager_3} : that_10;
            else
            {
                this.__p_Um3Ok1CdjpyMSyCM5QYjoh = State_Output_1;
                this.__cache_EnMJIHIP5HDP5JHKBazARD = manager_3;
            }

            return that_10;
        }

        public n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Um3Ok1CdjpyMSyCM5QYjoh", 215885U);
            var Output_1 = n56.FileReader_String_TT8gWSNJDrLPfzy5QjExui.Create(Node_Context: Node_Context_0);
            n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG that_2 = this;
            this.__p_Um3Ok1CdjpyMSyCM5QYjoh = Output_1;
            this.__cache_EnMJIHIP5HDP5JHKBazARD = null;
            return that_2;
        }

        public n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG __CreateDefault__()
        {
            n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG that_0 = this;
            this.__p_Um3Ok1CdjpyMSyCM5QYjoh = n56.FileReader_String_TT8gWSNJDrLPfzy5QjExui.CreateDefault();
            this.__cache_EnMJIHIP5HDP5JHKBazARD = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Um3Ok1CdjpyMSyCM5QYjoh);
            n1.CompilationHelper.SafeDispose(this.__cache_EnMJIHIP5HDP5JHKBazARD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 215885U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Um3Ok1CdjpyMSyCM5QYjoh", Name = "FileReader (String)", IsManaged = true, IsAutoGenerated = true)]
        public n56.FileReader_String_TT8gWSNJDrLPfzy5QjExui __p_Um3Ok1CdjpyMSyCM5QYjoh;
        [n1.ElementAttribute(TracingId = 215900U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "EnMJIHIP5HDP5JHKBazARD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n55.Manager<n2.ValueTuple, n2.ValueTuple<n6.XDocument>> __cache_EnMJIHIP5HDP5JHKBazARD = null;
        public JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG other): base(other)
        {
            this.__p_Um3Ok1CdjpyMSyCM5QYjoh = other.__p_Um3Ok1CdjpyMSyCM5QYjoh;
            this.__cache_EnMJIHIP5HDP5JHKBazARD = other.__cache_EnMJIHIP5HDP5JHKBazARD;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Um3Ok1CdjpyMSyCM5QYjoh", in __p_Um3Ok1CdjpyMSyCM5QYjoh), n1.CompilationHelper.GetValueOrExisting(values, "__cache_EnMJIHIP5HDP5JHKBazARD", in __cache_EnMJIHIP5HDP5JHKBazARD));
        }

        internal JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG __WITH__(n56.FileReader_String_TT8gWSNJDrLPfzy5QjExui __p_Um3Ok1CdjpyMSyCM5QYjoh, n55.Manager<n2.ValueTuple, n2.ValueTuple<n6.XDocument>> __cache_EnMJIHIP5HDP5JHKBazARD)
        {
            n37.JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Um3Ok1CdjpyMSyCM5QYjoh != this.__p_Um3Ok1CdjpyMSyCM5QYjoh || __cache_EnMJIHIP5HDP5JHKBazARD != this.__cache_EnMJIHIP5HDP5JHKBazARD ? new JSONReader_XDocument_NbGfJLYlal5O49GfRvntMG(this)
                {__p_Um3Ok1CdjpyMSyCM5QYjoh = __p_Um3Ok1CdjpyMSyCM5QYjoh, __cache_EnMJIHIP5HDP5JHKBazARD = __cache_EnMJIHIP5HDP5JHKBazARD} : that_0;
            else
            {
                this.__p_Um3Ok1CdjpyMSyCM5QYjoh = __p_Um3Ok1CdjpyMSyCM5QYjoh;
                this.__cache_EnMJIHIP5HDP5JHKBazARD = __cache_EnMJIHIP5HDP5JHKBazARD;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216025U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Rk0S9JlrxWRMdVQDEsXCS7", Name = "JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7")]
    [n2.SerializableAttribute]
    public class JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 CreateDefault()
        {
            var instance = new JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 Update(n11.Path File_Path_In, n6.XNode Data_In, n12.Encodings Encoding_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Indent_In, bool Omit_Root_Object_In, bool Write_In)
        {
            string __auto_0;
            if (Write_In)
            {
                var Result_2 = n24.XmlNodes.SerializeXNode(input: Data_In, indent: Indent_In, omitRootObject: Omit_Root_Object_In);
                __auto_0 = Result_2;
            }
            else
            {
                __auto_0 = "";
            }

            bool Append_3 = false;
            bool Update_4 = true;
            var Output_5 = this.__p_IxYbIrXUJ6jOTkCB1is6Jg;
            if (Update_4)
            {
                Output_5 = this.__p_IxYbIrXUJ6jOTkCB1is6Jg.Update(File_Path_In: File_Path_In, Data_In: __auto_0, Encoding_In: Encoding_In, Append_In: Append_3, Write_In: Write_In);
            }

            n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_5 != this.__p_IxYbIrXUJ6jOTkCB1is6Jg ? new JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(this)
                {__p_IxYbIrXUJ6jOTkCB1is6Jg = Output_5} : that_6;
            else
            {
                this.__p_IxYbIrXUJ6jOTkCB1is6Jg = Output_5;
            }

            return that_6;
        }

        public n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "IxYbIrXUJ6jOTkCB1is6Jg", 216045U);
            var Output_1 = n56.FileWriter_String_RhzHb4NoVZQP8wGq101JDK.Create(Node_Context: Node_Context_0);
            n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 that_2 = this;
            this.__p_IxYbIrXUJ6jOTkCB1is6Jg = Output_1;
            return that_2;
        }

        public n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 __CreateDefault__()
        {
            n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 that_0 = this;
            this.__p_IxYbIrXUJ6jOTkCB1is6Jg = n56.FileWriter_String_RhzHb4NoVZQP8wGq101JDK.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IxYbIrXUJ6jOTkCB1is6Jg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216045U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "IxYbIrXUJ6jOTkCB1is6Jg", Name = "FileWriter (String)", IsManaged = true, IsAutoGenerated = true)]
        public n56.FileWriter_String_RhzHb4NoVZQP8wGq101JDK __p_IxYbIrXUJ6jOTkCB1is6Jg;
        public JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 other): base(other)
        {
            this.__p_IxYbIrXUJ6jOTkCB1is6Jg = other.__p_IxYbIrXUJ6jOTkCB1is6Jg;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IxYbIrXUJ6jOTkCB1is6Jg", in __p_IxYbIrXUJ6jOTkCB1is6Jg));
        }

        internal JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 __WITH__(n56.FileWriter_String_RhzHb4NoVZQP8wGq101JDK __p_IxYbIrXUJ6jOTkCB1is6Jg)
        {
            n37.JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IxYbIrXUJ6jOTkCB1is6Jg != this.__p_IxYbIrXUJ6jOTkCB1is6Jg ? new JSONWriter_XDocument_Rk0S9JlrxWRMdVQDEsXCS7(this)
                {__p_IxYbIrXUJ6jOTkCB1is6Jg = __p_IxYbIrXUJ6jOTkCB1is6Jg} : that_0;
            else
            {
                this.__p_IxYbIrXUJ6jOTkCB1is6Jg = __p_IxYbIrXUJ6jOTkCB1is6Jg;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216154U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "TgZP25u6vCjPyckNhH9sai", Name = "JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai")]
    [n2.SerializableAttribute]
    public class JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai CreateDefault()
        {
            var instance = new JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai Update(n11.Path File_Path_In, n12.Encodings Encoding_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, bool Read_In, out n2.IObservable<n6.XDocument> Output_Out, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var State_Output_4 = this.__p_D2WVAhYr6YFMhyR2mypJ4S.Update(File_Path_In: File_Path_In, Encoding_In: Encoding_In, Read_In: Read_In, Output_Out: out n2.IObservable<string> Output_0, Progress_Out: out float Progress_1, In_Progress_Out: out bool In_Progress_2, On_Completed_Out: out bool On_Completed_3);
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_12 = this.__p_CkQVpPNFnVVMv8W9n8rAes.Update<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Value_In: Output_0, Selector_In: (string Arg_1_In_7, int Arg_2_In_8) =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                var Result_9 = n24.XmlNodes.DeserializeXNode(json: Arg_1_In_7, deserializeRootElementName: Deserialize_Root_Element_Name_In, writeArrayAttribute: Write_Array_Attribute_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<n6.XDocument> Result_10, Changed_Out: out bool Changed_11);
            Output_Out = Result_10;
            Progress_Out = Progress_1;
            In_Progress_Out = In_Progress_2;
            On_Completed_Out = On_Completed_3;
            n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = State_Output_4 != this.__p_D2WVAhYr6YFMhyR2mypJ4S || Output_12 != this.__p_CkQVpPNFnVVMv8W9n8rAes ? new JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(this)
                {__p_D2WVAhYr6YFMhyR2mypJ4S = State_Output_4, __p_CkQVpPNFnVVMv8W9n8rAes = Output_12} : that_13;
            else
            {
                this.__p_D2WVAhYr6YFMhyR2mypJ4S = State_Output_4;
                this.__p_CkQVpPNFnVVMv8W9n8rAes = Output_12;
            }

            return that_13;
        }

        public n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "D2WVAhYr6YFMhyR2mypJ4S", 216177U);
            var Output_1 = n56.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "CkQVpPNFnVVMv8W9n8rAes", 216201U);
            var Output_3 = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<string>, string, n6.XDocument>.Create<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Node_Context: Node_Context_2);
            n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai that_4 = this;
            this.__p_D2WVAhYr6YFMhyR2mypJ4S = Output_1;
            this.__p_CkQVpPNFnVVMv8W9n8rAes = Output_3;
            return that_4;
        }

        public n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai __CreateDefault__()
        {
            n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai that_0 = this;
            this.__p_D2WVAhYr6YFMhyR2mypJ4S = n56.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh.CreateDefault();
            this.__p_CkQVpPNFnVVMv8W9n8rAes = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<string>, string, n6.XDocument>.CreateDefault<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_D2WVAhYr6YFMhyR2mypJ4S);
            n1.CompilationHelper.SafeDispose(this.__p_CkQVpPNFnVVMv8W9n8rAes);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216177U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "D2WVAhYr6YFMhyR2mypJ4S", Name = "FileReader (String Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n56.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh __p_D2WVAhYr6YFMhyR2mypJ4S;
        [n1.ElementAttribute(TracingId = 216201U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "CkQVpPNFnVVMv8W9n8rAes", Name = "Select", IsManaged = true, IsAutoGenerated = true)]
        public n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<string>, string, n6.XDocument> __p_CkQVpPNFnVVMv8W9n8rAes;
        public JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai other): base(other)
        {
            this.__p_D2WVAhYr6YFMhyR2mypJ4S = other.__p_D2WVAhYr6YFMhyR2mypJ4S;
            this.__p_CkQVpPNFnVVMv8W9n8rAes = other.__p_CkQVpPNFnVVMv8W9n8rAes;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_D2WVAhYr6YFMhyR2mypJ4S", in __p_D2WVAhYr6YFMhyR2mypJ4S), n1.CompilationHelper.GetValueOrExisting(values, "__p_CkQVpPNFnVVMv8W9n8rAes", in __p_CkQVpPNFnVVMv8W9n8rAes));
        }

        internal JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai __WITH__(n56.FileReader_String_Reactive_VTFPwrKqLPQOeQrp8g7eWh __p_D2WVAhYr6YFMhyR2mypJ4S, n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<string>, string, n6.XDocument> __p_CkQVpPNFnVVMv8W9n8rAes)
        {
            n37.JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_D2WVAhYr6YFMhyR2mypJ4S != this.__p_D2WVAhYr6YFMhyR2mypJ4S || __p_CkQVpPNFnVVMv8W9n8rAes != this.__p_CkQVpPNFnVVMv8W9n8rAes ? new JSONReader_XDocument_Reactive_TgZP25u6vCjPyckNhH9sai(this)
                {__p_D2WVAhYr6YFMhyR2mypJ4S = __p_D2WVAhYr6YFMhyR2mypJ4S, __p_CkQVpPNFnVVMv8W9n8rAes = __p_CkQVpPNFnVVMv8W9n8rAes} : that_0;
            else
            {
                this.__p_D2WVAhYr6YFMhyR2mypJ4S = __p_D2WVAhYr6YFMhyR2mypJ4S;
                this.__p_CkQVpPNFnVVMv8W9n8rAes = __p_CkQVpPNFnVVMv8W9n8rAes;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 216380U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "IWXVEYl2Q9nMFA1Ol9XYnk", Name = "JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk")]
    [n2.SerializableAttribute]
    public class JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk Create(n1.NodeContext Node_Context)
        {
            var instance = new JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk CreateDefault()
        {
            var instance = new JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk Update(n11.Path File_Path_In, n2.IObservable<n6.XNode> Data_In, n12.Encodings Encoding_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Indent_In, bool Omit_Root_Object_In, out float Progress_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            var Output_7 = this.__p_R87epakuMZ6NneyLN9S2cB.Update<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Value_In: Data_In, Selector_In: (n6.XNode Arg_1_In_2, int Arg_2_In_3) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Result_4 = n24.XmlNodes.SerializeXNode(input: Arg_1_In_2, indent: Indent_In, omitRootObject: Omit_Root_Object_In);
                return Result_4;
            }

            , Result_Out: out n2.IObservable<string> Result_5, Changed_Out: out bool Changed_6);
            bool Append_8 = false;
            var Output_12 = this.__p_Hpixyv227ngNnvbIS2BE4A.Update(File_Path_In: File_Path_In, Data_In: Result_5, Encoding_In: Encoding_In, Append_In: Append_8, Progress_Out: out float Progress_9, In_Progress_Out: out bool In_Progress_10, On_Completed_Out: out bool On_Completed_11);
            Progress_Out = Progress_9;
            In_Progress_Out = In_Progress_10;
            On_Completed_Out = On_Completed_11;
            n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Output_7 != this.__p_R87epakuMZ6NneyLN9S2cB || Output_12 != this.__p_Hpixyv227ngNnvbIS2BE4A ? new JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(this)
                {__p_R87epakuMZ6NneyLN9S2cB = Output_7, __p_Hpixyv227ngNnvbIS2BE4A = Output_12} : that_13;
            else
            {
                this.__p_R87epakuMZ6NneyLN9S2cB = Output_7;
                this.__p_Hpixyv227ngNnvbIS2BE4A = Output_12;
            }

            return that_13;
        }

        public n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "Hpixyv227ngNnvbIS2BE4A", 216405U);
            var Output_1 = n56.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Q2iWAXgl3GDPCvxD5IfFJH", "R87epakuMZ6NneyLN9S2cB", 216437U);
            var Output_3 = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XNode>, n6.XNode, string>.Create<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>(Node_Context: Node_Context_2);
            n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk that_4 = this;
            this.__p_Hpixyv227ngNnvbIS2BE4A = Output_1;
            this.__p_R87epakuMZ6NneyLN9S2cB = Output_3;
            return that_4;
        }

        public n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk __CreateDefault__()
        {
            n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk that_0 = this;
            this.__p_R87epakuMZ6NneyLN9S2cB = n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XNode>, n6.XNode, string>.CreateDefault<n40.__AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH>();
            this.__p_Hpixyv227ngNnvbIS2BE4A = n56.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_R87epakuMZ6NneyLN9S2cB);
            n1.CompilationHelper.SafeDispose(this.__p_Hpixyv227ngNnvbIS2BE4A);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 216437U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "R87epakuMZ6NneyLN9S2cB", Name = "Select", IsManaged = true, IsAutoGenerated = true)]
        public n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XNode>, n6.XNode, string> __p_R87epakuMZ6NneyLN9S2cB;
        [n1.ElementAttribute(TracingId = 216405U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", PersistentId = "Hpixyv227ngNnvbIS2BE4A", Name = "FileWriter (String Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n56.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 __p_Hpixyv227ngNnvbIS2BE4A;
        public JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk other): base(other)
        {
            this.__p_R87epakuMZ6NneyLN9S2cB = other.__p_R87epakuMZ6NneyLN9S2cB;
            this.__p_Hpixyv227ngNnvbIS2BE4A = other.__p_Hpixyv227ngNnvbIS2BE4A;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_R87epakuMZ6NneyLN9S2cB", in __p_R87epakuMZ6NneyLN9S2cB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hpixyv227ngNnvbIS2BE4A", in __p_Hpixyv227ngNnvbIS2BE4A));
        }

        internal JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk __WITH__(n42.Select_IShm0SBzszCN5V5IleChXI<n2.IObservable<n6.XNode>, n6.XNode, string> __p_R87epakuMZ6NneyLN9S2cB, n56.FileWriter_String_Reactive_IKMLoIqK7roLwjblZg9cs1 __p_Hpixyv227ngNnvbIS2BE4A)
        {
            n37.JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_R87epakuMZ6NneyLN9S2cB != this.__p_R87epakuMZ6NneyLN9S2cB || __p_Hpixyv227ngNnvbIS2BE4A != this.__p_Hpixyv227ngNnvbIS2BE4A ? new JSONWriter_XDocument_Reactive_IWXVEYl2Q9nMFA1Ol9XYnk(this)
                {__p_R87epakuMZ6NneyLN9S2cB = __p_R87epakuMZ6NneyLN9S2cB, __p_Hpixyv227ngNnvbIS2BE4A = __p_Hpixyv227ngNnvbIS2BE4A} : that_0;
            else
            {
                this.__p_R87epakuMZ6NneyLN9S2cB = __p_R87epakuMZ6NneyLN9S2cB;
                this.__p_Hpixyv227ngNnvbIS2BE4A = __p_Hpixyv227ngNnvbIS2BE4A;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Load(string Uri_In, out n6.XDocument Result_Out)
        {
            var Result_0 = n6.XDocument.Load(uri: Uri_In);
            Result_Out = Result_0;
            return;
        }

        public static void Save(n6.XDocument Input_In, n19.Stream Stream_In, n6.SaveOptions Options_In, out n6.XDocument Output_Out)
        {
            Input_In.Save(stream: Stream_In, options: Options_In);
            Output_Out = Input_In;
            return;
        }

        public static void XPathEvaluate(n6.XNode Input_In, string Expression_In, out n2.Object Result_Out)
        {
            var Result_0 = n44.Extensions.XPathEvaluate(node: Input_In, expression: Expression_In);
            Result_Out = Result_0;
            return;
        }

        public static void Parse_XDocument(string Text_In, n6.LoadOptions Options_In, out n6.XDocument Result_Out)
        {
            var Result_0 = n6.XDocument.Parse(text: Text_In, options: Options_In);
            Result_Out = Result_0;
            return;
        }

        public static void ParseJSON_XDocument(string Input_In, string Deserialize_Root_Element_Name_In, bool Write_Array_Attribute_In, out n6.XDocument Result_Out)
        {
            var Result_0 = n24.XmlNodes.DeserializeXNode(json: Input_In, deserializeRootElementName: Deserialize_Root_Element_Name_In, writeArrayAttribute: Write_Array_Attribute_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Xml_.System.XML.ValidationType.Advanced
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NE(n24.ValidationType Input_In, n24.ValidationType Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void OperatorBitwiseAnd(n24.ValidationType Input_In, n24.ValidationType Input_2_In, out n24.ValidationType Output_Out)
        {
            var Output_0 = Input_In & Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public static void OperatorBitwiseExclusiveOr(n24.ValidationType Input_In, n24.ValidationType Input_2_In, out n24.ValidationType Output_Out)
        {
            var Output_0 = Input_In ^ Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public static void OperatorBitwiseOr(n24.ValidationType Input_In, n24.ValidationType Input_2_In, out n24.ValidationType Output_Out)
        {
            var Output_0 = Input_In | Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public static void OperatorEquals(n24.ValidationType Input_In, n24.ValidationType Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Xml_.System.XML.XDocumentReader.Advanced
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context_In, out n23.XDocumentReader Output_Out)
        {
            var Output_0 = new n23.XDocumentReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update(n23.XDocumentReader Input__this__In, n34.IResourceProvider<n19.Stream> Input_In, bool Read_In, out n23.XDocumentReader Output_Out, out n6.XDocument Result_Out)
        {
            var Result_0 = Input__this__In.Update(input: Input_In, read: Read_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Xml_.System.XML.XDocumentWriter.Advanced
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context_In, out n23.XDocumentWriter Output_Out)
        {
            var Output_0 = new n23.XDocumentWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update(n23.XDocumentWriter Input__this__In, n34.IResourceProvider<n19.Stream> Input_In, n6.XDocument Data_In, bool Write_In, out n23.XDocumentWriter Output_Out)
        {
            Input__this__In.Update(input: Input_In, data: Data_In, write: Write_In);
            Output_Out = Input__this__In;
            return;
        }
    }
}

namespace _VL_Xml_.System.XML.XDocumentReader_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n23.AsyncXDocumentReader Output_Out)
        {
            var Output_0 = new n23.AsyncXDocumentReader(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n23.AsyncXDocumentReader Input__this__In, n2.IObservable<n34.IResourceProvider<n19.Stream>> Input_In, out n23.AsyncXDocumentReader Output_Out, out n2.IObservable<n6.XDocument> Result_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var Result_2 = Input__this__In.Update(input: Input_In, inProgress: out bool In_Progress_0, onCompleted: out bool On_Completed_1);
            Output_Out = Input__this__In;
            Result_Out = Result_2;
            In_Progress_Out = In_Progress_0;
            On_Completed_Out = On_Completed_1;
            return;
        }
    }
}

namespace _VL_Xml_.System.XML.XDocumentWriter_Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 209714U, DocumentId = "Q2iWAXgl3GDPCvxD5IfFJH", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create_H(n1.NodeContext Node_Context_In, out n23.AsyncXDocumentWriter Output_Out)
        {
            var Output_0 = new n23.AsyncXDocumentWriter(nodeContext: Node_Context_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H(n23.AsyncXDocumentWriter Input__this__In, n34.IResourceProvider<n19.Stream> Input_In, n2.IObservable<n6.XDocument> Data_In, out n23.AsyncXDocumentWriter Output_Out, out n2.IObservable<n6.XDocument> Result_Out, out bool In_Progress_Out, out bool On_Completed_Out)
        {
            var Result_2 = Input__this__In.Update(input: Input_In, data: Data_In, inProgress: out bool In_Progress_0, onCompleted: out bool On_Completed_1);
            Output_Out = Input__this__In;
            Result_Out = Result_2;
            In_Progress_Out = In_Progress_0;
            On_Completed_Out = On_Completed_1;
            return;
        }
    }
}

namespace _VL_Xml_
{
    public struct __AdaptiveImplementations__Q2iWAXgl3GDPCvxD5IfFJH : n32.IAdaptiveCreateDefault<n19.Stream>, n32.IAdaptiveCreateDefault<n2.IObservable<string>>, n32.IAdaptiveCreateDefault<n2.IObservable<n6.XDocument>>, n32.IAdaptiveCreateDefault<n2.IObservable<n6.XNode>>, n32.IAdaptiveCreateDefault<n2.IObservable<n6.XElement>>
    {
        public void CreateDefault(out n19.Stream Output_Out)
        {
            var Null_0 = n57._Operations_.CreateDefault();
            Output_Out = Null_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<string> Output_Out)
        {
            var Result_0 = n25._Operations_.CreateDefault<string>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n6.XDocument> Output_Out)
        {
            var Result_0 = n25._Operations_.CreateDefault<n6.XDocument>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n6.XNode> Output_Out)
        {
            var Result_0 = n25._Operations_.CreateDefault<n6.XNode>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n6.XElement> Output_Out)
        {
            var Result_0 = n25._Operations_.CreateDefault<n6.XElement>();
            Output_Out = Result_0;
            return;
        }
    }
}