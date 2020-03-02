using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;


public class RotationSpeedJobSystem_ForEach{}

/*
public class RotationSpeedJobSystem_ForEach : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        float deltaTime = Time.DeltaTime;

        // Schedule job to rotate around up vector
        var jobHandle = Entities
            .ForEach((ref Rotation rotation, in RotationSpeed_ForEach rotationSpeed) =>
            {
                rotation.Value = math.mul(
                    math.normalize(rotation.Value),
                    quaternion.AxisAngle(math.up(), rotationSpeed.RadiansPerSecond * deltaTime));
            })
            .Schedule(inputDependencies);

        // Return job handle as the dependency for this system
        return jobHandle;
    }
}
*/