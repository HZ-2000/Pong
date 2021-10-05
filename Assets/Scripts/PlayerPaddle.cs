using UnityEngine;

public class PlayerPaddle : Paddle
{
    public Vector2 direction { get; private set; }
    float topBound = 4.2f;
    float bottomBound = -4.2f;

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

        if (transform.position.y > topBound)
        {
            Vector2 newPos = transform.position;
            newPos.y = topBound;
            transform.position = newPos;
        }

        if (transform.position.y < bottomBound)
        {
            Vector2 newPos = transform.position;
            newPos.y = bottomBound;
            transform.position = newPos;
        }
    }

    private void FixedUpdate()
    {
        if (this.direction.sqrMagnitude != 0) {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

}
