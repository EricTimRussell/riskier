<template>

  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-6 col-md-3 d-flex justify-content-evenly my-2" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
      <div class="row justify-content-center">
        <div class="col-12 bg-dark">
          <CreateAssetsForm />
          <h1 class="text-center m-3">Assets</h1>
        </div>
      </div>
      <div class="row">
        <div class="d-flex">
          <div class="col-4 text-center">
            <h6>Infantry</h6>
          </div>
          <div class="col-4 text-center">
            <h6>Elite Inf</h6>
          </div>
          <div class="col-4 text-center">
            <h6>Mech Inf</h6>
          </div>
        </div>
        <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
          <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
          <h6 class="px-2"> {{ assets.infantry }} </h6>
          <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
        </div>
        <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
          <button type="button" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
          <span class="px-2"> {{ assets.eliteInfantry }} </span>
          <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
        </div>
        <div class="col-4 btn-group btn-group-sm" role="group" aria-label="Small button group">
          <button type="button" class="btn btn-outline-dark mdi mdi-minus fs-4"></button>
          <span class="px-2"> {{ assets.mech }} </span>
          <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-4"></button>
        </div>
      </div>
    </div>



  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import AddOrRemoveAssets from "../components/AddOrRemoveAssets.vue";
import CreateAssetsForm from "../components/CreateAssetsForm.vue";
import Navbar from "../components/Navbar.vue";
import RegionCard from "../components/RegionCard.vue";
import { assetsService } from "../services/AssetsService";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";

export default {
  setup() {
    async function getAssets() {
      try {
        await assetsService.getAssets()
      } catch (error) {
        Pop.error(error, "Getting asssets")
      }
    }

    async function getAllRegions() {
      try {
        await regionTilesService.getAllRegions()
      } catch (error) {
        Pop.error(error, "getting all regions")
      }
    }
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account),
      assets: computed(() => AppState.assets)
    };
  },
  components: { RegionCard, Navbar, CreateAssetsForm, AddOrRemoveAssets }
}
</script>

<style scoped lang="scss">

</style>
