// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:False,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32901,y:32535,varname:node_3138,prsc:2|custl-1360-OUT,voffset-2587-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31661,y:32528,ptovrint:False,ptlb:SurfaceColor,ptin:_SurfaceColor,varname:_SurfaceColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2859558,c2:0.7239387,c3:0.9622642,c4:1;n:type:ShaderForge.SFN_Lerp,id:1079,x:31979,y:32687,varname:node_1079,prsc:2|A-6753-OUT,B-2643-OUT,T-8087-OUT;n:type:ShaderForge.SFN_Color,id:2683,x:31661,y:32685,ptovrint:False,ptlb:DepthColor,ptin:_DepthColor,varname:_DepthColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Slider,id:9595,x:31336,y:32835,ptovrint:False,ptlb:DepthBlend,ptin:_DepthBlend,varname:_DepthBlend,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:5;n:type:ShaderForge.SFN_DepthBlend,id:8087,x:31661,y:32835,varname:node_8087,prsc:2|DIST-9595-OUT;n:type:ShaderForge.SFN_Clamp01,id:6567,x:31825,y:32835,varname:node_6567,prsc:2|IN-8087-OUT;n:type:ShaderForge.SFN_Tex2d,id:194,x:31661,y:32168,ptovrint:False,ptlb:CausticsA,ptin:_CausticsA,varname:_Caustics,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:fa3dc91dc56fd8848b4b04cd26982ccf,ntxv:2,isnm:False|UVIN-9906-OUT;n:type:ShaderForge.SFN_TexCoord,id:5949,x:31064,y:32168,varname:node_5949,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:8462,x:31299,y:32168,varname:node_8462,prsc:2,spu:1,spv:1|UVIN-5949-UVOUT,DIST-7280-OUT;n:type:ShaderForge.SFN_Time,id:5976,x:30843,y:32302,varname:node_5976,prsc:2;n:type:ShaderForge.SFN_Color,id:9062,x:31979,y:32534,ptovrint:False,ptlb:CausticsColor,ptin:_CausticsColor,varname:_CausticsColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:5640,x:32235,y:32516,varname:node_5640,prsc:2|A-4163-OUT,B-9062-RGB,T-2221-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6909,x:30843,y:32455,ptovrint:False,ptlb:speedA,ptin:_speedA,varname:_speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:7280,x:31064,y:32325,varname:node_7280,prsc:2|A-5976-TSL,B-6909-OUT;n:type:ShaderForge.SFN_Multiply,id:1074,x:31979,y:32252,varname:node_1074,prsc:2|A-8959-OUT,B-449-OUT;n:type:ShaderForge.SFN_Slider,id:8959,x:31504,y:32074,ptovrint:False,ptlb:CausticsPower,ptin:_CausticsPower,varname:node_8959,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:10;n:type:ShaderForge.SFN_Tex2d,id:5737,x:31661,y:32348,ptovrint:False,ptlb:CausticsB,ptin:_CausticsB,varname:node_5737,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a1a5db1f30d143a4b908b35201d7134c,ntxv:0,isnm:False|UVIN-579-OUT;n:type:ShaderForge.SFN_Blend,id:449,x:31979,y:32076,varname:node_449,prsc:2,blmd:0,clmp:True|SRC-194-RGB,DST-5737-RGB;n:type:ShaderForge.SFN_Panner,id:4916,x:31299,y:32348,varname:node_4916,prsc:2,spu:1,spv:-1|UVIN-5949-UVOUT,DIST-5944-OUT;n:type:ShaderForge.SFN_Multiply,id:5944,x:31064,y:32451,varname:node_5944,prsc:2|A-5976-TSL,B-6039-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6039,x:30843,y:32532,ptovrint:False,ptlb:speedB,ptin:_speedB,varname:node_6039,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Add,id:9906,x:31484,y:32168,varname:node_9906,prsc:2|A-8462-UVOUT,B-7884-OUT;n:type:ShaderForge.SFN_Add,id:579,x:31484,y:32348,varname:node_579,prsc:2|A-4916-UVOUT,B-1830-OUT;n:type:ShaderForge.SFN_Tex2d,id:6578,x:30951,y:32624,ptovrint:False,ptlb:CausticsBFlowmap,ptin:_CausticsBFlowmap,varname:node_6578,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e85d122bbea91e64ba9dc0353d7cc6c9,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6651,x:30951,y:31924,ptovrint:False,ptlb:CausticsAFlowmap,ptin:_CausticsAFlowmap,varname:node_6651,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ab695c735f640f049a06c202ade30486,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:7884,x:31299,y:32033,varname:node_7884,prsc:2|A-6011-OUT,B-5513-OUT;n:type:ShaderForge.SFN_Slider,id:6011,x:30951,y:31828,ptovrint:False,ptlb:causticsAFlowmapPower,ptin:_causticsAFlowmapPower,varname:node_6011,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:1830,x:31299,y:32498,varname:node_1830,prsc:2|A-3451-OUT,B-1052-OUT;n:type:ShaderForge.SFN_Slider,id:3451,x:30951,y:32797,ptovrint:False,ptlb:CausticsBFlowmapPower,ptin:_CausticsBFlowmapPower,varname:node_3451,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_LightVector,id:4267,x:31621,y:31620,varname:node_4267,prsc:2;n:type:ShaderForge.SFN_HalfVector,id:8287,x:31621,y:31353,varname:node_8287,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:3803,x:31621,y:31477,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:3122,x:31879,y:31551,varname:node_3122,prsc:2,dt:1|A-4267-OUT,B-3803-OUT;n:type:ShaderForge.SFN_Dot,id:7225,x:31879,y:31416,varname:node_7225,prsc:2,dt:1|A-8287-OUT,B-3803-OUT;n:type:ShaderForge.SFN_Power,id:611,x:32101,y:31416,varname:node_611,prsc:2|VAL-7225-OUT,EXP-5046-OUT;n:type:ShaderForge.SFN_Multiply,id:4447,x:32292,y:31427,varname:node_4447,prsc:2|A-547-OUT,B-611-OUT;n:type:ShaderForge.SFN_Slider,id:547,x:32292,y:31342,ptovrint:False,ptlb:SpecularPower,ptin:_SpecularPower,varname:node_3790,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:10;n:type:ShaderForge.SFN_Exp,id:5046,x:32101,y:31269,varname:node_5046,prsc:2,et:1|IN-9607-OUT;n:type:ShaderForge.SFN_Set,id:3177,x:32044,y:31551,varname:lightData,prsc:2|IN-3122-OUT;n:type:ShaderForge.SFN_Set,id:5823,x:32454,y:31427,varname:specularData,prsc:2|IN-4447-OUT;n:type:ShaderForge.SFN_Slider,id:9607,x:31944,y:31191,ptovrint:False,ptlb:SpecularSize,ptin:_SpecularSize,varname:node_9607,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:10;n:type:ShaderForge.SFN_LightAttenuation,id:8657,x:32235,y:33086,varname:node_8657,prsc:2;n:type:ShaderForge.SFN_LightColor,id:8112,x:32235,y:32962,varname:node_8112,prsc:2;n:type:ShaderForge.SFN_Add,id:1794,x:32475,y:31541,varname:node_1794,prsc:2|A-3122-OUT,B-4447-OUT;n:type:ShaderForge.SFN_Set,id:2495,x:32635,y:31541,varname:lighting,prsc:2|IN-1794-OUT;n:type:ShaderForge.SFN_Get,id:383,x:32214,y:32464,varname:node_383,prsc:2|IN-3177-OUT;n:type:ShaderForge.SFN_Multiply,id:4438,x:32235,y:32648,varname:node_4438,prsc:2|A-5640-OUT,B-2293-RGB;n:type:ShaderForge.SFN_Color,id:2293,x:32235,y:32809,ptovrint:False,ptlb:ShadowColor,ptin:_ShadowColor,varname:node_2293,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:4226,x:32501,y:32560,varname:node_4226,prsc:2|A-4438-OUT,B-5640-OUT,T-383-OUT;n:type:ShaderForge.SFN_Get,id:527,x:32193,y:32205,varname:node_527,prsc:2|IN-5823-OUT;n:type:ShaderForge.SFN_Add,id:2221,x:31979,y:32380,varname:node_2221,prsc:2|A-1074-OUT,B-2292-OUT;n:type:ShaderForge.SFN_Multiply,id:2292,x:32214,y:32252,varname:node_2292,prsc:2|A-1074-OUT,B-527-OUT;n:type:ShaderForge.SFN_Append,id:5513,x:31108,y:31941,varname:node_5513,prsc:2|A-6651-R,B-6651-G;n:type:ShaderForge.SFN_Append,id:1052,x:31108,y:32624,varname:node_1052,prsc:2|A-6578-R,B-6578-G;n:type:ShaderForge.SFN_Tex2d,id:6222,x:32597,y:33248,ptovrint:False,ptlb:vOffsetTex,ptin:_vOffsetTex,varname:node_6222,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1790-OUT;n:type:ShaderForge.SFN_Multiply,id:2587,x:32807,y:33248,varname:node_2587,prsc:2|A-6222-R,B-1445-OUT,C-5891-XYZ;n:type:ShaderForge.SFN_Slider,id:1445,x:32440,y:33437,ptovrint:False,ptlb:vOffsetPower,ptin:_vOffsetPower,varname:node_1445,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:5028,x:31299,y:32635,varname:node_5028,prsc:2,v1:2;n:type:ShaderForge.SFN_Get,id:1790,x:32412,y:33248,varname:node_1790,prsc:2|IN-7047-OUT;n:type:ShaderForge.SFN_Set,id:7047,x:31484,y:32487,varname:vOffsetPann,prsc:2|IN-4916-UVOUT;n:type:ShaderForge.SFN_Vector4Property,id:5891,x:32597,y:33536,ptovrint:False,ptlb:vOffsetDir,ptin:_vOffsetDir,varname:node_5891,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_Multiply,id:7961,x:32441,y:33012,varname:node_7961,prsc:2|A-8112-RGB,B-8657-OUT;n:type:ShaderForge.SFN_Multiply,id:1360,x:32667,y:32673,varname:node_1360,prsc:2|A-4226-OUT,B-7961-OUT;n:type:ShaderForge.SFN_SceneColor,id:6211,x:31484,y:32685,varname:node_6211,prsc:2|UVIN-31-OUT;n:type:ShaderForge.SFN_Multiply,id:6753,x:31832,y:32685,varname:node_6753,prsc:2|A-2683-RGB,B-6211-RGB;n:type:ShaderForge.SFN_Color,id:4384,x:31661,y:33019,ptovrint:False,ptlb:ShoreColor,ptin:_ShoreColor,varname:node_4384,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:3859,x:31825,y:33019,varname:node_3859,prsc:2|A-4384-RGB,B-8018-OUT,C-1093-OUT;n:type:ShaderForge.SFN_DepthBlend,id:8336,x:31499,y:33215,varname:node_8336,prsc:2|DIST-3095-OUT;n:type:ShaderForge.SFN_Slider,id:3095,x:31174,y:33215,ptovrint:False,ptlb:ShoreBlend,ptin:_ShoreBlend,varname:node_3095,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Slider,id:8018,x:31336,y:33123,ptovrint:False,ptlb:ShorePower,ptin:_ShorePower,varname:node_8018,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Add,id:4163,x:32067,y:32855,varname:node_4163,prsc:2|A-1079-OUT,B-9434-OUT;n:type:ShaderForge.SFN_OneMinus,id:1093,x:31825,y:33215,varname:node_1093,prsc:2|IN-9820-OUT;n:type:ShaderForge.SFN_Posterize,id:520,x:31663,y:33215,varname:node_520,prsc:2|IN-8336-OUT,STPS-7949-OUT;n:type:ShaderForge.SFN_Slider,id:1899,x:31174,y:33356,ptovrint:False,ptlb:ShoreSteps,ptin:_ShoreSteps,varname:node_1899,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:2,cur:2,max:10;n:type:ShaderForge.SFN_Round,id:7949,x:31499,y:33356,varname:node_7949,prsc:2|IN-1899-OUT;n:type:ShaderForge.SFN_Clamp01,id:9820,x:31746,y:33356,varname:node_9820,prsc:2|IN-520-OUT;n:type:ShaderForge.SFN_Tex2d,id:1507,x:31493,y:32945,ptovrint:False,ptlb:ShoreTex,ptin:_ShoreTex,varname:node_1507,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-8793-UVOUT;n:type:ShaderForge.SFN_ValueProperty,id:1358,x:30849,y:32965,ptovrint:False,ptlb:ShoreSpeed,ptin:_ShoreSpeed,varname:node_1358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:1353,x:31074,y:32943,varname:node_1353,prsc:2|A-5976-TSL,B-1358-OUT;n:type:ShaderForge.SFN_Panner,id:8793,x:31252,y:32943,varname:node_8793,prsc:2,spu:1,spv:1|UVIN-5949-UVOUT,DIST-1353-OUT;n:type:ShaderForge.SFN_Blend,id:9434,x:32006,y:33012,varname:node_9434,prsc:2,blmd:10,clmp:True|SRC-1507-RGB,DST-3859-OUT;n:type:ShaderForge.SFN_Lerp,id:2643,x:31832,y:32534,varname:node_2643,prsc:2|A-7241-RGB,B-6211-RGB,T-2209-OUT;n:type:ShaderForge.SFN_Slider,id:2209,x:31327,y:32609,ptovrint:False,ptlb:SurfaceClarity,ptin:_SurfaceClarity,varname:node_2209,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:8356,x:30156,y:33157,ptovrint:False,ptlb:RefractionPower,ptin:_RefractionPower,varname:node_9018,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.05,max:1;n:type:ShaderForge.SFN_Multiply,id:2934,x:30534,y:33291,varname:node_2934,prsc:2|A-8356-OUT,B-9285-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9604,x:30138,y:33291,varname:node_9604,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-162-RGB;n:type:ShaderForge.SFN_Append,id:9285,x:30313,y:33291,varname:node_9285,prsc:2|A-9604-R,B-9604-G;n:type:ShaderForge.SFN_ScreenPos,id:1195,x:30534,y:33123,varname:node_1195,prsc:2,sctp:2;n:type:ShaderForge.SFN_Add,id:31,x:30722,y:33212,varname:node_31,prsc:2|A-1195-UVOUT,B-2934-OUT;n:type:ShaderForge.SFN_Tex2d,id:162,x:29979,y:33291,ptovrint:False,ptlb:RefractionTex,ptin:_RefractionTex,varname:node_162,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-1615-UVOUT;n:type:ShaderForge.SFN_Panner,id:1615,x:29814,y:33291,varname:node_1615,prsc:2,spu:1,spv:1|UVIN-7063-UVOUT,DIST-5579-OUT;n:type:ShaderForge.SFN_Multiply,id:5579,x:29651,y:33291,varname:node_5579,prsc:2|A-5976-TSL,B-2598-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2598,x:29473,y:33380,ptovrint:False,ptlb:RefractionSpeed,ptin:_RefractionSpeed,varname:node_2598,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:7063,x:29651,y:33146,varname:node_7063,prsc:2,uv:0,uaff:False;proporder:7241-2683-9595-9062-8959-194-5737-6909-6039-6578-6651-6011-3451-547-9607-2293-6222-1445-5891-4384-3095-8018-1899-1507-1358-2209-8356-162-2598;pass:END;sub:END;*/

Shader "Retus001/ToonWater" {
    Properties {
        _SurfaceColor ("SurfaceColor", Color) = (0.2859558,0.7239387,0.9622642,1)
        _DepthColor ("DepthColor", Color) = (0.07843138,0.3921569,0.7843137,1)
        _DepthBlend ("DepthBlend", Range(0, 5)) = 0.4
        _CausticsColor ("CausticsColor", Color) = (1,1,1,1)
        _CausticsPower ("CausticsPower", Range(0, 10)) = 0.5
        _CausticsA ("CausticsA", 2D) = "black" {}
        _CausticsB ("CausticsB", 2D) = "white" {}
        _speedA ("speedA", Float ) = 1
        _speedB ("speedB", Float ) = 2
        _CausticsBFlowmap ("CausticsBFlowmap", 2D) = "black" {}
        _CausticsAFlowmap ("CausticsAFlowmap", 2D) = "black" {}
        _causticsAFlowmapPower ("causticsAFlowmapPower", Range(0, 1)) = 0
        _CausticsBFlowmapPower ("CausticsBFlowmapPower", Range(0, 1)) = 0.2
        _SpecularPower ("SpecularPower", Range(0, 10)) = 2
        _SpecularSize ("SpecularSize", Range(0, 10)) = 2
        _ShadowColor ("ShadowColor", Color) = (0.5,0.5,0.5,1)
        _vOffsetTex ("vOffsetTex", 2D) = "white" {}
        _vOffsetPower ("vOffsetPower", Range(0, 1)) = 0
        _vOffsetDir ("vOffsetDir", Vector) = (0,0,0,0)
        _ShoreColor ("ShoreColor", Color) = (0.5,0.5,0.5,1)
        _ShoreBlend ("ShoreBlend", Range(0, 5)) = 0
        _ShorePower ("ShorePower", Range(0, 10)) = 1
        _ShoreSteps ("ShoreSteps", Range(2, 10)) = 2
        _ShoreTex ("ShoreTex", 2D) = "white" {}
        _ShoreSpeed ("ShoreSpeed", Float ) = 0
        _SurfaceClarity ("SurfaceClarity", Range(0, 1)) = 0
        _RefractionPower ("RefractionPower", Range(0, 1)) = 0.05
        _RefractionTex ("RefractionTex", 2D) = "bump" {}
        _RefractionSpeed ("RefractionSpeed", Float ) = 0
    }
    SubShader {
        Tags {
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _CausticsA; uniform float4 _CausticsA_ST;
            uniform sampler2D _CausticsB; uniform float4 _CausticsB_ST;
            uniform sampler2D _CausticsBFlowmap; uniform float4 _CausticsBFlowmap_ST;
            uniform sampler2D _CausticsAFlowmap; uniform float4 _CausticsAFlowmap_ST;
            uniform sampler2D _vOffsetTex; uniform float4 _vOffsetTex_ST;
            uniform sampler2D _ShoreTex; uniform float4 _ShoreTex_ST;
            uniform sampler2D _RefractionTex; uniform float4 _RefractionTex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _SurfaceColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _DepthColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlend)
                UNITY_DEFINE_INSTANCED_PROP( float4, _CausticsColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _speedA)
                UNITY_DEFINE_INSTANCED_PROP( float, _CausticsPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _speedB)
                UNITY_DEFINE_INSTANCED_PROP( float, _causticsAFlowmapPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _CausticsBFlowmapPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _SpecularPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _SpecularSize)
                UNITY_DEFINE_INSTANCED_PROP( float4, _ShadowColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _vOffsetPower)
                UNITY_DEFINE_INSTANCED_PROP( float4, _vOffsetDir)
                UNITY_DEFINE_INSTANCED_PROP( float4, _ShoreColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreBlend)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShorePower)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreSteps)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _SurfaceClarity)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionSpeed)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_5976 = _Time;
                float _speedB_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedB );
                float2 node_4916 = (o.uv0+(node_5976.r*_speedB_var)*float2(1,-1));
                float2 vOffsetPann = node_4916;
                float2 node_1790 = vOffsetPann;
                float4 _vOffsetTex_var = tex2Dlod(_vOffsetTex,float4(TRANSFORM_TEX(node_1790, _vOffsetTex),0.0,0));
                float _vOffsetPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetPower );
                float4 _vOffsetDir_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetDir );
                v.vertex.xyz += (_vOffsetTex_var.r*_vOffsetPower_var*_vOffsetDir_var.rgb);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _DepthColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthColor );
                float _RefractionPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionPower );
                float4 node_5976 = _Time;
                float _RefractionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionSpeed );
                float2 node_1615 = (i.uv0+(node_5976.r*_RefractionSpeed_var)*float2(1,1));
                float3 _RefractionTex_var = UnpackNormal(tex2D(_RefractionTex,TRANSFORM_TEX(node_1615, _RefractionTex)));
                float2 node_9604 = _RefractionTex_var.rgb.rg;
                float4 node_6211 = tex2D( _GrabTexture, (sceneUVs.rg+(_RefractionPower_var*float2(node_9604.r,node_9604.g))));
                float4 _SurfaceColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SurfaceColor );
                float _SurfaceClarity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SurfaceClarity );
                float _DepthBlend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlend );
                float node_8087 = saturate((sceneZ-partZ)/_DepthBlend_var);
                float _ShoreSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreSpeed );
                float2 node_8793 = (i.uv0+(node_5976.r*_ShoreSpeed_var)*float2(1,1));
                float4 _ShoreTex_var = tex2D(_ShoreTex,TRANSFORM_TEX(node_8793, _ShoreTex));
                float4 _ShoreColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreColor );
                float _ShorePower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShorePower );
                float _ShoreBlend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreBlend );
                float _ShoreSteps_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreSteps );
                float node_7949 = round(_ShoreSteps_var);
                float4 _CausticsColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsColor );
                float _CausticsPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsPower );
                float _speedA_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedA );
                float _causticsAFlowmapPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _causticsAFlowmapPower );
                float4 _CausticsAFlowmap_var = tex2D(_CausticsAFlowmap,TRANSFORM_TEX(i.uv0, _CausticsAFlowmap));
                float2 node_9906 = ((i.uv0+(node_5976.r*_speedA_var)*float2(1,1))+(_causticsAFlowmapPower_var*float2(_CausticsAFlowmap_var.r,_CausticsAFlowmap_var.g)));
                float4 _CausticsA_var = tex2D(_CausticsA,TRANSFORM_TEX(node_9906, _CausticsA));
                float _speedB_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedB );
                float2 node_4916 = (i.uv0+(node_5976.r*_speedB_var)*float2(1,-1));
                float _CausticsBFlowmapPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsBFlowmapPower );
                float4 _CausticsBFlowmap_var = tex2D(_CausticsBFlowmap,TRANSFORM_TEX(i.uv0, _CausticsBFlowmap));
                float2 node_579 = (node_4916+(_CausticsBFlowmapPower_var*float2(_CausticsBFlowmap_var.r,_CausticsBFlowmap_var.g)));
                float4 _CausticsB_var = tex2D(_CausticsB,TRANSFORM_TEX(node_579, _CausticsB));
                float3 node_1074 = (_CausticsPower_var*saturate(min(_CausticsA_var.rgb,_CausticsB_var.rgb)));
                float _SpecularPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularPower );
                float _SpecularSize_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularSize );
                float node_4447 = (_SpecularPower_var*pow(max(0,dot(halfDirection,normalDirection)),exp2(_SpecularSize_var)));
                float specularData = node_4447;
                float3 node_5640 = lerp((lerp((_DepthColor_var.rgb*node_6211.rgb),lerp(_SurfaceColor_var.rgb,node_6211.rgb,_SurfaceClarity_var),node_8087)+saturate(( (_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1)))) > 0.5 ? (1.0-(1.0-2.0*((_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1))))-0.5))*(1.0-_ShoreTex_var.rgb)) : (2.0*(_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1))))*_ShoreTex_var.rgb) ))),_CausticsColor_var.rgb,(node_1074+(node_1074*specularData)));
                float4 _ShadowColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShadowColor );
                float node_3122 = max(0,dot(lightDirection,normalDirection));
                float lightData = node_3122;
                float3 finalColor = (lerp((node_5640*_ShadowColor_var.rgb),node_5640,lightData)*(_LightColor0.rgb*attenuation));
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _CausticsA; uniform float4 _CausticsA_ST;
            uniform sampler2D _CausticsB; uniform float4 _CausticsB_ST;
            uniform sampler2D _CausticsBFlowmap; uniform float4 _CausticsBFlowmap_ST;
            uniform sampler2D _CausticsAFlowmap; uniform float4 _CausticsAFlowmap_ST;
            uniform sampler2D _vOffsetTex; uniform float4 _vOffsetTex_ST;
            uniform sampler2D _ShoreTex; uniform float4 _ShoreTex_ST;
            uniform sampler2D _RefractionTex; uniform float4 _RefractionTex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _SurfaceColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _DepthColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlend)
                UNITY_DEFINE_INSTANCED_PROP( float4, _CausticsColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _speedA)
                UNITY_DEFINE_INSTANCED_PROP( float, _CausticsPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _speedB)
                UNITY_DEFINE_INSTANCED_PROP( float, _causticsAFlowmapPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _CausticsBFlowmapPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _SpecularPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _SpecularSize)
                UNITY_DEFINE_INSTANCED_PROP( float4, _ShadowColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _vOffsetPower)
                UNITY_DEFINE_INSTANCED_PROP( float4, _vOffsetDir)
                UNITY_DEFINE_INSTANCED_PROP( float4, _ShoreColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreBlend)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShorePower)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreSteps)
                UNITY_DEFINE_INSTANCED_PROP( float, _ShoreSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _SurfaceClarity)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionPower)
                UNITY_DEFINE_INSTANCED_PROP( float, _RefractionSpeed)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_5976 = _Time;
                float _speedB_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedB );
                float2 node_4916 = (o.uv0+(node_5976.r*_speedB_var)*float2(1,-1));
                float2 vOffsetPann = node_4916;
                float2 node_1790 = vOffsetPann;
                float4 _vOffsetTex_var = tex2Dlod(_vOffsetTex,float4(TRANSFORM_TEX(node_1790, _vOffsetTex),0.0,0));
                float _vOffsetPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetPower );
                float4 _vOffsetDir_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetDir );
                v.vertex.xyz += (_vOffsetTex_var.r*_vOffsetPower_var*_vOffsetDir_var.rgb);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _DepthColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthColor );
                float _RefractionPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionPower );
                float4 node_5976 = _Time;
                float _RefractionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RefractionSpeed );
                float2 node_1615 = (i.uv0+(node_5976.r*_RefractionSpeed_var)*float2(1,1));
                float3 _RefractionTex_var = UnpackNormal(tex2D(_RefractionTex,TRANSFORM_TEX(node_1615, _RefractionTex)));
                float2 node_9604 = _RefractionTex_var.rgb.rg;
                float4 node_6211 = tex2D( _GrabTexture, (sceneUVs.rg+(_RefractionPower_var*float2(node_9604.r,node_9604.g))));
                float4 _SurfaceColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SurfaceColor );
                float _SurfaceClarity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SurfaceClarity );
                float _DepthBlend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlend );
                float node_8087 = saturate((sceneZ-partZ)/_DepthBlend_var);
                float _ShoreSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreSpeed );
                float2 node_8793 = (i.uv0+(node_5976.r*_ShoreSpeed_var)*float2(1,1));
                float4 _ShoreTex_var = tex2D(_ShoreTex,TRANSFORM_TEX(node_8793, _ShoreTex));
                float4 _ShoreColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreColor );
                float _ShorePower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShorePower );
                float _ShoreBlend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreBlend );
                float _ShoreSteps_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShoreSteps );
                float node_7949 = round(_ShoreSteps_var);
                float4 _CausticsColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsColor );
                float _CausticsPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsPower );
                float _speedA_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedA );
                float _causticsAFlowmapPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _causticsAFlowmapPower );
                float4 _CausticsAFlowmap_var = tex2D(_CausticsAFlowmap,TRANSFORM_TEX(i.uv0, _CausticsAFlowmap));
                float2 node_9906 = ((i.uv0+(node_5976.r*_speedA_var)*float2(1,1))+(_causticsAFlowmapPower_var*float2(_CausticsAFlowmap_var.r,_CausticsAFlowmap_var.g)));
                float4 _CausticsA_var = tex2D(_CausticsA,TRANSFORM_TEX(node_9906, _CausticsA));
                float _speedB_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedB );
                float2 node_4916 = (i.uv0+(node_5976.r*_speedB_var)*float2(1,-1));
                float _CausticsBFlowmapPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _CausticsBFlowmapPower );
                float4 _CausticsBFlowmap_var = tex2D(_CausticsBFlowmap,TRANSFORM_TEX(i.uv0, _CausticsBFlowmap));
                float2 node_579 = (node_4916+(_CausticsBFlowmapPower_var*float2(_CausticsBFlowmap_var.r,_CausticsBFlowmap_var.g)));
                float4 _CausticsB_var = tex2D(_CausticsB,TRANSFORM_TEX(node_579, _CausticsB));
                float3 node_1074 = (_CausticsPower_var*saturate(min(_CausticsA_var.rgb,_CausticsB_var.rgb)));
                float _SpecularPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularPower );
                float _SpecularSize_var = UNITY_ACCESS_INSTANCED_PROP( Props, _SpecularSize );
                float node_4447 = (_SpecularPower_var*pow(max(0,dot(halfDirection,normalDirection)),exp2(_SpecularSize_var)));
                float specularData = node_4447;
                float3 node_5640 = lerp((lerp((_DepthColor_var.rgb*node_6211.rgb),lerp(_SurfaceColor_var.rgb,node_6211.rgb,_SurfaceClarity_var),node_8087)+saturate(( (_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1)))) > 0.5 ? (1.0-(1.0-2.0*((_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1))))-0.5))*(1.0-_ShoreTex_var.rgb)) : (2.0*(_ShoreColor_var.rgb*_ShorePower_var*(1.0 - saturate(floor(saturate((sceneZ-partZ)/_ShoreBlend_var) * node_7949) / (node_7949 - 1))))*_ShoreTex_var.rgb) ))),_CausticsColor_var.rgb,(node_1074+(node_1074*specularData)));
                float4 _ShadowColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _ShadowColor );
                float node_3122 = max(0,dot(lightDirection,normalDirection));
                float lightData = node_3122;
                float3 finalColor = (lerp((node_5640*_ShadowColor_var.rgb),node_5640,lightData)*(_LightColor0.rgb*attenuation));
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma target 3.0
            uniform sampler2D _vOffsetTex; uniform float4 _vOffsetTex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _speedB)
                UNITY_DEFINE_INSTANCED_PROP( float, _vOffsetPower)
                UNITY_DEFINE_INSTANCED_PROP( float4, _vOffsetDir)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                float4 node_5976 = _Time;
                float _speedB_var = UNITY_ACCESS_INSTANCED_PROP( Props, _speedB );
                float2 node_4916 = (o.uv0+(node_5976.r*_speedB_var)*float2(1,-1));
                float2 vOffsetPann = node_4916;
                float2 node_1790 = vOffsetPann;
                float4 _vOffsetTex_var = tex2Dlod(_vOffsetTex,float4(TRANSFORM_TEX(node_1790, _vOffsetTex),0.0,0));
                float _vOffsetPower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetPower );
                float4 _vOffsetDir_var = UNITY_ACCESS_INSTANCED_PROP( Props, _vOffsetDir );
                v.vertex.xyz += (_vOffsetTex_var.r*_vOffsetPower_var*_vOffsetDir_var.rgb);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
