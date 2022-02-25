using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongGoal : MonoBehaviour
{
    [SerializeField] private PongBall ball;
    [SerializeField] private TMP_Text goalText;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject PongBall;
    private int Score = 0;

    IEnumerator WaitUntilRestart() {

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Score++;
            ball.Restart();
            
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        goalText.text = "" + Score;

        if (Score == 5) {

            winText.SetActive(true);
            Destroy(PongBall);
            StartCoroutine(WaitUntilRestart());

        }

    }
}
