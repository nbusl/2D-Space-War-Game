using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet2 : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy1":
                ScoreScript.scoreValue += 12;
                break;
            case "Asteroid1":
                ScoreScript.scoreValue += 5;
                break;
            case "Boss1":
                ScoreScript.scoreValue += 30;
                break;
        }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Boss1"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
