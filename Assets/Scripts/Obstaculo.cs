using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
    [SerializeField]
    private float velocidade = 0.5f;
    [SerializeField]
    private float variacaoDaPosicaoY;
    private Vector3 posicaoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * UnityEngine.Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start()
    {
        this.posicaoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }

    private void Update() {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        if(!this.pontuei && this.transform.position.x < this.posicaoAviao.x)
        {
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        this.Destruir();
    }

    public void Destruir() { 
        GameObject.Destroy(this.gameObject);
    }
}
