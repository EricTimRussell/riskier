<template>

  <body>

    <main class="container-fluid">
      <div class="row">
        <div class="col-12 d-flex flex-column align-items-center">
          <h1>Welcome to Riskier!</h1>
          <p class="px-3">Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint ex fugiat sunt. Commodi
            perferendisd consectetur architecto vel dolorem id, omnis sunt, nesciunt recusandae deserunt esse ducimus
            perspiciatis eius voluptates voluptate.</p>
        </div>
      </div>

    </main>
    <footer class="col-12 sticky-bottom py-3 d-flex justify-content-center">
      <router-link v-if="account.id" :to="{ name: 'Game', params: { id: account.id } }">
        <button class="btn">Get Started</button>
      </router-link>
    </footer>
  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import AirUnitsCard from "../components/AirUnitsCard.vue";
import ArmyCard from "../components/ArmyCard.vue";
import BuildingsCard from "../components/BuildingsCard.vue";
import DivisionsCard from "../components/DivisionsCard.vue";
import InfantryCard from "../components/InfantryCard.vue";
import MbtAndArtCard from "../components/MbtAndArtCard.vue";
import MechInfantryCard from "../components/MechInfantryCard.vue";
import Navbar from "../components/Navbar.vue";
import NavyUnitsCard from "../components/NavyUnitsCard.vue";
import RegionCard from "../components/RegionCard.vue";
import SsArtilleryAndAntiAircraft from "../components/SsArtilleryAndAntiAircraft.vue";
import SupplyTruckCard from "../components/SupplyTruckCard.vue";

export default {
  setup() {
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account),
      divisions: computed(() => AppState.divisions),
      armies: computed(() => AppState.armies)
    };
  },
  components: { RegionCard, Navbar, InfantryCard, MechInfantryCard, MbtAndArtCard, SsArtilleryAndAntiAircraft, SupplyTruckCard, AirUnitsCard, BuildingsCard, NavyUnitsCard, DivisionsCard, ArmyCard }
}
</script>

<style scoped lang="scss">
body {
  background-image: linear-gradient(rgba(0, 0, 0, 0.4),
      rgba(0, 0, 0, 0.4)), url(../assets/img/TopoMap2.jpg);
  background-attachment: fixed;
  background-position: center right;
  background-repeat: none;
  color: #1d1d1d;
  text-shadow: #000000 3px 3px 2px;
  color: whitesmoke;
}

button {
  background-color: #FFDA96;
}
</style>
