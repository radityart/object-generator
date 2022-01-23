using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputFields : MonoBehaviour
{
    private int input;
    public Vector3 objectPosition;
    public Vector3 objectRotation;
    public Vector3 objectScale;
    [SerializeField] private TMP_InputField posx;
    [SerializeField] private TMP_InputField posy;
    [SerializeField] private TMP_InputField posz;
    [SerializeField] private TMP_InputField rotx;
    [SerializeField] private TMP_InputField roty;
    [SerializeField] private TMP_InputField rotz;
    [SerializeField] private TMP_InputField sclx;
    [SerializeField] private TMP_InputField scly;
    [SerializeField] private TMP_InputField sclz;

    public void getPosX(){
        input = int.Parse(posx.GetComponent<TMP_InputField>().text);
        objectPosition.x = input;
    }
    public void getPosY(){
        input = int.Parse(posy.GetComponent<TMP_InputField>().text);
        objectPosition.y = input;
    }
    public void getPosZ(){
        input = int.Parse(posz.GetComponent<TMP_InputField>().text);
        objectPosition.z = input;
    }
    public void getRotX(){
        input = int.Parse(rotx.GetComponent<TMP_InputField>().text);
        objectRotation.x = input;
    }
    public void getRotY(){
        input = int.Parse(roty.GetComponent<TMP_InputField>().text);
        objectRotation.y = input;
    }
    public void getRotZ(){
        input = int.Parse(rotz.GetComponent<TMP_InputField>().text);
        objectRotation.z = input;
    }
    public void getScaX(){
        input = int.Parse(sclx.GetComponent<TMP_InputField>().text);
        objectScale.x = input;
    }
    public void getScaY(){
        input = int.Parse(scly.GetComponent<TMP_InputField>().text);
        objectScale.y = input;
    }
    public void getScaZ(){
        input = int.Parse(sclz.GetComponent<TMP_InputField>().text);
        objectScale.z = input;
    }
}
