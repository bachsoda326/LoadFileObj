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
        client.DownloadFile(url, Application.dataPath + @"/Resources/" + fileName);

        yield return client;

        Debug.Log("Download Finished!");
    }
}
