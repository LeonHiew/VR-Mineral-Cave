using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    private bool triggered = false;

    void OnTriggerEnter(Collider c)
    {
        if (!triggered && c.gameObject.tag == "key1")
        {
            timeline.Play();
            triggered = true;
        }
    }
}
