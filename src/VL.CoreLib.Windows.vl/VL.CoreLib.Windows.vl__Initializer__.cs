extern alias e70;
extern alias e5;
extern alias e17;

using n7 = _VL_CoreLib_;
using n2 = _VL_CoreLib_Windows_;
using n1 = e5::VL.Core.CompilerServices;
using n9 = e70::VL.App.WindowsForms;
using n6 = e5::VL.Core;
using n5 = e17::VL.CoreLib.Windows;
using n8 = global::System;
using n3 = _VL_CoreLib_Windows_.System.Windows;
using n4 = global::System.Drawing;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.HylXxkKPeF0O6LWz4fSQKoInitializer))]
[assembly: n1.TypeImportAttribute("WindowState", "System.Windows", typeof(n3.WindowState_TXbwxGLVQe9QXZeFcq3TYX), typeof(n3.WindowState_TXbwxGLVQe9QXZeFcq3TYX), false)]
[assembly: n1.TypeImportAttribute("SetWindowState", "System.Windows", typeof(n3.SetWindowState_NN7pI7FI1mWOUtJE7erhXK), typeof(n3.SetWindowState_NN7pI7FI1mWOUtJE7erhXK), false)]
[assembly: n1.TypeImportAttribute("SetWindowMode", "System.Windows", typeof(n3.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H), typeof(n3.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H), false)]
[assembly: n1.TypeImportAttribute("Size", "System.Windows", typeof(n4.Size), typeof(n4.Size), false)]
[assembly: n1.TypeImportAttribute("Rectangle", "System.Windows", typeof(n4.Rectangle), typeof(n4.Rectangle), false)]
[assembly: n1.TypeImportAttribute("RectangleF", "System.Windows", typeof(n4.RectangleF), typeof(n4.RectangleF), false)]
[assembly: n1.TypeImportAttribute("FormsExtensions", "", typeof(n5.FormsExtensions), null, false)]
[assembly: n1.TypeImportAttribute("VL.CoreLib.WindowsApplication", "", typeof(n2.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C), typeof(n2.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__HylXxkKPeF0O6LWz4fSQKo))]
namespace _VL_CoreLib_Windows_
{
    public sealed class HylXxkKPeF0O6LWz4fSQKoInitializer : n1.AssemblyInitializer<n2.HylXxkKPeF0O6LWz4fSQKoInitializer>
    {
        protected override sealed void RegisterServices(n6.IVLFactory factory)
        {
            n7.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
        }
    }
}

internal sealed class Program
{
    [n8.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n9.WindowsFormsAppHost<n2.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C>(c => n2.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C.Create(c), s => ((n2.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C)s).Update()))
            appHost.Run();
    }
}