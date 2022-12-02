<template>

  <body>

    <div class="d-flex">
      <div class="pl col-4">
        <h5>Infantry</h5>
      </div>
      <div class="pl col-4">
        <h5>Elite Inf</h5>
      </div>
      <div class="pl col-4">
        <h5>Mech Inf</h5>
      </div>
    </div>
    <div class="col-4 btn-group btn-group-sm px-5" role="group" aria-label="Small button group">
      <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
    </div>
    <div class="col-4 btn-group btn-group-sm px-5" role="group" aria-label="Small button group">
      <button type="button" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
    </div>
    <div class="col-4 btn-group btn-group-sm px-5" role="group" aria-label="Small button group">
      <button type="button" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
      <span class="px-3"> 0 </span>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
    </div>

  </body>

</template>


<script>
import { Asset } from "../models/Asset";
import { assetsService } from "../services/AssetsService";
import Pop from "../utils/Pop";

export default {
  // props: {
  //   assets: { type: Asset, required: true }
  // },
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
.pl {
  padding-left: 17.5rem;
}
</style>