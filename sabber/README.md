<p align="center">
<img src="docs/readme/sabberstone.png" alt="SabberStone logo" height="80%"/>
</p>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
[![Travis Build Status](https://travis-ci.org/HearthSim/SabberStone.svg?branch=master)](https://travis-ci.org/HearthSim/SabberStone)
[![AppVeyor Build status](https://ci.appveyor.com/api/projects/status/cncu269gxx9x6l3i?svg=true)](https://ci.appveyor.com/project/Bert-Proesmans/sabberstone)


# Overview

**State of Implementation: 100% (Kobolds and Catacombs 100%) of current Standard Cards (Year of the ... Maaaaaamooouth)!** ***(03.04.2018)***

SabberStone is just another Hearthstone simulator and implementation, written in C#. The project was started in Nov'16 while trying to implement aura, buffs & triggers into Brimstone. Focused to prototype my so called onion system I created SabberStone, which is using a layer approach to handle entity changing enchantments. Since then I haven't stopped implementing day by day new cards, new tests and new stuff. I created for fun a visualisation and a scoring based tree search a.i. which can be used to play games ([SabberStoneGui](/extensions/SabberStoneGui)).

By now this is a one man show, but there is still a lot of work to do, so any help is appreciated. The base code of Brimstone was a great inspiration for this project. Big thanks to **@Pattux**, **@Patashu** for helping on hearthstone super science problems ^^ thx **@Katy** for inspiration. And thx a lot to **@Citiral**, **@BertP** for working out on the stove implementation. And thx to **@Milva** who did a refactoring on the aura & enchantment system, with great value and is working hard for this project! You're welcome!

Join us on [Discord](https://discord.gg/my9WTwK)!

**Sabberstone Simulator can be connected to the real Hearthstone client!**
![Preview SabberStone connected to the Stove project](docs/readme/stove.PNG)

### Project Structure ###

* **SabberStoneCore** *(.NET Core)*

  Core simulator engine, all the functions needed for the simulator are in here. Check out the Wiki [Link](https://github.com/HearthSim/SabberStone/wiki) for informations about the core and how to use it.

* **SabberStoneCoreTest** *(.NET Core)*

  UnitTest for the simulator, there is a generated test for each card in the current game.

* **SabberStoneCoreConsole** *(.NET Core)*

  A test project to run simple codeline based games to test outcome.

* **SabberStoneCoreAi** *(.NET Core)*

  A test project to run A.I. simulations with predefinied decks and strategys.

* **SabberStoneGui** *(.NET Framework)*

  A test project that shows off a visual implementation of the SimpleAi project. This is probably where beginners should start looking at. There is a simple GUI which allows different decks to play against each other with different strategys. Check out the Wiki [Link](https://github.com/HearthSim/SabberStone/wiki/SabberStoneGui) for informations about the use of SimpleUi.

### Cards Implementation

- [x] Aura, Enchantment & Trigger
- [x] Hero, Hero Power & Weapon
- [x] Battlecry & Deathrattle
- [x] Choose One & Combo
- [x] Spell Power
- [x] Inspire, Joust & Discover
- [x] Jade Golems (Jade Lotus)
- [x] Buffing Hand (Grimy Goons)
- [x] Excess Mana
- [x] Freeze, Stealth & Poisonous
- [x] Potions (Kabal) ex. Kazakus
- [x] Adapt
- [x] Quest
- [ ] Spell Bender Phase
- [ ] Spell Text Phase (check if not already done)

**Basic & Classic**
* **100% Basic (142 Cards)**
* **100%% Classic (239 Cards)**
* 70% Hall of Fame (10 Cards)

**Adventures**
* **100% Blackrock Mountain (31 Cards)**
* **100% One Night in Karazhan (45 Cards)**
* *93% The League of Explorers (45 Cards) (needs to be upgraded to new system)*

**Expensions**
* **100% Kobolds and Catacombs (135 Cards)**
* **100% Knights of the Frozen Throne (135 Cards)**
* **100% Journey to Un'Goro (135 cards)**
* *91% The Grand Tournament (132 Cards) (needs to be upgraded to new system)*
* **100% Whispers of the Old Gods (134 Cards)**
* **100% Mean Streets of Gadgetzan (132 Cards)**
* *8% Goblins vs Gnomes (123 cards) (needs to be upgraded to new system)*
* *6% Curse of Naxxramas (30 cards) (needs to be upgraded to new system)*

*(Standard is beeing prioritized.)*

### ToDo List ###

- [x] move SabberStone to Github
- [x] start Wiki for SabberStone
- [x] moved from .NET Framework to .NET Core
- [x] make tasksystem stateful
- [ ] create a sync with a current game (hook on the power.log)
- [ ] integrate inter phases split.
- [ ] implement caching for performance opt.
- [ ] fill wiki for SabberStone

### Requirements

* Windows, macOS or Linux
  - [Visual Studio 2017 RC](https://www.microsoft.com/net/core#windowsvs2017) or [Visual Studio Code](https://code.visualstudio.com/) for best .NET Core support
  - [.NET Core](https://www.microsoft.com/net/download/core)

### Installation

* tbd

### Documentation

* Wiki [Link](https://github.com/HearthSim/SabberStone/wiki)
* SabberStoneCoreAi [Link](https://github.com/HearthSim/SabberStone/tree/master/SabberStoneCoreAi)
* SabberStoneCoreGui [Link](https://github.com/HearthSim/SabberStone/wiki/SabberStoneGui)

### License

[![AGPLv3](https://www.gnu.org/graphics/agplv3-88x31.png)](http://choosealicense.com/licenses/agpl-3.0/)

SabberStone is licensed under the terms of the
[Affero GPLv3](https://www.gnu.org/licenses/agpl-3.0.en.html) or any later version.

### Community
SabberStone is being developed by darkfriend77 (darkfriend@swissonline.ch)
* SabberStone on [Discord](https://discord.gg/my9WTwK) .. come and talk with us!
* SabberStone on [Reddit](https://redd.it/5p0ar8)
* SabberStone is a [HearthSim](http://hearthsim.info) project.
