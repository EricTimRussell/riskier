<template>

  <body>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <div>
        <button :disabled="(account.infantry == 0)" @click="removeInfantry()"
          class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
      </div>
      <div>
        <h6 class="px-3"><strong>{{ account.infantry }}</strong></h6>
      </div>
      <div>
        <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
      </div>
    </div>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <div>
        <button :disabled="(account.specialForces == 0)" @click="removeSpecialForces()"
          class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
      </div>
      <h6 class="px-3"><strong>{{ account.specialForces }}</strong></h6>
      <div>
        <button @click="addSpecialForces()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
      </div>
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
  background-color: #FFDA96;
}

button:disabled {
  background-color: #FFDA96;
}
</style>