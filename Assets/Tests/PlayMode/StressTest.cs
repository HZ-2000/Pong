using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class StressTest
{
    [SetUp]
    public void loadScene()
    {
        SceneManager.LoadScene("Pong");
    }

    [UnityTest]
    public IEnumerator VelocityStressTestFunc()
    {

        //Get the rigidbody component of the Ball game object
        Rigidbody2D body = GameObject.Find("Ball").GetComponent<Rigidbody2D>();

        //Track positions of each paddle in Scene
        Vector3 leftPlayerPos = GameObject.Find("Paddle1").GetComponent<Transform>().position;
        Vector3 rightPlayerPos = GameObject.Find("Paddle2").GetComponent<Transform>().position;

        //Get paddles' colliders
        Collider2D leftColl = GameObject.Find("Paddle1").GetComponent<Collider2D>();
        Collider2D rightColl = GameObject.Find("Paddle2").GetComponent<Collider2D>();

        //Track speed in left direction
        Vector2 leftSpeed;
        leftSpeed.x = 0;
        leftSpeed.y = 0;
        
        //Track speed in right direction
        Vector2 rightSpeed;
        rightSpeed.x = 0;
        rightSpeed.y = 0;


        //loop until ball moves beyond either paddle (should, in theory loop forever)
        while (body.transform.position.x > leftPlayerPos.x && body.transform.position.x < rightPlayerPos.x)
        {

            Vector2 currentVelocity = body.velocity;
            currentVelocity *= 1.1f;
            body.velocity = currentVelocity;

            /*leftSpeed.x--;
            rightSpeed.x++;
            if (body.velocity.x < 0)
            {
                body.velocity = leftSpeed;
            }
            else
            {
                body.velocity = rightSpeed;
            }*/
            Debug.Log(body.velocity);
            yield return null;

        }


        Debug.Log("No Collision at velocity " + body.velocity.x);
    }

    /*[TearDown]
    public void teardown()
    {
        SceneManager.UnloadSceneAsync("TestScene");
    } */
}
