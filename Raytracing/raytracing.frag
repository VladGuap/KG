#version 430

out vec4 FragColor;
in vec3 glPosition;

#define EPSILON 0.001
#define BIG 1000000.0;

const int DIFFUSE = 1;
const int REFLECTION = 2;
const int REFRACTION = 3;
const int DIFFUSE_REFLECTION = 1;
const int MIRROR_REFLECTION = 2;

const vec3 Unit = vec3 ( 1.0, 1.0, 1.0 );

struct SSphere
{
    vec3 Center;
    float Radius;
    int MaterialIdx;
};
struct STriangle
{
    vec3 v1;
    vec3 v2;
    vec3 v3;
    int MaterialIdx;
};

struct SCamera
{
    vec3 Position;
    vec3 View;
    vec3 Up;
    vec3 Side;
    vec2 Scale;
};
struct SRay {
    vec3 Origin;
    vec3 Direction;
};

struct STracingRay {
    SRay ray;
    float contribution;
    int depth;
};
struct SIntersection
{
    float Time;
    vec3 Point;
    vec3 Normal;
    vec3 Color;
    vec4 LightCoeffs;
    float ReflectionCoef;
    float RefractionCoef;
    int MaterialType;
};
struct SLight
{
    vec3 Position;
};
struct SMaterial
{
    vec3 Color;
    vec4 LightCoeffs;
    float ReflectionCoef;
    float RefractionCoef;
    int MaterialType;
};

SLight light;
SMaterial materials[7];

STriangle triangles[26];
SSphere spheres[2];

void initializeDefaultScene(out STriangle triangles[26], out SSphere spheres[2])
{
    triangles[0].v1 = vec3(-5.0,-5.0, -5.0);
    triangles[0].v2 = vec3(-5.0, 5.0, 5.0);
    triangles[0].v3 = vec3(-5.0, 5.0,-5.0);
    triangles[0].MaterialIdx = 4;
    triangles[1].v1 = vec3(-5.0,-5.0,-5.0);
    triangles[1].v2 = vec3(-5.0,-5.0, 5.0);
    triangles[1].v3 = vec3(-5.0, 5.0, 5.0);
    triangles[1].MaterialIdx = 4;
    
    triangles[2].v1 = vec3(-5.0,-5.0, 5.0);
    triangles[2].v2 = vec3( 5.0,-5.0, 5.0);
    triangles[2].v3 = vec3(-5.0, 5.0, 5.0);
    triangles[2].MaterialIdx = 1;
    triangles[3].v1 = vec3( 5.0, 5.0, 5.0);
    triangles[3].v2 = vec3(-5.0, 5.0, 5.0);
    triangles[3].v3 = vec3( 5.0,-5.0, 5.0);
    triangles[3].MaterialIdx = 1;
    
    triangles[4].v1 = vec3( 5.0, 5.0, 5.0);
    triangles[4].v2 = vec3( 5.0, 5.0, -5.0);
    triangles[4].v3 = vec3( 5.0,-5.0, -5.0);
    triangles[4].MaterialIdx = 4;
    triangles[5].v1 = vec3( 5.0, 5.0, 5.0);
    triangles[5].v2 = vec3( 5.0, -5.0, 5.0);
    triangles[5].v3 = vec3( 5.0,-5.0, -5.0);
    triangles[5].MaterialIdx = 4;
    
    triangles[6].v1 = vec3( -5.0, -5.0, 5.0);
    triangles[6].v2 = vec3( -5.0, -5.0, -5.0);
    triangles[6].v3 = vec3( 5.0, -5.0, -5.0);
    triangles[6].MaterialIdx = 2;
    triangles[7].v1 = vec3( -5.0, -5.0, 5.0);
    triangles[7].v2 = vec3( 5.0, -5.0, 5.0);
    triangles[7].v3 = vec3( 5.0, -5.0, -5.0);
    triangles[7].MaterialIdx = 2;
    
    triangles[8].v1 = vec3( -5.0, 5.0, 5.0);
    triangles[8].v2 = vec3( -5.0, 5.0, -5.0);
    triangles[8].v3 = vec3( 5.0, 5.0, -5.0);
    triangles[8].MaterialIdx = 3;
    triangles[9].v1 = vec3( -5.0, 5.0, 5.0);
    triangles[9].v2 = vec3( 5.0, 5.0, 5.0);
    triangles[9].v3 = vec3( 5.0, 5.0, -5.0);
    triangles[9].MaterialIdx = 3;
    
    spheres[0].Center = vec3(-2,-1.5,-2.25);
    spheres[0].Radius = 0.8;
    spheres[0].MaterialIdx = 0;

    spheres[1].Center = vec3(2.0,1.0,-1.0);
    spheres[1].Radius = 1.0;
    spheres[1].MaterialIdx = 5;

	triangles[10].v1 = vec3(-1.5,2.0, -2.5);
    triangles[10].v2 = vec3( -4.0,-3.0, -3.5);
    triangles[10].v3 = vec3(-1.0, -3.0, -3.5);
    triangles[10].MaterialIdx = 5;
	triangles[11].v1 = vec3(-1.5,-3.0, 1.0);
    triangles[11].v2 = vec3( -1.5,2.0, -2.5);
    triangles[11].v3 = vec3(-1.0, -3.0, -3.5);
    triangles[11].MaterialIdx = 5;
	triangles[12].v1 = vec3(-1.5,-3.0, 1.0);
    triangles[12].v2 = vec3( -1.5,2.0, -2.5);
    triangles[12].v3 = vec3(-4.0, -3.0, -3.5);
    triangles[12].MaterialIdx = 5;
	triangles[13].v1 = vec3(-1.5,-3.0, 1.0);
    triangles[13].v2 = vec3( -4.0,-3.0, -3.5);
    triangles[13].v3 = vec3(-1.0, -3.0, -3.5);
    triangles[13].MaterialIdx = 5;

	triangles[14].v1 = vec3(1.0,-2.5, -0.0);
    triangles[14].v2 = vec3(1.0, -0.5, 0.0);
    triangles[14].v3 = vec3(1.0, -0.5,-2.0);
    triangles[14].MaterialIdx = 6;
    triangles[15].v1 = vec3(1.0,-2.5,-2.0);
    triangles[15].v2 = vec3(1.0,-2.5, 0.0);
    triangles[15].v3 = vec3(1.0, -0.5, 0.0);
    triangles[15].MaterialIdx = 6;
    
    triangles[16].v1 = vec3(1.0,-2.5, 0.0);
    triangles[16].v2 = vec3( 3.0,-2.5, 0.0);
    triangles[16].v3 = vec3(1.0, -0.5, 0.0);
    triangles[16].MaterialIdx = 6;
    triangles[17].v1 = vec3( 3.0, -0.5, 0.0);
    triangles[17].v2 = vec3(1.0, -0.5, 0.0);
    triangles[17].v3 = vec3( 3.0,-2.5, 0.0);
    triangles[17].MaterialIdx = 6;
    
    triangles[18].v1 = vec3( 3.0, -0.5, 0.0);
    triangles[18].v2 = vec3( 3.0, -0.5, -2.0);
    triangles[18].v3 = vec3( 3.0,-2.5, -2.0);
    triangles[18].MaterialIdx = 6;
    triangles[19].v1 = vec3( 3.0, -0.5, 0.0);
    triangles[19].v2 = vec3( 3.0, -2.5, 0.0);
    triangles[19].v3 = vec3( 3.0,-2.5, -2.0);
    triangles[19].MaterialIdx = 6;
    
    triangles[20].v1 = vec3( 1.0, -2.5, 0.0);
    triangles[20].v2 = vec3( 1.0, -2.5, -2.0);
    triangles[20].v3 = vec3( 3.0, -2.5, -2.0);
    triangles[20].MaterialIdx = 6;
    triangles[21].v1 = vec3( 1.0, -2.5, 0.0);
    triangles[21].v2 = vec3( 3.0, -2.5, 0.0);
    triangles[21].v3 = vec3( 3.0, -2.5, -2.0);
    triangles[21].MaterialIdx = 6;
    
    triangles[22].v1 = vec3( 1.0, -0.5, 0.0);
    triangles[22].v2 = vec3( 1.0, -0.5, -2.0);
    triangles[22].v3 = vec3( 3.0, -0.5, -2.0);
    triangles[22].MaterialIdx = 6;
    triangles[23].v1 = vec3( 1.0, -0.5, 0.0);
    triangles[23].v2 = vec3( 3.0, -0.5, 0.0);
    triangles[23].v3 = vec3( 3.0, -0.5, -2.0);
    triangles[23].MaterialIdx = 6;

	triangles[24].v1 = vec3(1.0,-2.5, -2.0);
    triangles[24].v2 = vec3( 3.0,-2.5, -2.0);
    triangles[24].v3 = vec3(1.0, -0.5, -2.0);
    triangles[24].MaterialIdx = 6;
    triangles[25].v1 = vec3( 3.0, -0.5, -2.0);
    triangles[25].v2 = vec3(1.0, -0.5, -2.0);
    triangles[25].v3 = vec3( 3.0,-2.5, -2.0);
    triangles[25].MaterialIdx = 6;
}
SRay GenerateRay ( SCamera uCamera ) {
    vec2 coords = glPosition.xy * uCamera.Scale;
    vec3 direction = uCamera.View + uCamera.Side * coords.x + uCamera.Up *
    coords.y;
    return SRay ( uCamera.Position, normalize(direction) );
}
SCamera initializeDefaultCamera() 
{
    SCamera camera;
    camera.Position = vec3(0.0, 0.0, -8.0);
    camera.View = vec3(0.0, 0.0, 1.0);
    camera.Up = vec3(0.0, 1.0, 0.0);
    camera.Side = vec3(1.0, 0.0, 0.0);
    camera.Scale = vec2(1.0);
    return camera;
}
bool IntersectSphere ( SSphere sphere, SRay ray, float start, float final, out float time )
{
    ray.Origin -= sphere.Center;
    float A = dot ( ray.Direction, ray.Direction );
    float B = dot ( ray.Direction, ray.Origin );
    float C = dot ( ray.Origin, ray.Origin ) - sphere.Radius * sphere.Radius; float D = B * B - A * C;
    if ( D > 0.0 )
    {
        D= sqrt (D);
        //time = min ( max ( 0.0, ( -B - D ) / A ), ( -B + D ) / A );
        float t1 = ( -B - D ) / A; float t2 = ( -B + D ) / A; if(t1 < 0 && t2 < 0)
            return false;
        if(min(t1, t2) < 0)
        {
            time = max(t1,t2); return true;
        }
        time = min(t1, t2);
        return true;
    }
    return false;
}
bool IntersectTriangle (SRay ray, vec3 v1, vec3 v2, vec3 v3, out float time )
{
    time = -1;
    vec3 A = v2 - v1;
    vec3 B = v3 - v1;
    vec3 N = cross(A, B);
    float NdotRayDirection = dot(N, ray.Direction);
    if ((NdotRayDirection > -EPSILON) && (NdotRayDirection < EPSILON))
        return false;
    float d = dot(N, v1);
    float t = -(dot(N, ray.Origin) - d) / NdotRayDirection;
    if (t < 0)
        return false;
    vec3 P = ray.Origin + t * ray.Direction;
    vec3 C;
    vec3 edge1 = v2 - v1;
    vec3 VP1 = P - v1;
    C = cross(edge1, VP1);
    if (dot(N, C) < 0)
        return false;
    vec3 edge2 = v3 - v2;
    vec3 VP2 = P - v2;
    C = cross(edge2, VP2);
    if (dot(N, C) < 0)
        return false;
    vec3 edge3 = v1 - v3;
    vec3 VP3 = P - v3;
    C = cross(edge3, VP3);
    if (dot(N, C) < 0)
        return false;
    time = t;
    return true;
}
bool Raytrace ( SRay ray, SSphere spheres[2], STriangle triangles[26], SMaterial materials[7], float start, float final, inout SIntersection intersect )
{
    bool result = false;
    float test = start;
    intersect.Time = final;

    for(int i = 0; i < 2; i++)
    {
        SSphere sphere = spheres[i];
        if( IntersectSphere (sphere, ray, start, final, test ) && test < intersect.Time )
        {
            intersect.Time = test;
            intersect.Point = ray.Origin + ray.Direction * test;
            intersect.Normal = normalize ( intersect.Point - spheres[i].Center );
            intersect.Color = materials[sphere.MaterialIdx].Color;
            intersect.LightCoeffs = materials[sphere.MaterialIdx].LightCoeffs;
            intersect.ReflectionCoef = materials[sphere.MaterialIdx].ReflectionCoef;
            intersect.RefractionCoef = materials[sphere.MaterialIdx].RefractionCoef;
            intersect.MaterialType = materials[sphere.MaterialIdx].MaterialType;
            result = true;
        } }

    for(int i = 0; i < 26; i++)
    {
        STriangle triangle = triangles[i];
        if(IntersectTriangle(ray, triangle.v1, triangle.v2, triangle.v3, test)
           && test < intersect.Time)
        {
            intersect.Time = test;
            intersect.Point = ray.Origin + ray.Direction * test;
            intersect.Normal = normalize(cross(triangle.v1 - triangle.v2, triangle.v3 - triangle.v2));
            intersect.Color = materials[triangle.MaterialIdx].Color;
            intersect.LightCoeffs = materials[triangle.MaterialIdx].LightCoeffs;
            intersect.ReflectionCoef = materials[triangle.MaterialIdx].ReflectionCoef;
            intersect.RefractionCoef = materials[triangle.MaterialIdx].RefractionCoef;
            intersect.MaterialType = materials[triangle.MaterialIdx].MaterialType;
            result = true;
        }
    }
    return result;
}
void initializeDefaultLightMaterials(out SLight light, out SMaterial materials[7])
{
    light.Position = vec3(3.0, 2.0, -5.0f);
    vec4 lightCoefs = vec4(0.4, 0.9, 0.2, 2.0);
    materials[0].Color = vec3(0, 0.0, 1.0);
    materials[0].LightCoeffs = vec4(lightCoefs);
    materials[0].ReflectionCoef = 0.4;
    materials[0].RefractionCoef = 1.0;
    materials[0].MaterialType = REFLECTION;
    
    materials[1].Color = vec3(0.0, 0.0, 1.0);
    materials[1].LightCoeffs = vec4(lightCoefs);
    materials[1].ReflectionCoef = 0.2;
    materials[1].RefractionCoef = .3;
    materials[1].MaterialType = DIFFUSE;
    
    materials[2].Color = vec3(1.0, 1.0, 0.0);
    materials[2].LightCoeffs = vec4(lightCoefs);
    materials[2].ReflectionCoef = 0.25;
    materials[2].RefractionCoef = 1;
    materials[2].MaterialType = REFLECTION;
    
    materials[3].Color = vec3(0.0, 1.0, 0);
    materials[3].LightCoeffs = vec4(lightCoefs);
    materials[3].ReflectionCoef = 0.001;
    materials[3].RefractionCoef = 1;
    materials[3].MaterialType = REFLECTION;
    
    materials[4].Color = vec3(.4, 0.6, .8);
    materials[4].LightCoeffs = vec4(lightCoefs);
    materials[4].ReflectionCoef = 0.05;
    materials[4].RefractionCoef = 1;
    materials[4].MaterialType = REFLECTION;
	lightCoefs=vec4(0.4, 0.9, 0.9, 500.0);
	materials[5].Color = vec3(1.0, 1.0, 0.0);
    materials[5].LightCoeffs = vec4(lightCoefs);
    materials[5].ReflectionCoef = 1.0;
    materials[5].RefractionCoef = 3;
    materials[5].MaterialType = REFRACTION;
	materials[6].Color = vec3(1.0, 0.0, 0);
    materials[6].LightCoeffs = vec4(lightCoefs);
    materials[6].ReflectionCoef = 0.1;
    materials[6].RefractionCoef = 1;
    materials[6].MaterialType = REFLECTION;
}


SCamera uCamera;
SLight uLight;

vec3 Phong ( SIntersection intersect, SLight currLight, float shadow)
{
    vec3 light = normalize ( currLight.Position - intersect.Point );
    float diffuse = max(dot(light, intersect.Normal), 0.0);
    vec3 view = normalize(uCamera.Position - intersect.Point);
    vec3 reflected= reflect( -view, intersect.Normal );
    float specular = pow(max(dot(reflected, light), 0.0), intersect.LightCoeffs.w);
    return intersect.LightCoeffs.x * intersect.Color +
        intersect.LightCoeffs.y * diffuse * intersect.Color * shadow +
        intersect.LightCoeffs.z * specular * Unit;
}

float Shadow(SLight currLight, SIntersection intersect)
{
    float shadowing = 1.0;
    vec3 direction = normalize(currLight.Position - intersect.Point);
    float distanceLight = distance(currLight.Position, intersect.Point);
    SRay shadowRay = SRay(intersect.Point + direction * EPSILON, direction);
    SIntersection shadowIntersect;
    if (Raytrace(shadowRay, spheres, triangles, materials, 0, distanceLight, shadowIntersect)) {
        shadowing = 0.0;
    }
    return shadowing;
}
float Fresnel(const vec3 I, const vec3 N, const float ior)
{
	float kr;
	float cosi=clamp(-1,1,dot(I,N));
	float etai=1, etat=ior;
	if (cosi>0)
	{
		float temp=etai;
		etai=etat;
		etat=temp;
	}
	float sint=etai/etat*sqrt(max(0.f,1-cosi*cosi));
	if (sint>=1)
	{
		kr=1;
		return kr;
	}
	else
	{
	float cost=sqrt(max(0.f,1-sint*sint));
	cosi=abs(cosi);
	float Rs=((etat*cosi)-(etai*cost))/((etat*cosi)+(etai*cost));
	float Rp=((etai*cosi)-(etat*cost))/((etai*cosi)+(etat*cost));
	return kr=(Rs*Rs+Rp*Rp)/2;
	}
}

const int MAX_STACK_SIZE = 100;
const int MAX_TRACE_DEPTH = 80;
STracingRay stack[MAX_STACK_SIZE];
int stackSize = 0;
bool pushRay(STracingRay secondaryRay)
{
    if(stackSize < MAX_STACK_SIZE - 1 && secondaryRay.depth < MAX_TRACE_DEPTH)
    {
        stack[stackSize] = secondaryRay;
        stackSize++;
        return true;
    }
    return false;
}

bool isEmpty()
{
    if(stackSize < 0)
        return true;
    return false;
}

STracingRay popRay()
{
    stackSize--;
    return stack[stackSize];
}


void main ( void )
{
    
    float start = 0;
    float final = BIG;
    
    uCamera = initializeDefaultCamera();
    SRay ray = GenerateRay( uCamera);
    uLight.Position = vec3(0.5, 0.5, -1);
    
    SIntersection intersect;
    intersect.Time = 1000000.0;
    vec3 resultColor = vec3(0,0,0);
    
    initializeDefaultScene( triangles, spheres );
    initializeDefaultLightMaterials(uLight, materials);
    
    STracingRay trRay = STracingRay(ray, 1, 0);
    pushRay(trRay);
    while(!isEmpty())
    {
        STracingRay trRay = popRay();
        ray = trRay.ray;
        SIntersection intersect;
        intersect.Time = BIG;
        start = 0;
        final = BIG;
        if (Raytrace(ray, spheres, triangles, materials, start, final, intersect))
        {
            switch(intersect.MaterialType)
            {
                case DIFFUSE_REFLECTION:
                {
                    float shadowing = Shadow(uLight, intersect);
                    resultColor += trRay.contribution * Phong ( intersect, uLight, shadowing );
                    break;
                }
                case MIRROR_REFLECTION:
                {
                    if(intersect.ReflectionCoef < 1)
                    {
                        float contribution = trRay.contribution * (1 - intersect.ReflectionCoef);
                        float shadowing = Shadow(uLight, intersect);
                        resultColor +=  contribution * Phong(intersect, uLight, shadowing);
                    }
                    vec3 reflectDirection = reflect(ray.Direction, intersect.Normal); 
                    float contribution = trRay.contribution * intersect.ReflectionCoef;
                    STracingRay reflectRay = STracingRay(SRay(intersect.Point + reflectDirection * EPSILON, reflectDirection),
                                                         contribution, trRay.depth + 1);
                    pushRay(reflectRay);
                    break;
                }
                case REFRACTION:
                {
                    bool outside = (dot(ray.Direction, intersect.Normal) < 0);
                    vec3 bias = EPSILON * intersect.Normal;
                    float ior = outside ? 1.0/intersect.RefractionCoef : intersect.RefractionCoef;
                    int signOut = outside ? 1 : -1;
                    //float kr=Fresnel(ray.Direction,intersect.Normal*signOut,ior);
                    float kr = 2.1;
					if (kr<14)
					{
					vec3 refractionDirection = normalize(refract(ray.Direction, intersect.Normal*signOut,ior));
                    vec3 refractionRayOrig = intersect.Point+EPSILON*refractionDirection;
                    STracingRay refractionRay = STracingRay(SRay(refractionRayOrig, refractionDirection), trRay.contribution * (1 - kr), trRay.depth + 1);
                    pushRay(refractionRay);
					}
                    
                }
            } 
        } 
    } 
    FragColor = vec4 ( resultColor, 1.0);
}
