using System;
using Unity.Entities;

[Serializable]
public struct RotationSpeed_IJobChunk : IComponentData
{
    public float RadiansPerSecond;
}