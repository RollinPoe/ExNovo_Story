using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    public TextMeshProUGUI tmpro;
    public string text { get { return tmpro.text; } set { tmpro.text = value; } }

    [HideInInspector]
    public int choiceIndex = -1;

    public void outputCharName()
    {
        Image img = this.gameObject.GetComponentInChildren<Image>();
        CACHE.tempVals[4] = img.sprite.name;
        Debug.Log(img.sprite.name);
    }
}
