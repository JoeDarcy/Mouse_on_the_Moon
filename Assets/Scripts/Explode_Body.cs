using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode_Body : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(0, 100), ForceMode2D.Impulse);
    }

}
