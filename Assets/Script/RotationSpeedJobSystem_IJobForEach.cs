using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;


public class RotationSpeedJobSystem_IJobForEach { }

/*
public class RotationSpeedJobSystem_IJobForEach : JobComponentSystem
{
    struct RotationSpeedJob : IJobForEach<Rotation, RotationSpeed_ForEach>
    {
        public float dt;

        public void Execute(ref Rotation rotation, [ReadOnly]ref RotationSpeed_ForEach rotationSpeed)
        {
            rotation.Value = math.mul(
                     math.normalize(rotation.Value),
                     quaternion.AxisAngle(math.up(), rotationSpeed.RadiansPerSecond * dt));
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new RotationSpeedJob() { dt = Time.DeltaTime };
        return job.Schedule(this, inputDeps);
    }
}
*/