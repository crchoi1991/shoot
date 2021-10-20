using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickConnect()
    {
        var obj = GameObject.Find("Login");
        var nameObj = obj.transform.Find("InputName").gameObject.GetComponent<InputField>();
        Debug.LogFormat("Connect : {0}", nameObj.text);
        obj.SetActive(false);
    }
}
