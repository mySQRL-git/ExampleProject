using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class SampleMono : MonoBehaviour
{
    [SerializeField] bool isDog = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("CAT");
        Debug.Log(isDog);
        // GetComponent<SampleMono>().isDog = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
