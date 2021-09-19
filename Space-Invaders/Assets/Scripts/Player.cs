using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Projectile laserPrefab;
    public float speed = 5.0f;
    private bool _laserActive;
    public bool isAlive = true;
    private UImanager _uiManager;

    public int remainingShields = 3;

    private void Start()
    {
        _uiManager = GameObject.Find("UICanvas").GetComponent<UImanager>();
    }

    private void Update(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }

    private void Shoot(){
        if (!_laserActive){
            Projectile projectile = Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += LaserDestroyed;
            _laserActive = true;
            SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Shoot);
        }
    }

    private void LaserDestroyed(){
        _laserActive = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
            if (remainingShields > 0)
            {
                remainingShields = remainingShields - 1;
                _uiManager.updateShields(remainingShields);
                SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.PlayerGotShot);
            }
            else
            {
                //LOSE THE GAME
                this.gameObject.SetActive(false);
                SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Lose);
                isAlive = false;
            }
        }
    }
}
