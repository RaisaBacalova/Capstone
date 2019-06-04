Shader "Holistic/Ship" {

Properties {
	_MainTex ("Texture", 2D) = "black" {}
}
Subshader {
	Tags {"Queue" = "Transparent"}
	//Blend One One
	//Blend SrcAlpha OneMinusSrcAlpha
	Blend DstColor Zero
	//Blend DstColor One
	Pass {
		SetTexture [_MainTex] {combine texture}
	}
}
}