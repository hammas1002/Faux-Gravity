using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    FauxGravityAttractor attractor;
    // Start is called before the first frame update
    void Awake()
    {
        attractor = FindObjectOfType<FauxGravityAttractor>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        attractor.Attract(transform);
    }
}
