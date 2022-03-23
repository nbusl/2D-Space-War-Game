using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                ScoreScript.scoreValue += 10;
                break;
            case "Asteroid":
                ScoreScript.scoreValue += 5;
                break;
            case "Boss":
                ScoreScript.scoreValue += 30;
                break;
        }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Boss"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
