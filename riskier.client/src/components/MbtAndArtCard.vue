<template>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.mbt == 0)" @click="removeMbt()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex align-items-center">
      <h6 class="px-3 fs-4"><strong>{{ account.mbt }}</strong></h6>
    </div>
    <div>
      <button @click="addMbt()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.artillery == 0)" @click="removeArtillery()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex align-items-center">
      <h6 class="px-3 fs-4"> <strong>{{ account.artillery }} </strong></h6>
    </div>
    <div>
      <button @click="addArtillery()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
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