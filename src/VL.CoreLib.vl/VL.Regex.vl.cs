extern alias e3;
extern alias e2;

using n19 = _CoreLibBasics_.Control.Advanced;
using n10 = e2::VL.Lib.Collections;
using n6 = e3::VL.Lib.Primitive.CacheRegion;
using n9 = global::System.Collections.Generic;
using n16 = _VL_Regex_.Text.RegularExpressions.Patched.SpecialCharacters.Experimental;
using n20 = global::System.Text;
using n13 = e3::VL.Lib.Primitive;
using n12 = e2::VL.Lib.Runtime;
using n5 = global::System.Text.RegularExpressions;
using n1 = e2::VL.Core;
using n2 = global::System;
using n15 = _VL_Regex_.Text.RegularExpressions.Patched.Alternation.Experimental;
using n14 = _VL_Regex_.Text.RegularExpressions.Patched.CharacterClasses.Experimental;
using n7 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n18 = _VL_Regex_.Text.RegularExpressions.Patched.Quantifiers.Experimental;
using n8 = global::System.Runtime.CompilerServices;
using n17 = _VL_Regex_.Text.RegularExpressions.Patched.Anchors.Experimental;
using n11 = _VL_Collections_.Collections.Spread;
using n3 = _VL_Regex_.Text.RegularExpressions;

namespace _VL_Regex_.Text.RegularExpressions
{
    [n1.ElementAttribute(TracingId = 117318U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "No3CCkpgB8zO94DQbGm6O4", Name = "IsMatch_No3CCkpgB8zO94DQbGm6O4")]
    [n2.SerializableAttribute]
    public class IsMatch_No3CCkpgB8zO94DQbGm6O4 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 Create(n1.NodeContext Node_Context)
        {
            var instance = new IsMatch_No3CCkpgB8zO94DQbGm6O4(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 CreateDefault()
        {
            var instance = new IsMatch_No3CCkpgB8zO94DQbGm6O4(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 Update(string Input_In, string Pattern_In, [n4.SerializedDefaultValueAttribute("Compiled", false)] n5.RegexOptions Options_In, out bool Result_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_O1rkEy1RHn3NlMpcwCbBTq;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>>(n2.ValueTuple.Create(default(n5.Regex)));
            }

            var inputs_3 = (Pattern_In, Options_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_7 = new n5.Regex(pattern: Pattern_In, options: Options_In);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            bool Force_9 = false;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_TzW1uqoYLntN6leNn86oW7;
            if (manager_11 is null)
            {
                manager_11 = new n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<bool>>(n2.ValueTuple.Create(false));
            }

            var inputs_12 = (__auto_8, Input_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Force_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                n7.ObjectHelpers.IsAssigned(x: __auto_8, result: out bool Result_16, notAssigned: out bool Not_Assigned_17);
                bool __auto_18;
                if (Result_16)
                {
                    var Result_20 = __auto_8.IsMatch(input: Input_In);
                    __auto_18 = Result_20;
                }
                else
                {
                    __auto_18 = false;
                }

                outputs_13 = n2.ValueTuple.Create(__auto_18);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, default, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var __auto_21 = outputs_13.Item1;
            Result_Out = __auto_21;
            n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = manager_2 != this.__cache_O1rkEy1RHn3NlMpcwCbBTq || manager_11 != this.__cache_TzW1uqoYLntN6leNn86oW7 ? new IsMatch_No3CCkpgB8zO94DQbGm6O4(this)
                {__cache_O1rkEy1RHn3NlMpcwCbBTq = manager_2, __cache_TzW1uqoYLntN6leNn86oW7 = manager_11} : that_22;
            else
            {
                this.__cache_O1rkEy1RHn3NlMpcwCbBTq = manager_2;
                this.__cache_TzW1uqoYLntN6leNn86oW7 = manager_11;
            }

            return that_22;
        }

        public n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 that_0 = this;
            this.__cache_O1rkEy1RHn3NlMpcwCbBTq = null;
            this.__cache_TzW1uqoYLntN6leNn86oW7 = null;
            return that_0;
        }

        public n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 __CreateDefault__()
        {
            n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 that_0 = this;
            this.__cache_O1rkEy1RHn3NlMpcwCbBTq = null;
            this.__cache_TzW1uqoYLntN6leNn86oW7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_O1rkEy1RHn3NlMpcwCbBTq);
            n1.CompilationHelper.SafeDispose(this.__cache_TzW1uqoYLntN6leNn86oW7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117325U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "O1rkEy1RHn3NlMpcwCbBTq", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_O1rkEy1RHn3NlMpcwCbBTq = null;
        [n1.ElementAttribute(TracingId = 117387U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "TzW1uqoYLntN6leNn86oW7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<bool>> __cache_TzW1uqoYLntN6leNn86oW7 = null;
        public IsMatch_No3CCkpgB8zO94DQbGm6O4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IsMatch_No3CCkpgB8zO94DQbGm6O4(IsMatch_No3CCkpgB8zO94DQbGm6O4 other): base(other)
        {
            this.__cache_O1rkEy1RHn3NlMpcwCbBTq = other.__cache_O1rkEy1RHn3NlMpcwCbBTq;
            this.__cache_TzW1uqoYLntN6leNn86oW7 = other.__cache_TzW1uqoYLntN6leNn86oW7;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_O1rkEy1RHn3NlMpcwCbBTq", in __cache_O1rkEy1RHn3NlMpcwCbBTq), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TzW1uqoYLntN6leNn86oW7", in __cache_TzW1uqoYLntN6leNn86oW7));
        }

        internal IsMatch_No3CCkpgB8zO94DQbGm6O4 __WITH__(n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_O1rkEy1RHn3NlMpcwCbBTq, n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<bool>> __cache_TzW1uqoYLntN6leNn86oW7)
        {
            n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_O1rkEy1RHn3NlMpcwCbBTq != this.__cache_O1rkEy1RHn3NlMpcwCbBTq || __cache_TzW1uqoYLntN6leNn86oW7 != this.__cache_TzW1uqoYLntN6leNn86oW7 ? new IsMatch_No3CCkpgB8zO94DQbGm6O4(this)
                {__cache_O1rkEy1RHn3NlMpcwCbBTq = __cache_O1rkEy1RHn3NlMpcwCbBTq, __cache_TzW1uqoYLntN6leNn86oW7 = __cache_TzW1uqoYLntN6leNn86oW7} : that_0;
            else
            {
                this.__cache_O1rkEy1RHn3NlMpcwCbBTq = __cache_O1rkEy1RHn3NlMpcwCbBTq;
                this.__cache_TzW1uqoYLntN6leNn86oW7 = __cache_TzW1uqoYLntN6leNn86oW7;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 117582U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "F5NEdQWxM1sMWC1M7hYyBj", Name = "Replace_F5NEdQWxM1sMWC1M7hYyBj")]
    [n2.SerializableAttribute]
    public class Replace_F5NEdQWxM1sMWC1M7hYyBj : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Replace_F5NEdQWxM1sMWC1M7hYyBj Create(n1.NodeContext Node_Context)
        {
            var instance = new Replace_F5NEdQWxM1sMWC1M7hYyBj(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Replace_F5NEdQWxM1sMWC1M7hYyBj CreateDefault()
        {
            var instance = new Replace_F5NEdQWxM1sMWC1M7hYyBj(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Replace_F5NEdQWxM1sMWC1M7hYyBj Update(string Input_In, string Pattern_In, string Replacement_In, [n4.SerializedDefaultValueAttribute("Compiled", false)] n5.RegexOptions Options_In, out string Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_U14jUiVqjzoLhR3Cnu355R;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>>(n2.ValueTuple.Create(default(n5.Regex)));
            }

            var inputs_3 = (Pattern_In, Options_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_7 = new n5.Regex(pattern: Pattern_In, options: Options_In);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            bool Force_9 = false;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_RsRnu9h2g59LEH3VgogPcX;
            if (manager_11 is null)
            {
                manager_11 = new n6.Manager<n2.ValueTuple<n5.Regex, string, string>, n2.ValueTuple<string>>(n2.ValueTuple.Create(""));
            }

            var inputs_12 = (__auto_8, Input_In, Replacement_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Force_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                n7.ObjectHelpers.IsAssigned(x: __auto_8, result: out bool Result_16, notAssigned: out bool Not_Assigned_17);
                string __auto_18;
                if (Result_16)
                {
                    var Result_20 = __auto_8.Replace(input: Input_In, replacement: Replacement_In);
                    __auto_18 = Result_20;
                }
                else
                {
                    __auto_18 = "";
                }

                outputs_13 = n2.ValueTuple.Create(__auto_18);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, default, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var __auto_21 = outputs_13.Item1;
            Output_Out = __auto_21;
            n3.Replace_F5NEdQWxM1sMWC1M7hYyBj that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = manager_2 != this.__cache_U14jUiVqjzoLhR3Cnu355R || manager_11 != this.__cache_RsRnu9h2g59LEH3VgogPcX ? new Replace_F5NEdQWxM1sMWC1M7hYyBj(this)
                {__cache_U14jUiVqjzoLhR3Cnu355R = manager_2, __cache_RsRnu9h2g59LEH3VgogPcX = manager_11} : that_22;
            else
            {
                this.__cache_U14jUiVqjzoLhR3Cnu355R = manager_2;
                this.__cache_RsRnu9h2g59LEH3VgogPcX = manager_11;
            }

            return that_22;
        }

        public n3.Replace_F5NEdQWxM1sMWC1M7hYyBj __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Replace_F5NEdQWxM1sMWC1M7hYyBj that_0 = this;
            this.__cache_U14jUiVqjzoLhR3Cnu355R = null;
            this.__cache_RsRnu9h2g59LEH3VgogPcX = null;
            return that_0;
        }

        public n3.Replace_F5NEdQWxM1sMWC1M7hYyBj __CreateDefault__()
        {
            n3.Replace_F5NEdQWxM1sMWC1M7hYyBj that_0 = this;
            this.__cache_U14jUiVqjzoLhR3Cnu355R = null;
            this.__cache_RsRnu9h2g59LEH3VgogPcX = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_U14jUiVqjzoLhR3Cnu355R);
            n1.CompilationHelper.SafeDispose(this.__cache_RsRnu9h2g59LEH3VgogPcX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117589U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "U14jUiVqjzoLhR3Cnu355R", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_U14jUiVqjzoLhR3Cnu355R = null;
        [n1.ElementAttribute(TracingId = 117656U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "RsRnu9h2g59LEH3VgogPcX", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.Regex, string, string>, n2.ValueTuple<string>> __cache_RsRnu9h2g59LEH3VgogPcX = null;
        public Replace_F5NEdQWxM1sMWC1M7hYyBj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Replace_F5NEdQWxM1sMWC1M7hYyBj(Replace_F5NEdQWxM1sMWC1M7hYyBj other): base(other)
        {
            this.__cache_U14jUiVqjzoLhR3Cnu355R = other.__cache_U14jUiVqjzoLhR3Cnu355R;
            this.__cache_RsRnu9h2g59LEH3VgogPcX = other.__cache_RsRnu9h2g59LEH3VgogPcX;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_U14jUiVqjzoLhR3Cnu355R", in __cache_U14jUiVqjzoLhR3Cnu355R), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RsRnu9h2g59LEH3VgogPcX", in __cache_RsRnu9h2g59LEH3VgogPcX));
        }

        internal Replace_F5NEdQWxM1sMWC1M7hYyBj __WITH__(n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_U14jUiVqjzoLhR3Cnu355R, n6.Manager<n2.ValueTuple<n5.Regex, string, string>, n2.ValueTuple<string>> __cache_RsRnu9h2g59LEH3VgogPcX)
        {
            n3.Replace_F5NEdQWxM1sMWC1M7hYyBj that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_U14jUiVqjzoLhR3Cnu355R != this.__cache_U14jUiVqjzoLhR3Cnu355R || __cache_RsRnu9h2g59LEH3VgogPcX != this.__cache_RsRnu9h2g59LEH3VgogPcX ? new Replace_F5NEdQWxM1sMWC1M7hYyBj(this)
                {__cache_U14jUiVqjzoLhR3Cnu355R = __cache_U14jUiVqjzoLhR3Cnu355R, __cache_RsRnu9h2g59LEH3VgogPcX = __cache_RsRnu9h2g59LEH3VgogPcX} : that_0;
            else
            {
                this.__cache_U14jUiVqjzoLhR3Cnu355R = __cache_U14jUiVqjzoLhR3Cnu355R;
                this.__cache_RsRnu9h2g59LEH3VgogPcX = __cache_RsRnu9h2g59LEH3VgogPcX;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 117835U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "NkW4XSRiiqZLVwUsqFQNTW", Name = "Split_NkW4XSRiiqZLVwUsqFQNTW")]
    [n2.SerializableAttribute]
    public class Split_NkW4XSRiiqZLVwUsqFQNTW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Split_NkW4XSRiiqZLVwUsqFQNTW Create(n1.NodeContext Node_Context)
        {
            var instance = new Split_NkW4XSRiiqZLVwUsqFQNTW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Split_NkW4XSRiiqZLVwUsqFQNTW CreateDefault()
        {
            var instance = new Split_NkW4XSRiiqZLVwUsqFQNTW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Split_NkW4XSRiiqZLVwUsqFQNTW Update(string Input_In, string Pattern_In, [n4.SerializedDefaultValueAttribute("Compiled", false)] n5.RegexOptions Options_In, out n10.Spread<string> Result_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_CDO64VnHXeQNEHe9KCRHOr;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>>(n2.ValueTuple.Create(default(n5.Regex)));
            }

            var inputs_3 = (Pattern_In, Options_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_7 = new n5.Regex(pattern: Pattern_In, options: Options_In);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            bool Force_9 = false;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_SOaqhdLR9GbOVzqLSXGLba;
            if (manager_11 is null)
            {
                manager_11 = new n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>>>(n2.ValueTuple.Create(n11._Operations_.CreateDefault<string>()));
            }

            var inputs_12 = (__auto_8, Input_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Force_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                n7.ObjectHelpers.IsAssigned(x: __auto_8, result: out bool Result_16, notAssigned: out bool Not_Assigned_17);
                n10.Spread<string> __auto_18;
                if (Result_16)
                {
                    var Result_20 = __auto_8.Split(input: Input_In);
                    n9.IEnumerable<string> Input_21 = (n9.IEnumerable<string>)Result_20;
                    n11._Operations_.FromSequence<string>(Input_In: Input_21, Result_Out: out n10.Spread<string> Result_22);
                    __auto_18 = Result_22;
                }
                else
                {
                    __auto_18 = n11._Operations_.CreateDefault<string>();
                }

                outputs_13 = n2.ValueTuple.Create(__auto_18);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, default, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var __auto_23 = outputs_13.Item1;
            Result_Out = __auto_23;
            n3.Split_NkW4XSRiiqZLVwUsqFQNTW that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = manager_2 != this.__cache_CDO64VnHXeQNEHe9KCRHOr || manager_11 != this.__cache_SOaqhdLR9GbOVzqLSXGLba ? new Split_NkW4XSRiiqZLVwUsqFQNTW(this)
                {__cache_CDO64VnHXeQNEHe9KCRHOr = manager_2, __cache_SOaqhdLR9GbOVzqLSXGLba = manager_11} : that_24;
            else
            {
                this.__cache_CDO64VnHXeQNEHe9KCRHOr = manager_2;
                this.__cache_SOaqhdLR9GbOVzqLSXGLba = manager_11;
            }

            return that_24;
        }

        public n3.Split_NkW4XSRiiqZLVwUsqFQNTW __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Split_NkW4XSRiiqZLVwUsqFQNTW that_0 = this;
            this.__cache_CDO64VnHXeQNEHe9KCRHOr = null;
            this.__cache_SOaqhdLR9GbOVzqLSXGLba = null;
            return that_0;
        }

        public n3.Split_NkW4XSRiiqZLVwUsqFQNTW __CreateDefault__()
        {
            n3.Split_NkW4XSRiiqZLVwUsqFQNTW that_0 = this;
            this.__cache_CDO64VnHXeQNEHe9KCRHOr = null;
            this.__cache_SOaqhdLR9GbOVzqLSXGLba = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CDO64VnHXeQNEHe9KCRHOr);
            n1.CompilationHelper.SafeDispose(this.__cache_SOaqhdLR9GbOVzqLSXGLba);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 117839U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "CDO64VnHXeQNEHe9KCRHOr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_CDO64VnHXeQNEHe9KCRHOr = null;
        [n1.ElementAttribute(TracingId = 117874U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "SOaqhdLR9GbOVzqLSXGLba", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>>> __cache_SOaqhdLR9GbOVzqLSXGLba = null;
        public Split_NkW4XSRiiqZLVwUsqFQNTW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Split_NkW4XSRiiqZLVwUsqFQNTW(Split_NkW4XSRiiqZLVwUsqFQNTW other): base(other)
        {
            this.__cache_CDO64VnHXeQNEHe9KCRHOr = other.__cache_CDO64VnHXeQNEHe9KCRHOr;
            this.__cache_SOaqhdLR9GbOVzqLSXGLba = other.__cache_SOaqhdLR9GbOVzqLSXGLba;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CDO64VnHXeQNEHe9KCRHOr", in __cache_CDO64VnHXeQNEHe9KCRHOr), n1.CompilationHelper.GetValueOrExisting(values, "__cache_SOaqhdLR9GbOVzqLSXGLba", in __cache_SOaqhdLR9GbOVzqLSXGLba));
        }

        internal Split_NkW4XSRiiqZLVwUsqFQNTW __WITH__(n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_CDO64VnHXeQNEHe9KCRHOr, n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>>> __cache_SOaqhdLR9GbOVzqLSXGLba)
        {
            n3.Split_NkW4XSRiiqZLVwUsqFQNTW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CDO64VnHXeQNEHe9KCRHOr != this.__cache_CDO64VnHXeQNEHe9KCRHOr || __cache_SOaqhdLR9GbOVzqLSXGLba != this.__cache_SOaqhdLR9GbOVzqLSXGLba ? new Split_NkW4XSRiiqZLVwUsqFQNTW(this)
                {__cache_CDO64VnHXeQNEHe9KCRHOr = __cache_CDO64VnHXeQNEHe9KCRHOr, __cache_SOaqhdLR9GbOVzqLSXGLba = __cache_SOaqhdLR9GbOVzqLSXGLba} : that_0;
            else
            {
                this.__cache_CDO64VnHXeQNEHe9KCRHOr = __cache_CDO64VnHXeQNEHe9KCRHOr;
                this.__cache_SOaqhdLR9GbOVzqLSXGLba = __cache_SOaqhdLR9GbOVzqLSXGLba;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 118386U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "EWOwsOz68C1Mwnt5excx6S", Name = "Matches_EWOwsOz68C1Mwnt5excx6S")]
    [n2.SerializableAttribute]
    public class Matches_EWOwsOz68C1Mwnt5excx6S : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Matches_EWOwsOz68C1Mwnt5excx6S Create(n1.NodeContext Node_Context)
        {
            var instance = new Matches_EWOwsOz68C1Mwnt5excx6S(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Matches_EWOwsOz68C1Mwnt5excx6S CreateDefault()
        {
            var instance = new Matches_EWOwsOz68C1Mwnt5excx6S(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Matches_EWOwsOz68C1Mwnt5excx6S Update(string Input_In, string Pattern_In, [n4.SerializedDefaultValueAttribute("Compiled", false)] n5.RegexOptions Options_In, out n10.Spread<string> Result_Out, out n10.Spread<n10.Spread<string>> Result_Groups_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_J0nHhTg5jp5QF5rCpKFEam;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>>(n2.ValueTuple.Create(default(n5.Regex)));
            }

            var inputs_3 = (Pattern_In, Options_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_7 = new n5.Regex(pattern: Pattern_In, options: Options_In);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            bool Force_9 = false;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_VqmFbQvaXnhNDNRzDfxFgH;
            if (manager_11 is null)
            {
                manager_11 = new n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>, n10.Spread<n10.Spread<string>>>>((n11._Operations_.CreateDefault<string>(), n11._Operations_.CreateDefault<n10.Spread<string>>()));
            }

            var inputs_12 = (__auto_8, Input_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Force_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__FoK3B1N3v3FLBCZI2vhm9R>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __FoK3B1N3v3FLBCZI2vhm9R(__GetContext__(), n1.VLObject.NewIdentity());
                }

                n7.ObjectHelpers.IsAssigned(x: __auto_8, result: out bool Result_16, notAssigned: out bool Not_Assigned_17);
                n10.Spread<string> __auto_18;
                n10.Spread<n10.Spread<string>> __auto_19;
                var state_20 = n1.CompilationHelper.Restore<__HKxq5O2oO7jQMMbq2ozF0b>(state_15.__if_URaFO5Gl8yeOtKaI3uWdKF, __GetContext__());
                if (Result_16)
                {
                    if (state_20 == null)
                    {
                        state_20 = new __HKxq5O2oO7jQMMbq2ozF0b(__GetContext__(), n1.VLObject.NewIdentity())
                        {__cp_NVlcT2aTwjHLL2BeZUn57J = n11._Operations_.CreateDefault<string>(), __cp_Glqv2NgNEiCO49CfQPsRIu = n11._Operations_.CreateDefault<n10.Spread<string>>()};
                    }

                    var Result_21 = __auto_8.Matches(input: Input_In);
                    var Count_22 = Result_21.Count;
                    var manager_42 = state_20.__loop_J6mVhFbgvTmPIBS0sMaEGG ?? new n12.ImmutableLifetimeManager();
                    var iterator_43 = manager_42.GetIterator(__GetContext__());
                    var builder_44 = n4.CollectionBuilders.GetBuilder(state_20.__cp_NVlcT2aTwjHLL2BeZUn57J, 16);
                    n10.Spread<string> output_45;
                    var builder_46 = n4.CollectionBuilders.GetBuilder(state_20.__cp_Glqv2NgNEiCO49CfQPsRIu, 16);
                    n10.Spread<n10.Spread<string>> output_47;
                    try
                    {
                        for (var i_23 = 0; i_23 < Count_22; i_23++)
                        {
                            var i_local_24 = i_23;
                            __NfTOSoOp5y1MWzqYObVhaU state_25;
                            if (!iterator_43.MoveNext(out state_25))
                            {
                                iterator_43.Add(state_25 = new __NfTOSoOp5y1MWzqYObVhaU(__GetContext__(), n1.VLObject.NewIdentity())
                                {__cp_FGgl7UtNMg0NGIeMLEqel1 = n11._Operations_.CreateDefault<string>()});
                            }

                            int __pad_DufkOIz5zO2NvNTL01sCE3_26 = __slot_DufkOIz5zO2NvNTL01sCE3;
                            var Item_27 = Result_21[i_local_24];
                            var Groups_28 = Item_27.Groups;
                            var Count_29 = Groups_28.Count;
                            var Output_30 = Count_29 - __pad_DufkOIz5zO2NvNTL01sCE3_26;
                            var builder_37 = n4.CollectionBuilders.GetBuilder(state_25.__cp_FGgl7UtNMg0NGIeMLEqel1, 16);
                            n10.Spread<string> output_38;
                            try
                            {
                                for (var i_31 = 0; i_31 < Output_30; i_31++)
                                {
                                    var i_local_32 = i_31;
                                    var Output_34 = i_local_32 + __pad_DufkOIz5zO2NvNTL01sCE3_26;
                                    var Item_35 = Groups_28[Output_34];
                                    var Value_36 = Item_35.Value;
                                    builder_37.Add(Value_36);
                                }
                            }
                            finally
                            {
                                output_38 = builder_37.Commit();
                            }

                            int Groupnum_39 = 0;
                            var Item_40 = Groups_28[Groupnum_39];
                            var Value_41 = Item_40.Value;
                            if (state_25.__GetContext__().IsImmutable)
                                state_25 = output_38 != state_25.__cp_FGgl7UtNMg0NGIeMLEqel1 ? new __NfTOSoOp5y1MWzqYObVhaU(state_25)
                                {__cp_FGgl7UtNMg0NGIeMLEqel1 = output_38} : state_25;
                            else
                            {
                                state_25.__cp_FGgl7UtNMg0NGIeMLEqel1 = output_38;
                            }

                            iterator_43.Update(state_25);
                            builder_44.Add(Value_41);
                            builder_46.Add(output_38);
                        }
                    }
                    finally
                    {
                        manager_42 = iterator_43.Commit();
                        output_45 = builder_44.Commit();
                        output_47 = builder_46.Commit();
                    }

                    __auto_18 = output_45;
                    __auto_19 = output_47;
                    if (state_20.__GetContext__().IsImmutable)
                        state_20 = manager_42 != state_20.__loop_J6mVhFbgvTmPIBS0sMaEGG || output_45 != state_20.__cp_NVlcT2aTwjHLL2BeZUn57J || output_47 != state_20.__cp_Glqv2NgNEiCO49CfQPsRIu ? new __HKxq5O2oO7jQMMbq2ozF0b(state_20)
                        {__loop_J6mVhFbgvTmPIBS0sMaEGG = manager_42, __cp_NVlcT2aTwjHLL2BeZUn57J = output_45, __cp_Glqv2NgNEiCO49CfQPsRIu = output_47} : state_20;
                    else
                    {
                        state_20.__loop_J6mVhFbgvTmPIBS0sMaEGG = manager_42;
                        state_20.__cp_NVlcT2aTwjHLL2BeZUn57J = output_45;
                        state_20.__cp_Glqv2NgNEiCO49CfQPsRIu = output_47;
                    }
                }
                else
                {
                    __auto_18 = n11._Operations_.CreateDefault<string>();
                    __auto_19 = n11._Operations_.CreateDefault<n10.Spread<string>>();
                }

                if (state_15.__GetContext__().IsImmutable)
                    state_15 = state_20 != state_15.__if_URaFO5Gl8yeOtKaI3uWdKF ? new __FoK3B1N3v3FLBCZI2vhm9R(state_15)
                    {__if_URaFO5Gl8yeOtKaI3uWdKF = state_20} : state_15;
                else
                {
                    state_15.__if_URaFO5Gl8yeOtKaI3uWdKF = state_20;
                }

                outputs_13 = (__auto_18, __auto_19);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_48, __auto_49) = outputs_13;
            Result_Out = __auto_48;
            Result_Groups_Out = __auto_49;
            n3.Matches_EWOwsOz68C1Mwnt5excx6S that_50 = this;
            if (this.__GetContext__().IsImmutable)
                that_50 = manager_2 != this.__cache_J0nHhTg5jp5QF5rCpKFEam || manager_11 != this.__cache_VqmFbQvaXnhNDNRzDfxFgH ? new Matches_EWOwsOz68C1Mwnt5excx6S(this)
                {__cache_J0nHhTg5jp5QF5rCpKFEam = manager_2, __cache_VqmFbQvaXnhNDNRzDfxFgH = manager_11} : that_50;
            else
            {
                this.__cache_J0nHhTg5jp5QF5rCpKFEam = manager_2;
                this.__cache_VqmFbQvaXnhNDNRzDfxFgH = manager_11;
            }

            return that_50;
        }

        public n3.Matches_EWOwsOz68C1Mwnt5excx6S __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Matches_EWOwsOz68C1Mwnt5excx6S that_0 = this;
            this.__cache_J0nHhTg5jp5QF5rCpKFEam = null;
            this.__cache_VqmFbQvaXnhNDNRzDfxFgH = null;
            return that_0;
        }

        public n3.Matches_EWOwsOz68C1Mwnt5excx6S __CreateDefault__()
        {
            n3.Matches_EWOwsOz68C1Mwnt5excx6S that_0 = this;
            this.__cache_J0nHhTg5jp5QF5rCpKFEam = null;
            this.__cache_VqmFbQvaXnhNDNRzDfxFgH = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_J0nHhTg5jp5QF5rCpKFEam);
            n1.CompilationHelper.SafeDispose(this.__cache_VqmFbQvaXnhNDNRzDfxFgH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 118393U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "J0nHhTg5jp5QF5rCpKFEam", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_J0nHhTg5jp5QF5rCpKFEam = null;
        [n1.ElementAttribute(TracingId = 122367U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "VqmFbQvaXnhNDNRzDfxFgH", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>, n10.Spread<n10.Spread<string>>>> __cache_VqmFbQvaXnhNDNRzDfxFgH = null;
        [n1.ElementAttribute(TracingId = 122513U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "DufkOIz5zO2NvNTL01sCE3", Name = "__slot_DufkOIz5zO2NvNTL01sCE3")]
        public static int __slot_DufkOIz5zO2NvNTL01sCE3 = 1;
        static Matches_EWOwsOz68C1Mwnt5excx6S()
        {
        }

        public Matches_EWOwsOz68C1Mwnt5excx6S(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Matches_EWOwsOz68C1Mwnt5excx6S(Matches_EWOwsOz68C1Mwnt5excx6S other): base(other)
        {
            this.__cache_J0nHhTg5jp5QF5rCpKFEam = other.__cache_J0nHhTg5jp5QF5rCpKFEam;
            this.__cache_VqmFbQvaXnhNDNRzDfxFgH = other.__cache_VqmFbQvaXnhNDNRzDfxFgH;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_J0nHhTg5jp5QF5rCpKFEam", in __cache_J0nHhTg5jp5QF5rCpKFEam), n1.CompilationHelper.GetValueOrExisting(values, "__cache_VqmFbQvaXnhNDNRzDfxFgH", in __cache_VqmFbQvaXnhNDNRzDfxFgH));
        }

        internal Matches_EWOwsOz68C1Mwnt5excx6S __WITH__(n6.Manager<n2.ValueTuple<string, n5.RegexOptions>, n2.ValueTuple<n5.Regex>> __cache_J0nHhTg5jp5QF5rCpKFEam, n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<n10.Spread<string>, n10.Spread<n10.Spread<string>>>> __cache_VqmFbQvaXnhNDNRzDfxFgH)
        {
            n3.Matches_EWOwsOz68C1Mwnt5excx6S that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_J0nHhTg5jp5QF5rCpKFEam != this.__cache_J0nHhTg5jp5QF5rCpKFEam || __cache_VqmFbQvaXnhNDNRzDfxFgH != this.__cache_VqmFbQvaXnhNDNRzDfxFgH ? new Matches_EWOwsOz68C1Mwnt5excx6S(this)
                {__cache_J0nHhTg5jp5QF5rCpKFEam = __cache_J0nHhTg5jp5QF5rCpKFEam, __cache_VqmFbQvaXnhNDNRzDfxFgH = __cache_VqmFbQvaXnhNDNRzDfxFgH} : that_0;
            else
            {
                this.__cache_J0nHhTg5jp5QF5rCpKFEam = __cache_J0nHhTg5jp5QF5rCpKFEam;
                this.__cache_VqmFbQvaXnhNDNRzDfxFgH = __cache_VqmFbQvaXnhNDNRzDfxFgH;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "FoK3B1N3v3FLBCZI2vhm9R", Name = "__FoK3B1N3v3FLBCZI2vhm9R")]
        [n2.SerializableAttribute]
        public class __FoK3B1N3v3FLBCZI2vhm9R : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_URaFO5Gl8yeOtKaI3uWdKF);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_URaFO5Gl8yeOtKaI3uWdKF;
            public __FoK3B1N3v3FLBCZI2vhm9R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FoK3B1N3v3FLBCZI2vhm9R(__FoK3B1N3v3FLBCZI2vhm9R other): base(other)
            {
                this.__if_URaFO5Gl8yeOtKaI3uWdKF = other.__if_URaFO5Gl8yeOtKaI3uWdKF;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_URaFO5Gl8yeOtKaI3uWdKF", in __if_URaFO5Gl8yeOtKaI3uWdKF));
            }

            internal __FoK3B1N3v3FLBCZI2vhm9R __WITH__(n2.Object __if_URaFO5Gl8yeOtKaI3uWdKF)
            {
                __FoK3B1N3v3FLBCZI2vhm9R that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_URaFO5Gl8yeOtKaI3uWdKF != this.__if_URaFO5Gl8yeOtKaI3uWdKF ? new __FoK3B1N3v3FLBCZI2vhm9R(this)
                    {__if_URaFO5Gl8yeOtKaI3uWdKF = __if_URaFO5Gl8yeOtKaI3uWdKF} : that_0;
                else
                {
                    this.__if_URaFO5Gl8yeOtKaI3uWdKF = __if_URaFO5Gl8yeOtKaI3uWdKF;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "HKxq5O2oO7jQMMbq2ozF0b", Name = "__HKxq5O2oO7jQMMbq2ozF0b")]
        [n2.SerializableAttribute]
        public class __HKxq5O2oO7jQMMbq2ozF0b : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_J6mVhFbgvTmPIBS0sMaEGG);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n12.ImmutableLifetimeManager __loop_J6mVhFbgvTmPIBS0sMaEGG;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<string> __cp_NVlcT2aTwjHLL2BeZUn57J;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n10.Spread<string>> __cp_Glqv2NgNEiCO49CfQPsRIu;
            public __HKxq5O2oO7jQMMbq2ozF0b(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HKxq5O2oO7jQMMbq2ozF0b(__HKxq5O2oO7jQMMbq2ozF0b other): base(other)
            {
                this.__loop_J6mVhFbgvTmPIBS0sMaEGG = other.__loop_J6mVhFbgvTmPIBS0sMaEGG;
                this.__cp_NVlcT2aTwjHLL2BeZUn57J = other.__cp_NVlcT2aTwjHLL2BeZUn57J;
                this.__cp_Glqv2NgNEiCO49CfQPsRIu = other.__cp_Glqv2NgNEiCO49CfQPsRIu;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_J6mVhFbgvTmPIBS0sMaEGG", in __loop_J6mVhFbgvTmPIBS0sMaEGG), n1.CompilationHelper.GetValueOrExisting(values, "__cp_NVlcT2aTwjHLL2BeZUn57J", in __cp_NVlcT2aTwjHLL2BeZUn57J), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Glqv2NgNEiCO49CfQPsRIu", in __cp_Glqv2NgNEiCO49CfQPsRIu));
            }

            internal __HKxq5O2oO7jQMMbq2ozF0b __WITH__(n12.ImmutableLifetimeManager __loop_J6mVhFbgvTmPIBS0sMaEGG, n10.Spread<string> __cp_NVlcT2aTwjHLL2BeZUn57J, n10.Spread<n10.Spread<string>> __cp_Glqv2NgNEiCO49CfQPsRIu)
            {
                __HKxq5O2oO7jQMMbq2ozF0b that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_J6mVhFbgvTmPIBS0sMaEGG != this.__loop_J6mVhFbgvTmPIBS0sMaEGG || __cp_NVlcT2aTwjHLL2BeZUn57J != this.__cp_NVlcT2aTwjHLL2BeZUn57J || __cp_Glqv2NgNEiCO49CfQPsRIu != this.__cp_Glqv2NgNEiCO49CfQPsRIu ? new __HKxq5O2oO7jQMMbq2ozF0b(this)
                    {__loop_J6mVhFbgvTmPIBS0sMaEGG = __loop_J6mVhFbgvTmPIBS0sMaEGG, __cp_NVlcT2aTwjHLL2BeZUn57J = __cp_NVlcT2aTwjHLL2BeZUn57J, __cp_Glqv2NgNEiCO49CfQPsRIu = __cp_Glqv2NgNEiCO49CfQPsRIu} : that_0;
                else
                {
                    this.__loop_J6mVhFbgvTmPIBS0sMaEGG = __loop_J6mVhFbgvTmPIBS0sMaEGG;
                    this.__cp_NVlcT2aTwjHLL2BeZUn57J = __cp_NVlcT2aTwjHLL2BeZUn57J;
                    this.__cp_Glqv2NgNEiCO49CfQPsRIu = __cp_Glqv2NgNEiCO49CfQPsRIu;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "NfTOSoOp5y1MWzqYObVhaU", Name = "__NfTOSoOp5y1MWzqYObVhaU")]
        [n2.SerializableAttribute]
        public class __NfTOSoOp5y1MWzqYObVhaU : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<string> __cp_FGgl7UtNMg0NGIeMLEqel1;
            public __NfTOSoOp5y1MWzqYObVhaU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NfTOSoOp5y1MWzqYObVhaU(__NfTOSoOp5y1MWzqYObVhaU other): base(other)
            {
                this.__cp_FGgl7UtNMg0NGIeMLEqel1 = other.__cp_FGgl7UtNMg0NGIeMLEqel1;
            }

            protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_FGgl7UtNMg0NGIeMLEqel1", in __cp_FGgl7UtNMg0NGIeMLEqel1));
            }

            internal __NfTOSoOp5y1MWzqYObVhaU __WITH__(n10.Spread<string> __cp_FGgl7UtNMg0NGIeMLEqel1)
            {
                __NfTOSoOp5y1MWzqYObVhaU that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_FGgl7UtNMg0NGIeMLEqel1 != this.__cp_FGgl7UtNMg0NGIeMLEqel1 ? new __NfTOSoOp5y1MWzqYObVhaU(this)
                    {__cp_FGgl7UtNMg0NGIeMLEqel1 = __cp_FGgl7UtNMg0NGIeMLEqel1} : that_0;
                else
                {
                    this.__cp_FGgl7UtNMg0NGIeMLEqel1 = __cp_FGgl7UtNMg0NGIeMLEqel1;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 131472U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "VLBfcL2fMjXLFtW0rDJYRo", Name = "IsEmail_VLBfcL2fMjXLFtW0rDJYRo")]
    [n2.SerializableAttribute]
    public class IsEmail_VLBfcL2fMjXLFtW0rDJYRo : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo Create(n1.NodeContext Node_Context)
        {
            var instance = new IsEmail_VLBfcL2fMjXLFtW0rDJYRo(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo CreateDefault()
        {
            var instance = new IsEmail_VLBfcL2fMjXLFtW0rDJYRo(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo Update(string Input_In, out bool Result_Out)
        {
            n5.RegexOptions __pad_TLKq7rxPQVBLVWwbDV89Vz_0 = __slot_TLKq7rxPQVBLVWwbDV89Vz;
            n5.RegexOptions __pad_QysWKyPSYeFN79qoGLwCzd_1 = __slot_QysWKyPSYeFN79qoGLwCzd;
            n5.RegexOptions __pad_BC31CkD1rnjNznDihPZIZD_2 = __slot_BC31CkD1rnjNznDihPZIZD;
            string __auto_3 = this.Expression;
            var Output_4 = __pad_TLKq7rxPQVBLVWwbDV89Vz_0 | __pad_QysWKyPSYeFN79qoGLwCzd_1;
            Output_4 = Output_4 | __pad_BC31CkD1rnjNznDihPZIZD_2;
            var Output_6 = this.__p_RGmqrzS6x07NtKxVZSO29K.Update(Input_In: Input_In, Pattern_In: __auto_3, Options_In: Output_4, Result_Out: out bool Result_5);
            Result_Out = Result_5;
            n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_6 != this.__p_RGmqrzS6x07NtKxVZSO29K ? new IsEmail_VLBfcL2fMjXLFtW0rDJYRo(this)
                {__p_RGmqrzS6x07NtKxVZSO29K = Output_6} : that_7;
            else
            {
                this.__p_RGmqrzS6x07NtKxVZSO29K = Output_6;
            }

            return that_7;
        }

        public n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_FnjtC339tHzMv8YrOUTOX3_0 = __slot_FnjtC339tHzMv8YrOUTOX3;
            string __pad_FX1pWN95O0VP9lgIkiQAUe_1 = __slot_FX1pWN95O0VP9lgIkiQAUe;
            string __pad_Piv6KFNfHSaPnJB9f0eHpk_2 = __slot_Piv6KFNfHSaPnJB9f0eHpk;
            string __pad_RsoOT7nQd3sPS0erPxsuCY_3 = __slot_RsoOT7nQd3sPS0erPxsuCY;
            string __pad_PqKhdwNrKHvPCR32SV2SnV_4 = __slot_PqKhdwNrKHvPCR32SV2SnV;
            string __pad_CkC403OQ4H7PjCmSUPg5sK_5 = __slot_CkC403OQ4H7PjCmSUPg5sK;
            string __pad_LxZmlESAQNBNZhSoWRN1AO_6 = __slot_LxZmlESAQNBNZhSoWRN1AO;
            string __pad_SSYbewlKII3QAMr0BRxHTP_7 = __slot_SSYbewlKII3QAMr0BRxHTP;
            string __pad_CjCnSglfsh7PEs5q6Vylee_8 = __slot_CjCnSglfsh7PEs5q6Vylee;
            var Output_9 = n5.Regex.Escape(str: __pad_FnjtC339tHzMv8YrOUTOX3_0);
            string Input_10 = "(?!";
            string Input_3_11 = ")";
            var Output_12 = n13.StringExtensions.Plus(input: Input_10, input2: Output_9);
            var Output_13 = n13.StringExtensions.Plus(input: Output_12, input2: Input_3_11);
            var Output_14 = n13.StringExtensions.Plus(input: Output_9, input2: Output_13);
            string Input_15 = "(";
            string Input_3_16 = ")";
            var Output_17 = n13.StringExtensions.Plus(input: Input_15, input2: Output_14);
            var Output_18 = n13.StringExtensions.Plus(input: Output_17, input2: Input_3_16);
            var Output_19 = n5.Regex.Escape(str: __pad_FX1pWN95O0VP9lgIkiQAUe_1);
            n14._Operations_.AnyWordChar(Output_Out: out string Output_20);
            var Output_21 = n13.StringExtensions.Plus(input: Output_19, input2: Output_20);
            string Input_22 = "[";
            string Input_3_23 = "]";
            var Output_24 = n13.StringExtensions.Plus(input: Input_22, input2: Output_21);
            var Output_25 = n13.StringExtensions.Plus(input: Output_24, input2: Input_3_23);
            var builder_26 = n4.CollectionBuilders.GetBuilder(n11._Operations_.CreateDefault<string>(), 2);
            builder_26.Add(Output_18);
            builder_26.Add(Output_25);
            var __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H_27 = builder_26.Commit();
            n15._Operations_.OR_RegExpr(Input_In: __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H_27, Output_Out: out string Output_28);
            string Input_2_29 = "*";
            var Output_30 = n13.StringExtensions.Plus(input: Output_28, input2: Input_2_29);
            string Input_31 = "0";
            string Input_2_32 = "9";
            string Input_33 = "";
            string Input_3_34 = "-";
            string Input_5_35 = "";
            var Output_36 = n13.StringExtensions.Plus(input: Input_33, input2: Input_31);
            var Output_37 = n13.StringExtensions.Plus(input: Output_36, input2: Input_3_34);
            var Output_38 = n13.StringExtensions.Plus(input: Output_37, input2: Input_2_32);
            var Output_39 = n13.StringExtensions.Plus(input: Output_38, input2: Input_5_35);
            string Input_40 = "a";
            string Input_2_41 = "z";
            string Input_42 = "";
            string Input_3_43 = "-";
            string Input_5_44 = "";
            var Output_45 = n13.StringExtensions.Plus(input: Input_42, input2: Input_40);
            var Output_46 = n13.StringExtensions.Plus(input: Output_45, input2: Input_3_43);
            var Output_47 = n13.StringExtensions.Plus(input: Output_46, input2: Input_2_41);
            var Output_48 = n13.StringExtensions.Plus(input: Output_47, input2: Input_5_44);
            var Output_49 = n13.StringExtensions.Plus(input: Output_39, input2: Output_48);
            string Input_50 = "[";
            string Input_3_51 = "]";
            var Output_52 = n13.StringExtensions.Plus(input: Input_50, input2: Output_49);
            var Output_53 = n13.StringExtensions.Plus(input: Output_52, input2: Input_3_51);
            var Output_54 = n13.StringExtensions.Plus(input: Output_53, input2: Output_30);
            string Input_55 = "(?<=";
            string Input_3_56 = ")";
            var Output_57 = n13.StringExtensions.Plus(input: Input_55, input2: Output_53);
            var Output_58 = n13.StringExtensions.Plus(input: Output_57, input2: Input_3_56);
            var Output_59 = n13.StringExtensions.Plus(input: Output_58, input2: __pad_Piv6KFNfHSaPnJB9f0eHpk_2);
            string Input_60 = "(";
            string Input_3_61 = ")";
            var Output_62 = n13.StringExtensions.Plus(input: Input_60, input2: Output_54);
            var Output_63 = n13.StringExtensions.Plus(input: Output_62, input2: Input_3_61);
            var Output_64 = n13.StringExtensions.Plus(input: Output_63, input2: Output_59);
            string Input_65 = "(";
            string Input_3_66 = ")";
            var Output_67 = n13.StringExtensions.Plus(input: Input_65, input2: Output_64);
            var Output_68 = n13.StringExtensions.Plus(input: Output_67, input2: Input_3_66);
            n14._Operations_.AnyChar(Output_Out: out string Output_69);
            string Input_2_70 = "+?";
            var Output_71 = n13.StringExtensions.Plus(input: Output_69, input2: Input_2_70);
            n16._Operations_.BackSlash(Output_Out: out string Output_72);
            string Input_73 = "(?<!";
            string Input_3_74 = ")";
            var Output_75 = n13.StringExtensions.Plus(input: Input_73, input2: Output_72);
            var Output_76 = n13.StringExtensions.Plus(input: Output_75, input2: Input_3_74);
            var Output_77 = n13.StringExtensions.Plus(input: Output_76, input2: __pad_PqKhdwNrKHvPCR32SV2SnV_4);
            var Output_78 = n13.StringExtensions.Plus(input: __pad_RsoOT7nQd3sPS0erPxsuCY_3, input2: Output_71);
            var Output_79 = n13.StringExtensions.Plus(input: Output_78, input2: Output_77);
            string Input_80 = "(";
            string Input_3_81 = ")";
            var Output_82 = n13.StringExtensions.Plus(input: Input_80, input2: Output_79);
            var Output_83 = n13.StringExtensions.Plus(input: Output_82, input2: Input_3_81);
            string Input_84 = "(?(";
            string Input_3_85 = ")";
            string Input_5_86 = "|";
            string Input_7_87 = ")";
            var Output_88 = n13.StringExtensions.Plus(input: Input_84, input2: __pad_RsoOT7nQd3sPS0erPxsuCY_3);
            var Output_89 = n13.StringExtensions.Plus(input: Output_88, input2: Input_3_85);
            var Output_90 = n13.StringExtensions.Plus(input: Output_89, input2: Output_83);
            var Output_91 = n13.StringExtensions.Plus(input: Output_90, input2: Input_5_86);
            var Output_92 = n13.StringExtensions.Plus(input: Output_91, input2: Output_68);
            var Output_93 = n13.StringExtensions.Plus(input: Output_92, input2: Input_7_87);
            n17._Operations_.StringStarts(Output_Out: out string Output_94);
            var Output_95 = n5.Regex.Escape(str: __pad_CkC403OQ4H7PjCmSUPg5sK_5);
            n14._Operations_.AnyDigit(Output_Out: out string Output_96);
            int N_97 = 1;
            int M_98 = 3;
            n18._Operations_.NToMTimes(Input_In: Output_96, N_In: N_97, M_In: M_98, Output_Out: out string Output_99);
            var Output_100 = n5.Regex.Escape(str: __pad_LxZmlESAQNBNZhSoWRN1AO_6);
            var Output_101 = n13.StringExtensions.Plus(input: Output_99, input2: Output_100);
            string Input_102 = "(";
            string Input_3_103 = ")";
            var Output_104 = n13.StringExtensions.Plus(input: Input_102, input2: Output_101);
            var Output_105 = n13.StringExtensions.Plus(input: Output_104, input2: Input_3_103);
            int N_106 = 3;
            n18._Operations_.ExactlyNTimes(Input_In: Output_105, N_In: N_106, Output_Out: out string Output_107);
            var Output_108 = n5.Regex.Escape(str: __pad_SSYbewlKII3QAMr0BRxHTP_7);
            var Output_109 = n13.StringExtensions.Plus(input: Output_95, input2: Output_107);
            var Output_110 = n13.StringExtensions.Plus(input: Output_109, input2: Output_99);
            var Output_111 = n13.StringExtensions.Plus(input: Output_110, input2: Output_108);
            string Input_112 = "(";
            string Input_3_113 = ")";
            var Output_114 = n13.StringExtensions.Plus(input: Input_112, input2: Output_111);
            var Output_115 = n13.StringExtensions.Plus(input: Output_114, input2: Input_3_113);
            string Input_116 = "0";
            string Input_2_117 = "9";
            string Input_118 = "";
            string Input_3_119 = "-";
            string Input_5_120 = "";
            var Output_121 = n13.StringExtensions.Plus(input: Input_118, input2: Input_116);
            var Output_122 = n13.StringExtensions.Plus(input: Output_121, input2: Input_3_119);
            var Output_123 = n13.StringExtensions.Plus(input: Output_122, input2: Input_2_117);
            var Output_124 = n13.StringExtensions.Plus(input: Output_123, input2: Input_5_120);
            string Input_125 = "a";
            string Input_2_126 = "z";
            string Input_127 = "";
            string Input_3_128 = "-";
            string Input_5_129 = "";
            var Output_130 = n13.StringExtensions.Plus(input: Input_127, input2: Input_125);
            var Output_131 = n13.StringExtensions.Plus(input: Output_130, input2: Input_3_128);
            var Output_132 = n13.StringExtensions.Plus(input: Output_131, input2: Input_2_126);
            var Output_133 = n13.StringExtensions.Plus(input: Output_132, input2: Input_5_129);
            var Output_134 = n13.StringExtensions.Plus(input: Output_124, input2: Output_133);
            string Input_135 = "[";
            string Input_3_136 = "]";
            var Output_137 = n13.StringExtensions.Plus(input: Input_135, input2: Output_134);
            var Output_138 = n13.StringExtensions.Plus(input: Output_137, input2: Input_3_136);
            string Input_139 = "-";
            var Output_140 = n13.StringExtensions.Plus(input: Input_139, input2: Output_134);
            string Input_141 = "[";
            string Input_3_142 = "]";
            var Output_143 = n13.StringExtensions.Plus(input: Input_141, input2: Output_140);
            var Output_144 = n13.StringExtensions.Plus(input: Output_143, input2: Input_3_142);
            string Input_2_145 = "*";
            var Output_146 = n13.StringExtensions.Plus(input: Output_144, input2: Input_2_145);
            var Output_147 = n5.Regex.Escape(str: __pad_CjCnSglfsh7PEs5q6Vylee_8);
            var Output_148 = n13.StringExtensions.Plus(input: Output_138, input2: Output_146);
            var Output_149 = n13.StringExtensions.Plus(input: Output_148, input2: Output_138);
            var Output_150 = n13.StringExtensions.Plus(input: Output_149, input2: Output_147);
            string Input_151 = "(";
            string Input_3_152 = ")";
            var Output_153 = n13.StringExtensions.Plus(input: Input_151, input2: Output_150);
            var Output_154 = n13.StringExtensions.Plus(input: Output_153, input2: Input_3_152);
            string Input_2_155 = "+";
            var Output_156 = n13.StringExtensions.Plus(input: Output_154, input2: Input_2_155);
            int N_157 = 0;
            int M_158 = 22;
            n18._Operations_.NToMTimes(Input_In: Output_144, N_In: N_157, M_In: M_158, Output_Out: out string Output_159);
            var Output_160 = n13.StringExtensions.Plus(input: Output_138, input2: Output_159);
            var Output_161 = n13.StringExtensions.Plus(input: Output_160, input2: Output_138);
            var Output_162 = n13.StringExtensions.Plus(input: Output_156, input2: Output_161);
            string Input_163 = "(";
            string Input_3_164 = ")";
            var Output_165 = n13.StringExtensions.Plus(input: Input_163, input2: Output_162);
            var Output_166 = n13.StringExtensions.Plus(input: Output_165, input2: Input_3_164);
            string Input_167 = "(?(";
            string Input_3_168 = ")";
            string Input_5_169 = "|";
            string Input_7_170 = ")";
            var Output_171 = n13.StringExtensions.Plus(input: Input_167, input2: Output_95);
            var Output_172 = n13.StringExtensions.Plus(input: Output_171, input2: Input_3_168);
            var Output_173 = n13.StringExtensions.Plus(input: Output_172, input2: Output_115);
            var Output_174 = n13.StringExtensions.Plus(input: Output_173, input2: Input_5_169);
            var Output_175 = n13.StringExtensions.Plus(input: Output_174, input2: Output_166);
            var Output_176 = n13.StringExtensions.Plus(input: Output_175, input2: Input_7_170);
            n17._Operations_.StringEnds(Output_Out: out string Output_177);
            var Output_178 = n13.StringExtensions.Plus(input: Output_94, input2: Output_93);
            var Output_179 = n13.StringExtensions.Plus(input: Output_178, input2: Output_176);
            var Output_180 = n13.StringExtensions.Plus(input: Output_179, input2: Output_177);
            string __pad_VmTcE6UsOrNOAhsPLKceUa_181 = Output_115;
            string __auto_182 = Output_180;
            n1.NodeContext Node_Context_183 = Node_Context.CreateSubContext("BrdqoPCUQm5MjX4cJz5Rvf", "RGmqrzS6x07NtKxVZSO29K", 131478U);
            var Output_184 = n3.IsMatch_No3CCkpgB8zO94DQbGm6O4.Create(Node_Context: Node_Context_183);
            n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo that_185 = this;
            this.__slot_VmTcE6UsOrNOAhsPLKceUa = Output_115;
            this.Expression = Output_180;
            this.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H_27;
            this.__p_RGmqrzS6x07NtKxVZSO29K = Output_184;
            return that_185;
        }

        public n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo __CreateDefault__()
        {
            n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo that_0 = this;
            this.__slot_VmTcE6UsOrNOAhsPLKceUa = "";
            this.Expression = "";
            this.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = n11._Operations_.CreateDefault<string>();
            this.__p_RGmqrzS6x07NtKxVZSO29K = n3.IsMatch_No3CCkpgB8zO94DQbGm6O4.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RGmqrzS6x07NtKxVZSO29K);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 131489U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "TLKq7rxPQVBLVWwbDV89Vz", Name = "__slot_TLKq7rxPQVBLVWwbDV89Vz")]
        public static n5.RegexOptions __slot_TLKq7rxPQVBLVWwbDV89Vz = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Compiled", false, "BrdqoPCUQm5MjX4cJz5Rvf", "TLKq7rxPQVBLVWwbDV89Vz");
        [n1.ElementAttribute(TracingId = 131501U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "QysWKyPSYeFN79qoGLwCzd", Name = "__slot_QysWKyPSYeFN79qoGLwCzd")]
        public static n5.RegexOptions __slot_QysWKyPSYeFN79qoGLwCzd = n1.CompilationHelper.Deserialize<n5.RegexOptions>("IgnoreCase", false, "BrdqoPCUQm5MjX4cJz5Rvf", "QysWKyPSYeFN79qoGLwCzd");
        [n1.ElementAttribute(TracingId = 131504U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "BC31CkD1rnjNznDihPZIZD", Name = "__slot_BC31CkD1rnjNznDihPZIZD")]
        public static n5.RegexOptions __slot_BC31CkD1rnjNznDihPZIZD = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Singleline", false, "BrdqoPCUQm5MjX4cJz5Rvf", "BC31CkD1rnjNznDihPZIZD");
        [n1.ElementAttribute(TracingId = 131525U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "TCIgAf0BTCiLtdgaqRzrok", Name = "__slot_TCIgAf0BTCiLtdgaqRzrok")]
        public static string __slot_TCIgAf0BTCiLtdgaqRzrok = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`{}|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
        [n1.ElementAttribute(TracingId = 131542U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "RsoOT7nQd3sPS0erPxsuCY", Name = "__slot_RsoOT7nQd3sPS0erPxsuCY")]
        public static string __slot_RsoOT7nQd3sPS0erPxsuCY = "\"";
        [n1.ElementAttribute(TracingId = 136364U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "PqKhdwNrKHvPCR32SV2SnV", Name = "__slot_PqKhdwNrKHvPCR32SV2SnV")]
        public static string __slot_PqKhdwNrKHvPCR32SV2SnV = "\"@";
        [n1.ElementAttribute(TracingId = 136366U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "NXevPdoS11VNiybw5YJdXJ", Name = "__slot_NXevPdoS11VNiybw5YJdXJ")]
        public static string __slot_NXevPdoS11VNiybw5YJdXJ = "\"na me\"@";
        [n1.ElementAttribute(TracingId = 136473U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "FnjtC339tHzMv8YrOUTOX3", Name = "__slot_FnjtC339tHzMv8YrOUTOX3")]
        public static string __slot_FnjtC339tHzMv8YrOUTOX3 = ".";
        [n1.ElementAttribute(TracingId = 136479U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "FbLbrVb2xDiNGo7CihEOLt", Name = "__slot_FbLbrVb2xDiNGo7CihEOLt")]
        public static string __slot_FbLbrVb2xDiNGo7CihEOLt = "number or small letter";
        [n1.ElementAttribute(TracingId = 136546U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "Piv6KFNfHSaPnJB9f0eHpk", Name = "__slot_Piv6KFNfHSaPnJB9f0eHpk")]
        public static string __slot_Piv6KFNfHSaPnJB9f0eHpk = "@";
        [n1.ElementAttribute(TracingId = 136571U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "BDXKv4FyL4QPQbf90uMkPs", Name = "__slot_BDXKv4FyL4QPQbf90uMkPs")]
        public static string __slot_BDXKv4FyL4QPQbf90uMkPs = "\"my name\"@ \r\n  or \r\n2+2@";
        [n1.ElementAttribute(TracingId = 136610U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "CkC403OQ4H7PjCmSUPg5sK", Name = "__slot_CkC403OQ4H7PjCmSUPg5sK")]
        public static string __slot_CkC403OQ4H7PjCmSUPg5sK = "[";
        [n1.ElementAttribute(TracingId = 136636U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "SSYbewlKII3QAMr0BRxHTP", Name = "__slot_SSYbewlKII3QAMr0BRxHTP")]
        public static string __slot_SSYbewlKII3QAMr0BRxHTP = "]";
        [n1.ElementAttribute(TracingId = 136641U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "VmTcE6UsOrNOAhsPLKceUa", Name = "__slot_VmTcE6UsOrNOAhsPLKceUa")]
        public string __slot_VmTcE6UsOrNOAhsPLKceUa;
        [n1.ElementAttribute(TracingId = 139691U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "LxZmlESAQNBNZhSoWRN1AO", Name = "__slot_LxZmlESAQNBNZhSoWRN1AO")]
        public static string __slot_LxZmlESAQNBNZhSoWRN1AO = ".";
        [n1.ElementAttribute(TracingId = 139739U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "OBkVU9u5tbTMIouDsX9TFN", Name = "__slot_OBkVU9u5tbTMIouDsX9TFN")]
        public static string __slot_OBkVU9u5tbTMIouDsX9TFN = "IP: \r\n[3.222.31.1]";
        [n1.ElementAttribute(TracingId = 139752U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "ItZZKDukd3aPXTmpNwMNpS", Name = "__slot_ItZZKDukd3aPXTmpNwMNpS")]
        public static string __slot_ItZZKDukd3aPXTmpNwMNpS = "or";
        [n1.ElementAttribute(TracingId = 139779U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "FX1pWN95O0VP9lgIkiQAUe", Name = "__slot_FX1pWN95O0VP9lgIkiQAUe")]
        public static string __slot_FX1pWN95O0VP9lgIkiQAUe = "-!#$%'*+=?^`{}|~";
        [n1.ElementAttribute(TracingId = 139783U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "DY0WtoEcqlKQBLF5tiWoaN", Name = "__slot_DY0WtoEcqlKQBLF5tiWoaN")]
        public static string __slot_DY0WtoEcqlKQBLF5tiWoaN = "https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format";
        [n1.ElementAttribute(TracingId = 139817U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "OKZZ55Vqmx1MDzVhv2MaXl", Name = "__slot_OKZZ55Vqmx1MDzVhv2MaXl")]
        public static string __slot_OKZZ55Vqmx1MDzVhv2MaXl = "[-!#$%&'*+/=?^`{}&#124;~\\w] is an alternative encoding";
        [n1.ElementAttribute(TracingId = 139910U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "NVNQEbk8lPZMIdu2qkEIlY", Name = "__slot_NVNQEbk8lPZMIdu2qkEIlY")]
        public static string __slot_NVNQEbk8lPZMIdu2qkEIlY = "number or small letter";
        [n1.ElementAttribute(TracingId = 140064U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "H2PgPLVBvkmLLfwIOKiVOl", Name = "__slot_H2PgPLVBvkmLLfwIOKiVOl")]
        public static string __slot_H2PgPLVBvkmLLfwIOKiVOl = "numbers and letters\r\nhyphen allowed in between\r\nending with a '.'";
        [n1.ElementAttribute(TracingId = 140090U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "CjCnSglfsh7PEs5q6Vylee", Name = "__slot_CjCnSglfsh7PEs5q6Vylee")]
        public static string __slot_CjCnSglfsh7PEs5q6Vylee = ".";
        [n1.ElementAttribute(TracingId = 140120U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "UytFZBa6bOEOdJP9qn4zsw", Name = "__slot_UytFZBa6bOEOdJP9qn4zsw")]
        public static string __slot_UytFZBa6bOEOdJP9qn4zsw = "blabla.x.com ";
        [n1.ElementAttribute(TracingId = 140180U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "AWc7nv1joAMOkkAmAexI4G", Name = "__slot_AWc7nv1joAMOkkAmAexI4G")]
        public static string __slot_AWc7nv1joAMOkkAmAexI4G = "top domain \"com\"\r\ncannot be super long";
        [n1.ElementAttribute(TracingId = 140187U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "IUM9CPUUArgNuVwP1ZnkCF", Name = "__slot_IUM9CPUUArgNuVwP1ZnkCF")]
        public static string __slot_IUM9CPUUArgNuVwP1ZnkCF = "we patched this:";
        [n1.ElementAttribute(TracingId = 140200U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "PCHJofPkH85Pvnvs3aOGsn", Name = "__slot_PCHJofPkH85Pvnvs3aOGsn")]
        public static string __slot_PCHJofPkH85Pvnvs3aOGsn = "as a proof of concept";
        [n1.ElementAttribute(TracingId = 131511U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "JKkxo9QCs0zN84zuYLmCdq", Name = "Expression")]
        public string Expression;
        [n1.ElementAttribute(TracingId = 131478U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "RGmqrzS6x07NtKxVZSO29K", Name = "IsMatch", IsManaged = true, IsAutoGenerated = true)]
        public n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 __p_RGmqrzS6x07NtKxVZSO29K;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n10.Spread<string> __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = default(n10.Spread<string>);
        static IsEmail_VLBfcL2fMjXLFtW0rDJYRo()
        {
        }

        public IsEmail_VLBfcL2fMjXLFtW0rDJYRo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IsEmail_VLBfcL2fMjXLFtW0rDJYRo(IsEmail_VLBfcL2fMjXLFtW0rDJYRo other): base(other)
        {
            this.__slot_VmTcE6UsOrNOAhsPLKceUa = other.__slot_VmTcE6UsOrNOAhsPLKceUa;
            this.Expression = other.Expression;
            this.__p_RGmqrzS6x07NtKxVZSO29K = other.__p_RGmqrzS6x07NtKxVZSO29K;
            this.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = other.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_VmTcE6UsOrNOAhsPLKceUa", in __slot_VmTcE6UsOrNOAhsPLKceUa), n1.CompilationHelper.GetValueOrExisting(values, "Expression", in Expression), n1.CompilationHelper.GetValueOrExisting(values, "__p_RGmqrzS6x07NtKxVZSO29K", in __p_RGmqrzS6x07NtKxVZSO29K), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H", in __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H));
        }

        internal IsEmail_VLBfcL2fMjXLFtW0rDJYRo __WITH__(string __slot_VmTcE6UsOrNOAhsPLKceUa, string Expression, n3.IsMatch_No3CCkpgB8zO94DQbGm6O4 __p_RGmqrzS6x07NtKxVZSO29K, n10.Spread<string> __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H)
        {
            n3.IsEmail_VLBfcL2fMjXLFtW0rDJYRo that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_VmTcE6UsOrNOAhsPLKceUa != this.__slot_VmTcE6UsOrNOAhsPLKceUa || Expression != this.Expression || __p_RGmqrzS6x07NtKxVZSO29K != this.__p_RGmqrzS6x07NtKxVZSO29K || __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H != this.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H ? new IsEmail_VLBfcL2fMjXLFtW0rDJYRo(this)
                {__slot_VmTcE6UsOrNOAhsPLKceUa = __slot_VmTcE6UsOrNOAhsPLKceUa, Expression = Expression, __p_RGmqrzS6x07NtKxVZSO29K = __p_RGmqrzS6x07NtKxVZSO29K, __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H} : that_0;
            else
            {
                this.__slot_VmTcE6UsOrNOAhsPLKceUa = __slot_VmTcE6UsOrNOAhsPLKceUa;
                this.Expression = Expression;
                this.__p_RGmqrzS6x07NtKxVZSO29K = __p_RGmqrzS6x07NtKxVZSO29K;
                this.__pin_group_Input_In_MfDmnNKJytlLx83UoneR7H = __pin_group_Input_In_MfDmnNKJytlLx83UoneR7H;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 140439U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "P7RlkAIt05ZLyx86JF4FWD", Name = "VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD")]
    [n2.SerializableAttribute]
    public class VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD CreateDefault()
        {
            var instance = new VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD Update()
        {
            return this;
        }

        public n3.VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD __CreateDefault__()
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

        public VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD(VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_RegexApplication_P7RlkAIt05ZLyx86JF4FWD __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Escape(string Input_In, out string Output_Out)
        {
            var Output_0 = n5.Regex.Escape(str: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Unescape(string Input_In, out string Output_Out)
        {
            var Output_0 = n5.Regex.Unescape(str: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void RegexOptions(bool Ignore_Case_In, bool Culture_Invariant_In, bool Singleline_In, bool Multiline_In, bool Ignore_Pattern_Whitespace_In, bool Compiled_In, bool Explicit_Capture_In, bool Right_To_Left_In, bool ECMAScript_In, out n5.RegexOptions Output_Out)
        {
            n5.RegexOptions __pad_DfjVudRNFNHNx3UBgOhMVB_0 = __slot_DfjVudRNFNHNx3UBgOhMVB;
            n5.RegexOptions __pad_QUl9WykPAkBMMn1vJl05jO_1 = __slot_QUl9WykPAkBMMn1vJl05jO;
            n5.RegexOptions __pad_SeN0JqdMxpkN7Cmrv6NjLf_2 = __slot_SeN0JqdMxpkN7Cmrv6NjLf;
            n5.RegexOptions __pad_KSk64nuhgPxLOuCNQXAaaR_3 = __slot_KSk64nuhgPxLOuCNQXAaaR;
            n5.RegexOptions __pad_Lf1xyI4ylsiOoYVqkkLAkD_4 = __slot_Lf1xyI4ylsiOoYVqkkLAkD;
            n5.RegexOptions __pad_O2hsX6RRXosNUVB7LM5E5Y_5 = __slot_O2hsX6RRXosNUVB7LM5E5Y;
            n5.RegexOptions __pad_KCNE8ydJfSkPVUwPnJtkyu_6 = __slot_KCNE8ydJfSkPVUwPnJtkyu;
            n5.RegexOptions __pad_AbueszNjvqGM1CtSs9Wyo6_7 = __slot_AbueszNjvqGM1CtSs9Wyo6;
            n5.RegexOptions __pad_QztiMZp4PeeMuO17StxvJE_8 = __slot_QztiMZp4PeeMuO17StxvJE;
            n5.RegexOptions Input_9 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Ignore_Case_In, Input_In: Input_9, Input_2_In: __pad_DfjVudRNFNHNx3UBgOhMVB_0, Output_Out: out n5.RegexOptions Output_10);
            n5.RegexOptions Input_11 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Culture_Invariant_In, Input_In: Input_11, Input_2_In: __pad_QUl9WykPAkBMMn1vJl05jO_1, Output_Out: out n5.RegexOptions Output_12);
            n5.RegexOptions Input_13 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Singleline_In, Input_In: Input_13, Input_2_In: __pad_SeN0JqdMxpkN7Cmrv6NjLf_2, Output_Out: out n5.RegexOptions Output_14);
            n5.RegexOptions Input_15 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Multiline_In, Input_In: Input_15, Input_2_In: __pad_KSk64nuhgPxLOuCNQXAaaR_3, Output_Out: out n5.RegexOptions Output_16);
            n5.RegexOptions Input_17 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Ignore_Pattern_Whitespace_In, Input_In: Input_17, Input_2_In: __pad_Lf1xyI4ylsiOoYVqkkLAkD_4, Output_Out: out n5.RegexOptions Output_18);
            n5.RegexOptions Input_19 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Compiled_In, Input_In: Input_19, Input_2_In: __pad_O2hsX6RRXosNUVB7LM5E5Y_5, Output_Out: out n5.RegexOptions Output_20);
            n5.RegexOptions Input_21 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Explicit_Capture_In, Input_In: Input_21, Input_2_In: __pad_KCNE8ydJfSkPVUwPnJtkyu_6, Output_Out: out n5.RegexOptions Output_22);
            n5.RegexOptions Input_23 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: Right_To_Left_In, Input_In: Input_23, Input_2_In: __pad_AbueszNjvqGM1CtSs9Wyo6_7, Output_Out: out n5.RegexOptions Output_24);
            n5.RegexOptions Input_25 = default(n5.RegexOptions);
            n19._Operations_.Switch_Boolean<n5.RegexOptions>(Condition_In: ECMAScript_In, Input_In: Input_25, Input_2_In: __pad_QztiMZp4PeeMuO17StxvJE_8, Output_Out: out n5.RegexOptions Output_26);
            var Output_27 = Output_10 | Output_12;
            Output_27 = Output_27 | Output_14;
            Output_27 = Output_27 | Output_16;
            Output_27 = Output_27 | Output_18;
            Output_27 = Output_27 | Output_20;
            Output_27 = Output_27 | Output_22;
            Output_27 = Output_27 | Output_24;
            Output_27 = Output_27 | Output_26;
            Output_Out = Output_27;
            return;
        }

        [n1.ElementAttribute(TracingId = 118064U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "DfjVudRNFNHNx3UBgOhMVB", Name = "__slot_DfjVudRNFNHNx3UBgOhMVB")]
        public static n5.RegexOptions __slot_DfjVudRNFNHNx3UBgOhMVB = n1.CompilationHelper.Deserialize<n5.RegexOptions>("IgnoreCase", false, "BrdqoPCUQm5MjX4cJz5Rvf", "DfjVudRNFNHNx3UBgOhMVB");
        [n1.ElementAttribute(TracingId = 118276U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "QUl9WykPAkBMMn1vJl05jO", Name = "__slot_QUl9WykPAkBMMn1vJl05jO")]
        public static n5.RegexOptions __slot_QUl9WykPAkBMMn1vJl05jO = n1.CompilationHelper.Deserialize<n5.RegexOptions>("CultureInvariant", false, "BrdqoPCUQm5MjX4cJz5Rvf", "QUl9WykPAkBMMn1vJl05jO");
        [n1.ElementAttribute(TracingId = 118183U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "SeN0JqdMxpkN7Cmrv6NjLf", Name = "__slot_SeN0JqdMxpkN7Cmrv6NjLf")]
        public static n5.RegexOptions __slot_SeN0JqdMxpkN7Cmrv6NjLf = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Singleline", false, "BrdqoPCUQm5MjX4cJz5Rvf", "SeN0JqdMxpkN7Cmrv6NjLf");
        [n1.ElementAttribute(TracingId = 118090U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "KSk64nuhgPxLOuCNQXAaaR", Name = "__slot_KSk64nuhgPxLOuCNQXAaaR")]
        public static n5.RegexOptions __slot_KSk64nuhgPxLOuCNQXAaaR = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Multiline", false, "BrdqoPCUQm5MjX4cJz5Rvf", "KSk64nuhgPxLOuCNQXAaaR");
        [n1.ElementAttribute(TracingId = 118208U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "Lf1xyI4ylsiOoYVqkkLAkD", Name = "__slot_Lf1xyI4ylsiOoYVqkkLAkD")]
        public static n5.RegexOptions __slot_Lf1xyI4ylsiOoYVqkkLAkD = n1.CompilationHelper.Deserialize<n5.RegexOptions>("IgnorePatternWhitespace", false, "BrdqoPCUQm5MjX4cJz5Rvf", "Lf1xyI4ylsiOoYVqkkLAkD");
        [n1.ElementAttribute(TracingId = 118162U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "O2hsX6RRXosNUVB7LM5E5Y", Name = "__slot_O2hsX6RRXosNUVB7LM5E5Y")]
        public static n5.RegexOptions __slot_O2hsX6RRXosNUVB7LM5E5Y = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Compiled", false, "BrdqoPCUQm5MjX4cJz5Rvf", "O2hsX6RRXosNUVB7LM5E5Y");
        [n1.ElementAttribute(TracingId = 118128U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "KCNE8ydJfSkPVUwPnJtkyu", Name = "__slot_KCNE8ydJfSkPVUwPnJtkyu")]
        public static n5.RegexOptions __slot_KCNE8ydJfSkPVUwPnJtkyu = n1.CompilationHelper.Deserialize<n5.RegexOptions>("ExplicitCapture", false, "BrdqoPCUQm5MjX4cJz5Rvf", "KCNE8ydJfSkPVUwPnJtkyu");
        [n1.ElementAttribute(TracingId = 118230U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "AbueszNjvqGM1CtSs9Wyo6", Name = "__slot_AbueszNjvqGM1CtSs9Wyo6")]
        public static n5.RegexOptions __slot_AbueszNjvqGM1CtSs9Wyo6 = n1.CompilationHelper.Deserialize<n5.RegexOptions>("RightToLeft", false, "BrdqoPCUQm5MjX4cJz5Rvf", "AbueszNjvqGM1CtSs9Wyo6");
        [n1.ElementAttribute(TracingId = 118252U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "QztiMZp4PeeMuO17StxvJE", Name = "__slot_QztiMZp4PeeMuO17StxvJE")]
        public static n5.RegexOptions __slot_QztiMZp4PeeMuO17StxvJE = n1.CompilationHelper.Deserialize<n5.RegexOptions>("ECMAScript", false, "BrdqoPCUQm5MjX4cJz5Rvf", "QztiMZp4PeeMuO17StxvJE");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.SpecialCharacters.Experimental
{
    [n1.ElementAttribute(TracingId = 124107U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "EpZIkcWdU51Px03xnhvg4W", Name = "Themselves_EpZIkcWdU51Px03xnhvg4W")]
    [n2.SerializableAttribute]
    public class Themselves_EpZIkcWdU51Px03xnhvg4W : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n16.Themselves_EpZIkcWdU51Px03xnhvg4W Create(n1.NodeContext Node_Context)
        {
            var instance = new Themselves_EpZIkcWdU51Px03xnhvg4W(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n16.Themselves_EpZIkcWdU51Px03xnhvg4W CreateDefault()
        {
            var instance = new Themselves_EpZIkcWdU51Px03xnhvg4W(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n16.Themselves_EpZIkcWdU51Px03xnhvg4W Update(string Input_In, out string Output_Out)
        {
            n5.Regex __pad_TkKFmbqSTBRNKaDzzjwVJ6_0 = this.__slot_TkKFmbqSTBRNKaDzzjwVJ6;
            string __pad_RCJ18mDZboDLO7SSjaSqaZ_1 = __slot_RCJ18mDZboDLO7SSjaSqaZ;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_G8guRFOYFm4OJNCEXBGkGi;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<string>>(n2.ValueTuple.Create(""));
            }

            var inputs_5 = (__pad_TkKFmbqSTBRNKaDzzjwVJ6_0, Input_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var Result_9 = __pad_TkKFmbqSTBRNKaDzzjwVJ6_0.Replace(input: Input_In, replacement: __pad_RCJ18mDZboDLO7SSjaSqaZ_1);
                outputs_6 = n2.ValueTuple.Create(Result_9);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_10 = outputs_6.Item1;
            Output_Out = __auto_10;
            n16.Themselves_EpZIkcWdU51Px03xnhvg4W that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = manager_4 != this.__cache_G8guRFOYFm4OJNCEXBGkGi ? new Themselves_EpZIkcWdU51Px03xnhvg4W(this)
                {__cache_G8guRFOYFm4OJNCEXBGkGi = manager_4} : that_11;
            else
            {
                this.__cache_G8guRFOYFm4OJNCEXBGkGi = manager_4;
            }

            return that_11;
        }

        public n16.Themselves_EpZIkcWdU51Px03xnhvg4W __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_EOegPLG5PIlL7WLRvLEmac_0 = __slot_EOegPLG5PIlL7WLRvLEmac;
            string Input_1 = "[";
            string Input_3_2 = "]";
            var Output_3 = n13.StringExtensions.Plus(input: Input_1, input2: __pad_EOegPLG5PIlL7WLRvLEmac_0);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_3_2);
            n5.RegexOptions Options_5 = __c_Vt9BEAi1QpcL4afM0APchh;
            var Output_6 = new n5.Regex(pattern: Output_4, options: Options_5);
            n5.Regex __pad_TkKFmbqSTBRNKaDzzjwVJ6_7 = Output_6;
            n16.Themselves_EpZIkcWdU51Px03xnhvg4W that_8 = this;
            this.__slot_TkKFmbqSTBRNKaDzzjwVJ6 = Output_6;
            this.__cache_G8guRFOYFm4OJNCEXBGkGi = null;
            return that_8;
        }

        public n16.Themselves_EpZIkcWdU51Px03xnhvg4W __CreateDefault__()
        {
            n16.Themselves_EpZIkcWdU51Px03xnhvg4W that_0 = this;
            this.__slot_TkKFmbqSTBRNKaDzzjwVJ6 = default(n5.Regex);
            this.__cache_G8guRFOYFm4OJNCEXBGkGi = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_G8guRFOYFm4OJNCEXBGkGi);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 124112U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "EOegPLG5PIlL7WLRvLEmac", Name = "__slot_EOegPLG5PIlL7WLRvLEmac")]
        public static string __slot_EOegPLG5PIlL7WLRvLEmac = "\\.\\$\\^\\{\\[\\(\\|\\)\\]\\}\\*\\+\\?\\\\";
        [n1.ElementAttribute(TracingId = 124193U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "TkKFmbqSTBRNKaDzzjwVJ6", Name = "__slot_TkKFmbqSTBRNKaDzzjwVJ6")]
        public n5.Regex __slot_TkKFmbqSTBRNKaDzzjwVJ6;
        [n1.ElementAttribute(TracingId = 124196U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "I5dAu3eIjvaOwkBweMb1UO", Name = "__slot_I5dAu3eIjvaOwkBweMb1UO")]
        public static string __slot_I5dAu3eIjvaOwkBweMb1UO = "replace all of these characters with \"\\\" followed by the character";
        [n1.ElementAttribute(TracingId = 124219U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "RCJ18mDZboDLO7SSjaSqaZ", Name = "__slot_RCJ18mDZboDLO7SSjaSqaZ")]
        public static string __slot_RCJ18mDZboDLO7SSjaSqaZ = "\\$&";
        [n1.ElementAttribute(TracingId = 124223U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "JVaCy7Iw6JTM4r7bWKadIt", Name = "__slot_JVaCy7Iw6JTM4r7bWKadIt")]
        public static string __slot_JVaCy7Iw6JTM4r7bWKadIt = "The node helps you to make sure that you don't use a reserved character in an unescaped manner";
        [n1.ElementAttribute(TracingId = 124122U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "G8guRFOYFm4OJNCEXBGkGi", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<string>> __cache_G8guRFOYFm4OJNCEXBGkGi = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.RegexOptions __c_Vt9BEAi1QpcL4afM0APchh = n1.CompilationHelper.Deserialize<n5.RegexOptions>("Compiled", false, "BrdqoPCUQm5MjX4cJz5Rvf", "Vt9BEAi1QpcL4afM0APchh");
        static Themselves_EpZIkcWdU51Px03xnhvg4W()
        {
        }

        public Themselves_EpZIkcWdU51Px03xnhvg4W(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Themselves_EpZIkcWdU51Px03xnhvg4W(Themselves_EpZIkcWdU51Px03xnhvg4W other): base(other)
        {
            this.__slot_TkKFmbqSTBRNKaDzzjwVJ6 = other.__slot_TkKFmbqSTBRNKaDzzjwVJ6;
            this.__cache_G8guRFOYFm4OJNCEXBGkGi = other.__cache_G8guRFOYFm4OJNCEXBGkGi;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_TkKFmbqSTBRNKaDzzjwVJ6", in __slot_TkKFmbqSTBRNKaDzzjwVJ6), n1.CompilationHelper.GetValueOrExisting(values, "__cache_G8guRFOYFm4OJNCEXBGkGi", in __cache_G8guRFOYFm4OJNCEXBGkGi));
        }

        internal Themselves_EpZIkcWdU51Px03xnhvg4W __WITH__(n5.Regex __slot_TkKFmbqSTBRNKaDzzjwVJ6, n6.Manager<n2.ValueTuple<n5.Regex, string>, n2.ValueTuple<string>> __cache_G8guRFOYFm4OJNCEXBGkGi)
        {
            n16.Themselves_EpZIkcWdU51Px03xnhvg4W that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_TkKFmbqSTBRNKaDzzjwVJ6 != this.__slot_TkKFmbqSTBRNKaDzzjwVJ6 || __cache_G8guRFOYFm4OJNCEXBGkGi != this.__cache_G8guRFOYFm4OJNCEXBGkGi ? new Themselves_EpZIkcWdU51Px03xnhvg4W(this)
                {__slot_TkKFmbqSTBRNKaDzzjwVJ6 = __slot_TkKFmbqSTBRNKaDzzjwVJ6, __cache_G8guRFOYFm4OJNCEXBGkGi = __cache_G8guRFOYFm4OJNCEXBGkGi} : that_0;
            else
            {
                this.__slot_TkKFmbqSTBRNKaDzzjwVJ6 = __slot_TkKFmbqSTBRNKaDzzjwVJ6;
                this.__cache_G8guRFOYFm4OJNCEXBGkGi = __cache_G8guRFOYFm4OJNCEXBGkGi;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Tab(out string Output_Out)
        {
            string __pad_Arqm8QiLixaN6tbKu4tvlx_0 = __slot_Arqm8QiLixaN6tbKu4tvlx;
            Output_Out = __pad_Arqm8QiLixaN6tbKu4tvlx_0;
            return;
        }

        public static void NewLine(out string Output_Out)
        {
            string __pad_IOTVDyHyFN1NLVjGzjCvy4_0 = __slot_IOTVDyHyFN1NLVjGzjCvy4;
            Output_Out = __pad_IOTVDyHyFN1NLVjGzjCvy4_0;
            return;
        }

        public static void FromUnicode([n4.SerializedDefaultValueAttribute("039E", false)] string Input_In, out string Output_Out)
        {
            string Input_0 = "\\u";
            var Output_1 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            Output_Out = Output_1;
            return;
        }

        public static void CarriageReturn(out string Output_Out)
        {
            string __pad_VvE4ILcK669OlortYXrXZ0_0 = __slot_VvE4ILcK669OlortYXrXZ0;
            Output_Out = __pad_VvE4ILcK669OlortYXrXZ0_0;
            return;
        }

        public static void CarriageReturnNewLine(out string Output_Out)
        {
            string __pad_E6v2U0ldEJaQKgX2hbb42b_0 = __slot_E6v2U0ldEJaQKgX2hbb42b;
            Output_Out = __pad_E6v2U0ldEJaQKgX2hbb42b_0;
            return;
        }

        public static void Space(out string Output_Out)
        {
            string __pad_J1gVDEClR65OlJ2l04OGRT_0 = __slot_J1gVDEClR65OlJ2l04OGRT;
            Output_Out = __pad_J1gVDEClR65OlJ2l04OGRT_0;
            return;
        }

        public static void BackSlash(out string Output_Out)
        {
            string __pad_CmXzWxhAzGSOVLLRJaR6kB_0 = __slot_CmXzWxhAzGSOVLLRJaR6kB;
            Output_Out = __pad_CmXzWxhAzGSOVLLRJaR6kB_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 123919U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "Arqm8QiLixaN6tbKu4tvlx", Name = "__slot_Arqm8QiLixaN6tbKu4tvlx")]
        public static string __slot_Arqm8QiLixaN6tbKu4tvlx = "\\t";
        [n1.ElementAttribute(TracingId = 123944U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "IOTVDyHyFN1NLVjGzjCvy4", Name = "__slot_IOTVDyHyFN1NLVjGzjCvy4")]
        public static string __slot_IOTVDyHyFN1NLVjGzjCvy4 = "\\n";
        [n1.ElementAttribute(TracingId = 124020U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "VvE4ILcK669OlortYXrXZ0", Name = "__slot_VvE4ILcK669OlortYXrXZ0")]
        public static string __slot_VvE4ILcK669OlortYXrXZ0 = "\\r";
        [n1.ElementAttribute(TracingId = 124053U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "E6v2U0ldEJaQKgX2hbb42b", Name = "__slot_E6v2U0ldEJaQKgX2hbb42b")]
        public static string __slot_E6v2U0ldEJaQKgX2hbb42b = "\\r\\n";
        [n1.ElementAttribute(TracingId = 124070U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "J1gVDEClR65OlJ2l04OGRT", Name = "__slot_J1gVDEClR65OlJ2l04OGRT")]
        public static string __slot_J1gVDEClR65OlJ2l04OGRT = "\\x020";
        [n1.ElementAttribute(TracingId = 124093U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "CmXzWxhAzGSOVLLRJaR6kB", Name = "__slot_CmXzWxhAzGSOVLLRJaR6kB")]
        public static string __slot_CmXzWxhAzGSOVLLRJaR6kB = "\\\\";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.CharacterClasses.Experimental
{
    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void AnyOfTheseChars([n4.SerializedDefaultValueAttribute("VL", false)] string Input_In, out string Output_Out)
        {
            string Input_0 = "[";
            string Input_3_1 = "]";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            Output_Out = Output_3;
            return;
        }

        public static void AnyWordChar(out string Output_Out)
        {
            string __pad_DSJMDiaFCJZNBVP3qzALbj_0 = __slot_DSJMDiaFCJZNBVP3qzALbj;
            Output_Out = __pad_DSJMDiaFCJZNBVP3qzALbj_0;
            return;
        }

        public static void AnyWhiteSpace(out string Output_Out)
        {
            string __pad_IvNade5Q4DeNje0nbibiSS_0 = __slot_IvNade5Q4DeNje0nbibiSS;
            Output_Out = __pad_IvNade5Q4DeNje0nbibiSS_0;
            return;
        }

        public static void AnyChar(out string Output_Out)
        {
            string __pad_DHHJPPGRIo9Nw9cbjm203e_0 = __slot_DHHJPPGRIo9Nw9cbjm203e;
            Output_Out = __pad_DHHJPPGRIo9Nw9cbjm203e_0;
            return;
        }

        public static void AnyNonWordChar(out string Output_Out)
        {
            string __pad_I3bkjhkjw43NRuiqt4TME8_0 = __slot_I3bkjhkjw43NRuiqt4TME8;
            Output_Out = __pad_I3bkjhkjw43NRuiqt4TME8_0;
            return;
        }

        public static void NotTheseChars([n4.SerializedDefaultValueAttribute("xyz", false)] string Input_In, out string Output_Out)
        {
            string Input_0 = "[^";
            string Input_3_1 = "]";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            Output_Out = Output_3;
            return;
        }

        public static void AnyNonWhiteSpace(out string Output_Out)
        {
            string __pad_S49l70zzW4NObAotkDhp9W_0 = __slot_S49l70zzW4NObAotkDhp9W;
            Output_Out = __pad_S49l70zzW4NObAotkDhp9W_0;
            return;
        }

        public static void AnyDigit(out string Output_Out)
        {
            string __pad_G8VoRVElxcKMGKXnyzJdVZ_0 = __slot_G8VoRVElxcKMGKXnyzJdVZ;
            Output_Out = __pad_G8VoRVElxcKMGKXnyzJdVZ_0;
            return;
        }

        public static void AnyNonDigit(out string Output_Out)
        {
            string __pad_K59Sg1k1ZIDP0yWd47S6r4_0 = __slot_K59Sg1k1ZIDP0yWd47S6r4;
            Output_Out = __pad_K59Sg1k1ZIDP0yWd47S6r4_0;
            return;
        }

        public static void CharRange([n4.SerializedDefaultValueAttribute("A", false)] string Input_In, [n4.SerializedDefaultValueAttribute("Z", false)] string Input_2_In, out string Output_Out)
        {
            string Input_0 = "";
            string Input_3_1 = "-";
            string Input_5_2 = "";
            var Output_3 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_3_1);
            var Output_5 = n13.StringExtensions.Plus(input: Output_4, input2: Input_2_In);
            var Output_6 = n13.StringExtensions.Plus(input: Output_5, input2: Input_5_2);
            Output_Out = Output_6;
            return;
        }

        [n1.ElementAttribute(TracingId = 124350U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "DSJMDiaFCJZNBVP3qzALbj", Name = "__slot_DSJMDiaFCJZNBVP3qzALbj")]
        public static string __slot_DSJMDiaFCJZNBVP3qzALbj = "\\w";
        [n1.ElementAttribute(TracingId = 124374U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "IvNade5Q4DeNje0nbibiSS", Name = "__slot_IvNade5Q4DeNje0nbibiSS")]
        public static string __slot_IvNade5Q4DeNje0nbibiSS = "\\s";
        [n1.ElementAttribute(TracingId = 124412U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "DHHJPPGRIo9Nw9cbjm203e", Name = "__slot_DHHJPPGRIo9Nw9cbjm203e")]
        public static string __slot_DHHJPPGRIo9Nw9cbjm203e = ".";
        [n1.ElementAttribute(TracingId = 124436U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "I3bkjhkjw43NRuiqt4TME8", Name = "__slot_I3bkjhkjw43NRuiqt4TME8")]
        public static string __slot_I3bkjhkjw43NRuiqt4TME8 = "\\W";
        [n1.ElementAttribute(TracingId = 124534U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "S49l70zzW4NObAotkDhp9W", Name = "__slot_S49l70zzW4NObAotkDhp9W")]
        public static string __slot_S49l70zzW4NObAotkDhp9W = "\\S";
        [n1.ElementAttribute(TracingId = 129220U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "G8VoRVElxcKMGKXnyzJdVZ", Name = "__slot_G8VoRVElxcKMGKXnyzJdVZ")]
        public static string __slot_G8VoRVElxcKMGKXnyzJdVZ = "\\d";
        [n1.ElementAttribute(TracingId = 130605U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "K59Sg1k1ZIDP0yWd47S6r4", Name = "__slot_K59Sg1k1ZIDP0yWd47S6r4")]
        public static string __slot_K59Sg1k1ZIDP0yWd47S6r4 = "\\D";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.Quantifiers.Experimental
{
    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void SeveralTimes_OrZeroTimes([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, out string Output_Out)
        {
            string Input_2_0 = "*";
            var Output_1 = n13.StringExtensions.Plus(input: Input_In, input2: Input_2_0);
            Output_Out = Output_1;
            return;
        }

        public static void SeveralTimes_AtLeastOnce([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, out string Output_Out)
        {
            string Input_2_0 = "+";
            var Output_1 = n13.StringExtensions.Plus(input: Input_In, input2: Input_2_0);
            Output_Out = Output_1;
            return;
        }

        public static void MaybeOnce([n4.SerializedDefaultValueAttribute("L", false)] string Input_In, out string Output_Out)
        {
            string Input_2_0 = "?";
            var Output_1 = n13.StringExtensions.Plus(input: Input_In, input2: Input_2_0);
            Output_Out = Output_1;
            return;
        }

        public static void ExactlyNTimes([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, [n4.SerializedDefaultValueAttribute("4", false)] int N_In, out string Output_Out)
        {
            var Result_0 = n7.ObjectHelpers.ToString(input: N_In);
            string Input_1 = "{";
            string Input_3_2 = "}";
            var Output_3 = n13.StringExtensions.Plus(input: Input_1, input2: Result_0);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_3_2);
            var Output_5 = n13.StringExtensions.Plus(input: Input_In, input2: Output_4);
            Output_Out = Output_5;
            return;
        }

        public static void AtLeastNTimes([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, [n4.SerializedDefaultValueAttribute("4", false)] int N_In, out string Output_Out)
        {
            var Result_0 = n7.ObjectHelpers.ToString(input: N_In);
            string Input_1 = "{";
            string Input_3_2 = ",}";
            var Output_3 = n13.StringExtensions.Plus(input: Input_1, input2: Result_0);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_3_2);
            var Output_5 = n13.StringExtensions.Plus(input: Input_In, input2: Output_4);
            Output_Out = Output_5;
            return;
        }

        public static void NToMTimes([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, [n4.SerializedDefaultValueAttribute("4", false)] int N_In, [n4.SerializedDefaultValueAttribute("5", false)] int M_In, out string Output_Out)
        {
            var Result_0 = n7.ObjectHelpers.ToString(input: N_In);
            var Result_1 = n7.ObjectHelpers.ToString(input: M_In);
            string Input_2 = "{";
            string Input_3_3 = ",";
            string Input_5_4 = "}";
            var Output_5 = n13.StringExtensions.Plus(input: Input_2, input2: Result_0);
            var Output_6 = n13.StringExtensions.Plus(input: Output_5, input2: Input_3_3);
            var Output_7 = n13.StringExtensions.Plus(input: Output_6, input2: Result_1);
            var Output_8 = n13.StringExtensions.Plus(input: Output_7, input2: Input_5_4);
            var Output_9 = n13.StringExtensions.Plus(input: Input_In, input2: Output_8);
            Output_Out = Output_9;
            return;
        }

        public static void SeveralTimes_OrZeroTimes_PreferFew([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, out string Output_Out)
        {
            string Input_2_0 = "*?";
            var Output_1 = n13.StringExtensions.Plus(input: Input_In, input2: Input_2_0);
            Output_Out = Output_1;
            return;
        }

        public static void SeveralTimes_AtLeastOnce_PreferFew([n4.SerializedDefaultValueAttribute("v", false)] string Input_In, out string Output_Out)
        {
            string Input_2_0 = "+?";
            var Output_1 = n13.StringExtensions.Plus(input: Input_In, input2: Input_2_0);
            Output_Out = Output_1;
            return;
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.Anchors.Experimental
{
    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void StringStarts(out string Output_Out)
        {
            string __pad_EmmdmoUNh9gQVxaeAY1UcB_0 = __slot_EmmdmoUNh9gQVxaeAY1UcB;
            Output_Out = __pad_EmmdmoUNh9gQVxaeAY1UcB_0;
            return;
        }

        public static void StringEnds(out string Output_Out)
        {
            string __pad_LdAEnDIfUAUMV05gzgrg2r_0 = __slot_LdAEnDIfUAUMV05gzgrg2r;
            Output_Out = __pad_LdAEnDIfUAUMV05gzgrg2r_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 130979U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "EmmdmoUNh9gQVxaeAY1UcB", Name = "__slot_EmmdmoUNh9gQVxaeAY1UcB")]
        public static string __slot_EmmdmoUNh9gQVxaeAY1UcB = "^";
        [n1.ElementAttribute(TracingId = 130994U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", PersistentId = "LdAEnDIfUAUMV05gzgrg2r", Name = "__slot_LdAEnDIfUAUMV05gzgrg2r")]
        public static string __slot_LdAEnDIfUAUMV05gzgrg2r = "$";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.Groups.Experimental
{
    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Group_RegExpr([n4.SerializedDefaultValueAttribute("", false)] string Input_In, out string Output_Out)
        {
            string Input_0 = "(";
            string Input_3_1 = ")";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            Output_Out = Output_3;
            return;
        }

        public static void GroupAndName([n4.SerializedDefaultValueAttribute("", false)] string Input_In, [n4.SerializedDefaultValueAttribute("Foo", false)] string Name_In, out string Output_Out)
        {
            string Input_0 = "(?<";
            string Input_3_1 = ">";
            string Input_5_2 = ")";
            var Output_3 = n13.StringExtensions.Plus(input: Input_0, input2: Name_In);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_3_1);
            var Output_5 = n13.StringExtensions.Plus(input: Output_4, input2: Input_In);
            var Output_6 = n13.StringExtensions.Plus(input: Output_5, input2: Input_5_2);
            Output_Out = Output_6;
            return;
        }

        public static void NotPrecededBy([n4.SerializedDefaultValueAttribute("L", false)] string Input_In, [n4.SerializedDefaultValueAttribute("V", false)] string Input_2_In, out string Output_Out)
        {
            string Input_0 = "(?<!";
            string Input_3_1 = ")";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_2_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_In);
            Output_Out = Output_4;
            return;
        }

        public static void NotFollowedBy([n4.SerializedDefaultValueAttribute("L", false)] string Input_In, out string Output_Out)
        {
            string Input_0 = "(?!";
            string Input_3_1 = ")";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            Output_Out = Output_3;
            return;
        }

        public static void PrecededBy([n4.SerializedDefaultValueAttribute("L", false)] string Input_In, [n4.SerializedDefaultValueAttribute("V", false)] string Input_2_In, out string Output_Out)
        {
            string Input_0 = "(?<=";
            string Input_3_1 = ")";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_2_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_3_1);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_In);
            Output_Out = Output_4;
            return;
        }

        public static void Group_RegExpr([n4.SerializedDefaultValueAttribute("", false)] string Input_In, [n4.SerializedDefaultValueAttribute("", false)] string Input_2_In, out string Output_Out)
        {
            string Input_0 = "(";
            string Input_4_1 = ")";
            var Output_2 = n13.StringExtensions.Plus(input: Input_0, input2: Input_In);
            var Output_3 = n13.StringExtensions.Plus(input: Output_2, input2: Input_2_In);
            var Output_4 = n13.StringExtensions.Plus(input: Output_3, input2: Input_4_1);
            Output_Out = Output_4;
            return;
        }
    }
}

namespace _VL_Regex_.Text.RegularExpressions.Patched.Alternation.Experimental
{
    [n1.ElementAttribute(TracingId = 116778U, DocumentId = "BrdqoPCUQm5MjX4cJz5Rvf", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void If_RegExpr([n4.SerializedDefaultValueAttribute("", false)] string If_In, string Then_In, string Else_In, out string Output_Out)
        {
            string Input_0 = "(?(";
            string Input_3_1 = ")";
            string Input_5_2 = "|";
            string Input_7_3 = ")";
            var Output_4 = n13.StringExtensions.Plus(input: Input_0, input2: If_In);
            var Output_5 = n13.StringExtensions.Plus(input: Output_4, input2: Input_3_1);
            var Output_6 = n13.StringExtensions.Plus(input: Output_5, input2: Then_In);
            var Output_7 = n13.StringExtensions.Plus(input: Output_6, input2: Input_5_2);
            var Output_8 = n13.StringExtensions.Plus(input: Output_7, input2: Else_In);
            var Output_9 = n13.StringExtensions.Plus(input: Output_8, input2: Input_7_3);
            Output_Out = Output_9;
            return;
        }

        public static void OR_RegExpr([n4.SerializedDefaultValueAttribute("<DefaultValue xmlns=\"property\">\r\n  <Item xmlns=\"\"></Item>\r\n</DefaultValue>", true)] n10.Spread<string> Input_In, out string Output_Out)
        {
            string Value_0 = "(";
            int Capacity_1 = 16;
            var Output_2 = new n20.StringBuilder(value: Value_0, capacity: Capacity_1);
            n11._Operations_.Count<string>(Input_In: Input_In, Count_Out: out int Count_3);
            int Input_2_4 = 1;
            var Output_5 = Count_3 - Input_2_4;
            n20.StringBuilder accumulator_7 = Output_2;
            var i_9 = 0;
            foreach (var item_6 in n4.CollectionExtensions.AsSpan(Input_In))
            {
                var splicer_8 = item_6;
                var i_local_10 = i_9;
                var Result_11 = i_local_10 < Output_5;
                var Result_12 = accumulator_7.Append(value: splicer_8);
                n20.StringBuilder __auto_13;
                if (Result_11)
                {
                    string Value_14 = "|";
                    var Result_15 = accumulator_7.Append(value: Value_14);
                    __auto_13 = accumulator_7;
                }
                else
                {
                    __auto_13 = accumulator_7;
                }

                accumulator_7 = __auto_13;
                i_9++;
            }

            string Value_16 = ")";
            var Result_17 = accumulator_7.Append(value: Value_16);
            var Result_18 = n7.ObjectHelpers.ToString(input: accumulator_7);
            Output_Out = Result_18;
            return;
        }
    }
}

namespace _VL_Regex_
{
    public struct __AdaptiveImplementations__BrdqoPCUQm5MjX4cJz5Rvf
    {
    }
}