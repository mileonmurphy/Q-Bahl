// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:1,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:True,enco:True,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:2,dpts:2,wrdp:False,dith:0,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:744,x:36885,y:32322,varname:node_744,prsc:2|diff-7202-OUT,spec-5289-OUT,gloss-4212-OUT,normal-2992-OUT,emission-1816-OUT,alpha-7630-OUT,refract-6201-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:2173,x:32171,y:32783,ptovrint:False,ptlb:WaterNormal,ptin:_WaterNormal,varname:_WaterNormal,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2dAsset,id:4169,x:32171,y:33020,ptovrint:False,ptlb:WaterUV(normal),ptin:_WaterUVnormal,varname:_WaterUVnormal,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:3,isnm:False;n:type:ShaderForge.SFN_FragmentPosition,id:8160,x:31959,y:32559,varname:node_8160,prsc:2;n:type:ShaderForge.SFN_Append,id:239,x:32181,y:32587,varname:node_239,prsc:2|A-8160-X,B-8160-Z;n:type:ShaderForge.SFN_Divide,id:7642,x:32404,y:32568,varname:node_7642,prsc:2|A-239-OUT,B-2432-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2432,x:32181,y:32464,ptovrint:False,ptlb:scale 1,ptin:_scale1,varname:_scale1,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Divide,id:7214,x:32404,y:32383,varname:node_7214,prsc:2|A-239-OUT,B-5209-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5209,x:32181,y:32299,ptovrint:False,ptlb:scale 2,ptin:_scale2,varname:_scale2,prsc:2,glob:False,v1:2;n:type:ShaderForge.SFN_Time,id:7131,x:31936,y:32067,varname:node_7131,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:4380,x:32181,y:32178,ptovrint:False,ptlb:speed 1,ptin:_speed1,varname:_speed1,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:1000,x:32165,y:32003,ptovrint:False,ptlb:speed 2,ptin:_speed2,varname:_speed2,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:1498,x:32374,y:31991,varname:node_1498,prsc:2|A-1000-OUT,B-7131-TSL;n:type:ShaderForge.SFN_Multiply,id:285,x:32374,y:32154,varname:node_285,prsc:2|A-4380-OUT,B-7131-TSL;n:type:ShaderForge.SFN_Add,id:7362,x:32578,y:32383,varname:node_7362,prsc:2|A-1498-OUT,B-7214-OUT;n:type:ShaderForge.SFN_Add,id:3954,x:32599,y:32588,varname:node_3954,prsc:2|A-285-OUT,B-7642-OUT;n:type:ShaderForge.SFN_Tex2d,id:9474,x:32961,y:32601,varname:_node_9474,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:0,isnm:False|UVIN-3954-OUT,TEX-2173-TEX;n:type:ShaderForge.SFN_Tex2d,id:8567,x:32821,y:32425,varname:_node_8567,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:0,isnm:False|UVIN-7362-OUT,TEX-2173-TEX;n:type:ShaderForge.SFN_Tex2d,id:6683,x:32821,y:32766,varname:_node_6683,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:0,isnm:False|UVIN-7362-OUT,TEX-4169-TEX;n:type:ShaderForge.SFN_Tex2d,id:9849,x:32821,y:32924,varname:_node_9849,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:0,isnm:False|UVIN-3954-OUT,TEX-4169-TEX;n:type:ShaderForge.SFN_Blend,id:5926,x:33217,y:32870,varname:node_5926,prsc:2,blmd:10,clmp:True|SRC-6683-RGB,DST-9849-RGB;n:type:ShaderForge.SFN_NormalBlend,id:9864,x:33925,y:32347,varname:node_9864,prsc:2|BSE-8567-RGB,DTL-9474-RGB;n:type:ShaderForge.SFN_Fresnel,id:4259,x:33449,y:32004,varname:node_4259,prsc:2|NRM-9964-OUT,EXP-6207-OUT;n:type:ShaderForge.SFN_Slider,id:6207,x:32891,y:32270,ptovrint:False,ptlb:exp,ptin:_exp,varname:_exp,prsc:2,min:0,cur:3.54701,max:5;n:type:ShaderForge.SFN_NormalVector,id:9964,x:33261,y:32166,prsc:2,pt:True;n:type:ShaderForge.SFN_Slider,id:9626,x:33232,y:32431,ptovrint:False,ptlb:reflect 1 ,ptin:_reflect1,varname:_reflect1,prsc:2,min:0,cur:0.08547009,max:1;n:type:ShaderForge.SFN_Slider,id:6400,x:33371,y:32265,ptovrint:False,ptlb:reflect 2,ptin:_reflect2,varname:_reflect2,prsc:2,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Lerp,id:5020,x:36363,y:32515,varname:node_5020,prsc:2|A-6400-OUT,B-9626-OUT,T-8312-OUT;n:type:ShaderForge.SFN_Vector1,id:6203,x:33372,y:32674,varname:node_6203,prsc:2,v1:0.95;n:type:ShaderForge.SFN_ComponentMask,id:8049,x:33439,y:32842,varname:node_8049,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5926-OUT;n:type:ShaderForge.SFN_Slider,id:3095,x:35205,y:32858,ptovrint:False,ptlb:clean,ptin:_clean,varname:_clean,prsc:2,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:6201,x:33936,y:32920,varname:node_6201,prsc:2|A-8049-OUT,B-808-OUT;n:type:ShaderForge.SFN_Vector1,id:808,x:33365,y:33217,varname:node_808,prsc:2,v1:0.016;n:type:ShaderForge.SFN_Multiply,id:4556,x:35551,y:32832,varname:node_4556,prsc:2|A-5020-OUT,B-3095-OUT;n:type:ShaderForge.SFN_Color,id:8784,x:33734,y:32280,ptovrint:False,ptlb:color,ptin:_color,varname:_color,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Color,id:3433,x:33734,y:32070,ptovrint:False,ptlb:color 2,ptin:_color2,varname:_color2,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:7202,x:35780,y:32270,varname:node_7202,prsc:2|A-3433-RGB,B-8784-RGB,T-8312-OUT;n:type:ShaderForge.SFN_Power,id:8312,x:33626,y:31884,varname:node_8312,prsc:2|VAL-4259-OUT,EXP-6207-OUT;n:type:ShaderForge.SFN_Lerp,id:2992,x:34117,y:32489,varname:node_2992,prsc:2|A-7512-RGB,B-9864-OUT,T-3538-OUT;n:type:ShaderForge.SFN_Slider,id:3538,x:34085,y:32846,ptovrint:False,ptlb:normal power,ptin:_normalpower,varname:_normalpower,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_SceneDepth,id:5618,x:34355,y:32540,varname:node_5618,prsc:2;n:type:ShaderForge.SFN_Depth,id:2566,x:34436,y:32828,varname:node_2566,prsc:2;n:type:ShaderForge.SFN_Subtract,id:3613,x:35441,y:33213,varname:node_3613,prsc:2|A-5618-OUT,B-2566-OUT;n:type:ShaderForge.SFN_Multiply,id:3966,x:35161,y:32525,varname:node_3966,prsc:2|A-3033-OUT,B-3613-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3033,x:34763,y:32510,ptovrint:False,ptlb:Depth,ptin:_Depth,varname:_Depth,prsc:2,glob:False,v1:2;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:5256,x:35624,y:33155,varname:node_5256,prsc:2|IN-3966-OUT,IMIN-4586-OUT,IMAX-2899-OUT,OMIN-7073-OUT,OMAX-1363-OUT;n:type:ShaderForge.SFN_Vector4Property,id:351,x:34704,y:32711,ptovrint:False,ptlb:vector,ptin:_vector,varname:_vector,prsc:2,glob:False,v1:0,v2:0,v3:0,v4:-0.1;n:type:ShaderForge.SFN_Add,id:4586,x:34946,y:32749,varname:node_4586,prsc:2|A-351-XYZ,B-351-W;n:type:ShaderForge.SFN_Vector4Property,id:5914,x:34664,y:33065,ptovrint:False,ptlb:vector_d,ptin:_vector_d,varname:_vector_d,prsc:2,glob:False,v1:0.8,v2:3.2,v3:7.2,v4:0;n:type:ShaderForge.SFN_Add,id:2899,x:34909,y:33026,varname:node_2899,prsc:2|A-5914-XYZ,B-5914-W;n:type:ShaderForge.SFN_Vector1,id:1363,x:35115,y:32838,varname:node_1363,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:7073,x:35131,y:32944,varname:node_7073,prsc:2,v1:1;n:type:ShaderForge.SFN_Clamp01,id:591,x:35406,y:32654,varname:node_591,prsc:2|IN-5256-OUT;n:type:ShaderForge.SFN_Lerp,id:2121,x:35765,y:32504,varname:node_2121,prsc:2|A-4664-RGB,B-7229-RGB,T-591-OUT;n:type:ShaderForge.SFN_Color,id:4664,x:35341,y:32340,ptovrint:False,ptlb:color fade 1,ptin:_colorfade1,varname:_colorfade1,prsc:2,glob:False,c1:0.6768491,c2:0.8299308,c3:0.8602941,c4:1;n:type:ShaderForge.SFN_Color,id:7229,x:35547,y:32353,ptovrint:False,ptlb:color fade 2,ptin:_colorfade2,varname:_colorfade2,prsc:2,glob:False,c1:0.2299488,c2:0.1760381,c3:0.3235294,c4:1;n:type:ShaderForge.SFN_Multiply,id:3051,x:35724,y:32722,varname:node_3051,prsc:2|A-3966-OUT,B-3095-OUT,C-4163-OUT;n:type:ShaderForge.SFN_Clamp,id:7630,x:36111,y:32734,varname:node_7630,prsc:2|IN-6126-OUT,MIN-1052-OUT,MAX-791-OUT;n:type:ShaderForge.SFN_Vector1,id:1052,x:35922,y:32941,varname:node_1052,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:791,x:36088,y:32977,varname:node_791,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:7841,x:35956,y:32428,varname:node_7841,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:2939,x:35991,y:32556,varname:node_2939,prsc:2|A-2121-OUT,B-7630-OUT;n:type:ShaderForge.SFN_Lerp,id:3046,x:35753,y:32629,varname:node_3046,prsc:2|A-4664-RGB,B-7841-OUT,T-9511-OUT;n:type:ShaderForge.SFN_Add,id:1816,x:36132,y:32471,varname:node_1816,prsc:2|A-3046-OUT,B-2939-OUT;n:type:ShaderForge.SFN_Clamp01,id:9511,x:35533,y:32688,varname:node_9511,prsc:2|IN-1004-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:1004,x:35937,y:33161,varname:node_1004,prsc:2|IN-3613-OUT,IMIN-7311-OUT,IMAX-5994-OUT,OMIN-7145-OUT,OMAX-2186-OUT;n:type:ShaderForge.SFN_Vector1,id:3815,x:35645,y:33390,varname:node_3815,prsc:2,v1:-0.1;n:type:ShaderForge.SFN_Append,id:7311,x:35966,y:33347,varname:node_7311,prsc:2|A-3815-OUT,B-3815-OUT,C-3815-OUT;n:type:ShaderForge.SFN_Vector1,id:7719,x:35646,y:33578,varname:node_7719,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Vector1,id:5249,x:35646,y:33647,varname:node_5249,prsc:2,v1:3.2;n:type:ShaderForge.SFN_Vector1,id:927,x:35642,y:33749,varname:node_927,prsc:2,v1:7.7;n:type:ShaderForge.SFN_Append,id:5994,x:35860,y:33551,varname:node_5994,prsc:2|A-7719-OUT,B-5249-OUT,C-927-OUT;n:type:ShaderForge.SFN_Vector1,id:7145,x:35576,y:33309,varname:node_7145,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:2186,x:35719,y:33233,varname:node_2186,prsc:2,v1:0;n:type:ShaderForge.SFN_Lerp,id:4163,x:35724,y:32941,varname:node_4163,prsc:2|A-4556-OUT,B-5020-OUT,T-5804-OUT;n:type:ShaderForge.SFN_Slider,id:5804,x:36111,y:32895,ptovrint:False,ptlb:edge,ptin:_edge,varname:_edge,prsc:2,min:0,cur:0,max:0.1;n:type:ShaderForge.SFN_Lerp,id:6126,x:35903,y:32774,varname:node_6126,prsc:2|A-3051-OUT,B-3966-OUT,T-5804-OUT;n:type:ShaderForge.SFN_Vector1,id:4212,x:36344,y:32255,varname:node_4212,prsc:2,v1:1;n:type:ShaderForge.SFN_Add,id:5289,x:36260,y:32367,varname:node_5289,prsc:2|A-4212-OUT,B-7202-OUT;n:type:ShaderForge.SFN_Tex2d,id:7512,x:33754,y:32563,varname:_node_7512,prsc:2,tex:aba06f8af729c9e4fa841a4dc7d578c5,ntxv:0,isnm:False|UVIN-7119-OUT,TEX-2173-TEX;n:type:ShaderForge.SFN_Vector2,id:7119,x:32426,y:33092,varname:node_7119,prsc:2,v1:0,v2:0;proporder:2173-2432-5209-4380-1000-6207-9626-6400-4169-3095-8784-3433-3538-3033-351-5914-4664-7229-5804;pass:END;sub:END;*/

Shader "Almgp/cristal/cristalWater" {
    Properties {
        _WaterNormal ("WaterNormal", 2D) = "bump" {}
        _scale1 ("scale 1", Float ) = 1
        _scale2 ("scale 2", Float ) = 2
        _speed1 ("speed 1", Float ) = 1
        _speed2 ("speed 2", Float ) = 1
        _exp ("exp", Range(0, 5)) = 3.54701
        _reflect1 ("reflect 1 ", Range(0, 1)) = 0.08547009
        _reflect2 ("reflect 2", Range(0, 1)) = 1
        _WaterUVnormal ("WaterUV(normal)", 2D) = "bump" {}
        _clean ("clean", Range(0, 1)) = 1
        _color ("color", Color) = (0.5,0.5,0.5,1)
        _color2 ("color 2", Color) = (0.5,0.5,0.5,1)
        _normalpower ("normal power", Range(0, 1)) = 0
        _Depth ("Depth", Float ) = 2
        _vector ("vector", Vector) = (0,0,0,-0.1)
        _vector_d ("vector_d", Vector) = (0.8,3.2,7.2,0)
        _colorfade1 ("color fade 1", Color) = (0.6768491,0.8299308,0.8602941,1)
        _colorfade2 ("color fade 2", Color) = (0.2299488,0.1760381,0.3235294,1)
        _edge ("edge", Range(0, 0.1)) = 0
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
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform sampler2D _WaterNormal; uniform float4 _WaterNormal_ST;
            uniform sampler2D _WaterUVnormal; uniform float4 _WaterUVnormal_ST;
            uniform float _scale1;
            uniform float _scale2;
            uniform float _speed1;
            uniform float _speed2;
            uniform float _exp;
            uniform float _reflect1;
            uniform float _reflect2;
            uniform float _clean;
            uniform float4 _color;
            uniform float4 _color2;
            uniform float _normalpower;
            uniform float _Depth;
            uniform float4 _vector;
            uniform float4 _vector_d;
            uniform float4 _colorfade1;
            uniform float4 _colorfade2;
            uniform float _edge;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                float4 screenPos : TEXCOORD4;
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
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
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float4 node_7131 = _Time + _TimeEditor;
                float2 node_239 = float2(i.posWorld.r,i.posWorld.b);
                float2 node_7362 = ((_speed2*node_7131.r)+(node_239/_scale2));
                float4 _node_6683 = tex2D(_WaterUVnormal,TRANSFORM_TEX(node_7362, _WaterUVnormal));
                float2 node_3954 = ((_speed1*node_7131.r)+(node_239/_scale1));
                float4 _node_9849 = tex2D(_WaterUVnormal,TRANSFORM_TEX(node_3954, _WaterUVnormal));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (saturate(( _node_9849.rgb > 0.5 ? (1.0-(1.0-2.0*(_node_9849.rgb-0.5))*(1.0-_node_6683.rgb)) : (2.0*_node_9849.rgb*_node_6683.rgb) )).rg*0.016);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_7119 = float2(0,0);
                float3 _node_7512 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_7119, _WaterNormal)));
                float3 _node_8567 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_7362, _WaterNormal)));
                float3 _node_9474 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_3954, _WaterNormal)));
                float3 node_9864_nrm_base = _node_8567.rgb + float3(0,0,1);
                float3 node_9864_nrm_detail = _node_9474.rgb * float3(-1,-1,1);
                float3 node_9864_nrm_combined = node_9864_nrm_base*dot(node_9864_nrm_base, node_9864_nrm_detail)/node_9864_nrm_base.z - node_9864_nrm_detail;
                float3 node_9864 = node_9864_nrm_combined;
                float3 normalLocal = lerp(_node_7512.rgb,node_9864,_normalpower);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_4212 = 1.0;
                float gloss = node_4212;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
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
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_8312 = pow(pow(1.0-max(0,dot(normalDirection, viewDirection)),_exp),_exp);
                float3 node_7202 = lerp(_color2.rgb,_color.rgb,node_8312);
                float3 specularColor = (node_4212+node_7202);
                float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
                float normTerm = (specPow + 8.0 ) / (8.0 * Pi);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*normTerm*specularColor;
                float3 indirectSpecular = (gi.indirect.specular)*specularColor;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = node_7202;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_7841 = 0.0;
                float node_3613 = (sceneZ-partZ);
                float node_3815 = (-0.1);
                float3 node_7311 = float3(node_3815,node_3815,node_3815);
                float node_7145 = 1.0;
                float node_3966 = (_Depth*node_3613);
                float3 node_4586 = (_vector.rgb+_vector.a);
                float node_7073 = 1.0;
                float node_5020 = lerp(_reflect2,_reflect1,node_8312);
                float node_7630 = clamp(lerp((node_3966*_clean*lerp((node_5020*_clean),node_5020,_edge)),node_3966,_edge),0.0,1.0);
                float3 emissive = (lerp(_colorfade1.rgb,float3(node_7841,node_7841,node_7841),saturate((node_7145 + ( (node_3613 - node_7311) * (0.0 - node_7145) ) / (float3(0.8,3.2,7.7) - node_7311))))+(lerp(_colorfade1.rgb,_colorfade2.rgb,saturate((node_7073 + ( (node_3966 - node_4586) * (0.0 - node_7073) ) / ((_vector_d.rgb+_vector_d.a) - node_4586))))*node_7630));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                return fixed4(lerp(sceneColor.rgb, finalColor,node_7630),1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform sampler2D _WaterNormal; uniform float4 _WaterNormal_ST;
            uniform sampler2D _WaterUVnormal; uniform float4 _WaterUVnormal_ST;
            uniform float _scale1;
            uniform float _scale2;
            uniform float _speed1;
            uniform float _speed2;
            uniform float _exp;
            uniform float _reflect1;
            uniform float _reflect2;
            uniform float _clean;
            uniform float4 _color;
            uniform float4 _color2;
            uniform float _normalpower;
            uniform float _Depth;
            uniform float4 _vector;
            uniform float4 _vector_d;
            uniform float4 _colorfade1;
            uniform float4 _colorfade2;
            uniform float _edge;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                float4 screenPos : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
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
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float4 node_7131 = _Time + _TimeEditor;
                float2 node_239 = float2(i.posWorld.r,i.posWorld.b);
                float2 node_7362 = ((_speed2*node_7131.r)+(node_239/_scale2));
                float4 _node_6683 = tex2D(_WaterUVnormal,TRANSFORM_TEX(node_7362, _WaterUVnormal));
                float2 node_3954 = ((_speed1*node_7131.r)+(node_239/_scale1));
                float4 _node_9849 = tex2D(_WaterUVnormal,TRANSFORM_TEX(node_3954, _WaterUVnormal));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (saturate(( _node_9849.rgb > 0.5 ? (1.0-(1.0-2.0*(_node_9849.rgb-0.5))*(1.0-_node_6683.rgb)) : (2.0*_node_9849.rgb*_node_6683.rgb) )).rg*0.016);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_7119 = float2(0,0);
                float3 _node_7512 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_7119, _WaterNormal)));
                float3 _node_8567 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_7362, _WaterNormal)));
                float3 _node_9474 = UnpackNormal(tex2D(_WaterNormal,TRANSFORM_TEX(node_3954, _WaterNormal)));
                float3 node_9864_nrm_base = _node_8567.rgb + float3(0,0,1);
                float3 node_9864_nrm_detail = _node_9474.rgb * float3(-1,-1,1);
                float3 node_9864_nrm_combined = node_9864_nrm_base*dot(node_9864_nrm_base, node_9864_nrm_detail)/node_9864_nrm_base.z - node_9864_nrm_detail;
                float3 node_9864 = node_9864_nrm_combined;
                float3 normalLocal = lerp(_node_7512.rgb,node_9864,_normalpower);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_4212 = 1.0;
                float gloss = node_4212;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_8312 = pow(pow(1.0-max(0,dot(normalDirection, viewDirection)),_exp),_exp);
                float3 node_7202 = lerp(_color2.rgb,_color.rgb,node_8312);
                float3 specularColor = (node_4212+node_7202);
                float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
                float normTerm = (specPow + 8.0 ) / (8.0 * Pi);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*normTerm*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = node_7202;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_3613 = (sceneZ-partZ);
                float node_3966 = (_Depth*node_3613);
                float node_5020 = lerp(_reflect2,_reflect1,node_8312);
                float node_7630 = clamp(lerp((node_3966*_clean*lerp((node_5020*_clean),node_5020,_edge)),node_3966,_edge),0.0,1.0);
                return fixed4(finalColor * node_7630,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
