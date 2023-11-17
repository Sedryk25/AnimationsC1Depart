using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttraperTorche : MonoBehaviour
{
    [SerializeField] GameObject _monJoueur;
    [SerializeField] GameObject _torcheMur;
    [SerializeField] GameObject _torcheJoueur; 


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _torcheMur.SetActive(false); 
            _torcheMur.SetActive(true);
        }
    }
}
