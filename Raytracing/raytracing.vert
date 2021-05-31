#version 430

in vec3 vPosition;
out vec3 glPosition;

void main (void)
{
	glPosition = vPosition;
	gl_Position = vec4(vPosition, 1.0);
}