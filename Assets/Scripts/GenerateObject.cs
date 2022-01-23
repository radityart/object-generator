using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    [SerializeField] private GameObject shape;
    [SerializeField] private GameObject properties;
    private ButtonClick shapeBool;
    private InputFields inputs;
    private GameObject spawnedObject;
    void Start()
    {
        shapeBool = shape.GetComponent<ButtonClick>();
        inputs = properties.GetComponent<InputFields>();
        
    }
    public void Spawn(){
        if(shapeBool.cube){
            spawnedObject = Resources.Load("Prefabs/Cube") as GameObject;
            GameObject child = Instantiate(spawnedObject,inputs.objectPosition,Quaternion.Euler(inputs.objectRotation));
            child.transform.localScale = inputs.objectScale;
        }
        else if(shapeBool.cylinder){
            spawnedObject = Resources.Load("Prefabs/Cylinder") as GameObject;
            GameObject child = Instantiate(spawnedObject,inputs.objectPosition,Quaternion.Euler(inputs.objectRotation));
            child.transform.localScale = inputs.objectScale;
        }
        else if(shapeBool.capsule){
            spawnedObject = Resources.Load("Prefabs/Capsule") as GameObject;
            GameObject child = Instantiate(spawnedObject,inputs.objectPosition,Quaternion.Euler(inputs.objectRotation));
            child.transform.localScale = inputs.objectScale;
        }
        else if(shapeBool.sphere){
            spawnedObject = Resources.Load("Prefabs/Sphere") as GameObject;
            GameObject child = Instantiate(spawnedObject,inputs.objectPosition,Quaternion.Euler(inputs.objectRotation));
            child.transform.localScale = inputs.objectScale;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
