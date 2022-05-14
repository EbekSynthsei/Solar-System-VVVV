extern alias e56;
extern alias e70;
extern alias e40;
extern alias e48;
extern alias e52;
extern alias e5;
extern alias e67;

using n17 = _VL_Stride_Windows_.Stride.Rendering;
using n19 = _VL_Stride_Windows_.Stride;
using n21 = _VL_Stride_Graphics_Windows_;
using n26 = _VL_CoreLib_;
using n1 = e5::VL.Core.CompilerServices;
using n30 = e70::VL.App.WindowsForms;
using n18 = _VL_Stride_Windows_.Stride.Textures.Source;
using n11 = _VL_Stride_Assets_Windows_.Stride;
using n24 = e56::VL.Stride.Windows.Core;
using n8 = _VL_Stride_Assets_Windows_.Stride.Assets.AssetBuilderService.Internal;
using n6 = _VL_Stride_Assets_Windows_.Stride.Assets;
using n3 = e48::Stride.Core.Assets;
using n13 = _VL_Stride_Graphics_Windows_.Stride.Textures.Spout.SpoutSender_SharedTexture;
using n25 = e40::VL.Stride.Core;
using n5 = e40::VL.Stride.Assets;
using n4 = e52::Stride.Core.IO;
using n28 = _VL_Skia_;
using n22 = e5::VL.Core;
using n29 = global::System;
using n20 = _VL_Stride_Assets_Windows_;
using n12 = _VL_Stride_Graphics_Windows_.Stride.Textures.Spout;
using n23 = e67::VL.Stride.Lib;
using n14 = _VL_Stride_Graphics_Windows_.Stride.Textures;
using n27 = _VL_Stride_Runtime_;
using n9 = e56::VL.Stride.Windows.Assets;
using n16 = _VL_Stride_Graphics_Windows_.Stride;
using n10 = _VL_Stride_Assets_Windows_.Stride.Assets.Advanced;
using n2 = _VL_Stride_Windows_;
using n15 = _VL_Stride_Graphics_Windows_.Stride.Graphics.Texture.Advanced;
using n7 = _VL_Stride_Assets_Windows_.Stride.Assets.Internal;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.Qi7h0S2HFoXQSgcrQLzJIkInitializer))]
[assembly: n1.TypeImportAttribute("Asset", "Stride.API.Assets", typeof(n3.Asset), null, false)]
[assembly: n1.TypeImportAttribute("AssetItem", "Stride.API.Assets", typeof(n3.AssetItem), typeof(n3.AssetItem), false)]
[assembly: n1.TypeImportAttribute("IAssetWithSource", "Stride.API.Assets", typeof(n3.IAssetWithSource), null, false)]
[assembly: n1.TypeImportAttribute("UFile", "Stride.API.Assets", typeof(n4.UFile), typeof(n4.UFile), false)]
[assembly: n1.TypeImportAttribute("AssetWrapper", "Stride.API.Assets", typeof(n5.AssetWrapper<>), typeof(n5.AssetWrapper<>), false)]
[assembly: n1.TypeImportAttribute("AssetWrapperBase", "Stride.API.Assets", typeof(n5.AssetWrapperBase), null, false)]
[assembly: n1.TypeImportAttribute("LoadAssetFile", "Stride.Assets", typeof(n6.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<>), typeof(n6.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<>), false)]
[assembly: n1.TypeImportAttribute("AssetMaterial", "Stride.Assets", typeof(n6.AssetMaterial_IgwzVY1otseO6SzguQMCo8), typeof(n6.AssetMaterial_IgwzVY1otseO6SzguQMCo8), false)]
[assembly: n1.TypeImportAttribute("AssetPrefab", "Stride.Assets", typeof(n6.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc), typeof(n6.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc), false)]
[assembly: n1.TypeImportAttribute("LoadProject", "Stride.Assets", typeof(n6.LoadProject_M7djlgidxbFQD0mWqmavrG), typeof(n6.LoadProject_M7djlgidxbFQD0mWqmavrG), false)]
[assembly: n1.TypeImportAttribute("AssetScene", "Stride.Assets", typeof(n6.AssetScene_AGzBVhNopB6LTM5HprvWlR), typeof(n6.AssetScene_AGzBVhNopB6LTM5HprvWlR), false)]
[assembly: n1.TypeImportAttribute("AssetTexture", "Stride.Assets", typeof(n6.AssetTexture_PSPWnmek3XdOg3vx4c3MUM), typeof(n6.AssetTexture_PSPWnmek3XdOg3vx4c3MUM), false)]
[assembly: n1.TypeImportAttribute("FileVideo", "Stride.Assets", typeof(n7.FileVideo_IWHxp1HsClUOiMAxLe32Ll), typeof(n7.FileVideo_IWHxp1HsClUOiMAxLe32Ll), false)]
[assembly: n1.TypeImportAttribute("FileSound", "Stride.Assets", typeof(n7.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ), typeof(n7.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ), false)]
[assembly: n1.TypeImportAttribute("VideoFromUrl", "Stride.Assets", typeof(n7.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl), typeof(n7.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl), false)]
[assembly: n1.TypeImportAttribute("IncrementalAssetBuilder", "Stride.Assets", typeof(n7.IncrementalAssetBuilder_C), typeof(n7.IncrementalAssetBuilder_C), false)]
[assembly: n1.TypeImportAttribute("AssetBuilderService", "Stride.Assets", typeof(n7.AssetBuilderService_C), typeof(n8._Operations_), false)]
[assembly: n1.TypeImportAttribute("IAssetBuilderService", "Stride.Assets", typeof(n9.IAssetBuilderService), null, false)]
[assembly: n1.TypeImportAttribute("GetAssetBuilderService", "Stride.Assets", typeof(n7.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau), typeof(n7.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau), false)]
[assembly: n1.TypeImportAttribute("ExistingProject", "Stride.Assets", typeof(n7.ExistingProject_C), typeof(n7.ExistingProject_C), false)]
[assembly: n1.TypeImportAttribute("UnloadDeletedProjectAssets", "Stride.Assets", typeof(n7.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM), typeof(n7.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM), false)]
[assembly: n1.TypeImportAttribute("LoadProjectAssets", "Stride.Assets", typeof(n7.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<>), typeof(n7.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<>), false)]
[assembly: n1.TypeImportAttribute("DisposeLoadedProjectAssets", "Stride.Assets", typeof(n7.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR), typeof(n7.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR), false)]
[assembly: n1.TypeImportAttribute("RuntimeAsset", "Stride.Assets", typeof(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS), typeof(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS), false)]
[assembly: n1.TypeImportAttribute("ListAssets", "Stride.Assets", typeof(n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC), typeof(n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC), false)]
[assembly: n1.TypeImportAttribute("AssetItemInfo", "Stride.Assets", typeof(n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r), typeof(n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r), false)]
[assembly: n1.TypeImportAttribute("RuntimeAssetItem", "Stride.Assets", typeof(n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw), typeof(n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw), false)]
[assembly: n1.TypeImportAttribute("FileTexture", "Stride.Assets", typeof(n6.FileTexture_VHk2U8mzzVePYWKVz5dr4z), typeof(n6.FileTexture_VHk2U8mzzVePYWKVz5dr4z), false)]
[assembly: n1.TypeImportAttribute("FileTextureGrayscale", "Stride.Assets", typeof(n6.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI), typeof(n6.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI), false)]
[assembly: n1.TypeImportAttribute("FileTextureNormalMap", "Stride.Assets", typeof(n6.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh), typeof(n6.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh), false)]
[assembly: n1.TypeImportAttribute("FileModel", "Stride.Assets", typeof(n6.FileModel_Q662A7DGcNSMVAXgG6NNYJ), typeof(n6.FileModel_Q662A7DGcNSMVAXgG6NNYJ), false)]
[assembly: n1.TypeImportAttribute("Asset", "Stride.Assets", typeof(n6.Asset_NgMUSSka40YMiqWx9s159z<>), typeof(n6.Asset_NgMUSSka40YMiqWx9s159z<>), false)]
[assembly: n1.TypeImportAttribute("AssetModel", "Stride.Assets", typeof(n6.AssetModel_Vck1QpjM5l6NWkQcueF1SO), typeof(n6.AssetModel_Vck1QpjM5l6NWkQcueF1SO), false)]
[assembly: n1.TypeImportAttribute("VL.Stride.Assets.WindowsApplication", "Stride", typeof(n11.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn), typeof(n11.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn), false)]
[assembly: n1.TypeImportAttribute("SpoutSender (SharedTexture)", "Stride.Textures.Spout", typeof(n12.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8), typeof(n12.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8), false)]
[assembly: n1.TypeImportAttribute("ActiveSenderClearer", "Stride.Textures.Spout.SpoutSender (SharedTexture)", typeof(n13.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8), typeof(n13.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8), false)]
[assembly: n1.TypeImportAttribute("SpoutSender", "Stride.Textures.Spout", typeof(n12.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ), typeof(n12.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ), false)]
[assembly: n1.TypeImportAttribute("ReadSharedMemory", "Stride.Textures.Spout", typeof(n12.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O), typeof(n12.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O), false)]
[assembly: n1.TypeImportAttribute("GetSpoutHandle", "Stride.Textures.Spout", typeof(n12.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG), typeof(n12.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG), false)]
[assembly: n1.TypeImportAttribute("SpoutReceiver", "Stride.Textures.Spout", typeof(n12.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1), typeof(n12.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1), false)]
[assembly: n1.TypeImportAttribute("SenderNames", "Stride.Textures.Spout", typeof(n12.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9), typeof(n12.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9), false)]
[assembly: n1.TypeImportAttribute("ActiveSender", "Stride.Textures.Spout", typeof(n12.ActiveSender_GP70vnZCHDTOGK77SB6cvs), typeof(n12.ActiveSender_GP70vnZCHDTOGK77SB6cvs), false)]
[assembly: n1.TypeImportAttribute("WriteSharedMemory", "Stride.Textures.Spout", typeof(n12.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH), typeof(n12.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH), false)]
[assembly: n1.TypeImportAttribute("SetActiveSender", "Stride.Textures.Spout", typeof(n12.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk), typeof(n12.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk), false)]
[assembly: n1.TypeImportAttribute("UploadToVVVVOrg", "Stride.Textures", typeof(n14.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l), typeof(n14.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l), false)]
[assembly: n1.TypeImportAttribute("FromNativeTexture", "Stride.Graphics.Texture", typeof(n15.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz), typeof(n15.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz), false)]
[assembly: n1.TypeImportAttribute("FromSharedHandle", "Stride.Graphics.Texture", typeof(n15.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo), typeof(n15.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo), false)]
[assembly: n1.TypeImportAttribute("VL.Stride.Graphics.WindowsApplication", "Stride", typeof(n16.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw), typeof(n16.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw), false)]
[assembly: n1.TypeImportAttribute("SkiaRenderer", "Stride.Rendering", typeof(n17.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI), typeof(n17.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI), false)]
[assembly: n1.TypeImportAttribute("AsSharedTexture", "Stride.Rendering", typeof(n17.AsSharedTexture_QPinH2kdJ21LstCls82xZe), typeof(n17.AsSharedTexture_QPinH2kdJ21LstCls82xZe), false)]
[assembly: n1.TypeImportAttribute("Rectangle", "Stride.Textures.Source", typeof(n18.Rectangle_R51yPqjFZmpPw6aX2G3LE0), typeof(n18.Rectangle_R51yPqjFZmpPw6aX2G3LE0), false)]
[assembly: n1.TypeImportAttribute("Circle", "Stride.Textures.Source", typeof(n18.Circle_KZJ9Mw0tv2YQAAENG41G31), typeof(n18.Circle_KZJ9Mw0tv2YQAAENG41G31), false)]
[assembly: n1.TypeImportAttribute("Polygon", "Stride.Textures.Source", typeof(n18.Polygon_Crg4bCepjCgOB2arXcsjeQ), typeof(n18.Polygon_Crg4bCepjCgOB2arXcsjeQ), false)]
[assembly: n1.TypeImportAttribute("SkiaTexture", "Stride.Textures.Source", typeof(n18.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa), typeof(n18.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa), false)]
[assembly: n1.TypeImportAttribute("VL.Stride.WindowsApplication", "Stride", typeof(n19.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ), typeof(n19.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n20.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF))]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n21.__AdaptiveImplementations__CWTbJ7dBwqtLwCqXKAv402))]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__Qi7h0S2HFoXQSgcrQLzJIk))]
namespace _VL_Stride_Windows_
{
    public sealed class Qi7h0S2HFoXQSgcrQLzJIkInitializer : n1.AssemblyInitializer<n2.Qi7h0S2HFoXQSgcrQLzJIkInitializer>
    {
        protected override sealed void RegisterServices(n22.IVLFactory factory)
        {
            n23.Initialization.Default.Init(factory);
            n24.Initialization.Default.Init(factory);
            n25.Initialization.Default.Init(factory);
            n26.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
            n27.MZmd92n0x8tLLBfKYOnxOxInitializer.Default.Init(factory);
            n28.TTuiw20kKkCQVOiomg84XZInitializer.Default.Init(factory);
        }
    }
}

internal sealed class Program
{
    [n29.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n30.WindowsFormsAppHost<n19.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ>(c => n19.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ.Create(c), s => ((n19.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ)s).Update()))
            appHost.Run();
    }
}