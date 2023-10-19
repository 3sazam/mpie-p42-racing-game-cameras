using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float offsetY;
    public float offsetZ;
    public GameObject target;

    public float rotationX;
    void Start()
    {
        Transform t = gameObject.transform;
        t.Rotate(rotationX, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(target.transform);
        Transform t = gameObject.transform;
        t.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);

    }
}
