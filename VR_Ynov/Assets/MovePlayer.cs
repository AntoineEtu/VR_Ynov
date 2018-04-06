using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public GameObject player;
    public Rigidbody myRigidBody;
    private Vector3 offset;

    public float interval;
    public float JumpHeight;
    public float JumpIntervalHeight;
    public float mouseX;
    public float mouseY;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        interval = 0.02f;
        JumpHeight = 2f;
        JumpIntervalHeight = 0.01f;
        mouseX = Input.GetAxis("Mouse X");
        mouseY = -Input.GetAxis("Mouse Y");
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = -Input.GetAxis("Mouse Y");
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - interval;
            player.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + interval;
            player.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + interval;
            player.transform.position = position;
            
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - interval;
            player.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.Space) && player.transform.position.y < JumpHeight)
        {

            Vector3 position = this.transform.position;
            for (int i = 0; i <= JumpHeight / JumpIntervalHeight; i++)
            {
                position.y = position.y + JumpIntervalHeight;
                player.transform.position = Vector3.up * 260 * Time.deltaTime;
            }
        }

    }
}
