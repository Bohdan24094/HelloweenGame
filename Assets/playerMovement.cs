using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Update is called once per frame
    private void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

      // if (rb.position.y < -1f)
      // {
      //
      //     FindObjectOfType<GameManager>().EndGame();
      //
      // }
    }
}
