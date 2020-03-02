using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

// This system updates all entities in the scene with both a RotationSpeed_ForEach and Rotation component.

public class RotationSpeedSystem_ForEach : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref RotationSpeed_ForEach rotationSpeed, ref Rotation rotation) =>
        {
            var deltaTime = Time.deltaTime; 

            /* 旋转Cube，代码逻辑不用管，这里可以是其他任何逻辑 */
            rotation.Value = math.mul(math.normalize(rotation.Value),
                quaternion.AxisAngle(math.up(), rotationSpeed.RadiansPerSecond * deltaTime));
        });
    }
}