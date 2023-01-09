<template>
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.mbt <= 0)" @click="removeMbt()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Main Battle Tank</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.mbt }}</strong></h6>
    </div>
    <div>
      <button @click="addMbt()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">4-<span class="mdi mdi-currency-usd text-warning"></span> 4-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      1-<span class="mdi mdi-barley text-success"></span></span>
  </div>


  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.artillery <= 0)" @click="removeArtillery()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Artillery</h6>
      <h6 class="px-3 fs-4"> <strong>{{ account.artillery }} </strong></h6>
    </div>
    <div>
      <button @click="addArtillery()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd text-warning"></span> 3-<span
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
      async addMbt() {
        try {
          await landUnitsService.addMbt()
        } catch (error) {
          Pop.error(error, "Adding Mbt")
        }
      },
      async removeMbt() {
        try {
          await landUnitsService.removeMbt()
        } catch (error) {
          Pop.error(error, "Removing Mbt")
        }
      },
      async addArtillery() {
        try {
          await landUnitsService.addArtillery()
        } catch (error) {
          Pop.error(error, "Adding Artillery")
        }
      },
      async removeArtillery() {
        try {
          await landUnitsService.removeArtillery()
        } catch (error) {
          Pop.error(error, "Removing Artillery")
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