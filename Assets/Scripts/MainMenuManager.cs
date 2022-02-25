using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button startGameButton;
    [SerializeField] private Button notQuitePlatformer;
    [SerializeField] private Button openCredits;
    [SerializeField] private Button closeCredits;
    [SerializeField] private Button threeDSpawnButton;
    [SerializeField] private Button pongButton;
    [SerializeField] private GameObject creditsUI;
    // Start is called before the first frame update
    void Awake()
    {
        openCredits.onClick.AddListener(() => creditsUI.SetActive(true));
        closeCredits.onClick.AddListener(() => creditsUI.SetActive(false));
        startGameButton.onClick.AddListener(() => LoadingScreen.LoadScene("SampleScene"));
        notQuitePlatformer.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));
        threeDSpawnButton.onClick.AddListener(() => LoadingScreen.LoadScene("3DSpawn"));
        pongButton.onClick.AddListener(() => LoadingScreen.LoadScene("Pong"));

    }

}
