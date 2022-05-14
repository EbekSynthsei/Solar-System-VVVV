extern alias e2;
extern alias e5;

using n17 = _CoreLibBasics_.Control.Advanced;
using n27 = global::System.Reactive.Subjects;
using n28 = _CoreLibBasics_.Primitive.Object.Advanced;
using n10 = _CoreLibBasics_.Control;
using n11 = _VL_Reactive_.Reactive.Advanced;
using n21 = global::System.Reactive.Concurrency;
using n5 = e5::VL.Core.CompilerServices;
using n36 = _CoreLibBasics_.Primitive.Delegates.Delegate__0_MG_1.Advanced;
using n34 = global::System.Reactive.Disposables;
using n12 = global::System.Collections.Generic;
using n8 = _VL_Reactive_.Reactive.Observable.Advanced;
using n15 = _VL_Reactive_;
using n4 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n37 = _VL_Reactive_.Reactive.Disposables.SerialDisposable.Advanced;
using n39 = _CoreLibBasics_.System.TimeSpan;
using n16 = e2::VL.Lib.Primitive.CacheRegion;
using n41 = _VL_Reactive_.Reactive.Scheduler.Advanced;
using n30 = global::System.Threading;
using n18 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n33 = global::System.Threading.Tasks;
using n29 = e2::VL.Lib.Reactive.ObservableNodes;
using n38 = e5::VL.Lib.Basics.Resources;
using n2 = global::System;
using n3 = _VL_Reactive_.Reactive;
using n14 = global::System.Reactive.Linq;
using n6 = e2::VL.Lib.Proxies;
using n19 = _VL_Reactive_.Reactive.ToObservable_Switch.Advanced;
using n7 = _CoreLibBasics_.Primitive.Delegates.Proxies.Proxy__1_MG_1.Advanced;
using n32 = global::System.Reactive.Threading.Tasks;
using n13 = _CoreLibBasics_.Primitive.Delegates.Proxies.Proxy__2_MG_1.Advanced;
using n20 = _CoreLibBasics_.Primitive.Delegates.Proxies.Proxy__0_MG_1.Advanced;
using n25 = _VL_Reactive_.Reactive.HoldLatest;
using n22 = _VL_Collections_.Collections.Sequence;
using n9 = global::System.Runtime.CompilerServices;
using n26 = global::System.Reactive.Joins;
using n35 = e5::VL.Lib.Collections;
using n24 = _VL_Reactive_.Reactive.Splitter;
using n23 = global::System.Reactive;
using n31 = _VL_Reactive_.Reactive.Advanced.Experimental;
using n40 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_Reactive_.Reactive
{
    [n1.ElementAttribute(TracingId = 199993U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EkOSuQ2SNXuLp8x04fZw4t", Name = "Where_EkOSuQ2SNXuLp8x04fZw4t")]
    [n2.SerializableAttribute]
    public class Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> Update<AdM>(T2 Value_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_SjE5lltg97cQFKfuzoMAbD.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            n7._Operations_.Update<T, bool>(Input_In: this.__p_Ssjfi90sriiLlxiKsrn0v5, Delegate_In: Predicate_In, Output_Out: out n6.FuncProxy<T, bool> Output_5, Result_Out: out n2.Func<T, bool> Result_6);
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_ULuvwavbBYdPyZYWnPJoBh.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n8._Operations_.Where<T>(Input_In: Input_4, Predicate_In: Result_6, Output_Out: out n2.IObservable<T> Output_9);
                return Output_9;
            }

            , Result_Out: out n2.IObservable<T> Result_10);
            Result_Out = Result_10;
            Changed_Out = Result_1;
            n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_3 != this.__p_SjE5lltg97cQFKfuzoMAbD || Output_5 != this.__p_Ssjfi90sriiLlxiKsrn0v5 || Output_11 != this.__p_ULuvwavbBYdPyZYWnPJoBh ? new Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T>(this)
                {__p_SjE5lltg97cQFKfuzoMAbD = Output_3, __p_Ssjfi90sriiLlxiKsrn0v5 = Output_5, __p_ULuvwavbBYdPyZYWnPJoBh = Output_11} : that_12;
            else
            {
                this.__p_SjE5lltg97cQFKfuzoMAbD = Output_3;
                this.__p_Ssjfi90sriiLlxiKsrn0v5 = Output_5;
                this.__p_ULuvwavbBYdPyZYWnPJoBh = Output_11;
            }

            return that_12;
        }

        public n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "SjE5lltg97cQFKfuzoMAbD", 200001U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Ssjfi90sriiLlxiKsrn0v5", 200062U);
            n7._Operations_.Create<T, bool>(Node_Context: Node_Context_4, Output_Out: out n6.FuncProxy<T, bool> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "ULuvwavbBYdPyZYWnPJoBh", 200035U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_6);
            n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> that_8 = this;
            this.__p_SjE5lltg97cQFKfuzoMAbD = Output_3;
            this.__p_Ssjfi90sriiLlxiKsrn0v5 = Output_5;
            this.__p_ULuvwavbBYdPyZYWnPJoBh = Output_7;
            return that_8;
        }

        public n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> that_1 = this;
            this.__p_SjE5lltg97cQFKfuzoMAbD = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_Ssjfi90sriiLlxiKsrn0v5 = default(n6.FuncProxy<T, bool>);
            this.__p_ULuvwavbBYdPyZYWnPJoBh = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SjE5lltg97cQFKfuzoMAbD);
            n1.CompilationHelper.SafeDispose(this.__p_Ssjfi90sriiLlxiKsrn0v5);
            n1.CompilationHelper.SafeDispose(this.__p_ULuvwavbBYdPyZYWnPJoBh);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200001U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "SjE5lltg97cQFKfuzoMAbD", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_SjE5lltg97cQFKfuzoMAbD;
        [n1.ElementAttribute(TracingId = 200062U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Ssjfi90sriiLlxiKsrn0v5", Name = "Proxy (1 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T, bool> __p_Ssjfi90sriiLlxiKsrn0v5;
        [n1.ElementAttribute(TracingId = 200035U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "ULuvwavbBYdPyZYWnPJoBh", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_ULuvwavbBYdPyZYWnPJoBh;
        public Where_EkOSuQ2SNXuLp8x04fZw4t(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Where_EkOSuQ2SNXuLp8x04fZw4t(Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> other): base(other)
        {
            this.__p_SjE5lltg97cQFKfuzoMAbD = other.__p_SjE5lltg97cQFKfuzoMAbD;
            this.__p_Ssjfi90sriiLlxiKsrn0v5 = other.__p_Ssjfi90sriiLlxiKsrn0v5;
            this.__p_ULuvwavbBYdPyZYWnPJoBh = other.__p_ULuvwavbBYdPyZYWnPJoBh;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SjE5lltg97cQFKfuzoMAbD", in __p_SjE5lltg97cQFKfuzoMAbD), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ssjfi90sriiLlxiKsrn0v5", in __p_Ssjfi90sriiLlxiKsrn0v5), n1.CompilationHelper.GetValueOrExisting(values, "__p_ULuvwavbBYdPyZYWnPJoBh", in __p_ULuvwavbBYdPyZYWnPJoBh));
        }

        internal Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_SjE5lltg97cQFKfuzoMAbD, n6.FuncProxy<T, bool> __p_Ssjfi90sriiLlxiKsrn0v5, n11.ToObservable_Switch_Factory_C<T> __p_ULuvwavbBYdPyZYWnPJoBh)
        {
            n3.Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SjE5lltg97cQFKfuzoMAbD != this.__p_SjE5lltg97cQFKfuzoMAbD || __p_Ssjfi90sriiLlxiKsrn0v5 != this.__p_Ssjfi90sriiLlxiKsrn0v5 || __p_ULuvwavbBYdPyZYWnPJoBh != this.__p_ULuvwavbBYdPyZYWnPJoBh ? new Where_EkOSuQ2SNXuLp8x04fZw4t<T2, T>(this)
                {__p_SjE5lltg97cQFKfuzoMAbD = __p_SjE5lltg97cQFKfuzoMAbD, __p_Ssjfi90sriiLlxiKsrn0v5 = __p_Ssjfi90sriiLlxiKsrn0v5, __p_ULuvwavbBYdPyZYWnPJoBh = __p_ULuvwavbBYdPyZYWnPJoBh} : that_0;
            else
            {
                this.__p_SjE5lltg97cQFKfuzoMAbD = __p_SjE5lltg97cQFKfuzoMAbD;
                this.__p_Ssjfi90sriiLlxiKsrn0v5 = __p_Ssjfi90sriiLlxiKsrn0v5;
                this.__p_ULuvwavbBYdPyZYWnPJoBh = __p_ULuvwavbBYdPyZYWnPJoBh;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200137U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "IShm0SBzszCN5V5IleChXI", Name = "Select_IShm0SBzszCN5V5IleChXI")]
    [n2.SerializableAttribute]
    public class Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T2>
    {
        [n5.CreateNewAttribute]
        public static n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Select_IShm0SBzszCN5V5IleChXI<T3, T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Select_IShm0SBzszCN5V5IleChXI<T3, T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> Update<AdM>(T3 Value_In, n2.Func<T2, int, T> Selector_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_UotNKNmBESfNe8kur5kc28.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T2> Input_4 = (n2.IObservable<T2>)Value_In;
            n13._Operations_.Update<T2, int, T>(Input_In: this.__p_EtpAlP4lrkmQTkxn2zodf3, Delegate_In: Selector_In, Output_Out: out n6.FuncProxy<T2, int, T> Output_5, Result_Out: out n2.Func<T2, int, T> Result_6);
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_COvdZUNr4wMMhxDyGHgHIt.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n8._Operations_.Select<T2, T>(Input_In: Input_4, Selector_In: Result_6, Output_Out: out n2.IObservable<T> Output_9);
                return Output_9;
            }

            , Result_Out: out n2.IObservable<T> Result_10);
            Result_Out = Result_10;
            Changed_Out = Result_1;
            n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_3 != this.__p_UotNKNmBESfNe8kur5kc28 || Output_5 != this.__p_EtpAlP4lrkmQTkxn2zodf3 || Output_11 != this.__p_COvdZUNr4wMMhxDyGHgHIt ? new Select_IShm0SBzszCN5V5IleChXI<T3, T2, T>(this)
                {__p_UotNKNmBESfNe8kur5kc28 = Output_3, __p_EtpAlP4lrkmQTkxn2zodf3 = Output_5, __p_COvdZUNr4wMMhxDyGHgHIt = Output_11} : that_12;
            else
            {
                this.__p_UotNKNmBESfNe8kur5kc28 = Output_3;
                this.__p_EtpAlP4lrkmQTkxn2zodf3 = Output_5;
                this.__p_COvdZUNr4wMMhxDyGHgHIt = Output_11;
            }

            return that_12;
        }

        public n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "UotNKNmBESfNe8kur5kc28", 200147U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "EtpAlP4lrkmQTkxn2zodf3", 200201U);
            n13._Operations_.Create<T2, int, T>(Node_Context: Node_Context_4, Output_Out: out n6.FuncProxy<T2, int, T> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "COvdZUNr4wMMhxDyGHgHIt", 200168U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_6);
            n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> that_8 = this;
            this.__p_UotNKNmBESfNe8kur5kc28 = Output_3;
            this.__p_EtpAlP4lrkmQTkxn2zodf3 = Output_5;
            this.__p_COvdZUNr4wMMhxDyGHgHIt = Output_7;
            return that_8;
        }

        public n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var w_0 = default(AdM);
            n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> that_1 = this;
            this.__p_UotNKNmBESfNe8kur5kc28 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_EtpAlP4lrkmQTkxn2zodf3 = default(n6.FuncProxy<T2, int, T>);
            this.__p_COvdZUNr4wMMhxDyGHgHIt = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UotNKNmBESfNe8kur5kc28);
            n1.CompilationHelper.SafeDispose(this.__p_EtpAlP4lrkmQTkxn2zodf3);
            n1.CompilationHelper.SafeDispose(this.__p_COvdZUNr4wMMhxDyGHgHIt);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200147U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "UotNKNmBESfNe8kur5kc28", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_UotNKNmBESfNe8kur5kc28;
        [n1.ElementAttribute(TracingId = 200201U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EtpAlP4lrkmQTkxn2zodf3", Name = "Proxy (2 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T2, int, T> __p_EtpAlP4lrkmQTkxn2zodf3;
        [n1.ElementAttribute(TracingId = 200168U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "COvdZUNr4wMMhxDyGHgHIt", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_COvdZUNr4wMMhxDyGHgHIt;
        public Select_IShm0SBzszCN5V5IleChXI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Select_IShm0SBzszCN5V5IleChXI(Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> other): base(other)
        {
            this.__p_UotNKNmBESfNe8kur5kc28 = other.__p_UotNKNmBESfNe8kur5kc28;
            this.__p_EtpAlP4lrkmQTkxn2zodf3 = other.__p_EtpAlP4lrkmQTkxn2zodf3;
            this.__p_COvdZUNr4wMMhxDyGHgHIt = other.__p_COvdZUNr4wMMhxDyGHgHIt;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UotNKNmBESfNe8kur5kc28", in __p_UotNKNmBESfNe8kur5kc28), n1.CompilationHelper.GetValueOrExisting(values, "__p_EtpAlP4lrkmQTkxn2zodf3", in __p_EtpAlP4lrkmQTkxn2zodf3), n1.CompilationHelper.GetValueOrExisting(values, "__p_COvdZUNr4wMMhxDyGHgHIt", in __p_COvdZUNr4wMMhxDyGHgHIt));
        }

        internal Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_UotNKNmBESfNe8kur5kc28, n6.FuncProxy<T2, int, T> __p_EtpAlP4lrkmQTkxn2zodf3, n11.ToObservable_Switch_Factory_C<T> __p_COvdZUNr4wMMhxDyGHgHIt)
        {
            n3.Select_IShm0SBzszCN5V5IleChXI<T3, T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UotNKNmBESfNe8kur5kc28 != this.__p_UotNKNmBESfNe8kur5kc28 || __p_EtpAlP4lrkmQTkxn2zodf3 != this.__p_EtpAlP4lrkmQTkxn2zodf3 || __p_COvdZUNr4wMMhxDyGHgHIt != this.__p_COvdZUNr4wMMhxDyGHgHIt ? new Select_IShm0SBzszCN5V5IleChXI<T3, T2, T>(this)
                {__p_UotNKNmBESfNe8kur5kc28 = __p_UotNKNmBESfNe8kur5kc28, __p_EtpAlP4lrkmQTkxn2zodf3 = __p_EtpAlP4lrkmQTkxn2zodf3, __p_COvdZUNr4wMMhxDyGHgHIt = __p_COvdZUNr4wMMhxDyGHgHIt} : that_0;
            else
            {
                this.__p_UotNKNmBESfNe8kur5kc28 = __p_UotNKNmBESfNe8kur5kc28;
                this.__p_EtpAlP4lrkmQTkxn2zodf3 = __p_EtpAlP4lrkmQTkxn2zodf3;
                this.__p_COvdZUNr4wMMhxDyGHgHIt = __p_COvdZUNr4wMMhxDyGHgHIt;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200279U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "LnnZZkStd9UPhJSxj0GRf7", Name = "Merge_LnnZZkStd9UPhJSxj0GRf7")]
    [n2.SerializableAttribute]
    public class Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T> where T3 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> Update<AdM>(T2 Value_In, T3 Value_2_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_RCnsqgwr4yfMTRFhvTZ39d.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_SXPV24IlAH2OOLaV6vUG6R.Update(Value_In: Value_2_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            var __fallback___9 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_HrI8PGSXkuuNKCckpaXyqv.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                n8._Operations_.Merge<T, T3>(Input_In: Input_8, Input_2_In: Value_2_In, Output_Out: out n2.IObservable<T> Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<T> Result_12);
            Result_Out = Result_12;
            Changed_Out = Output_7;
            n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_3 != this.__p_RCnsqgwr4yfMTRFhvTZ39d || Output_6 != this.__p_SXPV24IlAH2OOLaV6vUG6R || Output_13 != this.__p_HrI8PGSXkuuNKCckpaXyqv ? new Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3>(this)
                {__p_RCnsqgwr4yfMTRFhvTZ39d = Output_3, __p_SXPV24IlAH2OOLaV6vUG6R = Output_6, __p_HrI8PGSXkuuNKCckpaXyqv = Output_13} : that_14;
            else
            {
                this.__p_RCnsqgwr4yfMTRFhvTZ39d = Output_3;
                this.__p_SXPV24IlAH2OOLaV6vUG6R = Output_6;
                this.__p_HrI8PGSXkuuNKCckpaXyqv = Output_13;
            }

            return that_14;
        }

        public n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "RCnsqgwr4yfMTRFhvTZ39d", 200287U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "SXPV24IlAH2OOLaV6vUG6R", 200298U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "HrI8PGSXkuuNKCckpaXyqv", 200328U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> that_9 = this;
            this.__p_RCnsqgwr4yfMTRFhvTZ39d = Output_3;
            this.__p_SXPV24IlAH2OOLaV6vUG6R = Output_6;
            this.__p_HrI8PGSXkuuNKCckpaXyqv = Output_8;
            return that_9;
        }

        public n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> that_1 = this;
            this.__p_RCnsqgwr4yfMTRFhvTZ39d = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_SXPV24IlAH2OOLaV6vUG6R = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_HrI8PGSXkuuNKCckpaXyqv = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RCnsqgwr4yfMTRFhvTZ39d);
            n1.CompilationHelper.SafeDispose(this.__p_SXPV24IlAH2OOLaV6vUG6R);
            n1.CompilationHelper.SafeDispose(this.__p_HrI8PGSXkuuNKCckpaXyqv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200287U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "RCnsqgwr4yfMTRFhvTZ39d", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_RCnsqgwr4yfMTRFhvTZ39d;
        [n1.ElementAttribute(TracingId = 200298U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "SXPV24IlAH2OOLaV6vUG6R", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_SXPV24IlAH2OOLaV6vUG6R;
        [n1.ElementAttribute(TracingId = 200328U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HrI8PGSXkuuNKCckpaXyqv", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_HrI8PGSXkuuNKCckpaXyqv;
        public Merge_LnnZZkStd9UPhJSxj0GRf7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Merge_LnnZZkStd9UPhJSxj0GRf7(Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> other): base(other)
        {
            this.__p_RCnsqgwr4yfMTRFhvTZ39d = other.__p_RCnsqgwr4yfMTRFhvTZ39d;
            this.__p_SXPV24IlAH2OOLaV6vUG6R = other.__p_SXPV24IlAH2OOLaV6vUG6R;
            this.__p_HrI8PGSXkuuNKCckpaXyqv = other.__p_HrI8PGSXkuuNKCckpaXyqv;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RCnsqgwr4yfMTRFhvTZ39d", in __p_RCnsqgwr4yfMTRFhvTZ39d), n1.CompilationHelper.GetValueOrExisting(values, "__p_SXPV24IlAH2OOLaV6vUG6R", in __p_SXPV24IlAH2OOLaV6vUG6R), n1.CompilationHelper.GetValueOrExisting(values, "__p_HrI8PGSXkuuNKCckpaXyqv", in __p_HrI8PGSXkuuNKCckpaXyqv));
        }

        internal Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_RCnsqgwr4yfMTRFhvTZ39d, n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_SXPV24IlAH2OOLaV6vUG6R, n11.ToObservable_Switch_Factory_C<T> __p_HrI8PGSXkuuNKCckpaXyqv)
        {
            n3.Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RCnsqgwr4yfMTRFhvTZ39d != this.__p_RCnsqgwr4yfMTRFhvTZ39d || __p_SXPV24IlAH2OOLaV6vUG6R != this.__p_SXPV24IlAH2OOLaV6vUG6R || __p_HrI8PGSXkuuNKCckpaXyqv != this.__p_HrI8PGSXkuuNKCckpaXyqv ? new Merge_LnnZZkStd9UPhJSxj0GRf7<T2, T, T3>(this)
                {__p_RCnsqgwr4yfMTRFhvTZ39d = __p_RCnsqgwr4yfMTRFhvTZ39d, __p_SXPV24IlAH2OOLaV6vUG6R = __p_SXPV24IlAH2OOLaV6vUG6R, __p_HrI8PGSXkuuNKCckpaXyqv = __p_HrI8PGSXkuuNKCckpaXyqv} : that_0;
            else
            {
                this.__p_RCnsqgwr4yfMTRFhvTZ39d = __p_RCnsqgwr4yfMTRFhvTZ39d;
                this.__p_SXPV24IlAH2OOLaV6vUG6R = __p_SXPV24IlAH2OOLaV6vUG6R;
                this.__p_HrI8PGSXkuuNKCckpaXyqv = __p_HrI8PGSXkuuNKCckpaXyqv;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200397U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "H0f7FR6DlKkP89i5do6r8X", Name = "Interval_H0f7FR6DlKkP89i5do6r8X")]
    [n2.SerializableAttribute]
    public class Interval_H0f7FR6DlKkP89i5do6r8X : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n3.Interval_H0f7FR6DlKkP89i5do6r8X Create(n1.NodeContext Node_Context)
        {
            var instance = new Interval_H0f7FR6DlKkP89i5do6r8X(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Interval_H0f7FR6DlKkP89i5do6r8X CreateDefault()
        {
            var instance = new Interval_H0f7FR6DlKkP89i5do6r8X(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Interval_H0f7FR6DlKkP89i5do6r8X Update(n2.TimeSpan Period_In, out n2.IObservable<long> Result_Out, out bool Changed_Out)
        {
            var Output_2 = this.__p_PVeJmF1npuKPDwW0qQHnGa.Update(Value_In: Period_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var __fallback___3 = n1.ServiceRegistry.Current;
            var Output_7 = this.__p_Bmj9D2S6YAYO6zcVwVbTz6.Update<n2.IObservable<long>, n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Send_In: Result_0, Factory_In: () =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                var Result_5 = n14.Observable.Interval(period: Period_In);
                return Result_5;
            }

            , Result_Out: out n2.IObservable<long> Result_6);
            Result_Out = Result_6;
            Changed_Out = Result_0;
            n3.Interval_H0f7FR6DlKkP89i5do6r8X that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_2 != this.__p_PVeJmF1npuKPDwW0qQHnGa || Output_7 != this.__p_Bmj9D2S6YAYO6zcVwVbTz6 ? new Interval_H0f7FR6DlKkP89i5do6r8X(this)
                {__p_PVeJmF1npuKPDwW0qQHnGa = Output_2, __p_Bmj9D2S6YAYO6zcVwVbTz6 = Output_7} : that_8;
            else
            {
                this.__p_PVeJmF1npuKPDwW0qQHnGa = Output_2;
                this.__p_Bmj9D2S6YAYO6zcVwVbTz6 = Output_7;
            }

            return that_8;
        }

        public n3.Interval_H0f7FR6DlKkP89i5do6r8X __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "PVeJmF1npuKPDwW0qQHnGa", 200402U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Bmj9D2S6YAYO6zcVwVbTz6", 200410U);
            var Output_4 = n11.ToObservable_Switch_Factory_C<long>.Create(Node_Context: Node_Context_3);
            n3.Interval_H0f7FR6DlKkP89i5do6r8X that_5 = this;
            this.__p_PVeJmF1npuKPDwW0qQHnGa = Output_2;
            this.__p_Bmj9D2S6YAYO6zcVwVbTz6 = Output_4;
            return that_5;
        }

        public n3.Interval_H0f7FR6DlKkP89i5do6r8X __CreateDefault__()
        {
            n3.Interval_H0f7FR6DlKkP89i5do6r8X that_0 = this;
            this.__p_PVeJmF1npuKPDwW0qQHnGa = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_Bmj9D2S6YAYO6zcVwVbTz6 = n11.ToObservable_Switch_Factory_C<long>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PVeJmF1npuKPDwW0qQHnGa);
            n1.CompilationHelper.SafeDispose(this.__p_Bmj9D2S6YAYO6zcVwVbTz6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200402U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "PVeJmF1npuKPDwW0qQHnGa", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_PVeJmF1npuKPDwW0qQHnGa;
        [n1.ElementAttribute(TracingId = 200410U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Bmj9D2S6YAYO6zcVwVbTz6", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<long> __p_Bmj9D2S6YAYO6zcVwVbTz6;
        public Interval_H0f7FR6DlKkP89i5do6r8X(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Interval_H0f7FR6DlKkP89i5do6r8X(Interval_H0f7FR6DlKkP89i5do6r8X other): base(other)
        {
            this.__p_PVeJmF1npuKPDwW0qQHnGa = other.__p_PVeJmF1npuKPDwW0qQHnGa;
            this.__p_Bmj9D2S6YAYO6zcVwVbTz6 = other.__p_Bmj9D2S6YAYO6zcVwVbTz6;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PVeJmF1npuKPDwW0qQHnGa", in __p_PVeJmF1npuKPDwW0qQHnGa), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bmj9D2S6YAYO6zcVwVbTz6", in __p_Bmj9D2S6YAYO6zcVwVbTz6));
        }

        internal Interval_H0f7FR6DlKkP89i5do6r8X __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_PVeJmF1npuKPDwW0qQHnGa, n11.ToObservable_Switch_Factory_C<long> __p_Bmj9D2S6YAYO6zcVwVbTz6)
        {
            n3.Interval_H0f7FR6DlKkP89i5do6r8X that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PVeJmF1npuKPDwW0qQHnGa != this.__p_PVeJmF1npuKPDwW0qQHnGa || __p_Bmj9D2S6YAYO6zcVwVbTz6 != this.__p_Bmj9D2S6YAYO6zcVwVbTz6 ? new Interval_H0f7FR6DlKkP89i5do6r8X(this)
                {__p_PVeJmF1npuKPDwW0qQHnGa = __p_PVeJmF1npuKPDwW0qQHnGa, __p_Bmj9D2S6YAYO6zcVwVbTz6 = __p_Bmj9D2S6YAYO6zcVwVbTz6} : that_0;
            else
            {
                this.__p_PVeJmF1npuKPDwW0qQHnGa = __p_PVeJmF1npuKPDwW0qQHnGa;
                this.__p_Bmj9D2S6YAYO6zcVwVbTz6 = __p_Bmj9D2S6YAYO6zcVwVbTz6;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200464U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "M9sbDTDlF27NjjkngIh8VW", Name = "Switch_M9sbDTDlF27NjjkngIh8VW")]
    [n2.SerializableAttribute]
    public class Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<n2.IObservable<T>>
    {
        [n5.CreateNewAttribute]
        public static n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Switch_M9sbDTDlF27NjjkngIh8VW<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> CreateDefault()
        {
            var instance = new Switch_M9sbDTDlF27NjjkngIh8VW<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> Update(T2 Value_In, out n2.IObservable<T> Result_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_CkcEUYX5FSzOX3wVpSftMd;
            if (manager_2 is null)
            {
                manager_2 = new n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple<n2.IObservable<T>>>(n2.ValueTuple.Create(n8._Operations_.CreateDefault<T>()));
            }

            var inputs_3 = n2.ValueTuple.Create(Value_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n2.IObservable<n2.IObservable<T>> Input_7 = (n2.IObservable<n2.IObservable<T>>)Value_In;
                n8._Operations_.Switch<T>(Input_In: Input_7, Output_Out: out n2.IObservable<T> Output_8);
                outputs_4 = n2.ValueTuple.Create(Output_8);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_9 = outputs_4.Item1;
            Result_Out = __auto_9;
            n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = manager_2 != this.__cache_CkcEUYX5FSzOX3wVpSftMd ? new Switch_M9sbDTDlF27NjjkngIh8VW<T2, T>(this)
                {__cache_CkcEUYX5FSzOX3wVpSftMd = manager_2} : that_10;
            else
            {
                this.__cache_CkcEUYX5FSzOX3wVpSftMd = manager_2;
            }

            return that_10;
        }

        public n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> that_0 = this;
            this.__cache_CkcEUYX5FSzOX3wVpSftMd = null;
            return that_0;
        }

        public n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> __CreateDefault__()
        {
            n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> that_0 = this;
            this.__cache_CkcEUYX5FSzOX3wVpSftMd = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CkcEUYX5FSzOX3wVpSftMd);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200471U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "CkcEUYX5FSzOX3wVpSftMd", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple<n2.IObservable<T>>> __cache_CkcEUYX5FSzOX3wVpSftMd = null;
        public Switch_M9sbDTDlF27NjjkngIh8VW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Switch_M9sbDTDlF27NjjkngIh8VW(Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> other): base(other)
        {
            this.__cache_CkcEUYX5FSzOX3wVpSftMd = other.__cache_CkcEUYX5FSzOX3wVpSftMd;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CkcEUYX5FSzOX3wVpSftMd", in __cache_CkcEUYX5FSzOX3wVpSftMd));
        }

        internal Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> __WITH__(n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple<n2.IObservable<T>>> __cache_CkcEUYX5FSzOX3wVpSftMd)
        {
            n3.Switch_M9sbDTDlF27NjjkngIh8VW<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CkcEUYX5FSzOX3wVpSftMd != this.__cache_CkcEUYX5FSzOX3wVpSftMd ? new Switch_M9sbDTDlF27NjjkngIh8VW<T2, T>(this)
                {__cache_CkcEUYX5FSzOX3wVpSftMd = __cache_CkcEUYX5FSzOX3wVpSftMd} : that_0;
            else
            {
                this.__cache_CkcEUYX5FSzOX3wVpSftMd = __cache_CkcEUYX5FSzOX3wVpSftMd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200515U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "N6evgN1VndeQcCuXCwH8GU", Name = "Delay_N6evgN1VndeQcCuXCwH8GU")]
    [n2.SerializableAttribute]
    public class Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Delay_N6evgN1VndeQcCuXCwH8GU<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Delay_N6evgN1VndeQcCuXCwH8GU<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> Update<AdM>(T2 Value_In, n2.TimeSpan Due_Time_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_DjUPQQaJ8rUNG62V9ljIi1.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_HsvyZ97mojOPtJe5iu6AGm.Update(Value_In: Due_Time_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            var __fallback___9 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_G0Cp6Z6q9dXMdMOTi5gTSn.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                n8._Operations_.Delay<T>(Input_In: Input_8, Due_Time_In: Due_Time_In, Output_Out: out n2.IObservable<T> Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<T> Result_12);
            Result_Out = Result_12;
            Changed_Out = Output_7;
            n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_3 != this.__p_DjUPQQaJ8rUNG62V9ljIi1 || Output_6 != this.__p_HsvyZ97mojOPtJe5iu6AGm || Output_13 != this.__p_G0Cp6Z6q9dXMdMOTi5gTSn ? new Delay_N6evgN1VndeQcCuXCwH8GU<T2, T>(this)
                {__p_DjUPQQaJ8rUNG62V9ljIi1 = Output_3, __p_HsvyZ97mojOPtJe5iu6AGm = Output_6, __p_G0Cp6Z6q9dXMdMOTi5gTSn = Output_13} : that_14;
            else
            {
                this.__p_DjUPQQaJ8rUNG62V9ljIi1 = Output_3;
                this.__p_HsvyZ97mojOPtJe5iu6AGm = Output_6;
                this.__p_G0Cp6Z6q9dXMdMOTi5gTSn = Output_13;
            }

            return that_14;
        }

        public n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "DjUPQQaJ8rUNG62V9ljIi1", 200519U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "HsvyZ97mojOPtJe5iu6AGm", 200529U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "G0Cp6Z6q9dXMdMOTi5gTSn", 200550U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> that_9 = this;
            this.__p_DjUPQQaJ8rUNG62V9ljIi1 = Output_3;
            this.__p_HsvyZ97mojOPtJe5iu6AGm = Output_6;
            this.__p_G0Cp6Z6q9dXMdMOTi5gTSn = Output_8;
            return that_9;
        }

        public n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> that_1 = this;
            this.__p_DjUPQQaJ8rUNG62V9ljIi1 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_HsvyZ97mojOPtJe5iu6AGm = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_G0Cp6Z6q9dXMdMOTi5gTSn = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DjUPQQaJ8rUNG62V9ljIi1);
            n1.CompilationHelper.SafeDispose(this.__p_HsvyZ97mojOPtJe5iu6AGm);
            n1.CompilationHelper.SafeDispose(this.__p_G0Cp6Z6q9dXMdMOTi5gTSn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200519U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DjUPQQaJ8rUNG62V9ljIi1", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_DjUPQQaJ8rUNG62V9ljIi1;
        [n1.ElementAttribute(TracingId = 200529U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HsvyZ97mojOPtJe5iu6AGm", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_HsvyZ97mojOPtJe5iu6AGm;
        [n1.ElementAttribute(TracingId = 200550U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "G0Cp6Z6q9dXMdMOTi5gTSn", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_G0Cp6Z6q9dXMdMOTi5gTSn;
        public Delay_N6evgN1VndeQcCuXCwH8GU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Delay_N6evgN1VndeQcCuXCwH8GU(Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> other): base(other)
        {
            this.__p_DjUPQQaJ8rUNG62V9ljIi1 = other.__p_DjUPQQaJ8rUNG62V9ljIi1;
            this.__p_HsvyZ97mojOPtJe5iu6AGm = other.__p_HsvyZ97mojOPtJe5iu6AGm;
            this.__p_G0Cp6Z6q9dXMdMOTi5gTSn = other.__p_G0Cp6Z6q9dXMdMOTi5gTSn;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DjUPQQaJ8rUNG62V9ljIi1", in __p_DjUPQQaJ8rUNG62V9ljIi1), n1.CompilationHelper.GetValueOrExisting(values, "__p_HsvyZ97mojOPtJe5iu6AGm", in __p_HsvyZ97mojOPtJe5iu6AGm), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0Cp6Z6q9dXMdMOTi5gTSn", in __p_G0Cp6Z6q9dXMdMOTi5gTSn));
        }

        internal Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_DjUPQQaJ8rUNG62V9ljIi1, n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_HsvyZ97mojOPtJe5iu6AGm, n11.ToObservable_Switch_Factory_C<T> __p_G0Cp6Z6q9dXMdMOTi5gTSn)
        {
            n3.Delay_N6evgN1VndeQcCuXCwH8GU<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DjUPQQaJ8rUNG62V9ljIi1 != this.__p_DjUPQQaJ8rUNG62V9ljIi1 || __p_HsvyZ97mojOPtJe5iu6AGm != this.__p_HsvyZ97mojOPtJe5iu6AGm || __p_G0Cp6Z6q9dXMdMOTi5gTSn != this.__p_G0Cp6Z6q9dXMdMOTi5gTSn ? new Delay_N6evgN1VndeQcCuXCwH8GU<T2, T>(this)
                {__p_DjUPQQaJ8rUNG62V9ljIi1 = __p_DjUPQQaJ8rUNG62V9ljIi1, __p_HsvyZ97mojOPtJe5iu6AGm = __p_HsvyZ97mojOPtJe5iu6AGm, __p_G0Cp6Z6q9dXMdMOTi5gTSn = __p_G0Cp6Z6q9dXMdMOTi5gTSn} : that_0;
            else
            {
                this.__p_DjUPQQaJ8rUNG62V9ljIi1 = __p_DjUPQQaJ8rUNG62V9ljIi1;
                this.__p_HsvyZ97mojOPtJe5iu6AGm = __p_HsvyZ97mojOPtJe5iu6AGm;
                this.__p_G0Cp6Z6q9dXMdMOTi5gTSn = __p_G0Cp6Z6q9dXMdMOTi5gTSn;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200599U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Dh9N8ErVIdWPbrAzdG3zju", Name = "Scan_Dh9N8ErVIdWPbrAzdG3zju")]
    [n2.SerializableAttribute]
    public class Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> Update<AdM>(T3 Value_In, T2 Seed_In, n2.Func<T2, T, T2> Accumulator_In, out n2.IObservable<T2> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T2>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_JTtpv9ETBpNPYElcUjSaMH.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_C15PJO0w60COlaAJHC3RGP.Update(Value_In: Seed_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            n13._Operations_.Update<T2, T, T2>(Input_In: this.__p_FFldYSxAnieLoc7pirHnuT, Delegate_In: Accumulator_In, Output_Out: out n6.FuncProxy<T2, T, T2> Output_9, Result_Out: out n2.Func<T2, T, T2> Result_10);
            var __fallback___11 = n1.ServiceRegistry.Current;
            var Output_15 = this.__p_IkgMnkFl7xcOEPggsA0VEU.Update<n2.IObservable<T2>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_12 = __fallback___11.MakeCurrentIfNone();
                n8._Operations_.Scan<T, T2>(Input_In: Input_8, Seed_In: Seed_In, Accumulator_In: Result_10, Output_Out: out n2.IObservable<T2> Output_13);
                return Output_13;
            }

            , Result_Out: out n2.IObservable<T2> Result_14);
            Result_Out = Result_14;
            n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = Output_3 != this.__p_JTtpv9ETBpNPYElcUjSaMH || Output_6 != this.__p_C15PJO0w60COlaAJHC3RGP || Output_9 != this.__p_FFldYSxAnieLoc7pirHnuT || Output_15 != this.__p_IkgMnkFl7xcOEPggsA0VEU ? new Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2>(this)
                {__p_JTtpv9ETBpNPYElcUjSaMH = Output_3, __p_C15PJO0w60COlaAJHC3RGP = Output_6, __p_FFldYSxAnieLoc7pirHnuT = Output_9, __p_IkgMnkFl7xcOEPggsA0VEU = Output_15} : that_16;
            else
            {
                this.__p_JTtpv9ETBpNPYElcUjSaMH = Output_3;
                this.__p_C15PJO0w60COlaAJHC3RGP = Output_6;
                this.__p_FFldYSxAnieLoc7pirHnuT = Output_9;
                this.__p_IkgMnkFl7xcOEPggsA0VEU = Output_15;
            }

            return that_16;
        }

        public n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "JTtpv9ETBpNPYElcUjSaMH", 200603U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "C15PJO0w60COlaAJHC3RGP", 200617U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "FFldYSxAnieLoc7pirHnuT", 200632U);
            n13._Operations_.Create<T2, T, T2>(Node_Context: Node_Context_7, Output_Out: out n6.FuncProxy<T2, T, T2> Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "IkgMnkFl7xcOEPggsA0VEU", 200621U);
            var Output_10 = n11.ToObservable_Switch_Factory_C<T2>.Create(Node_Context: Node_Context_9);
            n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> that_11 = this;
            this.__p_JTtpv9ETBpNPYElcUjSaMH = Output_3;
            this.__p_C15PJO0w60COlaAJHC3RGP = Output_6;
            this.__p_FFldYSxAnieLoc7pirHnuT = Output_8;
            this.__p_IkgMnkFl7xcOEPggsA0VEU = Output_10;
            return that_11;
        }

        public n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> that_1 = this;
            this.__p_JTtpv9ETBpNPYElcUjSaMH = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_C15PJO0w60COlaAJHC3RGP = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_FFldYSxAnieLoc7pirHnuT = default(n6.FuncProxy<T2, T, T2>);
            this.__p_IkgMnkFl7xcOEPggsA0VEU = n11.ToObservable_Switch_Factory_C<T2>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JTtpv9ETBpNPYElcUjSaMH);
            n1.CompilationHelper.SafeDispose(this.__p_C15PJO0w60COlaAJHC3RGP);
            n1.CompilationHelper.SafeDispose(this.__p_FFldYSxAnieLoc7pirHnuT);
            n1.CompilationHelper.SafeDispose(this.__p_IkgMnkFl7xcOEPggsA0VEU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200603U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "JTtpv9ETBpNPYElcUjSaMH", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_JTtpv9ETBpNPYElcUjSaMH;
        [n1.ElementAttribute(TracingId = 200617U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "C15PJO0w60COlaAJHC3RGP", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_C15PJO0w60COlaAJHC3RGP;
        [n1.ElementAttribute(TracingId = 200632U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "FFldYSxAnieLoc7pirHnuT", Name = "Proxy (2 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T2, T, T2> __p_FFldYSxAnieLoc7pirHnuT;
        [n1.ElementAttribute(TracingId = 200621U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "IkgMnkFl7xcOEPggsA0VEU", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T2> __p_IkgMnkFl7xcOEPggsA0VEU;
        public Scan_Dh9N8ErVIdWPbrAzdG3zju(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Scan_Dh9N8ErVIdWPbrAzdG3zju(Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> other): base(other)
        {
            this.__p_JTtpv9ETBpNPYElcUjSaMH = other.__p_JTtpv9ETBpNPYElcUjSaMH;
            this.__p_C15PJO0w60COlaAJHC3RGP = other.__p_C15PJO0w60COlaAJHC3RGP;
            this.__p_FFldYSxAnieLoc7pirHnuT = other.__p_FFldYSxAnieLoc7pirHnuT;
            this.__p_IkgMnkFl7xcOEPggsA0VEU = other.__p_IkgMnkFl7xcOEPggsA0VEU;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JTtpv9ETBpNPYElcUjSaMH", in __p_JTtpv9ETBpNPYElcUjSaMH), n1.CompilationHelper.GetValueOrExisting(values, "__p_C15PJO0w60COlaAJHC3RGP", in __p_C15PJO0w60COlaAJHC3RGP), n1.CompilationHelper.GetValueOrExisting(values, "__p_FFldYSxAnieLoc7pirHnuT", in __p_FFldYSxAnieLoc7pirHnuT), n1.CompilationHelper.GetValueOrExisting(values, "__p_IkgMnkFl7xcOEPggsA0VEU", in __p_IkgMnkFl7xcOEPggsA0VEU));
        }

        internal Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_JTtpv9ETBpNPYElcUjSaMH, n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_C15PJO0w60COlaAJHC3RGP, n6.FuncProxy<T2, T, T2> __p_FFldYSxAnieLoc7pirHnuT, n11.ToObservable_Switch_Factory_C<T2> __p_IkgMnkFl7xcOEPggsA0VEU)
        {
            n3.Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JTtpv9ETBpNPYElcUjSaMH != this.__p_JTtpv9ETBpNPYElcUjSaMH || __p_C15PJO0w60COlaAJHC3RGP != this.__p_C15PJO0w60COlaAJHC3RGP || __p_FFldYSxAnieLoc7pirHnuT != this.__p_FFldYSxAnieLoc7pirHnuT || __p_IkgMnkFl7xcOEPggsA0VEU != this.__p_IkgMnkFl7xcOEPggsA0VEU ? new Scan_Dh9N8ErVIdWPbrAzdG3zju<T3, T, T2>(this)
                {__p_JTtpv9ETBpNPYElcUjSaMH = __p_JTtpv9ETBpNPYElcUjSaMH, __p_C15PJO0w60COlaAJHC3RGP = __p_C15PJO0w60COlaAJHC3RGP, __p_FFldYSxAnieLoc7pirHnuT = __p_FFldYSxAnieLoc7pirHnuT, __p_IkgMnkFl7xcOEPggsA0VEU = __p_IkgMnkFl7xcOEPggsA0VEU} : that_0;
            else
            {
                this.__p_JTtpv9ETBpNPYElcUjSaMH = __p_JTtpv9ETBpNPYElcUjSaMH;
                this.__p_C15PJO0w60COlaAJHC3RGP = __p_C15PJO0w60COlaAJHC3RGP;
                this.__p_FFldYSxAnieLoc7pirHnuT = __p_FFldYSxAnieLoc7pirHnuT;
                this.__p_IkgMnkFl7xcOEPggsA0VEU = __p_IkgMnkFl7xcOEPggsA0VEU;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200660U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "TaON6llvjjFNAoxwHbG7Qy", Name = "Select_Many_TaON6llvjjFNAoxwHbG7Qy")]
    [n2.SerializableAttribute]
    public class Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T2>
    {
        [n5.CreateNewAttribute]
        public static n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> Update<AdM>(T3 Value_In, n2.Func<T2, int, n2.IObservable<T>> Selector_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_LVByJ4y4KjILUDEtNvULGL.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T2> Input_4 = (n2.IObservable<T2>)Value_In;
            n13._Operations_.Update<T2, int, n2.IObservable<T>>(Input_In: this.__p_HGq1x4gHwtULr2IrlJ566j, Delegate_In: Selector_In, Output_Out: out n6.FuncProxy<T2, int, n2.IObservable<T>> Output_5, Result_Out: out n2.Func<T2, int, n2.IObservable<T>> Result_6);
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_B5ZqtlftgKwLUFall038xy.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n8._Operations_.Select_Many<T2, T>(Input_In: Input_4, Selector_In: Result_6, Output_Out: out n2.IObservable<T> Output_9);
                return Output_9;
            }

            , Result_Out: out n2.IObservable<T> Result_10);
            Result_Out = Result_10;
            Changed_Out = Result_1;
            n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_3 != this.__p_LVByJ4y4KjILUDEtNvULGL || Output_5 != this.__p_HGq1x4gHwtULr2IrlJ566j || Output_11 != this.__p_B5ZqtlftgKwLUFall038xy ? new Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T>(this)
                {__p_LVByJ4y4KjILUDEtNvULGL = Output_3, __p_HGq1x4gHwtULr2IrlJ566j = Output_5, __p_B5ZqtlftgKwLUFall038xy = Output_11} : that_12;
            else
            {
                this.__p_LVByJ4y4KjILUDEtNvULGL = Output_3;
                this.__p_HGq1x4gHwtULr2IrlJ566j = Output_5;
                this.__p_B5ZqtlftgKwLUFall038xy = Output_11;
            }

            return that_12;
        }

        public n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "LVByJ4y4KjILUDEtNvULGL", 200664U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "HGq1x4gHwtULr2IrlJ566j", 200681U);
            n13._Operations_.Create<T2, int, n2.IObservable<T>>(Node_Context: Node_Context_4, Output_Out: out n6.FuncProxy<T2, int, n2.IObservable<T>> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "B5ZqtlftgKwLUFall038xy", 200671U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_6);
            n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> that_8 = this;
            this.__p_LVByJ4y4KjILUDEtNvULGL = Output_3;
            this.__p_HGq1x4gHwtULr2IrlJ566j = Output_5;
            this.__p_B5ZqtlftgKwLUFall038xy = Output_7;
            return that_8;
        }

        public n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var w_0 = default(AdM);
            n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> that_1 = this;
            this.__p_LVByJ4y4KjILUDEtNvULGL = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_HGq1x4gHwtULr2IrlJ566j = default(n6.FuncProxy<T2, int, n2.IObservable<T>>);
            this.__p_B5ZqtlftgKwLUFall038xy = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LVByJ4y4KjILUDEtNvULGL);
            n1.CompilationHelper.SafeDispose(this.__p_HGq1x4gHwtULr2IrlJ566j);
            n1.CompilationHelper.SafeDispose(this.__p_B5ZqtlftgKwLUFall038xy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200664U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "LVByJ4y4KjILUDEtNvULGL", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_LVByJ4y4KjILUDEtNvULGL;
        [n1.ElementAttribute(TracingId = 200681U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HGq1x4gHwtULr2IrlJ566j", Name = "Proxy (2 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T2, int, n2.IObservable<T>> __p_HGq1x4gHwtULr2IrlJ566j;
        [n1.ElementAttribute(TracingId = 200671U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "B5ZqtlftgKwLUFall038xy", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_B5ZqtlftgKwLUFall038xy;
        public Select_Many_TaON6llvjjFNAoxwHbG7Qy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Select_Many_TaON6llvjjFNAoxwHbG7Qy(Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> other): base(other)
        {
            this.__p_LVByJ4y4KjILUDEtNvULGL = other.__p_LVByJ4y4KjILUDEtNvULGL;
            this.__p_HGq1x4gHwtULr2IrlJ566j = other.__p_HGq1x4gHwtULr2IrlJ566j;
            this.__p_B5ZqtlftgKwLUFall038xy = other.__p_B5ZqtlftgKwLUFall038xy;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LVByJ4y4KjILUDEtNvULGL", in __p_LVByJ4y4KjILUDEtNvULGL), n1.CompilationHelper.GetValueOrExisting(values, "__p_HGq1x4gHwtULr2IrlJ566j", in __p_HGq1x4gHwtULr2IrlJ566j), n1.CompilationHelper.GetValueOrExisting(values, "__p_B5ZqtlftgKwLUFall038xy", in __p_B5ZqtlftgKwLUFall038xy));
        }

        internal Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_LVByJ4y4KjILUDEtNvULGL, n6.FuncProxy<T2, int, n2.IObservable<T>> __p_HGq1x4gHwtULr2IrlJ566j, n11.ToObservable_Switch_Factory_C<T> __p_B5ZqtlftgKwLUFall038xy)
        {
            n3.Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LVByJ4y4KjILUDEtNvULGL != this.__p_LVByJ4y4KjILUDEtNvULGL || __p_HGq1x4gHwtULr2IrlJ566j != this.__p_HGq1x4gHwtULr2IrlJ566j || __p_B5ZqtlftgKwLUFall038xy != this.__p_B5ZqtlftgKwLUFall038xy ? new Select_Many_TaON6llvjjFNAoxwHbG7Qy<T3, T2, T>(this)
                {__p_LVByJ4y4KjILUDEtNvULGL = __p_LVByJ4y4KjILUDEtNvULGL, __p_HGq1x4gHwtULr2IrlJ566j = __p_HGq1x4gHwtULr2IrlJ566j, __p_B5ZqtlftgKwLUFall038xy = __p_B5ZqtlftgKwLUFall038xy} : that_0;
            else
            {
                this.__p_LVByJ4y4KjILUDEtNvULGL = __p_LVByJ4y4KjILUDEtNvULGL;
                this.__p_HGq1x4gHwtULr2IrlJ566j = __p_HGq1x4gHwtULr2IrlJ566j;
                this.__p_B5ZqtlftgKwLUFall038xy = __p_B5ZqtlftgKwLUFall038xy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200706U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Vw4wezAoeUcN4n1nx1FBq2", Name = "Skip_Vw4wezAoeUcN4n1nx1FBq2")]
    [n2.SerializableAttribute]
    public class Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> Update<AdM>(T2 Value_In, int Count_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_A0HOq36nTxZMBY78WqonwQ.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_UkUH1n8VrfaLPWEledB39y.Update(Value_In: Count_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            var __fallback___9 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_KA8N1Yh5JhjPGpmA7MqOl5.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                n8._Operations_.Skip<T>(Input_In: Input_8, Count_In: Count_In, Output_Out: out n2.IObservable<T> Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<T> Result_12);
            Result_Out = Result_12;
            Changed_Out = Output_7;
            n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_3 != this.__p_A0HOq36nTxZMBY78WqonwQ || Output_6 != this.__p_UkUH1n8VrfaLPWEledB39y || Output_13 != this.__p_KA8N1Yh5JhjPGpmA7MqOl5 ? new Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T>(this)
                {__p_A0HOq36nTxZMBY78WqonwQ = Output_3, __p_UkUH1n8VrfaLPWEledB39y = Output_6, __p_KA8N1Yh5JhjPGpmA7MqOl5 = Output_13} : that_14;
            else
            {
                this.__p_A0HOq36nTxZMBY78WqonwQ = Output_3;
                this.__p_UkUH1n8VrfaLPWEledB39y = Output_6;
                this.__p_KA8N1Yh5JhjPGpmA7MqOl5 = Output_13;
            }

            return that_14;
        }

        public n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "A0HOq36nTxZMBY78WqonwQ", 200710U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "UkUH1n8VrfaLPWEledB39y", 200716U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "KA8N1Yh5JhjPGpmA7MqOl5", 200725U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> that_9 = this;
            this.__p_A0HOq36nTxZMBY78WqonwQ = Output_3;
            this.__p_UkUH1n8VrfaLPWEledB39y = Output_6;
            this.__p_KA8N1Yh5JhjPGpmA7MqOl5 = Output_8;
            return that_9;
        }

        public n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> that_1 = this;
            this.__p_A0HOq36nTxZMBY78WqonwQ = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_UkUH1n8VrfaLPWEledB39y = n10.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_KA8N1Yh5JhjPGpmA7MqOl5 = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_A0HOq36nTxZMBY78WqonwQ);
            n1.CompilationHelper.SafeDispose(this.__p_UkUH1n8VrfaLPWEledB39y);
            n1.CompilationHelper.SafeDispose(this.__p_KA8N1Yh5JhjPGpmA7MqOl5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200710U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "A0HOq36nTxZMBY78WqonwQ", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_A0HOq36nTxZMBY78WqonwQ;
        [n1.ElementAttribute(TracingId = 200716U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "UkUH1n8VrfaLPWEledB39y", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_UkUH1n8VrfaLPWEledB39y;
        [n1.ElementAttribute(TracingId = 200725U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "KA8N1Yh5JhjPGpmA7MqOl5", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_KA8N1Yh5JhjPGpmA7MqOl5;
        public Skip_Vw4wezAoeUcN4n1nx1FBq2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Skip_Vw4wezAoeUcN4n1nx1FBq2(Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> other): base(other)
        {
            this.__p_A0HOq36nTxZMBY78WqonwQ = other.__p_A0HOq36nTxZMBY78WqonwQ;
            this.__p_UkUH1n8VrfaLPWEledB39y = other.__p_UkUH1n8VrfaLPWEledB39y;
            this.__p_KA8N1Yh5JhjPGpmA7MqOl5 = other.__p_KA8N1Yh5JhjPGpmA7MqOl5;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_A0HOq36nTxZMBY78WqonwQ", in __p_A0HOq36nTxZMBY78WqonwQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_UkUH1n8VrfaLPWEledB39y", in __p_UkUH1n8VrfaLPWEledB39y), n1.CompilationHelper.GetValueOrExisting(values, "__p_KA8N1Yh5JhjPGpmA7MqOl5", in __p_KA8N1Yh5JhjPGpmA7MqOl5));
        }

        internal Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_A0HOq36nTxZMBY78WqonwQ, n10.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_UkUH1n8VrfaLPWEledB39y, n11.ToObservable_Switch_Factory_C<T> __p_KA8N1Yh5JhjPGpmA7MqOl5)
        {
            n3.Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_A0HOq36nTxZMBY78WqonwQ != this.__p_A0HOq36nTxZMBY78WqonwQ || __p_UkUH1n8VrfaLPWEledB39y != this.__p_UkUH1n8VrfaLPWEledB39y || __p_KA8N1Yh5JhjPGpmA7MqOl5 != this.__p_KA8N1Yh5JhjPGpmA7MqOl5 ? new Skip_Vw4wezAoeUcN4n1nx1FBq2<T2, T>(this)
                {__p_A0HOq36nTxZMBY78WqonwQ = __p_A0HOq36nTxZMBY78WqonwQ, __p_UkUH1n8VrfaLPWEledB39y = __p_UkUH1n8VrfaLPWEledB39y, __p_KA8N1Yh5JhjPGpmA7MqOl5 = __p_KA8N1Yh5JhjPGpmA7MqOl5} : that_0;
            else
            {
                this.__p_A0HOq36nTxZMBY78WqonwQ = __p_A0HOq36nTxZMBY78WqonwQ;
                this.__p_UkUH1n8VrfaLPWEledB39y = __p_UkUH1n8VrfaLPWEledB39y;
                this.__p_KA8N1Yh5JhjPGpmA7MqOl5 = __p_KA8N1Yh5JhjPGpmA7MqOl5;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200759U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "GTQXyzhCPSJLd9mBoqWYUk", Name = "Timer_GTQXyzhCPSJLd9mBoqWYUk")]
    [n2.SerializableAttribute]
    public class Timer_GTQXyzhCPSJLd9mBoqWYUk : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n3.Timer_GTQXyzhCPSJLd9mBoqWYUk Create(n1.NodeContext Node_Context)
        {
            var instance = new Timer_GTQXyzhCPSJLd9mBoqWYUk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Timer_GTQXyzhCPSJLd9mBoqWYUk CreateDefault()
        {
            var instance = new Timer_GTQXyzhCPSJLd9mBoqWYUk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Timer_GTQXyzhCPSJLd9mBoqWYUk Update(n2.TimeSpan Due_Time_In, n2.TimeSpan Period_In, out n2.IObservable<long> Result_Out, out bool Changed_Out)
        {
            var Output_2 = this.__p_E7SlATy4pQ9QbSCy79JsTc.Update(Value_In: Due_Time_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var Output_5 = this.__p_VcLUY9gc2gyMGVSIXSlMmh.Update(Value_In: Period_In, Result_Out: out bool Result_3, Unchanged_Out: out bool Unchanged_4);
            var Output_6 = Result_0 || Result_3;
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_J5FACfmxwtlOkkVeVB34bL.Update<n2.IObservable<long>, n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Send_In: Output_6, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                var Result_9 = n14.Observable.Timer(dueTime: Due_Time_In, period: Period_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<long> Result_10);
            Result_Out = Result_10;
            Changed_Out = Output_6;
            n3.Timer_GTQXyzhCPSJLd9mBoqWYUk that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_2 != this.__p_E7SlATy4pQ9QbSCy79JsTc || Output_5 != this.__p_VcLUY9gc2gyMGVSIXSlMmh || Output_11 != this.__p_J5FACfmxwtlOkkVeVB34bL ? new Timer_GTQXyzhCPSJLd9mBoqWYUk(this)
                {__p_E7SlATy4pQ9QbSCy79JsTc = Output_2, __p_VcLUY9gc2gyMGVSIXSlMmh = Output_5, __p_J5FACfmxwtlOkkVeVB34bL = Output_11} : that_12;
            else
            {
                this.__p_E7SlATy4pQ9QbSCy79JsTc = Output_2;
                this.__p_VcLUY9gc2gyMGVSIXSlMmh = Output_5;
                this.__p_J5FACfmxwtlOkkVeVB34bL = Output_11;
            }

            return that_12;
        }

        public n3.Timer_GTQXyzhCPSJLd9mBoqWYUk __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "E7SlATy4pQ9QbSCy79JsTc", 200762U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "VcLUY9gc2gyMGVSIXSlMmh", 200773U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "J5FACfmxwtlOkkVeVB34bL", 200778U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<long>.Create(Node_Context: Node_Context_6);
            n3.Timer_GTQXyzhCPSJLd9mBoqWYUk that_8 = this;
            this.__p_E7SlATy4pQ9QbSCy79JsTc = Output_2;
            this.__p_VcLUY9gc2gyMGVSIXSlMmh = Output_5;
            this.__p_J5FACfmxwtlOkkVeVB34bL = Output_7;
            return that_8;
        }

        public n3.Timer_GTQXyzhCPSJLd9mBoqWYUk __CreateDefault__()
        {
            n3.Timer_GTQXyzhCPSJLd9mBoqWYUk that_0 = this;
            this.__p_E7SlATy4pQ9QbSCy79JsTc = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_VcLUY9gc2gyMGVSIXSlMmh = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_J5FACfmxwtlOkkVeVB34bL = n11.ToObservable_Switch_Factory_C<long>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_E7SlATy4pQ9QbSCy79JsTc);
            n1.CompilationHelper.SafeDispose(this.__p_VcLUY9gc2gyMGVSIXSlMmh);
            n1.CompilationHelper.SafeDispose(this.__p_J5FACfmxwtlOkkVeVB34bL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200762U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "E7SlATy4pQ9QbSCy79JsTc", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_E7SlATy4pQ9QbSCy79JsTc;
        [n1.ElementAttribute(TracingId = 200773U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "VcLUY9gc2gyMGVSIXSlMmh", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_VcLUY9gc2gyMGVSIXSlMmh;
        [n1.ElementAttribute(TracingId = 200778U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "J5FACfmxwtlOkkVeVB34bL", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<long> __p_J5FACfmxwtlOkkVeVB34bL;
        public Timer_GTQXyzhCPSJLd9mBoqWYUk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Timer_GTQXyzhCPSJLd9mBoqWYUk(Timer_GTQXyzhCPSJLd9mBoqWYUk other): base(other)
        {
            this.__p_E7SlATy4pQ9QbSCy79JsTc = other.__p_E7SlATy4pQ9QbSCy79JsTc;
            this.__p_VcLUY9gc2gyMGVSIXSlMmh = other.__p_VcLUY9gc2gyMGVSIXSlMmh;
            this.__p_J5FACfmxwtlOkkVeVB34bL = other.__p_J5FACfmxwtlOkkVeVB34bL;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_E7SlATy4pQ9QbSCy79JsTc", in __p_E7SlATy4pQ9QbSCy79JsTc), n1.CompilationHelper.GetValueOrExisting(values, "__p_VcLUY9gc2gyMGVSIXSlMmh", in __p_VcLUY9gc2gyMGVSIXSlMmh), n1.CompilationHelper.GetValueOrExisting(values, "__p_J5FACfmxwtlOkkVeVB34bL", in __p_J5FACfmxwtlOkkVeVB34bL));
        }

        internal Timer_GTQXyzhCPSJLd9mBoqWYUk __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_E7SlATy4pQ9QbSCy79JsTc, n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_VcLUY9gc2gyMGVSIXSlMmh, n11.ToObservable_Switch_Factory_C<long> __p_J5FACfmxwtlOkkVeVB34bL)
        {
            n3.Timer_GTQXyzhCPSJLd9mBoqWYUk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_E7SlATy4pQ9QbSCy79JsTc != this.__p_E7SlATy4pQ9QbSCy79JsTc || __p_VcLUY9gc2gyMGVSIXSlMmh != this.__p_VcLUY9gc2gyMGVSIXSlMmh || __p_J5FACfmxwtlOkkVeVB34bL != this.__p_J5FACfmxwtlOkkVeVB34bL ? new Timer_GTQXyzhCPSJLd9mBoqWYUk(this)
                {__p_E7SlATy4pQ9QbSCy79JsTc = __p_E7SlATy4pQ9QbSCy79JsTc, __p_VcLUY9gc2gyMGVSIXSlMmh = __p_VcLUY9gc2gyMGVSIXSlMmh, __p_J5FACfmxwtlOkkVeVB34bL = __p_J5FACfmxwtlOkkVeVB34bL} : that_0;
            else
            {
                this.__p_E7SlATy4pQ9QbSCy79JsTc = __p_E7SlATy4pQ9QbSCy79JsTc;
                this.__p_VcLUY9gc2gyMGVSIXSlMmh = __p_VcLUY9gc2gyMGVSIXSlMmh;
                this.__p_J5FACfmxwtlOkkVeVB34bL = __p_J5FACfmxwtlOkkVeVB34bL;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200812U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HtQVkL9qnY1L0NVTWCkYb0", Name = "Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0")]
    [n2.SerializableAttribute]
    public class Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> Update(bool Condition_In, T2 False_In, T2 True_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
        {
            n17._Operations_.Switch_Boolean<T2>(Condition_In: Condition_In, Input_In: False_In, Input_2_In: True_In, Output_Out: out T2 Output_0);
            n2.IObservable<T> Message_1 = (n2.IObservable<T>)Output_0;
            var Output_4 = this.__p_DmaaO9xZ4BDOFZ7k25grs6.Update(Value_In: Output_0, Result_Out: out bool Result_2, Unchanged_Out: out bool Unchanged_3);
            n19._Operations_.Update<T>(Input_In: this.__p_SXncT6S28SLNIYnDpTyim2, Message_In: Message_1, Send_In: Result_2, Output_Out: out n18.ToObservableSwitch<T> Output_5, Result_Out: out n2.IObservable<T> Result_6);
            Result_Out = Result_6;
            Changed_Out = Result_2;
            n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_4 != this.__p_DmaaO9xZ4BDOFZ7k25grs6 || Output_5 != this.__p_SXncT6S28SLNIYnDpTyim2 ? new Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T>(this)
                {__p_DmaaO9xZ4BDOFZ7k25grs6 = Output_4, __p_SXncT6S28SLNIYnDpTyim2 = Output_5} : that_7;
            else
            {
                this.__p_DmaaO9xZ4BDOFZ7k25grs6 = Output_4;
                this.__p_SXncT6S28SLNIYnDpTyim2 = Output_5;
            }

            return that_7;
        }

        public n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "DmaaO9xZ4BDOFZ7k25grs6", 200815U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "SXncT6S28SLNIYnDpTyim2", 200819U);
            n19._Operations_.Create<T>(Node_Context: Node_Context_4, Output_Out: out n18.ToObservableSwitch<T> Output_5);
            n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> that_6 = this;
            this.__p_DmaaO9xZ4BDOFZ7k25grs6 = Output_3;
            this.__p_SXncT6S28SLNIYnDpTyim2 = Output_5;
            return that_6;
        }

        public n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> that_1 = this;
            this.__p_DmaaO9xZ4BDOFZ7k25grs6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_SXncT6S28SLNIYnDpTyim2 = default(n18.ToObservableSwitch<T>);
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DmaaO9xZ4BDOFZ7k25grs6);
            n1.CompilationHelper.SafeDispose(this.__p_SXncT6S28SLNIYnDpTyim2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200815U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DmaaO9xZ4BDOFZ7k25grs6", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_DmaaO9xZ4BDOFZ7k25grs6;
        [n1.ElementAttribute(TracingId = 200819U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "SXncT6S28SLNIYnDpTyim2", Name = "ToObservable (Switch)", IsManaged = true, IsAutoGenerated = true)]
        public n18.ToObservableSwitch<T> __p_SXncT6S28SLNIYnDpTyim2;
        public Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0(Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> other): base(other)
        {
            this.__p_DmaaO9xZ4BDOFZ7k25grs6 = other.__p_DmaaO9xZ4BDOFZ7k25grs6;
            this.__p_SXncT6S28SLNIYnDpTyim2 = other.__p_SXncT6S28SLNIYnDpTyim2;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DmaaO9xZ4BDOFZ7k25grs6", in __p_DmaaO9xZ4BDOFZ7k25grs6), n1.CompilationHelper.GetValueOrExisting(values, "__p_SXncT6S28SLNIYnDpTyim2", in __p_SXncT6S28SLNIYnDpTyim2));
        }

        internal Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_DmaaO9xZ4BDOFZ7k25grs6, n18.ToObservableSwitch<T> __p_SXncT6S28SLNIYnDpTyim2)
        {
            n3.Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DmaaO9xZ4BDOFZ7k25grs6 != this.__p_DmaaO9xZ4BDOFZ7k25grs6 || __p_SXncT6S28SLNIYnDpTyim2 != this.__p_SXncT6S28SLNIYnDpTyim2 ? new Switch_Condition_HtQVkL9qnY1L0NVTWCkYb0<T2, T>(this)
                {__p_DmaaO9xZ4BDOFZ7k25grs6 = __p_DmaaO9xZ4BDOFZ7k25grs6, __p_SXncT6S28SLNIYnDpTyim2 = __p_SXncT6S28SLNIYnDpTyim2} : that_0;
            else
            {
                this.__p_DmaaO9xZ4BDOFZ7k25grs6 = __p_DmaaO9xZ4BDOFZ7k25grs6;
                this.__p_SXncT6S28SLNIYnDpTyim2 = __p_SXncT6S28SLNIYnDpTyim2;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200856U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "ETN9yfSVnttO7fKOEDrW3o", Name = "OfType_ETN9yfSVnttO7fKOEDrW3o")]
    [n2.SerializableAttribute]
    public class OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<n2.Object>
    {
        [n5.CreateNewAttribute]
        public static n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_Eqfuj1WvfweO5Vrf2DVf7D.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<n2.Object> Input_4 = (n2.IObservable<n2.Object>)Value_In;
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_UMe5203wXrTORD6XLnwZNL.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n8._Operations_.OfType<T>(Input_In: Input_4, Output_Out: out n2.IObservable<T> Output_7);
                return Output_7;
            }

            , Result_Out: out n2.IObservable<T> Result_8);
            Result_Out = Result_8;
            Changed_Out = Result_1;
            n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_Eqfuj1WvfweO5Vrf2DVf7D || Output_9 != this.__p_UMe5203wXrTORD6XLnwZNL ? new OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T>(this)
                {__p_Eqfuj1WvfweO5Vrf2DVf7D = Output_3, __p_UMe5203wXrTORD6XLnwZNL = Output_9} : that_10;
            else
            {
                this.__p_Eqfuj1WvfweO5Vrf2DVf7D = Output_3;
                this.__p_UMe5203wXrTORD6XLnwZNL = Output_9;
            }

            return that_10;
        }

        public n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Eqfuj1WvfweO5Vrf2DVf7D", 200860U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "UMe5203wXrTORD6XLnwZNL", 200866U);
            var Output_5 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_4);
            n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> that_6 = this;
            this.__p_Eqfuj1WvfweO5Vrf2DVf7D = Output_3;
            this.__p_UMe5203wXrTORD6XLnwZNL = Output_5;
            return that_6;
        }

        public n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> that_1 = this;
            this.__p_Eqfuj1WvfweO5Vrf2DVf7D = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_UMe5203wXrTORD6XLnwZNL = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Eqfuj1WvfweO5Vrf2DVf7D);
            n1.CompilationHelper.SafeDispose(this.__p_UMe5203wXrTORD6XLnwZNL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200860U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Eqfuj1WvfweO5Vrf2DVf7D", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_Eqfuj1WvfweO5Vrf2DVf7D;
        [n1.ElementAttribute(TracingId = 200866U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "UMe5203wXrTORD6XLnwZNL", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_UMe5203wXrTORD6XLnwZNL;
        public OfType_ETN9yfSVnttO7fKOEDrW3o(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OfType_ETN9yfSVnttO7fKOEDrW3o(OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> other): base(other)
        {
            this.__p_Eqfuj1WvfweO5Vrf2DVf7D = other.__p_Eqfuj1WvfweO5Vrf2DVf7D;
            this.__p_UMe5203wXrTORD6XLnwZNL = other.__p_UMe5203wXrTORD6XLnwZNL;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Eqfuj1WvfweO5Vrf2DVf7D", in __p_Eqfuj1WvfweO5Vrf2DVf7D), n1.CompilationHelper.GetValueOrExisting(values, "__p_UMe5203wXrTORD6XLnwZNL", in __p_UMe5203wXrTORD6XLnwZNL));
        }

        internal OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_Eqfuj1WvfweO5Vrf2DVf7D, n11.ToObservable_Switch_Factory_C<T> __p_UMe5203wXrTORD6XLnwZNL)
        {
            n3.OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Eqfuj1WvfweO5Vrf2DVf7D != this.__p_Eqfuj1WvfweO5Vrf2DVf7D || __p_UMe5203wXrTORD6XLnwZNL != this.__p_UMe5203wXrTORD6XLnwZNL ? new OfType_ETN9yfSVnttO7fKOEDrW3o<T2, T>(this)
                {__p_Eqfuj1WvfweO5Vrf2DVf7D = __p_Eqfuj1WvfweO5Vrf2DVf7D, __p_UMe5203wXrTORD6XLnwZNL = __p_UMe5203wXrTORD6XLnwZNL} : that_0;
            else
            {
                this.__p_Eqfuj1WvfweO5Vrf2DVf7D = __p_Eqfuj1WvfweO5Vrf2DVf7D;
                this.__p_UMe5203wXrTORD6XLnwZNL = __p_UMe5203wXrTORD6XLnwZNL;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200916U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Cx5E5ey1sbWOrINWIDrTDF", Name = "Start_Cx5E5ey1sbWOrINWIDrTDF")]
    [n2.SerializableAttribute]
    public class Start_Cx5E5ey1sbWOrINWIDrTDF<T> : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Start_Cx5E5ey1sbWOrINWIDrTDF<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> CreateDefault()
        {
            var instance = new Start_Cx5E5ey1sbWOrINWIDrTDF<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> Update<AdM>(n2.Func<T> Function_In, bool Run_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            n20._Operations_.Update<T>(Input_In: this.__p_BWOSGAOYLSkMAhDOjSrCsI, Delegate_In: Function_In, Output_Out: out n6.FuncProxy<T> Output_1, Result_Out: out n2.Func<T> Result_2);
            var __fallback___3 = n1.ServiceRegistry.Current;
            var Output_7 = this.__p_OJihjQI2QINLDmoDi7onEE.Update<n2.IObservable<T>, AdM>(Send_In: Run_In, Factory_In: () =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                n8._Operations_.Start<T>(Function_In: Result_2, Result_Out: out n2.IObservable<T> Result_5);
                return Result_5;
            }

            , Result_Out: out n2.IObservable<T> Result_6);
            Result_Out = Result_6;
            n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_1 != this.__p_BWOSGAOYLSkMAhDOjSrCsI || Output_7 != this.__p_OJihjQI2QINLDmoDi7onEE ? new Start_Cx5E5ey1sbWOrINWIDrTDF<T>(this)
                {__p_BWOSGAOYLSkMAhDOjSrCsI = Output_1, __p_OJihjQI2QINLDmoDi7onEE = Output_7} : that_8;
            else
            {
                this.__p_BWOSGAOYLSkMAhDOjSrCsI = Output_1;
                this.__p_OJihjQI2QINLDmoDi7onEE = Output_7;
            }

            return that_8;
        }

        public n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "BWOSGAOYLSkMAhDOjSrCsI", 200944U);
            n20._Operations_.Create<T>(Node_Context: Node_Context_0, Output_Out: out n6.FuncProxy<T> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "OJihjQI2QINLDmoDi7onEE", 200927U);
            var Output_3 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_2);
            n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> that_4 = this;
            this.__p_BWOSGAOYLSkMAhDOjSrCsI = Output_1;
            this.__p_OJihjQI2QINLDmoDi7onEE = Output_3;
            return that_4;
        }

        public n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> __CreateDefault__()
        {
            n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> that_0 = this;
            this.__p_BWOSGAOYLSkMAhDOjSrCsI = default(n6.FuncProxy<T>);
            this.__p_OJihjQI2QINLDmoDi7onEE = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BWOSGAOYLSkMAhDOjSrCsI);
            n1.CompilationHelper.SafeDispose(this.__p_OJihjQI2QINLDmoDi7onEE);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200944U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "BWOSGAOYLSkMAhDOjSrCsI", Name = "Proxy (0 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T> __p_BWOSGAOYLSkMAhDOjSrCsI;
        [n1.ElementAttribute(TracingId = 200927U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "OJihjQI2QINLDmoDi7onEE", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_OJihjQI2QINLDmoDi7onEE;
        public Start_Cx5E5ey1sbWOrINWIDrTDF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Start_Cx5E5ey1sbWOrINWIDrTDF(Start_Cx5E5ey1sbWOrINWIDrTDF<T> other): base(other)
        {
            this.__p_BWOSGAOYLSkMAhDOjSrCsI = other.__p_BWOSGAOYLSkMAhDOjSrCsI;
            this.__p_OJihjQI2QINLDmoDi7onEE = other.__p_OJihjQI2QINLDmoDi7onEE;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BWOSGAOYLSkMAhDOjSrCsI", in __p_BWOSGAOYLSkMAhDOjSrCsI), n1.CompilationHelper.GetValueOrExisting(values, "__p_OJihjQI2QINLDmoDi7onEE", in __p_OJihjQI2QINLDmoDi7onEE));
        }

        internal Start_Cx5E5ey1sbWOrINWIDrTDF<T> __WITH__(n6.FuncProxy<T> __p_BWOSGAOYLSkMAhDOjSrCsI, n11.ToObservable_Switch_Factory_C<T> __p_OJihjQI2QINLDmoDi7onEE)
        {
            n3.Start_Cx5E5ey1sbWOrINWIDrTDF<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BWOSGAOYLSkMAhDOjSrCsI != this.__p_BWOSGAOYLSkMAhDOjSrCsI || __p_OJihjQI2QINLDmoDi7onEE != this.__p_OJihjQI2QINLDmoDi7onEE ? new Start_Cx5E5ey1sbWOrINWIDrTDF<T>(this)
                {__p_BWOSGAOYLSkMAhDOjSrCsI = __p_BWOSGAOYLSkMAhDOjSrCsI, __p_OJihjQI2QINLDmoDi7onEE = __p_OJihjQI2QINLDmoDi7onEE} : that_0;
            else
            {
                this.__p_BWOSGAOYLSkMAhDOjSrCsI = __p_BWOSGAOYLSkMAhDOjSrCsI;
                this.__p_OJihjQI2QINLDmoDi7onEE = __p_OJihjQI2QINLDmoDi7onEE;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 200986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DIR0tfXghECLMGaltFLlX7", Name = "Repeat_DIR0tfXghECLMGaltFLlX7")]
    [n2.SerializableAttribute]
    public class Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Repeat_DIR0tfXghECLMGaltFLlX7<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Repeat_DIR0tfXghECLMGaltFLlX7<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_PKaYggUpiseQEuERwn56GC.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_Vii9FI9B41DNknSpiiyTXy.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n8._Operations_.Repeat<T>(Input_In: Input_4, Output_Out: out n2.IObservable<T> Output_7);
                return Output_7;
            }

            , Result_Out: out n2.IObservable<T> Result_8);
            Result_Out = Result_8;
            n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_PKaYggUpiseQEuERwn56GC || Output_9 != this.__p_Vii9FI9B41DNknSpiiyTXy ? new Repeat_DIR0tfXghECLMGaltFLlX7<T, T2>(this)
                {__p_PKaYggUpiseQEuERwn56GC = Output_3, __p_Vii9FI9B41DNknSpiiyTXy = Output_9} : that_10;
            else
            {
                this.__p_PKaYggUpiseQEuERwn56GC = Output_3;
                this.__p_Vii9FI9B41DNknSpiiyTXy = Output_9;
            }

            return that_10;
        }

        public n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Vii9FI9B41DNknSpiiyTXy", 200991U);
            var Output_2 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "PKaYggUpiseQEuERwn56GC", 201014U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> that_6 = this;
            this.__p_Vii9FI9B41DNknSpiiyTXy = Output_2;
            this.__p_PKaYggUpiseQEuERwn56GC = Output_5;
            return that_6;
        }

        public n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> that_1 = this;
            this.__p_PKaYggUpiseQEuERwn56GC = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_Vii9FI9B41DNknSpiiyTXy = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PKaYggUpiseQEuERwn56GC);
            n1.CompilationHelper.SafeDispose(this.__p_Vii9FI9B41DNknSpiiyTXy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201014U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "PKaYggUpiseQEuERwn56GC", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_PKaYggUpiseQEuERwn56GC;
        [n1.ElementAttribute(TracingId = 200991U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Vii9FI9B41DNknSpiiyTXy", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_Vii9FI9B41DNknSpiiyTXy;
        public Repeat_DIR0tfXghECLMGaltFLlX7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Repeat_DIR0tfXghECLMGaltFLlX7(Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> other): base(other)
        {
            this.__p_PKaYggUpiseQEuERwn56GC = other.__p_PKaYggUpiseQEuERwn56GC;
            this.__p_Vii9FI9B41DNknSpiiyTXy = other.__p_Vii9FI9B41DNknSpiiyTXy;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PKaYggUpiseQEuERwn56GC", in __p_PKaYggUpiseQEuERwn56GC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vii9FI9B41DNknSpiiyTXy", in __p_Vii9FI9B41DNknSpiiyTXy));
        }

        internal Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_PKaYggUpiseQEuERwn56GC, n11.ToObservable_Switch_Factory_C<T> __p_Vii9FI9B41DNknSpiiyTXy)
        {
            n3.Repeat_DIR0tfXghECLMGaltFLlX7<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PKaYggUpiseQEuERwn56GC != this.__p_PKaYggUpiseQEuERwn56GC || __p_Vii9FI9B41DNknSpiiyTXy != this.__p_Vii9FI9B41DNknSpiiyTXy ? new Repeat_DIR0tfXghECLMGaltFLlX7<T, T2>(this)
                {__p_PKaYggUpiseQEuERwn56GC = __p_PKaYggUpiseQEuERwn56GC, __p_Vii9FI9B41DNknSpiiyTXy = __p_Vii9FI9B41DNknSpiiyTXy} : that_0;
            else
            {
                this.__p_PKaYggUpiseQEuERwn56GC = __p_PKaYggUpiseQEuERwn56GC;
                this.__p_Vii9FI9B41DNknSpiiyTXy = __p_Vii9FI9B41DNknSpiiyTXy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201048U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "IhmkyepgZO0OATXiSzm7Yy", Name = "Merge_Many_IhmkyepgZO0OATXiSzm7Yy")]
    [n2.SerializableAttribute]
    public class Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<n2.IObservable<T>>
    {
        [n5.CreateNewAttribute]
        public static n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_G725kt4s2WWPOscYdpGjQF.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<n2.IObservable<T>> Input_4 = (n2.IObservable<n2.IObservable<T>>)Value_In;
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_AVvy6W6WT25Pq1YSlrQeGR.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n8._Operations_.Merge_Many<T>(Input_In: Input_4, Output_Out: out n2.IObservable<T> Output_7);
                return Output_7;
            }

            , Result_Out: out n2.IObservable<T> Result_8);
            Result_Out = Result_8;
            Changed_Out = Result_1;
            n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_G725kt4s2WWPOscYdpGjQF || Output_9 != this.__p_AVvy6W6WT25Pq1YSlrQeGR ? new Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T>(this)
                {__p_G725kt4s2WWPOscYdpGjQF = Output_3, __p_AVvy6W6WT25Pq1YSlrQeGR = Output_9} : that_10;
            else
            {
                this.__p_G725kt4s2WWPOscYdpGjQF = Output_3;
                this.__p_AVvy6W6WT25Pq1YSlrQeGR = Output_9;
            }

            return that_10;
        }

        public n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "G725kt4s2WWPOscYdpGjQF", 201054U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "AVvy6W6WT25Pq1YSlrQeGR", 201062U);
            var Output_5 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_4);
            n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> that_6 = this;
            this.__p_G725kt4s2WWPOscYdpGjQF = Output_3;
            this.__p_AVvy6W6WT25Pq1YSlrQeGR = Output_5;
            return that_6;
        }

        public n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> that_1 = this;
            this.__p_G725kt4s2WWPOscYdpGjQF = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_AVvy6W6WT25Pq1YSlrQeGR = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_G725kt4s2WWPOscYdpGjQF);
            n1.CompilationHelper.SafeDispose(this.__p_AVvy6W6WT25Pq1YSlrQeGR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201054U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "G725kt4s2WWPOscYdpGjQF", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_G725kt4s2WWPOscYdpGjQF;
        [n1.ElementAttribute(TracingId = 201062U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "AVvy6W6WT25Pq1YSlrQeGR", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_AVvy6W6WT25Pq1YSlrQeGR;
        public Merge_Many_IhmkyepgZO0OATXiSzm7Yy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Merge_Many_IhmkyepgZO0OATXiSzm7Yy(Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> other): base(other)
        {
            this.__p_G725kt4s2WWPOscYdpGjQF = other.__p_G725kt4s2WWPOscYdpGjQF;
            this.__p_AVvy6W6WT25Pq1YSlrQeGR = other.__p_AVvy6W6WT25Pq1YSlrQeGR;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_G725kt4s2WWPOscYdpGjQF", in __p_G725kt4s2WWPOscYdpGjQF), n1.CompilationHelper.GetValueOrExisting(values, "__p_AVvy6W6WT25Pq1YSlrQeGR", in __p_AVvy6W6WT25Pq1YSlrQeGR));
        }

        internal Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_G725kt4s2WWPOscYdpGjQF, n11.ToObservable_Switch_Factory_C<T> __p_AVvy6W6WT25Pq1YSlrQeGR)
        {
            n3.Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_G725kt4s2WWPOscYdpGjQF != this.__p_G725kt4s2WWPOscYdpGjQF || __p_AVvy6W6WT25Pq1YSlrQeGR != this.__p_AVvy6W6WT25Pq1YSlrQeGR ? new Merge_Many_IhmkyepgZO0OATXiSzm7Yy<T2, T>(this)
                {__p_G725kt4s2WWPOscYdpGjQF = __p_G725kt4s2WWPOscYdpGjQF, __p_AVvy6W6WT25Pq1YSlrQeGR = __p_AVvy6W6WT25Pq1YSlrQeGR} : that_0;
            else
            {
                this.__p_G725kt4s2WWPOscYdpGjQF = __p_G725kt4s2WWPOscYdpGjQF;
                this.__p_AVvy6W6WT25Pq1YSlrQeGR = __p_AVvy6W6WT25Pq1YSlrQeGR;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201117U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "CAkl7WqqQZvPCVtGNHyJPW", Name = "Take_CAkl7WqqQZvPCVtGNHyJPW")]
    [n2.SerializableAttribute]
    public class Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> Update<AdM>(T2 Value_In, int Count_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_FU2piVNSs1lMEP1FO96b0J.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_Nd75dzpuj6qP1j1qtlfiDW.Update(Value_In: Count_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            var __fallback___9 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_HJrMpnSpRDPPjKxIqd4jvy.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                n8._Operations_.Take<T>(Input_In: Input_8, Count_In: Count_In, Output_Out: out n2.IObservable<T> Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<T> Result_12);
            Result_Out = Result_12;
            Changed_Out = Output_7;
            n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_3 != this.__p_FU2piVNSs1lMEP1FO96b0J || Output_6 != this.__p_Nd75dzpuj6qP1j1qtlfiDW || Output_13 != this.__p_HJrMpnSpRDPPjKxIqd4jvy ? new Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T>(this)
                {__p_FU2piVNSs1lMEP1FO96b0J = Output_3, __p_Nd75dzpuj6qP1j1qtlfiDW = Output_6, __p_HJrMpnSpRDPPjKxIqd4jvy = Output_13} : that_14;
            else
            {
                this.__p_FU2piVNSs1lMEP1FO96b0J = Output_3;
                this.__p_Nd75dzpuj6qP1j1qtlfiDW = Output_6;
                this.__p_HJrMpnSpRDPPjKxIqd4jvy = Output_13;
            }

            return that_14;
        }

        public n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "FU2piVNSs1lMEP1FO96b0J", 201124U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Nd75dzpuj6qP1j1qtlfiDW", 201139U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "HJrMpnSpRDPPjKxIqd4jvy", 201156U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> that_9 = this;
            this.__p_FU2piVNSs1lMEP1FO96b0J = Output_3;
            this.__p_Nd75dzpuj6qP1j1qtlfiDW = Output_6;
            this.__p_HJrMpnSpRDPPjKxIqd4jvy = Output_8;
            return that_9;
        }

        public n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> that_1 = this;
            this.__p_FU2piVNSs1lMEP1FO96b0J = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_Nd75dzpuj6qP1j1qtlfiDW = n10.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_HJrMpnSpRDPPjKxIqd4jvy = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FU2piVNSs1lMEP1FO96b0J);
            n1.CompilationHelper.SafeDispose(this.__p_Nd75dzpuj6qP1j1qtlfiDW);
            n1.CompilationHelper.SafeDispose(this.__p_HJrMpnSpRDPPjKxIqd4jvy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201124U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "FU2piVNSs1lMEP1FO96b0J", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_FU2piVNSs1lMEP1FO96b0J;
        [n1.ElementAttribute(TracingId = 201139U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Nd75dzpuj6qP1j1qtlfiDW", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_Nd75dzpuj6qP1j1qtlfiDW;
        [n1.ElementAttribute(TracingId = 201156U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HJrMpnSpRDPPjKxIqd4jvy", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_HJrMpnSpRDPPjKxIqd4jvy;
        public Take_CAkl7WqqQZvPCVtGNHyJPW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Take_CAkl7WqqQZvPCVtGNHyJPW(Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> other): base(other)
        {
            this.__p_FU2piVNSs1lMEP1FO96b0J = other.__p_FU2piVNSs1lMEP1FO96b0J;
            this.__p_Nd75dzpuj6qP1j1qtlfiDW = other.__p_Nd75dzpuj6qP1j1qtlfiDW;
            this.__p_HJrMpnSpRDPPjKxIqd4jvy = other.__p_HJrMpnSpRDPPjKxIqd4jvy;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FU2piVNSs1lMEP1FO96b0J", in __p_FU2piVNSs1lMEP1FO96b0J), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nd75dzpuj6qP1j1qtlfiDW", in __p_Nd75dzpuj6qP1j1qtlfiDW), n1.CompilationHelper.GetValueOrExisting(values, "__p_HJrMpnSpRDPPjKxIqd4jvy", in __p_HJrMpnSpRDPPjKxIqd4jvy));
        }

        internal Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_FU2piVNSs1lMEP1FO96b0J, n10.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_Nd75dzpuj6qP1j1qtlfiDW, n11.ToObservable_Switch_Factory_C<T> __p_HJrMpnSpRDPPjKxIqd4jvy)
        {
            n3.Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FU2piVNSs1lMEP1FO96b0J != this.__p_FU2piVNSs1lMEP1FO96b0J || __p_Nd75dzpuj6qP1j1qtlfiDW != this.__p_Nd75dzpuj6qP1j1qtlfiDW || __p_HJrMpnSpRDPPjKxIqd4jvy != this.__p_HJrMpnSpRDPPjKxIqd4jvy ? new Take_CAkl7WqqQZvPCVtGNHyJPW<T2, T>(this)
                {__p_FU2piVNSs1lMEP1FO96b0J = __p_FU2piVNSs1lMEP1FO96b0J, __p_Nd75dzpuj6qP1j1qtlfiDW = __p_Nd75dzpuj6qP1j1qtlfiDW, __p_HJrMpnSpRDPPjKxIqd4jvy = __p_HJrMpnSpRDPPjKxIqd4jvy} : that_0;
            else
            {
                this.__p_FU2piVNSs1lMEP1FO96b0J = __p_FU2piVNSs1lMEP1FO96b0J;
                this.__p_Nd75dzpuj6qP1j1qtlfiDW = __p_Nd75dzpuj6qP1j1qtlfiDW;
                this.__p_HJrMpnSpRDPPjKxIqd4jvy = __p_HJrMpnSpRDPPjKxIqd4jvy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201214U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EWTRWuyOPQ6Lx5WrZG8U8p", Name = "CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p")]
    [n2.SerializableAttribute]
    public class CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> : n1.VLObject, n2.IDisposable where T5 : n2.IObservable<T2> where T4 : n2.IObservable<T3>
    {
        [n5.CreateNewAttribute]
        public static n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T4>, n4.IAdaptiveCreateDefault<T5>
        {
            var instance = new CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T4>, n4.IAdaptiveCreateDefault<T5>
        {
            var instance = new CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> Update<AdM>(T5 Input_In, T4 Input_2_In, n2.Func<T2, T3, T> Result_Selector_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            n2.IObservable<T2> Input_1 = (n2.IObservable<T2>)Input_In;
            var Output_4 = this.__p_AyUKMPekr8sMDQRqCyLN29.Update(Value_In: Input_In, Result_Out: out bool Result_2, Unchanged_Out: out bool Unchanged_3);
            var Output_7 = this.__p_CTPqieDBNRSPkmEMLRmt54.Update(Value_In: Input_2_In, Result_Out: out bool Result_5, Unchanged_Out: out bool Unchanged_6);
            var Output_8 = Result_2 || Result_5;
            n2.IObservable<T3> Second_9 = (n2.IObservable<T3>)Input_2_In;
            var __fallback___10 = n1.ServiceRegistry.Current;
            var Output_14 = this.__p_AAJjp7ukfblOs8b8xwe5KW.Update<n2.IObservable<T>, AdM>(Send_In: Output_8, Factory_In: () =>
            {
                using var __current_11 = __fallback___10.MakeCurrentIfNone();
                n8._Operations_.CombineLatest<T2, T3, T>(Input_In: Input_1, Second_In: Second_9, Result_Selector_In: Result_Selector_In, Output_Out: out n2.IObservable<T> Output_12);
                return Output_12;
            }

            , Result_Out: out n2.IObservable<T> Result_13);
            Result_Out = Result_13;
            n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Output_4 != this.__p_AyUKMPekr8sMDQRqCyLN29 || Output_7 != this.__p_CTPqieDBNRSPkmEMLRmt54 || Output_14 != this.__p_AAJjp7ukfblOs8b8xwe5KW ? new CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T>(this)
                {__p_AyUKMPekr8sMDQRqCyLN29 = Output_4, __p_CTPqieDBNRSPkmEMLRmt54 = Output_7, __p_AAJjp7ukfblOs8b8xwe5KW = Output_14} : that_15;
            else
            {
                this.__p_AyUKMPekr8sMDQRqCyLN29 = Output_4;
                this.__p_CTPqieDBNRSPkmEMLRmt54 = Output_7;
                this.__p_AAJjp7ukfblOs8b8xwe5KW = Output_14;
            }

            return that_15;
        }

        public n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T4>, n4.IAdaptiveCreateDefault<T5>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "AyUKMPekr8sMDQRqCyLN29", 201218U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T5>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "CTPqieDBNRSPkmEMLRmt54", 201230U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T4>.Create<AdM>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "AAJjp7ukfblOs8b8xwe5KW", 201247U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> that_9 = this;
            this.__p_AyUKMPekr8sMDQRqCyLN29 = Output_3;
            this.__p_CTPqieDBNRSPkmEMLRmt54 = Output_6;
            this.__p_AAJjp7ukfblOs8b8xwe5KW = Output_8;
            return that_9;
        }

        public n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T4>, n4.IAdaptiveCreateDefault<T5>
        {
            var w_0 = default(AdM);
            n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> that_1 = this;
            this.__p_AyUKMPekr8sMDQRqCyLN29 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T5>.CreateDefault<AdM>();
            this.__p_CTPqieDBNRSPkmEMLRmt54 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T4>.CreateDefault<AdM>();
            this.__p_AAJjp7ukfblOs8b8xwe5KW = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AyUKMPekr8sMDQRqCyLN29);
            n1.CompilationHelper.SafeDispose(this.__p_CTPqieDBNRSPkmEMLRmt54);
            n1.CompilationHelper.SafeDispose(this.__p_AAJjp7ukfblOs8b8xwe5KW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201218U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "AyUKMPekr8sMDQRqCyLN29", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T5> __p_AyUKMPekr8sMDQRqCyLN29;
        [n1.ElementAttribute(TracingId = 201230U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "CTPqieDBNRSPkmEMLRmt54", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T4> __p_CTPqieDBNRSPkmEMLRmt54;
        [n1.ElementAttribute(TracingId = 201247U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "AAJjp7ukfblOs8b8xwe5KW", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_AAJjp7ukfblOs8b8xwe5KW;
        public CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p(CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> other): base(other)
        {
            this.__p_AyUKMPekr8sMDQRqCyLN29 = other.__p_AyUKMPekr8sMDQRqCyLN29;
            this.__p_CTPqieDBNRSPkmEMLRmt54 = other.__p_CTPqieDBNRSPkmEMLRmt54;
            this.__p_AAJjp7ukfblOs8b8xwe5KW = other.__p_AAJjp7ukfblOs8b8xwe5KW;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AyUKMPekr8sMDQRqCyLN29", in __p_AyUKMPekr8sMDQRqCyLN29), n1.CompilationHelper.GetValueOrExisting(values, "__p_CTPqieDBNRSPkmEMLRmt54", in __p_CTPqieDBNRSPkmEMLRmt54), n1.CompilationHelper.GetValueOrExisting(values, "__p_AAJjp7ukfblOs8b8xwe5KW", in __p_AAJjp7ukfblOs8b8xwe5KW));
        }

        internal CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T5> __p_AyUKMPekr8sMDQRqCyLN29, n10.Changed_A8JGbead2bxNdnPybiEqVS<T4> __p_CTPqieDBNRSPkmEMLRmt54, n11.ToObservable_Switch_Factory_C<T> __p_AAJjp7ukfblOs8b8xwe5KW)
        {
            n3.CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AyUKMPekr8sMDQRqCyLN29 != this.__p_AyUKMPekr8sMDQRqCyLN29 || __p_CTPqieDBNRSPkmEMLRmt54 != this.__p_CTPqieDBNRSPkmEMLRmt54 || __p_AAJjp7ukfblOs8b8xwe5KW != this.__p_AAJjp7ukfblOs8b8xwe5KW ? new CombineLatest_EWTRWuyOPQ6Lx5WrZG8U8p<T5, T2, T4, T3, T>(this)
                {__p_AyUKMPekr8sMDQRqCyLN29 = __p_AyUKMPekr8sMDQRqCyLN29, __p_CTPqieDBNRSPkmEMLRmt54 = __p_CTPqieDBNRSPkmEMLRmt54, __p_AAJjp7ukfblOs8b8xwe5KW = __p_AAJjp7ukfblOs8b8xwe5KW} : that_0;
            else
            {
                this.__p_AyUKMPekr8sMDQRqCyLN29 = __p_AyUKMPekr8sMDQRqCyLN29;
                this.__p_CTPqieDBNRSPkmEMLRmt54 = __p_CTPqieDBNRSPkmEMLRmt54;
                this.__p_AAJjp7ukfblOs8b8xwe5KW = __p_AAJjp7ukfblOs8b8xwe5KW;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201310U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "PIc7u1Dw1JzLwxtTfYqP8i", Name = "DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i")]
    [n2.SerializableAttribute]
    public class DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_ROsWe0cUIQrL96EVKyzelF.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_OYQ1Ke2sZTHOlGVI2icQJL.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n8._Operations_.DistinctUntilChanged<T>(Input_In: Input_4, Output_Out: out n2.IObservable<T> Output_7);
                return Output_7;
            }

            , Result_Out: out n2.IObservable<T> Result_8);
            Result_Out = Result_8;
            n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_ROsWe0cUIQrL96EVKyzelF || Output_9 != this.__p_OYQ1Ke2sZTHOlGVI2icQJL ? new DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2>(this)
                {__p_ROsWe0cUIQrL96EVKyzelF = Output_3, __p_OYQ1Ke2sZTHOlGVI2icQJL = Output_9} : that_10;
            else
            {
                this.__p_ROsWe0cUIQrL96EVKyzelF = Output_3;
                this.__p_OYQ1Ke2sZTHOlGVI2icQJL = Output_9;
            }

            return that_10;
        }

        public n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "OYQ1Ke2sZTHOlGVI2icQJL", 201318U);
            var Output_2 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "ROsWe0cUIQrL96EVKyzelF", 201339U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> that_6 = this;
            this.__p_OYQ1Ke2sZTHOlGVI2icQJL = Output_2;
            this.__p_ROsWe0cUIQrL96EVKyzelF = Output_5;
            return that_6;
        }

        public n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> that_1 = this;
            this.__p_ROsWe0cUIQrL96EVKyzelF = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_OYQ1Ke2sZTHOlGVI2icQJL = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ROsWe0cUIQrL96EVKyzelF);
            n1.CompilationHelper.SafeDispose(this.__p_OYQ1Ke2sZTHOlGVI2icQJL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201339U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "ROsWe0cUIQrL96EVKyzelF", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_ROsWe0cUIQrL96EVKyzelF;
        [n1.ElementAttribute(TracingId = 201318U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "OYQ1Ke2sZTHOlGVI2icQJL", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_OYQ1Ke2sZTHOlGVI2icQJL;
        public DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i(DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> other): base(other)
        {
            this.__p_ROsWe0cUIQrL96EVKyzelF = other.__p_ROsWe0cUIQrL96EVKyzelF;
            this.__p_OYQ1Ke2sZTHOlGVI2icQJL = other.__p_OYQ1Ke2sZTHOlGVI2icQJL;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ROsWe0cUIQrL96EVKyzelF", in __p_ROsWe0cUIQrL96EVKyzelF), n1.CompilationHelper.GetValueOrExisting(values, "__p_OYQ1Ke2sZTHOlGVI2icQJL", in __p_OYQ1Ke2sZTHOlGVI2icQJL));
        }

        internal DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_ROsWe0cUIQrL96EVKyzelF, n11.ToObservable_Switch_Factory_C<T> __p_OYQ1Ke2sZTHOlGVI2icQJL)
        {
            n3.DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ROsWe0cUIQrL96EVKyzelF != this.__p_ROsWe0cUIQrL96EVKyzelF || __p_OYQ1Ke2sZTHOlGVI2icQJL != this.__p_OYQ1Ke2sZTHOlGVI2icQJL ? new DistinctUntilChanged_PIc7u1Dw1JzLwxtTfYqP8i<T, T2>(this)
                {__p_ROsWe0cUIQrL96EVKyzelF = __p_ROsWe0cUIQrL96EVKyzelF, __p_OYQ1Ke2sZTHOlGVI2icQJL = __p_OYQ1Ke2sZTHOlGVI2icQJL} : that_0;
            else
            {
                this.__p_ROsWe0cUIQrL96EVKyzelF = __p_ROsWe0cUIQrL96EVKyzelF;
                this.__p_OYQ1Ke2sZTHOlGVI2icQJL = __p_OYQ1Ke2sZTHOlGVI2icQJL;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201485U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Up0anaeyxPTOUQbikDZ9zh", Name = "ToBackground_Up0anaeyxPTOUQbikDZ9zh")]
    [n2.SerializableAttribute]
    public class ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<n21.IScheduler>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<n21.IScheduler>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Task_Pool_1 = n21.Scheduler.TaskPool;
            var Output_3 = this.__p_H836dpB83x2NoWndWRKLGv.Update<AdM>(Value_In: Value_In, Scheduler_In: Task_Pool_1, Result_Out: out n2.IObservable<T> Result_2);
            Result_Out = Result_2;
            n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = Output_3 != this.__p_H836dpB83x2NoWndWRKLGv ? new ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T>(this)
                {__p_H836dpB83x2NoWndWRKLGv = Output_3} : that_4;
            else
            {
                this.__p_H836dpB83x2NoWndWRKLGv = Output_3;
            }

            return that_4;
        }

        public n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<n21.IScheduler>, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "H836dpB83x2NoWndWRKLGv", 201490U);
            var Output_2 = n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T2, T, n21.IScheduler>.Create<AdM>(Node_Context: Node_Context_1);
            n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> that_3 = this;
            this.__p_H836dpB83x2NoWndWRKLGv = Output_2;
            return that_3;
        }

        public n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<n21.IScheduler>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> that_1 = this;
            this.__p_H836dpB83x2NoWndWRKLGv = n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T2, T, n21.IScheduler>.CreateDefault<AdM>();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_H836dpB83x2NoWndWRKLGv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201490U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "H836dpB83x2NoWndWRKLGv", Name = "ObserveOn", IsManaged = true, IsAutoGenerated = true)]
        public n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T2, T, n21.IScheduler> __p_H836dpB83x2NoWndWRKLGv;
        public ToBackground_Up0anaeyxPTOUQbikDZ9zh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToBackground_Up0anaeyxPTOUQbikDZ9zh(ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> other): base(other)
        {
            this.__p_H836dpB83x2NoWndWRKLGv = other.__p_H836dpB83x2NoWndWRKLGv;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H836dpB83x2NoWndWRKLGv", in __p_H836dpB83x2NoWndWRKLGv));
        }

        internal ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> __WITH__(n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T2, T, n21.IScheduler> __p_H836dpB83x2NoWndWRKLGv)
        {
            n3.ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_H836dpB83x2NoWndWRKLGv != this.__p_H836dpB83x2NoWndWRKLGv ? new ToBackground_Up0anaeyxPTOUQbikDZ9zh<T2, T>(this)
                {__p_H836dpB83x2NoWndWRKLGv = __p_H836dpB83x2NoWndWRKLGv} : that_0;
            else
            {
                this.__p_H836dpB83x2NoWndWRKLGv = __p_H836dpB83x2NoWndWRKLGv;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 201532U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "RTNrLc5G9FBOoD4FfaDw7M", Name = "Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M")]
    [n2.SerializableAttribute]
    public class Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> : n1.VLObject, n2.IDisposable where T2 : n12.IEnumerable<n2.IObservable<T>>
    {
        [n5.CreateNewAttribute]
        public static n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            T2 __auto_1 = this.Sequence;
            n12.IEnumerable<n2.IObservable<T>> Input_2 = (n12.IEnumerable<n2.IObservable<T>>)Value_In;
            n12.IEnumerable<n2.IObservable<T>> Input_3 = (n12.IEnumerable<n2.IObservable<T>>)Value_In;
            n12.IEnumerable<n2.IObservable<T>> Second_4 = (n12.IEnumerable<n2.IObservable<T>>)__auto_1;
            n22._Operations_.SequenceEqual<n2.IObservable<T>>(Input_In: Input_3, Second_In: Second_4, Result_Out: out bool Result_5);
            var Output_6 = !Result_5;
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_DCOlhdUrr4BM0qAWudgwLt.Update<n2.IObservable<T>, AdM>(Send_In: Output_6, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n8._Operations_.Merge_Spectral<T>(Input_In: Input_2, Result_Out: out n2.IObservable<T> Result_9);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<T> Result_10);
            T2 __auto_12 = Value_In;
            Result_Out = Result_10;
            Changed_Out = Result_5;
            n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Output_11 != this.__p_DCOlhdUrr4BM0qAWudgwLt || !n12.EqualityComparer<T2>.Default.Equals(Value_In, this.Sequence) ? new Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2>(this)
                {__p_DCOlhdUrr4BM0qAWudgwLt = Output_11, Sequence = Value_In} : that_13;
            else
            {
                this.__p_DCOlhdUrr4BM0qAWudgwLt = Output_11;
                this.Sequence = Value_In;
            }

            return that_13;
        }

        public n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T2 __out_0);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "DCOlhdUrr4BM0qAWudgwLt", 201542U);
            var Output_2 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_1);
            n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> that_3 = this;
            this.Sequence = __out_0;
            this.__p_DCOlhdUrr4BM0qAWudgwLt = Output_2;
            return that_3;
        }

        public n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T2 __out_1);
            n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> that_1 = this;
            this.Sequence = __out_1;
            this.__p_DCOlhdUrr4BM0qAWudgwLt = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DCOlhdUrr4BM0qAWudgwLt);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 201563U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Oejvkn5pJRYNbGix5tTL20", Name = "Sequence")]
        public T2 Sequence;
        [n1.ElementAttribute(TracingId = 201542U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DCOlhdUrr4BM0qAWudgwLt", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_DCOlhdUrr4BM0qAWudgwLt;
        public Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M(Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> other): base(other)
        {
            this.Sequence = other.Sequence;
            this.__p_DCOlhdUrr4BM0qAWudgwLt = other.__p_DCOlhdUrr4BM0qAWudgwLt;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Sequence", in Sequence), n1.CompilationHelper.GetValueOrExisting(values, "__p_DCOlhdUrr4BM0qAWudgwLt", in __p_DCOlhdUrr4BM0qAWudgwLt));
        }

        internal Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> __WITH__(T2 Sequence, n11.ToObservable_Switch_Factory_C<T> __p_DCOlhdUrr4BM0qAWudgwLt)
        {
            n3.Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n12.EqualityComparer<T2>.Default.Equals(Sequence, this.Sequence) || __p_DCOlhdUrr4BM0qAWudgwLt != this.__p_DCOlhdUrr4BM0qAWudgwLt ? new Merge_Spectral_RTNrLc5G9FBOoD4FfaDw7M<T, T2>(this)
                {Sequence = Sequence, __p_DCOlhdUrr4BM0qAWudgwLt = __p_DCOlhdUrr4BM0qAWudgwLt} : that_0;
            else
            {
                this.Sequence = Sequence;
                this.__p_DCOlhdUrr4BM0qAWudgwLt = __p_DCOlhdUrr4BM0qAWudgwLt;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 207880U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "NZSiSuCpMvdPCnpJ1Mpmkx", Name = "HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx")]
    [n2.SerializableAttribute]
    public class HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> Create<AdM>(n1.NodeContext Node_Context, n2.Exception Initial_Result_In)
            where AdM : struct, n4.IAdaptiveCreateDefault<T>
        {
            var instance = new HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Initial_Result_In);
        }

        [n5.CreateDefaultAttribute]
        public static n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> CreateDefault()
        {
            var instance = new HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> Update<T2>(T2 Input_In, bool Reset_In, out n2.Exception Exception_Out, out string Message_Out, out bool On_Error_Out)
            where T2 : n2.IObservable<T>
        {
            n2.IObservable<T> Input_0 = (n2.IObservable<T>)Input_In;
            n24._Operations_.Update_H<T>(Input__this__In: this.__p_DBbz1mSxh6YMSobyUyAwvK, Input_In: Input_0, Output_Out: out n18.SplitterNode<T> Output_1, Original_Out: out n2.IObservable<T> Original_2, On_Error_Out: out n2.IObservable<n2.Exception> On_Error_3, On_Completed_Out: out n2.IObservable<n23.Unit> On_Completed_4);
            bool Reset_5 = false;
            bool Update_6 = true;
            var Output_7 = this.__p_CaxF9nYHq7rOGFu9pj42Vi;
            if (Update_6)
            {
                n25._Operations_.Update_H<T>(Input_In: this.__p_CaxF9nYHq7rOGFu9pj42Vi, Async_Notifications_In: Original_2, Reset_In: Reset_5, Output_Out: out Output_7);
            }

            bool Update_8 = true;
            var Output_9 = this.__p_U8ET1BOsUw7QOcOofyN4T4;
            if (Update_8)
            {
                n25._Operations_.Update_H<n2.Exception>(Input_In: this.__p_U8ET1BOsUw7QOcOofyN4T4, Async_Notifications_In: On_Error_3, Reset_In: Reset_In, Output_Out: out Output_9);
            }

            n25._Operations_.GetData_H<n2.Exception>(Input_In: Output_9, Output_Out: out n18.HoldLatest<n2.Exception> Output_10, Value_Out: out n2.Exception Value_11, On_Data_Out: out bool On_Data_12);
            var Message_13 = Value_11.Message;
            Exception_Out = Value_11;
            Message_Out = Message_13;
            On_Error_Out = On_Data_12;
            n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_1 != this.__p_DBbz1mSxh6YMSobyUyAwvK || Output_7 != this.__p_CaxF9nYHq7rOGFu9pj42Vi || Output_10 != this.__p_U8ET1BOsUw7QOcOofyN4T4 ? new HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T>(this)
                {__p_DBbz1mSxh6YMSobyUyAwvK = Output_1, __p_CaxF9nYHq7rOGFu9pj42Vi = Output_7, __p_U8ET1BOsUw7QOcOofyN4T4 = Output_10} : that_14;
            else
            {
                this.__p_DBbz1mSxh6YMSobyUyAwvK = Output_1;
                this.__p_CaxF9nYHq7rOGFu9pj42Vi = Output_7;
                this.__p_U8ET1BOsUw7QOcOofyN4T4 = Output_10;
            }

            return that_14;
        }

        public n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> __Create__<AdM>(n1.NodeContext Node_Context, n2.Exception Initial_Result_In)
            where AdM : struct, n4.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "U8ET1BOsUw7QOcOofyN4T4", 207885U);
            n25._Operations_.Create_H<n2.Exception>(Node_Context: Node_Context_1, Initial_Result_In: Initial_Result_In, Output_Out: out n18.HoldLatest<n2.Exception> Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "DBbz1mSxh6YMSobyUyAwvK", 208215U);
            n24._Operations_.Create_H<T>(Node_Context: Node_Context_3, Output_Out: out n18.SplitterNode<T> Output_4);
            w_0.CreateDefault(Output_Out: out T Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "CaxF9nYHq7rOGFu9pj42Vi", 208245U);
            n25._Operations_.Create_H<T>(Node_Context: Node_Context_6, Initial_Result_In: Output_5, Output_Out: out n18.HoldLatest<T> Output_7);
            n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> that_8 = this;
            this.__p_U8ET1BOsUw7QOcOofyN4T4 = Output_2;
            this.__p_DBbz1mSxh6YMSobyUyAwvK = Output_4;
            this.__p_CaxF9nYHq7rOGFu9pj42Vi = Output_7;
            return that_8;
        }

        public n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> __CreateDefault__()
        {
            n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> that_0 = this;
            this.__p_DBbz1mSxh6YMSobyUyAwvK = default(n18.SplitterNode<T>);
            this.__p_CaxF9nYHq7rOGFu9pj42Vi = default(n18.HoldLatest<T>);
            this.__p_U8ET1BOsUw7QOcOofyN4T4 = default(n18.HoldLatest<n2.Exception>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DBbz1mSxh6YMSobyUyAwvK);
            n1.CompilationHelper.SafeDispose(this.__p_CaxF9nYHq7rOGFu9pj42Vi);
            n1.CompilationHelper.SafeDispose(this.__p_U8ET1BOsUw7QOcOofyN4T4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 208215U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DBbz1mSxh6YMSobyUyAwvK", Name = "Splitter", IsManaged = true, IsAutoGenerated = true)]
        public n18.SplitterNode<T> __p_DBbz1mSxh6YMSobyUyAwvK;
        [n1.ElementAttribute(TracingId = 208245U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "CaxF9nYHq7rOGFu9pj42Vi", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n18.HoldLatest<T> __p_CaxF9nYHq7rOGFu9pj42Vi;
        [n1.ElementAttribute(TracingId = 207885U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "U8ET1BOsUw7QOcOofyN4T4", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n18.HoldLatest<n2.Exception> __p_U8ET1BOsUw7QOcOofyN4T4;
        public HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx(HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> other): base(other)
        {
            this.__p_DBbz1mSxh6YMSobyUyAwvK = other.__p_DBbz1mSxh6YMSobyUyAwvK;
            this.__p_CaxF9nYHq7rOGFu9pj42Vi = other.__p_CaxF9nYHq7rOGFu9pj42Vi;
            this.__p_U8ET1BOsUw7QOcOofyN4T4 = other.__p_U8ET1BOsUw7QOcOofyN4T4;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DBbz1mSxh6YMSobyUyAwvK", in __p_DBbz1mSxh6YMSobyUyAwvK), n1.CompilationHelper.GetValueOrExisting(values, "__p_CaxF9nYHq7rOGFu9pj42Vi", in __p_CaxF9nYHq7rOGFu9pj42Vi), n1.CompilationHelper.GetValueOrExisting(values, "__p_U8ET1BOsUw7QOcOofyN4T4", in __p_U8ET1BOsUw7QOcOofyN4T4));
        }

        internal HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> __WITH__(n18.SplitterNode<T> __p_DBbz1mSxh6YMSobyUyAwvK, n18.HoldLatest<T> __p_CaxF9nYHq7rOGFu9pj42Vi, n18.HoldLatest<n2.Exception> __p_U8ET1BOsUw7QOcOofyN4T4)
        {
            n3.HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DBbz1mSxh6YMSobyUyAwvK != this.__p_DBbz1mSxh6YMSobyUyAwvK || __p_CaxF9nYHq7rOGFu9pj42Vi != this.__p_CaxF9nYHq7rOGFu9pj42Vi || __p_U8ET1BOsUw7QOcOofyN4T4 != this.__p_U8ET1BOsUw7QOcOofyN4T4 ? new HoldLatestError_NZSiSuCpMvdPCnpJ1Mpmkx<T>(this)
                {__p_DBbz1mSxh6YMSobyUyAwvK = __p_DBbz1mSxh6YMSobyUyAwvK, __p_CaxF9nYHq7rOGFu9pj42Vi = __p_CaxF9nYHq7rOGFu9pj42Vi, __p_U8ET1BOsUw7QOcOofyN4T4 = __p_U8ET1BOsUw7QOcOofyN4T4} : that_0;
            else
            {
                this.__p_DBbz1mSxh6YMSobyUyAwvK = __p_DBbz1mSxh6YMSobyUyAwvK;
                this.__p_CaxF9nYHq7rOGFu9pj42Vi = __p_CaxF9nYHq7rOGFu9pj42Vi;
                this.__p_U8ET1BOsUw7QOcOofyN4T4 = __p_U8ET1BOsUw7QOcOofyN4T4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 208334U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "IgyGg5kwKKONCipLkZ9fth", Name = "VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth")]
    [n2.SerializableAttribute]
    public class VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n3.VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n3.VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth CreateDefault()
        {
            var instance = new VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth Update()
        {
            return this;
        }

        public n3.VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth __CreateDefault__()
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

        public VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth(VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_ReactiveApplication_IgyGg5kwKKONCipLkZ9fth __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Reactive_.Reactive.AsyncTask
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.AsyncTask<T> Output_Out)
        {
            var Output_0 = new n18.AsyncTask<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T, TState>(n18.AsyncTask<T> Input_In, n2.Func<TState> Create_In, n2.Func<TState, n30.CancellationToken, n2.Tuple<TState, T>> Update_In, bool Trigger_In, bool Abort_In, out n18.AsyncTask<T> Output_Out, out n2.IObservable<T> Result_Out, out bool In_Progress_Out)
            where TState : class
        {
            var Result_1 = Input_In.Update<TState>(create: Create_In, update: Update_In, trigger: Trigger_In, abort: Abort_In, inProgress: out bool In_Progress_0);
            Output_Out = Input_In;
            Result_Out = Result_1;
            In_Progress_Out = In_Progress_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.AsyncLoop
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<TState, T>(n1.NodeContext Node_Context, out n18.AsyncLoop<TState, T> Output_Out)
            where TState : class
        {
            var Output_0 = new n18.AsyncLoop<TState, T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T>(n18.AsyncLoop<TState, T> Input_In, n2.Func<TState> Create_In, n2.Func<TState, n30.CancellationToken, n2.Tuple<TState, T, bool>> Update_In, bool Restart_In, bool Abort_In, out n18.AsyncLoop<TState, T> Output_Out, out n2.IObservable<T> Result_Out, out bool In_Progress_Out)
            where TState : class
        {
            var Result_1 = Input_In.Update(create: Create_In, update: Update_In, restart: Restart_In, abort: Abort_In, inProgress: out bool In_Progress_0);
            Output_Out = Input_In;
            Result_Out = Result_1;
            In_Progress_Out = In_Progress_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Advanced
{
    [n1.ElementAttribute(TracingId = 204483U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "F4mUOvKeVLAMR1yATfEJEA", Name = "ObserveOn_F4mUOvKeVLAMR1yATfEJEA")]
    [n2.SerializableAttribute]
    public class ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T> where T2 : n21.IScheduler
    {
        [n5.CreateNewAttribute]
        public static n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> Update<AdM>(T3 Value_In, T2 Scheduler_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_QBQBbhNTDktQBwQ9zHsBh1.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_UMxNorUCzI5LdHQ4GfobUm.Update(Value_In: Scheduler_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n21.IScheduler Scheduler_8 = (n21.IScheduler)Scheduler_In;
            n2.IObservable<T> Input_9 = (n2.IObservable<T>)Value_In;
            var __fallback___10 = n1.ServiceRegistry.Current;
            var Output_14 = this.__p_Riwsx9qXsldPSO3TuwSzwH.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_11 = __fallback___10.MakeCurrentIfNone();
                var Output_12 = n14.Observable.ObserveOn<T>(source: Input_9, scheduler: Scheduler_8);
                return Output_12;
            }

            , Result_Out: out n2.IObservable<T> Result_13);
            Result_Out = Result_13;
            n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Output_3 != this.__p_QBQBbhNTDktQBwQ9zHsBh1 || Output_6 != this.__p_UMxNorUCzI5LdHQ4GfobUm || Output_14 != this.__p_Riwsx9qXsldPSO3TuwSzwH ? new ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2>(this)
                {__p_QBQBbhNTDktQBwQ9zHsBh1 = Output_3, __p_UMxNorUCzI5LdHQ4GfobUm = Output_6, __p_Riwsx9qXsldPSO3TuwSzwH = Output_14} : that_15;
            else
            {
                this.__p_QBQBbhNTDktQBwQ9zHsBh1 = Output_3;
                this.__p_UMxNorUCzI5LdHQ4GfobUm = Output_6;
                this.__p_Riwsx9qXsldPSO3TuwSzwH = Output_14;
            }

            return that_15;
        }

        public n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "QBQBbhNTDktQBwQ9zHsBh1", 204488U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "UMxNorUCzI5LdHQ4GfobUm", 204492U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Riwsx9qXsldPSO3TuwSzwH", 204501U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> that_9 = this;
            this.__p_QBQBbhNTDktQBwQ9zHsBh1 = Output_3;
            this.__p_UMxNorUCzI5LdHQ4GfobUm = Output_6;
            this.__p_Riwsx9qXsldPSO3TuwSzwH = Output_8;
            return that_9;
        }

        public n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> that_1 = this;
            this.__p_QBQBbhNTDktQBwQ9zHsBh1 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_UMxNorUCzI5LdHQ4GfobUm = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_Riwsx9qXsldPSO3TuwSzwH = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QBQBbhNTDktQBwQ9zHsBh1);
            n1.CompilationHelper.SafeDispose(this.__p_UMxNorUCzI5LdHQ4GfobUm);
            n1.CompilationHelper.SafeDispose(this.__p_Riwsx9qXsldPSO3TuwSzwH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204488U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "QBQBbhNTDktQBwQ9zHsBh1", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_QBQBbhNTDktQBwQ9zHsBh1;
        [n1.ElementAttribute(TracingId = 204492U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "UMxNorUCzI5LdHQ4GfobUm", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_UMxNorUCzI5LdHQ4GfobUm;
        [n1.ElementAttribute(TracingId = 204501U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Riwsx9qXsldPSO3TuwSzwH", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_Riwsx9qXsldPSO3TuwSzwH;
        public ObserveOn_F4mUOvKeVLAMR1yATfEJEA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ObserveOn_F4mUOvKeVLAMR1yATfEJEA(ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> other): base(other)
        {
            this.__p_QBQBbhNTDktQBwQ9zHsBh1 = other.__p_QBQBbhNTDktQBwQ9zHsBh1;
            this.__p_UMxNorUCzI5LdHQ4GfobUm = other.__p_UMxNorUCzI5LdHQ4GfobUm;
            this.__p_Riwsx9qXsldPSO3TuwSzwH = other.__p_Riwsx9qXsldPSO3TuwSzwH;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QBQBbhNTDktQBwQ9zHsBh1", in __p_QBQBbhNTDktQBwQ9zHsBh1), n1.CompilationHelper.GetValueOrExisting(values, "__p_UMxNorUCzI5LdHQ4GfobUm", in __p_UMxNorUCzI5LdHQ4GfobUm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Riwsx9qXsldPSO3TuwSzwH", in __p_Riwsx9qXsldPSO3TuwSzwH));
        }

        internal ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_QBQBbhNTDktQBwQ9zHsBh1, n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_UMxNorUCzI5LdHQ4GfobUm, n11.ToObservable_Switch_Factory_C<T> __p_Riwsx9qXsldPSO3TuwSzwH)
        {
            n11.ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QBQBbhNTDktQBwQ9zHsBh1 != this.__p_QBQBbhNTDktQBwQ9zHsBh1 || __p_UMxNorUCzI5LdHQ4GfobUm != this.__p_UMxNorUCzI5LdHQ4GfobUm || __p_Riwsx9qXsldPSO3TuwSzwH != this.__p_Riwsx9qXsldPSO3TuwSzwH ? new ObserveOn_F4mUOvKeVLAMR1yATfEJEA<T3, T, T2>(this)
                {__p_QBQBbhNTDktQBwQ9zHsBh1 = __p_QBQBbhNTDktQBwQ9zHsBh1, __p_UMxNorUCzI5LdHQ4GfobUm = __p_UMxNorUCzI5LdHQ4GfobUm, __p_Riwsx9qXsldPSO3TuwSzwH = __p_Riwsx9qXsldPSO3TuwSzwH} : that_0;
            else
            {
                this.__p_QBQBbhNTDktQBwQ9zHsBh1 = __p_QBQBbhNTDktQBwQ9zHsBh1;
                this.__p_UMxNorUCzI5LdHQ4GfobUm = __p_UMxNorUCzI5LdHQ4GfobUm;
                this.__p_Riwsx9qXsldPSO3TuwSzwH = __p_Riwsx9qXsldPSO3TuwSzwH;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204532U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "OqUWvqY7MYgLZyVwn6WULj", Name = "SubscribeOn_OqUWvqY7MYgLZyVwn6WULj")]
    [n2.SerializableAttribute]
    public class SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T> where T2 : n21.IScheduler
    {
        [n5.CreateNewAttribute]
        public static n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> Update<AdM>(T3 Value_In, T2 Scheduler_In, out n2.IObservable<T> Result_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_JTe6LKwSq4hNa0aam1HYGo.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_KgJfbpjQgxZOMnvxhU66JM.Update(Value_In: Scheduler_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n21.IScheduler Scheduler_8 = (n21.IScheduler)Scheduler_In;
            n2.IObservable<T> Input_9 = (n2.IObservable<T>)Value_In;
            var __fallback___10 = n1.ServiceRegistry.Current;
            var Output_14 = this.__p_U2UTHv5UAc2MdIJIE7dsxU.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_11 = __fallback___10.MakeCurrentIfNone();
                var Output_12 = n14.Observable.SubscribeOn<T>(source: Input_9, scheduler: Scheduler_8);
                return Output_12;
            }

            , Result_Out: out n2.IObservable<T> Result_13);
            Result_Out = Result_13;
            n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = Output_3 != this.__p_JTe6LKwSq4hNa0aam1HYGo || Output_6 != this.__p_KgJfbpjQgxZOMnvxhU66JM || Output_14 != this.__p_U2UTHv5UAc2MdIJIE7dsxU ? new SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2>(this)
                {__p_JTe6LKwSq4hNa0aam1HYGo = Output_3, __p_KgJfbpjQgxZOMnvxhU66JM = Output_6, __p_U2UTHv5UAc2MdIJIE7dsxU = Output_14} : that_15;
            else
            {
                this.__p_JTe6LKwSq4hNa0aam1HYGo = Output_3;
                this.__p_KgJfbpjQgxZOMnvxhU66JM = Output_6;
                this.__p_U2UTHv5UAc2MdIJIE7dsxU = Output_14;
            }

            return that_15;
        }

        public n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "JTe6LKwSq4hNa0aam1HYGo", 204537U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "KgJfbpjQgxZOMnvxhU66JM", 204541U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "U2UTHv5UAc2MdIJIE7dsxU", 204550U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> that_9 = this;
            this.__p_JTe6LKwSq4hNa0aam1HYGo = Output_3;
            this.__p_KgJfbpjQgxZOMnvxhU66JM = Output_6;
            this.__p_U2UTHv5UAc2MdIJIE7dsxU = Output_8;
            return that_9;
        }

        public n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> that_1 = this;
            this.__p_JTe6LKwSq4hNa0aam1HYGo = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_KgJfbpjQgxZOMnvxhU66JM = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_U2UTHv5UAc2MdIJIE7dsxU = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JTe6LKwSq4hNa0aam1HYGo);
            n1.CompilationHelper.SafeDispose(this.__p_KgJfbpjQgxZOMnvxhU66JM);
            n1.CompilationHelper.SafeDispose(this.__p_U2UTHv5UAc2MdIJIE7dsxU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204537U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "JTe6LKwSq4hNa0aam1HYGo", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_JTe6LKwSq4hNa0aam1HYGo;
        [n1.ElementAttribute(TracingId = 204541U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "KgJfbpjQgxZOMnvxhU66JM", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_KgJfbpjQgxZOMnvxhU66JM;
        [n1.ElementAttribute(TracingId = 204550U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "U2UTHv5UAc2MdIJIE7dsxU", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_U2UTHv5UAc2MdIJIE7dsxU;
        public SubscribeOn_OqUWvqY7MYgLZyVwn6WULj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SubscribeOn_OqUWvqY7MYgLZyVwn6WULj(SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> other): base(other)
        {
            this.__p_JTe6LKwSq4hNa0aam1HYGo = other.__p_JTe6LKwSq4hNa0aam1HYGo;
            this.__p_KgJfbpjQgxZOMnvxhU66JM = other.__p_KgJfbpjQgxZOMnvxhU66JM;
            this.__p_U2UTHv5UAc2MdIJIE7dsxU = other.__p_U2UTHv5UAc2MdIJIE7dsxU;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JTe6LKwSq4hNa0aam1HYGo", in __p_JTe6LKwSq4hNa0aam1HYGo), n1.CompilationHelper.GetValueOrExisting(values, "__p_KgJfbpjQgxZOMnvxhU66JM", in __p_KgJfbpjQgxZOMnvxhU66JM), n1.CompilationHelper.GetValueOrExisting(values, "__p_U2UTHv5UAc2MdIJIE7dsxU", in __p_U2UTHv5UAc2MdIJIE7dsxU));
        }

        internal SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_JTe6LKwSq4hNa0aam1HYGo, n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_KgJfbpjQgxZOMnvxhU66JM, n11.ToObservable_Switch_Factory_C<T> __p_U2UTHv5UAc2MdIJIE7dsxU)
        {
            n11.SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JTe6LKwSq4hNa0aam1HYGo != this.__p_JTe6LKwSq4hNa0aam1HYGo || __p_KgJfbpjQgxZOMnvxhU66JM != this.__p_KgJfbpjQgxZOMnvxhU66JM || __p_U2UTHv5UAc2MdIJIE7dsxU != this.__p_U2UTHv5UAc2MdIJIE7dsxU ? new SubscribeOn_OqUWvqY7MYgLZyVwn6WULj<T3, T, T2>(this)
                {__p_JTe6LKwSq4hNa0aam1HYGo = __p_JTe6LKwSq4hNa0aam1HYGo, __p_KgJfbpjQgxZOMnvxhU66JM = __p_KgJfbpjQgxZOMnvxhU66JM, __p_U2UTHv5UAc2MdIJIE7dsxU = __p_U2UTHv5UAc2MdIJIE7dsxU} : that_0;
            else
            {
                this.__p_JTe6LKwSq4hNa0aam1HYGo = __p_JTe6LKwSq4hNa0aam1HYGo;
                this.__p_KgJfbpjQgxZOMnvxhU66JM = __p_KgJfbpjQgxZOMnvxhU66JM;
                this.__p_U2UTHv5UAc2MdIJIE7dsxU = __p_U2UTHv5UAc2MdIJIE7dsxU;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204582U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EoyRQUM1DNAPhPDcGsxhuR", Name = "ToObservable_Switch_Factory_C")]
    [n2.SerializableAttribute]
    public class ToObservable_Switch_Factory_C<T> : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.ToObservable_Switch_Factory_C<T> Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new ToObservable_Switch_Factory_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.ToObservable_Switch_Factory_C<T> CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new ToObservable_Switch_Factory_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.ToObservable_Switch_Factory_C<T> Update<T2, AdM>(n2.Func<T2> Factory_In, bool Send_In, out n2.IObservable<T> Result_Out)
            where T2 : n2.IObservable<T> where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T2 Output_1);
            T2 __auto_2;
            if (Send_In)
            {
                n36._Operations_.Invoke<T2>(Input_In: Factory_In, Result_Out: out T2 Result_4);
                __auto_2 = Result_4;
            }
            else
            {
                __auto_2 = Output_1;
            }

            n2.IObservable<T> Message_5 = (n2.IObservable<T>)__auto_2;
            n19._Operations_.Update<T>(Input_In: this.__p_NsvyNJFuoK7PKKHtwuUPWP, Message_In: Message_5, Send_In: Send_In, Output_Out: out n18.ToObservableSwitch<T> Output_6, Result_Out: out n2.IObservable<T> Result_7);
            this.__p_NsvyNJFuoK7PKKHtwuUPWP = Output_6;
            Result_Out = Result_7;
            return this;
        }

        public n11.ToObservable_Switch_Factory_C<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "NsvyNJFuoK7PKKHtwuUPWP", 204598U);
            n19._Operations_.Create<T>(Node_Context: Node_Context_0, Output_Out: out n18.ToObservableSwitch<T> Output_1);
            this.__p_NsvyNJFuoK7PKKHtwuUPWP = Output_1;
            return this;
        }

        public n11.ToObservable_Switch_Factory_C<T> __CreateDefault__()
        {
            this.__p_NsvyNJFuoK7PKKHtwuUPWP = default(n18.ToObservableSwitch<T>);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NsvyNJFuoK7PKKHtwuUPWP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204598U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "NsvyNJFuoK7PKKHtwuUPWP", Name = "ToObservable (Switch)", IsManaged = true, IsAutoGenerated = true)]
        public n18.ToObservableSwitch<T> __p_NsvyNJFuoK7PKKHtwuUPWP;
        public ToObservable_Switch_Factory_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToObservable_Switch_Factory_C(ToObservable_Switch_Factory_C<T> other): base(other)
        {
            this.__p_NsvyNJFuoK7PKKHtwuUPWP = other.__p_NsvyNJFuoK7PKKHtwuUPWP;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NsvyNJFuoK7PKKHtwuUPWP", in __p_NsvyNJFuoK7PKKHtwuUPWP));
        }

        internal ToObservable_Switch_Factory_C<T> __WITH__(n18.ToObservableSwitch<T> __p_NsvyNJFuoK7PKKHtwuUPWP)
        {
            n11.ToObservable_Switch_Factory_C<T> that_0 = this;
            this.__p_NsvyNJFuoK7PKKHtwuUPWP = __p_NsvyNJFuoK7PKKHtwuUPWP;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204730U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "TIVntx4u9wKOYbpyhwUlcm", Name = "Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm")]
    [n2.SerializableAttribute]
    public class Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm Create(n1.NodeContext Node_Context)
        {
            var instance = new Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm CreateDefault()
        {
            var instance = new Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm Update(n2.TimeSpan Period_In, n21.IScheduler Scheduler_In, out n2.IObservable<long> Result_Out, out bool Changed_Out)
        {
            var Output_2 = this.__p_Cw9x6YLeG7sObVe7LOlVEK.Update(Value_In: Period_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var Output_5 = this.__p_BMGqhpbF8wPMaNBqhWXOTd.Update(Value_In: Scheduler_In, Result_Out: out bool Result_3, Unchanged_Out: out bool Unchanged_4);
            var Output_6 = Result_0 || Result_3;
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_QfXJIwgAdJpLz3QkLmqFVm.Update<n2.IObservable<long>, n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Send_In: Output_6, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                var Result_9 = n14.Observable.Interval(period: Period_In, scheduler: Scheduler_In);
                return Result_9;
            }

            , Result_Out: out n2.IObservable<long> Result_10);
            Result_Out = Result_10;
            Changed_Out = Output_6;
            n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_2 != this.__p_Cw9x6YLeG7sObVe7LOlVEK || Output_5 != this.__p_BMGqhpbF8wPMaNBqhWXOTd || Output_11 != this.__p_QfXJIwgAdJpLz3QkLmqFVm ? new Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(this)
                {__p_Cw9x6YLeG7sObVe7LOlVEK = Output_2, __p_BMGqhpbF8wPMaNBqhWXOTd = Output_5, __p_QfXJIwgAdJpLz3QkLmqFVm = Output_11} : that_12;
            else
            {
                this.__p_Cw9x6YLeG7sObVe7LOlVEK = Output_2;
                this.__p_BMGqhpbF8wPMaNBqhWXOTd = Output_5;
                this.__p_QfXJIwgAdJpLz3QkLmqFVm = Output_11;
            }

            return that_12;
        }

        public n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Cw9x6YLeG7sObVe7LOlVEK", 204733U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "QfXJIwgAdJpLz3QkLmqFVm", 204739U);
            var Output_4 = n11.ToObservable_Switch_Factory_C<long>.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "BMGqhpbF8wPMaNBqhWXOTd", 204750U);
            bool Changed_On_Create_6 = true;
            var Output_7 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_5, Changed_On_Create_In: Changed_On_Create_6);
            n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm that_8 = this;
            this.__p_Cw9x6YLeG7sObVe7LOlVEK = Output_2;
            this.__p_QfXJIwgAdJpLz3QkLmqFVm = Output_4;
            this.__p_BMGqhpbF8wPMaNBqhWXOTd = Output_7;
            return that_8;
        }

        public n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm __CreateDefault__()
        {
            n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm that_0 = this;
            this.__p_Cw9x6YLeG7sObVe7LOlVEK = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_BMGqhpbF8wPMaNBqhWXOTd = n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_QfXJIwgAdJpLz3QkLmqFVm = n11.ToObservable_Switch_Factory_C<long>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Cw9x6YLeG7sObVe7LOlVEK);
            n1.CompilationHelper.SafeDispose(this.__p_BMGqhpbF8wPMaNBqhWXOTd);
            n1.CompilationHelper.SafeDispose(this.__p_QfXJIwgAdJpLz3QkLmqFVm);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204733U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Cw9x6YLeG7sObVe7LOlVEK", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_Cw9x6YLeG7sObVe7LOlVEK;
        [n1.ElementAttribute(TracingId = 204750U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "BMGqhpbF8wPMaNBqhWXOTd", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler> __p_BMGqhpbF8wPMaNBqhWXOTd;
        [n1.ElementAttribute(TracingId = 204739U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "QfXJIwgAdJpLz3QkLmqFVm", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<long> __p_QfXJIwgAdJpLz3QkLmqFVm;
        public Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm other): base(other)
        {
            this.__p_Cw9x6YLeG7sObVe7LOlVEK = other.__p_Cw9x6YLeG7sObVe7LOlVEK;
            this.__p_BMGqhpbF8wPMaNBqhWXOTd = other.__p_BMGqhpbF8wPMaNBqhWXOTd;
            this.__p_QfXJIwgAdJpLz3QkLmqFVm = other.__p_QfXJIwgAdJpLz3QkLmqFVm;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Cw9x6YLeG7sObVe7LOlVEK", in __p_Cw9x6YLeG7sObVe7LOlVEK), n1.CompilationHelper.GetValueOrExisting(values, "__p_BMGqhpbF8wPMaNBqhWXOTd", in __p_BMGqhpbF8wPMaNBqhWXOTd), n1.CompilationHelper.GetValueOrExisting(values, "__p_QfXJIwgAdJpLz3QkLmqFVm", in __p_QfXJIwgAdJpLz3QkLmqFVm));
        }

        internal Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_Cw9x6YLeG7sObVe7LOlVEK, n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler> __p_BMGqhpbF8wPMaNBqhWXOTd, n11.ToObservable_Switch_Factory_C<long> __p_QfXJIwgAdJpLz3QkLmqFVm)
        {
            n11.Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Cw9x6YLeG7sObVe7LOlVEK != this.__p_Cw9x6YLeG7sObVe7LOlVEK || __p_BMGqhpbF8wPMaNBqhWXOTd != this.__p_BMGqhpbF8wPMaNBqhWXOTd || __p_QfXJIwgAdJpLz3QkLmqFVm != this.__p_QfXJIwgAdJpLz3QkLmqFVm ? new Interval_Scheduler_TIVntx4u9wKOYbpyhwUlcm(this)
                {__p_Cw9x6YLeG7sObVe7LOlVEK = __p_Cw9x6YLeG7sObVe7LOlVEK, __p_BMGqhpbF8wPMaNBqhWXOTd = __p_BMGqhpbF8wPMaNBqhWXOTd, __p_QfXJIwgAdJpLz3QkLmqFVm = __p_QfXJIwgAdJpLz3QkLmqFVm} : that_0;
            else
            {
                this.__p_Cw9x6YLeG7sObVe7LOlVEK = __p_Cw9x6YLeG7sObVe7LOlVEK;
                this.__p_BMGqhpbF8wPMaNBqhWXOTd = __p_BMGqhpbF8wPMaNBqhWXOTd;
                this.__p_QfXJIwgAdJpLz3QkLmqFVm = __p_QfXJIwgAdJpLz3QkLmqFVm;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204783U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "S0h3L3sZJgNOx3wRQLzJy7", Name = "Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7")]
    [n2.SerializableAttribute]
    public class Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 Create(n1.NodeContext Node_Context)
        {
            var instance = new Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 CreateDefault()
        {
            var instance = new Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 Update(n2.TimeSpan Due_Time_In, n2.TimeSpan Period_In, n21.IScheduler Scheduler_In, out n2.IObservable<long> Result_Out, out bool Changed_Out)
        {
            var Output_2 = this.__p_PFF4CcxlHmUPtR7V8VsyRT.Update(Value_In: Due_Time_In, Result_Out: out bool Result_0, Unchanged_Out: out bool Unchanged_1);
            var Output_5 = this.__p_VAVwIPOFDzNNfaurnKfKeF.Update(Value_In: Period_In, Result_Out: out bool Result_3, Unchanged_Out: out bool Unchanged_4);
            var Output_8 = this.__p_HeUoU7voZXFPJfO5AYlMQQ.Update(Value_In: Scheduler_In, Result_Out: out bool Result_6, Unchanged_Out: out bool Unchanged_7);
            var Output_9 = Result_0 || Result_3;
            var Output_10 = Output_9 || Result_6;
            var __fallback___11 = n1.ServiceRegistry.Current;
            var Output_15 = this.__p_GfurezGAb9aPw3oZfrn3OU.Update<n2.IObservable<long>, n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Send_In: Output_10, Factory_In: () =>
            {
                using var __current_12 = __fallback___11.MakeCurrentIfNone();
                var Result_13 = n14.Observable.Timer(dueTime: Due_Time_In, period: Period_In, scheduler: Scheduler_In);
                return Result_13;
            }

            , Result_Out: out n2.IObservable<long> Result_14);
            Result_Out = Result_14;
            Changed_Out = Output_10;
            n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = Output_2 != this.__p_PFF4CcxlHmUPtR7V8VsyRT || Output_5 != this.__p_VAVwIPOFDzNNfaurnKfKeF || Output_8 != this.__p_HeUoU7voZXFPJfO5AYlMQQ || Output_15 != this.__p_GfurezGAb9aPw3oZfrn3OU ? new Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(this)
                {__p_PFF4CcxlHmUPtR7V8VsyRT = Output_2, __p_VAVwIPOFDzNNfaurnKfKeF = Output_5, __p_HeUoU7voZXFPJfO5AYlMQQ = Output_8, __p_GfurezGAb9aPw3oZfrn3OU = Output_15} : that_16;
            else
            {
                this.__p_PFF4CcxlHmUPtR7V8VsyRT = Output_2;
                this.__p_VAVwIPOFDzNNfaurnKfKeF = Output_5;
                this.__p_HeUoU7voZXFPJfO5AYlMQQ = Output_8;
                this.__p_GfurezGAb9aPw3oZfrn3OU = Output_15;
            }

            return that_16;
        }

        public n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "PFF4CcxlHmUPtR7V8VsyRT", 204786U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "VAVwIPOFDzNNfaurnKfKeF", 204798U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "GfurezGAb9aPw3oZfrn3OU", 204803U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<long>.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "HeUoU7voZXFPJfO5AYlMQQ", 204815U);
            bool Changed_On_Create_9 = true;
            var Output_10 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_8, Changed_On_Create_In: Changed_On_Create_9);
            n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 that_11 = this;
            this.__p_PFF4CcxlHmUPtR7V8VsyRT = Output_2;
            this.__p_VAVwIPOFDzNNfaurnKfKeF = Output_5;
            this.__p_GfurezGAb9aPw3oZfrn3OU = Output_7;
            this.__p_HeUoU7voZXFPJfO5AYlMQQ = Output_10;
            return that_11;
        }

        public n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 __CreateDefault__()
        {
            n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 that_0 = this;
            this.__p_PFF4CcxlHmUPtR7V8VsyRT = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_VAVwIPOFDzNNfaurnKfKeF = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_HeUoU7voZXFPJfO5AYlMQQ = n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_GfurezGAb9aPw3oZfrn3OU = n11.ToObservable_Switch_Factory_C<long>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PFF4CcxlHmUPtR7V8VsyRT);
            n1.CompilationHelper.SafeDispose(this.__p_VAVwIPOFDzNNfaurnKfKeF);
            n1.CompilationHelper.SafeDispose(this.__p_HeUoU7voZXFPJfO5AYlMQQ);
            n1.CompilationHelper.SafeDispose(this.__p_GfurezGAb9aPw3oZfrn3OU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204786U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "PFF4CcxlHmUPtR7V8VsyRT", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_PFF4CcxlHmUPtR7V8VsyRT;
        [n1.ElementAttribute(TracingId = 204798U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "VAVwIPOFDzNNfaurnKfKeF", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_VAVwIPOFDzNNfaurnKfKeF;
        [n1.ElementAttribute(TracingId = 204815U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HeUoU7voZXFPJfO5AYlMQQ", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler> __p_HeUoU7voZXFPJfO5AYlMQQ;
        [n1.ElementAttribute(TracingId = 204803U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "GfurezGAb9aPw3oZfrn3OU", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<long> __p_GfurezGAb9aPw3oZfrn3OU;
        public Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 other): base(other)
        {
            this.__p_PFF4CcxlHmUPtR7V8VsyRT = other.__p_PFF4CcxlHmUPtR7V8VsyRT;
            this.__p_VAVwIPOFDzNNfaurnKfKeF = other.__p_VAVwIPOFDzNNfaurnKfKeF;
            this.__p_HeUoU7voZXFPJfO5AYlMQQ = other.__p_HeUoU7voZXFPJfO5AYlMQQ;
            this.__p_GfurezGAb9aPw3oZfrn3OU = other.__p_GfurezGAb9aPw3oZfrn3OU;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PFF4CcxlHmUPtR7V8VsyRT", in __p_PFF4CcxlHmUPtR7V8VsyRT), n1.CompilationHelper.GetValueOrExisting(values, "__p_VAVwIPOFDzNNfaurnKfKeF", in __p_VAVwIPOFDzNNfaurnKfKeF), n1.CompilationHelper.GetValueOrExisting(values, "__p_HeUoU7voZXFPJfO5AYlMQQ", in __p_HeUoU7voZXFPJfO5AYlMQQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_GfurezGAb9aPw3oZfrn3OU", in __p_GfurezGAb9aPw3oZfrn3OU));
        }

        internal Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_PFF4CcxlHmUPtR7V8VsyRT, n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_VAVwIPOFDzNNfaurnKfKeF, n10.Changed_A8JGbead2bxNdnPybiEqVS<n21.IScheduler> __p_HeUoU7voZXFPJfO5AYlMQQ, n11.ToObservable_Switch_Factory_C<long> __p_GfurezGAb9aPw3oZfrn3OU)
        {
            n11.Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PFF4CcxlHmUPtR7V8VsyRT != this.__p_PFF4CcxlHmUPtR7V8VsyRT || __p_VAVwIPOFDzNNfaurnKfKeF != this.__p_VAVwIPOFDzNNfaurnKfKeF || __p_HeUoU7voZXFPJfO5AYlMQQ != this.__p_HeUoU7voZXFPJfO5AYlMQQ || __p_GfurezGAb9aPw3oZfrn3OU != this.__p_GfurezGAb9aPw3oZfrn3OU ? new Timer_Scheduler_S0h3L3sZJgNOx3wRQLzJy7(this)
                {__p_PFF4CcxlHmUPtR7V8VsyRT = __p_PFF4CcxlHmUPtR7V8VsyRT, __p_VAVwIPOFDzNNfaurnKfKeF = __p_VAVwIPOFDzNNfaurnKfKeF, __p_HeUoU7voZXFPJfO5AYlMQQ = __p_HeUoU7voZXFPJfO5AYlMQQ, __p_GfurezGAb9aPw3oZfrn3OU = __p_GfurezGAb9aPw3oZfrn3OU} : that_0;
            else
            {
                this.__p_PFF4CcxlHmUPtR7V8VsyRT = __p_PFF4CcxlHmUPtR7V8VsyRT;
                this.__p_VAVwIPOFDzNNfaurnKfKeF = __p_VAVwIPOFDzNNfaurnKfKeF;
                this.__p_HeUoU7voZXFPJfO5AYlMQQ = __p_HeUoU7voZXFPJfO5AYlMQQ;
                this.__p_GfurezGAb9aPw3oZfrn3OU = __p_GfurezGAb9aPw3oZfrn3OU;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204848U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "LvsQ92IwaWSOTxoGAtewZr", Name = "Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr")]
    [n2.SerializableAttribute]
    public class Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> CreateDefault()
        {
            var instance = new Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> Update<T2, AdM>(n2.Func<T> Function_In, bool Run_In, T2 Scheduler_In, out n2.IObservable<T> Result_Out)
            where T2 : n21.IScheduler where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            n21.IScheduler Scheduler_1 = (n21.IScheduler)Scheduler_In;
            var __fallback___2 = n1.ServiceRegistry.Current;
            var Output_6 = this.__p_F755YION4J8QPsVOEyoCKj.Update<n2.IObservable<T>, AdM>(Send_In: Run_In, Factory_In: () =>
            {
                using var __current_3 = __fallback___2.MakeCurrentIfNone();
                var Result_4 = n14.Observable.Start<T>(function: Function_In, scheduler: Scheduler_1);
                return Result_4;
            }

            , Result_Out: out n2.IObservable<T> Result_5);
            Result_Out = Result_5;
            n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_6 != this.__p_F755YION4J8QPsVOEyoCKj ? new Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T>(this)
                {__p_F755YION4J8QPsVOEyoCKj = Output_6} : that_7;
            else
            {
                this.__p_F755YION4J8QPsVOEyoCKj = Output_6;
            }

            return that_7;
        }

        public n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "F755YION4J8QPsVOEyoCKj", 204854U);
            var Output_1 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_0);
            n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> that_2 = this;
            this.__p_F755YION4J8QPsVOEyoCKj = Output_1;
            return that_2;
        }

        public n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> __CreateDefault__()
        {
            n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> that_0 = this;
            this.__p_F755YION4J8QPsVOEyoCKj = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_F755YION4J8QPsVOEyoCKj);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204854U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "F755YION4J8QPsVOEyoCKj", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_F755YION4J8QPsVOEyoCKj;
        public Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr(Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> other): base(other)
        {
            this.__p_F755YION4J8QPsVOEyoCKj = other.__p_F755YION4J8QPsVOEyoCKj;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F755YION4J8QPsVOEyoCKj", in __p_F755YION4J8QPsVOEyoCKj));
        }

        internal Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> __WITH__(n11.ToObservable_Switch_Factory_C<T> __p_F755YION4J8QPsVOEyoCKj)
        {
            n11.Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_F755YION4J8QPsVOEyoCKj != this.__p_F755YION4J8QPsVOEyoCKj ? new Start_Scheduler_LvsQ92IwaWSOTxoGAtewZr<T>(this)
                {__p_F755YION4J8QPsVOEyoCKj = __p_F755YION4J8QPsVOEyoCKj} : that_0;
            else
            {
                this.__p_F755YION4J8QPsVOEyoCKj = __p_F755YION4J8QPsVOEyoCKj;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 204965U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "UHwFxWIoziFM6ohIUbKf4j", Name = "DelaySubscription_UHwFxWIoziFM6ohIUbKf4j")]
    [n2.SerializableAttribute]
    public class DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> Update<AdM>(T2 Value_In, n2.TimeSpan Due_Time_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_TFbkKoEwfbCQBZUse6rsqp.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_EcsoyMyZbrSMM1FfgNYsv9.Update(Value_In: Due_Time_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            var __fallback___9 = n1.ServiceRegistry.Current;
            var Output_13 = this.__p_GqKvbTpW7O0NWyLoewF51r.Update<n2.IObservable<T>, AdM>(Send_In: Output_7, Factory_In: () =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                n8._Operations_.DelaySubscription<T>(Input_In: Input_8, Due_Time_In: Due_Time_In, Output_Out: out n2.IObservable<T> Output_11);
                return Output_11;
            }

            , Result_Out: out n2.IObservable<T> Result_12);
            Result_Out = Result_12;
            Changed_Out = Output_7;
            n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = Output_3 != this.__p_TFbkKoEwfbCQBZUse6rsqp || Output_6 != this.__p_EcsoyMyZbrSMM1FfgNYsv9 || Output_13 != this.__p_GqKvbTpW7O0NWyLoewF51r ? new DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T>(this)
                {__p_TFbkKoEwfbCQBZUse6rsqp = Output_3, __p_EcsoyMyZbrSMM1FfgNYsv9 = Output_6, __p_GqKvbTpW7O0NWyLoewF51r = Output_13} : that_14;
            else
            {
                this.__p_TFbkKoEwfbCQBZUse6rsqp = Output_3;
                this.__p_EcsoyMyZbrSMM1FfgNYsv9 = Output_6;
                this.__p_GqKvbTpW7O0NWyLoewF51r = Output_13;
            }

            return that_14;
        }

        public n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "TFbkKoEwfbCQBZUse6rsqp", 204969U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "EcsoyMyZbrSMM1FfgNYsv9", 204974U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "GqKvbTpW7O0NWyLoewF51r", 204984U);
            var Output_8 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_7);
            n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> that_9 = this;
            this.__p_TFbkKoEwfbCQBZUse6rsqp = Output_3;
            this.__p_EcsoyMyZbrSMM1FfgNYsv9 = Output_6;
            this.__p_GqKvbTpW7O0NWyLoewF51r = Output_8;
            return that_9;
        }

        public n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> that_1 = this;
            this.__p_TFbkKoEwfbCQBZUse6rsqp = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_EcsoyMyZbrSMM1FfgNYsv9 = n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            this.__p_GqKvbTpW7O0NWyLoewF51r = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TFbkKoEwfbCQBZUse6rsqp);
            n1.CompilationHelper.SafeDispose(this.__p_EcsoyMyZbrSMM1FfgNYsv9);
            n1.CompilationHelper.SafeDispose(this.__p_GqKvbTpW7O0NWyLoewF51r);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 204969U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "TFbkKoEwfbCQBZUse6rsqp", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_TFbkKoEwfbCQBZUse6rsqp;
        [n1.ElementAttribute(TracingId = 204974U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EcsoyMyZbrSMM1FfgNYsv9", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_EcsoyMyZbrSMM1FfgNYsv9;
        [n1.ElementAttribute(TracingId = 204984U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "GqKvbTpW7O0NWyLoewF51r", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_GqKvbTpW7O0NWyLoewF51r;
        public DelaySubscription_UHwFxWIoziFM6ohIUbKf4j(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DelaySubscription_UHwFxWIoziFM6ohIUbKf4j(DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> other): base(other)
        {
            this.__p_TFbkKoEwfbCQBZUse6rsqp = other.__p_TFbkKoEwfbCQBZUse6rsqp;
            this.__p_EcsoyMyZbrSMM1FfgNYsv9 = other.__p_EcsoyMyZbrSMM1FfgNYsv9;
            this.__p_GqKvbTpW7O0NWyLoewF51r = other.__p_GqKvbTpW7O0NWyLoewF51r;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TFbkKoEwfbCQBZUse6rsqp", in __p_TFbkKoEwfbCQBZUse6rsqp), n1.CompilationHelper.GetValueOrExisting(values, "__p_EcsoyMyZbrSMM1FfgNYsv9", in __p_EcsoyMyZbrSMM1FfgNYsv9), n1.CompilationHelper.GetValueOrExisting(values, "__p_GqKvbTpW7O0NWyLoewF51r", in __p_GqKvbTpW7O0NWyLoewF51r));
        }

        internal DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_TFbkKoEwfbCQBZUse6rsqp, n10.Changed_A8JGbead2bxNdnPybiEqVS<n2.TimeSpan> __p_EcsoyMyZbrSMM1FfgNYsv9, n11.ToObservable_Switch_Factory_C<T> __p_GqKvbTpW7O0NWyLoewF51r)
        {
            n11.DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_TFbkKoEwfbCQBZUse6rsqp != this.__p_TFbkKoEwfbCQBZUse6rsqp || __p_EcsoyMyZbrSMM1FfgNYsv9 != this.__p_EcsoyMyZbrSMM1FfgNYsv9 || __p_GqKvbTpW7O0NWyLoewF51r != this.__p_GqKvbTpW7O0NWyLoewF51r ? new DelaySubscription_UHwFxWIoziFM6ohIUbKf4j<T2, T>(this)
                {__p_TFbkKoEwfbCQBZUse6rsqp = __p_TFbkKoEwfbCQBZUse6rsqp, __p_EcsoyMyZbrSMM1FfgNYsv9 = __p_EcsoyMyZbrSMM1FfgNYsv9, __p_GqKvbTpW7O0NWyLoewF51r = __p_GqKvbTpW7O0NWyLoewF51r} : that_0;
            else
            {
                this.__p_TFbkKoEwfbCQBZUse6rsqp = __p_TFbkKoEwfbCQBZUse6rsqp;
                this.__p_EcsoyMyZbrSMM1FfgNYsv9 = __p_EcsoyMyZbrSMM1FfgNYsv9;
                this.__p_GqKvbTpW7O0NWyLoewF51r = __p_GqKvbTpW7O0NWyLoewF51r;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 205018U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "FQ7XtdMDBGPLleeBUkCLzC", Name = "Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC")]
    [n2.SerializableAttribute]
    public class Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> : n1.VLObject, n2.IDisposable where T3 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var instance = new Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> Update<AdM>(T3 Value_In, n2.Func<T, n2.IObservable<T2>> Delay_Duration_Selector_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            n7._Operations_.Update<T, n2.IObservable<T2>>(Input_In: this.__p_ObVRkNKtAuLM00bqXwDUBZ, Delegate_In: Delay_Duration_Selector_In, Output_Out: out n6.FuncProxy<T, n2.IObservable<T2>> Output_5, Result_Out: out n2.Func<T, n2.IObservable<T2>> Result_6);
            var __fallback___7 = n1.ServiceRegistry.Current;
            var Output_11 = this.__p_LkzDLH8uxkjOJ7uGWTD2Jb.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n8._Operations_.Delay_Selector<T, T2>(Input_In: Input_4, Delay_Duration_Selector_In: Result_6, Output_Out: out n2.IObservable<T> Output_9);
                return Output_9;
            }

            , Result_Out: out n2.IObservable<T> Result_10);
            Result_Out = Result_10;
            Changed_Out = Result_1;
            n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_3 != this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T || Output_5 != this.__p_ObVRkNKtAuLM00bqXwDUBZ || Output_11 != this.__p_LkzDLH8uxkjOJ7uGWTD2Jb ? new Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2>(this)
                {__p_GbMjTGQ2Hy8OfY2HX8Fr7T = Output_3, __p_ObVRkNKtAuLM00bqXwDUBZ = Output_5, __p_LkzDLH8uxkjOJ7uGWTD2Jb = Output_11} : that_12;
            else
            {
                this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T = Output_3;
                this.__p_ObVRkNKtAuLM00bqXwDUBZ = Output_5;
                this.__p_LkzDLH8uxkjOJ7uGWTD2Jb = Output_11;
            }

            return that_12;
        }

        public n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "GbMjTGQ2Hy8OfY2HX8Fr7T", 205022U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "ObVRkNKtAuLM00bqXwDUBZ", 205039U);
            n7._Operations_.Create<T, n2.IObservable<T2>>(Node_Context: Node_Context_4, Output_Out: out n6.FuncProxy<T, n2.IObservable<T2>> Output_5);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "LkzDLH8uxkjOJ7uGWTD2Jb", 205029U);
            var Output_7 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_6);
            n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> that_8 = this;
            this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T = Output_3;
            this.__p_ObVRkNKtAuLM00bqXwDUBZ = Output_5;
            this.__p_LkzDLH8uxkjOJ7uGWTD2Jb = Output_7;
            return that_8;
        }

        public n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T3>
        {
            var w_0 = default(AdM);
            n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> that_1 = this;
            this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T = n10.Changed_A8JGbead2bxNdnPybiEqVS<T3>.CreateDefault<AdM>();
            this.__p_ObVRkNKtAuLM00bqXwDUBZ = default(n6.FuncProxy<T, n2.IObservable<T2>>);
            this.__p_LkzDLH8uxkjOJ7uGWTD2Jb = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T);
            n1.CompilationHelper.SafeDispose(this.__p_ObVRkNKtAuLM00bqXwDUBZ);
            n1.CompilationHelper.SafeDispose(this.__p_LkzDLH8uxkjOJ7uGWTD2Jb);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 205022U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "GbMjTGQ2Hy8OfY2HX8Fr7T", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_GbMjTGQ2Hy8OfY2HX8Fr7T;
        [n1.ElementAttribute(TracingId = 205039U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "ObVRkNKtAuLM00bqXwDUBZ", Name = "Proxy (1 -> 1)", IsManaged = true, IsAutoGenerated = true)]
        public n6.FuncProxy<T, n2.IObservable<T2>> __p_ObVRkNKtAuLM00bqXwDUBZ;
        [n1.ElementAttribute(TracingId = 205029U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "LkzDLH8uxkjOJ7uGWTD2Jb", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_LkzDLH8uxkjOJ7uGWTD2Jb;
        public Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC(Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> other): base(other)
        {
            this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T = other.__p_GbMjTGQ2Hy8OfY2HX8Fr7T;
            this.__p_ObVRkNKtAuLM00bqXwDUBZ = other.__p_ObVRkNKtAuLM00bqXwDUBZ;
            this.__p_LkzDLH8uxkjOJ7uGWTD2Jb = other.__p_LkzDLH8uxkjOJ7uGWTD2Jb;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GbMjTGQ2Hy8OfY2HX8Fr7T", in __p_GbMjTGQ2Hy8OfY2HX8Fr7T), n1.CompilationHelper.GetValueOrExisting(values, "__p_ObVRkNKtAuLM00bqXwDUBZ", in __p_ObVRkNKtAuLM00bqXwDUBZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_LkzDLH8uxkjOJ7uGWTD2Jb", in __p_LkzDLH8uxkjOJ7uGWTD2Jb));
        }

        internal Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T3> __p_GbMjTGQ2Hy8OfY2HX8Fr7T, n6.FuncProxy<T, n2.IObservable<T2>> __p_ObVRkNKtAuLM00bqXwDUBZ, n11.ToObservable_Switch_Factory_C<T> __p_LkzDLH8uxkjOJ7uGWTD2Jb)
        {
            n11.Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GbMjTGQ2Hy8OfY2HX8Fr7T != this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T || __p_ObVRkNKtAuLM00bqXwDUBZ != this.__p_ObVRkNKtAuLM00bqXwDUBZ || __p_LkzDLH8uxkjOJ7uGWTD2Jb != this.__p_LkzDLH8uxkjOJ7uGWTD2Jb ? new Delay_Selector_FQ7XtdMDBGPLleeBUkCLzC<T3, T, T2>(this)
                {__p_GbMjTGQ2Hy8OfY2HX8Fr7T = __p_GbMjTGQ2Hy8OfY2HX8Fr7T, __p_ObVRkNKtAuLM00bqXwDUBZ = __p_ObVRkNKtAuLM00bqXwDUBZ, __p_LkzDLH8uxkjOJ7uGWTD2Jb = __p_LkzDLH8uxkjOJ7uGWTD2Jb} : that_0;
            else
            {
                this.__p_GbMjTGQ2Hy8OfY2HX8Fr7T = __p_GbMjTGQ2Hy8OfY2HX8Fr7T;
                this.__p_ObVRkNKtAuLM00bqXwDUBZ = __p_ObVRkNKtAuLM00bqXwDUBZ;
                this.__p_LkzDLH8uxkjOJ7uGWTD2Jb = __p_LkzDLH8uxkjOJ7uGWTD2Jb;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 205064U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Lsf50CleCKxM1BNaNyQVcY", Name = "Retry_Lsf50CleCKxM1BNaNyQVcY")]
    [n2.SerializableAttribute]
    public class Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> Update<AdM>(T2 Value_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_JDR3BmVj5hvLpv8cme0jnM.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            var __fallback___5 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_EjEFJm5vPMKNnh9iXlSTb5.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                n8._Operations_.Retry<T>(Input_In: Input_4, Output_Out: out n2.IObservable<T> Output_7);
                return Output_7;
            }

            , Result_Out: out n2.IObservable<T> Result_8);
            Result_Out = Result_8;
            Changed_Out = Result_1;
            n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_JDR3BmVj5hvLpv8cme0jnM || Output_9 != this.__p_EjEFJm5vPMKNnh9iXlSTb5 ? new Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T>(this)
                {__p_JDR3BmVj5hvLpv8cme0jnM = Output_3, __p_EjEFJm5vPMKNnh9iXlSTb5 = Output_9} : that_10;
            else
            {
                this.__p_JDR3BmVj5hvLpv8cme0jnM = Output_3;
                this.__p_EjEFJm5vPMKNnh9iXlSTb5 = Output_9;
            }

            return that_10;
        }

        public n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "JDR3BmVj5hvLpv8cme0jnM", 205068U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "EjEFJm5vPMKNnh9iXlSTb5", 205074U);
            var Output_5 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_4);
            n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> that_6 = this;
            this.__p_JDR3BmVj5hvLpv8cme0jnM = Output_3;
            this.__p_EjEFJm5vPMKNnh9iXlSTb5 = Output_5;
            return that_6;
        }

        public n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> that_1 = this;
            this.__p_JDR3BmVj5hvLpv8cme0jnM = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_EjEFJm5vPMKNnh9iXlSTb5 = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JDR3BmVj5hvLpv8cme0jnM);
            n1.CompilationHelper.SafeDispose(this.__p_EjEFJm5vPMKNnh9iXlSTb5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 205068U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "JDR3BmVj5hvLpv8cme0jnM", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_JDR3BmVj5hvLpv8cme0jnM;
        [n1.ElementAttribute(TracingId = 205074U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "EjEFJm5vPMKNnh9iXlSTb5", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_EjEFJm5vPMKNnh9iXlSTb5;
        public Retry_Lsf50CleCKxM1BNaNyQVcY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Retry_Lsf50CleCKxM1BNaNyQVcY(Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> other): base(other)
        {
            this.__p_JDR3BmVj5hvLpv8cme0jnM = other.__p_JDR3BmVj5hvLpv8cme0jnM;
            this.__p_EjEFJm5vPMKNnh9iXlSTb5 = other.__p_EjEFJm5vPMKNnh9iXlSTb5;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JDR3BmVj5hvLpv8cme0jnM", in __p_JDR3BmVj5hvLpv8cme0jnM), n1.CompilationHelper.GetValueOrExisting(values, "__p_EjEFJm5vPMKNnh9iXlSTb5", in __p_EjEFJm5vPMKNnh9iXlSTb5));
        }

        internal Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_JDR3BmVj5hvLpv8cme0jnM, n11.ToObservable_Switch_Factory_C<T> __p_EjEFJm5vPMKNnh9iXlSTb5)
        {
            n11.Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JDR3BmVj5hvLpv8cme0jnM != this.__p_JDR3BmVj5hvLpv8cme0jnM || __p_EjEFJm5vPMKNnh9iXlSTb5 != this.__p_EjEFJm5vPMKNnh9iXlSTb5 ? new Retry_Lsf50CleCKxM1BNaNyQVcY<T2, T>(this)
                {__p_JDR3BmVj5hvLpv8cme0jnM = __p_JDR3BmVj5hvLpv8cme0jnM, __p_EjEFJm5vPMKNnh9iXlSTb5 = __p_EjEFJm5vPMKNnh9iXlSTb5} : that_0;
            else
            {
                this.__p_JDR3BmVj5hvLpv8cme0jnM = __p_JDR3BmVj5hvLpv8cme0jnM;
                this.__p_EjEFJm5vPMKNnh9iXlSTb5 = __p_EjEFJm5vPMKNnh9iXlSTb5;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 205101U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "JKwXPXF0joDPBMdRD0GlYS", Name = "OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS")]
    [n2.SerializableAttribute]
    public class OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> Update<T3, AdM>(T2 Value_In, T3 Second_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
            where T3 : n2.IObservable<T> where AdM : struct, n4.IAdaptiveCreateDefault<n2.IObservable<T>>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_JmErZ1pqoeHO7mVX7dywmN.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n2.IObservable<T> Input_4 = (n2.IObservable<T>)Value_In;
            n2.IObservable<T> Second_5 = (n2.IObservable<T>)Second_In;
            var __fallback___6 = n1.ServiceRegistry.Current;
            var Output_10 = this.__p_Snb6XpWQ8srNk6NIa0nXkj.Update<n2.IObservable<T>, AdM>(Send_In: Result_1, Factory_In: () =>
            {
                using var __current_7 = __fallback___6.MakeCurrentIfNone();
                n8._Operations_.OnErrorResumeNext<T>(Input_In: Input_4, Second_In: Second_5, Output_Out: out n2.IObservable<T> Output_8);
                return Output_8;
            }

            , Result_Out: out n2.IObservable<T> Result_9);
            Result_Out = Result_9;
            Changed_Out = Result_1;
            n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = Output_3 != this.__p_JmErZ1pqoeHO7mVX7dywmN || Output_10 != this.__p_Snb6XpWQ8srNk6NIa0nXkj ? new OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T>(this)
                {__p_JmErZ1pqoeHO7mVX7dywmN = Output_3, __p_Snb6XpWQ8srNk6NIa0nXkj = Output_10} : that_11;
            else
            {
                this.__p_JmErZ1pqoeHO7mVX7dywmN = Output_3;
                this.__p_Snb6XpWQ8srNk6NIa0nXkj = Output_10;
            }

            return that_11;
        }

        public n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "JmErZ1pqoeHO7mVX7dywmN", 205105U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Snb6XpWQ8srNk6NIa0nXkj", 205111U);
            var Output_5 = n11.ToObservable_Switch_Factory_C<T>.Create(Node_Context: Node_Context_4);
            n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> that_6 = this;
            this.__p_JmErZ1pqoeHO7mVX7dywmN = Output_3;
            this.__p_Snb6XpWQ8srNk6NIa0nXkj = Output_5;
            return that_6;
        }

        public n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> that_1 = this;
            this.__p_JmErZ1pqoeHO7mVX7dywmN = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_Snb6XpWQ8srNk6NIa0nXkj = n11.ToObservable_Switch_Factory_C<T>.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JmErZ1pqoeHO7mVX7dywmN);
            n1.CompilationHelper.SafeDispose(this.__p_Snb6XpWQ8srNk6NIa0nXkj);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 205105U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "JmErZ1pqoeHO7mVX7dywmN", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_JmErZ1pqoeHO7mVX7dywmN;
        [n1.ElementAttribute(TracingId = 205111U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Snb6XpWQ8srNk6NIa0nXkj", Name = "ToObservable (Switch Factory)", IsManaged = true, IsAutoGenerated = true)]
        public n11.ToObservable_Switch_Factory_C<T> __p_Snb6XpWQ8srNk6NIa0nXkj;
        public OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS(OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> other): base(other)
        {
            this.__p_JmErZ1pqoeHO7mVX7dywmN = other.__p_JmErZ1pqoeHO7mVX7dywmN;
            this.__p_Snb6XpWQ8srNk6NIa0nXkj = other.__p_Snb6XpWQ8srNk6NIa0nXkj;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JmErZ1pqoeHO7mVX7dywmN", in __p_JmErZ1pqoeHO7mVX7dywmN), n1.CompilationHelper.GetValueOrExisting(values, "__p_Snb6XpWQ8srNk6NIa0nXkj", in __p_Snb6XpWQ8srNk6NIa0nXkj));
        }

        internal OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> __WITH__(n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_JmErZ1pqoeHO7mVX7dywmN, n11.ToObservable_Switch_Factory_C<T> __p_Snb6XpWQ8srNk6NIa0nXkj)
        {
            n11.OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JmErZ1pqoeHO7mVX7dywmN != this.__p_JmErZ1pqoeHO7mVX7dywmN || __p_Snb6XpWQ8srNk6NIa0nXkj != this.__p_Snb6XpWQ8srNk6NIa0nXkj ? new OnErrorResumeNext_JKwXPXF0joDPBMdRD0GlYS<T2, T>(this)
                {__p_JmErZ1pqoeHO7mVX7dywmN = __p_JmErZ1pqoeHO7mVX7dywmN, __p_Snb6XpWQ8srNk6NIa0nXkj = __p_Snb6XpWQ8srNk6NIa0nXkj} : that_0;
            else
            {
                this.__p_JmErZ1pqoeHO7mVX7dywmN = __p_JmErZ1pqoeHO7mVX7dywmN;
                this.__p_Snb6XpWQ8srNk6NIa0nXkj = __p_Snb6XpWQ8srNk6NIa0nXkj;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 205143U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "BZyUX5h0XgiNMgTAWoC4AX", Name = "BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX")]
    [n2.SerializableAttribute]
    public class BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> CreateDefault<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var instance = new BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> Update(T2 Value_In, [n5.SerializedDefaultValueAttribute("1", false)] double Delay_In_Seconds_In, out n2.IObservable<T> Result_Out, out bool Changed_Out)
        {
            n2.IObservable<T> __auto_0 = this.Result;
            var Output_3 = this.__p_Hq8uHRhrkSEOaImf4QMDrF.Update(Value_In: Value_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_6 = this.__p_NbbrTH4FSBEQKJP52y7N9o.Update(Value_In: Delay_In_Seconds_In, Result_Out: out bool Result_4, Unchanged_Out: out bool Unchanged_5);
            var Output_7 = Result_1 || Result_4;
            n2.IObservable<T> Input_8 = (n2.IObservable<T>)Value_In;
            n2.IObservable<T> __auto_9;
            if (Output_7)
            {
                n8._Operations_.BackoffAndRetry<T>(Input_In: Input_8, Delay_In_Seconds_In: Delay_In_Seconds_In, Output_Out: out n2.IObservable<T> Output_11);
                __auto_9 = Output_11;
            }
            else
            {
                __auto_9 = __auto_0;
            }

            n2.IObservable<T> __auto_12 = __auto_9;
            Result_Out = __auto_12;
            Changed_Out = Result_1;
            n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Output_3 != this.__p_Hq8uHRhrkSEOaImf4QMDrF || Output_6 != this.__p_NbbrTH4FSBEQKJP52y7N9o || __auto_9 != this.Result ? new BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T>(this)
                {__p_Hq8uHRhrkSEOaImf4QMDrF = Output_3, __p_NbbrTH4FSBEQKJP52y7N9o = Output_6, Result = __auto_9} : that_13;
            else
            {
                this.__p_Hq8uHRhrkSEOaImf4QMDrF = Output_3;
                this.__p_NbbrTH4FSBEQKJP52y7N9o = Output_6;
                this.Result = __auto_9;
            }

            return that_13;
        }

        public n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "Hq8uHRhrkSEOaImf4QMDrF", 205147U);
            bool Changed_On_Create_2 = true;
            var Output_3 = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.Create<AdM>(Node_Context: Node_Context_1, Changed_On_Create_In: Changed_On_Create_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "NbbrTH4FSBEQKJP52y7N9o", 205153U);
            bool Changed_On_Create_5 = true;
            var Output_6 = n10.Changed_A8JGbead2bxNdnPybiEqVS<double>.Create<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>(Node_Context: Node_Context_4, Changed_On_Create_In: Changed_On_Create_5);
            n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> that_7 = this;
            this.Result = n8._Operations_.CreateDefault<T>();
            this.__p_Hq8uHRhrkSEOaImf4QMDrF = Output_3;
            this.__p_NbbrTH4FSBEQKJP52y7N9o = Output_6;
            return that_7;
        }

        public n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> __CreateDefault__<AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> that_1 = this;
            this.Result = n8._Operations_.CreateDefault<T>();
            this.__p_Hq8uHRhrkSEOaImf4QMDrF = n10.Changed_A8JGbead2bxNdnPybiEqVS<T2>.CreateDefault<AdM>();
            this.__p_NbbrTH4FSBEQKJP52y7N9o = n10.Changed_A8JGbead2bxNdnPybiEqVS<double>.CreateDefault<n15.__AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag>();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Hq8uHRhrkSEOaImf4QMDrF);
            n1.CompilationHelper.SafeDispose(this.__p_NbbrTH4FSBEQKJP52y7N9o);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 205174U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "M9lGqkJBuhFLD9Bms3KYeq", Name = "Result")]
        public n2.IObservable<T> Result;
        [n1.ElementAttribute(TracingId = 205147U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Hq8uHRhrkSEOaImf4QMDrF", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_Hq8uHRhrkSEOaImf4QMDrF;
        [n1.ElementAttribute(TracingId = 205153U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "NbbrTH4FSBEQKJP52y7N9o", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n10.Changed_A8JGbead2bxNdnPybiEqVS<double> __p_NbbrTH4FSBEQKJP52y7N9o;
        public BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX(BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> other): base(other)
        {
            this.Result = other.Result;
            this.__p_Hq8uHRhrkSEOaImf4QMDrF = other.__p_Hq8uHRhrkSEOaImf4QMDrF;
            this.__p_NbbrTH4FSBEQKJP52y7N9o = other.__p_NbbrTH4FSBEQKJP52y7N9o;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Result", in Result), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hq8uHRhrkSEOaImf4QMDrF", in __p_Hq8uHRhrkSEOaImf4QMDrF), n1.CompilationHelper.GetValueOrExisting(values, "__p_NbbrTH4FSBEQKJP52y7N9o", in __p_NbbrTH4FSBEQKJP52y7N9o));
        }

        internal BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> __WITH__(n2.IObservable<T> Result, n10.Changed_A8JGbead2bxNdnPybiEqVS<T2> __p_Hq8uHRhrkSEOaImf4QMDrF, n10.Changed_A8JGbead2bxNdnPybiEqVS<double> __p_NbbrTH4FSBEQKJP52y7N9o)
        {
            n11.BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Result != this.Result || __p_Hq8uHRhrkSEOaImf4QMDrF != this.__p_Hq8uHRhrkSEOaImf4QMDrF || __p_NbbrTH4FSBEQKJP52y7N9o != this.__p_NbbrTH4FSBEQKJP52y7N9o ? new BackoffAndRetry_BZyUX5h0XgiNMgTAWoC4AX<T2, T>(this)
                {Result = Result, __p_Hq8uHRhrkSEOaImf4QMDrF = __p_Hq8uHRhrkSEOaImf4QMDrF, __p_NbbrTH4FSBEQKJP52y7N9o = __p_NbbrTH4FSBEQKJP52y7N9o} : that_0;
            else
            {
                this.Result = Result;
                this.__p_Hq8uHRhrkSEOaImf4QMDrF = __p_Hq8uHRhrkSEOaImf4QMDrF;
                this.__p_NbbrTH4FSBEQKJP52y7N9o = __p_NbbrTH4FSBEQKJP52y7N9o;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 205234U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "HQMsg5b9zDWN4pgYzUuHLi", Name = "Subscribe_HQMsg5b9zDWN4pgYzUuHLi")]
    [n2.SerializableAttribute]
    public class Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> : n1.VLObject, n2.IDisposable where T2 : n2.IObservable<T>
    {
        [n5.CreateNewAttribute]
        public static n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> CreateDefault()
        {
            var instance = new Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> Update(T2 Input_In)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_DMYxjQFJcKjNdCdvEZniAL;
            if (manager_2 is null)
            {
                manager_2 = new n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__On4tIy3QzBPO5ogGeojQfr>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __On4tIy3QzBPO5ogGeojQfr(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("AeLw27X3UZTPbUKzkJqoag", "DWRyqIEDMaeL20ebzlJXYH", 205245U);
                    n37._Operations_.Create(Node_Context: Node_Context_7, Output_Out: out n34.SerialDisposable Output_8);
                    state_6.__p_DWRyqIEDMaeL20ebzlJXYH = Output_8;
                }

                n2.IObservable<T> Input_9 = (n2.IObservable<T>)Input_In;
                n8._Operations_.Retry<T>(Input_In: Input_9, Output_Out: out n2.IObservable<T> Output_10);
                n8._Operations_.Subscribe<T>(Input_In: Output_10, Result_Out: out n2.IDisposable Result_11);
                bool SetDisposable_12 = true;
                var Output_13 = state_6.__p_DWRyqIEDMaeL20ebzlJXYH;
                if (SetDisposable_12)
                {
                    n34.SerialDisposable Input_14 = state_6.__p_DWRyqIEDMaeL20ebzlJXYH;
                    Input_14.Disposable = Result_11;
                    Output_13 = Input_14;
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_13 != state_6.__p_DWRyqIEDMaeL20ebzlJXYH ? new __On4tIy3QzBPO5ogGeojQfr(state_6)
                    {__p_DWRyqIEDMaeL20ebzlJXYH = Output_13} : state_6;
                else
                {
                    state_6.__p_DWRyqIEDMaeL20ebzlJXYH = Output_13;
                }

                outputs_4 = n2.ValueTuple.Create();
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = manager_2 != this.__cache_DMYxjQFJcKjNdCdvEZniAL ? new Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T>(this)
                {__cache_DMYxjQFJcKjNdCdvEZniAL = manager_2} : that_15;
            else
            {
                this.__cache_DMYxjQFJcKjNdCdvEZniAL = manager_2;
            }

            return that_15;
        }

        public n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> that_0 = this;
            this.__cache_DMYxjQFJcKjNdCdvEZniAL = null;
            return that_0;
        }

        public n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> __CreateDefault__()
        {
            n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> that_0 = this;
            this.__cache_DMYxjQFJcKjNdCdvEZniAL = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DMYxjQFJcKjNdCdvEZniAL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 205238U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DMYxjQFJcKjNdCdvEZniAL", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple> __cache_DMYxjQFJcKjNdCdvEZniAL = null;
        public Subscribe_HQMsg5b9zDWN4pgYzUuHLi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Subscribe_HQMsg5b9zDWN4pgYzUuHLi(Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> other): base(other)
        {
            this.__cache_DMYxjQFJcKjNdCdvEZniAL = other.__cache_DMYxjQFJcKjNdCdvEZniAL;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DMYxjQFJcKjNdCdvEZniAL", in __cache_DMYxjQFJcKjNdCdvEZniAL));
        }

        internal Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> __WITH__(n16.Manager<n2.ValueTuple<T2>, n2.ValueTuple> __cache_DMYxjQFJcKjNdCdvEZniAL)
        {
            n11.Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DMYxjQFJcKjNdCdvEZniAL != this.__cache_DMYxjQFJcKjNdCdvEZniAL ? new Subscribe_HQMsg5b9zDWN4pgYzUuHLi<T2, T>(this)
                {__cache_DMYxjQFJcKjNdCdvEZniAL = __cache_DMYxjQFJcKjNdCdvEZniAL} : that_0;
            else
            {
                this.__cache_DMYxjQFJcKjNdCdvEZniAL = __cache_DMYxjQFJcKjNdCdvEZniAL;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "On4tIy3QzBPO5ogGeojQfr", Name = "__On4tIy3QzBPO5ogGeojQfr")]
        [n2.SerializableAttribute]
        public class __On4tIy3QzBPO5ogGeojQfr : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DWRyqIEDMaeL20ebzlJXYH);
                return;
            }

            [n1.ElementAttribute(TracingId = 205245U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "DWRyqIEDMaeL20ebzlJXYH", Name = "SerialDisposable", IsManaged = true, IsAutoGenerated = true)]
            public n34.SerialDisposable __p_DWRyqIEDMaeL20ebzlJXYH;
            public __On4tIy3QzBPO5ogGeojQfr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __On4tIy3QzBPO5ogGeojQfr(__On4tIy3QzBPO5ogGeojQfr other): base(other)
            {
                this.__p_DWRyqIEDMaeL20ebzlJXYH = other.__p_DWRyqIEDMaeL20ebzlJXYH;
            }

            protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DWRyqIEDMaeL20ebzlJXYH", in __p_DWRyqIEDMaeL20ebzlJXYH));
            }

            internal __On4tIy3QzBPO5ogGeojQfr __WITH__(n34.SerialDisposable __p_DWRyqIEDMaeL20ebzlJXYH)
            {
                __On4tIy3QzBPO5ogGeojQfr that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DWRyqIEDMaeL20ebzlJXYH != this.__p_DWRyqIEDMaeL20ebzlJXYH ? new __On4tIy3QzBPO5ogGeojQfr(this)
                    {__p_DWRyqIEDMaeL20ebzlJXYH = __p_DWRyqIEDMaeL20ebzlJXYH} : that_0;
                else
                {
                    this.__p_DWRyqIEDMaeL20ebzlJXYH = __p_DWRyqIEDMaeL20ebzlJXYH;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Reactive_.Reactive.CancellationToken.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateDefaultAttribute]
        public static n30.CancellationToken CreateDefault()
        {
            var None_0 = n30.CancellationToken.None;
            return None_0;
        }
    }
}

namespace _VL_Reactive_.Reactive.Observable.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateDefaultAttribute]
        public static n2.IObservable<T> CreateDefault<T>()
        {
            var Result_0 = n18.ObservableNodes.Never<T>();
            return Result_0;
        }

        public static void Aggregate<T2, T>(n2.IObservable<T2> Input_In, T Seed_In, n2.Func<T, T2, T> Accumulator_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Aggregate<T2, T>(source: Input_In, seed: Seed_In, accumulator: Accumulator_In);
            Output_Out = Output_0;
            return;
        }

        public static void Aggregate_Selector<T2, T, T3>(n2.IObservable<T2> Input_In, T Seed_In, n2.Func<T, T2, T> Accumulator_In, n2.Func<T, T3> Result_Selector_In, out n2.IObservable<T3> Output_Out)
        {
            var Output_0 = n14.Observable.Aggregate<T2, T, T3>(source: Input_In, seed: Seed_In, accumulator: Accumulator_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void All<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.All<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Amb<T>(n12.IEnumerable<n2.IObservable<T>> Input_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Amb<T>(sources: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Amb_IObservableLTSourceG_IObservableLTSourceG<T>(n2.IObservable<T> Input_In, n2.IObservable<T> Second_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Amb<T>(first: Input_In, second: Second_In);
            Output_Out = Output_0;
            return;
        }

        public static void And<T, T2>(n2.IObservable<T> Input_In, n2.IObservable<T2> Right_In, out n26.Pattern<T, T2> Result_Out)
        {
            var Result_0 = n14.Observable.And<T, T2>(left: Input_In, right: Right_In);
            Result_Out = Result_0;
            return;
        }

        public static void Any<T>(n2.IObservable<T> Input_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.Any<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Any_Predicate<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.Any<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void BackoffAndRetry<T>(n2.IObservable<T> Input_In, [n5.SerializedDefaultValueAttribute("1", false)] double Delay_In_Seconds_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n18.ObservableNodes.BackoffAndRetry<T>(source: Input_In, delayInSeconds: Delay_In_Seconds_In);
            Output_Out = Output_0;
            return;
        }

        public static void BackoffAndRetry_Count<T>(n2.IObservable<T> Input_In, [n5.SerializedDefaultValueAttribute("3", false)] int Retry_Count_In, [n5.SerializedDefaultValueAttribute("1", false)] double Delay_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n18.ObservableNodes.BackoffAndRetry<T>(source: Input_In, retryCount: Retry_Count_In, delay: Delay_In);
            Output_Out = Output_0;
            return;
        }

        public static void Buffer<T>(n2.IObservable<T> Input_In, int Count_In, out n2.IObservable<n12.IList<T>> Output_Out)
        {
            var Output_0 = n14.Observable.Buffer<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Buffer_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Time_Span_In, out n2.IObservable<n12.IList<T>> Output_Out)
        {
            var Output_0 = n14.Observable.Buffer<T>(source: Input_In, timeSpan: Time_Span_In);
            Output_Out = Output_0;
            return;
        }

        public static void Buffer_Skip_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Time_Span_In, n2.TimeSpan Time_Shift_In, out n2.IObservable<n12.IList<T>> Output_Out)
        {
            var Output_0 = n14.Observable.Buffer<T>(source: Input_In, timeSpan: Time_Span_In, timeShift: Time_Shift_In);
            Output_Out = Output_0;
            return;
        }

        public static void Buffer_Skip<T>(n2.IObservable<T> Input_In, int Count_In, int Skip_In, out n2.IObservable<n12.IList<T>> Output_Out)
        {
            var Output_0 = n14.Observable.Buffer<T>(source: Input_In, count: Count_In, skip: Skip_In);
            Output_Out = Output_0;
            return;
        }

        public static void Chunkify<T>(n2.IObservable<T> Input_In, out n12.IEnumerable<n12.IList<T>> Result_Out)
        {
            var Result_0 = n14.Observable.Chunkify<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void CombineLatest<T, T2, T3>(n2.IObservable<T> Input_In, n2.IObservable<T2> Second_In, n2.Func<T, T2, T3> Result_Selector_In, out n2.IObservable<T3> Output_Out)
        {
            var Output_0 = n14.Observable.CombineLatest<T, T2, T3>(first: Input_In, second: Second_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Concat<T, T2>(n2.IObservable<T> Input_In, T2 Input_2_In, out n2.IObservable<T> Output_Out)
            where T2 : n2.IObservable<T>
        {
            n2.IObservable<T> Second_0 = (n2.IObservable<T>)Input_2_In;
            var Output_1 = n14.Observable.Concat<T>(first: Input_In, second: Second_0);
            Output_Out = Output_1;
            return;
        }

        public static void Contains<T>(n2.IObservable<T> Input_In, T Value_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.Contains<T>(source: Input_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void Count<T>(n2.IObservable<T> Input_In, out n2.IObservable<int> Output_Out)
        {
            var Output_0 = n14.Observable.Count<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Count_Predicate<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<int> Output_Out)
        {
            var Output_0 = n14.Observable.Count<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n2.Func<n2.IObserver<T>, n2.IDisposable> Subscribe_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Create<T>(subscribe: Subscribe_In);
            Result_Out = Result_0;
            return;
        }

        public static void Create_Action<T>(n2.Func<n2.IObserver<T>, n2.Action> Subscribe_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Create<T>(subscribe: Subscribe_In);
            Result_Out = Result_0;
            return;
        }

        public static void Defer<T>(n2.Func<n2.IObservable<T>> Observable_Factory_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Defer<T>(observableFactory: Observable_Factory_In);
            Result_Out = Result_0;
            return;
        }

        public static void Delay<T>(n2.IObservable<T> Input_In, n2.TimeSpan Due_Time_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Delay<T>(source: Input_In, dueTime: Due_Time_In);
            Output_Out = Output_0;
            return;
        }

        public static void Delay_Selector<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, n2.IObservable<T2>> Delay_Duration_Selector_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Delay<T, T2>(source: Input_In, delayDurationSelector: Delay_Duration_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void DelaySubscription<T>(n2.IObservable<T> Input_In, n2.TimeSpan Due_Time_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.DelaySubscription<T>(source: Input_In, dueTime: Due_Time_In);
            Output_Out = Output_0;
            return;
        }

        public static void Distinct<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Distinct<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Distinct_Selector<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Distinct<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void DistinctUntilChanged<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.DistinctUntilChanged<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void DistinctUntilChanged_Selector<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.DistinctUntilChanged<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Empty<T>(out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n18.ObservableNodes.Empty<T>();
            Result_Out = Result_0;
            return;
        }

        public static void Finally<T>(n2.IObservable<T> Input_In, n2.Action Finally_Action_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Finally<T>(source: Input_In, finallyAction: Finally_Action_In);
            Output_Out = Output_0;
            return;
        }

        public static void First<T>(n2.IObservable<T> Input_In, out T Result_Out)
        {
            var Result_0 = n14.Observable.First<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void First_Selector<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out T Result_Out)
        {
            var Result_0 = n14.Observable.First<T>(source: Input_In, predicate: Predicate_In);
            Result_Out = Result_0;
            return;
        }

        public static void ForEach2<T>(n2.IObservable<T> Input_In, n2.Action<T, int> On_Next_In)
        {
            n14.Observable.ForEach<T>(source: Input_In, onNext: On_Next_In);
            return;
        }

        public static void FromSequence<T>(n12.IEnumerable<T> Input_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.ToObservable<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void GroupBy<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n2.IObservable<n14.IGroupedObservable<T2, T>> Output_Out)
        {
            var Output_0 = n14.Observable.GroupBy<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void If2<T>(n2.Func<bool> Condition_In, n2.IObservable<T> Then_Source_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.If<T>(condition: Condition_In, thenSource: Then_Source_In);
            Result_Out = Result_0;
            return;
        }

        public static void IfElse<T>(n2.Func<bool> Condition_In, n2.IObservable<T> Then_Source_In, n2.IObservable<T> Else_Source_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.If<T>(condition: Condition_In, thenSource: Then_Source_In, elseSource: Else_Source_In);
            Result_Out = Result_0;
            return;
        }

        public static void IgnoreElements<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.IgnoreElements<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Interval(n2.TimeSpan Period_In, out n2.IObservable<long> Result_Out)
        {
            var Result_0 = n14.Observable.Interval(period: Period_In);
            Result_Out = Result_0;
            return;
        }

        public static void IsEmpty<T>(n2.IObservable<T> Input_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.IsEmpty<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Merge<T, T2>(n2.IObservable<T> Input_In, T2 Input_2_In, out n2.IObservable<T> Output_Out)
            where T2 : n2.IObservable<T>
        {
            n2.IObservable<T> Second_0 = (n2.IObservable<T>)Input_2_In;
            var Output_1 = n14.Observable.Merge<T>(first: Input_In, second: Second_0);
            Output_Out = Output_1;
            return;
        }

        public static void Merge_Many<T>(n2.IObservable<n2.IObservable<T>> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Merge<T>(sources: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Merge_Spectral<T>(n12.IEnumerable<n2.IObservable<T>> Input_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Merge<T>(sources: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void MostRecent<T>(n2.IObservable<T> Input_In, T Initial_Value_In, out n12.IEnumerable<T> Result_Out)
        {
            var Result_0 = n14.Observable.MostRecent<T>(source: Input_In, initialValue: Initial_Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void Never<T>(out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n18.ObservableNodes.Never<T>();
            Result_Out = Result_0;
            return;
        }

        public static void ObserveOn<T>(n2.IObservable<T> Input_In, n21.IScheduler Scheduler_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.ObserveOn<T>(source: Input_In, scheduler: Scheduler_In);
            Output_Out = Output_0;
            return;
        }

        public static void OfType<T>(n2.IObservable<n2.Object> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.OfType<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void OnErrorResumeNext<T>(n2.IObservable<T> Input_In, n2.IObservable<T> Second_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.OnErrorResumeNext<T>(first: Input_In, second: Second_In);
            Output_Out = Output_0;
            return;
        }

        public static void OnErrorTerminate<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n18.ObservableNodes.OnErrorTerminate<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Select<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, int, T2> Selector_In, out n2.IObservable<T2> Output_Out)
        {
            var Output_0 = n14.Observable.Select<T, T2>(source: Input_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Select_Many<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, int, n2.IObservable<T2>> Selector_In, out n2.IObservable<T2> Output_Out)
        {
            var Output_0 = n14.Observable.SelectMany<T, T2>(source: Input_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Publish<T>(n2.IObservable<T> Input_In, out n27.IConnectableObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Publish<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void PublishLast<T>(n2.IObservable<T> Input_In, out n27.IConnectableObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.PublishLast<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void PubRefCount<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n18.ObservableNodes.PubRefCount<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Range(int Start_In, int Count_In, out n2.IObservable<int> Result_Out)
        {
            var Result_0 = n14.Observable.Range(start: Start_In, count: Count_In);
            Result_Out = Result_0;
            return;
        }

        public static void RefCount<T>(n27.IConnectableObservable<T> Input_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.RefCount<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Repeat<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Repeat<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Repeat_Count<T>(n2.IObservable<T> Input_In, int Repeat_Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Repeat<T>(source: Input_In, repeatCount: Repeat_Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Repeat_Value_Count<T>(T Value_In, int Repeat_Count_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Repeat<T>(value: Value_In, repeatCount: Repeat_Count_In);
            Result_Out = Result_0;
            return;
        }

        public static void Repeat_Value<T>(T Value_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Repeat<T>(value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void Replay<T>(n2.IObservable<T> Input_In, out n27.IConnectableObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Replay<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Retry<T>(n2.IObservable<T> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Retry<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Retry_Count<T>(n2.IObservable<T> Input_In, int Retry_Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Retry<T>(source: Input_In, retryCount: Retry_Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Return<T>(T Value_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Return<T>(value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void Sample<T>(n2.IObservable<T> Input_In, n2.TimeSpan Interval_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Sample<T>(source: Input_In, interval: Interval_In);
            Output_Out = Output_0;
            return;
        }

        public static void Sample_Sampler<T, T2>(n2.IObservable<T> Input_In, n2.IObservable<T2> Sampler_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Sample<T, T2>(source: Input_In, sampler: Sampler_In);
            Output_Out = Output_0;
            return;
        }

        public static void Scan<T2, T>(n2.IObservable<T2> Input_In, T Seed_In, n2.Func<T, T2, T> Accumulator_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Scan<T2, T>(source: Input_In, seed: Seed_In, accumulator: Accumulator_In);
            Output_Out = Output_0;
            return;
        }

        public static void SequenceEqual<T>(n2.IObservable<T> Input_In, n2.IObservable<T> Second_In, out n2.IObservable<bool> Output_Out)
        {
            var Output_0 = n14.Observable.SequenceEqual<T>(first: Input_In, second: Second_In);
            Output_Out = Output_0;
            return;
        }

        public static void Skip<T>(n2.IObservable<T> Input_In, int Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Skip<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Skip_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Duration_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Skip<T>(source: Input_In, duration: Duration_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipLast<T>(n2.IObservable<T> Input_In, int Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.SkipLast<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipLast_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Duration_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.SkipLast<T>(source: Input_In, duration: Duration_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipUntil<T, T2>(n2.IObservable<T> Input_In, n2.IObservable<T2> Other_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.SkipUntil<T, T2>(source: Input_In, other: Other_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipWhile<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.SkipWhile<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Start<T>(n2.Func<T> Function_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n14.Observable.Start<T>(function: Function_In);
            Result_Out = Result_0;
            return;
        }

        public static void StartWith<T>(n2.IObservable<T> Input_In, n12.IEnumerable<T> Values_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.StartWith<T>(source: Input_In, values: Values_In);
            Output_Out = Output_0;
            return;
        }

        public static void SubscribeOn<T>(n2.IObservable<T> Input_In, n21.IScheduler Scheduler_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.SubscribeOn<T>(source: Input_In, scheduler: Scheduler_In);
            Output_Out = Output_0;
            return;
        }

        public static void Switch<T>(n2.IObservable<n2.IObservable<T>> Input_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Switch<T>(sources: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Take<T>(n2.IObservable<T> Input_In, int Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Take<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Take_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Duration_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Take<T>(source: Input_In, duration: Duration_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeLast<T>(n2.IObservable<T> Input_In, int Count_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.TakeLast<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeLast_Duration<T>(n2.IObservable<T> Input_In, n2.TimeSpan Duration_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.TakeLast<T>(source: Input_In, duration: Duration_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeUntil<T, T2>(n2.IObservable<T> Input_In, n2.IObservable<T2> Other_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.TakeUntil<T, T2>(source: Input_In, other: Other_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeWhile<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.TakeWhile<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Then<T, T2>(n2.IObservable<T> Input_In, n2.Func<T, T2> Selector_In, out n26.Plan<T2> Result_Out)
        {
            var Result_0 = n14.Observable.Then<T, T2>(source: Input_In, selector: Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void TimeInterval<T>(n2.IObservable<T> Input_In, out n2.IObservable<n23.TimeInterval<T>> Output_Out)
        {
            var Output_0 = n14.Observable.TimeInterval<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Timer(n2.TimeSpan Due_Time_In, n2.TimeSpan Period_In, out n2.IObservable<long> Result_Out)
        {
            var Result_0 = n14.Observable.Timer(dueTime: Due_Time_In, period: Period_In);
            Result_Out = Result_0;
            return;
        }

        public static void Timestamp<T>(n2.IObservable<T> Input_In, out n2.IObservable<n23.Timestamped<T>> Output_Out)
        {
            var Output_0 = n14.Observable.Timestamp<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Using<T2, T>(n2.Func<T2> Resource_Factory_In, n2.Func<T2, n2.IObservable<T>> Observable_Factory_In, out n2.IObservable<T> Result_Out)
            where T2 : n2.IDisposable
        {
            var Result_0 = n14.Observable.Using<T, T2>(resourceFactory: Resource_Factory_In, observableFactory: Observable_Factory_In);
            Result_Out = Result_0;
            return;
        }

        public static void Where<T>(n2.IObservable<T> Input_In, n2.Func<T, bool> Predicate_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Where<T>(source: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip__2_MG_1<T, T2, T3>(n2.IObservable<T> Input_In, n2.IObservable<T2> Second_In, n2.Func<T, T2, T3> Result_Selector_In, out n2.IObservable<T3> Output_Out)
        {
            var Output_0 = n14.Observable.Zip<T, T2, T3>(first: Input_In, second: Second_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip__3_MG_1<T, T2, T3, T4>(n2.IObservable<T> Input_In, n2.IObservable<T2> Source_2_In, n2.IObservable<T3> Source_3_In, n2.Func<T, T2, T3, T4> Result_Selector_In, out n2.IObservable<T4> Output_Out)
        {
            var Output_0 = n14.Observable.Zip<T, T2, T3, T4>(source1: Input_In, source2: Source_2_In, source3: Source_3_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip__4_MG_1<T, T2, T3, T4, T5, T6>(n2.IObservable<T> Input_In, n2.IObservable<T2> Source_2_In, n2.IObservable<T3> Source_3_In, n2.IObservable<T4> Source_4_In, n2.IObservable<T5> Source_5_In, n2.Func<T, T2, T3, T4, T5, T6> Result_Selector_In, out n2.IObservable<T6> Output_Out)
        {
            var Output_0 = n14.Observable.Zip<T, T2, T3, T4, T5, T6>(source1: Input_In, source2: Source_2_In, source3: Source_3_In, source4: Source_4_In, source5: Source_5_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip_Many_Selector<T, T2>(n12.IEnumerable<n2.IObservable<T>> Input_In, n2.Func<n12.IList<T>, T2> Result_Selector_In, out n2.IObservable<T2> Result_Out)
        {
            var Result_0 = n14.Observable.Zip<T, T2>(sources: Input_In, resultSelector: Result_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void Zip_Many<T>(n12.IEnumerable<n2.IObservable<T>> Input_In, out n2.IObservable<n12.IList<T>> Result_Out)
        {
            var Result_0 = n14.Observable.Zip<T>(sources: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Do<T>(n2.IObservable<T> Input_In, n2.Action<T> On_Next_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Do<T>(source: Input_In, onNext: On_Next_In);
            Output_Out = Output_0;
            return;
        }

        public static void ElementAt<T>(n2.IObservable<T> Input_In, int Index_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.ElementAt<T>(source: Input_In, index: Index_In);
            Output_Out = Output_0;
            return;
        }

        public static void Throttle<T>(n2.IObservable<T> Input_In, n2.TimeSpan Due_Time_In, out n2.IObservable<T> Output_Out)
        {
            var Output_0 = n14.Observable.Throttle<T>(source: Input_In, dueTime: Due_Time_In);
            Output_Out = Output_0;
            return;
        }

        public static void Subscribe<T>(n2.IObservable<T> Input_In, out n2.IDisposable Result_Out)
        {
            var Result_0 = n2.ObservableExtensions.Subscribe<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Loop<TState, T>(n2.Func<TState> Create_In, n2.Func<TState, n2.IObserver<T>, n30.CancellationToken, TState> Update_In, int Milliseconds_Delay_In, out n2.IObservable<T> Result_Out)
            where TState : class
        {
            var Result_0 = n18.ObservableNodes.Loop<TState, T>(create: Create_In, update: Update_In, millisecondsDelay: Milliseconds_Delay_In);
            Result_Out = Result_0;
            return;
        }

        public static void Subscribe_Provider<T>(n2.IObservable<T> Source_In, out n38.IResourceProvider<n2.IDisposable> Result_Out)
        {
            var Result_0 = n18.ObservableNodes.Subscribe<T>(source: Source_In);
            Result_Out = Result_0;
            return;
        }

        public static void PollData<T2, TState, T>(n38.IResourceProvider<T2> Device_Provider_In, n2.Func<T2, TState> Create_In, n2.Func<TState, T2, n30.CancellationToken, n2.Tuple<TState, T>> Update_In, int Milliseconds_Delay_In, out n2.IObservable<T> Result_Out)
            where T2 : class, n2.IDisposable where TState : class
        {
            var Result_0 = n18.ObservableNodes.PollData<TState, T2, T>(deviceProvider: Device_Provider_In, create: Create_In, update: Update_In, millisecondsDelay: Milliseconds_Delay_In);
            Result_Out = Result_0;
            return;
        }

        public static void PollResource<T, TState, T2>(n38.IResourceProvider<T> Device_Provider_In, n2.Func<T, TState> Create_In, n2.Func<TState, T, n30.CancellationToken, n2.Tuple<TState, T2>> Update_In, int Milliseconds_Delay_In, out n2.IObservable<T2> Result_Out)
            where T : class, n2.IDisposable where TState : class where T2 : n2.IDisposable
        {
            var Result_0 = n18.ObservableNodes.PollResource<TState, T, T2>(deviceProvider: Device_Provider_In, create: Create_In, update: Update_In, millisecondsDelay: Milliseconds_Delay_In);
            Result_Out = Result_0;
            return;
        }

        public static void Using_Provider<T2, T>(n38.IResourceProvider<T2> Provider_In, n2.Func<T2, n2.IObservable<T>> Observable_Factory_In, out n2.IObservable<T> Result_Out)
            where T2 : class, n2.IDisposable
        {
            var Result_0 = n18.ObservableNodes.Using<T2, T>(provider: Provider_In, observableFactory: Observable_Factory_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Observer.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void OnCompleted<T>(n2.IObserver<T> Input_In, out n2.IObserver<T> Output_Out)
        {
            ((n2.IObserver<T>)Input_In).OnCompleted();
            Output_Out = Input_In;
            return;
        }

        public static void OnError<T>(n2.IObserver<T> Input_In, n2.Exception Error_In, out n2.IObserver<T> Output_Out)
        {
            ((n2.IObserver<T>)Input_In).OnError(error: Error_In);
            Output_Out = Input_In;
            return;
        }

        public static void OnNext<T>(n2.IObserver<T> Input_In, T Value_In, out n2.IObserver<T> Output_Out)
        {
            ((n2.IObserver<T>)Input_In).OnNext(value: Value_In);
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__1.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Then<T, T2>(n26.Pattern<T> Input_In, n2.Func<T, T2> Selector_In, out n26.Pattern<T> Output_Out, out n26.Plan<T2> Result_Out)
        {
            var Result_0 = Input_In.Then<T2>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__2.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3>(n26.Pattern<T, T2> Input_In, n2.IObservable<T3> Other_In, out n26.Pattern<T, T2> Output_Out, out n26.Pattern<T, T2, T3> Result_Out)
        {
            var Result_0 = Input_In.And<T3>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3>(n26.Pattern<T, T2> Input_In, n2.Func<T, T2, T3> Selector_In, out n26.Pattern<T, T2> Output_Out, out n26.Plan<T3> Result_Out)
        {
            var Result_0 = Input_In.Then<T3>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__3.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4>(n26.Pattern<T, T2, T3> Input_In, n2.IObservable<T4> Other_In, out n26.Pattern<T, T2, T3> Output_Out, out n26.Pattern<T, T2, T3, T4> Result_Out)
        {
            var Result_0 = Input_In.And<T4>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4>(n26.Pattern<T, T2, T3> Input_In, n2.Func<T, T2, T3, T4> Selector_In, out n26.Pattern<T, T2, T3> Output_Out, out n26.Plan<T4> Result_Out)
        {
            var Result_0 = Input_In.Then<T4>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__4.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4, T5>(n26.Pattern<T, T2, T3, T4> Input_In, n2.IObservable<T5> Other_In, out n26.Pattern<T, T2, T3, T4> Output_Out, out n26.Pattern<T, T2, T3, T4, T5> Result_Out)
        {
            var Result_0 = Input_In.And<T5>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4, T5>(n26.Pattern<T, T2, T3, T4> Input_In, n2.Func<T, T2, T3, T4, T5> Selector_In, out n26.Pattern<T, T2, T3, T4> Output_Out, out n26.Plan<T5> Result_Out)
        {
            var Result_0 = Input_In.Then<T5>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__5.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4, T5, T6>(n26.Pattern<T, T2, T3, T4, T5> Input_In, n2.IObservable<T6> Other_In, out n26.Pattern<T, T2, T3, T4, T5> Output_Out, out n26.Pattern<T, T2, T3, T4, T5, T6> Result_Out)
        {
            var Result_0 = Input_In.And<T6>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4, T5, T6>(n26.Pattern<T, T2, T3, T4, T5> Input_In, n2.Func<T, T2, T3, T4, T5, T6> Selector_In, out n26.Pattern<T, T2, T3, T4, T5> Output_Out, out n26.Plan<T6> Result_Out)
        {
            var Result_0 = Input_In.Then<T6>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__6.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4, T5, T6, T7>(n26.Pattern<T, T2, T3, T4, T5, T6> Input_In, n2.IObservable<T7> Other_In, out n26.Pattern<T, T2, T3, T4, T5, T6> Output_Out, out n26.Pattern<T, T2, T3, T4, T5, T6, T7> Result_Out)
        {
            var Result_0 = Input_In.And<T7>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4, T5, T6, T7>(n26.Pattern<T, T2, T3, T4, T5, T6> Input_In, n2.Func<T, T2, T3, T4, T5, T6, T7> Selector_In, out n26.Pattern<T, T2, T3, T4, T5, T6> Output_Out, out n26.Plan<T7> Result_Out)
        {
            var Result_0 = Input_In.Then<T7>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__7.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4, T5, T6, T7, T8>(n26.Pattern<T, T2, T3, T4, T5, T6, T7> Input_In, n2.IObservable<T8> Other_In, out n26.Pattern<T, T2, T3, T4, T5, T6, T7> Output_Out, out n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8> Result_Out)
        {
            var Result_0 = Input_In.And<T8>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4, T5, T6, T7, T8>(n26.Pattern<T, T2, T3, T4, T5, T6, T7> Input_In, n2.Func<T, T2, T3, T4, T5, T6, T7, T8> Selector_In, out n26.Pattern<T, T2, T3, T4, T5, T6, T7> Output_Out, out n26.Plan<T8> Result_Out)
        {
            var Result_0 = Input_In.Then<T8>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Joins.Pattern__8.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void And<T, T2, T3, T4, T5, T6, T7, T8, T9>(n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8> Input_In, n2.IObservable<T9> Other_In, out n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8> Output_Out, out n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8, T9> Result_Out)
        {
            var Result_0 = Input_In.And<T9>(other: Other_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Then<T, T2, T3, T4, T5, T6, T7, T8, T9>(n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8> Input_In, n2.Func<T, T2, T3, T4, T5, T6, T7, T8, T9> Selector_In, out n26.Pattern<T, T2, T3, T4, T5, T6, T7, T8> Output_Out, out n26.Plan<T9> Result_Out)
        {
            var Result_0 = Input_In.Then<T9>(selector: Selector_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Subjects.AsyncSubject.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n27.AsyncSubject<T> Output_Out)
        {
            var Output_0 = new n27.AsyncSubject<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Destroy<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void GetAwaiter<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out, out n27.AsyncSubject<T> Result_Out)
        {
            var Result_0 = Input_In.GetAwaiter();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetResult<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out, out T Result_Out)
        {
            var Result_0 = Input_In.GetResult();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void HasObservers<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out, out bool Has_Observers_Out)
        {
            var Has_Observers_0 = Input_In.HasObservers;
            Output_Out = Input_In;
            Has_Observers_Out = Has_Observers_0;
            return;
        }

        public static void IsCompleted<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out, out bool Is_Completed_Out)
        {
            var Is_Completed_0 = Input_In.IsCompleted;
            Output_Out = Input_In;
            Is_Completed_Out = Is_Completed_0;
            return;
        }

        public static void OnCompleted<T>(n27.AsyncSubject<T> Input_In, out n27.AsyncSubject<T> Output_Out)
        {
            Input_In.OnCompleted();
            Output_Out = Input_In;
            return;
        }

        public static void OnCompleted_Action<T>(n27.AsyncSubject<T> Input_In, n2.Action Continuation_In, out n27.AsyncSubject<T> Output_Out)
        {
            Input_In.OnCompleted(continuation: Continuation_In);
            Output_Out = Input_In;
            return;
        }

        public static void OnError<T>(n27.AsyncSubject<T> Input_In, n2.Exception Error_In, out n27.AsyncSubject<T> Output_Out)
        {
            Input_In.OnError(error: Error_In);
            Output_Out = Input_In;
            return;
        }

        public static void OnNext<T>(n27.AsyncSubject<T> Input_In, T Value_In, out n27.AsyncSubject<T> Output_Out)
        {
            Input_In.OnNext(value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Subscribe<T>(n27.AsyncSubject<T> Input_In, n2.IObserver<T> Observer_In, out n27.AsyncSubject<T> Output_Out, out n2.IDisposable Result_Out)
        {
            var Result_0 = Input_In.Subscribe(observer: Observer_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Subjects.BehaviorSubject.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Value_In, out n27.BehaviorSubject<T> Output_Out)
        {
            var Output_0 = new n27.BehaviorSubject<T>(value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void Destroy<T>(n27.BehaviorSubject<T> Input_In, out n27.BehaviorSubject<T> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void HasObservers<T>(n27.BehaviorSubject<T> Input_In, out n27.BehaviorSubject<T> Output_Out, out bool Has_Observers_Out)
        {
            var Has_Observers_0 = Input_In.HasObservers;
            Output_Out = Input_In;
            Has_Observers_Out = Has_Observers_0;
            return;
        }

        public static void OnCompleted<T>(n27.BehaviorSubject<T> Input_In, out n27.BehaviorSubject<T> Output_Out)
        {
            Input_In.OnCompleted();
            Output_Out = Input_In;
            return;
        }

        public static void OnError<T>(n27.BehaviorSubject<T> Input_In, n2.Exception Error_In, out n27.BehaviorSubject<T> Output_Out)
        {
            Input_In.OnError(error: Error_In);
            Output_Out = Input_In;
            return;
        }

        public static void OnNext<T>(n27.BehaviorSubject<T> Input_In, T Value_In, out n27.BehaviorSubject<T> Output_Out)
        {
            Input_In.OnNext(value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Subscribe<T>(n27.BehaviorSubject<T> Input_In, n2.IObserver<T> Observer_In, out n27.BehaviorSubject<T> Output_Out, out n2.IDisposable Result_Out)
        {
            var Result_0 = Input_In.Subscribe(observer: Observer_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Value<T>(n27.BehaviorSubject<T> Input_In, out n27.BehaviorSubject<T> Output_Out, out T Value_Out)
        {
            var Value_0 = Input_In.Value;
            Output_Out = Input_In;
            Value_Out = Value_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Subjects.Subject.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n27.Subject<T> Output_Out)
        {
            var Output_0 = new n27.Subject<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Destroy<T>(n27.Subject<T> Input_In, out n27.Subject<T> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void HasObservers<T>(n27.Subject<T> Input_In, out n27.Subject<T> Output_Out, out bool Has_Observers_Out)
        {
            var Has_Observers_0 = Input_In.HasObservers;
            Output_Out = Input_In;
            Has_Observers_Out = Has_Observers_0;
            return;
        }

        public static void OnCompleted<T>(n27.Subject<T> Input_In, out n27.Subject<T> Output_Out)
        {
            Input_In.OnCompleted();
            Output_Out = Input_In;
            return;
        }

        public static void OnError<T>(n27.Subject<T> Input_In, n2.Exception Error_In, out n27.Subject<T> Output_Out)
        {
            Input_In.OnError(error: Error_In);
            Output_Out = Input_In;
            return;
        }

        public static void OnNext<T>(n27.Subject<T> Input_In, T Value_In, out n27.Subject<T> Output_Out)
        {
            Input_In.OnNext(value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Subscribe<T>(n27.Subject<T> Input_In, n2.IObserver<T> Observer_In, out n27.Subject<T> Output_Out, out n2.IDisposable Result_Out)
        {
            var Result_0 = Input_In.Subscribe(observer: Observer_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.ConnectableObservable.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Connect<T>(n27.IConnectableObservable<T> Input_In, out n2.IDisposable Result_Out)
        {
            var Result_0 = ((n27.IConnectableObservable<T>)Input_In).Connect();
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Scheduler.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateDefaultAttribute]
        public static n21.IScheduler CreateDefault()
        {
            var New_Thread_0 = n21.Scheduler.NewThread;
            return New_Thread_0;
        }

        public static void CurrentSynchronizationContext(out n21.IScheduler Output_Out)
        {
            var Current_Synchronization_Context_0 = n18.SafeScheduler.CurrentSynchronizationContext;
            Output_Out = Current_Synchronization_Context_0;
            return;
        }

        public static void CurrentThread(out n21.CurrentThreadScheduler Output_Out)
        {
            var Current_Thread_0 = n21.Scheduler.CurrentThread;
            Output_Out = Current_Thread_0;
            return;
        }

        public static void Default(out n21.DefaultScheduler Output_Out)
        {
            var Default_0 = n21.Scheduler.Default;
            Output_Out = Default_0;
            return;
        }

        public static void Immediate(out n21.ImmediateScheduler Output_Out)
        {
            var Immediate_0 = n21.Scheduler.Immediate;
            Output_Out = Immediate_0;
            return;
        }

        public static void NewThread(out n21.IScheduler Output_Out)
        {
            var New_Thread_0 = n21.Scheduler.NewThread;
            Output_Out = New_Thread_0;
            return;
        }

        public static void TaskPool(out n21.IScheduler Output_Out)
        {
            var Task_Pool_0 = n21.Scheduler.TaskPool;
            Output_Out = Task_Pool_0;
            return;
        }

        public static void ThreadPool(out n21.IScheduler Output_Out)
        {
            var Thread_Pool_0 = n21.Scheduler.ThreadPool;
            Output_Out = Thread_Pool_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.TimeInterval.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NE<T>(n23.TimeInterval<T> Input_In, n23.TimeInterval<T> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void OperatorEquals<T>(n23.TimeInterval<T> Input_In, n23.TimeInterval<T> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void Interval<T>(n23.TimeInterval<T> Input_In, out n2.TimeSpan Interval_Out)
        {
            var Interval_0 = Input_In.Interval;
            Interval_Out = Interval_0;
            return;
        }

        public static void Value<T>(n23.TimeInterval<T> Input_In, out T Value_Out)
        {
            var Value_0 = Input_In.Value;
            Value_Out = Value_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Timestamped.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NE<T>(n23.Timestamped<T> Input_In, n23.Timestamped<T> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void OperatorEquals<T>(n23.Timestamped<T> Input_In, n23.Timestamped<T> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void Timestamp<T>(n23.Timestamped<T> Input_In, out n2.DateTimeOffset Timestamp_Out)
        {
            var Timestamp_0 = Input_In.Timestamp;
            Timestamp_Out = Timestamp_0;
            return;
        }

        public static void Value<T>(n23.Timestamped<T> Input_In, out T Value_Out)
        {
            var Value_0 = Input_In.Value;
            Value_Out = Value_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.EventPattern.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void OperatorEquals<T, T2>(n23.EventPattern<T, T2> Input_In, n23.EventPattern<T, T2> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void NE<T, T2>(n23.EventPattern<T, T2> Input_In, n23.EventPattern<T, T2> Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public static void EventArgs<T2, T>(n23.EventPattern<T2, T> Input_In, out T Event_Args_Out)
        {
            var Event_Args_0 = Input_In.EventArgs;
            Event_Args_Out = Event_Args_0;
            return;
        }

        public static void Sender<T, T2>(n23.EventPattern<T, T2> Input_In, out T Sender_Out)
        {
            var Sender_0 = Input_In.Sender;
            Sender_Out = Sender_0;
            return;
        }

        [n5.CreateNewAttribute]
        public static void Create<T2, T>(n1.NodeContext Node_Context, T2 Sender_In, T E_In, out n23.EventPattern<T2, T> Output_Out)
        {
            var Output_0 = new n23.EventPattern<T2, T>(sender: Sender_In, e: E_In);
            Output_Out = Output_0;
            return;
        }

        [n5.CreateDefaultAttribute]
        public static n23.EventPattern<T, T2> CreateDefault<T, T2, AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T>, n4.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            w_0.CreateDefault(Output_Out: out T2 Output_2);
            var Output_3 = new n23.EventPattern<T, T2>(sender: Output_1, e: Output_2);
            return Output_3;
        }
    }
}

namespace _VL_Reactive_.Reactive.EventPattern2.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n2.Object Sender_In, T E_In, out n23.EventPattern<T> Output_Out)
        {
            var Output_0 = new n23.EventPattern<T>(sender: Sender_In, e: E_In);
            Output_Out = Output_0;
            return;
        }

        [n5.CreateDefaultAttribute]
        public static n23.EventPattern<T> CreateDefault<T, AdM>()
            where AdM : struct, n4.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            n2.Object Sender_2 = n28._Operations_.CreateDefault();
            var Output_3 = new n23.EventPattern<T>(sender: Sender_2, e: Output_1);
            return Output_3;
        }
    }
}

namespace _VL_Reactive_.Reactive.BlockingReceiver.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n29.BlockingReceiver<T> Output_Out)
        {
            var Output_0 = new n29.BlockingReceiver<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Receive<T>(n29.BlockingReceiver<T> Input__this__In, n2.IObservable<T> Input_In, T Default_Value_In, n30.CancellationToken Cancellation_Token_In, out n29.BlockingReceiver<T> Output_Out, out T Result_Out, out bool Success_Out)
        {
            var Result_1 = Input__this__In.Receive(input: Input_In, defaultValue: Default_Value_In, cancellationToken: Cancellation_Token_In, success: out bool Success_0);
            Output_Out = Input__this__In;
            Result_Out = Result_1;
            Success_Out = Success_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Advanced.Experimental
{
    [n1.ElementAttribute(TracingId = 204885U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "RPjn37rOx3TMmWWspWTMqJ", Name = "MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ")]
    [n2.SerializableAttribute]
    public class MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ Create(n1.NodeContext Node_Context)
        {
            var instance = new MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ CreateDefault()
        {
            var instance = new MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ Update([n5.SerializedDefaultValueAttribute("100", false)] int Period_In, [n5.SerializedDefaultValueAttribute("Periodic", false)] n1.TimerMode Mode_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Reset_Counter_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n2.IObservable<n18.TimerClock> Result_Out, out float Last_Period_Out)
        {
            n18.MultimediaTimerObservable __auto_0 = this.Timer;
            var Result_2 = __auto_0.Update(period: Period_In, mode: Mode_In, resetCounter: Reset_Counter_In, enabled: Enabled_In, lastPeriod: out float Last_Period_1);
            n18.MultimediaTimerObservable __auto_3 = __auto_0;
            Result_Out = Result_2;
            Last_Period_Out = Last_Period_1;
            n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = __auto_0 != this.Timer ? new MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(this)
                {Timer = __auto_0} : that_4;
            else
            {
                this.Timer = __auto_0;
            }

            return that_4;
        }

        public n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n18.MultimediaTimerObservable();
            n18.MultimediaTimerObservable __auto_1 = Output_0;
            n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ that_2 = this;
            this.Timer = Output_0;
            return that_2;
        }

        public n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ Dispose_()
        {
            n18.MultimediaTimerObservable __auto_0 = this.Timer;
            __auto_0.Dispose();
            return this;
        }

        public n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ __CreateDefault__()
        {
            n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ that_0 = this;
            this.Timer = default(n18.MultimediaTimerObservable);
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 204891U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Q9xSS21VSnjPpD3jEC8DSi", Name = "Timer")]
        public n18.MultimediaTimerObservable Timer;
        public MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ other): base(other)
        {
            this.Timer = other.Timer;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Timer", in Timer));
        }

        internal MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ __WITH__(n18.MultimediaTimerObservable Timer)
        {
            n31.MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Timer != this.Timer ? new MultimediaTimer_RPjn37rOx3TMmWWspWTMqJ(this)
                {Timer = Timer} : that_1;
            else
            {
                this.Timer = Timer;
            }

            return that_1;
        }
    }

    [n1.ElementAttribute(TracingId = 204921U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "Oiuupkv6usHNXRlLQ4SAwb", Name = "BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb")]
    [n2.SerializableAttribute]
    public class BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb Create(n1.NodeContext Node_Context)
        {
            var instance = new BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb CreateDefault()
        {
            var instance = new BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb Update([n5.SerializedDefaultValueAttribute("100", false)] float Period_In, [n5.SerializedDefaultValueAttribute("4", false)] int Wait_Accuracy_In, [n5.SerializedDefaultValueAttribute("Periodic", false)] n1.TimerMode Mode_In, [n5.SerializedDefaultValueAttribute("MTA", false)] n30.ApartmentState Thread_Apartment_State_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Reset_Counter_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n2.IObservable<n18.TimerClock> Result_Out, out float Last_Period_Out)
        {
            n18.BusyWaitTimerObservable __auto_0 = this.Timer;
            var Result_2 = __auto_0.Update(period: Period_In, waitAccuracy: Wait_Accuracy_In, mode: Mode_In, threadApartmentState: Thread_Apartment_State_In, resetCounter: Reset_Counter_In, enabled: Enabled_In, lastPeriod: out float Last_Period_1);
            n18.BusyWaitTimerObservable __auto_3 = __auto_0;
            Result_Out = Result_2;
            Last_Period_Out = Last_Period_1;
            n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = __auto_0 != this.Timer ? new BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(this)
                {Timer = __auto_0} : that_4;
            else
            {
                this.Timer = __auto_0;
            }

            return that_4;
        }

        public n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n18.BusyWaitTimerObservable();
            n18.BusyWaitTimerObservable __auto_1 = Output_0;
            n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb that_2 = this;
            this.Timer = Output_0;
            return that_2;
        }

        public n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb Dispose_()
        {
            n18.BusyWaitTimerObservable __auto_0 = this.Timer;
            __auto_0.Dispose();
            return this;
        }

        public n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb __CreateDefault__()
        {
            n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb that_0 = this;
            this.Timer = default(n18.BusyWaitTimerObservable);
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 204927U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", PersistentId = "QW4xH5PBnO7MEWc4ULTm58", Name = "Timer")]
        public n18.BusyWaitTimerObservable Timer;
        public BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb other): base(other)
        {
            this.Timer = other.Timer;
        }

        protected override n1.IVLObject __With__(n12.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Timer", in Timer));
        }

        internal BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb __WITH__(n18.BusyWaitTimerObservable Timer)
        {
            n31.BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Timer != this.Timer ? new BusyWaitTimer_Oiuupkv6usHNXRlLQ4SAwb(this)
                {Timer = Timer} : that_1;
            else
            {
                this.Timer = Timer;
            }

            return that_1;
        }
    }
}

namespace _VL_Reactive_.Reactive.ToObservable_Switch.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n18.ToObservableSwitch<T> Output_Out)
        {
            var Output_0 = new n18.ToObservableSwitch<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Destroy<T>(n18.ToObservableSwitch<T> Input_In, out n18.ToObservableSwitch<T> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void Update<T>(n18.ToObservableSwitch<T> Input_In, n2.IObservable<T> Message_In, bool Send_In, out n18.ToObservableSwitch<T> Output_Out, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = Input_In.Update(message: Message_In, send: Send_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Task.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ToObservable<T>(n33.Task<T> Input_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n32.TaskObservableExtensions.ToObservable<T>(task: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToObservable_Scheduler<T>(n33.Task<T> Input_In, n21.IScheduler Scheduler_In, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = n32.TaskObservableExtensions.ToObservable<T>(task: Input_In, scheduler: Scheduler_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Task_NonGeneric.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ToObservable_Scheduler(n33.Task Input_In, n21.IScheduler Scheduler_In, out n2.IObservable<n23.Unit> Result_Out)
        {
            var Result_0 = n32.TaskObservableExtensions.ToObservable(task: Input_In, scheduler: Scheduler_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToObservable(n33.Task Input_In, out n2.IObservable<n23.Unit> Result_Out)
        {
            var Result_0 = n32.TaskObservableExtensions.ToObservable(task: Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Disposables.SerialDisposable.Advanced
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void SetDisposable(n34.SerialDisposable Input_In, n2.IDisposable Value_In, out n34.SerialDisposable Output_Out)
        {
            Input_In.Disposable = Value_In;
            Output_Out = Input_In;
            return;
        }

        [n5.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, out n34.SerialDisposable Output_Out)
        {
            var Output_0 = new n34.SerialDisposable();
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Debug
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.DebugNode<T> Output_Out)
        {
            var Output_0 = new n18.DebugNode<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.DebugNode<T> Input__this__In, n2.IObservable<T> Input_In, bool Reset_In, out n18.DebugNode<T> Output_Out, out n2.IObservable<T> Result_Out, out int Input_Changed_Count_Out, out int Subscribe_Calls_Out, out int On_Next_Calls_Out, out int On_Error_Calls_Out, out int On_Completed_Calls_Out, out int Unsubscribe_Calls_Out, out int Latest_Thread_Id_Out)
        {
            var Result_7 = Input__this__In.Update(input: Input_In, reset: Reset_In, inputChangedCount: out int Input_Changed_Count_0, subscribeCalls: out int Subscribe_Calls_1, onNextCalls: out int On_Next_Calls_2, onErrorCalls: out int On_Error_Calls_3, onCompletedCalls: out int On_Completed_Calls_4, unsubscribeCalls: out int Unsubscribe_Calls_5, latestThreadId: out int Latest_Thread_Id_6);
            Output_Out = Input__this__In;
            Result_Out = Result_7;
            Input_Changed_Count_Out = Input_Changed_Count_0;
            Subscribe_Calls_Out = Subscribe_Calls_1;
            On_Next_Calls_Out = On_Next_Calls_2;
            On_Error_Calls_Out = On_Error_Calls_3;
            On_Completed_Calls_Out = On_Completed_Calls_4;
            Unsubscribe_Calls_Out = Unsubscribe_Calls_5;
            Latest_Thread_Id_Out = Latest_Thread_Id_6;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.ForEach
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<TState, T, T2>(n1.NodeContext Node_Context, out n18.ForEach<TState, T, T2> Output_Out)
            where TState : class
        {
            var Output_0 = new n18.ForEach<TState, T, T2>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T, T2>(n18.ForEach<TState, T, T2> Input_In, n2.IObservable<T> Messages_In, bool Reset_In, n2.Func<TState> Create_In, n2.Func<TState, T, n2.Tuple<TState, T2>> Update_In, out n18.ForEach<TState, T, T2> Output_Out, out n2.IObservable<T2> Result_Out)
            where TState : class
        {
            var Result_0 = Input_In.Update(messages: Messages_In, reset: Reset_In, create: Create_In, update: Update_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.ForEach_Keep
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<TState, T, T2>(n1.NodeContext Node_Context, out n18.ForEachKeep<TState, T, T2> Output_Out)
            where TState : class
        {
            var Output_0 = new n18.ForEachKeep<TState, T, T2>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T, T2>(n18.ForEachKeep<TState, T, T2> Input_In, n2.IObservable<T> Messages_In, bool Reset_In, n2.Func<TState> Create_In, n2.Func<TState, T, n2.Tuple<TState, T2, bool>> Update_In, out n18.ForEachKeep<TState, T, T2> Output_Out, out n2.IObservable<T2> Result_Out)
            where TState : class
        {
            var Result_0 = Input_In.Update(messages: Messages_In, reset: Reset_In, create: Create_In, update: Update_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.HoldLatest
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, T Initial_Result_In, out n18.HoldLatest<T> Output_Out)
        {
            var Output_0 = new n18.HoldLatest<T>(initialResult: Initial_Result_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.HoldLatest<T> Input_In, n2.IObservable<T> Async_Notifications_In, bool Reset_In, out n18.HoldLatest<T> Output_Out)
        {
            Input_In.Update(asyncNotifications: Async_Notifications_In, reset: Reset_In);
            Output_Out = Input_In;
            return;
        }

        public static void GetData_H<T>(n18.HoldLatest<T> Input_In, out n18.HoldLatest<T> Output_Out, out T Value_Out, out bool On_Data_Out)
        {
            Input_In.GetData(value: out T Value_0, onData: out bool On_Data_1);
            Output_Out = Input_In;
            Value_Out = Value_0;
            On_Data_Out = On_Data_1;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.KeepAlive
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.KeepAlive<T> Output_Out)
        {
            var Output_0 = new n18.KeepAlive<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.KeepAlive<T> Input_In, n2.IObservable<T> Message_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n18.KeepAlive<T> Output_Out, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = Input_In.Update(message: Message_In, enabled: Enabled_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.SPH
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.SampleAndHold<T> Output_Out)
        {
            var Output_0 = new n18.SampleAndHold<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Sample_H<T>(n18.SampleAndHold<T> Input_In, n2.IObservable<T> Async_Notifications_In, out n18.SampleAndHold<T> Output_Out, out n35.Spread<T> Notifications_Out, out bool On_Data_Out)
        {
            Input_In.Sample(asyncNotifications: Async_Notifications_In, notifications: out n35.Spread<T> Notifications_0, onData: out bool On_Data_1);
            Output_Out = Input_In;
            Notifications_Out = Notifications_0;
            On_Data_Out = On_Data_1;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Sampler
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateDefaultAttribute]
        public static n18.Sampler<T> CreateDefault_H<T>()
        {
            var Default_0 = n18.Sampler<T>.Default;
            return Default_0;
        }

        public static void Sample_H<T>(n18.Sampler<T> Input_In, n2.IObservable<T> Async_Notifications_In, out n18.Sampler<T> Output_Out, out n35.Spread<T> Notifications_Out, out bool On_Data_Out)
        {
            var Output_2 = Input_In.Sample(asyncNotifications: Async_Notifications_In, notifications: out n35.Spread<T> Notifications_0, onData: out bool On_Data_1);
            Output_Out = Output_2;
            Notifications_Out = Notifications_0;
            On_Data_Out = On_Data_1;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.ToObservable
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.ToObservable<T> Output_Out)
        {
            var Output_0 = new n18.ToObservable<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.ToObservable<T> Input_In, T Message_In, bool Send_In, out n18.ToObservable<T> Output_Out, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = Input_In.Update(message: Message_In, send: Send_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.ToObservable_Sequence
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.ToObservableSequence<T> Output_Out)
        {
            var Output_0 = new n18.ToObservableSequence<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.ToObservableSequence<T> Input_In, n12.IEnumerable<T> Messages_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Send_In, out n18.ToObservableSequence<T> Output_Out, out n2.IObservable<T> Result_Out)
        {
            var Result_0 = Input_In.Update(messages: Messages_In, send: Send_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Reactive_.Reactive.Splitter
{
    [n1.ElementAttribute(TracingId = 199986U, DocumentId = "AeLw27X3UZTPbUKzkJqoag", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateNewAttribute]
        public static void Create_H<T>(n1.NodeContext Node_Context, out n18.SplitterNode<T> Output_Out)
        {
            var Output_0 = new n18.SplitterNode<T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<T>(n18.SplitterNode<T> Input__this__In, n2.IObservable<T> Input_In, out n18.SplitterNode<T> Output_Out, out n2.IObservable<T> Original_Out, out n2.IObservable<n2.Exception> On_Error_Out, out n2.IObservable<n23.Unit> On_Completed_Out)
        {
            Input__this__In.Update(input: Input_In, original: out n2.IObservable<T> Original_0, onError: out n2.IObservable<n2.Exception> On_Error_1, onCompleted: out n2.IObservable<n23.Unit> On_Completed_2);
            Output_Out = Input__this__In;
            Original_Out = Original_0;
            On_Error_Out = On_Error_1;
            On_Completed_Out = On_Completed_2;
            return;
        }
    }
}

namespace _VL_Reactive_
{
    public struct __AdaptiveImplementations__AeLw27X3UZTPbUKzkJqoag : n4.IAdaptiveCreateDefault<n2.TimeSpan>, n4.IAdaptiveCreateDefault<n2.IObservable<long>>, n4.IAdaptiveCreateDefault<int>, n4.IAdaptiveCreateDefault<bool>, n4.IAdaptiveCreateDefault<n2.IDisposable>, n4.IAdaptiveCreateDefault<n21.IScheduler>, n4.IAdaptiveCreateDefault<double>
    {
        public void CreateDefault(out n2.TimeSpan Output_Out)
        {
            var Zero_0 = n39._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<long> Output_Out)
        {
            var Result_0 = n8._Operations_.CreateDefault<long>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n40._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n40._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.IDisposable Output_Out)
        {
            n40._Operations_.CreateDefault_Generic<n2.IDisposable>(Output_Out: out n2.IDisposable Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n21.IScheduler Output_Out)
        {
            var Output_0 = n41._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out double Output_Out)
        {
            n40._Operations_.CreateDefault_Generic<double>(Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}