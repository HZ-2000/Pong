using UnityEngine;

public class Ball : MonoBehaviour
{
  public float speed = 200.0f;

  protected new Rigidbody2D rigidbody { get; private set; }

  private void Awake()
  {
      this.rigidbody = GetComponent<Rigidbody2D>();
  }

  private void Start()
  {
    ResetPosition();
  }

  public void ResetPosition()
  {
    this.rigidbody.position = Vector3.zero;
    this.rigidbody.velocity = Vector3.zero;

    AddStartingForce();
  }

  private void AddStartingForce()
  {
    float x = Random.value < 0.5f ? -1.0f : 1.0f;
    float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                    Random.Range(0.5f, 1.0f);

    Vector2 direction = new Vector2(x, y);
    this.rigidbody.AddForce(direction * this.speed);
  }

  public void AddForce(Vector2 force)
  {
    this.rigidbody.AddForce(force);
  }
}
