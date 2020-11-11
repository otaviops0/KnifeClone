using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject telaGameOver;
    public GameObject faca;
    public GameObject roda;
    void Start() {
        Instantiate(roda, new Vector3(0, 0, 0), Quaternion.Euler(90, 0, 0));
        Dados.facas = Dados.totalFacas;
        Dados.facaAtual = Instantiate(faca, new Vector3(0, -0.9f, -2), Quaternion.identity);
    }
    void Update() {
        if (Dados.facaAtual.name == "Faca") {
            Dados.facaAtual = Instantiate(faca, new Vector3(0, -0.9f, -2), Quaternion.identity);
        }
        if (Dados.fim) {
            Instantiate(telaGameOver, new Vector3(), Quaternion.identity);
            Dados.fim = false;
        }
    }
}
