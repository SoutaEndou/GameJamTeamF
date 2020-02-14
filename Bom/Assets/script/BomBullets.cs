using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomBullets : MonoBehaviour
{
    float delta;
    public float advanceBullet;
    // Start is called before the first frame update
    void Start()
    {
        delta = 0.0f;
        advanceBullet = -0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        transform.Translate(0, 0, this.advanceBullet);
        if (delta >= 2.0f)
        {
            delta = 0.0f;
            Destroy(gameObject);
        }
    }
}
