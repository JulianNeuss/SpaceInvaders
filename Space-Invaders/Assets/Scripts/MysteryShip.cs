using UnityEngine;

public class MysteryShip : MonoBehaviour
{
    public float speed = 5.0f;
    public System.Action killedShip;

    private void Update(){
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);

        this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        if(this.transform.position.x <= leftEdge.x + 1.0f){
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == LayerMask.NameToLayer("Laser")){
            this.killedShip.Invoke();
            this.gameObject.SetActive(false);
            SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.MysteryShipKilled);
        }
    }

}


  

	
	
   