using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsManager : MonoBehaviour
{
    public static GameEventsManager instance { get; private set; }
    public MiscEvents miscEvents;

    private void Awake() {
        if (instance != null){
            Debug.LogError("More than one instance of Game Event Manager Exists");
        }
        instance = this;

        miscEvents = new MiscEvents();
    }
}
