using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshPro childText;
    int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            childText.text = "Great job my dude";

        if (Input.GetKeyDown(KeyCode.B))
            childText.text = "Beth was here";

    }
}
