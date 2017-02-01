using UnityEngine;

namespace Assets.Scripts
{
  public class PlayerController : MonoBehaviour
  {
    private Rigidbody rb;

    public float speed;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
      float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");
      var movement = new Vector3(moveHorizontal, 0f, moveVertical);
      rb.AddForce(movement * speed);
    }
  }
}