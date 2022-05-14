extern alias e6;
extern alias e2;
extern alias e5;

using n9 = _CoreLibBasics_.Primitive.Object.Advanced;
using n10 = global::System.Collections.Immutable;
using n7 = e6::VL.Lang.PublicAPI;
using n3 = e6::VL.Model;
using n6 = e2::VL.Lib.Primitive.Object;
using n5 = e5::VL.Core.CompilerServices;
using n14 = _VL_Lang_.VL.Session;
using n12 = e6::VL.Lang;
using n19 = global::System.Reactive.Disposables;
using n16 = global::System.Collections.Generic;
using n11 = e2::VL.Lib.Primitive.CacheRegion;
using n20 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n2 = global::System;
using n21 = _VL_Reactive_.Reactive.ForEach;
using n8 = e6::VL.Lang.Symbols;
using n4 = _VL_Lang_.VL;
using n18 = _VL_Collections_.Collections.Sequence;
using n13 = global::System.Runtime.CompilerServices;
using n15 = e5::VL.Lib.Collections;
using n17 = _VL_Collections_.Collections.Spread;

namespace _VL_Lang_.VL.Model.DataHub
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GetClrType(n3.DataHub Input_In, out n2.Type Result_Out)
        {
            var Result_0 = n3.ModelInterfaceExtensions.GetClrType(hub: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetClrValue(n3.DataHub Input_In, n2.Type Type_In, out n2.Object Result_Out)
        {
            var Result_0 = n3.ModelInterfaceExtensions.GetClrValue(hub: Input_In, type: Type_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Lang_.VL.Model.NameAndVersion
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NamePart(n3.NameAndVersion Input_In, out string Name_Part_Out)
        {
            var Name_Part_0 = Input_In.NamePart;
            Name_Part_Out = Name_Part_0;
            return;
        }

        public static void VersionPart(n3.NameAndVersion Input_In, out string Version_Part_Out)
        {
            var Version_Part_0 = Input_In.VersionPart;
            Version_Part_Out = Version_Part_0;
            return;
        }
    }
}

namespace _VL_Lang_.VL.Model.Solution
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void MakeCurrent(n3.Solution Input_In, [n5.SerializedDefaultValueAttribute("Default", false)] n3.SolutionUpdateKind Kind_In, n3.Canvas Canvas_In)
        {
            n3.ModelExtensions.MakeCurrent(solution: Input_In, kind: Kind_In, canvas: Canvas_In);
            return;
        }
    }
}

namespace _VL_Lang_.VL
{
    [n1.ElementAttribute(TracingId = 25830U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "MiCPmvTOC3PO5DW2pduuvS", Name = "GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS")]
    [n2.SerializableAttribute]
    public class GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS Create(n1.NodeContext Node_Context)
        {
            var instance = new GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS CreateDefault()
        {
            var instance = new GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS Update(n2.Object Value_In, n8.IScope Scope_In, out n8.IConcreteTypeSymbol Output_Out)
        {
            n6.ObjectHelpers.IsAssigned(x: Value_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n6.ObjectHelpers.IsAssigned(x: Scope_In, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            var Output_4 = Result_0 && Result_2;
            n8.IConcreteTypeSymbol __auto_5;
            var state_6 = n1.CompilationHelper.Restore<__SCTrHpI07FjMmSZGPHDev4>(this.__if_BVqLRZpW1DzLZv59bVCBBC, __GetContext__());
            if (Output_4)
            {
                if (state_6 == null)
                {
                    state_6 = new __SCTrHpI07FjMmSZGPHDev4(__GetContext__(), n1.VLObject.NewIdentity());
                }

                n9._Operations_.GetType(Input_In: Value_In, Output_Out: out n2.Type Output_7);
                bool Force_8 = false;
                bool Dispose_Cached_Outputs_9 = false;
                var manager_10 = state_6.__cache_PH2m5se9VygNzKtVjnwfxP;
                if (manager_10 is null)
                {
                    manager_10 = new n11.Manager<n2.ValueTuple<n2.Type, n8.IScope>, n2.ValueTuple<n8.IConcreteTypeSymbol>>(n2.ValueTuple.Create(default(n8.IConcreteTypeSymbol)));
                }

                var inputs_11 = (Output_7, Scope_In);
                var outputs_12 = manager_10.Outputs;
                var Has_Changed_13 = Force_8 || manager_10.InputsChanged(inputs_11);
                if (Has_Changed_13)
                {
                    if (Dispose_Cached_Outputs_9)
                        manager_10.DisposeOutputs();
                    var Result_15 = n12.ReflectionExtensions.ToVlType(type: Output_7, scope: Scope_In);
                    outputs_12 = n2.ValueTuple.Create(Result_15);
                    manager_10 = manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9, default, outputs_12);
                }
                else
                {
                    manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9);
                }

                var __auto_16 = outputs_12.Item1;
                __auto_5 = __auto_16;
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = manager_10 != state_6.__cache_PH2m5se9VygNzKtVjnwfxP ? new __SCTrHpI07FjMmSZGPHDev4(state_6)
                    {__cache_PH2m5se9VygNzKtVjnwfxP = manager_10} : state_6;
                else
                {
                    state_6.__cache_PH2m5se9VygNzKtVjnwfxP = manager_10;
                }
            }
            else
            {
                __auto_5 = default(n8.IConcreteTypeSymbol);
            }

            Output_Out = __auto_5;
            n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS that_17 = this;
            if (this.__GetContext__().IsImmutable)
                that_17 = state_6 != this.__if_BVqLRZpW1DzLZv59bVCBBC ? new GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(this)
                {__if_BVqLRZpW1DzLZv59bVCBBC = state_6} : that_17;
            else
            {
                this.__if_BVqLRZpW1DzLZv59bVCBBC = state_6;
            }

            return that_17;
        }

        public n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS __Create__(n1.NodeContext Node_Context)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS that_0 = this;
            this.__if_BVqLRZpW1DzLZv59bVCBBC = default(n2.Object);
            return that_0;
        }

        public n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS __CreateDefault__()
        {
            n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS that_0 = this;
            this.__if_BVqLRZpW1DzLZv59bVCBBC = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_BVqLRZpW1DzLZv59bVCBBC);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_BVqLRZpW1DzLZv59bVCBBC;
        public GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS other): base(other)
        {
            this.__if_BVqLRZpW1DzLZv59bVCBBC = other.__if_BVqLRZpW1DzLZv59bVCBBC;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_BVqLRZpW1DzLZv59bVCBBC", in __if_BVqLRZpW1DzLZv59bVCBBC));
        }

        internal GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS __WITH__(n2.Object __if_BVqLRZpW1DzLZv59bVCBBC)
        {
            n4.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_BVqLRZpW1DzLZv59bVCBBC != this.__if_BVqLRZpW1DzLZv59bVCBBC ? new GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS(this)
                {__if_BVqLRZpW1DzLZv59bVCBBC = __if_BVqLRZpW1DzLZv59bVCBBC} : that_0;
            else
            {
                this.__if_BVqLRZpW1DzLZv59bVCBBC = __if_BVqLRZpW1DzLZv59bVCBBC;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "SCTrHpI07FjMmSZGPHDev4", Name = "__SCTrHpI07FjMmSZGPHDev4")]
        [n2.SerializableAttribute]
        public class __SCTrHpI07FjMmSZGPHDev4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_PH2m5se9VygNzKtVjnwfxP);
                return;
            }

            [n1.ElementAttribute(TracingId = 25853U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "PH2m5se9VygNzKtVjnwfxP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n11.Manager<n2.ValueTuple<n2.Type, n8.IScope>, n2.ValueTuple<n8.IConcreteTypeSymbol>> __cache_PH2m5se9VygNzKtVjnwfxP = null;
            public __SCTrHpI07FjMmSZGPHDev4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SCTrHpI07FjMmSZGPHDev4(__SCTrHpI07FjMmSZGPHDev4 other): base(other)
            {
                this.__cache_PH2m5se9VygNzKtVjnwfxP = other.__cache_PH2m5se9VygNzKtVjnwfxP;
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PH2m5se9VygNzKtVjnwfxP", in __cache_PH2m5se9VygNzKtVjnwfxP));
            }

            internal __SCTrHpI07FjMmSZGPHDev4 __WITH__(n11.Manager<n2.ValueTuple<n2.Type, n8.IScope>, n2.ValueTuple<n8.IConcreteTypeSymbol>> __cache_PH2m5se9VygNzKtVjnwfxP)
            {
                __SCTrHpI07FjMmSZGPHDev4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_PH2m5se9VygNzKtVjnwfxP != this.__cache_PH2m5se9VygNzKtVjnwfxP ? new __SCTrHpI07FjMmSZGPHDev4(this)
                    {__cache_PH2m5se9VygNzKtVjnwfxP = __cache_PH2m5se9VygNzKtVjnwfxP} : that_0;
                else
                {
                    this.__cache_PH2m5se9VygNzKtVjnwfxP = __cache_PH2m5se9VygNzKtVjnwfxP;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CurrentSolution(out n3.Solution Current_Solution_Out)
        {
            var Instance_0 = n3.VLSession.Instance;
            var Current_Solution_1 = Instance_0.CurrentSolution;
            Current_Solution_Out = Current_Solution_1;
            return;
        }
    }
}

namespace _VL_Lang_.VL.ISolution
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Confirm(n7.ISolution Input_In, [n5.SerializedDefaultValueAttribute("Default", false)] n3.SolutionUpdateKind Solution_Update_Kind_In, out n7.ISolution Output_Out)
        {
            ((n7.ISolution)Input_In).Confirm(solutionUpdateKind: Solution_Update_Kind_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetPinValue_OrFurtherOutwards(n7.ISolution Input_In, n10.ImmutableStack<uint> Stack_In, string Pin_In, n2.Object Value_In, out n7.ISolution Output_Out)
        {
            var Output_0 = ((n7.ISolution)Input_In).SetPinValue(stack: Stack_In, pin: Pin_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void SetPinValue(n7.ISolution Input_In, uint Node_In, string Pin_In, n2.Object Value_In, out n7.ISolution Output_Out)
        {
            var Output_0 = ((n7.ISolution)Input_In).SetPinValue(node: Node_In, pin: Pin_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void SetPinValue_OrFurtherOutwards(n7.ISolution Input_In, n10.ImmutableStack<n1.UniqueId> Stack_In, string Pin_In, n2.Object Value_In, out n7.ISolution Output_Out)
        {
            var Output_0 = ((n7.ISolution)Input_In).SetPinValue(stack: Stack_In, pin: Pin_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void SetPinValue(n7.ISolution Input_In, n1.UniqueId Node_In, string Pin_In, n2.Object Value_In, out n7.ISolution Output_Out)
        {
            var Output_0 = ((n7.ISolution)Input_In).SetPinValue(node: Node_In, pin: Pin_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void ModifyPinGroup(n7.ISolution Input_In, uint Node_Id_In, string Pin_Group_In, bool Is_Input_In, out n7.PinGroupBuilder Result_Out)
        {
            var Result_0 = ((n7.ISolution)Input_In).ModifyPinGroup(nodeId: Node_Id_In, pinGroup: Pin_Group_In, isInput: Is_Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void ModifyPinGroup(n7.ISolution Input_In, n1.UniqueId Node_Id_In, string Pin_Group_In, bool Is_Input_In, out n7.PinGroupBuilder Result_Out)
        {
            var Result_0 = ((n7.ISolution)Input_In).ModifyPinGroup(nodeId: Node_Id_In, pinGroup: Pin_Group_In, isInput: Is_Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Lang_.VL.Session
{
    [n1.ElementAttribute(TracingId = 23231U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "KZL6CijWUqQOxf8NXnAKDW", Name = "Warn_KZL6CijWUqQOxf8NXnAKDW")]
    [n2.SerializableAttribute]
    public class Warn_KZL6CijWUqQOxf8NXnAKDW : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.Warn_KZL6CijWUqQOxf8NXnAKDW Create(n1.NodeContext Node_Context_In, [n5.SerializedDefaultValueAttribute("WARNING", false)] string Warning_In, [n5.SerializedDefaultValueAttribute("", false)] string Why_In, [n5.SerializedDefaultValueAttribute("", false)] string How_In, [n5.SerializedDefaultValueAttribute("", false)] string Ignore_In, [n5.SerializedDefaultValueAttribute("9999", false)] int Depth_In)
        {
            var instance = new Warn_KZL6CijWUqQOxf8NXnAKDW(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In, Warning_In, Why_In, How_In, Ignore_In, Depth_In);
        }

        [n5.CreateDefaultAttribute]
        public static n14.Warn_KZL6CijWUqQOxf8NXnAKDW CreateDefault()
        {
            var instance = new Warn_KZL6CijWUqQOxf8NXnAKDW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.Warn_KZL6CijWUqQOxf8NXnAKDW Update(bool WARN_In)
        {
            n15.Spread<n12.Message> __auto_0 = this.Messages;
            if (WARN_In)
            {
                var i_4 = 0;
                foreach (var item_2 in n5.CollectionExtensions.AsSpan(__auto_0))
                {
                    var splicer_3 = item_2;
                    var i_local_5 = i_4;
                    n7.Session.AddMessage(message: splicer_3);
                    i_4++;
                }
            }

            return this;
        }

        public n14.Warn_KZL6CijWUqQOxf8NXnAKDW __Create__(n1.NodeContext Node_Context_In, [n5.SerializedDefaultValueAttribute("WARNING", false)] string Warning_In, [n5.SerializedDefaultValueAttribute("", false)] string Why_In, [n5.SerializedDefaultValueAttribute("", false)] string How_In, [n5.SerializedDefaultValueAttribute("", false)] string Ignore_In, [n5.SerializedDefaultValueAttribute("9999", false)] int Depth_In)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Path_0 = Node_Context_In.Path;
            var Stack_1 = Path_0.Stack;
            n16.IEnumerable<n1.UniqueId> Input_2 = (n16.IEnumerable<n1.UniqueId>)Stack_1;
            n18._Operations_.Take<n1.UniqueId>(Input_In: Input_2, Count_In: Depth_In, Output_Out: out n16.IEnumerable<n1.UniqueId> Output_3);
            var builder_10 = n5.CollectionBuilders.GetBuilder(n17._Operations_.CreateDefault<n12.Message>(), 16);
            n15.Spread<n12.Message> output_11;
            try
            {
                var i_6 = 0;
                foreach (var item_4 in Output_3)
                {
                    var splicer_5 = item_4;
                    var i_local_7 = i_6;
                    n12.MessageSeverity Severity_8 = __c_PrlUVtvMoSaN6Y3RSIuzT7;
                    var Output_9 = new n12.Message(location: splicer_5, severity: Severity_8, what: Warning_In, why: Why_In, how: How_In, ignore: Ignore_In);
                    builder_10.Add(Output_9);
                    i_6++;
                }
            }
            finally
            {
                output_11 = builder_10.Commit();
            }

            n15.Spread<n12.Message> __auto_12 = output_11;
            n14.Warn_KZL6CijWUqQOxf8NXnAKDW that_13 = this;
            this.Messages = output_11;
            this.__cp_RfojuYqqgKOPPrvvWwyLaX = output_11;
            return that_13;
        }

        public n14.Warn_KZL6CijWUqQOxf8NXnAKDW __CreateDefault__()
        {
            n14.Warn_KZL6CijWUqQOxf8NXnAKDW that_0 = this;
            this.Messages = n17._Operations_.CreateDefault<n12.Message>();
            this.__cp_RfojuYqqgKOPPrvvWwyLaX = n17._Operations_.CreateDefault<n12.Message>();
            return that_0;
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

        [n1.ElementAttribute(TracingId = 24807U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "FRr1vOn8uCIN8wX7yJaSUy", Name = "Messages")]
        public n15.Spread<n12.Message> Messages;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n12.MessageSeverity __c_PrlUVtvMoSaN6Y3RSIuzT7 = n1.CompilationHelper.Deserialize<n12.MessageSeverity>("Warning", false, "AMsJsrrhltMMjgtUbICS42", "PrlUVtvMoSaN6Y3RSIuzT7");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n15.Spread<n12.Message> __cp_RfojuYqqgKOPPrvvWwyLaX;
        static Warn_KZL6CijWUqQOxf8NXnAKDW()
        {
        }

        public Warn_KZL6CijWUqQOxf8NXnAKDW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Warn_KZL6CijWUqQOxf8NXnAKDW(Warn_KZL6CijWUqQOxf8NXnAKDW other): base(other)
        {
            this.Messages = other.Messages;
            this.__cp_RfojuYqqgKOPPrvvWwyLaX = other.__cp_RfojuYqqgKOPPrvvWwyLaX;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Messages", in Messages), n1.CompilationHelper.GetValueOrExisting(values, "__cp_RfojuYqqgKOPPrvvWwyLaX", in __cp_RfojuYqqgKOPPrvvWwyLaX));
        }

        internal Warn_KZL6CijWUqQOxf8NXnAKDW __WITH__(n15.Spread<n12.Message> Messages, n15.Spread<n12.Message> __cp_RfojuYqqgKOPPrvvWwyLaX)
        {
            n14.Warn_KZL6CijWUqQOxf8NXnAKDW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Messages != this.Messages || __cp_RfojuYqqgKOPPrvvWwyLaX != this.__cp_RfojuYqqgKOPPrvvWwyLaX ? new Warn_KZL6CijWUqQOxf8NXnAKDW(this)
                {Messages = Messages, __cp_RfojuYqqgKOPPrvvWwyLaX = __cp_RfojuYqqgKOPPrvvWwyLaX} : that_0;
            else
            {
                this.Messages = Messages;
                this.__cp_RfojuYqqgKOPPrvvWwyLaX = __cp_RfojuYqqgKOPPrvvWwyLaX;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 24875U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "GYsdXrRxO0XPGjJN6a55zq", Name = "Warn_Reactive_C")]
    [n2.SerializableAttribute]
    public class Warn_Reactive_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.Warn_Reactive_C Create(n2.IObservable<bool> WARN_In, n1.NodeContext Node_Context_In, [n5.SerializedDefaultValueAttribute("WARNING", false)] string Warning_In, [n5.SerializedDefaultValueAttribute("", false)] string Why_In, [n5.SerializedDefaultValueAttribute("", false)] string How_In, [n5.SerializedDefaultValueAttribute("", false)] string Ignore_In, [n5.SerializedDefaultValueAttribute("9999", false)] int Depth_In)
        {
            Node_Context_In = Node_Context_In.WithIsImmutable(false);
            var instance = new Warn_Reactive_C(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(WARN_In, Node_Context_In, Warning_In, Why_In, How_In, Ignore_In, Depth_In);
        }

        [n5.CreateDefaultAttribute]
        public static n14.Warn_Reactive_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Warn_Reactive_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.Warn_Reactive_C __Create__(n2.IObservable<bool> WARN_In, n1.NodeContext Node_Context_In, [n5.SerializedDefaultValueAttribute("WARNING", false)] string Warning_In, [n5.SerializedDefaultValueAttribute("", false)] string Why_In, [n5.SerializedDefaultValueAttribute("", false)] string How_In, [n5.SerializedDefaultValueAttribute("", false)] string Ignore_In, [n5.SerializedDefaultValueAttribute("9999", false)] int Depth_In)
        {
            n13.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_AZ0wgWEVigsOAHPjmcrCv0 = default(n19.CompositeDisposable);
            var Output_0 = new n19.CompositeDisposable();
            this.__slot_AZ0wgWEVigsOAHPjmcrCv0 = Output_0;
            n19.CompositeDisposable __pad_AZ0wgWEVigsOAHPjmcrCv0_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context_In.CreateSubContext("AMsJsrrhltMMjgtUbICS42", "JINlkHk6eoOQMgsPbLZZen", 24891U);
            n21._Operations_.Create_H<n2.Object, bool, bool>(Node_Context: Node_Context_2, Output_Out: out n20.ForEach<n2.Object, bool, bool> Output_3);
            this.__p_JINlkHk6eoOQMgsPbLZZen = Output_3;
            bool Reset_4 = false;
            var __fallback___5 = n1.ServiceRegistry.Current;
            n21._Operations_.Update_H<n2.Object, bool, bool>(Input_In: Output_3, Messages_In: WARN_In, Reset_In: Reset_4, Update_In: (n2.Object s_7, bool On_In_8) =>
            {
                using var __current_6 = __fallback___5.MakeCurrentIfNone();
                var state_7 = n1.CompilationHelper.Restore<__BFNxsJqZ7yJOoVng5TNI0E>(s_7, Node_Context_In);
                __pad_AZ0wgWEVigsOAHPjmcrCv0_1.Clear();
                if (On_In_8)
                {
                    var Path_9 = Node_Context_In.Path;
                    var Stack_10 = Path_9.Stack;
                    n16.IEnumerable<n1.UniqueId> Input_11 = (n16.IEnumerable<n1.UniqueId>)Stack_10;
                    n18._Operations_.Take<n1.UniqueId>(Input_In: Input_11, Count_In: Depth_In, Output_Out: out n16.IEnumerable<n1.UniqueId> Output_12);
                    var i_15 = 0;
                    foreach (var item_13 in Output_12)
                    {
                        var splicer_14 = item_13;
                        var i_local_16 = i_15;
                        n12.MessageSeverity Severity_17 = __c_Vdyn3pSHlfsLnTVExjvgYQ;
                        var Output_18 = new n12.Message(location: splicer_14, severity: Severity_17, what: Warning_In, why: Why_In, how: How_In, ignore: Ignore_In);
                        var Result_19 = n7.Session.AddPersistentMessage(message: Output_18);
                        __pad_AZ0wgWEVigsOAHPjmcrCv0_1.Add(item: Result_19);
                        i_15++;
                    }
                }

                return n2.Tuple.Create<n2.Object, bool>(state_7, On_In_8);
            }

            , Create_In: () =>
            {
                using var __current_20 = __fallback___5.MakeCurrentIfNone();
                var state_7 = new __BFNxsJqZ7yJOoVng5TNI0E(Node_Context_In, n1.VLObject.NewIdentity());
                return state_7;
            }

            , Output_Out: out n20.ForEach<n2.Object, bool, bool> Output_21, Result_Out: out n2.IObservable<bool> Result_22);
            this.__p_JINlkHk6eoOQMgsPbLZZen = Output_21;
            return this;
        }

        public n14.Warn_Reactive_C Dispose_()
        {
            n19.CompositeDisposable __pad_AZ0wgWEVigsOAHPjmcrCv0_0 = this.__slot_AZ0wgWEVigsOAHPjmcrCv0;
            n2.IDisposable Input_1 = (n2.IDisposable)__pad_AZ0wgWEVigsOAHPjmcrCv0_0;
            ((n2.IDisposable)Input_1).Dispose();
            n1.CompilationHelper.SafeDispose(this.__p_JINlkHk6eoOQMgsPbLZZen);
            return this;
        }

        public n14.Warn_Reactive_C __CreateDefault__()
        {
            this.__slot_AZ0wgWEVigsOAHPjmcrCv0 = default(n19.CompositeDisposable);
            this.__p_JINlkHk6eoOQMgsPbLZZen = default(n20.ForEach<n2.Object, bool, bool>);
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 25012U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "RZ51dSiQBRCQEoSZkrKVfi", Name = "__slot_RZ51dSiQBRCQEoSZkrKVfi")]
        public static string __slot_RZ51dSiQBRCQEoSZkrKVfi = "On Dispose turn them off";
        [n1.ElementAttribute(TracingId = 25026U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "AZ0wgWEVigsOAHPjmcrCv0", Name = "__slot_AZ0wgWEVigsOAHPjmcrCv0")]
        public n19.CompositeDisposable __slot_AZ0wgWEVigsOAHPjmcrCv0;
        [n1.ElementAttribute(TracingId = 24891U, DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "JINlkHk6eoOQMgsPbLZZen", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n20.ForEach<n2.Object, bool, bool> __p_JINlkHk6eoOQMgsPbLZZen;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n12.MessageSeverity __c_Vdyn3pSHlfsLnTVExjvgYQ = n1.CompilationHelper.Deserialize<n12.MessageSeverity>("Warning", false, "AMsJsrrhltMMjgtUbICS42", "Vdyn3pSHlfsLnTVExjvgYQ");
        static Warn_Reactive_C()
        {
        }

        public Warn_Reactive_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Warn_Reactive_C(Warn_Reactive_C other): base(other)
        {
            this.__slot_AZ0wgWEVigsOAHPjmcrCv0 = other.__slot_AZ0wgWEVigsOAHPjmcrCv0;
            this.__p_JINlkHk6eoOQMgsPbLZZen = other.__p_JINlkHk6eoOQMgsPbLZZen;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_AZ0wgWEVigsOAHPjmcrCv0", in __slot_AZ0wgWEVigsOAHPjmcrCv0), n1.CompilationHelper.GetValueOrExisting(values, "__p_JINlkHk6eoOQMgsPbLZZen", in __p_JINlkHk6eoOQMgsPbLZZen));
        }

        internal Warn_Reactive_C __WITH__(n19.CompositeDisposable __slot_AZ0wgWEVigsOAHPjmcrCv0, n20.ForEach<n2.Object, bool, bool> __p_JINlkHk6eoOQMgsPbLZZen)
        {
            n14.Warn_Reactive_C that_0 = this;
            this.__slot_AZ0wgWEVigsOAHPjmcrCv0 = __slot_AZ0wgWEVigsOAHPjmcrCv0;
            this.__p_JINlkHk6eoOQMgsPbLZZen = __p_JINlkHk6eoOQMgsPbLZZen;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AMsJsrrhltMMjgtUbICS42", PersistentId = "BFNxsJqZ7yJOoVng5TNI0E", Name = "__BFNxsJqZ7yJOoVng5TNI0E")]
        [n2.SerializableAttribute]
        public class __BFNxsJqZ7yJOoVng5TNI0E : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __BFNxsJqZ7yJOoVng5TNI0E(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BFNxsJqZ7yJOoVng5TNI0E(__BFNxsJqZ7yJOoVng5TNI0E other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __BFNxsJqZ7yJOoVng5TNI0E __WITH__()
            {
                return this;
            }
        }
    }
}

namespace _VL_Lang_.VL.PinGroupBuilder
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Commit(n7.PinGroupBuilder Input_In, out n7.ISolution Result_Out, out n7.PinGroupBuilder State_Output_Out)
        {
            var Result_0 = Input_In.Commit();
            Result_Out = Result_0;
            State_Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Lang_.VL.LiveValueNotification
{
    [n1.ElementAttribute(TracingId = 22042U, DocumentId = "AMsJsrrhltMMjgtUbICS42", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.LiveValueNotification Input_In, out n2.Object Value_Out, out n8.PatchNotification Source_Out)
        {
            var Value_0 = Input_In.Value;
            var Source_1 = Input_In.Source;
            Value_Out = Value_0;
            Source_Out = Source_1;
            return;
        }
    }
}

namespace _VL_Lang_
{
    public struct __AdaptiveImplementations__AMsJsrrhltMMjgtUbICS42
    {
    }
}