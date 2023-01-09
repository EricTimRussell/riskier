<template>

  <body>
    <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group"
      aria-label="Small button group">
      <div>
        <button :disabled="(account.infantry <= 0)" @click="removeInfantry()"
          class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
      </div>
      <div class="d-flex flex-column align-items-center">
        <h6 class="px-2">Infantry</h6>
        <h6 class="px-2 fs-4"><strong>{{ account.infantry }}</strong></h6>
      </div>
      <div>
        <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
      </div>
    </div>
    <div class="col-12 d-flex justify-content-center mb-5">
      <span class="fs-4">1-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
          class="mdi mdi-factory px-1 text-secondary"></span>
        3-<span class="mdi mdi-barley text-success"></span></span>
    </div>


    <div class="col-12 btn-group btn-group-sm px-2 d-flex justify-content-center" role="group"
      aria-label="Small button group">
      <div>
        <button :disabled="(account.specialForces <= 0)" @click="removeSpecialForces()"
          class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
      </div>
      <div class="d-flex flex-column align-items-center">
        <h6 class="px-2">Special Forces</h6>
        <h6 class="px-3 fs-4"><strong>{{ account.specialForces }}</strong></h6>
      </div>
      <div>
        <button @click="addSpecialForces()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
      </div>
    </div>
    <div class="col-12 d-flex justify-content-center mb-5">
      <span class="fs-4">3-<span class="mdi mdi-currency-usd text-warning"></span> 1-<span
          class="mdi mdi-factory px-1 text-secondary"></span>
        3-<span class="mdi mdi-barley text-success"></span></span>
    </div>
  </body>

</template>


<script>
import Pop from "../utils/Pop";
import { landUnitsService } from "../services/LandUnitsService"
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";

export default {
  setup() {
    return {
      account: computed(() => AppState.account),
      async addInfantry() {
        try {
          await landUnitsService.addInfantry()
        } catch (error) {
          Pop.error(error, "Adding Infantry")
        }
      },
      async removeInfantry() {
        try {
          await landUnitsService.removeInfantry()
        } catch (error) {
          Pop.error(error, "Removing Infantry")
        }
      },
      async addSpecialForces() {
        try {
          await landUnitsService.addSpecialForces()
        } catch (error) {
          Pop.error(error, "Adding SpecialForces")
        }
      },
      async removeSpecialForces() {
        try {
          await landUnitsService.removeSpecialForces()
        } catch (error) {
          Pop.error(error, "Removing SpecialForces")
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
</style>