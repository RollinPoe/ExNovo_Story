using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileImgScreen : MonoBehaviour
{

    public static ProfileImgScreen instance;

    public TitleHeader header;

    public GameObject root;

    void Awake()
    {
        instance = this;
        Hide();
    }

    public static void Show(string title, bool clearCurrentInput = true)
    {
        instance.root.SetActive(true);

        //only show a title if one is given.
        if (title != "")
            instance.header.Show(title);
        else
            instance.header.Hide();

        if (isRevealing)
            instance.StopCoroutine(revealing);

        revealing = instance.StartCoroutine(Revealing());
    }

    public static void Hide()
    {
        instance.root.SetActive(false);
        instance.header.Hide();
    }

    public static bool isWaitingForUserInput { get { return instance.root.activeInHierarchy; } }
    public static bool isRevealing { get { return revealing != null; } }
    static Coroutine revealing = null;
    static IEnumerator Revealing()
    { 
        while (instance.header.isRevealing)
            yield return new WaitForEndOfFrame();

        revealing = null;
    }

    public void Accept()
    {
        Debug.Log(this.gameObject.name);
        Hide();
    }
}
