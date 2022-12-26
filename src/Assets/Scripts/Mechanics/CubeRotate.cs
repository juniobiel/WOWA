using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    private SpriteRenderer spriteRenderer { get; set; }
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0,0,1, Space.Self);
        timer += Time.deltaTime;
        if(timer >= 1.5f)
        {
            spriteRenderer.color = Random.ColorHSV();
            timer -= timer;
        }
    }
}
