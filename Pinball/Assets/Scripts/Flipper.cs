using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float flipForce = 1.5f;
    public Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.A)) && (gameObject.tag == "Esquerdo"))
        {
            _rb.AddForce(new Vector2(0f, 1f) * flipForce, ForceMode2D.Impulse);
        }
        else if((Input.GetKey(KeyCode.D)) && (gameObject.tag == "Direito"))
        {
            _rb.AddForce(new Vector2(0f, 1f) * flipForce, ForceMode2D.Impulse);
        }
    }
}
