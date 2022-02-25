using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{

    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private float startSpeed;


    IEnumerator WaitThenStart() {

        yield return new WaitForSeconds(2);
        Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
        mainRigidBody.velocity = newVelocity.normalized * startSpeed;
    }

    public void Restart()
    {
        mainRigidBody.position = new Vector2(15, 10);
        mainRigidBody.velocity = new Vector2(0,0);
        StartCoroutine(WaitThenStart());
        
    }
    // Start is called before the first frame update
    void Start()
    {

        Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-0.5f, 0.5f));
        mainRigidBody.velocity = newVelocity.normalized * startSpeed;

    }


}
