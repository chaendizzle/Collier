﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

 void Start ()
     {
             GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Wind";
     }
}
