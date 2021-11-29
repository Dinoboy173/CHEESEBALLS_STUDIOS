using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioKeys
{ 
    MASTERVOLUME,
    VOLUME,
    PITCH,
    CLIP,
    TIME
};

public enum SoundNames
{
    MainTheme,
    BeachTheme,
    CaveTheme,
    MansionTheme,
    ButtonClick,
    VowelA,
    VowelE,
    VowelI,
    VowelO,
    VowelU
};

public enum Scenes
{
    NULL,
    MainMenuScene,
    IntroScene,
    OutroScene,
    MapScene,
    BeachScene,
    CaveScene,
    MansionScene
};

public enum CheeseQuestTriggers
{
    CheddarQuestActive,
    CheddarQuestComplete,
    SwissQuestActive,
    SwissQuestComplete,
    BlueQuestActive,
    BlueQuestComplete
};