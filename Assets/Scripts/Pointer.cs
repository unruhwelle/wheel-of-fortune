using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public ParticleSystem hitParticle;
    public WheelOfFortune wheelOfFortune;
    public WheelOfFortune.WheelSegment currentValue;

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out WheelMesh wheel) && wheelOfFortune.wheelMode == WheelOfFortune.Mode.Running)
        {
            currentValue = wheel.segment;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        wheelOfFortune.PlayHitDivider(transform);
        hitParticle.Emit(30);
    }
}
