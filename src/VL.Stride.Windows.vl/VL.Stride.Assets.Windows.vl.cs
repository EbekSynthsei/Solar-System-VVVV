extern alias e6;
extern alias e22;
extern alias e52;
extern alias e24;
extern alias e42;
extern alias e31;
extern alias e45;
extern alias e43;
extern alias e3;
extern alias e25;
extern alias e2;
extern alias e58;
extern alias e48;
extern alias e23;
extern alias e29;
extern alias e4;

using n23 = e58::Stride.Video;
using n62 = e43::Stride.Core.Assets.Analysis;
using n21 = e2::VL.Lib.Collections;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n75 = _CoreLibBasics_.Animation.FrameBased;
using n39 = _CoreLibBasics_.Primitive.Object.Advanced;
using n26 = e42::VL.Stride.Assets.RuntimeContentLoader;
using n72 = _CoreLibBasics_.Control;
using n41 = global::System.Collections.ObjectModel;
using n73 = _CoreLibBasics_.IO.FileWatcher.Experimental;
using n76 = _CoreLibBasics_.Animation.IClock.Advanced;
using n81 = _VL_Stride_Games_.Stride.Utils;
using n69 = e3::VL.Lib.Reactive;
using n55 = _CoreLibBasics_.Primitive.Tuple__2_Items.Advanced;
using n63 = _CoreLibBasics_.Primitive.String;
using n43 = _CoreLibBasics_.Primitive;
using n45 = global::System.Collections;
using n17 = global::System.Collections.Generic;
using n28 = _VL_Stride_Rendering_.Stride.Utils.Advanced;
using n66 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Engine.Entity.Advanced;
using n57 = _CoreLibBasics_.Primitive.TypeHelpers.Advanced;
using n60 = e2::VL.Lib.Basics.Resources;
using n29 = e6::Stride.Core;
using n74 = _CoreLibBasics_.IO.Path;
using n27 = _VL_Reactive_.Reactive.Observable.Advanced;
using n37 = _VL_Stride_Assets_Windows_.Stride.Assets.ExistingProject.Internal;
using n61 = _VL_Stride_Assets_Windows_.Stride;
using n24 = e42::VL.Stride.Assets;
using n15 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n52 = e52::Stride.Assets.Models;
using n33 = _VL_Stride_Assets_Windows_.Stride.Assets.AssetBuilderService.Internal;
using n3 = _VL_Stride_Assets_Windows_.Stride.Assets;
using n54 = _CoreLibBasics_.Primitive.Boolean;
using n30 = e3::VL.Lib.Primitive;
using n44 = e2::VL.Lib.Runtime;
using n48 = e42::Faithlife.Utility;
using n70 = global::System.Threading;
using n6 = e31::VL.Stride.Assets;
using n20 = e24::Stride.Engine;
using n82 = e25::Stride.Games;
using n49 = e23::Stride.Core.Assets;
using n9 = _VL_CoreLib_IO_.IO.File;
using n25 = e6::Stride.Core.Diagnostics;
using n83 = _CoreLibBasics_.IO.Stream.Experimental;
using n31 = e42::VL.Stride.Windows.Assets;
using n1 = e2::VL.Core;
using n50 = e48::Stride.Assets.Media;
using n79 = e22::Stride.Graphics;
using n2 = global::System;
using n71 = _VL_Reactive_.Reactive.AsyncTask;
using n53 = e4::Stride.Core.Mathematics;
using n56 = e23::Stride.Core.Serialization.Contents;
using n19 = _VL_Stride_Assets_Windows_;
using n13 = e43::Stride.Core.Assets;
using n35 = e3::VL.Lib.Experimental;
using n46 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n51 = e43::Stride.Core.Assets.Yaml;
using n5 = e2::VL.Lib.IO;
using n12 = e3::VL.Lib.Primitive.Object;
using n42 = _VL_Collections_.Collections.Mutable.MutableObservableCollection.Advanced;
using n8 = e3::VL.Lib.IO;
using n4 = e2::VL.Core.CompilerServices;
using n58 = e43::Stride.Core.Assets.Serializers;
using n40 = e45::Stride.Core;
using n68 = _VL_Reactive_.Reactive.HoldLatest;
using n67 = _VL_Stride_Engine_.Stride;
using n77 = e2::VL.Lib.Animation;
using n10 = _VL_Stride_Assets_Windows_.Stride.Assets.Advanced;
using n78 = _VL_Stride_Engine_.Stride.Utils.Advanced;
using n18 = e29::Stride.Rendering;
using n38 = e45::Stride.Core.IO;
using n34 = _VL_Collections_.Collections.Sequence;
using n16 = global::System.Runtime.CompilerServices;
using n80 = _VL_Stride_Assets_Windows_.Stride.Assets.Asset;
using n36 = _CoreLibBasics_.Primitive.SingleInstance_PerApp;
using n65 = global::System.Linq;
using n47 = e48::Stride.Assets.Textures;
using n32 = _VL_Collections_.Collections.Interfaces.ICollection.Advanced;
using n22 = _VL_Collections_.Collections.Spread;
using n64 = _VL_CoreLib_Experimental_.Control.Experimental;
using n59 = _CoreLibBasics_.System.Resources.Advanced;
using n84 = _CoreLibBasics_.Primitive.Advanced;
using n85 = _CoreLibBasics_._3D.Vector3;
using n14 = _VL_Stride_Assets_Windows_.Stride.Assets.Internal;
using n11 = global::System.IO;

namespace _VL_Stride_Assets_Windows_.Stride.Assets
{
    [n1.ElementAttribute(TracingId = 4412U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "EQEqPKNdxEjNio5WMOpCUe", Name = "LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe")]
    [n2.SerializableAttribute]
    public class LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> : n1.VLObject, n2.IDisposable where T : class
    {
        [n4.CreateNewAttribute]
        public static n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> CreateDefault()
        {
            var instance = new LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> Update<AdM>(n5.Path Path_In, bool Reload_In, out T Asset_Out, out bool Is_Loading_Out, out bool Already_Loaded_Out)
            where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_R815Re7xhKoL400zvbFOdZ;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<n6.AssetWrapper<T>, bool>>((default(n6.AssetWrapper<T>), false));
            }

            var inputs_3 = n2.ValueTuple.Create(Path_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Reload_In || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__SDCgFqPUkekLJAuJJ2dkLR>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __SDCgFqPUkekLJAuJJ2dkLR(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "Dz9iWpf28LQNIqII7Tosyk", 4452U);
                    n9._Operations_.Create_H(Node_Context_In: Node_Context_7, Output_Out: out n8.FileNode Output_8);
                    state_6.__p_Dz9iWpf28LQNIqII7Tosyk = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "BPH3GaTR155NUDApt7wW1t", 4435U);
                    var Output_10 = n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS.Create(Node_Context: Node_Context_9);
                    state_6.__p_BPH3GaTR155NUDApt7wW1t = Output_10;
                }

                var Result_11 = (string)Path_In;
                n11.FileMode File_Mode_12 = __c_MGH3mUfDg7fMTi8L3Qx3ij;
                n11.FileAccess File_Access_13 = __c_FnTstHdUY3JN5rOzbG47GK;
                n11.FileShare File_Share_14 = __c_QBHFCkSo0MoN3dO29dtMTH;
                n8.FileNode Input_15 = state_6.__p_Dz9iWpf28LQNIqII7Tosyk;
                var Result_16 = Input_15.Update(filePath: Path_In, fileMode: File_Mode_12, fileAccess: File_Access_13, fileShare: File_Share_14);
                var Result_17 = Result_11.GetHashCode();
                var Result_18 = n12.ObjectHelpers.ToString(input: Result_17);
                var Output_19 = n11.Path.GetDirectoryName(path: Result_11);
                bool Build_20 = true;
                bool Reload_21 = false;
                string Name_22 = "";
                var __fallback___23 = n1.ServiceRegistry.Current;
                var Output_29 = state_6.__p_BPH3GaTR155NUDApt7wW1t.Update<n13.Asset, T, AdM>(Build_In: Build_20, Reload_In: Reload_21, Url_In: Result_18, Source_Folder_In: Output_19, Name_In: Name_22, Create_Asset_In: (n13.Package Arg_In_25) =>
                {
                    using var __current_24 = __fallback___23.MakeCurrentIfNone();
                    n14._Operations_.AssetFromFile(Filename_In: Result_11, File_In: Result_16, Result_Out: out n13.Asset Result_26);
                    return Result_26;
                }

                , Wrapper_Out: out n6.AssetWrapper<T> Wrapper_27, Already_Loaded_Out: out bool Already_Loaded_28);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Input_15 != state_6.__p_Dz9iWpf28LQNIqII7Tosyk || Output_29 != state_6.__p_BPH3GaTR155NUDApt7wW1t ? new __SDCgFqPUkekLJAuJJ2dkLR(state_6)
                    {__p_Dz9iWpf28LQNIqII7Tosyk = Input_15, __p_BPH3GaTR155NUDApt7wW1t = Output_29} : state_6;
                else
                {
                    state_6.__p_Dz9iWpf28LQNIqII7Tosyk = Input_15;
                    state_6.__p_BPH3GaTR155NUDApt7wW1t = Output_29;
                }

                outputs_4 = (Wrapper_27, Already_Loaded_28);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_30, __auto_31) = outputs_4;
            __auto_30.GetValues(asset: out T Asset_32, exists: out bool Exists_33, loading: out bool Loading_34);
            Asset_Out = Asset_32;
            Is_Loading_Out = Loading_34;
            Already_Loaded_Out = __auto_31;
            n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = manager_2 != this.__cache_R815Re7xhKoL400zvbFOdZ ? new LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T>(this)
                {__cache_R815Re7xhKoL400zvbFOdZ = manager_2} : that_35;
            else
            {
                this.__cache_R815Re7xhKoL400zvbFOdZ = manager_2;
            }

            return that_35;
        }

        public n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> that_0 = this;
            this.__cache_R815Re7xhKoL400zvbFOdZ = null;
            return that_0;
        }

        public n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> __CreateDefault__()
        {
            n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> that_0 = this;
            this.__cache_R815Re7xhKoL400zvbFOdZ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_R815Re7xhKoL400zvbFOdZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 4415U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "R815Re7xhKoL400zvbFOdZ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<n6.AssetWrapper<T>, bool>> __cache_R815Re7xhKoL400zvbFOdZ = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.FileMode __c_MGH3mUfDg7fMTi8L3Qx3ij = n1.CompilationHelper.Deserialize<n11.FileMode>("Open", false, "OpwXTKxodpcLMuzoaGSQfF", "MGH3mUfDg7fMTi8L3Qx3ij");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.FileAccess __c_FnTstHdUY3JN5rOzbG47GK = n1.CompilationHelper.Deserialize<n11.FileAccess>("Read", false, "OpwXTKxodpcLMuzoaGSQfF", "FnTstHdUY3JN5rOzbG47GK");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.FileShare __c_QBHFCkSo0MoN3dO29dtMTH = n1.CompilationHelper.Deserialize<n11.FileShare>("Read", false, "OpwXTKxodpcLMuzoaGSQfF", "QBHFCkSo0MoN3dO29dtMTH");
        static LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe()
        {
        }

        public LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe(LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> other): base(other)
        {
            this.__cache_R815Re7xhKoL400zvbFOdZ = other.__cache_R815Re7xhKoL400zvbFOdZ;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_R815Re7xhKoL400zvbFOdZ", in __cache_R815Re7xhKoL400zvbFOdZ));
        }

        internal LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> __WITH__(n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<n6.AssetWrapper<T>, bool>> __cache_R815Re7xhKoL400zvbFOdZ)
        {
            n3.LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_R815Re7xhKoL400zvbFOdZ != this.__cache_R815Re7xhKoL400zvbFOdZ ? new LoadAssetFile_EQEqPKNdxEjNio5WMOpCUe<T>(this)
                {__cache_R815Re7xhKoL400zvbFOdZ = __cache_R815Re7xhKoL400zvbFOdZ} : that_0;
            else
            {
                this.__cache_R815Re7xhKoL400zvbFOdZ = __cache_R815Re7xhKoL400zvbFOdZ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SDCgFqPUkekLJAuJJ2dkLR", Name = "__SDCgFqPUkekLJAuJJ2dkLR")]
        [n2.SerializableAttribute]
        public class __SDCgFqPUkekLJAuJJ2dkLR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Dz9iWpf28LQNIqII7Tosyk);
                n1.CompilationHelper.SafeDispose(this.__p_BPH3GaTR155NUDApt7wW1t);
                return;
            }

            [n1.ElementAttribute(TracingId = 4452U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Dz9iWpf28LQNIqII7Tosyk", Name = "File", IsManaged = true, IsAutoGenerated = true)]
            public n8.FileNode __p_Dz9iWpf28LQNIqII7Tosyk;
            [n1.ElementAttribute(TracingId = 4435U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "BPH3GaTR155NUDApt7wW1t", Name = "RuntimeAsset", IsManaged = true, IsAutoGenerated = true)]
            public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_BPH3GaTR155NUDApt7wW1t;
            public __SDCgFqPUkekLJAuJJ2dkLR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SDCgFqPUkekLJAuJJ2dkLR(__SDCgFqPUkekLJAuJJ2dkLR other): base(other)
            {
                this.__p_Dz9iWpf28LQNIqII7Tosyk = other.__p_Dz9iWpf28LQNIqII7Tosyk;
                this.__p_BPH3GaTR155NUDApt7wW1t = other.__p_BPH3GaTR155NUDApt7wW1t;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Dz9iWpf28LQNIqII7Tosyk", in __p_Dz9iWpf28LQNIqII7Tosyk), n1.CompilationHelper.GetValueOrExisting(values, "__p_BPH3GaTR155NUDApt7wW1t", in __p_BPH3GaTR155NUDApt7wW1t));
            }

            internal __SDCgFqPUkekLJAuJJ2dkLR __WITH__(n8.FileNode __p_Dz9iWpf28LQNIqII7Tosyk, n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_BPH3GaTR155NUDApt7wW1t)
            {
                __SDCgFqPUkekLJAuJJ2dkLR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Dz9iWpf28LQNIqII7Tosyk != this.__p_Dz9iWpf28LQNIqII7Tosyk || __p_BPH3GaTR155NUDApt7wW1t != this.__p_BPH3GaTR155NUDApt7wW1t ? new __SDCgFqPUkekLJAuJJ2dkLR(this)
                    {__p_Dz9iWpf28LQNIqII7Tosyk = __p_Dz9iWpf28LQNIqII7Tosyk, __p_BPH3GaTR155NUDApt7wW1t = __p_BPH3GaTR155NUDApt7wW1t} : that_0;
                else
                {
                    this.__p_Dz9iWpf28LQNIqII7Tosyk = __p_Dz9iWpf28LQNIqII7Tosyk;
                    this.__p_BPH3GaTR155NUDApt7wW1t = __p_BPH3GaTR155NUDApt7wW1t;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 4509U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IgwzVY1otseO6SzguQMCo8", Name = "AssetMaterial_IgwzVY1otseO6SzguQMCo8")]
    [n2.SerializableAttribute]
    public class AssetMaterial_IgwzVY1otseO6SzguQMCo8 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetMaterial_IgwzVY1otseO6SzguQMCo8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 CreateDefault()
        {
            var instance = new AssetMaterial_IgwzVY1otseO6SzguQMCo8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 Update(string Material_Url_In, bool Reload_In, out n18.Material Output_Out, out bool Exists_Out)
        {
            var Output_3 = this.__p_ApWPpcGcoHvN0y89fPd83Y.Update<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Url_In: Material_Url_In, Reload_In: Reload_In, Asset_Out: out n18.Material Asset_0, Exists_Out: out bool Exists_1, Loading_Out: out bool Loading_2);
            Output_Out = Asset_0;
            Exists_Out = Exists_1;
            n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = Output_3 != this.__p_ApWPpcGcoHvN0y89fPd83Y ? new AssetMaterial_IgwzVY1otseO6SzguQMCo8(this)
                {__p_ApWPpcGcoHvN0y89fPd83Y = Output_3} : that_4;
            else
            {
                this.__p_ApWPpcGcoHvN0y89fPd83Y = Output_3;
            }

            return that_4;
        }

        public n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "ApWPpcGcoHvN0y89fPd83Y", 4514U);
            var Output_1 = n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Material>.Create(Node_Context: Node_Context_0);
            n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 that_2 = this;
            this.__p_ApWPpcGcoHvN0y89fPd83Y = Output_1;
            return that_2;
        }

        public n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 __CreateDefault__()
        {
            n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 that_0 = this;
            this.__p_ApWPpcGcoHvN0y89fPd83Y = n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Material>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ApWPpcGcoHvN0y89fPd83Y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 4514U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "ApWPpcGcoHvN0y89fPd83Y", Name = "Asset", IsManaged = true, IsAutoGenerated = true)]
        public n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Material> __p_ApWPpcGcoHvN0y89fPd83Y;
        public AssetMaterial_IgwzVY1otseO6SzguQMCo8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetMaterial_IgwzVY1otseO6SzguQMCo8(AssetMaterial_IgwzVY1otseO6SzguQMCo8 other): base(other)
        {
            this.__p_ApWPpcGcoHvN0y89fPd83Y = other.__p_ApWPpcGcoHvN0y89fPd83Y;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ApWPpcGcoHvN0y89fPd83Y", in __p_ApWPpcGcoHvN0y89fPd83Y));
        }

        internal AssetMaterial_IgwzVY1otseO6SzguQMCo8 __WITH__(n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Material> __p_ApWPpcGcoHvN0y89fPd83Y)
        {
            n3.AssetMaterial_IgwzVY1otseO6SzguQMCo8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ApWPpcGcoHvN0y89fPd83Y != this.__p_ApWPpcGcoHvN0y89fPd83Y ? new AssetMaterial_IgwzVY1otseO6SzguQMCo8(this)
                {__p_ApWPpcGcoHvN0y89fPd83Y = __p_ApWPpcGcoHvN0y89fPd83Y} : that_0;
            else
            {
                this.__p_ApWPpcGcoHvN0y89fPd83Y = __p_ApWPpcGcoHvN0y89fPd83Y;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 4539U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "F1JF1x8wm09NDzPw2aw8Pc", Name = "AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc")]
    [n2.SerializableAttribute]
    public class AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc CreateDefault()
        {
            var instance = new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc Update(string Prefab_Url_In, bool Reload_In, out n20.Entity Entity_Out, out bool Exists_Out)
        {
            n20.Entity __auto_0 = this.Entity;
            n21.Spread<n20.Entity> __auto_1 = this.Original_Prefab_Entities;
            n20.Entity __auto_2 = this.Entity;
            var Output_6 = this.__p_T6NK0epPOHDN2EBttwhEmr.Update<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Url_In: Prefab_Url_In, Reload_In: Reload_In, Asset_Out: out n20.Prefab Asset_3, Exists_Out: out bool Exists_4, Loading_Out: out bool Loading_5);
            bool Force_7 = false;
            bool Dispose_Cached_Outputs_8 = false;
            var manager_9 = this.__cache_AkyFqFHwIHkMysXWhPWkRn;
            if (manager_9 is null)
            {
                manager_9 = new n7.Manager<n2.ValueTuple<n20.Prefab>, n2.ValueTuple<n21.Spread<n20.Entity>, n20.Entity>>((n22._Operations_.CreateDefault<n20.Entity>(), default(n20.Entity)));
            }

            var inputs_10 = n2.ValueTuple.Create(Asset_3);
            var outputs_11 = manager_9.Outputs;
            var Has_Changed_12 = Force_7 || manager_9.InputsChanged(inputs_10);
            if (Has_Changed_12)
            {
                if (Dispose_Cached_Outputs_8)
                    manager_9.DisposeOutputs();
                n22._Operations_.Empty<n20.Entity>(Empty_Out: out n21.Spread<n20.Entity> Empty_14);
                n21.Spread<n20.Entity> __auto_15;
                if (Exists_4)
                {
                    var Result_17 = Asset_3.Instantiate();
                    n17.IEnumerable<n20.Entity> Input_18 = (n17.IEnumerable<n20.Entity>)Result_17;
                    n22._Operations_.FromSequence<n20.Entity>(Input_In: Input_18, Result_Out: out n21.Spread<n20.Entity> Result_19);
                    __auto_15 = Result_19;
                    var i_22 = 0;
                    foreach (var item_20 in n4.CollectionExtensions.AsSpan(Result_19))
                    {
                        var splicer_21 = item_20;
                        var i_local_23 = i_22;
                        bool Apply_25 = true;
                        if (Apply_25)
                        {
                            n20.EntityTransformExtensions.SetParent(entity: splicer_21, parent: __auto_0);
                        }

                        i_22++;
                    }
                }
                else
                {
                    __auto_15 = Empty_14;
                }

                n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "HbKtq8vd3ciQCh21aTJvbI", 4616U);
                n66._Operations_.Create(Node_Context: Node_Context_26, Output_Out: out n20.Entity Output_27);
                n34._Operations_.FirstOrDefault<n21.Spread<n20.Entity>, n20.Entity>(Input_In: __auto_15, Default_Value_In: Output_27, Output_Out: out n21.Spread<n20.Entity> Output_28, Result_Out: out n20.Entity Result_29);
                var i_32 = 0;
                foreach (var item_30 in n4.CollectionExtensions.AsSpan(__auto_1))
                {
                    var splicer_31 = item_30;
                    var i_local_33 = i_32;
                    n39._Operations_.NULL<n20.Entity>(Result_Out: out n20.Entity Result_35);
                    bool Apply_36 = true;
                    if (Apply_36)
                    {
                        n20.EntityTransformExtensions.SetParent(entity: splicer_31, parent: Result_35);
                    }

                    i_32++;
                }

                outputs_11 = (__auto_15, Result_29);
                manager_9 = manager_9.Update(inputs_10, __GetContext__().IsImmutable, Dispose_Cached_Outputs_8, default, outputs_11);
            }
            else
            {
                manager_9.Update(inputs_10, __GetContext__().IsImmutable, Dispose_Cached_Outputs_8);
            }

            var(__auto_37, __auto_38) = outputs_11;
            n21.Spread<n20.Entity> __auto_39 = __auto_37;
            Entity_Out = __auto_2;
            Exists_Out = Exists_4;
            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_40 = this;
            if (this.__GetContext__().IsImmutable)
                that_40 = Output_6 != this.__p_T6NK0epPOHDN2EBttwhEmr || manager_9 != this.__cache_AkyFqFHwIHkMysXWhPWkRn || __auto_37 != this.Original_Prefab_Entities ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_T6NK0epPOHDN2EBttwhEmr = Output_6, __cache_AkyFqFHwIHkMysXWhPWkRn = manager_9, Original_Prefab_Entities = __auto_37} : that_40;
            else
            {
                this.__p_T6NK0epPOHDN2EBttwhEmr = Output_6;
                this.__cache_AkyFqFHwIHkMysXWhPWkRn = manager_9;
                this.Original_Prefab_Entities = __auto_37;
            }

            return that_40;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc SetEntities(n21.Spread<n20.Entity> Children_In)
        {
            bool SetEntities_0 = true;
            var Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo;
            if (SetEntities_0)
            {
                Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo.SetEntities(Children_In: Children_In);
            }

            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1} : that_2;
            else
            {
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1;
            }

            return that_2;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc SetComponents(n21.Spread<n20.EntityComponent> Components_In)
        {
            bool SetComponents_0 = true;
            var Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo;
            if (SetComponents_0)
            {
                Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo.SetComponents(Components_In: Components_In);
            }

            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1} : that_2;
            else
            {
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1;
            }

            return that_2;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc SetTransformation(n53.Matrix Transformation_In)
        {
            bool SetTransformation_0 = true;
            var Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo;
            if (SetTransformation_0)
            {
                Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo.SetTransformation(Transformation_In: Transformation_In);
            }

            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1} : that_2;
            else
            {
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1;
            }

            return that_2;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc GetFirstPrefabEntity(out n20.Entity First_Original_Prefab_Entity_Out)
        {
            var manager_0 = this.__cache_AkyFqFHwIHkMysXWhPWkRn;
            if (manager_0 is null)
            {
                manager_0 = new n7.Manager<n2.ValueTuple<n20.Prefab>, n2.ValueTuple<n21.Spread<n20.Entity>, n20.Entity>>((n22._Operations_.CreateDefault<n20.Entity>(), default(n20.Entity)));
            }

            var(__auto_1, __auto_2) = manager_0.Outputs;
            First_Original_Prefab_Entity_Out = __auto_2;
            return this;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc GetPrefabEntities(out n21.Spread<n20.Entity> Original_Prefab_Entities_Out)
        {
            n21.Spread<n20.Entity> __auto_0 = this.Original_Prefab_Entities;
            Original_Prefab_Entities_Out = __auto_0;
            return this;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc SetName(string Name_In)
        {
            bool SetName_0 = true;
            var Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo;
            if (SetName_0)
            {
                Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo.SetName(Name_In: Name_In);
            }

            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1} : that_2;
            else
            {
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1;
            }

            return that_2;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc SetEnabled([n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            bool SetEnabled_0 = true;
            var Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo;
            if (SetEnabled_0)
            {
                Output_1 = this.__p_JqFmkDyEQmtPcyCMOWg0Xo.SetEnabled(Enabled_In: Enabled_In);
            }

            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1} : that_2;
            else
            {
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = Output_1;
            }

            return that_2;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_At0fyCtQKpcMmlhBGyNxho_0 = __slot_At0fyCtQKpcMmlhBGyNxho;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "JqFmkDyEQmtPcyCMOWg0Xo", 4548U);
            n17.IEnumerable<n20.EntityComponent> Base_Components_2 = n34._Operations_.CreateDefault<n20.EntityComponent>();
            var Output_3 = n67.Entity_OfyExcqEe4CPH8Wq0L8jzv.Create(Node_Context: Node_Context_1, Initial_Name_In: __pad_At0fyCtQKpcMmlhBGyNxho_0, Base_Components_In: Base_Components_2);
            var State_Output_5 = Output_3.GetEntity(Output_Out: out n20.Entity Output_4);
            n20.Entity __auto_6 = Output_4;
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "T6NK0epPOHDN2EBttwhEmr", 4619U);
            var Output_8 = n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Prefab>.Create(Node_Context: Node_Context_7);
            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_9 = this;
            this.Entity = Output_4;
            this.Original_Prefab_Entities = n22._Operations_.CreateDefault<n20.Entity>();
            this.__p_JqFmkDyEQmtPcyCMOWg0Xo = State_Output_5;
            this.__p_T6NK0epPOHDN2EBttwhEmr = Output_8;
            this.__cache_AkyFqFHwIHkMysXWhPWkRn = null;
            return that_9;
        }

        public n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc __CreateDefault__()
        {
            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_0 = this;
            this.Entity = default(n20.Entity);
            this.Original_Prefab_Entities = n22._Operations_.CreateDefault<n20.Entity>();
            this.__p_T6NK0epPOHDN2EBttwhEmr = n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Prefab>.CreateDefault();
            this.__cache_AkyFqFHwIHkMysXWhPWkRn = null;
            this.__p_JqFmkDyEQmtPcyCMOWg0Xo = n67.Entity_OfyExcqEe4CPH8Wq0L8jzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_T6NK0epPOHDN2EBttwhEmr);
            n1.CompilationHelper.SafeDispose(this.__cache_AkyFqFHwIHkMysXWhPWkRn);
            n1.CompilationHelper.SafeDispose(this.__p_JqFmkDyEQmtPcyCMOWg0Xo);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 4626U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "At0fyCtQKpcMmlhBGyNxho", Name = "__slot_At0fyCtQKpcMmlhBGyNxho")]
        public static string __slot_At0fyCtQKpcMmlhBGyNxho = "Prefab";
        [n1.ElementAttribute(TracingId = 4628U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "ADndyPXZlkvLZVRF5WhSt8", Name = "Entity")]
        public n20.Entity Entity;
        [n1.ElementAttribute(TracingId = 4632U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "PWVz9PT9orSOqmdvA0qInP", Name = "Original Prefab Entities")]
        public n21.Spread<n20.Entity> Original_Prefab_Entities;
        [n1.ElementAttribute(TracingId = 4619U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "T6NK0epPOHDN2EBttwhEmr", Name = "Asset", IsManaged = true, IsAutoGenerated = true)]
        public n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Prefab> __p_T6NK0epPOHDN2EBttwhEmr;
        [n1.ElementAttribute(TracingId = 4560U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AkyFqFHwIHkMysXWhPWkRn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n20.Prefab>, n2.ValueTuple<n21.Spread<n20.Entity>, n20.Entity>> __cache_AkyFqFHwIHkMysXWhPWkRn = null;
        [n1.ElementAttribute(TracingId = 4548U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "JqFmkDyEQmtPcyCMOWg0Xo", Name = "Entity", IsManaged = true, IsAutoGenerated = true)]
        public n67.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_JqFmkDyEQmtPcyCMOWg0Xo;
        static AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc()
        {
        }

        public AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc other): base(other)
        {
            this.Entity = other.Entity;
            this.Original_Prefab_Entities = other.Original_Prefab_Entities;
            this.__p_T6NK0epPOHDN2EBttwhEmr = other.__p_T6NK0epPOHDN2EBttwhEmr;
            this.__cache_AkyFqFHwIHkMysXWhPWkRn = other.__cache_AkyFqFHwIHkMysXWhPWkRn;
            this.__p_JqFmkDyEQmtPcyCMOWg0Xo = other.__p_JqFmkDyEQmtPcyCMOWg0Xo;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Entity", in Entity), n1.CompilationHelper.GetValueOrExisting(values, "Original_Prefab_Entities", in Original_Prefab_Entities), n1.CompilationHelper.GetValueOrExisting(values, "__p_T6NK0epPOHDN2EBttwhEmr", in __p_T6NK0epPOHDN2EBttwhEmr), n1.CompilationHelper.GetValueOrExisting(values, "__cache_AkyFqFHwIHkMysXWhPWkRn", in __cache_AkyFqFHwIHkMysXWhPWkRn), n1.CompilationHelper.GetValueOrExisting(values, "__p_JqFmkDyEQmtPcyCMOWg0Xo", in __p_JqFmkDyEQmtPcyCMOWg0Xo));
        }

        internal AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc __WITH__(n20.Entity Entity, n21.Spread<n20.Entity> Original_Prefab_Entities, n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Prefab> __p_T6NK0epPOHDN2EBttwhEmr, n7.Manager<n2.ValueTuple<n20.Prefab>, n2.ValueTuple<n21.Spread<n20.Entity>, n20.Entity>> __cache_AkyFqFHwIHkMysXWhPWkRn, n67.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_JqFmkDyEQmtPcyCMOWg0Xo)
        {
            n3.AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Entity != this.Entity || Original_Prefab_Entities != this.Original_Prefab_Entities || __p_T6NK0epPOHDN2EBttwhEmr != this.__p_T6NK0epPOHDN2EBttwhEmr || __cache_AkyFqFHwIHkMysXWhPWkRn != this.__cache_AkyFqFHwIHkMysXWhPWkRn || __p_JqFmkDyEQmtPcyCMOWg0Xo != this.__p_JqFmkDyEQmtPcyCMOWg0Xo ? new AssetPrefab_F1JF1x8wm09NDzPw2aw8Pc(this)
                {Entity = Entity, Original_Prefab_Entities = Original_Prefab_Entities, __p_T6NK0epPOHDN2EBttwhEmr = __p_T6NK0epPOHDN2EBttwhEmr, __cache_AkyFqFHwIHkMysXWhPWkRn = __cache_AkyFqFHwIHkMysXWhPWkRn, __p_JqFmkDyEQmtPcyCMOWg0Xo = __p_JqFmkDyEQmtPcyCMOWg0Xo} : that_0;
            else
            {
                this.Entity = Entity;
                this.Original_Prefab_Entities = Original_Prefab_Entities;
                this.__p_T6NK0epPOHDN2EBttwhEmr = __p_T6NK0epPOHDN2EBttwhEmr;
                this.__cache_AkyFqFHwIHkMysXWhPWkRn = __cache_AkyFqFHwIHkMysXWhPWkRn;
                this.__p_JqFmkDyEQmtPcyCMOWg0Xo = __p_JqFmkDyEQmtPcyCMOWg0Xo;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 4989U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "M7djlgidxbFQD0mWqmavrG", Name = "LoadProject_M7djlgidxbFQD0mWqmavrG")]
    [n2.SerializableAttribute]
    public class LoadProject_M7djlgidxbFQD0mWqmavrG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.LoadProject_M7djlgidxbFQD0mWqmavrG Create(n1.NodeContext Node_Context)
        {
            var instance = new LoadProject_M7djlgidxbFQD0mWqmavrG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.LoadProject_M7djlgidxbFQD0mWqmavrG CreateDefault()
        {
            var instance = new LoadProject_M7djlgidxbFQD0mWqmavrG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.LoadProject_M7djlgidxbFQD0mWqmavrG Update(n5.Path Project_Path_In, bool Reload_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Reload_In, out bool Loading_Out, out bool Project_Is_Loading_Out, out n21.Spread<n2.Object> Contents_Out, out n21.Spread<bool> On_Data_Out, out n21.Spread<string> Content_URLs_Out, out n21.Spread<bool> Content_Is_Loading_Out, out bool Any_Content_Is_Loading_Out, out n21.Spread<n13.AssetItem> Available_Assets_Out, out int Changes_Out)
        {
            bool __auto_0 = this.Project_Loading;
            n2.Type __auto_1 = this.Filter_Exclude_Type;
            var Output_4 = this.__p_M2sp5nggGBOLRZCsVLtnao.Update(Value_In: Project_Path_In, Result_Out: out bool Result_2, Unchanged_Out: out bool Unchanged_3);
            Project_Path_In.Filename(directory: out string Directory_5, filename: out string Filename_6, extension: out string Extension_7);
            string Filter_8 = "";
            bool Include_Subdirectories_9 = false;
            bool Update_10 = true;
            var Output_11 = this.__p_KbIoNW6BWkmPQFtYi001l6;
            if (Update_10)
            {
                n8.Watcher Input_12 = this.__p_KbIoNW6BWkmPQFtYi001l6;
                Input_12.Update(path: Directory_5, filter: Filter_8, includeSubdirectories: Include_Subdirectories_9);
                Output_11 = Input_12;
            }

            var Changed_13 = Output_11.Changed;
            bool Reset_14 = false;
            bool Update_15 = true;
            var Output_16 = this.__p_JJ4Fsw7hjGbPy1sTqCrN0H;
            if (Update_15)
            {
                n68._Operations_.Update_H<n5.Path>(Input_In: this.__p_JJ4Fsw7hjGbPy1sTqCrN0H, Async_Notifications_In: Changed_13, Reset_In: Reset_14, Output_Out: out Output_16);
            }

            n68._Operations_.GetData_H<n5.Path>(Input_In: Output_16, Output_Out: out n69.HoldLatest<n5.Path> Output_17, Value_Out: out n5.Path Value_18, On_Data_Out: out bool On_Data_19);
            var Output_20 = On_Data_19 && Auto_Reload_In;
            var Output_21 = Reload_In || Output_20;
            var Output_22 = !__auto_0;
            var Output_23 = Output_21 && Output_22;
            var Output_24 = Result_2 || Output_23;
            float Time_25 = 0.25F;
            bool Retriggerable_26 = true;
            bool Reset_27 = false;
            var Output_30 = this.__p_U1oCM7F1M5GO0XegwsNfdG.Update(Set_In: On_Data_19, Time_In: Time_25, Retriggerable_In: Retriggerable_26, Reset_In: Reset_27, Value_Out: out bool Value_28, Inverse_Output_Out: out bool Inverse_Output_29);
            var Output_33 = this.__p_LYyGoQ9MG0tOulyKDQkJKc.Update(Value_In: Value_28, Up_Edge_Out: out bool Up_Edge_31, Down_Edge_Out: out bool Down_Edge_32);
            int Increment_34 = 1;
            int Default_35 = 0;
            bool Update_36 = true;
            var Output_37 = this.__p_SRE0vzVcq49OEPXMLxF53c;
            if (Update_36)
            {
                Output_37 = this.__p_SRE0vzVcq49OEPXMLxF53c.Update(Increment_In: Increment_34, Default_In: Default_35);
            }

            var Output_38 = Output_37;
            if (On_Data_19)
            {
                Output_38 = Output_37.Up();
            }

            var Output_40 = Output_38.GetValue(Value_Out: out int Value_39);
            bool Update_41 = true;
            var Output_42 = this.__p_TfDLLxjDjvgPMcLtq3huQc;
            if (Update_41)
            {
                Output_42 = this.__p_TfDLLxjDjvgPMcLtq3huQc.Update();
            }

            bool Abort_43 = false;
            var __fallback___44 = n1.ServiceRegistry.Current;
            n71._Operations_.Update_H<n21.Spread<n13.AssetItem>, n2.Object>(Input_In: this.__p_DJhopjb0VQgNyadNFPzQJG, Trigger_In: Output_24, Abort_In: Abort_43, Update_In: (n2.Object s_47, n70.CancellationToken Input_1_In_48) =>
            {
                using var __current_45 = __fallback___44.MakeCurrentIfNone();
                var state_46 = n1.CompilationHelper.Restore<__PKd0BDCRi26O2Rqh9lPuKv>(s_47, __GetContext__());
                string __pad_KRXQinvfm2IOtizbHcexnx_49 = __slot_KRXQinvfm2IOtizbHcexnx;
                var Exists_50 = Project_Path_In.Exists;
                Project_Path_In.Filename(directory: out string Directory_51, filename: out string Filename_52, extension: out string Extension_53);
                var Result_54 = Extension_53 == __pad_KRXQinvfm2IOtizbHcexnx_49;
                var Output_55 = Exists_50 && Result_54;
                n21.Spread<n13.AssetItem> __auto_56;
                if (Output_55)
                {
                    bool Add_58 = true;
                    var Output_60 = Output_42.AddProject(Add_In: Add_58, Project_Path_In: Project_Path_In, Assets_Out: out n13.PackageAssetCollection Assets_59);
                    n17.IEnumerable<n13.AssetItem> Input_61 = (n17.IEnumerable<n13.AssetItem>)Assets_59;
                    n14._Operations_.OrderAssets(Input_In: Input_61, Result_Out: out n21.Spread<n13.AssetItem> Result_62);
                    __auto_56 = Result_62;
                }
                else
                {
                    __auto_56 = n22._Operations_.CreateDefault<n13.AssetItem>();
                }

                return n2.Tuple.Create<n2.Object, n21.Spread<n13.AssetItem>>(state_46, __auto_56);
            }

            , Create_In: () =>
            {
                using var __current_63 = __fallback___44.MakeCurrentIfNone();
                var state_46 = new __PKd0BDCRi26O2Rqh9lPuKv(__GetContext__(), n1.VLObject.NewIdentity());
                return state_46;
            }

            , Output_Out: out n69.AsyncTask<n21.Spread<n13.AssetItem>> Output_64, Result_Out: out n2.IObservable<n21.Spread<n13.AssetItem>> Result_65, In_Progress_Out: out bool In_Progress_66);
            bool Reset_67 = false;
            bool Update_68 = true;
            var Output_69 = this.__p_GeSvzyNtrqDO38sW7B5rGy;
            if (Update_68)
            {
                n68._Operations_.Update_H<n21.Spread<n13.AssetItem>>(Input_In: this.__p_GeSvzyNtrqDO38sW7B5rGy, Async_Notifications_In: Result_65, Reset_In: Reset_67, Output_Out: out Output_69);
            }

            n68._Operations_.GetData_H<n21.Spread<n13.AssetItem>>(Input_In: Output_69, Output_Out: out n69.HoldLatest<n21.Spread<n13.AssetItem>> Output_70, Value_Out: out n21.Spread<n13.AssetItem> Value_71, On_Data_Out: out bool On_Data_72);
            var Output_73 = this.__p_TEgC8tk127xMsv3oUb3FI7;
            if (Output_24)
            {
                Output_73 = this.__p_TEgC8tk127xMsv3oUb3FI7.Set();
            }

            var Output_74 = Output_73;
            if (On_Data_72)
            {
                Output_74 = Output_73.Reset();
            }

            var Output_76 = Output_74.GetState(State_Out: out bool State_75);
            n17.IEnumerable<n13.AssetItem> Input_77 = (n17.IEnumerable<n13.AssetItem>)Value_71;
            bool Dispose_Cached_Outputs_78 = false;
            var manager_79 = this.__cache_OAIUednlv7WM0ZoMJwBmJI;
            if (manager_79 is null)
            {
                manager_79 = new n7.Manager<n2.ValueTuple, n2.ValueTuple<n21.Spread<n43.Reference_C<bool>>, n21.Spread<n2.IObservable<n2.Object>>, n21.Spread<string>>>((n22._Operations_.CreateDefault<n43.Reference_C<bool>>(), n22._Operations_.CreateDefault<n2.IObservable<n2.Object>>(), n22._Operations_.CreateDefault<string>()));
            }

            var inputs_80 = n2.ValueTuple.Create();
            var outputs_81 = manager_79.Outputs;
            var Has_Changed_82 = On_Data_72 || manager_79.InputsChanged(inputs_80);
            if (Has_Changed_82)
            {
                if (Dispose_Cached_Outputs_78)
                    manager_79.DisposeOutputs();
                var state_83 = n1.CompilationHelper.Restore<__Sk0ZbOM0n1yMegkDnicWys>(manager_79.State, __GetContext__());
                if (state_83 == null)
                {
                    state_83 = new __Sk0ZbOM0n1yMegkDnicWys(__GetContext__(), n1.VLObject.NewIdentity())
                    {Urls = n22._Operations_.CreateDefault<string>()};
                    n1.NodeContext Node_Context_84 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "QydNeSf23zVNinleEqQNuK", 5181U);
                    var Output_85 = n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<n2.Object>.Create(Node_Context: Node_Context_84);
                    state_83.__p_QydNeSf23zVNinleEqQNuK = Output_85;
                    n1.NodeContext Node_Context_86 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "BdF4EPgTTKKOM2s3GwlqkZ", 5223U);
                    var Output_87 = n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM.Create(Node_Context: Node_Context_86);
                    state_83.__p_BdF4EPgTTKKOM2s3GwlqkZ = Output_87;
                }

                n21.Spread<string> __auto_88 = state_83.Urls;
                n14._Operations_.FilterAssets(Input_In: Input_77, Excluded_Type_In: __auto_1, Output_Out: out n17.IEnumerable<n13.AssetItem> Output_89);
                n17.IEnumerable<string> Urls_90 = (n17.IEnumerable<string>)__auto_88;
                var Output_92 = state_83.__p_BdF4EPgTTKKOM2s3GwlqkZ.Update(New_Assets_In: Output_89, Urls_In: Urls_90, Execution_Order_Helper_Out: out bool Execution_Order_Helper_91);
                var Output_96 = state_83.__p_QydNeSf23zVNinleEqQNuK.Update<n17.IEnumerable<n13.AssetItem>, n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Asset_Items_In: Output_89, Execution_Order_Helper_In: Execution_Order_Helper_91, Urls_Out: out n21.Spread<string> Urls_93, Is_Loading_Out: out n21.Spread<n43.Reference_C<bool>> Is_Loading_94, Content_Out: out n21.Spread<n2.IObservable<n2.Object>> Content_95);
                n21.Spread<string> __auto_97 = Urls_93;
                if (state_83.__GetContext__().IsImmutable)
                    state_83 = Output_92 != state_83.__p_BdF4EPgTTKKOM2s3GwlqkZ || Output_96 != state_83.__p_QydNeSf23zVNinleEqQNuK || Urls_93 != state_83.Urls ? new __Sk0ZbOM0n1yMegkDnicWys(state_83)
                    {__p_BdF4EPgTTKKOM2s3GwlqkZ = Output_92, __p_QydNeSf23zVNinleEqQNuK = Output_96, Urls = Urls_93} : state_83;
                else
                {
                    state_83.__p_BdF4EPgTTKKOM2s3GwlqkZ = Output_92;
                    state_83.__p_QydNeSf23zVNinleEqQNuK = Output_96;
                    state_83.Urls = Urls_93;
                }

                outputs_81 = (Is_Loading_94, Content_95, Urls_93);
                manager_79 = manager_79.Update(inputs_80, __GetContext__().IsImmutable, Dispose_Cached_Outputs_78, state_83, outputs_81);
            }
            else
            {
                manager_79.Update(inputs_80, __GetContext__().IsImmutable, Dispose_Cached_Outputs_78);
            }

            var(__auto_98, __auto_99, __auto_100) = outputs_81;
            bool accumulator_101 = false;
            var enumerator_102 = n4.CollectionExtensions.AsSpan(__auto_99).GetEnumerator();
            var enumerator_104 = n4.CollectionExtensions.AsSpan(__auto_98).GetEnumerator();
            var manager_121 = this.__loop_RPXMUg9SLP4NouBbro1pX4 ?? new n44.ImmutableLifetimeManager();
            var iterator_122 = manager_121.GetIterator(__GetContext__());
            var builder_123 = n4.CollectionBuilders.GetBuilder(this.__cp_LoUNZaOhG9MLlLX8tmao3U, 16);
            n21.Spread<n2.Object> output_124;
            var builder_125 = n4.CollectionBuilders.GetBuilder(this.__cp_D1mOpWyh7LgMv2ZjxP6rcB, 16);
            n21.Spread<bool> output_126;
            var builder_127 = n4.CollectionBuilders.GetBuilder(this.__cp_SK2rb3atyxQQEgElmkXI3I, 16);
            n21.Spread<bool> output_128;
            try
            {
                var i_106 = 0;
                while (enumerator_102.MoveNext() && enumerator_104.MoveNext())
                {
                    var splicer_103 = enumerator_102.Current;
                    var splicer_105 = enumerator_104.Current;
                    var i_local_107 = i_106;
                    __SDGNN7AXSFmNtF6ByrSD9X state_108;
                    if (!iterator_122.MoveNext(out state_108))
                    {
                        iterator_122.Add(state_108 = new __SDGNN7AXSFmNtF6ByrSD9X(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_109 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "VEnORJjJGRLMD3xU28kwED", 5252U);
                        n2.Object Initial_Result_110 = n39._Operations_.CreateDefault();
                        n68._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_109, Initial_Result_In: Initial_Result_110, Output_Out: out n69.HoldLatest<n2.Object> Output_111);
                        state_108.__p_VEnORJjJGRLMD3xU28kwED = Output_111;
                    }

                    bool Reset_112 = false;
                    bool Update_113 = true;
                    var Output_114 = state_108.__p_VEnORJjJGRLMD3xU28kwED;
                    if (Update_113)
                    {
                        n68._Operations_.Update_H<n2.Object>(Input_In: state_108.__p_VEnORJjJGRLMD3xU28kwED, Async_Notifications_In: splicer_103, Reset_In: Reset_112, Output_Out: out Output_114);
                    }

                    n68._Operations_.GetData_H<n2.Object>(Input_In: Output_114, Output_Out: out n69.HoldLatest<n2.Object> Output_115, Value_Out: out n2.Object Value_116, On_Data_Out: out bool On_Data_117);
                    var Output_119 = splicer_105.Data_(Data_Out: out bool Data_118);
                    var Output_120 = Data_118 || accumulator_101;
                    if (state_108.__GetContext__().IsImmutable)
                        state_108 = Output_115 != state_108.__p_VEnORJjJGRLMD3xU28kwED ? new __SDGNN7AXSFmNtF6ByrSD9X(state_108)
                        {__p_VEnORJjJGRLMD3xU28kwED = Output_115} : state_108;
                    else
                    {
                        state_108.__p_VEnORJjJGRLMD3xU28kwED = Output_115;
                    }

                    iterator_122.Update(state_108);
                    builder_123.Add(Value_116);
                    builder_125.Add(On_Data_117);
                    builder_127.Add(Data_118);
                    accumulator_101 = Output_120;
                    i_106++;
                }
            }
            finally
            {
                manager_121 = iterator_122.Commit();
                output_124 = builder_123.Commit();
                output_126 = builder_125.Commit();
                output_128 = builder_127.Commit();
            }

            var Output_129 = State_75 || accumulator_101;
            bool __auto_130 = State_75;
            Loading_Out = Output_129;
            Project_Is_Loading_Out = State_75;
            Contents_Out = output_124;
            On_Data_Out = output_126;
            Content_URLs_Out = __auto_100;
            Content_Is_Loading_Out = output_128;
            Any_Content_Is_Loading_Out = accumulator_101;
            Available_Assets_Out = Value_71;
            Changes_Out = Value_39;
            n3.LoadProject_M7djlgidxbFQD0mWqmavrG that_131 = this;
            if (this.__GetContext__().IsImmutable)
                that_131 = Output_4 != this.__p_M2sp5nggGBOLRZCsVLtnao || Output_11 != this.__p_KbIoNW6BWkmPQFtYi001l6 || Output_17 != this.__p_JJ4Fsw7hjGbPy1sTqCrN0H || Output_30 != this.__p_U1oCM7F1M5GO0XegwsNfdG || Output_33 != this.__p_LYyGoQ9MG0tOulyKDQkJKc || Output_40 != this.__p_SRE0vzVcq49OEPXMLxF53c || Output_42 != this.__p_TfDLLxjDjvgPMcLtq3huQc || Output_64 != this.__p_DJhopjb0VQgNyadNFPzQJG || Output_70 != this.__p_GeSvzyNtrqDO38sW7B5rGy || Output_76 != this.__p_TEgC8tk127xMsv3oUb3FI7 || manager_79 != this.__cache_OAIUednlv7WM0ZoMJwBmJI || manager_121 != this.__loop_RPXMUg9SLP4NouBbro1pX4 || output_124 != this.__cp_LoUNZaOhG9MLlLX8tmao3U || output_126 != this.__cp_D1mOpWyh7LgMv2ZjxP6rcB || output_128 != this.__cp_SK2rb3atyxQQEgElmkXI3I || State_75 != this.Project_Loading ? new LoadProject_M7djlgidxbFQD0mWqmavrG(this)
                {__p_M2sp5nggGBOLRZCsVLtnao = Output_4, __p_KbIoNW6BWkmPQFtYi001l6 = Output_11, __p_JJ4Fsw7hjGbPy1sTqCrN0H = Output_17, __p_U1oCM7F1M5GO0XegwsNfdG = Output_30, __p_LYyGoQ9MG0tOulyKDQkJKc = Output_33, __p_SRE0vzVcq49OEPXMLxF53c = Output_40, __p_TfDLLxjDjvgPMcLtq3huQc = Output_42, __p_DJhopjb0VQgNyadNFPzQJG = Output_64, __p_GeSvzyNtrqDO38sW7B5rGy = Output_70, __p_TEgC8tk127xMsv3oUb3FI7 = Output_76, __cache_OAIUednlv7WM0ZoMJwBmJI = manager_79, __loop_RPXMUg9SLP4NouBbro1pX4 = manager_121, __cp_LoUNZaOhG9MLlLX8tmao3U = output_124, __cp_D1mOpWyh7LgMv2ZjxP6rcB = output_126, __cp_SK2rb3atyxQQEgElmkXI3I = output_128, Project_Loading = State_75} : that_131;
            else
            {
                this.__p_M2sp5nggGBOLRZCsVLtnao = Output_4;
                this.__p_KbIoNW6BWkmPQFtYi001l6 = Output_11;
                this.__p_JJ4Fsw7hjGbPy1sTqCrN0H = Output_17;
                this.__p_U1oCM7F1M5GO0XegwsNfdG = Output_30;
                this.__p_LYyGoQ9MG0tOulyKDQkJKc = Output_33;
                this.__p_SRE0vzVcq49OEPXMLxF53c = Output_40;
                this.__p_TfDLLxjDjvgPMcLtq3huQc = Output_42;
                this.__p_DJhopjb0VQgNyadNFPzQJG = Output_64;
                this.__p_GeSvzyNtrqDO38sW7B5rGy = Output_70;
                this.__p_TEgC8tk127xMsv3oUb3FI7 = Output_76;
                this.__cache_OAIUednlv7WM0ZoMJwBmJI = manager_79;
                this.__loop_RPXMUg9SLP4NouBbro1pX4 = manager_121;
                this.__cp_LoUNZaOhG9MLlLX8tmao3U = output_124;
                this.__cp_D1mOpWyh7LgMv2ZjxP6rcB = output_126;
                this.__cp_SK2rb3atyxQQEgElmkXI3I = output_128;
                this.Project_Loading = State_75;
            }

            return that_131;
        }

        public n3.LoadProject_M7djlgidxbFQD0mWqmavrG __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_M8WQrNUlUf6Ng13WrPeWZB_0 = __slot_M8WQrNUlUf6Ng13WrPeWZB;
            var Result_1 = n2.Type.GetType(typeName: __pad_M8WQrNUlUf6Ng13WrPeWZB_0);
            n2.Type __auto_2 = Result_1;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "TfDLLxjDjvgPMcLtq3huQc", 5333U);
            var Output_4 = n14.ExistingProject_C.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "DJhopjb0VQgNyadNFPzQJG", 4996U);
            n71._Operations_.Create_H<n21.Spread<n13.AssetItem>>(Node_Context: Node_Context_5, Output_Out: out n69.AsyncTask<n21.Spread<n13.AssetItem>> Output_6);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "M2sp5nggGBOLRZCsVLtnao", 5138U);
            bool Changed_On_Create_8 = true;
            var Output_9 = n72.Changed_A8JGbead2bxNdnPybiEqVS<n5.Path>.Create<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Node_Context: Node_Context_7, Changed_On_Create_In: Changed_On_Create_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "GeSvzyNtrqDO38sW7B5rGy", 5146U);
            n21.Spread<n13.AssetItem> Initial_Result_11 = n22._Operations_.CreateDefault<n13.AssetItem>();
            n68._Operations_.Create_H<n21.Spread<n13.AssetItem>>(Node_Context: Node_Context_10, Initial_Result_In: Initial_Result_11, Output_Out: out n69.HoldLatest<n21.Spread<n13.AssetItem>> Output_12);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "TEgC8tk127xMsv3oUb3FI7", 5302U);
            var Output_14 = n72.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "KbIoNW6BWkmPQFtYi001l6", 5384U);
            n73._Operations_.Create_H(Node_Context: Node_Context_15, Output_Out: out n8.Watcher Output_16);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "JJ4Fsw7hjGbPy1sTqCrN0H", 5406U);
            n5.Path Initial_Result_18 = n74._Operations_.CreateDefault();
            n68._Operations_.Create_H<n5.Path>(Node_Context: Node_Context_17, Initial_Result_In: Initial_Result_18, Output_Out: out n69.HoldLatest<n5.Path> Output_19);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "SRE0vzVcq49OEPXMLxF53c", 5422U);
            var Output_21 = n75.Counter_UIay2coHW4dO2NuoNnTZ3G.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "U1oCM7F1M5GO0XegwsNfdG", 5446U);
            n77.IClock Clock_23 = n76._Operations_.CreateDefault();
            var Output_24 = n72.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.Create(Node_Context: Node_Context_22, Clock_In: Clock_23);
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "LYyGoQ9MG0tOulyKDQkJKc", 5459U);
            var Output_26 = n72.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_25);
            n3.LoadProject_M7djlgidxbFQD0mWqmavrG that_27 = this;
            this.Filter_Exclude_Type = Result_1;
            this.Project_Loading = false;
            this.__cp_LoUNZaOhG9MLlLX8tmao3U = n22._Operations_.CreateDefault<n2.Object>();
            this.__cp_D1mOpWyh7LgMv2ZjxP6rcB = n22._Operations_.CreateDefault<bool>();
            this.__cp_SK2rb3atyxQQEgElmkXI3I = n22._Operations_.CreateDefault<bool>();
            this.__p_TfDLLxjDjvgPMcLtq3huQc = Output_4;
            this.__p_DJhopjb0VQgNyadNFPzQJG = Output_6;
            this.__p_M2sp5nggGBOLRZCsVLtnao = Output_9;
            this.__p_GeSvzyNtrqDO38sW7B5rGy = Output_12;
            this.__p_TEgC8tk127xMsv3oUb3FI7 = Output_14;
            this.__p_KbIoNW6BWkmPQFtYi001l6 = Output_16;
            this.__p_JJ4Fsw7hjGbPy1sTqCrN0H = Output_19;
            this.__p_SRE0vzVcq49OEPXMLxF53c = Output_21;
            this.__p_U1oCM7F1M5GO0XegwsNfdG = Output_24;
            this.__p_LYyGoQ9MG0tOulyKDQkJKc = Output_26;
            this.__cache_OAIUednlv7WM0ZoMJwBmJI = null;
            this.__loop_RPXMUg9SLP4NouBbro1pX4 = default(n44.ImmutableLifetimeManager);
            return that_27;
        }

        public n3.LoadProject_M7djlgidxbFQD0mWqmavrG Dispose_()
        {
            n1.CompilationHelper.SafeDispose(this.__p_M2sp5nggGBOLRZCsVLtnao);
            n1.CompilationHelper.SafeDispose(this.__p_KbIoNW6BWkmPQFtYi001l6);
            n1.CompilationHelper.SafeDispose(this.__p_JJ4Fsw7hjGbPy1sTqCrN0H);
            n1.CompilationHelper.SafeDispose(this.__p_U1oCM7F1M5GO0XegwsNfdG);
            n1.CompilationHelper.SafeDispose(this.__p_LYyGoQ9MG0tOulyKDQkJKc);
            n1.CompilationHelper.SafeDispose(this.__p_SRE0vzVcq49OEPXMLxF53c);
            n1.CompilationHelper.SafeDispose(this.__p_TfDLLxjDjvgPMcLtq3huQc);
            n1.CompilationHelper.SafeDispose(this.__p_DJhopjb0VQgNyadNFPzQJG);
            n1.CompilationHelper.SafeDispose(this.__p_GeSvzyNtrqDO38sW7B5rGy);
            n1.CompilationHelper.SafeDispose(this.__p_TEgC8tk127xMsv3oUb3FI7);
            n1.CompilationHelper.SafeDispose(this.__cache_OAIUednlv7WM0ZoMJwBmJI);
            n1.CompilationHelper.SafeDispose(this.__loop_RPXMUg9SLP4NouBbro1pX4);
            return this;
        }

        public n3.LoadProject_M7djlgidxbFQD0mWqmavrG __CreateDefault__()
        {
            n3.LoadProject_M7djlgidxbFQD0mWqmavrG that_0 = this;
            this.Filter_Exclude_Type = default(n2.Type);
            this.Project_Loading = false;
            this.__cp_LoUNZaOhG9MLlLX8tmao3U = n22._Operations_.CreateDefault<n2.Object>();
            this.__cp_D1mOpWyh7LgMv2ZjxP6rcB = n22._Operations_.CreateDefault<bool>();
            this.__cp_SK2rb3atyxQQEgElmkXI3I = n22._Operations_.CreateDefault<bool>();
            this.__p_M2sp5nggGBOLRZCsVLtnao = n72.Changed_A8JGbead2bxNdnPybiEqVS<n5.Path>.CreateDefault<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>();
            this.__p_KbIoNW6BWkmPQFtYi001l6 = default(n8.Watcher);
            this.__p_JJ4Fsw7hjGbPy1sTqCrN0H = default(n69.HoldLatest<n5.Path>);
            this.__p_U1oCM7F1M5GO0XegwsNfdG = n72.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.CreateDefault();
            this.__p_LYyGoQ9MG0tOulyKDQkJKc = n72.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_SRE0vzVcq49OEPXMLxF53c = n75.Counter_UIay2coHW4dO2NuoNnTZ3G.CreateDefault();
            this.__p_TfDLLxjDjvgPMcLtq3huQc = n14.ExistingProject_C.CreateDefault();
            this.__p_DJhopjb0VQgNyadNFPzQJG = default(n69.AsyncTask<n21.Spread<n13.AssetItem>>);
            this.__p_GeSvzyNtrqDO38sW7B5rGy = default(n69.HoldLatest<n21.Spread<n13.AssetItem>>);
            this.__p_TEgC8tk127xMsv3oUb3FI7 = n72.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__cache_OAIUednlv7WM0ZoMJwBmJI = null;
            this.__loop_RPXMUg9SLP4NouBbro1pX4 = default(n44.ImmutableLifetimeManager);
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 5355U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "M8WQrNUlUf6Ng13WrPeWZB", Name = "__slot_M8WQrNUlUf6Ng13WrPeWZB")]
        public static string __slot_M8WQrNUlUf6Ng13WrPeWZB = "Stride.Core.Assets.SourceCodeAsset, Stride.Core.Assets";
        [n1.ElementAttribute(TracingId = 5357U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OD65LwHwQHhP7MYMXZy4Nd", Name = "Filter Exclude Type")]
        public n2.Type Filter_Exclude_Type;
        [n1.ElementAttribute(TracingId = 5370U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "QUFCbUiRubzQaMU3l0SBHQ", Name = "Project Loading")]
        public bool Project_Loading;
        [n1.ElementAttribute(TracingId = 5138U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "M2sp5nggGBOLRZCsVLtnao", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n72.Changed_A8JGbead2bxNdnPybiEqVS<n5.Path> __p_M2sp5nggGBOLRZCsVLtnao;
        [n1.ElementAttribute(TracingId = 5384U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "KbIoNW6BWkmPQFtYi001l6", Name = "FileWatcher", IsManaged = true, IsAutoGenerated = true)]
        public n8.Watcher __p_KbIoNW6BWkmPQFtYi001l6;
        [n1.ElementAttribute(TracingId = 5406U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "JJ4Fsw7hjGbPy1sTqCrN0H", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n69.HoldLatest<n5.Path> __p_JJ4Fsw7hjGbPy1sTqCrN0H;
        [n1.ElementAttribute(TracingId = 5446U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "U1oCM7F1M5GO0XegwsNfdG", Name = "MonoFlop", IsManaged = true, IsAutoGenerated = true)]
        public n72.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_U1oCM7F1M5GO0XegwsNfdG;
        [n1.ElementAttribute(TracingId = 5459U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "LYyGoQ9MG0tOulyKDQkJKc", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n72.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LYyGoQ9MG0tOulyKDQkJKc;
        [n1.ElementAttribute(TracingId = 5422U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SRE0vzVcq49OEPXMLxF53c", Name = "Counter", IsManaged = true, IsAutoGenerated = true)]
        public n75.Counter_UIay2coHW4dO2NuoNnTZ3G __p_SRE0vzVcq49OEPXMLxF53c;
        [n1.ElementAttribute(TracingId = 5333U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "TfDLLxjDjvgPMcLtq3huQc", Name = "ExistingProject", IsManaged = true, IsAutoGenerated = true)]
        public n14.ExistingProject_C __p_TfDLLxjDjvgPMcLtq3huQc;
        [n1.ElementAttribute(TracingId = 4996U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "DJhopjb0VQgNyadNFPzQJG", Name = "AsyncTask", IsManaged = true, IsAutoGenerated = true)]
        public n69.AsyncTask<n21.Spread<n13.AssetItem>> __p_DJhopjb0VQgNyadNFPzQJG;
        [n1.ElementAttribute(TracingId = 5113U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "KRXQinvfm2IOtizbHcexnx", Name = "__slot_KRXQinvfm2IOtizbHcexnx")]
        public static string __slot_KRXQinvfm2IOtizbHcexnx = "csproj";
        [n1.ElementAttribute(TracingId = 5146U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "GeSvzyNtrqDO38sW7B5rGy", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n69.HoldLatest<n21.Spread<n13.AssetItem>> __p_GeSvzyNtrqDO38sW7B5rGy;
        [n1.ElementAttribute(TracingId = 5302U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "TEgC8tk127xMsv3oUb3FI7", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n72.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_TEgC8tk127xMsv3oUb3FI7;
        [n1.ElementAttribute(TracingId = 5159U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OAIUednlv7WM0ZoMJwBmJI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple, n2.ValueTuple<n21.Spread<n43.Reference_C<bool>>, n21.Spread<n2.IObservable<n2.Object>>, n21.Spread<string>>> __cache_OAIUednlv7WM0ZoMJwBmJI = null;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n44.ImmutableLifetimeManager __loop_RPXMUg9SLP4NouBbro1pX4;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<n2.Object> __cp_LoUNZaOhG9MLlLX8tmao3U;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<bool> __cp_D1mOpWyh7LgMv2ZjxP6rcB;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<bool> __cp_SK2rb3atyxQQEgElmkXI3I;
        static LoadProject_M7djlgidxbFQD0mWqmavrG()
        {
        }

        public LoadProject_M7djlgidxbFQD0mWqmavrG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LoadProject_M7djlgidxbFQD0mWqmavrG(LoadProject_M7djlgidxbFQD0mWqmavrG other): base(other)
        {
            this.Filter_Exclude_Type = other.Filter_Exclude_Type;
            this.Project_Loading = other.Project_Loading;
            this.__p_M2sp5nggGBOLRZCsVLtnao = other.__p_M2sp5nggGBOLRZCsVLtnao;
            this.__p_KbIoNW6BWkmPQFtYi001l6 = other.__p_KbIoNW6BWkmPQFtYi001l6;
            this.__p_JJ4Fsw7hjGbPy1sTqCrN0H = other.__p_JJ4Fsw7hjGbPy1sTqCrN0H;
            this.__p_U1oCM7F1M5GO0XegwsNfdG = other.__p_U1oCM7F1M5GO0XegwsNfdG;
            this.__p_LYyGoQ9MG0tOulyKDQkJKc = other.__p_LYyGoQ9MG0tOulyKDQkJKc;
            this.__p_SRE0vzVcq49OEPXMLxF53c = other.__p_SRE0vzVcq49OEPXMLxF53c;
            this.__p_TfDLLxjDjvgPMcLtq3huQc = other.__p_TfDLLxjDjvgPMcLtq3huQc;
            this.__p_DJhopjb0VQgNyadNFPzQJG = other.__p_DJhopjb0VQgNyadNFPzQJG;
            this.__p_GeSvzyNtrqDO38sW7B5rGy = other.__p_GeSvzyNtrqDO38sW7B5rGy;
            this.__p_TEgC8tk127xMsv3oUb3FI7 = other.__p_TEgC8tk127xMsv3oUb3FI7;
            this.__cache_OAIUednlv7WM0ZoMJwBmJI = other.__cache_OAIUednlv7WM0ZoMJwBmJI;
            this.__loop_RPXMUg9SLP4NouBbro1pX4 = other.__loop_RPXMUg9SLP4NouBbro1pX4;
            this.__cp_LoUNZaOhG9MLlLX8tmao3U = other.__cp_LoUNZaOhG9MLlLX8tmao3U;
            this.__cp_D1mOpWyh7LgMv2ZjxP6rcB = other.__cp_D1mOpWyh7LgMv2ZjxP6rcB;
            this.__cp_SK2rb3atyxQQEgElmkXI3I = other.__cp_SK2rb3atyxQQEgElmkXI3I;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Filter_Exclude_Type", in Filter_Exclude_Type), n1.CompilationHelper.GetValueOrExisting(values, "Project_Loading", in Project_Loading), n1.CompilationHelper.GetValueOrExisting(values, "__p_M2sp5nggGBOLRZCsVLtnao", in __p_M2sp5nggGBOLRZCsVLtnao), n1.CompilationHelper.GetValueOrExisting(values, "__p_KbIoNW6BWkmPQFtYi001l6", in __p_KbIoNW6BWkmPQFtYi001l6), n1.CompilationHelper.GetValueOrExisting(values, "__p_JJ4Fsw7hjGbPy1sTqCrN0H", in __p_JJ4Fsw7hjGbPy1sTqCrN0H), n1.CompilationHelper.GetValueOrExisting(values, "__p_U1oCM7F1M5GO0XegwsNfdG", in __p_U1oCM7F1M5GO0XegwsNfdG), n1.CompilationHelper.GetValueOrExisting(values, "__p_LYyGoQ9MG0tOulyKDQkJKc", in __p_LYyGoQ9MG0tOulyKDQkJKc), n1.CompilationHelper.GetValueOrExisting(values, "__p_SRE0vzVcq49OEPXMLxF53c", in __p_SRE0vzVcq49OEPXMLxF53c), n1.CompilationHelper.GetValueOrExisting(values, "__p_TfDLLxjDjvgPMcLtq3huQc", in __p_TfDLLxjDjvgPMcLtq3huQc), n1.CompilationHelper.GetValueOrExisting(values, "__p_DJhopjb0VQgNyadNFPzQJG", in __p_DJhopjb0VQgNyadNFPzQJG), n1.CompilationHelper.GetValueOrExisting(values, "__p_GeSvzyNtrqDO38sW7B5rGy", in __p_GeSvzyNtrqDO38sW7B5rGy), n1.CompilationHelper.GetValueOrExisting(values, "__p_TEgC8tk127xMsv3oUb3FI7", in __p_TEgC8tk127xMsv3oUb3FI7), n1.CompilationHelper.GetValueOrExisting(values, "__cache_OAIUednlv7WM0ZoMJwBmJI", in __cache_OAIUednlv7WM0ZoMJwBmJI), n1.CompilationHelper.GetValueOrExisting(values, "__loop_RPXMUg9SLP4NouBbro1pX4", in __loop_RPXMUg9SLP4NouBbro1pX4), n1.CompilationHelper.GetValueOrExisting(values, "__cp_LoUNZaOhG9MLlLX8tmao3U", in __cp_LoUNZaOhG9MLlLX8tmao3U), n1.CompilationHelper.GetValueOrExisting(values, "__cp_D1mOpWyh7LgMv2ZjxP6rcB", in __cp_D1mOpWyh7LgMv2ZjxP6rcB), n1.CompilationHelper.GetValueOrExisting(values, "__cp_SK2rb3atyxQQEgElmkXI3I", in __cp_SK2rb3atyxQQEgElmkXI3I));
        }

        internal LoadProject_M7djlgidxbFQD0mWqmavrG __WITH__(n2.Type Filter_Exclude_Type, bool Project_Loading, n72.Changed_A8JGbead2bxNdnPybiEqVS<n5.Path> __p_M2sp5nggGBOLRZCsVLtnao, n8.Watcher __p_KbIoNW6BWkmPQFtYi001l6, n69.HoldLatest<n5.Path> __p_JJ4Fsw7hjGbPy1sTqCrN0H, n72.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_U1oCM7F1M5GO0XegwsNfdG, n72.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_LYyGoQ9MG0tOulyKDQkJKc, n75.Counter_UIay2coHW4dO2NuoNnTZ3G __p_SRE0vzVcq49OEPXMLxF53c, n14.ExistingProject_C __p_TfDLLxjDjvgPMcLtq3huQc, n69.AsyncTask<n21.Spread<n13.AssetItem>> __p_DJhopjb0VQgNyadNFPzQJG, n69.HoldLatest<n21.Spread<n13.AssetItem>> __p_GeSvzyNtrqDO38sW7B5rGy, n72.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_TEgC8tk127xMsv3oUb3FI7, n7.Manager<n2.ValueTuple, n2.ValueTuple<n21.Spread<n43.Reference_C<bool>>, n21.Spread<n2.IObservable<n2.Object>>, n21.Spread<string>>> __cache_OAIUednlv7WM0ZoMJwBmJI, n44.ImmutableLifetimeManager __loop_RPXMUg9SLP4NouBbro1pX4, n21.Spread<n2.Object> __cp_LoUNZaOhG9MLlLX8tmao3U, n21.Spread<bool> __cp_D1mOpWyh7LgMv2ZjxP6rcB, n21.Spread<bool> __cp_SK2rb3atyxQQEgElmkXI3I)
        {
            n3.LoadProject_M7djlgidxbFQD0mWqmavrG that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Filter_Exclude_Type != this.Filter_Exclude_Type || Project_Loading != this.Project_Loading || __p_M2sp5nggGBOLRZCsVLtnao != this.__p_M2sp5nggGBOLRZCsVLtnao || __p_KbIoNW6BWkmPQFtYi001l6 != this.__p_KbIoNW6BWkmPQFtYi001l6 || __p_JJ4Fsw7hjGbPy1sTqCrN0H != this.__p_JJ4Fsw7hjGbPy1sTqCrN0H || __p_U1oCM7F1M5GO0XegwsNfdG != this.__p_U1oCM7F1M5GO0XegwsNfdG || __p_LYyGoQ9MG0tOulyKDQkJKc != this.__p_LYyGoQ9MG0tOulyKDQkJKc || __p_SRE0vzVcq49OEPXMLxF53c != this.__p_SRE0vzVcq49OEPXMLxF53c || __p_TfDLLxjDjvgPMcLtq3huQc != this.__p_TfDLLxjDjvgPMcLtq3huQc || __p_DJhopjb0VQgNyadNFPzQJG != this.__p_DJhopjb0VQgNyadNFPzQJG || __p_GeSvzyNtrqDO38sW7B5rGy != this.__p_GeSvzyNtrqDO38sW7B5rGy || __p_TEgC8tk127xMsv3oUb3FI7 != this.__p_TEgC8tk127xMsv3oUb3FI7 || __cache_OAIUednlv7WM0ZoMJwBmJI != this.__cache_OAIUednlv7WM0ZoMJwBmJI || __loop_RPXMUg9SLP4NouBbro1pX4 != this.__loop_RPXMUg9SLP4NouBbro1pX4 || __cp_LoUNZaOhG9MLlLX8tmao3U != this.__cp_LoUNZaOhG9MLlLX8tmao3U || __cp_D1mOpWyh7LgMv2ZjxP6rcB != this.__cp_D1mOpWyh7LgMv2ZjxP6rcB || __cp_SK2rb3atyxQQEgElmkXI3I != this.__cp_SK2rb3atyxQQEgElmkXI3I ? new LoadProject_M7djlgidxbFQD0mWqmavrG(this)
                {Filter_Exclude_Type = Filter_Exclude_Type, Project_Loading = Project_Loading, __p_M2sp5nggGBOLRZCsVLtnao = __p_M2sp5nggGBOLRZCsVLtnao, __p_KbIoNW6BWkmPQFtYi001l6 = __p_KbIoNW6BWkmPQFtYi001l6, __p_JJ4Fsw7hjGbPy1sTqCrN0H = __p_JJ4Fsw7hjGbPy1sTqCrN0H, __p_U1oCM7F1M5GO0XegwsNfdG = __p_U1oCM7F1M5GO0XegwsNfdG, __p_LYyGoQ9MG0tOulyKDQkJKc = __p_LYyGoQ9MG0tOulyKDQkJKc, __p_SRE0vzVcq49OEPXMLxF53c = __p_SRE0vzVcq49OEPXMLxF53c, __p_TfDLLxjDjvgPMcLtq3huQc = __p_TfDLLxjDjvgPMcLtq3huQc, __p_DJhopjb0VQgNyadNFPzQJG = __p_DJhopjb0VQgNyadNFPzQJG, __p_GeSvzyNtrqDO38sW7B5rGy = __p_GeSvzyNtrqDO38sW7B5rGy, __p_TEgC8tk127xMsv3oUb3FI7 = __p_TEgC8tk127xMsv3oUb3FI7, __cache_OAIUednlv7WM0ZoMJwBmJI = __cache_OAIUednlv7WM0ZoMJwBmJI, __loop_RPXMUg9SLP4NouBbro1pX4 = __loop_RPXMUg9SLP4NouBbro1pX4, __cp_LoUNZaOhG9MLlLX8tmao3U = __cp_LoUNZaOhG9MLlLX8tmao3U, __cp_D1mOpWyh7LgMv2ZjxP6rcB = __cp_D1mOpWyh7LgMv2ZjxP6rcB, __cp_SK2rb3atyxQQEgElmkXI3I = __cp_SK2rb3atyxQQEgElmkXI3I} : that_1;
            else
            {
                this.Filter_Exclude_Type = Filter_Exclude_Type;
                this.Project_Loading = Project_Loading;
                this.__p_M2sp5nggGBOLRZCsVLtnao = __p_M2sp5nggGBOLRZCsVLtnao;
                this.__p_KbIoNW6BWkmPQFtYi001l6 = __p_KbIoNW6BWkmPQFtYi001l6;
                this.__p_JJ4Fsw7hjGbPy1sTqCrN0H = __p_JJ4Fsw7hjGbPy1sTqCrN0H;
                this.__p_U1oCM7F1M5GO0XegwsNfdG = __p_U1oCM7F1M5GO0XegwsNfdG;
                this.__p_LYyGoQ9MG0tOulyKDQkJKc = __p_LYyGoQ9MG0tOulyKDQkJKc;
                this.__p_SRE0vzVcq49OEPXMLxF53c = __p_SRE0vzVcq49OEPXMLxF53c;
                this.__p_TfDLLxjDjvgPMcLtq3huQc = __p_TfDLLxjDjvgPMcLtq3huQc;
                this.__p_DJhopjb0VQgNyadNFPzQJG = __p_DJhopjb0VQgNyadNFPzQJG;
                this.__p_GeSvzyNtrqDO38sW7B5rGy = __p_GeSvzyNtrqDO38sW7B5rGy;
                this.__p_TEgC8tk127xMsv3oUb3FI7 = __p_TEgC8tk127xMsv3oUb3FI7;
                this.__cache_OAIUednlv7WM0ZoMJwBmJI = __cache_OAIUednlv7WM0ZoMJwBmJI;
                this.__loop_RPXMUg9SLP4NouBbro1pX4 = __loop_RPXMUg9SLP4NouBbro1pX4;
                this.__cp_LoUNZaOhG9MLlLX8tmao3U = __cp_LoUNZaOhG9MLlLX8tmao3U;
                this.__cp_D1mOpWyh7LgMv2ZjxP6rcB = __cp_D1mOpWyh7LgMv2ZjxP6rcB;
                this.__cp_SK2rb3atyxQQEgElmkXI3I = __cp_SK2rb3atyxQQEgElmkXI3I;
            }

            return that_1;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "PKd0BDCRi26O2Rqh9lPuKv", Name = "__PKd0BDCRi26O2Rqh9lPuKv")]
        [n2.SerializableAttribute]
        public class __PKd0BDCRi26O2Rqh9lPuKv : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __PKd0BDCRi26O2Rqh9lPuKv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PKd0BDCRi26O2Rqh9lPuKv(__PKd0BDCRi26O2Rqh9lPuKv other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __PKd0BDCRi26O2Rqh9lPuKv __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Sk0ZbOM0n1yMegkDnicWys", Name = "__Sk0ZbOM0n1yMegkDnicWys")]
        [n2.SerializableAttribute]
        public class __Sk0ZbOM0n1yMegkDnicWys : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QydNeSf23zVNinleEqQNuK);
                n1.CompilationHelper.SafeDispose(this.__p_BdF4EPgTTKKOM2s3GwlqkZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 5181U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "QydNeSf23zVNinleEqQNuK", Name = "LoadProjectAssets", IsManaged = true, IsAutoGenerated = true)]
            public n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<n2.Object> __p_QydNeSf23zVNinleEqQNuK;
            [n1.ElementAttribute(TracingId = 5223U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "BdF4EPgTTKKOM2s3GwlqkZ", Name = "UnloadDeletedProjectAssets", IsManaged = true, IsAutoGenerated = true)]
            public n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM __p_BdF4EPgTTKKOM2s3GwlqkZ;
            [n1.ElementAttribute(TracingId = 5176U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "D8MdhB0OLbnNH7icgAzbQL", Name = "Urls")]
            public n21.Spread<string> Urls;
            public __Sk0ZbOM0n1yMegkDnicWys(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Sk0ZbOM0n1yMegkDnicWys(__Sk0ZbOM0n1yMegkDnicWys other): base(other)
            {
                this.__p_QydNeSf23zVNinleEqQNuK = other.__p_QydNeSf23zVNinleEqQNuK;
                this.__p_BdF4EPgTTKKOM2s3GwlqkZ = other.__p_BdF4EPgTTKKOM2s3GwlqkZ;
                this.Urls = other.Urls;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QydNeSf23zVNinleEqQNuK", in __p_QydNeSf23zVNinleEqQNuK), n1.CompilationHelper.GetValueOrExisting(values, "__p_BdF4EPgTTKKOM2s3GwlqkZ", in __p_BdF4EPgTTKKOM2s3GwlqkZ), n1.CompilationHelper.GetValueOrExisting(values, "Urls", in Urls));
            }

            internal __Sk0ZbOM0n1yMegkDnicWys __WITH__(n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<n2.Object> __p_QydNeSf23zVNinleEqQNuK, n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM __p_BdF4EPgTTKKOM2s3GwlqkZ, n21.Spread<string> Urls)
            {
                __Sk0ZbOM0n1yMegkDnicWys that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QydNeSf23zVNinleEqQNuK != this.__p_QydNeSf23zVNinleEqQNuK || __p_BdF4EPgTTKKOM2s3GwlqkZ != this.__p_BdF4EPgTTKKOM2s3GwlqkZ || Urls != this.Urls ? new __Sk0ZbOM0n1yMegkDnicWys(this)
                    {__p_QydNeSf23zVNinleEqQNuK = __p_QydNeSf23zVNinleEqQNuK, __p_BdF4EPgTTKKOM2s3GwlqkZ = __p_BdF4EPgTTKKOM2s3GwlqkZ, Urls = Urls} : that_0;
                else
                {
                    this.__p_QydNeSf23zVNinleEqQNuK = __p_QydNeSf23zVNinleEqQNuK;
                    this.__p_BdF4EPgTTKKOM2s3GwlqkZ = __p_BdF4EPgTTKKOM2s3GwlqkZ;
                    this.Urls = Urls;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SDGNN7AXSFmNtF6ByrSD9X", Name = "__SDGNN7AXSFmNtF6ByrSD9X")]
        [n2.SerializableAttribute]
        public class __SDGNN7AXSFmNtF6ByrSD9X : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VEnORJjJGRLMD3xU28kwED);
                return;
            }

            [n1.ElementAttribute(TracingId = 5252U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VEnORJjJGRLMD3xU28kwED", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
            public n69.HoldLatest<n2.Object> __p_VEnORJjJGRLMD3xU28kwED;
            public __SDGNN7AXSFmNtF6ByrSD9X(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SDGNN7AXSFmNtF6ByrSD9X(__SDGNN7AXSFmNtF6ByrSD9X other): base(other)
            {
                this.__p_VEnORJjJGRLMD3xU28kwED = other.__p_VEnORJjJGRLMD3xU28kwED;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VEnORJjJGRLMD3xU28kwED", in __p_VEnORJjJGRLMD3xU28kwED));
            }

            internal __SDGNN7AXSFmNtF6ByrSD9X __WITH__(n69.HoldLatest<n2.Object> __p_VEnORJjJGRLMD3xU28kwED)
            {
                __SDGNN7AXSFmNtF6ByrSD9X that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VEnORJjJGRLMD3xU28kwED != this.__p_VEnORJjJGRLMD3xU28kwED ? new __SDGNN7AXSFmNtF6ByrSD9X(this)
                    {__p_VEnORJjJGRLMD3xU28kwED = __p_VEnORJjJGRLMD3xU28kwED} : that_0;
                else
                {
                    this.__p_VEnORJjJGRLMD3xU28kwED = __p_VEnORJjJGRLMD3xU28kwED;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 5653U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AGzBVhNopB6LTM5HprvWlR", Name = "AssetScene_AGzBVhNopB6LTM5HprvWlR")]
    [n2.SerializableAttribute]
    public class AssetScene_AGzBVhNopB6LTM5HprvWlR : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AssetScene_AGzBVhNopB6LTM5HprvWlR Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetScene_AGzBVhNopB6LTM5HprvWlR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AssetScene_AGzBVhNopB6LTM5HprvWlR CreateDefault()
        {
            var instance = new AssetScene_AGzBVhNopB6LTM5HprvWlR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AssetScene_AGzBVhNopB6LTM5HprvWlR Update(string Scene_Url_In, bool Reload_In, out n20.Scene Output_Out, out bool Exists_Out)
        {
            bool __pad_J4V5oRHS0ZqLkJtwrxy1oW_0 = __slot_J4V5oRHS0ZqLkJtwrxy1oW;
            var Output_4 = this.__p_AFgdbuAFF5TLfg7Q45blJF.Update<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Url_In: Scene_Url_In, Reload_In: Reload_In, Asset_Out: out n20.Scene Asset_1, Exists_Out: out bool Exists_2, Loading_Out: out bool Loading_3);
            bool Force_5 = false;
            var manager_6 = this.__cache_OR4LzgEHAYvO61To8v12hV;
            if (manager_6 is null)
            {
                manager_6 = new n7.Manager<n2.ValueTuple<n20.Scene>, n2.ValueTuple<n78.SceneManager_C, n20.Scene>>((n78.SceneManager_C.CreateDefault(), default(n20.Scene)));
            }

            var inputs_7 = n2.ValueTuple.Create(Asset_1);
            var outputs_8 = manager_6.Outputs;
            var Has_Changed_9 = Force_5 || manager_6.InputsChanged(inputs_7);
            if (Has_Changed_9)
            {
                if (__pad_J4V5oRHS0ZqLkJtwrxy1oW_0)
                    manager_6.DisposeOutputs();
                n12.ObjectHelpers.IsAssigned(x: Asset_1, result: out bool Result_11, notAssigned: out bool Not_Assigned_12);
                n78.SceneManager_C __auto_13;
                n20.Scene __auto_14;
                if (Result_11)
                {
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "GAHXx7pIp5hMGkcKmbYGvB", 5699U);
                    var Output_18 = n78.SceneManager_C.Create(Node_Context: Node_Context_16, Scene_In: Asset_1, Scene_Out: out n20.Scene Scene_17);
                    __auto_13 = Output_18;
                    __auto_14 = Scene_17;
                }
                else
                {
                    __auto_13 = n78.SceneManager_C.CreateDefault();
                    __auto_14 = default(n20.Scene);
                }

                outputs_8 = (__auto_13, __auto_14);
                manager_6 = manager_6.Update(inputs_7, __GetContext__().IsImmutable, __pad_J4V5oRHS0ZqLkJtwrxy1oW_0, default, outputs_8);
            }
            else
            {
                manager_6.Update(inputs_7, __GetContext__().IsImmutable, __pad_J4V5oRHS0ZqLkJtwrxy1oW_0);
            }

            var(__auto_19, __auto_20) = outputs_8;
            Output_Out = __auto_20;
            Exists_Out = Exists_2;
            n3.AssetScene_AGzBVhNopB6LTM5HprvWlR that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = Output_4 != this.__p_AFgdbuAFF5TLfg7Q45blJF || manager_6 != this.__cache_OR4LzgEHAYvO61To8v12hV ? new AssetScene_AGzBVhNopB6LTM5HprvWlR(this)
                {__p_AFgdbuAFF5TLfg7Q45blJF = Output_4, __cache_OR4LzgEHAYvO61To8v12hV = manager_6} : that_21;
            else
            {
                this.__p_AFgdbuAFF5TLfg7Q45blJF = Output_4;
                this.__cache_OR4LzgEHAYvO61To8v12hV = manager_6;
            }

            return that_21;
        }

        public n3.AssetScene_AGzBVhNopB6LTM5HprvWlR __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "AFgdbuAFF5TLfg7Q45blJF", 5667U);
            var Output_1 = n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Scene>.Create(Node_Context: Node_Context_0);
            n3.AssetScene_AGzBVhNopB6LTM5HprvWlR that_2 = this;
            this.__p_AFgdbuAFF5TLfg7Q45blJF = Output_1;
            this.__cache_OR4LzgEHAYvO61To8v12hV = null;
            return that_2;
        }

        public n3.AssetScene_AGzBVhNopB6LTM5HprvWlR __CreateDefault__()
        {
            n3.AssetScene_AGzBVhNopB6LTM5HprvWlR that_0 = this;
            this.__p_AFgdbuAFF5TLfg7Q45blJF = n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Scene>.CreateDefault();
            this.__cache_OR4LzgEHAYvO61To8v12hV = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AFgdbuAFF5TLfg7Q45blJF);
            n1.CompilationHelper.SafeDispose(this.__cache_OR4LzgEHAYvO61To8v12hV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 5729U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "J4V5oRHS0ZqLkJtwrxy1oW", Name = "__slot_J4V5oRHS0ZqLkJtwrxy1oW")]
        public static bool __slot_J4V5oRHS0ZqLkJtwrxy1oW = true;
        [n1.ElementAttribute(TracingId = 5667U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AFgdbuAFF5TLfg7Q45blJF", Name = "Asset", IsManaged = true, IsAutoGenerated = true)]
        public n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Scene> __p_AFgdbuAFF5TLfg7Q45blJF;
        [n1.ElementAttribute(TracingId = 5681U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OR4LzgEHAYvO61To8v12hV", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n20.Scene>, n2.ValueTuple<n78.SceneManager_C, n20.Scene>> __cache_OR4LzgEHAYvO61To8v12hV = null;
        static AssetScene_AGzBVhNopB6LTM5HprvWlR()
        {
        }

        public AssetScene_AGzBVhNopB6LTM5HprvWlR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetScene_AGzBVhNopB6LTM5HprvWlR(AssetScene_AGzBVhNopB6LTM5HprvWlR other): base(other)
        {
            this.__p_AFgdbuAFF5TLfg7Q45blJF = other.__p_AFgdbuAFF5TLfg7Q45blJF;
            this.__cache_OR4LzgEHAYvO61To8v12hV = other.__cache_OR4LzgEHAYvO61To8v12hV;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AFgdbuAFF5TLfg7Q45blJF", in __p_AFgdbuAFF5TLfg7Q45blJF), n1.CompilationHelper.GetValueOrExisting(values, "__cache_OR4LzgEHAYvO61To8v12hV", in __cache_OR4LzgEHAYvO61To8v12hV));
        }

        internal AssetScene_AGzBVhNopB6LTM5HprvWlR __WITH__(n3.Asset_NgMUSSka40YMiqWx9s159z<n20.Scene> __p_AFgdbuAFF5TLfg7Q45blJF, n7.Manager<n2.ValueTuple<n20.Scene>, n2.ValueTuple<n78.SceneManager_C, n20.Scene>> __cache_OR4LzgEHAYvO61To8v12hV)
        {
            n3.AssetScene_AGzBVhNopB6LTM5HprvWlR that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AFgdbuAFF5TLfg7Q45blJF != this.__p_AFgdbuAFF5TLfg7Q45blJF || __cache_OR4LzgEHAYvO61To8v12hV != this.__cache_OR4LzgEHAYvO61To8v12hV ? new AssetScene_AGzBVhNopB6LTM5HprvWlR(this)
                {__p_AFgdbuAFF5TLfg7Q45blJF = __p_AFgdbuAFF5TLfg7Q45blJF, __cache_OR4LzgEHAYvO61To8v12hV = __cache_OR4LzgEHAYvO61To8v12hV} : that_0;
            else
            {
                this.__p_AFgdbuAFF5TLfg7Q45blJF = __p_AFgdbuAFF5TLfg7Q45blJF;
                this.__cache_OR4LzgEHAYvO61To8v12hV = __cache_OR4LzgEHAYvO61To8v12hV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 5793U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "PSPWnmek3XdOg3vx4c3MUM", Name = "AssetTexture_PSPWnmek3XdOg3vx4c3MUM")]
    [n2.SerializableAttribute]
    public class AssetTexture_PSPWnmek3XdOg3vx4c3MUM : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetTexture_PSPWnmek3XdOg3vx4c3MUM(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM CreateDefault()
        {
            var instance = new AssetTexture_PSPWnmek3XdOg3vx4c3MUM(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM Update(string Texture_Url_In, bool Reload_In, out n79.Texture Output_Out, out bool Exists_Out)
        {
            var Output_3 = this.__p_NpdmOFmTuxDOOZ76MplGXS.Update<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Url_In: Texture_Url_In, Reload_In: Reload_In, Asset_Out: out n79.Texture Asset_0, Exists_Out: out bool Exists_1, Loading_Out: out bool Loading_2);
            Output_Out = Asset_0;
            Exists_Out = Exists_1;
            n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = Output_3 != this.__p_NpdmOFmTuxDOOZ76MplGXS ? new AssetTexture_PSPWnmek3XdOg3vx4c3MUM(this)
                {__p_NpdmOFmTuxDOOZ76MplGXS = Output_3} : that_4;
            else
            {
                this.__p_NpdmOFmTuxDOOZ76MplGXS = Output_3;
            }

            return that_4;
        }

        public n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "NpdmOFmTuxDOOZ76MplGXS", 5803U);
            var Output_1 = n3.Asset_NgMUSSka40YMiqWx9s159z<n79.Texture>.Create(Node_Context: Node_Context_0);
            n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM that_2 = this;
            this.__p_NpdmOFmTuxDOOZ76MplGXS = Output_1;
            return that_2;
        }

        public n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM __CreateDefault__()
        {
            n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM that_0 = this;
            this.__p_NpdmOFmTuxDOOZ76MplGXS = n3.Asset_NgMUSSka40YMiqWx9s159z<n79.Texture>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NpdmOFmTuxDOOZ76MplGXS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 5803U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NpdmOFmTuxDOOZ76MplGXS", Name = "Asset", IsManaged = true, IsAutoGenerated = true)]
        public n3.Asset_NgMUSSka40YMiqWx9s159z<n79.Texture> __p_NpdmOFmTuxDOOZ76MplGXS;
        public AssetTexture_PSPWnmek3XdOg3vx4c3MUM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetTexture_PSPWnmek3XdOg3vx4c3MUM(AssetTexture_PSPWnmek3XdOg3vx4c3MUM other): base(other)
        {
            this.__p_NpdmOFmTuxDOOZ76MplGXS = other.__p_NpdmOFmTuxDOOZ76MplGXS;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NpdmOFmTuxDOOZ76MplGXS", in __p_NpdmOFmTuxDOOZ76MplGXS));
        }

        internal AssetTexture_PSPWnmek3XdOg3vx4c3MUM __WITH__(n3.Asset_NgMUSSka40YMiqWx9s159z<n79.Texture> __p_NpdmOFmTuxDOOZ76MplGXS)
        {
            n3.AssetTexture_PSPWnmek3XdOg3vx4c3MUM that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_NpdmOFmTuxDOOZ76MplGXS != this.__p_NpdmOFmTuxDOOZ76MplGXS ? new AssetTexture_PSPWnmek3XdOg3vx4c3MUM(this)
                {__p_NpdmOFmTuxDOOZ76MplGXS = __p_NpdmOFmTuxDOOZ76MplGXS} : that_0;
            else
            {
                this.__p_NpdmOFmTuxDOOZ76MplGXS = __p_NpdmOFmTuxDOOZ76MplGXS;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 13628U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VHk2U8mzzVePYWKVz5dr4z", Name = "FileTexture_VHk2U8mzzVePYWKVz5dr4z")]
    [n2.SerializableAttribute]
    public class FileTexture_VHk2U8mzzVePYWKVz5dr4z : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z Create(n1.NodeContext Node_Context)
        {
            var instance = new FileTexture_VHk2U8mzzVePYWKVz5dr4z(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z CreateDefault()
        {
            var instance = new FileTexture_VHk2U8mzzVePYWKVz5dr4z(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z Update(n5.Path Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Generate_Mipmaps_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Premultiply_Alpha_In, bool Compress_In, [n4.SerializedDefaultValueAttribute("Auto", false)] n47.AlphaFormat Alpha_Format_In, bool Reload_In, out n79.Texture Texture_Out, out bool Is_Loading_Out, out bool Already_Loaded_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_GCecB09Ckh1POQDkKRmC9o;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool, bool, n47.AlphaFormat>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>>((default(n6.AssetWrapper<n79.Texture>), false));
            }

            var inputs_2 = (Path_In, Generate_Mipmaps_In, Is_sRGB_In, Premultiply_Alpha_In, Compress_In, Alpha_Format_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Reload_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__KC5pjaSks4LPE5KORZCVRP>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __KC5pjaSks4LPE5KORZCVRP(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "H2zYPeO0KUANhPsVErqbPs", 13674U);
                    var Output_7 = n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS.Create(Node_Context: Node_Context_6);
                    state_5.__p_H2zYPeO0KUANhPsVErqbPs = Output_7;
                }

                n74._Operations_.FileExists(Input_In: Path_In, Exists_Out: out bool Exists_8);
                var Output_9 = new n2.ValueTuple<n5.Path, bool, bool, bool, bool, n47.AlphaFormat>(item1: Path_In, item2: Generate_Mipmaps_In, item3: Is_sRGB_In, item4: Premultiply_Alpha_In, item5: Compress_In, item6: Alpha_Format_In);
                n14._Operations_.GetUniqueAssetURL(Input_In: Path_In, Hash_Object_In: Output_9, Output_Out: out string Output_10, Directory_Out: out string Directory_11, Name_Out: out string Name_12);
                var __fallback___13 = n1.ServiceRegistry.Current;
                var Output_24 = state_5.__p_H2zYPeO0KUANhPsVErqbPs.Update<n47.TextureAsset, n79.Texture, n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Build_In: Exists_8, Reload_In: Reload_In, Url_In: Output_10, Source_Folder_In: Directory_11, Name_In: Name_12, Create_Asset_In: (n13.Package Arg_In_15) =>
                {
                    using var __current_14 = __fallback___13.MakeCurrentIfNone();
                    bool Color_Key_Enabled_16 = false;
                    n53.Color4 Color_Key_Color_17 = __c_VL4PxCn5dblQblbBJOgPTJ;
                    n14._Operations_.CreateColorTextureType(Is_sRGB_In: Is_sRGB_In, Premultiply_Alpha_In: Premultiply_Alpha_In, Alpha_Format_In: Alpha_Format_In, Color_Key_Enabled_In: Color_Key_Enabled_16, Color_Key_Color_In: Color_Key_Color_17, Output_Out: out n47.ColorTextureType Output_18);
                    n47.ITextureType Type_19 = (n47.ITextureType)Output_18;
                    bool Is_Streamable_20 = false;
                    n14._Operations_.TextureAssetFromFile(Filename_In: Path_In, Generate_Mipmaps_In: Generate_Mipmaps_In, Is_Compressed_In: Compress_In, Is_Streamable_In: Is_Streamable_20, Url_In: Output_10, Type_In: Type_19, Asset_Out: out n47.TextureAsset Asset_21);
                    return Asset_21;
                }

                , Wrapper_Out: out n6.AssetWrapper<n79.Texture> Wrapper_22, Already_Loaded_Out: out bool Already_Loaded_23);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_24 != state_5.__p_H2zYPeO0KUANhPsVErqbPs ? new __KC5pjaSks4LPE5KORZCVRP(state_5)
                    {__p_H2zYPeO0KUANhPsVErqbPs = Output_24} : state_5;
                else
                {
                    state_5.__p_H2zYPeO0KUANhPsVErqbPs = Output_24;
                }

                outputs_3 = (Wrapper_22, Already_Loaded_23);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var(__auto_25, __auto_26) = outputs_3;
            __auto_25.GetValues(asset: out n79.Texture Asset_27, exists: out bool Exists_28, loading: out bool Loading_29);
            Texture_Out = Asset_27;
            Is_Loading_Out = Loading_29;
            Already_Loaded_Out = __auto_26;
            n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_1 != this.__cache_GCecB09Ckh1POQDkKRmC9o ? new FileTexture_VHk2U8mzzVePYWKVz5dr4z(this)
                {__cache_GCecB09Ckh1POQDkKRmC9o = manager_1} : that_30;
            else
            {
                this.__cache_GCecB09Ckh1POQDkKRmC9o = manager_1;
            }

            return that_30;
        }

        public n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z that_0 = this;
            this.__cache_GCecB09Ckh1POQDkKRmC9o = null;
            return that_0;
        }

        public n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z __CreateDefault__()
        {
            n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z that_0 = this;
            this.__cache_GCecB09Ckh1POQDkKRmC9o = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GCecB09Ckh1POQDkKRmC9o);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 13635U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "GCecB09Ckh1POQDkKRmC9o", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool, bool, n47.AlphaFormat>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_GCecB09Ckh1POQDkKRmC9o = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n53.Color4 __c_VL4PxCn5dblQblbBJOgPTJ = n1.CompilationHelper.Deserialize<n53.Color4>("0, 0, 0, 1", false, "OpwXTKxodpcLMuzoaGSQfF", "VL4PxCn5dblQblbBJOgPTJ");
        static FileTexture_VHk2U8mzzVePYWKVz5dr4z()
        {
        }

        public FileTexture_VHk2U8mzzVePYWKVz5dr4z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileTexture_VHk2U8mzzVePYWKVz5dr4z(FileTexture_VHk2U8mzzVePYWKVz5dr4z other): base(other)
        {
            this.__cache_GCecB09Ckh1POQDkKRmC9o = other.__cache_GCecB09Ckh1POQDkKRmC9o;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GCecB09Ckh1POQDkKRmC9o", in __cache_GCecB09Ckh1POQDkKRmC9o));
        }

        internal FileTexture_VHk2U8mzzVePYWKVz5dr4z __WITH__(n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool, bool, n47.AlphaFormat>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_GCecB09Ckh1POQDkKRmC9o)
        {
            n3.FileTexture_VHk2U8mzzVePYWKVz5dr4z that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GCecB09Ckh1POQDkKRmC9o != this.__cache_GCecB09Ckh1POQDkKRmC9o ? new FileTexture_VHk2U8mzzVePYWKVz5dr4z(this)
                {__cache_GCecB09Ckh1POQDkKRmC9o = __cache_GCecB09Ckh1POQDkKRmC9o} : that_0;
            else
            {
                this.__cache_GCecB09Ckh1POQDkKRmC9o = __cache_GCecB09Ckh1POQDkKRmC9o;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "KC5pjaSks4LPE5KORZCVRP", Name = "__KC5pjaSks4LPE5KORZCVRP")]
        [n2.SerializableAttribute]
        public class __KC5pjaSks4LPE5KORZCVRP : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_H2zYPeO0KUANhPsVErqbPs);
                return;
            }

            [n1.ElementAttribute(TracingId = 13674U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "H2zYPeO0KUANhPsVErqbPs", Name = "RuntimeAsset", IsManaged = true, IsAutoGenerated = true)]
            public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_H2zYPeO0KUANhPsVErqbPs;
            public __KC5pjaSks4LPE5KORZCVRP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KC5pjaSks4LPE5KORZCVRP(__KC5pjaSks4LPE5KORZCVRP other): base(other)
            {
                this.__p_H2zYPeO0KUANhPsVErqbPs = other.__p_H2zYPeO0KUANhPsVErqbPs;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H2zYPeO0KUANhPsVErqbPs", in __p_H2zYPeO0KUANhPsVErqbPs));
            }

            internal __KC5pjaSks4LPE5KORZCVRP __WITH__(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_H2zYPeO0KUANhPsVErqbPs)
            {
                __KC5pjaSks4LPE5KORZCVRP that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_H2zYPeO0KUANhPsVErqbPs != this.__p_H2zYPeO0KUANhPsVErqbPs ? new __KC5pjaSks4LPE5KORZCVRP(this)
                    {__p_H2zYPeO0KUANhPsVErqbPs = __p_H2zYPeO0KUANhPsVErqbPs} : that_0;
                else
                {
                    this.__p_H2zYPeO0KUANhPsVErqbPs = __p_H2zYPeO0KUANhPsVErqbPs;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 14083U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Rvc213620VPN5DkPWF6ncI", Name = "FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI")]
    [n2.SerializableAttribute]
    public class FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI Create(n1.NodeContext Node_Context)
        {
            var instance = new FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI CreateDefault()
        {
            var instance = new FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI Update(n5.Path Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Generate_Mipmaps_In, bool Compress_In, bool Reload_In, out n79.Texture Texture_Out, out bool Is_Loading_Out, out bool Already_Loaded_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_SttTrd0bLpnP6PY12mM6te;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<n5.Path, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>>((default(n6.AssetWrapper<n79.Texture>), false));
            }

            var inputs_2 = (Path_In, Generate_Mipmaps_In, Compress_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Reload_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__HeQ48bGU4EKQLUl1dW1LVf>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __HeQ48bGU4EKQLUl1dW1LVf(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "ViS9dPCXE5oNxCDNZd7E7x", 14136U);
                    var Output_7 = n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS.Create(Node_Context: Node_Context_6);
                    state_5.__p_ViS9dPCXE5oNxCDNZd7E7x = Output_7;
                }

                n74._Operations_.FileExists(Input_In: Path_In, Exists_Out: out bool Exists_8);
                var Output_9 = new n2.ValueTuple<bool, bool>(item1: Generate_Mipmaps_In, item2: Compress_In);
                n14._Operations_.GetUniqueAssetURL(Input_In: Path_In, Hash_Object_In: Output_9, Output_Out: out string Output_10, Directory_Out: out string Directory_11, Name_Out: out string Name_12);
                var __fallback___13 = n1.ServiceRegistry.Current;
                var Output_22 = state_5.__p_ViS9dPCXE5oNxCDNZd7E7x.Update<n47.TextureAsset, n79.Texture, n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Build_In: Exists_8, Reload_In: Reload_In, Url_In: Output_10, Source_Folder_In: Directory_11, Name_In: Name_12, Create_Asset_In: (n13.Package Arg_In_15) =>
                {
                    using var __current_14 = __fallback___13.MakeCurrentIfNone();
                    var Output_16 = new n47.GrayscaleTextureType();
                    n47.ITextureType Type_17 = (n47.ITextureType)Output_16;
                    bool Is_Streamable_18 = false;
                    n14._Operations_.TextureAssetFromFile(Filename_In: Path_In, Generate_Mipmaps_In: Generate_Mipmaps_In, Is_Compressed_In: Compress_In, Is_Streamable_In: Is_Streamable_18, Url_In: Output_10, Type_In: Type_17, Asset_Out: out n47.TextureAsset Asset_19);
                    return Asset_19;
                }

                , Wrapper_Out: out n6.AssetWrapper<n79.Texture> Wrapper_20, Already_Loaded_Out: out bool Already_Loaded_21);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_22 != state_5.__p_ViS9dPCXE5oNxCDNZd7E7x ? new __HeQ48bGU4EKQLUl1dW1LVf(state_5)
                    {__p_ViS9dPCXE5oNxCDNZd7E7x = Output_22} : state_5;
                else
                {
                    state_5.__p_ViS9dPCXE5oNxCDNZd7E7x = Output_22;
                }

                outputs_3 = (Wrapper_20, Already_Loaded_21);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var(__auto_23, __auto_24) = outputs_3;
            __auto_23.GetValues(asset: out n79.Texture Asset_25, exists: out bool Exists_26, loading: out bool Loading_27);
            Texture_Out = Asset_25;
            Is_Loading_Out = Loading_27;
            Already_Loaded_Out = __auto_24;
            n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI that_28 = this;
            if (this.__GetContext__().IsImmutable)
                that_28 = manager_1 != this.__cache_SttTrd0bLpnP6PY12mM6te ? new FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(this)
                {__cache_SttTrd0bLpnP6PY12mM6te = manager_1} : that_28;
            else
            {
                this.__cache_SttTrd0bLpnP6PY12mM6te = manager_1;
            }

            return that_28;
        }

        public n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI that_0 = this;
            this.__cache_SttTrd0bLpnP6PY12mM6te = null;
            return that_0;
        }

        public n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI __CreateDefault__()
        {
            n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI that_0 = this;
            this.__cache_SttTrd0bLpnP6PY12mM6te = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SttTrd0bLpnP6PY12mM6te);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 14093U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SttTrd0bLpnP6PY12mM6te", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_SttTrd0bLpnP6PY12mM6te = null;
        public FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI other): base(other)
        {
            this.__cache_SttTrd0bLpnP6PY12mM6te = other.__cache_SttTrd0bLpnP6PY12mM6te;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SttTrd0bLpnP6PY12mM6te", in __cache_SttTrd0bLpnP6PY12mM6te));
        }

        internal FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI __WITH__(n7.Manager<n2.ValueTuple<n5.Path, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_SttTrd0bLpnP6PY12mM6te)
        {
            n3.FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SttTrd0bLpnP6PY12mM6te != this.__cache_SttTrd0bLpnP6PY12mM6te ? new FileTextureGrayscale_Rvc213620VPN5DkPWF6ncI(this)
                {__cache_SttTrd0bLpnP6PY12mM6te = __cache_SttTrd0bLpnP6PY12mM6te} : that_0;
            else
            {
                this.__cache_SttTrd0bLpnP6PY12mM6te = __cache_SttTrd0bLpnP6PY12mM6te;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "HeQ48bGU4EKQLUl1dW1LVf", Name = "__HeQ48bGU4EKQLUl1dW1LVf")]
        [n2.SerializableAttribute]
        public class __HeQ48bGU4EKQLUl1dW1LVf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_ViS9dPCXE5oNxCDNZd7E7x);
                return;
            }

            [n1.ElementAttribute(TracingId = 14136U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "ViS9dPCXE5oNxCDNZd7E7x", Name = "RuntimeAsset", IsManaged = true, IsAutoGenerated = true)]
            public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_ViS9dPCXE5oNxCDNZd7E7x;
            public __HeQ48bGU4EKQLUl1dW1LVf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HeQ48bGU4EKQLUl1dW1LVf(__HeQ48bGU4EKQLUl1dW1LVf other): base(other)
            {
                this.__p_ViS9dPCXE5oNxCDNZd7E7x = other.__p_ViS9dPCXE5oNxCDNZd7E7x;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ViS9dPCXE5oNxCDNZd7E7x", in __p_ViS9dPCXE5oNxCDNZd7E7x));
            }

            internal __HeQ48bGU4EKQLUl1dW1LVf __WITH__(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_ViS9dPCXE5oNxCDNZd7E7x)
            {
                __HeQ48bGU4EKQLUl1dW1LVf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_ViS9dPCXE5oNxCDNZd7E7x != this.__p_ViS9dPCXE5oNxCDNZd7E7x ? new __HeQ48bGU4EKQLUl1dW1LVf(this)
                    {__p_ViS9dPCXE5oNxCDNZd7E7x = __p_ViS9dPCXE5oNxCDNZd7E7x} : that_0;
                else
                {
                    this.__p_ViS9dPCXE5oNxCDNZd7E7x = __p_ViS9dPCXE5oNxCDNZd7E7x;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 14432U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Dtkq2d2dsNZLhMxWhzzUjh", Name = "FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh")]
    [n2.SerializableAttribute]
    public class FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh Create(n1.NodeContext Node_Context)
        {
            var instance = new FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh CreateDefault()
        {
            var instance = new FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh Update(n5.Path Path_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Generate_Mipmaps_In, bool Invert_Y_In, bool Compress_In, bool Reload_In, out n79.Texture Texture_Out, out bool Is_Loading_Out, out bool Already_Loaded_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_NTmqgosLR0ELCvd7XHq4AJ;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>>((default(n6.AssetWrapper<n79.Texture>), false));
            }

            var inputs_2 = (Path_In, Generate_Mipmaps_In, Invert_Y_In, Compress_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Reload_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__Rjlh4EY5EOZPH216jGEZ2T>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __Rjlh4EY5EOZPH216jGEZ2T(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "OOXzU5Md12rPG68z0xTGeV", 14476U);
                    var Output_7 = n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS.Create(Node_Context: Node_Context_6);
                    state_5.__p_OOXzU5Md12rPG68z0xTGeV = Output_7;
                }

                n74._Operations_.FileExists(Input_In: Path_In, Exists_Out: out bool Exists_8);
                var Output_9 = new n2.ValueTuple<bool, bool, bool>(item1: Generate_Mipmaps_In, item2: Invert_Y_In, item3: Compress_In);
                n14._Operations_.GetUniqueAssetURL(Input_In: Path_In, Hash_Object_In: Output_9, Output_Out: out string Output_10, Directory_Out: out string Directory_11, Name_Out: out string Name_12);
                var __fallback___13 = n1.ServiceRegistry.Current;
                var Output_22 = state_5.__p_OOXzU5Md12rPG68z0xTGeV.Update<n47.TextureAsset, n79.Texture, n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Build_In: Exists_8, Reload_In: Reload_In, Url_In: Output_10, Source_Folder_In: Directory_11, Name_In: Name_12, Create_Asset_In: (n13.Package Arg_In_15) =>
                {
                    using var __current_14 = __fallback___13.MakeCurrentIfNone();
                    n14._Operations_.CreateNormalMapTextureType(Invert_Y_In: Invert_Y_In, Output_Out: out n47.NormapMapTextureType Output_16);
                    n47.ITextureType Type_17 = (n47.ITextureType)Output_16;
                    bool Is_Streamable_18 = false;
                    n14._Operations_.TextureAssetFromFile(Filename_In: Path_In, Generate_Mipmaps_In: Generate_Mipmaps_In, Is_Compressed_In: Compress_In, Is_Streamable_In: Is_Streamable_18, Url_In: Output_10, Type_In: Type_17, Asset_Out: out n47.TextureAsset Asset_19);
                    return Asset_19;
                }

                , Wrapper_Out: out n6.AssetWrapper<n79.Texture> Wrapper_20, Already_Loaded_Out: out bool Already_Loaded_21);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_22 != state_5.__p_OOXzU5Md12rPG68z0xTGeV ? new __Rjlh4EY5EOZPH216jGEZ2T(state_5)
                    {__p_OOXzU5Md12rPG68z0xTGeV = Output_22} : state_5;
                else
                {
                    state_5.__p_OOXzU5Md12rPG68z0xTGeV = Output_22;
                }

                outputs_3 = (Wrapper_20, Already_Loaded_21);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var(__auto_23, __auto_24) = outputs_3;
            __auto_23.GetValues(asset: out n79.Texture Asset_25, exists: out bool Exists_26, loading: out bool Loading_27);
            Texture_Out = Asset_25;
            Is_Loading_Out = Loading_27;
            Already_Loaded_Out = __auto_24;
            n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh that_28 = this;
            if (this.__GetContext__().IsImmutable)
                that_28 = manager_1 != this.__cache_NTmqgosLR0ELCvd7XHq4AJ ? new FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(this)
                {__cache_NTmqgosLR0ELCvd7XHq4AJ = manager_1} : that_28;
            else
            {
                this.__cache_NTmqgosLR0ELCvd7XHq4AJ = manager_1;
            }

            return that_28;
        }

        public n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh that_0 = this;
            this.__cache_NTmqgosLR0ELCvd7XHq4AJ = null;
            return that_0;
        }

        public n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh __CreateDefault__()
        {
            n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh that_0 = this;
            this.__cache_NTmqgosLR0ELCvd7XHq4AJ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NTmqgosLR0ELCvd7XHq4AJ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 14441U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NTmqgosLR0ELCvd7XHq4AJ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_NTmqgosLR0ELCvd7XHq4AJ = null;
        public FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh other): base(other)
        {
            this.__cache_NTmqgosLR0ELCvd7XHq4AJ = other.__cache_NTmqgosLR0ELCvd7XHq4AJ;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NTmqgosLR0ELCvd7XHq4AJ", in __cache_NTmqgosLR0ELCvd7XHq4AJ));
        }

        internal FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh __WITH__(n7.Manager<n2.ValueTuple<n5.Path, bool, bool, bool>, n2.ValueTuple<n6.AssetWrapper<n79.Texture>, bool>> __cache_NTmqgosLR0ELCvd7XHq4AJ)
        {
            n3.FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NTmqgosLR0ELCvd7XHq4AJ != this.__cache_NTmqgosLR0ELCvd7XHq4AJ ? new FileTextureNormalMap_Dtkq2d2dsNZLhMxWhzzUjh(this)
                {__cache_NTmqgosLR0ELCvd7XHq4AJ = __cache_NTmqgosLR0ELCvd7XHq4AJ} : that_0;
            else
            {
                this.__cache_NTmqgosLR0ELCvd7XHq4AJ = __cache_NTmqgosLR0ELCvd7XHq4AJ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Rjlh4EY5EOZPH216jGEZ2T", Name = "__Rjlh4EY5EOZPH216jGEZ2T")]
        [n2.SerializableAttribute]
        public class __Rjlh4EY5EOZPH216jGEZ2T : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OOXzU5Md12rPG68z0xTGeV);
                return;
            }

            [n1.ElementAttribute(TracingId = 14476U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OOXzU5Md12rPG68z0xTGeV", Name = "RuntimeAsset", IsManaged = true, IsAutoGenerated = true)]
            public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_OOXzU5Md12rPG68z0xTGeV;
            public __Rjlh4EY5EOZPH216jGEZ2T(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Rjlh4EY5EOZPH216jGEZ2T(__Rjlh4EY5EOZPH216jGEZ2T other): base(other)
            {
                this.__p_OOXzU5Md12rPG68z0xTGeV = other.__p_OOXzU5Md12rPG68z0xTGeV;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OOXzU5Md12rPG68z0xTGeV", in __p_OOXzU5Md12rPG68z0xTGeV));
            }

            internal __Rjlh4EY5EOZPH216jGEZ2T __WITH__(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_OOXzU5Md12rPG68z0xTGeV)
            {
                __Rjlh4EY5EOZPH216jGEZ2T that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OOXzU5Md12rPG68z0xTGeV != this.__p_OOXzU5Md12rPG68z0xTGeV ? new __Rjlh4EY5EOZPH216jGEZ2T(this)
                    {__p_OOXzU5Md12rPG68z0xTGeV = __p_OOXzU5Md12rPG68z0xTGeV} : that_0;
                else
                {
                    this.__p_OOXzU5Md12rPG68z0xTGeV = __p_OOXzU5Md12rPG68z0xTGeV;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 14793U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Q662A7DGcNSMVAXgG6NNYJ", Name = "FileModel_Q662A7DGcNSMVAXgG6NNYJ")]
    [n2.SerializableAttribute]
    public class FileModel_Q662A7DGcNSMVAXgG6NNYJ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ Create(n1.NodeContext Node_Context)
        {
            var instance = new FileModel_Q662A7DGcNSMVAXgG6NNYJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ CreateDefault()
        {
            var instance = new FileModel_Q662A7DGcNSMVAXgG6NNYJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ Update(n5.Path Path_In, [n4.SerializedDefaultValueAttribute("1", false)] float Import_Scale_In, n53.Vector3 Pivot_Position_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Merge_Meshes_In, bool Reload_In, out n18.Model Model_Out, out bool Is_Loading_Out, out bool Already_Loaded_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<n5.Path, float, n53.Vector3, bool>, n2.ValueTuple<n6.AssetWrapper<n18.Model>, bool>>((default(n6.AssetWrapper<n18.Model>), false));
            }

            var inputs_2 = (Path_In, Import_Scale_In, Pivot_Position_In, Merge_Meshes_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Reload_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__SwaQS64ytilMPJ7z3cUDCf>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __SwaQS64ytilMPJ7z3cUDCf(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "AkoYcqVqAOoMUXDfqOd485", 14851U);
                    var Output_7 = n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS.Create(Node_Context: Node_Context_6);
                    state_5.__p_AkoYcqVqAOoMUXDfqOd485 = Output_7;
                }

                n74._Operations_.FileExists(Input_In: Path_In, Exists_Out: out bool Exists_8);
                var Output_9 = new n2.ValueTuple<float, n53.Vector3, bool>(item1: Import_Scale_In, item2: Pivot_Position_In, item3: Merge_Meshes_In);
                n14._Operations_.GetUniqueAssetURL(Input_In: Path_In, Hash_Object_In: Output_9, Output_Out: out string Output_10, Directory_Out: out string Directory_11, Name_Out: out string Name_12);
                var __fallback___13 = n1.ServiceRegistry.Current;
                var Output_19 = state_5.__p_AkoYcqVqAOoMUXDfqOd485.Update<n52.ModelAsset, n18.Model, n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Build_In: Exists_8, Reload_In: Reload_In, Url_In: Output_10, Source_Folder_In: Directory_11, Name_In: Name_12, Create_Asset_In: (n13.Package Arg_In_15) =>
                {
                    using var __current_14 = __fallback___13.MakeCurrentIfNone();
                    n14._Operations_.ModelAssetFromFile(Filename_In: Path_In, Inport_Scale_In: Import_Scale_In, Pivot_Position_In: Pivot_Position_In, Url_In: Output_10, Merge_Meshes_In: Merge_Meshes_In, Model_Asset_Out: out n52.ModelAsset Model_Asset_16);
                    return Model_Asset_16;
                }

                , Wrapper_Out: out n6.AssetWrapper<n18.Model> Wrapper_17, Already_Loaded_Out: out bool Already_Loaded_18);
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_19 != state_5.__p_AkoYcqVqAOoMUXDfqOd485 ? new __SwaQS64ytilMPJ7z3cUDCf(state_5)
                    {__p_AkoYcqVqAOoMUXDfqOd485 = Output_19} : state_5;
                else
                {
                    state_5.__p_AkoYcqVqAOoMUXDfqOd485 = Output_19;
                }

                outputs_3 = (Wrapper_17, Already_Loaded_18);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var(__auto_20, __auto_21) = outputs_3;
            __auto_20.GetValues(asset: out n18.Model Asset_22, exists: out bool Exists_23, loading: out bool Loading_24);
            Model_Out = Asset_22;
            Is_Loading_Out = Loading_24;
            Already_Loaded_Out = __auto_21;
            n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_1 != this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS ? new FileModel_Q662A7DGcNSMVAXgG6NNYJ(this)
                {__cache_RCc0jJQ6Ly0LZxn4sDBzbS = manager_1} : that_25;
            else
            {
                this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS = manager_1;
            }

            return that_25;
        }

        public n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ that_0 = this;
            this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS = null;
            return that_0;
        }

        public n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ __CreateDefault__()
        {
            n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ that_0 = this;
            this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 14802U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "RCc0jJQ6Ly0LZxn4sDBzbS", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path, float, n53.Vector3, bool>, n2.ValueTuple<n6.AssetWrapper<n18.Model>, bool>> __cache_RCc0jJQ6Ly0LZxn4sDBzbS = null;
        public FileModel_Q662A7DGcNSMVAXgG6NNYJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileModel_Q662A7DGcNSMVAXgG6NNYJ(FileModel_Q662A7DGcNSMVAXgG6NNYJ other): base(other)
        {
            this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS = other.__cache_RCc0jJQ6Ly0LZxn4sDBzbS;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RCc0jJQ6Ly0LZxn4sDBzbS", in __cache_RCc0jJQ6Ly0LZxn4sDBzbS));
        }

        internal FileModel_Q662A7DGcNSMVAXgG6NNYJ __WITH__(n7.Manager<n2.ValueTuple<n5.Path, float, n53.Vector3, bool>, n2.ValueTuple<n6.AssetWrapper<n18.Model>, bool>> __cache_RCc0jJQ6Ly0LZxn4sDBzbS)
        {
            n3.FileModel_Q662A7DGcNSMVAXgG6NNYJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RCc0jJQ6Ly0LZxn4sDBzbS != this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS ? new FileModel_Q662A7DGcNSMVAXgG6NNYJ(this)
                {__cache_RCc0jJQ6Ly0LZxn4sDBzbS = __cache_RCc0jJQ6Ly0LZxn4sDBzbS} : that_0;
            else
            {
                this.__cache_RCc0jJQ6Ly0LZxn4sDBzbS = __cache_RCc0jJQ6Ly0LZxn4sDBzbS;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SwaQS64ytilMPJ7z3cUDCf", Name = "__SwaQS64ytilMPJ7z3cUDCf")]
        [n2.SerializableAttribute]
        public class __SwaQS64ytilMPJ7z3cUDCf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AkoYcqVqAOoMUXDfqOd485);
                return;
            }

            [n1.ElementAttribute(TracingId = 14851U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AkoYcqVqAOoMUXDfqOd485", Name = "RuntimeAsset", IsManaged = true, IsAutoGenerated = true)]
            public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_AkoYcqVqAOoMUXDfqOd485;
            public __SwaQS64ytilMPJ7z3cUDCf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SwaQS64ytilMPJ7z3cUDCf(__SwaQS64ytilMPJ7z3cUDCf other): base(other)
            {
                this.__p_AkoYcqVqAOoMUXDfqOd485 = other.__p_AkoYcqVqAOoMUXDfqOd485;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AkoYcqVqAOoMUXDfqOd485", in __p_AkoYcqVqAOoMUXDfqOd485));
            }

            internal __SwaQS64ytilMPJ7z3cUDCf __WITH__(n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __p_AkoYcqVqAOoMUXDfqOd485)
            {
                __SwaQS64ytilMPJ7z3cUDCf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AkoYcqVqAOoMUXDfqOd485 != this.__p_AkoYcqVqAOoMUXDfqOd485 ? new __SwaQS64ytilMPJ7z3cUDCf(this)
                    {__p_AkoYcqVqAOoMUXDfqOd485 = __p_AkoYcqVqAOoMUXDfqOd485} : that_0;
                else
                {
                    this.__p_AkoYcqVqAOoMUXDfqOd485 = __p_AkoYcqVqAOoMUXDfqOd485;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 15153U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NgMUSSka40YMiqWx9s159z", Name = "Asset_NgMUSSka40YMiqWx9s159z")]
    [n2.SerializableAttribute]
    public class Asset_NgMUSSka40YMiqWx9s159z<T> : n1.VLObject, n2.IDisposable where T : class
    {
        [n4.CreateNewAttribute]
        public static n3.Asset_NgMUSSka40YMiqWx9s159z<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Asset_NgMUSSka40YMiqWx9s159z<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Asset_NgMUSSka40YMiqWx9s159z<T> CreateDefault()
        {
            var instance = new Asset_NgMUSSka40YMiqWx9s159z<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Asset_NgMUSSka40YMiqWx9s159z<T> Update<AdM>(string Url_In, bool Reload_In, out T Asset_Out, out bool Exists_Out, out bool Loading_Out)
            where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n6.AssetWrapper<T> __auto_1 = this.Current_Value;
            n14.AssetBuilderService_C __auto_2 = this.Builder;
            n6.AssetWrapper<T> __auto_3 = this.Game_Value;
            n56.ContentManager __auto_4 = this.Game_Content;
            var Output_7 = this.__p_IUkyvyg3nUNPzXz6dy2veV.Update(Value_In: Url_In, Result_Out: out bool Result_5, Unchanged_Out: out bool Unchanged_6);
            var Output_8 = Reload_In || Result_5;
            n6.AssetWrapper<T> __auto_9;
            if (Output_8)
            {
                n14._Operations_.TryLoadExisting<T, AdM>(Input_In: __auto_2, Url_In: Url_In, Reload_In: Reload_In, Result_Out: out n6.AssetWrapper<T> Result_11, Loaded_Out: out bool Loaded_12);
                n80._Operations_.TryLoadFromGame<T>(Game_Content_In: __auto_4, Input_In: Result_11, Url_In: Url_In, Game_Value_In: __auto_3, Output_Out: out n6.AssetWrapper<T> Output_13);
                __auto_9 = Output_13;
            }
            else
            {
                __auto_9 = __auto_1;
            }

            n6.AssetWrapper<T> __auto_14 = __auto_9;
            string __auto_15 = Url_In;
            __auto_14.GetValues(asset: out T Asset_16, exists: out bool Exists_17, loading: out bool Loading_18);
            Asset_Out = Asset_16;
            Exists_Out = Exists_17;
            Loading_Out = Loading_18;
            n3.Asset_NgMUSSka40YMiqWx9s159z<T> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = Output_7 != this.__p_IUkyvyg3nUNPzXz6dy2veV || __auto_9 != this.Current_Value || Url_In != this.Url ? new Asset_NgMUSSka40YMiqWx9s159z<T>(this)
                {__p_IUkyvyg3nUNPzXz6dy2veV = Output_7, Current_Value = __auto_9, Url = Url_In} : that_19;
            else
            {
                this.__p_IUkyvyg3nUNPzXz6dy2veV = Output_7;
                this.Current_Value = __auto_9;
                this.Url = Url_In;
            }

            return that_19;
        }

        public n3.Asset_NgMUSSka40YMiqWx9s159z<T> __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n6.AssetWrapper<T>();
            n6.AssetWrapper<T> __auto_1 = Output_0;
            n6.AssetWrapper<T> __auto_2 = Output_0;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "NfmHQD5LWrsPCkAPzVm0lz", 15363U);
            var Output_4 = n81.Game_NFOYCtbjpVWPQqunXUGp2r.Create(Node_Context_In: Node_Context_3);
            var State_Output_6 = Output_4.Update(Output_Out: out n20.Game Output_5);
            n82.IGame Input_7 = (n82.IGame)Output_5;
            var Content_8 = Input_7.Content;
            n56.ContentManager __auto_9 = Content_8;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "TtYs3Xuo0g6MMgWwWuiIDE", 15328U);
            var Output_11 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_10);
            var Output_13 = Output_11.Update(Service_Out: out n14.AssetBuilderService_C Service_12);
            n14.AssetBuilderService_C __auto_14 = Service_12;
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "IUkyvyg3nUNPzXz6dy2veV", 15241U);
            bool Changed_On_Create_16 = true;
            var Output_17 = n72.Changed_A8JGbead2bxNdnPybiEqVS<string>.Create<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Node_Context: Node_Context_15, Changed_On_Create_In: Changed_On_Create_16);
            n3.Asset_NgMUSSka40YMiqWx9s159z<T> that_18 = this;
            this.Builder = Service_12;
            this.Url = "";
            this.Game_Content = Content_8;
            this.Game_Value = Output_0;
            this.Current_Value = Output_0;
            this.__p_NfmHQD5LWrsPCkAPzVm0lz = State_Output_6;
            this.__p_TtYs3Xuo0g6MMgWwWuiIDE = Output_13;
            this.__p_IUkyvyg3nUNPzXz6dy2veV = Output_17;
            return that_18;
        }

        public n3.Asset_NgMUSSka40YMiqWx9s159z<T> Dispose_()
        {
            n14.AssetBuilderService_C __auto_0 = this.Builder;
            string __auto_1 = this.Url;
            n56.ContentManager __auto_2 = this.Game_Content;
            var Output_4 = __auto_0.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_3);
            var Content_Manager_5 = Content_Loader_3.ContentManager;
            n14._Operations_.UnloadFromContent(Content_Manager_In: Content_Manager_5, Url_In: __auto_1);
            n14._Operations_.UnloadFromContent(Content_Manager_In: __auto_2, Url_In: __auto_1);
            n1.CompilationHelper.SafeDispose(this.__p_IUkyvyg3nUNPzXz6dy2veV);
            n1.CompilationHelper.SafeDispose(this.__p_NfmHQD5LWrsPCkAPzVm0lz);
            n1.CompilationHelper.SafeDispose(this.__p_TtYs3Xuo0g6MMgWwWuiIDE);
            return this;
        }

        public n3.Asset_NgMUSSka40YMiqWx9s159z<T> __CreateDefault__()
        {
            n3.Asset_NgMUSSka40YMiqWx9s159z<T> that_0 = this;
            this.Builder = n33._Operations_.CreateDefault();
            this.Url = "";
            this.Game_Content = default(n56.ContentManager);
            this.Game_Value = default(n6.AssetWrapper<T>);
            this.Current_Value = default(n6.AssetWrapper<T>);
            this.__p_IUkyvyg3nUNPzXz6dy2veV = n72.Changed_A8JGbead2bxNdnPybiEqVS<string>.CreateDefault<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>();
            this.__p_NfmHQD5LWrsPCkAPzVm0lz = n81.Game_NFOYCtbjpVWPQqunXUGp2r.CreateDefault();
            this.__p_TtYs3Xuo0g6MMgWwWuiIDE = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 15343U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "O7PI0uwVCr3Ogk9uhvce8m", Name = "Builder")]
        public n14.AssetBuilderService_C Builder;
        [n1.ElementAttribute(TracingId = 15361U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "GqGghpuvQa5Nh0K0zrIZMv", Name = "Url")]
        public string Url;
        [n1.ElementAttribute(TracingId = 15392U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "TmPYcIFTMvCQJBQpSECMt9", Name = "Game Content")]
        public n56.ContentManager Game_Content;
        [n1.ElementAttribute(TracingId = 15438U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Ve7naje38fMOq32lCOZoB6", Name = "Game Value")]
        public n6.AssetWrapper<T> Game_Value;
        [n1.ElementAttribute(TracingId = 15293U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "RyoUrkVJtugNNCCiO3pYr0", Name = "Current Value")]
        public n6.AssetWrapper<T> Current_Value;
        [n1.ElementAttribute(TracingId = 15241U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IUkyvyg3nUNPzXz6dy2veV", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n72.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_IUkyvyg3nUNPzXz6dy2veV;
        [n1.ElementAttribute(TracingId = 15363U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NfmHQD5LWrsPCkAPzVm0lz", Name = "Game", IsManaged = true, IsAutoGenerated = true)]
        public n81.Game_NFOYCtbjpVWPQqunXUGp2r __p_NfmHQD5LWrsPCkAPzVm0lz;
        [n1.ElementAttribute(TracingId = 15328U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "TtYs3Xuo0g6MMgWwWuiIDE", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_TtYs3Xuo0g6MMgWwWuiIDE;
        public Asset_NgMUSSka40YMiqWx9s159z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Asset_NgMUSSka40YMiqWx9s159z(Asset_NgMUSSka40YMiqWx9s159z<T> other): base(other)
        {
            this.Builder = other.Builder;
            this.Url = other.Url;
            this.Game_Content = other.Game_Content;
            this.Game_Value = other.Game_Value;
            this.Current_Value = other.Current_Value;
            this.__p_IUkyvyg3nUNPzXz6dy2veV = other.__p_IUkyvyg3nUNPzXz6dy2veV;
            this.__p_NfmHQD5LWrsPCkAPzVm0lz = other.__p_NfmHQD5LWrsPCkAPzVm0lz;
            this.__p_TtYs3Xuo0g6MMgWwWuiIDE = other.__p_TtYs3Xuo0g6MMgWwWuiIDE;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder", in Builder), n1.CompilationHelper.GetValueOrExisting(values, "Url", in Url), n1.CompilationHelper.GetValueOrExisting(values, "Game_Content", in Game_Content), n1.CompilationHelper.GetValueOrExisting(values, "Game_Value", in Game_Value), n1.CompilationHelper.GetValueOrExisting(values, "Current_Value", in Current_Value), n1.CompilationHelper.GetValueOrExisting(values, "__p_IUkyvyg3nUNPzXz6dy2veV", in __p_IUkyvyg3nUNPzXz6dy2veV), n1.CompilationHelper.GetValueOrExisting(values, "__p_NfmHQD5LWrsPCkAPzVm0lz", in __p_NfmHQD5LWrsPCkAPzVm0lz), n1.CompilationHelper.GetValueOrExisting(values, "__p_TtYs3Xuo0g6MMgWwWuiIDE", in __p_TtYs3Xuo0g6MMgWwWuiIDE));
        }

        internal Asset_NgMUSSka40YMiqWx9s159z<T> __WITH__(n14.AssetBuilderService_C Builder, string Url, n56.ContentManager Game_Content, n6.AssetWrapper<T> Game_Value, n6.AssetWrapper<T> Current_Value, n72.Changed_A8JGbead2bxNdnPybiEqVS<string> __p_IUkyvyg3nUNPzXz6dy2veV, n81.Game_NFOYCtbjpVWPQqunXUGp2r __p_NfmHQD5LWrsPCkAPzVm0lz, n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_TtYs3Xuo0g6MMgWwWuiIDE)
        {
            n3.Asset_NgMUSSka40YMiqWx9s159z<T> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Builder != this.Builder || Url != this.Url || Game_Content != this.Game_Content || Game_Value != this.Game_Value || Current_Value != this.Current_Value || __p_IUkyvyg3nUNPzXz6dy2veV != this.__p_IUkyvyg3nUNPzXz6dy2veV || __p_NfmHQD5LWrsPCkAPzVm0lz != this.__p_NfmHQD5LWrsPCkAPzVm0lz || __p_TtYs3Xuo0g6MMgWwWuiIDE != this.__p_TtYs3Xuo0g6MMgWwWuiIDE ? new Asset_NgMUSSka40YMiqWx9s159z<T>(this)
                {Builder = Builder, Url = Url, Game_Content = Game_Content, Game_Value = Game_Value, Current_Value = Current_Value, __p_IUkyvyg3nUNPzXz6dy2veV = __p_IUkyvyg3nUNPzXz6dy2veV, __p_NfmHQD5LWrsPCkAPzVm0lz = __p_NfmHQD5LWrsPCkAPzVm0lz, __p_TtYs3Xuo0g6MMgWwWuiIDE = __p_TtYs3Xuo0g6MMgWwWuiIDE} : that_1;
            else
            {
                this.Builder = Builder;
                this.Url = Url;
                this.Game_Content = Game_Content;
                this.Game_Value = Game_Value;
                this.Current_Value = Current_Value;
                this.__p_IUkyvyg3nUNPzXz6dy2veV = __p_IUkyvyg3nUNPzXz6dy2veV;
                this.__p_NfmHQD5LWrsPCkAPzVm0lz = __p_NfmHQD5LWrsPCkAPzVm0lz;
                this.__p_TtYs3Xuo0g6MMgWwWuiIDE = __p_TtYs3Xuo0g6MMgWwWuiIDE;
            }

            return that_1;
        }
    }

    [n1.ElementAttribute(TracingId = 15876U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Vck1QpjM5l6NWkQcueF1SO", Name = "AssetModel_Vck1QpjM5l6NWkQcueF1SO")]
    [n2.SerializableAttribute]
    public class AssetModel_Vck1QpjM5l6NWkQcueF1SO : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetModel_Vck1QpjM5l6NWkQcueF1SO(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO CreateDefault()
        {
            var instance = new AssetModel_Vck1QpjM5l6NWkQcueF1SO(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO Update(string Model_Url_In, bool Reload_In, out n18.Model Output_Out, out bool Exists_Out)
        {
            var Output_3 = this.__p_Ng5R21wDDtMN5OPyrIrn4G.Update<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Url_In: Model_Url_In, Reload_In: Reload_In, Asset_Out: out n18.Model Asset_0, Exists_Out: out bool Exists_1, Loading_Out: out bool Loading_2);
            Output_Out = Asset_0;
            Exists_Out = Exists_1;
            n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = Output_3 != this.__p_Ng5R21wDDtMN5OPyrIrn4G ? new AssetModel_Vck1QpjM5l6NWkQcueF1SO(this)
                {__p_Ng5R21wDDtMN5OPyrIrn4G = Output_3} : that_4;
            else
            {
                this.__p_Ng5R21wDDtMN5OPyrIrn4G = Output_3;
            }

            return that_4;
        }

        public n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "Ng5R21wDDtMN5OPyrIrn4G", 15885U);
            var Output_1 = n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Model>.Create(Node_Context: Node_Context_0);
            n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO that_2 = this;
            this.__p_Ng5R21wDDtMN5OPyrIrn4G = Output_1;
            return that_2;
        }

        public n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO __CreateDefault__()
        {
            n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO that_0 = this;
            this.__p_Ng5R21wDDtMN5OPyrIrn4G = n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Model>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Ng5R21wDDtMN5OPyrIrn4G);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 15885U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Ng5R21wDDtMN5OPyrIrn4G", Name = "Asset", IsManaged = true, IsAutoGenerated = true)]
        public n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Model> __p_Ng5R21wDDtMN5OPyrIrn4G;
        public AssetModel_Vck1QpjM5l6NWkQcueF1SO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetModel_Vck1QpjM5l6NWkQcueF1SO(AssetModel_Vck1QpjM5l6NWkQcueF1SO other): base(other)
        {
            this.__p_Ng5R21wDDtMN5OPyrIrn4G = other.__p_Ng5R21wDDtMN5OPyrIrn4G;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ng5R21wDDtMN5OPyrIrn4G", in __p_Ng5R21wDDtMN5OPyrIrn4G));
        }

        internal AssetModel_Vck1QpjM5l6NWkQcueF1SO __WITH__(n3.Asset_NgMUSSka40YMiqWx9s159z<n18.Model> __p_Ng5R21wDDtMN5OPyrIrn4G)
        {
            n3.AssetModel_Vck1QpjM5l6NWkQcueF1SO that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Ng5R21wDDtMN5OPyrIrn4G != this.__p_Ng5R21wDDtMN5OPyrIrn4G ? new AssetModel_Vck1QpjM5l6NWkQcueF1SO(this)
                {__p_Ng5R21wDDtMN5OPyrIrn4G = __p_Ng5R21wDDtMN5OPyrIrn4G} : that_0;
            else
            {
                this.__p_Ng5R21wDDtMN5OPyrIrn4G = __p_Ng5R21wDDtMN5OPyrIrn4G;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride.Assets.Internal
{
    [n1.ElementAttribute(TracingId = 6611U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IWHxp1HsClUOiMAxLe32Ll", Name = "FileVideo_IWHxp1HsClUOiMAxLe32Ll")]
    [n2.SerializableAttribute]
    public class FileVideo_IWHxp1HsClUOiMAxLe32Ll : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll Create(n1.NodeContext Node_Context)
        {
            var instance = new FileVideo_IWHxp1HsClUOiMAxLe32Ll(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll CreateDefault()
        {
            var instance = new FileVideo_IWHxp1HsClUOiMAxLe32Ll(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll Update(n5.Path Path_In, bool Reload_In, out bool Already_Loaded_Out)
        {
            bool __pad_D13Nf7G38DRMfu7y2AsqMQ_0 = __slot_D13Nf7G38DRMfu7y2AsqMQ;
            bool __pad_Tdac8QHiGHdOMAxJFojJwI_1 = __slot_Tdac8QHiGHdOMAxJFojJwI;
            var Output_2 = Reload_In || __pad_D13Nf7G38DRMfu7y2AsqMQ_0;
            var Output_3 = Output_2 || __pad_Tdac8QHiGHdOMAxJFojJwI_1;
            bool Dispose_Cached_Outputs_4 = false;
            var manager_5 = this.__cache_STecWrepIF0QHBLDYPXwUn;
            if (manager_5 is null)
            {
                manager_5 = new n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>>(n2.ValueTuple.Create(false));
            }

            var inputs_6 = n2.ValueTuple.Create(Path_In);
            var outputs_7 = manager_5.Outputs;
            var Has_Changed_8 = Output_3 || manager_5.InputsChanged(inputs_6);
            if (Has_Changed_8)
            {
                if (Dispose_Cached_Outputs_4)
                    manager_5.DisposeOutputs();
                var Result_10 = (string)Path_In;
                var Result_11 = Result_10.GetHashCode();
                var Result_12 = n12.ObjectHelpers.ToString(input: Result_11);
                outputs_7 = n2.ValueTuple.Create(false);
                manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, default, outputs_7);
            }
            else
            {
                manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
            }

            var __auto_13 = outputs_7.Item1;
            Already_Loaded_Out = __auto_13;
            n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_5 != this.__cache_STecWrepIF0QHBLDYPXwUn ? new FileVideo_IWHxp1HsClUOiMAxLe32Ll(this)
                {__cache_STecWrepIF0QHBLDYPXwUn = manager_5} : that_14;
            else
            {
                this.__cache_STecWrepIF0QHBLDYPXwUn = manager_5;
            }

            return that_14;
        }

        public n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll that_0 = this;
            this.__cache_STecWrepIF0QHBLDYPXwUn = null;
            return that_0;
        }

        public n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll __CreateDefault__()
        {
            n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll that_0 = this;
            this.__cache_STecWrepIF0QHBLDYPXwUn = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_STecWrepIF0QHBLDYPXwUn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 6687U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "D13Nf7G38DRMfu7y2AsqMQ", Name = "__slot_D13Nf7G38DRMfu7y2AsqMQ")]
        public static bool __slot_D13Nf7G38DRMfu7y2AsqMQ = false;
        [n1.ElementAttribute(TracingId = 6688U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Tdac8QHiGHdOMAxJFojJwI", Name = "__slot_Tdac8QHiGHdOMAxJFojJwI")]
        public static bool __slot_Tdac8QHiGHdOMAxJFojJwI = false;
        [n1.ElementAttribute(TracingId = 6615U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "STecWrepIF0QHBLDYPXwUn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>> __cache_STecWrepIF0QHBLDYPXwUn = null;
        static FileVideo_IWHxp1HsClUOiMAxLe32Ll()
        {
        }

        public FileVideo_IWHxp1HsClUOiMAxLe32Ll(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileVideo_IWHxp1HsClUOiMAxLe32Ll(FileVideo_IWHxp1HsClUOiMAxLe32Ll other): base(other)
        {
            this.__cache_STecWrepIF0QHBLDYPXwUn = other.__cache_STecWrepIF0QHBLDYPXwUn;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_STecWrepIF0QHBLDYPXwUn", in __cache_STecWrepIF0QHBLDYPXwUn));
        }

        internal FileVideo_IWHxp1HsClUOiMAxLe32Ll __WITH__(n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>> __cache_STecWrepIF0QHBLDYPXwUn)
        {
            n14.FileVideo_IWHxp1HsClUOiMAxLe32Ll that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_STecWrepIF0QHBLDYPXwUn != this.__cache_STecWrepIF0QHBLDYPXwUn ? new FileVideo_IWHxp1HsClUOiMAxLe32Ll(this)
                {__cache_STecWrepIF0QHBLDYPXwUn = __cache_STecWrepIF0QHBLDYPXwUn} : that_0;
            else
            {
                this.__cache_STecWrepIF0QHBLDYPXwUn = __cache_STecWrepIF0QHBLDYPXwUn;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 6715U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SBDVy4ZFHcBM1ssvsC1ROJ", Name = "FileSound_SBDVy4ZFHcBM1ssvsC1ROJ")]
    [n2.SerializableAttribute]
    public class FileSound_SBDVy4ZFHcBM1ssvsC1ROJ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ Create(n1.NodeContext Node_Context)
        {
            var instance = new FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ CreateDefault()
        {
            var instance = new FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ Update(n5.Path Path_In, bool Reload_In, out bool Has_Changed_Out, out bool Already_Loaded_Out)
        {
            bool __pad_K2rpIbXBkl3ObygYK9Krzw_0 = __slot_K2rpIbXBkl3ObygYK9Krzw;
            bool __pad_FM2UZy4zz8PQWkHjgC4Rh3_1 = __slot_FM2UZy4zz8PQWkHjgC4Rh3;
            var Output_2 = Reload_In || __pad_K2rpIbXBkl3ObygYK9Krzw_0;
            var Output_3 = Output_2 || __pad_FM2UZy4zz8PQWkHjgC4Rh3_1;
            bool Dispose_Cached_Outputs_4 = false;
            var manager_5 = this.__cache_AxpYmBkE9szO37wFQLGCfv;
            if (manager_5 is null)
            {
                manager_5 = new n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>>(n2.ValueTuple.Create(false));
            }

            var inputs_6 = n2.ValueTuple.Create(Path_In);
            var outputs_7 = manager_5.Outputs;
            var Has_Changed_8 = Output_3 || manager_5.InputsChanged(inputs_6);
            if (Has_Changed_8)
            {
                if (Dispose_Cached_Outputs_4)
                    manager_5.DisposeOutputs();
                var Result_10 = (string)Path_In;
                var Result_11 = Result_10.GetHashCode();
                var Result_12 = n12.ObjectHelpers.ToString(input: Result_11);
                outputs_7 = n2.ValueTuple.Create(false);
                manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, default, outputs_7);
            }
            else
            {
                manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
            }

            var __auto_13 = outputs_7.Item1;
            Has_Changed_Out = Has_Changed_8;
            Already_Loaded_Out = __auto_13;
            n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_5 != this.__cache_AxpYmBkE9szO37wFQLGCfv ? new FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(this)
                {__cache_AxpYmBkE9szO37wFQLGCfv = manager_5} : that_14;
            else
            {
                this.__cache_AxpYmBkE9szO37wFQLGCfv = manager_5;
            }

            return that_14;
        }

        public n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ that_0 = this;
            this.__cache_AxpYmBkE9szO37wFQLGCfv = null;
            return that_0;
        }

        public n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ __CreateDefault__()
        {
            n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ that_0 = this;
            this.__cache_AxpYmBkE9szO37wFQLGCfv = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_AxpYmBkE9szO37wFQLGCfv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 6764U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "K2rpIbXBkl3ObygYK9Krzw", Name = "__slot_K2rpIbXBkl3ObygYK9Krzw")]
        public static bool __slot_K2rpIbXBkl3ObygYK9Krzw = false;
        [n1.ElementAttribute(TracingId = 6765U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "FM2UZy4zz8PQWkHjgC4Rh3", Name = "__slot_FM2UZy4zz8PQWkHjgC4Rh3")]
        public static bool __slot_FM2UZy4zz8PQWkHjgC4Rh3 = false;
        [n1.ElementAttribute(TracingId = 6718U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AxpYmBkE9szO37wFQLGCfv", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>> __cache_AxpYmBkE9szO37wFQLGCfv = null;
        static FileSound_SBDVy4ZFHcBM1ssvsC1ROJ()
        {
        }

        public FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(FileSound_SBDVy4ZFHcBM1ssvsC1ROJ other): base(other)
        {
            this.__cache_AxpYmBkE9szO37wFQLGCfv = other.__cache_AxpYmBkE9szO37wFQLGCfv;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_AxpYmBkE9szO37wFQLGCfv", in __cache_AxpYmBkE9szO37wFQLGCfv));
        }

        internal FileSound_SBDVy4ZFHcBM1ssvsC1ROJ __WITH__(n7.Manager<n2.ValueTuple<n5.Path>, n2.ValueTuple<bool>> __cache_AxpYmBkE9szO37wFQLGCfv)
        {
            n14.FileSound_SBDVy4ZFHcBM1ssvsC1ROJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_AxpYmBkE9szO37wFQLGCfv != this.__cache_AxpYmBkE9szO37wFQLGCfv ? new FileSound_SBDVy4ZFHcBM1ssvsC1ROJ(this)
                {__cache_AxpYmBkE9szO37wFQLGCfv = __cache_AxpYmBkE9szO37wFQLGCfv} : that_0;
            else
            {
                this.__cache_AxpYmBkE9szO37wFQLGCfv = __cache_AxpYmBkE9szO37wFQLGCfv;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 6795U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Ib7QGYWs75PNeb5YI1PChl", Name = "VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl")]
    [n2.SerializableAttribute]
    public class VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl Create(n1.NodeContext Node_Context)
        {
            var instance = new VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl CreateDefault()
        {
            var instance = new VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl Update(out n23.Video Video_Out)
        {
            n23.Video __auto_0 = this.v;
            Video_Out = __auto_0;
            return this;
        }

        public n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_G07TpXOLrdzNBvEg3HNwaP_0 = __slot_G07TpXOLrdzNBvEg3HNwaP;
            var Output_1 = new n23.Video();
            Output_1.CompressedDataUrl = __pad_G07TpXOLrdzNBvEg3HNwaP_0;
            n23.Video __auto_2 = Output_1;
            n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl that_3 = this;
            this.v = Output_1;
            return that_3;
        }

        public n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl __CreateDefault__()
        {
            n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl that_0 = this;
            this.v = default(n23.Video);
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

        [n1.ElementAttribute(TracingId = 6804U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "G07TpXOLrdzNBvEg3HNwaP", Name = "__slot_G07TpXOLrdzNBvEg3HNwaP")]
        public static string __slot_G07TpXOLrdzNBvEg3HNwaP = "Birds_H264";
        [n1.ElementAttribute(TracingId = 6806U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "ENySPDBA0QjO0EPwr7qLeU", Name = "v")]
        public n23.Video v;
        static VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl()
        {
        }

        public VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl(VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl other): base(other)
        {
            this.v = other.v;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "v", in v));
        }

        internal VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl __WITH__(n23.Video v)
        {
            n14.VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = v != this.v ? new VideoFromUrl_Ib7QGYWs75PNeb5YI1PChl(this)
                {v = v} : that_0;
            else
            {
                this.v = v;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 6865U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "S05QiWhSMYPQAKlrBTDI5O", Name = "IncrementalAssetBuilder_C")]
    [n2.SerializableAttribute]
    public class IncrementalAssetBuilder_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.IncrementalAssetBuilder_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new IncrementalAssetBuilder_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.IncrementalAssetBuilder_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new IncrementalAssetBuilder_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.IncrementalAssetBuilder_C BuildAsync(n17.IEnumerable<n13.AssetItem> Assets_To_Rebuild_In)
        {
            n24.AssetBuilderServiceScript __auto_0 = this.Asset_Build_Service_Script;
            __auto_0.PushWork(items: Assets_To_Rebuild_In);
            return this;
        }

        public n14.IncrementalAssetBuilder_C GetContentLoader(out n24.RuntimeContentLoader Content_Loader_Out)
        {
            n24.RuntimeContentLoader __pad_IxeZHrX8hWDNGRAxcReVsE_0 = this.__slot_IxeZHrX8hWDNGRAxcReVsE;
            Content_Loader_Out = __pad_IxeZHrX8hWDNGRAxcReVsE_0;
            return this;
        }

        public n14.IncrementalAssetBuilder_C GetLogger(out n25.Logger Logger_Out)
        {
            n25.Logger __pad_OTeC61dll2RP2b95v1bA9B_0 = this.__slot_OTeC61dll2RP2b95v1bA9B;
            Logger_Out = __pad_OTeC61dll2RP2b95v1bA9B_0;
            return this;
        }

        public n14.IncrementalAssetBuilder_C GetAssetBuiltEvent(out n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> On_Asset_Built_Out)
        {
            n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> __pad_EQEA3yGduKoMC3xKu8jqiK_0 = this.__slot_EQEA3yGduKoMC3xKu8jqiK;
            On_Asset_Built_Out = __pad_EQEA3yGduKoMC3xKu8jqiK_0;
            return this;
        }

        public n14.IncrementalAssetBuilder_C BuildSync()
        {
            return this;
        }

        public n14.IncrementalAssetBuilder_C __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_IxeZHrX8hWDNGRAxcReVsE = default(n24.RuntimeContentLoader);
            this.__slot_EQEA3yGduKoMC3xKu8jqiK = n27._Operations_.CreateDefault<n2.Tuple<n26.ReloadingAsset, n2.Object>>();
            this.__slot_OTeC61dll2RP2b95v1bA9B = default(n25.Logger);
            this.Asset_Build_Service_Script = default(n24.AssetBuilderServiceScript);
            string __pad_JSoz1np3cIvLcylSAeHOgK_0 = __slot_JSoz1np3cIvLcylSAeHOgK;
            var Result_1 = n25.GlobalLogger.GetLogger(module: __pad_JSoz1np3cIvLcylSAeHOgK_0);
            n25.LogMessageType Type_2 = default(n25.LogMessageType);
            bool Enabled_Flag_3 = true;
            Result_1.ActivateLog(type: Type_2, enabledFlag: Enabled_Flag_3);
            n25.ILogger Logger_4 = (n25.ILogger)Result_1;
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "Fcu0wbycks3OCQUVaEnCy5", 6932U);
            var Output_6 = n28.GameProvider_Pd38wXWKEIYP1l5KGR7wKt.Create(Node_Context_In: Node_Context_5);
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = Output_6;
            var Output_8 = Output_6.GetGame(Game_Out: out n20.Game Game_7);
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = Output_8;
            var Output_9 = new n24.RuntimeContentLoader(logger: Logger_4, game: Game_7);
            this.__slot_OTeC61dll2RP2b95v1bA9B = Result_1;
            n25.Logger __pad_OTeC61dll2RP2b95v1bA9B_10 = Result_1;
            var Output_12 = Output_8.GetServices(Services_Out: out n29.ServiceRegistry Services_11);
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = Output_12;
            var On_Asset_Built_13 = Output_9.OnAssetBuilt;
            this.__slot_EQEA3yGduKoMC3xKu8jqiK = On_Asset_Built_13;
            n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> __pad_EQEA3yGduKoMC3xKu8jqiK_14 = On_Asset_Built_13;
            this.__slot_IxeZHrX8hWDNGRAxcReVsE = Output_9;
            n24.RuntimeContentLoader __pad_IxeZHrX8hWDNGRAxcReVsE_15 = Output_9;
            var Result_16 = Services_11.GetService<n24.AssetBuilderServiceScript>();
            Result_16.ContentLoader = Output_9;
            this.Asset_Build_Service_Script = Result_16;
            n24.AssetBuilderServiceScript __auto_17 = Result_16;
            return this;
        }

        public n14.IncrementalAssetBuilder_C Dispose_()
        {
            n24.RuntimeContentLoader __pad_IxeZHrX8hWDNGRAxcReVsE_0 = this.__slot_IxeZHrX8hWDNGRAxcReVsE;
            n30.IDisposableUtils.TryDispose(input: __pad_IxeZHrX8hWDNGRAxcReVsE_0, success: out bool Success_1);
            n1.CompilationHelper.SafeDispose(this.__p_Fcu0wbycks3OCQUVaEnCy5);
            return this;
        }

        public n14.IncrementalAssetBuilder_C __CreateDefault__()
        {
            this.__slot_IxeZHrX8hWDNGRAxcReVsE = default(n24.RuntimeContentLoader);
            this.__slot_EQEA3yGduKoMC3xKu8jqiK = n27._Operations_.CreateDefault<n2.Tuple<n26.ReloadingAsset, n2.Object>>();
            this.__slot_OTeC61dll2RP2b95v1bA9B = default(n25.Logger);
            this.Asset_Build_Service_Script = default(n24.AssetBuilderServiceScript);
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = n28.GameProvider_Pd38wXWKEIYP1l5KGR7wKt.CreateDefault();
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 6883U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "JSoz1np3cIvLcylSAeHOgK", Name = "__slot_JSoz1np3cIvLcylSAeHOgK")]
        public static string __slot_JSoz1np3cIvLcylSAeHOgK = "Incremental Builder";
        [n1.ElementAttribute(TracingId = 6892U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IxeZHrX8hWDNGRAxcReVsE", Name = "__slot_IxeZHrX8hWDNGRAxcReVsE")]
        public n24.RuntimeContentLoader __slot_IxeZHrX8hWDNGRAxcReVsE;
        [n1.ElementAttribute(TracingId = 6893U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "EQEA3yGduKoMC3xKu8jqiK", Name = "__slot_EQEA3yGduKoMC3xKu8jqiK")]
        public n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> __slot_EQEA3yGduKoMC3xKu8jqiK;
        [n1.ElementAttribute(TracingId = 6898U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OTeC61dll2RP2b95v1bA9B", Name = "__slot_OTeC61dll2RP2b95v1bA9B")]
        public n25.Logger __slot_OTeC61dll2RP2b95v1bA9B;
        [n1.ElementAttribute(TracingId = 6908U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "PZSoGXp7M86NmTAH4GGgkb", Name = "Asset Build Service Script")]
        public n24.AssetBuilderServiceScript Asset_Build_Service_Script;
        [n1.ElementAttribute(TracingId = 6932U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Fcu0wbycks3OCQUVaEnCy5", Name = "GameProvider", IsManaged = true, IsAutoGenerated = true)]
        public n28.GameProvider_Pd38wXWKEIYP1l5KGR7wKt __p_Fcu0wbycks3OCQUVaEnCy5;
        static IncrementalAssetBuilder_C()
        {
        }

        public IncrementalAssetBuilder_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IncrementalAssetBuilder_C(IncrementalAssetBuilder_C other): base(other)
        {
            this.__slot_IxeZHrX8hWDNGRAxcReVsE = other.__slot_IxeZHrX8hWDNGRAxcReVsE;
            this.__slot_EQEA3yGduKoMC3xKu8jqiK = other.__slot_EQEA3yGduKoMC3xKu8jqiK;
            this.__slot_OTeC61dll2RP2b95v1bA9B = other.__slot_OTeC61dll2RP2b95v1bA9B;
            this.Asset_Build_Service_Script = other.Asset_Build_Service_Script;
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = other.__p_Fcu0wbycks3OCQUVaEnCy5;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_IxeZHrX8hWDNGRAxcReVsE", in __slot_IxeZHrX8hWDNGRAxcReVsE), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EQEA3yGduKoMC3xKu8jqiK", in __slot_EQEA3yGduKoMC3xKu8jqiK), n1.CompilationHelper.GetValueOrExisting(values, "__slot_OTeC61dll2RP2b95v1bA9B", in __slot_OTeC61dll2RP2b95v1bA9B), n1.CompilationHelper.GetValueOrExisting(values, "Asset_Build_Service_Script", in Asset_Build_Service_Script), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fcu0wbycks3OCQUVaEnCy5", in __p_Fcu0wbycks3OCQUVaEnCy5));
        }

        internal IncrementalAssetBuilder_C __WITH__(n24.RuntimeContentLoader __slot_IxeZHrX8hWDNGRAxcReVsE, n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> __slot_EQEA3yGduKoMC3xKu8jqiK, n25.Logger __slot_OTeC61dll2RP2b95v1bA9B, n24.AssetBuilderServiceScript Asset_Build_Service_Script, n28.GameProvider_Pd38wXWKEIYP1l5KGR7wKt __p_Fcu0wbycks3OCQUVaEnCy5)
        {
            n14.IncrementalAssetBuilder_C that_0 = this;
            this.__slot_IxeZHrX8hWDNGRAxcReVsE = __slot_IxeZHrX8hWDNGRAxcReVsE;
            this.__slot_EQEA3yGduKoMC3xKu8jqiK = __slot_EQEA3yGduKoMC3xKu8jqiK;
            this.__slot_OTeC61dll2RP2b95v1bA9B = __slot_OTeC61dll2RP2b95v1bA9B;
            this.Asset_Build_Service_Script = Asset_Build_Service_Script;
            this.__p_Fcu0wbycks3OCQUVaEnCy5 = __p_Fcu0wbycks3OCQUVaEnCy5;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 7236U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NnosSuoWiVYMWRdvYviwN2", Name = "AssetBuilderService_C")]
    [n2.SerializableAttribute]
    public class AssetBuilderService_C : n1.VLObject, n31.IAssetBuilderService, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.AssetBuilderService_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new AssetBuilderService_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.AssetBuilderService_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new AssetBuilderService_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.AssetBuilderService_C BuildAsync([n4.SerializedDefaultValueAttribute("True", false)] bool Add_To_Runtime_Package_In, n17.IEnumerable<n13.AssetItem> Asset_items_In)
        {
            n13.Package __auto_0 = this.Package;
            n25.Logger __auto_1 = this.Logger;
            n25.ILogger Logger_2 = (n25.ILogger)__auto_1;
            var breakOutput_20 = false;
            var i_5 = 0;
            foreach (var item_3 in Asset_items_In)
            {
                var splicer_4 = item_3;
                var i_local_6 = i_5;
                n17.ICollection<n13.AssetReference> __auto_8;
                if (Add_To_Runtime_Package_In)
                {
                    var Assets_10 = __auto_0.Assets;
                    var Root_Assets_11 = __auto_0.RootAssets;
                    n17.ICollection<n13.AssetReference> Input_12 = (n17.ICollection<n13.AssetReference>)Root_Assets_11;
                    n14._Operations_.ToAssetReference(Input_In: splicer_4, Output_Out: out n13.AssetReference Output_13);
                    var Result_14 = ((n17.ICollection<n13.AssetReference>)Input_12).Remove(item: Output_13);
                    ((n17.ICollection<n13.AssetReference>)Input_12).Add(item: Output_13);
                    __auto_8 = Input_12;
                    var Result_15 = Assets_10.Remove(item: splicer_4);
                    Assets_10.Add(item: splicer_4);
                }
                else
                {
                    __auto_8 = n32._Operations_.CreateDefault<n13.AssetReference>();
                }

                bool Condition_16 = false;
                n13.AssetItem __auto_17;
                if (Condition_16)
                {
                    __auto_17 = default(n13.AssetItem);
                }
                else
                {
                    __auto_17 = splicer_4;
                }

                n33._Operations_.EnsureAbsolutePath(Asset_Item_In: __auto_17, Logger_In: Logger_2, Asset_Item_Out: out n13.AssetItem Asset_Item_19);
                i_5++;
            }

            bool Condition_21 = false;
            n17.IEnumerable<n13.AssetItem> __auto_22;
            if (Condition_21)
            {
                __auto_22 = n34._Operations_.CreateDefault<n13.AssetItem>();
            }
            else
            {
                __auto_22 = Asset_items_In;
            }

            bool BuildAsync_24 = true;
            var Output_25 = this.__p_Akzgt3xvDubLJ4T0JuySrQ;
            if (BuildAsync_24)
            {
                Output_25 = this.__p_Akzgt3xvDubLJ4T0JuySrQ.BuildAsync(Assets_To_Rebuild_In: __auto_22);
            }

            this.__p_Akzgt3xvDubLJ4T0JuySrQ = Output_25;
            return this;
        }

        public n14.AssetBuilderService_C GetContentLoader(out n24.RuntimeContentLoader Content_Loader_Out)
        {
            var Output_1 = this.__p_Akzgt3xvDubLJ4T0JuySrQ.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_0);
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = Output_1;
            Content_Loader_Out = Content_Loader_0;
            return this;
        }

        public n14.AssetBuilderService_C GetLogger(out n25.Logger Logger_Out)
        {
            n25.Logger __auto_0 = this.Logger;
            Logger_Out = __auto_0;
            return this;
        }

        public n14.AssetBuilderService_C GetAssetBuiltEvent(out n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> On_Asset_Built_Out)
        {
            var Output_1 = this.__p_Akzgt3xvDubLJ4T0JuySrQ.GetAssetBuiltEvent(On_Asset_Built_Out: out n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> On_Asset_Built_0);
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = Output_1;
            On_Asset_Built_Out = On_Asset_Built_0;
            return this;
        }

        public n14.AssetBuilderService_C GetRuntimePackage(out n13.Package Package_Out, out n13.PackageSession Package_Session_Out)
        {
            n13.Package __auto_0 = this.Package;
            n13.PackageSession __auto_1 = this.Package_Session;
            Package_Out = __auto_0;
            Package_Session_Out = __auto_1;
            return this;
        }

        public n14.AssetBuilderService_C __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Package_Session = default(n13.PackageSession);
            this.Package = default(n13.Package);
            this.Logger = default(n25.Logger);
            n14._Operations_.CreateRuntimePackage(Output_Out: out n13.Package Output_0);
            this.Package = Output_0;
            n13.Package __auto_1 = Output_0;
            var Output_2 = new n13.PackageSession(package: Output_0);
            this.Package_Session = Output_2;
            n13.PackageSession __auto_3 = Output_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "Akzgt3xvDubLJ4T0JuySrQ", 7239U);
            var Output_5 = n14.IncrementalAssetBuilder_C.Create(Node_Context: Node_Context_4);
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = Output_5;
            var Output_7 = Output_5.GetLogger(Logger_Out: out n25.Logger Logger_6);
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = Output_7;
            this.Logger = Logger_6;
            n25.Logger __auto_8 = Logger_6;
            return this;
        }

        public n14.AssetBuilderService_C __CreateDefault__()
        {
            this.Package_Session = default(n13.PackageSession);
            this.Package = default(n13.Package);
            this.Logger = default(n25.Logger);
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = n14.IncrementalAssetBuilder_C.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Akzgt3xvDubLJ4T0JuySrQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 7254U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VHAtZRDJxEHN6Dpe9H1lXi", Name = "Package Session")]
        public n13.PackageSession Package_Session;
        [n1.ElementAttribute(TracingId = 7248U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "EgskGn0anTAQNsUF3L3kzk", Name = "Package")]
        public n13.Package Package;
        [n1.ElementAttribute(TracingId = 7550U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "FmTXeHlUg9wQWGMXdBoakm", Name = "Logger")]
        public n25.Logger Logger;
        [n1.ElementAttribute(TracingId = 7239U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Akzgt3xvDubLJ4T0JuySrQ", Name = "IncrementalAssetBuilder", IsManaged = true, IsAutoGenerated = true)]
        public n14.IncrementalAssetBuilder_C __p_Akzgt3xvDubLJ4T0JuySrQ;
        public AssetBuilderService_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetBuilderService_C(AssetBuilderService_C other): base(other)
        {
            this.Package_Session = other.Package_Session;
            this.Package = other.Package;
            this.Logger = other.Logger;
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = other.__p_Akzgt3xvDubLJ4T0JuySrQ;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Package_Session", in Package_Session), n1.CompilationHelper.GetValueOrExisting(values, "Package", in Package), n1.CompilationHelper.GetValueOrExisting(values, "Logger", in Logger), n1.CompilationHelper.GetValueOrExisting(values, "__p_Akzgt3xvDubLJ4T0JuySrQ", in __p_Akzgt3xvDubLJ4T0JuySrQ));
        }

        internal AssetBuilderService_C __WITH__(n13.PackageSession Package_Session, n13.Package Package, n25.Logger Logger, n14.IncrementalAssetBuilder_C __p_Akzgt3xvDubLJ4T0JuySrQ)
        {
            n14.AssetBuilderService_C that_0 = this;
            this.Package_Session = Package_Session;
            this.Package = Package;
            this.Logger = Logger;
            this.__p_Akzgt3xvDubLJ4T0JuySrQ = __p_Akzgt3xvDubLJ4T0JuySrQ;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 7895U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OqqyqkcUDlkM4LtWN5eDau", Name = "GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau")]
    [n2.SerializableAttribute]
    public class GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau Create(n1.NodeContext Node_Context)
        {
            var instance = new GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau CreateDefault()
        {
            var instance = new GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau Update(out n14.AssetBuilderService_C Service_Out)
        {
            n36._Operations_.Value<n14.AssetBuilderService_C>(Input_In: this.__p_LqzifnIgd7sP6NebNCcdM0, Output_Out: out n35.SingleInstancePerApp<n14.AssetBuilderService_C> Output_0, Value_Out: out n14.AssetBuilderService_C Value_1);
            Service_Out = Value_1;
            n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_0 != this.__p_LqzifnIgd7sP6NebNCcdM0 ? new GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(this)
                {__p_LqzifnIgd7sP6NebNCcdM0 = Output_0} : that_2;
            else
            {
                this.__p_LqzifnIgd7sP6NebNCcdM0 = Output_0;
            }

            return that_2;
        }

        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "LqzifnIgd7sP6NebNCcdM0", 7900U);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n36._Operations_.Create<n14.AssetBuilderService_C>(Node_Context: Node_Context_0, Producer_In: () =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "CCi3edGK81TL0vKYck5fXA", 7906U);
                var Output_4 = n14.AssetBuilderService_C.Create(Node_Context: Node_Context_3);
                return Output_4;
            }

            , Output_Out: out n35.SingleInstancePerApp<n14.AssetBuilderService_C> Output_5);
            n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau that_6 = this;
            this.__p_LqzifnIgd7sP6NebNCcdM0 = Output_5;
            return that_6;
        }

        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __CreateDefault__()
        {
            n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau that_0 = this;
            this.__p_LqzifnIgd7sP6NebNCcdM0 = default(n35.SingleInstancePerApp<n14.AssetBuilderService_C>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LqzifnIgd7sP6NebNCcdM0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 7900U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "LqzifnIgd7sP6NebNCcdM0", Name = "SingleInstance (PerApp)", IsManaged = true, IsAutoGenerated = true)]
        public n35.SingleInstancePerApp<n14.AssetBuilderService_C> __p_LqzifnIgd7sP6NebNCcdM0;
        public GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau other): base(other)
        {
            this.__p_LqzifnIgd7sP6NebNCcdM0 = other.__p_LqzifnIgd7sP6NebNCcdM0;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LqzifnIgd7sP6NebNCcdM0", in __p_LqzifnIgd7sP6NebNCcdM0));
        }

        internal GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __WITH__(n35.SingleInstancePerApp<n14.AssetBuilderService_C> __p_LqzifnIgd7sP6NebNCcdM0)
        {
            n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LqzifnIgd7sP6NebNCcdM0 != this.__p_LqzifnIgd7sP6NebNCcdM0 ? new GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau(this)
                {__p_LqzifnIgd7sP6NebNCcdM0 = __p_LqzifnIgd7sP6NebNCcdM0} : that_0;
            else
            {
                this.__p_LqzifnIgd7sP6NebNCcdM0 = __p_LqzifnIgd7sP6NebNCcdM0;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 10201U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IQOAA8IGg90OB5zyGz4EuI", Name = "ExistingProject_C")]
    [n2.SerializableAttribute]
    public class ExistingProject_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.ExistingProject_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new ExistingProject_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.ExistingProject_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new ExistingProject_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.ExistingProject_C Update()
        {
            var Output_1 = this.__p_BYWjmKy2QklNfPcdkVX2oY.Update(Service_Out: out n14.AssetBuilderService_C Service_0);
            this.__p_BYWjmKy2QklNfPcdkVX2oY = Output_1;
            this.Builder = Service_0;
            n14.AssetBuilderService_C __auto_2 = Service_0;
            return this;
        }

        public n14.ExistingProject_C AddProject(bool Add_In, n5.Path Project_Path_In, out n13.PackageAssetCollection Assets_Out)
        {
            n13.PackageContainer __auto_0 = this.Project;
            n14.AssetBuilderService_C __auto_1 = this.Builder;
            n13.PackageContainer __auto_2;
            if (Add_In)
            {
                var Output_6 = __auto_1.GetRuntimePackage(Package_Out: out n13.Package Package_4, Package_Session_Out: out n13.PackageSession Package_Session_5);
                n37._Operations_.SafeRemoveProject(Runtime_Package_Session_In: Package_Session_5, Project_In: __auto_0, Package_Session_Out: out n13.PackageSession Package_Session_7);
                n14._Operations_.PathToUFile(Input_In: Project_Path_In, Output_Out: out n38.UFile Output_8);
                n37._Operations_.SafeRemoveNewProject(Runtime_Package_Session_In: Package_Session_7, New_Project_File_Path_In: Output_8, Package_Session_Out: out n13.PackageSession Package_Session_9);
                var Output_11 = Output_6.GetLogger(Logger_Out: out n25.Logger Logger_10);
                n25.ILogger Logger_12 = (n25.ILogger)Logger_10;
                var Result_13 = n13.PackageLoadParameters.Default();
                var Result_14 = Package_Session_9.AddExistingProject(projectPath: Output_8, logger: Logger_12, loadParametersArg: Result_13);
                n37._Operations_.SetDirtyFlags(Input_In: Result_14, Output_Out: out n13.PackageContainer Output_15);
                __auto_2 = Output_15;
            }
            else
            {
                __auto_2 = __auto_0;
            }

            this.Project = __auto_2;
            n13.PackageContainer __auto_16 = __auto_2;
            var Package_17 = __auto_16.Package;
            var Assets_18 = Package_17.Assets;
            Assets_Out = Assets_18;
            return this;
        }

        public n14.ExistingProject_C __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Builder = n33._Operations_.CreateDefault();
            this.Project = default(n13.PackageContainer);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "BYWjmKy2QklNfPcdkVX2oY", 10207U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            this.__p_BYWjmKy2QklNfPcdkVX2oY = Output_1;
            return this;
        }

        public n14.ExistingProject_C Dispose_()
        {
            n14.AssetBuilderService_C __auto_0 = this.Builder;
            n13.PackageContainer __auto_1 = this.Project;
            var Output_4 = __auto_0.GetRuntimePackage(Package_Out: out n13.Package Package_2, Package_Session_Out: out n13.PackageSession Package_Session_3);
            n37._Operations_.SafeRemoveProject(Runtime_Package_Session_In: Package_Session_3, Project_In: __auto_1, Package_Session_Out: out n13.PackageSession Package_Session_5);
            n1.CompilationHelper.SafeDispose(this.__p_BYWjmKy2QklNfPcdkVX2oY);
            return this;
        }

        public n14.ExistingProject_C __CreateDefault__()
        {
            this.Builder = n33._Operations_.CreateDefault();
            this.Project = default(n13.PackageContainer);
            this.__p_BYWjmKy2QklNfPcdkVX2oY = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 10205U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Mtd6pneJFA6NdRhJ7YOWFN", Name = "Builder")]
        public n14.AssetBuilderService_C Builder;
        [n1.ElementAttribute(TracingId = 10775U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IpyPOx5qc8zNipkGjbmgxC", Name = "Project")]
        public n13.PackageContainer Project;
        [n1.ElementAttribute(TracingId = 10207U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "BYWjmKy2QklNfPcdkVX2oY", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_BYWjmKy2QklNfPcdkVX2oY;
        public ExistingProject_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ExistingProject_C(ExistingProject_C other): base(other)
        {
            this.Builder = other.Builder;
            this.Project = other.Project;
            this.__p_BYWjmKy2QklNfPcdkVX2oY = other.__p_BYWjmKy2QklNfPcdkVX2oY;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder", in Builder), n1.CompilationHelper.GetValueOrExisting(values, "Project", in Project), n1.CompilationHelper.GetValueOrExisting(values, "__p_BYWjmKy2QklNfPcdkVX2oY", in __p_BYWjmKy2QklNfPcdkVX2oY));
        }

        internal ExistingProject_C __WITH__(n14.AssetBuilderService_C Builder, n13.PackageContainer Project, n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_BYWjmKy2QklNfPcdkVX2oY)
        {
            n14.ExistingProject_C that_0 = this;
            this.Builder = Builder;
            this.Project = Project;
            this.__p_BYWjmKy2QklNfPcdkVX2oY = __p_BYWjmKy2QklNfPcdkVX2oY;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 11717U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "C2Xind0USqVPpqh2MLbXkM", Name = "UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM")]
    [n2.SerializableAttribute]
    public class UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM Create(n1.NodeContext Node_Context)
        {
            var instance = new UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM CreateDefault()
        {
            var instance = new UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM Update(n17.IEnumerable<n13.AssetItem> New_Assets_In, n17.IEnumerable<string> Urls_In, out bool Execution_Order_Helper_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n34._Operations_.Select<n13.AssetItem, string>(Input_In: New_Assets_In, Transformer_In: (n13.AssetItem Arg_1_In_2, int Arg_2_In_3) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Location_4 = Arg_1_In_2.Location;
                var Result_5 = n12.ObjectHelpers.ToString(input: Location_4);
                return Result_5;
            }

            , Output_Out: out n17.IEnumerable<string> Output_6);
            n34._Operations_.Except<string>(Input_In: Urls_In, Input_2_In: Output_6, Output_Out: out n17.IEnumerable<string> Output_7);
            var Output_9 = this.__p_IDvg18MwzzmL4Jxj7ohhCW.Update(Service_Out: out n14.AssetBuilderService_C Service_8);
            var breakOutput_16 = false;
            var i_12 = 0;
            foreach (var item_10 in Output_7)
            {
                var splicer_11 = item_10;
                var i_local_13 = i_12;
                n14._Operations_.SafeUnloadAsset(Input_In: Service_8, Url_In: splicer_11, Output_Out: out n14.AssetBuilderService_C Output_15);
                i_12++;
            }

            Execution_Order_Helper_Out = breakOutput_16;
            n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM that_17 = this;
            if (this.__GetContext__().IsImmutable)
                that_17 = Output_9 != this.__p_IDvg18MwzzmL4Jxj7ohhCW ? new UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(this)
                {__p_IDvg18MwzzmL4Jxj7ohhCW = Output_9} : that_17;
            else
            {
                this.__p_IDvg18MwzzmL4Jxj7ohhCW = Output_9;
            }

            return that_17;
        }

        public n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "IDvg18MwzzmL4Jxj7ohhCW", 11722U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM that_2 = this;
            this.__p_IDvg18MwzzmL4Jxj7ohhCW = Output_1;
            return that_2;
        }

        public n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM Dispose_()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IDvg18MwzzmL4Jxj7ohhCW);
            return this;
        }

        public n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM __CreateDefault__()
        {
            n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM that_0 = this;
            this.__p_IDvg18MwzzmL4Jxj7ohhCW = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 11722U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IDvg18MwzzmL4Jxj7ohhCW", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_IDvg18MwzzmL4Jxj7ohhCW;
        public UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM other): base(other)
        {
            this.__p_IDvg18MwzzmL4Jxj7ohhCW = other.__p_IDvg18MwzzmL4Jxj7ohhCW;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IDvg18MwzzmL4Jxj7ohhCW", in __p_IDvg18MwzzmL4Jxj7ohhCW));
        }

        internal UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM __WITH__(n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_IDvg18MwzzmL4Jxj7ohhCW)
        {
            n14.UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = __p_IDvg18MwzzmL4Jxj7ohhCW != this.__p_IDvg18MwzzmL4Jxj7ohhCW ? new UnloadDeletedProjectAssets_C2Xind0USqVPpqh2MLbXkM(this)
                {__p_IDvg18MwzzmL4Jxj7ohhCW = __p_IDvg18MwzzmL4Jxj7ohhCW} : that_1;
            else
            {
                this.__p_IDvg18MwzzmL4Jxj7ohhCW = __p_IDvg18MwzzmL4Jxj7ohhCW;
            }

            return that_1;
        }
    }

    [n1.ElementAttribute(TracingId = 11867U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "OvABOUW1t3OQFuniDviwsF", Name = "LoadProjectAssets_OvABOUW1t3OQFuniDviwsF")]
    [n2.SerializableAttribute]
    public class LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> CreateDefault()
        {
            var instance = new LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> Update<T2, AdM>(T2 Asset_Items_In, n2.Object Execution_Order_Helper_In, out n21.Spread<string> Urls_Out, out n21.Spread<n43.Reference_C<bool>> Is_Loading_Out, out n21.Spread<n2.IObservable<T>> Content_Out)
            where T2 : n17.IEnumerable<n13.AssetItem> where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            string __pad_Ablq3NgE4OGLNsZ2SBXydu_1 = __slot_Ablq3NgE4OGLNsZ2SBXydu;
            var Output_3 = this.__p_JFA6W7NtcFZMhzoBcYpbBr.Update(Service_Out: out n14.AssetBuilderService_C Service_2);
            var manager_26 = this.__loop_NmCPbdYk7mlMCbGQoD8rbX ?? new n44.ImmutableLifetimeManager();
            var iterator_27 = manager_26.GetIterator(__GetContext__());
            var builder_28 = n4.CollectionBuilders.GetBuilder(this.__cp_VNgNWZqQya4L508TfqKGzE, 16);
            n21.Spread<string> output_29;
            var builder_30 = n4.CollectionBuilders.GetBuilder(this.__cp_V54SFICwvwKLC6nkuVxCWZ, 16);
            n21.Spread<n43.Reference_C<bool>> output_31;
            var builder_32 = n4.CollectionBuilders.GetBuilder(this.__cp_UW472ExcBz4QHLcexdW8iL, 16);
            n21.Spread<n2.IObservable<T>> output_33;
            var breakOutput_34 = false;
            try
            {
                var i_6 = 0;
                foreach (var item_4 in Asset_Items_In)
                {
                    var splicer_5 = item_4;
                    var i_local_7 = i_6;
                    __SkFpGmeBJlaMlU8hb54Gsi state_8;
                    if (!iterator_27.MoveNext(out state_8))
                    {
                        iterator_27.Add(state_8 = new __SkFpGmeBJlaMlU8hb54Gsi(__GetContext__(), n1.VLObject.NewIdentity()));
                        bool __pad_NnsHviwuDK8NOhnPogWVJm_9 = __slot_NnsHviwuDK8NOhnPogWVJm;
                        n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "Rc3gegHGmk2O1TCim3Ma4D", 11910U);
                        var Output_11 = n43.Reference_C<bool>.Create<n19.__AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF>(Node_Context: Node_Context_10, Data_In: __pad_NnsHviwuDK8NOhnPogWVJm_9);
                        state_8.Loading = Output_11;
                        n43.Reference_C<bool> __auto_12 = Output_11;
                    }

                    n43.Reference_C<bool> __auto_13 = state_8.Loading;
                    var Location_14 = splicer_5.Location;
                    string Name_15 = "";
                    n14._Operations_.SubscribeToBuildEvent<T, AdM>(Input_In: Service_2, Location_In: Location_14, Name_In: Name_15, Logger_Prefix_In: __pad_Ablq3NgE4OGLNsZ2SBXydu_1, Output_Out: out n2.IObservable<T> Output_16);
                    var Result_17 = n12.ObjectHelpers.ToString(input: Location_14);
                    bool Data_18 = true;
                    var Output_19 = __auto_13.SetData(Data_In: Data_18);
                    var __fallback___20 = n1.ServiceRegistry.Current;
                    n27._Operations_.Do<T>(Input_In: Output_16, On_Next_In: (T Arg_In_22) =>
                    {
                        using var __current_21 = __fallback___20.MakeCurrentIfNone();
                        bool Data_23 = false;
                        var Output_24 = Output_19.SetData(Data_In: Data_23);
                    }

                    , Output_Out: out n2.IObservable<T> Output_25);
                    iterator_27.Update(state_8);
                    builder_28.Add(Result_17);
                    builder_30.Add(Output_19);
                    builder_32.Add(Output_25);
                    i_6++;
                }
            }
            finally
            {
                manager_26 = iterator_27.Commit();
                output_29 = builder_28.Commit();
                output_31 = builder_30.Commit();
                output_33 = builder_32.Commit();
            }

            n17.IEnumerable<n13.AssetItem> Asset_items_35 = (n17.IEnumerable<n13.AssetItem>)Asset_Items_In;
            var Output_36 = Service_2.BuildAsync(Add_To_Runtime_Package_In: breakOutput_34, Asset_items_In: Asset_items_35);
            n14.AssetBuilderService_C __auto_37 = Service_2;
            n21.Spread<string> __auto_38 = output_29;
            Urls_Out = __auto_38;
            Is_Loading_Out = output_31;
            Content_Out = output_33;
            n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> that_39 = this;
            if (this.__GetContext__().IsImmutable)
                that_39 = Output_3 != this.__p_JFA6W7NtcFZMhzoBcYpbBr || manager_26 != this.__loop_NmCPbdYk7mlMCbGQoD8rbX || output_29 != this.__cp_VNgNWZqQya4L508TfqKGzE || output_31 != this.__cp_V54SFICwvwKLC6nkuVxCWZ || output_33 != this.__cp_UW472ExcBz4QHLcexdW8iL || Service_2 != this.Builder || output_29 != this.Urls ? new LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T>(this)
                {__p_JFA6W7NtcFZMhzoBcYpbBr = Output_3, __loop_NmCPbdYk7mlMCbGQoD8rbX = manager_26, __cp_VNgNWZqQya4L508TfqKGzE = output_29, __cp_V54SFICwvwKLC6nkuVxCWZ = output_31, __cp_UW472ExcBz4QHLcexdW8iL = output_33, Builder = Service_2, Urls = output_29} : that_39;
            else
            {
                this.__p_JFA6W7NtcFZMhzoBcYpbBr = Output_3;
                this.__loop_NmCPbdYk7mlMCbGQoD8rbX = manager_26;
                this.__cp_VNgNWZqQya4L508TfqKGzE = output_29;
                this.__cp_V54SFICwvwKLC6nkuVxCWZ = output_31;
                this.__cp_UW472ExcBz4QHLcexdW8iL = output_33;
                this.Builder = Service_2;
                this.Urls = output_29;
            }

            return that_39;
        }

        public n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "JFA6W7NtcFZMhzoBcYpbBr", 11875U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> that_2 = this;
            this.Builder = n33._Operations_.CreateDefault();
            this.Urls = n22._Operations_.CreateDefault<string>();
            this.__cp_VNgNWZqQya4L508TfqKGzE = n22._Operations_.CreateDefault<string>();
            this.__cp_V54SFICwvwKLC6nkuVxCWZ = n22._Operations_.CreateDefault<n43.Reference_C<bool>>();
            this.__cp_UW472ExcBz4QHLcexdW8iL = n22._Operations_.CreateDefault<n2.IObservable<T>>();
            this.__p_JFA6W7NtcFZMhzoBcYpbBr = Output_1;
            this.__loop_NmCPbdYk7mlMCbGQoD8rbX = default(n44.ImmutableLifetimeManager);
            return that_2;
        }

        public n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> Dispose_()
        {
            n21.Spread<string> __auto_0 = this.Urls;
            n14.AssetBuilderService_C __auto_1 = this.Builder;
            var i_4 = 0;
            foreach (var item_2 in n4.CollectionExtensions.AsSpan(__auto_0))
            {
                var splicer_3 = item_2;
                var i_local_5 = i_4;
                n14._Operations_.SafeUnloadAsset(Input_In: __auto_1, Url_In: splicer_3, Output_Out: out n14.AssetBuilderService_C Output_7);
                i_4++;
            }

            n1.CompilationHelper.SafeDispose(this.__p_JFA6W7NtcFZMhzoBcYpbBr);
            n1.CompilationHelper.SafeDispose(this.__loop_NmCPbdYk7mlMCbGQoD8rbX);
            return this;
        }

        public n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> __CreateDefault__()
        {
            n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> that_0 = this;
            this.Builder = n33._Operations_.CreateDefault();
            this.Urls = n22._Operations_.CreateDefault<string>();
            this.__cp_VNgNWZqQya4L508TfqKGzE = n22._Operations_.CreateDefault<string>();
            this.__cp_V54SFICwvwKLC6nkuVxCWZ = n22._Operations_.CreateDefault<n43.Reference_C<bool>>();
            this.__cp_UW472ExcBz4QHLcexdW8iL = n22._Operations_.CreateDefault<n2.IObservable<T>>();
            this.__p_JFA6W7NtcFZMhzoBcYpbBr = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            this.__loop_NmCPbdYk7mlMCbGQoD8rbX = default(n44.ImmutableLifetimeManager);
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 11947U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Ablq3NgE4OGLNsZ2SBXydu", Name = "__slot_Ablq3NgE4OGLNsZ2SBXydu")]
        public static string __slot_Ablq3NgE4OGLNsZ2SBXydu = "LoadProject: ";
        [n1.ElementAttribute(TracingId = 11886U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Hf3e6BJbjsCMOAfz0ve21A", Name = "Builder")]
        public n14.AssetBuilderService_C Builder;
        [n1.ElementAttribute(TracingId = 11884U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "MMRmmFgXzaHPQiObbxfY1z", Name = "Urls")]
        public n21.Spread<string> Urls;
        [n1.ElementAttribute(TracingId = 11875U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "JFA6W7NtcFZMhzoBcYpbBr", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_JFA6W7NtcFZMhzoBcYpbBr;
        [n1.ElementAttribute(TracingId = 11931U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NnsHviwuDK8NOhnPogWVJm", Name = "__slot_NnsHviwuDK8NOhnPogWVJm")]
        public static bool __slot_NnsHviwuDK8NOhnPogWVJm = false;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n44.ImmutableLifetimeManager __loop_NmCPbdYk7mlMCbGQoD8rbX;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<string> __cp_VNgNWZqQya4L508TfqKGzE;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<n43.Reference_C<bool>> __cp_V54SFICwvwKLC6nkuVxCWZ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n21.Spread<n2.IObservable<T>> __cp_UW472ExcBz4QHLcexdW8iL;
        static LoadProjectAssets_OvABOUW1t3OQFuniDviwsF()
        {
        }

        public LoadProjectAssets_OvABOUW1t3OQFuniDviwsF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LoadProjectAssets_OvABOUW1t3OQFuniDviwsF(LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> other): base(other)
        {
            this.Builder = other.Builder;
            this.Urls = other.Urls;
            this.__p_JFA6W7NtcFZMhzoBcYpbBr = other.__p_JFA6W7NtcFZMhzoBcYpbBr;
            this.__loop_NmCPbdYk7mlMCbGQoD8rbX = other.__loop_NmCPbdYk7mlMCbGQoD8rbX;
            this.__cp_VNgNWZqQya4L508TfqKGzE = other.__cp_VNgNWZqQya4L508TfqKGzE;
            this.__cp_V54SFICwvwKLC6nkuVxCWZ = other.__cp_V54SFICwvwKLC6nkuVxCWZ;
            this.__cp_UW472ExcBz4QHLcexdW8iL = other.__cp_UW472ExcBz4QHLcexdW8iL;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder", in Builder), n1.CompilationHelper.GetValueOrExisting(values, "Urls", in Urls), n1.CompilationHelper.GetValueOrExisting(values, "__p_JFA6W7NtcFZMhzoBcYpbBr", in __p_JFA6W7NtcFZMhzoBcYpbBr), n1.CompilationHelper.GetValueOrExisting(values, "__loop_NmCPbdYk7mlMCbGQoD8rbX", in __loop_NmCPbdYk7mlMCbGQoD8rbX), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VNgNWZqQya4L508TfqKGzE", in __cp_VNgNWZqQya4L508TfqKGzE), n1.CompilationHelper.GetValueOrExisting(values, "__cp_V54SFICwvwKLC6nkuVxCWZ", in __cp_V54SFICwvwKLC6nkuVxCWZ), n1.CompilationHelper.GetValueOrExisting(values, "__cp_UW472ExcBz4QHLcexdW8iL", in __cp_UW472ExcBz4QHLcexdW8iL));
        }

        internal LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> __WITH__(n14.AssetBuilderService_C Builder, n21.Spread<string> Urls, n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_JFA6W7NtcFZMhzoBcYpbBr, n44.ImmutableLifetimeManager __loop_NmCPbdYk7mlMCbGQoD8rbX, n21.Spread<string> __cp_VNgNWZqQya4L508TfqKGzE, n21.Spread<n43.Reference_C<bool>> __cp_V54SFICwvwKLC6nkuVxCWZ, n21.Spread<n2.IObservable<T>> __cp_UW472ExcBz4QHLcexdW8iL)
        {
            n14.LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T> that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Builder != this.Builder || Urls != this.Urls || __p_JFA6W7NtcFZMhzoBcYpbBr != this.__p_JFA6W7NtcFZMhzoBcYpbBr || __loop_NmCPbdYk7mlMCbGQoD8rbX != this.__loop_NmCPbdYk7mlMCbGQoD8rbX || __cp_VNgNWZqQya4L508TfqKGzE != this.__cp_VNgNWZqQya4L508TfqKGzE || __cp_V54SFICwvwKLC6nkuVxCWZ != this.__cp_V54SFICwvwKLC6nkuVxCWZ || __cp_UW472ExcBz4QHLcexdW8iL != this.__cp_UW472ExcBz4QHLcexdW8iL ? new LoadProjectAssets_OvABOUW1t3OQFuniDviwsF<T>(this)
                {Builder = Builder, Urls = Urls, __p_JFA6W7NtcFZMhzoBcYpbBr = __p_JFA6W7NtcFZMhzoBcYpbBr, __loop_NmCPbdYk7mlMCbGQoD8rbX = __loop_NmCPbdYk7mlMCbGQoD8rbX, __cp_VNgNWZqQya4L508TfqKGzE = __cp_VNgNWZqQya4L508TfqKGzE, __cp_V54SFICwvwKLC6nkuVxCWZ = __cp_V54SFICwvwKLC6nkuVxCWZ, __cp_UW472ExcBz4QHLcexdW8iL = __cp_UW472ExcBz4QHLcexdW8iL} : that_1;
            else
            {
                this.Builder = Builder;
                this.Urls = Urls;
                this.__p_JFA6W7NtcFZMhzoBcYpbBr = __p_JFA6W7NtcFZMhzoBcYpbBr;
                this.__loop_NmCPbdYk7mlMCbGQoD8rbX = __loop_NmCPbdYk7mlMCbGQoD8rbX;
                this.__cp_VNgNWZqQya4L508TfqKGzE = __cp_VNgNWZqQya4L508TfqKGzE;
                this.__cp_V54SFICwvwKLC6nkuVxCWZ = __cp_V54SFICwvwKLC6nkuVxCWZ;
                this.__cp_UW472ExcBz4QHLcexdW8iL = __cp_UW472ExcBz4QHLcexdW8iL;
            }

            return that_1;
        }

        [n1.ElementAttribute(DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SkFpGmeBJlaMlU8hb54Gsi", Name = "__SkFpGmeBJlaMlU8hb54Gsi")]
        [n2.SerializableAttribute]
        public class __SkFpGmeBJlaMlU8hb54Gsi : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 11928U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "SlMMYtF7jHsLfbHDSsE6pH", Name = "Loading")]
            public n43.Reference_C<bool> Loading;
            public __SkFpGmeBJlaMlU8hb54Gsi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SkFpGmeBJlaMlU8hb54Gsi(__SkFpGmeBJlaMlU8hb54Gsi other): base(other)
            {
                this.Loading = other.Loading;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Loading", in Loading));
            }

            internal __SkFpGmeBJlaMlU8hb54Gsi __WITH__(n43.Reference_C<bool> Loading)
            {
                __SkFpGmeBJlaMlU8hb54Gsi that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = Loading != this.Loading ? new __SkFpGmeBJlaMlU8hb54Gsi(this)
                    {Loading = Loading} : that_0;
                else
                {
                    this.Loading = Loading;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 12007U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "LwUfBt2Wmw6MkjxpnlUAkR", Name = "DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR")]
    [n2.SerializableAttribute]
    public class DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR Create(n1.NodeContext Node_Context)
        {
            var instance = new DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR CreateDefault()
        {
            var instance = new DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR Update(n17.IEnumerable<string> Urls_In)
        {
            n17.IEnumerable<string> __pad_Mba6ahtuQ25PW00XiwIfQZ_0 = Urls_In;
            var Output_2 = this.__p_L7jxwFguiBYQUUO85F5IWg.Update(Service_Out: out n14.AssetBuilderService_C Service_1);
            n14.AssetBuilderService_C __pad_CTNdZ6ONb1VLjoP1sj120e_3 = Service_1;
            var i_6 = 0;
            foreach (var item_4 in __pad_Mba6ahtuQ25PW00XiwIfQZ_0)
            {
                var splicer_5 = item_4;
                var i_local_7 = i_6;
                n14._Operations_.SafeUnloadAsset(Input_In: __pad_CTNdZ6ONb1VLjoP1sj120e_3, Url_In: splicer_5, Output_Out: out n14.AssetBuilderService_C Output_9);
                i_6++;
            }

            n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Urls_In != this.__slot_Mba6ahtuQ25PW00XiwIfQZ || Output_2 != this.__p_L7jxwFguiBYQUUO85F5IWg || Service_1 != this.__slot_CTNdZ6ONb1VLjoP1sj120e ? new DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(this)
                {__slot_Mba6ahtuQ25PW00XiwIfQZ = Urls_In, __p_L7jxwFguiBYQUUO85F5IWg = Output_2, __slot_CTNdZ6ONb1VLjoP1sj120e = Service_1} : that_10;
            else
            {
                this.__slot_Mba6ahtuQ25PW00XiwIfQZ = Urls_In;
                this.__p_L7jxwFguiBYQUUO85F5IWg = Output_2;
                this.__slot_CTNdZ6ONb1VLjoP1sj120e = Service_1;
            }

            return that_10;
        }

        public n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "L7jxwFguiBYQUUO85F5IWg", 12010U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR that_2 = this;
            this.__slot_CTNdZ6ONb1VLjoP1sj120e = n33._Operations_.CreateDefault();
            this.__slot_Mba6ahtuQ25PW00XiwIfQZ = n34._Operations_.CreateDefault<string>();
            this.__p_L7jxwFguiBYQUUO85F5IWg = Output_1;
            return that_2;
        }

        public n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR __CreateDefault__()
        {
            n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR that_0 = this;
            this.__slot_CTNdZ6ONb1VLjoP1sj120e = n33._Operations_.CreateDefault();
            this.__slot_Mba6ahtuQ25PW00XiwIfQZ = n34._Operations_.CreateDefault<string>();
            this.__p_L7jxwFguiBYQUUO85F5IWg = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_L7jxwFguiBYQUUO85F5IWg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 12025U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "CTNdZ6ONb1VLjoP1sj120e", Name = "__slot_CTNdZ6ONb1VLjoP1sj120e")]
        public n14.AssetBuilderService_C __slot_CTNdZ6ONb1VLjoP1sj120e;
        [n1.ElementAttribute(TracingId = 12026U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Mba6ahtuQ25PW00XiwIfQZ", Name = "__slot_Mba6ahtuQ25PW00XiwIfQZ")]
        public n17.IEnumerable<string> __slot_Mba6ahtuQ25PW00XiwIfQZ;
        [n1.ElementAttribute(TracingId = 12010U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "L7jxwFguiBYQUUO85F5IWg", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_L7jxwFguiBYQUUO85F5IWg;
        public DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR other): base(other)
        {
            this.__slot_CTNdZ6ONb1VLjoP1sj120e = other.__slot_CTNdZ6ONb1VLjoP1sj120e;
            this.__slot_Mba6ahtuQ25PW00XiwIfQZ = other.__slot_Mba6ahtuQ25PW00XiwIfQZ;
            this.__p_L7jxwFguiBYQUUO85F5IWg = other.__p_L7jxwFguiBYQUUO85F5IWg;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_CTNdZ6ONb1VLjoP1sj120e", in __slot_CTNdZ6ONb1VLjoP1sj120e), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Mba6ahtuQ25PW00XiwIfQZ", in __slot_Mba6ahtuQ25PW00XiwIfQZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_L7jxwFguiBYQUUO85F5IWg", in __p_L7jxwFguiBYQUUO85F5IWg));
        }

        internal DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR __WITH__(n14.AssetBuilderService_C __slot_CTNdZ6ONb1VLjoP1sj120e, n17.IEnumerable<string> __slot_Mba6ahtuQ25PW00XiwIfQZ, n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_L7jxwFguiBYQUUO85F5IWg)
        {
            n14.DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_CTNdZ6ONb1VLjoP1sj120e != this.__slot_CTNdZ6ONb1VLjoP1sj120e || __slot_Mba6ahtuQ25PW00XiwIfQZ != this.__slot_Mba6ahtuQ25PW00XiwIfQZ || __p_L7jxwFguiBYQUUO85F5IWg != this.__p_L7jxwFguiBYQUUO85F5IWg ? new DisposeLoadedProjectAssets_LwUfBt2Wmw6MkjxpnlUAkR(this)
                {__slot_CTNdZ6ONb1VLjoP1sj120e = __slot_CTNdZ6ONb1VLjoP1sj120e, __slot_Mba6ahtuQ25PW00XiwIfQZ = __slot_Mba6ahtuQ25PW00XiwIfQZ, __p_L7jxwFguiBYQUUO85F5IWg = __p_L7jxwFguiBYQUUO85F5IWg} : that_0;
            else
            {
                this.__slot_CTNdZ6ONb1VLjoP1sj120e = __slot_CTNdZ6ONb1VLjoP1sj120e;
                this.__slot_Mba6ahtuQ25PW00XiwIfQZ = __slot_Mba6ahtuQ25PW00XiwIfQZ;
                this.__p_L7jxwFguiBYQUUO85F5IWg = __p_L7jxwFguiBYQUUO85F5IWg;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 4382U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TextureAssetFromFile(n5.Path Filename_In, bool Generate_Mipmaps_In, bool Is_Compressed_In, bool Is_Streamable_In, string Url_In, n47.ITextureType Type_In, out n47.TextureAsset Asset_Out)
        {
            var Output_0 = new n47.TextureAsset();
            Output_0.IsCompressed = Is_Compressed_In;
            Output_0.GenerateMipmaps = Generate_Mipmaps_In;
            Output_0.IsStreamable = Is_Streamable_In;
            Output_0.Type = Type_In;
            n14._Operations_.PathToUFile(Input_In: Filename_In, Output_Out: out n38.UFile Output_1);
            Output_0.Source = Output_1;
            var Url_Namespace_2 = n48.GuidUtility.UrlNamespace;
            var Output_3 = n48.GuidUtility.Create(namespaceId: Url_Namespace_2, name: Url_In);
            var Output_4 = new n49.AssetId(guid: Output_3);
            Output_0.Id = Output_4;
            Asset_Out = Output_0;
            return;
        }

        public static void VideoAssetFromFile(n5.Path Filename_In, out n50.VideoAsset Asset_Out)
        {
            var Result_0 = (string)Filename_In;
            var Url_Namespace_1 = n48.GuidUtility.UrlNamespace;
            var Output_2 = n48.GuidUtility.Create(namespaceId: Url_Namespace_1, name: Result_0);
            var Output_3 = new n49.AssetId(guid: Output_2);
            var Output_4 = new n50.VideoAsset();
            n14._Operations_.PathToUFile(Input_In: Filename_In, Output_Out: out n38.UFile Output_5);
            Output_4.Source = Output_5;
            Output_4.Id = Output_3;
            Asset_Out = Output_4;
            return;
        }

        public static void SoundAssetFromFile(n5.Path Filename_In, bool Spatialized_In, bool Stream_From_Disk_In, out n50.SoundAsset Asset_Out)
        {
            var Result_0 = (string)Filename_In;
            var Url_Namespace_1 = n48.GuidUtility.UrlNamespace;
            var Output_2 = n48.GuidUtility.Create(namespaceId: Url_Namespace_1, name: Result_0);
            var Output_3 = new n49.AssetId(guid: Output_2);
            var Output_4 = new n50.SoundAsset();
            Output_4.StreamFromDisk = Stream_From_Disk_In;
            Output_4.Spatialized = Spatialized_In;
            n14._Operations_.PathToUFile(Input_In: Filename_In, Output_Out: out n38.UFile Output_5);
            Output_4.Source = Output_5;
            Output_4.Id = Output_3;
            Asset_Out = Output_4;
            return;
        }

        public static void ModelAssetFromFile(n5.Path Filename_In, float Inport_Scale_In, n53.Vector3 Pivot_Position_In, string Url_In, bool Merge_Meshes_In, out n52.ModelAsset Model_Asset_Out)
        {
            var Output_0 = new n52.ModelAsset();
            n14._Operations_.PathToUFile(Input_In: Filename_In, Output_Out: out n38.UFile Output_1);
            Output_0.Source = Output_1;
            Output_0.ScaleImport = Inport_Scale_In;
            Output_0.PivotPosition = Pivot_Position_In;
            Output_0.MergeMeshes = Merge_Meshes_In;
            var Url_Namespace_2 = n48.GuidUtility.UrlNamespace;
            var Output_3 = n48.GuidUtility.Create(namespaceId: Url_Namespace_2, name: Url_In);
            var Output_4 = new n49.AssetId(guid: Output_3);
            Output_0.Id = Output_4;
            Model_Asset_Out = Output_0;
            return;
        }

        public static void CreateColorTextureType([n4.SerializedDefaultValueAttribute("True", false)] bool Is_sRGB_In, bool Premultiply_Alpha_In, [n4.SerializedDefaultValueAttribute("Auto", false)] n47.AlphaFormat Alpha_Format_In, bool Color_Key_Enabled_In, [n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n53.Color4 Color_Key_Color_In, out n47.ColorTextureType Output_Out)
        {
            var Output_0 = new n47.ColorTextureType();
            Output_0.UseSRgbSampling = Is_sRGB_In;
            Output_0.PremultiplyAlpha = Premultiply_Alpha_In;
            Output_0.Alpha = Alpha_Format_In;
            Output_0.ColorKeyEnabled = Color_Key_Enabled_In;
            var Result_1 = (n53.Color)Color_Key_Color_In;
            Output_0.ColorKeyColor = Result_1;
            Output_Out = Output_0;
            return;
        }

        public static void CreateGrayscaleTextureType(out n47.GrayscaleTextureType Output_Out)
        {
            var Output_0 = new n47.GrayscaleTextureType();
            Output_Out = Output_0;
            return;
        }

        public static void CreateNormalMapTextureType(bool Invert_Y_In, out n47.NormapMapTextureType Output_Out)
        {
            var Output_0 = new n47.NormapMapTextureType();
            Output_0.InvertY = Invert_Y_In;
            Output_Out = Output_0;
            return;
        }

        public static void PathToUFile(n5.Path Input_In, out n38.UFile Output_Out)
        {
            var Result_0 = (string)Input_In;
            var Output_1 = new n38.UFile(filePath: Result_0);
            Output_Out = Output_1;
            return;
        }

        public static void ToAssetReference(n13.AssetItem Input_In, out n13.AssetReference Output_Out)
        {
            var Id_0 = Input_In.Id;
            var Location_1 = Input_In.Location;
            var Output_2 = new n13.AssetReference(id: Id_0, location: Location_1);
            Output_Out = Output_2;
            return;
        }

        public static void CreateRuntimePackage(out n13.Package Output_Out)
        {
            n5.Path __pad_NBTgJ28Fc43LXar5lZzOXU_0 = __slot_NBTgJ28Fc43LXar5lZzOXU;
            string __pad_RMTJS9uSJB2M0Dkz3W4ySF_1 = __slot_RMTJS9uSJB2M0Dkz3W4ySF;
            string __pad_E2pFbkO6GWIL8tUnIaE5Xh_2 = __slot_E2pFbkO6GWIL8tUnIaE5Xh;
            var Output_3 = new n13.Package();
            var Meta_4 = Output_3.Meta;
            n14._Operations_.PathToUFile(Input_In: __pad_NBTgJ28Fc43LXar5lZzOXU_0, Output_Out: out n38.UFile Output_5);
            Output_3.FullPath = Output_5;
            Meta_4.Name = __pad_RMTJS9uSJB2M0Dkz3W4ySF_1;
            var Output_6 = new n40.PackageVersion(version: __pad_E2pFbkO6GWIL8tUnIaE5Xh_2);
            Meta_4.Version = Output_6;
            Output_Out = Output_3;
            return;
        }

        public static void SubscribeToBuildEvent<T, AdM>(n14.AssetBuilderService_C Input_In, n38.UFile Location_In, string Name_In, string Logger_Prefix_In, out n2.IObservable<T> Output_Out)
            where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Output_2 = Input_In.GetAssetBuiltEvent(On_Asset_Built_Out: out n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> On_Asset_Built_1);
            var __fallback___3 = n1.ServiceRegistry.Current;
            n27._Operations_.Where<n2.Tuple<n26.ReloadingAsset, n2.Object>>(Input_In: On_Asset_Built_1, Predicate_In: (n2.Tuple<n26.ReloadingAsset, n2.Object> Arg_In_5) =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                n55._Operations_.Item1<n26.ReloadingAsset, n2.Object>(Input_In: Arg_In_5, Item_1_Out: out n26.ReloadingAsset Item_1_6);
                var Asset_Item_7 = Item_1_6.AssetItem;
                var Location_8 = Asset_Item_7.Location;
                var Result_9 = n12.ObjectHelpers.Eq(input: Location_8, input2: Location_In);
                return Result_9;
            }

            , Output_Out: out n2.IObservable<n2.Tuple<n26.ReloadingAsset, n2.Object>> Output_10);
            n27._Operations_.Select<n2.Tuple<n26.ReloadingAsset, n2.Object>, T>(Input_In: Output_10, Selector_In: (n2.Tuple<n26.ReloadingAsset, n2.Object> Arg_1_In_12, int Arg_2_In_13) =>
            {
                using var __current_11 = __fallback___3.MakeCurrentIfNone();
                n55._Operations_.Item2<n26.ReloadingAsset, n2.Object>(Input_In: Arg_1_In_12, Item_2_Out: out n2.Object Item_2_14);
                w_0.CreateDefault(Output_Out: out T Output_15);
                n39._Operations_.CastAs<T>(Input_In: Item_2_14, Default_In: Output_15, Result_Out: out T Result_16, Success_Out: out bool Success_17);
                n14._Operations_.SetFriendlyName<T>(Input_In: Result_16, Name_In: Name_In, Output_Out: out T Output_18);
                n39._Operations_.AsObject<T>(Input_In: Output_18, Result_Out: out n2.Object Result_19);
                var Result_20 = n12.ObjectHelpers.ToString(input: Result_19);
                var Output_21 = n30.StringExtensions.Plus(input: Logger_Prefix_In, input2: Result_20);
                bool Apply_22 = true;
                if (Apply_22)
                {
                    n2.Console.WriteLine(value: Output_21);
                }

                return Result_16;
            }

            , Output_Out: out n2.IObservable<T> Output_23);
            Output_Out = Output_23;
            return;
        }

        public static void TryLoadExisting<T, AdM>(n14.AssetBuilderService_C Input_In, string Url_In, bool Reload_In, out n6.AssetWrapper<T> Result_Out, out bool Loaded_Out)
            where T : class where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var Output_2 = Input_In.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_1);
            var Content_Manager_3 = Content_Loader_1.ContentManager;
            bool Loaded_Manually_Only_4 = false;
            var Result_5 = Content_Manager_3.IsLoaded(url: Url_In, loadedManuallyOnly: Loaded_Manually_Only_4);
            var Output_6 = !Reload_In;
            var Output_7 = Result_5 && Output_6;
            var Result_8 = Content_Loader_1.GetOrCreateAssetWrapper<T>(url: Url_In);
            if (Output_7)
            {
                n56.ContentManagerLoaderSettings Settings_9 = default(n56.ContentManagerLoaderSettings);
                var Result_10 = Content_Manager_3.Load<T>(url: Url_In, settings: Settings_9);
                Result_8.GetValues(asset: out T Asset_11, exists: out bool Exists_12, loading: out bool Loading_13);
                w_0.CreateDefault(Output_Out: out T Output_14);
                w_0.CreateDefault(Output_Out: out T Output_15);
                n57._Operations_.ConstrainTypes<T>(Input_In: Asset_11, Input_2_In: Result_10, Input_3_In: Output_14, Input_4_In: Output_15);
            }

            Result_Out = Result_8;
            Loaded_Out = Result_5;
            return;
        }

        public static void AssetFromFile(string Filename_In, n60.IResourceProvider<n11.Stream> File_In, out n13.Asset Result_Out)
        {
            var Output_0 = n11.Path.GetExtension(path: Filename_In);
            var Output_1 = Output_0.ToLowerInvariant();
            var Result_2 = n13.AssetFileSerializer.FindSerializer(assetFileExtension: Output_1);
            n12.ObjectHelpers.IsAssigned(x: Result_2, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            var Result_5 = n11.File.Exists(path: Filename_In);
            var Output_6 = Result_3 && Result_5;
            n13.Asset __auto_7;
            if (Output_6)
            {
                var Output_8 = new n38.UFile(filePath: Filename_In);
                var __fallback___9 = n1.ServiceRegistry.Current;
                n59._Operations_.Using_Select<n11.Stream, n13.Asset>(Input_In: File_In, Extractor_In: (n11.Stream Arg_In_11) =>
                {
                    using var __current_10 = __fallback___9.MakeCurrentIfNone();
                    n25.ILogger Log_12 = default(n25.ILogger);
                    bool Clear_Broken_Object_References_13 = true;
                    var Result_16 = ((n58.IAssetSerializer)Result_2).Load(stream: Arg_In_11, filePath: Output_8, log: Log_12, clearBrokenObjectReferences: Clear_Broken_Object_References_13, aliasOccurred: out bool Alias_Occurred_14, yamlMetadata: out n51.AttachedYamlAssetMetadata Yaml_Metadata_15);
                    n39._Operations_.HardCast<n13.Asset>(Input_In: Result_16, Result_Out: out n13.Asset Result_17);
                    return Result_17;
                }

                , Result_Out: out n13.Asset Result_18);
                __auto_7 = Result_18;
            }
            else
            {
                __auto_7 = default(n13.Asset);
            }

            Result_Out = __auto_7;
            return;
        }

        public static void GetUniqueAssetURL(n5.Path Input_In, n2.Object Hash_Object_In, out string Output_Out, out string Directory_Out, out string Name_Out)
        {
            string __pad_AbVlBluladJO3eEbSXpn8T_0 = __slot_AbVlBluladJO3eEbSXpn8T;
            string __pad_EuLgBFU7JM7QSbpPcdeMDG_1 = __slot_EuLgBFU7JM7QSbpPcdeMDG;
            string __pad_CybcZttnafmMGStbC1K5ej_2 = __slot_CybcZttnafmMGStbC1K5ej;
            string __pad_Vf55temwgchOYui8RtHR5j_3 = __slot_Vf55temwgchOYui8RtHR5j;
            var Result_4 = Hash_Object_In.GetHashCode();
            var Result_5 = n12.ObjectHelpers.ToString(input: Result_4);
            var Result_6 = (string)Input_In;
            n63._Operations_.Replace(Input_In: Result_6, Old_Value_In: __pad_AbVlBluladJO3eEbSXpn8T_0, New_Value_In: __pad_EuLgBFU7JM7QSbpPcdeMDG_1, Output_Out: out string Output_7);
            n63._Operations_.Replace(Input_In: Output_7, Old_Value_In: __pad_CybcZttnafmMGStbC1K5ej_2, New_Value_In: __pad_Vf55temwgchOYui8RtHR5j_3, Output_Out: out string Output_8);
            var Result_9 = string.IsNullOrWhiteSpace(value: Output_8);
            var Output_10 = !Result_9;
            string __auto_11;
            if (Output_10)
            {
                var Output_12 = n30.StringExtensions.Plus(input: Output_8, input2: __pad_Vf55temwgchOYui8RtHR5j_3);
                var Output_13 = n30.StringExtensions.Plus(input: Output_12, input2: Result_5);
                __auto_11 = Output_13;
            }
            else
            {
                __auto_11 = Result_5;
            }

            Input_In.Filename(directory: out string Directory_14, filename: out string Filename_15, extension: out string Extension_16);
            var Output_17 = n30.StringExtensions.Plus(input: Filename_15, input2: Extension_16);
            Output_Out = __auto_11;
            Directory_Out = Directory_14;
            Name_Out = Output_17;
            return;
        }

        public static void SetFriendlyName<T>(T Input_In, string Name_In, out T Output_Out)
        {
            n29.ComponentBase Default_0 = default(n29.ComponentBase);
            n39._Operations_.CastAs_Generic<T, n29.ComponentBase>(Input_In: Input_In, Default_In: Default_0, Result_Out: out n29.ComponentBase Result_1, Success_Out: out bool Success_2);
            var Result_3 = string.IsNullOrWhiteSpace(value: Name_In);
            var Output_4 = !Result_3;
            var Output_5 = Success_2 && Output_4;
            var Output_6 = Result_1;
            if (Output_5)
            {
                Result_1.Name = Name_In;
            }

            Output_Out = Input_In;
            return;
        }

        public static void UnloadFromContent(n56.ContentManager Content_Manager_In, string Url_In)
        {
            n12.ObjectHelpers.IsAssigned(x: Content_Manager_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            if (Result_0)
            {
                bool __pad_L9WSWJZWR0rOUCAwTXUKQX_2 = __slot_L9WSWJZWR0rOUCAwTXUKQX;
                var Result_3 = Content_Manager_In.IsLoaded(url: Url_In, loadedManuallyOnly: __pad_L9WSWJZWR0rOUCAwTXUKQX_2);
                if (Result_3)
                {
                    n56.ContentManager Default_Output_4 = default(n56.ContentManager);
                    var __fallback___5 = n1.ServiceRegistry.Current;
                    n64._Operations_.Try_Stateless<n56.ContentManager>(Default_Output_In: Default_Output_4, Try_In: () =>
                    {
                        using var __current_6 = __fallback___5.MakeCurrentIfNone();
                        Content_Manager_In.Unload(url: Url_In);
                        return Content_Manager_In;
                    }

                    , Result_Out: out n56.ContentManager Result_7, Success_Out: out bool Success_8, Error_Message_Out: out string Error_Message_9);
                }
            }

            return;
        }

        public static void SafeUnloadAsset(n14.AssetBuilderService_C Input_In, string Url_In, out n14.AssetBuilderService_C Output_Out)
        {
            bool Default_Output_0 = false;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n64._Operations_.Try_Stateless<bool>(Default_Output_In: Default_Output_0, Try_In: () =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                bool __pad_LBsMJiZnpumOsHC5RZjwmB_3 = __slot_LBsMJiZnpumOsHC5RZjwmB;
                int __pad_T5KBQaIMFT1OTC8aJkJcyO_4 = __slot_T5KBQaIMFT1OTC8aJkJcyO;
                var Output_6 = Input_In.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_5);
                var Content_Manager_7 = Content_Loader_5.ContentManager;
                for (var i_8 = 0; i_8 < __pad_T5KBQaIMFT1OTC8aJkJcyO_4; i_8++)
                {
                    var i_local_9 = i_8;
                    bool Loaded_Manually_Only_10 = false;
                    var Result_11 = Content_Manager_7.IsLoaded(url: Url_In, loadedManuallyOnly: Loaded_Manually_Only_10);
                    var Output_12 = !Result_11;
                    var Output_13 = Content_Loader_5;
                    if (Result_11)
                    {
                        Content_Loader_5.UnloadContent(url: Url_In);
                    }

                    if (Output_12)
                    {
                        break;
                    }
                }

                return __pad_LBsMJiZnpumOsHC5RZjwmB_3;
            }

            , Result_Out: out bool Result_14, Success_Out: out bool Success_15, Error_Message_Out: out string Error_Message_16);
            Output_Out = Input_In;
            return;
        }

        public static void FilterAssets(n17.IEnumerable<n13.AssetItem> Input_In, n2.Type Excluded_Type_In, out n17.IEnumerable<n13.AssetItem> Output_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n34._Operations_.Where<n13.AssetItem>(Input_In: Input_In, Predicate_In: (n13.AssetItem Arg_1_In_2, int Arg_2_In_3) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Asset_4 = Arg_1_In_2.Asset;
                n39._Operations_.GetType(Input_In: Asset_4, Output_Out: out n2.Type Output_5);
                var Result_6 = Excluded_Type_In.IsAssignableFrom(c: Output_5);
                var Output_7 = !Result_6;
                return Output_7;
            }

            , Output_Out: out n17.IEnumerable<n13.AssetItem> Output_8);
            Output_Out = Output_8;
            return;
        }

        public static void OrderAssets(n17.IEnumerable<n13.AssetItem> Input_In, out n21.Spread<n13.AssetItem> Result_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n34._Operations_.OrderBy<n13.AssetItem, n38.UFile>(Input_In: Input_In, Key_Selector_In: (n13.AssetItem Arg_In_2) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Location_3 = Arg_In_2.Location;
                return Location_3;
            }

            , Result_Out: out n65.IOrderedEnumerable<n13.AssetItem> Result_4);
            n17.IEnumerable<n13.AssetItem> Input_5 = (n17.IEnumerable<n13.AssetItem>)Result_4;
            n22._Operations_.FromSequence<n13.AssetItem>(Input_In: Input_5, Result_Out: out n21.Spread<n13.AssetItem> Result_6);
            Result_Out = Result_6;
            return;
        }

        [n1.ElementAttribute(TracingId = 7234U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "NBTgJ28Fc43LXar5lZzOXU", Name = "__slot_NBTgJ28Fc43LXar5lZzOXU")]
        public static n5.Path __slot_NBTgJ28Fc43LXar5lZzOXU = n1.CompilationHelper.Deserialize<n5.Path>("", false, "OpwXTKxodpcLMuzoaGSQfF", "NBTgJ28Fc43LXar5lZzOXU");
        [n1.ElementAttribute(TracingId = 7202U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "RMTJS9uSJB2M0Dkz3W4ySF", Name = "__slot_RMTJS9uSJB2M0Dkz3W4ySF")]
        public static string __slot_RMTJS9uSJB2M0Dkz3W4ySF = "VLRuntimeAssets";
        [n1.ElementAttribute(TracingId = 7210U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "E2pFbkO6GWIL8tUnIaE5Xh", Name = "__slot_E2pFbkO6GWIL8tUnIaE5Xh")]
        public static string __slot_E2pFbkO6GWIL8tUnIaE5Xh = "1.0.0.0";
        [n1.ElementAttribute(TracingId = 9338U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "AbVlBluladJO3eEbSXpn8T", Name = "__slot_AbVlBluladJO3eEbSXpn8T")]
        public static string __slot_AbVlBluladJO3eEbSXpn8T = ":";
        [n1.ElementAttribute(TracingId = 9345U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "EuLgBFU7JM7QSbpPcdeMDG", Name = "__slot_EuLgBFU7JM7QSbpPcdeMDG")]
        public static string __slot_EuLgBFU7JM7QSbpPcdeMDG = "";
        [n1.ElementAttribute(TracingId = 9358U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "CybcZttnafmMGStbC1K5ej", Name = "__slot_CybcZttnafmMGStbC1K5ej")]
        public static string __slot_CybcZttnafmMGStbC1K5ej = "\\";
        [n1.ElementAttribute(TracingId = 9363U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "Vf55temwgchOYui8RtHR5j", Name = "__slot_Vf55temwgchOYui8RtHR5j")]
        public static string __slot_Vf55temwgchOYui8RtHR5j = "/";
        [n1.ElementAttribute(TracingId = 10179U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "L9WSWJZWR0rOUCAwTXUKQX", Name = "__slot_L9WSWJZWR0rOUCAwTXUKQX")]
        public static bool __slot_L9WSWJZWR0rOUCAwTXUKQX = true;
        [n1.ElementAttribute(TracingId = 12052U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "LBsMJiZnpumOsHC5RZjwmB", Name = "__slot_LBsMJiZnpumOsHC5RZjwmB")]
        public static bool __slot_LBsMJiZnpumOsHC5RZjwmB = true;
        [n1.ElementAttribute(TracingId = 12207U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "T5KBQaIMFT1OTC8aJkJcyO", Name = "__slot_T5KBQaIMFT1OTC8aJkJcyO")]
        public static int __slot_T5KBQaIMFT1OTC8aJkJcyO = 999;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride.Assets.AssetBuilderService.Internal
{
    [n1.ElementAttribute(TracingId = 4382U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void EnsureAbsolutePath(n13.AssetItem Asset_Item_In, n25.ILogger Logger_In, out n13.AssetItem Asset_Item_Out)
        {
            var Output_0 = new n62.AssetAnalysisParameters();
            bool Value_1 = true;
            Output_0.IsProcessingUPaths = Value_1;
            n38.UPathType Value_2 = default(n38.UPathType);
            Output_0.ConvertUPathTo = Value_2;
            n62.AssetAnalysis.Run(assetItem: Asset_Item_In, log: Logger_In, parameters: Output_0);
            Asset_Item_Out = Asset_Item_In;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n14.AssetBuilderService_C CreateDefault()
        {
            string __pad_CuVoZp6xL1VLXxGf0onPIM_0 = __slot_CuVoZp6xL1VLXxGf0onPIM;
            n39._Operations_.NULL<n14.AssetBuilderService_C>(Result_Out: out n14.AssetBuilderService_C Result_1);
            return Result_1;
        }

        [n1.ElementAttribute(TracingId = 7577U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "CuVoZp6xL1VLXxGf0onPIM", Name = "__slot_CuVoZp6xL1VLXxGf0onPIM")]
        public static string __slot_CuVoZp6xL1VLXxGf0onPIM = "inportant to not create a new one each frame for unconnected input pins";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride.Assets.ExistingProject.Internal
{
    [n1.ElementAttribute(TracingId = 4382U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void AddProjectReference(n13.Package Package_In, n2.Object Input_In, out n13.DependencyRange Dependency_Out)
        {
            n13.SolutionProject Default_0 = default(n13.SolutionProject);
            n39._Operations_.CastAs<n13.SolutionProject>(Input_In: Input_In, Default_In: Default_0, Result_Out: out n13.SolutionProject Result_1, Success_Out: out bool Success_2);
            var Full_Path_3 = Result_1.FullPath;
            var Result_4 = n12.ObjectHelpers.ToString(input: Full_Path_3);
            var Meta_5 = Package_In.Meta;
            var Version_6 = Meta_5.Version;
            bool Min_Version_Inclusive_7 = true;
            var Output_8 = new n40.PackageVersionRange(minVersion: Version_6, minVersionInclusive: Min_Version_Inclusive_7);
            string Name_9 = "";
            n13.DependencyType Type_10 = __c_IrvdyPpKk7NMmUpwgFFhlf;
            var Output_11 = new n13.DependencyRange(name: Name_9, versionRange: Output_8, type: Type_10);
            Output_11.MSBuildProject = Result_4;
            var Container_12 = Package_In.Container;
            var Direct_Dependencies_13 = Container_12.DirectDependencies;
            n42._Operations_.Contains<n13.DependencyRange>(Input_In: Direct_Dependencies_13, Item_In: Output_11, Output_2_Out: out n41.Collection<n13.DependencyRange> Output_2_14, Result_Out: out bool Result_15);
            var Output_16 = !Result_15;
            if (Output_16)
            {
                n42._Operations_.Add<n13.DependencyRange>(Input_In: Direct_Dependencies_13, Item_In: Output_11, Output_2_Out: out n41.Collection<n13.DependencyRange> Output_2_17);
            }

            Dependency_Out = Output_11;
            return;
        }

        public static void RemoveProject(n13.PackageSession Runtime_Package_Session_In, n13.PackageContainer Project_In, out n13.PackageSession Package_Session_Out)
        {
            var Projects_0 = Runtime_Package_Session_In.Projects;
            n42._Operations_.Remove<n13.PackageContainer>(Input_In: Projects_0, Item_In: Project_In, Output_2_Out: out n41.Collection<n13.PackageContainer> Output_2_1, Result_Out: out bool Result_2);
            Package_Session_Out = Runtime_Package_Session_In;
            return;
        }

        public static void SafeRemoveProject(n13.PackageSession Runtime_Package_Session_In, n13.PackageContainer Project_In, out n13.PackageSession Package_Session_Out)
        {
            n12.ObjectHelpers.IsAssigned(x: Runtime_Package_Session_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n12.ObjectHelpers.IsAssigned(x: Project_In, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            bool Input_4 = true;
            bool Input_3_5 = true;
            var Output_6 = Input_4 && Result_0;
            var Output_7 = Output_6 && Input_3_5;
            var Output_8 = Output_7 && Result_2;
            n13.PackageSession __auto_9;
            if (Output_8)
            {
                n37._Operations_.RemoveProject(Runtime_Package_Session_In: Runtime_Package_Session_In, Project_In: Project_In, Package_Session_Out: out n13.PackageSession Package_Session_10);
                __auto_9 = Package_Session_10;
            }
            else
            {
                __auto_9 = Runtime_Package_Session_In;
            }

            Package_Session_Out = __auto_9;
            return;
        }

        public static void SetDirtyFlags(n13.PackageContainer Input_In, out n13.PackageContainer Output_Out)
        {
            var Package_0 = Input_In.Package;
            bool Value_1 = true;
            Package_0.IsDirty = Value_1;
            var Assets_2 = Package_0.Assets;
            var i_5 = 0;
            foreach (var item_3 in Assets_2)
            {
                var splicer_4 = item_3;
                var i_local_6 = i_5;
                bool Value_7 = true;
                splicer_4.IsDirty = Value_7;
                i_5++;
            }

            Output_Out = Input_In;
            return;
        }

        public static void SafeRemoveNewProject(n13.PackageSession Runtime_Package_Session_In, n38.UFile New_Project_File_Path_In, out n13.PackageSession Package_Session_Out)
        {
            n12.ObjectHelpers.IsAssigned(x: Runtime_Package_Session_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            bool Input_2 = true;
            var Output_3 = Input_2 && Result_0;
            var Result_4 = New_Project_File_Path_In.GetFileNameWithoutExtension();
            n13.PackageSession __auto_5;
            if (Output_3)
            {
                var Projects_6 = Runtime_Package_Session_In.Projects;
                __auto_5 = Runtime_Package_Session_In;
                n45.IEnumerable Input_7 = (n45.IEnumerable)Projects_6;
                n34._Operations_.OfType<n13.PackageContainer>(Input_In: Input_7, Result_Out: out n17.IEnumerable<n13.PackageContainer> Result_8);
                var __fallback___9 = n1.ServiceRegistry.Current;
                n34._Operations_.Where<n13.PackageContainer>(Input_In: Result_8, Predicate_In: (n13.PackageContainer Arg_1_In_11, int Arg_2_In_12) =>
                {
                    using var __current_10 = __fallback___9.MakeCurrentIfNone();
                    var Package_13 = Arg_1_In_11.Package;
                    var Full_Path_14 = Package_13.FullPath;
                    var Result_15 = Full_Path_14.GetFileNameWithoutExtension();
                    var Result_16 = Result_15 == Result_4;
                    return Result_16;
                }

                , Output_Out: out n17.IEnumerable<n13.PackageContainer> Output_17);
                n22._Operations_.FromSequence<n13.PackageContainer>(Input_In: Output_17, Result_Out: out n21.Spread<n13.PackageContainer> Result_18);
                var i_21 = 0;
                foreach (var item_19 in n4.CollectionExtensions.AsSpan(Result_18))
                {
                    var splicer_20 = item_19;
                    var i_local_22 = i_21;
                    n37._Operations_.SafeRemoveProject(Runtime_Package_Session_In: Runtime_Package_Session_In, Project_In: splicer_20, Package_Session_Out: out n13.PackageSession Package_Session_23);
                    i_21++;
                }
            }
            else
            {
                __auto_5 = Runtime_Package_Session_In;
            }

            Package_Session_Out = __auto_5;
            return;
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.DependencyType __c_IrvdyPpKk7NMmUpwgFFhlf = n1.CompilationHelper.Deserialize<n13.DependencyType>("Project", false, "OpwXTKxodpcLMuzoaGSQfF", "IrvdyPpKk7NMmUpwgFFhlf");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride.Assets.Advanced
{
    [n1.ElementAttribute(TracingId = 12532U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VgZeOO9CcieL8y7OwiEllS", Name = "RuntimeAsset_VgZeOO9CcieL8y7OwiEllS")]
    [n2.SerializableAttribute]
    public class RuntimeAsset_VgZeOO9CcieL8y7OwiEllS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS Create(n1.NodeContext Node_Context)
        {
            var instance = new RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS CreateDefault()
        {
            var instance = new RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS Update<T2, T, AdM>([n4.SerializedDefaultValueAttribute("True", false)] bool Build_In, bool Reload_In, string Url_In, n2.Func<n13.Package, T2> Create_Asset_In, string Source_Folder_In, string Name_In, out n6.AssetWrapper<T> Wrapper_Out, out bool Already_Loaded_Out)
            where T2 : n13.Asset where T : class where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            var Output_9 = this.__p_HEshEiOWzxwPFhRtov567v.Update<T, AdM>(Build_In: Build_In, Reload_In: Reload_In, Url_In: Url_In, Source_Folder_In: Source_Folder_In, Name_In: Name_In, Create_Asset_Item_In: (n13.Package Input_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                n46._Operations_.Invoke<n13.Package, T2>(Input_In: Create_Asset_In, Arg_In: Input_In_3, Result_Out: out T2 Result_4);
                var Output_5 = new n38.UFile(filePath: Url_In);
                var Output_6 = new n13.AssetItem(location: Output_5, asset: Result_4);
                return Output_6;
            }

            , Wrapper_Out: out n6.AssetWrapper<T> Wrapper_7, Already_Loaded_Out: out bool Already_Loaded_8);
            Wrapper_Out = Wrapper_7;
            Already_Loaded_Out = Already_Loaded_8;
            n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_9 != this.__p_HEshEiOWzxwPFhRtov567v ? new RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(this)
                {__p_HEshEiOWzxwPFhRtov567v = Output_9} : that_10;
            else
            {
                this.__p_HEshEiOWzxwPFhRtov567v = Output_9;
            }

            return that_10;
        }

        public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "HEshEiOWzxwPFhRtov567v", 12552U);
            var Output_1 = n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw.Create(Node_Context: Node_Context_0);
            n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS that_2 = this;
            this.__p_HEshEiOWzxwPFhRtov567v = Output_1;
            return that_2;
        }

        public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS Dispose_()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HEshEiOWzxwPFhRtov567v);
            return this;
        }

        public n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __CreateDefault__()
        {
            n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS that_0 = this;
            this.__p_HEshEiOWzxwPFhRtov567v = n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 12552U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "HEshEiOWzxwPFhRtov567v", Name = "RuntimeAssetItem", IsManaged = true, IsAutoGenerated = true)]
        public n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw __p_HEshEiOWzxwPFhRtov567v;
        public RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(RuntimeAsset_VgZeOO9CcieL8y7OwiEllS other): base(other)
        {
            this.__p_HEshEiOWzxwPFhRtov567v = other.__p_HEshEiOWzxwPFhRtov567v;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HEshEiOWzxwPFhRtov567v", in __p_HEshEiOWzxwPFhRtov567v));
        }

        internal RuntimeAsset_VgZeOO9CcieL8y7OwiEllS __WITH__(n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw __p_HEshEiOWzxwPFhRtov567v)
        {
            n10.RuntimeAsset_VgZeOO9CcieL8y7OwiEllS that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = __p_HEshEiOWzxwPFhRtov567v != this.__p_HEshEiOWzxwPFhRtov567v ? new RuntimeAsset_VgZeOO9CcieL8y7OwiEllS(this)
                {__p_HEshEiOWzxwPFhRtov567v = __p_HEshEiOWzxwPFhRtov567v} : that_1;
            else
            {
                this.__p_HEshEiOWzxwPFhRtov567v = __p_HEshEiOWzxwPFhRtov567v;
            }

            return that_1;
        }
    }

    [n1.ElementAttribute(TracingId = 12758U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VmTWNKE7B5VPMgb0RdtwUC", Name = "ListAssets_VmTWNKE7B5VPMgb0RdtwUC")]
    [n2.SerializableAttribute]
    public class ListAssets_VmTWNKE7B5VPMgb0RdtwUC : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC Create(n1.NodeContext Node_Context)
        {
            var instance = new ListAssets_VmTWNKE7B5VPMgb0RdtwUC(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC CreateDefault()
        {
            var instance = new ListAssets_VmTWNKE7B5VPMgb0RdtwUC(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC Update(out n17.IReadOnlyCollection<n13.AssetItem> Loaded_Asset_Items_Out, out n17.IReadOnlyCollection<n17.KeyValuePair<string, n6.AssetWrapperBase>> Requested_Assets_Out)
        {
            var Output_1 = this.__p_I41ToZEM5p1OjUdyYAnY7Q.Update(Service_Out: out n14.AssetBuilderService_C Service_0);
            var Output_4 = Service_0.GetRuntimePackage(Package_Out: out n13.Package Package_2, Package_Session_Out: out n13.PackageSession Package_Session_3);
            var Assets_5 = Package_2.Assets;
            n17.IReadOnlyCollection<n13.AssetItem> Loaded_Asset_Items_Out_6 = (n17.IReadOnlyCollection<n13.AssetItem>)Assets_5;
            var Output_8 = Service_0.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_7);
            var All_Assets_9 = Content_Loader_7.AllAssets;
            Loaded_Asset_Items_Out = Loaded_Asset_Items_Out_6;
            Requested_Assets_Out = All_Assets_9;
            n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_1 != this.__p_I41ToZEM5p1OjUdyYAnY7Q ? new ListAssets_VmTWNKE7B5VPMgb0RdtwUC(this)
                {__p_I41ToZEM5p1OjUdyYAnY7Q = Output_1} : that_10;
            else
            {
                this.__p_I41ToZEM5p1OjUdyYAnY7Q = Output_1;
            }

            return that_10;
        }

        public n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "I41ToZEM5p1OjUdyYAnY7Q", 12763U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC that_2 = this;
            this.__p_I41ToZEM5p1OjUdyYAnY7Q = Output_1;
            return that_2;
        }

        public n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC __CreateDefault__()
        {
            n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC that_0 = this;
            this.__p_I41ToZEM5p1OjUdyYAnY7Q = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_I41ToZEM5p1OjUdyYAnY7Q);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 12763U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "I41ToZEM5p1OjUdyYAnY7Q", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_I41ToZEM5p1OjUdyYAnY7Q;
        public ListAssets_VmTWNKE7B5VPMgb0RdtwUC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ListAssets_VmTWNKE7B5VPMgb0RdtwUC(ListAssets_VmTWNKE7B5VPMgb0RdtwUC other): base(other)
        {
            this.__p_I41ToZEM5p1OjUdyYAnY7Q = other.__p_I41ToZEM5p1OjUdyYAnY7Q;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_I41ToZEM5p1OjUdyYAnY7Q", in __p_I41ToZEM5p1OjUdyYAnY7Q));
        }

        internal ListAssets_VmTWNKE7B5VPMgb0RdtwUC __WITH__(n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_I41ToZEM5p1OjUdyYAnY7Q)
        {
            n10.ListAssets_VmTWNKE7B5VPMgb0RdtwUC that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_I41ToZEM5p1OjUdyYAnY7Q != this.__p_I41ToZEM5p1OjUdyYAnY7Q ? new ListAssets_VmTWNKE7B5VPMgb0RdtwUC(this)
                {__p_I41ToZEM5p1OjUdyYAnY7Q = __p_I41ToZEM5p1OjUdyYAnY7Q} : that_0;
            else
            {
                this.__p_I41ToZEM5p1OjUdyYAnY7Q = __p_I41ToZEM5p1OjUdyYAnY7Q;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 12889U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "F2ZxHcXlgsRPgsjnt4K59r", Name = "AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r")]
    [n2.SerializableAttribute]
    public class AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r Create(n1.NodeContext Node_Context)
        {
            var instance = new AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r CreateDefault()
        {
            var instance = new AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r Update(n13.AssetItem AssetItem_In, out n13.Asset Asset_Out, out bool Is_Dirty_Out, out n38.UFile Full_Path_Out, out n38.UFile Location_Out, out n49.AssetId Id_Out, out n38.UDirectory Source_Folder_Out, out bool Is_Deleted_Out, out long Version_Out, out n51.AttachedYamlAssetMetadata Yaml_Metadata_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_IzCboaeguSULbPSO23hKYn;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n13.AssetItem>, n2.ValueTuple<n13.Asset, bool, n38.UFile, n38.UFile, n49.AssetId, n38.UDirectory, bool, n2.ValueTuple<long, n51.AttachedYamlAssetMetadata>>>((default(n13.Asset), false, default(n38.UFile), default(n38.UFile), default(n49.AssetId), default(n38.UDirectory), false, 0L, default(n51.AttachedYamlAssetMetadata)));
            }

            var inputs_3 = n2.ValueTuple.Create(AssetItem_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Asset_7 = AssetItem_In.Asset;
                var Is_Dirty_8 = AssetItem_In.IsDirty;
                var Full_Path_9 = AssetItem_In.FullPath;
                var Location_10 = AssetItem_In.Location;
                var Id_11 = AssetItem_In.Id;
                var Source_Folder_12 = AssetItem_In.SourceFolder;
                var Is_Deleted_13 = AssetItem_In.IsDeleted;
                var Version_14 = AssetItem_In.Version;
                var Yaml_Metadata_15 = AssetItem_In.YamlMetadata;
                outputs_4 = (Asset_7, Is_Dirty_8, Full_Path_9, Location_10, Id_11, Source_Folder_12, Is_Deleted_13, Version_14, Yaml_Metadata_15);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_16, __auto_17, __auto_18, __auto_19, __auto_20, __auto_21, __auto_22, __auto_23, __auto_24) = outputs_4;
            Asset_Out = __auto_16;
            Is_Dirty_Out = __auto_17;
            Full_Path_Out = __auto_18;
            Location_Out = __auto_19;
            Id_Out = __auto_20;
            Source_Folder_Out = __auto_21;
            Is_Deleted_Out = __auto_22;
            Version_Out = __auto_23;
            Yaml_Metadata_Out = __auto_24;
            n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_2 != this.__cache_IzCboaeguSULbPSO23hKYn ? new AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(this)
                {__cache_IzCboaeguSULbPSO23hKYn = manager_2} : that_25;
            else
            {
                this.__cache_IzCboaeguSULbPSO23hKYn = manager_2;
            }

            return that_25;
        }

        public n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r that_0 = this;
            this.__cache_IzCboaeguSULbPSO23hKYn = null;
            return that_0;
        }

        public n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r __CreateDefault__()
        {
            n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r that_0 = this;
            this.__cache_IzCboaeguSULbPSO23hKYn = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_IzCboaeguSULbPSO23hKYn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 12901U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "IzCboaeguSULbPSO23hKYn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n13.AssetItem>, n2.ValueTuple<n13.Asset, bool, n38.UFile, n38.UFile, n49.AssetId, n38.UDirectory, bool, n2.ValueTuple<long, n51.AttachedYamlAssetMetadata>>> __cache_IzCboaeguSULbPSO23hKYn = null;
        public AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r other): base(other)
        {
            this.__cache_IzCboaeguSULbPSO23hKYn = other.__cache_IzCboaeguSULbPSO23hKYn;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_IzCboaeguSULbPSO23hKYn", in __cache_IzCboaeguSULbPSO23hKYn));
        }

        internal AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r __WITH__(n7.Manager<n2.ValueTuple<n13.AssetItem>, n2.ValueTuple<n13.Asset, bool, n38.UFile, n38.UFile, n49.AssetId, n38.UDirectory, bool, n2.ValueTuple<long, n51.AttachedYamlAssetMetadata>>> __cache_IzCboaeguSULbPSO23hKYn)
        {
            n10.AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_IzCboaeguSULbPSO23hKYn != this.__cache_IzCboaeguSULbPSO23hKYn ? new AssetItemInfo_F2ZxHcXlgsRPgsjnt4K59r(this)
                {__cache_IzCboaeguSULbPSO23hKYn = __cache_IzCboaeguSULbPSO23hKYn} : that_0;
            else
            {
                this.__cache_IzCboaeguSULbPSO23hKYn = __cache_IzCboaeguSULbPSO23hKYn;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 13151U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "S5MzdrZlwPhNNcSZsbTyKw", Name = "RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw")]
    [n2.SerializableAttribute]
    public class RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw Create(n1.NodeContext Node_Context)
        {
            var instance = new RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw CreateDefault()
        {
            var instance = new RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw Update<T, AdM>([n4.SerializedDefaultValueAttribute("True", false)] bool Build_In, bool Reload_In, string Url_In, n2.Func<n13.Package, n13.AssetItem> Create_Asset_Item_In, string Source_Folder_In, string Name_In, out n6.AssetWrapper<T> Wrapper_Out, out bool Already_Loaded_Out)
            where T : class where AdM : struct, n15.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n14.AssetBuilderService_C __auto_1 = this.Builder;
            n14._Operations_.TryLoadExisting<T, AdM>(Input_In: __auto_1, Url_In: Url_In, Reload_In: Reload_In, Result_Out: out n6.AssetWrapper<T> Result_2, Loaded_Out: out bool Loaded_3);
            n54._Operations_.ORNOT(Input_In: Reload_In, Input_2_In: Loaded_3, Output_Out: out bool Output_4);
            if (Output_4)
            {
                var Output_8 = __auto_1.GetRuntimePackage(Package_Out: out n13.Package Package_6, Package_Session_Out: out n13.PackageSession Package_Session_7);
                var Assets_9 = Package_6.Assets;
                var Result_10 = Assets_9.Find(location: Url_In);
                var Result_11 = Assets_9.Remove(item: Result_10);
                var Package_12 = Assets_9.Package;
                n46._Operations_.Invoke<n13.Package, n13.AssetItem>(Input_In: Create_Asset_Item_In, Arg_In: Package_12, Result_Out: out n13.AssetItem Result_13);
                n12.ObjectHelpers.IsAssigned(x: Result_13, result: out bool Result_14, notAssigned: out bool Not_Assigned_15);
                var Output_16 = new n38.UDirectory(directoryPath: Source_Folder_In);
                if (Result_14)
                {
                    var Result_18 = string.IsNullOrWhiteSpace(value: Source_Folder_In);
                    var Output_19 = !Result_18;
                    var Output_20 = Result_13;
                    if (Output_19)
                    {
                        Result_13.SourceFolder = Output_16;
                    }

                    n34._Operations_.FromValue<n13.AssetItem>(Input_In: Output_20, Result_Out: out n17.IEnumerable<n13.AssetItem> Result_21);
                    bool Add_To_Runtime_Package_22 = true;
                    var Output_23 = Output_8;
                    if (Build_In)
                    {
                        Output_23 = Output_8.BuildAsync(Add_To_Runtime_Package_In: Add_To_Runtime_Package_22, Asset_items_In: Result_21);
                    }
                }
            }

            string __auto_24 = Url_In;
            Result_2.Name = Name_In;
            Wrapper_Out = Result_2;
            Already_Loaded_Out = Loaded_3;
            n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Url_In != this.Url ? new RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(this)
                {Url = Url_In} : that_25;
            else
            {
                this.Url = Url_In;
            }

            return that_25;
        }

        public n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("OpwXTKxodpcLMuzoaGSQfF", "K6jaK77fwwIL0xOlp0ausC", 13157U);
            var Output_1 = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.Create(Node_Context: Node_Context_0);
            var Output_3 = Output_1.Update(Service_Out: out n14.AssetBuilderService_C Service_2);
            n14.AssetBuilderService_C __auto_4 = Service_2;
            n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw that_5 = this;
            this.Builder = Service_2;
            this.Url = "";
            this.__p_K6jaK77fwwIL0xOlp0ausC = Output_3;
            return that_5;
        }

        public n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw Dispose_()
        {
            n14.AssetBuilderService_C __auto_0 = this.Builder;
            string __auto_1 = this.Url;
            var Output_3 = __auto_0.GetContentLoader(Content_Loader_Out: out n24.RuntimeContentLoader Content_Loader_2);
            var Content_Manager_4 = Content_Loader_2.ContentManager;
            n14._Operations_.UnloadFromContent(Content_Manager_In: Content_Manager_4, Url_In: __auto_1);
            n1.CompilationHelper.SafeDispose(this.__p_K6jaK77fwwIL0xOlp0ausC);
            return this;
        }

        public n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw __CreateDefault__()
        {
            n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw that_0 = this;
            this.Builder = n33._Operations_.CreateDefault();
            this.Url = "";
            this.__p_K6jaK77fwwIL0xOlp0ausC = n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 13363U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "VztsC28GAtPLgGifqczTLR", Name = "Builder")]
        public n14.AssetBuilderService_C Builder;
        [n1.ElementAttribute(TracingId = 13359U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "CUJBHkk4K5OOW4cZuGknVV", Name = "Url")]
        public string Url;
        [n1.ElementAttribute(TracingId = 13157U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "K6jaK77fwwIL0xOlp0ausC", Name = "GetAssetBuilderService", IsManaged = true, IsAutoGenerated = true)]
        public n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_K6jaK77fwwIL0xOlp0ausC;
        public RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw other): base(other)
        {
            this.Builder = other.Builder;
            this.Url = other.Url;
            this.__p_K6jaK77fwwIL0xOlp0ausC = other.__p_K6jaK77fwwIL0xOlp0ausC;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder", in Builder), n1.CompilationHelper.GetValueOrExisting(values, "Url", in Url), n1.CompilationHelper.GetValueOrExisting(values, "__p_K6jaK77fwwIL0xOlp0ausC", in __p_K6jaK77fwwIL0xOlp0ausC));
        }

        internal RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw __WITH__(n14.AssetBuilderService_C Builder, string Url, n14.GetAssetBuilderService_OqqyqkcUDlkM4LtWN5eDau __p_K6jaK77fwwIL0xOlp0ausC)
        {
            n10.RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Builder != this.Builder || Url != this.Url || __p_K6jaK77fwwIL0xOlp0ausC != this.__p_K6jaK77fwwIL0xOlp0ausC ? new RuntimeAssetItem_S5MzdrZlwPhNNcSZsbTyKw(this)
                {Builder = Builder, Url = Url, __p_K6jaK77fwwIL0xOlp0ausC = __p_K6jaK77fwwIL0xOlp0ausC} : that_1;
            else
            {
                this.Builder = Builder;
                this.Url = Url;
                this.__p_K6jaK77fwwIL0xOlp0ausC = __p_K6jaK77fwwIL0xOlp0ausC;
            }

            return that_1;
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride.Assets.Asset
{
    [n1.ElementAttribute(TracingId = 4382U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TryLoadFromGame<T>(n56.ContentManager Game_Content_In, n6.AssetWrapper<T> Input_In, string Url_In, n6.AssetWrapper<T> Game_Value_In, out n6.AssetWrapper<T> Output_Out)
            where T : class
        {
            Input_In.GetValues(asset: out T Asset_0, exists: out bool Exists_1, loading: out bool Loading_2);
            var Output_3 = !Exists_1;
            n6.AssetWrapper<T> __auto_4;
            if (Output_3)
            {
                var Result_5 = Game_Content_In.Exists(url: Url_In);
                n6.AssetWrapper<T> __auto_6;
                if (Result_5)
                {
                    bool __pad_QP6RP6lvrPgPxSgSr6EgTI_7 = __slot_QP6RP6lvrPgPxSgSr6EgTI;
                    n56.ContentManagerLoaderSettings Settings_8 = default(n56.ContentManagerLoaderSettings);
                    var Result_9 = Game_Content_In.Load<T>(url: Url_In, settings: Settings_8);
                    Game_Value_In.SetValues(asset: Result_9, exists: __pad_QP6RP6lvrPgPxSgSr6EgTI_7);
                    __auto_6 = Game_Value_In;
                }
                else
                {
                    __auto_6 = Input_In;
                }

                __auto_4 = __auto_6;
            }
            else
            {
                __auto_4 = Input_In;
            }

            Output_Out = __auto_4;
            return;
        }

        [n1.ElementAttribute(TracingId = 15612U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "QP6RP6lvrPgPxSgSr6EgTI", Name = "__slot_QP6RP6lvrPgPxSgSr6EgTI")]
        public static bool __slot_QP6RP6lvrPgPxSgSr6EgTI = true;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Assets_Windows_.Stride
{
    [n1.ElementAttribute(TracingId = 15928U, DocumentId = "OpwXTKxodpcLMuzoaGSQfF", PersistentId = "ULBprqvLI8MMadQZyRlyfn", Name = "VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn")]
    [n2.SerializableAttribute]
    public class VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n61.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n61.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn CreateDefault()
        {
            var instance = new VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n61.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn Update()
        {
            return this;
        }

        public n61.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn __Create__(n1.NodeContext Node_Context)
        {
            n16.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n61.VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn __CreateDefault__()
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

        public VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn(VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Assets_WindowsApplication_ULBprqvLI8MMadQZyRlyfn __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Assets_Windows_
{
    public struct __AdaptiveImplementations__OpwXTKxodpcLMuzoaGSQfF : n15.IAdaptiveCreateDefault<n11.Stream>, n15.IAdaptiveCreateDefault<n18.Material>, n15.IAdaptiveCreateDefault<n20.Prefab>, n15.IAdaptiveCreateDefault<n5.Path>, n15.IAdaptiveCreateDefault<n2.Object>, n15.IAdaptiveCreateDefault<bool>, n15.IAdaptiveCreateDefault<n20.Scene>, n15.IAdaptiveCreateDefault<n79.Texture>, n15.IAdaptiveCreateDefault<n26.ReloadingAsset>, n15.IAdaptiveCreateDefault<n13.AssetItem>, n15.IAdaptiveCreateDefault<n47.AlphaFormat>, n15.IAdaptiveCreateDefault<n18.Model>, n15.IAdaptiveCreateDefault<n53.Vector3>, n15.IAdaptiveCreateDefault<float>, n15.IAdaptiveCreateDefault<string>
    {
        public void CreateDefault(out n11.Stream Output_Out)
        {
            var Null_0 = n83._Operations_.CreateDefault();
            Output_Out = Null_0;
            return;
        }

        public void CreateDefault(out n18.Material Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n18.Material>(Output_Out: out n18.Material Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n20.Prefab Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n20.Prefab>(Output_Out: out n20.Prefab Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n5.Path Output_Out)
        {
            var Default_0 = n74._Operations_.CreateDefault();
            Output_Out = Default_0;
            return;
        }

        public void CreateDefault(out n2.Object Output_Out)
        {
            var Output_0 = n39._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n20.Scene Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n20.Scene>(Output_Out: out n20.Scene Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n79.Texture Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n79.Texture>(Output_Out: out n79.Texture Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n26.ReloadingAsset Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n26.ReloadingAsset>(Output_Out: out n26.ReloadingAsset Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n13.AssetItem Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n13.AssetItem>(Output_Out: out n13.AssetItem Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n47.AlphaFormat Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n47.AlphaFormat>(Output_Out: out n47.AlphaFormat Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n18.Model Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<n18.Model>(Output_Out: out n18.Model Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n53.Vector3 Output_Out)
        {
            var Zero_0 = n85._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n84._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n63._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }
    }
}