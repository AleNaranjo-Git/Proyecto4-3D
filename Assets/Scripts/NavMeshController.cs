using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshController : MonoBehaviour
{

    public Transform objetivo;
    private UnityEngine.AI.NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;
    }
}
