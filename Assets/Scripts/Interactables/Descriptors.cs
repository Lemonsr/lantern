﻿using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Descriptors : Interactable {
    [SerializeField] private string descriptorDesc;
    [SerializeField] private Dialogue dialogue;
    private Player player;
    public void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        objDesc = descriptorDesc;
    }
    public override void Interact() {
        if (!player.inDialogue) {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        } else {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }
}
