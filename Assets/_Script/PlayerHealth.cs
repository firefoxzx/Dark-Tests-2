using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject DeathMenu;

    private void Awake(){
        DeathMenu.SetActive(false);
    }
    public void Die(){
        Debug.Log("Death");
        DeathMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
