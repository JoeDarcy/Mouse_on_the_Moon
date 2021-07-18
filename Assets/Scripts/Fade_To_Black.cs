using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_To_Black : MonoBehaviour
{
    [SerializeField] private float fadeSpeed = 0.001f;
    [SerializeField] private SpriteRenderer blackFadeRenderer = null;
    private Color tmp;

    // Start is called before the first frame update
    void Start() {
        tmp = blackFadeRenderer.GetComponent<SpriteRenderer>().color;
        blackFadeRenderer.GetComponent<SpriteRenderer>().color = tmp;
    }

    // Update is called once per frame
    void Update() {
        if (tmp.a < 1.0f) {
            tmp.a += fadeSpeed * Time.deltaTime;
            blackFadeRenderer.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
