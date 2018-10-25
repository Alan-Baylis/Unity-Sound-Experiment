using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class earRape : MonoBehaviour {

	public float movex;
	public bool play = true;
	public bool randomAudioOnMovement = true;
	public int trackPicker;

	public AudioClip alia;
	public AudioClip brexit;
	public AudioClip evilmorty;
	public AudioClip flamingo;
	public AudioClip fortnite;
	public AudioClip kazoo;
	public AudioClip monster;
	public AudioClip pumpedupkicks;
	public AudioClip russia;
	public AudioClip shark;
	public AudioClip shutdown;
	public AudioClip startup;
	public AudioClip strongandstable;
	public AudioClip thomas;
	public AudioClip ting;
	public AudioClip vape;
	public AudioClip vitas;
	public AudioClip wiisports;

	IEnumerator SoundReset(){
		yield return new WaitForSeconds(5);
		play = true;
	}

	// Use this for initialization
	void Start () {
		StartCoroutine(SoundReset());
	}
	
	// Update is called once per frame
    void Update () {

		// Toggle Random Audio on movement
		if (Input.GetKeyDown(KeyCode.O)){
            Debug.Log("Random Audio on Movement - On");
			randomAudioOnMovement = true;
        }

		if (Input.GetKeyDown(KeyCode.P)){
            Debug.Log("Random Audio on Movement - Off");
			randomAudioOnMovement = false;
        }

		// Bottom Row
		if (Input.GetKeyDown(KeyCode.Z)){
            AudioSource.PlayClipAtPoint(russia, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.X)){
            AudioSource.PlayClipAtPoint(vape, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.C)){
            AudioSource.PlayClipAtPoint(vitas, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.V)){
            AudioSource.PlayClipAtPoint(fortnite, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.B)){
            AudioSource.PlayClipAtPoint(startup, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.N)){
            AudioSource.PlayClipAtPoint(shutdown, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.M)){
            AudioSource.PlayClipAtPoint(brexit, new Vector3(5, 1, 2));
        }

		// Middle Row

		if (Input.GetKeyDown(KeyCode.F)){
            AudioSource.PlayClipAtPoint(flamingo, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.G)){
            AudioSource.PlayClipAtPoint(evilmorty, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.H)){
            AudioSource.PlayClipAtPoint(alia, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.J)){
            AudioSource.PlayClipAtPoint(strongandstable, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.K)){
            AudioSource.PlayClipAtPoint(kazoo, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.L)){
            AudioSource.PlayClipAtPoint(shark, new Vector3(5, 1, 2));
        }

		// Top row

		if (Input.GetKeyDown(KeyCode.E)){
            AudioSource.PlayClipAtPoint(fortnite, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.R)){
            AudioSource.PlayClipAtPoint(pumpedupkicks, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.T)){
            AudioSource.PlayClipAtPoint(thomas, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.Y)){
            AudioSource.PlayClipAtPoint(monster, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.U)){
            AudioSource.PlayClipAtPoint(ting, new Vector3(5, 1, 2));
        }

		if (Input.GetKeyDown(KeyCode.I)){
            AudioSource.PlayClipAtPoint(wiisports, new Vector3(5, 1, 2));
        }

		if (randomAudioOnMovement == true) {
			int trackPicker = UnityEngine.Random.Range(1, 18);

			movex = Input.GetAxis("Horizontal");
			if (movex != 0.0f && play == true){
				

				if (trackPicker == 1) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(alia, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 2) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(brexit, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 3) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(evilmorty, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 4) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(flamingo, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 5) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(fortnite, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 6) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(kazoo, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 7) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(monster, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 8) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(pumpedupkicks, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 9) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(russia, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 10) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(shark, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 11) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(shutdown, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 12) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(startup, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 13) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(strongandstable, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 14) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(thomas, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 15) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(ting, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 16) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(vape, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 17) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(vitas, new Vector3(5, 1, 2));
					play = false;
				}

				if (trackPicker == 18) {
					Debug.Log(trackPicker);
					AudioSource.PlayClipAtPoint(wiisports, new Vector3(5, 1, 2));
					play = false;
				}
		}
	}


		
	}
}