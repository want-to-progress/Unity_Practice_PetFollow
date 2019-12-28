using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{
    private GameObject dragonPos;
    private GameObject human;
    

    void Start()
    {
        dragonPos = GameObject.Find("飛龍");
        human = GameObject.Find("野蠻人");
    }

    
    void Update()
    {
        if (Vector3.Distance(dragonPos.transform.position,
                             human.transform.position) > 2)
        {
            Vector3 newDragonPos = Vector3.Lerp(dragonPos.transform.position,
                                                human.transform.position,
                                                0.5f * Time.deltaTime);
            //newDragonPos.z = dragonPos.transform.position.z;

            dragonPos.transform.position = newDragonPos;
        }
        dragonPos.transform.LookAt(human.transform);
    }
}
