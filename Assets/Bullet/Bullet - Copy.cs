using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("velocidad")]
    public float ySpeed;
    private float xSpeed;
    [Header("Direccion")]
    public int yDirection;
    private int xDirection;
    private Transform _componentTrasform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        _componentTrasform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _componentTrasform.position = new Vector2(_componentTrasform.position.x + xSpeed * xDirection * Time.deltaTime,
            _componentTrasform.position.y + ySpeed * yDirection * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            Destroy(this.gameObject);
        }
    }
}
