using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableParticleEffect : MonoBehaviour
{
    public ParticleSystem PS;

    private void Awake()
    {
        var sh = PS.shape;
        sh.enabled = true;
        sh.shapeType = ParticleSystemShapeType.Mesh;
        sh.mesh = this.transform.parent.GetComponent<MeshFilter>().mesh;
        sh.scale = this.transform.parent.transform.localScale * 1.5f;
    }
}
