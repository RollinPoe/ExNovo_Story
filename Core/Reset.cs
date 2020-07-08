using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string filePath = FileManager.savPath + "Resources/gameFiles/0.txt";
        if (System.IO.File.Exists(filePath))
        {
            Debug.Log("An old save file exists. The system will delete it now.");
            System.IO.File.Delete(filePath); System.IO.File.Delete(filePath + ".meta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
