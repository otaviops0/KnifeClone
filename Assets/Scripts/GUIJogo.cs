using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIJogo : MonoBehaviour {
    public Text txtPontos;
    public GameObject painel;
    public Image iconeFaca;
    public Sprite comFaca;
    public Sprite semFaca;
    private List<Image> iconesFaca;
    void Start() {
        iconesFaca = new List<Image>();
        for (int i=0;i<Dados.totalFacas;i++) {
            GameObject facaIco = new GameObject();
            Image imagem = facaIco.AddComponent<Image>();
            iconesFaca.Add(imagem);
            imagem.sprite = comFaca;
            imagem.rectTransform.sizeDelta = new Vector2(40, 40);
            facaIco.GetComponent<RectTransform>().SetParent(painel.transform);
            facaIco.transform.position = new Vector3(20, i * 40 + 20, 0);
            facaIco.SetActive(true);
        }
    }
    void Update() {
        txtPontos.text = Convert.ToString(Dados.pontos);
        for (int i = 0; i < iconesFaca.Count; i++) {
            if (i >= Dados.facas) {
                iconesFaca[i].sprite = semFaca;
            } else {
                iconesFaca[i].sprite = comFaca;
            }
        }
    }
}
