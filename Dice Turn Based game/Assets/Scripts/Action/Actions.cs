using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The class for making actions, should be treated like an abstract class
abstract public class Actions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Executes what the action should do
    public virtual void execute()
    {

    }
}
