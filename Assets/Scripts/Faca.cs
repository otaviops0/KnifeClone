using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Faca : MonoBehaviour {
    public int velocidade = 5;
    public AudioClip somLancamento;
    public AudioClip somAcerto;
    public AudioClip somErro;
    private int status;
    private AudioSource som;
    void Start() {
        gameObject.name = "FacaAtual";
        status = 0;
        som = GetComponent<AudioSource>();
    }
    void Update() {
        if (status == 0 && Input.GetMouseButtonDown(0)) {
            status = 1;
            som.PlayOneShot(somLancamento);
        }
        if (status == 1) {
            transform.position += Vector3.forward * velocidade * Time.deltaTime;
        }
        if (status == 3) {
            transform.position -= Vector3.forward * velocidade/4 * Time.deltaTime;
            transform.Rotate(0, 5, 0);
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Roda") {
            this.transform.parent = other.gameObject.transform;
            status = 2;
            Dados.pontos++;
            Dados.facas--;
            gameObject.name = "Faca";
            som.PlayOneShot(somAcerto);
            if (Dados.facas<=0) {
                status = 4;
                Dados.fim = true;
            }
        } else if (status == 1 && other.gameObject.name == "Faca") {
            status = 3;
            som.PlayOneShot(somErro);
            Dados.fim = true;
        }
    }
}
