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
        childText.text = $"Frame number is {frameCounter}";
        frameCounter++;
    }
}
