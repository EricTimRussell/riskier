<template>
  <body class="container-fluid">
    <div class="row">
      <div class="col-12 my-3 text-center bg-green py-3 elevation-5">
        <h2 class="mdi mdi-tank"> Ground Forces</h2>
      </div>
      <div>
        <InfantryCard />
      </div>
      <div>
        <MechInfantryCard />
      </div>
      <div>
        <MbtAndArtCard />
      </div>
      <div>
        <SsArtilleryAndAntiAircraft />
      </div>
      <!-- <div>
          <SupplyTruckCard />
        </div> -->
    </div>
    <div class="row">
      <div class="col-12 my-4 text-center bg-green elevation-5">
        <h2 class="m-3 mdi mdi-shield-airplane"> AirForce</h2>
      </div>
      <div class="px-4">
        <AirUnitsCard />
      </div>
    </div>
    <div class="row">
      <div class="col-12 my-4 text-center bg-green elevation-5">
        <h2 class="m-3 mdi mdi-ferry"> Navy</h2>
      </div>
      <div class="px-4">
        <NavyUnitsCard />
      </div>
    </div>
    <div class="row">
      <div class="col-12 text-center my-4 bg-green elevation-5">
        <h2 class="m-3 mdi mdi-warehouse"> Buildings</h2>
      </div>
      <div>
        <BuildingsCard />
      </div>
    </div>
    <div class="row bg-green mt-4 pt-3 elevation-5">
      <div class="col-12 d-flex justify-content-center mb-1" v-if="account.id">
        <h2 class="mdi mdi-shield-star"> Armies & Divisions</h2>
      </div>
      <div class="col-12 col-md-6 d-flex justify-content-center mb-4">
        <button class="mx-3 py-2 px-3 rounded text-shadow-dark" data-bs-toggle="modal" data-bs-target="#formDivision"
          aria-label="Form Division">Form
          Division</button>
      </div>
      <div class="col-12 col-md-6 d-flex justify-content-center">
        <button class="mx-3 py-2 px-3 mb-3 rounded text-shadow-dark" data-bs-toggle="modal" data-bs-target="#formArmy"
          aria-label="Form Army">Form Army</button>
      </div>
    </div>
    <div class="row justify-content-center">
      <div class="col-6 col-md-4 col-lg-3 my-3" v-for="d in divisions">
        <DivisionsCard :divisions="d" :key="d.id" />
      </div>
    </div>
    <div class="row justify-content-center" v-if="armies.length > 0 || divisions.length > 0">
      <div class="col-10 col-md-4 col-lg-3 my-3" v-for="a in armies">
        <ArmyCard :armies="a" :key="a.id" />
      </div>
    </div>
    <div v-else class="text-center pt-3">
      <h6>You currently have no armies or divisions.</h6>
    </div>
    <div class="row">
      <div class="col-12 d-flex flex-column align-items-center bg-green elevation-5 mt-4 pt-3">
        <h2 class="mdi mdi-airplane-takeoff"> Carriers</h2>
        <button class="mx-3 py-2 px-3 my-3 rounded text-shadow-dark" data-bs-toggle="modal"
          data-bs-target="#formCarrierGroup" aria-label="Form Carrier Group">Add Carrier Group</button>
      </div>
      <div class="col-12 col-lg-4 d-flex justify-content-center my-3" v-if="carrierGroup.length > 0"
        v-for="c in carrierGroup">
        <CarrierGroupCard :carrierGroup="c" :key="c.id" />
      </div>
      <div class="text-center pt-3" v-else>
        <h6>You currently have no Carriers</h6>
      </div>
    </div>
    <div v-if="account.id">
      <div class="row justify-content-center bg-green elevation-5 mt-5">
        <div class="col-12 mb-1">
          <h2 class="text-center m-3 mdi mdi-map-legend"> Owned Regions</h2>
        </div>
        <div class="col-12 col-md-6 d-flex justify-content-center mb-4">
          <button type="submit" class="rounded text-shadow-dark p-2 mx-3" data-bs-toggle="modal"
            data-bs-target="#createRegion" aria-label="Create Region">
            Claim Region
          </button>
        </div>
        <div class="col-12 col-md-6 d-flex justify-content-center mb-3">
          <button type="submit" class="rounded text-shadow-dark py-2 px-3 mx-3" data-bs-toggle="modal"
            data-bs-target="#createCity" aria-label="Create City">
            Claim City
          </button>
        </div>
      </div>
      <div class="row">
        <div class="col-6 col-md-4 col-lg-2 d-flex justify-content-evenly my-3" v-if="regions.length > 0"
          v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
        <div v-else class="text-center pt-3">
          <h6>Press "Claim Region" to add regions to your owned regions.</h6>
        </div>
      </div>
    </div>
  </body>
</template>

<script>
import { onAuthLoaded } from "@bcwdev/auth0provider-client";
import { computed } from "@vue/reactivity";
import { useRoute } from "vue-router";
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
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";
import { navyUnitsService } from "../services/NavyUnitsService";
import CarrierGroupCard from "../components/CarrierGroupCard.vue";


export default {
  setup() {
    const route = useRoute();

    async function getRegionByOwnerId() {
      try {
        await regionTilesService.getRegionsByOwnerId(route.params.id)
      } catch (error) {
        Pop.error(error, "getting regions by ownerId")
      }
    }
    async function getDivisionByOwnerId() {
      try {
        await armiesDivisionsService.getDivisionByOwnerId(route.params.id)
      } catch (error) {
        Pop.error(error, "Getting Divisions by ownerId")
      }
    }
    async function getArmyByOwnerId() {
      try {
        await armiesDivisionsService.getArmyByOwnerId(route.params.id)
      } catch (error) {
        Pop.error(error, "Getting Armies by ownerId")
      }
    }
    async function getCarrierGroupByOwnerId() {
      try {
        await navyUnitsService.getCarrierGroupByOwnerId(route.params.id)
      } catch (error) {
        Pop.error(error, "Getting Carrier Group")
      }
    }
    // Run these functions when a users auth token has been verified
    onAuthLoaded(() => {
      getRegionByOwnerId()
      getDivisionByOwnerId()
      getArmyByOwnerId()
      getCarrierGroupByOwnerId()
    })
    return {
      // Sort regions by lowest to highest #
      regions: computed(() => AppState.regions.sort((a, b) => a.regionNumber - b.regionNumber)),
      account: computed(() => AppState.account),
      divisions: computed(() => AppState.divisions),
      armies: computed(() => AppState.armies),
      carrierGroup: computed(() => AppState.carrierGroups),

    };
  },
  components: { RegionCard, Navbar, InfantryCard, MechInfantryCard, MbtAndArtCard, SsArtilleryAndAntiAircraft, SupplyTruckCard, AirUnitsCard, BuildingsCard, NavyUnitsCard, DivisionsCard, ArmyCard, CarrierGroupCard }
}
</script>

<style scoped lang="scss">
body {
  color: #1d1d1d;
  text-shadow: #000000 3px 3px 2px;
  color: whitesmoke;
}

.text-shadow-dark {
  color: #1d1d1d;
  text-shadow: whitesmoke 2px 2px;
  background: linear-gradient(#FFDA96, #dda15e);
  letter-spacing: 1px;
}

.bg-green {
  background: linear-gradient(#606c38, #283618)
}

button:active {
  box-shadow: none;
  background: #515151
}

.row {
  margin-right: 0%;
}

.pl-75 {
  padding-left: 5.5rem;
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
