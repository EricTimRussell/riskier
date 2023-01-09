<template>
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.carrier <= 0)" @click="removeCarrier()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Aircraft Carrier</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.carrier }}</strong></h6>
    </div>
    <div>
      <button @click="addCarrier()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      3-<span class="mdi mdi-barley text-success"></span></span>
  </div>


  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.cruiser <= 0)" @click="removeCruiser()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Cruiser</h6>
      <h6 class="px-3 fs-4"><strong> {{ account.cruiser }} </strong></h6>
    </div>
    <div>
      <button @click="addCruiser()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      3-<span class="mdi mdi-barley text-success"></span></span>
  </div>


  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.destroyer <= 0)" @click="removeDestroyer()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Destroyer</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.destroyer }}</strong></h6>
    </div>
    <div>
      <button @click="addDestroyer()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-2">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      3-<span class="mdi mdi-barley text-success"></span></span>
  </div>
</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { navyUnitsService } from "../services/NavyUnitsService";
import Pop from "../utils/Pop";

export default {
  setup() {
    return {
      account: computed(() => AppState.account),
      async addCarrier() {
        try {
          await navyUnitsService.addCarrier()
        } catch (error) {
          Pop.error(error, "Adding Carrier")
        }
      },
      async removeCarrier() {
        try {
          await navyUnitsService.removeCarrier()
        } catch (error) {
          Pop.error(error, "Removing Carrier")
        }
      },
      async addCruiser() {
        try {
          await navyUnitsService.addCruiser()
        } catch (error) {
          Pop.error(error, "Adding Cruiser")
        }
      },
      async removeCruiser() {
        try {
          await navyUnitsService.removeCruiser()
        } catch (error) {
          Pop.error(error, "Removing Cruiser")
        }
      },
      async addDestroyer() {
        try {
          await navyUnitsService.addDestroyer()
        } catch (error) {
          Pop.error(error, "Adding Destroyer")
        }
      },
      async removeDestroyer() {
        try {
          await navyUnitsService.removeDestroyer()
        } catch (error) {
          Pop.error(error, "Removing Destroyer")
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