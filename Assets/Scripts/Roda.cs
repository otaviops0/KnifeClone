using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Roda : MonoBehaviour {
    public float acelFacil;
    public float acelMedio;
    public float acelDificil;
    public float velFacio;
    public float velMedio;
    public float velDificil;
    private float aceleracao;
    private float velMaxima;
    private Boolean horario;
    private float velocidade;
    void Start() {
        gameObject.name = "Roda";
        switch (Dados.dificuldade) {
            case 1:
                aceleracao = acelFacil;
                velMaxima = velFacio;
                break;
            case 2:
                aceleracao = acelMedio;
                velMaxima = velMedio;
                break;
            case 3:
                aceleracao = acelDificil;
                velMaxima = velDificil;
                break;
        }
        velocidade = velMaxima;
    }
    void Update() {
        transform.Rotate(0, velocidade*Time.deltaTime, 0);
        if (horario) {
            velocidade -= aceleracao * Time.deltaTime;
            if (velocidade <= -velMaxima) {
                horario = false;
            }
        } else {
            velocidade += aceleracao * Time.deltaTime;
            if (velocidade >= velMaxima) {
                horario = true;
            }
        }
    }
}
