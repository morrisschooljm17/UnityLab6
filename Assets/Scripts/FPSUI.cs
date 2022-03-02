using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSUI : MonoBehaviour
{

    [SerializeField] private Image healthBar;
    [SerializeField] private TMP_Text enemyDefeatText;
    // Start is called before the first frame update


    public void ShowHealthFraction(float fraction)
    {
        healthBar.fillAmount = fraction;
    }

    public void ShowEnemyDefeatCount(int count)
    {
        enemyDefeatText.text = "Enemies Defeated: " + count;
    }
}
