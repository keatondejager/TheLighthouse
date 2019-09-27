Shader "Unlit/Silhouette_Shader"
{
    Properties
    {
		_colour1 ("Colour 1", Color) = (1,1,1)
		_colour2 ("Colour 2", Color) = (1,0,1)
    }
    SubShader
    {
		Tags { "Queue" = "Geometry+1" }
		Pass
		{
			ZTest Less
			Color [_colour1]
		}

		Pass
		{
			ZTest Greater
			Color [_colour2]
		}
    }
}
