using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody g;
    private Vector3 force;
    [SerializeField]
    private KeyCode key;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            force.Set(0,b,0);
            g.AddForce(force, ForceMode.Impulse);
            
        }
        
    }
}
