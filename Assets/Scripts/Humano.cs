using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    private float forwardInput;
    private float horizontalInput;
    [SerializeField]
    private float speed;
    private string nombre = "Mario";
    public string Nombre { get => nombre; set => nombre = value; }

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector2(horizontalInput, forwardInput);
        direccion = Vector2.ClampMagnitude(direccion, 1);

        transform.Translate(direccion * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Bot>().Saludar();
    }
}
