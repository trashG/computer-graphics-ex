#version 330 core
in vec3 customColor;
in vec2 texCoord;
out vec4 color;
uniform sampler2D ourTexture;
void main()
{
color = texture(ourTexture, texCoord);
}