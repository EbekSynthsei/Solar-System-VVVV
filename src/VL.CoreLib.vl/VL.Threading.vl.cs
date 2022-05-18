extern alias e3;
extern alias e2;

using n8 = _VL_Collections_.Collections.IReadOnlyList;
using n5 = e3::VL.Lib.Threading.ThreadingUtils;
using n14 = e2::VL.Lib.Collections;
using n13 = e3::VL.Lib.Primitive.CacheRegion;
using n3 = _VL_Threading_.System.Threading.Advanced;
using n7 = _CoreLibBasics_.VL.Experimental;
using n9 = global::System.Collections.Generic;
using n12 = global::System.Threading;
using n1 = e2::VL.Core;
using n2 = global::System;
using n10 = e2::VL.Core.PublicAPI;
using n4 = e2::VL.Core.CompilerServices;
using n6 = e3::VL.Lib.Threading;
using n11 = global::System.Runtime.CompilerServices;

namespace _VL_Threading_.System.Threading.Advanced
{
    [n1.ElementAttribute(TracingId = 119648U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "FyCN7Vj282lLcqnkwpaV2j", Name = "Lock_FyCN7Vj282lLcqnkwpaV2j")]
    [n2.SerializableAttribute]
    public class Lock_FyCN7Vj282lLcqnkwpaV2j : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Lock_FyCN7Vj282lLcqnkwpaV2j Create(n1.NodeContext Node_Context)
        {
            var instance = new Lock_FyCN7Vj282lLcqnkwpaV2j(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Lock_FyCN7Vj282lLcqnkwpaV2j CreateDefault()
        {
            var instance = new Lock_FyCN7Vj282lLcqnkwpaV2j(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Lock_FyCN7Vj282lLcqnkwpaV2j Update(n10.ICustomRegion Region_In, n2.Object Key_In, [n4.SerializedDefaultValueAttribute("-1", false)] double Timeout_In)
        {
            var Result_0 = n2.TimeSpan.FromSeconds(value: Timeout_In);
            var Result_2 = n6.ThreadingUtils.TryEnter(key: Key_In, timeout: Result_0, @lock: out n5.MonitorLock Lock_1);
            var state_3 = n1.CompilationHelper.Restore<__Mbog0goZ0gHOee9uEr4qVX>(this.__if_RfF8IgvKjx2Ou3G0zUxCXa, __GetContext__());
            if (Result_2)
            {
                if (state_3 == null)
                {
                    state_3 = new __Mbog0goZ0gHOee9uEr4qVX(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var state_4 = n1.CompilationHelper.Restore<__RCFqByZuIYwNB7eac2FbDK>(state_3.__using_Ejo5KFlvt3KNlhNOezOslj, __GetContext__());
                using (Lock_1)
                {
                    if (state_4 == null)
                    {
                        state_4 = new __RCFqByZuIYwNB7eac2FbDK(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_5 = __GetContext__().CreateSubContext("TRSQqiX8IifNt3AKKsULGv", "LFZsZfP2rlCP3Bu2NC36ga", 121163U);
                        var Output_6 = n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2.Create(Node_Context_In: Node_Context_5);
                        state_4.__p_LFZsZfP2rlCP3Bu2NC36ga = Output_6;
                    }

                    var Input_Values_7 = Region_In.InputValues;
                    bool Reset_8 = false;
                    bool Update_9 = true;
                    var Output_10 = state_4.__p_LFZsZfP2rlCP3Bu2NC36ga;
                    if (Update_9)
                    {
                        Output_10 = state_4.__p_LFZsZfP2rlCP3Bu2NC36ga.Update(Region_In: Region_In, Reset_In: Reset_8, Inputs_In: Input_Values_7);
                    }

                    n9.IReadOnlyList<n2.Object> Value_11 = n8._Operations_.CreateDefault<n2.Object>();
                    Region_In.OutputValues = Value_11;
                    if (state_4.__GetContext__().IsImmutable)
                        state_4 = Output_10 != state_4.__p_LFZsZfP2rlCP3Bu2NC36ga ? new __RCFqByZuIYwNB7eac2FbDK(state_4)
                        {__p_LFZsZfP2rlCP3Bu2NC36ga = Output_10} : state_4;
                    else
                    {
                        state_4.__p_LFZsZfP2rlCP3Bu2NC36ga = Output_10;
                    }
                }

                if (state_3.__GetContext__().IsImmutable)
                    state_3 = state_4 != state_3.__using_Ejo5KFlvt3KNlhNOezOslj ? new __Mbog0goZ0gHOee9uEr4qVX(state_3)
                    {__using_Ejo5KFlvt3KNlhNOezOslj = state_4} : state_3;
                else
                {
                    state_3.__using_Ejo5KFlvt3KNlhNOezOslj = state_4;
                }
            }

            n3.Lock_FyCN7Vj282lLcqnkwpaV2j that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = state_3 != this.__if_RfF8IgvKjx2Ou3G0zUxCXa ? new Lock_FyCN7Vj282lLcqnkwpaV2j(this)
                {__if_RfF8IgvKjx2Ou3G0zUxCXa = state_3} : that_12;
            else
            {
                this.__if_RfF8IgvKjx2Ou3G0zUxCXa = state_3;
            }

            return that_12;
        }

        public n3.Lock_FyCN7Vj282lLcqnkwpaV2j __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Lock_FyCN7Vj282lLcqnkwpaV2j that_0 = this;
            this.__if_RfF8IgvKjx2Ou3G0zUxCXa = default(n2.Object);
            return that_0;
        }

        public n3.Lock_FyCN7Vj282lLcqnkwpaV2j __CreateDefault__()
        {
            n3.Lock_FyCN7Vj282lLcqnkwpaV2j that_0 = this;
            this.__if_RfF8IgvKjx2Ou3G0zUxCXa = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_RfF8IgvKjx2Ou3G0zUxCXa);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_RfF8IgvKjx2Ou3G0zUxCXa;
        public Lock_FyCN7Vj282lLcqnkwpaV2j(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Lock_FyCN7Vj282lLcqnkwpaV2j(Lock_FyCN7Vj282lLcqnkwpaV2j other): base(other)
        {
            this.__if_RfF8IgvKjx2Ou3G0zUxCXa = other.__if_RfF8IgvKjx2Ou3G0zUxCXa;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_RfF8IgvKjx2Ou3G0zUxCXa", in __if_RfF8IgvKjx2Ou3G0zUxCXa));
        }

        internal Lock_FyCN7Vj282lLcqnkwpaV2j __WITH__(n2.Object __if_RfF8IgvKjx2Ou3G0zUxCXa)
        {
            n3.Lock_FyCN7Vj282lLcqnkwpaV2j that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_RfF8IgvKjx2Ou3G0zUxCXa != this.__if_RfF8IgvKjx2Ou3G0zUxCXa ? new Lock_FyCN7Vj282lLcqnkwpaV2j(this)
                {__if_RfF8IgvKjx2Ou3G0zUxCXa = __if_RfF8IgvKjx2Ou3G0zUxCXa} : that_0;
            else
            {
                this.__if_RfF8IgvKjx2Ou3G0zUxCXa = __if_RfF8IgvKjx2Ou3G0zUxCXa;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "Mbog0goZ0gHOee9uEr4qVX", Name = "__Mbog0goZ0gHOee9uEr4qVX")]
        [n2.SerializableAttribute]
        public class __Mbog0goZ0gHOee9uEr4qVX : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__using_Ejo5KFlvt3KNlhNOezOslj);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __using_Ejo5KFlvt3KNlhNOezOslj;
            public __Mbog0goZ0gHOee9uEr4qVX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Mbog0goZ0gHOee9uEr4qVX(__Mbog0goZ0gHOee9uEr4qVX other): base(other)
            {
                this.__using_Ejo5KFlvt3KNlhNOezOslj = other.__using_Ejo5KFlvt3KNlhNOezOslj;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__using_Ejo5KFlvt3KNlhNOezOslj", in __using_Ejo5KFlvt3KNlhNOezOslj));
            }

            internal __Mbog0goZ0gHOee9uEr4qVX __WITH__(n2.Object __using_Ejo5KFlvt3KNlhNOezOslj)
            {
                __Mbog0goZ0gHOee9uEr4qVX that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __using_Ejo5KFlvt3KNlhNOezOslj != this.__using_Ejo5KFlvt3KNlhNOezOslj ? new __Mbog0goZ0gHOee9uEr4qVX(this)
                    {__using_Ejo5KFlvt3KNlhNOezOslj = __using_Ejo5KFlvt3KNlhNOezOslj} : that_0;
                else
                {
                    this.__using_Ejo5KFlvt3KNlhNOezOslj = __using_Ejo5KFlvt3KNlhNOezOslj;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "RCFqByZuIYwNB7eac2FbDK", Name = "__RCFqByZuIYwNB7eac2FbDK")]
        [n2.SerializableAttribute]
        public class __RCFqByZuIYwNB7eac2FbDK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_LFZsZfP2rlCP3Bu2NC36ga);
                return;
            }

            [n1.ElementAttribute(TracingId = 121163U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "LFZsZfP2rlCP3Bu2NC36ga", Name = "CustomRegionPatch", IsManaged = true, IsAutoGenerated = true)]
            public n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2 __p_LFZsZfP2rlCP3Bu2NC36ga;
            public __RCFqByZuIYwNB7eac2FbDK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RCFqByZuIYwNB7eac2FbDK(__RCFqByZuIYwNB7eac2FbDK other): base(other)
            {
                this.__p_LFZsZfP2rlCP3Bu2NC36ga = other.__p_LFZsZfP2rlCP3Bu2NC36ga;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LFZsZfP2rlCP3Bu2NC36ga", in __p_LFZsZfP2rlCP3Bu2NC36ga));
            }

            internal __RCFqByZuIYwNB7eac2FbDK __WITH__(n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2 __p_LFZsZfP2rlCP3Bu2NC36ga)
            {
                __RCFqByZuIYwNB7eac2FbDK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_LFZsZfP2rlCP3Bu2NC36ga != this.__p_LFZsZfP2rlCP3Bu2NC36ga ? new __RCFqByZuIYwNB7eac2FbDK(this)
                    {__p_LFZsZfP2rlCP3Bu2NC36ga = __p_LFZsZfP2rlCP3Bu2NC36ga} : that_0;
                else
                {
                    this.__p_LFZsZfP2rlCP3Bu2NC36ga = __p_LFZsZfP2rlCP3Bu2NC36ga;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 121256U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "ERguMxLK1NKQZpEFFt1hQj", Name = "Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj")]
    [n2.SerializableAttribute]
    public class Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj Create(n1.NodeContext Node_Context)
        {
            var instance = new Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj CreateDefault()
        {
            var instance = new Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj Update(n10.ICustomRegion Region_In, [n4.SerializedDefaultValueAttribute("GlobalResource", false)] string Key_In, [n4.SerializedDefaultValueAttribute("-1", false)] double Timeout_In)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = true;
            var manager_2 = this.__cache_SwAEgGsxKr3O1r4m4r3YQ6;
            if (manager_2 is null)
            {
                manager_2 = new n13.Manager<n2.ValueTuple<string>, n2.ValueTuple<n12.Mutex>>(n2.ValueTuple.Create(default(n12.Mutex)));
            }

            var inputs_3 = n2.ValueTuple.Create(Key_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                bool Initially_Owned_7 = false;
                var Output_8 = new n12.Mutex(initiallyOwned: Initially_Owned_7, name: Key_In);
                outputs_4 = n2.ValueTuple.Create(Output_8);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_9 = outputs_4.Item1;
            var Result_10 = n2.TimeSpan.FromSeconds(value: Timeout_In);
            var Result_12 = n6.ThreadingUtils.TryEnter(mutex: __auto_9, timeout: Result_10, mutexLock: out n5.MutexLock Mutex_Lock_11);
            var state_13 = n1.CompilationHelper.Restore<__P1z5YIqrhEFQZYTCx97PIB>(this.__if_Hv0S0mF6pxFL8bBYMx0hgf, __GetContext__());
            if (Result_12)
            {
                if (state_13 == null)
                {
                    state_13 = new __P1z5YIqrhEFQZYTCx97PIB(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var state_14 = n1.CompilationHelper.Restore<__CaFnzBB9S4iP9sAHg8Qf5v>(state_13.__using_CWYc02zqPH2PmlmzW9auMj, __GetContext__());
                using (Mutex_Lock_11)
                {
                    if (state_14 == null)
                    {
                        state_14 = new __CaFnzBB9S4iP9sAHg8Qf5v(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("TRSQqiX8IifNt3AKKsULGv", "AyBdIEFqIAkPkruIxagwnP", 121339U);
                        var Output_16 = n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2.Create(Node_Context_In: Node_Context_15);
                        state_14.__p_AyBdIEFqIAkPkruIxagwnP = Output_16;
                    }

                    var Input_Values_17 = Region_In.InputValues;
                    bool Reset_18 = false;
                    bool Update_19 = true;
                    var Output_20 = state_14.__p_AyBdIEFqIAkPkruIxagwnP;
                    if (Update_19)
                    {
                        Output_20 = state_14.__p_AyBdIEFqIAkPkruIxagwnP.Update(Region_In: Region_In, Reset_In: Reset_18, Inputs_In: Input_Values_17);
                    }

                    n9.IReadOnlyList<n2.Object> Incoming_Links_21 = n8._Operations_.CreateDefault<n2.Object>();
                    var Output_23 = Output_20.UpdatePart2(Incoming_Links_In: Incoming_Links_21, Outputs_Out: out n14.Spread<n2.Object> Outputs_22);
                    n9.IReadOnlyList<n2.Object> Value_24 = (n9.IReadOnlyList<n2.Object>)Outputs_22;
                    Region_In.OutputValues = Value_24;
                    if (state_14.__GetContext__().IsImmutable)
                        state_14 = Output_23 != state_14.__p_AyBdIEFqIAkPkruIxagwnP ? new __CaFnzBB9S4iP9sAHg8Qf5v(state_14)
                        {__p_AyBdIEFqIAkPkruIxagwnP = Output_23} : state_14;
                    else
                    {
                        state_14.__p_AyBdIEFqIAkPkruIxagwnP = Output_23;
                    }
                }

                if (state_13.__GetContext__().IsImmutable)
                    state_13 = state_14 != state_13.__using_CWYc02zqPH2PmlmzW9auMj ? new __P1z5YIqrhEFQZYTCx97PIB(state_13)
                    {__using_CWYc02zqPH2PmlmzW9auMj = state_14} : state_13;
                else
                {
                    state_13.__using_CWYc02zqPH2PmlmzW9auMj = state_14;
                }
            }

            n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_2 != this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 || state_13 != this.__if_Hv0S0mF6pxFL8bBYMx0hgf ? new Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(this)
                {__cache_SwAEgGsxKr3O1r4m4r3YQ6 = manager_2, __if_Hv0S0mF6pxFL8bBYMx0hgf = state_13} : that_25;
            else
            {
                this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 = manager_2;
                this.__if_Hv0S0mF6pxFL8bBYMx0hgf = state_13;
            }

            return that_25;
        }

        public n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj that_0 = this;
            this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 = null;
            this.__if_Hv0S0mF6pxFL8bBYMx0hgf = default(n2.Object);
            return that_0;
        }

        public n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj __CreateDefault__()
        {
            n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj that_0 = this;
            this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 = null;
            this.__if_Hv0S0mF6pxFL8bBYMx0hgf = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SwAEgGsxKr3O1r4m4r3YQ6);
            n1.CompilationHelper.SafeDispose(this.__if_Hv0S0mF6pxFL8bBYMx0hgf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 121260U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "SwAEgGsxKr3O1r4m4r3YQ6", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<string>, n2.ValueTuple<n12.Mutex>> __cache_SwAEgGsxKr3O1r4m4r3YQ6 = null;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Hv0S0mF6pxFL8bBYMx0hgf;
        public Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj other): base(other)
        {
            this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 = other.__cache_SwAEgGsxKr3O1r4m4r3YQ6;
            this.__if_Hv0S0mF6pxFL8bBYMx0hgf = other.__if_Hv0S0mF6pxFL8bBYMx0hgf;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SwAEgGsxKr3O1r4m4r3YQ6", in __cache_SwAEgGsxKr3O1r4m4r3YQ6), n1.CompilationHelper.GetValueOrExisting(values, "__if_Hv0S0mF6pxFL8bBYMx0hgf", in __if_Hv0S0mF6pxFL8bBYMx0hgf));
        }

        internal Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj __WITH__(n13.Manager<n2.ValueTuple<string>, n2.ValueTuple<n12.Mutex>> __cache_SwAEgGsxKr3O1r4m4r3YQ6, n2.Object __if_Hv0S0mF6pxFL8bBYMx0hgf)
        {
            n3.Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SwAEgGsxKr3O1r4m4r3YQ6 != this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 || __if_Hv0S0mF6pxFL8bBYMx0hgf != this.__if_Hv0S0mF6pxFL8bBYMx0hgf ? new Lock_InterMprocess_ERguMxLK1NKQZpEFFt1hQj(this)
                {__cache_SwAEgGsxKr3O1r4m4r3YQ6 = __cache_SwAEgGsxKr3O1r4m4r3YQ6, __if_Hv0S0mF6pxFL8bBYMx0hgf = __if_Hv0S0mF6pxFL8bBYMx0hgf} : that_0;
            else
            {
                this.__cache_SwAEgGsxKr3O1r4m4r3YQ6 = __cache_SwAEgGsxKr3O1r4m4r3YQ6;
                this.__if_Hv0S0mF6pxFL8bBYMx0hgf = __if_Hv0S0mF6pxFL8bBYMx0hgf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "P1z5YIqrhEFQZYTCx97PIB", Name = "__P1z5YIqrhEFQZYTCx97PIB")]
        [n2.SerializableAttribute]
        public class __P1z5YIqrhEFQZYTCx97PIB : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__using_CWYc02zqPH2PmlmzW9auMj);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __using_CWYc02zqPH2PmlmzW9auMj;
            public __P1z5YIqrhEFQZYTCx97PIB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __P1z5YIqrhEFQZYTCx97PIB(__P1z5YIqrhEFQZYTCx97PIB other): base(other)
            {
                this.__using_CWYc02zqPH2PmlmzW9auMj = other.__using_CWYc02zqPH2PmlmzW9auMj;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__using_CWYc02zqPH2PmlmzW9auMj", in __using_CWYc02zqPH2PmlmzW9auMj));
            }

            internal __P1z5YIqrhEFQZYTCx97PIB __WITH__(n2.Object __using_CWYc02zqPH2PmlmzW9auMj)
            {
                __P1z5YIqrhEFQZYTCx97PIB that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __using_CWYc02zqPH2PmlmzW9auMj != this.__using_CWYc02zqPH2PmlmzW9auMj ? new __P1z5YIqrhEFQZYTCx97PIB(this)
                    {__using_CWYc02zqPH2PmlmzW9auMj = __using_CWYc02zqPH2PmlmzW9auMj} : that_0;
                else
                {
                    this.__using_CWYc02zqPH2PmlmzW9auMj = __using_CWYc02zqPH2PmlmzW9auMj;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "CaFnzBB9S4iP9sAHg8Qf5v", Name = "__CaFnzBB9S4iP9sAHg8Qf5v")]
        [n2.SerializableAttribute]
        public class __CaFnzBB9S4iP9sAHg8Qf5v : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AyBdIEFqIAkPkruIxagwnP);
                return;
            }

            [n1.ElementAttribute(TracingId = 121339U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "AyBdIEFqIAkPkruIxagwnP", Name = "CustomRegionPatch", IsManaged = true, IsAutoGenerated = true)]
            public n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2 __p_AyBdIEFqIAkPkruIxagwnP;
            public __CaFnzBB9S4iP9sAHg8Qf5v(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CaFnzBB9S4iP9sAHg8Qf5v(__CaFnzBB9S4iP9sAHg8Qf5v other): base(other)
            {
                this.__p_AyBdIEFqIAkPkruIxagwnP = other.__p_AyBdIEFqIAkPkruIxagwnP;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AyBdIEFqIAkPkruIxagwnP", in __p_AyBdIEFqIAkPkruIxagwnP));
            }

            internal __CaFnzBB9S4iP9sAHg8Qf5v __WITH__(n7.CustomRegionPatch_I8CuhA1uzWAOhPtfcLn0d2 __p_AyBdIEFqIAkPkruIxagwnP)
            {
                __CaFnzBB9S4iP9sAHg8Qf5v that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AyBdIEFqIAkPkruIxagwnP != this.__p_AyBdIEFqIAkPkruIxagwnP ? new __CaFnzBB9S4iP9sAHg8Qf5v(this)
                    {__p_AyBdIEFqIAkPkruIxagwnP = __p_AyBdIEFqIAkPkruIxagwnP} : that_0;
                else
                {
                    this.__p_AyBdIEFqIAkPkruIxagwnP = __p_AyBdIEFqIAkPkruIxagwnP;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 123344U, DocumentId = "TRSQqiX8IifNt3AKKsULGv", PersistentId = "OCB5WhWtDvJM8pGrD6L6oS", Name = "VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS")]
    [n2.SerializableAttribute]
    public class VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS CreateDefault()
        {
            var instance = new VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS Update()
        {
            return this;
        }

        public n3.VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS __CreateDefault__()
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

        public VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS(VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_ThreadingApplication_OCB5WhWtDvJM8pGrD6L6oS __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Threading_
{
    public struct __AdaptiveImplementations__TRSQqiX8IifNt3AKKsULGv
    {
    }
}