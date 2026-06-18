using UnityEngine;

public class TesteDebug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Collectible");
        Debug.Log("TAG encontrou: " + objs.Length);
    }
}
