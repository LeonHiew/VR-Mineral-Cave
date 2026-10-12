using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger1 : MonoBehaviour
{
    public PlayableDirector timeline;
    private bool triggered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!triggered && c.gameObject.tag == "key2")
        {
            timeline.Play();
            triggered = true;
        }
    }
}
