using UnityEngine;

public class PlayerPaddle : Paddle
{
    public Vector2 direction { get; private set; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            this.direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            this.direction = Vector2.down;
        } else {
            this.direction = Vector2.zero;
        }

        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        if (this.direction.sqrMagnitude != 0) {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

}
