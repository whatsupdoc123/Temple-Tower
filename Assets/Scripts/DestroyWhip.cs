using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhip : MonoBehaviour
{
    public float lifeTime;

    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
                Destroy(this.gameObject);
        }
    }
}
