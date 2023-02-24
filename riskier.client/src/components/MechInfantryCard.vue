<template>
  <!-- SECTION Mechanized Infantry -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.mech <= 0)" @click="removeMech()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Mechanized Infantry</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.mech }}</strong></h6>
    </div>
    <div>
      <button @click="addMech()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-4">2-<span class="mdi mdi-currency-usd text-warning"></span> 2-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      3-<span class="mdi mdi-barley text-success"></span></span>
  </div>

  <!-- SECTION Infantry Fighting Vehicle -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.ifv <= 0)" @click="removeIfv()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-1">Infantry Fighting Vehicle</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.ifv }} </strong></h6>
    </div>
    <div>
      <button @click="addIfv()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-4">3-<span class="mdi mdi-currency-usd text-warning"></span> 3-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      1-<span class="mdi mdi-barley text-success"></span></span>
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

      // Mech = Mechanized Infantry
      async addMech() {
        try {
          await landUnitsService.addMech()
        } catch (error) {
          Pop.error(error, "Adding Mech")
        }
      },

      async removeMech() {
        try {
          await landUnitsService.removeMech()
        } catch (error) {
          Pop.error(error, "Removing Mech")
        }
      },

      // IFV = Infantry Fighting Vehicle
      async addIfv() {
        try {
          await landUnitsService.addIfv()
        } catch (error) {
          Pop.error(error, "Adding Ifv")
        }
      },

      async removeIfv() {
        try {
          await landUnitsService.removeIfv()
        } catch (error) {
          Pop.error(error, "Removing Ifv")
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