// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:3,spmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,rprd:True,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:True,dith:0,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:7162,x:34518,y:32570,varname:node_7162,prsc:2|diff-492-OUT,spec-135-OUT,gloss-8270-OUT,emission-8263-OUT,lwrap-8263-OUT,alpha-8339-OUT,refract-2126-OUT;n:type:ShaderForge.SFN_Slider,id:5280,x:33689,y:32577,ptovrint:False,ptlb:spec,ptin:_spec,varname:_spec,prsc:2,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Slider,id:8270,x:32777,y:32899,ptovrint:False,ptlb:gloss,ptin:_gloss,varname:_gloss,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_VertexColor,id:4457,x:32661,y:32584,varname:node_4457,prsc:2;n:type:ShaderForge.SFN_Color,id:7241,x:33086,y:32367,ptovrint:False,ptlb:color override,ptin:_coloroverride,varname:_coloroverride,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:492,x:32963,y:32628,varname:node_492,prsc:2|A-7241-RGB,B-4457-RGB,C-7241-RGB;n:type:ShaderForge.SFN_Fresnel,id:3926,x:33265,y:32715,varname:node_3926,prsc:2|NRM-4693-OUT,EXP-8194-OUT;n:type:ShaderForge.SFN_NormalVector,id:4693,x:33114,y:32844,prsc:2,pt:False;n:type:ShaderForge.SFN_Slider,id:8194,x:32540,y:33122,ptovrint:False,ptlb:exp,ptin:_exp,varname:_exp,prsc:2,min:0,cur:0,max:8;n:type:ShaderForge.SFN_Multiply,id:6476,x:33491,y:32543,varname:node_6476,prsc:2|A-492-OUT,B-3926-OUT;n:type:ShaderForge.SFN_Slider,id:8339,x:33308,y:32880,ptovrint:False,ptlb:opac,ptin:_opac,varname:_opac,prsc:2,min:0,cur:0.2051282,max:1;n:type:ShaderForge.SFN_ValueProperty,id:2335,x:33702,y:32780,ptovrint:False,ptlb:emmis power,ptin:_emmispower,varname:_emmispower,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8263,x:33974,y:32733,varname:node_8263,prsc:2|A-6476-OUT,B-2335-OUT,C-7241-RGB;n:type:ShaderForge.SFN_Multiply,id:2126,x:33663,y:33059,varname:node_2126,prsc:2|A-751-OUT,B-3876-OUT;n:type:ShaderForge.SFN_Slider,id:3876,x:33409,y:33260,ptovrint:False,ptlb:refract,ptin:_refract,varname:_refract,prsc:2,min:0,cur:0.1763488,max:1;n:type:ShaderForge.SFN_Tex2d,id:6164,x:33114,y:33090,ptovrint:False,ptlb:DUDV,ptin:_DUDV,varname:_DUDV,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:3,isnm:False|UVIN-3080-UVOUT;n:type:ShaderForge.SFN_ScreenPos,id:3080,x:32671,y:33321,varname:node_3080,prsc:2,sctp:0;n:type:ShaderForge.SFN_Append,id:751,x:33294,y:33187,varname:node_751,prsc:2|A-6164-R,B-6164-G;n:type:ShaderForge.SFN_Depth,id:4322,x:33584,y:33375,varname:node_4322,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:1985,x:33558,y:33585,prsc:2,pt:False;n:type:ShaderForge.SFN_FragmentPosition,id:3446,x:33589,y:33726,varname:node_3446,prsc:2;n:type:ShaderForge.SFN_Subtract,id:5601,x:33761,y:33514,varname:node_5601,prsc:2|A-3446-XYZ,B-1985-OUT;n:type:ShaderForge.SFN_Multiply,id:3384,x:33872,y:33146,varname:node_3384,prsc:2|A-4322-OUT,B-5601-OUT;n:type:ShaderForge.SFN_Lerp,id:4352,x:34479,y:33100,varname:node_4352,prsc:2|A-8441-OUT,B-2540-OUT,T-3384-OUT;n:type:ShaderForge.SFN_Color,id:709,x:33940,y:32891,ptovrint:False,ptlb: col spec 1,ptin:_colspec1,varname:_colspec1,prsc:2,glob:False,c1:0.7699799,c2:0.4044118,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:5148,x:34004,y:33100,ptovrint:False,ptlb: col spec 2,ptin:_colspec2,varname:_colspec2,prsc:2,glob:False,c1:1,c2:0.5646045,c3:0.4044118,c4:1;n:type:ShaderForge.SFN_Multiply,id:7819,x:34223,y:32754,varname:node_7819,prsc:2|A-5280-OUT,B-4352-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:135,x:34263,y:32599,varname:node_135,prsc:2,min:0,max:1|IN-7819-OUT;n:type:ShaderForge.SFN_OneMinus,id:8441,x:34273,y:32973,varname:node_8441,prsc:2|IN-709-RGB;n:type:ShaderForge.SFN_OneMinus,id:2734,x:34252,y:33168,varname:node_2734,prsc:2|IN-5148-RGB;n:type:ShaderForge.SFN_Color,id:8004,x:34030,y:33338,ptovrint:False,ptlb: col spec 3,ptin:_colspec3,varname:_colspec3,prsc:2,glob:False,c1:1,c2:0.5646045,c3:0.4044118,c4:1;n:type:ShaderForge.SFN_Lerp,id:2540,x:34431,y:33327,varname:node_2540,prsc:2|A-2734-OUT,B-8004-RGB,T-6164-G;proporder:5280-8270-7241-8194-8339-2335-3876-6164-709-5148-8004;pass:END;sub:END;*/

Shader "Almgp/cristalCave/vertexCristalShader" {
    Properties {
        _spec ("spec", Range(0, 5)) = 0
        _gloss ("gloss", Range(0, 1)) = 0
        _coloroverride ("color override", Color) = (0.5,0.5,0.5,1)
        _exp ("exp", Range(0, 8)) = 0
        _opac ("opac", Range(0, 1)) = 0.2051282
        _emmispower ("emmis power", Float ) = 1
        _refract ("refract", Range(0, 1)) = 0.1763488
        _DUDV ("DUDV", 2D) = "bump" {}
        _colspec1 (" col spec 1", Color) = (0.7699799,0.4044118,1,1)
        _colspec2 (" col spec 2", Color) = (1,0.5646045,0.4044118,1)
        _colspec3 (" col spec 3", Color) = (1,0.5646045,0.4044118,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _spec;
            uniform float _gloss;
            uniform float4 _coloroverride;
            uniform float _exp;
            uniform float _opac;
            uniform float _emmispower;
            uniform float _refract;
            uniform sampler2D _DUDV; uniform float4 _DUDV_ST;
            uniform float4 _colspec1;
            uniform float4 _colspec2;
            uniform float4 _colspec3;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv1 : TEXCOORD0;
                float2 uv2 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float3 tangentDir : TEXCOORD4;
                float3 bitangentDir : TEXCOORD5;
                float4 screenPos : TEXCOORD6;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
            #endif
            #ifdef DYNAMICLIGHTMAP_ON
                o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
            #endif
            o.normalDir = UnityObjectToWorldNormal(v.normal);
            o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
            o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
            o.posWorld = mul(_Object2World, v.vertex);
            float3 lightColor = _LightColor0.rgb;
            o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
            UNITY_TRANSFER_FOG(o,o.pos);
            o.projPos = ComputeScreenPos (o.pos);
            COMPUTE_EYEDEPTH(o.projPos.z);
            o.screenPos = o.pos;
            return o;
        }
        float4 frag(VertexOutput i) : COLOR {
            #if UNITY_UV_STARTS_AT_TOP
                float grabSign = -_ProjectionParams.x;
            #else
                float grabSign = _ProjectionParams.x;
            #endif
            i.normalDir = normalize(i.normalDir);
            i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
            i.screenPos.y *= _ProjectionParams.x;
            float partZ = max(0,i.projPos.z - _ProjectionParams.g);
            float4 _DUDV_var = tex2D(_DUDV,TRANSFORM_TEX(i.screenPos.rg, _DUDV));
            float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (float2(_DUDV_var.r,_DUDV_var.g)*_refract);
            float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
            float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/// Vectors:
            float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
            float3 normalDirection = i.normalDir;
            float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
            float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
            float3 lightColor = _LightColor0.rgb;
            float3 halfDirection = normalize(viewDirection+lightDirection);
// Lighting:
            float attenuation = 1;
            float3 attenColor = attenuation * _LightColor0.xyz;
            float Pi = 3.141592654;
            float InvPi = 0.31830988618;
///// Gloss:
            float gloss = _gloss;
            float specPow = exp2( gloss * 10.0+1.0);
/// GI Data:
            UnityLight light;
            #ifdef LIGHTMAP_OFF
                light.color = lightColor;
                light.dir = lightDirection;
                light.ndotl = LambertTerm (normalDirection, light.dir);
            #else
                light.color = half3(0.f, 0.f, 0.f);
                light.ndotl = 0.0f;
                light.dir = half3(0.f, 0.f, 0.f);
            #endif
            UnityGIInput d;
            d.light = light;
            d.worldPos = i.posWorld.xyz;
            d.worldViewDir = viewDirection;
            d.atten = attenuation;
            #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                d.ambient = 0;
                d.lightmapUV = i.ambientOrLightmapUV;
            #else
                d.ambient = i.ambientOrLightmapUV;
            #endif
            d.boxMax[0] = unity_SpecCube0_BoxMax;
            d.boxMin[0] = unity_SpecCube0_BoxMin;
            d.probePosition[0] = unity_SpecCube0_ProbePosition;
            d.probeHDR[0] = unity_SpecCube0_HDR;
            d.boxMax[1] = unity_SpecCube1_BoxMax;
            d.boxMin[1] = unity_SpecCube1_BoxMin;
            d.probePosition[1] = unity_SpecCube1_ProbePosition;
            d.probeHDR[1] = unity_SpecCube1_HDR;
            UnityGI gi = UnityGlobalIllumination (d, 1, gloss, normalDirection);
            lightDirection = gi.light.dir;
            lightColor = gi.light.color;
// Specular:
            float NdotL = max(0, dot( normalDirection, lightDirection ));
            float LdotH = max(0.0,dot(lightDirection, halfDirection));
            float3 node_5601 = (i.posWorld.rgb-i.normalDir);
            float3 specularColor = clamp((_spec*lerp((1.0 - _colspec1.rgb),lerp((1.0 - _colspec2.rgb),_colspec3.rgb,_DUDV_var.g),(partZ*node_5601))),0,1);
            float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
            float NdotV = max(0.0,dot( normalDirection, viewDirection ));
            float NdotH = max(0.0,dot( normalDirection, halfDirection ));
            float VdotH = max(0.0,dot( viewDirection, halfDirection ));
            float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
            float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
            float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
            float3 directSpecular = 1 * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
            half grazingTerm = saturate( gloss + specularMonochrome );
            float3 indirectSpecular = (gi.indirect.specular);
            indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
            float3 specular = (directSpecular + indirectSpecular);
/// Diffuse:
            NdotL = dot( normalDirection, lightDirection );
            float3 node_492 = (_coloroverride.rgb*i.vertexColor.rgb*_coloroverride.rgb);
            float3 node_8263 = ((node_492*pow(1.0-max(0,dot(i.normalDir, viewDirection)),_exp))*_emmispower*_coloroverride.rgb);
            float3 w = node_8263*0.5; // Light wrapping
            float3 NdotLWrap = NdotL * ( 1.0 - w );
            float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
            NdotL = max(0.0,dot( normalDirection, lightDirection ));
            half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
            NdotLWrap = max(float3(0,0,0), NdotLWrap);
            float3 directDiffuse = (forwardLight + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL))*(0.5-max(w.r,max(w.g,w.b))*0.5) * attenColor;
            float3 indirectDiffuse = float3(0,0,0);
            indirectDiffuse += gi.indirect.diffuse;
            float3 diffuseColor = node_492;
            diffuseColor *= 1-specularMonochrome;
            float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
// Emissive:
            float3 emissive = node_8263;
// Final Color:
            float3 finalColor = diffuse + specular + emissive;
            fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,_opac),1);
            UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
            return finalRGBA;
        }
        ENDCG
    }
    Pass {
        Name "FORWARD_DELTA"
        Tags {
            "LightMode"="ForwardAdd"
        }
        Blend One One
        
        
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag
        #define UNITY_PASS_FORWARDADD
        #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
        #define _GLOSSYENV 1
        #include "UnityCG.cginc"
        #include "AutoLight.cginc"
        #include "Lighting.cginc"
        #include "UnityPBSLighting.cginc"
        #include "UnityStandardBRDF.cginc"
        #pragma multi_compile_fwdadd
        #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
        #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
        #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
        #pragma multi_compile_fog
        #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
        #pragma target 3.0
        uniform sampler2D _GrabTexture;
        uniform float _spec;
        uniform float _gloss;
        uniform float4 _coloroverride;
        uniform float _exp;
        uniform float _opac;
        uniform float _emmispower;
        uniform float _refract;
        uniform sampler2D _DUDV; uniform float4 _DUDV_ST;
        uniform float4 _colspec1;
        uniform float4 _colspec2;
        uniform float4 _colspec3;
        struct VertexInput {
            float4 vertex : POSITION;
            float3 normal : NORMAL;
            float4 tangent : TANGENT;
            float2 texcoord1 : TEXCOORD1;
            float2 texcoord2 : TEXCOORD2;
            float4 vertexColor : COLOR;
        };
        struct VertexOutput {
            float4 pos : SV_POSITION;
            float2 uv1 : TEXCOORD0;
            float2 uv2 : TEXCOORD1;
            float4 posWorld : TEXCOORD2;
            float3 normalDir : TEXCOORD3;
            float3 tangentDir : TEXCOORD4;
            float3 bitangentDir : TEXCOORD5;
            float4 screenPos : TEXCOORD6;
            float4 vertexColor : COLOR;
            float4 projPos : TEXCOORD7;
            LIGHTING_COORDS(8,9)
        };
        VertexOutput vert (VertexInput v) {
            VertexOutput o = (VertexOutput)0;
            o.uv1 = v.texcoord1;
            o.uv2 = v.texcoord2;
            o.vertexColor = v.vertexColor;
            o.normalDir = UnityObjectToWorldNormal(v.normal);
            o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
            o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
            o.posWorld = mul(_Object2World, v.vertex);
            float3 lightColor = _LightColor0.rgb;
            o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
            o.projPos = ComputeScreenPos (o.pos);
            COMPUTE_EYEDEPTH(o.projPos.z);
            o.screenPos = o.pos;
            TRANSFER_VERTEX_TO_FRAGMENT(o)
            return o;
        }
        float4 frag(VertexOutput i) : COLOR {
            #if UNITY_UV_STARTS_AT_TOP
                float grabSign = -_ProjectionParams.x;
            #else
                float grabSign = _ProjectionParams.x;
            #endif
            i.normalDir = normalize(i.normalDir);
            i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
            i.screenPos.y *= _ProjectionParams.x;
            float partZ = max(0,i.projPos.z - _ProjectionParams.g);
            float4 _DUDV_var = tex2D(_DUDV,TRANSFORM_TEX(i.screenPos.rg, _DUDV));
            float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (float2(_DUDV_var.r,_DUDV_var.g)*_refract);
            float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
            float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/// Vectors:
            float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
            float3 normalDirection = i.normalDir;
            float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
            float3 lightColor = _LightColor0.rgb;
            float3 halfDirection = normalize(viewDirection+lightDirection);
// Lighting:
            float attenuation = LIGHT_ATTENUATION(i);
            float3 attenColor = attenuation * _LightColor0.xyz;
            float Pi = 3.141592654;
            float InvPi = 0.31830988618;
///// Gloss:
            float gloss = _gloss;
            float specPow = exp2( gloss * 10.0+1.0);
// Specular:
            float NdotL = max(0, dot( normalDirection, lightDirection ));
            float LdotH = max(0.0,dot(lightDirection, halfDirection));
            float3 node_5601 = (i.posWorld.rgb-i.normalDir);
            float3 specularColor = clamp((_spec*lerp((1.0 - _colspec1.rgb),lerp((1.0 - _colspec2.rgb),_colspec3.rgb,_DUDV_var.g),(partZ*node_5601))),0,1);
            float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
            float NdotV = max(0.0,dot( normalDirection, viewDirection ));
            float NdotH = max(0.0,dot( normalDirection, halfDirection ));
            float VdotH = max(0.0,dot( viewDirection, halfDirection ));
            float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
            float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
            float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
            float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
            float3 specular = directSpecular;
/// Diffuse:
            NdotL = dot( normalDirection, lightDirection );
            float3 node_492 = (_coloroverride.rgb*i.vertexColor.rgb*_coloroverride.rgb);
            float3 node_8263 = ((node_492*pow(1.0-max(0,dot(i.normalDir, viewDirection)),_exp))*_emmispower*_coloroverride.rgb);
            float3 w = node_8263*0.5; // Light wrapping
            float3 NdotLWrap = NdotL * ( 1.0 - w );
            float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
            NdotL = max(0.0,dot( normalDirection, lightDirection ));
            half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
            NdotLWrap = max(float3(0,0,0), NdotLWrap);
            float3 directDiffuse = (forwardLight + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL))*(0.5-max(w.r,max(w.g,w.b))*0.5) * attenColor;
            float3 diffuseColor = node_492;
            diffuseColor *= 1-specularMonochrome;
            float3 diffuse = directDiffuse * diffuseColor;
// Final Color:
            float3 finalColor = diffuse + specular;
            return fixed4(finalColor * _opac,0);
        }
        ENDCG
    }
    Pass {
        Name "Meta"
        Tags {
            "LightMode"="Meta"
        }
        Cull Off
        
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag
        #define UNITY_PASS_META 1
        #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
        #define _GLOSSYENV 1
        #include "UnityCG.cginc"
        #include "Lighting.cginc"
        #include "UnityPBSLighting.cginc"
        #include "UnityStandardBRDF.cginc"
        #include "UnityMetaPass.cginc"
        #pragma fragmentoption ARB_precision_hint_fastest
        #pragma multi_compile_shadowcaster
        #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
        #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
        #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
        #pragma multi_compile_fog
        #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
        #pragma target 3.0
        uniform float _spec;
        uniform float _gloss;
        uniform float4 _coloroverride;
        uniform float _exp;
        uniform float _emmispower;
        uniform sampler2D _DUDV; uniform float4 _DUDV_ST;
        uniform float4 _colspec1;
        uniform float4 _colspec2;
        uniform float4 _colspec3;
        struct VertexInput {
            float4 vertex : POSITION;
            float3 normal : NORMAL;
            float2 texcoord1 : TEXCOORD1;
            float2 texcoord2 : TEXCOORD2;
            float4 vertexColor : COLOR;
        };
        struct VertexOutput {
            float4 pos : SV_POSITION;
            float2 uv1 : TEXCOORD0;
            float2 uv2 : TEXCOORD1;
            float4 posWorld : TEXCOORD2;
            float3 normalDir : TEXCOORD3;
            float4 screenPos : TEXCOORD4;
            float4 vertexColor : COLOR;
            float4 projPos : TEXCOORD5;
        };
        VertexOutput vert (VertexInput v) {
            VertexOutput o = (VertexOutput)0;
            o.uv1 = v.texcoord1;
            o.uv2 = v.texcoord2;
            o.vertexColor = v.vertexColor;
            o.normalDir = UnityObjectToWorldNormal(v.normal);
            o.posWorld = mul(_Object2World, v.vertex);
            o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
            o.projPos = ComputeScreenPos (o.pos);
            COMPUTE_EYEDEPTH(o.projPos.z);
            o.screenPos = o.pos;
            return o;
        }
        float4 frag(VertexOutput i) : SV_Target {
            i.normalDir = normalize(i.normalDir);
            i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
            i.screenPos.y *= _ProjectionParams.x;
            float partZ = max(0,i.projPos.z - _ProjectionParams.g);
/// Vectors:
            float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
            float3 normalDirection = i.normalDir;
            UnityMetaInput o;
            UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
            
            float3 node_492 = (_coloroverride.rgb*i.vertexColor.rgb*_coloroverride.rgb);
            float3 node_8263 = ((node_492*pow(1.0-max(0,dot(i.normalDir, viewDirection)),_exp))*_emmispower*_coloroverride.rgb);
            o.Emission = node_8263;
            
            float3 diffColor = node_492;
            float4 _DUDV_var = tex2D(_DUDV,TRANSFORM_TEX(i.screenPos.rg, _DUDV));
            float3 node_5601 = (i.posWorld.rgb-i.normalDir);
            float3 specColor = clamp((_spec*lerp((1.0 - _colspec1.rgb),lerp((1.0 - _colspec2.rgb),_colspec3.rgb,_DUDV_var.g),(partZ*node_5601))),0,1);
            float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
            diffColor *= (1.0-specularMonochrome);
            float roughness = 1.0 - _gloss;
            o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
            
            return UnityMetaFragment( o );
        }
        ENDCG
    }
}
FallBack "Diffuse"
CustomEditor "ShaderForgeMaterialInspector"
}
