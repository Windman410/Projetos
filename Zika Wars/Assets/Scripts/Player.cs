using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{

    private Controls control;
    public GameObject[] enemies;
    public GameObject[] spawners;
    public GameObject[] doors;
    private Score scoreUI;
    private Health healthUI;
    private Action actionUI;
    private GameObject attackRange;
    private GameObject player;
    public GameOver gameOver;
    public int health;
    public float invTime;
    public float invCooldown;
    public float actionTime;
    public float actionCooldown;
    public float doorCooldown;
    public float doorTime;
    public int enemyKills;
    public int spawnerKills;
    public int spawnerMax;
    public GameObject victoryObjects;
    GameObject[] controlObjects;
    GameObject[] topUIObjects;
    AudioSource[] sounds;
    AudioSource hurtSound;
    public float h;
    PauseMenu pause;


    void Start(){
        control = FindObjectOfType<Controls>();
        scoreUI = FindObjectOfType<Score>();
        healthUI = FindObjectOfType<Health>();
        actionUI = FindObjectOfType<Action>();
        attackRange = GameObject.FindGameObjectWithTag("Attack");
        player = GameObject.FindGameObjectWithTag("Player");
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        spawnerMax = spawners.Length;
        gameOver = player.GetComponent<GameOver>();
        invTime = 0;
        controlObjects = GameObject.FindGameObjectsWithTag("GameController");
        topUIObjects = GameObject.FindGameObjectsWithTag("UserInterfaceTop");
        sounds = GetComponents<AudioSource>();
        hurtSound = sounds[1];

        sounds = null;
    }

    void Update(){
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        doors = GameObject.FindGameObjectsWithTag("Door");
        bool spawnerFlag = false;
        bool doorFlag = false;
        if (invTime > 0)
        {
            invTime -= Time.deltaTime;
        }
        if (doorTime > 0)
        {
            doorTime -= Time.deltaTime;
        }
        if (health <= 0){
            SceneManager.LoadScene("GameOver");

        }
        if (actionTime >= 0)
        {
            actionTime -= Time.deltaTime;
        }
        //adicionar porta de saida
        if(spawnerMax == spawnerKills)
        {
            SceneManager.LoadScene("Victory");
        }

        if (spawnerMax != spawnerKills){
            foreach (GameObject g in spawners){
                if (player.GetComponent<BoxCollider2D>().bounds.Intersects(g.GetComponent<BoxCollider2D>().bounds)){
                    Spawner script = (Spawner)g.GetComponent(typeof(Spawner));
                    if (script.activeSpawn){
                        actionUI.changeSpriteSpawner();
                        spawnerFlag = true;
                    }
                    
                }
            }
        }

        if (!spawnerFlag){
            foreach (GameObject g in doors){
                if (g.name == "Door(Clone)")
                    Destroy(g);
                if (player.GetComponent<BoxCollider2D>().bounds.Intersects(g.GetComponent<BoxCollider2D>().bounds))
                {
                    actionUI.changeSpriteDoor();
                    doorFlag = true;
                }
            }
        }

        if (!(spawnerFlag) && !(doorFlag)){
            actionUI.changeSpriteAttack();
        }

        if (Input.GetButtonDown("Fire3")){
            Action();
        }


        float h = Input.GetAxisRaw("Horizontal");


        if (h > 0){
            RightArrow();
        } else if (h < 0){
            LeftArrow();
        } else if(h == 0){
            ReleaseLeftArrow();
            ReleaseRightArrow();
        }

        if (Input.GetButtonDown("Pause"))
        {
            Debug.Log("Pause");
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pause.showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pause.hidePaused();
            }
        }

        if (Input.GetButtonDown("Select"))
        {
            Debug.Log("Select");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void LeftArrow(){
        control.moveright = false;
        control.moveleft = true;
        control.direction = -1;
    }

    public void RightArrow(){
        control.moveright = true;
        control.moveleft = false;
        control.direction = 1;
    }

    public void ReleaseLeftArrow(){
        control.moveleft = false;
    }

    public void ReleaseRightArrow(){
        control.moveright = false;
    }

    public void Jump(){
        control.jump = true;
    }

    public void Action(){
        bool spawnerFlag = false;
        bool doorFlag = false;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        doors = GameObject.FindGameObjectsWithTag("Door");
        
        if (actionTime <= 0)
        {
            actionTime = actionCooldown;
            if (spawners.Length != spawnerKills)
            {
                foreach (GameObject g in spawners)
                {
                    if (player.GetComponent<BoxCollider2D>().bounds.Intersects(g.GetComponent<BoxCollider2D>().bounds))
                    {
                        Debug.DrawLine(this.transform.position, g.transform.position, Color.red, 1);
                        Spawner script = (Spawner)g.GetComponent(typeof(Spawner));
                        if (script.activeSpawn)
                        {
                            scoreUI.scoreUp(500);
                            script.CloseSpawner();
                            spawnerKills++;
                            spawnerFlag = true;
                        }
                    }
                }
            }

            if (!spawnerFlag)
            {
                foreach (GameObject g in doors)
                {
                    if (player.GetComponent<BoxCollider2D>().bounds.Intersects(g.GetComponent<BoxCollider2D>().bounds))
                    {
                        Debug.DrawLine(this.transform.position, g.transform.position, Color.red, 1);
                        g.GetComponent<Animator>().SetBool("open", true);
                        Door script = (Door)g.GetComponent(typeof(Door));
                        script.StartCoroutine("openDoor");
                        doorFlag = true;
                    }
                }
            }


            if (!(spawnerFlag) && !(doorFlag))
            {
                StartCoroutine("playerAttack");
            }
        }
    }

    IEnumerator takeDamage(){
        if(invTime <= 0){
            hurtSound.Play();
            health--;
            healthUI.healthDown();
            invTime = invCooldown;
        }
        yield return null;
    }

    public void LoseGame(){
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator playerAttack()
    {
        player.GetComponent<Animator>().SetBool("attacking", true);
        foreach (GameObject g in enemies)
        {
            if (attackRange.GetComponent<BoxCollider2D>().bounds.Intersects(g.GetComponent<CircleCollider2D>().bounds))
            {
                Debug.DrawLine(this.transform.position, g.transform.position, Color.red, 1);
                Destroy(g);
                scoreUI.scoreUp(100);
                enemyKills++;
            }
        }
        yield return new WaitForSeconds(0.1f);
        player.GetComponent<Animator>().SetBool("attacking", false);
        yield return null;

        

    }

}