using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceGame : MonoBehaviour {

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start() {
        textComponent.text = ("Texty texto, I'm a textatious text meant to be tested. I have no soul but that's ok.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
