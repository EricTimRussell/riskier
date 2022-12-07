<template>

  <body>
    <header class="sticky-top">
      <Navbar />
    </header>
    <main>
      <router-view />
    </main>
    <footer class="sticky-bottom bg-green text-end px-3">
      <i class="mdi mdi-book-open-variant fs-1 text-light selectable" title="Rule Book" data-bs-toggle="modal"
        data-bs-target="#staticBackdrop"></i>
    </footer>
  </body>

  <!-- Create Region Modal -->
  <section>
    <div class="modal fade" id="createRegion" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="exampleModalLabel">Create Region</h1>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            <CreateRegionForm />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Rule Book Modal -->
  <section>
    <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1"
      aria-labelledby="staticBackdropLabel" aria-hidden="true">
      <div class="modal-dialog modal-dialog-scrollable">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="staticBackdropLabel">Rule Book:</h1>
            <div class="input-group length">
              <input type="text" class="form-control" placeholder="Search..." aria-label="Search"
                aria-describedby="basic-addon1">
            </div>
          </div>
          <div class="modal-body">
            <h2>Resources</h2>
            <p>--Resources are determined by the roll of a D6 for each tile
              captured, except for the
              tiles with cities
              on them. Each tile contains capital, industry, and agriculture and a D6 should be rolled to determine the
              amount of each for every tile captured.
              <br>
              --Cities are worth a pre-deterimed amount based on their size or importance. A players
              capital is worth 15 of each resource. A captured capital is worth 10 of each. A medium sized city is worth
              6 of each
              resources. A small city is worth 4 of each resource.
              <br>
              --City size can be determined by the number of buildings present on the board piece. 5 buildings is a
              capital size. 4 is a medium city and 3 is a small city.
              <br>
              --Water tiles can be owned by players so long as all the land tiles around the water are controlled by 1
              player. Water tiles can only produce Agriculture they cannot produce Capital or Industry. Water tiles are
              worth 3 agriculture points per tile. Once all the land is controlled around the water tile(s) by one
              player that player can immediately add those water tiles to their owned regions list.
              <br>
              --Losing water tiles occures when another player takes a majority (more than 50%) of the land tiles around
              the water tiles.
              <br>
              --Players cannot own any of the water on the outside of the board. Only the physical water tiles can be
              owned.
            </p>
            <br>
            <h2>Supplies</h2>
            <p>--Supplies are a citical component that players will need to manage to ensure their armies are
              prepared.
              <br>
              --Capital and medium sized cities produce 1 ammo per turn and can store ammo in warehouses when built in
              adjacent tiles. If cities do not have a warehouse they do not produce anything.
              <br>
              --If the warehouses in a city are full the city will stop producing supplies until more warehouses are
              built or supplies are moved via supply trucks or transport aircraft.
              <br>
              --Supply trucks can be built to transport up to 3 supplies across the map. When supply trucks reach their
              destination the supplies can be instantly transferred to the units on that tile.
              <br>
              --1 supply peg is enough for 1 battle. This includes any offensive or defensive operations. Any unit(s)
              involved in a battle use up 1 supply.
              <br>
              --Black pegs on the board represent supplies. One peg is considered one supply point.
            </p>
            <br>
            <h2>Unit Types & General Rules</h2>
            <div class="text-center">
              <h3>--Land Units--</h3>
            </div>
            <p>
              --All units have a set amount of movement points and offensive points. Movement points are the number of
              times a unit can move on the combat board per turn. Offensive points are the number of times a unit can
              attack per turn. Range is the distance a unit can attack an enemy. A range of 1 means the unit can only
              attack tiles that are next to them.
              <br>
              <strong>--Infantry</strong> are a more defensively balanced unit with limited offensive capabilities. They
              have the ability to occupy fortifications giving them a boost to defensive durability. Infantry have 1
              movement point, 1 offensive point, and a range of 1.
              <br>
              <strong>--Special Forces</strong> are similar to infantry in that they are defensively balanced, but are a
              fair bit more effective offensively. They also have the ability to occupy fortifications. Special forces
              have access to certain operational events that no other unit has. Special forces have the ability to
              carry laser designators giving artillery more accuracy and gaining access to destroyer artillery if
              applicable. SF units have 1 movement point, 1 offensive point, and a range of 1.
              <br>
              <strong>--Mechanized Infantry (Mech)</strong> are a heavier more mobile version of infantry. They are
              balanced
              between offensive ability and defensive ability. Making these units slightly more effective at taking on
              heavier opponents. Mech units have 2 movement points, 1 offensive point, and a range of 1.
              <br>
              <strong>--Infantry Fighting Vehicle (IFV)</strong> are essentially light tanks that are effective at
              taking on infantry and Mechanized units. They are average at taking on other IFV's and are ineffective at
              taking on MBT's. IFV's have 3 movement points, 1 offensive point, and a range of 1.
              <br>
              <strong>--Main Battle Tank (MBT)</strong> are the offensive work horse of any ground assault. They are
              effective at taking on any ground enemy, but have very limited defensive capabilities. MBT's have 2
              movement points, 2 offensive points, and a range of 1.
              <br>
              <strong>--Anti-aircraft</strong> is a players ground defense from aircraft. They can fire 2 AA missiles at
              aircraft that are within range. They have no other offensive ability and do not have any defensive
              ability. If they are attacked by ground units they are immediately destroyed. AA have 1 movement point, 1
              offensive point, and a range of 2 on the CB (Combat Board). On the main board any aircraft that attacks a
              tile with AA will have to survive 1 shot from the AA unit before it can attempt to destroy its target.
              <br>
              <strong>--Artillery</strong> carry more ammo than missile artillery however they are fairly ineffective
              unless they have special forces with a laser designator guiding their shots. Artillery have 1 movement
              point, 1 offensive point, and a range of 3 on the combat board. On the main board artillery can fire into
              adjacent tiles so long as there are no fortifications present on that tile. Artillery cannot fire into
              tiles with fortifications.
              <br>
              <strong>--SS-Artillery</strong> is a very effective form of artillery but is limited on its ammunition and
              the enemies ability to shoot down surface-to-surface missiles. They do not have any defensive
              ability. Missile artillery are not used on the combat board. They have a range of 2 tiles on the main
              board. SS-Artillery needs to be re-supplied after each shot.
              <br>
              <strong>--Supply Truck</strong> moves supplies from warehouses to your units on the battlefield as well as
              to naval yards to supply your navy. Has no offensive or defensive ability and can move 1 tile per turn on
              the MB. Supply trucks are not used on the CB.
            </p>
            <div class="text-center">
              <h3>Air Units</h3>
            </div>
            <p>
              <strong>--Fighter Aircraft</strong> provide more flexable AA cover for ground units with a limited ability
              to strike ground targets. Fighter aircraft have 4 movement points, 1 offensive point, and a range
              of 2 on the combat board. They can move 3 tiles on the main board per turn. Fighter aircraft must
              stay within 3 tiles of an
              airfield. Once a fighter aircraft has used its 1 offensive point (on the main
              board) the player will immediately return it to
              an airfield within range. Fighters on the combat board can remain for the duration of the battle but once
              they are taken off the combat board or the battle ends they will be immediately moved to a airfield within
              range. Fighters can only attack once and then have to return to an airfield before they
              can attack again on the main board. Fighters also have the ability to attack on the main board wherever
              they want so long as
              they are within 3 tiles of an owned airfield.
              <br>
              <strong>--Close Air Support (CAS)</strong> aircraft are very effective at destroying ground targets and
              provide some air cover against other CAS aircraft. However, they cannot target fighter aircraft and only
              have a small chance to evade fighter attacks. CAS have 3 movement points, 2 offensive points, and a range
              of 1 on the combat board. CAS cannot attack on the main board.
              <br>
              <strong>--Supply Aircraft</strong> can deliver supplies by air to ground units and transport units
              from airfield to airfield. They can also be used to deploy special
              forces units and infantry by air as paratroopers. They have no offensive or defensive ability. Supply
              aircraft are not used on the combat board. They can move 2 tiles per turn on the main board.
            </p>
            <div class="text-center">
              <h3>Navy Units</h3>
            </div>
            <p>
              <strong>--Carriers</strong> have the ability to carry up to 8 fighter aircraft and CAS. They are durable
              ships and rely on their aircraft for offensive and defensive capabilities. Carriers have point defense
              systems that let
              them target incoming missiles and aircraft. Carriers also have the ability to transport and land up to 6
              ground units. Carriers have 1 movement point and no offensive points, however they can deploy 2 aircraft
              per turn. Carriers point defense has a range of 1 on the mainboard and the combat board.
              <br>
              <strong>--Cruisers</strong> are much more versatile than destroyers, but are not as durable or nimble.
              They have the ability to deploy 3 surface-to-surface missiles and have infinite AA missiles. They
              have a small cannon that is mostly effective at htting other cruisers. Cruisers have 2 movement points and
              1 offensive point. On the combat board and the main board cruisers AA has a range of 1 and their SS
              missiles have a range of 3. The cannon has a range of 1. A cruisers cannon cannot fire at land targets.
              <br>
              <strong>--Destroyers</strong> are heavy combat vessels with large guns and heavy armor giving them the
              ability to absorb hits. They are smaller and more nimble than most naval vessals and are great at
              destroying other naval vessels. They have no AA ability. Destroyers have 2 movement points and 2 offensive
              points with a range of 1. Destroyers have the ability to provide fire support to land battles so long as
              they are adjacent to the tile where the battle is taking place. They can only fire when there is a special
              forces unit with a laser designator directing its fire.
            </p>
            <div class="text-center">
              <h3>Combat Rules</h3>
            </div>
            <p>
              --Before combat begins be sure to place any item cards face up in front of the player at the combat board
              when being used.
              <br>
              --The defending player places their units first on the board and then the offensive player places theirs.
              There is a maximum of 12 ground units each for both sides on the board at one time. There is no limit on
              aircraft. A maximum of 2 ground units can share the same tile, however there is no limit on aircraft. If
              there are more than 12 defending units involved the defending player can decide to retreat the extra units
              or keep them as reserves to be used in combat later. Offense can only deploy a max of 12 units at one time
              as well, but does not get to use reserves. The defending player will place their 3 bunkers (only infantry
              or Special forces can use bunkers) and all their units involved and place them in the middle of the combat
              board. The defending player cannot place units on first row of tiles closest to them.
              <br>
              --Infantry/Special forces that occupy fortifications take 2 hits to destroy. If a player only lands 1
              successful hit then the fortification is destroyed and removed from play but the infantry remains. Tiles
              with fortifications can only have 1 unit at a time on that tile.
              <br>
              -- The defending player must deploy all their units possible up to the maximum of 12. For example the
              defending player cannot deploy 2 units and have the other 10 retreat. If they wish to try and retreat they
              need to follow the retreat rules.
              <br>
              --The offensive player will place their units as close to the defending player as they wish. However, they
              cannot place their units behind the defending player unless they are using the paratroopers item.
              <br>
              --During combat if the defending player loses units they can deploy reserves and they will enter the
              combat board in the row closest to the defending player. When reserve are placed they cannot move until
              the next turn.
              <br>
              --During combat every unit is subject to their environmental rules to determine their probabilities of
              hitting and missing attacks.
              <br>
              --Fighters and CAS can be deployed immediately or they can be set to the side and called up when players
              wish to use them. When aircraft are deployed they will be placed on the 1st row closest to the player
              deploying the aircraft. Fighter aircraft can move and attack immediately. CAS can move immediately but
              they cannot attack until the players next turn.
              <br>
              --Any action an aircraft takes when they are within AA range the AA gets to fire 1 shot at the aircraft.
              This applies to all AA that is in range. For example if a player moves their aircraft into AA range the AA
              get to fire at them first before the aircraft can do anything else. During that same turn if that aircraft
              moves onto another tile and is still within AA range the AA gets to fire again. This can occur as many
              times as the aircraft moves within AA range.
              <br>
              <strong>--Example:</strong> An IFV unit attacks an enemy unit on the space next to it. The attacking unit
              fails to destroy the defending unit. The attacking player still has 3 movement points left but cannot
              attack with that unit again during this turn. If the attacking unit was successfull they would move into
              the space they captured and this would count as 1 movement point. The player can still move the unit 2
              more space but cannot attack anymore. If the attacking unit were an MBT it can attack twice in one turn as
              well as move twice.
              <br>
              --Once a unit is locked into combat that unit cannot move until they destroy the enemy or are relieved by
              another unit.
              <br>
              <strong> Example:</strong> A mechanized unit is attacking an infantry unit. They both roll successfull
              hits and neither of them are destroyed, however the mech unit cannot attack again since it only has 1
              attack point. And since the mech unit was unsuccessfull at destroying the infantry the mech is now locked
              in combat with the infantry and cannot move even though it still has 2 movement points left. If during
              that same turn another unit comes along and destroys the infantry they are no longer locked in combat and
              can now move if they wish. If the mech unit was not relieved at the end of the players turn the other
              player can now go on the offensive against the mech unit.
            </p>
            <div class="text-center">
              <h3>Retreat Rules</h3>
            </div>
            <p>
              --The defending/offensive players can retreat by moving there units to first row of tiles closest to
              them and declaring the unit is retreating. They have to remain on that tile for 1 turn in order to retreat
              and be will removed from the board. If the combat board is not being used the retreating player declares
              that they are retreating and the retreating unit will have to survive 1 turn before moving the unit in the
              opposite direction where combat is taking place. Once it is declared that a unit is retreating this cannot
              be undone and the unit will be removed after 1 turn unless it is destroyed.
              <br>
              --Once a unit has retreated the player will move that unit in the opposite direction from where the attack
              came from on the main board. If the opposite tile is water or hostile territory the unit will move to the
              nearest safe tile. If there are no safe tiles the unit cannot retreat.
              <br>
              --Fighter Aircraft can retreat instantly and will be returned to any airfield within range.
              <br>
              --Combat is resolved once all of a players units are destroyed or the attacker/defender retreats from the
              battlefield.
              <br>
              --If both players declare that they want to end combat before all units have been destroyed/retreated then
              combat immediately ends.
              <br>
              --Players involved should keep track of units lost and territory lost during combat and then update their
              economies immediately after the combat phase ends. This means adding and subtracting your resources to
              reflect your casualties and territory lost.
              <br>
              --When a player takes territory from another player they must hold that territory for 1 turn before they
              can claim it. Once claimed they can then roll for resources and draw a card from the item deck.
              <br>
            </p>
            <div class="text-center">
              <h3>Item Card Rules</h3>
            </div>
            <p>
              --Items are cards that are drawn from a pile every time a player takes a territory including territory not
              owned by another player. Players can have as many item cards as they want. Once they are used shuffle them
              back into item deck.
              <br>
              --Item cards are placed face up in front of the player when using an item card at the combat board.
              <br>
              <strong>--Exsplosive Reactive Armor:</strong> This can be used before a battle begins to increase MBT's
              odds of surving a hit. When an MBT takes a hit roll a D12 to determine if the reactive armor deflects the
              shot 1-5 is successful.
              <br>
              <strong>--Laser Designator:</strong> This item can be used beofre a battle to increase the odds of
              artillery hitting its target. Special forces units are required to use the laser designator item. Enemy
              units next to a special forces unit can be lased and give artillery a better chance of hitting their
              target so long as the artillery is within range. Lasing a target does not use up the special forces
              offensive point.
              <br>
              <strong>--Cruise Missile:</strong> This item can be used during a players 3rd phase before or after a
              battle. It cannot be used during a battle. Cruise missiles can be launched from any of the players
              aircraft or cruisers to hit targets as far away as 4 tiles on the MB. Cruise missile hits are determined
              by a D12 (1-10), and they can only be intercepted using the Point Defense item, carrier, or AA. If the
              cruise missile flies over a hostile tile with AA (not including cities) or a carrier the player that owns
              that tile should roll a D12 to try and intercept the missile.
              <br>
              <strong>Point Defense:</strong> The point defense item can be used by a defending player before a battle
              to provide better AA and anti-missile protection. If used on an aircraft D12 1-9 is a hit. Point defense
              can only target 1 unit and is discarded after use regardless of outcome. Defending players can use as many
              point defense cards as they want but will need to declare how many cards they are going to deploy before
              the battle. Item cannot be used during naval battles.
              <br>
              <strong>Aircraft Stealth:</strong> The stealth card can be applied before a battle. This will reverse
              attack
              order of AA and aircraft meaning the aircraft will fire first and then the AA will fire second and also
              reduces the AA hit chance to D12 (1-6). If the AA is destroyed by an aircrafts first shot the AA does not
              get to fire.
              <br>
              <strong>Surplus Fuel:</strong> This item can be used before a battle begins to upgrade mechanized units
              movement. When used mechanized units can now move 3 spaces on the battlefield but can still only attack
              once per turn.
              <br>
              <strong>Paratroopers:</strong> This item card can be used before combat by the offensive player. The
              offensive player can place up to 3 infantry units behind the defending player during the combat board
              set-up phase. This requires the offensive player to have infantry or SF infantry present when the attack
              is initiated. If AA is present then each infantry unit being deployed as paratroopers will have to survive
              one AA attack roll. The AA only gets to shoot once at each paratrooper.
              <br>
              <strong>Javelin Missiles</strong> : This item card equips infantry units (not SF) with effective anti-tank
              weapons. A roll of can be added to all infantry attacks vs MBT's bringing the odds up to 64% chance to
              hit. Does not apply to defense rolls.
            </p>
            <div class="text-center">
              <h3>Event Card Rules</h3>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          </div>
        </div>
      </div>
    </div>
  </section>

</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import CreateRegionForm from "./components/CreateRegionForm.vue";
import Navbar from "./components/Navbar.vue";


export default {
  setup() {
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, CreateRegionForm }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}

body {
  font-family: Impact, 'Arial Narrow Bold', sans-serif;
  letter-spacing: 1px;
  background-color: #606C38;
}

button {
  box-shadow: black 4px 4px;
}

.bg-green {
  background-color: #606c3800;
}
</style>
