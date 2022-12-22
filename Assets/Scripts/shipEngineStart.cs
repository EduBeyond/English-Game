using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipEngineStart : MonoBehaviour
{
    [SerializeField] private Animator Spaceship;
    [SerializeField] private Animator LevelLoader;

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
        LevelLoader.Play("outro_crossfade", 0, 4.0f);
        }

    }
}
