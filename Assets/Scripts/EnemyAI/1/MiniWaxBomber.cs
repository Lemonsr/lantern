﻿using System.Collections;
using UnityEngine;

public class MiniWaxBomber : Enemy { //Super fast and explodes
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource explosion;
    private Transform target;
    private bool dead;

    private void Start() {
        GetSprite();
        dead = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {
        if (health <= 0 && !dead) {
            explosion.Play();
            dead = true;
            StartCoroutine(Explosion());
            StartCoroutine(Death());
        }

        if (!dead && Vector2.Distance(transform.position, target.position) > 0) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        animator.SetFloat("Hori", target.position.x - transform.position.x);
        animator.SetFloat("Vert", target.position.y - transform.position.y);
    }
    private IEnumerator Explosion() {
        Collider2D[] hits = Physics2D.OverlapCircleAll(this.GetComponent<Rigidbody2D>().position, 1);
        foreach (Collider2D col in hits) {
            if (col.gameObject.tag == "Player") {
                col.gameObject.GetComponent<Player>().Damage(2);
            } else if (col.gameObject.tag == "Enemy") {
                col.gameObject.GetComponent<Enemy>().Damage(2);
            }
        }
        yield return new WaitForSeconds(0.01f);
    }
    private IEnumerator Death() {
        animator.SetBool("Dead", true);
        GameObject.FindGameObjectWithTag("DungeonSceneManager").GetComponent<Manager1>().EnemiesNow(-1);
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }
}