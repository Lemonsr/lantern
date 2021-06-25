﻿using System.Collections;
using UnityEngine;

public class DataStorage : MonoBehaviour {
    public static Hashtable saveValues = new Hashtable();
    /*
    int volume => Stored in PlayerPrefs

    int health;

    int maxHealth;

    Vector2 position;

    string currScene;
    
    int facingDirection

    int deaths;
    after 3 deaths, trigger blacksmith

    int blacksmith;
    0 for Lumin haven't talked to blacksmith, 1 for seen blacksmith already

    int upgrade;
    0 for No Upgrade, 1 for Vampric Embrace, 2 for Fleet Foot, 3 for Nova Impact

    int upgradeBar;
    tracks upgrade progress till can trigger upgrade

    int introSceneDone;
    0 for not done, 1 for done: triggers bedroom tutorial

    int tutorialDojo;
    0 for tutorial to trigger, 1 for talking to the Senior Warden to fire at the dummies, 2 for finishing the tutorial

    int messHall;
    0 - haven't finished wax dungeon
    1 - finished wax dungeon

    int progress; 
    0 - haven't done tutorial yet
    1 - finished tutorial, haven't talked to priest
    2 - talked to priest, haven't entered dungeon (enable Wax Dungeon Button)
    3 - attempted wax dungeon, died
    4 - completed wax dungeon, haven't talked to priest
    5 - completed wax dungeon, talked to priest

    int blessings;
    0 - have not died yet
    1 - died the first time (need a way to differentiate which part the player died from)
    2 - already introduced to blessings

    int usedBlessings;
    0 - did not use blessings (easter egg available)
    1 - used blessings (no easter egg available)

    int waxDungeonRoom;
    0 to 8 - tracks what room the player is in for Wax Dungeon

    int[] randWaxDungeonArray;
    [] - Randomly generates what rooms the Player goes through

    int completedWaxDungeon;
    0 - haven't finished the Wax Dungeon
    1 - attempted but haven't finished Wax Dungeon
    2 - finished the Wax Dungeon

    int waxDungeonGolem;
    0 - haven't seen golem
    1 - fought and lost against golem
    2 - fought and won golem

    int waxDungeonFourArms;
    0 - haven't seen four arms
    1 - fought and lost against four arms
    2 - fought and won four arms

    int waxDungeonGabriel;
    0 - haven't seen Gabriel
    1 - fought and lost against Gabriel
    2 - fought and won Gabriel

    //For end game//

    int finalBossBeatenCount;
    how many times you've beaten the final boss

    bool reversedControls;

    bool blackOut;

    bool timeTrial

    float timeTrialTime;
    Keeps track of how much time you have left

    int completedReversedControls

    int completedBlackOut;

    int completedTimeTrial
    */
}