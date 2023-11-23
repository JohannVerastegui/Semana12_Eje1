using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((signInSuccess) =>
        {
            if (signInSuccess)
            {
                GetFirstTrophy();
                Debug.Log("Se logue� con �xito");
            }
            else
            {
                Debug.Log("No se logue�");
            }
        });
    }

    private void GetFirstTrophy()
    {
        Trophies.TryUnlock(216196, (result) =>
        {
            SceneManager.LoadScene("GameplayScene");
            switch (result)
            {
                case TryUnlockResult.Failure:
                    Debug.Log("No se pudo desbloquear el trofeo");
                    break;
                case TryUnlockResult.Unlocked:
                    Debug.Log("Se desbloque� el trofeo");
                    break;
                case TryUnlockResult.AlreadyUnlocked:
                    Debug.Log("El trofeo ya estaba desbloqueado");
                    break;
            }
        });
    }
}