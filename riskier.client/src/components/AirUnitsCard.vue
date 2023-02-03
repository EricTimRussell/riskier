<template>
  <!-- SECTION Fighter Aircraft -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.fighterAircraft <= 0)" @click="removeFighterAircraft()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Fighter Aircraft</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.fighterAircraft }}</strong></h6>
    </div>
    <div>
      <button @click="addFighterAircraft()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">4-<span class="mdi mdi-currency-usd text-warning"></span> 4-<span
        class="mdi mdi-factory text-secondary"></span></span>
  </div>

  <!-- SECTION Close Air Support -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.closeAirSupport <= 0)" @click="removeCloseAirSupport()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Close-Air-Support</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.closeAirSupport }}</strong></h6>
    </div>
    <div>
      <button @click="addCloseAirSupport()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">4-<span class="mdi mdi-currency-usd text-warning"></span> 4-<span
        class="mdi mdi-factory text-secondary"></span></span>
  </div>

  <!-- SECTION Transport aircraft -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.transportAircraft <= 0)" @click="removeTransportAircraft()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Transport Aircraft</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.transportAircraft }}</strong></h6>
    </div>
    <div>
      <button @click="addTransportAircraft()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-2">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
        class="mdi mdi-factory text-secondary"></span></span>
  </div>

</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { airUnitsService } from "../services/AirUnits";
import Pop from "../utils/Pop";

export default {
  setup() {
    return {
      account: computed(() => AppState.account),
      async addFighterAircraft() {
        try {
          await airUnitsService.addFighterAircraft()
        } catch (error) {
          Pop.error(error, "Adding FighterAircraft")
        }
      },

      async removeFighterAircraft() {
        try {
          await airUnitsService.removeFighterAircraft()
        } catch (error) {
          Pop.error(error, "Removing FighterAircraft")
        }
      },

      async addCloseAirSupport() {
        try {
          await airUnitsService.addCloseAirSupport()
        } catch (error) {
          Pop.error(error, "Adding CloseAirSupport")
        }
      },

      async removeCloseAirSupport() {
        try {
          await airUnitsService.removeCloseAirSupport()
        } catch (error) {
          Pop.error(error, "Removing CloseAirSupport")
        }
      },

      async addTransportAircraft() {
        try {
          await airUnitsService.addTransportAircraft()
        } catch (error) {
          Pop.error(error, "Adding TransportAircraft")
        }
      },

      async removeTransportAircraft() {
        try {
          await airUnitsService.removeTransportAircraft()
        } catch (error) {
          Pop.error(error, "Removing TransportAircraft")
        }
      },
    }
  }
}
</script>


<style lang="scss" scoped>
button {
  background: linear-gradient(#FFDA96, #dda15e);
}

button:disabled {
  background-color: #FFDA96;
}

.pl-5 {
  padding-left: 2.5rem;
}
</style>