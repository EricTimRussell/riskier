<template>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeMech()" class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
    </div>
    <h6 class="px-3">{{ account.mech }}</h6>
    <div>
      <button @click="addMech()" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
    </div>
  </div>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeIfv()" class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
    </div>
    <h6 class="px-3"> {{ account.ifv }} </h6>
    <div>
      <button @click="addIfv()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
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

</style>