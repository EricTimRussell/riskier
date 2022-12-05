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
            </p>
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
