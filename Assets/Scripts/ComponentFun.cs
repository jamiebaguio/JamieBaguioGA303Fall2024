using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ComponentFun : MonoBehaviour
{
    public GameObject superCoolBallObject;

    public int counter = 0;
    public string myName;

    // Start is called before the first frame update voide Start()
    // Start is called before the first frame update
    void Start()
    {
                //superCoolBallObject = GameObject.Find("Morgan"); // Finds the
                GameObject in the Heirarchy named
        //"Morgan" _EXACTLY_ and sets a varaible reference to
        "superCoolBallObject".
        //superCoolBallObject now always refers to the object that was found named
        Morgan.

                //GameObject.Find("Sphere").transform.SetParent(null);
                //superCoolBallObject.SetActive(false); //This sets the GameObject that is
        referred to by "superCoolBallObject" to disabled.
        //superCoolBallObject.SetActive(true); //This sets the GameObject that is
        referred to by "superCoolBallObject" to enabled.
        //gameObject.SetActive(false); //This would turn off the gameObject this
        script is attached to in the scene.
        //gameObject.SetActive(true); //This would turn on the gameObject this
        script is attached to in the scene.
        //gameObject.transform.



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
