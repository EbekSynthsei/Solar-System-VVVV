extern alias e6;
extern alias e5;

using n5 = e6::VL.Lang.PublicAPI;
using n3 = e6::VL.Model;
using n12 = _VL_CoreLib_;
using n1 = e5::VL.Core.CompilerServices;
using n6 = _VL_Lang_.VL.Session;
using n7 = e6::VL.Lang;
using n4 = e5::VL.Core;
using n2 = _VL_Lang_;
using n9 = e6::VL.Core;
using n11 = e5::VL.Lib;
using n8 = e6::VL.Lang.Symbols;
using n10 = _VL_Lang_.VL;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.AMsJsrrhltMMjgtUbICS42Initializer))]
[assembly: n1.TypeImportAttribute("Canvas", "VL.Model", typeof(n3.Canvas), null, true)]
[assembly: n1.TypeImportAttribute("Compound", "VL.Model", typeof(n3.Compound), null, true)]
[assembly: n1.TypeImportAttribute("ControlPoint", "VL.Model", typeof(n3.ControlPoint), null, true)]
[assembly: n1.TypeImportAttribute("DataHub", "VL.Model", typeof(n3.DataHub), null, true)]
[assembly: n1.TypeImportAttribute("Dependency", "VL.Model", typeof(n3.Dependency), null, true)]
[assembly: n1.TypeImportAttribute("Document", "VL.Model", typeof(n3.Document), null, true)]
[assembly: n1.TypeImportAttribute("DocumentDependency", "VL.Model", typeof(n3.DocumentDependency), null, true)]
[assembly: n1.TypeImportAttribute("Element", "VL.Model", typeof(n3.Element), null, true)]
[assembly: n1.TypeImportAttribute("Fragment", "VL.Model", typeof(n3.Fragment), null, true)]
[assembly: n1.TypeImportAttribute("Link", "VL.Model", typeof(n3.Link), null, true)]
[assembly: n1.TypeImportAttribute("NameAndVersion", "VL.Model", typeof(n3.NameAndVersion), typeof(n3.NameAndVersion), true)]
[assembly: n1.TypeImportAttribute("Node", "VL.Model", typeof(n3.Node), null, true)]
[assembly: n1.TypeImportAttribute("NodeFragment", "VL.Model", typeof(n3.NodeFragment), null, true)]
[assembly: n1.TypeImportAttribute("NodeOrPatch", "VL.Model", typeof(n3.NodeOrPatch), null, true)]
[assembly: n1.TypeImportAttribute("NugetDependency", "VL.Model", typeof(n3.NugetDependency), null, true)]
[assembly: n1.TypeImportAttribute("Pad", "VL.Model", typeof(n3.Pad), null, true)]
[assembly: n1.TypeImportAttribute("Patch", "VL.Model", typeof(n3.Patch), null, true)]
[assembly: n1.TypeImportAttribute("Pin", "VL.Model", typeof(n3.Pin), null, true)]
[assembly: n1.TypeImportAttribute("PlatformDependency", "VL.Model", typeof(n3.PlatformDependency), null, true)]
[assembly: n1.TypeImportAttribute("ProcessDefinition", "VL.Model", typeof(n3.ProcessDefinition), null, true)]
[assembly: n1.TypeImportAttribute("Solution", "VL.Model", typeof(n3.Solution), typeof(n3.Solution), true)]
[assembly: n1.TypeImportAttribute("ElementId", "VL.Model", typeof(n3.ElementId), null, true)]
[assembly: n1.TypeImportAttribute("IInfo", "VL.Model", typeof(n4.IInfo), null, false)]
[assembly: n1.TypeImportAttribute("ISolution", "VL", typeof(n5.ISolution), null, true)]
[assembly: n1.TypeImportAttribute("Session", "VL", typeof(n5.Session), null, false)]
[assembly: n1.TypeImportAttribute("Warn", "VL.Session", typeof(n6.Warn_KZL6CijWUqQOxf8NXnAKDW), typeof(n6.Warn_KZL6CijWUqQOxf8NXnAKDW), false)]
[assembly: n1.TypeImportAttribute("Warn (Reactive)", "VL.Session", typeof(n6.Warn_Reactive_C), typeof(n6.Warn_Reactive_C), false)]
[assembly: n1.TypeImportAttribute("PinGroupBuilder", "VL", typeof(n5.PinGroupBuilder), null, false)]
[assembly: n1.TypeImportAttribute("PackageDescription", "VL", typeof(n5.PackageDescription), typeof(n5.PackageDescription), true)]
[assembly: n1.TypeImportAttribute("Message", "VL", typeof(n7.Message), typeof(n7.Message), false)]
[assembly: n1.TypeImportAttribute("MessageSeverity", "VL", typeof(n7.MessageSeverity), null, true)]
[assembly: n1.TypeImportAttribute("IDataHubInfo", "VL", typeof(n5.IDataHubInfo), null, false)]
[assembly: n1.TypeImportAttribute("INodeInfo", "VL", typeof(n5.INodeInfo), null, false)]
[assembly: n1.TypeImportAttribute("ILiveElement", "VL", typeof(n5.ILiveElement), null, false)]
[assembly: n1.TypeImportAttribute("TimingData", "VL", typeof(n8.TimingData), typeof(n8.TimingData), false)]
[assembly: n1.TypeImportAttribute("ILiveDataHub", "VL", typeof(n5.ILiveDataHub), null, false)]
[assembly: n1.TypeImportAttribute("ILiveNodeApplication", "VL", typeof(n5.ILiveNodeApplication), null, false)]
[assembly: n1.TypeImportAttribute("ElementHelpers", "VL", typeof(n5.ElementHelpers), null, false)]
[assembly: n1.TypeImportAttribute("IElementInfo", "VL", typeof(n5.IElementInfo), null, false)]
[assembly: n1.TypeImportAttribute("ILiveLink", "VL", typeof(n5.ILiveLink), null, false)]
[assembly: n1.TypeImportAttribute("ILinkInfo", "VL", typeof(n5.ILinkInfo), null, false)]
[assembly: n1.TypeImportAttribute("IMomentInfo", "VL", typeof(n5.IMomentInfo), null, false)]
[assembly: n1.TypeImportAttribute("Boxing", "VL", typeof(n9.Boxing), null, false)]
[assembly: n1.TypeImportAttribute("LiveValueNotification", "VL", typeof(n8.LiveValueNotification), typeof(n8.LiveValueNotification), true)]
[assembly: n1.TypeImportAttribute("PatchNotification", "VL", typeof(n8.PatchNotification), typeof(n8.PatchNotification), false)]
[assembly: n1.TypeImportAttribute("ICommand", "VL", typeof(n5.ICommand), null, false)]
[assembly: n1.TypeImportAttribute("ICommandService", "VL", typeof(n5.ICommandService), null, false)]
[assembly: n1.TypeImportAttribute("GetVLTypeForScope", "VL", typeof(n10.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS), typeof(n10.GetVLTypeForScope_MiCPmvTOC3PO5DW2pduuvS), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__AMsJsrrhltMMjgtUbICS42))]
namespace _VL_Lang_
{
    public sealed class AMsJsrrhltMMjgtUbICS42Initializer : n1.AssemblyInitializer<n2.AMsJsrrhltMMjgtUbICS42Initializer>
    {
        protected override sealed void RegisterServices(n4.IVLFactory factory)
        {
            n11.VL_Core_Initializer.Default.Init(factory);
            n12.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
        }
    }
}