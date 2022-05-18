extern alias e3;
extern alias e2;
extern alias e20;

using n11 = _VL_FuzzySearch_;
using n17 = _CoreLibBasics_.Control.Advanced;
using n5 = e2::VL.Lib.Collections;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n22 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n24 = _CoreLibBasics_.Control;
using n19 = _CoreLibBasics_.Primitive.String;
using n3 = _VL_FuzzySearch_.Text.FuzzySearch;
using n15 = _VL_Text_SimMetrics_.Text.Metrics;
using n6 = global::System.Collections.Generic;
using n13 = e20::SimMetricsCore.API;
using n28 = _CoreLibBasics_.Math.Adaptive;
using n27 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n21 = e3::VL.Lib.Primitive;
using n10 = e2::VL.Lib.Runtime;
using n20 = _VL_Text_SimMetrics_.Text.Metrics.IStringMetric;
using n18 = global::System.Text.RegularExpressions;
using n1 = e2::VL.Core;
using n25 = _VL_FuzzySearch_.Text.FuzzySearch.Scoring;
using n2 = global::System;
using n4 = e2::VL.Core.CompilerServices;
using n9 = _VL_FuzzySearch_.Text.FuzzySearch.Search;
using n12 = _VL_Collections_.Collections.Sequence;
using n14 = global::System.Runtime.CompilerServices;
using n16 = global::System.Linq;
using n8 = _VL_Collections_.Collections.Spread;
using n23 = _VL_Regex_.Text.RegularExpressions;
using n26 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_FuzzySearch_.Text.FuzzySearch
{
    [n1.ElementAttribute(TracingId = 218882U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "Vihr5DFy03FLLX8M2rP0e3", Name = "Search_Vihr5DFy03FLLX8M2rP0e3")]
    [n2.SerializableAttribute]
    public class Search_Vihr5DFy03FLLX8M2rP0e3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Search_Vihr5DFy03FLLX8M2rP0e3 Create(n1.NodeContext Node_Context)
        {
            var instance = new Search_Vihr5DFy03FLLX8M2rP0e3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Search_Vihr5DFy03FLLX8M2rP0e3 CreateDefault()
        {
            var instance = new Search_Vihr5DFy03FLLX8M2rP0e3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Search_Vihr5DFy03FLLX8M2rP0e3 Update(n5.Spread<string> List_to_Search_In, [n4.SerializedDefaultValueAttribute("", false)] string Search_String_In, int Minimum_Word_Length_In, bool Case_Sensetive_In, n6.IEnumerable<string> Words_to_Exclude_In, [n4.SerializedDefaultValueAttribute("0.6", false)] float Similarity_Threshold_In, out n5.Spread<n9.SearchResult_R> Output_Out, out bool Search_String_exists_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_DNhErxLiIYeOqrqz2NaZ7h;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.Spread<string>, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<n5.Spread<string>>>>(n2.ValueTuple.Create(n8._Operations_.CreateDefault<n5.Spread<string>>()));
            }

            var inputs_3 = (List_to_Search_In, Minimum_Word_Length_In, Words_to_Exclude_In, Case_Sensetive_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__D04sentDAMAPI446hG8pQ4>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __D04sentDAMAPI446hG8pQ4(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_Fym2tdkFLzFP6fD0uP6g05 = n8._Operations_.CreateDefault<n5.Spread<string>>()};
                }

                var manager_18 = state_6.__loop_JwvHIP75QB9K977T9ehJAq ?? new n10.ImmutableLifetimeManager();
                var iterator_19 = manager_18.GetIterator(__GetContext__());
                var builder_20 = n4.CollectionBuilders.GetBuilder(state_6.__cp_Fym2tdkFLzFP6fD0uP6g05, 16);
                n5.Spread<n5.Spread<string>> output_21;
                try
                {
                    var i_9 = 0;
                    foreach (var item_7 in n4.CollectionExtensions.AsSpan(List_to_Search_In))
                    {
                        var splicer_8 = item_7;
                        var i_local_10 = i_9;
                        __OX6hFKg5k1qMcND0KgBjOL state_11;
                        if (!iterator_19.MoveNext(out state_11))
                        {
                            iterator_19.Add(state_11 = new __OX6hFKg5k1qMcND0KgBjOL(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "D6ahSbuE2MkPP5caA8ZQbU", 218935U);
                            var Output_13 = n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa.Create(Node_Context: Node_Context_12);
                            state_11.__p_D6ahSbuE2MkPP5caA8ZQbU = Output_13;
                        }

                        float Words_to_Exclude_Minimum_Similarity_14 = 0.6F;
                        bool Include_Shortcuts_15 = true;
                        var State_Output_17 = state_11.__p_D6ahSbuE2MkPP5caA8ZQbU.Update(Input_In: splicer_8, Minimum_Word_Length_In: Minimum_Word_Length_In, Words_to_Exclude_In: Words_to_Exclude_In, Case_Sensetive_In: Case_Sensetive_In, Words_to_Exclude_Minimum_Similarity_In: Words_to_Exclude_Minimum_Similarity_14, Include_Shortcuts_In: Include_Shortcuts_15, Output_Out: out n5.Spread<string> Output_16);
                        if (state_11.__GetContext__().IsImmutable)
                            state_11 = State_Output_17 != state_11.__p_D6ahSbuE2MkPP5caA8ZQbU ? new __OX6hFKg5k1qMcND0KgBjOL(state_11)
                            {__p_D6ahSbuE2MkPP5caA8ZQbU = State_Output_17} : state_11;
                        else
                        {
                            state_11.__p_D6ahSbuE2MkPP5caA8ZQbU = State_Output_17;
                        }

                        iterator_19.Update(state_11);
                        builder_20.Add(Output_16);
                        i_9++;
                    }
                }
                finally
                {
                    manager_18 = iterator_19.Commit();
                    output_21 = builder_20.Commit();
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = manager_18 != state_6.__loop_JwvHIP75QB9K977T9ehJAq || output_21 != state_6.__cp_Fym2tdkFLzFP6fD0uP6g05 ? new __D04sentDAMAPI446hG8pQ4(state_6)
                    {__loop_JwvHIP75QB9K977T9ehJAq = manager_18, __cp_Fym2tdkFLzFP6fD0uP6g05 = output_21} : state_6;
                else
                {
                    state_6.__loop_JwvHIP75QB9K977T9ehJAq = manager_18;
                    state_6.__cp_Fym2tdkFLzFP6fD0uP6g05 = output_21;
                }

                outputs_4 = n2.ValueTuple.Create(output_21);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_22 = outputs_4.Item1;
            bool Force_23 = false;
            bool Dispose_Cached_Outputs_24 = false;
            var manager_25 = this.__cache_Pq2AsBlFaP4PTmTzs0Xhus;
            if (manager_25 is null)
            {
                manager_25 = new n7.Manager<n2.ValueTuple<string, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<string>>>(n2.ValueTuple.Create(n8._Operations_.CreateDefault<string>()));
            }

            var inputs_26 = (Search_String_In, Minimum_Word_Length_In, Words_to_Exclude_In, Case_Sensetive_In);
            var outputs_27 = manager_25.Outputs;
            var Has_Changed_28 = Force_23 || manager_25.InputsChanged(inputs_26);
            if (Has_Changed_28)
            {
                if (Dispose_Cached_Outputs_24)
                    manager_25.DisposeOutputs();
                var state_29 = n1.CompilationHelper.Restore<__VX5c4ZMN0FIOpUQyzU2DAO>(manager_25.State, __GetContext__());
                if (state_29 == null)
                {
                    state_29 = new __VX5c4ZMN0FIOpUQyzU2DAO(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "Upw21pW1kUPL8JBzrvORyi", 218996U);
                    var Output_31 = n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa.Create(Node_Context: Node_Context_30);
                    state_29.__p_Upw21pW1kUPL8JBzrvORyi = Output_31;
                }

                float Words_to_Exclude_Minimum_Similarity_32 = 0.6F;
                bool Include_Shortcuts_33 = true;
                var State_Output_35 = state_29.__p_Upw21pW1kUPL8JBzrvORyi.Update(Input_In: Search_String_In, Minimum_Word_Length_In: Minimum_Word_Length_In, Words_to_Exclude_In: Words_to_Exclude_In, Case_Sensetive_In: Case_Sensetive_In, Words_to_Exclude_Minimum_Similarity_In: Words_to_Exclude_Minimum_Similarity_32, Include_Shortcuts_In: Include_Shortcuts_33, Output_Out: out n5.Spread<string> Output_34);
                if (state_29.__GetContext__().IsImmutable)
                    state_29 = State_Output_35 != state_29.__p_Upw21pW1kUPL8JBzrvORyi ? new __VX5c4ZMN0FIOpUQyzU2DAO(state_29)
                    {__p_Upw21pW1kUPL8JBzrvORyi = State_Output_35} : state_29;
                else
                {
                    state_29.__p_Upw21pW1kUPL8JBzrvORyi = State_Output_35;
                }

                outputs_27 = n2.ValueTuple.Create(Output_34);
                manager_25 = manager_25.Update(inputs_26, __GetContext__().IsImmutable, Dispose_Cached_Outputs_24, state_29, outputs_27);
            }
            else
            {
                manager_25.Update(inputs_26, __GetContext__().IsImmutable, Dispose_Cached_Outputs_24);
            }

            var __auto_36 = outputs_27.Item1;
            var State_Output_38 = this.__p_TIItYhqBzfBLIDBZ2HSKrD.Get(Output_Out: out n13.IStringMetric Output_37);
            bool Force_39 = false;
            bool Dispose_Cached_Outputs_40 = false;
            var manager_41 = this.__cache_E4rkhiWseohMNPhuW8Uv2F;
            if (manager_41 is null)
            {
                manager_41 = new n7.Manager<n2.ValueTuple<n5.Spread<string>, n5.Spread<n5.Spread<string>>, n5.Spread<string>, float>, n2.ValueTuple<n5.Spread<n9.SearchResult_R>>>(n2.ValueTuple.Create(n8._Operations_.CreateDefault<n9.SearchResult_R>()));
            }

            var inputs_42 = (List_to_Search_In, __auto_22, __auto_36, Similarity_Threshold_In);
            var outputs_43 = manager_41.Outputs;
            var Has_Changed_44 = Force_39 || manager_41.InputsChanged(inputs_42);
            if (Has_Changed_44)
            {
                if (Dispose_Cached_Outputs_40)
                    manager_41.DisposeOutputs();
                var state_45 = n1.CompilationHelper.Restore<__DXpLxGxSH8iLkbJpvlTYHv>(manager_41.State, __GetContext__());
                if (state_45 == null)
                {
                    state_45 = new __DXpLxGxSH8iLkbJpvlTYHv(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_46 = __GetContext__().CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "CE921TBEFimNeh522NqNgi", 219113U);
                    var Output_47 = n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ.Create(Node_Context: Node_Context_46);
                    state_45.__p_CE921TBEFimNeh522NqNgi = Output_47;
                }

                n6.IEnumerable<n6.IEnumerable<string>> List_to_Search_48 = (n6.IEnumerable<n6.IEnumerable<string>>)__auto_22;
                n6.IEnumerable<string> Search_String_49 = (n6.IEnumerable<string>)__auto_36;
                var State_Output_51 = state_45.__p_CE921TBEFimNeh522NqNgi.Update(Original_Strings_In: List_to_Search_In, List_to_Search_In: List_to_Search_48, Search_String_In: Search_String_49, Similarity_Threshold_In: Similarity_Threshold_In, Algorithm_In: Output_37, Output_Out: out n5.Spread<n9.SearchResult_R> Output_50);
                if (state_45.__GetContext__().IsImmutable)
                    state_45 = State_Output_51 != state_45.__p_CE921TBEFimNeh522NqNgi ? new __DXpLxGxSH8iLkbJpvlTYHv(state_45)
                    {__p_CE921TBEFimNeh522NqNgi = State_Output_51} : state_45;
                else
                {
                    state_45.__p_CE921TBEFimNeh522NqNgi = State_Output_51;
                }

                outputs_43 = n2.ValueTuple.Create(Output_50);
                manager_41 = manager_41.Update(inputs_42, __GetContext__().IsImmutable, Dispose_Cached_Outputs_40, state_45, outputs_43);
            }
            else
            {
                manager_41.Update(inputs_42, __GetContext__().IsImmutable, Dispose_Cached_Outputs_40);
            }

            var __auto_52 = outputs_43.Item1;
            n6.IEnumerable<string> Input_53 = (n6.IEnumerable<string>)__auto_36;
            n12._Operations_.Any<string>(Input_In: Input_53, Result_Out: out bool Result_54);
            Output_Out = __auto_52;
            Search_String_exists_Out = Result_54;
            n3.Search_Vihr5DFy03FLLX8M2rP0e3 that_55 = this;
            if (this.__GetContext__().IsImmutable)
                that_55 = manager_2 != this.__cache_DNhErxLiIYeOqrqz2NaZ7h || manager_25 != this.__cache_Pq2AsBlFaP4PTmTzs0Xhus || State_Output_38 != this.__p_TIItYhqBzfBLIDBZ2HSKrD || manager_41 != this.__cache_E4rkhiWseohMNPhuW8Uv2F ? new Search_Vihr5DFy03FLLX8M2rP0e3(this)
                {__cache_DNhErxLiIYeOqrqz2NaZ7h = manager_2, __cache_Pq2AsBlFaP4PTmTzs0Xhus = manager_25, __p_TIItYhqBzfBLIDBZ2HSKrD = State_Output_38, __cache_E4rkhiWseohMNPhuW8Uv2F = manager_41} : that_55;
            else
            {
                this.__cache_DNhErxLiIYeOqrqz2NaZ7h = manager_2;
                this.__cache_Pq2AsBlFaP4PTmTzs0Xhus = manager_25;
                this.__p_TIItYhqBzfBLIDBZ2HSKrD = State_Output_38;
                this.__cache_E4rkhiWseohMNPhuW8Uv2F = manager_41;
            }

            return that_55;
        }

        public n3.Search_Vihr5DFy03FLLX8M2rP0e3 __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "TIItYhqBzfBLIDBZ2HSKrD", 219036U);
            var Output_1 = n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc.Create(Node_Context: Node_Context_0);
            n3.Search_Vihr5DFy03FLLX8M2rP0e3 that_2 = this;
            this.__p_TIItYhqBzfBLIDBZ2HSKrD = Output_1;
            this.__cache_DNhErxLiIYeOqrqz2NaZ7h = null;
            this.__cache_Pq2AsBlFaP4PTmTzs0Xhus = null;
            this.__cache_E4rkhiWseohMNPhuW8Uv2F = null;
            return that_2;
        }

        public n3.Search_Vihr5DFy03FLLX8M2rP0e3 __CreateDefault__()
        {
            n3.Search_Vihr5DFy03FLLX8M2rP0e3 that_0 = this;
            this.__cache_DNhErxLiIYeOqrqz2NaZ7h = null;
            this.__cache_Pq2AsBlFaP4PTmTzs0Xhus = null;
            this.__p_TIItYhqBzfBLIDBZ2HSKrD = n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc.CreateDefault();
            this.__cache_E4rkhiWseohMNPhuW8Uv2F = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DNhErxLiIYeOqrqz2NaZ7h);
            n1.CompilationHelper.SafeDispose(this.__cache_Pq2AsBlFaP4PTmTzs0Xhus);
            n1.CompilationHelper.SafeDispose(this.__p_TIItYhqBzfBLIDBZ2HSKrD);
            n1.CompilationHelper.SafeDispose(this.__cache_E4rkhiWseohMNPhuW8Uv2F);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 219045U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "DQ2QCI1KJ0QNcE103Suitb", Name = "__slot_DQ2QCI1KJ0QNcE103Suitb")]
        public static string __slot_DQ2QCI1KJ0QNcE103Suitb = "< Similarity Algorithm";
        [n1.ElementAttribute(TracingId = 219055U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "JWxne1ZNoIoNFCtdbYHcXb", Name = "__slot_JWxne1ZNoIoNFCtdbYHcXb")]
        public static string __slot_JWxne1ZNoIoNFCtdbYHcXb = "< Make your own Preprocessor";
        [n1.ElementAttribute(TracingId = 218892U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "DNhErxLiIYeOqrqz2NaZ7h", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Spread<string>, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<n5.Spread<string>>>> __cache_DNhErxLiIYeOqrqz2NaZ7h = null;
        [n1.ElementAttribute(TracingId = 218963U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "Pq2AsBlFaP4PTmTzs0Xhus", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<string, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<string>>> __cache_Pq2AsBlFaP4PTmTzs0Xhus = null;
        [n1.ElementAttribute(TracingId = 219036U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "TIItYhqBzfBLIDBZ2HSKrD", Name = "Levenshtein", IsManaged = true, IsAutoGenerated = true)]
        public n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __p_TIItYhqBzfBLIDBZ2HSKrD;
        [n1.ElementAttribute(TracingId = 219080U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "E4rkhiWseohMNPhuW8Uv2F", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Spread<string>, n5.Spread<n5.Spread<string>>, n5.Spread<string>, float>, n2.ValueTuple<n5.Spread<n9.SearchResult_R>>> __cache_E4rkhiWseohMNPhuW8Uv2F = null;
        static Search_Vihr5DFy03FLLX8M2rP0e3()
        {
        }

        public Search_Vihr5DFy03FLLX8M2rP0e3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Search_Vihr5DFy03FLLX8M2rP0e3(Search_Vihr5DFy03FLLX8M2rP0e3 other): base(other)
        {
            this.__cache_DNhErxLiIYeOqrqz2NaZ7h = other.__cache_DNhErxLiIYeOqrqz2NaZ7h;
            this.__cache_Pq2AsBlFaP4PTmTzs0Xhus = other.__cache_Pq2AsBlFaP4PTmTzs0Xhus;
            this.__p_TIItYhqBzfBLIDBZ2HSKrD = other.__p_TIItYhqBzfBLIDBZ2HSKrD;
            this.__cache_E4rkhiWseohMNPhuW8Uv2F = other.__cache_E4rkhiWseohMNPhuW8Uv2F;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DNhErxLiIYeOqrqz2NaZ7h", in __cache_DNhErxLiIYeOqrqz2NaZ7h), n1.CompilationHelper.GetValueOrExisting(values, "__cache_Pq2AsBlFaP4PTmTzs0Xhus", in __cache_Pq2AsBlFaP4PTmTzs0Xhus), n1.CompilationHelper.GetValueOrExisting(values, "__p_TIItYhqBzfBLIDBZ2HSKrD", in __p_TIItYhqBzfBLIDBZ2HSKrD), n1.CompilationHelper.GetValueOrExisting(values, "__cache_E4rkhiWseohMNPhuW8Uv2F", in __cache_E4rkhiWseohMNPhuW8Uv2F));
        }

        internal Search_Vihr5DFy03FLLX8M2rP0e3 __WITH__(n7.Manager<n2.ValueTuple<n5.Spread<string>, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<n5.Spread<string>>>> __cache_DNhErxLiIYeOqrqz2NaZ7h, n7.Manager<n2.ValueTuple<string, int, n6.IEnumerable<string>, bool>, n2.ValueTuple<n5.Spread<string>>> __cache_Pq2AsBlFaP4PTmTzs0Xhus, n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __p_TIItYhqBzfBLIDBZ2HSKrD, n7.Manager<n2.ValueTuple<n5.Spread<string>, n5.Spread<n5.Spread<string>>, n5.Spread<string>, float>, n2.ValueTuple<n5.Spread<n9.SearchResult_R>>> __cache_E4rkhiWseohMNPhuW8Uv2F)
        {
            n3.Search_Vihr5DFy03FLLX8M2rP0e3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DNhErxLiIYeOqrqz2NaZ7h != this.__cache_DNhErxLiIYeOqrqz2NaZ7h || __cache_Pq2AsBlFaP4PTmTzs0Xhus != this.__cache_Pq2AsBlFaP4PTmTzs0Xhus || __p_TIItYhqBzfBLIDBZ2HSKrD != this.__p_TIItYhqBzfBLIDBZ2HSKrD || __cache_E4rkhiWseohMNPhuW8Uv2F != this.__cache_E4rkhiWseohMNPhuW8Uv2F ? new Search_Vihr5DFy03FLLX8M2rP0e3(this)
                {__cache_DNhErxLiIYeOqrqz2NaZ7h = __cache_DNhErxLiIYeOqrqz2NaZ7h, __cache_Pq2AsBlFaP4PTmTzs0Xhus = __cache_Pq2AsBlFaP4PTmTzs0Xhus, __p_TIItYhqBzfBLIDBZ2HSKrD = __p_TIItYhqBzfBLIDBZ2HSKrD, __cache_E4rkhiWseohMNPhuW8Uv2F = __cache_E4rkhiWseohMNPhuW8Uv2F} : that_0;
            else
            {
                this.__cache_DNhErxLiIYeOqrqz2NaZ7h = __cache_DNhErxLiIYeOqrqz2NaZ7h;
                this.__cache_Pq2AsBlFaP4PTmTzs0Xhus = __cache_Pq2AsBlFaP4PTmTzs0Xhus;
                this.__p_TIItYhqBzfBLIDBZ2HSKrD = __p_TIItYhqBzfBLIDBZ2HSKrD;
                this.__cache_E4rkhiWseohMNPhuW8Uv2F = __cache_E4rkhiWseohMNPhuW8Uv2F;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "D04sentDAMAPI446hG8pQ4", Name = "__D04sentDAMAPI446hG8pQ4")]
        [n2.SerializableAttribute]
        public class __D04sentDAMAPI446hG8pQ4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_JwvHIP75QB9K977T9ehJAq);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n10.ImmutableLifetimeManager __loop_JwvHIP75QB9K977T9ehJAq;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n5.Spread<string>> __cp_Fym2tdkFLzFP6fD0uP6g05;
            public __D04sentDAMAPI446hG8pQ4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __D04sentDAMAPI446hG8pQ4(__D04sentDAMAPI446hG8pQ4 other): base(other)
            {
                this.__loop_JwvHIP75QB9K977T9ehJAq = other.__loop_JwvHIP75QB9K977T9ehJAq;
                this.__cp_Fym2tdkFLzFP6fD0uP6g05 = other.__cp_Fym2tdkFLzFP6fD0uP6g05;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_JwvHIP75QB9K977T9ehJAq", in __loop_JwvHIP75QB9K977T9ehJAq), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Fym2tdkFLzFP6fD0uP6g05", in __cp_Fym2tdkFLzFP6fD0uP6g05));
            }

            internal __D04sentDAMAPI446hG8pQ4 __WITH__(n10.ImmutableLifetimeManager __loop_JwvHIP75QB9K977T9ehJAq, n5.Spread<n5.Spread<string>> __cp_Fym2tdkFLzFP6fD0uP6g05)
            {
                __D04sentDAMAPI446hG8pQ4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_JwvHIP75QB9K977T9ehJAq != this.__loop_JwvHIP75QB9K977T9ehJAq || __cp_Fym2tdkFLzFP6fD0uP6g05 != this.__cp_Fym2tdkFLzFP6fD0uP6g05 ? new __D04sentDAMAPI446hG8pQ4(this)
                    {__loop_JwvHIP75QB9K977T9ehJAq = __loop_JwvHIP75QB9K977T9ehJAq, __cp_Fym2tdkFLzFP6fD0uP6g05 = __cp_Fym2tdkFLzFP6fD0uP6g05} : that_0;
                else
                {
                    this.__loop_JwvHIP75QB9K977T9ehJAq = __loop_JwvHIP75QB9K977T9ehJAq;
                    this.__cp_Fym2tdkFLzFP6fD0uP6g05 = __cp_Fym2tdkFLzFP6fD0uP6g05;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "OX6hFKg5k1qMcND0KgBjOL", Name = "__OX6hFKg5k1qMcND0KgBjOL")]
        [n2.SerializableAttribute]
        public class __OX6hFKg5k1qMcND0KgBjOL : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_D6ahSbuE2MkPP5caA8ZQbU);
                return;
            }

            [n1.ElementAttribute(TracingId = 218935U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "D6ahSbuE2MkPP5caA8ZQbU", Name = "Preprocessor", IsManaged = true, IsAutoGenerated = true)]
            public n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __p_D6ahSbuE2MkPP5caA8ZQbU;
            public __OX6hFKg5k1qMcND0KgBjOL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OX6hFKg5k1qMcND0KgBjOL(__OX6hFKg5k1qMcND0KgBjOL other): base(other)
            {
                this.__p_D6ahSbuE2MkPP5caA8ZQbU = other.__p_D6ahSbuE2MkPP5caA8ZQbU;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_D6ahSbuE2MkPP5caA8ZQbU", in __p_D6ahSbuE2MkPP5caA8ZQbU));
            }

            internal __OX6hFKg5k1qMcND0KgBjOL __WITH__(n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __p_D6ahSbuE2MkPP5caA8ZQbU)
            {
                __OX6hFKg5k1qMcND0KgBjOL that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_D6ahSbuE2MkPP5caA8ZQbU != this.__p_D6ahSbuE2MkPP5caA8ZQbU ? new __OX6hFKg5k1qMcND0KgBjOL(this)
                    {__p_D6ahSbuE2MkPP5caA8ZQbU = __p_D6ahSbuE2MkPP5caA8ZQbU} : that_0;
                else
                {
                    this.__p_D6ahSbuE2MkPP5caA8ZQbU = __p_D6ahSbuE2MkPP5caA8ZQbU;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "VX5c4ZMN0FIOpUQyzU2DAO", Name = "__VX5c4ZMN0FIOpUQyzU2DAO")]
        [n2.SerializableAttribute]
        public class __VX5c4ZMN0FIOpUQyzU2DAO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Upw21pW1kUPL8JBzrvORyi);
                return;
            }

            [n1.ElementAttribute(TracingId = 218996U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "Upw21pW1kUPL8JBzrvORyi", Name = "Preprocessor", IsManaged = true, IsAutoGenerated = true)]
            public n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __p_Upw21pW1kUPL8JBzrvORyi;
            public __VX5c4ZMN0FIOpUQyzU2DAO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VX5c4ZMN0FIOpUQyzU2DAO(__VX5c4ZMN0FIOpUQyzU2DAO other): base(other)
            {
                this.__p_Upw21pW1kUPL8JBzrvORyi = other.__p_Upw21pW1kUPL8JBzrvORyi;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Upw21pW1kUPL8JBzrvORyi", in __p_Upw21pW1kUPL8JBzrvORyi));
            }

            internal __VX5c4ZMN0FIOpUQyzU2DAO __WITH__(n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __p_Upw21pW1kUPL8JBzrvORyi)
            {
                __VX5c4ZMN0FIOpUQyzU2DAO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Upw21pW1kUPL8JBzrvORyi != this.__p_Upw21pW1kUPL8JBzrvORyi ? new __VX5c4ZMN0FIOpUQyzU2DAO(this)
                    {__p_Upw21pW1kUPL8JBzrvORyi = __p_Upw21pW1kUPL8JBzrvORyi} : that_0;
                else
                {
                    this.__p_Upw21pW1kUPL8JBzrvORyi = __p_Upw21pW1kUPL8JBzrvORyi;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "DXpLxGxSH8iLkbJpvlTYHv", Name = "__DXpLxGxSH8iLkbJpvlTYHv")]
        [n2.SerializableAttribute]
        public class __DXpLxGxSH8iLkbJpvlTYHv : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CE921TBEFimNeh522NqNgi);
                return;
            }

            [n1.ElementAttribute(TracingId = 219113U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "CE921TBEFimNeh522NqNgi", Name = "SearchWithoutPreprocessor", IsManaged = true, IsAutoGenerated = true)]
            public n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ __p_CE921TBEFimNeh522NqNgi;
            public __DXpLxGxSH8iLkbJpvlTYHv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DXpLxGxSH8iLkbJpvlTYHv(__DXpLxGxSH8iLkbJpvlTYHv other): base(other)
            {
                this.__p_CE921TBEFimNeh522NqNgi = other.__p_CE921TBEFimNeh522NqNgi;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CE921TBEFimNeh522NqNgi", in __p_CE921TBEFimNeh522NqNgi));
            }

            internal __DXpLxGxSH8iLkbJpvlTYHv __WITH__(n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ __p_CE921TBEFimNeh522NqNgi)
            {
                __DXpLxGxSH8iLkbJpvlTYHv that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CE921TBEFimNeh522NqNgi != this.__p_CE921TBEFimNeh522NqNgi ? new __DXpLxGxSH8iLkbJpvlTYHv(this)
                    {__p_CE921TBEFimNeh522NqNgi = __p_CE921TBEFimNeh522NqNgi} : that_0;
                else
                {
                    this.__p_CE921TBEFimNeh522NqNgi = __p_CE921TBEFimNeh522NqNgi;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 219292U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "QTgqAnyg4VMNspLitcV86m", Name = "SpliceSearchResult_QTgqAnyg4VMNspLitcV86m")]
    [n2.SerializableAttribute]
    public class SpliceSearchResult_QTgqAnyg4VMNspLitcV86m : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m Create(n1.NodeContext Node_Context)
        {
            var instance = new SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m CreateDefault()
        {
            var instance = new SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m Update(n6.IEnumerable<n9.SearchResult_R> Input_In, float Minimum_Score_In, out n5.Spread<string> Values_Out, out n5.Spread<int> Indices_Out, out n5.Spread<float> Scores_Out, out n5.Spread<n5.Spread<n9.Similarity_R>> Similarities_Out)
        {
            var builder_11 = n4.CollectionBuilders.GetBuilder(this.__cp_HbzrTxzqnfvNOkme2TfRZy, 16);
            n5.Spread<string> output_12;
            var builder_13 = n4.CollectionBuilders.GetBuilder(this.__cp_RS2T3u5GjYFM5RrapV7MLK, 16);
            n5.Spread<int> output_14;
            var builder_15 = n4.CollectionBuilders.GetBuilder(this.__cp_K96z6GZkuHwPlRVFSdKJqP, 16);
            n5.Spread<float> output_16;
            var builder_17 = n4.CollectionBuilders.GetBuilder(this.__cp_Ic5xHQcOWqvOqGM3p9cwrt, 16);
            n5.Spread<n5.Spread<n9.Similarity_R>> output_18;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Input_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    var Output_9 = splicer_1.Split(Value_Out: out string Value_5, Index_Out: out int Index_6, Similarities_Out: out n5.Spread<n9.Similarity_R> Similarities_7, Score_Out: out float Score_8);
                    var Result_10 = Score_8 >= Minimum_Score_In;
                    if (Result_10)
                    {
                        builder_11.Add(Value_5);
                        builder_13.Add(Index_6);
                        builder_15.Add(Score_8);
                        builder_17.Add(Similarities_7);
                    }

                    i_2++;
                }
            }
            finally
            {
                output_12 = builder_11.Commit();
                output_14 = builder_13.Commit();
                output_16 = builder_15.Commit();
                output_18 = builder_17.Commit();
            }

            Values_Out = output_12;
            Indices_Out = output_14;
            Scores_Out = output_16;
            Similarities_Out = output_18;
            n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = output_12 != this.__cp_HbzrTxzqnfvNOkme2TfRZy || output_14 != this.__cp_RS2T3u5GjYFM5RrapV7MLK || output_16 != this.__cp_K96z6GZkuHwPlRVFSdKJqP || output_18 != this.__cp_Ic5xHQcOWqvOqGM3p9cwrt ? new SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(this)
                {__cp_HbzrTxzqnfvNOkme2TfRZy = output_12, __cp_RS2T3u5GjYFM5RrapV7MLK = output_14, __cp_K96z6GZkuHwPlRVFSdKJqP = output_16, __cp_Ic5xHQcOWqvOqGM3p9cwrt = output_18} : that_19;
            else
            {
                this.__cp_HbzrTxzqnfvNOkme2TfRZy = output_12;
                this.__cp_RS2T3u5GjYFM5RrapV7MLK = output_14;
                this.__cp_K96z6GZkuHwPlRVFSdKJqP = output_16;
                this.__cp_Ic5xHQcOWqvOqGM3p9cwrt = output_18;
            }

            return that_19;
        }

        public n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m that_0 = this;
            this.__cp_HbzrTxzqnfvNOkme2TfRZy = n8._Operations_.CreateDefault<string>();
            this.__cp_RS2T3u5GjYFM5RrapV7MLK = n8._Operations_.CreateDefault<int>();
            this.__cp_K96z6GZkuHwPlRVFSdKJqP = n8._Operations_.CreateDefault<float>();
            this.__cp_Ic5xHQcOWqvOqGM3p9cwrt = n8._Operations_.CreateDefault<n5.Spread<n9.Similarity_R>>();
            return that_0;
        }

        public n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m __CreateDefault__()
        {
            n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m that_0 = this;
            this.__cp_HbzrTxzqnfvNOkme2TfRZy = n8._Operations_.CreateDefault<string>();
            this.__cp_RS2T3u5GjYFM5RrapV7MLK = n8._Operations_.CreateDefault<int>();
            this.__cp_K96z6GZkuHwPlRVFSdKJqP = n8._Operations_.CreateDefault<float>();
            this.__cp_Ic5xHQcOWqvOqGM3p9cwrt = n8._Operations_.CreateDefault<n5.Spread<n9.Similarity_R>>();
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

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __cp_HbzrTxzqnfvNOkme2TfRZy;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<int> __cp_RS2T3u5GjYFM5RrapV7MLK;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<float> __cp_K96z6GZkuHwPlRVFSdKJqP;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<n5.Spread<n9.Similarity_R>> __cp_Ic5xHQcOWqvOqGM3p9cwrt;
        public SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(SpliceSearchResult_QTgqAnyg4VMNspLitcV86m other): base(other)
        {
            this.__cp_HbzrTxzqnfvNOkme2TfRZy = other.__cp_HbzrTxzqnfvNOkme2TfRZy;
            this.__cp_RS2T3u5GjYFM5RrapV7MLK = other.__cp_RS2T3u5GjYFM5RrapV7MLK;
            this.__cp_K96z6GZkuHwPlRVFSdKJqP = other.__cp_K96z6GZkuHwPlRVFSdKJqP;
            this.__cp_Ic5xHQcOWqvOqGM3p9cwrt = other.__cp_Ic5xHQcOWqvOqGM3p9cwrt;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_HbzrTxzqnfvNOkme2TfRZy", in __cp_HbzrTxzqnfvNOkme2TfRZy), n1.CompilationHelper.GetValueOrExisting(values, "__cp_RS2T3u5GjYFM5RrapV7MLK", in __cp_RS2T3u5GjYFM5RrapV7MLK), n1.CompilationHelper.GetValueOrExisting(values, "__cp_K96z6GZkuHwPlRVFSdKJqP", in __cp_K96z6GZkuHwPlRVFSdKJqP), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Ic5xHQcOWqvOqGM3p9cwrt", in __cp_Ic5xHQcOWqvOqGM3p9cwrt));
        }

        internal SpliceSearchResult_QTgqAnyg4VMNspLitcV86m __WITH__(n5.Spread<string> __cp_HbzrTxzqnfvNOkme2TfRZy, n5.Spread<int> __cp_RS2T3u5GjYFM5RrapV7MLK, n5.Spread<float> __cp_K96z6GZkuHwPlRVFSdKJqP, n5.Spread<n5.Spread<n9.Similarity_R>> __cp_Ic5xHQcOWqvOqGM3p9cwrt)
        {
            n3.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cp_HbzrTxzqnfvNOkme2TfRZy != this.__cp_HbzrTxzqnfvNOkme2TfRZy || __cp_RS2T3u5GjYFM5RrapV7MLK != this.__cp_RS2T3u5GjYFM5RrapV7MLK || __cp_K96z6GZkuHwPlRVFSdKJqP != this.__cp_K96z6GZkuHwPlRVFSdKJqP || __cp_Ic5xHQcOWqvOqGM3p9cwrt != this.__cp_Ic5xHQcOWqvOqGM3p9cwrt ? new SpliceSearchResult_QTgqAnyg4VMNspLitcV86m(this)
                {__cp_HbzrTxzqnfvNOkme2TfRZy = __cp_HbzrTxzqnfvNOkme2TfRZy, __cp_RS2T3u5GjYFM5RrapV7MLK = __cp_RS2T3u5GjYFM5RrapV7MLK, __cp_K96z6GZkuHwPlRVFSdKJqP = __cp_K96z6GZkuHwPlRVFSdKJqP, __cp_Ic5xHQcOWqvOqGM3p9cwrt = __cp_Ic5xHQcOWqvOqGM3p9cwrt} : that_0;
            else
            {
                this.__cp_HbzrTxzqnfvNOkme2TfRZy = __cp_HbzrTxzqnfvNOkme2TfRZy;
                this.__cp_RS2T3u5GjYFM5RrapV7MLK = __cp_RS2T3u5GjYFM5RrapV7MLK;
                this.__cp_K96z6GZkuHwPlRVFSdKJqP = __cp_K96z6GZkuHwPlRVFSdKJqP;
                this.__cp_Ic5xHQcOWqvOqGM3p9cwrt = __cp_Ic5xHQcOWqvOqGM3p9cwrt;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 220980U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "QNoCSs9ybjcOpshRtevLwJ", Name = "SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ")]
    [n2.SerializableAttribute]
    public class SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ Create(n1.NodeContext Node_Context)
        {
            var instance = new SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ CreateDefault()
        {
            var instance = new SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ Update(n5.Spread<string> Original_Strings_In, n6.IEnumerable<n6.IEnumerable<string>> List_to_Search_In, [n4.SerializedDefaultValueAttribute("", false)] n6.IEnumerable<string> Search_String_In, [n4.SerializedDefaultValueAttribute("0.6", false)] float Similarity_Threshold_In, n13.IStringMetric Algorithm_In, out n5.Spread<n9.SearchResult_R> Output_Out)
        {
            n12._Operations_.Any<string>(Input_In: Search_String_In, Result_Out: out bool Result_0);
            n5.Spread<n9.SearchResult_R> __auto_1;
            var state_2 = n1.CompilationHelper.Restore<__DNmicbAPjz4NO7fmSrBJDN>(this.__if_Q2DlIzZvlCAPBL07wxeL53, __GetContext__());
            if (Result_0)
            {
                if (state_2 == null)
                {
                    state_2 = new __DNmicbAPjz4NO7fmSrBJDN(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_P4Hw73BERE5LBtKrwnpzJQ = n8._Operations_.CreateDefault<n9.SearchResult_R>()};
                }

                n5.SpreadBuilder<n9.Similarity_R> accumulator_4 = n22._Operations_.CreateDefault<n9.Similarity_R>();
                var manager_51 = state_2.__loop_G2bovXfdSIrLyi0feQHCd3 ?? new n10.ImmutableLifetimeManager();
                var iterator_52 = manager_51.GetIterator(__GetContext__());
                var builder_53 = n4.CollectionBuilders.GetBuilder(state_2.__cp_P4Hw73BERE5LBtKrwnpzJQ, 16);
                n5.Spread<n9.SearchResult_R> output_54;
                try
                {
                    var i_6 = 0;
                    foreach (var item_3 in List_to_Search_In)
                    {
                        var splicer_5 = item_3;
                        var i_local_7 = i_6;
                        __E9rSrbPqHZlQN5fXLojG5i state_8;
                        if (!iterator_52.MoveNext(out state_8))
                        {
                            iterator_52.Add(state_8 = new __E9rSrbPqHZlQN5fXLojG5i(__GetContext__(), n1.VLObject.NewIdentity()));
                        }

                        string Default_Value_9 = "";
                        n8._Operations_.GetSlice<string>(Input_In: Original_Strings_In, Default_Value_In: Default_Value_9, Index_In: i_local_7, Result_Out: out string Result_10);
                        n5.SpreadBuilder<n9.Similarity_R> accumulator_12 = accumulator_4;
                        var manager_42 = state_8.__loop_K69KBKRAQ5tPdL0ptzp89A ?? new n10.ImmutableLifetimeManager();
                        var iterator_43 = manager_42.GetIterator(__GetContext__());
                        try
                        {
                            var i_14 = 0;
                            foreach (var item_11 in Search_String_In)
                            {
                                var splicer_13 = item_11;
                                var i_local_15 = i_14;
                                __SNco5xRE7JXMWTu2WzSBi6 state_16;
                                if (!iterator_43.MoveNext(out state_16))
                                {
                                    iterator_43.Add(state_16 = new __SNco5xRE7JXMWTu2WzSBi6(__GetContext__(), n1.VLObject.NewIdentity()));
                                }

                                var Length_17 = splicer_13.Length;
                                n5.SpreadBuilder<n9.Similarity_R> accumulator_19 = accumulator_12;
                                var manager_40 = state_16.__loop_UHAJECJtqdxO3TmqCvXl6x ?? new n10.ImmutableLifetimeManager();
                                var iterator_41 = manager_40.GetIterator(__GetContext__());
                                try
                                {
                                    var i_21 = 0;
                                    foreach (var item_18 in splicer_5)
                                    {
                                        var splicer_20 = item_18;
                                        var i_local_22 = i_21;
                                        __CwI0idP4pz8M2NJqFjMbeT state_23;
                                        if (!iterator_41.MoveNext(out state_23))
                                        {
                                            iterator_41.Add(state_23 = new __CwI0idP4pz8M2NJqFjMbeT(__GetContext__(), n1.VLObject.NewIdentity()));
                                        }

                                        n20._Operations_.GetSimilarity(Input_In: Algorithm_In, First_Word_In: splicer_20, Second_Word_In: splicer_13, Output_Out: out n13.IStringMetric Output_24, Result_Out: out float Result_25);
                                        var Result_26 = Result_25 < Similarity_Threshold_In;
                                        float __auto_27;
                                        var state_28 = n1.CompilationHelper.Restore<__D2IVuAS5YW2MW09W2NTJAi>(state_23.__if_KjtEdXkQoGaN64kw7QXJ3i, __GetContext__());
                                        if (Result_26)
                                        {
                                            if (state_28 == null)
                                            {
                                                state_28 = new __D2IVuAS5YW2MW09W2NTJAi(__GetContext__(), n1.VLObject.NewIdentity())
                                                {__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = n8._Operations_.CreateDefault<float>()};
                                            }

                                            float __pad_D1kGRPt5jBTNMdS417KxPS_29 = __slot_D1kGRPt5jBTNMdS417KxPS;
                                            var Result_30 = splicer_20.Contains(value: splicer_13);
                                            int Index_31 = n2.Convert.ToInt32(Result_30);
                                            var Output_32 = Similarity_Threshold_In + __pad_D1kGRPt5jBTNMdS417KxPS_29;
                                            var builder_33 = n4.CollectionBuilders.GetBuilder(state_28.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt, 2);
                                            builder_33.Add(Result_25);
                                            builder_33.Add(Output_32);
                                            var __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt_34 = builder_33.Commit();
                                            n24._Operations_.Switch<float, n11.__AdaptiveImplementations__QDVtT0Z8fBYMjLwlcbJ0Wv>(Index_In: Index_31, Input_In: __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt_34, Output_Out: out float Output_35);
                                            __auto_27 = Output_35;
                                            if (state_28.__GetContext__().IsImmutable)
                                                state_28 = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt_34 != state_28.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt ? new __D2IVuAS5YW2MW09W2NTJAi(state_28)
                                                {__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt_34} : state_28;
                                            else
                                            {
                                                state_28.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt_34;
                                            }
                                        }
                                        else
                                        {
                                            __auto_27 = Result_25;
                                        }

                                        n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "EgUhyAHtySWLkfv9HtSfsM", 221457U);
                                        var Output_37 = n9.Similarity_R.Create(Node_Context: Node_Context_36, Similarity_In: __auto_27, Search_Word_Length_In: Length_17, Search_Word_Index_In: i_local_15, List_Word_Index_In: i_local_22);
                                        var Result_38 = __auto_27 > Similarity_Threshold_In;
                                        var Output_39 = accumulator_19;
                                        if (Result_38)
                                        {
                                            n22._Operations_.Add<n9.Similarity_R>(Input_In: accumulator_19, Item_In: Output_37, Output_Out: out Output_39);
                                        }

                                        if (state_23.__GetContext__().IsImmutable)
                                            state_23 = state_28 != state_23.__if_KjtEdXkQoGaN64kw7QXJ3i ? new __CwI0idP4pz8M2NJqFjMbeT(state_23)
                                            {__if_KjtEdXkQoGaN64kw7QXJ3i = state_28} : state_23;
                                        else
                                        {
                                            state_23.__if_KjtEdXkQoGaN64kw7QXJ3i = state_28;
                                        }

                                        iterator_41.Update(state_23);
                                        accumulator_19 = Output_39;
                                        i_21++;
                                    }
                                }
                                finally
                                {
                                    manager_40 = iterator_41.Commit();
                                }

                                if (state_16.__GetContext__().IsImmutable)
                                    state_16 = manager_40 != state_16.__loop_UHAJECJtqdxO3TmqCvXl6x ? new __SNco5xRE7JXMWTu2WzSBi6(state_16)
                                    {__loop_UHAJECJtqdxO3TmqCvXl6x = manager_40} : state_16;
                                else
                                {
                                    state_16.__loop_UHAJECJtqdxO3TmqCvXl6x = manager_40;
                                }

                                iterator_43.Update(state_16);
                                accumulator_12 = accumulator_19;
                                i_14++;
                            }
                        }
                        finally
                        {
                            manager_42 = iterator_43.Commit();
                        }

                        n22._Operations_.ToSpread<n9.Similarity_R>(Input_In: accumulator_12, Output_Out: out n5.SpreadBuilder<n9.Similarity_R> Output_44, Result_Out: out n5.Spread<n9.Similarity_R> Result_45);
                        n1.NodeContext Node_Context_46 = __GetContext__().CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "PZqROHhnVtPOAb6URBjj9I", 221521U);
                        var Output_47 = n9.SearchResult_R.Create(Node_Context: Node_Context_46, Value_In: Result_10, Index_In: i_local_7, Similarities_In: Result_45);
                        n22._Operations_.Clear<n9.Similarity_R>(Input_In: Output_44, Output_Out: out n5.SpreadBuilder<n9.Similarity_R> Output_48);
                        n6.IEnumerable<n9.Similarity_R> Input_49 = (n6.IEnumerable<n9.Similarity_R>)Result_45;
                        n12._Operations_.Any<n9.Similarity_R>(Input_In: Input_49, Result_Out: out bool Result_50);
                        if (state_8.__GetContext__().IsImmutable)
                            state_8 = manager_42 != state_8.__loop_K69KBKRAQ5tPdL0ptzp89A ? new __E9rSrbPqHZlQN5fXLojG5i(state_8)
                            {__loop_K69KBKRAQ5tPdL0ptzp89A = manager_42} : state_8;
                        else
                        {
                            state_8.__loop_K69KBKRAQ5tPdL0ptzp89A = manager_42;
                        }

                        iterator_52.Update(state_8);
                        if (Result_50)
                        {
                            builder_53.Add(Output_47);
                        }
                        else
                            iterator_52.Remove();
                        accumulator_4 = Output_48;
                        i_6++;
                    }
                }
                finally
                {
                    manager_51 = iterator_52.Commit();
                    output_54 = builder_53.Commit();
                }

                n6.IEnumerable<n9.SearchResult_R> Input_55 = (n6.IEnumerable<n9.SearchResult_R>)output_54;
                n25._Operations_.CalculateScores(Input_In: Input_55, Result_Out: out n5.Spread<n9.SearchResult_R> Result_56);
                __auto_1 = Result_56;
                if (state_2.__GetContext__().IsImmutable)
                    state_2 = manager_51 != state_2.__loop_G2bovXfdSIrLyi0feQHCd3 || output_54 != state_2.__cp_P4Hw73BERE5LBtKrwnpzJQ ? new __DNmicbAPjz4NO7fmSrBJDN(state_2)
                    {__loop_G2bovXfdSIrLyi0feQHCd3 = manager_51, __cp_P4Hw73BERE5LBtKrwnpzJQ = output_54} : state_2;
                else
                {
                    state_2.__loop_G2bovXfdSIrLyi0feQHCd3 = manager_51;
                    state_2.__cp_P4Hw73BERE5LBtKrwnpzJQ = output_54;
                }
            }
            else
            {
                __auto_1 = n8._Operations_.CreateDefault<n9.SearchResult_R>();
            }

            Output_Out = __auto_1;
            n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ that_57 = this;
            if (this.__GetContext__().IsImmutable)
                that_57 = state_2 != this.__if_Q2DlIzZvlCAPBL07wxeL53 ? new SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(this)
                {__if_Q2DlIzZvlCAPBL07wxeL53 = state_2} : that_57;
            else
            {
                this.__if_Q2DlIzZvlCAPBL07wxeL53 = state_2;
            }

            return that_57;
        }

        public n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ that_0 = this;
            this.__if_Q2DlIzZvlCAPBL07wxeL53 = default(n2.Object);
            return that_0;
        }

        public n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ __CreateDefault__()
        {
            n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ that_0 = this;
            this.__if_Q2DlIzZvlCAPBL07wxeL53 = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Q2DlIzZvlCAPBL07wxeL53);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 221450U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "D1kGRPt5jBTNMdS417KxPS", Name = "__slot_D1kGRPt5jBTNMdS417KxPS")]
        public static float __slot_D1kGRPt5jBTNMdS417KxPS = 0.01F;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Q2DlIzZvlCAPBL07wxeL53;
        static SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ()
        {
        }

        public SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ other): base(other)
        {
            this.__if_Q2DlIzZvlCAPBL07wxeL53 = other.__if_Q2DlIzZvlCAPBL07wxeL53;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_Q2DlIzZvlCAPBL07wxeL53", in __if_Q2DlIzZvlCAPBL07wxeL53));
        }

        internal SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ __WITH__(n2.Object __if_Q2DlIzZvlCAPBL07wxeL53)
        {
            n3.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_Q2DlIzZvlCAPBL07wxeL53 != this.__if_Q2DlIzZvlCAPBL07wxeL53 ? new SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ(this)
                {__if_Q2DlIzZvlCAPBL07wxeL53 = __if_Q2DlIzZvlCAPBL07wxeL53} : that_0;
            else
            {
                this.__if_Q2DlIzZvlCAPBL07wxeL53 = __if_Q2DlIzZvlCAPBL07wxeL53;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "DNmicbAPjz4NO7fmSrBJDN", Name = "__DNmicbAPjz4NO7fmSrBJDN")]
        [n2.SerializableAttribute]
        public class __DNmicbAPjz4NO7fmSrBJDN : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_G2bovXfdSIrLyi0feQHCd3);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n10.ImmutableLifetimeManager __loop_G2bovXfdSIrLyi0feQHCd3;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n9.SearchResult_R> __cp_P4Hw73BERE5LBtKrwnpzJQ;
            public __DNmicbAPjz4NO7fmSrBJDN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DNmicbAPjz4NO7fmSrBJDN(__DNmicbAPjz4NO7fmSrBJDN other): base(other)
            {
                this.__loop_G2bovXfdSIrLyi0feQHCd3 = other.__loop_G2bovXfdSIrLyi0feQHCd3;
                this.__cp_P4Hw73BERE5LBtKrwnpzJQ = other.__cp_P4Hw73BERE5LBtKrwnpzJQ;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_G2bovXfdSIrLyi0feQHCd3", in __loop_G2bovXfdSIrLyi0feQHCd3), n1.CompilationHelper.GetValueOrExisting(values, "__cp_P4Hw73BERE5LBtKrwnpzJQ", in __cp_P4Hw73BERE5LBtKrwnpzJQ));
            }

            internal __DNmicbAPjz4NO7fmSrBJDN __WITH__(n10.ImmutableLifetimeManager __loop_G2bovXfdSIrLyi0feQHCd3, n5.Spread<n9.SearchResult_R> __cp_P4Hw73BERE5LBtKrwnpzJQ)
            {
                __DNmicbAPjz4NO7fmSrBJDN that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_G2bovXfdSIrLyi0feQHCd3 != this.__loop_G2bovXfdSIrLyi0feQHCd3 || __cp_P4Hw73BERE5LBtKrwnpzJQ != this.__cp_P4Hw73BERE5LBtKrwnpzJQ ? new __DNmicbAPjz4NO7fmSrBJDN(this)
                    {__loop_G2bovXfdSIrLyi0feQHCd3 = __loop_G2bovXfdSIrLyi0feQHCd3, __cp_P4Hw73BERE5LBtKrwnpzJQ = __cp_P4Hw73BERE5LBtKrwnpzJQ} : that_0;
                else
                {
                    this.__loop_G2bovXfdSIrLyi0feQHCd3 = __loop_G2bovXfdSIrLyi0feQHCd3;
                    this.__cp_P4Hw73BERE5LBtKrwnpzJQ = __cp_P4Hw73BERE5LBtKrwnpzJQ;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "E9rSrbPqHZlQN5fXLojG5i", Name = "__E9rSrbPqHZlQN5fXLojG5i")]
        [n2.SerializableAttribute]
        public class __E9rSrbPqHZlQN5fXLojG5i : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_K69KBKRAQ5tPdL0ptzp89A);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n10.ImmutableLifetimeManager __loop_K69KBKRAQ5tPdL0ptzp89A;
            public __E9rSrbPqHZlQN5fXLojG5i(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __E9rSrbPqHZlQN5fXLojG5i(__E9rSrbPqHZlQN5fXLojG5i other): base(other)
            {
                this.__loop_K69KBKRAQ5tPdL0ptzp89A = other.__loop_K69KBKRAQ5tPdL0ptzp89A;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_K69KBKRAQ5tPdL0ptzp89A", in __loop_K69KBKRAQ5tPdL0ptzp89A));
            }

            internal __E9rSrbPqHZlQN5fXLojG5i __WITH__(n10.ImmutableLifetimeManager __loop_K69KBKRAQ5tPdL0ptzp89A)
            {
                __E9rSrbPqHZlQN5fXLojG5i that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_K69KBKRAQ5tPdL0ptzp89A != this.__loop_K69KBKRAQ5tPdL0ptzp89A ? new __E9rSrbPqHZlQN5fXLojG5i(this)
                    {__loop_K69KBKRAQ5tPdL0ptzp89A = __loop_K69KBKRAQ5tPdL0ptzp89A} : that_0;
                else
                {
                    this.__loop_K69KBKRAQ5tPdL0ptzp89A = __loop_K69KBKRAQ5tPdL0ptzp89A;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "SNco5xRE7JXMWTu2WzSBi6", Name = "__SNco5xRE7JXMWTu2WzSBi6")]
        [n2.SerializableAttribute]
        public class __SNco5xRE7JXMWTu2WzSBi6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_UHAJECJtqdxO3TmqCvXl6x);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n10.ImmutableLifetimeManager __loop_UHAJECJtqdxO3TmqCvXl6x;
            public __SNco5xRE7JXMWTu2WzSBi6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SNco5xRE7JXMWTu2WzSBi6(__SNco5xRE7JXMWTu2WzSBi6 other): base(other)
            {
                this.__loop_UHAJECJtqdxO3TmqCvXl6x = other.__loop_UHAJECJtqdxO3TmqCvXl6x;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_UHAJECJtqdxO3TmqCvXl6x", in __loop_UHAJECJtqdxO3TmqCvXl6x));
            }

            internal __SNco5xRE7JXMWTu2WzSBi6 __WITH__(n10.ImmutableLifetimeManager __loop_UHAJECJtqdxO3TmqCvXl6x)
            {
                __SNco5xRE7JXMWTu2WzSBi6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_UHAJECJtqdxO3TmqCvXl6x != this.__loop_UHAJECJtqdxO3TmqCvXl6x ? new __SNco5xRE7JXMWTu2WzSBi6(this)
                    {__loop_UHAJECJtqdxO3TmqCvXl6x = __loop_UHAJECJtqdxO3TmqCvXl6x} : that_0;
                else
                {
                    this.__loop_UHAJECJtqdxO3TmqCvXl6x = __loop_UHAJECJtqdxO3TmqCvXl6x;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "CwI0idP4pz8M2NJqFjMbeT", Name = "__CwI0idP4pz8M2NJqFjMbeT")]
        [n2.SerializableAttribute]
        public class __CwI0idP4pz8M2NJqFjMbeT : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_KjtEdXkQoGaN64kw7QXJ3i);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_KjtEdXkQoGaN64kw7QXJ3i;
            public __CwI0idP4pz8M2NJqFjMbeT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CwI0idP4pz8M2NJqFjMbeT(__CwI0idP4pz8M2NJqFjMbeT other): base(other)
            {
                this.__if_KjtEdXkQoGaN64kw7QXJ3i = other.__if_KjtEdXkQoGaN64kw7QXJ3i;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_KjtEdXkQoGaN64kw7QXJ3i", in __if_KjtEdXkQoGaN64kw7QXJ3i));
            }

            internal __CwI0idP4pz8M2NJqFjMbeT __WITH__(n2.Object __if_KjtEdXkQoGaN64kw7QXJ3i)
            {
                __CwI0idP4pz8M2NJqFjMbeT that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_KjtEdXkQoGaN64kw7QXJ3i != this.__if_KjtEdXkQoGaN64kw7QXJ3i ? new __CwI0idP4pz8M2NJqFjMbeT(this)
                    {__if_KjtEdXkQoGaN64kw7QXJ3i = __if_KjtEdXkQoGaN64kw7QXJ3i} : that_0;
                else
                {
                    this.__if_KjtEdXkQoGaN64kw7QXJ3i = __if_KjtEdXkQoGaN64kw7QXJ3i;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "D2IVuAS5YW2MW09W2NTJAi", Name = "__D2IVuAS5YW2MW09W2NTJAi")]
        [n2.SerializableAttribute]
        public class __D2IVuAS5YW2MW09W2NTJAi : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = default(n5.Spread<float>);
            public __D2IVuAS5YW2MW09W2NTJAi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __D2IVuAS5YW2MW09W2NTJAi(__D2IVuAS5YW2MW09W2NTJAi other): base(other)
            {
                this.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = other.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt", in __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt));
            }

            internal __D2IVuAS5YW2MW09W2NTJAi __WITH__(n5.Spread<float> __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt)
            {
                __D2IVuAS5YW2MW09W2NTJAi that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt != this.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt ? new __D2IVuAS5YW2MW09W2NTJAi(this)
                    {__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt} : that_0;
                else
                {
                    this.__pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt = __pin_group_Input_In_HXAspULKqrVMAI0BKId5Gt;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 221789U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "Bhs4SL1pMxOPqTWtYYsSWP", Name = "VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP")]
    [n2.SerializableAttribute]
    public class VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP CreateDefault()
        {
            var instance = new VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP Update()
        {
            return this;
        }

        public n3.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP __CreateDefault__()
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

        public VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP(VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_FuzzySearch_.Text.FuzzySearch.Scoring
{
    [n1.ElementAttribute(TracingId = 218876U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CalculateScores(n6.IEnumerable<n9.SearchResult_R> Input_In, out n5.Spread<n9.SearchResult_R> Result_Out)
        {
            n5.Spread<n9.SearchResult_R> __cp_CTPy2RygCX0Mwu8Wr1O2Q3 = n8._Operations_.CreateDefault<n9.SearchResult_R>();
            n5.Spread<n9.SearchResult_R> __cp_DGEn76jFCdyOvBlI8MGfqA = n8._Operations_.CreateDefault<n9.SearchResult_R>();
            string __pad_GvSAxRaQXwTNbXuj9hKnVL_0 = __slot_GvSAxRaQXwTNbXuj9hKnVL;
            string __pad_OwToJWKJHN0NGmiq7wD0u8_1 = __slot_OwToJWKJHN0NGmiq7wD0u8;
            var builder_23 = n4.CollectionBuilders.GetBuilder(__cp_CTPy2RygCX0Mwu8Wr1O2Q3, 16);
            n5.Spread<n9.SearchResult_R> output_24;
            try
            {
                var i_4 = 0;
                foreach (var item_2 in Input_In)
                {
                    var splicer_3 = item_2;
                    var i_local_5 = i_4;
                    n5.Spread<float> __cp_MbBeUGcrRqrPuQVaix2XMl = n8._Operations_.CreateDefault<float>();
                    var Output_7 = splicer_3.Similarities_(Similarities_Out: out n5.Spread<n9.Similarity_R> Similarities_6);
                    var builder_19 = n4.CollectionBuilders.GetBuilder(__cp_MbBeUGcrRqrPuQVaix2XMl, 16);
                    n5.Spread<float> output_20;
                    try
                    {
                        var i_10 = 0;
                        foreach (var item_8 in n4.CollectionExtensions.AsSpan(Similarities_6))
                        {
                            var splicer_9 = item_8;
                            var i_local_11 = i_10;
                            var Output_16 = splicer_9.Split(Similarity_Out: out float Similarity_12, Search_Word_Length_Out: out int Search_Word_Length_13, Search_Word_Index_Out: out int Search_Word_Index_14, List_Word_Index_Out: out int List_Word_Index_15);
                            float Input_2_17 = (float)Search_Word_Length_13;
                            var Output_18 = Similarity_12 * Input_2_17;
                            builder_19.Add(Output_18);
                            i_10++;
                        }
                    }
                    finally
                    {
                        output_20 = builder_19.Commit();
                    }

                    n12._Operations_.Sum<n5.Spread<float>, float, n11.__AdaptiveImplementations__QDVtT0Z8fBYMjLwlcbJ0Wv>(Input_In: output_20, Result_Out: out float Result_21);
                    var Output_22 = splicer_3.SetScore(Score_In: Result_21);
                    builder_23.Add(Output_22);
                    i_4++;
                }
            }
            finally
            {
                output_24 = builder_23.Commit();
            }

            var __fallback___25 = n1.ServiceRegistry.Current;
            n12._Operations_.Max_Selector<n5.Spread<n9.SearchResult_R>, n9.SearchResult_R, float, n11.__AdaptiveImplementations__QDVtT0Z8fBYMjLwlcbJ0Wv>(Input_In: output_24, Selector_In: (n9.SearchResult_R Input_In_27) =>
            {
                using var __current_26 = __fallback___25.MakeCurrentIfNone();
                var Output_29 = Input_In_27.Score_(Score_Out: out float Score_28);
                return Score_28;
            }

            , Result_Out: out float Result_30);
            var builder_39 = n4.CollectionBuilders.GetBuilder(__cp_DGEn76jFCdyOvBlI8MGfqA, 16);
            n5.Spread<n9.SearchResult_R> output_40;
            try
            {
                var i_33 = 0;
                foreach (var item_31 in n4.CollectionExtensions.AsSpan(output_24))
                {
                    var splicer_32 = item_31;
                    var i_local_34 = i_33;
                    var Output_36 = splicer_32.Score_(Score_Out: out float Score_35);
                    var Output_37 = (float)Score_35 / Result_30;
                    var Output_38 = splicer_32.SetScore(Score_In: Output_37);
                    builder_39.Add(Output_38);
                    i_33++;
                }
            }
            finally
            {
                output_40 = builder_39.Commit();
            }

            n6.IEnumerable<n9.SearchResult_R> Input_41 = (n6.IEnumerable<n9.SearchResult_R>)output_40;
            n12._Operations_.OrderByDescending<n9.SearchResult_R, float>(Input_In: Input_41, Key_Selector_In: (n9.SearchResult_R Input_In_43) =>
            {
                using var __current_42 = __fallback___25.MakeCurrentIfNone();
                var Output_45 = Input_In_43.Score_(Score_Out: out float Score_44);
                return Score_44;
            }

            , Result_Out: out n16.IOrderedEnumerable<n9.SearchResult_R> Result_46);
            n6.IEnumerable<n9.SearchResult_R> Input_47 = (n6.IEnumerable<n9.SearchResult_R>)Result_46;
            n8._Operations_.FromSequence<n9.SearchResult_R>(Input_In: Input_47, Result_Out: out n5.Spread<n9.SearchResult_R> Result_48);
            Result_Out = Result_48;
            return;
        }

        [n1.ElementAttribute(TracingId = 219503U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "GvSAxRaQXwTNbXuj9hKnVL", Name = "__slot_GvSAxRaQXwTNbXuj9hKnVL")]
        public static string __slot_GvSAxRaQXwTNbXuj9hKnVL = "< Take into account the length of the word of the Search String";
        [n1.ElementAttribute(TracingId = 219511U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "OwToJWKJHN0NGmiq7wD0u8", Name = "__slot_OwToJWKJHN0NGmiq7wD0u8")]
        public static string __slot_OwToJWKJHN0NGmiq7wD0u8 = "< Normalize the score";
        static _Operations_()
        {
        }
    }
}

namespace _VL_FuzzySearch_.Text.FuzzySearch.Search
{
    [n1.ElementAttribute(TracingId = 220062U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "VuFQ2dznHyxQLSn1VhRFn0", Name = "SearchResult_R")]
    [n2.SerializableAttribute]
    public class SearchResult_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.SearchResult_R Create(n1.NodeContext Node_Context, string Value_In, int Index_In, n5.Spread<n9.Similarity_R> Similarities_In)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new SearchResult_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Value_In, Index_In, Similarities_In);
        }

        [n4.CreateDefaultAttribute]
        public static n9.SearchResult_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n9.SearchResult_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new SearchResult_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.SearchResult_R __DEFAULT__;
        public n9.SearchResult_R Split(out string Value_Out, out int Index_Out, out n5.Spread<n9.Similarity_R> Similarities_Out, out float Score_Out)
        {
            string __auto_0 = this.Value;
            int __auto_1 = this.Index;
            n5.Spread<n9.Similarity_R> __auto_2 = this.Similarities;
            float __auto_3 = this.Score;
            Value_Out = __auto_0;
            Index_Out = __auto_1;
            Similarities_Out = __auto_2;
            Score_Out = __auto_3;
            return this;
        }

        public n9.SearchResult_R SetScore(float Score_In)
        {
            float __auto_0 = Score_In;
            n9.SearchResult_R that_1 = this;
            that_1 = Score_In != this.Score ? new SearchResult_R(this)
            {Score = Score_In} : that_1;
            return that_1;
        }

        public n9.SearchResult_R Score_(out float Score_Out)
        {
            float __auto_0 = this.Score;
            Score_Out = __auto_0;
            return this;
        }

        public n9.SearchResult_R Similarities_(out n5.Spread<n9.Similarity_R> Similarities_Out)
        {
            n5.Spread<n9.Similarity_R> __auto_0 = this.Similarities;
            Similarities_Out = __auto_0;
            return this;
        }

        public n9.SearchResult_R __Create__(n1.NodeContext Node_Context, string Value_In, int Index_In, n5.Spread<n9.Similarity_R> Similarities_In)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __auto_0 = Value_In;
            int __auto_1 = Index_In;
            n5.Spread<n9.Similarity_R> __auto_2 = Similarities_In;
            n9.SearchResult_R that_3 = this;
            this.Value = Value_In;
            this.Similarities = Similarities_In;
            this.Score = 0F;
            this.Index = Index_In;
            return that_3;
        }

        public n9.SearchResult_R __CreateDefault__()
        {
            n9.SearchResult_R that_0 = this;
            this.Value = "";
            this.Similarities = n8._Operations_.CreateDefault<n9.Similarity_R>();
            this.Score = 0F;
            this.Index = 0;
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

        [n1.ElementAttribute(TracingId = 220067U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "KlGL84nMZiSOW3PCrDZNTR", Name = "Value")]
        public string Value;
        [n1.ElementAttribute(TracingId = 220071U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "T3UvqWWWcDwMnucTWedvz2", Name = "Similarities")]
        public n5.Spread<n9.Similarity_R> Similarities;
        [n1.ElementAttribute(TracingId = 220082U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "IMm1vEGCARSO0mDSmK3HY1", Name = "Score")]
        public float Score;
        [n1.ElementAttribute(TracingId = 220096U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "A0SNJPSywdVL6IhrYflOea", Name = "Index")]
        public int Index;
        public SearchResult_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SearchResult_R(SearchResult_R other): base(other)
        {
            this.Value = other.Value;
            this.Similarities = other.Similarities;
            this.Score = other.Score;
            this.Index = other.Index;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Value", in Value), n1.CompilationHelper.GetValueOrExisting(values, "Similarities", in Similarities), n1.CompilationHelper.GetValueOrExisting(values, "Score", in Score), n1.CompilationHelper.GetValueOrExisting(values, "Index", in Index));
        }

        internal SearchResult_R __WITH__(string Value, n5.Spread<n9.Similarity_R> Similarities, float Score, int Index)
        {
            n9.SearchResult_R that_0 = this;
            that_0 = Value != this.Value || Similarities != this.Similarities || Score != this.Score || Index != this.Index ? new SearchResult_R(this)
            {Value = Value, Similarities = Similarities, Score = Score, Index = Index} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 220255U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "TlMBNRdJn35PkJtiM4658J", Name = "Similarity_R")]
    [n2.SerializableAttribute]
    public class Similarity_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.Similarity_R Create(n1.NodeContext Node_Context, float Similarity_In, int Search_Word_Length_In, int Search_Word_Index_In, int List_Word_Index_In)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new Similarity_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Similarity_In, Search_Word_Length_In, Search_Word_Index_In, List_Word_Index_In);
        }

        [n4.CreateDefaultAttribute]
        public static n9.Similarity_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n9.Similarity_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new Similarity_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.Similarity_R __DEFAULT__;
        public n9.Similarity_R Split(out float Similarity_Out, out int Search_Word_Length_Out, out int Search_Word_Index_Out, out int List_Word_Index_Out)
        {
            float __auto_0 = this.Similarity;
            int __auto_1 = this.Search_Word_Length;
            int __auto_2 = this.Search_Word_Index;
            int __auto_3 = this.List_Word_Index;
            Similarity_Out = __auto_0;
            Search_Word_Length_Out = __auto_1;
            Search_Word_Index_Out = __auto_2;
            List_Word_Index_Out = __auto_3;
            return this;
        }

        public n9.Similarity_R SetSimilarity()
        {
            return this;
        }

        public n9.Similarity_R __Create__(n1.NodeContext Node_Context, float Similarity_In, int Search_Word_Length_In, int Search_Word_Index_In, int List_Word_Index_In)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            float __auto_0 = Similarity_In;
            int __auto_1 = Search_Word_Length_In;
            int __auto_2 = Search_Word_Index_In;
            int __auto_3 = List_Word_Index_In;
            n9.Similarity_R that_4 = this;
            this.Similarity = Similarity_In;
            this.Search_Word_Length = Search_Word_Length_In;
            this.List_Word_Index = List_Word_Index_In;
            this.Search_Word_Index = Search_Word_Index_In;
            return that_4;
        }

        public n9.Similarity_R __CreateDefault__()
        {
            n9.Similarity_R that_0 = this;
            this.Similarity = 0F;
            this.Search_Word_Length = 0;
            this.List_Word_Index = 0;
            this.Search_Word_Index = 0;
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

        [n1.ElementAttribute(TracingId = 220260U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "DL1Sr9txzlkOjRdeMWsgzV", Name = "Similarity")]
        public float Similarity;
        [n1.ElementAttribute(TracingId = 220266U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "MGIIHs8iQpmNV3wg7Qr1lD", Name = "Search Word Length")]
        public int Search_Word_Length;
        [n1.ElementAttribute(TracingId = 220282U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "BsGTUKrHGvQNSezmn347DJ", Name = "List Word Index")]
        public int List_Word_Index;
        [n1.ElementAttribute(TracingId = 220278U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "TH5RkxjsNgqNch9RelUzj0", Name = "Search Word Index")]
        public int Search_Word_Index;
        public Similarity_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Similarity_R(Similarity_R other): base(other)
        {
            this.Similarity = other.Similarity;
            this.Search_Word_Length = other.Search_Word_Length;
            this.List_Word_Index = other.List_Word_Index;
            this.Search_Word_Index = other.Search_Word_Index;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Similarity", in Similarity), n1.CompilationHelper.GetValueOrExisting(values, "Search_Word_Length", in Search_Word_Length), n1.CompilationHelper.GetValueOrExisting(values, "List_Word_Index", in List_Word_Index), n1.CompilationHelper.GetValueOrExisting(values, "Search_Word_Index", in Search_Word_Index));
        }

        internal Similarity_R __WITH__(float Similarity, int Search_Word_Length, int List_Word_Index, int Search_Word_Index)
        {
            n9.Similarity_R that_0 = this;
            that_0 = Similarity != this.Similarity || Search_Word_Length != this.Search_Word_Length || List_Word_Index != this.List_Word_Index || Search_Word_Index != this.Search_Word_Index ? new Similarity_R(this)
            {Similarity = Similarity, Search_Word_Length = Search_Word_Length, List_Word_Index = List_Word_Index, Search_Word_Index = Search_Word_Index} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 220421U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "OKbFWImbj2eQKzAF2Fggxa", Name = "Preprocessor_OKbFWImbj2eQKzAF2Fggxa")]
    [n2.SerializableAttribute]
    public class Preprocessor_OKbFWImbj2eQKzAF2Fggxa : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa Create(n1.NodeContext Node_Context)
        {
            var instance = new Preprocessor_OKbFWImbj2eQKzAF2Fggxa(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa CreateDefault()
        {
            var instance = new Preprocessor_OKbFWImbj2eQKzAF2Fggxa(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa Update(string Input_In, int Minimum_Word_Length_In, n6.IEnumerable<string> Words_to_Exclude_In, bool Case_Sensetive_In, [n4.SerializedDefaultValueAttribute("0.6", false)] float Words_to_Exclude_Minimum_Similarity_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Include_Shortcuts_In, out n5.Spread<string> Output_Out)
        {
            string __pad_CZXst8YxzwgMmh6i7CzZv3_0 = __slot_CZXst8YxzwgMmh6i7CzZv3;
            string __pad_PiYMuLy0idZOIfICE1735K_1 = __slot_PiYMuLy0idZOIfICE1735K;
            n17._Operations_.Switch_Boolean<string>(Condition_In: Include_Shortcuts_In, Input_In: __pad_CZXst8YxzwgMmh6i7CzZv3_0, Input_2_In: __pad_PiYMuLy0idZOIfICE1735K_1, Output_Out: out string Output_2);
            n18.RegexOptions Options_3 = __c_GsKzjLfcmkGMWPtOMocDZa;
            var Output_6 = this.__p_LBT8VabFGjmQa6qtGUgFOI.Update(Input_In: Input_In, Pattern_In: Output_2, Options_In: Options_3, Result_Out: out n5.Spread<string> Result_4, Result_Groups_Out: out n5.Spread<n5.Spread<string>> Result_Groups_5);
            n19._Operations_.Clean(Input_In: Result_4, Output_Out: out n5.Spread<string> Output_7);
            var Output_8 = !Case_Sensetive_In;
            var State_Output_10 = this.__p_E04MbrK3tJYLrhzJEXwebW.Get(Output_Out: out n13.IStringMetric Output_9);
            var builder_31 = n4.CollectionBuilders.GetBuilder(this.__cp_MlJsFTgYQH7NInBiRE5jO2, 16);
            n5.Spread<string> output_32;
            try
            {
                var i_13 = 0;
                foreach (var item_11 in n4.CollectionExtensions.AsSpan(Output_7))
                {
                    var splicer_12 = item_11;
                    var i_local_14 = i_13;
                    var Output_16 = splicer_12;
                    if (Output_8)
                    {
                        var Output_17 = splicer_12.ToLowerInvariant();
                        Output_16 = Output_17;
                    }

                    var Length_18 = Output_16.Length;
                    var Result_19 = Length_18 >= Minimum_Word_Length_In;
                    var breakOutput_28 = false;
                    var i_22 = 0;
                    foreach (var item_20 in Words_to_Exclude_In)
                    {
                        var splicer_21 = item_20;
                        var i_local_23 = i_22;
                        n20._Operations_.GetSimilarity(Input_In: Output_9, First_Word_In: Output_16, Second_Word_In: splicer_21, Output_Out: out n13.IStringMetric Output_25, Result_Out: out float Result_26);
                        var Result_27 = Result_26 >= Words_to_Exclude_Minimum_Similarity_In;
                        if (Result_27)
                        {
                            breakOutput_28 = Result_27;
                            break;
                        }

                        i_22++;
                    }

                    var Output_29 = !breakOutput_28;
                    var Output_30 = Result_19 && Output_29;
                    if (Output_30)
                    {
                        builder_31.Add(Output_16);
                    }

                    i_13++;
                }
            }
            finally
            {
                output_32 = builder_31.Commit();
            }

            var builder_55 = n4.CollectionBuilders.GetBuilder(this.__cp_GFq349T7xunMw2PDPSmsoS, 16);
            n5.Spread<string> output_56;
            try
            {
                var i_35 = 0;
                foreach (var item_33 in n4.CollectionExtensions.AsSpan(output_32))
                {
                    var splicer_34 = item_33;
                    var i_local_36 = i_35;
                    var Output_38 = n21.Integer32Extensions.Inc(input: i_local_36);
                    n8._Operations_.Skip<string>(Input_In: output_32, Count_In: Output_38, Output_Out: out n5.Spread<string> Output_39);
                    var breakOutput_49 = false;
                    var i_42 = 0;
                    foreach (var item_40 in n4.CollectionExtensions.AsSpan(Output_39))
                    {
                        var splicer_41 = item_40;
                        var i_local_43 = i_42;
                        float __pad_SOedeD73LShO3diWwpCybK_45 = __slot_SOedeD73LShO3diWwpCybK;
                        n20._Operations_.GetSimilarity(Input_In: Output_9, First_Word_In: splicer_34, Second_Word_In: splicer_41, Output_Out: out n13.IStringMetric Output_46, Result_Out: out float Result_47);
                        var Result_48 = Result_47 > __pad_SOedeD73LShO3diWwpCybK_45;
                        if (Result_48)
                        {
                            breakOutput_49 = Result_48;
                            break;
                        }

                        i_42++;
                    }

                    var Output_50 = !breakOutput_49;
                    n8._Operations_.Count<string>(Input_In: Output_39, Count_Out: out int Count_51);
                    int Input_2_52 = 0;
                    var Result_53 = Count_51 == Input_2_52;
                    var Output_54 = Output_50 || Result_53;
                    if (Output_54)
                    {
                        builder_55.Add(splicer_34);
                    }

                    i_35++;
                }
            }
            finally
            {
                output_56 = builder_55.Commit();
            }

            Output_Out = output_56;
            n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa that_57 = this;
            if (this.__GetContext__().IsImmutable)
                that_57 = Output_6 != this.__p_LBT8VabFGjmQa6qtGUgFOI || State_Output_10 != this.__p_E04MbrK3tJYLrhzJEXwebW || output_32 != this.__cp_MlJsFTgYQH7NInBiRE5jO2 || output_56 != this.__cp_GFq349T7xunMw2PDPSmsoS ? new Preprocessor_OKbFWImbj2eQKzAF2Fggxa(this)
                {__p_LBT8VabFGjmQa6qtGUgFOI = Output_6, __p_E04MbrK3tJYLrhzJEXwebW = State_Output_10, __cp_MlJsFTgYQH7NInBiRE5jO2 = output_32, __cp_GFq349T7xunMw2PDPSmsoS = output_56} : that_57;
            else
            {
                this.__p_LBT8VabFGjmQa6qtGUgFOI = Output_6;
                this.__p_E04MbrK3tJYLrhzJEXwebW = State_Output_10;
                this.__cp_MlJsFTgYQH7NInBiRE5jO2 = output_32;
                this.__cp_GFq349T7xunMw2PDPSmsoS = output_56;
            }

            return that_57;
        }

        public n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "LBT8VabFGjmQa6qtGUgFOI", 220576U);
            var Output_1 = n23.Matches_EWOwsOz68C1Mwnt5excx6S.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QDVtT0Z8fBYMjLwlcbJ0Wv", "E04MbrK3tJYLrhzJEXwebW", 220610U);
            var Output_3 = n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc.Create(Node_Context: Node_Context_2);
            n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa that_4 = this;
            this.__cp_MlJsFTgYQH7NInBiRE5jO2 = n8._Operations_.CreateDefault<string>();
            this.__cp_GFq349T7xunMw2PDPSmsoS = n8._Operations_.CreateDefault<string>();
            this.__p_LBT8VabFGjmQa6qtGUgFOI = Output_1;
            this.__p_E04MbrK3tJYLrhzJEXwebW = Output_3;
            return that_4;
        }

        public n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa __CreateDefault__()
        {
            n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa that_0 = this;
            this.__cp_MlJsFTgYQH7NInBiRE5jO2 = n8._Operations_.CreateDefault<string>();
            this.__cp_GFq349T7xunMw2PDPSmsoS = n8._Operations_.CreateDefault<string>();
            this.__p_LBT8VabFGjmQa6qtGUgFOI = n23.Matches_EWOwsOz68C1Mwnt5excx6S.CreateDefault();
            this.__p_E04MbrK3tJYLrhzJEXwebW = n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LBT8VabFGjmQa6qtGUgFOI);
            n1.CompilationHelper.SafeDispose(this.__p_E04MbrK3tJYLrhzJEXwebW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 220597U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "CZXst8YxzwgMmh6i7CzZv3", Name = "__slot_CZXst8YxzwgMmh6i7CzZv3")]
        public static string __slot_CZXst8YxzwgMmh6i7CzZv3 = "([A-Z]+(?![a-z])|[A-Z][a-z][0-9]+|[0-9]+|[a-z]+)";
        [n1.ElementAttribute(TracingId = 220599U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "I2RvtWByO8DNBkelPH3qek", Name = "__slot_I2RvtWByO8DNBkelPH3qek")]
        public static string __slot_I2RvtWByO8DNBkelPH3qek = "< Split at Spaces, CamelCaps and Abbrevations.\r\nSupports any identifier with words, acronyms, numbers, underscores.\r\nhttps://stackoverflow.com/a/37532157";
        [n1.ElementAttribute(TracingId = 220778U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "EEC8PdF4pcxNyvv3i7woL8", Name = "__slot_EEC8PdF4pcxNyvv3i7woL8")]
        public static string __slot_EEC8PdF4pcxNyvv3i7woL8 = "< Remove Similar words";
        [n1.ElementAttribute(TracingId = 220797U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "PiYMuLy0idZOIfICE1735K", Name = "__slot_PiYMuLy0idZOIfICE1735K")]
        public static string __slot_PiYMuLy0idZOIfICE1735K = "([A-Z]*[a-z]*[0-9]*(?![a-z])|[A-Z][a-z]+|[0-9]+|[a-z]+)";
        [n1.ElementAttribute(TracingId = 220576U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "LBT8VabFGjmQa6qtGUgFOI", Name = "Matches", IsManaged = true, IsAutoGenerated = true)]
        public n23.Matches_EWOwsOz68C1Mwnt5excx6S __p_LBT8VabFGjmQa6qtGUgFOI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n18.RegexOptions __c_GsKzjLfcmkGMWPtOMocDZa = n1.CompilationHelper.Deserialize<n18.RegexOptions>("Compiled", false, "QDVtT0Z8fBYMjLwlcbJ0Wv", "GsKzjLfcmkGMWPtOMocDZa");
        [n1.ElementAttribute(TracingId = 220610U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "E04MbrK3tJYLrhzJEXwebW", Name = "Levenshtein", IsManaged = true, IsAutoGenerated = true)]
        public n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __p_E04MbrK3tJYLrhzJEXwebW;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __cp_MlJsFTgYQH7NInBiRE5jO2;
        [n1.ElementAttribute(TracingId = 220673U, DocumentId = "QDVtT0Z8fBYMjLwlcbJ0Wv", PersistentId = "SOedeD73LShO3diWwpCybK", Name = "__slot_SOedeD73LShO3diWwpCybK")]
        public static float __slot_SOedeD73LShO3diWwpCybK = 0.8F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __cp_GFq349T7xunMw2PDPSmsoS;
        static Preprocessor_OKbFWImbj2eQKzAF2Fggxa()
        {
        }

        public Preprocessor_OKbFWImbj2eQKzAF2Fggxa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Preprocessor_OKbFWImbj2eQKzAF2Fggxa(Preprocessor_OKbFWImbj2eQKzAF2Fggxa other): base(other)
        {
            this.__p_LBT8VabFGjmQa6qtGUgFOI = other.__p_LBT8VabFGjmQa6qtGUgFOI;
            this.__p_E04MbrK3tJYLrhzJEXwebW = other.__p_E04MbrK3tJYLrhzJEXwebW;
            this.__cp_MlJsFTgYQH7NInBiRE5jO2 = other.__cp_MlJsFTgYQH7NInBiRE5jO2;
            this.__cp_GFq349T7xunMw2PDPSmsoS = other.__cp_GFq349T7xunMw2PDPSmsoS;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LBT8VabFGjmQa6qtGUgFOI", in __p_LBT8VabFGjmQa6qtGUgFOI), n1.CompilationHelper.GetValueOrExisting(values, "__p_E04MbrK3tJYLrhzJEXwebW", in __p_E04MbrK3tJYLrhzJEXwebW), n1.CompilationHelper.GetValueOrExisting(values, "__cp_MlJsFTgYQH7NInBiRE5jO2", in __cp_MlJsFTgYQH7NInBiRE5jO2), n1.CompilationHelper.GetValueOrExisting(values, "__cp_GFq349T7xunMw2PDPSmsoS", in __cp_GFq349T7xunMw2PDPSmsoS));
        }

        internal Preprocessor_OKbFWImbj2eQKzAF2Fggxa __WITH__(n23.Matches_EWOwsOz68C1Mwnt5excx6S __p_LBT8VabFGjmQa6qtGUgFOI, n15.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __p_E04MbrK3tJYLrhzJEXwebW, n5.Spread<string> __cp_MlJsFTgYQH7NInBiRE5jO2, n5.Spread<string> __cp_GFq349T7xunMw2PDPSmsoS)
        {
            n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LBT8VabFGjmQa6qtGUgFOI != this.__p_LBT8VabFGjmQa6qtGUgFOI || __p_E04MbrK3tJYLrhzJEXwebW != this.__p_E04MbrK3tJYLrhzJEXwebW || __cp_MlJsFTgYQH7NInBiRE5jO2 != this.__cp_MlJsFTgYQH7NInBiRE5jO2 || __cp_GFq349T7xunMw2PDPSmsoS != this.__cp_GFq349T7xunMw2PDPSmsoS ? new Preprocessor_OKbFWImbj2eQKzAF2Fggxa(this)
                {__p_LBT8VabFGjmQa6qtGUgFOI = __p_LBT8VabFGjmQa6qtGUgFOI, __p_E04MbrK3tJYLrhzJEXwebW = __p_E04MbrK3tJYLrhzJEXwebW, __cp_MlJsFTgYQH7NInBiRE5jO2 = __cp_MlJsFTgYQH7NInBiRE5jO2, __cp_GFq349T7xunMw2PDPSmsoS = __cp_GFq349T7xunMw2PDPSmsoS} : that_0;
            else
            {
                this.__p_LBT8VabFGjmQa6qtGUgFOI = __p_LBT8VabFGjmQa6qtGUgFOI;
                this.__p_E04MbrK3tJYLrhzJEXwebW = __p_E04MbrK3tJYLrhzJEXwebW;
                this.__cp_MlJsFTgYQH7NInBiRE5jO2 = __cp_MlJsFTgYQH7NInBiRE5jO2;
                this.__cp_GFq349T7xunMw2PDPSmsoS = __cp_GFq349T7xunMw2PDPSmsoS;
            }

            return that_0;
        }
    }
}

namespace _VL_FuzzySearch_
{
    public struct __AdaptiveImplementations__QDVtT0Z8fBYMjLwlcbJ0Wv : n27.IAdaptiveCreateDefault<float>, n28.IAdaptiveOperatorPlus<float>, n28.IAdaptiveOperatorGreater<float>
    {
        public void CreateDefault(out float Output_Out)
        {
            n26._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}