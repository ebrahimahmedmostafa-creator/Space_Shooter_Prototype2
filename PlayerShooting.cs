using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunPortLeft , gunPortRight;
    public float bulletSpeed = 60f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        SpawnBullet(gunPortLeft);
        SpawnBullet(gunPortRight);
    }

    void SpawnBullet(Transform targetPort)
    {
        if (targetPort == null || bulletPrefab == null) return;

        GameObject bullet = Instantiate(bulletPrefab, targetPort.position, targetPort.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = targetPort.forward * bulletSpeed;
        }

        Destroy(bullet, 3f);
    }
}