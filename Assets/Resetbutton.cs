using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetbutton : MonoBehaviour
{
    public GameObject redsquare;
    public GameObject greensquare;

    public void resetsquares()
    {
        redsquare.transform.position = new Vector2(-1, 0);
        greensquare.transform.position = new Vector2(1, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
