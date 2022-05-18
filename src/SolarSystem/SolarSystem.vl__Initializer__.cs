extern alias e2;
extern alias e70;

using n3 = _SolarSystem_.Main;
using n8 = _VL_Fuse_;
using n5 = _VL_CoreLib_;
using n10 = e70::VL.App.WindowsForms;
using n7 = _VL_Skia_;
using n2 = _SolarSystem_;
using n6 = _VL_Stride_;
using n4 = e2::VL.Core;
using n9 = global::System;
using n1 = e2::VL.Core.CompilerServices;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.KYrBT1ndOH9MqXl8wdSpYVInitializer))]
[assembly: n1.TypeImportAttribute("SolarSystemApplication", "Main", typeof(n3.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe), typeof(n3.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV))]
namespace _SolarSystem_
{
    public sealed class KYrBT1ndOH9MqXl8wdSpYVInitializer : n1.AssemblyInitializer<n2.KYrBT1ndOH9MqXl8wdSpYVInitializer>
    {
        protected override sealed void RegisterServices(n4.IVLFactory factory)
        {
            n5.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
            n6.DZTiJFhHydJQMleZQmJvQjInitializer.Default.Init(factory);
            n7.TTuiw20kKkCQVOiomg84XZInitializer.Default.Init(factory);
            n8.MzrPktFwnABMtmjvPGeHVwInitializer.Default.Init(factory);
        }
    }
}

internal sealed class Program
{
    [n9.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n10.WindowsFormsAppHost<n3.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe>(c => n3.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe.Create(c), s => ((n3.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe)s).Update()))
            appHost.Run();
    }
}