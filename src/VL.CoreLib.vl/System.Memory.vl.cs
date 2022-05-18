extern alias e2;

using n6 = global::System.Collections.Generic;
using n3 = _System_Memory_.System.Advanced;
using n1 = e2::VL.Core;
using n2 = global::System;
using n4 = e2::VL.Core.CompilerServices;
using n5 = global::System.Runtime.CompilerServices;

namespace _System_Memory_.System.Advanced
{
    [n1.ElementAttribute(TracingId = 114341U, DocumentId = "TbpIhqjOLSBPFhdxbH8kpm", PersistentId = "T71syYzZFaGPUlhLXsVdjN", Name = "System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN")]
    [n2.SerializableAttribute]
    public class System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN Create(n1.NodeContext Node_Context)
        {
            var instance = new System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN CreateDefault()
        {
            var instance = new System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN Update()
        {
            return this;
        }

        public n3.System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN __CreateDefault__()
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

        public System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN(System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal System_MemoryApplication_T71syYzZFaGPUlhLXsVdjN __WITH__()
        {
            return this;
        }
    }
}

namespace _System_Memory_.System.Memory.Advanced
{
    [n1.ElementAttribute(TracingId = 114050U, DocumentId = "TbpIhqjOLSBPFhdxbH8kpm", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n2.Memory<T> CreateDefault<T>()
        {
            var Empty_0 = n2.Memory<T>.Empty;
            return Empty_0;
        }
    }
}

namespace _System_Memory_.System.ReadOnlyMemory.Advanced
{
    [n1.ElementAttribute(TracingId = 114050U, DocumentId = "TbpIhqjOLSBPFhdxbH8kpm", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n2.ReadOnlyMemory<T> CreateDefault<T>()
        {
            var Empty_0 = n2.ReadOnlyMemory<T>.Empty;
            return Empty_0;
        }
    }
}

namespace _System_Memory_.System.IHasMemory.Advanced
{
    [n1.ElementAttribute(TracingId = 114050U, DocumentId = "TbpIhqjOLSBPFhdxbH8kpm", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n1.IHasMemory<T> CreateDefault<T>()
        {
            var Result_0 = n1.HasMemoryExtensions.Empty<T>();
            return Result_0;
        }

        public static void ElementSize<T>(n1.IHasMemory<T> Input_In, out int Result_Out)
        {
            var Result_0 = n1.HasMemoryExtensions.ElementSize<T>(instance: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Empty<T>(out n1.IHasMemory<T> Result_Out)
        {
            var Result_0 = n1.HasMemoryExtensions.Empty<T>();
            Result_Out = Result_0;
            return;
        }

        public static void HasData<T>(n1.IHasMemory<T> Input_In, out bool Result_Out)
        {
            var Result_0 = n1.HasMemoryExtensions.HasData<T>(instance: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Length<T>(n1.IHasMemory<T> Input_In, out int Result_Out)
        {
            var Result_0 = n1.HasMemoryExtensions.Length<T>(instance: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Size<T>(n1.IHasMemory<T> Input_In, out long Result_Out)
        {
            var Result_0 = n1.HasMemoryExtensions.Size<T>(instance: Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _System_Memory_.System.Advanced.Adaptive
{
    public interface IAdaptiveAsMemory<T2, T>
    {
        void AsMemory(T2 Input_In, out n2.Memory<T> Result_Out);
    }

    public interface IAdaptiveAsReadOnlyMemory<T2, T>
    {
        void AsReadOnlyMemory(T2 Input_In, out n2.ReadOnlyMemory<T> Result_Out);
    }
}

namespace _System_Memory_
{
    public struct __AdaptiveImplementations__TbpIhqjOLSBPFhdxbH8kpm
    {
    }
}