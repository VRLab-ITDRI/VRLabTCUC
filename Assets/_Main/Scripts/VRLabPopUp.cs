using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabPopUp : MonoBehaviour
{
    public GameObject popUpObject;

    // Start is called before the first frame update
    void Start()
    {
        popUpObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoPopUp()
    {
        popUpObject.SetActive(true);
    }
}
