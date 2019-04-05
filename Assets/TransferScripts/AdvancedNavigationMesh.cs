using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AdvancedNavigationMesh : MonoBehaviour
{
    [SerializeField] Transform BioDestination;
    [SerializeField] List<AdvancedNavigationMesh> points;
    [SerializeField] Dropdown dropdownValues;


    NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnSelect()
    {
        if (dropdownValues.value == 0)
        {
            navAgent.ResetPath();

        }
        if (dropdownValues.value == 1)
        {
            navAgent = this.GetComponent<NavMeshAgent>();
            if (navAgent == null)
            {
                Debug.Log("Jesse Avila will get punished" + gameObject.name);
            }
            else
            {
         
                setBioPath();   
            }
            
        }
        if (dropdownValues.value == 2)
        {

            navAgent = this.GetComponent<NavMeshAgent>();
            if (navAgent == null)
            {
                Debug.Log("Jesse Avila will get punished" + gameObject.name);
            }
            else
            {
            }

        }

    }

    private void setBioPath()
    {
        if(BioDestination != null)
        {
            //Vector3 pos = Vector3.MoveTowards(transform.position, SalazarPath[current].position, speed * Time.deltaTime);

            Vector3 targetDestination = BioDestination.transform.position;
            navAgent.SetDestination(targetDestination);
        }
    }

    // Update is called once per frame
    void Update()
    {

        OnSelect();
    }
}
