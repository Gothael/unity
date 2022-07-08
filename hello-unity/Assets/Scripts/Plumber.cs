using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plumber : MonoBehaviour
{
    Transform hatTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Let's a go !!!");
        hatTransform = transform.Find("Hat");
    }

    // Update is called once per frame
    void Update()
    {
        // Did the plumber fall down?
        if (transform.rotation.z > 0.75)
        {
            if (hatTransform.position.x > -1.0 && hatTransform.position.y < -1.5)
            {
                hatTransform.Translate(new Vector3(0.002f, 0.001f));
            }
            else if (hatTransform.position.y < -0.5)
            {
                hatTransform.Translate(new Vector3(0.000f, 0.001f));
            }

            // Enable physics on hat
            hatTransform.GetComponent<Rigidbody2D>().simulated = true;

            Debug.Log(string.Format(
                    "hatTransform.position.x = {0}      hatTransform.position.y = {1}",
                    hatTransform.position.x,
                    hatTransform.position.y
                ));
        }
    }
}
