/**************************
***** Compiler Parameters *****
***************************
@P EffectName: VLEffectMain
@P   - Material.PixelStageSurfaceShaders: mixin MaterialSurfaceArray [{layers = [mixin MaterialSurfaceDiffuse [{diffuseMap = ComputeColorConstantColorLink<Material.DiffuseValue>}], mixin MaterialSurfaceGlossinessMap<true> [{glossinessMap = mixin FloatToScalar [{Value = mixin DoFloat [{Before = mixin ComputeOrder [{Computes = [ComputeVoid]}]}, {Value = ConstantFloat<1>}]}]}], mixin MaterialSurfaceMetalness [{metalnessMap = ComputeColorConstantFloatLink<Material.MetalnessValue>}], mixin MaterialSurfaceSetStreamFromComputeColor<matEmissive,rgba> [{computeColorSource = mixin Float4ToColor [{Value = mixin DoFloat4 [{Before = mixin ComputeOrder [{Computes = [ComputeVoid, ComputeVoid, ComputeVoid, mixin AssignVarFloat2<Input_2> [{Value = InputFloat2<ShaderFX.InputValueFloat2,PerMaterial>}], mixin AssignVarFloat2<Plus_3> [{Value = mixin PlusFloat2 [{Left = GetSemanticFloat2<SemanticValue_4,TEXCOORD0>}, {Right = GetVarFloat2<Input_2>}]}], mixin AssignVarFloat2<Input_5> [{Value = InputFloat2<ShaderFX.InputValueFloat2.i1,PerMaterial>}], mixin AssignVarFloat2<Multiply_6> [{Value = mixin MultiplyFloat2 [{Left = GetVarFloat2<Plus_3>}, {Right = GetVarFloat2<Input_5>}]}], mixin AssignVarFloat2<Input_7> [{Value = InputFloat2<ShaderFX.InputValueFloat2.i2,PerMaterial>}], mixin AssignVarFloat2<Plus_8> [{Value = mixin PlusFloat2 [{Left = GetVarFloat2<Multiply_6>}, {Right = GetVarFloat2<Input_7>}]}], mixin AssignVarFloat4<TextureValue_9> [{Value = mixin SampleTextureFloat4<ObjectTexture_fx0,PerMaterial,ObjectSampler_fx1,PerMaterial> [{TexCd = GetVarFloat2<Plus_8>}]}]]}]}, {Value = GetVarFloat4<TextureValue_9>}]}]}], mixin MaterialSurfaceSetStreamFromComputeColor<matEmissiveIntensity,r> [{computeColorSource = mixin FloatToScalar [{Value = mixin DoFloat [{Before = mixin ComputeOrder [{Computes = [mixin AssignVarFloat<Input_10> [{Value = InputFloat<ShaderFX.InputValueFloat,PerMaterial>}]]}]}, {Value = GetVarFloat<Input_10>}]}]}], mixin MaterialSurfaceLightingAndShading [{surfaces = [MaterialSurfaceShadingDiffuseLambert<false>, mixin MaterialSurfaceShadingSpecularMicrofacet [{environmentFunction = MaterialSpecularMicrofacetEnvironmentGGXLUT}, {fresnelFunction = MaterialSpecularMicrofacetFresnelSchlick}, {geometricShadowingFunction = MaterialSpecularMicrofacetVisibilitySmithSchlickGGX}, {normalDistributionFunction = MaterialSpecularMicrofacetNormalDistributionGGX}]]}], MaterialSurfaceEmissiveShading<false>]}]
@P Material.PixelStageStreamInitializer: mixin MaterialStream, MaterialPixelShadingStream
@P Lighting.DirectLightGroups: LightClusteredPointGroup, LightClusteredSpotGroup
@P Lighting.EnvironmentLights: LightSimpleAmbient, sdfx LightSkyboxEffect, EnvironmentLight
@P LightSkyboxShader.LightDiffuseColor.environmentLights[1]: SphericalHarmonicsEnvironmentColor<3>
@P LightSkyboxShader.LightSpecularColor.environmentLights[1]: RoughnessCubeMapEnvironmentColor
@P StrideEffectBase.RenderTargetExtensions: mixin [{ShadingColor1 = GBufferOutputSubsurfaceScatteringMaterialIndex}]
***************************
****  ConstantBuffers  ****
***************************
cbuffer PerDraw [Size: 432]
@C    World_id32 => Transformation.World
@C    WorldInverse_id33 => Transformation.WorldInverse
@C    WorldInverseTranspose_id34 => Transformation.WorldInverseTranspose
@C    WorldView_id35 => Transformation.WorldView
@C    WorldViewInverse_id36 => Transformation.WorldViewInverse
@C    WorldViewProjection_id37 => Transformation.WorldViewProjection
@C    WorldScale_id38 => Transformation.WorldScale
@C    EyeMS_id39 => Transformation.EyeMS
@C    MaterialIndex_id83 => GBufferOutputSubsurfaceScatteringMaterialIndex.MaterialIndex
cbuffer PerMaterial [Size: 64]
@C    constantColor_id171 => Material.DiffuseValue
@C    constantFloat_id180 => Material.MetalnessValue
@C    InputValue_id186 => ShaderFX.InputValueFloat2
@C    InputValue_id194 => ShaderFX.InputValueFloat2.i1
@C    InputValue_id201 => ShaderFX.InputValueFloat2.i2
@C    InputValue_id218 => ShaderFX.InputValueFloat
cbuffer PerView [Size: 672]
@C    View_id25 => Transformation.View
@C    ViewInverse_id26 => Transformation.ViewInverse
@C    Projection_id27 => Transformation.Projection
@C    ProjectionInverse_id28 => Transformation.ProjectionInverse
@C    ViewProjection_id29 => Transformation.ViewProjection
@C    ProjScreenRay_id30 => Transformation.ProjScreenRay
@C    Eye_id31 => Transformation.Eye
@C    NearClipPlane_id87 => Camera.NearClipPlane
@C    FarClipPlane_id88 => Camera.FarClipPlane
@C    ZProjection_id89 => Camera.ZProjection
@C    ViewSize_id90 => Camera.ViewSize
@C    AspectRatio_id91 => Camera.AspectRatio
@C    _padding_PerView_Default => _padding_PerView_Default
@C    ClusterDepthScale_id96 => LightClustered.ClusterDepthScale
@C    ClusterDepthBias_id97 => LightClustered.ClusterDepthBias
@C    ClusterStride_id98 => LightClustered.ClusterStride
@C    AmbientLight_id101 => LightSimpleAmbient.AmbientLight.environmentLights[0]
@C    SphericalColors_id106 => SphericalHarmonicsEnvironmentColor.SphericalColors.lightDiffuseColor.environmentLights[1]
@C    MipCount_id165 => RoughnessCubeMapEnvironmentColor.MipCount.lightSpecularColor.environmentLights[1]
@C    SkyMatrix_id167 => LightSkyboxShader.SkyMatrix.environmentLights[1]
@C    Intensity_id168 => LightSkyboxShader.Intensity.environmentLights[1]
@C    _padding_PerView_Lighting => _padding_PerView_Lighting
***************************
******  Resources    ******
***************************
@R    PerMaterial => PerMaterial [Stage: None, Slot: (-1--1)]
@R    DynamicTexture_id208 => ObjectTexture_fx0 [Stage: None, Slot: (-1--1)]
@R    DynamicTexture_id208 => ObjectTexture_fx0 [Stage: None, Slot: (-1--1)]
@R    DynamicSampler_id209 => ObjectSampler_fx1 [Stage: None, Slot: (-1--1)]
@R    DynamicSampler_id209 => ObjectSampler_fx1 [Stage: None, Slot: (-1--1)]
@R    EnvironmentLightingDFG_LUT_id230 => MaterialSpecularMicrofacetEnvironmentGGXLUT.EnvironmentLightingDFG_LUT [Stage: None, Slot: (-1--1)]
@R    EnvironmentLightingDFG_LUT_id230 => MaterialSpecularMicrofacetEnvironmentGGXLUT.EnvironmentLightingDFG_LUT [Stage: None, Slot: (-1--1)]
@R    LightClusters_id94 => LightClustered.LightClusters [Stage: None, Slot: (-1--1)]
@R    LightClusters_id94 => LightClustered.LightClusters [Stage: None, Slot: (-1--1)]
@R    LightIndices_id95 => LightClustered.LightIndices [Stage: None, Slot: (-1--1)]
@R    LightIndices_id95 => LightClustered.LightIndices [Stage: None, Slot: (-1--1)]
@R    PointLights_id99 => LightClusteredPointGroup.PointLights [Stage: None, Slot: (-1--1)]
@R    PointLights_id99 => LightClusteredPointGroup.PointLights [Stage: None, Slot: (-1--1)]
@R    SpotLights_id100 => LightClusteredSpotGroup.SpotLights [Stage: None, Slot: (-1--1)]
@R    SpotLights_id100 => LightClusteredSpotGroup.SpotLights [Stage: None, Slot: (-1--1)]
@R    CubeMap_id166 => RoughnessCubeMapEnvironmentColor.CubeMap.lightSpecularColor.environmentLights[1] [Stage: None, Slot: (-1--1)]
@R    CubeMap_id166 => RoughnessCubeMapEnvironmentColor.CubeMap.lightSpecularColor.environmentLights[1] [Stage: None, Slot: (-1--1)]
@R    PerDraw => PerDraw [Stage: Vertex, Slot: (0-0)]
@R    PerView => PerView [Stage: Vertex, Slot: (1-1)]
@R    LinearSampler_id137 => Texturing.LinearSampler [Stage: Pixel, Slot: (0-0)]
@R    DynamicSampler_id209 => ObjectSampler_fx1 [Stage: Pixel, Slot: (1-1)]
@R    DynamicTexture_id208 => ObjectTexture_fx0 [Stage: Pixel, Slot: (0-0)]
@R    EnvironmentLightingDFG_LUT_id230 => MaterialSpecularMicrofacetEnvironmentGGXLUT.EnvironmentLightingDFG_LUT [Stage: Pixel, Slot: (1-1)]
@R    LightClusters_id94 => LightClustered.LightClusters [Stage: Pixel, Slot: (2-2)]
@R    LightIndices_id95 => LightClustered.LightIndices [Stage: Pixel, Slot: (3-3)]
@R    PointLights_id99 => LightClusteredPointGroup.PointLights [Stage: Pixel, Slot: (4-4)]
@R    SpotLights_id100 => LightClusteredSpotGroup.SpotLights [Stage: Pixel, Slot: (5-5)]
@R    CubeMap_id166 => RoughnessCubeMapEnvironmentColor.CubeMap.lightSpecularColor.environmentLights[1] [Stage: Pixel, Slot: (6-6)]
@R    PerDraw => PerDraw [Stage: Pixel, Slot: (0-0)]
@R    PerMaterial => PerMaterial [Stage: Pixel, Slot: (1-1)]
@R    PerView => PerView [Stage: Pixel, Slot: (2-2)]
***************************
*****     Sources     *****
***************************
@S    ShaderBase => 01e372056ff6c06edab8e988414a8f75
@S    ShaderBaseStream => 91c0ea8aae0a45ca00578a4084fa3607
@S    ShadingBase => ffb632df632721ce2c25f1b6f505fc1e
@S    ComputeColor => 4f34177c1ace328c0f5ae9b3e880dac2
@S    TransformationBase => 8b17025a11a061cbf806a590fecff713
@S    NormalStream => 901c352015317e9dff7f9aef777dc0c7
@S    TransformationWAndVP => 4852381ef91335cbf665eca43a0eb5ee
@S    PositionStream4 => 978c413387a2cb385e61d6d096be6d21
@S    PositionHStream4 => 6a2c2e4bcfc42de2c49c69f480ead970
@S    Transformation => 6c40fce14b58a620257103f7d0f4c093
@S    NormalFromMesh => d6eccd1ce6aae826e4049d4e94b581a4
@S    NormalBase => 3e598ef48925debde0053f3469205f5f
@S    NormalUpdate => a1cefe3f75303b1c5857928c714e12bf
@S    MaterialSurfacePixelStageCompositor => 69d0c95661b93268f264d740adf7b8f4
@S    PositionStream => f29f571241be3db9dd2ec9688eb1db49
@S    MaterialPixelShadingStream => 9d583be145776e49c5a8377a978b0658
@S    MaterialPixelStream => ba54d20041c3b54e07f20babb85f60bb
@S    MaterialStream => 5add3babbb46e617235ca05953485ed8
@S    IStreamInitializer => 092b60c9fe32ce985421fcfe20a11072
@S    LightStream => 56c38b50a16fcb778c6eb6de86c307b5
@S    DirectLightGroupArray => eb6e08e566ca745bb06964c172175969
@S    DirectLightGroup => f340deae83183fca86789915a8f743c4
@S    ShadowGroup => 05578eeca4469db17e4a68e127e25a9f
@S    ShadowStream => 1adfec0b15bc9bf4d56e6be9b378a587
@S    TextureProjectionGroup => 48db91a31cbf2a9150d13547051adb85
@S    EnvironmentLightArray => 02bffee7c5265d75553f30029f1fbf48
@S    EnvironmentLight => aec79836f4a6429ad55d8efc9971a8d7
@S    IMaterialSurface => 993d0e1a3a0209ce4df727250c905ab8
@S    LightClusteredPointGroup => daa4f884feed02bad152ef53f5820771
@S    LightClustered => f939f2ab47789c1fd022283bcadfa42e
@S    ScreenPositionBase => 447b80ee2709564be56e617346288f78
@S    Camera => 68de88612bfb3b0a92e9082b82b993a9
@S    LightPoint => ffca22202bf34deee191bc36e95d9ccf
@S    LightUtil => 21256a4364432cc656447ee541333792
@S    LightClusteredSpotGroup => ae51eef97b7a5ad4cf63e15461308bdd
@S    LightSpot => ffc8735093683cafbdbc1f59643b9b8f
@S    SpotLightDataInternalShader => 5f0bd728a1c56b1def3b26d3859f6876
@S    LightSpotAttenuationDefault => 3764b4b242d09ba41b1a9cd5678ddf55
@S    LightSimpleAmbient => 6b7c24748a4d72e5eb22ae12802d3b2d
@S    LightSkyboxShader => e57c1a10760a5036091dc1dcff962ae4
@S    IComputeEnvironmentColor => 0783535f47b4ba224b058b4b2ef41e20
@S    SphericalHarmonicsEnvironmentColor => d0c7f35eaec52e1a0fb822bc020d370a
@S    SphericalHarmonicsUtils => cdd3d002e9050bbda686218976dc0951
@S    Math => 395aa210901b9e0783594d1b4fb0a441
@S    RoughnessCubeMapEnvironmentColor => 0f1c10a9dec458f93fadc022cb19144e
@S    Texturing => 6605f68230266eff2bc8b4e8102ede6b
@S    MaterialSurfaceArray => 6c056e27887290fe2f9862991714228f
@S    MaterialSurfaceDiffuse => 4130aff8a17174b1b1457299185be45e
@S    IMaterialSurfacePixel => efa5da7adb861031599778e9829daca8
@S    ComputeColorConstantColorLink => 66070b757702cedd6874020f33fef9bf
@S    MaterialSurfaceGlossinessMap => ec8934feb70f88c3bd9058130e6b7832
@S    FloatToScalar => 190ca2ba985be574ef882e8bdb8b38a2
@S    ComputeFloat => 2744918ba519afc956e367cbd1cb1fc4
@S    DoFloat => d050e0ec3f8e208b719183949cc88f11
@S    ComputeVoid => de97af339f497c4b8917a076af92194b
@S    ComputeOrder => 50906fabe772669b3f8af01fdd9c505d
@S    ConstantFloat => aed4b78684dc4c864ef592d9012d160a
@S    MaterialSurfaceMetalness => 53f38107e2a3f588a066e5056cfbe194
@S    ComputeColorConstantFloatLink => 67c5dd9d320c3e22be10134f9f78fe1f
@S    MaterialSurfaceSetStreamFromComputeColor => d24798cd4613058b907bf6e272883693
@S    IMaterialSurfaceVertex => 0fdda64f0492719d7ada59ea23d8f052
@S    MaterialVertexStream => 4f1267b84dea64fc7c323dfcfc385ab2
@S    MaterialDisplacementStream => 5d57748e7230a9347827c8f299c2d525
@S    IMaterialSurfaceDomain => 4f15b2e1d3036634d4e5f52e39c40e57
@S    MaterialDomainStream => a7008fc6e4d9a36114cef530b894de85
@S    MaterialTessellationStream => c86b4a80b983fe69485b091d0a16cf5a
@S    Float4ToColor => 090c0c91c91b9d0b479ea3e773355055
@S    ComputeFloat4 => 6aeb31691af393d622350bb42f15ad31
@S    DoFloat4 => 39d0035e8f78b3fb7449b690dd1fcc91
@S    AssignVarFloat2 => 67b63b02f9838f2318eb0c65bb4553da
@S    ComputeFloat2 => 3cb979534c18e3e81752140e13d82062
@S    StreamVariableFloat2 => c5141787f96b8fee35fde0d761b49e03
@S    InputFloat2 => 042c351c36e5fb3acaea7eeb8813664f
@S    DeclFloat2 => eecebfd45046be0b49f471972754ce92
@S    PlusFloat2 => ff9adf9813c4ace655072c9d25bf5f9b
@S    GetSemanticFloat2 => cef11c2d21dccf32709a3540af9fdfe6
@S    SemanticFloat2 => eea4e558745376b199f8d17e22432d60
@S    GetVarFloat2 => 64a3517f4f1ae31bdf05f2c3d3fe8e0a
@S    MultiplyFloat2 => 41c1c86a3e98175af72d90c7f66234df
@S    AssignVarFloat4 => e54e0b8e92e739bce2ac0f556badd874
@S    StreamVariableFloat4 => c2e6e06503f828c3a049b22513676b9e
@S    SampleTextureFloat4 => b832676f5e8f16d886cc7db0f638781e
@S    DeclTexture => 20968d641b7a50ffd1f5a28039e2e644
@S    DeclSampler => a4a1cb6e69a422bf97ec5d441117548a
@S    GetVarFloat4 => 9a12d35140d41c5c9743d8babe2b56e2
@S    AssignVarFloat => a27c6bbf503fcc9e236bc94dd1c261bf
@S    StreamVariableFloat => 20a0c0292833cf8f573b776f121529c5
@S    InputFloat => edce7cfb3e88687e30d0d7dadcb5a90d
@S    DeclFloat => f4460ed7a64afae8a4c604a1f0434666
@S    GetVarFloat => 15ef45218ac83c53348d7e12dab45514
@S    MaterialSurfaceLightingAndShading => 56a8877cd2af395727b11f69c761ad41
@S    IMaterialSurfaceShading => 86261e2a0ca0229f0d6ddf87490e5967
@S    MaterialSurfaceShadingDiffuseLambert => 9adb7783d6ea173f9f8ffdfa5c141256
@S    MaterialSurfaceShadingSpecularMicrofacet => 74a9cdfd18445f03ce98df19b4e5e5f0
@S    BRDFMicrofacet => 634bc8cd641b44251287c32dc4bb310b
@S    IMaterialSpecularMicrofacetFresnelFunction => 12e80a2bc796cfc576987299453cb890
@S    IMaterialSpecularMicrofacetVisibilityFunction => a8f975c174875f719493984daf60fab9
@S    IMaterialSpecularMicrofacetNormalDistributionFunction => fc5b438d6e5ae420d08b84f94299b658
@S    IMaterialSpecularMicrofacetEnvironmentFunction => 2faf111195f4b7802bc5194f4a9a62ee
@S    MaterialSpecularMicrofacetEnvironmentGGXLUT => 6f3fa570d4541f87cd04693e894e1856
@S    MaterialSpecularMicrofacetFresnelSchlick => 04e1a6d84795686816d85b78b9155ad8
@S    MaterialSpecularMicrofacetVisibilitySmithSchlickGGX => 45e27c12fa6ed8195f675a525b5df801
@S    MaterialSpecularMicrofacetNormalDistributionGGX => a9f1af90f24c65d1656e0b155aabc565
@S    MaterialSurfaceEmissiveShading => 1c66007c23627d525bd2d12381ca0782
@S    GBufferOutputSubsurfaceScatteringMaterialIndex => 5df9471bf02401dc5db0de4bbd3d8abb
***************************
*****     Stages      *****
***************************
@G    Vertex => 4dd351e624ae23bca1cde0008bff22af
//
// Generated by Microsoft (R) HLSL Shader Compiler 10.1
//
//
// Buffer Definitions: 
//
// cbuffer PerDraw
// {
//
//   float4x4 World_id32;               // Offset:    0 Size:    64
//   float4x4 WorldInverse_id33;        // Offset:   64 Size:    64 [unused]
//   float4x4 WorldInverseTranspose_id34;// Offset:  128 Size:    64
//   float4x4 WorldView_id35;           // Offset:  192 Size:    64 [unused]
//   float4x4 WorldViewInverse_id36;    // Offset:  256 Size:    64 [unused]
//   float4x4 WorldViewProjection_id37; // Offset:  320 Size:    64 [unused]
//   float3 WorldScale_id38;            // Offset:  384 Size:    12 [unused]
//   float4 EyeMS_id39;                 // Offset:  400 Size:    16 [unused]
//   uint MaterialIndex_id83;           // Offset:  416 Size:     4 [unused]
//
// }
//
// cbuffer PerView
// {
//
//   float4x4 View_id25;                // Offset:    0 Size:    64 [unused]
//   float4x4 ViewInverse_id26;         // Offset:   64 Size:    64 [unused]
//   float4x4 Projection_id27;          // Offset:  128 Size:    64 [unused]
//   float4x4 ProjectionInverse_id28;   // Offset:  192 Size:    64 [unused]
//   float4x4 ViewProjection_id29;      // Offset:  256 Size:    64
//   float2 ProjScreenRay_id30;         // Offset:  320 Size:     8 [unused]
//   float4 Eye_id31;                   // Offset:  336 Size:    16 [unused]
//   float NearClipPlane_id87;          // Offset:  352 Size:     4 [unused]
//      = 0x3f800000 
//   float FarClipPlane_id88;           // Offset:  356 Size:     4 [unused]
//      = 0x42c80000 
//   float2 ZProjection_id89;           // Offset:  360 Size:     8 [unused]
//   float2 ViewSize_id90;              // Offset:  368 Size:     8 [unused]
//   float AspectRatio_id91;            // Offset:  376 Size:     4 [unused]
//   float4 _padding_PerView_Default;   // Offset:  384 Size:    16 [unused]
//   float ClusterDepthScale_id96;      // Offset:  400 Size:     4 [unused]
//   float ClusterDepthBias_id97;       // Offset:  404 Size:     4 [unused]
//   float2 ClusterStride_id98;         // Offset:  408 Size:     8 [unused]
//   float3 AmbientLight_id101;         // Offset:  416 Size:    12 [unused]
//   float3 SphericalColors_id106[9];   // Offset:  432 Size:   140 [unused]
//   float MipCount_id165;              // Offset:  572 Size:     4 [unused]
//   float4x4 SkyMatrix_id167;          // Offset:  576 Size:    64 [unused]
//   float Intensity_id168;             // Offset:  640 Size:     4 [unused]
//   float4 _padding_PerView_Lighting;  // Offset:  656 Size:    16 [unused]
//
// }
//
//
// Resource Bindings:
//
// Name                                 Type  Format         Dim      HLSL Bind  Count
// ------------------------------ ---------- ------- ----------- -------------- ------
// PerDraw                           cbuffer      NA          NA            cb0      1 
// PerView                           cbuffer      NA          NA            cb1      1 
//
//
//
// Input signature:
//
// Name                 Index   Mask Register SysValue  Format   Used
// -------------------- ----- ------ -------- -------- ------- ------
// POSITION                 0   xyzw        0     NONE   float   xyzw
// NORMAL                   0   xyz         1     NONE   float   xyz 
// TEXCOORD                 0   xy          2     NONE   float   xy  
//
//
// Output signature:
//
// Name                 Index   Mask Register SysValue  Format   Used
// -------------------- ----- ------ -------- -------- ------- ------
// POSITION_WS              0   xyzw        0     NONE   float   xyzw
// SV_Position              0   xyzw        1      POS   float   xyzw
// NORMALWS                 0   xyz         2     NONE   float   xyz 
// SCREENPOSITION_ID86_SEM     0   xyzw        3     NONE   float   xyzw
// TEXCOORD                 0   xy          4     NONE   float   xy  
//
vs_5_0
dcl_globalFlags refactoringAllowed
dcl_constantbuffer CB0[11], immediateIndexed
dcl_constantbuffer CB1[20], immediateIndexed
dcl_input v0.xyzw
dcl_input v1.xyz
dcl_input v2.xy
dcl_output o0.xyzw
dcl_output_siv o1.xyzw, position
dcl_output o2.xyz
dcl_output o3.xyzw
dcl_output o4.xy
dcl_temps 2
//
// Initial variable locations:
//   v0.x <- __input__.Position_id21.x; v0.y <- __input__.Position_id21.y; v0.z <- __input__.Position_id21.z; v0.w <- __input__.Position_id21.w; 
//   v1.x <- __input__.meshNormal_id16.x; v1.y <- __input__.meshNormal_id16.y; v1.z <- __input__.meshNormal_id16.z; 
//   v2.x <- __input__.TexCoord_id155.x; v2.y <- __input__.TexCoord_id155.y; 
//   o4.x <- <VSMain return value>.TexCoord_id155.x; o4.y <- <VSMain return value>.TexCoord_id155.y; 
//   o3.x <- <VSMain return value>.ScreenPosition_id86.x; o3.y <- <VSMain return value>.ScreenPosition_id86.y; o3.z <- <VSMain return value>.ScreenPosition_id86.z; o3.w <- <VSMain return value>.ScreenPosition_id86.w; 
//   o2.x <- <VSMain return value>.normalWS_id19.x; o2.y <- <VSMain return value>.normalWS_id19.y; o2.z <- <VSMain return value>.normalWS_id19.z; 
//   o1.x <- <VSMain return value>.ShadingPosition_id0.x; o1.y <- <VSMain return value>.ShadingPosition_id0.y; o1.z <- <VSMain return value>.ShadingPosition_id0.z; o1.w <- <VSMain return value>.ShadingPosition_id0.w; 
//   o0.x <- <VSMain return value>.PositionWS_id22.x; o0.y <- <VSMain return value>.PositionWS_id22.y; o0.z <- <VSMain return value>.PositionWS_id22.z; o0.w <- <VSMain return value>.PositionWS_id22.w
//
#line 1085 "C:\Users\emanu\Desktop\ReposFolder\Solar-System-VVVV\SolarSystem\lib\log\shader_VLEffectMain_b80a0d496126cf9dd50064d7420db436.hlsl"
dp4 r0.x, v0.xyzw, cb0[0].xyzw  // r0.x <- streams.PositionWS_id22.x
dp4 r0.y, v0.xyzw, cb0[1].xyzw  // r0.y <- streams.PositionWS_id22.y
dp4 r0.z, v0.xyzw, cb0[2].xyzw  // r0.z <- streams.PositionWS_id22.z
dp4 r0.w, v0.xyzw, cb0[3].xyzw  // r0.w <- streams.PositionWS_id22.w

#line 1173
mov o0.xyzw, r0.xyzw

#line 1028
dp4 r1.x, r0.xyzw, cb1[16].xyzw  // r1.x <- <ComputeShadingPosition_id11 return value>.x
dp4 r1.y, r0.xyzw, cb1[17].xyzw  // r1.y <- <ComputeShadingPosition_id11 return value>.y
dp4 r1.z, r0.xyzw, cb1[18].xyzw  // r1.z <- <ComputeShadingPosition_id11 return value>.z
dp4 r1.w, r0.xyzw, cb1[19].xyzw  // r1.w <- <ComputeShadingPosition_id11 return value>.w

#line 1173
mov o1.xyzw, r1.xyzw
mov o3.xyzw, r1.xyzw

#line 1125
dp3 o2.x, v1.xyzx, cb0[8].xyzx
dp3 o2.y, v1.xyzx, cb0[9].xyzx
dp3 o2.z, v1.xyzx, cb0[10].xyzx

#line 1173
mov o4.xy, v2.xyxx
ret 
// Approximately 16 instruction slots used
@G    Pixel => 4db684325f35e7f8130b6a3591130257
//
// Generated by Microsoft (R) HLSL Shader Compiler 10.1
//
//
// Buffer Definitions: 
//
// cbuffer PerDraw
// {
//
//   float4x4 World_id32;               // Offset:    0 Size:    64 [unused]
//   float4x4 WorldInverse_id33;        // Offset:   64 Size:    64 [unused]
//   float4x4 WorldInverseTranspose_id34;// Offset:  128 Size:    64 [unused]
//   float4x4 WorldView_id35;           // Offset:  192 Size:    64 [unused]
//   float4x4 WorldViewInverse_id36;    // Offset:  256 Size:    64 [unused]
//   float4x4 WorldViewProjection_id37; // Offset:  320 Size:    64 [unused]
//   float3 WorldScale_id38;            // Offset:  384 Size:    12 [unused]
//   float4 EyeMS_id39;                 // Offset:  400 Size:    16 [unused]
//   uint MaterialIndex_id83;           // Offset:  416 Size:     4
//
// }
//
// cbuffer PerMaterial
// {
//
//   float4 constantColor_id171;        // Offset:    0 Size:    16
//   float constantFloat_id180;         // Offset:   16 Size:     4
//   float2 InputValue_id186;           // Offset:   20 Size:     8
//   float2 InputValue_id194;           // Offset:   32 Size:     8
//   float2 InputValue_id201;           // Offset:   40 Size:     8
//   float InputValue_id218;            // Offset:   48 Size:     4
//
// }
//
// cbuffer PerView
// {
//
//   float4x4 View_id25;                // Offset:    0 Size:    64 [unused]
//   float4x4 ViewInverse_id26;         // Offset:   64 Size:    64 [unused]
//   float4x4 Projection_id27;          // Offset:  128 Size:    64 [unused]
//   float4x4 ProjectionInverse_id28;   // Offset:  192 Size:    64 [unused]
//   float4x4 ViewProjection_id29;      // Offset:  256 Size:    64 [unused]
//   float2 ProjScreenRay_id30;         // Offset:  320 Size:     8 [unused]
//   float4 Eye_id31;                   // Offset:  336 Size:    16
//   float NearClipPlane_id87;          // Offset:  352 Size:     4 [unused]
//      = 0x3f800000 
//   float FarClipPlane_id88;           // Offset:  356 Size:     4 [unused]
//      = 0x42c80000 
//   float2 ZProjection_id89;           // Offset:  360 Size:     8
//   float2 ViewSize_id90;              // Offset:  368 Size:     8 [unused]
//   float AspectRatio_id91;            // Offset:  376 Size:     4 [unused]
//   float4 _padding_PerView_Default;   // Offset:  384 Size:    16 [unused]
//   float ClusterDepthScale_id96;      // Offset:  400 Size:     4
//   float ClusterDepthBias_id97;       // Offset:  404 Size:     4
//   float2 ClusterStride_id98;         // Offset:  408 Size:     8
//   float3 AmbientLight_id101;         // Offset:  416 Size:    12
//   float3 SphericalColors_id106[9];   // Offset:  432 Size:   140
//   float MipCount_id165;              // Offset:  572 Size:     4
//   float4x4 SkyMatrix_id167;          // Offset:  576 Size:    64
//   float Intensity_id168;             // Offset:  640 Size:     4
//   float4 _padding_PerView_Lighting;  // Offset:  656 Size:    16 [unused]
//
// }
//
//
// Resource Bindings:
//
// Name                                 Type  Format         Dim      HLSL Bind  Count
// ------------------------------ ---------- ------- ----------- -------------- ------
// LinearSampler_id137               sampler      NA          NA             s0      1 
// DynamicSampler_id209              sampler      NA          NA             s1      1 
// DynamicTexture_id208              texture  float4          2d             t0      1 
// EnvironmentLightingDFG_LUT_id230    texture  float4          2d             t1      1 
// LightClusters_id94                texture   uint2          3d             t2      1 
// LightIndices_id95                 texture    uint         buf             t3      1 
// PointLights_id99                  texture  float4         buf             t4      1 
// SpotLights_id100                  texture  float4         buf             t5      1 
// CubeMap_id166                     texture  float4        cube             t6      1 
// PerDraw                           cbuffer      NA          NA            cb0      1 
// PerMaterial                       cbuffer      NA          NA            cb1      1 
// PerView                           cbuffer      NA          NA            cb2      1 
//
//
//
// Input signature:
//
// Name                 Index   Mask Register SysValue  Format   Used
// -------------------- ----- ------ -------- -------- ------- ------
// POSITION_WS              0   xyzw        0     NONE   float   xyz 
// SV_Position              0   xyzw        1      POS   float     z 
// NORMALWS                 0   xyz         2     NONE   float   xyz 
// SCREENPOSITION_ID86_SEM     0   xyzw        3     NONE   float   xy w
// TEXCOORD                 0   xy          4     NONE   float   xy  
// SV_IsFrontFace           0   x           5    FFACE    uint   x   
//
//
// Output signature:
//
// Name                 Index   Mask Register SysValue  Format   Used
// -------------------- ----- ------ -------- -------- ------- ------
// SV_Target                0   xyzw        0   TARGET   float   xyzw
// SV_Target                1   xyzw        1   TARGET   float   xyzw
//
ps_5_0
dcl_globalFlags refactoringAllowed
dcl_constantbuffer CB0[27], immediateIndexed
dcl_constantbuffer CB1[4], immediateIndexed
dcl_constantbuffer CB2[41], immediateIndexed
dcl_sampler s0, mode_default
dcl_sampler s1, mode_default
dcl_resource_texture2d (float,float,float,float) t0
dcl_resource_texture2d (float,float,float,float) t1
dcl_resource_texture3d (uint,uint,uint,uint) t2
dcl_resource_buffer (uint,uint,uint,uint) t3
dcl_resource_buffer (float,float,float,float) t4
dcl_resource_buffer (float,float,float,float) t5
dcl_resource_texturecube (float,float,float,float) t6
dcl_input_ps linear v0.xyz
dcl_input_ps_siv linear noperspective v1.z, position
dcl_input_ps linear v2.xyz
dcl_input_ps linear v3.xyw
dcl_input_ps linear v4.xy
dcl_input_ps_sgv constant v5.x, is_front_face
dcl_output o0.xyzw
dcl_output o1.xyzw
dcl_temps 17
//
// Initial variable locations:
//   v0.x <- __input__.PositionWS_id22.x; v0.y <- __input__.PositionWS_id22.y; v0.z <- __input__.PositionWS_id22.z; v0.w <- __input__.PositionWS_id22.w; 
//   v1.x <- __input__.ShadingPosition_id0.x; v1.y <- __input__.ShadingPosition_id0.y; v1.z <- __input__.ShadingPosition_id0.z; v1.w <- __input__.ShadingPosition_id0.w; 
//   v2.x <- __input__.normalWS_id19.x; v2.y <- __input__.normalWS_id19.y; v2.z <- __input__.normalWS_id19.z; 
//   v3.x <- __input__.ScreenPosition_id86.x; v3.y <- __input__.ScreenPosition_id86.y; v3.z <- __input__.ScreenPosition_id86.z; v3.w <- __input__.ScreenPosition_id86.w; 
//   v4.x <- __input__.TexCoord_id155.x; v4.y <- __input__.TexCoord_id155.y; 
//   v5.x <- __input__.IsFrontFace_id1; 
//   o1.x <- <PSMain return value>.ColorTarget1_id3.x; o1.y <- <PSMain return value>.ColorTarget1_id3.y; o1.z <- <PSMain return value>.ColorTarget1_id3.z; o1.w <- <PSMain return value>.ColorTarget1_id3.w; 
//   o0.x <- <PSMain return value>.ColorTarget_id2.x; o0.y <- <PSMain return value>.ColorTarget_id2.y; o0.z <- <PSMain return value>.ColorTarget_id2.z; o0.w <- <PSMain return value>.ColorTarget_id2.w
//
#line 1152 "C:\Users\emanu\Desktop\ReposFolder\Solar-System-VVVV\SolarSystem\lib\log\shader_VLEffectMain_b80a0d496126cf9dd50064d7420db436.hlsl"
div r0.xy, v3.xyxx, v3.wwww  // r0.x <- streams.ScreenPosition_id86.x; r0.y <- streams.ScreenPosition_id86.y

#line 1119
dp3 r0.z, v2.xyzx, v2.xyzx
lt r0.w, l(0.000000), r0.z

#line 1120
rsq r0.z, r0.z
mul r1.xyz, r0.zzzz, v2.xyzx  // r1.x <- streams.normalWS_id19.x; r1.y <- streams.normalWS_id19.y; r1.z <- streams.normalWS_id19.z
movc r1.xyz, r0.wwww, r1.xyzx, v2.xyzx

#line 1093
add r2.xyz, -v0.xyzx, cb2[21].xyzx
dp3 r0.z, r2.xyzx, r2.xyzx
rsq r0.z, r0.z
mul r2.xyz, r0.zzzz, r2.xyzx  // r2.x <- streams.viewWS_id68.x; r2.y <- streams.viewWS_id68.y; r2.z <- streams.viewWS_id68.z

#line 984
add r3.xyz, cb1[0].xyzx, l(-0.020000, -0.020000, -0.020000, 0.000000)
mad r3.xyz, cb1[1].xxxx, r3.xyzx, l(0.020000, 0.020000, 0.020000, 0.000000)  // r3.x <- streams.matSpecular_id55.x; r3.y <- streams.matSpecular_id55.y; r3.z <- streams.matSpecular_id55.z

#line 985
mad r4.xyz, cb1[1].xxxx, -cb1[0].xyzx, cb1[0].xyzx  // r4.x <- streams.matDiffuse_id53.x; r4.y <- streams.matDiffuse_id53.y; r4.z <- streams.matDiffuse_id53.z

#line 370
add r0.zw, v4.xxxy, cb1[1].yyyz  // r0.z <- <Compute_id252 return value>.x; r0.w <- <Compute_id252 return value>.y

#line 354
mad r0.zw, r0.zzzw, cb1[2].xxxy, cb1[2].zzzw  // r0.z <- <Compute_id268 return value>.x; r0.w <- <Compute_id268 return value>.y

#line 350
sample_indexable(texture2d)(float,float,float,float) r5.xyz, r0.zwzz, t0.xyzw, s1  // r5.x <- <Compute_id272 return value>.x; r5.y <- <Compute_id272 return value>.y; r5.z <- <Compute_id272 return value>.z

#line 865
movc r1.xyz, v5.xxxx, r1.xyzx, -r1.xyzx  // r1.x <- streams.normalWS_id19.x; r1.y <- streams.normalWS_id19.y; r1.z <- streams.normalWS_id19.z

#line 810
dp3 r0.z, r1.xyzx, r2.xyzx
max r6.y, r0.z, l(0.000100)  // r6.y <- streams.NdotV_id72

#line 669
add r0.z, v1.z, -cb2[22].z
div r0.z, cb2[22].w, r0.z  // r0.z <- depth

#line 670
mad r0.xy, r0.xyxx, l(1.000000, -1.000000, 0.000000, 0.000000), l(1.000000, 1.000000, 0.000000, 0.000000)
mul r0.xy, r0.xyxx, cb2[25].zwzz

#line 671
mad r0.z, r0.z, cb2[25].x, cb2[25].y
log r0.z, r0.z
max r0.z, r0.z, l(0.000000)

#line 672
mul r0.xy, r0.xyxx, l(0.500000, 0.500000, 0.000000, 0.000000)

#line 671
ftoi r7.xyz, r0.xyzx  // r7.z <- slice

#line 672
mov r7.w, l(0)
ld_indexable(texture3d)(uint,uint,uint,uint) r0.xy, r7.xyzw, t2.xyzw  // r0.x <- streams.lightData_id92.x; r0.y <- streams.lightData_id92.y

#line 793
and r0.z, r0.y, l(0x0000ffff)  // r0.z <- <GetMaxLightCount_id185 return value>

#line 883
mov r7.xyz, r1.xyzx  // r7.x <- streams.normalWS_id19.x; r7.y <- streams.normalWS_id19.y; r7.z <- streams.normalWS_id19.z
mov r7.w, v0.x  // r7.w <- streams.PositionWS_id22.x
mov r8.xy, v0.yzyy  // r8.x <- streams.PositionWS_id22.y; r8.y <- streams.PositionWS_id22.z
mov r8.zw, r2.xxxy  // r8.z <- streams.viewWS_id68.x; r8.w <- streams.viewWS_id68.y
mov r9.z, r2.z  // r9.z <- streams.viewWS_id68.z
mov r10.xyz, r4.xyzx  // r10.x <- streams.matDiffuseVisible_id69.x; r10.y <- streams.matDiffuseVisible_id69.y; r10.z <- streams.matDiffuseVisible_id69.z
mov r11.xyz, r3.xyzx  // r11.x <- streams.matSpecularVisible_id71.x; r11.y <- streams.matSpecularVisible_id71.y; r11.z <- streams.matSpecularVisible_id71.z
mov r6.w, r6.y  // r6.w <- streams.NdotV_id72
mov r6.z, r0.x  // r6.z <- streams.lightIndex_id93
mov r12.xyz, l(0,0,0,0)  // r12.x <- directLightingContribution.x; r12.y <- directLightingContribution.y; r12.z <- directLightingContribution.z
mov r0.w, l(0)  // r0.w <- i
loop 
  ige r1.w, r0.w, r0.z
  breakc_nz r1.w

#line 885
  if_nz r1.w

#line 887
    break 

#line 888
  endif 

#line 656
  ld_indexable(buffer)(uint,uint,uint,uint) r1.w, r6.zzzz, t3.yzwx  // r1.w <- realLightIndex

#line 657
  iadd r6.z, r6.z, l(1)  // r6.z <- streams.lightIndex_id93

#line 659
  ishl r2.w, r1.w, l(1)
  ld_indexable(buffer)(float,float,float,float) r13.xyzw, r2.wwww, t4.xyzw  // r13.x <- pointLight1.x; r13.y <- pointLight1.y; r13.z <- pointLight1.z; r13.w <- pointLight1.w

#line 660
  bfi r1.w, l(31), l(1), r1.w, l(1)
  ld_indexable(buffer)(float,float,float,float) r14.xyz, r1.wwww, t4.xyzw  // r14.x <- pointLight2.x; r14.y <- pointLight2.y; r14.z <- pointLight2.z

#line 400
  mov r15.x, r7.w
  mov r15.yz, r8.xxyx
  add r13.xyz, r13.xyzx, -r15.xyzx  // r13.x <- lightVector.x; r13.y <- lightVector.y; r13.z <- lightVector.z

#line 401
  dp3 r1.w, r13.xyzx, r13.xyzx
  sqrt r2.w, r1.w  // r2.w <- lightVectorLength

#line 402
  div r13.xyz, r13.xyzx, r2.wwww  // r13.x <- lightVectorNorm.x; r13.y <- lightVectorNorm.y; r13.z <- lightVectorNorm.z

#line 340
  max r2.w, r1.w, l(0.000100)
  div r2.w, l(1.000000, 1.000000, 1.000000, 1.000000), r2.w  // r2.w <- attenuation

#line 291
  mul r1.w, r13.w, r1.w  // r1.w <- factor

#line 292
  mad r1.w, -r1.w, r1.w, l(1.000000)
  max r1.w, r1.w, l(0.000000)  // r1.w <- smoothFactor

#line 293
  mul r1.w, r1.w, r1.w  // r1.w <- <SmoothDistanceAttenuation_id57 return value>

#line 341
  mul r1.w, r1.w, r2.w  // r1.w <- attenuation

#line 779
  dp3 r2.w, r7.xyzx, r13.xyzx
  max r2.w, r2.w, l(0.000100)  // r2.w <- streams.NdotL_id49

#line 781
  mul r14.xyz, r1.wwww, r14.xyzx
  mul r14.xyz, r2.wwww, r14.xyzx  // r14.x <- streams.lightColorNdotL_id44.x; r14.y <- streams.lightColorNdotL_id44.y; r14.z <- streams.lightColorNdotL_id44.z

#line 771
  mov r9.xy, r8.zwzz
  add r9.xyw, r13.xyxz, r9.xyxz
  dp3 r1.w, r9.xywx, r9.xywx
  rsq r1.w, r1.w
  mul r9.xyw, r1.wwww, r9.xyxw  // r9.x <- streams.H_id75.x; r9.y <- streams.H_id75.y; r9.w <- streams.H_id75.z

#line 773
  dp3_sat r1.w, r13.xyzx, r9.xywx  // r1.w <- streams.LdotH_id77

#line 767
  mul r9.xyw, r10.xyxz, r14.xyxz

#line 893
  mad r9.xyw, r9.xyxw, l(0.318310, 0.318310, 0.000000, 0.318310), r12.xyxz  // r9.x <- directLightingContribution.x; r9.y <- directLightingContribution.y; r9.w <- directLightingContribution.z

#line 396
  add r13.xyz, -r11.xyzx, l(1.000000, 1.000000, 1.000000, 0.000000)
  add r1.w, -r1.w, l(1.000000)
  mul r3.w, r1.w, r1.w
  mul r3.w, r3.w, r3.w
  mul r1.w, r1.w, r3.w
  mad r13.xyz, r13.xyzx, r1.wwww, r11.xyzx  // r13.x <- <FresnelSchlick_id135 return value>.x; r13.y <- <FresnelSchlick_id135 return value>.y; r13.z <- <FresnelSchlick_id135 return value>.z

#line 392
  mad r1.w, r2.w, l(0.500000), l(0.500000)
  div r1.w, r2.w, r1.w  // r1.w <- <VisibilityhSchlickGGX_id151 return value>
  mad r3.w, r6.w, l(0.500000), l(0.500000)
  div r3.w, r6.w, r3.w  // r3.w <- <VisibilityhSchlickGGX_id151 return value>

#line 491
  mul r1.w, r1.w, r3.w
  mul r2.w, r6.w, r2.w
  div r1.w, r1.w, r2.w  // r1.w <- <VisibilitySmithSchlickGGX_id153 return value>

#line 761
  mul r13.xyz, r1.wwww, r13.xyzx
  mul r13.xyz, r14.xyzx, r13.xyzx

#line 897
  mad r12.xyz, r13.xyzx, l(0.079577, 0.079577, 0.079577, 0.000000), r9.xywx  // r12.x <- directLightingContribution.x; r12.y <- directLightingContribution.y; r12.z <- directLightingContribution.z

#line 883
  iadd r0.w, r0.w, l(1)

#line 899
endloop   // r6.z <- streams.lightIndex_id93

#line 750
ushr r0.x, r0.y, l(16)  // r0.x <- <GetMaxLightCount_id197 return value>

#line 907
mov r0.yzw, v0.xxyz  // r0.y <- streams.PositionWS_id22.x; r0.z <- streams.PositionWS_id22.y; r0.w <- streams.PositionWS_id22.z
mov r1.w, r6.y  // r1.w <- streams.NdotV_id72
mov r7.xyz, r1.xyzx
mov r8.xyz, r2.xyzx  // r8.x <- streams.viewWS_id68.x; r8.y <- streams.viewWS_id68.y; r8.z <- streams.viewWS_id68.z
mov r9.xyz, r4.xyzx  // r9.x <- streams.matDiffuseVisible_id69.x; r9.y <- streams.matDiffuseVisible_id69.y; r9.z <- streams.matDiffuseVisible_id69.z
mov r10.xyz, r3.xyzx  // r10.x <- streams.matSpecularVisible_id71.x; r10.y <- streams.matSpecularVisible_id71.y; r10.z <- streams.matSpecularVisible_id71.z
mov r11.xyz, r12.xyzx  // r11.x <- directLightingContribution.x; r11.y <- directLightingContribution.y; r11.z <- directLightingContribution.z
mov r2.w, r6.z  // r2.w <- streams.lightIndex_id93
mov r3.w, l(0)  // r3.w <- i
loop 
  ige r4.w, r3.w, r0.x
  breakc_nz r4.w

#line 909
  if_nz r4.w

#line 911
    break 

#line 912
  endif 

#line 616
  ld_indexable(buffer)(uint,uint,uint,uint) r4.w, r2.wwww, t3.yzwx  // r4.w <- realLightIndex

#line 617
  iadd r2.w, r2.w, l(1)  // r2.w <- streams.lightIndex_id93

#line 619
  ishl r5.w, r4.w, l(2)
  ld_indexable(buffer)(float,float,float,float) r13.xyz, r5.wwww, t5.xyzw  // r13.x <- spotLight1.x; r13.y <- spotLight1.y; r13.z <- spotLight1.z

#line 622
  bfi r14.xyz, l(30, 30, 30, 0), l(2, 2, 2, 0), r4.wwww, l(1, 2, 3, 0)

#line 620
  ld_indexable(buffer)(float,float,float,float) r15.xyz, r14.xxxx, t5.xyzw  // r15.x <- spotLight2.x; r15.y <- spotLight2.y; r15.z <- spotLight2.z

#line 621
  ld_indexable(buffer)(float,float,float,float) r14.xyw, r14.yyyy, t5.xywz  // r14.x <- spotLight3.x; r14.y <- spotLight3.y; r14.w <- spotLight3.z

#line 622
  ld_indexable(buffer)(float,float,float,float) r16.xyz, r14.zzzz, t5.xyzw  // r16.x <- spotLight4.x; r16.y <- spotLight4.y; r16.z <- spotLight4.z

#line 378
  add r13.xyz, -r0.yzwy, r13.xyzx  // r13.x <- lightVector.x; r13.y <- lightVector.y; r13.z <- lightVector.z

#line 379
  dp3 r4.w, r13.xyzx, r13.xyzx
  sqrt r5.w, r4.w  // r5.w <- lightVectorLength

#line 380
  div r13.xyz, r13.xyzx, r5.wwww  // r13.x <- lightVectorNorm.x; r13.y <- lightVectorNorm.y; r13.z <- lightVectorNorm.z

#line 333
  max r5.w, r4.w, l(0.000100)
  div r5.w, l(1.000000, 1.000000, 1.000000, 1.000000), r5.w  // r5.w <- attenuation

#line 285
  mul r4.w, r14.w, r4.w  // r4.w <- factor

#line 286
  mad r4.w, -r4.w, r4.w, l(1.000000)
  max r4.w, r4.w, l(0.000000)  // r4.w <- smoothFactor

#line 287
  mul r4.w, r4.w, r4.w  // r4.w <- <SmoothDistanceAttenuation_id68 return value>

#line 334
  mul r4.w, r4.w, r5.w  // r4.w <- attenuation

#line 325
  dp3 r5.w, -r15.xyzx, r13.xyzx  // r5.w <- cd

#line 326
  mad_sat r5.w, r5.w, r14.x, r14.y  // r5.w <- attenuation

#line 327
  mul r5.w, r5.w, r5.w

#line 386
  mul r4.w, r4.w, r5.w  // r4.w <- attenuation

#line 736
  dp3 r5.w, r7.xyzx, r13.xyzx
  max r5.w, r5.w, l(0.000100)  // r5.w <- streams.NdotL_id49

#line 738
  mul r14.xyz, r4.wwww, r16.xyzx
  mul r14.xyz, r5.wwww, r14.xyzx  // r14.x <- streams.lightColorNdotL_id44.x; r14.y <- streams.lightColorNdotL_id44.y; r14.z <- streams.lightColorNdotL_id44.z

#line 771
  add r15.xyz, r8.xyzx, r13.xyzx
  dp3 r4.w, r15.xyzx, r15.xyzx
  rsq r4.w, r4.w
  mul r15.xyz, r4.wwww, r15.xyzx  // r15.x <- streams.H_id75.x; r15.y <- streams.H_id75.y; r15.z <- streams.H_id75.z

#line 773
  dp3_sat r4.w, r13.xyzx, r15.xyzx  // r4.w <- streams.LdotH_id77

#line 767
  mul r13.xyz, r9.xyzx, r14.xyzx

#line 917
  mad r13.xyz, r13.xyzx, l(0.318310, 0.318310, 0.318310, 0.000000), r11.xyzx  // r13.x <- directLightingContribution.x; r13.y <- directLightingContribution.y; r13.z <- directLightingContribution.z

#line 396
  add r15.xyz, -r10.xyzx, l(1.000000, 1.000000, 1.000000, 0.000000)
  add r4.w, -r4.w, l(1.000000)
  mul r6.w, r4.w, r4.w
  mul r6.w, r6.w, r6.w
  mul r4.w, r4.w, r6.w
  mad r15.xyz, r15.xyzx, r4.wwww, r10.xyzx  // r15.x <- <FresnelSchlick_id135 return value>.x; r15.y <- <FresnelSchlick_id135 return value>.y; r15.z <- <FresnelSchlick_id135 return value>.z

#line 392
  mad r4.w, r5.w, l(0.500000), l(0.500000)
  div r4.w, r5.w, r4.w  // r4.w <- <VisibilityhSchlickGGX_id151 return value>
  mad r6.w, r1.w, l(0.500000), l(0.500000)
  div r6.w, r1.w, r6.w  // r6.w <- <VisibilityhSchlickGGX_id151 return value>

#line 491
  mul r4.w, r4.w, r6.w
  mul r5.w, r1.w, r5.w
  div r4.w, r4.w, r5.w  // r4.w <- <VisibilitySmithSchlickGGX_id153 return value>

#line 761
  mul r15.xyz, r4.wwww, r15.xyzx
  mul r14.xyz, r14.xyzx, r15.xyzx

#line 921
  mad r11.xyz, r14.xyzx, l(0.079577, 0.079577, 0.079577, 0.000000), r13.xyzx  // r11.x <- directLightingContribution.x; r11.y <- directLightingContribution.y; r11.z <- directLightingContribution.z

#line 907
  iadd r3.w, r3.w, l(1)

#line 923
endloop   // r2.w <- streams.lightIndex_id93

#line 593
mov r6.x, l(0)
sample_l_indexable(texture2d)(float,float,float,float) r0.xy, r6.xyxx, t1.xyzw, s0, l(0.000000)  // r0.x <- environmentLightingDFG.x; r0.y <- environmentLightingDFG.y

#line 594
mad r0.xyz, r3.xyzx, r0.xxxx, r0.yyyy  // r0.x <- <Compute_id310 return value>.x; r0.y <- <Compute_id310 return value>.y; r0.z <- <Compute_id310 return value>.z

#line 719
mul r3.xyz, r0.xyzx, cb2[26].xyzx  // r3.x <- <ComputeEnvironmentLightContribution_id489 return value>.x; r3.y <- <ComputeEnvironmentLightContribution_id489 return value>.y; r3.z <- <ComputeEnvironmentLightContribution_id489 return value>.z

#line 935
mad r3.xyz, r4.xyzx, cb2[26].xyzx, r3.xyzx  // r3.x <- environmentLightingContribution.x; r3.y <- environmentLightingContribution.y; r3.z <- environmentLightingContribution.z

#line 708
dp3 r0.w, r1.xyzx, cb2[36].xyzx  // r0.w <- sampleDirection.x
dp3 r1.w, r1.xyzx, cb2[37].xyzx  // r1.w <- sampleDirection.y
dp3 r2.w, r1.xyzx, cb2[38].xyzx  // r2.w <- sampleDirection.z

#line 456
mul r3.w, r1.w, r1.w  // r3.w <- y2

#line 457
mul r4.w, r2.w, r2.w  // r4.w <- z2

#line 461
mad r6.xyz, cb2[28].xyzx, r1.wwww, cb2[27].xyzx  // r6.x <- color.x; r6.y <- color.y; r6.z <- color.z

#line 462
mad r6.xyz, cb2[29].xyzx, -r2.wwww, r6.xyzx

#line 463
mad r6.xyz, cb2[30].xyzx, r0.wwww, r6.xyzx

#line 466
mul r7.xyz, r1.wwww, cb2[31].xyzx
mad r6.xyz, r7.xyzx, r0.wwww, r6.xyzx

#line 467
mul r7.xyz, r1.wwww, cb2[32].xyzx
mad r6.xyz, r7.xyzx, -r2.wwww, r6.xyzx

#line 468
mad r1.w, r4.w, l(3.000000), l(-1.000000)
mad r6.xyz, cb2[33].xyzx, r1.wwww, r6.xyzx

#line 469
mul r7.xyz, r0.wwww, cb2[34].xyzx
mad r6.xyz, r7.xyzx, -r2.wwww, r6.xyzx

#line 470
mad r0.w, r0.w, r0.w, -r3.w
mad r6.xyz, cb2[35].xyzx, r0.wwww, r6.xyzx

#line 710
mul r6.xyz, r6.xyzx, cb2[40].xxxx  // r6.x <- streams.envLightDiffuseColor_id47.x; r6.y <- streams.envLightDiffuseColor_id47.y; r6.z <- streams.envLightDiffuseColor_id47.z

#line 711
dp3 r0.w, -r2.xyzx, r1.xyzx
add r0.w, r0.w, r0.w
mad r1.xyz, r1.xyzx, -r0.wwww, -r2.xyzx  // r1.x <- sampleDirection.x; r1.y <- sampleDirection.y; r1.z <- sampleDirection.z

#line 712
dp3 r2.x, r1.xyzx, cb2[36].xyzx  // r2.x <- sampleDirection.x
dp3 r2.y, r1.xyzx, cb2[37].xyzx  // r2.y <- sampleDirection.y
dp3 r0.w, r1.xyzx, cb2[38].xyzx  // r0.w <- sampleDirection.z

#line 713
mov r2.z, -r0.w  // r2.z <- sampleDirection.z

#line 579
sample_l_indexable(texturecube)(float,float,float,float) r1.xyz, r2.xyzx, t6.xyzw, s0, cb2[35].w  // r1.x <- <Compute_id218 return value>.x; r1.y <- <Compute_id218 return value>.y; r1.z <- <Compute_id218 return value>.z

#line 714
mul r1.xyz, r1.xyzx, cb2[40].xxxx  // r1.x <- streams.envLightSpecularColor_id48.x; r1.y <- streams.envLightSpecularColor_id48.y; r1.z <- streams.envLightSpecularColor_id48.z

#line 943
mad r2.xyz, r4.xyzx, r6.xyzx, r3.xyzx  // r2.x <- environmentLightingContribution.x; r2.y <- environmentLightingContribution.y; r2.z <- environmentLightingContribution.z

#line 947
mad r0.xyz, r0.xyzx, r1.xyzx, r2.xyzx  // r0.x <- environmentLightingContribution.x; r0.y <- environmentLightingContribution.y; r0.z <- environmentLightingContribution.z

#line 962
mad r0.xyz, r11.xyzx, l(3.141593, 3.141593, 3.141593, 0.000000), r0.xyzx  // r0.x <- streams.shadingColor_id73.x; r0.y <- streams.shadingColor_id73.y; r0.z <- streams.shadingColor_id73.z

#line 859
mad o0.xyz, r5.xyzx, cb1[3].xxxx, r0.xyzx

#line 1089
utof o1.xyzw, cb0[26].xxxx

#line 1157
mov o0.w, cb1[0].w
ret 
// Approximately 205 instruction slots used
***************************
*************************/
const static int TOrder_id103 = 3;
const static int TOrder_id105 = 3;
const static bool TInvert_id178 = true;
const static float Value_id174 = 1;
const static bool TIsEnergyConservative_id227 = false;
static const float PI_id229 = 3.14159265358979323846;
const static bool TUseAlphaFromEmissive_id239 = false;
struct PS_STREAMS 
{
    float4 ScreenPosition_id86;
    float3 normalWS_id19;
    float4 PositionWS_id22;
    float2 TexCoord_id155;
    float4 ShadingPosition_id0;
    bool IsFrontFace_id1;
    float3 meshNormalWS_id17;
    float3 viewWS_id68;
    float3 shadingColor_id73;
    float matBlend_id40;
    float3 matNormal_id51;
    float4 matColorBase_id52;
    float4 matDiffuse_id53;
    float3 matDiffuseVisible_id69;
    float3 matSpecular_id55;
    float3 matSpecularVisible_id71;
    float matSpecularIntensity_id56;
    float matGlossiness_id54;
    float alphaRoughness_id70;
    float matAmbientOcclusion_id57;
    float matAmbientOcclusionDirectLightingFactor_id58;
    float matCavity_id59;
    float matCavityDiffuse_id60;
    float matCavitySpecular_id61;
    float4 matEmissive_id62;
    float matEmissiveIntensity_id63;
    float matScatteringStrength_id64;
    float2 matDiffuseSpecularAlphaBlend_id65;
    float3 matAlphaBlendColor_id66;
    float matAlphaDiscard_id67;
    float shadingColorAlpha_id74;
    float2 Input_2_id185;
    float2 Plus_3_id188;
    float2 Input_5_id193;
    float2 Multiply_6_id196;
    float2 Input_7_id200;
    float2 Plus_8_id203;
    float4 TextureValue_9_id207;
    float Input_10_id217;
    float3 lightPositionWS_id41;
    float3 lightDirectionWS_id42;
    float3 lightColor_id43;
    float3 lightColorNdotL_id44;
    float3 lightSpecularColorNdotL_id45;
    float lightAttenuation_id46;
    float3 envLightDiffuseColor_id47;
    float3 envLightSpecularColor_id48;
    float lightDirectAmbientOcclusion_id50;
    float NdotL_id49;
    float NdotV_id72;
    uint2 lightData_id92;
    int lightIndex_id93;
    float thicknessWS_id85;
    float3 shadowColor_id84;
    float3 H_id75;
    float NdotH_id76;
    float LdotH_id77;
    float VdotH_id78;
    float4 ColorTarget_id2;
    float4 ColorTarget1_id3;
};
struct PS_OUTPUT 
{
    float4 ColorTarget_id2 : SV_Target0;
    float4 ColorTarget1_id3 : SV_Target1;
};
struct PS_INPUT 
{
    float4 PositionWS_id22 : POSITION_WS;
    float4 ShadingPosition_id0 : SV_Position;
    float3 normalWS_id19 : NORMALWS;
    float4 ScreenPosition_id86 : SCREENPOSITION_ID86_SEM;
    float2 TexCoord_id155 : TEXCOORD0;
    bool IsFrontFace_id1 : SV_IsFrontFace;
};
struct VS_STREAMS 
{
    float4 Position_id21;
    float3 meshNormal_id16;
    float2 TexCoord_id155;
    float4 PositionH_id24;
    float DepthVS_id23;
    float3 meshNormalWS_id17;
    float4 PositionWS_id22;
    float4 ShadingPosition_id0;
    float3 normalWS_id19;
    float4 ScreenPosition_id86;
};
struct VS_OUTPUT 
{
    float4 PositionWS_id22 : POSITION_WS;
    float4 ShadingPosition_id0 : SV_Position;
    float3 normalWS_id19 : NORMALWS;
    float4 ScreenPosition_id86 : SCREENPOSITION_ID86_SEM;
    float2 TexCoord_id155 : TEXCOORD0;
};
struct VS_INPUT 
{
    float4 Position_id21 : POSITION;
    float3 meshNormal_id16 : NORMAL;
    float2 TexCoord_id155 : TEXCOORD0;
};
struct PointLightData 
{
    float3 PositionWS;
    float InvSquareRadius;
    float3 Color;
};
struct PointLightDataInternal 
{
    float3 PositionWS;
    float InvSquareRadius;
    float3 Color;
};
struct SpotLightDataInternal 
{
    float3 PositionWS;
    float3 DirectionWS;
    float3 AngleOffsetAndInvSquareRadius;
    float3 Color;
};
struct SpotLightData 
{
    float3 PositionWS;
    float3 DirectionWS;
    float3 AngleOffsetAndInvSquareRadius;
    float3 Color;
};
cbuffer PerDraw 
{
    float4x4 World_id32;
    float4x4 WorldInverse_id33;
    float4x4 WorldInverseTranspose_id34;
    float4x4 WorldView_id35;
    float4x4 WorldViewInverse_id36;
    float4x4 WorldViewProjection_id37;
    float3 WorldScale_id38;
    float4 EyeMS_id39;
    uint MaterialIndex_id83;
};
cbuffer PerMaterial 
{
    float4 constantColor_id171;
    float constantFloat_id180;
    float2 InputValue_id186;
    float2 InputValue_id194;
    float2 InputValue_id201;
    float InputValue_id218;
};
cbuffer PerView 
{
    float4x4 View_id25;
    float4x4 ViewInverse_id26;
    float4x4 Projection_id27;
    float4x4 ProjectionInverse_id28;
    float4x4 ViewProjection_id29;
    float2 ProjScreenRay_id30;
    float4 Eye_id31;
    float NearClipPlane_id87 = 1.0f;
    float FarClipPlane_id88 = 100.0f;
    float2 ZProjection_id89;
    float2 ViewSize_id90;
    float AspectRatio_id91;
    float4 _padding_PerView_Default;
    float ClusterDepthScale_id96;
    float ClusterDepthBias_id97;
    float2 ClusterStride_id98;
    float3 AmbientLight_id101;
    float3 SphericalColors_id106[TOrder_id105 * TOrder_id105];
    float MipCount_id165;
    float4x4 SkyMatrix_id167;
    float Intensity_id168;
    float4 _padding_PerView_Lighting;
};
cbuffer Globals 
{
    float2 Texture0TexelSize_id108;
    float2 Texture1TexelSize_id110;
    float2 Texture2TexelSize_id112;
    float2 Texture3TexelSize_id114;
    float2 Texture4TexelSize_id116;
    float2 Texture5TexelSize_id118;
    float2 Texture6TexelSize_id120;
    float2 Texture7TexelSize_id122;
    float2 Texture8TexelSize_id124;
    float2 Texture9TexelSize_id126;
};
Texture2D Texture0_id107;
Texture2D Texture1_id109;
Texture2D Texture2_id111;
Texture2D Texture3_id113;
Texture2D Texture4_id115;
Texture2D Texture5_id117;
Texture2D Texture6_id119;
Texture2D Texture7_id121;
Texture2D Texture8_id123;
Texture2D Texture9_id125;
TextureCube TextureCube0_id127;
TextureCube TextureCube1_id128;
TextureCube TextureCube2_id129;
TextureCube TextureCube3_id130;
Texture3D Texture3D0_id131;
Texture3D Texture3D1_id132;
Texture3D Texture3D2_id133;
Texture3D Texture3D3_id134;
SamplerState Sampler_id135;
SamplerState PointSampler_id136 
{
    Filter = MIN_MAG_MIP_POINT;
};
SamplerState LinearSampler_id137 
{
    Filter = MIN_MAG_MIP_LINEAR;
};
SamplerState LinearBorderSampler_id138 
{
    Filter = MIN_MAG_MIP_LINEAR;
    AddressU = Border;
    AddressV = Border;
};
SamplerComparisonState LinearClampCompareLessEqualSampler_id139 
{
    Filter = COMPARISON_MIN_MAG_LINEAR_MIP_POINT;
    AddressU = Clamp;
    AddressV = Clamp;
    ComparisonFunc = LessEqual;
};
SamplerState AnisotropicSampler_id140 
{
    Filter = ANISOTROPIC;
};
SamplerState AnisotropicRepeatSampler_id141 
{
    Filter = ANISOTROPIC;
    AddressU = Wrap;
    AddressV = Wrap;
    MaxAnisotropy = 16;
};
SamplerState PointRepeatSampler_id142 
{
    Filter = MIN_MAG_MIP_POINT;
    AddressU = Wrap;
    AddressV = Wrap;
};
SamplerState LinearRepeatSampler_id143 
{
    Filter = MIN_MAG_MIP_LINEAR;
    AddressU = Wrap;
    AddressV = Wrap;
};
SamplerState RepeatSampler_id144 
{
    AddressU = Wrap;
    AddressV = Wrap;
};
SamplerState Sampler0_id145;
SamplerState Sampler1_id146;
SamplerState Sampler2_id147;
SamplerState Sampler3_id148;
SamplerState Sampler4_id149;
SamplerState Sampler5_id150;
SamplerState Sampler6_id151;
SamplerState Sampler7_id152;
SamplerState Sampler8_id153;
SamplerState Sampler9_id154;
Texture2D DynamicTexture_id208;
SamplerState DynamicSampler_id209;
Texture2D EnvironmentLightingDFG_LUT_id230;
Texture3D<uint2> LightClusters_id94;
Buffer<uint> LightIndices_id95;
Buffer<float4> PointLights_id99;
Buffer<float4> SpotLights_id100;
TextureCube CubeMap_id166;
float SmoothDistanceAttenuation_id68(float squaredDistance, float lightInvSquareRadius)
{
    float factor = squaredDistance * lightInvSquareRadius;
    float smoothFactor = saturate(1.0f - factor * factor);
    return smoothFactor * smoothFactor;
}
float SmoothDistanceAttenuation_id57(float squaredDistance, float lightInvSquareRadius)
{
    float factor = squaredDistance * lightInvSquareRadius;
    float smoothFactor = saturate(1.0f - factor * factor);
    return smoothFactor * smoothFactor;
}
float2 Compute_id269(inout PS_STREAMS streams)
{
    return streams.Plus_8_id203;
}
float2 Compute_id265(inout PS_STREAMS streams)
{
    return streams.Input_7_id200;
}
float2 Compute_id263(inout PS_STREAMS streams)
{
    return streams.Multiply_6_id196;
}
float2 Compute_id257(inout PS_STREAMS streams)
{
    return streams.Input_5_id193;
}
float2 Compute_id255(inout PS_STREAMS streams)
{
    return streams.Plus_3_id188;
}
float2 Compute_id249(inout PS_STREAMS streams)
{
    return streams.Input_2_id185;
}
float2 Compute_id247(inout PS_STREAMS streams)
{
    return streams.TexCoord_id155;
}
float GetAngularAttenuation_id70(float3 lightVector, float3 lightDirection, float lightAngleScale, float lightAngleOffset)
{
    float cd = dot(lightDirection, lightVector);
    float attenuation = saturate(cd * lightAngleScale + lightAngleOffset);
    attenuation *= attenuation;
    return attenuation;
}
float GetDistanceAttenuation_id69(float lightVectorLength, float lightInvSquareRadius)
{
    float d2 = lightVectorLength * lightVectorLength;
    float attenuation = 1.0 / (max(d2, 0.01 * 0.01));
    attenuation *= SmoothDistanceAttenuation_id68(d2, lightInvSquareRadius);
    return attenuation;
}
float GetDistanceAttenuation_id59(float lightVectorLength, float lightInvSquareRadius)
{
    float d2 = lightVectorLength * lightVectorLength;
    float attenuation = 1.0 / (max(d2, 0.01 * 0.01));
    attenuation *= SmoothDistanceAttenuation_id57(d2, lightInvSquareRadius);
    return attenuation;
}
float Compute_id298()
{
    return InputValue_id218;
}
float4 Compute_id272(inout PS_STREAMS streams)
{
    return DynamicTexture_id208.Sample(DynamicSampler_id209, Compute_id269(streams));
}
float2 Compute_id268(inout PS_STREAMS streams)
{
    return Compute_id263(streams) + Compute_id265(streams);
}
float2 Compute_id261()
{
    return InputValue_id201;
}
float2 Compute_id260(inout PS_STREAMS streams)
{
    return Compute_id255(streams) * Compute_id257(streams);
}
float2 Compute_id253()
{
    return InputValue_id194;
}
float2 Compute_id252(inout PS_STREAMS streams)
{
    return Compute_id247(streams) + Compute_id249(streams);
}
float2 Compute_id245()
{
    return InputValue_id186;
}
float ComputeAttenuation_id71(float3 PositionWS, float3 AngleOffsetAndInvSquareRadius, float3 DirectionWS, float3 position, inout float3 lightVectorNorm)
{
    float3 lightVector = PositionWS - position;
    float lightVectorLength = length(lightVector);
    lightVectorNorm = lightVector / lightVectorLength;
    float3 lightAngleOffsetAndInvSquareRadius = AngleOffsetAndInvSquareRadius;
    float2 lightAngleAndOffset = lightAngleOffsetAndInvSquareRadius.xy;
    float lightInvSquareRadius = lightAngleOffsetAndInvSquareRadius.z;
    float3 lightDirection = -DirectionWS;
    float attenuation = GetDistanceAttenuation_id69(lightVectorLength, lightInvSquareRadius);
    attenuation *= GetAngularAttenuation_id70(lightVectorNorm, lightDirection, lightAngleAndOffset.x, lightAngleAndOffset.y);
    return attenuation;
}
float VisibilityhSchlickGGX_id151(float alphaR, float nDotX)
{
    float k = alphaR * 0.5f;
    return nDotX / (nDotX * (1.0f - k) + k);
}
float3 FresnelSchlick_id135(float3 f0, float3 f90, float lOrVDotH)
{
    return f0 + (f90 - f0) * pow((1 - lOrVDotH), 5);
}
float ComputeAttenuation_id58(PointLightDataInternal light, float3 position, inout float3 lightVectorNorm)
{
    float3 lightVector = light.PositionWS - position;
    float lightVectorLength = length(lightVector);
    lightVectorNorm = lightVector / lightVectorLength;
    float lightInvSquareRadius = light.InvSquareRadius;
    return GetDistanceAttenuation_id59(lightVectorLength, lightInvSquareRadius);
}
void Compute_id301(inout PS_STREAMS streams)
{
    streams.Input_10_id217 = Compute_id298();
}
void Compute_id289(inout PS_STREAMS streams)
{
    streams.TextureValue_9_id207 = Compute_id272(streams);
}
void Compute_id287(inout PS_STREAMS streams)
{
    streams.Plus_8_id203 = Compute_id268(streams);
}
void Compute_id285(inout PS_STREAMS streams)
{
    streams.Input_7_id200 = Compute_id261();
}
void Compute_id283(inout PS_STREAMS streams)
{
    streams.Multiply_6_id196 = Compute_id260(streams);
}
void Compute_id281(inout PS_STREAMS streams)
{
    streams.Input_5_id193 = Compute_id253();
}
void Compute_id279(inout PS_STREAMS streams)
{
    streams.Plus_3_id188 = Compute_id252(streams);
}
void Compute_id277(inout PS_STREAMS streams)
{
    streams.Input_2_id185 = Compute_id245();
}
void Compute_id275()
{
}
void Compute_id274()
{
}
void Compute_id273()
{
}
void Compute_id234()
{
}
float4 EvaluateSphericalHarmonics_id81(float3 sphericalColors[TOrder_id103 * TOrder_id103], float3 direction)
{
    float x = direction.x;
    float y = direction.y;
    float z = direction.z;
    float x2 = x * x;
    float y2 = y * y;
    float z2 = z * z;
    float3 color = sphericalColors[0];

    {
        color += sphericalColors[1] * y;
        color += sphericalColors[2] * z;
        color += sphericalColors[3] * x;

        {
            color += sphericalColors[4] * y * x;
            color += sphericalColors[5] * y * z;
            color += sphericalColors[6] * (3.0 * z2 - 1.0);
            color += sphericalColors[7] * x * z;
            color += sphericalColors[8] * (x2 - y2);
        }
    }
    return float4(color, 1);
}
void ProcessLight_id72(inout PS_STREAMS streams, SpotLightDataInternal light)
{
    float3 lightVectorNorm;
    float attenuation = ComputeAttenuation_id71(light.PositionWS, light.AngleOffsetAndInvSquareRadius, light.DirectionWS, streams.PositionWS_id22.xyz, lightVectorNorm);
    streams.lightColor_id43 = light.Color;
    streams.lightAttenuation_id46 = attenuation;
    streams.lightDirectionWS_id42 = lightVectorNorm;
}
float NormalDistributionGGX_id165(float alphaR, float nDotH)
{
    float alphaR2 = alphaR * alphaR;
    float d = max(nDotH * nDotH * (alphaR2 - 1) + 1, 0.0001);
    return alphaR2 / (PI_id229 * d * d);
}
float VisibilitySmithSchlickGGX_id153(float alphaR, float nDotL, float nDotV)
{
    return VisibilityhSchlickGGX_id151(alphaR, nDotL) * VisibilityhSchlickGGX_id151(alphaR, nDotV) / (nDotL * nDotV);
}
float3 FresnelSchlick_id141(float3 f0, float lOrVDotH)
{
    return FresnelSchlick_id135(f0, 1.0f, lOrVDotH);
}
void ProcessLight_id61(inout PS_STREAMS streams, PointLightDataInternal light)
{
    float3 lightVectorNorm;
    float attenuation = ComputeAttenuation_id58(light, streams.PositionWS_id22.xyz, lightVectorNorm);
    streams.lightPositionWS_id41 = light.PositionWS;
    streams.lightColor_id43 = light.Color;
    streams.lightAttenuation_id46 = attenuation;
    streams.lightDirectionWS_id42 = lightVectorNorm;
}
float Compute_id304(inout PS_STREAMS streams)
{
    return streams.Input_10_id217;
}
void Compute_id303(inout PS_STREAMS streams)
{

    {
        Compute_id301(streams);
    }
}
float4 Compute_id292(inout PS_STREAMS streams)
{
    return streams.TextureValue_9_id207;
}
void Compute_id291(inout PS_STREAMS streams)
{

    {
        Compute_id273();
    }

    {
        Compute_id274();
    }

    {
        Compute_id275();
    }

    {
        Compute_id277(streams);
    }

    {
        Compute_id279(streams);
    }

    {
        Compute_id281(streams);
    }

    {
        Compute_id283(streams);
    }

    {
        Compute_id285(streams);
    }

    {
        Compute_id287(streams);
    }

    {
        Compute_id289(streams);
    }
}
float Compute_id237()
{
    return Value_id174;
}
void Compute_id236()
{

    {
        Compute_id234();
    }
}
float4 Compute_id218(inout PS_STREAMS streams, float3 direction)
{
    float alpha = streams.alphaRoughness_id70;
    float mipLevel = sqrt(alpha) * MipCount_id165;
    return CubeMap_id166.SampleLevel(LinearSampler_id137, direction, mipLevel);
}
float4 Compute_id213(float3 direction)
{
    return EvaluateSphericalHarmonics_id81(SphericalColors_id106, direction);
}
void PrepareEnvironmentLight_id85(inout PS_STREAMS streams)
{
    streams.envLightDiffuseColor_id47 = 0;
    streams.envLightSpecularColor_id48 = 0;
}
float3 Compute_id310(float3 specularColor, float alphaR, float nDotV)
{
    float glossiness = 1.0f - sqrt(alphaR);
    float4 environmentLightingDFG = EnvironmentLightingDFG_LUT_id230.SampleLevel(LinearSampler_id137, float2(glossiness, nDotV), 0);
    return specularColor * environmentLightingDFG.r + environmentLightingDFG.g;
}
void PrepareEnvironmentLight_id76(inout PS_STREAMS streams)
{
    streams.envLightDiffuseColor_id47 = 0;
    streams.envLightSpecularColor_id48 = 0;
}
float3 ComputeSpecularTextureProjection_id67(float3 positionWS, float3 reflectionWS, int lightIndex)
{
    return 1.0f;
}
float3 ComputeTextureProjection_id66(float3 positionWS, int lightIndex)
{
    return 1.0f;
}
float3 ComputeShadow_id65(inout PS_STREAMS streams, float3 position, int lightIndex)
{
    streams.thicknessWS_id85 = 0.0;
    return 1.0f;
}
void PrepareDirectLightCore_id64(inout PS_STREAMS streams, int lightIndexIgnored)
{
    int realLightIndex = LightIndices_id95.Load(streams.lightIndex_id93);
    streams.lightIndex_id93++;
    SpotLightDataInternal spotLight;
    float4 spotLight1 = SpotLights_id100.Load(realLightIndex * 4);
    float4 spotLight2 = SpotLights_id100.Load(realLightIndex * 4 + 1);
    float4 spotLight3 = SpotLights_id100.Load(realLightIndex * 4 + 2);
    float4 spotLight4 = SpotLights_id100.Load(realLightIndex * 4 + 3);
    spotLight.PositionWS = spotLight1.xyz;
    spotLight.DirectionWS = spotLight2.xyz;
    spotLight.AngleOffsetAndInvSquareRadius = spotLight3.xyz;
    spotLight.Color = spotLight4.xyz;
    ProcessLight_id72(streams, spotLight);
}
float Compute_id402(inout PS_STREAMS streams)
{
    return NormalDistributionGGX_id165(streams.alphaRoughness_id70, streams.NdotH_id76);
}
float Compute_id372(inout PS_STREAMS streams)
{
    return VisibilitySmithSchlickGGX_id153(streams.alphaRoughness_id70, streams.NdotL_id49, streams.NdotV_id72);
}
float3 Compute_id342(inout PS_STREAMS streams, float3 f0)
{
    return FresnelSchlick_id141(f0, streams.LdotH_id77);
}
float3 ComputeSpecularTextureProjection_id56(float3 positionWS, float3 reflectionWS, int lightIndex)
{
    return 1.0f;
}
float3 ComputeTextureProjection_id55(float3 positionWS, int lightIndex)
{
    return 1.0f;
}
float3 ComputeShadow_id54(inout PS_STREAMS streams, float3 position, int lightIndex)
{
    streams.thicknessWS_id85 = 0.0;
    return 1.0f;
}
void PrepareDirectLightCore_id53(inout PS_STREAMS streams, int lightIndexIgnored)
{
    int realLightIndex = LightIndices_id95.Load(streams.lightIndex_id93);
    streams.lightIndex_id93++;
    PointLightDataInternal pointLight;
    float4 pointLight1 = PointLights_id99.Load(realLightIndex * 2);
    float4 pointLight2 = PointLights_id99.Load(realLightIndex * 2 + 1);
    pointLight.PositionWS = pointLight1.xyz;
    pointLight.InvSquareRadius = pointLight1.w;
    pointLight.Color = pointLight2.xyz;
    ProcessLight_id61(streams, pointLight);
}
void PrepareLightData_id60(inout PS_STREAMS streams)
{
    float projectedDepth = streams.ShadingPosition_id0.z;
    float depth = ZProjection_id89.y / (projectedDepth - ZProjection_id89.x);
    float2 texCoord = float2(streams.ScreenPosition_id86.x + 1, 1 - streams.ScreenPosition_id86.y) * 0.5;
    int slice = int(max(log2(depth * ClusterDepthScale_id96 + ClusterDepthBias_id97), 0));
    streams.lightData_id92 = LightClusters_id94.Load(int4(texCoord * ClusterStride_id98, slice, 0));
    streams.lightIndex_id93 = streams.lightData_id92.x;
}
float Compute_id307(inout PS_STREAMS streams)
{
    Compute_id303(streams);
    return Compute_id304(streams);
}
float4 Compute_id295(inout PS_STREAMS streams)
{
    Compute_id291(streams);
    return Compute_id292(streams);
}
float Compute_id240()
{
    Compute_id236();
    return Compute_id237();
}
void ResetStream_id171()
{
}
void AfterLightingAndShading_id459()
{
}
void AfterLightingAndShading_id440()
{
}
void PrepareEnvironmentLight_id231(inout PS_STREAMS streams)
{
    streams.envLightDiffuseColor_id47 = 0;
    streams.envLightSpecularColor_id48 = 0;
}
void PrepareEnvironmentLight_id228(inout PS_STREAMS streams)
{
    PrepareEnvironmentLight_id85(streams);
    float ambientAccessibility = streams.matAmbientOcclusion_id57;
    float3 sampleDirection = mul(streams.normalWS_id19, (float3x3)SkyMatrix_id167);
    sampleDirection = float3(sampleDirection.xy, -sampleDirection.z);
    streams.envLightDiffuseColor_id47 = Compute_id213(sampleDirection).rgb * Intensity_id168 * ambientAccessibility * streams.matDiffuseSpecularAlphaBlend_id65.x;
    sampleDirection = reflect(-streams.viewWS_id68, streams.normalWS_id19);
    sampleDirection = mul(sampleDirection, (float3x3)SkyMatrix_id167);
    sampleDirection = float3(sampleDirection.xy, -sampleDirection.z);
    streams.envLightSpecularColor_id48 = Compute_id218(streams, sampleDirection).rgb * Intensity_id168 * ambientAccessibility * streams.matDiffuseSpecularAlphaBlend_id65.y;
}
float3 ComputeEnvironmentLightContribution_id489(inout PS_STREAMS streams)
{
    float3 specularColor = streams.matSpecularVisible_id71;
    return Compute_id310(specularColor, streams.alphaRoughness_id70, streams.NdotV_id72) * streams.envLightSpecularColor_id48;
}
float3 ComputeEnvironmentLightContribution_id433(inout PS_STREAMS streams)
{
    float3 diffuseColor = streams.matDiffuseVisible_id69;
    return diffuseColor * streams.envLightDiffuseColor_id47;
}
void PrepareEnvironmentLight_id223(inout PS_STREAMS streams)
{
    PrepareEnvironmentLight_id76(streams);
    float3 lightColor = AmbientLight_id101 * streams.matAmbientOcclusion_id57;
    streams.envLightDiffuseColor_id47 = lightColor;
    streams.envLightSpecularColor_id48 = lightColor;
}
void PrepareDirectLight_id194(inout PS_STREAMS streams, int lightIndex)
{
    PrepareDirectLightCore_id64(streams, lightIndex);
    streams.NdotL_id49 = max(dot(streams.normalWS_id19, streams.lightDirectionWS_id42), 0.0001f);
    streams.shadowColor_id84 = ComputeShadow_id65(streams, streams.PositionWS_id22.xyz, lightIndex);
    streams.lightColorNdotL_id44 = streams.lightColor_id43 * streams.lightAttenuation_id46 * streams.shadowColor_id84 * streams.NdotL_id49 * streams.lightDirectAmbientOcclusion_id50;
    streams.lightSpecularColorNdotL_id45 = streams.lightColorNdotL_id44;
    streams.lightColorNdotL_id44 *= ComputeTextureProjection_id66(streams.PositionWS_id22.xyz, lightIndex);
    float3 reflectionVectorWS = reflect(-streams.viewWS_id68, streams.normalWS_id19);
    streams.lightSpecularColorNdotL_id45 *= ComputeSpecularTextureProjection_id67(streams.PositionWS_id22.xyz, reflectionVectorWS, lightIndex);
}
int GetLightCount_id198(inout PS_STREAMS streams)
{
    return streams.lightData_id92.y >> 16;
}
int GetMaxLightCount_id197(inout PS_STREAMS streams)
{
    return streams.lightData_id92.y >> 16;
}
void PrepareDirectLights_id192()
{
}
float3 ComputeDirectLightContribution_id488(inout PS_STREAMS streams)
{
    float3 specularColor = streams.matSpecularVisible_id71;
    float3 fresnel = Compute_id342(streams, specularColor);
    float geometricShadowing = Compute_id372(streams);
    float normalDistribution = Compute_id402(streams);
    float3 reflected = fresnel * geometricShadowing * normalDistribution / 4;
    return reflected * streams.lightSpecularColorNdotL_id45 * streams.matDiffuseSpecularAlphaBlend_id65.y;
}
float3 ComputeDirectLightContribution_id432(inout PS_STREAMS streams)
{
    float3 diffuseColor = streams.matDiffuseVisible_id69;
    return diffuseColor / PI_id229 * streams.lightColorNdotL_id44 * streams.matDiffuseSpecularAlphaBlend_id65.x;
}
void PrepareMaterialPerDirectLight_id30(inout PS_STREAMS streams)
{
    streams.H_id75 = normalize(streams.viewWS_id68 + streams.lightDirectionWS_id42);
    streams.NdotH_id76 = saturate(dot(streams.normalWS_id19, streams.H_id75));
    streams.LdotH_id77 = saturate(dot(streams.lightDirectionWS_id42, streams.H_id75));
    streams.VdotH_id78 = streams.LdotH_id77;
}
void PrepareDirectLight_id181(inout PS_STREAMS streams, int lightIndex)
{
    PrepareDirectLightCore_id53(streams, lightIndex);
    streams.NdotL_id49 = max(dot(streams.normalWS_id19, streams.lightDirectionWS_id42), 0.0001f);
    streams.shadowColor_id84 = ComputeShadow_id54(streams, streams.PositionWS_id22.xyz, lightIndex);
    streams.lightColorNdotL_id44 = streams.lightColor_id43 * streams.lightAttenuation_id46 * streams.shadowColor_id84 * streams.NdotL_id49 * streams.lightDirectAmbientOcclusion_id50;
    streams.lightSpecularColorNdotL_id45 = streams.lightColorNdotL_id44;
    streams.lightColorNdotL_id44 *= ComputeTextureProjection_id55(streams.PositionWS_id22.xyz, lightIndex);
    float3 reflectionVectorWS = reflect(-streams.viewWS_id68, streams.normalWS_id19);
    streams.lightSpecularColorNdotL_id45 *= ComputeSpecularTextureProjection_id56(streams.PositionWS_id22.xyz, reflectionVectorWS, lightIndex);
}
int GetLightCount_id186(inout PS_STREAMS streams)
{
    return streams.lightData_id92.y & 0xFFFF;
}
int GetMaxLightCount_id185(inout PS_STREAMS streams)
{
    return streams.lightData_id92.y & 0xFFFF;
}
void PrepareDirectLights_id184(inout PS_STREAMS streams)
{
    PrepareLightData_id60(streams);
}
void PrepareForLightingAndShading_id456()
{
}
void PrepareForLightingAndShading_id437()
{
}
void PrepareMaterialForLightingAndShading_id167(inout PS_STREAMS streams)
{
    streams.lightDirectAmbientOcclusion_id50 = lerp(1.0, streams.matAmbientOcclusion_id57, streams.matAmbientOcclusionDirectLightingFactor_id58);
    streams.matDiffuseVisible_id69 = streams.matDiffuse_id53.rgb * lerp(1.0f, streams.matCavity_id59, streams.matCavityDiffuse_id60) * streams.matDiffuseSpecularAlphaBlend_id65.r * streams.matAlphaBlendColor_id66;
    streams.matSpecularVisible_id71 = streams.matSpecular_id55.rgb * streams.matSpecularIntensity_id56 * lerp(1.0f, streams.matCavity_id59, streams.matCavitySpecular_id61) * streams.matDiffuseSpecularAlphaBlend_id65.g * streams.matAlphaBlendColor_id66;
    streams.NdotV_id72 = max(dot(streams.normalWS_id19, streams.viewWS_id68), 0.0001f);
    float roughness = 1.0f - streams.matGlossiness_id54;
    streams.alphaRoughness_id70 = max(roughness * roughness, 0.001);
}
void ResetLightStream_id166(inout PS_STREAMS streams)
{
    streams.lightPositionWS_id41 = 0;
    streams.lightDirectionWS_id42 = 0;
    streams.lightColor_id43 = 0;
    streams.lightColorNdotL_id44 = 0;
    streams.lightSpecularColorNdotL_id45 = 0;
    streams.lightAttenuation_id46 = 1.0f;
    streams.envLightDiffuseColor_id47 = 0;
    streams.envLightSpecularColor_id48 = 0;
    streams.lightDirectAmbientOcclusion_id50 = 1.0f;
    streams.NdotL_id49 = 0;
}
void UpdateNormalFromTangentSpace_id23(float3 normalInTangentSpace)
{
}
float4 Compute_id309(inout PS_STREAMS streams)
{
    float x = Compute_id307(streams);
    return float4(x, x, x, x);
}
float4 Compute_id297(inout PS_STREAMS streams)
{
    return Compute_id295(streams);
}
float4 Compute_id243()
{
    return float4(constantFloat_id180, constantFloat_id180, constantFloat_id180, constantFloat_id180);
}
float4 Compute_id242()
{
    float x = Compute_id240();
    return float4(x, x, x, x);
}
float4 Compute_id232()
{
    return constantColor_id171;
}
void ResetStream_id172(inout PS_STREAMS streams)
{
    ResetStream_id171();
    streams.matBlend_id40 = 0.0f;
}
void Compute_id531(inout PS_STREAMS streams)
{
    streams.shadingColor_id73 += streams.matEmissive_id62.rgb * streams.matEmissiveIntensity_id63;
}
void Compute_id530(inout PS_STREAMS streams)
{
    UpdateNormalFromTangentSpace_id23(streams.matNormal_id51);
    if (!streams.IsFrontFace_id1)
        streams.normalWS_id19 = -streams.normalWS_id19;
    ResetLightStream_id166(streams);
    PrepareMaterialForLightingAndShading_id167(streams);

    {
        PrepareForLightingAndShading_id437();
    }

    {
        PrepareForLightingAndShading_id456();
    }
    float3 directLightingContribution = 0;

    {
        PrepareDirectLights_id184(streams);
        const int maxLightCount = GetMaxLightCount_id185(streams);
        int count = GetLightCount_id186(streams);

        for (int i = 0; i < maxLightCount; i++)
        {
            if (i >= count)
            {
                break;
            }
            PrepareDirectLight_id181(streams, i);
            PrepareMaterialPerDirectLight_id30(streams);

            {
                directLightingContribution += ComputeDirectLightContribution_id432(streams);
            }

            {
                directLightingContribution += ComputeDirectLightContribution_id488(streams);
            }
        }
    }

    {
        PrepareDirectLights_id192();
        const int maxLightCount = GetMaxLightCount_id197(streams);
        int count = GetLightCount_id198(streams);

        for (int i = 0; i < maxLightCount; i++)
        {
            if (i >= count)
            {
                break;
            }
            PrepareDirectLight_id194(streams, i);
            PrepareMaterialPerDirectLight_id30(streams);

            {
                directLightingContribution += ComputeDirectLightContribution_id432(streams);
            }

            {
                directLightingContribution += ComputeDirectLightContribution_id488(streams);
            }
        }
    }
    float3 environmentLightingContribution = 0;

    {
        PrepareEnvironmentLight_id223(streams);

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id433(streams);
        }

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id489(streams);
        }
    }

    {
        PrepareEnvironmentLight_id228(streams);

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id433(streams);
        }

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id489(streams);
        }
    }

    {
        PrepareEnvironmentLight_id231(streams);

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id433(streams);
        }

        {
            environmentLightingContribution += ComputeEnvironmentLightContribution_id489(streams);
        }
    }
    streams.shadingColor_id73 += directLightingContribution * PI_id229 + environmentLightingContribution;
    streams.shadingColorAlpha_id74 = streams.matDiffuse_id53.a;

    {
        AfterLightingAndShading_id440();
    }

    {
        AfterLightingAndShading_id459();
    }
}
void Compute_id514(inout PS_STREAMS streams)
{
    streams.matEmissiveIntensity_id63 = Compute_id309(streams).r;
}
void Compute_id509(inout PS_STREAMS streams)
{
    streams.matEmissive_id62 = Compute_id297(streams).rgba;
}
void Compute_id504(inout PS_STREAMS streams)
{
    float metalness = Compute_id243().r;
    streams.matSpecular_id55 = lerp(0.02, streams.matDiffuse_id53.rgb, metalness);
    streams.matDiffuse_id53.rgb = lerp(streams.matDiffuse_id53.rgb, 0, metalness);
}
void Compute_id499(inout PS_STREAMS streams)
{
    float glossiness = Compute_id242().r;

    {
        glossiness = 1.0 - glossiness;
    }
    streams.matGlossiness_id54 = glossiness;
}
void Compute_id494(inout PS_STREAMS streams)
{
    float4 colorBase = Compute_id232();
    streams.matDiffuse_id53 = colorBase;
    streams.matColorBase_id52 = colorBase;
}
void ResetStream_id173(inout PS_STREAMS streams)
{
    ResetStream_id172(streams);
    streams.matNormal_id51 = float3(0, 0, 1);
    streams.matColorBase_id52 = 0.0f;
    streams.matDiffuse_id53 = 0.0f;
    streams.matDiffuseVisible_id69 = 0.0f;
    streams.matSpecular_id55 = 0.0f;
    streams.matSpecularVisible_id71 = 0.0f;
    streams.matSpecularIntensity_id56 = 1.0f;
    streams.matGlossiness_id54 = 0.0f;
    streams.alphaRoughness_id70 = 1.0f;
    streams.matAmbientOcclusion_id57 = 1.0f;
    streams.matAmbientOcclusionDirectLightingFactor_id58 = 0.0f;
    streams.matCavity_id59 = 1.0f;
    streams.matCavityDiffuse_id60 = 0.0f;
    streams.matCavitySpecular_id61 = 0.0f;
    streams.matEmissive_id62 = 0.0f;
    streams.matEmissiveIntensity_id63 = 0.0f;
    streams.matScatteringStrength_id64 = 1.0f;
    streams.matDiffuseSpecularAlphaBlend_id65 = 1.0f;
    streams.matAlphaBlendColor_id66 = 1.0f;
    streams.matAlphaDiscard_id67 = 0.1f;
}
float4 ComputeShadingPosition_id11(float4 world)
{
    return mul(world, ViewProjection_id29);
}
void PostTransformPosition_id6()
{
}
void PreTransformPosition_id4()
{
}
void Compute_id50(inout PS_STREAMS streams)
{

    {
        Compute_id494(streams);
    }

    {
        Compute_id499(streams);
    }

    {
        Compute_id504(streams);
    }

    {
        Compute_id509(streams);
    }

    {
        Compute_id514(streams);
    }

    {
        Compute_id530(streams);
    }

    {
        Compute_id531(streams);
    }
}
void ResetStream_id49(inout PS_STREAMS streams)
{
    ResetStream_id173(streams);
    streams.shadingColorAlpha_id74 = 1.0f;
}
void PostTransformPosition_id12(inout VS_STREAMS streams)
{
    PostTransformPosition_id6();
    streams.ShadingPosition_id0 = ComputeShadingPosition_id11(streams.PositionWS_id22);
    streams.PositionH_id24 = streams.ShadingPosition_id0;
    streams.DepthVS_id23 = streams.ShadingPosition_id0.w;
}
void TransformPosition_id5()
{
}
void PreTransformPosition_id10(inout VS_STREAMS streams)
{
    PreTransformPosition_id4();
    streams.PositionWS_id22 = mul(streams.Position_id21, World_id32);
}
float4 Compute_id48()
{
    return MaterialIndex_id83;
}
float4 Shading_id31(inout PS_STREAMS streams)
{
    streams.viewWS_id68 = normalize(Eye_id31.xyz - streams.PositionWS_id22.xyz);
    streams.shadingColor_id73 = 0;
    ResetStream_id49(streams);
    Compute_id50(streams);
    return float4(streams.shadingColor_id73, streams.shadingColorAlpha_id74);
}
void PSMain_id1()
{
}
void BaseTransformVS_id8(inout VS_STREAMS streams)
{
    PreTransformPosition_id10(streams);
    TransformPosition_id5();
    PostTransformPosition_id12(streams);
}
void VSMain_id0()
{
}
void PSMain_id3(inout PS_STREAMS streams)
{
    PSMain_id1();
    streams.ColorTarget_id2 = Shading_id31(streams);
    streams.ColorTarget1_id3 = Compute_id48();
}
void GenerateNormal_PS_id22(inout PS_STREAMS streams)
{
    if (dot(streams.normalWS_id19, streams.normalWS_id19) > 0)
        streams.normalWS_id19 = normalize(streams.normalWS_id19);
    streams.meshNormalWS_id17 = streams.normalWS_id19;
}
void GenerateNormal_VS_id21(inout VS_STREAMS streams)
{
    streams.meshNormalWS_id17 = mul(streams.meshNormal_id16, (float3x3)WorldInverseTranspose_id34);
    streams.normalWS_id19 = streams.meshNormalWS_id17;
}
void VSMain_id9(inout VS_STREAMS streams)
{
    VSMain_id0();
    BaseTransformVS_id8(streams);
}
void PSMain_id20(inout PS_STREAMS streams)
{
    GenerateNormal_PS_id22(streams);
    PSMain_id3(streams);
}
void VSMain_id19(inout VS_STREAMS streams)
{
    VSMain_id9(streams);
    GenerateNormal_VS_id21(streams);
}
PS_OUTPUT PSMain(PS_INPUT __input__)
{
    PS_STREAMS streams = (PS_STREAMS)0;
    streams.PositionWS_id22 = __input__.PositionWS_id22;
    streams.ShadingPosition_id0 = __input__.ShadingPosition_id0;
    streams.normalWS_id19 = __input__.normalWS_id19;
    streams.ScreenPosition_id86 = __input__.ScreenPosition_id86;
    streams.TexCoord_id155 = __input__.TexCoord_id155;
    streams.IsFrontFace_id1 = __input__.IsFrontFace_id1;
    streams.ScreenPosition_id86 /= streams.ScreenPosition_id86.w;
    PSMain_id20(streams);
    PS_OUTPUT __output__ = (PS_OUTPUT)0;
    __output__.ColorTarget_id2 = streams.ColorTarget_id2;
    __output__.ColorTarget1_id3 = streams.ColorTarget1_id3;
    return __output__;
}
VS_OUTPUT VSMain(VS_INPUT __input__)
{
    VS_STREAMS streams = (VS_STREAMS)0;
    streams.Position_id21 = __input__.Position_id21;
    streams.meshNormal_id16 = __input__.meshNormal_id16;
    streams.TexCoord_id155 = __input__.TexCoord_id155;
    VSMain_id19(streams);
    streams.ScreenPosition_id86 = streams.ShadingPosition_id0;
    VS_OUTPUT __output__ = (VS_OUTPUT)0;
    __output__.PositionWS_id22 = streams.PositionWS_id22;
    __output__.ShadingPosition_id0 = streams.ShadingPosition_id0;
    __output__.normalWS_id19 = streams.normalWS_id19;
    __output__.ScreenPosition_id86 = streams.ScreenPosition_id86;
    __output__.TexCoord_id155 = streams.TexCoord_id155;
    return __output__;
}
