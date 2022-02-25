using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Transform Target;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currentPos = mainTransform.position;
        currentPos.x = Target.position.x;
        mainTransform.position = currentPos;
    }
}
