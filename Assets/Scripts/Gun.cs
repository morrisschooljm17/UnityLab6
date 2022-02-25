using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform gunTransform;
    [SerializeField] private Transform shootPosition;
    [Range(0, 200)]
    [SerializeField] private float moveSpeed;
    

    [SerializeField] private GameObject[] bullets;


    // Update is called once per frame
    void Update()
    {
        gunTransform.Rotate(0, 0, -moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown("space")) {
            Fire();
        }

    }

    private void Fire() {
        GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);

    }
}
