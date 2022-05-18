extern alias e2;

using n6 = global::System.Collections.Generic;
using n3 = _VL_Fuse_.Fuse;
using n1 = e2::VL.Core;
using n2 = global::System;
using n4 = e2::VL.Core.CompilerServices;
using n5 = global::System.Runtime.CompilerServices;

namespace _VL_Fuse_.Fuse
{
    [n1.ElementAttribute(TracingId = 314933U, DocumentId = "MzrPktFwnABMtmjvPGeHVw", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv(VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_FuseApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Fuse_
{
    public struct __AdaptiveImplementations__MzrPktFwnABMtmjvPGeHVw
    {
    }
}