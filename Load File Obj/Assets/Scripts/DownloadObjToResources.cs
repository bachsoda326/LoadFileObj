using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class DownloadObjToResources : MonoBehaviour
{
    public string url = "";
    public string fileName = "";

    public void BtnDownLoad()
    {        
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        var client = new WebClient();
        client.DownloadFile("http://likebyduybao.16mb.com/bmw_x5/BMWX54.obj", Application.dataPath + @"/Resources/" + fileName);

        yield return client;

        Debug.Log("Download Finished!");
    }
}
