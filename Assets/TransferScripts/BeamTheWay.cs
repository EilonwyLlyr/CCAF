using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeamTheWay : MonoBehaviour
{
    public Dropdown dropdownValues;
    public GameObject beam;
    public Transform locationOfBeam;

    bool no = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        beam.GetComponent<Renderer>().enabled = false;
        onSelect();
    }
    public void onSelect()
    {

        if (dropdownValues.value == 1)
        {
            // Instantiate(beam, new Vector3 (-16,1,-66), Quaternion.Euler(0,0,0));
            //beam.GetComponent<Renderer>().enabled = true;
        }
        //else { beam.GetComponent<Renderer>().enabled = false;}
    }
    void OnBecomeInvisible()
    {
        enabled = false;
    }
    void OnBecomeVisible()
    {
        enabled = true;
    }
}
