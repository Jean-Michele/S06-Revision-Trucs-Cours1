using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesOr : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] GameObject _instantiateCopper;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        Instantiate(_prefabOriginal, _instantiateCopper.transform.position, _instantiateCopper.transform.rotation);
    }
}
