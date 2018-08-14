using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
    UnityEngine.AI.NavMeshAgent agenteDENavegacion;
    public GameObject destino;
    //private UnityEngine.AI.NavMeshAgent agenteDENavegacion;
	void Start () {
        agenteDENavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agenteDENavegacion.SetDestination(destino.transform.position);
	}
}
