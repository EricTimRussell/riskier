<template>

  <body>

    <main class="container-fluid">
      <div class="row">
        <div class="col-12 d-flex flex-column align-items-center">
          <h1>Welcome to Riskier!</h1>
          <p class="px-3">&nbsp;&nbsp;&nbsp;Log in or create an account to get started. You do not need to use a real
            email to create an
            account. Once you have logged in or created an account press "Get Started" to begin. It may be necessary to
            refresh the page in order for the "Get Started" button to appear.</p>
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
import { accountService } from "../services/AccountService";
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";

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
