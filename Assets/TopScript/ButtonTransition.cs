using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTransitionScript : MonoBehaviour
{
    public void OnClickBallGameButton()
    {
        SceneManager.LoadScene("BallGameScene");
    }
}
