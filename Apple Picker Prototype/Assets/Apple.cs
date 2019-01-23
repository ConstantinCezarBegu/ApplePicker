using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour { 

    private static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }
}
