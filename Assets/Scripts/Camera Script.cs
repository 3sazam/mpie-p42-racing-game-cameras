using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float offsetY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject target = GameObject.Find("Car");
        Transform t = gameObject.transform;
        t.position = new Vector3(target.transform.position.x,target.transform.position.y + offsetY, target.transform.position.z);


    }
}
 