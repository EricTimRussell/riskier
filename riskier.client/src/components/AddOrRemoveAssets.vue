<template>

  <body>

    <div class="pl col-4">
      <h6>Infantry</h6>
    </div>
    <div class="pl col-4">
      <h6>Elite Inf</h6>
    </div>
    <div class="pl col-4">
      <h6>Mech Inf</h6>
    </div>
    <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
      <button @click="addInfantry()" class="btn btn-outline-dark">+</button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark">-</button>
    </div>
    <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
      <button type="button" class="btn btn-outline-dark">+</button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark">-</button>
    </div>
    <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
      <button type="button" class="btn btn-outline-dark">+</button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark">-</button>
    </div>

  </body>

</template>


<script>
import { assetsService } from "../services/AssetsService";
import Pop from "../utils/Pop";

export default {
  setup() {
    return {
      //SECTION Start Asset Add and Remove Functions
      async addInfantry() {
        try {
          assetsService.addInfantry()
        } catch (error) {
          Pop.error(error, "Add Infantry")
        }
      }


      // SECTION End Asset Add and Remove Functions
    }
  }
}
</script>


<style lang="scss" scoped>

</style>