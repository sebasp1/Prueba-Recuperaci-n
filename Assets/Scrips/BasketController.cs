using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;
    }

    void Start()
    {
        string colorString = PlayerPrefs.GetString("BasketColor", "FFFFFF");
        Color color;
        ColorUtility.TryParseHtmlString("#" + colorString, out color);
        GetComponent<Renderer>().material.color = color;
    }
}
