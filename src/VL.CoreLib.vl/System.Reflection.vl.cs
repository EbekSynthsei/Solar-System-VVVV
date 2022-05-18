extern alias e2;

using n5 = _System_Reflection_.System.Reflection;
using n4 = global::System.Collections.Immutable;
using n7 = global::System.Collections.Generic;
using n1 = e2::VL.Core;
using n3 = global::System;
using n2 = e2::VL.Core.CompilerServices;
using n6 = global::System.Runtime.CompilerServices;

namespace _System_Reflection_.System.Reflection.IVLObject.Experimental
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n2.CreateDefaultAttribute]
        public static n1.IVLObject CreateDefault_H()
        {
            var Default_0 = n1.VLObjectExtensions.Default;
            return Default_0;
        }

        public static void TryGetValue<T>(n1.IVLObject Input_In, string Name_In, T Default_Value_In, out T Value_Out, out bool Result_Out)
        {
            var Result_1 = n1.VLObjectExtensions.TryGetValue<T>(instance: Input_In, name: Name_In, defaultValue: Default_Value_In, value: out T Value_0);
            Value_Out = Value_0;
            Result_Out = Result_1;
            return;
        }

        public static void TryGetValueByPath<T>(n1.IVLObject Input_In, string Path_In, T Default_Value_In, out T Value_Out, out bool Result_Out)
        {
            var Result_1 = n1.VLObjectExtensions.TryGetValueByPath<T>(instance: Input_In, path: Path_In, defaultValue: Default_Value_In, value: out T Value_0);
            Value_Out = Value_0;
            Result_Out = Result_1;
            return;
        }

        public static void WithValue<T2, T>(T2 Input_In, string Name_In, T Value_In, out T2 Output_Out)
            where T2 : class, n1.IVLObject
        {
            var Output_0 = n1.VLObjectExtensions.WithValue<T2, T>(instance: Input_In, name: Name_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void WithValueByPath<T2, T>(T2 Input_In, string Path_In, T Value_In, out T2 Output_Out)
            where T2 : class, n1.IVLObject
        {
            var Output_0 = n1.VLObjectExtensions.WithValueByPath<T2, T>(instance: Input_In, path: Path_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void Type(n1.IVLObject Input_In, out n1.IVLTypeInfo Type_Out)
        {
            var Type_0 = Input_In.Type;
            n1.IVLObject __pad_NAWbAizZQaVPJ9lPAoHOyo_1 = Input_In;
            Type_Out = Type_0;
            return;
        }

        public static void Context(n1.IVLObject Input_In, out n1.NodeContext Context_Out)
        {
            var Context_0 = Input_In.Context;
            n1.IVLObject __pad_D7KjncZk66kMXSwPY9acEL_1 = Input_In;
            Context_Out = Context_0;
            return;
        }

        public static void TryReplaceDescendant<T, T2>(T Input_In, T2 Descendant_In, out T Updated_Instance_Out, out bool Result_Out)
            where T : class, n1.IVLObject where T2 : class, n1.IVLObject
        {
            var Result_1 = n1.VLObjectExtensions.TryReplaceDescendant<T, T2>(instance: Input_In, descendant: Descendant_In, updatedInstance: out T Updated_Instance_0);
            Updated_Instance_Out = Updated_Instance_0;
            Result_Out = Result_1;
            return;
        }

        public static void Identity(n1.IVLObject Input_In, out uint Identity_Out)
        {
            var Identity_0 = Input_In.Identity;
            n1.IVLObject __pad_O1LcWS4vfCJOyRXKEqLtix_1 = Input_In;
            Identity_Out = Identity_0;
            return;
        }

        public static void IsSupportedCollectionType(n1.IVLTypeInfo Type_In, out bool Result_Out)
        {
            var Result_0 = n1.VLObjectExtensions.IsSupportedCollectionType(type: Type_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryGetPath(n1.IVLObject Input_In, n1.IVLObject Descendant_In, out bool Result_Out, out string Path_Out)
        {
            var Result_1 = n1.VLObjectExtensions.TryGetPath(instance: Input_In, descendant: Descendant_In, path: out string Path_0);
            Result_Out = Result_1;
            Path_Out = Path_0;
            return;
        }
    }
}

namespace _System_Reflection_.System.Reflection.IVLTypeInfo.Experimental
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n2.CreateDefaultAttribute]
        public static n1.IVLTypeInfo CreateDefault_H()
        {
            var Default_0 = n1.VLTypeInfoExtensions.Default;
            return Default_0;
        }
    }
}

namespace _System_Reflection_.System.Reflection.IVLPropertyInfo.Experimental
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n2.CreateDefaultAttribute]
        public static n1.IVLPropertyInfo CreateDefault_H()
        {
            var Default_0 = n1.VLPropertyInfoExtensions.Default;
            return Default_0;
        }

        public static void TryGetValue<T2, T3, T>(T2 Input_In, T3 Property_In, T Default_Value_In, out T Value_Out, out bool Success_Out)
            where T2 : n1.IVLObject where T3 : n1.IVLPropertyInfo
        {
            n1.IVLPropertyInfo Input_0 = (n1.IVLPropertyInfo)Property_In;
            n1.IVLObject Instance_1 = (n1.IVLObject)Input_In;
            var Result_3 = n1.VLPropertyInfoExtensions.TryGetValue<T>(property: Input_0, instance: Instance_1, defaultValue: Default_Value_In, value: out T Value_2);
            Value_Out = Value_2;
            Success_Out = Result_3;
            return;
        }

        public static void WithValue<T2, T3, T>(T2 Input_In, T3 Property_In, T Value_In, out T2 Output_Out)
            where T2 : class, n1.IVLObject where T3 : n1.IVLPropertyInfo
        {
            n1.IVLPropertyInfo Input_0 = (n1.IVLPropertyInfo)Property_In;
            var Result_1 = n1.VLPropertyInfoExtensions.WithValue<T2, T>(property: Input_0, instance: Input_In, value: Value_In);
            Output_Out = Result_1;
            return;
        }

        public static void DeclaringType(n1.IVLPropertyInfo Input_In, out n1.IVLTypeInfo Declaring_Type_Out)
        {
            var Declaring_Type_0 = Input_In.DeclaringType;
            Declaring_Type_Out = Declaring_Type_0;
            return;
        }

        public static void Name(n1.IVLPropertyInfo Input_In, out string Name_Out)
        {
            var Name_0 = Input_In.Name;
            Name_Out = Name_0;
            return;
        }

        public static void Type(n1.IVLPropertyInfo Input_In, out n1.IVLTypeInfo Type_Out)
        {
            var Type_0 = Input_In.Type;
            Type_Out = Type_0;
            return;
        }
    }
}

namespace _System_Reflection_.System.Reflection.IVLFactory.Experimental
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n2.CreateDefaultAttribute]
        public static n1.IVLFactory CreateDefault_H()
        {
            var Current_0 = n1.VLFactory.Current;
            return Current_0;
        }

        public static void CreateInstance(n1.IVLFactory Input_In, n3.Type Type_In, n1.NodeContext Node_Context_In, out n1.IVLFactory Output_Out, out n3.Object Result_Out)
        {
            var Result_0 = ((n1.IVLFactory)Input_In).CreateInstance(type: Type_In, nodeContext: Node_Context_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void TryCreateInstance<T>(n1.IVLFactory Input_In, T Default_Value_In, n1.NodeContext Node_Context_In, out bool Success_Out, out T Instance_Out)
        {
            var Result_1 = n1.VLFactoryExtensions.TryCreateInstance<T>(factory: Input_In, defaultValue: Default_Value_In, nodeContext: Node_Context_In, instance: out T Instance_0);
            Success_Out = Result_1;
            Instance_Out = Instance_0;
            return;
        }

        public static void GetDefaultValue(n1.IVLFactory Input_In, n3.Type Type_In, out n1.IVLFactory Output_Out, out n3.Object Result_Out)
        {
            var Result_0 = ((n1.IVLFactory)Input_In).GetDefaultValue(type: Type_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetTypeByName(n1.IVLFactory Input_In, string Name_In, out n1.IVLFactory Output_Out, out n3.Type Result_Out)
        {
            var Result_0 = ((n1.IVLFactory)Input_In).GetTypeByName(name: Name_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetTypeInfo(n1.IVLFactory Input_In, n3.Type Type_In, out n1.IVLFactory Output_Out, out n1.IVLTypeInfo Result_Out)
        {
            var Result_0 = ((n1.IVLFactory)Input_In).GetTypeInfo(type: Type_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void RegisterService<T, T2>(n1.IVLFactory Input_In, n3.Func<T, T2> Create_In, out n1.IVLFactory Output_Out)
        {
            var Output_0 = n1.VLFactoryExtensions.RegisterService<T, T2>(factory: Input_In, create: Create_In);
            Output_Out = Output_0;
            return;
        }

        public static void TryCreateService<T>(n1.IVLFactory Input_In, n3.Object Value_In, n3.Type For_Type_In, T Default_Service_In, out bool Result_Out, out T Service_Out)
        {
            var Result_1 = n1.VLFactoryExtensions.TryCreateService<T>(factory: Input_In, value: Value_In, forType: For_Type_In, defaultService: Default_Service_In, service: out T Service_0);
            Result_Out = Result_1;
            Service_Out = Service_0;
            return;
        }

        public static void GetService<T>(n1.IVLFactory Input_In, out T Result_Out)
            where T : class
        {
            var Result_0 = n1.VLFactoryExtensions.GetService<T>(factory: Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _System_Reflection_.System.Reflection.NodeContext.Advanced
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n2.CreateDefaultAttribute]
        public static n1.NodeContext CreateDefault_H()
        {
            var Default_0 = n1.NodeContext.Default;
            return Default_0;
        }

        public static void Factory(n1.NodeContext Input_In, out n1.IVLFactory Factory_Out)
        {
            var Factory_0 = Input_In.Factory;
            Factory_Out = Factory_0;
            return;
        }

        public static void Path(n1.NodeContext Input_In, out n1.NodePath Path_Out)
        {
            var Path_0 = Input_In.Path;
            Path_Out = Path_0;
            return;
        }
    }
}

namespace _System_Reflection_.System.Reflection.NodePath.Advanced
{
    [n1.ElementAttribute(TracingId = 91239U, DocumentId = "LiIPinoB4LjLRms7uZqVID", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Stack(n1.NodePath Input_In, out n1.NodePath Output_Out, out n4.ImmutableStack<uint> Stack_Out)
        {
            var Obsolete_Stack_0 = Input_In.ObsoleteStack;
            Output_Out = Input_In;
            Stack_Out = Obsolete_Stack_0;
            return;
        }

        public static void Stack(n1.NodePath Input_In, out n1.NodePath Output_Out, out n4.ImmutableStack<n1.UniqueId> Stack_Out)
        {
            var Stack_0 = Input_In.Stack;
            Output_Out = Input_In;
            Stack_Out = Stack_0;
            return;
        }
    }
}

namespace _System_Reflection_.System.Reflection
{
    [n1.ElementAttribute(TracingId = 92568U, DocumentId = "LiIPinoB4LjLRms7uZqVID", PersistentId = "MN0dCnpOh71NdoghiwHCa7", Name = "System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7")]
    [n3.SerializableAttribute]
    public class System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 : n1.VLObject, n3.IDisposable
    {
        [n2.CreateNewAttribute]
        public static n5.System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 Create(n1.NodeContext Node_Context)
        {
            var instance = new System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n2.CreateDefaultAttribute]
        public static n5.System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 CreateDefault()
        {
            var instance = new System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 Update()
        {
            return this;
        }

        public n5.System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n5.System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 __CreateDefault__()
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

        public System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7(System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal System_ReflectionApplication_MN0dCnpOh71NdoghiwHCa7 __WITH__()
        {
            return this;
        }
    }
}

namespace _System_Reflection_
{
    public struct __AdaptiveImplementations__LiIPinoB4LjLRms7uZqVID
    {
    }
}