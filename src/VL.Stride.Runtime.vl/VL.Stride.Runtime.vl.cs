extern alias e2;

using n3 = _VL_Stride_Runtime_.Stride;
using n6 = global::System.Collections.Generic;
using n1 = e2::VL.Core;
using n2 = global::System;
using n4 = e2::VL.Core.CompilerServices;
using n5 = global::System.Runtime.CompilerServices;

namespace _VL_Stride_Runtime_.Stride
{
    [n1.ElementAttribute(TracingId = 373U, DocumentId = "MZmd92n0x8tLLBfKYOnxOx", PersistentId = "SVC5xgUyUSrLhdrp2wZ8uC", Name = "VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC")]
    [n2.SerializableAttribute]
    public class VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC CreateDefault()
        {
            var instance = new VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC Update()
        {
            return this;
        }

        public n3.VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC __CreateDefault__()
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

        public VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC(VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_RuntimeApplication_SVC5xgUyUSrLhdrp2wZ8uC __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Runtime_
{
    public struct __AdaptiveImplementations__MZmd92n0x8tLLBfKYOnxOx
    {
    }
}