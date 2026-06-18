using UnityEngine;

public class Collectible3D : MonoBehaviour
{
    public GameObject onCollectEffect;
    [SerializeField] private float rotationSpeed = 100f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (CollectibleManager3D.Instance != null)
            {
                CollectibleManager3D.Instance.CollectItem();
            }

            if (onCollectEffect != null)
            {
                Instantiate(onCollectEffect, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}
