using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeedY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, _rotationSpeedY,0f);
    }
}
