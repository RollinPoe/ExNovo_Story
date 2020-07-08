using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdaptiveFontTMPro : MonoBehaviour
{
    TextMeshProUGUI txt;
    public bool continualUpdate = true;
    public int fontSizeAtDefaultRes = 36;
    public static float defaultRes = 2594f; //Deal with this later? Computer dependent. Need to retrieve on app start.

    // Start is called before the first frame update
    void Start()
    {
        //print(Screen.width + Screen.height);
        txt = GetComponent<TextMeshProUGUI>();

        if (continualUpdate)
        {
            InvokeRepeating("Adjust", 0f, Random.Range(0.3f, 1f));
        }
        else
        {
            //Adjust();
            enabled = false;
        }
    }

    void Adjust()
    {
        if(!enabled || !gameObject.activeInHierarchy)
        {
            return;
        }

        float totalCurrentRes = Screen.height + Screen.width;
        float perc = totalCurrentRes / defaultRes;
        int fontsize = Mathf.RoundToInt((float)fontSizeAtDefaultRes * perc);

        txt.fontSize = fontsize;
    }
}
