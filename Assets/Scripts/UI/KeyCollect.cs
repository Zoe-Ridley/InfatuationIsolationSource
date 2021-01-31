using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyCollect : MonoBehaviour
{
public Text MyText;
private int keys;
// Use this for initialization
void Start () {
MyText.text = "";
}
// Update is called once per frame
void Update () {
MyText.text = "Keys: " + keys + "/4";
}
void OnTriggerEnter2D(Collider2D other) {
     
        if (other.gameObject.CompareTag("Keys"))
        {
            keys = keys + 1;
        }
     
        if (other.gameObject.CompareTag("Keys"))
        {
            Destroy (other.gameObject);
        }

        if(keys == 4)
        {
            GameObject barrier = GameObject.Find("Barrier");
            Destroy(barrier);
        }
     
    }
}