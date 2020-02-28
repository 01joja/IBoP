﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopUp : MonoBehaviour
{
    public GameState State;
    public List<GameObject> PopUps;
    public bool FireOnce;
    private bool done = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ProcessGameState(State.GetState());
    }

    public virtual void ProcessGameState(int[] state)
    {
        if(!FireOnce || !done)
            if (state[0] > -1)
            {
                done = true;
                foreach (GameObject popUp in PopUps)
                {
                    Instantiate(popUp);
                }
            }
    }


}
public abstract class GameState : MonoBehaviour
{
    public abstract int[] GetState();
}

