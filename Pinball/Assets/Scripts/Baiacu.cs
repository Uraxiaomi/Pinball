using UnityEngine;

public class Baiacu : MonoBehaviour
{
    public Animator _an;
    public Rigidbody2D _rb;
    public bool inflando;
    public bool desinflando;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _an = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        inflando = false;
        desinflando = false;
    }

    // Update is called once per frame
    void Update()
    {
        _an.SetBool("Inflando", inflando);
        _an.SetBool("Desinflando", desinflando);
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bola")
            {
                inflando = true;
            }
        }
        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bola")
            {
                inflando = false;
            }
        }
}
