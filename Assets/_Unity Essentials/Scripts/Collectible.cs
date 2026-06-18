using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Header("Efeito ao coletar")]
    public GameObject onCollectEffect;

    [Header("Configuração de Rotação")]
    [SerializeField] private float rotationSpeed = 100f;

    private void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item coletado!");

            // Instancia o efeito UMA vez
            if (onCollectEffect != null)
            {
                Instantiate(onCollectEffect, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }

}