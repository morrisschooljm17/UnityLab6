using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddleController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(upKey))
        {
            mainRigidBody.AddForce(new Vector2(0, moveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(downKey))
        {
            mainRigidBody.AddForce(new Vector2(0, -moveSpeed * Time.deltaTime));
        }

    }
}
