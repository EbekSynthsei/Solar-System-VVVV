extern alias e5;

using n3 = _VL_CoreLib_;
using n4 = e5::VL.Core.CompilerServices;
using n6 = global::System.Collections.Generic;
using n1 = e5::VL.Core;
using n2 = global::System;
using n5 = global::System.Runtime.CompilerServices;

namespace _VL_CoreLib_
{
    [n1.ElementAttribute(TracingId = 44U, DocumentId = "LMFQrbYrtQvO4pn4vSywS3", PersistentId = "HOXmgyFb22hNHgiGpPvAIF", Name = "VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF")]
    [n2.SerializableAttribute]
    public class VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF CreateDefault()
        {
            var instance = new VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF Update()
        {
            return this;
        }

        public n3.VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF __CreateDefault__()
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

        public VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF(VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_CoreLibApplication_HOXmgyFb22hNHgiGpPvAIF __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_CoreLib_
{
    public struct __AdaptiveImplementations__LMFQrbYrtQvO4pn4vSywS3
    {
    }
}