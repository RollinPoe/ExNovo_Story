using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    public static void Inject(ref string s)
    {
        if (!s.Contains("["))
            return;

        s = s.Replace("[participantName]", CACHE.tempVals[0]);
        //s = s.Replace("[curHolyRelic]", "Divine Arc");
        s = s.Replace("[choiceButton2]", CACHE.tempVals[3]);
        s = s.Replace("[choiceResponse2]", CACHE.tempVals[4]);
        s = s.Replace("[choiceButton3L]", CACHE.tempVals[5]);
        s = s.Replace("[choiceResponse3L]", CACHE.tempVals[6]);
        s = s.Replace("[choiceButton3R]", CACHE.tempVals[7]);
        s = s.Replace("[choiceResponse3R]", CACHE.tempVals[8]);


    }

    public static string[] SplitByTags(string targetText)
    {
        return targetText.Split(new char[2] { '<', '>' });
    }
}
