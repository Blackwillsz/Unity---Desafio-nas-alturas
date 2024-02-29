using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour {
    [SerializeField]
    private float velocidade;
    private float deslocamento;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        this.posicaoInicial =this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    private void Update() {
        deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
