using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjFromResources : MonoBehaviour
{
    public string objName = "";

    public void BtnLoadObj()
    {
        GameObject obj = Instantiate(Resources.Load(objName, typeof(GameObject))) as GameObject;
    }
}
