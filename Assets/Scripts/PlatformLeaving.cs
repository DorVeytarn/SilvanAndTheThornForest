using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLeaving : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }
}
