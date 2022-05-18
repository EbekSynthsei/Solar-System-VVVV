extern alias e2;

using n6 = global::System.Collections.Generic;
using n3 = _VL_EditingFramework_;
using n1 = e2::VL.Core;
using n2 = global::System;
using n4 = e2::VL.Core.CompilerServices;
using n5 = global::System.Runtime.CompilerServices;

namespace _VL_EditingFramework_
{
    [n1.ElementAttribute(TracingId = 39527U, DocumentId = "Tbxvcw7pDmdQapVBYd69Lt", PersistentId = "AYHUjx6grqrLMtRDjNztRS", Name = "VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS")]
    [n2.SerializableAttribute]
    public class VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS CreateDefault()
        {
            var instance = new VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS Update()
        {
            return this;
        }

        public n3.VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS __CreateDefault__()
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

        public VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS(VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_EditingFrameworkApplication_AYHUjx6grqrLMtRDjNztRS __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_EditingFramework_
{
    public struct __AdaptiveImplementations__Tbxvcw7pDmdQapVBYd69Lt
    {
    }
}