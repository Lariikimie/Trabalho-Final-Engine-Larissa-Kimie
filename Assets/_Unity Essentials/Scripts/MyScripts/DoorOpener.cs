using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;

    [Header("Configuração")]
    [SerializeField] private bool isLocked = false;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();

        if (doorAnimator == null)
        {
            Debug.LogWarning("Animator não encontrado na porta!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TryOpenDoor();
        }
    }

    private void TryOpenDoor()
    {
        if (isLocked)
        {
            Debug.Log("A porta está trancada!");
            return;
        }

        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Door_Open");
        }
    }
}