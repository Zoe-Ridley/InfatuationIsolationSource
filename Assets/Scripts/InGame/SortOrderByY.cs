using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortOrderByY : MonoBehaviour
{
    public float minus = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt((transform.position.y - minus) * 100f) * -1 - 1000;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
