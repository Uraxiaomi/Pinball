using UnityEngine;

public class Mola : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float pullForce = 0;
    public bool puxando = true;
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
            pullForce = (Time.deltaTime * 50) + pullForce;
            _rb.AddForce(new Vector2(0f, -1f) * pullForce, ForceMode2D.Force);
            puxando = true;
        }
        else
        {
            pullForce = 0;
            puxando = false;
        }
    }
}
