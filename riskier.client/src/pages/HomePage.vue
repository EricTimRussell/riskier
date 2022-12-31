<template>

  <body>

    <main class="container-fluid">
      <div class="row">
        <div class="col-12 d-flex flex-column align-items-center">
          <h1>Welcome to Riskier!</h1>
          <p class="px-3">&nbsp;&nbsp;&nbsp;Log in or create an account to get started. You do not need to use a real
            email to create an
            account.</p>
          <h2>Quick Setup Instructions</h2>
          <p class="px-3">
            Every faction starts with a capital, 2 medium cities, and 3 small cities. Once you have chosen your starting
            location you now own all the tiles around your capital and can choose 3 more tiles to expand to so long as
            they are adjacent to tiles you already own. You can now place your cities wherever you like within your
            controlled territory. Now press "Get Started" and scroll to the bottom and claim a city for each city and
            claim a region for each tile you own that does not have a city present.
          </p>
        </div>
      </div>
      <div class="col-12 sticky-bottom py-3 d-flex justify-content-center">
        <router-link v-if="account.id" :to="{ name: 'Game', params: { id: account.id } }">
          <button class="btn">Get Started</button>
        </router-link>
      </div>
    </main>
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
  color: #1d1d1d;
  text-shadow: #000000 3px 3px 2px;
  color: whitesmoke;
  min-height: 80vh;
}

button {
  background-color: #FFDA96;
}
</style>
