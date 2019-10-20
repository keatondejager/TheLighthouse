using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSwapMaterial : MonoBehaviour
{

    public List<Material> Materials = new List<Material>();

    private ParticleSystem _LightningParticleSystem;
    private ParticleSystemRenderer _LightningParticleRender;
    public bool ChangeMaterial = false;
    // Start is called before the first frame update
    void Start()
    {
        _LightningParticleSystem = GetComponent<ParticleSystem>();
        _LightningParticleRender = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(_LightningParticleSystem.particleCount);
        if(_LightningParticleSystem.particleCount == 0 && ChangeMaterial == true)
        {
            _LightningParticleRender.material = Materials[(int)Random.Range(0, Materials.Count)];
            ChangeMaterial = false;
        }
        else if(_LightningParticleSystem.particleCount == 1 && ChangeMaterial == false)
        {
            ChangeMaterial = true;
        }
    }
}
