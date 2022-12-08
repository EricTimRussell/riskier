<template>
  <!-- TODO need to create a component for tracking army/division pieces -->
  <!-- TODO need to add costs for each unit -->

  <body>
    <div class="container-fluid" v-if="account.id">
      <div class="row">
        <div class="col-12 mb-3 text-center">
          <h2>Ground Forces</h2>
        </div>
        <div class="col-6 pl-65">
          <h6>Infantry</h6>
        </div>
        <div class="col-6 px-4">
          <h6>Special Forces</h6>
        </div>
        <div class="px-4">
          <InfantryCard />
        </div>
        <div class="col-6 pl-7 pt-4">
          <h6>Mech</h6>
        </div>
        <div class="col-6 pt-4 pl-65">
          <h6>IFV</h6>
        </div>
        <div class="px-4">
          <MechInfantryCard />
        </div>
        <div class="col-6 pl-7 pt-4">
          <h6>MBT</h6>
        </div>
        <div class="col-6 pt-4 pl-55">
          <h6>Artillery</h6>
        </div>
        <div class="px-4">
          <MbtAndArtCard />
        </div>
        <div class="col-6 pl-6 pt-4">
          <h6>SsArtillery</h6>
        </div>
        <div class="col-6 pt-4 pl-5">
          <h6>AntiAircraft</h6>
        </div>
        <div class="px-4">
          <SsArtilleryAndAntiAircraft />
        </div>
        <div class="col-6 pt-4 pl-6">
          <h6>Supply Truck</h6>
        </div>
        <div class="px-4">
          <SupplyTruckCard />
        </div>
      </div>
      <div class="row">
        <div class="col-12 mt-4 text-center bg-green">
          <h2 class="m-3">AirForce</h2>
        </div>
        <div class="col-6 pt-3 pl-65">
          <h6>Fighter</h6>
        </div>
        <div class="col-6 pt-3 pl-65">
          <h6>CAS</h6>
        </div>
        <div class="px-4">
          <AirUnitsCard />
        </div>
      </div>
      <div class="row">
        <div class="col-12 mt-4 text-center bg-green">
          <h2 class="m-3">Navy</h2>
        </div>
        <div class="col-6 pt-3 pl-7">
          <h6>Carrier</h6>
        </div>
        <div class="col-6 pt-3 pl-55">
          <h6>Cruiser</h6>
        </div>
        <div class="px-4">
          <NavyUnitsCard />
        </div>
      </div>
      <div class="row">
        <div class="col-12 text-center mt-4 bg-green">
          <h2 class="m-3">Buildings</h2>
        </div>
        <div class="col-6 pt-3 pl-7">
          <h6>Airfield</h6>
        </div>
        <div class="col-6 pt-3 pl-5">
          <h6>Naval Yard</h6>
        </div>
        <div class="px-4">
          <BuildingsCard />
        </div>
      </div>
    </div>
    <div class="container-fluid" v-else>
      <div class="row">
        <div class="col-12 text-center">
          <h1>Select Login to Get Started</h1>
        </div>
      </div>
    </div>
    <div class="container-fluid" v-if="account.id">
      <div class="row justify-content-center mt-5">
        <div class="col-12 bg-green">
          <h2 class="text-center m-3">Owned Regions</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-6 col-md-3 d-flex justify-content-evenly my-2" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
    </div>



  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import AirUnitsCard from "../components/AirUnitsCard.vue";
import BuildingsCard from "../components/BuildingsCard.vue";
import InfantryCard from "../components/InfantryCard.vue";
import MbtAndArtCard from "../components/MbtAndArtCard.vue";
import MechInfantryCard from "../components/MechInfantryCard.vue";
import Navbar from "../components/Navbar.vue";
import NavyUnitsCard from "../components/NavyUnitsCard.vue";
import RegionCard from "../components/RegionCard.vue";
import SsArtilleryAndAntiAircraft from "../components/SsArtilleryAndAntiAircraft.vue";
import SupplyTruckCard from "../components/SupplyTruckCard.vue";
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
  components: { RegionCard, Navbar, InfantryCard, MechInfantryCard, MbtAndArtCard, SsArtilleryAndAntiAircraft, SupplyTruckCard, AirUnitsCard, BuildingsCard, NavyUnitsCard }
}
</script>

<style scoped lang="scss">
body {
  background-image: linear-gradient(rgba(0, 0, 0, 0.3),
      rgba(0, 0, 0, 0.3)), url(../assets/img/TopoMap2.jpg);
  background-attachment: fixed;
  background-position: center right;
  color: #1d1d1d;
  text-shadow: #000000 3px 3px 2px;
  color: whitesmoke;
}

.bg-green {
  background-color: #606C38;
}

.pl-7 {
  padding-left: 5rem;
}

.pl-6 {
  padding-left: 4rem;
}

.pl-65 {
  padding-left: 4.5rem;
}

.pl-55 {
  padding-left: 3rem;
}

.pl-5 {
  padding-left: 2.5rem;
}
</style>
