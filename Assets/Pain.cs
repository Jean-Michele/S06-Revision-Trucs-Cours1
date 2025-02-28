using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pain : MonoBehaviour
{
    [SerializeField] GameObject _Boite;
    [SerializeField] GameObject _Drapeau;
    [SerializeField] GameObject _Champignons;

   void Start()
    {
        float RandomValue = Random.Range(0f, 1f);

        if(RandomValue > 0.5f){
            Instantiate(_Champignons, _Boite.transform.position, _Boite.transform.rotation);
        }
        else{
            Instantiate(_Champignons, _Drapeau.transform.position, _Drapeau.transform.rotation);
        }
    }
}
