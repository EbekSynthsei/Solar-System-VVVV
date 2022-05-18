extern alias e2;
extern alias e70;

using n8 = e70::VL.App.WindowsForms;
using n3 = _VL_Stride_.Stride;
using n2 = _VL_Stride_;
using n4 = e2::VL.Core;
using n7 = global::System;
using n1 = e2::VL.Core.CompilerServices;
using n5 = _VL_Stride_Runtime_;
using n6 = _VL_Stride_Windows_;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.DZTiJFhHydJQMleZQmJvQjInitializer))]
[assembly: n1.TypeImportAttribute("VL.StrideApplication", "Stride", typeof(n3.VL_StrideApplication_GLGlNfsOnrZP7PwNthN41C), typeof(n3.VL_StrideApplication_GLGlNfsOnrZP7PwNthN41C), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__DZTiJFhHydJQMleZQmJvQj))]
namespace _VL_Stride_
{
    public sealed class DZTiJFhHydJQMleZQmJvQjInitializer : n1.AssemblyInitializer<n2.DZTiJFhHydJQMleZQmJvQjInitializer>
    {
        protected override sealed void RegisterServices(n4.IVLFactory factory)
        {
            n5.MZmd92n0x8tLLBfKYOnxOxInitializer.Default.Init(factory);
            n6.Qi7h0S2HFoXQSgcrQLzJIkInitializer.Default.Init(factory);
        }
    }
}

internal sealed class Program
{
    [n7.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n8.WindowsFormsAppHost<n3.VL_StrideApplication_GLGlNfsOnrZP7PwNthN41C>(c => n3.VL_StrideApplication_GLGlNfsOnrZP7PwNthN41C.Create(c), s => ((n3.VL_StrideApplication_GLGlNfsOnrZP7PwNthN41C)s).Update()))
            appHost.Run();
    }
}