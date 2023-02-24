<template>
  <!-- SECTION ssArtillery also known as Missile Artillery on the board game-->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.ssArtillery <= 0)" @click="removeSsArtillery()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Missile Artillery</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.ssArtillery }}</strong></h6>
    </div>
    <div>
      <button @click="addSsArtillery()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">2-<span class="mdi mdi-currency-usd text-warning"></span> 4-<span
        class="mdi mdi-factory text-secondary"></span></span>
  </div>

  <!-- SECTION Anti-Aircraft -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.antiAircraft <= 0)" @click="removeAntiAircraft()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Anti-Aircraft</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.antiAircraft }}</strong></h6>
    </div>
    <div>
      <button @click="addAntiAircraft()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-2">
    <span class="fs-5">3-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
        class="mdi mdi-factory text-secondary"></span></span>
  </div>
</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { landUnitsService } from "../services/LandUnitsService";
import Pop from "../utils/Pop";

export default {
  setup() {
    return {
      account: computed(() => AppState.account),

      // Also known as missile artillery
      async addSsArtillery() {
        try {
          await landUnitsService.addSsArtillery()
        } catch (error) {
          Pop.error(error, "Adding SsArtillery")
        }
      },

      async removeSsArtillery() {
        try {
          await landUnitsService.removeSsArtillery()
        } catch (error) {
          Pop.error(error, "Removing SsArtillery")
        }
      },

      async addAntiAircraft() {
        try {
          await landUnitsService.addAntiAircraft()
        } catch (error) {
          Pop.error(error, "Adding AntiAircraft")
        }
      },

      async removeAntiAircraft() {
        try {
          await landUnitsService.removeAntiAircraft()
        } catch (error) {
          Pop.error(error, "Removing AntiAircraft")
        }
      }
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

button:active {
  box-shadow: none;
  background: linear-gradient(#606c38, #283618)
}
</style>