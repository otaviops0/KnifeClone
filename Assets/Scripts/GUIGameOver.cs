using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GUIGameOver : MonoBehaviour {
    public Text txtPontos;
    void Start() {
        txtPontos.text = Convert.ToString(Dados.pontos);
    }
    public void abreMenu() {
        SceneManager.LoadScene("Menu");
        Dados.pontos = 0;
    }
}
