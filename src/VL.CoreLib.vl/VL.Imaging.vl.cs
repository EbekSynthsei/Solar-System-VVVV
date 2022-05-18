extern alias e2;

using n9 = global::System.Collections.Generic;
using n4 = e2::VL.Lib.Basics.Imaging;
using n2 = e2::VL.Core;
using n3 = global::System;
using n5 = _VL_Imaging_.Graphics.Imaging;
using n6 = e2::VL.Core.CompilerServices;
using n7 = global::System.Runtime.CompilerServices;
using n8 = global::System.IO;

namespace _VL_Imaging_.Graphics.Imaging
{
    [n2.ElementAttribute(TracingId = 96306U, DocumentId = "AZFkohqeJbMMvWBi7VBs4X", PersistentId = "ACmZxixKsJiLhKAJgd78rl", Name = "VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl")]
    [n3.SerializableAttribute]
    public class VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl : n2.VLObject, n3.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl Create(n2.NodeContext Node_Context)
        {
            var instance = new VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl CreateDefault()
        {
            var instance = new VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl Update()
        {
            return this;
        }

        public n5.VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl __Create__(n2.NodeContext Node_Context)
        {
            n7.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n5.VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl(VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl other): base(other)
        {
        }

        protected override n2.IVLObject __With__(n9.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal VL_ImagingApplication_ACmZxixKsJiLhKAJgd78rl __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Imaging_.Graphics.Imaging.Image
{
    [n2.ElementAttribute(TracingId = 96094U, DocumentId = "AZFkohqeJbMMvWBi7VBs4X", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateDefaultAttribute]
        public static n4.IImage CreateDefault()
        {
            var Default_0 = n4.ImageExtensions.Default;
            return Default_0;
        }

        public static void Clone(n4.IImage Input_In, out n4.IImage Output_Out)
        {
            var Output_0 = n4.ImageExtensions.Clone(image: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void CloneEmpty(n4.IImage Input_In, out n4.IImage Output_Out)
        {
            var Output_0 = n4.ImageExtensions.CloneEmpty(image: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void ToStream(n4.IImage Input_In, out n8.Stream Result_Out)
        {
            var Result_0 = n4.ImageExtensions.ToStream(image: Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Imaging_.Graphics.Imaging.ArrayImage.Advanced
{
    [n2.ElementAttribute(TracingId = 96094U, DocumentId = "AZFkohqeJbMMvWBi7VBs4X", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateDefaultAttribute]
        public static n4.ArrayImage<T> CreateDefault<T>()
            where T : struct
        {
            var Default_0 = n4.ArrayImage<T>.Default;
            return Default_0;
        }
    }
}

namespace _VL_Imaging_.Graphics.Imaging.HoldLatestCopy.Advanced
{
    [n2.ElementAttribute(TracingId = 96094U, DocumentId = "AZFkohqeJbMMvWBi7VBs4X", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n6.CreateNewAttribute]
        public static void Create(n2.NodeContext Node_Context, n4.IImage Initial_Result_In, out n4.HoldLatestCopy Output_Out)
        {
            var Output_0 = new n4.HoldLatestCopy(initialResult: Initial_Result_In);
            Output_Out = Output_0;
            return;
        }

        public static void Update(n4.HoldLatestCopy Input_In, n3.IObservable<n4.IImage> Async_Notifications_In, [n6.SerializedDefaultValueAttribute("16", false)] int Timeout_In, bool Reset_In, out n4.HoldLatestCopy Output_Out, out n4.IImage Result_Out, out int Swap_Count_Out, out int Drop_Count_Out)
        {
            var Result_2 = Input_In.Update(asyncNotifications: Async_Notifications_In, timeout: Timeout_In, reset: Reset_In, swapCount: out int Swap_Count_0, dropCount: out int Drop_Count_1);
            Output_Out = Input_In;
            Result_Out = Result_2;
            Swap_Count_Out = Swap_Count_0;
            Drop_Count_Out = Drop_Count_1;
            return;
        }
    }
}

namespace _VL_Imaging_
{
    public struct __AdaptiveImplementations__AZFkohqeJbMMvWBi7VBs4X
    {
    }
}