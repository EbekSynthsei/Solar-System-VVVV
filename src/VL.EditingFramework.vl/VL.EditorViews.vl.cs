extern alias e18;
extern alias e9;
extern alias e2;
extern alias e5;
extern alias e1;

using n22 = _VL_Editors_.Editors._3D.Advanced;
using n24 = _CoreLibBasics_._3D.Matrix;
using n9 = _VL_Skia_.Graphics.Skia;
using n21 = e2::VL.Lib.Primitive;
using n46 = _CoreLibBasics_.Primitive.Object.Advanced;
using n38 = _CoreLibBasics_.Control;
using n45 = e9::VL.Lib.IO.Notifications;
using n34 = global::System.Collections.Immutable;
using n40 = _CoreLibBasics_.Math.Generic.Advanced;
using n54 = e2::VL.Lib.Text;
using n20 = e2::VL.Lib.Mathematics;
using n18 = _VL_Skia_.Graphics.Skia.Layers;
using n49 = _VL_Reactive_.Reactive.Sampler;
using n12 = _VL_Editors_.Editors.Advanced;
using n30 = e2::VL.Lib.Color;
using n11 = _VL_EditorViews_.Graphics.Skia.EditorViews.PointsView.Experimental;
using n4 = e5::VL.Core.CompilerServices;
using n32 = _CoreLibBasics_._2D.Transform;
using n28 = _VL_Skia_.Graphics.Skia.Paint;
using n7 = global::System.Collections.Generic;
using n29 = _CoreLibBasics_._2D.Vector2;
using n13 = global::SkiaSharp;
using n5 = e1::Stride.Core.Mathematics;
using n57 = _CoreLibBasics_.Math.Adaptive;
using n25 = _VL_Skia_.Graphics.Skia.Layer.Advanced;
using n56 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n53 = _VL_EditorViews_.Graphics.Skia.EditorViews.PointEditorView.Experimental;
using n3 = _VL_EditorViews_.Graphics.Skia.EditorViews.Experimental;
using n10 = _VL_EditorViews_.Graphics.Skia.EditorViews.GizmoView.Experimental;
using n14 = e2::VL.Lib.Primitive.CacheRegion;
using n50 = _VL_Skia_.Graphics.Skia.Layers.Text;
using n51 = _VL_Skia_.Graphics.Skia.Text;
using n48 = _VL_Reactive_.Reactive.ForEach_Keep;
using n37 = _VL_Skia_.IO.Keyboard;
using n47 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n35 = e9::VL.Lib.IO;
using n43 = _VL_Skia_.Graphics.Skia.Paint.Advanced;
using n15 = _VL_Skia_.Graphics.Skia.SKPath.Advanced;
using n31 = e5::VL.Lib.Runtime;
using n16 = _VL_Skia_.Graphics.Skia.Paths.Advanced;
using n2 = global::System;
using n44 = _CoreLibBasics_.Color.RGBA;
using n41 = _CoreLibBasics_._2D.Rectangle;
using n27 = _VL_Skia_.Graphics.Skia.Transform;
using n33 = global::System.Windows.Forms;
using n17 = _VL_Collections_.Collections.Sequence;
using n19 = global::System.Runtime.CompilerServices;
using n36 = _VL_Skia_.IO.Mouse;
using n8 = e18::VL.Skia;
using n6 = e5::VL.Lib.Collections;
using n39 = _VL_EditorViews_;
using n52 = _VL_Skia_.Graphics.Skia.Transform.WithinSpace;
using n23 = _VL_Collections_.Collections.Spread;
using n42 = _VL_Skia_.Graphics.Skia.Paint.PathEffects.Advanced;
using n55 = _CoreLibBasics_.Primitive.Advanced;
using n26 = _CoreLibBasics_._3D.Vector3;

namespace _VL_EditorViews_.Graphics.Skia.EditorViews.Experimental
{
    [n1.ElementAttribute(TracingId = 103617U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "CBqPfiL44KTLx6sm35ChLH", Name = "GizmoView_CBqPfiL44KTLx6sm35ChLH")]
    [n2.SerializableAttribute]
    public class GizmoView_CBqPfiL44KTLx6sm35ChLH : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GizmoView_CBqPfiL44KTLx6sm35ChLH Create(n1.NodeContext Node_Context)
        {
            var instance = new GizmoView_CBqPfiL44KTLx6sm35ChLH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GizmoView_CBqPfiL44KTLx6sm35ChLH CreateDefault()
        {
            var instance = new GizmoView_CBqPfiL44KTLx6sm35ChLH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GizmoView_CBqPfiL44KTLx6sm35ChLH Update(n22.GizmoState_R Input_In, bool Enabled_In, out n8.ILayer Output_Out)
        {
            n6.Spread<n5.Color4> __auto_0 = this.Colors;
            n7.IEnumerable<n5.Color4> Colors_1 = (n7.IEnumerable<n5.Color4>)__auto_0;
            n7.IEnumerable<n5.Color4> Colors_2 = (n7.IEnumerable<n5.Color4>)__auto_0;
            n7.IEnumerable<n5.Color4> Colors_3 = (n7.IEnumerable<n5.Color4>)__auto_0;
            n8.ILayer __auto_4;
            var state_5 = n1.CompilationHelper.Restore<__GzKIVeEE7sRMAER8w4YolR>(this.__if_VKt2Yj9Nc9CNrVHroPJPAC, __GetContext__());
            if (Enabled_In)
            {
                if (state_5 == null)
                {
                    state_5 = new __GzKIVeEE7sRMAER8w4YolR(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = n23._Operations_.CreateDefault<n8.ILayer>()};
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HKAjq1JZOo5PoQm1MR3cWh", 104188U);
                    var Output_7 = n9.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_6);
                    state_5.__p_HKAjq1JZOo5PoQm1MR3cWh = Output_7;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Nxh65DVZ51pQQ8VGbMLInn", 104195U);
                    var Output_9 = n10.DrawCenter_UtsfEfb9QfhM1f4443x988.Create(Node_Context: Node_Context_8);
                    state_5.__p_Nxh65DVZ51pQQ8VGbMLInn = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "GGrSihyuC2eNpKRknSupai", 104255U);
                    var Output_11 = n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm.Create(Node_Context: Node_Context_10);
                    state_5.__p_GGrSihyuC2eNpKRknSupai = Output_11;
                }

                n5.Color4 __pad_DkpRsP1pCnhLMfNzcUTLnz_12 = __slot_DkpRsP1pCnhLMfNzcUTLnz;
                var Output_20 = Input_In.Split(Gizmo_Model_Out: out n22.GizmoModel_R Gizmo_Model_13, Active_Axis_Out: out n5.Vector3 Active_Axis_14, Translation_Offset_Out: out n5.Vector3 Translation_Offset_15, Rotation_Value_Out: out n5.Vector3 Rotation_Value_16, Scale_Offset_Out: out n5.Vector3 Scale_Offset_17, Visible_Out: out bool Visible_18, Idle_Out: out bool Idle_19);
                var Output_38 = Gizmo_Model_13.Split(Translation_Out: out n6.Spread<n5.Matrix> Translation_21, Scale_Out: out n6.Spread<n5.Matrix> Scale_22, Rotation_Out: out n6.Spread<n5.Matrix> Rotation_23, Center_Out: out n5.Matrix Center_24, Position_Out: out n5.Vector3 Position_25, Active_Axis_Out: out n5.Vector3 Active_Axis_26, Translation_Active_Out: out bool Translation_Active_27, Scale_Active_Out: out bool Scale_Active_28, Rotation_Active_Out: out bool Rotation_Active_29, Center_Active_Out: out bool Center_Active_30, Center_Enabled_Out: out bool Center_Enabled_31, Translation_Enabled_Out: out bool Translation_Enabled_32, Scale_Enabled_Out: out bool Scale_Enabled_33, Rotation_Enabled_Out: out bool Rotation_Enabled_34, Pick_Size_Out: out float Pick_Size_35, Gizmo_Size_Out: out float Gizmo_Size_36, Active_Plane_Out: out n5.Vector3 Active_Plane_37);
                var Result_39 = n20.Vector3Nodes.ToValues(input: ref Active_Axis_14);
                float Default_Value_40 = 0F;
                n23._Operations_.SplitLast<float>(Input_In: Result_39, Default_Value_In: Default_Value_40, Output_Out: out n6.Spread<float> Output_41, Result_Out: out float Result_42);
                n7.IEnumerable<float> Active_Plane_43 = (n7.IEnumerable<float>)Output_41;
                n7.IEnumerable<float> Active_Axis_44 = (n7.IEnumerable<float>)Output_41;
                n8.ILayer __auto_45;
                var state_46 = n1.CompilationHelper.Restore<__ETfS04uD4GqMdJYEvrGDhk>(state_5.__if_HfCHzZF42TgOZH1xjpdSkH, __GetContext__());
                if (Idle_19)
                {
                    if (state_46 == null)
                    {
                        state_46 = new __ETfS04uD4GqMdJYEvrGDhk(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = n23._Operations_.CreateDefault<n8.ILayer>()};
                        n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "TwUSt15uos4N8gr1zbMQjn", 104215U);
                        var Output_48 = n10.DrawScale_VCoaztTRPukLSgIjawVi6E.Create(Node_Context: Node_Context_47);
                        state_46.__p_TwUSt15uos4N8gr1zbMQjn = Output_48;
                        n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "UYEgl9FUkq8OPaWjxExZJ0", 104226U);
                        var Output_50 = n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk.Create(Node_Context: Node_Context_49);
                        state_46.__p_UYEgl9FUkq8OPaWjxExZJ0 = Output_50;
                        n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "EkOtf31YooKPN7W9Zoubg5", 104237U);
                        var Output_52 = n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj.Create(Node_Context: Node_Context_51);
                        state_46.__p_EkOtf31YooKPN7W9Zoubg5 = Output_52;
                        n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "JtHlwxvt8rMOz0Pv8Cl46M", 104248U);
                        var Output_54 = n9.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_53);
                        state_46.__p_JtHlwxvt8rMOz0Pv8Cl46M = Output_54;
                    }

                    n5.Color4 __pad_BKLvc8T6GLpNpIQHRn6W2N_55 = __slot_BKLvc8T6GLpNpIQHRn6W2N;
                    n5.Matrix Default_Value_56 = n24._Operations_.CreateDefault();
                    int Index_57 = 2;
                    n23._Operations_.GetSlice<n5.Matrix>(Input_In: Rotation_23, Default_Value_In: Default_Value_56, Index_In: Index_57, Result_Out: out n5.Matrix Result_58);
                    float Default_Value_59 = 0F;
                    int Index_60 = 2;
                    n23._Operations_.GetSlice<float>(Input_In: Result_39, Default_Value_In: Default_Value_59, Index_In: Index_60, Result_Out: out float Result_61);
                    var State_Output_63 = state_46.__p_EkOtf31YooKPN7W9Zoubg5.Update(Transformation_In: Result_58, Color_In: __pad_BKLvc8T6GLpNpIQHRn6W2N_55, Is_Active_In: Result_61, Enabled_In: Rotation_Enabled_34, Output_Out: out n8.ILayer Output_62);
                    n5.Matrix Default_Value_64 = n24._Operations_.CreateDefault();
                    n23._Operations_.SplitLast<n5.Matrix>(Input_In: Translation_21, Default_Value_In: Default_Value_64, Output_Out: out n6.Spread<n5.Matrix> Output_65, Result_Out: out n5.Matrix Result_66);
                    n7.IEnumerable<n5.Matrix> Transformations_67 = (n7.IEnumerable<n5.Matrix>)Output_65;
                    var State_Output_69 = state_46.__p_UYEgl9FUkq8OPaWjxExZJ0.Update(Transformations_In: Transformations_67, Colors_In: Colors_1, Active_Axis_In: Active_Axis_44, Enabled_In: Translation_Enabled_32, Output_Out: out n8.ILayer Output_68);
                    n5.Matrix Default_Value_70 = n24._Operations_.CreateDefault();
                    n23._Operations_.SplitLast<n5.Matrix>(Input_In: Scale_22, Default_Value_In: Default_Value_70, Output_Out: out n6.Spread<n5.Matrix> Output_71, Result_Out: out n5.Matrix Result_72);
                    n7.IEnumerable<n5.Matrix> Transformation_73 = (n7.IEnumerable<n5.Matrix>)Output_71;
                    var State_Output_75 = state_46.__p_TwUSt15uos4N8gr1zbMQjn.Update(Transformation_In: Transformation_73, Colors_In: Colors_2, Active_Plane_In: Active_Plane_43, Enabled_In: Scale_Enabled_33, Output_Out: out n8.ILayer Output_74);
                    bool Debug_76 = false;
                    bool Enabled_77 = true;
                    var builder_78 = n4.CollectionBuilders.GetBuilder(state_46.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M, 3);
                    builder_78.Add(Output_62);
                    builder_78.Add(Output_68);
                    builder_78.Add(Output_74);
                    var __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M_79 = builder_78.Commit();
                    var State_Output_81 = state_46.__p_JtHlwxvt8rMOz0Pv8Cl46M.Update(Input_In: __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M_79, Debug_In: Debug_76, Enabled_In: Enabled_77, Output_Out: out n8.ILayer Output_80);
                    __auto_45 = Output_80;
                    if (state_46.__GetContext__().IsImmutable)
                        state_46 = State_Output_63 != state_46.__p_EkOtf31YooKPN7W9Zoubg5 || State_Output_69 != state_46.__p_UYEgl9FUkq8OPaWjxExZJ0 || State_Output_75 != state_46.__p_TwUSt15uos4N8gr1zbMQjn || __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M_79 != state_46.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M || State_Output_81 != state_46.__p_JtHlwxvt8rMOz0Pv8Cl46M ? new __ETfS04uD4GqMdJYEvrGDhk(state_46)
                        {__p_EkOtf31YooKPN7W9Zoubg5 = State_Output_63, __p_UYEgl9FUkq8OPaWjxExZJ0 = State_Output_69, __p_TwUSt15uos4N8gr1zbMQjn = State_Output_75, __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M_79, __p_JtHlwxvt8rMOz0Pv8Cl46M = State_Output_81} : state_46;
                    else
                    {
                        state_46.__p_EkOtf31YooKPN7W9Zoubg5 = State_Output_63;
                        state_46.__p_UYEgl9FUkq8OPaWjxExZJ0 = State_Output_69;
                        state_46.__p_TwUSt15uos4N8gr1zbMQjn = State_Output_75;
                        state_46.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M_79;
                        state_46.__p_JtHlwxvt8rMOz0Pv8Cl46M = State_Output_81;
                    }
                }
                else
                {
                    __auto_45 = n25._Operations_.CreateDefault();
                }

                var Output_82 = Center_Enabled_31 && Idle_19;
                var State_Output_84 = state_5.__p_Nxh65DVZ51pQQ8VGbMLInn.Update(Transformation_In: Center_24, Color_In: __pad_DkpRsP1pCnhLMfNzcUTLnz_12, Is_Active_In: Center_Active_30, Enabled_In: Output_82, Output_Out: out n8.ILayer Output_83);
                n26._Operations_.XY(Input_In: Position_25, Output_Out: out n5.Vector2 Output_85);
                n7.IEnumerable<float> Active_Axis_86 = (n7.IEnumerable<float>)Output_41;
                bool Enabled_87 = true;
                var State_Output_89 = state_5.__p_GGrSihyuC2eNpKRknSupai.Update(Position_In: Output_85, Colors_In: Colors_3, Active_Axis_In: Active_Axis_86, Enabled_In: Enabled_87, Output_Out: out n8.ILayer Output_88);
                bool Debug_90 = false;
                bool Enabled_91 = true;
                var builder_92 = n4.CollectionBuilders.GetBuilder(state_5.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh, 3);
                builder_92.Add(Output_88);
                builder_92.Add(__auto_45);
                builder_92.Add(Output_83);
                var __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh_93 = builder_92.Commit();
                var State_Output_95 = state_5.__p_HKAjq1JZOo5PoQm1MR3cWh.Update(Input_In: __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh_93, Debug_In: Debug_90, Enabled_In: Enabled_91, Output_Out: out n8.ILayer Output_94);
                __auto_4 = Output_94;
                if (state_5.__GetContext__().IsImmutable)
                    state_5 = state_46 != state_5.__if_HfCHzZF42TgOZH1xjpdSkH || State_Output_84 != state_5.__p_Nxh65DVZ51pQQ8VGbMLInn || State_Output_89 != state_5.__p_GGrSihyuC2eNpKRknSupai || __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh_93 != state_5.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh || State_Output_95 != state_5.__p_HKAjq1JZOo5PoQm1MR3cWh ? new __GzKIVeEE7sRMAER8w4YolR(state_5)
                    {__if_HfCHzZF42TgOZH1xjpdSkH = state_46, __p_Nxh65DVZ51pQQ8VGbMLInn = State_Output_84, __p_GGrSihyuC2eNpKRknSupai = State_Output_89, __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh_93, __p_HKAjq1JZOo5PoQm1MR3cWh = State_Output_95} : state_5;
                else
                {
                    state_5.__if_HfCHzZF42TgOZH1xjpdSkH = state_46;
                    state_5.__p_Nxh65DVZ51pQQ8VGbMLInn = State_Output_84;
                    state_5.__p_GGrSihyuC2eNpKRknSupai = State_Output_89;
                    state_5.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh_93;
                    state_5.__p_HKAjq1JZOo5PoQm1MR3cWh = State_Output_95;
                }
            }
            else
            {
                __auto_4 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_4;
            n3.GizmoView_CBqPfiL44KTLx6sm35ChLH that_96 = this;
            if (this.__GetContext__().IsImmutable)
                that_96 = state_5 != this.__if_VKt2Yj9Nc9CNrVHroPJPAC ? new GizmoView_CBqPfiL44KTLx6sm35ChLH(this)
                {__if_VKt2Yj9Nc9CNrVHroPJPAC = state_5} : that_96;
            else
            {
                this.__if_VKt2Yj9Nc9CNrVHroPJPAC = state_5;
            }

            return that_96;
        }

        public n3.GizmoView_CBqPfiL44KTLx6sm35ChLH __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            float Red_0 = 1F;
            float Green_1 = 0F;
            float Blue_2 = 0F;
            float Alpha_3 = 1F;
            var Result_4 = n30.ColorNodes.Join(red: Red_0, green: Green_1, blue: Blue_2, alpha: Alpha_3);
            float Red_5 = 0F;
            float Green_6 = 1F;
            float Blue_7 = 0F;
            float Alpha_8 = 1F;
            var Result_9 = n30.ColorNodes.Join(red: Red_5, green: Green_6, blue: Blue_7, alpha: Alpha_8);
            var builder_10 = n4.CollectionBuilders.GetBuilder(n23._Operations_.CreateDefault<n5.Color4>(), 2);
            builder_10.Add(Result_4);
            builder_10.Add(Result_9);
            var __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3_11 = builder_10.Commit();
            n23._Operations_.Cons<n5.Color4>(Input_In: __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3_11, Result_Out: out n6.Spread<n5.Color4> Result_12);
            n6.Spread<n5.Color4> __auto_13 = Result_12;
            n3.GizmoView_CBqPfiL44KTLx6sm35ChLH that_14 = this;
            this.Colors = Result_12;
            this.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3_11;
            this.__if_VKt2Yj9Nc9CNrVHroPJPAC = default(n2.Object);
            return that_14;
        }

        public n3.GizmoView_CBqPfiL44KTLx6sm35ChLH __CreateDefault__()
        {
            n3.GizmoView_CBqPfiL44KTLx6sm35ChLH that_0 = this;
            this.Colors = n23._Operations_.CreateDefault<n5.Color4>();
            this.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = n23._Operations_.CreateDefault<n5.Color4>();
            this.__if_VKt2Yj9Nc9CNrVHroPJPAC = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_VKt2Yj9Nc9CNrVHroPJPAC);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104152U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RfuVQto5QSaMzzGknEtSKn", Name = "Colors")]
        public n6.Spread<n5.Color4> Colors;
        [n1.ElementAttribute(TracingId = 104201U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DkpRsP1pCnhLMfNzcUTLnz", Name = "__slot_DkpRsP1pCnhLMfNzcUTLnz")]
        public static n5.Color4 __slot_DkpRsP1pCnhLMfNzcUTLnz = n1.CompilationHelper.Deserialize<n5.Color4>("1, 0.6599985, 0, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "DkpRsP1pCnhLMfNzcUTLnz");
        [n1.ElementAttribute(TracingId = 104209U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "BKLvc8T6GLpNpIQHRn6W2N", Name = "__slot_BKLvc8T6GLpNpIQHRn6W2N")]
        public static n5.Color4 __slot_BKLvc8T6GLpNpIQHRn6W2N = n1.CompilationHelper.Deserialize<n5.Color4>("0, 0.5199978, 1, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "BKLvc8T6GLpNpIQHRn6W2N");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_VKt2Yj9Nc9CNrVHroPJPAC;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Color4> __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = default(n6.Spread<n5.Color4>);
        static GizmoView_CBqPfiL44KTLx6sm35ChLH()
        {
        }

        public GizmoView_CBqPfiL44KTLx6sm35ChLH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoView_CBqPfiL44KTLx6sm35ChLH(GizmoView_CBqPfiL44KTLx6sm35ChLH other): base(other)
        {
            this.Colors = other.Colors;
            this.__if_VKt2Yj9Nc9CNrVHroPJPAC = other.__if_VKt2Yj9Nc9CNrVHroPJPAC;
            this.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = other.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Colors", in Colors), n1.CompilationHelper.GetValueOrExisting(values, "__if_VKt2Yj9Nc9CNrVHroPJPAC", in __if_VKt2Yj9Nc9CNrVHroPJPAC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3", in __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3));
        }

        internal GizmoView_CBqPfiL44KTLx6sm35ChLH __WITH__(n6.Spread<n5.Color4> Colors, n2.Object __if_VKt2Yj9Nc9CNrVHroPJPAC, n6.Spread<n5.Color4> __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3)
        {
            n3.GizmoView_CBqPfiL44KTLx6sm35ChLH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Colors != this.Colors || __if_VKt2Yj9Nc9CNrVHroPJPAC != this.__if_VKt2Yj9Nc9CNrVHroPJPAC || __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 != this.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 ? new GizmoView_CBqPfiL44KTLx6sm35ChLH(this)
                {Colors = Colors, __if_VKt2Yj9Nc9CNrVHroPJPAC = __if_VKt2Yj9Nc9CNrVHroPJPAC, __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3} : that_0;
            else
            {
                this.Colors = Colors;
                this.__if_VKt2Yj9Nc9CNrVHroPJPAC = __if_VKt2Yj9Nc9CNrVHroPJPAC;
                this.__pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3 = __pin_group_Input_In_UWs9J8GECwbMzxqAI4PtL3;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GzKIVeEE7sRMAER8w4YolR", Name = "__GzKIVeEE7sRMAER8w4YolR")]
        [n2.SerializableAttribute]
        public class __GzKIVeEE7sRMAER8w4YolR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HKAjq1JZOo5PoQm1MR3cWh);
                n1.CompilationHelper.SafeDispose(this.__p_Nxh65DVZ51pQQ8VGbMLInn);
                n1.CompilationHelper.SafeDispose(this.__p_GGrSihyuC2eNpKRknSupai);
                n1.CompilationHelper.SafeDispose(this.__if_HfCHzZF42TgOZH1xjpdSkH);
                return;
            }

            [n1.ElementAttribute(TracingId = 104188U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HKAjq1JZOo5PoQm1MR3cWh", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_HKAjq1JZOo5PoQm1MR3cWh;
            [n1.ElementAttribute(TracingId = 104195U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Nxh65DVZ51pQQ8VGbMLInn", Name = "DrawCenter", IsManaged = true, IsAutoGenerated = true)]
            public n10.DrawCenter_UtsfEfb9QfhM1f4443x988 __p_Nxh65DVZ51pQQ8VGbMLInn;
            [n1.ElementAttribute(TracingId = 104255U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GGrSihyuC2eNpKRknSupai", Name = "DrawActiveAxis", IsManaged = true, IsAutoGenerated = true)]
            public n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm __p_GGrSihyuC2eNpKRknSupai;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_HfCHzZF42TgOZH1xjpdSkH;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = default(n6.Spread<n8.ILayer>);
            public __GzKIVeEE7sRMAER8w4YolR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GzKIVeEE7sRMAER8w4YolR(__GzKIVeEE7sRMAER8w4YolR other): base(other)
            {
                this.__p_HKAjq1JZOo5PoQm1MR3cWh = other.__p_HKAjq1JZOo5PoQm1MR3cWh;
                this.__p_Nxh65DVZ51pQQ8VGbMLInn = other.__p_Nxh65DVZ51pQQ8VGbMLInn;
                this.__p_GGrSihyuC2eNpKRknSupai = other.__p_GGrSihyuC2eNpKRknSupai;
                this.__if_HfCHzZF42TgOZH1xjpdSkH = other.__if_HfCHzZF42TgOZH1xjpdSkH;
                this.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = other.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HKAjq1JZOo5PoQm1MR3cWh", in __p_HKAjq1JZOo5PoQm1MR3cWh), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nxh65DVZ51pQQ8VGbMLInn", in __p_Nxh65DVZ51pQQ8VGbMLInn), n1.CompilationHelper.GetValueOrExisting(values, "__p_GGrSihyuC2eNpKRknSupai", in __p_GGrSihyuC2eNpKRknSupai), n1.CompilationHelper.GetValueOrExisting(values, "__if_HfCHzZF42TgOZH1xjpdSkH", in __if_HfCHzZF42TgOZH1xjpdSkH), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh", in __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh));
            }

            internal __GzKIVeEE7sRMAER8w4YolR __WITH__(n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_HKAjq1JZOo5PoQm1MR3cWh, n10.DrawCenter_UtsfEfb9QfhM1f4443x988 __p_Nxh65DVZ51pQQ8VGbMLInn, n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm __p_GGrSihyuC2eNpKRknSupai, n2.Object __if_HfCHzZF42TgOZH1xjpdSkH, n6.Spread<n8.ILayer> __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh)
            {
                __GzKIVeEE7sRMAER8w4YolR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HKAjq1JZOo5PoQm1MR3cWh != this.__p_HKAjq1JZOo5PoQm1MR3cWh || __p_Nxh65DVZ51pQQ8VGbMLInn != this.__p_Nxh65DVZ51pQQ8VGbMLInn || __p_GGrSihyuC2eNpKRknSupai != this.__p_GGrSihyuC2eNpKRknSupai || __if_HfCHzZF42TgOZH1xjpdSkH != this.__if_HfCHzZF42TgOZH1xjpdSkH || __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh != this.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh ? new __GzKIVeEE7sRMAER8w4YolR(this)
                    {__p_HKAjq1JZOo5PoQm1MR3cWh = __p_HKAjq1JZOo5PoQm1MR3cWh, __p_Nxh65DVZ51pQQ8VGbMLInn = __p_Nxh65DVZ51pQQ8VGbMLInn, __p_GGrSihyuC2eNpKRknSupai = __p_GGrSihyuC2eNpKRknSupai, __if_HfCHzZF42TgOZH1xjpdSkH = __if_HfCHzZF42TgOZH1xjpdSkH, __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh} : that_0;
                else
                {
                    this.__p_HKAjq1JZOo5PoQm1MR3cWh = __p_HKAjq1JZOo5PoQm1MR3cWh;
                    this.__p_Nxh65DVZ51pQQ8VGbMLInn = __p_Nxh65DVZ51pQQ8VGbMLInn;
                    this.__p_GGrSihyuC2eNpKRknSupai = __p_GGrSihyuC2eNpKRknSupai;
                    this.__if_HfCHzZF42TgOZH1xjpdSkH = __if_HfCHzZF42TgOZH1xjpdSkH;
                    this.__pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh = __pin_group_Input_In_HKAjq1JZOo5PoQm1MR3cWh;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ETfS04uD4GqMdJYEvrGDhk", Name = "__ETfS04uD4GqMdJYEvrGDhk")]
        [n2.SerializableAttribute]
        public class __ETfS04uD4GqMdJYEvrGDhk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TwUSt15uos4N8gr1zbMQjn);
                n1.CompilationHelper.SafeDispose(this.__p_UYEgl9FUkq8OPaWjxExZJ0);
                n1.CompilationHelper.SafeDispose(this.__p_EkOtf31YooKPN7W9Zoubg5);
                n1.CompilationHelper.SafeDispose(this.__p_JtHlwxvt8rMOz0Pv8Cl46M);
                return;
            }

            [n1.ElementAttribute(TracingId = 104215U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TwUSt15uos4N8gr1zbMQjn", Name = "DrawScale", IsManaged = true, IsAutoGenerated = true)]
            public n10.DrawScale_VCoaztTRPukLSgIjawVi6E __p_TwUSt15uos4N8gr1zbMQjn;
            [n1.ElementAttribute(TracingId = 104226U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UYEgl9FUkq8OPaWjxExZJ0", Name = "DrawTranslate", IsManaged = true, IsAutoGenerated = true)]
            public n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk __p_UYEgl9FUkq8OPaWjxExZJ0;
            [n1.ElementAttribute(TracingId = 104237U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "EkOtf31YooKPN7W9Zoubg5", Name = "DrawRotation", IsManaged = true, IsAutoGenerated = true)]
            public n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj __p_EkOtf31YooKPN7W9Zoubg5;
            [n1.ElementAttribute(TracingId = 104248U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JtHlwxvt8rMOz0Pv8Cl46M", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_JtHlwxvt8rMOz0Pv8Cl46M;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = default(n6.Spread<n8.ILayer>);
            public __ETfS04uD4GqMdJYEvrGDhk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ETfS04uD4GqMdJYEvrGDhk(__ETfS04uD4GqMdJYEvrGDhk other): base(other)
            {
                this.__p_TwUSt15uos4N8gr1zbMQjn = other.__p_TwUSt15uos4N8gr1zbMQjn;
                this.__p_UYEgl9FUkq8OPaWjxExZJ0 = other.__p_UYEgl9FUkq8OPaWjxExZJ0;
                this.__p_EkOtf31YooKPN7W9Zoubg5 = other.__p_EkOtf31YooKPN7W9Zoubg5;
                this.__p_JtHlwxvt8rMOz0Pv8Cl46M = other.__p_JtHlwxvt8rMOz0Pv8Cl46M;
                this.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = other.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TwUSt15uos4N8gr1zbMQjn", in __p_TwUSt15uos4N8gr1zbMQjn), n1.CompilationHelper.GetValueOrExisting(values, "__p_UYEgl9FUkq8OPaWjxExZJ0", in __p_UYEgl9FUkq8OPaWjxExZJ0), n1.CompilationHelper.GetValueOrExisting(values, "__p_EkOtf31YooKPN7W9Zoubg5", in __p_EkOtf31YooKPN7W9Zoubg5), n1.CompilationHelper.GetValueOrExisting(values, "__p_JtHlwxvt8rMOz0Pv8Cl46M", in __p_JtHlwxvt8rMOz0Pv8Cl46M), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M", in __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M));
            }

            internal __ETfS04uD4GqMdJYEvrGDhk __WITH__(n10.DrawScale_VCoaztTRPukLSgIjawVi6E __p_TwUSt15uos4N8gr1zbMQjn, n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk __p_UYEgl9FUkq8OPaWjxExZJ0, n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj __p_EkOtf31YooKPN7W9Zoubg5, n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_JtHlwxvt8rMOz0Pv8Cl46M, n6.Spread<n8.ILayer> __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M)
            {
                __ETfS04uD4GqMdJYEvrGDhk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TwUSt15uos4N8gr1zbMQjn != this.__p_TwUSt15uos4N8gr1zbMQjn || __p_UYEgl9FUkq8OPaWjxExZJ0 != this.__p_UYEgl9FUkq8OPaWjxExZJ0 || __p_EkOtf31YooKPN7W9Zoubg5 != this.__p_EkOtf31YooKPN7W9Zoubg5 || __p_JtHlwxvt8rMOz0Pv8Cl46M != this.__p_JtHlwxvt8rMOz0Pv8Cl46M || __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M != this.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M ? new __ETfS04uD4GqMdJYEvrGDhk(this)
                    {__p_TwUSt15uos4N8gr1zbMQjn = __p_TwUSt15uos4N8gr1zbMQjn, __p_UYEgl9FUkq8OPaWjxExZJ0 = __p_UYEgl9FUkq8OPaWjxExZJ0, __p_EkOtf31YooKPN7W9Zoubg5 = __p_EkOtf31YooKPN7W9Zoubg5, __p_JtHlwxvt8rMOz0Pv8Cl46M = __p_JtHlwxvt8rMOz0Pv8Cl46M, __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M} : that_0;
                else
                {
                    this.__p_TwUSt15uos4N8gr1zbMQjn = __p_TwUSt15uos4N8gr1zbMQjn;
                    this.__p_UYEgl9FUkq8OPaWjxExZJ0 = __p_UYEgl9FUkq8OPaWjxExZJ0;
                    this.__p_EkOtf31YooKPN7W9Zoubg5 = __p_EkOtf31YooKPN7W9Zoubg5;
                    this.__p_JtHlwxvt8rMOz0Pv8Cl46M = __p_JtHlwxvt8rMOz0Pv8Cl46M;
                    this.__pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M = __pin_group_Input_In_JtHlwxvt8rMOz0Pv8Cl46M;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 104335U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PQqoiyAh9ItOf66vhNibVw", Name = "PointsView_PQqoiyAh9ItOf66vhNibVw")]
    [n2.SerializableAttribute]
    public class PointsView_PQqoiyAh9ItOf66vhNibVw : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PointsView_PQqoiyAh9ItOf66vhNibVw Create(n1.NodeContext Node_Context)
        {
            var instance = new PointsView_PQqoiyAh9ItOf66vhNibVw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PointsView_PQqoiyAh9ItOf66vhNibVw CreateDefault()
        {
            var instance = new PointsView_PQqoiyAh9ItOf66vhNibVw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PointsView_PQqoiyAh9ItOf66vhNibVw Update(n6.Spread<n12.EditablePoint_R<n5.Vector2>> Points_In, n5.Color4 Point_Color_In, n5.Color4 Line_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Show_Line_In, [n4.SerializedDefaultValueAttribute("1", false)] float PickSize_In, [n4.SerializedDefaultValueAttribute("1", false)] float Zoom_In, out n8.ILayer Output_Out)
        {
            float __pad_EolFAfT9KFJNnkqmcRMASi_0 = __slot_EolFAfT9KFJNnkqmcRMASi;
            float __pad_PdQJoQsteQcQAM3N1ew8iW_1 = __slot_PdQJoQsteQcQAM3N1ew8iW;
            n5.Color4 __pad_PfGFb0EfCycLDIZbNyzCGq_2 = __slot_PfGFb0EfCycLDIZbNyzCGq;
            float __pad_IdkJMe3D3eWMdQDA1N5BRA_3 = __slot_IdkJMe3D3eWMdQDA1N5BRA;
            n5.Color4 __pad_Upvf9F0op70NTaV6j03bZG_4 = __slot_Upvf9F0op70NTaV6j03bZG;
            bool Force_5 = false;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_TkKeUFngj1aPckfx8KzVIg;
            if (manager_7 is null)
            {
                manager_7 = new n14.Manager<n2.ValueTuple<n6.Spread<n12.EditablePoint_R<n5.Vector2>>>, n2.ValueTuple<n6.Spread<n5.Vector2>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>>>((n23._Operations_.CreateDefault<n5.Vector2>(), n23._Operations_.CreateDefault<n12.EditablePoint_R<n5.Vector2>>(), n23._Operations_.CreateDefault<n12.EditablePoint_R<n5.Vector2>>(), n23._Operations_.CreateDefault<n12.EditablePoint_R<n5.Vector2>>()));
            }

            var inputs_8 = n2.ValueTuple.Create(Points_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__MPonqEXGYVLPw3mx0DdOr6>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __MPonqEXGYVLPw3mx0DdOr6(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_KQVrhjuu9KaN0hDBZS5gaF = n23._Operations_.CreateDefault<n5.Vector2>()};
                }

                var __fallback___12 = n1.ServiceRegistry.Current;
                n23._Operations_.Where<n12.EditablePoint_R<n5.Vector2>>(Input_In: Points_In, Predicate_In: (n12.EditablePoint_R<n5.Vector2> Arg_1_In_14, int Arg_2_In_15) =>
                {
                    using var __current_13 = __fallback___12.MakeCurrentIfNone();
                    var Output_23 = Arg_1_In_14.Split(Position_Out: out n5.Vector2 Position_16, Locked_Out: out bool Locked_17, Selected_Out: out bool Selected_18, Hovered_Out: out bool Hovered_19, KeyHovered_Out: out bool KeyHovered_20, SelectionModifier_Out: out int SelectionModifier_21, Id_Out: out int Id_22);
                    var Output_24 = !Selected_18;
                    return Output_24;
                }

                , Output_Out: out n6.Spread<n12.EditablePoint_R<n5.Vector2>> Output_25);
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_11.__cp_KQVrhjuu9KaN0hDBZS5gaF, 16);
                n6.Spread<n5.Vector2> output_40;
                try
                {
                    var i_28 = 0;
                    foreach (var item_26 in n4.CollectionExtensions.AsSpan(Points_In))
                    {
                        var splicer_27 = item_26;
                        var i_local_29 = i_28;
                        var Output_38 = splicer_27.Split(Position_Out: out n5.Vector2 Position_31, Locked_Out: out bool Locked_32, Selected_Out: out bool Selected_33, Hovered_Out: out bool Hovered_34, KeyHovered_Out: out bool KeyHovered_35, SelectionModifier_Out: out int SelectionModifier_36, Id_Out: out int Id_37);
                        builder_39.Add(Position_31);
                        i_28++;
                    }
                }
                finally
                {
                    output_40 = builder_39.Commit();
                }

                n23._Operations_.Where<n12.EditablePoint_R<n5.Vector2>>(Input_In: Points_In, Predicate_In: (n12.EditablePoint_R<n5.Vector2> Arg_1_In_42, int Arg_2_In_43) =>
                {
                    using var __current_41 = __fallback___12.MakeCurrentIfNone();
                    int __pad_Dp2QFoCMWDuQUSj3A0UMMU_44 = __slot_Dp2QFoCMWDuQUSj3A0UMMU;
                    var Output_52 = Arg_1_In_42.Split(Position_Out: out n5.Vector2 Position_45, Locked_Out: out bool Locked_46, Selected_Out: out bool Selected_47, Hovered_Out: out bool Hovered_48, KeyHovered_Out: out bool KeyHovered_49, SelectionModifier_Out: out int SelectionModifier_50, Id_Out: out int Id_51);
                    var Result_53 = SelectionModifier_50 > __pad_Dp2QFoCMWDuQUSj3A0UMMU_44;
                    var Output_54 = Selected_47 || Result_53;
                    return Output_54;
                }

                , Output_Out: out n6.Spread<n12.EditablePoint_R<n5.Vector2>> Output_55);
                n23._Operations_.Where<n12.EditablePoint_R<n5.Vector2>>(Input_In: Points_In, Predicate_In: (n12.EditablePoint_R<n5.Vector2> Arg_1_In_57, int Arg_2_In_58) =>
                {
                    using var __current_56 = __fallback___12.MakeCurrentIfNone();
                    var Output_66 = Arg_1_In_57.Split(Position_Out: out n5.Vector2 Position_59, Locked_Out: out bool Locked_60, Selected_Out: out bool Selected_61, Hovered_Out: out bool Hovered_62, KeyHovered_Out: out bool KeyHovered_63, SelectionModifier_Out: out int SelectionModifier_64, Id_Out: out int Id_65);
                    var Output_67 = Hovered_62 || KeyHovered_63;
                    return Output_67;
                }

                , Output_Out: out n6.Spread<n12.EditablePoint_R<n5.Vector2>> Output_68);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = output_40 != state_11.__cp_KQVrhjuu9KaN0hDBZS5gaF ? new __MPonqEXGYVLPw3mx0DdOr6(state_11)
                    {__cp_KQVrhjuu9KaN0hDBZS5gaF = output_40} : state_11;
                else
                {
                    state_11.__cp_KQVrhjuu9KaN0hDBZS5gaF = output_40;
                }

                outputs_9 = (output_40, Output_25, Output_55, Output_68);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var(All_Points_69, Normal_70, Selected_71, Hovered_72) = outputs_9;
            n9.SkiaPaint_R Input_73 = n9.SkiaPaint_R.CreateDefault();
            n13.SKShader Shader_74 = default(n13.SKShader);
            var State_Output_76 = this.__p_DoIFZeVSC3sMCZ8GNGXuO0.Update(Input_In: Input_73, Color_In: Point_Color_In, Shader_In: Shader_74, Output_Out: out n9.SkiaPaint_R Output_75);
            n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>> Input_77 = (n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>)Normal_70;
            var Output_78 = PickSize_In * Zoom_In;
            var State_Output_80 = this.__p_QZRX4KoR6p0PcbVUHKWLsU.Update(Input_In: Input_77, Size_In: Output_78, Paint_In: Output_75, Output_Out: out n18.PathLayer_C Output_79);
            var Output_81 = PickSize_In + __pad_EolFAfT9KFJNnkqmcRMASi_0;
            var Output_82 = Output_81 * Zoom_In;
            n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>> Input_83 = (n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>)Hovered_72;
            n9.SkiaPaint_R Input_84 = n9.SkiaPaint_R.CreateDefault();
            n13.SKStrokeJoin Join_85 = __c_IrjyA35JPr6NhFNOPNWxBw;
            n13.SKStrokeCap Cap_86 = __c_MWkMY7c8Z7cLElodYPqKLz;
            float Miter_87 = 0F;
            var State_Output_89 = this.__p_PL9Mp7aSjojOe2SzMegBkI.Update(Input_In: Input_84, Color_In: __pad_PfGFb0EfCycLDIZbNyzCGq_2, Stroke_Width_In: __pad_PdQJoQsteQcQAM3N1ew8iW_1, Join_In: Join_85, Cap_In: Cap_86, Miter_In: Miter_87, Output_Out: out n9.SkiaPaint_R Output_88);
            var State_Output_91 = this.__p_JOxZdRTxr7QMbAT2usOzxA.Update(Input_In: Input_83, Size_In: Output_82, Paint_In: Output_88, Output_Out: out n18.PathLayer_C Output_90);
            n8.ILayer Input_4_92 = (n8.ILayer)Output_90;
            n7.IEnumerable<n5.Vector2> Points_93 = (n7.IEnumerable<n5.Vector2>)All_Points_69;
            n9.SkiaPaint_R Input_94 = n9.SkiaPaint_R.CreateDefault();
            n13.SKStrokeJoin Join_95 = __c_MIU4acUcEknOwcM5EXrDXM;
            n13.SKStrokeCap Cap_96 = __c_F8h8unUXKtZOHSEMoaK7F1;
            float Miter_97 = 0F;
            var State_Output_99 = this.__p_GimdyXdRbnEOiHH8eUzN4g.Update(Input_In: Input_94, Color_In: Line_Color_In, Stroke_Width_In: __pad_IdkJMe3D3eWMdQDA1N5BRA_3, Join_In: Join_95, Cap_In: Cap_96, Miter_In: Miter_97, Output_Out: out n9.SkiaPaint_R Output_98);
            bool Closed_100 = false;
            n13.SKPathFillType Winding_101 = default(n13.SKPathFillType);
            var State_Output_103 = this.__p_AgfVaSTeEyeMe2JrsUvrTc.Update(Points_In: Points_93, Closed_In: Closed_100, Paint_In: Output_98, Winding_In: Winding_101, Enabled_In: Show_Line_In, Output_Out: out n18.PathLayer_C Output_102);
            n8.ILayer Input_104 = (n8.ILayer)Output_102;
            n8.ILayer Input_2_105 = (n8.ILayer)Output_79;
            n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>> Input_106 = (n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>)Selected_71;
            n9.SkiaPaint_R Input_107 = n9.SkiaPaint_R.CreateDefault();
            n13.SKShader Shader_108 = default(n13.SKShader);
            var State_Output_110 = this.__p_Fv47uVnbSMjPYUBhKYDavO.Update(Input_In: Input_107, Color_In: __pad_Upvf9F0op70NTaV6j03bZG_4, Shader_In: Shader_108, Output_Out: out n9.SkiaPaint_R Output_109);
            var State_Output_112 = this.__p_KJsAFDb1ag8OZOuRispgz1.Update(Input_In: Input_106, Size_In: Output_78, Paint_In: Output_109, Output_Out: out n18.PathLayer_C Output_111);
            n8.ILayer Input_3_113 = (n8.ILayer)Output_111;
            bool Debug_114 = false;
            bool Enabled_115 = true;
            var builder_116 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U, 4);
            builder_116.Add(Input_104);
            builder_116.Add(Input_2_105);
            builder_116.Add(Input_3_113);
            builder_116.Add(Input_4_92);
            var __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U_117 = builder_116.Commit();
            var State_Output_119 = this.__p_KRoSnCtm3JWLLOzy6AgQ8U.Update(Input_In: __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U_117, Debug_In: Debug_114, Enabled_In: Enabled_115, Output_Out: out n8.ILayer Output_118);
            Output_Out = Output_118;
            n3.PointsView_PQqoiyAh9ItOf66vhNibVw that_120 = this;
            if (this.__GetContext__().IsImmutable)
                that_120 = manager_7 != this.__cache_TkKeUFngj1aPckfx8KzVIg || State_Output_76 != this.__p_DoIFZeVSC3sMCZ8GNGXuO0 || State_Output_80 != this.__p_QZRX4KoR6p0PcbVUHKWLsU || State_Output_89 != this.__p_PL9Mp7aSjojOe2SzMegBkI || State_Output_91 != this.__p_JOxZdRTxr7QMbAT2usOzxA || State_Output_99 != this.__p_GimdyXdRbnEOiHH8eUzN4g || State_Output_103 != this.__p_AgfVaSTeEyeMe2JrsUvrTc || State_Output_110 != this.__p_Fv47uVnbSMjPYUBhKYDavO || State_Output_112 != this.__p_KJsAFDb1ag8OZOuRispgz1 || __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U_117 != this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U || State_Output_119 != this.__p_KRoSnCtm3JWLLOzy6AgQ8U ? new PointsView_PQqoiyAh9ItOf66vhNibVw(this)
                {__cache_TkKeUFngj1aPckfx8KzVIg = manager_7, __p_DoIFZeVSC3sMCZ8GNGXuO0 = State_Output_76, __p_QZRX4KoR6p0PcbVUHKWLsU = State_Output_80, __p_PL9Mp7aSjojOe2SzMegBkI = State_Output_89, __p_JOxZdRTxr7QMbAT2usOzxA = State_Output_91, __p_GimdyXdRbnEOiHH8eUzN4g = State_Output_99, __p_AgfVaSTeEyeMe2JrsUvrTc = State_Output_103, __p_Fv47uVnbSMjPYUBhKYDavO = State_Output_110, __p_KJsAFDb1ag8OZOuRispgz1 = State_Output_112, __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U_117, __p_KRoSnCtm3JWLLOzy6AgQ8U = State_Output_119} : that_120;
            else
            {
                this.__cache_TkKeUFngj1aPckfx8KzVIg = manager_7;
                this.__p_DoIFZeVSC3sMCZ8GNGXuO0 = State_Output_76;
                this.__p_QZRX4KoR6p0PcbVUHKWLsU = State_Output_80;
                this.__p_PL9Mp7aSjojOe2SzMegBkI = State_Output_89;
                this.__p_JOxZdRTxr7QMbAT2usOzxA = State_Output_91;
                this.__p_GimdyXdRbnEOiHH8eUzN4g = State_Output_99;
                this.__p_AgfVaSTeEyeMe2JrsUvrTc = State_Output_103;
                this.__p_Fv47uVnbSMjPYUBhKYDavO = State_Output_110;
                this.__p_KJsAFDb1ag8OZOuRispgz1 = State_Output_112;
                this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U_117;
                this.__p_KRoSnCtm3JWLLOzy6AgQ8U = State_Output_119;
            }

            return that_120;
        }

        public n3.PointsView_PQqoiyAh9ItOf66vhNibVw __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Fv47uVnbSMjPYUBhKYDavO", 104338U);
            var Output_1 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "QZRX4KoR6p0PcbVUHKWLsU", 104343U);
            var Output_3 = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "KJsAFDb1ag8OZOuRispgz1", 104348U);
            var Output_5 = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "JOxZdRTxr7QMbAT2usOzxA", 104353U);
            var Output_7 = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "PL9Mp7aSjojOe2SzMegBkI", 104358U);
            var Output_9 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "AgfVaSTeEyeMe2JrsUvrTc", 104374U);
            var Output_11 = n18.Polygon_OpmdO5gZr3xLcHs8bYnFf1.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "GimdyXdRbnEOiHH8eUzN4g", 104381U);
            var Output_13 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "DoIFZeVSC3sMCZ8GNGXuO0", 104494U);
            var Output_15 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "KRoSnCtm3JWLLOzy6AgQ8U", 104509U);
            var Output_17 = n9.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_16);
            n3.PointsView_PQqoiyAh9ItOf66vhNibVw that_18 = this;
            this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = n23._Operations_.CreateDefault<n8.ILayer>();
            this.__p_Fv47uVnbSMjPYUBhKYDavO = Output_1;
            this.__p_QZRX4KoR6p0PcbVUHKWLsU = Output_3;
            this.__p_KJsAFDb1ag8OZOuRispgz1 = Output_5;
            this.__p_JOxZdRTxr7QMbAT2usOzxA = Output_7;
            this.__p_PL9Mp7aSjojOe2SzMegBkI = Output_9;
            this.__p_AgfVaSTeEyeMe2JrsUvrTc = Output_11;
            this.__p_GimdyXdRbnEOiHH8eUzN4g = Output_13;
            this.__p_DoIFZeVSC3sMCZ8GNGXuO0 = Output_15;
            this.__p_KRoSnCtm3JWLLOzy6AgQ8U = Output_17;
            this.__cache_TkKeUFngj1aPckfx8KzVIg = null;
            return that_18;
        }

        public n3.PointsView_PQqoiyAh9ItOf66vhNibVw __CreateDefault__()
        {
            n3.PointsView_PQqoiyAh9ItOf66vhNibVw that_0 = this;
            this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = n23._Operations_.CreateDefault<n8.ILayer>();
            this.__cache_TkKeUFngj1aPckfx8KzVIg = null;
            this.__p_DoIFZeVSC3sMCZ8GNGXuO0 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.CreateDefault();
            this.__p_QZRX4KoR6p0PcbVUHKWLsU = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.CreateDefault();
            this.__p_PL9Mp7aSjojOe2SzMegBkI = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.CreateDefault();
            this.__p_JOxZdRTxr7QMbAT2usOzxA = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.CreateDefault();
            this.__p_GimdyXdRbnEOiHH8eUzN4g = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.CreateDefault();
            this.__p_AgfVaSTeEyeMe2JrsUvrTc = n18.Polygon_OpmdO5gZr3xLcHs8bYnFf1.CreateDefault();
            this.__p_Fv47uVnbSMjPYUBhKYDavO = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.CreateDefault();
            this.__p_KJsAFDb1ag8OZOuRispgz1 = n11.DrawPoints_Lml7tONfclPOARgsXFq7Br.CreateDefault();
            this.__p_KRoSnCtm3JWLLOzy6AgQ8U = n9.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_TkKeUFngj1aPckfx8KzVIg);
            n1.CompilationHelper.SafeDispose(this.__p_DoIFZeVSC3sMCZ8GNGXuO0);
            n1.CompilationHelper.SafeDispose(this.__p_QZRX4KoR6p0PcbVUHKWLsU);
            n1.CompilationHelper.SafeDispose(this.__p_PL9Mp7aSjojOe2SzMegBkI);
            n1.CompilationHelper.SafeDispose(this.__p_JOxZdRTxr7QMbAT2usOzxA);
            n1.CompilationHelper.SafeDispose(this.__p_GimdyXdRbnEOiHH8eUzN4g);
            n1.CompilationHelper.SafeDispose(this.__p_AgfVaSTeEyeMe2JrsUvrTc);
            n1.CompilationHelper.SafeDispose(this.__p_Fv47uVnbSMjPYUBhKYDavO);
            n1.CompilationHelper.SafeDispose(this.__p_KJsAFDb1ag8OZOuRispgz1);
            n1.CompilationHelper.SafeDispose(this.__p_KRoSnCtm3JWLLOzy6AgQ8U);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104366U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PdQJoQsteQcQAM3N1ew8iW", Name = "__slot_PdQJoQsteQcQAM3N1ew8iW")]
        public static float __slot_PdQJoQsteQcQAM3N1ew8iW = 0F;
        [n1.ElementAttribute(TracingId = 104367U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PfGFb0EfCycLDIZbNyzCGq", Name = "__slot_PfGFb0EfCycLDIZbNyzCGq")]
        public static n5.Color4 __slot_PfGFb0EfCycLDIZbNyzCGq = n1.CompilationHelper.Deserialize<n5.Color4>("0, 0.6999974, 1, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "PfGFb0EfCycLDIZbNyzCGq");
        [n1.ElementAttribute(TracingId = 104372U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "EolFAfT9KFJNnkqmcRMASi", Name = "__slot_EolFAfT9KFJNnkqmcRMASi")]
        public static float __slot_EolFAfT9KFJNnkqmcRMASi = 0.03F;
        [n1.ElementAttribute(TracingId = 104373U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Upvf9F0op70NTaV6j03bZG", Name = "__slot_Upvf9F0op70NTaV6j03bZG")]
        public static n5.Color4 __slot_Upvf9F0op70NTaV6j03bZG = n1.CompilationHelper.Deserialize<n5.Color4>("0, 0.7700002, 0.07700197, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "Upvf9F0op70NTaV6j03bZG");
        [n1.ElementAttribute(TracingId = 104389U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IdkJMe3D3eWMdQDA1N5BRA", Name = "__slot_IdkJMe3D3eWMdQDA1N5BRA")]
        public static float __slot_IdkJMe3D3eWMdQDA1N5BRA = 0F;
        [n1.ElementAttribute(TracingId = 104390U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TkKeUFngj1aPckfx8KzVIg", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n14.Manager<n2.ValueTuple<n6.Spread<n12.EditablePoint_R<n5.Vector2>>>, n2.ValueTuple<n6.Spread<n5.Vector2>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>>> __cache_TkKeUFngj1aPckfx8KzVIg = null;
        [n1.ElementAttribute(TracingId = 104451U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Dp2QFoCMWDuQUSj3A0UMMU", Name = "__slot_Dp2QFoCMWDuQUSj3A0UMMU")]
        public static int __slot_Dp2QFoCMWDuQUSj3A0UMMU = 0;
        [n1.ElementAttribute(TracingId = 104494U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DoIFZeVSC3sMCZ8GNGXuO0", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
        public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_DoIFZeVSC3sMCZ8GNGXuO0;
        [n1.ElementAttribute(TracingId = 104343U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "QZRX4KoR6p0PcbVUHKWLsU", Name = "DrawPoints", IsManaged = true, IsAutoGenerated = true)]
        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_QZRX4KoR6p0PcbVUHKWLsU;
        [n1.ElementAttribute(TracingId = 104358U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PL9Mp7aSjojOe2SzMegBkI", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
        public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_PL9Mp7aSjojOe2SzMegBkI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_IrjyA35JPr6NhFNOPNWxBw = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "IrjyA35JPr6NhFNOPNWxBw");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_MWkMY7c8Z7cLElodYPqKLz = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "MWkMY7c8Z7cLElodYPqKLz");
        [n1.ElementAttribute(TracingId = 104353U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JOxZdRTxr7QMbAT2usOzxA", Name = "DrawPoints", IsManaged = true, IsAutoGenerated = true)]
        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_JOxZdRTxr7QMbAT2usOzxA;
        [n1.ElementAttribute(TracingId = 104381U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GimdyXdRbnEOiHH8eUzN4g", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
        public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_GimdyXdRbnEOiHH8eUzN4g;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_MIU4acUcEknOwcM5EXrDXM = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "MIU4acUcEknOwcM5EXrDXM");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_F8h8unUXKtZOHSEMoaK7F1 = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "F8h8unUXKtZOHSEMoaK7F1");
        [n1.ElementAttribute(TracingId = 104374U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AgfVaSTeEyeMe2JrsUvrTc", Name = "Polygon", IsManaged = true, IsAutoGenerated = true)]
        public n18.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_AgfVaSTeEyeMe2JrsUvrTc;
        [n1.ElementAttribute(TracingId = 104338U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Fv47uVnbSMjPYUBhKYDavO", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
        public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Fv47uVnbSMjPYUBhKYDavO;
        [n1.ElementAttribute(TracingId = 104348U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KJsAFDb1ag8OZOuRispgz1", Name = "DrawPoints", IsManaged = true, IsAutoGenerated = true)]
        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_KJsAFDb1ag8OZOuRispgz1;
        [n1.ElementAttribute(TracingId = 104509U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KRoSnCtm3JWLLOzy6AgQ8U", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_KRoSnCtm3JWLLOzy6AgQ8U;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n8.ILayer> __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = default(n6.Spread<n8.ILayer>);
        static PointsView_PQqoiyAh9ItOf66vhNibVw()
        {
        }

        public PointsView_PQqoiyAh9ItOf66vhNibVw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointsView_PQqoiyAh9ItOf66vhNibVw(PointsView_PQqoiyAh9ItOf66vhNibVw other): base(other)
        {
            this.__cache_TkKeUFngj1aPckfx8KzVIg = other.__cache_TkKeUFngj1aPckfx8KzVIg;
            this.__p_DoIFZeVSC3sMCZ8GNGXuO0 = other.__p_DoIFZeVSC3sMCZ8GNGXuO0;
            this.__p_QZRX4KoR6p0PcbVUHKWLsU = other.__p_QZRX4KoR6p0PcbVUHKWLsU;
            this.__p_PL9Mp7aSjojOe2SzMegBkI = other.__p_PL9Mp7aSjojOe2SzMegBkI;
            this.__p_JOxZdRTxr7QMbAT2usOzxA = other.__p_JOxZdRTxr7QMbAT2usOzxA;
            this.__p_GimdyXdRbnEOiHH8eUzN4g = other.__p_GimdyXdRbnEOiHH8eUzN4g;
            this.__p_AgfVaSTeEyeMe2JrsUvrTc = other.__p_AgfVaSTeEyeMe2JrsUvrTc;
            this.__p_Fv47uVnbSMjPYUBhKYDavO = other.__p_Fv47uVnbSMjPYUBhKYDavO;
            this.__p_KJsAFDb1ag8OZOuRispgz1 = other.__p_KJsAFDb1ag8OZOuRispgz1;
            this.__p_KRoSnCtm3JWLLOzy6AgQ8U = other.__p_KRoSnCtm3JWLLOzy6AgQ8U;
            this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = other.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_TkKeUFngj1aPckfx8KzVIg", in __cache_TkKeUFngj1aPckfx8KzVIg), n1.CompilationHelper.GetValueOrExisting(values, "__p_DoIFZeVSC3sMCZ8GNGXuO0", in __p_DoIFZeVSC3sMCZ8GNGXuO0), n1.CompilationHelper.GetValueOrExisting(values, "__p_QZRX4KoR6p0PcbVUHKWLsU", in __p_QZRX4KoR6p0PcbVUHKWLsU), n1.CompilationHelper.GetValueOrExisting(values, "__p_PL9Mp7aSjojOe2SzMegBkI", in __p_PL9Mp7aSjojOe2SzMegBkI), n1.CompilationHelper.GetValueOrExisting(values, "__p_JOxZdRTxr7QMbAT2usOzxA", in __p_JOxZdRTxr7QMbAT2usOzxA), n1.CompilationHelper.GetValueOrExisting(values, "__p_GimdyXdRbnEOiHH8eUzN4g", in __p_GimdyXdRbnEOiHH8eUzN4g), n1.CompilationHelper.GetValueOrExisting(values, "__p_AgfVaSTeEyeMe2JrsUvrTc", in __p_AgfVaSTeEyeMe2JrsUvrTc), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fv47uVnbSMjPYUBhKYDavO", in __p_Fv47uVnbSMjPYUBhKYDavO), n1.CompilationHelper.GetValueOrExisting(values, "__p_KJsAFDb1ag8OZOuRispgz1", in __p_KJsAFDb1ag8OZOuRispgz1), n1.CompilationHelper.GetValueOrExisting(values, "__p_KRoSnCtm3JWLLOzy6AgQ8U", in __p_KRoSnCtm3JWLLOzy6AgQ8U), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U", in __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U));
        }

        internal PointsView_PQqoiyAh9ItOf66vhNibVw __WITH__(n14.Manager<n2.ValueTuple<n6.Spread<n12.EditablePoint_R<n5.Vector2>>>, n2.ValueTuple<n6.Spread<n5.Vector2>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>, n6.Spread<n12.EditablePoint_R<n5.Vector2>>>> __cache_TkKeUFngj1aPckfx8KzVIg, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_DoIFZeVSC3sMCZ8GNGXuO0, n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_QZRX4KoR6p0PcbVUHKWLsU, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_PL9Mp7aSjojOe2SzMegBkI, n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_JOxZdRTxr7QMbAT2usOzxA, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_GimdyXdRbnEOiHH8eUzN4g, n18.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_AgfVaSTeEyeMe2JrsUvrTc, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Fv47uVnbSMjPYUBhKYDavO, n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __p_KJsAFDb1ag8OZOuRispgz1, n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_KRoSnCtm3JWLLOzy6AgQ8U, n6.Spread<n8.ILayer> __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U)
        {
            n3.PointsView_PQqoiyAh9ItOf66vhNibVw that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_TkKeUFngj1aPckfx8KzVIg != this.__cache_TkKeUFngj1aPckfx8KzVIg || __p_DoIFZeVSC3sMCZ8GNGXuO0 != this.__p_DoIFZeVSC3sMCZ8GNGXuO0 || __p_QZRX4KoR6p0PcbVUHKWLsU != this.__p_QZRX4KoR6p0PcbVUHKWLsU || __p_PL9Mp7aSjojOe2SzMegBkI != this.__p_PL9Mp7aSjojOe2SzMegBkI || __p_JOxZdRTxr7QMbAT2usOzxA != this.__p_JOxZdRTxr7QMbAT2usOzxA || __p_GimdyXdRbnEOiHH8eUzN4g != this.__p_GimdyXdRbnEOiHH8eUzN4g || __p_AgfVaSTeEyeMe2JrsUvrTc != this.__p_AgfVaSTeEyeMe2JrsUvrTc || __p_Fv47uVnbSMjPYUBhKYDavO != this.__p_Fv47uVnbSMjPYUBhKYDavO || __p_KJsAFDb1ag8OZOuRispgz1 != this.__p_KJsAFDb1ag8OZOuRispgz1 || __p_KRoSnCtm3JWLLOzy6AgQ8U != this.__p_KRoSnCtm3JWLLOzy6AgQ8U || __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U != this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U ? new PointsView_PQqoiyAh9ItOf66vhNibVw(this)
                {__cache_TkKeUFngj1aPckfx8KzVIg = __cache_TkKeUFngj1aPckfx8KzVIg, __p_DoIFZeVSC3sMCZ8GNGXuO0 = __p_DoIFZeVSC3sMCZ8GNGXuO0, __p_QZRX4KoR6p0PcbVUHKWLsU = __p_QZRX4KoR6p0PcbVUHKWLsU, __p_PL9Mp7aSjojOe2SzMegBkI = __p_PL9Mp7aSjojOe2SzMegBkI, __p_JOxZdRTxr7QMbAT2usOzxA = __p_JOxZdRTxr7QMbAT2usOzxA, __p_GimdyXdRbnEOiHH8eUzN4g = __p_GimdyXdRbnEOiHH8eUzN4g, __p_AgfVaSTeEyeMe2JrsUvrTc = __p_AgfVaSTeEyeMe2JrsUvrTc, __p_Fv47uVnbSMjPYUBhKYDavO = __p_Fv47uVnbSMjPYUBhKYDavO, __p_KJsAFDb1ag8OZOuRispgz1 = __p_KJsAFDb1ag8OZOuRispgz1, __p_KRoSnCtm3JWLLOzy6AgQ8U = __p_KRoSnCtm3JWLLOzy6AgQ8U, __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U} : that_0;
            else
            {
                this.__cache_TkKeUFngj1aPckfx8KzVIg = __cache_TkKeUFngj1aPckfx8KzVIg;
                this.__p_DoIFZeVSC3sMCZ8GNGXuO0 = __p_DoIFZeVSC3sMCZ8GNGXuO0;
                this.__p_QZRX4KoR6p0PcbVUHKWLsU = __p_QZRX4KoR6p0PcbVUHKWLsU;
                this.__p_PL9Mp7aSjojOe2SzMegBkI = __p_PL9Mp7aSjojOe2SzMegBkI;
                this.__p_JOxZdRTxr7QMbAT2usOzxA = __p_JOxZdRTxr7QMbAT2usOzxA;
                this.__p_GimdyXdRbnEOiHH8eUzN4g = __p_GimdyXdRbnEOiHH8eUzN4g;
                this.__p_AgfVaSTeEyeMe2JrsUvrTc = __p_AgfVaSTeEyeMe2JrsUvrTc;
                this.__p_Fv47uVnbSMjPYUBhKYDavO = __p_Fv47uVnbSMjPYUBhKYDavO;
                this.__p_KJsAFDb1ag8OZOuRispgz1 = __p_KJsAFDb1ag8OZOuRispgz1;
                this.__p_KRoSnCtm3JWLLOzy6AgQ8U = __p_KRoSnCtm3JWLLOzy6AgQ8U;
                this.__pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U = __pin_group_Input_In_KRoSnCtm3JWLLOzy6AgQ8U;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MPonqEXGYVLPw3mx0DdOr6", Name = "__MPonqEXGYVLPw3mx0DdOr6")]
        [n2.SerializableAttribute]
        public class __MPonqEXGYVLPw3mx0DdOr6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n5.Vector2> __cp_KQVrhjuu9KaN0hDBZS5gaF;
            public __MPonqEXGYVLPw3mx0DdOr6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MPonqEXGYVLPw3mx0DdOr6(__MPonqEXGYVLPw3mx0DdOr6 other): base(other)
            {
                this.__cp_KQVrhjuu9KaN0hDBZS5gaF = other.__cp_KQVrhjuu9KaN0hDBZS5gaF;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_KQVrhjuu9KaN0hDBZS5gaF", in __cp_KQVrhjuu9KaN0hDBZS5gaF));
            }

            internal __MPonqEXGYVLPw3mx0DdOr6 __WITH__(n6.Spread<n5.Vector2> __cp_KQVrhjuu9KaN0hDBZS5gaF)
            {
                __MPonqEXGYVLPw3mx0DdOr6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_KQVrhjuu9KaN0hDBZS5gaF != this.__cp_KQVrhjuu9KaN0hDBZS5gaF ? new __MPonqEXGYVLPw3mx0DdOr6(this)
                    {__cp_KQVrhjuu9KaN0hDBZS5gaF = __cp_KQVrhjuu9KaN0hDBZS5gaF} : that_0;
                else
                {
                    this.__cp_KQVrhjuu9KaN0hDBZS5gaF = __cp_KQVrhjuu9KaN0hDBZS5gaF;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 104685U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "K88djuDkMfIOXDig3JmLMD", Name = "PointEditorControls_K88djuDkMfIOXDig3JmLMD")]
    [n2.SerializableAttribute]
    public class PointEditorControls_K88djuDkMfIOXDig3JmLMD : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD Create(n1.NodeContext Node_Context)
        {
            var instance = new PointEditorControls_K88djuDkMfIOXDig3JmLMD(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD CreateDefault()
        {
            var instance = new PointEditorControls_K88djuDkMfIOXDig3JmLMD(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD Join(n35.IMouse Mouse_Device_In, n35.IKeyboard Keyboard_Device_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n12.PointEditorControlsData_R PointEditor_Controls_Out)
        {
            n12.PointEditorControlsData_R __auto_0 = this.PointEditorControlsData;
            string __pad_Bax7yrAKoSCMoEUa04bm7J_1 = __slot_Bax7yrAKoSCMoEUa04bm7J;
            string __pad_Ax1wG6eUwdJOUKimRPhYJt_2 = __slot_Ax1wG6eUwdJOUKimRPhYJt;
            string __pad_KrEqFoo9kYVNZfJuSNcN61_3 = __slot_KrEqFoo9kYVNZfJuSNcN61;
            string __pad_REBhsgXxUbNPEBpSEPyXDy_4 = __slot_REBhsgXxUbNPEBpSEPyXDy;
            string __pad_U4zzinW9ys8NJTgUd2PHVW_5 = __slot_U4zzinW9ys8NJTgUd2PHVW;
            string __pad_PShIthT7SbCNtWio34NXnW_6 = __slot_PShIthT7SbCNtWio34NXnW;
            string __pad_I5RDiv004PBLBW5svGx9rm_7 = __slot_I5RDiv004PBLBW5svGx9rm;
            string __pad_K5nATbckZccMY62AiLq12L_8 = __slot_K5nATbckZccMY62AiLq12L;
            string __pad_Btk3JQFiD6zNbonRASvMoJ_9 = __slot_Btk3JQFiD6zNbonRASvMoJ;
            string __pad_TKFGXUbyTK3P9LSOEd0Bha_10 = __slot_TKFGXUbyTK3P9LSOEd0Bha;
            string __pad_OtaeD2CaUGvPxgCQwp6Gd0_11 = __slot_OtaeD2CaUGvPxgCQwp6Gd0;
            string __pad_JDqXz6QDNp3LYaumqIXE2Y_12 = __slot_JDqXz6QDNp3LYaumqIXE2Y;
            var Output_23 = this.__p_FbTAmyZwxh4PDi4947HJjt.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n5.Vector2 Position_In_World_13, Position_In_Projection_Out: out n5.Vector2 Position_In_Projection_14, Position_Out: out n5.Vector2 Position_15, Left_Pressed_Out: out bool Left_Pressed_16, Middle_Pressed_Out: out bool Middle_Pressed_17, Right_Pressed_Out: out bool Right_Pressed_18, Normalized_Position_Out: out n5.Vector2 Normalized_Position_19, WheelDelta_Out: out int WheelDelta_20, Client_Area_Out: out n5.Vector2 Client_Area_21, Sender_Out: out n2.Object Sender_22);
            var Output_25 = this.__p_MYT7NBe6ZA5M8FhitG7s3f.Update(Position_In: Position_In_World_13, Select_In: Left_Pressed_16, Selection_Out: out n5.RectangleF Selection_24);
            var Output_27 = this.__p_AIYzm8BEKn6Pihwhc0NmQY.Update(Keyboard_Device_In: Keyboard_Device_In, Pressed_Keys_Out: out n34.ImmutableHashSet<n33.Keys> Pressed_Keys_26);
            var Output_29 = this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Bax7yrAKoSCMoEUa04bm7J_1, Is_Down_Out: out bool Is_Down_28);
            var Output_31 = this.__p_GwqertOIO7LL0iDBHpGXfs.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_JDqXz6QDNp3LYaumqIXE2Y_12, Is_Down_Out: out bool Is_Down_30);
            var Output_32 = Is_Down_28 || Is_Down_30;
            var Output_35 = this.__p_Jytdo1HLXg6N55DBFl6qEB.Update(Value_In: Output_32, Up_Edge_Out: out bool Up_Edge_33, Down_Edge_Out: out bool Down_Edge_34);
            var Output_37 = this.__p_J9pNb6eGBGmNC0pE37Ufx7.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Ax1wG6eUwdJOUKimRPhYJt_2, Is_Down_Out: out bool Is_Down_36);
            var Output_39 = this.__p_HcGw1tsZTzFPHzrnMGP0cl.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_PShIthT7SbCNtWio34NXnW_6, Is_Down_Out: out bool Is_Down_38);
            var Output_41 = this.__p_HtTMzduVFsyM2bvTdyzWMP.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_OtaeD2CaUGvPxgCQwp6Gd0_11, Is_Down_Out: out bool Is_Down_40);
            var Output_44 = this.__p_VhLbGCSvXa5Nt3pc4LKcPT.Update(Value_In: Is_Down_40, Up_Edge_Out: out bool Up_Edge_42, Down_Edge_Out: out bool Down_Edge_43);
            var Output_45 = !Is_Down_38;
            var Output_47 = this.__p_FUSNjsspejYMbkWBJN5ogn.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_Btk3JQFiD6zNbonRASvMoJ_9, Is_Down_Out: out bool Is_Down_46);
            var Output_50 = this.__p_HYovc4SindRN3P4XkHAPJx.Update(Value_In: Is_Down_46, Up_Edge_Out: out bool Up_Edge_48, Down_Edge_Out: out bool Down_Edge_49);
            var Output_51 = Output_45 && Up_Edge_48;
            var Output_52 = Is_Down_38 && Up_Edge_48;
            var Output_54 = this.__p_UczaGvV2R0nNFVMlGFUSXy.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_KrEqFoo9kYVNZfJuSNcN61_3, Is_Down_Out: out bool Is_Down_53);
            var Output_55 = Is_Down_53 && Is_Down_36;
            var Output_57 = this.__p_OmeiCJMSnM3NzFwKrY3TO4.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_U4zzinW9ys8NJTgUd2PHVW_5, Is_Down_Out: out bool Is_Down_56);
            var Output_59 = this.__p_L6rH0FSkE3JQHP8rP34W3r.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_REBhsgXxUbNPEBpSEPyXDy_4, Is_Down_Out: out bool Is_Down_58);
            var Output_61 = this.__p_Fa4XlYweaZBO6Z0fg0wVpE.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_TKFGXUbyTK3P9LSOEd0Bha_10, Is_Down_Out: out bool Is_Down_60);
            var Output_63 = this.__p_LMooO2MTmHPNtjh00admE2.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_I5RDiv004PBLBW5svGx9rm_7, Is_Down_Out: out bool Is_Down_62);
            var Output_65 = this.__p_KhuI1dYqRyeNyKnGKVo88D.Update(Keys_In: Pressed_Keys_26, Key_Name_In: __pad_K5nATbckZccMY62AiLq12L_8, Is_Down_Out: out bool Is_Down_64);
            var Output_66 = Is_Down_62 && Is_Down_64;
            bool Apply_67 = true;
            var Output_68 = Is_Down_38;
            if (Apply_67)
            {
                var Output_69 = !Is_Down_38;
                Output_68 = Output_69;
            }

            var Output_70 = Output_66 && Output_68;
            var Output_73 = this.__p_HwRNPxgZpeHNyVBa7gvwSl.Update(Value_In: Output_70, Up_Edge_Out: out bool Up_Edge_71, Down_Edge_Out: out bool Down_Edge_72);
            var Output_74 = Output_66 && Is_Down_38;
            var Output_77 = this.__p_C3RBvFIzZqpPfmgVaq2VYL.Update(Value_In: Output_74, Up_Edge_Out: out bool Up_Edge_75, Down_Edge_Out: out bool Down_Edge_76);
            var Output_78 = __auto_0;
            if (Enabled_In)
            {
                Output_78 = __auto_0.Join(Pointer_Position_In: Position_In_World_13, Mouse_Pressed_In: Left_Pressed_16, Selection_In: Selection_24, Remove_Selected_In: Up_Edge_33, Control_In: Is_Down_36, Shift_In: Is_Down_38, Space_In: Up_Edge_42, Hover_Next_In: Output_51, Hover_Previous_In: Output_52, Select_All_In: Output_55, Scale_In: Is_Down_56, Rotate_In: Is_Down_58, Translate_In: Is_Down_60, Undo_In: Up_Edge_71, Redo_In: Up_Edge_75);
            }

            bool __pad_Tf6h2HvioG3LgmmnXerxVV_79 = Output_52;
            n12.PointEditorControlsData_R __auto_80 = Output_78;
            PointEditor_Controls_Out = Output_78;
            n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD that_81 = this;
            if (this.__GetContext__().IsImmutable)
                that_81 = Output_23 != this.__p_FbTAmyZwxh4PDi4947HJjt || Output_25 != this.__p_MYT7NBe6ZA5M8FhitG7s3f || Output_27 != this.__p_AIYzm8BEKn6Pihwhc0NmQY || Output_29 != this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a || Output_31 != this.__p_GwqertOIO7LL0iDBHpGXfs || Output_35 != this.__p_Jytdo1HLXg6N55DBFl6qEB || Output_37 != this.__p_J9pNb6eGBGmNC0pE37Ufx7 || Output_39 != this.__p_HcGw1tsZTzFPHzrnMGP0cl || Output_41 != this.__p_HtTMzduVFsyM2bvTdyzWMP || Output_44 != this.__p_VhLbGCSvXa5Nt3pc4LKcPT || Output_47 != this.__p_FUSNjsspejYMbkWBJN5ogn || Output_50 != this.__p_HYovc4SindRN3P4XkHAPJx || Output_54 != this.__p_UczaGvV2R0nNFVMlGFUSXy || Output_57 != this.__p_OmeiCJMSnM3NzFwKrY3TO4 || Output_59 != this.__p_L6rH0FSkE3JQHP8rP34W3r || Output_61 != this.__p_Fa4XlYweaZBO6Z0fg0wVpE || Output_63 != this.__p_LMooO2MTmHPNtjh00admE2 || Output_65 != this.__p_KhuI1dYqRyeNyKnGKVo88D || Output_73 != this.__p_HwRNPxgZpeHNyVBa7gvwSl || Output_77 != this.__p_C3RBvFIzZqpPfmgVaq2VYL || Output_52 != this.__slot_Tf6h2HvioG3LgmmnXerxVV || Output_78 != this.PointEditorControlsData ? new PointEditorControls_K88djuDkMfIOXDig3JmLMD(this)
                {__p_FbTAmyZwxh4PDi4947HJjt = Output_23, __p_MYT7NBe6ZA5M8FhitG7s3f = Output_25, __p_AIYzm8BEKn6Pihwhc0NmQY = Output_27, __p_Sgy3sl0uMF0NBOjhJ1lJ0a = Output_29, __p_GwqertOIO7LL0iDBHpGXfs = Output_31, __p_Jytdo1HLXg6N55DBFl6qEB = Output_35, __p_J9pNb6eGBGmNC0pE37Ufx7 = Output_37, __p_HcGw1tsZTzFPHzrnMGP0cl = Output_39, __p_HtTMzduVFsyM2bvTdyzWMP = Output_41, __p_VhLbGCSvXa5Nt3pc4LKcPT = Output_44, __p_FUSNjsspejYMbkWBJN5ogn = Output_47, __p_HYovc4SindRN3P4XkHAPJx = Output_50, __p_UczaGvV2R0nNFVMlGFUSXy = Output_54, __p_OmeiCJMSnM3NzFwKrY3TO4 = Output_57, __p_L6rH0FSkE3JQHP8rP34W3r = Output_59, __p_Fa4XlYweaZBO6Z0fg0wVpE = Output_61, __p_LMooO2MTmHPNtjh00admE2 = Output_63, __p_KhuI1dYqRyeNyKnGKVo88D = Output_65, __p_HwRNPxgZpeHNyVBa7gvwSl = Output_73, __p_C3RBvFIzZqpPfmgVaq2VYL = Output_77, __slot_Tf6h2HvioG3LgmmnXerxVV = Output_52, PointEditorControlsData = Output_78} : that_81;
            else
            {
                this.__p_FbTAmyZwxh4PDi4947HJjt = Output_23;
                this.__p_MYT7NBe6ZA5M8FhitG7s3f = Output_25;
                this.__p_AIYzm8BEKn6Pihwhc0NmQY = Output_27;
                this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a = Output_29;
                this.__p_GwqertOIO7LL0iDBHpGXfs = Output_31;
                this.__p_Jytdo1HLXg6N55DBFl6qEB = Output_35;
                this.__p_J9pNb6eGBGmNC0pE37Ufx7 = Output_37;
                this.__p_HcGw1tsZTzFPHzrnMGP0cl = Output_39;
                this.__p_HtTMzduVFsyM2bvTdyzWMP = Output_41;
                this.__p_VhLbGCSvXa5Nt3pc4LKcPT = Output_44;
                this.__p_FUSNjsspejYMbkWBJN5ogn = Output_47;
                this.__p_HYovc4SindRN3P4XkHAPJx = Output_50;
                this.__p_UczaGvV2R0nNFVMlGFUSXy = Output_54;
                this.__p_OmeiCJMSnM3NzFwKrY3TO4 = Output_57;
                this.__p_L6rH0FSkE3JQHP8rP34W3r = Output_59;
                this.__p_Fa4XlYweaZBO6Z0fg0wVpE = Output_61;
                this.__p_LMooO2MTmHPNtjh00admE2 = Output_63;
                this.__p_KhuI1dYqRyeNyKnGKVo88D = Output_65;
                this.__p_HwRNPxgZpeHNyVBa7gvwSl = Output_73;
                this.__p_C3RBvFIzZqpPfmgVaq2VYL = Output_77;
                this.__slot_Tf6h2HvioG3LgmmnXerxVV = Output_52;
                this.PointEditorControlsData = Output_78;
            }

            return that_81;
        }

        public n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "FbTAmyZwxh4PDi4947HJjt", 104737U);
            var Output_1 = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "AIYzm8BEKn6Pihwhc0NmQY", 104758U);
            var Output_3 = n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "J9pNb6eGBGmNC0pE37Ufx7", 104766U);
            var Output_5 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "MYT7NBe6ZA5M8FhitG7s3f", 104776U);
            var Output_7 = n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "L6rH0FSkE3JQHP8rP34W3r", 104783U);
            var Output_9 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "OmeiCJMSnM3NzFwKrY3TO4", 104790U);
            var Output_11 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HcGw1tsZTzFPHzrnMGP0cl", 104798U);
            var Output_13 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "UczaGvV2R0nNFVMlGFUSXy", 104815U);
            var Output_15 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Sgy3sl0uMF0NBOjhJ1lJ0a", 104859U);
            var Output_17 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "KhuI1dYqRyeNyKnGKVo88D", 104865U);
            var Output_19 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "LMooO2MTmHPNtjh00admE2", 104869U);
            var Output_21 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HwRNPxgZpeHNyVBa7gvwSl", 104885U);
            var Output_23 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "C3RBvFIzZqpPfmgVaq2VYL", 104889U);
            var Output_25 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Fa4XlYweaZBO6Z0fg0wVpE", 104893U);
            var Output_27 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HtTMzduVFsyM2bvTdyzWMP", 104902U);
            var Output_29 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "VhLbGCSvXa5Nt3pc4LKcPT", 104906U);
            var Output_31 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "FUSNjsspejYMbkWBJN5ogn", 104911U);
            var Output_33 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_32);
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HYovc4SindRN3P4XkHAPJx", 104922U);
            var Output_35 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_34);
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "GwqertOIO7LL0iDBHpGXfs", 104931U);
            var Output_37 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_36);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Jytdo1HLXg6N55DBFl6qEB", 104939U);
            var Output_39 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_38);
            n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD that_40 = this;
            this.PointEditorControlsData = n12.PointEditorControlsData_R.CreateDefault();
            this.__slot_Tf6h2HvioG3LgmmnXerxVV = false;
            this.__p_FbTAmyZwxh4PDi4947HJjt = Output_1;
            this.__p_AIYzm8BEKn6Pihwhc0NmQY = Output_3;
            this.__p_J9pNb6eGBGmNC0pE37Ufx7 = Output_5;
            this.__p_MYT7NBe6ZA5M8FhitG7s3f = Output_7;
            this.__p_L6rH0FSkE3JQHP8rP34W3r = Output_9;
            this.__p_OmeiCJMSnM3NzFwKrY3TO4 = Output_11;
            this.__p_HcGw1tsZTzFPHzrnMGP0cl = Output_13;
            this.__p_UczaGvV2R0nNFVMlGFUSXy = Output_15;
            this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a = Output_17;
            this.__p_KhuI1dYqRyeNyKnGKVo88D = Output_19;
            this.__p_LMooO2MTmHPNtjh00admE2 = Output_21;
            this.__p_HwRNPxgZpeHNyVBa7gvwSl = Output_23;
            this.__p_C3RBvFIzZqpPfmgVaq2VYL = Output_25;
            this.__p_Fa4XlYweaZBO6Z0fg0wVpE = Output_27;
            this.__p_HtTMzduVFsyM2bvTdyzWMP = Output_29;
            this.__p_VhLbGCSvXa5Nt3pc4LKcPT = Output_31;
            this.__p_FUSNjsspejYMbkWBJN5ogn = Output_33;
            this.__p_HYovc4SindRN3P4XkHAPJx = Output_35;
            this.__p_GwqertOIO7LL0iDBHpGXfs = Output_37;
            this.__p_Jytdo1HLXg6N55DBFl6qEB = Output_39;
            return that_40;
        }

        public n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD __CreateDefault__()
        {
            n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD that_0 = this;
            this.PointEditorControlsData = n12.PointEditorControlsData_R.CreateDefault();
            this.__slot_Tf6h2HvioG3LgmmnXerxVV = false;
            this.__p_FbTAmyZwxh4PDi4947HJjt = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_MYT7NBe6ZA5M8FhitG7s3f = n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7.CreateDefault();
            this.__p_AIYzm8BEKn6Pihwhc0NmQY = n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_GwqertOIO7LL0iDBHpGXfs = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Jytdo1HLXg6N55DBFl6qEB = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_J9pNb6eGBGmNC0pE37Ufx7 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_HcGw1tsZTzFPHzrnMGP0cl = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_HtTMzduVFsyM2bvTdyzWMP = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_VhLbGCSvXa5Nt3pc4LKcPT = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_FUSNjsspejYMbkWBJN5ogn = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_HYovc4SindRN3P4XkHAPJx = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_UczaGvV2R0nNFVMlGFUSXy = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_OmeiCJMSnM3NzFwKrY3TO4 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_L6rH0FSkE3JQHP8rP34W3r = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Fa4XlYweaZBO6Z0fg0wVpE = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LMooO2MTmHPNtjh00admE2 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_KhuI1dYqRyeNyKnGKVo88D = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_HwRNPxgZpeHNyVBa7gvwSl = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_C3RBvFIzZqpPfmgVaq2VYL = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FbTAmyZwxh4PDi4947HJjt);
            n1.CompilationHelper.SafeDispose(this.__p_MYT7NBe6ZA5M8FhitG7s3f);
            n1.CompilationHelper.SafeDispose(this.__p_AIYzm8BEKn6Pihwhc0NmQY);
            n1.CompilationHelper.SafeDispose(this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a);
            n1.CompilationHelper.SafeDispose(this.__p_GwqertOIO7LL0iDBHpGXfs);
            n1.CompilationHelper.SafeDispose(this.__p_Jytdo1HLXg6N55DBFl6qEB);
            n1.CompilationHelper.SafeDispose(this.__p_J9pNb6eGBGmNC0pE37Ufx7);
            n1.CompilationHelper.SafeDispose(this.__p_HcGw1tsZTzFPHzrnMGP0cl);
            n1.CompilationHelper.SafeDispose(this.__p_HtTMzduVFsyM2bvTdyzWMP);
            n1.CompilationHelper.SafeDispose(this.__p_VhLbGCSvXa5Nt3pc4LKcPT);
            n1.CompilationHelper.SafeDispose(this.__p_FUSNjsspejYMbkWBJN5ogn);
            n1.CompilationHelper.SafeDispose(this.__p_HYovc4SindRN3P4XkHAPJx);
            n1.CompilationHelper.SafeDispose(this.__p_UczaGvV2R0nNFVMlGFUSXy);
            n1.CompilationHelper.SafeDispose(this.__p_OmeiCJMSnM3NzFwKrY3TO4);
            n1.CompilationHelper.SafeDispose(this.__p_L6rH0FSkE3JQHP8rP34W3r);
            n1.CompilationHelper.SafeDispose(this.__p_Fa4XlYweaZBO6Z0fg0wVpE);
            n1.CompilationHelper.SafeDispose(this.__p_LMooO2MTmHPNtjh00admE2);
            n1.CompilationHelper.SafeDispose(this.__p_KhuI1dYqRyeNyKnGKVo88D);
            n1.CompilationHelper.SafeDispose(this.__p_HwRNPxgZpeHNyVBa7gvwSl);
            n1.CompilationHelper.SafeDispose(this.__p_C3RBvFIzZqpPfmgVaq2VYL);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104687U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JCSSqsMvTsQPSKoSKwXPkd", Name = "PointEditorControlsData")]
        public n12.PointEditorControlsData_R PointEditorControlsData;
        [n1.ElementAttribute(TracingId = 104711U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Ax1wG6eUwdJOUKimRPhYJt", Name = "__slot_Ax1wG6eUwdJOUKimRPhYJt")]
        public static string __slot_Ax1wG6eUwdJOUKimRPhYJt = "ControlKey";
        [n1.ElementAttribute(TracingId = 104712U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "REBhsgXxUbNPEBpSEPyXDy", Name = "__slot_REBhsgXxUbNPEBpSEPyXDy")]
        public static string __slot_REBhsgXxUbNPEBpSEPyXDy = "C";
        [n1.ElementAttribute(TracingId = 104713U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "U4zzinW9ys8NJTgUd2PHVW", Name = "__slot_U4zzinW9ys8NJTgUd2PHVW")]
        public static string __slot_U4zzinW9ys8NJTgUd2PHVW = "X";
        [n1.ElementAttribute(TracingId = 104716U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PShIthT7SbCNtWio34NXnW", Name = "__slot_PShIthT7SbCNtWio34NXnW")]
        public static string __slot_PShIthT7SbCNtWio34NXnW = "ShiftKey";
        [n1.ElementAttribute(TracingId = 104720U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KrEqFoo9kYVNZfJuSNcN61", Name = "__slot_KrEqFoo9kYVNZfJuSNcN61")]
        public static string __slot_KrEqFoo9kYVNZfJuSNcN61 = "A";
        [n1.ElementAttribute(TracingId = 104725U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Bax7yrAKoSCMoEUa04bm7J", Name = "__slot_Bax7yrAKoSCMoEUa04bm7J")]
        public static string __slot_Bax7yrAKoSCMoEUa04bm7J = "Delete";
        [n1.ElementAttribute(TracingId = 104729U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "K5nATbckZccMY62AiLq12L", Name = "__slot_K5nATbckZccMY62AiLq12L")]
        public static string __slot_K5nATbckZccMY62AiLq12L = "ControlKey";
        [n1.ElementAttribute(TracingId = 104732U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "I5RDiv004PBLBW5svGx9rm", Name = "__slot_I5RDiv004PBLBW5svGx9rm")]
        public static string __slot_I5RDiv004PBLBW5svGx9rm = "Z";
        [n1.ElementAttribute(TracingId = 104733U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TKFGXUbyTK3P9LSOEd0Bha", Name = "__slot_TKFGXUbyTK3P9LSOEd0Bha")]
        public static string __slot_TKFGXUbyTK3P9LSOEd0Bha = "V";
        [n1.ElementAttribute(TracingId = 104901U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "OtaeD2CaUGvPxgCQwp6Gd0", Name = "__slot_OtaeD2CaUGvPxgCQwp6Gd0")]
        public static string __slot_OtaeD2CaUGvPxgCQwp6Gd0 = "Space";
        [n1.ElementAttribute(TracingId = 104910U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Btk3JQFiD6zNbonRASvMoJ", Name = "__slot_Btk3JQFiD6zNbonRASvMoJ")]
        public static string __slot_Btk3JQFiD6zNbonRASvMoJ = "Q";
        [n1.ElementAttribute(TracingId = 104930U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JDqXz6QDNp3LYaumqIXE2Y", Name = "__slot_JDqXz6QDNp3LYaumqIXE2Y")]
        public static string __slot_JDqXz6QDNp3LYaumqIXE2Y = "Back";
        [n1.ElementAttribute(TracingId = 104943U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Tf6h2HvioG3LgmmnXerxVV", Name = "__slot_Tf6h2HvioG3LgmmnXerxVV")]
        public bool __slot_Tf6h2HvioG3LgmmnXerxVV;
        [n1.ElementAttribute(TracingId = 104737U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FbTAmyZwxh4PDi4947HJjt", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_FbTAmyZwxh4PDi4947HJjt;
        [n1.ElementAttribute(TracingId = 104776U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MYT7NBe6ZA5M8FhitG7s3f", Name = "SelectionRect", IsManaged = true, IsAutoGenerated = true)]
        public n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 __p_MYT7NBe6ZA5M8FhitG7s3f;
        [n1.ElementAttribute(TracingId = 104758U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AIYzm8BEKn6Pihwhc0NmQY", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_AIYzm8BEKn6Pihwhc0NmQY;
        [n1.ElementAttribute(TracingId = 104859U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Sgy3sl0uMF0NBOjhJ1lJ0a", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Sgy3sl0uMF0NBOjhJ1lJ0a;
        [n1.ElementAttribute(TracingId = 104931U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GwqertOIO7LL0iDBHpGXfs", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_GwqertOIO7LL0iDBHpGXfs;
        [n1.ElementAttribute(TracingId = 104939U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Jytdo1HLXg6N55DBFl6qEB", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Jytdo1HLXg6N55DBFl6qEB;
        [n1.ElementAttribute(TracingId = 104766U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "J9pNb6eGBGmNC0pE37Ufx7", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_J9pNb6eGBGmNC0pE37Ufx7;
        [n1.ElementAttribute(TracingId = 104798U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HcGw1tsZTzFPHzrnMGP0cl", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_HcGw1tsZTzFPHzrnMGP0cl;
        [n1.ElementAttribute(TracingId = 104902U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HtTMzduVFsyM2bvTdyzWMP", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_HtTMzduVFsyM2bvTdyzWMP;
        [n1.ElementAttribute(TracingId = 104906U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VhLbGCSvXa5Nt3pc4LKcPT", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VhLbGCSvXa5Nt3pc4LKcPT;
        [n1.ElementAttribute(TracingId = 104911U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FUSNjsspejYMbkWBJN5ogn", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FUSNjsspejYMbkWBJN5ogn;
        [n1.ElementAttribute(TracingId = 104922U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HYovc4SindRN3P4XkHAPJx", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HYovc4SindRN3P4XkHAPJx;
        [n1.ElementAttribute(TracingId = 104815U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UczaGvV2R0nNFVMlGFUSXy", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UczaGvV2R0nNFVMlGFUSXy;
        [n1.ElementAttribute(TracingId = 104790U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "OmeiCJMSnM3NzFwKrY3TO4", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_OmeiCJMSnM3NzFwKrY3TO4;
        [n1.ElementAttribute(TracingId = 104783U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "L6rH0FSkE3JQHP8rP34W3r", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_L6rH0FSkE3JQHP8rP34W3r;
        [n1.ElementAttribute(TracingId = 104893U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Fa4XlYweaZBO6Z0fg0wVpE", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Fa4XlYweaZBO6Z0fg0wVpE;
        [n1.ElementAttribute(TracingId = 104869U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "LMooO2MTmHPNtjh00admE2", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LMooO2MTmHPNtjh00admE2;
        [n1.ElementAttribute(TracingId = 104865U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KhuI1dYqRyeNyKnGKVo88D", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_KhuI1dYqRyeNyKnGKVo88D;
        [n1.ElementAttribute(TracingId = 104885U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HwRNPxgZpeHNyVBa7gvwSl", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HwRNPxgZpeHNyVBa7gvwSl;
        [n1.ElementAttribute(TracingId = 104889U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "C3RBvFIzZqpPfmgVaq2VYL", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_C3RBvFIzZqpPfmgVaq2VYL;
        static PointEditorControls_K88djuDkMfIOXDig3JmLMD()
        {
        }

        public PointEditorControls_K88djuDkMfIOXDig3JmLMD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditorControls_K88djuDkMfIOXDig3JmLMD(PointEditorControls_K88djuDkMfIOXDig3JmLMD other): base(other)
        {
            this.PointEditorControlsData = other.PointEditorControlsData;
            this.__slot_Tf6h2HvioG3LgmmnXerxVV = other.__slot_Tf6h2HvioG3LgmmnXerxVV;
            this.__p_FbTAmyZwxh4PDi4947HJjt = other.__p_FbTAmyZwxh4PDi4947HJjt;
            this.__p_MYT7NBe6ZA5M8FhitG7s3f = other.__p_MYT7NBe6ZA5M8FhitG7s3f;
            this.__p_AIYzm8BEKn6Pihwhc0NmQY = other.__p_AIYzm8BEKn6Pihwhc0NmQY;
            this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a = other.__p_Sgy3sl0uMF0NBOjhJ1lJ0a;
            this.__p_GwqertOIO7LL0iDBHpGXfs = other.__p_GwqertOIO7LL0iDBHpGXfs;
            this.__p_Jytdo1HLXg6N55DBFl6qEB = other.__p_Jytdo1HLXg6N55DBFl6qEB;
            this.__p_J9pNb6eGBGmNC0pE37Ufx7 = other.__p_J9pNb6eGBGmNC0pE37Ufx7;
            this.__p_HcGw1tsZTzFPHzrnMGP0cl = other.__p_HcGw1tsZTzFPHzrnMGP0cl;
            this.__p_HtTMzduVFsyM2bvTdyzWMP = other.__p_HtTMzduVFsyM2bvTdyzWMP;
            this.__p_VhLbGCSvXa5Nt3pc4LKcPT = other.__p_VhLbGCSvXa5Nt3pc4LKcPT;
            this.__p_FUSNjsspejYMbkWBJN5ogn = other.__p_FUSNjsspejYMbkWBJN5ogn;
            this.__p_HYovc4SindRN3P4XkHAPJx = other.__p_HYovc4SindRN3P4XkHAPJx;
            this.__p_UczaGvV2R0nNFVMlGFUSXy = other.__p_UczaGvV2R0nNFVMlGFUSXy;
            this.__p_OmeiCJMSnM3NzFwKrY3TO4 = other.__p_OmeiCJMSnM3NzFwKrY3TO4;
            this.__p_L6rH0FSkE3JQHP8rP34W3r = other.__p_L6rH0FSkE3JQHP8rP34W3r;
            this.__p_Fa4XlYweaZBO6Z0fg0wVpE = other.__p_Fa4XlYweaZBO6Z0fg0wVpE;
            this.__p_LMooO2MTmHPNtjh00admE2 = other.__p_LMooO2MTmHPNtjh00admE2;
            this.__p_KhuI1dYqRyeNyKnGKVo88D = other.__p_KhuI1dYqRyeNyKnGKVo88D;
            this.__p_HwRNPxgZpeHNyVBa7gvwSl = other.__p_HwRNPxgZpeHNyVBa7gvwSl;
            this.__p_C3RBvFIzZqpPfmgVaq2VYL = other.__p_C3RBvFIzZqpPfmgVaq2VYL;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "PointEditorControlsData", in PointEditorControlsData), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Tf6h2HvioG3LgmmnXerxVV", in __slot_Tf6h2HvioG3LgmmnXerxVV), n1.CompilationHelper.GetValueOrExisting(values, "__p_FbTAmyZwxh4PDi4947HJjt", in __p_FbTAmyZwxh4PDi4947HJjt), n1.CompilationHelper.GetValueOrExisting(values, "__p_MYT7NBe6ZA5M8FhitG7s3f", in __p_MYT7NBe6ZA5M8FhitG7s3f), n1.CompilationHelper.GetValueOrExisting(values, "__p_AIYzm8BEKn6Pihwhc0NmQY", in __p_AIYzm8BEKn6Pihwhc0NmQY), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sgy3sl0uMF0NBOjhJ1lJ0a", in __p_Sgy3sl0uMF0NBOjhJ1lJ0a), n1.CompilationHelper.GetValueOrExisting(values, "__p_GwqertOIO7LL0iDBHpGXfs", in __p_GwqertOIO7LL0iDBHpGXfs), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jytdo1HLXg6N55DBFl6qEB", in __p_Jytdo1HLXg6N55DBFl6qEB), n1.CompilationHelper.GetValueOrExisting(values, "__p_J9pNb6eGBGmNC0pE37Ufx7", in __p_J9pNb6eGBGmNC0pE37Ufx7), n1.CompilationHelper.GetValueOrExisting(values, "__p_HcGw1tsZTzFPHzrnMGP0cl", in __p_HcGw1tsZTzFPHzrnMGP0cl), n1.CompilationHelper.GetValueOrExisting(values, "__p_HtTMzduVFsyM2bvTdyzWMP", in __p_HtTMzduVFsyM2bvTdyzWMP), n1.CompilationHelper.GetValueOrExisting(values, "__p_VhLbGCSvXa5Nt3pc4LKcPT", in __p_VhLbGCSvXa5Nt3pc4LKcPT), n1.CompilationHelper.GetValueOrExisting(values, "__p_FUSNjsspejYMbkWBJN5ogn", in __p_FUSNjsspejYMbkWBJN5ogn), n1.CompilationHelper.GetValueOrExisting(values, "__p_HYovc4SindRN3P4XkHAPJx", in __p_HYovc4SindRN3P4XkHAPJx), n1.CompilationHelper.GetValueOrExisting(values, "__p_UczaGvV2R0nNFVMlGFUSXy", in __p_UczaGvV2R0nNFVMlGFUSXy), n1.CompilationHelper.GetValueOrExisting(values, "__p_OmeiCJMSnM3NzFwKrY3TO4", in __p_OmeiCJMSnM3NzFwKrY3TO4), n1.CompilationHelper.GetValueOrExisting(values, "__p_L6rH0FSkE3JQHP8rP34W3r", in __p_L6rH0FSkE3JQHP8rP34W3r), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fa4XlYweaZBO6Z0fg0wVpE", in __p_Fa4XlYweaZBO6Z0fg0wVpE), n1.CompilationHelper.GetValueOrExisting(values, "__p_LMooO2MTmHPNtjh00admE2", in __p_LMooO2MTmHPNtjh00admE2), n1.CompilationHelper.GetValueOrExisting(values, "__p_KhuI1dYqRyeNyKnGKVo88D", in __p_KhuI1dYqRyeNyKnGKVo88D), n1.CompilationHelper.GetValueOrExisting(values, "__p_HwRNPxgZpeHNyVBa7gvwSl", in __p_HwRNPxgZpeHNyVBa7gvwSl), n1.CompilationHelper.GetValueOrExisting(values, "__p_C3RBvFIzZqpPfmgVaq2VYL", in __p_C3RBvFIzZqpPfmgVaq2VYL));
        }

        internal PointEditorControls_K88djuDkMfIOXDig3JmLMD __WITH__(n12.PointEditorControlsData_R PointEditorControlsData, bool __slot_Tf6h2HvioG3LgmmnXerxVV, n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_FbTAmyZwxh4PDi4947HJjt, n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 __p_MYT7NBe6ZA5M8FhitG7s3f, n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_AIYzm8BEKn6Pihwhc0NmQY, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Sgy3sl0uMF0NBOjhJ1lJ0a, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_GwqertOIO7LL0iDBHpGXfs, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Jytdo1HLXg6N55DBFl6qEB, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_J9pNb6eGBGmNC0pE37Ufx7, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_HcGw1tsZTzFPHzrnMGP0cl, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_HtTMzduVFsyM2bvTdyzWMP, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VhLbGCSvXa5Nt3pc4LKcPT, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FUSNjsspejYMbkWBJN5ogn, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HYovc4SindRN3P4XkHAPJx, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UczaGvV2R0nNFVMlGFUSXy, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_OmeiCJMSnM3NzFwKrY3TO4, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_L6rH0FSkE3JQHP8rP34W3r, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Fa4XlYweaZBO6Z0fg0wVpE, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LMooO2MTmHPNtjh00admE2, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_KhuI1dYqRyeNyKnGKVo88D, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_HwRNPxgZpeHNyVBa7gvwSl, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_C3RBvFIzZqpPfmgVaq2VYL)
        {
            n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = PointEditorControlsData != this.PointEditorControlsData || __slot_Tf6h2HvioG3LgmmnXerxVV != this.__slot_Tf6h2HvioG3LgmmnXerxVV || __p_FbTAmyZwxh4PDi4947HJjt != this.__p_FbTAmyZwxh4PDi4947HJjt || __p_MYT7NBe6ZA5M8FhitG7s3f != this.__p_MYT7NBe6ZA5M8FhitG7s3f || __p_AIYzm8BEKn6Pihwhc0NmQY != this.__p_AIYzm8BEKn6Pihwhc0NmQY || __p_Sgy3sl0uMF0NBOjhJ1lJ0a != this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a || __p_GwqertOIO7LL0iDBHpGXfs != this.__p_GwqertOIO7LL0iDBHpGXfs || __p_Jytdo1HLXg6N55DBFl6qEB != this.__p_Jytdo1HLXg6N55DBFl6qEB || __p_J9pNb6eGBGmNC0pE37Ufx7 != this.__p_J9pNb6eGBGmNC0pE37Ufx7 || __p_HcGw1tsZTzFPHzrnMGP0cl != this.__p_HcGw1tsZTzFPHzrnMGP0cl || __p_HtTMzduVFsyM2bvTdyzWMP != this.__p_HtTMzduVFsyM2bvTdyzWMP || __p_VhLbGCSvXa5Nt3pc4LKcPT != this.__p_VhLbGCSvXa5Nt3pc4LKcPT || __p_FUSNjsspejYMbkWBJN5ogn != this.__p_FUSNjsspejYMbkWBJN5ogn || __p_HYovc4SindRN3P4XkHAPJx != this.__p_HYovc4SindRN3P4XkHAPJx || __p_UczaGvV2R0nNFVMlGFUSXy != this.__p_UczaGvV2R0nNFVMlGFUSXy || __p_OmeiCJMSnM3NzFwKrY3TO4 != this.__p_OmeiCJMSnM3NzFwKrY3TO4 || __p_L6rH0FSkE3JQHP8rP34W3r != this.__p_L6rH0FSkE3JQHP8rP34W3r || __p_Fa4XlYweaZBO6Z0fg0wVpE != this.__p_Fa4XlYweaZBO6Z0fg0wVpE || __p_LMooO2MTmHPNtjh00admE2 != this.__p_LMooO2MTmHPNtjh00admE2 || __p_KhuI1dYqRyeNyKnGKVo88D != this.__p_KhuI1dYqRyeNyKnGKVo88D || __p_HwRNPxgZpeHNyVBa7gvwSl != this.__p_HwRNPxgZpeHNyVBa7gvwSl || __p_C3RBvFIzZqpPfmgVaq2VYL != this.__p_C3RBvFIzZqpPfmgVaq2VYL ? new PointEditorControls_K88djuDkMfIOXDig3JmLMD(this)
                {PointEditorControlsData = PointEditorControlsData, __slot_Tf6h2HvioG3LgmmnXerxVV = __slot_Tf6h2HvioG3LgmmnXerxVV, __p_FbTAmyZwxh4PDi4947HJjt = __p_FbTAmyZwxh4PDi4947HJjt, __p_MYT7NBe6ZA5M8FhitG7s3f = __p_MYT7NBe6ZA5M8FhitG7s3f, __p_AIYzm8BEKn6Pihwhc0NmQY = __p_AIYzm8BEKn6Pihwhc0NmQY, __p_Sgy3sl0uMF0NBOjhJ1lJ0a = __p_Sgy3sl0uMF0NBOjhJ1lJ0a, __p_GwqertOIO7LL0iDBHpGXfs = __p_GwqertOIO7LL0iDBHpGXfs, __p_Jytdo1HLXg6N55DBFl6qEB = __p_Jytdo1HLXg6N55DBFl6qEB, __p_J9pNb6eGBGmNC0pE37Ufx7 = __p_J9pNb6eGBGmNC0pE37Ufx7, __p_HcGw1tsZTzFPHzrnMGP0cl = __p_HcGw1tsZTzFPHzrnMGP0cl, __p_HtTMzduVFsyM2bvTdyzWMP = __p_HtTMzduVFsyM2bvTdyzWMP, __p_VhLbGCSvXa5Nt3pc4LKcPT = __p_VhLbGCSvXa5Nt3pc4LKcPT, __p_FUSNjsspejYMbkWBJN5ogn = __p_FUSNjsspejYMbkWBJN5ogn, __p_HYovc4SindRN3P4XkHAPJx = __p_HYovc4SindRN3P4XkHAPJx, __p_UczaGvV2R0nNFVMlGFUSXy = __p_UczaGvV2R0nNFVMlGFUSXy, __p_OmeiCJMSnM3NzFwKrY3TO4 = __p_OmeiCJMSnM3NzFwKrY3TO4, __p_L6rH0FSkE3JQHP8rP34W3r = __p_L6rH0FSkE3JQHP8rP34W3r, __p_Fa4XlYweaZBO6Z0fg0wVpE = __p_Fa4XlYweaZBO6Z0fg0wVpE, __p_LMooO2MTmHPNtjh00admE2 = __p_LMooO2MTmHPNtjh00admE2, __p_KhuI1dYqRyeNyKnGKVo88D = __p_KhuI1dYqRyeNyKnGKVo88D, __p_HwRNPxgZpeHNyVBa7gvwSl = __p_HwRNPxgZpeHNyVBa7gvwSl, __p_C3RBvFIzZqpPfmgVaq2VYL = __p_C3RBvFIzZqpPfmgVaq2VYL} : that_0;
            else
            {
                this.PointEditorControlsData = PointEditorControlsData;
                this.__slot_Tf6h2HvioG3LgmmnXerxVV = __slot_Tf6h2HvioG3LgmmnXerxVV;
                this.__p_FbTAmyZwxh4PDi4947HJjt = __p_FbTAmyZwxh4PDi4947HJjt;
                this.__p_MYT7NBe6ZA5M8FhitG7s3f = __p_MYT7NBe6ZA5M8FhitG7s3f;
                this.__p_AIYzm8BEKn6Pihwhc0NmQY = __p_AIYzm8BEKn6Pihwhc0NmQY;
                this.__p_Sgy3sl0uMF0NBOjhJ1lJ0a = __p_Sgy3sl0uMF0NBOjhJ1lJ0a;
                this.__p_GwqertOIO7LL0iDBHpGXfs = __p_GwqertOIO7LL0iDBHpGXfs;
                this.__p_Jytdo1HLXg6N55DBFl6qEB = __p_Jytdo1HLXg6N55DBFl6qEB;
                this.__p_J9pNb6eGBGmNC0pE37Ufx7 = __p_J9pNb6eGBGmNC0pE37Ufx7;
                this.__p_HcGw1tsZTzFPHzrnMGP0cl = __p_HcGw1tsZTzFPHzrnMGP0cl;
                this.__p_HtTMzduVFsyM2bvTdyzWMP = __p_HtTMzduVFsyM2bvTdyzWMP;
                this.__p_VhLbGCSvXa5Nt3pc4LKcPT = __p_VhLbGCSvXa5Nt3pc4LKcPT;
                this.__p_FUSNjsspejYMbkWBJN5ogn = __p_FUSNjsspejYMbkWBJN5ogn;
                this.__p_HYovc4SindRN3P4XkHAPJx = __p_HYovc4SindRN3P4XkHAPJx;
                this.__p_UczaGvV2R0nNFVMlGFUSXy = __p_UczaGvV2R0nNFVMlGFUSXy;
                this.__p_OmeiCJMSnM3NzFwKrY3TO4 = __p_OmeiCJMSnM3NzFwKrY3TO4;
                this.__p_L6rH0FSkE3JQHP8rP34W3r = __p_L6rH0FSkE3JQHP8rP34W3r;
                this.__p_Fa4XlYweaZBO6Z0fg0wVpE = __p_Fa4XlYweaZBO6Z0fg0wVpE;
                this.__p_LMooO2MTmHPNtjh00admE2 = __p_LMooO2MTmHPNtjh00admE2;
                this.__p_KhuI1dYqRyeNyKnGKVo88D = __p_KhuI1dYqRyeNyKnGKVo88D;
                this.__p_HwRNPxgZpeHNyVBa7gvwSl = __p_HwRNPxgZpeHNyVBa7gvwSl;
                this.__p_C3RBvFIzZqpPfmgVaq2VYL = __p_C3RBvFIzZqpPfmgVaq2VYL;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 105010U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PjwVSmIMzyGM5MzvE89PG7", Name = "SelectionRect_PjwVSmIMzyGM5MzvE89PG7")]
    [n2.SerializableAttribute]
    public class SelectionRect_PjwVSmIMzyGM5MzvE89PG7 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 Create(n1.NodeContext Node_Context)
        {
            var instance = new SelectionRect_PjwVSmIMzyGM5MzvE89PG7(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 CreateDefault()
        {
            var instance = new SelectionRect_PjwVSmIMzyGM5MzvE89PG7(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 Update(n5.Vector2 Position_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Select_In, out n5.RectangleF Selection_Out)
        {
            float __pad_TvbMCgvVNaBPHMDbjAbNcC_0 = __slot_TvbMCgvVNaBPHMDbjAbNcC;
            var Output_3 = this.__p_ALNK3DAI9l5PkTyyR9Onpz.Update(Value_In: Select_In, Up_Edge_Out: out bool Up_Edge_1, Down_Edge_Out: out bool Down_Edge_2);
            bool SetValue_4 = true;
            var Output_5 = this.__p_CtTjtf6PdHdMxjcnW6eDA1;
            if (SetValue_4)
            {
                Output_5 = this.__p_CtTjtf6PdHdMxjcnW6eDA1.SetValue(Value_In: Position_In, Sample_In: Up_Edge_1);
            }

            var Output_7 = Output_5.GetValue(Value_Out: out n5.Vector2 Value_6);
            bool SetValue_8 = true;
            var Output_9 = this.__p_Irbt1acdEUNMCBSpmSAuhM;
            if (SetValue_8)
            {
                Output_9 = this.__p_Irbt1acdEUNMCBSpmSAuhM.SetValue(Value_In: Position_In, Sample_In: Select_In);
            }

            var Output_11 = Output_9.GetValue(Value_Out: out n5.Vector2 Value_10);
            bool Apply_12 = true;
            var Output_13 = Value_10;
            if (Apply_12)
            {
                var Output_14 = n20.Vector2Nodes.Lerp(input: ref Value_10, input2: ref Value_6, scalar: __pad_TvbMCgvVNaBPHMDbjAbNcC_0);
                Output_13 = Output_14;
            }

            bool Apply_15 = true;
            var Output_16 = Value_10;
            if (Apply_15)
            {
                n5.Vector2.Subtract(left: ref Value_10, right: ref Value_6, result: out n5.Vector2 Output_17);
                Output_16 = Output_17;
            }

            n20.Vector2Nodes.Vector(input: ref Output_16, x: out float X_18, y: out float Y_19);
            bool Apply_20 = true;
            var Output_21 = X_18;
            if (Apply_20)
            {
                n40._Operations_.Abs<float, n39.__AdaptiveImplementations__PSPaLWEsDmnP5LJnFN7pkq>(Input_In: X_18, Output_Out: out Output_21);
            }

            bool Apply_22 = true;
            var Output_23 = Y_19;
            if (Apply_22)
            {
                n40._Operations_.Abs<float, n39.__AdaptiveImplementations__PSPaLWEsDmnP5LJnFN7pkq>(Input_In: Y_19, Output_Out: out Output_23);
            }

            var Output_24 = new n5.Vector2(x: Output_21, y: Output_23);
            var Result_25 = n20.RectangleNodes.FromCenterSize(center: ref Output_13, size: ref Output_24);
            Selection_Out = Result_25;
            n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = Output_3 != this.__p_ALNK3DAI9l5PkTyyR9Onpz || Output_7 != this.__p_CtTjtf6PdHdMxjcnW6eDA1 || Output_11 != this.__p_Irbt1acdEUNMCBSpmSAuhM ? new SelectionRect_PjwVSmIMzyGM5MzvE89PG7(this)
                {__p_ALNK3DAI9l5PkTyyR9Onpz = Output_3, __p_CtTjtf6PdHdMxjcnW6eDA1 = Output_7, __p_Irbt1acdEUNMCBSpmSAuhM = Output_11} : that_26;
            else
            {
                this.__p_ALNK3DAI9l5PkTyyR9Onpz = Output_3;
                this.__p_CtTjtf6PdHdMxjcnW6eDA1 = Output_7;
                this.__p_Irbt1acdEUNMCBSpmSAuhM = Output_11;
            }

            return that_26;
        }

        public n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "CtTjtf6PdHdMxjcnW6eDA1", 105051U);
            n5.Vector2 Initial_Value_1 = n29._Operations_.CreateDefault();
            var Output_2 = n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2>.Create(Node_Context: Node_Context_0, Initial_Value_In: Initial_Value_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "ALNK3DAI9l5PkTyyR9Onpz", 105056U);
            var Output_4 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Irbt1acdEUNMCBSpmSAuhM", 105060U);
            n5.Vector2 Initial_Value_6 = n29._Operations_.CreateDefault();
            var Output_7 = n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2>.Create(Node_Context: Node_Context_5, Initial_Value_In: Initial_Value_6);
            n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 that_8 = this;
            this.__p_CtTjtf6PdHdMxjcnW6eDA1 = Output_2;
            this.__p_ALNK3DAI9l5PkTyyR9Onpz = Output_4;
            this.__p_Irbt1acdEUNMCBSpmSAuhM = Output_7;
            return that_8;
        }

        public n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 __CreateDefault__()
        {
            n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 that_0 = this;
            this.__p_ALNK3DAI9l5PkTyyR9Onpz = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_CtTjtf6PdHdMxjcnW6eDA1 = n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2>.CreateDefault();
            this.__p_Irbt1acdEUNMCBSpmSAuhM = n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ALNK3DAI9l5PkTyyR9Onpz);
            n1.CompilationHelper.SafeDispose(this.__p_CtTjtf6PdHdMxjcnW6eDA1);
            n1.CompilationHelper.SafeDispose(this.__p_Irbt1acdEUNMCBSpmSAuhM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105026U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TvbMCgvVNaBPHMDbjAbNcC", Name = "__slot_TvbMCgvVNaBPHMDbjAbNcC")]
        public static float __slot_TvbMCgvVNaBPHMDbjAbNcC = 0.499999821F;
        [n1.ElementAttribute(TracingId = 105056U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ALNK3DAI9l5PkTyyR9Onpz", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_ALNK3DAI9l5PkTyyR9Onpz;
        [n1.ElementAttribute(TracingId = 105051U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "CtTjtf6PdHdMxjcnW6eDA1", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2> __p_CtTjtf6PdHdMxjcnW6eDA1;
        [n1.ElementAttribute(TracingId = 105060U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Irbt1acdEUNMCBSpmSAuhM", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2> __p_Irbt1acdEUNMCBSpmSAuhM;
        static SelectionRect_PjwVSmIMzyGM5MzvE89PG7()
        {
        }

        public SelectionRect_PjwVSmIMzyGM5MzvE89PG7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectionRect_PjwVSmIMzyGM5MzvE89PG7(SelectionRect_PjwVSmIMzyGM5MzvE89PG7 other): base(other)
        {
            this.__p_ALNK3DAI9l5PkTyyR9Onpz = other.__p_ALNK3DAI9l5PkTyyR9Onpz;
            this.__p_CtTjtf6PdHdMxjcnW6eDA1 = other.__p_CtTjtf6PdHdMxjcnW6eDA1;
            this.__p_Irbt1acdEUNMCBSpmSAuhM = other.__p_Irbt1acdEUNMCBSpmSAuhM;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ALNK3DAI9l5PkTyyR9Onpz", in __p_ALNK3DAI9l5PkTyyR9Onpz), n1.CompilationHelper.GetValueOrExisting(values, "__p_CtTjtf6PdHdMxjcnW6eDA1", in __p_CtTjtf6PdHdMxjcnW6eDA1), n1.CompilationHelper.GetValueOrExisting(values, "__p_Irbt1acdEUNMCBSpmSAuhM", in __p_Irbt1acdEUNMCBSpmSAuhM));
        }

        internal SelectionRect_PjwVSmIMzyGM5MzvE89PG7 __WITH__(n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_ALNK3DAI9l5PkTyyR9Onpz, n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2> __p_CtTjtf6PdHdMxjcnW6eDA1, n38.SPH_RESwCzqU3iTMc4Ig82Av03<n5.Vector2> __p_Irbt1acdEUNMCBSpmSAuhM)
        {
            n3.SelectionRect_PjwVSmIMzyGM5MzvE89PG7 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ALNK3DAI9l5PkTyyR9Onpz != this.__p_ALNK3DAI9l5PkTyyR9Onpz || __p_CtTjtf6PdHdMxjcnW6eDA1 != this.__p_CtTjtf6PdHdMxjcnW6eDA1 || __p_Irbt1acdEUNMCBSpmSAuhM != this.__p_Irbt1acdEUNMCBSpmSAuhM ? new SelectionRect_PjwVSmIMzyGM5MzvE89PG7(this)
                {__p_ALNK3DAI9l5PkTyyR9Onpz = __p_ALNK3DAI9l5PkTyyR9Onpz, __p_CtTjtf6PdHdMxjcnW6eDA1 = __p_CtTjtf6PdHdMxjcnW6eDA1, __p_Irbt1acdEUNMCBSpmSAuhM = __p_Irbt1acdEUNMCBSpmSAuhM} : that_0;
            else
            {
                this.__p_ALNK3DAI9l5PkTyyR9Onpz = __p_ALNK3DAI9l5PkTyyR9Onpz;
                this.__p_CtTjtf6PdHdMxjcnW6eDA1 = __p_CtTjtf6PdHdMxjcnW6eDA1;
                this.__p_Irbt1acdEUNMCBSpmSAuhM = __p_Irbt1acdEUNMCBSpmSAuhM;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 105091U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RiqDyTf90wsLg4kSBfT9Tr", Name = "GizmoControls_RiqDyTf90wsLg4kSBfT9Tr")]
    [n2.SerializableAttribute]
    public class GizmoControls_RiqDyTf90wsLg4kSBfT9Tr : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr Create(n1.NodeContext Node_Context)
        {
            var instance = new GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr CreateDefault()
        {
            var instance = new GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr Update(n35.IMouse Mouse_In, n35.IKeyboard Keyboard_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> Gizmo_Controls_Out)
        {
            n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> __auto_0 = this.Controls;
            string __pad_Temlu0XcByWLBbdK28YCOe_1 = __slot_Temlu0XcByWLBbdK28YCOe;
            string __pad_AWuKDIQVhPPMDnDiheFwa1_2 = __slot_AWuKDIQVhPPMDnDiheFwa1;
            string __pad_KgAJaEHUbvwMstfrnuUdzd_3 = __slot_KgAJaEHUbvwMstfrnuUdzd;
            string __pad_NKWuLOnXURjOJlelfH0uAV_4 = __slot_NKWuLOnXURjOJlelfH0uAV;
            string __pad_UCku1KLhtDqMcDA4O8wmDu_5 = __slot_UCku1KLhtDqMcDA4O8wmDu;
            string __pad_RblKkl92v54NeLsTwaVvH1_6 = __slot_RblKkl92v54NeLsTwaVvH1;
            string __pad_EfFWgravadNLVWgA5zbgM1_7 = __slot_EfFWgravadNLVWgA5zbgM1;
            float __pad_MM7qbxjLvQ0MQw8kt4Hbmg_8 = __slot_MM7qbxjLvQ0MQw8kt4Hbmg;
            string __pad_AJ9aNn76m7sOtPvyehvN2B_9 = __slot_AJ9aNn76m7sOtPvyehvN2B;
            string __pad_Iw8jXv2wJUHOZLqKTQyO1Y_10 = __slot_Iw8jXv2wJUHOZLqKTQyO1Y;
            var Output_21 = this.__p_SNiEWhfHcDCNezyppxcF6f.Update(Mouse_Device_In: Mouse_In, Position_In_World_Out: out n5.Vector2 Position_In_World_11, Position_In_Projection_Out: out n5.Vector2 Position_In_Projection_12, Position_Out: out n5.Vector2 Position_13, Left_Pressed_Out: out bool Left_Pressed_14, Middle_Pressed_Out: out bool Middle_Pressed_15, Right_Pressed_Out: out bool Right_Pressed_16, Normalized_Position_Out: out n5.Vector2 Normalized_Position_17, WheelDelta_Out: out int WheelDelta_18, Client_Area_Out: out n5.Vector2 Client_Area_19, Sender_Out: out n2.Object Sender_20);
            var Output_23 = this.__p_VOOpodqTzCULwlmcnFAaVH.Update(Keyboard_Device_In: Keyboard_In, Pressed_Keys_Out: out n34.ImmutableHashSet<n33.Keys> Pressed_Keys_22);
            var Output_25 = this.__p_FrYpY8swhSoMAgmCviGeUX.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_Temlu0XcByWLBbdK28YCOe_1, Is_Down_Out: out bool Is_Down_24);
            var Output_28 = this.__p_Cg8w2J7xvAAL68vV4JciKG.Update(Value_In: Is_Down_24, Up_Edge_Out: out bool Up_Edge_26, Down_Edge_Out: out bool Down_Edge_27);
            float Input_29 = n2.Convert.ToSingle(Up_Edge_26);
            var Output_30 = Input_29 * __pad_MM7qbxjLvQ0MQw8kt4Hbmg_8;
            var Output_32 = this.__p_AI7eCsxOWFcMIc32LmUerj.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_UCku1KLhtDqMcDA4O8wmDu_5, Is_Down_Out: out bool Is_Down_31);
            var Output_35 = this.__p_FVhgcstQTRMLtc58tnKLIm.Update(Value_In: Is_Down_31, Up_Edge_Out: out bool Up_Edge_33, Down_Edge_Out: out bool Down_Edge_34);
            float Input_2_36 = n2.Convert.ToSingle(Up_Edge_33);
            var Output_37 = Output_30 + Input_2_36;
            var Output_39 = this.__p_RbXt39njzzrL33naQUfyHV.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_EfFWgravadNLVWgA5zbgM1_7, Is_Down_Out: out bool Is_Down_38);
            var Output_42 = this.__p_QCyAsag8bMTMNYL8T3GevE.Update(Value_In: Is_Down_38, Up_Edge_Out: out bool Up_Edge_40, Down_Edge_Out: out bool Down_Edge_41);
            float Input_43 = n2.Convert.ToSingle(Up_Edge_40);
            var Output_44 = Input_43 * __pad_MM7qbxjLvQ0MQw8kt4Hbmg_8;
            var Output_46 = this.__p_ACYNr64nm7WM2wdipeXWra.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_RblKkl92v54NeLsTwaVvH1_6, Is_Down_Out: out bool Is_Down_45);
            var Output_49 = this.__p_At4S9Ol11qYLDkwMwaUYgE.Update(Value_In: Is_Down_45, Up_Edge_Out: out bool Up_Edge_47, Down_Edge_Out: out bool Down_Edge_48);
            float Input_2_50 = n2.Convert.ToSingle(Up_Edge_47);
            var Output_51 = Output_44 + Input_2_50;
            var Output_53 = this.__p_OT9YJei7FzZO4iYhQxDrqh.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_Iw8jXv2wJUHOZLqKTQyO1Y_10, Is_Down_Out: out bool Is_Down_52);
            var Output_56 = this.__p_DoYgamewBVTLVGk84wZpSg.Update(Value_In: Is_Down_52, Up_Edge_Out: out bool Up_Edge_54, Down_Edge_Out: out bool Down_Edge_55);
            float Input_57 = n2.Convert.ToSingle(Up_Edge_54);
            var Output_58 = Input_57 * __pad_MM7qbxjLvQ0MQw8kt4Hbmg_8;
            var Output_60 = this.__p_VeKxscHx8vSQGW61kQmYWg.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_AJ9aNn76m7sOtPvyehvN2B_9, Is_Down_Out: out bool Is_Down_59);
            var Output_63 = this.__p_Q0s4gI9uNPLLVZvZcee5kY.Update(Value_In: Is_Down_59, Up_Edge_Out: out bool Up_Edge_61, Down_Edge_Out: out bool Down_Edge_62);
            float Input_2_64 = n2.Convert.ToSingle(Up_Edge_61);
            var Output_65 = Output_58 + Input_2_64;
            var Output_66 = new n5.Vector3(x: Output_37, y: Output_51, z: Output_65);
            var Output_68 = this.__p_DsNLtewtvgvMpXgXcjs1ul.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_AWuKDIQVhPPMDnDiheFwa1_2, Is_Down_Out: out bool Is_Down_67);
            var Output_70 = this.__p_LE5ipy9CiUoMPyjk0ppkNX.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_NKWuLOnXURjOJlelfH0uAV_4, Is_Down_Out: out bool Is_Down_69);
            var Output_73 = this.__p_Am9kxrIHbCzP5542lQ5Eej.Update(Value_In: Is_Down_69, Up_Edge_Out: out bool Up_Edge_71, Down_Edge_Out: out bool Down_Edge_72);
            var Output_75 = this.__p_JjM9YdpFWwIORU8w9LtRHD.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_KgAJaEHUbvwMstfrnuUdzd_3, Is_Down_Out: out bool Is_Down_74);
            var Output_76 = Is_Down_67 && Is_Down_74;
            var Output_77 = !Is_Down_67;
            var Output_78 = Output_77 && Is_Down_74;
            var Output_79 = Up_Edge_26 || Up_Edge_33;
            var Output_80 = Output_79 || Up_Edge_47;
            var Output_81 = Output_80 || Up_Edge_40;
            var Output_82 = Output_81 || Up_Edge_61;
            var Output_83 = Output_82 || Up_Edge_54;
            var Output_84 = __auto_0;
            if (Enable_In)
            {
                Output_84 = __auto_0.Join(Mouse_Position_In: Position_In_World_11, Nudge_Offset_In: Output_66, Left_Button_Pressed_In: Left_Pressed_14, Uniform_Scaling_In: Is_Down_67, Mode_Selection_Pressed_In: Up_Edge_71, Small_Rotation_Step_In: Is_Down_67, Smaller_Rotation_Step_In: Output_76, Big_Rotation_Step_In: Output_78, Nudge_In: Output_83);
            }

            n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> __auto_85 = Output_84;
            Gizmo_Controls_Out = Output_84;
            n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr that_86 = this;
            if (this.__GetContext__().IsImmutable)
                that_86 = Output_21 != this.__p_SNiEWhfHcDCNezyppxcF6f || Output_23 != this.__p_VOOpodqTzCULwlmcnFAaVH || Output_25 != this.__p_FrYpY8swhSoMAgmCviGeUX || Output_28 != this.__p_Cg8w2J7xvAAL68vV4JciKG || Output_32 != this.__p_AI7eCsxOWFcMIc32LmUerj || Output_35 != this.__p_FVhgcstQTRMLtc58tnKLIm || Output_39 != this.__p_RbXt39njzzrL33naQUfyHV || Output_42 != this.__p_QCyAsag8bMTMNYL8T3GevE || Output_46 != this.__p_ACYNr64nm7WM2wdipeXWra || Output_49 != this.__p_At4S9Ol11qYLDkwMwaUYgE || Output_53 != this.__p_OT9YJei7FzZO4iYhQxDrqh || Output_56 != this.__p_DoYgamewBVTLVGk84wZpSg || Output_60 != this.__p_VeKxscHx8vSQGW61kQmYWg || Output_63 != this.__p_Q0s4gI9uNPLLVZvZcee5kY || Output_68 != this.__p_DsNLtewtvgvMpXgXcjs1ul || Output_70 != this.__p_LE5ipy9CiUoMPyjk0ppkNX || Output_73 != this.__p_Am9kxrIHbCzP5542lQ5Eej || Output_75 != this.__p_JjM9YdpFWwIORU8w9LtRHD || Output_84 != this.Controls ? new GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(this)
                {__p_SNiEWhfHcDCNezyppxcF6f = Output_21, __p_VOOpodqTzCULwlmcnFAaVH = Output_23, __p_FrYpY8swhSoMAgmCviGeUX = Output_25, __p_Cg8w2J7xvAAL68vV4JciKG = Output_28, __p_AI7eCsxOWFcMIc32LmUerj = Output_32, __p_FVhgcstQTRMLtc58tnKLIm = Output_35, __p_RbXt39njzzrL33naQUfyHV = Output_39, __p_QCyAsag8bMTMNYL8T3GevE = Output_42, __p_ACYNr64nm7WM2wdipeXWra = Output_46, __p_At4S9Ol11qYLDkwMwaUYgE = Output_49, __p_OT9YJei7FzZO4iYhQxDrqh = Output_53, __p_DoYgamewBVTLVGk84wZpSg = Output_56, __p_VeKxscHx8vSQGW61kQmYWg = Output_60, __p_Q0s4gI9uNPLLVZvZcee5kY = Output_63, __p_DsNLtewtvgvMpXgXcjs1ul = Output_68, __p_LE5ipy9CiUoMPyjk0ppkNX = Output_70, __p_Am9kxrIHbCzP5542lQ5Eej = Output_73, __p_JjM9YdpFWwIORU8w9LtRHD = Output_75, Controls = Output_84} : that_86;
            else
            {
                this.__p_SNiEWhfHcDCNezyppxcF6f = Output_21;
                this.__p_VOOpodqTzCULwlmcnFAaVH = Output_23;
                this.__p_FrYpY8swhSoMAgmCviGeUX = Output_25;
                this.__p_Cg8w2J7xvAAL68vV4JciKG = Output_28;
                this.__p_AI7eCsxOWFcMIc32LmUerj = Output_32;
                this.__p_FVhgcstQTRMLtc58tnKLIm = Output_35;
                this.__p_RbXt39njzzrL33naQUfyHV = Output_39;
                this.__p_QCyAsag8bMTMNYL8T3GevE = Output_42;
                this.__p_ACYNr64nm7WM2wdipeXWra = Output_46;
                this.__p_At4S9Ol11qYLDkwMwaUYgE = Output_49;
                this.__p_OT9YJei7FzZO4iYhQxDrqh = Output_53;
                this.__p_DoYgamewBVTLVGk84wZpSg = Output_56;
                this.__p_VeKxscHx8vSQGW61kQmYWg = Output_60;
                this.__p_Q0s4gI9uNPLLVZvZcee5kY = Output_63;
                this.__p_DsNLtewtvgvMpXgXcjs1ul = Output_68;
                this.__p_LE5ipy9CiUoMPyjk0ppkNX = Output_70;
                this.__p_Am9kxrIHbCzP5542lQ5Eej = Output_73;
                this.__p_JjM9YdpFWwIORU8w9LtRHD = Output_75;
                this.Controls = Output_84;
            }

            return that_86;
        }

        public n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "DsNLtewtvgvMpXgXcjs1ul", 105095U);
            var Output_1 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "LE5ipy9CiUoMPyjk0ppkNX", 105100U);
            var Output_3 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "SNiEWhfHcDCNezyppxcF6f", 105106U);
            var Output_5 = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "VOOpodqTzCULwlmcnFAaVH", 105132U);
            var Output_7 = n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Am9kxrIHbCzP5542lQ5Eej", 105135U);
            var Output_9 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "FrYpY8swhSoMAgmCviGeUX", 105147U);
            var Output_11 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "AI7eCsxOWFcMIc32LmUerj", 105151U);
            var Output_13 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "ACYNr64nm7WM2wdipeXWra", 105155U);
            var Output_15 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "RbXt39njzzrL33naQUfyHV", 105159U);
            var Output_17 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Cg8w2J7xvAAL68vV4JciKG", 105184U);
            var Output_19 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "FVhgcstQTRMLtc58tnKLIm", 105188U);
            var Output_21 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "At4S9Ol11qYLDkwMwaUYgE", 105192U);
            var Output_23 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "QCyAsag8bMTMNYL8T3GevE", 105196U);
            var Output_25 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "VeKxscHx8vSQGW61kQmYWg", 105210U);
            var Output_27 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "OT9YJei7FzZO4iYhQxDrqh", 105214U);
            var Output_29 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Q0s4gI9uNPLLVZvZcee5kY", 105226U);
            var Output_31 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "DoYgamewBVTLVGk84wZpSg", 105230U);
            var Output_33 = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_32);
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "JjM9YdpFWwIORU8w9LtRHD", 105234U);
            var Output_35 = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_34);
            n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr that_36 = this;
            this.Controls = n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool>.CreateDefault<n39.__AdaptiveImplementations__PSPaLWEsDmnP5LJnFN7pkq>();
            this.__p_DsNLtewtvgvMpXgXcjs1ul = Output_1;
            this.__p_LE5ipy9CiUoMPyjk0ppkNX = Output_3;
            this.__p_SNiEWhfHcDCNezyppxcF6f = Output_5;
            this.__p_VOOpodqTzCULwlmcnFAaVH = Output_7;
            this.__p_Am9kxrIHbCzP5542lQ5Eej = Output_9;
            this.__p_FrYpY8swhSoMAgmCviGeUX = Output_11;
            this.__p_AI7eCsxOWFcMIc32LmUerj = Output_13;
            this.__p_ACYNr64nm7WM2wdipeXWra = Output_15;
            this.__p_RbXt39njzzrL33naQUfyHV = Output_17;
            this.__p_Cg8w2J7xvAAL68vV4JciKG = Output_19;
            this.__p_FVhgcstQTRMLtc58tnKLIm = Output_21;
            this.__p_At4S9Ol11qYLDkwMwaUYgE = Output_23;
            this.__p_QCyAsag8bMTMNYL8T3GevE = Output_25;
            this.__p_VeKxscHx8vSQGW61kQmYWg = Output_27;
            this.__p_OT9YJei7FzZO4iYhQxDrqh = Output_29;
            this.__p_Q0s4gI9uNPLLVZvZcee5kY = Output_31;
            this.__p_DoYgamewBVTLVGk84wZpSg = Output_33;
            this.__p_JjM9YdpFWwIORU8w9LtRHD = Output_35;
            return that_36;
        }

        public n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr __CreateDefault__()
        {
            n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr that_0 = this;
            this.Controls = n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool>.CreateDefault<n39.__AdaptiveImplementations__PSPaLWEsDmnP5LJnFN7pkq>();
            this.__p_SNiEWhfHcDCNezyppxcF6f = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_VOOpodqTzCULwlmcnFAaVH = n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_FrYpY8swhSoMAgmCviGeUX = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Cg8w2J7xvAAL68vV4JciKG = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_AI7eCsxOWFcMIc32LmUerj = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_FVhgcstQTRMLtc58tnKLIm = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_RbXt39njzzrL33naQUfyHV = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_QCyAsag8bMTMNYL8T3GevE = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_ACYNr64nm7WM2wdipeXWra = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_At4S9Ol11qYLDkwMwaUYgE = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_OT9YJei7FzZO4iYhQxDrqh = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_DoYgamewBVTLVGk84wZpSg = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_VeKxscHx8vSQGW61kQmYWg = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Q0s4gI9uNPLLVZvZcee5kY = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_DsNLtewtvgvMpXgXcjs1ul = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LE5ipy9CiUoMPyjk0ppkNX = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Am9kxrIHbCzP5542lQ5Eej = n38.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_JjM9YdpFWwIORU8w9LtRHD = n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SNiEWhfHcDCNezyppxcF6f);
            n1.CompilationHelper.SafeDispose(this.__p_VOOpodqTzCULwlmcnFAaVH);
            n1.CompilationHelper.SafeDispose(this.__p_FrYpY8swhSoMAgmCviGeUX);
            n1.CompilationHelper.SafeDispose(this.__p_Cg8w2J7xvAAL68vV4JciKG);
            n1.CompilationHelper.SafeDispose(this.__p_AI7eCsxOWFcMIc32LmUerj);
            n1.CompilationHelper.SafeDispose(this.__p_FVhgcstQTRMLtc58tnKLIm);
            n1.CompilationHelper.SafeDispose(this.__p_RbXt39njzzrL33naQUfyHV);
            n1.CompilationHelper.SafeDispose(this.__p_QCyAsag8bMTMNYL8T3GevE);
            n1.CompilationHelper.SafeDispose(this.__p_ACYNr64nm7WM2wdipeXWra);
            n1.CompilationHelper.SafeDispose(this.__p_At4S9Ol11qYLDkwMwaUYgE);
            n1.CompilationHelper.SafeDispose(this.__p_OT9YJei7FzZO4iYhQxDrqh);
            n1.CompilationHelper.SafeDispose(this.__p_DoYgamewBVTLVGk84wZpSg);
            n1.CompilationHelper.SafeDispose(this.__p_VeKxscHx8vSQGW61kQmYWg);
            n1.CompilationHelper.SafeDispose(this.__p_Q0s4gI9uNPLLVZvZcee5kY);
            n1.CompilationHelper.SafeDispose(this.__p_DsNLtewtvgvMpXgXcjs1ul);
            n1.CompilationHelper.SafeDispose(this.__p_LE5ipy9CiUoMPyjk0ppkNX);
            n1.CompilationHelper.SafeDispose(this.__p_Am9kxrIHbCzP5542lQ5Eej);
            n1.CompilationHelper.SafeDispose(this.__p_JjM9YdpFWwIORU8w9LtRHD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105099U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AWuKDIQVhPPMDnDiheFwa1", Name = "__slot_AWuKDIQVhPPMDnDiheFwa1")]
        public static string __slot_AWuKDIQVhPPMDnDiheFwa1 = "ShiftKey";
        [n1.ElementAttribute(TracingId = 105104U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NKWuLOnXURjOJlelfH0uAV", Name = "__slot_NKWuLOnXURjOJlelfH0uAV")]
        public static string __slot_NKWuLOnXURjOJlelfH0uAV = "G";
        [n1.ElementAttribute(TracingId = 105142U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Temlu0XcByWLBbdK28YCOe", Name = "__slot_Temlu0XcByWLBbdK28YCOe")]
        public static string __slot_Temlu0XcByWLBbdK28YCOe = "Left";
        [n1.ElementAttribute(TracingId = 105143U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UCku1KLhtDqMcDA4O8wmDu", Name = "__slot_UCku1KLhtDqMcDA4O8wmDu")]
        public static string __slot_UCku1KLhtDqMcDA4O8wmDu = "Right";
        [n1.ElementAttribute(TracingId = 105144U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RblKkl92v54NeLsTwaVvH1", Name = "__slot_RblKkl92v54NeLsTwaVvH1")]
        public static string __slot_RblKkl92v54NeLsTwaVvH1 = "Up";
        [n1.ElementAttribute(TracingId = 105145U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "EfFWgravadNLVWgA5zbgM1", Name = "__slot_EfFWgravadNLVWgA5zbgM1")]
        public static string __slot_EfFWgravadNLVWgA5zbgM1 = "Down";
        [n1.ElementAttribute(TracingId = 105146U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MM7qbxjLvQ0MQw8kt4Hbmg", Name = "__slot_MM7qbxjLvQ0MQw8kt4Hbmg")]
        public static float __slot_MM7qbxjLvQ0MQw8kt4Hbmg = -1F;
        [n1.ElementAttribute(TracingId = 105208U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AJ9aNn76m7sOtPvyehvN2B", Name = "__slot_AJ9aNn76m7sOtPvyehvN2B")]
        public static string __slot_AJ9aNn76m7sOtPvyehvN2B = "PageUp";
        [n1.ElementAttribute(TracingId = 105209U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Iw8jXv2wJUHOZLqKTQyO1Y", Name = "__slot_Iw8jXv2wJUHOZLqKTQyO1Y")]
        public static string __slot_Iw8jXv2wJUHOZLqKTQyO1Y = "PageDown";
        [n1.ElementAttribute(TracingId = 105238U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KgAJaEHUbvwMstfrnuUdzd", Name = "__slot_KgAJaEHUbvwMstfrnuUdzd")]
        public static string __slot_KgAJaEHUbvwMstfrnuUdzd = "ControlKey";
        [n1.ElementAttribute(TracingId = 105140U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "V5Bb2pkE5zHOsopTloxOOG", Name = "Controls")]
        public n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> Controls;
        [n1.ElementAttribute(TracingId = 105106U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "SNiEWhfHcDCNezyppxcF6f", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_SNiEWhfHcDCNezyppxcF6f;
        [n1.ElementAttribute(TracingId = 105132U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VOOpodqTzCULwlmcnFAaVH", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_VOOpodqTzCULwlmcnFAaVH;
        [n1.ElementAttribute(TracingId = 105147U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FrYpY8swhSoMAgmCviGeUX", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FrYpY8swhSoMAgmCviGeUX;
        [n1.ElementAttribute(TracingId = 105184U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Cg8w2J7xvAAL68vV4JciKG", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Cg8w2J7xvAAL68vV4JciKG;
        [n1.ElementAttribute(TracingId = 105151U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AI7eCsxOWFcMIc32LmUerj", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_AI7eCsxOWFcMIc32LmUerj;
        [n1.ElementAttribute(TracingId = 105188U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FVhgcstQTRMLtc58tnKLIm", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FVhgcstQTRMLtc58tnKLIm;
        [n1.ElementAttribute(TracingId = 105159U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RbXt39njzzrL33naQUfyHV", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RbXt39njzzrL33naQUfyHV;
        [n1.ElementAttribute(TracingId = 105196U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "QCyAsag8bMTMNYL8T3GevE", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_QCyAsag8bMTMNYL8T3GevE;
        [n1.ElementAttribute(TracingId = 105155U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ACYNr64nm7WM2wdipeXWra", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_ACYNr64nm7WM2wdipeXWra;
        [n1.ElementAttribute(TracingId = 105192U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "At4S9Ol11qYLDkwMwaUYgE", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_At4S9Ol11qYLDkwMwaUYgE;
        [n1.ElementAttribute(TracingId = 105214U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "OT9YJei7FzZO4iYhQxDrqh", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_OT9YJei7FzZO4iYhQxDrqh;
        [n1.ElementAttribute(TracingId = 105230U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DoYgamewBVTLVGk84wZpSg", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_DoYgamewBVTLVGk84wZpSg;
        [n1.ElementAttribute(TracingId = 105210U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VeKxscHx8vSQGW61kQmYWg", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_VeKxscHx8vSQGW61kQmYWg;
        [n1.ElementAttribute(TracingId = 105226U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Q0s4gI9uNPLLVZvZcee5kY", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Q0s4gI9uNPLLVZvZcee5kY;
        [n1.ElementAttribute(TracingId = 105095U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DsNLtewtvgvMpXgXcjs1ul", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_DsNLtewtvgvMpXgXcjs1ul;
        [n1.ElementAttribute(TracingId = 105100U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "LE5ipy9CiUoMPyjk0ppkNX", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LE5ipy9CiUoMPyjk0ppkNX;
        [n1.ElementAttribute(TracingId = 105135U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Am9kxrIHbCzP5542lQ5Eej", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Am9kxrIHbCzP5542lQ5Eej;
        [n1.ElementAttribute(TracingId = 105234U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JjM9YdpFWwIORU8w9LtRHD", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JjM9YdpFWwIORU8w9LtRHD;
        static GizmoControls_RiqDyTf90wsLg4kSBfT9Tr()
        {
        }

        public GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(GizmoControls_RiqDyTf90wsLg4kSBfT9Tr other): base(other)
        {
            this.Controls = other.Controls;
            this.__p_SNiEWhfHcDCNezyppxcF6f = other.__p_SNiEWhfHcDCNezyppxcF6f;
            this.__p_VOOpodqTzCULwlmcnFAaVH = other.__p_VOOpodqTzCULwlmcnFAaVH;
            this.__p_FrYpY8swhSoMAgmCviGeUX = other.__p_FrYpY8swhSoMAgmCviGeUX;
            this.__p_Cg8w2J7xvAAL68vV4JciKG = other.__p_Cg8w2J7xvAAL68vV4JciKG;
            this.__p_AI7eCsxOWFcMIc32LmUerj = other.__p_AI7eCsxOWFcMIc32LmUerj;
            this.__p_FVhgcstQTRMLtc58tnKLIm = other.__p_FVhgcstQTRMLtc58tnKLIm;
            this.__p_RbXt39njzzrL33naQUfyHV = other.__p_RbXt39njzzrL33naQUfyHV;
            this.__p_QCyAsag8bMTMNYL8T3GevE = other.__p_QCyAsag8bMTMNYL8T3GevE;
            this.__p_ACYNr64nm7WM2wdipeXWra = other.__p_ACYNr64nm7WM2wdipeXWra;
            this.__p_At4S9Ol11qYLDkwMwaUYgE = other.__p_At4S9Ol11qYLDkwMwaUYgE;
            this.__p_OT9YJei7FzZO4iYhQxDrqh = other.__p_OT9YJei7FzZO4iYhQxDrqh;
            this.__p_DoYgamewBVTLVGk84wZpSg = other.__p_DoYgamewBVTLVGk84wZpSg;
            this.__p_VeKxscHx8vSQGW61kQmYWg = other.__p_VeKxscHx8vSQGW61kQmYWg;
            this.__p_Q0s4gI9uNPLLVZvZcee5kY = other.__p_Q0s4gI9uNPLLVZvZcee5kY;
            this.__p_DsNLtewtvgvMpXgXcjs1ul = other.__p_DsNLtewtvgvMpXgXcjs1ul;
            this.__p_LE5ipy9CiUoMPyjk0ppkNX = other.__p_LE5ipy9CiUoMPyjk0ppkNX;
            this.__p_Am9kxrIHbCzP5542lQ5Eej = other.__p_Am9kxrIHbCzP5542lQ5Eej;
            this.__p_JjM9YdpFWwIORU8w9LtRHD = other.__p_JjM9YdpFWwIORU8w9LtRHD;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Controls", in Controls), n1.CompilationHelper.GetValueOrExisting(values, "__p_SNiEWhfHcDCNezyppxcF6f", in __p_SNiEWhfHcDCNezyppxcF6f), n1.CompilationHelper.GetValueOrExisting(values, "__p_VOOpodqTzCULwlmcnFAaVH", in __p_VOOpodqTzCULwlmcnFAaVH), n1.CompilationHelper.GetValueOrExisting(values, "__p_FrYpY8swhSoMAgmCviGeUX", in __p_FrYpY8swhSoMAgmCviGeUX), n1.CompilationHelper.GetValueOrExisting(values, "__p_Cg8w2J7xvAAL68vV4JciKG", in __p_Cg8w2J7xvAAL68vV4JciKG), n1.CompilationHelper.GetValueOrExisting(values, "__p_AI7eCsxOWFcMIc32LmUerj", in __p_AI7eCsxOWFcMIc32LmUerj), n1.CompilationHelper.GetValueOrExisting(values, "__p_FVhgcstQTRMLtc58tnKLIm", in __p_FVhgcstQTRMLtc58tnKLIm), n1.CompilationHelper.GetValueOrExisting(values, "__p_RbXt39njzzrL33naQUfyHV", in __p_RbXt39njzzrL33naQUfyHV), n1.CompilationHelper.GetValueOrExisting(values, "__p_QCyAsag8bMTMNYL8T3GevE", in __p_QCyAsag8bMTMNYL8T3GevE), n1.CompilationHelper.GetValueOrExisting(values, "__p_ACYNr64nm7WM2wdipeXWra", in __p_ACYNr64nm7WM2wdipeXWra), n1.CompilationHelper.GetValueOrExisting(values, "__p_At4S9Ol11qYLDkwMwaUYgE", in __p_At4S9Ol11qYLDkwMwaUYgE), n1.CompilationHelper.GetValueOrExisting(values, "__p_OT9YJei7FzZO4iYhQxDrqh", in __p_OT9YJei7FzZO4iYhQxDrqh), n1.CompilationHelper.GetValueOrExisting(values, "__p_DoYgamewBVTLVGk84wZpSg", in __p_DoYgamewBVTLVGk84wZpSg), n1.CompilationHelper.GetValueOrExisting(values, "__p_VeKxscHx8vSQGW61kQmYWg", in __p_VeKxscHx8vSQGW61kQmYWg), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q0s4gI9uNPLLVZvZcee5kY", in __p_Q0s4gI9uNPLLVZvZcee5kY), n1.CompilationHelper.GetValueOrExisting(values, "__p_DsNLtewtvgvMpXgXcjs1ul", in __p_DsNLtewtvgvMpXgXcjs1ul), n1.CompilationHelper.GetValueOrExisting(values, "__p_LE5ipy9CiUoMPyjk0ppkNX", in __p_LE5ipy9CiUoMPyjk0ppkNX), n1.CompilationHelper.GetValueOrExisting(values, "__p_Am9kxrIHbCzP5542lQ5Eej", in __p_Am9kxrIHbCzP5542lQ5Eej), n1.CompilationHelper.GetValueOrExisting(values, "__p_JjM9YdpFWwIORU8w9LtRHD", in __p_JjM9YdpFWwIORU8w9LtRHD));
        }

        internal GizmoControls_RiqDyTf90wsLg4kSBfT9Tr __WITH__(n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> Controls, n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_SNiEWhfHcDCNezyppxcF6f, n37.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_VOOpodqTzCULwlmcnFAaVH, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FrYpY8swhSoMAgmCviGeUX, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Cg8w2J7xvAAL68vV4JciKG, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_AI7eCsxOWFcMIc32LmUerj, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_FVhgcstQTRMLtc58tnKLIm, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_RbXt39njzzrL33naQUfyHV, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_QCyAsag8bMTMNYL8T3GevE, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_ACYNr64nm7WM2wdipeXWra, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_At4S9Ol11qYLDkwMwaUYgE, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_OT9YJei7FzZO4iYhQxDrqh, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_DoYgamewBVTLVGk84wZpSg, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_VeKxscHx8vSQGW61kQmYWg, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Q0s4gI9uNPLLVZvZcee5kY, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_DsNLtewtvgvMpXgXcjs1ul, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LE5ipy9CiUoMPyjk0ppkNX, n38.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Am9kxrIHbCzP5542lQ5Eej, n37.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JjM9YdpFWwIORU8w9LtRHD)
        {
            n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Controls != this.Controls || __p_SNiEWhfHcDCNezyppxcF6f != this.__p_SNiEWhfHcDCNezyppxcF6f || __p_VOOpodqTzCULwlmcnFAaVH != this.__p_VOOpodqTzCULwlmcnFAaVH || __p_FrYpY8swhSoMAgmCviGeUX != this.__p_FrYpY8swhSoMAgmCviGeUX || __p_Cg8w2J7xvAAL68vV4JciKG != this.__p_Cg8w2J7xvAAL68vV4JciKG || __p_AI7eCsxOWFcMIc32LmUerj != this.__p_AI7eCsxOWFcMIc32LmUerj || __p_FVhgcstQTRMLtc58tnKLIm != this.__p_FVhgcstQTRMLtc58tnKLIm || __p_RbXt39njzzrL33naQUfyHV != this.__p_RbXt39njzzrL33naQUfyHV || __p_QCyAsag8bMTMNYL8T3GevE != this.__p_QCyAsag8bMTMNYL8T3GevE || __p_ACYNr64nm7WM2wdipeXWra != this.__p_ACYNr64nm7WM2wdipeXWra || __p_At4S9Ol11qYLDkwMwaUYgE != this.__p_At4S9Ol11qYLDkwMwaUYgE || __p_OT9YJei7FzZO4iYhQxDrqh != this.__p_OT9YJei7FzZO4iYhQxDrqh || __p_DoYgamewBVTLVGk84wZpSg != this.__p_DoYgamewBVTLVGk84wZpSg || __p_VeKxscHx8vSQGW61kQmYWg != this.__p_VeKxscHx8vSQGW61kQmYWg || __p_Q0s4gI9uNPLLVZvZcee5kY != this.__p_Q0s4gI9uNPLLVZvZcee5kY || __p_DsNLtewtvgvMpXgXcjs1ul != this.__p_DsNLtewtvgvMpXgXcjs1ul || __p_LE5ipy9CiUoMPyjk0ppkNX != this.__p_LE5ipy9CiUoMPyjk0ppkNX || __p_Am9kxrIHbCzP5542lQ5Eej != this.__p_Am9kxrIHbCzP5542lQ5Eej || __p_JjM9YdpFWwIORU8w9LtRHD != this.__p_JjM9YdpFWwIORU8w9LtRHD ? new GizmoControls_RiqDyTf90wsLg4kSBfT9Tr(this)
                {Controls = Controls, __p_SNiEWhfHcDCNezyppxcF6f = __p_SNiEWhfHcDCNezyppxcF6f, __p_VOOpodqTzCULwlmcnFAaVH = __p_VOOpodqTzCULwlmcnFAaVH, __p_FrYpY8swhSoMAgmCviGeUX = __p_FrYpY8swhSoMAgmCviGeUX, __p_Cg8w2J7xvAAL68vV4JciKG = __p_Cg8w2J7xvAAL68vV4JciKG, __p_AI7eCsxOWFcMIc32LmUerj = __p_AI7eCsxOWFcMIc32LmUerj, __p_FVhgcstQTRMLtc58tnKLIm = __p_FVhgcstQTRMLtc58tnKLIm, __p_RbXt39njzzrL33naQUfyHV = __p_RbXt39njzzrL33naQUfyHV, __p_QCyAsag8bMTMNYL8T3GevE = __p_QCyAsag8bMTMNYL8T3GevE, __p_ACYNr64nm7WM2wdipeXWra = __p_ACYNr64nm7WM2wdipeXWra, __p_At4S9Ol11qYLDkwMwaUYgE = __p_At4S9Ol11qYLDkwMwaUYgE, __p_OT9YJei7FzZO4iYhQxDrqh = __p_OT9YJei7FzZO4iYhQxDrqh, __p_DoYgamewBVTLVGk84wZpSg = __p_DoYgamewBVTLVGk84wZpSg, __p_VeKxscHx8vSQGW61kQmYWg = __p_VeKxscHx8vSQGW61kQmYWg, __p_Q0s4gI9uNPLLVZvZcee5kY = __p_Q0s4gI9uNPLLVZvZcee5kY, __p_DsNLtewtvgvMpXgXcjs1ul = __p_DsNLtewtvgvMpXgXcjs1ul, __p_LE5ipy9CiUoMPyjk0ppkNX = __p_LE5ipy9CiUoMPyjk0ppkNX, __p_Am9kxrIHbCzP5542lQ5Eej = __p_Am9kxrIHbCzP5542lQ5Eej, __p_JjM9YdpFWwIORU8w9LtRHD = __p_JjM9YdpFWwIORU8w9LtRHD} : that_0;
            else
            {
                this.Controls = Controls;
                this.__p_SNiEWhfHcDCNezyppxcF6f = __p_SNiEWhfHcDCNezyppxcF6f;
                this.__p_VOOpodqTzCULwlmcnFAaVH = __p_VOOpodqTzCULwlmcnFAaVH;
                this.__p_FrYpY8swhSoMAgmCviGeUX = __p_FrYpY8swhSoMAgmCviGeUX;
                this.__p_Cg8w2J7xvAAL68vV4JciKG = __p_Cg8w2J7xvAAL68vV4JciKG;
                this.__p_AI7eCsxOWFcMIc32LmUerj = __p_AI7eCsxOWFcMIc32LmUerj;
                this.__p_FVhgcstQTRMLtc58tnKLIm = __p_FVhgcstQTRMLtc58tnKLIm;
                this.__p_RbXt39njzzrL33naQUfyHV = __p_RbXt39njzzrL33naQUfyHV;
                this.__p_QCyAsag8bMTMNYL8T3GevE = __p_QCyAsag8bMTMNYL8T3GevE;
                this.__p_ACYNr64nm7WM2wdipeXWra = __p_ACYNr64nm7WM2wdipeXWra;
                this.__p_At4S9Ol11qYLDkwMwaUYgE = __p_At4S9Ol11qYLDkwMwaUYgE;
                this.__p_OT9YJei7FzZO4iYhQxDrqh = __p_OT9YJei7FzZO4iYhQxDrqh;
                this.__p_DoYgamewBVTLVGk84wZpSg = __p_DoYgamewBVTLVGk84wZpSg;
                this.__p_VeKxscHx8vSQGW61kQmYWg = __p_VeKxscHx8vSQGW61kQmYWg;
                this.__p_Q0s4gI9uNPLLVZvZcee5kY = __p_Q0s4gI9uNPLLVZvZcee5kY;
                this.__p_DsNLtewtvgvMpXgXcjs1ul = __p_DsNLtewtvgvMpXgXcjs1ul;
                this.__p_LE5ipy9CiUoMPyjk0ppkNX = __p_LE5ipy9CiUoMPyjk0ppkNX;
                this.__p_Am9kxrIHbCzP5542lQ5Eej = __p_Am9kxrIHbCzP5542lQ5Eej;
                this.__p_JjM9YdpFWwIORU8w9LtRHD = __p_JjM9YdpFWwIORU8w9LtRHD;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 105330U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NSEPHSiFs4VNPg8X1wMwHN", Name = "PointEditorView_NSEPHSiFs4VNPg8X1wMwHN")]
    [n2.SerializableAttribute]
    public class PointEditorView_NSEPHSiFs4VNPg8X1wMwHN : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN Create(n1.NodeContext Node_Context)
        {
            var instance = new PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN CreateDefault()
        {
            var instance = new PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN Update(n12.PointEditorState_R<n5.Vector2, float, bool, bool, bool, bool, n5.Vector2> Point_Editor_State_In, [n4.SerializedDefaultValueAttribute("1", false)] float Camera_Zoom_In, n5.Color4 Point_Color_In, [n4.SerializedDefaultValueAttribute("0.6400003, 0.6400003, 0.6400003, 1", false)] n5.Color4 Line_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Show_Line_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Show_Gizmo_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Show_OSD_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__RJP8O8nKV5GNyA8DKTNQGS>(this.__if_EHYQgcDPgGWNiicrDl2f5L, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __RJP8O8nKV5GNyA8DKTNQGS(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = n23._Operations_.CreateDefault<n8.ILayer>()};
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Bqp3ytd7tRaPFs2lvCGwYj", 105498U);
                    var Output_3 = n9.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_2);
                    state_1.__p_Bqp3ytd7tRaPFs2lvCGwYj = Output_3;
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "IvX1UStqtP0QIQbah9LbIP", 105506U);
                    var Output_5 = n3.PointsView_PQqoiyAh9ItOf66vhNibVw.Create(Node_Context: Node_Context_4);
                    state_1.__p_IvX1UStqtP0QIQbah9LbIP = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Vo7VtHHwg5pOeI9nVrXzLj", 105514U);
                    var Output_7 = n3.GizmoView_CBqPfiL44KTLx6sm35ChLH.Create(Node_Context: Node_Context_6);
                    state_1.__p_Vo7VtHHwg5pOeI9nVrXzLj = Output_7;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "NGjsoUWplQ3LeK336yHaMS", 105518U);
                    var Output_9 = n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp.Create(Node_Context: Node_Context_8);
                    state_1.__p_NGjsoUWplQ3LeK336yHaMS = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "O22hzobNKGlMgEyexBjPVi", 105528U);
                    var Output_11 = n3.OSD_NvBg1s1IGmmNdg56xJH4Gn.Create(Node_Context: Node_Context_10);
                    state_1.__p_O22hzobNKGlMgEyexBjPVi = Output_11;
                }

                float __pad_TXvEZx8fVEZMS0dnWQ6WE9_12 = __slot_TXvEZx8fVEZMS0dnWQ6WE9;
                bool __pad_ChoJtYRfj1ML488BadYGbR_13 = __slot_ChoJtYRfj1ML488BadYGbR;
                n5.RectangleF __pad_Va9YBcYpP6EO6ycg3mwEk0_14 = __slot_Va9YBcYpP6EO6ycg3mwEk0;
                var Output_24 = Point_Editor_State_In.Split(EditablePoints_Out: out n6.Spread<n12.EditablePoint_R<n5.Vector2>> EditablePoints_15, Pick_Size_Out: out float Pick_Size_16, Editing_Out: out bool Editing_17, Scaling_Out: out bool Scaling_18, Rotation_Out: out bool Rotation_19, Translation_Out: out bool Translation_20, Offset_Out: out n5.Vector2 Offset_21, Is_Projection_Space_Out: out bool Is_Projection_Space_22, GizmoState_Out: out n22.GizmoState_R GizmoState_23);
                var Output_25 = (float)__pad_TXvEZx8fVEZMS0dnWQ6WE9_12 / Camera_Zoom_In;
                var State_Output_27 = state_1.__p_IvX1UStqtP0QIQbah9LbIP.Update(Points_In: EditablePoints_15, Point_Color_In: Point_Color_In, Line_Color_In: Line_Color_In, Show_Line_In: Show_Line_In, PickSize_In: Pick_Size_16, Zoom_In: Output_25, Output_Out: out n8.ILayer Output_26);
                var State_Output_29 = state_1.__p_NGjsoUWplQ3LeK336yHaMS.Update(Bounds_In: __pad_Va9YBcYpP6EO6ycg3mwEk0_14, Zoom_In: Output_25, Enabled_In: __pad_ChoJtYRfj1ML488BadYGbR_13, Output_Out: out n8.ILayer Output_28);
                var State_Output_31 = state_1.__p_Vo7VtHHwg5pOeI9nVrXzLj.Update(Input_In: GizmoState_23, Enabled_In: Show_Gizmo_In, Output_Out: out n8.ILayer Output_30);
                var Output_32 = Editing_17 && Show_OSD_In;
                var State_Output_34 = state_1.__p_O22hzobNKGlMgEyexBjPVi.Update(Scale_In: Scaling_18, Rotate_In: Rotation_19, Translate_In: Translation_20, Offset_In: Offset_21, Enabled_In: Output_32, Output_Out: out n8.ILayer Output_33);
                bool Debug_35 = false;
                bool Enabled_36 = true;
                var builder_37 = n4.CollectionBuilders.GetBuilder(state_1.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj, 4);
                builder_37.Add(Output_26);
                builder_37.Add(Output_28);
                builder_37.Add(Output_30);
                builder_37.Add(Output_33);
                var __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj_38 = builder_37.Commit();
                var State_Output_40 = state_1.__p_Bqp3ytd7tRaPFs2lvCGwYj.Update(Input_In: __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj_38, Debug_In: Debug_35, Enabled_In: Enabled_36, Output_Out: out n8.ILayer Output_39);
                __auto_0 = Output_39;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = State_Output_27 != state_1.__p_IvX1UStqtP0QIQbah9LbIP || State_Output_29 != state_1.__p_NGjsoUWplQ3LeK336yHaMS || State_Output_31 != state_1.__p_Vo7VtHHwg5pOeI9nVrXzLj || State_Output_34 != state_1.__p_O22hzobNKGlMgEyexBjPVi || __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj_38 != state_1.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj || State_Output_40 != state_1.__p_Bqp3ytd7tRaPFs2lvCGwYj ? new __RJP8O8nKV5GNyA8DKTNQGS(state_1)
                    {__p_IvX1UStqtP0QIQbah9LbIP = State_Output_27, __p_NGjsoUWplQ3LeK336yHaMS = State_Output_29, __p_Vo7VtHHwg5pOeI9nVrXzLj = State_Output_31, __p_O22hzobNKGlMgEyexBjPVi = State_Output_34, __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj_38, __p_Bqp3ytd7tRaPFs2lvCGwYj = State_Output_40} : state_1;
                else
                {
                    state_1.__p_IvX1UStqtP0QIQbah9LbIP = State_Output_27;
                    state_1.__p_NGjsoUWplQ3LeK336yHaMS = State_Output_29;
                    state_1.__p_Vo7VtHHwg5pOeI9nVrXzLj = State_Output_31;
                    state_1.__p_O22hzobNKGlMgEyexBjPVi = State_Output_34;
                    state_1.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj_38;
                    state_1.__p_Bqp3ytd7tRaPFs2lvCGwYj = State_Output_40;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN that_41 = this;
            if (this.__GetContext__().IsImmutable)
                that_41 = state_1 != this.__if_EHYQgcDPgGWNiicrDl2f5L ? new PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(this)
                {__if_EHYQgcDPgGWNiicrDl2f5L = state_1} : that_41;
            else
            {
                this.__if_EHYQgcDPgGWNiicrDl2f5L = state_1;
            }

            return that_41;
        }

        public n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN that_0 = this;
            this.__if_EHYQgcDPgGWNiicrDl2f5L = default(n2.Object);
            return that_0;
        }

        public n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN __CreateDefault__()
        {
            n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN that_0 = this;
            this.__if_EHYQgcDPgGWNiicrDl2f5L = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_EHYQgcDPgGWNiicrDl2f5L);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105543U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "P6IonEhA0ApPySqkff3sWr", Name = "__slot_P6IonEhA0ApPySqkff3sWr")]
        public static string __slot_P6IonEhA0ApPySqkff3sWr = "<< Selection info is not coming from the PointEditorState. In Beta selection is drawn by the Cursor node.";
        [n1.ElementAttribute(TracingId = 105527U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TXvEZx8fVEZMS0dnWQ6WE9", Name = "__slot_TXvEZx8fVEZMS0dnWQ6WE9")]
        public static float __slot_TXvEZx8fVEZMS0dnWQ6WE9 = 1F;
        [n1.ElementAttribute(TracingId = 105539U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ChoJtYRfj1ML488BadYGbR", Name = "__slot_ChoJtYRfj1ML488BadYGbR")]
        public static bool __slot_ChoJtYRfj1ML488BadYGbR = false;
        [n1.ElementAttribute(TracingId = 105540U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Va9YBcYpP6EO6ycg3mwEk0", Name = "__slot_Va9YBcYpP6EO6ycg3mwEk0")]
        public static n5.RectangleF __slot_Va9YBcYpP6EO6ycg3mwEk0 = n41._Operations_.CreateDefault();
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_EHYQgcDPgGWNiicrDl2f5L;
        static PointEditorView_NSEPHSiFs4VNPg8X1wMwHN()
        {
        }

        public PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(PointEditorView_NSEPHSiFs4VNPg8X1wMwHN other): base(other)
        {
            this.__if_EHYQgcDPgGWNiicrDl2f5L = other.__if_EHYQgcDPgGWNiicrDl2f5L;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_EHYQgcDPgGWNiicrDl2f5L", in __if_EHYQgcDPgGWNiicrDl2f5L));
        }

        internal PointEditorView_NSEPHSiFs4VNPg8X1wMwHN __WITH__(n2.Object __if_EHYQgcDPgGWNiicrDl2f5L)
        {
            n3.PointEditorView_NSEPHSiFs4VNPg8X1wMwHN that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_EHYQgcDPgGWNiicrDl2f5L != this.__if_EHYQgcDPgGWNiicrDl2f5L ? new PointEditorView_NSEPHSiFs4VNPg8X1wMwHN(this)
                {__if_EHYQgcDPgGWNiicrDl2f5L = __if_EHYQgcDPgGWNiicrDl2f5L} : that_0;
            else
            {
                this.__if_EHYQgcDPgGWNiicrDl2f5L = __if_EHYQgcDPgGWNiicrDl2f5L;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RJP8O8nKV5GNyA8DKTNQGS", Name = "__RJP8O8nKV5GNyA8DKTNQGS")]
        [n2.SerializableAttribute]
        public class __RJP8O8nKV5GNyA8DKTNQGS : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Bqp3ytd7tRaPFs2lvCGwYj);
                n1.CompilationHelper.SafeDispose(this.__p_IvX1UStqtP0QIQbah9LbIP);
                n1.CompilationHelper.SafeDispose(this.__p_Vo7VtHHwg5pOeI9nVrXzLj);
                n1.CompilationHelper.SafeDispose(this.__p_NGjsoUWplQ3LeK336yHaMS);
                n1.CompilationHelper.SafeDispose(this.__p_O22hzobNKGlMgEyexBjPVi);
                return;
            }

            [n1.ElementAttribute(TracingId = 105498U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Bqp3ytd7tRaPFs2lvCGwYj", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Bqp3ytd7tRaPFs2lvCGwYj;
            [n1.ElementAttribute(TracingId = 105506U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IvX1UStqtP0QIQbah9LbIP", Name = "PointsView", IsManaged = true, IsAutoGenerated = true)]
            public n3.PointsView_PQqoiyAh9ItOf66vhNibVw __p_IvX1UStqtP0QIQbah9LbIP;
            [n1.ElementAttribute(TracingId = 105514U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Vo7VtHHwg5pOeI9nVrXzLj", Name = "GizmoView", IsManaged = true, IsAutoGenerated = true)]
            public n3.GizmoView_CBqPfiL44KTLx6sm35ChLH __p_Vo7VtHHwg5pOeI9nVrXzLj;
            [n1.ElementAttribute(TracingId = 105518U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NGjsoUWplQ3LeK336yHaMS", Name = "SelectionView", IsManaged = true, IsAutoGenerated = true)]
            public n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp __p_NGjsoUWplQ3LeK336yHaMS;
            [n1.ElementAttribute(TracingId = 105528U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "O22hzobNKGlMgEyexBjPVi", Name = "OSD", IsManaged = true, IsAutoGenerated = true)]
            public n3.OSD_NvBg1s1IGmmNdg56xJH4Gn __p_O22hzobNKGlMgEyexBjPVi;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = default(n6.Spread<n8.ILayer>);
            public __RJP8O8nKV5GNyA8DKTNQGS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RJP8O8nKV5GNyA8DKTNQGS(__RJP8O8nKV5GNyA8DKTNQGS other): base(other)
            {
                this.__p_Bqp3ytd7tRaPFs2lvCGwYj = other.__p_Bqp3ytd7tRaPFs2lvCGwYj;
                this.__p_IvX1UStqtP0QIQbah9LbIP = other.__p_IvX1UStqtP0QIQbah9LbIP;
                this.__p_Vo7VtHHwg5pOeI9nVrXzLj = other.__p_Vo7VtHHwg5pOeI9nVrXzLj;
                this.__p_NGjsoUWplQ3LeK336yHaMS = other.__p_NGjsoUWplQ3LeK336yHaMS;
                this.__p_O22hzobNKGlMgEyexBjPVi = other.__p_O22hzobNKGlMgEyexBjPVi;
                this.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = other.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Bqp3ytd7tRaPFs2lvCGwYj", in __p_Bqp3ytd7tRaPFs2lvCGwYj), n1.CompilationHelper.GetValueOrExisting(values, "__p_IvX1UStqtP0QIQbah9LbIP", in __p_IvX1UStqtP0QIQbah9LbIP), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vo7VtHHwg5pOeI9nVrXzLj", in __p_Vo7VtHHwg5pOeI9nVrXzLj), n1.CompilationHelper.GetValueOrExisting(values, "__p_NGjsoUWplQ3LeK336yHaMS", in __p_NGjsoUWplQ3LeK336yHaMS), n1.CompilationHelper.GetValueOrExisting(values, "__p_O22hzobNKGlMgEyexBjPVi", in __p_O22hzobNKGlMgEyexBjPVi), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj", in __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj));
            }

            internal __RJP8O8nKV5GNyA8DKTNQGS __WITH__(n9.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Bqp3ytd7tRaPFs2lvCGwYj, n3.PointsView_PQqoiyAh9ItOf66vhNibVw __p_IvX1UStqtP0QIQbah9LbIP, n3.GizmoView_CBqPfiL44KTLx6sm35ChLH __p_Vo7VtHHwg5pOeI9nVrXzLj, n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp __p_NGjsoUWplQ3LeK336yHaMS, n3.OSD_NvBg1s1IGmmNdg56xJH4Gn __p_O22hzobNKGlMgEyexBjPVi, n6.Spread<n8.ILayer> __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj)
            {
                __RJP8O8nKV5GNyA8DKTNQGS that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Bqp3ytd7tRaPFs2lvCGwYj != this.__p_Bqp3ytd7tRaPFs2lvCGwYj || __p_IvX1UStqtP0QIQbah9LbIP != this.__p_IvX1UStqtP0QIQbah9LbIP || __p_Vo7VtHHwg5pOeI9nVrXzLj != this.__p_Vo7VtHHwg5pOeI9nVrXzLj || __p_NGjsoUWplQ3LeK336yHaMS != this.__p_NGjsoUWplQ3LeK336yHaMS || __p_O22hzobNKGlMgEyexBjPVi != this.__p_O22hzobNKGlMgEyexBjPVi || __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj != this.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj ? new __RJP8O8nKV5GNyA8DKTNQGS(this)
                    {__p_Bqp3ytd7tRaPFs2lvCGwYj = __p_Bqp3ytd7tRaPFs2lvCGwYj, __p_IvX1UStqtP0QIQbah9LbIP = __p_IvX1UStqtP0QIQbah9LbIP, __p_Vo7VtHHwg5pOeI9nVrXzLj = __p_Vo7VtHHwg5pOeI9nVrXzLj, __p_NGjsoUWplQ3LeK336yHaMS = __p_NGjsoUWplQ3LeK336yHaMS, __p_O22hzobNKGlMgEyexBjPVi = __p_O22hzobNKGlMgEyexBjPVi, __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj} : that_0;
                else
                {
                    this.__p_Bqp3ytd7tRaPFs2lvCGwYj = __p_Bqp3ytd7tRaPFs2lvCGwYj;
                    this.__p_IvX1UStqtP0QIQbah9LbIP = __p_IvX1UStqtP0QIQbah9LbIP;
                    this.__p_Vo7VtHHwg5pOeI9nVrXzLj = __p_Vo7VtHHwg5pOeI9nVrXzLj;
                    this.__p_NGjsoUWplQ3LeK336yHaMS = __p_NGjsoUWplQ3LeK336yHaMS;
                    this.__p_O22hzobNKGlMgEyexBjPVi = __p_O22hzobNKGlMgEyexBjPVi;
                    this.__pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj = __pin_group_Input_In_Bqp3ytd7tRaPFs2lvCGwYj;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 105597U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JUDeZ7KywnpLlOY4LW4zpp", Name = "SelectionView_JUDeZ7KywnpLlOY4LW4zpp")]
    [n2.SerializableAttribute]
    public class SelectionView_JUDeZ7KywnpLlOY4LW4zpp : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp Create(n1.NodeContext Node_Context)
        {
            var instance = new SelectionView_JUDeZ7KywnpLlOY4LW4zpp(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp CreateDefault()
        {
            var instance = new SelectionView_JUDeZ7KywnpLlOY4LW4zpp(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp Update(n5.RectangleF Bounds_In, [n4.SerializedDefaultValueAttribute("1", false)] float Zoom_In, bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__FvCnzD7GXvvP4ZvPw8GvLY>(this.__if_IOVLUanWh82MItXVpN7JkN, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __FvCnzD7GXvvP4ZvPw8GvLY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = n23._Operations_.CreateDefault<float>()};
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "JpGEQncQ6EKMfAY31sE77H", 105605U);
                    var Output_3 = n18.Rectangle_Bounds_C.Create(Node_Context: Node_Context_2);
                    state_1.__p_JpGEQncQ6EKMfAY31sE77H = Output_3;
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Fbwswe4TKhAN7jhqohKRVd", 105610U);
                    var Output_5 = n42.Dash_Tbb74q3oVnWNQnA8Ia99B2.Create(Node_Context: Node_Context_4);
                    state_1.__p_Fbwswe4TKhAN7jhqohKRVd = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "NEFy2msWdUkO2nFqLYHdYA", 105614U);
                    var Output_7 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_6);
                    state_1.__p_NEFy2msWdUkO2nFqLYHdYA = Output_7;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "CqzVnZdlZ2KQDrT2Qd6ort", 105622U);
                    var Output_9 = n43.SetPathEffect_HWBvwGcGA1bOuOoib2v9Rv.Create(Node_Context: Node_Context_8);
                    state_1.__p_CqzVnZdlZ2KQDrT2Qd6ort = Output_9;
                }

                float __pad_ChBXcBBbOjBQK8lul7fwlb_10 = __slot_ChBXcBBbOjBQK8lul7fwlb;
                float __pad_IWSnSgJ2rDDMfHPR8362Px_11 = __slot_IWSnSgJ2rDDMfHPR8362Px;
                float __pad_RaC5XYTMZLtOZFojBq04G8_12 = __slot_RaC5XYTMZLtOZFojBq04G8;
                var Output_13 = __pad_ChBXcBBbOjBQK8lul7fwlb_10 * Zoom_In;
                var Output_14 = __pad_IWSnSgJ2rDDMfHPR8362Px_11 * Zoom_In;
                var builder_15 = n4.CollectionBuilders.GetBuilder(state_1.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz, 2);
                builder_15.Add(Output_13);
                builder_15.Add(Output_14);
                var __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz_16 = builder_15.Commit();
                n23._Operations_.Cons<float>(Input_In: __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz_16, Result_Out: out n6.Spread<float> Result_17);
                n7.IEnumerable<float> Pattern_18 = (n7.IEnumerable<float>)Result_17;
                float Pattern_Phase_19 = 0F;
                var State_Output_21 = state_1.__p_Fbwswe4TKhAN7jhqohKRVd.Update(Pattern_In: Pattern_18, Pattern_Phase_In: Pattern_Phase_19, Output_Out: out n13.SKPathEffect Output_20);
                n9.SkiaPaint_R Input_22 = n9.SkiaPaint_R.CreateDefault();
                var State_Output_24 = state_1.__p_CqzVnZdlZ2KQDrT2Qd6ort.Update(Input_In: Input_22, Effect_In: Output_20, Output_Out: out n9.SkiaPaint_R Output_23);
                n5.Color4 Color_25 = n44._Operations_.CreateDefault();
                n13.SKStrokeJoin Join_26 = __c_MPrmjohdZc3MsYnWp7DrAV;
                n13.SKStrokeCap Cap_27 = __c_HtKqxZlQPIuMhPJ8oaaApu;
                float Miter_28 = 0F;
                var State_Output_30 = state_1.__p_NEFy2msWdUkO2nFqLYHdYA.Update(Input_In: Output_23, Color_In: Color_25, Stroke_Width_In: __pad_RaC5XYTMZLtOZFojBq04G8_12, Join_In: Join_26, Cap_In: Cap_27, Miter_In: Miter_28, Output_Out: out n9.SkiaPaint_R Output_29);
                bool Enabled_31 = true;
                var State_Output_33 = state_1.__p_JpGEQncQ6EKMfAY31sE77H.Update(Bounds_In: Bounds_In, Paint_In: Output_29, Enabled_In: Enabled_31, Output_Out: out n8.ILayer Output_32);
                __auto_0 = Output_32;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz_16 != state_1.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz || State_Output_21 != state_1.__p_Fbwswe4TKhAN7jhqohKRVd || State_Output_24 != state_1.__p_CqzVnZdlZ2KQDrT2Qd6ort || State_Output_30 != state_1.__p_NEFy2msWdUkO2nFqLYHdYA || State_Output_33 != state_1.__p_JpGEQncQ6EKMfAY31sE77H ? new __FvCnzD7GXvvP4ZvPw8GvLY(state_1)
                    {__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz_16, __p_Fbwswe4TKhAN7jhqohKRVd = State_Output_21, __p_CqzVnZdlZ2KQDrT2Qd6ort = State_Output_24, __p_NEFy2msWdUkO2nFqLYHdYA = State_Output_30, __p_JpGEQncQ6EKMfAY31sE77H = State_Output_33} : state_1;
                else
                {
                    state_1.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz_16;
                    state_1.__p_Fbwswe4TKhAN7jhqohKRVd = State_Output_21;
                    state_1.__p_CqzVnZdlZ2KQDrT2Qd6ort = State_Output_24;
                    state_1.__p_NEFy2msWdUkO2nFqLYHdYA = State_Output_30;
                    state_1.__p_JpGEQncQ6EKMfAY31sE77H = State_Output_33;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp that_34 = this;
            if (this.__GetContext__().IsImmutable)
                that_34 = state_1 != this.__if_IOVLUanWh82MItXVpN7JkN ? new SelectionView_JUDeZ7KywnpLlOY4LW4zpp(this)
                {__if_IOVLUanWh82MItXVpN7JkN = state_1} : that_34;
            else
            {
                this.__if_IOVLUanWh82MItXVpN7JkN = state_1;
            }

            return that_34;
        }

        public n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp that_0 = this;
            this.__if_IOVLUanWh82MItXVpN7JkN = default(n2.Object);
            return that_0;
        }

        public n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp __CreateDefault__()
        {
            n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp that_0 = this;
            this.__if_IOVLUanWh82MItXVpN7JkN = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_IOVLUanWh82MItXVpN7JkN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105630U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ChBXcBBbOjBQK8lul7fwlb", Name = "__slot_ChBXcBBbOjBQK8lul7fwlb")]
        public static float __slot_ChBXcBBbOjBQK8lul7fwlb = 0.02F;
        [n1.ElementAttribute(TracingId = 105631U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IWSnSgJ2rDDMfHPR8362Px", Name = "__slot_IWSnSgJ2rDDMfHPR8362Px")]
        public static float __slot_IWSnSgJ2rDDMfHPR8362Px = 0.02F;
        [n1.ElementAttribute(TracingId = 105632U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RaC5XYTMZLtOZFojBq04G8", Name = "__slot_RaC5XYTMZLtOZFojBq04G8")]
        public static float __slot_RaC5XYTMZLtOZFojBq04G8 = 0F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_MPrmjohdZc3MsYnWp7DrAV = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "MPrmjohdZc3MsYnWp7DrAV");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_HtKqxZlQPIuMhPJ8oaaApu = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "HtKqxZlQPIuMhPJ8oaaApu");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_IOVLUanWh82MItXVpN7JkN;
        static SelectionView_JUDeZ7KywnpLlOY4LW4zpp()
        {
        }

        public SelectionView_JUDeZ7KywnpLlOY4LW4zpp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectionView_JUDeZ7KywnpLlOY4LW4zpp(SelectionView_JUDeZ7KywnpLlOY4LW4zpp other): base(other)
        {
            this.__if_IOVLUanWh82MItXVpN7JkN = other.__if_IOVLUanWh82MItXVpN7JkN;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_IOVLUanWh82MItXVpN7JkN", in __if_IOVLUanWh82MItXVpN7JkN));
        }

        internal SelectionView_JUDeZ7KywnpLlOY4LW4zpp __WITH__(n2.Object __if_IOVLUanWh82MItXVpN7JkN)
        {
            n3.SelectionView_JUDeZ7KywnpLlOY4LW4zpp that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_IOVLUanWh82MItXVpN7JkN != this.__if_IOVLUanWh82MItXVpN7JkN ? new SelectionView_JUDeZ7KywnpLlOY4LW4zpp(this)
                {__if_IOVLUanWh82MItXVpN7JkN = __if_IOVLUanWh82MItXVpN7JkN} : that_0;
            else
            {
                this.__if_IOVLUanWh82MItXVpN7JkN = __if_IOVLUanWh82MItXVpN7JkN;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FvCnzD7GXvvP4ZvPw8GvLY", Name = "__FvCnzD7GXvvP4ZvPw8GvLY")]
        [n2.SerializableAttribute]
        public class __FvCnzD7GXvvP4ZvPw8GvLY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JpGEQncQ6EKMfAY31sE77H);
                n1.CompilationHelper.SafeDispose(this.__p_Fbwswe4TKhAN7jhqohKRVd);
                n1.CompilationHelper.SafeDispose(this.__p_NEFy2msWdUkO2nFqLYHdYA);
                n1.CompilationHelper.SafeDispose(this.__p_CqzVnZdlZ2KQDrT2Qd6ort);
                return;
            }

            [n1.ElementAttribute(TracingId = 105605U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "JpGEQncQ6EKMfAY31sE77H", Name = "Rectangle (Bounds)", IsManaged = true, IsAutoGenerated = true)]
            public n18.Rectangle_Bounds_C __p_JpGEQncQ6EKMfAY31sE77H;
            [n1.ElementAttribute(TracingId = 105610U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Fbwswe4TKhAN7jhqohKRVd", Name = "Dash", IsManaged = true, IsAutoGenerated = true)]
            public n42.Dash_Tbb74q3oVnWNQnA8Ia99B2 __p_Fbwswe4TKhAN7jhqohKRVd;
            [n1.ElementAttribute(TracingId = 105614U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NEFy2msWdUkO2nFqLYHdYA", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_NEFy2msWdUkO2nFqLYHdYA;
            [n1.ElementAttribute(TracingId = 105622U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "CqzVnZdlZ2KQDrT2Qd6ort", Name = "SetPathEffect", IsManaged = true, IsAutoGenerated = true)]
            public n43.SetPathEffect_HWBvwGcGA1bOuOoib2v9Rv __p_CqzVnZdlZ2KQDrT2Qd6ort;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<float> __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = default(n6.Spread<float>);
            public __FvCnzD7GXvvP4ZvPw8GvLY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FvCnzD7GXvvP4ZvPw8GvLY(__FvCnzD7GXvvP4ZvPw8GvLY other): base(other)
            {
                this.__p_JpGEQncQ6EKMfAY31sE77H = other.__p_JpGEQncQ6EKMfAY31sE77H;
                this.__p_Fbwswe4TKhAN7jhqohKRVd = other.__p_Fbwswe4TKhAN7jhqohKRVd;
                this.__p_NEFy2msWdUkO2nFqLYHdYA = other.__p_NEFy2msWdUkO2nFqLYHdYA;
                this.__p_CqzVnZdlZ2KQDrT2Qd6ort = other.__p_CqzVnZdlZ2KQDrT2Qd6ort;
                this.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = other.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JpGEQncQ6EKMfAY31sE77H", in __p_JpGEQncQ6EKMfAY31sE77H), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fbwswe4TKhAN7jhqohKRVd", in __p_Fbwswe4TKhAN7jhqohKRVd), n1.CompilationHelper.GetValueOrExisting(values, "__p_NEFy2msWdUkO2nFqLYHdYA", in __p_NEFy2msWdUkO2nFqLYHdYA), n1.CompilationHelper.GetValueOrExisting(values, "__p_CqzVnZdlZ2KQDrT2Qd6ort", in __p_CqzVnZdlZ2KQDrT2Qd6ort), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz", in __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz));
            }

            internal __FvCnzD7GXvvP4ZvPw8GvLY __WITH__(n18.Rectangle_Bounds_C __p_JpGEQncQ6EKMfAY31sE77H, n42.Dash_Tbb74q3oVnWNQnA8Ia99B2 __p_Fbwswe4TKhAN7jhqohKRVd, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_NEFy2msWdUkO2nFqLYHdYA, n43.SetPathEffect_HWBvwGcGA1bOuOoib2v9Rv __p_CqzVnZdlZ2KQDrT2Qd6ort, n6.Spread<float> __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz)
            {
                __FvCnzD7GXvvP4ZvPw8GvLY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JpGEQncQ6EKMfAY31sE77H != this.__p_JpGEQncQ6EKMfAY31sE77H || __p_Fbwswe4TKhAN7jhqohKRVd != this.__p_Fbwswe4TKhAN7jhqohKRVd || __p_NEFy2msWdUkO2nFqLYHdYA != this.__p_NEFy2msWdUkO2nFqLYHdYA || __p_CqzVnZdlZ2KQDrT2Qd6ort != this.__p_CqzVnZdlZ2KQDrT2Qd6ort || __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz != this.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz ? new __FvCnzD7GXvvP4ZvPw8GvLY(this)
                    {__p_JpGEQncQ6EKMfAY31sE77H = __p_JpGEQncQ6EKMfAY31sE77H, __p_Fbwswe4TKhAN7jhqohKRVd = __p_Fbwswe4TKhAN7jhqohKRVd, __p_NEFy2msWdUkO2nFqLYHdYA = __p_NEFy2msWdUkO2nFqLYHdYA, __p_CqzVnZdlZ2KQDrT2Qd6ort = __p_CqzVnZdlZ2KQDrT2Qd6ort, __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz} : that_0;
                else
                {
                    this.__p_JpGEQncQ6EKMfAY31sE77H = __p_JpGEQncQ6EKMfAY31sE77H;
                    this.__p_Fbwswe4TKhAN7jhqohKRVd = __p_Fbwswe4TKhAN7jhqohKRVd;
                    this.__p_NEFy2msWdUkO2nFqLYHdYA = __p_NEFy2msWdUkO2nFqLYHdYA;
                    this.__p_CqzVnZdlZ2KQDrT2Qd6ort = __p_CqzVnZdlZ2KQDrT2Qd6ort;
                    this.__pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz = __pin_group_Input_In_M28zXjiAPlWMqVpB8FdjMz;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 105676U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AoOOS0kkLQhOAM5B9j3hNy", Name = "IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy")]
    [n2.SerializableAttribute]
    public class IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy Create(n1.NodeContext Node_Context)
        {
            var instance = new IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy CreateDefault()
        {
            var instance = new IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy Update(n35.IMouse Input_In, out bool Output_Out)
        {
            var Notifications_0 = Input_In.Notifications;
            bool Reset_1 = false;
            var __fallback___2 = n1.ServiceRegistry.Current;
            n48._Operations_.Update_H<n2.Object, n45.MouseNotification, bool>(Input_In: this.__p_C5lE01lw72UOr3OZe7P7LD, Messages_In: Notifications_0, Reset_In: Reset_1, Update_In: (n2.Object s_5, n45.MouseNotification Input_1_In_6) =>
            {
                using var __current_3 = __fallback___2.MakeCurrentIfNone();
                var state_4 = n1.CompilationHelper.Restore<__PfZT9TflyeYMpbDGBFX0WU>(s_5, __GetContext__());
                bool __pad_V1X0r0nOlB6LthgurznRUS_7 = __slot_V1X0r0nOlB6LthgurznRUS;
                n45.INotification Input_8 = (n45.INotification)Input_1_In_6;
                var Result_9 = n45.NotificationHelpers.IsMouseDoubleClick(notification: Input_8);
                bool __auto_10;
                if (Result_9)
                {
                    n33.MouseButtons __pad_GOg2fJxGnVcNXSF7qLOK9X_12 = __slot_GOg2fJxGnVcNXSF7qLOK9X;
                    n45.MouseButtonNotification Default_13 = default(n45.MouseButtonNotification);
                    n46._Operations_.CastAs<n45.MouseButtonNotification>(Input_In: Input_1_In_6, Default_In: Default_13, Result_Out: out n45.MouseButtonNotification Result_14, Success_Out: out bool Success_15);
                    var Buttons_16 = Result_14.Buttons;
                    var Result_17 = Buttons_16 == __pad_GOg2fJxGnVcNXSF7qLOK9X_12;
                    __auto_10 = Result_17;
                }
                else
                {
                    __auto_10 = false;
                }

                return n2.Tuple.Create<n2.Object, bool, bool>(state_4, __pad_V1X0r0nOlB6LthgurznRUS_7, __auto_10);
            }

            , Create_In: () =>
            {
                using var __current_18 = __fallback___2.MakeCurrentIfNone();
                var state_4 = new __PfZT9TflyeYMpbDGBFX0WU(__GetContext__(), n1.VLObject.NewIdentity());
                return state_4;
            }

            , Output_Out: out n47.ForEachKeep<n2.Object, n45.MouseNotification, bool> Output_19, Result_Out: out n2.IObservable<bool> Result_20);
            n49._Operations_.Sample_H<bool>(Input_In: this.__p_MTPI1RSbGgJMjF4hPOQjQ0, Async_Notifications_In: Result_20, Output_Out: out n47.Sampler<bool> Output_21, Notifications_Out: out n6.Spread<bool> Notifications_22, On_Data_Out: out bool On_Data_23);
            Output_Out = On_Data_23;
            n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = Output_19 != this.__p_C5lE01lw72UOr3OZe7P7LD || Output_21 != this.__p_MTPI1RSbGgJMjF4hPOQjQ0 ? new IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(this)
                {__p_C5lE01lw72UOr3OZe7P7LD = Output_19, __p_MTPI1RSbGgJMjF4hPOQjQ0 = Output_21} : that_24;
            else
            {
                this.__p_C5lE01lw72UOr3OZe7P7LD = Output_19;
                this.__p_MTPI1RSbGgJMjF4hPOQjQ0 = Output_21;
            }

            return that_24;
        }

        public n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Default_0 = n49._Operations_.CreateDefault_H<bool>();
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "C5lE01lw72UOr3OZe7P7LD", 105686U);
            n48._Operations_.Create_H<n2.Object, n45.MouseNotification, bool>(Node_Context: Node_Context_1, Output_Out: out n47.ForEachKeep<n2.Object, n45.MouseNotification, bool> Output_2);
            n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy that_3 = this;
            this.__p_MTPI1RSbGgJMjF4hPOQjQ0 = Default_0;
            this.__p_C5lE01lw72UOr3OZe7P7LD = Output_2;
            return that_3;
        }

        public n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy __CreateDefault__()
        {
            n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy that_0 = this;
            this.__p_C5lE01lw72UOr3OZe7P7LD = default(n47.ForEachKeep<n2.Object, n45.MouseNotification, bool>);
            this.__p_MTPI1RSbGgJMjF4hPOQjQ0 = n49._Operations_.CreateDefault_H<bool>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_C5lE01lw72UOr3OZe7P7LD);
            n1.CompilationHelper.SafeDispose(this.__p_MTPI1RSbGgJMjF4hPOQjQ0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105686U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "C5lE01lw72UOr3OZe7P7LD", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n47.ForEachKeep<n2.Object, n45.MouseNotification, bool> __p_C5lE01lw72UOr3OZe7P7LD;
        [n1.ElementAttribute(TracingId = 105702U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "V1X0r0nOlB6LthgurznRUS", Name = "__slot_V1X0r0nOlB6LthgurznRUS")]
        public static bool __slot_V1X0r0nOlB6LthgurznRUS = true;
        [n1.ElementAttribute(TracingId = 105720U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GOg2fJxGnVcNXSF7qLOK9X", Name = "__slot_GOg2fJxGnVcNXSF7qLOK9X")]
        public static n33.MouseButtons __slot_GOg2fJxGnVcNXSF7qLOK9X = n1.CompilationHelper.Deserialize<n33.MouseButtons>("Left", false, "PSPaLWEsDmnP5LJnFN7pkq", "GOg2fJxGnVcNXSF7qLOK9X");
        [n1.ElementAttribute(TracingId = 105682U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MTPI1RSbGgJMjF4hPOQjQ0", Name = "Sampler", IsManaged = true, IsAutoGenerated = true)]
        public n47.Sampler<bool> __p_MTPI1RSbGgJMjF4hPOQjQ0;
        static IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy()
        {
        }

        public IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy other): base(other)
        {
            this.__p_C5lE01lw72UOr3OZe7P7LD = other.__p_C5lE01lw72UOr3OZe7P7LD;
            this.__p_MTPI1RSbGgJMjF4hPOQjQ0 = other.__p_MTPI1RSbGgJMjF4hPOQjQ0;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_C5lE01lw72UOr3OZe7P7LD", in __p_C5lE01lw72UOr3OZe7P7LD), n1.CompilationHelper.GetValueOrExisting(values, "__p_MTPI1RSbGgJMjF4hPOQjQ0", in __p_MTPI1RSbGgJMjF4hPOQjQ0));
        }

        internal IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy __WITH__(n47.ForEachKeep<n2.Object, n45.MouseNotification, bool> __p_C5lE01lw72UOr3OZe7P7LD, n47.Sampler<bool> __p_MTPI1RSbGgJMjF4hPOQjQ0)
        {
            n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_C5lE01lw72UOr3OZe7P7LD != this.__p_C5lE01lw72UOr3OZe7P7LD || __p_MTPI1RSbGgJMjF4hPOQjQ0 != this.__p_MTPI1RSbGgJMjF4hPOQjQ0 ? new IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy(this)
                {__p_C5lE01lw72UOr3OZe7P7LD = __p_C5lE01lw72UOr3OZe7P7LD, __p_MTPI1RSbGgJMjF4hPOQjQ0 = __p_MTPI1RSbGgJMjF4hPOQjQ0} : that_0;
            else
            {
                this.__p_C5lE01lw72UOr3OZe7P7LD = __p_C5lE01lw72UOr3OZe7P7LD;
                this.__p_MTPI1RSbGgJMjF4hPOQjQ0 = __p_MTPI1RSbGgJMjF4hPOQjQ0;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PfZT9TflyeYMpbDGBFX0WU", Name = "__PfZT9TflyeYMpbDGBFX0WU")]
        [n2.SerializableAttribute]
        public class __PfZT9TflyeYMpbDGBFX0WU : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __PfZT9TflyeYMpbDGBFX0WU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PfZT9TflyeYMpbDGBFX0WU(__PfZT9TflyeYMpbDGBFX0WU other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __PfZT9TflyeYMpbDGBFX0WU __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 105751U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "BCxMrPWENH6PVzMdvA0vxY", Name = "Controls_BCxMrPWENH6PVzMdvA0vxY")]
    [n2.SerializableAttribute]
    public class Controls_BCxMrPWENH6PVzMdvA0vxY : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Controls_BCxMrPWENH6PVzMdvA0vxY Create(n1.NodeContext Node_Context)
        {
            var instance = new Controls_BCxMrPWENH6PVzMdvA0vxY(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Controls_BCxMrPWENH6PVzMdvA0vxY CreateDefault()
        {
            var instance = new Controls_BCxMrPWENH6PVzMdvA0vxY(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Controls_BCxMrPWENH6PVzMdvA0vxY Update(n35.IMouse Mouse_Device_In, n35.IKeyboard Keyboard_Device_In, out n6.Spread<n5.Vector2> Position_Out, out bool Left_DoubleClick_Out, out n12.PointEditorControlsData_R PointEditor_Controls_Out, out n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> Gizmo_Controls_Out)
        {
            var Output_10 = this.__p_H1Jkquqigi8LxNVFQn2j5I.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n5.Vector2 Position_In_World_0, Position_In_Projection_Out: out n5.Vector2 Position_In_Projection_1, Position_Out: out n5.Vector2 Position_2, Left_Pressed_Out: out bool Left_Pressed_3, Middle_Pressed_Out: out bool Middle_Pressed_4, Right_Pressed_Out: out bool Right_Pressed_5, Normalized_Position_Out: out n5.Vector2 Normalized_Position_6, WheelDelta_Out: out int WheelDelta_7, Client_Area_Out: out n5.Vector2 Client_Area_8, Sender_Out: out n2.Object Sender_9);
            var builder_11 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw, 1);
            builder_11.Add(Position_In_World_0);
            var __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw_12 = builder_11.Commit();
            n23._Operations_.FromValue<n5.Vector2>(Input_In: __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw_12, Result_Out: out n6.Spread<n5.Vector2> Result_13);
            bool Enabled_14 = true;
            var Output_16 = this.__p_QAegIbpDbwcO30UYVjkuQK.Join(Mouse_Device_In: Mouse_Device_In, Keyboard_Device_In: Keyboard_Device_In, Enabled_In: Enabled_14, PointEditor_Controls_Out: out n12.PointEditorControlsData_R PointEditor_Controls_15);
            bool Enable_17 = true;
            var Output_19 = this.__p_Jcv8CBLb9dTMVum8oEauCV.Update(Mouse_In: Mouse_Device_In, Keyboard_In: Keyboard_Device_In, Enable_In: Enable_17, Gizmo_Controls_Out: out n22.GizmoControlsState_R<n5.Vector3, bool, bool, bool> Gizmo_Controls_18);
            var State_Output_21 = this.__p_Pmpkt6H5cqFQFbUeHSoZmZ.Update(Input_In: Mouse_Device_In, Output_Out: out bool Output_20);
            Position_Out = Result_13;
            Left_DoubleClick_Out = Output_20;
            PointEditor_Controls_Out = PointEditor_Controls_15;
            Gizmo_Controls_Out = Gizmo_Controls_18;
            n3.Controls_BCxMrPWENH6PVzMdvA0vxY that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = Output_10 != this.__p_H1Jkquqigi8LxNVFQn2j5I || __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw_12 != this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw || Output_16 != this.__p_QAegIbpDbwcO30UYVjkuQK || Output_19 != this.__p_Jcv8CBLb9dTMVum8oEauCV || State_Output_21 != this.__p_Pmpkt6H5cqFQFbUeHSoZmZ ? new Controls_BCxMrPWENH6PVzMdvA0vxY(this)
                {__p_H1Jkquqigi8LxNVFQn2j5I = Output_10, __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw_12, __p_QAegIbpDbwcO30UYVjkuQK = Output_16, __p_Jcv8CBLb9dTMVum8oEauCV = Output_19, __p_Pmpkt6H5cqFQFbUeHSoZmZ = State_Output_21} : that_22;
            else
            {
                this.__p_H1Jkquqigi8LxNVFQn2j5I = Output_10;
                this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw_12;
                this.__p_QAegIbpDbwcO30UYVjkuQK = Output_16;
                this.__p_Jcv8CBLb9dTMVum8oEauCV = Output_19;
                this.__p_Pmpkt6H5cqFQFbUeHSoZmZ = State_Output_21;
            }

            return that_22;
        }

        public n3.Controls_BCxMrPWENH6PVzMdvA0vxY __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "H1Jkquqigi8LxNVFQn2j5I", 105757U);
            var Output_1 = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Jcv8CBLb9dTMVum8oEauCV", 105769U);
            var Output_3 = n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "QAegIbpDbwcO30UYVjkuQK", 105774U);
            var Output_5 = n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Pmpkt6H5cqFQFbUeHSoZmZ", 105779U);
            var Output_7 = n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy.Create(Node_Context: Node_Context_6);
            n3.Controls_BCxMrPWENH6PVzMdvA0vxY that_8 = this;
            this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__p_H1Jkquqigi8LxNVFQn2j5I = Output_1;
            this.__p_Jcv8CBLb9dTMVum8oEauCV = Output_3;
            this.__p_QAegIbpDbwcO30UYVjkuQK = Output_5;
            this.__p_Pmpkt6H5cqFQFbUeHSoZmZ = Output_7;
            return that_8;
        }

        public n3.Controls_BCxMrPWENH6PVzMdvA0vxY __CreateDefault__()
        {
            n3.Controls_BCxMrPWENH6PVzMdvA0vxY that_0 = this;
            this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__p_H1Jkquqigi8LxNVFQn2j5I = n36.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_QAegIbpDbwcO30UYVjkuQK = n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD.CreateDefault();
            this.__p_Jcv8CBLb9dTMVum8oEauCV = n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr.CreateDefault();
            this.__p_Pmpkt6H5cqFQFbUeHSoZmZ = n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_H1Jkquqigi8LxNVFQn2j5I);
            n1.CompilationHelper.SafeDispose(this.__p_QAegIbpDbwcO30UYVjkuQK);
            n1.CompilationHelper.SafeDispose(this.__p_Jcv8CBLb9dTMVum8oEauCV);
            n1.CompilationHelper.SafeDispose(this.__p_Pmpkt6H5cqFQFbUeHSoZmZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105757U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "H1Jkquqigi8LxNVFQn2j5I", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_H1Jkquqigi8LxNVFQn2j5I;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Vector2> __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = default(n6.Spread<n5.Vector2>);
        [n1.ElementAttribute(TracingId = 105774U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "QAegIbpDbwcO30UYVjkuQK", Name = "PointEditorControls", IsManaged = true, IsAutoGenerated = true)]
        public n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD __p_QAegIbpDbwcO30UYVjkuQK;
        [n1.ElementAttribute(TracingId = 105769U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Jcv8CBLb9dTMVum8oEauCV", Name = "GizmoControls", IsManaged = true, IsAutoGenerated = true)]
        public n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr __p_Jcv8CBLb9dTMVum8oEauCV;
        [n1.ElementAttribute(TracingId = 105779U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Pmpkt6H5cqFQFbUeHSoZmZ", Name = "IsLeftDoubleClick", IsManaged = true, IsAutoGenerated = true)]
        public n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy __p_Pmpkt6H5cqFQFbUeHSoZmZ;
        public Controls_BCxMrPWENH6PVzMdvA0vxY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Controls_BCxMrPWENH6PVzMdvA0vxY(Controls_BCxMrPWENH6PVzMdvA0vxY other): base(other)
        {
            this.__p_H1Jkquqigi8LxNVFQn2j5I = other.__p_H1Jkquqigi8LxNVFQn2j5I;
            this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = other.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw;
            this.__p_QAegIbpDbwcO30UYVjkuQK = other.__p_QAegIbpDbwcO30UYVjkuQK;
            this.__p_Jcv8CBLb9dTMVum8oEauCV = other.__p_Jcv8CBLb9dTMVum8oEauCV;
            this.__p_Pmpkt6H5cqFQFbUeHSoZmZ = other.__p_Pmpkt6H5cqFQFbUeHSoZmZ;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H1Jkquqigi8LxNVFQn2j5I", in __p_H1Jkquqigi8LxNVFQn2j5I), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw", in __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw), n1.CompilationHelper.GetValueOrExisting(values, "__p_QAegIbpDbwcO30UYVjkuQK", in __p_QAegIbpDbwcO30UYVjkuQK), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jcv8CBLb9dTMVum8oEauCV", in __p_Jcv8CBLb9dTMVum8oEauCV), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pmpkt6H5cqFQFbUeHSoZmZ", in __p_Pmpkt6H5cqFQFbUeHSoZmZ));
        }

        internal Controls_BCxMrPWENH6PVzMdvA0vxY __WITH__(n36.MouseState_BNOhaxXysw1MZBzyJMI18t __p_H1Jkquqigi8LxNVFQn2j5I, n6.Spread<n5.Vector2> __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw, n3.PointEditorControls_K88djuDkMfIOXDig3JmLMD __p_QAegIbpDbwcO30UYVjkuQK, n3.GizmoControls_RiqDyTf90wsLg4kSBfT9Tr __p_Jcv8CBLb9dTMVum8oEauCV, n3.IsLeftDoubleClick_AoOOS0kkLQhOAM5B9j3hNy __p_Pmpkt6H5cqFQFbUeHSoZmZ)
        {
            n3.Controls_BCxMrPWENH6PVzMdvA0vxY that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_H1Jkquqigi8LxNVFQn2j5I != this.__p_H1Jkquqigi8LxNVFQn2j5I || __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw != this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw || __p_QAegIbpDbwcO30UYVjkuQK != this.__p_QAegIbpDbwcO30UYVjkuQK || __p_Jcv8CBLb9dTMVum8oEauCV != this.__p_Jcv8CBLb9dTMVum8oEauCV || __p_Pmpkt6H5cqFQFbUeHSoZmZ != this.__p_Pmpkt6H5cqFQFbUeHSoZmZ ? new Controls_BCxMrPWENH6PVzMdvA0vxY(this)
                {__p_H1Jkquqigi8LxNVFQn2j5I = __p_H1Jkquqigi8LxNVFQn2j5I, __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw, __p_QAegIbpDbwcO30UYVjkuQK = __p_QAegIbpDbwcO30UYVjkuQK, __p_Jcv8CBLb9dTMVum8oEauCV = __p_Jcv8CBLb9dTMVum8oEauCV, __p_Pmpkt6H5cqFQFbUeHSoZmZ = __p_Pmpkt6H5cqFQFbUeHSoZmZ} : that_0;
            else
            {
                this.__p_H1Jkquqigi8LxNVFQn2j5I = __p_H1Jkquqigi8LxNVFQn2j5I;
                this.__pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw = __pin_group_Input_In_VMPWU4wr4DAOQgI0Z03taw;
                this.__p_QAegIbpDbwcO30UYVjkuQK = __p_QAegIbpDbwcO30UYVjkuQK;
                this.__p_Jcv8CBLb9dTMVum8oEauCV = __p_Jcv8CBLb9dTMVum8oEauCV;
                this.__p_Pmpkt6H5cqFQFbUeHSoZmZ = __p_Pmpkt6H5cqFQFbUeHSoZmZ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 105816U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NvBg1s1IGmmNdg56xJH4Gn", Name = "OSD_NvBg1s1IGmmNdg56xJH4Gn")]
    [n2.SerializableAttribute]
    public class OSD_NvBg1s1IGmmNdg56xJH4Gn : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.OSD_NvBg1s1IGmmNdg56xJH4Gn Create(n1.NodeContext Node_Context)
        {
            var instance = new OSD_NvBg1s1IGmmNdg56xJH4Gn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.OSD_NvBg1s1IGmmNdg56xJH4Gn CreateDefault()
        {
            var instance = new OSD_NvBg1s1IGmmNdg56xJH4Gn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.OSD_NvBg1s1IGmmNdg56xJH4Gn Update(bool Scale_In, bool Rotate_In, bool Translate_In, n5.Vector2 Offset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__IoGt8eeG3EFNdBkDJbYsz4>(this.__if_PBhYVdhcYVFPq5Dx3X2xOK, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __IoGt8eeG3EFNdBkDJbYsz4(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "RUsGyKdRE0cMcXGZ17X7i8", 105826U);
                    var Output_3 = n50.Text_IDhaSC7EQyYLRW7vKwiIIb.Create(Node_Context: Node_Context_2);
                    state_1.__p_RUsGyKdRE0cMcXGZ17X7i8 = Output_3;
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "AzdFi3BY2EENjjYtR3WFtc", 105835U);
                    var Output_5 = n51.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN.Create(Node_Context: Node_Context_4);
                    state_1.__p_AzdFi3BY2EENjjYtR3WFtc = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "FQAMjN6CBbEPFIDVYoBViq", 105863U);
                    n52._Operations_.Create_H(Node_Context: Node_Context_6, Output_Out: out n8.SetSpaceUpstream Output_7);
                    state_1.__p_FQAMjN6CBbEPFIDVYoBViq = Output_7;
                }

                float __pad_IYcCwWRg8IRNq1MMEGWiWQ_8 = __slot_IYcCwWRg8IRNq1MMEGWiWQ;
                n5.Vector2 __pad_GlMyz0awcvWLUgoA88p7O8_9 = __slot_GlMyz0awcvWLUgoA88p7O8;
                n5.Vector2 __pad_PjEIZxJrRwIPLEotStmWQs_10 = __slot_PjEIZxJrRwIPLEotStmWQs;
                bool Force_11 = false;
                bool Dispose_Cached_Outputs_12 = false;
                var manager_13 = state_1.__cache_RT1pwnI6FcgOkRRTp95eCF;
                if (manager_13 is null)
                {
                    manager_13 = new n14.Manager<n2.ValueTuple<n5.Vector2>, n2.ValueTuple<string>>(n2.ValueTuple.Create(""));
                }

                var inputs_14 = n2.ValueTuple.Create(Offset_In);
                var outputs_15 = manager_13.Outputs;
                var Has_Changed_16 = Force_11 || manager_13.InputsChanged(inputs_14);
                if (Has_Changed_16)
                {
                    if (Dispose_Cached_Outputs_12)
                        manager_13.DisposeOutputs();
                    n53._Operations_.FormatData(Scale_In: Scale_In, Rotate_In: Rotate_In, Translate_In: Translate_In, Offset_In: Offset_In, Output_Out: out string Output_18);
                    outputs_15 = n2.ValueTuple.Create(Output_18);
                    manager_13 = manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12, default, outputs_15);
                }
                else
                {
                    manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12);
                }

                var __auto_19 = outputs_15.Item1;
                n9.SkiaPaint_R Input_20 = n9.SkiaPaint_R.CreateDefault();
                n54.FontList Family_Name_21 = __c_BNHO7fWHRtWPSZ996yxoR2;
                n13.SKTypefaceStyle Style_22 = default(n13.SKTypefaceStyle);
                n5.Color4 Color_23 = n44._Operations_.CreateDefault();
                float Line_Height_in_em_24 = 1.5F;
                n13.SKTextAlign Horizontal_Alignment_25 = __c_VJEF9EG5N2nMY3Ei1AfZyH;
                n8.VerticalTextAlignment Vertical_Alignment_26 = __c_GPLjCpaswvLLl6dENh8dgD;
                bool Show_Helpers_27 = false;
                var State_Output_29 = state_1.__p_AzdFi3BY2EENjjYtR3WFtc.Update(Input_In: Input_20, Family_Name_In: Family_Name_21, Style_In: Style_22, Size_In: __pad_IYcCwWRg8IRNq1MMEGWiWQ_8, Color_In: Color_23, Line_Height_in_em_In: Line_Height_in_em_24, Horizontal_Alignment_In: Horizontal_Alignment_25, Vertical_Alignment_In: Vertical_Alignment_26, Show_Helpers_In: Show_Helpers_27, Output_Out: out n9.SkiaPaint_R Output_28);
                n20.RectangleAnchor Anchor_30 = __c_Fgu1vqQNSJ2NolNeKbe4B4;
                bool Enabled_31 = true;
                var State_Output_34 = state_1.__p_RUsGyKdRE0cMcXGZ17X7i8.Update(Position_In: __pad_PjEIZxJrRwIPLEotStmWQs_10, Size_In: __pad_GlMyz0awcvWLUgoA88p7O8_9, Anchor_In: Anchor_30, Text_In: __auto_19, Paint_In: Output_28, Enabled_In: Enabled_31, Output_Out: out n8.ILayer Output_32, Baseline_Position_Out: out n6.Spread<n5.Vector2> Baseline_Position_33);
                n8.Sizing Sizing_35 = __c_USbeQsmfpLXQZJvTz0ngJ1;
                float Width_36 = 0F;
                float Height_37 = 2F;
                n20.RectangleAnchor Origin_38 = __c_RXrEYWdW690LEk5w35YJb0;
                n8.SetSpaceUpstream Input__this__39 = state_1.__p_FQAMjN6CBbEPFIDVYoBViq;
                Input__this__39.Update(input: Output_32, sizing: Sizing_35, width: Width_36, height: Height_37, origin: Origin_38, output: out n8.ILayer Output_40);
                __auto_0 = Output_40;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = manager_13 != state_1.__cache_RT1pwnI6FcgOkRRTp95eCF || State_Output_29 != state_1.__p_AzdFi3BY2EENjjYtR3WFtc || State_Output_34 != state_1.__p_RUsGyKdRE0cMcXGZ17X7i8 || Input__this__39 != state_1.__p_FQAMjN6CBbEPFIDVYoBViq ? new __IoGt8eeG3EFNdBkDJbYsz4(state_1)
                    {__cache_RT1pwnI6FcgOkRRTp95eCF = manager_13, __p_AzdFi3BY2EENjjYtR3WFtc = State_Output_29, __p_RUsGyKdRE0cMcXGZ17X7i8 = State_Output_34, __p_FQAMjN6CBbEPFIDVYoBViq = Input__this__39} : state_1;
                else
                {
                    state_1.__cache_RT1pwnI6FcgOkRRTp95eCF = manager_13;
                    state_1.__p_AzdFi3BY2EENjjYtR3WFtc = State_Output_29;
                    state_1.__p_RUsGyKdRE0cMcXGZ17X7i8 = State_Output_34;
                    state_1.__p_FQAMjN6CBbEPFIDVYoBViq = Input__this__39;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n3.OSD_NvBg1s1IGmmNdg56xJH4Gn that_41 = this;
            if (this.__GetContext__().IsImmutable)
                that_41 = state_1 != this.__if_PBhYVdhcYVFPq5Dx3X2xOK ? new OSD_NvBg1s1IGmmNdg56xJH4Gn(this)
                {__if_PBhYVdhcYVFPq5Dx3X2xOK = state_1} : that_41;
            else
            {
                this.__if_PBhYVdhcYVFPq5Dx3X2xOK = state_1;
            }

            return that_41;
        }

        public n3.OSD_NvBg1s1IGmmNdg56xJH4Gn __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.OSD_NvBg1s1IGmmNdg56xJH4Gn that_0 = this;
            this.__if_PBhYVdhcYVFPq5Dx3X2xOK = default(n2.Object);
            return that_0;
        }

        public n3.OSD_NvBg1s1IGmmNdg56xJH4Gn __CreateDefault__()
        {
            n3.OSD_NvBg1s1IGmmNdg56xJH4Gn that_0 = this;
            this.__if_PBhYVdhcYVFPq5Dx3X2xOK = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_PBhYVdhcYVFPq5Dx3X2xOK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 105861U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IYcCwWRg8IRNq1MMEGWiWQ", Name = "__slot_IYcCwWRg8IRNq1MMEGWiWQ")]
        public static float __slot_IYcCwWRg8IRNq1MMEGWiWQ = 0.05F;
        [n1.ElementAttribute(TracingId = 105862U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GlMyz0awcvWLUgoA88p7O8", Name = "__slot_GlMyz0awcvWLUgoA88p7O8")]
        public static n5.Vector2 __slot_GlMyz0awcvWLUgoA88p7O8 = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "GlMyz0awcvWLUgoA88p7O8");
        [n1.ElementAttribute(TracingId = 105870U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PjEIZxJrRwIPLEotStmWQs", Name = "__slot_PjEIZxJrRwIPLEotStmWQs")]
        public static n5.Vector2 __slot_PjEIZxJrRwIPLEotStmWQs = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "PjEIZxJrRwIPLEotStmWQs");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n54.FontList __c_BNHO7fWHRtWPSZ996yxoR2 = n1.CompilationHelper.Deserialize<n54.FontList>("Arial", false, "PSPaLWEsDmnP5LJnFN7pkq", "BNHO7fWHRtWPSZ996yxoR2");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKTextAlign __c_VJEF9EG5N2nMY3Ei1AfZyH = n1.CompilationHelper.Deserialize<n13.SKTextAlign>("Left", false, "PSPaLWEsDmnP5LJnFN7pkq", "VJEF9EG5N2nMY3Ei1AfZyH");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.VerticalTextAlignment __c_GPLjCpaswvLLl6dENh8dgD = n1.CompilationHelper.Deserialize<n8.VerticalTextAlignment>("Bottom", false, "PSPaLWEsDmnP5LJnFN7pkq", "GPLjCpaswvLLl6dENh8dgD");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n20.RectangleAnchor __c_Fgu1vqQNSJ2NolNeKbe4B4 = n1.CompilationHelper.Deserialize<n20.RectangleAnchor>("Center", false, "PSPaLWEsDmnP5LJnFN7pkq", "Fgu1vqQNSJ2NolNeKbe4B4");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.Sizing __c_USbeQsmfpLXQZJvTz0ngJ1 = n1.CompilationHelper.Deserialize<n8.Sizing>("ManualSize", false, "PSPaLWEsDmnP5LJnFN7pkq", "USbeQsmfpLXQZJvTz0ngJ1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n20.RectangleAnchor __c_RXrEYWdW690LEk5w35YJb0 = n1.CompilationHelper.Deserialize<n20.RectangleAnchor>("BottomLeft", false, "PSPaLWEsDmnP5LJnFN7pkq", "RXrEYWdW690LEk5w35YJb0");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_PBhYVdhcYVFPq5Dx3X2xOK;
        static OSD_NvBg1s1IGmmNdg56xJH4Gn()
        {
        }

        public OSD_NvBg1s1IGmmNdg56xJH4Gn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OSD_NvBg1s1IGmmNdg56xJH4Gn(OSD_NvBg1s1IGmmNdg56xJH4Gn other): base(other)
        {
            this.__if_PBhYVdhcYVFPq5Dx3X2xOK = other.__if_PBhYVdhcYVFPq5Dx3X2xOK;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_PBhYVdhcYVFPq5Dx3X2xOK", in __if_PBhYVdhcYVFPq5Dx3X2xOK));
        }

        internal OSD_NvBg1s1IGmmNdg56xJH4Gn __WITH__(n2.Object __if_PBhYVdhcYVFPq5Dx3X2xOK)
        {
            n3.OSD_NvBg1s1IGmmNdg56xJH4Gn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_PBhYVdhcYVFPq5Dx3X2xOK != this.__if_PBhYVdhcYVFPq5Dx3X2xOK ? new OSD_NvBg1s1IGmmNdg56xJH4Gn(this)
                {__if_PBhYVdhcYVFPq5Dx3X2xOK = __if_PBhYVdhcYVFPq5Dx3X2xOK} : that_0;
            else
            {
                this.__if_PBhYVdhcYVFPq5Dx3X2xOK = __if_PBhYVdhcYVFPq5Dx3X2xOK;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IoGt8eeG3EFNdBkDJbYsz4", Name = "__IoGt8eeG3EFNdBkDJbYsz4")]
        [n2.SerializableAttribute]
        public class __IoGt8eeG3EFNdBkDJbYsz4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RUsGyKdRE0cMcXGZ17X7i8);
                n1.CompilationHelper.SafeDispose(this.__p_AzdFi3BY2EENjjYtR3WFtc);
                n1.CompilationHelper.SafeDispose(this.__p_FQAMjN6CBbEPFIDVYoBViq);
                n1.CompilationHelper.SafeDispose(this.__cache_RT1pwnI6FcgOkRRTp95eCF);
                return;
            }

            [n1.ElementAttribute(TracingId = 105826U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RUsGyKdRE0cMcXGZ17X7i8", Name = "Text", IsManaged = true, IsAutoGenerated = true)]
            public n50.Text_IDhaSC7EQyYLRW7vKwiIIb __p_RUsGyKdRE0cMcXGZ17X7i8;
            [n1.ElementAttribute(TracingId = 105835U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AzdFi3BY2EENjjYtR3WFtc", Name = "FontAndParagraph", IsManaged = true, IsAutoGenerated = true)]
            public n51.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN __p_AzdFi3BY2EENjjYtR3WFtc;
            [n1.ElementAttribute(TracingId = 105863U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FQAMjN6CBbEPFIDVYoBViq", Name = "WithinSpace", IsManaged = true, IsAutoGenerated = true)]
            public n8.SetSpaceUpstream __p_FQAMjN6CBbEPFIDVYoBViq;
            [n1.ElementAttribute(TracingId = 105846U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RT1pwnI6FcgOkRRTp95eCF", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n14.Manager<n2.ValueTuple<n5.Vector2>, n2.ValueTuple<string>> __cache_RT1pwnI6FcgOkRRTp95eCF = null;
            public __IoGt8eeG3EFNdBkDJbYsz4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IoGt8eeG3EFNdBkDJbYsz4(__IoGt8eeG3EFNdBkDJbYsz4 other): base(other)
            {
                this.__p_RUsGyKdRE0cMcXGZ17X7i8 = other.__p_RUsGyKdRE0cMcXGZ17X7i8;
                this.__p_AzdFi3BY2EENjjYtR3WFtc = other.__p_AzdFi3BY2EENjjYtR3WFtc;
                this.__p_FQAMjN6CBbEPFIDVYoBViq = other.__p_FQAMjN6CBbEPFIDVYoBViq;
                this.__cache_RT1pwnI6FcgOkRRTp95eCF = other.__cache_RT1pwnI6FcgOkRRTp95eCF;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RUsGyKdRE0cMcXGZ17X7i8", in __p_RUsGyKdRE0cMcXGZ17X7i8), n1.CompilationHelper.GetValueOrExisting(values, "__p_AzdFi3BY2EENjjYtR3WFtc", in __p_AzdFi3BY2EENjjYtR3WFtc), n1.CompilationHelper.GetValueOrExisting(values, "__p_FQAMjN6CBbEPFIDVYoBViq", in __p_FQAMjN6CBbEPFIDVYoBViq), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RT1pwnI6FcgOkRRTp95eCF", in __cache_RT1pwnI6FcgOkRRTp95eCF));
            }

            internal __IoGt8eeG3EFNdBkDJbYsz4 __WITH__(n50.Text_IDhaSC7EQyYLRW7vKwiIIb __p_RUsGyKdRE0cMcXGZ17X7i8, n51.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN __p_AzdFi3BY2EENjjYtR3WFtc, n8.SetSpaceUpstream __p_FQAMjN6CBbEPFIDVYoBViq, n14.Manager<n2.ValueTuple<n5.Vector2>, n2.ValueTuple<string>> __cache_RT1pwnI6FcgOkRRTp95eCF)
            {
                __IoGt8eeG3EFNdBkDJbYsz4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RUsGyKdRE0cMcXGZ17X7i8 != this.__p_RUsGyKdRE0cMcXGZ17X7i8 || __p_AzdFi3BY2EENjjYtR3WFtc != this.__p_AzdFi3BY2EENjjYtR3WFtc || __p_FQAMjN6CBbEPFIDVYoBViq != this.__p_FQAMjN6CBbEPFIDVYoBViq || __cache_RT1pwnI6FcgOkRRTp95eCF != this.__cache_RT1pwnI6FcgOkRRTp95eCF ? new __IoGt8eeG3EFNdBkDJbYsz4(this)
                    {__p_RUsGyKdRE0cMcXGZ17X7i8 = __p_RUsGyKdRE0cMcXGZ17X7i8, __p_AzdFi3BY2EENjjYtR3WFtc = __p_AzdFi3BY2EENjjYtR3WFtc, __p_FQAMjN6CBbEPFIDVYoBViq = __p_FQAMjN6CBbEPFIDVYoBViq, __cache_RT1pwnI6FcgOkRRTp95eCF = __cache_RT1pwnI6FcgOkRRTp95eCF} : that_0;
                else
                {
                    this.__p_RUsGyKdRE0cMcXGZ17X7i8 = __p_RUsGyKdRE0cMcXGZ17X7i8;
                    this.__p_AzdFi3BY2EENjjYtR3WFtc = __p_AzdFi3BY2EENjjYtR3WFtc;
                    this.__p_FQAMjN6CBbEPFIDVYoBViq = __p_FQAMjN6CBbEPFIDVYoBViq;
                    this.__cache_RT1pwnI6FcgOkRRTp95eCF = __cache_RT1pwnI6FcgOkRRTp95eCF;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 105910U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DIFJp9qmxpCO3GWz2Qb5ou", Name = "VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou")]
    [n2.SerializableAttribute]
    public class VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou CreateDefault()
        {
            var instance = new VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou Update()
        {
            return this;
        }

        public n3.VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou __CreateDefault__()
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

        public VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou(VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_EditorViewsApplication_DIFJp9qmxpCO3GWz2Qb5ou __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_EditorViews_.Graphics.Skia.EditorViews.GizmoView.Experimental
{
    [n1.ElementAttribute(TracingId = 103632U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VCoaztTRPukLSgIjawVi6E", Name = "DrawScale_VCoaztTRPukLSgIjawVi6E")]
    [n2.SerializableAttribute]
    public class DrawScale_VCoaztTRPukLSgIjawVi6E : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.DrawScale_VCoaztTRPukLSgIjawVi6E Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawScale_VCoaztTRPukLSgIjawVi6E(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.DrawScale_VCoaztTRPukLSgIjawVi6E CreateDefault()
        {
            var instance = new DrawScale_VCoaztTRPukLSgIjawVi6E(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.DrawScale_VCoaztTRPukLSgIjawVi6E Update(n7.IEnumerable<n5.Matrix> Transformation_In, n7.IEnumerable<n5.Color4> Colors_In, n7.IEnumerable<float> Active_Plane_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__Gr11D34ZBAqMjih8tPuNsz>(this.__if_SdG2Mphati4OR8fkAzJEuY, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __Gr11D34ZBAqMjih8tPuNsz(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_P97ObRn0LXTMXqQL5TIXjx = n23._Operations_.CreateDefault<n8.ILayer>()};
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "OXXMfHqXSubP43rbKRSap7", 103676U);
                    var Output_3 = n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g.Create(Node_Context: Node_Context_2);
                    state_1.__p_OXXMfHqXSubP43rbKRSap7 = Output_3;
                }

                var enumerator_4 = Colors_In.GetEnumerator();
                var enumerator_6 = Transformation_In.GetEnumerator();
                var enumerator_8 = Active_Plane_In.GetEnumerator();
                var manager_32 = state_1.__loop_DGM8cTL2GOmPvvc3sEcbo2 ?? new n31.ImmutableLifetimeManager();
                var iterator_33 = manager_32.GetIterator(__GetContext__());
                var builder_34 = n4.CollectionBuilders.GetBuilder(state_1.__cp_P97ObRn0LXTMXqQL5TIXjx, 16);
                n6.Spread<n8.ILayer> output_35;
                try
                {
                    var i_10 = 0;
                    while (enumerator_4.MoveNext() && enumerator_6.MoveNext() && enumerator_8.MoveNext())
                    {
                        var splicer_5 = enumerator_4.Current;
                        var splicer_7 = enumerator_6.Current;
                        var splicer_9 = enumerator_8.Current;
                        var i_local_11 = i_10;
                        __ITrXSMUESOBPMCeJkY4gT2 state_12;
                        if (!iterator_33.MoveNext(out state_12))
                        {
                            iterator_33.Add(state_12 = new __ITrXSMUESOBPMCeJkY4gT2(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Mizl0tdgj53OchHC0urO4e", 103656U);
                            var Output_14 = n18.Rectangle_KrMUyIM5UCKL1aqQ0xQ3vh.Create(Node_Context: Node_Context_13);
                            state_12.__p_Mizl0tdgj53OchHC0urO4e = Output_14;
                            n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "IyyJlaVjaZhPNYjNVYnug9", 103663U);
                            var Output_16 = n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_15);
                            state_12.__p_IyyJlaVjaZhPNYjNVYnug9 = Output_16;
                            n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "L4QbvLfgEFxLhV5zDFZLbV", 103667U);
                            var Output_18 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_17);
                            state_12.__p_L4QbvLfgEFxLhV5zDFZLbV = Output_18;
                        }

                        n10._Operations_.Highlight(Input_In: splicer_5, Is_Active_In: splicer_9, Output_Out: out n5.Color4 Output_19);
                        n9.SkiaPaint_R Input_20 = n9.SkiaPaint_R.CreateDefault();
                        n13.SKShader Shader_21 = default(n13.SKShader);
                        var State_Output_23 = state_12.__p_L4QbvLfgEFxLhV5zDFZLbV.Update(Input_In: Input_20, Color_In: Output_19, Shader_In: Shader_21, Output_Out: out n9.SkiaPaint_R Output_22);
                        n5.Vector2 Position_24 = n29._Operations_.CreateDefault();
                        n5.Vector2 Size_25 = __c_TM8ol1izHlHPLUsuTZDB7e;
                        n20.RectangleAnchor Anchor_26 = __c_N5zgsXC5AX5PkFX6E65fCF;
                        bool Enabled_27 = true;
                        var State_Output_29 = state_12.__p_Mizl0tdgj53OchHC0urO4e.Update(Position_In: Position_24, Size_In: Size_25, Anchor_In: Anchor_26, Paint_In: Output_22, Enabled_In: Enabled_27, Output_Out: out n8.ILayer Output_28);
                        var State_Output_31 = state_12.__p_IyyJlaVjaZhPNYjNVYnug9.Update(Input_In: Output_28, Transformation_In: splicer_7, Output_Out: out n8.ILayer Output_30);
                        if (state_12.__GetContext__().IsImmutable)
                            state_12 = State_Output_23 != state_12.__p_L4QbvLfgEFxLhV5zDFZLbV || State_Output_29 != state_12.__p_Mizl0tdgj53OchHC0urO4e || State_Output_31 != state_12.__p_IyyJlaVjaZhPNYjNVYnug9 ? new __ITrXSMUESOBPMCeJkY4gT2(state_12)
                            {__p_L4QbvLfgEFxLhV5zDFZLbV = State_Output_23, __p_Mizl0tdgj53OchHC0urO4e = State_Output_29, __p_IyyJlaVjaZhPNYjNVYnug9 = State_Output_31} : state_12;
                        else
                        {
                            state_12.__p_L4QbvLfgEFxLhV5zDFZLbV = State_Output_23;
                            state_12.__p_Mizl0tdgj53OchHC0urO4e = State_Output_29;
                            state_12.__p_IyyJlaVjaZhPNYjNVYnug9 = State_Output_31;
                        }

                        iterator_33.Update(state_12);
                        builder_34.Add(Output_30);
                        i_10++;
                    }
                }
                finally
                {
                    enumerator_4.Dispose();
                    enumerator_6.Dispose();
                    enumerator_8.Dispose();
                    manager_32 = iterator_33.Commit();
                    output_35 = builder_34.Commit();
                }

                n7.IEnumerable<n8.ILayer> Input_36 = (n7.IEnumerable<n8.ILayer>)output_35;
                bool Debug_37 = false;
                bool Enabled_38 = true;
                var State_Output_40 = state_1.__p_OXXMfHqXSubP43rbKRSap7.Update(Input_In: Input_36, Debug_In: Debug_37, Enabled_In: Enabled_38, Output_Out: out n8.ILayer Output_39);
                __auto_0 = Output_39;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = manager_32 != state_1.__loop_DGM8cTL2GOmPvvc3sEcbo2 || output_35 != state_1.__cp_P97ObRn0LXTMXqQL5TIXjx || State_Output_40 != state_1.__p_OXXMfHqXSubP43rbKRSap7 ? new __Gr11D34ZBAqMjih8tPuNsz(state_1)
                    {__loop_DGM8cTL2GOmPvvc3sEcbo2 = manager_32, __cp_P97ObRn0LXTMXqQL5TIXjx = output_35, __p_OXXMfHqXSubP43rbKRSap7 = State_Output_40} : state_1;
                else
                {
                    state_1.__loop_DGM8cTL2GOmPvvc3sEcbo2 = manager_32;
                    state_1.__cp_P97ObRn0LXTMXqQL5TIXjx = output_35;
                    state_1.__p_OXXMfHqXSubP43rbKRSap7 = State_Output_40;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n10.DrawScale_VCoaztTRPukLSgIjawVi6E that_41 = this;
            if (this.__GetContext__().IsImmutable)
                that_41 = state_1 != this.__if_SdG2Mphati4OR8fkAzJEuY ? new DrawScale_VCoaztTRPukLSgIjawVi6E(this)
                {__if_SdG2Mphati4OR8fkAzJEuY = state_1} : that_41;
            else
            {
                this.__if_SdG2Mphati4OR8fkAzJEuY = state_1;
            }

            return that_41;
        }

        public n10.DrawScale_VCoaztTRPukLSgIjawVi6E __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n10.DrawScale_VCoaztTRPukLSgIjawVi6E that_0 = this;
            this.__if_SdG2Mphati4OR8fkAzJEuY = default(n2.Object);
            return that_0;
        }

        public n10.DrawScale_VCoaztTRPukLSgIjawVi6E __CreateDefault__()
        {
            n10.DrawScale_VCoaztTRPukLSgIjawVi6E that_0 = this;
            this.__if_SdG2Mphati4OR8fkAzJEuY = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_SdG2Mphati4OR8fkAzJEuY);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_TM8ol1izHlHPLUsuTZDB7e = n1.CompilationHelper.Deserialize<n5.Vector2>("1, 1", false, "PSPaLWEsDmnP5LJnFN7pkq", "TM8ol1izHlHPLUsuTZDB7e");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n20.RectangleAnchor __c_N5zgsXC5AX5PkFX6E65fCF = n1.CompilationHelper.Deserialize<n20.RectangleAnchor>("Center", false, "PSPaLWEsDmnP5LJnFN7pkq", "N5zgsXC5AX5PkFX6E65fCF");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_SdG2Mphati4OR8fkAzJEuY;
        static DrawScale_VCoaztTRPukLSgIjawVi6E()
        {
        }

        public DrawScale_VCoaztTRPukLSgIjawVi6E(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawScale_VCoaztTRPukLSgIjawVi6E(DrawScale_VCoaztTRPukLSgIjawVi6E other): base(other)
        {
            this.__if_SdG2Mphati4OR8fkAzJEuY = other.__if_SdG2Mphati4OR8fkAzJEuY;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_SdG2Mphati4OR8fkAzJEuY", in __if_SdG2Mphati4OR8fkAzJEuY));
        }

        internal DrawScale_VCoaztTRPukLSgIjawVi6E __WITH__(n2.Object __if_SdG2Mphati4OR8fkAzJEuY)
        {
            n10.DrawScale_VCoaztTRPukLSgIjawVi6E that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_SdG2Mphati4OR8fkAzJEuY != this.__if_SdG2Mphati4OR8fkAzJEuY ? new DrawScale_VCoaztTRPukLSgIjawVi6E(this)
                {__if_SdG2Mphati4OR8fkAzJEuY = __if_SdG2Mphati4OR8fkAzJEuY} : that_0;
            else
            {
                this.__if_SdG2Mphati4OR8fkAzJEuY = __if_SdG2Mphati4OR8fkAzJEuY;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Gr11D34ZBAqMjih8tPuNsz", Name = "__Gr11D34ZBAqMjih8tPuNsz")]
        [n2.SerializableAttribute]
        public class __Gr11D34ZBAqMjih8tPuNsz : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OXXMfHqXSubP43rbKRSap7);
                n1.CompilationHelper.SafeDispose(this.__loop_DGM8cTL2GOmPvvc3sEcbo2);
                return;
            }

            [n1.ElementAttribute(TracingId = 103676U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "OXXMfHqXSubP43rbKRSap7", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_OXXMfHqXSubP43rbKRSap7;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n31.ImmutableLifetimeManager __loop_DGM8cTL2GOmPvvc3sEcbo2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __cp_P97ObRn0LXTMXqQL5TIXjx;
            public __Gr11D34ZBAqMjih8tPuNsz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Gr11D34ZBAqMjih8tPuNsz(__Gr11D34ZBAqMjih8tPuNsz other): base(other)
            {
                this.__p_OXXMfHqXSubP43rbKRSap7 = other.__p_OXXMfHqXSubP43rbKRSap7;
                this.__loop_DGM8cTL2GOmPvvc3sEcbo2 = other.__loop_DGM8cTL2GOmPvvc3sEcbo2;
                this.__cp_P97ObRn0LXTMXqQL5TIXjx = other.__cp_P97ObRn0LXTMXqQL5TIXjx;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OXXMfHqXSubP43rbKRSap7", in __p_OXXMfHqXSubP43rbKRSap7), n1.CompilationHelper.GetValueOrExisting(values, "__loop_DGM8cTL2GOmPvvc3sEcbo2", in __loop_DGM8cTL2GOmPvvc3sEcbo2), n1.CompilationHelper.GetValueOrExisting(values, "__cp_P97ObRn0LXTMXqQL5TIXjx", in __cp_P97ObRn0LXTMXqQL5TIXjx));
            }

            internal __Gr11D34ZBAqMjih8tPuNsz __WITH__(n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_OXXMfHqXSubP43rbKRSap7, n31.ImmutableLifetimeManager __loop_DGM8cTL2GOmPvvc3sEcbo2, n6.Spread<n8.ILayer> __cp_P97ObRn0LXTMXqQL5TIXjx)
            {
                __Gr11D34ZBAqMjih8tPuNsz that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OXXMfHqXSubP43rbKRSap7 != this.__p_OXXMfHqXSubP43rbKRSap7 || __loop_DGM8cTL2GOmPvvc3sEcbo2 != this.__loop_DGM8cTL2GOmPvvc3sEcbo2 || __cp_P97ObRn0LXTMXqQL5TIXjx != this.__cp_P97ObRn0LXTMXqQL5TIXjx ? new __Gr11D34ZBAqMjih8tPuNsz(this)
                    {__p_OXXMfHqXSubP43rbKRSap7 = __p_OXXMfHqXSubP43rbKRSap7, __loop_DGM8cTL2GOmPvvc3sEcbo2 = __loop_DGM8cTL2GOmPvvc3sEcbo2, __cp_P97ObRn0LXTMXqQL5TIXjx = __cp_P97ObRn0LXTMXqQL5TIXjx} : that_0;
                else
                {
                    this.__p_OXXMfHqXSubP43rbKRSap7 = __p_OXXMfHqXSubP43rbKRSap7;
                    this.__loop_DGM8cTL2GOmPvvc3sEcbo2 = __loop_DGM8cTL2GOmPvvc3sEcbo2;
                    this.__cp_P97ObRn0LXTMXqQL5TIXjx = __cp_P97ObRn0LXTMXqQL5TIXjx;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ITrXSMUESOBPMCeJkY4gT2", Name = "__ITrXSMUESOBPMCeJkY4gT2")]
        [n2.SerializableAttribute]
        public class __ITrXSMUESOBPMCeJkY4gT2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Mizl0tdgj53OchHC0urO4e);
                n1.CompilationHelper.SafeDispose(this.__p_IyyJlaVjaZhPNYjNVYnug9);
                n1.CompilationHelper.SafeDispose(this.__p_L4QbvLfgEFxLhV5zDFZLbV);
                return;
            }

            [n1.ElementAttribute(TracingId = 103656U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Mizl0tdgj53OchHC0urO4e", Name = "Rectangle", IsManaged = true, IsAutoGenerated = true)]
            public n18.Rectangle_KrMUyIM5UCKL1aqQ0xQ3vh __p_Mizl0tdgj53OchHC0urO4e;
            [n1.ElementAttribute(TracingId = 103663U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IyyJlaVjaZhPNYjNVYnug9", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_IyyJlaVjaZhPNYjNVYnug9;
            [n1.ElementAttribute(TracingId = 103667U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "L4QbvLfgEFxLhV5zDFZLbV", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_L4QbvLfgEFxLhV5zDFZLbV;
            public __ITrXSMUESOBPMCeJkY4gT2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ITrXSMUESOBPMCeJkY4gT2(__ITrXSMUESOBPMCeJkY4gT2 other): base(other)
            {
                this.__p_Mizl0tdgj53OchHC0urO4e = other.__p_Mizl0tdgj53OchHC0urO4e;
                this.__p_IyyJlaVjaZhPNYjNVYnug9 = other.__p_IyyJlaVjaZhPNYjNVYnug9;
                this.__p_L4QbvLfgEFxLhV5zDFZLbV = other.__p_L4QbvLfgEFxLhV5zDFZLbV;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Mizl0tdgj53OchHC0urO4e", in __p_Mizl0tdgj53OchHC0urO4e), n1.CompilationHelper.GetValueOrExisting(values, "__p_IyyJlaVjaZhPNYjNVYnug9", in __p_IyyJlaVjaZhPNYjNVYnug9), n1.CompilationHelper.GetValueOrExisting(values, "__p_L4QbvLfgEFxLhV5zDFZLbV", in __p_L4QbvLfgEFxLhV5zDFZLbV));
            }

            internal __ITrXSMUESOBPMCeJkY4gT2 __WITH__(n18.Rectangle_KrMUyIM5UCKL1aqQ0xQ3vh __p_Mizl0tdgj53OchHC0urO4e, n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_IyyJlaVjaZhPNYjNVYnug9, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_L4QbvLfgEFxLhV5zDFZLbV)
            {
                __ITrXSMUESOBPMCeJkY4gT2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Mizl0tdgj53OchHC0urO4e != this.__p_Mizl0tdgj53OchHC0urO4e || __p_IyyJlaVjaZhPNYjNVYnug9 != this.__p_IyyJlaVjaZhPNYjNVYnug9 || __p_L4QbvLfgEFxLhV5zDFZLbV != this.__p_L4QbvLfgEFxLhV5zDFZLbV ? new __ITrXSMUESOBPMCeJkY4gT2(this)
                    {__p_Mizl0tdgj53OchHC0urO4e = __p_Mizl0tdgj53OchHC0urO4e, __p_IyyJlaVjaZhPNYjNVYnug9 = __p_IyyJlaVjaZhPNYjNVYnug9, __p_L4QbvLfgEFxLhV5zDFZLbV = __p_L4QbvLfgEFxLhV5zDFZLbV} : that_0;
                else
                {
                    this.__p_Mizl0tdgj53OchHC0urO4e = __p_Mizl0tdgj53OchHC0urO4e;
                    this.__p_IyyJlaVjaZhPNYjNVYnug9 = __p_IyyJlaVjaZhPNYjNVYnug9;
                    this.__p_L4QbvLfgEFxLhV5zDFZLbV = __p_L4QbvLfgEFxLhV5zDFZLbV;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103716U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "BbwjpL9scQpQVX3veRGirk", Name = "DrawTranslate_BbwjpL9scQpQVX3veRGirk")]
    [n2.SerializableAttribute]
    public class DrawTranslate_BbwjpL9scQpQVX3veRGirk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawTranslate_BbwjpL9scQpQVX3veRGirk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk CreateDefault()
        {
            var instance = new DrawTranslate_BbwjpL9scQpQVX3veRGirk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk Update(n7.IEnumerable<n5.Matrix> Transformations_In, n7.IEnumerable<n5.Color4> Colors_In, n7.IEnumerable<float> Active_Axis_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n6.Spread<n5.Vector2> __pad_LVNuL4zWru8QVE6nHn5Iu9_0 = this.__slot_LVNuL4zWru8QVE6nHn5Iu9;
            n6.Spread<n5.Vector2> __pad_NVN9iDxKSjtNtXuZnjk03F_1 = this.__slot_NVN9iDxKSjtNtXuZnjk03F;
            n8.ILayer __auto_2;
            var state_3 = n1.CompilationHelper.Restore<__ROgxspAdeiiPZ5bt4Neu9j>(this.__if_Vrd2EGGtz65OtpprNJHxhD, __GetContext__());
            if (Enabled_In)
            {
                if (state_3 == null)
                {
                    state_3 = new __ROgxspAdeiiPZ5bt4Neu9j(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_BLDaspvykCAP5nxT3FzKGr = n23._Operations_.CreateDefault<n8.ILayer>()};
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "HzUnIvkrmE0P34JtAkmtI9", 103783U);
                    var Output_5 = n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g.Create(Node_Context: Node_Context_4);
                    state_3.__p_HzUnIvkrmE0P34JtAkmtI9 = Output_5;
                }

                var enumerator_6 = Transformations_In.GetEnumerator();
                var enumerator_8 = n4.CollectionExtensions.AsSpan(__pad_LVNuL4zWru8QVE6nHn5Iu9_0).GetEnumerator();
                var enumerator_10 = n4.CollectionExtensions.AsSpan(__pad_NVN9iDxKSjtNtXuZnjk03F_1).GetEnumerator();
                var enumerator_12 = Colors_In.GetEnumerator();
                var enumerator_14 = Active_Axis_In.GetEnumerator();
                var manager_49 = state_3.__loop_R1pJcu4n9BKP9e62rMFilO ?? new n31.ImmutableLifetimeManager();
                var iterator_50 = manager_49.GetIterator(__GetContext__());
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_3.__cp_BLDaspvykCAP5nxT3FzKGr, 16);
                n6.Spread<n8.ILayer> output_52;
                try
                {
                    var i_16 = 0;
                    while (enumerator_6.MoveNext() && enumerator_8.MoveNext() && enumerator_10.MoveNext() && enumerator_12.MoveNext() && enumerator_14.MoveNext())
                    {
                        var splicer_7 = enumerator_6.Current;
                        var splicer_9 = enumerator_8.Current;
                        var splicer_11 = enumerator_10.Current;
                        var splicer_13 = enumerator_12.Current;
                        var splicer_15 = enumerator_14.Current;
                        var i_local_17 = i_16;
                        __LFQCsSI9GswPsw84n4lyRR state_18;
                        if (!iterator_50.MoveNext(out state_18))
                        {
                            iterator_50.Add(state_18 = new __LFQCsSI9GswPsw84n4lyRR(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Ht6XncgVQpFMcE90UFPD51", 103742U);
                            var Output_20 = n18.Arrow_LkmkJWVjwT1N0iaFX8x0DS.Create(Node_Context: Node_Context_19);
                            state_18.__p_Ht6XncgVQpFMcE90UFPD51 = Output_20;
                            n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "SeVe943CUFaOg1zNVkeIHY", 103751U);
                            var Output_22 = n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_21);
                            state_18.__p_SeVe943CUFaOg1zNVkeIHY = Output_22;
                            n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "DC7SPAUVI0yNeXgTMQ8TF6", 103755U);
                            var Output_24 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_23);
                            state_18.__p_DC7SPAUVI0yNeXgTMQ8TF6 = Output_24;
                        }

                        n5.Vector2 __pad_M2h89ygCKVdN6ixYzfh5Rp_25 = __slot_M2h89ygCKVdN6ixYzfh5Rp;
                        n10._Operations_.Highlight(Input_In: splicer_13, Is_Active_In: splicer_15, Output_Out: out n5.Color4 Output_26);
                        n9.SkiaPaint_R Input_27 = n9.SkiaPaint_R.CreateDefault();
                        float Stroke_Width_28 = 0F;
                        n13.SKStrokeJoin Join_29 = __c_TacW4PDyRZ6NthnqHAsZTv;
                        n13.SKStrokeCap Cap_30 = __c_RJzMsPvTELdNZnZrkX8yQ3;
                        float Miter_31 = 0F;
                        var State_Output_33 = state_18.__p_DC7SPAUVI0yNeXgTMQ8TF6.Update(Input_In: Input_27, Color_In: Output_26, Stroke_Width_In: Stroke_Width_28, Join_In: Join_29, Cap_In: Cap_30, Miter_In: Miter_31, Output_Out: out n9.SkiaPaint_R Output_32);
                        float Tip_Size_34 = 0.2F;
                        float Tip_Widening_35 = 0.17F;
                        bool Tail_Enable_36 = false;
                        bool Enabled_37 = true;
                        var State_Output_39 = state_18.__p_Ht6XncgVQpFMcE90UFPD51.Update(From_In: splicer_9, To_In: splicer_11, Tip_Size_In: Tip_Size_34, Tip_Widening_In: Tip_Widening_35, Tail_Enable_In: Tail_Enable_36, Paint_In: Output_32, Enabled_In: Enabled_37, Output_Out: out n18.PathLayer_C Output_38);
                        n8.ILayer Input_40 = (n8.ILayer)Output_38;
                        n5.Vector2.TransformCoordinate(coordinate: ref __pad_M2h89ygCKVdN6ixYzfh5Rp_25, transform: ref splicer_7, result: out n5.Vector2 Output_41);
                        n5.Matrix Input_42 = n24._Operations_.CreateDefault();
                        n32._Operations_.Translate(Input_In: Input_42, Translation_In: Output_41, Output_Out: out n5.Matrix Output_43);
                        var State_Output_45 = state_18.__p_SeVe943CUFaOg1zNVkeIHY.Update(Input_In: Input_40, Transformation_In: Output_43, Output_Out: out n8.ILayer Output_44);
                        n32._Operations_.Translate(Input_In: splicer_7, Translation_In: __pad_M2h89ygCKVdN6ixYzfh5Rp_25, Output_Out: out n5.Matrix Output_46);
                        n5.Vector3 Translation_47 = n26._Operations_.CreateDefault();
                        n5.Matrix.Translation(value: ref Translation_47, result: out n5.Matrix Result_48);
                        if (state_18.__GetContext__().IsImmutable)
                            state_18 = State_Output_33 != state_18.__p_DC7SPAUVI0yNeXgTMQ8TF6 || State_Output_39 != state_18.__p_Ht6XncgVQpFMcE90UFPD51 || State_Output_45 != state_18.__p_SeVe943CUFaOg1zNVkeIHY ? new __LFQCsSI9GswPsw84n4lyRR(state_18)
                            {__p_DC7SPAUVI0yNeXgTMQ8TF6 = State_Output_33, __p_Ht6XncgVQpFMcE90UFPD51 = State_Output_39, __p_SeVe943CUFaOg1zNVkeIHY = State_Output_45} : state_18;
                        else
                        {
                            state_18.__p_DC7SPAUVI0yNeXgTMQ8TF6 = State_Output_33;
                            state_18.__p_Ht6XncgVQpFMcE90UFPD51 = State_Output_39;
                            state_18.__p_SeVe943CUFaOg1zNVkeIHY = State_Output_45;
                        }

                        iterator_50.Update(state_18);
                        builder_51.Add(Output_44);
                        i_16++;
                    }
                }
                finally
                {
                    enumerator_6.Dispose();
                    enumerator_12.Dispose();
                    enumerator_14.Dispose();
                    manager_49 = iterator_50.Commit();
                    output_52 = builder_51.Commit();
                }

                n7.IEnumerable<n8.ILayer> Input_53 = (n7.IEnumerable<n8.ILayer>)output_52;
                bool Debug_54 = false;
                bool Enabled_55 = true;
                var State_Output_57 = state_3.__p_HzUnIvkrmE0P34JtAkmtI9.Update(Input_In: Input_53, Debug_In: Debug_54, Enabled_In: Enabled_55, Output_Out: out n8.ILayer Output_56);
                __auto_2 = Output_56;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_49 != state_3.__loop_R1pJcu4n9BKP9e62rMFilO || output_52 != state_3.__cp_BLDaspvykCAP5nxT3FzKGr || State_Output_57 != state_3.__p_HzUnIvkrmE0P34JtAkmtI9 ? new __ROgxspAdeiiPZ5bt4Neu9j(state_3)
                    {__loop_R1pJcu4n9BKP9e62rMFilO = manager_49, __cp_BLDaspvykCAP5nxT3FzKGr = output_52, __p_HzUnIvkrmE0P34JtAkmtI9 = State_Output_57} : state_3;
                else
                {
                    state_3.__loop_R1pJcu4n9BKP9e62rMFilO = manager_49;
                    state_3.__cp_BLDaspvykCAP5nxT3FzKGr = output_52;
                    state_3.__p_HzUnIvkrmE0P34JtAkmtI9 = State_Output_57;
                }
            }
            else
            {
                __auto_2 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_2;
            n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk that_58 = this;
            if (this.__GetContext__().IsImmutable)
                that_58 = state_3 != this.__if_Vrd2EGGtz65OtpprNJHxhD ? new DrawTranslate_BbwjpL9scQpQVX3veRGirk(this)
                {__if_Vrd2EGGtz65OtpprNJHxhD = state_3} : that_58;
            else
            {
                this.__if_Vrd2EGGtz65OtpprNJHxhD = state_3;
            }

            return that_58;
        }

        public n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.Vector2 __pad_PWKt9FXm8tYOoYoA9apQTX_0 = __slot_PWKt9FXm8tYOoYoA9apQTX;
            n5.Vector2 __pad_DDX42QXwo6zNn7BCgvkbYn_1 = __slot_DDX42QXwo6zNn7BCgvkbYn;
            n5.Vector2 __pad_Fnt9pbrejKoNiMvNEyaGY1_2 = __slot_Fnt9pbrejKoNiMvNEyaGY1;
            n5.Vector2 __pad_T8jSyuGYhefMkiOlqms6xE_3 = __slot_T8jSyuGYhefMkiOlqms6xE;
            var builder_4 = n4.CollectionBuilders.GetBuilder(n23._Operations_.CreateDefault<n5.Vector2>(), 2);
            builder_4.Add(__pad_PWKt9FXm8tYOoYoA9apQTX_0);
            builder_4.Add(__pad_DDX42QXwo6zNn7BCgvkbYn_1);
            var __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt_5 = builder_4.Commit();
            n23._Operations_.Cons<n5.Vector2>(Input_In: __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt_5, Result_Out: out n6.Spread<n5.Vector2> Result_6);
            n6.Spread<n5.Vector2> __pad_LVNuL4zWru8QVE6nHn5Iu9_7 = Result_6;
            var builder_8 = n4.CollectionBuilders.GetBuilder(n23._Operations_.CreateDefault<n5.Vector2>(), 2);
            builder_8.Add(__pad_Fnt9pbrejKoNiMvNEyaGY1_2);
            builder_8.Add(__pad_T8jSyuGYhefMkiOlqms6xE_3);
            var __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5_9 = builder_8.Commit();
            n23._Operations_.Cons<n5.Vector2>(Input_In: __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5_9, Result_Out: out n6.Spread<n5.Vector2> Result_10);
            n6.Spread<n5.Vector2> __pad_NVN9iDxKSjtNtXuZnjk03F_11 = Result_10;
            n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk that_12 = this;
            this.__slot_LVNuL4zWru8QVE6nHn5Iu9 = Result_6;
            this.__slot_NVN9iDxKSjtNtXuZnjk03F = Result_10;
            this.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt_5;
            this.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5_9;
            this.__if_Vrd2EGGtz65OtpprNJHxhD = default(n2.Object);
            return that_12;
        }

        public n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk __CreateDefault__()
        {
            n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk that_0 = this;
            this.__slot_LVNuL4zWru8QVE6nHn5Iu9 = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__slot_NVN9iDxKSjtNtXuZnjk03F = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__if_Vrd2EGGtz65OtpprNJHxhD = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Vrd2EGGtz65OtpprNJHxhD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 103788U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PWKt9FXm8tYOoYoA9apQTX", Name = "__slot_PWKt9FXm8tYOoYoA9apQTX")]
        public static n5.Vector2 __slot_PWKt9FXm8tYOoYoA9apQTX = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "PWKt9FXm8tYOoYoA9apQTX");
        [n1.ElementAttribute(TracingId = 103789U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Fnt9pbrejKoNiMvNEyaGY1", Name = "__slot_Fnt9pbrejKoNiMvNEyaGY1")]
        public static n5.Vector2 __slot_Fnt9pbrejKoNiMvNEyaGY1 = n1.CompilationHelper.Deserialize<n5.Vector2>("1, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "Fnt9pbrejKoNiMvNEyaGY1");
        [n1.ElementAttribute(TracingId = 103790U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DDX42QXwo6zNn7BCgvkbYn", Name = "__slot_DDX42QXwo6zNn7BCgvkbYn")]
        public static n5.Vector2 __slot_DDX42QXwo6zNn7BCgvkbYn = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "DDX42QXwo6zNn7BCgvkbYn");
        [n1.ElementAttribute(TracingId = 103791U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "T8jSyuGYhefMkiOlqms6xE", Name = "__slot_T8jSyuGYhefMkiOlqms6xE")]
        public static n5.Vector2 __slot_T8jSyuGYhefMkiOlqms6xE = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "T8jSyuGYhefMkiOlqms6xE");
        [n1.ElementAttribute(TracingId = 103800U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "LVNuL4zWru8QVE6nHn5Iu9", Name = "__slot_LVNuL4zWru8QVE6nHn5Iu9")]
        public n6.Spread<n5.Vector2> __slot_LVNuL4zWru8QVE6nHn5Iu9;
        [n1.ElementAttribute(TracingId = 103801U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NVN9iDxKSjtNtXuZnjk03F", Name = "__slot_NVN9iDxKSjtNtXuZnjk03F")]
        public n6.Spread<n5.Vector2> __slot_NVN9iDxKSjtNtXuZnjk03F;
        [n1.ElementAttribute(TracingId = 103774U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "M2h89ygCKVdN6ixYzfh5Rp", Name = "__slot_M2h89ygCKVdN6ixYzfh5Rp")]
        public static n5.Vector2 __slot_M2h89ygCKVdN6ixYzfh5Rp = n1.CompilationHelper.Deserialize<n5.Vector2>("0.74, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "M2h89ygCKVdN6ixYzfh5Rp");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_TacW4PDyRZ6NthnqHAsZTv = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "TacW4PDyRZ6NthnqHAsZTv");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_RJzMsPvTELdNZnZrkX8yQ3 = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "RJzMsPvTELdNZnZrkX8yQ3");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Vrd2EGGtz65OtpprNJHxhD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Vector2> __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = default(n6.Spread<n5.Vector2>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Vector2> __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = default(n6.Spread<n5.Vector2>);
        static DrawTranslate_BbwjpL9scQpQVX3veRGirk()
        {
        }

        public DrawTranslate_BbwjpL9scQpQVX3veRGirk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawTranslate_BbwjpL9scQpQVX3veRGirk(DrawTranslate_BbwjpL9scQpQVX3veRGirk other): base(other)
        {
            this.__slot_LVNuL4zWru8QVE6nHn5Iu9 = other.__slot_LVNuL4zWru8QVE6nHn5Iu9;
            this.__slot_NVN9iDxKSjtNtXuZnjk03F = other.__slot_NVN9iDxKSjtNtXuZnjk03F;
            this.__if_Vrd2EGGtz65OtpprNJHxhD = other.__if_Vrd2EGGtz65OtpprNJHxhD;
            this.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = other.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt;
            this.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = other.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LVNuL4zWru8QVE6nHn5Iu9", in __slot_LVNuL4zWru8QVE6nHn5Iu9), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NVN9iDxKSjtNtXuZnjk03F", in __slot_NVN9iDxKSjtNtXuZnjk03F), n1.CompilationHelper.GetValueOrExisting(values, "__if_Vrd2EGGtz65OtpprNJHxhD", in __if_Vrd2EGGtz65OtpprNJHxhD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt", in __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5", in __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5));
        }

        internal DrawTranslate_BbwjpL9scQpQVX3veRGirk __WITH__(n6.Spread<n5.Vector2> __slot_LVNuL4zWru8QVE6nHn5Iu9, n6.Spread<n5.Vector2> __slot_NVN9iDxKSjtNtXuZnjk03F, n2.Object __if_Vrd2EGGtz65OtpprNJHxhD, n6.Spread<n5.Vector2> __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt, n6.Spread<n5.Vector2> __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5)
        {
            n10.DrawTranslate_BbwjpL9scQpQVX3veRGirk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_LVNuL4zWru8QVE6nHn5Iu9 != this.__slot_LVNuL4zWru8QVE6nHn5Iu9 || __slot_NVN9iDxKSjtNtXuZnjk03F != this.__slot_NVN9iDxKSjtNtXuZnjk03F || __if_Vrd2EGGtz65OtpprNJHxhD != this.__if_Vrd2EGGtz65OtpprNJHxhD || __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt != this.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt || __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 != this.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 ? new DrawTranslate_BbwjpL9scQpQVX3veRGirk(this)
                {__slot_LVNuL4zWru8QVE6nHn5Iu9 = __slot_LVNuL4zWru8QVE6nHn5Iu9, __slot_NVN9iDxKSjtNtXuZnjk03F = __slot_NVN9iDxKSjtNtXuZnjk03F, __if_Vrd2EGGtz65OtpprNJHxhD = __if_Vrd2EGGtz65OtpprNJHxhD, __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt, __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5} : that_0;
            else
            {
                this.__slot_LVNuL4zWru8QVE6nHn5Iu9 = __slot_LVNuL4zWru8QVE6nHn5Iu9;
                this.__slot_NVN9iDxKSjtNtXuZnjk03F = __slot_NVN9iDxKSjtNtXuZnjk03F;
                this.__if_Vrd2EGGtz65OtpprNJHxhD = __if_Vrd2EGGtz65OtpprNJHxhD;
                this.__pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt = __pin_group_Input_In_P4eWn6v61kZQQ4cayPRVBt;
                this.__pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5 = __pin_group_Input_In_JVtEmjzwCm7MWDC2UAvGr5;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ROgxspAdeiiPZ5bt4Neu9j", Name = "__ROgxspAdeiiPZ5bt4Neu9j")]
        [n2.SerializableAttribute]
        public class __ROgxspAdeiiPZ5bt4Neu9j : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HzUnIvkrmE0P34JtAkmtI9);
                n1.CompilationHelper.SafeDispose(this.__loop_R1pJcu4n9BKP9e62rMFilO);
                return;
            }

            [n1.ElementAttribute(TracingId = 103783U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HzUnIvkrmE0P34JtAkmtI9", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_HzUnIvkrmE0P34JtAkmtI9;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n31.ImmutableLifetimeManager __loop_R1pJcu4n9BKP9e62rMFilO;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __cp_BLDaspvykCAP5nxT3FzKGr;
            public __ROgxspAdeiiPZ5bt4Neu9j(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ROgxspAdeiiPZ5bt4Neu9j(__ROgxspAdeiiPZ5bt4Neu9j other): base(other)
            {
                this.__p_HzUnIvkrmE0P34JtAkmtI9 = other.__p_HzUnIvkrmE0P34JtAkmtI9;
                this.__loop_R1pJcu4n9BKP9e62rMFilO = other.__loop_R1pJcu4n9BKP9e62rMFilO;
                this.__cp_BLDaspvykCAP5nxT3FzKGr = other.__cp_BLDaspvykCAP5nxT3FzKGr;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HzUnIvkrmE0P34JtAkmtI9", in __p_HzUnIvkrmE0P34JtAkmtI9), n1.CompilationHelper.GetValueOrExisting(values, "__loop_R1pJcu4n9BKP9e62rMFilO", in __loop_R1pJcu4n9BKP9e62rMFilO), n1.CompilationHelper.GetValueOrExisting(values, "__cp_BLDaspvykCAP5nxT3FzKGr", in __cp_BLDaspvykCAP5nxT3FzKGr));
            }

            internal __ROgxspAdeiiPZ5bt4Neu9j __WITH__(n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_HzUnIvkrmE0P34JtAkmtI9, n31.ImmutableLifetimeManager __loop_R1pJcu4n9BKP9e62rMFilO, n6.Spread<n8.ILayer> __cp_BLDaspvykCAP5nxT3FzKGr)
            {
                __ROgxspAdeiiPZ5bt4Neu9j that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HzUnIvkrmE0P34JtAkmtI9 != this.__p_HzUnIvkrmE0P34JtAkmtI9 || __loop_R1pJcu4n9BKP9e62rMFilO != this.__loop_R1pJcu4n9BKP9e62rMFilO || __cp_BLDaspvykCAP5nxT3FzKGr != this.__cp_BLDaspvykCAP5nxT3FzKGr ? new __ROgxspAdeiiPZ5bt4Neu9j(this)
                    {__p_HzUnIvkrmE0P34JtAkmtI9 = __p_HzUnIvkrmE0P34JtAkmtI9, __loop_R1pJcu4n9BKP9e62rMFilO = __loop_R1pJcu4n9BKP9e62rMFilO, __cp_BLDaspvykCAP5nxT3FzKGr = __cp_BLDaspvykCAP5nxT3FzKGr} : that_0;
                else
                {
                    this.__p_HzUnIvkrmE0P34JtAkmtI9 = __p_HzUnIvkrmE0P34JtAkmtI9;
                    this.__loop_R1pJcu4n9BKP9e62rMFilO = __loop_R1pJcu4n9BKP9e62rMFilO;
                    this.__cp_BLDaspvykCAP5nxT3FzKGr = __cp_BLDaspvykCAP5nxT3FzKGr;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "LFQCsSI9GswPsw84n4lyRR", Name = "__LFQCsSI9GswPsw84n4lyRR")]
        [n2.SerializableAttribute]
        public class __LFQCsSI9GswPsw84n4lyRR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Ht6XncgVQpFMcE90UFPD51);
                n1.CompilationHelper.SafeDispose(this.__p_SeVe943CUFaOg1zNVkeIHY);
                n1.CompilationHelper.SafeDispose(this.__p_DC7SPAUVI0yNeXgTMQ8TF6);
                return;
            }

            [n1.ElementAttribute(TracingId = 103742U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Ht6XncgVQpFMcE90UFPD51", Name = "Arrow", IsManaged = true, IsAutoGenerated = true)]
            public n18.Arrow_LkmkJWVjwT1N0iaFX8x0DS __p_Ht6XncgVQpFMcE90UFPD51;
            [n1.ElementAttribute(TracingId = 103751U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "SeVe943CUFaOg1zNVkeIHY", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_SeVe943CUFaOg1zNVkeIHY;
            [n1.ElementAttribute(TracingId = 103755U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "DC7SPAUVI0yNeXgTMQ8TF6", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_DC7SPAUVI0yNeXgTMQ8TF6;
            public __LFQCsSI9GswPsw84n4lyRR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LFQCsSI9GswPsw84n4lyRR(__LFQCsSI9GswPsw84n4lyRR other): base(other)
            {
                this.__p_Ht6XncgVQpFMcE90UFPD51 = other.__p_Ht6XncgVQpFMcE90UFPD51;
                this.__p_SeVe943CUFaOg1zNVkeIHY = other.__p_SeVe943CUFaOg1zNVkeIHY;
                this.__p_DC7SPAUVI0yNeXgTMQ8TF6 = other.__p_DC7SPAUVI0yNeXgTMQ8TF6;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ht6XncgVQpFMcE90UFPD51", in __p_Ht6XncgVQpFMcE90UFPD51), n1.CompilationHelper.GetValueOrExisting(values, "__p_SeVe943CUFaOg1zNVkeIHY", in __p_SeVe943CUFaOg1zNVkeIHY), n1.CompilationHelper.GetValueOrExisting(values, "__p_DC7SPAUVI0yNeXgTMQ8TF6", in __p_DC7SPAUVI0yNeXgTMQ8TF6));
            }

            internal __LFQCsSI9GswPsw84n4lyRR __WITH__(n18.Arrow_LkmkJWVjwT1N0iaFX8x0DS __p_Ht6XncgVQpFMcE90UFPD51, n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_SeVe943CUFaOg1zNVkeIHY, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_DC7SPAUVI0yNeXgTMQ8TF6)
            {
                __LFQCsSI9GswPsw84n4lyRR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Ht6XncgVQpFMcE90UFPD51 != this.__p_Ht6XncgVQpFMcE90UFPD51 || __p_SeVe943CUFaOg1zNVkeIHY != this.__p_SeVe943CUFaOg1zNVkeIHY || __p_DC7SPAUVI0yNeXgTMQ8TF6 != this.__p_DC7SPAUVI0yNeXgTMQ8TF6 ? new __LFQCsSI9GswPsw84n4lyRR(this)
                    {__p_Ht6XncgVQpFMcE90UFPD51 = __p_Ht6XncgVQpFMcE90UFPD51, __p_SeVe943CUFaOg1zNVkeIHY = __p_SeVe943CUFaOg1zNVkeIHY, __p_DC7SPAUVI0yNeXgTMQ8TF6 = __p_DC7SPAUVI0yNeXgTMQ8TF6} : that_0;
                else
                {
                    this.__p_Ht6XncgVQpFMcE90UFPD51 = __p_Ht6XncgVQpFMcE90UFPD51;
                    this.__p_SeVe943CUFaOg1zNVkeIHY = __p_SeVe943CUFaOg1zNVkeIHY;
                    this.__p_DC7SPAUVI0yNeXgTMQ8TF6 = __p_DC7SPAUVI0yNeXgTMQ8TF6;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103876U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PF3URITGWsDOB0U4CpD2cm", Name = "DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm")]
    [n2.SerializableAttribute]
    public class DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm CreateDefault()
        {
            var instance = new DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm Update(n5.Vector2 Position_In, n7.IEnumerable<n5.Color4> Colors_In, n7.IEnumerable<float> Active_Axis_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n6.Spread<n5.Vector2> __pad_GjYPH9GiNEqPeGearIH763_0 = this.__slot_GjYPH9GiNEqPeGearIH763;
            n6.Spread<n5.Vector2> __pad_PHsCtKYoF5rLypjpfKFCIT_1 = this.__slot_PHsCtKYoF5rLypjpfKFCIT;
            n8.ILayer __auto_2;
            var state_3 = n1.CompilationHelper.Restore<__NBN2YqPhkZHLlFQh2lZBUN>(this.__if_UeJhPhiHRUlOVSVidVMkTj, __GetContext__());
            if (Enabled_In)
            {
                if (state_3 == null)
                {
                    state_3 = new __NBN2YqPhkZHLlFQh2lZBUN(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_LJFpy4gAE6uLsts1fgxYYT = n23._Operations_.CreateDefault<n8.ILayer>()};
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "QPGZQhYYsSaOZY1Y8tlkzp", 103934U);
                    var Output_5 = n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g.Create(Node_Context: Node_Context_4);
                    state_3.__p_QPGZQhYYsSaOZY1Y8tlkzp = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "KHwsoZeOsmZPNAOJcLZMO9", 103939U);
                    var Output_7 = n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_6);
                    state_3.__p_KHwsoZeOsmZPNAOJcLZMO9 = Output_7;
                }

                var enumerator_8 = n4.CollectionExtensions.AsSpan(__pad_GjYPH9GiNEqPeGearIH763_0).GetEnumerator();
                var enumerator_10 = n4.CollectionExtensions.AsSpan(__pad_PHsCtKYoF5rLypjpfKFCIT_1).GetEnumerator();
                var enumerator_12 = Colors_In.GetEnumerator();
                var enumerator_14 = Active_Axis_In.GetEnumerator();
                var manager_34 = state_3.__loop_MUxTTajyJOdLHLRozMIb68 ?? new n31.ImmutableLifetimeManager();
                var iterator_35 = manager_34.GetIterator(__GetContext__());
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_3.__cp_LJFpy4gAE6uLsts1fgxYYT, 16);
                n6.Spread<n8.ILayer> output_37;
                try
                {
                    var i_16 = 0;
                    while (enumerator_8.MoveNext() && enumerator_10.MoveNext() && enumerator_12.MoveNext() && enumerator_14.MoveNext())
                    {
                        var splicer_9 = enumerator_8.Current;
                        var splicer_11 = enumerator_10.Current;
                        var splicer_13 = enumerator_12.Current;
                        var splicer_15 = enumerator_14.Current;
                        var i_local_17 = i_16;
                        __FjuIZw67zi4MFt18u3ON2x state_18;
                        if (!iterator_35.MoveNext(out state_18))
                        {
                            iterator_35.Add(state_18 = new __FjuIZw67zi4MFt18u3ON2x(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "MbOcRe0YeoiOcJXVrGz19P", 103909U);
                            var Output_20 = n18.Line_C.Create(Node_Context: Node_Context_19);
                            state_18.__p_MbOcRe0YeoiOcJXVrGz19P = Output_20;
                            n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Vn9XKMqGHZmMst5I3Qd1rC", 103919U);
                            var Output_22 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_21);
                            state_18.__p_Vn9XKMqGHZmMst5I3Qd1rC = Output_22;
                        }

                        float __pad_UGFbYbNzZOvQVwvc3zzKvH_23 = __slot_UGFbYbNzZOvQVwvc3zzKvH;
                        float __pad_OVQluJ2ggOnMm0dCC577cj_24 = __slot_OVQluJ2ggOnMm0dCC577cj;
                        n9.SkiaPaint_R Input_25 = n9.SkiaPaint_R.CreateDefault();
                        n13.SKStrokeJoin Join_26 = __c_TalLdoO1o8gQTCGYCJ9nGe;
                        n13.SKStrokeCap Cap_27 = __c_FON3jKfPE83NufMfsyKuEP;
                        float Miter_28 = 0F;
                        var State_Output_30 = state_18.__p_Vn9XKMqGHZmMst5I3Qd1rC.Update(Input_In: Input_25, Color_In: splicer_13, Stroke_Width_In: __pad_OVQluJ2ggOnMm0dCC577cj_24, Join_In: Join_26, Cap_In: Cap_27, Miter_In: Miter_28, Output_Out: out n9.SkiaPaint_R Output_29);
                        var Result_31 = splicer_15 > __pad_UGFbYbNzZOvQVwvc3zzKvH_23;
                        var State_Output_33 = state_18.__p_MbOcRe0YeoiOcJXVrGz19P.Update(Point_A_In: splicer_9, Point_B_In: splicer_11, Paint_In: Output_29, Enabled_In: Result_31, Output_Out: out n8.ILayer Output_32);
                        if (state_18.__GetContext__().IsImmutable)
                            state_18 = State_Output_30 != state_18.__p_Vn9XKMqGHZmMst5I3Qd1rC || State_Output_33 != state_18.__p_MbOcRe0YeoiOcJXVrGz19P ? new __FjuIZw67zi4MFt18u3ON2x(state_18)
                            {__p_Vn9XKMqGHZmMst5I3Qd1rC = State_Output_30, __p_MbOcRe0YeoiOcJXVrGz19P = State_Output_33} : state_18;
                        else
                        {
                            state_18.__p_Vn9XKMqGHZmMst5I3Qd1rC = State_Output_30;
                            state_18.__p_MbOcRe0YeoiOcJXVrGz19P = State_Output_33;
                        }

                        iterator_35.Update(state_18);
                        builder_36.Add(Output_32);
                        i_16++;
                    }
                }
                finally
                {
                    enumerator_12.Dispose();
                    enumerator_14.Dispose();
                    manager_34 = iterator_35.Commit();
                    output_37 = builder_36.Commit();
                }

                n7.IEnumerable<n8.ILayer> Input_38 = (n7.IEnumerable<n8.ILayer>)output_37;
                bool Debug_39 = false;
                bool Enabled_40 = true;
                var State_Output_42 = state_3.__p_QPGZQhYYsSaOZY1Y8tlkzp.Update(Input_In: Input_38, Debug_In: Debug_39, Enabled_In: Enabled_40, Output_Out: out n8.ILayer Output_41);
                n5.Matrix Input_43 = n24._Operations_.CreateDefault();
                n32._Operations_.Translate(Input_In: Input_43, Translation_In: Position_In, Output_Out: out n5.Matrix Output_44);
                var State_Output_46 = state_3.__p_KHwsoZeOsmZPNAOJcLZMO9.Update(Input_In: Output_41, Transformation_In: Output_44, Output_Out: out n8.ILayer Output_45);
                __auto_2 = Output_45;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_34 != state_3.__loop_MUxTTajyJOdLHLRozMIb68 || output_37 != state_3.__cp_LJFpy4gAE6uLsts1fgxYYT || State_Output_42 != state_3.__p_QPGZQhYYsSaOZY1Y8tlkzp || State_Output_46 != state_3.__p_KHwsoZeOsmZPNAOJcLZMO9 ? new __NBN2YqPhkZHLlFQh2lZBUN(state_3)
                    {__loop_MUxTTajyJOdLHLRozMIb68 = manager_34, __cp_LJFpy4gAE6uLsts1fgxYYT = output_37, __p_QPGZQhYYsSaOZY1Y8tlkzp = State_Output_42, __p_KHwsoZeOsmZPNAOJcLZMO9 = State_Output_46} : state_3;
                else
                {
                    state_3.__loop_MUxTTajyJOdLHLRozMIb68 = manager_34;
                    state_3.__cp_LJFpy4gAE6uLsts1fgxYYT = output_37;
                    state_3.__p_QPGZQhYYsSaOZY1Y8tlkzp = State_Output_42;
                    state_3.__p_KHwsoZeOsmZPNAOJcLZMO9 = State_Output_46;
                }
            }
            else
            {
                __auto_2 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_2;
            n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm that_47 = this;
            if (this.__GetContext__().IsImmutable)
                that_47 = state_3 != this.__if_UeJhPhiHRUlOVSVidVMkTj ? new DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(this)
                {__if_UeJhPhiHRUlOVSVidVMkTj = state_3} : that_47;
            else
            {
                this.__if_UeJhPhiHRUlOVSVidVMkTj = state_3;
            }

            return that_47;
        }

        public n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.Vector2 __pad_MeQ6TZUfuK7Nk1dLtaHoYl_0 = __slot_MeQ6TZUfuK7Nk1dLtaHoYl;
            n5.Vector2 __pad_FlcO4a41B4aLQuKr38UA2n_1 = __slot_FlcO4a41B4aLQuKr38UA2n;
            n5.Vector2 __pad_CeyoGjNFdENMIopeuDgN9Y_2 = __slot_CeyoGjNFdENMIopeuDgN9Y;
            n5.Vector2 __pad_Bn213cddJ71MMQoGRgiSDl_3 = __slot_Bn213cddJ71MMQoGRgiSDl;
            var builder_4 = n4.CollectionBuilders.GetBuilder(n23._Operations_.CreateDefault<n5.Vector2>(), 2);
            builder_4.Add(__pad_MeQ6TZUfuK7Nk1dLtaHoYl_0);
            builder_4.Add(__pad_FlcO4a41B4aLQuKr38UA2n_1);
            var __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs_5 = builder_4.Commit();
            n23._Operations_.Cons<n5.Vector2>(Input_In: __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs_5, Result_Out: out n6.Spread<n5.Vector2> Result_6);
            n6.Spread<n5.Vector2> __pad_GjYPH9GiNEqPeGearIH763_7 = Result_6;
            var builder_8 = n4.CollectionBuilders.GetBuilder(n23._Operations_.CreateDefault<n5.Vector2>(), 2);
            builder_8.Add(__pad_CeyoGjNFdENMIopeuDgN9Y_2);
            builder_8.Add(__pad_Bn213cddJ71MMQoGRgiSDl_3);
            var __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW_9 = builder_8.Commit();
            n23._Operations_.Cons<n5.Vector2>(Input_In: __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW_9, Result_Out: out n6.Spread<n5.Vector2> Result_10);
            n6.Spread<n5.Vector2> __pad_PHsCtKYoF5rLypjpfKFCIT_11 = Result_10;
            n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm that_12 = this;
            this.__slot_GjYPH9GiNEqPeGearIH763 = Result_6;
            this.__slot_PHsCtKYoF5rLypjpfKFCIT = Result_10;
            this.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs_5;
            this.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW_9;
            this.__if_UeJhPhiHRUlOVSVidVMkTj = default(n2.Object);
            return that_12;
        }

        public n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm __CreateDefault__()
        {
            n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm that_0 = this;
            this.__slot_GjYPH9GiNEqPeGearIH763 = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__slot_PHsCtKYoF5rLypjpfKFCIT = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = n23._Operations_.CreateDefault<n5.Vector2>();
            this.__if_UeJhPhiHRUlOVSVidVMkTj = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_UeJhPhiHRUlOVSVidVMkTj);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 103888U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MeQ6TZUfuK7Nk1dLtaHoYl", Name = "__slot_MeQ6TZUfuK7Nk1dLtaHoYl")]
        public static n5.Vector2 __slot_MeQ6TZUfuK7Nk1dLtaHoYl = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "MeQ6TZUfuK7Nk1dLtaHoYl");
        [n1.ElementAttribute(TracingId = 103889U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "CeyoGjNFdENMIopeuDgN9Y", Name = "__slot_CeyoGjNFdENMIopeuDgN9Y")]
        public static n5.Vector2 __slot_CeyoGjNFdENMIopeuDgN9Y = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "CeyoGjNFdENMIopeuDgN9Y");
        [n1.ElementAttribute(TracingId = 103890U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FlcO4a41B4aLQuKr38UA2n", Name = "__slot_FlcO4a41B4aLQuKr38UA2n")]
        public static n5.Vector2 __slot_FlcO4a41B4aLQuKr38UA2n = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "FlcO4a41B4aLQuKr38UA2n");
        [n1.ElementAttribute(TracingId = 103891U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Bn213cddJ71MMQoGRgiSDl", Name = "__slot_Bn213cddJ71MMQoGRgiSDl")]
        public static n5.Vector2 __slot_Bn213cddJ71MMQoGRgiSDl = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "Bn213cddJ71MMQoGRgiSDl");
        [n1.ElementAttribute(TracingId = 103894U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "GjYPH9GiNEqPeGearIH763", Name = "__slot_GjYPH9GiNEqPeGearIH763")]
        public n6.Spread<n5.Vector2> __slot_GjYPH9GiNEqPeGearIH763;
        [n1.ElementAttribute(TracingId = 103895U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "PHsCtKYoF5rLypjpfKFCIT", Name = "__slot_PHsCtKYoF5rLypjpfKFCIT")]
        public n6.Spread<n5.Vector2> __slot_PHsCtKYoF5rLypjpfKFCIT;
        [n1.ElementAttribute(TracingId = 103927U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UGFbYbNzZOvQVwvc3zzKvH", Name = "__slot_UGFbYbNzZOvQVwvc3zzKvH")]
        public static float __slot_UGFbYbNzZOvQVwvc3zzKvH = 0.5F;
        [n1.ElementAttribute(TracingId = 103928U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "OVQluJ2ggOnMm0dCC577cj", Name = "__slot_OVQluJ2ggOnMm0dCC577cj")]
        public static float __slot_OVQluJ2ggOnMm0dCC577cj = 0F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_TalLdoO1o8gQTCGYCJ9nGe = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "TalLdoO1o8gQTCGYCJ9nGe");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_FON3jKfPE83NufMfsyKuEP = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "FON3jKfPE83NufMfsyKuEP");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_UeJhPhiHRUlOVSVidVMkTj;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Vector2> __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = default(n6.Spread<n5.Vector2>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n6.Spread<n5.Vector2> __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = default(n6.Spread<n5.Vector2>);
        static DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm()
        {
        }

        public DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm other): base(other)
        {
            this.__slot_GjYPH9GiNEqPeGearIH763 = other.__slot_GjYPH9GiNEqPeGearIH763;
            this.__slot_PHsCtKYoF5rLypjpfKFCIT = other.__slot_PHsCtKYoF5rLypjpfKFCIT;
            this.__if_UeJhPhiHRUlOVSVidVMkTj = other.__if_UeJhPhiHRUlOVSVidVMkTj;
            this.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = other.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs;
            this.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = other.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_GjYPH9GiNEqPeGearIH763", in __slot_GjYPH9GiNEqPeGearIH763), n1.CompilationHelper.GetValueOrExisting(values, "__slot_PHsCtKYoF5rLypjpfKFCIT", in __slot_PHsCtKYoF5rLypjpfKFCIT), n1.CompilationHelper.GetValueOrExisting(values, "__if_UeJhPhiHRUlOVSVidVMkTj", in __if_UeJhPhiHRUlOVSVidVMkTj), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs", in __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW", in __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW));
        }

        internal DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm __WITH__(n6.Spread<n5.Vector2> __slot_GjYPH9GiNEqPeGearIH763, n6.Spread<n5.Vector2> __slot_PHsCtKYoF5rLypjpfKFCIT, n2.Object __if_UeJhPhiHRUlOVSVidVMkTj, n6.Spread<n5.Vector2> __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs, n6.Spread<n5.Vector2> __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW)
        {
            n10.DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_GjYPH9GiNEqPeGearIH763 != this.__slot_GjYPH9GiNEqPeGearIH763 || __slot_PHsCtKYoF5rLypjpfKFCIT != this.__slot_PHsCtKYoF5rLypjpfKFCIT || __if_UeJhPhiHRUlOVSVidVMkTj != this.__if_UeJhPhiHRUlOVSVidVMkTj || __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs != this.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs || __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW != this.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW ? new DrawActiveAxis_PF3URITGWsDOB0U4CpD2cm(this)
                {__slot_GjYPH9GiNEqPeGearIH763 = __slot_GjYPH9GiNEqPeGearIH763, __slot_PHsCtKYoF5rLypjpfKFCIT = __slot_PHsCtKYoF5rLypjpfKFCIT, __if_UeJhPhiHRUlOVSVidVMkTj = __if_UeJhPhiHRUlOVSVidVMkTj, __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs, __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW} : that_0;
            else
            {
                this.__slot_GjYPH9GiNEqPeGearIH763 = __slot_GjYPH9GiNEqPeGearIH763;
                this.__slot_PHsCtKYoF5rLypjpfKFCIT = __slot_PHsCtKYoF5rLypjpfKFCIT;
                this.__if_UeJhPhiHRUlOVSVidVMkTj = __if_UeJhPhiHRUlOVSVidVMkTj;
                this.__pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs = __pin_group_Input_In_QRBkfktm5CBP6PcQ8dTSWs;
                this.__pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW = __pin_group_Input_In_SuoFj4JKxpULPUYNdkDgEW;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NBN2YqPhkZHLlFQh2lZBUN", Name = "__NBN2YqPhkZHLlFQh2lZBUN")]
        [n2.SerializableAttribute]
        public class __NBN2YqPhkZHLlFQh2lZBUN : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QPGZQhYYsSaOZY1Y8tlkzp);
                n1.CompilationHelper.SafeDispose(this.__p_KHwsoZeOsmZPNAOJcLZMO9);
                n1.CompilationHelper.SafeDispose(this.__loop_MUxTTajyJOdLHLRozMIb68);
                return;
            }

            [n1.ElementAttribute(TracingId = 103934U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "QPGZQhYYsSaOZY1Y8tlkzp", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
            public n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_QPGZQhYYsSaOZY1Y8tlkzp;
            [n1.ElementAttribute(TracingId = 103939U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "KHwsoZeOsmZPNAOJcLZMO9", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_KHwsoZeOsmZPNAOJcLZMO9;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n31.ImmutableLifetimeManager __loop_MUxTTajyJOdLHLRozMIb68;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n6.Spread<n8.ILayer> __cp_LJFpy4gAE6uLsts1fgxYYT;
            public __NBN2YqPhkZHLlFQh2lZBUN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NBN2YqPhkZHLlFQh2lZBUN(__NBN2YqPhkZHLlFQh2lZBUN other): base(other)
            {
                this.__p_QPGZQhYYsSaOZY1Y8tlkzp = other.__p_QPGZQhYYsSaOZY1Y8tlkzp;
                this.__p_KHwsoZeOsmZPNAOJcLZMO9 = other.__p_KHwsoZeOsmZPNAOJcLZMO9;
                this.__loop_MUxTTajyJOdLHLRozMIb68 = other.__loop_MUxTTajyJOdLHLRozMIb68;
                this.__cp_LJFpy4gAE6uLsts1fgxYYT = other.__cp_LJFpy4gAE6uLsts1fgxYYT;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QPGZQhYYsSaOZY1Y8tlkzp", in __p_QPGZQhYYsSaOZY1Y8tlkzp), n1.CompilationHelper.GetValueOrExisting(values, "__p_KHwsoZeOsmZPNAOJcLZMO9", in __p_KHwsoZeOsmZPNAOJcLZMO9), n1.CompilationHelper.GetValueOrExisting(values, "__loop_MUxTTajyJOdLHLRozMIb68", in __loop_MUxTTajyJOdLHLRozMIb68), n1.CompilationHelper.GetValueOrExisting(values, "__cp_LJFpy4gAE6uLsts1fgxYYT", in __cp_LJFpy4gAE6uLsts1fgxYYT));
            }

            internal __NBN2YqPhkZHLlFQh2lZBUN __WITH__(n9.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_QPGZQhYYsSaOZY1Y8tlkzp, n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_KHwsoZeOsmZPNAOJcLZMO9, n31.ImmutableLifetimeManager __loop_MUxTTajyJOdLHLRozMIb68, n6.Spread<n8.ILayer> __cp_LJFpy4gAE6uLsts1fgxYYT)
            {
                __NBN2YqPhkZHLlFQh2lZBUN that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QPGZQhYYsSaOZY1Y8tlkzp != this.__p_QPGZQhYYsSaOZY1Y8tlkzp || __p_KHwsoZeOsmZPNAOJcLZMO9 != this.__p_KHwsoZeOsmZPNAOJcLZMO9 || __loop_MUxTTajyJOdLHLRozMIb68 != this.__loop_MUxTTajyJOdLHLRozMIb68 || __cp_LJFpy4gAE6uLsts1fgxYYT != this.__cp_LJFpy4gAE6uLsts1fgxYYT ? new __NBN2YqPhkZHLlFQh2lZBUN(this)
                    {__p_QPGZQhYYsSaOZY1Y8tlkzp = __p_QPGZQhYYsSaOZY1Y8tlkzp, __p_KHwsoZeOsmZPNAOJcLZMO9 = __p_KHwsoZeOsmZPNAOJcLZMO9, __loop_MUxTTajyJOdLHLRozMIb68 = __loop_MUxTTajyJOdLHLRozMIb68, __cp_LJFpy4gAE6uLsts1fgxYYT = __cp_LJFpy4gAE6uLsts1fgxYYT} : that_0;
                else
                {
                    this.__p_QPGZQhYYsSaOZY1Y8tlkzp = __p_QPGZQhYYsSaOZY1Y8tlkzp;
                    this.__p_KHwsoZeOsmZPNAOJcLZMO9 = __p_KHwsoZeOsmZPNAOJcLZMO9;
                    this.__loop_MUxTTajyJOdLHLRozMIb68 = __loop_MUxTTajyJOdLHLRozMIb68;
                    this.__cp_LJFpy4gAE6uLsts1fgxYYT = __cp_LJFpy4gAE6uLsts1fgxYYT;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FjuIZw67zi4MFt18u3ON2x", Name = "__FjuIZw67zi4MFt18u3ON2x")]
        [n2.SerializableAttribute]
        public class __FjuIZw67zi4MFt18u3ON2x : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MbOcRe0YeoiOcJXVrGz19P);
                n1.CompilationHelper.SafeDispose(this.__p_Vn9XKMqGHZmMst5I3Qd1rC);
                return;
            }

            [n1.ElementAttribute(TracingId = 103909U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MbOcRe0YeoiOcJXVrGz19P", Name = "Line", IsManaged = true, IsAutoGenerated = true)]
            public n18.Line_C __p_MbOcRe0YeoiOcJXVrGz19P;
            [n1.ElementAttribute(TracingId = 103919U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Vn9XKMqGHZmMst5I3Qd1rC", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_Vn9XKMqGHZmMst5I3Qd1rC;
            public __FjuIZw67zi4MFt18u3ON2x(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FjuIZw67zi4MFt18u3ON2x(__FjuIZw67zi4MFt18u3ON2x other): base(other)
            {
                this.__p_MbOcRe0YeoiOcJXVrGz19P = other.__p_MbOcRe0YeoiOcJXVrGz19P;
                this.__p_Vn9XKMqGHZmMst5I3Qd1rC = other.__p_Vn9XKMqGHZmMst5I3Qd1rC;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MbOcRe0YeoiOcJXVrGz19P", in __p_MbOcRe0YeoiOcJXVrGz19P), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vn9XKMqGHZmMst5I3Qd1rC", in __p_Vn9XKMqGHZmMst5I3Qd1rC));
            }

            internal __FjuIZw67zi4MFt18u3ON2x __WITH__(n18.Line_C __p_MbOcRe0YeoiOcJXVrGz19P, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_Vn9XKMqGHZmMst5I3Qd1rC)
            {
                __FjuIZw67zi4MFt18u3ON2x that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MbOcRe0YeoiOcJXVrGz19P != this.__p_MbOcRe0YeoiOcJXVrGz19P || __p_Vn9XKMqGHZmMst5I3Qd1rC != this.__p_Vn9XKMqGHZmMst5I3Qd1rC ? new __FjuIZw67zi4MFt18u3ON2x(this)
                    {__p_MbOcRe0YeoiOcJXVrGz19P = __p_MbOcRe0YeoiOcJXVrGz19P, __p_Vn9XKMqGHZmMst5I3Qd1rC = __p_Vn9XKMqGHZmMst5I3Qd1rC} : that_0;
                else
                {
                    this.__p_MbOcRe0YeoiOcJXVrGz19P = __p_MbOcRe0YeoiOcJXVrGz19P;
                    this.__p_Vn9XKMqGHZmMst5I3Qd1rC = __p_Vn9XKMqGHZmMst5I3Qd1rC;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103991U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HjhhS7ycrwZMLPltie7ifj", Name = "DrawRotation_HjhhS7ycrwZMLPltie7ifj")]
    [n2.SerializableAttribute]
    public class DrawRotation_HjhhS7ycrwZMLPltie7ifj : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawRotation_HjhhS7ycrwZMLPltie7ifj(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj CreateDefault()
        {
            var instance = new DrawRotation_HjhhS7ycrwZMLPltie7ifj(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj Update(n5.Matrix Transformation_In, n5.Color4 Color_In, float Is_Active_In, bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__EVDcxolCHsBO1rH4XVhfE2>(this.__if_OBQG3pjamwKNHnPfZzkemQ, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __EVDcxolCHsBO1rH4XVhfE2(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "ETRhTs3UQGKNkjW9cCDems", 104002U);
                    var Output_3 = n18.Circle_PkBNwasMVJjOdYsVSPoZ1g.Create(Node_Context: Node_Context_2);
                    state_1.__p_ETRhTs3UQGKNkjW9cCDems = Output_3;
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "TCtmccPFUsLMzqFzkaxz0A", 104009U);
                    var Output_5 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_4);
                    state_1.__p_TCtmccPFUsLMzqFzkaxz0A = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "NDUUDP9TIhSLA62KkkTaBQ", 104018U);
                    var Output_7 = n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_6);
                    state_1.__p_NDUUDP9TIhSLA62KkkTaBQ = Output_7;
                }

                float __pad_TD74bdr2OQMOll8frAmdrh_8 = __slot_TD74bdr2OQMOll8frAmdrh;
                n5.Vector2 __pad_VVm8kcL1E4dMiw4ELuItU6_9 = __slot_VVm8kcL1E4dMiw4ELuItU6;
                n10._Operations_.Highlight(Input_In: Color_In, Is_Active_In: Is_Active_In, Output_Out: out n5.Color4 Output_10);
                n9.SkiaPaint_R Input_11 = n9.SkiaPaint_R.CreateDefault();
                n13.SKStrokeJoin Join_12 = __c_Kd7HmtfLhX2LXdIEdtdfJ1;
                n13.SKStrokeCap Cap_13 = __c_QYIpB9VWSFJOBgeHFwXQEG;
                float Miter_14 = 0F;
                var State_Output_16 = state_1.__p_TCtmccPFUsLMzqFzkaxz0A.Update(Input_In: Input_11, Color_In: Output_10, Stroke_Width_In: __pad_TD74bdr2OQMOll8frAmdrh_8, Join_In: Join_12, Cap_In: Cap_13, Miter_In: Miter_14, Output_Out: out n9.SkiaPaint_R Output_15);
                n5.Vector2 Position_17 = __c_N7XLsqvPRFdNIJa34dv2Sr;
                float Radius_18 = 0.5F;
                n20.RectangleAnchor Anchor_19 = __c_DphB9BT1hbMMlRyMqxMuZM;
                bool Enabled_20 = true;
                var State_Output_22 = state_1.__p_ETRhTs3UQGKNkjW9cCDems.Update(Position_In: Position_17, Radius_In: Radius_18, Anchor_In: Anchor_19, Paint_In: Output_15, Enabled_In: Enabled_20, Output_Out: out n8.ILayer Output_21);
                n5.Vector2.TransformCoordinate(coordinate: ref __pad_VVm8kcL1E4dMiw4ELuItU6_9, transform: ref Transformation_In, result: out n5.Vector2 Output_23);
                n5.Matrix Input_24 = n24._Operations_.CreateDefault();
                n32._Operations_.Translate(Input_In: Input_24, Translation_In: Output_23, Output_Out: out n5.Matrix Output_25);
                var State_Output_27 = state_1.__p_NDUUDP9TIhSLA62KkkTaBQ.Update(Input_In: Output_21, Transformation_In: Output_25, Output_Out: out n8.ILayer Output_26);
                __auto_0 = Output_26;
                n5.Vector3 Translation_28 = n26._Operations_.CreateDefault();
                n5.Matrix.Translation(value: ref Translation_28, result: out n5.Matrix Result_29);
                n32._Operations_.Translate(Input_In: Transformation_In, Translation_In: __pad_VVm8kcL1E4dMiw4ELuItU6_9, Output_Out: out n5.Matrix Output_30);
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = State_Output_16 != state_1.__p_TCtmccPFUsLMzqFzkaxz0A || State_Output_22 != state_1.__p_ETRhTs3UQGKNkjW9cCDems || State_Output_27 != state_1.__p_NDUUDP9TIhSLA62KkkTaBQ ? new __EVDcxolCHsBO1rH4XVhfE2(state_1)
                    {__p_TCtmccPFUsLMzqFzkaxz0A = State_Output_16, __p_ETRhTs3UQGKNkjW9cCDems = State_Output_22, __p_NDUUDP9TIhSLA62KkkTaBQ = State_Output_27} : state_1;
                else
                {
                    state_1.__p_TCtmccPFUsLMzqFzkaxz0A = State_Output_16;
                    state_1.__p_ETRhTs3UQGKNkjW9cCDems = State_Output_22;
                    state_1.__p_NDUUDP9TIhSLA62KkkTaBQ = State_Output_27;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = state_1 != this.__if_OBQG3pjamwKNHnPfZzkemQ ? new DrawRotation_HjhhS7ycrwZMLPltie7ifj(this)
                {__if_OBQG3pjamwKNHnPfZzkemQ = state_1} : that_31;
            else
            {
                this.__if_OBQG3pjamwKNHnPfZzkemQ = state_1;
            }

            return that_31;
        }

        public n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj that_0 = this;
            this.__if_OBQG3pjamwKNHnPfZzkemQ = default(n2.Object);
            return that_0;
        }

        public n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj __CreateDefault__()
        {
            n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj that_0 = this;
            this.__if_OBQG3pjamwKNHnPfZzkemQ = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_OBQG3pjamwKNHnPfZzkemQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104017U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TD74bdr2OQMOll8frAmdrh", Name = "__slot_TD74bdr2OQMOll8frAmdrh")]
        public static float __slot_TD74bdr2OQMOll8frAmdrh = 0F;
        [n1.ElementAttribute(TracingId = 104033U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VVm8kcL1E4dMiw4ELuItU6", Name = "__slot_VVm8kcL1E4dMiw4ELuItU6")]
        public static n5.Vector2 __slot_VVm8kcL1E4dMiw4ELuItU6 = n1.CompilationHelper.Deserialize<n5.Vector2>("0.74, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "VVm8kcL1E4dMiw4ELuItU6");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeJoin __c_Kd7HmtfLhX2LXdIEdtdfJ1 = n1.CompilationHelper.Deserialize<n13.SKStrokeJoin>("Miter", false, "PSPaLWEsDmnP5LJnFN7pkq", "Kd7HmtfLhX2LXdIEdtdfJ1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKStrokeCap __c_QYIpB9VWSFJOBgeHFwXQEG = n1.CompilationHelper.Deserialize<n13.SKStrokeCap>("Butt", false, "PSPaLWEsDmnP5LJnFN7pkq", "QYIpB9VWSFJOBgeHFwXQEG");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_N7XLsqvPRFdNIJa34dv2Sr = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "N7XLsqvPRFdNIJa34dv2Sr");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n20.RectangleAnchor __c_DphB9BT1hbMMlRyMqxMuZM = n1.CompilationHelper.Deserialize<n20.RectangleAnchor>("Center", false, "PSPaLWEsDmnP5LJnFN7pkq", "DphB9BT1hbMMlRyMqxMuZM");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_OBQG3pjamwKNHnPfZzkemQ;
        static DrawRotation_HjhhS7ycrwZMLPltie7ifj()
        {
        }

        public DrawRotation_HjhhS7ycrwZMLPltie7ifj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawRotation_HjhhS7ycrwZMLPltie7ifj(DrawRotation_HjhhS7ycrwZMLPltie7ifj other): base(other)
        {
            this.__if_OBQG3pjamwKNHnPfZzkemQ = other.__if_OBQG3pjamwKNHnPfZzkemQ;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_OBQG3pjamwKNHnPfZzkemQ", in __if_OBQG3pjamwKNHnPfZzkemQ));
        }

        internal DrawRotation_HjhhS7ycrwZMLPltie7ifj __WITH__(n2.Object __if_OBQG3pjamwKNHnPfZzkemQ)
        {
            n10.DrawRotation_HjhhS7ycrwZMLPltie7ifj that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_OBQG3pjamwKNHnPfZzkemQ != this.__if_OBQG3pjamwKNHnPfZzkemQ ? new DrawRotation_HjhhS7ycrwZMLPltie7ifj(this)
                {__if_OBQG3pjamwKNHnPfZzkemQ = __if_OBQG3pjamwKNHnPfZzkemQ} : that_0;
            else
            {
                this.__if_OBQG3pjamwKNHnPfZzkemQ = __if_OBQG3pjamwKNHnPfZzkemQ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "EVDcxolCHsBO1rH4XVhfE2", Name = "__EVDcxolCHsBO1rH4XVhfE2")]
        [n2.SerializableAttribute]
        public class __EVDcxolCHsBO1rH4XVhfE2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_ETRhTs3UQGKNkjW9cCDems);
                n1.CompilationHelper.SafeDispose(this.__p_TCtmccPFUsLMzqFzkaxz0A);
                n1.CompilationHelper.SafeDispose(this.__p_NDUUDP9TIhSLA62KkkTaBQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 104002U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "ETRhTs3UQGKNkjW9cCDems", Name = "Circle", IsManaged = true, IsAutoGenerated = true)]
            public n18.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_ETRhTs3UQGKNkjW9cCDems;
            [n1.ElementAttribute(TracingId = 104009U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "TCtmccPFUsLMzqFzkaxz0A", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_TCtmccPFUsLMzqFzkaxz0A;
            [n1.ElementAttribute(TracingId = 104018U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "NDUUDP9TIhSLA62KkkTaBQ", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_NDUUDP9TIhSLA62KkkTaBQ;
            public __EVDcxolCHsBO1rH4XVhfE2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EVDcxolCHsBO1rH4XVhfE2(__EVDcxolCHsBO1rH4XVhfE2 other): base(other)
            {
                this.__p_ETRhTs3UQGKNkjW9cCDems = other.__p_ETRhTs3UQGKNkjW9cCDems;
                this.__p_TCtmccPFUsLMzqFzkaxz0A = other.__p_TCtmccPFUsLMzqFzkaxz0A;
                this.__p_NDUUDP9TIhSLA62KkkTaBQ = other.__p_NDUUDP9TIhSLA62KkkTaBQ;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ETRhTs3UQGKNkjW9cCDems", in __p_ETRhTs3UQGKNkjW9cCDems), n1.CompilationHelper.GetValueOrExisting(values, "__p_TCtmccPFUsLMzqFzkaxz0A", in __p_TCtmccPFUsLMzqFzkaxz0A), n1.CompilationHelper.GetValueOrExisting(values, "__p_NDUUDP9TIhSLA62KkkTaBQ", in __p_NDUUDP9TIhSLA62KkkTaBQ));
            }

            internal __EVDcxolCHsBO1rH4XVhfE2 __WITH__(n18.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_ETRhTs3UQGKNkjW9cCDems, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_TCtmccPFUsLMzqFzkaxz0A, n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_NDUUDP9TIhSLA62KkkTaBQ)
            {
                __EVDcxolCHsBO1rH4XVhfE2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_ETRhTs3UQGKNkjW9cCDems != this.__p_ETRhTs3UQGKNkjW9cCDems || __p_TCtmccPFUsLMzqFzkaxz0A != this.__p_TCtmccPFUsLMzqFzkaxz0A || __p_NDUUDP9TIhSLA62KkkTaBQ != this.__p_NDUUDP9TIhSLA62KkkTaBQ ? new __EVDcxolCHsBO1rH4XVhfE2(this)
                    {__p_ETRhTs3UQGKNkjW9cCDems = __p_ETRhTs3UQGKNkjW9cCDems, __p_TCtmccPFUsLMzqFzkaxz0A = __p_TCtmccPFUsLMzqFzkaxz0A, __p_NDUUDP9TIhSLA62KkkTaBQ = __p_NDUUDP9TIhSLA62KkkTaBQ} : that_0;
                else
                {
                    this.__p_ETRhTs3UQGKNkjW9cCDems = __p_ETRhTs3UQGKNkjW9cCDems;
                    this.__p_TCtmccPFUsLMzqFzkaxz0A = __p_TCtmccPFUsLMzqFzkaxz0A;
                    this.__p_NDUUDP9TIhSLA62KkkTaBQ = __p_NDUUDP9TIhSLA62KkkTaBQ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 104077U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UtsfEfb9QfhM1f4443x988", Name = "DrawCenter_UtsfEfb9QfhM1f4443x988")]
    [n2.SerializableAttribute]
    public class DrawCenter_UtsfEfb9QfhM1f4443x988 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n10.DrawCenter_UtsfEfb9QfhM1f4443x988 Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawCenter_UtsfEfb9QfhM1f4443x988(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n10.DrawCenter_UtsfEfb9QfhM1f4443x988 CreateDefault()
        {
            var instance = new DrawCenter_UtsfEfb9QfhM1f4443x988(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.DrawCenter_UtsfEfb9QfhM1f4443x988 Update(n5.Matrix Transformation_In, n5.Color4 Color_In, bool Is_Active_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.ILayer Output_Out)
        {
            n8.ILayer __auto_0;
            var state_1 = n1.CompilationHelper.Restore<__V6OTCWdQeeBNE42VBSikho>(this.__if_Hvuj2sfCV4DN5paKURiyRI, __GetContext__());
            if (Enabled_In)
            {
                if (state_1 == null)
                {
                    state_1 = new __V6OTCWdQeeBNE42VBSikho(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_2 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "Ba4XqCxGrlILcAVpMz01N9", 104087U);
                    var Output_3 = n18.Circle_PkBNwasMVJjOdYsVSPoZ1g.Create(Node_Context: Node_Context_2);
                    state_1.__p_Ba4XqCxGrlILcAVpMz01N9 = Output_3;
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "IgKVCfcHGndOfmTclo3osY", 104094U);
                    var Output_5 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_4);
                    state_1.__p_IgKVCfcHGndOfmTclo3osY = Output_5;
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "RbXKmFLUfYKPSY6vg0YDzd", 104103U);
                    var Output_7 = n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_6);
                    state_1.__p_RbXKmFLUfYKPSY6vg0YDzd = Output_7;
                }

                float __pad_FGoVrMfT6RmOqalWDNfXmX_8 = __slot_FGoVrMfT6RmOqalWDNfXmX;
                var Output_9 = !Is_Active_In;
                var Output_10 = Color_In;
                if (Output_9)
                {
                    n30.ColorNodes.Scale(input: ref Color_In, scalar: __pad_FGoVrMfT6RmOqalWDNfXmX_8, output: out n5.Color4 Output_11);
                    Output_10 = Output_11;
                }

                n9.SkiaPaint_R Input_12 = n9.SkiaPaint_R.CreateDefault();
                n13.SKShader Shader_13 = default(n13.SKShader);
                var State_Output_15 = state_1.__p_IgKVCfcHGndOfmTclo3osY.Update(Input_In: Input_12, Color_In: Output_10, Shader_In: Shader_13, Output_Out: out n9.SkiaPaint_R Output_14);
                bool Input_16 = true;
                bool Input_2_17 = true;
                var Output_18 = Input_16 && Input_2_17;
                n5.Vector2 Position_19 = __c_PbWCpBmf7DhQCIn8IqDH1m;
                float Radius_20 = 0.5F;
                n20.RectangleAnchor Anchor_21 = __c_VqGhj8PbnP4M0jte27rltZ;
                var State_Output_23 = state_1.__p_Ba4XqCxGrlILcAVpMz01N9.Update(Position_In: Position_19, Radius_In: Radius_20, Anchor_In: Anchor_21, Paint_In: Output_14, Enabled_In: Output_18, Output_Out: out n8.ILayer Output_22);
                var State_Output_25 = state_1.__p_RbXKmFLUfYKPSY6vg0YDzd.Update(Input_In: Output_22, Transformation_In: Transformation_In, Output_Out: out n8.ILayer Output_24);
                __auto_0 = Output_24;
                if (state_1.__GetContext__().IsImmutable)
                    state_1 = State_Output_15 != state_1.__p_IgKVCfcHGndOfmTclo3osY || State_Output_23 != state_1.__p_Ba4XqCxGrlILcAVpMz01N9 || State_Output_25 != state_1.__p_RbXKmFLUfYKPSY6vg0YDzd ? new __V6OTCWdQeeBNE42VBSikho(state_1)
                    {__p_IgKVCfcHGndOfmTclo3osY = State_Output_15, __p_Ba4XqCxGrlILcAVpMz01N9 = State_Output_23, __p_RbXKmFLUfYKPSY6vg0YDzd = State_Output_25} : state_1;
                else
                {
                    state_1.__p_IgKVCfcHGndOfmTclo3osY = State_Output_15;
                    state_1.__p_Ba4XqCxGrlILcAVpMz01N9 = State_Output_23;
                    state_1.__p_RbXKmFLUfYKPSY6vg0YDzd = State_Output_25;
                }
            }
            else
            {
                __auto_0 = n25._Operations_.CreateDefault();
            }

            Output_Out = __auto_0;
            n10.DrawCenter_UtsfEfb9QfhM1f4443x988 that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = state_1 != this.__if_Hvuj2sfCV4DN5paKURiyRI ? new DrawCenter_UtsfEfb9QfhM1f4443x988(this)
                {__if_Hvuj2sfCV4DN5paKURiyRI = state_1} : that_26;
            else
            {
                this.__if_Hvuj2sfCV4DN5paKURiyRI = state_1;
            }

            return that_26;
        }

        public n10.DrawCenter_UtsfEfb9QfhM1f4443x988 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n10.DrawCenter_UtsfEfb9QfhM1f4443x988 that_0 = this;
            this.__if_Hvuj2sfCV4DN5paKURiyRI = default(n2.Object);
            return that_0;
        }

        public n10.DrawCenter_UtsfEfb9QfhM1f4443x988 __CreateDefault__()
        {
            n10.DrawCenter_UtsfEfb9QfhM1f4443x988 that_0 = this;
            this.__if_Hvuj2sfCV4DN5paKURiyRI = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Hvuj2sfCV4DN5paKURiyRI);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104112U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "FGoVrMfT6RmOqalWDNfXmX", Name = "__slot_FGoVrMfT6RmOqalWDNfXmX")]
        public static float __slot_FGoVrMfT6RmOqalWDNfXmX = 0.8F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_PbWCpBmf7DhQCIn8IqDH1m = n1.CompilationHelper.Deserialize<n5.Vector2>("0, 0", false, "PSPaLWEsDmnP5LJnFN7pkq", "PbWCpBmf7DhQCIn8IqDH1m");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n20.RectangleAnchor __c_VqGhj8PbnP4M0jte27rltZ = n1.CompilationHelper.Deserialize<n20.RectangleAnchor>("Center", false, "PSPaLWEsDmnP5LJnFN7pkq", "VqGhj8PbnP4M0jte27rltZ");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Hvuj2sfCV4DN5paKURiyRI;
        static DrawCenter_UtsfEfb9QfhM1f4443x988()
        {
        }

        public DrawCenter_UtsfEfb9QfhM1f4443x988(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawCenter_UtsfEfb9QfhM1f4443x988(DrawCenter_UtsfEfb9QfhM1f4443x988 other): base(other)
        {
            this.__if_Hvuj2sfCV4DN5paKURiyRI = other.__if_Hvuj2sfCV4DN5paKURiyRI;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_Hvuj2sfCV4DN5paKURiyRI", in __if_Hvuj2sfCV4DN5paKURiyRI));
        }

        internal DrawCenter_UtsfEfb9QfhM1f4443x988 __WITH__(n2.Object __if_Hvuj2sfCV4DN5paKURiyRI)
        {
            n10.DrawCenter_UtsfEfb9QfhM1f4443x988 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_Hvuj2sfCV4DN5paKURiyRI != this.__if_Hvuj2sfCV4DN5paKURiyRI ? new DrawCenter_UtsfEfb9QfhM1f4443x988(this)
                {__if_Hvuj2sfCV4DN5paKURiyRI = __if_Hvuj2sfCV4DN5paKURiyRI} : that_0;
            else
            {
                this.__if_Hvuj2sfCV4DN5paKURiyRI = __if_Hvuj2sfCV4DN5paKURiyRI;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "V6OTCWdQeeBNE42VBSikho", Name = "__V6OTCWdQeeBNE42VBSikho")]
        [n2.SerializableAttribute]
        public class __V6OTCWdQeeBNE42VBSikho : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Ba4XqCxGrlILcAVpMz01N9);
                n1.CompilationHelper.SafeDispose(this.__p_IgKVCfcHGndOfmTclo3osY);
                n1.CompilationHelper.SafeDispose(this.__p_RbXKmFLUfYKPSY6vg0YDzd);
                return;
            }

            [n1.ElementAttribute(TracingId = 104087U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Ba4XqCxGrlILcAVpMz01N9", Name = "Circle", IsManaged = true, IsAutoGenerated = true)]
            public n18.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_Ba4XqCxGrlILcAVpMz01N9;
            [n1.ElementAttribute(TracingId = 104094U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "IgKVCfcHGndOfmTclo3osY", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_IgKVCfcHGndOfmTclo3osY;
            [n1.ElementAttribute(TracingId = 104103U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "RbXKmFLUfYKPSY6vg0YDzd", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_RbXKmFLUfYKPSY6vg0YDzd;
            public __V6OTCWdQeeBNE42VBSikho(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __V6OTCWdQeeBNE42VBSikho(__V6OTCWdQeeBNE42VBSikho other): base(other)
            {
                this.__p_Ba4XqCxGrlILcAVpMz01N9 = other.__p_Ba4XqCxGrlILcAVpMz01N9;
                this.__p_IgKVCfcHGndOfmTclo3osY = other.__p_IgKVCfcHGndOfmTclo3osY;
                this.__p_RbXKmFLUfYKPSY6vg0YDzd = other.__p_RbXKmFLUfYKPSY6vg0YDzd;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ba4XqCxGrlILcAVpMz01N9", in __p_Ba4XqCxGrlILcAVpMz01N9), n1.CompilationHelper.GetValueOrExisting(values, "__p_IgKVCfcHGndOfmTclo3osY", in __p_IgKVCfcHGndOfmTclo3osY), n1.CompilationHelper.GetValueOrExisting(values, "__p_RbXKmFLUfYKPSY6vg0YDzd", in __p_RbXKmFLUfYKPSY6vg0YDzd));
            }

            internal __V6OTCWdQeeBNE42VBSikho __WITH__(n18.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_Ba4XqCxGrlILcAVpMz01N9, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_IgKVCfcHGndOfmTclo3osY, n27.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_RbXKmFLUfYKPSY6vg0YDzd)
            {
                __V6OTCWdQeeBNE42VBSikho that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Ba4XqCxGrlILcAVpMz01N9 != this.__p_Ba4XqCxGrlILcAVpMz01N9 || __p_IgKVCfcHGndOfmTclo3osY != this.__p_IgKVCfcHGndOfmTclo3osY || __p_RbXKmFLUfYKPSY6vg0YDzd != this.__p_RbXKmFLUfYKPSY6vg0YDzd ? new __V6OTCWdQeeBNE42VBSikho(this)
                    {__p_Ba4XqCxGrlILcAVpMz01N9 = __p_Ba4XqCxGrlILcAVpMz01N9, __p_IgKVCfcHGndOfmTclo3osY = __p_IgKVCfcHGndOfmTclo3osY, __p_RbXKmFLUfYKPSY6vg0YDzd = __p_RbXKmFLUfYKPSY6vg0YDzd} : that_0;
                else
                {
                    this.__p_Ba4XqCxGrlILcAVpMz01N9 = __p_Ba4XqCxGrlILcAVpMz01N9;
                    this.__p_IgKVCfcHGndOfmTclo3osY = __p_IgKVCfcHGndOfmTclo3osY;
                    this.__p_RbXKmFLUfYKPSY6vg0YDzd = __p_RbXKmFLUfYKPSY6vg0YDzd;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 103613U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Highlight(n5.Color4 Input_In, float Is_Active_In, out n5.Color4 Output_Out)
        {
            float __pad_VGoWSyHs9hCLqRZx35yV8T_0 = __slot_VGoWSyHs9hCLqRZx35yV8T;
            float __pad_P7ZOWMsuiSZN3vUjOpBJvr_1 = __slot_P7ZOWMsuiSZN3vUjOpBJvr;
            var Result_2 = Is_Active_In < __pad_P7ZOWMsuiSZN3vUjOpBJvr_1;
            var Output_3 = Input_In;
            if (Result_2)
            {
                n30.ColorNodes.Scale(input: ref Input_In, scalar: __pad_VGoWSyHs9hCLqRZx35yV8T_0, output: out n5.Color4 Output_4);
                Output_3 = Output_4;
            }

            Output_Out = Output_3;
            return;
        }

        [n1.ElementAttribute(TracingId = 103855U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "VGoWSyHs9hCLqRZx35yV8T", Name = "__slot_VGoWSyHs9hCLqRZx35yV8T")]
        public static float __slot_VGoWSyHs9hCLqRZx35yV8T = 0.6F;
        [n1.ElementAttribute(TracingId = 103860U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "P7ZOWMsuiSZN3vUjOpBJvr", Name = "__slot_P7ZOWMsuiSZN3vUjOpBJvr")]
        public static float __slot_P7ZOWMsuiSZN3vUjOpBJvr = 0.5F;
        static _Operations_()
        {
        }
    }
}

namespace _VL_EditorViews_.Graphics.Skia.EditorViews.PointsView.Experimental
{
    [n1.ElementAttribute(TracingId = 104520U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Lml7tONfclPOARgsXFq7Br", Name = "DrawPoints_Lml7tONfclPOARgsXFq7Br")]
    [n2.SerializableAttribute]
    public class DrawPoints_Lml7tONfclPOARgsXFq7Br : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n11.DrawPoints_Lml7tONfclPOARgsXFq7Br Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawPoints_Lml7tONfclPOARgsXFq7Br(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n11.DrawPoints_Lml7tONfclPOARgsXFq7Br CreateDefault()
        {
            var instance = new DrawPoints_Lml7tONfclPOARgsXFq7Br(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br Update(n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>> Input_In, float Size_In, n9.SkiaPaint_R Paint_In, out n18.PathLayer_C Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_HBebewzQqtQLVNv4Ocecxg;
            if (manager_2 is null)
            {
                manager_2 = new n14.Manager<n2.ValueTuple<n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>, float>, n2.ValueTuple<n13.SKPath>>(n2.ValueTuple.Create(n15._Operations_.CreateDefault()));
            }

            var inputs_3 = (Input_In, Size_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n13.SKPath accumulator_8 = n15._Operations_.CreateDefault();
                var i_10 = 0;
                foreach (var item_7 in Input_In)
                {
                    var splicer_9 = item_7;
                    var i_local_11 = i_10;
                    float __pad_HyZmTsYnXeYPxu5TlcX6RK_13 = __slot_HyZmTsYnXeYPxu5TlcX6RK;
                    var Output_21 = splicer_9.Split(Position_Out: out n5.Vector2 Position_14, Locked_Out: out bool Locked_15, Selected_Out: out bool Selected_16, Hovered_Out: out bool Hovered_17, KeyHovered_Out: out bool KeyHovered_18, SelectionModifier_Out: out int SelectionModifier_19, Id_Out: out int Id_20);
                    var Output_22 = (float)Size_In / __pad_HyZmTsYnXeYPxu5TlcX6RK_13;
                    n13.SKPathDirection Dir_23 = __c_QFbbOPUMf9INjBAxc2s2PJ;
                    n16._Operations_.AddCircle(Input_In: accumulator_8, Center_In: Position_14, Dir_In: Dir_23, Radius_In: Output_22, Output_Out: out n13.SKPath Output_24);
                    accumulator_8 = Output_24;
                    i_10++;
                }

                outputs_4 = n2.ValueTuple.Create(accumulator_8);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_25 = outputs_4.Item1;
            n17._Operations_.Any<n12.EditablePoint_R<n5.Vector2>>(Input_In: Input_In, Result_Out: out bool Result_26);
            var State_Output_28 = this.__p_UjmMobny51PQWHE3XbP4px.Update(Path_In: __auto_25, Paint_In: Paint_In, Enabled_In: Result_26, Output_Out: out n18.PathLayer_C Output_27);
            Output_Out = Output_27;
            n11.DrawPoints_Lml7tONfclPOARgsXFq7Br that_29 = this;
            if (this.__GetContext__().IsImmutable)
                that_29 = manager_2 != this.__cache_HBebewzQqtQLVNv4Ocecxg || State_Output_28 != this.__p_UjmMobny51PQWHE3XbP4px ? new DrawPoints_Lml7tONfclPOARgsXFq7Br(this)
                {__cache_HBebewzQqtQLVNv4Ocecxg = manager_2, __p_UjmMobny51PQWHE3XbP4px = State_Output_28} : that_29;
            else
            {
                this.__cache_HBebewzQqtQLVNv4Ocecxg = manager_2;
                this.__p_UjmMobny51PQWHE3XbP4px = State_Output_28;
            }

            return that_29;
        }

        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("PSPaLWEsDmnP5LJnFN7pkq", "UjmMobny51PQWHE3XbP4px", 104523U);
            var Output_1 = n18.DrawPath_B5wYA2D334kMvk12hQ0Bw9.Create(Node_Context: Node_Context_0);
            n11.DrawPoints_Lml7tONfclPOARgsXFq7Br that_2 = this;
            this.__p_UjmMobny51PQWHE3XbP4px = Output_1;
            this.__cache_HBebewzQqtQLVNv4Ocecxg = null;
            return that_2;
        }

        public n11.DrawPoints_Lml7tONfclPOARgsXFq7Br __CreateDefault__()
        {
            n11.DrawPoints_Lml7tONfclPOARgsXFq7Br that_0 = this;
            this.__cache_HBebewzQqtQLVNv4Ocecxg = null;
            this.__p_UjmMobny51PQWHE3XbP4px = n18.DrawPath_B5wYA2D334kMvk12hQ0Bw9.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_HBebewzQqtQLVNv4Ocecxg);
            n1.CompilationHelper.SafeDispose(this.__p_UjmMobny51PQWHE3XbP4px);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 104532U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HBebewzQqtQLVNv4Ocecxg", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n14.Manager<n2.ValueTuple<n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>, float>, n2.ValueTuple<n13.SKPath>> __cache_HBebewzQqtQLVNv4Ocecxg = null;
        [n1.ElementAttribute(TracingId = 104567U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HyZmTsYnXeYPxu5TlcX6RK", Name = "__slot_HyZmTsYnXeYPxu5TlcX6RK")]
        public static float __slot_HyZmTsYnXeYPxu5TlcX6RK = 2F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n13.SKPathDirection __c_QFbbOPUMf9INjBAxc2s2PJ = n1.CompilationHelper.Deserialize<n13.SKPathDirection>("Clockwise", false, "PSPaLWEsDmnP5LJnFN7pkq", "QFbbOPUMf9INjBAxc2s2PJ");
        [n1.ElementAttribute(TracingId = 104523U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UjmMobny51PQWHE3XbP4px", Name = "DrawPath", IsManaged = true, IsAutoGenerated = true)]
        public n18.DrawPath_B5wYA2D334kMvk12hQ0Bw9 __p_UjmMobny51PQWHE3XbP4px;
        static DrawPoints_Lml7tONfclPOARgsXFq7Br()
        {
        }

        public DrawPoints_Lml7tONfclPOARgsXFq7Br(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawPoints_Lml7tONfclPOARgsXFq7Br(DrawPoints_Lml7tONfclPOARgsXFq7Br other): base(other)
        {
            this.__cache_HBebewzQqtQLVNv4Ocecxg = other.__cache_HBebewzQqtQLVNv4Ocecxg;
            this.__p_UjmMobny51PQWHE3XbP4px = other.__p_UjmMobny51PQWHE3XbP4px;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_HBebewzQqtQLVNv4Ocecxg", in __cache_HBebewzQqtQLVNv4Ocecxg), n1.CompilationHelper.GetValueOrExisting(values, "__p_UjmMobny51PQWHE3XbP4px", in __p_UjmMobny51PQWHE3XbP4px));
        }

        internal DrawPoints_Lml7tONfclPOARgsXFq7Br __WITH__(n14.Manager<n2.ValueTuple<n7.IEnumerable<n12.EditablePoint_R<n5.Vector2>>, float>, n2.ValueTuple<n13.SKPath>> __cache_HBebewzQqtQLVNv4Ocecxg, n18.DrawPath_B5wYA2D334kMvk12hQ0Bw9 __p_UjmMobny51PQWHE3XbP4px)
        {
            n11.DrawPoints_Lml7tONfclPOARgsXFq7Br that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_HBebewzQqtQLVNv4Ocecxg != this.__cache_HBebewzQqtQLVNv4Ocecxg || __p_UjmMobny51PQWHE3XbP4px != this.__p_UjmMobny51PQWHE3XbP4px ? new DrawPoints_Lml7tONfclPOARgsXFq7Br(this)
                {__cache_HBebewzQqtQLVNv4Ocecxg = __cache_HBebewzQqtQLVNv4Ocecxg, __p_UjmMobny51PQWHE3XbP4px = __p_UjmMobny51PQWHE3XbP4px} : that_0;
            else
            {
                this.__cache_HBebewzQqtQLVNv4Ocecxg = __cache_HBebewzQqtQLVNv4Ocecxg;
                this.__p_UjmMobny51PQWHE3XbP4px = __p_UjmMobny51PQWHE3XbP4px;
            }

            return that_0;
        }
    }
}

namespace _VL_EditorViews_.Graphics.Skia.EditorViews.PointEditorView.Experimental
{
    [n1.ElementAttribute(TracingId = 103613U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void FormatData(bool Scale_In, bool Rotate_In, bool Translate_In, n5.Vector2 Offset_In, out string Output_Out)
        {
            string __pad_UcYttbJbdbsOvqWKjBeFpv_0 = __slot_UcYttbJbdbsOvqWKjBeFpv;
            string __auto_1;
            if (Scale_In)
            {
                string __pad_CWXKtTe103NNlKeVnRsk4P_2 = __slot_CWXKtTe103NNlKeVnRsk4P;
                __auto_1 = __pad_CWXKtTe103NNlKeVnRsk4P_2;
            }
            else
            {
                __auto_1 = "";
            }

            var Output_3 = Scale_In || Translate_In;
            string __auto_4;
            if (Rotate_In)
            {
                string __pad_Qcjs3lCQTNbPg4KqVR1zSe_5 = __slot_Qcjs3lCQTNbPg4KqVR1zSe;
                __auto_4 = __pad_Qcjs3lCQTNbPg4KqVR1zSe_5;
            }
            else
            {
                __auto_4 = __auto_1;
            }

            string __auto_6;
            if (Translate_In)
            {
                string __pad_QSKIWOGUuQoLl0h5qhVL3D_7 = __slot_QSKIWOGUuQoLl0h5qhVL3D;
                __auto_6 = __pad_QSKIWOGUuQoLl0h5qhVL3D_7;
            }
            else
            {
                __auto_6 = __auto_4;
            }

            string __auto_8;
            if (Output_3)
            {
                string __pad_AZsr2LdAbm7PwelHqi5h6c_9 = __slot_AZsr2LdAbm7PwelHqi5h6c;
                string __pad_AYJX9krs31APxPjCDWdyb4_10 = __slot_AYJX9krs31APxPjCDWdyb4;
                string __pad_MeEvyncvRfSPUbtbBwQI6Z_11 = __slot_MeEvyncvRfSPUbtbBwQI6Z;
                n20.Vector2Nodes.Vector(input: ref Offset_In, x: out float X_12, y: out float Y_13);
                var Result_14 = X_12.ToString(format: __pad_AZsr2LdAbm7PwelHqi5h6c_9);
                var Result_15 = Y_13.ToString(format: __pad_MeEvyncvRfSPUbtbBwQI6Z_11);
                var Output_16 = n21.StringExtensions.Plus(input: Result_14, input2: __pad_AYJX9krs31APxPjCDWdyb4_10);
                var Output_17 = n21.StringExtensions.Plus(input: Output_16, input2: Result_15);
                __auto_8 = Output_17;
            }
            else
            {
                __auto_8 = "";
            }

            string __auto_18;
            if (Rotate_In)
            {
                string __pad_I0ffHCU0UqpP8k1wHoR8eW_19 = __slot_I0ffHCU0UqpP8k1wHoR8eW;
                string __pad_HjKvmZa33K0LDlok5eTAnM_20 = __slot_HjKvmZa33K0LDlok5eTAnM;
                var Y_21 = Offset_In.Y;
                var Output_22 = n21.Float32Extensions.CyclesToDegree(cycles: Y_21);
                var Result_23 = Output_22.ToString(format: __pad_I0ffHCU0UqpP8k1wHoR8eW_19);
                var Output_24 = n21.StringExtensions.Plus(input: Result_23, input2: __pad_HjKvmZa33K0LDlok5eTAnM_20);
                __auto_18 = Output_24;
            }
            else
            {
                __auto_18 = __auto_8;
            }

            var Output_25 = n21.StringExtensions.Plus(input: __auto_6, input2: __pad_UcYttbJbdbsOvqWKjBeFpv_0);
            var Output_26 = n21.StringExtensions.Plus(input: Output_25, input2: __auto_18);
            Output_Out = Output_26;
            return;
        }

        [n1.ElementAttribute(TracingId = 105369U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "UcYttbJbdbsOvqWKjBeFpv", Name = "__slot_UcYttbJbdbsOvqWKjBeFpv")]
        public static string __slot_UcYttbJbdbsOvqWKjBeFpv = ": ";
        [n1.ElementAttribute(TracingId = 105345U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "CWXKtTe103NNlKeVnRsk4P", Name = "__slot_CWXKtTe103NNlKeVnRsk4P")]
        public static string __slot_CWXKtTe103NNlKeVnRsk4P = "Scale";
        [n1.ElementAttribute(TracingId = 105353U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "Qcjs3lCQTNbPg4KqVR1zSe", Name = "__slot_Qcjs3lCQTNbPg4KqVR1zSe")]
        public static string __slot_Qcjs3lCQTNbPg4KqVR1zSe = "Rotate";
        [n1.ElementAttribute(TracingId = 105361U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "QSKIWOGUuQoLl0h5qhVL3D", Name = "__slot_QSKIWOGUuQoLl0h5qhVL3D")]
        public static string __slot_QSKIWOGUuQoLl0h5qhVL3D = "Translate";
        [n1.ElementAttribute(TracingId = 105411U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AZsr2LdAbm7PwelHqi5h6c", Name = "__slot_AZsr2LdAbm7PwelHqi5h6c")]
        public static string __slot_AZsr2LdAbm7PwelHqi5h6c = "f2";
        [n1.ElementAttribute(TracingId = 105417U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "AYJX9krs31APxPjCDWdyb4", Name = "__slot_AYJX9krs31APxPjCDWdyb4")]
        public static string __slot_AYJX9krs31APxPjCDWdyb4 = " ";
        [n1.ElementAttribute(TracingId = 105416U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "MeEvyncvRfSPUbtbBwQI6Z", Name = "__slot_MeEvyncvRfSPUbtbBwQI6Z")]
        public static string __slot_MeEvyncvRfSPUbtbBwQI6Z = "f2";
        [n1.ElementAttribute(TracingId = 105379U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "I0ffHCU0UqpP8k1wHoR8eW", Name = "__slot_I0ffHCU0UqpP8k1wHoR8eW")]
        public static string __slot_I0ffHCU0UqpP8k1wHoR8eW = "f2";
        [n1.ElementAttribute(TracingId = 105387U, DocumentId = "PSPaLWEsDmnP5LJnFN7pkq", PersistentId = "HjKvmZa33K0LDlok5eTAnM", Name = "__slot_HjKvmZa33K0LDlok5eTAnM")]
        public static string __slot_HjKvmZa33K0LDlok5eTAnM = "°";
        static _Operations_()
        {
        }
    }
}

namespace _VL_EditorViews_
{
    public struct __AdaptiveImplementations__PSPaLWEsDmnP5LJnFN7pkq : n56.IAdaptiveCreateDefault<n5.Vector2>, n56.IAdaptiveCreateDefault<float>, n57.IAdaptiveOperatorMinus<float>, n57.IAdaptiveOperatorLess<float>, n56.IAdaptiveCreateDefault<bool>, n56.IAdaptiveCreateDefault<n5.Vector3>
    {
        public void CreateDefault(out n5.Vector2 Output_Out)
        {
            var Zero_0 = n29._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n55._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n55._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n5.Vector3 Output_Out)
        {
            var Zero_0 = n26._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }
    }
}