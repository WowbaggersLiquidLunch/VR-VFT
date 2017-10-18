// http://answers.unity3d.com/answers/915304/view.html
// I don't know how it works!

Shader "Custom/Simple Interior" {
	Properties {
		_MainTex ("Base (RGB)", 3D) = "white" {}
	}

	SubShader {
		Tags { "RenderType" = "Opaque" }
		Cull Front
	
		CGPROGRAM
			#pragma surface surf Lambert vertex:vert
			sampler2D _MainTex;
		
			struct Input {
				float2 uv_MainTex;
				float4 color : COLOR;
			};
		
			void vert(inout appdata_full v) {
				v.normal.xyz = v.normal * -1;
			}
		
			void surf (Input IN, inout SurfaceOutput o) {
				fixed3 result = tex2D(_MainTex, IN.uv_MainTex);
				o.Albedo = result.rgb;
				o.Alpha = 1;
			}
		ENDCG
	}

	Fallback "Diffuse"
}