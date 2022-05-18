extern alias e3;
extern alias e2;
extern alias e10;

using n8 = global::System.Net.NetworkInformation;
using n26 = _CoreLibBasics_.Control.Advanced;
using n9 = e2::VL.Lib.Collections;
using n29 = _CoreLibBasics_.Primitive.Object.Advanced;
using n31 = _CoreLibBasics_.Control;
using n7 = e3::VL.Lib.IO.Net;
using n11 = global::System.Net;
using n4 = e3::VL.Lib.Control;
using n18 = _CoreLibBasics_.Primitive.Delegates.Delegate__0_MG_1.Advanced;
using n10 = global::System.Collections.Generic;
using n15 = e2::VL.Lib.Basics.Resources;
using n25 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n20 = e3::VL.Lib.IO.WebRequest;
using n27 = e10::VL.Model;
using n17 = global::System.Threading;
using n13 = e3::VL.Lib.IO.Socket;
using n38 = _CoreLibBasics_.IO.Stream.Experimental;
using n3 = e2::VL.Core;
using n14 = global::System.Net.Sockets;
using n5 = global::System;
using n24 = _VL_CoreLib_Experimental_.Primitive.Experimental;
using n32 = e3::VL.Lib.Experimental;
using n23 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n19 = e3::VL.Lib.Parallel;
using n12 = e2::VL.Lib.IO;
using n36 = _VL_CoreLib_Experimental_.Experimental;
using n6 = e2::VL.Core.CompilerServices;
using n33 = _VL_CoreLib_Experimental_.System.Process.Experimental;
using n34 = e3::JobManagement;
using n16 = e2::VL.Lib.Animation;
using n30 = global::System.Runtime.CompilerServices;
using n28 = e10::VL.Lang.PublicAPI;
using n21 = _VL_Collections_.Collections.Spread;
using n35 = _VL_CoreLib_Experimental_.Control.Experimental;
using n37 = _CoreLibBasics_.Primitive.Advanced;
using n22 = global::System.IO;

namespace _VL_CoreLib_Experimental_.Control.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Throw(n5.Exception E_In)
        {
            n4.TryCatchUtils.Throw(e: E_In);
            return;
        }

        public static void Throw_Message([n6.SerializedDefaultValueAttribute("Unspecified Exception", false)] string Message_In)
        {
            n4.TryCatchUtils.Throw(message: Message_In);
            return;
        }

        public static void Try_Stateless<T>(n5.Func<T> Try_In, T Default_Output_In, out T Result_Out, out bool Success_Out, out string Error_Message_Out)
        {
            var Result_2 = n4.TryCatchUtils.Try<T>(@try: Try_In, defaultOutput: Default_Output_In, success: out bool Success_0, errorMessage: out string Error_Message_1);
            Result_Out = Result_2;
            Success_Out = Success_0;
            Error_Message_Out = Error_Message_1;
            return;
        }

        public static void Try2__2Outputs_Stateless<T2, T>(n5.Func<n5.Tuple<T2, T>> Try_In, T2 Default_Output_1_In, T Default_Output_2_In, out T2 Output_1_Out, out T Output_2_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n4.TryCatchUtils.Try2<T2, T>(@try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, output1: out T2 Output_1_0, output2: out T Output_2_1, success: out bool Success_2, errorMessage: out string Error_Message_3);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Success_Out = Success_2;
            Error_Message_Out = Error_Message_3;
            return;
        }

        public static void Try3__3Outputs_Stateless<T3, T2, T>(n5.Func<n5.Tuple<T3, T2, T>> Try_In, T3 Default_Output_1_In, T2 Default_Output_2_In, T Default_Output_3_In, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n4.TryCatchUtils.Try3<T3, T2, T>(@try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2, success: out bool Success_3, errorMessage: out string Error_Message_4);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Success_Out = Success_3;
            Error_Message_Out = Error_Message_4;
            return;
        }

        public static void Try4__4Outputs_Stateless<T4, T3, T2, T>(n5.Func<n5.Tuple<T4, T3, T2, T>> Try_In, T4 Default_Output_1_In, T3 Default_Output_2_In, T2 Default_Output_3_In, T Default_Output_4_In, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n4.TryCatchUtils.Try4<T4, T3, T2, T>(@try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, defaultOutput4: Default_Output_4_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3, success: out bool Success_4, errorMessage: out string Error_Message_5);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Success_Out = Success_4;
            Error_Message_Out = Error_Message_5;
            return;
        }

        public static void Try5__5Outputs_Stateless<T5, T4, T3, T2, T>(n5.Func<n5.Tuple<T5, T4, T3, T2, T>> Try_In, T5 Default_Output_1_In, T4 Default_Output_2_In, T3 Default_Output_3_In, T2 Default_Output_4_In, T Default_Output_5_In, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out, out bool Success_Out, out string Error_Message_Out)
        {
            n4.TryCatchUtils.Try5<T5, T4, T3, T2, T>(@try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, defaultOutput4: Default_Output_4_In, defaultOutput5: Default_Output_5_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4, success: out bool Success_5, errorMessage: out string Error_Message_6);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            Success_Out = Success_5;
            Error_Message_Out = Error_Message_6;
            return;
        }

        public static void TryCatch_Stateless<T>(n5.Func<T> Try_In, n5.Func<n5.Exception, T> Catch_In, out T Result_Out)
        {
            var Result_0 = n4.TryCatchUtils.TryCatch<T>(@try: Try_In, @catch: Catch_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryCatch2__2Outputs_Stateless<T2, T>(n5.Func<n5.Tuple<T2, T>> Try_In, n5.Func<n5.Exception, n5.Tuple<T2, T>> Catch_In, out T2 Output_1_Out, out T Output_2_Out)
        {
            n4.TryCatchUtils.TryCatch2<T2, T>(@try: Try_In, @catch: Catch_In, output1: out T2 Output_1_0, output2: out T Output_2_1);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void TryCatch3__3Outputs_Stateless<T3, T2, T>(n5.Func<n5.Tuple<T3, T2, T>> Try_In, n5.Func<n5.Exception, n5.Tuple<T3, T2, T>> Catch_In, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out)
        {
            n4.TryCatchUtils.TryCatch3<T3, T2, T>(@try: Try_In, @catch: Catch_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            return;
        }

        public static void TryCatch4__4Outputs_Stateless<T4, T3, T2, T>(n5.Func<n5.Tuple<T4, T3, T2, T>> Try_In, n5.Func<n5.Exception, n5.Tuple<T4, T3, T2, T>> Catch_In, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out)
        {
            n4.TryCatchUtils.TryCatch4<T4, T3, T2, T>(@try: Try_In, @catch: Catch_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            return;
        }

        public static void TryCatch5__5Outputs_Stateless<T5, T4, T3, T2, T>(n5.Func<n5.Tuple<T5, T4, T3, T2, T>> Try_In, n5.Func<n5.Exception, n5.Tuple<T5, T4, T3, T2, T>> Catch_In, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out)
        {
            n4.TryCatchUtils.TryCatch5<T5, T4, T3, T2, T>(@try: Try_In, @catch: Catch_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            return;
        }

        public static void TryCatchFinally_Stateless<T2, T>(n5.Func<T2> Try_In, n5.Func<n5.Exception, T2> Catch_In, n5.Func<T2, T> Finally_In, out T Result_Out)
        {
            var Result_0 = n4.TryCatchUtils.TryCatchFinally<T2, T>(@try: Try_In, @catch: Catch_In, @finally: Finally_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryCatchFinally2__2Outputs_Stateless<T3, T4, T2, T>(n5.Func<n5.Tuple<T3, T4>> Try_In, n5.Func<n5.Exception, n5.Tuple<T3, T4>> Catch_In, n5.Func<n5.Tuple<T3, T4>, n5.Tuple<T2, T>> Finally_In, out T2 Output_1_Out, out T Output_2_Out)
        {
            n4.TryCatchUtils.TryCatchFinally2<T2, T, T3, T4>(@try: Try_In, @catch: Catch_In, @finally: Finally_In, output1: out T2 Output_1_0, output2: out T Output_2_1);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void TryCatchFinally3__3Outputs_Stateless<T4, T5, T6, T3, T2, T>(n5.Func<n5.Tuple<T4, T5, T6>> Try_In, n5.Func<n5.Exception, n5.Tuple<T4, T5, T6>> Catch_In, n5.Func<n5.Tuple<T4, T5, T6>, n5.Tuple<T3, T2, T>> Finally_In, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out)
        {
            n4.TryCatchUtils.TryCatchFinally3<T3, T2, T, T4, T5, T6>(@try: Try_In, @catch: Catch_In, @finally: Finally_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            return;
        }

        public static void TryCatchFinally4__4Outputs_Stateless<T5, T6, T7, T8, T4, T3, T2, T>(n5.Func<n5.Tuple<T5, T6, T7, T8>> Try_In, n5.Func<n5.Exception, n5.Tuple<T5, T6, T7, T8>> Catch_In, n5.Func<n5.Tuple<T5, T6, T7, T8>, n5.Tuple<T4, T3, T2, T>> Finally_In, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out)
        {
            n4.TryCatchUtils.TryCatchFinally4<T4, T3, T2, T, T5, T6, T7, T8>(@try: Try_In, @catch: Catch_In, @finally: Finally_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            return;
        }

        public static void TryCatchFinally5__5Outputs_Stateless<T6, T7, T8, T9, T10, T5, T4, T3, T2, T>(n5.Func<n5.Tuple<T6, T7, T8, T9, T10>> Try_In, n5.Func<n5.Exception, n5.Tuple<T6, T7, T8, T9, T10>> Catch_In, n5.Func<n5.Tuple<T6, T7, T8, T9, T10>, n5.Tuple<T5, T4, T3, T2, T>> Finally_In, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out)
        {
            n4.TryCatchUtils.TryCatchFinally5<T5, T4, T3, T2, T, T6, T7, T8, T9, T10>(@try: Try_In, @catch: Catch_In, @finally: Finally_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4);
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            return;
        }

        public static void LiveAndLetDie<T3, T2, T>(T3 Items_In, int Create_Count_In, n5.Func<T2> Creator_In, n5.Func<T2, T> Updator_In, n5.Func<T, bool> Killer_In, out n9.Spread<T> Alive_Items_Out, out n9.Spread<bool> Are_Alive_Out, out n9.Spread<T> Dead_Items_Out)
            where T3 : n10.IEnumerable<T2>
        {
            n9.Spread<T2> __cp_LziNSdWpmdyLzu2986FruQ = n21._Operations_.CreateDefault<T2>();
            n9.Spread<n10.IEnumerable<T2>> __pin_group_Input_In_AyEQhfznxhqMS0Ed2QNtcE = default(n9.Spread<n10.IEnumerable<T2>>);
            n9.Spread<T> __cp_H1fAIr4qCWcOLpwhLRbYwT = n21._Operations_.CreateDefault<T>();
            n9.Spread<bool> __cp_DjEgOwlv8tUPmEEm1g0pwY = n21._Operations_.CreateDefault<bool>();
            n9.Spread<bool> __cp_IZrdBu4RXczOZjIuy3AUPE = n21._Operations_.CreateDefault<bool>();
            n10.IEnumerable<T2> Input_0 = (n10.IEnumerable<T2>)Items_In;
            var builder_4 = n6.CollectionBuilders.GetBuilder(__cp_LziNSdWpmdyLzu2986FruQ, 16);
            n9.Spread<T2> output_5;
            try
            {
                for (var i_1 = 0; i_1 < Create_Count_In; i_1++)
                {
                    var i_local_2 = i_1;
                    n18._Operations_.Invoke<T2>(Input_In: Creator_In, Result_Out: out T2 Result_3);
                    builder_4.Add(Result_3);
                }
            }
            finally
            {
                output_5 = builder_4.Commit();
            }

            n10.IEnumerable<T2> Input_2_6 = (n10.IEnumerable<T2>)output_5;
            var builder_7 = n6.CollectionBuilders.GetBuilder(__pin_group_Input_In_AyEQhfznxhqMS0Ed2QNtcE, 2);
            builder_7.Add(Input_0);
            builder_7.Add(Input_2_6);
            var __pin_group_Input_In_AyEQhfznxhqMS0Ed2QNtcE_8 = builder_7.Commit();
            n21._Operations_.Concat<T2>(Input_In: __pin_group_Input_In_AyEQhfznxhqMS0Ed2QNtcE_8, Output_Out: out n9.Spread<T2> Output_9);
            var builder_19 = n6.CollectionBuilders.GetBuilder(__cp_H1fAIr4qCWcOLpwhLRbYwT, 16);
            n9.Spread<T> output_20;
            var builder_21 = n6.CollectionBuilders.GetBuilder(__cp_DjEgOwlv8tUPmEEm1g0pwY, 16);
            n9.Spread<bool> output_22;
            var builder_23 = n6.CollectionBuilders.GetBuilder(__cp_IZrdBu4RXczOZjIuy3AUPE, 16);
            n9.Spread<bool> output_24;
            try
            {
                var i_12 = 0;
                foreach (var item_10 in n6.CollectionExtensions.AsSpan(Output_9))
                {
                    var splicer_11 = item_10;
                    var i_local_13 = i_12;
                    n23._Operations_.Invoke<T2, T>(Input_In: Updator_In, Arg_In: splicer_11, Result_Out: out T Result_14);
                    n23._Operations_.Invoke<T, bool>(Input_In: Killer_In, Arg_In: Result_14, Result_Out: out bool Result_15);
                    bool Apply_16 = true;
                    var Output_17 = Result_15;
                    if (Apply_16)
                    {
                        var Output_18 = !Result_15;
                        Output_17 = Output_18;
                    }

                    builder_19.Add(Result_14);
                    builder_21.Add(Output_17);
                    builder_23.Add(Result_15);
                    i_12++;
                }
            }
            finally
            {
                output_20 = builder_19.Commit();
                output_22 = builder_21.Commit();
                output_24 = builder_23.Commit();
            }

            n21._Operations_.Select<n9.Spread<T>, T, n9.Spread<bool>>(Input_In: output_20, Alive_Values_In: output_22, Output_Out: out n9.Spread<T> Output_25);
            n21._Operations_.Select<n9.Spread<T>, T, n9.Spread<bool>>(Input_In: output_20, Alive_Values_In: output_24, Output_Out: out n9.Spread<T> Output_26);
            Alive_Items_Out = Output_25;
            Are_Alive_Out = output_22;
            Dead_Items_Out = Output_26;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatch.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchStateful<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchStateful<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T>(n4.TryCatchStateful<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T>> Catch_In, bool Re_Initialize_In, out n4.TryCatchStateful<TState> Output_Out, out T Result_Out)
            where TState : class
        {
            var Result_0 = Input_In.Update<T>(create: Create_In, @try: Try_In, @catch: Catch_In, reInitialize: Re_Initialize_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatch__2Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchStateful2<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchStateful2<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T2, T>(n4.TryCatchStateful2<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T2, T>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T2, T>> Catch_In, bool Re_Initialize_In, out n4.TryCatchStateful2<TState> Output_Out, out T2 Output_1_Out, out T Output_2_Out)
            where TState : class
        {
            Input_In.Update<T2, T>(create: Create_In, @try: Try_In, @catch: Catch_In, reInitialize: Re_Initialize_In, output1: out T2 Output_1_0, output2: out T Output_2_1);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatch__3Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchStateful3<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchStateful3<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T3, T2, T>(n4.TryCatchStateful3<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T3, T2, T>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T3, T2, T>> Catch_In, bool Re_Initialize_In, out n4.TryCatchStateful3<TState> Output_Out, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out)
            where TState : class
        {
            Input_In.Update<T3, T2, T>(create: Create_In, @try: Try_In, @catch: Catch_In, reInitialize: Re_Initialize_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatch__4Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchStateful4<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchStateful4<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T4, T3, T2, T>(n4.TryCatchStateful4<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T4, T3, T2, T>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T4, T3, T2, T>> Catch_In, bool Re_Initialize_In, out n4.TryCatchStateful4<TState> Output_Out, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out)
            where TState : class
        {
            Input_In.Update<T4, T3, T2, T>(create: Create_In, @try: Try_In, @catch: Catch_In, reInitialize: Re_Initialize_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatch__5Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchStateful5<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchStateful5<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T5, T4, T3, T2, T>(n4.TryCatchStateful5<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T5, T4, T3, T2, T>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T5, T4, T3, T2, T>> Catch_In, bool Re_Initialize_In, out n4.TryCatchStateful5<TState> Output_Out, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out)
            where TState : class
        {
            Input_In.Update<T5, T4, T3, T2, T>(create: Create_In, @try: Try_In, @catch: Catch_In, reInitialize: Re_Initialize_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatchFinally.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchFinallyStateful<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchFinallyStateful<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T2, T>(n4.TryCatchFinallyStateful<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T2>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T2>> Catch_In, n5.Func<TState, T2, n5.Tuple<TState, T>> Finally_In, bool Re_Initialize_In, out n4.TryCatchFinallyStateful<TState> Output_Out, out T Result_Out)
            where TState : class
        {
            var Result_0 = Input_In.Update<T2, T>(create: Create_In, @try: Try_In, @catch: Catch_In, @finally: Finally_In, reInitialize: Re_Initialize_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatchFinally__2Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchFinallyStateful2<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchFinallyStateful2<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T3, T4, T2, T>(n4.TryCatchFinallyStateful2<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T3, T4>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T3, T4>> Catch_In, n5.Func<TState, T3, T4, n5.Tuple<TState, T2, T>> Finally_In, bool Re_Initialize_In, out n4.TryCatchFinallyStateful2<TState> Output_Out, out T2 Output_1_Out, out T Output_2_Out)
            where TState : class
        {
            Input_In.Update<T2, T, T3, T4>(create: Create_In, @try: Try_In, @catch: Catch_In, @finally: Finally_In, reInitialize: Re_Initialize_In, output1: out T2 Output_1_0, output2: out T Output_2_1);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatchFinally__3Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchFinallyStateful3<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchFinallyStateful3<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T4, T5, T6, T3, T2, T>(n4.TryCatchFinallyStateful3<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T4, T5, T6>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T4, T5, T6>> Catch_In, n5.Func<TState, T4, T5, T6, n5.Tuple<TState, T3, T2, T>> Finally_In, bool Re_Initialize_In, out n4.TryCatchFinallyStateful3<TState> Output_Out, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out)
            where TState : class
        {
            Input_In.Update<T3, T2, T, T4, T5, T6>(create: Create_In, @try: Try_In, @catch: Catch_In, @finally: Finally_In, reInitialize: Re_Initialize_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatchFinally__4Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchFinallyStateful4<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchFinallyStateful4<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T5, T6, T7, T8, T4, T3, T2, T>(n4.TryCatchFinallyStateful4<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T5, T6, T7, T8>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T5, T6, T7, T8>> Catch_In, n5.Func<TState, T5, T6, T7, T8, n5.Tuple<TState, T4, T3, T2, T>> Finally_In, bool Re_Initialize_In, out n4.TryCatchFinallyStateful4<TState> Output_Out, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out)
            where TState : class
        {
            Input_In.Update<T4, T3, T2, T, T5, T6, T7, T8>(create: Create_In, @try: Try_In, @catch: Catch_In, @finally: Finally_In, reInitialize: Re_Initialize_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.TryCatchFinally__5Outputs.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryCatchFinallyStateful5<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryCatchFinallyStateful5<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T6, T7, T8, T9, T10, T5, T4, T3, T2, T>(n4.TryCatchFinallyStateful5<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T6, T7, T8, T9, T10>> Try_In, n5.Func<TState, n5.Exception, n5.Tuple<TState, T6, T7, T8, T9, T10>> Catch_In, n5.Func<TState, T6, T7, T8, T9, T10, n5.Tuple<TState, T5, T4, T3, T2, T>> Finally_In, bool Re_Initialize_In, out n4.TryCatchFinallyStateful5<TState> Output_Out, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out)
            where TState : class
        {
            Input_In.Update<T5, T4, T3, T2, T, T6, T7, T8, T9, T10>(create: Create_In, @try: Try_In, @catch: Catch_In, @finally: Finally_In, reInitialize: Re_Initialize_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Synchronizer.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create<TState, T, T2>(n3.NodeContext Node_Context, out n4.Synchronizer<TState, T, T2> Output_Out)
        {
            var Output_0 = new n4.Synchronizer<TState, T, T2>();
            Output_Out = Output_0;
            return;
        }

        public static void Update<TState, T, T2>(n4.Synchronizer<TState, T, T2> Input__this__In, n10.IEnumerable<T> Input_In, n5.Func<T, n5.Object> Key_Selector_In, n5.Func<T, TState> Create_In, n5.Func<TState, T, n5.Tuple<TState, T2>> Updator_In, out n4.Synchronizer<TState, T, T2> Output_Out, out n9.Spread<T2> Outputs_Out)
        {
            var Output_1 = Input__this__In.Update(input: Input_In, keySelector: Key_Selector_In, create: Create_In, updator: Updator_In, outputs: out n9.Spread<T2> Outputs_0);
            Output_Out = Output_1;
            Outputs_Out = Outputs_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Synchronizer_InputIsKey.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create<TState, T, T2>(n3.NodeContext Node_Context, out n4.SynchronizerInputIsKey<TState, T, T2> Output_Out)
        {
            var Output_0 = new n4.SynchronizerInputIsKey<TState, T, T2>();
            Output_Out = Output_0;
            return;
        }

        public static void Update<TState, T, T2>(n4.SynchronizerInputIsKey<TState, T, T2> Input__this__In, n10.IEnumerable<T> Input_In, n5.Func<T, TState> Create_In, n5.Func<TState, T, n5.Tuple<TState, T2>> Updator_In, out n4.SynchronizerInputIsKey<TState, T, T2> Output_Out, out n9.Spread<T2> Outputs_Out)
        {
            var Output_1 = Input__this__In.Update(input: Input_In, create: Create_In, updator: Updator_In, outputs: out n9.Spread<T2> Outputs_0);
            Output_Out = Output_1;
            Outputs_Out = Outputs_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Synchronizer_VLObjectInput.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create<TState, T2, T>(n3.NodeContext Node_Context, out n4.SynchronizerVLObjectInput<TState, T2, T> Output_Out)
            where T2 : n3.IVLObject
        {
            var Output_0 = new n4.SynchronizerVLObjectInput<TState, T2, T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update<TState, T2, T>(n4.SynchronizerVLObjectInput<TState, T2, T> Input__this__In, n10.IEnumerable<T2> Input_In, n5.Func<T2, TState> Create_In, n5.Func<TState, T2, n5.Tuple<TState, T>> Updator_In, out n4.SynchronizerVLObjectInput<TState, T2, T> Output_Out, out n9.Spread<T> Outputs_Out)
            where T2 : n3.IVLObject
        {
            var Output_1 = Input__this__In.Update(input: Input_In, create: Create_In, updator: Updator_In, outputs: out n9.Spread<T> Outputs_0);
            Output_Out = Output_1;
            Outputs_Out = Outputs_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Try__1_Output.Obsolete.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryStateful<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryStateful<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T>(n4.TryStateful<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T>> Try_In, T Default_Output_In, bool Re_Initialize_In, out n4.TryStateful<TState> Output_Out, out T Result_Out, out bool Success_Out, out string Error_Message_Out)
            where TState : class
        {
            var Result_2 = Input_In.Update<T>(create: Create_In, @try: Try_In, defaultOutput: Default_Output_In, reInitialize: Re_Initialize_In, success: out bool Success_0, errorMessage: out string Error_Message_1);
            Output_Out = Input_In;
            Result_Out = Result_2;
            Success_Out = Success_0;
            Error_Message_Out = Error_Message_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Try__2Outputs.Obsolete.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryStateful2<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryStateful2<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T2, T>(n4.TryStateful2<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T2, T>> Try_In, T2 Default_Output_1_In, T Default_Output_2_In, bool Re_Initialize_In, out n4.TryStateful2<TState> Output_Out, out T2 Output_1_Out, out T Output_2_Out, out bool Success_Out, out string Error_Message_Out)
            where TState : class
        {
            Input_In.Update<T2, T>(create: Create_In, @try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, reInitialize: Re_Initialize_In, output1: out T2 Output_1_0, output2: out T Output_2_1, success: out bool Success_2, errorMessage: out string Error_Message_3);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Success_Out = Success_2;
            Error_Message_Out = Error_Message_3;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Try__3Outputs.Obsolete.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryStateful3<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryStateful3<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T3, T2, T>(n4.TryStateful3<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T3, T2, T>> Try_In, T3 Default_Output_1_In, T2 Default_Output_2_In, T Default_Output_3_In, bool Re_Initialize_In, out n4.TryStateful3<TState> Output_Out, out T3 Output_1_Out, out T2 Output_2_Out, out T Output_3_Out, out bool Success_Out, out string Error_Message_Out)
            where TState : class
        {
            Input_In.Update<T3, T2, T>(create: Create_In, @try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, reInitialize: Re_Initialize_In, output1: out T3 Output_1_0, output2: out T2 Output_2_1, output3: out T Output_3_2, success: out bool Success_3, errorMessage: out string Error_Message_4);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Success_Out = Success_3;
            Error_Message_Out = Error_Message_4;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Try__4Outputs.Obsolete.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryStateful4<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryStateful4<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T4, T3, T2, T>(n4.TryStateful4<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T4, T3, T2, T>> Try_In, T4 Default_Output_1_In, T3 Default_Output_2_In, T2 Default_Output_3_In, T Default_Output_4_In, bool Re_Initialize_In, out n4.TryStateful4<TState> Output_Out, out T4 Output_1_Out, out T3 Output_2_Out, out T2 Output_3_Out, out T Output_4_Out, out bool Success_Out, out string Error_Message_Out)
            where TState : class
        {
            Input_In.Update<T4, T3, T2, T>(create: Create_In, @try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, defaultOutput4: Default_Output_4_In, reInitialize: Re_Initialize_In, output1: out T4 Output_1_0, output2: out T3 Output_2_1, output3: out T2 Output_3_2, output4: out T Output_4_3, success: out bool Success_4, errorMessage: out string Error_Message_5);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Success_Out = Success_4;
            Error_Message_Out = Error_Message_5;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Try__5Outputs.Obsolete.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState>(n3.NodeContext Node_Context, out n4.TryStateful5<TState> Output_Out)
            where TState : class
        {
            var Output_0 = new n4.TryStateful5<TState>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T5, T4, T3, T2, T>(n4.TryStateful5<TState> Input_In, n5.Func<TState> Create_In, n5.Func<TState, n5.Tuple<TState, T5, T4, T3, T2, T>> Try_In, T5 Default_Output_1_In, T4 Default_Output_2_In, T3 Default_Output_3_In, T2 Default_Output_4_In, T Default_Output_5_In, bool Re_Initialize_In, out n4.TryStateful5<TState> Output_Out, out T5 Output_1_Out, out T4 Output_2_Out, out T3 Output_3_Out, out T2 Output_4_Out, out T Output_5_Out, out bool Success_Out, out string Error_Message_Out)
            where TState : class
        {
            Input_In.Update<T5, T4, T3, T2, T>(create: Create_In, @try: Try_In, defaultOutput1: Default_Output_1_In, defaultOutput2: Default_Output_2_In, defaultOutput3: Default_Output_3_In, defaultOutput4: Default_Output_4_In, defaultOutput5: Default_Output_5_In, reInitialize: Re_Initialize_In, output1: out T5 Output_1_0, output2: out T4 Output_2_1, output3: out T3 Output_3_2, output4: out T2 Output_4_3, output5: out T Output_5_4, success: out bool Success_5, errorMessage: out string Error_Message_6);
            Output_Out = Input_In;
            Output_1_Out = Output_1_0;
            Output_2_Out = Output_2_1;
            Output_3_Out = Output_3_2;
            Output_4_Out = Output_4_3;
            Output_5_Out = Output_5_4;
            Success_Out = Success_5;
            Error_Message_Out = Error_Message_6;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Parallel.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ThreadSleep(int Milliseconds_Timeout_In)
        {
            n17.Thread.Sleep(millisecondsTimeout: Milliseconds_Timeout_In);
            return;
        }

        public static void CurrentThreadId(out int Managed_Thread_Id_Out)
        {
            var Current_Thread_0 = n17.Thread.CurrentThread;
            var Managed_Thread_Id_1 = Current_Thread_0.ManagedThreadId;
            Managed_Thread_Id_Out = Managed_Thread_Id_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Control.Parallel.ForEach.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create_H<TState, T>(n3.NodeContext Node_Context, out n19.ForEach<TState, T> Output_Out)
            where TState : class
        {
            var Output_0 = new n19.ForEach<TState, T>();
            Output_Out = Output_0;
            return;
        }

        public static void Update_H<TState, T, T2>(n19.ForEach<TState, T> Input__this__In, n10.IReadOnlyList<T2> Input_In, n5.Func<TState> Create_In, n5.Func<TState, T2, int, n5.Tuple<TState, T>> Update_In, out n19.ForEach<TState, T> Output_Out, out n9.SpreadBuilder<T> Result_Out)
            where TState : class
        {
            var Result_0 = Input__this__In.Update<T2>(input: Input_In, create: Create_In, update: Update_In);
            Output_Out = Input__this__In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.IPInterfaceStatistics.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.IPInterfaceStatistics Input_In, out long Bytes_Received_Out, out long Bytes_Sent_Out, out long Incoming_Packets_Discarded_Out, out long Incoming_Packets_With_Errors_Out, out long Incoming_Unknown_Protocol_Packets_Out, out long Non_Unicast_Packets_Received_Out, out long Non_Unicast_Packets_Sent_Out, out long Outgoing_Packets_Discarded_Out, out long Outgoing_Packets_With_Errors_Out, out long Output_Queue_Length_Out, out long Unicast_Packets_Received_Out, out long Unicast_Packets_Sent_Out)
        {
            n7.NetworkInterfaceUtils.Split(iPInterfaceStatistics: Input_In, bytesReceived: out long Bytes_Received_0, bytesSent: out long Bytes_Sent_1, incomingPacketsDiscarded: out long Incoming_Packets_Discarded_2, incomingPacketsWithErrors: out long Incoming_Packets_With_Errors_3, incomingUnknownProtocolPackets: out long Incoming_Unknown_Protocol_Packets_4, nonUnicastPacketsReceived: out long Non_Unicast_Packets_Received_5, nonUnicastPacketsSent: out long Non_Unicast_Packets_Sent_6, outgoingPacketsDiscarded: out long Outgoing_Packets_Discarded_7, outgoingPacketsWithErrors: out long Outgoing_Packets_With_Errors_8, outputQueueLength: out long Output_Queue_Length_9, unicastPacketsReceived: out long Unicast_Packets_Received_10, unicastPacketsSent: out long Unicast_Packets_Sent_11);
            Bytes_Received_Out = Bytes_Received_0;
            Bytes_Sent_Out = Bytes_Sent_1;
            Incoming_Packets_Discarded_Out = Incoming_Packets_Discarded_2;
            Incoming_Packets_With_Errors_Out = Incoming_Packets_With_Errors_3;
            Incoming_Unknown_Protocol_Packets_Out = Incoming_Unknown_Protocol_Packets_4;
            Non_Unicast_Packets_Received_Out = Non_Unicast_Packets_Received_5;
            Non_Unicast_Packets_Sent_Out = Non_Unicast_Packets_Sent_6;
            Outgoing_Packets_Discarded_Out = Outgoing_Packets_Discarded_7;
            Outgoing_Packets_With_Errors_Out = Outgoing_Packets_With_Errors_8;
            Output_Queue_Length_Out = Output_Queue_Length_9;
            Unicast_Packets_Received_Out = Unicast_Packets_Received_10;
            Unicast_Packets_Sent_Out = Unicast_Packets_Sent_11;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.IPv4InterfaceProperties.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.IPv4InterfaceProperties Input_In, out int Index_Out, out int Mtu_Out, out bool Uses_Wins_Out, out bool Is_Dhcp_Enabled_Out, out bool Is_Automatic_Private_Addressing_Active_Out, out bool Is_Automatic_Private_Addressing_Enabled_Out, out bool Is_Forwarding_Enabled_Out)
        {
            n7.NetworkInterfaceUtils.Split(iPv4InterfaceProperties: Input_In, index: out int Index_0, mtu: out int Mtu_1, usesWins: out bool Uses_Wins_2, isDhcpEnabled: out bool Is_Dhcp_Enabled_3, isAutomaticPrivateAddressingActive: out bool Is_Automatic_Private_Addressing_Active_4, isAutomaticPrivateAddressingEnabled: out bool Is_Automatic_Private_Addressing_Enabled_5, isForwardingEnabled: out bool Is_Forwarding_Enabled_6);
            Index_Out = Index_0;
            Mtu_Out = Mtu_1;
            Uses_Wins_Out = Uses_Wins_2;
            Is_Dhcp_Enabled_Out = Is_Dhcp_Enabled_3;
            Is_Automatic_Private_Addressing_Active_Out = Is_Automatic_Private_Addressing_Active_4;
            Is_Automatic_Private_Addressing_Enabled_Out = Is_Automatic_Private_Addressing_Enabled_5;
            Is_Forwarding_Enabled_Out = Is_Forwarding_Enabled_6;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.NetworkInterface.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.NetworkInterface Input_In, out string Name_Out, out string Description_Out, out string Id_Out, out bool Is_Receive_Only_Out, out n8.NetworkInterfaceType Network_Interface_Type_Out, out n8.OperationalStatus Operational_Status_Out, out long Speed_Out, out bool Supports_Multicast_Out)
        {
            n7.NetworkInterfaceUtils.Split(networkInterface: Input_In, name: out string Name_0, description: out string Description_1, id: out string Id_2, isReceiveOnly: out bool Is_Receive_Only_3, networkInterfaceType: out n8.NetworkInterfaceType Network_Interface_Type_4, operationalStatus: out n8.OperationalStatus Operational_Status_5, speed: out long Speed_6, supportsMulticast: out bool Supports_Multicast_7);
            Name_Out = Name_0;
            Description_Out = Description_1;
            Id_Out = Id_2;
            Is_Receive_Only_Out = Is_Receive_Only_3;
            Network_Interface_Type_Out = Network_Interface_Type_4;
            Operational_Status_Out = Operational_Status_5;
            Speed_Out = Speed_6;
            Supports_Multicast_Out = Supports_Multicast_7;
            return;
        }

        public static void Supports(n8.NetworkInterface Input_In, out bool Supports_IPv_4_Out, out bool Supports_IPv_6_Out)
        {
            n7.NetworkInterfaceUtils.Supports(networkInterface: Input_In, supportsIPv4: out bool Supports_IPv_4_0, supportsIPv6: out bool Supports_IPv_6_1);
            Supports_IPv_4_Out = Supports_IPv_4_0;
            Supports_IPv_6_Out = Supports_IPv_6_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.UnicastIPAddressInformation.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.UnicastIPAddressInformation Input_In, out long Address_Preferred_Lifetime_Out, out long Address_Valid_Lifetime_Out, out long Dhcp_Lease_Lifetime_Out, out n8.DuplicateAddressDetectionState Duplicate_Address_Detection_State_Out, out n8.PrefixOrigin Prefix_Origin_Out, out n8.SuffixOrigin Suffix_Origin_Out, out n11.IPAddress I_Pv_4Mask_Out, out int Prefix_Length_Out, out n11.IPAddress Address_Out, out bool Is_Dns_Eligible_Out, out bool Is_Transient_Out)
        {
            n7.NetworkInterfaceUtils.Split(unicastIPAddressInformation: Input_In, addressPreferredLifetime: out long Address_Preferred_Lifetime_0, addressValidLifetime: out long Address_Valid_Lifetime_1, dhcpLeaseLifetime: out long Dhcp_Lease_Lifetime_2, duplicateAddressDetectionState: out n8.DuplicateAddressDetectionState Duplicate_Address_Detection_State_3, prefixOrigin: out n8.PrefixOrigin Prefix_Origin_4, suffixOrigin: out n8.SuffixOrigin Suffix_Origin_5, iPv4Mask: out n11.IPAddress I_Pv_4Mask_6, prefixLength: out int Prefix_Length_7, address: out n11.IPAddress Address_8, isDnsEligible: out bool Is_Dns_Eligible_9, isTransient: out bool Is_Transient_10);
            Address_Preferred_Lifetime_Out = Address_Preferred_Lifetime_0;
            Address_Valid_Lifetime_Out = Address_Valid_Lifetime_1;
            Dhcp_Lease_Lifetime_Out = Dhcp_Lease_Lifetime_2;
            Duplicate_Address_Detection_State_Out = Duplicate_Address_Detection_State_3;
            Prefix_Origin_Out = Prefix_Origin_4;
            Suffix_Origin_Out = Suffix_Origin_5;
            I_Pv_4Mask_Out = I_Pv_4Mask_6;
            Prefix_Length_Out = Prefix_Length_7;
            Address_Out = Address_8;
            Is_Dns_Eligible_Out = Is_Dns_Eligible_9;
            Is_Transient_Out = Is_Transient_10;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.IPInterfaceProperties.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.IPInterfaceProperties Input_In, out n9.Spread<n8.IPAddressInformation> Anycast_Addresses_Out, out n9.Spread<n11.IPAddress> Dhcp_Server_Addresses_Out, out n9.Spread<n11.IPAddress> Dns_Addresses_Out, out string Dns_Suffix_Out, out n9.Spread<n11.IPAddress> Gateway_Addresses_Out, out bool Is_Dns_Enabled_Out, out bool Is_Dynamic_Dns_Enabled_Out, out n9.Spread<n8.MulticastIPAddressInformation> Multicast_Addresses_Out, out n9.Spread<n8.UnicastIPAddressInformation> Unicast_Addresses_Out, out n9.Spread<n11.IPAddress> Wins_Servers_Addresses_Out)
        {
            n7.NetworkInterfaceUtils.Split(iPInterfaceProperties: Input_In, anycastAddresses: out n9.Spread<n8.IPAddressInformation> Anycast_Addresses_0, dhcpServerAddresses: out n9.Spread<n11.IPAddress> Dhcp_Server_Addresses_1, dnsAddresses: out n9.Spread<n11.IPAddress> Dns_Addresses_2, dnsSuffix: out string Dns_Suffix_3, gatewayAddresses: out n9.Spread<n11.IPAddress> Gateway_Addresses_4, isDnsEnabled: out bool Is_Dns_Enabled_5, isDynamicDnsEnabled: out bool Is_Dynamic_Dns_Enabled_6, multicastAddresses: out n9.Spread<n8.MulticastIPAddressInformation> Multicast_Addresses_7, unicastAddresses: out n9.Spread<n8.UnicastIPAddressInformation> Unicast_Addresses_8, winsServersAddresses: out n9.Spread<n11.IPAddress> Wins_Servers_Addresses_9);
            Anycast_Addresses_Out = Anycast_Addresses_0;
            Dhcp_Server_Addresses_Out = Dhcp_Server_Addresses_1;
            Dns_Addresses_Out = Dns_Addresses_2;
            Dns_Suffix_Out = Dns_Suffix_3;
            Gateway_Addresses_Out = Gateway_Addresses_4;
            Is_Dns_Enabled_Out = Is_Dns_Enabled_5;
            Is_Dynamic_Dns_Enabled_Out = Is_Dynamic_Dns_Enabled_6;
            Multicast_Addresses_Out = Multicast_Addresses_7;
            Unicast_Addresses_Out = Unicast_Addresses_8;
            Wins_Servers_Addresses_Out = Wins_Servers_Addresses_9;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.IPv4InterfaceStatistics.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.IPv4InterfaceStatistics Input_In, out long Bytes_Received_Out, out long Bytes_Sent_Out, out long Incoming_Packets_Discarded_Out, out long Incoming_Packets_With_Errors_Out, out long Incoming_Unknown_Protocol_Packets_Out, out long Non_Unicast_Packets_Received_Out, out long Non_Unicast_Packets_Sent_Out, out long Outgoing_Packets_Discarded_Out, out long Outgoing_Packets_With_Errors_Out, out long Output_Queue_Length_Out, out long Unicast_Packets_Received_Out, out long Unicast_Packets_Sent_Out)
        {
            n7.NetworkInterfaceUtils.Split(iPv4InterfaceStatistics: Input_In, bytesReceived: out long Bytes_Received_0, bytesSent: out long Bytes_Sent_1, incomingPacketsDiscarded: out long Incoming_Packets_Discarded_2, incomingPacketsWithErrors: out long Incoming_Packets_With_Errors_3, incomingUnknownProtocolPackets: out long Incoming_Unknown_Protocol_Packets_4, nonUnicastPacketsReceived: out long Non_Unicast_Packets_Received_5, nonUnicastPacketsSent: out long Non_Unicast_Packets_Sent_6, outgoingPacketsDiscarded: out long Outgoing_Packets_Discarded_7, outgoingPacketsWithErrors: out long Outgoing_Packets_With_Errors_8, outputQueueLength: out long Output_Queue_Length_9, unicastPacketsReceived: out long Unicast_Packets_Received_10, unicastPacketsSent: out long Unicast_Packets_Sent_11);
            Bytes_Received_Out = Bytes_Received_0;
            Bytes_Sent_Out = Bytes_Sent_1;
            Incoming_Packets_Discarded_Out = Incoming_Packets_Discarded_2;
            Incoming_Packets_With_Errors_Out = Incoming_Packets_With_Errors_3;
            Incoming_Unknown_Protocol_Packets_Out = Incoming_Unknown_Protocol_Packets_4;
            Non_Unicast_Packets_Received_Out = Non_Unicast_Packets_Received_5;
            Non_Unicast_Packets_Sent_Out = Non_Unicast_Packets_Sent_6;
            Outgoing_Packets_Discarded_Out = Outgoing_Packets_Discarded_7;
            Outgoing_Packets_With_Errors_Out = Outgoing_Packets_With_Errors_8;
            Output_Queue_Length_Out = Output_Queue_Length_9;
            Unicast_Packets_Received_Out = Unicast_Packets_Received_10;
            Unicast_Packets_Sent_Out = Unicast_Packets_Sent_11;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.IPv6InterfaceProperties.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n8.IPv6InterfaceProperties Input_In, out int Index_Out, out int Mtu_Out)
        {
            n7.NetworkInterfaceUtils.Split(iPv6InterfaceProperties: Input_In, index: out int Index_0, mtu: out int Mtu_1);
            Index_Out = Index_0;
            Mtu_Out = Mtu_1;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Net.HTTPServer.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create(n3.NodeContext Node_Context, n12.Path Path_In, [n6.SerializedDefaultValueAttribute("80", false)] int Port_In, out n7.HTTPServer Output_Out)
        {
            var Output_0 = new n7.HTTPServer(path: Path_In, port: Port_In);
            Output_Out = Output_0;
            return;
        }

        public static void Destroy(n7.HTTPServer Input_In, out n7.HTTPServer Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Socket.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ReceiveFrom(n15.IResourceProvider<n14.Socket> Input_In, int Time_Out_In, out n15.IResourceProvider<n14.Socket> Output_Out, out n9.Spread<byte> Data_Out, out n11.IPEndPoint Remote_Out, out bool Timed_Out_Out)
        {
            var Output_3 = n13.SocketUtils.ReceiveFrom(input: Input_In, timeOut: Time_Out_In, data: out n9.Spread<byte> Data_0, remote: out n11.IPEndPoint Remote_1, timedOut: out bool Timed_Out_2);
            Output_Out = Output_3;
            Data_Out = Data_0;
            Remote_Out = Remote_1;
            Timed_Out_Out = Timed_Out_2;
            return;
        }

        public static void Send(n15.IResourceProvider<n14.Socket> Input_In, int Time_Out_In, n10.IEnumerable<byte> Data_In, bool Send_In, out n15.IResourceProvider<n14.Socket> Output_Out, out bool Timed_Out_Out)
        {
            var Output_1 = n13.SocketUtils.Send(input: Input_In, timeOut: Time_Out_In, data: Data_In, send: Send_In, timedOut: out bool Timed_Out_0);
            Output_Out = Output_1;
            Timed_Out_Out = Timed_Out_0;
            return;
        }

        public static void SendTo(n15.IResourceProvider<n14.Socket> Input_In, int Time_Out_In, n11.IPAddress Remote_Address_In, int Remote_Port_In, n10.IEnumerable<byte> Data_In, bool Send_In, out n15.IResourceProvider<n14.Socket> Output_Out, out bool Timed_Out_Out)
        {
            var Output_1 = n13.SocketUtils.SendTo(input: Input_In, timeOut: Time_Out_In, remoteAddress: Remote_Address_In, remotePort: Remote_Port_In, data: Data_In, send: Send_In, timedOut: out bool Timed_Out_0);
            Output_Out = Output_1;
            Timed_Out_Out = Timed_Out_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.Socket.SocketProvider.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create<T>(n3.NodeContext Node_Context, T Clock_In, out n13.SocketProvider Output_Out)
            where T : n16.IFrameClock
        {
            n16.IFrameClock Clock_0 = (n16.IFrameClock)Clock_In;
            var Output_1 = new n13.SocketProvider(clock: Clock_0);
            Output_Out = Output_1;
            return;
        }

        public static void Update(n13.SocketProvider Input_In, n14.SocketType Socket_Type_In, n14.ProtocolType Protocol_Type_In, n11.IPAddress Local_Address_In, int Local_Port_In, out n13.SocketProvider Output_Out, out n15.IResourceProvider<n14.Socket> Result_Out, out bool Changed_Out)
        {
            var Result_1 = Input_In.Update(socketType: Socket_Type_In, protocolType: Protocol_Type_In, localAddress: Local_Address_In, localPort: Local_Port_In, changed: out bool Changed_0);
            Output_Out = Input_In;
            Result_Out = Result_1;
            Changed_Out = Changed_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.WebRequest.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void AddHeaders(n11.WebRequest Input_In, n10.IEnumerable<string> Headers_In, out n11.HttpWebRequest Result_Out)
        {
            var Result_0 = n20.Webrequest.AddHeaders(webRequest: Input_In, headers: Headers_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetHttpResponse(n11.WebRequest Input_In, out n15.IResourceProvider<n11.HttpWebResponse> Result_Out, out string Status_Out)
        {
            var Result_1 = n20.Webrequest.GetHttpResponse(webRequest: Input_In, status: out string Status_0);
            Result_Out = Result_1;
            Status_Out = Status_0;
            return;
        }

        public static void GetRequestStream(n11.WebRequest Input_In, out n15.IResourceProvider<n22.Stream> Result_Out)
        {
            var Result_0 = n20.Webrequest.GetRequestStream(webRequest: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetResponse(n11.WebRequest Input_In, out n15.IResourceProvider<n11.WebResponse> Result_Out)
        {
            var Result_0 = n20.Webrequest.GetResponse(webRequest: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void SetProxy(n11.WebRequest Input_In, n11.ICredentials Credentials_In, string Uri_In, [n6.SerializedDefaultValueAttribute("8080", false)] int Port_In, out n11.HttpWebRequest Result_Out)
        {
            var Result_0 = n20.Webrequest.SetProxy(webRequest: Input_In, credentials: Credentials_In, uri: Uri_In, port: Port_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.WebRequest.HttpWebRequest.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Accept(n11.HttpWebRequest Input_In, out string Accept_Out)
        {
            var Accept_0 = Input_In.Accept;
            Accept_Out = Accept_0;
            return;
        }

        public static void Connection(n11.HttpWebRequest Input_In, out string Connection_Out)
        {
            var Connection_0 = Input_In.Connection;
            Connection_Out = Connection_0;
            return;
        }

        public static void ContinueTimeout(n11.HttpWebRequest Input_In, out int Continue_Timeout_Out)
        {
            var Continue_Timeout_0 = Input_In.ContinueTimeout;
            Continue_Timeout_Out = Continue_Timeout_0;
            return;
        }

        public static void Date(n11.HttpWebRequest Input_In, out n5.DateTime Date_Out)
        {
            var Date_0 = Input_In.Date;
            Date_Out = Date_0;
            return;
        }

        public static void Host(n11.HttpWebRequest Input_In, out string Host_Out)
        {
            var Host_0 = Input_In.Host;
            Host_Out = Host_0;
            return;
        }

        public static void KeepAlive(n11.HttpWebRequest Input_In, out bool Keep_Alive_Out)
        {
            var Keep_Alive_0 = Input_In.KeepAlive;
            Keep_Alive_Out = Keep_Alive_0;
            return;
        }

        public static void MediaType(n11.HttpWebRequest Input_In, out string Media_Type_Out)
        {
            var Media_Type_0 = Input_In.MediaType;
            Media_Type_Out = Media_Type_0;
            return;
        }

        public static void ProtocolVersion(n11.HttpWebRequest Input_In, out n5.Version Protocol_Version_Out)
        {
            var Protocol_Version_0 = Input_In.ProtocolVersion;
            Protocol_Version_Out = Protocol_Version_0;
            return;
        }

        public static void ReadWriteTimeout(n11.HttpWebRequest Input_In, out int Read_Write_Timeout_Out)
        {
            var Read_Write_Timeout_0 = Input_In.ReadWriteTimeout;
            Read_Write_Timeout_Out = Read_Write_Timeout_0;
            return;
        }

        public static void Referer(n11.HttpWebRequest Input_In, out string Referer_Out)
        {
            var Referer_0 = Input_In.Referer;
            Referer_Out = Referer_0;
            return;
        }

        public static void SendChunked(n11.HttpWebRequest Input_In, out bool Send_Chunked_Out)
        {
            var Send_Chunked_0 = Input_In.SendChunked;
            Send_Chunked_Out = Send_Chunked_0;
            return;
        }

        public static void SetAccept(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.Accept = Value_In;
            return;
        }

        public static void SetConnection(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.Connection = Value_In;
            return;
        }

        public static void SetContinueTimeout(n11.HttpWebRequest Input_In, int Value_In)
        {
            Input_In.ContinueTimeout = Value_In;
            return;
        }

        public static void SetDate(n11.HttpWebRequest Input_In, n5.DateTime Value_In)
        {
            Input_In.Date = Value_In;
            return;
        }

        public static void SetHost(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.Host = Value_In;
            return;
        }

        public static void SetKeepAlive(n11.HttpWebRequest Input_In, bool Value_In)
        {
            Input_In.KeepAlive = Value_In;
            return;
        }

        public static void SetMediaType(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.MediaType = Value_In;
            return;
        }

        public static void SetProtocolVersion(n11.HttpWebRequest Input_In, n5.Version Value_In)
        {
            Input_In.ProtocolVersion = Value_In;
            return;
        }

        public static void SetReadWriteTimeout(n11.HttpWebRequest Input_In, int Value_In)
        {
            Input_In.ReadWriteTimeout = Value_In;
            return;
        }

        public static void SetReferer(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.Referer = Value_In;
            return;
        }

        public static void SetSendChunked(n11.HttpWebRequest Input_In, bool Value_In)
        {
            Input_In.SendChunked = Value_In;
            return;
        }

        public static void SetTransferEncoding(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.TransferEncoding = Value_In;
            return;
        }

        public static void SetUnsafeAuthenticatedConnectionSharing(n11.HttpWebRequest Input_In, bool Value_In)
        {
            Input_In.UnsafeAuthenticatedConnectionSharing = Value_In;
            return;
        }

        public static void SetUserAgent(n11.HttpWebRequest Input_In, string Value_In)
        {
            Input_In.UserAgent = Value_In;
            return;
        }

        public static void TransferEncoding(n11.HttpWebRequest Input_In, out string Transfer_Encoding_Out)
        {
            var Transfer_Encoding_0 = Input_In.TransferEncoding;
            Transfer_Encoding_Out = Transfer_Encoding_0;
            return;
        }

        public static void UnsafeAuthenticatedConnectionSharing(n11.HttpWebRequest Input_In, out bool Unsafe_Authenticated_Connection_Sharing_Out)
        {
            var Unsafe_Authenticated_Connection_Sharing_0 = Input_In.UnsafeAuthenticatedConnectionSharing;
            Unsafe_Authenticated_Connection_Sharing_Out = Unsafe_Authenticated_Connection_Sharing_0;
            return;
        }

        public static void UserAgent(n11.HttpWebRequest Input_In, out string User_Agent_Out)
        {
            var User_Agent_0 = Input_In.UserAgent;
            User_Agent_Out = User_Agent_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.WebRequest.HttpWebResponse.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CharacterSet(n11.HttpWebResponse Input_In, out string Character_Set_Out)
        {
            var Character_Set_0 = Input_In.CharacterSet;
            Character_Set_Out = Character_Set_0;
            return;
        }

        public static void ContentEncoding(n11.HttpWebResponse Input_In, out string Content_Encoding_Out)
        {
            var Content_Encoding_0 = Input_In.ContentEncoding;
            Content_Encoding_Out = Content_Encoding_0;
            return;
        }

        public static void LastModified(n11.HttpWebResponse Input_In, out n5.DateTime Last_Modified_Out)
        {
            var Last_Modified_0 = Input_In.LastModified;
            Last_Modified_Out = Last_Modified_0;
            return;
        }

        public static void Method(n11.HttpWebResponse Input_In, out string Method_Out)
        {
            var Method_0 = Input_In.Method;
            Method_Out = Method_0;
            return;
        }

        public static void ProtocolVersion(n11.HttpWebResponse Input_In, out n5.Version Protocol_Version_Out)
        {
            var Protocol_Version_0 = Input_In.ProtocolVersion;
            Protocol_Version_Out = Protocol_Version_0;
            return;
        }

        public static void Server(n11.HttpWebResponse Input_In, out string Server_Out)
        {
            var Server_0 = Input_In.Server;
            Server_Out = Server_0;
            return;
        }

        public static void StatusCode(n11.HttpWebResponse Input_In, out n11.HttpStatusCode Status_Code_Out)
        {
            var Status_Code_0 = Input_In.StatusCode;
            Status_Code_Out = Status_Code_0;
            return;
        }

        public static void StatusDescription(n11.HttpWebResponse Input_In, out string Status_Description_Out)
        {
            var Status_Description_0 = Input_In.StatusDescription;
            Status_Description_Out = Status_Description_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.WebRequest.WebRequest.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ContentLength(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out long Content_Length_Out)
        {
            var Content_Length_0 = Input_In.ContentLength;
            Output_Out = Input_In;
            Content_Length_Out = Content_Length_0;
            return;
        }

        public static void ContentType(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out string Content_Type_Out)
        {
            var Content_Type_0 = Input_In.ContentType;
            Output_Out = Input_In;
            Content_Type_Out = Content_Type_0;
            return;
        }

        [n6.CreateNewAttribute]
        public static void Create(n3.NodeContext Node_Context, string Request_Uri_String_In, out n11.WebRequest Result_Out)
        {
            var Result_0 = n11.WebRequest.Create(requestUriString: Request_Uri_String_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateHttp(string Request_Uri_String_In, out n11.HttpWebRequest Result_Out)
        {
            var Result_0 = n11.WebRequest.CreateHttp(requestUriString: Request_Uri_String_In);
            Result_Out = Result_0;
            return;
        }

        public static void Credentials(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out n11.ICredentials Credentials_Out)
        {
            var Credentials_0 = Input_In.Credentials;
            Output_Out = Input_In;
            Credentials_Out = Credentials_0;
            return;
        }

        public static void Method(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out string Method_Out)
        {
            var Method_0 = Input_In.Method;
            Output_Out = Input_In;
            Method_Out = Method_0;
            return;
        }

        public static void PreAuthenticate(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out bool Pre_Authenticate_Out)
        {
            var Pre_Authenticate_0 = Input_In.PreAuthenticate;
            Output_Out = Input_In;
            Pre_Authenticate_Out = Pre_Authenticate_0;
            return;
        }

        public static void SetContentLength(n11.WebRequest Input_In, long Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.ContentLength = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetContentType(n11.WebRequest Input_In, string Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.ContentType = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetCredentials(n11.WebRequest Input_In, n11.ICredentials Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.Credentials = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetMethod(n11.WebRequest Input_In, string Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.Method = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetPreAuthenticate(n11.WebRequest Input_In, bool Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.PreAuthenticate = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetTimeout(n11.WebRequest Input_In, int Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.Timeout = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetUseDefaultCredentials(n11.WebRequest Input_In, bool Value_In, out n11.WebRequest Output_Out)
        {
            Input_In.UseDefaultCredentials = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void Timeout(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out int Timeout_Out)
        {
            var Timeout_0 = Input_In.Timeout;
            Output_Out = Input_In;
            Timeout_Out = Timeout_0;
            return;
        }

        public static void UseDefaultCredentials(n11.WebRequest Input_In, out n11.WebRequest Output_Out, out bool Use_Default_Credentials_Out)
        {
            var Use_Default_Credentials_0 = Input_In.UseDefaultCredentials;
            Output_Out = Input_In;
            Use_Default_Credentials_Out = Use_Default_Credentials_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.IO.WebRequest.WebResponse.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ContentLength(n11.WebResponse Input_In, out long Content_Length_Out)
        {
            var Content_Length_0 = Input_In.ContentLength;
            Content_Length_Out = Content_Length_0;
            return;
        }

        public static void ContentType(n11.WebResponse Input_In, out string Content_Type_Out)
        {
            var Content_Type_0 = Input_In.ContentType;
            Content_Type_Out = Content_Type_0;
            return;
        }

        public static void SetContentLength(n11.WebResponse Input_In, long Value_In)
        {
            Input_In.ContentLength = Value_In;
            return;
        }

        public static void SetContentType(n11.WebResponse Input_In, string Value_In)
        {
            Input_In.ContentType = Value_In;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Primitive.Exception.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void UnspecifiedException(out n5.Exception Unspecified_Exception_Out)
        {
            var Unspecified_Exception_0 = n4.ExceptionUtils.UnspecifiedException;
            Unspecified_Exception_Out = Unspecified_Exception_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Primitive.Experimental
{
    [n3.ElementAttribute(TracingId = 126447U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "SMiVmmAKtO6ON6v0GtlOUu", Name = "PersistentState_SMiVmmAKtO6ON6v0GtlOUu")]
    [n5.SerializableAttribute]
    public class PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> : n3.VLObject, n5.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> Create<AdM>(n3.NodeContext Node_Context_In)
            where AdM : struct, n25.IAdaptiveCreateDefault<T>
        {
            var instance = new PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T>(Node_Context_In, n3.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context_In);
        }

        [n6.CreateDefaultAttribute]
        public static n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> CreateDefault<AdM>()
            where AdM : struct, n25.IAdaptiveCreateDefault<T>
        {
            var instance = new PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T>(n3.NodeContext.Default, n3.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> Update(bool Run_In, n5.Func<T> Update_In, T State_In, bool Store_In, bool Recall_In, out T Output_Out)
        {
            string __pad_L4eKSUHmOLfQEmXleW4ov5_0 = __slot_L4eKSUHmOLfQEmXleW4ov5;
            n3.UniqueId __pad_NUqQoKE2YbJMTtAvqb9svj_1 = this.__slot_NUqQoKE2YbJMTtAvqb9svj;
            T __auto_2 = this.Value;
            T __auto_3;
            if (Run_In)
            {
                n18._Operations_.Invoke<T>(Input_In: Update_In, Result_Out: out T Result_5);
                __auto_3 = Result_5;
            }
            else
            {
                __auto_3 = __auto_2;
            }

            var State_Output_7 = this.__p_ApC4IQS0OzzOPTxqvxzaci.Update(Simulate_In: Recall_In, Output_Out: out bool Output_6);
            n26._Operations_.Switch_Boolean<T>(Condition_In: Output_6, Input_In: __auto_3, Input_2_In: State_In, Output_Out: out T Output_8);
            T __auto_9 = Output_8;
            if (Store_In)
            {
                var Instance_11 = n27.VLSession.Instance;
                var Current_Solution_12 = Instance_11.CurrentSolution;
                n28.ISolution Input_13 = (n28.ISolution)Current_Solution_12;
                n29._Operations_.AsObject<T>(Input_In: Output_8, Result_Out: out n5.Object Result_14);
                var Result_15 = ((n28.ISolution)Input_13).SetPinValue(node: __pad_NUqQoKE2YbJMTtAvqb9svj_1, pin: __pad_L4eKSUHmOLfQEmXleW4ov5_0, value: Result_14);
                n27.SolutionUpdateKind Solution_Update_Kind_16 = __c_HlD9TycgucDO24GBbQ3fpa;
                ((n28.ISolution)Input_13).Confirm(solutionUpdateKind: Solution_Update_Kind_16);
            }

            Output_Out = Output_8;
            n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> that_17 = this;
            if (this.__GetContext__().IsImmutable)
                that_17 = State_Output_7 != this.__p_ApC4IQS0OzzOPTxqvxzaci || !n10.EqualityComparer<T>.Default.Equals(Output_8, this.Value) ? new PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T>(this)
                {__p_ApC4IQS0OzzOPTxqvxzaci = State_Output_7, Value = Output_8} : that_17;
            else
            {
                this.__p_ApC4IQS0OzzOPTxqvxzaci = State_Output_7;
                this.Value = Output_8;
            }

            return that_17;
        }

        public n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> __Create__<AdM>(n3.NodeContext Node_Context_In)
            where AdM : struct, n25.IAdaptiveCreateDefault<T>
        {
            n30.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_0);
            var Path_1 = Node_Context_In.Path;
            var Stack_2 = Path_1.Stack;
            var Result_3 = Stack_2.Peek();
            n3.UniqueId __pad_NUqQoKE2YbJMTtAvqb9svj_4 = Result_3;
            n3.NodeContext Node_Context_5 = Node_Context_In.CreateSubContext("E532zsaM79WPN8Rl3xJlaB", "ApC4IQS0OzzOPTxqvxzaci", 126492U);
            var Output_6 = n31.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_5);
            n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> that_7 = this;
            this.__slot_NUqQoKE2YbJMTtAvqb9svj = Result_3;
            this.Value = __out_0;
            this.__p_ApC4IQS0OzzOPTxqvxzaci = Output_6;
            return that_7;
        }

        public n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> __CreateDefault__<AdM>()
            where AdM : struct, n25.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_1);
            n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> that_1 = this;
            this.__slot_NUqQoKE2YbJMTtAvqb9svj = default(n3.UniqueId);
            this.Value = __out_1;
            this.__p_ApC4IQS0OzzOPTxqvxzaci = n31.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n3.CompilationHelper.SafeDispose(this.__p_ApC4IQS0OzzOPTxqvxzaci);
            return;
        }

        void n5.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n3.ElementAttribute(TracingId = 126474U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "L4eKSUHmOLfQEmXleW4ov5", Name = "__slot_L4eKSUHmOLfQEmXleW4ov5")]
        public static string __slot_L4eKSUHmOLfQEmXleW4ov5 = "State";
        [n3.ElementAttribute(TracingId = 126482U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "NUqQoKE2YbJMTtAvqb9svj", Name = "__slot_NUqQoKE2YbJMTtAvqb9svj")]
        public n3.UniqueId __slot_NUqQoKE2YbJMTtAvqb9svj;
        [n3.ElementAttribute(TracingId = 126553U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "H0YlskW5r55Of3ff8PIHAc", Name = "Value")]
        public T Value;
        [n3.ElementAttribute(TracingId = 126492U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "ApC4IQS0OzzOPTxqvxzaci", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n31.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_ApC4IQS0OzzOPTxqvxzaci;
        [n3.ElementAttribute(IsAutoGenerated = true)]
        public static n27.SolutionUpdateKind __c_HlD9TycgucDO24GBbQ3fpa = n3.CompilationHelper.Deserialize<n27.SolutionUpdateKind>("Default", false, "E532zsaM79WPN8Rl3xJlaB", "HlD9TycgucDO24GBbQ3fpa");
        static PersistentState_SMiVmmAKtO6ON6v0GtlOUu()
        {
        }

        public PersistentState_SMiVmmAKtO6ON6v0GtlOUu(n3.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PersistentState_SMiVmmAKtO6ON6v0GtlOUu(PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> other): base(other)
        {
            this.__slot_NUqQoKE2YbJMTtAvqb9svj = other.__slot_NUqQoKE2YbJMTtAvqb9svj;
            this.Value = other.Value;
            this.__p_ApC4IQS0OzzOPTxqvxzaci = other.__p_ApC4IQS0OzzOPTxqvxzaci;
        }

        protected override n3.IVLObject __With__(n10.IReadOnlyDictionary<string, n5.Object> values)
        {
            return __WITH__(n3.CompilationHelper.GetValueOrExisting(values, "__slot_NUqQoKE2YbJMTtAvqb9svj", in __slot_NUqQoKE2YbJMTtAvqb9svj), n3.CompilationHelper.GetValueOrExisting(values, "Value", in Value), n3.CompilationHelper.GetValueOrExisting(values, "__p_ApC4IQS0OzzOPTxqvxzaci", in __p_ApC4IQS0OzzOPTxqvxzaci));
        }

        internal PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> __WITH__(n3.UniqueId __slot_NUqQoKE2YbJMTtAvqb9svj, T Value, n31.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_ApC4IQS0OzzOPTxqvxzaci)
        {
            n24.PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n10.EqualityComparer<n3.UniqueId>.Default.Equals(__slot_NUqQoKE2YbJMTtAvqb9svj, this.__slot_NUqQoKE2YbJMTtAvqb9svj) || !n10.EqualityComparer<T>.Default.Equals(Value, this.Value) || __p_ApC4IQS0OzzOPTxqvxzaci != this.__p_ApC4IQS0OzzOPTxqvxzaci ? new PersistentState_SMiVmmAKtO6ON6v0GtlOUu<T>(this)
                {__slot_NUqQoKE2YbJMTtAvqb9svj = __slot_NUqQoKE2YbJMTtAvqb9svj, Value = Value, __p_ApC4IQS0OzzOPTxqvxzaci = __p_ApC4IQS0OzzOPTxqvxzaci} : that_0;
            else
            {
                this.__slot_NUqQoKE2YbJMTtAvqb9svj = __slot_NUqQoKE2YbJMTtAvqb9svj;
                this.Value = Value;
                this.__p_ApC4IQS0OzzOPTxqvxzaci = __p_ApC4IQS0OzzOPTxqvxzaci;
            }

            return that_0;
        }
    }

    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void SingleInstance<T>(bool Force_New_Instance_In, n5.Func<T> Producer_In, n32.SingleInstanceBehaviorOnStop On_Stop_In, out T Singleton_Out)
            where T : class
        {
            var Result_0 = n32.SingleInstanceHelper<T>.SingleInstance(forceNewInstance: Force_New_Instance_In, producer: Producer_In, onStop: On_Stop_In);
            Singleton_Out = Result_0;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.System.Resources.Provider.Experimental
{
    [n3.ElementAttribute(TracingId = 97281U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void LocalEndPoint(n15.IResourceProvider<n14.Socket> Input_In, out n15.IResourceProvider<n14.Socket> Output_Out, out n11.IPEndPoint Endpoint_Out)
        {
            var Output_1 = n13.SocketUtils.LocalEndPoint(input: Input_In, endpoint: out n11.IPEndPoint Endpoint_0);
            Output_Out = Output_1;
            Endpoint_Out = Endpoint_0;
            return;
        }

        public static void RemoteEndPoint(n15.IResourceProvider<n14.Socket> Input_In, out n15.IResourceProvider<n14.Socket> Output_Out, out n11.IPEndPoint Endpoint_Out)
        {
            var Output_1 = n13.SocketUtils.RemoteEndPoint(input: Input_In, endpoint: out n11.IPEndPoint Endpoint_0);
            Output_Out = Output_1;
            Endpoint_Out = Endpoint_0;
            return;
        }

        public static void GetHeaders(n15.IResourceProvider<n11.WebResponse> Input_In, out n15.IResourceProvider<n11.WebResponse> Output_Out, out n9.Spread<string> Headers_Out)
        {
            var Output_1 = n20.Webrequest.GetHeaders(webResponse: Input_In, headers: out n9.Spread<string> Headers_0);
            Output_Out = Output_1;
            Headers_Out = Headers_0;
            return;
        }

        public static void GetResponseStream(n15.IResourceProvider<n11.WebResponse> Input_In, out n15.IResourceProvider<n22.Stream> Output_Out)
        {
            var Output_0 = n20.Webrequest.GetResponseStream(webResponse: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Split(n15.IResourceProvider<n11.WebResponse> Input_In, out n15.IResourceProvider<n11.WebResponse> Output_Out, out bool Is_From_Cache_Out, out bool Is_Mutually_Authenticated_Out, out long Content_Length_Out, out string Content_Type_Out, out string Response_Uri_Out, out n11.WebHeaderCollection Headers_Out, out bool Supports_Headers_Out)
        {
            var Output_7 = n20.Webrequest.Split(webResponse: Input_In, isFromCache: out bool Is_From_Cache_0, isMutuallyAuthenticated: out bool Is_Mutually_Authenticated_1, contentLength: out long Content_Length_2, contentType: out string Content_Type_3, responseUri: out string Response_Uri_4, headers: out n11.WebHeaderCollection Headers_5, supportsHeaders: out bool Supports_Headers_6);
            Output_Out = Output_7;
            Is_From_Cache_Out = Is_From_Cache_0;
            Is_Mutually_Authenticated_Out = Is_Mutually_Authenticated_1;
            Content_Length_Out = Content_Length_2;
            Content_Type_Out = Content_Type_3;
            Response_Uri_Out = Response_Uri_4;
            Headers_Out = Headers_5;
            Supports_Headers_Out = Supports_Headers_6;
            return;
        }
    }
}

namespace _VL_CoreLib_Experimental_.System.Process.Experimental
{
    [n3.ElementAttribute(TracingId = 127012U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "UW7Y4OEwksVP8fF4I5jRzk", Name = "JobObject_UW7Y4OEwksVP8fF4I5jRzk")]
    [n5.SerializableAttribute]
    public class JobObject_UW7Y4OEwksVP8fF4I5jRzk : n3.VLObject, n5.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk Create(n3.NodeContext Node_Context)
        {
            var instance = new JobObject_UW7Y4OEwksVP8fF4I5jRzk(Node_Context, n3.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk CreateDefault()
        {
            var instance = new JobObject_UW7Y4OEwksVP8fF4I5jRzk(n3.NodeContext.Default, n3.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk Update(int Process_Id_In, bool Add_Process_In, out string Error_Message_Out)
        {
            n34.Job __auto_0 = this.Job;
            string __auto_1;
            if (Add_Process_In)
            {
                bool Default_Output_3 = false;
                var __fallback___4 = n3.ServiceRegistry.Current;
                n35._Operations_.Try_Stateless<bool>(Default_Output_In: Default_Output_3, Try_In: () =>
                {
                    using var __current_5 = __fallback___4.MakeCurrentIfNone();
                    var Result_6 = __auto_0.AddProcess(processId: Process_Id_In);
                    return Result_6;
                }

                , Result_Out: out bool Result_7, Success_Out: out bool Success_8, Error_Message_Out: out string Error_Message_9);
                __auto_1 = Error_Message_9;
            }
            else
            {
                __auto_1 = "";
            }

            Error_Message_Out = __auto_1;
            return this;
        }

        public n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk __Create__(n3.NodeContext Node_Context)
        {
            n30.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n34.Job();
            n34.Job __auto_1 = Output_0;
            n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk that_2 = this;
            this.Job = Output_0;
            return that_2;
        }

        public n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk Dispose_()
        {
            n34.Job __auto_0 = this.Job;
            __auto_0.Dispose();
            return this;
        }

        public n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk __CreateDefault__()
        {
            n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk that_0 = this;
            this.Job = default(n34.Job);
            return that_0;
        }

        void n5.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n3.ElementAttribute(TracingId = 127366U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "BjEQDJNM2N3LGL3mdAIbL3", Name = "__slot_BjEQDJNM2N3LGL3mdAIbL3")]
        public static string __slot_BjEQDJNM2N3LGL3mdAIbL3 = "https://docs.microsoft.com/en-us/windows/desktop/ProcThread/job-objects\r\n\r\n";
        [n3.ElementAttribute(TracingId = 127383U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "TX4vHiPOuY4OFkagdQDqcw", Name = "__slot_TX4vHiPOuY4OFkagdQDqcw")]
        public static string __slot_TX4vHiPOuY4OFkagdQDqcw = "add other processes IDs to this process, so when it is closed, the others are shutdown as well.";
        [n3.ElementAttribute(TracingId = 127035U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "NImhsnhac5oMkTotgnaLKf", Name = "Job")]
        public n34.Job Job;
        static JobObject_UW7Y4OEwksVP8fF4I5jRzk()
        {
        }

        public JobObject_UW7Y4OEwksVP8fF4I5jRzk(n3.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JobObject_UW7Y4OEwksVP8fF4I5jRzk(JobObject_UW7Y4OEwksVP8fF4I5jRzk other): base(other)
        {
            this.Job = other.Job;
        }

        protected override n3.IVLObject __With__(n10.IReadOnlyDictionary<string, n5.Object> values)
        {
            return __WITH__(n3.CompilationHelper.GetValueOrExisting(values, "Job", in Job));
        }

        internal JobObject_UW7Y4OEwksVP8fF4I5jRzk __WITH__(n34.Job Job)
        {
            n33.JobObject_UW7Y4OEwksVP8fF4I5jRzk that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Job != this.Job ? new JobObject_UW7Y4OEwksVP8fF4I5jRzk(this)
                {Job = Job} : that_1;
            else
            {
                this.Job = Job;
            }

            return that_1;
        }
    }
}

namespace _VL_CoreLib_Experimental_.Experimental
{
    [n3.ElementAttribute(TracingId = 127456U, DocumentId = "E532zsaM79WPN8Rl3xJlaB", PersistentId = "ItYR8atty06M7klus5T2l8", Name = "VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8")]
    [n5.SerializableAttribute]
    public class VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 : n3.VLObject, n5.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n36.VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 Create(n3.NodeContext Node_Context)
        {
            var instance = new VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8(Node_Context, n3.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n36.VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 CreateDefault()
        {
            var instance = new VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8(n3.NodeContext.Default, n3.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n36.VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 Update()
        {
            return this;
        }

        public n36.VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 __Create__(n3.NodeContext Node_Context)
        {
            n30.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n36.VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n5.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8(n3.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8(VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 other): base(other)
        {
        }

        protected override n3.IVLObject __With__(n10.IReadOnlyDictionary<string, n5.Object> values)
        {
            return __WITH__();
        }

        internal VL_CoreLib_ExperimentalApplication_ItYR8atty06M7klus5T2l8 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_CoreLib_Experimental_
{
    public struct __AdaptiveImplementations__E532zsaM79WPN8Rl3xJlaB : n25.IAdaptiveCreateDefault<n14.Socket>, n25.IAdaptiveCreateDefault<n11.HttpWebResponse>, n25.IAdaptiveCreateDefault<n22.Stream>, n25.IAdaptiveCreateDefault<n11.WebResponse>
    {
        public void CreateDefault(out n14.Socket Output_Out)
        {
            n37._Operations_.CreateDefault_Generic<n14.Socket>(Output_Out: out n14.Socket Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n11.HttpWebResponse Output_Out)
        {
            n37._Operations_.CreateDefault_Generic<n11.HttpWebResponse>(Output_Out: out n11.HttpWebResponse Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n22.Stream Output_Out)
        {
            var Null_0 = n38._Operations_.CreateDefault();
            Output_Out = Null_0;
            return;
        }

        public void CreateDefault(out n11.WebResponse Output_Out)
        {
            n37._Operations_.CreateDefault_Generic<n11.WebResponse>(Output_Out: out n11.WebResponse Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}