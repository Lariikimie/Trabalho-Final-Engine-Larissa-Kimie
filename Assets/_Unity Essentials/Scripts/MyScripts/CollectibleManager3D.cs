using UnityEngine;
using TMPro;

public class CollectibleManager3D : MonoBehaviour
{
    public static CollectibleManager3D Instance;

    [SerializeField] private TextMeshProUGUI counterText;

    private int total;
    private int collected;

    private void Awake()
    {
        Instance = this;
        Debug.Log("MANAGER Awake");
    }

    private void Start()
    {
        Debug.Log("MANAGER Start rodando");

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Collectible");

        total = objs.Length;
        collected = 0;

        Debug.Log("Manager encontrou: " + total);

        UpdateUI();
    }

    public void CollectItem()
    {
        collected++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        Debug.Log("Atualizando UI");

        if (counterText != null)
        {
            counterText.text = "Faltam: " + (total - collected);
        }
        else
        {
            Debug.LogError("Texto NÃO está ligado no Manager!");
        }
    }
}