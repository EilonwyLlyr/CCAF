using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class searchingFunction : MonoBehaviour {

    enum State {Choosing, Selected};
    State state = State.Choosing;

    public Dropdown dropdownValues;
    public Text display;

    string changeable;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update ()
    {
        
            dropdownValues = GetComponent<Dropdown>();
            onSelect();
        
    }

    public void onSelect()
    {
        
        if (dropdownValues.value == 1)
        {
            changeable = "Let's find Bio Building";
            display.text = changeable;
            
        }
        if (dropdownValues.value == 2)
        {
            changeable = "Let's find JFK Library";
            display.text = changeable;
        }
        if (dropdownValues.value == 3)
        {
            changeable = "Let's find King Hall";
            display.text = changeable;
        }
        if (dropdownValues.value == 4)
        {
            changeable = "Let's find Salazar Hall";
            display.text = changeable;
        }
    }

}
