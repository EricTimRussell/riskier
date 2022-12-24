<template>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.supplyTruck == 0)" @click="removeSupplyTruck()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <h6 class="px-3"><strong>{{ account.supplyTruck }}</strong></h6>
    <div>
      <button @click="addSupplyTruck()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
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
      async addSupplyTruck() {
        try {
          await landUnitsService.addSupplyTruck()
        } catch (error) {
          Pop.error(error, "Adding SupplyTruck")
        }
      },
      async removeSupplyTruck() {
        try {
          await landUnitsService.removeSupplyTruck()
        } catch (error) {
          Pop.error(error, "Removing SupplyTruck")
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