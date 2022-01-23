using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
  public bool cube;
  public bool sphere;
  public bool capsule;
  public bool cylinder;
   
    public void CubeChosen()
    {
        cube = true;
    }
     public void CapsuleChosen()
    {
        capsule = true;
    }
     public void SphereChosen()
    {
        sphere = true;
    }
    public void CylinderChosen()
    {
        cylinder = true;
    }
}
