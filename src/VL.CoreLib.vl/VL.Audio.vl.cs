extern alias e2;
extern alias e5;

using n8 = _VL_Audio_.Audio;
using n4 = e5::VL.Core.CompilerServices;
using n7 = global::System.Collections.Generic;
using n1 = e5::VL.Core;
using n2 = global::System;
using n5 = e2::VL.Lib;
using n3 = _VL_Audio_.System.Audio;
using n6 = global::System.Runtime.CompilerServices;

namespace _VL_Audio_.System.Audio
{
    [n1.ElementAttribute(TracingId = 265704U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "KmqtCc8fN45PDMhJAI74SD", Name = "SystemVolume_KmqtCc8fN45PDMhJAI74SD")]
    [n2.SerializableAttribute]
    public class SystemVolume_KmqtCc8fN45PDMhJAI74SD : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD Create(n1.NodeContext Node_Context)
        {
            var instance = new SystemVolume_KmqtCc8fN45PDMhJAI74SD(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD CreateDefault()
        {
            var instance = new SystemVolume_KmqtCc8fN45PDMhJAI74SD(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD Update([n4.SerializedDefaultValueAttribute("0.25", false)] float Volume_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Apply_In, bool Read_In, out float Volume_Out)
        {
            float __pad_AGBf2NNGfPoODSBRLkB9vY_0 = __slot_AGBf2NNGfPoODSBRLkB9vY;
            n5.SystemVolume __pad_Lh6c0ubiiYKMIox8KirwDZ_1 = this.__slot_Lh6c0ubiiYKMIox8KirwDZ;
            float __auto_2 = this.Volume;
            var Output_3 = Volume_In * __pad_AGBf2NNGfPoODSBRLkB9vY_0;
            var Output_4 = __pad_Lh6c0ubiiYKMIox8KirwDZ_1;
            if (Apply_In)
            {
                __pad_Lh6c0ubiiYKMIox8KirwDZ_1.Volume = Output_3;
            }

            float __auto_5;
            if (Read_In)
            {
                float __pad_Ov6WVPsYZznNSKe5kkZXLZ_7 = __slot_Ov6WVPsYZznNSKe5kkZXLZ;
                var Volume_8 = Output_4.Volume;
                var Output_9 = Volume_8 * __pad_Ov6WVPsYZznNSKe5kkZXLZ_7;
                __auto_5 = Output_9;
            }
            else
            {
                __auto_5 = __auto_2;
            }

            float __auto_10 = __auto_5;
            Volume_Out = __auto_10;
            n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = __auto_5 != this.Volume ? new SystemVolume_KmqtCc8fN45PDMhJAI74SD(this)
                {Volume = __auto_5} : that_11;
            else
            {
                this.Volume = __auto_5;
            }

            return that_11;
        }

        public n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.SystemVolume();
            n5.SystemVolume __pad_Lh6c0ubiiYKMIox8KirwDZ_1 = Output_0;
            n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD that_2 = this;
            this.__slot_Lh6c0ubiiYKMIox8KirwDZ = Output_0;
            this.Volume = 0F;
            return that_2;
        }

        public n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD __CreateDefault__()
        {
            n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD that_0 = this;
            this.__slot_Lh6c0ubiiYKMIox8KirwDZ = default(n5.SystemVolume);
            this.Volume = 0F;
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

        [n1.ElementAttribute(TracingId = 265709U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "Lh6c0ubiiYKMIox8KirwDZ", Name = "__slot_Lh6c0ubiiYKMIox8KirwDZ")]
        public n5.SystemVolume __slot_Lh6c0ubiiYKMIox8KirwDZ;
        [n1.ElementAttribute(TracingId = 265735U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "AGBf2NNGfPoODSBRLkB9vY", Name = "__slot_AGBf2NNGfPoODSBRLkB9vY")]
        public static float __slot_AGBf2NNGfPoODSBRLkB9vY = 100F;
        [n1.ElementAttribute(TracingId = 265770U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "HqyaTTO7S8MMRIDsXBWSMh", Name = "Volume")]
        public float Volume;
        [n1.ElementAttribute(TracingId = 265758U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "Ov6WVPsYZznNSKe5kkZXLZ", Name = "__slot_Ov6WVPsYZznNSKe5kkZXLZ")]
        public static float __slot_Ov6WVPsYZznNSKe5kkZXLZ = 0.01F;
        static SystemVolume_KmqtCc8fN45PDMhJAI74SD()
        {
        }

        public SystemVolume_KmqtCc8fN45PDMhJAI74SD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SystemVolume_KmqtCc8fN45PDMhJAI74SD(SystemVolume_KmqtCc8fN45PDMhJAI74SD other): base(other)
        {
            this.__slot_Lh6c0ubiiYKMIox8KirwDZ = other.__slot_Lh6c0ubiiYKMIox8KirwDZ;
            this.Volume = other.Volume;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Lh6c0ubiiYKMIox8KirwDZ", in __slot_Lh6c0ubiiYKMIox8KirwDZ), n1.CompilationHelper.GetValueOrExisting(values, "Volume", in Volume));
        }

        internal SystemVolume_KmqtCc8fN45PDMhJAI74SD __WITH__(n5.SystemVolume __slot_Lh6c0ubiiYKMIox8KirwDZ, float Volume)
        {
            n3.SystemVolume_KmqtCc8fN45PDMhJAI74SD that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Lh6c0ubiiYKMIox8KirwDZ != this.__slot_Lh6c0ubiiYKMIox8KirwDZ || Volume != this.Volume ? new SystemVolume_KmqtCc8fN45PDMhJAI74SD(this)
                {__slot_Lh6c0ubiiYKMIox8KirwDZ = __slot_Lh6c0ubiiYKMIox8KirwDZ, Volume = Volume} : that_0;
            else
            {
                this.__slot_Lh6c0ubiiYKMIox8KirwDZ = __slot_Lh6c0ubiiYKMIox8KirwDZ;
                this.Volume = Volume;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 265826U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "H5eu6vAGOXJQFz9gXSu0oy", Name = "PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy")]
    [n2.SerializableAttribute]
    public class PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy Create(n1.NodeContext Node_Context)
        {
            var instance = new PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy CreateDefault()
        {
            var instance = new PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy Update(n5.PlaybackDeviceEnum Device_In, bool Apply_In, out bool Success_Out)
        {
            bool __auto_0;
            if (Apply_In)
            {
                var Result_2 = n5.SystemDevice.SetPlaybackDevice(device: Device_In);
                __auto_0 = Result_2;
            }
            else
            {
                __auto_0 = false;
            }

            Success_Out = __auto_0;
            return this;
        }

        public n3.PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy __CreateDefault__()
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

        public PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy(PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal PlaybackDevice_H5eu6vAGOXJQFz9gXSu0oy __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 265884U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "UEAyKbuXafWMqoXazJZMZR", Name = "CaptureDevice_UEAyKbuXafWMqoXazJZMZR")]
    [n2.SerializableAttribute]
    public class CaptureDevice_UEAyKbuXafWMqoXazJZMZR : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.CaptureDevice_UEAyKbuXafWMqoXazJZMZR Create(n1.NodeContext Node_Context)
        {
            var instance = new CaptureDevice_UEAyKbuXafWMqoXazJZMZR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.CaptureDevice_UEAyKbuXafWMqoXazJZMZR CreateDefault()
        {
            var instance = new CaptureDevice_UEAyKbuXafWMqoXazJZMZR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.CaptureDevice_UEAyKbuXafWMqoXazJZMZR Update(n5.CaptureDeviceEnum Device_In, bool Apply_In, out bool Success_Out)
        {
            bool __auto_0;
            if (Apply_In)
            {
                var Result_2 = n5.SystemDevice.SetCaptureDevice(device: Device_In);
                __auto_0 = Result_2;
            }
            else
            {
                __auto_0 = false;
            }

            Success_Out = __auto_0;
            return this;
        }

        public n3.CaptureDevice_UEAyKbuXafWMqoXazJZMZR __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.CaptureDevice_UEAyKbuXafWMqoXazJZMZR __CreateDefault__()
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

        public CaptureDevice_UEAyKbuXafWMqoXazJZMZR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CaptureDevice_UEAyKbuXafWMqoXazJZMZR(CaptureDevice_UEAyKbuXafWMqoXazJZMZR other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal CaptureDevice_UEAyKbuXafWMqoXazJZMZR __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 265984U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "EaK0ObPCDNOMoKrIuzU8qW", Name = "CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW")]
    [n2.SerializableAttribute]
    public class CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW Create(n1.NodeContext Node_Context)
        {
            var instance = new CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW CreateDefault()
        {
            var instance = new CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW Update(n5.PlaybackDeviceEnum Playback_Device_In, bool Apply_Playback_Device_In, n5.CaptureDeviceEnum Capture_Device_In, bool Apply_Capture_Device_In, out bool Playback_Device_Success_Out, out bool Capture_Device_Success_Out)
        {
            bool __auto_0;
            if (Apply_Playback_Device_In)
            {
                var Result_2 = n5.SystemDevice.SetCommunicationPlaybackDevice(device: Playback_Device_In);
                __auto_0 = Result_2;
            }
            else
            {
                __auto_0 = false;
            }

            bool __auto_3;
            if (Apply_Capture_Device_In)
            {
                var Result_5 = n5.SystemDevice.SetCommunicationCaptureDevice(device: Capture_Device_In);
                __auto_3 = Result_5;
            }
            else
            {
                __auto_3 = false;
            }

            Playback_Device_Success_Out = __auto_0;
            Capture_Device_Success_Out = __auto_3;
            return this;
        }

        public n3.CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW __CreateDefault__()
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

        public CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW(CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal CommunicationDevice_EaK0ObPCDNOMoKrIuzU8qW __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Audio_.System.Audio.PlaybackDeviceEnum.Advanced
{
    [n1.ElementAttribute(TracingId = 265700U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.PlaybackDeviceEnum CreateDefault()
        {
            var Result_0 = n5.PlaybackDeviceEnum.CreateDefault();
            return Result_0;
        }
    }
}

namespace _VL_Audio_.System.Audio.CaptureDeviceEnum.Advanced
{
    [n1.ElementAttribute(TracingId = 265700U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.CaptureDeviceEnum CreateDefault()
        {
            var Result_0 = n5.CaptureDeviceEnum.CreateDefault();
            return Result_0;
        }
    }
}

namespace _VL_Audio_.Audio
{
    [n1.ElementAttribute(TracingId = 266078U, DocumentId = "Jdtt8jmfRe7P1xlWyL0zVO", PersistentId = "RVkWN0naK0kQQDnrs3xwyE", Name = "VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE")]
    [n2.SerializableAttribute]
    public class VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE CreateDefault()
        {
            var instance = new VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE Update()
        {
            return this;
        }

        public n8.VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n8.VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE __CreateDefault__()
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

        public VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE(VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_AudioApplication_RVkWN0naK0kQQDnrs3xwyE __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Audio_
{
    public struct __AdaptiveImplementations__Jdtt8jmfRe7P1xlWyL0zVO
    {
    }
}