using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipEngineStart : MonoBehaviour
{
    [SerializeField] private Animator Spaceship;

    // Start is called before the first frame update
    void Start()
    {
   
 }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
        Spaceship.Play("shipHyperspace", 0, 4.0f);
        }

    }
}
