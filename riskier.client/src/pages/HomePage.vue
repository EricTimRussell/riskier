<template>

  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-6 col-md-3 d-flex justify-content-evenly my-2" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
      <div class="row justify-content-center">
        <div class="col-12 bg-dark">
          <h1 class="text-center m-3">Assets</h1>
        </div>
      </div>
      <div class="row">
        <div class="d-flex">
          <div class="col-6 text-center">
            <h6>Infantry</h6>
          </div>
          <div class="col-6 px-4">
            <h6>Special Forces</h6>
          </div>
        </div>
        <div class="px-4">
          <InfantryCard />
        </div>
        <div class="col-6 text-center pt-4">
          <h6>Mech Infantry</h6>
        </div>
        <div class="col-6 text-center pt-4">
          <h6>IFV</h6>
        </div>
        <div class="px-4">
          <MechInfantryCard />
        </div>
      </div>
    </div>



  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import InfantryCard from "../components/InfantryCard.vue";
import MechInfantryCard from "../components/MechInfantryCard.vue";
import Navbar from "../components/Navbar.vue";
import RegionCard from "../components/RegionCard.vue";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";

export default {
  setup() {
    async function getAllRegions() {
      try {
        await regionTilesService.getAllRegions()
      } catch (error) {
        Pop.error(error, "getting all regions")
      }
    }
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account),
    };
  },
  components: { RegionCard, Navbar, InfantryCard, MechInfantryCard }
}
</script>

<style scoped lang="scss">

</style>
