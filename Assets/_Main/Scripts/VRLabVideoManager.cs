using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VRLabVideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayerObject;
    public GameObject hiddenPlayButton;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayerObject = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (videoPlayerObject.isPlaying)
        {
            hiddenPlayButton.SetActive(false);
        }
        else if (!videoPlayerObject.isPlaying)
        {
            hiddenPlayButton.SetActive(true);
        }
    }
}
