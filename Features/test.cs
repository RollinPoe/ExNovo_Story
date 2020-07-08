using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    void Awake()
    {
        Debug.LogError("Trace");
        NovelController.instance.Next();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ASDasd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
