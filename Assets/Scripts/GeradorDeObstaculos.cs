using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour{
    [SerializeField]
    private float tempoParaGerar;
    [SerializeField]
    private GameObject manualDeInstrucoes;
    private float cronometro;
    [SerializeField]
    private float velocidade = 0.5f;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    private void Update() {

        this.cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            GameObject.Instantiate(manualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
            this.transform.Translate(Vector3.left * this.velocidade);
        }
    }
}
