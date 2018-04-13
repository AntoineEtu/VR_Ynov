using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

    public float speed = 2f;
    public float initSpeed = 2f;
    public float spacing = 1.0f;
    private Vector3 pos;
    private Rigidbody body;
    public Camera playerCamera;
    float posY;

    void Start()
    {
        pos = transform.position;
        posY = transform.position.y;
        Debug.Log("Hauteur perso :" + posY);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 vecteurMove = transform.localPosition + transform.forward * speed * Time.deltaTime;
            vecteurMove.y = posY;
            transform.localPosition = vecteurMove;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 vecteurMove = transform.localPosition - transform.forward * speed * Time.deltaTime;
            vecteurMove.y = posY;
            transform.localPosition = vecteurMove;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 vecteurMove = transform.localPosition + transform.right * speed * Time.deltaTime;
            vecteurMove.y = posY;
            transform.localPosition = vecteurMove;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 vecteurMove = transform.localPosition - transform.right * speed * Time.deltaTime;
            vecteurMove.y = posY;
            transform.localPosition = vecteurMove;
        }
        speed = initSpeed;
    }
}