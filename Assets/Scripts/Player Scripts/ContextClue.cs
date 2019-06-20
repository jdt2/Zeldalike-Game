using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextClue : MonoBehaviour
{
    public GameObject contextClue;
    public bool contextActive = false;

    public void ChangeContext() {
        contextActive = !contextActive;
        if(contextActive) {
            contextClue.SetActive(true);
        } else {
            contextClue.SetActive(false);
        }
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
