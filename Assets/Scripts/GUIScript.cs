using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour {
    public void novoJogo() {
        SceneManager.LoadScene("Jogo");
    }
    public void SendMessage(string mensagem) {
        if (mensagem == "facil") {
            Dados.dificuldade = 1;
            Dados.totalFacas = 7;
            SceneManager.LoadScene("Jogo");
        } else if (mensagem == "medio") {
            Dados.dificuldade = 2;
            Dados.totalFacas = 8;
            SceneManager.LoadScene("Jogo");
        } else if (mensagem == "dificil") {
            Dados.dificuldade = 3;
            Dados.totalFacas = 9;
            SceneManager.LoadScene("Jogo");
        }
    }
}
