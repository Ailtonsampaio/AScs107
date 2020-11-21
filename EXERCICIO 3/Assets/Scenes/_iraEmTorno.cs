using UnityEngine;
using System.Collections;

public class GiraEmTorno : MonoBehaviour {

	public Transform alvo; // objeto em torno de qual vamos girar
	public int velocidade; // velocidade da rotação
	public Vector3 eixoRotação = Vector3.up;
	
	void Start() {
		if (alvo == null) 
		{
			alvo = this.gameObject.transform;
			Debug.Log ("Alvo do GiraEmTorno não foi especificado, objeto vai girar em torno de si mesmo");
		}
	}

	// Update is called once per frame
	void Update () {
		// RotateAround leva três argumentos, primeiro é o ponto alvo de rotação
		// segundo é o vetor da direção da rotação
		// terceiro, é a quantidade de graus que vai girar
		// como o update roda a cada frame, vai girar essa quantidade por cada frame
		
		transform.RotateAround(alvo.transform.position,eixoRotação,velocidade * Time.deltaTime);
	}
}
