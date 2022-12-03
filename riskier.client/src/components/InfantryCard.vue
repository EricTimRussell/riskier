<template>

  <body>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <div>
        <button @click="removeInfantry()" class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
      </div>
      <h6 class="px-3">{{ account.infantry }}</h6>
      <div>
        <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
      </div>
    </div>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <button class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
      <h6 class="px-3"> {{ account.eliteInfantry }} </h6>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
    </div>
  </body>

</template>


<script>
import Pop from "../utils/Pop";
import { landUnitsService } from "../services/LandUnitsService"
import { ref } from "vue";
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";

export default {
  setup() {
    const editable = ref({})
    return {
      editable,
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
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>