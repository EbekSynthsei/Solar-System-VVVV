extern alias e3;
extern alias e2;

using n10 = e2::VL.Lib.Collections;
using n17 = _CoreLibBasics_.Control;
using n7 = _System_Serialization_.System.Serialization.Volatile.Advanced;
using n9 = global::System.Collections.Generic;
using n6 = _System_Serialization_.System.Serialization;
using n8 = _VL_Xml_.System.XML;
using n1 = e2::VL.Core;
using n2 = global::System;
using n15 = e2::VL.Lib.IO;
using n14 = e3::VL.Lib.IO;
using n4 = e2::VL.Core.CompilerServices;
using n3 = e3::VL.Lib.Runtime;
using n16 = global::System.Runtime.CompilerServices;
using n13 = _System_Serialization_.System.Serialization.Advanced;
using n12 = _VL_Collections_.Collections.Spread;
using n11 = global::System.Xml.Linq;

namespace _System_Serialization_.System.Serialization.Advanced
{
    [n1.ElementAttribute(TracingId = 83852U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Serialize<T>(n1.SerializationContext Input_In, string Name_In, T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Force_Element_In, out n2.Object Result_Out)
        {
            var Result_0 = n1.Serialization.Serialize<T>(context: Input_In, name: Name_In, value: Value_In, forceElement: Force_Element_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize<T>(n1.SerializationContext Input_In, n2.Object Content_In, string Name_In, out T Result_Out)
        {
            var Result_0 = n1.Serialization.Deserialize<T>(context: Input_In, content: Content_In, name: Name_In);
            Result_Out = Result_0;
            return;
        }

        public static void RegisterSerializer<T2, T>(n1.IVLFactory Input_In, T2 Serializer_In, out n1.IVLFactory Output_Out)
            where T2 : class, n1.ISerializer<T>
        {
            var Output_0 = n1.Serialization.RegisterSerializer<T, T2>(factory: Input_In, serializer: Serializer_In);
            Output_Out = Output_0;
            return;
        }

        public static void Serialize_Log_Errors<T>(T Value_In, bool Throw_On_Error_In, bool Include_Defaults_In, n1.NodeContext Node_Context_In, out n11.XElement Result_Out, out n9.IReadOnlyList<string> Error_Messages_Out)
        {
            var Result_1 = n1.Serialization.Serialize<T>(nodeContext: Node_Context_In, value: Value_In, throwOnError: Throw_On_Error_In, includeDefaults: Include_Defaults_In, errorMessages: out n9.IReadOnlyList<string> Error_Messages_0);
            Result_Out = Result_1;
            Error_Messages_Out = Error_Messages_0;
            return;
        }

        public static void Deserialize_Log_Errors<T>(n11.XElement Content_In, bool Throw_On_Error_In, n1.NodeContext Node_Context_In, out T Result_Out, out n9.IReadOnlyList<string> Error_Messages_Out)
        {
            var Result_1 = n1.Serialization.Deserialize<T>(nodeContext: Node_Context_In, content: Content_In, throwOnError: Throw_On_Error_In, errorMessages: out n9.IReadOnlyList<string> Error_Messages_0);
            Result_Out = Result_1;
            Error_Messages_Out = Error_Messages_0;
            return;
        }
    }
}

namespace _System_Serialization_.System.Serialization.Volatile.Advanced
{
    [n1.ElementAttribute(TracingId = 83852U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Deserialize_Binary_ReadOnlyMemory<T>(n2.ReadOnlyMemory<byte> Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Force_Little_Endian_In, out T Result_Out)
        {
            var Result_0 = n3.Serialization.DeserializeBinary<T>(serializedValue: Serialized_Value_In, forceLittleEndian: Force_Little_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize_Bson<T>(byte[] Serialized_Value_In, out T Result_Out)
        {
            var Result_0 = n3.Serialization.DeserializeBson<T>(serializedValue: Serialized_Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize_Json_Slicewise<T2, T>(T2 Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Omit_Header_In, out n10.Spread<T> Result_Out)
            where T2 : n9.IEnumerable<string>
        {
            n10.Spread<T> __cp_A0lDo2EFiUUMOSU0fxGA8s = n12._Operations_.CreateDefault<T>();
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_A0lDo2EFiUUMOSU0fxGA8s, 16);
            n10.Spread<T> output_6;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Serialized_Value_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n7._Operations_.Deserialize_Json<T>(Serialized_Value_In: splicer_1, Indent_In: Indent_In, Omit_Header_In: Omit_Header_In, Result_Out: out T Result_4);
                    builder_5.Add(Result_4);
                    i_2++;
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Result_Out = output_6;
            return;
        }

        public static void Deserialize_Json<T>(string Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Omit_Header_In, out T Result_Out)
        {
            var Result_0 = n3.Serialization.DeserializeJson<T>(serializedValue: Serialized_Value_In, indent: Indent_In, omitHeader: Omit_Header_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize_Xml_Slicewise<T2, T>(T2 Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, out n10.Spread<T> Result_Out)
            where T2 : n9.IEnumerable<string>
        {
            n10.Spread<T> __cp_MuiOKfhXQIgLRhy8RxSTkT = n12._Operations_.CreateDefault<T>();
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_MuiOKfhXQIgLRhy8RxSTkT, 16);
            n10.Spread<T> output_6;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Serialized_Value_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n7._Operations_.Deserialize_Xml<T>(Serialized_Value_In: splicer_1, Indent_In: Indent_In, Result_Out: out T Result_4);
                    builder_5.Add(Result_4);
                    i_2++;
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Result_Out = output_6;
            return;
        }

        public static void Deserialize_Xml<T>(string Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, out T Result_Out)
        {
            var Result_0 = n3.Serialization.DeserializeXml<T>(serializedValue: Serialized_Value_In, indent: Indent_In);
            Result_Out = Result_0;
            return;
        }

        public static void Serialize_Binary<T>(T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Force_Little_Endian_In, out byte[] Result_Out)
        {
            var Result_0 = n3.Serialization.SerializeBinary<T>(value: Value_In, forceLittleEndian: Force_Little_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void Serialize_Bson<T>(T Value_In, out byte[] Result_Out)
        {
            var Result_0 = n3.Serialization.SerializeBson<T>(value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void Serialize_Json_Slicewise<T2, T>(T2 Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Omit_Header_In, out n10.Spread<string> Result_Out)
            where T2 : n9.IEnumerable<T>
        {
            n10.Spread<string> __cp_JanpLebjo8LPQBZGcwt9oG = n12._Operations_.CreateDefault<string>();
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_JanpLebjo8LPQBZGcwt9oG, 16);
            n10.Spread<string> output_6;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Value_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n7._Operations_.Serialize_Json<T>(Value_In: splicer_1, Indent_In: Indent_In, Omit_Header_In: Omit_Header_In, Result_Out: out string Result_4);
                    builder_5.Add(Result_4);
                    i_2++;
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Result_Out = output_6;
            return;
        }

        public static void Serialize_Json<T>(T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Omit_Header_In, out string Result_Out)
        {
            var Result_0 = n3.Serialization.SerializeJson<T>(value: Value_In, indent: Indent_In, omitHeader: Omit_Header_In);
            Result_Out = Result_0;
            return;
        }

        public static void Serialize_Xml_Slicewise<T2, T>(T2 Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, out n10.Spread<string> Result_Out)
            where T2 : n9.IEnumerable<T>
        {
            n10.Spread<string> __cp_PrbNeUqfkOtLRnzJDf51wO = n12._Operations_.CreateDefault<string>();
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_PrbNeUqfkOtLRnzJDf51wO, 16);
            n10.Spread<string> output_6;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Value_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n7._Operations_.Serialize_Xml<T>(Value_In: splicer_1, Indent_In: Indent_In, Result_Out: out string Result_4);
                    builder_5.Add(Result_4);
                    i_2++;
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Result_Out = output_6;
            return;
        }

        public static void Serialize_Xml<T>(T Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Indent_In, out string Result_Out)
        {
            var Result_0 = n3.Serialization.SerializeXml<T>(value: Value_In, indent: Indent_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize_Binary<T>(byte[] Serialized_Value_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Force_Little_Endian_In, out T Result_Out)
        {
            var Result_0 = n3.Serialization.DeserializeBinary<T>(serializedValue: Serialized_Value_In, forceLittleEndian: Force_Little_Endian_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _System_Serialization_.System.Serialization
{
    [n1.ElementAttribute(TracingId = 89827U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "Ordux5u8MUjPFUJ6OrYaW1", Name = "Persistent_Ordux5u8MUjPFUJ6OrYaW1")]
    [n2.SerializableAttribute]
    public class Persistent_Ordux5u8MUjPFUJ6OrYaW1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 Create(n1.NodeContext Node_Context)
        {
            var instance = new Persistent_Ordux5u8MUjPFUJ6OrYaW1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 CreateDefault()
        {
            var instance = new Persistent_Ordux5u8MUjPFUJ6OrYaW1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 Update<T>(T Input_In, n15.Path File_Path_In, bool Write_In, bool Read_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Read_On_Open_In, bool Include_Defaults_In, bool Throw_On_Error_In, out T Output_Out)
        {
            T __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__GkuB5GyITVHLundXagPzp1>(this.__if_IZtGDxZ2OKpOxt9hKfN5kX, __GetContext__());
            if (Write_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __GkuB5GyITVHLundXagPzp1(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("UNgTG11dj1YPpT6hEzII3u", "UnlXPYKa5aGN6lIq6KKvJM", 89911U);
                    var Output_3 = n8.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R.Create(Node_Context: Node_Context_2);
                    state_1.__p_UnlXPYKa5aGN6lIq6KKvJM = Output_3;
                }

                n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("UNgTG11dj1YPpT6hEzII3u", "ILvsEteerFZOvvTwNNv0D6", 89921U);
                n13._Operations_.Serialize_Log_Errors<T>(Value_In: Input_In, Throw_On_Error_In: Throw_On_Error_In, Include_Defaults_In: Include_Defaults_In, Node_Context_In: Node_Context_4, Result_Out: out n11.XElement Result_5, Error_Messages_Out: out n9.IReadOnlyList<string> Error_Messages_6);
                File_Path_In.Filename(directory: out string Directory_7, filename: out string Filename_8, extension: out string Extension_9);
                var Result_10 = n14.PathExtension.ToPath(input: Directory_7);
                bool Create_11 = true;
                var Output_13 = n14.PathExtension.CreateDirectory(input: Result_10, create: Create_11, success: out bool Success_12);
                bool Update_14 = true;
                var Output_15 = state_1.__p_UnlXPYKa5aGN6lIq6KKvJM;
                if (Update_14)
                {
                    Output_15 = state_1.__p_UnlXPYKa5aGN6lIq6KKvJM.Update(File_Path_In: File_Path_In, Data_In: Result_5, Write_In: Success_12);
                }

                __auto_0 = Input_In;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = Output_15 != state_1.__p_UnlXPYKa5aGN6lIq6KKvJM ? new __GkuB5GyITVHLundXagPzp1(state_1)
                    {__p_UnlXPYKa5aGN6lIq6KKvJM = Output_15} : state_1;
                else
                {
                    state_1.__p_UnlXPYKa5aGN6lIq6KKvJM = Output_15;
                }
            }
            else
            {
                __auto_0 = Input_In;
            }

            bool Simulate_16 = false;
            var State_Output_18 = this.__p_O3mvYre01AZN3OprmuM0tI.Update(Simulate_In: Simulate_16, Output_Out: out bool Output_17);
            var Output_19 = Output_17 && Read_On_Open_In;
            var Output_20 = Read_In || Output_19;
            T __auto_21;
            var state_22 = n1.CompilationHelper.Restore<__TGEDNkvadi7OP4nui6VkVH>(this.__if_GVDuzkAA4l4LB2vIVjhCxS, __GetContext__());
            if (Output_20)
            {
                if (state_22 == null)
                {
                    state_22 = new __TGEDNkvadi7OP4nui6VkVH(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var Exists_23 = File_Path_In.Exists;
                T __auto_24;
                var state_25 = n1.CompilationHelper.Restore<__OJGA3ZpwsH2QaJjRjVZDHE>(state_22.__if_BcQIhjMVqwDOiWwb56cTSZ, __GetContext__());
                if (Exists_23)
                {
                    if (state_25 == null)
                    {
                        state_25 = new __OJGA3ZpwsH2QaJjRjVZDHE(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("UNgTG11dj1YPpT6hEzII3u", "HlqiQ7qZc7VP1n3nprAeNO", 89851U);
                        var Output_27 = n8.XMLReader_OcM6yTDIunKLXht5WzCyyW.Create(Node_Context: Node_Context_26);
                        state_25.__p_HlqiQ7qZc7VP1n3nprAeNO = Output_27;
                    }

                    var State_Output_29 = state_25.__p_HlqiQ7qZc7VP1n3nprAeNO.Update(File_Path_In: File_Path_In, Read_In: Output_20, Output_Out: out n11.XElement Output_28);
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("UNgTG11dj1YPpT6hEzII3u", "AgN3vcL20sSORif2Ostttr", 89860U);
                    n13._Operations_.Deserialize_Log_Errors<T>(Content_In: Output_28, Throw_On_Error_In: Throw_On_Error_In, Node_Context_In: Node_Context_30, Result_Out: out T Result_31, Error_Messages_Out: out n9.IReadOnlyList<string> Error_Messages_32);
                    __auto_24 = Result_31;
                    if (state_25.__GetContext__().IsImmutable)
                        state_25 = State_Output_29 != state_25.__p_HlqiQ7qZc7VP1n3nprAeNO ? new __OJGA3ZpwsH2QaJjRjVZDHE(state_25)
                        {__p_HlqiQ7qZc7VP1n3nprAeNO = State_Output_29} : state_25;
                    else
                    {
                        state_25.__p_HlqiQ7qZc7VP1n3nprAeNO = State_Output_29;
                    }
                }
                else
                {
                    __auto_24 = __auto_0;
                }

                __auto_21 = __auto_24;
                if (state_22.__GetContext__().IsImmutable)
                    state_22 = state_25 != state_22.__if_BcQIhjMVqwDOiWwb56cTSZ ? new __TGEDNkvadi7OP4nui6VkVH(state_22)
                    {__if_BcQIhjMVqwDOiWwb56cTSZ = state_25} : state_22;
                else
                {
                    state_22.__if_BcQIhjMVqwDOiWwb56cTSZ = state_25;
                }
            }
            else
            {
                __auto_21 = __auto_0;
            }

            Output_Out = __auto_21;
            n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = state_1 != this.__if_IZtGDxZ2OKpOxt9hKfN5kX || State_Output_18 != this.__p_O3mvYre01AZN3OprmuM0tI || state_22 != this.__if_GVDuzkAA4l4LB2vIVjhCxS ? new Persistent_Ordux5u8MUjPFUJ6OrYaW1(this)
                {__if_IZtGDxZ2OKpOxt9hKfN5kX = state_1, __p_O3mvYre01AZN3OprmuM0tI = State_Output_18, __if_GVDuzkAA4l4LB2vIVjhCxS = state_22} : that_33;
            else
            {
                this.__if_IZtGDxZ2OKpOxt9hKfN5kX = state_1;
                this.__p_O3mvYre01AZN3OprmuM0tI = State_Output_18;
                this.__if_GVDuzkAA4l4LB2vIVjhCxS = state_22;
            }

            return that_33;
        }

        public n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("UNgTG11dj1YPpT6hEzII3u", "O3mvYre01AZN3OprmuM0tI", 89888U);
            var Output_1 = n17.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 that_2 = this;
            this.__p_O3mvYre01AZN3OprmuM0tI = Output_1;
            this.__if_IZtGDxZ2OKpOxt9hKfN5kX = default(n2.Object);
            this.__if_GVDuzkAA4l4LB2vIVjhCxS = default(n2.Object);
            return that_2;
        }

        public n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 __CreateDefault__()
        {
            n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 that_0 = this;
            this.__if_IZtGDxZ2OKpOxt9hKfN5kX = default(n2.Object);
            this.__p_O3mvYre01AZN3OprmuM0tI = n17.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__if_GVDuzkAA4l4LB2vIVjhCxS = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_IZtGDxZ2OKpOxt9hKfN5kX);
            n1.CompilationHelper.SafeDispose(this.__p_O3mvYre01AZN3OprmuM0tI);
            n1.CompilationHelper.SafeDispose(this.__if_GVDuzkAA4l4LB2vIVjhCxS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_IZtGDxZ2OKpOxt9hKfN5kX;
        [n1.ElementAttribute(TracingId = 89888U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "O3mvYre01AZN3OprmuM0tI", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n17.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_O3mvYre01AZN3OprmuM0tI;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_GVDuzkAA4l4LB2vIVjhCxS;
        public Persistent_Ordux5u8MUjPFUJ6OrYaW1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Persistent_Ordux5u8MUjPFUJ6OrYaW1(Persistent_Ordux5u8MUjPFUJ6OrYaW1 other): base(other)
        {
            this.__if_IZtGDxZ2OKpOxt9hKfN5kX = other.__if_IZtGDxZ2OKpOxt9hKfN5kX;
            this.__p_O3mvYre01AZN3OprmuM0tI = other.__p_O3mvYre01AZN3OprmuM0tI;
            this.__if_GVDuzkAA4l4LB2vIVjhCxS = other.__if_GVDuzkAA4l4LB2vIVjhCxS;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_IZtGDxZ2OKpOxt9hKfN5kX", in __if_IZtGDxZ2OKpOxt9hKfN5kX), n1.CompilationHelper.GetValueOrExisting(values, "__p_O3mvYre01AZN3OprmuM0tI", in __p_O3mvYre01AZN3OprmuM0tI), n1.CompilationHelper.GetValueOrExisting(values, "__if_GVDuzkAA4l4LB2vIVjhCxS", in __if_GVDuzkAA4l4LB2vIVjhCxS));
        }

        internal Persistent_Ordux5u8MUjPFUJ6OrYaW1 __WITH__(n2.Object __if_IZtGDxZ2OKpOxt9hKfN5kX, n17.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_O3mvYre01AZN3OprmuM0tI, n2.Object __if_GVDuzkAA4l4LB2vIVjhCxS)
        {
            n6.Persistent_Ordux5u8MUjPFUJ6OrYaW1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_IZtGDxZ2OKpOxt9hKfN5kX != this.__if_IZtGDxZ2OKpOxt9hKfN5kX || __p_O3mvYre01AZN3OprmuM0tI != this.__p_O3mvYre01AZN3OprmuM0tI || __if_GVDuzkAA4l4LB2vIVjhCxS != this.__if_GVDuzkAA4l4LB2vIVjhCxS ? new Persistent_Ordux5u8MUjPFUJ6OrYaW1(this)
                {__if_IZtGDxZ2OKpOxt9hKfN5kX = __if_IZtGDxZ2OKpOxt9hKfN5kX, __p_O3mvYre01AZN3OprmuM0tI = __p_O3mvYre01AZN3OprmuM0tI, __if_GVDuzkAA4l4LB2vIVjhCxS = __if_GVDuzkAA4l4LB2vIVjhCxS} : that_0;
            else
            {
                this.__if_IZtGDxZ2OKpOxt9hKfN5kX = __if_IZtGDxZ2OKpOxt9hKfN5kX;
                this.__p_O3mvYre01AZN3OprmuM0tI = __p_O3mvYre01AZN3OprmuM0tI;
                this.__if_GVDuzkAA4l4LB2vIVjhCxS = __if_GVDuzkAA4l4LB2vIVjhCxS;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "GkuB5GyITVHLundXagPzp1", Name = "__GkuB5GyITVHLundXagPzp1")]
        [n2.SerializableAttribute]
        public class __GkuB5GyITVHLundXagPzp1 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UnlXPYKa5aGN6lIq6KKvJM);
                return;
            }

            [n1.ElementAttribute(TracingId = 89911U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "UnlXPYKa5aGN6lIq6KKvJM", Name = "XMLWriter", IsManaged = true, IsAutoGenerated = true)]
            public n8.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R __p_UnlXPYKa5aGN6lIq6KKvJM;
            public __GkuB5GyITVHLundXagPzp1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GkuB5GyITVHLundXagPzp1(__GkuB5GyITVHLundXagPzp1 other): base(other)
            {
                this.__p_UnlXPYKa5aGN6lIq6KKvJM = other.__p_UnlXPYKa5aGN6lIq6KKvJM;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UnlXPYKa5aGN6lIq6KKvJM", in __p_UnlXPYKa5aGN6lIq6KKvJM));
            }

            internal __GkuB5GyITVHLundXagPzp1 __WITH__(n8.XMLWriter_K3RuV8m5vRVMCM7TAI7w2R __p_UnlXPYKa5aGN6lIq6KKvJM)
            {
                __GkuB5GyITVHLundXagPzp1 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UnlXPYKa5aGN6lIq6KKvJM != this.__p_UnlXPYKa5aGN6lIq6KKvJM ? new __GkuB5GyITVHLundXagPzp1(this)
                    {__p_UnlXPYKa5aGN6lIq6KKvJM = __p_UnlXPYKa5aGN6lIq6KKvJM} : that_0;
                else
                {
                    this.__p_UnlXPYKa5aGN6lIq6KKvJM = __p_UnlXPYKa5aGN6lIq6KKvJM;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "TGEDNkvadi7OP4nui6VkVH", Name = "__TGEDNkvadi7OP4nui6VkVH")]
        [n2.SerializableAttribute]
        public class __TGEDNkvadi7OP4nui6VkVH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_BcQIhjMVqwDOiWwb56cTSZ);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_BcQIhjMVqwDOiWwb56cTSZ;
            public __TGEDNkvadi7OP4nui6VkVH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TGEDNkvadi7OP4nui6VkVH(__TGEDNkvadi7OP4nui6VkVH other): base(other)
            {
                this.__if_BcQIhjMVqwDOiWwb56cTSZ = other.__if_BcQIhjMVqwDOiWwb56cTSZ;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_BcQIhjMVqwDOiWwb56cTSZ", in __if_BcQIhjMVqwDOiWwb56cTSZ));
            }

            internal __TGEDNkvadi7OP4nui6VkVH __WITH__(n2.Object __if_BcQIhjMVqwDOiWwb56cTSZ)
            {
                __TGEDNkvadi7OP4nui6VkVH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_BcQIhjMVqwDOiWwb56cTSZ != this.__if_BcQIhjMVqwDOiWwb56cTSZ ? new __TGEDNkvadi7OP4nui6VkVH(this)
                    {__if_BcQIhjMVqwDOiWwb56cTSZ = __if_BcQIhjMVqwDOiWwb56cTSZ} : that_0;
                else
                {
                    this.__if_BcQIhjMVqwDOiWwb56cTSZ = __if_BcQIhjMVqwDOiWwb56cTSZ;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "OJGA3ZpwsH2QaJjRjVZDHE", Name = "__OJGA3ZpwsH2QaJjRjVZDHE")]
        [n2.SerializableAttribute]
        public class __OJGA3ZpwsH2QaJjRjVZDHE : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HlqiQ7qZc7VP1n3nprAeNO);
                return;
            }

            [n1.ElementAttribute(TracingId = 89851U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "HlqiQ7qZc7VP1n3nprAeNO", Name = "XMLReader", IsManaged = true, IsAutoGenerated = true)]
            public n8.XMLReader_OcM6yTDIunKLXht5WzCyyW __p_HlqiQ7qZc7VP1n3nprAeNO;
            public __OJGA3ZpwsH2QaJjRjVZDHE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OJGA3ZpwsH2QaJjRjVZDHE(__OJGA3ZpwsH2QaJjRjVZDHE other): base(other)
            {
                this.__p_HlqiQ7qZc7VP1n3nprAeNO = other.__p_HlqiQ7qZc7VP1n3nprAeNO;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HlqiQ7qZc7VP1n3nprAeNO", in __p_HlqiQ7qZc7VP1n3nprAeNO));
            }

            internal __OJGA3ZpwsH2QaJjRjVZDHE __WITH__(n8.XMLReader_OcM6yTDIunKLXht5WzCyyW __p_HlqiQ7qZc7VP1n3nprAeNO)
            {
                __OJGA3ZpwsH2QaJjRjVZDHE that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HlqiQ7qZc7VP1n3nprAeNO != this.__p_HlqiQ7qZc7VP1n3nprAeNO ? new __OJGA3ZpwsH2QaJjRjVZDHE(this)
                    {__p_HlqiQ7qZc7VP1n3nprAeNO = __p_HlqiQ7qZc7VP1n3nprAeNO} : that_0;
                else
                {
                    this.__p_HlqiQ7qZc7VP1n3nprAeNO = __p_HlqiQ7qZc7VP1n3nprAeNO;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 90084U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", PersistentId = "Im8eY6kiq8sPbl841Co0vs", Name = "System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs")]
    [n2.SerializableAttribute]
    public class System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n6.System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs Create(n1.NodeContext Node_Context)
        {
            var instance = new System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n6.System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs CreateDefault()
        {
            var instance = new System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n6.System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs Update()
        {
            return this;
        }

        public n6.System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n6.System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs __CreateDefault__()
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

        public System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs(System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal System_SerializationApplication_Im8eY6kiq8sPbl841Co0vs __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 83852U, DocumentId = "UNgTG11dj1YPpT6hEzII3u", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Serialize<T>(T Value_In, n1.NodeContext Node_Context_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Include_Defaults_In, out n11.XElement Result_Out)
        {
            var Result_0 = n1.Serialization.Serialize<T>(nodeContext: Node_Context_In, value: Value_In, includeDefaults: Include_Defaults_In);
            Result_Out = Result_0;
            return;
        }

        public static void Deserialize<T>(n11.XElement Content_In, n1.NodeContext Node_Context_In, out T Result_Out)
        {
            var Result_0 = n1.Serialization.Deserialize<T>(nodeContext: Node_Context_In, content: Content_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _System_Serialization_
{
    public struct __AdaptiveImplementations__UNgTG11dj1YPpT6hEzII3u
    {
    }
}