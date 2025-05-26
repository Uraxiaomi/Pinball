using UnityEngine;

public class Mola : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float pullForce = 10f;
    public bool comBola = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rb.AddForce(new Vector2(0f, -1f) * pullForce, ForceMode2D.Force);
        }
    }
}
