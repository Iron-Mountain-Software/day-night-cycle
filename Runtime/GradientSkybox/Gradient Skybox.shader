Shader "Skybox/Gradient Skybox"
{
    Properties
    {
        _TopColor ("Top Color", Color) = (1, 1, 1, 0)
        _MiddleColor ("Middle Color", Color) = (1, 1, 1, 0)
        _BottomColor ("Bottom Color", Color) = (1, 1, 1, 0)

        _Exponent1 ("Exponent Factor for Top Half", Float) = 1.0
        _Exponent2 ("Exponent Factor for Bottom Half", Float) = 1.0
        _Intensity ("Intensity Amplifier", Float) = 1.0
    }

    CGINCLUDE

    #include "UnityCG.cginc"

    struct appdata
    {
        float4 position : POSITION;
        float3 texcoord : TEXCOORD0;
    };
    
    struct v2f
    {
        float4 position : SV_POSITION;
        float3 texcoord : TEXCOORD0;
    };
    
    half4 _TopColor;
    half4 _MiddleColor;
    half4 _BottomColor;

    half _Intensity;
    half _Exponent1;
    half _Exponent2;
    
    v2f vert (appdata v)
    {
        v2f o;
        o.position = UnityObjectToClipPos (v.position);
        o.texcoord = v.texcoord;
        return o;
    }
    
    half4 frag (v2f i) : COLOR
    {
        float p = normalize (i.texcoord).y;
        float p1 = 1.0f - pow (min (1.0f, 1.0f - p), _Exponent1);
        float p3 = 1.0f - pow (min (1.0f, 1.0f + p), _Exponent2);
        float p2 = 1.0f - p1 - p3;

        return (_TopColor * p1 + _MiddleColor * p2 + _BottomColor * p3) * _Intensity;
    }

    ENDCG

    SubShader
    {
        Tags { "RenderType"="Background" "Queue"="Background" }
        Pass
        {
            ZWrite Off
            Cull Off

            
            CGPROGRAM
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma vertex vert
            #pragma fragment frag
            ENDCG
        }
    } 
}
